// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 19
// Methods: 151

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537499A0
        public void CheckCircularDependency(){} // RVA: 0x7FFD53749AE0
        public void Remove(){} // RVA: 0x7FFD53749BC0
        public void Add(){} // RVA: 0x7FFD53749C30
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x7FFD53749D70
        public void AppendResolutionPath(){} // RVA: 0x7FFD53749F10
    }

    public class CallSiteFactory : Object
    {
        public object Descriptors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5374A600
        public void get_Descriptors(){} // RVA: 0x7FFD4E35C380
        public void Populate(){} // RVA: 0x7FFD5374AA20
        public void ValidateTrimmingAnnotations(){} // RVA: 0x7FFD5374AFE0
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x7FFD5374B220
        public void AreCompatible(){} // RVA: 0x7FFD4F732F10
        public void GetCallSite(){} // RVA: 0x7FFD5374B730 | overloaded x2
        public void CreateCallSite(){} // RVA: 0x7FFD5374B970
        public void TryCreateExact(){} // RVA: 0x7FFD5374D460 | overloaded x2
        public void TryCreateOpenGeneric(){} // RVA: 0x7FFD5374D9C0 | overloaded x2
        public void TryCreateEnumerable(){} // RVA: 0x7FFD5374C340
        public void GetCommonCacheLocation(){} // RVA: 0x7FFD5374D400
        public void CreateConstructorCallSite(){} // RVA: 0x7FFD5374DE30
        public void CreateArgumentCallSites(){} // RVA: 0x7FFD5374E780
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x7FFD5374EC00
        public void Add(){} // RVA: 0x7FFD5374ED00
        public void KeysMatch(){} // RVA: 0x7FFD5374EDF0
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x7FFD5374EEB0
    }

    public class CallSiteRuntimeResolver : CallSiteVisitor`2
    {
        public object Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD5374F720
        public void .ctor(){} // RVA: 0x7FFD5374F780
        public void Resolve(){} // RVA: 0x7FFD5374F830
        public void VisitDisposeCache(){} // RVA: 0x7FFD5374F8F0
        public void VisitConstructor(){} // RVA: 0x7FFD5374F940
        public void VisitRootCache(){} // RVA: 0x7FFD5374FB30
        public void VisitScopeCache(){} // RVA: 0x7FFD5374FDD0
        public void VisitCache(){} // RVA: 0x7FFD5374FE30
        public void VisitConstant(){} // RVA: 0x7FFD53750240
        public void VisitServiceProvider(){} // RVA: 0x7FFD53750260
        public void VisitIEnumerable(){} // RVA: 0x7FFD53750270
        public void VisitFactory(){} // RVA: 0x7FFD53750390
        public void .cctor(){} // RVA: 0x7FFD537503D0
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x7FFD53750520
    }

    public class CallSiteValidator : CallSiteVisitor`2
    {
        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x7FFD53750530
        public void ValidateResolution(){} // RVA: 0x7FFD53750610
        public void VisitConstructor(){} // RVA: 0x7FFD53750880
        public void VisitIEnumerable(){} // RVA: 0x7FFD53750880
        public void VisitRootCache(){} // RVA: 0x7FFD53750920
        public void VisitScopeCache(){} // RVA: 0x7FFD537509B0
        public void VisitConstant(){} // RVA: 0x7FFD4E919180
        public void VisitServiceProvider(){} // RVA: 0x7FFD4E919180
        public void VisitFactory(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD53750CA0
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void VisitCallSite(){} // RVA: 0x7FFD4E2ADC40
        public void VisitCallSiteMain(){} // RVA: 0x7FFD4E2ADC40
        public void VisitNoCache(){} // RVA: 0x7FFD4E2ADC40
        public void VisitDisposeCache(){} // RVA: 0x7FFD4E2ADC40
        public void VisitRootCache(){} // RVA: 0x7FFD4E2ADC40
        public void VisitScopeCache(){} // RVA: 0x7FFD4E2ADC40
        public void VisitConstructor(){} // RVA: 0x7FFD4E2ADC40
        public void VisitConstant(){} // RVA: 0x7FFD4E2ADC40
        public void VisitServiceProvider(){} // RVA: 0x7FFD4E2ADC40
        public void VisitIEnumerable(){} // RVA: 0x7FFD4E2ADC40
        public void VisitFactory(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ConstantCallSite : ServiceCallSite
    {
        public object DefaultValue;
        public object ServiceType;
        public object ImplementationType;
        public object Kind;

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFD4E5F95E0
        public void .ctor(){} // RVA: 0x7FFD53750EF0
        public void get_ServiceType(){} // RVA: 0x7FFD4E3BE740
        public void get_ImplementationType(){} // RVA: 0x7FFD537510E0
        public void get_Kind(){} // RVA: 0x7FFD4E3E20C0
    }

    public class ConstructorCallSite : ServiceCallSite
    {
        public object ConstructorInfo;
        public object ParameterCallSites;
        public object ServiceType;
        public object ImplementationType;
        public object Kind;

        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x7FFD4E3BE740
        public void get_ParameterCallSites(){} // RVA: 0x7FFD4E3BC730
        public void .ctor(){} // RVA: 0x7FFD537511B0 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFD4E3E20E0
        public void get_ImplementationType(){} // RVA: 0x7FFD53751440
        public void get_Kind(){} // RVA: 0x7FFD4EA4EA40
    }

    public class FactoryCallSite : ServiceCallSite
    {
        public object Factory;
        public object ServiceType;
        public object ImplementationType;
        public object Kind;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD53751B30 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFD4E3BC730
        public void get_ImplementationType(){} // RVA: 0x7FFD4E919180
        public void get_Kind(){} // RVA: 0x7FFD4E5110E0
    }

    public class IEnumerableCallSite : ServiceCallSite
    {
        public object ItemType;
        public object ServiceCallSites;
        public object ServiceType;
        public object ImplementationType;
        public object Kind;

        // ── Methods ──
        public void get_ItemType(){} // RVA: 0x7FFD4E3BE740
        public void get_ServiceCallSites(){} // RVA: 0x7FFD4E3BC730
        public void .ctor(){} // RVA: 0x7FFD53751DD0
        public void get_ServiceType(){} // RVA: 0x7FFD53751EF0
        public void get_ImplementationType(){} // RVA: 0x7FFD53752040
        public void get_Kind(){} // RVA: 0x7FFD4E5110E0
    }

    public class ResultCache : ValueType
    {
        public object Location;
        public object Key;

        // ── Methods ──
        public void None(){} // RVA: 0x7FFD53752070
        public void .ctor(){} // RVA: 0x7FFD53752240 | overloaded x2
        public void get_Location(){} // RVA: 0x7FFD4F840210
        public void set_Location(){} // RVA: 0x7FFD4E78D8B0
        public void get_Key(){} // RVA: 0x7FFD4FE412A0
        public void set_Key(){} // RVA: 0x7FFD53752340
    }

    public class RuntimeResolverContext : ValueType
    {
        public object Scope;
        public object AcquiredLocks;

        // ── Methods ──
        public void get_Scope(){} // RVA: 0x7FFD4EEF9F60
        public void set_Scope(){} // RVA: 0x7FFD4ECFFE40
        public void get_AcquiredLocks(){} // RVA: 0x7FFD4FDE7500
        public void set_AcquiredLocks(){} // RVA: 0x7FFD4FDE7510
    }

    public class RuntimeServiceProviderEngine : ServiceProviderEngine
    {
        public object Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD537523B0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void RealizeService(){} // RVA: 0x7FFD53752410
        public void .cctor(){} // RVA: 0x7FFD53752500
    }

    public class ServiceCacheKey : ValueType
    {
        public object ServiceIdentifier;
        public object Slot;

        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7FFD4E6E0590
        public void get_Slot(){} // RVA: 0x7FFD4E38E5C0
        public void .ctor(){} // RVA: 0x7FFD515112C0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD53752950 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD537529F0
    }

    public class ServiceCallSite : Object
    {
        public object ServiceType;
        public object ImplementationType;
        public object Kind;
        public object Cache;
        public object Value;
        public object Key;
        public object CaptureDisposable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51DE1C80
        public void get_ServiceType(){} // RVA: 0x7FFD4E078E90
        public void get_ImplementationType(){} // RVA: 0x7FFD4E078E90
        public void get_Kind(){} // RVA: 0x7FFD4E079960
        public void get_Cache(){} // RVA: 0x7FFD4FDB7700
        public void get_Value(){} // RVA: 0x7FFD4E5F95E0
        public void set_Value(){} // RVA: 0x7FFD4E36F890
        public void get_Key(){} // RVA: 0x7FFD4E5F0140
        public void set_Key(){} // RVA: 0x7FFD4E5F0C20
        public void get_CaptureDisposable(){} // RVA: 0x7FFD53752A90
    }

    public class ServiceIdentifier : ValueType
    {
        public object ServiceKey;
        public object ServiceType;
        public object IsConstructedGenericType;

        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x7FFD4EEF9F60
        public void get_ServiceType(){} // RVA: 0x7FFD4F840220
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
        public void FromDescriptor(){} // RVA: 0x7FFD53752D50
        public void FromServiceType(){} // RVA: 0x7FFD53752D90
        public void Equals(){} // RVA: 0x7FFD53752EA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53752F40
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFD53752FD0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFD53753000
        public void ToString(){} // RVA: 0x7FFD53753060
    }

    public class ServiceProviderCallSite : ServiceCallSite
    {
        public object ServiceType;
        public object ImplementationType;
        public object Kind;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53753FE0
        public void get_ServiceType(){} // RVA: 0x7FFD4E3BE740
        public void get_ImplementationType(){} // RVA: 0x7FFD4E3BC730
        public void get_Kind(){} // RVA: 0x7FFD4E5110E0
    }

    public class ServiceProviderEngine : Object
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ServiceProviderEngineScope : Object
    {
        public object ResolvedServices;
        public object Sync;
        public object IsRootScope;
        public object RootProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537542A0
        public void get_ResolvedServices(){} // RVA: 0x7FFD4E36F0C0
        public void get_Sync(){} // RVA: 0x7FFD4E36F0C0
        public void get_IsRootScope(){} // RVA: 0x7FFD4E516BA0
        public void get_RootProvider(){} // RVA: 0x7FFD4E5F95E0
        public void GetService(){} // RVA: 0x7FFD53754450
        public void CaptureDisposable(){} // RVA: 0x7FFD53754560
        public void Dispose(){} // RVA: 0x7FFD53754910
        public void DisposeAsync(){} // RVA: 0x7FFD53754AA0
        public void BeginDispose(){} // RVA: 0x7FFD53754DD0
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x7FFD53755090
    }

    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFD4E426850
        public void RunOnEmptyStack(){} // RVA: 0x7FFD4E2ADC40
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}