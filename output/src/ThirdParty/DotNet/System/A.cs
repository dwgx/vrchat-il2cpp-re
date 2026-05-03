// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 43
// Methods: 397

namespace ThirdParty.DotNet.System
{
    public class AccessViolationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class Action : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class Action`1 : MulticastDelegate
    {
    }

    public class Action`10 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`11 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`12 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`13 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`14 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`15 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`16 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`3 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`4 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`5 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`6 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`7 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`8 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Action`9 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Activator : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFE810A1420 | overloaded x8
    }

    public class AggregateException : Exception
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Exception> m_innerExceptions; // 0x90
        public object field_1; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B2B50 | overloaded x11
        public void GetObjectData(){} // RVA: 0x7FFE868B2DE0
        public void GetBaseException(){} // RVA: 0x7FFE868B3090
        public void get_InnerExceptions(){} // RVA: 0x7FFE8154EB60
        public void Flatten(){} // RVA: 0x7FFE868B31A0
        public void get_Message(){} // RVA: 0x7FFE868B3420
        public void ToString(){} // RVA: 0x7FFE868B3700
    }

    public class AppContext : Object
    {
        // ── Methods ──
        public void InitializeDefaultSwitchValues(){} // RVA: 0x7FFE86A11A30
        public void TryGetSwitch(){} // RVA: 0x7FFE86A11C30
        public void .cctor(){} // RVA: 0x7FFE86A12190
    }

    public class AppContextDefaultValues : Object
    {
        // ── Methods ──
        public void PopulateDefaultValues(){} // RVA: 0x7FFE810FB310
        public void TryGetSwitchOverride(){} // RVA: 0x7FFE86A3C580
        public void .cctor(){} // RVA: 0x7FFE86A3C590
    }

    public class AppContextSwitches : Object
    {
    }

    public class AppDomain : MarshalByRefObject
    {
        public UIntPtr _mono_app_domain; // 0x18
        public string _process_guid;
        public System.Collections.Generic.Dictionary`2<string,object> type_resolve_in_progress; // 0xFFFF

        // ── Methods ──
        public void IsAppXModel(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void getFriendlyName(){} // RVA: 0x7FFE86A3C740
        public void getCurDomain(){} // RVA: 0x7FFE86A3C760
        public void get_CurrentDomain(){} // RVA: 0x7FFE86A3C760
        public void GetAssemblies(){} // RVA: 0x7FFE86A3C8E0 | overloaded x2
        public void GetData(){} // RVA: 0x7FFE86A3CA20
        public void InitializeLifetimeService(){} // RVA: 0x7FFE813240E0
        public void LoadAssembly(){} // RVA: 0x7FFE86A3CB80
        public void LoadSatellite(){} // RVA: 0x7FFE86A3CB90
        public void Load(){} // RVA: 0x7FFE86A3CDC0 | overloaded x2
        public void InternalSetDomainByID(){} // RVA: 0x7FFE86A3CED0
        public void InternalSetDomain(){} // RVA: 0x7FFE86A3CEE0
        public void InternalPushDomainRefByID(){} // RVA: 0x7FFE86A3CEF0
        public void InternalPopDomainRef(){} // RVA: 0x7FFE86A3CF00
        public void InternalSetContext(){} // RVA: 0x7FFE86A3CF10
        public void InternalGetContext(){} // RVA: 0x7FFE86827C40
        public void InternalGetDefaultContext(){} // RVA: 0x7FFE86827C40
        public void InternalGetProcessGuid(){} // RVA: 0x7FFE86A3CF20
        public void InvokeInDomainByID(){} // RVA: 0x7FFE86A3CF30
        public void GetProcessGuid(){} // RVA: 0x7FFE86A3CFD0
        public void InternalIsFinalizingForUnload(){} // RVA: 0x7FFE810FB320
        public void IsFinalizingForUnload(){} // RVA: 0x7FFE86A3D050
        public void getDomainID(){} // RVA: 0x7FFE86A3D060
        public void ToString(){} // RVA: 0x7FFE86A3C740
        public void DoAssemblyLoad(){} // RVA: 0x7FFE86A3D080
        public void DoAssemblyResolve(){} // RVA: 0x7FFE86A3D190
        public void DoTypeResolve(){} // RVA: 0x7FFE86A3D570
        public void DoResourceResolve(){} // RVA: 0x7FFE86A3D9C0
        public void DoDomainUnload(){} // RVA: 0x7FFE86A3DB00
        public void GetMarshalledDomainObjRef(){} // RVA: 0x7FFE86A3DB30
        public void ProcessMessageInDomain(){} // RVA: 0x7FFE86A3DBC0
        public void add_AssemblyLoad(){} // RVA: 0x7FFE86A3DEE0
        public void remove_AssemblyLoad(){} // RVA: 0x7FFE86A3DFD0
        public void add_AssemblyResolve(){} // RVA: 0x7FFE86A3E0C0
        public void remove_AssemblyResolve(){} // RVA: 0x7FFE86A3E1B0
        public void add_DomainUnload(){} // RVA: 0x7FFE86A3E2A0
        public void remove_DomainUnload(){} // RVA: 0x7FFE86A3E390
        public void add_ProcessExit(){} // RVA: 0x7FFE86A3E480
        public void remove_ProcessExit(){} // RVA: 0x7FFE86A3E570
        public void add_UnhandledException(){} // RVA: 0x7FFE86A3E660
        public void remove_UnhandledException(){} // RVA: 0x7FFE86A3E750
        public void get_IsHomogenous(){} // RVA: 0x7FFE811E0850
        public void get_IsFullyTrusted(){} // RVA: 0x7FFE811E0850
    }

