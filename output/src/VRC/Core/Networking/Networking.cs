// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking
// Classes: 27
// Methods: 296

namespace VRC.Core.Networking
{
    public class ArrayPoolShim : Object
    {
        // ── Methods ──
        public void Exchange(){} // RVA: 0x7FFE80E4BA70
        public void Release(){} // RVA: 0x7FFE80E46070
        public void Get(){} // RVA: 0x7FFE80E4BA70 | overloaded x2
    }

    public class ConcurrentLimitedCapacityList`1 : Object
    {
        public VRC.Core.Networking.LimitedCapacityList`1<T> theList;
        public object field_1; // 0x6A
        public object field_2; // 0x6B
        public object field_3; // 0x6C
        public object field_4; // 0x6D
        public object field_5; // 0x6E

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x7FFE80E2EDE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Full(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Push(){} // RVA: 0x7FFE810A1420
        public void PushAt(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void LastOrDefault(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class DecodeParameters32 : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.SerializedObjects _objects; // 0x10
        public int _objectIndex; // 0x20
        public float _sendTime; // 0x24
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataT _serializationRecovery; // 0x28
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_5; // 0x43

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88104620
        public void get_Objects(){} // RVA: 0x7FFE826F6B90
        public void set_Objects(){} // RVA: 0x7FFE848F1740
        public void get_ObjectIndex(){} // RVA: 0x7FFE8151D690
        public void set_ObjectIndex(){} // RVA: 0x7FFE8170B670
        public void get_SendTime(){} // RVA: 0x7FFE81268F50
        public void set_SendTime(){} // RVA: 0x7FFE81268F60
        public void get_SerializationRecovery(){} // RVA: 0x7FFE81129130
        public void set_SerializationRecovery(){} // RVA: 0x7FFE810FCE90
        public void get_SerializationHashes(){} // RVA: 0x7FFE881046E0
        public void get_HasSerializationRecovery(){} // RVA: 0x7FFE865A8CD0
    }

    public class DecodeParameters8 : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.SerializedObjects _objects; // 0x10
        public int _objectIndex; // 0x20
        public float _sendTime; // 0x24
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataT _serializationRecovery; // 0x28
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_5; // 0x49

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88104620
        public void get_Objects(){} // RVA: 0x7FFE826F6B90
        public void set_Objects(){} // RVA: 0x7FFE848F1740
        public void get_ObjectIndex(){} // RVA: 0x7FFE8151D690
        public void set_ObjectIndex(){} // RVA: 0x7FFE8170B670
        public void get_SendTime(){} // RVA: 0x7FFE81268F50
        public void set_SendTime(){} // RVA: 0x7FFE81268F60
        public void get_SerializationRecovery(){} // RVA: 0x7FFE81129130
        public void set_SerializationRecovery(){} // RVA: 0x7FFE810FCE90
        public void get_SerializationHashes(){} // RVA: 0x7FFE88104790
        public void get_HasSerializationRecovery(){} // RVA: 0x7FFE865A8CD0
    }

    public class FixedByteBufferAllocator32 : ByteBufferAllocator
    {
        public byte[] Buffer; // 0x18
        public object field_1; // 0x7A
        public object field_2; // 0x7B
        public object field_3; // 0x7C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881176B0
        public void GrowFront(){} // RVA: 0x7FFE88117850
        public void Init(){} // RVA: 0x7FFE88117890
        public void get_Span(){} // RVA: 0x7FFE881179C0
        public void get_ReadOnlySpan(){} // RVA: 0x7FFE88117A60
        public void get_Memory(){} // RVA: 0x7FFE88117B00
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFE88117BF0
    }

    public class FixedByteBufferAllocator8 : ByteBufferAllocator
    {
        public byte[] Buffer; // 0x18
        public object field_1; // 0x76
        public object field_2; // 0x77
        public object field_3; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88117080
        public void GrowFront(){} // RVA: 0x7FFE88117220
        public void Init(){} // RVA: 0x7FFE88117260
        public void get_Span(){} // RVA: 0x7FFE88117390
        public void get_ReadOnlySpan(){} // RVA: 0x7FFE88117430
        public void get_Memory(){} // RVA: 0x7FFE881174D0
        public void get_ReadOnlyMemory(){} // RVA: 0x7FFE881175C0
    }

    public class FlatBufferConfig : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88104820
    }

