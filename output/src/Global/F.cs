// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 24
// Methods: 120

public class FILE_TIME : ValueType
{
    public uint dwLowDateTime; // 0x10
    public uint dwHighDateTime; // 0x14

    // ── Methods ──
    public void ToTicks(){} // RVA: 0x7FFD537AA340
    public void ToDateTimeOffset(){} // RVA: 0x7FFD537AA350
}

public class FakeDelegate : Object
{
    public System.Reflection.MethodInfo Method; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void get_Method(){} // RVA: 0x7FFD4E35C380
}

public class Fallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E078F40
    public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
    public void EndInvoke(){} // RVA: 0x7FFD4E078F40
}

public class FallbackKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class FallbackWrapper`1 : Object
{
    public System.Collections.Generic.IEnumerable`1<T> Count;
    public System.Collections.Generic.IList`1<T> Item;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class Fallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class FeatureFidelityGroup : Object
{
    public 0x66504FA8 targetFeatureEnabled; // 0x10
    public 0x66504F50 targetFeatureFidelity; // 0x14
    public 0x66504FA8 currentFeatureEnabled; // 0x18
    public 0x66504F50 currentFeatureFidelity; // 0x1C
    public System.Nullable`1<0x66504FA8> lastSetTargetFeatureEnabled; // 0x20
    public System.Nullable`1<0x66504F50> lastSetTargetFeatureFidelity; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53CF3B50
}

public class FieldDescription : ValueType
{
    public string name;
    public string ussName;
    public System.Func`2<V,T> read;
    public WriteDelegate<V,V,T> write;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E09B8C0
}

