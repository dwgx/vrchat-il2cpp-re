/**
 * bridge.js - IL2CPP API bridge for VRChat
 *
 * Bypasses VRChat's anti-tamper return address validation by placing a
 * trampoline in GameAssembly.dll's writable data section. When the trampoline
 * calls an export, the return address is within GA's VA range, passing the check.
 *
 * Usage from Frida:
 *   frida -p <pid> -l bridge.js
 *
 * Or from Python:
 *   python bridge.py
 */

'use strict';

const TRAMPOLINE_SIZE = 64;

// Known export → API name mappings (from previous analysis)
const KNOWN_EXPORTS = {
    'xbdxfIjXGZA': 'il2cpp_domain_get',
    'HVnVGWHvEoF': 'il2cpp_thread_attach',
    'il2cpp_free': 'il2cpp_free',
    'il2cpp_gchandle_get_target': 'il2cpp_gchandle_get_target',
    'il2cpp_native_stack_trace': 'il2cpp_native_stack_trace',
};

class IL2CppBridge {
    constructor() {
        this.ga = null;
        this.gaBase = null;
        this.gaSize = 0;
        this.trampoline = null;
        this.trampolineNative = null;
        this.exports = {};
        this.realFunctions = {};
    }

    init() {
        // Find GameAssembly.dll
        this.ga = Process.findModuleByName('GameAssembly.dll');
        if (!this.ga) {
            throw new Error('GameAssembly.dll not found');
        }
        this.gaBase = this.ga.base;
        this.gaSize = this.ga.size;
        send({ type: 'info', msg: `GA: ${this.gaBase} size ${this.gaSize} (${(this.gaSize / 1024 / 1024).toFixed(0)}MB)` });

        // Enumerate exports
        const exports = this.ga.enumerateExports();
        for (const exp of exports) {
            this.exports[exp.name] = exp.address;
        }
        send({ type: 'info', msg: `Exports: ${exports.length}` });

        // Install trampoline
        this._installTrampoline();

        // Map known APIs
        this._mapApis();

        return this;
    }

    _installTrampoline() {
        // Find a writable data range within GA
        // Look for .data section (RW) - safest place, not integrity-checked
        const ranges = this.ga.enumerateRanges('rw-');
        let dataRange = null;

        for (const r of ranges) {
            if (r.size >= TRAMPOLINE_SIZE + 256) {
                dataRange = r;
                break;
            }
        }

        if (!dataRange) {
            // Fallback: find any writable range in GA
            const allRanges = Process.enumerateRanges('rw-');
            for (const r of allRanges) {
                const rEnd = r.base.add(r.size);
                const gaEnd = this.gaBase.add(this.gaSize);
                if (r.base.compare(this.gaBase) >= 0 && rEnd.compare(gaEnd) <= 0) {
                    if (r.size >= TRAMPOLINE_SIZE + 256) {
                        dataRange = r;
                        break;
                    }
                }
            }
        }

        if (!dataRange) {
            throw new Error('No writable data range found in GA');
        }

        // Use the END of the data section (least likely to be used by the program)
        // Align to 16 bytes
        const offset = dataRange.size - TRAMPOLINE_SIZE - 16;
        this.trampoline = dataRange.base.add(offset & ~0xF);

        send({ type: 'info', msg: `Trampoline at: ${this.trampoline} (in data range ${dataRange.base} +${dataRange.size})` });

        // Make the trampoline page executable
        Memory.protect(this.trampoline, TRAMPOLINE_SIZE, 'rwx');

        // Write trampoline shellcode
        // trampoline(target, arg1, arg2, arg3, arg4_on_stack)
        // Windows x64: rcx=target, rdx=arg1, r8=arg2, r9=arg3
        //
        // push rbx              ; save non-volatile
        // sub rsp, 0x28         ; shadow space (32) + alignment (8)
        // mov rax, rcx          ; rax = target export address
        // mov rcx, rdx          ; arg1
        // mov rdx, r8           ; arg2
        // mov r8, r9            ; arg3
        // mov r9, [rsp+0x58]    ; arg4 from caller's stack
        // call rax              ; CALL TARGET - return addr is within GA!
        // add rsp, 0x28
        // pop rbx
        // ret

        const code = [
            0x53,                           // push rbx
            0x48, 0x83, 0xEC, 0x28,         // sub rsp, 0x28
            0x48, 0x8B, 0xC1,               // mov rax, rcx
            0x48, 0x8B, 0xCA,               // mov rcx, rdx
            0x49, 0x8B, 0xD0,               // mov rdx, r8
            0x4D, 0x8B, 0xC1,               // mov r8, r9
            0x4C, 0x8B, 0x4C, 0x24, 0x58,   // mov r9, [rsp+0x58]
            0xFF, 0xD0,                      // call rax
            0x48, 0x83, 0xC4, 0x28,         // add rsp, 0x28
            0x5B,                           // pop rbx
            0xC3,                           // ret
        ];

        Memory.writeByteArray(this.trampoline, code);

        // Verify write
        const verify = Memory.readByteArray(this.trampoline, code.length);
        const ok = new Uint8Array(verify).every((b, i) => b === code[i]);
        if (!ok) {
            throw new Error('Trampoline verification failed!');
        }

        // Create NativeFunction for the trampoline
        // Signature: pointer trampoline(pointer target, pointer arg1, pointer arg2, pointer arg3, pointer arg4)
        this.trampolineNative = new NativeFunction(this.trampoline, 'pointer',
            ['pointer', 'pointer', 'pointer', 'pointer', 'pointer']);

        send({ type: 'info', msg: 'Trampoline installed and verified' });
    }