    public class FlatBufferSerializerCodec : Object
    {
        public VRC.Core.Networking.IFlatBufferNetworkSerializer serializer; // 0x10
        public bool verboseLogging; // 0x18

        // ── Methods ──
        public void get_Targets(){} // RVA: 0x7FFE88105710
        public void .ctor(){} // RVA: 0x7FFE881057E0
        public void Decode8(){} // RVA: 0x7FFE88106000
        public void Encode8(){} // RVA: 0x7FFE881065A0
        public void Decode32(){} // RVA: 0x7FFE88106D30
        public void Encode32(){} // RVA: 0x7FFE88107350
        public void DecodePlayer8(){} // RVA: 0x7FFE88107950
        public void get_ForcePlayerStartSync(){} // RVA: 0x7FFE88107D20
        public void EncodePlayer8(){} // RVA: 0x7FFE88107D60
        public void IsPlayerSerialization8MissingFields(){} // RVA: 0x7FFE881085B0
        public void ConfigureSparseArrays(){} // RVA: 0x7FFE88108610
        public void SparseDecode8(){} // RVA: 0x7FFE881088B0
        public void SparseEncode8(){} // RVA: 0x7FFE88108EE0
        public void SparseDecode32(){} // RVA: 0x7FFE88109760
        public void SparseEncode32(){} // RVA: 0x7FFE88109D50
        public void FindCorrectIndex(){} // RVA: 0x7FFE8810A670
    }

