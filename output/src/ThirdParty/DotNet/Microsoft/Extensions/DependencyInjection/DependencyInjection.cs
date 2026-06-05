// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
// Classes: 20
// Methods: 113

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection
{
    public class CallSiteJsonFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF863D600
        public void Format(){} // RVA: 0x7FFAF863D6B0
        public void VisitConstructor(){} // RVA: 0x7FFAF863D880
        public void VisitCallSiteMain(){} // RVA: 0x7FFAF863DAB0
        public void VisitConstant(){} // RVA: 0x7FFAF863DFE0
        public void VisitServiceProvider(){} // RVA: 0x7FFAF2FC9240
        public void VisitIEnumerable(){} // RVA: 0x7FFAF863E060
        public void VisitFactory(){} // RVA: 0x7FFAF863E2E0
        public void .cctor(){} // RVA: 0x7FFAF863E360
    }

    public class DependencyInjectionEventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF863EAD0
        public void CallSiteBuilt(){} // RVA: 0x7FFAF863F3F0 | overloaded x2
        public void ServiceResolved(){} // RVA: 0x7FFAF3AD0CE0 | overloaded x2
        public void DynamicMethodBuilt(){} // RVA: 0x7FFAF3AD0CE0 | overloaded x2
        public void ScopeDisposed(){} // RVA: 0x7FFAF863EF40
        public void ServiceRealizationFailed(){} // RVA: 0x7FFAF3AD0CE0 | overloaded x2
        public void ServiceProviderBuilt(){} // RVA: 0x7FFAF863F430 | overloaded x2
        public void ServiceProviderDescriptors(){} // RVA: 0x7FFAF863F230
        public void ServiceProviderDisposed(){} // RVA: 0x7FFAF863F6C0
        public void WriteServiceProviderBuilt(){} // RVA: 0x7FFAF863F930
        public void AppendServiceDescriptor(){} // RVA: 0x7FFAF863F9B0
        public void .cctor(){} // RVA: 0x7FFAF863FD60
    }

    public class FromKeyedServicesAttribute
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAF2DA8380
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
        public void GetRequiredService(){} // RVA: 0x7FFAF2ABCE10
    }

    public class KeyedService
    {
        // ── Methods ──
        public void get_AnyKey(){} // RVA: 0x7FFAF86398B0
        public void .cctor(){} // RVA: 0x7FFAF8639910
    }

    public class LoggingServiceCollectionExtensions
    {
        // ── Methods ──
        public void AddLogging(){} // RVA: 0x7FFAF865EE20
    }

    public class OptionsServiceCollectionExtensions
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7FFAF8665D10
        public void Configure(){} // RVA: 0x7FFAF2ACD550 | overloaded x2
    }

    public class ServiceCollection
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF8639A00
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2DA84E0
        public void get_Item(){} // RVA: 0x7FFAF8639A50
        public void set_Item(){} // RVA: 0x7FFAF8639AD0
        public void Clear(){} // RVA: 0x7FFAF8639B60
        public void Contains(){} // RVA: 0x7FFAF8639BE0
        public void CopyTo(){} // RVA: 0x7FFAF8639C90
        public void Remove(){} // RVA: 0x7FFAF8639D10
        public void GetEnumerator(){} // RVA: 0x7FFAF8639D80
        public void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(){} // RVA: 0x7FFAF8639E70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8639D80
        public void IndexOf(){} // RVA: 0x7FFAF8639ED0
        public void Insert(){} // RVA: 0x7FFAF8639F50
        public void RemoveAt(){} // RVA: 0x7FFAF8639FD0
        public void CheckReadOnly(){} // RVA: 0x7FFAF863A040
        public void ThrowReadOnlyException(){} // RVA: 0x7FFAF863A060
        public void .ctor(){} // RVA: 0x7FFAF863A0D0
    }

    public class ServiceCollectionContainerBuilderExtensions
    {
        // ── Methods ──
        public void BuildServiceProvider(){} // RVA: 0x7FFAF8640030 | overloaded x2
    }

    public class ServiceCollectionServiceExtensions
    {
        // ── Methods ──
        public void AddSingleton(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void Add(){} // RVA: 0x7FFAF863A4E0
    }

    public class ServiceDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF863AB20 | overloaded x6
        public void get_Lifetime(){} // RVA: 0x7FFAF2DDA5C0
        public void get_ServiceKey(){} // RVA: 0x7FFAF2D907C0
        public void get_ServiceType(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ImplementationType(){} // RVA: 0x7FFAF863ABE0
        public void get_KeyedImplementationType(){} // RVA: 0x7FFAF863AC00
        public void get_ImplementationInstance(){} // RVA: 0x7FFAF863AC20
        public void get_KeyedImplementationInstance(){} // RVA: 0x7FFAF863AC40
        public void get_ImplementationFactory(){} // RVA: 0x7FFAF863AC60
        public void get_KeyedImplementationFactory(){} // RVA: 0x7FFAF863ACE0
        public void get_IsKeyedService(){} // RVA: 0x7FFAF47EB060
        public void ToString(){} // RVA: 0x7FFAF863AD60
        public void GetImplementationType(){} // RVA: 0x7FFAF863B2A0
        public void Transient(){} // RVA: 0x7FFAF863B490
        public void Scoped(){} // RVA: 0x7FFAF863B520
        public void Singleton(){} // RVA: 0x7FFAF863B5C0 | overloaded x4
        public void DescribeKeyed(){} // RVA: 0x7FFAF863B840 | overloaded x2
        public void Describe(){} // RVA: 0x7FFAF863B710
        public void ThrowKeyedDescriptor(){} // RVA: 0x7FFAF863B970
        public void ThrowNonKeyedDescriptor(){} // RVA: 0x7FFAF863B9E0
    }

    public class ServiceKeyAttribute
    {
    }

    public class ServiceProvider
    {
        // ── Methods ──
        public void get_CallSiteFactory(){} // RVA: 0x7FFAF2F476A0
        public void get_Root(){} // RVA: 0x7FFAF2E0A740
        public void get_VerifyOpenGenericServiceTrimmability(){} // RVA: 0x7FFAF8640140
        public void get_DisableDynamicEngine(){} // RVA: 0x7FFAF86401A0
        public void get_VerifyAotCompatibility(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF8640200
        public void GetService(){} // RVA: 0x7FFAF8641610 | overloaded x2
        public void IsDisposed(){} // RVA: 0x7FFAF3198A80
        public void Dispose(){} // RVA: 0x7FFAF86413F0
        public void DisposeAsync(){} // RVA: 0x7FFAF8641420
        public void DisposeCore(){} // RVA: 0x7FFAF8641470
        public void OnCreate(){} // RVA: 0x7FFAF86414F0
        public void OnResolve(){} // RVA: 0x7FFAF86415E0
        public void ValidateService(){} // RVA: 0x7FFAF8641740
        public void CreateServiceAccessor(){} // RVA: 0x7FFAF86418D0
        public void ReplaceServiceAccessor(){} // RVA: 0x7FFAF8641E20
        public void GetEngine(){} // RVA: 0x7FFAF8642050
        public void .cctor(){} // RVA: 0x7FFAF86420F0
        public void <GetEngine>g__CreateDynamicEngine|36_0(){} // RVA: 0x7FFAF86421F0
    }

    public class ServiceProviderOptions
    {
        public object CallSiteFactory;
        public object Root;

        // ── Methods ──
        public void get_ValidateScopes(){} // RVA: 0x7FFAF2E575E0
        public void get_ValidateOnBuild(){} // RVA: 0x7FFAF2FF3460
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF86423D0
    }

    public class ServiceProviderServiceExtensions
    {
        // ── Methods ──
        public void GetRequiredService(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
    }

}