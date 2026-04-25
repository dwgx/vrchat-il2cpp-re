// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 45
// Methods: 215

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class AddrofIntrinsics : Object
    {
        // ── Methods ──
        public void AddrOf(){} // RVA: 0x7FFAC2E8DC40
    }

    public class COMException : ExternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC84D5BC0
    }

    public class ClassInterfaceAttribute : Attribute
    {
        public 0x6B0D50D8 _val; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class CollectionsMarshal : Object
    {
        public int ListSize;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0E0F60
        public void AsSpan(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeSetCount(){} // RVA: 0x7FFAC2C76370
    }

    public class ComCompatibleVersionAttribute : Attribute
    {
        public int _major; // 0x10
        public int _minor; // 0x14
        public int _build; // 0x18
        public int _revision; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D6230
    }

    public class ComDefaultInterfaceAttribute : Attribute
    {
        public System.Type _val; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class ComImportAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ComVisibleAttribute : Attribute
    {
        public bool _val; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class DefaultDllImportSearchPathsAttribute : Attribute
    {
        public 0x6B0D54A0 _paths; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class DllImportAttribute : Attribute
    {
        public string Value; // 0x10
        public string EntryPoint; // 0x18
        public 0x6B0D4A50 CharSet; // 0x20
        public bool SetLastError; // 0x24
        public bool ExactSpelling; // 0x25
        public bool PreserveSig; // 0x26
        public 0x6B0D56B0 CallingConvention; // 0x28
        public bool BestFitMapping; // 0x2C
        public bool ThrowOnUnmappableChar; // 0x2D

        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x7FFAC84D5EA0
        public void IsDefined(){} // RVA: 0x7FFAC84D6110
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
    }

    public class ErrorWrapper : Object
    {
        public int m_ErrorCode; // 0x10
    }

    public class ExternalException : SystemException
    {
        public object ErrorCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x5
        public void get_ErrorCode(){} // RVA: 0x7FFAC3138C20
        public void ToString(){} // RVA: 0x7FFAC84D4870
    }

    public class FieldOffsetAttribute : Attribute
    {
        public int _val; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class GCHandle : ValueType
    {
        public UIntPtr IsAllocated; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D76E0 | overloaded x3
        public void get_IsAllocated(){} // RVA: 0x7FFAC5DC6CA0
        public void get_Target(){} // RVA: 0x7FFAC84D7710
        public void set_Target(){} // RVA: 0x7FFAC84D7780
        public void AddrOfPinnedObject(){} // RVA: 0x7FFAC84D7810
        public void Alloc(){} // RVA: 0x7FFAC84D7940 | overloaded x2
        public void Free(){} // RVA: 0x7FFAC84D7AD0
        public void op_Explicit(){} // RVA: 0x7FFAC84D7B50 | overloaded x2
        public void CheckCurrentDomain(){} // RVA: 0x7FFAC3006850
        public void GetTarget(){} // RVA: 0x7FFAC8226490
        public void GetTargetHandle(){} // RVA: 0x7FFAC84D7BC0
        public void FreeHandle(){} // RVA: 0x7FFAC84D7CC0
        public void GetAddrOfPinnedObject(){} // RVA: 0x7FFAC84D7CD0
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void Equals(){} // RVA: 0x7FFAC84D7D30
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void FromIntPtr(){} // RVA: 0x7FFAC84D7B50
        public void ToIntPtr(){} // RVA: 0x7FFAC44F81E0
    }

    public class GuidAttribute : Attribute
    {
        public string _val; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class HandleRef : ValueType
    {
        public object Handle; // 0x10
        public UIntPtr _handle; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3307780
        public void get_Handle(){} // RVA: 0x7FFAC4420220
    }

    public class ICustomMarshaler
    {
        // ── Methods ──
        public void MarshalNativeToManaged(){}
        public void MarshalManagedToNative(){}
        public void CleanUpNativeData(){} // RVA: 0x7FFAC2C70BF0
        public void CleanUpManagedData(){} // RVA: 0x7FFAC2C70A40
        public void GetNativeDataSize(){} // RVA: 0x7FFAC2C59960
    }

    public class InAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InterfaceTypeAttribute : Attribute
    {
        public 0x6B0D4FD0 _val; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class LibraryImportAttribute : Attribute
    {
        public string LibraryName; // 0x10
        public string EntryPoint; // 0x18
        public 0x6B2B7818 StringMarshalling; // 0x20
        public System.Type StringMarshallingCustomType; // 0x28
        public bool SetLastError; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_LibraryName(){} // RVA: 0x7FFAC2F3C380
        public void get_EntryPoint(){} // RVA: 0x7FFAC2F247C0
        public void set_EntryPoint(){} // RVA: 0x7FFAC2F87E80
        public void get_StringMarshalling(){} // RVA: 0x7FFAC30DBBE0
        public void set_StringMarshalling(){} // RVA: 0x7FFAC35DB7A0
        public void get_StringMarshallingCustomType(){} // RVA: 0x7FFAC2F4F130
        public void set_StringMarshallingCustomType(){} // RVA: 0x7FFAC2F22E90
        public void get_SetLastError(){} // RVA: 0x7FFAC2F47450
        public void set_SetLastError(){} // RVA: 0x7FFAC2F47460
    }

    public class ListViewA`1 : Object
    {
        public ÎÏÌÏÏÎÍÏÍÌÏÏÍÌÏÌÍÎÍÌÌÏÌ[] _items; // 0x10
    }

    public class ListViewB`1 : Object
    {
        public ÎÏÌÏÏÎÍÏÍÌÏÏÍÌÏÌÍÎÍÌÌÏÌ[] _items; // 0x10
    }

    public class Marshal : Object
    {
        public int SystemMaxDBCSCharSize;
        public int SystemDefaultCharSize; // 0x4
        public System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Type,string>,System.Runtime.InteropServices.ICustomMarshaler> MarshalerInstanceCache; // 0x8
        public object MarshalerInstanceCacheLock; // 0x10

        // ── Methods ──
        public void AllocCoTaskMem(){} // RVA: 0x7FFAC84D7DC0
        public void AllocHGlobal(){} // RVA: 0x7FFAC84D7DE0 | overloaded x2
        public void copy_to_unmanaged(){} // RVA: 0x7FFAC84D7F30 | overloaded x2
        public void copy_to_unmanaged_fixed(){} // RVA: 0x7FFAC84D7EC0
        public void skip_fixed(){} // RVA: 0x7FFAC84D7EF0
        public void Copy(){} // RVA: 0x7FFAC84D8B60 | overloaded x11
        public void copy_from_unmanaged(){} // RVA: 0x7FFAC84D8550
        public void copy_from_unmanaged_fixed(){} // RVA: 0x7FFAC84D85E0
        public void FreeBSTR(){} // RVA: 0x7FFAC84D8C70
        public void FreeCoTaskMem(){} // RVA: 0x7FFAC84D8C80
        public void FreeHGlobal(){} // RVA: 0x7FFAC84D8C90
        public void ClearBSTR(){} // RVA: 0x7FFAC84D8CA0
        public void ZeroFreeBSTR(){} // RVA: 0x7FFAC84D8D60
        public void ClearUnicode(){} // RVA: 0x7FFAC84D8E60
        public void ZeroFreeGlobalAllocUnicode(){} // RVA: 0x7FFAC84D8F50
        public void GetHRForException(){} // RVA: 0x7FFAC84D9070
        public void IsComObject(){} // RVA: 0x7FFAC84D9080
        public void GetLastWin32Error(){} // RVA: 0x7FFAC84D90C0
        public void OffsetOf(){} // RVA: 0x7FFAC84D9130
        public void PtrToStringAnsi(){} // RVA: 0x7FFAC84D9160 | overloaded x2
        public void PtrToStringUTF8(){} // RVA: 0x7FFAC84D9190
        public void PtrToStringUni(){} // RVA: 0x7FFAC84D9280 | overloaded x2
        public void PtrToStructure(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void ReadByte(){} // RVA: 0x7FFAC530EA20
        public void ReadInt16(){} // RVA: 0x7FFAC84D93B0
        public void ReadInt32(){} // RVA: 0x7FFAC84D9430 | overloaded x2
        public void ReadInt64(){} // RVA: 0x7FFAC84D9470
        public void ReadIntPtr(){} // RVA: 0x7FFAC84D94B0
        public void ReleaseInternal(){} // RVA: 0x7FFAC84D9530
        public void Release(){} // RVA: 0x7FFAC84D9540
        public void SizeOf(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void StringToHGlobalAnsi(){} // RVA: 0x7FFAC84D9860 | overloaded x2
        public void StringToHGlobalUni(){} // RVA: 0x7FFAC84D9A20 | overloaded x2
        public void SecureStringToBSTR(){} // RVA: 0x7FFAC84D9AD0
        public void SecureStringGlobalAllocator(){} // RVA: 0x7FFAC84D9C20
        public void SecureStringToUnicode(){} // RVA: 0x7FFAC84D9CB0
        public void SecureStringToGlobalAllocUnicode(){} // RVA: 0x7FFAC84D9F80
        public void StructureToPtr(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void BufferToBSTR(){} // RVA: 0x7FFAC84DA250
        public void UnsafeAddrOfPinnedArrayElement(){} // RVA: 0x7FFAC2C68090 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAC530F5E0
        public void WriteInt16(){} // RVA: 0x7FFAC84DA280
        public void GetDelegateForFunctionPointerInternal(){} // RVA: 0x7FFAC84DA2C0
        public void GetDelegateForFunctionPointer(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetFunctionPointerForDelegateInternal(){} // RVA: 0x7FFAC84DA580
        public void GetFunctionPointerForDelegate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetCustomMarshalerInstance(){} // RVA: 0x7FFAC84DA630
        public void StringToCoTaskMemUTF8(){} // RVA: 0x7FFAC84DB140
        public void .cctor(){} // RVA: 0x7FFAC84DB230
    }

    public class MarshalAsAttribute : Attribute
    {
        public string Value; // 0x10
        public string MarshalType; // 0x18
        public System.Type MarshalTypeRef; // 0x20
        public System.Type SafeArrayUserDefinedSubType; // 0x28
        public 0x6B0D5238 utype; // 0x30
        public 0x6B0D5238 ArraySubType; // 0x34
        public 0x6B0D51E0 SafeArraySubType; // 0x38
        public int SizeConst; // 0x3C
        public int IidParameterIndex; // 0x40
        public short SizeParamIndex; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7CCE0
        public void get_Value(){} // RVA: 0x7FFAC2F7CCD0
        public void Copy(){} // RVA: 0x7FFAC84DB550
    }

    public class MarshalDirectiveException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class MemoryMarshal : Object
    {
        // ── Methods ──
        public void AsBytes(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AsMemory(){} // RVA: 0x7FFAC2E8DC40
        public void GetReference(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetNonNullPinnableReference(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Cast(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CreateSpan(){} // RVA: 0x7FFAC2E8DC40
        public void CreateReadOnlySpan(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetArray(){} // RVA: 0x7FFAC2E8DC40
        public void ToEnumerable(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void TryWrite(){}
    }

    public class NativeCallableAttribute : Attribute
    {
        public 0x6B0D56B0 CallingConvention; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OSPlatform : ValueType
    {
        public string Linux; // 0x10
        public System.Runtime.InteropServices.OSPlatform OSX;
        public System.Runtime.InteropServices.OSPlatform Windows; // 0x8
        public System.Runtime.InteropServices.OSPlatform <Windows>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Linux(){} // RVA: 0x7FFAC84D4C60
        public void get_OSX(){} // RVA: 0x7FFAC84D4CC0
        public void get_Windows(){} // RVA: 0x7FFAC84D4D20
        public void .ctor(){} // RVA: 0x7FFAC84D4D80
        public void Create(){} // RVA: 0x7FFAC84D4EA0
        public void Equals(){} // RVA: 0x7FFAC84D5130 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC840C200
        public void ToString(){} // RVA: 0x7FFAC84D51D0
        public void op_Equality(){} // RVA: 0x7FFAC84D5220
        public void .cctor(){} // RVA: 0x7FFAC84D5280
    }

    public class OptionalAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OutAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PreserveSigAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeInformation : Object
    {
        public 0x6B0D4CB8 FrameworkDescription;
        public 0x6B0D4CB8 OSDescription; // 0x4
        public System.Runtime.InteropServices.OSPlatform _osPlatform; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC84D6A10
        public void GetRuntimeArchitecture(){} // RVA: 0x7FFAC84D7430
        public void GetOSName(){} // RVA: 0x7FFAC84D7450
        public void get_FrameworkDescription(){} // RVA: 0x7FFAC84D7470
        public void IsOSPlatform(){} // RVA: 0x7FFAC84D74F0
        public void get_OSDescription(){} // RVA: 0x7FFAC84D75D0
    }

    public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
    {
        public object ByteLength;
        public object _numBytes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D5790
        public void Initialize(){} // RVA: 0x7FFAC84D5810
        public void AcquirePointer(){} // RVA: 0x7FFAC84D58E0
        public void ReleasePointer(){} // RVA: 0x7FFAC84D59B0
        public void get_ByteLength(){} // RVA: 0x7FFAC84D5A60
        public void NotInitialized(){} // RVA: 0x7FFAC84D5B10
        public void .cctor(){} // RVA: 0x7FFAC84D5B80
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
        public void .ctor(){} // RVA: 0x7FFAC84D6250
        public void Finalize(){} // RVA: 0x7FFAC84D62E0
        public void SetHandle(){} // RVA: 0x7FFAC441EFB0
        public void DangerousGetHandle(){} // RVA: 0x7FFAC2F3C380
        public void get_IsClosed(){} // RVA: 0x7FFAC84D6350
        public void get_IsInvalid(){} // RVA: 0x7FFAC2C59D00
        public void Close(){} // RVA: 0x7FFAC82490B0
        public void Dispose(){} // RVA: 0x7FFAC84D6360 | overloaded x2
        public void ReleaseHandle(){} // RVA: 0x7FFAC2C59D00
        public void SetHandleAsInvalid(){} // RVA: 0x7FFAC84D6420
        public void DangerousAddRef(){} // RVA: 0x7FFAC84D6550
        public void DangerousRelease(){} // RVA: 0x7FFAC84D66E0
        public void InternalDispose(){} // RVA: 0x7FFAC84D66F0
        public void InternalFinalize(){} // RVA: 0x7FFAC84D6790
        public void DangerousReleaseInternal(){} // RVA: 0x7FFAC84D67B0
    }

    public class SequenceMarshal : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7FFAC8A598A0
    }

    public class StructLayoutAttribute : Attribute
    {
    }

    public class SuppressGCTransitionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnmanagedCallersOnlyAttribute : Attribute
    {
        public System.Type[] CallConvs; // 0x10
        public string EntryPoint; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnmanagedFunctionPointerAttribute : Attribute
    {
        public 0x6B0D56B0 m_callingConvention; // 0x10
        public bool SetLastError; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class _Activator
    {
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