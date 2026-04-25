#!/usr/bin/env python3
"""
Merge all community deobfuscation mapping files into a single comprehensive JSON.
Reads from external/deob-maps/ repos and writes to output/all_community_mappings.json.
Also updates output/master_vocabulary.json with new readable names.
"""

import gzip
import json
import os
import re
from collections import defaultdict

BASE = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "external", "deob-maps")
OUTPUT = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "output")


def is_obfuscated_name(name):
    """Check if a name looks like an Il2CppDumper obfuscated name."""
    obf_patterns = [
        "PublicSealedva", "PublicAbstract", "PublicStatic",
        "MonoBehaviourPublic", "ObjectPublic", "ValueTypePublic",
        "InterfacePublicAbstract", "EnumPublicSealed", "EnumNPublicSealed",
        "PrivateImplementationDetails", "Unique", "MonoBehaviour1Public",
        "PropertyAttributePublic", "ScriptableObjectPublic",
        "MonoBehaviourPrivate", "ObjectPrivate", "ValueTypePrivate",
    ]
    return any(pat in name for pat in obf_patterns)


def parse_csv_line(line):
    """Parse a semicolon-separated CSV line, returning (obfuscated, real_name, score)."""
    line = line.strip()
    if not line:
        return None
    parts = line.split(";")
    if len(parts) < 2:
        return None
    obf = parts[0].lstrip(".")  # Remove leading dot
    real = parts[1]
    score = parts[2] if len(parts) > 2 else "0"
    return obf, real, score


def load_gz_csv(filepath):
    """Load a gzipped CSV file and return list of (obf, real, score) tuples."""
    mappings = []
    with gzip.open(filepath, "rt", encoding="utf-8-sig") as f:
        for line in f:
            result = parse_csv_line(line)
            if result:
                mappings.append(result)
    return mappings


def load_plain_csv(filepath):
    """Load a plain CSV file and return list of (obf, real, score) tuples."""
    mappings = []
    with open(filepath, "r", encoding="utf-8-sig") as f:
        for line in f:
            result = parse_csv_line(line)
            if result:
                mappings.append(result)
    return mappings


def extract_build_number(filename):
    """Extract build number from filename like '1043.0.csv.gz' -> '1043'."""
    match = re.match(r"(\d+)", os.path.basename(filename))
    if match:
        return match.group(1)
    return os.path.basename(filename).replace(".csv.gz", "").replace(".csv", "")


