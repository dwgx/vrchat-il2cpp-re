#!/usr/bin/env python3
"""
Photon Realtime Protocol Packet Capture & Analyzer
---------------------------------------------------
Captures VRChat Photon UDP packets WITHOUT process modification.
Zero footprint — uses raw socket or pcap to sniff network traffic.

Usage:
    python tools/photon_packet_capture.py [--interface <name>] [--duration <seconds>]
    python tools/photon_packet_capture.py --file <pcap_file>

Requirements:
    pip install scapy
    Run as Administrator (raw socket access)
"""

import sys, json, struct, time, argparse, os
from pathlib import Path
from collections import defaultdict
from datetime import datetime

sys.stdout.reconfigure(encoding='utf-8')

# ── Photon Protocol Constants ──────────────────────────────────────────

# Photon operation codes (ExitGames Photon Realtime)
PHOTON_OPCODES = {
    # Authentication
    230: 'Authenticate',
    231: 'AuthenticateOnce',
    229: 'JoinLobby',
    228: 'LeaveLobby',
    227: 'JoinRandomGame',
    226: 'JoinGame',
    225: 'CreateGame',
    224: 'LeaveGame',
    # Room operations
    253: 'RaiseEvent',
    252: 'SetProperties',
    251: 'GetProperties',
    250: 'ChangeGroups',
    248: 'ServerSettings',
    # Status
    254: 'Ping',
    # Events
    255: 'EventData',
}

# Photon event codes used by VRChat
VRC_EVENT_CODES = {
    1: 'Voice',
    6: 'Serialization',  # Player sync data
    7: 'InstantiatePRC',
    33: 'CacheInstantiation',
    200: 'DestroyObject',
    201: 'DestroyPlayer',
    202: 'UpdateFrequency',
    203: 'CloseConnection',
    # VRChat custom
    40: 'VRC_ModerationEvent',
    60: 'VRC_Udon',
    70: 'VRC_StringLoad',
    # RPC
    9: 'RPC',
}

# Photon message types
MSG_TYPES = {
    0: 'Init',
    1: 'InitResponse',
    2: 'Operation',
    3: 'OperationResponse',
    4: 'Event',
    6: 'InternalOp',
    7: 'InternalOpResponse',
    8: 'Message',
    9: 'RawMessage',
}

# Photon peer connection state
PHOTON_PORTS = {5055, 5056, 5058, 27000, 27001, 27002, 27003, 27004, 27005,
                5057, 4530, 4531, 4532, 4533}  # Standard Photon + VRChat ports

# VRChat specific ports (Photon regions)
VRC_PHOTON_SERVERS = [
    'ns.photonengine.io',      # Name server
    '*.photonengine.io',       # Regional
    '*.exitgames.com',         # Legacy
]


