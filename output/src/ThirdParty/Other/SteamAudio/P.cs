// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 8
// Methods: 28

namespace ThirdParty.Other.SteamAudio
{
    public class PathBakeParams : ValueType
    {
    }

    public class PathEffectParams : ValueType
    {
    }

    public class PathingVisualizationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FBA360
        public void Invoke(){} // RVA: 0x7FFE86FBA430
        public void BeginInvoke(){} // RVA: 0x7FFE86FBA490
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class PerspectiveCorrection : ValueType
    {
    }

    public class ProbeArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB5250 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE86FB52F0
        public void Release(){} // RVA: 0x7FFE86FB5330
        public void Get(){} // RVA: 0x7FFE81116380
        public void GenerateProbes(){} // RVA: 0x7FFE86FB53B0
        public void GetNumProbes(){} // RVA: 0x7FFE86FB5460
        public void GetProbe(){} // RVA: 0x7FFE86FB54E0
    }

    public class ProbeBatch : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB58B0 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFE86FB59A0
        public void Release(){} // RVA: 0x7FFE86FB59E0
        public void Get(){} // RVA: 0x7FFE810FE7C0
        public void Save(){} // RVA: 0x7FFE86FB5AB0
        public void AddProbeArray(){} // RVA: 0x7FFE86FB5BE0
        public void AddProbe(){} // RVA: 0x7FFE86FB5C80
        public void Commit(){} // RVA: 0x7FFE86FB5D20
        public void RemoveData(){} // RVA: 0x7FFE86FB5DA0
        public void GetDataSize(){} // RVA: 0x7FFE86FB5E30
    }

    public class ProbeGenerationParams : ValueType
    {
    }

    public class ProgressCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FB94D0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE86FB95A0
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

}