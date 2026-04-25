// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 43
// Methods: 397

namespace ThirdParty.DotNet.System
{
    public class AccessViolationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class Action : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class Action`1 : MulticastDelegate
    {
    }

    public class Action`10 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`11 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`12 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`13 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`14 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`15 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`16 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6055630
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class Action`3 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6191B70
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
    }

    public class Action`4 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`5 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`6 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`7 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`8 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Action`9 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Activator : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
    }

    public class AggregateException : Exception
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Exception> InnerExceptions; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8509350 | overloaded x11
        public void GetObjectData(){} // RVA: 0x7FFAC85095E0
        public void GetBaseException(){} // RVA: 0x7FFAC8509890
        public void get_InnerExceptions(){} // RVA: 0x7FFAC32EF640
        public void Flatten(){} // RVA: 0x7FFAC85099A0
        public void get_Message(){} // RVA: 0x7FFAC8509C20
        public void ToString(){} // RVA: 0x7FFAC8509F00
    }

    public class AppContext : Object
    {
        public System.Collections.Generic.Dictionary`2<string,0x6B0C2938> s_switchMap;
        public bool s_defaultsInitialized; // 0x8

        // ── Methods ──
        public void InitializeDefaultSwitchValues(){} // RVA: 0x7FFAC8668240
        public void TryGetSwitch(){} // RVA: 0x7FFAC8668440
        public void .cctor(){} // RVA: 0x7FFAC86689A0
    }

    public class AppContextDefaultValues : Object
    {
        public string SwitchEnforceJapaneseEraYearRanges;
        public string SwitchFormatJapaneseFirstYearAsANumber; // 0x8
        public string SwitchEnforceLegacyJapaneseDateParsing; // 0x10

        // ── Methods ──
        public void PopulateDefaultValues(){} // RVA: 0x7FFAC2F21310
        public void TryGetSwitchOverride(){} // RVA: 0x7FFAC8692DA0
        public void .cctor(){} // RVA: 0x7FFAC8692DB0
    }

    public class AppContextSwitches : Object
    {
        public bool SetActorAsReferenceWhenCopyingClaimsIdentity;
        public bool NoAsyncCurrentCulture; // 0x1
        public bool EnforceJapaneseEraYearRanges; // 0x2
        public bool FormatJapaneseFirstYearAsANumber; // 0x3
        public bool EnforceLegacyJapaneseDateParsing; // 0x4
    }

    public class AppDomain : MarshalByRefObject
    {
        public UIntPtr CurrentDomain; // 0x18
        public string IsHomogenous;
        public System.Collections.Generic.Dictionary`2<string,object> IsFullyTrusted; // 0xFFFF
        public System.Collections.Generic.Dictionary`2<string,object> assembly_resolve_in_progress; // 0xFFFF
        public System.Collections.Generic.Dictionary`2<string,object> assembly_resolve_in_progress_refonly; // 0xFFFF
        public object _evidence; // 0x20
        public object _granted; // 0x28
        public int _principalPolicy; // 0x30
        public System.AssemblyLoadEventHandler AssemblyLoad; // 0x38
        public System.ResolveEventHandler AssemblyResolve; // 0x40
        public System.EventHandler DomainUnload; // 0x48
        public System.EventHandler ProcessExit; // 0x50
        public System.ResolveEventHandler ResourceResolve; // 0x58
        public System.ResolveEventHandler TypeResolve; // 0x60
        public System.UnhandledExceptionEventHandler UnhandledException; // 0x68
        public System.EventHandler`1<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
        public object _domain_manager; // 0x78
        public System.ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
        public object _activation; // 0x88
        public object _applicationIdentity; // 0x90
        public System.Collections.Generic.List`1<string> compatibility_switch; // 0x98

        // ── Methods ──
        public void IsAppXModel(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void getFriendlyName(){} // RVA: 0x7FFAC8692F60
        public void getCurDomain(){} // RVA: 0x7FFAC8692F80
        public void get_CurrentDomain(){} // RVA: 0x7FFAC8692F80
        public void GetAssemblies(){} // RVA: 0x7FFAC8693100 | overloaded x2
        public void GetData(){} // RVA: 0x7FFAC8693240
        public void InitializeLifetimeService(){} // RVA: 0x7FFAC34F9180
        public void LoadAssembly(){} // RVA: 0x7FFAC86933A0
        public void LoadSatellite(){} // RVA: 0x7FFAC86933B0
        public void Load(){} // RVA: 0x7FFAC86935E0 | overloaded x2
        public void InternalSetDomainByID(){} // RVA: 0x7FFAC86936F0
        public void InternalSetDomain(){} // RVA: 0x7FFAC8693700
        public void InternalPushDomainRefByID(){} // RVA: 0x7FFAC8693710
        public void InternalPopDomainRef(){} // RVA: 0x7FFAC8693720
        public void InternalSetContext(){} // RVA: 0x7FFAC8693730
        public void InternalGetContext(){} // RVA: 0x7FFAC847E330
        public void InternalGetDefaultContext(){} // RVA: 0x7FFAC847E330
        public void InternalGetProcessGuid(){} // RVA: 0x7FFAC8693740
        public void InvokeInDomainByID(){} // RVA: 0x7FFAC8693750
        public void GetProcessGuid(){} // RVA: 0x7FFAC86937F0
        public void InternalIsFinalizingForUnload(){} // RVA: 0x7FFAC2F21320
        public void IsFinalizingForUnload(){} // RVA: 0x7FFAC8693870
        public void getDomainID(){} // RVA: 0x7FFAC8693880
        public void ToString(){} // RVA: 0x7FFAC8692F60
        public void DoAssemblyLoad(){} // RVA: 0x7FFAC86938A0
        public void DoAssemblyResolve(){} // RVA: 0x7FFAC86939B0
        public void DoTypeResolve(){} // RVA: 0x7FFAC8693D90
        public void DoResourceResolve(){} // RVA: 0x7FFAC86941E0
        public void DoDomainUnload(){} // RVA: 0x7FFAC8694320
        public void GetMarshalledDomainObjRef(){} // RVA: 0x7FFAC8694350
        public void ProcessMessageInDomain(){} // RVA: 0x7FFAC86943E0
        public void add_AssemblyLoad(){} // RVA: 0x7FFAC8694700
        public void remove_AssemblyLoad(){} // RVA: 0x7FFAC86947F0
        public void add_AssemblyResolve(){} // RVA: 0x7FFAC86948E0
        public void remove_AssemblyResolve(){} // RVA: 0x7FFAC86949D0
        public void add_DomainUnload(){} // RVA: 0x7FFAC8694AC0
        public void remove_DomainUnload(){} // RVA: 0x7FFAC8694BB0
        public void add_ProcessExit(){} // RVA: 0x7FFAC8694CA0
        public void remove_ProcessExit(){} // RVA: 0x7FFAC8694D90
        public void add_UnhandledException(){} // RVA: 0x7FFAC8694E80
        public void remove_UnhandledException(){} // RVA: 0x7FFAC8694F70
        public void get_IsHomogenous(){} // RVA: 0x7FFAC3006850
        public void get_IsFullyTrusted(){} // RVA: 0x7FFAC3006850
    }

    public class AppDomainSetup : Object
    {
        public string application_base; // 0x10
        public string application_name; // 0x18
        public string cache_path; // 0x20
        public string configuration_file; // 0x28
        public string dynamic_base; // 0x30
        public string license_file; // 0x38
        public string private_bin_path; // 0x40
        public string private_bin_path_probe; // 0x48
        public string shadow_copy_directories; // 0x50
        public string shadow_copy_files; // 0x58
        public bool publisher_policy; // 0x60
        public bool path_changed; // 0x61
        public int loader_optimization; // 0x64
        public bool disallow_binding_redirects; // 0x68
        public bool disallow_code_downloads; // 0x69
        public object _activationArguments; // 0x70
        public object domain_initializer; // 0x78
        public object application_trust; // 0x80
        public string[] domain_initializer_args; // 0x88
        public bool disallow_appbase_probe; // 0x90
        public byte[] configuration_bytes; // 0x98
        public byte[] serialized_non_primitives; // 0xA0
        public string manager_assembly; // 0xA8
        public string manager_type; // 0xB0
        public string[] partial_visible_assemblies; // 0xB8
        public string <TargetFrameworkName>k__BackingField; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AppDomainUnloadedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class ApplicationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A3C0 | overloaded x4
    }

    public class ArgIterator : ValueType
    {
        public UIntPtr sig; // 0x10
        public UIntPtr args; // 0x18
        public int next_arg; // 0x20
        public int num_args; // 0x24

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8697830
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
    }

    public class ArgumentException : SystemException
    {
        public string Message; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A5F0 | overloaded x6
        public void GetObjectData(){} // RVA: 0x7FFAC850A700
        public void get_Message(){} // RVA: 0x7FFAC850A8C0
    }

    public class ArgumentNullException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D0B20 | overloaded x4
    }

    public class ArgumentOutOfRangeException : ArgumentException
    {
        public object Message; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850ABA0 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFAC850AD10
        public void get_Message(){} // RVA: 0x7FFAC850AED0
    }

    public class ArithmeticException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

    public class Array : Object
    {
        public object System.Collections.ICollection.Count;
        public object System.Collections.IList.IsReadOnly;
        public object System.Collections.IList.Item;
        public object LongLength;
        public object IsFixedSize;
        public object IsReadOnly;
        public object IsSynchronized;
        public object SyncRoot;
        public object Length;
        public object Rank;

        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFAC86652B0 | overloaded x6
        public void AsReadOnly(){} // RVA: 0x7FFAC2C58F80
        public void Resize(){} // RVA: 0x7FFAC2C76370
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC8661110
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC8661120
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC8661130
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC8661150
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC86611A0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC8661270
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC86612D0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC86613A0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC86613F0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC8661440
        public void CopyTo(){} // RVA: 0x7FFAC8661F00 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8512B10
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFAC8661580
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFAC86617A0
        public void CombineHashCodes(){} // RVA: 0x7FFAC6511FF0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFAC86618D0
        public void BinarySearch(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void ConvertAll(){} // RVA: 0x7FFAC2C58FF0
        public void Copy(){} // RVA: 0x7FFAC8665B40 | overloaded x4
        public void ForEach(){} // RVA: 0x7FFAC2C70C80
        public void get_LongLength(){} // RVA: 0x7FFAC8661FA0
        public void GetLongLength(){} // RVA: 0x7FFAC8662060
        public void GetValue(){} // RVA: 0x7FFAC86649E0 | overloaded x8
        public void get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void GetMedian(){} // RVA: 0x7FFAC8662A40
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void LastIndexOf(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void Reverse(){} // RVA: 0x7FFAC2C77EC0 | overloaded x4
        public void SetValue(){} // RVA: 0x7FFAC8664CE0 | overloaded x8
        public void Sort(){} // RVA: 0x7FFAC2C761F0 | overloaded x17
        public void Exists(){} // RVA: 0x7FFAC2C5A350
        public void Fill(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFAC2E8DC40
        public void FindAll(){} // RVA: 0x7FFAC2C58FF0
        public void FindIndex(){} // RVA: 0x7FFAC2C629D0 | overloaded x3
        public void FindLast(){} // RVA: 0x7FFAC2E8DC40
        public void FindLastIndex(){} // RVA: 0x7FFAC2C629D0 | overloaded x3
        public void TrueForAll(){} // RVA: 0x7FFAC2C5A350
        public void GetEnumerator(){} // RVA: 0x7FFAC8664220
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void InternalArray__ICollection_get_Count(){} // RVA: 0x7FFAC8661110
        public void InternalArray__ICollection_get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void GetRawSzArrayData(){} // RVA: 0x7FFAC86642E0
        public void InternalArray__IEnumerable_GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void InternalArray__ICollection_Clear(){} // RVA: 0x7FFAC8664300
        public void InternalArray__ICollection_Add(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__ICollection_Remove(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__ICollection_Contains(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__ICollection_CopyTo(){} // RVA: 0x7FFAC2C77970
        public void InternalArray__IReadOnlyList_get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__IReadOnlyCollection_get_Count(){} // RVA: 0x7FFAC8661110
        public void InternalArray__Insert(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__RemoveAt(){} // RVA: 0x7FFAC8664350
        public void InternalArray__IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void InternalArray__set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void GetGenericValueImpl(){} // RVA: 0x7FFAC2C72BC0
        public void SetGenericValueImpl(){} // RVA: 0x7FFAC2C72BC0
        public void get_Length(){} // RVA: 0x7FFAC86643A0
        public void get_Rank(){} // RVA: 0x7FFAC8664460
        public void GetRank(){} // RVA: 0x7FFAC8664460
        public void GetLength(){} // RVA: 0x7FFAC8664470
        public void GetLowerBound(){} // RVA: 0x7FFAC86644C0
        public void GetValueImpl(){} // RVA: 0x7FFAC8664690
        public void SetValueImpl(){} // RVA: 0x7FFAC86646C0
        public void FastCopy(){} // RVA: 0x7FFAC86646D0
        public void CreateInstanceImpl(){} // RVA: 0x7FFAC86646E0
        public void GetUpperBound(){} // RVA: 0x7FFAC86646F0
        public void UnsafeCreateInstance(){} // RVA: 0x7FFAC8664DB0 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAC8665810
        public void ClearInternal(){} // RVA: 0x7FFAC86659E0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFAC86661F0
        public void CanAssignArrayElement(){} // RVA: 0x7FFAC8666270
        public void ConstrainedCopy(){} // RVA: 0x7FFAC8666370
        public void Empty(){} // RVA: 0x7FFAC2C58A90
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void IndexOfImpl(){} // RVA: 0x7FFAC2E8DC40
        public void LastIndexOfImpl(){} // RVA: 0x7FFAC2E8DC40
        public void SortImpl(){} // RVA: 0x7FFAC8666380
        public void UnsafeLoad(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeStore(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeMov(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ArraySegment`1 : ValueType
    {
        public System.ArraySegment`1<T> Empty;
        public T[] Array;
        public int Offset;
        public int Count;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void get_Array(){} // RVA: 0x7FFAC2C58E90
        public void get_Offset(){} // RVA: 0x7FFAC2C59960
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void Equals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void op_Equality(){} // RVA: 0x7FFAC2E8DC40
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IList<T>.IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.Generic.IReadOnlyList<T>.get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.Generic.ICollection<T>.Contains(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void ThrowInvalidOperationIfDefault(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ArraySortHelper`1 : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFAC2E8DC40
        public void SwapIfGreater(){} // RVA: 0x7FFAC2E8DC40
        public void Swap(){} // RVA: 0x7FFAC2E8DC40
        public void IntrospectiveSort(){} // RVA: 0x7FFAC2E8DC40
        public void IntroSort(){} // RVA: 0x7FFAC2E8DC40
        public void PickPivotAndPartition(){} // RVA: 0x7FFAC2E8DC40
        public void HeapSort(){} // RVA: 0x7FFAC2E8DC40
        public void DownHeap(){} // RVA: 0x7FFAC2E8DC40
        public void InsertionSort(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ArraySortHelper`2 : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFAC2E8DC40
        public void SwapIfGreaterWithValues(){} // RVA: 0x7FFAC2E8DC40
        public void Swap(){} // RVA: 0x7FFAC2E8DC40
        public void IntrospectiveSort(){} // RVA: 0x7FFAC2E8DC40
        public void IntroSort(){} // RVA: 0x7FFAC2E8DC40
        public void PickPivotAndPartition(){} // RVA: 0x7FFAC2E8DC40
        public void HeapSort(){} // RVA: 0x7FFAC2E8DC40
        public void DownHeap(){} // RVA: 0x7FFAC2E8DC40
        public void InsertionSort(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ArraySpec : Object
    {
        public int dimensions; // 0x10
        public bool bound; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86ACE60
        public void Resolve(){} // RVA: 0x7FFAC86ACE70
        public void Append(){} // RVA: 0x7FFAC86ACF00
        public void ToString(){} // RVA: 0x7FFAC86ACFB0
    }

    public class ArrayTypeMismatchException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class AssemblyLoadEventArgs : EventArgs
    {
        public System.Reflection.Assembly LoadedAssembly; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850B050
        public void get_LoadedAssembly(){} // RVA: 0x7FFAC2F3C380
    }

    public class AssemblyLoadEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class AsyncCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class Attribute : Object
    {
        public object TypeId;

        // ── Methods ──
        public void InternalGetCustomAttributes(){} // RVA: 0x7FFAC866AE00 | overloaded x2
        public void InternalParamGetCustomAttributes(){} // RVA: 0x7FFAC866AEB0
        public void InternalIsDefined(){} // RVA: 0x7FFAC866B510 | overloaded x2
        public void InternalParamIsDefined(){} // RVA: 0x7FFAC866B580
        public void GetCustomAttributes(){} // RVA: 0x7FFAC866D1A0 | overloaded x12
        public void IsDefined(){} // RVA: 0x7FFAC866C7B0 | overloaded x3
        public void GetCustomAttribute(){} // RVA: 0x7FFAC866D2D0 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC866D380
        public void AreFieldValuesEqual(){} // RVA: 0x7FFAC866D600
        public void GetHashCode(){} // RVA: 0x7FFAC866D7F0
        public void get_TypeId(){} // RVA: 0x7FFAC8653DF0
        public void Match(){} // RVA: 0x7FFAC489FD50
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC2F21320
    }

    public class AttributeUsageAttribute : Attribute
    {
        public 0x6B0BE528 AllowMultiple; // 0x10
        public bool Inherited; // 0x14
        public bool _inherited; // 0x15
        public System.AttributeUsageAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850B0F0
        public void get_AllowMultiple(){} // RVA: 0x7FFAC3070BD0
        public void set_AllowMultiple(){} // RVA: 0x7FFAC3070BE0
        public void get_Inherited(){} // RVA: 0x7FFAC3135090
        public void set_Inherited(){} // RVA: 0x7FFAC4411DF0
        public void .cctor(){} // RVA: 0x7FFAC850B100
    }

}