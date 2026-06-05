// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 33
// Methods: 120

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFAF9A08D40
        public void get_IsCompleted(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class CircularDependencyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9A07D40
    }

    public class ComponentRegistry
    {
        // ── Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF9A090E0
        public void RegisterServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void GetServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void IsComponentTypeRegistered(){} // RVA: 0x7FFAF9A091A0
        public void ResetProvidedComponents(){} // RVA: 0x7FFAF9A09290
    }

    public class CoreDiagnostics
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF9A0E860
        public void set_Instance(){} // RVA: 0x7FFAF9A0E8A0
        public void set_DiagnosticsComponentProvider(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF9A0E940
    }

    public class CoreLogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7FFAF9A08E30
        public void LogError(){} // RVA: 0x7FFAF9A08F10
        public void LogException(){} // RVA: 0x7FFAF9A08FF0
    }

    public class CoreMetrics
    {
        // ── Methods ──
        public void set_Instance(){} // RVA: 0x7FFAF9A0EA00
        public void .ctor(){} // RVA: 0x7FFAF9A0EAA0
    }

    public class CorePackageRegistry
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF9A09360
        public void set_Instance(){} // RVA: 0x7FFAF9A093A0
        public void get_Registry(){} // RVA: 0x7FFAF2DA8380
        public void set_Registry(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF9A09440
        public void Register(){} // RVA: 0x7FFAF2D33FA0
        public void Lock(){} // RVA: 0x7FFAF9A09560
    }

    public class CoreRegistration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32D0840
        public void DependsOn(){} // RVA: 0x7FFAF2D33FA0
        public void OptionallyDependsOn(){} // RVA: 0x7FFAF2D33FA0
        public void ProvidesComponent(){} // RVA: 0x7FFAF2D33FA0
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
        public void get_Instance(){} // RVA: 0x7FFAF9A09680
        public void set_Instance(){} // RVA: 0x7FFAF9A096C0
        public void get_Type(){} // RVA: 0x7FFAF306ED50
        public void set_Type(){} // RVA: 0x7FFAF30E74E0
        public void get_Options(){} // RVA: 0x7FFAF2DBB0C0
        public void get_PackageRegistry(){} // RVA: 0x7FFAF2DBB130
        public void set_PackageRegistry(){} // RVA: 0x7FFAF2D8EE90
        public void get_ComponentRegistry(){} // RVA: 0x7FFAF30E74D0
        public void set_ComponentRegistry(){} // RVA: 0x7FFAF2DBB890
        public void set_ServiceRegistry(){} // RVA: 0x7FFAF2F4B830
        public void .ctor(){} // RVA: 0x7FFAF9A09760
        public void RegisterPackage(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void GetServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void LockComponentRegistration(){} // RVA: 0x7FFAF9A09A70
    }

    public class CoreRegistryInitializer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void InitializeRegistryAsync(){} // RVA: 0x7FFAF9A09B90
    }

    public class DependencyTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DD5A50 | overloaded x2
    }

    public class DependencyTreeComponentHashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9A0E510
    }

    public class DependencyTreeExtensions
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7FFAF9A0BA10
        public void IsOptional(){} // RVA: 0x7FFAF9A0C3F0
        public void IsProvided(){} // RVA: 0x7FFAF9A0C480
        public void GetPackageJObject(){} // RVA: 0x7FFAF9A0C500
        public void GetComponentJObject(){} // RVA: 0x7FFAF9A0CE50
        public void GetComponentIdentifier(){} // RVA: 0x7FFAF9A0D3C0
    }

    public class DependencyTreeInitializeOrderSorter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9A0D490
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x7FFAF9A0D590
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x7FFAF9A0D990
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x7FFAF9A0DBA0
        public void SortTreeThrough(){} // RVA: 0x7FFAF9A0E020 | overloaded x2
        public void MarkPackage(){} // RVA: 0x7FFAF9A0E200
        public void GetPackageTypeHashes(){} // RVA: 0x7FFAF9A0E290
        public void GetPackageTypeHashFor(){} // RVA: 0x7FFAF9A0E2F0
        public void GetDependencyTypeHashesFor(){} // RVA: 0x7FFAF9A0E410
    }

    public class DependencyTreePackageHashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9A0E570 | overloaded x2
    }

    public class DependencyTreeSortFailedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9A0B7F0
        public void CreateExceptionMessage(){} // RVA: 0x7FFAF9A0B930
    }

    public class DictionaryExtensions
    {
        // ── Methods ──
        public void MergeAllowOverride(){} // RVA: 0x7FFAF2D33FA0
        public void ValueEquals(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
    }

    public class HashException
    {
        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7FFAF315FD40
        public void .ctor(){} // RVA: 0x7FFAF9A0E570 | overloaded x2
    }

    public class IComponentRegistry
    {
        // ── Methods ──
        public void RegisterServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void GetServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void ResetProvidedComponents(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IInitializablePackage
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IInitializablePackageV2
    {
        // ── Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IPackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7FFAF2ABCD60
        public void RegisterPackage(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterDependency(){} // RVA: 0x7FFAF2AD4FA0
        public void RegisterOptionalDependency(){} // RVA: 0x7FFAF2AD4FA0
        public void RegisterProvision(){} // RVA: 0x7FFAF2AD4FA0
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
        public void get_Registry(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void RegisterServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void GetServiceComponent(){} // RVA: 0x7FFAF2D33FA0
        public void ResetProvidedComponents(){} // RVA: 0x7FFAF9A09310
    }

    public class LockedPackageRegistry
    {
        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Tree(){} // RVA: 0x7FFAF9A0E600
        public void RegisterPackage(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterDependency(){} // RVA: 0x7FFAF2AD4FA0
        public void RegisterOptionalDependency(){} // RVA: 0x7FFAF2AD4FA0
        public void RegisterProvision(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class MissingComponent
    {
        // ── Methods ──
        public void get_IntendedType(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class PackageInitializationInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7FFAF2DA8380
        public void set_Tree(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void RegisterPackage(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterDependency(){} // RVA: 0x7FFAF2AD4FA0
        public void RegisterOptionalDependency(){} // RVA: 0x7FFAF2AD4FA0
        public void RegisterProvision(){} // RVA: 0x7FFAF2AD4FA0
        public void AddComponentDependencyToPackage(){} // RVA: 0x7FFAF9A0E650
    }

    public class ServiceRegistry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9A0E7A0
    }

    public class TaskAsyncOperation
    {
        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFAF444D670
        public void SetScheduler(){} // RVA: 0x7FFAF9A08D70
    }

    public class UnityServicesInitializer
    {
        // ── Methods ──
        public void CreateStaticInstance(){} // RVA: 0x7FFAF9A0EB60
        public void EnableServicesInitializationAsync(){} // RVA: 0x7FFAF9A0F320
    }

    public class UnityServicesInternal
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAF2DDA5C0
        public void set_State(){} // RVA: 0x7FFAF2D900C0
        public void get_Registry(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF9A0F8B0
        public void HasRequestedInitialization(){} // RVA: 0x7FFAF8583AC0
        public void InitializeServicesAsync(){} // RVA: 0x7FFAF9A0F9B0
        public void EnableInitializationAsync(){} // RVA: 0x7FFAF9A0FB60
    }

}