// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 26
// Methods: 190

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B92470
        public void CheckCircularDependency(){} // RVA: 0x5B925B0
        public void Remove(){} // RVA: 0x5B92690
        public void Add(){} // RVA: 0x5B92700
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x5B92840
        public void AppendResolutionPath(){} // RVA: 0x5B929E0
    }

    public class CallSiteFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B930D0
        public void get_Descriptors(){} // RVA: 0x2F8380
        public void Populate(){} // RVA: 0x5B934F0
        public void ValidateTrimmingAnnotations(){} // RVA: 0x5B93AB0
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x5B93CF0
        public void AreCompatible(){} // RVA: 0x188F1C0
        public void GetCallSite(){} // RVA: 0x5B94200 | overloaded x2
        public void CreateCallSite(){} // RVA: 0x5B94440
        public void TryCreateExact(){} // RVA: 0x5B95F30 | overloaded x2
        public void TryCreateOpenGeneric(){} // RVA: 0x5B96490 | overloaded x2
        public void TryCreateEnumerable(){} // RVA: 0x5B94E10
        public void GetCommonCacheLocation(){} // RVA: 0x5B95ED0
        public void CreateConstructorCallSite(){} // RVA: 0x5B96900
        public void CreateArgumentCallSites(){} // RVA: 0x5B97250
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x5B976D0
        public void Add(){} // RVA: 0x5B977D0
        public void KeysMatch(){} // RVA: 0x5B978C0
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x5B97980
    }

    public class CallSiteRuntimeResolver
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5B981F0
        public void .ctor(){} // RVA: 0x5B98250
        public void Resolve(){} // RVA: 0x5B98300
        public void VisitDisposeCache(){} // RVA: 0x5B983C0
        public void VisitConstructor(){} // RVA: 0x5B98410
        public void VisitRootCache(){} // RVA: 0x5B98600
        public void VisitScopeCache(){} // RVA: 0x5B988A0
        public void VisitCache(){} // RVA: 0x5B98900
        public void VisitConstant(){} // RVA: 0xA9C3E0
        public void VisitServiceProvider(){} // RVA: 0x5B98D10
        public void VisitIEnumerable(){} // RVA: 0x5B98D20
        public void VisitFactory(){} // RVA: 0x5B98E40
        public void .cctor(){} // RVA: 0x5B98E80
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x5B98FD0
    }

    public class CallSiteValidator
    {
        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x5B98FE0
        public void ValidateResolution(){} // RVA: 0x5B990C0
        public void VisitConstructor(){} // RVA: 0x5B99330
        public void VisitIEnumerable(){} // RVA: 0x5B99330
        public void VisitRootCache(){} // RVA: 0x5B993D0
        public void VisitScopeCache(){} // RVA: 0x5B99460
        public void VisitConstant(){} // RVA: 0x519240
        public void VisitServiceProvider(){} // RVA: 0x519240
        public void VisitFactory(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x5B99750
    }

    public class CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void VisitCallSite(){} // RVA: 0x283FA0
        public void VisitCallSiteMain(){} // RVA: 0x283FA0
        public void VisitNoCache(){} // RVA: 0x283FA0
        public void VisitDisposeCache(){} // RVA: 0x283FA0
        public void VisitRootCache(){} // RVA: 0x283FA0
        public void VisitScopeCache(){} // RVA: 0x283FA0
        public void VisitConstructor(){} // RVA: 0x283FA0
        public void VisitConstant(){} // RVA: 0x283FA0
        public void VisitServiceProvider(){} // RVA: 0x283FA0
        public void VisitIEnumerable(){} // RVA: 0x283FA0
        public void VisitFactory(){} // RVA: 0x283FA0
    }

    public class CompiledServiceProviderEngine
    {
        // ── Methods ──
        public void get_ResolverBuilder(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x5B998B0
        public void RealizeService(){} // RVA: 0x5B99970
    }

    public class ConstantCallSite
    {
        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x5B999A0
        public void get_ServiceType(){} // RVA: 0x35A740
        public void get_ImplementationType(){} // RVA: 0x5B99B90
        public void get_Kind(){} // RVA: 0x37E0C0
    }

    public class ConstructorCallSite
    {
        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x35A740
        public void get_ParameterCallSites(){} // RVA: 0x358730
        public void .ctor(){} // RVA: 0x5B99C60 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x37E0E0
        public void get_ImplementationType(){} // RVA: 0x5B99EF0
        public void get_Kind(){} // RVA: 0x9EAB90
    }

    public class DynamicServiceProviderEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B99F20
        public void RealizeService(){} // RVA: 0x5B9A030
        public void <>n__0(){} // RVA: 0x5B99970
    }

    public class FactoryCallSite
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x5B9A5E0 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x358730
        public void get_ImplementationType(){} // RVA: 0x519240
        public void get_Kind(){} // RVA: 0x59C540
    }

    public class IEnumerableCallSite
    {
        // ── Methods ──
        public void get_ItemType(){} // RVA: 0x35A740
        public void get_ServiceCallSites(){} // RVA: 0x358730
        public void .ctor(){} // RVA: 0x5B9A880
        public void get_ServiceType(){} // RVA: 0x5B9A9A0
        public void get_ImplementationType(){} // RVA: 0x5B9AAF0
        public void get_Kind(){} // RVA: 0x59C540
    }

    public class ILEmitResolverBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B9E360
        public void Build(){} // RVA: 0x5B9E720
        public void BuildType(){} // RVA: 0x5B9E740
        public void BuildTypeNoCache(){} // RVA: 0x5B9E830
        public void VisitDisposeCache(){} // RVA: 0x5B9E9D0
        public void VisitConstructor(){} // RVA: 0x5B9EB20
        public void VisitRootCache(){} // RVA: 0x5B9EDC0
        public void VisitScopeCache(){} // RVA: 0x5B9EF60
        public void VisitConstant(){} // RVA: 0x5B9F0B0
        public void VisitServiceProvider(){} // RVA: 0x5B9F120
        public void VisitIEnumerable(){} // RVA: 0x5B9F1B0
        public void VisitFactory(){} // RVA: 0x5B9F620
        public void AddConstant(){} // RVA: 0x5B9FA20
        public void AddCacheKey(){} // RVA: 0x5B9FD60
        public void GenerateMethodBody(){} // RVA: 0x5B9FF10
        public void BeginCaptureDisposable(){} // RVA: 0x5BA1020
        public void EndCaptureDisposable(){} // RVA: 0x5BA10B0
        public void .cctor(){} // RVA: 0x5BA1190
        public void <.ctor>b__14_0(){} // RVA: 0x5BA1E60
    }

    public class ILEmitResolverBuilderContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Generator(){} // RVA: 0x2F8380
        public void get_Constants(){} // RVA: 0x2E07C0
        public void set_Constants(){} // RVA: 0x343E80
        public void get_Factories(){} // RVA: 0x30B0C0
        public void set_Factories(){} // RVA: 0x30B0D0
    }

    public class ResultCache
    {
        // ── Methods ──
        public void None(){} // RVA: 0x5B9AB20
        public void .ctor(){} // RVA: 0x5B9ACF0 | overloaded x2
        public void get_Location(){} // RVA: 0x19689B0
        public void set_Location(){} // RVA: 0x833580
        public void get_Key(){} // RVA: 0x1F02A60
        public void set_Key(){} // RVA: 0x5B9ADF0
    }

    public class RuntimeResolverContext
    {
        // ── Methods ──
        public void get_Scope(){} // RVA: 0x1AD4690
        public void set_Scope(){} // RVA: 0x100A2F0
        public void get_AcquiredLocks(){} // RVA: 0x1EA9890
        public void set_AcquiredLocks(){} // RVA: 0x1EA98A0
    }

    public class RuntimeServiceProviderEngine
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5B9AE60
        public void .ctor(){} // RVA: 0x2DD310
        public void RealizeService(){} // RVA: 0x5B9AEC0
        public void .cctor(){} // RVA: 0x5B9AFB0
    }

    public class ServiceCacheKey
    {
        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x75E7E0
        public void get_Slot(){} // RVA: 0x32A5C0
        public void .ctor(){} // RVA: 0x37C5A70 | overloaded x2
        public void Equals(){} // RVA: 0x5B9B400 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B9B4A0
    }

    public class ServiceCallSite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x40ACEF0
        public void get_ServiceType(){} // RVA: 0xCD60
        public void get_ImplementationType(){} // RVA: 0xCD60
        public void get_Kind(){} // RVA: 0xD840
        public void get_Cache(){} // RVA: 0x1E79A80
        public void get_Value(){} // RVA: 0x6374D0
        public void set_Value(){} // RVA: 0x30B890
        public void get_Key(){} // RVA: 0x4976A0
        public void set_Key(){} // RVA: 0x49B830
        public void get_CaptureDisposable(){} // RVA: 0x5B9B540
    }

    public class ServiceDescriptorExtensions
    {
        // ── Methods ──
        public void HasImplementationInstance(){} // RVA: 0x5B9B6B0
        public void HasImplementationType(){} // RVA: 0x5B9B6D0
        public void GetImplementationInstance(){} // RVA: 0x5B9B730
        public void GetImplementationType(){} // RVA: 0x25F3A60
        public void TryGetImplementationType(){} // RVA: 0x5B9B750
    }

    public class ServiceIdentifier
    {
        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x1AD4690
        public void get_ServiceType(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x19B3510
        public void FromDescriptor(){} // RVA: 0x5B9B800
        public void FromServiceType(){} // RVA: 0x5B9B840
        public void Equals(){} // RVA: 0x5B9B950 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B9B9F0
        public void get_IsConstructedGenericType(){} // RVA: 0x5B9BA80
        public void GetGenericTypeDefinition(){} // RVA: 0x5B9BAB0
        public void ToString(){} // RVA: 0x5B9BB10
    }

    public class ServiceLookupHelpers
    {
        // ── Methods ──
        public void GetArrayEmptyMethodInfo(){} // RVA: 0x5B9BBD0
        public void .cctor(){} // RVA: 0x5B9BCC0
    }

    public class ServiceProviderCallSite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B9CA90
        public void get_ServiceType(){} // RVA: 0x35A740
        public void get_ImplementationType(){} // RVA: 0x358730
        public void get_Kind(){} // RVA: 0x59C540
    }

    public class ServiceProviderEngine
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ServiceProviderEngineScope
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B9CD50
        public void get_ResolvedServices(){} // RVA: 0x30B0C0
        public void get_Sync(){} // RVA: 0x30B0C0
        public void get_IsRootScope(){} // RVA: 0x6E8A80
        public void get_RootProvider(){} // RVA: 0x6374D0
        public void GetService(){} // RVA: 0x5B9CF00
        public void CaptureDisposable(){} // RVA: 0x5B9D010
        public void Dispose(){} // RVA: 0x5B9D3C0
        public void DisposeAsync(){} // RVA: 0x5B9D550
        public void BeginDispose(){} // RVA: 0x5B9D880
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x5B9DB40
    }

    public class StackGuard
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x3C2850
        public void RunOnEmptyStack(){} // RVA: 0x283FA0
        public void RunOnEmptyStackCore(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowObjectDisposedException(){} // RVA: 0x5B9E310
    }

}