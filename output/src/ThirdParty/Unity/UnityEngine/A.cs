// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 59
// Methods: 1211

namespace ThirdParty.Unity.UnityEngine
{
    public class AddComponentMenu : Attribute
    {
        public string m_AddComponentMenu; // 0x10
        public int m_Ordering; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x2
    }

    public class AnchoredJoint2D : Joint2D
    {
        public object anchor;
        public object connectedAnchor;
        public object autoConfigureConnectedAnchor;

        // ── Methods ──
        public void get_anchor(){} // RVA: 0x7FFAC9983300
        public void set_anchor(){} // RVA: 0x7FFAC9983360
        public void get_connectedAnchor(){} // RVA: 0x7FFAC99833C0
        public void set_connectedAnchor(){} // RVA: 0x7FFAC9983420
        public void get_autoConfigureConnectedAnchor(){} // RVA: 0x7FFAC9983480
        public void set_autoConfigureConnectedAnchor(){} // RVA: 0x7FFAC99834D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_anchor_Injected(){} // RVA: 0x7FFAC9983530
        public void set_anchor_Injected(){} // RVA: 0x7FFAC9983590
        public void get_connectedAnchor_Injected(){} // RVA: 0x7FFAC99835F0
        public void set_connectedAnchor_Injected(){} // RVA: 0x7FFAC9983650
    }

    public class AndroidJNI : Object
    {
        // ── Methods ──
        public void FindClass(){} // RVA: 0x7FFAC981EC90
        public void FromReflectedMethod(){} // RVA: 0x7FFAC981ECE0
        public void ExceptionOccurred(){} // RVA: 0x7FFAC981ED30
        public void ExceptionClear(){} // RVA: 0x7FFAC981ED80
        public void PushLocalFrame(){} // RVA: 0x7FFAC981EDD0
        public void PopLocalFrame(){} // RVA: 0x7FFAC981EE20
        public void NewGlobalRef(){} // RVA: 0x7FFAC981EE70
        public void QueueDeleteGlobalRef(){} // RVA: 0x7FFAC981EEC0
        public void NewWeakGlobalRef(){} // RVA: 0x7FFAC981EF10
        public void DeleteWeakGlobalRef(){} // RVA: 0x7FFAC981EF60
        public void NewLocalRef(){} // RVA: 0x7FFAC981EFB0
        public void DeleteLocalRef(){} // RVA: 0x7FFAC981F000
        public void IsSameObject(){} // RVA: 0x7FFAC981F050
        public void NewObject(){} // RVA: 0x7FFAC981F0B0
        public void NewObjectA(){} // RVA: 0x7FFAC981F150
        public void GetObjectClass(){} // RVA: 0x7FFAC981F1C0
        public void GetMethodID(){} // RVA: 0x7FFAC981F210
        public void GetFieldID(){} // RVA: 0x7FFAC981F280
        public void GetStaticMethodID(){} // RVA: 0x7FFAC981F2F0
        public void GetStaticFieldID(){} // RVA: 0x7FFAC981F360
        public void NewString(){} // RVA: 0x7FFAC981F3D0
        public void NewStringFromStr(){} // RVA: 0x7FFAC981F3D0
        public void GetStringChars(){} // RVA: 0x7FFAC981F420
        public void CallStringMethod(){} // RVA: 0x7FFAC981F570 | overloaded x2
        public void CallStringMethodUnsafe(){} // RVA: 0x7FFAC981F610
        public void CallObjectMethod(){} // RVA: 0x7FFAC981F680
        public void CallObjectMethodUnsafe(){} // RVA: 0x7FFAC981F720
        public void CallIntMethod(){} // RVA: 0x7FFAC981F890 | overloaded x2
        public void CallIntMethodUnsafe(){} // RVA: 0x7FFAC981F930
        public void CallBooleanMethod(){} // RVA: 0x7FFAC981F9A0
        public void CallBooleanMethodUnsafe(){} // RVA: 0x7FFAC981FA40
        public void CallShortMethod(){} // RVA: 0x7FFAC981FAB0
        public void CallShortMethodUnsafe(){} // RVA: 0x7FFAC981FB50
        public void CallSByteMethod(){} // RVA: 0x7FFAC981FBC0
        public void CallSByteMethodUnsafe(){} // RVA: 0x7FFAC981FC60
        public void CallCharMethod(){} // RVA: 0x7FFAC981FCD0
        public void CallCharMethodUnsafe(){} // RVA: 0x7FFAC981FD70
        public void CallFloatMethod(){} // RVA: 0x7FFAC981FDE0
        public void CallFloatMethodUnsafe(){} // RVA: 0x7FFAC981FE80
        public void CallDoubleMethod(){} // RVA: 0x7FFAC981FEF0
        public void CallDoubleMethodUnsafe(){} // RVA: 0x7FFAC981FF90
        public void CallLongMethod(){} // RVA: 0x7FFAC9820000
        public void CallLongMethodUnsafe(){} // RVA: 0x7FFAC98200A0
        public void CallVoidMethod(){} // RVA: 0x7FFAC9820110
        public void CallVoidMethodUnsafe(){} // RVA: 0x7FFAC98201B0
        public void GetStringField(){} // RVA: 0x7FFAC9820220
        public void GetObjectField(){} // RVA: 0x7FFAC9820280
        public void GetBooleanField(){} // RVA: 0x7FFAC98202E0
        public void GetSByteField(){} // RVA: 0x7FFAC9820340
        public void GetCharField(){} // RVA: 0x7FFAC98203A0
        public void GetShortField(){} // RVA: 0x7FFAC9820400
        public void GetIntField(){} // RVA: 0x7FFAC9820460
        public void GetLongField(){} // RVA: 0x7FFAC98204C0
        public void GetFloatField(){} // RVA: 0x7FFAC9820520
        public void GetDoubleField(){} // RVA: 0x7FFAC9820580
        public void CallStaticStringMethod(){} // RVA: 0x7FFAC98206E0 | overloaded x2
        public void CallStaticStringMethodUnsafe(){} // RVA: 0x7FFAC9820780
        public void CallStaticObjectMethod(){} // RVA: 0x7FFAC98207F0
        public void CallStaticObjectMethodUnsafe(){} // RVA: 0x7FFAC9820890
        public void CallStaticIntMethod(){} // RVA: 0x7FFAC9820900
        public void CallStaticIntMethodUnsafe(){} // RVA: 0x7FFAC98209A0
        public void CallStaticBooleanMethod(){} // RVA: 0x7FFAC9820A10
        public void CallStaticBooleanMethodUnsafe(){} // RVA: 0x7FFAC9820AB0
        public void CallStaticShortMethod(){} // RVA: 0x7FFAC9820B20
        public void CallStaticShortMethodUnsafe(){} // RVA: 0x7FFAC9820BC0
        public void CallStaticSByteMethod(){} // RVA: 0x7FFAC9820C30
        public void CallStaticSByteMethodUnsafe(){} // RVA: 0x7FFAC9820CD0
        public void CallStaticCharMethod(){} // RVA: 0x7FFAC9820D40
        public void CallStaticCharMethodUnsafe(){} // RVA: 0x7FFAC9820DE0
        public void CallStaticFloatMethod(){} // RVA: 0x7FFAC9820E50
        public void CallStaticFloatMethodUnsafe(){} // RVA: 0x7FFAC9820EF0
        public void CallStaticDoubleMethod(){} // RVA: 0x7FFAC9820F60
        public void CallStaticDoubleMethodUnsafe(){} // RVA: 0x7FFAC9821000
        public void CallStaticLongMethod(){} // RVA: 0x7FFAC9821070
        public void CallStaticLongMethodUnsafe(){} // RVA: 0x7FFAC9821110
        public void CallStaticVoidMethod(){} // RVA: 0x7FFAC9821180
        public void CallStaticVoidMethodUnsafe(){} // RVA: 0x7FFAC9821220
        public void GetStaticStringField(){} // RVA: 0x7FFAC9821290
        public void GetStaticObjectField(){} // RVA: 0x7FFAC98212F0
        public void GetStaticBooleanField(){} // RVA: 0x7FFAC9821350
        public void GetStaticSByteField(){} // RVA: 0x7FFAC98213B0
        public void GetStaticCharField(){} // RVA: 0x7FFAC9821410
        public void GetStaticShortField(){} // RVA: 0x7FFAC9821470
        public void GetStaticIntField(){} // RVA: 0x7FFAC98214D0
        public void GetStaticLongField(){} // RVA: 0x7FFAC9821530
        public void GetStaticFloatField(){} // RVA: 0x7FFAC9821590
        public void GetStaticDoubleField(){} // RVA: 0x7FFAC98215F0
        public void ToBooleanArray(){} // RVA: 0x7FFAC9821650
        public void ToByteArray(){} // RVA: 0x7FFAC98216A0
        public void ToSByteArray(){} // RVA: 0x7FFAC9821780 | overloaded x2
        public void ToCharArray(){} // RVA: 0x7FFAC9821870 | overloaded x2
        public void ToShortArray(){} // RVA: 0x7FFAC9821960 | overloaded x2
        public void ToIntArray(){} // RVA: 0x7FFAC9821A50 | overloaded x2
        public void ToLongArray(){} // RVA: 0x7FFAC9821B40 | overloaded x2
        public void ToFloatArray(){} // RVA: 0x7FFAC9821C30 | overloaded x2
        public void ToDoubleArray(){} // RVA: 0x7FFAC9821D20 | overloaded x2
        public void ToObjectArray(){} // RVA: 0x7FFAC9821DF0 | overloaded x2
        public void FromBooleanArray(){} // RVA: 0x7FFAC9821E90
        public void FromByteArray(){} // RVA: 0x7FFAC9821EE0
        public void FromSByteArray(){} // RVA: 0x7FFAC9821F30
        public void FromCharArray(){} // RVA: 0x7FFAC9821F80
        public void FromShortArray(){} // RVA: 0x7FFAC9821FD0
        public void FromIntArray(){} // RVA: 0x7FFAC9822020
        public void FromLongArray(){} // RVA: 0x7FFAC9822070
        public void FromFloatArray(){} // RVA: 0x7FFAC98220C0
        public void FromDoubleArray(){} // RVA: 0x7FFAC9822110
        public void GetArrayLength(){} // RVA: 0x7FFAC9822160
        public void NewFloatArray(){} // RVA: 0x7FFAC98221B0
        public void NewObjectArray(){} // RVA: 0x7FFAC9822200
        public void GetObjectArrayElement(){} // RVA: 0x7FFAC9822270
        public void SetObjectArrayElement(){} // RVA: 0x7FFAC98222D0
    }

