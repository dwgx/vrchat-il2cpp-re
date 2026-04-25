// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 7
// Methods: 12

namespace ThirdParty.Other.SteamAudio
{
    public class DeviationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C11A00
        public void Invoke(){} // RVA: 0x7FFAC8C11AD0
        public void BeginInvoke(){} // RVA: 0x7FFAC8C11BC0
        public void EndInvoke(){} // RVA: 0x7FFAC4034000
    }

    public class DeviationModel : ValueType
    {
        public 0x6B298A20 type; // 0x10
        public SteamAudio.DeviationCallback callback; // 0x18
        public UIntPtr userData; // 0x20
    }

    public class DirectEffectParams : ValueType
    {
        public 0x6B298AD0 flags; // 0x10
        public 0x6B298B28 transmissionType; // 0x14
        public float distanceAttenuation; // 0x18
        public float airAbsorptionLow; // 0x1C
        public float airAbsorptionMid; // 0x20
        public float airAbsorptionHigh; // 0x24
        public float directivityLow; // 0x28
        public float directivityMid; // 0x2C
        public float directivityHigh; // 0x30
        public float occlusion; // 0x34
        public float transmissionLow; // 0x38
        public float transmissionMid; // 0x3C
        public float transmissionHigh; // 0x40
    }

    public class Directivity : ValueType
    {
        public float dipoleWeightLow; // 0x10
        public float dipoleWeightMid; // 0x14
        public float dipoleWeightHigh; // 0x18
        public float dipolePowerLow; // 0x1C
        public float dipolePowerMid; // 0x20
        public float dipolePowerHigh; // 0x24
        public SteamAudio.DirectivityCallback callback; // 0x28
        public UIntPtr userData; // 0x30
    }

    public class DirectivityCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C11C90
        public void Invoke(){} // RVA: 0x7FFAC8C11D60
        public void BeginInvoke(){} // RVA: 0x7FFAC8C11D90
        public void EndInvoke(){} // RVA: 0x7FFAC4034000
    }

    public class DistanceAttenuationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C11880
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC8C11950
        public void EndInvoke(){} // RVA: 0x7FFAC4034000
    }

    public class DistanceAttenuationModel : ValueType
    {
        public 0x6B298970 type; // 0x10
        public float minDistance; // 0x14
        public SteamAudio.DistanceAttenuationCallback callback; // 0x18
        public UIntPtr userData; // 0x20
        public 0x6B298448 dirty; // 0x28
    }

}