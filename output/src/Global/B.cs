// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 31
// Methods: 151

public class BakeTextureOutput : ValueType
{
    public ector vertices; // 0x10
    public ector indices; // 0x18
}

public class BakedSolution : Object
{
    public float m_FrustumSizeIntSpace; // 0x10
    public ringToBytes m_AspectStretcher; // 0x14
    public bool m_HasBones; // 0x20
    public double m_SqrPolygonDiagonal; // 0x28
    public URA.woDigitYearMax<URA.woDigitYearMax<lfFrustumHeight>> m_OriginalPolygon; // 0x30
    public URA.woDigitYearMax<URA.woDigitYearMax<lfFrustumHeight>> m_Solution; // 0x38
    public double k_ClipperEpsilon;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC6B2A0
    public void IsValid(){} // RVA: 0x7FFD4FC6B3D0
    public void ConfinePoint(){} // RVA: 0x7FFD4FC6B3E0
    public void FindIntersection(){} // RVA: 0x7FFD4FC6BA50
    public void <ConfinePoint>g__IntPointLerp|9_0(){} // RVA: 0x7FFD4FC6BC70
    public void <ConfinePoint>g__IsInsideOriginal|9_1(){} // RVA: 0x7FFD4FC6BD10
    public void <ConfinePoint>g__ClosestPointOnSegment|9_2(){} // RVA: 0x7FFD4FC6BDF0
    public void <ConfinePoint>g__DoesIntersectOriginal|9_3(){} // RVA: 0x7FFD4FC6BE80
    public void <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(){} // RVA: 0x7FFD4FC6C0F0
}

public class BakingStateCache : ValueType
{
    public idity offsetter; // 0x10
    public URA.woDigitYearMax<C4> solutions; // 0x18
    public C4 rightCandidate; // 0x20
    public C4 leftCandidate; // 0x30
    public URA.woDigitYearMax<URA.woDigitYearMax<lfFrustumHeight>> maxCandidate; // 0x40
    public float stepSize; // 0x48
    public float maxFrustumHeight; // 0x4C
    public float userSetMaxFrustumHeight; // 0x50
    public float theoriticalMaxFrustumHeight; // 0x54
    public float currentFrustumHeight; // 0x58
    public float bakeTime; // 0x5C
}

public class BaseVisualElementScheduledItem : ScheduledItem
{
    public ÎÏÌÎÎÎÌÌÌ.omLeftRadius element; // 0x38
    public bool isScheduled; // 0x40
    public ÎÏÌÎÎÎÌÌÌ.? m_Activator; // 0x48

    // ── Methods ──
    public void get_element(){} // RVA: 0x7FFD4E5F0140
    public void set_element(){} // RVA: 0x7FFD4E5F0C20
    public void .ctor(){} // RVA: 0x7FFD55013DB0
    public void StartingIn(){} // RVA: 0x7FFD55013FD0
    public void Every(){} // RVA: 0x7FFD55013FE0
    public void OnItemUnscheduled(){} // RVA: 0x7FFD550140F0
    public void Resume(){} // RVA: 0x7FFD55014130
    public void Pause(){} // RVA: 0x7FFD55014160
    public void ExecuteLater(){} // RVA: 0x7FFD55014190
    public void OnPanelActivate(){} // RVA: 0x7FFD55014210
    public void OnPanelDeactivate(){} // RVA: 0x7FFD550142E0
    public void CanBeActivated(){} // RVA: 0x7FFD55014360
}

public class BatchModeUpdate : ValueType
{
}

public class BinderState : Object
{
    public int[] m_argsMap; // 0x10
    public int m_originalSize; // 0x18
    public bool m_isParamArray; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A95550
}

public class BindingSyntax : ValueType
{
    public ilAddress.epAliveInterval valid; // 0x10
    public ilAddress.s bindingIndex; // 0x18
    public int binding; // 0x20

