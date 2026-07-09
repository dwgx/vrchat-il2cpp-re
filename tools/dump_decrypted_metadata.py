"""
Dump decrypted VRChat IL2CPP metadata at runtime via Frida.

Two strategies for capturing the decrypted global-metadata.dat:

Strategy 1 (hook-based): Install an Interceptor at RVA 0xA8822C inside the
  metadata init function (RVA 0xA87BF0). At that instruction the register rdx
  holds the pointer to the fully-decrypted metadata buffer. We read rdx and
  dump from there.

Strategy 2 (memory scan): After VRChat is fully loaded, scan the process
  heap for a ~40 MB region whose first 4 bytes are 0x73 0x79 0x6D 0x2D
  ("sym-"). This avoids hooking and works even if metadata was loaded before
  we attached.

Execution order: try Strategy 2 first (fast, no side effects). If it finds
nothing, fall back to Strategy 1 and wait for the metadata load path to fire.

Output: D:\\Project\\vrchat-il2cpp-re\\data\\metadata_decrypted.dat

Static analysis references (GameAssembly.dll):
  RVA 0xA87BF0 - metadata init function (2728 bytes)
  RVA 0xA881D0 - call to metadata_loader (mmaps global-metadata.dat)
  RVA 0xA881D5 - stores raw/mmap pointer in global
  RVA 0xA88225 - loads the processed (decrypted) buffer pointer into rdx
  RVA 0xA8822C - movups xmm1, [rdx] reads first 16 bytes
  RVA 0xA88247 - cmp eax, 0x2D6D7973 checks magic "sym-"
"""

import frida
import sys
import os
import struct
import time
import ctypes
import subprocess

# ---------------------------------------------------------------------------
# Configuration
# ---------------------------------------------------------------------------

OUTPUT_PATH = r"D:\Project\vrchat-il2cpp-re\data\metadata_decrypted.dat"
PROCESS_NAME = "VRChat.exe"

# Metadata magic bytes (little-endian u32 for "sym-")
METADATA_MAGIC = 0x2D6D7973
METADATA_MAGIC_BYTES = b"\x73\x79\x6D\x2D"  # "sym-"

# Expected metadata size bounds
MIN_METADATA_SIZE = 4 * 1024 * 1024       # 4 MB minimum
MAX_METADATA_SIZE = 80 * 1024 * 1024      # 80 MB maximum
DEFAULT_DUMP_SIZE = 50 * 1024 * 1024      # 50 MB default read

# Memory scan chunk size (keep RSS low)
SCAN_CHUNK_SIZE = 4 * 1024 * 1024         # 4 MB per scan chunk

# RVAs
RVA_METADATA_INIT = 0xA87BF0
RVA_MOVUPS_READ = 0xA8822C   # movups xmm1, [rdx] -- rdx = decrypted buf
RVA_MAGIC_CMP = 0xA88247     # cmp eax, 0x2D6D7973

# Hook timeout
HOOK_TIMEOUT_SEC = 120

# ---------------------------------------------------------------------------
# Frida agent source -- Strategy 1 (hooking)
# ---------------------------------------------------------------------------

