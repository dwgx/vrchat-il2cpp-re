#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
derive_klass_layout.py

OFFLINE statistical derivation of the live VRChat Il2CppClass struct layout
from captured raw struct bytes. No process attach, no frida -- files only.

Input : output/p2_research/live_klass_raw_structs.json
        {"pid":..,"name_off":"0x50","count":N,
         "structs":[{"klass":"0x..","raw":"<0x200 bytes hex>","name":".."}, ..]}

HARD LIMIT: the raw dump holds only the 0x200-byte klass struct, NOT the
memory it points to. So we cannot follow array pointers, cannot measure the
FieldInfo stride, and cannot read the FieldInfo sub-offsets. We can only:
  - classify each 8-byte slot: self-ref / null / small-int / plausible pointer
  - find u16 slots that behave like a real count (small, varied, max bounded)
  - find which pointer slots are GATED by a count (present iff count > 0)
  - find fixed-delta sibling pointers (adjacent struct members, not array bounds)
Output is therefore a RANKED HYPOTHESIS for live verification, not proof.

Outputs:
  output/p2_research/layout_hypotheses.json
  output/p2_research/layout_hypotheses.md
"""

import json
import os
import struct
import sys

STRUCT_SIZE = 0x200
NQ = STRUCT_SIZE // 8
# plausible user-mode heap pointer window observed in this capture
PTR_LO = 0x10000
PTR_HI = 0x7FFFFFFFFFFF
# a real count never exceeds this (IL2CPP method/field counts are u16, < ~2000)
COUNT_MAX = 2000


def hx(v):
    return "0x%x" % v


class Slot:
    __slots__ = ("klass", "name", "raw", "q")

    def __init__(self, klass, name, raw):
        self.klass = klass
        self.name = name
        self.raw = raw
        self.q = list(struct.unpack_from("<%dQ" % NQ, raw, 0))

    def u16(self, off):
        return struct.unpack_from("<H", self.raw, off)[0]

    def u32(self, off):
        return struct.unpack_from("<I", self.raw, off)[0]

    def is_ptr_at(self, off):
        v = self.q[off // 8]
        return PTR_LO <= v <= PTR_HI and v != self.klass


def load(path):
    with open(path, "r", encoding="utf-8") as fh:
        d = json.load(fh)
    slots = []
    for s in d["structs"]:
        raw = bytes.fromhex(s["raw"])
        if len(raw) < STRUCT_SIZE:
            raw = raw + b"\x00" * (STRUCT_SIZE - len(raw))
        slots.append(Slot(int(s["klass"], 16), s.get("name", ""), raw[:STRUCT_SIZE]))
    return d, slots


# ----------------------------------------------------------------------------
# qword slot classification
# ----------------------------------------------------------------------------
def qword_profile(slots):
    """Per 8-byte offset: fractions of self-ref / null / plausible-ptr / int."""
    n = len(slots)
    res = {}
    for off in range(0, STRUCT_SIZE, 8):
        i = off // 8
        self_c = nullc = ptrc = 0
        for s in slots:
            v = s.q[i]
            if v == s.klass:
                self_c += 1
            elif v == 0:
                nullc += 1
            elif PTR_LO <= v <= PTR_HI:
                ptrc += 1
        res[off] = {
            "self": self_c / n,
            "null": nullc / n,
            "ptr": ptrc / n,
            "int": (n - self_c - nullc - ptrc) / n,
        }
    return res


# ----------------------------------------------------------------------------
# clean-count detection (u16)
# ----------------------------------------------------------------------------
def u16_profile(slots):
    """Per u16 offset, stats describing how 'count-like' it is.

    A u16 that overlaps the low bytes of a live pointer shows max==65535 and a
    huge mean -> rejected. A real count is small, bounded, and varied."""
    n = len(slots)
    res = {}
    for off in range(0, STRUCT_SIZE - 1):
        vals = [s.u16(off) for s in slots]
        mx = max(vals)
        nz = sum(1 for v in vals if v > 0)
        in_range = sum(1 for v in vals if 1 <= v <= COUNT_MAX)
        distinct = len(set(vals))
        nzvals = [v for v in vals if v > 0]
        mean_nz = (sum(nzvals) / len(nzvals)) if nzvals else 0.0
        res[off] = {
            "max": mx,
            "nonzero_frac": nz / n,
            "in_range_frac": in_range / n,
            "distinct": distinct,
            "mean_nonzero": mean_nz,
        }
    return res


def clean_count_score(st):
    """High only for slots that genuinely look like an IL2CPP count.

    Requirements: bounded max (not a pointer byte), most values in [1,COUNT_MAX],
    several distinct values, moderate mean."""
    if st["max"] > COUNT_MAX:
        return 0.0
    if st["distinct"] < 3:
        return 0.0
    score = st["in_range_frac"]
    # penalise near-constant or tiny-range slots (flags/bitfields)
    if st["distinct"] < 5:
        score *= 0.4
    if st["mean_nonzero"] > 600:
        score *= 0.5
    return score


# ----------------------------------------------------------------------------
# gating: pointer present iff count > 0
# ----------------------------------------------------------------------------
def gating(slots, count_off, ptr_off):
    n = len(slots)
    match = pos = pos_ptr = zero = zero_noptr = 0
    for s in slots:
        cnt = s.u16(count_off) > 0
        isptr = s.is_ptr_at(ptr_off)
        if cnt == isptr:
            match += 1
        if cnt:
            pos += 1
            if isptr:
                pos_ptr += 1
        else:
            zero += 1
            if not isptr:
                zero_noptr += 1
    return {
        "corr": match / n,
        "p1_cntpos_has_ptr": (pos_ptr / pos) if pos else None,
        "p0_cntzero_no_ptr": (zero_noptr / zero) if zero else None,
        "n_cnt_pos": pos,
        "n_cnt_zero": zero,
    }


def fixed_delta(slots, off_a, off_b):
    """Most common (b - a) when both are pointers. A constant delta independent
    of any count means they are adjacent struct members, NOT array start/end."""
    from collections import Counter
    c = Counter()
    for s in slots:
        if s.is_ptr_at(off_a) and s.is_ptr_at(off_b):
            c[s.q[off_b // 8] - s.q[off_a // 8]] += 1
    if not c:
        return None, 0
    d, k = c.most_common(1)[0]
    return d, k


def main():
    here = os.path.dirname(os.path.abspath(__file__))
    repo = os.path.abspath(os.path.join(here, "..", ".."))
    inp = os.path.join(repo, "output", "p2_research", "live_klass_raw_structs.json")
    outdir = os.path.join(repo, "output", "p2_research")

    d, slots = load(inp)
    n = len(slots)

    qp = qword_profile(slots)
    up = u16_profile(slots)

    # ---- self-reference offsets ----
    self_refs = sorted(((off, qp[off]["self"]) for off in qp
                        if qp[off]["self"] >= 0.10), key=lambda x: -x[1])

    # ---- clean count u16 offsets ----
    counts = sorted(((off, clean_count_score(up[off]), up[off]) for off in up
                     if clean_count_score(up[off]) > 0.2),
                    key=lambda x: -x[1])

    # ---- pointer offsets (candidate array / member pointers) ----
    ptr_offs = [off for off in qp if qp[off]["ptr"] >= 0.05]
    # always-present pointers (ungated structural members; method array lives here)
    always_ptr = [off for off in qp if qp[off]["ptr"] >= 0.95]

    # ---- for each clean count, find the pointers it gates ----
    count_records = []
    for coff, score, st in counts:
        gated = []
        for poff in ptr_offs:
            g = gating(slots, coff, poff)
            # gated == pointer present mostly when count>0, absent when count==0
            if (g["p1_cntpos_has_ptr"] or 0) > 0.85 and (g["p0_cntzero_no_ptr"] or 0) > 0.7:
                gated.append((poff, g))
        gated.sort(key=lambda x: -x[1]["corr"])
        count_records.append({
            "off": hx(coff),
            "score": round(score, 4),
            "max": st["max"],
            "nonzero_frac": round(st["nonzero_frac"], 4),
            "in_range_frac": round(st["in_range_frac"], 4),
            "distinct": st["distinct"],
            "mean_nonzero": round(st["mean_nonzero"], 2),
            "gated_pointers": [
                {"off": hx(p), "corr": round(g["corr"], 4),
                 "p1_cntpos_has_ptr": round(g["p1_cntpos_has_ptr"], 4),
                 "p0_cntzero_no_ptr": round(g["p0_cntzero_no_ptr"], 4)}
                for p, g in gated[:6]
            ],
        })

    # -----------------------------------------------------------------
    # DECISION
    # -----------------------------------------------------------------
    # field_count: the strongest clean count that GATES at least one pointer.
    # (A field array exists iff field_count>0, so the count must gate its ptr.)
    field_count_off = None
    field_ptr_off = None
    for rec in count_records:
        if rec["gated_pointers"]:
            field_count_off = int(rec["off"], 16)
            field_ptr_off = int(rec["gated_pointers"][0]["off"], 16)
            break
    if field_count_off is None and count_records:
        field_count_off = int(count_records[0]["off"], 16)

    # method_count: a SECOND independent clean count, if one exists.
    method_count_off = None
    for rec in count_records:
        if int(rec["off"], 16) != field_count_off:
            method_count_off = int(rec["off"], 16)
            break

    # method_array_ptr: the methods pointer is an always-present structural
    # pointer (present even when field_count==0, i.e. NOT gated by field_count).
    # In IL2CPP `methods` precedes `fields`, so prefer the earliest always-present
    # pointer that is not the name(+0x50), image(+0x0) or embedded-type slots.
    EXCLUDE = {0x0, 0x50}  # image ptr, name ptr (confirmed)
    method_ptr_candidates = []
    for off in sorted(always_ptr):
        if off in EXCLUDE:
            continue
        # skip slots that are gated by field_count (those are field-side)
        g = gating(slots, field_count_off, off) if field_count_off is not None else None
        gated_by_fields = g and (g["p0_cntzero_no_ptr"] or 0) > 0.7 and (g["p1_cntpos_has_ptr"] or 0) > 0.85
        if gated_by_fields:
            continue
        method_ptr_candidates.append(off)
    method_array_ptr_off = method_ptr_candidates[0] if method_ptr_candidates else None

    # detect fixed-delta sibling pointers around the field pointer (events/props)
    sibling_notes = []
    if field_ptr_off is not None:
        for other in sorted(p for rec in count_records
                            for p in [int(g["off"], 16) for g in rec["gated_pointers"]]
                            if p != field_ptr_off):
            dlt, k = fixed_delta(slots, field_ptr_off, other)
            if dlt is not None and k > n * 0.3:
                sibling_notes.append(
                    "%s is %d bytes from field_ptr in %d/%d classes (fixed delta -> "
                    "adjacent member, not array bound)" % (hx(other), dlt, k, n))

    # -----------------------------------------------------------------
    # assemble result
    # -----------------------------------------------------------------
    def field_count_candidates():
        return [{"off": r["off"], "score": r["score"], "max": r["max"],
                 "in_range_frac": r["in_range_frac"], "distinct": r["distinct"],
                 "mean_nonzero": r["mean_nonzero"],
                 "gates": [g["off"] for g in r["gated_pointers"]]}
                for r in count_records]

    def field_ptr_candidates():
        if field_count_off is None:
            return []
        rec = next((r for r in count_records
                    if int(r["off"], 16) == field_count_off), None)
        if not rec:
            return []
        return [{"off": g["off"], "corr": g["corr"],
                 "p1_cntpos_has_ptr": g["p1_cntpos_has_ptr"],
                 "p0_cntzero_no_ptr": g["p0_cntzero_no_ptr"],
                 "note": "present iff field_count>0"} for g in rec["gated_pointers"]]

    def method_ptr_candidate_records():
        out = []
        for off in method_ptr_candidates[:6]:
            out.append({"off": hx(off), "ptr_presence": round(qp[off]["ptr"], 4),
                        "note": "always-present structural pointer, not gated by "
                                "field_count; candidate methods array"})
        return out

    result = {
        "field_count_offset": {
            "best": hx(field_count_off) if field_count_off is not None else None,
            "confidence": "high" if field_ptr_off is not None else "low",
            "candidates": field_count_candidates(),
        },
        "method_count_offset": {
            "best": hx(method_count_off) if method_count_off is not None else None,
            "confidence": "low" if method_count_off is None else "medium",
            "candidates": ([{"off": r["off"], "score": r["score"], "max": r["max"]}
                            for r in count_records
                            if int(r["off"], 16) != field_count_off]),
            "note": ("No second clean u16 count is isolable offline -- the only "
                     "bounded, varied count slot is the field_count. Other u16 "
                     "slots near it overlap live pointer bytes (max==65535) and "
                     "are noise. method_count must be read live near field_count."),
        },
        "field_array_ptr_offset": {
            "best": hx(field_ptr_off) if field_ptr_off is not None else None,
            "confidence": "high" if field_ptr_off is not None else "low",
            "correlated_with_count": hx(field_count_off) if field_count_off is not None else None,
            "candidates": field_ptr_candidates(),
        },
        "method_array_ptr_offset": {
            "best": hx(method_array_ptr_off) if method_array_ptr_off is not None else None,
            "confidence": "low",
            "candidates": method_ptr_candidate_records(),
            "note": ("Methods array is an always-present pointer not gated by "
                     "field_count. Cannot be confirmed offline (no method_count "
                     "to correlate). Earliest non-excluded always-present pointer "
                     "is the leading hypothesis per IL2CPP member order."),
        },
        "self_ref_offsets": [hx(off) for off, frac in self_refs],
        "self_ref_detail": [{"off": hx(off), "frac": round(frac, 4)}
                            for off, frac in self_refs],
        "always_present_pointers": [hx(o) for o in sorted(always_ptr)],
        "sibling_pointer_notes": sibling_notes,
        "limitations": (
            "Derived from %d structs of %d bytes. Pointer window %s..%s. The "
            "capture has NO pointee memory, so FieldInfo stride and the "
            "sub-offsets (field name ptr / field offset u32 / field type ptr) "
            "CANNOT be derived here -- they must be probed live by dereferencing "
            "the field_array_ptr candidate (+0x%x) on a class with known fields."
            % (n, STRUCT_SIZE, hx(PTR_LO), hx(PTR_HI),
               field_ptr_off if field_ptr_off is not None else 0)
        ),
    }

    os.makedirs(outdir, exist_ok=True)
    jpath = os.path.join(outdir, "layout_hypotheses.json")
    with open(jpath, "w", encoding="utf-8") as fh:
        json.dump(result, fh, indent=2, ensure_ascii=False)

    # -----------------------------------------------------------------
    # human-readable summary
    # -----------------------------------------------------------------
    md = []
    md.append("# Live Il2CppClass layout hypotheses (offline-derived)\n\n")
    md.append("Source: `output/p2_research/live_klass_raw_structs.json` "
              "(%d structs, 0x%x bytes each, class name confirmed at +0x50).\n\n" % (n, STRUCT_SIZE))

    md.append("## Hard limitation\n\n")
    md.append("The capture holds only the 0x%x-byte klass struct, not the memory "
              "it points to. FieldInfo **stride** and the **sub-offsets** (field "
              "name ptr / field offset u32 / field type ptr) cannot be derived "
              "from this file; they must be read live by dereferencing the "
              "field_array_ptr below. Everything here is a ranked hypothesis.\n\n" % STRUCT_SIZE)

    md.append("## Top hypotheses\n\n")
    md.append("| member | best offset | confidence |\n|---|---|---|\n")
    md.append("| field_count | %s | %s |\n" % (
        result["field_count_offset"]["best"], result["field_count_offset"]["confidence"]))
    md.append("| field_array_ptr | %s | %s |\n" % (
        result["field_array_ptr_offset"]["best"], result["field_array_ptr_offset"]["confidence"]))
    md.append("| method_count | %s | %s |\n" % (
        result["method_count_offset"]["best"], result["method_count_offset"]["confidence"]))
    md.append("| method_array_ptr | %s | %s |\n\n" % (
        result["method_array_ptr_offset"]["best"], result["method_array_ptr_offset"]["confidence"]))

    md.append("## Self-reference offsets (structural anchors)\n\n")
    md.append("Slots equal to the klass own address (element_class / cast_class "
              "family in IL2CPP):\n\n| offset | self-ref frac |\n|---|---|\n")
    for off, frac in self_refs:
        md.append("| %s | %.1f%% |\n" % (hx(off), frac * 100))
    md.append("\n")

    md.append("## Clean count u16 slots and the pointers they gate\n\n")
    md.append("A real count is bounded (max <= %d), varied, and a paired array "
              "pointer is present exactly when the count > 0.\n\n" % COUNT_MAX)
    md.append("| u16 off | score | max | distinct | mean(nz) | gated pointers |\n")
    md.append("|---|---|---|---|---|---|\n")
    for r in count_records:
        md.append("| %s | %.3f | %d | %d | %.1f | %s |\n" % (
            r["off"], r["score"], r["max"], r["distinct"], r["mean_nonzero"],
            ", ".join("%s(corr=%.2f)" % (g["off"], g["corr"]) for g in r["gated_pointers"]) or "-"))
    md.append("\n")

    md.append("## field_array_ptr candidates (best: %s)\n\n" % result["field_array_ptr_offset"]["best"])
    md.append("| offset | corr | P(cnt>0 -> ptr) | P(cnt=0 -> null) |\n|---|---|---|---|\n")
    for c in result["field_array_ptr_offset"]["candidates"]:
        md.append("| %s | %.3f | %.3f | %.3f |\n" % (
            c["off"], c["corr"], c["p1_cntpos_has_ptr"], c["p0_cntzero_no_ptr"]))
    md.append("\n")

    md.append("## method_array_ptr candidates (best: %s)\n\n" % result["method_array_ptr_offset"]["best"])
    md.append("Always-present structural pointers not gated by field_count:\n\n")
    md.append("| offset | ptr presence |\n|---|---|\n")
    for c in result["method_array_ptr_offset"]["candidates"]:
        md.append("| %s | %.3f |\n" % (c["off"], c["ptr_presence"]))
    md.append("\n")

    if sibling_notes:
        md.append("## Sibling-pointer notes (fixed deltas)\n\n")
        for s in sibling_notes:
            md.append("- %s\n" % s)
        md.append("\n")

    md.append("## Reasoning and confidence\n\n")
    md.append("- **field_count (%s) -- HIGH**: the only bounded, varied u16 slot; "
              "it gates pointer(s) that appear exactly when it is > 0.\n"
              % result["field_count_offset"]["best"])
    md.append("- **field_array_ptr (%s) -- HIGH**: highest gating correlation with "
              "field_count.\n" % result["field_array_ptr_offset"]["best"])
    md.append("- **method_count -- LOW**: no second clean count is isolable "
              "offline; neighbouring u16 slots overlap pointer bytes. Read live.\n")
    md.append("- **method_array_ptr (%s) -- LOW**: best-guess always-present "
              "pointer; cannot be confirmed without a method_count to correlate.\n"
              % result["method_array_ptr_offset"]["best"])
    md.append("\n## Next live step\n\n")
    md.append("Dereference field_array_ptr (+%s) on a class with known fields, "
              "then scan the pointee for the FieldInfo stride and the "
              "name/offset/type sub-offsets.\n" % (result["field_array_ptr_offset"]["best"] or "?"))

    mpath = os.path.join(outdir, "layout_hypotheses.md")
    with open(mpath, "w", encoding="utf-8") as fh:
        fh.write("".join(md))

    # console summary
    print("structs:", n)
    print("self-ref offsets:", [hx(o) for o, _ in self_refs])
    print("clean count offsets:", [r["off"] for r in count_records])
    print("field_count best:", result["field_count_offset"]["best"],
          "(%s)" % result["field_count_offset"]["confidence"])
    print("field_array_ptr best:", result["field_array_ptr_offset"]["best"],
          "(%s)" % result["field_array_ptr_offset"]["confidence"])
    print("method_count best:", result["method_count_offset"]["best"],
          "(%s)" % result["method_count_offset"]["confidence"])
    print("method_array_ptr best:", result["method_array_ptr_offset"]["best"],
          "(%s)" % result["method_array_ptr_offset"]["confidence"])
    print("wrote:", jpath)
    print("wrote:", mpath)
    return 0


if __name__ == "__main__":
    sys.exit(main())
