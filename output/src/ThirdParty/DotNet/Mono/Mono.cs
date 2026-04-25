// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono
// Classes: 26
// Methods: 86

namespace ThirdParty.DotNet.Mono
{
    public class DependencyInjector : Object
    {
        public object SystemProvider;
        public Mono.ISystemDependencyProvider systemDependency; // 0x8

        // ── Methods ──
        public void get_SystemProvider(){} // RVA: 0x7FFAC838C420
        public void Register(){} // RVA: 0x7FFAC838C780
        public void ReflectionLoad(){} // RVA: 0x7FFAC838CA00
        public void .cctor(){} // RVA: 0x7FFAC838CBC0
    }

    public class ISystemCertificateProvider
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAC2C69DD0 | overloaded x3
    }

    public class ISystemDependencyProvider
    {
        public object CertificateProvider;

        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7FFAC2C58E90
    }

    public class MonoAssemblyName : ValueType
    {
        public UIntPtr name; // 0x10
        public UIntPtr culture; // 0x18
        public UIntPtr hash_value; // 0x20
        public UIntPtr public_key; // 0x28
        public <public_key_token>e__FixedBuffer public_key_token; // 0x30
        public uint hash_alg; // 0x44
        public uint hash_len; // 0x48
        public uint flags; // 0x4C
        public ushort major; // 0x50
        public ushort minor; // 0x52
        public ushort build; // 0x54
        public ushort revision; // 0x56
        public ushort arch; // 0x58
    }

    public class Runtime : Object
    {
        public object dump;

        // ── Methods ──
        public void GetDisplayName(){} // RVA: 0x7FFAC838CC70
        public void .cctor(){} // RVA: 0x7FFAC838CC90
    }

    public class RuntimeClassHandle : ValueType
    {
        public MonoClass* Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void Equals(){} // RVA: 0x7FFAC838CD40
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void GetTypeFromClass(){} // RVA: 0x7FFAC81B83A0
        public void GetTypeHandle(){} // RVA: 0x7FFAC838CE30
    }

    public class RuntimeEventHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void Equals(){} // RVA: 0x7FFAC838D0C0
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
    }

    public class RuntimeGPtrArrayHandle : ValueType
    {
        public GPtrArray* Length; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void get_Length(){} // RVA: 0x7FFAC838D2A0
        public void get_Item(){} // RVA: 0x7FFAC838D2C0
        public void Lookup(){} // RVA: 0x7FFAC838D2D0
        public void GPtrArrayFree(){} // RVA: 0x7FFAC838D350
        public void DestroyAndFree(){} // RVA: 0x7FFAC838D390
    }

    public class RuntimeGenericParamInfoHandle : ValueType
    {
        public GenericParamInfo* Constraints; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void get_Constraints(){} // RVA: 0x7FFAC838CE60
        public void get_Attributes(){} // RVA: 0x7FFAC838CE70
        public void GetConstraints(){} // RVA: 0x7FFAC838CE90
        public void GetConstraintsCount(){} // RVA: 0x7FFAC838D090
    }

    public class RuntimeMarshal : Object
    {
        // ── Methods ──
        public void PtrToUtf8String(){} // RVA: 0x7FFAC838D3F0
        public void MarshalString(){} // RVA: 0x7FFAC838D4F0
        public void DecodeBlobSize(){} // RVA: 0x7FFAC838D560
        public void DecodeBlobArray(){} // RVA: 0x7FFAC838D5C0
        public void AsciHexDigitValue(){} // RVA: 0x7FFAC838D6B0
        public void FreeAssemblyName(){} // RVA: 0x7FFAC838D6E0
    }

    public class RuntimePropertyHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void Equals(){} // RVA: 0x7FFAC838D1B0
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
    }

    public class RuntimeRemoteClassHandle : ValueType
    {
        public RemoteClass* ProxyClass; // 0x10

        // ── Methods ──
        public void get_ProxyClass(){} // RVA: 0x7FFAC838CE40
    }

    public class RuntimeStructs : Object
    {
    }

    public class SafeGPtrArrayHandle : ValueType
    {
        public Mono.RuntimeGPtrArrayHandle Length; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void Dispose(){} // RVA: 0x7FFAC838D390
        public void get_Length(){} // RVA: 0x7FFAC838D2A0
        public void get_Item(){} // RVA: 0x7FFAC838D2C0
    }

    public class SafeStringMarshal : ValueType
    {
        public string Value; // 0x10
        public UIntPtr marshaled_string; // 0x18

        // ── Methods ──
        public void StringToUtf8_icall(){} // RVA: 0x7FFAC838D720
        public void StringToUtf8(){} // RVA: 0x7FFAC838D800
        public void GFree(){} // RVA: 0x7FFAC82264A0
        public void .ctor(){} // RVA: 0x7FFAC838D8E0
        public void get_Value(){} // RVA: 0x7FFAC838D950
        public void Dispose(){} // RVA: 0x7FFAC838DA60
    }

    public class SystemCertificateProvider : Object
    {
        public Mono.Security.Interface.MonoTlsProvider X509Pal;
        public int initialized; // 0x8
        public Mono.X509PalImpl x509pal; // 0x10
        public object syncRoot; // 0x18

        // ── Methods ──
        public void GetX509Pal(){} // RVA: 0x7FFAC8E175E0
        public void EnsureInitialized(){} // RVA: 0x7FFAC8E17950
        public void get_X509Pal(){} // RVA: 0x7FFAC8E17C30
        public void Import(){} // RVA: 0x7FFAC8E17EC0 | overloaded x3
        public void Mono.ISystemCertificateProvider.Import(){} // RVA: 0x7FFAC8E17EB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8E18050
    }

    public class SystemDependencyProvider : Object
    {
        public Mono.SystemDependencyProvider Instance;
        public object Mono.ISystemDependencyProvider.CertificateProvider; // 0x8
        public Mono.SystemCertificateProvider CertificateProvider; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8E18110
        public void Initialize(){} // RVA: 0x7FFAC8E18170
        public void Mono.ISystemDependencyProvider.get_CertificateProvider(){} // RVA: 0x7FFAC2F3C380
        public void get_CertificateProvider(){} // RVA: 0x7FFAC2F3C380
        public void get_X509Pal(){} // RVA: 0x7FFAC8E18490
        public void .ctor(){} // RVA: 0x7FFAC8E18500
        public void .cctor(){} // RVA: 0x7FFAC8E185C0
    }

    public class ValueTuple : ValueType
    {
    }

    public class ValueTuple`1 : ValueType
    {
        public T Item1;
    }

    public class ValueTuple`2 : ValueType
    {
        public U Item1;
        public T Item2;
    }

    public class ValueTuple`3 : ValueType
    {
        public U Item1;
        public V Item2;
        public T Item3;
    }

    public class ValueTuple`4 : ValueType
    {
        public U Item1;
        public V Item2;
        public W Item3;
        public T Item4;
    }

    public class ValueTuple`5 : ValueType
    {
        public U Item1;
        public V Item2;
        public W Item3;
        public T4 Item4;
        public T Item5;
    }

    public class X509Pal : Object
    {
        public object Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8E18680
    }

    public class X509PalImpl : Object
    {
        public byte[] SupportsLegacyBasicConstraintsExtension;

        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAC2C58F40 | overloaded x3
        public void PEM(){} // RVA: 0x7FFAC8E187E0
        public void ConvertData(){} // RVA: 0x7FFAC8E18A60
        public void ImportFallback(){} // RVA: 0x7FFAC8E18C80 | overloaded x2
        public void get_SupportsLegacyBasicConstraintsExtension(){} // RVA: 0x7FFAC2F21320
        public void GetCertContentType(){} // RVA: 0x7FFAC8E18D00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8E19090
    }

    public class X509PalImplMono : X509PalImpl
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAC34F9180 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC8E18790
    }

}