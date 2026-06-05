// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 30
// Methods: 238

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8642470
        public void CheckCircularDependency(){} // RVA: 0x7FFAF86425B0
        public void Remove(){} // RVA: 0x7FFAF8642690
        public void Add(){} // RVA: 0x7FFAF8642700
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x7FFAF8642840
        public void AppendResolutionPath(){} // RVA: 0x7FFAF86429E0
    }

    public class CallSiteFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86430D0
        public void get_Descriptors(){} // RVA: 0x7FFAF2DA8380
        public void Populate(){} // RVA: 0x7FFAF86434F0
        public void ValidateTrimmingAnnotations(){} // RVA: 0x7FFAF8643AB0
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x7FFAF8643CF0
        public void AreCompatible(){} // RVA: 0x7FFAF433F1C0
        public void GetCallSite(){} // RVA: 0x7FFAF8644200 | overloaded x2
        public void CreateCallSite(){} // RVA: 0x7FFAF8644440
        public void TryCreateExact(){} // RVA: 0x7FFAF8645F30 | overloaded x2
        public void TryCreateOpenGeneric(){} // RVA: 0x7FFAF8646490 | overloaded x2
        public void TryCreateEnumerable(){} // RVA: 0x7FFAF8644E10
        public void GetCommonCacheLocation(){} // RVA: 0x7FFAF8645ED0
        public void CreateConstructorCallSite(){} // RVA: 0x7FFAF8646900
        public void CreateArgumentCallSites(){} // RVA: 0x7FFAF8647250
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x7FFAF86476D0
        public void Add(){} // RVA: 0x7FFAF86477D0
        public void KeysMatch(){} // RVA: 0x7FFAF86478C0
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x7FFAF8647980
    }

    public class CallSiteRuntimeResolver
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF86481F0
        public void .ctor(){} // RVA: 0x7FFAF8648250
        public void Resolve(){} // RVA: 0x7FFAF8648300
        public void VisitDisposeCache(){} // RVA: 0x7FFAF86483C0
        public void VisitConstructor(){} // RVA: 0x7FFAF8648410
        public void VisitRootCache(){} // RVA: 0x7FFAF8648600
        public void VisitScopeCache(){} // RVA: 0x7FFAF86488A0
        public void VisitCache(){} // RVA: 0x7FFAF8648900
        public void VisitConstant(){} // RVA: 0x7FFAF354C3E0
        public void VisitServiceProvider(){} // RVA: 0x7FFAF8648D10
        public void VisitIEnumerable(){} // RVA: 0x7FFAF8648D20
        public void VisitFactory(){} // RVA: 0x7FFAF8648E40
        public void .cctor(){} // RVA: 0x7FFAF8648E80
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x7FFAF8648FD0
    }

    public class CallSiteValidator
    {
        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x7FFAF8648FE0
        public void ValidateResolution(){} // RVA: 0x7FFAF86490C0
        public void VisitConstructor(){} // RVA: 0x7FFAF8649330
        public void VisitIEnumerable(){} // RVA: 0x7FFAF8649330
        public void VisitRootCache(){} // RVA: 0x7FFAF86493D0
        public void VisitScopeCache(){} // RVA: 0x7FFAF8649460
        public void VisitConstant(){} // RVA: 0x7FFAF2FC9240
        public void VisitServiceProvider(){} // RVA: 0x7FFAF2FC9240
        public void VisitFactory(){} // RVA: 0x7FFAF2FC9240
        public void .ctor(){} // RVA: 0x7FFAF8649750
    }

    public class CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void VisitCallSite(){} // RVA: 0x7FFAF2D33FA0
        public void VisitCallSiteMain(){} // RVA: 0x7FFAF2D33FA0
        public void VisitNoCache(){} // RVA: 0x7FFAF2D33FA0
        public void VisitDisposeCache(){} // RVA: 0x7FFAF2D33FA0
        public void VisitRootCache(){} // RVA: 0x7FFAF2D33FA0
        public void VisitScopeCache(){} // RVA: 0x7FFAF2D33FA0
        public void VisitConstructor(){} // RVA: 0x7FFAF2D33FA0
        public void VisitConstant(){} // RVA: 0x7FFAF2D33FA0
        public void VisitServiceProvider(){} // RVA: 0x7FFAF2D33FA0
        public void VisitIEnumerable(){} // RVA: 0x7FFAF2D33FA0
        public void VisitFactory(){} // RVA: 0x7FFAF2D33FA0
    }

    public class CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF81FF610
        public void VisitCallSite(){} // RVA: 0x7FFAF81FDFC0
        public void VisitCallSiteMain(){} // RVA: 0x7FFAF81FF6A0
        public void VisitNoCache(){} // RVA: 0x7FFAF81FE330
        public void VisitDisposeCache(){} // RVA: 0x7FFAF81FE330
        public void VisitRootCache(){} // RVA: 0x7FFAF81FE330
        public void VisitScopeCache(){} // RVA: 0x7FFAF81FE330
        public void VisitConstructor(){}
        public void VisitConstant(){}
        public void VisitServiceProvider(){}
        public void VisitIEnumerable(){}
        public void VisitFactory(){}
    }

    public class CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF81FE350
        public void VisitCallSite(){} // RVA: 0x7FFAF81FE3E0
        public void VisitCallSiteMain(){} // RVA: 0x7FFAF81FE510
        public void VisitNoCache(){} // RVA: 0x7FFAF81FE7C0
        public void VisitDisposeCache(){} // RVA: 0x7FFAF81FE7C0
        public void VisitRootCache(){} // RVA: 0x7FFAF81FE7C0
        public void VisitScopeCache(){} // RVA: 0x7FFAF81FE7C0
        public void VisitConstructor(){}
        public void VisitConstant(){}
        public void VisitServiceProvider(){}
        public void VisitIEnumerable(){}
        public void VisitFactory(){}
    }

    public class CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF81FF0F0
        public void VisitCallSite(){} // RVA: 0x7FFAF81FF180
        public void VisitCallSiteMain(){} // RVA: 0x7FFAF81FF2E0
        public void VisitNoCache(){} // RVA: 0x7FFAF81FF5D0
        public void VisitDisposeCache(){} // RVA: 0x7FFAF81FF5D0
        public void VisitRootCache(){} // RVA: 0x7FFAF81FF5D0
        public void VisitScopeCache(){} // RVA: 0x7FFAF81FF5D0
        public void VisitConstructor(){}
        public void VisitConstant(){}
        public void VisitServiceProvider(){}
        public void VisitIEnumerable(){}
        public void VisitFactory(){}
    }

    public class CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF81FDF30
        public void VisitCallSite(){} // RVA: 0x7FFAF81FDFC0
        public void VisitCallSiteMain(){} // RVA: 0x7FFAF81FE0B0
        public void VisitNoCache(){} // RVA: 0x7FFAF81FE330
        public void VisitDisposeCache(){} // RVA: 0x7FFAF81FE330
        public void VisitRootCache(){} // RVA: 0x7FFAF81FE330
        public void VisitScopeCache(){} // RVA: 0x7FFAF81FE330
        public void VisitConstructor(){} // RVA: 0x7FFAF2ACE6A0
        public void VisitConstant(){} // RVA: 0x7FFAF2ACE6A0
        public void VisitServiceProvider(){} // RVA: 0x7FFAF2ACE6A0
        public void VisitIEnumerable(){} // RVA: 0x7FFAF2ACE6A0
        public void VisitFactory(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class CompiledServiceProviderEngine
    {
        // ── Methods ──
        public void get_ResolverBuilder(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF86498B0
        public void RealizeService(){} // RVA: 0x7FFAF8649970
    }

    public class ConstantCallSite
    {
        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF86499A0
        public void get_ServiceType(){} // RVA: 0x7FFAF2E0A740
        public void get_ImplementationType(){} // RVA: 0x7FFAF8649B90
        public void get_Kind(){} // RVA: 0x7FFAF2E2E0C0
    }

    public class ConstructorCallSite
    {
        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x7FFAF2E0A740
        public void get_ParameterCallSites(){} // RVA: 0x7FFAF2E08730
        public void .ctor(){} // RVA: 0x7FFAF8649C60 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFAF2E2E0E0
        public void get_ImplementationType(){} // RVA: 0x7FFAF8649EF0
        public void get_Kind(){} // RVA: 0x7FFAF349AB90
    }

    public class DynamicServiceProviderEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8649F20
        public void RealizeService(){} // RVA: 0x7FFAF864A030
        public void <>n__0(){} // RVA: 0x7FFAF8649970
    }

    public class FactoryCallSite
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7FFAF2E0A740
        public void .ctor(){} // RVA: 0x7FFAF864A5E0 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFAF2E08730
        public void get_ImplementationType(){} // RVA: 0x7FFAF2FC9240
        public void get_Kind(){} // RVA: 0x7FFAF304C540
    }

    public class IEnumerableCallSite
    {
        // ── Methods ──
        public void get_ItemType(){} // RVA: 0x7FFAF2E0A740
        public void get_ServiceCallSites(){} // RVA: 0x7FFAF2E08730
        public void .ctor(){} // RVA: 0x7FFAF864A880
        public void get_ServiceType(){} // RVA: 0x7FFAF864A9A0
        public void get_ImplementationType(){} // RVA: 0x7FFAF864AAF0
        public void get_Kind(){} // RVA: 0x7FFAF304C540
    }

    public class ILEmitResolverBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF864E360
        public void Build(){} // RVA: 0x7FFAF864E720
        public void BuildType(){} // RVA: 0x7FFAF864E740
        public void BuildTypeNoCache(){} // RVA: 0x7FFAF864E830
        public void VisitDisposeCache(){} // RVA: 0x7FFAF864E9D0
        public void VisitConstructor(){} // RVA: 0x7FFAF864EB20
        public void VisitRootCache(){} // RVA: 0x7FFAF864EDC0
        public void VisitScopeCache(){} // RVA: 0x7FFAF864EF60
        public void VisitConstant(){} // RVA: 0x7FFAF864F0B0
        public void VisitServiceProvider(){} // RVA: 0x7FFAF864F120
        public void VisitIEnumerable(){} // RVA: 0x7FFAF864F1B0
        public void VisitFactory(){} // RVA: 0x7FFAF864F620
        public void AddConstant(){} // RVA: 0x7FFAF864FA20
        public void AddCacheKey(){} // RVA: 0x7FFAF864FD60
        public void GenerateMethodBody(){} // RVA: 0x7FFAF864FF10
        public void BeginCaptureDisposable(){} // RVA: 0x7FFAF8651020
        public void EndCaptureDisposable(){} // RVA: 0x7FFAF86510B0
        public void .cctor(){} // RVA: 0x7FFAF8651190
        public void <.ctor>b__14_0(){} // RVA: 0x7FFAF8651E60
    }

    public class ILEmitResolverBuilderContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Generator(){} // RVA: 0x7FFAF2DA8380
        public void get_Constants(){} // RVA: 0x7FFAF2D907C0
        public void set_Constants(){} // RVA: 0x7FFAF2DF3E80
        public void get_Factories(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Factories(){} // RVA: 0x7FFAF2DBB0D0
    }

    public class ResultCache
    {
        // ── Methods ──
        public void None(){} // RVA: 0x7FFAF864AB20
        public void .ctor(){} // RVA: 0x7FFAF864ACF0 | overloaded x2
        public void get_Location(){} // RVA: 0x7FFAF44189B0
        public void set_Location(){} // RVA: 0x7FFAF32E3580
        public void get_Key(){} // RVA: 0x7FFAF49B2A60
        public void set_Key(){} // RVA: 0x7FFAF864ADF0
    }

    public class RuntimeResolverContext
    {
        // ── Methods ──
        public void get_Scope(){} // RVA: 0x7FFAF4584690
        public void set_Scope(){} // RVA: 0x7FFAF3ABA2F0
        public void get_AcquiredLocks(){} // RVA: 0x7FFAF4959890
        public void set_AcquiredLocks(){} // RVA: 0x7FFAF49598A0
    }

    public class RuntimeServiceProviderEngine
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF864AE60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void RealizeService(){} // RVA: 0x7FFAF864AEC0
        public void .cctor(){} // RVA: 0x7FFAF864AFB0
    }

    public class ServiceCacheKey
    {
        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7FFAF320E7E0
        public void get_Slot(){} // RVA: 0x7FFAF2DDA5C0
        public void .ctor(){} // RVA: 0x7FFAF6275A70 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF864B400 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF864B4A0
    }

    public class ServiceCallSite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B5CEF0
        public void get_ServiceType(){} // RVA: 0x7FFAF2ABCD60
        public void get_ImplementationType(){} // RVA: 0x7FFAF2ABCD60
        public void get_Kind(){} // RVA: 0x7FFAF2ABD840
        public void get_Cache(){} // RVA: 0x7FFAF4929A80
        public void get_Value(){} // RVA: 0x7FFAF30E74D0
        public void set_Value(){} // RVA: 0x7FFAF2DBB890
        public void get_Key(){} // RVA: 0x7FFAF2F476A0
        public void set_Key(){} // RVA: 0x7FFAF2F4B830
        public void get_CaptureDisposable(){} // RVA: 0x7FFAF864B540
    }

    public class ServiceDescriptorExtensions
    {
        // ── Methods ──
        public void HasImplementationInstance(){} // RVA: 0x7FFAF864B6B0
        public void HasImplementationType(){} // RVA: 0x7FFAF864B6D0
        public void GetImplementationInstance(){} // RVA: 0x7FFAF864B730
        public void GetImplementationType(){} // RVA: 0x7FFAF50A3A60
        public void TryGetImplementationType(){} // RVA: 0x7FFAF864B750
    }

    public class ServiceIdentifier
    {
        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x7FFAF4584690
        public void get_ServiceType(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void FromDescriptor(){} // RVA: 0x7FFAF864B800
        public void FromServiceType(){} // RVA: 0x7FFAF864B840
        public void Equals(){} // RVA: 0x7FFAF864B950 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF864B9F0
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAF864BA80
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAF864BAB0
        public void ToString(){} // RVA: 0x7FFAF864BB10
    }

    public class ServiceLookupHelpers
    {
        // ── Methods ──
        public void GetArrayEmptyMethodInfo(){} // RVA: 0x7FFAF864BBD0
        public void .cctor(){} // RVA: 0x7FFAF864BCC0
    }

    public class ServiceProviderCallSite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF864CA90
        public void get_ServiceType(){} // RVA: 0x7FFAF2E0A740
        public void get_ImplementationType(){} // RVA: 0x7FFAF2E08730
        public void get_Kind(){} // RVA: 0x7FFAF304C540
    }

    public class ServiceProviderEngine
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ServiceProviderEngineScope
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF864CD50
        public void get_ResolvedServices(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Sync(){} // RVA: 0x7FFAF2DBB0C0
        public void get_IsRootScope(){} // RVA: 0x7FFAF3198A80
        public void get_RootProvider(){} // RVA: 0x7FFAF30E74D0
        public void GetService(){} // RVA: 0x7FFAF864CF00
        public void CaptureDisposable(){} // RVA: 0x7FFAF864D010
        public void Dispose(){} // RVA: 0x7FFAF864D3C0
        public void DisposeAsync(){} // RVA: 0x7FFAF864D550
        public void BeginDispose(){} // RVA: 0x7FFAF864D880
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x7FFAF864DB40
    }

    public class StackGuard
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFAF2E72850
        public void RunOnEmptyStack(){} // RVA: 0x7FFAF2D33FA0
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFAF864E310
    }

}