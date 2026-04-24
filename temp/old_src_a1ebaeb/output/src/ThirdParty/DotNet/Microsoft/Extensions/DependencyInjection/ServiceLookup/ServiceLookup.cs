// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
// Classes: 22
// Methods: 187

namespace ThirdParty.DotNet.Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class CallSiteChain : Object
    {
        public object x00; // 0x3501E580

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd4ab50
        public void Remove(){} // RVA: 0x7ffaadd4ad70
        public void Add(){} // RVA: 0x7ffaadd4ade0
        public void CreateCircularDependencyExceptionMessage(){} // RVA: 0x7ffaadd4af20
        public void AppendResolutionPath(){} // RVA: 0x7ffaadd4b0c0
        // ── Binary Analysis Named ──
        public void CheckCircularDependency(){} // RVA: 0x7ffaadd4ac90
    }

    public class CallSiteFactory : Object
    {
        public object _descriptorLookup; // 0x35007050
        public object x00; // 0x350078D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd4b7b0
        public void get_Descriptors(){} // RVA: 0x7ffaa894d380
        public void Populate(){} // RVA: 0x7ffaadd4bbd0
        public void ValidateTrimmingAnnotations(){} // RVA: 0x7ffaadd4c190
        public void AreCompatible(){} // RVA: 0x7ffaa9d5f390
        public void CreateCallSite(){} // RVA: 0x7ffaadd4cb20
        public void TryCreateExact(){} // RVA: 0x7ffaadd4e610
        public void TryCreateOpenGeneric(){} // RVA: 0x7ffaadd4eb70
        public void TryCreateEnumerable(){} // RVA: 0x7ffaadd4d4f0
        public void TryCreateExact(){} // RVA: 0x7ffaadd4e610
        public void TryCreateOpenGeneric(){} // RVA: 0x7ffaadd4eb70
        public void CreateConstructorCallSite(){} // RVA: 0x7ffaadd4efe0
        public void CreateArgumentCallSites(){} // RVA: 0x7ffaadd4f930
        public void VerifyOpenGenericAotCompatibility(){} // RVA: 0x7ffaadd4fdb0
        public void Add(){} // RVA: 0x7ffaadd4feb0
        public void KeysMatch(){} // RVA: 0x7ffaadd4ffa0
        public void <TryCreateEnumerable>g__AddCallSite|19_1(){} // RVA: 0x7ffaadd50060
        // ── Binary Analysis Named ──
        public void GetDynamicallyAccessedMemberTypes(){} // RVA: 0x7ffaadd4c3d0
        public void GetCallSite(){} // RVA: 0x7ffaadd4c8e0
        public void GetCallSite(){} // RVA: 0x7ffaadd4c8e0
        public void GetCommonCacheLocation(){} // RVA: 0x7ffaadd4e5b0
    }

    public class CallSiteRuntimeResolver : CallSiteVisitor`2
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaadd508d0
        public void .ctor(){} // RVA: 0x7ffaadd50930
        public void Resolve(){} // RVA: 0x7ffaadd509e0
        public void VisitDisposeCache(){} // RVA: 0x7ffaadd50aa0
        public void VisitConstructor(){} // RVA: 0x7ffaadd50af0
        public void VisitRootCache(){} // RVA: 0x7ffaadd50ce0
        public void VisitScopeCache(){} // RVA: 0x7ffaadd50f80
        public void VisitCache(){} // RVA: 0x7ffaadd50fe0
        public void VisitConstant(){} // RVA: 0x7ffaadd513f0
        public void VisitServiceProvider(){} // RVA: 0x7ffaadd51410
        public void VisitIEnumerable(){} // RVA: 0x7ffaadd51420
        public void VisitFactory(){} // RVA: 0x7ffaadd51540
        public void .cctor(){} // RVA: 0x7ffaadd51580
        public void <VisitIEnumerable>g__CreateArray|12_0(){} // RVA: 0x7ffaadd516d0
    }

    public class CallSiteValidator : CallSiteVisitor`2
    {
        public object x00; // 0x302FFB10

        // ── Original Methods ──
        public void ValidateCallSite(){} // RVA: 0x7ffaadd516e0
        public void ValidateResolution(){} // RVA: 0x7ffaadd517c0
        public void VisitConstructor(){} // RVA: 0x7ffaadd51a30
        public void VisitIEnumerable(){} // RVA: 0x7ffaadd51a30
        public void VisitRootCache(){} // RVA: 0x7ffaadd51ad0
        public void VisitScopeCache(){} // RVA: 0x7ffaadd51b60
        public void VisitConstant(){} // RVA: 0x7ffaa8f22da0
        public void VisitServiceProvider(){} // RVA: 0x7ffaa8f22da0
        public void VisitFactory(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaadd51e50
    }

    public class CallSiteVisitor`2 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void VisitCallSite(){} // RVA: 0x7ffaa887e5c0
        public void VisitCallSiteMain(){} // RVA: 0x7ffaa887e5c0
        public void VisitNoCache(){} // RVA: 0x7ffaa887e5c0
        public void VisitDisposeCache(){} // RVA: 0x7ffaa887e5c0
        public void VisitRootCache(){} // RVA: 0x7ffaa887e5c0
        public void VisitScopeCache(){} // RVA: 0x7ffaa887e5c0
        public void VisitConstructor(){} // RVA: 0x7ffaa887e5c0
        public void VisitConstant(){} // RVA: 0x7ffaa887e5c0
        public void VisitServiceProvider(){} // RVA: 0x7ffaa887e5c0
        public void VisitIEnumerable(){} // RVA: 0x7ffaa887e5c0
        public void VisitFactory(){} // RVA: 0x7ffaa887e5c0
    }

    public class CallSiteVisitor`2 : Object
    {
        public object x00; // 0x3500D990

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaad812050
        public void VisitCallSite(){} // RVA: 0x7ffaad810a00
        public void VisitCallSiteMain(){} // RVA: 0x7ffaad8120e0
        public void VisitNoCache(){} // RVA: 0x7ffaad810d70
        public void VisitDisposeCache(){} // RVA: 0x7ffaad810d70
        public void VisitRootCache(){} // RVA: 0x7ffaad810d70
        public void VisitScopeCache(){} // RVA: 0x7ffaad810d70
        public void VisitConstructor(){}
        public void VisitConstant(){}
        public void VisitServiceProvider(){}
        public void VisitIEnumerable(){}
        public void VisitFactory(){}
    }

    public class CallSiteVisitor`2 : Object
    {
        public object x00; // 0x3504A1D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaad810d90
        public void VisitCallSite(){} // RVA: 0x7ffaad810e20
        public void VisitCallSiteMain(){} // RVA: 0x7ffaad810f50
        public void VisitNoCache(){} // RVA: 0x7ffaad811200
        public void VisitDisposeCache(){} // RVA: 0x7ffaad811200
        public void VisitRootCache(){} // RVA: 0x7ffaad811200
        public void VisitScopeCache(){} // RVA: 0x7ffaad811200
        public void VisitConstructor(){}
        public void VisitConstant(){}
        public void VisitServiceProvider(){}
        public void VisitIEnumerable(){}
        public void VisitFactory(){}
    }

    public class CallSiteVisitor`2 : Object
    {
        public object x00; // 0x35081808

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaad811b30
        public void VisitCallSite(){} // RVA: 0x7ffaad811bc0
        public void VisitCallSiteMain(){} // RVA: 0x7ffaad811d20
        public void VisitNoCache(){} // RVA: 0x7ffaad812010
        public void VisitDisposeCache(){} // RVA: 0x7ffaad812010
        public void VisitRootCache(){} // RVA: 0x7ffaad812010
        public void VisitScopeCache(){} // RVA: 0x7ffaad812010
        public void VisitConstructor(){}
        public void VisitConstant(){}
        public void VisitServiceProvider(){}
        public void VisitIEnumerable(){}
        public void VisitFactory(){}
    }

    public class ConstantCallSite : ServiceCallSite
    {
        // ── Original Methods ──
        public void get_DefaultValue(){} // RVA: 0x7ffaa8bfcc80
        public void .ctor(){} // RVA: 0x7ffaadd520a0
        public void get_ServiceType(){} // RVA: 0x7ffaa89af740
        public void get_ImplementationType(){} // RVA: 0x7ffaadd52290
        public void get_Kind(){} // RVA: 0x7ffaa89d30c0
    }

    public class ConstructorCallSite : ServiceCallSite
    {
        public object _serviceType; // 0x3501F390, was: <ServiceType>k__BackingField

        // ── Original Methods ──
        public void get_ConstructorInfo(){} // RVA: 0x7ffaa89af740
        public void get_ParameterCallSites(){} // RVA: 0x7ffaa89ad730
        public void .ctor(){} // RVA: 0x7ffaadd52360
        public void .ctor(){} // RVA: 0x7ffaadd52360
        public void get_ServiceType(){} // RVA: 0x7ffaa89d30e0
        public void get_ImplementationType(){} // RVA: 0x7ffaadd525f0
        public void get_Kind(){} // RVA: 0x7ffaa905bf10
    }

    public class FactoryCallSite : ServiceCallSite
    {
        public object _kind; // 0x3501F060, was: <Kind>k__BackingField
        public object Factory; // 0x17000038

        // ── Original Methods ──
        public void get_Factory(){} // RVA: 0x7ffaa89af740
        public void .ctor(){} // RVA: 0x7ffaadd52ce0
        public void .ctor(){} // RVA: 0x7ffaadd52ce0
        public void get_ServiceType(){} // RVA: 0x7ffaa89ad730
        public void get_ImplementationType(){} // RVA: 0x7ffaa8f22da0
        public void get_Kind(){} // RVA: 0x7ffaa8b023d0
    }

    public class IEnumerableCallSite : ServiceCallSite
    {
        public object _kind; // 0x3501FDB0, was: <Kind>k__BackingField
        public object ItemType; // 0x1700003C

        // ── Original Methods ──
        public void get_ItemType(){} // RVA: 0x7ffaa89af740
        public void get_ServiceCallSites(){} // RVA: 0x7ffaa89ad730
        public void .ctor(){} // RVA: 0x7ffaadd52f80
        public void get_ServiceType(){} // RVA: 0x7ffaadd530a0
        public void get_ImplementationType(){} // RVA: 0x7ffaadd531f0
        public void get_Kind(){} // RVA: 0x7ffaa8b023d0
    }

    public class ResultCache : ValueType
    {
        public object _serviceIdentifier; // 0x3501CA70, was: <ServiceIdentifier>k__BackingF

        // ── Original Methods ──
        public void None(){} // RVA: 0x7ffaadd53220
        public void .ctor(){} // RVA: 0x7ffaadd533f0
        public void .ctor(){} // RVA: 0x7ffaadd533f0
        public void get_Location(){} // RVA: 0x7ffaa9e47550
        public void set_Location(){} // RVA: 0x7ffaa8d92880
        public void get_Key(){} // RVA: 0x7ffaaa427dd0
        public void set_Key(){} // RVA: 0x7ffaadd534f0
    }

    public class RuntimeResolverContext : ValueType
    {
        public object Ϯf; // 0x34FCDA40

        // ── Original Methods ──
        public void get_Scope(){} // RVA: 0x7ffaa950bda0
        public void set_Scope(){} // RVA: 0x7ffaa930eca0
        public void get_AcquiredLocks(){} // RVA: 0x7ffaaa3cef80
        public void set_AcquiredLocks(){} // RVA: 0x7ffaaa3cef90
    }

    public class RuntimeServiceProviderEngine : ServiceProviderEngine
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaadd53560
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void RealizeService(){} // RVA: 0x7ffaadd535c0
        public void .cctor(){} // RVA: 0x7ffaadd536b0
    }

    public class ServiceCacheKey : ValueType
    {
        // ── Original Methods ──
        public void get_ServiceIdentifier(){} // RVA: 0x7ffaa8ce3e60
        public void get_Slot(){} // RVA: 0x7ffaa897f5c0
        public void .ctor(){} // RVA: 0x7ffaabb02870
        public void .ctor(){} // RVA: 0x7ffaabb02870
        public void Equals(){} // RVA: 0x7ffaadd53b00
        public void Equals(){} // RVA: 0x7ffaadd53b00
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadd53ba0
    }

    public class ServiceCallSite : Object
    {
        public object _key; // 0x3501C1E0, was: <Key>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3d2160
        public void get_ServiceType(){} // RVA: 0x7ffaa86491d0
        public void get_ImplementationType(){} // RVA: 0x7ffaa86491d0
        public void get_Kind(){} // RVA: 0x7ffaa8649ca0
        public void get_Cache(){} // RVA: 0x7ffaaa39f180
        public void get_Value(){} // RVA: 0x7ffaa8bfcc80
        public void set_Value(){} // RVA: 0x7ffaa8960890
        public void get_Key(){} // RVA: 0x7ffaa8bf45b0
        public void set_Key(){} // RVA: 0x7ffaa8bf45c0
        public void get_CaptureDisposable(){} // RVA: 0x7ffaadd53c40
    }

    public class ServiceIdentifier : ValueType
    {
        // ── Original Methods ──
        public void get_ServiceKey(){} // RVA: 0x7ffaa950bda0
        public void get_ServiceType(){} // RVA: 0x7ffaa9e47540
        public void .ctor(){} // RVA: 0x7ffaa9bb9250
        public void FromDescriptor(){} // RVA: 0x7ffaadd53f00
        public void FromServiceType(){} // RVA: 0x7ffaadd53f40
        public void Equals(){} // RVA: 0x7ffaadd54050
        public void Equals(){} // RVA: 0x7ffaadd54050
        public void get_IsConstructedGenericType(){} // RVA: 0x7ffaadd54180
        public void ToString(){} // RVA: 0x7ffaadd54210
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadd540f0
        public void GetGenericTypeDefinition(){} // RVA: 0x7ffaadd541b0
    }

    public class ServiceProviderCallSite : ServiceCallSite
    {
        public object _kind; // 0x3501CF20, was: <Kind>k__BackingField
        public object ServiceType; // 0x17000050

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd55190
        public void get_ServiceType(){} // RVA: 0x7ffaa89af740
        public void get_ImplementationType(){} // RVA: 0x7ffaa89ad730
        public void get_Kind(){} // RVA: 0x7ffaa8b023d0
    }

    public class ServiceProviderEngine : Object
    {
        // ── Original Methods ──
        public void RealizeService(){} // RVA: 0x7ffaa8649280
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ServiceProviderEngineScope : Object
    {
        public object _resolvedServices; // 0x3501D0D0, was: <ResolvedServices>k__BackingFi

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd55450
        public void get_ResolvedServices(){} // RVA: 0x7ffaa89600c0
        public void get_Sync(){} // RVA: 0x7ffaa89600c0
        public void get_IsRootScope(){} // RVA: 0x7ffaa8b0edb0
        public void get_RootProvider(){} // RVA: 0x7ffaa8bfcc80
        public void CaptureDisposable(){} // RVA: 0x7ffaadd55710
        public void Dispose(){} // RVA: 0x7ffaadd55ac0
        public void DisposeAsync(){} // RVA: 0x7ffaadd55c50
        public void <DisposeAsync>g__Await|26_0(){} // RVA: 0x7ffaadd56240
        // ── Binary Analysis Named ──
        public void GetService(){} // RVA: 0x7ffaadd55600
        public void BeginDispose(){} // RVA: 0x7ffaadd55f80
    }

    public class StackGuard : Object
    {
        public object x00; // 0x350341F8

        // ── Original Methods ──
        public void TryEnterOnCurrentStack(){} // RVA: 0x7ffaa8a17850
        public void RunOnEmptyStack(){} // RVA: 0x7ffaa887e5c0
        public void RunOnEmptyStackCore(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}