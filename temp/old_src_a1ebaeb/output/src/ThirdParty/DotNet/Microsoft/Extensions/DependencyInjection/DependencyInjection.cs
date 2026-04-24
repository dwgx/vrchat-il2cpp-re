// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 18
// Methods: 110

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter : CallSiteVisitor`2
    {
        public object x00; // 0x30301070

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd45ce0
        public void Format(){} // RVA: 0x7ffaadd45d90
        public void VisitConstructor(){} // RVA: 0x7ffaadd45f60
        public void VisitCallSiteMain(){} // RVA: 0x7ffaadd46190
        public void VisitConstant(){} // RVA: 0x7ffaadd466c0
        public void VisitServiceProvider(){} // RVA: 0x7ffaa8f22da0
        public void VisitIEnumerable(){} // RVA: 0x7ffaadd46740
        public void VisitFactory(){} // RVA: 0x7ffaadd469c0
        public void .cctor(){} // RVA: 0x7ffaadd46a40
    }

    public class DependencyInjectionEventSource : EventSource
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd471b0
        public void CallSiteBuilt(){} // RVA: 0x7ffaadd47ad0
        public void ServiceResolved(){} // RVA: 0x7ffaa94a7020
        public void DynamicMethodBuilt(){} // RVA: 0x7ffaa94a7020
        public void ScopeDisposed(){} // RVA: 0x7ffaadd47620
        public void ServiceRealizationFailed(){} // RVA: 0x7ffaa94a7020
        public void ServiceProviderBuilt(){} // RVA: 0x7ffaadd47b10
        public void ServiceProviderDescriptors(){} // RVA: 0x7ffaadd47910
        public void ServiceResolved(){} // RVA: 0x7ffaa94a7020
        public void CallSiteBuilt(){} // RVA: 0x7ffaadd47ad0
        public void DynamicMethodBuilt(){} // RVA: 0x7ffaa94a7020
        public void ServiceRealizationFailed(){} // RVA: 0x7ffaa94a7020
        public void ServiceProviderBuilt(){} // RVA: 0x7ffaadd47b10
        public void ServiceProviderDisposed(){} // RVA: 0x7ffaadd47da0
        public void WriteServiceProviderBuilt(){} // RVA: 0x7ffaadd48010
        public void AppendServiceDescriptor(){} // RVA: 0x7ffaadd48090
        public void .cctor(){} // RVA: 0x7ffaadd48440
    }

    public class FromKeyedServicesAttribute : Attribute
    {
        // ── Original Methods ──
        public void get_Key(){} // RVA: 0x7ffaa894d380
    }

    public class IServiceCollection
    {
    }

    public class IServiceProviderIsKeyedService
    {
    }

    public class IServiceProviderIsService
    {
    }

    public class IServiceScope
    {
    }

    public class IServiceScopeFactory
    {
    }

    public class ISupportRequiredService
    {
        // ── Binary Analysis Named ──
        public void GetRequiredService(){} // RVA: 0x7ffaa8649280
    }

    public class KeyedService : Object
    {
        // ── Original Methods ──
        public void get_AnyKey(){} // RVA: 0x7ffaadd41f90
        public void .cctor(){} // RVA: 0x7ffaadd41ff0
    }

    public class OptionsServiceCollectionExtensions : Object
    {
        // ── Original Methods ──
        public void AddOptions(){} // RVA: 0x7ffaadd6e410
        public void Configure(){} // RVA: 0x7ffaa8659940
        public void Configure(){} // RVA: 0x7ffaa8659940
    }

    public class ServiceCollection : Object
    {
        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaadd420e0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa894d4e0
        public void get_Item(){} // RVA: 0x7ffaadd42130
        public void set_Item(){} // RVA: 0x7ffaadd421b0
        public void Clear(){} // RVA: 0x7ffaadd42240
        public void Contains(){} // RVA: 0x7ffaadd422c0
        public void CopyTo(){} // RVA: 0x7ffaadd42370
        public void Remove(){} // RVA: 0x7ffaadd423f0
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x7ffaadd42550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaadd42460
        public void IndexOf(){} // RVA: 0x7ffaadd425b0
        public void Insert(){} // RVA: 0x7ffaadd42630
        public void RemoveAt(){} // RVA: 0x7ffaadd426b0
        public void ThrowReadOnlyException(){} // RVA: 0x7ffaadd42740
        public void .ctor(){} // RVA: 0x7ffaadd427b0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaadd42460
        public void CheckReadOnly(){} // RVA: 0x7ffaadd42720
    }

    public class ServiceCollectionServiceExtensions : Object
    {
        // ── Original Methods ──
        public void AddSingleton(){} // RVA: 0x7ffaa887e5c0
        public void AddSingleton(){} // RVA: 0x7ffaa887e5c0
        public void AddSingleton(){} // RVA: 0x7ffaa887e5c0
        public void AddSingleton(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaadd42bc0
    }

    public class ServiceDescriptor : Object
    {
        public object _serviceType; // 0x318A8330, was: <ServiceType>k__BackingField
        public object _implementationFactory; // 0x318A8330
        public object Capacity; // 0x170008CD
        public object Count; // 0x170008CE

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd43200
        public void .ctor(){} // RVA: 0x7ffaadd43200
        public void .ctor(){} // RVA: 0x7ffaadd43200
        public void .ctor(){} // RVA: 0x7ffaadd43200
        public void .ctor(){} // RVA: 0x7ffaadd43200
        public void .ctor(){} // RVA: 0x7ffaadd43200
        public void get_Lifetime(){} // RVA: 0x7ffaa897f5c0
        public void get_ServiceKey(){} // RVA: 0x7ffaa89357c0
        public void get_ServiceType(){} // RVA: 0x7ffaa89600c0
        public void get_ImplementationType(){} // RVA: 0x7ffaadd432c0
        public void get_KeyedImplementationType(){} // RVA: 0x7ffaadd432e0
        public void get_ImplementationInstance(){} // RVA: 0x7ffaadd43300
        public void get_KeyedImplementationInstance(){} // RVA: 0x7ffaadd43320
        public void get_ImplementationFactory(){} // RVA: 0x7ffaadd43340
        public void get_KeyedImplementationFactory(){} // RVA: 0x7ffaadd433c0
        public void get_IsKeyedService(){} // RVA: 0x7ffaaa268a50
        public void ToString(){} // RVA: 0x7ffaadd43440
        public void Transient(){} // RVA: 0x7ffaadd43b70
        public void Scoped(){} // RVA: 0x7ffaadd43c00
        public void Singleton(){} // RVA: 0x7ffaadd43ca0
        public void Singleton(){} // RVA: 0x7ffaadd43ca0
        public void Singleton(){} // RVA: 0x7ffaadd43ca0
        public void Singleton(){} // RVA: 0x7ffaadd43ca0
        public void DescribeKeyed(){} // RVA: 0x7ffaadd43f20
        public void Describe(){} // RVA: 0x7ffaadd43df0
        public void DescribeKeyed(){} // RVA: 0x7ffaadd43f20
        public void ThrowKeyedDescriptor(){} // RVA: 0x7ffaadd44050
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x7ffaadd440c0
        // ── Binary Analysis Named ──
        public void GetImplementationType(){} // RVA: 0x7ffaadd43980
    }

    public class ServiceKeyAttribute : Attribute
    {
    }

    public class ServiceProvider : Object
    {
        public object _engine; // 0x350061B0
        public object _callSiteFactory; // 0x350061B0, was: <CallSiteFactory>k__BackingFie
        public object _disableDynamicEngine; // 0x350061B0, was: <DisableDynamicEngine>k__Backi
        public object CallSiteFactory; // 0x1700001B
        public object Root; // 0x1700001C
        public object VerifyOpenGenericServiceTrimmability; // 0x1700001D

        // ── Original Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x7ffaa8bf45b0
        public void get_Root(){} // RVA: 0x7ffaa89af740
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x7ffaadd48820
        public void get_DisableDynamicEngine(){} // RVA: 0x7ffaadd48880
        public void get_VerifyAotCompatibility(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaadd488e0
        public void IsDisposed(){} // RVA: 0x7ffaa8b0edb0
        public void Dispose(){} // RVA: 0x7ffaadd49ad0
        public void DisposeAsync(){} // RVA: 0x7ffaadd49b00
        public void DisposeCore(){} // RVA: 0x7ffaadd49b50
        public void OnCreate(){} // RVA: 0x7ffaadd49bd0
        public void OnResolve(){} // RVA: 0x7ffaadd49cc0
        public void ValidateService(){} // RVA: 0x7ffaadd49e20
        public void CreateServiceAccessor(){} // RVA: 0x7ffaadd49fb0
        public void ReplaceServiceAccessor(){} // RVA: 0x7ffaadd4a500
        public void .cctor(){} // RVA: 0x7ffaadd4a7d0
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x7ffaadd4a8d0
        // ── Binary Analysis Named ──
        public void GetService(){} // RVA: 0x7ffaadd49cf0
        public void GetService(){} // RVA: 0x7ffaadd49cf0
        public void GetEngine(){} // RVA: 0x7ffaadd4a730
    }

    public class ServiceProviderOptions : Object
    {
        public object _validateOnBuild; // 0x35006030, was: <ValidateOnBuild>k__BackingFie
        public object ValidateScopes; // 0x17000022

        // ── Original Methods ──
        public void get_ValidateScopes(){} // RVA: 0x7ffaa89fc5e0
        public void get_ValidateOnBuild(){} // RVA: 0x7ffaa8b37c40
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaadd4aab0
    }

    public class ServiceProviderServiceExtensions : Object
    {
        // ── Binary Analysis Named ──
        public void GetRequiredService(){} // RVA: 0x7ffaa887e5c0
        public void GetRequiredService(){} // RVA: 0x7ffaa887e5c0
    }

}