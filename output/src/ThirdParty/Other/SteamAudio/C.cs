// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 6
// Methods: 18

namespace ThirdParty.Other.SteamAudio
{
    public class ClosestHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C112B0
        public void Invoke(){} // RVA: 0x7FFAC8C11390
        public void BeginInvoke(){} // RVA: 0x7FFAC8C113B0
        public void EndInvoke(){} // RVA: 0x7FFAC3B16FD0
    }

    public class Common : Object
    {
        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x7FFAC3A89B70 | overloaded x2
        public void ConvertTransform(){} // RVA: 0x7FFAC8C0A9D0
        public void TransposeMatrix(){} // RVA: 0x7FFAC8C0AC60
        public void TransformMatrix(){} // RVA: 0x7FFAC8C0AC60
        public void ConvertString(){} // RVA: 0x7FFAC8C0AD10
        public void GetStreamingAssetsFileName(){} // RVA: 0x7FFAC8C0AD90
        public void HumanReadableDataSize(){} // RVA: 0x7FFAC8C0AE60
    }

    public class Constants : Object
    {
        public uint kVersionMajor;
        public uint kVersionMinor;
        public uint kVersionPatch;
        public uint kVersion;
    }

    public class Context : Object
    {
        public UIntPtr mContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0B400 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0B4A0
        public void Release(){} // RVA: 0x7FFAC8C0B4E0
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void LogMessage(){} // RVA: 0x7FFAC8C0B560
    }

    public class ContextSettings : ValueType
    {
        public uint version; // 0x10
        public SteamAudio.LogCallback logCallback; // 0x18
        public SteamAudio.AllocateCallback allocateCallback; // 0x20
        public SteamAudio.FreeCallback freeCallback; // 0x28
        public 0x6B298550 simdLevel; // 0x30
        public 0x6B2985A8 flags; // 0x34
    }

    public class CoordinateSpace3 : ValueType
    {
        public SteamAudio.Vector3 right; // 0x10
        public SteamAudio.Vector3 up; // 0x1C
        public SteamAudio.Vector3 ahead; // 0x28
        public SteamAudio.Vector3 origin; // 0x34
    }

}