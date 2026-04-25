# NOTICE — Provenance, Scope, and DMCA Contact

## What this repository contains

- Original Python tools written by the repository owner for analyzing
  IL2CPP-compiled Unity application memory dumps offline.
- Generated artifacts (JSON/CSV/CS files under `data/` and `output/`)
  produced by running those tools on memory dumps the repository
  owner captured from their own legitimately-acquired copy of an
  IL2CPP application running on their own machine.

## What this repository does NOT contain

- Game executables, libraries, or assets (e.g. `GameAssembly.dll`,
  `UnityPlayer.dll`, `global-metadata.dat`, audio, textures, scripts,
  game data files).
- Compiled IL or C# source code reconstructed from any third-party
  application.
- Any tool that injects into, patches, or otherwise tampers with a
  running game process.
- Anti-cheat bypasses, exploits, or cheating utilities.

The artifact files contain class/method/field names, type layouts,
and offsets observed in memory by the repository owner. They do not
contain copyrighted source code, game logic, or compiled binaries.

## Intent

Educational and research, documenting a reproducible workflow for
offline IL2CPP minidump analysis. Workflows of this type are
commonly used by:

- Security researchers studying anti-tamper / runtime protection
- Reverse-engineering hobbyists understanding how Unity IL2CPP
  organizes class metadata at runtime
- Mod toolchain authors providing compatibility shims for software
  the user already owns

## DMCA / takedown contact

If you are a rights holder and you believe specific files in this
repository require removal under the U.S. Digital Millennium
Copyright Act (DMCA) or analogous local copyright law, please open
an issue on this repository or email the address listed in the
repository owner's GitHub profile. Provide:

- The URL of the file(s) you believe are infringing.
- A short description of the rights you claim and why the file is
  infringing.
- Your contact information.

The repository owner will respond within seven (7) calendar days.
Files identified in good-faith requests will be removed pending
resolution.

## Use of this repository

By using or studying this repository, you acknowledge that:

- You will only run the tools against memory dumps you have produced
  from software you legitimately own and run on your own hardware.
- You will not redistribute the third-party software whose runtime
  state was the subject of the analysis.
- You are solely responsible for ensuring your use complies with the
  End User License Agreement of any software involved and with
  applicable local law.
