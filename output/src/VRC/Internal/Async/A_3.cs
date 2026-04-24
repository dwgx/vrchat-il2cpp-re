// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Internal.Async
// Classes: 100
// Methods: 874

namespace VRC.Internal.Async
{
    /// <summary>Originally: ÍÎÍÍÍÌÏÌÏÎÍÎÎÎÏÌÎÏÌÎÎÍÎ</summary>
    public class AsyncResult : Object
    {
        public byte[] _isCompleted; // 0x10
        public int _asyncState; // 0x18
        public int _completedSynchronously; // 0x1C
        public bool _asyncWaitHandle; // 0x20
        public object f_E2F; // 0x28
        public object ÏÎÍÌÏÎÌÌÏÌÎÌÏÎÎÌÎÏÎÌÌÌÌ; // 0x30
        public 0x6641E4D0 ÏÌÏÎÌÌÌÏÌÎÍÎÎÌÌÏÌÏÍÎÏÎÍ; // 0x38
        public object ÌÌÏÍÏÏÏÍÌÏÎÏÏÏÌÌÌÏÌÏÌÌÎ; // 0x40
        public bool ÌÎÎÌÌÌÍÍÎÏÍÏÍÎÎÌÌÏÍÌÏÎÏ; // 0x48
        public int ÏÍÌÍÎÎÍÏÏÌÏÍÍÍÎÏÏÎÌÏÏÏÍ; // 0x4C
        public int ÏÌÏÎÎÌÏÍÍÍÎÏÌÏÍÎÌÏÎÍÌÌÏ; // 0x50
        public object ÏÌÎÍÏÍÏÎÏÏÌÎÌÍÍÍÎÏÎÌÍÌÏ; // 0x58

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFD4F90CE20
        public void set_IsCompleted(){} // RVA: 0x7FFD4F90CE30
        public void set_AsyncWaitHandle_916C55B0D42C(){} // RVA: 0x7FFD4F90D170 | overloaded x2
        public void get_AsyncState(){} // RVA: 0x7FFD4E5F95E0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F90CE20
        public void get_hidden(){} // RVA: 0x7FFD4E3F8D30
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void set_CompletedSynchronously(){} // RVA: 0x7FFD4E3F8D30
        public void get_CompletedSynchronously(){} // RVA: 0x7FFD4E3F8D30
        public void .ctor(){} // RVA: 0x7FFD4F90CED0
        public void Initialize(){} // RVA: 0x7FFD4F90D070
        public void Instantiate(){} // RVA: 0x7FFD4F90D080
        public void GetHashCode_9F1376C665BE(){} // RVA: 0x7FFD4F90CEB0 | overloaded x2
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFD4F90D280
    }

