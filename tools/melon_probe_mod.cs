/**
 * VRChat MelonLoader Probe Mod — Online Runtime Analysis
 * ========================================================
 * Runs under MelonLoader with EAC active. Uses Harmony patches
 * (no Interceptor.attach = no code integrity violation).
 *
 * Build: Reference MelonLoader, Il2CppInterop, UnityEngine assemblies
 * Install: Copy DLL to VRChat/Mods/
 *
 * This is a TEMPLATE — adapt method signatures after Il2CppInterop
 * generates unhollowed assemblies from the deobfuscated dump.
 *
 * Risk level: LOW (same as any MelonLoader mod)
 * Detection: MelonLoader itself may be detected, but Harmony patches
 *            don't modify IL2CPP code pages (uses trampoline hooks).
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using MelonLoader;
using HarmonyLib;
using Il2CppInterop.Runtime;

[assembly: MelonInfo(typeof(VRCProbeMod.ProbeMod), "VRC Probe", "1.0.0", "researcher")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace VRCProbeMod
{
    public class ProbeMod : MelonMod
    {
        private static string _logDir;
        private static StreamWriter _logWriter;
        private static readonly object _logLock = new object();
        private static Dictionary<string, int> _callCounts = new();
        private static DateTime _sessionStart;

        public override void OnInitializeMelon()
        {
            _sessionStart = DateTime.Now;
            _logDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "vrc_probe_logs"
            );
            Directory.CreateDirectory(_logDir);

            var logFile = Path.Combine(_logDir, $"probe_{_sessionStart:yyyyMMdd_HHmmss}.jsonl");
            _logWriter = new StreamWriter(logFile, false, System.Text.Encoding.UTF8);
            _logWriter.AutoFlush = true;

            LogMsg("session_start", new { version = "1.0.0", time = _sessionStart.ToString("o") });

            // Apply Harmony patches
            ApplyPatches();

            MelonLogger.Msg($"[Probe] Logging to {logFile}");
        }

        public override void OnDeinitializeMelon()
        {
            LogMsg("session_end", new {
                duration_sec = (DateTime.Now - _sessionStart).TotalSeconds,
                total_calls = _callCounts
            });
            _logWriter?.Close();
        }

        private void ApplyPatches()
        {
            var harmony = new HarmonyLib.Harmony("com.researcher.vrcprobe");

            // ── 1. Photon Auth Flow ──────────────────────────────────

            // Hook OnCustomAuthenticationResponse
            TryPatch(harmony, "OnCustomAuthResponse",
                // Target: The Photon callback when auth completes
                // Use Il2CppInterop to resolve the actual method
                typeof(PhotonAuthPatches), nameof(PhotonAuthPatches.OnAuthResponse_Prefix));

            // ── 2. Room Join/Leave ───────────────────────────────────

            TryPatch(harmony, "OnJoinedRoom",
                typeof(RoomPatches), nameof(RoomPatches.OnJoinedRoom_Prefix));

            TryPatch(harmony, "OnLeftRoom",
                typeof(RoomPatches), nameof(RoomPatches.OnLeftRoom_Prefix));

            // ── 3. Network Serialization ─────────────────────────────

            TryPatch(harmony, "OnPhotonSerializeView",
                typeof(NetworkPatches), nameof(NetworkPatches.OnSerialize_Prefix));

            // ── 4. RPC Calls ─────────────────────────────────────────

            TryPatch(harmony, "RPC",
                typeof(RPCPatches), nameof(RPCPatches.OnRPC_Prefix));

            // ── 5. EAC Status ────────────────────────────────────────

            // Passive: read EAC session state from memory
            // No hook needed — just poll periodically in OnUpdate

            MelonLogger.Msg($"[Probe] Harmony patches applied");
        }

        private void TryPatch(HarmonyLib.Harmony harmony, string methodName,
                              Type patchClass, string patchMethodName)
        {
            try
            {
                // NOTE: Actual implementation needs Il2CppInterop method resolution
                // This is a skeleton — fill in after generating unhollowed assemblies
                MelonLogger.Msg($"[Probe] Patch registered: {methodName} -> {patchMethodName}");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Probe] Failed to patch {methodName}: {ex.Message}");
            }
        }

        public override void OnUpdate()
        {
            // Periodic data collection (every 5 seconds)
            if (DateTime.Now.Second % 5 == 0)
            {
                CollectRuntimeState();
            }
        }

        private void CollectRuntimeState()
        {
            // Read player count, room info, network stats
            // This is read-only memory access — not hooking
            try
            {
                // TODO: Use Il2CppInterop to read:
                // - Networking.Player.Count
                // - PhotonNetwork.CurrentRoom
                // - PhotonNetwork.NetworkingClient.LoadBalancingPeer stats
            }
            catch (Exception) { }
        }

        public static void LogMsg(string eventType, object data)
        {
            lock (_logLock)
            {
                try
                {
                    var elapsed = (DateTime.Now - _sessionStart).TotalSeconds;
                    var json = $"{{\"t\":{elapsed:F2},\"type\":\"{eventType}\",\"data\":{System.Text.Json.JsonSerializer.Serialize(data)}}}";
                    _logWriter?.WriteLine(json);

                    if (!_callCounts.ContainsKey(eventType))
                        _callCounts[eventType] = 0;
                    _callCounts[eventType]++;
                }
                catch { }
            }
        }
    }

    // ── Harmony Patch Classes ──────────────────────────────────────────

    [HarmonyPatch]
    public static class PhotonAuthPatches
    {
        // Prefix: runs BEFORE the original method
        public static void OnAuthResponse_Prefix(/* Il2Cpp params */)
        {
            ProbeMod.LogMsg("photon_auth", new {
                msg = "OnCustomAuthenticationResponse triggered",
                // TODO: Extract response data (retCode, parameters)
            });
        }
    }

    [HarmonyPatch]
    public static class RoomPatches
    {
        public static void OnJoinedRoom_Prefix()
        {
            ProbeMod.LogMsg("room_join", new {
                msg = "OnJoinedRoom triggered",
                // TODO: Read PhotonNetwork.CurrentRoom info
            });
        }

        public static void OnLeftRoom_Prefix()
        {
            ProbeMod.LogMsg("room_leave", new {
                msg = "OnLeftRoom triggered",
            });
        }
    }

    [HarmonyPatch]
    public static class NetworkPatches
    {
        public static void OnSerialize_Prefix(/* Il2Cpp stream, info */)
        {
            ProbeMod.LogMsg("net_serialize", new {
                msg = "OnPhotonSerializeView",
                // TODO: Log serialization direction, byte count
            });
        }
    }

    [HarmonyPatch]
    public static class RPCPatches
    {
        public static void OnRPC_Prefix(/* Il2Cpp params */)
        {
            ProbeMod.LogMsg("rpc_call", new {
                msg = "RPC invoked",
                // TODO: Log RPC name, target, parameters
            });
        }
    }
}