    public class AndroidJNIHelper : Object
    {
        // ── Methods ──
        public void GetConstructorID(){} // RVA: 0x7FFAC981CDE0 | overloaded x2
        public void GetMethodID(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void GetFieldID(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CreateJavaRunnable(){} // RVA: 0x7FFAC9818CF0
        public void CreateJavaProxy(){} // RVA: 0x7FFAC981E590
        public void CreateJNIArgArray(){} // RVA: 0x7FFAC981E7E0
        public void DeleteJNIArgArray(){} // RVA: 0x7FFAC981E910
        public void ConvertFromJNIArray(){} // RVA: 0x7FFAC2E8DC40
        public void Box(){} // RVA: 0x7FFAC981EC20 | overloaded x3
    }

    public class AndroidJNISafe : Object
    {
        // ── Methods ──
        public void CheckException(){} // RVA: 0x7FFAC9822340
        public void QueueDeleteGlobalRef(){} // RVA: 0x7FFAC9822670
        public void DeleteWeakGlobalRef(){} // RVA: 0x7FFAC98226D0
        public void DeleteLocalRef(){} // RVA: 0x7FFAC9822730
        public void NewString(){} // RVA: 0x7FFAC9822790
        public void GetStringChars(){} // RVA: 0x7FFAC9822820
        public void GetObjectClass(){} // RVA: 0x7FFAC98228B0
        public void GetStaticMethodID(){} // RVA: 0x7FFAC9822940
        public void GetMethodID(){} // RVA: 0x7FFAC9822990
        public void GetFieldID(){} // RVA: 0x7FFAC98229E0
        public void GetStaticFieldID(){} // RVA: 0x7FFAC9822A90
        public void FromReflectedMethod(){} // RVA: 0x7FFAC9822B40
        public void FindClass(){} // RVA: 0x7FFAC9822BD0
        public void NewObject(){} // RVA: 0x7FFAC9822C60
        public void GetStaticObjectField(){} // RVA: 0x7FFAC9822D50
        public void GetStaticStringField(){} // RVA: 0x7FFAC9822DF0
        public void GetStaticCharField(){} // RVA: 0x7FFAC9822E90
        public void GetStaticDoubleField(){} // RVA: 0x7FFAC9822F30
        public void GetStaticFloatField(){} // RVA: 0x7FFAC9822FE0
        public void GetStaticLongField(){} // RVA: 0x7FFAC9823090
        public void GetStaticShortField(){} // RVA: 0x7FFAC9823130
        public void GetStaticSByteField(){} // RVA: 0x7FFAC98231D0
        public void GetStaticBooleanField(){} // RVA: 0x7FFAC9823270
        public void GetStaticIntField(){} // RVA: 0x7FFAC9823310
        public void CallStaticVoidMethod(){} // RVA: 0x7FFAC9823440 | overloaded x2
        public void CallStaticObjectMethod(){} // RVA: 0x7FFAC98235B0 | overloaded x2
        public void CallStaticStringMethod(){} // RVA: 0x7FFAC9823730 | overloaded x2
        public void CallStaticCharMethod(){} // RVA: 0x7FFAC9823820
        public void CallStaticDoubleMethod(){} // RVA: 0x7FFAC9823910
        public void CallStaticFloatMethod(){} // RVA: 0x7FFAC9823A10
        public void CallStaticLongMethod(){} // RVA: 0x7FFAC9823B10
        public void CallStaticShortMethod(){} // RVA: 0x7FFAC9823C00
        public void CallStaticSByteMethod(){} // RVA: 0x7FFAC9823CF0
        public void CallStaticBooleanMethod(){} // RVA: 0x7FFAC9823DE0
        public void CallStaticIntMethod(){} // RVA: 0x7FFAC9823ED0
        public void GetObjectField(){} // RVA: 0x7FFAC9823FC0
        public void GetStringField(){} // RVA: 0x7FFAC9824060
        public void GetCharField(){} // RVA: 0x7FFAC9824100
        public void GetDoubleField(){} // RVA: 0x7FFAC98241A0
        public void GetFloatField(){} // RVA: 0x7FFAC9824250
        public void GetLongField(){} // RVA: 0x7FFAC9824300
        public void GetShortField(){} // RVA: 0x7FFAC98243A0
        public void GetSByteField(){} // RVA: 0x7FFAC9824440
        public void GetBooleanField(){} // RVA: 0x7FFAC98244E0
        public void GetIntField(){} // RVA: 0x7FFAC9824580
        public void CallVoidMethod(){} // RVA: 0x7FFAC9824620
        public void CallObjectMethod(){} // RVA: 0x7FFAC9824790 | overloaded x2
        public void CallStringMethod(){} // RVA: 0x7FFAC9824880
        public void CallCharMethod(){} // RVA: 0x7FFAC9824970
        public void CallDoubleMethod(){} // RVA: 0x7FFAC9824A60
        public void CallFloatMethod(){} // RVA: 0x7FFAC9824B60
        public void CallLongMethod(){} // RVA: 0x7FFAC9824C60
        public void CallShortMethod(){} // RVA: 0x7FFAC9824D50
        public void CallSByteMethod(){} // RVA: 0x7FFAC9824E40
        public void CallBooleanMethod(){} // RVA: 0x7FFAC9824F30
        public void CallIntMethod(){} // RVA: 0x7FFAC9825020
        public void FromCharArray(){} // RVA: 0x7FFAC9825110
        public void FromDoubleArray(){} // RVA: 0x7FFAC98251A0
        public void FromFloatArray(){} // RVA: 0x7FFAC9825230
        public void FromLongArray(){} // RVA: 0x7FFAC98252C0
        public void FromShortArray(){} // RVA: 0x7FFAC9825350
        public void FromByteArray(){} // RVA: 0x7FFAC98253E0
        public void FromSByteArray(){} // RVA: 0x7FFAC9825470
        public void FromBooleanArray(){} // RVA: 0x7FFAC9825500
        public void FromIntArray(){} // RVA: 0x7FFAC9825590
        public void ToObjectArray(){} // RVA: 0x7FFAC9825620
        public void ToCharArray(){} // RVA: 0x7FFAC98256E0
        public void ToDoubleArray(){} // RVA: 0x7FFAC9825790
        public void ToFloatArray(){} // RVA: 0x7FFAC9825840
        public void ToLongArray(){} // RVA: 0x7FFAC98258F0
        public void ToShortArray(){} // RVA: 0x7FFAC98259A0
        public void ToByteArray(){} // RVA: 0x7FFAC9825A50
        public void ToSByteArray(){} // RVA: 0x7FFAC9825AE0
        public void ToBooleanArray(){} // RVA: 0x7FFAC9825B90
        public void ToIntArray(){} // RVA: 0x7FFAC9825C20
        public void GetObjectArrayElement(){} // RVA: 0x7FFAC9825CD0
        public void GetArrayLength(){} // RVA: 0x7FFAC9825D70
    }

    public class AndroidJavaClass : AndroidJavaObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9817960 | overloaded x2
        public void _AndroidJavaClass(){} // RVA: 0x7FFAC98177A0
    }

    public class AndroidJavaException : Exception
    {
        public string StackTrace; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9814FF0
        public void get_StackTrace(){} // RVA: 0x7FFAC98150C0
    }

