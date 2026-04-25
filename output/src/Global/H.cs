// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 57
// Methods: 199

public class HIDCollectionDescriptor : ValueType
{
    public 0x6B14B848 type; // 0x10
    public int usage; // 0x14
    public 0x6B14BA58 usagePage; // 0x18
    public int parent; // 0x1C
    public int childCount; // 0x20
    public int firstChild; // 0x24
}

public class HIDDeviceDescriptor : ValueType
{
    public int vendorId; // 0x10
    public int productId; // 0x14
    public int usage; // 0x18
    public 0x6B14BA58 usagePage; // 0x1C
    public int inputReportSize; // 0x20
    public int outputReportSize; // 0x24
    public int featureReportSize; // 0x28
    public HIDElementDescriptor[] elements; // 0x30
    public HIDCollectionDescriptor[] collections; // 0x38

    // ── Methods ──
    public void ToJson(){} // RVA: 0x7FFAC96626A0
    public void FromJson(){} // RVA: 0x7FFAC9662710
}

public class HIDDeviceDescriptorBuilder : ValueType
{
    public 0x6B14BA58 usagePage; // 0x10
    public int usage; // 0x14
    public int m_CurrentReportId; // 0x18
    public 0x6B14B7F0 m_CurrentReportType; // 0x1C
    public int m_CurrentReportOffsetInBits; // 0x20
    public System.Collections.Generic.List`1<HIDElementDescriptor> m_Elements; // 0x28
    public System.Collections.Generic.List`1<HIDCollectionDescriptor> m_Collections; // 0x30
    public int m_InputReportSize; // 0x38
    public int m_OutputReportSize; // 0x3C
    public int m_FeatureReportSize; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9664AD0 | overloaded x2
    public void StartReport(){} // RVA: 0x7FFAC9664B00
    public void AddElement(){} // RVA: 0x7FFAC9664FC0 | overloaded x2
    public void WithPhysicalMinMax(){} // RVA: 0x7FFAC9665020
    public void WithLogicalMinMax(){} // RVA: 0x7FFAC96651E0
    public void Finish(){} // RVA: 0x7FFAC96653A0
}

public class HIDElementDescriptor : ValueType
{
    public int hasNullState; // 0x10
    public 0x6B14BA58 hasPreferredState; // 0x14
    public int isArray; // 0x18
    public int isNonLinear; // 0x1C
    public int isRelative; // 0x20
    public int isConstant; // 0x24
    public int isWrapping; // 0x28
    public int isSigned; // 0x2C
    public 0x6B14B7F0 minFloatValue; // 0x30
    public int maxFloatValue; // 0x34
    public int reportId; // 0x38
    public int reportSizeInBits; // 0x3C
    public int reportOffsetInBits; // 0x40
    public 0x6B14B8A0 flags; // 0x44
    public System.Nullable`1<int> usageMin; // 0x48
    public System.Nullable`1<int> usageMax; // 0x50

    // ── Methods ──
    public void get_hasNullState(){} // RVA: 0x7FFAC9660CE0
    public void get_hasPreferredState(){} // RVA: 0x7FFAC9660CF0
    public void get_isArray(){} // RVA: 0x7FFAC9660D00
    public void get_isNonLinear(){} // RVA: 0x7FFAC9660D10
    public void get_isRelative(){} // RVA: 0x7FFAC9660D20
    public void get_isConstant(){} // RVA: 0x7FFAC9660D30
    public void get_isWrapping(){} // RVA: 0x7FFAC9660D40
    public void get_isSigned(){} // RVA: 0x7FFAC9660D50
    public void get_minFloatValue(){} // RVA: 0x7FFAC9660D60
    public void get_maxFloatValue(){} // RVA: 0x7FFAC9660E40
    public void Is(){} // RVA: 0x7FFAC9660F20
    public void DetermineName(){} // RVA: 0x7FFAC9660F30
    public void DetermineDisplayName(){} // RVA: 0x7FFAC96611F0
    public void IsUsableElement(){} // RVA: 0x7FFAC96612D0
    public void DetermineLayout(){} // RVA: 0x7FFAC9661300
    public void DetermineFormat(){} // RVA: 0x7FFAC9661400
    public void DetermineUsages(){} // RVA: 0x7FFAC9661580
    public void DetermineParameters(){} // RVA: 0x7FFAC9661900
    public void DetermineAxisNormalizationParameters(){} // RVA: 0x7FFAC9661A40
    public void DetermineProcessors(){} // RVA: 0x7FFAC9661BF0
    public void DetermineDefaultState(){} // RVA: 0x7FFAC9661C50
    public void AddChildControls(){} // RVA: 0x7FFAC9661D90
}

