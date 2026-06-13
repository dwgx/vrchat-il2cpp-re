// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono
// Classes: 26
// Methods: 86

namespace ThirdParty.DotNet.Mono
{
    public class DependencyInjector
    {
        public object CertificateProvider;

        // ── Methods ──
        public void get_SystemProvider(){} // RVA: 0x5BF4ED0
        public void Register(){} // RVA: 0x5BF5230
        public void ReflectionLoad(){} // RVA: 0x5BF54B0
        public void .cctor(){} // RVA: 0x5BF5670
    }

    public class ISystemCertificateProvider
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x1DD80 | overloaded x3
    }

    public class ISystemDependencyProvider
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0xCD60
    }

    public class MonoAssemblyName
    {
    }

    public class Runtime
    {
        // ── Methods ──
        public void GetDisplayName(){} // RVA: 0x5BF5720
        public void .cctor(){} // RVA: 0x5BF5740
    }

    public class RuntimeClassHandle
    {
        public MonoClass* ProxyClass; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320 | overloaded x2
        public void get_Value(){} // RVA: 0x1AD4690
        public void Equals(){} // RVA: 0x5BF57F0
        public void GetHashCode(){} // RVA: 0x19689B0
        public void GetTypeFromClass(){} // RVA: 0x5A20F80
        public void GetTypeHandle(){} // RVA: 0x5BF58E0
    }

    public class RuntimeEventHandle
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void get_Value(){} // RVA: 0x1AD4690
        public void Equals(){} // RVA: 0x5BF5B70
        public void GetHashCode(){} // RVA: 0x19689B0
    }

    public class RuntimeGPtrArrayHandle
    {
        public GPtrArray* value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void get_Length(){} // RVA: 0x5BF5D50
        public void get_Item(){} // RVA: 0x5BF5D70
        public void Lookup(){} // RVA: 0x5BF5D80
        public void GPtrArrayFree(){} // RVA: 0x5BF5E00
        public void DestroyAndFree(){} // RVA: 0x5BF5E40
    }

    public class RuntimeGenericParamInfoHandle
    {
        public GenericParamInfo* Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void get_Constraints(){} // RVA: 0x5BF5910
        public void get_Attributes(){} // RVA: 0x5BF5920
        public void GetConstraints(){} // RVA: 0x5BF5940
        public void GetConstraintsCount(){} // RVA: 0x5BF5B40
    }

    public class RuntimeMarshal
    {
        // ── Methods ──
        public void PtrToUtf8String(){} // RVA: 0x5BF5EA0
        public void MarshalString(){} // RVA: 0x5BF5FA0
        public void DecodeBlobSize(){} // RVA: 0x5BF6010
        public void DecodeBlobArray(){} // RVA: 0x5BF6070
        public void AsciHexDigitValue(){} // RVA: 0x5BF6160
        public void FreeAssemblyName(){} // RVA: 0x5BF6190
    }

    public class RuntimePropertyHandle
    {
        public UIntPtr Length; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void get_Value(){} // RVA: 0x1AD4690
        public void Equals(){} // RVA: 0x5BF5C60
        public void GetHashCode(){} // RVA: 0x19689B0
    }

    public class RuntimeRemoteClassHandle
    {
        public RemoteClass* Constraints; // 0x10

        // ── Methods ──
        public void get_ProxyClass(){} // RVA: 0x5BF58F0
    }

    public class RuntimeStructs
    {
    }

    public class SafeGPtrArrayHandle
    {
        public Mono.RuntimeGPtrArrayHandle handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320
        public void Dispose(){} // RVA: 0x5BF5E40
        public void get_Length(){} // RVA: 0x5BF5D50
        public void get_Item(){} // RVA: 0x5BF5D70
    }

    public class SafeStringMarshal : StringToUtf8_icall
    {
        public string str; // 0x10

        // ── Methods ──
        public void StringToUtf8_icall(){} // RVA: 0x5BF61D0
        public void StringToUtf8(){} // RVA: 0x5BF62B0
        public void GFree(){} // RVA: 0x5A8F080
        public void .ctor(){} // RVA: 0x5BF6390
        public void get_Value(){} // RVA: 0x5BF6400
        public void Dispose(){} // RVA: 0x5BF6510
    }

    public class SystemCertificateProvider
    {
        public Mono.Security.Interface.MonoTlsProvider provider;

        // ── Methods ──
        public void GetX509Pal(){} // RVA: 0x6680B20
        public void EnsureInitialized(){} // RVA: 0x6680E90
        public void get_X509Pal(){} // RVA: 0x6681170
        public void Import(){} // RVA: 0x6681400 | overloaded x3
        public void Mono.ISystemCertificateProvider.Import(){} // RVA: 0x66813F0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6681590
    }

    public class SystemDependencyProvider
    {
        public Mono.SystemDependencyProvider instance;
        public object syncRoot; // 0x8
        public Mono.SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6681650
        public void Initialize(){} // RVA: 0x66816B0
        public void Mono.ISystemDependencyProvider.get_CertificateProvider(){} // RVA: 0x2F8380
        public void get_CertificateProvider(){} // RVA: 0x2F8380
        public void get_X509Pal(){} // RVA: 0x66819D0
        public void .ctor(){} // RVA: 0x6681A40
        public void .cctor(){} // RVA: 0x6681B00
    }

    public class ValueTuple
    {
    }

    public class ValueTuple`1
    {
    }

    public class ValueTuple`2
    {
    }

    public class ValueTuple`3
    {
    }

    public class ValueTuple`4
    {
    }

    public class ValueTuple`5
    {
    }

    public class X509Pal
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6681BC0
    }

    public class X509PalImpl
    {
        public byte[] signedData;

        // ── Methods ──
        public void Import(){} // RVA: 0xCE10 | overloaded x3
        public void PEM(){} // RVA: 0x6681D20
        public void ConvertData(){} // RVA: 0x6681FA0
        public void ImportFallback(){} // RVA: 0x66821C0 | overloaded x2
        public void get_SupportsLegacyBasicConstraintsExtension(){} // RVA: 0x2DD320
        public void GetCertContentType(){} // RVA: 0x6682240
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x66825D0
    }

    public class X509PalImplMono
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x519240 | overloaded x3
        public void .ctor(){} // RVA: 0x6681CD0
    }

}