public class FillCollection`1 : Object
{
    public int Count; // 0x10
    public FillCollection`1<System.Collections.Generic.KeyValuePair`2<string,int>> IsReadOnly; // 0xFFFF
    public int <Count>k__BackingField; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void set_Count(){} // RVA: 0x7FFD4E090ED0
    public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
    public void CopyTo(){} // RVA: 0x7FFD4E097970
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void Clear(){} // RVA: 0x7FFD4E090980
    public void Contains(){} // RVA: 0x7FFD4E2ADC40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void Remove(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class FilterBlockCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class FinalizationHelper : Object
{
    public LinkedSlotVolatile<int>[] SlotArray; // 0x10
    public bool m_trackAllValues; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E096500
    public void Finalize(){} // RVA: 0x7FFD4E090980
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E079F60
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class FingerData : ValueType
{
    public 0x66360878 Finger; // 0x10
    public JointData[] Joints; // 0x18
    public UnityEngine.Vector3 TipPosition; // 0x20
}

public class FinishFrameRendering : ValueType
{
}

public class FirstValueToUniTaskObserver`1 : Object
{
    public System.Action`1<object> callback;
    public Cysharp.Threading.Tasks.UniTaskCompletionSource`1<T> promise;
    public 0x665483F0 disposable;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration registration;
    public bool hasValue;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFD4E090A10
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class FoldoutList : Object
{
    public System.Collections.Generic.List`1<bool> Item; // 0x10
    public bool Count; // 0x18
    public UnityEngine.Vector2 scrollPos; // 0x1C

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4E4D4BF0
    public void IndexOf(){} // RVA: 0x7FFD4E4D4C80
    public void set_Count(){} // RVA: 0x7FFD4E4D4D10
    public void op_Implicit(){} // RVA: 0x7FFD4E4D4DC0
    public void CompareBaseObjects(){} // RVA: 0x7FFD4E4D4F30
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E4D4FB0
    public void get_Count(){} // RVA: 0x7FFD4E4D5000
    public void get_name(){} // RVA: 0x7FFD4E4D5050
    public void set_name(){} // RVA: 0x7FFD4E4D50E0
    public void set_Item(){} // RVA: 0x7FFD4E4D5240
    public void Instantiate(){} // RVA: 0x7FFD4E4D52D0
    public void .ctor(){} // RVA: 0x7FFD4E4D5320
    public void Initialize(){} // RVA: 0x7FFD4E4D53E0
    public void Equals(){} // RVA: 0x7FFD4E4D54C0
    public void GetHashCode(){} // RVA: 0x7FFD4E4D5560
    public void get_Item(){} // RVA: 0x7FFD4E4D5600
}

public class FontTextureRebuildCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class ForceOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D74E70
    public void set_enabled(){} // RVA: 0x7FFD54D74EC0
    public void get_x(){} // RVA: 0x7FFD54D74F20
    public void set_x(){} // RVA: 0x7FFD54D74F90
    public void get_y(){} // RVA: 0x7FFD54D74FF0
    public void set_y(){} // RVA: 0x7FFD54D75060
    public void get_z(){} // RVA: 0x7FFD54D750C0
    public void set_z(){} // RVA: 0x7FFD54D75130
    public void get_xMultiplier(){} // RVA: 0x7FFD54D75190
    public void set_xMultiplier(){} // RVA: 0x7FFD54D751E0
    public void get_yMultiplier(){} // RVA: 0x7FFD54D75240
    public void set_yMultiplier(){} // RVA: 0x7FFD54D75290
    public void get_zMultiplier(){} // RVA: 0x7FFD54D752F0
    public void set_zMultiplier(){} // RVA: 0x7FFD54D75340
    public void get_space(){} // RVA: 0x7FFD54D753A0
    public void set_space(){} // RVA: 0x7FFD54D753F0
    public void get_randomized(){} // RVA: 0x7FFD54D75450
    public void set_randomized(){} // RVA: 0x7FFD54D754A0
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D74E70
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D74EC0
    public void get_x_Injected(){} // RVA: 0x7FFD54D75500
    public void set_x_Injected(){} // RVA: 0x7FFD54D75560
    public void get_y_Injected(){} // RVA: 0x7FFD54D755C0
    public void set_y_Injected(){} // RVA: 0x7FFD54D75620
    public void get_z_Injected(){} // RVA: 0x7FFD54D75680
    public void set_z_Injected(){} // RVA: 0x7FFD54D756E0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFD54D75190
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFD54D751E0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFD54D75240
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFD54D75290
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFD54D752F0
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFD54D75340
    public void get_space_Injected(){} // RVA: 0x7FFD54D753A0
    public void set_space_Injected(){} // RVA: 0x7FFD54D753F0
    public void get_randomized_Injected(){} // RVA: 0x7FFD54D75450
    public void set_randomized_Injected(){} // RVA: 0x7FFD54D754A0
}

public class FovCache : ValueType
{
    public UnityEngine.Rect mFovSoftGuideRect; // 0x10
    public UnityEngine.Rect mFovHardGuideRect; // 0x20
    public float mFovH; // 0x30
    public float mFov; // 0x34
    public float mOrthoSizeOverDistance; // 0x38
    public float mAspect; // 0x3C
    public UnityEngine.Rect mSoftGuideRect; // 0x40
    public UnityEngine.Rect mHardGuideRect; // 0x50

    // ── Methods ──
    public void UpdateCache(){} // RVA: 0x7FFD4FC44D60
    public void ScreenToFOV(){} // RVA: 0x7FFD4FC45120
}

public class Frame : Object
{
    public int frameNumber; // 0x10
    public int frameDelay; // 0x14
    public float[] Visemes; // 0x18
    public float laughterScore; // 0x20

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4EE93BF0
    public void Equals(){} // RVA: 0x7FFD4EE93C40
    public void GetHashCode(){} // RVA: 0x7FFD4EE93C40
    public void op_Implicit(){} // RVA: 0x7FFD4EE93CA0
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EE93BF0
    public void .ctor(){} // RVA: 0x7FFD4EE93D30
    public void Initialize(){} // RVA: 0x7FFD4EE93E00
    public void get_name(){} // RVA: 0x7FFD4EE93E90
    public void set_name(){} // RVA: 0x7FFD4EE93BF0
}

public class FrameReadyEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD55D20
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class FromAsyncTrimPromise`1 : Task`1
{
    public 0x6641E4D0 s_completeFromAsyncResult;
    public T m_thisRef;
    public System.Func`3<T,System.IAsyncResult,T> m_endMethod;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void CompleteFromAsyncResult(){} // RVA: 0x7FFD4E090A10
    public void Complete(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class Func`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}
