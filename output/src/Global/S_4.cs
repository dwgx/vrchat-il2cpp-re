// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 77
// Methods: 304

public class StateEventBuffer : ValueType
{
    public UnityEngine.InputSystem.LowLevel.StateEvent stateEvent; // 0x10
    public int kMaxSize;
    public <data>e__FixedBuffer data; // 0x29
}

public class StateHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC8C3FF80
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class StateOrProvinceName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368A40
}

public class StateSettings : ValueType
{
    public float Default; // 0x10
    public float deadMuscleWeight; // 0x14
    public float deadMuscleDamper; // 0x18
    public float maxFreezeSqrVelocity; // 0x1C
    public bool freezePermanently; // 0x20
    public bool enableAngularLimitsOnKill; // 0x21
    public bool enableInternalCollisionsOnKill; // 0x22

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FBD8C0
    public void get_Default(){} // RVA: 0x7FFAC2FBD900
}

public class StateUpHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC8C3FEF0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class StaticGetter`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class StaticTypeReinitAttribute : Attribute
{
    public System.Type reinitType; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
}

public class StationOccupantDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB24A0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class StationOccupiedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AE32D0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class StatusDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class SteamVR_Utils : Object
{
    public string secretKey;

    // ── Methods ──
    public void IsValid(){} // RVA: 0x7FFAC8C33DB0 | overloaded x2
    public void Slerp(){} // RVA: 0x7FFAC8C33E20
    public void Lerp(){} // RVA: 0x7FFAC8C34000 | overloaded x3
    public void InverseLerp(){} // RVA: 0x7FFAC8C340A0 | overloaded x3
    public void Saturate(){} // RVA: 0x7FFAC8C340D0 | overloaded x2
    public void Abs(){} // RVA: 0x7FFAC8C34130 | overloaded x2
    public void _copysign(){} // RVA: 0x7FFAC8C34170
    public void GetRotation(){} // RVA: 0x7FFAC8C341B0
    public void GetPosition(){} // RVA: 0x7FFAC8C343C0
    public void GetScale(){} // RVA: 0x7FFAC8C343F0
    public void GetLossyScale(){} // RVA: 0x7FFAC8C34570
    public void GetBadMD5Hash(){} // RVA: 0x7FFAC8C34670 | overloaded x2
    public void GetBadMD5HashFromFile(){} // RVA: 0x7FFAC8C34920
    public void SanitizePath(){} // RVA: 0x7FFAC8C34990
    public void FindType(){} // RVA: 0x7FFAC8C34AC0
    public void CallSystemFn(){} // RVA: 0x7FFAC8C34C10
    public void TakeStereoScreenshot(){} // RVA: 0x7FFAC8C34DB0
}

public class StopSendingMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFAC96020F0
}

public class StoreInstance : Object
{
    public string storeName; // 0x10
    public UnityEngine.Purchasing.Extension.IStore instance; // 0x18

    // ── Methods ──
    public void get_storeName(){} // RVA: 0x7FFAC2F3C380
    public void get_instance(){} // RVA: 0x7FFAC2F247C0
    public void .ctor(){} // RVA: 0x7FFAC34EC240
}

public class StreamTokenReader : Object
{
    public System.IO.StreamReader NumCharEncountered; // 0x10
    public int _numCharRead; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC44F7620
    public void Read(){} // RVA: 0x7FFAC84021A0
    public void get_NumCharEncountered(){} // RVA: 0x7FFAC3157800
}

public class StringCache : ValueType
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,string>> CachePool;
    public VRC.Core.Pool.PooledObject`1<System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,string>> Cache; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4AA1C40
    public void Create(){} // RVA: 0x7FFACBE0B250
    public void Dispose(){} // RVA: 0x7FFACBE0B4C0
    public void Get(){} // RVA: 0x7FFACBE0B500
    public void .cctor(){} // RVA: 0x7FFACBE0B6D0
}

public class StringMaker : Object
{
    public string[] aStrings; // 0x10
    public uint cStringsMax; // 0x18
    public uint cStringsUsed; // 0x1C
    public System.Text.StringBuilder _outStringBuilder; // 0x20
    public char[] _outChars; // 0x28
    public int _outIndex; // 0x30

