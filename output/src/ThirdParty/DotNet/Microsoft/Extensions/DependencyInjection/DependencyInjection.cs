// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 20
// Methods: 113

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter : CallSiteVisitor`2
    {
        public Microsoft.Extensions.DependencyInjection.CallSiteJsonFormatter Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8324B30
        public void Format(){} // RVA: 0x7FFAC8324BE0
        public void VisitConstructor(){} // RVA: 0x7FFAC8324DB0
        public void VisitCallSiteMain(){} // RVA: 0x7FFAC8324FE0
        public void VisitConstant(){} // RVA: 0x7FFAC8325510
        public void VisitServiceProvider(){} // RVA: 0x7FFAC34F9180
        public void VisitIEnumerable(){} // RVA: 0x7FFAC8325590
        public void VisitFactory(){} // RVA: 0x7FFAC8325810
        public void .cctor(){} // RVA: 0x7FFAC8325890
    }

    public class DependencyInjectionEventSource : EventSource
    {
        public Microsoft.Extensions.DependencyInjection.DependencyInjectionEventSource Log;
        public System.Collections.Generic.List`1<System.WeakReference`1<Microsoft.Extensions.DependencyInjection.ServiceProvider>> _providers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8326000
        public void CallSiteBuilt(){} // RVA: 0x7FFAC8326920 | overloaded x2
        public void ServiceResolved(){} // RVA: 0x7FFAC35D2DD0 | overloaded x2
        public void DynamicMethodBuilt(){} // RVA: 0x7FFAC35D2DD0 | overloaded x2
        public void ScopeDisposed(){} // RVA: 0x7FFAC8326470
        public void ServiceRealizationFailed(){} // RVA: 0x7FFAC35D2DD0 | overloaded x2
        public void ServiceProviderBuilt(){} // RVA: 0x7FFAC8326960 | overloaded x2
        public void ServiceProviderDescriptors(){} // RVA: 0x7FFAC8326760
        public void ServiceProviderDisposed(){} // RVA: 0x7FFAC8326BF0
        public void WriteServiceProviderBuilt(){} // RVA: 0x7FFAC8326E60
        public void AppendServiceDescriptor(){} // RVA: 0x7FFAC8326EE0
        public void .cctor(){} // RVA: 0x7FFAC8327290
    }

    public class FromKeyedServicesAttribute : Attribute
    {
        public object Key; // 0x10

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAC2F3C380
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
        public void GetRequiredService(){} // RVA: 0x7FFAC2C58F40
    }

    public class KeyedService : Object
    {
        public object AnyKey;

        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x7FFAC8320DE0
        public void .cctor(){} // RVA: 0x7FFAC8320E40
    }

    public class LoggingServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddLogging(){} // RVA: 0x7FFAC8346370
    }

    public class OptionsServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7FFAC834D260
        public void Configure(){} // RVA: 0x7FFAC2C69600 | overloaded x2
    }

    public class ServiceCollection : Object
    {
        public System.Collections.Generic.List`1<Microsoft.Extensions.DependencyInjection.ServiceDescriptor> Count; // 0x10
        public bool IsReadOnly; // 0x18

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC8320F30
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Item(){} // RVA: 0x7FFAC8320F80
        public void set_Item(){} // RVA: 0x7FFAC8321000
        public void Clear(){} // RVA: 0x7FFAC8321090
        public void Contains(){} // RVA: 0x7FFAC8321110
        public void CopyTo(){} // RVA: 0x7FFAC83211C0
        public void Remove(){} // RVA: 0x7FFAC8321240
        public void GetEnumerator(){} // RVA: 0x7FFAC83212B0
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x7FFAC83213A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC83212B0
        public void IndexOf(){} // RVA: 0x7FFAC8321400
        public void Insert(){} // RVA: 0x7FFAC8321480
        public void RemoveAt(){} // RVA: 0x7FFAC8321500
        public void CheckReadOnly(){} // RVA: 0x7FFAC8321570
        public void ThrowReadOnlyException(){} // RVA: 0x7FFAC8321590
        public void .ctor(){} // RVA: 0x7FFAC8321600
    }

    public class ServiceCollectionContainerBuilderExtensions : Object
    {
        // ── Methods ──
        public void BuildServiceProvider(){} // RVA: 0x7FFAC8327560 | overloaded x2
    }

    public class ServiceCollectionServiceExtensions : Object
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void Add(){} // RVA: 0x7FFAC8321A10
    }

    public class ServiceDescriptor : Object
    {
        public 0x6B2D8978 Lifetime; // 0x10
        public object ServiceKey; // 0x18
        public System.Type ServiceType; // 0x20
        public System.Type ImplementationType; // 0x28
        public object KeyedImplementationType; // 0x30
        public object ImplementationInstance; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8322050 | overloaded x6
        public void get_Lifetime(){} // RVA: 0x7FFAC2F6E5C0
        public void get_ServiceKey(){} // RVA: 0x7FFAC2F247C0
        public void get_ServiceType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ImplementationType(){} // RVA: 0x7FFAC8322110
        public void get_KeyedImplementationType(){} // RVA: 0x7FFAC8322130
        public void get_ImplementationInstance(){} // RVA: 0x7FFAC8322150
        public void get_KeyedImplementationInstance(){} // RVA: 0x7FFAC8322170
        public void get_ImplementationFactory(){} // RVA: 0x7FFAC8322190
        public void get_KeyedImplementationFactory(){} // RVA: 0x7FFAC8322210
        public void get_IsKeyedService(){} // RVA: 0x7FFAC4860B40
        public void ToString(){} // RVA: 0x7FFAC8322290
        public void GetImplementationType(){} // RVA: 0x7FFAC83227D0
        public void Transient(){} // RVA: 0x7FFAC83229C0
        public void Scoped(){} // RVA: 0x7FFAC8322A50
        public void Singleton(){} // RVA: 0x7FFAC8322AF0 | overloaded x4
        public void DescribeKeyed(){} // RVA: 0x7FFAC8322D70 | overloaded x2
        public void Describe(){} // RVA: 0x7FFAC8322C40
        public void ThrowKeyedDescriptor(){} // RVA: 0x7FFAC8322EA0
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x7FFAC8322F10
    }

    public class ServiceKeyAttribute : Attribute
    {
    }

    public class ServiceProvider : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteValidator CallSiteFactory; // 0x10
        public System.Func`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> Root; // 0x18
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngine VerifyOpenGenericServiceTrimmability; // 0x20
        public bool DisableDynamicEngine; // 0x28
        public System.Collections.Concurrent.ConcurrentDictionary`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> VerifyAotCompatibility; // 0x30
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory <CallSiteFactory>k__BackingField; // 0x38
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope <Root>k__BackingField; // 0x40
        public bool <VerifyOpenGenericServiceTrimmability>k__BackingField;
        public bool <DisableDynamicEngine>k__BackingField; // 0x1

        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x7FFAC31D0140
        public void get_Root(){} // RVA: 0x7FFAC2F9E740
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x7FFAC8327670
        public void get_DisableDynamicEngine(){} // RVA: 0x7FFAC83276D0
        public void get_VerifyAotCompatibility(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC8327730
        public void GetService(){} // RVA: 0x7FFAC8328B40 | overloaded x2
        public void IsDisposed(){} // RVA: 0x7FFAC30F6BA0
        public void Dispose(){} // RVA: 0x7FFAC8328920
        public void DisposeAsync(){} // RVA: 0x7FFAC8328950
        public void DisposeCore(){} // RVA: 0x7FFAC83289A0
        public void OnCreate(){} // RVA: 0x7FFAC8328A20
        public void OnResolve(){} // RVA: 0x7FFAC8328B10
        public void ValidateService(){} // RVA: 0x7FFAC8328C70
        public void CreateServiceAccessor(){} // RVA: 0x7FFAC8328E00
        public void ReplaceServiceAccessor(){} // RVA: 0x7FFAC8329350
        public void GetEngine(){} // RVA: 0x7FFAC8329580
        public void .cctor(){} // RVA: 0x7FFAC8329620
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x7FFAC8329720
    }

    public class ServiceProviderOptions : Object
    {
        public Microsoft.Extensions.DependencyInjection.ServiceProviderOptions ValidateScopes;
        public bool ValidateOnBuild; // 0x10
        public bool <ValidateOnBuild>k__BackingField; // 0x11

        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0x7FFAC2FEB5E0
        public void get_ValidateOnBuild(){} // RVA: 0x7FFAC3771DA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8329900
    }

    public class ServiceProviderServiceExtensions : Object
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

}