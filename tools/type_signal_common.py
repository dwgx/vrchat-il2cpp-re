"""Shared type-name helpers for the structural-signal miners.

The Unity 6 extractor now renders generic instances as Base<Arg,Arg,...> (see
resolve_type_name in extract_reverse_unity6.py). The discriminative part of a
generic is often an INNER argument (List<ApiWorldInstance> -> ApiWorldInstance),
so the miners must look inside the angle brackets, not just at the outer name.

clean_type_tokens(t) returns the set of clean, domain-meaningful short type
names found anywhere in t (outer + all generic args), dropping primitives,
plumbing/container types, and obfuscated (beebyte) names.
"""
import re

_BEEBYTE = set("ÌÍÎÏ")
_PRIM = {
    "Single", "Int32", "Boolean", "UInt32", "Byte", "Int64", "Double", "String",
    "Char", "Object", "UInt64", "Int16", "UInt16", "SByte", "IntPtr", "UIntPtr",
    "Void",
}
# Container / plumbing generics: useful as outer shells but not as a class
# domain signal on their own. We still mine their INNER args.
_CONTAINER = {
    "List", "Dictionary", "HashSet", "IList", "IDictionary", "ICollection",
    "IEnumerable", "IEnumerator", "IReadOnlyList", "IReadOnlyDictionary",
    "KeyValuePair", "Nullable", "IComparer", "IEqualityComparer", "Comparer",
    "EqualityComparer", "Queue", "Stack", "LinkedList", "SortedDictionary",
    "SortedList", "SortedSet", "ReadOnlyCollection", "ObservableCollection",
    "ConcurrentDictionary", "ConcurrentQueue", "ConcurrentBag", "Tuple",
    "ValueTuple", "Array",
}
_NOISE = {
    "Action", "Func", "Task", "ValueTask", "UniTask", "UniTaskVoid",
    "CancellationToken", "CancellationTokenSource", "Type", "Exception",
    "Predicate", "Comparison", "Converter", "EventHandler", "WeakReference",
    "Lazy", "ThreadLocal",
    # placeholder tokens that can leak in from unresolved nested Il2CppTypes
    "genericparam", "genericinst", "array", "class", "kind",
}

# Tokens of the form WORD, optionally namespace-qualified, ignoring < > , markers.
_TOKEN = re.compile(r"[A-Za-z_][A-Za-z0-9_.]*")


def short(name: str) -> str:
    return name.split(".")[-1].split("`")[0]


def is_clean_short(s: str) -> bool:
    if not s or any(c in _BEEBYTE for c in s):
        return False
    return s not in _PRIM and s not in _CONTAINER and s not in _NOISE


def clean_type_tokens(t: str) -> set:
    """All clean domain type short-names found in t (outer name + generic args).

    Container/plumbing outer names (List, Dictionary, Func, ...) are dropped, but
    their inner arguments are kept: 'List<ApiWorldInstance>' -> {'ApiWorldInstance'};
    'Dictionary<String,ApiWorld>' -> {'ApiWorld'}; 'Func<VRCPlayerApi,Boolean>' ->
    {'VRCPlayerApi'}. Obfuscated args are skipped.
    """
    if not t or t.startswith("<"):
        return set()
    out = set()
    for tok in _TOKEN.findall(t):
        s = short(tok)
        if is_clean_short(s):
            out.add(s)
    return out