    // ── Methods ──
    public void HashString(){} // RVA: 0x7FFAC8401C40
    public void HashCharArray(){} // RVA: 0x7FFAC8401CA0
    public void .ctor(){} // RVA: 0x7FFAC8401D00
    public void CompareStringAndChars(){} // RVA: 0x7FFAC8401E20
    public void MakeString(){} // RVA: 0x7FFAC8401E90
}

public class StringOutFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class StringParser : ValueType
{
    public System.ReadOnlySpan`1<char> _str; // 0x10
    public char _ch; // 0x20
    public int _pos; // 0x24
    public int _len; // 0x28

    // ── Methods ──
    public void NextChar(){} // RVA: 0x7FFAC855F590
    public void NextNonDigit(){} // RVA: 0x7FFAC855F5D0
    public void TryParse(){} // RVA: 0x7FFAC855F630
    public void ParseInt(){} // RVA: 0x7FFAC855F960
    public void ParseTime(){} // RVA: 0x7FFAC855FA50
    public void SkipBlanks(){} // RVA: 0x7FFAC855FDE0
}

public class StringSerializer : ValueType
{
    public string _serializedText; // 0x10
    public int _currentTokenStartIndex; // 0x18
    public 0x6B0BD768 _state; // 0x1C

    // ── Methods ──
    public void GetSerializedString(){} // RVA: 0x7FFAC8504A60
    public void GetDeserializedTimeZoneInfo(){} // RVA: 0x7FFAC8505600
    public void .ctor(){} // RVA: 0x7FFAC8505820
    public void SerializeSubstitute(){} // RVA: 0x7FFAC85058A0
    public void SerializeTransitionTime(){} // RVA: 0x7FFAC8505950
    public void VerifyIsEscapableCharacter(){} // RVA: 0x7FFAC8505DF0
    public void SkipVersionNextDataFields(){} // RVA: 0x7FFAC8505EA0
    public void GetNextStringValue(){} // RVA: 0x7FFAC85060C0
    public void GetNextDateTimeValue(){} // RVA: 0x7FFAC85064E0
    public void GetNextTimeSpanValue(){} // RVA: 0x7FFAC8506600
    public void GetNextInt32Value(){} // RVA: 0x7FFAC85066D0
    public void GetNextAdjustmentRuleArrayValue(){} // RVA: 0x7FFAC85067F0
    public void GetNextAdjustmentRuleValue(){} // RVA: 0x7FFAC8506A60
    public void GetNextTransitionTimeValue(){} // RVA: 0x7FFAC8506F10
}

public class String_CreateStringFromEncoding : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89735E0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class Struct256Bit : ValueType
{
    public System.Decimal d1; // 0x10
    public System.Decimal d2; // 0x20
}

public class StructGetter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class StructuredPerspectiveData : ValueType
{
    public int size;
    public UnityEngine.Vector2 depthImageSize; // 0x10
    public UnityEngine.Vector2 depthPrincipalPoint; // 0x18
    public UnityEngine.Vector2 depthFocalLength; // 0x20
    public float farClip; // 0x28
    public float nearClip; // 0x2C
    public UnityEngine.Matrix4x4 extrinsics; // 0x30
    public UnityEngine.Matrix4x4 extrinsicsInverse; // 0x70
    public UnityEngine.Vector4 crop; // 0xB0
    public float clipEpsilon; // 0xC0
    public UnityEngine.Vector3 cameraPosition; // 0xC4
    public UnityEngine.Vector3 cameraNormal; // 0xD0
    public float padding; // 0xDC

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC495FC70
}

public class StudioLiteLookData : Object
{
    public 0x6B186940 shadowCastingMode; // 0x10
    public bool receiveShadows; // 0x14
    public bool interpolateLightProbes; // 0x15
    public bool showMain; // 0x16
    public bool showMainEdge; // 0x17
    public bool showFill; // 0x18
    public bool showFillEdge; // 0x19

    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFAC9E72660
}

public class StudioLiteMeshData : Object
{
    public int perspectiveLimit; // 0x10
    public 0x6B2A9E80 normalGenerationTechnique; // 0x14
    public 0x6B2A9E28 meshDensity; // 0x18
    public bool enableAdaptiveClipThresholding; // 0x1C
    public float clippingThreshold; // 0x20
    public float ditheringWidth; // 0x24
    public float invalidEdgeWidth; // 0x28
    public float invalidStrength; // 0x2C
    public float sobelFilterMultiplier; // 0x30
    public bool blurFilterEnable; // 0x34
    public float blurFilterRadius; // 0x38
    public float depthBiasCompensation; // 0x3C
    public float edgeCompressionNoiseThreshold; // 0x40
    public bool pausePlayerWhenInvisible; // 0x44
    public bool pauseDataGenerationWhenInvisible; // 0x45

    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFAC9E72490
}

public class StudioLiteMeshSourceShaderIds : Object
{
    public int _EdgeTriangleBuffer;
    public int _MainPerspectiveIndex; // 0x4

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC49729F0
}

public class StudioLookData : Object
{
    public 0x6B186940 shadowCastingMode; // 0x10
    public bool receiveShadows; // 0x14
    public bool interpolateLightProbes; // 0x15

    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFAC9E72630
}

public class StudioMeshData : Object
{
    public float volumeDensity; // 0x10
    public float surfaceSensitivity; // 0x14
    public float depthBiasCompensation; // 0x18
    public float weightUnknown; // 0x1C
    public float weightUnseenMax; // 0x20
    public float weightUnseenMin; // 0x24
    public float weightUnseenFalloffPower; // 0x28
    public float weightInFrontMax; // 0x2C
    public float weightInFrontMin; // 0x30
    public int normalWeightResolutionReduction; // 0x34
    public bool pausePlayerWhenInvisible; // 0x38
    public bool pauseDataGenerationWhenInvisible; // 0x39
    public bool enableSurfaceSmoothing; // 0x3A
    public float surfaceSmoothingRadius; // 0x3C
    public uint surfaceBufferCapacity; // 0x40
    public float viewDependentColorBlendWeight; // 0x44
    public float surfaceNormalColorBlendWeight; // 0x48
    public float surfaceDisparityColorThreshold; // 0x4C
    public float disparityBlendWidth; // 0x50
    public 0x6B2B97B8 untexturedGeometrySettings; // 0x54
    public bool enableEdgeMask; // 0x58
    public AdvancedPerspectiveSettings perspective0Settings; // 0x60
    public AdvancedPerspectiveSettings perspective1Settings; // 0x68

    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFAC9E71F40
}

public class StudioMeshSourceShaderIds : Object
{
    public int _GlobalViewDependentColorBlendWeight;
    public int _SurfaceNormalColorBlendingPower; // 0x4
    public int _PerViewDisparityThreshold; // 0x8
    public int _PerViewDisparityBlendWidth; // 0xC
    public int _PerspectiveColorBlending; // 0x10
    public int _UntexturedFragDefaultColor; // 0x14
    public string _UntexturedFragmentInfer; // 0x18
    public string _UntexturedFragmentColorize; // 0x20
    public string _UntexturedFragmentClip; // 0x28
    public int _SdfBuffer; // 0x30
    public int _SdfWeightBuffer; // 0x34
    public int _VoxelGridX; // 0x38
    public int _VoxelGridY; // 0x3C
    public int _VoxelGridZ; // 0x40
    public int _VoxelGridf; // 0x44
    public int _BoundsSize; // 0x48
    public int _BoundsCenter; // 0x4C
    public int _IsoLODScalar; // 0x50
    public int _SdfSensitivity; // 0x54
    public int _WeightUnknown; // 0x58
    public int _WeightUnseenMax; // 0x5C
    public int _WeightUnseenMin; // 0x60
    public int _WeightUnseenFalloffPower; // 0x64
    public int _WeightInFrontMax; // 0x68
    public int _WeightInFrontMin; // 0x6C
    public int _NormalTexture; // 0x70
    public int _NormalTexture_TexelSize; // 0x74
    public int _NormalWeights; // 0x78
    public int _PerspectiveGeometryData; // 0x7C
    public int _WSDepth; // 0x80
    public int _CurrentPerspective; // 0x84
    public int _DispatchSize; // 0x88
    public int _MainTex; // 0x8C
    public int _Points; // 0x90
    public int _SdfAlpha; // 0x94
    public int _PointSize; // 0x98
    public int _LocalToWorldMatrix; // 0x9C
    public int _PingData; // 0xA0
    public int _PongData; // 0xA4
    public int _DataSize; // 0xA8
    public int _Axis; // 0xAC
    public int _PowerAmount; // 0xB0
    public int _GaussianNormalization; // 0xB4
    public int _GaussianExponential; // 0xB8
    public int _TriangleDataBuffer; // 0xBC
    public int _SdfThreshold; // 0xC0
    public int _TriangleBuffer; // 0xC4
    public int _TriangleCullingThreshold; // 0xC8
    public int _IndirectArgs; // 0xCC

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC496DB70
}

public class StyleData : ValueType
{
    public T startValue;
    public T endValue;
    public T reversingAdjustedStartValue;
    public T currentValue;
}

public class SubDouble : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEC470
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubEmittersModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC994EDB0
    public void set_enabled(){} // RVA: 0x7FFAC994EE00
    public void get_subEmittersCount(){} // RVA: 0x7FFAC994EE60
    public void AddSubEmitter(){} // RVA: 0x7FFAC994EF30 | overloaded x2
    public void RemoveSubEmitter(){} // RVA: 0x7FFAC994EFC0 | overloaded x2
    public void RemoveSubEmitterObject(){} // RVA: 0x7FFAC994EFC0
    public void SetSubEmitterSystem(){} // RVA: 0x7FFAC994F020
    public void SetSubEmitterType(){} // RVA: 0x7FFAC994F090
    public void SetSubEmitterProperties(){} // RVA: 0x7FFAC994F100
    public void SetSubEmitterEmitProbability(){} // RVA: 0x7FFAC994F170
    public void GetSubEmitterSystem(){} // RVA: 0x7FFAC994F1E0
    public void GetSubEmitterType(){} // RVA: 0x7FFAC994F240
    public void GetSubEmitterProperties(){} // RVA: 0x7FFAC994F2A0
    public void GetSubEmitterEmitProbability(){} // RVA: 0x7FFAC994F300
    public void get_enabled_Injected(){} // RVA: 0x7FFAC994EDB0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC994EE00
    public void get_subEmittersCount_Injected(){} // RVA: 0x7FFAC994EE60
    public void AddSubEmitter_Injected(){} // RVA: 0x7FFAC994EEB0
    public void RemoveSubEmitter_Injected(){} // RVA: 0x7FFAC994EF60
    public void RemoveSubEmitterObject_Injected(){} // RVA: 0x7FFAC994EFC0
    public void SetSubEmitterSystem_Injected(){} // RVA: 0x7FFAC994F020
    public void SetSubEmitterType_Injected(){} // RVA: 0x7FFAC994F090
    public void SetSubEmitterProperties_Injected(){} // RVA: 0x7FFAC994F100
    public void SetSubEmitterEmitProbability_Injected(){} // RVA: 0x7FFAC994F170
    public void GetSubEmitterSystem_Injected(){} // RVA: 0x7FFAC994F1E0
    public void GetSubEmitterType_Injected(){} // RVA: 0x7FFAC994F240
    public void GetSubEmitterProperties_Injected(){} // RVA: 0x7FFAC994F2A0
    public void GetSubEmitterEmitProbability_Injected(){} // RVA: 0x7FFAC994F300
}

public class SubInt16 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEBB40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubInt32 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEBC90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubInt64 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEBDD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubOvfInt16 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DECA10
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubOvfInt32 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DECC30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubOvfInt64 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DECDD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubOvfUInt16 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DECFC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubOvfUInt32 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DED1E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubOvfUInt64 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DED3B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubSingle : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEC310
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubUInt16 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEBF20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubUInt32 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEC070
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubUInt64 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEC1C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SubmitEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C47790
}

public class Subscriber : Object
{
    public UnityEngine.InputSystem.InputRemoting owner; // 0x10
    public System.IObserver`1<Message> observer; // 0x18

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC9602020
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Subscription : Object
{
    public object gate;
    public Cysharp.Threading.Tasks.Internal.AsyncSubject`1<T> parent;
    public System.IObserver`1<T> unsubscribeTarget;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class Surname : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8369050
}

public class SwitchCaseProxy : Object
{
    public System.Linq.Expressions.SwitchCase Body; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72460
    public void get_Body(){} // RVA: 0x7FFAC356B610
    public void get_TestValues(){} // RVA: 0x7FFAC3511350
}

public class SwitchExpressionProxy : Object
{
    public System.Linq.Expressions.SwitchExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72540
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_Cases(){} // RVA: 0x7FFAC37735E0
    public void get_Comparison(){} // RVA: 0x7FFAC3510100
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_DefaultBody(){} // RVA: 0x7FFAC3773190
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_SwitchValue(){} // RVA: 0x7FFAC356B610
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class SwitchFullInputReport : ValueType
{
    public int kSize;
    public byte ExpectedReportId;
    public byte reportId; // 0x10
    public byte buttons0; // 0x13
    public byte buttons1; // 0x14
    public byte buttons2; // 0x15
    public byte left0; // 0x16
    public byte left1; // 0x17
    public byte left2; // 0x18
    public byte right0; // 0x19
    public byte right1; // 0x1A
    public byte right2; // 0x1B

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9657FF0
}

public class SwitchHIDGenericInputReport : ValueType
{
    public byte Format; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFAC96582A0
}

public class SwitchInputOnlyReport : ValueType
{
    public int kSize;
    public byte buttons0; // 0x10
    public byte buttons1; // 0x11
    public byte hat; // 0x12
    public byte leftX; // 0x13
    public byte leftY; // 0x14
    public byte rightX; // 0x15
    public byte rightY; // 0x16

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9657A00
}

public class SwitchMagicOutputHIDBluetooth : ValueType
{
    public int Type;
    public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
    public SwitchMagicOutputReport report; // 0x18

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFAC96582B0
    public void get_typeStatic(){} // RVA: 0x7FFAC96582B0
    public void Create(){} // RVA: 0x7FFAC96582C0
}

public class SwitchMagicOutputHIDUSB : ValueType
{
    public int Type;
    public UnityEngine.InputSystem.LowLevel.InputDeviceCommand typeStatic; // 0x10
    public SwitchMagicOutputReport report; // 0x18

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFAC96582B0
    public void get_typeStatic(){} // RVA: 0x7FFAC96582B0
    public void Create(){} // RVA: 0x7FFAC9658310
}

public class SwitchMagicOutputReport : ValueType
{
    public int kSize;
    public byte ExpectedReplyInputReportId;
    public byte reportType; // 0x10
    public byte commandId; // 0x11
}

public class SwitchSimpleInputReport : ValueType
{
    public int kSize;
    public byte ExpectedReportId;
    public byte reportId; // 0x10
    public byte buttons0; // 0x11
    public byte buttons1; // 0x12
    public byte hat; // 0x13
    public ushort leftX; // 0x14
    public ushort leftY; // 0x16
    public ushort rightX; // 0x18
    public ushort rightY; // 0x1A

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9657CE0
}

public class SymbolTables : ValueType
{
    public string[] symtable; // 0x10
    public int symCount; // 0x18
    public QName[] qnametable; // 0x20
    public int qnameCount; // 0x28

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC9094190
}

public class SyncHashtable : Hashtable
{
    public System.Collections.Hashtable Count; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85A4920 | overloaded x2
    public void GetObjectData(){} // RVA: 0x7FFAC85A4980
    public void get_Count(){} // RVA: 0x7FFAC85A49C0
    public void get_IsReadOnly(){} // RVA: 0x7FFAC85A49F0
    public void get_IsFixedSize(){} // RVA: 0x7FFAC85A4A20
    public void get_IsSynchronized(){} // RVA: 0x7FFAC3006850
    public void get_Item(){} // RVA: 0x7FFAC85A4A50
    public void set_Item(){} // RVA: 0x7FFAC85A4A80
    public void get_SyncRoot(){} // RVA: 0x7FFAC85A4C20
    public void Add(){} // RVA: 0x7FFAC85A4C50
    public void Clear(){} // RVA: 0x7FFAC85A4DF0
    public void Contains(){} // RVA: 0x7FFAC85A4F60
    public void ContainsKey(){} // RVA: 0x7FFAC85A4F90
    public void CopyTo(){} // RVA: 0x7FFAC85A5040
    public void Clone(){} // RVA: 0x7FFAC85A51E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC85A53F0
    public void GetEnumerator(){} // RVA: 0x7FFAC85A53F0
    public void get_Keys(){} // RVA: 0x7FFAC85A5420
    public void get_Values(){} // RVA: 0x7FFAC85A55B0
    public void Remove(){} // RVA: 0x7FFAC85A5740
    public void OnDeserialization(){} // RVA: 0x7FFAC2F21310
}

public class SyncSortedList : SortedList
{
    public System.Collections.SortedList Count; // 0x48
    public object SyncRoot; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85970D0
    public void get_Count(){} // RVA: 0x7FFAC85971D0
    public void get_SyncRoot(){} // RVA: 0x7FFAC2FC20E0
    public void get_IsReadOnly(){} // RVA: 0x7FFAC8597330
    public void get_IsFixedSize(){} // RVA: 0x7FFAC8597360
    public void get_IsSynchronized(){} // RVA: 0x7FFAC3006850
    public void get_Item(){} // RVA: 0x7FFAC8597390
    public void set_Item(){} // RVA: 0x7FFAC8597500
    public void Add(){} // RVA: 0x7FFAC8597670
    public void Clear(){} // RVA: 0x7FFAC85977E0
    public void Clone(){} // RVA: 0x7FFAC8597930
    public void Contains(){} // RVA: 0x7FFAC8597A90
    public void ContainsKey(){} // RVA: 0x7FFAC8597C10
    public void ContainsValue(){} // RVA: 0x7FFAC8597D90
    public void CopyTo(){} // RVA: 0x7FFAC8597F10
    public void GetByIndex(){} // RVA: 0x7FFAC8598080
    public void GetEnumerator(){} // RVA: 0x7FFAC85981F0
    public void GetKey(){} // RVA: 0x7FFAC8598350
    public void GetKeyList(){} // RVA: 0x7FFAC85984C0
    public void GetValueList(){} // RVA: 0x7FFAC8598620
    public void IndexOfKey(){} // RVA: 0x7FFAC8598780
    public void IndexOfValue(){} // RVA: 0x7FFAC8598960
    public void RemoveAt(){} // RVA: 0x7FFAC8598AE0
    public void Remove(){} // RVA: 0x7FFAC8598C40
}

public class SyncTextReader : TextReader
{
    public System.IO.TextReader _in; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85CFD30
    public void Close(){} // RVA: 0x7FFAC85CFDD0
    public void Dispose(){} // RVA: 0x7FFAC85CFE00
    public void Peek(){} // RVA: 0x7FFAC838EC40
    public void Read(){} // RVA: 0x7FFAC85CFE60 | overloaded x2
    public void ReadLine(){} // RVA: 0x7FFAC85CFE90
    public void ReadToEnd(){} // RVA: 0x7FFAC8459490
    public void ReadToEndAsync(){} // RVA: 0x7FFAC85CFEC0
    public void ReadAsync(){} // RVA: 0x7FFAC85CFF40
}

public class SyncTextWriter : TextWriter
{
    public System.IO.TextWriter Encoding; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85D29D0
    public void get_Encoding(){} // RVA: 0x7FFAC85D2AB0
    public void get_FormatProvider(){} // RVA: 0x7FFAC85D2AE0
    public void get_NewLine(){} // RVA: 0x7FFAC85D2B10
    public void Close(){} // RVA: 0x7FFAC84B9050
    public void Dispose(){} // RVA: 0x7FFAC85D2B40
    public void Flush(){} // RVA: 0x7FFAC85D2BA0
    public void Write(){} // RVA: 0x7FFAC85D2C30 | overloaded x8
    public void WriteLine(){} // RVA: 0x7FFAC85D2CC0 | overloaded x5
    public void WriteAsync(){} // RVA: 0x7FFAC85D2E70 | overloaded x3
    public void WriteLineAsync(){} // RVA: 0x7FFAC85D2F60
    public void FlushAsync(){} // RVA: 0x7FFAC85D3050
}

public class SyncTile : ValueType
{
    public UnityEngine.Vector3Int m_Position; // 0x10
    public UnityEngine.Tilemaps.TileBase m_Tile; // 0x20
    public UnityEngine.Tilemaps.TileData m_TileData; // 0x28
}

public class SyncTileCallbackSettings : ValueType
{
    public bool hasSyncTileCallback; // 0x10
    public bool hasPositionsChangedCallback; // 0x11
    public bool isBufferSyncTile; // 0x12
}

public class SynchronizeInputs : ValueType
{
}

public class SynchronizeState : ValueType
{
}

public class SynchronousAsyncResult : Object
{
    public object IsCompleted; // 0x10
    public bool AsyncWaitHandle; // 0x18
    public System.Threading.ManualResetEvent AsyncState; // 0x20
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo CompletedSynchronously; // 0x28
    public bool _endXxxCalled; // 0x30
    public int _bytesRead; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85EAC90 | overloaded x3
    public void get_IsCompleted(){} // RVA: 0x7FFAC3006850
    public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC85EAE20
    public void get_AsyncState(){} // RVA: 0x7FFAC2F3C380
    public void get_CompletedSynchronously(){} // RVA: 0x7FFAC3006850
    public void ThrowIfError(){} // RVA: 0x7FFAC85EAF80
    public void EndRead(){} // RVA: 0x7FFAC85E91C0
    public void EndWrite(){} // RVA: 0x7FFAC85E9420
}

public class SystemController : ScriptableObject
{
    public bool testSteamAccount; // 0x18

