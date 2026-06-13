// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 5
// Methods: 106

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class Marshal
    {
        // ── Methods ──
        public void AllocCoTaskMem(){} // RVA: 0x5D406F0
        public void AllocHGlobal(){} // RVA: 0x5D40710 | overloaded x2
        public void copy_to_unmanaged(){} // RVA: 0x5D40860 | overloaded x2
        public void copy_to_unmanaged_fixed(){} // RVA: 0x5D407F0
        public void skip_fixed(){} // RVA: 0x5D40820
        public void Copy(){} // RVA: 0x5D41490 | overloaded x11
        public void copy_from_unmanaged(){} // RVA: 0x5D40E80
        public void copy_from_unmanaged_fixed(){} // RVA: 0x5D40F10
        public void FreeBSTR(){} // RVA: 0x5D415A0
        public void FreeCoTaskMem(){} // RVA: 0x5D415B0
        public void FreeHGlobal(){} // RVA: 0x5D415C0
        public void ClearBSTR(){} // RVA: 0x5D415D0
        public void ZeroFreeBSTR(){} // RVA: 0x5D41690
        public void ClearUnicode(){} // RVA: 0x5D41790
        public void ZeroFreeGlobalAllocUnicode(){} // RVA: 0x5D41880
        public void GetHRForException(){} // RVA: 0x5D419A0
        public void IsComObject(){} // RVA: 0x5D419B0
        public void GetLastWin32Error(){} // RVA: 0x5D419F0
        public void OffsetOf(){} // RVA: 0x5D41A60
        public void PtrToStringAnsi(){} // RVA: 0x5D41A90 | overloaded x2
        public void PtrToStringUTF8(){} // RVA: 0x5D41AC0
        public void PtrToStringUni(){} // RVA: 0x5D41BB0 | overloaded x2
        public void PtrToStructure(){} // RVA: 0x283FA0 | overloaded x4
        public void ReadByte(){} // RVA: 0x2110EA0
        public void ReadInt16(){} // RVA: 0x5D41CE0
        public void ReadInt32(){} // RVA: 0x5D41D60 | overloaded x2
        public void ReadInt64(){} // RVA: 0x5D41DA0
        public void ReadIntPtr(){} // RVA: 0x5D41DE0
        public void ReleaseInternal(){} // RVA: 0x5D41E60
        public void Release(){} // RVA: 0x5D41E70
        public void SizeOf(){} // RVA: 0x283FA0 | overloaded x4
        public void StringToHGlobalAnsi(){} // RVA: 0x5D42190 | overloaded x2
        public void StringToHGlobalUni(){} // RVA: 0x5D42350 | overloaded x2
        public void SecureStringToBSTR(){} // RVA: 0x5D42400
        public void SecureStringGlobalAllocator(){} // RVA: 0x5D42550
        public void SecureStringToUnicode(){} // RVA: 0x5D425E0
        public void SecureStringToGlobalAllocUnicode(){} // RVA: 0x5D428B0
        public void StructureToPtr(){} // RVA: 0x283FA0 | overloaded x2
        public void BufferToBSTR(){} // RVA: 0x5D42B80
        public void UnsafeAddrOfPinnedArrayElement(){} // RVA: 0x1BF70 | overloaded x2
        public void WriteByte(){} // RVA: 0x2111A80
        public void WriteInt16(){} // RVA: 0x5D42BB0
        public void GetDelegateForFunctionPointerInternal(){} // RVA: 0x5D42BF0
        public void GetDelegateForFunctionPointer(){} // RVA: 0x283FA0 | overloaded x2
        public void GetFunctionPointerForDelegateInternal(){} // RVA: 0x5D42EB0
        public void GetFunctionPointerForDelegate(){} // RVA: 0x283FA0 | overloaded x2
        public void GetCustomMarshalerInstance(){} // RVA: 0x5D42F60
        public void StringToCoTaskMemUTF8(){} // RVA: 0x5D43A70
        public void .cctor(){} // RVA: 0x5D43B60
    }

    public class MarshalAsAttribute
    {
        public string MarshalCookie; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x338CE0
        public void get_Value(){} // RVA: 0x338CD0
        public void Copy(){} // RVA: 0x5D43E80
    }

    public class MarshalDirectiveException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class MemoryMarshal
    {
        // ── Methods ──
        public void AsBytes(){} // RVA: 0x283FA0 | overloaded x2
        public void AsMemory(){} // RVA: 0x283FA0
        public void GetReference(){} // RVA: 0x283FA0 | overloaded x2
        public void GetNonNullPinnableReference(){} // RVA: 0x283FA0 | overloaded x2
        public void Cast(){} // RVA: 0x283FA0 | overloaded x2
        public void CreateSpan(){} // RVA: 0x283FA0
        public void CreateReadOnlySpan(){} // RVA: 0x283FA0
        public void TryGetArray(){} // RVA: 0x283FA0
        public void ToEnumerable(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0
        public void Write(){} // RVA: 0x283FA0
        public void TryWrite(){}
    }

    public class MemoryMarshal
    {
        // ── Methods ──
        public void TryGetArray(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0
        public void Write(){} // RVA: 0x283FA0
        public void TryWrite(){} // RVA: 0x283FA0
        public void AsBytes(){} // RVA: 0x283FA0
        public void GetReference(){} // RVA: 0x283FA0 | overloaded x2
        public void Cast(){} // RVA: 0x283FA0
    }

}