// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Internal
// Classes: 33
// Methods: 120

namespace ThirdParty.Other.Unity.Services.Core.Internal
{
    public class AsyncOperationBase : CustomYieldInstruction
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFE87A99BD0
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
    }

    public class CircularDependencyException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A98BD0
    }

    public class ComponentRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<int,Unity.Services.Core.Internal.IServiceComponent> _componentTypeHashToInstance; // 0x10

        // ── Methods ──
        public void get_ComponentTypeHashToInstance(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE87A99F70
        public void RegisterServiceComponent(){} // RVA: 0x7FFE810A1420
        public void GetServiceComponent(){} // RVA: 0x7FFE810A1420
        public void IsComponentTypeRegistered(){} // RVA: 0x7FFE87A9A030
        public void ResetProvidedComponents(){} // RVA: 0x7FFE87A9A120
    }

    public class CoreDiagnostics : Object
    {
        public Unity.Services.Core.Internal.CoreDiagnostics _instance;
        public System.Collections.Generic.IDictionary`2<string,string> _coreTags; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE87A9F6F0
        public void set_Instance(){} // RVA: 0x7FFE87A9F730
        public void set_DiagnosticsComponentProvider(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE87A9F7D0
    }

    public class CoreLogger : Object
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7FFE87A99CC0
        public void LogError(){} // RVA: 0x7FFE87A99DA0
        public void LogException(){} // RVA: 0x7FFE87A99E80
    }

    public class CoreMetrics : Object
    {
        public Unity.Services.Core.Internal.CoreMetrics _instance;

        // ── Methods ──
        public void set_Instance(){} // RVA: 0x7FFE87A9F890
        public void .ctor(){} // RVA: 0x7FFE87A9F930
    }

    public class CorePackageRegistry : Object
    {
        public Unity.Services.Core.Internal.CorePackageRegistry _instance;
        public Unity.Services.Core.Internal.IPackageRegistry _registry; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE87A9A1F0
        public void set_Instance(){} // RVA: 0x7FFE87A9A230
        public void get_Registry(){} // RVA: 0x7FFE81116380
        public void set_Registry(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE87A9A2D0
        public void Register(){} // RVA: 0x7FFE810A1420
        public void Lock(){} // RVA: 0x7FFE87A9A3F0
    }

    public class CoreRegistration : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815AE520
        public void DependsOn(){} // RVA: 0x7FFE810A1420
        public void OptionallyDependsOn(){} // RVA: 0x7FFE810A1420
        public void ProvidesComponent(){} // RVA: 0x7FFE810A1420
    }

    public class CoreRegistry : Object
    {
        public Unity.Services.Core.Internal.CoreRegistry _instance;
        public string _instanceId; // 0x10
        public 8 _type; // 0x18
        public Unity.Services.Core.InitializationOptions _options; // 0x20
        public Unity.Services.Core.Internal.IPackageRegistry _packageRegistry; // 0x28
        public Unity.Services.Core.Internal.IComponentRegistry _componentRegistry; // 0x30

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE87A9A510
        public void set_Instance(){} // RVA: 0x7FFE87A9A550
        public void get_Type(){} // RVA: 0x7FFE813DB630
        public void set_Type(){} // RVA: 0x7FFE8144DF00
        public void get_Options(){} // RVA: 0x7FFE811290C0
        public void get_PackageRegistry(){} // RVA: 0x7FFE81129130
        public void set_PackageRegistry(){} // RVA: 0x7FFE810FCE90
        public void get_ComponentRegistry(){} // RVA: 0x7FFE8144E200
        public void set_ComponentRegistry(){} // RVA: 0x7FFE81129890
        public void set_ServiceRegistry(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE87A9A5F0
        public void RegisterPackage(){} // RVA: 0x7FFE810A1420
        public void RegisterServiceComponent(){} // RVA: 0x7FFE810A1420
        public void GetServiceComponent(){} // RVA: 0x7FFE810A1420
        public void LockComponentRegistration(){} // RVA: 0x7FFE87A9A900
    }

    public class CoreRegistryInitializer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void InitializeRegistryAsync(){} // RVA: 0x7FFE87A9AA20
    }

    public class DependencyTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81143A50 | overloaded x2
    }

    public class DependencyTreeComponentHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A9F3A0
    }

    public class DependencyTreeExtensions : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7FFE87A9C8A0
        public void IsOptional(){} // RVA: 0x7FFE87A9D280
        public void IsProvided(){} // RVA: 0x7FFE87A9D310
        public void GetPackageJObject(){} // RVA: 0x7FFE87A9D390
        public void GetComponentJObject(){} // RVA: 0x7FFE87A9DCE0
        public void GetComponentIdentifier(){} // RVA: 0x7FFE87A9E250
    }

    public class DependencyTreeInitializeOrderSorter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A9E320
        public void SortRegisteredPackagesIntoTarget(){} // RVA: 0x7FFE87A9E420
        public void RemoveUnprovidedOptionalDependenciesFromTree(){} // RVA: 0x7FFE87A9E820
        public void RemoveUnprovidedOptionalDependencies(){} // RVA: 0x7FFE87A9EA30
        public void SortTreeThrough(){} // RVA: 0x7FFE87A9EEB0 | overloaded x2
        public void MarkPackage(){} // RVA: 0x7FFE87A9F090
        public void GetPackageTypeHashes(){} // RVA: 0x7FFE87A9F120
        public void GetPackageTypeHashFor(){} // RVA: 0x7FFE87A9F180
        public void GetDependencyTypeHashesFor(){} // RVA: 0x7FFE87A9F2A0
    }

    public class DependencyTreePackageHashException : HashException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A9F400 | overloaded x2
    }

    public class DependencyTreeSortFailedException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A9C680
        public void CreateExceptionMessage(){} // RVA: 0x7FFE87A9C7C0
    }

    public class DictionaryExtensions : Object
    {
        // ── Methods ──
        public void MergeAllowOverride(){} // RVA: 0x7FFE810A1420
        public void ValueEquals(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class HashException : Exception
    {
        public int _hash; // 0x90

        // ── Methods ──
        public void get_Hash(){} // RVA: 0x7FFE814AA220
        public void .ctor(){} // RVA: 0x7FFE87A9F400 | overloaded x2
    }

    public class IComponentRegistry
    {
        // ── Methods ──
        public void RegisterServiceComponent(){} // RVA: 0x7FFE810A1420
        public void GetServiceComponent(){} // RVA: 0x7FFE810A1420
        public void ResetProvidedComponents(){} // RVA: 0x7FFE80E460A0
    }

    public class IInitializablePackage
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E2E390
    }

    public class IInitializablePackageV2
    {
        // ── Methods ──
        public void InitializeInstanceAsync(){} // RVA: 0x7FFE80E2E390
    }

    public class IPackageRegistry
    {
        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7FFE80E2E2E0
        public void RegisterPackage(){} // RVA: 0x7FFE810A1420
        public void RegisterDependency(){} // RVA: 0x7FFE80E46530
        public void RegisterOptionalDependency(){} // RVA: 0x7FFE80E46530
        public void RegisterProvision(){} // RVA: 0x7FFE80E46530
    }

    public class IServiceComponent
    {
    }

    public class IServiceRegistry
    {
    }

    public class LockedComponentRegistry : Object
    {
        public Unity.Services.Core.Internal.IComponentRegistry _registry; // 0x10

        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void RegisterServiceComponent(){} // RVA: 0x7FFE810A1420
        public void GetServiceComponent(){} // RVA: 0x7FFE810A1420
        public void ResetProvidedComponents(){} // RVA: 0x7FFE87A9A1A0
    }

    public class LockedPackageRegistry : Object
    {
        public Unity.Services.Core.Internal.IPackageRegistry _registry; // 0x10
        public object field_1; // 0x12

        // ── Methods ──
        public void get_Registry(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Tree(){} // RVA: 0x7FFE87A9F490
        public void RegisterPackage(){} // RVA: 0x7FFE810A1420
        public void RegisterDependency(){} // RVA: 0x7FFE80E46530
        public void RegisterOptionalDependency(){} // RVA: 0x7FFE80E46530
        public void RegisterProvision(){} // RVA: 0x7FFE80E46530
    }

    public class MissingComponent : Object
    {
        public System.Type _intendedType; // 0x10

        // ── Methods ──
        public void get_IntendedType(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class PackageInitializationInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PackageRegistry : Object
    {
        public Unity.Services.Core.Internal.DependencyTree _tree; // 0x10

        // ── Methods ──
        public void get_Tree(){} // RVA: 0x7FFE81116380
        public void set_Tree(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void RegisterPackage(){} // RVA: 0x7FFE810A1420
        public void RegisterDependency(){} // RVA: 0x7FFE80E46530
        public void RegisterOptionalDependency(){} // RVA: 0x7FFE80E46530
        public void RegisterProvision(){} // RVA: 0x7FFE80E46530
        public void AddComponentDependencyToPackage(){} // RVA: 0x7FFE87A9F4E0
    }

    public class ServiceRegistry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A9F630
    }

    public class TaskAsyncOperation : AsyncOperationBase
    {
        public System.Threading.Tasks.TaskScheduler Scheduler;

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFE82749A10
        public void SetScheduler(){} // RVA: 0x7FFE87A99C00
    }

    public class UnityServicesInitializer : Object
    {
        // ── Methods ──
        public void CreateStaticInstance(){} // RVA: 0x7FFE87A9F9F0
        public void EnableServicesInitializationAsync(){} // RVA: 0x7FFE87AA01B0
    }

    public class UnityServicesInternal : Object
    {
        public 0x666E067C _state; // 0x10
        public bool CanInitialize; // 0x14

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE811485C0
        public void set_State(){} // RVA: 0x7FFE810FE0C0
        public void get_Registry(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE87AA0740
        public void HasRequestedInitialization(){} // RVA: 0x7FFE866148F0
        public void InitializeServicesAsync(){} // RVA: 0x7FFE87AA0840
        public void EnableInitializationAsync(){} // RVA: 0x7FFE87AA09F0
    }

}