    // ── Methods ──
    public void BackPressed(){} // RVA: 0x7FFAC39B4E30
    public void CreateInstance(){} // RVA: 0x7FFAC426D6D0
    public void Equals(){} // RVA: 0x7FFAC426D6D0
    public void CreateScriptableObject(){} // RVA: 0x7FFAC426D700
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC426D790
    public void GetHashCode(){} // RVA: 0x7FFAC426D7E0
    public void ToString(){} // RVA: 0x7FFAC426D870
    public void GetGameObject_E1B(){} // RVA: 0x7FFAC426D900
    public void .ctor(){} // RVA: 0x7FFAC312F5F0
    public void Initialize(){} // RVA: 0x7FFAC426D990
    public void GetGameObject_EAA(){} // RVA: 0x7FFAC426DA10
    public void GetTouch(){} // RVA: 0x7FFAC426DAA0
    public void CheckAndProcessSystemStatus(){} // RVA: 0x7FFAC426DB20
    public void Initialize_F4380EE5B316(){} // RVA: 0x7FFAC426DB20
    public void DoInternal_FromEulerRad_Injected_EF0(){} // RVA: 0x7FFAC426DB30
}

public class SystemFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6525E10
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class SystemObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFAC2F21310
    public void SetObjectData(){} // RVA: 0x7FFACC07BD90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SystemThreadingTasks_TaskSchedulerDebugView : Object
{
}

public class SystemThreading_SpinLockDebugView : Object
{
}

public class SystemTimeProvider : TimeProvider
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8320140
}

public class sentry_logger_function_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6192A30
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class sentry_value_t : ValueType
{
    public ulong _bits; // 0x10
    public double _double; // 0x10
}

public class sockaddr_in : ValueType
{
    public byte sin_len; // 0x10
    public byte sin_family; // 0x11

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC9328780
}
