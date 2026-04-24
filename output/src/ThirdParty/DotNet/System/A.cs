// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 31
// Methods: 343

namespace ThirdParty.DotNet.System
{
    public class Action : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E39F980
        public void Invoke(){} // RVA: 0x7FFD4E39FA50
    }

    public class Action`1 : MulticastDelegate
    {
    }

    public class Action`10 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`11 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`12 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`13 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`14 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`15 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`16 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51475630
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class Action`3 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD515B1B70
        public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    }

    public class Action`4 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`5 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`6 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`7 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`8 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Action`9 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Activator : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
    }

    public class AppContext : Object
    {
        public System.Collections.Generic.Dictionary`2<string,0x66422938> s_switchMap;
        public bool s_defaultsInitialized; // 0x8

        // ── Methods ──
        public void InitializeDefaultSwitchValues(){} // RVA: 0x7FFD53A88240
        public void TryGetSwitch(){} // RVA: 0x7FFD53A88440
        public void .cctor(){} // RVA: 0x7FFD53A889A0
    }

    public class AppContextDefaultValues : Object
    {
        public string SwitchEnforceJapaneseEraYearRanges;
        public string SwitchFormatJapaneseFirstYearAsANumber; // 0x8
        public string SwitchEnforceLegacyJapaneseDateParsing; // 0x10

        // ── Methods ──
        public void PopulateDefaultValues(){} // RVA: 0x7FFD4E341310
        public void TryGetSwitchOverride(){} // RVA: 0x7FFD53AB2DA0
        public void .cctor(){} // RVA: 0x7FFD53AB2DB0
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
        public 0x6641E478 AssemblyLoad; // 0x38
        public 0x66420E10 AssemblyResolve; // 0x40
        public Cl DomainUnload; // 0x48
        public Cl ProcessExit; // 0x50
        public 0x66420E10 ResourceResolve; // 0x58
        public 0x66420E10 TypeResolve; // 0x60
        public System.UnhandledExceptionEventHandler UnhandledException; // 0x68
        public System.EventHandler`1<0x66435C30> FirstChanceException; // 0x70
        public object _domain_manager; // 0x78
        public 0x66420E10 ReflectionOnlyAssemblyResolve; // 0x80
        public object _activation; // 0x88
        public object _applicationIdentity; // 0x90
        public System.Collections.Generic.List`1<string> compatibility_switch; // 0x98

        // ── Methods ──
        public void IsAppXModel(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void getFriendlyName(){} // RVA: 0x7FFD53AB2F60
        public void getCurDomain(){} // RVA: 0x7FFD53AB2F80
        public void get_CurrentDomain(){} // RVA: 0x7FFD53AB2F80
        public void GetAssemblies(){} // RVA: 0x7FFD53AB3100 | overloaded x2
        public void GetData(){} // RVA: 0x7FFD53AB3240
        public void InitializeLifetimeService(){} // RVA: 0x7FFD4E919180
        public void LoadAssembly(){} // RVA: 0x7FFD53AB33A0
        public void LoadSatellite(){} // RVA: 0x7FFD53AB33B0
        public void Load(){} // RVA: 0x7FFD53AB35E0 | overloaded x2
        public void InternalSetDomainByID(){} // RVA: 0x7FFD53AB36F0
        public void InternalSetDomain(){} // RVA: 0x7FFD53AB3700
        public void InternalPushDomainRefByID(){} // RVA: 0x7FFD53AB3710
        public void InternalPopDomainRef(){} // RVA: 0x7FFD53AB3720
        public void InternalSetContext(){} // RVA: 0x7FFD53AB3730
        public void InternalGetContext(){} // RVA: 0x7FFD5389E330
        public void InternalGetDefaultContext(){} // RVA: 0x7FFD5389E330
        public void InternalGetProcessGuid(){} // RVA: 0x7FFD53AB3740
        public void InvokeInDomainByID(){} // RVA: 0x7FFD53AB3750
        public void GetProcessGuid(){} // RVA: 0x7FFD53AB37F0
        public void InternalIsFinalizingForUnload(){} // RVA: 0x7FFD4E341320
        public void IsFinalizingForUnload(){} // RVA: 0x7FFD53AB3870
        public void getDomainID(){} // RVA: 0x7FFD53AB3880
        public void ToString(){} // RVA: 0x7FFD53AB2F60
        public void DoAssemblyLoad(){} // RVA: 0x7FFD53AB38A0
        public void DoAssemblyResolve(){} // RVA: 0x7FFD53AB39B0
        public void DoTypeResolve(){} // RVA: 0x7FFD53AB3D90
        public void DoResourceResolve(){} // RVA: 0x7FFD53AB41E0
        public void DoDomainUnload(){} // RVA: 0x7FFD53AB4320
        public void GetMarshalledDomainObjRef(){} // RVA: 0x7FFD53AB4350
        public void ProcessMessageInDomain(){} // RVA: 0x7FFD53AB43E0
        public void add_AssemblyLoad(){} // RVA: 0x7FFD53AB4700
        public void remove_AssemblyLoad(){} // RVA: 0x7FFD53AB47F0
        public void add_AssemblyResolve(){} // RVA: 0x7FFD53AB48E0
        public void remove_AssemblyResolve(){} // RVA: 0x7FFD53AB49D0
        public void add_DomainUnload(){} // RVA: 0x7FFD53AB4AC0
        public void remove_DomainUnload(){} // RVA: 0x7FFD53AB4BB0
        public void add_ProcessExit(){} // RVA: 0x7FFD53AB4CA0
        public void remove_ProcessExit(){} // RVA: 0x7FFD53AB4D90
        public void add_UnhandledException(){} // RVA: 0x7FFD53AB4E80
        public void remove_UnhandledException(){} // RVA: 0x7FFD53AB4F70
        public void get_IsHomogenous(){} // RVA: 0x7FFD4E426850
        public void get_IsFullyTrusted(){} // RVA: 0x7FFD4E426850
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
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ArgIterator : ValueType
    {
        public UIntPtr sig; // 0x10
        public UIntPtr args; // 0x18
        public int next_arg; // 0x20
        public int num_args; // 0x24

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD53AB7830
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
    }

    public class ArgumentException : SystemException
    {
        public string Message; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5392A5F0 | overloaded x6
        public void GetObjectData(){} // RVA: 0x7FFD5392A700
        public void get_Message(){} // RVA: 0x7FFD5392A8C0
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
        public void CreateInstance(){} // RVA: 0x7FFD53A852B0 | overloaded x6
        public void AsReadOnly(){} // RVA: 0x7FFD4E078F80
        public void Resize(){} // RVA: 0x7FFD4E096370
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFD53A81110
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD53A81120
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD53A81130
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD53A81150
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD53A811A0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD53A81270
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD53A812D0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD53A813A0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD53A813F0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD53A81440
        public void CopyTo(){} // RVA: 0x7FFD53A81F00 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53932B10
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFD53A81580
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFD53A817A0
        public void CombineHashCodes(){} // RVA: 0x7FFD51931FF0
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFD53A818D0
        public void BinarySearch(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void ConvertAll(){} // RVA: 0x7FFD4E078FF0
        public void Copy(){} // RVA: 0x7FFD53A85B40 | overloaded x4
        public void ForEach(){} // RVA: 0x7FFD4E090C80
        public void get_LongLength(){} // RVA: 0x7FFD53A81FA0
        public void GetLongLength(){} // RVA: 0x7FFD53A82060
        public void GetValue(){} // RVA: 0x7FFD53A849E0 | overloaded x8
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E426850
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void get_SyncRoot(){} // RVA: 0x7FFD4F9181E0
        public void GetMedian(){} // RVA: 0x7FFD53A82A40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void LastIndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void Reverse(){} // RVA: 0x7FFD4E097EC0 | overloaded x4
        public void SetValue(){} // RVA: 0x7FFD53A84CE0 | overloaded x8
        public void Sort(){} // RVA: 0x7FFD4E0961F0 | overloaded x17
        public void Exists(){} // RVA: 0x7FFD4E07A350
        public void Fill(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFD4E2ADC40
        public void FindAll(){} // RVA: 0x7FFD4E078FF0
        public void FindIndex(){} // RVA: 0x7FFD4E0829D0 | overloaded x3
        public void FindLast(){} // RVA: 0x7FFD4E2ADC40
        public void FindLastIndex(){} // RVA: 0x7FFD4E0829D0 | overloaded x3
        public void TrueForAll(){} // RVA: 0x7FFD4E07A350
        public void GetEnumerator(){} // RVA: 0x7FFD53A84220
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void InternalArray__ICollection_get_Count(){} // RVA: 0x7FFD53A81110
        public void InternalArray__ICollection_get_IsReadOnly(){} // RVA: 0x7FFD4E426850
        public void GetRawSzArrayData(){} // RVA: 0x7FFD53A842E0
        public void InternalArray__IEnumerable_GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void InternalArray__ICollection_Clear(){} // RVA: 0x7FFD53A84300
        public void InternalArray__ICollection_Add(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__ICollection_Remove(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__ICollection_Contains(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__ICollection_CopyTo(){} // RVA: 0x7FFD4E097970
        public void InternalArray__IReadOnlyList_get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__IReadOnlyCollection_get_Count(){} // RVA: 0x7FFD53A81110
        public void InternalArray__Insert(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__RemoveAt(){} // RVA: 0x7FFD53A84350
        public void InternalArray__IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void InternalArray__set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetGenericValueImpl(){} // RVA: 0x7FFD4E092BC0
        public void SetGenericValueImpl(){} // RVA: 0x7FFD4E092BC0
        public void get_Length(){} // RVA: 0x7FFD53A843A0
        public void get_Rank(){} // RVA: 0x7FFD53A84460
        public void GetRank(){} // RVA: 0x7FFD53A84460
        public void GetLength(){} // RVA: 0x7FFD53A84470
        public void GetLowerBound(){} // RVA: 0x7FFD53A844C0
        public void GetValueImpl(){} // RVA: 0x7FFD53A84690
        public void SetValueImpl(){} // RVA: 0x7FFD53A846C0
        public void FastCopy(){} // RVA: 0x7FFD53A846D0
        public void CreateInstanceImpl(){} // RVA: 0x7FFD53A846E0
        public void GetUpperBound(){} // RVA: 0x7FFD53A846F0
        public void UnsafeCreateInstance(){} // RVA: 0x7FFD53A84DB0 | overloaded x3
        public void Clear(){} // RVA: 0x7FFD53A85810
        public void ClearInternal(){} // RVA: 0x7FFD53A859E0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFD53A861F0
        public void CanAssignArrayElement(){} // RVA: 0x7FFD53A86270
        public void ConstrainedCopy(){} // RVA: 0x7FFD53A86370
        public void Empty(){} // RVA: 0x7FFD4E078A90
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void IndexOfImpl(){} // RVA: 0x7FFD4E2ADC40
        public void LastIndexOfImpl(){} // RVA: 0x7FFD4E2ADC40
        public void SortImpl(){} // RVA: 0x7FFD53A86380
        public void UnsafeLoad(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeStore(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeMov(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ArraySegment`1 : ValueType
    {
        public System.ArraySegment`1<ÌÌÏÌÏÏÍÏÍÌÎÎÌÌÏÌÌÍÍÌÍÏÌ> Empty;
        public ÌÌÏÌÏÏÍÏÍÌÎÎÌÌÏÌÌÍÍÌÍÏÌ[] Array; // 0x10
        public int Offset; // 0x18
        public int Count; // 0x1C

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Array(){} // RVA: 0x7FFD4E078E90
        public void get_Offset(){} // RVA: 0x7FFD4E079960
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void op_Equality(){} // RVA: 0x7FFD4E2ADC40
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.IReadOnlyList<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<T>.Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void ThrowInvalidOperationIfDefault(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ArraySortHelper`1 : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFD4E2ADC40
        public void SwapIfGreater(){} // RVA: 0x7FFD4E2ADC40
        public void Swap(){} // RVA: 0x7FFD4E2ADC40
        public void IntrospectiveSort(){} // RVA: 0x7FFD4E2ADC40
        public void IntroSort(){} // RVA: 0x7FFD4E2ADC40
        public void PickPivotAndPartition(){} // RVA: 0x7FFD4E2ADC40
        public void HeapSort(){} // RVA: 0x7FFD4E2ADC40
        public void DownHeap(){} // RVA: 0x7FFD4E2ADC40
        public void InsertionSort(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ArraySortHelper`2 : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFD4E2ADC40
        public void SwapIfGreaterWithValues(){} // RVA: 0x7FFD4E2ADC40
        public void Swap(){} // RVA: 0x7FFD4E2ADC40
        public void IntrospectiveSort(){} // RVA: 0x7FFD4E2ADC40
        public void IntroSort(){} // RVA: 0x7FFD4E2ADC40
        public void PickPivotAndPartition(){} // RVA: 0x7FFD4E2ADC40
        public void HeapSort(){} // RVA: 0x7FFD4E2ADC40
        public void DownHeap(){} // RVA: 0x7FFD4E2ADC40
        public void InsertionSort(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Attribute : Object
    {
        public object TypeId;

        // ── Methods ──
        public void InternalGetCustomAttributes(){} // RVA: 0x7FFD53A8AE00 | overloaded x2
        public void InternalParamGetCustomAttributes(){} // RVA: 0x7FFD53A8AEB0
        public void InternalIsDefined(){} // RVA: 0x7FFD53A8B510 | overloaded x2
        public void InternalParamIsDefined(){} // RVA: 0x7FFD53A8B580
        public void GetCustomAttributes(){} // RVA: 0x7FFD53A8D1A0 | overloaded x12
        public void IsDefined(){} // RVA: 0x7FFD53A8C7B0 | overloaded x3
        public void GetCustomAttribute(){} // RVA: 0x7FFD53A8D2D0 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD53A8D380
        public void AreFieldValuesEqual(){} // RVA: 0x7FFD53A8D600
        public void GetHashCode(){} // RVA: 0x7FFD53A8D7F0
        public void get_TypeId(){} // RVA: 0x7FFD53A73DF0
        public void Match(){} // RVA: 0x7FFD4FCBFD50
        public void IsDefaultAttribute(){} // RVA: 0x7FFD4E341320
    }

    public class AttributeUsageAttribute : Attribute
    {
        public ` AllowMultiple; // 0x10
        public bool Inherited; // 0x14
        public bool _inherited; // 0x15
        public System.AttributeUsageAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5392B0F0
        public void get_AllowMultiple(){} // RVA: 0x7FFD4E490BD0
        public void set_AllowMultiple(){} // RVA: 0x7FFD4E490BE0
        public void get_Inherited(){} // RVA: 0x7FFD4E555090
        public void set_Inherited(){} // RVA: 0x7FFD4F831DF0
        public void .cctor(){} // RVA: 0x7FFD5392B100
    }

}