class PhotonPacketParser:
    """Parse Photon Realtime protocol packets."""

    def __init__(self):
        self.stats = defaultdict(int)
        self.auth_data = []
        self.events = []
        self.operations = []
        self.rpc_calls = []
        self.sync_data = []

    def parse_photon_header(self, data: bytes) -> dict | None:
        """Parse Photon UDP packet header."""
        if len(data) < 12:
            return None

        try:
            # Photon header: peerID(2) + crcCheck(1) + commandCount(1) + timestamp(4) + challenge(4)
            peer_id = struct.unpack('>H', data[0:2])[0]
            flags = data[2]
            cmd_count = data[3]
            timestamp = struct.unpack('>I', data[4:8])[0]
            challenge = struct.unpack('>i', data[8:12])[0]

            return {
                'peer_id': peer_id,
                'flags': flags,
                'cmd_count': cmd_count,
                'timestamp': timestamp,
                'challenge': challenge,
                'has_crc': bool(flags & 0xCC),
            }
        except Exception:
            return None

    def parse_photon_command(self, data: bytes, offset: int) -> tuple[dict | None, int]:
        """Parse a single Photon command from the packet."""
        if offset + 12 > len(data):
            return None, len(data)

        try:
            cmd_type = data[offset]
            channel = data[offset + 1]
            cmd_flags = data[offset + 2]
            # reserved = data[offset + 3]
            cmd_length = struct.unpack('>I', data[offset + 4:offset + 8])[0]
            seq_num = struct.unpack('>I', data[offset + 8:offset + 12])[0]

            cmd = {
                'type': cmd_type,
                'channel': channel,
                'flags': cmd_flags,
                'length': cmd_length,
                'seq': seq_num,
            }

            # Command types:
            # 1=Acknowledge, 4=Disconnect, 5=Ping, 6=SendReliable,
            # 7=SendUnreliable, 8=SendFragment, 11=SendUnreliableProcessed
            if cmd_type in (6, 7, 11) and offset + 12 < offset + cmd_length:
                # Has message payload
                msg_offset = offset + 12
                if cmd_type == 6:
                    msg_offset += 4  # Reliable has fragment count

                if msg_offset < offset + cmd_length and msg_offset < len(data):
                    msg = self._parse_photon_message(data, msg_offset, offset + cmd_length)
                    if msg:
                        cmd['message'] = msg

            next_offset = offset + max(cmd_length, 12)
            return cmd, next_offset

        except Exception:
            return None, len(data)

    def _parse_photon_message(self, data: bytes, offset: int, end: int) -> dict | None:
        """Parse Photon message payload (operation/event)."""
        if offset >= end or offset >= len(data):
            return None

        try:
            # Message header: magicByte + msgType + operationCode
            if data[offset] == 0xF3:  # Photon magic byte
                msg_type = data[offset + 1]
                msg = {
                    'msg_type': msg_type,
                    'msg_type_name': MSG_TYPES.get(msg_type, f'Unknown({msg_type})'),
                }

                if msg_type in (2, 3):  # Operation / OperationResponse
                    op_code = data[offset + 2]
                    msg['op_code'] = op_code
                    msg['op_name'] = PHOTON_OPCODES.get(op_code, f'Op_{op_code}')
                    if msg_type == 3:
                        # Response has return code
                        if offset + 4 <= end:
                            msg['return_code'] = struct.unpack('>h', data[offset + 3:offset + 5])[0]

                elif msg_type == 4:  # Event
                    event_code = data[offset + 2]
                    msg['event_code'] = event_code
                    msg['event_name'] = VRC_EVENT_CODES.get(event_code, f'Event_{event_code}')

                return msg

            elif data[offset] == 0xFB:  # Encrypted
                return {'msg_type': -1, 'msg_type_name': 'Encrypted', 'encrypted': True}

        except Exception:
            pass
        return None

    def process_packet(self, src_ip: str, dst_ip: str, src_port: int, dst_port: int,
                       data: bytes, timestamp: float = 0):
        """Process a single UDP packet."""
        self.stats['total_packets'] += 1
        self.stats['total_bytes'] += len(data)

        header = self.parse_photon_header(data)
        if not header:
            return

        self.stats['photon_packets'] += 1
        direction = 'OUT' if src_port > 10000 else 'IN'

        offset = 12
        if header['has_crc']:
            offset += 4  # Skip CRC

        for i in range(header['cmd_count']):
            cmd, offset = self.parse_photon_command(data, offset)
            if not cmd:
                break

            self.stats[f'cmd_type_{cmd["type"]}'] += 1

            msg = cmd.get('message')
            if not msg:
                continue

            record = {
                'time': timestamp or time.time(),
                'direction': direction,
                'src': f'{src_ip}:{src_port}',
                'dst': f'{dst_ip}:{dst_port}',
                'peer_id': header['peer_id'],
                **msg,
            }

            # Track by type
            if msg.get('encrypted'):
                self.stats['encrypted_messages'] += 1
            elif msg['msg_type'] in (2, 3):
                self.stats['operations'] += 1
                self.operations.append(record)
                op_code = msg.get('op_code', 0)
                self.stats[f'op_{msg.get("op_name", op_code)}'] += 1

                if op_code in (230, 231):
                    self.auth_data.append(record)
            elif msg['msg_type'] == 4:
                self.stats['events'] += 1
                self.events.append(record)
                evt_code = msg.get('event_code', 0)
                self.stats[f'evt_{msg.get("event_name", evt_code)}'] += 1

                if evt_code == 9:
                    self.rpc_calls.append(record)
                elif evt_code == 6:
                    self.sync_data.append(record)

    def get_summary(self) -> dict:
        """Generate analysis summary."""
        return {
            'capture_stats': dict(self.stats),
            'auth_events': len(self.auth_data),
            'total_operations': len(self.operations),
            'total_events': len(self.events),
            'rpc_calls': len(self.rpc_calls),
            'sync_packets': len(self.sync_data),
            'operation_types': {k: v for k, v in self.stats.items() if k.startswith('op_')},
            'event_types': {k: v for k, v in self.stats.items() if k.startswith('evt_')},
        }


