#!/usr/bin/env python3
"""Probe early VRChat startup waits with Frida."""

from __future__ import annotations

import json
import subprocess
import sys
import time
import ctypes
from collections import Counter, OrderedDict
from pathlib import Path

import frida

sys.stdout.reconfigure(encoding="utf-8")

VRCHAT_EXE = r"D:\WorkSpace\VRChat\VRChat.exe"
VRCHAT_CWD = r"D:\WorkSpace\VRChat"
SCRIPT_PATH = Path(__file__).resolve()
RAW_LOG_PATH = SCRIPT_PATH.with_name("probe_wait_raw.log")
WAIT_SECONDS = 60
VERSION_WAIT_RVA = 0x4C186A

HOOK_JS = r"""
'use strict';

var waitSeq = 1;

function sendEvent(payload) {
    send(payload);
}

function currentTid() {
    return Process.getCurrentThreadId();
}

function moduleOffset(address) {
    try {
        var m = Process.findModuleByAddress(address);
        if (m)
            return m.name + '+0x' + address.sub(m.base).toString(16);
    } catch (e) {}
    return ptr(address).toString();
}

function captureStack(context, depth) {
    try {
        return Thread.backtrace(context, Backtracer.ACCURATE)
            .slice(0, depth)
            .map(moduleOffset);
    } catch (e) {
        return ['<bt-error:' + e.message + '>'];
    }
}

function captureThreadStack(thread, depth) {
    try {
        return Thread.backtrace(thread.context || null, Backtracer.FUZZY)
            .slice(0, depth)
            .map(moduleOffset);
    } catch (e) {
        return ['<thread-bt-error:' + e.message + '>'];
    }
}

function regString(regValue) {
    if (regValue === undefined || regValue === null)
        return null;
    try {
        return ptr(regValue).toString();
    } catch (e) {
        return String(regValue);
    }
}

function ptrString(value) {
    try {
        return ptr(value).toString();
    } catch (e) {
        return String(value);
    }
}

function readAnsi(ptrValue) {
    try {
        if (ptrValue.isNull())
            return null;
        return ptrValue.readAnsiString();
    } catch (e) {
        return '<ansi-error:' + e.message + '>';
    }
}

function readUtf16(ptrValue) {
    try {
        if (ptrValue.isNull())
            return null;
        return ptrValue.readUtf16String();
    } catch (e) {
        return '<utf16-error:' + e.message + '>';
    }
}

function readUnicodeString(usPtr) {
    try {
        if (usPtr.isNull())
            return null;
        var length = usPtr.readU16();
        var buffer = usPtr.add(0x8).readPointer();
        if (buffer.isNull())
            return null;
        if (length === 0)
            return '';
        return buffer.readUtf16String(length / 2);
    } catch (e) {
        return '<unicode-error:' + e.message + '>';
    }
}

function readObjectAttributesName(objectAttributesPtr) {
    try {
        if (objectAttributesPtr.isNull())
            return null;
        var usPtr = objectAttributesPtr.add(0x10).readPointer();
        return readUnicodeString(usPtr);
    } catch (e) {
        return '<oa-error:' + e.message + '>';
    }
}

function describeTimeout(timeoutPtr) {
    if (timeoutPtr.isNull()) {
        return { kind: 'infinite', value: null, ptr: '0x0' };
    }
    try {
        var value = timeoutPtr.readS64().toString();
        var kind = value[0] === '-' ? 'relative' : 'absolute';
        return { kind: kind, value: value, ptr: timeoutPtr.toString() };
    } catch (e) {
        return { kind: 'unreadable', value: e.message, ptr: timeoutPtr.toString() };
    }
}

function readHandleArray(handlesPtr, countValue) {
    var handles = [];
    var count = 0;
    try {
        count = parseInt(countValue);
    } catch (e) {
        count = 0;
    }
    if (!isFinite(count) || count < 0)
        count = 0;
    var limit = Math.min(count, 16);
    for (var i = 0; i < limit; i++) {
        try {
            handles.push(handlesPtr.add(i * Process.pointerSize).readPointer().toString());
        } catch (e) {
            handles.push('<handle-read-error:' + e.message + '>');
        }
    }
    if (count > limit)
        handles.push('...+' + (count - limit));
    return handles;
}

function looksLikePipe(name) {
    if (name === null)
        return false;
    var lower = String(name).toLowerCase();
    return lower.indexOf('\\pipe\\') !== -1 || lower.indexOf('namedpipe') !== -1;
}

function firstVersionFrame(stack) {
    for (var i = 0; i < stack.length; i++) {
        if (String(stack[i]).toLowerCase().indexOf('version.dll+') === 0)
            return stack[i];
    }
    return null;
}

function hookWait(moduleName, exportName, onEnterBuilder) {
    var address = Module.findGlobalExportByName(moduleName, exportName);
    if (address === null)
        return;
    Interceptor.attach(address, {
        onEnter: function (args) {
            var details = onEnterBuilder.call(this, args) || {};
            var stack = captureStack(this.context, 6);
            var payload = {
                ev: 'wait_enter',
                id: waitSeq++,
                api: exportName,
                module: moduleName,
                tid: currentTid(),
                stack: stack,
                version_frame: firstVersionFrame(stack),
                return_address: moduleOffset(this.returnAddress)
            };
            for (var key in details)
                payload[key] = details[key];
            this.__waitId = payload.id;
            sendEvent(payload);
        },
        onLeave: function (retval) {
            if (this.__waitId === undefined)
                return;
            sendEvent({
                ev: 'wait_leave',
                id: this.__waitId,
                tid: currentTid(),
                api: exportName,
                module: moduleName,
                status: retval.toString()
            });
        }
    });
}

function hookNamedHandle(moduleName, exportName, typeName, nameReader, nameArgIndex) {
    var address = Module.findGlobalExportByName(moduleName, exportName);
    if (address === null)
        return;
    Interceptor.attach(address, {
        onEnter: function (args) {
            this.__tid = currentTid();
            this.__name = nameReader(args[nameArgIndex]);
            this.__stack = captureStack(this.context, 6);
        },
        onLeave: function (retval) {
            if (retval.isNull())
                return;
            sendEvent({
                ev: 'handle_name',
                api: exportName,
                module: moduleName,
                type: typeName,
                handle: retval.toString(),
                name: this.__name,
                tid: this.__tid,
                stack: this.__stack
            });
        }
    });
}

hookWait('ntdll.dll', 'NtWaitForSingleObject', function (args) {
    return {
        handle: ptrString(args[0]),
        timeout: describeTimeout(args[2]),
        wait_target: ptrString(args[0]),
        alertable: !!args[1].toInt32()
    };
});

hookWait('ntdll.dll', 'NtWaitForMultipleObjects', function (args) {
    var count = parseInt(args[0]);
    var handles = readHandleArray(args[1], count);
    return {
        count: count,
        handles: handles,
        timeout: describeTimeout(args[3]),
        wait_type: args[2].toInt32(),
        alertable: !!args[4].toInt32(),
        wait_target: handles.join(',')
    };
});

hookWait('ntdll.dll', 'NtSignalAndWaitForSingleObject', function (args) {
    return {
        signal_handle: ptrString(args[0]),
        handle: ptrString(args[1]),
        timeout: describeTimeout(args[3]),
        alertable: !!args[2].toInt32(),
        wait_target: ptrString(args[1])
    };
});

hookWait('kernelbase.dll', 'WaitForSingleObjectEx', function (args) {
    return {
        handle: ptrString(args[0]),
        timeout: { kind: 'millis', value: args[1].toUInt32().toString(), ptr: null },
        alertable: !!args[2].toInt32(),
        wait_target: ptrString(args[0])
    };
});

hookWait('kernelbase.dll', 'WaitForSingleObject', function (args) {
    return {
        handle: ptrString(args[0]),
        timeout: { kind: 'millis', value: args[1].toUInt32().toString(), ptr: null },
        alertable: false,
        wait_target: ptrString(args[0])
    };
});

hookWait('kernelbase.dll', 'WaitForMultipleObjectsEx', function (args) {
    var count = args[0].toInt32();
    var handles = readHandleArray(args[1], count);
    return {
        count: count,
        handles: handles,
        timeout: { kind: 'millis', value: args[3].toUInt32().toString(), ptr: null },
        wait_type: !!args[2].toInt32() ? 1 : 0,
        alertable: !!args[4].toInt32(),
        wait_target: handles.join(',')
    };
});

hookWait('kernelbase.dll', 'SignalObjectAndWait', function (args) {
    return {
        signal_handle: ptrString(args[0]),
        handle: ptrString(args[1]),
        timeout: { kind: 'millis', value: args[2].toUInt32().toString(), ptr: null },
        alertable: !!args[3].toInt32(),
        wait_target: ptrString(args[1])
    };
});

hookNamedHandle('kernelbase.dll', 'CreateEventW', 'Event', readUtf16, 3);
hookNamedHandle('kernelbase.dll', 'CreateEventA', 'Event', readAnsi, 3);
hookNamedHandle('kernelbase.dll', 'CreateMutexW', 'Mutex', readUtf16, 2);
hookNamedHandle('kernelbase.dll', 'CreateMutexA', 'Mutex', readAnsi, 2);
hookNamedHandle('kernelbase.dll', 'CreateSemaphoreW', 'Semaphore', readUtf16, 3);
hookNamedHandle('kernelbase.dll', 'CreateSemaphoreA', 'Semaphore', readAnsi, 3);
hookNamedHandle('kernelbase.dll', 'OpenEventW', 'Event', readUtf16, 2);

function hookNtObjectCreate(exportName, typeName) {
    var address = Module.findGlobalExportByName('ntdll.dll', exportName);
    if (address === null)
        return;
    Interceptor.attach(address, {
        onEnter: function (args) {
            this.__out = args[0];
            this.__tid = currentTid();
            this.__name = readObjectAttributesName(args[2]);
            this.__stack = captureStack(this.context, 6);
        },
        onLeave: function (retval) {
            try {
                if (retval.toInt32() < 0 || this.__out.isNull())
                    return;
                sendEvent({
                    ev: 'handle_name',
                    api: exportName,
                    module: 'ntdll.dll',
                    type: typeName,
                    handle: this.__out.readPointer().toString(),
                    name: this.__name,
                    tid: this.__tid,
                    stack: this.__stack
                });
            } catch (e) {
                sendEvent({
                    ev: 'probe_error',
                    where: exportName + '.onLeave',
                    error: e.message
                });
            }
        }
    });
}

hookNtObjectCreate('NtCreateEvent', 'Event');
hookNtObjectCreate('NtOpenEvent', 'Event');
hookNtObjectCreate('NtCreateMutant', 'Mutex');
hookNtObjectCreate('NtOpenMutant', 'Mutex');
hookNtObjectCreate('NtCreateSemaphore', 'Semaphore');
hookNtObjectCreate('NtOpenSemaphore', 'Semaphore');

var ntCreateFile = Module.findGlobalExportByName('ntdll.dll', 'NtCreateFile');
if (ntCreateFile !== null) {
    Interceptor.attach(ntCreateFile, {
        onEnter: function (args) {
            this.__fileHandleOut = args[0];
            this.__tid = currentTid();
            this.__name = readObjectAttributesName(args[2]);
            this.__stack = captureStack(this.context, 6);
        },
        onLeave: function (retval) {
            try {
                if (retval.toInt32() < 0 || this.__fileHandleOut.isNull())
                    return;
                var handle = this.__fileHandleOut.readPointer().toString();
                sendEvent({
                    ev: 'handle_name',
                    api: 'NtCreateFile',
                    module: 'ntdll.dll',
                    type: looksLikePipe(this.__name) ? 'Pipe' : 'File',
                    handle: handle,
                    name: this.__name,
                    tid: this.__tid,
                    stack: this.__stack
                });
            } catch (e) {
                sendEvent({
                    ev: 'probe_error',
                    where: 'NtCreateFile.onLeave',
                    error: e.message
                });
            }
        }
    });
}

function disassembleAround(target) {
    function findEndingInstruction(targetAddress, preferCalls) {
        var matches = [];
        for (var back = 1; back <= 16; back++) {
            var candidate = targetAddress.sub(back);
            try {
                var insn = Instruction.parse(candidate);
                if (insn.next.equals(targetAddress))
                    matches.push(insn);
            } catch (e) {}
        }
        if (matches.length === 0)
            return null;
        if (preferCalls) {
            for (var i = matches.length - 1; i >= 0; i--) {
                if (matches[i].mnemonic.indexOf('call') === 0)
                    return matches[i];
            }
        }
        return matches[matches.length - 1];
    }

    var previous = findEndingInstruction(target, true);
    var lines = [];
    if (previous !== null) {
        lines.push(moduleOffset(previous.address) + ': ' + previous.toString() + '  ; previous-ending-at-target');
    } else {
        lines.push('<no-previous-instruction-ending-at-target>');
    }
    var current = target;
    for (var j = 0; j < 10; j++) {
        try {
            var insn = Instruction.parse(current);
            lines.push((j === 0 ? '>> ' : '') + moduleOffset(insn.address) + ': ' + insn.toString());
            current = insn.next;
        } catch (e) {
            lines.push('!! ' + ptr(current).toString() + ': ' + e.message);
            break;
        }
    }
    return {
        previous: previous !== null ? moduleOffset(previous.address) + ': ' + previous.toString() : null,
        lines: lines
    };
}

rpc.exports = {
    threadsnapshot: function () {
        return Process.enumerateThreads().map(function (thread) {
            var top = captureThreadStack(thread, 10);
            return {
                tid: thread.id,
                state: thread.state,
                stack: top,
                context: {
                    rip: regString(thread.context ? thread.context.rip : null),
                    rsp: regString(thread.context ? thread.context.rsp : null),
                    rbp: regString(thread.context ? thread.context.rbp : null),
                    rcx: regString(thread.context ? thread.context.rcx : null),
                    rdx: regString(thread.context ? thread.context.rdx : null),
                    r8: regString(thread.context ? thread.context.r8 : null),
                    r9: regString(thread.context ? thread.context.r9 : null)
                }
            };
        });
    },
    disasmversion: function (rvaText) {
        var version = Process.findModuleByName('VERSION.dll');
        var target = version.base.add(ptr(rvaText).toUInt32());
        var disasm = disassembleAround(target);
        return {
            base: version.base.toString(),
            target: target.toString(),
            previous: disasm.previous,
            lines: disasm.lines
        };
    }
};

sendEvent({ ev: 'ready' });
"""