    public class AppDomainSetup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AppDomainUnloadedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class ApplicationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3BC0 | overloaded x4
    }

    public class ArgIterator : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE86A41010
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
    }

    public class ArgumentException : SystemException
    {
        public string _paramName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3DF0 | overloaded x6
        public void GetObjectData(){} // RVA: 0x7FFE868B3F00
        public void get_Message(){} // RVA: 0x7FFE868B40C0
    }

    public class ArgumentNullException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677A420 | overloaded x4
    }

    public class ArgumentOutOfRangeException : ArgumentException
    {
        public object _actualValue; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B43A0 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFE868B4510
        public void get_Message(){} // RVA: 0x7FFE868B46D0
    }

    public class ArithmeticException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

    public class Array : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFE86A0EAA0 | overloaded x6
        public void AsReadOnly(){} // RVA: 0x7FFE80E2E3D0
        public void Resize(){} // RVA: 0x7FFE80E4BA70
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE86A0A900
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE86A0A910
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE86A0A920
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE86A0A940
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE86A0A990
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE86A0AA60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE86A0AAC0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE86A0AB90
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE86A0ABE0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE86A0AC30
        public void CopyTo(){} // RVA: 0x7FFE86A0B6F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE868BC310
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFE86A0AD70
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFE86A0AF90
        public void CombineHashCodes(){} // RVA: 0x7FFE84897A50
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFE86A0B0C0
        public void BinarySearch(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void ConvertAll(){} // RVA: 0x7FFE80E2E440
        public void Copy(){} // RVA: 0x7FFE86A0F330 | overloaded x4
        public void ForEach(){} // RVA: 0x7FFE80E462E0
        public void get_LongLength(){} // RVA: 0x7FFE86A0B790
        public void GetLongLength(){} // RVA: 0x7FFE86A0B850
        public void GetValue(){} // RVA: 0x7FFE86A0E1D0 | overloaded x8
        public void get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void GetMedian(){} // RVA: 0x7FFE86A0C230
        public void IndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void LastIndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void Reverse(){} // RVA: 0x7FFE80E4D5C0 | overloaded x4
        public void SetValue(){} // RVA: 0x7FFE86A0E4D0 | overloaded x8
        public void Sort(){} // RVA: 0x7FFE80E4B8F0 | overloaded x17
        public void Exists(){} // RVA: 0x7FFE80E2F7A0
        public void Fill(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Find(){} // RVA: 0x7FFE810A1420
        public void FindAll(){} // RVA: 0x7FFE80E2E440
        public void FindIndex(){} // RVA: 0x7FFE80E37E20 | overloaded x3
        public void FindLast(){} // RVA: 0x7FFE810A1420
        public void FindLastIndex(){} // RVA: 0x7FFE80E37E20 | overloaded x3
        public void TrueForAll(){} // RVA: 0x7FFE80E2F7A0
        public void GetEnumerator(){} // RVA: 0x7FFE86A0DA10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void InternalArray__ICollection_get_Count(){} // RVA: 0x7FFE86A0A900
        public void InternalArray__ICollection_get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void GetRawSzArrayData(){} // RVA: 0x7FFE86A0DAD0
        public void InternalArray__IEnumerable_GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void InternalArray__ICollection_Clear(){} // RVA: 0x7FFE86A0DAF0
        public void InternalArray__ICollection_Add(){} // RVA: 0x7FFE810A1420
        public void InternalArray__ICollection_Remove(){} // RVA: 0x7FFE810A1420
        public void InternalArray__ICollection_Contains(){} // RVA: 0x7FFE810A1420
        public void InternalArray__ICollection_CopyTo(){} // RVA: 0x7FFE80E4D070
        public void InternalArray__IReadOnlyList_get_Item(){} // RVA: 0x7FFE810A1420
        public void InternalArray__IReadOnlyCollection_get_Count(){} // RVA: 0x7FFE86A0A900
        public void InternalArray__Insert(){} // RVA: 0x7FFE810A1420
        public void InternalArray__RemoveAt(){} // RVA: 0x7FFE86A0DB40
        public void InternalArray__IndexOf(){} // RVA: 0x7FFE810A1420
        public void InternalArray__get_Item(){} // RVA: 0x7FFE810A1420
        public void InternalArray__set_Item(){} // RVA: 0x7FFE810A1420
        public void GetGenericValueImpl(){} // RVA: 0x7FFE80E48220
        public void SetGenericValueImpl(){} // RVA: 0x7FFE80E48220
        public void get_Length(){} // RVA: 0x7FFE86A0DB90
        public void get_Rank(){} // RVA: 0x7FFE86A0DC50
        public void GetRank(){} // RVA: 0x7FFE86A0DC50
        public void GetLength(){} // RVA: 0x7FFE86A0DC60
        public void GetLowerBound(){} // RVA: 0x7FFE86A0DCB0
        public void GetValueImpl(){} // RVA: 0x7FFE86A0DE80
        public void SetValueImpl(){} // RVA: 0x7FFE86A0DEB0
        public void FastCopy(){} // RVA: 0x7FFE86A0DEC0
        public void CreateInstanceImpl(){} // RVA: 0x7FFE86A0DED0
        public void GetUpperBound(){} // RVA: 0x7FFE86A0DEE0
        public void UnsafeCreateInstance(){} // RVA: 0x7FFE86A0E5A0 | overloaded x3
        public void Clear(){} // RVA: 0x7FFE86A0F000
        public void ClearInternal(){} // RVA: 0x7FFE86A0F1D0
        public void CreateArrayTypeMismatchException(){} // RVA: 0x7FFE86A0F9E0
        public void CanAssignArrayElement(){} // RVA: 0x7FFE86A0FA60
        public void ConstrainedCopy(){} // RVA: 0x7FFE86A0FB60
        public void Empty(){} // RVA: 0x7FFE80E2DEE0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void IndexOfImpl(){} // RVA: 0x7FFE810A1420
        public void LastIndexOfImpl(){} // RVA: 0x7FFE810A1420
        public void SortImpl(){} // RVA: 0x7FFE86A0FB70
        public void UnsafeLoad(){} // RVA: 0x7FFE810A1420
        public void UnsafeStore(){} // RVA: 0x7FFE810A1420
        public void UnsafeMov(){} // RVA: 0x7FFE810A1420
    }

    public class ArraySegment`1 : ValueType
    {
        public System.ArraySegment`1<T> _empty;
        public T[] _array;
        public int _offset;
        public int _count;
        public System.ArraySegment`1<int> _empty;
        public int[] _array; // 0x10
        public int _offset; // 0x18

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_Array(){} // RVA: 0x7FFE80E2E2E0
        public void get_Offset(){} // RVA: 0x7FFE80E2EDB0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void op_Equality(){} // RVA: 0x7FFE810A1420
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.IndexOf(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.IReadOnlyList<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<T>.Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void ThrowInvalidOperationIfDefault(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ArraySortHelper`1 : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFE810A1420
        public void SwapIfGreater(){} // RVA: 0x7FFE810A1420
        public void Swap(){} // RVA: 0x7FFE810A1420
        public void IntrospectiveSort(){} // RVA: 0x7FFE810A1420
        public void IntroSort(){} // RVA: 0x7FFE810A1420
        public void PickPivotAndPartition(){} // RVA: 0x7FFE810A1420
        public void HeapSort(){} // RVA: 0x7FFE810A1420
        public void DownHeap(){} // RVA: 0x7FFE810A1420
        public void InsertionSort(){} // RVA: 0x7FFE810A1420
    }

    public class ArraySortHelper`2 : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFE810A1420
        public void SwapIfGreaterWithValues(){} // RVA: 0x7FFE810A1420
        public void Swap(){} // RVA: 0x7FFE810A1420
        public void IntrospectiveSort(){} // RVA: 0x7FFE810A1420
        public void IntroSort(){} // RVA: 0x7FFE810A1420
        public void PickPivotAndPartition(){} // RVA: 0x7FFE810A1420
        public void HeapSort(){} // RVA: 0x7FFE810A1420
        public void DownHeap(){} // RVA: 0x7FFE810A1420
        public void InsertionSort(){} // RVA: 0x7FFE810A1420
    }

    public class ArraySpec : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A56610
        public void Resolve(){} // RVA: 0x7FFE86A56620
        public void Append(){} // RVA: 0x7FFE86A566B0
        public void ToString(){} // RVA: 0x7FFE86A56760
    }

    public class ArrayTypeMismatchException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class AssemblyLoadEventArgs : EventArgs
    {
        public System.Reflection.Assembly _loadedAssembly; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B4850
        public void get_LoadedAssembly(){} // RVA: 0x7FFE81116380
    }

    public class AssemblyLoadEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class AsyncCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE81156C70
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class Attribute : Object
    {
        // ── Methods ──
        public void InternalGetCustomAttributes(){} // RVA: 0x7FFE86A145F0 | overloaded x2
        public void InternalParamGetCustomAttributes(){} // RVA: 0x7FFE86A146A0
        public void InternalIsDefined(){} // RVA: 0x7FFE86A14D00 | overloaded x2
        public void InternalParamIsDefined(){} // RVA: 0x7FFE86A14D70
        public void GetCustomAttributes(){} // RVA: 0x7FFE86A16990 | overloaded x12
        public void IsDefined(){} // RVA: 0x7FFE86A15FA0 | overloaded x3
        public void GetCustomAttribute(){} // RVA: 0x7FFE86A16AC0 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE86A16B70
        public void AreFieldValuesEqual(){} // RVA: 0x7FFE86A16DF0
        public void GetHashCode(){} // RVA: 0x7FFE86A16FE0
        public void get_TypeId(){} // RVA: 0x7FFE869FD5E0
        public void Match(){} // RVA: 0x7FFE82B08080
        public void IsDefaultAttribute(){} // RVA: 0x7FFE810FB320
    }

    public class AttributeUsageAttribute : Attribute
    {
        public 0x664B744C _attributeTarget; // 0x10
        public bool _allowMultiple; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B48F0
        public void get_AllowMultiple(){} // RVA: 0x7FFE8124ABD0
        public void set_AllowMultiple(){} // RVA: 0x7FFE8124ABE0
        public void get_Inherited(){} // RVA: 0x7FFE8139AC40
        public void set_Inherited(){} // RVA: 0x7FFE826E34C0
        public void .cctor(){} // RVA: 0x7FFE868B4900
    }

}