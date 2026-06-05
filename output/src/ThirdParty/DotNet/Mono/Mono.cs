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
        public void get_SystemProvider(){} // RVA: 0x7FFAF86A4ED0
        public void Register(){} // RVA: 0x7FFAF86A5230
        public void ReflectionLoad(){} // RVA: 0x7FFAF86A54B0
        public void .cctor(){} // RVA: 0x7FFAF86A5670
    }

    public class ISystemCertificateProvider
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAF2ACDD80 | overloaded x3
    }

    public class ISystemDependencyProvider
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7FFAF2ABCD60
    }

    public class MonoAssemblyName
    {
    }

    public class Runtime
    {
        // ── Methods ──
        public void GetDisplayName(){} // RVA: 0x7FFAF86A5720
        public void .cctor(){} // RVA: 0x7FFAF86A5740
    }

    public class RuntimeClassHandle
    {
        public object ProxyClass;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void Equals(){} // RVA: 0x7FFAF86A57F0
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
        public void GetTypeFromClass(){} // RVA: 0x7FFAF84D0F80
        public void GetTypeHandle(){} // RVA: 0x7FFAF86A58E0
    }

    public class RuntimeEventHandle
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void Equals(){} // RVA: 0x7FFAF86A5B70
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
    }

    public class RuntimeGPtrArrayHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void get_Length(){} // RVA: 0x7FFAF86A5D50
        public void get_Item(){} // RVA: 0x7FFAF86A5D70
        public void Lookup(){} // RVA: 0x7FFAF86A5D80
        public void GPtrArrayFree(){} // RVA: 0x7FFAF86A5E00
        public void DestroyAndFree(){} // RVA: 0x7FFAF86A5E40
    }

    public class RuntimeGenericParamInfoHandle
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void get_Constraints(){} // RVA: 0x7FFAF86A5910
        public void get_Attributes(){} // RVA: 0x7FFAF86A5920
        public void GetConstraints(){} // RVA: 0x7FFAF86A5940
        public void GetConstraintsCount(){} // RVA: 0x7FFAF86A5B40
    }

    public class RuntimeMarshal
    {
        // ── Methods ──
        public void PtrToUtf8String(){} // RVA: 0x7FFAF86A5EA0
        public void MarshalString(){} // RVA: 0x7FFAF86A5FA0
        public void DecodeBlobSize(){} // RVA: 0x7FFAF86A6010
        public void DecodeBlobArray(){} // RVA: 0x7FFAF86A6070
        public void AsciHexDigitValue(){} // RVA: 0x7FFAF86A6160
        public void FreeAssemblyName(){} // RVA: 0x7FFAF86A6190
    }

    public class RuntimePropertyHandle
    {
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void Equals(){} // RVA: 0x7FFAF86A5C60
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
    }

    public class RuntimeRemoteClassHandle
    {
        public object Constraints;

        // ── Methods ──
        public void get_ProxyClass(){} // RVA: 0x7FFAF86A58F0
    }

    public class RuntimeStructs
    {
    }

    public class SafeGPtrArrayHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320
        public void Dispose(){} // RVA: 0x7FFAF86A5E40
        public void get_Length(){} // RVA: 0x7FFAF86A5D50
        public void get_Item(){} // RVA: 0x7FFAF86A5D70
    }

    public class SafeStringMarshal : StringToUtf8_icall
    {
        // ── Methods ──
        public void StringToUtf8_icall(){} // RVA: 0x7FFAF86A61D0
        public void StringToUtf8(){} // RVA: 0x7FFAF86A62B0
        public void GFree(){} // RVA: 0x7FFAF853F080
        public void .ctor(){} // RVA: 0x7FFAF86A6390
        public void get_Value(){} // RVA: 0x7FFAF86A6400
        public void Dispose(){} // RVA: 0x7FFAF86A6510
    }

    public class SystemCertificateProvider
    {
        // ── Methods ──
        public void GetX509Pal(){} // RVA: 0x7FFAF9130B20
        public void EnsureInitialized(){} // RVA: 0x7FFAF9130E90
        public void get_X509Pal(){} // RVA: 0x7FFAF9131170
        public void Import(){} // RVA: 0x7FFAF9131400 | overloaded x3
        public void Mono.ISystemCertificateProvider.Import(){} // RVA: 0x7FFAF91313F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF9131590
    }

    public class SystemDependencyProvider
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF9131650
        public void Initialize(){} // RVA: 0x7FFAF91316B0
        public void Mono.ISystemDependencyProvider.get_CertificateProvider(){} // RVA: 0x7FFAF2DA8380
        public void get_CertificateProvider(){} // RVA: 0x7FFAF2DA8380
        public void get_X509Pal(){} // RVA: 0x7FFAF91319D0
        public void .ctor(){} // RVA: 0x7FFAF9131A40
        public void .cctor(){} // RVA: 0x7FFAF9131B00
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
        public void get_Instance(){} // RVA: 0x7FFAF9131BC0
    }

    public class X509PalImpl
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAF2ABCE10 | overloaded x3
        public void PEM(){} // RVA: 0x7FFAF9131D20
        public void ConvertData(){} // RVA: 0x7FFAF9131FA0
        public void ImportFallback(){} // RVA: 0x7FFAF91321C0 | overloaded x2
        public void get_SupportsLegacyBasicConstraintsExtension(){} // RVA: 0x7FFAF2D8D320
        public void GetCertContentType(){} // RVA: 0x7FFAF9132240
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF91325D0
    }

    public class X509PalImplMono
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAF2FC9240 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF9131CD0
    }

}