AGENT_SOURCE = r"""
'use strict';

var MAGIC = 0x2d6d7973;
var MAX_DUMP = %%MAX_DUMP%%;
var MIN_SIZE = %%MIN_SIZE%%;

// Resolve GameAssembly base
var ga = Process.getModuleByName("GameAssembly.dll");
var base = ga.base;

send({t: 'log', m: 'GameAssembly.dll base: ' + base});
send({t: 'log', m: 'Module size: ' + ga.size});

// ---- Strategy 2: Memory scan for "sym-" pattern in committed pages ----

function scanForMetadata() {
    send({t: 'log', m: '[scan] Starting memory scan for decrypted metadata...'});

    var pattern = '73 79 6D 2D';  // "sym-"
    var found = null;

    // Scan within GameAssembly's readable sections first (fast path)
    // The global pointer references heap memory, so scan all readable ranges
    var ranges = Process.enumerateRanges('r--');
    send({t: 'log', m: '[scan] Enumerated ' + ranges.length + ' readable ranges'});

    for (var i = 0; i < ranges.length; i++) {
        var range = ranges[i];
        // Skip small ranges (metadata is at least MIN_SIZE)
        if (range.size < MIN_SIZE) continue;
        // Skip very large ranges to avoid OOM (e.g. mapped GPU memory)
        if (range.size > 512 * 1024 * 1024) continue;

        try {
            var matches = Memory.scanSync(range.base, range.size, pattern);
            for (var j = 0; j < matches.length; j++) {
                var addr = matches[j].address;
                // Verify: read bytes 4-7, should be a valid version field
                // IL2CPP metadata version is typically 24-29
                var version = addr.add(4).readS32();
                if (version >= 20 && version <= 50) {
                    // Additional check: stringLiteralOffset at offset 8
                    // should be a reasonable offset (> 0x100 and < filesize)
                    var strLitOff = addr.add(8).readU32();
                    if (strLitOff > 0x100 && strLitOff < range.size) {
                        send({t: 'log', m: '[scan] FOUND candidate at ' + addr +
                              ' version=' + version + ' strLitOff=0x' + strLitOff.toString(16)});
                        found = {addr: addr, rangeSize: range.size, rangeBase: range.base};
                        break;
                    }
                }
            }
        } catch (e) {
            // Access violation on guard pages etc -- skip
        }
        if (found) break;
    }

    if (found) {
        dumpFromAddress(found.addr, found.rangeSize, found.rangeBase);
    } else {
        send({t: 'log', m: '[scan] No decrypted metadata found in memory. Installing hooks...'});
        installHooks();
    }
}

// ---- Dump logic ----

function dumpFromAddress(addr, rangeSize, rangeBase) {
    // Determine actual metadata size from the header
    // IL2CPP GlobalMetadataHeader has a known layout. We can estimate size
    // from the last offset+count pair, or just dump up to end of the range.
    var offsetFromBase = addr.sub(rangeBase).toInt32();
    var maxAvailable = rangeSize - offsetFromBase;
    var dumpSize = Math.min(maxAvailable, MAX_DUMP);

    send({t: 'log', m: '[dump] Address: ' + addr});
    send({t: 'log', m: '[dump] Available in range: ' + maxAvailable + ' bytes'});
    send({t: 'log', m: '[dump] Will dump: ' + dumpSize + ' bytes'});

    // Attempt to find actual end by scanning header offset/count pairs
    // The header is typically 0x108 bytes (IL2CPP v29) containing pairs of
    // (offset, count/size) for each table. The maximum offset+size = file end.
    var realSize = estimateMetadataSize(addr, dumpSize);
    if (realSize > 0 && realSize <= dumpSize) {
        send({t: 'log', m: '[dump] Estimated real size from header: ' + realSize + ' bytes'});
        dumpSize = realSize;
    }

    // Dump in chunks to keep memory pressure low
    var CHUNK = 4 * 1024 * 1024;  // 4 MB
    var offset = 0;
    var chunks = [];

    while (offset < dumpSize) {
        var thisChunk = Math.min(CHUNK, dumpSize - offset);
        var data = addr.add(offset).readByteArray(thisChunk);
        send({t: 'chunk', offset: offset, total: dumpSize}, data);
        offset += thisChunk;
    }

    send({t: 'done', size: dumpSize});
}

function estimateMetadataSize(addr, maxRead) {
    // Read first 0x110 bytes (header) and find the largest offset + size
    try {
        var headerSize = 0x110;
        if (headerSize > maxRead) return 0;
        var hdr = addr.readByteArray(headerSize);
        var view = new DataView(hdr);

        // Skip magic (4) + version (4) = start at offset 8
        // Each entry is (offset:u32, size/count:u32) = 8 bytes per pair
        var maxEnd = 0;
        for (var off = 8; off + 8 <= headerSize; off += 8) {
            var tableOffset = view.getUint32(off, true);
            var tableSize = view.getUint32(off + 4, true);
            var end = tableOffset + tableSize;
            if (end > maxEnd && tableOffset < 0x10000000 && tableSize < 0x10000000) {
                maxEnd = end;
            }
        }

        if (maxEnd > MIN_SIZE && maxEnd < MAX_DUMP) {
            // Align up to 4K page
            return (maxEnd + 0xFFF) & ~0xFFF;
        }
    } catch (e) {
        send({t: 'log', m: '[size] Error estimating: ' + e});
    }
    return 0;
}

// ---- Strategy 1: Hook-based ----

function installHooks() {
    // Hook at RVA 0xA8822C: movups xmm1, [rdx]
    // At this point rdx = pointer to decrypted metadata buffer
    var hookAddr = base.add(0xA8822C);
    send({t: 'log', m: '[hook] Installing at ' + hookAddr + ' (RVA 0xA8822C)'});

    Interceptor.attach(hookAddr, {
        onEnter: function(args) {
            var rdx = this.context.rdx;
            send({t: 'log', m: '[hook] Hit! rdx = ' + rdx});

            try {
                var magic = rdx.readU32();
                send({t: 'log', m: '[hook] First dword: 0x' + magic.toString(16)});

                if (magic === MAGIC) {
                    send({t: 'log', m: '[hook] Magic matches -- metadata is decrypted'});
                    // Find the range this address belongs to
                    var ranges = Process.enumerateRanges('r--');
                    var rangeSize = MAX_DUMP;
                    var rangeBase = rdx;
                    for (var i = 0; i < ranges.length; i++) {
                        var r = ranges[i];
                        var rEnd = r.base.add(r.size);
                        if (rdx.compare(r.base) >= 0 && rdx.compare(rEnd) < 0) {
                            rangeSize = r.size;
                            rangeBase = r.base;
                            break;
                        }
                    }
                    dumpFromAddress(rdx, rangeSize, rangeBase);
                    // Unhook after successful dump
                    Interceptor.detachAll();
                } else {
                    send({t: 'log', m: '[hook] Magic mismatch -- buffer may still be encrypted'});
                    send({t: 'log', m: '[hook] Trying alternate: read global at RVA offset'});

                    // Try the alternate global pointer (0xA88225 loads from [rip+0xC97B624])
                    // Compute absolute address of the global
                    var globalRip = base.add(0xA8822B);  // next instruction after 0xA88225 (7-byte mov)
                    var ripOffset = 0xC97B624;  // from disassembly
                    var globalAddr = globalRip.add(ripOffset);
                    send({t: 'log', m: '[hook] Global pointer at: ' + globalAddr});

                    try {
                        var bufPtr = globalAddr.readPointer();
                        send({t: 'log', m: '[hook] Global points to: ' + bufPtr});
                        var altMagic = bufPtr.readU32();
                        send({t: 'log', m: '[hook] Alt buffer magic: 0x' + altMagic.toString(16)});
                        if (altMagic === MAGIC) {
                            var ranges2 = Process.enumerateRanges('r--');
                            var rs = MAX_DUMP, rb = bufPtr;
                            for (var j = 0; j < ranges2.length; j++) {
                                var r2 = ranges2[j];
                                if (bufPtr.compare(r2.base) >= 0 &&
                                    bufPtr.compare(r2.base.add(r2.size)) < 0) {
                                    rs = r2.size; rb = r2.base; break;
                                }
                            }
                            dumpFromAddress(bufPtr, rs, rb);
                            Interceptor.detachAll();
                        }
                    } catch (e2) {
                        send({t: 'log', m: '[hook] Alt read failed: ' + e2});
                    }
                }
            } catch (e) {
                send({t: 'log', m: '[hook] Error reading rdx: ' + e});
            }
        }
    });

    send({t: 'log', m: '[hook] Hooks active. Waiting for metadata init...'});
    send({t: 'hooks_installed'});
}

// ---- Entry point ----
// Small delay to let module list stabilize
setTimeout(function() {
    scanForMetadata();
}, 500);
"""

