// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.InteropServices
// Classes: 40
// Methods: 206

namespace ThirdParty.DotNet.System.Runtime.InteropServices
{
    public class AddrofIntrinsics : Object
    {
        // ── Methods ──
        public void AddrOf(){} // RVA: 0xA94080
    }

    public class COMException : ExternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
        public void ToString(){} // RVA: 0x67B6F80
    }

    public class ClassInterfaceAttribute : Attribute
    {
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class CollectionsMarshal : Object
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x3030D40
    }

    public class CollectionsMarshal : Object
    {
        public object ListSize;

        // ── Methods ──
        public void AsSpan(){} // RVA: 0x302FBE0
        public void UnsafeSetCount(){} // RVA: 0x30307B0
        public void .cctor(){} // RVA: 0xA7B59F0
    }

    public class ComCompatibleVersionAttribute : Attribute
    {
        public object _major;
        public object _minor;
        public object _build;
        public object _revision;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B7600
    }

    public class ComDefaultInterfaceAttribute : Attribute
    {
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class ComImportAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ComVisibleAttribute : Attribute
    {
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
    }

    public class DefaultDllImportSearchPathsAttribute : Attribute
    {
        public object _paths;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class DllImportAttribute : Attribute
    {
        public object _val;
        public object EntryPoint;
        public object CharSet;
        public object SetLastError;
        public object ExactSpelling;
        public object PreserveSig;
        public object CallingConvention;
        public object BestFitMapping;
        public object ThrowOnUnmappableChar;

        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x67B7260
        public void IsDefined(){} // RVA: 0x67B74E0
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB5DBF0
    }

    public class ExternalException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
        public void get_ErrorCode(){} // RVA: 0xD347A0
        public void ToString(){} // RVA: 0x67B5C70
    }

    public class FieldOffsetAttribute : Attribute
    {
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class GCHandle : ValueType
    {
        public object handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AEC30
        public void get_IsAllocated(){} // RVA: 0x311760
        public void GetRef(){} // RVA: 0x239A590
        public void SetRef(){} // RVA: 0x173E760
        public void CanDereferenceHandle(){} // RVA: 0x67B8AA0
        public void get_Target(){} // RVA: 0x8AEDC0
        public void set_Target(){} // RVA: 0x8AEDD0
        public void AddrOfPinnedObject(){} // RVA: 0x8AEDE0
        public void Alloc(){} // RVA: 0x67B8CC0
        public void Free(){} // RVA: 0x8AEDF0
        public void op_Explicit(){} // RVA: 0x67B8ED0
        public void CheckCurrentDomain(){} // RVA: 0xC2E4C0
        public void GetTarget(){} // RVA: 0x6509330
        public void GetTargetHandle(){} // RVA: 0x67B8F40
        public void FreeHandle(){} // RVA: 0x67B9040
        public void GetAddrOfPinnedObject(){} // RVA: 0x67B9050
        public void op_Equality(){} // RVA: 0x2AFB5A0
        public void Equals(){} // RVA: 0x8AEE00
        public void GetHashCode(){} // RVA: 0x77E60
        public void FromIntPtr(){} // RVA: 0x67B8ED0
        public void ToIntPtr(){} // RVA: 0x2303260
    }

    public class GCHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAF320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6B380
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GuidAttribute : Attribute
    {
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class HandleRef : ValueType
    {
        public object _wrapper;
        public object _handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x260A0
        public void get_Handle(){} // RVA: 0x77ED0
    }

    public class ICustomMarshaler
    {
        // ── Methods ──
        public void MarshalNativeToManaged(){} // RVA: 0x881D60
        public void MarshalManagedToNative(){} // RVA: 0x87C540
        public void CleanUpNativeData(){} // RVA: 0x8943F0
        public void CleanUpManagedData(){} // RVA: 0x894320
        public void GetNativeDataSize(){} // RVA: 0x87C130
    }

    public class InAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InterfaceTypeAttribute : Attribute
    {
        public object _val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class LibraryImportAttribute : Attribute
    {
        public object _libraryName;
        public object _entryPoint;
        public object _stringMarshalling;
        public object _stringMarshallingCustomType;
        public object _setLastError;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_LibraryName(){} // RVA: 0xB5DBF0
        public void get_EntryPoint(){} // RVA: 0xB465B0
        public void set_EntryPoint(){} // RVA: 0xBA9BA0
        public void get_StringMarshalling(){} // RVA: 0xFEAE90
        public void set_StringMarshalling(){} // RVA: 0x1269760
        public void get_StringMarshallingCustomType(){} // RVA: 0xB70160
        public void set_StringMarshallingCustomType(){} // RVA: 0xB44DC0
        public void get_SetLastError(){} // RVA: 0xB68DF0
        public void set_SetLastError(){} // RVA: 0xB68E00
    }

    public class LibraryImportAttribute : Attribute
    {
        public object _libraryName;
        public object _entryPoint;
        public object _stringMarshalling;
        public object _stringMarshallingCustomType;
        public object _setLastError;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_LibraryName(){} // RVA: 0xB5DBF0
        public void get_EntryPoint(){} // RVA: 0xB465B0
        public void set_EntryPoint(){} // RVA: 0xBA9BA0
        public void get_StringMarshalling(){} // RVA: 0xFEAE90
        public void set_StringMarshalling(){} // RVA: 0x1269760
        public void get_StringMarshallingCustomType(){} // RVA: 0xB70160
        public void set_StringMarshallingCustomType(){} // RVA: 0xB44DC0
        public void get_SetLastError(){} // RVA: 0xB68DF0
        public void set_SetLastError(){} // RVA: 0xB68E00
    }

    public class Marshal : Object
    {
        public object SystemMaxDBCSCharSize;
        public object SystemDefaultCharSize;
        public object MarshalerInstanceCache;
        public object MarshalerInstanceCacheLock;

        // ── Methods ──
        public void AllocCoTaskMem(){} // RVA: 0x67B9150
        public void AllocHGlobal(){} // RVA: 0x67B9170
        public void copy_to_unmanaged(){} // RVA: 0x67B92C0
        public void copy_to_unmanaged_fixed(){} // RVA: 0x67B9250
        public void skip_fixed(){} // RVA: 0x67B9280
        public void Copy(){} // RVA: 0x67B9EE0
        public void copy_from_unmanaged(){} // RVA: 0x67B9920
        public void copy_from_unmanaged_fixed(){} // RVA: 0x67B99B0
        public void FreeBSTR(){} // RVA: 0x67B9FE0
        public void FreeCoTaskMem(){} // RVA: 0x67B9FF0
        public void FreeHGlobal(){} // RVA: 0x67BA000
        public void ClearBSTR(){} // RVA: 0x67BA010
        public void ZeroFreeBSTR(){} // RVA: 0x67BA0D0
        public void ClearUnicode(){} // RVA: 0x67BA1D0
        public void ZeroFreeGlobalAllocUnicode(){} // RVA: 0x67BA2C0
        public void GetHRForException(){} // RVA: 0x67BA3E0
        public void IsComObject(){} // RVA: 0x67BA3F0
        public void GetLastWin32Error(){} // RVA: 0x67BA430
        public void OffsetOf(){} // RVA: 0x67BA4A0
        public void PtrToStringAnsi(){} // RVA: 0x67BA4D0
        public void PtrToStringUTF8(){} // RVA: 0x67BA500
        public void PtrToStringUni(){} // RVA: 0x67BA5F0
        public void PtrToStructure(){} // RVA: 0x3153890
        public void ReadByte(){} // RVA: 0x2AFE9C0
        public void ReadInt16(){} // RVA: 0x67BA720
        public void ReadInt32(){} // RVA: 0x67BA7A0
        public void ReadInt64(){} // RVA: 0x67BA7E0
        public void ReadIntPtr(){} // RVA: 0x67BA820
        public void ReleaseInternal(){} // RVA: 0x67BA8A0
        public void Release(){} // RVA: 0x67BA8B0
        public void SizeOf(){} // RVA: 0x3154340
        public void StringToHGlobalAnsi(){} // RVA: 0x67BABE0
        public void StringToHGlobalUni(){} // RVA: 0x67BADB0
        public void SecureStringToBSTR(){} // RVA: 0x67BAE60
        public void SecureStringGlobalAllocator(){} // RVA: 0x67BAFB0
        public void SecureStringToUnicode(){} // RVA: 0x67BB040
        public void SecureStringToGlobalAllocUnicode(){} // RVA: 0x67BB320
        public void StructureToPtr(){} // RVA: 0x3154690
        public void BufferToBSTR(){} // RVA: 0x67BB5E0
        public void UnsafeAddrOfPinnedArrayElement(){} // RVA: 0x3155070
        public void WriteByte(){} // RVA: 0x2AFF640
        public void WriteInt16(){} // RVA: 0x67BB610
        public void GetDelegateForFunctionPointerInternal(){} // RVA: 0x67BB650
        public void GetDelegateForFunctionPointer(){} // RVA: 0xA94080
        public void GetFunctionPointerForDelegateInternal(){} // RVA: 0x67BB940
        public void GetFunctionPointerForDelegate(){} // RVA: 0x31535F0
        public void GetCustomMarshalerInstance(){} // RVA: 0x67BB9F0
        public void StringToCoTaskMemUTF8(){} // RVA: 0x67BC4D0
        public void .cctor(){} // RVA: 0x67BC5C0
    }

    public class MarshalAsAttribute : Attribute
    {
        public object MarshalCookie;
        public object MarshalType;
        public object MarshalTypeRef;
        public object SafeArrayUserDefinedSubType;
        public object utype;
        public object ArraySubType;
        public object SafeArraySubType;
        public object SizeConst;
        public object IidParameterIndex;
        public object SizeParamIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB9E090
        public void get_Value(){} // RVA: 0xB9E080
        public void Copy(){} // RVA: 0x67BC8D0
    }

    public class MarshalDirectiveException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class MemoryMarshal : Object
    {
        // ── Methods ──
        public void AsBytes(){} // RVA: 0x3163230
        public void AsMemory(){} // RVA: 0xA94080
        public void GetReference(){} // RVA: 0x239A590
        public void GetNonNullPinnableReference(){} // RVA: 0x3163BD0
        public void Cast(){} // RVA: 0x3163650
        public void CreateSpan(){} // RVA: 0x3163B80
        public void CreateReadOnlySpan(){} // RVA: 0x3163B80
        public void TryGetArray(){} // RVA: 0xA94080
        public void ToEnumerable(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0x3163E50
        public void Write(){} // RVA: 0x3164D70
        public void TryWrite(){} // RVA: 0x3164AD0
    }

    public class MemoryMarshal : Object
    {
        // ── Methods ──
        public void TryGetArray(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void TryWrite(){} // RVA: 0xA94080
        public void AsBytes(){} // RVA: 0xA94080
        public void GetReference(){} // RVA: 0xA94080
        public void Cast(){} // RVA: 0xA94080
    }

    public class NativeCallableAttribute : Attribute
    {
        public object CallingConvention;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OSPlatform : ValueType
    {
        public object _osPlatform;
        public object _linux;
        public object _oSX;
        public object _windows;

        // ── Methods ──
        public void get_Linux(){} // RVA: 0x67B6060
        public void get_OSX(){} // RVA: 0x67B60C0
        public void get_Windows(){} // RVA: 0x67B6120
        public void .ctor(){} // RVA: 0x8AEB50
        public void Create(){} // RVA: 0x67B62A0
        public void Equals(){} // RVA: 0x8AEB80
        public void GetHashCode(){} // RVA: 0x8AC630
        public void ToString(){} // RVA: 0x8AC510
        public void op_Equality(){} // RVA: 0x67B65D0
        public void .cctor(){} // RVA: 0x67B6630
    }

    public class OptionalAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OutAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PreserveSigAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeInformation : Object
    {
        public object _osArchitecture;
        public object _processArchitecture;
        public object _osPlatform;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x67B7D90
        public void GetRuntimeArchitecture(){} // RVA: 0x67B87B0
        public void GetOSName(){} // RVA: 0x67B87D0
        public void get_FrameworkDescription(){} // RVA: 0x67B87F0
        public void IsOSPlatform(){} // RVA: 0x67B8870
        public void get_OSDescription(){} // RVA: 0x67B8950
    }

    public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
    {
        public object Uninitialized;
        public object _numBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B6B40
        public void Initialize(){} // RVA: 0x67B6BC0
        public void AcquirePointer(){} // RVA: 0x67B6C90
        public void ReleasePointer(){} // RVA: 0x67B6D70
        public void get_ByteLength(){} // RVA: 0x67B6E20
        public void NotInitialized(){} // RVA: 0x67B6ED0
        public void .cctor(){} // RVA: 0x67B6F40
    }

    public class SafeHandle : CriticalFinalizerObject
    {
        public object handle;
        public object _state;
        public object _ownsHandle;
        public object _fullyInitialized;
        public object RefCount_Mask;
        public object RefCount_One;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B7620
        public void Finalize(){} // RVA: 0x67B76B0
        public void SetHandle(){} // RVA: 0x2230E30
        public void DangerousGetHandle(){} // RVA: 0xB5DBF0
        public void get_IsClosed(){} // RVA: 0x64D65D0
        public void get_IsInvalid(){} // RVA: 0x87D280
        public void Close(){} // RVA: 0x652C5D0
        public void Dispose(){} // RVA: 0x67B7720
        public void ReleaseHandle(){} // RVA: 0x87D280
        public void SetHandleAsInvalid(){} // RVA: 0x67B77E0
        public void DangerousAddRef(){} // RVA: 0x67B78F0
        public void DangerousRelease(){} // RVA: 0x67B7A60
        public void InternalDispose(){} // RVA: 0x67B7A70
        public void InternalFinalize(){} // RVA: 0x67B7B10
        public void DangerousReleaseInternal(){} // RVA: 0x67B7B30
    }

    public class SequenceMarshal : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x6D2F500
    }

    public class SequenceMarshal : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x67B5FC0
    }

    public class SuppressGCTransitionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnmanagedCallersOnlyAttribute : Attribute
    {
        public object CallConvs;
        public object EntryPoint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnmanagedFunctionPointerAttribute : Attribute
    {
        public object m_callingConvention;
        public object SetLastError;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

}