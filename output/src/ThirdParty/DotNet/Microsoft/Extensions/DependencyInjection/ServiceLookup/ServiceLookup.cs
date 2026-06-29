// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 31
// Methods: 244

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain : Object
    {
        public object _callSiteChain;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x660BB90
        public void CheckCircularDependency(){} // RVA: 0x660BCD0
        public void Remove(){} // RVA: 0x660BDB0
        public void Add(){} // RVA: 0x660BE20
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x660BF40
        public void AppendResolutionPath(){} // RVA: 0x660C0E0
    }

    public class CallSiteFactory : Object
    {
        public object _descriptors;
        public object _callSiteCache;
        public object _descriptorLookup;
        public object _callSiteLocks;
        public object _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x660C7C0
        public void get_Descriptors(){} // RVA: 0xB5DBF0
        public void Populate(){} // RVA: 0x660CBE0
        public void ValidateTrimmingAnnotations(){} // RVA: 0x660D1C0
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x660D410
        public void AreCompatible(){} // RVA: 0x2154E40
        public void GetCallSite(){} // RVA: 0x660D910
        public void CreateCallSite(){} // RVA: 0x660DB70
        public void TryCreateExact(){} // RVA: 0x660F640
        public void TryCreateOpenGeneric(){} // RVA: 0x660FB80
        public void TryCreateEnumerable(){} // RVA: 0x660E530
        public void GetCommonCacheLocation(){} // RVA: 0x660F5E0
        public void CreateConstructorCallSite(){} // RVA: 0x660FFD0
        public void CreateArgumentCallSites(){} // RVA: 0x6610910
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x6610D90
        public void Add(){} // RVA: 0x6610EA0
        public void KeysMatch(){} // RVA: 0x6610F90
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x6611050
    }

    public class CallSiteRuntimeResolver : CallSiteVisitor`2
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x66118E0
        public void .ctor(){} // RVA: 0x6611940
        public void Resolve(){} // RVA: 0x66119F0
        public void VisitDisposeCache(){} // RVA: 0x6611AB0
        public void VisitConstructor(){} // RVA: 0x6611B00
        public void VisitRootCache(){} // RVA: 0x6611D10
        public void VisitScopeCache(){} // RVA: 0x6611F90
        public void VisitCache(){} // RVA: 0x6611FF0
        public void VisitConstant(){} // RVA: 0x13874F0
        public void VisitServiceProvider(){} // RVA: 0x66123F0
        public void VisitIEnumerable(){} // RVA: 0x6612400
        public void VisitFactory(){} // RVA: 0x6612520
        public void .cctor(){} // RVA: 0x6612560
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x66126B0
    }

    public class CallSiteValidator : CallSiteVisitor`2
    {
        public object _scopedServices;

        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x66126C0
        public void ValidateResolution(){} // RVA: 0x6612790
        public void VisitConstructor(){} // RVA: 0x66129F0
        public void VisitIEnumerable(){} // RVA: 0x66129F0
        public void VisitRootCache(){} // RVA: 0x6612A90
        public void VisitScopeCache(){} // RVA: 0x6612B20
        public void VisitConstant(){} // RVA: 0xDAC980
        public void VisitServiceProvider(){} // RVA: 0xDAC980
        public void VisitFactory(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0x6612DE0
    }

    public class CallSiteVisitor`2 : Object
    {
        public object _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void VisitCallSite(){} // RVA: 0xA94080
        public void VisitCallSiteMain(){} // RVA: 0xA94080
        public void VisitNoCache(){} // RVA: 0xA94080
        public void VisitDisposeCache(){} // RVA: 0xA94080
        public void VisitRootCache(){} // RVA: 0xA94080
        public void VisitScopeCache(){} // RVA: 0xA94080
        public void VisitConstructor(){} // RVA: 0xA94080
        public void VisitConstant(){} // RVA: 0xA94080
        public void VisitServiceProvider(){} // RVA: 0xA94080
        public void VisitIEnumerable(){} // RVA: 0xA94080
        public void VisitFactory(){} // RVA: 0xA94080
    }

    public class CallSiteVisitor`2 : Object
    {
        public object _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x627C4D0
        public void VisitCallSite(){} // RVA: 0x627AEC0
        public void VisitCallSiteMain(){} // RVA: 0x627C560
        public void VisitNoCache(){} // RVA: 0x627B230
        public void VisitDisposeCache(){} // RVA: 0x627B230
        public void VisitRootCache(){} // RVA: 0x627B230
        public void VisitScopeCache(){} // RVA: 0x627B230
        public void VisitConstructor(){} // RVA: 0x881FC0
        public void VisitConstant(){} // RVA: 0x881FC0
        public void VisitServiceProvider(){} // RVA: 0x881FC0
        public void VisitIEnumerable(){} // RVA: 0x881FC0
        public void VisitFactory(){} // RVA: 0x881FC0
    }

    public class CallSiteVisitor`2 : Object
    {
        public object _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x627B250
        public void VisitCallSite(){} // RVA: 0x627B2E0
        public void VisitCallSiteMain(){} // RVA: 0x627B410
        public void VisitNoCache(){} // RVA: 0x627B6C0
        public void VisitDisposeCache(){} // RVA: 0x627B6C0
        public void VisitRootCache(){} // RVA: 0x627B6C0
        public void VisitScopeCache(){} // RVA: 0x627B6C0
        public void VisitConstructor(){} // RVA: 0x87C5F0
        public void VisitConstant(){} // RVA: 0x87C5F0
        public void VisitServiceProvider(){} // RVA: 0x87C5F0
        public void VisitIEnumerable(){} // RVA: 0x87C5F0
        public void VisitFactory(){} // RVA: 0x87C5F0
    }

    public class CallSiteVisitor`2 : Object
    {
        public object _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x627BFB0
        public void VisitCallSite(){} // RVA: 0x627C040
        public void VisitCallSiteMain(){} // RVA: 0x627C1A0
        public void VisitNoCache(){} // RVA: 0x627C490
        public void VisitDisposeCache(){} // RVA: 0x627C490
        public void VisitRootCache(){} // RVA: 0x627C490
        public void VisitScopeCache(){} // RVA: 0x627C490
        public void VisitConstructor(){} // RVA: 0x87C5F0
        public void VisitConstant(){} // RVA: 0x87C5F0
        public void VisitServiceProvider(){} // RVA: 0x87C5F0
        public void VisitIEnumerable(){} // RVA: 0x87C5F0
        public void VisitFactory(){} // RVA: 0x87C5F0
    }

    public class CallSiteVisitor`2 : Object
    {
        public object _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x627AE30
        public void VisitCallSite(){} // RVA: 0x627AEC0
        public void VisitCallSiteMain(){} // RVA: 0x627AFB0
        public void VisitNoCache(){} // RVA: 0x627B230
        public void VisitDisposeCache(){} // RVA: 0x627B230
        public void VisitRootCache(){} // RVA: 0x627B230
        public void VisitScopeCache(){} // RVA: 0x627B230
        public void VisitConstructor(){} // RVA: 0x87C5F0
        public void VisitConstant(){} // RVA: 0x87C5F0
        public void VisitServiceProvider(){} // RVA: 0x87C5F0
        public void VisitIEnumerable(){} // RVA: 0x87C5F0
        public void VisitFactory(){} // RVA: 0x87C5F0
    }

    public class CompiledServiceProviderEngine : ServiceProviderEngine
    {
        public object _resolverBuilder;

        // ── Methods ──
        public void get_ResolverBuilder(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x6612F40
        public void RealizeService(){} // RVA: 0x6613000
    }

    public class ConstantCallSite : ServiceCallSite
    {
        public object _serviceType;
        public object _kind;

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x6613030
        public void get_ServiceType(){} // RVA: 0xBC1B30
        public void get_ImplementationType(){} // RVA: 0x6613220
        public void get_Kind(){} // RVA: 0xBE5890
    }

    public class ConstructorCallSite : ServiceCallSite
    {
        public object _constructorInfo;
        public object _parameterCallSites;
        public object _serviceType;
        public object _kind;

        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0xBC1B30
        public void get_ParameterCallSites(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0x66132F0
        public void get_ServiceType(){} // RVA: 0xBE58B0
        public void get_ImplementationType(){} // RVA: 0x6613580
        public void get_Kind(){} // RVA: 0x12BB630
    }

    public class DynamicServiceProviderEngine : CompiledServiceProviderEngine
    {
        public object _serviceProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66135B0
        public void RealizeService(){} // RVA: 0x66136C0
        public void <>n__0(){} // RVA: 0x6613000
    }

    public class FactoryCallSite : ServiceCallSite
    {
        public object _factory;
        public object _serviceType;
        public object _kind;

        // ── Methods ──
        public void get_Factory(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0x6613C70
        public void get_ServiceType(){} // RVA: 0xBBF8F0
        public void get_ImplementationType(){} // RVA: 0xDAC980
        public void get_Kind(){} // RVA: 0xE32C80
    }

    public class IEnumerableCallSite : ServiceCallSite
    {
        public object _itemType;
        public object _serviceCallSites;
        public object _kind;

        // ── Methods ──
        public void get_ItemType(){} // RVA: 0xBC1B30
        public void get_ServiceCallSites(){} // RVA: 0xBBF8F0
        public void .ctor(){} // RVA: 0x6613F10
        public void get_ServiceType(){} // RVA: 0x6614030
        public void get_ImplementationType(){} // RVA: 0x6614160
        public void get_Kind(){} // RVA: 0xE32C80
    }

    public class ILEmitResolverBuilder : CallSiteVisitor`2
    {
        public object ResolvedServicesGetter;
        public object ScopeLockGetter;
        public object ScopeIsRootScope;
        public object CallSiteRuntimeResolverResolveMethod;
        public object CallSiteRuntimeResolverInstanceField;
        public object FactoriesField;
        public object ConstantsField;
        public object GetTypeFromHandleMethod;
        public object CacheKeyCtor;
        public object _rootScope;
        public object _scopeResolverCache;
        public object _buildTypeDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6617730
        public void Build(){} // RVA: 0x6617AE0
        public void BuildType(){} // RVA: 0x6617B00
        public void BuildTypeNoCache(){} // RVA: 0x6617BF0
        public void VisitDisposeCache(){} // RVA: 0x6617D80
        public void VisitConstructor(){} // RVA: 0x6617ED0
        public void VisitRootCache(){} // RVA: 0x6618180
        public void VisitScopeCache(){} // RVA: 0x6618320
        public void VisitConstant(){} // RVA: 0x6618470
        public void VisitServiceProvider(){} // RVA: 0x66184E0
        public void VisitIEnumerable(){} // RVA: 0x6618570
        public void VisitFactory(){} // RVA: 0x66189F0
        public void AddConstant(){} // RVA: 0x6618DC0
        public void AddCacheKey(){} // RVA: 0x66190D0
        public void GenerateMethodBody(){} // RVA: 0x6619280
        public void BeginCaptureDisposable(){} // RVA: 0x661A430
        public void EndCaptureDisposable(){} // RVA: 0x661A4C0
        public void .cctor(){} // RVA: 0x661A5A0
        public void <.ctor>b__14_0(){} // RVA: 0x661B130
    }

    public class ILEmitResolverBuilderContext : Object
    {
        public object _generator;
        public object _constants;
        public object _factories;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Generator(){} // RVA: 0xB5DBF0
        public void get_Constants(){} // RVA: 0xB465B0
        public void set_Constants(){} // RVA: 0xBA9BA0
        public void get_Factories(){} // RVA: 0xB700F0
        public void set_Factories(){} // RVA: 0xB70100
    }

    public class ResultCache : ValueType
    {
        public object _location;
        public object _key;

        // ── Methods ──
        public void None(){} // RVA: 0x6614190
        public void .ctor(){} // RVA: 0x8A89F0
        public void get_Location(){} // RVA: 0x77E60
        public void set_Location(){} // RVA: 0x29580
        public void get_Key(){} // RVA: 0xA3220
        public void set_Key(){} // RVA: 0x8A8A20
    }

    public class RuntimeResolverContext : ValueType
    {
        public object _scope;
        public object _acquiredLocks;

        // ── Methods ──
        public void get_Scope(){} // RVA: 0x77900
        public void set_Scope(){} // RVA: 0x47F10
        public void get_AcquiredLocks(){} // RVA: 0x14790
        public void set_AcquiredLocks(){} // RVA: 0x92DD0
    }

    public class RuntimeServiceProviderEngine : ServiceProviderEngine
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x66144D0
        public void .ctor(){} // RVA: 0xB43310
        public void RealizeService(){} // RVA: 0x6614530
        public void .cctor(){} // RVA: 0x6614620
    }

    public class ServiceCacheKey : ValueType
    {
        public object _serviceIdentifier;
        public object _slot;

        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7BF80
        public void get_Slot(){} // RVA: 0x8C7E0
        public void .ctor(){} // RVA: 0x35DD20
        public void Equals(){} // RVA: 0x8A8CA0
        public void GetHashCode(){} // RVA: 0x8A8CB0
    }

    public class ServiceCallSite : Object
    {
        public object _cache;
        public object _value;
        public object _key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B70E30
        public void get_ServiceType(){} // RVA: 0x87C0A0
        public void get_ImplementationType(){} // RVA: 0x87C0A0
        public void get_Kind(){} // RVA: 0x87C130
        public void get_Cache(){} // RVA: 0x26FAD00
        public void get_Value(){} // RVA: 0xD33E60
        public void set_Value(){} // RVA: 0xB708C0
        public void get_Key(){} // RVA: 0xD05CA0
        public void set_Key(){} // RVA: 0xD09D70
        public void get_CaptureDisposable(){} // RVA: 0x6614B80
    }

    public class ServiceCallSite[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ServiceDescriptorExtensions : Object
    {
        // ── Methods ──
        public void HasImplementationInstance(){} // RVA: 0x6614D40
        public void HasImplementationType(){} // RVA: 0x6614D60
        public void GetImplementationInstance(){} // RVA: 0x6614DA0
        public void GetImplementationType(){} // RVA: 0x3024670
        public void TryGetImplementationType(){} // RVA: 0x6614DC0
    }

    public class ServiceIdentifier : ValueType
    {
        public object _serviceKey;
        public object _serviceType;

        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x77900
        public void get_ServiceType(){} // RVA: 0x77ED0
        public void .ctor(){} // RVA: 0x76310
        public void FromDescriptor(){} // RVA: 0x6614E50
        public void FromServiceType(){} // RVA: 0x6614E90
        public void Equals(){} // RVA: 0x8A8DA0
        public void GetHashCode(){} // RVA: 0x8A8DB0
        public void get_IsConstructedGenericType(){} // RVA: 0x8A8DC0
        public void GetGenericTypeDefinition(){} // RVA: 0x8A8DF0
        public void ToString(){} // RVA: 0x8A8F00
    }

    public class ServiceLookupHelpers : Object
    {
        public object ArrayEmptyMethodInfo;
        public object InvokeFactoryMethodInfo;
        public object CaptureDisposableMethodInfo;
        public object TryGetValueMethodInfo;
        public object ResolveCallSiteAndScopeMethodInfo;
        public object AddMethodInfo;
        public object MonitorEnterMethodInfo;
        public object MonitorExitMethodInfo;

        // ── Methods ──
        public void GetArrayEmptyMethodInfo(){} // RVA: 0x6615200
        public void .cctor(){} // RVA: 0x66152F0
    }

    public class ServiceProviderCallSite : ServiceCallSite
    {
        public object _serviceType;
        public object _implementationType;
        public object _kind;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6615F30
        public void get_ServiceType(){} // RVA: 0xBC1B30
        public void get_ImplementationType(){} // RVA: 0xBBF8F0
        public void get_Kind(){} // RVA: 0xE32C80
    }

    public class ServiceProviderEngine : Object
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ServiceProviderEngineScope : Object
    {
        public object _disposed;
        public object _disposables;
        public object _resolvedServices;
        public object _isRootScope;
        public object _rootProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6616180
        public void get_ResolvedServices(){} // RVA: 0xB700F0
        public void get_Sync(){} // RVA: 0xB700F0
        public void get_IsRootScope(){} // RVA: 0xF73960
        public void get_RootProvider(){} // RVA: 0xD33E60
        public void GetService(){} // RVA: 0x6616330
        public void CaptureDisposable(){} // RVA: 0x6616440
        public void Dispose(){} // RVA: 0x66167B0
        public void DisposeAsync(){} // RVA: 0x6616960
        public void BeginDispose(){} // RVA: 0x6616C90
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x6616F00
    }

    public class StackGuard : Object
    {
        public object _executionStackCount;

        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0xC2E4C0
        public void RunOnEmptyStack(){} // RVA: 0x29C35E0
        public void RunOnEmptyStackCore(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowObjectDisposedException(){} // RVA: 0x66176E0
    }

}