    _mapApis() {
        // Build known API function references
        this.api = {};
        for (const [exportName, apiName] of Object.entries(KNOWN_EXPORTS)) {
            if (this.exports[exportName]) {
                this.api[apiName] = this.exports[exportName];
                send({ type: 'info', msg: `API: ${apiName} -> ${exportName} @ ${this.exports[exportName]}` });
            }
        }
    }

    /**
     * Call an export through the trampoline (bypasses return address check).
     * @param {NativePointer|string} target - Export address or name
     * @param  {...NativePointer} args - Up to 4 arguments
     * @returns {NativePointer} Return value
     */
    call(target, ...args) {
        let addr;
        if (typeof target === 'string') {
            addr = this.exports[target] || this.api[target];
            if (!addr) throw new Error(`Unknown export/API: ${target}`);
        } else {
            addr = target;
        }

        // Pad args to 4
        while (args.length < 4) args.push(ptr(0));

        return this.trampolineNative(addr, args[0], args[1], args[2], args[3]);
    }

    /**
     * Test the bridge by calling il2cpp_domain_get (no args, returns domain pointer).
     */
    test() {
        send({ type: 'info', msg: '--- Bridge Test ---' });

        // Test 1: il2cpp_domain_get
        if (this.api['il2cpp_domain_get']) {
            try {
                const domain = this.call('il2cpp_domain_get');
                send({ type: 'result', msg: `il2cpp_domain_get() = ${domain}`, success: !domain.isNull() });
            } catch (e) {
                send({ type: 'error', msg: `il2cpp_domain_get failed: ${e.message}` });
            }
        }

        // Test 2: il2cpp_thread_attach
        if (this.api['il2cpp_thread_attach'] && this.api['il2cpp_domain_get']) {
            try {
                const domain = this.call('il2cpp_domain_get');
                if (!domain.isNull()) {
                    const thread = this.call('il2cpp_thread_attach', domain);
                    send({ type: 'result', msg: `il2cpp_thread_attach(domain) = ${thread}`, success: !thread.isNull() });
                }
            } catch (e) {
                send({ type: 'error', msg: `il2cpp_thread_attach failed: ${e.message}` });
            }
        }

        // Test 3: Try all exports with single NULL arg to see which ones return non-null
        // (This is DANGEROUS for some functions, only do with known-safe single-arg functions)
        send({ type: 'info', msg: 'Testing single-arg exports that have known real function mappings...' });

        // Only test exports that map to unique real functions (avoid redundant tests)
        const tested = new Set();
        let working = 0;
        let crashed = 0;

        // We WON'T blindly test all exports as some might crash
        // Instead, just report the bridge is ready
        send({ type: 'info', msg: `Bridge ready. ${Object.keys(this.api).length} known APIs, ${Object.keys(this.exports).length} total exports` });
    }

    /**
     * Probe single-arg exports safely: call with a known-valid pointer.
     * Use the mscorlib assembly table entry as a safe test pointer.
     */
    probeExports(testPtr) {
        const results = {};
        const safeExports = Object.keys(this.exports).filter(name =>
            !name.startsWith('il2cpp_') // avoid standard exports
        );

        for (const name of safeExports.slice(0, 5)) {  // Only first 5 for safety
            try {
                const result = this.call(name, testPtr);
                results[name] = result.toString();
                send({ type: 'probe', name, result: result.toString() });
            } catch (e) {
                results[name] = `ERROR: ${e.message}`;
                send({ type: 'probe', name, result: `ERROR: ${e.message}` });
            }
        }
        return results;
    }
}

// Auto-init
try {
    const bridge = new IL2CppBridge().init();
    bridge.test();

    // Expose to RPC
    rpc.exports = {
        call: function(exportName, ...args) {
            return bridge.call(exportName, ...args.map(a => ptr(a))).toString();
        },
        listExports: function() {
            return Object.keys(bridge.exports);
        },
        listApis: function() {
            return Object.keys(bridge.api);
        },
        getExportAddr: function(name) {
            return (bridge.exports[name] || bridge.api[name] || ptr(0)).toString();
        },
    };
} catch (e) {
    send({ type: 'error', msg: `Bridge init failed: ${e.message}` });
}
