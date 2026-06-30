# Live <-> Static Class Cross-Reference

OFFLINE analysis. Goal: map STATIC obfuscated/synthetic class identities to LIVE real (human-readable) names harvested from the running process.

## Result

- High-confidence recoveries: **0**
- Plausible recoveries: **0**
- Ambiguous (unresolvable) shape collisions: **68780**
- Live real classes: 17805  (2044 distinct names)
- Static obfuscated identities: 3600 (obfclass keys 548 + synthetic targets 3543 + full_targets classes 1265)

## Join keys attempted and their overlap

| join key | overlap |
| --- | --- |
| live_real_name == static_obf_key | 0 |
| live_weak_name == static_obf_key | 0 |
| live_any_name == obfclass_keys | 0 |
| live_any_name == synthetic_targets | 0 |
| live_any_name == full_targets_cls | 0 |
| live_any_name == obf_garbage_value | 0 |
| live_klass_addr == runtime_sample_va | 0 |
| live_klass_addr == full_targets_ea | 0 |

## Why the recovery count is what it is (honest caveats)

- The live substrate stores **nf=0, fields=[], ns=null for ALL 19,343 records**. Field-count, field-name, and namespace joins are therefore structurally impossible — the substrate simply did not capture those attributes.
- The only populated numeric live attribute is **nm (method count)**, and it is polluted: 335 distinct live names share nm=66, and many "names" are GameObject / Transform / UI-label instance strings rather than IL2CPP type names. nm is not a reliable type-shape key.
- **Every exact-identity and address join returned ZERO overlap.** The static side keys by synthetic/Beebyte obfuscated tokens; the live real side has readable names; the two name spaces do not intersect, the Beebyte garbage values never appear live, and the live klass VAs (this session pid) share no addresses with the static target VAs/EAs (different builds / different process).
- A shape-only bridge on nm-alone is not a valid unique match (a single nm value maps to hundreds of classes on the static side and dozens on the live side). Those 68780 pairings are reported as ambiguous, not recoveries, per the project no-inflation rule.

## Conclusion

With the live substrate as currently serialized, there are **no high-confidence recoveries**. The harvest is genuinely valuable (17,805 real names), but it lacks the join attributes (per-class field counts, field-name sets, namespaces, or a shared key linking a live klass to a static obfuscated identity) needed to bind a live real name onto a specific static obfuscated class. To turn this harvest into recoveries, the substrate must be re-harvested with per-class **field counts + field-name sets + namespace**, or a **live-klass -> static-VA bridge** must be recorded at harvest time so shape/field joins become uniquely resolvable.

