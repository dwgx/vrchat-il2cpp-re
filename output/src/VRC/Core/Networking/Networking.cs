// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking
// Classes: 43
// Methods: 496

namespace VRC.Core.Networking
{
    public class ArrayPoolShim
    {
        // ── Methods ──
        public void Exchange(){} // RVA: 0x2A490
        public void Release(){} // RVA: 0x24AE0
        public void Get(){} // RVA: 0x2A490 | overloaded x2
    }

    public class ConcurrentLimitedCapacityList`1
    {
        public VRC.Core.Networking.LimitedCapacityList`1<T> theList;

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0xD870
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void get_Capacity(){} // RVA: 0xD840
        public void set_Capacity(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Full(){} // RVA: 0xDBE0
        public void Add(){} // RVA: 0x283FA0
        public void Push(){} // RVA: 0x283FA0
        public void PushAt(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void Remove(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void LastOrDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class ConcurrentLimitedCapacityList`1 : VRC.Core.Networking
    {
        public VRC.Core.Networking.LimitedCapacityList`1<VRC.Core.Networking.PositionEvent> theList; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x2A93640
        public void .ctor(){} // RVA: 0x2A937C0 | overloaded x2
        public void get_Count(){} // RVA: 0x2A93910
        public void get_IsReadOnly(){} // RVA: 0x2A93A70
        public void get_Capacity(){} // RVA: 0x2A93BB0
        public void set_Capacity(){} // RVA: 0x2A93D20
        public void get_Item(){} // RVA: 0x2A94010
        public void set_Item(){} // RVA: 0x2A941B0
        public void get_Full(){} // RVA: 0x2A94350
        public void Add(){} // RVA: 0x2A94390
        public void Push(){} // RVA: 0x2A94500
        public void PushAt(){} // RVA: 0x2A94770
        public void Clear(){} // RVA: 0x2A949B0
        public void Contains(){} // RVA: 0x2A94B30
        public void CopyTo(){} // RVA: 0x2A94D30
        public void Remove(){} // RVA: 0x2A94ED0
        public void GetEnumerator(){} // RVA: 0x2A95090
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A95090
        public void IndexOf(){} // RVA: 0x2A95200
        public void Insert(){} // RVA: 0x2A953E0
        public void RemoveAt(){} // RVA: 0x2A95580
        public void LastOrDefault(){} // RVA: 0x2A95D20 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x2A95AE0 | overloaded x2
    }

    public class ConcurrentLimitedCapacityList`1 : VRC.Core.Networking
    {
        public VRC.Core.Networking.LimitedCapacityList`1<VRC.Core.Networking.Pose.PoseEvent> theList; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x2A93640
        public void .ctor(){} // RVA: 0x2A937C0 | overloaded x2
        public void get_Count(){} // RVA: 0x2A93910
        public void get_IsReadOnly(){} // RVA: 0x2A93A70
        public void get_Capacity(){} // RVA: 0x2A93BB0
        public void set_Capacity(){} // RVA: 0x2A93D20
        public void get_Item(){} // RVA: 0x2A94010
        public void set_Item(){} // RVA: 0x2A941B0
        public void get_Full(){} // RVA: 0x2A94350
        public void Add(){} // RVA: 0x2A94390
        public void Push(){} // RVA: 0x2A94500
        public void PushAt(){} // RVA: 0x2A94770
        public void Clear(){} // RVA: 0x2A949B0
        public void Contains(){} // RVA: 0x2A94B30
        public void CopyTo(){} // RVA: 0x2A94D30
        public void Remove(){} // RVA: 0x2A94ED0
        public void GetEnumerator(){} // RVA: 0x2A95090
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A95090
        public void IndexOf(){} // RVA: 0x2A95200
        public void Insert(){} // RVA: 0x2A953E0
        public void RemoveAt(){} // RVA: 0x2A95580
        public void LastOrDefault(){} // RVA: 0x2A95D20 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x2A95AE0 | overloaded x2
    }

    public class DecodeParameters32
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.SerializedObjects <Objects>k__BackingField; // 0x10
        public int <ObjectIndex>k__BackingField; // 0x20
        public float <SendTime>k__BackingField; // 0x24
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataT <SerializationRecovery>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75C75D0
        public void get_Objects(){} // RVA: 0x196ABE0
        public void set_Objects(){} // RVA: 0x3C7BF40
        public void get_ObjectIndex(){} // RVA: 0x760030
        public void set_ObjectIndex(){} // RVA: 0x99E0D0
        public void get_SendTime(){} // RVA: 0x44AF50
        public void set_SendTime(){} // RVA: 0x44AF60
        public void get_SerializationRecovery(){} // RVA: 0x30B130
        public void set_SerializationRecovery(){} // RVA: 0x2DEE90
        public void get_SerializationHashes(){} // RVA: 0x75C7690
        public void get_HasSerializationRecovery(){} // RVA: 0x5A67FD0
    }

