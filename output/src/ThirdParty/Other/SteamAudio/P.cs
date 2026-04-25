// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 8
// Methods: 28

namespace ThirdParty.Other.SteamAudio
{
    public class PathBakeParams : ValueType
    {
        public UIntPtr scene; // 0x10
        public UIntPtr probeBatch; // 0x18
        public SteamAudio.BakedDataIdentifier identifier; // 0x20
        public int numSamples; // 0x38
        public float radius; // 0x3C
        public float threshold; // 0x40
        public float visRange; // 0x44
        public float pathRange; // 0x48
        public int numThreads; // 0x4C
    }

    public class PathEffectParams : ValueType
    {
        public float eqCoeffsLow; // 0x10
        public float eqCoeffsMid; // 0x14
        public float eqCoeffsHigh; // 0x18
        public UIntPtr shCoeffs; // 0x20
        public int order; // 0x28
        public 0x6B298448 binaural; // 0x2C
        public UIntPtr hrtf; // 0x30
        public SteamAudio.CoordinateSpace3 listener; // 0x38
    }

    public class PathingVisualizationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C11E40
        public void Invoke(){} // RVA: 0x7FFAC8C11F10
        public void BeginInvoke(){} // RVA: 0x7FFAC8C11F70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class PerspectiveCorrection : ValueType
    {
        public 0x6B298448 enabled; // 0x10
        public float xfactor; // 0x14
        public float yfactor; // 0x18
        public SteamAudio.Matrix4x4 transform; // 0x1C
    }

    public class ProbeArray : Object
    {
        public UIntPtr mProbeArray; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0CD10 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0CDB0
        public void Release(){} // RVA: 0x7FFAC8C0CDF0
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void GenerateProbes(){} // RVA: 0x7FFAC8C0CE70
        public void GetNumProbes(){} // RVA: 0x7FFAC8C0CF20
        public void GetProbe(){} // RVA: 0x7FFAC8C0CFA0
    }

    public class ProbeBatch : Object
    {
        public SteamAudio.Context mContext; // 0x10
        public UIntPtr mProbeBatch; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0D370 | overloaded x3
        public void Finalize(){} // RVA: 0x7FFAC8C0D460
        public void Release(){} // RVA: 0x7FFAC8C0D4A0
        public void Get(){} // RVA: 0x7FFAC2F247C0
        public void Save(){} // RVA: 0x7FFAC8C0D570
        public void AddProbeArray(){} // RVA: 0x7FFAC8C0D6A0
        public void AddProbe(){} // RVA: 0x7FFAC8C0D740
        public void Commit(){} // RVA: 0x7FFAC8C0D7E0
        public void RemoveData(){} // RVA: 0x7FFAC8C0D860
        public void GetDataSize(){} // RVA: 0x7FFAC8C0D8F0
    }

    public class ProbeGenerationParams : ValueType
    {
        public 0x6B298760 type; // 0x10
        public float spacing; // 0x14
        public float height; // 0x18
        public SteamAudio.Matrix4x4 transform; // 0x1C
    }

    public class ProgressCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C10F90
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC8C11060
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

}