# ---------------------------------------------------------------------------
# Python host
# ---------------------------------------------------------------------------


class MetadataDumper:
    def __init__(self):
        self.chunks = {}
        self.total_size = 0
        self.done = False
        self.hooks_installed = False
        self.session = None
        self.script = None

    def find_vrchat_pid(self):
        """Auto-detect VRChat.exe PID."""
        # Try tasklist on Windows
        try:
            result = subprocess.run(
                ["tasklist", "/FI", f"IMAGENAME eq {PROCESS_NAME}", "/FO", "CSV", "/NH"],
                capture_output=True, text=True, timeout=5
            )
            for line in result.stdout.strip().split('\n'):
                if PROCESS_NAME.lower() in line.lower():
                    # CSV format: "name","pid","session","session#","mem"
                    parts = line.strip().strip('"').split('","')
                    if len(parts) >= 2:
                        return int(parts[1])
        except Exception:
            pass

        # Fallback: use frida enumerate
        try:
            for proc in frida.enumerate_processes():
                if proc.name.lower() == PROCESS_NAME.lower():
                    return proc.pid
        except Exception:
            pass

        return None

    def attach(self):
        """Attach Frida to VRChat."""
        pid = self.find_vrchat_pid()
        if pid is None:
            print("[-] VRChat.exe not found. Make sure it is running.")
            print("    Launch with: python tools/deploy_to_steam.py")
            sys.exit(1)

        print(f"[+] Found {PROCESS_NAME} (PID {pid})")
        print(f"[+] Attaching Frida...")

        try:
            self.session = frida.attach(pid)
        except frida.ProcessNotFoundError:
            print(f"[-] Could not attach to PID {pid}. Process may have exited.")
            sys.exit(1)
        except frida.PermissionDeniedError:
            print("[-] Permission denied. Run as Administrator.")
            sys.exit(1)

        print(f"[+] Attached successfully.")

    def inject(self):
        """Inject the agent script."""
        source = AGENT_SOURCE.replace("%%MAX_DUMP%%", str(MAX_METADATA_SIZE))
        source = source.replace("%%MIN_SIZE%%", str(MIN_METADATA_SIZE))

        self.script = self.session.create_script(source)
        self.script.on('message', self._on_message)
        self.script.on('destroyed', self._on_destroyed)
        self.script.load()
        print("[+] Agent injected.")

    def _on_destroyed(self):
        if not self.done:
            print("[-] Script destroyed unexpectedly.")

    def _on_message(self, message, data):
        if message['type'] == 'error':
            print(f"[!] Agent error: {message.get('description', message)}")
            if 'stack' in message:
                for line in message['stack'].split('\n')[:5]:
                    print(f"    {line}")
            return

        if message['type'] != 'send':
            return

        payload = message['payload']
        msg_type = payload.get('t')

        if msg_type == 'log':
            print(f"    {payload['m']}")

        elif msg_type == 'hooks_installed':
            self.hooks_installed = True

        elif msg_type == 'chunk':
            offset = payload['offset']
            total = payload['total']
            self.total_size = total
            self.chunks[offset] = data
            pct = int((offset + len(data)) / total * 100)
            mb_done = (offset + len(data)) / (1024 * 1024)
            mb_total = total / (1024 * 1024)
            print(f"    [chunk] {mb_done:.1f}/{mb_total:.1f} MB ({pct}%)")

        elif msg_type == 'done':
            self.total_size = payload['size']
            self._write_output()
            self.done = True

    def _write_output(self):
        """Assemble chunks and write to disk."""
        if not self.chunks:
            print("[-] No data received.")
            return

        print(f"[+] Assembling {len(self.chunks)} chunks ({self.total_size} bytes)...")
        os.makedirs(os.path.dirname(OUTPUT_PATH), exist_ok=True)

        with open(OUTPUT_PATH, 'wb') as f:
            offset = 0
            while offset < self.total_size:
                chunk = self.chunks.get(offset)
                if chunk is None:
                    print(f"[-] Missing chunk at offset {offset}!")
                    break
                f.write(chunk)
                offset += len(chunk)

        actual_size = os.path.getsize(OUTPUT_PATH)
        print(f"[+] Written: {OUTPUT_PATH}")
        print(f"    Size: {actual_size:,} bytes ({actual_size / (1024*1024):.2f} MB)")

        self._verify()

    def _verify(self):
        """Verify dumped metadata has valid structure."""
        print("[+] Verifying dump...")
        try:
            with open(OUTPUT_PATH, 'rb') as f:
                header = f.read(0x110)
        except OSError as e:
            print(f"[-] Cannot read output: {e}")
            return False

        if len(header) < 16:
            print("[-] File too small.")
            return False

        magic = struct.unpack_from('<I', header, 0)[0]
        if magic != METADATA_MAGIC:
            print(f"[-] FAILED: magic = 0x{magic:08X}, expected 0x{METADATA_MAGIC:08X}")
            return False

        version = struct.unpack_from('<i', header, 4)[0]
        print(f"    Magic: OK (0x{magic:08X} = \"sym-\")")
        print(f"    Version: {version}")

        if not (20 <= version <= 50):
            print(f"[-] WARNING: version {version} outside expected range [20, 50]")

        # Parse a few header fields
        str_lit_offset = struct.unpack_from('<I', header, 8)[0]
        str_lit_size = struct.unpack_from('<I', header, 12)[0]
        print(f"    stringLiteral offset: 0x{str_lit_offset:X}, size: {str_lit_size:,}")

        # Sanity: stringLiteral offset should be > header and < filesize
        file_size = os.path.getsize(OUTPUT_PATH)
        if str_lit_offset < 0x100 or str_lit_offset > file_size:
            print(f"[-] WARNING: stringLiteral offset looks wrong")
        else:
            print(f"    Structure looks valid.")

        # Count how many table entries have reasonable offsets
        valid_tables = 0
        for i in range(8, min(0x108, len(header)), 8):
            off = struct.unpack_from('<I', header, i)[0]
            sz = struct.unpack_from('<I', header, i + 4)[0]
            if 0 < off < file_size and sz < file_size:
                valid_tables += 1

        print(f"    Valid table entries in header: {valid_tables}/32")

        if valid_tables >= 10:
            print("[+] VERIFICATION PASSED")
            return True
        else:
            print("[-] WARNING: fewer valid tables than expected")
            return False

    def run(self):
        """Main execution loop."""
        self.attach()
        self.inject()

        print("[+] Waiting for metadata dump...")
        start = time.time()
        timeout = HOOK_TIMEOUT_SEC

        try:
            while not self.done:
                time.sleep(0.5)
                elapsed = time.time() - start
                if self.hooks_installed and elapsed > timeout:
                    print(f"[-] Timeout after {timeout}s waiting for hook to fire.")
                    print("    The metadata may have already been loaded before attach.")
                    print("    Try restarting VRChat and running this script earlier.")
                    break
        except KeyboardInterrupt:
            print("\n[+] Interrupted by user.")
        finally:
            if self.session:
                try:
                    self.session.detach()
                except Exception:
                    pass
                print("[+] Detached from process.")

        if self.done:
            return 0
        return 1


# ---------------------------------------------------------------------------
# Entry point
# ---------------------------------------------------------------------------

def main():
    print("=" * 60)
    print("  VRChat Metadata Runtime Dump")
    print("  Strategy 2 (scan) then Strategy 1 (hook)")
    print("=" * 60)
    print()

    dumper = MetadataDumper()
    sys.exit(dumper.run())


if __name__ == '__main__':
    main()
