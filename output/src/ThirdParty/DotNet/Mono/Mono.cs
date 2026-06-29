// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono
// Classes: 18
// Methods: 75

namespace ThirdParty.DotNet.Mono
{
    public class DependencyInjector : Object
    {
        // ── Methods ──
        public void get_SystemProvider(){} // RVA: 0x7AD9E2B60
        public void Register(){} // RVA: 0x7AD9E3050
        public void ReflectionLoad(){} // RVA: 0x7AD9E32A0
        public void .cctor(){} // RVA: 0x7AD9E3460
    }

    public class ISystemCertificateProvider
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7A7E0FC80
    }

    public class ISystemDependencyProvider
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7A7E00680
    }

    public class Runtime : Object
    {
        // ── Methods ──
        public void GetDisplayName(){} // RVA: 0x7AD9E3510
        public void .cctor(){} // RVA: 0x7AD9E3530
    }

    public class RuntimeClassHandle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void get_Value(){} // RVA: 0x7A765F710
        public void Equals(){} // RVA: 0x7A7E2E7B0
        public void GetHashCode(){} // RVA: 0x7A765F070
        public void GetTypeFromClass(){} // RVA: 0x7AD80D310
        public void GetTypeHandle(){} // RVA: 0x7A7E2E8B0
    }

    public class RuntimeEventHandle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void get_Value(){} // RVA: 0x7A765F710
        public void Equals(){} // RVA: 0x7A7E2E960
        public void GetHashCode(){} // RVA: 0x7A765F070
    }

    public class RuntimeGPtrArrayHandle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void get_Length(){} // RVA: 0x7A7E2EB60
        public void get_Item(){} // RVA: 0x7A7E2EB80
        public void Lookup(){} // RVA: 0x7A7E2EB90
        public void GPtrArrayFree(){} // RVA: 0x7AD9E3BF0
        public void DestroyAndFree(){} // RVA: 0x7AD9E3C30
    }

    public class RuntimeGenericParamInfoHandle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void get_Constraints(){} // RVA: 0x7A7E2E8E0
        public void get_Attributes(){} // RVA: 0x7A7E2E8F0
        public void GetConstraints(){} // RVA: 0x7A7E2E910
        public void GetConstraintsCount(){} // RVA: 0x7A7E2E920
    }

    public class RuntimeMarshal : Object
    {
        // ── Methods ──
        public void PtrToUtf8String(){} // RVA: 0x7AD9E3C90
        public void MarshalString(){} // RVA: 0x7AD9E3D90
        public void DecodeBlobSize(){} // RVA: 0x7AD9E3E00
        public void DecodeBlobArray(){} // RVA: 0x7AD9E3E60
        public void AsciHexDigitValue(){} // RVA: 0x7AD9E3F50
        public void FreeAssemblyName(){} // RVA: 0x7AD9E3F80
    }

    public class RuntimePropertyHandle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void get_Value(){} // RVA: 0x7A765F710
        public void Equals(){} // RVA: 0x7A7E2EA60
        public void GetHashCode(){} // RVA: 0x7A765F070
    }

    public class RuntimeRemoteClassHandle : ValueType
    {
        // ── Methods ──
        public void get_ProxyClass(){} // RVA: 0x7A7E2E8C0
    }

    public class SafeGPtrArrayHandle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void Dispose(){} // RVA: 0x7A7E2EBA0
        public void get_Length(){} // RVA: 0x7A7E2EB60
        public void get_Item(){} // RVA: 0x7A7E2EB80
    }

    public class SafeStringMarshal : ValueType
    {
        // ── Methods ──
        public void StringToUtf8_icall(){} // RVA: 0x7AD9E3FC0
        public void StringToUtf8(){} // RVA: 0x7AD9E40B0
        public void GFree(){} // RVA: 0x7AD87BE30
        public void .ctor(){} // RVA: 0x7A7E2ECF0
        public void get_Value(){} // RVA: 0x7A7E2ED00
        public void Dispose(){} // RVA: 0x7A7E2ED10
    }

    public class SystemCertificateProvider : Object
    {
        // ── Methods ──
        public void GetX509Pal(){} // RVA: 0x7AE46F2A0
        public void EnsureInitialized(){} // RVA: 0x7AE46F610
        public void get_X509Pal(){} // RVA: 0x7AE46F8C0
        public void Import(){} // RVA: 0x7AE46FCC0
        public void Mono.ISystemCertificateProvider.Import(){} // RVA: 0x7AE46FB40
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE46FE40
    }

    public class SystemDependencyProvider : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE46FF00
        public void Initialize(){} // RVA: 0x7AE46FF60
        public void Mono.ISystemDependencyProvider.get_CertificateProvider(){} // RVA: 0x7A80F2570
        public void get_CertificateProvider(){} // RVA: 0x7A80F2570
        public void get_X509Pal(){} // RVA: 0x7AE470250
        public void .ctor(){} // RVA: 0x7AE4702C0
        public void .cctor(){} // RVA: 0x7AE470380
    }

    public class X509Pal : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE470440
    }

    public class X509PalImpl : Object
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7A7E00B20
        public void PEM(){} // RVA: 0x7AE4705A0
        public void ConvertData(){} // RVA: 0x7AE470820
        public void ImportFallback(){} // RVA: 0x7AE470A40
        public void get_SupportsLegacyBasicConstraintsExtension(){} // RVA: 0x7A80D7320
        public void GetCertContentType(){} // RVA: 0x7AE470AC0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE470E50
    }

    public class X509PalImplMono : X509PalImpl
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7AE470550
    }

}