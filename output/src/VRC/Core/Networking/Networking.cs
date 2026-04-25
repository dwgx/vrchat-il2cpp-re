// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking
// Classes: 26
// Methods: 289

namespace VRC.Core.Networking
{
    public class ArrayPoolShim : Object
    {
        // ── Methods ──
        public void Exchange(){} // RVA: 0x7FFD4E096370
        public void Release(){} // RVA: 0x7FFD4E090A10
        public void Get(){} // RVA: 0x7FFD4E096370 | overloaded x2
    }

    public class ConcurrentLimitedCapacityList`1 : Object
    {
        public object SerializationHistoryLength;
        public object Count;
        public object IsReadOnly;
        public object Capacity;
        public object Item;
        public object Full;

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x7FFD4E079990
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Full(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void PushAt(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void LastOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class DecodeParameters32 : Object
    {
        public object Objects;
        public object ObjectIndex;
        public object SendTime;
        public object SerializationRecovery;
        public object SerializationHashes;
        public object HasSerializationRecovery;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5517AAD0
        public void get_Objects(){} // RVA: 0x7FFD4F842E80
        public void set_Objects(){} // RVA: 0x7FFD519C18F0
        public void get_ObjectIndex(){} // RVA: 0x7FFD4E4FBBE0
        public void set_ObjectIndex(){} // RVA: 0x7FFD4E9FB7A0
        public void get_SendTime(){} // RVA: 0x7FFD4E4AEF50
        public void set_SendTime(){} // RVA: 0x7FFD4E4AEF60
        public void get_SerializationRecovery(){} // RVA: 0x7FFD4E36F130
        public void set_SerializationRecovery(){} // RVA: 0x7FFD4E342E90
        public void get_SerializationHashes(){} // RVA: 0x7FFD5517AB90
        public void get_HasSerializationRecovery(){} // RVA: 0x7FFD5361F390
    }

    public class DecodeParameters8 : Object
    {
        public object Objects;
        public object ObjectIndex;
        public object SendTime;
        public object SerializationRecovery;
        public object SerializationHashes;
        public object HasSerializationRecovery;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5517AAD0
        public void get_Objects(){} // RVA: 0x7FFD4F842E80
        public void set_Objects(){} // RVA: 0x7FFD519C18F0
        public void get_ObjectIndex(){} // RVA: 0x7FFD4E4FBBE0
        public void set_ObjectIndex(){} // RVA: 0x7FFD4E9FB7A0
        public void get_SendTime(){} // RVA: 0x7FFD4E4AEF50
        public void set_SendTime(){} // RVA: 0x7FFD4E4AEF60
        public void get_SerializationRecovery(){} // RVA: 0x7FFD4E36F130
        public void set_SerializationRecovery(){} // RVA: 0x7FFD4E342E90
        public void get_SerializationHashes(){} // RVA: 0x7FFD5517AC40
        public void get_HasSerializationRecovery(){} // RVA: 0x7FFD5361F390
    }

    public class FixedByteBufferAllocator8 : ByteBufferAllocator
    {
        public object Span;
        public object ReadOnlySpan;
        public object Memory;
        public object ReadOnlyMemory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5518D530
        public void GrowFront(){} // RVA: 0x7FFD5518D6D0
        public void Init(){} // RVA: 0x7FFD5518D710
        public void get_Span(){} // RVA: 0x7FFD5518D840
        public void get_ReadOnlySpan(){} // RVA: 0x7FFD5518D8E0
        public void get_Memory(){} // RVA: 0x7FFD5518D990
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFD5518DA80
    }

    public class FlatBufferConfig : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5517ACD0
    }

    public class FlatBufferSerializerCodec : Object
    {
        public object Targets;
        public object ForcePlayerStartSync;

        // ── Methods ──
        public void get_Targets(){} // RVA: 0x7FFD5517BBC0
        public void .ctor(){} // RVA: 0x7FFD5517BC90
        public void Decode8(){} // RVA: 0x7FFD5517C4B0
        public void Encode8(){} // RVA: 0x7FFD5517CA50
        public void Decode32(){} // RVA: 0x7FFD5517D1E0
        public void Encode32(){} // RVA: 0x7FFD5517D800
        public void DecodePlayer8(){} // RVA: 0x7FFD5517DE00
        public void get_ForcePlayerStartSync(){} // RVA: 0x7FFD5517E1D0
        public void EncodePlayer8(){} // RVA: 0x7FFD5517E210
        public void IsPlayerSerialization8MissingFields(){} // RVA: 0x7FFD5517EA60
        public void ConfigureSparseArrays(){} // RVA: 0x7FFD5517EAC0
        public void SparseDecode8(){} // RVA: 0x7FFD5517ED60
        public void SparseEncode8(){} // RVA: 0x7FFD5517F390
        public void SparseDecode32(){} // RVA: 0x7FFD5517FC10
        public void SparseEncode32(){} // RVA: 0x7FFD55180200
        public void FindCorrectIndex(){} // RVA: 0x7FFD55180B20
    }

    public class IEvent
    {
        public object Time;
        public object Store;
        public object Instigator;
        public object ShouldBroadcast;
        public object Serialize;
        public object Sender;

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFD4E07EB60
        public void get_Store(){} // RVA: 0x7FFD4E079D00
        public void get_Instigator(){} // RVA: 0x7FFD4E079960
        public void set_Instigator(){} // RVA: 0x7FFD4E090ED0
        public void get_ShouldBroadcast(){} // RVA: 0x7FFD4E079D00
        public void get_Serialize(){} // RVA: 0x7FFD4E078E90
        public void get_Sender(){} // RVA: 0x7FFD4E079960
        public void set_Sender(){} // RVA: 0x7FFD4E090ED0
        public void DeepClone(){} // RVA: 0x7FFD4E078E90
    }

    public class IFlatBufferNetworkSerializer
    {
        public object EventCode;
        public object name;
        public object IsSparse;
        public object LastEncoding;
        public object Targets;
        public object MaxContentLength8;
        public object MaxContentLength32;

        // ── Methods ──
        public void get_EventCode(){} // RVA: 0x7FFD4E079D00
        public void get_name(){} // RVA: 0x7FFD4E078E90
        public void get_IsSparse(){} // RVA: 0x7FFD4E079D00
        public void get_LastEncoding(){} // RVA: 0x7FFD4E078E90
        public void get_Targets(){} // RVA: 0x7FFD4E078E90
        public void MakeTransformHash(){} // RVA: 0x7FFD4E07E6B0
        public void get_MaxContentLength8(){} // RVA: 0x7FFD55181440
        public void get_MaxContentLength32(){} // RVA: 0x7FFD55181490
    }

    public class ILimitedCapacityList`1
    {
        public object Capacity;

