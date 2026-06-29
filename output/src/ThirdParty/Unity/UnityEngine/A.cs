// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 93
// Methods: 2139

namespace ThirdParty.Unity.UnityEngine
{
    public class AddComponentMenu : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class AnchoredJoint2D : Joint2D
    {
        // ── Methods ──
        public void get_anchor(){} // RVA: 0x7D0C6B0
        public void set_anchor(){} // RVA: 0x7D0C760
        public void get_connectedAnchor(){} // RVA: 0x7D0C810
        public void set_connectedAnchor(){} // RVA: 0x7D0C8C0
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7D0C970
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7D0CA10
        public void .ctor(){} // RVA: 0xB43D60
        public void get_anchor_Injected(){} // RVA: 0x7D0CAC0
        public void set_anchor_Injected(){} // RVA: 0x7D0CB20
        public void get_connectedAnchor_Injected(){} // RVA: 0x7D0CB80
        public void set_connectedAnchor_Injected(){} // RVA: 0x7D0CBE0
        public void get_autoConfigureConnectedAnchor_Injected(){} // RVA: 0x7D0CC40
        public void set_autoConfigureConnectedAnchor_Injected(){} // RVA: 0x7D0CC90
    }

    public class AndroidJNI : Object
    {
        // ── Methods ──
        public void ReleaseStringChars(){} // RVA: 0x7AF28C0
        public void InvokeAction(){} // RVA: 0x774F030
        public void FindClass(){} // RVA: 0x7AF2910
        public void FromReflectedMethod(){} // RVA: 0x7AF2A50
        public void ExceptionOccurred(){} // RVA: 0x7AF2AA0
        public void ExceptionClear(){} // RVA: 0x7AF2AF0
        public void PushLocalFrame(){} // RVA: 0x7AF2B40
        public void PopLocalFrame(){} // RVA: 0x7AF2B90
        public void NewGlobalRef(){} // RVA: 0x7AF2BE0
        public void QueueDeleteGlobalRef(){} // RVA: 0x7AF2C30
        public void NewWeakGlobalRef(){} // RVA: 0x7AF2C80
        public void DeleteWeakGlobalRef(){} // RVA: 0x7AF2CD0
        public void NewLocalRef(){} // RVA: 0x7AF2D20
        public void DeleteLocalRef(){} // RVA: 0x7AF2D70
        public void IsSameObject(){} // RVA: 0x7AF2DC0
        public void NewObject(){} // RVA: 0x7AF2E20
        public void NewObjectA(){} // RVA: 0x7AF2EC0
        public void GetObjectClass(){} // RVA: 0x7AF2F30
        public void GetMethodID(){} // RVA: 0x7AF2F80
        public void GetFieldID(){} // RVA: 0x7AF3190
        public void GetStaticMethodID(){} // RVA: 0x7AF33A0
        public void GetStaticFieldID(){} // RVA: 0x7AF35B0
        public void NewString(){} // RVA: 0x7AF37C0
        public void NewStringFromStr(){} // RVA: 0x7AF37D0
        public void GetStringChars(){} // RVA: 0x7AF3910
        public void GetStringCharsInternal(){} // RVA: 0x7AF3A90
        public void CallStringMethod(){} // RVA: 0x7AF3BB0
        public void CallStringMethodUnsafe(){} // RVA: 0x7AF3C20
        public void CallStringMethodUnsafeInternal(){} // RVA: 0x7AF3D60
        public void CallObjectMethod(){} // RVA: 0x7AF3DF0
        public void CallObjectMethodUnsafe(){} // RVA: 0x7AF3E90
        public void CallIntMethod(){} // RVA: 0x7AF4000
        public void CallIntMethodUnsafe(){} // RVA: 0x7AF40A0
        public void CallBooleanMethod(){} // RVA: 0x7AF4110
        public void CallBooleanMethodUnsafe(){} // RVA: 0x7AF41B0
        public void CallShortMethod(){} // RVA: 0x7AF4220
        public void CallShortMethodUnsafe(){} // RVA: 0x7AF42C0
        public void CallSByteMethod(){} // RVA: 0x7AF4330
        public void CallSByteMethodUnsafe(){} // RVA: 0x7AF43D0
        public void CallCharMethod(){} // RVA: 0x7AF4440
        public void CallCharMethodUnsafe(){} // RVA: 0x7AF44E0
        public void CallFloatMethod(){} // RVA: 0x7AF4550
        public void CallFloatMethodUnsafe(){} // RVA: 0x7AF45F0
        public void CallDoubleMethod(){} // RVA: 0x7AF4660
        public void CallDoubleMethodUnsafe(){} // RVA: 0x7AF4700
        public void CallLongMethod(){} // RVA: 0x7AF4770
        public void CallLongMethodUnsafe(){} // RVA: 0x7AF4810
        public void CallVoidMethod(){} // RVA: 0x7AF4880
        public void CallVoidMethodUnsafe(){} // RVA: 0x7AF4920
        public void GetStringField(){} // RVA: 0x7AF4990
        public void GetStringFieldInternal(){} // RVA: 0x7AF4AC0
        public void GetObjectField(){} // RVA: 0x7AF4B40
        public void GetBooleanField(){} // RVA: 0x7AF4BA0
        public void GetSByteField(){} // RVA: 0x7AF4C00
        public void GetCharField(){} // RVA: 0x7AF4C60
        public void GetShortField(){} // RVA: 0x7AF4CC0
        public void GetIntField(){} // RVA: 0x7AF4D20
        public void GetLongField(){} // RVA: 0x7AF4D80
        public void GetFloatField(){} // RVA: 0x7AF4DE0
        public void GetDoubleField(){} // RVA: 0x7AF4E40
        public void CallStaticStringMethod(){} // RVA: 0x7AF4F50
        public void CallStaticStringMethodUnsafe(){} // RVA: 0x7AF4FC0
        public void CallStaticStringMethodUnsafeInternal(){} // RVA: 0x7AF5100
        public void CallStaticObjectMethod(){} // RVA: 0x7AF5190
        public void CallStaticObjectMethodUnsafe(){} // RVA: 0x7AF5230
        public void CallStaticIntMethod(){} // RVA: 0x7AF52A0
        public void CallStaticIntMethodUnsafe(){} // RVA: 0x7AF5340
        public void CallStaticBooleanMethod(){} // RVA: 0x7AF53B0
        public void CallStaticBooleanMethodUnsafe(){} // RVA: 0x7AF5450
        public void CallStaticShortMethod(){} // RVA: 0x7AF54C0
        public void CallStaticShortMethodUnsafe(){} // RVA: 0x7AF5560
        public void CallStaticSByteMethod(){} // RVA: 0x7AF55D0
        public void CallStaticSByteMethodUnsafe(){} // RVA: 0x7AF5670
        public void CallStaticCharMethod(){} // RVA: 0x7AF56E0
        public void CallStaticCharMethodUnsafe(){} // RVA: 0x7AF5780
        public void CallStaticFloatMethod(){} // RVA: 0x7AF57F0
        public void CallStaticFloatMethodUnsafe(){} // RVA: 0x7AF5890
        public void CallStaticDoubleMethod(){} // RVA: 0x7AF5900
        public void CallStaticDoubleMethodUnsafe(){} // RVA: 0x7AF59A0
        public void CallStaticLongMethod(){} // RVA: 0x7AF5A10
        public void CallStaticLongMethodUnsafe(){} // RVA: 0x7AF5AB0
        public void GetStaticStringField(){} // RVA: 0x7AF5B20
        public void GetStaticStringFieldInternal(){} // RVA: 0x7AF5C50
        public void GetStaticObjectField(){} // RVA: 0x7AF5CD0
        public void GetStaticBooleanField(){} // RVA: 0x7AF5D30
        public void GetStaticSByteField(){} // RVA: 0x7AF5D90
        public void GetStaticCharField(){} // RVA: 0x7AF5DF0
        public void GetStaticShortField(){} // RVA: 0x7AF5E50
        public void GetStaticIntField(){} // RVA: 0x7AF5EB0
        public void GetStaticLongField(){} // RVA: 0x7AF5F10
        public void GetStaticFloatField(){} // RVA: 0x7AF5F70
        public void GetStaticDoubleField(){} // RVA: 0x7AF5FD0
        public void ConvertToBooleanArray(){} // RVA: 0x7AF6030
        public void ToBooleanArray(){} // RVA: 0x7AF6100
        public void ToByteArray(){} // RVA: 0x7AF61C0
        public void ToSByteArray(){} // RVA: 0x7AF6320
        public void ToCharArray(){} // RVA: 0x7AF6410
        public void ToShortArray(){} // RVA: 0x7AF6500
        public void ToIntArray(){} // RVA: 0x7AF65F0
        public void ToLongArray(){} // RVA: 0x7AF66E0
        public void ToFloatArray(){} // RVA: 0x7AF67D0
        public void ToDoubleArray(){} // RVA: 0x7AF68C0
        public void ToObjectArray(){} // RVA: 0x7AF6990
        public void FromBooleanArray(){} // RVA: 0x7AF6A30
        public void FromByteArray(){} // RVA: 0x7AF6C70
        public void FromSByteArray(){} // RVA: 0x7AF6D70
        public void FromCharArray(){} // RVA: 0x7AF6DC0
        public void FromShortArray(){} // RVA: 0x7AF6E10
        public void FromIntArray(){} // RVA: 0x7AF6E60
        public void FromLongArray(){} // RVA: 0x7AF6EB0
        public void FromFloatArray(){} // RVA: 0x7AF6F00
        public void FromDoubleArray(){} // RVA: 0x7AF6F50
        public void GetArrayLength(){} // RVA: 0x7AF6FA0
        public void NewFloatArray(){} // RVA: 0x7AF6FF0
        public void NewObjectArray(){} // RVA: 0x7AF7040
        public void GetObjectArrayElement(){} // RVA: 0x7AF70B0
        public void SetObjectArrayElement(){} // RVA: 0x7AF7110
        public void ReleaseStringChars_Injected(){} // RVA: 0x7AF7180
        public void FindClass_Injected(){} // RVA: 0x7AF71D0
        public void GetMethodID_Injected(){} // RVA: 0x7AF7220
        public void GetFieldID_Injected(){} // RVA: 0x7AF7290
        public void GetStaticMethodID_Injected(){} // RVA: 0x7AF7300
        public void GetStaticFieldID_Injected(){} // RVA: 0x7AF7370
        public void NewStringFromStr_Injected(){} // RVA: 0x7AF73E0
        public void GetStringCharsInternal_Injected(){} // RVA: 0x7AF7430
        public void CallStringMethodUnsafeInternal_Injected(){} // RVA: 0x7AF7490
        public void GetStringFieldInternal_Injected(){} // RVA: 0x7AF7510
        public void CallStaticStringMethodUnsafeInternal_Injected(){} // RVA: 0x7AF7580
        public void GetStaticStringFieldInternal_Injected(){} // RVA: 0x7AF7600
        public void ConvertToBooleanArray_Injected(){} // RVA: 0x7AF7670
        public void ToByteArray_Injected(){} // RVA: 0x7AF76C0
        public void FromBooleanArray_Injected(){} // RVA: 0x7AF7710
        public void FromByteArray_Injected(){} // RVA: 0x7AF7770
    }

    public class AndroidJNIHelper : Object
    {
        // ── Methods ──
        public void GetConstructorID(){} // RVA: 0x7AF2520
        public void GetMethodID(){} // RVA: 0xA94080
        public void GetFieldID(){} // RVA: 0xA94080
        public void CreateJavaRunnable(){} // RVA: 0x7AF1E50
        public void CreateJavaProxy(){} // RVA: 0x7AF1F80
        public void CreateJNIArgArray(){} // RVA: 0x7AF2210
        public void DeleteJNIArgArray(){} // RVA: 0x7AF2360
        public void ConvertFromJNIArray(){} // RVA: 0xA94080
        public void Box(){} // RVA: 0x7AF2850
    }

    public class AndroidJNIHelper[] : Array
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

    public class AndroidJNISafe : Object
    {
        // ── Methods ──
        public void CheckException(){} // RVA: 0x7AF7890
        public void QueueDeleteGlobalRef(){} // RVA: 0x7AF7BD0
        public void DeleteWeakGlobalRef(){} // RVA: 0x7AF7C30
        public void DeleteLocalRef(){} // RVA: 0x7AF7C90
        public void NewString(){} // RVA: 0x7AF7CF0
        public void GetStringChars(){} // RVA: 0x7AF7D40
        public void GetObjectClass(){} // RVA: 0x7AF7D90
        public void GetStaticMethodID(){} // RVA: 0x7AF7E20
        public void GetMethodID(){} // RVA: 0x7AF7E70
        public void GetFieldID(){} // RVA: 0x7AF7EC0
        public void GetStaticFieldID(){} // RVA: 0x7AF7F10
        public void FromReflectedMethod(){} // RVA: 0x7AF7F60
        public void FindClass(){} // RVA: 0x7AF7FF0
        public void PushLocalFrame(){} // RVA: 0x7AF8040
        public void NewObject(){} // RVA: 0x7AF80A0
        public void GetStaticObjectField(){} // RVA: 0x7AF8190
        public void GetStaticStringField(){} // RVA: 0x7AF8230
        public void GetStaticCharField(){} // RVA: 0x7AF8280
        public void GetStaticDoubleField(){} // RVA: 0x7AF8320
        public void GetStaticFloatField(){} // RVA: 0x7AF83D0
        public void GetStaticLongField(){} // RVA: 0x7AF8480
        public void GetStaticShortField(){} // RVA: 0x7AF8520
        public void GetStaticSByteField(){} // RVA: 0x7AF85C0
        public void GetStaticBooleanField(){} // RVA: 0x7AF8660
        public void GetStaticIntField(){} // RVA: 0x7AF8700
        public void CallStaticObjectMethod(){} // RVA: 0x7AF8830
        public void CallStaticStringMethod(){} // RVA: 0x7AF89B0
        public void CallStaticCharMethod(){} // RVA: 0x7AF8AB0
        public void CallStaticDoubleMethod(){} // RVA: 0x7AF8BA0
        public void CallStaticFloatMethod(){} // RVA: 0x7AF8CA0
        public void CallStaticLongMethod(){} // RVA: 0x7AF8DA0
        public void CallStaticShortMethod(){} // RVA: 0x7AF8E90
        public void CallStaticSByteMethod(){} // RVA: 0x7AF8F80
        public void CallStaticBooleanMethod(){} // RVA: 0x7AF9070
        public void CallStaticIntMethod(){} // RVA: 0x7AF9160
        public void GetObjectField(){} // RVA: 0x7AF9250
        public void GetStringField(){} // RVA: 0x7AF92F0
        public void GetCharField(){} // RVA: 0x7AF9340
        public void GetDoubleField(){} // RVA: 0x7AF93E0
        public void GetFloatField(){} // RVA: 0x7AF9490
        public void GetLongField(){} // RVA: 0x7AF9540
        public void GetShortField(){} // RVA: 0x7AF95E0
        public void GetSByteField(){} // RVA: 0x7AF9680
        public void GetBooleanField(){} // RVA: 0x7AF9720
        public void GetIntField(){} // RVA: 0x7AF97C0
        public void CallVoidMethod(){} // RVA: 0x7AF9860
        public void CallObjectMethod(){} // RVA: 0x7AF99D0
        public void CallStringMethod(){} // RVA: 0x7AF9AC0
        public void CallCharMethod(){} // RVA: 0x7AF9BC0
        public void CallDoubleMethod(){} // RVA: 0x7AF9CB0
        public void CallFloatMethod(){} // RVA: 0x7AF9DB0
        public void CallLongMethod(){} // RVA: 0x7AF9EB0
        public void CallShortMethod(){} // RVA: 0x7AF9FA0
        public void CallSByteMethod(){} // RVA: 0x7AFA090
        public void CallBooleanMethod(){} // RVA: 0x7AFA180
        public void CallIntMethod(){} // RVA: 0x7AFA270
        public void FromCharArray(){} // RVA: 0x7AFA360
        public void FromDoubleArray(){} // RVA: 0x7AFA3F0
        public void FromFloatArray(){} // RVA: 0x7AFA480
        public void FromLongArray(){} // RVA: 0x7AFA510
        public void FromShortArray(){} // RVA: 0x7AFA5A0
        public void FromByteArray(){} // RVA: 0x7AFA630
        public void FromSByteArray(){} // RVA: 0x7AFA680
        public void FromBooleanArray(){} // RVA: 0x7AFA710
        public void FromIntArray(){} // RVA: 0x7AFA760
        public void ToObjectArray(){} // RVA: 0x7AFA7F0
        public void ToCharArray(){} // RVA: 0x7AFA8B0
        public void ToDoubleArray(){} // RVA: 0x7AFA960
        public void ToFloatArray(){} // RVA: 0x7AFAA10
        public void ToLongArray(){} // RVA: 0x7AFAAC0
        public void ToShortArray(){} // RVA: 0x7AFAB70
        public void ToByteArray(){} // RVA: 0x7AFAC20
        public void ToSByteArray(){} // RVA: 0x7AFAD30
        public void ToBooleanArray(){} // RVA: 0x7AFADE0
        public void ToIntArray(){} // RVA: 0x7AFAEE0
        public void GetObjectArrayElement(){} // RVA: 0x7AFAF90
        public void GetArrayLength(){} // RVA: 0x7AFB030
    }

