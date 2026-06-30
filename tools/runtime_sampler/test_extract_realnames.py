#!/usr/bin/env python
"""Behaviour lock for the runtime-instance real-name scorer.

These synthetic cases pin the contract gate_decompile_names.py relies on:
  - a clean DTO (consistent JSON schema / GameObject.name) yields the RIGHT name
  - a noise-only class yields proposed_name=null (the item-20 anti-inflation
    lesson: prefer null over a structural / generic guess)
  - JSON keys outrank GameObject.name outrank string values
  - every accepted row clears name_quality.is_weak_name and the gate's format

Run: python tools/runtime_sampler/test_extract_realnames.py
(exit 0 = all green, non-zero = drift). No external framework needed.
"""
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
sys.path.insert(0, str(Path(__file__).resolve().parent))
sys.path.insert(0, str(Path(__file__).resolve().parent.parent))

from extract_realnames import score_class, meaningful_tokens, to_pascal, VALID
from name_quality import is_weak_name

fails = []


def check(cond, msg):
    if not cond:
        fails.append(msg)
        print(f"  FAIL: {msg}")
    else:
        print(f"  ok: {msg}")


# --- 1) clear DTO: repeated JSON schema -> the schema-derived name -----------
avatar_perf = [
    {"fields": {"f_3A": "https://api.vrchat.cloud/avatars/x"},
     "strings": ["avatar_tune"],
     "json_keys": ["avatarPerformance", "performanceRating", "id"],
     "tostring": "AvatarPerformanceData (clone)",
     "gameobject_name": "AvatarTuneButton"},
    {"fields": {"f_3A": "https://api.vrchat.cloud/avatars/y"},
     "strings": ["avatar_tune", "perf"],
     "json_keys": ["avatarPerformance", "performanceRating", "url"],
     "tostring": "AvatarPerformanceData",
     "gameobject_name": "AvatarTuneButton (1)"},
]
r = score_class("BaseClass290Impl_828C", avatar_perf)
print("DTO case ->", r["proposed_name"], r["confidence"])
check(r["proposed_name"] == "AvatarPerformanceData",
      f"DTO resolves to AvatarPerformanceData (got {r['proposed_name']})")
check(r["confidence"] >= 0.45, "DTO confidence above floor")
check(any(e["source"] == "json_keys" for e in r["evidence"]),
      "DTO winning evidence cites json_keys")
check(not is_weak_name(r["proposed_name"]), "DTO name passes is_weak_name")
check(bool(VALID.match(r["proposed_name"])), "DTO name passes gate format")


# --- 2) noise-only: generic keys + junk strings -> NULL ----------------------
noise = [
    {"fields": {"f_1": "true", "f_2": "12345"},
     "strings": ["http://x", "null", "true", "0"],
     "json_keys": ["id", "name", "value", "count"],
     "tostring": "", "gameobject_name": "GameObject"},
    {"fields": {"f_1": "false"},
     "strings": ["https://y", "false"],
     "json_keys": ["id", "type", "items"],
     "tostring": "", "gameobject_name": "GameObject (1)"},
]
r = score_class("BaseClass7Sibling_4F24", noise)
print("noise case ->", r["proposed_name"], r["confidence"])
check(r["proposed_name"] is None, "noise-only yields null (no structural guess)")


# --- 3) empty instances -> null, never crashes -------------------------------
r = score_class("Obf_Empty", [])
check(r["proposed_name"] is None and r["confidence"] == 0.0,
      "empty instance list yields null")


# --- 4) signal hierarchy: JSON keys beat a conflicting GameObject.name -------
conflict = [
    {"fields": {}, "strings": [],
     "json_keys": ["shopProduct", "priceTokens", "ownedStatus"],
     "tostring": "", "gameobject_name": "GenericRoot"},
    {"fields": {}, "strings": [],
     "json_keys": ["shopProduct", "priceTokens"],
     "tostring": "", "gameobject_name": "GenericRoot"},
]
r = score_class("BaseClass55Impl_AAAA", conflict)
print("hierarchy case ->", r["proposed_name"], r["confidence"])
check(r["proposed_name"] is not None and r["proposed_name"].startswith("ShopProduct"),
      f"json keys win over gameobject (got {r['proposed_name']})")


# --- 5) GameObject.name wins when there are no JSON keys ----------------------
go_only = [
    {"fields": {}, "strings": ["click"],
     "json_keys": [], "tostring": "",
     "gameobject_name": "FavoritesPanel"},
    {"fields": {}, "strings": ["click"],
     "json_keys": [], "tostring": "",
     "gameobject_name": "FavoritesPanel (1)"},
]
r = score_class("BaseClass9_BBBB", go_only)
print("gameobject case ->", r["proposed_name"], r["confidence"])
check(r["proposed_name"] == "FavoritesPanel",
      f"gameobject-only resolves to FavoritesPanel (got {r['proposed_name']})")


# --- 6) one-off / single instance with weak signal stays null ----------------
oneoff = [
    {"fields": {}, "strings": ["x"], "json_keys": ["data"],
     "tostring": "", "gameobject_name": ""},
]
r = score_class("Obf_OneOff", oneoff)
check(r["proposed_name"] is None,
      f"single weak instance yields null (got {r['proposed_name']})")


# --- 7) tokeniser sanity -----------------------------------------------------
check(meaningful_tokens("avatarPerformance") == ["avatar", "performance"],
      "camelCase splits to domain tokens")
check(meaningful_tokens("performance_rating") == ["performance", "rating"],
      "snake_case splits to domain tokens")
check(meaningful_tokens("id") == [] and meaningful_tokens("url") == [],
      "generic words drop to nothing")
check(to_pascal(["shop", "product"]) == "ShopProduct", "to_pascal joins tokens")


if fails:
    print(f"\nDRIFT: {len(fails)} failing assertion(s)")
    sys.exit(1)
print("\nALL GREEN — runtime real-name scorer locked")
sys.exit(0)