    // ── Methods ──
    public void get_valid(){} // RVA: 0x7FFD5495F330
    public void get_bindingIndex(){} // RVA: 0x7FFD5495F3A0
    public void get_binding(){} // RVA: 0x7FFD5495F420
    public void .ctor(){} // RVA: 0x7FFD5495F520
    public void WithName(){} // RVA: 0x7FFD5495F5E0
    public void WithPath(){} // RVA: 0x7FFD5495F740
    public void WithGroup(){} // RVA: 0x7FFD5495F8B0
    public void WithGroups(){} // RVA: 0x7FFD5495FAC0
    public void WithInteraction(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void WithInteractions(){} // RVA: 0x7FFD5495FF60
    public void WithProcessor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void WithProcessors(){} // RVA: 0x7FFD54960400
    public void Triggering(){} // RVA: 0x7FFD54960690
    public void To(){} // RVA: 0x7FFD549608A0
    public void NextBinding(){} // RVA: 0x7FFD54960A40
    public void PreviousBinding(){} // RVA: 0x7FFD54960A80
    public void NextPartBinding(){} // RVA: 0x7FFD54960AC0
    public void PreviousPartBinding(){} // RVA: 0x7FFD54960B50
    public void NextCompositeBinding(){} // RVA: 0x7FFD54960BE0
    public void PreviousCompositeBinding(){} // RVA: 0x7FFD54960C20
    public void Iterate(){} // RVA: 0x7FFD54960C60
    public void IterateCompositeBinding(){} // RVA: 0x7FFD54960D60
    public void IteratePartBinding(){} // RVA: 0x7FFD54961080
    public void Erase(){} // RVA: 0x7FFD549612E0
    public void InsertPartBinding(){} // RVA: 0x7FFD54961720
}

public class BitRegion : ValueType
{
    public object isEmpty;

    // ── Methods ──
    public void get_isEmpty(){} // RVA: 0x7FFD5498A470
    public void .ctor(){} // RVA: 0x7FFD5498A480 | overloaded x2
    public void Overlap(){} // RVA: 0x7FFD5498A490
}

public class BlendshapesConfig : Object
{
    public ure skinnedMeshRenderer; // 0x10
    public int blendShapeCount; // 0x18
    public string[] blendshapeNames; // 0x20
    public float[] blendshapeWeights; // 0x28

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4F92A230
    public void Equals(){} // RVA: 0x7FFD4F92A430
    public void GetHashCode(){} // RVA: 0x7FFD4F92A830
    public void op_Implicit(){} // RVA: 0x7FFD4F92AA30
    public void CompareBaseObjects(){} // RVA: 0x7FFD4F92AC40
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F92AE50
    public void GetCachedPtr(){} // RVA: 0x7FFD4F92B060
    public void get_name(){} // RVA: 0x7FFD4F92B460
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Initialize(){} // RVA: 0x7FFD4F92B660
    public void Instantiate(){} // RVA: 0x7FFD4F92B860
}

public class BlendshapesConfigForExport : Object
{
    public string skinnedMeshRendererPath; // 0x10
    public int blendShapeCount; // 0x18
    public string[] blendshapeNames; // 0x20
    public float[] blendshapeWeights; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Block : ValueType
{
    public HeadAnimatorForExport Bytes; // 0x10
    public int AllocatedBytes; // 0x20
    public int Alignment; // 0x24
    public byte Log2Alignment; // 0x28
    public byte Padding0; // 0x29
    public ushort Padding1; // 0x2A
    public uint Padding2; // 0x2C

    // ── Methods ──
    public void get_Bytes(){} // RVA: 0x7FFD5492F3E0
    public void get_AllocatedBytes(){} // RVA: 0x7FFD5492F3F0
    public void get_Alignment(){} // RVA: 0x7FFD5492F400
    public void set_Alignment(){} // RVA: 0x7FFD5492F410
    public void Dispose(){} // RVA: 0x7FFD5492F460
    public void TryFree(){} // RVA: 0x7FFD5492F460
}

public class Bone : ValueType
{
    public int isSimulated; // 0x10
    public int parentIndex; // 0x14
    public bool isEndBone; // 0x18
    public InsertTextStyleInTextProcessingArray simulatedType; // 0x1C
    public int boneChainIndex; // 0x20
    public es.eout localPoseRotation; // 0x24
    public es.ap localBoneVector; // 0x34
    public es.ap localPoseBoneVector; // 0x40
    public es.ap originalLocalPosition; // 0x4C
    public es.eout originalLocalRotation; // 0x58
    public es.ap originalLocalVector; // 0x68
    public float originalLocalBoneLength; // 0x74
    public float globalRestLength; // 0x78
    public es.ap originalRootEndpoint; // 0x7C
    public es.ap originalLocalGravityNormal; // 0x88
    public es.ap beginPoint; // 0x94
    public es.ap endPoint; // 0xA0
    public es.ap prevVelocity; // 0xAC
    public es.ap immobileEndpoint; // 0xB8
    public es.ap prevEndPoint; // 0xC4
    public es.ap prevVector; // 0xD0
    public es.eout prevLocalRotation; // 0xDC
    public float totalRestLength; // 0xEC
    public float totalLength; // 0xF0
    public float totalMinRestLength; // 0xF4
    public float totalMaxRestLength; // 0xF8
    public ÏÍÏÍÍ grabStatus; // 0xFC
    public float pull; // 0x100
    public float spring; // 0x104
    public float stiffness; // 0x108
    public float gravity; // 0x10C
    public float gravityFalloff; // 0x110
    public float immobile; // 0x114
    public float radiusBegin; // 0x118
    public float radiusEnd; // 0x11C
    public float globalRadiusBegin; // 0x120
    public float globalRadiusEnd; // 0x124
    public es.gine.XR maxAngle; // 0x128
    public es.ap limitAxisX; // 0x130
    public es.ap limitAxisY; // 0x13C
    public es.ap limitRotation; // 0x148
    public float stretchMotion; // 0x154
    public float stretch; // 0x158
    public float squish; // 0x15C