    public class AndroidJNI[] : Array
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

    public class AndroidJavaClass : AndroidJavaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAFC0
        public void _AndroidJavaClass(){} // RVA: 0x7AEAE00
    }

    public class AndroidJavaException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE82D0
        public void get_StackTrace(){} // RVA: 0x7AE83A0
    }

    public class AndroidJavaObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0x7AEA990
        public void Call(){} // RVA: 0xA94080
        public void Get(){} // RVA: 0xA94080
        public void GetStatic(){} // RVA: 0xA94080
        public void GetRawObject(){} // RVA: 0x7AEA080
        public void GetRawClass(){} // RVA: 0x6AE0A90
        public void CloneReference(){} // RVA: 0x7AEA0A0
        public void CallStatic(){} // RVA: 0xA94080
        public void DebugPrint(){} // RVA: 0x7AEA2C0
        public void _AndroidJavaObject(){} // RVA: 0x7AEA590
        public void Finalize(){} // RVA: 0x6527310
        public void _Call(){} // RVA: 0xA94080
        public void _Get(){} // RVA: 0xA94080
        public void _CallStatic(){} // RVA: 0xA94080
        public void _GetStatic(){} // RVA: 0xA94080
        public void AndroidJavaObjectDeleteLocalRef(){} // RVA: 0x7AEAC90
        public void AndroidJavaClassDeleteLocalRef(){} // RVA: 0x7AEAD40
        public void FromJavaArrayDeleteLocalRef(){} // RVA: 0xA94080
        public void FromJavaArray(){} // RVA: 0xA94080
        public void _GetRawObject(){} // RVA: 0x7AEA080
        public void _GetRawClass(){} // RVA: 0x6AE0A90
    }

    public class AndroidJavaProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8790
        public void Finalize(){} // RVA: 0x7AE87F0
        public void Invoke(){} // RVA: 0x7AE94B0
        public void equals(){} // RVA: 0x7AE98D0
        public void hashCode(){} // RVA: 0x7AE9950
        public void toString(){} // RVA: 0x7AE9A40
        public void GetProxyObject(){} // RVA: 0x7AE9AA0
        public void GetRawProxy(){} // RVA: 0x7AE9AC0
        public void .cctor(){} // RVA: 0x7AE9BD0
    }

    public class AndroidJavaRunnable : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class AndroidJavaRunnableProxy : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE8500
        public void run(){} // RVA: 0x7AE85C0
        public void Invoke(){} // RVA: 0x7AE85F0
    }

    public class AndroidReflection : Object
    {
        // ── Methods ──
        public void IsPrimitive(){} // RVA: 0x6A54B70
        public void IsAssignableFrom(){} // RVA: 0x7AEB130
        public void GetStaticMethodID(){} // RVA: 0x7AEB160
        public void GetMethodID(){} // RVA: 0x7AEB200
        public void GetConstructorMember(){} // RVA: 0x7AEB2A0
        public void GetMethodMember(){} // RVA: 0x7AEB4F0
        public void GetFieldMember(){} // RVA: 0x7AEB800
        public void GetFieldClass(){} // RVA: 0x7AEBA30
        public void GetFieldSignature(){} // RVA: 0x7AEBAD0
        public void NewProxyInstance(){} // RVA: 0x7AEBBF0
        public void CreateInvocationError(){} // RVA: 0x7AEBD40
        public void .cctor(){} // RVA: 0x7AEBE90
    }

    public class Animation : Behaviour
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x7AFC670
        public void set_clip(){} // RVA: 0x7AFC730
        public void get_playAutomatically(){} // RVA: 0x7AFC810
        public void set_playAutomatically(){} // RVA: 0x7AFC8B0
        public void get_wrapMode(){} // RVA: 0x7AFC960
        public void set_wrapMode(){} // RVA: 0x7AFCA00
        public void Stop(){} // RVA: 0x7AFCB50
        public void StopNamed(){} // RVA: 0x7AFCB60
        public void Rewind(){} // RVA: 0x7AFCD90
        public void RewindNamed(){} // RVA: 0x7AFCDA0
        public void Sample(){} // RVA: 0x7AFCF30
        public void get_isPlaying(){} // RVA: 0x7AFCFD0
        public void IsPlaying(){} // RVA: 0x7AFD070
        public void get_Item(){} // RVA: 0x7AFD200
        public void Play(){} // RVA: 0x7AFE330
        public void PlayDefaultAnimation(){} // RVA: 0x7AFD2C0
        public void CrossFade(){} // RVA: 0x7AFD570
        public void Blend(){} // RVA: 0x7AFD770
        public void CrossFadeQueued(){} // RVA: 0x7AFD9A0
        public void PlayQueued(){} // RVA: 0x7AFDBB0
        public void AddClip(){} // RVA: 0x7AFDDC0
        public void RemoveClip(){} // RVA: 0x7AFE0F0
        public void RemoveClipNamed(){} // RVA: 0x7AFE100
        public void GetClipCount(){} // RVA: 0x7AFE290
        public void SyncLayer(){} // RVA: 0x7AFE340
        public void GetEnumerator(){} // RVA: 0x7AFE3F0
        public void GetState(){} // RVA: 0x7AFE490
        public void GetStateAtIndex(){} // RVA: 0x7AFE620
        public void GetStateCount(){} // RVA: 0x7AFE6D0
        public void GetClip(){} // RVA: 0x7AFE770
        public void get_animatePhysics(){} // RVA: 0x7AFE7A0
        public void set_animatePhysics(){} // RVA: 0x7AFE840
        public void get_updateMode(){} // RVA: 0x7AFE8F0
        public void set_updateMode(){} // RVA: 0x7AFE990
        public void get_animateOnlyIfVisible(){} // RVA: 0x7AFEA40
        public void set_animateOnlyIfVisible(){} // RVA: 0x7AFEAE0
        public void get_cullingType(){} // RVA: 0x7AFEB90
        public void set_cullingType(){} // RVA: 0x7AFEC30
        public void get_localBounds(){} // RVA: 0x7AFECE0
        public void set_localBounds(){} // RVA: 0x7AFEDA0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_clip_Injected(){} // RVA: 0x7AFEE50
        public void set_clip_Injected(){} // RVA: 0x7AFEEA0
        public void get_playAutomatically_Injected(){} // RVA: 0x7AFEF00
        public void set_playAutomatically_Injected(){} // RVA: 0x7AFEF50
        public void get_wrapMode_Injected(){} // RVA: 0x7AFEFB0
        public void set_wrapMode_Injected(){} // RVA: 0x7AFF000
        public void Stop_Injected(){} // RVA: 0x7AFF060
        public void StopNamed_Injected(){} // RVA: 0x7AFF0B0
        public void Rewind_Injected(){} // RVA: 0x7AFF110
        public void RewindNamed_Injected(){} // RVA: 0x7AFF160
        public void Sample_Injected(){} // RVA: 0x7AFF1C0
        public void get_isPlaying_Injected(){} // RVA: 0x7AFF210
        public void IsPlaying_Injected(){} // RVA: 0x7AFF260
        public void PlayDefaultAnimation_Injected(){} // RVA: 0x7AFF2C0
        public void Play_Injected(){} // RVA: 0x7AFF320
        public void CrossFade_Injected(){} // RVA: 0x7AFF390
        public void Blend_Injected(){} // RVA: 0x7AFF410
        public void CrossFadeQueued_Injected(){} // RVA: 0x7AFF490
        public void PlayQueued_Injected(){} // RVA: 0x7AFF520
        public void AddClip_Injected(){} // RVA: 0x7AFF5A0
        public void RemoveClip_Injected(){} // RVA: 0x7AFF630
        public void RemoveClipNamed_Injected(){} // RVA: 0x7AFF690
        public void GetClipCount_Injected(){} // RVA: 0x7AFF6F0
        public void SyncLayer_Injected(){} // RVA: 0x7AFF740
        public void GetState_Injected(){} // RVA: 0x7AFF7A0
        public void GetStateAtIndex_Injected(){} // RVA: 0x7AFF800
        public void GetStateCount_Injected(){} // RVA: 0x7AFF860
        public void get_animatePhysics_Injected(){} // RVA: 0x7AFF8B0
        public void set_animatePhysics_Injected(){} // RVA: 0x7AFF900
        public void get_updateMode_Injected(){} // RVA: 0x7AFF960
        public void set_updateMode_Injected(){} // RVA: 0x7AFF9B0
        public void get_animateOnlyIfVisible_Injected(){} // RVA: 0x7AFFA10
        public void set_animateOnlyIfVisible_Injected(){} // RVA: 0x7AFFA60
        public void get_cullingType_Injected(){} // RVA: 0x7AFFAC0
        public void set_cullingType_Injected(){} // RVA: 0x7AFFB10
        public void get_localBounds_Injected(){} // RVA: 0x7AFFB70
        public void set_localBounds_Injected(){} // RVA: 0x7AFFBD0
    }

    public class AnimationClip : Motion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B023B0
        public void Internal_CreateAnimationClip(){} // RVA: 0x7B02440
        public void SampleAnimation(){} // RVA: 0x7B02660
        public void get_length(){} // RVA: 0x7B027B0
        public void get_frameRate(){} // RVA: 0x7B02850
        public void set_frameRate(){} // RVA: 0x7B028F0
        public void SetCurve(){} // RVA: 0x7B029A0
        public void EnsureQuaternionContinuity(){} // RVA: 0x7B02C60
        public void ClearCurves(){} // RVA: 0x7B02D00
        public void get_wrapMode(){} // RVA: 0x7B02DA0
        public void set_wrapMode(){} // RVA: 0x7B02E40
        public void get_localBounds(){} // RVA: 0x7B02EF0
        public void set_localBounds(){} // RVA: 0x7B02FB0
        public void get_legacy(){} // RVA: 0x7B03060
        public void set_legacy(){} // RVA: 0x7B03100
        public void get_humanMotion(){} // RVA: 0x7B031B0
        public void get_empty(){} // RVA: 0x7B03250
        public void get_hasGenericRootTransform(){} // RVA: 0x7B032F0
        public void get_hasMotionFloatCurves(){} // RVA: 0x7B03390
        public void get_hasMotionCurves(){} // RVA: 0x7B03430
        public void get_hasRootCurves(){} // RVA: 0x7B034D0
        public void get_hasRootMotion(){} // RVA: 0x7B03570
        public void get_events(){} // RVA: 0x7B03610
        public void set_events(){} // RVA: 0x7B038C0
        public void SetEventsInternal(){} // RVA: 0x7B03B00
        public void GetEventsInternal(){} // RVA: 0x7B03BC0
        public void SampleAnimation_Injected(){} // RVA: 0x7B03C80
        public void get_length_Injected(){} // RVA: 0x7B03D00
        public void get_frameRate_Injected(){} // RVA: 0x7B03D50
        public void set_frameRate_Injected(){} // RVA: 0x7B03DA0
        public void SetCurve_Injected(){} // RVA: 0x7B03E00
        public void EnsureQuaternionContinuity_Injected(){} // RVA: 0x7B03E90
        public void ClearCurves_Injected(){} // RVA: 0x7B03EE0
        public void get_wrapMode_Injected(){} // RVA: 0x7B03F30
        public void set_wrapMode_Injected(){} // RVA: 0x7B03F80
        public void get_localBounds_Injected(){} // RVA: 0x7B03FE0
        public void set_localBounds_Injected(){} // RVA: 0x7B04040
        public void get_legacy_Injected(){} // RVA: 0x7B040A0
        public void set_legacy_Injected(){} // RVA: 0x7B040F0
        public void get_humanMotion_Injected(){} // RVA: 0x7B04150
        public void get_empty_Injected(){} // RVA: 0x7B041A0
        public void get_hasGenericRootTransform_Injected(){} // RVA: 0x7B041F0
        public void get_hasMotionFloatCurves_Injected(){} // RVA: 0x7B04240
        public void get_hasMotionCurves_Injected(){} // RVA: 0x7B04290
        public void get_hasRootCurves_Injected(){} // RVA: 0x7B042E0
        public void get_hasRootMotion_Injected(){} // RVA: 0x7B04330
        public void SetEventsInternal_Injected(){} // RVA: 0x7B04380
        public void GetEventsInternal_Injected(){} // RVA: 0x7B043F0
    }

    public class AnimationClip[] : Array
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

    public class AnimationCurve : Object
    {
        // ── Methods ──
        public void Internal_Destroy(){} // RVA: 0x7B51750
        public void Internal_Create(){} // RVA: 0x7B517A0
        public void Internal_Equals(){} // RVA: 0x7B51870
        public void Internal_CopyFrom(){} // RVA: 0x7B518F0
        public void Finalize(){} // RVA: 0x7B51970
        public void Evaluate(){} // RVA: 0x7B51A00
        public void get_keys(){} // RVA: 0x7B51A80
        public void set_keys(){} // RVA: 0x7B51A90
        public void AddKey(){} // RVA: 0x7B51C30
        public void AddKey_Internal(){} // RVA: 0x7B51CC0
        public void MoveKey(){} // RVA: 0x7B51D40
        public void ClearKeys(){} // RVA: 0x7B51DD0
        public void RemoveKey(){} // RVA: 0x7B51E40
        public void get_Item(){} // RVA: 0x7B51EC0
        public void get_length(){} // RVA: 0x7B51F90
        public void SetKeys(){} // RVA: 0x7B51A90
        public void GetKey(){} // RVA: 0x7B52000
        public void GetKeys(){} // RVA: 0x7B520A0
        public void GetHashCode(){} // RVA: 0x7B52310
        public void SmoothTangents(){} // RVA: 0x7B52380
        public void Constant(){} // RVA: 0x7B52410
        public void Linear(){} // RVA: 0x7B52430
        public void EaseInOut(){} // RVA: 0x7B52620
        public void get_preWrapMode(){} // RVA: 0x7B527E0
        public void set_preWrapMode(){} // RVA: 0x7B52850
        public void get_postWrapMode(){} // RVA: 0x7B528D0
        public void set_postWrapMode(){} // RVA: 0x7B52940
        public void .ctor(){} // RVA: 0x7B52A10
        public void Equals(){} // RVA: 0x7B52B20
        public void CopyFrom(){} // RVA: 0x7B52C70
        public void Internal_Create_Injected(){} // RVA: 0x7B52D00
        public void Internal_Equals_Injected(){} // RVA: 0x7B52D50
        public void Internal_CopyFrom_Injected(){} // RVA: 0x7B52DB0
        public void Evaluate_Injected(){} // RVA: 0x7B52E10
        public void AddKey_Injected(){} // RVA: 0x7B52E70
        public void AddKey_Internal_Injected(){} // RVA: 0x7B52EE0
        public void MoveKey_Injected(){} // RVA: 0x7B52F40
        public void ClearKeys_Injected(){} // RVA: 0x7B52FB0
        public void RemoveKey_Injected(){} // RVA: 0x7B53000
        public void get_length_Injected(){} // RVA: 0x7B53060
        public void SetKeys_Injected(){} // RVA: 0x7B530B0
        public void GetKey_Injected(){} // RVA: 0x7B53110
        public void GetKeys_Injected(){} // RVA: 0x7B53180
        public void GetHashCode_Injected(){} // RVA: 0x7B531E0
        public void SmoothTangents_Injected(){} // RVA: 0x7B53230
        public void get_preWrapMode_Injected(){} // RVA: 0x7B532A0
        public void set_preWrapMode_Injected(){} // RVA: 0x7B532F0
        public void get_postWrapMode_Injected(){} // RVA: 0x7B53350
        public void set_postWrapMode_Injected(){} // RVA: 0x7B533A0
    }

    public class AnimationCurve[] : Array
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

    public class AnimationEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B02210
        public void get_stringParameter(){} // RVA: 0x7489A40
        public void get_functionName(){} // RVA: 0x3926770
    }

    public class AnimationEventBlittable : ValueType
    {
        // ── Methods ──
        public void FromAnimationEvents(){} // RVA: 0x7B01420
        public void PointerToAnimationEvent(){} // RVA: 0x7B016A0
        public void PointerToAnimationEvents(){} // RVA: 0x7B01700
        public void DisposeEvents(){} // RVA: 0x7B01860
        public void FreeEventsInternal(){} // RVA: 0x7B018F0
        public void ToAnimationEvent(){} // RVA: 0x7B01940
        public void Dispose(){} // RVA: 0x9596E0
    }

    public class AnimationEventBlittable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80140
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B270
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC53C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35E00
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B270
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AnimationEvent[] : Array
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

    public class AnimationState : TrackedReference
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7AFFDA0
        public void set_enabled(){} // RVA: 0x7AFFE10
        public void get_weight(){} // RVA: 0x7AFFE90
        public void set_weight(){} // RVA: 0x7AFFF00
        public void get_wrapMode(){} // RVA: 0x7AFFF80
        public void set_wrapMode(){} // RVA: 0x7AFFFF0
        public void get_time(){} // RVA: 0x7B00070
        public void set_time(){} // RVA: 0x7B000E0
        public void get_normalizedTime(){} // RVA: 0x7B00160
        public void set_normalizedTime(){} // RVA: 0x7B001D0
        public void get_speed(){} // RVA: 0x7B00250
        public void set_speed(){} // RVA: 0x7B002C0
        public void get_normalizedSpeed(){} // RVA: 0x7B00340
        public void set_normalizedSpeed(){} // RVA: 0x7B003B0
        public void get_length(){} // RVA: 0x7B00430
        public void get_layer(){} // RVA: 0x7B004A0
        public void set_layer(){} // RVA: 0x7B00510
        public void get_clip(){} // RVA: 0x7B00590
        public void get_name(){} // RVA: 0x7B00640
        public void set_name(){} // RVA: 0x7B00730
        public void get_blendMode(){} // RVA: 0x7B008B0
        public void set_blendMode(){} // RVA: 0x7B00920
        public void AddMixingTransform(){} // RVA: 0x7B009B0
        public void RemoveMixingTransform(){} // RVA: 0x7B00AC0
        public void .ctor(){} // RVA: 0xB43310
        public void get_enabled_Injected(){} // RVA: 0x7B00BC0
        public void set_enabled_Injected(){} // RVA: 0x7B00C10
        public void get_weight_Injected(){} // RVA: 0x7B00C70
        public void set_weight_Injected(){} // RVA: 0x7B00CC0
        public void get_wrapMode_Injected(){} // RVA: 0x7B00D20
        public void set_wrapMode_Injected(){} // RVA: 0x7B00D70
        public void get_time_Injected(){} // RVA: 0x7B00DD0
        public void set_time_Injected(){} // RVA: 0x7B00E20
        public void get_normalizedTime_Injected(){} // RVA: 0x7B00E80
        public void set_normalizedTime_Injected(){} // RVA: 0x7B00ED0
        public void get_speed_Injected(){} // RVA: 0x7B00F30
        public void set_speed_Injected(){} // RVA: 0x7B00F80
        public void get_normalizedSpeed_Injected(){} // RVA: 0x7B00FE0
        public void set_normalizedSpeed_Injected(){} // RVA: 0x7B01030
        public void get_length_Injected(){} // RVA: 0x7B01090
        public void get_layer_Injected(){} // RVA: 0x7B010E0
        public void set_layer_Injected(){} // RVA: 0x7B01130
        public void get_clip_Injected(){} // RVA: 0x7B01190
        public void get_name_Injected(){} // RVA: 0x7B011E0
        public void set_name_Injected(){} // RVA: 0x7B01240
        public void get_blendMode_Injected(){} // RVA: 0x7B012A0
        public void set_blendMode_Injected(){} // RVA: 0x7B012F0
        public void AddMixingTransform_Injected(){} // RVA: 0x7B01350
        public void RemoveMixingTransform_Injected(){} // RVA: 0x7B013C0
    }

    public class AnimationState[] : Array
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

    public class Animation[] : Array
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

    public class Animator : Behaviour
    {
        // ── Methods ──
        public void get_isOptimizable(){} // RVA: 0x7B049F0
        public void get_isHuman(){} // RVA: 0x7B04A90
        public void get_hasRootMotion(){} // RVA: 0x7B04B30
        public void get_isRootPositionOrRotationControlledByCurves(){} // RVA: 0x7B04BD0
        public void get_humanScale(){} // RVA: 0x7B04C70
        public void get_isInitialized(){} // RVA: 0x7B04D10
        public void GetFloat(){} // RVA: 0x7B04DC0
        public void SetFloat(){} // RVA: 0x7B04F50
        public void GetBool(){} // RVA: 0x7B05030
        public void SetBool(){} // RVA: 0x7B050F0
        public void GetInteger(){} // RVA: 0x7B051C0
        public void SetInteger(){} // RVA: 0x7B05280
        public void SetTrigger(){} // RVA: 0x7B05350
        public void ResetTrigger(){} // RVA: 0x7B05410
        public void IsParameterControlledByCurve(){} // RVA: 0x7B054D0
        public void get_deltaPosition(){} // RVA: 0x7B05580
        public void get_deltaRotation(){} // RVA: 0x7B05640
        public void get_velocity(){} // RVA: 0x7B05700
        public void get_angularVelocity(){} // RVA: 0x7B057C0
        public void get_rootPosition(){} // RVA: 0x7B05880
        public void set_rootPosition(){} // RVA: 0x7B05940
        public void get_rootRotation(){} // RVA: 0x7B059F0
        public void set_rootRotation(){} // RVA: 0x7B05AB0
        public void get_applyRootMotion(){} // RVA: 0x7B05B60
        public void set_applyRootMotion(){} // RVA: 0x7B05C00
        public void get_noDiscreteIntBindings(){} // RVA: 0x7B05CB0
        public void set_noDiscreteIntBindings(){} // RVA: 0x7B05D50
        public void get_linearVelocityBlending(){} // RVA: 0x7B05E00
        public void set_linearVelocityBlending(){} // RVA: 0x7B05EA0
        public void get_animatePhysics(){} // RVA: 0x7B05F50
        public void set_animatePhysics(){} // RVA: 0x7B05FF0
        public void get_updateMode(){} // RVA: 0x7B060A0
        public void set_updateMode(){} // RVA: 0x7B06140
        public void get_hasTransformHierarchy(){} // RVA: 0x7B061F0
        public void get_allowConstantClipSamplingOptimization(){} // RVA: 0x7B06290
        public void set_allowConstantClipSamplingOptimization(){} // RVA: 0x7B06330
        public void get_gravityWeight(){} // RVA: 0x7B063E0
        public void get_bodyPosition(){} // RVA: 0x7B06480
        public void set_bodyPosition(){} // RVA: 0x7B06560
        public void get_bodyPositionInternal(){} // RVA: 0x7B06620
        public void set_bodyPositionInternal(){} // RVA: 0x7B066E0
        public void get_bodyRotation(){} // RVA: 0x7B06790
        public void set_bodyRotation(){} // RVA: 0x7B06860
        public void get_bodyRotationInternal(){} // RVA: 0x7B06910
        public void set_bodyRotationInternal(){} // RVA: 0x7B069D0
        public void GetIKPosition(){} // RVA: 0x7B06A80
        public void GetGoalPosition(){} // RVA: 0x7B06B70
        public void SetIKPosition(){} // RVA: 0x7B06C40
        public void SetGoalPosition(){} // RVA: 0x7B06D10
        public void GetIKRotation(){} // RVA: 0x7B06DD0
        public void GetGoalRotation(){} // RVA: 0x7B06EB0
        public void SetIKRotation(){} // RVA: 0x7B06F70
        public void SetGoalRotation(){} // RVA: 0x7B07030
        public void GetIKPositionWeight(){} // RVA: 0x7B070F0
        public void GetGoalWeightPosition(){} // RVA: 0x7B071A0
        public void SetIKPositionWeight(){} // RVA: 0x7B07250
        public void SetGoalWeightPosition(){} // RVA: 0x7B07310
        public void GetIKRotationWeight(){} // RVA: 0x7B073D0
        public void GetGoalWeightRotation(){} // RVA: 0x7B07480
        public void SetIKRotationWeight(){} // RVA: 0x7B07530
        public void SetGoalWeightRotation(){} // RVA: 0x7B075F0
        public void GetIKHintPosition(){} // RVA: 0x7B076B0
        public void GetHintPosition(){} // RVA: 0x7B077A0
        public void SetIKHintPosition(){} // RVA: 0x7B07870
        public void SetHintPosition(){} // RVA: 0x7B07940
        public void GetIKHintPositionWeight(){} // RVA: 0x7B07A00
        public void GetHintWeightPosition(){} // RVA: 0x7B07AB0
        public void SetIKHintPositionWeight(){} // RVA: 0x7B07B60
        public void SetHintWeightPosition(){} // RVA: 0x7B07C20
        public void SetLookAtPosition(){} // RVA: 0x7B07CE0
        public void SetLookAtPositionInternal(){} // RVA: 0x7B07DA0
        public void SetLookAtWeight(){} // RVA: 0x7B08110
        public void SetLookAtWeightInternal(){} // RVA: 0x7B08170
        public void SetBoneLocalRotation(){} // RVA: 0x7B08240
        public void SetBoneLocalRotationInternal(){} // RVA: 0x7B08350
        public void GetBehaviour(){} // RVA: 0xA94080
        public void ConvertStateMachineBehaviour(){} // RVA: 0x29A4240
        public void GetBehaviours(){} // RVA: 0x2D71A10
        public void InternalGetBehaviours(){} // RVA: 0x7B08510
        public void InternalGetBehavioursByKey(){} // RVA: 0x7B08770
        public void get_stabilizeFeet(){} // RVA: 0x7B08870
        public void set_stabilizeFeet(){} // RVA: 0x7B08910
        public void get_layerCount(){} // RVA: 0x7B089C0
        public void GetLayerName(){} // RVA: 0x7B08A60
        public void GetLayerIndex(){} // RVA: 0x7B08BA0
        public void GetLayerWeight(){} // RVA: 0x7B08D30
        public void SetLayerWeight(){} // RVA: 0x7B08DE0
        public void GetAnimatorStateInfo(){} // RVA: 0x7B08EA0
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7B08F70
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7B09070
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7B09230
        public void GetAnimatorClipInfoCount(){} // RVA: 0x7B09320
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7B093E0
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7B093F0
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7B09560
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7B096B0
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7B095E0
        public void IsInTransition(){} // RVA: 0x7B09730
        public void get_parameters(){} // RVA: 0x7B097E0
        public void get_parameterCount(){} // RVA: 0x7B09880
        public void GetParameterInternal(){} // RVA: 0x7B09920
        public void GetParameter(){} // RVA: 0x7B099D0
        public void get_feetPivotActive(){} // RVA: 0x7B09B10
        public void set_feetPivotActive(){} // RVA: 0x7B09BB0
        public void get_pivotWeight(){} // RVA: 0x7B09C60
        public void get_pivotPosition(){} // RVA: 0x7B09D00
        public void MatchTarget(){} // RVA: 0x7B0A110
        public void InterruptMatchTarget(){} // RVA: 0x7B0A250
        public void get_isMatchingTarget(){} // RVA: 0x7B0A300
        public void get_speed(){} // RVA: 0x7B0A3A0
        public void set_speed(){} // RVA: 0x7B0A440
        public void ForceStateNormalizedTime(){} // RVA: 0x7B0A4F0
        public void CrossFadeInFixedTime(){} // RVA: 0x7B0A720
        public void WriteDefaultValues(){} // RVA: 0x7B0A7F0
        public void CrossFade(){} // RVA: 0x7B0AB50
        public void PlayInFixedTime(){} // RVA: 0x7B0AD60
        public void Play(){} // RVA: 0x7B0AF60
        public void SetTarget(){} // RVA: 0x7B0AF90
        public void get_targetPosition(){} // RVA: 0x7B0B050
        public void get_targetRotation(){} // RVA: 0x7B0B110
        public void IsControlled(){} // RVA: 0x263B110
        public void IsBoneTransform(){} // RVA: 0x7B0B1D0
        public void get_avatarRoot(){} // RVA: 0x7B0B2B0
        public void GetBoneTransform(){} // RVA: 0x7B0B370
        public void GetBoneTransformInternal(){} // RVA: 0x7B0B6D0
        public void get_cullingMode(){} // RVA: 0x7B0B7A0
        public void set_cullingMode(){} // RVA: 0x7B0B840
        public void StartPlayback(){} // RVA: 0x7B0B8F0
        public void StopPlayback(){} // RVA: 0x7B0B990
        public void get_playbackTime(){} // RVA: 0x7B0BA30
        public void set_playbackTime(){} // RVA: 0x7B0BAD0
        public void StartRecording(){} // RVA: 0x7B0BB80
        public void StopRecording(){} // RVA: 0x7B0BC30
        public void get_recorderStartTime(){} // RVA: 0x7B0BCD0
        public void set_recorderStartTime(){} // RVA: 0xB43310
        public void GetRecorderStartTime(){} // RVA: 0x7B0BCD0
        public void get_recorderStopTime(){} // RVA: 0x7B0BD70
        public void set_recorderStopTime(){} // RVA: 0xB43310
        public void GetRecorderStopTime(){} // RVA: 0x7B0BD70
        public void get_recorderMode(){} // RVA: 0x7B0BE10
        public void get_runtimeAnimatorController(){} // RVA: 0x7B0BEB0
        public void set_runtimeAnimatorController(){} // RVA: 0x7B0BF70
        public void get_hasBoundPlayables(){} // RVA: 0x7B0C050
        public void ClearInternalControllerPlayable(){} // RVA: 0x7B0C0F0
        public void HasState(){} // RVA: 0x7B0C190
        public void StringToHash(){} // RVA: 0x7B0C250
        public void get_avatar(){} // RVA: 0x7B0C390
        public void set_avatar(){} // RVA: 0x7B0C450
        public void GetStats(){} // RVA: 0x7B0C530
        public void get_playableGraph(){} // RVA: 0x7B0C660
        public void GetCurrentGraph(){} // RVA: 0x7B0C720
        public void CheckIfInIKPass(){} // RVA: 0x7B0C7D0
        public void IsInIKPass(){} // RVA: 0x7B0C940
        public void SetFloatString(){} // RVA: 0x7B0C9E0
        public void SetFloatID(){} // RVA: 0x7B04E90
        public void GetFloatString(){} // RVA: 0x7B0CB80
        public void GetFloatID(){} // RVA: 0x7B04DC0
        public void SetBoolString(){} // RVA: 0x7B0CD20
        public void SetBoolID(){} // RVA: 0x7B050F0
        public void GetBoolString(){} // RVA: 0x7B0CEB0
        public void GetBoolID(){} // RVA: 0x7B05030
        public void SetIntegerString(){} // RVA: 0x7B0D040
        public void SetIntegerID(){} // RVA: 0x7B05280
        public void GetIntegerString(){} // RVA: 0x7B0D1D0
        public void GetIntegerID(){} // RVA: 0x7B051C0
        public void SetTriggerString(){} // RVA: 0x7B0D360
        public void SetTriggerID(){} // RVA: 0x7B05350
        public void ResetTriggerString(){} // RVA: 0x7B0D4F0
        public void ResetTriggerID(){} // RVA: 0x7B05410
        public void IsParameterControlledByCurveString(){} // RVA: 0x7B0D680
        public void IsParameterControlledByCurveID(){} // RVA: 0x7B054D0
        public void SetFloatStringDamp(){} // RVA: 0x7B0D810
        public void SetFloatIDDamp(){} // RVA: 0x7B04F50
        public void get_layersAffectMassCenter(){} // RVA: 0x7B0D9E0
        public void set_layersAffectMassCenter(){} // RVA: 0x7B0DA80
        public void get_leftFeetBottomHeight(){} // RVA: 0x7B0DB30
        public void get_rightFeetBottomHeight(){} // RVA: 0x7B0DBD0
        public void get_supportsOnAnimatorMove(){} // RVA: 0x7B0DC70
        public void OnUpdateModeChanged(){} // RVA: 0x7B0DD10
        public void OnCullingModeChanged(){} // RVA: 0x7B0DDB0
        public void WriteDefaultPose(){} // RVA: 0x7B0DE50
        public void Update(){} // RVA: 0x7B0DEF0
        public void Rebind(){} // RVA: 0x7B0E040
        public void ApplyBuiltinRootMotion(){} // RVA: 0x7B0E0F0
        public void EvaluateController(){} // RVA: 0x7B0E230
        public void GetCurrentStateName(){} // RVA: 0x7B0E2E0
        public void GetNextStateName(){} // RVA: 0x7B0E2F0
        public void GetAnimatorStateName(){} // RVA: 0x7B0E300
        public void ResolveHash(){} // RVA: 0x7B0E450
        public void get_logWarnings(){} // RVA: 0x7B0E590
        public void set_logWarnings(){} // RVA: 0x7B0E630
        public void get_fireEvents(){} // RVA: 0x7B0E6E0
        public void set_fireEvents(){} // RVA: 0x7B0E780
        public void get_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7B0E830
        public void set_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7B0E8D0
        public void get_keepAnimatorStateOnDisable(){} // RVA: 0x7B0E830
        public void set_keepAnimatorStateOnDisable(){} // RVA: 0x7B0E8E0
        public void get_writeDefaultValuesOnDisable(){} // RVA: 0x7B0E990
        public void set_writeDefaultValuesOnDisable(){} // RVA: 0x7B0EA30
        public void GetVector(){} // RVA: 0x7B0EAE0
        public void SetVector(){} // RVA: 0xB43310
        public void GetQuaternion(){} // RVA: 0x7B0EB40
        public void SetQuaternion(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
        public void get_isOptimizable_Injected(){} // RVA: 0x7B0EB90
        public void get_isHuman_Injected(){} // RVA: 0x7B0EBE0
        public void get_hasRootMotion_Injected(){} // RVA: 0x7B0EC30
        public void get_isRootPositionOrRotationControlledByCurves_Injected(){} // RVA: 0x7B0EC80
        public void get_humanScale_Injected(){} // RVA: 0x7B0ECD0
        public void get_isInitialized_Injected(){} // RVA: 0x7B0ED20
        public void get_deltaPosition_Injected(){} // RVA: 0x7B0ED70
        public void get_deltaRotation_Injected(){} // RVA: 0x7B0EDD0
        public void get_velocity_Injected(){} // RVA: 0x7B0EE30
        public void get_angularVelocity_Injected(){} // RVA: 0x7B0EE90
        public void get_rootPosition_Injected(){} // RVA: 0x7B0EEF0
        public void set_rootPosition_Injected(){} // RVA: 0x7B0EF50
        public void get_rootRotation_Injected(){} // RVA: 0x7B0EFB0
        public void set_rootRotation_Injected(){} // RVA: 0x7B0F010
        public void get_applyRootMotion_Injected(){} // RVA: 0x7B0F070
        public void set_applyRootMotion_Injected(){} // RVA: 0x7B0F0C0
        public void get_noDiscreteIntBindings_Injected(){} // RVA: 0x7B0F120
        public void set_noDiscreteIntBindings_Injected(){} // RVA: 0x7B0F170
        public void get_linearVelocityBlending_Injected(){} // RVA: 0x7B0F1D0
        public void set_linearVelocityBlending_Injected(){} // RVA: 0x7B0F220
        public void get_animatePhysics_Injected(){} // RVA: 0x7B0F280
        public void set_animatePhysics_Injected(){} // RVA: 0x7B0F2D0
        public void get_updateMode_Injected(){} // RVA: 0x7B0F330
        public void set_updateMode_Injected(){} // RVA: 0x7B0F380
        public void get_hasTransformHierarchy_Injected(){} // RVA: 0x7B0F3E0
        public void get_allowConstantClipSamplingOptimization_Injected(){} // RVA: 0x7B0F430
        public void set_allowConstantClipSamplingOptimization_Injected(){} // RVA: 0x7B0F480
        public void get_gravityWeight_Injected(){} // RVA: 0x7B0F4E0
        public void get_bodyPositionInternal_Injected(){} // RVA: 0x7B0F530
        public void set_bodyPositionInternal_Injected(){} // RVA: 0x7B0F590
        public void get_bodyRotationInternal_Injected(){} // RVA: 0x7B0F5F0
        public void set_bodyRotationInternal_Injected(){} // RVA: 0x7B0F650
        public void GetGoalPosition_Injected(){} // RVA: 0x7B0F6B0
        public void SetGoalPosition_Injected(){} // RVA: 0x7B0F720
        public void GetGoalRotation_Injected(){} // RVA: 0x7B0F790
        public void SetGoalRotation_Injected(){} // RVA: 0x7B0F800
        public void GetGoalWeightPosition_Injected(){} // RVA: 0x7B0F870
        public void SetGoalWeightPosition_Injected(){} // RVA: 0x7B0F8D0
        public void GetGoalWeightRotation_Injected(){} // RVA: 0x7B0F940
        public void SetGoalWeightRotation_Injected(){} // RVA: 0x7B0F9A0
        public void GetHintPosition_Injected(){} // RVA: 0x7B0FA10
        public void SetHintPosition_Injected(){} // RVA: 0x7B0FA80
        public void GetHintWeightPosition_Injected(){} // RVA: 0x7B0FAF0
        public void SetHintWeightPosition_Injected(){} // RVA: 0x7B0FB50
        public void SetLookAtPositionInternal_Injected(){} // RVA: 0x7B0FBC0
        public void SetLookAtWeightInternal_Injected(){} // RVA: 0x7B0FC20
        public void SetBoneLocalRotationInternal_Injected(){} // RVA: 0x7B0FCB0
        public void GetBehaviour_Injected(){} // RVA: 0x7B0FD20
        public void InternalGetBehaviours_Injected(){} // RVA: 0x7B0FD80
        public void InternalGetBehavioursByKey_Injected(){} // RVA: 0x7B0FDE0
        public void get_stabilizeFeet_Injected(){} // RVA: 0x7B0FE60
        public void set_stabilizeFeet_Injected(){} // RVA: 0x7B0FEB0
        public void get_layerCount_Injected(){} // RVA: 0x7B0FF10
        public void GetLayerName_Injected(){} // RVA: 0x7B0FF60
        public void GetLayerIndex_Injected(){} // RVA: 0x7B0FFD0
        public void GetLayerWeight_Injected(){} // RVA: 0x7B10030
        public void SetLayerWeight_Injected(){} // RVA: 0x7B10090
        public void GetAnimatorStateInfo_Injected(){} // RVA: 0x7B10100
        public void GetAnimatorTransitionInfo_Injected(){} // RVA: 0x7B10180
        public void GetAnimatorClipInfoCount_Injected(){} // RVA: 0x7B101F0
        public void GetCurrentAnimatorClipInfo_Injected(){} // RVA: 0x7B10260
        public void GetNextAnimatorClipInfo_Injected(){} // RVA: 0x7B102C0
        public void GetAnimatorClipInfoInternal_Injected(){} // RVA: 0x7B10320
        public void IsInTransition_Injected(){} // RVA: 0x7B103A0
        public void get_parameters_Injected(){} // RVA: 0x7B10400
        public void get_parameterCount_Injected(){} // RVA: 0x7B10450
        public void GetParameterInternal_Injected(){} // RVA: 0x7B104A0
        public void get_feetPivotActive_Injected(){} // RVA: 0x7B10500
        public void set_feetPivotActive_Injected(){} // RVA: 0x7B10550
        public void get_pivotWeight_Injected(){} // RVA: 0x7B105B0
        public void get_pivotPosition_Injected(){} // RVA: 0x7B10600
        public void MatchTarget_Injected(){} // RVA: 0x7B10660
        public void InterruptMatchTarget_Injected(){} // RVA: 0x7B106F0
        public void get_isMatchingTarget_Injected(){} // RVA: 0x7B10750
        public void get_speed_Injected(){} // RVA: 0x7B107A0
        public void set_speed_Injected(){} // RVA: 0x7B107F0
        public void CrossFadeInFixedTime_Injected(){} // RVA: 0x7B10850
        public void WriteDefaultValues_Injected(){} // RVA: 0x7B108D0
        public void CrossFade_Injected(){} // RVA: 0x7B10920
        public void PlayInFixedTime_Injected(){} // RVA: 0x7B109A0
        public void Play_Injected(){} // RVA: 0x7B10A20
        public void SetTarget_Injected(){} // RVA: 0x7B10AA0
        public void get_targetPosition_Injected(){} // RVA: 0x7B10B10
        public void get_targetRotation_Injected(){} // RVA: 0x7B10B70
        public void IsBoneTransform_Injected(){} // RVA: 0x7B10BD0
        public void get_avatarRoot_Injected(){} // RVA: 0x7B10C30
        public void GetBoneTransformInternal_Injected(){} // RVA: 0x7B10C80
        public void get_cullingMode_Injected(){} // RVA: 0x7B10CE0
        public void set_cullingMode_Injected(){} // RVA: 0x7B10D30
        public void StartPlayback_Injected(){} // RVA: 0x7B10D90
        public void StopPlayback_Injected(){} // RVA: 0x7B10DE0
        public void get_playbackTime_Injected(){} // RVA: 0x7B10E30
        public void set_playbackTime_Injected(){} // RVA: 0x7B10E80
        public void StartRecording_Injected(){} // RVA: 0x7B10EE0
        public void StopRecording_Injected(){} // RVA: 0x7B10F40
        public void GetRecorderStartTime_Injected(){} // RVA: 0x7B10F90
        public void GetRecorderStopTime_Injected(){} // RVA: 0x7B10FE0
        public void get_recorderMode_Injected(){} // RVA: 0x7B11030
        public void get_runtimeAnimatorController_Injected(){} // RVA: 0x7B11080
        public void set_runtimeAnimatorController_Injected(){} // RVA: 0x7B110D0
        public void get_hasBoundPlayables_Injected(){} // RVA: 0x7B11130
        public void ClearInternalControllerPlayable_Injected(){} // RVA: 0x7B11180
        public void HasState_Injected(){} // RVA: 0x7B111D0
        public void StringToHash_Injected(){} // RVA: 0x7B11240
        public void get_avatar_Injected(){} // RVA: 0x7B11290
        public void set_avatar_Injected(){} // RVA: 0x7B112E0
        public void GetStats_Injected(){} // RVA: 0x7B11340
        public void GetCurrentGraph_Injected(){} // RVA: 0x7B113A0
        public void IsInIKPass_Injected(){} // RVA: 0x7B11400
        public void SetFloatString_Injected(){} // RVA: 0x7B11450
        public void SetFloatID_Injected(){} // RVA: 0x7B114C0
        public void GetFloatString_Injected(){} // RVA: 0x7B11530
        public void GetFloatID_Injected(){} // RVA: 0x7B11590
        public void SetBoolString_Injected(){} // RVA: 0x7B115F0
        public void SetBoolID_Injected(){} // RVA: 0x7B11660
        public void GetBoolString_Injected(){} // RVA: 0x7B116D0
        public void GetBoolID_Injected(){} // RVA: 0x7B11730
        public void SetIntegerString_Injected(){} // RVA: 0x7B11790
        public void SetIntegerID_Injected(){} // RVA: 0x7B11800
        public void GetIntegerString_Injected(){} // RVA: 0x7B11870
        public void GetIntegerID_Injected(){} // RVA: 0x7B118D0
        public void SetTriggerString_Injected(){} // RVA: 0x7B11930
        public void SetTriggerID_Injected(){} // RVA: 0x7B11990
        public void ResetTriggerString_Injected(){} // RVA: 0x7B119F0
        public void ResetTriggerID_Injected(){} // RVA: 0x7B11A50
        public void IsParameterControlledByCurveString_Injected(){} // RVA: 0x7B11AB0
        public void IsParameterControlledByCurveID_Injected(){} // RVA: 0x7B11B10
        public void SetFloatStringDamp_Injected(){} // RVA: 0x7B11B70
        public void SetFloatIDDamp_Injected(){} // RVA: 0x7B11BF0
        public void get_layersAffectMassCenter_Injected(){} // RVA: 0x7B11C70
        public void set_layersAffectMassCenter_Injected(){} // RVA: 0x7B11CC0
        public void get_leftFeetBottomHeight_Injected(){} // RVA: 0x7B11D20
        public void get_rightFeetBottomHeight_Injected(){} // RVA: 0x7B11D70
        public void get_supportsOnAnimatorMove_Injected(){} // RVA: 0x7B11DC0
        public void OnUpdateModeChanged_Injected(){} // RVA: 0x7B11E10
        public void OnCullingModeChanged_Injected(){} // RVA: 0x7B11E60
        public void WriteDefaultPose_Injected(){} // RVA: 0x7B11EB0
        public void Update_Injected(){} // RVA: 0x7B11F00
        public void Rebind_Injected(){} // RVA: 0x7B11F60
        public void ApplyBuiltinRootMotion_Injected(){} // RVA: 0x7B11FC0
        public void EvaluateController_Injected(){} // RVA: 0x7B12010
        public void GetAnimatorStateName_Injected(){} // RVA: 0x7B12070
        public void ResolveHash_Injected(){} // RVA: 0x7B120F0
        public void get_logWarnings_Injected(){} // RVA: 0x7B12160
        public void set_logWarnings_Injected(){} // RVA: 0x7B121B0
        public void get_fireEvents_Injected(){} // RVA: 0x7B12210
        public void set_fireEvents_Injected(){} // RVA: 0x7B12260
        public void get_keepAnimatorStateOnDisable_Injected(){} // RVA: 0x7B122C0
        public void set_keepAnimatorStateOnDisable_Injected(){} // RVA: 0x7B12310
        public void get_writeDefaultValuesOnDisable_Injected(){} // RVA: 0x7B12370
        public void set_writeDefaultValuesOnDisable_Injected(){} // RVA: 0x7B123C0
    }

    public class AnimatorClipInfo : ValueType
    {
        // ── Methods ──
        public void get_clip(){} // RVA: 0x9596F0
        public void get_weight(){} // RVA: 0x958940
        public void InstanceIDToAnimationClipPPtr(){} // RVA: 0x7B047F0
        public void InstanceIDToAnimationClipPPtr_Injected(){} // RVA: 0x7B04870
    }

    public class AnimatorClipInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7D9E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E33ED0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AnimatorControllerParameter : Object
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x3E42230
        public void get_nameHash(){} // RVA: 0x7B12420
        public void get_type(){} // RVA: 0x47FDFF0
        public void set_type(){} // RVA: 0x1033F40
        public void get_defaultFloat(){} // RVA: 0x7AE80E0
        public void set_defaultFloat(){} // RVA: 0xC152E0
        public void get_defaultInt(){} // RVA: 0x4EDA0B0
        public void set_defaultInt(){} // RVA: 0x1269760
        public void get_defaultBool(){} // RVA: 0x7B12430
        public void set_defaultBool(){} // RVA: 0xD72F80
        public void Equals(){} // RVA: 0x7B12440
        public void GetHashCode(){} // RVA: 0x1269730
        public void .ctor(){} // RVA: 0x7B12520
    }

    public class AnimatorControllerParameter[] : Array
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

    public class AnimatorOverrideController : RuntimeAnimatorController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B126C0
        public void Internal_Create(){} // RVA: 0x7B12770
        public void get_runtimeAnimatorController(){} // RVA: 0x7B12810
        public void set_runtimeAnimatorController(){} // RVA: 0x7B128D0
        public void get_Item(){} // RVA: 0x7B12DC0
        public void set_Item(){} // RVA: 0x7B12EC0
        public void Internal_GetClipByName(){} // RVA: 0x7B129D0
        public void Internal_SetClipByName(){} // RVA: 0x7B12C00
        public void GetClip(){} // RVA: 0x7B12EE0
        public void SetClip(){} // RVA: 0x7B13000
        public void SendNotification(){} // RVA: 0x7B13130
        public void GetOriginalClip(){} // RVA: 0x7B131D0
        public void GetOverrideClip(){} // RVA: 0x7B132A0
        public void get_overridesCount(){} // RVA: 0x7B133A0
        public void GetOverrides(){} // RVA: 0x7B13440
        public void ApplyOverrides(){} // RVA: 0x7B13770
        public void OnInvalidateOverrideController(){} // RVA: 0x7B13BA0
        public void Internal_Create_Injected(){} // RVA: 0x7B13BE0
        public void get_runtimeAnimatorController_Injected(){} // RVA: 0x7B13C40
        public void set_runtimeAnimatorController_Injected(){} // RVA: 0x7B13C90
        public void Internal_GetClipByName_Injected(){} // RVA: 0x7B13CF0
        public void Internal_SetClipByName_Injected(){} // RVA: 0x7B13D60
        public void GetClip_Injected(){} // RVA: 0x7B13DD0
        public void SetClip_Injected(){} // RVA: 0x7B13E40
        public void SendNotification_Injected(){} // RVA: 0x7B13EC0
        public void GetOriginalClip_Injected(){} // RVA: 0x7B13F10
        public void GetOverrideClip_Injected(){} // RVA: 0x7B13F70
        public void get_overridesCount_Injected(){} // RVA: 0x7B13FD0
    }

    public class AnimatorOverrideController[] : Array
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

    public class AnimatorStateInfo : ValueType
    {
        // ── Methods ──
        public void IsName(){} // RVA: 0x959700
        public void get_fullPathHash(){} // RVA: 0x438050
        public void get_shortNameHash(){} // RVA: 0x454FE0
        public void get_normalizedTime(){} // RVA: 0x958960
        public void get_length(){} // RVA: 0x958970
        public void get_speed(){} // RVA: 0x276FA0
        public void get_speedMultiplier(){} // RVA: 0x958980
        public void get_tagHash(){} // RVA: 0x959740
        public void IsTag(){} // RVA: 0x959750
        public void get_loop(){} // RVA: 0x9589A0
    }

    public class AnimatorStateInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F2C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AE10
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4AF0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35240
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AE10
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AnimatorTransitionInfo : ValueType
    {
        // ── Methods ──
        public void IsName(){} // RVA: 0x959800
        public void IsUserName(){} // RVA: 0x959850
        public void get_fullPathHash(){} // RVA: 0x454FE0
        public void get_nameHash(){} // RVA: 0x438050
        public void get_userNameHash(){} // RVA: 0x4A8D60
        public void get_durationUnit(){} // RVA: 0x959880
        public void get_duration(){} // RVA: 0x958970
        public void get_normalizedTime(){} // RVA: 0x276FA0
        public void get_anyState(){} // RVA: 0x959890
    }

    public class AnimatorTransitionInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AnimatorUtility : Object
    {
        // ── Methods ──
        public void OptimizeTransformHierarchy(){} // RVA: 0x7B14020
        public void DeoptimizeTransformHierarchy(){} // RVA: 0x7B140F0
        public void .ctor(){} // RVA: 0xB43310
        public void OptimizeTransformHierarchy_Injected(){} // RVA: 0x7B141B0
        public void DeoptimizeTransformHierarchy_Injected(){} // RVA: 0x7B14210
    }

    public class Animator[] : Array
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

    public class Application : Object
    {
        // ── Methods ──
        public void Quit(){} // RVA: 0x7B534A0
        public void get_isPlaying(){} // RVA: 0x7B53520
        public void get_isFocused(){} // RVA: 0x7B53570
        public void get_buildGUID(){} // RVA: 0x7B535C0
        public void get_runInBackground(){} // RVA: 0x7B536C0
        public void set_runInBackground(){} // RVA: 0x7B53710
        public void get_isBatchMode(){} // RVA: 0x7B53760
        public void get_dataPath(){} // RVA: 0x7B537B0
        public void get_streamingAssetsPath(){} // RVA: 0x7B538B0
        public void get_persistentDataPath(){} // RVA: 0x7B539B0
        public void get_temporaryCachePath(){} // RVA: 0x7B53AB0
        public void get_unityVersion(){} // RVA: 0x7B53BB0
        public void get_version(){} // RVA: 0x7B53CB0
        public void get_installMode(){} // RVA: 0x7B53DB0
        public void get_productName(){} // RVA: 0x7B53E00
        public void get_companyName(){} // RVA: 0x7B53F00
        public void get_cloudProjectId(){} // RVA: 0x7B54000
        public void OpenURL(){} // RVA: 0x7B54100
        public void get_targetFrameRate(){} // RVA: 0x7B54260
        public void set_targetFrameRate(){} // RVA: 0x7B542B0
        public void SetLogCallbackDefined(){} // RVA: 0x7B54300
        public void GetStackTraceLogType(){} // RVA: 0x7B54350
        public void set_backgroundLoadingPriority(){} // RVA: 0x7B543A0
        public void HasUserAuthorization(){} // RVA: 0x7B543F0
        public void get_platform(){} // RVA: 0x7B54440
        public void get_isMobilePlatform(){} // RVA: 0x7B54490
        public void get_systemLanguage(){} // RVA: 0x7B54580
        public void get_internetReachability(){} // RVA: 0x7B545D0
        public void add_lowMemory(){} // RVA: 0x7B54620
        public void remove_lowMemory(){} // RVA: 0x7B54770
        public void CallLowMemory(){} // RVA: 0x7B548C0
        public void HasLogCallback(){} // RVA: 0x7B54A00
        public void add_logMessageReceivedThreaded(){} // RVA: 0x7B54A90
        public void remove_logMessageReceivedThreaded(){} // RVA: 0x7B54C10
        public void CallLogCallback(){} // RVA: 0x7B54D50
        public void add_onBeforeRender(){} // RVA: 0x7B54E40
        public void remove_onBeforeRender(){} // RVA: 0x7B54E90
        public void add_focusChanged(){} // RVA: 0x7B54EE0
        public void remove_focusChanged(){} // RVA: 0x7B55050
        public void add_wantsToQuit(){} // RVA: 0x7B551C0
        public void remove_wantsToQuit(){} // RVA: 0x7B55330
        public void add_quitting(){} // RVA: 0x7B554A0
        public void remove_quitting(){} // RVA: 0x7B555F0
        public void Internal_ApplicationWantsToQuit(){} // RVA: 0x7B55740
        public void get_exitCancellationToken(){} // RVA: 0x7B558F0
        public void Internal_InitializeExitCancellationToken(){} // RVA: 0x7B55960
        public void Internal_RaiseExitCancellationToken(){} // RVA: 0x7B55AC0
        public void Internal_ApplicationQuit(){} // RVA: 0x7B55B70
        public void Internal_ApplicationUnload(){} // RVA: 0x7B55C10
        public void InvokeOnBeforeRender(){} // RVA: 0x7B55CB0
        public void InvokeFocusChanged(){} // RVA: 0x7B55D00
        public void InvokeDeepLinkActivated(){} // RVA: 0x7B55DA0
        public void get_isEditor(){} // RVA: 0x263B110
        public void .cctor(){} // RVA: 0x7B55E40
        public void get_buildGUID_Injected(){} // RVA: 0x7B55F10
        public void get_dataPath_Injected(){} // RVA: 0x7B55F60
        public void get_streamingAssetsPath_Injected(){} // RVA: 0x7B55FB0
        public void get_persistentDataPath_Injected(){} // RVA: 0x7B56000
        public void get_temporaryCachePath_Injected(){} // RVA: 0x7B56050
        public void get_unityVersion_Injected(){} // RVA: 0x7B560A0
        public void get_version_Injected(){} // RVA: 0x7B560F0
        public void get_productName_Injected(){} // RVA: 0x7B56140
        public void get_companyName_Injected(){} // RVA: 0x7B56190
        public void get_cloudProjectId_Injected(){} // RVA: 0x7B561E0
        public void OpenURL_Injected(){} // RVA: 0x7B56230
    }

    public class ApplicationMemoryUsageChange : ValueType
    {
        // ── Methods ──
        public void set_memoryUsage(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x29580
    }

    public class Application[] : Array
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

    public class AreaEffector2D : Effector2D
    {
        // ── Methods ──
        public void get_forceAngle(){} // RVA: 0x7D12490
        public void set_forceAngle(){} // RVA: 0x7D12530
        public void get_useGlobalAngle(){} // RVA: 0x7D125E0
        public void set_useGlobalAngle(){} // RVA: 0x7D12680
        public void get_forceMagnitude(){} // RVA: 0x7D12730
        public void set_forceMagnitude(){} // RVA: 0x7D127D0
        public void get_forceVariation(){} // RVA: 0x7D12880
        public void set_forceVariation(){} // RVA: 0x7D12920
        public void get_drag(){} // RVA: 0x7D129D0
        public void set_drag(){} // RVA: 0x7D12A70
        public void get_angularDrag(){} // RVA: 0x7D12B20
        public void set_angularDrag(){} // RVA: 0x7D12BC0
        public void get_forceTarget(){} // RVA: 0x7D12C70
        public void set_forceTarget(){} // RVA: 0x7D12D10
        public void .ctor(){} // RVA: 0xB43D60
        public void get_forceAngle_Injected(){} // RVA: 0x7D12DC0
        public void set_forceAngle_Injected(){} // RVA: 0x7D12E10
        public void get_useGlobalAngle_Injected(){} // RVA: 0x7D12E70
        public void set_useGlobalAngle_Injected(){} // RVA: 0x7D12EC0
        public void get_forceMagnitude_Injected(){} // RVA: 0x7D12F20
        public void set_forceMagnitude_Injected(){} // RVA: 0x7D12F70
        public void get_forceVariation_Injected(){} // RVA: 0x7D12FD0
        public void set_forceVariation_Injected(){} // RVA: 0x7D13020
        public void get_drag_Injected(){} // RVA: 0x7D13080
        public void set_drag_Injected(){} // RVA: 0x7D130D0
        public void get_angularDrag_Injected(){} // RVA: 0x7D13130
        public void set_angularDrag_Injected(){} // RVA: 0x7D13180
        public void get_forceTarget_Injected(){} // RVA: 0x7D131E0
        public void set_forceTarget_Injected(){} // RVA: 0x7D13230
    }

    public class AssemblyFullName : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x966130
        public void GetHashCode(){} // RVA: 0x966140
        public void ToString(){} // RVA: 0x9661E0
    }

    public class AssemblyFullName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AssemblyIsEditorAssembly[] : Array
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

    public class AssemblyVersion : ValueType
    {
        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7BF9E70
        public void ToString(){} // RVA: 0x965E20
        public void Equals(){} // RVA: 0x965E30
        public void GetHashCode(){} // RVA: 0x965EE0
    }

    public class AssemblyVersion[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AssetBundle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B2EE10
        public void LoadAsset(){} // RVA: 0x7B2F010
        public void LoadAsset_Internal(){} // RVA: 0x7B2F150
        public void LoadAssetWithSubAssetsAsync(){} // RVA: 0x7B2F540
        public void LoadAllAssetsAsync(){} // RVA: 0x7B2F7D0
        public void Unload(){} // RVA: 0x7B2F890
        public void UnloadAsync(){} // RVA: 0x7B2F940
        public void GetAllAssetNames(){} // RVA: 0x7B2FA60
        public void GetAllScenePaths(){} // RVA: 0x7B2FB00
        public void LoadAssetWithSubAssetsAsync_Internal(){} // RVA: 0x7B2FBA0
        public void LoadAsset_Internal_Injected(){} // RVA: 0x7B2FE90
        public void Unload_Injected(){} // RVA: 0x7B2FF00
        public void UnloadAsync_Injected(){} // RVA: 0x7B2FF60
        public void GetAllAssetNames_Injected(){} // RVA: 0x7B2FFC0
        public void GetAllScenePaths_Injected(){} // RVA: 0x7B30010
        public void LoadAssetWithSubAssetsAsync_Internal_Injected(){} // RVA: 0x7B30060
    }

    public class AssetBundleCreateRequest : AsyncOperation
    {
        // ── Methods ──
        public void get_assetBundle(){} // RVA: 0x7B300E0
        public void get_assetBundle_Injected(){} // RVA: 0x7B30190
    }

    public class AssetBundleCreateRequest[] : Array
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

    public class AssetBundleRecompressOperation[] : Array
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

    public class AssetBundleRequest : ResourceRequest
    {
        // ── Methods ──
        public void GetResult(){} // RVA: 0x7B301E0
        public void get_asset(){} // RVA: 0xBFA210
        public void get_allAssets(){} // RVA: 0x7B30290
        public void .ctor(){} // RVA: 0x7B30300
        public void GetResult_Injected(){} // RVA: 0x7B30310
        public void get_allAssets_Injected(){} // RVA: 0x7B30360
    }

    public class AssetBundleRequest[] : Array
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

    public class AssetBundleUnloadOperation : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B30300
    }

    public class AssetBundleUnloadOperation[] : Array
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

    public class AssetFileNameExtensionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class AsyncInstantiateOperation : AsyncOperation
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x7489A40
        public void IsCancellationRequested(){} // RVA: 0x7BF43E0
        public void CreateResultArray(){} // RVA: 0x7BF4450
        public void .cctor(){} // RVA: 0x7BF44F0
    }

    public class AsyncInstantiateOperationHelper : Object
    {
        // ── Methods ──
        public void CreateAsyncInstantiateOperationResultArray(){} // RVA: 0x3042DE0
    }

    public class AsyncInstantiateOperationHelper[] : Array
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

    public class AsyncInstantiateOperation[] : Array
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

    public class AsyncInstantiateOperation`1 : AsyncInstantiateOperation
    {
        // ── Methods ──
        public void get_Result(){} // RVA: 0x87C0A0
    }

    public class AsyncOperation : YieldInstruction
    {
        // ── Methods ──
        public void InternalDestroy(){} // RVA: 0x7BF45C0
        public void InternalSetManagedObject(){} // RVA: 0x7BF4610
        public void .ctor(){} // RVA: 0x7BF4670
        public void get_isDone(){} // RVA: 0x7BF46E0
        public void get_progress(){} // RVA: 0x7BF4750
        public void set_allowSceneActivation(){} // RVA: 0x7BF47C0
        public void Finalize(){} // RVA: 0x7BF4840
        public void InvokeCompletionEvent(){} // RVA: 0x7BF48C0
        public void add_completed(){} // RVA: 0x7BF4940
        public void remove_completed(){} // RVA: 0x7BF4AE0
        public void get_isDone_Injected(){} // RVA: 0x7BF4BE0
        public void get_progress_Injected(){} // RVA: 0x7BF4C30
        public void set_allowSceneActivation_Injected(){} // RVA: 0x7BF4C80
    }

    public class AsyncOperationAwaitableExtensions : Object
    {
        // ── Methods ──
        public void GetAwaiter(){} // RVA: 0x7BF9B50
    }

    public class AsyncOperation[] : Array
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

    public class AttributeHelperEngine : Object
    {
        // ── Methods ──
        public void GetParentTypeDisallowingMultipleInclusion(){} // RVA: 0x7BF4D40
        public void GetRequiredComponents(){} // RVA: 0x7BF4EB0
        public void GetExecuteMode(){} // RVA: 0x7BF5310
        public void CheckIsEditorScript(){} // RVA: 0x7BF5480
        public void GetDefaultExecutionOrderFor(){} // RVA: 0x7BF56C0
        public void GetCustomAttributeOfType(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x7BF5820
    }

    public class AttributeHelperEngine[] : Array
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

    public class AudioBehaviour : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class AudioChorusFilter : Behaviour
    {
        // ── Methods ──
        public void get_dryMix(){} // RVA: 0x7B3BDB0
        public void set_dryMix(){} // RVA: 0x7B3BE50
        public void get_wetMix1(){} // RVA: 0x7B3BF00
        public void set_wetMix1(){} // RVA: 0x7B3BFA0
        public void get_wetMix2(){} // RVA: 0x7B3C050
        public void set_wetMix2(){} // RVA: 0x7B3C0F0
        public void get_wetMix3(){} // RVA: 0x7B3C1A0
        public void set_wetMix3(){} // RVA: 0x7B3C240
        public void get_delay(){} // RVA: 0x7B3C2F0
        public void set_delay(){} // RVA: 0x7B3C390
        public void get_rate(){} // RVA: 0x7B3C440
        public void set_rate(){} // RVA: 0x7B3C4E0
        public void get_depth(){} // RVA: 0x7B3C590
        public void set_depth(){} // RVA: 0x7B3C630
        public void get_feedback(){} // RVA: 0x7B3C6E0
        public void set_feedback(){} // RVA: 0x7B3C750
        public void .ctor(){} // RVA: 0xB43D60
        public void get_dryMix_Injected(){} // RVA: 0x7B3C7B0
        public void set_dryMix_Injected(){} // RVA: 0x7B3C800
        public void get_wetMix1_Injected(){} // RVA: 0x7B3C860
        public void set_wetMix1_Injected(){} // RVA: 0x7B3C8B0
        public void get_wetMix2_Injected(){} // RVA: 0x7B3C910
        public void set_wetMix2_Injected(){} // RVA: 0x7B3C960
        public void get_wetMix3_Injected(){} // RVA: 0x7B3C9C0
        public void set_wetMix3_Injected(){} // RVA: 0x7B3CA10
        public void get_delay_Injected(){} // RVA: 0x7B3CA70
        public void set_delay_Injected(){} // RVA: 0x7B3CAC0
        public void get_rate_Injected(){} // RVA: 0x7B3CB20
        public void set_rate_Injected(){} // RVA: 0x7B3CB70
        public void get_depth_Injected(){} // RVA: 0x7B3CBD0
        public void set_depth_Injected(){} // RVA: 0x7B3CC20
    }

    public class AudioClip : AudioResource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B30AB0
        public void GetData(){} // RVA: 0x7B31870
        public void SetData(){} // RVA: 0x7B31AF0
        public void Construct_Internal(){} // RVA: 0x7B30E10
        public void GetName(){} // RVA: 0x7B30E90
        public void CreateUserSound(){} // RVA: 0x7B30FC0
        public void get_length(){} // RVA: 0x7B31190
        public void get_samples(){} // RVA: 0x7B31230
        public void get_channels(){} // RVA: 0x7B312D0
        public void get_frequency(){} // RVA: 0x7B31370
        public void get_loadType(){} // RVA: 0x7B31410
        public void LoadAudioData(){} // RVA: 0x7B314B0
        public void UnloadAudioData(){} // RVA: 0x7B31550
        public void get_preloadAudioData(){} // RVA: 0x7B315F0
        public void get_ambisonic(){} // RVA: 0x7B31690
        public void get_loadInBackground(){} // RVA: 0x7B31730
        public void get_loadState(){} // RVA: 0x7B317D0
        public void Create(){} // RVA: 0x7B31E70
        public void add_m_PCMReaderCallback(){} // RVA: 0x7B32260
        public void remove_m_PCMReaderCallback(){} // RVA: 0x7B32350
        public void add_m_PCMSetPositionCallback(){} // RVA: 0x7B32440
        public void remove_m_PCMSetPositionCallback(){} // RVA: 0x7B32530
        public void InvokePCMReaderCallback_Internal(){} // RVA: 0x7B32620
        public void InvokePCMSetPositionCallback_Internal(){} // RVA: 0x7B32640
        public void GetData_Injected(){} // RVA: 0x7B32660
        public void SetData_Injected(){} // RVA: 0x7B326D0
        public void Construct_Internal_Injected(){} // RVA: 0x7B32740
        public void GetName_Injected(){} // RVA: 0x7B32790
        public void CreateUserSound_Injected(){} // RVA: 0x7B327F0
        public void get_length_Injected(){} // RVA: 0x7B32880
        public void get_samples_Injected(){} // RVA: 0x7B328D0
        public void get_channels_Injected(){} // RVA: 0x7B32920
        public void get_frequency_Injected(){} // RVA: 0x7B32970
        public void get_loadType_Injected(){} // RVA: 0x7B329C0
        public void LoadAudioData_Injected(){} // RVA: 0x7B32A10
        public void UnloadAudioData_Injected(){} // RVA: 0x7B32A60
        public void get_preloadAudioData_Injected(){} // RVA: 0x7B32AB0
        public void get_ambisonic_Injected(){} // RVA: 0x7B32B00
        public void get_loadInBackground_Injected(){} // RVA: 0x7B32B50
        public void get_loadState_Injected(){} // RVA: 0x7B32BA0
    }

    public class AudioClip[] : Array
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

    public class AudioDistortionFilter : Behaviour
    {
        // ── Methods ──
        public void get_distortionLevel(){} // RVA: 0x7B3B3B0
        public void set_distortionLevel(){} // RVA: 0x7B3B450
        public void .ctor(){} // RVA: 0xB43D60
        public void get_distortionLevel_Injected(){} // RVA: 0x7B3B500
        public void set_distortionLevel_Injected(){} // RVA: 0x7B3B550
    }

    public class AudioEchoFilter : Behaviour
    {
        // ── Methods ──
        public void get_delay(){} // RVA: 0x7B3B5B0
        public void set_delay(){} // RVA: 0x7B3B650
        public void get_decayRatio(){} // RVA: 0x7B3B700
        public void set_decayRatio(){} // RVA: 0x7B3B7A0
        public void get_dryMix(){} // RVA: 0x7B3B850
        public void set_dryMix(){} // RVA: 0x7B3B8F0
        public void get_wetMix(){} // RVA: 0x7B3B9A0
        public void set_wetMix(){} // RVA: 0x7B3BA40
        public void .ctor(){} // RVA: 0xB43D60
        public void get_delay_Injected(){} // RVA: 0x7B3BAF0
        public void set_delay_Injected(){} // RVA: 0x7B3BB40
        public void get_decayRatio_Injected(){} // RVA: 0x7B3BBA0
        public void set_decayRatio_Injected(){} // RVA: 0x7B3BBF0
        public void get_dryMix_Injected(){} // RVA: 0x7B3BC50
        public void set_dryMix_Injected(){} // RVA: 0x7B3BCA0
        public void get_wetMix_Injected(){} // RVA: 0x7B3BD00
        public void set_wetMix_Injected(){} // RVA: 0x7B3BD50
    }

    public class AudioHighPassFilter : Behaviour
    {
        // ── Methods ──
        public void get_cutoffFrequency(){} // RVA: 0x7B3AFB0
        public void set_cutoffFrequency(){} // RVA: 0x7B3B050
        public void get_highpassResonanceQ(){} // RVA: 0x7B3B100
        public void set_highpassResonanceQ(){} // RVA: 0x7B3B1A0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_cutoffFrequency_Injected(){} // RVA: 0x7B3B250
        public void set_cutoffFrequency_Injected(){} // RVA: 0x7B3B2A0
        public void get_highpassResonanceQ_Injected(){} // RVA: 0x7B3B300
        public void set_highpassResonanceQ_Injected(){} // RVA: 0x7B3B350
    }

    public class AudioListener : AudioBehaviour
    {
        // ── Methods ──
        public void get_volume(){} // RVA: 0x7B32BF0
        public void set_volume(){} // RVA: 0x7B32C40
        public void get_pause(){} // RVA: 0x7B32CA0
        public void set_pause(){} // RVA: 0x7B32CF0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class AudioListener[] : Array
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

    public class AudioLowPassFilter : Behaviour
    {
        // ── Methods ──
        public void GetCustomLowpassLevelCurveCopy(){} // RVA: 0x7B3A930
        public void SetCustomLowpassLevelCurveHelper(){} // RVA: 0x7B3AA20
        public void get_customCutoffCurve(){} // RVA: 0x7B3A930
        public void set_customCutoffCurve(){} // RVA: 0x7B3AA20
        public void get_cutoffFrequency(){} // RVA: 0x7B3AB00
        public void set_cutoffFrequency(){} // RVA: 0x7B3ABA0
        public void get_lowpassResonanceQ(){} // RVA: 0x7B3AC50
        public void set_lowpassResonanceQ(){} // RVA: 0x7B3ACF0
        public void .ctor(){} // RVA: 0xB43D60
        public void GetCustomLowpassLevelCurveCopy_Injected(){} // RVA: 0x7B3ADA0
        public void SetCustomLowpassLevelCurveHelper_Injected(){} // RVA: 0x7B3ADF0
        public void get_cutoffFrequency_Injected(){} // RVA: 0x7B3AE50
        public void set_cutoffFrequency_Injected(){} // RVA: 0x7B3AEA0
        public void get_lowpassResonanceQ_Injected(){} // RVA: 0x7B3AF00
        public void set_lowpassResonanceQ_Injected(){} // RVA: 0x7B3AF50
    }

    public class AudioRenderer : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7B3F450
        public void Stop(){} // RVA: 0x7B3F4A0
        public void GetSampleCountForCaptureFrame(){} // RVA: 0x7B3F4F0
        public void Render(){} // RVA: 0x7B3F540
        public void Internal_AudioRenderer_Start(){} // RVA: 0x7B3F450
        public void Internal_AudioRenderer_Stop(){} // RVA: 0x7B3F4A0
        public void Internal_AudioRenderer_GetSampleCountForCaptureFrame(){} // RVA: 0x7B3F4F0
        public void Internal_AudioRenderer_Render(){} // RVA: 0x7B3F5D0
    }

    public class AudioReverbFilter : Behaviour
    {
        // ── Methods ──
        public void get_reverbPreset(){} // RVA: 0x7B3CC80
        public void set_reverbPreset(){} // RVA: 0x7B3CD20
        public void get_dryLevel(){} // RVA: 0x7B3CDD0
        public void set_dryLevel(){} // RVA: 0x7B3CE70
        public void get_room(){} // RVA: 0x7B3CF20
        public void set_room(){} // RVA: 0x7B3CFC0
        public void get_roomHF(){} // RVA: 0x7B3D070
        public void set_roomHF(){} // RVA: 0x7B3D110
        public void get_roomRolloffFactor(){} // RVA: 0x7B3D1C0
        public void set_roomRolloffFactor(){} // RVA: 0x7B3D230
        public void get_decayTime(){} // RVA: 0x7B3D290
        public void set_decayTime(){} // RVA: 0x7B3D330
        public void get_decayHFRatio(){} // RVA: 0x7B3D3E0
        public void set_decayHFRatio(){} // RVA: 0x7B3D480
        public void get_reflectionsLevel(){} // RVA: 0x7B3D530
        public void set_reflectionsLevel(){} // RVA: 0x7B3D5D0
        public void get_reflectionsDelay(){} // RVA: 0x7B3D680
        public void set_reflectionsDelay(){} // RVA: 0x7B3D720
        public void get_reverbLevel(){} // RVA: 0x7B3D7D0
        public void set_reverbLevel(){} // RVA: 0x7B3D870
        public void get_reverbDelay(){} // RVA: 0x7B3D920
        public void set_reverbDelay(){} // RVA: 0x7B3D9C0
        public void get_diffusion(){} // RVA: 0x7B3DA70
        public void set_diffusion(){} // RVA: 0x7B3DB10
        public void get_density(){} // RVA: 0x7B3DBC0
        public void set_density(){} // RVA: 0x7B3DC60
        public void get_hfReference(){} // RVA: 0x7B3DD10
        public void set_hfReference(){} // RVA: 0x7B3DDB0
        public void get_roomLF(){} // RVA: 0x7B3DE60
        public void set_roomLF(){} // RVA: 0x7B3DF00
        public void get_lfReference(){} // RVA: 0x7B3DFB0
        public void set_lfReference(){} // RVA: 0x7B3E050
        public void .ctor(){} // RVA: 0xB43D60
        public void get_reverbPreset_Injected(){} // RVA: 0x7B3E100
        public void set_reverbPreset_Injected(){} // RVA: 0x7B3E150
        public void get_dryLevel_Injected(){} // RVA: 0x7B3E1B0
        public void set_dryLevel_Injected(){} // RVA: 0x7B3E200
        public void get_room_Injected(){} // RVA: 0x7B3E260
        public void set_room_Injected(){} // RVA: 0x7B3E2B0
        public void get_roomHF_Injected(){} // RVA: 0x7B3E310
        public void set_roomHF_Injected(){} // RVA: 0x7B3E360
        public void get_decayTime_Injected(){} // RVA: 0x7B3E3C0
        public void set_decayTime_Injected(){} // RVA: 0x7B3E410
        public void get_decayHFRatio_Injected(){} // RVA: 0x7B3E470
        public void set_decayHFRatio_Injected(){} // RVA: 0x7B3E4C0
        public void get_reflectionsLevel_Injected(){} // RVA: 0x7B3E520
        public void set_reflectionsLevel_Injected(){} // RVA: 0x7B3E570
        public void get_reflectionsDelay_Injected(){} // RVA: 0x7B3E5D0
        public void set_reflectionsDelay_Injected(){} // RVA: 0x7B3E620
        public void get_reverbLevel_Injected(){} // RVA: 0x7B3E680
        public void set_reverbLevel_Injected(){} // RVA: 0x7B3E6D0
        public void get_reverbDelay_Injected(){} // RVA: 0x7B3E730
        public void set_reverbDelay_Injected(){} // RVA: 0x7B3E780
        public void get_diffusion_Injected(){} // RVA: 0x7B3E7E0
        public void set_diffusion_Injected(){} // RVA: 0x7B3E830
        public void get_density_Injected(){} // RVA: 0x7B3E890
        public void set_density_Injected(){} // RVA: 0x7B3E8E0
        public void get_hfReference_Injected(){} // RVA: 0x7B3E940
        public void set_hfReference_Injected(){} // RVA: 0x7B3E990
        public void get_roomLF_Injected(){} // RVA: 0x7B3E9F0
        public void set_roomLF_Injected(){} // RVA: 0x7B3EA40
        public void get_lfReference_Injected(){} // RVA: 0x7B3EAA0
        public void set_lfReference_Injected(){} // RVA: 0x7B3EAF0
    }

    public class AudioReverbZone : Behaviour
    {
        // ── Methods ──
        public void get_minDistance(){} // RVA: 0x7B38860
        public void set_minDistance(){} // RVA: 0x7B38900
        public void get_maxDistance(){} // RVA: 0x7B389B0
        public void set_maxDistance(){} // RVA: 0x7B38A50
        public void get_reverbPreset(){} // RVA: 0x7B38B00
        public void set_reverbPreset(){} // RVA: 0x7B38BA0
        public void get_room(){} // RVA: 0x7B38C50
        public void set_room(){} // RVA: 0x7B38CF0
        public void get_roomHF(){} // RVA: 0x7B38DA0
        public void set_roomHF(){} // RVA: 0x7B38E40
        public void get_roomLF(){} // RVA: 0x7B38EF0
        public void set_roomLF(){} // RVA: 0x7B38F90
        public void get_decayTime(){} // RVA: 0x7B39040
        public void set_decayTime(){} // RVA: 0x7B390E0
        public void get_decayHFRatio(){} // RVA: 0x7B39190
        public void set_decayHFRatio(){} // RVA: 0x7B39230
        public void get_reflections(){} // RVA: 0x7B392E0
        public void set_reflections(){} // RVA: 0x7B39380
        public void get_reflectionsDelay(){} // RVA: 0x7B39430
        public void set_reflectionsDelay(){} // RVA: 0x7B394D0
        public void get_reverb(){} // RVA: 0x7B39580
        public void set_reverb(){} // RVA: 0x7B39620
        public void get_reverbDelay(){} // RVA: 0x7B396D0
        public void set_reverbDelay(){} // RVA: 0x7B39770
        public void get_HFReference(){} // RVA: 0x7B39820
        public void set_HFReference(){} // RVA: 0x7B398C0
        public void get_LFReference(){} // RVA: 0x7B39970
        public void set_LFReference(){} // RVA: 0x7B39A10
        public void get_roomRolloffFactor(){} // RVA: 0x7B39AC0
        public void set_roomRolloffFactor(){} // RVA: 0x7B39B30
        public void get_diffusion(){} // RVA: 0x7B39B90
        public void set_diffusion(){} // RVA: 0x7B39C30
        public void get_density(){} // RVA: 0x7B39CE0
        public void set_density(){} // RVA: 0x7B39D80
        public void .ctor(){} // RVA: 0xB43D60
        public void get_minDistance_Injected(){} // RVA: 0x7B39E30
        public void set_minDistance_Injected(){} // RVA: 0x7B39E80
        public void get_maxDistance_Injected(){} // RVA: 0x7B39EE0
        public void set_maxDistance_Injected(){} // RVA: 0x7B39F30
        public void get_reverbPreset_Injected(){} // RVA: 0x7B39F90
        public void set_reverbPreset_Injected(){} // RVA: 0x7B39FE0
        public void get_room_Injected(){} // RVA: 0x7B3A040
        public void set_room_Injected(){} // RVA: 0x7B3A090
        public void get_roomHF_Injected(){} // RVA: 0x7B3A0F0
        public void set_roomHF_Injected(){} // RVA: 0x7B3A140
        public void get_roomLF_Injected(){} // RVA: 0x7B3A1A0
        public void set_roomLF_Injected(){} // RVA: 0x7B3A1F0
        public void get_decayTime_Injected(){} // RVA: 0x7B3A250
        public void set_decayTime_Injected(){} // RVA: 0x7B3A2A0
        public void get_decayHFRatio_Injected(){} // RVA: 0x7B3A300
        public void set_decayHFRatio_Injected(){} // RVA: 0x7B3A350
        public void get_reflections_Injected(){} // RVA: 0x7B3A3B0
        public void set_reflections_Injected(){} // RVA: 0x7B3A400
        public void get_reflectionsDelay_Injected(){} // RVA: 0x7B3A460
        public void set_reflectionsDelay_Injected(){} // RVA: 0x7B3A4B0
        public void get_reverb_Injected(){} // RVA: 0x7B3A510
        public void set_reverb_Injected(){} // RVA: 0x7B3A560
        public void get_reverbDelay_Injected(){} // RVA: 0x7B3A5C0
        public void set_reverbDelay_Injected(){} // RVA: 0x7B3A610
        public void get_HFReference_Injected(){} // RVA: 0x7B3A670
        public void set_HFReference_Injected(){} // RVA: 0x7B3A6C0
        public void get_LFReference_Injected(){} // RVA: 0x7B3A720
        public void set_LFReference_Injected(){} // RVA: 0x7B3A770
        public void get_diffusion_Injected(){} // RVA: 0x7B3A7D0
        public void set_diffusion_Injected(){} // RVA: 0x7B3A820
        public void get_density_Injected(){} // RVA: 0x7B3A880
        public void set_density_Injected(){} // RVA: 0x7B3A8D0
    }

    public class AudioSettings : Object
    {
        // ── Methods ──
        public void GetSpeakerMode(){} // RVA: 0x7B30470
        public void SetConfiguration(){} // RVA: 0x7B304C0
        public void GetSampleRate(){} // RVA: 0x6CC61E0
        public void get_driverCapabilities(){} // RVA: 0x7B30510
        public void get_speakerMode(){} // RVA: 0x7B30470
        public void get_dspTime(){} // RVA: 0x7B30560
        public void get_outputSampleRate(){} // RVA: 0x6CC61E0
        public void GetDSPBufferSize(){} // RVA: 0x7B305B0
        public void GetConfiguration(){} // RVA: 0x7B30610
        public void Reset(){} // RVA: 0x7B30670
        public void add_OnAudioConfigurationChanged(){} // RVA: 0x7B306D0
        public void remove_OnAudioConfigurationChanged(){} // RVA: 0x7B307E0
        public void InvokeOnAudioConfigurationChanged(){} // RVA: 0x7B308F0
        public void InvokeOnAudioSystemShuttingDown(){} // RVA: 0x7B30950
        public void InvokeOnAudioSystemStartedUp(){} // RVA: 0x7B309B0
        public void .ctor(){} // RVA: 0xB43310
        public void SetConfiguration_Injected(){} // RVA: 0x7B30A10
        public void GetConfiguration_Injected(){} // RVA: 0x7B30A60
    }

    public class AudioSettings[] : Array
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

    public class AudioSource : AudioBehaviour
    {
        // ── Methods ──
        public void GetPitch(){} // RVA: 0x7B32D40
        public void SetPitch(){} // RVA: 0x7B32E00
        public void PlayHelper(){} // RVA: 0x7B32ED0
        public void Play(){} // RVA: 0x7B33F90
        public void PlayOneShotHelper(){} // RVA: 0x7B33050
        public void Stop(){} // RVA: 0x7B343C0
        public void SetCustomCurveHelper(){} // RVA: 0x7B33240
        public void GetCustomCurveHelper(){} // RVA: 0x7B33330
        public void GetOutputDataHelper(){} // RVA: 0x7B33420
        public void GetSpectrumDataHelper(){} // RVA: 0x7B335B0
        public void get_volume(){} // RVA: 0x7B33740
        public void set_volume(){} // RVA: 0x7B337E0
        public void get_pitch(){} // RVA: 0x7B32D40
        public void set_pitch(){} // RVA: 0x7B32E00
        public void get_time(){} // RVA: 0x7B33890
        public void set_time(){} // RVA: 0x7B33930
        public void get_timeSamples(){} // RVA: 0x7B339E0
        public void set_timeSamples(){} // RVA: 0x7B33A80
        public void get_clip(){} // RVA: 0x7B33B30
        public void set_clip(){} // RVA: 0x7B33C40
        public void get_resource(){} // RVA: 0x7B33D20
        public void set_resource(){} // RVA: 0x7B33C40
        public void get_outputAudioMixerGroup(){} // RVA: 0x7B33DE0
        public void set_outputAudioMixerGroup(){} // RVA: 0x7B33EA0
        public void PlayDelayed(){} // RVA: 0x7B33FA0
        public void PlayScheduled(){} // RVA: 0x7B33FE0
        public void PlayOneShot(){} // RVA: 0x7B34020
        public void SetScheduledStartTime(){} // RVA: 0x7B34260
        public void SetScheduledEndTime(){} // RVA: 0x7B34310
        public void Pause(){} // RVA: 0x7B34460
        public void UnPause(){} // RVA: 0x7B34500
        public void SkipToNextElementIfHasContainer(){} // RVA: 0x7B345A0
        public void get_isPlaying(){} // RVA: 0x7B34640
        public void get_isContainerPlaying(){} // RVA: 0x7B346E0
        public void get_containerActivePlayables(){} // RVA: 0x7B34780
        public void get_isVirtual(){} // RVA: 0x7B34820
        public void PlayClipAtPoint(){} // RVA: 0x7B348F0
        public void get_loop(){} // RVA: 0x7B34CC0
        public void set_loop(){} // RVA: 0x7B34D60
        public void get_ignoreListenerVolume(){} // RVA: 0x7B34E10
        public void set_ignoreListenerVolume(){} // RVA: 0x7B34EB0
        public void get_playOnAwake(){} // RVA: 0x7B34F60
        public void set_playOnAwake(){} // RVA: 0x7B35000
        public void get_ignoreListenerPause(){} // RVA: 0x7B350B0
        public void set_ignoreListenerPause(){} // RVA: 0x7B35150
        public void get_velocityUpdateMode(){} // RVA: 0x7B35200
        public void set_velocityUpdateMode(){} // RVA: 0x7B352A0
        public void get_panStereo(){} // RVA: 0x7B35350
        public void set_panStereo(){} // RVA: 0x7B353F0
        public void get_spatialBlend(){} // RVA: 0x7B354A0
        public void set_spatialBlend(){} // RVA: 0x7B35540
        public void get_spatialize(){} // RVA: 0x7B355F0
        public void set_spatialize(){} // RVA: 0x7B35690
        public void get_spatializePostEffects(){} // RVA: 0x7B35740
        public void set_spatializePostEffects(){} // RVA: 0x7B357E0
        public void SetCustomCurve(){} // RVA: 0x7B33240
        public void GetCustomCurve(){} // RVA: 0x7B33330
        public void get_reverbZoneMix(){} // RVA: 0x7B35890
        public void set_reverbZoneMix(){} // RVA: 0x7B35930
        public void get_bypassEffects(){} // RVA: 0x7B359E0
        public void set_bypassEffects(){} // RVA: 0x7B35A80
        public void get_bypassListenerEffects(){} // RVA: 0x7B35B30
        public void set_bypassListenerEffects(){} // RVA: 0x7B35BD0
        public void get_bypassReverbZones(){} // RVA: 0x7B35C80
        public void set_bypassReverbZones(){} // RVA: 0x7B35D20
        public void get_dopplerLevel(){} // RVA: 0x7B35DD0
        public void set_dopplerLevel(){} // RVA: 0x7B35E70
        public void get_spread(){} // RVA: 0x7B35F20
        public void set_spread(){} // RVA: 0x7B35FC0
        public void get_priority(){} // RVA: 0x7B36070
        public void set_priority(){} // RVA: 0x7B36110
        public void get_mute(){} // RVA: 0x7B361C0
        public void set_mute(){} // RVA: 0x7B36260
        public void get_minDistance(){} // RVA: 0x7B36310
        public void set_minDistance(){} // RVA: 0x7B363B0
        public void get_maxDistance(){} // RVA: 0x7B36460
        public void set_maxDistance(){} // RVA: 0x7B36500
        public void get_rolloffMode(){} // RVA: 0x7B365B0
        public void set_rolloffMode(){} // RVA: 0x7B36650
        public void GetOutputData(){} // RVA: 0x7B36770
        public void GetSpectrumData(){} // RVA: 0x7B36810
        public void get_minVolume(){} // RVA: 0x7B36820
        public void set_minVolume(){} // RVA: 0x7B36890
        public void get_maxVolume(){} // RVA: 0x7B368F0
        public void set_maxVolume(){} // RVA: 0x7B36960
        public void get_rolloffFactor(){} // RVA: 0x7B369C0
        public void set_rolloffFactor(){} // RVA: 0x7B36A30
        public void SetSpatializerFloat(){} // RVA: 0x7B36A90
        public void GetSpatializerFloat(){} // RVA: 0x7B36B50
        public void GetAmbisonicDecoderFloat(){} // RVA: 0x7B36C10
        public void SetAmbisonicDecoderFloat(){} // RVA: 0x7B36CD0
        public void GetAudioRandomContainerRuntimeMeterValue(){} // RVA: 0x7B36D90
        public void .ctor(){} // RVA: 0xB43D60
        public void GetPitch_Injected(){} // RVA: 0x7B36E30
        public void SetPitch_Injected(){} // RVA: 0x7B36E80
        public void PlayHelper_Injected(){} // RVA: 0x7B36EE0
        public void Play_Injected(){} // RVA: 0x7B36F40
        public void PlayOneShotHelper_Injected(){} // RVA: 0x7B36FA0
        public void Stop_Injected(){} // RVA: 0x7B37010
        public void SetCustomCurveHelper_Injected(){} // RVA: 0x7B37070
        public void GetCustomCurveHelper_Injected(){} // RVA: 0x7B370E0
        public void GetOutputDataHelper_Injected(){} // RVA: 0x7B37140
        public void GetSpectrumDataHelper_Injected(){} // RVA: 0x7B371B0
        public void get_volume_Injected(){} // RVA: 0x7B37230
        public void set_volume_Injected(){} // RVA: 0x7B37280
        public void get_time_Injected(){} // RVA: 0x7B372E0
        public void set_time_Injected(){} // RVA: 0x7B37330
        public void get_timeSamples_Injected(){} // RVA: 0x7B37390
        public void set_timeSamples_Injected(){} // RVA: 0x7B373E0
        public void get_resource_Injected(){} // RVA: 0x7B37440
        public void set_resource_Injected(){} // RVA: 0x7B37490
        public void get_outputAudioMixerGroup_Injected(){} // RVA: 0x7B374F0
        public void set_outputAudioMixerGroup_Injected(){} // RVA: 0x7B37540
        public void SetScheduledStartTime_Injected(){} // RVA: 0x7B375A0
        public void SetScheduledEndTime_Injected(){} // RVA: 0x7B37600
        public void Pause_Injected(){} // RVA: 0x7B37660
        public void UnPause_Injected(){} // RVA: 0x7B376B0
        public void SkipToNextElementIfHasContainer_Injected(){} // RVA: 0x7B37700
        public void get_isPlaying_Injected(){} // RVA: 0x7B37750
        public void get_isContainerPlaying_Injected(){} // RVA: 0x7B377A0
        public void get_containerActivePlayables_Injected(){} // RVA: 0x7B377F0
        public void get_isVirtual_Injected(){} // RVA: 0x7B37840
        public void get_loop_Injected(){} // RVA: 0x7B37890
        public void set_loop_Injected(){} // RVA: 0x7B378E0
        public void get_ignoreListenerVolume_Injected(){} // RVA: 0x7B37940
        public void set_ignoreListenerVolume_Injected(){} // RVA: 0x7B37990
        public void get_playOnAwake_Injected(){} // RVA: 0x7B379F0
        public void set_playOnAwake_Injected(){} // RVA: 0x7B37A40
        public void get_ignoreListenerPause_Injected(){} // RVA: 0x7B37AA0
        public void set_ignoreListenerPause_Injected(){} // RVA: 0x7B37AF0
        public void get_velocityUpdateMode_Injected(){} // RVA: 0x7B37B50
        public void set_velocityUpdateMode_Injected(){} // RVA: 0x7B37BA0
        public void get_panStereo_Injected(){} // RVA: 0x7B37C00
        public void set_panStereo_Injected(){} // RVA: 0x7B37C50
        public void get_spatialBlend_Injected(){} // RVA: 0x7B37CB0
        public void set_spatialBlend_Injected(){} // RVA: 0x7B37D00
        public void get_spatialize_Injected(){} // RVA: 0x7B37D60
        public void set_spatialize_Injected(){} // RVA: 0x7B37DB0
        public void get_spatializePostEffects_Injected(){} // RVA: 0x7B37E10
        public void set_spatializePostEffects_Injected(){} // RVA: 0x7B37E60
        public void get_reverbZoneMix_Injected(){} // RVA: 0x7B37EC0
        public void set_reverbZoneMix_Injected(){} // RVA: 0x7B37F10
        public void get_bypassEffects_Injected(){} // RVA: 0x7B37F70
        public void set_bypassEffects_Injected(){} // RVA: 0x7B37FC0
        public void get_bypassListenerEffects_Injected(){} // RVA: 0x7B38020
        public void set_bypassListenerEffects_Injected(){} // RVA: 0x7B38070
        public void get_bypassReverbZones_Injected(){} // RVA: 0x7B380D0
        public void set_bypassReverbZones_Injected(){} // RVA: 0x7B38120
        public void get_dopplerLevel_Injected(){} // RVA: 0x7B38180
        public void set_dopplerLevel_Injected(){} // RVA: 0x7B381D0
        public void get_spread_Injected(){} // RVA: 0x7B38230
        public void set_spread_Injected(){} // RVA: 0x7B38280
        public void get_priority_Injected(){} // RVA: 0x7B382E0
        public void set_priority_Injected(){} // RVA: 0x7B38330
        public void get_mute_Injected(){} // RVA: 0x7B38390
        public void set_mute_Injected(){} // RVA: 0x7B383E0
        public void get_minDistance_Injected(){} // RVA: 0x7B38440
        public void set_minDistance_Injected(){} // RVA: 0x7B38490
        public void get_maxDistance_Injected(){} // RVA: 0x7B384F0
        public void set_maxDistance_Injected(){} // RVA: 0x7B38540
        public void get_rolloffMode_Injected(){} // RVA: 0x7B385A0
        public void set_rolloffMode_Injected(){} // RVA: 0x7B385F0
        public void SetSpatializerFloat_Injected(){} // RVA: 0x7B38650
        public void GetSpatializerFloat_Injected(){} // RVA: 0x7B386C0
        public void GetAmbisonicDecoderFloat_Injected(){} // RVA: 0x7B38730
        public void SetAmbisonicDecoderFloat_Injected(){} // RVA: 0x7B387A0
        public void GetAudioRandomContainerRuntimeMeterValue_Injected(){} // RVA: 0x7B38810
    }

    public class AudioSource[] : Array
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

    public class Avatar : Object
    {
        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7B14260
        public void get_isHuman(){} // RVA: 0x7B14300
        public void get_humanDescription(){} // RVA: 0x7B143A0
        public void GetAxisLength(){} // RVA: 0x7B14460
        public void GetPostRotation(){} // RVA: 0x7B14550
        public void Internal_GetAxisLength(){} // RVA: 0x7B14670
        public void Internal_GetPostRotation(){} // RVA: 0x7B14720
        public void get_isValid_Injected(){} // RVA: 0x7B147E0
        public void get_isHuman_Injected(){} // RVA: 0x7B14830
        public void get_humanDescription_Injected(){} // RVA: 0x7B14880
        public void Internal_GetAxisLength_Injected(){} // RVA: 0x7B148E0
        public void Internal_GetPostRotation_Injected(){} // RVA: 0x7B14940
    }

    public class AvatarBuilder : Object
    {
        // ── Methods ──
        public void BuildHumanAvatar(){} // RVA: 0x7B14A20
        public void BuildHumanAvatarInternal(){} // RVA: 0x7B14BF0
        public void BuildGenericAvatar(){} // RVA: 0x7B14CB0
        public void .ctor(){} // RVA: 0xB43310
        public void BuildHumanAvatarInternal_Injected(){} // RVA: 0x7B14F20
        public void BuildGenericAvatar_Injected(){} // RVA: 0x7B14F80
    }

    public class AvatarMask : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14FE0
        public void Internal_Create(){} // RVA: 0x7B15070
        public void GetHumanoidBodyPartActive(){} // RVA: 0x7B150C0
        public void SetHumanoidBodyPartActive(){} // RVA: 0x7B15170
        public void get_transformCount(){} // RVA: 0x7B15230
        public void set_transformCount(){} // RVA: 0x7B152D0
        public void AddTransformPath(){} // RVA: 0x7B15390
        public void RemoveTransformPath(){} // RVA: 0x7B154C0
        public void GetTransformPath(){} // RVA: 0x7B155E0
        public void SetTransformPath(){} // RVA: 0x7B15720
        public void GetTransformWeight(){} // RVA: 0x7B158B0
        public void SetTransformWeight(){} // RVA: 0x7B15960
        public void GetTransformActive(){} // RVA: 0x7B15A20
        public void SetTransformActive(){} // RVA: 0x7B15AD0
        public void GetHumanoidBodyPartActive_Injected(){} // RVA: 0x7B15BA0
        public void SetHumanoidBodyPartActive_Injected(){} // RVA: 0x7B15C00
        public void get_transformCount_Injected(){} // RVA: 0x7B15C70
        public void set_transformCount_Injected(){} // RVA: 0x7B15CC0
        public void AddTransformPath_Injected(){} // RVA: 0x7B15D20
        public void RemoveTransformPath_Injected(){} // RVA: 0x7B15D90
        public void GetTransformPath_Injected(){} // RVA: 0x7B15E00
        public void SetTransformPath_Injected(){} // RVA: 0x7B15E70
        public void GetTransformWeight_Injected(){} // RVA: 0x7B15EE0
        public void SetTransformWeight_Injected(){} // RVA: 0x7B15F40
    }

    public class AvatarMaskBodyPart[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AvatarMask[] : Array
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

    public class Avatar[] : Array
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

    public class Awaitable : Object
    {
        // ── Methods ──
        public void FromAsyncOperation(){} // RVA: 0x7BF5C50
        public void FromAsyncOperationInternal(){} // RVA: 0x7BF5D90
        public void GetAwaiter(){} // RVA: 0x18D7680
        public void SetExceptionFromNative(){} // RVA: 0x7BF5DE0
        public void RunContinuation(){} // RVA: 0x7BF6010
        public void AttachManagedGCHandleToNativeAwaitable(){} // RVA: 0x7BF6150
        public void ReleaseNativeAwaitable(){} // RVA: 0x7BF61B0
        public void CancelNativeAwaitable(){} // RVA: 0x7BF6200
        public void IsNativeAwaitableCompleted(){} // RVA: 0x7BF6250
        public void .ctor(){} // RVA: 0x7BF62A0
        public void NewManagedAwaitable(){} // RVA: 0x7BF62B0
        public void FromNativeAwaitableHandle(){} // RVA: 0x7BF63A0
        public void WireupCancellation(){} // RVA: 0x7BF6550
        public void MatchCompletionThreadAffinity(){} // RVA: 0x7BF6A60
        public void RaiseManagedCompletion(){} // RVA: 0x7BF6F80
        public void RunOrScheduleContinuation(){} // RVA: 0x7BF6DB0
        public void DoRunContinuationOnSynchonizationContext(){} // RVA: 0x7BF6F20
        public void PropagateExceptionAndRelease(){} // RVA: 0x7BF7160
        public void Cancel(){} // RVA: 0x7BF75C0
        public void get_IsCompletedNoLock(){} // RVA: 0x7BF7770
        public void get_IsLogicallyCompletedNoLock(){} // RVA: 0x7BF78E0
        public void get_IsCompleted(){} // RVA: 0x7BF7A20
        public void get_IsDettachedOrCompleted(){} // RVA: 0x7BF7C30
        public void CheckPointerValidity(){} // RVA: 0x7BF7E20
        public void SetContinuation(){} // RVA: 0x7BF7EC0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7BF8160
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0xB43310
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xDAC980
        public void ThrowIfNotMainThread(){} // RVA: 0x7BF8190
        public void EndOfFrameAsync(){} // RVA: 0x7BF8290
        public void EnsureDelayedCallWiredUp(){} // RVA: 0x7BF8450
        public void OnDelayedCallManagerCleared(){} // RVA: 0x7BF8770
        public void OnUpdate(){} // RVA: 0x7BF88B0
        public void OnEndOfFrame(){} // RVA: 0x7BF8920
        public void WireupNextFrameAndEndOfFrameCallbacks(){} // RVA: 0x7BF8990
        public void SetSynchronizationContext(){} // RVA: 0x7BF89E0
        public void .cctor(){} // RVA: 0x7BF8AC0
    }

    public class Awaitable[] : Array
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

    public class Awaitable`1 : Object
    {
        // ── Methods ──
        public void ContinueWith(){} // RVA: 0x894320
        public void GetResult(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
        public void GetAwaiter(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

}