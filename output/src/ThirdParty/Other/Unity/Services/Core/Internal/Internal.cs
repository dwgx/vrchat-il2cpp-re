// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 33
// Methods: 120

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase : CustomYieldInstruction
    {
        public object keepWaiting;
        public object IsCompleted;

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFAC96F1660
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
    }

    public class CircularDependencyException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F0660
    }

    public class ComponentRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<int,Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance; // 0x10

        // ── Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC96F1A00
        public void RegisterServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void GetServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void IsComponentTypeRegistered(){} // RVA: 0x7FFAC96F1AC0
        public void ResetProvidedComponents(){} // RVA: 0x7FFAC96F1BB0
    }

    public class CoreDiagnostics : Object
    {
        public Unity.Services.Core.Internal.CoreDiagnostics Instance;
        public System.Collections.Generic.IDictionary`2<string,string> DiagnosticsComponentProvider; // 0x10
        public Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC96F7180
        public void set_Instance(){} // RVA: 0x7FFAC96F71C0
        public void set_DiagnosticsComponentProvider(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC96F7260
    }

    public class CoreLogger : Object
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7FFAC96F1750
        public void LogError(){} // RVA: 0x7FFAC96F1830
        public void LogException(){} // RVA: 0x7FFAC96F1910
    }

    public class CoreMetrics : Object
    {
        public Unity.Services.Core.Internal.CoreMetrics Instance;
        public System.Collections.Generic.IDictionary`2<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField; // 0x10

        // ── Methods ──
        public void set_Instance(){} // RVA: 0x7FFAC96F7320
        public void .ctor(){} // RVA: 0x7FFAC96F73C0
    }

    public class CorePackageRegistry : Object
    {
        public Unity.Services.Core.Internal.CorePackageRegistry Instance;
        public Unity.Services.Core.Internal.IPackageRegistry Registry; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC96F1C80
        public void set_Instance(){} // RVA: 0x7FFAC96F1CC0
        public void get_Registry(){} // RVA: 0x7FFAC2F3C380
        public void set_Registry(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC96F1D60
        public void Register(){} // RVA: 0x7FFAC2E8DC40
        public void Lock(){} // RVA: 0x7FFAC96F1E80
    }

    public class CoreRegistration : ValueType
    {
        public Unity.Services.Core.Internal.IPackageRegistry m_Registry; // 0x10
        public int m_PackageHash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC335C3C0
        public void DependsOn(){} // RVA: 0x7FFAC2E8DC40
        public void OptionallyDependsOn(){} // RVA: 0x7FFAC2E8DC40
        public void ProvidesComponent(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CoreRegistry : Object
    {
        public Unity.Services.Core.Internal.CoreRegistry Instance;
        public string Type; // 0x10
        public 0x6B2E4DC0 Options; // 0x18
        public Unity.Services.Core.InitializationOptions PackageRegistry; // 0x20
        public Unity.Services.Core.Internal.IPackageRegistry ComponentRegistry; // 0x28
        public Unity.Services.Core.Internal.IComponentRegistry ServiceRegistry; // 0x30
        public Unity.Services.Core.Internal.IServiceRegistry <ServiceRegistry>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC96F1FA0
        public void set_Instance(){} // RVA: 0x7FFAC96F1FE0
        public void get_Type(){} // RVA: 0x7FFAC3157800
        public void set_Type(){} // RVA: 0x7FFAC392CD10
        public void get_Options(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PackageRegistry(){} // RVA: 0x7FFAC2F4F130
        public void set_PackageRegistry(){} // RVA: 0x7FFAC2F22E90
        public void get_ComponentRegistry(){} // RVA: 0x7FFAC31D95E0
        public void set_ComponentRegistry(){} // RVA: 0x7FFAC2F4F890
        public void set_ServiceRegistry(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFAC96F2080
        public void RegisterPackage(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void GetServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void LockComponentRegistration(){} // RVA: 0x7FFAC96F2390
    }

    public class CoreRegistryInitializer : Object
    {
        public Unity.Services.Core.Internal.CoreRegistry m_Registry; // 0x10
        public System.Collections.Generic.List`1<int> m_SortedPackageTypeHashes; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void InitializeRegistryAsync(){} // RVA: 0x7FFAC96F24B0
    }

    public class DependencyTree : Object
    {
        public System.Collections.Generic.Dictionary`2<int,Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance; // 0x10
        public System.Collections.Generic.Dictionary`2<int,int> ComponentTypeHashToPackageTypeHash; // 0x18
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<int>> PackageTypeHashToComponentTypeHashDependencies; // 0x20
        public System.Collections.Generic.Dictionary`2<int,Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F69A50 | overloaded x2
    }

    public class DependencyTreeComponentHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F6E30
    }

    public class DependencyTreeExtensions : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7FFAC96F4330
        public void IsOptional(){} // RVA: 0x7FFAC96F4D10
        public void IsProvided(){} // RVA: 0x7FFAC96F4DA0
        public void GetPackageJObject(){} // RVA: 0x7FFAC96F4E20
        public void GetComponentJObject(){} // RVA: 0x7FFAC96F5770
        public void GetComponentIdentifier(){} // RVA: 0x7FFAC96F5CE0
    }

    public class DependencyTreeInitializeOrderSorter : ValueType
    {
        public Unity.Services.Core.Internal.DependencyTree Tree; // 0x10
        public System.Collections.Generic.ICollection`1<int> Target; // 0x18
        public System.Collections.Generic.Dictionary`2<int,0x6B2CD500> m_PackageTypeHashExplorationHistory; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F5DB0
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x7FFAC96F5EB0
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x7FFAC96F62B0
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x7FFAC96F64C0
        public void SortTreeThrough(){} // RVA: 0x7FFAC96F6940 | overloaded x2
        public void MarkPackage(){} // RVA: 0x7FFAC96F6B20
        public void GetPackageTypeHashes(){} // RVA: 0x7FFAC96F6BB0
        public void GetPackageTypeHashFor(){} // RVA: 0x7FFAC96F6C10
        public void GetDependencyTypeHashesFor(){} // RVA: 0x7FFAC96F6D30
    }

    public class DependencyTreePackageHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F6E90 | overloaded x2
    }

    public class DependencyTreeSortFailedException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F4110
        public void CreateExceptionMessage(){} // RVA: 0x7FFAC96F4250
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void MergeAllowOverride(){} // RVA: 0x7FFAC2E8DC40
        public void ValueEquals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class HashException : Exception
    {
        public int Hash; // 0x90

        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7FFAC3220660
        public void .ctor(){} // RVA: 0x7FFAC96F6E90 | overloaded x2
    }

    public class IComponentRegistry
    {
        // ── Methods ──
        public void RegisterServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void GetServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void ResetProvidedComponents(){} // RVA: 0x7FFAC2C70A40
    }

    public class IInitializablePackage
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC2C58F40
    }

    public class IInitializablePackageV2
    {
        // ── Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0x7FFAC2C58F40
    }

    public class IPackageRegistry
    {
        public object Tree;

        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7FFAC2C58E90
        public void RegisterPackage(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterDependency(){} // RVA: 0x7FFAC2C70ED0
        public void RegisterOptionalDependency(){} // RVA: 0x7FFAC2C70ED0
        public void RegisterProvision(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IServiceComponent
    {
    }

    public class IServiceRegistry
    {
    }

    public class LockedComponentRegistry : Object
    {
        public Unity.Services.Core.Internal.IComponentRegistry Registry; // 0x10

        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void RegisterServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void GetServiceComponent(){} // RVA: 0x7FFAC2E8DC40
        public void ResetProvidedComponents(){} // RVA: 0x7FFAC96F1C30
    }

    public class LockedPackageRegistry : Object
    {
        public Unity.Services.Core.Internal.IPackageRegistry Registry; // 0x10

        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Tree(){} // RVA: 0x7FFAC96F6F20
        public void RegisterPackage(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterDependency(){} // RVA: 0x7FFAC2C70ED0
        public void RegisterOptionalDependency(){} // RVA: 0x7FFAC2C70ED0
        public void RegisterProvision(){} // RVA: 0x7FFAC2C70ED0
    }

    public class MissingComponent : Object
    {
        public System.Type IntendedType; // 0x10

        // ── Methods ──
        public void get_IntendedType(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class PackageInitializationInfo : Object
    {
        public System.Type PackageType; // 0x10
        public double InitializationTimeInSeconds; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PackageRegistry : Object
    {
        public Unity.Services.Core.Internal.DependencyTree Tree; // 0x10

        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7FFAC2F3C380
        public void set_Tree(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void RegisterPackage(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterDependency(){} // RVA: 0x7FFAC2C70ED0
        public void RegisterOptionalDependency(){} // RVA: 0x7FFAC2C70ED0
        public void RegisterProvision(){} // RVA: 0x7FFAC2C70ED0
        public void AddComponentDependencyToPackage(){} // RVA: 0x7FFAC96F6F70
    }

    public class ServiceRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<int,object> <ServiceTypeHashToInstance>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F70C0
    }

    public class TaskAsyncOperation : AsyncOperationBase
    {
        public System.Threading.Tasks.TaskScheduler IsCompleted;
        public System.Threading.Tasks.Task m_Task; // 0x10

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFAC4458C20
        public void SetScheduler(){} // RVA: 0x7FFAC96F1690
    }

    public class UnityServicesInitializer : Object
    {
        // ── Methods ──
        public void CreateStaticInstance(){} // RVA: 0x7FFAC96F7480
        public void EnableServicesInitializationAsync(){} // RVA: 0x7FFAC96F7C40
    }

    public class UnityServicesInternal : Object
    {
        public 0x6B2E4CB8 State; // 0x10
        public bool Registry; // 0x14
        public System.Threading.Tasks.TaskCompletionSource`1<object> m_Initialization; // 0x18
        public Unity.Services.Core.Internal.CoreRegistry <Registry>k__BackingField; // 0x20
        public Unity.Services.Core.Internal.CoreMetrics <Metrics>k__BackingField; // 0x28
        public Unity.Services.Core.Internal.CoreDiagnostics <Diagnostics>k__BackingField; // 0x30

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC2F6E5C0
        public void set_State(){} // RVA: 0x7FFAC2F240C0
        public void get_Registry(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC96F81D0
        public void HasRequestedInitialization(){} // RVA: 0x7FFAC826AFD0
        public void InitializeServicesAsync(){} // RVA: 0x7FFAC96F82D0
        public void EnableInitializationAsync(){} // RVA: 0x7FFAC96F8480
    }

}