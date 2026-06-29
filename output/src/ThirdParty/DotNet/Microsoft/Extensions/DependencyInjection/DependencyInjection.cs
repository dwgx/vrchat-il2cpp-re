// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 15
// Methods: 107

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter : CallSiteVisitor`2
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66071F0
        public void Format(){} // RVA: 0x66072A0
        public void VisitConstructor(){} // RVA: 0x6607470
        public void VisitCallSiteMain(){} // RVA: 0x66076B0
        public void VisitConstant(){} // RVA: 0x66078E0
        public void VisitServiceProvider(){} // RVA: 0xDAC980
        public void VisitIEnumerable(){} // RVA: 0x6607960
        public void VisitFactory(){} // RVA: 0x6607BE0
        public void .cctor(){} // RVA: 0x6607C60
    }

    public class DependencyInjectionEventSource : EventSource
    {
        public object Log;
        public object _providers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66083C0
        public void CallSiteBuilt(){} // RVA: 0x6608CA0
        public void ServiceResolved(){} // RVA: 0x18F3EB0
        public void DynamicMethodBuilt(){} // RVA: 0x18F3EB0
        public void ScopeDisposed(){} // RVA: 0x6608810
        public void ServiceRealizationFailed(){} // RVA: 0x18F3EB0
        public void ServiceProviderBuilt(){} // RVA: 0x6608CE0
        public void ServiceProviderDescriptors(){} // RVA: 0x6608AF0
        public void ServiceProviderDisposed(){} // RVA: 0x6608F40
        public void WriteServiceProviderBuilt(){} // RVA: 0x6609170
        public void AppendServiceDescriptor(){} // RVA: 0x66091F0
        public void .cctor(){} // RVA: 0x6609580
    }

    public class FromKeyedServicesAttribute : Attribute
    {
        public object _key;

        // ── Methods ──
        public void get_Key(){} // RVA: 0xB5DBF0
    }

    public class ISupportRequiredService
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x87C540
    }

    public class KeyedService : Object
    {
        public object _anyKey;

        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x6603590
        public void .cctor(){} // RVA: 0x66035F0
    }

    public class LoggingServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddLogging(){} // RVA: 0x6627BA0
    }

    public class OptionsServiceCollectionExtensions : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x662E950
        public void Configure(){} // RVA: 0x317BAE0
    }

    public class ServiceCollection : Object
    {
        public object _descriptors;
        public object _isReadOnly;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x66036E0
        public void get_IsReadOnly(){} // RVA: 0xB5DD50
        public void get_Item(){} // RVA: 0x6603730
        public void set_Item(){} // RVA: 0x66037B0
        public void Clear(){} // RVA: 0x6603840
        public void Contains(){} // RVA: 0x66038C0
        public void CopyTo(){} // RVA: 0x6603970
        public void Remove(){} // RVA: 0x66039F0
        public void GetEnumerator(){} // RVA: 0x6603A60
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x6603B50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6603A60
        public void IndexOf(){} // RVA: 0x6603BB0
        public void Insert(){} // RVA: 0x6603C30
        public void RemoveAt(){} // RVA: 0x6603CB0
        public void CheckReadOnly(){} // RVA: 0x6603D20
        public void ThrowReadOnlyException(){} // RVA: 0x6603D40
        public void .ctor(){} // RVA: 0x6603DB0
    }

    public class ServiceCollectionContainerBuilderExtensions : Object
    {
        // ── Methods ──
        public void BuildServiceProvider(){} // RVA: 0x6609850
    }

    public class ServiceCollectionServiceExtensions : Object
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x29B3F70
        public void Add(){} // RVA: 0x66041C0
    }

    public class ServiceDescriptor : Object
    {
        public object _lifetime;
        public object _serviceKey;
        public object _serviceType;
        public object _implementationType;
        public object _implementationInstance;
        public object _implementationFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6604820
        public void get_Lifetime(){} // RVA: 0xB8F8F0
        public void get_ServiceKey(){} // RVA: 0xB465B0
        public void get_ServiceType(){} // RVA: 0xB700F0
        public void get_ImplementationType(){} // RVA: 0x66048E0
        public void get_KeyedImplementationType(){} // RVA: 0x6604900
        public void get_ImplementationInstance(){} // RVA: 0x6604920
        public void get_KeyedImplementationInstance(){} // RVA: 0x6604940
        public void get_ImplementationFactory(){} // RVA: 0x6604960
        public void get_KeyedImplementationFactory(){} // RVA: 0x66049E0
        public void get_IsKeyedService(){} // RVA: 0x25E9250
        public void ToString(){} // RVA: 0x6604A60
        public void GetImplementationType(){} // RVA: 0x6604F90
        public void Transient(){} // RVA: 0x6605150
        public void Scoped(){} // RVA: 0x66051E0
        public void Singleton(){} // RVA: 0x29B4380
        public void DescribeKeyed(){} // RVA: 0x29B41B0
        public void Describe(){} // RVA: 0x66053D0
        public void ThrowKeyedDescriptor(){} // RVA: 0x6605630
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x66056A0
    }

    public class ServiceDescriptor[] : Array
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

    public class ServiceProvider : Object
    {
        public object _callSiteValidator;
        public object _createServiceAccessor;
        public object _engine;
        public object _disposed;
        public object _serviceAccessors;
        public object _callSiteFactory;
        public object _root;
        public object _verifyOpenGenericServiceTrimmability;
        public object _disableDynamicEngine;

        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0xD05CA0
        public void get_Root(){} // RVA: 0xBC1B30
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x6609960
        public void get_DisableDynamicEngine(){} // RVA: 0x66099C0
        public void get_VerifyAotCompatibility(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x6609A20
        public void GetService(){} // RVA: 0x660AD20
        public void IsDisposed(){} // RVA: 0xF73960
        public void Dispose(){} // RVA: 0x660AB10
        public void DisposeAsync(){} // RVA: 0x660AB40
        public void DisposeCore(){} // RVA: 0x660AB90
        public void OnCreate(){} // RVA: 0x660AC10
        public void OnResolve(){} // RVA: 0x660ACF0
        public void ValidateService(){} // RVA: 0x660AE50
        public void CreateServiceAccessor(){} // RVA: 0x660AFE0
        public void ReplaceServiceAccessor(){} // RVA: 0x660B530
        public void GetEngine(){} // RVA: 0x660B760
        public void .cctor(){} // RVA: 0x660B810
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x660B910
    }

    public class ServiceProviderOptions : Object
    {
        public object Default;
        public object _validateScopes;
        public object _validateOnBuild;

        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0xC120A0
        public void get_ValidateOnBuild(){} // RVA: 0xDD5C50
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x660BAF0
    }

    public class ServiceProviderServiceExtensions : Object
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x29B5030
    }

}