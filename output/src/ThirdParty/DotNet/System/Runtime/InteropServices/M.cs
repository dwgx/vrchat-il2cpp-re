// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 5
// Methods: 106

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class Marshal
    {
        // ── Methods ──
        public void AllocCoTaskMem(){} // RVA: 0x7FFAF87F06F0
        public void AllocHGlobal(){} // RVA: 0x7FFAF87F0710 | overloaded x2
        public void copy_to_unmanaged(){} // RVA: 0x7FFAF87F0860 | overloaded x2
        public void copy_to_unmanaged_fixed(){} // RVA: 0x7FFAF87F07F0
        public void skip_fixed(){} // RVA: 0x7FFAF87F0820
        public void Copy(){} // RVA: 0x7FFAF87F1490 | overloaded x11
        public void copy_from_unmanaged(){} // RVA: 0x7FFAF87F0E80
        public void copy_from_unmanaged_fixed(){} // RVA: 0x7FFAF87F0F10
        public void FreeBSTR(){} // RVA: 0x7FFAF87F15A0
        public void FreeCoTaskMem(){} // RVA: 0x7FFAF87F15B0
        public void FreeHGlobal(){} // RVA: 0x7FFAF87F15C0
        public void ClearBSTR(){} // RVA: 0x7FFAF87F15D0
        public void ZeroFreeBSTR(){} // RVA: 0x7FFAF87F1690
        public void ClearUnicode(){} // RVA: 0x7FFAF87F1790
        public void ZeroFreeGlobalAllocUnicode(){} // RVA: 0x7FFAF87F1880
        public void GetHRForException(){} // RVA: 0x7FFAF87F19A0
        public void IsComObject(){} // RVA: 0x7FFAF87F19B0
        public void GetLastWin32Error(){} // RVA: 0x7FFAF87F19F0
        public void OffsetOf(){} // RVA: 0x7FFAF87F1A60
        public void PtrToStringAnsi(){} // RVA: 0x7FFAF87F1A90 | overloaded x2
        public void PtrToStringUTF8(){} // RVA: 0x7FFAF87F1AC0
        public void PtrToStringUni(){} // RVA: 0x7FFAF87F1BB0 | overloaded x2
        public void PtrToStructure(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void ReadByte(){} // RVA: 0x7FFAF4BC0EA0
        public void ReadInt16(){} // RVA: 0x7FFAF87F1CE0
        public void ReadInt32(){} // RVA: 0x7FFAF87F1D60 | overloaded x2
        public void ReadInt64(){} // RVA: 0x7FFAF87F1DA0
        public void ReadIntPtr(){} // RVA: 0x7FFAF87F1DE0
        public void ReleaseInternal(){} // RVA: 0x7FFAF87F1E60
        public void Release(){} // RVA: 0x7FFAF87F1E70
        public void SizeOf(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void StringToHGlobalAnsi(){} // RVA: 0x7FFAF87F2190 | overloaded x2
        public void StringToHGlobalUni(){} // RVA: 0x7FFAF87F2350 | overloaded x2
        public void SecureStringToBSTR(){} // RVA: 0x7FFAF87F2400
        public void SecureStringGlobalAllocator(){} // RVA: 0x7FFAF87F2550
        public void SecureStringToUnicode(){} // RVA: 0x7FFAF87F25E0
        public void SecureStringToGlobalAllocUnicode(){} // RVA: 0x7FFAF87F28B0
        public void StructureToPtr(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void BufferToBSTR(){} // RVA: 0x7FFAF87F2B80
        public void UnsafeAddrOfPinnedArrayElement(){} // RVA: 0x7FFAF2ACBF70 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAF4BC1A80
        public void WriteInt16(){} // RVA: 0x7FFAF87F2BB0
        public void GetDelegateForFunctionPointerInternal(){} // RVA: 0x7FFAF87F2BF0
        public void GetDelegateForFunctionPointer(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetFunctionPointerForDelegateInternal(){} // RVA: 0x7FFAF87F2EB0
        public void GetFunctionPointerForDelegate(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetCustomMarshalerInstance(){} // RVA: 0x7FFAF87F2F60
        public void StringToCoTaskMemUTF8(){} // RVA: 0x7FFAF87F3A70
        public void .cctor(){} // RVA: 0x7FFAF87F3B60
    }

    public class MarshalAsAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DE8CE0
        public void get_Value(){} // RVA: 0x7FFAF2DE8CD0
        public void Copy(){} // RVA: 0x7FFAF87F3E80
    }

    public class MarshalDirectiveException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class MemoryMarshal
    {
        // ── Methods ──
        public void AsBytes(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void AsMemory(){} // RVA: 0x7FFAF2D33FA0
        public void GetReference(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetNonNullPinnableReference(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Cast(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void CreateSpan(){} // RVA: 0x7FFAF2D33FA0
        public void CreateReadOnlySpan(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetArray(){} // RVA: 0x7FFAF2D33FA0
        public void ToEnumerable(){} // RVA: 0x7FFAF2D33FA0
        public void Read(){} // RVA: 0x7FFAF2D33FA0
        public void Write(){} // RVA: 0x7FFAF2D33FA0
        public void TryWrite(){}
    }

    public class MemoryMarshal
    {
        // ── Methods ──
        public void TryGetArray(){} // RVA: 0x7FFAF2D33FA0
        public void Read(){} // RVA: 0x7FFAF2D33FA0
        public void Write(){} // RVA: 0x7FFAF2D33FA0
        public void TryWrite(){} // RVA: 0x7FFAF2D33FA0
        public void AsBytes(){} // RVA: 0x7FFAF2D33FA0
        public void GetReference(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Cast(){} // RVA: 0x7FFAF2D33FA0
    }

}