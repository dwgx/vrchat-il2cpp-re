# IL2CPP Memory-Dump Toolkit

A general-purpose collection of Python scripts for analyzing **IL2CPP-
compiled Unity game minidumps offline**. The toolkit reads MDMP /
Windows kernel crash dumps that the **end user has produced from a
copy of a game they personally own and run**, and helps the user
explore the in-memory class metadata that any IL2CPP runtime exposes.

## What this is NOT

- **Not a cheat, exploit, or anti-cheat bypass.** Nothing in this
  repository modifies, patches, injects into, or otherwise tampers
  with any running game process or game binary.
- **Not a redistribution of any game, asset, or copyrighted code.**
  No `GameAssembly.dll`, `UnityPlayer.dll`, `global-metadata.dat`,
  game manifests, audio, textures, scripts, or any other content
  belonging to any third party is shipped here. Users supply their
  own dump, which they are free to produce only from a legitimate
  copy of a game they own.
- **Not affiliated with any game studio.** Any class, method, or
  field names that appear in tool output are the user's own
  observations of their own runtime memory, not material taken from
  this repository.

## What this is

Educational tooling demonstrating the standard offline IL2CPP
analysis pipeline:

```
Windows Complete Memory Dump (.dmp, written by the Windows kernel
on system crash, owned by the user)
    │
    ▼
tools/kerneldump_to_minidump.py   - extract one process's user-mode
                                    memory into an MDMP minidump via
                                    Volatility3
    │
    ▼
tools/extract_precise_dump.py --auto-heap
                                  - scan all user-mode memory ranges
                                    for Il2CppClass self-reference
                                    pattern, list classes/methods
    │
    ▼
tools/extract_field_types_from_dump.py
                                  - resolve each class's FieldInfo
                                    array into (name, type, offset)
    │
    ▼
tools/run_full_pipeline.py        - orchestrate name resolution from
                                    user-supplied vocabulary sources
```

## Requirements

- Windows 10/11 (admin if you plan to configure Complete Memory Dump
  on your own machine)
- Python 3.10+
- `pip install volatility3 frida psutil`

## Inputs You Provide

This repository contains **no inputs**. To run anything you need:

1. A minidump (`.dmp`) that you produced yourself with a tool such
   as Sysinternals Procdump or Windows Task Manager, of a game
   process you legitimately own and ran on your own machine, OR
2. A Windows complete memory dump (`C:\Windows\MEMORY.DMP`) that
   Windows generated from a system crash on your own machine.

The tools produce derived data files locally in `data/` and
`output/`, which are excluded from version control by default.

## DMCA / Removal Requests

If you are a rights-holder who believes any specific commit or file
in this repository requires takedown under the DMCA or analogous
local copyright law, please open an issue or email the address
listed in the repository profile. The owner will respond within
seven days. The intent of this repository is purely educational.

## License

MIT — see [LICENSE](LICENSE).

The license applies only to the source code in this repository.
The user is responsible for ensuring their use of any third-party
runtime, dump file, or derived metadata complies with the relevant
EULA and local law.