def powershell(command: str, timeout_ms: int = 10000) -> str:
    result = subprocess.run(
        ["powershell", "-NoProfile", "-Command", command],
        capture_output=True,
        text=True,
        timeout=timeout_ms / 1000,
    )
    return result.stdout


kernel32 = ctypes.windll.kernel32
ntdll = ctypes.windll.ntdll

PROCESS_DUP_HANDLE = 0x0040
PROCESS_QUERY_LIMITED_INFORMATION = 0x1000
DUPLICATE_SAME_ACCESS = 0x00000002

kernel32.GetCurrentProcess.restype = ctypes.c_void_p
kernel32.OpenProcess.argtypes = [ctypes.c_uint32, ctypes.c_int, ctypes.c_uint32]
kernel32.OpenProcess.restype = ctypes.c_void_p
kernel32.DuplicateHandle.argtypes = [
    ctypes.c_void_p,
    ctypes.c_void_p,
    ctypes.c_void_p,
    ctypes.POINTER(ctypes.c_void_p),
    ctypes.c_uint32,
    ctypes.c_int,
    ctypes.c_uint32,
]
kernel32.DuplicateHandle.restype = ctypes.c_int
kernel32.CloseHandle.argtypes = [ctypes.c_void_p]
kernel32.CloseHandle.restype = ctypes.c_int
ntdll.NtQueryObject.argtypes = [
    ctypes.c_void_p,
    ctypes.c_int,
    ctypes.c_void_p,
    ctypes.c_ulong,
    ctypes.POINTER(ctypes.c_ulong),
]
ntdll.NtQueryObject.restype = ctypes.c_long