    // ── Methods ──
    public void get_isSimulated(){} // RVA: 0x7FFD55262AC0
}

public class BoolChildrenSection : ChildrenSection`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD56CF3280
}

public class BoolDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EF032D0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class BoolEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD56B837A0
}

public class BoundedChannelReader : ChannelReader`1
{
    public bstacleAvoidance.ition_Injected<T1717741984> _parent;
    public bstacleAvoidance.al<T1717741984> _readerSingleton;
    public bstacleAvoidance.al<bool> _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryRead(){} // RVA: 0x7FFD4E079F60
    public void WaitToReadAsync(){}
    public void DequeueItemAndPostProcess(){} // RVA: 0x7FFD4E2ADC40
}

public class BoundedChannelWriter : ChannelWriter`1
{
    public bstacleAvoidance.ition_Injected<T1717742000> _parent;
    public bstacleAvoidance.ernal_Injected<T1717742000> _writerSingleton;
    public bstacleAvoidance.al<bool> _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryComplete(){} // RVA: 0x7FFD4E079F60
    public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7FFD4E2ADC40
}

public class BoxAvoidance : Object
{
    public n<T1717690976,int> _wrapper;

    // ── Methods ──
    public void ToInt(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class BrainEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC174A0
}

public class BrainFrame : Object
{
    public int Active; // 0x10
    public EXTERNAL_INDEX_REF_SIG.ty blend; // 0x18
    public EXTERNAL_INDEX_REF_SIG.ty workingBlend; // 0x20
    public EXTERNAL_INDEX_REF_SIG.enGenericInterfaceType workingBlendSource; // 0x28
    public float deltaTimeOverride; // 0x30
    public float blendStartPosition; // 0x34

    // ── Methods ──
    public void get_Active(){} // RVA: 0x7FFD4FC175C0
    public void .ctor(){} // RVA: 0x7FFD4FC175E0
}

public class Bucket : Object
{
    public int Id;
    public T1717745648[][] _buffers;
    public int _poolId;
    public sageKind.ceJapaneseEraYearRanges _lock;
    public int _index;

    // ── Methods ──
    public void .ctor(){}
    public void get_Id(){} // RVA: 0x7FFD4E079960
    public void Rent(){} // RVA: 0x7FFD4E078E90
    public void Return(){} // RVA: 0x7FFD4E090A40
}

public class BufferedAsyncEnumerable : Object
{
    public URA.woDigitYearMax<T1717652448> _buffer;

    // ── Methods ──
    public void GetAsyncEnumerator(){}
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class BufferedAudioStream : Object
{
    public bool VerboseLogging;
    public t audio; // 0x10
    public float[] audioBuffer; // 0x18
    public int writePos; // 0x20
    public float bufferLengthSeconds;
    public int sampleRate;
    public int bufferSize;
    public float playbackDelayTimeSeconds;
    public float playbackDelayRemaining; // 0x24
    public float remainingBufferTime; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53C384F0
    public void Update(){} // RVA: 0x7FFD53C386E0
    public void Stop(){} // RVA: 0x7FFD53C388D0
    public void AddData(){} // RVA: 0x7FFD53C389A0
}

public class Builder : Object
{
    public string Capacity; // 0x10
    public string Count; // 0x18
    public object Item; // 0x20
    public 2.Code System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x28
    public int <stateSizeInBytes>k__BackingField; // 0x2C
    public string m_ExtendsLayout; // 0x30
    public aphy<bool> <updateBeforeRender>k__BackingField; // 0x38
    public int m_ControlCount; // 0x3C
    public s[] m_Controls; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void get_Capacity(){} // RVA: 0x7FFD4E079960
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void set_Count(){} // RVA: 0x7FFD4E090ED0
    public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFD4E0909B0
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void set_Item(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
    public void MoveToImmutable(){} // RVA: 0x7FFD4E2ADC40
    public void Clear(){} // RVA: 0x7FFD4E090980
    public void Insert(){} // RVA: 0x7FFD4E2ADC40
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void Remove(){} // RVA: 0x7FFD4E2ADC40
    public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
    public void Contains(){} // RVA: 0x7FFD4E2ADC40
    public void CopyTo(){} // RVA: 0x7FFD4E097970
    public void EnsureCapacity(){} // RVA: 0x7FFD4E090ED0
    public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class BuiltInUriParser : UriParser
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD547B1540
}

public class Burst : ValueType
{
    public float time; // 0x10
    public k count; // 0x18
    public int minCount; // 0x38
    public float maxCount; // 0x3C
    public float cycleCount; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54D709D0 | overloaded x5
    public void get_time(){} // RVA: 0x7FFD4E364D20
    public void set_time(){} // RVA: 0x7FFD4FEBB910
    public void get_count(){} // RVA: 0x7FFD54D70A50
    public void set_count(){} // RVA: 0x7FFD54D70A70
    public void get_minCount(){} // RVA: 0x7FFD54D70AD0
    public void set_minCount(){} // RVA: 0x7FFD54D70AE0
    public void get_maxCount(){} // RVA: 0x7FFD54D70AF0
    public void set_maxCount(){} // RVA: 0x7FFD54D70B00
    public void get_cycleCount(){} // RVA: 0x7FFD54D70B10
    public void set_cycleCount(){} // RVA: 0x7FFD54D70B20
    public void get_repeatInterval(){} // RVA: 0x7FFD54D5FB10
    public void set_repeatInterval(){} // RVA: 0x7FFD54D70BD0
    public void get_probability(){} // RVA: 0x7FFD54D70C80
    public void set_probability(){} // RVA: 0x7FFD54D70C90
}

public class BurstCompilerHelper : Object
{
    public Rigidbody IsBurstEnabledImpl;
    public bool IsBurstGenerated; // 0x8

    // ── Methods ──
    public void IsBurstEnabled(){} // RVA: 0x7FFD54926440
    public void DiscardedMethod(){} // RVA: 0x7FFD4FDDD6A0
    public void IsCompiledByBurst(){} // RVA: 0x7FFD54926490
    public void .cctor(){} // RVA: 0x7FFD54926570
    public void IsBurstEnabled$BurstManaged(){} // RVA: 0x7FFD549267F0
}

public class Button : ValueType
{
    public ePathName117.ÌÎÌÎÏÏÌÎÏÍÍÌÌÌÏÌÍÎÍÎÌÏ icon; // 0x10
    public ÍÏÎÍÌÍÌÎÌÏÌÍÏÍÌÏÎÎÎÎÏÏ text; // 0x18
    public string previousText; // 0x20
}

public class ButtonClickedEvent : UnityEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC74470
}

public class ButtonState : Object
{
    public ighlightedTrigger m_Button; // 0x10
    public tMinimumThreshold m_EventData; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F6F7180
}

public class bucket : ValueType
{
    public object key; // 0x10
    public object val; // 0x18
    public int hash_coll; // 0x20
}