        // ── Methods ──
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void PushAt(){} // RVA: 0x7FFD4E2ADC40
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
    }

    public class ILoggableClass
    {
        // ── Methods ──
        public void LogInfoFormat(){} // RVA: 0x7FFD4E099B30
        public void LogWarningFormat(){} // RVA: 0x7FFD4E099B30
        public void LogErrorFormat(){} // RVA: 0x7FFD4E099B30
        public void LogException(){} // RVA: 0x7FFD4E090A40
        public void LogInfo(){} // RVA: 0x7FFD4E090A40
        public void LogError(){} // RVA: 0x7FFD4E090A40
    }

    public class INetworkReadyReceiver
    {
        // ── Methods ──
        public void OnNetworkReady(){} // RVA: 0x7FFD4E090980
    }

    public class ISyncPhysics
    {
        public object LastPosition;

        // ── Methods ──
        public void get_LastPosition(){} // RVA: 0x7FFD4E078E90
        public void Decode(){}
    }

    public class ITimedValue
    {
        public object Time;

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFD4E08D880
        public void set_Time(){} // RVA: 0x7FFD4E09E480
        public void Copy(){} // RVA: 0x7FFD4E090A40
    }

    public class ITweenableValue
    {
        // ── Methods ──
        public void Tween(){}
        public void Interpolate(){} // RVA: 0x7FFD4E07DFB0
        public void Extrapolate(){} // RVA: 0x7FFD4E07DFB0
    }

    public class IVRC_FlatBufferSerializer
    {
        public object TypeId;

        // ── Methods ──
        public void NeedsSync(){} // RVA: 0x7FFD4E079D00
        public void NeedsImportant(){} // RVA: 0x7FFD4E079D00
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E079D00
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E079D00
        public void Encode(){} // RVA: 0x7FFD4E07E6B0 | overloaded x2
        public void Decode(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_TypeId(){} // RVA: 0x7FFD4E079960
        public void SerializedName(){} // RVA: 0x7FFD4E078E90
    }

    public class IVRC_PersistentSerializer
    {
        public object UniqueHash;

        // ── Methods ──
        public void get_UniqueHash(){} // RVA: 0x7FFD4E079960
        public void GenerateComponentInfo(){} // RVA: 0x7FFD4E087DE0
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFD4E079F60
    }

