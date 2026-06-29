// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 86
// Methods: 608

public class WIN32_FIND_DATA : ValueType
{
    public object dwFileAttributes;
    public object ftCreationTime;
    public object ftLastAccessTime;
    public object ftLastWriteTime;
    public object nFileSizeHigh;
    public object nFileSizeLow;
    public object dwReserved0;
    public object dwReserved1;
    public object _cFileName;
    public object _cAlternateFileName;

    // ── Methods ──
    public void get_cFileName(){} // RVA: 0x8AAEB0
    public void SetFileName(){} // RVA: 0x8AAF10
}

public class WaitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x69AB300
    public void Invoke(){} // RVA: 0xCA8D60
}

public class WaitForAudioCaptureDeviceAuthorisation : CustomYieldInstruction
{
    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x6CF2380
    public void .ctor(){} // RVA: 0xB43310
}

public class WaitForAuthorisationToAccessPhotos : CustomYieldInstruction
{
    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x6CF23E0
    public void .ctor(){} // RVA: 0xB43310
}

public class WaitForCompletion : CustomYieldInstruction
{
    public object t;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x2713FF0
    public void .ctor(){} // RVA: 0xB44D60
}

public class WaitForElapsedLoops : CustomYieldInstruction
{
    public object t;
    public object elapsedLoops;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x27140C0
    public void .ctor(){} // RVA: 0x2615F10
}

public class WaitForKill : CustomYieldInstruction
{
    public object t;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x27140A0
    public void .ctor(){} // RVA: 0xB44D60
}

public class WaitForPosition : CustomYieldInstruction
{
    public object t;
    public object position;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x2714100
    public void .ctor(){} // RVA: 0x2714150
}

public class WaitForRewind : CustomYieldInstruction
{
    public object t;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x2714030
    public void .ctor(){} // RVA: 0xB44D60
}

public class WaitForStart : CustomYieldInstruction
{
    public object t;

    // ── Methods ──
    public void get_keepWaiting(){} // RVA: 0x27141B0
    public void .ctor(){} // RVA: 0xB44D60
}