public class HIDItemStateGlobal : ValueType
{
    public System.Nullable`1<int> usagePage; // 0x10
    public System.Nullable`1<int> logicalMinimum; // 0x18
    public System.Nullable`1<int> logicalMaximum; // 0x20
    public System.Nullable`1<int> physicalMinimum; // 0x28
    public System.Nullable`1<int> physicalMaximum; // 0x30
    public System.Nullable`1<int> unitExponent; // 0x38
    public System.Nullable`1<int> unit; // 0x40
    public System.Nullable`1<int> reportSize; // 0x48
    public System.Nullable`1<int> reportCount; // 0x50
    public System.Nullable`1<int> reportId; // 0x58

    // ── Methods ──
    public void GetUsagePage(){} // RVA: 0x7FFAC9666AF0
    public void GetPhysicalMin(){} // RVA: 0x7FFAC9666B80
    public void GetPhysicalMax(){} // RVA: 0x7FFAC9666C10
}

public class HIDItemStateLocal : ValueType
{
    public System.Nullable`1<int> usage; // 0x10
    public System.Nullable`1<int> usageMinimum; // 0x18
    public System.Nullable`1<int> usageMaximum; // 0x20
    public System.Nullable`1<int> designatorIndex; // 0x28
    public System.Nullable`1<int> designatorMinimum; // 0x30
    public System.Nullable`1<int> designatorMaximum; // 0x38
    public System.Nullable`1<int> stringIndex; // 0x40
    public System.Nullable`1<int> stringMinimum; // 0x48
    public System.Nullable`1<int> stringMaximum; // 0x50
    public System.Collections.Generic.List`1<int> usageList; // 0x58

    // ── Methods ──
    public void Reset(){} // RVA: 0x7FFAC96667A0
    public void SetUsage(){} // RVA: 0x7FFAC9666850
    public void GetUsage(){} // RVA: 0x7FFAC96669F0
}

public class HIDLayoutBuilder : Object
{
    public string displayName; // 0x10
    public HIDDeviceDescriptor hidDescriptor; // 0x18
    public string parentLayout; // 0x48
    public System.Type deviceType; // 0x50

    // ── Methods ──
    public void Build(){} // RVA: 0x7FFAC965ED60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class HIDPageUsage : ValueType
{
    public 0x6B14BA58 page; // 0x10
    public int usage; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9667310 | overloaded x2
}

public class HIDReportData : ValueType
{
    public int reportId; // 0x10
    public 0x6B14B7F0 reportType; // 0x14
    public int currentBitOffset; // 0x18

    // ── Methods ──
    public void FindOrAddReport(){} // RVA: 0x7FFAC9666580
}

public class HMacDrbgProvider : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mHMac; // 0x10
    public byte[] mNonce; // 0x18
    public byte[] mPersonalizationString; // 0x20
    public int mSecurityStrength; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92DC0D0
    public void Get(){} // RVA: 0x7FFACBB86480
}

public class HTTP : Object
{
    // ── Methods ──
    public void SetHttpTransferUpdateCallback(){} // RVA: 0x7FFAC88736C0
}

public class HTTP_REQUEST_HEADER_ID : Object
{
    public string[] m_Strings;

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC92DB0E0
    public void .cctor(){} // RVA: 0x7FFAC92DB160
}

