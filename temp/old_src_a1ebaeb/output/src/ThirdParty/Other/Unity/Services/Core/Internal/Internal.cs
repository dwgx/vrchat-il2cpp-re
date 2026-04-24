// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 31
// Methods: 117

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase : CustomYieldInstruction
    {
        // ── Original Methods ──
        public void get_keepWaiting(){} // RVA: 0x7ffaaf113640
        public void get_IsCompleted(){} // RVA: 0x7ffaa864a040
    }

    public class CircularDependencyException : ServicesInitializationException
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf112640
    }

    public class ComponentRegistry : Object
    {
        // ── Original Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaaf1139e0
        public void RegisterServiceComponent(){} // RVA: 0x7ffaa887e5c0
        public void IsComponentTypeRegistered(){} // RVA: 0x7ffaaf113aa0
        public void ResetProvidedComponents(){} // RVA: 0x7ffaaf113b90
        // ── Binary Analysis Named ──
        public void GetServiceComponent(){} // RVA: 0x7ffaa887e5c0
    }

    public class CoreDiagnostics : Object
    {
        public object _diagnosticsComponentProvider; // 0x339BD8D0, was: <DiagnosticsComponentProvider>
        public object Instance; // 0x17000015

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaf119160
        public void set_Instance(){} // RVA: 0x7ffaaf1191a0
        public void set_DiagnosticsComponentProvider(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf119240
    }

    public class CoreLogger : Object
    {
        // ── Original Methods ──
        public void LogWarning(){} // RVA: 0x7ffaaf113730
        public void LogError(){} // RVA: 0x7ffaaf113810
        public void LogException(){} // RVA: 0x7ffaaf1138f0
    }

    public class CoreMetrics : Object
    {
        // ── Original Methods ──
        public void set_Instance(){} // RVA: 0x7ffaaf119300
        public void .ctor(){} // RVA: 0x7ffaaf1193a0
    }

    public class CorePackageRegistry : Object
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaf113c60
        public void set_Instance(){} // RVA: 0x7ffaaf113ca0
        public void get_Registry(){} // RVA: 0x7ffaa894d380
        public void set_Registry(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaaf113d40
        public void Register(){} // RVA: 0x7ffaa887e5c0
        public void Lock(){} // RVA: 0x7ffaaf113e60
    }

    public class CoreRegistration : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d82c00
        public void DependsOn(){} // RVA: 0x7ffaa887e5c0
        public void OptionallyDependsOn(){} // RVA: 0x7ffaa887e5c0
        public void ProvidesComponent(){} // RVA: 0x7ffaa887e5c0
    }

    public class CoreRegistry : Object
    {
        public object _type; // 0x3171F930, was: <Type>k__BackingField
        public object _componentRegistry; // 0x3171F930, was: <ComponentRegistry>k__BackingF

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaf113f80
        public void set_Instance(){} // RVA: 0x7ffaaf113fc0
        public void get_Type(){} // RVA: 0x7ffaa8b945a0
        public void set_Type(){} // RVA: 0x7ffaa9357830
        public void get_Options(){} // RVA: 0x7ffaa89600c0
        public void get_PackageRegistry(){} // RVA: 0x7ffaa8960130
        public void set_PackageRegistry(){} // RVA: 0x7ffaa8933e90
        public void get_ComponentRegistry(){} // RVA: 0x7ffaa8bfcc80
        public void set_ComponentRegistry(){} // RVA: 0x7ffaa8960890
        public void set_ServiceRegistry(){} // RVA: 0x7ffaa8bf45c0
        public void .ctor(){} // RVA: 0x7ffaaf114060
        public void RegisterPackage(){} // RVA: 0x7ffaa887e5c0
        public void RegisterServiceComponent(){} // RVA: 0x7ffaa887e5c0
        public void LockComponentRegistration(){} // RVA: 0x7ffaaf114370
        // ── Binary Analysis Named ──
        public void GetServiceComponent(){} // RVA: 0x7ffaa887e5c0
    }

    public class CoreRegistryInitializer : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void InitializeRegistryAsync(){} // RVA: 0x7ffaaf114490
    }

    public class DependencyTree : Object
    {
        public object PackageTypeHashToComponentTypeHashDependencies; // 0x3365BA40
        public object 000; // 0x4

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa897aa50
        public void .ctor(){} // RVA: 0x7ffaa897aa50
    }

    public class DependencyTreeExtensions : Object
    {
        // ── Original Methods ──
        public void ToJson(){} // RVA: 0x7ffaaf116310
        public void IsOptional(){} // RVA: 0x7ffaaf116cf0
        public void IsProvided(){} // RVA: 0x7ffaaf116d80
        // ── Binary Analysis Named ──
        public void GetPackageJObject(){} // RVA: 0x7ffaaf116e00
        public void GetComponentJObject(){} // RVA: 0x7ffaaf117750
        public void GetComponentIdentifier(){} // RVA: 0x7ffaaf117cc0
    }

    public class DependencyTreeInitializeOrderSorter : ValueType
    {
        public object m_PackageTypeHashExplorationHistory; // 0x336F4A50

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf117d90
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x7ffaaf117e90
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x7ffaaf118290
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x7ffaaf1184a0
        public void SortTreeThrough(){} // RVA: 0x7ffaaf118920
        public void SortTreeThrough(){} // RVA: 0x7ffaaf118920
        public void MarkPackage(){} // RVA: 0x7ffaaf118b00
        // ── Binary Analysis Named ──
        public void GetPackageTypeHashes(){} // RVA: 0x7ffaaf118b90
        public void GetPackageTypeHashFor(){} // RVA: 0x7ffaaf118bf0
        public void GetDependencyTypeHashesFor(){} // RVA: 0x7ffaaf118d10
    }

    public class DependencyTreeSortFailedException : Exception
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1160f0
        public void CreateExceptionMessage(){} // RVA: 0x7ffaaf116230
    }

    public class DictionaryExtensions : Object
    {
        // ── Original Methods ──
        public void MergeAllowOverride(){} // RVA: 0x7ffaa887e5c0
        public void ValueEquals(){} // RVA: 0x7ffaa887e5c0
        public void ValueEquals(){} // RVA: 0x7ffaa887e5c0
    }

    public class HashException : Exception
    {
        // ── Original Methods ──
        public void get_Hash(){} // RVA: 0x7ffaa8c4abe0
        public void .ctor(){} // RVA: 0x7ffaaf118e70
        public void .ctor(){} // RVA: 0x7ffaaf118e70
    }

    public class IComponentRegistry
    {
        // ── Original Methods ──
        public void RegisterServiceComponent(){} // RVA: 0x7ffaa887e5c0
        public void ResetProvidedComponents(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetServiceComponent(){} // RVA: 0x7ffaa887e5c0
    }

    public class IInitializablePackage
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8649280
    }

    public class IInitializablePackageV2
    {
        // ── Original Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0x7ffaa8649280
    }

    public class IPackageRegistry
    {
        // ── Original Methods ──
        public void get_Tree(){} // RVA: 0x7ffaa86491d0
        public void RegisterPackage(){} // RVA: 0x7ffaa887e5c0
        public void RegisterDependency(){} // RVA: 0x7ffaa8661210
        public void RegisterOptionalDependency(){} // RVA: 0x7ffaa8661210
        public void RegisterProvision(){} // RVA: 0x7ffaa8661210
    }

    public class IServiceComponent
    {
    }

    public class IServiceRegistry
    {
    }

    public class LockedComponentRegistry : Object
    {
        // ── Original Methods ──
        public void get_Registry(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void RegisterServiceComponent(){} // RVA: 0x7ffaa887e5c0
        public void ResetProvidedComponents(){} // RVA: 0x7ffaaf113c10
        // ── Binary Analysis Named ──
        public void GetServiceComponent(){} // RVA: 0x7ffaa887e5c0
    }

    public class LockedPackageRegistry : Object
    {
        // ── Original Methods ──
        public void get_Registry(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_Tree(){} // RVA: 0x7ffaaf118f00
        public void RegisterPackage(){} // RVA: 0x7ffaa887e5c0
        public void RegisterDependency(){} // RVA: 0x7ffaa8661210
        public void RegisterOptionalDependency(){} // RVA: 0x7ffaa8661210
        public void RegisterProvision(){} // RVA: 0x7ffaa8661210
    }

    public class MissingComponent : Object
    {
        // ── Original Methods ──
        public void get_IntendedType(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class PackageInitializationInfo : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class PackageRegistry : Object
    {
        // ── Original Methods ──
        public void get_Tree(){} // RVA: 0x7ffaa894d380
        public void set_Tree(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void RegisterPackage(){} // RVA: 0x7ffaa887e5c0
        public void RegisterDependency(){} // RVA: 0x7ffaa8661210
        public void RegisterOptionalDependency(){} // RVA: 0x7ffaa8661210
        public void RegisterProvision(){} // RVA: 0x7ffaa8661210
        public void AddComponentDependencyToPackage(){} // RVA: 0x7ffaaf118f50
    }

    public class ServiceRegistry : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1190a0
    }

    public class TaskAsyncOperation : AsyncOperationBase
    {
        // ── Original Methods ──
        public void get_IsCompleted(){} // RVA: 0x7ffaa9e7a500
        // ── Binary Analysis Named ──
        public void SetScheduler(){} // RVA: 0x7ffaaf113670
    }

    public class UnityServicesInitializer : Object
    {
        // ── Original Methods ──
        public void CreateStaticInstance(){} // RVA: 0x7ffaaf119460
        public void EnableServicesInitializationAsync(){} // RVA: 0x7ffaaf119c20
    }

    public class UnityServicesInternal : Object
    {
        public object m_Initialization; // 0x33894CC0
        public object _diagnostics; // 0x33894CC0, was: <Diagnostics>k__BackingField
        public object State; // 0x17000018
        public object Registry; // 0x17000019

        // ── Original Methods ──
        public void get_State(){} // RVA: 0x7ffaa897f5c0
        public void set_State(){} // RVA: 0x7ffaa89350c0
        public void get_Registry(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaaf11a1b0
        public void HasRequestedInitialization(){} // RVA: 0x7ffaadc8c180
        public void InitializeServicesAsync(){} // RVA: 0x7ffaaf11a2b0
        public void EnableInitializationAsync(){} // RVA: 0x7ffaaf11a460
    }

}