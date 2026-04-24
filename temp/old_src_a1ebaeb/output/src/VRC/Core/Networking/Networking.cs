// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking
// Classes: 26
// Methods: 289

namespace VRC.Core.Networking
{
    public class ArrayPoolShim : Object
    {
        // ── Original Methods ──
        public void Exchange(){} // RVA: 0x7ffaa86666b0
        public void Release(){} // RVA: 0x7ffaa8660d50
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa86666b0
        public void Get(){} // RVA: 0x7ffaa86666b0
    }

    public class ConcurrentLimitedCapacityList`1 : Object
    {
        // ── Original Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x7ffaa8649cd0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void set_Capacity(){} // RVA: 0x7ffaa8661210
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void get_Full(){} // RVA: 0x7ffaa864a040
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Push(){} // RVA: 0x7ffaa887e5c0
        public void PushAt(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void RemoveAt(){} // RVA: 0x7ffaa8661210
        public void LastOrDefault(){} // RVA: 0x7ffaa887e5c0
        public void FirstOrDefault(){} // RVA: 0x7ffaa887e5c0
        public void FirstOrDefault(){} // RVA: 0x7ffaa887e5c0
        public void LastOrDefault(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class DecodeParameters32 : Object
    {
        public object _sendTime; // 0x336EF790, was: <SendTime>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf77d500
        public void get_Objects(){} // RVA: 0x7ffaa9e49b20
        public void set_Objects(){} // RVA: 0x7ffaabfb44a0
        public void get_ObjectIndex(){} // RVA: 0x7ffaa8aeced0
        public void set_ObjectIndex(){} // RVA: 0x7ffaa900aa90
        public void get_SendTime(){} // RVA: 0x7ffaa8a9ff50
        public void set_SendTime(){} // RVA: 0x7ffaa8a9ff60
        public void get_SerializationRecovery(){} // RVA: 0x7ffaa8960130
        public void set_SerializationRecovery(){} // RVA: 0x7ffaa8933e90
        public void get_SerializationHashes(){} // RVA: 0x7ffaaf77d5c0
        public void get_HasSerializationRecovery(){} // RVA: 0x7ffaadc20540
    }

    public class DecodeParameters8 : Object
    {
        public object _sendTime; // 0x338CE6F0, was: <SendTime>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf77d500
        public void get_Objects(){} // RVA: 0x7ffaa9e49b20
        public void set_Objects(){} // RVA: 0x7ffaabfb44a0
        public void get_ObjectIndex(){} // RVA: 0x7ffaa8aeced0
        public void set_ObjectIndex(){} // RVA: 0x7ffaa900aa90
        public void get_SendTime(){} // RVA: 0x7ffaa8a9ff50
        public void set_SendTime(){} // RVA: 0x7ffaa8a9ff60
        public void get_SerializationRecovery(){} // RVA: 0x7ffaa8960130
        public void set_SerializationRecovery(){} // RVA: 0x7ffaa8933e90
        public void get_SerializationHashes(){} // RVA: 0x7ffaaf77d670
        public void get_HasSerializationRecovery(){} // RVA: 0x7ffaadc20540
    }

    public class FixedByteBufferAllocator8 : ByteBufferAllocator
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf78ff60
        public void GrowFront(){} // RVA: 0x7ffaaf790100
        public void Init(){} // RVA: 0x7ffaaf790140
        public void get_Span(){} // RVA: 0x7ffaaf790270
        public void get_ReadOnlySpan(){} // RVA: 0x7ffaaf790310
        public void get_Memory(){} // RVA: 0x7ffaaf7903c0
        public void get_ReadOnlyMemory(){} // RVA: 0x7ffaaf7904b0
    }

    public class FlatBufferConfig : Object
    {
        public object MaximumBunchSize32; // 0x334D1B70
        public object DistanceFactor; // 0x334D1B70
        public object SlowUpdateFactorThreadhold; // 0x334D1B70
        public object ViewSegmentLength; // 0x334D1B70
        public object InterestRequestTimeLimit; // 0x334D1B70
        public object MaxDistanceFromCentre; // 0x334D1B70
        public object value__; // 0x81AB47E0
        public object HasPoseRecorder; // 0x81AB47E0
        public object .;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf77d700
    }

    public class FlatBufferSerializerCodec : Object
    {
        public object objectLock; // 0x339BC1B0
        public object receiveBuffer8; // 0x339BC1B0
        public object receiveAllocator32; // 0x339BC1B0
        public object recordSerialization; // 0x339BC1B0
        public object _playerEncodeCount; // 0x339BC1B0
        public object _emptyPlayerBuffer; // 0x339BC1B0
        public object h; // 0x3372CC10
        public object get_name; // 0xB41F4950

        // ── Original Methods ──
        public void get_Targets(){} // RVA: 0x7ffaaf77e5f0
        public void .ctor(){} // RVA: 0x7ffaaf77e6c0
        public void Decode8(){} // RVA: 0x7ffaaf77eee0
        public void Encode8(){} // RVA: 0x7ffaaf77f480
        public void Decode32(){} // RVA: 0x7ffaaf77fc10
        public void Encode32(){} // RVA: 0x7ffaaf780230
        public void DecodePlayer8(){} // RVA: 0x7ffaaf780830
        public void get_ForcePlayerStartSync(){} // RVA: 0x7ffaaf780c00
        public void EncodePlayer8(){} // RVA: 0x7ffaaf780c40
        public void IsPlayerSerialization8MissingFields(){} // RVA: 0x7ffaaf781490
        public void ConfigureSparseArrays(){} // RVA: 0x7ffaaf7814f0
        public void SparseDecode8(){} // RVA: 0x7ffaaf781790
        public void SparseEncode8(){} // RVA: 0x7ffaaf781dc0
        public void SparseDecode32(){} // RVA: 0x7ffaaf782640
        public void SparseEncode32(){} // RVA: 0x7ffaaf782c30
        public void FindCorrectIndex(){} // RVA: 0x7ffaaf783550
    }

    public class IEvent
    {
        // ── Original Methods ──
        public void get_Time(){} // RVA: 0x7ffaa864eea0
        public void get_Store(){} // RVA: 0x7ffaa864a040
        public void get_Instigator(){} // RVA: 0x7ffaa8649ca0
        public void set_Instigator(){} // RVA: 0x7ffaa8661210
        public void get_ShouldBroadcast(){} // RVA: 0x7ffaa864a040
        public void get_Serialize(){} // RVA: 0x7ffaa86491d0
        public void get_Sender(){} // RVA: 0x7ffaa8649ca0
        public void set_Sender(){} // RVA: 0x7ffaa8661210
        public void DeepClone(){} // RVA: 0x7ffaa86491d0
    }

    public class IFlatBufferNetworkSerializer
    {
        // ── Original Methods ──
        public void get_EventCode(){} // RVA: 0x7ffaa864a040
        public void get_name(){} // RVA: 0x7ffaa86491d0
        public void get_IsSparse(){} // RVA: 0x7ffaa864a040
        public void get_LastEncoding(){} // RVA: 0x7ffaa86491d0
        public void get_Targets(){} // RVA: 0x7ffaa86491d0
        public void MakeTransformHash(){} // RVA: 0x7ffaa864e9f0
        public void get_MaxContentLength8(){} // RVA: 0x7ffaaf783e70
        public void get_MaxContentLength32(){} // RVA: 0x7ffaaf783ec0
    }

    public class ILimitedCapacityList`1
    {
        // ── Original Methods ──
        public void Push(){} // RVA: 0x7ffaa887e5c0
        public void PushAt(){} // RVA: 0x7ffaa887e5c0
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void set_Capacity(){} // RVA: 0x7ffaa8661210
    }