    public class LimitedCapacityList`1 : Object
    {
        public object SerializationHistoryLength;
        public object Count;
        public object Item;
        public object Capacity;
        public object Full;
        public object IsReadOnly;

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x7FFD4E079990
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
        public void get_Full(){} // RVA: 0x7FFD4E079D00
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void PushAt(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NetworkUpdateRates : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5517A010
    }

    public class NumericExtensions : Object
    {
        // ── Methods ──
        public void Clamp(){} // RVA: 0x7FFD4E2ADC40
        public void SingleToInt(){} // RVA: 0x7FFD5392C850
        public void IntToSingle(){} // RVA: 0x7FFD5392C860
        public void IsBad(){} // RVA: 0x7FFD5518CFC0
        public void IsSafe(){} // RVA: 0x7FFD5518CFE0
        public void AlmostEquals(){} // RVA: 0x7FFD5518D080
        public void CeilToInt(){} // RVA: 0x7FFD5518D100
        public void FloorToInt(){} // RVA: 0x7FFD5518D160
        public void FloatToHalf(){} // RVA: 0x7FFD5518D1C0
        public void HalfToFloat(){} // RVA: 0x7FFD5518D250
        public void MaybeLerpTowards(){} // RVA: 0x7FFD5518D2C0
        public void RoundTo(){} // RVA: 0x7FFD5518D360
    }

    public class PositionEvent : TweenableValue`1
    {
        public object flags;
        public object IsKinematic;
        public object UseGravity;
        public object HeldInHand;
        public object DiscontinuityCounter;
        public object Discontinuity;
        public object isHeld;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55181730 | overloaded x2
        public void DeepCopy(){} // RVA: 0x7FFD55181920
        public void get_flags(){} // RVA: 0x7FFD4E3FCC00
        public void set_flags(){} // RVA: 0x7FFD4E3FCC10
        public void IsBad(){} // RVA: 0x7FFD55181B60
        public void Interpolate(){} // RVA: 0x7FFD55181C30
        public void Extrapolate(){} // RVA: 0x7FFD55181E00
        public void get_IsKinematic(){} // RVA: 0x7FFD55181FD0
        public void set_IsKinematic(){} // RVA: 0x7FFD55181FE0
        public void get_UseGravity(){} // RVA: 0x7FFD55182010
        public void set_UseGravity(){} // RVA: 0x7FFD55182020
        public void get_HeldInHand(){} // RVA: 0x7FFD55182050
        public void set_HeldInHand(){} // RVA: 0x7FFD55182060
        public void get_DiscontinuityCounter(){} // RVA: 0x7FFD55182070
        public void set_DiscontinuityCounter(){} // RVA: 0x7FFD55182080
        public void get_Discontinuity(){} // RVA: 0x7FFD4E409570
        public void set_Discontinuity(){} // RVA: 0x7FFD4E409580
        public void get_isHeld(){} // RVA: 0x7FFD551820A0
        public void IsDiscontinuousWith(){} // RVA: 0x7FFD551820B0
    }