    public class AndroidJavaObject : Object
    {
        public bool enableDebugPrints;
        public UnityEngine.GlobalJavaObjectRef m_jobject; // 0x10
        public UnityEngine.GlobalJavaObjectRef m_jclass; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAC98173A0 | overloaded x2
        public void Call(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void GetStatic(){} // RVA: 0x7FFAC2E8DC40
        public void GetRawObject(){} // RVA: 0x7FFAC9816CE0
        public void GetRawClass(){} // RVA: 0x7FFAC8804860
        public void CloneReference(){} // RVA: 0x7FFAC9816D00
        public void CallStatic(){} // RVA: 0x7FFAC2E8DC40
        public void DebugPrint(){} // RVA: 0x7FFAC9816F20
        public void _AndroidJavaObject(){} // RVA: 0x7FFAC9817140 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8371850
        public void _Call(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void _Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void _CallStatic(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void _GetStatic(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AndroidJavaObjectDeleteLocalRef(){} // RVA: 0x7FFAC9817630
        public void AndroidJavaClassDeleteLocalRef(){} // RVA: 0x7FFAC98176E0
        public void FromJavaArrayDeleteLocalRef(){} // RVA: 0x7FFAC2E8DC40
        public void _GetRawObject(){} // RVA: 0x7FFAC9816CE0
        public void _GetRawClass(){} // RVA: 0x7FFAC8804860
    }

    public class AndroidJavaProxy : Object
    {
        public UnityEngine.AndroidJavaClass javaInterface; // 0x10
        public UIntPtr proxyObject; // 0x18
        public UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        public UIntPtr s_HashCodeMethodID; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98154B0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC9815510
        public void Invoke(){} // RVA: 0x7FFAC9816180 | overloaded x3
        public void equals(){} // RVA: 0x7FFAC98165A0
        public void hashCode(){} // RVA: 0x7FFAC9816620
        public void toString(){} // RVA: 0x7FFAC9816710
        public void GetProxyObject(){} // RVA: 0x7FFAC9816770
        public void GetRawProxy(){} // RVA: 0x7FFAC9816790
        public void .cctor(){} // RVA: 0x7FFAC98168A0
    }

    public class AndroidJavaRunnable : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class AndroidJavaRunnableProxy : AndroidJavaProxy
    {
        public UnityEngine.AndroidJavaRunnable mRunnable; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9815220
        public void run(){} // RVA: 0x7FFAC98152E0
        public void Invoke(){} // RVA: 0x7FFAC9815310
    }

    public class AndroidReflection : Object
    {
        public UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass;
        public UIntPtr s_ReflectionHelperGetConstructorID; // 0x8
        public UIntPtr s_ReflectionHelperGetMethodID; // 0x10
        public UIntPtr s_ReflectionHelperGetFieldID; // 0x18
        public UIntPtr s_ReflectionHelperGetFieldSignature; // 0x20
        public UIntPtr s_ReflectionHelperNewProxyInstance; // 0x28
        public UIntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
        public UIntPtr s_FieldGetDeclaringClass; // 0x38

        // ── Methods ──
        public void IsPrimitive(){} // RVA: 0x7FFAC8778020
        public void IsAssignableFrom(){} // RVA: 0x7FFAC9817AD0
        public void GetStaticMethodID(){} // RVA: 0x7FFAC9817B00
        public void GetMethodID(){} // RVA: 0x7FFAC9817B90
        public void GetConstructorMember(){} // RVA: 0x7FFAC9817C20
        public void GetMethodMember(){} // RVA: 0x7FFAC9817E60
        public void GetFieldMember(){} // RVA: 0x7FFAC9818170
        public void GetFieldClass(){} // RVA: 0x7FFAC98183A0
        public void GetFieldSignature(){} // RVA: 0x7FFAC9818440
        public void NewProxyInstance(){} // RVA: 0x7FFAC9818560
        public void SetNativeExceptionOnProxy(){} // RVA: 0x7FFAC98186B0
        public void .cctor(){} // RVA: 0x7FFAC9818810
    }

    public class Animation : Behaviour
    {
        public object clip;
        public object playAutomatically;
        public object wrapMode;
        public object isPlaying;
        public object Item;
        public object animatePhysics;
        public object animateOnlyIfVisible;
        public object cullingType;
        public object localBounds;

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFAC9825EC0
        public void set_clip(){} // RVA: 0x7FFAC9825F10
        public void get_playAutomatically(){} // RVA: 0x7FFAC9825F70
        public void set_playAutomatically(){} // RVA: 0x7FFAC9825FC0
        public void get_wrapMode(){} // RVA: 0x7FFAC9826020
        public void set_wrapMode(){} // RVA: 0x7FFAC9826070
        public void Stop(){} // RVA: 0x7FFAC9826120 | overloaded x2
        public void StopNamed(){} // RVA: 0x7FFAC9826120
        public void Rewind(){} // RVA: 0x7FFAC98261D0 | overloaded x2
        public void RewindNamed(){} // RVA: 0x7FFAC98261D0
        public void Sample(){} // RVA: 0x7FFAC9826230
        public void get_isPlaying(){} // RVA: 0x7FFAC9826280
        public void IsPlaying(){} // RVA: 0x7FFAC98262D0
        public void get_Item(){} // RVA: 0x7FFAC9826330
        public void Play(){} // RVA: 0x7FFAC9826E60 | overloaded x6
        public void PlayDefaultAnimation(){} // RVA: 0x7FFAC98263F0
        public void CrossFade(){} // RVA: 0x7FFAC9826620 | overloaded x3
        public void Blend(){} // RVA: 0x7FFAC9826790 | overloaded x3
        public void CrossFadeQueued(){} // RVA: 0x7FFAC98269A0 | overloaded x4
        public void PlayQueued(){} // RVA: 0x7FFAC9826B20 | overloaded x3
        public void AddClip(){} // RVA: 0x7FFAC9826CC0 | overloaded x3
        public void RemoveClip(){} // RVA: 0x7FFAC9826DB0 | overloaded x2
        public void RemoveClipNamed(){} // RVA: 0x7FFAC9826DB0
        public void GetClipCount(){} // RVA: 0x7FFAC9826E10
        public void SyncLayer(){} // RVA: 0x7FFAC9826E70
        public void GetEnumerator(){} // RVA: 0x7FFAC9826ED0
        public void GetState(){} // RVA: 0x7FFAC9826330
        public void GetStateAtIndex(){} // RVA: 0x7FFAC9826F70
        public void GetStateCount(){} // RVA: 0x7FFAC9826FD0
        public void GetClip(){} // RVA: 0x7FFAC9827020
        public void get_animatePhysics(){} // RVA: 0x7FFAC98270E0
        public void set_animatePhysics(){} // RVA: 0x7FFAC9827130
        public void get_animateOnlyIfVisible(){} // RVA: 0x7FFAC9827190
        public void set_animateOnlyIfVisible(){} // RVA: 0x7FFAC98271E0
        public void get_cullingType(){} // RVA: 0x7FFAC9827240
        public void set_cullingType(){} // RVA: 0x7FFAC9827290
        public void get_localBounds(){} // RVA: 0x7FFAC98272F0
        public void set_localBounds(){} // RVA: 0x7FFAC9827360
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_localBounds_Injected(){} // RVA: 0x7FFAC98273C0
        public void set_localBounds_Injected(){} // RVA: 0x7FFAC9827420
    }

    public class AnimationClip : Motion
    {
        public object length;
        public object frameRate;
        public object wrapMode;
        public object localBounds;
        public object legacy;
        public object humanMotion;
        public object empty;
        public object hasGenericRootTransform;
        public object hasMotionFloatCurves;
        public object hasMotionCurves;
        public object hasRootCurves;
        public object hasRootMotion;
        public object events;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9827FD0
        public void Internal_CreateAnimationClip(){} // RVA: 0x7FFAC9828060
        public void SampleAnimation(){} // RVA: 0x7FFAC9828170 | overloaded x2
        public void get_length(){} // RVA: 0x7FFAC98281F0
        public void get_frameRate(){} // RVA: 0x7FFAC9828240
        public void set_frameRate(){} // RVA: 0x7FFAC9828290
        public void SetCurve(){} // RVA: 0x7FFAC98282F0
        public void EnsureQuaternionContinuity(){} // RVA: 0x7FFAC9828380
        public void ClearCurves(){} // RVA: 0x7FFAC98283D0
        public void get_wrapMode(){} // RVA: 0x7FFAC9828420
        public void set_wrapMode(){} // RVA: 0x7FFAC9828470
        public void get_localBounds(){} // RVA: 0x7FFAC98284D0
        public void set_localBounds(){} // RVA: 0x7FFAC9828540
        public void get_legacy(){} // RVA: 0x7FFAC98285A0
        public void set_legacy(){} // RVA: 0x7FFAC98285F0
        public void get_humanMotion(){} // RVA: 0x7FFAC9828650
        public void get_empty(){} // RVA: 0x7FFAC98286A0
        public void get_hasGenericRootTransform(){} // RVA: 0x7FFAC98286F0
        public void get_hasMotionFloatCurves(){} // RVA: 0x7FFAC9828740
        public void get_hasMotionCurves(){} // RVA: 0x7FFAC9828790
        public void get_hasRootCurves(){} // RVA: 0x7FFAC98287E0
        public void get_hasRootMotion(){} // RVA: 0x7FFAC9828830
        public void get_events(){} // RVA: 0x7FFAC9828880
        public void set_events(){} // RVA: 0x7FFAC9828930
        public void SetEventsInternal(){} // RVA: 0x7FFAC9828930
        public void GetEventsInternal(){} // RVA: 0x7FFAC9828990
        public void get_localBounds_Injected(){} // RVA: 0x7FFAC98289E0
        public void set_localBounds_Injected(){} // RVA: 0x7FFAC9828A40
    }

    public class AnimationCurve : Object
    {
        public UIntPtr keys; // 0x10

        // ── Methods ──
        public void Internal_Destroy(){} // RVA: 0x7FFAC9851CF0
        public void Internal_Create(){} // RVA: 0x7FFAC9851D40
        public void Internal_Equals(){} // RVA: 0x7FFAC9851D90
        public void Internal_CopyFrom(){} // RVA: 0x7FFAC9851DF0
        public void Finalize(){} // RVA: 0x7FFAC9851E50
        public void Evaluate(){} // RVA: 0x7FFAC9851ED0
        public void get_keys(){} // RVA: 0x7FFAC9851F30
        public void set_keys(){} // RVA: 0x7FFAC9851F80
        public void AddKey(){} // RVA: 0x7FFAC9852050 | overloaded x2
        public void AddKey_Internal(){} // RVA: 0x7FFAC98520C0
        public void MoveKey(){} // RVA: 0x7FFAC9852120
        public void ClearKeys(){} // RVA: 0x7FFAC9852190
        public void RemoveKey(){} // RVA: 0x7FFAC98521E0
        public void get_Item(){} // RVA: 0x7FFAC9852240
        public void get_length(){} // RVA: 0x7FFAC98522F0
        public void SetKeys(){} // RVA: 0x7FFAC9851F80
        public void GetKey(){} // RVA: 0x7FFAC9852340
        public void GetKeys(){} // RVA: 0x7FFAC9851F30
        public void GetHashCode(){} // RVA: 0x7FFAC98523C0
        public void SmoothTangents(){} // RVA: 0x7FFAC9852410
        public void Constant(){} // RVA: 0x7FFAC9852480
        public void Linear(){} // RVA: 0x7FFAC98524A0
        public void EaseInOut(){} // RVA: 0x7FFAC9852690
        public void get_preWrapMode(){} // RVA: 0x7FFAC9852850
        public void set_preWrapMode(){} // RVA: 0x7FFAC98528A0
        public void get_postWrapMode(){} // RVA: 0x7FFAC9852900
        public void set_postWrapMode(){} // RVA: 0x7FFAC9852950
        public void .ctor(){} // RVA: 0x7FFAC9852A10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC9852B80 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAC9852CF0
        public void AddKey_Internal_Injected(){} // RVA: 0x7FFAC9852D60
        public void MoveKey_Injected(){} // RVA: 0x7FFAC9852DC0
        public void GetKey_Injected(){} // RVA: 0x7FFAC9852E30
    }

    public class AnimationEvent : Object
    {
        public float stringParameter; // 0x10
        public string functionName; // 0x18
        public string m_StringParameter; // 0x20
        public UnityEngine.Object m_ObjectReferenceParameter; // 0x28
        public float m_FloatParameter; // 0x30
        public int m_IntParameter; // 0x34
        public int m_MessageOptions; // 0x38
        public 0x6B29C3E0 m_Source; // 0x3C
        public UnityEngine.AnimationState m_StateSender; // 0x40
        public UnityEngine.AnimatorStateInfo m_AnimatorStateInfo; // 0x48
        public UnityEngine.AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9827E30
        public void get_stringParameter(){} // RVA: 0x7FFAC91BAEE0
        public void get_functionName(){} // RVA: 0x7FFAC58A1130
    }

    public class AnimationState : TrackedReference
    {
        public object enabled;
        public object weight;
        public object wrapMode;
        public object time;
        public object normalizedTime;
        public object speed;
        public object normalizedSpeed;
        public object length;
        public object layer;
        public object clip;
        public object name;
        public object blendMode;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC9827570
        public void set_enabled(){} // RVA: 0x7FFAC98275C0
        public void get_weight(){} // RVA: 0x7FFAC9827620
        public void set_weight(){} // RVA: 0x7FFAC9827670
        public void get_wrapMode(){} // RVA: 0x7FFAC98276D0
        public void set_wrapMode(){} // RVA: 0x7FFAC9827720
        public void get_time(){} // RVA: 0x7FFAC9827780
        public void set_time(){} // RVA: 0x7FFAC98277D0
        public void get_normalizedTime(){} // RVA: 0x7FFAC9827830
        public void set_normalizedTime(){} // RVA: 0x7FFAC9827880
        public void get_speed(){} // RVA: 0x7FFAC98278E0
        public void set_speed(){} // RVA: 0x7FFAC9827930
        public void get_normalizedSpeed(){} // RVA: 0x7FFAC9827990
        public void set_normalizedSpeed(){} // RVA: 0x7FFAC98279E0
        public void get_length(){} // RVA: 0x7FFAC9827A40
        public void get_layer(){} // RVA: 0x7FFAC9827A90
        public void set_layer(){} // RVA: 0x7FFAC9827AE0
        public void get_clip(){} // RVA: 0x7FFAC9827B40
        public void get_name(){} // RVA: 0x7FFAC9827B90
        public void set_name(){} // RVA: 0x7FFAC9827BE0
        public void get_blendMode(){} // RVA: 0x7FFAC9827C40
        public void set_blendMode(){} // RVA: 0x7FFAC9827C90
        public void AddMixingTransform(){} // RVA: 0x7FFAC9827D60 | overloaded x2
        public void RemoveMixingTransform(){} // RVA: 0x7FFAC9827DD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Animator : Behaviour
    {
        public object isOptimizable;
        public object isHuman;
        public object hasRootMotion;
        public object isRootPositionOrRotationControlledByCurves;
        public object humanScale;
        public object isInitialized;
        public object deltaPosition;
        public object deltaRotation;
        public object velocity;
        public object angularVelocity;
        public object rootPosition;
        public object rootRotation;
        public object applyRootMotion;
        public object noDiscreteIntBindings;
        public object linearVelocityBlending;
        public object animatePhysics;
        public object updateMode;
        public object hasTransformHierarchy;
        public object allowConstantClipSamplingOptimization;
        public object gravityWeight;
        public object bodyPosition;
        public object bodyPositionInternal;
        public object bodyRotation;
        public object bodyRotationInternal;
        public object stabilizeFeet;
        public object layerCount;
        public object parameters;
        public object parameterCount;
        public object feetPivotActive;
        public object pivotWeight;
        public object pivotPosition;
        public object isMatchingTarget;
        public object speed;
        public object targetPosition;
        public object targetRotation;
        public object avatarRoot;
        public object cullingMode;
        public object playbackTime;
        public object recorderStartTime;
        public object recorderStopTime;
        public object recorderMode;
        public object runtimeAnimatorController;
        public object hasBoundPlayables;
        public object avatar;
        public object playableGraph;
        public object layersAffectMassCenter;
        public object leftFeetBottomHeight;
        public object rightFeetBottomHeight;
        public object supportsOnAnimatorMove;
        public object logWarnings;
        public object fireEvents;
        public object keepAnimatorControllerStateOnDisable;
        public object keepAnimatorStateOnDisable;
        public object writeDefaultValuesOnDisable;

        // ── Methods ──
        public void get_isOptimizable(){} // RVA: 0x7FFAC9828DB0
        public void get_isHuman(){} // RVA: 0x7FFAC9828E00
        public void get_hasRootMotion(){} // RVA: 0x7FFAC9828E50
        public void get_isRootPositionOrRotationControlledByCurves(){} // RVA: 0x7FFAC9828EA0
        public void get_humanScale(){} // RVA: 0x7FFAC9828EF0
        public void get_isInitialized(){} // RVA: 0x7FFAC9828F40
        public void GetFloat(){} // RVA: 0x7FFAC9828FF0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFAC98291B0 | overloaded x4
        public void GetBool(){} // RVA: 0x7FFAC9829290 | overloaded x2
        public void SetBool(){} // RVA: 0x7FFAC9829360 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFAC9829430 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFAC9829500 | overloaded x2
        public void SetTrigger(){} // RVA: 0x7FFAC98295D0 | overloaded x2
        public void ResetTrigger(){} // RVA: 0x7FFAC9829690 | overloaded x2
        public void IsParameterControlledByCurve(){} // RVA: 0x7FFAC9829750 | overloaded x2
        public void get_deltaPosition(){} // RVA: 0x7FFAC98297B0
        public void get_deltaRotation(){} // RVA: 0x7FFAC9829820
        public void get_velocity(){} // RVA: 0x7FFAC9829890
        public void get_angularVelocity(){} // RVA: 0x7FFAC9829900
        public void get_rootPosition(){} // RVA: 0x7FFAC9829970
        public void set_rootPosition(){} // RVA: 0x7FFAC98299E0
        public void get_rootRotation(){} // RVA: 0x7FFAC9829A40
        public void set_rootRotation(){} // RVA: 0x7FFAC9829AB0
        public void get_applyRootMotion(){} // RVA: 0x7FFAC9829B10
        public void set_applyRootMotion(){} // RVA: 0x7FFAC9829B60
        public void get_noDiscreteIntBindings(){} // RVA: 0x7FFAC9829BC0
        public void set_noDiscreteIntBindings(){} // RVA: 0x7FFAC9829C10
        public void get_linearVelocityBlending(){} // RVA: 0x7FFAC9829C70
        public void set_linearVelocityBlending(){} // RVA: 0x7FFAC9829CC0
        public void get_animatePhysics(){} // RVA: 0x7FFAC9829D20
        public void set_animatePhysics(){} // RVA: 0x7FFAC9829D80
        public void get_updateMode(){} // RVA: 0x7FFAC9829DF0
        public void set_updateMode(){} // RVA: 0x7FFAC9829E40
        public void get_hasTransformHierarchy(){} // RVA: 0x7FFAC9829EA0
        public void get_allowConstantClipSamplingOptimization(){} // RVA: 0x7FFAC9829EF0
        public void set_allowConstantClipSamplingOptimization(){} // RVA: 0x7FFAC9829F40
        public void get_gravityWeight(){} // RVA: 0x7FFAC9829FA0
        public void get_bodyPosition(){} // RVA: 0x7FFAC9829FF0
        public void set_bodyPosition(){} // RVA: 0x7FFAC982A090
        public void get_bodyPositionInternal(){} // RVA: 0x7FFAC982A110
        public void set_bodyPositionInternal(){} // RVA: 0x7FFAC982A180
        public void get_bodyRotation(){} // RVA: 0x7FFAC982A1E0
        public void set_bodyRotation(){} // RVA: 0x7FFAC982A270
        public void get_bodyRotationInternal(){} // RVA: 0x7FFAC982A2E0
        public void set_bodyRotationInternal(){} // RVA: 0x7FFAC982A350
        public void GetIKPosition(){} // RVA: 0x7FFAC982A3B0
        public void GetGoalPosition(){} // RVA: 0x7FFAC982A450
        public void SetIKPosition(){} // RVA: 0x7FFAC982A4D0
        public void SetGoalPosition(){} // RVA: 0x7FFAC982A560
        public void GetIKRotation(){} // RVA: 0x7FFAC982A5D0
        public void GetGoalRotation(){} // RVA: 0x7FFAC982A670
        public void SetIKRotation(){} // RVA: 0x7FFAC982A6F0
        public void SetGoalRotation(){} // RVA: 0x7FFAC982A770
        public void GetIKPositionWeight(){} // RVA: 0x7FFAC982A7E0
        public void GetGoalWeightPosition(){} // RVA: 0x7FFAC982A850
        public void SetIKPositionWeight(){} // RVA: 0x7FFAC982A8B0
        public void SetGoalWeightPosition(){} // RVA: 0x7FFAC982A930
        public void GetIKRotationWeight(){} // RVA: 0x7FFAC982A9A0
        public void GetGoalWeightRotation(){} // RVA: 0x7FFAC982AA10
        public void SetIKRotationWeight(){} // RVA: 0x7FFAC982AA70
        public void SetGoalWeightRotation(){} // RVA: 0x7FFAC982AAF0
        public void GetIKHintPosition(){} // RVA: 0x7FFAC982AB60
        public void GetHintPosition(){} // RVA: 0x7FFAC982AC00
        public void SetIKHintPosition(){} // RVA: 0x7FFAC982AC80
        public void SetHintPosition(){} // RVA: 0x7FFAC982AD10
        public void GetIKHintPositionWeight(){} // RVA: 0x7FFAC982AD80
        public void GetHintWeightPosition(){} // RVA: 0x7FFAC982ADF0
        public void SetIKHintPositionWeight(){} // RVA: 0x7FFAC982AE50
        public void SetHintWeightPosition(){} // RVA: 0x7FFAC982AED0
        public void SetLookAtPosition(){} // RVA: 0x7FFAC982AF40
        public void SetLookAtPositionInternal(){} // RVA: 0x7FFAC982AFC0
        public void SetLookAtWeight(){} // RVA: 0x7FFAC982B2A0 | overloaded x5
        public void SetLookAtWeightInternal(){} // RVA: 0x7FFAC982B300
        public void SetBoneLocalRotation(){} // RVA: 0x7FFAC982B390
        public void SetBoneLocalRotationInternal(){} // RVA: 0x7FFAC982B450
        public void GetBehaviour(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ConvertStateMachineBehaviour(){} // RVA: 0x7FFAC2C58F80
        public void GetBehaviours(){} // RVA: 0x7FFAC982B580 | overloaded x2
        public void InternalGetBehaviours(){} // RVA: 0x7FFAC982B520
        public void InternalGetBehavioursByKey(){} // RVA: 0x7FFAC982B6C0
        public void get_stabilizeFeet(){} // RVA: 0x7FFAC982B740
        public void set_stabilizeFeet(){} // RVA: 0x7FFAC982B790
        public void get_layerCount(){} // RVA: 0x7FFAC982B7F0
        public void GetLayerName(){} // RVA: 0x7FFAC982B840
        public void GetLayerIndex(){} // RVA: 0x7FFAC982B8A0
        public void GetLayerWeight(){} // RVA: 0x7FFAC982B900
        public void SetLayerWeight(){} // RVA: 0x7FFAC982B960
        public void GetAnimatorStateInfo(){} // RVA: 0x7FFAC982B9D0
        public void GetCurrentAnimatorStateInfo(){} // RVA: 0x7FFAC982BA50
        public void GetNextAnimatorStateInfo(){} // RVA: 0x7FFAC982BB00
        public void GetAnimatorTransitionInfo(){} // RVA: 0x7FFAC982BC20 | overloaded x2
        public void GetAnimatorClipInfoCount(){} // RVA: 0x7FFAC982BCC0
        public void GetCurrentAnimatorClipInfoCount(){} // RVA: 0x7FFAC982BD30
        public void GetNextAnimatorClipInfoCount(){} // RVA: 0x7FFAC982BD90
        public void GetCurrentAnimatorClipInfo(){} // RVA: 0x7FFAC982BEB0 | overloaded x2
        public void GetNextAnimatorClipInfo(){} // RVA: 0x7FFAC982BFB0 | overloaded x2
        public void GetAnimatorClipInfoInternal(){} // RVA: 0x7FFAC982BF30
        public void IsInTransition(){} // RVA: 0x7FFAC982C030
        public void get_parameters(){} // RVA: 0x7FFAC982C090
        public void get_parameterCount(){} // RVA: 0x7FFAC982C0E0
        public void GetParameterInternal(){} // RVA: 0x7FFAC982C130
        public void GetParameter(){} // RVA: 0x7FFAC982C190
        public void get_feetPivotActive(){} // RVA: 0x7FFAC982C280
        public void set_feetPivotActive(){} // RVA: 0x7FFAC982C2D0
        public void get_pivotWeight(){} // RVA: 0x7FFAC982C330
        public void get_pivotPosition(){} // RVA: 0x7FFAC982C380
        public void MatchTarget(){} // RVA: 0x7FFAC982C650 | overloaded x4
        public void InterruptMatchTarget(){} // RVA: 0x7FFAC982C780 | overloaded x2
        public void get_isMatchingTarget(){} // RVA: 0x7FFAC982C7E0
        public void get_speed(){} // RVA: 0x7FFAC982C830
        public void set_speed(){} // RVA: 0x7FFAC982C880
        public void ForceStateNormalizedTime(){} // RVA: 0x7FFAC982C8E0
        public void CrossFadeInFixedTime(){} // RVA: 0x7FFAC982CE30 | overloaded x8
        public void WriteDefaultValues(){} // RVA: 0x7FFAC982CEB0
        public void CrossFade(){} // RVA: 0x7FFAC982D210 | overloaded x8
        public void PlayInFixedTime(){} // RVA: 0x7FFAC982D420 | overloaded x6
        public void Play(){} // RVA: 0x7FFAC982D5D0 | overloaded x6
        public void SetTarget(){} // RVA: 0x7FFAC982D600
        public void get_targetPosition(){} // RVA: 0x7FFAC982D670
        public void get_targetRotation(){} // RVA: 0x7FFAC982D6E0
        public void IsControlled(){} // RVA: 0x7FFAC52088B0
        public void IsBoneTransform(){} // RVA: 0x7FFAC982D750
        public void get_avatarRoot(){} // RVA: 0x7FFAC982D7B0
        public void GetBoneTransform(){} // RVA: 0x7FFAC982D800
        public void GetBoneTransformInternal(){} // RVA: 0x7FFAC982DC30
        public void get_cullingMode(){} // RVA: 0x7FFAC982DC90
        public void set_cullingMode(){} // RVA: 0x7FFAC982DCE0
        public void StartPlayback(){} // RVA: 0x7FFAC982DD40
        public void StopPlayback(){} // RVA: 0x7FFAC982DD90
        public void get_playbackTime(){} // RVA: 0x7FFAC982DDE0
        public void set_playbackTime(){} // RVA: 0x7FFAC982DE30
        public void StartRecording(){} // RVA: 0x7FFAC982DE90
        public void StopRecording(){} // RVA: 0x7FFAC982DEF0
        public void get_recorderStartTime(){} // RVA: 0x7FFAC982DF40
        public void set_recorderStartTime(){} // RVA: 0x7FFAC2F21310
        public void GetRecorderStartTime(){} // RVA: 0x7FFAC982DF40
        public void get_recorderStopTime(){} // RVA: 0x7FFAC982DF90
        public void set_recorderStopTime(){} // RVA: 0x7FFAC2F21310
        public void GetRecorderStopTime(){} // RVA: 0x7FFAC982DF90
        public void get_recorderMode(){} // RVA: 0x7FFAC982DFE0
        public void get_runtimeAnimatorController(){} // RVA: 0x7FFAC982E030
        public void set_runtimeAnimatorController(){} // RVA: 0x7FFAC982E080
        public void get_hasBoundPlayables(){} // RVA: 0x7FFAC982E0E0
        public void ClearInternalControllerPlayable(){} // RVA: 0x7FFAC982E130
        public void HasState(){} // RVA: 0x7FFAC982E180
        public void StringToHash(){} // RVA: 0x7FFAC982E1F0
        public void get_avatar(){} // RVA: 0x7FFAC982E240
        public void set_avatar(){} // RVA: 0x7FFAC982E290
        public void GetStats(){} // RVA: 0x7FFAC982E2F0
        public void get_playableGraph(){} // RVA: 0x7FFAC982E340
        public void GetCurrentGraph(){} // RVA: 0x7FFAC982E3C0
        public void CheckIfInIKPass(){} // RVA: 0x7FFAC982E420
        public void IsInIKPass(){} // RVA: 0x7FFAC982E520
        public void SetFloatString(){} // RVA: 0x7FFAC9829050
        public void SetFloatID(){} // RVA: 0x7FFAC9829140
        public void GetFloatString(){} // RVA: 0x7FFAC9828F90
        public void GetFloatID(){} // RVA: 0x7FFAC9828FF0
        public void SetBoolString(){} // RVA: 0x7FFAC98292F0
        public void SetBoolID(){} // RVA: 0x7FFAC9829360
        public void GetBoolString(){} // RVA: 0x7FFAC9829230
        public void GetBoolID(){} // RVA: 0x7FFAC9829290
        public void SetIntegerString(){} // RVA: 0x7FFAC9829490
        public void SetIntegerID(){} // RVA: 0x7FFAC9829500
        public void GetIntegerString(){} // RVA: 0x7FFAC98293D0
        public void GetIntegerID(){} // RVA: 0x7FFAC9829430
        public void SetTriggerString(){} // RVA: 0x7FFAC9829570
        public void SetTriggerID(){} // RVA: 0x7FFAC98295D0
        public void ResetTriggerString(){} // RVA: 0x7FFAC9829630
        public void ResetTriggerID(){} // RVA: 0x7FFAC9829690
        public void IsParameterControlledByCurveString(){} // RVA: 0x7FFAC98296F0
        public void IsParameterControlledByCurveID(){} // RVA: 0x7FFAC9829750
        public void SetFloatStringDamp(){} // RVA: 0x7FFAC98290C0
        public void SetFloatIDDamp(){} // RVA: 0x7FFAC98291B0
        public void get_layersAffectMassCenter(){} // RVA: 0x7FFAC982E570
        public void set_layersAffectMassCenter(){} // RVA: 0x7FFAC982E5C0
        public void get_leftFeetBottomHeight(){} // RVA: 0x7FFAC982E620
        public void get_rightFeetBottomHeight(){} // RVA: 0x7FFAC982E670
        public void get_supportsOnAnimatorMove(){} // RVA: 0x7FFAC982E6C0
        public void OnUpdateModeChanged(){} // RVA: 0x7FFAC982E710
        public void OnCullingModeChanged(){} // RVA: 0x7FFAC982E760
        public void WriteDefaultPose(){} // RVA: 0x7FFAC982E7B0
        public void Update(){} // RVA: 0x7FFAC982E800
        public void Rebind(){} // RVA: 0x7FFAC982E8C0 | overloaded x2
        public void ApplyBuiltinRootMotion(){} // RVA: 0x7FFAC982E920
        public void EvaluateController(){} // RVA: 0x7FFAC982E9D0 | overloaded x2
        public void GetCurrentStateName(){} // RVA: 0x7FFAC982EA30
        public void GetNextStateName(){} // RVA: 0x7FFAC982EA90
        public void GetAnimatorStateName(){} // RVA: 0x7FFAC982EAF0
        public void ResolveHash(){} // RVA: 0x7FFAC982EB60
        public void get_logWarnings(){} // RVA: 0x7FFAC982EBC0
        public void set_logWarnings(){} // RVA: 0x7FFAC982EC10
        public void get_fireEvents(){} // RVA: 0x7FFAC982EC70
        public void set_fireEvents(){} // RVA: 0x7FFAC982ECC0
        public void get_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7FFAC982ED20
        public void set_keepAnimatorControllerStateOnDisable(){} // RVA: 0x7FFAC982ED70
        public void get_keepAnimatorStateOnDisable(){} // RVA: 0x7FFAC982ED20
        public void set_keepAnimatorStateOnDisable(){} // RVA: 0x7FFAC982ED70
        public void get_writeDefaultValuesOnDisable(){} // RVA: 0x7FFAC982EDD0
        public void set_writeDefaultValuesOnDisable(){} // RVA: 0x7FFAC982EE20
        public void GetVector(){} // RVA: 0x7FFAC982EE80 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void GetQuaternion(){} // RVA: 0x7FFAC982EEE0 | overloaded x2
        public void SetQuaternion(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_deltaPosition_Injected(){} // RVA: 0x7FFAC982EF30
        public void get_deltaRotation_Injected(){} // RVA: 0x7FFAC982EF90
        public void get_velocity_Injected(){} // RVA: 0x7FFAC982EFF0
        public void get_angularVelocity_Injected(){} // RVA: 0x7FFAC982F050
        public void get_rootPosition_Injected(){} // RVA: 0x7FFAC982F0B0
        public void set_rootPosition_Injected(){} // RVA: 0x7FFAC982F110
        public void get_rootRotation_Injected(){} // RVA: 0x7FFAC982F170
        public void set_rootRotation_Injected(){} // RVA: 0x7FFAC982F1D0
        public void get_bodyPositionInternal_Injected(){} // RVA: 0x7FFAC982F230
        public void set_bodyPositionInternal_Injected(){} // RVA: 0x7FFAC982F290
        public void get_bodyRotationInternal_Injected(){} // RVA: 0x7FFAC982F2F0
        public void set_bodyRotationInternal_Injected(){} // RVA: 0x7FFAC982F350
        public void GetGoalPosition_Injected(){} // RVA: 0x7FFAC982F3B0
        public void SetGoalPosition_Injected(){} // RVA: 0x7FFAC982F420
        public void GetGoalRotation_Injected(){} // RVA: 0x7FFAC982F490
        public void SetGoalRotation_Injected(){} // RVA: 0x7FFAC982F500
        public void GetHintPosition_Injected(){} // RVA: 0x7FFAC982F570
        public void SetHintPosition_Injected(){} // RVA: 0x7FFAC982F5E0
        public void SetLookAtPositionInternal_Injected(){} // RVA: 0x7FFAC982F650
        public void SetBoneLocalRotationInternal_Injected(){} // RVA: 0x7FFAC982F6B0
        public void get_pivotPosition_Injected(){} // RVA: 0x7FFAC982F720
        public void MatchTarget_Injected(){} // RVA: 0x7FFAC982F780
        public void get_targetPosition_Injected(){} // RVA: 0x7FFAC982F810
        public void get_targetRotation_Injected(){} // RVA: 0x7FFAC982F870
    }

    public class AnimatorClipInfo : ValueType
    {
        public int clip; // 0x10
        public float weight; // 0x14

        // ── Methods ──
        public void get_clip(){} // RVA: 0x7FFAC9828AA0
        public void get_weight(){} // RVA: 0x7FFAC2F44D30
        public void InstanceIDToAnimationClipPPtr(){} // RVA: 0x7FFAC9828B00
    }

    public class AnimatorControllerParameter : Object
    {
        public string name; // 0x10
        public 0x6B29C6F8 nameHash; // 0x18
        public float type; // 0x1C
        public int defaultFloat; // 0x20
        public bool defaultInt; // 0x24

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC5CC4750
        public void get_nameHash(){} // RVA: 0x7FFAC982F8D0
        public void get_type(){} // RVA: 0x7FFAC669DCA0
        public void set_type(){} // RVA: 0x7FFAC392CD10
        public void get_defaultFloat(){} // RVA: 0x7FFAC9814E00
        public void set_defaultFloat(){} // RVA: 0x7FFAC2FEE580
        public void get_defaultInt(){} // RVA: 0x7FFAC6C90D40
        public void set_defaultInt(){} // RVA: 0x7FFAC35DB7A0
        public void get_defaultBool(){} // RVA: 0x7FFAC982F920
        public void set_defaultBool(){} // RVA: 0x7FFAC4422FB0
        public void Equals(){} // RVA: 0x7FFAC982F930
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void .ctor(){} // RVA: 0x7FFAC982FA40
    }

    public class AnimatorOverrideController : RuntimeAnimatorController
    {
        public OnOverrideControllerDirtyCallback runtimeAnimatorController; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC982FBB0 | overloaded x2
        public void Internal_Create(){} // RVA: 0x7FFAC982FCA0
        public void get_runtimeAnimatorController(){} // RVA: 0x7FFAC982FD00
        public void set_runtimeAnimatorController(){} // RVA: 0x7FFAC982FD50
        public void get_Item(){} // RVA: 0x7FFAC982FF00 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC982FF70 | overloaded x2
        public void Internal_GetClipByName(){} // RVA: 0x7FFAC982FE90
        public void Internal_SetClipByName(){} // RVA: 0x7FFAC982FE20
        public void GetClip(){} // RVA: 0x7FFAC982FF90
        public void SetClip(){} // RVA: 0x7FFAC9830000
        public void SendNotification(){} // RVA: 0x7FFAC9830080
        public void GetOriginalClip(){} // RVA: 0x7FFAC98300D0
        public void GetOverrideClip(){} // RVA: 0x7FFAC9830130
        public void get_overridesCount(){} // RVA: 0x7FFAC9830190
        public void GetOverrides(){} // RVA: 0x7FFAC98301E0
        public void ApplyOverrides(){} // RVA: 0x7FFAC9830450
        public void OnInvalidateOverrideController(){} // RVA: 0x7FFAC9830790
    }

    public class AnimatorStateInfo : ValueType
    {
        public int fullPathHash; // 0x10
        public int shortNameHash; // 0x14
        public int normalizedTime; // 0x18
        public float length; // 0x1C
        public float speed; // 0x20
        public float speedMultiplier; // 0x24
        public float tagHash; // 0x28
        public int loop; // 0x2C
        public int m_Loop; // 0x30

        // ── Methods ──
        public void IsName(){} // RVA: 0x7FFAC9828B50
        public void get_fullPathHash(){} // RVA: 0x7FFAC653D9A0
        public void get_shortNameHash(){} // RVA: 0x7FFAC8F93F90
        public void get_normalizedTime(){} // RVA: 0x7FFAC2F44D00
        public void get_length(){} // RVA: 0x7FFAC9814DF0
        public void get_speed(){} // RVA: 0x7FFAC58A0690
        public void get_speedMultiplier(){} // RVA: 0x7FFAC9811DF0
        public void get_tagHash(){} // RVA: 0x7FFAC5CC4740
        public void IsTag(){} // RVA: 0x7FFAC9828BD0
        public void get_loop(){} // RVA: 0x7FFAC9811E00
    }

    public class AnimatorTransitionInfo : ValueType
    {
        public int fullPathHash; // 0x10
        public int nameHash; // 0x14
        public int userNameHash; // 0x18
        public bool durationUnit; // 0x1C
        public float duration; // 0x20
        public float normalizedTime; // 0x24
        public bool anyState; // 0x28
        public int m_TransitionType; // 0x2C

        // ── Methods ──
        public void IsName(){} // RVA: 0x7FFAC9828C40
        public void IsUserName(){} // RVA: 0x7FFAC9828D00
        public void get_fullPathHash(){} // RVA: 0x7FFAC8F93F90
        public void get_nameHash(){} // RVA: 0x7FFAC653D9A0
        public void get_userNameHash(){} // RVA: 0x7FFAC69CBEA0
        public void get_durationUnit(){} // RVA: 0x7FFAC9828D70
        public void get_duration(){} // RVA: 0x7FFAC9814DF0
        public void get_normalizedTime(){} // RVA: 0x7FFAC58A0690
        public void get_anyState(){} // RVA: 0x7FFAC9828D80
    }

    public class AnimatorUtility : Object
    {
        // ── Methods ──
        public void OptimizeTransformHierarchy(){} // RVA: 0x7FFAC98307D0
        public void DeoptimizeTransformHierarchy(){} // RVA: 0x7FFAC9830830
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Application : Object
    {
        public LowMemoryCallback isPlaying;
        public MemoryUsageChangedCallback isFocused; // 0x8
        public LogCallback buildGUID; // 0x10
        public LogCallback runInBackground; // 0x18
        public System.Action`1<bool> isBatchMode; // 0x20
        public System.Action`1<string> dataPath; // 0x28
        public System.Func`1<bool> streamingAssetsPath; // 0x30
        public System.Action persistentDataPath; // 0x38
        public System.Action temporaryCachePath; // 0x40
        public System.Threading.CancellationTokenSource unityVersion; // 0x48

        // ── Methods ──
        public void Quit(){} // RVA: 0x7FFAC9852EF0 | overloaded x2
        public void get_isPlaying(){} // RVA: 0x7FFAC9852F70
        public void get_isFocused(){} // RVA: 0x7FFAC9852FC0
        public void get_buildGUID(){} // RVA: 0x7FFAC9853010
        public void get_runInBackground(){} // RVA: 0x7FFAC9853060
        public void set_runInBackground(){} // RVA: 0x7FFAC98530B0
        public void get_isBatchMode(){} // RVA: 0x7FFAC9853100
        public void get_dataPath(){} // RVA: 0x7FFAC9853150
        public void get_streamingAssetsPath(){} // RVA: 0x7FFAC98531A0
        public void get_persistentDataPath(){} // RVA: 0x7FFAC98531F0
        public void get_temporaryCachePath(){} // RVA: 0x7FFAC9853240
        public void get_unityVersion(){} // RVA: 0x7FFAC9853290
        public void get_version(){} // RVA: 0x7FFAC98532E0
        public void get_installMode(){} // RVA: 0x7FFAC9853330
        public void get_productName(){} // RVA: 0x7FFAC9853380
        public void get_companyName(){} // RVA: 0x7FFAC98533D0
        public void get_cloudProjectId(){} // RVA: 0x7FFAC9853420
        public void OpenURL(){} // RVA: 0x7FFAC9853470
        public void get_targetFrameRate(){} // RVA: 0x7FFAC98534C0
        public void set_targetFrameRate(){} // RVA: 0x7FFAC9853510
        public void SetLogCallbackDefined(){} // RVA: 0x7FFAC9853560
        public void GetStackTraceLogType(){} // RVA: 0x7FFAC98535B0
        public void set_backgroundLoadingPriority(){} // RVA: 0x7FFAC9853600
        public void RequestUserAuthorization(){} // RVA: 0x7FFAC9853650
        public void HasUserAuthorization(){} // RVA: 0x7FFAC98536A0
        public void get_platform(){} // RVA: 0x7FFAC98536F0
        public void get_isMobilePlatform(){} // RVA: 0x7FFAC9853740
        public void get_systemLanguage(){} // RVA: 0x7FFAC9853830
        public void get_internetReachability(){} // RVA: 0x7FFAC9853880
        public void add_lowMemory(){} // RVA: 0x7FFAC98538D0
        public void remove_lowMemory(){} // RVA: 0x7FFAC9853A20
        public void CallLowMemory(){} // RVA: 0x7FFAC9853B70
        public void HasLogCallback(){} // RVA: 0x7FFAC9853CB0
        public void add_logMessageReceivedThreaded(){} // RVA: 0x7FFAC9853D40
        public void remove_logMessageReceivedThreaded(){} // RVA: 0x7FFAC9853EC0
        public void CallLogCallback(){} // RVA: 0x7FFAC9854000
        public void add_onBeforeRender(){} // RVA: 0x7FFAC98540F0
        public void remove_onBeforeRender(){} // RVA: 0x7FFAC9854140
        public void add_focusChanged(){} // RVA: 0x7FFAC9854190
        public void remove_focusChanged(){} // RVA: 0x7FFAC98542F0
        public void add_wantsToQuit(){} // RVA: 0x7FFAC9854450
        public void remove_wantsToQuit(){} // RVA: 0x7FFAC98545B0
        public void add_quitting(){} // RVA: 0x7FFAC9854710
        public void remove_quitting(){} // RVA: 0x7FFAC9854860
        public void Internal_ApplicationWantsToQuit(){} // RVA: 0x7FFAC98549B0
        public void Internal_ApplicationQuit(){} // RVA: 0x7FFAC9854B60
        public void Internal_ApplicationUnload(){} // RVA: 0x7FFAC9854D00
        public void InvokeOnBeforeRender(){} // RVA: 0x7FFAC9854DA0
        public void InvokeFocusChanged(){} // RVA: 0x7FFAC9854DF0
        public void InvokeDeepLinkActivated(){} // RVA: 0x7FFAC9854E90
        public void get_isEditor(){} // RVA: 0x7FFAC52088B0
        public void .cctor(){} // RVA: 0x7FFAC9854F30
    }

    public class ApplicationMemoryUsageChange : ValueType
    {
        public 0x6B179268 memoryUsage; // 0x10

        // ── Methods ──
        public void set_memoryUsage(){} // RVA: 0x7FFAC336D8B0
        public void .ctor(){} // RVA: 0x7FFAC336D8B0
    }

    public class AreaEffector2D : Effector2D
    {
        public object forceAngle;
        public object useGlobalAngle;
        public object forceMagnitude;
        public object forceVariation;
        public object drag;
        public object angularDrag;
        public object forceTarget;

        // ── Methods ──
        public void get_forceAngle(){} // RVA: 0x7FFAC9985B60
        public void set_forceAngle(){} // RVA: 0x7FFAC9985BB0
        public void get_useGlobalAngle(){} // RVA: 0x7FFAC9985C10
        public void set_useGlobalAngle(){} // RVA: 0x7FFAC9985C60
        public void get_forceMagnitude(){} // RVA: 0x7FFAC9985CC0
        public void set_forceMagnitude(){} // RVA: 0x7FFAC9985D10
        public void get_forceVariation(){} // RVA: 0x7FFAC9985D70
        public void set_forceVariation(){} // RVA: 0x7FFAC9985DC0
        public void get_drag(){} // RVA: 0x7FFAC9985E20
        public void set_drag(){} // RVA: 0x7FFAC9985E70
        public void get_angularDrag(){} // RVA: 0x7FFAC9985ED0
        public void set_angularDrag(){} // RVA: 0x7FFAC9985F20
        public void get_forceTarget(){} // RVA: 0x7FFAC9985F80
        public void set_forceTarget(){} // RVA: 0x7FFAC9985FD0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ArticulationBody : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AssemblyFullName : ValueType
    {
        public string Name; // 0x10
        public UnityEngine.AssemblyVersion Version; // 0x18
        public string PublicKeyToken; // 0x20
        public string Culture; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC98BB8F0
        public void GetHashCode(){} // RVA: 0x7FFAC98BBAA0
        public void ToString(){} // RVA: 0x7FFAC98BBB40
    }

    public class AssemblyIsEditorAssembly : Attribute
    {
    }

    public class AssemblyVersion : ValueType
    {
        public ushort major; // 0x10
        public ushort minor; // 0x12
        public ushort build; // 0x14
        public ushort revision; // 0x16

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFAC98BB410
        public void ToString(){} // RVA: 0x7FFAC98BB450
        public void Equals(){} // RVA: 0x7FFAC98BB690
        public void GetHashCode(){} // RVA: 0x7FFAC98BB740
    }

    public class AssetBundle : Object
    {
        public object isStreamedSceneAssetBundle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9842B80
        public void LoadFromFile_Internal(){} // RVA: 0x7FFAC9842BD0
        public void LoadFromFile(){} // RVA: 0x7FFAC9842C40
        public void get_isStreamedSceneAssetBundle(){} // RVA: 0x7FFAC9842CA0
        public void LoadAsset(){} // RVA: 0x7FFAC9842DD0 | overloaded x3
        public void LoadAsset_Internal(){} // RVA: 0x7FFAC9842F70
        public void LoadAssetWithSubAssetsAsync(){} // RVA: 0x7FFAC9843200 | overloaded x2
        public void LoadAllAssetsAsync(){} // RVA: 0x7FFAC98434F0 | overloaded x2
        public void Unload(){} // RVA: 0x7FFAC98435C0
        public void UnloadAsync(){} // RVA: 0x7FFAC9843620
        public void GetAllAssetNames(){} // RVA: 0x7FFAC9843680
        public void GetAllScenePaths(){} // RVA: 0x7FFAC98436D0
        public void LoadAssetWithSubAssetsAsync_Internal(){} // RVA: 0x7FFAC9843720
    }

    public class AssetBundleCreateRequest : AsyncOperation
    {
        public object assetBundle;

        // ── Methods ──
        public void get_assetBundle(){} // RVA: 0x7FFAC98437A0
    }

    public class AssetBundleRecompressOperation : AsyncOperation
    {
    }

    public class AssetBundleRequest : ResourceRequest
    {
        public object asset;
        public object allAssets;

        // ── Methods ──
        public void GetResult(){} // RVA: 0x7FFAC98437F0
        public void get_asset(){} // RVA: 0x7FFAC2FD5BC0
        public void get_allAssets(){} // RVA: 0x7FFAC9843840
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AssetBundleUnloadOperation : AsyncOperation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AssetFileNameExtensionAttribute : Attribute
    {
        public string <preferredExtension>k__BackingField; // 0x10
        public System.Collections.Generic.IEnumerable`1<string> <otherExtensions>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class AsyncInstantiateOperation : AsyncOperation
    {
        public UnityEngine.Object[] Result; // 0x20

        // ── Methods ──
        public void get_Result(){} // RVA: 0x7FFAC91BAEE0
    }

    public class AsyncInstantiateOperationHelper : Object
    {
        // ── Methods ──
        public void SetAsyncInstantiateOperationResult(){} // RVA: 0x7FFAC98B93C0
    }

    public class AsyncInstantiateOperation`1 : CustomYieldInstruction
    {
        public UnityEngine.AsyncInstantiateOperation keepWaiting;

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFAC2C59D00
        public void add_completed(){} // RVA: 0x7FFAC2C70A40
        public void remove_completed(){} // RVA: 0x7FFAC2C70A40
        public void get_isDone(){} // RVA: 0x7FFAC2C59D00
        public void get_progress(){} // RVA: 0x7FFAC2C6D880
        public void get_Result(){} // RVA: 0x7FFAC2C58E90
    }

    public class AsyncOperation : YieldInstruction
    {
        public UIntPtr isDone; // 0x10
        public System.Action`1<UnityEngine.AsyncOperation> progress; // 0x18

        // ── Methods ──
        public void InternalDestroy(){} // RVA: 0x7FFAC98B9420
        public void get_isDone(){} // RVA: 0x7FFAC98B9470
        public void get_progress(){} // RVA: 0x7FFAC98B94C0
        public void set_allowSceneActivation(){} // RVA: 0x7FFAC98B9510
        public void Finalize(){} // RVA: 0x7FFAC98B9570
        public void InvokeCompletionEvent(){} // RVA: 0x7FFAC98B95F0
        public void add_completed(){} // RVA: 0x7FFAC98B9670
        public void remove_completed(){} // RVA: 0x7FFAC98B97F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AttributeHelperEngine : Object
    {
        public UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        public UnityEngine.ExecuteInEditMode[] _executeInEditModeArray; // 0x8
        public UnityEngine.RequireComponent[] _requireComponentArray; // 0x10

        // ── Methods ──
        public void GetParentTypeDisallowingMultipleInclusion(){} // RVA: 0x7FFAC98B98F0
        public void GetRequiredComponents(){} // RVA: 0x7FFAC98B9AB0
        public void GetExecuteMode(){} // RVA: 0x7FFAC98B9F70
        public void CheckIsEditorScript(){} // RVA: 0x7FFAC98BA0F0
        public void GetDefaultExecutionOrderFor(){} // RVA: 0x7FFAC98BA370
        public void GetCustomAttributeOfType(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC98BA520
    }

    public class AudioBehaviour : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioChorusFilter : Behaviour
    {
        public object dryMix;
        public object wetMix1;
        public object wetMix2;
        public object wetMix3;
        public object delay;
        public object rate;
        public object depth;
        public object feedback;

        // ── Methods ──
        public void get_dryMix(){} // RVA: 0x7FFAC9848B10
        public void set_dryMix(){} // RVA: 0x7FFAC9848B60
        public void get_wetMix1(){} // RVA: 0x7FFAC9848BC0
        public void set_wetMix1(){} // RVA: 0x7FFAC9848C10
        public void get_wetMix2(){} // RVA: 0x7FFAC9848C70
        public void set_wetMix2(){} // RVA: 0x7FFAC9848CC0
        public void get_wetMix3(){} // RVA: 0x7FFAC9848D20
        public void set_wetMix3(){} // RVA: 0x7FFAC9848D70
        public void get_delay(){} // RVA: 0x7FFAC9848DD0
        public void set_delay(){} // RVA: 0x7FFAC9848E20
        public void get_rate(){} // RVA: 0x7FFAC9848E80
        public void set_rate(){} // RVA: 0x7FFAC9848ED0
        public void get_depth(){} // RVA: 0x7FFAC9848F30
        public void set_depth(){} // RVA: 0x7FFAC9848F80
        public void get_feedback(){} // RVA: 0x7FFAC9848FE0
        public void set_feedback(){} // RVA: 0x7FFAC9849050
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioClip : Object
    {
        public PCMReaderCallback length; // 0x18
        public PCMSetPositionCallback samples; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9843ED0
        public void GetData(){} // RVA: 0x7FFAC9844570 | overloaded x2
        public void SetData(){} // RVA: 0x7FFAC9844760 | overloaded x2
        public void Construct_Internal(){} // RVA: 0x7FFAC98440D0
        public void GetName(){} // RVA: 0x7FFAC9844120
        public void CreateUserSound(){} // RVA: 0x7FFAC9844170
        public void get_length(){} // RVA: 0x7FFAC9844200
        public void get_samples(){} // RVA: 0x7FFAC9844250
        public void get_channels(){} // RVA: 0x7FFAC98442A0
        public void get_frequency(){} // RVA: 0x7FFAC98442F0
        public void get_loadType(){} // RVA: 0x7FFAC9844340
        public void LoadAudioData(){} // RVA: 0x7FFAC9844390
        public void UnloadAudioData(){} // RVA: 0x7FFAC98443E0
        public void get_preloadAudioData(){} // RVA: 0x7FFAC9844430
        public void get_ambisonic(){} // RVA: 0x7FFAC9844480
        public void get_loadInBackground(){} // RVA: 0x7FFAC98444D0
        public void get_loadState(){} // RVA: 0x7FFAC9844520
        public void Create(){} // RVA: 0x7FFAC9844A30 | overloaded x2
        public void add_m_PCMReaderCallback(){} // RVA: 0x7FFAC9844E30
        public void remove_m_PCMReaderCallback(){} // RVA: 0x7FFAC9844F20
        public void add_m_PCMSetPositionCallback(){} // RVA: 0x7FFAC9845010
        public void remove_m_PCMSetPositionCallback(){} // RVA: 0x7FFAC9845100
        public void InvokePCMReaderCallback_Internal(){} // RVA: 0x7FFAC98451F0
        public void InvokePCMSetPositionCallback_Internal(){} // RVA: 0x7FFAC9845210
    }

    public class AudioConfiguration : ValueType
    {
        public 0x6B2BF9B0 speakerMode; // 0x10
        public int dspBufferSize; // 0x14
        public int sampleRate; // 0x18
        public int numRealVoices; // 0x1C
        public int numVirtualVoices; // 0x20
    }

    public class AudioDistortionFilter : Behaviour
    {
        public object distortionLevel;

        // ── Methods ──
        public void get_distortionLevel(){} // RVA: 0x7FFAC98487A0
        public void set_distortionLevel(){} // RVA: 0x7FFAC98487F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioEchoFilter : Behaviour
    {
        public object delay;
        public object decayRatio;
        public object dryMix;
        public object wetMix;

        // ── Methods ──
        public void get_delay(){} // RVA: 0x7FFAC9848850
        public void set_delay(){} // RVA: 0x7FFAC98488A0
        public void get_decayRatio(){} // RVA: 0x7FFAC9848900
        public void set_decayRatio(){} // RVA: 0x7FFAC9848950
        public void get_dryMix(){} // RVA: 0x7FFAC98489B0
        public void set_dryMix(){} // RVA: 0x7FFAC9848A00
        public void get_wetMix(){} // RVA: 0x7FFAC9848A60
        public void set_wetMix(){} // RVA: 0x7FFAC9848AB0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioHighPassFilter : Behaviour
    {
        public object cutoffFrequency;
        public object highpassResonanceQ;

        // ── Methods ──
        public void get_cutoffFrequency(){} // RVA: 0x7FFAC9848640
        public void set_cutoffFrequency(){} // RVA: 0x7FFAC9848690
        public void get_highpassResonanceQ(){} // RVA: 0x7FFAC98486F0
        public void set_highpassResonanceQ(){} // RVA: 0x7FFAC9848740
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioListener : AudioBehaviour
    {
        public object volume;
        public object pause;

        // ── Methods ──
        public void get_volume(){} // RVA: 0x7FFAC9845230
        public void set_volume(){} // RVA: 0x7FFAC9845280
        public void get_pause(){} // RVA: 0x7FFAC98452E0
        public void set_pause(){} // RVA: 0x7FFAC9845330
    }

    public class AudioLowPassFilter : Behaviour
    {
        public object customCutoffCurve;
        public object cutoffFrequency;
        public object lowpassResonanceQ;

        // ── Methods ──
        public void GetCustomLowpassLevelCurveCopy(){} // RVA: 0x7FFAC9848430
        public void SetCustomLowpassLevelCurveHelper(){} // RVA: 0x7FFAC9848480
        public void get_customCutoffCurve(){} // RVA: 0x7FFAC9848430
        public void set_customCutoffCurve(){} // RVA: 0x7FFAC9848480
        public void get_cutoffFrequency(){} // RVA: 0x7FFAC98484E0
        public void set_cutoffFrequency(){} // RVA: 0x7FFAC9848530
        public void get_lowpassResonanceQ(){} // RVA: 0x7FFAC9848590
        public void set_lowpassResonanceQ(){} // RVA: 0x7FFAC98485E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioRenderer : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC984A3B0
        public void Stop(){} // RVA: 0x7FFAC984A400
        public void GetSampleCountForCaptureFrame(){} // RVA: 0x7FFAC984A450
        public void Render(){} // RVA: 0x7FFAC984A4A0
        public void Internal_AudioRenderer_Start(){} // RVA: 0x7FFAC984A3B0
        public void Internal_AudioRenderer_Stop(){} // RVA: 0x7FFAC984A400
        public void Internal_AudioRenderer_GetSampleCountForCaptureFrame(){} // RVA: 0x7FFAC984A450
        public void Internal_AudioRenderer_Render(){} // RVA: 0x7FFAC984A530
    }

    public class AudioReverbFilter : Behaviour
    {
        public object reverbPreset;
        public object dryLevel;
        public object room;
        public object roomHF;
        public object roomRolloffFactor;
        public object decayTime;
        public object decayHFRatio;
        public object reflectionsLevel;
        public object reflectionsDelay;
        public object reverbLevel;
        public object reverbDelay;
        public object diffusion;
        public object density;
        public object hfReference;
        public object roomLF;
        public object lfReference;

        // ── Methods ──
        public void get_reverbPreset(){} // RVA: 0x7FFAC98490B0
        public void set_reverbPreset(){} // RVA: 0x7FFAC9849100
        public void get_dryLevel(){} // RVA: 0x7FFAC9849160
        public void set_dryLevel(){} // RVA: 0x7FFAC98491B0
        public void get_room(){} // RVA: 0x7FFAC9849210
        public void set_room(){} // RVA: 0x7FFAC9849260
        public void get_roomHF(){} // RVA: 0x7FFAC98492C0
        public void set_roomHF(){} // RVA: 0x7FFAC9849310
        public void get_roomRolloffFactor(){} // RVA: 0x7FFAC9849370
        public void set_roomRolloffFactor(){} // RVA: 0x7FFAC98493E0
        public void get_decayTime(){} // RVA: 0x7FFAC9849440
        public void set_decayTime(){} // RVA: 0x7FFAC9849490
        public void get_decayHFRatio(){} // RVA: 0x7FFAC98494F0
        public void set_decayHFRatio(){} // RVA: 0x7FFAC9849540
        public void get_reflectionsLevel(){} // RVA: 0x7FFAC98495A0
        public void set_reflectionsLevel(){} // RVA: 0x7FFAC98495F0
        public void get_reflectionsDelay(){} // RVA: 0x7FFAC9849650
        public void set_reflectionsDelay(){} // RVA: 0x7FFAC98496A0
        public void get_reverbLevel(){} // RVA: 0x7FFAC9849700
        public void set_reverbLevel(){} // RVA: 0x7FFAC9849750
        public void get_reverbDelay(){} // RVA: 0x7FFAC98497B0
        public void set_reverbDelay(){} // RVA: 0x7FFAC9849800
        public void get_diffusion(){} // RVA: 0x7FFAC9849860
        public void set_diffusion(){} // RVA: 0x7FFAC98498B0
        public void get_density(){} // RVA: 0x7FFAC9849910
        public void set_density(){} // RVA: 0x7FFAC9849960
        public void get_hfReference(){} // RVA: 0x7FFAC98499C0
        public void set_hfReference(){} // RVA: 0x7FFAC9849A10
        public void get_roomLF(){} // RVA: 0x7FFAC9849A70
        public void set_roomLF(){} // RVA: 0x7FFAC9849AC0
        public void get_lfReference(){} // RVA: 0x7FFAC9849B20
        public void set_lfReference(){} // RVA: 0x7FFAC9849B70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioReverbZone : Behaviour
    {
        public object minDistance;
        public object maxDistance;
        public object reverbPreset;
        public object room;
        public object roomHF;
        public object roomLF;
        public object decayTime;
        public object decayHFRatio;
        public object reflections;
        public object reflectionsDelay;
        public object reverb;
        public object reverbDelay;
        public object HFReference;
        public object LFReference;
        public object roomRolloffFactor;
        public object diffusion;
        public object density;

        // ── Methods ──
        public void get_minDistance(){} // RVA: 0x7FFAC9847860
        public void set_minDistance(){} // RVA: 0x7FFAC98478B0
        public void get_maxDistance(){} // RVA: 0x7FFAC9847910
        public void set_maxDistance(){} // RVA: 0x7FFAC9847960
        public void get_reverbPreset(){} // RVA: 0x7FFAC98479C0
        public void set_reverbPreset(){} // RVA: 0x7FFAC9847A10
        public void get_room(){} // RVA: 0x7FFAC9847A70
        public void set_room(){} // RVA: 0x7FFAC9847AC0
        public void get_roomHF(){} // RVA: 0x7FFAC9847B20
        public void set_roomHF(){} // RVA: 0x7FFAC9847B70
        public void get_roomLF(){} // RVA: 0x7FFAC9847BD0
        public void set_roomLF(){} // RVA: 0x7FFAC9847C20
        public void get_decayTime(){} // RVA: 0x7FFAC9847C80
        public void set_decayTime(){} // RVA: 0x7FFAC9847CD0
        public void get_decayHFRatio(){} // RVA: 0x7FFAC9847D30
        public void set_decayHFRatio(){} // RVA: 0x7FFAC9847D80
        public void get_reflections(){} // RVA: 0x7FFAC9847DE0
        public void set_reflections(){} // RVA: 0x7FFAC9847E30
        public void get_reflectionsDelay(){} // RVA: 0x7FFAC9847E90
        public void set_reflectionsDelay(){} // RVA: 0x7FFAC9847EE0
        public void get_reverb(){} // RVA: 0x7FFAC9847F40
        public void set_reverb(){} // RVA: 0x7FFAC9847F90
        public void get_reverbDelay(){} // RVA: 0x7FFAC9847FF0
        public void set_reverbDelay(){} // RVA: 0x7FFAC9848040
        public void get_HFReference(){} // RVA: 0x7FFAC98480A0
        public void set_HFReference(){} // RVA: 0x7FFAC98480F0
        public void get_LFReference(){} // RVA: 0x7FFAC9848150
        public void set_LFReference(){} // RVA: 0x7FFAC98481A0
        public void get_roomRolloffFactor(){} // RVA: 0x7FFAC9848200
        public void set_roomRolloffFactor(){} // RVA: 0x7FFAC9848270
        public void get_diffusion(){} // RVA: 0x7FFAC98482D0
        public void set_diffusion(){} // RVA: 0x7FFAC9848320
        public void get_density(){} // RVA: 0x7FFAC9848380
        public void set_density(){} // RVA: 0x7FFAC98483D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AudioSettings : Object
    {
        public AudioConfigurationChangeHandler driverCapabilities;
        public System.Action speakerMode; // 0x8
        public System.Action dspTime; // 0x10

        // ── Methods ──
        public void GetSpeakerMode(){} // RVA: 0x7FFAC9843890
        public void SetConfiguration(){} // RVA: 0x7FFAC98438E0
        public void GetSampleRate(){} // RVA: 0x7FFAC89F0760
        public void get_driverCapabilities(){} // RVA: 0x7FFAC9843930
        public void get_speakerMode(){} // RVA: 0x7FFAC9843890
        public void get_dspTime(){} // RVA: 0x7FFAC9843980
        public void get_outputSampleRate(){} // RVA: 0x7FFAC89F0760
        public void GetDSPBufferSize(){} // RVA: 0x7FFAC98439D0
        public void GetConfiguration(){} // RVA: 0x7FFAC9843A30
        public void Reset(){} // RVA: 0x7FFAC9843A90
        public void add_OnAudioConfigurationChanged(){} // RVA: 0x7FFAC9843AF0
        public void remove_OnAudioConfigurationChanged(){} // RVA: 0x7FFAC9843C00
        public void InvokeOnAudioConfigurationChanged(){} // RVA: 0x7FFAC9843D10
        public void InvokeOnAudioSystemShuttingDown(){} // RVA: 0x7FFAC9843D70
        public void InvokeOnAudioSystemStartedUp(){} // RVA: 0x7FFAC9843DD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetConfiguration_Injected(){} // RVA: 0x7FFAC9843E30
        public void GetConfiguration_Injected(){} // RVA: 0x7FFAC9843E80
    }

    public class AudioSource : AudioBehaviour
    {
        public object volume;
        public object pitch;
        public object time;
        public object timeSamples;
        public object clip;
        public object outputAudioMixerGroup;
        public object isPlaying;
        public object isVirtual;
        public object loop;
        public object ignoreListenerVolume;
        public object playOnAwake;
        public object ignoreListenerPause;
        public object velocityUpdateMode;
        public object panStereo;
        public object spatialBlend;
        public object spatialize;
        public object spatializePostEffects;
        public object reverbZoneMix;
        public object bypassEffects;
        public object bypassListenerEffects;
        public object bypassReverbZones;
        public object dopplerLevel;
        public object spread;
        public object priority;
        public object mute;
        public object minDistance;
        public object maxDistance;
        public object rolloffMode;
        public object minVolume;
        public object maxVolume;
        public object rolloffFactor;

        // ── Methods ──
        public void GetPitch(){} // RVA: 0x7FFAC9845380
        public void SetPitch(){} // RVA: 0x7FFAC98453D0
        public void PlayHelper(){} // RVA: 0x7FFAC9845430
        public void Play(){} // RVA: 0x7FFAC9845430 | overloaded x3
        public void PlayOneShotHelper(){} // RVA: 0x7FFAC98454F0
        public void Stop(){} // RVA: 0x7FFAC9845EA0 | overloaded x2
        public void SetCustomCurveHelper(){} // RVA: 0x7FFAC98455C0
        public void GetCustomCurveHelper(){} // RVA: 0x7FFAC9845630
        public void GetOutputDataHelper(){} // RVA: 0x7FFAC9845690
        public void GetSpectrumDataHelper(){} // RVA: 0x7FFAC9845700
        public void get_volume(){} // RVA: 0x7FFAC9845780
        public void set_volume(){} // RVA: 0x7FFAC98457D0
        public void get_pitch(){} // RVA: 0x7FFAC9845380
        public void set_pitch(){} // RVA: 0x7FFAC98453D0
        public void get_time(){} // RVA: 0x7FFAC9845830
        public void set_time(){} // RVA: 0x7FFAC9845880
        public void get_timeSamples(){} // RVA: 0x7FFAC98458E0
        public void set_timeSamples(){} // RVA: 0x7FFAC9845930
        public void get_clip(){} // RVA: 0x7FFAC9845990
        public void set_clip(){} // RVA: 0x7FFAC98459E0
        public void get_outputAudioMixerGroup(){} // RVA: 0x7FFAC9845A40
        public void set_outputAudioMixerGroup(){} // RVA: 0x7FFAC9845A90
        public void PlayDelayed(){} // RVA: 0x7FFAC9845B50
        public void PlayScheduled(){} // RVA: 0x7FFAC9845BD0
        public void PlayOneShot(){} // RVA: 0x7FFAC9845C60 | overloaded x2
        public void SetScheduledStartTime(){} // RVA: 0x7FFAC9845DE0
        public void SetScheduledEndTime(){} // RVA: 0x7FFAC9845E40
        public void Pause(){} // RVA: 0x7FFAC9845F00
        public void UnPause(){} // RVA: 0x7FFAC9845F50
        public void get_isPlaying(){} // RVA: 0x7FFAC9845FA0
        public void get_isVirtual(){} // RVA: 0x7FFAC9845FF0
        public void PlayClipAtPoint(){} // RVA: 0x7FFAC9846070 | overloaded x2
        public void get_loop(){} // RVA: 0x7FFAC9846550
        public void set_loop(){} // RVA: 0x7FFAC98465A0
        public void get_ignoreListenerVolume(){} // RVA: 0x7FFAC9846600
        public void set_ignoreListenerVolume(){} // RVA: 0x7FFAC9846650
        public void get_playOnAwake(){} // RVA: 0x7FFAC98466B0
        public void set_playOnAwake(){} // RVA: 0x7FFAC9846700
        public void get_ignoreListenerPause(){} // RVA: 0x7FFAC9846760
        public void set_ignoreListenerPause(){} // RVA: 0x7FFAC98467B0
        public void get_velocityUpdateMode(){} // RVA: 0x7FFAC9846810
        public void set_velocityUpdateMode(){} // RVA: 0x7FFAC9846860
        public void get_panStereo(){} // RVA: 0x7FFAC98468C0
        public void set_panStereo(){} // RVA: 0x7FFAC9846910
        public void get_spatialBlend(){} // RVA: 0x7FFAC9846970
        public void set_spatialBlend(){} // RVA: 0x7FFAC98469C0
        public void get_spatialize(){} // RVA: 0x7FFAC9846A20
        public void set_spatialize(){} // RVA: 0x7FFAC9846A70
        public void get_spatializePostEffects(){} // RVA: 0x7FFAC9846AD0
        public void set_spatializePostEffects(){} // RVA: 0x7FFAC9846B20
        public void SetCustomCurve(){} // RVA: 0x7FFAC98455C0
        public void GetCustomCurve(){} // RVA: 0x7FFAC9845630
        public void get_reverbZoneMix(){} // RVA: 0x7FFAC9846B80
        public void set_reverbZoneMix(){} // RVA: 0x7FFAC9846BD0
        public void get_bypassEffects(){} // RVA: 0x7FFAC9846C30
        public void set_bypassEffects(){} // RVA: 0x7FFAC9846C80
        public void get_bypassListenerEffects(){} // RVA: 0x7FFAC9846CE0
        public void set_bypassListenerEffects(){} // RVA: 0x7FFAC9846D30
        public void get_bypassReverbZones(){} // RVA: 0x7FFAC9846D90
        public void set_bypassReverbZones(){} // RVA: 0x7FFAC9846DE0
        public void get_dopplerLevel(){} // RVA: 0x7FFAC9846E40
        public void set_dopplerLevel(){} // RVA: 0x7FFAC9846E90
        public void get_spread(){} // RVA: 0x7FFAC9846EF0
        public void set_spread(){} // RVA: 0x7FFAC9846F40
        public void get_priority(){} // RVA: 0x7FFAC9846FA0
        public void set_priority(){} // RVA: 0x7FFAC9846FF0
        public void get_mute(){} // RVA: 0x7FFAC9847050
        public void set_mute(){} // RVA: 0x7FFAC98470A0
        public void get_minDistance(){} // RVA: 0x7FFAC9847100
        public void set_minDistance(){} // RVA: 0x7FFAC9847150
        public void get_maxDistance(){} // RVA: 0x7FFAC98471B0
        public void set_maxDistance(){} // RVA: 0x7FFAC9847200
        public void get_rolloffMode(){} // RVA: 0x7FFAC9847260
        public void set_rolloffMode(){} // RVA: 0x7FFAC98472B0
        public void GetOutputData(){} // RVA: 0x7FFAC9847380 | overloaded x2
        public void GetSpectrumData(){} // RVA: 0x7FFAC9847420 | overloaded x2
        public void get_minVolume(){} // RVA: 0x7FFAC9847430
        public void set_minVolume(){} // RVA: 0x7FFAC98474A0
        public void get_maxVolume(){} // RVA: 0x7FFAC9847500
        public void set_maxVolume(){} // RVA: 0x7FFAC9847570
        public void get_rolloffFactor(){} // RVA: 0x7FFAC98475D0
        public void set_rolloffFactor(){} // RVA: 0x7FFAC9847640
        public void SetSpatializerFloat(){} // RVA: 0x7FFAC98476A0
        public void GetSpatializerFloat(){} // RVA: 0x7FFAC9847710
        public void GetAmbisonicDecoderFloat(){} // RVA: 0x7FFAC9847780
        public void SetAmbisonicDecoderFloat(){} // RVA: 0x7FFAC98477F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Avatar : Object
    {
        public object isValid;
        public object isHuman;
        public object humanDescription;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9830880
        public void get_isValid(){} // RVA: 0x7FFAC98308D0
        public void get_isHuman(){} // RVA: 0x7FFAC9830920
        public void get_humanDescription(){} // RVA: 0x7FFAC9830970
        public void GetAxisLength(){} // RVA: 0x7FFAC98309F0
        public void GetPostRotation(){} // RVA: 0x7FFAC9830A90
        public void Internal_GetAxisLength(){} // RVA: 0x7FFAC9830B60
        public void Internal_GetPostRotation(){} // RVA: 0x7FFAC9830BC0
        public void get_humanDescription_Injected(){} // RVA: 0x7FFAC9830C40
        public void Internal_GetPostRotation_Injected(){} // RVA: 0x7FFAC9830CA0
    }

    public class AvatarBuilder : Object
    {
        // ── Methods ──
        public void BuildHumanAvatar(){} // RVA: 0x7FFAC9830D50
        public void BuildHumanAvatarInternal(){} // RVA: 0x7FFAC9830EC0
        public void BuildGenericAvatar(){} // RVA: 0x7FFAC9830F20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void BuildHumanAvatarInternal_Injected(){} // RVA: 0x7FFAC9830F80
    }

    public class AvatarMask : Object
    {
        public object transformCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9830FE0
        public void Internal_Create(){} // RVA: 0x7FFAC9831070
        public void GetHumanoidBodyPartActive(){} // RVA: 0x7FFAC98310C0
        public void SetHumanoidBodyPartActive(){} // RVA: 0x7FFAC9831120
        public void get_transformCount(){} // RVA: 0x7FFAC9831190
        public void set_transformCount(){} // RVA: 0x7FFAC98311E0
        public void AddTransformPath(){} // RVA: 0x7FFAC98312B0 | overloaded x2
        public void RemoveTransformPath(){} // RVA: 0x7FFAC9831390 | overloaded x2
        public void GetTransformPath(){} // RVA: 0x7FFAC9831400
        public void SetTransformPath(){} // RVA: 0x7FFAC9831460
        public void GetTransformWeight(){} // RVA: 0x7FFAC98314D0
        public void SetTransformWeight(){} // RVA: 0x7FFAC9831530
        public void GetTransformActive(){} // RVA: 0x7FFAC98315A0
        public void SetTransformActive(){} // RVA: 0x7FFAC9831610
    }

}