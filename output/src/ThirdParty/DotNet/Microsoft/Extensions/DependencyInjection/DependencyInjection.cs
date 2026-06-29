// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 15
// Methods: 107

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter : CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD97B400
        public void Format(){} // RVA: 0x7AD97B4B0
        public void VisitConstructor(){} // RVA: 0x7AD97B680
        public void VisitCallSiteMain(){} // RVA: 0x7AD97B8C0
        public void VisitConstant(){} // RVA: 0x7AD97BAF0
        public void VisitServiceProvider(){} // RVA: 0x7A82D1450
        public void VisitIEnumerable(){} // RVA: 0x7AD97BB70
        public void VisitFactory(){} // RVA: 0x7AD97BE00
        public void .cctor(){} // RVA: 0x7AD97BE80
    }

    public class DependencyInjectionEventSource : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD97C5E0
        public void CallSiteBuilt(){} // RVA: 0x7AD97CF00
        public void ServiceResolved(){} // RVA: 0x7A8DD7270
        public void DynamicMethodBuilt(){} // RVA: 0x7A8DD7270
        public void ScopeDisposed(){} // RVA: 0x7AD97CA50
        public void ServiceRealizationFailed(){} // RVA: 0x7A8DD7270
        public void ServiceProviderBuilt(){} // RVA: 0x7AD97CF40
        public void ServiceProviderDescriptors(){} // RVA: 0x7AD97CD40
        public void ServiceProviderDisposed(){} // RVA: 0x7AD97D1A0
        public void WriteServiceProviderBuilt(){} // RVA: 0x7AD97D3D0
        public void AppendServiceDescriptor(){} // RVA: 0x7AD97D450
        public void .cctor(){} // RVA: 0x7AD97D800
    }

    public class FromKeyedServicesAttribute : Attribute
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7A80F2570
    }

    public class ISupportRequiredService
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x7A7E00B20
    }

    public class KeyedService : Object
    {
        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x7AD9776A0
        public void .cctor(){} // RVA: 0x7AD977700
    }

    public class LoggingServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddLogging(){} // RVA: 0x7AD99CB00
    }

    public class OptionsServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7AD9A3980
        public void Configure(){} // RVA: 0x7AA552D00
    }

    public class ServiceCollection : Object
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7AD9777F0
        public void get_IsReadOnly(){} // RVA: 0x7A80F26D0
        public void get_Item(){} // RVA: 0x7AD977840
        public void set_Item(){} // RVA: 0x7AD9778C0
        public void Clear(){} // RVA: 0x7AD977950
        public void Contains(){} // RVA: 0x7AD9779D0
        public void CopyTo(){} // RVA: 0x7AD977A80
        public void Remove(){} // RVA: 0x7AD977B00
        public void GetEnumerator(){} // RVA: 0x7AD977B70
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x7AD977C60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD977B70
        public void IndexOf(){} // RVA: 0x7AD977CC0
        public void Insert(){} // RVA: 0x7AD977D40
        public void RemoveAt(){} // RVA: 0x7AD977DC0
        public void CheckReadOnly(){} // RVA: 0x7AD977E30
        public void ThrowReadOnlyException(){} // RVA: 0x7AD977E50
        public void .ctor(){} // RVA: 0x7AD977EC0
    }

    public class ServiceCollectionContainerBuilderExtensions : Object
    {
        // ── Methods ──
        public void BuildServiceProvider(){} // RVA: 0x7AD97DAD0
    }

    public class ServiceCollectionServiceExtensions : Object
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x7AA58A150
        public void Add(){} // RVA: 0x7AD9782D0
    }

    public class ServiceDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD978930
        public void get_Lifetime(){} // RVA: 0x7A8124910
        public void get_ServiceKey(){} // RVA: 0x7A80DA7B0
        public void get_ServiceType(){} // RVA: 0x7A81052C0
        public void get_ImplementationType(){} // RVA: 0x7AD9789F0
        public void get_KeyedImplementationType(){} // RVA: 0x7AD978A10
        public void get_ImplementationInstance(){} // RVA: 0x7AD978A30
        public void get_KeyedImplementationInstance(){} // RVA: 0x7AD978A50
        public void get_ImplementationFactory(){} // RVA: 0x7AD978A70
        public void get_KeyedImplementationFactory(){} // RVA: 0x7AD978AF0
        public void get_IsKeyedService(){} // RVA: 0x7A9B3D890
        public void ToString(){} // RVA: 0x7AD978B70
        public void GetImplementationType(){} // RVA: 0x7AD9790B0
        public void Transient(){} // RVA: 0x7AD979290
        public void Scoped(){} // RVA: 0x7AD979320
        public void Singleton(){} // RVA: 0x7AA58A5F0
        public void DescribeKeyed(){} // RVA: 0x7AA58A3C0
        public void Describe(){} // RVA: 0x7AD979510
        public void ThrowKeyedDescriptor(){} // RVA: 0x7AD979770
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x7AD9797E0
    }

    public class ServiceDescriptor[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ServiceProvider : Object
    {
        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x7A8292C30
        public void get_Root(){} // RVA: 0x7A8154D80
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x7AD97DBE0
        public void get_DisableDynamicEngine(){} // RVA: 0x7AD97DC40
        public void get_VerifyAotCompatibility(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AD97DCA0
        public void GetService(){} // RVA: 0x7AD97F0C0
        public void IsDisposed(){} // RVA: 0x7A84A5BD0
        public void Dispose(){} // RVA: 0x7AD97EEA0
        public void DisposeAsync(){} // RVA: 0x7AD97EED0
        public void DisposeCore(){} // RVA: 0x7AD97EF20
        public void OnCreate(){} // RVA: 0x7AD97EFA0
        public void OnResolve(){} // RVA: 0x7AD97F090
        public void ValidateService(){} // RVA: 0x7AD97F1F0
        public void CreateServiceAccessor(){} // RVA: 0x7AD97F380
        public void ReplaceServiceAccessor(){} // RVA: 0x7AD97F8D0
        public void GetEngine(){} // RVA: 0x7AD97FB00
        public void .cctor(){} // RVA: 0x7AD97FBB0
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x7AD97FCB0
    }

    public class ServiceProviderOptions : Object
    {
        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0x7A81A2200
        public void get_ValidateOnBuild(){} // RVA: 0x7A82FBFB0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AD97FE90
    }

    public class ServiceProviderServiceExtensions : Object
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x7AA58A820
    }

}