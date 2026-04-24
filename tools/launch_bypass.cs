// Minimal launch.exe replacement — skips EAC, starts VRChat.exe directly.
// Steam provides the Steam API context (overlay, SteamAppId, IPC).
// Compile: csc /out:launch.exe /target:winexe launch_bypass.cs
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string dir = AppDomain.CurrentDomain.BaseDirectory;
        string vrchat = Path.Combine(dir, "VRChat.exe");

        if (!File.Exists(vrchat))
        {
            Console.Error.WriteLine("VRChat.exe not found in " + dir);
            return;
        }

        // Forward all args, ensure --no-vr is included
        string argStr = string.Join(" ", args);
        if (!argStr.Contains("--no-vr"))
            argStr = "--no-vr " + argStr;

        var psi = new ProcessStartInfo
        {
            FileName = vrchat,
            Arguments = argStr.Trim(),
            WorkingDirectory = dir,
            UseShellExecute = false
        };

        try
        {
            var p = Process.Start(psi);
            Console.WriteLine("[bypass] Started VRChat.exe (PID " + p.Id + ") args: " + argStr.Trim());
            // Don't wait — Steam expects launch.exe to exit quickly
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Failed to start VRChat.exe: " + ex.Message);
        }
    }
}
