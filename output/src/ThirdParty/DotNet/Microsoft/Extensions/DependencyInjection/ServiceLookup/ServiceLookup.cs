// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 26
// Methods: 190

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866D32A0
        public void CheckCircularDependency(){} // RVA: 0x7FFE866D33E0
        public void Remove(){} // RVA: 0x7FFE866D34C0
        public void Add(){} // RVA: 0x7FFE866D3530
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x7FFE866D3670
        public void AppendResolutionPath(){} // RVA: 0x7FFE866D3810
    }

    public class CallSiteFactory : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceDescriptor[] _descriptors; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866D3F00
        public void get_Descriptors(){} // RVA: 0x7FFE81116380
        public void Populate(){} // RVA: 0x7FFE866D4320
        public void ValidateTrimmingAnnotations(){} // RVA: 0x7FFE866D48E0
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x7FFE866D4B20
        public void AreCompatible(){} // RVA: 0x7FFE826077A0
        public void GetCallSite(){} // RVA: 0x7FFE866D5030 | overloaded x2
        public void CreateCallSite(){} // RVA: 0x7FFE866D5270
        public void TryCreateExact(){} // RVA: 0x7FFE866D6D60 | overloaded x2
        public void TryCreateOpenGeneric(){} // RVA: 0x7FFE866D72C0 | overloaded x2
        public void TryCreateEnumerable(){} // RVA: 0x7FFE866D5C40
        public void GetCommonCacheLocation(){} // RVA: 0x7FFE866D6D00
        public void CreateConstructorCallSite(){} // RVA: 0x7FFE866D7730
        public void CreateArgumentCallSites(){} // RVA: 0x7FFE866D8080
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x7FFE866D8500
        public void Add(){} // RVA: 0x7FFE866D8600
        public void KeysMatch(){} // RVA: 0x7FFE866D86F0
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x7FFE866D87B0
    }

    public class CallSiteRuntimeResolver : CallSiteVisitor`2
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteRuntimeResolver _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE866D9020
        public void .ctor(){} // RVA: 0x7FFE866D9080
        public void Resolve(){} // RVA: 0x7FFE866D9130
        public void VisitDisposeCache(){} // RVA: 0x7FFE866D91F0
        public void VisitConstructor(){} // RVA: 0x7FFE866D9240
        public void VisitRootCache(){} // RVA: 0x7FFE866D9430
        public void VisitScopeCache(){} // RVA: 0x7FFE866D96D0
        public void VisitCache(){} // RVA: 0x7FFE866D9730
        public void VisitConstant(){} // RVA: 0x7FFE866D9B40
        public void VisitServiceProvider(){} // RVA: 0x7FFE866D9B60
        public void VisitIEnumerable(){} // RVA: 0x7FFE866D9B70
        public void VisitFactory(){} // RVA: 0x7FFE866D9C90
        public void .cctor(){} // RVA: 0x7FFE866D9CD0
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x7FFE866D9E20
    }

    public class CallSiteValidator : CallSiteVisitor`2
    {
        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x7FFE866D9E30
        public void ValidateResolution(){} // RVA: 0x7FFE866D9F10
        public void VisitConstructor(){} // RVA: 0x7FFE866DA180
        public void VisitIEnumerable(){} // RVA: 0x7FFE866DA180
        public void VisitRootCache(){} // RVA: 0x7FFE866DA220
        public void VisitScopeCache(){} // RVA: 0x7FFE866DA2B0
        public void VisitConstant(){} // RVA: 0x7FFE813240E0
        public void VisitServiceProvider(){} // RVA: 0x7FFE813240E0
        public void VisitFactory(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE866DA5A0
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void VisitCallSite(){} // RVA: 0x7FFE810A1420
        public void VisitCallSiteMain(){} // RVA: 0x7FFE810A1420
        public void VisitNoCache(){} // RVA: 0x7FFE810A1420
        public void VisitDisposeCache(){} // RVA: 0x7FFE810A1420
        public void VisitRootCache(){} // RVA: 0x7FFE810A1420
        public void VisitScopeCache(){} // RVA: 0x7FFE810A1420
        public void VisitConstructor(){} // RVA: 0x7FFE810A1420
        public void VisitConstant(){} // RVA: 0x7FFE810A1420
        public void VisitServiceProvider(){} // RVA: 0x7FFE810A1420
        public void VisitIEnumerable(){} // RVA: 0x7FFE810A1420
        public void VisitFactory(){} // RVA: 0x7FFE810A1420
    }

    public class CompiledServiceProviderEngine : ServiceProviderEngine
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ILEmitResolverBuilder _resolverBuilder; // 0x10

        // ── Methods ──
        public void get_ResolverBuilder(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE866DA700
        public void RealizeService(){} // RVA: 0x7FFE866DA7C0
    }

    public class ConstantCallSite : ServiceCallSite
    {
        public System.Type _serviceType; // 0x40
        public 0x666AA334 _kind; // 0x48
        public object field_2; // 0x2F
        public object field_3; // 0x30

        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE866DA7F0
        public void get_ServiceType(){} // RVA: 0x7FFE81178740
        public void get_ImplementationType(){} // RVA: 0x7FFE866DA9E0
        public void get_Kind(){} // RVA: 0x7FFE8119C0C0
    }

    public class ConstructorCallSite : ServiceCallSite
    {
        public System.Reflection.ConstructorInfo _constructorInfo; // 0x40
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite[] _parameterCallSites; // 0x48
        public System.Type _serviceType; // 0x50
        public 0x666AA334 _kind; // 0x58
        public object field_4; // 0x33

        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x7FFE81178740
        public void get_ParameterCallSites(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE866DAAB0 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFE8119C0E0
        public void get_ImplementationType(){} // RVA: 0x7FFE866DAD40
        public void get_Kind(){} // RVA: 0x7FFE8175AC90
    }

    public class DynamicServiceProviderEngine : CompiledServiceProviderEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866DAD70
        public void RealizeService(){} // RVA: 0x7FFE866DAE80
        public void <>n__0(){} // RVA: 0x7FFE866DA7C0
    }

    public class FactoryCallSite : ServiceCallSite
    {
        public System.Func`2<System.IServiceProvider,object> _factory; // 0x40
        public System.Type _serviceType; // 0x48
        public 0x666AA334 _kind; // 0x50
        public object field_3; // 0x38

        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE866DB430 | overloaded x2
        public void get_ServiceType(){} // RVA: 0x7FFE81176730
        public void get_ImplementationType(){} // RVA: 0x7FFE813240E0
        public void get_Kind(){} // RVA: 0x7FFE8139DAD0
    }

    public class IEnumerableCallSite : ServiceCallSite
    {
        public System.Type _itemType; // 0x40
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite[] _serviceCallSites; // 0x48
        public 0x666AA334 _kind; // 0x50
        public object field_3; // 0x3C
        public object field_4; // 0x3D

        // ── Methods ──
        public void get_ItemType(){} // RVA: 0x7FFE81178740
        public void get_ServiceCallSites(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE866DB6D0
        public void get_ServiceType(){} // RVA: 0x7FFE866DB7F0
        public void get_ImplementationType(){} // RVA: 0x7FFE866DB940
        public void get_Kind(){} // RVA: 0x7FFE8139DAD0
    }

    public class ILEmitResolverBuilder : CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866DF1B0
        public void Build(){} // RVA: 0x7FFE866DF570
        public void BuildType(){} // RVA: 0x7FFE866DF590
        public void BuildTypeNoCache(){} // RVA: 0x7FFE866DF680
        public void VisitDisposeCache(){} // RVA: 0x7FFE866DF820
        public void VisitConstructor(){} // RVA: 0x7FFE866DF970
        public void VisitRootCache(){} // RVA: 0x7FFE866DFC10
        public void VisitScopeCache(){} // RVA: 0x7FFE866DFDB0
        public void VisitConstant(){} // RVA: 0x7FFE866DFF00
        public void VisitServiceProvider(){} // RVA: 0x7FFE866DFF70
        public void VisitIEnumerable(){} // RVA: 0x7FFE866E0000
        public void VisitFactory(){} // RVA: 0x7FFE866E0470
        public void AddConstant(){} // RVA: 0x7FFE866E0870
        public void AddCacheKey(){} // RVA: 0x7FFE866E0BB0
        public void GenerateMethodBody(){} // RVA: 0x7FFE866E0D60
        public void BeginCaptureDisposable(){} // RVA: 0x7FFE866E1E70
        public void EndCaptureDisposable(){} // RVA: 0x7FFE866E1F00
        public void .cctor(){} // RVA: 0x7FFE866E1FE0
        public void <.ctor>b__14_0(){} // RVA: 0x7FFE866E2CB0
    }

    public class ILEmitResolverBuilderContext : Object
    {
        public System.Reflection.Emit.ILGenerator _generator; // 0x10
        public System.Collections.Generic.List`1<object> _constants; // 0x18
        public System.Collections.Generic.List`1<System.Func`2<System.IServiceProvider,object>> _factories; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Generator(){} // RVA: 0x7FFE81116380
        public void get_Constants(){} // RVA: 0x7FFE810FE7C0
        public void set_Constants(){} // RVA: 0x7FFE81161E80
        public void get_Factories(){} // RVA: 0x7FFE811290C0
        public void set_Factories(){} // RVA: 0x7FFE811290D0
    }

    public class ResultCache : ValueType
    {
        public 0x666AA38C _location; // 0x10
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey _key; // 0x18

        // ── Methods ──
        public void None(){} // RVA: 0x7FFE866DB970
        public void .ctor(){} // RVA: 0x7FFE866DBB40 | overloaded x2
        public void get_Location(){} // RVA: 0x7FFE826F4220
        public void set_Location(){} // RVA: 0x7FFE815BF990
        public void get_Key(){} // RVA: 0x7FFE82C8CF70
        public void set_Key(){} // RVA: 0x7FFE866DBC40
    }

    public class RuntimeResolverContext : ValueType
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope _scope; // 0x10
        public + _acquiredLocks; // 0x18

        // ── Methods ──
        public void get_Scope(){} // RVA: 0x7FFE8284EF60
        public void set_Scope(){} // RVA: 0x7FFE81D7E9E0
        public void get_AcquiredLocks(){} // RVA: 0x7FFE82C33000
        public void set_AcquiredLocks(){} // RVA: 0x7FFE82C33010
    }

    public class RuntimeServiceProviderEngine : ServiceProviderEngine
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeServiceProviderEngine _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE866DBCB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void RealizeService(){} // RVA: 0x7FFE866DBD10
        public void .cctor(){} // RVA: 0x7FFE866DBE00
    }

    public class ServiceCacheKey : ValueType
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier _serviceIdentifier; // 0x10
        public int _slot; // 0x20

        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7FFE8151C410
        public void get_Slot(){} // RVA: 0x7FFE811485C0
        public void .ctor(){} // RVA: 0x7FFE844564B0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE866DC250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866DC2F0
    }

    public class ServiceCallSite : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache _cache; // 0x10
        public object _value; // 0x30
        public object _key2; // 0x38
        public 0x666AA38C _location; // 0x10
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey _key2; // 0x18
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier _serviceIdentifier; // 0x10
        public int _slot; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84D23120
        public void get_ServiceType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ImplementationType(){} // RVA: 0x7FFE80E2E2E0
        public void get_Kind(){} // RVA: 0x7FFE80E2EDB0
        public void get_Cache(){} // RVA: 0x7FFE82C03200
        public void get_Value(){} // RVA: 0x7FFE8144E200
        public void set_Value(){} // RVA: 0x7FFE81129890
        public void get_Key(){} // RVA: 0x7FFE8143BA80
        public void set_Key(){} // RVA: 0x7FFE81437330
        public void get_CaptureDisposable(){} // RVA: 0x7FFE866DC390
    }

    public class ServiceDescriptorExtensions : Object
    {
        // ── Methods ──
        public void HasImplementationInstance(){} // RVA: 0x7FFE866DC500
        public void HasImplementationType(){} // RVA: 0x7FFE866DC520
        public void GetImplementationInstance(){} // RVA: 0x7FFE866DC580
        public void GetImplementationType(){} // RVA: 0x7FFE83344A10
        public void TryGetImplementationType(){} // RVA: 0x7FFE866DC5A0
    }

    public class ServiceIdentifier : ValueType
    {
        public object _serviceKey; // 0x10
        public System.Type _serviceType; // 0x18
        public object field_2; // 0x3740

        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x7FFE8284EF60
        public void get_ServiceType(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void FromDescriptor(){} // RVA: 0x7FFE866DC650
        public void FromServiceType(){} // RVA: 0x7FFE866DC690
        public void Equals(){} // RVA: 0x7FFE866DC7A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866DC840
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE866DC8D0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE866DC900
        public void ToString(){} // RVA: 0x7FFE866DC960
    }

    public class ServiceLookupHelpers : Object
    {
        // ── Methods ──
        public void GetArrayEmptyMethodInfo(){} // RVA: 0x7FFE866DCA20
        public void .cctor(){} // RVA: 0x7FFE866DCB10
    }

    public class ServiceProviderCallSite : ServiceCallSite
    {
        public System.Type _serviceType; // 0x40
        public System.Type _implementationType; // 0x48
        public 0x666AA334 _kind; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866DD8E0
        public void get_ServiceType(){} // RVA: 0x7FFE81178740
        public void get_ImplementationType(){} // RVA: 0x7FFE81176730
        public void get_Kind(){} // RVA: 0x7FFE8139DAD0
    }

    public class ServiceProviderEngine : Object
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ServiceProviderEngineScope : Object
    {
        public bool _disposed; // 0x10
        public System.Collections.Generic.List`1<object> _disposables; // 0x18
        public System.Collections.Generic.Dictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,object> _resolvedServices; // 0x20
        public bool _isRootScope; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866DDBA0
        public void get_ResolvedServices(){} // RVA: 0x7FFE811290C0
        public void get_Sync(){} // RVA: 0x7FFE811290C0
        public void get_IsRootScope(){} // RVA: 0x7FFE815F1380
        public void get_RootProvider(){} // RVA: 0x7FFE8144E200
        public void GetService(){} // RVA: 0x7FFE866DDD50
        public void CaptureDisposable(){} // RVA: 0x7FFE866DDE60
        public void Dispose(){} // RVA: 0x7FFE866DE210
        public void DisposeAsync(){} // RVA: 0x7FFE866DE3A0
        public void BeginDispose(){} // RVA: 0x7FFE866DE6D0
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x7FFE866DE990
    }

    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7FFE811E0850
        public void RunOnEmptyStack(){} // RVA: 0x7FFE810A1420
        public void RunOnEmptyStackCore(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFE866DF160
    }

}