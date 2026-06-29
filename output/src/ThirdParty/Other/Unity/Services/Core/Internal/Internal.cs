// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 31
// Methods: 119

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase : CustomYieldInstruction
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7AED371B0
        public void get_IsCompleted(){} // RVA: 0x7A7E01900
    }

    public class CircularDependencyException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED36190
    }

    public class ComponentRegistry : Object
    {
        // ── Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AED37550
        public void RegisterServiceComponent(){} // RVA: 0x7A8051B10
        public void GetServiceComponent(){} // RVA: 0x7A8051B10
        public void IsComponentTypeRegistered(){} // RVA: 0x7AED37610
        public void ResetProvidedComponents(){} // RVA: 0x7AED37700
    }

    public class CoreDiagnostics : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AED3CD40
        public void set_Instance(){} // RVA: 0x7AED3CD80
        public void set_DiagnosticsComponentProvider(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AED3CE20
        public void <Instance>k__BackingField(){} // RVA: 0x7B3F6A648
    }

    public class CoreLogger : Object
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7AED372A0
        public void LogError(){} // RVA: 0x7AED37380
        public void LogException(){} // RVA: 0x7AED37460
    }

    public class CoreMetrics : Object
    {
        // ── Methods ──
        public void set_Instance(){} // RVA: 0x7AED3CEE0
        public void .ctor(){} // RVA: 0x7AED3CF80
    }

    public class CorePackageRegistry : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AED377D0
        public void set_Instance(){} // RVA: 0x7AED37810
        public void get_Registry(){} // RVA: 0x7A80F2570
        public void set_Registry(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AED378B0
        public void Register(){} // RVA: 0x7AA4159E0
        public void Lock(){} // RVA: 0x7AED379D0
    }

    public class CoreRegistration : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7613470
        public void DependsOn(){} // RVA: 0x7A77A8B60
        public void OptionallyDependsOn(){} // RVA: 0x7A77A8B60
        public void ProvidesComponent(){} // RVA: 0x7A77A8B60
    }

    public class CoreRegistry : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AED37AF0
        public void set_Instance(){} // RVA: 0x7AED37B30
        public void get_Type(){} // RVA: 0x7A83782A0
        public void set_Type(){} // RVA: 0x7A84385B0
        public void get_Options(){} // RVA: 0x7A81052C0
        public void get_PackageRegistry(){} // RVA: 0x7A8105330
        public void set_PackageRegistry(){} // RVA: 0x7A80D8E80
        public void get_ComponentRegistry(){} // RVA: 0x7A83F69F0
        public void set_ComponentRegistry(){} // RVA: 0x7A8105A90
        public void set_ServiceRegistry(){} // RVA: 0x7A8296DE0
        public void .ctor(){} // RVA: 0x7AED37BD0
        public void RegisterPackage(){} // RVA: 0x7AA415CB0
        public void RegisterServiceComponent(){} // RVA: 0x7A8051B10
        public void GetServiceComponent(){} // RVA: 0x7A8051B10
        public void LockComponentRegistration(){} // RVA: 0x7AED37F00
    }

    public class CoreRegistryInitializer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void InitializeRegistryAsync(){} // RVA: 0x7AED38020
        // ── Unresolved (hash) ──
        public void m_Registry(){} // RVA: 0x7B3F69FD8
    }

    public class DependencyTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811FE30
        public void PackageTypeHashToInstance(){} // RVA: 0x7B2E26F50
    }

    public class DependencyTreeComponentHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED3C9F0
    }

    public class DependencyTreeExtensions : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7AED39EB0
        public void IsOptional(){} // RVA: 0x7AED3A870
        public void IsProvided(){} // RVA: 0x7AED3A900
        public void GetPackageJObject(){} // RVA: 0x7AED3A980
        public void GetComponentJObject(){} // RVA: 0x7AED3B2E0
        public void GetComponentIdentifier(){} // RVA: 0x7AED3B850
    }

    public class DependencyTreeInitializeOrderSorter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EBE5F0
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x7A7EBE600
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x7A7EBE610
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x7A7EBE620
        public void SortTreeThrough(){} // RVA: 0x7A7EBE640
        public void MarkPackage(){} // RVA: 0x7A7EBE650
        public void GetPackageTypeHashes(){} // RVA: 0x7A7EBE660
        public void GetPackageTypeHashFor(){} // RVA: 0x7A7EBE6C0
        public void GetDependencyTypeHashesFor(){} // RVA: 0x7A7EBE6D0
        public void Tree(){} // RVA: 0x7B3FB4328
    }

    public class DependencyTreePackageHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED3CA50
    }

    public class DependencyTreeSortFailedException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED39C90
        public void CreateExceptionMessage(){} // RVA: 0x7AED39DD0
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void MergeAllowOverride(){} // RVA: 0x7A8051B10
        public void ValueEquals(){} // RVA: 0x7A8051B10
    }

    public class HashException : Exception
    {
        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7A846C760
        public void .ctor(){} // RVA: 0x7AED3CA50
    }

    public class IComponentRegistry
    {
        // ── Methods ──
        public void RegisterServiceComponent(){} // RVA: 0x7A8051B10
        public void GetServiceComponent(){} // RVA: 0x7A8051B10
        public void ResetProvidedComponents(){} // RVA: 0x7A7E18800
    }

    public class IInitializablePackage
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7A7E00B20
    }

    public class IInitializablePackageV2
    {
        // ── Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0x7A7E00B20
    }

    public class IPackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7A7E00680
        public void RegisterPackage(){} // RVA: 0x7A7E00560
        public void RegisterDependency(){} // RVA: 0x7A7E189D0
        public void RegisterOptionalDependency(){} // RVA: 0x7A7E189D0
        public void RegisterProvision(){} // RVA: 0x7A7E189D0
    }

    public class LockedComponentRegistry : Object
    {
        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void RegisterServiceComponent(){} // RVA: 0x7A8051B10
        public void GetServiceComponent(){} // RVA: 0x7A8051B10
        public void ResetProvidedComponents(){} // RVA: 0x7AED37780
    }

    public class LockedPackageRegistry : Object
    {
        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Tree(){} // RVA: 0x7AED3CAE0
        public void RegisterPackage(){} // RVA: 0x7A8051B10
        public void RegisterDependency(){} // RVA: 0x7A7E189D0
        public void RegisterOptionalDependency(){} // RVA: 0x7A7E189D0
        public void RegisterProvision(){} // RVA: 0x7A7E189D0
    }

    public class MissingComponent : Object
    {
        // ── Methods ──
        public void get_IntendedType(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class PackageInitializationInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PackageRegistry : Object
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7A80F2570
        public void set_Tree(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void RegisterPackage(){} // RVA: 0x7AA5531F0
        public void RegisterDependency(){} // RVA: 0x7AA552E80
        public void RegisterOptionalDependency(){} // RVA: 0x7AA553060
        public void RegisterProvision(){} // RVA: 0x7AA5536F0
        public void AddComponentDependencyToPackage(){} // RVA: 0x7AED3CB30
    }

    public class ServiceRegistry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED3CC80
    }

    public class TaskAsyncOperation : AsyncOperationBase
    {
        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7A975A090
        public void SetScheduler(){} // RVA: 0x7AED371E0
    }

    public class UnityServicesInitializer : Object
    {
        // ── Methods ──
        public void CreateStaticInstance(){} // RVA: 0x7AED3D040
        public void EnableServicesInitializationAsync(){} // RVA: 0x7AED3D810
    }

    public class UnityServicesInternal : Object
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7A8124910
        public void set_State(){} // RVA: 0x7A80DA0C0
        public void get_Registry(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AED3DDB0
        public void HasRequestedInitialization(){} // RVA: 0x7AD8C1160
        public void InitializeServicesAsync(){} // RVA: 0x7AED3DEB0
        public void EnableInitializationAsync(){} // RVA: 0x7AED3E060
    }

}