    public class QuantizedSerialization : Object
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFD55185D50 | overloaded x11
        public void Deserialize(){} // RVA: 0x7FFD55186930 | overloaded x15
        public void SerializeQuaternionAsNone(){} // RVA: 0x7FFD55186AC0 | overloaded x2
        public void SerializeVector3AsNone(){} // RVA: 0x7FFD55186D40 | overloaded x2
        public void DeserializeQuaternionFromNone(){} // RVA: 0x7FFD55183BC0 | overloaded x2
        public void DeserializeVector3FromNone(){} // RVA: 0x7FFD55183D40 | overloaded x2
        public void SerializeQuaternionAsHalfFloat(){} // RVA: 0x7FFD55187240 | overloaded x2
        public void SerializeVectorAsHalfFloat(){} // RVA: 0x7FFD551873E0 | overloaded x2
        public void DeserializeQuaternionFromHalfFloat(){} // RVA: 0x7FFD55184150 | overloaded x2
        public void DeserializeVectorFromHalfFloat(){} // RVA: 0x7FFD55184280 | overloaded x2
        public void SerializeQuaternionAsZeroToOneTenBitFloat(){} // RVA: 0x7FFD551879C0 | overloaded x2
        public void SerializeVectorAsZeroToOneTenBitFloat(){} // RVA: 0x7FFD55187C20 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneTenBitFloat(){} // RVA: 0x7FFD55187F90 | overloaded x2
        public void DeserializeVectorFromZeroToOneTenBitFloat(){} // RVA: 0x7FFD55188130 | overloaded x2
        public void SerializeQuaternionAsZeroToOneTwelveBitFloat(){} // RVA: 0x7FFD55188440 | overloaded x2
        public void SerializeVectorAsZeroToOneTwelveBitFloat(){} // RVA: 0x7FFD551886E0 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneTwelveBitFloat(){} // RVA: 0x7FFD55188AC0 | overloaded x2
        public void DeserializeVectorFromZeroToOneTwelveBitFloat(){} // RVA: 0x7FFD55188C60 | overloaded x2
        public void SerializeQuaternionAsZeroToOneEightBitFloat(){} // RVA: 0x7FFD55188FA0 | overloaded x2
        public void SerializeVectorAsZeroToOneEightBitFloat(){} // RVA: 0x7FFD55189200 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneEightBitFloat(){} // RVA: 0x7FFD55189550 | overloaded x2
        public void DeserializeVectorFromZeroToOneEightBitFloat(){} // RVA: 0x7FFD551896F0 | overloaded x2
        public void SerializeFloatsAsNone(){} // RVA: 0x7FFD55186F40
        public void SerializeFloatNotImplemented(){} // RVA: 0x7FFD551870B0
        public void DeserializeFloatsFromNone(){} // RVA: 0x7FFD551870F0
        public void DeserializeFloatNotImplemented(){} // RVA: 0x7FFD55187200
        public void SerializeFloatAsHalfFloat(){} // RVA: 0x7FFD55187530
        public void DeserializeFloatFromHalfFloat(){} // RVA: 0x7FFD55187620
        public void SerializeFloatsAsHalfFloat(){} // RVA: 0x7FFD55187670
        public void DeserializeFloatsFromHalfFloat(){} // RVA: 0x7FFD55187810
        public void FloatToTenBit(){} // RVA: 0x7FFD55187970
        public void TenBitToFloat(){} // RVA: 0x7FFD551879A0
        public void SerializeFloatsAsZeroToOneTenBitFloat(){} // RVA: 0x7FFD55187DC0
        public void DeserializeFloatsFromZeroToOneTenBitFloat(){} // RVA: 0x7FFD55188260
        public void FloatToTwelveBit(){} // RVA: 0x7FFD551883F0
        public void TwelveBitToFloat(){} // RVA: 0x7FFD55188420
        public void SerializeFloatsAsZeroToOneTwelveBitFloat(){} // RVA: 0x7FFD551888B0
        public void DeserializeFloatsFromZeroToOneTwelveBitFloat(){} // RVA: 0x7FFD55188D90
        public void FloatToEightBit(){} // RVA: 0x7FFD55188F50
        public void EightBitToFloat(){} // RVA: 0x7FFD55188F80
        public void SerializeFloatsAsZeroToOneEightBitFloat(){} // RVA: 0x7FFD55189390
        public void DeserializeFloatsFromZeroToOneEightBitFloat(){} // RVA: 0x7FFD55189820
        public void Clamp(){} // RVA: 0x7FFD55189A70 | overloaded x2
        public void ConvertPuppetFloatToByte(){} // RVA: 0x7FFD55189AE0
        public void ConvertByteToPuppetFloat(){} // RVA: 0x7FFD55189C60
        public void ConvertAngularVelocityFloatToByte(){} // RVA: 0x7FFD55189C90
        public void ConvertByteToAngularVelocityFloat(){} // RVA: 0x7FFD55189D40
        public void .cctor(){} // RVA: 0x7FFD55189D60
    }

    public class RoomNetworkProperty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SyncPhysicsCodec : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFD55182110
        public void Decode(){} // RVA: 0x7FFD55182500
        public void <Decode>g__getPosFloatAtOffset|3_0(){} // RVA: 0x7FFD551826F0
    }

    public class TimeProxy : Object
    {
        public object time;
        public object timeSinceEnteredRoom;
        public object realtimeSinceStartup;
        public object fixedTime;
        public object deltaTime;
        public object smoothDeltaTime;
        public object unixTime;
        public object renderedFrameCount;

        // ── Methods ──
        public void get_time(){} // RVA: 0x7FFD5517A0B0
        public void get_timeSinceEnteredRoom(){} // RVA: 0x7FFD5517A110
        public void get_realtimeSinceStartup(){} // RVA: 0x7FFD5517A170
        public void get_fixedTime(){} // RVA: 0x7FFD5517A1D0
        public void get_deltaTime(){} // RVA: 0x7FFD5517A230
        public void get_smoothDeltaTime(){} // RVA: 0x7FFD5517A290
        public void get_unixTime(){} // RVA: 0x7FFD5517A2F0
        public void get_renderedFrameCount(){} // RVA: 0x7FFD5517A350
    }

    public class VRCPhotonEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5517A3B0
    }

}