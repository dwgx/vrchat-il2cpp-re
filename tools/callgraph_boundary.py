"""Shared next-VA-bounded disassembly for call-graph analysis.

This is the SINGLE source of truth for how a function body is delimited when
extracting its domain callees. Both the discovery sweep (sweep_weak_callees.py)
and the independent precision audit (verify_callgraph_precision.py) import from
here, so a verifier can never silently drift to a different (or flawed) boundary
than the code it checks.

History: for three rounds an overrun bug hid because each tool kept its own copy
of iter_func with a fixed-size window and no next-VA ceiling. When a ret had no
trailing int3/nop padding, disassembly ran into the adjacent function and its
calls were miscounted as the current class's callees, systematically inflating
domain-callee counts (TextCodec_63AC read Encoding x28 instead of the true x7).
The next-VA hard boundary (below) fixes this; centralising it prevents recurrence.
"""
import re, bisect

# A method pointer's true function ends no later than the next known method's
# start VA. The ~239k method VAs do not overlap, so the next one is a valid hard
# ceiling; in practice every real `ret` is reached before it (verified), so this
# only ever trims overrun, never truncates a real body early.

GENERIC_CALLEE = re.compile(
    r'^(Type|Struct|Mono|Service|Major|Static|Record|DataOnly|Unknown|Empty|'
    r'LargeClass|Class_|Obf_|BaseClass|k__|Backing|Delegate|Enum|Sibling|'
    r'Derived|Related|Impl|Pointer|UnityObjectWrapper|PropertyAttribute)|'
    r'^(System|Object|Component|Array|String|Time|Func`|Action`|List`|'
    r'Dictionary`|Nullable`|IEnumerable|IEnumerator|ValueType|Exception|'
    r'ThrowHelper|ArgumentNullException|Span`|Memory`|Task`|ValueTask|'
    r'IDisposable|EqualityComparer|Comparer`|HashSet`|GameObject|Transform|'
    r'Debug|MonoBehaviour|Component|Vector|Quaternion|Mathf|Convert)$')


def iter_func(md, code, va, next_va=None):
    """Disassemble one function. Stop at: (1) the next known method's start VA
    (hard boundary — prevents overrun into the adjacent function when a ret has
    no trailing padding, which injected phantom callees and inflated counts), or
    (2) a ret followed by int3/nop padding."""
    seen_ret = False
    for insn in md.disasm(code, va):
        if next_va is not None and insn.address >= next_va:
            return
        if seen_ret and insn.mnemonic in ("int3", "nop"):
            return
        yield insn
        seen_ret = (insn.mnemonic == "ret")


def build_va2cls(dump):
    """Map every method-pointer VA -> owning class name, and return the sorted
    VA list used for next-function boundary lookup."""
    va2cls = {}
    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            for _m, va in c.get("method_pointers", {}).items():
                try:
                    va2cls[int(va, 16)] = c.get("name", "")
                except (ValueError, TypeError):
                    pass
    return va2cls, sorted(va2cls)


def next_va_for(all_vas, va):
    """Start VA of the next known method after `va`, or None if `va` is last."""
    i = bisect.bisect_right(all_vas, va)
    return all_vas[i] if i < len(all_vas) else None


def class_domain_callees(dr, md, va2cls, all_vas, method_pointers, scan=2000,
                         include_generic=False):
    """Count domain callees across all methods of one class, each delimited by
    the next-VA boundary. Returns a collections.Counter. Generic/ubiquitous
    callees are excluded unless include_generic=True."""
    import collections
    callee = collections.Counter()
    for _m, va_hex in method_pointers.items():
        try:
            va = int(va_hex, 16)
        except (ValueError, TypeError):
            continue
        fo = dr.v2f(va)
        if fo is None:
            continue
        nva = next_va_for(all_vas, va)
        for insn in iter_func(md, dr.mm[fo:fo + scan], va, nva):
            if insn.mnemonic == "call" and insn.operands and insn.operands[0].type == 2:
                cn = va2cls.get(insn.operands[0].imm)
                if cn and (include_generic or not GENERIC_CALLEE.match(cn)):
                    callee[cn] += 1
    return callee