    public class ILoggableClass
    {
        // ── Original Methods ──
        public void LogInfoFormat(){} // RVA: 0x7ffaa8669e70
        public void LogWarningFormat(){} // RVA: 0x7ffaa8669e70
        public void LogErrorFormat(){} // RVA: 0x7ffaa8669e70
        public void LogException(){} // RVA: 0x7ffaa8660d80
        public void LogInfo(){} // RVA: 0x7ffaa8660d80
        public void LogError(){} // RVA: 0x7ffaa8660d80
    }

    public class INetworkReadyReceiver
    {
        // ── Original Methods ──
        public void OnNetworkReady(){} // RVA: 0x7ffaa8660cc0
    }

    public class ISyncPhysics
    {
        // ── Original Methods ──
        public void get_LastPosition(){} // RVA: 0x7ffaa86491d0
        public void Decode(){}
    }

    public class ITimedValue
    {
        // ── Original Methods ──
        public void get_Time(){} // RVA: 0x7ffaa865dbc0
        public void set_Time(){} // RVA: 0x7ffaa866e7c0
        public void Copy(){} // RVA: 0x7ffaa8660d80
    }

    public class ITweenableValue
    {
        // ── Original Methods ──
        public void Tween(){}
        public void Interpolate(){} // RVA: 0x7ffaa864e2f0
        public void Extrapolate(){} // RVA: 0x7ffaa864e2f0
    }

