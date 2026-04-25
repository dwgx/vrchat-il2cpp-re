// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 26
// Methods: 190

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain : Object
    {
        public System.Collections.Generic.Dictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ChainItemInfo> _callSiteChain; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83299A0
        public void CheckCircularDependency(){} // RVA: 0x7FFAC8329AE0
        public void Remove(){} // RVA: 0x7FFAC8329BC0
        public void Add(){} // RVA: 0x7FFAC8329C30
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x7FFAC8329D70
        public void AppendResolutionPath(){} // RVA: 0x7FFAC8329F10
    }

    public class CallSiteFactory : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceDescriptor[] Descriptors; // 0x10
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite> _callSiteCache; // 0x18
        public System.Collections.Generic.Dictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceDescriptorCacheItem> _descriptorLookup; // 0x20
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,object> _callSiteLocks; // 0x28
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.StackGuard _stackGuard; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC832A600
        public void get_Descriptors(){} // RVA: 0x7FFAC2F3C380
        public void Populate(){} // RVA: 0x7FFAC832AA20
        public void ValidateTrimmingAnnotations(){} // RVA: 0x7FFAC832AFE0
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x7FFAC832B220
        public void AreCompatible(){} // RVA: 0x7FFAC4312F10
        public void GetCallSite(){} // RVA: 0x7FFAC832B730 | overloaded x2
        public void CreateCallSite(){} // RVA: 0x7FFAC832B970
        public void TryCreateExact(){} // RVA: 0x7FFAC832D460 | overloaded x2
        public void TryCreateOpenGeneric(){} // RVA: 0x7FFAC832D9C0 | overloaded x2
        public void TryCreateEnumerable(){} // RVA: 0x7FFAC832C340
        public void GetCommonCacheLocation(){} // RVA: 0x7FFAC832D400
        public void CreateConstructorCallSite(){} // RVA: 0x7FFAC832DE30
        public void CreateArgumentCallSites(){} // RVA: 0x7FFAC832E780
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x7FFAC832EC00
        public void Add(){} // RVA: 0x7FFAC832ED00
        public void KeysMatch(){} // RVA: 0x7FFAC832EDF0
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x7FFAC832EEB0
    }

    public class CallSiteRuntimeResolver : CallSiteVisitor`2
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC832F720
        public void .ctor(){} // RVA: 0x7FFAC832F780
        public void Resolve(){} // RVA: 0x7FFAC832F830
        public void VisitDisposeCache(){} // RVA: 0x7FFAC832F8F0
        public void VisitConstructor(){} // RVA: 0x7FFAC832F940
        public void VisitRootCache(){} // RVA: 0x7FFAC832FB30
        public void VisitScopeCache(){} // RVA: 0x7FFAC832FDD0
        public void VisitCache(){} // RVA: 0x7FFAC832FE30
        public void VisitConstant(){} // RVA: 0x7FFAC8330240
        public void VisitServiceProvider(){} // RVA: 0x7FFAC8330260
        public void VisitIEnumerable(){} // RVA: 0x7FFAC8330270
        public void VisitFactory(){} // RVA: 0x7FFAC8330390
        public void .cctor(){} // RVA: 0x7FFAC83303D0
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x7FFAC8330520
    }

    public class CallSiteValidator : CallSiteVisitor`2
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,System.Type> _scopedServices; // 0x18

        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x7FFAC8330530
        public void ValidateResolution(){} // RVA: 0x7FFAC8330610
        public void VisitConstructor(){} // RVA: 0x7FFAC8330880
        public void VisitIEnumerable(){} // RVA: 0x7FFAC8330880
        public void VisitRootCache(){} // RVA: 0x7FFAC8330920
        public void VisitScopeCache(){} // RVA: 0x7FFAC83309B0
        public void VisitConstant(){} // RVA: 0x7FFAC34F9180
        public void VisitServiceProvider(){} // RVA: 0x7FFAC34F9180
        public void VisitFactory(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC8330CA0
    }

    public class CallSiteVisitor`2 : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.StackGuard _stackGuard;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void VisitCallSite(){} // RVA: 0x7FFAC2E8DC40
        public void VisitCallSiteMain(){} // RVA: 0x7FFAC2E8DC40
        public void VisitNoCache(){} // RVA: 0x7FFAC2E8DC40
        public void VisitDisposeCache(){} // RVA: 0x7FFAC2E8DC40
        public void VisitRootCache(){} // RVA: 0x7FFAC2E8DC40
        public void VisitScopeCache(){} // RVA: 0x7FFAC2E8DC40
        public void VisitConstructor(){} // RVA: 0x7FFAC2E8DC40
        public void VisitConstant(){} // RVA: 0x7FFAC2E8DC40
        public void VisitServiceProvider(){} // RVA: 0x7FFAC2E8DC40
        public void VisitIEnumerable(){} // RVA: 0x7FFAC2E8DC40
        public void VisitFactory(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CompiledServiceProviderEngine : ServiceProviderEngine
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ILEmitResolverBuilder ResolverBuilder; // 0x10

        // ── Methods ──
        public void get_ResolverBuilder(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC8330E00
        public void RealizeService(){} // RVA: 0x7FFAC8330EC0
    }

    public class ConstantCallSite : ServiceCallSite
    {
        public System.Type DefaultValue; // 0x40
        public 0x6B2B0498 ServiceType; // 0x48

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC8330EF0
        public void get_ServiceType(){} // RVA: 0x7FFAC2F9E740
        public void get_ImplementationType(){} // RVA: 0x7FFAC83310E0
        public void get_Kind(){} // RVA: 0x7FFAC2FC20C0
    }

    public class ConstructorCallSite : ServiceCallSite
    {
        public System.Reflection.ConstructorInfo ConstructorInfo; // 0x40
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite[] ParameterCallSites; // 0x48
        public System.Type ServiceType; // 0x50
        public 0x6B2B0498 ImplementationType; // 0x58

        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x7FFAC2F9E740
        public void get_ParameterCallSites(){} // RVA: 0x7FFAC2F9C730
        public void .ctor(){} // RVA: 0x7FFAC83311B0 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFAC2FC20E0
        public void get_ImplementationType(){} // RVA: 0x7FFAC8331440
        public void get_Kind(){} // RVA: 0x7FFAC362EA40
    }

    public class DynamicServiceProviderEngine : CompiledServiceProviderEngine
    {
        public Microsoft.Extensions.DependencyInjection.ServiceProvider _serviceProvider; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8331470
        public void RealizeService(){} // RVA: 0x7FFAC8331580
        public void <>n__0(){} // RVA: 0x7FFAC8330EC0
    }

    public class FactoryCallSite : ServiceCallSite
    {
        public System.Func`2<System.IServiceProvider,object> Factory; // 0x40
        public System.Type ServiceType; // 0x48
        public 0x6B2B0498 ImplementationType; // 0x50

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC8331B30 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFAC2F9C730
        public void get_ImplementationType(){} // RVA: 0x7FFAC34F9180
        public void get_Kind(){} // RVA: 0x7FFAC30F10E0
    }

    public class IEnumerableCallSite : ServiceCallSite
    {
        public System.Type ItemType; // 0x40
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite[] ServiceCallSites; // 0x48
        public 0x6B2B0498 ServiceType; // 0x50

        // ── Methods ──
        public void get_ItemType(){} // RVA: 0x7FFAC2F9E740
        public void get_ServiceCallSites(){} // RVA: 0x7FFAC2F9C730
        public void .ctor(){} // RVA: 0x7FFAC8331DD0
        public void get_ServiceType(){} // RVA: 0x7FFAC8331EF0
        public void get_ImplementationType(){} // RVA: 0x7FFAC8332040
        public void get_Kind(){} // RVA: 0x7FFAC30F10E0
    }

    public class ILEmitResolverBuilder : CallSiteVisitor`2
    {
        public System.Reflection.MethodInfo ResolvedServicesGetter;
        public System.Reflection.MethodInfo ScopeLockGetter; // 0x8
        public System.Reflection.MethodInfo ScopeIsRootScope; // 0x10
        public System.Reflection.MethodInfo CallSiteRuntimeResolverResolveMethod; // 0x18
        public System.Reflection.MethodInfo CallSiteRuntimeResolverInstanceField; // 0x20
        public System.Reflection.FieldInfo FactoriesField; // 0x28
        public System.Reflection.FieldInfo ConstantsField; // 0x30
        public System.Reflection.MethodInfo GetTypeFromHandleMethod; // 0x38
        public System.Reflection.ConstructorInfo CacheKeyCtor; // 0x40
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope _rootScope; // 0x18
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,GeneratedMethod> _scopeResolverCache; // 0x20
        public System.Func`3<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite,GeneratedMethod> _buildTypeDelegate; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83358B0
        public void Build(){} // RVA: 0x7FFAC8335C70
        public void BuildType(){} // RVA: 0x7FFAC8335C90
        public void BuildTypeNoCache(){} // RVA: 0x7FFAC8335D80
        public void VisitDisposeCache(){} // RVA: 0x7FFAC8335F20
        public void VisitConstructor(){} // RVA: 0x7FFAC8336070
        public void VisitRootCache(){} // RVA: 0x7FFAC8336310
        public void VisitScopeCache(){} // RVA: 0x7FFAC83364B0
        public void VisitConstant(){} // RVA: 0x7FFAC8336600
        public void VisitServiceProvider(){} // RVA: 0x7FFAC8336670
        public void VisitIEnumerable(){} // RVA: 0x7FFAC8336700
        public void VisitFactory(){} // RVA: 0x7FFAC8336B70
        public void AddConstant(){} // RVA: 0x7FFAC8336F70
        public void AddCacheKey(){} // RVA: 0x7FFAC83372B0
        public void GenerateMethodBody(){} // RVA: 0x7FFAC8337460
        public void BeginCaptureDisposable(){} // RVA: 0x7FFAC8338570
        public void EndCaptureDisposable(){} // RVA: 0x7FFAC8338600
        public void .cctor(){} // RVA: 0x7FFAC83386E0
        public void <.ctor>b__14_0(){} // RVA: 0x7FFAC83393B0
    }

    public class ILEmitResolverBuilderContext : Object
    {
        public System.Reflection.Emit.ILGenerator Generator; // 0x10
        public System.Collections.Generic.List`1<object> Constants; // 0x18
        public System.Collections.Generic.List`1<System.Func`2<System.IServiceProvider,object>> Factories; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Generator(){} // RVA: 0x7FFAC2F3C380
        public void get_Constants(){} // RVA: 0x7FFAC2F247C0
        public void set_Constants(){} // RVA: 0x7FFAC2F87E80
        public void get_Factories(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Factories(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class ResultCache : ValueType
    {
        public 0x6B2B04F0 Location; // 0x10
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey Key; // 0x18

        // ── Methods ──
        public void None(){} // RVA: 0x7FFAC8332070
        public void .ctor(){} // RVA: 0x7FFAC8332240 | overloaded x2
        public void get_Location(){} // RVA: 0x7FFAC4420210
        public void set_Location(){} // RVA: 0x7FFAC336D8B0
        public void get_Key(){} // RVA: 0x7FFAC4A212A0
        public void set_Key(){} // RVA: 0x7FFAC8332340
    }

    public class RuntimeResolverContext : ValueType
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope Scope; // 0x10
        public 0x6B2B05F8 AcquiredLocks; // 0x18

        // ── Methods ──
        public void get_Scope(){} // RVA: 0x7FFAC3AD9F60
        public void set_Scope(){} // RVA: 0x7FFAC38DFE40
        public void get_AcquiredLocks(){} // RVA: 0x7FFAC49C7500
        public void set_AcquiredLocks(){} // RVA: 0x7FFAC49C7510
    }

    public class RuntimeServiceProviderEngine : ServiceProviderEngine
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeServiceProviderEngine Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC83323B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void RealizeService(){} // RVA: 0x7FFAC8332410
        public void .cctor(){} // RVA: 0x7FFAC8332500
    }

    public class ServiceCacheKey : ValueType
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier ServiceIdentifier; // 0x10
        public int Slot; // 0x20

        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7FFAC32C0590
        public void get_Slot(){} // RVA: 0x7FFAC2F6E5C0
        public void .ctor(){} // RVA: 0x7FFAC60F12C0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8332950 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC83329F0
    }

    public class ServiceCallSite : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache ServiceType; // 0x10
        public object ImplementationType; // 0x30
        public object Kind; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC69C1C80
        public void get_ServiceType(){} // RVA: 0x7FFAC2C58E90
        public void get_ImplementationType(){} // RVA: 0x7FFAC2C58E90
        public void get_Kind(){} // RVA: 0x7FFAC2C59960
        public void get_Cache(){} // RVA: 0x7FFAC4997700
        public void get_Value(){} // RVA: 0x7FFAC31D95E0
        public void set_Value(){} // RVA: 0x7FFAC2F4F890
        public void get_Key(){} // RVA: 0x7FFAC31D0140
        public void set_Key(){} // RVA: 0x7FFAC31D0C20
        public void get_CaptureDisposable(){} // RVA: 0x7FFAC8332A90
    }

    public class ServiceDescriptorExtensions : Object
    {
        // ── Methods ──
        public void HasImplementationInstance(){} // RVA: 0x7FFAC8332C00
        public void HasImplementationType(){} // RVA: 0x7FFAC8332C20
        public void GetImplementationInstance(){} // RVA: 0x7FFAC8332C80
        public void GetImplementationType(){} // RVA: 0x7FFAC5093990
        public void TryGetImplementationType(){} // RVA: 0x7FFAC8332CA0
    }

    public class ServiceIdentifier : ValueType
    {
        public object ServiceKey; // 0x10
        public System.Type ServiceType; // 0x18

        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x7FFAC3AD9F60
        public void get_ServiceType(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void FromDescriptor(){} // RVA: 0x7FFAC8332D50
        public void FromServiceType(){} // RVA: 0x7FFAC8332D90
        public void Equals(){} // RVA: 0x7FFAC8332EA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8332F40
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC8332FD0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC8333000
        public void ToString(){} // RVA: 0x7FFAC8333060
    }

    public class ServiceLookupHelpers : Object
    {
        public System.Reflection.MethodInfo ArrayEmptyMethodInfo;
        public System.Reflection.MethodInfo InvokeFactoryMethodInfo; // 0x8
        public System.Reflection.MethodInfo CaptureDisposableMethodInfo; // 0x10
        public System.Reflection.MethodInfo TryGetValueMethodInfo; // 0x18
        public System.Reflection.MethodInfo ResolveCallSiteAndScopeMethodInfo; // 0x20
        public System.Reflection.MethodInfo AddMethodInfo; // 0x28
        public System.Reflection.MethodInfo MonitorEnterMethodInfo; // 0x30
        public System.Reflection.MethodInfo MonitorExitMethodInfo; // 0x38

        // ── Methods ──
        public void GetArrayEmptyMethodInfo(){} // RVA: 0x7FFAC8333120
        public void .cctor(){} // RVA: 0x7FFAC8333210
    }

    public class ServiceProviderCallSite : ServiceCallSite
    {
        public System.Type ServiceType; // 0x40
        public System.Type ImplementationType; // 0x48
        public 0x6B2B0498 Kind; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8333FE0
        public void get_ServiceType(){} // RVA: 0x7FFAC2F9E740
        public void get_ImplementationType(){} // RVA: 0x7FFAC2F9C730
        public void get_Kind(){} // RVA: 0x7FFAC30F10E0
    }

    public class ServiceProviderEngine : Object
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ServiceProviderEngineScope : Object
    {
        public bool ResolvedServices; // 0x10
        public System.Collections.Generic.List`1<object> Sync; // 0x18
        public System.Collections.Generic.Dictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,object> IsRootScope; // 0x20
        public bool RootProvider; // 0x28
        public Microsoft.Extensions.DependencyInjection.ServiceProvider <RootProvider>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83342A0
        public void get_ResolvedServices(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Sync(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IsRootScope(){} // RVA: 0x7FFAC30F6BA0
        public void get_RootProvider(){} // RVA: 0x7FFAC31D95E0
        public void GetService(){} // RVA: 0x7FFAC8334450
        public void CaptureDisposable(){} // RVA: 0x7FFAC8334560
        public void Dispose(){} // RVA: 0x7FFAC8334910
        public void DisposeAsync(){} // RVA: 0x7FFAC8334AA0
        public void BeginDispose(){} // RVA: 0x7FFAC8334DD0
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x7FFAC8335090
    }

    public class StackGuard : Object
    {
        public int _executionStackCount; // 0x10

        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFAC3006850
        public void RunOnEmptyStack(){} // RVA: 0x7FFAC2E8DC40
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFAC8335860
    }

}