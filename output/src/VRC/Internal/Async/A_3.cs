// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Internal.Async
// Classes: 100
// Methods: 870

namespace VRC.Internal.Async
{
    /// <summary>Originally: ÍÎÍÍÍÌÏÌÏÎÍÎÎÎÏÌÎÏÌÎÎÍÎ</summary>
    public class AsyncResult_CEFF : Object
    {
        public byte[] _isCompleted; // 0x10
        public int _asyncState; // 0x18
        public int _completedSynchronously; // 0x1C
        public bool _asyncWaitHandle; // 0x20
        public object f_E2F; // 0x28
        public object ÏÎÍÌÏÎÌÌÏÌÎÌÏÎÎÌÎÏÎÌÌÌÌ; // 0x30
        public System.AsyncCallback ÏÌÏÎÌÌÌÏÌÎÍÎÎÌÌÏÌÏÍÎÏÎÍ; // 0x38
        public object ÌÌÏÍÏÏÏÍÌÏÎÏÏÏÌÌÌÏÌÏÌÌÎ; // 0x40
        public bool ÌÎÎÌÌÌÍÍÎÏÍÏÍÎÎÌÌÏÍÌÏÎÏ; // 0x48
        public int ÏÍÌÍÎÎÍÏÏÌÏÍÍÍÎÏÏÎÌÏÏÏÍ; // 0x4C
        public int ÏÌÏÎÎÌÏÍÍÍÎÏÌÏÍÎÌÏÎÍÌÌÏ; // 0x50
        public object ÏÌÎÍÏÍÏÎÏÏÌÎÌÍÍÍÎÏÎÌÍÌÏ; // 0x58

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFAC44ECE20
        public void set_IsCompleted(){} // RVA: 0x7FFAC44ECE30
        public void set_AsyncWaitHandle_916C55B0D42C_916C55B0D42C(){} // RVA: 0x7FFAC44ED170 | overloaded x2
        public void get_AsyncState(){} // RVA: 0x7FFAC31D95E0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC44ECE20
        public void get_hidden(){} // RVA: 0x7FFAC2FD8D30
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void set_CompletedSynchronously(){} // RVA: 0x7FFAC2FD8D30
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC2FD8D30
        public void .ctor(){} // RVA: 0x7FFAC44ECED0
        public void Initialize(){} // RVA: 0x7FFAC44ED070
        public void Instantiate(){} // RVA: 0x7FFAC44ED080
        public void GetHashCode_9F1376C665BE_9F1376C665BE(){} // RVA: 0x7FFAC44ECEB0 | overloaded x2
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC44ED280
    }