public class HandInputData : ValueType
{
    public float TrackedDuration; // 0x10
    public PinchData[] Pinches; // 0x18
    public bool[] FingerExtended; // 0x20
    public float[] FingerCurls; // 0x28
    public float[] FingerCurlVelocities; // 0x30
    public UnityEngine.Vector3 PreviousWristPositionPlayspace; // 0x38
    public UnityEngine.Vector3 WristVelocity; // 0x44
    public UnityEngine.Vector3 WristVelocityPlayspace; // 0x50

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC3FF0AD0
    public void InternalEquals(){} // RVA: 0x7FFAC3FF0FB0
    public void DefaultEquals(){} // RVA: 0x7FFAC3FF1320
    public void GetHashCode(){} // RVA: 0x7FFAC3FF17D0
    public void InternalGetHashCode(){} // RVA: 0x7FFAC3FF1CD0
    public void ToString(){} // RVA: 0x7FFAC3FF2040
    public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3FF26E0
    public void HasValidInternalValue(){} // RVA: 0x7FFAC3FF2DB0
}

public class HandState : ValueType
{
    public 0x6B1A76D8 Status; // 0x10
    public Posef RootPose; // 0x14
    public Quatf[] BoneRotations; // 0x30
    public 0x6B1A77E0 Pinches; // 0x38
    public float[] PinchStrength; // 0x40
    public Posef PointerPose; // 0x48
    public float HandScale; // 0x64
    public 0x6B1A7628 HandConfidence; // 0x68
    public 0x6B1A7628[] FingerConfidences; // 0x70
    public double RequestedTimeStamp; // 0x78
    public double SampleTimeStamp; // 0x80
}

public class HandStateInternal : ValueType
{
    public 0x6B1A76D8 Status; // 0x10
    public Posef RootPose; // 0x14
    public Quatf BoneRotations_0; // 0x30
    public Quatf BoneRotations_1; // 0x40
    public Quatf BoneRotations_2; // 0x50
    public Quatf BoneRotations_3; // 0x60
    public Quatf BoneRotations_4; // 0x70
    public Quatf BoneRotations_5; // 0x80
    public Quatf BoneRotations_6; // 0x90
    public Quatf BoneRotations_7; // 0xA0
    public Quatf BoneRotations_8; // 0xB0
    public Quatf BoneRotations_9; // 0xC0
    public Quatf BoneRotations_10; // 0xD0
    public Quatf BoneRotations_11; // 0xE0
    public Quatf BoneRotations_12; // 0xF0
    public Quatf BoneRotations_13; // 0x100
    public Quatf BoneRotations_14; // 0x110
    public Quatf BoneRotations_15; // 0x120
    public Quatf BoneRotations_16; // 0x130
    public Quatf BoneRotations_17; // 0x140
    public Quatf BoneRotations_18; // 0x150
    public Quatf BoneRotations_19; // 0x160
    public Quatf BoneRotations_20; // 0x170
    public Quatf BoneRotations_21; // 0x180
    public Quatf BoneRotations_22; // 0x190
    public Quatf BoneRotations_23; // 0x1A0
    public 0x6B1A77E0 Pinches; // 0x1B0
    public float PinchStrength_0; // 0x1B4
    public float PinchStrength_1; // 0x1B8
    public float PinchStrength_2; // 0x1BC
    public float PinchStrength_3; // 0x1C0
    public float PinchStrength_4; // 0x1C4
    public Posef PointerPose; // 0x1C8
    public float HandScale; // 0x1E4
    public 0x6B1A7628 HandConfidence; // 0x1E8
    public 0x6B1A7628 FingerConfidences_0; // 0x1EC
    public 0x6B1A7628 FingerConfidences_1; // 0x1F0
    public 0x6B1A7628 FingerConfidences_2; // 0x1F4
    public 0x6B1A7628 FingerConfidences_3; // 0x1F8
    public 0x6B1A7628 FingerConfidences_4; // 0x1FC
    public double RequestedTimeStamp; // 0x200
    public double SampleTimeStamp; // 0x208
}

public class HandTrackingData : ValueType
{
    public bool IsLeft; // 0x10
    public bool IsTracking; // 0x11
    public bool IsPersisting; // 0x12
    public 0x6B000820 FidelityLevel; // 0x14
    public FingerData[] Fingers; // 0x18
    public TrackedPose WristPose; // 0x20
    public TrackedPose PalmPose; // 0x3C
}

public class Handler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Handlers : Object
{
    public UIntPtr Utf8JsonWriter; // 0x10
    public UIntPtr StringHandler; // 0x18
    public UIntPtr Utf8StringWriter; // 0x20
    public UIntPtr ReadBoxed; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F69A50
}

