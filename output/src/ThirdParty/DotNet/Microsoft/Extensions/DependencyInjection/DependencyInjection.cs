// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 20
// Methods: 113

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter : CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866CE430
        public void Format(){} // RVA: 0x7FFE866CE4E0
        public void VisitConstructor(){} // RVA: 0x7FFE866CE6B0
        public void VisitCallSiteMain(){} // RVA: 0x7FFE866CE8E0
        public void VisitConstant(){} // RVA: 0x7FFE866CEE10
        public void VisitServiceProvider(){} // RVA: 0x7FFE813240E0
        public void VisitIEnumerable(){} // RVA: 0x7FFE866CEE90
        public void VisitFactory(){} // RVA: 0x7FFE866CF110
        public void .cctor(){} // RVA: 0x7FFE866CF190
    }

    public class DependencyInjectionEventSource : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866CF900
        public void CallSiteBuilt(){} // RVA: 0x7FFE866D0220 | overloaded x2
        public void ServiceResolved(){} // RVA: 0x7FFE81D95990 | overloaded x2
        public void DynamicMethodBuilt(){} // RVA: 0x7FFE81D95990 | overloaded x2
        public void ScopeDisposed(){} // RVA: 0x7FFE866CFD70
        public void ServiceRealizationFailed(){} // RVA: 0x7FFE81D95990 | overloaded x2
        public void ServiceProviderBuilt(){} // RVA: 0x7FFE866D0260 | overloaded x2
        public void ServiceProviderDescriptors(){} // RVA: 0x7FFE866D0060
        public void ServiceProviderDisposed(){} // RVA: 0x7FFE866D04F0
        public void WriteServiceProviderBuilt(){} // RVA: 0x7FFE866D0760
        public void AppendServiceDescriptor(){} // RVA: 0x7FFE866D07E0
        public void .cctor(){} // RVA: 0x7FFE866D0B90
    }

    public class FromKeyedServicesAttribute : Attribute
    {
        public object _key; // 0x10

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE81116380
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
        public void GetRequiredService(){} // RVA: 0x7FFE80E2E390
    }

    public class KeyedService : Object
    {
        public object _anyKey;

        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x7FFE866CA6E0
        public void .cctor(){} // RVA: 0x7FFE866CA740
    }

    public class LoggingServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddLogging(){} // RVA: 0x7FFE866EFC70
    }

    public class OptionsServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7FFE866F6B60
        public void Configure(){} // RVA: 0x7FFE80E3EAC0 | overloaded x2
    }

    public class ServiceCollection : Object
    {
        public System.Collections.Generic.List`1<Microsoft.Extensions.DependencyInjection.ServiceDescriptor> _descriptors; // 0x10
        public bool _isReadOnly; // 0x18
        public object ` 00; // 0x9

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE866CA830
        public void get_IsReadOnly(){} // RVA: 0x7FFE811164E0
        public void get_Item(){} // RVA: 0x7FFE866CA880
        public void set_Item(){} // RVA: 0x7FFE866CA900
        public void Clear(){} // RVA: 0x7FFE866CA990
        public void Contains(){} // RVA: 0x7FFE866CAA10
        public void CopyTo(){} // RVA: 0x7FFE866CAAC0
        public void Remove(){} // RVA: 0x7FFE866CAB40
        public void GetEnumerator(){} // RVA: 0x7FFE866CABB0
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x7FFE866CACA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE866CABB0
        public void IndexOf(){} // RVA: 0x7FFE866CAD00
        public void Insert(){} // RVA: 0x7FFE866CAD80
        public void RemoveAt(){} // RVA: 0x7FFE866CAE00
        public void CheckReadOnly(){} // RVA: 0x7FFE866CAE70
        public void ThrowReadOnlyException(){} // RVA: 0x7FFE866CAE90
        public void .ctor(){} // RVA: 0x7FFE866CAF00
    }

    public class ServiceCollectionContainerBuilderExtensions : Object
    {
        // ── Methods ──
        public void BuildServiceProvider(){} // RVA: 0x7FFE866D0E60 | overloaded x2
    }

    public class ServiceCollectionServiceExtensions : Object
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void Add(){} // RVA: 0x7FFE866CB310
    }

    public class ServiceDescriptor : Object
    {
        public 0x666D2E44 _lifetime; // 0x10
        public object _serviceKey; // 0x18
        public System.Type _serviceType; // 0x20
        public System.Type _implementationType; // 0x28
        public object _implementationInstance; // 0x30
        public object _implementationFactory; // 0x38
        public object field_6; // 0x8CD
        public object field_7; // 0x8CE
        public object field_8; // 0x8CF
        public object field_9; // 0x8D0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866CB950 | overloaded x6
        public void get_Lifetime(){} // RVA: 0x7FFE811485C0
        public void get_ServiceKey(){} // RVA: 0x7FFE810FE7C0
        public void get_ServiceType(){} // RVA: 0x7FFE811290C0
        public void get_ImplementationType(){} // RVA: 0x7FFE866CBA10
        public void get_KeyedImplementationType(){} // RVA: 0x7FFE866CBA30
        public void get_ImplementationInstance(){} // RVA: 0x7FFE866CBA50
        public void get_KeyedImplementationInstance(){} // RVA: 0x7FFE866CBA70
        public void get_ImplementationFactory(){} // RVA: 0x7FFE866CBA90
        public void get_KeyedImplementationFactory(){} // RVA: 0x7FFE866CBB10
        public void get_IsKeyedService(){} // RVA: 0x7FFE82AC8EE0
        public void ToString(){} // RVA: 0x7FFE866CBB90
        public void GetImplementationType(){} // RVA: 0x7FFE866CC0D0
        public void Transient(){} // RVA: 0x7FFE866CC2C0
        public void Scoped(){} // RVA: 0x7FFE866CC350
        public void Singleton(){} // RVA: 0x7FFE866CC3F0 | overloaded x4
        public void DescribeKeyed(){} // RVA: 0x7FFE866CC670 | overloaded x2
        public void Describe(){} // RVA: 0x7FFE866CC540
        public void ThrowKeyedDescriptor(){} // RVA: 0x7FFE866CC7A0
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x7FFE866CC810
    }

    public class ServiceKeyAttribute : Attribute
    {
    }

    public class ServiceProvider : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteValidator _callSiteValidator; // 0x10
        public System.Func`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> _createServiceAccessor; // 0x18
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngine _engine; // 0x20
        public bool _disposed; // 0x28
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> _serviceAccessors; // 0x30

        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x7FFE8143BA80
        public void get_Root(){} // RVA: 0x7FFE81178740
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x7FFE866D0F70
        public void get_DisableDynamicEngine(){} // RVA: 0x7FFE866D0FD0
        public void get_VerifyAotCompatibility(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE866D1030
        public void GetService(){} // RVA: 0x7FFE866D2440 | overloaded x2
        public void IsDisposed(){} // RVA: 0x7FFE815F1380
        public void Dispose(){} // RVA: 0x7FFE866D2220
        public void DisposeAsync(){} // RVA: 0x7FFE866D2250
        public void DisposeCore(){} // RVA: 0x7FFE866D22A0
        public void OnCreate(){} // RVA: 0x7FFE866D2320
        public void OnResolve(){} // RVA: 0x7FFE866D2410
        public void ValidateService(){} // RVA: 0x7FFE866D2570
        public void CreateServiceAccessor(){} // RVA: 0x7FFE866D2700
        public void ReplaceServiceAccessor(){} // RVA: 0x7FFE866D2C50
        public void GetEngine(){} // RVA: 0x7FFE866D2E80
        public void .cctor(){} // RVA: 0x7FFE866D2F20
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x7FFE866D3020
    }

    public class ServiceProviderOptions : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceProviderOptions Default;
        public bool _validateScopes; // 0x10

        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0x7FFE811C55E0
        public void get_ValidateOnBuild(){} // RVA: 0x7FFE81346E30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE866D3200
    }

    public class ServiceProviderServiceExtensions : Object
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

}