    public class IVRC_FlatBufferSerializer
    {
        // ── Original Methods ──
        public void NeedsSync(){} // RVA: 0x7ffaa864a040
        public void NeedsImportant(){} // RVA: 0x7ffaa864a040
        public void CanSerialize8Bit(){} // RVA: 0x7ffaa864a040
        public void CanSerialize32Bit(){} // RVA: 0x7ffaa864a040
        public void Encode(){} // RVA: 0x7ffaa864e9f0
        public void Encode(){} // RVA: 0x7ffaa864e9f0
        public void Decode(){} // RVA: 0x7ffaa8660d80
        public void Decode(){} // RVA: 0x7ffaa8660d80
        public void get_TypeId(){} // RVA: 0x7ffaa8649ca0
        public void SerializedName(){} // RVA: 0x7ffaa86491d0
    }

    public class IVRC_PersistentSerializer
    {
        // ── Original Methods ──
        public void get_UniqueHash(){} // RVA: 0x7ffaa8649ca0
        public void GenerateComponentInfo(){} // RVA: 0x7ffaa8658120
        public void CanUsePersistenceHashes(){} // RVA: 0x7ffaa864a2a0
    }

    public class LimitedCapacityList`1 : Object
    {
        // ── Original Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x7ffaa8649cd0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void set_Capacity(){} // RVA: 0x7ffaa8661210
        public void get_Full(){} // RVA: 0x7ffaa864a040
        public void get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void Push(){} // RVA: 0x7ffaa887e5c0
        public void PushAt(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void RemoveAt(){} // RVA: 0x7ffaa8661210
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class NetworkUpdateRates : Object
    {
        public object UpdateRateMSNormal; // 0x335015C0
        public object `;

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf77ca40
    }

    public class NumericExtensions : Object
    {
        public object h; // 0x846D72B8

        // ── Original Methods ──
        public void Clamp(){} // RVA: 0x7ffaa887e5c0
        public void SingleToInt(){} // RVA: 0x7ffaadf2daa0
        public void IntToSingle(){} // RVA: 0x7ffaadf2dab0
        public void IsBad(){} // RVA: 0x7ffaaf78f9f0
        public void IsSafe(){} // RVA: 0x7ffaaf78fa10
        public void AlmostEquals(){} // RVA: 0x7ffaaf78fab0
        public void CeilToInt(){} // RVA: 0x7ffaaf78fb30
        public void FloorToInt(){} // RVA: 0x7ffaaf78fb90
        public void FloatToHalf(){} // RVA: 0x7ffaaf78fbf0
        public void HalfToFloat(){} // RVA: 0x7ffaaf78fc80
        public void MaybeLerpTowards(){} // RVA: 0x7ffaaf78fcf0
        public void RoundTo(){} // RVA: 0x7ffaaf78fd90
    }

    public class PositionEvent : TweenableValue`1
    {
        public object Position; // 0x33A56CA0
        public object HasValue; // 0x33A56CA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf784160
        public void .ctor(){} // RVA: 0x7ffaaf784160
        public void DeepCopy(){} // RVA: 0x7ffaaf784350
        public void get_flags(){} // RVA: 0x7ffaa89edc00
        public void set_flags(){} // RVA: 0x7ffaa89edc10
        public void IsBad(){} // RVA: 0x7ffaaf784590
        public void Interpolate(){} // RVA: 0x7ffaaf784660
        public void Extrapolate(){} // RVA: 0x7ffaaf784830
        public void get_IsKinematic(){} // RVA: 0x7ffaaf784a00
        public void set_IsKinematic(){} // RVA: 0x7ffaaf784a10
        public void get_UseGravity(){} // RVA: 0x7ffaaf784a40
        public void set_UseGravity(){} // RVA: 0x7ffaaf784a50
        public void get_HeldInHand(){} // RVA: 0x7ffaaf784a80
        public void set_HeldInHand(){} // RVA: 0x7ffaaf784a90
        public void get_DiscontinuityCounter(){} // RVA: 0x7ffaaf784aa0
        public void set_DiscontinuityCounter(){} // RVA: 0x7ffaaf784ab0
        public void get_Discontinuity(){} // RVA: 0x7ffaa89fa570
        public void set_Discontinuity(){} // RVA: 0x7ffaa89fa580
        public void get_isHeld(){} // RVA: 0x7ffaaf784ad0
        public void IsDiscontinuousWith(){} // RVA: 0x7ffaaf784ae0
    }

    public class QuantizedSerialization : Object
    {
        public object MinimumFloatTolerance; // 0x333D1490
        public object IdentityQuaternion8; // 0x333D1490
        public object temp5; // 0x333D1490
        public object serializers; // 0x333D1490
        public object eightBitFloatFactor; // 0x333D1490
        public object h; // 0x846DCBE0
        public object h; // 0x846DD9D0
        public object h; // 0x3024EA20
        public object h; // 0x400014E
        public object 8؏f; // 0x67283C23

        // ── Original Methods ──
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void SerializeQuaternionAsNone(){} // RVA: 0x7ffaaf7894f0
        public void SerializeVector3AsNone(){} // RVA: 0x7ffaaf789770
        public void DeserializeQuaternionFromNone(){} // RVA: 0x7ffaaf7865f0
        public void DeserializeVector3FromNone(){} // RVA: 0x7ffaaf786770
        public void SerializeQuaternionAsHalfFloat(){} // RVA: 0x7ffaaf789c70
        public void SerializeVectorAsHalfFloat(){} // RVA: 0x7ffaaf789e10
        public void DeserializeQuaternionFromHalfFloat(){} // RVA: 0x7ffaaf786b80
        public void DeserializeVectorFromHalfFloat(){} // RVA: 0x7ffaaf786cb0
        public void SerializeQuaternionAsZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a3f0
        public void SerializeVectorAsZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a650
        public void DeserializeQuaternionFromZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a9c0
        public void DeserializeVectorFromZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78ab60
        public void SerializeQuaternionAsZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78ae70
        public void SerializeVectorAsZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b110
        public void DeserializeQuaternionFromZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b4f0
        public void DeserializeVectorFromZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b690
        public void SerializeQuaternionAsZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78b9d0
        public void SerializeVectorAsZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78bc30
        public void DeserializeQuaternionFromZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78bf80
        public void DeserializeVectorFromZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78c120
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Serialize(){} // RVA: 0x7ffaaf788780
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void Deserialize(){} // RVA: 0x7ffaaf789360
        public void SerializeQuaternionAsNone(){} // RVA: 0x7ffaaf7894f0
        public void SerializeVector3AsNone(){} // RVA: 0x7ffaaf789770
        public void SerializeFloatsAsNone(){} // RVA: 0x7ffaaf789970
        public void SerializeFloatNotImplemented(){} // RVA: 0x7ffaaf789ae0
        public void DeserializeQuaternionFromNone(){} // RVA: 0x7ffaaf7865f0
        public void DeserializeVector3FromNone(){} // RVA: 0x7ffaaf786770
        public void DeserializeFloatsFromNone(){} // RVA: 0x7ffaaf789b20
        public void DeserializeFloatNotImplemented(){} // RVA: 0x7ffaaf789c30
        public void SerializeQuaternionAsHalfFloat(){} // RVA: 0x7ffaaf789c70
        public void SerializeVectorAsHalfFloat(){} // RVA: 0x7ffaaf789e10
        public void SerializeFloatAsHalfFloat(){} // RVA: 0x7ffaaf789f60
        public void DeserializeFloatFromHalfFloat(){} // RVA: 0x7ffaaf78a050
        public void SerializeFloatsAsHalfFloat(){} // RVA: 0x7ffaaf78a0a0
        public void DeserializeQuaternionFromHalfFloat(){} // RVA: 0x7ffaaf786b80
        public void DeserializeVectorFromHalfFloat(){} // RVA: 0x7ffaaf786cb0
        public void DeserializeFloatsFromHalfFloat(){} // RVA: 0x7ffaaf78a240
        public void FloatToTenBit(){} // RVA: 0x7ffaaf78a3a0
        public void TenBitToFloat(){} // RVA: 0x7ffaaf78a3d0
        public void SerializeQuaternionAsZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a3f0
        public void SerializeVectorAsZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a650
        public void SerializeFloatsAsZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a7f0
        public void DeserializeQuaternionFromZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78a9c0
        public void DeserializeVectorFromZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78ab60
        public void DeserializeFloatsFromZeroToOneTenBitFloat(){} // RVA: 0x7ffaaf78ac90
        public void FloatToTwelveBit(){} // RVA: 0x7ffaaf78ae20
        public void TwelveBitToFloat(){} // RVA: 0x7ffaaf78ae50
        public void SerializeQuaternionAsZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78ae70
        public void SerializeVectorAsZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b110
        public void SerializeFloatsAsZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b2e0
        public void DeserializeQuaternionFromZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b4f0
        public void DeserializeVectorFromZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b690
        public void DeserializeFloatsFromZeroToOneTwelveBitFloat(){} // RVA: 0x7ffaaf78b7c0
        public void FloatToEightBit(){} // RVA: 0x7ffaaf78b980
        public void EightBitToFloat(){} // RVA: 0x7ffaaf78b9b0
        public void SerializeQuaternionAsZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78b9d0
        public void SerializeVectorAsZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78bc30
        public void SerializeFloatsAsZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78bdc0
        public void DeserializeQuaternionFromZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78bf80
        public void DeserializeVectorFromZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78c120
        public void DeserializeFloatsFromZeroToOneEightBitFloat(){} // RVA: 0x7ffaaf78c250
        public void Clamp(){} // RVA: 0x7ffaaf78c4a0
        public void Clamp(){} // RVA: 0x7ffaaf78c4a0
        public void ConvertPuppetFloatToByte(){} // RVA: 0x7ffaaf78c510
        public void ConvertByteToPuppetFloat(){} // RVA: 0x7ffaaf78c690
        public void ConvertAngularVelocityFloatToByte(){} // RVA: 0x7ffaaf78c6c0
        public void ConvertByteToAngularVelocityFloat(){} // RVA: 0x7ffaaf78c770
        public void .cctor(){} // RVA: 0x7ffaaf78c790
    }

    public class RoomNetworkProperty : Object
    {
        public object Feature_Flags; // 0x33658A60
        public object Use_Instance_Persistence; // 0x33658A60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SyncPhysicsCodec : Object
    {
        // ── Original Methods ──
        public void Encode(){} // RVA: 0x7ffaaf784b40
        public void Decode(){} // RVA: 0x7ffaaf784f30
        public void <Decode>g__getPosFloatAtOffset|3_0(){} // RVA: 0x7ffaaf785120
    }

    public class TimeProxy : Object
    {
        public object RealtimeSinceStartupDelegate; // 0x33390030
        public object SmoothDeltaTimeDelegate; // 0x33390030

        // ── Original Methods ──
        public void get_time(){} // RVA: 0x7ffaaf77cae0
        public void get_timeSinceEnteredRoom(){} // RVA: 0x7ffaaf77cb40
        public void get_realtimeSinceStartup(){} // RVA: 0x7ffaaf77cba0
        public void get_fixedTime(){} // RVA: 0x7ffaaf77cc00
        public void get_deltaTime(){} // RVA: 0x7ffaaf77cc60
        public void get_smoothDeltaTime(){} // RVA: 0x7ffaaf77ccc0
        public void get_unixTime(){} // RVA: 0x7ffaaf77cd20
        public void get_renderedFrameCount(){} // RVA: 0x7ffaaf77cd80
    }

    public class VRCPhotonEvent : Object
    {
        public object ExecutiveAction; // 0x339D5580
        public object VoiceDataReceived; // 0x339D5580
        public object InitialSyncFinished; // 0x339D5580
        public object ReceiveInterval; // 0x339D5580
        public object UdonSerialization32; // 0x339D5580
        public object PropSerialization8; // 0x339D5580
        public object UdonUnreliableSerialization; // 0x339D5580
        public object OwnershipRequest; // 0x339D5580
        public object SerializationRecovery; // 0x339D5580
        public object MasterTransfer; // 0x339D5580
        public object RequestNoPersist; // 0x339D5580
        public object TextChatMessage; // 0x339D5580
        public object StorePurchaseResult; // 0x339D5580
        public object AvatarInteractionList; // 0x339D5580
        public object FocusViewEvent; // 0x339D5580
        public object InstanceContentSettingsUpdate; // 0x339D5580
        public object BulkData; // 0x339D5580
        public object Serialization8Types; // 0x339D5580
        public object UnreliableSerializationTypes; // 0x339D5580
        public object get_Objects; // 0xB3FA0BA0
        public object h; // 0x846D0CA8
        public object in`;
        public object get_SerializationRecovery; // 0xB4163140
        public object h; // 0x846D0CC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf77cde0
    }

}