    public class DecodeParameters8
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.SerializedObjects <Objects>k__BackingField; // 0x10
        public int <ObjectIndex>k__BackingField; // 0x20
        public float <SendTime>k__BackingField; // 0x24
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataT <SerializationRecovery>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75C75D0
        public void get_Objects(){} // RVA: 0x196ABE0
        public void set_Objects(){} // RVA: 0x3C7BF40
        public void get_ObjectIndex(){} // RVA: 0x760030
        public void set_ObjectIndex(){} // RVA: 0x99E0D0
        public void get_SendTime(){} // RVA: 0x44AF50
        public void set_SendTime(){} // RVA: 0x44AF60
        public void get_SerializationRecovery(){} // RVA: 0x30B130
        public void set_SerializationRecovery(){} // RVA: 0x2DEE90
        public void get_SerializationHashes(){} // RVA: 0x75C7740
        public void get_HasSerializationRecovery(){} // RVA: 0x5A67FD0
    }

    public class FixedByteBufferAllocator32
    {
        public byte[] Buffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75DA660
        public void GrowFront(){} // RVA: 0x75DA800
        public void Init(){} // RVA: 0x75DA840
        public void get_Span(){} // RVA: 0x75DA970
        public void get_ReadOnlySpan(){} // RVA: 0x75DAA10
        public void get_Memory(){} // RVA: 0x75DAAB0
        public void get_ReadOnlyMemory(){} // RVA: 0x75DABA0
    }

    public class FixedByteBufferAllocator8
    {
        public byte[] Buffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75DA030
        public void GrowFront(){} // RVA: 0x75DA1D0
        public void Init(){} // RVA: 0x75DA210
        public void get_Span(){} // RVA: 0x75DA340
        public void get_ReadOnlySpan(){} // RVA: 0x75DA3E0
        public void get_Memory(){} // RVA: 0x75DA480
        public void get_ReadOnlyMemory(){} // RVA: 0x75DA570
    }

    public class FlatBufferConfig
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75C77D0
    }

    public class FlatBufferSerializerCodec
    {
        public VRC.Core.Networking.IFlatBufferNetworkSerializer serializer; // 0x10
        public bool verboseLogging; // 0x18

        // ── Methods ──
        public void get_Targets(){} // RVA: 0x75C86C0
        public void .ctor(){} // RVA: 0x75C8790
        public void Decode8(){} // RVA: 0x75C8FB0
        public void Encode8(){} // RVA: 0x75C9550
        public void Decode32(){} // RVA: 0x75C9CE0
        public void Encode32(){} // RVA: 0x75CA300
        public void DecodePlayer8(){} // RVA: 0x75CA900
        public void get_ForcePlayerStartSync(){} // RVA: 0x75CACD0
        public void EncodePlayer8(){} // RVA: 0x75CAD10
        public void IsPlayerSerialization8MissingFields(){} // RVA: 0x75CB560
        public void ConfigureSparseArrays(){} // RVA: 0x75CB5C0
        public void SparseDecode8(){} // RVA: 0x75CB860
        public void SparseEncode8(){} // RVA: 0x75CBE90
        public void SparseDecode32(){} // RVA: 0x75CC710
        public void SparseEncode32(){} // RVA: 0x75CCD00
        public void FindCorrectIndex(){} // RVA: 0x75CD620
    }

    public class IEvent
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x12A40
        public void get_Store(){} // RVA: 0xDBE0
        public void get_Instigator(){} // RVA: 0xD840
        public void set_Instigator(){} // RVA: 0x24FA0
        public void get_ShouldBroadcast(){} // RVA: 0xDBE0
        public void get_Serialize(){} // RVA: 0xCD60
        public void get_Sender(){} // RVA: 0xD840
        public void set_Sender(){} // RVA: 0x24FA0
        public void DeepClone(){} // RVA: 0xCD60
    }

    public class IFlatBufferNetworkSerializer
    {
        public int HeaderLength8;
        public int HeaderLength32;

        // ── Methods ──
        public void get_EventCode(){} // RVA: 0xDBE0
        public void get_name(){} // RVA: 0xCD60
        public void get_IsSparse(){} // RVA: 0xDBE0
        public void get_LastEncoding(){} // RVA: 0xCD60
        public void get_Targets(){} // RVA: 0xCD60
        public void MakeTransformHash(){} // RVA: 0x12590
        public void get_MaxContentLength8(){} // RVA: 0x75CDF40
        public void get_MaxContentLength32(){} // RVA: 0x75CDF90
    }

    public class ILimitedCapacityList`1
    {
        // ── Methods ──
        public void Push(){} // RVA: 0x283FA0
        public void PushAt(){} // RVA: 0x283FA0
        public void get_Capacity(){} // RVA: 0xD840
        public void set_Capacity(){} // RVA: 0x24FA0
    }

    public class ILimitedCapacityList`1
    {
        // ── Methods ──
        public void Push(){} // RVA: 0xCE10
        public void PushAt(){} // RVA: 0x1CEE0
        public void get_Capacity(){} // RVA: 0xD840
        public void set_Capacity(){} // RVA: 0x24FA0
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILimitedCapacityList`1
    {
    }

    public class ILoggableClass
    {
        // ── Methods ──
        public void LogInfoFormat(){} // RVA: 0x2DC60
        public void LogWarningFormat(){} // RVA: 0x2DC60
        public void LogErrorFormat(){} // RVA: 0x2DC60
        public void LogException(){} // RVA: 0x24B10
        public void LogInfo(){} // RVA: 0x24B10
        public void LogError(){} // RVA: 0x24B10
    }

    public class INetworkReadyReceiver
    {
        // ── Methods ──
        public void OnNetworkReady(){} // RVA: 0x24A50
    }

    public class ISyncPhysics
    {
        // ── Methods ──
        public void get_LastPosition(){} // RVA: 0xCD60
        public void Decode(){}
    }

    public class ITimedValue
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x21890
        public void set_Time(){} // RVA: 0x325B0
        public void Copy(){} // RVA: 0x24B10
    }

    public class ITweenableValue
    {
        // ── Methods ──
        public void Tween(){}
        public void Interpolate(){} // RVA: 0x11E90
        public void Extrapolate(){} // RVA: 0x11E90
    }

    public class IVRC_FlatBufferSerializer
    {
        // ── Methods ──
        public void NeedsSync(){} // RVA: 0xDBE0
        public void NeedsImportant(){} // RVA: 0xDBE0
        public void CanSerialize8Bit(){} // RVA: 0xDBE0
        public void CanSerialize32Bit(){} // RVA: 0xDBE0
        public void Encode(){} // RVA: 0x12590 | overloaded x2
        public void Decode(){} // RVA: 0x24B10 | overloaded x2
        public void get_TypeId(){} // RVA: 0xD840
        public void SerializedName(){} // RVA: 0xCD60
    }

    public class IVRC_PersistentSerializer
    {
        // ── Methods ──
        public void get_UniqueHash(){} // RVA: 0xD840
        public void GenerateComponentInfo(){} // RVA: 0x1BCC0
        public void CanUsePersistenceHashes(){} // RVA: 0xDE40
    }

    public class LimitedCapacityList`1
    {
        public System.Collections.Generic.List`1<T> data;

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0xD870
        public void get_Count(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void get_Capacity(){} // RVA: 0xD840
        public void set_Capacity(){} // RVA: 0x24FA0
        public void get_Full(){} // RVA: 0xDBE0
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Add(){} // RVA: 0x283FA0
        public void Push(){} // RVA: 0x283FA0
        public void PushAt(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void Remove(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
    }

    public class LimitedCapacityList`1
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.PositionEvent> data; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x37E25A0
        public void get_Count(){} // RVA: 0x37E2650
        public void get_Item(){} // RVA: 0x2AC4300
        public void set_Item(){} // RVA: 0x2BCC680
        public void .ctor(){} // RVA: 0x37E2880 | overloaded x2
        public void get_Capacity(){} // RVA: 0x37E28C0
        public void set_Capacity(){} // RVA: 0x37E28F0
        public void get_Full(){} // RVA: 0x37E2A60
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x37E2A90
        public void Push(){} // RVA: 0x37E2B70
        public void PushAt(){} // RVA: 0x37E2C80
        public void Clear(){} // RVA: 0x2BCC740
        public void Contains(){} // RVA: 0x37E2D60
        public void CopyTo(){} // RVA: 0x2AC3D20
        public void Remove(){} // RVA: 0x37E2DE0
        public void GetEnumerator(){} // RVA: 0x37E2E10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37E2E10
        public void IndexOf(){} // RVA: 0x37E2EE0
        public void Insert(){} // RVA: 0x37E2F40
        public void RemoveAt(){} // RVA: 0x37E3080
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x37E30B0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E30F0
    }

    public class LimitedCapacityList`1
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.Pose.PoseEvent> data; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x37E25A0
        public void get_Count(){} // RVA: 0x37E2650
        public void get_Item(){} // RVA: 0x2AC4300
        public void set_Item(){} // RVA: 0x2BCC680
        public void .ctor(){} // RVA: 0x37E2880 | overloaded x2
        public void get_Capacity(){} // RVA: 0x37E28C0
        public void set_Capacity(){} // RVA: 0x37E28F0
        public void get_Full(){} // RVA: 0x37E2A60
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x37E2A90
        public void Push(){} // RVA: 0x37E2B70
        public void PushAt(){} // RVA: 0x37E2C80
        public void Clear(){} // RVA: 0x2BCC740
        public void Contains(){} // RVA: 0x37E2D60
        public void CopyTo(){} // RVA: 0x2AC3D20
        public void Remove(){} // RVA: 0x37E2DE0
        public void GetEnumerator(){} // RVA: 0x37E2E10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37E2E10
        public void IndexOf(){} // RVA: 0x37E2EE0
        public void Insert(){} // RVA: 0x37E2F40
        public void RemoveAt(){} // RVA: 0x37E3080
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x37E30B0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E30F0
    }

    public class LimitedCapacityList`1 : VRC.Core.Networking
    {
        public System.Collections.Generic.List`1<float> data; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x37E3110
        public void get_Count(){} // RVA: 0x37E2650
        public void get_Item(){} // RVA: 0x37E31C0
        public void set_Item(){} // RVA: 0x37E3210
        public void .ctor(){} // RVA: 0x37E3470 | overloaded x2
        public void get_Capacity(){} // RVA: 0x37E28C0
        public void set_Capacity(){} // RVA: 0x37E34B0
        public void get_Full(){} // RVA: 0x37E2A60
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x37E36C0
        public void Push(){} // RVA: 0x37E37D0
        public void PushAt(){} // RVA: 0x37E3900
        public void Clear(){} // RVA: 0x37E3A10
        public void Contains(){} // RVA: 0x37E3A40
        public void CopyTo(){} // RVA: 0x2AC3D20
        public void Remove(){} // RVA: 0x37E3AC0
        public void GetEnumerator(){} // RVA: 0x37E3AF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37E3AF0
        public void IndexOf(){} // RVA: 0x37E3BC0
        public void Insert(){} // RVA: 0x37E3C20
        public void RemoveAt(){} // RVA: 0x37E3D50
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x37E3DB0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E3EC0
    }

    public class LimitedCapacityList`1 : VRC.Core.Networking
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.Tween.AnimationEvent> data; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x37E25A0
        public void get_Count(){} // RVA: 0x37E2650
        public void get_Item(){} // RVA: 0x2AC4300
        public void set_Item(){} // RVA: 0x2BCC680
        public void .ctor(){} // RVA: 0x37E2880 | overloaded x2
        public void get_Capacity(){} // RVA: 0x37E28C0
        public void set_Capacity(){} // RVA: 0x37E28F0
        public void get_Full(){} // RVA: 0x37E2A60
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x37E2A90
        public void Push(){} // RVA: 0x37E2B70
        public void PushAt(){} // RVA: 0x37E2C80
        public void Clear(){} // RVA: 0x2BCC740
        public void Contains(){} // RVA: 0x37E2D60
        public void CopyTo(){} // RVA: 0x2AC3D20
        public void Remove(){} // RVA: 0x37E2DE0
        public void GetEnumerator(){} // RVA: 0x37E2E10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37E2E10
        public void IndexOf(){} // RVA: 0x37E2EE0
        public void Insert(){} // RVA: 0x37E2F40
        public void RemoveAt(){} // RVA: 0x37E3080
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x37E30B0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E30F0
    }

    public class LimitedCapacityList`1 : VRC.Core.Networking
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.Tween.AnimatorEvent> data; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x37E25A0
        public void get_Count(){} // RVA: 0x37E2650
        public void get_Item(){} // RVA: 0x2AC4300
        public void set_Item(){} // RVA: 0x2BCC680
        public void .ctor(){} // RVA: 0x37E2880 | overloaded x2
        public void get_Capacity(){} // RVA: 0x37E28C0
        public void set_Capacity(){} // RVA: 0x37E28F0
        public void get_Full(){} // RVA: 0x37E2A60
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x37E2A90
        public void Push(){} // RVA: 0x37E2B70
        public void PushAt(){} // RVA: 0x37E2C80
        public void Clear(){} // RVA: 0x2BCC740
        public void Contains(){} // RVA: 0x37E2D60
        public void CopyTo(){} // RVA: 0x2AC3D20
        public void Remove(){} // RVA: 0x37E2DE0
        public void GetEnumerator(){} // RVA: 0x37E2E10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37E2E10
        public void IndexOf(){} // RVA: 0x37E2EE0
        public void Insert(){} // RVA: 0x37E2F40
        public void RemoveAt(){} // RVA: 0x37E3080
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x37E30B0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E30F0
    }

    public class LimitedCapacityList`1 : VRC.Core.Networking
    {
        public System.Collections.Generic.List`1<ÍÏÌÎÎÎÎÏÏÌÏÎÎÏÎÍÍÎÏÏÌÎÍ> data; // 0x10

        // ── Methods ──
        public void get_SerializationHistoryLength(){} // RVA: 0x37E25A0
        public void get_Count(){} // RVA: 0x37E2650
        public void get_Item(){} // RVA: 0x2AC4300
        public void set_Item(){} // RVA: 0x2BCC680
        public void .ctor(){} // RVA: 0x37E2880 | overloaded x2
        public void get_Capacity(){} // RVA: 0x37E28C0
        public void set_Capacity(){} // RVA: 0x37E28F0
        public void get_Full(){} // RVA: 0x37E2A60
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x37E2A90
        public void Push(){} // RVA: 0x37E2B70
        public void PushAt(){} // RVA: 0x37E2C80
        public void Clear(){} // RVA: 0x2BCC740
        public void Contains(){} // RVA: 0x37E2D60
        public void CopyTo(){} // RVA: 0x2AC3D20
        public void Remove(){} // RVA: 0x37E2DE0
        public void GetEnumerator(){} // RVA: 0x37E2E10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37E2E10
        public void IndexOf(){} // RVA: 0x37E2EE0
        public void Insert(){} // RVA: 0x37E2F40
        public void RemoveAt(){} // RVA: 0x37E3080
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x37E30B0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E30F0
    }

    public class NetworkUpdateRates
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x75C6B10
    }

    public class NumericExtensions
    {
        // ── Methods ──
        public void Clamp(){} // RVA: 0x283FA0
        public void SingleToInt(){} // RVA: 0x5D751C0
        public void IntToSingle(){} // RVA: 0x5D751D0
        public void IsBad(){} // RVA: 0x75D9AC0
        public void IsSafe(){} // RVA: 0x75D9AE0
        public void AlmostEquals(){} // RVA: 0x75D9B80
        public void CeilToInt(){} // RVA: 0x75D9C00
        public void FloorToInt(){} // RVA: 0x75D9C60
        public void FloatToHalf(){} // RVA: 0x75D9CC0
        public void HalfToFloat(){} // RVA: 0x75D9D50
        public void MaybeLerpTowards(){} // RVA: 0x75D9DC0
        public void RoundTo(){} // RVA: 0x75D9E60
    }

    public class PositionEvent
    {
        public byte <flags>k__BackingField; // 0x40
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T Velocity; // 0x48
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T Position; // 0x50
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT Rotation; // 0x58
        public bool WasSleeping; // 0x60
        public bool HasValue; // 0x61
        public int OwnerID; // 0x64

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75CE230 | overloaded x2
        public void DeepCopy(){} // RVA: 0x75CE420
        public void get_flags(){} // RVA: 0x398C00
        public void set_flags(){} // RVA: 0x398C10
        public void IsBad(){} // RVA: 0x75CE660
        public void Interpolate(){} // RVA: 0x75CE730
        public void Extrapolate(){} // RVA: 0x75CE900
        public void get_IsKinematic(){} // RVA: 0x75CEAD0
        public void set_IsKinematic(){} // RVA: 0x75CEAE0
        public void get_UseGravity(){} // RVA: 0x75CEB10
        public void set_UseGravity(){} // RVA: 0x75CEB20
        public void get_HeldInHand(){} // RVA: 0x75CEB50
        public void set_HeldInHand(){} // RVA: 0x75CEB60
        public void get_DiscontinuityCounter(){} // RVA: 0x75CEB70
        public void set_DiscontinuityCounter(){} // RVA: 0x75CEB80
        public void get_Discontinuity(){} // RVA: 0x3A5570
        public void set_Discontinuity(){} // RVA: 0x3A5580
        public void get_isHeld(){} // RVA: 0x75CEBA0
        public void IsDiscontinuousWith(){} // RVA: 0x75CEBB0
    }

    public class QuantizedSerialization
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x75D2850 | overloaded x11
        public void Deserialize(){} // RVA: 0x75D3430 | overloaded x15
        public void SerializeQuaternionAsNone(){} // RVA: 0x75D35C0 | overloaded x2
        public void SerializeVector3AsNone(){} // RVA: 0x75D3840 | overloaded x2
        public void DeserializeQuaternionFromNone(){} // RVA: 0x75D06C0 | overloaded x2
        public void DeserializeVector3FromNone(){} // RVA: 0x75D0840 | overloaded x2
        public void SerializeQuaternionAsHalfFloat(){} // RVA: 0x75D3D40 | overloaded x2
        public void SerializeVectorAsHalfFloat(){} // RVA: 0x75D3EE0 | overloaded x2
        public void DeserializeQuaternionFromHalfFloat(){} // RVA: 0x75D0C50 | overloaded x2
        public void DeserializeVectorFromHalfFloat(){} // RVA: 0x75D0D80 | overloaded x2
        public void SerializeQuaternionAsZeroToOneTenBitFloat(){} // RVA: 0x75D44C0 | overloaded x2
        public void SerializeVectorAsZeroToOneTenBitFloat(){} // RVA: 0x75D4720 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneTenBitFloat(){} // RVA: 0x75D4A90 | overloaded x2
        public void DeserializeVectorFromZeroToOneTenBitFloat(){} // RVA: 0x75D4C30 | overloaded x2
        public void SerializeQuaternionAsZeroToOneTwelveBitFloat(){} // RVA: 0x75D4F40 | overloaded x2
        public void SerializeVectorAsZeroToOneTwelveBitFloat(){} // RVA: 0x75D51E0 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneTwelveBitFloat(){} // RVA: 0x75D55C0 | overloaded x2
        public void DeserializeVectorFromZeroToOneTwelveBitFloat(){} // RVA: 0x75D5760 | overloaded x2
        public void SerializeQuaternionAsZeroToOneEightBitFloat(){} // RVA: 0x75D5AA0 | overloaded x2
        public void SerializeVectorAsZeroToOneEightBitFloat(){} // RVA: 0x75D5D00 | overloaded x2
        public void DeserializeQuaternionFromZeroToOneEightBitFloat(){} // RVA: 0x75D6050 | overloaded x2
        public void DeserializeVectorFromZeroToOneEightBitFloat(){} // RVA: 0x75D61F0 | overloaded x2
        public void SerializeFloatsAsNone(){} // RVA: 0x75D3A40
        public void SerializeFloatNotImplemented(){} // RVA: 0x75D3BB0
        public void DeserializeFloatsFromNone(){} // RVA: 0x75D3BF0
        public void DeserializeFloatNotImplemented(){} // RVA: 0x75D3D00
        public void SerializeFloatAsHalfFloat(){} // RVA: 0x75D4030
        public void DeserializeFloatFromHalfFloat(){} // RVA: 0x75D4120
        public void SerializeFloatsAsHalfFloat(){} // RVA: 0x75D4170
        public void DeserializeFloatsFromHalfFloat(){} // RVA: 0x75D4310
        public void FloatToTenBit(){} // RVA: 0x75D4470
        public void TenBitToFloat(){} // RVA: 0x75D44A0
        public void SerializeFloatsAsZeroToOneTenBitFloat(){} // RVA: 0x75D48C0
        public void DeserializeFloatsFromZeroToOneTenBitFloat(){} // RVA: 0x75D4D60
        public void FloatToTwelveBit(){} // RVA: 0x75D4EF0
        public void TwelveBitToFloat(){} // RVA: 0x75D4F20
        public void SerializeFloatsAsZeroToOneTwelveBitFloat(){} // RVA: 0x75D53B0
        public void DeserializeFloatsFromZeroToOneTwelveBitFloat(){} // RVA: 0x75D5890
        public void FloatToEightBit(){} // RVA: 0x75D5A50
        public void EightBitToFloat(){} // RVA: 0x75D5A80
        public void SerializeFloatsAsZeroToOneEightBitFloat(){} // RVA: 0x75D5E90
        public void DeserializeFloatsFromZeroToOneEightBitFloat(){} // RVA: 0x75D6320
        public void Clamp(){} // RVA: 0x75D6570 | overloaded x2
        public void ConvertPuppetFloatToByte(){} // RVA: 0x75D65E0
        public void ConvertByteToPuppetFloat(){} // RVA: 0x75D6760
        public void ConvertAngularVelocityFloatToByte(){} // RVA: 0x75D6790
        public void ConvertByteToAngularVelocityFloat(){} // RVA: 0x75D6840
        public void .cctor(){} // RVA: 0x75D6860
    }

    public class RoomNetworkProperty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SyncPhysicsCodec
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x75CEC10
        public void Decode(){} // RVA: 0x75CF000
        public void <Decode>g__getPosFloatAtOffset|3_0(){} // RVA: 0x75CF1F0
    }

    public class TimeProxy
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
        public void get_time(){} // RVA: 0x75C6BB0
        public void get_timeSinceEnteredRoom(){} // RVA: 0x75C6C10
        public void get_realtimeSinceStartup(){} // RVA: 0x75C6C70
        public void get_fixedTime(){} // RVA: 0x75C6CD0
        public void get_deltaTime(){} // RVA: 0x75C6D30
        public void get_smoothDeltaTime(){} // RVA: 0x75C6D90
        public void get_unixTime(){} // RVA: 0x75C6DF0
        public void get_renderedFrameCount(){} // RVA: 0x75C6E50
    }

    public class VRCPhotonEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x75C6EB0
    }

}