def main():
    all_by_build = {}
    all_sources = []

    # ==========================================================
    # 1. VRChat-Deobfuscation-Maps (13 builds)
    # ==========================================================
    vrcd_dir = os.path.join(BASE, "VRChat-Deobfuscation-Maps")
    vrcd_files = sorted([f for f in os.listdir(vrcd_dir) if f.endswith(".csv.gz")])
    print(f"=== VRChat-Deobfuscation-Maps: {len(vrcd_files)} files ===")
    for fname in vrcd_files:
        build = extract_build_number(fname)
        filepath = os.path.join(vrcd_dir, fname)
        mappings = load_gz_csv(filepath)
        build_dict = {}
        for obf, real, score in mappings:
            build_dict[obf] = real
        all_by_build[build] = build_dict
        all_sources.append({
            "repo": "VRChat-Deobfuscation-Maps",
            "file": fname,
            "build": build,
            "count": len(build_dict)
        })
        print(f"  Build {build}: {len(build_dict)} mappings")

    # ==========================================================
    # 2. EWorldTools-Maps (build 1275)
    # ==========================================================
    ewt_path = os.path.join(BASE, "EWorldTools-Maps", "VRChat", "1275.csv.gz")
    if os.path.exists(ewt_path):
        mappings = load_gz_csv(ewt_path)
        build_dict = {}
        for obf, real, score in mappings:
            build_dict[obf] = real
        all_by_build["1275"] = build_dict
        all_sources.append({
            "repo": "EWorldTools-Maps",
            "file": "1275.csv.gz",
            "build": "1275",
            "count": len(build_dict)
        })
        print(f"\n=== EWorldTools-Maps ===")
        print(f"  Build 1275: {len(build_dict)} mappings")

    # ==========================================================
    # 3. lilfluff-Maps (DeobfuscationMap.csv.gz + 2 plain CSVs)
    # ==========================================================
    print(f"\n=== lilfluff-Maps ===")

    # Main .gz file
    lilfluff_gz = os.path.join(BASE, "lilfluff-Maps", "DeobfuscationMap.csv.gz")
    if os.path.exists(lilfluff_gz):
        mappings = load_gz_csv(lilfluff_gz)
        build_dict = {}
        for obf, real, score in mappings:
            build_dict[obf] = real
        all_by_build["lilfluff_default"] = build_dict
        all_sources.append({
            "repo": "lilfluff-Maps",
            "file": "DeobfuscationMap.csv.gz",
            "build": "lilfluff_default",
            "count": len(build_dict)
        })
        print(f"  DeobfuscationMap.csv.gz: {len(build_dict)} mappings")

    # Plain CSVs in "Deob 1219 WIP"
    wip_dir = os.path.join(BASE, "lilfluff-Maps", "Deob 1219 WIP")
    if os.path.isdir(wip_dir):
        for fname in sorted(os.listdir(wip_dir)):
            if fname.endswith(".csv"):
                fpath = os.path.join(wip_dir, fname)
                mappings = load_plain_csv(fpath)
                build_num = extract_build_number(fname.replace("CustomMap", ""))
                build_key = f"lilfluff_{build_num}"
                build_dict = {}
                for obf, real, score in mappings:
                    build_dict[obf] = real
                all_by_build[build_key] = build_dict
                all_sources.append({
                    "repo": "lilfluff-Maps",
                    "file": fname,
                    "build": build_key,
                    "count": len(build_dict)
                })
                print(f"  {fname}: {len(build_dict)} mappings")

    # ==========================================================
    # ANALYZE AND CATEGORIZE
    # ==========================================================
    print(f"\n=== Analysis ===")

    all_real_names = set()
    all_obf_to_real = {}
    real_name_sources = defaultdict(set)

    for build, mappings in all_by_build.items():
        for obf, real in mappings.items():
            all_real_names.add(real)
            real_name_sources[real].add(build)
            if obf not in all_obf_to_real:
                all_obf_to_real[obf] = real

    # Separate truly readable names from obfuscated-to-obfuscated mappings
    readable_real_names = set()
    obf_to_obf_mappings = set()

    for name in all_real_names:
        if is_obfuscated_name(name):
            obf_to_obf_mappings.add(name)
        else:
            readable_real_names.add(name)

    print(f"Total unique real names (all): {len(all_real_names)}")
    print(f"  Truly readable: {len(readable_real_names)}")
    print(f"  Still obfuscated (cross-build mappings): {len(obf_to_obf_mappings)}")
    print(f"Total unique obfuscated keys: {len(all_obf_to_real)}")
    print(f"Total builds/sources: {len(all_by_build)}")

    # ==========================================================
    # BUILD OUTPUT JSON
    # ==========================================================
    sorted_all_real = sorted(all_real_names)
    sorted_readable = sorted(readable_real_names)

    output_data = {
        "by_build": {},
        "all_real_names": sorted_all_real,
        "readable_real_names": sorted_readable,
        "merged_obf_to_real": all_obf_to_real,
        "stats": {
            "total_builds": len(all_by_build),
            "total_unique_mappings": sum(len(m) for m in all_by_build.values()),
            "total_unique_real_names": len(all_real_names),
            "total_readable_real_names": len(readable_real_names),
            "total_obf_to_obf_crossbuild": len(obf_to_obf_mappings),
            "total_unique_obf_keys": len(all_obf_to_real),
            "sources": all_sources,
            "builds": sorted(all_by_build.keys())
        }
    }

    for build in sorted(all_by_build.keys()):
        output_data["by_build"][build] = all_by_build[build]

    os.makedirs(OUTPUT, exist_ok=True)
    out_path = os.path.join(OUTPUT, "all_community_mappings.json")
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(output_data, f, ensure_ascii=False, indent=2)

    file_size = os.path.getsize(out_path)
    print(f"\nWrote {out_path}")
    print(f"  File size: {file_size:,} bytes")

    # ==========================================================
    # UPDATE MASTER VOCABULARY
    # ==========================================================
    master_path = os.path.join(OUTPUT, "master_vocabulary.json")
    try:
        with open(master_path, "r", encoding="utf-8") as f:
            master = json.load(f)
    except Exception:
        master = {"names": [], "total_signatures": 0, "unique_names": 0}

    existing_names = set(master.get("names", []))
    print(f"\nExisting master vocabulary: {len(existing_names)} names")

    new_names = readable_real_names - existing_names
    print(f"New names to add from community maps: {len(new_names)}")

    if new_names:
        all_names = sorted(existing_names | readable_real_names)
        master["names"] = all_names
        master["total_signatures"] = len(all_names)
        master["unique_names"] = len(all_names)

        if "sources" not in master:
            master["sources"] = {}
        master["sources"]["community_deob_maps"] = {
            "total_readable_names": len(readable_real_names),
            "new_names_added": len(new_names),
            "repos": ["VRChat-Deobfuscation-Maps", "EWorldTools-Maps", "lilfluff-Maps"],
            "builds_covered": sorted(all_by_build.keys())
        }

        with open(master_path, "w", encoding="utf-8") as f:
            json.dump(master, f, ensure_ascii=False, indent=2)

        master_size = os.path.getsize(master_path)
        print(f"Updated master vocabulary: {len(all_names)} names ({master_size:,} bytes)")
    else:
        print("No new names to add - master vocabulary already up to date.")

    # ==========================================================
    # PRINT SAMPLES
    # ==========================================================
    print(f"\n=== Sample readable real names (first 30) ===")
    for name in sorted_readable[:30]:
        builds = sorted(real_name_sources[name])
        bstr = ", ".join(builds[:4])
        if len(builds) > 4:
            bstr += "..."
        print(f"  {name}  [in {len(builds)} builds: {bstr}]")

    print(f"\n=== VRC-prefixed names (first 40) ===")
    vrc_names = sorted([n for n in readable_real_names if "VRC" in n or "vrc" in n])
    for name in vrc_names[:40]:
        print(f"  {name}")
    print(f"  ... total VRC-prefixed: {len(vrc_names)}")

    print(f"\n=== Namespace breakdown ===")
    ns_counts = defaultdict(int)
    for name in readable_real_names:
        if "." in name:
            ns = name.split(".")[0]
            ns_counts[ns] += 1
        elif "::" in name:
            ns = name.split("::")[0]
            ns_counts[ns] += 1
        else:
            ns_counts["(no namespace)"] += 1
    for ns, count in sorted(ns_counts.items(), key=lambda x: -x[1])[:25]:
        print(f"  {ns}: {count}")

    print("\nDone.")


if __name__ == "__main__":
    main()