    /// <summary>Originally: ÍÎÎÏÏÌÏÌÏÏÏÏÎÌÍÎÏÌÏÎÏÎÌ</summary>
    public class AsyncStateMachine_007A_007A : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÎÍÌÌÍÎÌÍÍÏÏÎÌÍÎÏÍÌÍÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Action`1<ÍÏÏÌÌÏÌÏÌÍÏÏÎÏÎÌÍÏÌÌÍÏÏ> ÍÏÍÎÍÎÎÎÏÏÌÌÎÌÌÏÌÎÏÎÏÏÍ; // 0x28
        public System.Action`1<VRC.Core.ApiContainer> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ; // 0x30
        public ÌÌÍÎÌÏÌÌÎÎÏÌÎÍÌÌÌÌÏÌÌÎÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public Awaiter<UnityEngine.Texture2D> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3439E80
        public void InternalEquals(){} // RVA: 0x7FFAC343A590
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC343ACA0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC343B3B0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÍÍÌÍÏÌÎÍÏÍÍÍÎÍÎÎÍÏÌÍÎ</summary>
    public class AsyncStateMachine_02B2 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.HashSet`1<ÎÎÏÍÏÌÏÌÎÎÏÎÎÍÍÎÎÎÍÏÍÍÏ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÌÎÍÍÎÏÍÌÎÌÎÌÍÍÌÌÌÎÌÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.DateTime ÏÏÍÎÏÍÌÏÏÌÌÏÎÌÍÎÏÏÏÎÌÍÏ; // 0x38
        public System.Collections.Generic.ISet`1<0x6B168EE0> ÏÍÍÌÌÏÏÎÏÎÍÌÎÌÏÎÍÌÎÍÌÎÌ; // 0x40
        public Awaiter<System.Collections.Generic.IEnumerable`1<VRC.Core.APICalendarEntry>[]> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4922660
        public void InternalEquals(){} // RVA: 0x7FFAC4922690
        public void DefaultEquals(){} // RVA: 0x7FFAC49226C0
        public void GetHashCode(){} // RVA: 0x7FFAC49226F0
        public void MoveNext(){} // RVA: 0x7FFAC4922C00
        public void SetStateMachine(){} // RVA: 0x7FFAC4923140
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4923170
        public void ToString(){} // RVA: 0x7FFAC4923680
        // ── Unresolved (hash) ──
        public void m_5EB(){} // RVA: 0x7FFAC49236B0
    }

    /// <summary>Originally: ÍÎÏÍÏÌÌÏÍÍÍÏÍÌÏÍÏÎÍÌÍÎÍ</summary>
    public class AsyncStateMachine_0416_0416 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public string ÎÏÏÌÏÌÏÏÎÍÍÍÌÎÎÍÍÎÎÎÏÍÏ; // 0x38
        public System.Threading.CancellationToken ÏÍÍÏÍÌÎÎÍÏÍÎÌÏÎÍÍÏÍÏÏÏÏ; // 0x40
        public ÌÏÍÏÍÏÎÏÍÎÍÎÌÎÌÌÎÏÏÎÎÎÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x48
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3243690
        public void InternalEquals(){} // RVA: 0x7FFAC3244460
        public void DefaultEquals(){} // RVA: 0x7FFAC3245220
        public void SetStateMachine(){} // RVA: 0x7FFAC3245FF0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3246020
        public void Equals(){} // RVA: 0x7FFAC3246DD0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3246E00
        public void GetHashCode(){} // RVA: 0x7FFAC3246E30
    }

    /// <summary>Originally: ÍÍÌÏÍÎÎÌÎÍÌÍÌÌÍÍÍÎÌÍÏÌÍ</summary>
    public class AsyncStateMachine_07CA_07CA : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎÌÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3210B80
        public void SetStateMachine(){} // RVA: 0x7FFAC32116D0
        public void DefaultEquals(){} // RVA: 0x7FFAC3211730
        public void Equals(){} // RVA: 0x7FFAC3212280
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3212DD0
        public void GetHashCode(){} // RVA: 0x7FFAC3212E30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3213980
    }

    /// <summary>Originally: ÍÎÎÌÍÎÌÌÏÍÎÏÎÏÏÏÏÍÌÏÏÎÎ</summary>
    public class AsyncStateMachine_0AEA0_0AEA : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`2<0x6B0020E0,ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public float ÍÍÍÌÍÌÌÍÍÎÍÏÌÎÎÎÎÍÎÌÍÎÌ; // 0x40
        public VRC.Core.ApiAvatar ÏÏÍÏÏÍÏÎÏÎÌÎÍÌÍÏÌÌÏÌÎÍÍ; // 0x48
        public 0x6B0ACE60 ÌÍÏÎÍÍÌÍÍÎÎÏÍÎÏÌÏÍÍÌÌÎÌ; // 0x50
        public bool ÌÌÏÎÌÌÌÎÌÌÏÎÎÌÏÌÌÍÍÎÏÏÎ; // 0x54
        public bool ÏÍÍÍÌÎÍÍÏÏÎÌÍÎÏÍÌÍÍÌÍÍÏ; // 0x55
        public 0x6B002088 ÍÏÌÎÍÏÍÏÍÍÍÍÍÍÎÍÏÏÏÏÍÌÏ; // 0x58
        public VRC.Core.ApiAvatar ÍÌÎÌÌÍÎÍÌÏÏÍÌÏÌÏÌÍÎÏÍÏÍ; // 0x60
        public 0x6B0ACE60 ÏÏÏÎÎÌÎÏÌÌÎÍÎÍÌÍÍÏÏÌÍÍÌ; // 0x68
        public System.Threading.CancellationToken ÎÍÏÏÎÌÎÏÎÍÍÌÌÌÌÌÏÏÌÌÏÌÎ; // 0x70
        public ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ ÏÍÎÍÏÏÎÌÎÎÌÎÎÍÍÏÎÎÎÎÌÍÍ; // 0x78
        public Awaiter<ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x80
        public object ÏÎÍÍÎÌÍÌÏÍÌÏÏÏÏÏÍÏÌÌÍÍÌ; // 0x98
        public int ÏÎÍÏÏÍÏÎÌÎÏÍÏÎÎÏÍÎÎÏÍÍÌ; // 0xA0
        public System.ValueTuple`2<0x6B0020E0,ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ> ÎÏÍÍÏÎÍÎÎÌÌÍÌÍÌÏÌÎÎÌÏÍÍ; // 0xA8
        public UnityEngine.Transform ÏÎÎÌÍÍÏÌÌÎÏÍÍÍÌÍÌÎÌÍÏÌÌ; // 0xB8
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0xC0
        public System.Runtime.CompilerServices.ValueTaskAwaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0xD0

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC40C2280
        public void SetStateMachine(){} // RVA: 0x7FFAC40C4130
        public void DefaultEquals(){} // RVA: 0x7FFAC40C4160
        public void GetHashCode(){} // RVA: 0x7FFAC40C4190
        public void MoveNext(){} // RVA: 0x7FFAC40C6030
        public void ToString(){} // RVA: 0x7FFAC40C7F00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC40C7F30
        public void HasValidInternalValue(){} // RVA: 0x7FFAC40C9D60
    }

    /// <summary>Originally: ÍÎÍÌÎÍÏÎÏÍÌÍÌÎÌÏÏÏÍÏÎÎÎ</summary>
    public class AsyncStateMachine_0BB5_0BB5 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÎÏÏÌÎÎÌÎÎÌÍÏÌÌÌÏÎÏÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public string ÌÏÌÎÎÎÎÏÍÍÌÏÏÍÎÏÎÏÍÎÏÎÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3864DA0
        public void InternalEquals(){} // RVA: 0x7FFAC3865080
        public void SetStateMachine(){} // RVA: 0x7FFAC360C270
        public void GetHashCode(){} // RVA: 0x7FFAC360C270
        public void MoveNext(){} // RVA: 0x7FFAC3865360
        public void ToString(){} // RVA: 0x7FFAC360C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC360C270
        public void HasValidInternalValue(){} // RVA: 0x7FFAC3865640
    }

    /// <summary>Originally: ÍÍÌÎÎÌÌÎÌÌÌÏÌÎÎÎÎÍÎÌÌÍÌ</summary>
    public class AsyncStateMachine_0D4A_0D4A : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Threading.CancellationTokenSource ÌÏÌÎÎÍÏÎÌÏÌÌÍÌÌÌÍÎÎÌÏÎÌ; // 0x28
        public string ÎÏÏÌÏÌÏÏÎÍÍÍÌÎÎÍÍÎÎÎÏÍÏ; // 0x30
        public ÌÍÌÍÎÏÌÏÌÍÍÎÌÍÌÍÏÏÎÍÌÍÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public ÌÎÌÌÏÌÏÍÎÌÌÌÏÌÌÌÍÌÌÎÏÍÎ ÏÎÎÎÏÍÎÌÎÍÍÏÍÍÏÎÎÏÏÌÏÎÏ; // 0x40
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x48
        public bool ÌÎÏÎÌÏÏÎÌÌÌÌÎÎÌÌÏÍÎÎÍÌÌ; // 0x50
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58
        public string ÍÌÎÏÌÏÎÌÍÍÎÌÌÎÎÍÍÌÎÏÍÍÎ; // 0x68
        public Awaiter<bool> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x70

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3246E60
        public void MoveNext(){} // RVA: 0x7FFAC3248920
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC324A390
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC324BE40
        public void ToString(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÍÌÏÏÍÍÏÌÌÍÌÌÎÍÏÏÏÍÏÍÏ</summary>
    public class AsyncStateMachine_10E7_10E7 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Economy.Internal.EconomyStoresManager ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC35D4F80
        public void MoveNext(){} // RVA: 0x7FFAC35D54B0
        public void DefaultEquals(){} // RVA: 0x7FFAC35D5A00
        public void GetHashCode(){} // RVA: 0x7FFAC35D5F30
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC35D6460
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC35D6990
        public void AssignConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÌÎÎÌÍÎÎÌÍÏÏÍÌÎÌÌÍÌÎÏ</summary>
    public class AsyncStateMachine_11D5_11D5 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÌÌÏÎÍÏÏÍÏÌÍÏÎÎÍÏÍÍÎÏÍÌÎ; // 0x20
        public ÍÏÎÎÍÏÍÌÍÎÎÏÌÎÏÍÍÏÍÏÏÎÏ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x28
        public string ÎÏÍÍÎÎÏÍÎÏÎÌÍÎÎÍÏÏÍÏÎÎÎ; // 0x30
        public UnityEngine.GameObject ÌÌÍÌÏÏÎÎÍÌÎÏÌÎÌÍÎÍÎÌÏÍÏ; // 0x38
        public UnityEngine.GameObject ÎÏÍÌÎÌÍÎÎÎÌÍÍÌÍÏÏÍÍÎÌÍÍ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC45DFAE0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC45E0370
        public void InternalGetHashCode(){} // RVA: 0x7FFAC45E0BF0
        public void GetHashCode(){} // RVA: 0x7FFAC45E1470
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC45E1D00
        public void ToString(){} // RVA: 0x7FFAC45E2580
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC45E2E10
        public void MoveNext(){} // RVA: 0x7FFAC45E36A0
    }

    /// <summary>Originally: ÍÌÎÌÎÏÎÍÍÍÍÍÌÏÍÎÏÎÎÍÌÎÏ</summary>
    public class AsyncStateMachine_13EF_13EF : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÍÌÍÌÎÏÎÍÍÌÍÍÎÍÍÌÍÍÎÍÏÌÍ; // 0x28
        public VRC.Localization.LocalizationManager ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public bool ÍÎÍÍÎÍÏÌÏÏÏÌÏÏÎÌÍÎÎÍÏÌÏ; // 0x38
        public bool ÍÎÏÏÌÌÎÏÏÏÍÏÎÎÏÍÍÏÌÏÍÍÍ; // 0x39
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC46CB100
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC46CB880
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC46CC000
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetOrInitializeCurrentUICulture(){} // RVA: 0x7FFAC46CC780
    }

    /// <summary>Originally: ÍÍÌÍÏÍÌÌÌÍÏÍÌÍÍÌÌÏÌÌÏÍÍ</summary>
    public class AsyncStateMachine_15C1_15C1 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÌÏÍÎÍÌÍÍÎÌÌÌÎÎÎÌÍÏÌÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public bool ÌÏÎÎÍÌÎÍÏÍÎÍÌÎÍÌÍÍÌÎÌÏÍ; // 0x28
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC36FF870
        public void Equals(){} // RVA: 0x7FFAC36FFEA0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC37004D0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC3700B10
        public void MoveNext(){} // RVA: 0x7FFAC3701150
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC3701780
    }

    /// <summary>Originally: ÍÎÌÏÌÏÌÏÌÌÌÎÏÏÍÌÎÌÏÍÎÏÎ</summary>
    public class AsyncStateMachine_1798_1798 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÌÏÏÏÏÎÌÏÌÌÌÏÍÍÎÎÌÍÎÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC36BC0A0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC36BCE20
        public void MoveNext(){} // RVA: 0x7FFAC36BDBB0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÏÌÌÍÍÍÎÌÍÍÎÍÎÍÍÍÎÌÍÌ</summary>
    public class AsyncStateMachine_1915_1915 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public float[] ÏÎÌÍÏÌÌÍÏÏÌÏÍÏÏÍÎÍÏÌÍÌÍ; // 0x28
        public float ÌÌÎÍÏÎÏÎÎÎÍÍÏÌÏÎÎÍÍÏÏÌÌ; // 0x30
        public ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public float ÎÏÎÍÍÎÏÌÍÎÎÌÏÏÌÌÌÍÏÏÎÌÏ; // 0x40
        public VRC.Core.Pool.PooledArray`1<float> ÌÎÌÌÌÎÎÌÍÏÎÎÍÍÌÍÏÌÏÏÎÌÍ; // 0x48
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3B5C320
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC3B5C8E0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC3B5CE40
    }

    /// <summary>Originally: ÍÎÍÏÎÏÍÍÏÍÍÌÏÎÌÍÌÏÌÏÏÎÎ</summary>
    public class AsyncStateMachine_1C13_1C13 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÎÌÎÎÏÍÌÌÍÎÎÎÎÏÍÌÏÎÍÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Runtime.CompilerServices.TaskAwaiter`1<ÎÏÏÌÏÌÍÏÍÍÎÍÎÌÍÎÌÏÌÌÍÍÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3D9CAA0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC3D9D5F0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3D9E150
        public void MoveNext(){} // RVA: 0x7FFAC3D9ECB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3D9F7E0
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÍÎÌÍÏÏÏÌÏÏÎÏÏÏÏÍÏÍÎÍ</summary>
    public class AsyncStateMachine_1D93_1D93 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÍÎÏÌÏÍÍÏÎÌÌÏÌÎÏÍÎÍÍÎÌÎ ÏÏÌÎÌÌÏÍÎÏÍÎÎÍÍÏÎÎÏÍÎÎÎ; // 0x30
        public ÏÏÌÏÎÏÏÎÏÌÌÌÌÍÍÌÏÏÍÌÎÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public System.Threading.CancellationTokenSource ÌÍÎÍÍÌÌÏÎÍÏÌÍÍÍÎÍÌÌÍÌÌÎ; // 0x40
        public UnityEngine.Transform ÎÎÎÌÎÍÏÍÏÌÍÌÌÍÌÎÎÍÍÌÍÌÌ; // 0x48
        public string ÎÍÏÏÍÎÎÌÌÎÏÏÌÍÎÏÌÏÍÌÌÌÌ; // 0x50
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58
        public Awaiter<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x68

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB78B020
        public void InternalEquals(){} // RVA: 0x7FFACB78B9F0
        public void SetStateMachine(){} // RVA: 0x7FFACB78BA20
        public void GetHashCode(){} // RVA: 0x7FFACB78BA50
        public void InternalGetHashCode(){} // RVA: 0x7FFACB78C420
        public void ToString(){} // RVA: 0x7FFACB78CDF0
        public void MoveNext(){} // RVA: 0x7FFACB78D7C0
        public void HasValidInternalValue(){} // RVA: 0x7FFACB78E190
    }

    /// <summary>Originally: ÍÍÍÎÌÎÍÏÍÌÍÍÌÌÎÏÎÌÍÍÌÎÏ</summary>
    public class AsyncStateMachine_1ECF_1ECF : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÌÌÌÌÍÍÌÌÌÌÏÌÏÏÏÏÏÏÏÌÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Runtime.CompilerServices.TaskAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFACB59BC60
        public void MoveNext(){} // RVA: 0x7FFACB59BEA0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFACB59C0E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFACB59C320
    }

    /// <summary>Originally: ÍÌÎÎÎÏÍÏÍÌÎÏÏÍÍÍÍÎÏÍÎÎÏ</summary>
    public class AsyncStateMachine_28D8_28D8 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎÌÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Action ÍÏÍÎÍÎÎÎÏÏÌÌÎÌÌÏÌÎÏÎÏÏÍ; // 0x28
        public System.Action`1<string> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ; // 0x30
        public ÌÍÍÎÎÏÌÌÌÏÍÌÍÌÍÏÎÏÏÍÌÏÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3213CA0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC3214250
        public void Equals(){} // RVA: 0x7FFAC3214810
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÏÏÍÍÌÎÎÌÌÌÌÍÌÏÍÎÏÎÌÏÍ</summary>
    public class AsyncStateMachine_298C_298C : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÏÏÎÍÍÌÏÏÌÏÍÍÍÏÏÎÏÏÌÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3607580
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC3607A90
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3607FA0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void ValidateStructPointers(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÏÍÌÌÌÌÍÎÌÌÎÏÏÎÎÌÎÍÎÌÏ</summary>
    public class AsyncStateMachine_2C08_2C08 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÎÎÍÌÌÎÏÍÏÎÎÎÌÌÎÎÍÍÌÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC360C270
        public void SetStateMachine(){} // RVA: 0x7FFAC360C270
        public void DefaultEquals(){} // RVA: 0x7FFACB3D6FF0
        public void GetHashCode(){} // RVA: 0x7FFACB3D7270
        public void InternalGetHashCode(){} // RVA: 0x7FFAC360C270
        public void ToString(){} // RVA: 0x7FFACB3D74F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFACB3D7770
        public void SetGameObjectActive(){} // RVA: 0x7FFACB3D79F0
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC360C270
        public void MoveNext(){} // RVA: 0x7FFACB3D7C70
    }

    /// <summary>Originally: ÍÍÌÏÎÎÏÍÍÌÎÏÌÎÍÍÎÎÎÌÎÎÎ</summary>
    public class AsyncStateMachine_2E60_2E60 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.GameObject> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÏÎÏÏÏÍÌÎÎÏÍÏÌÎÏÎÌÍÌÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter<UnityEngine.GameObject> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3495780
        public void SetStateMachine(){} // RVA: 0x7FFAC3495C60
        public void DefaultEquals(){} // RVA: 0x7FFAC3495C90
        public void GetHashCode(){} // RVA: 0x7FFAC3496170
        public void InternalGetHashCode(){} // RVA: 0x7FFAC34961A0
        public void ToString(){} // RVA: 0x7FFAC34961D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3496200
        public void MoveNext(){} // RVA: 0x7FFAC34966E0
    }

    /// <summary>Originally: ÍÍÍÏÎÏÎÎÏÏÏÎÍÍÌÏÎÌÎÌÍÌÎ</summary>
    public class AsyncStateMachine_3269_3269 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public bool ÍÍÌÌÎÌÍÎÎÎÎÌÏÏÍÎÌÎÍÏÎÌÌ; // 0x28
        public bool ÌÏÎÏÏÌÏÎÏÌÎÎÍÎÏÏÏÌÎÏÎÏÍ; // 0x29
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x38
        public bool ÍÎÌÍÍÍÍÌÍÎÏÍÏÌÎÏÏÏÏÌÌÏÏ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48
        public 0x6B29C858 ÏÍÎÍÏÍÎÎÍÍÎÌÍÌÎÏÏÍÍÏÍÌÌ; // 0x58
        public float ÎÏÍÏÌÏÏÎÍÍÎÌÍÏÌÎÌÍÍÍÌÏÏ; // 0x5C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC40D3420
        public void InternalEquals(){} // RVA: 0x7FFAC40D43E0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC40D5340
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC40D6270
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ValidateStructPointers(){} // RVA: 0x7FFAC40D71F0
    }

    /// <summary>Originally: ÍÎÌÍÌÍÌÎÏÍÍÍÏÏÌÎÎÏÍÏÌÎÍ</summary>
    public class AsyncStateMachine_352F_352F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÎÍÏÎÎÌÌÎÎÌÏÏÎÏÌÍÌÌÍÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÌÍÌÌÏÍÍÍÍÎÌÍÍÎÎÍÌÍÌÌÏÌÍ; // 0x30
        public 0x6B234DC0 ÌÏÎÍÍÍÎÌÌÌÍÏÌÎÌÍÌÍÏÎÍÍÎ; // 0x34
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFACB336BC0
        public void MoveNext(){} // RVA: 0x7FFACB337200
        public void InternalGetHashCode(){} // RVA: 0x7FFACB337840
        public void GetHashCode(){} // RVA: 0x7FFACB337E80
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÏÍÎÌÎÎÌÏÎÎÍÏÌÎÌÌÌÏÎÍÌ</summary>
    public class AsyncStateMachine_38BE_38BE : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public ÎÎÏÎÌÍÎÍÌÍÏÍÎÏÎÎÌÏÏÎÎÍÌ<U,V,U> ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ;
        public V ÏÍÏÌÏÍÏÍÎÏÎÍÍÎÍÎÍÌÎÏÍÏÌ;
        public int ÍÍÍÏÍÌÏÎÏÏÍÎÏÎÍÎÌÏÌÏÍÌÏ;
        public Awaiter<U> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C70980
        public void MoveNext(){} // RVA: 0x7FFAC2C70980
        public void DefaultEquals(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCode(){} // RVA: 0x7FFAC2C70980
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2C70A40
        public void ToString(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2C70980
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC2C70980
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÍÎÌÎÌÌÍÍÏÏÏÏÏÏÌÏÏÍÍÎÍÏÏ</summary>
    public class AsyncStateMachine_3A7B_3A7B : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.GameObject> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÌÏÏÌÌÍÎÍÍÎÌÎÎÎÌÌÌÏÍÏÍ ÎÌÎÍÎÌÎÌÌÎÌÎÎÎÏÌÏÌÏÌÏÍÎ; // 0x30
        public ÍÍÏÎÍÍÎÏÎÏÌÍÌÏÏÌÏÎÌÏÌÍÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public UnityEngine.Vector3 ÏÎÏÎÌÏÎÏÎÌÌÌÎÌÍÍÏÏÏÏÏÌÌ; // 0x40
        public UnityEngine.Quaternion ÎÎÍÎÌÌÌÌÎÍÌÌÎÏÏÌÌÍÍÏÍÏÌ; // 0x4C
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3918C90
        public void InternalEquals(){} // RVA: 0x7FFAC3918CC0
        public void MoveNext(){} // RVA: 0x7FFAC3919730
        public void GetHashCode(){} // RVA: 0x7FFAC391A1A0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC391A1D0
        public void SetStateMachine(){} // RVA: 0x7FFAC391AC40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC391AC70
        public void ToString(){} // RVA: 0x7FFAC391ACA0
    }

    /// <summary>Originally: ÍÌÏÍÍÏÎÏÎÎÎÌÎÏÌÍÎÎÎÏÎÍÏ</summary>
    public class AsyncStateMachine_3C1B : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public UnityEngine.Texture2D ÌÎÌÎÎÎÏÏÌÍÏÏÏÍÏÌÌÏÏÍÎÍÏ; // 0x30
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x38
        public ÎÌÎÏÌÏÏÏÍÌÏÌÍÍÌÌÎÏÌÌÌÍÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public ÏÏÌÏÍÌÎÍÍÏÌÏÏÎÎÍÌÍÍÌÏÏÎ ÍÌÎÌÏÌÌÌÏÍÎÍÎÍÎÎÍÏÎÏÏÍÍ; // 0x48
        public ulong ÍÎÏÎÍÌÎÏÍÌÍÏÌÌÎÍÏÍÌÍÏÎÍ; // 0x60
        public System.Threading.CancellationTokenSource ÍÎÍÏÌÎÍÏÍÍÌÏÌÏÍÍÍÌÎÍÍÏÏ; // 0x68
        public System.Threading.CancellationTokenSource ÎÏÍÏÍÌÍÏÎÎÏÌÏÍÎÍÌÏÏÌÎÎÌ; // 0x70
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x78

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC48FA3B0
        public void InternalEquals(){} // RVA: 0x7FFAC48FA3E0
        public void DefaultEquals(){} // RVA: 0x7FFAC48FAD20
        public void GetHashCode(){} // RVA: 0x7FFAC48FAD50
        public void InternalGetHashCode(){} // RVA: 0x7FFAC48FB6A0
        public void SetStateMachine(){} // RVA: 0x7FFAC48FBFE0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC48FC010
        public void MoveNext(){} // RVA: 0x7FFAC48FC960
    }

    /// <summary>Originally: ÍÍÏÎÍÌÎÏÎÎÍÍÍÌÏÎÍÍÎÎÎÎÌ</summary>
    public class AsyncStateMachine_3E81_3E81 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiVRChatProductDetails>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Runtime.CompilerServices.TaskAwaiter`1<VRC.Core.ApiContainer> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC478BB10
        public void InternalEquals(){} // RVA: 0x7FFAC478BB80
        public void DefaultEquals(){} // RVA: 0x7FFAC478BBF0
        public void Equals(){} // RVA: 0x7FFAC478BC60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC478C500
        public void GetHashCode(){} // RVA: 0x7FFAC478CDA0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC478D640
        public void ToString(){} // RVA: 0x7FFAC478D6B0
        public void MoveNext(){} // RVA: 0x7FFAC478DF50
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC478E7D0
    }

    /// <summary>Originally: ÍÍÎÌÏÎÏÌÏÍÎÍÍÍÎÍÌÏÎÌÍÍÍ</summary>
    public class AsyncStateMachine_3F27_3F27 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Collections.Generic.List`1<Mediapipe.Detection>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÌÌÎÍÏÍÏÌÏÍÍÎÌÌÍÏÌÌÏÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Runtime.CompilerServices.TaskAwaiter`1<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC449ED00
        public void MoveNext(){} // RVA: 0x7FFAC449ED70
        public void DefaultEquals(){} // RVA: 0x7FFAC449F290
        public void Equals(){} // RVA: 0x7FFAC449F300
        public void InternalGetHashCode(){} // RVA: 0x7FFAC449F370
        public void GetHashCode(){} // RVA: 0x7FFAC449F890
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC449F900
    }

    /// <summary>Originally: ÍÌÏÌÎÌÍÎÏÌÍÏÍÌÏÎÍÏÏÏÎÏÎ</summary>
    public class AsyncStateMachine_40B0_40B0 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÌÍÌÏÎÌÌÌÎÍÎÍÍÌÍÎÌÎÌÌÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject> ÍÏÌÌÌÍÌÌÏÏÌÍÌÏÌÎÍÏÌÌÎÎÌ; // 0x30
        public bool ÎÏÌÏÌÏÎÍÌÏÌÌÏÌÍÍÍÎÍÎÍÎÎ; // 0x38
        public bool ÎÎÍÎÎÌÎÎÎÌÌÏÎÎÎÌÍÏÏÏÌÎÎ; // 0x39
        public bool ÌÌÏÌÎÌÎÌÎÏÎÌÏÌÍÍÎÍÍÏÍÌÍ; // 0x3A
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3996760
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC3996A80
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC3996DB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC39970E0
        public void SetState(){} // RVA: 0x7FFAC3997410
        public void MoveNext(){} // RVA: 0x7FFAC3997730
    }

    /// <summary>Originally: ÍÌÎÎÍÏÎÍÌÎÏÎÏÎÌÍÎÎÏÏÎÌÌ</summary>
    public class AsyncStateMachine_459D_459D : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÎÎÏÍÏÌÍÌÎÏÌÌÎÌÌÍÍÍÎÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB7A78B0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB7A7DF0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFACB7A8310
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC2F21310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÍÏÎÏÌÏÏÏÌÌÌÍÌÌÍÏÌÏÌÎÌ</summary>
    public class AsyncStateMachine_46DB_46DB : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÌÌÏÍÌÎÌÏÏÍÌÍÎÌÍÏÍÍÏÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public ÍÎÎÎÍÎÍÍÍÌÏÎÍÎÏÎÍÍÏÏÌÏÏ ÍÏÎÍÌÍÌÍÎÌÎÏÍÍÌÏÌÏÎÍÌÌÎ; // 0x40
        public UnityEngine.AssetBundle ÍÌÎÏÌÍÏÏÏÎÍÏÌÏÌÌÎÎÏÎÎÎÏ; // 0x50
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58
        public Awaiter<int> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x68
        public Awaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0x78
        public Awaiter<ÍÎÎÎÍÎÍÍÍÌÏÎÍÎÏÎÍÍÏÏÌÏÏ> ÍÎÌÍÎÎÍÏÌÍÎÍÌÎÎÌÎÌÌÏÏÌÌ; // 0x88
        public AsyncOperationAwaiter ÏÌÏÏÌÍÏÌÎÏÌÎÍÍÎÏÌÌÍÏÌÍÌ; // 0xA8

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3C92830
        public void InternalEquals(){} // RVA: 0x7FFAC3C948D0
        public void SetStateMachine(){} // RVA: 0x7FFAC3C969E0
        public void GetHashCode(){} // RVA: 0x7FFAC3C96A40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3C969E0
        public void ToString(){} // RVA: 0x7FFAC3C98B00
        public void MoveNext(){} // RVA: 0x7FFAC3C9AB20
        public void HasValidInternalValue(){} // RVA: 0x7FFAC3C9CB80
    }

    /// <summary>Originally: ÍÍÌÎÎÌÏÌÎÍÌÌÎÌÌÍÌÎÎÌÏÌÍ</summary>
    public class AsyncStateMachine_4913_4913 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.Object> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÍÎÏÎÍÏÍÍÏÍÌÌÌÌÎÎÍÎÍÌÌÎÎ; // 0x30
        public UnityEngine.ResourceRequest ÍÎÌÏÏÌÏÎÍÌÍÏÏÍÌÎÍÎÍÏÍÎÍ; // 0x38
        public ResourceRequestAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3999B40
        public void InternalEquals(){} // RVA: 0x7FFAC399A010
        public void DefaultEquals(){} // RVA: 0x7FFAC399A4E0
        public void SetStateMachine(){} // RVA: 0x7FFAC399A510
        public void InternalGetHashCode(){} // RVA: 0x7FFAC399A540
        public void Equals(){} // RVA: 0x7FFAC399AA10
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC399AEE0
        public void GetHashCode(){} // RVA: 0x7FFAC399AF10
    }

    /// <summary>Originally: ÍÍÍÏÏÎÏÏÍÍÍÏÌÌÏÎÍÌÍÍÍÍÎ</summary>
    public class AsyncStateMachine_4B8F_4B8F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiWorldInstance ÎÌÌÏÍÌÌÏÌÍÎÍÌÎÎÌÍÍÎÍÏÎÏ; // 0x28
        public ÍÌÎÍÌÍÎÎÎÏÍÍÌÌÏÍÌÍÌÍÎÍÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3299140
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3299C80
        public void ToString(){} // RVA: 0x7FFAC329A8D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC329B410
    }

    /// <summary>Originally: ÍÍÌÎÏÍÏÌÌÌÍÌÌÏÏÍÍÍÍÎÏÍÏ</summary>
    public class AsyncStateMachine_523F_523F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÍÏÍÏÌÌÎÏÍÌÌÍÍÌÎÌÏÍÌÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x30
        public bool ÍÏÎÏÏÏÌÏÏÌÏÎÏÏÎÌÎÏÌÎÏÏÍ; // 0x38
        public Awaiter<ÍÍÎÌÏÍÍÌÌÍÎÍÌÎÏÎÎÌÌÎÍÎÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter<ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x58

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFACB489490
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB489E30
        public void InternalGetHashCode(){} // RVA: 0x7FFACB48A7D0
        public void Equals(){} // RVA: 0x7FFACB48B170
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFACB48BB10
    }

    /// <summary>Originally: ÍÍÏÌÍÍÎÏÏÎÎÎÌÍÍÌÍÎÏÏÌÏÌ</summary>
    public class AsyncStateMachine_5587_5587 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`5<U,V,W,T4,T>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public System.Threading.Tasks.Task`1<U> ÍÏÍÌÌÎÎÎÌÌÎÌÎÌÍÎÎÏÍÏÎÎÏ;
        public System.Threading.Tasks.Task`1<V> ÌÌÏÎÎÌÌÎÏÌÏÌÍÍÌÏÌÎÍÌÍÌÏ;
        public System.Threading.Tasks.Task`1<W> ÎÍÍÎÍÏÏÏÍÍÍÍÎÍÌÌÌÏÎÌÏÍÎ;
        public System.Threading.Tasks.Task`1<T4> ÌÎÏÎÎÌÌÏÌÍÎÏÍÍÏÎÌÎÎÌÎÎÍ;
        public System.Threading.Tasks.Task`1<T> ÍÍÎÍÍÎÎÍÏÍÍÌÌÌÎÎÎÎÍÌÏÏÏ;
        public System.Runtime.CompilerServices.TaskAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
        public void InternalEquals(){} // RVA: 0x7FFAC2C70980
        public void MoveNext(){} // RVA: 0x7FFAC2C70980
        public void Equals(){} // RVA: 0x7FFAC2C70980
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCode(){} // RVA: 0x7FFAC2C70980
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2C70A40
    }

    /// <summary>Originally: ÍÍÏÍÍÌÍÌÎÏÏÌÌÌÌÏÍÏÎÌÌÎÍ</summary>
    public class AsyncStateMachine_5964 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÌÎÏÎÏÌÍÏÍÌÏÍÌÍÎÎÌÏÌÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public int ÎÎÎÌÏÍÍÏÌÏÎÌÏÍÏÍÍÏÏÏÎÍÍ; // 0x28
        public string ÍÏÏÌÍÏÏÍÏÎÍÎÎÎÎÌÎÍÍÌÌÍÏ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC48D5240
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC48D5CE0
        public void GetHashCode(){} // RVA: 0x7FFAC48D6200
        public void MoveNext(){} // RVA: 0x7FFAC48D6720
        public void ToString(){} // RVA: 0x7FFAC2F21310
        // ── Unresolved (hash) ──
        public void m_6C0(){} // RVA: 0x7FFAC48D7230
    }

    /// <summary>Originally: ÍÍÌÏÍÎÍÌÌÏÍÌÍÌÏÍÏÍÏÌÍÍÏ</summary>
    public class AsyncStateMachine_6089_6089 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.Texture2D> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌÎÍÌ ÎÎÎÎÎÍÍÎÍÌÎÌÍÌÌÌÎÍÎÏÌÏÎ; // 0x30
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x38
        public ÍÍÍÏÌÏÍÏÍÏÍÎÏÌÏÏÍÍÍÍÎÏÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC46FD630
        public void InternalEquals(){} // RVA: 0x7FFAC46FDE10
        public void DefaultEquals(){} // RVA: 0x7FFAC46FE5C0
        public void Equals(){} // RVA: 0x7FFAC46FEDA0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC46FEDD0
        public void GetHashCode(){} // RVA: 0x7FFAC46FEE00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC46FF5D0
        public void SetStateMachine(){} // RVA: 0x7FFAC46FF600
    }

    /// <summary>Originally: ÍÍÎÎÍÎÍÎÌÍÌÍÏÏÍÏÎÎÏÌÏÏÏ</summary>
    public class AsyncStateMachine_6271_6271 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÌÍÌÏÎÌÌÌÎÍÎÍÍÌÍÎÌÎÌÌÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public bool ÎÏÌÏÌÏÎÍÌÏÌÌÏÌÍÍÍÎÍÎÍÎÎ; // 0x28
        public bool ÎÎÍÎÎÌÎÎÎÌÌÏÎÎÎÌÍÏÏÏÌÎÎ; // 0x29
        public ÌÎÌÍÏÍÍÌÍÏÍÍÏÍÎÌÍÎÍÏÍÍÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3997A50
        public void InternalEquals(){} // RVA: 0x7FFAC39980B0
        public void DefaultEquals(){} // RVA: 0x7FFAC3998700
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC3998D50
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC39994E0
    }

    /// <summary>Originally: ÍÍÏÏÎÎÍÍÏÍÎÌÎÍÏÎÏÍÍÌÎÍÎ</summary>
    public class AsyncStateMachine_64BE_64BE : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÏÌÏÏÏÏÎÌÍÍÌÎÎÎÌÏÎÎÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFACB482650
        public void InternalEquals(){} // RVA: 0x7FFACB482C00
        public void SetStateMachine(){} // RVA: 0x7FFAC360C270
        public void Equals(){} // RVA: 0x7FFAC360C270
        public void InternalGetHashCode(){} // RVA: 0x7FFAC360C270
        public void GetHashCode(){} // RVA: 0x7FFAC360C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC360C270
        public void ToString(){} // RVA: 0x7FFAC360C270
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC360C270
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFACB4831B0
    }

    /// <summary>Originally: ÍÍÏÌÍÌÌÏÍÍÍÍÌÏÎÌÏÌÍÍÍÎÍ</summary>
    public class AsyncStateMachine_653E_653E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public ÌÏÏÏÎÏÍÌÍÌÍÎÍÌÍÏÌÎÌÏÌÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ;
        public string ÍÌÎÌÏÌÌÌÏÍÎÍÎÍÎÎÍÏÎÏÏÍÍ;
        public Awaiter<object> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C70980
        public void InternalEquals(){} // RVA: 0x7FFAC2C70980
        public void DefaultEquals(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCode(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
        public void ToString(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2C70A40
        public void MoveNext(){} // RVA: 0x7FFAC2C70980
        public void ValidateStructPointers(){} // RVA: 0x7FFAC2C70980
        public void StartCoroutine(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÍÎÏÍÍÌÎÎÍÌÌÎÍÎÌÏÎÍÌÌÏÎÌ</summary>
    public class AsyncStateMachine_66E4_66E4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ ÍÌÏÏÍÏÏÍÎÌÎÏÌÍÎÎÏÍÌÏÍÎÍ; // 0x30
        public ÍÌÍÍÏÍÏÌÍÏÎÍÍÍÌÍÍÏÏÎÌÌÏ ÏÏÌÎÌÌÏÍÎÏÍÎÎÍÍÏÎÎÏÍÎÎÎ; // 0x38
        public ÍÌÍÍÏÍÏÌÍÏÎÍÍÍÌÍÍÏÏÎÌÌÏ ÍÏÍÏÌÍÌÍÍÏÌÏÏÏÏÌÌÍÌÏÍÌÎ; // 0x40
        public System.Collections.Generic.List`1<ÍÌÌÎÎÏÏÍÌÏÎÎÍÍÎÌÏÏÏÏÏÎÌ> ÎÌÏÏÎÌÍÌÎÍÏÍÍÎÌÎÍÏÍÎÍÍÌ; // 0x48
        public System.Collections.Generic.List`1<ÍÌÌÎÎÏÏÍÌÏÎÎÍÍÎÌÏÏÏÏÏÎÌ> ÎÍÏÍÌÎÎÌÍÎÍÌÌÎÌÌÎÍÎÏÏÍÎ; // 0x50
        public System.Collections.Generic.List`1<ÍÌÌÎÎÏÏÍÌÏÎÎÍÍÎÌÏÏÏÏÏÎÌ> ÍÏÌÍÏÍÌÍÎÍÏÍÏÍÌÌÍÍÏÍÍÎÎ; // 0x58
        public Awaiter<UnityEngine.GameObject[]> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB783B30
        public void InternalEquals(){} // RVA: 0x7FFACB783B60
        public void MoveNext(){} // RVA: 0x7FFACB783B90
        public void SetStateMachine(){} // RVA: 0x7FFACB784C50
        public void InternalGetHashCode(){} // RVA: 0x7FFACB784C80
        public void GetHashCode(){} // RVA: 0x7FFACB784CB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFACB784CE0
        public void ToString(){} // RVA: 0x7FFACB784D10
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFACB785DD0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFACB786EA0
    }

    /// <summary>Originally: ÍÍÏÏÍÌÌÍÏÍÍÏÎÎÏÎÎÎÎÏÎÎÍ</summary>
    public class AsyncStateMachine_69D3_69D3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÌÎÍÌÌÌÍÎÍÏÍÏÎÌÍÍÌÍÏÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB73D3A0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÏÏÍÎÎÏÍÌÏÍÌÎÍÍÎÌÏÏÍÎÍ</summary>
    public class AsyncStateMachine_6AE6_6AE6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÎÍÍÎÌÌÍÎÌÌÏÌÍÌÍÎÍÎÍÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Cysharp.Threading.Tasks.UniTaskCompletionSource ÏÌÎÏÍÏÏÏÌÍÏÏÍÍÏÍÎÏÎÍÌÍÏ; // 0x28
        public int ÍÎÌÎÍÏÌÌÍÏÎÌÌÏÍÏÌÍÌÏÌÌÍ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x34
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC3DFB3F0
        public void MoveNext(){} // RVA: 0x7FFAC3DFBF10
        public void GetHashCode(){} // RVA: 0x7FFAC3DFCA30
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3DFD4E0
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÎÍÌÏÌÎÍÍÏÎÌÍÎÎÌÎÎÍÎÌ</summary>
    public class AsyncStateMachine_6BD4_6BD4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÎÏÎÌÎÎÌÍÎÏÌÍÍÎÍÎÍÏÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public ÏÍÎÏÍÏÎÎÌÏÍÎÏÍÎÌÍÎÏÏÌÏÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public ÏÎÏÎÏÎÏÌÌÎÏÌÍÌÎÌÏÌÌÍÏÏÌ[] ÍÏÍÍÌÏÌÏÌÌÏÎÏÍÏÌÏÎÎÍÌÍÏ; // 0x38
        public System.Runtime.CompilerServices.TaskAwaiter`1<VRC.Economy.IProduct[]> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC36168B0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC36176A0
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3618490
        public void MoveNext(){} // RVA: 0x7FFAC3619280
    }

    /// <summary>Originally: ÍÍÍÍÎÍÏÏÏÍÌÏÌÎÏÎÎÏÏÏÏÌÍ</summary>
    public class AsyncStateMachine_6C69_6C69 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC3D77B80
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3D78030
        public void ToString(){} // RVA: 0x7FFAC3D784D0
        public void MoveNext(){} // RVA: 0x7FFAC3D78960
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÎÌÌÌÌÍÎÍÌÏÍÎÏÍÎÏÌÏÍÏÎ</summary>
    public class AsyncStateMachine_7598_7598 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÍÏÎÎÌÏÏÏÎÎÌÍÏÌÏÌÎÏÏÎÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC37497F0
        public void DefaultEquals(){} // RVA: 0x7FFAC3749B00
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC3749E20
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC374A140
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC374A460
        public void MoveNext(){} // RVA: 0x7FFAC374A770
    }

    /// <summary>Originally: ÍÌÎÏÏÌÎÏÌÎÌÏÏÎÏÌÌÎÎÍÍÎÎ</summary>
    public class AsyncStateMachine_7688_7688 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<string> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public PictureManager ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public string ÌÎÎÌÎÌÍÏÌÍÌÍÎÍÍÌÏÏÏÍÍÌÏ; // 0x38
        public byte[] ÌÍÍÌÌÏÍÏÏÌÏÏÎÌÍÍÌÌÍÌÍÏÎ; // 0x40
        public string ÌÏÎÏÌÏÍÎÍÏÏÎÍÍÏÏÍÍÌÏÌÏÌ; // 0x48
        public string ÎÍÎÌÌÍÌÎÌÏÌÎÎÍÏÌÌÌÏÍÎÍÍ; // 0x50
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58
        public object ÍÎÌÍÌÍÍÎÎÏÍÎÌÌÎÌÌÎÍÎÍÎÎ; // 0x60
        public int ÌÌÎÏÎÎÏÏÎÎÌÏÎÎÍÍÍÍÎÌÎÌÏ; // 0x68
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x70

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC42AAFC0
        public void SetStateMachine(){} // RVA: 0x7FFAC42AB7E0
        public void MoveNext(){} // RVA: 0x7FFAC42AB810
        public void GetHashCode(){} // RVA: 0x7FFAC42AC040
        public void InternalGetHashCode(){} // RVA: 0x7FFAC42AC070
        public void ToString(){} // RVA: 0x7FFAC42AC0A0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC42AC0D0
    }

    /// <summary>Originally: ÍÍÌÏÍÌÏÏÍÍÏÌÍÍÏÌÌÌÏÍÌÌÎ</summary>
    public class AsyncStateMachine_7AE8_7AE8 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.IReadOnlyList`1<ÍÍÎÍÌÌÏÏÏÎÏÏÍÌÎÍÍÌÌÎÏÎÏ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public bool ÌÌÏÌÏÌÏÍÌÏÎÍÎÏÍÎÌÍÎÌÎÎÍ; // 0x30
        public string ÏÍÍÏÌÏÌÏÏÌÌÎÌÎÏÌÏÍÏÎÎÍÎ; // 0x38
        public Awaiter<System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiStoreShelf>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC35D9C10
        public void InternalEquals(){} // RVA: 0x7FFAC35DA140
        public void DefaultEquals(){} // RVA: 0x7FFAC35DA170
        public void SetStateMachine(){} // RVA: 0x7FFAC35DA6A0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC35DA6D0
        public void Equals(){} // RVA: 0x7FFAC35DAC00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC35DB120
        public void GetHashCode(){} // RVA: 0x7FFAC35DB640
    }

    /// <summary>Originally: ÍÎÏÍÍÎÏÎÎÍÎÌÍÎÌÍÎÏÌÌÌÏÎ</summary>
    public class AsyncStateMachine_7FFF : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<ÎÌÍÍÏÏÏÎÏÎÌÏÎÎÌÍÏÎÍÏÌÍÌ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÎÏÌÏÏÏÍÌÏÌÍÍÌÌÎÏÌÌÌÍÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x48
        public ÏÏÌÏÍÌÎÍÍÏÌÏÏÎÎÍÌÍÍÌÏÏÎ ÍÌÎÌÏÌÌÌÏÍÎÍÎÍÎÎÍÏÎÏÏÍÍ; // 0x50
        public int ÌÍÌÎÎÎÏÏÌÏÏÍÎÎÎÏÎÎÎÎÍÍÎ; // 0x68
        public bool ÏÏÏÎÌÌÎÎÎÍÎÌÌÏÍÌÌÎÎÌÍÎÎ; // 0x6C
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x70
        public ÍÎÎÎÎÌÍÌÏÏÎÎÏÍÎÏÎÎÎÌÎÌÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x78
        public bool ÍÌÎÍÎÍÏÏÌÏÍÏÍÌÌÎÎÌÎÏÌÎÌ; // 0x80
        public UnityEngine.Texture2D ÍÍÍÏÌÍÍÎÌÎÏÏÍÌÏÌÎÍÎÏÎÎÎ; // 0x88
        public bool ÏÍÎÏÎÏÏÏÍÏÎÏÎÎÎÏÌÌÎÌÌÍÎ; // 0x90
        public Awaiter<UnityEngine.Texture2D> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x98
        public Awaiter<bool> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0xB0
        public UnityEngine.Texture2D ÎÌÏÏÏÏÎÌÌÍÏÍÌÏÏÏÎÍÎÎÍÎÌ; // 0xC0
        public Awaiter<System.ValueTuple`2<bool,UnityEngine.Texture2D>> ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0xC8
        public Awaiter ÍÎÌÍÎÎÍÏÌÍÎÍÌÎÎÌÎÌÌÏÏÌÌ; // 0xE8

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4900F90
        public void InternalEquals(){} // RVA: 0x7FFAC4900FC0
        public void MoveNext(){} // RVA: 0x7FFAC4900FF0
        public void SetStateMachine(){} // RVA: 0x7FFAC4902D30
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4902D60
        public void GetHashCode(){} // RVA: 0x7FFAC4902D90
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4902DC0
        public void ToString(){} // RVA: 0x7FFAC4904B00
    }

    /// <summary>Originally: ÍÍÏÎÎÌÌÍÏÌÍÍÍÎÍÏÌÎÎÏÎÏÌ</summary>
    public class AsyncStateMachine_8012_8012 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÍÏÎÌÍÏÌÏÍÏÎÌÎÍÎÍÍÏÎÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC41C8480
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC41C8BE0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC41C9340
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC41C9A90
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC41CA1E0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC41CA930
    }

    /// <summary>Originally: ÍÌÎÏÍÍÏÏÍÏÏÏÎÏÌÍÍÏÏÍÎÏÍ</summary>
    public class AsyncStateMachine_8659_8659 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public bool ÍÌÏÏÌÏÎÍÎÏÌÍÌÍÏÍÍÏÌÎÌÍÌ; // 0x28
        public float ÎÌÌÎÍÌÌÎÌÎÌÌÎÎÏÍÍÎÎÌÍÍÏ; // 0x2C
        public float ÏÏÎÎÍÎÍÌÏÌÎÎÎÌÎÍÏÌÏÍÌÎÎ; // 0x30
        public float ÏÌÏÍÏÎÌÌÍÌÌÎÍÏÍÏÎÎÏÌÏÏÏ; // 0x34
        public float ÏÌÌÎÌÎÏÏÍÎÍÎÎÎÏÍÌÎÏÏÎÏÏ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC3D78DF0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3D793F0
        public void MoveNext(){} // RVA: 0x7FFAC3D799F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3D79FC0
    }

    /// <summary>Originally: ÍÍÎÌÌÌÌÎÍÍÍÍÌÌÍÎÏÏÏÍÌÌÏ</summary>
    public class AsyncStateMachine_86A6_86A6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÌÌÎÎÎÎÎÌÎÏÌÍÏÏÍÎÏÎÎÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public UnityEngine.GameObject ÏÎÎÌÏÌÍÏÍÌÍÏÎÎÎÎÎÍÌÏÌÌÎ; // 0x30
        public System.Action`1<UnityEngine.GameObject> ÏÏÏÎÎÎÏÏÌÏÏÏÎÌÌÎÍÏÎÍÏÏÍ; // 0x38
        public System.Action`1<string> ÌÌÍÏÍÍÏÌÌÏÎÌÎÌÍÌÏÏÌÍÎÎÍ; // 0x40
        public Awaiter<UnityEngine.GameObject> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC474ECB0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC474F010
        public void MoveNext(){} // RVA: 0x7FFAC474F370
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC474F6D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC474FA30
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC474FD90
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÎÏÏÌÌÌÌÏÍÌÌÏÌÍÏÏÎÏÍÍÎ</summary>
    public class AsyncStateMachine_86F9 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<long> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÎÏÌÏÏÏÍÌÏÌÍÍÌÌÎÏÌÌÌÍÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter<long> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC48FE080
        public void MoveNext(){} // RVA: 0x7FFAC48FE0B0
        public void SetStateMachine(){} // RVA: 0x7FFAC48FE3D0
        public void GetHashCode(){} // RVA: 0x7FFAC48FE400
        public void InternalGetHashCode(){} // RVA: 0x7FFAC48FE430
        public void ToString(){} // RVA: 0x7FFAC48FE460
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC48FE490
        // ── Unresolved (hash) ──
        public void m_5EB(){} // RVA: 0x7FFAC48FE4C0
        public void m_0AA(){} // RVA: 0x7FFAC48FE4F0
        public void m_776(){} // RVA: 0x7FFAC48FE520
    }

    /// <summary>Originally: ÍÎÍÌÎÌÎÌÏÎÍÍÌÎÍÏÌÏÌÏÌÎÍ</summary>
    public class AsyncStateMachine_89C3_89C3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x28
        public ÍÌÎÌÏÍÌÎÍÏÏÌÍÎÌÏÌÍÍÌÌÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC4294BC0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4294F10
        public void MoveNext(){} // RVA: 0x7FFAC4295270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC42955C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÍÌÌÌÍÎÎÏÌÌÍÍÌÌÏÏÌÍÍÎÏ</summary>
    public class AsyncStateMachine_89E7_89E7 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÌÌÍÌÍÍÏÎÏÍÏÍÎÍÍÍÌÏÏÌÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÌÍÎÏÎÌÌÌÏÏÏÌÍÍÏÎÌÏÍÏÏÌÏ; // 0x30
        public int ÏÍÌÍÌÍÎÎÍÎÌÎÍÏÍÍÍÎÍÎÏÎÌ; // 0x34
        public System.Runtime.CompilerServices.TaskAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC36E6F90
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC36E76E0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÎÍÏÌÏÎÏÎÎÎÏÌÏÍÌÎÌÌÌÎÏ</summary>
    public class AsyncStateMachine_8A12_8A12 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÍÍÌÏÍÏÍÏÌÎÍÏÍÎÏÏÍÍÏÍÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC33C3B40
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC33C4740
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÌÎÍÏÎÍÍÏÍÍÍÌÎÍÏÎÎÏÍÍÍ</summary>
    public class AsyncStateMachine_9237_9237 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÍÎÍÎÏÎÌÌÏÎÏÍÏÍÌÎÍÎÍÍÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x30
        public bool ÍÏÎÎÎÏÌÎÍÍÏÌÍÏÍÏÍÎÏÏÌÍÏ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFACB9B6160
        public void DefaultEquals(){} // RVA: 0x7FFACB9B64A0
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFACB9B67E0
        public void GetHashCode(){} // RVA: 0x7FFACB9B6B20
        public void MoveNext(){} // RVA: 0x7FFACB9B6E50
    }

    /// <summary>Originally: ÍÌÏÌÎÍÏÎÏÏÍÌÍÍÎÍÎÍÍÌÎÌÎ</summary>
    public class AsyncStateMachine_95C3_95C3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÎÌÏÏÏÏÍÍÏÏÎÍÍÎÎÌÎÏÏÍÎÎÎ; // 0x28
        public ÎÎÎÏÏÏÎÍÎÍÏÍÌÍÏÍÌÌÌÎÌÍÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public int ÎÏÏÍÍÏÍÍÏÌÏÎÍÎÌÍÍÏÍÎÌÎÍ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC43ECEF0
        public void DefaultEquals(){} // RVA: 0x7FFAC43EDCF0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC43EEA20
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÌÎÌÏÌÎÏÍÍÎÏÌÎÏÎÌÏÏÎÎÌ</summary>
    public class AsyncStateMachine_972F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.UI.Core.Styles.StyleEngine ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public Awaiter<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFACB257BB0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFACB2580D0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFACB2585F0
        public void ToString(){} // RVA: 0x7FFACB258B10
        // ── Unresolved (hash) ──
        public void m_496(){} // RVA: 0x7FFAC2F21310
        public void m_B43(){} // RVA: 0x7FFACB259030
    }

    /// <summary>Originally: ÍÎÌÌÌÌÏÏÍÏÍÍÏÎÏÌÍÍÎÌÌÌÏ</summary>
    public class AsyncStateMachine_9C79_9C79 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public UnityEngine.RenderTexture ÎÌÎÏÌÍÏÎÎÏÍÌÎÏÍÏÌÎÎÏÎÌÏ; // 0x30
        public UnityEngine.Texture2D ÎÎÎÍÍÍÎÏÍÏÏÏÎÍÏÎÍÍÎÌÎÏÍ; // 0x38
        public ÏÎÍÌÎÏÍÏÍÏÏÏÎÏÎÏÏÏÎÎÌÎÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC46BA2A0
        public void InternalEquals(){} // RVA: 0x7FFAC46BAA00
        public void DefaultEquals(){} // RVA: 0x7FFAC46BB160
        public void GetHashCode(){} // RVA: 0x7FFAC46BB8C0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC46BC010
        public void MoveNext(){} // RVA: 0x7FFAC46BC770
        public void SetStateMachine(){} // RVA: 0x7FFAC46BCEC0
        public void ToString(){} // RVA: 0x7FFAC46BCEF0
        public void Initialize(){} // RVA: 0x7FFAC46BD650
    }

    /// <summary>Originally: ÍÎÎÍÍÍÏÍÎÏÌÌÏÌÌÍÎÍÎÎÏÏÎ</summary>
    public class AsyncStateMachine_A0DC_A0DC : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÌÌÌÌÎÎÌÍÍÏÍÎÍÌÎÏÌÎÏÌÏ ÎÍÏÏÏÏÎÍÎÎÏÎÍÍÎÏÌÌÍÍÍÌÍ; // 0x28
        public ÍÏÌÏÎÎÏÍÎÌÌÍÍÌÏÎÏÍÎÍÍÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public string ÏÏÎÎÏÍÌÎÍÎÍÏÌÍÍÏÍÌÌÌÍÏÏ; // 0x38
        public System.Runtime.CompilerServices.TaskAwaiter`1<VRC.Core.ApiContainer> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC477DC90
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC477EA00
        public void MoveNext(){} // RVA: 0x7FFAC477F780
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC47804F0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC4781270
    }

    /// <summary>Originally: ÍÎÌÌÌÏÏÎÏÏÎÍÏÎÌÏÌÍÎÎÏÏÏ</summary>
    public class AsyncStateMachine_A486_A486 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÏÏÌÏÌÌÌÌÏÏÎÏÏÌÍÍÍÏÏÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public ÍÍÌÎÌÏÎÏÍÏÍÏÎÍÌÏÌÏÎÎÍÌÏ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter<int> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC32D4680
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC32D4EE0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC32D5730
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC32D5F90
    }

    /// <summary>Originally: ÍÍÏÎÏÎÏÏÏÎÌÌÎÎÎÌÎÌÌÏÍÎÎ</summary>
    public class AsyncStateMachine_ABB4_ABB4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÍÎÌÎÎÎÎÍÌÎÏÌÏÍÎÏÌÏÏÏÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB7EF720
        public void InternalEquals(){} // RVA: 0x7FFACB7EFC20
        public void DefaultEquals(){} // RVA: 0x7FFACB7F0110
        public void GetHashCode(){} // RVA: 0x7FFACB7F05F0
        public void MoveNext(){} // RVA: 0x7FFACB7F0AE0
        public void ToString(){} // RVA: 0x7FFACB7F0FE0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ValidateStructPointers(){} // RVA: 0x7FFACB7F14E0
        public void Initialize(){} // RVA: 0x7FFACB7F19C0
    }

    /// <summary>Originally: ÍÎÎÎÏÏÎÎÍÎÏÏÍÍÏÌÎÍÌÏÏÎÍ</summary>
    public class AsyncStateMachine_AD91_AD91 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public 0x6AFF7978 ÎÌÏÍÍÌÌÎÍÍÍÏÏÍÌÎÍÎÎÍÌÍÍ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter<VRC.Core.ApiWorldInstance> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3D4C9A0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void AssignConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÌÌÏÍÍÍÍÎÌÌÏÌÍÏÏÍÍÍÏÏ</summary>
    public class AsyncStateMachine_ADC3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.List`1<T>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public string ÎÏÏÌÎÌÏÍÎÍÌÍÏÌÍÏÍÎÏÍÏÌÏ;
        public System.Action`1<System.Collections.IEnumerable> ÍÏÍÎÍÎÎÎÏÏÌÌÎÌÌÏÌÎÏÎÏÏÍ;
        public System.Action`1<string> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ;
        public System.Collections.Generic.List`1<T> ÌÏÌÍÎÌÍÎÌÌÏÏÏÌÌÍÌÏÌÍÍÌÍ;
        public Awaiter<System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiInventoryItem>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C70A40
        public void MoveNext(){} // RVA: 0x7FFAC2C70980
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCode(){} // RVA: 0x7FFAC2C70980
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2C70A40
        public void ToString(){} // RVA: 0x7FFAC2C70980
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2C70980
        public void MoveNext_6392243295A0(){} // RVA: 0x7FFAC2C70980
        public void StartCoroutine(){} // RVA: 0x7FFAC2C70980
        public void MoveNext_D3EA4DFC56AD(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÍÌÏÏÍÏÍÌÍÍÏÌÏÌÌÍÏÍÍÍÌÏÌ</summary>
    public class AsyncStateMachine_AFE4_AFE4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÍÌÍÏÎÌÌÌÏÏÍÏÍÍÏÍÌÎÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public ÍÍÏÌÎÎÍÎÍÎÎÍÏÍÎÌÏÌÌÎÏÍÎ ÌÌÎÌÎÎÍÌÎÎÍÌÍÏÌÍÏÌÌÎÏÌÌ; // 0x38
        public 0x6B24D498 ÏÎÏÏÍÍÌÌÎÌÎÏÎÎÍÏÌÎÌÍÌÏÎ; // 0x50
        public UnityEngine.Networking.UnityWebRequest ÌÌÏÌÌÏÎÌÏÍÌÎÎÏÌÍÍÌÏÍÌÍÌ; // 0x58
        public Awaiter<ÏÍÍÍÎÏÍÏÎÏÏÌÍÍÏÍÏÏÏÏÏÏÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3CCD4D0
        public void MoveNext(){} // RVA: 0x7FFAC3CCDB70
        public void DefaultEquals(){} // RVA: 0x7FFAC3CCE210
        public void GetHashCode(){} // RVA: 0x7FFAC3CCE240
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3CCE8E0
        public void ToString(){} // RVA: 0x7FFAC3CCEF80
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3CCEFB0
        public void SetStateMachine(){} // RVA: 0x7FFAC3CCF650
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC3CCF680
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC3CCF6B0
    }

    /// <summary>Originally: ÍÍÎÌÌÌÌÏÎÏÏÍÌÏÍÍÍÍÏÎÎÎÎ</summary>
    public class AsyncStateMachine_B028_B028 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`3<string,bool,VRC.Localization.LocalizableString>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.APIUser ÌÎÎÌÌÌÍÌÍÍÏÎÎÏÏÎÎÏÍÌÎÎÎ; // 0x60
        public System.ValueTuple`2<string,bool> ÎÌÍÌÍÌÎÎÍÍÏÌÍÏÎÌÍÏÍÏÎÌÏ; // 0x68
        public VRC.Core.ApiWorldInstance ÏÌÌÍÎÏÎÎÏÍÎÍÎÏÌÍÍÎÏÏÍÌÏ; // 0x78
        public System.Runtime.CompilerServices.TaskAwaiter`1<System.ValueTuple`2<VRC.Core.ApiWorldInstance,VRC.Core.ApiContainer>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x80
        public VRC.Core.ApiWorldInstance ÍÎÌÍÌÍÍÎÎÏÍÎÌÌÎÌÌÎÍÎÍÎÎ; // 0x88
        public Awaiter<VRC.Core.ApiWorld> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x90

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC43F6920
        public void InternalEquals(){} // RVA: 0x7FFAC43F8370
        public void DefaultEquals(){} // RVA: 0x7FFAC43FA1B0
        public void GetHashCode(){} // RVA: 0x7FFAC43FA1E0
        public void MoveNext(){} // RVA: 0x7FFAC43FC020
        public void SetStateMachine(){} // RVA: 0x7FFAC43FDED0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC43FDF00
        public void ToString(){} // RVA: 0x7FFAC43FFD30
        public void ValidateStructPointers(){} // RVA: 0x7FFAC44019E0
    }

    /// <summary>Originally: ÍÍÌÎÏÎÎÌÍÏÏÏÏÍÏÍÎÍÌÏÌÏÌ</summary>
    public class AsyncStateMachine_B1F1_B1F1 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÍÏÏÌÌÎÎÍÏÌÍÌÏÎÏÍÍÍÍÍÌÍÍ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC47173E0
        public void InternalEquals(){} // RVA: 0x7FFAC4717960
        public void DefaultEquals(){} // RVA: 0x7FFAC4717FB0
        public void MoveNext(){} // RVA: 0x7FFAC47185F0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4718C30
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÌÏÌÎÎÌÌÍÌÌÌÍÎÎÌÏÎÎÎÌÎÏ</summary>
    public class AsyncStateMachine_B3D6_B3D6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`4<int,string,int,bool>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÍÍÍÌÌÌÍÏÍÏÏÎÌÌÏÌÍÏÍÎÌÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public Awaiter<System.ValueTuple`4<int,string,int,bool>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3290BC0
        public void InternalEquals(){} // RVA: 0x7FFAC32914D0
        public void DefaultEquals(){} // RVA: 0x7FFAC3291500
        public void GetHashCode(){} // RVA: 0x7FFAC3291E20
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3292740
        public void ToString(){} // RVA: 0x7FFAC3293050
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3293080
        public void SetStateMachine(){} // RVA: 0x7FFAC3293990
        public void MoveNext(){} // RVA: 0x7FFAC32939C0
    }

    /// <summary>Originally: ÍÍÎÍÌÌÌÍÌÏÏÏÏÎÍÌÎÌÎÎÎÌÎ</summary>
    public class AsyncStateMachine_B520_B520 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÌÏÎÎÎÎÎÌÍÏÌÍÏÍÏÎÎÌÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public ÏÎÍÏÍÌÌÍÍÏÎÌÍÎÏÎÌÏÌÍÎÌÍ ÌÌÍÏÍÏÎÍÏÎÎÏÎÎÎÎÍÌÎÏÏÍÎ; // 0x38
        public ÏÌÍÎÏÌÎÌÎÎÎÎÍÏÍÎÎÏÎÌÍÌÍ ÎÌÎÍÏÌÌÍÎÎÎÎÌÏÏÎÌÌÏÍÎÎÏ; // 0x40
        public VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface ÎÎÎÏÏÌÎÎÍÎÌÌÏÌÍÌÍÍÌÏÌÎÎ; // 0x98
        public VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist`1<UnityEngine.Object> ÏÏÏÍÍÎÏÌÎÍÎÎÍÍÎÎÌÍÍÏÏÏÏ; // 0xA0
        public System.ReadOnlyMemory`1<byte> ÍÏÌÌÍÏÎÍÌÌÏÎÌÌÍÏÍÌÎÏÌÌÏ; // 0xA8
        public float ÍÏÎÏÏÎÍÌÌÏÎÌÍÍÍÌÎÎÌÏÎÌÎ; // 0xB8
        public ÏÎÍÏÍÌÌÍÍÏÎÌÍÎÏÎÌÏÌÍÎÌÍ ÏÎÏÎÍÌÍÎÍÌÍÏÌÏÌÌÌÎÎÏÏÌÍ; // 0xC0
        public object ÌÏÍÍÌÍÎÌÌÍÏÎÎÍÏÏÏÌÌÏÏÌÎ; // 0xC8
        public int ÍÎÌÍÌÍÍÎÎÏÍÎÌÌÎÌÌÎÍÎÍÎÎ; // 0xD0
        public bool ÌÌÎÏÎÎÏÏÎÎÌÏÎÎÍÍÍÍÎÌÎÌÏ; // 0xD4
        public Awaiter<System.ValueTuple`2<UnityEngine.GameObject,VRC.SDK3.Props.Components.VRCPropDescriptor>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0xD8
        public System.Runtime.CompilerServices.ValueTaskAwaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0xF8

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC333BE50
        public void MoveNext(){} // RVA: 0x7FFAC333BE80
        public void DefaultEquals(){} // RVA: 0x7FFAC333E190
        public void GetHashCode(){} // RVA: 0x7FFAC33404B0
        public void SetStateMachine(){} // RVA: 0x7FFAC3342790
        public void ToString(){} // RVA: 0x7FFAC33427C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3344A80
        public void Initialize(){} // RVA: 0x7FFAC3346D50
        public void InitializeInternal(){} // RVA: 0x7FFAC3348FE0
        public void SetAnimatedTextureInternalData(){} // RVA: 0x7FFAC3349010
    }

    /// <summary>Originally: ÍÍÎÍÎÎÎÏÏÍÍÍÎÍÏÏÌÍÍÏÍÌÌ</summary>
    public class AsyncStateMachine_B561_B561 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public int ÌÌÎÍÎÍÏÍÎÍÍÏÏÎÍÏÎÎÍÏÏÏÏ; // 0x20
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x28
        public ÌÎÏÍÍÏÎÎÌÎÏÌÌÎÏÍÎÌÎÏÍÌÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB748FA0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFACB7492C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFACB7495E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB7498F0
        public void ValidateStructPointers(){} // RVA: 0x7FFACB749C00
    }

    /// <summary>Originally: ÍÍÍÎÌÌÍÎÌÍÍÏÏÌÌÏÍÌÍÎÎÍÎ</summary>
    public class AsyncStateMachine_B68C_B68C : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public ÎÏÏÏÎÍÍÌÎÎÍÌÌÌÍÏÏÎÎÍÎÏÏ<T> ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ;
        public object ÎÍÎÏÏÌÎÎÏÍÍÎÌÌÍÏÎÍÍÎÍÎÌ;
        public T ÎÌÍÍÏÌÎÍÏÎÏÍÎÍÏÎÏÎÍÌÌÌÍ;
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C70A40
        public void MoveNext(){} // RVA: 0x7FFAC2C70980
        public void DefaultEquals(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCode(){} // RVA: 0x7FFAC2C70980
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2C70A40
        public void ToString(){} // RVA: 0x7FFAC2C70A40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2C70980
        public void ContainsChild(){} // RVA: 0x7FFAC2C70A40
        public void SetStateMachine(){} // RVA: 0x7FFAC2C70A40
    }

    /// <summary>Originally: ÍÎÏÌÍÏÏÏÏÍÎÎÎÌÏÍÎÏÏÏÌÍÏ</summary>
    public class AsyncStateMachine_B811_B811 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x20

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFACB4F4B80
        public void Equals(){} // RVA: 0x7FFACB4F4FE0
        public void InternalGetHashCode(){} // RVA: 0x7FFACB4F5450
        public void GetHashCode(){} // RVA: 0x7FFACB4F58D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB4F5D50
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÎÍÍÍÎÏÎÌÍÎÌÏÌÍÎÍÍÌÏÍ</summary>
    public class AsyncStateMachine_BB6E_BB6E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÌÌÍÌÎÍÍÌÌÏÌÌÏÏÎÌÍÏÌÏÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x28
        public ÍÍÍÏÏÎÍÎÏÍÍÏÎÎÏÏÎÎÌÌÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public object ÍÍÎÏÎÍÍÌÌÍÍÌÍÎÎÍÌÎÌÏÎÌÏ; // 0x40
        public int ÌÏÍÍÌÍÎÌÌÍÏÎÎÍÏÏÏÌÌÏÏÌÎ; // 0x48
        public Awaiter<System.Collections.Generic.IEnumerable`1<VRC.Core.ApiFile>> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x50
        public Awaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0x68
        public System.Exception ÍÎÏÍÏÎÌÏÏÌÎÏÏÌÎÎÍÌÎÎÍÍÎ; // 0x78
        public Awaiter ÍÎÌÍÎÎÍÏÌÍÎÍÌÎÎÌÎÌÌÏÏÌÌ; // 0x80

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC35198D0
        public void InternalEquals(){} // RVA: 0x7FFAC351A540
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC351B1C0
        public void Equals(){} // RVA: 0x7FFAC351BE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC351CAB0
    }

    /// <summary>Originally: ÍÍÌÍÍÎÎÏÎÌÌÌÌÎÏÍÍÎÎÎÎÍÎ</summary>
    public class AsyncStateMachine_C065 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÌÏÍÌÎÌÏÌÎÍÍÏÏÍÍÌÌÌÌÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public float ÌÍÏÌÌÏÌÏÌÍÍÏÎÌÏÏÍÌÍÍÍÏÌ; // 0x30
        public float ÍÍÌÏÎÎÍÍÎÍÏÍÍÌÍÍÌÍÍÏÌÌÍ; // 0x34
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC365B1E0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÍÎÎÍÏÍÏÍÎÍÌÎÏÎÌÍÎÏÌÌÌ</summary>
    public class AsyncStateMachine_C613_C613 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Action`1<string> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ; // 0x28
        public ÍÎÎÏÍÎÎÏÌÎÌÍÎÏÌÌÏÎÌÌÏÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Action`1<System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ>> ÍÏÍÎÍÎÎÎÏÏÌÌÎÌÌÏÌÎÏÎÏÏÍ; // 0x38
        public System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ> ÎÌÍÏÎÌÎÌÍÏÎÍÍÏÏÌÎÏÎÎÌÏÏ; // 0x40
        public Awaiter<System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC32F69B0
        public void InternalEquals(){} // RVA: 0x7FFAC32F7600
        public void DefaultEquals(){} // RVA: 0x7FFAC32F8200
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC32F8E60
        public void ValidateStructPointers(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÎÎÍÏÏÍÎÍÎÌÌÎÏÏÌÎÌÎÏÏÏ</summary>
    public class AsyncStateMachine_C700_C700 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÍÌÍÏÎÌÌÌÏÏÍÏÍÍÏÍÌÎÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public ÍÍÏÌÎÎÍÎÍÎÎÍÏÍÎÌÏÌÌÎÏÍÎ ÌÌÎÌÎÎÍÌÎÎÍÌÍÏÌÍÏÌÌÎÏÌÌ; // 0x38
        public 0x6B24D498 ÏÎÏÏÍÍÌÌÎÌÎÏÎÎÍÏÌÎÌÍÌÏÎ; // 0x50
        public System.Collections.Generic.Dictionary`2<string,string> ÍÎÍÎÏÍÎÌÏÍÌÎÌÌÍÏÍÎÏÎÍÏÍ; // 0x58
        public Awaiter<ÏÍÍÍÎÏÍÏÎÏÏÌÍÍÏÍÏÏÏÏÏÏÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3CCF6E0
        public void SetStateMachine(){} // RVA: 0x7FFAC3CCFDB0
        public void MoveNext(){} // RVA: 0x7FFAC3CCFDE0
        public void GetHashCode(){} // RVA: 0x7FFAC3CD04B0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3CD04E0
        public void ToString(){} // RVA: 0x7FFAC3CD0510
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3CD0540
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFAC3CD0C10
        public void Start(){} // RVA: 0x7FFAC3CD12E0
        public void Create(){} // RVA: 0x7FFAC3CD19B0
    }

    /// <summary>Originally: ÍÌÏÏÎÍÌÍÍÏÎÌÏÏÎÌÍÌÎÎÏÎÌ</summary>
    public class AsyncStateMachine_C980_C980 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Collections.Generic.Dictionary`2<string,Token>[] ÍÌÏÌÍÌÎÏÍÎÍÏÍÎÏÎÍÎÏÌÍÎÍ; // 0x20
        public int ÌÌÎÍÏÍÍÌÎÌÍÌÍÍÌÌÍÏÌÏÎÍÌ; // 0x28
        public ÍÎÍÌÌÎÏÎÍÍÌÌÍÌÍÌÌÍÏÌÏÏÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public bool ÏÏÌÏÏÎÌÍÍÌÍÍÎÎÎÎÍÎÎÍÌÍÍ; // 0x38
        public int ÎÌÎÎÍÌÍÌÏÏÌÍÍÎÌÎÍÍÍÍÌÌÎ; // 0x3C
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x50
        public Awaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC361A0E0
        public void InternalEquals(){} // RVA: 0x7FFAC361C1D0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC361E2D0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3620360
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC3622440
        public void ToString(){} // RVA: 0x7FFAC3624550
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC3626630
    }

    /// <summary>Originally: ÍÌÎÌÎÏÏÌÎÌÍÍÌÍÎÏÏÏÌÌÌÎÏ</summary>
    public class AsyncStateMachine_CB63_CB63 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÌÎÏÎÏÍÌÌÎÍÏÏÌÏÍÎÍÍÎÌÌ ÎÌÎÍÏÌÌÍÎÎÎÎÌÏÏÎÌÌÏÍÎÎÏ; // 0x28
        public ÎÎÏÏÍÍÏÍÏÌÏÏÌÎÏÌÎÏÌÌÏÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter<System.Collections.Generic.List`1<ÎÎÎÍÌÌÍÏÏÌÏÌÎÏÏÌÏÌÍÌÏÍÍ>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB4CA530
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFACB4CB2D0
        public void GetHashCode(){} // RVA: 0x7FFACB4CC070
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB4CCE10
    }

    /// <summary>Originally: ÍÌÏÎÏÍÎÎÌÌÎÏÎÌÌÎÍÏÍÌÍÎÍ</summary>
    public class AsyncStateMachine_D060_D060 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÍÎÏÌÎÌÍÏÎÏÌÏÌÌÎÎÌÏÏÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC34F6240
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void HasValidInternalValue(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÍÎÎÎÍÎÍÌÎÌÎÏÏÍÌÏÎÏÎÍÍ</summary>
    public class AsyncStateMachine_D594_D594 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Collections.IList ÍÌÍÌÏÍÍÌÎÎÎÏÎÏÍÎÎÌÌÌÍÌÏ; // 0x20
        public ÌÍÌÏÎÏÎÎÍÎÎÎÌÌÌÏÏÍÏÍÏÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Collections.Generic.List`1<ÎÎÏÌÍÌÌÍÍÌÏÎÍÍÏÍÌÎÌÍÎÍÏ> ÏÎÌÎÏÌÌÌÎÎÎÎÍÌÏÏÎÌÌÎÌÎÌ; // 0x30
        public Awaiter<ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ[]> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFACB5123A0
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB512EA0
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void ValidateStructPointers(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÍÌÌÍÎÎÎÍÏÍÌÍÌÍÏÍÏÍÍÌ</summary>
    public class AsyncStateMachine_D924_D924 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÌÍÌÎÍÌÎÏÎÏÎÏÏÍÎÏÎÌÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public long ÍÎÌÎÌÌÎÎÍÎÌÏÎÍÎÏÍÏÎÌÏÎÍ; // 0x28
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC43BE070
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC43BE460
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC43BE840
        public void MoveNext_6C0187(){} // RVA: 0x7FFAC43BEC30
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÌÎÎÍÏÏÌÌÌÎÌÎÍÍÍÌÌÌÌÏÏ</summary>
    public class AsyncStateMachine_DC37 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.GameObject> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÎÍÎÍÎÏÍÍÌÌÎÌÌÌÍÎÏÍÏÍÎ ÍÌÌÍÎÌÌÍÏÍÌÌÏÎÌÎÍÏÎÏÎÎÌ; // 0x30
        public ÍÌÌÎÎÏÏÍÌÏÎÎÍÍÎÌÏÏÏÏÏÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x48
        public bool ÍÎÎÍÍÎÏÏÏÍÏÏÎÌÏÎÎÎÏÌÎÏÏ; // 0x50
        public System.Threading.CancellationToken ÏÍÍÎÎÌÏÎÏÌÌÍÎÍÏÏÍÌÎÍÌÍÎ; // 0x58
        public ResourceRequestAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACBA14C90
        public void InternalEquals(){} // RVA: 0x7FFACBA15EC0
        public void DefaultEquals(){} // RVA: 0x7FFACBA15EF0
        public void SetStateMachine(){} // RVA: 0x7FFACBA15F20
        public void InternalGetHashCode(){} // RVA: 0x7FFACBA15F50
        public void GetHashCode(){} // RVA: 0x7FFACBA17180
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFACBA180E0
        public void ToString(){} // RVA: 0x7FFACBA19040
        public void MoveNext(){} // RVA: 0x7FFACBA19070
        // ── Unresolved (hash) ──
        public void m_639(){} // RVA: 0x7FFACBA19FD0
    }

    /// <summary>Originally: ÍÌÎÏÏÎÏÌÏÏÍÎÍÎÍÎÌÏÌÍÎÏÎ</summary>
    public class AsyncStateMachine_DC8D_DC8D : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ÌÍÍÎÎÎÍÎÏÏÏÍÏÎÎÍÏÍÌÎÏÏÌ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÎÍÍÌÎÎÎÌÏÏÎÎÎÍÌÎÍÎÍÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Runtime.CompilerServices.TaskAwaiter`1<System.ValueTuple`4<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>,NextResult<System.Collections.Generic.List`1<Mediapipe.NormalizedLandmarkList>>,NextResult<System.Collections.Generic.List`1<Mediapipe.NormalizedRect>>,NextResult<System.Collections.Generic.List`1<Mediapipe.NormalizedRect>>>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC44974A0
        public void InternalEquals(){} // RVA: 0x7FFAC4497FD0
        public void DefaultEquals(){} // RVA: 0x7FFAC4498040
        public void Equals(){} // RVA: 0x7FFAC44980B0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4498120
        public void SetStateMachine(){} // RVA: 0x7FFAC4498C50
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4498CC0
        public void GetHashCode(){} // RVA: 0x7FFAC4498D30
        public void ToString(){} // RVA: 0x7FFAC4498DA0
    }

    /// <summary>Originally: ÍÍÌÌÍÏÎÏÌÏÌÏÌÎÏÍÌÍÌÏÏÍÍ</summary>
    public class AsyncStateMachine_E0BC_E0BC : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<ÏÎÍÏÍÌÌÍÍÏÎÌÍÎÏÎÌÏÌÍÎÌÍ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiProp ÏÌÌÎÍÎÎÏÏÍÎÏÏÏÎÍÍÏÌÏÌÏÍ; // 0x30
        public ÌÏÎÌÍÎÌÍÌÏÏÎÎÎÏÎÏÍÏÍÎÍÎ ÌÌÍÏÌÍÌÌÍÏÍÌÍÍÍÍÌÍÎÌÎÌÎ; // 0x38
        public ÏÎÍÏÍÌÌÍÍÏÎÌÍÎÏÎÌÏÌÍÎÌÍ ÍÎÏÏÍÍÌÏÌÏÍÎÌÌÎÌÎÏÌÌÌÏÎ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3310340
        public void InternalEquals(){} // RVA: 0x7FFAC3310370
        public void DefaultEquals(){} // RVA: 0x7FFAC33106A0
        public void GetHashCode(){} // RVA: 0x7FFAC33109E0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3310D10
        public void MoveNext(){} // RVA: 0x7FFAC3310D40
        public void SetStateMachine(){} // RVA: 0x7FFAC3311070
        public void ToString(){} // RVA: 0x7FFAC33110A0
        public void MoveNext_73B8E0(){} // RVA: 0x7FFAC33110D0
    }

    /// <summary>Originally: ÍÎÏÍÍÎÌÍÏÎÍÏÏÍÍÍÏÎÌÏÍÎÎ</summary>
    public class AsyncStateMachine_E4AD_E4AD : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiAvatar ÏÏÍÏÏÍÏÎÏÎÌÎÍÌÍÏÌÌÏÌÎÍÍ; // 0x38
        public ÌÌÍÌÍÌÍÌÍÏÌÌÌÍÌÏÌÌÏÎÎÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ ÏÎÍÏÎÍÌÎÏÌÏÍÍÎÌÎÎÎÌÌÍÌÎ; // 0x48
        public Awaiter<ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x68

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC41BA150
        public void MoveNext(){} // RVA: 0x7FFAC41BA7C0
        public void SetStateMachine(){} // RVA: 0x7FFAC360C270
        public void GetHashCode(){} // RVA: 0x7FFAC360C270
        public void InternalGetHashCode(){} // RVA: 0x7FFAC360C270
        public void ToString(){} // RVA: 0x7FFAC360C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC41BAE70
    }

    /// <summary>Originally: ÍÌÏÍÌÍÌÌÎÌÌÍÎÌÌÎÎÏÍÏÌÎÌ</summary>
    public class AsyncStateMachine_E4E6_E4E6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÍÎÏÏÎÌÍÌÎÎÏÌÍÍÎÏÎÌÎÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFACB2F76A0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB2F7AB0
        public void InternalGetHashCode(){} // RVA: 0x7FFACB2F7ED0
        public void Equals(){} // RVA: 0x7FFACB2F82D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFACB2F86E0
        public void GetHashCode(){} // RVA: 0x7FFACB2F8AE0
        public void ToString(){} // RVA: 0x7FFACB2F8EE0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFACB2F92E0
    }

    /// <summary>Originally: ÍÌÎÍÏÌÌÎÌÎÍÍÌÍÏÍÏÌÏÎÌÌÌ</summary>
    public class AsyncStateMachine_E569_E569 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÌÏÎÏÍÌÍÏÌÌÍÎÏÎÏÌÌÏÏÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x28
        public System.Action ÏÍÌÎÌÍÌÏÏÎÏÍÎÌÌÎÎÏÎÌÎÏÍ; // 0x30
        public Awaiter<string> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter<ÎÌÍÍÏÏÏÎÏÎÌÏÎÎÌÍÏÎÍÏÌÍÌ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4943990
        public void MoveNext(){} // RVA: 0x7FFAC4944200
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4944AD0
    }

    /// <summary>Originally: ÍÎÍÏÎÏÌÎÎÌÌÌÎÌÏÌÌÎÎÏÌÎÏ</summary>
    public class AsyncStateMachine_E763_E763 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public float ÍÍÍÌÍÌÌÍÍÎÍÏÌÎÎÎÎÍÎÌÍÎÌ; // 0x30
        public Awaiter<System.ValueTuple`3<bool,bool,UnityEngine.GameObject>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x58

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC4101CF0
        public void InternalEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC41024F0
        public void GetHashCode(){} // RVA: 0x7FFAC4102D00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC4103510
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC4103D00
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÏÌÎÏÎÌÍÍÌÏÏÌÎÏÎÌÎÍÎÎÍ</summary>
    public class AsyncStateMachine_E866_E866 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<string> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public Transmtn.DTO.Notifications.Notification ÌÌÏÌÌÍÌÍÌÌÌÏÎÎÌÍÌÍÍÎÍÍÍ; // 0x30
        public System.Runtime.CompilerServices.TaskAwaiter`1<System.ValueTuple`2<VRC.Core.APIUser,VRC.Core.ApiContainer>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3E9FFD0
        public void MoveNext(){} // RVA: 0x7FFAC3EA0000
        public void DefaultEquals(){} // RVA: 0x7FFAC3EA0580
        public void GetHashCode(){} // RVA: 0x7FFAC3EA05B0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3EA0B30
        public void SetStateMachine(){} // RVA: 0x7FFAC3EA10C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3EA10F0
    }

    /// <summary>Originally: ÍÍÏÎÌÍÍÏÎÎÎÌÍÌÍÏÍÌÍÌÎÍÎ</summary>
    public class AsyncStateMachine_EB2E_EB2E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÎÏÍÍÌÎÍÍÎÍÎÎÌÍÎÍÎÏÍÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public Enumerator<0x6B24D498,System.Collections.Generic.List`1<ÌÍÌÌÏÍÌÎÌÏÏÍÌÍÎÌÍÏÍÍÏÍÌ>> ÍÍÎÏÎÍÍÌÌÍÍÌÍÎÎÍÌÎÌÏÎÌÏ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC4648F20
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC4649450
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4649980
        public void GetHashCode(){} // RVA: 0x7FFAC4649EB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÎÍÌÎÏÍÌÎÎÏÏÏÌÌÏÌÏÌÏÌÎ</summary>
    public class AsyncStateMachine_EB6F_EB6F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÎÌÎÍÌÍÏÎÏÌÌÌÎÎÍÎÌÍÍÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter<ÌÏÏÏÏÍÏÏÌÍÎÏÌÌÏÍÏÌÌÍÌÍÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC4252C30
        public void MoveNext(){} // RVA: 0x7FFAC4253460
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4253C90
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÏÌÎÎÏÏÌÌÏÍÏÎÎÏÌÌÏÍÎÏÎ</summary>
    public class AsyncStateMachine_F3E8_F3E8 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÎÏÍÎÏÏÌÏÍÏÏÎÎÌÍÌÏÏÎÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3C7C600
        public void InternalEquals(){} // RVA: 0x7FFAC3C7CC80
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3C7D300
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC3C7D980
        public void ValidateStructPointers(){} // RVA: 0x7FFAC3C7E010
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÌÎÍÎÏÎÌÌÍÎÍÍÍÍÌÏÍÌÌÎÎ</summary>
    public class AsyncStateMachine_F6E6_F6E6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÌÎÏÎÍÏÏÌÎÍÍÏÍÌÍÎÌÎÍÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter<ÎÏÌÏÏÎÍÏÍÌÏÏÍÌÏÌÍÎÍÌÌÏÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalEquals(){} // RVA: 0x7FFAC3800D50
        public void MoveNext(){} // RVA: 0x7FFAC3801140
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void SetConnectedBody(){} // RVA: 0x7FFAC2F21310
        public void MoveNext_58A42C(){} // RVA: 0x7FFAC3801530
        public void SetStateMachine_B13951(){} // RVA: 0x7FFAC3801920
    }

    /// <summary>Originally: ÍÍÌÎÎÌÍÎÏÏÌÏÌÏÍÎÍÍÍÍÏÎÎ</summary>
    public class AsyncStateMachine_F72A_F72A : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÎÍÍÎÌÌÍÎÌÌÏÌÍÌÍÎÍÎÍÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÎÏÎÎÍÍÎÍÍÍÏÌÎÏÎÎÍÌÏÌÏÎÍ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x34
        public VRC.Core.Pool.PooledObject`1<System.Collections.Generic.List`1<ÎÎÍÏÏÎÌÎÎÌÎÌÎÌÍÏÍÌÍÌÎÏÍ>> ÌÏÍÍÌÍÎÌÌÍÏÎÎÍÏÏÏÌÌÏÏÌÎ; // 0x38
        public Enumerator<ÎÎÍÏÏÎÌÎÎÌÎÌÎÌÍÏÍÌÍÌÎÏÍ> ÍÎÌÍÌÍÍÎÎÏÍÎÌÌÎÌÌÎÍÎÍÎÎ; // 0x48
        public ÎÎÍÏÏÎÌÎÎÌÎÌÎÌÍÏÍÌÍÌÎÏÍ ÏÎÎÌÌÏÌÎÌÎÌÍÍÏÍÏÌÌÏÍÍÏÌ; // 0x60
        public int ÎÎÏÍÌÍÏÎÏÌÌÍÎÏÏÍÍÌÌÌÍÏÍ; // 0x68
        public UnityEngine.Transform ÌÏÏÎÏÌÎÏÌÍÍÏÎÏÎÏÌÌÍÎÍÎÍ; // 0x70

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC3DF3F90
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC3DF5700
        public void Equals(){} // RVA: 0x7FFAC3DF6E70
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3DF8590
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3DF9CC0
    }

    /// <summary>Originally: ÍÌÎÎÎÎÏÎÎÏÏÏÎÏÎÏÌÌÏÍÏÌÌ</summary>
    public class AsyncStateMachine_F884_F884 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`2<bool,string>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÏÎÍÏÍÎÌÌÎÎÏÍÏÏÏÎÍÏÍÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public ÏÎÎÏÍÌÍÏÎÍÌÎÌÍÎÏÎÍÍÍÎÏÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC37D87D0
        public void InternalEquals(){} // RVA: 0x7FFAC37D9280
        public void DefaultEquals(){} // RVA: 0x7FFAC37D92B0
        public void MoveNext(){} // RVA: 0x7FFAC37D9D60
        public void SetStateMachine(){} // RVA: 0x7FFAC37DA840
        public void GetHashCode(){} // RVA: 0x7FFAC37DA870
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC37DB320
        public void ToString(){} // RVA: 0x7FFAC37DB350
    }

    /// <summary>Originally: ÍÌÏÏÎÏÍÎÏÍÏÎÏÍÌÏÌÌÎÍÍÍÌ</summary>
    public class AsyncStateMachine_F8D3_F8D3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÌÏÎÎÏÏÏÍÏÎÌÍÍÎÏÏÌÏÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB96DC00
        public void InternalEquals(){} // RVA: 0x7FFAC360C270
        public void SetStateMachine(){} // RVA: 0x7FFAC360C270
        public void GetHashCode(){} // RVA: 0x7FFAC360C270
        public void MoveNext(){} // RVA: 0x7FFACB96DFE0
        public void ToString(){} // RVA: 0x7FFAC360C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFACB96E3C0
        public void SetStateMachine_0AA19D537BD0(){} // RVA: 0x7FFAC360C270
        public void OnCollisionEnter(){} // RVA: 0x7FFACB96E7A0
        public void SetStateMachine_8126F535A019(){} // RVA: 0x7FFAC360C270
    }

    /// <summary>Originally: ÍÎÌÍÎÍÏÍÏÍÍÏÌÌÏÎÍÍÍÏÏÌÎ</summary>
    public class AsyncStateMachine_FA3E_FA3E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÌÎÎÍÍÎÍÏÎÍÍÎÌÍÏÍÌÏÌÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÍÎÎÏÎÎÍÍÎÏÎÏÌÌÏÌÎÏÌÍÏÌÎ; // 0x30
        public 0x6B234DC0 ÍÌÍÏÌÌÍÎÍÍÍÌÍÍÌÍÏÎÌÎÌÎÍ; // 0x34
        public System.Threading.CancellationTokenSource ÌÍÎÍÍÌÌÏÎÍÏÌÍÍÍÎÍÌÌÍÌÌÎ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACB60DF40
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFACB60E6C0
        public void InternalGetHashCode(){} // RVA: 0x7FFACB60EE70
        public void GetHashCode(){} // RVA: 0x7FFACB60F620
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÍÏÏÏÎÍÎÍÍÎÏÍÌÍÌÍÎÎÌÍÏÌ</summary>
    public class AsyncStateMachine_FCAB0_FCAB : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÏÏÏÎÏÍÏÏÍÌÌÍÏÍÍÎÎÌÌÎÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC43C5360
        public void InternalEquals(){} // RVA: 0x7FFAC43C5700
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC2F21310
        public void InternalGetHashCode(){} // RVA: 0x7FFAC43C5AB0
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC43C5E60
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
    }

    /// <summary>Originally: ÍÎÎÎÏÎÌÏÏÏÎÍÌÌÍÏÎÎÏÌÌÏÌ</summary>
    public class AsyncStateMachine_FFE1_FFE1 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC324FC80
        public void InternalEquals(){} // RVA: 0x7FFAC3250200
        public void DefaultEquals(){} // RVA: 0x7FFAC2F21310
        public void SetStateMachine(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3250780
        public void GetHashCode(){} // RVA: 0x7FFAC2F21310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F21310
    }

}