// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 20
// Methods: 113

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B8D600
        public void Format(){} // RVA: 0x5B8D6B0
        public void VisitConstructor(){} // RVA: 0x5B8D880
        public void VisitCallSiteMain(){} // RVA: 0x5B8DAB0
        public void VisitConstant(){} // RVA: 0x5B8DFE0
        public void VisitServiceProvider(){} // RVA: 0x519240
        public void VisitIEnumerable(){} // RVA: 0x5B8E060
        public void VisitFactory(){} // RVA: 0x5B8E2E0
        public void .cctor(){} // RVA: 0x5B8E360
    }

    public class DependencyInjectionEventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B8EAD0
        public void CallSiteBuilt(){} // RVA: 0x5B8F3F0 | overloaded x2
        public void ServiceResolved(){} // RVA: 0x1020CE0 | overloaded x2
        public void DynamicMethodBuilt(){} // RVA: 0x1020CE0 | overloaded x2
        public void ScopeDisposed(){} // RVA: 0x5B8EF40
        public void ServiceRealizationFailed(){} // RVA: 0x1020CE0 | overloaded x2
        public void ServiceProviderBuilt(){} // RVA: 0x5B8F430 | overloaded x2
        public void ServiceProviderDescriptors(){} // RVA: 0x5B8F230
        public void ServiceProviderDisposed(){} // RVA: 0x5B8F6C0
        public void WriteServiceProviderBuilt(){} // RVA: 0x5B8F930
        public void AppendServiceDescriptor(){} // RVA: 0x5B8F9B0
        public void .cctor(){} // RVA: 0x5B8FD60
    }

    public class FromKeyedServicesAttribute
    {
        public object <Key>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Key(){} // RVA: 0x2F8380
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
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0xCE10
    }

    public class KeyedService
    {
        public object <AnyKey>k__BackingField;

        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x5B898B0
        public void .cctor(){} // RVA: 0x5B89910
    }

    public class LoggingServiceCollectionExtensions
    {
        // ── Methods ──
        public void AddLogging(){} // RVA: 0x5BAEE20
    }

    public class OptionsServiceCollectionExtensions
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x5BB5D10
        public void Configure(){} // RVA: 0x1D550 | overloaded x2
    }

    public class ServiceCollection
    {
        public System.Collections.Generic.List`1<Microsoft.Extensions.DependencyInjection.ServiceDescriptor> _descriptors; // 0x10
        public bool _isReadOnly; // 0x18

        // ── Methods ──
        public void get_Count(){} // RVA: 0x5B89A00
        public void get_IsReadOnly(){} // RVA: 0x2F84E0
        public void get_Item(){} // RVA: 0x5B89A50
        public void set_Item(){} // RVA: 0x5B89AD0
        public void Clear(){} // RVA: 0x5B89B60
        public void Contains(){} // RVA: 0x5B89BE0
        public void CopyTo(){} // RVA: 0x5B89C90
        public void Remove(){} // RVA: 0x5B89D10
        public void GetEnumerator(){} // RVA: 0x5B89D80
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x5B89E70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5B89D80
        public void IndexOf(){} // RVA: 0x5B89ED0
        public void Insert(){} // RVA: 0x5B89F50
        public void RemoveAt(){} // RVA: 0x5B89FD0
        public void CheckReadOnly(){} // RVA: 0x5B8A040
        public void ThrowReadOnlyException(){} // RVA: 0x5B8A060
        public void .ctor(){} // RVA: 0x5B8A0D0
    }

    public class ServiceCollectionContainerBuilderExtensions
    {
        // ── Methods ──
        public void BuildServiceProvider(){} // RVA: 0x5B90030 | overloaded x2
    }

    public class ServiceCollectionServiceExtensions
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x283FA0 | overloaded x4
        public void Add(){} // RVA: 0x5B8A4E0
    }

    public class ServiceDescriptor
    {
        public 0x659FB3B0 <Lifetime>k__BackingField; // 0x10
        public object <ServiceKey>k__BackingField; // 0x18
        public System.Type <ServiceType>k__BackingField; // 0x20
        public System.Type _implementationType; // 0x28
        public object _implementationInstance; // 0x30
        public object _implementationFactory; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B8AB20 | overloaded x6
        public void get_Lifetime(){} // RVA: 0x32A5C0
        public void get_ServiceKey(){} // RVA: 0x2E07C0
        public void get_ServiceType(){} // RVA: 0x30B0C0
        public void get_ImplementationType(){} // RVA: 0x5B8ABE0
        public void get_KeyedImplementationType(){} // RVA: 0x5B8AC00
        public void get_ImplementationInstance(){} // RVA: 0x5B8AC20
        public void get_KeyedImplementationInstance(){} // RVA: 0x5B8AC40
        public void get_ImplementationFactory(){} // RVA: 0x5B8AC60
        public void get_KeyedImplementationFactory(){} // RVA: 0x5B8ACE0
        public void get_IsKeyedService(){} // RVA: 0x1D3B060
        public void ToString(){} // RVA: 0x5B8AD60
        public void GetImplementationType(){} // RVA: 0x5B8B2A0
        public void Transient(){} // RVA: 0x5B8B490
        public void Scoped(){} // RVA: 0x5B8B520
        public void Singleton(){} // RVA: 0x5B8B5C0 | overloaded x4
        public void DescribeKeyed(){} // RVA: 0x5B8B840 | overloaded x2
        public void Describe(){} // RVA: 0x5B8B710
        public void ThrowKeyedDescriptor(){} // RVA: 0x5B8B970
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x5B8B9E0
    }

    public class ServiceKeyAttribute
    {
    }

    public class ServiceProvider
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteValidator _callSiteValidator; // 0x10
        public System.Func`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> _createServiceAccessor; // 0x18
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngine _engine; // 0x20
        public bool _disposed; // 0x28
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> _serviceAccessors; // 0x30

        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x4976A0
        public void get_Root(){} // RVA: 0x35A740
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x5B90140
        public void get_DisableDynamicEngine(){} // RVA: 0x5B901A0
        public void get_VerifyAotCompatibility(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x5B90200
        public void GetService(){} // RVA: 0x5B91610 | overloaded x2
        public void IsDisposed(){} // RVA: 0x6E8A80
        public void Dispose(){} // RVA: 0x5B913F0
        public void DisposeAsync(){} // RVA: 0x5B91420
        public void DisposeCore(){} // RVA: 0x5B91470
        public void OnCreate(){} // RVA: 0x5B914F0
        public void OnResolve(){} // RVA: 0x5B915E0
        public void ValidateService(){} // RVA: 0x5B91740
        public void CreateServiceAccessor(){} // RVA: 0x5B918D0
        public void ReplaceServiceAccessor(){} // RVA: 0x5B91E20
        public void GetEngine(){} // RVA: 0x5B92050
        public void .cctor(){} // RVA: 0x5B920F0
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x5B921F0
    }

    public class ServiceProviderOptions
    {
        public Microsoft.Extensions.DependencyInjection.ServiceProviderOptions CallSiteFactory;
        public bool Root; // 0x10

        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0x3A75E0
        public void get_ValidateOnBuild(){} // RVA: 0x543460
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5B923D0
    }

    public class ServiceProviderServiceExtensions
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x283FA0 | overloaded x2
    }

}