    /// <summary>Originally: ÍÎÎÏÏÌÏÌÏÏÏÏÎÌÍÎÏÌÏÎÏÎÌ</summary>
    public class AsyncStateMachine_007A : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÎÍÌÌÍÎÌÍÍÏÏÎÌÍÎÏÍÌÍÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Action`1<ÍÏÏÌÌÏÌÏÌÍÏÏÎÏÎÌÍÏÌÌÍÏÏ> ÍÏÍÎÍÎÎÎÏÏÌÌÎÌÌÏÌÎÏÎÏÏÍ; // 0x28
        public System.Action`1<VRC.Core.ApiContainer> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ; // 0x30
        public ÌÌÍÎÌÏÌÌÎÎÏÌÎÍÌÌÌÌÏÌÌÎÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public Awaiter<UnityEngine.Texture2D> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E859E80
        public void InternalEquals(){} // RVA: 0x7FFD4E85A590
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4E85ACA0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E85B3B0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÏÍÏÌÌÏÍÍÍÏÍÌÏÍÏÎÍÌÍÎÍ</summary>
    public class AsyncStateMachine_0416 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public string ÎÏÏÌÏÌÏÏÎÍÍÍÌÎÎÍÍÎÎÎÏÍÏ; // 0x38
        public System.Threading.CancellationToken ÏÍÍÏÍÌÎÎÍÏÍÎÌÏÎÍÍÏÍÏÏÏÏ; // 0x40
        public ÌÏÍÏÍÏÎÏÍÎÍÎÌÎÌÌÎÏÏÎÎÎÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x48
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E663690
        public void InternalEquals(){} // RVA: 0x7FFD4E664460
        public void DefaultEquals(){} // RVA: 0x7FFD4E665220
        public void SetStateMachine(){} // RVA: 0x7FFD4E665FF0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E666020
        public void Equals(){} // RVA: 0x7FFD4E666DD0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E666E00
        public void GetHashCode(){} // RVA: 0x7FFD4E666E30
    }

    /// <summary>Originally: ÍÍÌÏÍÎÎÌÎÍÌÍÌÌÍÍÍÎÌÍÏÌÍ</summary>
    public class AsyncStateMachine_07CA : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎÌÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E630B80
        public void SetStateMachine(){} // RVA: 0x7FFD4E6316D0
        public void DefaultEquals(){} // RVA: 0x7FFD4E631730
        public void Equals(){} // RVA: 0x7FFD4E632280
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E632DD0
        public void GetHashCode(){} // RVA: 0x7FFD4E632E30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E633980
    }

    /// <summary>Originally: ÍÎÎÌÍÎÌÌÏÍÎÏÎÏÏÏÏÍÌÏÏÎÎ</summary>
    public class AsyncStateMachine_0AEA0 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`2<0x663620E0,ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public float ÍÍÍÌÍÌÌÍÍÎÍÏÌÎÎÎÎÍÎÌÍÎÌ; // 0x40
        public VRC.Core.ApiAvatar ÏÏÍÏÏÍÏÎÏÎÌÎÍÌÍÏÌÌÏÌÎÍÍ; // 0x48
        public 0x6640CE60 ÌÍÏÎÍÍÌÍÍÎÎÏÍÎÏÌÏÍÍÌÌÎÌ; // 0x50
        public bool ÌÌÏÎÌÌÌÎÌÌÏÎÎÌÏÌÌÍÍÎÏÏÎ; // 0x54
        public bool ÏÍÍÍÌÎÍÍÏÏÎÌÍÎÏÍÌÍÍÌÍÍÏ; // 0x55
        public 0x66362088 ÍÏÌÎÍÏÍÏÍÍÍÍÍÍÎÍÏÏÏÏÍÌÏ; // 0x58
        public VRC.Core.ApiAvatar ÍÌÎÌÌÍÎÍÌÏÏÍÌÏÌÏÌÍÎÏÍÏÍ; // 0x60
        public 0x6640CE60 ÏÏÏÎÎÌÎÏÌÌÎÍÎÍÌÍÍÏÏÌÍÍÌ; // 0x68
        public System.Threading.CancellationToken ÎÍÏÏÎÌÎÏÎÍÍÌÌÌÌÌÏÏÌÌÏÌÎ; // 0x70
        public ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ ÏÍÎÍÏÏÎÌÎÎÌÎÎÍÍÏÎÎÎÎÌÍÍ; // 0x78
        public Awaiter<ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x80
        public object ÏÎÍÍÎÌÍÌÏÍÌÏÏÏÏÏÍÏÌÌÍÍÌ; // 0x98
        public int ÏÎÍÏÏÍÏÎÌÎÏÍÏÎÎÏÍÎÎÏÍÍÌ; // 0xA0
        public System.ValueTuple`2<0x663620E0,ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ> ÎÏÍÍÏÎÍÎÎÌÌÍÌÍÌÏÌÎÎÌÏÍÍ; // 0xA8
        public UnityEngine.Transform ÏÎÎÌÍÍÏÌÌÎÏÍÍÍÌÍÌÎÌÍÏÌÌ; // 0xB8
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0xC0
        public System.Runtime.CompilerServices.ValueTaskAwaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0xD0

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F4E2280
        public void SetStateMachine(){} // RVA: 0x7FFD4F4E4130
        public void DefaultEquals(){} // RVA: 0x7FFD4F4E4160
        public void GetHashCode(){} // RVA: 0x7FFD4F4E4190
        public void MoveNext(){} // RVA: 0x7FFD4F4E6030
        public void ToString(){} // RVA: 0x7FFD4F4E7F00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F4E7F30
        public void HasValidInternalValue(){} // RVA: 0x7FFD4F4E9D60
    }

    /// <summary>Originally: ÍÎÍÌÎÍÏÎÏÍÌÍÌÎÌÏÏÏÍÏÎÎÎ</summary>
    public class AsyncStateMachine_0BB5 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÎÏÏÌÎÎÌÎÎÌÍÏÌÌÌÏÎÏÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public string ÌÏÌÎÎÎÎÏÍÍÌÏÏÍÎÏÎÏÍÎÏÎÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EC84DA0
        public void InternalEquals(){} // RVA: 0x7FFD4EC85080
        public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void MoveNext(){} // RVA: 0x7FFD4EC85360
        public void ToString(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EA2C270
        public void HasValidInternalValue(){} // RVA: 0x7FFD4EC85640
    }

    /// <summary>Originally: ÍÏÍÌÎÏÍÎÏÍÏÎÍÎÏÎÏÎÍÏÎÍÌ</summary>
    public class AsyncStateMachine_0BE6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÍÍÍÌÌÎÏÍÏÍÍÏÌÏÍÍÏÍÌÍÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EADAEF0
        public void InternalEquals(){} // RVA: 0x7FFD4EADB170
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EADB400
        public void MoveNext(){} // RVA: 0x7FFD4EADB690
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4EADB910
        public void ToString(){} // RVA: 0x7FFD4EADBB90
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4EADBE20
    }

    /// <summary>Originally: ÍÍÌÎÎÌÌÎÌÌÌÏÌÎÎÎÎÍÎÌÌÍÌ</summary>
    public class AsyncStateMachine_0D4A : ValueType
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
        public void Equals(){} // RVA: 0x7FFD4E666E60
        public void MoveNext(){} // RVA: 0x7FFD4E668920
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E66A390
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E66BE40
        public void ToString(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÍÌÏÏÍÍÏÌÌÍÌÌÎÍÏÏÏÍÏÍÏ</summary>
    public class AsyncStateMachine_10E7 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Economy.Internal.EconomyStoresManager ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E9F4F80
        public void MoveNext(){} // RVA: 0x7FFD4E9F54B0
        public void DefaultEquals(){} // RVA: 0x7FFD4E9F5A00
        public void GetHashCode(){} // RVA: 0x7FFD4E9F5F30
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E9F6460
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E9F6990
        public void AssignConnectedBody(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÌÎÎÌÍÎÎÌÍÏÏÍÌÎÌÌÍÌÎÏ</summary>
    public class AsyncStateMachine_11D5 : ValueType
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
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4F9FFAE0
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4FA00370
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FA00BF0
        public void GetHashCode(){} // RVA: 0x7FFD4FA01470
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4FA01D00
        public void ToString(){} // RVA: 0x7FFD4FA02580
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4FA02E10
        public void MoveNext(){} // RVA: 0x7FFD4FA036A0
    }

    /// <summary>Originally: ÍÍÌÍÏÍÌÌÌÍÏÍÌÍÍÌÌÏÌÌÏÍÍ</summary>
    public class AsyncStateMachine_15C1 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÌÏÍÎÍÌÍÍÎÌÌÌÎÎÎÌÍÏÌÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public bool ÌÏÎÎÍÌÎÍÏÍÎÍÌÎÍÌÍÍÌÎÌÏÍ; // 0x28
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4EB1F870
        public void Equals(){} // RVA: 0x7FFD4EB1FEA0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EB204D0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4EB20B10
        public void MoveNext(){} // RVA: 0x7FFD4EB21150
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4EB21780
    }

    /// <summary>Originally: ÍÎÌÏÌÏÌÏÌÌÌÎÏÏÍÌÎÌÏÍÎÏÎ</summary>
    public class AsyncStateMachine_1798 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÌÏÏÏÏÎÌÏÌÌÌÏÍÍÎÎÌÍÎÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4EADC0A0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EADCE20
        public void MoveNext(){} // RVA: 0x7FFD4EADDBB0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÏÌÌÍÍÍÎÌÍÍÎÍÎÍÍÍÎÌÍÌ</summary>
    public class AsyncStateMachine_1915 : ValueType
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
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4EF7C320
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4EF7C8E0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4EF7CE40
    }

    /// <summary>Originally: ÍÏÌÌÎÏÍÌÍÍÌÍÍÌÎÎÍÌÎÍÎÎÏ</summary>
    public class AsyncStateMachine_1997 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiAdminAssetBundle ÎÌÍÍÎÏÏÏÍÍÍÌÏÎÏÌÏÎÏÍÌÎÎ; // 0x28
        public System.Action`1<string> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ; // 0x30
        public ÌÌÍÍÏÏÌÎÍÍÏÏÍÌÌÏÎÎÎÎÌÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.Object>> ÏÏÏÌÍÍÌÍÌÏÍÎÏÏÍÍÎÏÏÏÌÎÏ; // 0x40
        public ÎÎÌÎÏÎÍÍÎÌÌÍÎÎÏÎÍÎÌÌÏÌÎ ÏÍÎÍÏÏÍÎÏÍÍÌÎÍÎÍÎÏÍÍÏÏÍ; // 0x48
        public object ÌÏÍÍÌÍÎÌÌÍÏÎÎÍÏÏÏÌÌÏÏÌÎ; // 0x50
        public int ÍÎÌÍÌÍÍÎÎÏÍÎÌÌÎÌÌÎÍÎÍÎÎ; // 0x58
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60
        public System.Runtime.CompilerServices.ValueTaskAwaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x70

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EE73F10
        public void InternalEquals(){} // RVA: 0x7FFD4EE74F10
        public void DefaultEquals(){} // RVA: 0x7FFD4EE75F10
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4EE76F10
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EE77F20
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void ValidateStructPointers(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÍÏÎÏÍÍÏÍÍÌÏÎÌÍÌÏÌÏÏÎÎ</summary>
    public class AsyncStateMachine_1C13 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÎÌÎÎÏÍÌÌÍÎÎÎÎÏÍÌÏÎÍÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Runtime.CompilerServices.TaskAwaiter`1<ÎÏÏÌÏÌÍÏÍÍÎÍÎÌÍÎÌÏÌÌÍÍÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F1BCAA0
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4F1BD5F0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F1BE150
        public void MoveNext(){} // RVA: 0x7FFD4F1BECB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F1BF7E0
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÍÎÌÍÏÏÏÌÏÏÎÏÏÏÏÍÏÍÎÍ</summary>
    public class AsyncStateMachine_1D93 : ValueType
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
        public void Equals(){} // RVA: 0x7FFD56BAB020
        public void InternalEquals(){} // RVA: 0x7FFD56BAB9F0
        public void SetStateMachine(){} // RVA: 0x7FFD56BABA20
        public void GetHashCode(){} // RVA: 0x7FFD56BABA50
        public void InternalGetHashCode(){} // RVA: 0x7FFD56BAC420
        public void ToString(){} // RVA: 0x7FFD56BACDF0
        public void MoveNext(){} // RVA: 0x7FFD56BAD7C0
        public void HasValidInternalValue(){} // RVA: 0x7FFD56BAE190
    }

    /// <summary>Originally: ÍÍÍÎÌÎÍÏÍÌÍÍÌÌÎÏÎÌÍÍÌÎÏ</summary>
    public class AsyncStateMachine_1ECF : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÌÌÌÌÍÍÌÌÌÌÏÌÏÏÏÏÏÏÏÌÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Runtime.CompilerServices.TaskAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD569BBC60
        public void MoveNext(){} // RVA: 0x7FFD569BBEA0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD569BC0E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD569BC320
    }

    /// <summary>Originally: ÍÎÏÏÍÎÏÍÍÎÎÎÍÏÌÏÎÏÎÏÎÌÎ</summary>
    public class AsyncStateMachine_2713 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎÌÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public System.Collections.Generic.Dictionary`2<byte,object> ÌÏÎÏÎÎÍÎÌÌÏÏÏÎÍÌÌÎÍÍÎÍÏ; // 0x28
        public int ÌÍÌÌÎÎÏÌÍÎÏÍÏÎÌÍÌÎÎÎÍÎÌ; // 0x30
        public int ÍÌÌÌÍÎÏÎÍÍÎÍÎÌÌÌÎÎÍÏÎÏÏ; // 0x34
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E63AFC0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E63BCE0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E63C9F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4E63D720
    }

    /// <summary>Originally: ÍÏÍÌÏÏÎÏÍÍÌÎÎÍÎÌÏÌÎÌÏÎÍ</summary>
    public class AsyncStateMachine_294A : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÎÌÏÍÌÎÌÎÌÎÎÏÏÍÌÌÎÎÌÏÌÎ ÌÏÌÍÌÌÎÏÏÌÎÌÍÏÍÏÍÍÎÎÌÍÍ; // 0x30
        public ÍÏÍÌÎÏÍÎÌÌÍÎÌÏÌÌÎÏÎÍÏÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public string ÎÍÏÌÏÏÎÌÏÏÍÍÍÌÌÌÌÎÎÍÌÏÎ; // 0x40
        public bool ÎÌÏÏÍÍÎÍÍÌÎÏÎÌÎÏÌÏÏÎÍÌÎ; // 0x48
        public bool ÎÏÎÍÏÎÌÌÌÎÎÌÎÎÏÍÌÎÎÍÎÎÎ; // 0x49
        public bool ÍÌÍÏÏÏÌÍÏÌÏÍÌÍÏÏÍÍÌÍÎÎÌ; // 0x4A
        public bool ÍÎÎÍÎÎÎÌÌÏÏÎÎÏÎÍÌÏÌÌÏÎÍ; // 0x4B
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD56C42BC0
        public void InternalEquals(){} // RVA: 0x7FFD56C43000
        public void MoveNext(){} // RVA: 0x7FFD56C43440
        public void SetStateMachine(){} // RVA: 0x7FFD56C43880
        public void InternalGetHashCode(){} // RVA: 0x7FFD56C438B0
        public void GetHashCode(){} // RVA: 0x7FFD56C438E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD56C43D20
        public void ToString(){} // RVA: 0x7FFD56C43D50
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD56C44190
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD56C441C0
    }

    /// <summary>Originally: ÍÍÏÏÍÍÌÎÎÌÌÌÌÍÌÏÍÎÏÎÌÏÍ</summary>
    public class AsyncStateMachine_298C : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÏÏÎÍÍÌÏÏÌÏÍÍÍÏÏÎÏÏÌÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EA27580
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4EA27A90
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4EA27FA0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void ValidateStructPointers(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÏÍÌÌÌÌÍÎÌÌÎÏÏÎÎÌÎÍÎÌÏ</summary>
    public class AsyncStateMachine_2C08 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÎÎÍÌÌÎÏÍÏÎÎÎÌÌÎÎÍÍÌÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EA2C270
        public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
        public void DefaultEquals(){} // RVA: 0x7FFD567F6FF0
        public void GetHashCode(){} // RVA: 0x7FFD567F7270
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void ToString(){} // RVA: 0x7FFD567F74F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD567F7770
        public void SetGameObjectActive(){} // RVA: 0x7FFD567F79F0
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4EA2C270
        public void MoveNext(){} // RVA: 0x7FFD567F7C70
    }

    /// <summary>Originally: ÍÍÌÏÎÎÏÍÍÌÎÏÌÎÍÍÎÎÎÌÎÎÎ</summary>
    public class AsyncStateMachine_2E60 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.GameObject> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÏÎÏÏÏÍÌÎÎÏÍÏÌÎÏÎÌÍÌÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter<UnityEngine.GameObject> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E8B5780
        public void SetStateMachine(){} // RVA: 0x7FFD4E8B5C60
        public void DefaultEquals(){} // RVA: 0x7FFD4E8B5C90
        public void GetHashCode(){} // RVA: 0x7FFD4E8B6170
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E8B61A0
        public void ToString(){} // RVA: 0x7FFD4E8B61D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E8B6200
        public void MoveNext(){} // RVA: 0x7FFD4E8B66E0
    }

    /// <summary>Originally: ÍÎÏÏÎÍÌÍÍÍÍÎÎÌÍÍÏÏÍÌÍÏÎ</summary>
    public class AsyncStateMachine_307D : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Action`1<VRC.Localization.LocalizableString> ÏÌÎÏÎÍÎÌÍÎÎÌÎÏÏÌÏÏÍÍÏÌÌ; // 0x20
        public VRC.Core.ApiWorldInstance ÎÎÌÏÎÎÌÌÏÎÍÍÌÏÌÏÌÌÌÍÌÎÏ; // 0x28
        public bool ÏÎÏÏÎÍÎÏÏÏÌÍÎÏÌÍÏÌÏÌÍÍÍ; // 0x30
        public UnityEngine.Vector3 ÏÎÍÏÌÌÍÏÍÎÍÌÎÌÏÌÌÍÌÌÍÎÌ; // 0x34
        public UnityEngine.Vector3 ÎÌÎÍÏÏÍÎÏÍÏÎÍÎÍÍÍÎÌÏÍÌÍ; // 0x40
        public ÌÏÌÌÌÍÌÏÍÏÍÌÎÌÏÍÌÍÎÎÏÏÎ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x50
        public Awaiter<System.ValueTuple`2<string,bool>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4F5A4E40
        public void MoveNext(){} // RVA: 0x7FFD4F5A5490
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4F5A5AD0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F5A6110
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÍÏÎÏÎÎÏÏÏÎÍÍÌÏÎÌÎÌÍÌÎ</summary>
    public class AsyncStateMachine_3269 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public bool ÍÍÌÌÎÌÍÎÎÎÎÌÏÏÍÎÌÎÍÏÎÌÌ; // 0x28
        public bool ÌÏÎÏÏÌÏÎÏÌÎÎÍÎÏÏÏÌÎÏÎÏÍ; // 0x29
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x38
        public bool ÍÎÌÍÍÍÍÌÍÎÏÍÏÌÎÏÏÏÏÌÌÏÏ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48
        public 0x665FC858 ÏÍÎÍÏÍÎÎÍÍÎÌÍÌÎÏÏÍÍÏÍÌÌ; // 0x58
        public float ÎÏÍÏÌÏÏÎÍÍÎÌÍÏÌÎÌÍÍÍÌÏÏ; // 0x5C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F4F3420
        public void InternalEquals(){} // RVA: 0x7FFD4F4F43E0
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4F4F5340
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F4F6270
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ValidateStructPointers(){} // RVA: 0x7FFD4F4F71F0
    }

    /// <summary>Originally: ÍÎÌÍÌÍÌÎÏÍÍÍÏÏÌÎÎÏÍÏÌÎÍ</summary>
    public class AsyncStateMachine_352F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÎÍÏÎÎÌÌÎÎÌÏÏÎÏÌÍÌÌÍÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÌÍÌÌÏÍÍÍÍÎÌÍÍÎÎÍÌÍÌÌÏÌÍ; // 0x30
        public 0x66594DC0 ÌÏÎÍÍÍÎÌÌÌÍÏÌÎÌÍÌÍÏÎÍÍÎ; // 0x34
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD56756BC0
        public void MoveNext(){} // RVA: 0x7FFD56757200
        public void InternalGetHashCode(){} // RVA: 0x7FFD56757840
        public void GetHashCode(){} // RVA: 0x7FFD56757E80
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÏÍÎÌÎÎÌÏÎÎÍÏÌÎÌÌÌÏÎÍÌ</summary>
    public class AsyncStateMachine_38BE : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public ÎÎÏÎÌÍÎÍÌÍÏÍÎÏÎÎÌÏÏÎÎÍÌ<U,V,U> ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ;
        public V ÏÍÏÌÏÍÏÍÎÏÎÍÍÎÍÎÍÌÎÏÍÏÌ;
        public int ÍÍÍÏÍÌÏÎÏÏÍÎÏÎÍÎÌÏÌÏÍÌÏ;
        public Awaiter<U> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E090980
        public void MoveNext(){} // RVA: 0x7FFD4E090980
        public void DefaultEquals(){} // RVA: 0x7FFD4E090A40
        public void GetHashCode(){} // RVA: 0x7FFD4E090980
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E090A40
        public void ToString(){} // RVA: 0x7FFD4E090A40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E090980
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4E090980
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÍÎÌÎÌÌÍÍÏÏÏÏÏÏÌÏÏÍÍÎÍÏÏ</summary>
    public class AsyncStateMachine_3A7B : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.GameObject> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÌÏÏÌÌÍÎÍÍÎÌÎÎÎÌÌÌÏÍÏÍ ÎÌÎÍÎÌÎÌÌÎÌÎÎÎÏÌÏÌÏÌÏÍÎ; // 0x30
        public ÍÍÏÎÍÍÎÏÎÏÌÍÌÏÏÌÏÎÌÏÌÍÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public UnityEngine.Vector3 ÏÎÏÎÌÏÎÏÎÌÌÌÎÌÍÍÏÏÏÏÏÌÌ; // 0x40
        public UnityEngine.Quaternion ÎÎÍÎÌÌÌÌÎÍÌÌÎÏÏÌÌÍÍÏÍÏÌ; // 0x4C
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4ED38C90
        public void InternalEquals(){} // RVA: 0x7FFD4ED38CC0
        public void MoveNext(){} // RVA: 0x7FFD4ED39730
        public void GetHashCode(){} // RVA: 0x7FFD4ED3A1A0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4ED3A1D0
        public void SetStateMachine(){} // RVA: 0x7FFD4ED3AC40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4ED3AC70
        public void ToString(){} // RVA: 0x7FFD4ED3ACA0
    }

    /// <summary>Originally: ÍÍÏÎÍÌÎÏÎÎÍÍÍÌÏÎÍÍÎÎÎÎÌ</summary>
    public class AsyncStateMachine_3E81 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiVRChatProductDetails>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Runtime.CompilerServices.TaskAwaiter`1<VRC.Core.ApiContainer> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4FBABB10
        public void InternalEquals(){} // RVA: 0x7FFD4FBABB80
        public void DefaultEquals(){} // RVA: 0x7FFD4FBABBF0
        public void Equals(){} // RVA: 0x7FFD4FBABC60
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FBAC500
        public void GetHashCode(){} // RVA: 0x7FFD4FBACDA0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4FBAD640
        public void ToString(){} // RVA: 0x7FFD4FBAD6B0
        public void MoveNext(){} // RVA: 0x7FFD4FBADF50
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4FBAE7D0
    }

    /// <summary>Originally: ÍÍÎÌÏÎÏÌÏÍÎÍÍÍÎÍÌÏÎÌÍÍÍ</summary>
    public class AsyncStateMachine_3F27 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Collections.Generic.List`1<Mediapipe.Detection>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÌÌÎÍÏÍÏÌÏÍÍÎÌÌÍÏÌÌÏÍÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Runtime.CompilerServices.TaskAwaiter`1<NextResult<System.Collections.Generic.List`1<Mediapipe.Detection>>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4F8BED00
        public void MoveNext(){} // RVA: 0x7FFD4F8BED70
        public void DefaultEquals(){} // RVA: 0x7FFD4F8BF290
        public void Equals(){} // RVA: 0x7FFD4F8BF300
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F8BF370
        public void GetHashCode(){} // RVA: 0x7FFD4F8BF890
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F8BF900
    }

    /// <summary>Originally: ÍÎÍÏÎÏÌÏÏÏÌÌÌÍÌÌÍÏÌÏÌÎÌ</summary>
    public class AsyncStateMachine_46DB : ValueType
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
        public void Equals(){} // RVA: 0x7FFD4F0B2830
        public void InternalEquals(){} // RVA: 0x7FFD4F0B48D0
        public void SetStateMachine(){} // RVA: 0x7FFD4F0B69E0
        public void GetHashCode(){} // RVA: 0x7FFD4F0B6A40
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F0B69E0
        public void ToString(){} // RVA: 0x7FFD4F0B8B00
        public void MoveNext(){} // RVA: 0x7FFD4F0BAB20
        public void HasValidInternalValue(){} // RVA: 0x7FFD4F0BCB80
    }

    /// <summary>Originally: ÍÍÌÎÎÌÏÌÎÍÌÌÎÌÌÍÌÎÎÌÏÌÍ</summary>
    public class AsyncStateMachine_4913 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.Object> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÍÎÏÎÍÏÍÍÏÍÌÌÌÌÎÎÍÎÍÌÌÎÎ; // 0x30
        public UnityEngine.ResourceRequest ÍÎÌÏÏÌÏÎÍÌÍÏÏÍÌÎÍÎÍÏÍÎÍ; // 0x38
        public ResourceRequestAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4EDB9B40
        public void InternalEquals(){} // RVA: 0x7FFD4EDBA010
        public void DefaultEquals(){} // RVA: 0x7FFD4EDBA4E0
        public void SetStateMachine(){} // RVA: 0x7FFD4EDBA510
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EDBA540
        public void Equals(){} // RVA: 0x7FFD4EDBAA10
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EDBAEE0
        public void GetHashCode(){} // RVA: 0x7FFD4EDBAF10
    }

    /// <summary>Originally: ÍÍÍÏÏÎÏÏÍÍÍÏÌÌÏÎÍÌÍÍÍÍÎ</summary>
    public class AsyncStateMachine_4B8F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiWorldInstance ÎÌÌÏÍÌÌÏÌÍÎÍÌÎÎÌÍÍÎÍÏÎÏ; // 0x28
        public ÍÌÎÍÌÍÎÎÎÏÍÍÌÌÏÍÌÍÌÍÎÍÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4E6B9140
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E6B9C80
        public void ToString(){} // RVA: 0x7FFD4E6BA8D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E6BB410
    }

    /// <summary>Originally: ÍÏÍÌÌÏÎÍÌÌÍÏÌÍÎÌÍÎÎÍÍÎÌ</summary>
    public class AsyncStateMachine_4DF0 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÍÏÏÏÏÌÍÍÏÌÍÌÌÎÌÌÎÌÌÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD56924760
        public void GetHashCode(){} // RVA: 0x7FFD56925530
        public void MoveNext(){} // RVA: 0x7FFD56926300
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÏÏÎÌÌÏÍÎÍÏÎÍÌÏÍÏÏÍÎÎÍ</summary>
    public class AsyncStateMachine_4E48 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Collections.Generic.List`1<ÌÍÌÌÏÍÌÎÌÏÏÍÌÍÎÌÍÏÍÍÏÍÌ> ÏÎÍÏÏÎÍÍÌÍÏÏÌÎÌÎÍÍÏÌÌÌÌ; // 0x28
        public ÎÎÎÏÍÍÌÎÍÍÎÍÎÎÌÍÎÍÎÏÍÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public ÌÍÌÌÏÍÌÎÌÏÏÍÌÍÎÌÍÏÍÍÏÍÌ ÎÍÏÌÏÏÎÎÏÍÌÍÎÍÍÍÎÍÎÎÏÏÎ; // 0x48
        public ÍÎÎÎÍÎÍÍÍÌÏÎÍÎÏÎÍÍÏÏÌÏÏ ÍÎÏÏÍÎÌÍÎÍÍÌÎÍÌÍÍÎÍÍÍÍÎ; // 0x50
        public Awaiter<ÍÎÎÎÍÎÍÍÍÌÏÎÍÎÏÎÍÍÏÏÌÏÏ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x60
        public Awaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0x80

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4FA6A3E0
        public void GetHashCode(){} // RVA: 0x7FFD4FA6B280
        public void MoveNext(){} // RVA: 0x7FFD4FA6C130
        public void ToString(){} // RVA: 0x7FFD4FA6CF90
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ValidateStructPointers(){} // RVA: 0x7FFD4FA6DE00
        public void Start(){} // RVA: 0x7FFD4FA6EC70
    }

    /// <summary>Originally: ÍÎÏÍÏÏÌÏÎÎÏÌÍÌÎÍÎÌÎÏÌÍÍ</summary>
    public class AsyncStateMachine_50D3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÍÎÏÏÏÌÍÎÏÍÌÏÌÍÍÏÎÍÎÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public string ÌÍÍÌÏÌÏÎÍÏÏÎÎÎÎÎÌÏÌÏÎÎÎ; // 0x28
        public string ÏÏÍÌÌÏÎÏÍÌÍÍÏÏÏÎÌÌÌÏÎÎÌ; // 0x30
        public bool ÍÍÍÏÎÏÍÎÌÏÍÌÌÏÍÌÌÏÏÌÏÌÎ; // 0x38
        public string ÌÎÌÎÍÍÍÍÏÎÎÍÏÍÎÎÍÍÏÍÍÎÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x58
        public Awaiter ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4F270F00
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F272050
        public void GetHashCode(){} // RVA: 0x7FFD4F273190
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4F274120
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4E341310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4F2750D0
    }

    /// <summary>Originally: ÍÏÌÌÍÍÌÏÌÍÍÏÌÎÍÍÏÍÏÎÎÍÍ</summary>
    public class AsyncStateMachine_50F3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÏÌÍÎÌÏÍÍÍÍÎÍÌÌÎÎÌÎÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Runtime.CompilerServices.ValueTaskAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F1909F0
        public void MoveNext(){} // RVA: 0x7FFD4F1911F0
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4F1919F0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F192200
        public void ToString(){} // RVA: 0x7FFD4F192A10
        public void InvokeRepeating(){} // RVA: 0x7FFD4F193220
    }

    /// <summary>Originally: ÍÍÌÎÏÍÏÌÌÌÍÌÌÏÏÍÍÍÍÎÏÍÏ</summary>
    public class AsyncStateMachine_523F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÍÏÍÏÌÌÎÏÍÌÌÍÍÌÎÌÏÍÌÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x30
        public bool ÍÏÎÏÏÏÌÏÏÌÏÎÏÏÎÌÎÏÌÎÏÏÍ; // 0x38
        public Awaiter<ÍÍÎÌÏÍÍÌÌÍÎÍÌÎÏÎÎÌÌÎÍÎÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter<ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x58

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD568A9490
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD568A9E30
        public void InternalGetHashCode(){} // RVA: 0x7FFD568AA7D0
        public void Equals(){} // RVA: 0x7FFD568AB170
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD568ABB10
    }

    /// <summary>Originally: ÍÏÌÏÌÌÎÌÌÍÌÏÎÏÌÍÎÏÍÎÍÌÌ</summary>
    public class AsyncStateMachine_5338 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`2<int,ÏÎÌÌÍÍÎÎÌÏÏÍÌÍÌÌÎÏÏÏÏÌÍ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÎÎÏÍÎÏÏÍÏÏÏÍÎÍÍÍÍÎÏÍÌÎÍ; // 0x38
        public int ÎÎÏÍÏÎÌÌÍÍÌÌÏÏÏÌÍÌÎÌÌÍÍ; // 0x40
        public string ÍÌÏÎÍÎÍÎÌÍÌÎÏÏÏÍÎÍÏÎÍÌÏ; // 0x48
        public bool ÌÌÏÎÍÎÏÏÌÎÎÏÌÎÌÍÎÎÌÏÎÌÌ; // 0x50
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x58
        public Awaiter<System.ValueTuple`2<int,ÏÎÌÌÍÍÎÎÌÏÏÍÌÍÌÌÎÏÏÏÏÌÍ>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F138DD0
        public void InternalEquals(){} // RVA: 0x7FFD4F138E00
        public void DefaultEquals(){} // RVA: 0x7FFD4F1391C0
        public void MoveNext(){} // RVA: 0x7FFD4F1391F0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F1395B0
        public void GetHashCode(){} // RVA: 0x7FFD4F139970
        public void SetStateMachine(){} // RVA: 0x7FFD4F139D30
    }

    /// <summary>Originally: ÍÍÏÌÍÍÎÏÏÎÎÎÌÍÍÌÍÎÏÏÌÏÌ</summary>
    public class AsyncStateMachine_5587 : ValueType
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
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
        public void InternalEquals(){} // RVA: 0x7FFD4E090980
        public void MoveNext(){} // RVA: 0x7FFD4E090980
        public void Equals(){} // RVA: 0x7FFD4E090980
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E090A40
        public void GetHashCode(){} // RVA: 0x7FFD4E090980
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E090A40
    }

    /// <summary>Originally: ÍÍÌÏÍÎÍÌÌÏÍÌÍÌÏÍÏÍÏÌÍÍÏ</summary>
    public class AsyncStateMachine_6089 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<UnityEngine.Texture2D> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌÎÍÌ ÎÎÎÎÎÍÍÎÍÌÎÌÍÌÌÌÎÍÎÏÌÏÎ; // 0x30
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x38
        public ÍÍÍÏÌÏÍÏÍÏÍÎÏÌÏÏÍÍÍÍÎÏÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4FB1D630
        public void InternalEquals(){} // RVA: 0x7FFD4FB1DE10
        public void DefaultEquals(){} // RVA: 0x7FFD4FB1E5C0
        public void Equals(){} // RVA: 0x7FFD4FB1EDA0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FB1EDD0
        public void GetHashCode(){} // RVA: 0x7FFD4FB1EE00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4FB1F5D0
        public void SetStateMachine(){} // RVA: 0x7FFD4FB1F600
    }

    /// <summary>Originally: ÍÍÎÎÍÎÍÎÌÍÌÍÏÏÍÏÎÎÏÌÏÏÏ</summary>
    public class AsyncStateMachine_6271 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÏÌÍÌÏÎÌÌÌÎÍÎÍÍÌÍÎÌÎÌÌÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public bool ÎÏÌÏÌÏÎÍÌÏÌÌÏÌÍÍÍÎÍÎÍÎÎ; // 0x28
        public bool ÎÎÍÎÎÌÎÎÎÌÌÏÎÎÎÌÍÏÏÏÌÎÎ; // 0x29
        public ÌÎÌÍÏÍÍÌÍÏÍÍÏÍÎÌÍÎÍÏÍÍÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4EDB7A50
        public void InternalEquals(){} // RVA: 0x7FFD4EDB80B0
        public void DefaultEquals(){} // RVA: 0x7FFD4EDB8700
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4EDB8D50
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EDB94E0
    }

    /// <summary>Originally: ÍÍÏÏÎÎÍÍÏÍÎÌÎÍÏÎÏÍÍÌÎÍÎ</summary>
    public class AsyncStateMachine_64BE : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÏÌÏÏÏÏÎÌÍÍÌÎÎÎÌÏÎÎÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD568A2650
        public void InternalEquals(){} // RVA: 0x7FFD568A2C00
        public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
        public void Equals(){} // RVA: 0x7FFD4EA2C270
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EA2C270
        public void ToString(){} // RVA: 0x7FFD4EA2C270
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4EA2C270
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD568A31B0
    }

    /// <summary>Originally: ÍÍÏÌÍÌÌÏÍÍÍÍÌÏÎÌÏÌÍÍÍÎÍ</summary>
    public class AsyncStateMachine_653E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ;
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<T> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ;
        public ÌÏÏÏÎÏÍÌÍÌÍÎÍÌÍÏÌÎÌÏÌÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ;
        public string ÍÌÎÌÏÌÌÌÏÍÎÍÎÍÎÎÍÏÎÏÏÍÍ;
        public Awaiter<object> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E090980
        public void InternalEquals(){} // RVA: 0x7FFD4E090980
        public void DefaultEquals(){} // RVA: 0x7FFD4E090A40
        public void GetHashCode(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
        public void ToString(){} // RVA: 0x7FFD4E090A40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E090A40
        public void MoveNext(){} // RVA: 0x7FFD4E090980
        public void ValidateStructPointers(){} // RVA: 0x7FFD4E090980
        public void StartCoroutine(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÍÎÏÍÍÌÎÎÍÌÌÎÍÎÌÏÎÍÌÌÏÎÌ</summary>
    public class AsyncStateMachine_66E4 : ValueType
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
        public void Equals(){} // RVA: 0x7FFD56BA3B30
        public void InternalEquals(){} // RVA: 0x7FFD56BA3B60
        public void MoveNext(){} // RVA: 0x7FFD56BA3B90
        public void SetStateMachine(){} // RVA: 0x7FFD56BA4C50
        public void InternalGetHashCode(){} // RVA: 0x7FFD56BA4C80
        public void GetHashCode(){} // RVA: 0x7FFD56BA4CB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD56BA4CE0
        public void ToString(){} // RVA: 0x7FFD56BA4D10
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD56BA5DD0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD56BA6EA0
    }

    /// <summary>Originally: ÍÍÏÏÍÌÌÍÏÍÍÏÎÎÏÎÎÎÎÏÎÎÍ</summary>
    public class AsyncStateMachine_69D3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÌÎÍÌÌÌÍÎÍÏÍÏÎÌÍÍÌÍÏÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD56B5D3A0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÏÏÍÎÎÏÍÌÏÍÌÎÍÍÎÌÏÏÍÎÍ</summary>
    public class AsyncStateMachine_6AE6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÎÍÍÎÌÌÍÎÌÌÏÌÍÌÍÎÍÎÍÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Cysharp.Threading.Tasks.UniTaskCompletionSource ÏÌÎÏÍÏÏÏÌÍÏÏÍÍÏÍÎÏÎÍÌÍÏ; // 0x28
        public int ÍÎÌÎÍÏÌÌÍÏÎÌÌÏÍÏÌÍÌÏÌÌÍ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x34
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4F21B3F0
        public void MoveNext(){} // RVA: 0x7FFD4F21BF10
        public void GetHashCode(){} // RVA: 0x7FFD4F21CA30
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F21D4E0
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÎÍÌÏÌÎÍÍÏÎÌÍÎÎÌÎÎÍÎÌ</summary>
    public class AsyncStateMachine_6BD4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÎÏÎÌÎÎÌÍÎÏÌÍÍÎÍÎÍÏÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public ÏÍÎÏÍÏÎÎÌÏÍÎÏÍÎÌÍÎÏÏÌÏÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public ÏÎÏÎÏÎÏÌÌÎÏÌÍÌÎÌÏÌÌÍÏÏÌ[] ÍÏÍÍÌÏÌÏÌÌÏÎÏÍÏÌÏÎÎÍÌÍÏ; // 0x38
        public System.Runtime.CompilerServices.TaskAwaiter`1<VRC.Economy.IProduct[]> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EA368B0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA376A0
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EA38490
        public void MoveNext(){} // RVA: 0x7FFD4EA39280
    }

    /// <summary>Originally: ÍÍÍÍÎÍÏÏÏÍÌÏÌÎÏÎÎÏÏÏÏÌÍ</summary>
    public class AsyncStateMachine_6C69 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4F197B80
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F198030
        public void ToString(){} // RVA: 0x7FFD4F1984D0
        public void MoveNext(){} // RVA: 0x7FFD4F198960
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÏÍÍÌÌÌÌÏÍÌÍÌÌÌÏÍÍÍÎÍÏÎ</summary>
    public class AsyncStateMachine_751D : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ ÎÌÍÌÌÎÎÏÎÍÎÍÎÍÏÎÍÌÏÌÌÍÏ; // 0x28
        public System.Collections.Generic.Dictionary`2<byte,object> ÍÍÍÍÎÏÎÎÏÌÎÎÍÍÏÍÎÏÍÌÏÏÍ; // 0x30
        public ÏÎÏÍÎÌÌÎÍÍÌÍÍÎÍÏÏÏÎÍÌÏÎ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public ÎÎÏÏÌÏÌÌÌÌÏÏÎÏÏÌÍÍÍÏÏÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public ÍÎÎÏÍÎÏÌÍÎÎÏÏÌÌÌÌÍÏÏÌÍÏ ÍÎÌÎÎÏÌÌÏÍÍÏÏÏÍÌÏÍÌÎÎÌÌ; // 0x48
        public bool ÍÏÎÍÍÌÌÌÍÍÌÌÎÎÏÎÎÌÍÎÌÍÏ; // 0x50
        public ÍÍÎÍÎÎÍÌÏÏÌÏÍÍÎÏÏÏÌÍÎÌÏ ÏÏÍÎÏÌÌÍÎÏÍÍÌÌÎÎÍÎÍÏÌÏÎ; // 0x58
        public ÍÎÎÏÍÎÏÌÍÎÎÏÏÌÌÌÌÍÏÏÌÍÏ ÏÌÏÍÏÎÏÍÎÍÍÍÏÎÎÌÌÏÎÏÌÌÍ; // 0x60
        public Awaiter<ÍÍÎÍÎÎÍÌÏÏÌÏÍÍÎÏÏÏÌÍÎÌÏ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x68
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x80
        public Awaiter<int> ÍÏÏÍÏÎÎÌÏÎÎÏÍÍÏÍÎÍÎÌÌÌÍ; // 0x90
        public Awaiter<bool> ÍÎÌÍÎÎÍÏÌÍÎÍÌÎÎÌÎÌÌÏÏÌÌ; // 0xA0

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E6EA3D0
        public void InternalEquals(){} // RVA: 0x7FFD4E6ECA20
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4E6EF040
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÎÌÌÌÌÍÎÍÌÏÍÎÏÍÎÏÌÏÍÏÎ</summary>
    public class AsyncStateMachine_7598 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÍÏÎÎÌÏÏÏÎÎÌÍÏÌÏÌÎÏÏÎÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4EB697F0
        public void DefaultEquals(){} // RVA: 0x7FFD4EB69B00
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4EB69E20
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EB6A140
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4EB6A460
        public void MoveNext(){} // RVA: 0x7FFD4EB6A770
    }

    /// <summary>Originally: ÍÍÌÏÍÌÏÏÍÍÏÌÍÍÏÌÌÌÏÍÌÌÎ</summary>
    public class AsyncStateMachine_7AE8 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.IReadOnlyList`1<ÍÍÎÍÌÌÏÏÏÎÏÏÍÌÎÍÍÌÌÎÏÎÏ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public bool ÌÌÏÌÏÌÏÍÌÏÎÍÎÏÍÎÌÍÎÌÎÎÍ; // 0x30
        public string ÏÍÍÏÌÏÌÏÏÌÌÎÌÎÏÌÏÍÏÎÎÍÎ; // 0x38
        public Awaiter<System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiStoreShelf>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E9F9C10
        public void InternalEquals(){} // RVA: 0x7FFD4E9FA140
        public void DefaultEquals(){} // RVA: 0x7FFD4E9FA170
        public void SetStateMachine(){} // RVA: 0x7FFD4E9FA6A0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E9FA6D0
        public void Equals(){} // RVA: 0x7FFD4E9FAC00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E9FB120
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB640
    }

    /// <summary>Originally: ÍÍÏÎÎÌÌÍÏÌÍÍÍÎÍÏÌÎÎÏÎÏÌ</summary>
    public class AsyncStateMachine_8012 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÍÏÎÌÍÏÌÏÍÏÎÌÎÍÎÍÍÏÎÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F5E8480
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4F5E8BE0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F5E9340
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F5E9A90
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4F5EA1E0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4F5EA930
    }

    /// <summary>Originally: ÍÍÎÌÌÌÌÎÍÍÍÍÌÌÍÎÏÏÏÍÌÌÏ</summary>
    public class AsyncStateMachine_86A6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÌÌÎÎÎÎÎÌÎÏÌÍÏÏÍÎÏÎÎÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public UnityEngine.GameObject ÏÎÎÌÏÌÍÏÍÌÍÏÎÎÎÎÎÍÌÏÌÌÎ; // 0x30
        public System.Action`1<UnityEngine.GameObject> ÏÏÏÎÎÎÏÏÌÏÏÏÎÌÌÎÍÏÎÍÏÏÍ; // 0x38
        public System.Action`1<string> ÌÌÍÏÍÍÏÌÌÏÎÌÎÌÍÌÏÏÌÍÎÎÍ; // 0x40
        public Awaiter<UnityEngine.GameObject> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4FB6ECB0
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4FB6F010
        public void MoveNext(){} // RVA: 0x7FFD4FB6F370
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4FB6F6D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4FB6FA30
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4FB6FD90
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÍÌÎÌÎÌÏÎÍÍÌÎÍÏÌÏÌÏÌÎÍ</summary>
    public class AsyncStateMachine_89C3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Threading.CancellationToken ÏÏÍÍÎÎÍÌÌÏÌÍÌÍÍÏÌÌÎÎÍÌÏ; // 0x28
        public ÍÌÎÌÏÍÌÎÍÏÏÌÍÎÌÏÌÍÍÌÌÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4F6B4BC0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F6B4F10
        public void MoveNext(){} // RVA: 0x7FFD4F6B5270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F6B55C0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÍÌÌÌÍÎÎÏÌÌÍÍÌÌÏÏÌÍÍÎÏ</summary>
    public class AsyncStateMachine_89E7 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÍÌÌÍÌÍÍÏÎÏÍÏÍÎÍÍÍÌÏÏÌÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÌÍÎÏÎÌÌÌÏÏÏÌÍÍÏÎÌÏÍÏÏÌÏ; // 0x30
        public int ÏÍÌÍÌÍÎÎÍÎÌÎÍÏÍÍÍÎÍÎÏÎÌ; // 0x34
        public System.Runtime.CompilerServices.TaskAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EB06F90
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4EB076E0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÎÍÏÌÏÎÏÎÎÎÏÌÏÍÌÎÌÌÌÎÏ</summary>
    public class AsyncStateMachine_8A12 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÌÍÍÌÏÍÏÍÏÌÎÍÏÍÎÏÏÍÍÏÍÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4E7E3B40
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E7E4740
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÌÎÍÏÎÍÍÏÍÍÍÌÎÍÏÎÎÏÍÍÍ</summary>
    public class AsyncStateMachine_9237 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÍÎÍÎÏÎÌÌÏÎÏÍÏÍÌÎÍÎÍÍÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x30
        public bool ÍÏÎÎÎÏÌÎÍÍÏÌÍÏÍÏÍÎÏÏÌÍÏ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD56DD6160
        public void DefaultEquals(){} // RVA: 0x7FFD56DD64A0
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD56DD67E0
        public void GetHashCode(){} // RVA: 0x7FFD56DD6B20
        public void MoveNext(){} // RVA: 0x7FFD56DD6E50
    }

    /// <summary>Originally: ÍÎÌÌÌÌÏÏÍÏÍÍÏÎÏÌÍÍÎÌÌÌÏ</summary>
    public class AsyncStateMachine_9C79 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public UnityEngine.RenderTexture ÎÌÎÏÌÍÏÎÎÏÍÌÎÏÍÏÌÎÎÏÎÌÏ; // 0x30
        public UnityEngine.Texture2D ÎÎÎÍÍÍÎÏÍÏÏÏÎÍÏÎÍÍÎÌÎÏÍ; // 0x38
        public ÏÎÍÌÎÏÍÏÍÏÏÏÎÏÎÏÏÏÎÎÌÎÍ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4FADA2A0
        public void InternalEquals(){} // RVA: 0x7FFD4FADAA00
        public void DefaultEquals(){} // RVA: 0x7FFD4FADB160
        public void GetHashCode(){} // RVA: 0x7FFD4FADB8C0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FADC010
        public void MoveNext(){} // RVA: 0x7FFD4FADC770
        public void SetStateMachine(){} // RVA: 0x7FFD4FADCEC0
        public void ToString(){} // RVA: 0x7FFD4FADCEF0
        public void Initialize(){} // RVA: 0x7FFD4FADD650
    }

    /// <summary>Originally: ÍÎÏÎÎÍÎÍÏÌÍÍÎÍÌÏÎÏÏÎÏÎÍ</summary>
    public class AsyncStateMachine_9F59 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Threading.CancellationToken ÏÍÍÏÍÌÎÎÍÏÍÎÌÏÎÍÍÏÍÏÏÏÏ; // 0x20
        public Cysharp.Threading.Tasks.UniTaskCompletionSource`1<string> ÏÍÏÌÎÏÍÎÎÎÌÏÍÌÌÌÏÏÎÌÍÏÌ; // 0x28
        public string ÌÌÏÍÌÌÌÌÌÏÎÌÎÌÍÌÏÎÎÌÏÏÎ; // 0x30
        public ÎÏÏÏÌÎÏÎÎÏÎÌÌÌÏÍÍÎÏÍÏÎÌ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x38
        public int ÍÏÎÌÏÌÍÏÎÌÎÏÍÎÎÏÏÍÏÏÍÌÌ; // 0x40
        public System.Collections.Generic.Dictionary`2<string,Token> ÎÎÍÏÎÍÌÏÏÏÏÏÌÍÍÎÏÌÏÎÎÍÍ; // 0x48
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E670D10
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E671620
        public void MoveNext(){} // RVA: 0x7FFD4E671F30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÎÍÍÍÏÍÎÏÌÌÏÌÌÍÎÍÎÎÏÏÎ</summary>
    public class AsyncStateMachine_A0DC : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public 0x664D49E0 ÎÍÏÏÏÏÎÍÎÎÏÎÍÍÎÏÌÌÍÍÍÌÍ; // 0x28
        public ÍÏÌÏÎÎÏÍÎÌÌÍÍÌÏÎÏÍÎÍÍÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public string ÏÏÎÎÏÍÌÎÍÎÍÏÌÍÍÏÍÌÌÌÍÏÏ; // 0x38
        public System.Runtime.CompilerServices.TaskAwaiter`1<VRC.Core.ApiContainer> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4FB9DC90
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FB9EA00
        public void MoveNext(){} // RVA: 0x7FFD4FB9F780
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4FBA04F0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4FBA1270
    }

    /// <summary>Originally: ÍÎÌÌÌÏÏÎÏÏÎÍÏÎÌÏÌÍÎÎÏÏÏ</summary>
    public class AsyncStateMachine_A486 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÏÏÌÏÌÌÌÌÏÏÎÏÏÌÍÍÍÏÏÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public ÍÍÌÎÌÏÎÏÍÏÍÏÎÍÌÏÌÏÎÎÍÌÏ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter<int> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E6F4680
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4E6F4EE0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E6F5730
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E6F5F90
    }

    /// <summary>Originally: ÍÏÍÍÌÏÍÍÍÌÍÏÎÌÌÎÎÌÍÌÏÍÎ</summary>
    public class AsyncStateMachine_A6AD : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÍÌÎÌÏÍÌÍÎÎÌÍÎÏÎÍÏÌÏÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public UnityEngine.GameObject ÎÏÎÎÎÎÎÎÍÎÎÍÏÌÏÍÍÍÎÏÍÎÏ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E6ACE00
        public void InternalEquals(){} // RVA: 0x7FFD4E6AD860
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E6AE2B0
        public void ToString(){} // RVA: 0x7FFD4E6AED10
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4E6AF740
        public void MoveNext(){} // RVA: 0x7FFD4E6B0170
    }

    /// <summary>Originally: ÍÍÏÎÏÎÏÏÏÎÌÌÎÎÎÌÎÌÌÏÍÎÎ</summary>
    public class AsyncStateMachine_ABB4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÍÎÌÎÎÎÎÍÌÎÏÌÏÍÎÏÌÏÏÏÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD56C0F720
        public void InternalEquals(){} // RVA: 0x7FFD56C0FC20
        public void DefaultEquals(){} // RVA: 0x7FFD56C10110
        public void GetHashCode(){} // RVA: 0x7FFD56C105F0
        public void MoveNext(){} // RVA: 0x7FFD56C10AE0
        public void ToString(){} // RVA: 0x7FFD56C10FE0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ValidateStructPointers(){} // RVA: 0x7FFD56C114E0
        public void Initialize(){} // RVA: 0x7FFD56C119C0
    }

    /// <summary>Originally: ÍÎÎÎÏÏÎÎÍÎÏÏÍÍÏÌÎÍÌÏÏÎÍ</summary>
    public class AsyncStateMachine_AD91 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎÏÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public 0x66357978 ÎÌÏÍÍÌÌÎÍÍÍÏÏÍÌÎÍÎÎÍÌÍÍ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter<VRC.Core.ApiWorldInstance> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4F16C9A0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void AssignConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÌÌÏÍÍÍÍÎÌÌÏÌÍÏÏÍÍÍÏÏ</summary>
    public class AsyncStateMachine_ADC3 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E090A40
        public void MoveNext(){} // RVA: 0x7FFD4E090980
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
        public void GetHashCode(){} // RVA: 0x7FFD4E090980
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E090A40
        public void ToString(){} // RVA: 0x7FFD4E090980
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E090980
        public void MoveNext_6392243295A0(){} // RVA: 0x7FFD4E090980
        public void StartCoroutine(){} // RVA: 0x7FFD4E090980
        public void MoveNext_D3EA4DFC56AD(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÍÌÏÏÍÏÍÌÍÍÏÌÏÌÌÍÏÍÍÍÌÏÌ</summary>
    public class AsyncStateMachine_AFE4 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÍÌÍÏÎÌÌÌÏÏÍÏÍÍÏÍÌÎÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public ÍÍÏÌÎÎÍÎÍÎÎÍÏÍÎÌÏÌÌÎÏÍÎ ÌÌÎÌÎÎÍÌÎÎÍÌÍÏÌÍÏÌÌÎÏÌÌ; // 0x38
        public 0x665AD498 ÏÎÏÏÍÍÌÌÎÌÎÏÎÎÍÏÌÎÌÍÌÏÎ; // 0x50
        public UnityEngine.Networking.UnityWebRequest ÌÌÏÌÌÏÎÌÏÍÌÎÎÏÌÍÍÌÏÍÌÍÌ; // 0x58
        public Awaiter<ÏÍÍÍÎÏÍÏÎÏÏÌÍÍÏÍÏÏÏÏÏÏÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F0ED4D0
        public void MoveNext(){} // RVA: 0x7FFD4F0EDB70
        public void DefaultEquals(){} // RVA: 0x7FFD4F0EE210
        public void GetHashCode(){} // RVA: 0x7FFD4F0EE240
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F0EE8E0
        public void ToString(){} // RVA: 0x7FFD4F0EEF80
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F0EEFB0
        public void SetStateMachine(){} // RVA: 0x7FFD4F0EF650
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4F0EF680
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4F0EF6B0
    }

    /// <summary>Originally: ÍÍÎÌÌÌÌÏÎÏÏÍÌÏÍÍÍÍÏÎÎÎÎ</summary>
    public class AsyncStateMachine_B028 : ValueType
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
        public void Equals(){} // RVA: 0x7FFD4F816920
        public void InternalEquals(){} // RVA: 0x7FFD4F818370
        public void DefaultEquals(){} // RVA: 0x7FFD4F81A1B0
        public void GetHashCode(){} // RVA: 0x7FFD4F81A1E0
        public void MoveNext(){} // RVA: 0x7FFD4F81C020
        public void SetStateMachine(){} // RVA: 0x7FFD4F81DED0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F81DF00
        public void ToString(){} // RVA: 0x7FFD4F81FD30
        public void ValidateStructPointers(){} // RVA: 0x7FFD4F8219E0
    }

    /// <summary>Originally: ÍÍÌÎÏÎÎÌÍÏÏÏÏÍÏÍÎÍÌÏÌÏÌ</summary>
    public class AsyncStateMachine_B1F1 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public string ÍÏÏÌÌÎÎÍÏÌÍÌÏÎÏÍÍÍÍÍÌÍÍ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4FB373E0
        public void InternalEquals(){} // RVA: 0x7FFD4FB37960
        public void DefaultEquals(){} // RVA: 0x7FFD4FB37FB0
        public void MoveNext(){} // RVA: 0x7FFD4FB385F0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FB38C30
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÌÏÌÎÎÌÌÍÌÌÌÍÎÎÌÏÎÎÎÌÎÏ</summary>
    public class AsyncStateMachine_B3D6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.ValueTuple`4<int,string,int,bool>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÍÍÍÌÌÌÍÏÍÏÏÎÌÌÏÌÍÏÍÎÌÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public Awaiter<System.ValueTuple`4<int,string,int,bool>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E6B0BC0
        public void InternalEquals(){} // RVA: 0x7FFD4E6B14D0
        public void DefaultEquals(){} // RVA: 0x7FFD4E6B1500
        public void GetHashCode(){} // RVA: 0x7FFD4E6B1E20
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E6B2740
        public void ToString(){} // RVA: 0x7FFD4E6B3050
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E6B3080
        public void SetStateMachine(){} // RVA: 0x7FFD4E6B3990
        public void MoveNext(){} // RVA: 0x7FFD4E6B39C0
    }

    /// <summary>Originally: ÍÍÎÍÌÌÌÍÌÏÏÏÏÎÍÌÎÌÎÎÎÌÎ</summary>
    public class AsyncStateMachine_B520 : ValueType
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
        public void Equals(){} // RVA: 0x7FFD4E75BE50
        public void MoveNext(){} // RVA: 0x7FFD4E75BE80
        public void DefaultEquals(){} // RVA: 0x7FFD4E75E190
        public void GetHashCode(){} // RVA: 0x7FFD4E7604B0
        public void SetStateMachine(){} // RVA: 0x7FFD4E762790
        public void ToString(){} // RVA: 0x7FFD4E7627C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E764A80
        public void Initialize(){} // RVA: 0x7FFD4E766D50
        public void InitializeInternal(){} // RVA: 0x7FFD4E768FE0
        public void SetAnimatedTextureInternalData(){} // RVA: 0x7FFD4E769010
    }

    /// <summary>Originally: ÍÍÎÍÎÎÎÏÏÍÍÍÎÍÏÏÌÍÍÏÍÌÌ</summary>
    public class AsyncStateMachine_B561 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public int ÌÌÎÍÎÍÏÍÎÍÍÏÏÎÍÏÎÎÍÏÏÏÏ; // 0x20
        public System.Threading.CancellationToken ÎÌÏÏÎÌÌÎÍÍÏÏÍÌÏÌÍÏÌÏÍÌÍ; // 0x28
        public ÌÎÏÍÍÏÎÎÌÎÏÌÌÎÏÍÎÌÎÏÍÌÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD56B68FA0
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD56B692C0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD56B695E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD56B698F0
        public void ValidateStructPointers(){} // RVA: 0x7FFD56B69C00
    }

    /// <summary>Originally: ÍÍÍÎÌÌÍÎÌÍÍÏÏÌÌÏÍÌÍÎÎÍÎ</summary>
    public class AsyncStateMachine_B68C : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E090A40
        public void MoveNext(){} // RVA: 0x7FFD4E090980
        public void DefaultEquals(){} // RVA: 0x7FFD4E090A40
        public void GetHashCode(){} // RVA: 0x7FFD4E090980
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E090A40
        public void ToString(){} // RVA: 0x7FFD4E090A40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E090980
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void SetStateMachine(){} // RVA: 0x7FFD4E090A40
    }

    /// <summary>Originally: ÍÎÏÌÍÏÏÏÏÍÎÎÎÌÏÍÎÏÏÏÌÍÏ</summary>
    public class AsyncStateMachine_B811 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x20

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD56914B80
        public void Equals(){} // RVA: 0x7FFD56914FE0
        public void InternalGetHashCode(){} // RVA: 0x7FFD56915450
        public void GetHashCode(){} // RVA: 0x7FFD569158D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD56915D50
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÏÌÌÎÏÎÌÎÌÏÎÌÎÎÌÏÌÌÏÍÌÏ</summary>
    public class AsyncStateMachine_BB25 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÎÌÌÌÍÎÌÌÎÏÏÌÍÎÎÌÏÌÎÎÌÏ ÎÍÏÌÏÏÎÌÏÏÍÍÍÌÌÌÌÎÎÍÌÏÎ; // 0x38
        public ÎÏÏÌÌÌÌÏÏÏÏÍÌÏÍÌÏÏÌÎÍÎÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public 0x664D25C8 ÌÎÏÏÌÍÏÍÌÎÌÏÏÏÍÎÏÌÍÍÍÏÌ; // 0x48
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD56C84620
        public void MoveNext(){} // RVA: 0x7FFD56C84CB0
        public void DefaultEquals(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void InternalGetHashCode(){} // RVA: 0x7FFD56C85340
        public void ToString(){} // RVA: 0x7FFD56C859D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EA2C270
        public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
        public void set_localPosition(){} // RVA: 0x7FFD56C86070
    }

    /// <summary>Originally: ÍÍÌÎÍÍÍÎÏÎÌÍÎÌÏÌÍÎÍÍÌÏÍ</summary>
    public class AsyncStateMachine_BB6E : ValueType
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
        public void MoveNext(){} // RVA: 0x7FFD4E9398D0
        public void InternalEquals(){} // RVA: 0x7FFD4E93A540
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E93B1C0
        public void Equals(){} // RVA: 0x7FFD4E93BE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E93CAB0
    }

    /// <summary>Originally: ÍÏÍÍÎÌÎÎÍÎÍÎÏÍÍÍÌÏÏÌÍÎÎ</summary>
    public class AsyncStateMachine_BFA3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.List`1<ÌÏÌÏÏÏÏÍÍÏÏÍÎÍÎÍÎÎÏÎÌÌÍ>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÏÎÍÏÍÎÌÌÎÎÏÍÏÏÏÎÍÏÍÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public string[] ÏÏÍÎÎÌÍÍÎÎÎÎÌÏÌÎÍÎÎÌÎÌÍ; // 0x38
        public string[] ÍÎÍÏÍÌÎÌÏÌÍÌÍÌÍÏÎÎÏÏÌÌÎ; // 0x40
        public ÎÌÍÏÌÌÌÎÍÏÏÌÌÍÍÏÏÎÎÎÍÏÏ ÎÏÌÍÍÍÌÌÍÏÏÏÍÍÏÌÌÏÍÏÎÌÌ; // 0x48
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EBFCE90
        public void InternalEquals(){} // RVA: 0x7FFD4EBFCEC0
        public void DefaultEquals(){} // RVA: 0x7FFD4EBFD4B0
        public void GetHashCode(){} // RVA: 0x7FFD4EBFD4E0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EBFD510
        public void MoveNext(){} // RVA: 0x7FFD4EBFD540
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EBFDB30
        public void SetStateMachine(){} // RVA: 0x7FFD4EBFDB60
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
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4EA7B1E0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÏÌÌÎÌÍÍÌÏÏÎÍÏÎÏÍÍÌÍÎÏÌ</summary>
    public class AsyncStateMachine_C175 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÎÎÍÌÌÎÏÍÏÎÎÎÌÌÎÎÍÍÌÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD567F7EF0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD567F82D0
        public void GetHashCode(){} // RVA: 0x7FFD567F8650
        public void ToString(){} // RVA: 0x7FFD567F89E0
    }

    /// <summary>Originally: ÍÏÌÏÏÌÏÌÏÎÎÌÎÍÌÍÎÎÍÌÏÏÌ</summary>
    public class AsyncStateMachine_C21C : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<System.Collections.Generic.Dictionary`2<string,string>> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÍÎÍÌÌÌÎÏÎÌÌÏÌÍÎÌÌÌÌÌÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Collections.Generic.Dictionary`2<string,string> ÎÎÌÍÏÌÍÌÏÌÍÍÏÌÍÎÍÏÌÍÌÍÌ; // 0x38
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F0DB270
        public void InternalEquals(){} // RVA: 0x7FFD4F0DB2A0
        public void DefaultEquals(){} // RVA: 0x7FFD4F0DB8F0
        public void GetHashCode(){} // RVA: 0x7FFD4F0DB920
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F0DBF70
        public void MoveNext(){} // RVA: 0x7FFD4F0DBFA0
        public void SetStateMachine(){} // RVA: 0x7FFD4F0DC5F0
        public void ToString(){} // RVA: 0x7FFD4F0DC620
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4F0DCC70
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4F0DCCA0
    }

    /// <summary>Originally: ÍÎÍÎÎÍÏÍÏÍÎÍÌÎÏÎÌÍÎÏÌÌÌ</summary>
    public class AsyncStateMachine_C613 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Action`1<string> ÏÏÌÎÌÏÎÏÏÏÌÎÌÍÏÍÍÏÍÏÎÎÍ; // 0x28
        public ÍÎÎÏÍÎÎÏÌÎÌÍÎÏÌÌÏÎÌÌÏÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public System.Action`1<System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ>> ÍÏÍÎÍÎÎÎÏÏÌÌÎÌÌÏÌÎÏÎÏÏÍ; // 0x38
        public System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ> ÎÌÍÏÎÌÎÌÍÏÎÍÍÏÏÌÎÏÎÎÌÏÏ; // 0x40
        public Awaiter<System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E7169B0
        public void InternalEquals(){} // RVA: 0x7FFD4E717600
        public void DefaultEquals(){} // RVA: 0x7FFD4E718200
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E718E60
        public void ValidateStructPointers(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÎÎÍÏÏÍÎÍÎÌÌÎÏÏÌÎÌÎÏÏÏ</summary>
    public class AsyncStateMachine_C700 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<bool> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÏÍÌÍÏÎÌÌÌÏÏÍÏÍÍÏÍÌÎÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public ÍÍÏÌÎÎÍÎÍÎÎÍÏÍÎÌÏÌÌÎÏÍÎ ÌÌÎÌÎÎÍÌÎÎÍÌÍÏÌÍÏÌÌÎÏÌÌ; // 0x38
        public 0x665AD498 ÏÎÏÏÍÍÌÌÎÌÎÏÎÎÍÏÌÎÌÍÌÏÎ; // 0x50
        public System.Collections.Generic.Dictionary`2<string,string> ÍÎÍÎÏÍÎÌÏÍÌÎÌÌÍÏÍÎÏÎÍÏÍ; // 0x58
        public Awaiter<ÏÍÍÍÎÏÍÏÎÏÏÌÍÍÏÍÏÏÏÏÏÏÍ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F0EF6E0
        public void SetStateMachine(){} // RVA: 0x7FFD4F0EFDB0
        public void MoveNext(){} // RVA: 0x7FFD4F0EFDE0
        public void GetHashCode(){} // RVA: 0x7FFD4F0F04B0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F0F04E0
        public void ToString(){} // RVA: 0x7FFD4F0F0510
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F0F0540
        public void AwaitUnsafeOnCompleted(){} // RVA: 0x7FFD4F0F0C10
        public void Start(){} // RVA: 0x7FFD4F0F12E0
        public void Create(){} // RVA: 0x7FFD4F0F19B0
    }

    /// <summary>Originally: ÍÌÏÏÎÍÌÍÍÏÎÌÏÏÎÌÍÌÎÎÏÎÌ</summary>
    public class AsyncStateMachine_C980 : ValueType
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
        public void Equals(){} // RVA: 0x7FFD4EA3A0E0
        public void InternalEquals(){} // RVA: 0x7FFD4EA3C1D0
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4EA3E2D0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA40360
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4EA42440
        public void ToString(){} // RVA: 0x7FFD4EA44550
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4EA46630
    }

    /// <summary>Originally: ÍÌÏÎÏÍÎÎÌÌÎÏÎÌÌÎÍÏÍÌÍÎÍ</summary>
    public class AsyncStateMachine_D060 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÍÎÏÌÎÌÍÏÎÏÌÏÌÌÎÎÌÏÏÏÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4E916240
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void HasValidInternalValue(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÍÎÎÎÍÎÍÌÎÌÎÏÏÍÌÏÎÏÎÍÍ</summary>
    public class AsyncStateMachine_D594 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public System.Collections.IList ÍÌÍÌÏÍÍÌÎÎÎÏÎÏÍÎÎÌÌÌÍÌÏ; // 0x20
        public ÌÍÌÏÎÏÎÎÍÎÎÎÌÌÌÏÏÍÏÍÏÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public System.Collections.Generic.List`1<ÎÎÏÌÍÌÌÍÍÌÏÎÍÍÏÍÌÎÌÍÎÍÏ> ÏÎÌÎÏÌÌÌÎÎÎÎÍÌÏÏÎÌÌÎÌÎÌ; // 0x30
        public Awaiter<ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ[]> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD569323A0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD56932EA0
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void ValidateStructPointers(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÍÌÌÍÎÎÎÍÏÍÌÍÌÍÏÍÏÍÍÌ</summary>
    public class AsyncStateMachine_D924 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÌÍÌÎÍÌÎÏÎÏÎÏÏÍÎÏÎÌÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public long ÍÎÌÎÌÌÎÎÍÎÌÏÎÍÎÏÍÏÎÌÏÎÍ; // 0x28
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4F7DE070
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4F7DE460
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F7DE840
        public void MoveNext_6C0187(){} // RVA: 0x7FFD4F7DEC30
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÌÍÏÎÏÌÏÌÏÌÎÏÍÌÍÌÏÏÍÍ</summary>
    public class AsyncStateMachine_E0BC : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<ÏÎÍÏÍÌÌÍÍÏÎÌÍÎÏÎÌÏÌÍÎÌÍ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiProp ÏÌÌÎÍÎÎÏÏÍÎÏÏÏÎÍÍÏÌÏÌÏÍ; // 0x30
        public ÌÏÎÌÍÎÌÍÌÏÏÎÎÎÏÎÏÍÏÍÎÍÎ ÌÌÍÏÌÍÌÌÍÏÍÌÍÍÍÍÌÍÎÌÎÌÎ; // 0x38
        public ÏÎÍÏÍÌÌÍÍÏÎÌÍÎÏÎÌÏÌÍÎÌÍ ÍÎÏÏÍÍÌÏÌÏÍÎÌÌÎÌÎÏÌÌÌÏÎ; // 0x40
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x48

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E730340
        public void InternalEquals(){} // RVA: 0x7FFD4E730370
        public void DefaultEquals(){} // RVA: 0x7FFD4E7306A0
        public void GetHashCode(){} // RVA: 0x7FFD4E7309E0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E730D10
        public void MoveNext(){} // RVA: 0x7FFD4E730D40
        public void SetStateMachine(){} // RVA: 0x7FFD4E731070
        public void ToString(){} // RVA: 0x7FFD4E7310A0
        public void MoveNext_73B8E0(){} // RVA: 0x7FFD4E7310D0
    }

    /// <summary>Originally: ÍÏÍÌÎÎÍÏÏÏÏÎÌÏÏÎÌÎÍÍÌÍÍ</summary>
    public class AsyncStateMachine_E46D : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<ÏÏÌÎÍÎÏÌÎÍÌÌÎÌÏÍÏÏÍÎÏÎÌ> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÌÌÏÏÎÌÏÏÏÌÌÏÏÎÍÎÎÍÎÎÍÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x30
        public UnityEngine.Vector3 ÏÎÍÏÌÌÍÏÍÎÍÌÎÌÏÌÌÍÌÌÍÎÌ; // 0x38
        public UnityEngine.Vector3 ÌÎÎÏÍÍÏÎÎÌÎÌÌÎÎÎÍÎÍÏÏÏÍ; // 0x44
        public int ÏÌÌÏÍÏÌÌÎÏÏÌÌÎÌÍÎÏÍÏÌÌÌ; // 0x50
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ ÎÍÎÏÏÌÎÎÏÍÍÎÌÌÍÏÎÍÍÎÍÎÌ; // 0x58
        public ÍÏÏÌÌÏÌÏÌÍÏÏÎÏÎÌÍÏÌÌÍÏÏ ÍÍÎÎÏÎÎÏÍÎÎÍÏÎÎÍÌÌÌÌÎÍÍ; // 0x60
        public string ÏÍÎÏÍÌÌÌÍÎÏÌÎÎÎÏÌÎÎÎÎÌÏ; // 0x68
        public UnityEngine.ResourceRequest ÍÌÍÍÏÎÏÍÍÎÍÌÌÎÎÎÍÌÎÎÎÏÏ; // 0x70
        public ResourceRequestAwaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x78

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E836D40
        public void InternalEquals(){} // RVA: 0x7FFD4E8377F0
        public void DefaultEquals(){} // RVA: 0x7FFD4E837820
        public void GetHashCode(){} // RVA: 0x7FFD4E837850
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E837880
        public void SetStateMachine(){} // RVA: 0x7FFD4E8378B0
        public void MoveNext(){} // RVA: 0x7FFD4E8378E0
        public void ToString(){} // RVA: 0x7FFD4E838390
    }

    /// <summary>Originally: ÍÎÏÍÍÎÌÍÏÎÍÏÏÍÍÍÏÎÌÏÍÎÎ</summary>
    public class AsyncStateMachine_E4AD : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public VRC.Core.ApiAvatar ÏÏÍÏÏÍÏÎÏÎÌÎÍÌÍÏÌÌÏÌÎÍÍ; // 0x38
        public ÌÌÍÌÍÌÍÌÍÏÌÌÌÍÌÏÌÌÏÎÎÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x40
        public ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ ÏÎÍÏÎÍÌÎÏÌÏÍÍÎÌÎÎÎÌÌÍÌÎ; // 0x48
        public Awaiter<ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x50
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x68

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F5DA150
        public void MoveNext(){} // RVA: 0x7FFD4F5DA7C0
        public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void ToString(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F5DAE70
    }

    /// <summary>Originally: ÍÌÏÍÌÍÌÌÎÌÌÍÎÌÌÎÎÏÍÏÌÎÌ</summary>
    public class AsyncStateMachine_E4E6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÍÎÏÏÎÌÍÌÎÎÏÌÍÍÎÏÎÌÎÍÏÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD567176A0
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD56717AB0
        public void InternalGetHashCode(){} // RVA: 0x7FFD56717ED0
        public void Equals(){} // RVA: 0x7FFD567182D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD567186E0
        public void GetHashCode(){} // RVA: 0x7FFD56718AE0
        public void ToString(){} // RVA: 0x7FFD56718EE0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD567192E0
    }

    /// <summary>Originally: ÍÎÍÏÎÏÌÎÎÌÌÌÎÌÏÌÌÎÎÏÌÎÏ</summary>
    public class AsyncStateMachine_E763 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public float ÍÍÍÌÍÌÌÍÍÎÍÏÌÎÎÎÎÍÎÌÍÎÌ; // 0x30
        public Awaiter<System.ValueTuple`3<bool,bool,UnityEngine.GameObject>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x58

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4F521CF0
        public void InternalEquals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F5224F0
        public void GetHashCode(){} // RVA: 0x7FFD4F522D00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4F523510
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4F523D00
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÏÌÎÏÎÌÍÍÌÏÏÌÎÏÎÌÎÍÎÎÍ</summary>
    public class AsyncStateMachine_E866 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`1<string> ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public Transmtn.DTO.Notifications.Notification ÌÌÏÌÌÍÌÍÌÌÌÏÎÎÌÍÌÍÍÎÍÍÍ; // 0x30
        public System.Runtime.CompilerServices.TaskAwaiter`1<System.ValueTuple`2<VRC.Core.APIUser,VRC.Core.ApiContainer>> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F2BFFD0
        public void MoveNext(){} // RVA: 0x7FFD4F2C0000
        public void DefaultEquals(){} // RVA: 0x7FFD4F2C0580
        public void GetHashCode(){} // RVA: 0x7FFD4F2C05B0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F2C0B30
        public void SetStateMachine(){} // RVA: 0x7FFD4F2C10C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F2C10F0
    }

    /// <summary>Originally: ÍÍÏÎÌÍÍÏÎÎÎÌÍÌÍÏÍÌÍÌÎÍÎ</summary>
    public class AsyncStateMachine_EB2E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÎÏÍÍÌÎÍÍÎÍÎÎÌÍÎÍÎÏÍÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public Enumerator<0x665AD498,System.Collections.Generic.List`1<ÌÍÌÌÏÍÌÎÌÏÏÍÌÍÎÌÍÏÍÍÏÍÌ>> ÍÍÎÏÎÍÍÌÌÍÍÌÍÎÎÍÌÎÌÏÎÌÏ; // 0x30
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x58

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4FA68F20
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4FA69450
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FA69980
        public void GetHashCode(){} // RVA: 0x7FFD4FA69EB0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÎÍÌÎÏÍÌÎÎÏÏÏÌÌÏÌÏÌÏÌÎ</summary>
    public class AsyncStateMachine_EB6F : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÎÎÌÎÍÌÍÏÎÏÌÌÌÎÎÍÎÌÍÍÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter<ÌÏÏÏÏÍÏÏÌÍÎÏÌÌÏÍÏÌÌÍÌÍÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28
        public Awaiter ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4F672C30
        public void MoveNext(){} // RVA: 0x7FFD4F673460
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F673C90
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÏÌÎÎÏÏÌÌÏÍÏÎÎÏÌÌÏÍÎÏÎ</summary>
    public class AsyncStateMachine_F3E8 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÎÏÍÎÏÏÌÏÍÏÏÎÎÌÍÌÏÏÎÍÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F09C600
        public void InternalEquals(){} // RVA: 0x7FFD4F09CC80
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4F09D300
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4F09D980
        public void ValidateStructPointers(){} // RVA: 0x7FFD4F09E010
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÌÎÍÎÏÎÌÌÍÎÍÍÍÍÌÏÍÌÌÎÎ</summary>
    public class AsyncStateMachine_F6E6 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÏÌÌÎÏÎÍÏÏÌÎÍÍÏÍÌÍÎÌÎÍÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter<ÎÏÌÏÏÎÍÏÍÌÏÏÍÌÏÌÍÎÍÌÌÏÌ> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalEquals(){} // RVA: 0x7FFD4EC20D50
        public void MoveNext(){} // RVA: 0x7FFD4EC21140
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
        public void MoveNext_58A42C(){} // RVA: 0x7FFD4EC21530
        public void SetStateMachine_B13951(){} // RVA: 0x7FFD4EC21920
    }

    /// <summary>Originally: ÍÍÌÎÎÌÍÎÏÏÌÏÌÏÍÎÍÍÍÍÏÎÎ</summary>
    public class AsyncStateMachine_F72A : ValueType
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
        public void MoveNext(){} // RVA: 0x7FFD4F213F90
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4F215700
        public void Equals(){} // RVA: 0x7FFD4F216E70
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F218590
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F219CC0
    }

    /// <summary>Originally: ÍÌÏÏÎÏÍÎÏÍÏÎÏÍÌÏÌÌÎÍÍÍÌ</summary>
    public class AsyncStateMachine_F8D3 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public System.Runtime.CompilerServices.AsyncVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÌÏÎÎÏÏÏÍÏÎÌÍÍÎÏÏÌÏÌÏÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x38
        public Awaiter<bool> ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD56D8DC00
        public void InternalEquals(){} // RVA: 0x7FFD4EA2C270
        public void SetStateMachine(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCode(){} // RVA: 0x7FFD4EA2C270
        public void MoveNext(){} // RVA: 0x7FFD56D8DFE0
        public void ToString(){} // RVA: 0x7FFD4EA2C270
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD56D8E3C0
        public void SetStateMachine_0AA19D537BD0(){} // RVA: 0x7FFD4EA2C270
        public void OnCollisionEnter(){} // RVA: 0x7FFD56D8E7A0
        public void SetStateMachine_8126F535A019(){} // RVA: 0x7FFD4EA2C270
    }

    /// <summary>Originally: ÍÎÌÍÎÍÏÍÏÍÍÏÌÌÏÎÍÍÍÏÏÌÎ</summary>
    public class AsyncStateMachine_FA3E : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÎÌÎÎÍÍÎÍÏÎÍÍÎÌÍÏÍÌÏÌÎÌ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public bool ÍÎÎÏÎÎÍÍÎÏÎÏÌÌÏÌÎÏÌÍÏÌÎ; // 0x30
        public 0x66594DC0 ÍÌÍÏÌÌÍÎÍÍÍÌÍÍÌÍÏÎÌÎÌÎÍ; // 0x34
        public System.Threading.CancellationTokenSource ÌÍÎÍÍÌÌÏÎÍÏÌÍÍÍÎÍÌÌÍÌÌÎ; // 0x38
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x40
        public Awaiter<ÎÎÏÎÍÎÎÌÍÏÍÍÍÍÏÎÎÌÍÎÏÏÏ> ÏÍÏÎÎÍÎÌÌÎÏÏÌÌÍÏÌÏÍÍÎÌÌ; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD56A2DF40
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD56A2E6C0
        public void InternalGetHashCode(){} // RVA: 0x7FFD56A2EE70
        public void GetHashCode(){} // RVA: 0x7FFD56A2F620
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÏÏÏÎÍÎÍÍÎÏÍÌÍÌÍÎÎÌÍÏÌ</summary>
    public class AsyncStateMachine_FCAB0 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÍÌÏÏÏÎÏÍÏÏÍÌÌÍÏÍÍÎÎÌÌÎÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4F7E5360
        public void InternalEquals(){} // RVA: 0x7FFD4F7E5700
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F7E5AB0
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F7E5E60
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÎÎÎÏÎÌÏÏÏÎÍÌÌÍÏÎÎÏÌÌÏÌ</summary>
    public class AsyncStateMachine_FFE1 : ValueType
    {
        public int ÍÏÍÎÌÎÏÏÏÍÍÌÎÌÌÎÌÌÌÏÎÍÍ; // 0x10
        public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder ÎÏÏÏÏÍÏÎÎÌÍÌÎÍÏÌÍÎÍÏÏÍÏ; // 0x18
        public ÎÏÍÎÏÎÏÌÏÏÌÎÍÌÎÏÏÌÍÌÎÎÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x20
        public Awaiter ÌÍÌÍÏÏÎÍÍÎÍÌÌÌÏÎÏÌÌÎÎÌÌ; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E66FC80
        public void InternalEquals(){} // RVA: 0x7FFD4E670200
        public void DefaultEquals(){} // RVA: 0x7FFD4E341310
        public void SetStateMachine(){} // RVA: 0x7FFD4E341310
        public void MoveNext(){} // RVA: 0x7FFD4E670780
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E341310
    }

}