CURRENT_PROCESS = kernel32.GetCurrentProcess()


def read_unicode_from_buffer(buffer: ctypes.Array[ctypes.c_byte]) -> str | None:
    raw = ctypes.string_at(ctypes.addressof(buffer), len(buffer))
    length = int.from_bytes(raw[:2], "little", signed=False)
    if length == 0:
        return ""
    ptr_size = ctypes.sizeof(ctypes.c_void_p)
    ptr_offset = 8 if ptr_size == 8 else 4
    raw_ptr = int.from_bytes(raw[ptr_offset : ptr_offset + ptr_size], "little", signed=False)
    if raw_ptr == 0:
        return None
    return ctypes.wstring_at(raw_ptr, length // 2)


def nt_query_object_text(handle: int, info_class: int) -> str | None:
    size = 0x400
    while size <= 0x10000:
        buffer = (ctypes.c_byte * size)()
        return_length = ctypes.c_ulong()
        status = ntdll.NtQueryObject(
            ctypes.c_void_p(handle),
            ctypes.c_int(info_class),
            ctypes.byref(buffer),
            ctypes.c_ulong(size),
            ctypes.byref(return_length),
        )
        if status == 0:
            return read_unicode_from_buffer(buffer)
        if status == 0xC0000004:
            size = max(size * 2, return_length.value + 0x100)
            continue
        return None
    return None


def query_remote_handle(pid: int, handle_text: str) -> dict | None:
    if not handle_text or not handle_text.startswith("0x"):
        return None
    remote_process = kernel32.OpenProcess(
        PROCESS_DUP_HANDLE | PROCESS_QUERY_LIMITED_INFORMATION,
        False,
        pid,
    )
    if not remote_process:
        return None
    duplicated = ctypes.c_void_p()
    try:
        ok = kernel32.DuplicateHandle(
            ctypes.c_void_p(remote_process),
            ctypes.c_void_p(int(handle_text, 16)),
            ctypes.c_void_p(CURRENT_PROCESS),
            ctypes.byref(duplicated),
            0,
            False,
            DUPLICATE_SAME_ACCESS,
        )
        if not ok:
            return None
        dup_handle = duplicated.value
        type_name = nt_query_object_text(dup_handle, 2)
        object_name = nt_query_object_text(dup_handle, 1)
        return {
            "handle": handle_text,
            "type": type_name,
            "name": object_name,
            "source": "NtQueryObject",
        }
    finally:
        if duplicated.value:
            kernel32.CloseHandle(ctypes.c_void_p(duplicated.value))
        kernel32.CloseHandle(ctypes.c_void_p(remote_process))


def list_vrchat_pids() -> list[int]:
    output = powershell(
        "Get-Process VRChat -ErrorAction SilentlyContinue | Select-Object -ExpandProperty Id"
    )
    pids = []
    for line in output.splitlines():
        line = line.strip()
        if line.isdigit():
            pids.append(int(line))
    return pids


def kill_all_vrchat() -> None:
    subprocess.run(
        ["taskkill", "/F", "/IM", "VRChat.exe"],
        capture_output=True,
        text=True,
        timeout=10,
    )


def first_version_frame(stack: list[str]) -> str | None:
    for frame in stack:
        if frame.lower().startswith("version.dll+"):
            return frame
    return None


def first_non_wait_frame(stack: list[str]) -> str | None:
    skip_prefixes = (
        "ntdll.dll+",
        "kernelbase.dll+",
        "kernel32.dll+",
        "wow64",
    )
    for frame in stack:
        lower = frame.lower()
        if lower.startswith(skip_prefixes):
            continue
        return frame
    return stack[0] if stack else None


def normalize_timeout(timeout: dict | None) -> str:
    if not timeout:
        return "unknown"
    kind = timeout.get("kind", "unknown")
    value = timeout.get("value")
    if value is None:
        return kind
    return f"{kind}:{value}"


def parse_hex_int(value: str | None) -> int | None:
    if not value or not isinstance(value, str):
        return None
    try:
        return int(value, 16)
    except ValueError:
        return None


def resolve_handle(handle: str | None, handle_map: dict[str, dict]) -> str:
    if not handle:
        return "?"
    meta = handle_map.get(handle)
    if not meta:
        return handle
    parts = [handle, meta.get("type", "?")]
    name = meta.get("name")
    if name:
        parts.append(name)
    creator_tid = meta.get("tid")
    if creator_tid is not None:
        parts.append(f"creator_tid={creator_tid}")
    return " | ".join(parts)


def resolve_wait_target(event: dict, handle_map: dict[str, dict]) -> str:
    api = event.get("api")
    if api in {"NtWaitForMultipleObjects", "WaitForMultipleObjectsEx"}:
        handles = event.get("handles", [])
        return "; ".join(resolve_handle(handle, handle_map) for handle in handles)
    if api in {"NtSignalAndWaitForSingleObject", "SignalObjectAndWait"}:
        wait_desc = resolve_handle(event.get("handle"), handle_map)
        signal_desc = resolve_handle(event.get("signal_handle"), handle_map)
        return f"wait={wait_desc}; signal={signal_desc}"
    return resolve_handle(event.get("handle"), handle_map)


def make_wait_signature(event: dict) -> str:
    handles = event.get("handles")
    if handles is not None:
        handle_sig = ",".join(handles)
    else:
        handle_sig = event.get("handle") or ""
    signal_handle = event.get("signal_handle") or ""
    caller = first_version_frame(event.get("stack", [])) or first_non_wait_frame(event.get("stack", [])) or "?"
    return "|".join(
        [
            event.get("api", "?"),
            str(event.get("tid", "?")),
            handle_sig,
            signal_handle,
            normalize_timeout(event.get("timeout")),
            caller,
        ]
    )


def dump_log(
    path: Path,
    handle_map: dict[str, dict],
    wait_aggs: OrderedDict[str, dict],
    outstanding: dict[int, dict],
    latest_wait_by_thread: dict[int, dict],
    version_waits: list[dict],
    thread_snapshot: list[dict],
    disasm: dict,
    errors: list[dict],
) -> None:
    lines: list[str] = []
    lines.append("== Handles ==")
    for handle, meta in sorted(handle_map.items()):
        name = meta.get("name")
        creator = first_non_wait_frame(meta.get("stack", []))
        lines.append(
            f"{handle} type={meta.get('type')} name={name!r} tid={meta.get('tid')} creator={creator}"
        )

    lines.append("")
    lines.append("== Aggregated Waits ==")
    for agg in wait_aggs.values():
        event = agg["sample"]
        lines.append(
            f"{event['api']} tid={event['tid']} enter={agg['enter']} leave={agg['leave']} "
            f"target={resolve_wait_target(event, handle_map)} timeout={normalize_timeout(event.get('timeout'))} "
            f"caller={first_version_frame(event.get('stack', [])) or first_non_wait_frame(event.get('stack', []))} "
            f"ret={event.get('return_address')}"
        )
        for frame in event.get("stack", []):
            lines.append(f"  {frame}")

    lines.append("")
    lines.append("== Outstanding Waits ==")
    for wait_id, event in sorted(outstanding.items()):
        lines.append(
            f"id={wait_id} api={event['api']} tid={event['tid']} "
            f"target={resolve_wait_target(event, handle_map)} timeout={normalize_timeout(event.get('timeout'))} "
            f"caller={first_version_frame(event.get('stack', [])) or first_non_wait_frame(event.get('stack', []))} "
            f"ret={event.get('return_address')}"
        )

    lines.append("")
    lines.append("== Latest Wait Per Thread ==")
    for tid, event in sorted(latest_wait_by_thread.items()):
        lines.append(
            f"tid={tid} api={event['api']} target={resolve_wait_target(event, handle_map)} "
            f"timeout={normalize_timeout(event.get('timeout'))}"
        )

    lines.append("")
    lines.append("== VERSION Waits ==")
    for event in version_waits:
        lines.append(
            f"id={event['id']} api={event['api']} tid={event['tid']} "
            f"version={event.get('version_frame')} target={resolve_wait_target(event, handle_map)} "
            f"timeout={normalize_timeout(event.get('timeout'))} ret={event.get('return_address')}"
        )

    lines.append("")
    lines.append("== Thread Snapshot ==")
    for thread in sorted(thread_snapshot, key=lambda item: item["tid"]):
        ctx = thread.get("context", {})
        lines.append(
            f"tid={thread['tid']} state={thread.get('state')} "
            f"rip={ctx.get('rip')} rcx={ctx.get('rcx')} rdx={ctx.get('rdx')} r8={ctx.get('r8')}"
        )
        for frame in thread.get("stack", []):
            lines.append(f"  {frame}")

    lines.append("")
    lines.append("== VERSION Disasm ==")
    lines.append(
        f"base={disasm.get('base')} target={disasm.get('target')} previous={disasm.get('previous')}"
    )
    for line in disasm.get("lines", []):
        lines.append(line)

    if errors:
        lines.append("")
        lines.append("== Probe Errors ==")
        for error in errors:
            lines.append(json.dumps(error, ensure_ascii=False))

    path.write_text("\n".join(lines) + "\n", encoding="utf-8")


def summarize_for_stdout(
    handle_map: dict[str, dict],
    outstanding: dict[int, dict],
    latest_wait_by_thread: dict[int, dict],
) -> None:
    print("[probe] latest waits per thread:", flush=True)
    for tid, event in sorted(latest_wait_by_thread.items()):
        print(
            f"  tid={tid} {event['api']} target={resolve_wait_target(event, handle_map)} "
            f"timeout={normalize_timeout(event.get('timeout'))}",
            flush=True,
        )
    print("[probe] outstanding waits:", flush=True)
    for wait_id, event in sorted(outstanding.items()):
        print(
            f"  id={wait_id} tid={event['tid']} {event['api']} target={resolve_wait_target(event, handle_map)} "
            f"timeout={normalize_timeout(event.get('timeout'))}",
            flush=True,
        )


def main() -> int:
    existing_pids = list_vrchat_pids()
    if existing_pids:
        print(f"[probe] refusing to start with existing VRChat.exe PIDs: {existing_pids}", flush=True)
        return 2

    handle_map: dict[str, dict] = {}
    wait_aggs: OrderedDict[str, dict] = OrderedDict()
    outstanding: dict[int, dict] = {}
    latest_wait_by_thread: dict[int, dict] = {}
    version_waits: list[dict] = []
    errors: list[dict] = []

    session = None
    script = None
    pid = None

    def on_message(message, data):
        if message.get("type") == "send":
            payload = message.get("payload", {})
            event_type = payload.get("ev")
            if event_type == "handle_name":
                handle_map[payload["handle"]] = payload
            elif event_type == "wait_enter":
                outstanding[payload["id"]] = payload
                latest_wait_by_thread[payload["tid"]] = payload
                if payload.get("version_frame"):
                    version_waits.append(payload)
                sig = make_wait_signature(payload)
                agg = wait_aggs.setdefault(sig, {"enter": 0, "leave": 0, "sample": payload, "statuses": Counter()})
                agg["enter"] += 1
            elif event_type == "wait_leave":
                event = outstanding.pop(payload["id"], None)
                if event is not None:
                    sig = make_wait_signature(event)
                    agg = wait_aggs.setdefault(sig, {"enter": 0, "leave": 0, "sample": event, "statuses": Counter()})
                    agg["leave"] += 1
                    agg["statuses"][payload.get("status")] += 1
            elif event_type == "probe_error":
                errors.append(payload)
            elif event_type == "ready":
                print("[probe] hook ready", flush=True)
        elif message.get("type") == "error":
            errors.append(message)
            print(f"[probe] script error: {message.get('description')}", flush=True)

    try:
        print(f"[probe] spawning {VRCHAT_EXE} --no-vr", flush=True)
        pid = frida.spawn([VRCHAT_EXE, "--no-vr"], cwd=VRCHAT_CWD)
        session = frida.attach(pid)
        script = session.create_script(HOOK_JS)
        script.on("message", on_message)
        script.load()
        frida.resume(pid)
        print(f"[probe] resumed pid={pid}, observing {WAIT_SECONDS}s", flush=True)
        deadline = time.time() + WAIT_SECONDS
        while time.time() < deadline:
            time.sleep(1)
    finally:
        thread_snapshot = []
        disasm = {"base": None, "target": None, "lines": []}
        if script is not None:
            try:
                thread_snapshot = script.exports_sync.threadsnapshot()
            except Exception as exc:
                errors.append({"ev": "rpc_error", "where": "threadsnapshot", "error": str(exc)})
            try:
                disasm = script.exports_sync.disasmversion(hex(VERSION_WAIT_RVA))
            except Exception as exc:
                errors.append({"ev": "rpc_error", "where": "disasmversion", "error": str(exc)})
        if pid is not None:
            for thread in thread_snapshot:
                stack = thread.get("stack", [])
                if not stack or not stack[0].startswith("KERNELBASE.dll+0x3bc5f"):
                    continue
                handle_text = thread.get("context", {}).get("rcx")
                try:
                    queried = query_remote_handle(pid, handle_text)
                    if queried is not None:
                        handle_map.setdefault(handle_text, {}).update(queried)
                except Exception as exc:
                    errors.append(
                        {
                            "ev": "query_remote_handle_error",
                            "tid": thread.get("tid"),
                            "handle": handle_text,
                            "error": str(exc),
                        }
                    )
        dump_log(
            RAW_LOG_PATH,
            handle_map,
            wait_aggs,
            outstanding,
            latest_wait_by_thread,
            version_waits,
            thread_snapshot,
            disasm,
            errors,
        )
        summarize_for_stdout(handle_map, outstanding, latest_wait_by_thread)
        try:
            if session is not None:
                session.detach()
        except Exception:
            pass
        if pid is not None:
            try:
                frida.kill(pid)
            except Exception:
                pass
        kill_all_vrchat()
        if list_vrchat_pids():
            print("[probe] warning: VRChat.exe still running after cleanup", flush=True)
            return 3
        print(f"[probe] raw log written to {RAW_LOG_PATH}", flush=True)

    return 0


if __name__ == "__main__":
    sys.exit(main())
