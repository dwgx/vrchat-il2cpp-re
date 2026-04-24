// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 26
// Methods: 162

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class AddrofIntrinsics : Object
    {
        // ── Methods ──
        public void AddrOf(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ClassInterfaceAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
    }

    public class CollectionsMarshal : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD57500F60
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeSetCount(){} // RVA: 0x7FFD4E096370
    }

    public class ComCompatibleVersionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538F6230
    }

    public class ComImportAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ComVisibleAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E40B5F0
    }

    public class DefaultDllImportSearchPathsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
    }

    public class ErrorWrapper : Object
    {
        public int m_ErrorCode; // 0x10
    }

    public class GCHandle : ValueType
    {
        public object IsAllocated;
        public object Target;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538F76E0 | overloaded x3
        public void get_IsAllocated(){} // RVA: 0x7FFD511E6CA0
        public void get_Target(){} // RVA: 0x7FFD538F7710
        public void set_Target(){} // RVA: 0x7FFD538F7780
        public void AddrOfPinnedObject(){} // RVA: 0x7FFD538F7810
        public void Alloc(){} // RVA: 0x7FFD538F7940 | overloaded x2
        public void Free(){} // RVA: 0x7FFD538F7AD0
        public void op_Explicit(){} // RVA: 0x7FFD538F7B50 | overloaded x2
        public void CheckCurrentDomain(){} // RVA: 0x7FFD4E426850
        public void GetTarget(){} // RVA: 0x7FFD53646490
        public void GetTargetHandle(){} // RVA: 0x7FFD538F7BC0
        public void FreeHandle(){} // RVA: 0x7FFD538F7CC0
        public void GetAddrOfPinnedObject(){} // RVA: 0x7FFD538F7CD0
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void Equals(){} // RVA: 0x7FFD538F7D30
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void FromIntPtr(){} // RVA: 0x7FFD538F7B50
        public void ToIntPtr(){} // RVA: 0x7FFD4F9181E0
    }

    public class GuidAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class InAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ListViewA`1 : Object
    {
    }

    public class ListViewB`1 : Object
    {
    }

    public class Marshal : Object
    {
        // ── Methods ──
        public void AllocCoTaskMem(){} // RVA: 0x7FFD538F7DC0
        public void AllocHGlobal(){} // RVA: 0x7FFD538F7DE0 | overloaded x2
        public void copy_to_unmanaged(){} // RVA: 0x7FFD538F7F30 | overloaded x2
        public void copy_to_unmanaged_fixed(){} // RVA: 0x7FFD538F7EC0
        public void skip_fixed(){} // RVA: 0x7FFD538F7EF0
        public void Copy(){} // RVA: 0x7FFD538F8B60 | overloaded x11
        public void copy_from_unmanaged(){} // RVA: 0x7FFD538F8550
        public void copy_from_unmanaged_fixed(){} // RVA: 0x7FFD538F85E0
        public void FreeBSTR(){} // RVA: 0x7FFD538F8C70
        public void FreeCoTaskMem(){} // RVA: 0x7FFD538F8C80
        public void FreeHGlobal(){} // RVA: 0x7FFD538F8C90
        public void ClearBSTR(){} // RVA: 0x7FFD538F8CA0
        public void ZeroFreeBSTR(){} // RVA: 0x7FFD538F8D60
        public void ClearUnicode(){} // RVA: 0x7FFD538F8E60
        public void ZeroFreeGlobalAllocUnicode(){} // RVA: 0x7FFD538F8F50
        public void GetHRForException(){} // RVA: 0x7FFD538F9070
        public void IsComObject(){} // RVA: 0x7FFD538F9080
        public void GetLastWin32Error(){} // RVA: 0x7FFD538F90C0
        public void OffsetOf(){} // RVA: 0x7FFD538F9130
        public void PtrToStringAnsi(){} // RVA: 0x7FFD538F9160 | overloaded x2
        public void PtrToStringUTF8(){} // RVA: 0x7FFD538F9190
        public void PtrToStringUni(){} // RVA: 0x7FFD538F9280 | overloaded x2
        public void PtrToStructure(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void ReadByte(){} // RVA: 0x7FFD5072EA20
        public void ReadInt16(){} // RVA: 0x7FFD538F93B0
        public void ReadInt32(){} // RVA: 0x7FFD538F9430 | overloaded x2
        public void ReadInt64(){} // RVA: 0x7FFD538F9470
        public void ReadIntPtr(){} // RVA: 0x7FFD538F94B0
        public void ReleaseInternal(){} // RVA: 0x7FFD538F9530
        public void Release(){} // RVA: 0x7FFD538F9540
        public void SizeOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void StringToHGlobalAnsi(){} // RVA: 0x7FFD538F9860 | overloaded x2
        public void StringToHGlobalUni(){} // RVA: 0x7FFD538F9A20 | overloaded x2
        public void SecureStringToBSTR(){} // RVA: 0x7FFD538F9AD0
        public void SecureStringGlobalAllocator(){} // RVA: 0x7FFD538F9C20
        public void SecureStringToUnicode(){} // RVA: 0x7FFD538F9CB0
        public void SecureStringToGlobalAllocUnicode(){} // RVA: 0x7FFD538F9F80
        public void StructureToPtr(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void BufferToBSTR(){} // RVA: 0x7FFD538FA250
        public void UnsafeAddrOfPinnedArrayElement(){} // RVA: 0x7FFD4E088090 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFD5072F5E0
        public void WriteInt16(){} // RVA: 0x7FFD538FA280
        public void GetDelegateForFunctionPointerInternal(){} // RVA: 0x7FFD538FA2C0
        public void GetDelegateForFunctionPointer(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetFunctionPointerForDelegateInternal(){} // RVA: 0x7FFD538FA580
        public void GetFunctionPointerForDelegate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetCustomMarshalerInstance(){} // RVA: 0x7FFD538FA630
        public void StringToCoTaskMemUTF8(){} // RVA: 0x7FFD538FB140
        public void .cctor(){} // RVA: 0x7FFD538FB230
    }

    public class MemoryMarshal : Object
    {
        // ── Methods ──
        public void AsBytes(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AsMemory(){} // RVA: 0x7FFD4E2ADC40
        public void GetReference(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetNonNullPinnableReference(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Cast(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CreateSpan(){} // RVA: 0x7FFD4E2ADC40
        public void CreateReadOnlySpan(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetArray(){} // RVA: 0x7FFD4E2ADC40
        public void ToEnumerable(){} // RVA: 0x7FFD4E2ADC40
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void TryWrite(){}
    }

    public class OSPlatform : ValueType
    {
        public object Linux;
        public object OSX;
        public object Windows;

        // ── Methods ──
        public void get_Linux(){} // RVA: 0x7FFD538F4C60
        public void get_OSX(){} // RVA: 0x7FFD538F4CC0
        public void get_Windows(){} // RVA: 0x7FFD538F4D20
        public void .ctor(){} // RVA: 0x7FFD538F4D80
        public void Create(){} // RVA: 0x7FFD538F4EA0
        public void Equals(){} // RVA: 0x7FFD538F5130 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD5382C200
        public void ToString(){} // RVA: 0x7FFD538F51D0
        public void op_Equality(){} // RVA: 0x7FFD538F5220
        public void .cctor(){} // RVA: 0x7FFD538F5280
    }

    public class OptionalAttribute : Attribute
    {
        public UIntPtr <DataPointer>k__BackingField; // 0x10
        public int <Size>k__BackingField; // 0x18
        public int <Reserved>k__BackingField; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class OutAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PreserveSigAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeInformation : Object
    {
        public object FrameworkDescription;
        public object OSDescription;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD538F6A10
        public void GetRuntimeArchitecture(){} // RVA: 0x7FFD538F7430
        public void GetOSName(){} // RVA: 0x7FFD538F7450
        public void get_FrameworkDescription(){} // RVA: 0x7FFD538F7470
        public void IsOSPlatform(){} // RVA: 0x7FFD538F74F0
        public void get_OSDescription(){} // RVA: 0x7FFD538F75D0
    }

    public class SafeHandle : CriticalFinalizerObject
    {
        public UIntPtr IsClosed; // 0x10
        public int IsInvalid; // 0x18
        public bool _ownsHandle; // 0x1C
        public bool _fullyInitialized; // 0x1D
        public int RefCount_Mask;
        public int RefCount_One;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538F6250
        public void Finalize(){} // RVA: 0x7FFD538F62E0
        public void SetHandle(){} // RVA: 0x7FFD4F83EFB0
        public void DangerousGetHandle(){} // RVA: 0x7FFD4E35C380
        public void get_IsClosed(){} // RVA: 0x7FFD538F6350
        public void get_IsInvalid(){} // RVA: 0x7FFD4E079D00
        public void Close(){} // RVA: 0x7FFD536690B0
        public void Dispose(){} // RVA: 0x7FFD538F6360 | overloaded x2
        public void ReleaseHandle(){} // RVA: 0x7FFD4E079D00
        public void SetHandleAsInvalid(){} // RVA: 0x7FFD538F6420
        public void DangerousAddRef(){} // RVA: 0x7FFD538F6550
        public void DangerousRelease(){} // RVA: 0x7FFD538F66E0
        public void InternalDispose(){} // RVA: 0x7FFD538F66F0
        public void InternalFinalize(){} // RVA: 0x7FFD538F6790
        public void DangerousReleaseInternal(){} // RVA: 0x7FFD538F67B0
    }

    public class _Assembly
    {
    }

    public class _AssemblyName
    {
    }

    public class _Exception
    {
    }

    public class _Module
    {
    }

    public class _ParameterInfo
    {
    }

}