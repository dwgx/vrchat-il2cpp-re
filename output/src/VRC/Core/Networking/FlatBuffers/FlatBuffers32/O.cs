// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 12
// Methods: 147

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class ObjectBunch
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsObjectBunch(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Time(){} // RVA: 0x7FFAFA0C3160
        public void get_Sender(){} // RVA: 0x7FFAFA0C31B0
        public void get_Index(){} // RVA: 0x7FFAFA0B7550
        public void Data(){} // RVA: 0x7FFAFA0C4430
        public void get_DataLength(){} // RVA: 0x7FFAFA0B7710
        public void GetDataBytes(){} // RVA: 0x7FFAFA0C44B0
        public void GetDataArray(){} // RVA: 0x7FFAFA0C4520
        public void CreateObjectBunch(){} // RVA: 0x7FFAFA0C4570
        public void StartObjectBunch(){} // RVA: 0x7FFAFA0C4700
        public void AddTime(){} // RVA: 0x7FFAFA0C3690
        public void AddSender(){} // RVA: 0x7FFAFA0C3700
        public void AddIndex(){} // RVA: 0x7FFAFA0B7D80
        public void AddData(){} // RVA: 0x7FFAFA0B7DF0
        public void CreateDataVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAFA0C48C0 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAFA0BFBF0
        public void EndObjectBunch(){} // RVA: 0x7FFAFA0C4980
        public void UnPack(){} // RVA: 0x7FFAFA0C49D0
        public void UnPackTo(){} // RVA: 0x7FFAFA0C4A80
        public void Pack(){} // RVA: 0x7FFAFA0C4D30
    }

    public class ObjectBunchT
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x7FFAF2DDA5C0
        public void set_Time(){} // RVA: 0x7FFAF2D900C0
        public void get_Sender(){} // RVA: 0x7FFAF335BED0
        public void set_Sender(){} // RVA: 0x7FFAF335C660
        public void get_Index(){} // RVA: 0x7FFAF2DA84E0
        public void set_Index(){} // RVA: 0x7FFAF2DA84F0
        public void get_Data(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Data(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAFA0C4EA0
    }

    public class ObjectBunchVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C4F00
    }

    public class ObjectMetadata
    {
        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFAFA0B6960
        public void AreCompatible(){} // RVA: 0x7FFAFA0B6F50
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsObjectMetadata(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Is8Bit(){} // RVA: 0x7FFAFA0B74B0
        public void get_DoNotPersist(){} // RVA: 0x7FFAFA0B7500
        public void get_Code(){} // RVA: 0x7FFAFA0B7550
        public void ComponentInfo(){} // RVA: 0x7FFAFA0B75A0
        public void get_ComponentInfoLength(){} // RVA: 0x7FFAFA0B7710
        public void Payload(){} // RVA: 0x7FFAFA0B7780
        public void get_PayloadLength(){} // RVA: 0x7FFAFA0B78F0
        public void get_InitialPath(){} // RVA: 0x7FFAFA0B7960
        public void GetInitialPathBytes(){} // RVA: 0x7FFAFA0B79F0
        public void GetInitialPathArray(){} // RVA: 0x7FFAFA0B7A60
        public void CreateObjectMetadata(){} // RVA: 0x7FFAFA0B7AB0
        public void StartObjectMetadata(){} // RVA: 0x7FFAFA0B7C80
        public void AddIs8Bit(){} // RVA: 0x7FFAFA0B7CA0
        public void AddDoNotPersist(){} // RVA: 0x7FFAFA0B7D10
        public void AddCode(){} // RVA: 0x7FFAFA0B7D80
        public void AddComponentInfo(){} // RVA: 0x7FFAFA0B7DF0
        public void CreateComponentInfoVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7FFAFA0B8130 | overloaded x3
        public void StartComponentInfoVector(){} // RVA: 0x7FFAFA0B81F0
        public void AddPayload(){} // RVA: 0x7FFAFA0B8220
        public void CreatePayloadVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreatePayloadVectorBlock(){} // RVA: 0x7FFAFA0B84A0 | overloaded x3
        public void StartPayloadVector(){} // RVA: 0x7FFAFA0B81F0
        public void AddInitialPath(){} // RVA: 0x7FFAFA0B8560
        public void EndObjectMetadata(){} // RVA: 0x7FFAFA0B85A0
        public void UnPack(){} // RVA: 0x7FFAFA0B85F0
        public void UnPackTo(){} // RVA: 0x7FFAFA0B8660
        public void Pack(){} // RVA: 0x7FFAFA0B8BF0
    }

    public class ObjectMetadataPair
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsObjectMetadataPair(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_ViewId(){} // RVA: 0x7FFAFA0C3160
        public void get_Metadata(){} // RVA: 0x7FFAFA0C5230
        public void CreateObjectMetadataPair(){} // RVA: 0x7FFAFA0C5360
        public void StartObjectMetadataPair(){} // RVA: 0x7FFAFA0C0510
        public void AddViewId(){} // RVA: 0x7FFAFA0C3690
        public void AddMetadata(){} // RVA: 0x7FFAFA0C07A0
        public void EndObjectMetadataPair(){} // RVA: 0x7FFAFA0C5440
        public void UnPack(){} // RVA: 0x7FFAFA0C5490
        public void UnPackTo(){} // RVA: 0x7FFAFA0C5540
        public void Pack(){} // RVA: 0x7FFAFA0C56E0
    }

    public class ObjectMetadataPairT
    {
        public object ViewId;
        public object ComponentIndex;

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7FFAF2DDA5C0
        public void set_ViewId(){} // RVA: 0x7FFAF2D900C0
        public void get_Metadata(){} // RVA: 0x7FFAF2D907C0
        public void set_Metadata(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA0C57F0
    }

    public class ObjectMetadataPairVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C5850
    }

    public class ObjectMetadataT
    {
        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7FFAFA0B8F60
        public void AreCompatible(){} // RVA: 0x7FFAFA0B9440
        public void get_Is8Bit(){} // RVA: 0x7FFAF2E575E0
        public void set_Is8Bit(){} // RVA: 0x7FFAF2E575F0
        public void get_DoNotPersist(){} // RVA: 0x7FFAF2FF3460
        public void set_DoNotPersist(){} // RVA: 0x7FFAF2FF3470
        public void get_Code(){} // RVA: 0x7FFAF440A940
        public void set_Code(){} // RVA: 0x7FFAF440A9A0
        public void get_ComponentInfo(){} // RVA: 0x7FFAF2D907C0
        public void set_ComponentInfo(){} // RVA: 0x7FFAF2DF3E80
        public void get_Payload(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Payload(){} // RVA: 0x7FFAF2DBB0D0
        public void get_InitialPath(){} // RVA: 0x7FFAF2DBB130
        public void set_InitialPath(){} // RVA: 0x7FFAF2D8EE90
        public void .ctor(){} // RVA: 0x7FFAFA0B9710
    }

    public class ObjectMetadataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C5040
    }

    public class ObjectPool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFAFA0C1850
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Data(){} // RVA: 0x7FFAFA0BF670
        public void get_DataLength(){} // RVA: 0x7FFAFA0BF6F0
        public void GetDataBytes(){} // RVA: 0x7FFAFA0C1940
        public void GetDataArray(){} // RVA: 0x7FFAFA0C19B0
        public void CreateObjectPool(){} // RVA: 0x7FFAFA0C1A00
        public void StartObjectPool(){} // RVA: 0x7FFAFA0BF310
        public void AddData(){} // RVA: 0x7FFAFA0BF330
        public void CreateDataVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAFA0C1C20 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAFA0BFBF0
        public void EndObjectPool(){} // RVA: 0x7FFAFA0C1CE0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFAFA0C0A90
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFAFA0C0AF0
        public void UnPack(){} // RVA: 0x7FFAFA0C1D30
        public void UnPackTo(){} // RVA: 0x7FFAFA0C1DE0
        public void Pack(){} // RVA: 0x7FFAFA0C1FF0
    }

    public class ObjectPoolT
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2DA8380
        public void set_Data(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0C20E0
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0C2190
    }

    public class ObjectPoolVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C00F0
    }

}