def capture_live(interface: str = None, duration: int = 60):
    """Live capture using scapy."""
    try:
        from scapy.all import sniff, UDP, IP
    except ImportError:
        print('[!] scapy not installed. Install: pip install scapy')
        print('[!] Also need Npcap on Windows: https://npcap.com/')
        return None

    parser = PhotonPacketParser()
    start_time = time.time()

    def packet_handler(pkt):
        if not pkt.haslayer(UDP) or not pkt.haslayer(IP):
            return

        udp = pkt[UDP]
        ip = pkt[IP]

        # Filter for Photon ports
        if udp.sport not in PHOTON_PORTS and udp.dport not in PHOTON_PORTS:
            # Also check high ephemeral ports (client side)
            if udp.sport < 49152 and udp.dport < 49152:
                return

        payload = bytes(udp.payload)
        if len(payload) < 12:
            return

        parser.process_packet(
            ip.src, ip.dst, udp.sport, udp.dport,
            payload, float(pkt.time)
        )

        # Progress indicator
        elapsed = time.time() - start_time
        if parser.stats['photon_packets'] % 100 == 0:
            print(f'\r  [{elapsed:.0f}s] Photon: {parser.stats["photon_packets"]} pkts, '
                  f'Ops: {parser.stats["operations"]}, Events: {parser.stats["events"]}, '
                  f'Encrypted: {parser.stats["encrypted_messages"]}', end='', flush=True)

    print(f'[*] Starting live capture (duration={duration}s)')
    if interface:
        print(f'    Interface: {interface}')
    print(f'    Filtering: Photon UDP ports + VRChat traffic')
    print(f'    Press Ctrl+C to stop early\n')

    try:
        sniff(
            filter='udp',
            prn=packet_handler,
            iface=interface,
            timeout=duration,
            store=0,
        )
    except KeyboardInterrupt:
        print('\n[*] Capture interrupted by user')
    except Exception as e:
        print(f'\n[!] Capture error: {e}')

    print()
    return parser


def analyze_pcap(filepath: str):
    """Analyze a saved pcap file."""
    try:
        from scapy.all import rdpcap, UDP, IP
    except ImportError:
        print('[!] scapy not installed')
        return None

    parser = PhotonPacketParser()
    print(f'[*] Reading {filepath}...')

    packets = rdpcap(filepath)
    for pkt in packets:
        if not pkt.haslayer(UDP) or not pkt.haslayer(IP):
            continue
        udp = pkt[UDP]
        ip = pkt[IP]
        payload = bytes(udp.payload)
        if len(payload) >= 12:
            parser.process_packet(
                ip.src, ip.dst, udp.sport, udp.dport,
                payload, float(pkt.time)
            )

    return parser


def print_report(parser: PhotonPacketParser, output_path: str = None):
    """Print and optionally save analysis report."""
    summary = parser.get_summary()

    print('\n' + '=' * 60)
    print('  PHOTON PACKET ANALYSIS REPORT')
    print('=' * 60)

    print(f'\n  Total packets:     {summary["capture_stats"].get("total_packets", 0):,}')
    print(f'  Photon packets:    {summary["capture_stats"].get("photon_packets", 0):,}')
    print(f'  Total bytes:       {summary["capture_stats"].get("total_bytes", 0):,}')
    print(f'  Encrypted msgs:    {summary["capture_stats"].get("encrypted_messages", 0):,}')

    print(f'\n  Operations:        {summary["total_operations"]:,}')
    for k, v in sorted(summary['operation_types'].items()):
        print(f'    {k[3:]}: {v}')

    print(f'\n  Events:            {summary["total_events"]:,}')
    for k, v in sorted(summary['event_types'].items()):
        print(f'    {k[4:]}: {v}')

    print(f'\n  Auth events:       {summary["auth_events"]}')
    print(f'  RPC calls:         {summary["rpc_calls"]}')
    print(f'  Sync packets:      {summary["sync_packets"]}')

    if parser.auth_data:
        print(f'\n  --- Auth Flow ---')
        for auth in parser.auth_data[:10]:
            print(f'    [{auth["direction"]}] {auth.get("op_name", "?")} '
                  f'retCode={auth.get("return_code", "N/A")} '
                  f'{auth["src"]} -> {auth["dst"]}')

    if output_path:
        base = Path(output_path)
        report_data = {
            'summary': summary,
            'auth_events': parser.auth_data[:50],
            'operations': parser.operations[:200],
            'events': parser.events[:200],
            'rpc_calls': parser.rpc_calls[:100],
            'captured_at': datetime.now().isoformat(),
        }
        with open(base, 'w', encoding='utf-8') as f:
            json.dump(report_data, f, indent=2, default=str)
        print(f'\n  Report saved: {base}')

    print('=' * 60)


def main():
    parser = argparse.ArgumentParser(description='Photon Packet Capture & Analyzer')
    parser.add_argument('--interface', '-i', help='Network interface for live capture')
    parser.add_argument('--duration', '-d', type=int, default=120, help='Capture duration (seconds)')
    parser.add_argument('--file', '-f', help='Analyze existing pcap file')
    parser.add_argument('--output', '-o', default=None,
                        help='Output JSON report path (default: output/photon_capture.json)')
    args = parser.parse_args()

    if args.output is None:
        base = Path(__file__).resolve().parent.parent / 'output'
        args.output = str(base / 'photon_capture.json')

    if args.file:
        result = analyze_pcap(args.file)
    else:
        result = capture_live(args.interface, args.duration)

    if result:
        print_report(result, args.output)


if __name__ == '__main__':
    main()
