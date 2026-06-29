// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 31
// Methods: 244

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD97FF30
        public void CheckCircularDependency(){} // RVA: 0x7AD980070
        public void Remove(){} // RVA: 0x7AD980150
        public void Add(){} // RVA: 0x7AD9801C0
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x7AD9802E0
        public void AppendResolutionPath(){} // RVA: 0x7AD980480
    }

    public class CallSiteFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD980B70
        public void get_Descriptors(){} // RVA: 0x7A80F2570
        public void Populate(){} // RVA: 0x7AD980F90
        public void ValidateTrimmingAnnotations(){} // RVA: 0x7AD981550
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x7AD9817A0
        public void AreCompatible(){} // RVA: 0x7A9624BF0
        public void GetCallSite(){} // RVA: 0x7AD981CC0
        public void CreateCallSite(){} // RVA: 0x7AD981F20
        public void TryCreateExact(){} // RVA: 0x7AD9839D0
        public void TryCreateOpenGeneric(){} // RVA: 0x7AD983F40
        public void TryCreateEnumerable(){} // RVA: 0x7AD9828E0
        public void GetCommonCacheLocation(){} // RVA: 0x7AD983970
        public void CreateConstructorCallSite(){} // RVA: 0x7AD9843A0
        public void CreateArgumentCallSites(){} // RVA: 0x7AD984CE0
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x7AD985170
        public void Add(){} // RVA: 0x7AD985280
        public void KeysMatch(){} // RVA: 0x7AD985370
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x7AD985430
    }

    public class CallSiteRuntimeResolver : CallSiteVisitor`2
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AD985CC0
        public void .ctor(){} // RVA: 0x7AD985D20
        public void Resolve(){} // RVA: 0x7AD985DD0
        public void VisitDisposeCache(){} // RVA: 0x7AD985E90
        public void VisitConstructor(){} // RVA: 0x7AD985EE0
        public void VisitRootCache(){} // RVA: 0x7AD9860F0
        public void VisitScopeCache(){} // RVA: 0x7AD986370
        public void VisitCache(){} // RVA: 0x7AD9863D0
        public void VisitConstant(){} // RVA: 0x7A885A050
        public void VisitServiceProvider(){} // RVA: 0x7AD9867D0
        public void VisitIEnumerable(){} // RVA: 0x7AD9867E0
        public void VisitFactory(){} // RVA: 0x7AD986900
        public void .cctor(){} // RVA: 0x7AD986940
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x7AD986A90
    }

    public class CallSiteValidator : CallSiteVisitor`2
    {
        // ── Methods ──
        public void ValidateCallSite(){} // RVA: 0x7AD986AA0
        public void ValidateResolution(){} // RVA: 0x7AD986B80
        public void VisitConstructor(){} // RVA: 0x7AD986DF0
        public void VisitIEnumerable(){} // RVA: 0x7AD986DF0
        public void VisitRootCache(){} // RVA: 0x7AD986E90
        public void VisitScopeCache(){} // RVA: 0x7AD986F20
        public void VisitConstant(){} // RVA: 0x7A82D1450
        public void VisitServiceProvider(){} // RVA: 0x7A82D1450
        public void VisitFactory(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7AD987210
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void VisitCallSite(){} // RVA: 0x7A8051B10
        public void VisitCallSiteMain(){} // RVA: 0x7A8051B10
        public void VisitNoCache(){} // RVA: 0x7A8051B10
        public void VisitDisposeCache(){} // RVA: 0x7A8051B10
        public void VisitRootCache(){} // RVA: 0x7A8051B10
        public void VisitScopeCache(){} // RVA: 0x7A8051B10
        public void VisitConstructor(){} // RVA: 0x7A8051B10
        public void VisitConstant(){} // RVA: 0x7A8051B10
        public void VisitServiceProvider(){} // RVA: 0x7A8051B10
        public void VisitIEnumerable(){} // RVA: 0x7A8051B10
        public void VisitFactory(){} // RVA: 0x7A8051B10
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD51E720
        public void VisitCallSite(){} // RVA: 0x7AD51D110
        public void VisitCallSiteMain(){} // RVA: 0x7AD51E7B0
        public void VisitNoCache(){} // RVA: 0x7AD51D480
        public void VisitDisposeCache(){} // RVA: 0x7AD51D480
        public void VisitRootCache(){} // RVA: 0x7AD51D480
        public void VisitScopeCache(){} // RVA: 0x7AD51D480
        public void VisitConstructor(){} // RVA: 0x7A7E06640
        public void VisitConstant(){} // RVA: 0x7A7E06640
        public void VisitServiceProvider(){} // RVA: 0x7A7E06640
        public void VisitIEnumerable(){} // RVA: 0x7A7E06640
        public void VisitFactory(){} // RVA: 0x7A7E06640
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD51D4A0
        public void VisitCallSite(){} // RVA: 0x7AD51D530
        public void VisitCallSiteMain(){} // RVA: 0x7AD51D660
        public void VisitNoCache(){} // RVA: 0x7AD51D910
        public void VisitDisposeCache(){} // RVA: 0x7AD51D910
        public void VisitRootCache(){} // RVA: 0x7AD51D910
        public void VisitScopeCache(){} // RVA: 0x7AD51D910
        public void VisitConstructor(){} // RVA: 0x7A7E00BD0
        public void VisitConstant(){} // RVA: 0x7A7E00BD0
        public void VisitServiceProvider(){} // RVA: 0x7A7E00BD0
        public void VisitIEnumerable(){} // RVA: 0x7A7E00BD0
        public void VisitFactory(){} // RVA: 0x7A7E00BD0
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD51E200
        public void VisitCallSite(){} // RVA: 0x7AD51E290
        public void VisitCallSiteMain(){} // RVA: 0x7AD51E3F0
        public void VisitNoCache(){} // RVA: 0x7AD51E6E0
        public void VisitDisposeCache(){} // RVA: 0x7AD51E6E0
        public void VisitRootCache(){} // RVA: 0x7AD51E6E0
        public void VisitScopeCache(){} // RVA: 0x7AD51E6E0
        public void VisitConstructor(){} // RVA: 0x7A7E00BD0
        public void VisitConstant(){} // RVA: 0x7A7E00BD0
        public void VisitServiceProvider(){} // RVA: 0x7A7E00BD0
        public void VisitIEnumerable(){} // RVA: 0x7A7E00BD0
        public void VisitFactory(){} // RVA: 0x7A7E00BD0
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD51D080
        public void VisitCallSite(){} // RVA: 0x7AD51D110
        public void VisitCallSiteMain(){} // RVA: 0x7AD51D200
        public void VisitNoCache(){} // RVA: 0x7AD51D480
        public void VisitDisposeCache(){} // RVA: 0x7AD51D480
        public void VisitRootCache(){} // RVA: 0x7AD51D480
        public void VisitScopeCache(){} // RVA: 0x7AD51D480
        public void VisitConstructor(){} // RVA: 0x7A7E00BD0
        public void VisitConstant(){} // RVA: 0x7A7E00BD0
        public void VisitServiceProvider(){} // RVA: 0x7A7E00BD0
        public void VisitIEnumerable(){} // RVA: 0x7A7E00BD0
        public void VisitFactory(){} // RVA: 0x7A7E00BD0
    }

    public class CompiledServiceProviderEngine : ServiceProviderEngine
    {
        // ── Methods ──
        public void get_ResolverBuilder(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AD987370
        public void RealizeService(){} // RVA: 0x7AD987430
    }

    public class ConstantCallSite : ServiceCallSite
    {
        // ── Methods ──
        public void get_DefaultValue(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AD987460
        public void get_ServiceType(){} // RVA: 0x7A8154D80
        public void get_ImplementationType(){} // RVA: 0x7AD987650
        public void get_Kind(){} // RVA: 0x7A8178B70
    }

    public class ConstructorCallSite : ServiceCallSite
    {
        // ── Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x7A8154D80
        public void get_ParameterCallSites(){} // RVA: 0x7A8152D80
        public void .ctor(){} // RVA: 0x7AD987720
        public void get_ServiceType(){} // RVA: 0x7A8178B90
        public void get_ImplementationType(){} // RVA: 0x7AD9879B0
        public void get_Kind(){} // RVA: 0x7A87A7DA0
    }

    public class DynamicServiceProviderEngine : CompiledServiceProviderEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9879E0
        public void RealizeService(){} // RVA: 0x7AD987AF0
        public void <>n__0(){} // RVA: 0x7AD987430
    }

    public class FactoryCallSite : ServiceCallSite
    {
        // ── Methods ──
        public void get_Factory(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7AD9880A0
        public void get_ServiceType(){} // RVA: 0x7A8152D80
        public void get_ImplementationType(){} // RVA: 0x7A82D1450
        public void get_Kind(){} // RVA: 0x7A8355950
    }

    public class IEnumerableCallSite : ServiceCallSite
    {
        // ── Methods ──
        public void get_ItemType(){} // RVA: 0x7A8154D80
        public void get_ServiceCallSites(){} // RVA: 0x7A8152D80
        public void .ctor(){} // RVA: 0x7AD988340
        public void get_ServiceType(){} // RVA: 0x7AD988460
        public void get_ImplementationType(){} // RVA: 0x7AD9885C0
        public void get_Kind(){} // RVA: 0x7A8355950
    }

    public class ILEmitResolverBuilder : CallSiteVisitor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD98BDD0
        public void Build(){} // RVA: 0x7AD98C180
        public void BuildType(){} // RVA: 0x7AD98C1A0
        public void BuildTypeNoCache(){} // RVA: 0x7AD98C290
        public void VisitDisposeCache(){} // RVA: 0x7AD98C430
        public void VisitConstructor(){} // RVA: 0x7AD98C580
        public void VisitRootCache(){} // RVA: 0x7AD98C830
        public void VisitScopeCache(){} // RVA: 0x7AD98C9D0
        public void VisitConstant(){} // RVA: 0x7AD98CB20
        public void VisitServiceProvider(){} // RVA: 0x7AD98CB90
        public void VisitIEnumerable(){} // RVA: 0x7AD98CC20
        public void VisitFactory(){} // RVA: 0x7AD98D0A0
        public void AddConstant(){} // RVA: 0x7AD98D4A0
        public void AddCacheKey(){} // RVA: 0x7AD98D7F0
        public void GenerateMethodBody(){} // RVA: 0x7AD98D9A0
        public void BeginCaptureDisposable(){} // RVA: 0x7AD98EAB0
        public void EndCaptureDisposable(){} // RVA: 0x7AD98EB40
        public void .cctor(){} // RVA: 0x7AD98EC20
        public void <.ctor>b__14_0(){} // RVA: 0x7AD98F8F0
    }

    public class ILEmitResolverBuilderContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Generator(){} // RVA: 0x7A80F2570
        public void get_Constants(){} // RVA: 0x7A80DA7B0
        public void set_Constants(){} // RVA: 0x7A813E420
        public void get_Factories(){} // RVA: 0x7A81052C0
        public void set_Factories(){} // RVA: 0x7A81052D0
    }

    public class ResultCache : ValueType
    {
        // ── Methods ──
        public void None(){} // RVA: 0x7AD9885F0
        public void .ctor(){} // RVA: 0x7A7E2C3D0
        public void get_Location(){} // RVA: 0x7A765F070
        public void set_Location(){} // RVA: 0x7A76134D0
        public void get_Key(){} // RVA: 0x7A768E4C0
        public void set_Key(){} // RVA: 0x7A7E2C400
    }

    public class RuntimeResolverContext : ValueType
    {
        // ── Methods ──
        public void get_Scope(){} // RVA: 0x7A765F710
        public void set_Scope(){} // RVA: 0x7A7637E60
        public void get_AcquiredLocks(){} // RVA: 0x7A75FEFA0
        public void set_AcquiredLocks(){} // RVA: 0x7A767FBC0
    }

    public class RuntimeServiceProviderEngine : ServiceProviderEngine
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AD988930
        public void .ctor(){} // RVA: 0x7A80D7310
        public void RealizeService(){} // RVA: 0x7AD988990
        public void .cctor(){} // RVA: 0x7AD988A80
    }

    public class ServiceCacheKey : ValueType
    {
        // ── Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7A7662BE0
        public void get_Slot(){} // RVA: 0x7A7677B20
        public void .ctor(){} // RVA: 0x7A79095A0
        public void Equals(){} // RVA: 0x7A7E2C5E0
        public void GetHashCode(){} // RVA: 0x7A7E2C5F0
    }

    public class ServiceCallSite : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABEA22A0
        public void get_ServiceType(){} // RVA: 0x7A7E00680
        public void get_ImplementationType(){} // RVA: 0x7A7E00680
        public void get_Kind(){} // RVA: 0x7A7E00710
        public void get_Cache(){} // RVA: 0x7A9C7E4C0
        public void get_Value(){} // RVA: 0x7A83F69F0
        public void set_Value(){} // RVA: 0x7A8105A90
        public void get_Key(){} // RVA: 0x7A8292C30
        public void set_Key(){} // RVA: 0x7A8296DE0
        public void get_CaptureDisposable(){} // RVA: 0x7AD989010
    }

    public class ServiceCallSite[] : Array
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

    public class ServiceDescriptorExtensions : Object
    {
        // ── Methods ──
        public void HasImplementationInstance(){} // RVA: 0x7AD989180
        public void HasImplementationType(){} // RVA: 0x7AD9891A0
        public void GetImplementationInstance(){} // RVA: 0x7AD989200
        public void GetImplementationType(){} // RVA: 0x7AA405B10
        public void TryGetImplementationType(){} // RVA: 0x7AD989220
    }

    public class ServiceIdentifier : ValueType
    {
        // ── Methods ──
        public void get_ServiceKey(){} // RVA: 0x7A765F710
        public void get_ServiceType(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7661E00
        public void FromDescriptor(){} // RVA: 0x7AD9892D0
        public void FromServiceType(){} // RVA: 0x7AD989310
        public void Equals(){} // RVA: 0x7A7E2C640
        public void GetHashCode(){} // RVA: 0x7A7E2C650
        public void get_IsConstructedGenericType(){} // RVA: 0x7A7E2C660
        public void GetGenericTypeDefinition(){} // RVA: 0x7A7E2C690
        public void ToString(){} // RVA: 0x7A7E2C7A0
    }

    public class ServiceLookupHelpers : Object
    {
        // ── Methods ──
        public void GetArrayEmptyMethodInfo(){} // RVA: 0x7AD9896A0
        public void .cctor(){} // RVA: 0x7AD989790
    }

    public class ServiceProviderCallSite : ServiceCallSite
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD98A560
        public void get_ServiceType(){} // RVA: 0x7A8154D80
        public void get_ImplementationType(){} // RVA: 0x7A8152D80
        public void get_Kind(){} // RVA: 0x7A8355950
    }

    public class ServiceProviderEngine : Object
    {
        // ── Methods ──
        public void RealizeService(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ServiceProviderEngineScope : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD98A820
        public void get_ResolvedServices(){} // RVA: 0x7A81052C0
        public void get_Sync(){} // RVA: 0x7A81052C0
        public void get_IsRootScope(){} // RVA: 0x7A84A5BD0
        public void get_RootProvider(){} // RVA: 0x7A83F69F0
        public void GetService(){} // RVA: 0x7AD98A9D0
        public void CaptureDisposable(){} // RVA: 0x7AD98AAE0
        public void Dispose(){} // RVA: 0x7AD98AE50
        public void DisposeAsync(){} // RVA: 0x7AD98B000
        public void BeginDispose(){} // RVA: 0x7AD98B330
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x7AD98B5A0
    }

    public class StackGuard : Object
    {
        // ── Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7A81BD750
        public void RunOnEmptyStack(){} // RVA: 0x7AA597DB0
        public void RunOnEmptyStackCore(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowObjectDisposedException(){} // RVA: 0x7AD98BD80
    }

}