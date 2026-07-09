"""Deeper analysis of obfuscated exports."""
import pefile
import re
from collections import Counter

DLL_PATH = r"D:\Steam\steamapps\common\VRChat\GameAssembly.dll"
pe = pefile.PE(DLL_PATH, fast_load=True)
pe.parse_data_directories(directories=[pefile.DIRECTORY_ENTRY["IMAGE_DIRECTORY_ENTRY_EXPORT"]])

exports = []
for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
    name = exp.name.decode("utf-8") if exp.name else f"ordinal_{exp.ordinal}"
    exports.append({"name": name, "ordinal": exp.ordinal, "rva": exp.address})

# Check how many point to same RVA (thunks/stubs)
rva_counts = Counter(e["rva"] for e in exports)
print("RVAs shared by multiple exports (possible stubs/thunks):")
for rva, count in rva_counts.most_common(15):
    if count > 1:
        names = [e["name"] for e in exports if e["rva"] == rva]
        print(f"  RVA 0x{rva:x} ({count} exports): {names}")

# The 3 real il2cpp exports
print("\nThe 3 surviving il2cpp_ exports:")
for e in exports:
    if e["name"].startswith("il2cpp_"):
        print(f"  {e['name']:<40s} ordinal={e['ordinal']}  RVA=0x{e['rva']:x}")

# Known system/utility exports
known_system = ["DllCanUnloadNow", "DllGetActivationFactory", "CloseNLSocket",
                "CreateNLSocket", "ReadEvents", "CloseZStream", "CreateZStream",
                "Flush", "ReadZStream", "WriteZStream"]
print("\nKnown system/utility exports:")
for e in sorted(exports, key=lambda x: x["name"]):
    if e["name"] in known_system:
        print(f"  {e['name']:<40s} RVA=0x{e['rva']:x}")

# Detect obfuscation patterns
print("\n--- Obfuscation pattern analysis ---")
obfuscated_11 = [e for e in exports if re.match(r"^[A-Za-z]{11}$", e["name"])]
print(f"Exports matching pattern [A-Za-z]{{11}} (11 random alpha): {len(obfuscated_11)}")

# Length distribution
non_special = [e for e in exports if not e["name"].startswith("il2cpp_") and e["name"] not in known_system]
lengths = Counter(len(e["name"]) for e in non_special)
print("\nName length distribution (non-system, non-il2cpp):")
for length in sorted(lengths.keys()):
    print(f"  len={length:2d}: {lengths[length]:3d} exports")

# Check if obfuscated exports map to the same ~range of RVAs as the il2cpp ones
il2cpp_rvas = [e["rva"] for e in exports if e["name"].startswith("il2cpp_")]
obf_rvas = sorted(e["rva"] for e in non_special if e["name"] not in known_system)
print(f"\nil2cpp_ export RVA range: {[hex(r) for r in il2cpp_rvas]}")
print(f"Obfuscated export RVA range: 0x{min(obf_rvas):x} - 0x{max(obf_rvas):x}")

# Check how many land near the 0xa9xxxx cluster
cluster_a9 = [r for r in obf_rvas if 0xa90000 <= r <= 0xaa0000]
print(f"Exports in RVA cluster 0xa9xxxx: {len(cluster_a9)} / {len(obf_rvas)}")
print("(This cluster likely contains the il2cpp API dispatch table)")

# Check for ordinal gaps (may indicate removed exports)
ordinals = sorted(e["ordinal"] for e in exports)
gaps = []
for i in range(len(ordinals)-1):
    if ordinals[i+1] - ordinals[i] > 1:
        gaps.append((ordinals[i], ordinals[i+1]))
print(f"\nOrdinal gaps (potential removed exports): {gaps}")
print(f"Ordinal range: {min(ordinals)} - {max(ordinals)}")

pe.close()
