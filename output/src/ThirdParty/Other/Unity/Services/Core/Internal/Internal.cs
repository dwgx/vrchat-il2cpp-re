// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 31
// Methods: 118

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase : CustomYieldInstruction
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x79A39A0
        public void get_IsCompleted(){} // RVA: 0x87D280
    }

    public class CircularDependencyException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A2680
    }

    public class ComponentRegistry : Object
    {
        public object _componentTypeHashToInstance;

        // ── Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x79A3D40
        public void RegisterServiceComponent(){} // RVA: 0xA94080
        public void GetServiceComponent(){} // RVA: 0xA94080
        public void IsComponentTypeRegistered(){} // RVA: 0x79A3E00
        public void ResetProvidedComponents(){} // RVA: 0x79A3EF0
    }

    public class CoreDiagnostics : Object
    {
        public object _instance;
        public object _coreTags;
        public object _diagnosticsComponentProvider;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x79A94E0
        public void set_Instance(){} // RVA: 0x79A9520
        public void set_DiagnosticsComponentProvider(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x79A95C0
    }

    public class CoreLogger : Object
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x79A3A90
        public void LogError(){} // RVA: 0x79A3B70
        public void LogException(){} // RVA: 0x79A3C50
    }

    public class CoreMetrics : Object
    {
        public object _instance;
        public object _allPackageMetrics;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x79A9680
        public void set_Instance(){} // RVA: 0x79A96C0
        public void .ctor(){} // RVA: 0x79A9760
    }

    public class CorePackageRegistry : Object
    {
        public object _instance;
        public object _registry;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x79A3FC0
        public void set_Instance(){} // RVA: 0x79A4000
        public void get_Registry(){} // RVA: 0xB5DBF0
        public void set_Registry(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x79A40A0
        public void Register(){} // RVA: 0x303A440
        public void Lock(){} // RVA: 0x79A41C0
    }

    public class CoreRegistration : ValueType
    {
        public object m_Registry;
        public object m_PackageHash;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28E70
        public void DependsOn(){} // RVA: 0x1F21A0
        public void OptionallyDependsOn(){} // RVA: 0x1F21A0
        public void ProvidesComponent(){} // RVA: 0x1F21A0
    }

    public class CoreRegistry : Object
    {
        public object _instance;
        public object _instanceId;
        public object _type;
        public object _options;
        public object _packageRegistry;
        public object _componentRegistry;
        public object _serviceRegistry;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x79A42E0
        public void set_Instance(){} // RVA: 0x79A4320
        public void get_Type(){} // RVA: 0xE62D00
        public void set_Type(){} // RVA: 0x1033F40
        public void get_Options(){} // RVA: 0xB700F0
        public void get_PackageRegistry(){} // RVA: 0xB70160
        public void set_PackageRegistry(){} // RVA: 0xB44DC0
        public void get_ComponentRegistry(){} // RVA: 0xD33E60
        public void set_ComponentRegistry(){} // RVA: 0xB708C0
        public void set_ServiceRegistry(){} // RVA: 0xD09D70
        public void .ctor(){} // RVA: 0x79A43C0
        public void RegisterPackage(){} // RVA: 0x303A710
        public void RegisterServiceComponent(){} // RVA: 0xA94080
        public void GetServiceComponent(){} // RVA: 0xA94080
        public void LockComponentRegistration(){} // RVA: 0x79A46F0
    }

    public class CoreRegistryInitializer : Object
    {
        public object m_Registry;
        public object m_SortedPackageTypeHashes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void InitializeRegistryAsync(){} // RVA: 0x79A4810
    }

    public class DependencyTree : Object
    {
        public object PackageTypeHashToInstance;
        public object ComponentTypeHashToPackageTypeHash;
        public object PackageTypeHashToComponentTypeHashDependencies;
        public object ComponentTypeHashToInstance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB8AE10
    }

    public class DependencyTreeComponentHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A9190
    }

    public class DependencyTreeExtensions : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x79A6680
        public void IsOptional(){} // RVA: 0x79A7040
        public void IsProvided(){} // RVA: 0x79A70D0
        public void GetPackageJObject(){} // RVA: 0x79A7150
        public void GetComponentJObject(){} // RVA: 0x79A7AA0
        public void GetComponentIdentifier(){} // RVA: 0x79A8000
    }

    public class DependencyTreeInitializeOrderSorter : ValueType
    {
        public object Tree;
        public object Target;
        public object m_PackageTypeHashExplorationHistory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x940E80
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x940E90
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x940EA0
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x940EB0
        public void SortTreeThrough(){} // RVA: 0x940ED0
        public void MarkPackage(){} // RVA: 0x940EE0
        public void GetPackageTypeHashes(){} // RVA: 0x940EF0
        public void GetPackageTypeHashFor(){} // RVA: 0x940F50
        public void GetDependencyTypeHashesFor(){} // RVA: 0x940F60
    }

    public class DependencyTreePackageHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A91F0
    }

    public class DependencyTreeSortFailedException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A6480
        public void CreateExceptionMessage(){} // RVA: 0x79A65B0
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void MergeAllowOverride(){} // RVA: 0xA94080
        public void ValueEquals(){} // RVA: 0xA94080
    }

    public class HashException : Exception
    {
        public object _hash;

        // ── Methods ──
        public void get_Hash(){} // RVA: 0xF3A950
        public void .ctor(){} // RVA: 0x79A91F0
    }

    public class IComponentRegistry
    {
        // ── Methods ──
        public void RegisterServiceComponent(){} // RVA: 0xA94080
        public void GetServiceComponent(){} // RVA: 0xA94080
        public void ResetProvidedComponents(){} // RVA: 0x894320
    }

    public class IInitializablePackage
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x87C540
    }

    public class IInitializablePackageV2
    {
        // ── Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0x87C540
    }

    public class IPackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x87C0A0
        public void RegisterPackage(){} // RVA: 0x87BF80
        public void RegisterDependency(){} // RVA: 0x8944F0
        public void RegisterOptionalDependency(){} // RVA: 0x8944F0
        public void RegisterProvision(){} // RVA: 0x8944F0
    }

    public class LockedComponentRegistry : Object
    {
        public object _registry;

        // ── Methods ──
        public void get_Registry(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
        public void RegisterServiceComponent(){} // RVA: 0xA94080
        public void GetServiceComponent(){} // RVA: 0xA94080
        public void ResetProvidedComponents(){} // RVA: 0x79A3F70
    }

    public class LockedPackageRegistry : Object
    {
        public object _registry;

        // ── Methods ──
        public void get_Registry(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Tree(){} // RVA: 0x79A9280
        public void RegisterPackage(){} // RVA: 0xA94080
        public void RegisterDependency(){} // RVA: 0x8944F0
        public void RegisterOptionalDependency(){} // RVA: 0x8944F0
        public void RegisterProvision(){} // RVA: 0x8944F0
    }

    public class MissingComponent : Object
    {
        public object _intendedType;

        // ── Methods ──
        public void get_IntendedType(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class PackageInitializationInfo : Object
    {
        public object PackageType;
        public object InitializationTimeInSeconds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PackageRegistry : Object
    {
        public object _tree;

        // ── Methods ──
        public void get_Tree(){} // RVA: 0xB5DBF0
        public void set_Tree(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB44D60
        public void RegisterPackage(){} // RVA: 0x317BF70
        public void RegisterDependency(){} // RVA: 0x317BC60
        public void RegisterOptionalDependency(){} // RVA: 0x317BE10
        public void RegisterProvision(){} // RVA: 0x317C410
        public void AddComponentDependencyToPackage(){} // RVA: 0x79A92D0
    }

    public class ServiceRegistry : Object
    {
        public object _serviceTypeHashToInstance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A9420
    }

    public class TaskAsyncOperation : AsyncOperationBase
    {
        public object Scheduler;
        public object m_Task;

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x2283E50
        public void SetScheduler(){} // RVA: 0x79A39D0
    }

    public class UnityServicesInitializer : Object
    {
        // ── Methods ──
        public void CreateStaticInstance(){} // RVA: 0x79A9820
        public void EnableServicesInitializationAsync(){} // RVA: 0x79AA160
        public void CreateInstance(){} // RVA: 0x79AA2C0
    }

    public class UnityServicesInternal : Object
    {
        public object _state;
        public object CanInitialize;
        public object m_Initialization;
        public object _registry;
        public object _metrics;
        public object _diagnostics;

        // ── Methods ──
        public void get_State(){} // RVA: 0xB8F8F0
        public void set_State(){} // RVA: 0xB460A0
        public void get_Registry(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x79AA870
        public void HasRequestedInitialization(){} // RVA: 0x654E320
        public void InitializeServicesAsync(){} // RVA: 0x79AA970
        public void EnableInitialization(){} // RVA: 0x1AEDC60
        public void EnableInitializationAsync(){} // RVA: 0x79AAB20
    }

}