public class HandshakeHashUpdateStream : BaseOutputStream
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.RecordStream mOuter; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB2A940
    public void Write(){} // RVA: 0x7FFACBB3BD60
}

public class HandshakeMessage : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB58FE0 | overloaded x2
    public void Write(){} // RVA: 0x7FFACBB590C0
    public void WriteToRecordStream(){} // RVA: 0x7FFACBB59100
}

public class HapticEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC056670
    public void Invoke(){} // RVA: 0x7FFAC61931F0
    public void BeginInvoke(){} // RVA: 0x7FFACC0567F0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class HapticInfo : Object
{
    public bool playingHaptics; // 0x10
    public float hapticsDurationPlayed; // 0x14
    public float hapticsDuration; // 0x18
    public float hapticAmplitude; // 0x1C
    public 0x6B2C8DD8 node; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class HapticsBuffer : ValueType
{
    public UIntPtr Samples; // 0x10
    public int SamplesCount; // 0x18
}

public class HapticsDesc : ValueType
{
    public int SampleRateHz; // 0x10
    public int SampleSizeInBytes; // 0x14
    public int MinimumSafeSamplesQueued; // 0x18
    public int MinimumBufferSamplesCount; // 0x1C
    public int OptimalBufferSamplesCount; // 0x20
    public int MaximumBufferSamplesCount; // 0x24
}

public class HapticsState : ValueType
{
    public int SamplesAvailable; // 0x10
    public int SamplesQueued; // 0x14
}

public class HasValue : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEE410
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Hash128Input : TextInputBase
{
    public object allowedCharacters;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9AB75A0
    public void get_allowedCharacters(){} // RVA: 0x7FFAC9AB76A0
    public void AcceptCharacter(){} // RVA: 0x7FFAC9AB76E0
    public void StringToValue(){} // RVA: 0x7FFAC9AB7010
    public void Parse(){} // RVA: 0x7FFAC9AB77E0
}

public class HashBucket : ValueType
{
    public System.Collections.Generic.KeyValuePair`2<U,T> IsEmpty;
    public Node<System.Collections.Generic.KeyValuePair`2<U,T>> FirstValue;

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
    public void get_FirstValue(){} // RVA: 0x7FFAC2E8DC40
    public void get_AdditionalElements(){} // RVA: 0x7FFAC2C58E90
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void Equals(){} // RVA: 0x7FFAC2C59F60
    public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
    public void Freeze(){} // RVA: 0x7FFAC2C70980
}

public class HashBucketByRefEqualityComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<HashBucket<T>> DefaultInstance;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFAC2C58A90
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Equals(){} // RVA: 0x7FFAC2E8DC40
    public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class HashBucketByValueEqualityComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<HashBucket<T>> DefaultInstance;
    public System.Collections.Generic.IEqualityComparer`1<T> _valueComparer;

    // ── Methods ──
    public void get_DefaultInstance(){} // RVA: 0x7FFAC2C58A90
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Equals(){} // RVA: 0x7FFAC2E8DC40
    public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class HashCode : ValueType
{
    public int _hashCode; // 0x10

    // ── Methods ──
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void ToHashCode(){} // RVA: 0x7FFAC4420210
}

public class HashCode64`1 : ValueType
{
    public long Value;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class HashCodeOfStringDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC91ABDC0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class HashDrbgProvider : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x10
    public byte[] mNonce; // 0x18
    public byte[] mPersonalizationString; // 0x20
    public int mSecurityStrength; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92DC0D0
    public void Get(){} // RVA: 0x7FFACBB863E0
}

public class HashPair : ValueType
{
    public int parentHash; // 0x10
    public int hash; // 0x14
}

public class HashSetPoolImpl`1 : Object
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.HashSet`1<T>> Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class HashsetIterator`1 : ValueType
{
    public bool Current;
    public System.Collections.Generic.HashSet`1<T> hashset;
    public Enumerator<T> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class HashtableDebugView : Object
{
}

public class HashtableEnumerator : Object
{
    public System.Collections.Hashtable Key; // 0x10
    public int Entry; // 0x18
    public int Current; // 0x1C
    public bool Value; // 0x20
    public int _getObjectRetType; // 0x24
    public object _currentKey; // 0x28
    public object _currentValue; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85A58D0
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void get_Key(){} // RVA: 0x7FFAC85A5960
    public void MoveNext(){} // RVA: 0x7FFAC85A59D0
    public void get_Entry(){} // RVA: 0x7FFAC85A5B00
    public void get_Current(){} // RVA: 0x7FFAC85A5B80
    public void get_Value(){} // RVA: 0x7FFAC85A5C60
    public void Reset(){} // RVA: 0x7FFAC85A5CD0
}

public class HeadChopBone : Object
{
    public UnityEngine.Transform Transform; // 0x10
    public float scaleFactor; // 0x18
    public 0x6B2D4300 applyCondition; // 0x1C

    // ── Methods ──
    public void get_Transform(){} // RVA: 0x7FFAC2F3C380
    public void CanApply(){} // RVA: 0x7FFACC01CA90
    public void GetDesiredScaleFactor(){} // RVA: 0x7FFACC01CAB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class HeadChopData : ValueType
{
    public float DesiredAppliedScaleFactor; // 0x10
    public UnityEngine.Vector3 OriginalLocalPosition; // 0x14
    public UnityEngine.Vector3 OriginalRootSpacePosition; // 0x20
    public UnityEngine.Vector3 OriginalLocalScale; // 0x2C
}

public class HeaderBucket : Object
{
    public object HasStringValues; // 0x10
    public System.Collections.Generic.List`1<string> Values; // 0x18
    public System.Func`2<object,string> CustomToString; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8BF0300
    public void get_HasStringValues(){} // RVA: 0x7FFAC8FAA490
    public void get_Values(){} // RVA: 0x7FFAC8FAA4E0
    public void set_Values(){} // RVA: 0x7FFAC2F87E80
    public void ParsedToString(){} // RVA: 0x7FFAC8FAA5A0
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    public System.Net.Http.Headers.TryParseDelegate`1<T> parser; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5E4A7D0
    public void AddToCollection(){} // RVA: 0x7FFAC5E4A890
    public void CreateCollection(){} // RVA: 0x7FFAC5E4AA30
    public void ToStringCollection(){} // RVA: 0x7FFAC5E4C340
    public void TryParse(){} // RVA: 0x7FFAC5E4C710
}

public class Heading : ValueType
{
    public 0x6B229B00 m_Definition; // 0x10
    public int m_VelocityFilterStrength; // 0x14
    public float m_Bias; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC482EE60
}

public class HebrewValue : ValueType
{
    public 0x6B0DB590 token; // 0x10
    public short value; // 0x12

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC60F0B90
}

public class HeightProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A67F0
    public void .ctor(){} // RVA: 0x7FFAC99A6830
}

public class HeightmapChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC99F5A30
    public void Invoke(){} // RVA: 0x7FFAC8788060
}

public class Hierarchy : ValueType
{
    public string parent;
    public UnityEngine.UIElements.VisualElement children; // 0x10

    // ── Methods ──
    public void get_parent(){} // RVA: 0x7FFAC9BF22F0
    public void get_children(){} // RVA: 0x7FFAC9BF2310
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void Add(){} // RVA: 0x7FFAC9BF2330
    public void Insert(){} // RVA: 0x7FFAC9BF23F0
    public void Remove(){} // RVA: 0x7FFAC9BF2810
    public void RemoveAt(){} // RVA: 0x7FFAC9BF2970
    public void Clear(){} // RVA: 0x7FFAC9BF2CA0
    public void BringToFront(){} // RVA: 0x7FFAC9BF31F0
    public void SendToBack(){} // RVA: 0x7FFAC9BF3350
    public void PlaceBehind(){} // RVA: 0x7FFAC9BF3420
    public void MoveChildElement(){} // RVA: 0x7FFAC9BF3570
    public void get_childCount(){} // RVA: 0x7FFAC9BF36E0
    public void get_Item(){} // RVA: 0x7FFAC9BF3730
    public void IndexOf(){} // RVA: 0x7FFAC9BF37B0
    public void ElementAt(){} // RVA: 0x7FFAC9BF3840
    public void Children(){} // RVA: 0x7FFAC9BF2310
    public void SetParent(){} // RVA: 0x7FFAC9BF3850
    public void PutChildAtIndex(){} // RVA: 0x7FFAC9BF39F0
    public void RemoveChildAtIndex(){} // RVA: 0x7FFAC9BF3B50
    public void ReleaseChildList(){} // RVA: 0x7FFAC9BF3BD0
    public void Equals(){} // RVA: 0x7FFAC9BF3D20 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC9AC20E0
    public void op_Equality(){} // RVA: 0x7FFAC98F6CE0
}

public class HitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7FA90
    public void Invoke(){} // RVA: 0x7FFAC2F7FB60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FB90
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class HitInfo : ValueType
{
    public UnityEngine.GameObject target; // 0x10
    public UnityEngine.Camera camera; // 0x18

    // ── Methods ──
    public void SendMessage(){} // RVA: 0x7FFAC99425B0
    public void op_Implicit(){} // RVA: 0x7FFAC99425E0
    public void Compare(){} // RVA: 0x7FFAC9942750
}

public class HitPoint : Object
{
    public string inProgress; // 0x10
    public UnityEngine.Collider crossFader; // 0x18
    public float timer; // 0x20
    public float force; // 0x24
    public float point; // 0x28
    public UnityEngine.Vector3 <force>k__BackingField; // 0x2C
    public UnityEngine.Vector3 <point>k__BackingField; // 0x38
    public float length; // 0x44
    public float crossFadeSpeed; // 0x48
    public float lastTime; // 0x4C

    // ── Methods ──
    public void get_inProgress(){} // RVA: 0x7FFAC308EF40
    public void get_crossFader(){} // RVA: 0x7FFAC308EF50
    public void set_crossFader(){} // RVA: 0x7FFAC308EF60
    public void get_timer(){} // RVA: 0x7FFAC3000210
    public void set_timer(){} // RVA: 0x7FFAC3000220
    public void get_force(){} // RVA: 0x7FFAC2F87F10
    public void set_force(){} // RVA: 0x7FFAC2F87F30
    public void get_point(){} // RVA: 0x7FFAC2F87F40
    public void set_point(){} // RVA: 0x7FFAC2F87F60
    public void Hit(){} // RVA: 0x7FFAC308EF70
    public void Apply(){} // RVA: 0x7FFAC308F0A0
    public void GetLength(){} // RVA: 0x7FFAC2C6D880
    public void CrossFadeStart(){} // RVA: 0x7FFAC2C70980
    public void OnApply(){} // RVA: 0x7FFAC2C7D7B0
    public void .ctor(){} // RVA: 0x7FFAC308F1F0
}

public class HitPointBone : HitPoint
{
    public UnityEngine.AnimationCurve aroundCenterOfMass; // 0x50
    public BoneLink[] boneLinks; // 0x58
    public UnityEngine.Rigidbody rigidbody; // 0x60

    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFAC308FA20
    public void CrossFadeStart(){} // RVA: 0x7FFAC308FB70
    public void OnApply(){} // RVA: 0x7FFAC308FBC0
    public void .ctor(){} // RVA: 0x7FFAC308F1F0
}

public class HitPointEffector : HitPoint
{
    public UnityEngine.AnimationCurve offsetInForceDirection; // 0x50
    public UnityEngine.AnimationCurve offsetInUpDirection; // 0x58
    public EffectorLink[] effectorLinks; // 0x60

    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFAC308F2C0
    public void CrossFadeStart(){} // RVA: 0x7FFAC308F570
    public void OnApply(){} // RVA: 0x7FFAC308F5D0
    public void .ctor(){} // RVA: 0x7FFAC308F1F0
}

public class Host : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFAC8FB0BE0
}

public class HttpApi : Object
{
    public string[] m_Strings;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC92DABC0
}

public class HudLayout : Object
{
    public UnityEngine.RectTransform PopupTransform; // 0x10
    public UnityEngine.RectTransform UserEventTransform; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class HumanoidMuscle : Object
{
    public string name; // 0x10
    public 0x6B29CC78 bone; // 0x18
    public Props props; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}
