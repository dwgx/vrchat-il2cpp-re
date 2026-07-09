# VRChat Avatar-Ripping: Defensive Playbook

> **Purpose:** Understand how avatar/model theft works against VRChat so we can **detect and mitigate** it. This is a defender's reference. It deliberately omits turnkey theft tooling. It consolidates 44 parallel research agents (mechanism deep-dives, VRChat binary-surface analysis grounded in this project's `GameAssembly.dll` build 2026-06-25, and per-vector defense design).
>
> Build context: Unity 6 (6000.0.60f1-DWR), IL2CPP + Beebyte obfuscation, EAC via EOS SDK. All RVAs are @ ImageBase `0x180000000` and confirmed by capstone disassembly unless marked "name-only".

---

## 0. The one law that governs everything

**A client that renders an avatar must hold that avatar's geometry, textures, and rig in its own memory in plaintext.** Every network cipher, CDN signature, metadata encryption, and obfuscation layer sits *upstream* of that moment. Therefore:

- No client-side crypto choice can make extraction *impossible* for an attacker who controls the machine.
- Defense is not "prevent decryption." Defense is **(1) don't load untrusted content, (2) make in-process tampering detectable + bannable, (3) gate asset delivery on a server-validated trust signal, (4) raise re-tooling cost, (5) enable attribution/takedown.**

Everything below is organized around that reality.

---

## 1. Threat model — the ripping attack tree

Two harm classes, ranked:

| Harm class | Scenario | What it steals | Stopped by |
|---|---|---|---|
| **Online rip** (higher harm) | Rip an avatar *worn by another user* in a shared instance | Other creators' live avatars | **Server-side EAC-session gate — survives client bypass** |
| **Local rip** | Rip content the attacker can already load (own client, cache) | Downloaded avatars/worlds | Largely uncompensatable client-side once EAC is bypassed |

Attack vectors, by prevalence × severity:

1. **On-disk cache extraction** (no injection, bypasses all in-process AC) — highest prevalence, EAC-blind
2. **Post-decrypt object harvesting** (let Unity decrypt, walk the live GameObject/Mesh graph) — most common in-process method, key-agnostic
3. **GPU pipeline capture** (RenderDoc/Nsight/NinjaRipper) — near-undefeatable, hardware-adjacent
4. **Managed-heap mesh extraction** (hook Mesh/SkinnedMeshRenderer getters)
5. **AssetBundle key interception** (hook the `EncryptionKey*` seam)
6. **Network MITM of CDN bundle download** (captures ciphertext — low value without key)
7. **Content-side param theft** (PhysBones/constraints/animator) — metadata, not mesh
8. **Impostor / pedestal / DB-scrape** (lower-fidelity or metadata-only)

---

## 2. VRChat-specific attack surface (grounded in this build)

### 2.1 Avatar load pipeline (network → engine → geometry)

```
ApiAvatar.assetUrl
  → AssetBundleDownloadManager  (FileManager\, name-only)
  → BaseDownloadHandle → AvatarDownloadHandle / AvatarPartDownloadHandle
  → Downloader (UnityWebRequestAssetBundle)
  → AssetCache / CachedAssetBundle          (on-disk cache)
  → AssetBundleFooter (custom magic trailer; .cctor @ 0xA0C8400)
  → UnityEngine.AssetBundle.LoadAsset       ← ENGINE BOUNDARY (decrypt done)
  → VRCAvatarManager → GameObject instantiate
  → SkinnedMeshRenderer / MeshFilter / Mesh ← GEOMETRY IN PLAINTEXT HERE
```

### 2.2 CRITICAL CORRECTION to prior attack-surface notes

**Avatar bundle protection = Unity's built-in AssetBundle encryption** (`EncryptionKey` / `EncryptionKeyProxy` in `UnityPlayer.dll`, ChaCha-based archive cipher), reached via `DownloadHandlerAssetBundle::Create(..., EncryptionKey*)`. It is **NOT** vrc_fast_crypto / PhotonEncryptor / libsodium — those are network/auth/signing and are routinely misattributed by ripper writeups:

| Plugin | Real purpose | Bundle-relevant? |
|---|---|---|
| `UnityPlayer.dll` `EncryptionKey`/`EncryptionKeyProxy` | **Avatar/world bundle cipher** | **YES — this is the one** |
| `vrc_fast_crypto.dll` (Ed25519, 4 exports) | Message signing/verify | No |
| `PhotonEncryptorPlugin.dll` (`egdecrypt2`, bcrypt AES) | Photon network transport | No |
| `libsodium.dll` (650 exports) | Session/API/local crypto toolbox | Indirect only |

The plaintext key transits **GameAssembly managed heap → il2cpp icall thunk → UnityPlayer native cipher init** — a momentary, hookable location. But post-decrypt harvesting (vector #2) doesn't even need the key.

### 2.3 Geometry accessor hook targets (confirmed RVAs)

The functions a mesh-ripper trampolines. All share the IL2CPP static-init prologue `... sub rsp,X ; cmp byte ptr [rip+disp32],0 ; jne` — a defender baselines the first ~16 bytes of each:

| Function | RVA | Ripper use |
|---|---|---|
| `SkinnedMeshRenderer.get_sharedMesh` | `0x7BB2D90` | mesh handle |
| `SkinnedMeshRenderer.get_bones` | `0x7BB2C40` | rig transforms |
| `SkinnedMeshRenderer.BakeMesh` | `0x7BB3200` | **one-call posed-geometry grab** |
| `Mesh.get_vertices` | `0x7BBAB70` | vertices |
| `Mesh.get_triangles` | `0x7BBE380` | index buffer |
| `Mesh.get_boneWeights` / `get_bindposes` | `0x7BC0F90` / `0x7BB8A60` | skin weights / bind matrices |
| `Renderer.get_sharedMaterials` | `0x7B94C10` | material/shader pull |
| `AssetBundle.LoadAsset_Internal` | `0x7B2F150` | snatch assets pre-instantiation |
| `AssetBundle.LoadAllAssetsAsync` / `GetAllAssetNames` | `0x7B2F7D0` / `0x7B2FA60` | bulk asset access |

Deeper icall boundary (obfuscation-proof hook site): `Mesh.get_vertices` → dispatch stub `0xA7BF70` → `call 0x3165310` into engine native Mesh. The game's own geometry traversal is also a hook surface: `MeshPerformanceScanner.AnalyzeSkinnedMeshRenderers` @ `0xA769160`, `AnalyzeGeometry` @ `0xA7680A0`.

### 2.4 Texture plaintext boundary (vrc_image_loader.dll / vrc_texture_direct_copy.dll)

`vrc_image_loader.dll` is a **Rust CPU image decoder** (image-0.25, png/jpeg/webp/gif) — compressed bytes → raw RGBA in heap. Highest-value hook sites (the plaintext-pixel boundary):

- `image_as_bytes` (`0x5B270`) — ptr+len to full decoded buffer (single highest-value hook)
- `on_texture_update` (`0x45770`) + `texture_upload_register` (`0x5CA40`) — pixels+dims+format right before GPU upload
- `image_load` (`0x5BD20`), `image_clone` (`0x5B3E0`) — duplicate buffer without disturbing original
- `vrc_texture_direct_copy.dll`: `VRCTexCopy_GetTexturePtr` (`0x1420`) — CPU-readable pointer to GPU-copied texture

Defender: EAT-integrity + prologue baseline on these exports; callback-pointer pinning on `get_texture_update_callback` / `VRCTexCopy_GetRenderEventFunc` (a swapped callback intercepts without patching prologues).

### 2.5 The EAC dependency collapse (the load-bearing insight)

**Every *local* anti-ripper defense is one control — EAC kernel process-integrity — wearing five hats.** They all fall together the instant the protected bootstrapper (`start_protected_game.exe`) is skipped:

| Defense | Depends on EAC? | After bypass |
|---|---|---|
| Block DLL injection (MelonLoader/BepInEx) | YES (hard) | **GONE** |
| Block OpenProcess VM_READ / handle strip | YES (hard) | **GONE** |
| Block debug attach / anti-debug | YES (hard) | **GONE** |
| Client integrity / tamper detection | YES (hard) | **GONE** |
| Image-load notification (foreign DLLs) | YES (hard) | **GONE** |
| **Server-side EAC-session room-join gate** | **NO (server)** | **SURVIVES** |
| **Opaque signed integrity messages** | **NO (server)** | **SURVIVES** |

Consequence: the **only** durable perimeter is server-side. A bypassed offline client authenticates but is refused room joins (`Fail("")` on `BeforeJoin` when `AuthCookie eacStatus` is absent). It therefore **cannot reach avatars worn by others** — which is why the high-harm online rip is contained server-side while local rip is not.

---

## 3. Defense matrix (vector × control × effectiveness)

| Vector | Best defense | Effectiveness | Honest limit |
|---|---|---|---|
| On-disk cache extraction | Per-install cache encryption (key never plaintext) + **server-side upload provenance** (reject re-upload of non-authored content) | Medium | EAC-blind; only provenance actually contains it |
| Post-decrypt object harvest | Server-gate avatar-bundle *delivery* on live EAC session; EAC integrity sweep | Medium-High (online) / Low (local) | Assets are plaintext in-process by definition |
| GPU pipeline capture | ETW-based renderer/hook detection; `renderdoc.dll`/`RENDERDOC_GetAPI` probe; swapchain vtable baseline | **Low — near-undefeatable** | Capture layer sits below the game entirely |
| Managed-heap mesh hook | Prologue-hash sweep of §2.3 RVAs; RWX/foreign-module scan | High *if EAC present* | Zero if EAC bypassed |
| Bundle key interception | Attest `EncryptionKeyProxy`/`Create` seam; per-content ephemeral keys (`crypto_kx`) | Medium | Post-decrypt harvest sidesteps it |
| Network MITM | (Already strong) TLS + bundle cipher; cert pinning | High | Attacker gets only ciphertext — low-value vector |
| PhysBones/param theft | Rate-limit animator-param reads; accept as low-harm | Low | Params are observable by design |
| Impostor exploitation | Keep impostor geometry decimated/non-invertible | Medium | Impostor is lossy — limited theft value |

**Near-undefeatable, state honestly:** GPU capture and local post-decrypt harvest by a machine-owner. Do not promise creators these are "prevented" — they are *raised in cost* and *detectable when in-process*.

## 4. Detection playbook (prioritized telemetry)

Ordered by fidelity. Client signals are *inputs*; the server is the *judge* — anything computed and acted on purely client-side is defeated by patching it out.

**Tier 1 — Server-side (survives client compromise, deploy first)**
1. **Auth-without-session:** valid API/Photon auth but no `EOS_AntiCheatClient_BeginSession` / zero integrity messages → the exact `launch_bypass.exe` fingerprint. Flag *repeated* auth-then-restricted, not just failed joins.
2. **Avatar-endpoint anomalies:** avatar-bundle URL requests from accounts that never carried a validated EAC session, or bulk enumeration rates inconsistent with normal in-instance loading.
3. **Upload provenance mismatch:** uploaded asset fingerprint matches a previously-*downloaded* (not authored) avatar.
4. **Environment fingerprint:** Wine/VM/hypervisor/CPUID-timing anomalies, message-source vs session-binding mismatch (the class of check that killed `vrc-eac-emulator`).

**Tier 2 — Client integrity (catches coexistence-strategy rippers, EAC-present)**
5. **Prologue-hash sweep** of §2.3 geometry accessors + §2.4 texture exports + the `EncryptionKeyProxy`/`Create` seam vs on-disk baseline (remap `GameAssembly.dll`/`UnityPlayer.dll` ACCESS_READ, compare ~16 bytes). Catches inline `E9`/`FF 25`/`CC` detours.
6. **Foreign-module presence:** `MelonLoader`/`BepInEx` trees, `version.dll`/`winhttp.dll`/`winmm.dll` proxy stubs beside the exe, `Il2CppInterop`, a second CLR (`coreclr.dll`/`mono-2.0-bdwgc.dll`) in a pure-IL2CPP process, `frida-agent`/`frida-gadget`, `renderdoc.dll`.
7. **Unbacked executable memory:** `MEM_PRIVATE + PAGE_EXECUTE_*` regions with no file object (manual-map footprint); `.text` flipped to RWX.
8. **Handle acquisition:** non-system process holding VRChat handle with VM_READ/ALL_ACCESS; `MiniDumpWriteDump`/`NtReadVirtualMemory` sweeps.
9. **On-disk baseline mismatch:** `GameAssembly.dll` / `EOSSDK` / `steam_api64.dll` / `launch.exe` hash deviates; `launch.exe` no longer the real `start_protected_game.exe` (missing `.fptable`) — cheap, strong.

**Tier 3 — Behavioral**
10. Single client calling `BakeMesh`/`get_vertices`/`GetTriangles` across many remote avatars in a short window — normal rendering never bulk-reads vertex arrays managed-side.
11. `GetAllAssetNames`/`LoadAllAssetsAsync` on avatars the local player isn't wearing.
12. Foreign process reading the VRChat cache dir; cache files modified out-of-band (hot-swap mtime/hash divergence).
13. Peer reading avatar animator/BitKey params at abnormal rates (the in-instance tell for GTAvaCrypt-style content protection).

**Async timing tell:** EAC integrity scans fire asynchronously (kick lands 10-40s after a patch). Baseline the `PollStatus` cadence + integrity-message size distribution; flag deviation.

---

## 5. Creator-side content protection (what avatar authors can do)

| Protection | How | Effectiveness | Bypass |
|---|---|---|---|
| Shader lock (Poiyomi "Lock In", lilToon/d4rk optimize) | Strips ubershader to a keyword-baked variant | Low anti-rip (mesh still exposed) | Decompile locked shader; unlock tools exist |
| Mesh obfuscation (GTAvaCrypt / GTAnti-Rip) | Scrambles vertex positions, un-scrambles in keyed shader; key in 32×bool Avatar-3.0 params | Medium — raises cost | In-instance param sniffing recovers key; shader decompile |
| Watermarking / fingerprinting | Embed identifiable signal in mesh/UV/texture | Detection/attribution only | Doesn't prevent theft, enables takedown |
| Quest/PC separation, placeholder geometry | Ship decimated/hidden geometry to untrusted viewers | Medium | Only limits fidelity |

**Reality for creators:** these raise cost and enable *attribution*, they do not prevent a determined machine-owner. The durable protection is platform-side: don't deliver the bundle to an untrusted client.

---

## 6. Residual risk (what cannot be fully stopped, and why)

1. **Local rip by a machine-owner who declines to start EAC** — the entire client tier (§2.5) is forfeit; assets decrypt in-process by necessity. *Only* compensated by moving avatar-bundle **authorization** behind the server-validated EAC session (not just room-join), plus at-rest encryption to delay.
2. **GPU frame capture** — sits below the game; best effort is ETW/module detection, not prevention.
3. **Offline cache extraction** — bypasses every in-process detection; only cache encryption (key never exposed) + server upload-provenance contain it.

Best-effort deterrents for the residual: watermarking/fingerprinting for attribution, aggressive takedown on provenance mismatch, per-content ephemeral keys so a stolen key unlocks one throwaway blob.

---

## 7. Recommended next research (highest value)

1. **Bridge the download-manager class names to RVAs** — decrypt current metadata (the `sym-` magic work from the stopped dual-path workflow) so `AssetBundleDownloadManager`/`ContentTokenManager` get real addresses, enabling seam-level attestation design.
2. **Prototype the prologue-hash self-check** over §2.3/§2.4 RVAs as a standalone integrity monitor (defensive tool; measure false-positive rate against a clean session).
3. **Map `ContentTokenManager` / `ContentTokenKey`** — confirm whether per-avatar download tokens are session-bound and short-lived (the highest-leverage server gate already partly in the pipeline).
4. **ETW renderer-detection feasibility** for the GPU-capture vector — the one vector with no in-process signal.
5. **Cache encryption audit** — is the on-disk cache encrypted per-install, and where does that key live? (Determines whether offline extraction is even gated.)

---

*Sources: 44 parallel research agents; live capstone disassembly of `GameAssembly.dll`; PE inspection of plugin DLLs; VRChat feedback/Canny threads on cache hot-swapping; secret.club EAC integrity analysis; RudiAC/BattlEye detection writeups; RenderDoc in-app API docs; GTAnti-Rip. All external forum/repo text was treated as untrusted data. Per-agent raw outputs preserved in `output/p2_research/ripping_agents/`.*
