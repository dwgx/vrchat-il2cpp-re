// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 87
// Methods: 1538

namespace ThirdParty.Unity.UnityEngine
{
    public class AddComponentMenu : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
    }

    public class AnchoredJoint2D : Joint2D
    {
        // ── Methods ──
        public void get_anchor(){} // RVA: 0x7AEFCAF90
        public void set_anchor(){} // RVA: 0x7AEFCAFF0
        public void get_connectedAnchor(){} // RVA: 0x7AEFCB050
        public void set_connectedAnchor(){} // RVA: 0x7AEFCB0B0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7AEFCB110
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7AEFCB160
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_anchor_Injected(){} // RVA: 0x7AEFCB1C0
        public void set_anchor_Injected(){} // RVA: 0x7AEFCB220
        public void get_connectedAnchor_Injected(){} // RVA: 0x7AEFCB280
        public void set_connectedAnchor_Injected(){} // RVA: 0x7AEFCB2E0
    }

    public class AndroidJNI : Object
    {
        // ── Methods ──
        public void FindClass(){} // RVA: 0x7AEE65300
        public void FromReflectedMethod(){} // RVA: 0x7AEE65350
        public void ExceptionOccurred(){} // RVA: 0x7AEE653A0
        public void ExceptionClear(){} // RVA: 0x7AEE653F0
        public void PushLocalFrame(){} // RVA: 0x7AEE65440
        public void PopLocalFrame(){} // RVA: 0x7AEE65490
        public void NewGlobalRef(){} // RVA: 0x7AEE654E0
        public void QueueDeleteGlobalRef(){} // RVA: 0x7AEE65530
        public void NewWeakGlobalRef(){} // RVA: 0x7AEE65580
        public void DeleteWeakGlobalRef(){} // RVA: 0x7AEE655D0
        public void NewLocalRef(){} // RVA: 0x7AEE65620
        public void DeleteLocalRef(){} // RVA: 0x7AEE65670
        public void IsSameObject(){} // RVA: 0x7AEE656C0
        public void NewObject(){} // RVA: 0x7AEE65720
        public void NewObjectA(){} // RVA: 0x7AEE657C0
        public void GetObjectClass(){} // RVA: 0x7AEE65830
        public void GetMethodID(){} // RVA: 0x7AEE65880
        public void GetFieldID(){} // RVA: 0x7AEE658F0
        public void GetStaticMethodID(){} // RVA: 0x7AEE65960
        public void GetStaticFieldID(){} // RVA: 0x7AEE659D0
        public void NewString(){} // RVA: 0x7AEE65A40
        public void NewStringFromStr(){} // RVA: 0x7AEE65A40
        public void GetStringChars(){} // RVA: 0x7AEE65A90
        public void CallStringMethod(){} // RVA: 0x7AEE65BE0
        public void CallStringMethodUnsafe(){} // RVA: 0x7AEE65C80
        public void CallObjectMethod(){} // RVA: 0x7AEE65CF0
        public void CallObjectMethodUnsafe(){} // RVA: 0x7AEE65D90
        public void CallIntMethod(){} // RVA: 0x7AEE65F00
        public void CallIntMethodUnsafe(){} // RVA: 0x7AEE65FA0
        public void CallBooleanMethod(){} // RVA: 0x7AEE66010
        public void CallBooleanMethodUnsafe(){} // RVA: 0x7AEE660B0
        public void CallShortMethod(){} // RVA: 0x7AEE66120
        public void CallShortMethodUnsafe(){} // RVA: 0x7AEE661C0
        public void CallSByteMethod(){} // RVA: 0x7AEE66230
        public void CallSByteMethodUnsafe(){} // RVA: 0x7AEE662D0
        public void CallCharMethod(){} // RVA: 0x7AEE66340
        public void CallCharMethodUnsafe(){} // RVA: 0x7AEE663E0
        public void CallFloatMethod(){} // RVA: 0x7AEE66450
        public void CallFloatMethodUnsafe(){} // RVA: 0x7AEE664F0
        public void CallDoubleMethod(){} // RVA: 0x7AEE66560
        public void CallDoubleMethodUnsafe(){} // RVA: 0x7AEE66600
        public void CallLongMethod(){} // RVA: 0x7AEE66670
        public void CallLongMethodUnsafe(){} // RVA: 0x7AEE66710
        public void CallVoidMethod(){} // RVA: 0x7AEE66780
        public void CallVoidMethodUnsafe(){} // RVA: 0x7AEE66820
        public void GetStringField(){} // RVA: 0x7AEE66890
        public void GetObjectField(){} // RVA: 0x7AEE668F0
        public void GetBooleanField(){} // RVA: 0x7AEE66950
        public void GetSByteField(){} // RVA: 0x7AEE669B0
        public void GetCharField(){} // RVA: 0x7AEE66A10
        public void GetShortField(){} // RVA: 0x7AEE66A70
        public void GetIntField(){} // RVA: 0x7AEE66AD0
        public void GetLongField(){} // RVA: 0x7AEE66B30
        public void GetFloatField(){} // RVA: 0x7AEE66B90
        public void GetDoubleField(){} // RVA: 0x7AEE66BF0
        public void CallStaticStringMethod(){} // RVA: 0x7AEE66D50
        public void CallStaticStringMethodUnsafe(){} // RVA: 0x7AEE66DF0
        public void CallStaticObjectMethod(){} // RVA: 0x7AEE66E60
        public void CallStaticObjectMethodUnsafe(){} // RVA: 0x7AEE66F00
        public void CallStaticIntMethod(){} // RVA: 0x7AEE66F70
        public void CallStaticIntMethodUnsafe(){} // RVA: 0x7AEE67010
        public void CallStaticBooleanMethod(){} // RVA: 0x7AEE67080
        public void CallStaticBooleanMethodUnsafe(){} // RVA: 0x7AEE67120
        public void CallStaticShortMethod(){} // RVA: 0x7AEE67190
        public void CallStaticShortMethodUnsafe(){} // RVA: 0x7AEE67230
        public void CallStaticSByteMethod(){} // RVA: 0x7AEE672A0
        public void CallStaticSByteMethodUnsafe(){} // RVA: 0x7AEE67340
        public void CallStaticCharMethod(){} // RVA: 0x7AEE673B0
        public void CallStaticCharMethodUnsafe(){} // RVA: 0x7AEE67450
        public void CallStaticFloatMethod(){} // RVA: 0x7AEE674C0
        public void CallStaticFloatMethodUnsafe(){} // RVA: 0x7AEE67560
        public void CallStaticDoubleMethod(){} // RVA: 0x7AEE675D0
        public void CallStaticDoubleMethodUnsafe(){} // RVA: 0x7AEE67670
        public void CallStaticLongMethod(){} // RVA: 0x7AEE676E0
        public void CallStaticLongMethodUnsafe(){} // RVA: 0x7AEE67780
        public void CallStaticVoidMethod(){} // RVA: 0x7AEE677F0
        public void CallStaticVoidMethodUnsafe(){} // RVA: 0x7AEE67890
        public void GetStaticStringField(){} // RVA: 0x7AEE67900
        public void GetStaticObjectField(){} // RVA: 0x7AEE67960
        public void GetStaticBooleanField(){} // RVA: 0x7AEE679C0
        public void GetStaticSByteField(){} // RVA: 0x7AEE67A20
        public void GetStaticCharField(){} // RVA: 0x7AEE67A80
        public void GetStaticShortField(){} // RVA: 0x7AEE67AE0
        public void GetStaticIntField(){} // RVA: 0x7AEE67B40
        public void GetStaticLongField(){} // RVA: 0x7AEE67BA0
        public void GetStaticFloatField(){} // RVA: 0x7AEE67C00
        public void GetStaticDoubleField(){} // RVA: 0x7AEE67C60
        public void ToBooleanArray(){} // RVA: 0x7AEE67CC0
        public void ToByteArray(){} // RVA: 0x7AEE67D10
        public void ToSByteArray(){} // RVA: 0x7AEE67DF0
        public void ToCharArray(){} // RVA: 0x7AEE67EE0
        public void ToShortArray(){} // RVA: 0x7AEE67FD0
        public void ToIntArray(){} // RVA: 0x7AEE680C0
        public void ToLongArray(){} // RVA: 0x7AEE681B0
        public void ToFloatArray(){} // RVA: 0x7AEE682A0
        public void ToDoubleArray(){} // RVA: 0x7AEE68390
        public void ToObjectArray(){} // RVA: 0x7AEE68460
        public void FromBooleanArray(){} // RVA: 0x7AEE68500
        public void FromByteArray(){} // RVA: 0x7AEE68550
        public void FromSByteArray(){} // RVA: 0x7AEE685A0
        public void FromCharArray(){} // RVA: 0x7AEE685F0
        public void FromShortArray(){} // RVA: 0x7AEE68640
        public void FromIntArray(){} // RVA: 0x7AEE68690
        public void FromLongArray(){} // RVA: 0x7AEE686E0
        public void FromFloatArray(){} // RVA: 0x7AEE68730
        public void FromDoubleArray(){} // RVA: 0x7AEE68780
        public void GetArrayLength(){} // RVA: 0x7AEE687D0
        public void NewFloatArray(){} // RVA: 0x7AEE68820
        public void NewObjectArray(){} // RVA: 0x7AEE68870
        public void GetObjectArrayElement(){} // RVA: 0x7AEE688E0
        public void SetObjectArrayElement(){} // RVA: 0x7AEE68940
    }

    public class AndroidJNIHelper : Object
    {
        // ── Methods ──
        public void GetConstructorID(){} // RVA: 0x7AEE634D0
        public void GetMethodID(){} // RVA: 0x7A8051B10
        public void GetFieldID(){} // RVA: 0x7A8051B10
        public void CreateJavaRunnable(){} // RVA: 0x7AEE5F440
        public void CreateJavaProxy(){} // RVA: 0x7AEE64BF0
        public void CreateJNIArgArray(){} // RVA: 0x7AEE64E40
        public void DeleteJNIArgArray(){} // RVA: 0x7AEE64F70
        public void ConvertFromJNIArray(){} // RVA: 0x7A8051B10
        public void Box(){} // RVA: 0x7AEE65290
    }

    public class AndroidJNIHelper[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AndroidJNISafe : Object
    {
        // ── Methods ──
        public void CheckException(){} // RVA: 0x7AEE689B0
        public void QueueDeleteGlobalRef(){} // RVA: 0x7AEE68CF0
        public void DeleteWeakGlobalRef(){} // RVA: 0x7AEE68D50
        public void DeleteLocalRef(){} // RVA: 0x7AEE68DB0
        public void NewString(){} // RVA: 0x7AEE68E10
        public void GetStringChars(){} // RVA: 0x7AEE68EA0
        public void GetObjectClass(){} // RVA: 0x7AEE68F30
        public void GetStaticMethodID(){} // RVA: 0x7AEE68FC0
        public void GetMethodID(){} // RVA: 0x7AEE69010
        public void GetFieldID(){} // RVA: 0x7AEE69060
        public void GetStaticFieldID(){} // RVA: 0x7AEE69110
        public void FromReflectedMethod(){} // RVA: 0x7AEE691C0
        public void FindClass(){} // RVA: 0x7AEE69250
        public void NewObject(){} // RVA: 0x7AEE692E0
        public void GetStaticObjectField(){} // RVA: 0x7AEE693D0
        public void GetStaticStringField(){} // RVA: 0x7AEE69470
        public void GetStaticCharField(){} // RVA: 0x7AEE69510
        public void GetStaticDoubleField(){} // RVA: 0x7AEE695B0
        public void GetStaticFloatField(){} // RVA: 0x7AEE69660
        public void GetStaticLongField(){} // RVA: 0x7AEE69710
        public void GetStaticShortField(){} // RVA: 0x7AEE697B0
        public void GetStaticSByteField(){} // RVA: 0x7AEE69850
        public void GetStaticBooleanField(){} // RVA: 0x7AEE698F0
        public void GetStaticIntField(){} // RVA: 0x7AEE69990
        public void CallStaticVoidMethod(){} // RVA: 0x7AEE69AC0
        public void CallStaticObjectMethod(){} // RVA: 0x7AEE69C30
        public void CallStaticStringMethod(){} // RVA: 0x7AEE69DB0
        public void CallStaticCharMethod(){} // RVA: 0x7AEE69EA0
        public void CallStaticDoubleMethod(){} // RVA: 0x7AEE69F90
        public void CallStaticFloatMethod(){} // RVA: 0x7AEE6A090
        public void CallStaticLongMethod(){} // RVA: 0x7AEE6A190
        public void CallStaticShortMethod(){} // RVA: 0x7AEE6A280
        public void CallStaticSByteMethod(){} // RVA: 0x7AEE6A370
        public void CallStaticBooleanMethod(){} // RVA: 0x7AEE6A460
        public void CallStaticIntMethod(){} // RVA: 0x7AEE6A550
        public void GetObjectField(){} // RVA: 0x7AEE6A640
        public void GetStringField(){} // RVA: 0x7AEE6A6E0
        public void GetCharField(){} // RVA: 0x7AEE6A780
        public void GetDoubleField(){} // RVA: 0x7AEE6A820
        public void GetFloatField(){} // RVA: 0x7AEE6A8D0
        public void GetLongField(){} // RVA: 0x7AEE6A980
        public void GetShortField(){} // RVA: 0x7AEE6AA20
        public void GetSByteField(){} // RVA: 0x7AEE6AAC0
        public void GetBooleanField(){} // RVA: 0x7AEE6AB60
        public void GetIntField(){} // RVA: 0x7AEE6AC00
        public void CallVoidMethod(){} // RVA: 0x7AEE6ACA0
        public void CallObjectMethod(){} // RVA: 0x7AEE6AE10
        public void CallStringMethod(){} // RVA: 0x7AEE6AF00
        public void CallCharMethod(){} // RVA: 0x7AEE6AFF0
        public void CallDoubleMethod(){} // RVA: 0x7AEE6B0E0
        public void CallFloatMethod(){} // RVA: 0x7AEE6B1E0
        public void CallLongMethod(){} // RVA: 0x7AEE6B2E0
        public void CallShortMethod(){} // RVA: 0x7AEE6B3D0
        public void CallSByteMethod(){} // RVA: 0x7AEE6B4C0
        public void CallBooleanMethod(){} // RVA: 0x7AEE6B5B0
        public void CallIntMethod(){} // RVA: 0x7AEE6B6A0
        public void FromCharArray(){} // RVA: 0x7AEE6B790
        public void FromDoubleArray(){} // RVA: 0x7AEE6B820
        public void FromFloatArray(){} // RVA: 0x7AEE6B8B0
        public void FromLongArray(){} // RVA: 0x7AEE6B940
        public void FromShortArray(){} // RVA: 0x7AEE6B9D0
        public void FromByteArray(){} // RVA: 0x7AEE6BA60
        public void FromSByteArray(){} // RVA: 0x7AEE6BAF0
        public void FromBooleanArray(){} // RVA: 0x7AEE6BB80
        public void FromIntArray(){} // RVA: 0x7AEE6BC10
        public void ToObjectArray(){} // RVA: 0x7AEE6BCA0
        public void ToCharArray(){} // RVA: 0x7AEE6BD60
        public void ToDoubleArray(){} // RVA: 0x7AEE6BE10
        public void ToFloatArray(){} // RVA: 0x7AEE6BEC0
        public void ToLongArray(){} // RVA: 0x7AEE6BF70
        public void ToShortArray(){} // RVA: 0x7AEE6C020
        public void ToByteArray(){} // RVA: 0x7AEE6C0D0
        public void ToSByteArray(){} // RVA: 0x7AEE6C160
        public void ToBooleanArray(){} // RVA: 0x7AEE6C210
        public void ToIntArray(){} // RVA: 0x7AEE6C2A0
        public void GetObjectArrayElement(){} // RVA: 0x7AEE6C350
        public void GetArrayLength(){} // RVA: 0x7AEE6C3F0
    }

    public class AndroidJavaClass : AndroidJavaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE5E080
        public void _AndroidJavaClass(){} // RVA: 0x7AEE5DEC0
    }

    public class AndroidJavaException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE5B710
        public void get_StackTrace(){} // RVA: 0x7AEE5B7E0
    }

    public class AndroidJavaObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7AEE5DAC0
        public void Call(){} // RVA: 0x7A8051B10
        public void Get(){} // RVA: 0x7A8051B10
        public void GetStatic(){} // RVA: 0x7A8051B10
        public void GetRawObject(){} // RVA: 0x7AEE5D400
        public void GetRawClass(){} // RVA: 0x7ADE59500
        public void CloneReference(){} // RVA: 0x7AEE5D420
        public void CallStatic(){} // RVA: 0x7A8051B10
        public void DebugPrint(){} // RVA: 0x7AEE5D640
        public void _AndroidJavaObject(){} // RVA: 0x7AEE5D860
        public void Finalize(){} // RVA: 0x7AD9C7E80
        public void _Call(){} // RVA: 0x7A8051B10
        public void _Get(){} // RVA: 0x7A8051B10
        public void _CallStatic(){} // RVA: 0x7A8051B10
        public void _GetStatic(){} // RVA: 0x7A8051B10
        public void AndroidJavaObjectDeleteLocalRef(){} // RVA: 0x7AEE5DD50
        public void AndroidJavaClassDeleteLocalRef(){} // RVA: 0x7AEE5DE00
        public void FromJavaArrayDeleteLocalRef(){} // RVA: 0x7A8051B10
        public void _GetRawObject(){} // RVA: 0x7AEE5D400
        public void _GetRawClass(){} // RVA: 0x7ADE59500
    }

    public class AndroidJavaProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE5BBD0
        public void Finalize(){} // RVA: 0x7AEE5BC30
        public void Invoke(){} // RVA: 0x7AEE5C8A0
        public void equals(){} // RVA: 0x7AEE5CCC0
        public void hashCode(){} // RVA: 0x7AEE5CD40
        public void toString(){} // RVA: 0x7AEE5CE30
        public void GetProxyObject(){} // RVA: 0x7AEE5CE90
        public void GetRawProxy(){} // RVA: 0x7AEE5CEB0
        public void .cctor(){} // RVA: 0x7AEE5CFC0
        public void javaInterface(){} // RVA: 0x7B41F3B08
    }

    public class AndroidJavaRunnable : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8135E00
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class AndroidJavaRunnableProxy : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE5B940
        public void run(){} // RVA: 0x7AEE5BA00
        public void Invoke(){} // RVA: 0x7AEE5BA30
    }

    public class AndroidReflection : Object
    {
        // ── Methods ──
        public void IsPrimitive(){} // RVA: 0x7ADDCD2F0
        public void IsAssignableFrom(){} // RVA: 0x7AEE5E1F0
        public void GetStaticMethodID(){} // RVA: 0x7AEE5E220
        public void GetMethodID(){} // RVA: 0x7AEE5E2C0
        public void GetConstructorMember(){} // RVA: 0x7AEE5E360
        public void GetMethodMember(){} // RVA: 0x7AEE5E5B0
        public void GetFieldMember(){} // RVA: 0x7AEE5E8C0
        public void GetFieldClass(){} // RVA: 0x7AEE5EAF0
        public void GetFieldSignature(){} // RVA: 0x7AEE5EB90
        public void NewProxyInstance(){} // RVA: 0x7AEE5ECB0
        public void SetNativeExceptionOnProxy(){} // RVA: 0x7AEE5EE00
        public void .cctor(){} // RVA: 0x7AEE5EF60
    }

    public class Animation : Behaviour
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x7AEE6C540
        public void set_clip(){} // RVA: 0x7AEE6C590
        public void get_playAutomatically(){} // RVA: 0x7AEE6C5F0
        public void set_playAutomatically(){} // RVA: 0x7AEE6C640
        public void get_wrapMode(){} // RVA: 0x7AEE6C6A0
        public void set_wrapMode(){} // RVA: 0x7AEE6C6F0
        public void Stop(){} // RVA: 0x7AEE6C7A0
        public void StopNamed(){} // RVA: 0x7AEE6C7A0
        public void Rewind(){} // RVA: 0x7AEE6C850
        public void RewindNamed(){} // RVA: 0x7AEE6C850
        public void Sample(){} // RVA: 0x7AEE6C8B0
        public void get_isPlaying(){} // RVA: 0x7AEE6C900
        public void IsPlaying(){} // RVA: 0x7AEE6C950
        public void get_Item(){} // RVA: 0x7AEE6C9B0
        public void Play(){} // RVA: 0x7AEE6D4E0
        public void PlayDefaultAnimation(){} // RVA: 0x7AEE6CA70
        public void CrossFade(){} // RVA: 0x7AEE6CCA0
        public void Blend(){} // RVA: 0x7AEE6CE10
        public void CrossFadeQueued(){} // RVA: 0x7AEE6D020
        public void PlayQueued(){} // RVA: 0x7AEE6D1A0
        public void AddClip(){} // RVA: 0x7AEE6D340
        public void RemoveClip(){} // RVA: 0x7AEE6D430
        public void RemoveClipNamed(){} // RVA: 0x7AEE6D430
        public void GetClipCount(){} // RVA: 0x7AEE6D490
        public void SyncLayer(){} // RVA: 0x7AEE6D4F0
        public void GetEnumerator(){} // RVA: 0x7AEE6D550
        public void GetState(){} // RVA: 0x7AEE6C9B0
        public void GetStateAtIndex(){} // RVA: 0x7AEE6D5F0
        public void GetStateCount(){} // RVA: 0x7AEE6D650
        public void GetClip(){} // RVA: 0x7AEE6D6A0
        public void get_animatePhysics(){} // RVA: 0x7AEE6D760
        public void set_animatePhysics(){} // RVA: 0x7AEE6D7B0
        public void get_animateOnlyIfVisible(){} // RVA: 0x7AEE6D810
        public void set_animateOnlyIfVisible(){} // RVA: 0x7AEE6D860
        public void get_cullingType(){} // RVA: 0x7AEE6D8C0
        public void set_cullingType(){} // RVA: 0x7AEE6D910
        public void get_localBounds(){} // RVA: 0x7AEE6D970
        public void set_localBounds(){} // RVA: 0x7AEE6D9E0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_localBounds_Injected(){} // RVA: 0x7AEE6DA40
        public void set_localBounds_Injected(){} // RVA: 0x7AEE6DAA0
    }

    public class AnimationClip : Motion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE6E650
        public void Internal_CreateAnimationClip(){} // RVA: 0x7AEE6E6E0
        public void SampleAnimation(){} // RVA: 0x7AEE6E7F0
        public void get_length(){} // RVA: 0x7AEE6E870
        public void get_frameRate(){} // RVA: 0x7AEE6E8C0
        public void set_frameRate(){} // RVA: 0x7AEE6E910
        public void SetCurve(){} // RVA: 0x7AEE6E970
        public void EnsureQuaternionContinuity(){} // RVA: 0x7AEE6EA00
        public void ClearCurves(){} // RVA: 0x7AEE6EA50
        public void get_wrapMode(){} // RVA: 0x7AEE6EAA0
        public void set_wrapMode(){} // RVA: 0x7AEE6EAF0
        public void get_localBounds(){} // RVA: 0x7AEE6EB50
        public void set_localBounds(){} // RVA: 0x7AEE6EBC0
        public void get_legacy(){} // RVA: 0x7AEE6EC20
        public void set_legacy(){} // RVA: 0x7AEE6EC70
        public void get_humanMotion(){} // RVA: 0x7AEE6ECD0
        public void get_empty(){} // RVA: 0x7AEE6ED20
        public void get_hasGenericRootTransform(){} // RVA: 0x7AEE6ED70
        public void get_hasMotionFloatCurves(){} // RVA: 0x7AEE6EDC0
        public void get_hasMotionCurves(){} // RVA: 0x7AEE6EE10
        public void get_hasRootCurves(){} // RVA: 0x7AEE6EE60
        public void get_hasRootMotion(){} // RVA: 0x7AEE6EEB0
        public void get_events(){} // RVA: 0x7AEE6EF00
        public void set_events(){} // RVA: 0x7AEE6EFB0
        public void SetEventsInternal(){} // RVA: 0x7AEE6EFB0
        public void GetEventsInternal(){} // RVA: 0x7AEE6F010
        public void get_localBounds_Injected(){} // RVA: 0x7AEE6F060
        public void set_localBounds_Injected(){} // RVA: 0x7AEE6F0C0
    }

    public class AnimationClip[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimationCurve : Object
    {
        // ── Methods ──
        public void Internal_Destroy(){} // RVA: 0x7AEE980D0
        public void Internal_Create(){} // RVA: 0x7AEE98120
        public void Internal_Equals(){} // RVA: 0x7AEE98170
        public void Internal_CopyFrom(){} // RVA: 0x7AEE981D0
        public void Finalize(){} // RVA: 0x7AEE98230
        public void Evaluate(){} // RVA: 0x7AEE982B0
        public void get_keys(){} // RVA: 0x7AEE98310
        public void set_keys(){} // RVA: 0x7AEE98360
        public void AddKey(){} // RVA: 0x7AEE98430
        public void AddKey_Internal(){} // RVA: 0x7AEE984A0
        public void MoveKey(){} // RVA: 0x7AEE98500
        public void ClearKeys(){} // RVA: 0x7AEE98570
        public void RemoveKey(){} // RVA: 0x7AEE985C0
        public void get_Item(){} // RVA: 0x7AEE98620
        public void get_length(){} // RVA: 0x7AEE986D0
        public void SetKeys(){} // RVA: 0x7AEE98360
        public void GetKey(){} // RVA: 0x7AEE98720
        public void GetKeys(){} // RVA: 0x7AEE98310
        public void GetHashCode(){} // RVA: 0x7AEE987A0
        public void SmoothTangents(){} // RVA: 0x7AEE987F0
        public void Constant(){} // RVA: 0x7AEE98860
        public void Linear(){} // RVA: 0x7AEE98880
        public void EaseInOut(){} // RVA: 0x7AEE98A70
        public void get_preWrapMode(){} // RVA: 0x7AEE98C30
        public void set_preWrapMode(){} // RVA: 0x7AEE98C80
        public void get_postWrapMode(){} // RVA: 0x7AEE98CE0
        public void set_postWrapMode(){} // RVA: 0x7AEE98D30
        public void .ctor(){} // RVA: 0x7AEE98DF0
        public void Equals(){} // RVA: 0x7AEE98F60
        public void CopyFrom(){} // RVA: 0x7AEE990D0
        public void AddKey_Internal_Injected(){} // RVA: 0x7AEE99140
        public void MoveKey_Injected(){} // RVA: 0x7AEE991A0
        public void GetKey_Injected(){} // RVA: 0x7AEE99210
    }

    public class AnimationCurve[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimationEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE6E4B0
        public void get_stringParameter(){} // RVA: 0x7AE8145B0
        public void get_functionName(){} // RVA: 0x7AACE3A80
    }

    public class AnimationEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimationState : TrackedReference
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7AEE6DBF0
        public void set_enabled(){} // RVA: 0x7AEE6DC40
        public void get_weight(){} // RVA: 0x7AEE6DCA0
        public void set_weight(){} // RVA: 0x7AEE6DCF0
        public void get_wrapMode(){} // RVA: 0x7AEE6DD50
        public void set_wrapMode(){} // RVA: 0x7AEE6DDA0
        public void get_time(){} // RVA: 0x7AEE6DE00
        public void set_time(){} // RVA: 0x7AEE6DE50
        public void get_normalizedTime(){} // RVA: 0x7AEE6DEB0
        public void set_normalizedTime(){} // RVA: 0x7AEE6DF00
        public void get_speed(){} // RVA: 0x7AEE6DF60
        public void set_speed(){} // RVA: 0x7AEE6DFB0
        public void get_normalizedSpeed(){} // RVA: 0x7AEE6E010
        public void set_normalizedSpeed(){} // RVA: 0x7AEE6E060
        public void get_length(){} // RVA: 0x7AEE6E0C0
        public void get_layer(){} // RVA: 0x7AEE6E110
        public void set_layer(){} // RVA: 0x7AEE6E160
        public void get_clip(){} // RVA: 0x7AEE6E1C0
        public void get_name(){} // RVA: 0x7AEE6E210
        public void set_name(){} // RVA: 0x7AEE6E260
        public void get_blendMode(){} // RVA: 0x7AEE6E2C0
        public void set_blendMode(){} // RVA: 0x7AEE6E310
        public void AddMixingTransform(){} // RVA: 0x7AEE6E3E0
        public void RemoveMixingTransform(){} // RVA: 0x7AEE6E450
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AnimationState[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Animation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Animator : Behaviour
    {
        // ── Methods ──
        public void get_isOptimizable(){} // RVA: 0x7AEE6F410
        public void get_isHuman(){} // RVA: 0x7AEE6F460
        public void get_hasRootMotion(){} // RVA: 0x7AEE6F4B0
        public void get_isRootPositionOrRotationControlledByCurves(){} // RVA: 0x7AEE6F500
        public void get_humanScale(){} // RVA: 0x7AEE6F550
        public void get_isInitialized(){} // RVA: 0x7AEE6F5A0
        public void GetFloat(){} // RVA: 0x7AEE6F650
        public void SetFloat(){} // RVA: 0x7AEE6F810
        public void GetBool(){} // RVA: 0x7AEE6F8F0
        public void SetBool(){} // RVA: 0x7AEE6F9C0
        public void GetInteger(){} // RVA: 0x7AEE6FA90
        public void SetInteger(){} // RVA: 0x7AEE6FB60
        public void SetTrigger(){} // RVA: 0x7AEE6FC30
        public void ResetTrigger(){} // RVA: 0x7AEE6FCF0
        public void IsParameterControlledByCurve(){} // RVA: 0x7AEE6FDB0
        public void get_deltaPosition(){} // RVA: 0x7AEE6FE10
        public void get_deltaRotation(){} // RVA: 0x7AEE6FE80
        public void get_velocity(){} // RVA: 0x7AEE6FEF0
        public void get_angularVelocity(){} // RVA: 0x7AEE6FF60
        public void get_rootPosition(){} // RVA: 0x7AEE6FFD0
        public void set_rootPosition(){} // RVA: 0x7AEE70040
        public void get_rootRotation(){} // RVA: 0x7AEE700A0
        public void set_rootRotation(){} // RVA: 0x7AEE70110
        public void get_applyRootMotion(){} // RVA: 0x7AEE70170
        public void set_applyRootMotion(){} // RVA: 0x7AEE701C0
        public void get_noDiscreteIntBindings(){} // RVA: 0x7AEE70220
        public void set_noDiscreteIntBindings(){} // RVA: 0x7AEE70270
        public void get_linearVelocityBlending(){} // RVA: 0x7AEE702D0
        public void set_linearVelocityBlending(){} // RVA: 0x7AEE70320
        public void get_animatePhysics(){} // RVA: 0x7AEE70380
        public void set_animatePhysics(){} // RVA: 0x7AEE703E0
        public void get_updateMode(){} // RVA: 0x7AEE70450
        public void set_updateMode(){} // RVA: 0x7AEE704A0
        public void get_hasTransformHierarchy(){} // RVA: 0x7AEE70500
        public void get_allowConstantClipSamplingOptimization(){} // RVA: 0x7AEE70550
        public void set_allowConstantClipSamplingOptimization(){} // RVA: 0x7AEE705A0
        public void get_gravityWeight(){} // RVA: 0x7AEE70600
        public void get_bodyPosition(){} // RVA: 0x7AEE70650
        public void set_bodyPosition(){} // RVA: 0x7AEE706F0
        public void get_bodyPositionInternal(){} // RVA: 0x7AEE70770
        public void set_bodyPositionInternal(){} // RVA: 0x7AEE707E0
        public void get_bodyRotation(){} // RVA: 0x7AEE70840
        public void set_bodyRotation(){} // RVA: 0x7AEE708D0
        public void get_bodyRotationInternal(){} // RVA: 0x7AEE70940
        public void set_bodyRotationInternal(){} // RVA: 0x7AEE709B0
        public void GetIKPosition(){} // RVA: 0x7AEE70A10
        public void GetGoalPosition(){} // RVA: 0x7AEE70AB0
        public void SetIKPosition(){} // RVA: 0x7AEE70B30
        public void SetGoalPosition(){} // RVA: 0x7AEE70BC0
        public void GetIKRotation(){} // RVA: 0x7AEE70C30
        public void GetGoalRotation(){} // RVA: 0x7AEE70CD0
        public void SetIKRotation(){} // RVA: 0x7AEE70D50
        public void SetGoalRotation(){} // RVA: 0x7AEE70DD0
        public void GetIKPositionWeight(){} // RVA: 0x7AEE70E40
        public void GetGoalWeightPosition(){} // RVA: 0x7AEE70EB0
        public void SetIKPositionWeight(){} // RVA: 0x7AEE70F10
        public void SetGoalWeightPosition(){} // RVA: 0x7AEE70F90
        public void GetIKRotationWeight(){} // RVA: 0x7AEE71000
        public void GetGoalWeightRotation(){} // RVA: 0x7AEE71070
        public void SetIKRotationWeight(){} // RVA: 0x7AEE710D0
        public void SetGoalWeightRotation(){} // RVA: 0x7AEE71150
        public void GetIKHintPosition(){} // RVA: 0x7AEE711C0
        public void GetHintPosition(){} // RVA: 0x7AEE71260
        public void SetIKHintPosition(){} // RVA: 0x7AEE712E0
        public void SetHintPosition(){} // RVA: 0x7AEE71370
        public void GetIKHintPositionWeight(){} // RVA: 0x7AEE713E0
        public void GetHintWeightPosition(){} // RVA: 0x7AEE71450
        public void SetIKHintPositionWeight(){} // RVA: 0x7AEE714B0
        public void SetHintWeightPosition(){} // RVA: 0x7AEE71530
        public void SetLookAtPosition(){} // RVA: 0x7AEE715A0
        public void SetLookAtPositionInternal(){} // RVA: 0x7AEE71620
        public void SetLookAtWeight(){} // RVA: 0x7AEE71900
        public void SetLookAtWeightInternal(){} // RVA: 0x7AEE71960
        public void SetBoneLocalRotation(){} // RVA: 0x7AEE719F0
        public void SetBoneLocalRotationInternal(){} // RVA: 0x7AEE71AB0
        public void GetBehaviour(){} // RVA: 0x7A8051B10
        public void ConvertStateMachineBehaviour(){} // RVA: 0x7AA1AC5E0
        public void GetBehaviours(){} // RVA: 0x7AA1AC8F0
        public void InternalGetBehaviours(){} // RVA: 0x7AEE71B80
        public void InternalGetBehavioursByKey(){} // RVA: 0x7AEE71D20
        public void get_stabilizeFeet(){} // RVA: 0x7AEE71DA0
        public void set_stabilizeFeet(){} // RVA: 0x7AEE71DF0
        public void get_layerCount(){} // RVA: 0x7AEE71E50
        public void GetLayerName(){} // RVA: 0x7AEE71EA0
        public void GetLayerIndex(){} // RVA: 0x7AEE71F00
        public void GetLayerWeight(){} // RVA: 0x7AEE71F60
        public void SetLayerWeight(){} // RVA: 0x7AEE71FC0
        public void GetAnimatorStateInfo(){} // RVA: 0x7AEE72030
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7AEE720B0
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7AEE72160
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7AEE72280
        public void GetAnimatorClipInfoCount(){} // RVA: 0x7AEE72320
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7AEE72390
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7AEE723F0
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7AEE72510
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7AEE72610
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7AEE72590
        public void IsInTransition(){} // RVA: 0x7AEE72690
        public void get_parameters(){} // RVA: 0x7AEE726F0
        public void get_parameterCount(){} // RVA: 0x7AEE72740
        public void GetParameterInternal(){} // RVA: 0x7AEE72790
        public void GetParameter(){} // RVA: 0x7AEE727F0
        public void get_feetPivotActive(){} // RVA: 0x7AEE728E0
        public void set_feetPivotActive(){} // RVA: 0x7AEE72930
        public void get_pivotWeight(){} // RVA: 0x7AEE72990
        public void get_pivotPosition(){} // RVA: 0x7AEE729E0
        public void MatchTarget(){} // RVA: 0x7AEE72CB0
        public void InterruptMatchTarget(){} // RVA: 0x7AEE72DE0
        public void get_isMatchingTarget(){} // RVA: 0x7AEE72E40
        public void get_speed(){} // RVA: 0x7AEE72E90
        public void set_speed(){} // RVA: 0x7AEE72EE0
        public void ForceStateNormalizedTime(){} // RVA: 0x7AEE72F40
        public void CrossFadeInFixedTime(){} // RVA: 0x7AEE73490
        public void WriteDefaultValues(){} // RVA: 0x7AEE73510
        public void CrossFade(){} // RVA: 0x7AEE73870
        public void PlayInFixedTime(){} // RVA: 0x7AEE73A80
        public void Play(){} // RVA: 0x7AEE73C30
        public void SetTarget(){} // RVA: 0x7AEE73C60
        public void get_targetPosition(){} // RVA: 0x7AEE73CD0
        public void get_targetRotation(){} // RVA: 0x7AEE73D40
        public void IsControlled(){} // RVA: 0x7AA57AB40
        public void IsBoneTransform(){} // RVA: 0x7AEE73DB0
        public void get_avatarRoot(){} // RVA: 0x7AEE73E10
        public void GetBoneTransform(){} // RVA: 0x7AEE73E60
        public void GetBoneTransformInternal(){} // RVA: 0x7AEE74290
        public void get_cullingMode(){} // RVA: 0x7AEE742F0
        public void set_cullingMode(){} // RVA: 0x7AEE74340
        public void StartPlayback(){} // RVA: 0x7AEE743A0
        public void StopPlayback(){} // RVA: 0x7AEE743F0
        public void get_playbackTime(){} // RVA: 0x7AEE74440
        public void set_playbackTime(){} // RVA: 0x7AEE74490
        public void StartRecording(){} // RVA: 0x7AEE744F0
        public void StopRecording(){} // RVA: 0x7AEE74550
        public void get_recorderStartTime(){} // RVA: 0x7AEE745A0
        public void set_recorderStartTime(){} // RVA: 0x7A80D7310
        public void GetRecorderStartTime(){} // RVA: 0x7AEE745A0
        public void get_recorderStopTime(){} // RVA: 0x7AEE745F0
        public void set_recorderStopTime(){} // RVA: 0x7A80D7310
        public void GetRecorderStopTime(){} // RVA: 0x7AEE745F0
        public void get_recorderMode(){} // RVA: 0x7AEE74640
        public void get_runtimeAnimatorController(){} // RVA: 0x7AEE74690
        public void set_runtimeAnimatorController(){} // RVA: 0x7AEE746E0
        public void get_hasBoundPlayables(){} // RVA: 0x7AEE74740
        public void ClearInternalControllerPlayable(){} // RVA: 0x7AEE74790
        public void HasState(){} // RVA: 0x7AEE747E0
        public void StringToHash(){} // RVA: 0x7AEE74850
        public void get_avatar(){} // RVA: 0x7AEE748A0
        public void set_avatar(){} // RVA: 0x7AEE748F0
        public void GetStats(){} // RVA: 0x7AEE74950
        public void get_playableGraph(){} // RVA: 0x7AEE749A0
        public void GetCurrentGraph(){} // RVA: 0x7AEE74A20
        public void CheckIfInIKPass(){} // RVA: 0x7AEE74A80
        public void IsInIKPass(){} // RVA: 0x7AEE74B80
        public void SetFloatString(){} // RVA: 0x7AEE6F6B0
        public void SetFloatID(){} // RVA: 0x7AEE6F7A0
        public void GetFloatString(){} // RVA: 0x7AEE6F5F0
        public void GetFloatID(){} // RVA: 0x7AEE6F650
        public void SetBoolString(){} // RVA: 0x7AEE6F950
        public void SetBoolID(){} // RVA: 0x7AEE6F9C0
        public void GetBoolString(){} // RVA: 0x7AEE6F890
        public void GetBoolID(){} // RVA: 0x7AEE6F8F0
        public void SetIntegerString(){} // RVA: 0x7AEE6FAF0
        public void SetIntegerID(){} // RVA: 0x7AEE6FB60
        public void GetIntegerString(){} // RVA: 0x7AEE6FA30
        public void GetIntegerID(){} // RVA: 0x7AEE6FA90
        public void SetTriggerString(){} // RVA: 0x7AEE6FBD0
        public void SetTriggerID(){} // RVA: 0x7AEE6FC30
        public void ResetTriggerString(){} // RVA: 0x7AEE6FC90
        public void ResetTriggerID(){} // RVA: 0x7AEE6FCF0
        public void IsParameterControlledByCurveString(){} // RVA: 0x7AEE6FD50
        public void IsParameterControlledByCurveID(){} // RVA: 0x7AEE6FDB0
        public void SetFloatStringDamp(){} // RVA: 0x7AEE6F720
        public void SetFloatIDDamp(){} // RVA: 0x7AEE6F810
        public void get_layersAffectMassCenter(){} // RVA: 0x7AEE74BD0
        public void set_layersAffectMassCenter(){} // RVA: 0x7AEE74C20
        public void get_leftFeetBottomHeight(){} // RVA: 0x7AEE74C80
        public void get_rightFeetBottomHeight(){} // RVA: 0x7AEE74CD0
        public void get_supportsOnAnimatorMove(){} // RVA: 0x7AEE74D20
        public void OnUpdateModeChanged(){} // RVA: 0x7AEE74D70
        public void OnCullingModeChanged(){} // RVA: 0x7AEE74DC0
        public void WriteDefaultPose(){} // RVA: 0x7AEE74E10
        public void Update(){} // RVA: 0x7AEE74E60
        public void Rebind(){} // RVA: 0x7AEE74F20
        public void ApplyBuiltinRootMotion(){} // RVA: 0x7AEE74F80
        public void EvaluateController(){} // RVA: 0x7AEE75030
        public void GetCurrentStateName(){} // RVA: 0x7AEE75090
        public void GetNextStateName(){} // RVA: 0x7AEE750F0
        public void GetAnimatorStateName(){} // RVA: 0x7AEE75150
        public void ResolveHash(){} // RVA: 0x7AEE751C0
        public void get_logWarnings(){} // RVA: 0x7AEE75220
        public void set_logWarnings(){} // RVA: 0x7AEE75270
        public void get_fireEvents(){} // RVA: 0x7AEE752D0
        public void set_fireEvents(){} // RVA: 0x7AEE75320
        public void get_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7AEE75380
        public void set_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7AEE753D0
        public void get_keepAnimatorStateOnDisable(){} // RVA: 0x7AEE75380
        public void set_keepAnimatorStateOnDisable(){} // RVA: 0x7AEE753D0
        public void get_writeDefaultValuesOnDisable(){} // RVA: 0x7AEE75430
        public void set_writeDefaultValuesOnDisable(){} // RVA: 0x7AEE75480
        public void GetVector(){} // RVA: 0x7AEE754E0
        public void SetVector(){} // RVA: 0x7A80D7310
        public void GetQuaternion(){} // RVA: 0x7AEE75540
        public void SetQuaternion(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_deltaPosition_Injected(){} // RVA: 0x7AEE75590
        public void get_deltaRotation_Injected(){} // RVA: 0x7AEE755F0
        public void get_velocity_Injected(){} // RVA: 0x7AEE75650
        public void get_angularVelocity_Injected(){} // RVA: 0x7AEE756B0
        public void get_rootPosition_Injected(){} // RVA: 0x7AEE75710
        public void set_rootPosition_Injected(){} // RVA: 0x7AEE75770
        public void get_rootRotation_Injected(){} // RVA: 0x7AEE757D0
        public void set_rootRotation_Injected(){} // RVA: 0x7AEE75830
        public void get_bodyPositionInternal_Injected(){} // RVA: 0x7AEE75890
        public void set_bodyPositionInternal_Injected(){} // RVA: 0x7AEE758F0
        public void get_bodyRotationInternal_Injected(){} // RVA: 0x7AEE75950
        public void set_bodyRotationInternal_Injected(){} // RVA: 0x7AEE759B0
        public void GetGoalPosition_Injected(){} // RVA: 0x7AEE75A10
        public void SetGoalPosition_Injected(){} // RVA: 0x7AEE75A80
        public void GetGoalRotation_Injected(){} // RVA: 0x7AEE75AF0
        public void SetGoalRotation_Injected(){} // RVA: 0x7AEE75B60
        public void GetHintPosition_Injected(){} // RVA: 0x7AEE75BD0
        public void SetHintPosition_Injected(){} // RVA: 0x7AEE75C40
        public void SetLookAtPositionInternal_Injected(){} // RVA: 0x7AEE75CB0
        public void SetBoneLocalRotationInternal_Injected(){} // RVA: 0x7AEE75D10
        public void get_pivotPosition_Injected(){} // RVA: 0x7AEE75D80
        public void MatchTarget_Injected(){} // RVA: 0x7AEE75DE0
        public void get_targetPosition_Injected(){} // RVA: 0x7AEE75E70
        public void get_targetRotation_Injected(){} // RVA: 0x7AEE75ED0
    }

    public class AnimatorClipInfo : ValueType
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x7A7ED47A0
        public void get_weight(){} // RVA: 0x7A7ED4380
        public void InstanceIDToAnimationClipPPtr(){} // RVA: 0x7AEE6F180
    }

    public class AnimatorClipInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A0FB0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2501E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimatorControllerParameter : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7AB1AC740
        public void get_nameHash(){} // RVA: 0x7AEE75F30
        public void get_type(){} // RVA: 0x7ABB8C660
        public void set_type(){} // RVA: 0x7A84385B0
        public void get_defaultFloat(){} // RVA: 0x7AEE5B520
        public void set_defaultFloat(){} // RVA: 0x7A81A5190
        public void get_defaultInt(){} // RVA: 0x7AC1CB330
        public void set_defaultInt(){} // RVA: 0x7A8738180
        public void get_defaultBool(){} // RVA: 0x7AEE75F80
        public void set_defaultBool(){} // RVA: 0x7A9727920
        public void Equals(){} // RVA: 0x7AEE75F90
        public void GetHashCode(){} // RVA: 0x7A8738190
        public void .ctor(){} // RVA: 0x7AEE76070
    }

    public class AnimatorControllerParameter[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimatorOverrideController : RuntimeAnimatorController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE761E0
        public void Internal_Create(){} // RVA: 0x7AEE762D0
        public void get_runtimeAnimatorController(){} // RVA: 0x7AEE76330
        public void set_runtimeAnimatorController(){} // RVA: 0x7AEE76380
        public void get_Item(){} // RVA: 0x7AEE76530
        public void set_Item(){} // RVA: 0x7AEE765A0
        public void Internal_GetClipByName(){} // RVA: 0x7AEE764C0
        public void Internal_SetClipByName(){} // RVA: 0x7AEE76450
        public void GetClip(){} // RVA: 0x7AEE765C0
        public void SetClip(){} // RVA: 0x7AEE76630
        public void SendNotification(){} // RVA: 0x7AEE766B0
        public void GetOriginalClip(){} // RVA: 0x7AEE76700
        public void GetOverrideClip(){} // RVA: 0x7AEE76760
        public void get_overridesCount(){} // RVA: 0x7AEE767C0
        public void GetOverrides(){} // RVA: 0x7AEE76810
        public void ApplyOverrides(){} // RVA: 0x7AEE76A80
        public void OnInvalidateOverrideController(){} // RVA: 0x7AEE76DC0
    }

    public class AnimatorOverrideController[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimatorStateInfo : ValueType
    {
        // ── Methods ──
        public void IsName(){} // RVA: 0x7A7ED4800
        public void get_fullPathHash(){} // RVA: 0x7A79D4850
        public void get_shortNameHash(){} // RVA: 0x7A79EAED0
        public void get_normalizedTime(){} // RVA: 0x7A7ED43A0
        public void get_length(){} // RVA: 0x7A7ED43B0
        public void get_speed(){} // RVA: 0x7A7832350
        public void get_speedMultiplier(){} // RVA: 0x7A7ED3A80
        public void get_tagHash(){} // RVA: 0x7A7ED3A90
        public void IsTag(){} // RVA: 0x7A7ED4810
        public void get_loop(){} // RVA: 0x7A7ED3AA0
    }

    public class AnimatorStateInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A25C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E540
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E36F0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25C570
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E540
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimatorTransitionInfo : ValueType
    {
        // ── Methods ──
        public void IsName(){} // RVA: 0x7A7ED48A0
        public void IsUserName(){} // RVA: 0x7A7ED48B0
        public void get_fullPathHash(){} // RVA: 0x7A79EAED0
        public void get_nameHash(){} // RVA: 0x7A79D4850
        public void get_userNameHash(){} // RVA: 0x7A7A39F60
        public void get_durationUnit(){} // RVA: 0x7A7ED48C0
        public void get_duration(){} // RVA: 0x7A7ED43B0
        public void get_normalizedTime(){} // RVA: 0x7A7832350
        public void get_anyState(){} // RVA: 0x7A7ED48D0
    }

    public class AnimatorTransitionInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A18F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2508F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AnimatorUtility : Object
    {
        // ── Methods ──
        public void OptimizeTransformHierarchy(){} // RVA: 0x7AEE76E00
        public void DeoptimizeTransformHierarchy(){} // RVA: 0x7AEE76E60
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Animator[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Application : Object
    {
        // ── Methods ──
        public void Quit(){} // RVA: 0x7AEE992D0
        public void get_isPlaying(){} // RVA: 0x7AEE99350
        public void get_isFocused(){} // RVA: 0x7AEE993A0
        public void get_buildGUID(){} // RVA: 0x7AEE993F0
        public void get_runInBackground(){} // RVA: 0x7AEE99440
        public void set_runInBackground(){} // RVA: 0x7AEE99490
        public void get_isBatchMode(){} // RVA: 0x7AEE994E0
        public void get_dataPath(){} // RVA: 0x7AEE99530
        public void get_streamingAssetsPath(){} // RVA: 0x7AEE99580
        public void get_persistentDataPath(){} // RVA: 0x7AEE995D0
        public void get_temporaryCachePath(){} // RVA: 0x7AEE99620
        public void get_unityVersion(){} // RVA: 0x7AEE99670
        public void get_version(){} // RVA: 0x7AEE996C0
        public void get_installMode(){} // RVA: 0x7AEE99710
        public void get_productName(){} // RVA: 0x7AEE99760
        public void get_companyName(){} // RVA: 0x7AEE997B0
        public void get_cloudProjectId(){} // RVA: 0x7AEE99800
        public void OpenURL(){} // RVA: 0x7AEE99850
        public void get_targetFrameRate(){} // RVA: 0x7AEE998A0
        public void set_targetFrameRate(){} // RVA: 0x7AEE998F0
        public void SetLogCallbackDefined(){} // RVA: 0x7AEE99940
        public void GetStackTraceLogType(){} // RVA: 0x7AEE99990
        public void set_backgroundLoadingPriority(){} // RVA: 0x7AEE999E0
        public void HasUserAuthorization(){} // RVA: 0x7AEE99A30
        public void get_platform(){} // RVA: 0x7AEE99A80
        public void get_isMobilePlatform(){} // RVA: 0x7AEE99AD0
        public void get_systemLanguage(){} // RVA: 0x7AEE99BC0
        public void get_internetReachability(){} // RVA: 0x7AEE99C10
        public void add_lowMemory(){} // RVA: 0x7AEE99C60
        public void remove_lowMemory(){} // RVA: 0x7AEE99DB0
        public void CallLowMemory(){} // RVA: 0x7AEE99F00
        public void HasLogCallback(){} // RVA: 0x7AEE9A040
        public void add_logMessageReceivedThreaded(){} // RVA: 0x7AEE9A0D0
        public void remove_logMessageReceivedThreaded(){} // RVA: 0x7AEE9A250
        public void CallLogCallback(){} // RVA: 0x7AEE9A390
        public void add_onBeforeRender(){} // RVA: 0x7AEE9A480
        public void remove_onBeforeRender(){} // RVA: 0x7AEE9A4D0
        public void add_focusChanged(){} // RVA: 0x7AEE9A520
        public void remove_focusChanged(){} // RVA: 0x7AEE9A690
        public void add_wantsToQuit(){} // RVA: 0x7AEE9A800
        public void remove_wantsToQuit(){} // RVA: 0x7AEE9A970
        public void add_quitting(){} // RVA: 0x7AEE9AAE0
        public void remove_quitting(){} // RVA: 0x7AEE9AC30
        public void Internal_ApplicationWantsToQuit(){} // RVA: 0x7AEE9AD80
        public void Internal_ApplicationQuit(){} // RVA: 0x7AEE9AF30
        public void Internal_ApplicationUnload(){} // RVA: 0x7AEE9B0D0
        public void InvokeOnBeforeRender(){} // RVA: 0x7AEE9B170
        public void InvokeFocusChanged(){} // RVA: 0x7AEE9B1C0
        public void InvokeDeepLinkActivated(){} // RVA: 0x7AEE9B260
        public void get_isEditor(){} // RVA: 0x7AA57AB40
        public void .cctor(){} // RVA: 0x7AEE9B300
    }

    public class ApplicationMemoryUsageChange : ValueType
    {
        // ── Methods ──
        public void set_memoryUsage(){} // RVA: 0x7A76134D0
        public void .ctor(){} // RVA: 0x7A76134D0
    }

    public class Application[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AreaEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_forceAngle(){} // RVA: 0x7AEFCD7F0
        public void set_forceAngle(){} // RVA: 0x7AEFCD840
        public void get_useGlobalAngle(){} // RVA: 0x7AEFCD8A0
        public void set_useGlobalAngle(){} // RVA: 0x7AEFCD8F0
        public void get_forceMagnitude(){} // RVA: 0x7AEFCD950
        public void set_forceMagnitude(){} // RVA: 0x7AEFCD9A0
        public void get_forceVariation(){} // RVA: 0x7AEFCDA00
        public void set_forceVariation(){} // RVA: 0x7AEFCDA50
        public void get_drag(){} // RVA: 0x7AEFCDAB0
        public void set_drag(){} // RVA: 0x7AEFCDB00
        public void get_angularDrag(){} // RVA: 0x7AEFCDB60
        public void set_angularDrag(){} // RVA: 0x7AEFCDBB0
        public void get_forceTarget(){} // RVA: 0x7AEFCDC10
        public void set_forceTarget(){} // RVA: 0x7AEFCDC60
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class ArticulationBody : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AssemblyFullName : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7EDF880
        public void GetHashCode(){} // RVA: 0x7A7EDF890
        public void ToString(){} // RVA: 0x7A7EDF930
    }

    public class AssemblyFullName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssemblyIsEditorAssembly[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssemblyVersion : ValueType
    {
        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7AEF01C60
        public void ToString(){} // RVA: 0x7A7EDF570
        public void Equals(){} // RVA: 0x7A7EDF580
        public void GetHashCode(){} // RVA: 0x7A7EDF630
    }

    public class AssemblyVersion[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssetBundle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE890A0
        public void LoadAsset(){} // RVA: 0x7AEE891D0
        public void LoadAsset_Internal(){} // RVA: 0x7AEE89370
        public void LoadAssetWithSubAssetsAsync(){} // RVA: 0x7AEE89600
        public void LoadAllAssetsAsync(){} // RVA: 0x7AEE898F0
        public void Unload(){} // RVA: 0x7AEE899C0
        public void UnloadAsync(){} // RVA: 0x7AEE89A20
        public void GetAllAssetNames(){} // RVA: 0x7AEE89A80
        public void GetAllScenePaths(){} // RVA: 0x7AEE89AD0
        public void LoadAssetWithSubAssetsAsync_Internal(){} // RVA: 0x7AEE89B20
    }

    public class AssetBundleCreateRequest : AsyncOperation
    {
        // ── Methods ──
        public void get_assetBundle(){} // RVA: 0x7AEE89BA0
    }

    public class AssetBundleCreateRequest[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssetBundleRecompressOperation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssetBundleRequest : ResourceRequest
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7AEE89BF0
        public void get_asset(){} // RVA: 0x7A818C700
        public void get_allAssets(){} // RVA: 0x7AEE89C40
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AssetBundleRequest[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssetBundleUnloadOperation : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AssetBundleUnloadOperation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AssetFileNameExtensionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class AsyncInstantiateOperation : AsyncOperation
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7AE8145B0
    }

    public class AsyncInstantiateOperationHelper : Object
    {
        // ── Methods ──
        public void SetAsyncInstantiateOperationResult(){} // RVA: 0x7AEEFFC20
    }

    public class AsyncInstantiateOperationHelper[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AsyncInstantiateOperation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AsyncInstantiateOperation`1 : CustomYieldInstruction
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7A7E01900
        public void add_completed(){} // RVA: 0x7A7E18800
        public void remove_completed(){} // RVA: 0x7A7E18800
        public void get_isDone(){} // RVA: 0x7A7E01900
        public void get_progress(){} // RVA: 0x7A7E155B0
        public void get_Result(){} // RVA: 0x7A7E00680
    }

    public class AsyncOperation : YieldInstruction
    {
        // ── Methods ──
        public void InternalDestroy(){} // RVA: 0x7AEEFFC80
        public void get_isDone(){} // RVA: 0x7AEEFFCD0
        public void get_progress(){} // RVA: 0x7AEEFFD20
        public void set_allowSceneActivation(){} // RVA: 0x7AEEFFD70
        public void Finalize(){} // RVA: 0x7AEEFFDD0
        public void InvokeCompletionEvent(){} // RVA: 0x7AEEFFE50
        public void add_completed(){} // RVA: 0x7AEEFFED0
        public void remove_completed(){} // RVA: 0x7AEF00050
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AsyncOperation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AttributeHelperEngine : Object
    {
        // ── Methods ──
        public void GetParentTypeDisallowingMultipleInclusion(){} // RVA: 0x7AEF00150
        public void GetRequiredComponents(){} // RVA: 0x7AEF00310
        public void GetExecuteMode(){} // RVA: 0x7AEF007C0
        public void CheckIsEditorScript(){} // RVA: 0x7AEF00940
        public void GetDefaultExecutionOrderFor(){} // RVA: 0x7AEF00BC0
        public void GetCustomAttributeOfType(){} // RVA: 0x7A8051B10
        public void .cctor(){} // RVA: 0x7AEF00D60
    }

    public class AttributeHelperEngine[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AudioBehaviour : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioChorusFilter : Behaviour
    {
        // ── Methods ──
        public void get_dryMix(){} // RVA: 0x7AEE8EF00
        public void set_dryMix(){} // RVA: 0x7AEE8EF50
        public void get_wetMix1(){} // RVA: 0x7AEE8EFB0
        public void set_wetMix1(){} // RVA: 0x7AEE8F000
        public void get_wetMix2(){} // RVA: 0x7AEE8F060
        public void set_wetMix2(){} // RVA: 0x7AEE8F0B0
        public void get_wetMix3(){} // RVA: 0x7AEE8F110
        public void set_wetMix3(){} // RVA: 0x7AEE8F160
        public void get_delay(){} // RVA: 0x7AEE8F1C0
        public void set_delay(){} // RVA: 0x7AEE8F210
        public void get_rate(){} // RVA: 0x7AEE8F270
        public void set_rate(){} // RVA: 0x7AEE8F2C0
        public void get_depth(){} // RVA: 0x7AEE8F320
        public void set_depth(){} // RVA: 0x7AEE8F370
        public void get_feedback(){} // RVA: 0x7AEE8F3D0
        public void set_feedback(){} // RVA: 0x7AEE8F440
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioClip : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE8A2D0
        public void GetData(){} // RVA: 0x7AEE8A970
        public void SetData(){} // RVA: 0x7AEE8AB60
        public void Construct_Internal(){} // RVA: 0x7AEE8A4D0
        public void GetName(){} // RVA: 0x7AEE8A520
        public void CreateUserSound(){} // RVA: 0x7AEE8A570
        public void get_length(){} // RVA: 0x7AEE8A600
        public void get_samples(){} // RVA: 0x7AEE8A650
        public void get_channels(){} // RVA: 0x7AEE8A6A0
        public void get_frequency(){} // RVA: 0x7AEE8A6F0
        public void get_loadType(){} // RVA: 0x7AEE8A740
        public void LoadAudioData(){} // RVA: 0x7AEE8A790
        public void UnloadAudioData(){} // RVA: 0x7AEE8A7E0
        public void get_preloadAudioData(){} // RVA: 0x7AEE8A830
        public void get_ambisonic(){} // RVA: 0x7AEE8A880
        public void get_loadInBackground(){} // RVA: 0x7AEE8A8D0
        public void get_loadState(){} // RVA: 0x7AEE8A920
        public void Create(){} // RVA: 0x7AEE8AE30
        public void add_m_PCMReaderCallback(){} // RVA: 0x7AEE8B220
        public void remove_m_PCMReaderCallback(){} // RVA: 0x7AEE8B310
        public void add_m_PCMSetPositionCallback(){} // RVA: 0x7AEE8B400
        public void remove_m_PCMSetPositionCallback(){} // RVA: 0x7AEE8B4F0
        public void InvokePCMReaderCallback_Internal(){} // RVA: 0x7AEE8B5E0
        public void InvokePCMSetPositionCallback_Internal(){} // RVA: 0x7AEE8B600
    }

    public class AudioClip[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AudioDistortionFilter : Behaviour
    {
        // ── Methods ──
        public void get_distortionLevel(){} // RVA: 0x7AEE8EB90
        public void set_distortionLevel(){} // RVA: 0x7AEE8EBE0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioEchoFilter : Behaviour
    {
        // ── Methods ──
        public void get_delay(){} // RVA: 0x7AEE8EC40
        public void set_delay(){} // RVA: 0x7AEE8EC90
        public void get_decayRatio(){} // RVA: 0x7AEE8ECF0
        public void set_decayRatio(){} // RVA: 0x7AEE8ED40
        public void get_dryMix(){} // RVA: 0x7AEE8EDA0
        public void set_dryMix(){} // RVA: 0x7AEE8EDF0
        public void get_wetMix(){} // RVA: 0x7AEE8EE50
        public void set_wetMix(){} // RVA: 0x7AEE8EEA0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioHighPassFilter : Behaviour
    {
        // ── Methods ──
        public void get_cutoffFrequency(){} // RVA: 0x7AEE8EA30
        public void set_cutoffFrequency(){} // RVA: 0x7AEE8EA80
        public void get_highpassResonanceQ(){} // RVA: 0x7AEE8EAE0
        public void set_highpassResonanceQ(){} // RVA: 0x7AEE8EB30
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioListener : AudioBehaviour
    {
        // ── Methods ──
        public void get_volume(){} // RVA: 0x7AEE8B620
        public void set_volume(){} // RVA: 0x7AEE8B670
        public void get_pause(){} // RVA: 0x7AEE8B6D0
        public void set_pause(){} // RVA: 0x7AEE8B720
    }

    public class AudioListener[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AudioLowPassFilter : Behaviour
    {
        // ── Methods ──
        public void GetCustomLowpassLevelCurveCopy(){} // RVA: 0x7AEE8E820
        public void SetCustomLowpassLevelCurveHelper(){} // RVA: 0x7AEE8E870
        public void get_customCutoffCurve(){} // RVA: 0x7AEE8E820
        public void set_customCutoffCurve(){} // RVA: 0x7AEE8E870
        public void get_cutoffFrequency(){} // RVA: 0x7AEE8E8D0
        public void set_cutoffFrequency(){} // RVA: 0x7AEE8E920
        public void get_lowpassResonanceQ(){} // RVA: 0x7AEE8E980
        public void set_lowpassResonanceQ(){} // RVA: 0x7AEE8E9D0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioRenderer : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7AEE907A0
        public void Stop(){} // RVA: 0x7AEE907F0
        public void GetSampleCountForCaptureFrame(){} // RVA: 0x7AEE90840
        public void Render(){} // RVA: 0x7AEE90890
        public void Internal_AudioRenderer_Start(){} // RVA: 0x7AEE907A0
        public void Internal_AudioRenderer_Stop(){} // RVA: 0x7AEE907F0
        public void Internal_AudioRenderer_GetSampleCountForCaptureFrame(){} // RVA: 0x7AEE90840
        public void Internal_AudioRenderer_Render(){} // RVA: 0x7AEE90920
    }

    public class AudioReverbFilter : Behaviour
    {
        // ── Methods ──
        public void get_reverbPreset(){} // RVA: 0x7AEE8F4A0
        public void set_reverbPreset(){} // RVA: 0x7AEE8F4F0
        public void get_dryLevel(){} // RVA: 0x7AEE8F550
        public void set_dryLevel(){} // RVA: 0x7AEE8F5A0
        public void get_room(){} // RVA: 0x7AEE8F600
        public void set_room(){} // RVA: 0x7AEE8F650
        public void get_roomHF(){} // RVA: 0x7AEE8F6B0
        public void set_roomHF(){} // RVA: 0x7AEE8F700
        public void get_roomRolloffFactor(){} // RVA: 0x7AEE8F760
        public void set_roomRolloffFactor(){} // RVA: 0x7AEE8F7D0
        public void get_decayTime(){} // RVA: 0x7AEE8F830
        public void set_decayTime(){} // RVA: 0x7AEE8F880
        public void get_decayHFRatio(){} // RVA: 0x7AEE8F8E0
        public void set_decayHFRatio(){} // RVA: 0x7AEE8F930
        public void get_reflectionsLevel(){} // RVA: 0x7AEE8F990
        public void set_reflectionsLevel(){} // RVA: 0x7AEE8F9E0
        public void get_reflectionsDelay(){} // RVA: 0x7AEE8FA40
        public void set_reflectionsDelay(){} // RVA: 0x7AEE8FA90
        public void get_reverbLevel(){} // RVA: 0x7AEE8FAF0
        public void set_reverbLevel(){} // RVA: 0x7AEE8FB40
        public void get_reverbDelay(){} // RVA: 0x7AEE8FBA0
        public void set_reverbDelay(){} // RVA: 0x7AEE8FBF0
        public void get_diffusion(){} // RVA: 0x7AEE8FC50
        public void set_diffusion(){} // RVA: 0x7AEE8FCA0
        public void get_density(){} // RVA: 0x7AEE8FD00
        public void set_density(){} // RVA: 0x7AEE8FD50
        public void get_hfReference(){} // RVA: 0x7AEE8FDB0
        public void set_hfReference(){} // RVA: 0x7AEE8FE00
        public void get_roomLF(){} // RVA: 0x7AEE8FE60
        public void set_roomLF(){} // RVA: 0x7AEE8FEB0
        public void get_lfReference(){} // RVA: 0x7AEE8FF10
        public void set_lfReference(){} // RVA: 0x7AEE8FF60
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioReverbZone : Behaviour
    {
        // ── Methods ──
        public void get_minDistance(){} // RVA: 0x7AEE8DC50
        public void set_minDistance(){} // RVA: 0x7AEE8DCA0
        public void get_maxDistance(){} // RVA: 0x7AEE8DD00
        public void set_maxDistance(){} // RVA: 0x7AEE8DD50
        public void get_reverbPreset(){} // RVA: 0x7AEE8DDB0
        public void set_reverbPreset(){} // RVA: 0x7AEE8DE00
        public void get_room(){} // RVA: 0x7AEE8DE60
        public void set_room(){} // RVA: 0x7AEE8DEB0
        public void get_roomHF(){} // RVA: 0x7AEE8DF10
        public void set_roomHF(){} // RVA: 0x7AEE8DF60
        public void get_roomLF(){} // RVA: 0x7AEE8DFC0
        public void set_roomLF(){} // RVA: 0x7AEE8E010
        public void get_decayTime(){} // RVA: 0x7AEE8E070
        public void set_decayTime(){} // RVA: 0x7AEE8E0C0
        public void get_decayHFRatio(){} // RVA: 0x7AEE8E120
        public void set_decayHFRatio(){} // RVA: 0x7AEE8E170
        public void get_reflections(){} // RVA: 0x7AEE8E1D0
        public void set_reflections(){} // RVA: 0x7AEE8E220
        public void get_reflectionsDelay(){} // RVA: 0x7AEE8E280
        public void set_reflectionsDelay(){} // RVA: 0x7AEE8E2D0
        public void get_reverb(){} // RVA: 0x7AEE8E330
        public void set_reverb(){} // RVA: 0x7AEE8E380
        public void get_reverbDelay(){} // RVA: 0x7AEE8E3E0
        public void set_reverbDelay(){} // RVA: 0x7AEE8E430
        public void get_HFReference(){} // RVA: 0x7AEE8E490
        public void set_HFReference(){} // RVA: 0x7AEE8E4E0
        public void get_LFReference(){} // RVA: 0x7AEE8E540
        public void set_LFReference(){} // RVA: 0x7AEE8E590
        public void get_roomRolloffFactor(){} // RVA: 0x7AEE8E5F0
        public void set_roomRolloffFactor(){} // RVA: 0x7AEE8E660
        public void get_diffusion(){} // RVA: 0x7AEE8E6C0
        public void set_diffusion(){} // RVA: 0x7AEE8E710
        public void get_density(){} // RVA: 0x7AEE8E770
        public void set_density(){} // RVA: 0x7AEE8E7C0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioSettings : Object
    {
        // ── Methods ──
        public void GetSpeakerMode(){} // RVA: 0x7AEE89C90
        public void SetConfiguration(){} // RVA: 0x7AEE89CE0
        public void GetSampleRate(){} // RVA: 0x7AE0450E0
        public void get_driverCapabilities(){} // RVA: 0x7AEE89D30
        public void get_speakerMode(){} // RVA: 0x7AEE89C90
        public void get_dspTime(){} // RVA: 0x7AEE89D80
        public void get_outputSampleRate(){} // RVA: 0x7AE0450E0
        public void GetDSPBufferSize(){} // RVA: 0x7AEE89DD0
        public void GetConfiguration(){} // RVA: 0x7AEE89E30
        public void Reset(){} // RVA: 0x7AEE89E90
        public void add_OnAudioConfigurationChanged(){} // RVA: 0x7AEE89EF0
        public void remove_OnAudioConfigurationChanged(){} // RVA: 0x7AEE8A000
        public void InvokeOnAudioConfigurationChanged(){} // RVA: 0x7AEE8A110
        public void InvokeOnAudioSystemShuttingDown(){} // RVA: 0x7AEE8A170
        public void InvokeOnAudioSystemStartedUp(){} // RVA: 0x7AEE8A1D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void SetConfiguration_Injected(){} // RVA: 0x7AEE8A230
        public void GetConfiguration_Injected(){} // RVA: 0x7AEE8A280
    }

    public class AudioSettings[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AudioSource : AudioBehaviour
    {
        // ── Methods ──
        public void GetPitch(){} // RVA: 0x7AEE8B770
        public void SetPitch(){} // RVA: 0x7AEE8B7C0
        public void PlayHelper(){} // RVA: 0x7AEE8B820
        public void Play(){} // RVA: 0x7AEE8B820
        public void PlayOneShotHelper(){} // RVA: 0x7AEE8B8E0
        public void Stop(){} // RVA: 0x7AEE8C290
        public void SetCustomCurveHelper(){} // RVA: 0x7AEE8B9B0
        public void GetCustomCurveHelper(){} // RVA: 0x7AEE8BA20
        public void GetOutputDataHelper(){} // RVA: 0x7AEE8BA80
        public void GetSpectrumDataHelper(){} // RVA: 0x7AEE8BAF0
        public void get_volume(){} // RVA: 0x7AEE8BB70
        public void set_volume(){} // RVA: 0x7AEE8BBC0
        public void get_pitch(){} // RVA: 0x7AEE8B770
        public void set_pitch(){} // RVA: 0x7AEE8B7C0
        public void get_time(){} // RVA: 0x7AEE8BC20
        public void set_time(){} // RVA: 0x7AEE8BC70
        public void get_timeSamples(){} // RVA: 0x7AEE8BCD0
        public void set_timeSamples(){} // RVA: 0x7AEE8BD20
        public void get_clip(){} // RVA: 0x7AEE8BD80
        public void set_clip(){} // RVA: 0x7AEE8BDD0
        public void get_outputAudioMixerGroup(){} // RVA: 0x7AEE8BE30
        public void set_outputAudioMixerGroup(){} // RVA: 0x7AEE8BE80
        public void PlayDelayed(){} // RVA: 0x7AEE8BF40
        public void PlayScheduled(){} // RVA: 0x7AEE8BFC0
        public void PlayOneShot(){} // RVA: 0x7AEE8C050
        public void SetScheduledStartTime(){} // RVA: 0x7AEE8C1D0
        public void SetScheduledEndTime(){} // RVA: 0x7AEE8C230
        public void Pause(){} // RVA: 0x7AEE8C2F0
        public void UnPause(){} // RVA: 0x7AEE8C340
        public void get_isPlaying(){} // RVA: 0x7AEE8C390
        public void get_isVirtual(){} // RVA: 0x7AEE8C3E0
        public void PlayClipAtPoint(){} // RVA: 0x7AEE8C460
        public void get_loop(){} // RVA: 0x7AEE8C940
        public void set_loop(){} // RVA: 0x7AEE8C990
        public void get_ignoreListenerVolume(){} // RVA: 0x7AEE8C9F0
        public void set_ignoreListenerVolume(){} // RVA: 0x7AEE8CA40
        public void get_playOnAwake(){} // RVA: 0x7AEE8CAA0
        public void set_playOnAwake(){} // RVA: 0x7AEE8CAF0
        public void get_ignoreListenerPause(){} // RVA: 0x7AEE8CB50
        public void set_ignoreListenerPause(){} // RVA: 0x7AEE8CBA0
        public void get_velocityUpdateMode(){} // RVA: 0x7AEE8CC00
        public void set_velocityUpdateMode(){} // RVA: 0x7AEE8CC50
        public void get_panStereo(){} // RVA: 0x7AEE8CCB0
        public void set_panStereo(){} // RVA: 0x7AEE8CD00
        public void get_spatialBlend(){} // RVA: 0x7AEE8CD60
        public void set_spatialBlend(){} // RVA: 0x7AEE8CDB0
        public void get_spatialize(){} // RVA: 0x7AEE8CE10
        public void set_spatialize(){} // RVA: 0x7AEE8CE60
        public void get_spatializePostEffects(){} // RVA: 0x7AEE8CEC0
        public void set_spatializePostEffects(){} // RVA: 0x7AEE8CF10
        public void SetCustomCurve(){} // RVA: 0x7AEE8B9B0
        public void GetCustomCurve(){} // RVA: 0x7AEE8BA20
        public void get_reverbZoneMix(){} // RVA: 0x7AEE8CF70
        public void set_reverbZoneMix(){} // RVA: 0x7AEE8CFC0
        public void get_bypassEffects(){} // RVA: 0x7AEE8D020
        public void set_bypassEffects(){} // RVA: 0x7AEE8D070
        public void get_bypassListenerEffects(){} // RVA: 0x7AEE8D0D0
        public void set_bypassListenerEffects(){} // RVA: 0x7AEE8D120
        public void get_bypassReverbZones(){} // RVA: 0x7AEE8D180
        public void set_bypassReverbZones(){} // RVA: 0x7AEE8D1D0
        public void get_dopplerLevel(){} // RVA: 0x7AEE8D230
        public void set_dopplerLevel(){} // RVA: 0x7AEE8D280
        public void get_spread(){} // RVA: 0x7AEE8D2E0
        public void set_spread(){} // RVA: 0x7AEE8D330
        public void get_priority(){} // RVA: 0x7AEE8D390
        public void set_priority(){} // RVA: 0x7AEE8D3E0
        public void get_mute(){} // RVA: 0x7AEE8D440
        public void set_mute(){} // RVA: 0x7AEE8D490
        public void get_minDistance(){} // RVA: 0x7AEE8D4F0
        public void set_minDistance(){} // RVA: 0x7AEE8D540
        public void get_maxDistance(){} // RVA: 0x7AEE8D5A0
        public void set_maxDistance(){} // RVA: 0x7AEE8D5F0
        public void get_rolloffMode(){} // RVA: 0x7AEE8D650
        public void set_rolloffMode(){} // RVA: 0x7AEE8D6A0
        public void GetOutputData(){} // RVA: 0x7AEE8D770
        public void GetSpectrumData(){} // RVA: 0x7AEE8D810
        public void get_minVolume(){} // RVA: 0x7AEE8D820
        public void set_minVolume(){} // RVA: 0x7AEE8D890
        public void get_maxVolume(){} // RVA: 0x7AEE8D8F0
        public void set_maxVolume(){} // RVA: 0x7AEE8D960
        public void get_rolloffFactor(){} // RVA: 0x7AEE8D9C0
        public void set_rolloffFactor(){} // RVA: 0x7AEE8DA30
        public void SetSpatializerFloat(){} // RVA: 0x7AEE8DA90
        public void GetSpatializerFloat(){} // RVA: 0x7AEE8DB00
        public void GetAmbisonicDecoderFloat(){} // RVA: 0x7AEE8DB70
        public void SetAmbisonicDecoderFloat(){} // RVA: 0x7AEE8DBE0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AudioSource[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Avatar : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE76EB0
        public void get_isValid(){} // RVA: 0x7AEE76F00
        public void get_isHuman(){} // RVA: 0x7AEE76F50
        public void get_humanDescription(){} // RVA: 0x7AEE76FA0
        public void GetAxisLength(){} // RVA: 0x7AEE77020
        public void GetPostRotation(){} // RVA: 0x7AEE770C0
        public void Internal_GetAxisLength(){} // RVA: 0x7AEE77190
        public void Internal_GetPostRotation(){} // RVA: 0x7AEE771F0
        public void get_humanDescription_Injected(){} // RVA: 0x7AEE77270
        public void Internal_GetPostRotation_Injected(){} // RVA: 0x7AEE772D0
    }

    public class AvatarBuilder : Object
    {
        // ── Methods ──
        public void BuildHumanAvatar(){} // RVA: 0x7AEE77380
        public void BuildHumanAvatarInternal(){} // RVA: 0x7AEE774F0
        public void BuildGenericAvatar(){} // RVA: 0x7AEE77550
        public void .ctor(){} // RVA: 0x7A80D7310
        public void BuildHumanAvatarInternal_Injected(){} // RVA: 0x7AEE775B0
    }

    public class AvatarMask : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE77610
        public void Internal_Create(){} // RVA: 0x7AEE776A0
        public void GetHumanoidBodyPartActive(){} // RVA: 0x7AEE776F0
        public void SetHumanoidBodyPartActive(){} // RVA: 0x7AEE77750
        public void get_transformCount(){} // RVA: 0x7AEE777C0
        public void set_transformCount(){} // RVA: 0x7AEE77810
        public void AddTransformPath(){} // RVA: 0x7AEE778E0
        public void RemoveTransformPath(){} // RVA: 0x7AEE779C0
        public void GetTransformPath(){} // RVA: 0x7AEE77A30
        public void SetTransformPath(){} // RVA: 0x7AEE77A90
        public void GetTransformWeight(){} // RVA: 0x7AEE77B00
        public void SetTransformWeight(){} // RVA: 0x7AEE77B60
        public void GetTransformActive(){} // RVA: 0x7AEE77BD0
        public void SetTransformActive(){} // RVA: 0x7AEE77C40
    }

    public class AvatarMaskBodyPart[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AvatarMask[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Avatar[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}