    public class IEvent
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFE80E33FB0
        public void get_Store(){} // RVA: 0x7FFE80E2F150
        public void get_Instigator(){} // RVA: 0x7FFE80E2EDB0
        public void set_Instigator(){} // RVA: 0x7FFE80E46530
        public void get_ShouldBroadcast(){} // RVA: 0x7FFE80E2F150
        public void get_Serialize(){} // RVA: 0x7FFE80E2E2E0
        public void get_Sender(){} // RVA: 0x7FFE80E2EDB0
        public void set_Sender(){} // RVA: 0x7FFE80E46530
        public void DeepClone(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IFlatBufferNetworkSerializer
    {
        public int HeaderLength8;
        public int HeaderLength32;
        public object field_2; // 0x57
        public object field_3; // 0x58
        public object field_4; // 0x59
        public object field_5; // 0x5A
        public object field_6; // 0x5B

        // ── Methods ──
        public void get_EventCode(){} // RVA: 0x7FFE80E2F150
        public void get_name(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsSparse(){} // RVA: 0x7FFE80E2F150
        public void get_LastEncoding(){} // RVA: 0x7FFE80E2E2E0
        public void get_Targets(){} // RVA: 0x7FFE80E2E2E0
        public void MakeTransformHash(){} // RVA: 0x7FFE80E33B00
        public void get_MaxContentLength8(){} // RVA: 0x7FFE8810AF90
        public void get_MaxContentLength32(){} // RVA: 0x7FFE8810AFE0
    }

    public class ILimitedCapacityList`1
    {
        // ── Methods ──
        public void Push(){} // RVA: 0x7FFE810A1420
        public void PushAt(){} // RVA: 0x7FFE810A1420
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
    }

    public class ILoggableClass
    {
        // ── Methods ──
        public void LogInfoFormat(){} // RVA: 0x7FFE80E4F230
        public void LogWarningFormat(){} // RVA: 0x7FFE80E4F230
        public void LogErrorFormat(){} // RVA: 0x7FFE80E4F230
        public void LogException(){} // RVA: 0x7FFE80E460A0
        public void LogInfo(){} // RVA: 0x7FFE80E460A0
        public void LogError(){} // RVA: 0x7FFE80E460A0
    }

    public class INetworkReadyReceiver
    {
        // ── Methods ──
        public void OnNetworkReady(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISyncPhysics
    {
        // ── Methods ──
        public void get_LastPosition(){} // RVA: 0x7FFE80E2E2E0
        public void Decode(){}
    }

    public class ITimedValue
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFE80E42E10
        public void set_Time(){} // RVA: 0x7FFE80E53B80
        public void Copy(){} // RVA: 0x7FFE80E460A0
    }

    public class ITweenableValue
    {
        // ── Methods ──
        public void Tween(){}
        public void Interpolate(){} // RVA: 0x7FFE80E33400
        public void Extrapolate(){} // RVA: 0x7FFE80E33400
    }

    public class IVRC_FlatBufferSerializer
    {
        // ── Methods ──
        public void NeedsSync(){} // RVA: 0x7FFE80E2F150
        public void NeedsImportant(){} // RVA: 0x7FFE80E2F150
        public void CanSerialize8Bit(){} // RVA: 0x7FFE80E2F150
        public void CanSerialize32Bit(){} // RVA: 0x7FFE80E2F150
        public void Encode(){} // RVA: 0x7FFE80E33B00 | overloaded x2
        public void Decode(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_TypeId(){} // RVA: 0x7FFE80E2EDB0
        public void SerializedName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IVRC_PersistentSerializer
    {
        // ── Methods ──
        public void get_UniqueHash(){} // RVA: 0x7FFE80E2EDB0
        public void GenerateComponentInfo(){} // RVA: 0x7FFE80E3D230
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFE80E2F3B0
    }

    public class LimitedCapacityList`1 : Object
    {
        public System.Collections.Generic.List`1<T> data;
        public System.Collections.Generic.List`1<VRC.Core.Networking.PositionEvent> data; // 0x10
        public bool field_2; // 0x3030
        public object field_3; // 0xB960
        public object field_4; // 0xFFFF
        public object field_5; // 0x3010

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x7FFE80E2EDE0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_Full(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Push(){} // RVA: 0x7FFE810A1420
        public void PushAt(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
    }

    public class NetworkUpdateRates : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88103B60
    }

    public class NumericExtensions : Object
    {
        // ── Methods ──
        public void Clamp(){} // RVA: 0x7FFE810A1420
        public void SingleToInt(){} // RVA: 0x7FFE868B6050
        public void IntToSingle(){} // RVA: 0x7FFE868B6060
        public void IsBad(){} // RVA: 0x7FFE88116B10
        public void IsSafe(){} // RVA: 0x7FFE88116B30
        public void AlmostEquals(){} // RVA: 0x7FFE88116BD0
        public void CeilToInt(){} // RVA: 0x7FFE88116C50
        public void FloorToInt(){} // RVA: 0x7FFE88116CB0
        public void FloatToHalf(){} // RVA: 0x7FFE88116D10
        public void HalfToFloat(){} // RVA: 0x7FFE88116DA0
        public void MaybeLerpTowards(){} // RVA: 0x7FFE88116E10
        public void RoundTo(){} // RVA: 0x7FFE88116EB0
    }

    public class PositionEvent : TweenableValue`1
    {
        public byte _flags; // 0x40
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T Velocity; // 0x48
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T Position; // 0x50
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT Rotation; // 0x58
        public bool WasSleeping; // 0x60
        public bool HasValue; // 0x61
        public int OwnerID; // 0x64

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8810B280 | overloaded x2
        public void DeepCopy(){} // RVA: 0x7FFE8810B470
        public void get_flags(){} // RVA: 0x7FFE811B6C00
        public void set_flags(){} // RVA: 0x7FFE811B6C10
        public void IsBad(){} // RVA: 0x7FFE8810B6B0
        public void Interpolate(){} // RVA: 0x7FFE8810B780
        public void Extrapolate(){} // RVA: 0x7FFE8810B950
        public void get_IsKinematic(){} // RVA: 0x7FFE8810BB20
        public void set_IsKinematic(){} // RVA: 0x7FFE8810BB30
        public void get_UseGravity(){} // RVA: 0x7FFE8810BB60
        public void set_UseGravity(){} // RVA: 0x7FFE8810BB70
        public void get_HeldInHand(){} // RVA: 0x7FFE8810BBA0
        public void set_HeldInHand(){} // RVA: 0x7FFE8810BBB0
        public void get_DiscontinuityCounter(){} // RVA: 0x7FFE8810BBC0
        public void set_DiscontinuityCounter(){} // RVA: 0x7FFE8810BBD0
        public void get_Discontinuity(){} // RVA: 0x7FFE811C3570
        public void set_Discontinuity(){} // RVA: 0x7FFE811C3580
        public void get_isHeld(){} // RVA: 0x7FFE8810BBF0
        public void IsDiscontinuousWith(){} // RVA: 0x7FFE8810BC00
    }

    public class QuantizedSerialization : Object
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFE8810F8A0 | overloaded x11
        public void Deserialize(){} // RVA: 0x7FFE88110480 | overloaded x15
        public void SerializeQuaternionAsNone(){} // RVA: 0x7FFE88110610 | overloaded x2
        public void SerializeVector3AsNone(){} // RVA: 0x7FFE88110890 | overloaded x2
        public void DeserializeQuaternionFromNone(){} // RVA: 0x7FFE8810D710 | overloaded x2
        public void DeserializeVector3FromNone(){} // RVA: 0x7FFE8810D890 | overloaded x2
        public void SerializeQuaternionAsHalfFloat(){} // RVA: 0x7FFE88110D90 | overloaded x2
        public void SerializeVectorAsHalfFloat(){} // RVA: 0x7FFE88110F30 | overloaded x2
        public void DeserializeQuaternionFromHalfFloat(){} // RVA: 0x7FFE8810DCA0 | overloaded x2
        public void DeserializeVectorFromHalfFloat(){} // RVA: 0x7FFE8810DDD0 | overloaded x2
        public void SerializeQuaternionAsZeroToOneTenBitFloat(){} // RVA: 0x7FFE88111510 | overloaded x2
        public void SerializeVectorAsZeroToOneTenBitFloat(){} // RVA: 0x7FFE88111770 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneTenBitFloat(){} // RVA: 0x7FFE88111AE0 | overloaded x2
        public void DeserializeVectorFromZeroToOneTenBitFloat(){} // RVA: 0x7FFE88111C80 | overloaded x2
        public void SerializeQuaternionAsZeroToOneTwelveBitFloat(){} // RVA: 0x7FFE88111F90 | overloaded x2
        public void SerializeVectorAsZeroToOneTwelveBitFloat(){} // RVA: 0x7FFE88112230 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneTwelveBitFloat(){} // RVA: 0x7FFE88112610 | overloaded x2
        public void DeserializeVectorFromZeroToOneTwelveBitFloat(){} // RVA: 0x7FFE881127B0 | overloaded x2
        public void SerializeQuaternionAsZeroToOneEightBitFloat(){} // RVA: 0x7FFE88112AF0 | overloaded x2
        public void SerializeVectorAsZeroToOneEightBitFloat(){} // RVA: 0x7FFE88112D50 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneEightBitFloat(){} // RVA: 0x7FFE881130A0 | overloaded x2
        public void DeserializeVectorFromZeroToOneEightBitFloat(){} // RVA: 0x7FFE88113240 | overloaded x2
        public void SerializeFloatsAsNone(){} // RVA: 0x7FFE88110A90
        public void SerializeFloatNotImplemented(){} // RVA: 0x7FFE88110C00
        public void DeserializeFloatsFromNone(){} // RVA: 0x7FFE88110C40
        public void DeserializeFloatNotImplemented(){} // RVA: 0x7FFE88110D50
        public void SerializeFloatAsHalfFloat(){} // RVA: 0x7FFE88111080
        public void DeserializeFloatFromHalfFloat(){} // RVA: 0x7FFE88111170
        public void SerializeFloatsAsHalfFloat(){} // RVA: 0x7FFE881111C0
        public void DeserializeFloatsFromHalfFloat(){} // RVA: 0x7FFE88111360
        public void FloatToTenBit(){} // RVA: 0x7FFE881114C0
        public void TenBitToFloat(){} // RVA: 0x7FFE881114F0
        public void SerializeFloatsAsZeroToOneTenBitFloat(){} // RVA: 0x7FFE88111910
        public void DeserializeFloatsFromZeroToOneTenBitFloat(){} // RVA: 0x7FFE88111DB0
        public void FloatToTwelveBit(){} // RVA: 0x7FFE88111F40
        public void TwelveBitToFloat(){} // RVA: 0x7FFE88111F70
        public void SerializeFloatsAsZeroToOneTwelveBitFloat(){} // RVA: 0x7FFE88112400
        public void DeserializeFloatsFromZeroToOneTwelveBitFloat(){} // RVA: 0x7FFE881128E0
        public void FloatToEightBit(){} // RVA: 0x7FFE88112AA0
        public void EightBitToFloat(){} // RVA: 0x7FFE88112AD0
        public void SerializeFloatsAsZeroToOneEightBitFloat(){} // RVA: 0x7FFE88112EE0
        public void DeserializeFloatsFromZeroToOneEightBitFloat(){} // RVA: 0x7FFE88113370
        public void Clamp(){} // RVA: 0x7FFE881135C0 | overloaded x2
        public void ConvertPuppetFloatToByte(){} // RVA: 0x7FFE88113630
        public void ConvertByteToPuppetFloat(){} // RVA: 0x7FFE881137B0
        public void ConvertAngularVelocityFloatToByte(){} // RVA: 0x7FFE881137E0
        public void ConvertByteToAngularVelocityFloat(){} // RVA: 0x7FFE88113890
        public void .cctor(){} // RVA: 0x7FFE881138B0
    }

    public class RoomNetworkProperty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SyncPhysicsCodec : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFE8810BC60
        public void Decode(){} // RVA: 0x7FFE8810C050
        public void <Decode>g__getPosFloatAtOffset|3_0(){} // RVA: 0x7FFE8810C240
    }

    public class TimeProxy : Object
    {
        public System.Func`1<float> TimeDelegate;
        public System.Func`1<float> TimeSinceEnteredRoomDelegate; // 0x8
        public System.Func`1<float> RealtimeSinceStartupDelegate; // 0x10
        public System.Func`1<float> FixedTimeDelegate; // 0x18
        public System.Func`1<float> DeltaTimeDelegate; // 0x20
        public System.Func`1<float> SmoothDeltaTimeDelegate; // 0x28
        public System.Func`1<long> UnixTimeDelegate; // 0x30
        public System.Func`1<int> FrameCountDelegate; // 0x38

        // ── Methods ──
        public void get_time(){} // RVA: 0x7FFE88103C00
        public void get_timeSinceEnteredRoom(){} // RVA: 0x7FFE88103C60
        public void get_realtimeSinceStartup(){} // RVA: 0x7FFE88103CC0
        public void get_fixedTime(){} // RVA: 0x7FFE88103D20
        public void get_deltaTime(){} // RVA: 0x7FFE88103D80
        public void get_smoothDeltaTime(){} // RVA: 0x7FFE88103DE0
        public void get_unixTime(){} // RVA: 0x7FFE88103E40
        public void get_renderedFrameCount(){} // RVA: 0x7FFE88103EA0
    }

    public class VRCPhotonEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE88103F00
    }

}