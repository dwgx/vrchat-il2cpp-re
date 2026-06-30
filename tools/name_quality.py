#!/usr/bin/env python
"""Canonical name-quality criterion — single source of truth.

run_full_pipeline.py, compute_final_stats.py, apply_class_names.py and
grade_evidence.py all import from here so the "is this a real semantic name?"
judgement can never drift between the pipeline, the coverage report, the name
applier and the evidence grader (a drift that previously inflated class coverage
from a true ~45% to a reported 62.8% by counting structural placeholders as
semantic).

Golden cases pinning this behaviour live in tools/test_name_quality.py — run it
before changing anything here.

A "weak" name is one that conveys no domain meaning and should count as fallback:
  1. legacy weak prefixes (Type/Struct/Mono/.../Class_)            -> weak
  2. structural placeholders synthesized from class topology
     (BaseClassN, BackingFieldBase, k__BackingField, and stacked
     Sibling/Impl/Derived/Related tokens) that reduce to nothing
     meaningful once synthetic tokens + the trailing _HEX are stripped.

Example placeholders (weak):  BaseClass290ImplImpl_31B9, BackingFieldBase_16D7,
    k__BackingFieldSibling_3FE6, RequiresStoringk__BackingRelated_C846
Example real names (kept):    ShopPrefabProvider, AsyncStateMachine_50D1,
    GestureLocomotionBase_D955 (residual "GestureLocomotionBase"),
    ContainerPromptBaseImpl_CCAF (residual "ContainerPromptBase")
"""
import re

# 1) Legacy weak prefixes — fallback names the pipeline synthesizes from class
#    topology. CRITICAL: these prefixes are real English words, so a bare
#    startswith() wrongly demotes legitimate names (MonoBehaviour, ServiceProvider,
#    TypeConverterRegistry, StaticMeshBatcher, RecordReader, StructLayoutAttribute).
#    The pipeline only ever emits them as "<prefix><digit>..." (Mono1m, Service31m,
#    Type5m3f, Record106f, Static18m, DataOnly4f) or "<prefix>_..." (Class_5, Obf_X)
#    or the bare descriptive tokens (EmptyType, EmptyClass, LargeClass). A real name
#    always has a LETTER right after the prefix, so we require a digit / underscore /
#    end-of-string boundary — never a letter. See tools/deobfuscate.py phase-7
#    fallback naming (the only producer of these).
_COUNTING_PREFIX = re.compile(
    r'^(Type|Struct|Mono|Service|Major|Static|DataOnly|Record|Unknown)\d')
_TOKEN_PREFIX = re.compile(
    r'^(EmptyType|EmptyStruct|EmptyClass|LargeClass)(\d|_|$)')
_UNDERSCORE_PREFIX = ('Obf_', 'Class_')

# 2) Structural-placeholder residual test.
_SYNTH = re.compile(
    r'(BaseClass\d*|BackingFieldBase|BackingField|RequiresStoring'
    r'|k__BackingField|Sibling|Impl|Derived|Related|Backing)')
_HEXTAIL = re.compile(r'_[0-9A-Fa-f]{3,4}$')
_LEAD_NOISE = re.compile(r'^(UI|Pointer)+')

# 3) Generic-BCL-word-only test (item 20). A name that, after stripping the hex
# residue tail, is exactly one generic framework word (Delegate_72B1 -> "Delegate")
# is structurally accurate but carries no domain content - it is a LABEL for the
# class's framework role, not a recovered developer name. Demote to weak so the
# coverage headline doesn't count MulticastDelegate subclasses as named. Must be
# the WHOLE name (DelegateRegistry / EventDelegate keep their domain qualifier and
# stay real).
_GENERIC_BCL_ONLY = re.compile(
    r'^(Delegate|MulticastDelegate|Object|Component|ValueType|Enum|Attribute)$')


def _residual(name: str) -> str:
    """What meaningful text remains after removing synthetic structural tokens."""
    s = _HEXTAIL.sub('', name)
    s = _SYNTH.sub('', s)
    s = _LEAD_NOISE.sub('', s)
    s = re.sub(r'[_\d]+', '', s)
    return s


def is_structural_placeholder(name: str) -> bool:
    """True if the name is synthesized from class topology with no domain meaning."""
    # Only treat as placeholder if it actually contains synthetic tokens; this
    # avoids demoting short-but-real names like "Pose" or "Rect".
    if not _SYNTH.search(name) and 'k__' not in name:
        return False
    return len(_residual(name)) < 3


def is_weak_name(name: str) -> bool:
    """Canonical fallback test: legacy weak prefix OR structural placeholder."""
    if not name:
        return True
    if _COUNTING_PREFIX.match(name):
        return True
    if _TOKEN_PREFIX.match(name):
        return True
    if name.startswith(_UNDERSCORE_PREFIX):
        return True
    if is_structural_placeholder(name):
        return True
    # item 20: name reduces to a single generic framework word + hex tail
    if _GENERIC_BCL_ONLY.match(_HEXTAIL.sub('', name).rstrip('_')):
        return True
    return False
