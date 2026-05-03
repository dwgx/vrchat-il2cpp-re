// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono
// Classes: 26
// Methods: 86

namespace ThirdParty.DotNet.Mono
{
    public class DependencyInjector : Object
    {
        public object locker;

        // ── Methods ──
        public void get_SystemProvider(){} // RVA: 0x7FFE86735D20
        public void Register(){} // RVA: 0x7FFE86736080
        public void ReflectionLoad(){} // RVA: 0x7FFE86736300
        public void .cctor(){} // RVA: 0x7FFE867364C0
    }

    public class ISystemCertificateProvider
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFE80E3F2F0 | overloaded x3
    }

    public class ISystemDependencyProvider
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7FFE80E2E2E0
    }

    public class MonoAssemblyName : ValueType
    {
    }

    public class Runtime : Object
    {
        // ── Methods ──
        public void GetDisplayName(){} // RVA: 0x7FFE86736570
        public void .cctor(){} // RVA: 0x7FFE86736590
    }

    public class RuntimeClassHandle : ValueType
    {
        public MonoClass* value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void Equals(){} // RVA: 0x7FFE86736640
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void GetTypeFromClass(){} // RVA: 0x7FFE86561CE0
        public void GetTypeHandle(){} // RVA: 0x7FFE86736730
    }

    public class RuntimeEventHandle : ValueType
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void Equals(){} // RVA: 0x7FFE867369C0
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
    }

    public class RuntimeGPtrArrayHandle : ValueType
    {
        public GPtrArray* value; // 0x10
        public object field_1; // 0xB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void get_Length(){} // RVA: 0x7FFE86736BA0
        public void get_Item(){} // RVA: 0x7FFE86736BC0
        public void Lookup(){} // RVA: 0x7FFE86736BD0
        public void GPtrArrayFree(){} // RVA: 0x7FFE86736C50
        public void DestroyAndFree(){} // RVA: 0x7FFE86736C90
    }

    public class RuntimeGenericParamInfoHandle : ValueType
    {
        public GenericParamInfo* value; // 0x10
        public object field_1; // 0x7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void get_Constraints(){} // RVA: 0x7FFE86736760
        public void get_Attributes(){} // RVA: 0x7FFE86736770
        public void GetConstraints(){} // RVA: 0x7FFE86736790
        public void GetConstraintsCount(){} // RVA: 0x7FFE86736990
    }

    public class RuntimeMarshal : Object
    {
        // ── Methods ──
        public void PtrToUtf8String(){} // RVA: 0x7FFE86736CF0
        public void MarshalString(){} // RVA: 0x7FFE86736DF0
        public void DecodeBlobSize(){} // RVA: 0x7FFE86736E60
        public void DecodeBlobArray(){} // RVA: 0x7FFE86736EC0
        public void AsciHexDigitValue(){} // RVA: 0x7FFE86736FB0
        public void FreeAssemblyName(){} // RVA: 0x7FFE86736FE0
    }

    public class RuntimePropertyHandle : ValueType
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void Equals(){} // RVA: 0x7FFE86736AB0
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
    }

    public class RuntimeRemoteClassHandle : ValueType
    {
        public RemoteClass* value; // 0x10

        // ── Methods ──
        public void get_ProxyClass(){} // RVA: 0x7FFE86736740
    }

    public class RuntimeStructs : Object
    {
    }

    public class SafeGPtrArrayHandle : ValueType
    {
        public Mono.RuntimeGPtrArrayHandle handle; // 0x10
        public object field_1; // 0xD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void Dispose(){} // RVA: 0x7FFE86736C90
        public void get_Length(){} // RVA: 0x7FFE86736BA0
        public void get_Item(){} // RVA: 0x7FFE86736BC0
    }

    public class SafeStringMarshal : ValueType
    {
        public string str; // 0x10

        // ── Methods ──
        public void StringToUtf8_icall(){} // RVA: 0x7FFE86737020
        public void StringToUtf8(){} // RVA: 0x7FFE86737100
        public void GFree(){} // RVA: 0x7FFE865CFDE0
        public void .ctor(){} // RVA: 0x7FFE867371E0
        public void get_Value(){} // RVA: 0x7FFE86737250
        public void Dispose(){} // RVA: 0x7FFE86737360
    }

    public class SystemCertificateProvider : Object
    {
        public Mono.Security.Interface.MonoTlsProvider provider;

        // ── Methods ──
        public void GetX509Pal(){} // RVA: 0x7FFE871BFA10
        public void EnsureInitialized(){} // RVA: 0x7FFE871BFD80
        public void get_X509Pal(){} // RVA: 0x7FFE871C0060
        public void Import(){} // RVA: 0x7FFE871C02F0 | overloaded x3
        public void Mono.ISystemCertificateProvider.Import(){} // RVA: 0x7FFE871C02E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE871C0480
    }

    public class SystemDependencyProvider : Object
    {
        public Mono.SystemDependencyProvider instance;
        public object syncRoot; // 0x8
        public Mono.SystemCertificateProvider _certificateProvider; // 0x10
        public object field_3; // 0x2

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE871C0540
        public void Initialize(){} // RVA: 0x7FFE871C05A0
        public void Mono.ISystemDependencyProvider.get_CertificateProvider(){} // RVA: 0x7FFE81116380
        public void get_CertificateProvider(){} // RVA: 0x7FFE81116380
        public void get_X509Pal(){} // RVA: 0x7FFE871C08C0
        public void .ctor(){} // RVA: 0x7FFE871C0930
        public void .cctor(){} // RVA: 0x7FFE871C09F0
    }

    public class ValueTuple : ValueType
    {
    }

    public class ValueTuple`1 : ValueType
    {
    }

    public class ValueTuple`2 : ValueType
    {
    }

    public class ValueTuple`3 : ValueType
    {
    }

    public class ValueTuple`4 : ValueType
    {
    }

    public class ValueTuple`5 : ValueType
    {
    }

    public class X509Pal : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE871C0AB0
    }

    public class X509PalImpl : Object
    {
        public byte[] signedData;

        // ── Methods ──
        public void Import(){} // RVA: 0x7FFE80E2E390 | overloaded x3
        public void PEM(){} // RVA: 0x7FFE871C0C10
        public void ConvertData(){} // RVA: 0x7FFE871C0E90
        public void ImportFallback(){} // RVA: 0x7FFE871C10B0 | overloaded x2
        public void get_SupportsLegacyBasicConstraintsExtension(){} // RVA: 0x7FFE810FB320
        public void GetCertContentType(){} // RVA: 0x7FFE871C1130
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE871C14C0
    }

    public class X509PalImplMono : X509PalImpl
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFE813240E0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE871C0BC0
    }

}