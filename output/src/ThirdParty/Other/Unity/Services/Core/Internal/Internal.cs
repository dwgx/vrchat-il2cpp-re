// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 33
// Methods: 120

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x6F58D40
        public void get_IsCompleted(){} // RVA: 0xDBE0
    }

    public class CircularDependencyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F57D40
    }

    public class ComponentRegistry
    {
        // ── Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x6F590E0
        public void RegisterServiceComponent(){} // RVA: 0x283FA0
        public void GetServiceComponent(){} // RVA: 0x283FA0
        public void IsComponentTypeRegistered(){} // RVA: 0x6F591A0
        public void ResetProvidedComponents(){} // RVA: 0x6F59290
    }

    public class CoreDiagnostics
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6F5E860
        public void set_Instance(){} // RVA: 0x6F5E8A0
        public void set_DiagnosticsComponentProvider(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x6F5E940
    }

    public class CoreLogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x6F58E30
        public void LogError(){} // RVA: 0x6F58F10
        public void LogException(){} // RVA: 0x6F58FF0
    }

    public class CoreMetrics
    {
        // ── Methods ──
        public void set_Instance(){} // RVA: 0x6F5EA00
        public void .ctor(){} // RVA: 0x6F5EAA0
    }

    public class CorePackageRegistry
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6F59360
        public void set_Instance(){} // RVA: 0x6F593A0
        public void get_Registry(){} // RVA: 0x2F8380
        public void set_Registry(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x6F59440
        public void Register(){} // RVA: 0x283FA0
        public void Lock(){} // RVA: 0x6F59560
    }

    public class CoreRegistration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x820840
        public void DependsOn(){} // RVA: 0x283FA0
        public void OptionallyDependsOn(){} // RVA: 0x283FA0
        public void ProvidesComponent(){} // RVA: 0x283FA0
    }

    public class CoreRegistry
    {
        public object format;
        public object isReadable;
        public object streamingMipmaps;
        public object streamingMipmapsPriority;
        public object requestedMipmapLevel;
        public object desiredMipmapLevel;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6F59680
        public void set_Instance(){} // RVA: 0x6F596C0
        public void get_Type(){} // RVA: 0x5BED50
        public void set_Type(){} // RVA: 0x6374E0
        public void get_Options(){} // RVA: 0x30B0C0
        public void get_PackageRegistry(){} // RVA: 0x30B130
        public void set_PackageRegistry(){} // RVA: 0x2DEE90
        public void get_ComponentRegistry(){} // RVA: 0x6374D0
        public void set_ComponentRegistry(){} // RVA: 0x30B890
        public void set_ServiceRegistry(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x6F59760
        public void RegisterPackage(){} // RVA: 0x283FA0
        public void RegisterServiceComponent(){} // RVA: 0x283FA0
        public void GetServiceComponent(){} // RVA: 0x283FA0
        public void LockComponentRegistration(){} // RVA: 0x6F59A70
    }

    public class CoreRegistryInitializer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void InitializeRegistryAsync(){} // RVA: 0x6F59B90
    }

    public class DependencyTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x325A50 | overloaded x2
    }

    public class DependencyTreeComponentHashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5E510
    }

    public class DependencyTreeExtensions
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x6F5BA10
        public void IsOptional(){} // RVA: 0x6F5C3F0
        public void IsProvided(){} // RVA: 0x6F5C480
        public void GetPackageJObject(){} // RVA: 0x6F5C500
        public void GetComponentJObject(){} // RVA: 0x6F5CE50
        public void GetComponentIdentifier(){} // RVA: 0x6F5D3C0
    }

    public class DependencyTreeInitializeOrderSorter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5D490
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x6F5D590
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x6F5D990
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x6F5DBA0
        public void SortTreeThrough(){} // RVA: 0x6F5E020 | overloaded x2
        public void MarkPackage(){} // RVA: 0x6F5E200
        public void GetPackageTypeHashes(){} // RVA: 0x6F5E290
        public void GetPackageTypeHashFor(){} // RVA: 0x6F5E2F0
        public void GetDependencyTypeHashesFor(){} // RVA: 0x6F5E410
    }

    public class DependencyTreePackageHashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5E570 | overloaded x2
    }

    public class DependencyTreeSortFailedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5B7F0
        public void CreateExceptionMessage(){} // RVA: 0x6F5B930
    }

    public class DictionaryExtensions
    {
        // ── Methods ──
        public void MergeAllowOverride(){} // RVA: 0x283FA0
        public void ValueEquals(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class HashException
    {
        // ── Methods ──
        public void get_Hash(){} // RVA: 0x6AFD40
        public void .ctor(){} // RVA: 0x6F5E570 | overloaded x2
    }

    public class IComponentRegistry
    {
        // ── Methods ──
        public void RegisterServiceComponent(){} // RVA: 0x283FA0
        public void GetServiceComponent(){} // RVA: 0x283FA0
        public void ResetProvidedComponents(){} // RVA: 0x24B10
    }

    public class IInitializablePackage
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0xCE10
    }

    public class IInitializablePackageV2
    {
        // ── Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0xCE10
    }

    public class IPackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0xCD60
        public void RegisterPackage(){} // RVA: 0x283FA0
        public void RegisterDependency(){} // RVA: 0x24FA0
        public void RegisterOptionalDependency(){} // RVA: 0x24FA0
        public void RegisterProvision(){} // RVA: 0x24FA0
    }

    public class IServiceComponent
    {
    }

    public class IServiceRegistry
    {
    }

    public class LockedComponentRegistry
    {
        // ── Methods ──
        public void get_Registry(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
        public void RegisterServiceComponent(){} // RVA: 0x283FA0
        public void GetServiceComponent(){} // RVA: 0x283FA0
        public void ResetProvidedComponents(){} // RVA: 0x6F59310
    }

    public class LockedPackageRegistry
    {
        // ── Methods ──
        public void get_Registry(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Tree(){} // RVA: 0x6F5E600
        public void RegisterPackage(){} // RVA: 0x283FA0
        public void RegisterDependency(){} // RVA: 0x24FA0
        public void RegisterOptionalDependency(){} // RVA: 0x24FA0
        public void RegisterProvision(){} // RVA: 0x24FA0
    }

    public class MissingComponent
    {
        // ── Methods ──
        public void get_IntendedType(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class PackageInitializationInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x2F8380
        public void set_Tree(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DEE30
        public void RegisterPackage(){} // RVA: 0x283FA0
        public void RegisterDependency(){} // RVA: 0x24FA0
        public void RegisterOptionalDependency(){} // RVA: 0x24FA0
        public void RegisterProvision(){} // RVA: 0x24FA0
        public void AddComponentDependencyToPackage(){} // RVA: 0x6F5E650
    }

    public class ServiceRegistry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5E7A0
    }

    public class TaskAsyncOperation
    {
        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x199D670
        public void SetScheduler(){} // RVA: 0x6F58D70
    }

    public class UnityServicesInitializer
    {
        // ── Methods ──
        public void CreateStaticInstance(){} // RVA: 0x6F5EB60
        public void EnableServicesInitializationAsync(){} // RVA: 0x6F5F320
    }

    public class UnityServicesInternal
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x32A5C0
        public void set_State(){} // RVA: 0x2E00C0
        public void get_Registry(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x6F5F8B0
        public void HasRequestedInitialization(){} // RVA: 0x5AD3AC0
        public void InitializeServicesAsync(){} // RVA: 0x6F5F9B0
        public void EnableInitializationAsync(){} // RVA: 0x6F5FB60
    }

}