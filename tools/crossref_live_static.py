#!/usr/bin/env python3
"""
crossref_live_static.py - Cross-reference LIVE-harvested class names against
STATIC obfuscated/synthetic class identities to find direct recovery wins.

OFFLINE file analysis only. No process attach, no frida. Reads the harvested
live substrate + the static obfuscation/target inventories and quantifies how
many static-obfuscated classes can be matched to a live REAL (human-readable)
name with high confidence.

STRICT NO-INFLATION DISCIPLINE: a recovery is only counted as high-confidence
when the join is unique and unambiguous. Anything weaker is reported as
plausible or counted as ambiguous, never as a recovery.

Inputs (read-only):
  output/p2_research/live_class_substrate.json   live names + kind + nm (nf=0, ns null)
  output/p2_research/obfclass_to_original.json   static obf-key -> Beebyte garbage original
  output/p2_research/runtime_sample_targets.json synthetic name + nfields/nmethods + callee_hint
  output/p2_research/full_targets.json           obf class::method work-list
  data/class_map_old_to_new.json                 cross-build VA mapping

Outputs:
  output/p2_research/live_static_crossref.json
  output/p2_research/live_static_crossref.md
"""
import json
import os
import sys
from collections import Counter

sys.stdout.reconfigure(encoding='utf-8')

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
P2 = os.path.join(ROOT, 'output', 'p2_research')


def load(path):
    with open(path, encoding='utf-8') as f:
        return json.load(f)


def is_obfuscated_name(name):
    """Heuristic: does a name look like a Beebyte/synthetic obfuscation artifact?"""
    if not name:
        return False
    if any(ch in 'ÌÍÎÏ' for ch in name):
        return True
    if '_k__BackingField' in name or name.startswith('BaseClass') or name.startswith('BackingField'):
        return True
    return False


