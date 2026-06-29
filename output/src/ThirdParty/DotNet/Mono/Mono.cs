// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono
// Classes: 18
// Methods: 75

namespace ThirdParty.DotNet.Mono
{
    public class DependencyInjector : Object
    {
        public object locker;
        public object systemDependency;

        // ── Methods ──
        public void get_SystemProvider(){} // RVA: 0x666D890
        public void Register(){} // RVA: 0x666DD70
        public void ReflectionLoad(){} // RVA: 0x666DFC0
        public void .cctor(){} // RVA: 0x666E170
    }

    public class ISystemCertificateProvider
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x88B6A0
    }

    public class ISystemDependencyProvider
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x87C0A0
    }

    public class Runtime : Object
    {
        public object dump;

        // ── Methods ──
        public void GetDisplayName(){} // RVA: 0x666E220
        public void .cctor(){} // RVA: 0x666E240
    }

    public class RuntimeClassHandle : ValueType
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void get_Value(){} // RVA: 0x77900
        public void Equals(){} // RVA: 0x8AB410
        public void GetHashCode(){} // RVA: 0x77E60
        public void GetTypeFromClass(){} // RVA: 0x649B1A0
        public void GetTypeHandle(){} // RVA: 0x8AB4F0
    }

    public class RuntimeEventHandle : ValueType
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void get_Value(){} // RVA: 0x77900
        public void Equals(){} // RVA: 0x8AB5A0
        public void GetHashCode(){} // RVA: 0x77E60
    }

    public class RuntimeGPtrArrayHandle : ValueType
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void get_Length(){} // RVA: 0x8AB760
        public void get_Item(){} // RVA: 0x8AB780
        public void Lookup(){} // RVA: 0x8AB790
        public void GPtrArrayFree(){} // RVA: 0x666E8A0
        public void DestroyAndFree(){} // RVA: 0x666E8E0
    }

    public class RuntimeGenericParamInfoHandle : ValueType
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void get_Constraints(){} // RVA: 0x8AB520
        public void get_Attributes(){} // RVA: 0x8AB530
        public void GetConstraints(){} // RVA: 0x8AB550
        public void GetConstraintsCount(){} // RVA: 0x8AB560
    }

    public class RuntimeMarshal : Object
    {
        // ── Methods ──
        public void PtrToUtf8String(){} // RVA: 0x666E940
        public void MarshalString(){} // RVA: 0x666EA20
        public void DecodeBlobSize(){} // RVA: 0x666EA90
        public void DecodeBlobArray(){} // RVA: 0x666EAF0
        public void AsciHexDigitValue(){} // RVA: 0x666EBE0
        public void FreeAssemblyName(){} // RVA: 0x666EC10
    }

    public class RuntimePropertyHandle : ValueType
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void get_Value(){} // RVA: 0x77900
        public void Equals(){} // RVA: 0x8AB680
        public void GetHashCode(){} // RVA: 0x77E60
    }

    public class RuntimeRemoteClassHandle : ValueType
    {
        public object value;

        // ── Methods ──
        public void get_ProxyClass(){} // RVA: 0x8AB500
    }

    public class SafeGPtrArrayHandle : ValueType
    {
        public object handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void Dispose(){} // RVA: 0x8AB7A0
        public void get_Length(){} // RVA: 0x8AB760
        public void get_Item(){} // RVA: 0x8AB780
    }

    public class SafeStringMarshal : ValueType
    {
        public object str;
        public object marshaled_string;

        // ── Methods ──
        public void StringToUtf8_icall(){} // RVA: 0x666EC50
        public void StringToUtf8(){} // RVA: 0x666ED40
        public void GFree(){} // RVA: 0x6509340
        public void .ctor(){} // RVA: 0x8AB8F0
        public void get_Value(){} // RVA: 0x8AB900
        public void Dispose(){} // RVA: 0x8AB910
    }

    public class SystemCertificateProvider : Object
    {
        public object provider;
        public object initialized;
        public object x509pal;
        public object syncRoot;

        // ── Methods ──
        public void GetX509Pal(){} // RVA: 0x70EB3B0
        public void EnsureInitialized(){} // RVA: 0x70EB720
        public void get_X509Pal(){} // RVA: 0x70EB9D0
        public void Import(){} // RVA: 0x70EBDD0
        public void Mono.ISystemCertificateProvider.Import(){} // RVA: 0x70EBC50
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x70EBF50
    }

    public class SystemDependencyProvider : Object
    {
        public object instance;
        public object syncRoot;
        public object _certificateProvider;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x70EC010
        public void Initialize(){} // RVA: 0x70EC070
        public void Mono.ISystemDependencyProvider.get_CertificateProvider(){} // RVA: 0xB5DBF0
        public void get_CertificateProvider(){} // RVA: 0xB5DBF0
        public void get_X509Pal(){} // RVA: 0x70EC360
        public void .ctor(){} // RVA: 0x70EC3D0
        public void .cctor(){} // RVA: 0x70EC490
    }

    public class X509Pal : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x70EC550
    }

    public class X509PalImpl : Object
    {
        public object signedData;

        // ── Methods ──
        public void Import(){} // RVA: 0x87C540
        public void PEM(){} // RVA: 0x70EC6B0
        public void ConvertData(){} // RVA: 0x70EC930
        public void ImportFallback(){} // RVA: 0x70ECB50
        public void get_SupportsLegacyBasicConstraintsExtension(){} // RVA: 0xB43320
        public void GetCertContentType(){} // RVA: 0x70ECBD0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x70ECF60
    }

    public class X509PalImplMono : X509PalImpl
    {
        // ── Methods ──
        public void Import(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0x70EC660
    }

}