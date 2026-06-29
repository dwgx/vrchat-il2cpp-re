// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 10
// Methods: 70

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class SafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__ok(){} // RVA: 0x7AD8C9D90
        public void absl_Status__raw_code(){} // RVA: 0x7AD8C9E10
        public void mp_ImageFrame__Format(){} // RVA: 0x7AD8C9E90
        public void mp_ImageFrame__Width(){} // RVA: 0x7AD8C9F10
        public void mp_ImageFrame__Height(){} // RVA: 0x7AD8C9F90
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x7AD8CA010
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x7AD8CA090
        public void mp_Image__width(){} // RVA: 0x7AD8CA110
        public void mp_Image__height(){} // RVA: 0x7AD8CA190
        public void mp_Image__step(){} // RVA: 0x7AD8CA210
        public void mp_Image__image_format(){} // RVA: 0x7AD8CA290
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x7AD8CA310
        public void mp_Packet__IsEmpty(){} // RVA: 0x7AD8CA390
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x7AD8CA410
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x7AD8CA490
        public void mp_SharedGlContext__get(){} // RVA: 0x7AD8CA510
        public void mp_GlSyncToken__get(){} // RVA: 0x7AD8CA590
        public void mp_SharedGpuResources__get(){} // RVA: 0x7AD8CA610
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x7AD8CA690
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x7AD8CA720
    }

    public class SerializedProto : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A7E29F50
        public void Deserialize(){} // RVA: 0x7A8051B10
        public void WriteTo(){} // RVA: 0x7A8051B10
    }

    public class SerializedProtoVector : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A7E29FB0
        public void Deserialize(){} // RVA: 0x7A7E18890
        public void WriteTo(){} // RVA: 0x7A7E06320
    }

    public class SharedPtrHandle : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBD5A90
        public void Get(){} // RVA: 0x7A7E00680
    }

    public class Status : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBD5A90
        public void DeleteMpPtr(){} // RVA: 0x7AD8C6020
        public void UnsafeAssertOk(){} // RVA: 0x7AD8C6080
        public void AssertOk(){} // RVA: 0x7AD8C61A0
        public void Ok(){} // RVA: 0x7AD8C62C0
        public void Code(){} // RVA: 0x7AD8C6380
        public void RawCode(){} // RVA: 0x7AD8C6380
        public void ToString(){} // RVA: 0x7AD8C64B0
    }

    public class StatusArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E2A150
        public void Ok(){} // RVA: 0x7AD8C5E60
        public void InvalidArgument(){} // RVA: 0x7AD8C5ED0
        public void NotFound(){} // RVA: 0x7AD8C5F40
        public void Internal(){} // RVA: 0x7AD8C5FB0
    }

    public class StatusHandlerConfig : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD917650
        public void get_Descriptor(){} // RVA: 0x7AD9176B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD917770
        public void .ctor(){} // RVA: 0x7AD9179A0
        public void Clone(){} // RVA: 0x7AD917C70
        public void get_StatusHandler(){} // RVA: 0x7AD917CD0
        public void set_StatusHandler(){} // RVA: 0x7AD917D40
        public void get_HasStatusHandler(){} // RVA: 0x7A9B3D890
        public void ClearStatusHandler(){} // RVA: 0x7AA4BE520
        public void get_InputSidePacket(){} // RVA: 0x7A81052C0
        public void get_ExternalInput(){} // RVA: 0x7A8105330
        public void get_Options(){} // RVA: 0x7A83F69F0
        public void set_Options(){} // RVA: 0x7A8105A90
        public void Equals(){} // RVA: 0x7AD917EA0
        public void GetHashCode(){} // RVA: 0x7AD918020
        public void ToString(){} // RVA: 0x7AD918110
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD918160
        public void CalculateSize(){} // RVA: 0x7AD9182C0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD918650
        public void .cctor(){} // RVA: 0x7AD918830
    }

    public class StatusHandlerReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD916FA0
        public void .cctor(){} // RVA: 0x7AD917000
    }

    public class StdString : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8C23F0
        public void DeleteMpPtr(){} // RVA: 0x7AD8C2560
        public void Swap(){} // RVA: 0x7AD8C2620
    }

    public class StreamHandlerReflection : Object
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7AD918C70
        public void .cctor(){} // RVA: 0x7AD918CD0
    }

}