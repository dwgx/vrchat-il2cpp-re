// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 18
// Methods: 110

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter : CallSiteVisitor`2
    {
        public ute.m.Collections.Immutable.dll Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53744B30
        public void Format(){} // RVA: 0x7FFD53744BE0
        public void VisitConstructor(){} // RVA: 0x7FFD53744DB0
        public void VisitCallSiteMain(){} // RVA: 0x7FFD53744FE0
        public void VisitConstant(){} // RVA: 0x7FFD53745510
        public void VisitServiceProvider(){} // RVA: 0x7FFD4E919180
        public void VisitIEnumerable(){} // RVA: 0x7FFD53745590
        public void VisitFactory(){} // RVA: 0x7FFD53745810
        public void .cctor(){} // RVA: 0x7FFD53745890
    }

    public class DependencyInjectionEventSource : EventSource
    {
        public ute.ocFreeConcurrentStack`1 Log;
        public URA.woDigitYearMax<numValuesAndNames<ute.SetTimeWindow>> _providers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53746000
        public void CallSiteBuilt(){} // RVA: 0x7FFD53746920 | overloaded x2
        public void ServiceResolved(){} // RVA: 0x7FFD4E9F2DD0 | overloaded x2
        public void DynamicMethodBuilt(){} // RVA: 0x7FFD4E9F2DD0 | overloaded x2
        public void ScopeDisposed(){} // RVA: 0x7FFD53746470
        public void ServiceRealizationFailed(){} // RVA: 0x7FFD4E9F2DD0 | overloaded x2
        public void ServiceProviderBuilt(){} // RVA: 0x7FFD53746960 | overloaded x2
        public void ServiceProviderDescriptors(){} // RVA: 0x7FFD53746760
        public void ServiceProviderDisposed(){} // RVA: 0x7FFD53746BF0
        public void WriteServiceProviderBuilt(){} // RVA: 0x7FFD53746E60
        public void AppendServiceDescriptor(){} // RVA: 0x7FFD53746EE0
        public void .cctor(){} // RVA: 0x7FFD53747290
    }

    public class FromKeyedServicesAttribute : Attribute
    {
        public object Key; // 0x10

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFD4E35C380
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
        public void GetRequiredService(){} // RVA: 0x7FFD4E078F40
    }

    public class KeyedService : Object
    {
        public object AnyKey;

        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x7FFD53740DE0
        public void .cctor(){} // RVA: 0x7FFD53740E40
    }

    public class OptionsServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7FFD5376D260
        public void Configure(){} // RVA: 0x7FFD4E089600 | overloaded x2
    }

    public class ServiceCollection : Object
    {
        public URA.woDigitYearMax<ute.portsPacking> Count; // 0x10
        public bool IsReadOnly; // 0x18

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD53740F30
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E35C4E0
        public void get_Item(){} // RVA: 0x7FFD53740F80
        public void set_Item(){} // RVA: 0x7FFD53741000
        public void Clear(){} // RVA: 0x7FFD53741090
        public void Contains(){} // RVA: 0x7FFD53741110
        public void CopyTo(){} // RVA: 0x7FFD537411C0
        public void Remove(){} // RVA: 0x7FFD53741240
        public void GetEnumerator(){} // RVA: 0x7FFD537412B0
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x7FFD537413A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD537412B0
        public void IndexOf(){} // RVA: 0x7FFD53741400
        public void Insert(){} // RVA: 0x7FFD53741480
        public void RemoveAt(){} // RVA: 0x7FFD53741500
        public void CheckReadOnly(){} // RVA: 0x7FFD53741570
        public void ThrowReadOnlyException(){} // RVA: 0x7FFD53741590
        public void .ctor(){} // RVA: 0x7FFD53741600
    }

    public class ServiceCollectionServiceExtensions : Object
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void Add(){} // RVA: 0x7FFD53741A10
    }

    public class ServiceDescriptor : Object
    {
        public ute.? Lifetime; // 0x10
        public object ServiceKey; // 0x18
        public object ServiceType; // 0x20
        public object ImplementationType; // 0x28
        public object KeyedImplementationType; // 0x30
        public object ImplementationInstance; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53742050 | overloaded x6
        public void get_Lifetime(){} // RVA: 0x7FFD4E38E5C0
        public void get_ServiceKey(){} // RVA: 0x7FFD4E3447C0
        public void get_ServiceType(){} // RVA: 0x7FFD4E36F0C0
        public void get_ImplementationType(){} // RVA: 0x7FFD53742110
        public void get_KeyedImplementationType(){} // RVA: 0x7FFD53742130
        public void get_ImplementationInstance(){} // RVA: 0x7FFD53742150
        public void get_KeyedImplementationInstance(){} // RVA: 0x7FFD53742170
        public void get_ImplementationFactory(){} // RVA: 0x7FFD53742190
        public void get_KeyedImplementationFactory(){} // RVA: 0x7FFD53742210
        public void get_IsKeyedService(){} // RVA: 0x7FFD4FC80B40
        public void ToString(){} // RVA: 0x7FFD53742290
        public void GetImplementationType(){} // RVA: 0x7FFD537427D0
        public void Transient(){} // RVA: 0x7FFD537429C0
        public void Scoped(){} // RVA: 0x7FFD53742A50
        public void Singleton(){} // RVA: 0x7FFD53742AF0 | overloaded x4
        public void DescribeKeyed(){} // RVA: 0x7FFD53742D70 | overloaded x2
        public void Describe(){} // RVA: 0x7FFD53742C40
        public void ThrowKeyedDescriptor(){} // RVA: 0x7FFD53742EA0
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x7FFD53742F10
    }

    public class ServiceKeyAttribute : Attribute
    {
    }

    public class ServiceProvider : Object
    {
        public numeratorObject.ons.Immutable.ISecurePooledObjectUser.PoolUserId CallSiteFactory; // 0x10
        public n<numeratorObject.posed,stem.Collections.Generic.ICollection<T>.get_Count> Root; // 0x18
        public numeratorObject.? VerifyOpenGenericServiceTrimmability; // 0x20
        public bool DisableDynamicEngine; // 0x28
        public JapaneseLangName.erns<numeratorObject.posed,stem.Collections.Generic.ICollection<T>.get_Count> VerifyAotCompatibility; // 0x30
        public numeratorObject.e <CallSiteFactory>k__BackingField; // 0x38
        public numeratorObject.? <Root>k__BackingField; // 0x40
        public bool <VerifyOpenGenericServiceTrimmability>k__BackingField;
        public bool <DisableDynamicEngine>k__BackingField; // 0x1

        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x7FFD4E5F0140
        public void get_Root(){} // RVA: 0x7FFD4E3BE740
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x7FFD53747670
        public void get_DisableDynamicEngine(){} // RVA: 0x7FFD537476D0
        public void get_VerifyAotCompatibility(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD53747730
        public void GetService(){} // RVA: 0x7FFD53748B40 | overloaded x2
        public void IsDisposed(){} // RVA: 0x7FFD4E516BA0
        public void Dispose(){} // RVA: 0x7FFD53748920
        public void DisposeAsync(){} // RVA: 0x7FFD53748950
        public void DisposeCore(){} // RVA: 0x7FFD537489A0
        public void OnCreate(){} // RVA: 0x7FFD53748A20
        public void OnResolve(){} // RVA: 0x7FFD53748B10
        public void ValidateService(){} // RVA: 0x7FFD53748C70
        public void CreateServiceAccessor(){} // RVA: 0x7FFD53748E00
        public void ReplaceServiceAccessor(){} // RVA: 0x7FFD53749350
        public void GetEngine(){} // RVA: 0x7FFD53749580
        public void .cctor(){} // RVA: 0x7FFD53749620
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x7FFD53749720
    }

    public class ServiceProviderOptions : Object
    {
        public ute.fNotInitialized ValidateScopes;
        public bool ValidateOnBuild; // 0x10
        public bool <ValidateOnBuild>k__BackingField; // 0x11

        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0x7FFD4E40B5E0
        public void get_ValidateOnBuild(){} // RVA: 0x7FFD4EB91DA0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53749900
    }

    public class ServiceProviderServiceExtensions : Object
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

}