public class Waypoint[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F0B0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AD50
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC49A0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E350A0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AD50
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Waypoint[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E395D0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class WeakKeyComparer : Object
{
    // ── Methods ──
    public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x770FF80
    public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0xE8FE30
    public void .ctor(){} // RVA: 0xB43310
}

public class WebFile : Object
{
    public object data;
    public object path;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class WebFile[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class WebSocketReceiveResultGetter : ValueType
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0x91BF30
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    public object IsWellKnownType;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x8942F0
}

public class WhenAllPromise`10 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object t10;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`11 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object t10;
    public object t11;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`12 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object t10;
    public object t11;
    public object t12;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`13 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object t10;
    public object t11;
    public object t12;
    public object t13;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT13(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`14 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object t10;
    public object t11;
    public object t12;
    public object t13;
    public object t14;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT13(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT14(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`15 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object t10;
    public object t11;
    public object t12;
    public object t13;
    public object t14;
    public object t15;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT13(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT14(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT15(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`3 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`4 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`5 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`6 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`7 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`8 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAllPromise`9 : Object
{
    public object t1;
    public object t2;
    public object t3;
    public object t4;
    public object t5;
    public object t6;
    public object t7;
    public object t8;
    public object t9;
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
    public void GetStatus(){} // RVA: 0x87D010
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void OnCompleted(){} // RVA: 0x89DD60
}

public class WhenAnyLRPromise`1 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryLeftInvokeContinuation(){} // RVA: 0x8945C0
    public void TryRightInvokeContinuation(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x77598E0
    public void TryInvokeContinuation(){} // RVA: 0x7759BA0
    public void GetResult(){} // RVA: 0x7759C90
    public void GetStatus(){} // RVA: 0x7759D10
    public void OnCompleted(){} // RVA: 0x7759D60
    public void UnsafeGetStatus(){} // RVA: 0x7759DE0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7759C90
}

public class WhenAnyPromise`1 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899290
    public void TryInvokeContinuation(){} // RVA: 0x89DC30
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`10 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`11 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`12 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`13 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT13(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`14 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT13(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT14(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`15 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT10(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT11(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT12(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT13(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT14(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT15(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`2 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`2 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5732360
    public void TryInvokeContinuationT1(){} // RVA: 0x57329E0
    public void TryInvokeContinuationT2(){} // RVA: 0x5732AE0
    public void GetResult(){} // RVA: 0x5732C00
    public void GetStatus(){} // RVA: 0x5732C90
    public void OnCompleted(){} // RVA: 0x5732CB0
    public void UnsafeGetStatus(){} // RVA: 0x5732CE0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x5732CF0
}

public class WhenAnyPromise`3 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`4 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`5 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`6 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`7 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`8 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhenAnyPromise`9 : Object
{
    public object completedCount;
    public object core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void TryInvokeContinuationT1(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT2(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT3(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT4(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT5(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT6(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT7(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT8(){} // RVA: 0x8945C0
    public void TryInvokeContinuationT9(){} // RVA: 0x8945C0
    public void GetResult(){} // RVA: 0xA94080
    public void GetStatus(){} // RVA: 0x87D010
    public void OnCompleted(){} // RVA: 0x89DD60
    public void UnsafeGetStatus(){} // RVA: 0x87C130
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x894470
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void MoveNext(){} // RVA: 0x575F440
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x575F4E0
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereArrayIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EB70
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void Dispose(){} // RVA: 0x5766360
    public void MoveNext(){} // RVA: 0x5766410
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57665C0
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void MoveNext(){} // RVA: 0x576A260
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x576A420
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
    public void Clone(){} // RVA: 0x575F070
    public void MoveNext(){} // RVA: 0x576A260
    public void Select(){} // RVA: 0x2D2CA40
    public void Where(){} // RVA: 0x576A420
}

public class WhereListIterator`1 : Iterator`1
{
    public object source;
    public object predicate;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x575EF90
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8954D0
    public void Clone(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x579B2F0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x576BAB0
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8954D0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void Dispose(){} // RVA: 0x5806C40
    public void MoveNext(){} // RVA: 0x5806CF0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x57A0960
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8954D0
    public void Clone(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585C190
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B400
    public void Clone(){} // RVA: 0x576B530
    public void MoveNext(){} // RVA: 0x585B070
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581AD00
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public object source;
    public object predicate;
    public object selector;
    public object enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x576B820
    public void Clone(){} // RVA: 0x576B950
    public void MoveNext(){} // RVA: 0x585F1A0
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x581B120
}

public class WithSyncContext : CancellationCallbackInfo
{
    public object TargetSyncContext;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x699FF00
}

public class WorkStealingQueue : Object
{
    public object _headIndex;
    public object _tailIndex;
    public object _array;
    public object _mask;
    public object _addTakeCount;
    public object _stealCount;
    public object _currentOp;
    public object _frozen;
    public object _nextQueue;
    public object _ownerThreadId;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void LocalPush(){} // RVA: 0xA94080
    public void TryLocalPop(){} // RVA: 0x87D350
    public void TrySteal(){} // RVA: 0x87F360
    public void DangerousCopyTo(){} // RVA: 0x885970
    public void get_DangerousCount(){} // RVA: 0x87C130
}

public class WrappedPropertyDescriptor : PropertyDescriptor
{
    public object target;
    public object property;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x77119F0
    public void get_Attributes(){} // RVA: 0x7711B10
    public void get_ComponentType(){} // RVA: 0x7711B40
    public void get_IsReadOnly(){} // RVA: 0x7711B70
    public void get_PropertyType(){} // RVA: 0x7711BA0
    public void CanResetValue(){} // RVA: 0x7711BD0
    public void GetValue(){} // RVA: 0x7711C10
    public void ResetValue(){} // RVA: 0x7711C50
    public void SetValue(){} // RVA: 0x7711C90
    public void ShouldSerializeValue(){} // RVA: 0x7711CD0
}

public class WriteCallbackInfo : Object
{
    public object Type;
    public object TypeName;
    public object TypeNs;
    public object Callback;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class WriteCallbackInfo : Object
{
    public object Type;
    public object TypeName;
    public object TypeNs;
    public object Callback;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class WriteDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68D8970
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x68D88A0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class WriteMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68D8970
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x68D88A0
    public void EndInvoke(){} // RVA: 0xB44BE0
}
