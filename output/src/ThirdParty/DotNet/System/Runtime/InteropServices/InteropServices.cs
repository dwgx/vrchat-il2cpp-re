// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 45
// Methods: 215

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class AddrofIntrinsics : Object
    {
        // ── Methods ──
        public void AddrOf(){} // RVA: 0x7FFE810A1420
    }

    public class COMException : ExternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8687F3F0
    }

    public class ClassInterfaceAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class CollectionsMarshal : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A546F30
        public void AsSpan(){} // RVA: 0x7FFE810A1420
        public void UnsafeSetCount(){} // RVA: 0x7FFE80E4BA70
    }

    public class ComCompatibleVersionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687FA60
    }

    public class ComDefaultInterfaceAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class ComImportAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ComVisibleAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class DefaultDllImportSearchPathsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class DllImportAttribute : Attribute
    {
        public string _val; // 0x10

        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x7FFE8687F6D0
        public void IsDefined(){} // RVA: 0x7FFE8687F940
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE81116380
    }

    public class ErrorWrapper : Object
    {
    }

    public class ExternalException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x5
        public void get_ErrorCode(){} // RVA: 0x7FFE8139EA30
        public void ToString(){} // RVA: 0x7FFE8687E0A0
    }

    public class FieldOffsetAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class GCHandle : ValueType
    {
        public UIntPtr handle; // 0x10
        public object field_1; // 0x9070

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86880F10 | overloaded x3
        public void get_IsAllocated(){} // RVA: 0x7FFE8412EC80
        public void get_Target(){} // RVA: 0x7FFE86880F40
        public void set_Target(){} // RVA: 0x7FFE86880FB0
        public void AddrOfPinnedObject(){} // RVA: 0x7FFE86881040
        public void Alloc(){} // RVA: 0x7FFE86881170 | overloaded x2
        public void Free(){} // RVA: 0x7FFE86881300
        public void op_Explicit(){} // RVA: 0x7FFE86881380 | overloaded x2
        public void CheckCurrentDomain(){} // RVA: 0x7FFE811E0850
        public void GetTarget(){} // RVA: 0x7FFE865CFDD0
        public void GetTargetHandle(){} // RVA: 0x7FFE868813F0
        public void FreeHandle(){} // RVA: 0x7FFE868814F0
        public void GetAddrOfPinnedObject(){} // RVA: 0x7FFE86881500
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void Equals(){} // RVA: 0x7FFE86881560
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void FromIntPtr(){} // RVA: 0x7FFE86881380
        public void ToIntPtr(){} // RVA: 0x7FFE827C4A80
    }

    public class GuidAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class HandleRef : ValueType
    {
        public object _wrapper; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81566320
        public void get_Handle(){} // RVA: 0x7FFE826F4210
    }

    public class ICustomMarshaler
    {
        // ── Methods ──
        public void MarshalNativeToManaged(){}
        public void MarshalManagedToNative(){}
        public void CleanUpNativeData(){} // RVA: 0x7FFE80E46250
        public void CleanUpManagedData(){} // RVA: 0x7FFE80E460A0
        public void GetNativeDataSize(){} // RVA: 0x7FFE80E2EDB0
    }

    public class InAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InterfaceTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class LibraryImportAttribute : Attribute
    {
        public string _libraryName; // 0x10
        public string _entryPoint; // 0x18
        public H _stringMarshalling; // 0x20
        public System.Type _stringMarshallingCustomType; // 0x28
        public bool _setLastError; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_LibraryName(){} // RVA: 0x7FFE81116380
        public void get_EntryPoint(){} // RVA: 0x7FFE810FE7C0
        public void set_EntryPoint(){} // RVA: 0x7FFE81161E80
        public void get_StringMarshalling(){} // RVA: 0x7FFE8151D690
        public void set_StringMarshalling(){} // RVA: 0x7FFE8170B670
        public void get_StringMarshallingCustomType(){} // RVA: 0x7FFE81129130
        public void set_StringMarshallingCustomType(){} // RVA: 0x7FFE810FCE90
        public void get_SetLastError(){} // RVA: 0x7FFE81121450
        public void set_SetLastError(){} // RVA: 0x7FFE81121460
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
        public void AllocCoTaskMem(){} // RVA: 0x7FFE868815F0
        public void AllocHGlobal(){} // RVA: 0x7FFE86881610 | overloaded x2
        public void copy_to_unmanaged(){} // RVA: 0x7FFE86881760 | overloaded x2
        public void copy_to_unmanaged_fixed(){} // RVA: 0x7FFE868816F0
        public void skip_fixed(){} // RVA: 0x7FFE86881720
        public void Copy(){} // RVA: 0x7FFE86882390 | overloaded x11
        public void copy_from_unmanaged(){} // RVA: 0x7FFE86881D80
        public void copy_from_unmanaged_fixed(){} // RVA: 0x7FFE86881E10
        public void FreeBSTR(){} // RVA: 0x7FFE868824A0
        public void FreeCoTaskMem(){} // RVA: 0x7FFE868824B0
        public void FreeHGlobal(){} // RVA: 0x7FFE868824C0
        public void ClearBSTR(){} // RVA: 0x7FFE868824D0
        public void ZeroFreeBSTR(){} // RVA: 0x7FFE86882590
        public void ClearUnicode(){} // RVA: 0x7FFE86882690
        public void ZeroFreeGlobalAllocUnicode(){} // RVA: 0x7FFE86882780
        public void GetHRForException(){} // RVA: 0x7FFE868828A0
        public void IsComObject(){} // RVA: 0x7FFE868828B0
        public void GetLastWin32Error(){} // RVA: 0x7FFE868828F0
        public void OffsetOf(){} // RVA: 0x7FFE86882960
        public void PtrToStringAnsi(){} // RVA: 0x7FFE86882990 | overloaded x2
        public void PtrToStringUTF8(){} // RVA: 0x7FFE868829C0
        public void PtrToStringUni(){} // RVA: 0x7FFE86882AB0 | overloaded x2
        public void PtrToStructure(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void ReadByte(){} // RVA: 0x7FFE835C52F0
        public void ReadInt16(){} // RVA: 0x7FFE86882BE0
        public void ReadInt32(){} // RVA: 0x7FFE86882C60 | overloaded x2
        public void ReadInt64(){} // RVA: 0x7FFE86882CA0
        public void ReadIntPtr(){} // RVA: 0x7FFE86882CE0
        public void ReleaseInternal(){} // RVA: 0x7FFE86882D60
        public void Release(){} // RVA: 0x7FFE86882D70
        public void SizeOf(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void StringToHGlobalAnsi(){} // RVA: 0x7FFE86883090 | overloaded x2
        public void StringToHGlobalUni(){} // RVA: 0x7FFE86883250 | overloaded x2
        public void SecureStringToBSTR(){} // RVA: 0x7FFE86883300
        public void SecureStringGlobalAllocator(){} // RVA: 0x7FFE86883450
        public void SecureStringToUnicode(){} // RVA: 0x7FFE868834E0
        public void SecureStringToGlobalAllocUnicode(){} // RVA: 0x7FFE868837B0
        public void StructureToPtr(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void BufferToBSTR(){} // RVA: 0x7FFE86883A80
        public void UnsafeAddrOfPinnedArrayElement(){} // RVA: 0x7FFE80E3D4E0 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE835C5EC0
        public void WriteInt16(){} // RVA: 0x7FFE86883AB0
        public void GetDelegateForFunctionPointerInternal(){} // RVA: 0x7FFE86883AF0
        public void GetDelegateForFunctionPointer(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetFunctionPointerForDelegateInternal(){} // RVA: 0x7FFE86883DB0
        public void GetFunctionPointerForDelegate(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetCustomMarshalerInstance(){} // RVA: 0x7FFE86883E60
        public void StringToCoTaskMemUTF8(){} // RVA: 0x7FFE86884970
        public void .cctor(){} // RVA: 0x7FFE86884A60
    }

    public class MarshalAsAttribute : Attribute
    {
        public string MarshalCookie; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81156CE0
        public void get_Value(){} // RVA: 0x7FFE81156CD0
        public void Copy(){} // RVA: 0x7FFE86884D80
    }

    public class MarshalDirectiveException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class MemoryMarshal : Object
    {
        // ── Methods ──
        public void AsBytes(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AsMemory(){} // RVA: 0x7FFE810A1420
        public void GetReference(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetNonNullPinnableReference(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Cast(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CreateSpan(){} // RVA: 0x7FFE810A1420
        public void CreateReadOnlySpan(){} // RVA: 0x7FFE810A1420
        public void TryGetArray(){} // RVA: 0x7FFE810A1420
        public void ToEnumerable(){} // RVA: 0x7FFE810A1420
        public void Read(){} // RVA: 0x7FFE810A1420
        public void Write(){} // RVA: 0x7FFE810A1420
        public void TryWrite(){}
    }

    public class NativeCallableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OSPlatform : ValueType
    {
        public string _osPlatform; // 0x10
        public System.Runtime.InteropServices.OSPlatform _linux;
        public System.Runtime.InteropServices.OSPlatform _oSX; // 0x8

        // ── Methods ──
        public void get_Linux(){} // RVA: 0x7FFE8687E490
        public void get_OSX(){} // RVA: 0x7FFE8687E4F0
        public void get_Windows(){} // RVA: 0x7FFE8687E550
        public void .ctor(){} // RVA: 0x7FFE8687E5B0
        public void Create(){} // RVA: 0x7FFE8687E6D0
        public void Equals(){} // RVA: 0x7FFE8687E960 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE867B5B10
        public void ToString(){} // RVA: 0x7FFE8687EA00
        public void op_Equality(){} // RVA: 0x7FFE8687EA50
        public void .cctor(){} // RVA: 0x7FFE8687EAB0
    }

    public class OptionalAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OutAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PreserveSigAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeInformation : Object
    {
        public 0x664CDBDC _osArchitecture;
        public 0x664CDBDC _processArchitecture; // 0x4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86880240
        public void GetRuntimeArchitecture(){} // RVA: 0x7FFE86880C60
        public void GetOSName(){} // RVA: 0x7FFE86880C80
        public void get_FrameworkDescription(){} // RVA: 0x7FFE86880CA0
        public void IsOSPlatform(){} // RVA: 0x7FFE86880D20
        public void get_OSDescription(){} // RVA: 0x7FFE86880E00
    }

    public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
    {
        public object Uninitialized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687EFC0
        public void Initialize(){} // RVA: 0x7FFE8687F040
        public void AcquirePointer(){} // RVA: 0x7FFE8687F110
        public void ReleasePointer(){} // RVA: 0x7FFE8687F1E0
        public void get_ByteLength(){} // RVA: 0x7FFE8687F290
        public void NotInitialized(){} // RVA: 0x7FFE8687F340
        public void .cctor(){} // RVA: 0x7FFE8687F3B0
    }

    public class SafeHandle : CriticalFinalizerObject
    {
        public UIntPtr handle; // 0x10
        public int _state; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687FA80
        public void Finalize(){} // RVA: 0x7FFE8687FB10
        public void SetHandle(){} // RVA: 0x7FFE826F2ED0
        public void DangerousGetHandle(){} // RVA: 0x7FFE81116380
        public void get_IsClosed(){} // RVA: 0x7FFE8687FB80
        public void get_IsInvalid(){} // RVA: 0x7FFE80E2F150
        public void Close(){} // RVA: 0x7FFE865F29F0
        public void Dispose(){} // RVA: 0x7FFE8687FB90 | overloaded x2
        public void ReleaseHandle(){} // RVA: 0x7FFE80E2F150
        public void SetHandleAsInvalid(){} // RVA: 0x7FFE8687FC50
        public void DangerousAddRef(){} // RVA: 0x7FFE8687FD80
        public void DangerousRelease(){} // RVA: 0x7FFE8687FF10
        public void InternalDispose(){} // RVA: 0x7FFE8687FF20
        public void InternalFinalize(){} // RVA: 0x7FFE8687FFC0
        public void DangerousReleaseInternal(){} // RVA: 0x7FFE8687FFE0
    }

    public class SequenceMarshal : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7FFE86E02F30
    }

    public class StructLayoutAttribute : Attribute
    {
    }

    public class SuppressGCTransitionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnmanagedCallersOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnmanagedFunctionPointerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
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