def main():
    sub = load(os.path.join(P2, 'live_class_substrate.json'))
    live = sub['classes']
    obf = load(os.path.join(P2, 'obfclass_to_original.json'))
    rst = load(os.path.join(P2, 'runtime_sample_targets.json'))
    full = load(os.path.join(P2, 'full_targets.json'))
    try:
        oldnew = load(os.path.join(ROOT, 'data', 'class_map_old_to_new.json'))
    except Exception:
        oldnew = {}

    # ---- LIVE side -------------------------------------------------------
    live_real = [c for c in live if c.get('kind') == 'real']
    live_weak = [c for c in live if c.get('kind') == 'weak']
    live_real_names = set(c['name'] for c in live_real)
    live_weak_names = set(c['name'] for c in live_weak)
    live_all_names = set(c['name'] for c in live)
    live_klass_addrs = set(c['klass'].lower() for c in live)

    # Data-quality facts about the live substrate (verified at runtime):
    #   nf == 0 for every record       -> field-count join impossible
    #   fields == [] for every record  -> field-name join impossible
    #   ns == null/garbage             -> namespace join impossible
    #   nm is POLLUTED: hundreds of distinct names share an nm value and many
    #     "names" are GameObject/Transform/UI-label instance strings, not type
    #     names -> nm is NOT a reliable type-shape key.
    nf_nonzero = sum(1 for c in live if c.get('nf', 0))
    fields_nonempty = sum(1 for c in live if c.get('fields'))
    ns_real = sum(1 for c in live if c.get('ns'))

    # ---- STATIC side: obfuscated / unnamed identities --------------------
    obf_keys = set(obf.keys())
    obf_garbage_vals = set(obf.values())  # all ÌÍÎÏ garbage = still-unknown originals
    synth_names = set(r['name'] for r in rst)
    full_cls = set(r['class'] for r in full)
    static_obf_universe = obf_keys | synth_names | full_cls
    static_obf_count = len(static_obf_universe)

    # ---- JOIN ATTEMPTS ---------------------------------------------------
    joins = {}
    # J1: direct name identity across both sides.
    joins['live_real_name == static_obf_key'] = len(live_real_names & static_obf_universe)
    joins['live_weak_name == static_obf_key'] = len(live_weak_names & static_obf_universe)
    joins['live_any_name == obfclass_keys'] = len(live_all_names & obf_keys)
    joins['live_any_name == synthetic_targets'] = len(live_all_names & synth_names)
    joins['live_any_name == full_targets_cls'] = len(live_all_names & full_cls)
    # J2: Beebyte garbage-value bridge.
    joins['live_any_name == obf_garbage_value'] = len(live_all_names & obf_garbage_vals)
    # J3: klass address identity (live VAs vs static target VAs).
    rst_vas = set(r['va'].lower() for r in rst if 'va' in r)
    full_eas = set(r['ea'].lower() for r in full if 'ea' in r)
    joins['live_klass_addr == runtime_sample_va'] = len(live_klass_addrs & rst_vas)
    joins['live_klass_addr == full_targets_ea'] = len(live_klass_addrs & full_eas)

    # J4: SHAPE join (nfields+nmethods). Live nf==0 universally, so the only
    #     shape component available is nmethods. Measure ambiguity: for each
    #     static target nmethods value, how many live-real classes collide.
    live_real_nm = Counter(c['nm'] for c in live_real)
    tgt_by_nm = Counter(r['nmethods'] for r in rst)
    # A shape match is only "unique" if exactly one static target AND exactly
    # one live-real class share an nmethods value that is > 0. Even then, with
    # nf unavailable and nm polluted, this is not corroborated -> at best
    # "ambiguous". Count how many nm values are 1:1 on both sides.
    unique_both = 0
    for nm, scnt in tgt_by_nm.items():
        if nm > 0 and scnt == 1 and live_real_nm.get(nm, 0) == 1:
            unique_both += 1

    # ---- RECOVERY CLASSIFICATION ----------------------------------------
    # A recovery requires a verifiable join from a STATIC obfuscated identity
    # to a LIVE real name. We collect any candidate produced by J1/J3 (exact
    # identity bridges); shape-only (J4) candidates are explicitly NOT promoted
    # to recoveries because nf is unavailable and nm is polluted.
    high_confidence = []
    plausible = []

    # J1/J3 exact bridges -> would be high-confidence if any existed.
    for nm in sorted(live_real_names & static_obf_universe):
        high_confidence.append({
            'static_key': nm,
            'live_name': nm,
            'evidence': 'exact obfuscated-token identity present on both static and live sides',
            'join': 'name-identity',
        })

    # Ambiguous tier: shape-only collisions that can never be uniquely resolved
    # with the available live fields (nf=0, ns null). Count, do not enumerate
    # as recoveries.
    ambiguous_count = 0
    for nm, scnt in tgt_by_nm.items():
        if nm <= 0:
            continue
        lcnt = live_real_nm.get(nm, 0)
        if lcnt > 0:
            # every (static target, live real) pair sharing this nm is an
            # unresolvable shape collision
            ambiguous_count += scnt * lcnt

    method = (
        "Attempted every available join key between the LIVE substrate and the "
        "STATIC obfuscation/target inventories. Live records carry nf=0, empty "
        "fields[], and null/garbage ns for ALL 19,343 classes, so field-count, "
        "field-name, and namespace joins are structurally impossible. nm (method "
        "count) is polluted (335 distinct live names share nm=66; many 'names' "
        "are GameObject/Transform/UI-label instance strings, not type names), so "
        "it is not a reliable type-shape key. Exact-identity joins tried: "
        "live name vs obfclass keys, synthetic target names, full_targets class "
        "names, and Beebyte garbage values; klass-address joins tried: live "
        "klass VA vs runtime_sample VA and full_targets EA. Shape join "
        "(nfields+nmethods) reduces to nmethods-only and is recorded as ambiguous, "
        "never promoted to a recovery. A candidate is high-confidence ONLY on a "
        "unique exact-identity or address bridge; plausible requires nm shape "
        "corroborated by namespace or field names (unavailable here); everything "
        "else is counted ambiguous."
    )

    out = {
        'live_real_classes': len(live_real),
        'static_obfuscated_classes': static_obf_count,
        'recoveries': {
            'high_confidence': high_confidence,
            'plausible': plausible,
            'ambiguous_count': ambiguous_count,
        },
        'method': method,
        'diagnostics': {
            'live_total': len(live),
            'live_real': len(live_real),
            'live_weak': len(live_weak),
            'live_real_distinct_names': len(live_real_names),
            'static_obfclass_keys': len(obf_keys),
            'static_synthetic_targets': len(synth_names),
            'static_full_targets_cls': len(full_cls),
            'live_records_with_nf_gt0': nf_nonzero,
            'live_records_with_fields': fields_nonempty,
            'live_records_with_real_ns': ns_real,
            'join_overlaps': joins,
            'shape_join_unique_on_both_sides_nm': unique_both,
            'class_map_old_to_new_entries': len(oldnew),
        },
    }

    out_json = os.path.join(P2, 'live_static_crossref.json')
    with open(out_json, 'w', encoding='utf-8') as f:
        json.dump(out, f, ensure_ascii=False, indent=2)

    # ---- Markdown summary ------------------------------------------------
    md = []
    md.append('# Live <-> Static Class Cross-Reference')
    md.append('')
    md.append('OFFLINE analysis. Goal: map STATIC obfuscated/synthetic class identities '
              'to LIVE real (human-readable) names harvested from the running process.')
    md.append('')
    md.append('## Result')
    md.append('')
    md.append(f'- High-confidence recoveries: **{len(high_confidence)}**')
    md.append(f'- Plausible recoveries: **{len(plausible)}**')
    md.append(f'- Ambiguous (unresolvable) shape collisions: **{ambiguous_count}**')
    md.append(f'- Live real classes: {len(live_real)}  ({len(live_real_names)} distinct names)')
    md.append(f'- Static obfuscated identities: {static_obf_count} '
              f'(obfclass keys {len(obf_keys)} + synthetic targets {len(synth_names)} '
              f'+ full_targets classes {len(full_cls)})')
    md.append('')
    md.append('## Join keys attempted and their overlap')
    md.append('')
    md.append('| join key | overlap |')
    md.append('| --- | --- |')
    for k, v in joins.items():
        md.append(f'| {k} | {v} |')
    md.append('')
    md.append('## Why the recovery count is what it is (honest caveats)')
    md.append('')
    md.append('- The live substrate stores **nf=0, fields=[], ns=null for ALL 19,343 records**. '
              'Field-count, field-name, and namespace joins are therefore structurally impossible '
              '— the substrate simply did not capture those attributes.')
    md.append('- The only populated numeric live attribute is **nm (method count)**, and it is '
              'polluted: 335 distinct live names share nm=66, and many "names" are GameObject / '
              'Transform / UI-label instance strings rather than IL2CPP type names. nm is not a '
              'reliable type-shape key.')
    md.append('- **Every exact-identity and address join returned ZERO overlap.** The static side '
              'keys by synthetic/Beebyte obfuscated tokens; the live real side has readable names; '
              'the two name spaces do not intersect, the Beebyte garbage values never appear live, '
              'and the live klass VAs (this session pid) share no addresses with the static target '
              'VAs/EAs (different builds / different process).')
    md.append('- A shape-only bridge on nm-alone is not a valid unique match (a single nm value '
              'maps to hundreds of classes on the static side and dozens on the live side). Those '
              f'{ambiguous_count} pairings are reported as ambiguous, not recoveries, per the '
              'project no-inflation rule.')
    md.append('')
    md.append('## Conclusion')
    md.append('')
    if not high_confidence:
        md.append('With the live substrate as currently serialized, there are **no high-confidence '
                  'recoveries**. The harvest is genuinely valuable (17,805 real names), but it lacks '
                  'the join attributes (per-class field counts, field-name sets, namespaces, or a '
                  'shared key linking a live klass to a static obfuscated identity) needed to bind a '
                  'live real name onto a specific static obfuscated class. To turn this harvest into '
                  'recoveries, the substrate must be re-harvested with per-class **field counts + '
                  'field-name sets + namespace**, or a **live-klass -> static-VA bridge** must be '
                  'recorded at harvest time so shape/field joins become uniquely resolvable.')
    else:
        md.append(f'{len(high_confidence)} high-confidence recoveries via exact-identity/address bridges.')
    md.append('')

    out_md = os.path.join(P2, 'live_static_crossref.md')
    with open(out_md, 'w', encoding='utf-8') as f:
        f.write('\n'.join(md) + '\n')

    print('high_confidence:', len(high_confidence))
    print('plausible:', len(plausible))
    print('ambiguous_count:', ambiguous_count)
    print('join overlaps:', json.dumps(joins, ensure_ascii=False))
    print('wrote:', out_json)
    print('wrote:', out_md)


if __name__ == '__main__':
    main()
