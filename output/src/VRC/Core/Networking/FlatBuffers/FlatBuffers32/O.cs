// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 12
// Methods: 147

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class ObjectBunch : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x218
        public object field_2; // 0x219
        public object field_3; // 0x21A
        public object field_4; // 0x21B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsObjectBunch(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Time(){} // RVA: 0x7FFE881501B0
        public void get_Sender(){} // RVA: 0x7FFE88150200
        public void get_Index(){} // RVA: 0x7FFE881445A0
        public void Data(){} // RVA: 0x7FFE88151480
        public void get_DataLength(){} // RVA: 0x7FFE88144760
        public void GetDataBytes(){} // RVA: 0x7FFE88151500
        public void GetDataArray(){} // RVA: 0x7FFE88151570
        public void CreateObjectBunch(){} // RVA: 0x7FFE881515C0
        public void StartObjectBunch(){} // RVA: 0x7FFE88151750
        public void AddTime(){} // RVA: 0x7FFE881506E0
        public void AddSender(){} // RVA: 0x7FFE88150750
        public void AddIndex(){} // RVA: 0x7FFE88144DD0
        public void AddData(){} // RVA: 0x7FFE88144E40
        public void CreateDataVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFE88151910 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFE8814CC40
        public void EndObjectBunch(){} // RVA: 0x7FFE881519D0
        public void UnPack(){} // RVA: 0x7FFE88151A20
        public void UnPackTo(){} // RVA: 0x7FFE88151AD0
        public void Pack(){} // RVA: 0x7FFE88151D80
    }

    public class ObjectBunchT : Object
    {
        public int _time; // 0x10
        public int _sender; // 0x14
        public byte _index; // 0x18
        public System.Collections.Generic.List`1<byte> _data; // 0x20

        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFE811485C0
        public void set_Time(){} // RVA: 0x7FFE810FE0C0
        public void get_Sender(){} // RVA: 0x7FFE8164B230
        public void set_Sender(){} // RVA: 0x7FFE8164E0F0
        public void get_Index(){} // RVA: 0x7FFE811164E0
        public void set_Index(){} // RVA: 0x7FFE811164F0
        public void get_Data(){} // RVA: 0x7FFE811290C0
        public void set_Data(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE88151EF0
    }

    public class ObjectBunchVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88151F50
    }

    public class ObjectMetadata : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x1BE
        public object field_2; // 0x1BF
        public object field_3; // 0x1C0
        public object field_4; // 0x1C1
        public object field_5; // 0x1C2
        public object field_6; // 0x1C3

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFE881439B0
        public void AreCompatible(){} // RVA: 0x7FFE88143FA0
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsObjectMetadata(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Is8Bit(){} // RVA: 0x7FFE88144500
        public void get_DoNotPersist(){} // RVA: 0x7FFE88144550
        public void get_Code(){} // RVA: 0x7FFE881445A0
        public void ComponentInfo(){} // RVA: 0x7FFE881445F0
        public void get_ComponentInfoLength(){} // RVA: 0x7FFE88144760
        public void Payload(){} // RVA: 0x7FFE881447D0
        public void get_PayloadLength(){} // RVA: 0x7FFE88144940
        public void get_InitialPath(){} // RVA: 0x7FFE881449B0
        public void GetInitialPathBytes(){} // RVA: 0x7FFE88144A40
        public void GetInitialPathArray(){} // RVA: 0x7FFE88144AB0
        public void CreateObjectMetadata(){} // RVA: 0x7FFE88144B00
        public void StartObjectMetadata(){} // RVA: 0x7FFE88144CD0
        public void AddIs8Bit(){} // RVA: 0x7FFE88144CF0
        public void AddDoNotPersist(){} // RVA: 0x7FFE88144D60
        public void AddCode(){} // RVA: 0x7FFE88144DD0
        public void AddComponentInfo(){} // RVA: 0x7FFE88144E40
        public void CreateComponentInfoVector(){} // RVA: 0x7FFE88144E80
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7FFE88145180 | overloaded x3
        public void StartComponentInfoVector(){} // RVA: 0x7FFE88145240
        public void AddPayload(){} // RVA: 0x7FFE88145270
        public void CreatePayloadVector(){} // RVA: 0x7FFE88144E80
        public void CreatePayloadVectorBlock(){} // RVA: 0x7FFE881454F0 | overloaded x3
        public void StartPayloadVector(){} // RVA: 0x7FFE88145240
        public void AddInitialPath(){} // RVA: 0x7FFE881455B0
        public void EndObjectMetadata(){} // RVA: 0x7FFE881455F0
        public void UnPack(){} // RVA: 0x7FFE88145640
        public void UnPackTo(){} // RVA: 0x7FFE881456B0
        public void Pack(){} // RVA: 0x7FFE88145C40
    }

    public class ObjectMetadataPair : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x221
        public object field_2; // 0x222

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsObjectMetadataPair(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_ViewId(){} // RVA: 0x7FFE881501B0
        public void get_Metadata(){} // RVA: 0x7FFE88152280
        public void CreateObjectMetadataPair(){} // RVA: 0x7FFE881523B0
        public void StartObjectMetadataPair(){} // RVA: 0x7FFE8814D560
        public void AddViewId(){} // RVA: 0x7FFE881506E0
        public void AddMetadata(){} // RVA: 0x7FFE8814D7F0
        public void EndObjectMetadataPair(){} // RVA: 0x7FFE88152490
        public void UnPack(){} // RVA: 0x7FFE881524E0
        public void UnPackTo(){} // RVA: 0x7FFE88152590
        public void Pack(){} // RVA: 0x7FFE88152730
    }

    public class ObjectMetadataPairT : Object
    {
        public int _viewId; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataT _metadata; // 0x18

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7FFE811485C0
        public void set_ViewId(){} // RVA: 0x7FFE810FE0C0
        public void get_Metadata(){} // RVA: 0x7FFE810FE7C0
        public void set_Metadata(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE88152840
    }

    public class ObjectMetadataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE881528A0
    }

    public class ObjectMetadataT : Object
    {
        public bool _is8Bit; // 0x10
        public bool _doNotPersist; // 0x11
        public byte _code; // 0x12
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ComponentInfoT> _componentInfo; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectBunchT> _payload; // 0x20
        public string _initialPath; // 0x28

        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFE88145FB0
        public void AreCompatible(){} // RVA: 0x7FFE88146490
        public void get_Is8Bit(){} // RVA: 0x7FFE811C55E0
        public void set_Is8Bit(){} // RVA: 0x7FFE811C55F0
        public void get_DoNotPersist(){} // RVA: 0x7FFE81346E30
        public void set_DoNotPersist(){} // RVA: 0x7FFE813471A0
        public void get_Code(){} // RVA: 0x7FFE826E3520
        public void set_Code(){} // RVA: 0x7FFE826E34A0
        public void get_ComponentInfo(){} // RVA: 0x7FFE810FE7C0
        public void set_ComponentInfo(){} // RVA: 0x7FFE81161E80
        public void get_Payload(){} // RVA: 0x7FFE811290C0
        public void set_Payload(){} // RVA: 0x7FFE811290D0
        public void get_InitialPath(){} // RVA: 0x7FFE81129130
        public void set_InitialPath(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE88146760
    }

    public class ObjectMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88152090
    }

    public class ObjectPool : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x205

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFE8814E8A0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE8814C6C0
        public void get_DataLength(){} // RVA: 0x7FFE8814C740
        public void GetDataBytes(){} // RVA: 0x7FFE8814E990
        public void GetDataArray(){} // RVA: 0x7FFE8814EA00
        public void CreateObjectPool(){} // RVA: 0x7FFE8814EA50
        public void StartObjectPool(){} // RVA: 0x7FFE8814C360
        public void AddData(){} // RVA: 0x7FFE8814C380
        public void CreateDataVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFE8814EC70 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFE8814CC40
        public void EndObjectPool(){} // RVA: 0x7FFE8814ED30
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE8814ED80
        public void UnPackTo(){} // RVA: 0x7FFE8814EE30
        public void Pack(){} // RVA: 0x7FFE8814F040
    }

    public class ObjectPoolT : Object
    {
        public System.Collections.Generic.List`1<byte> _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE8814F130
        public void SerializeToBinary(){} // RVA: 0x7FFE8814F1E0
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

}