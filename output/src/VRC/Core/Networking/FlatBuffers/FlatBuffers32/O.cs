// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 12
// Methods: 147

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class ObjectBunch
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsObjectBunch(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Time(){} // RVA: 0x7613160
        public void get_Sender(){} // RVA: 0x76131B0
        public void get_Index(){} // RVA: 0x7607550
        public void Data(){} // RVA: 0x7614430
        public void get_DataLength(){} // RVA: 0x7607710
        public void GetDataBytes(){} // RVA: 0x76144B0
        public void GetDataArray(){} // RVA: 0x7614520
        public void CreateObjectBunch(){} // RVA: 0x7614570
        public void StartObjectBunch(){} // RVA: 0x7614700
        public void AddTime(){} // RVA: 0x7613690
        public void AddSender(){} // RVA: 0x7613700
        public void AddIndex(){} // RVA: 0x7607D80
        public void AddData(){} // RVA: 0x7607DF0
        public void CreateDataVector(){} // RVA: 0x760F8A0
        public void CreateDataVectorBlock(){} // RVA: 0x76148C0 | overloaded x3
        public void StartDataVector(){} // RVA: 0x760FBF0
        public void EndObjectBunch(){} // RVA: 0x7614980
        public void UnPack(){} // RVA: 0x76149D0
        public void UnPackTo(){} // RVA: 0x7614A80
        public void Pack(){} // RVA: 0x7614D30
    }

    public class ObjectBunchT
    {
        // ── Methods ──
        public void get_Time(){} // RVA: 0x32A5C0
        public void set_Time(){} // RVA: 0x2E00C0
        public void get_Sender(){} // RVA: 0x8ABED0
        public void set_Sender(){} // RVA: 0x8AC660
        public void get_Index(){} // RVA: 0x2F84E0
        public void set_Index(){} // RVA: 0x2F84F0
        public void get_Data(){} // RVA: 0x30B0C0
        public void set_Data(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x7614EA0
    }

    public class ObjectBunchVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7614F00
    }

    public class ObjectMetadata
    {
        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7606960
        public void AreCompatible(){} // RVA: 0x7606F50
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsObjectMetadata(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Is8Bit(){} // RVA: 0x76074B0
        public void get_DoNotPersist(){} // RVA: 0x7607500
        public void get_Code(){} // RVA: 0x7607550
        public void ComponentInfo(){} // RVA: 0x76075A0
        public void get_ComponentInfoLength(){} // RVA: 0x7607710
        public void Payload(){} // RVA: 0x7607780
        public void get_PayloadLength(){} // RVA: 0x76078F0
        public void get_InitialPath(){} // RVA: 0x7607960
        public void GetInitialPathBytes(){} // RVA: 0x76079F0
        public void GetInitialPathArray(){} // RVA: 0x7607A60
        public void CreateObjectMetadata(){} // RVA: 0x7607AB0
        public void StartObjectMetadata(){} // RVA: 0x7607C80
        public void AddIs8Bit(){} // RVA: 0x7607CA0
        public void AddDoNotPersist(){} // RVA: 0x7607D10
        public void AddCode(){} // RVA: 0x7607D80
        public void AddComponentInfo(){} // RVA: 0x7607DF0
        public void CreateComponentInfoVector(){} // RVA: 0x7607E30
        public void CreateComponentInfoVectorBlock(){} // RVA: 0x7608130 | overloaded x3
        public void StartComponentInfoVector(){} // RVA: 0x76081F0
        public void AddPayload(){} // RVA: 0x7608220
        public void CreatePayloadVector(){} // RVA: 0x7607E30
        public void CreatePayloadVectorBlock(){} // RVA: 0x76084A0 | overloaded x3
        public void StartPayloadVector(){} // RVA: 0x76081F0
        public void AddInitialPath(){} // RVA: 0x7608560
        public void EndObjectMetadata(){} // RVA: 0x76085A0
        public void UnPack(){} // RVA: 0x76085F0
        public void UnPackTo(){} // RVA: 0x7608660
        public void Pack(){} // RVA: 0x7608BF0
    }

    public class ObjectMetadataPair
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsObjectMetadataPair(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_ViewId(){} // RVA: 0x7613160
        public void get_Metadata(){} // RVA: 0x7615230
        public void CreateObjectMetadataPair(){} // RVA: 0x7615360
        public void StartObjectMetadataPair(){} // RVA: 0x7610510
        public void AddViewId(){} // RVA: 0x7613690
        public void AddMetadata(){} // RVA: 0x76107A0
        public void EndObjectMetadataPair(){} // RVA: 0x7615440
        public void UnPack(){} // RVA: 0x7615490
        public void UnPackTo(){} // RVA: 0x7615540
        public void Pack(){} // RVA: 0x76156E0
    }

    public class ObjectMetadataPairT
    {
        public object ViewId;
        public object ComponentIndex;

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x32A5C0
        public void set_ViewId(){} // RVA: 0x2E00C0
        public void get_Metadata(){} // RVA: 0x2E07C0
        public void set_Metadata(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x76157F0
    }

    public class ObjectMetadataPairVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7615850
    }

    public class ObjectMetadataT
    {
        // ── Methods ──
        public void ComputeHash(){} // RVA: 0x7608F60
        public void AreCompatible(){} // RVA: 0x7609440
        public void get_Is8Bit(){} // RVA: 0x3A75E0
        public void set_Is8Bit(){} // RVA: 0x3A75F0
        public void get_DoNotPersist(){} // RVA: 0x543460
        public void set_DoNotPersist(){} // RVA: 0x543470
        public void get_Code(){} // RVA: 0x195A940
        public void set_Code(){} // RVA: 0x195A9A0
        public void get_ComponentInfo(){} // RVA: 0x2E07C0
        public void set_ComponentInfo(){} // RVA: 0x343E80
        public void get_Payload(){} // RVA: 0x30B0C0
        public void set_Payload(){} // RVA: 0x30B0D0
        public void get_InitialPath(){} // RVA: 0x30B130
        public void set_InitialPath(){} // RVA: 0x2DEE90
        public void .ctor(){} // RVA: 0x7609710
    }

    public class ObjectMetadataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7615040
    }

    public class ObjectPool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsObjectPool(){} // RVA: 0x7607450 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7611850
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x760F670
        public void get_DataLength(){} // RVA: 0x760F6F0
        public void GetDataBytes(){} // RVA: 0x7611940
        public void GetDataArray(){} // RVA: 0x76119B0
        public void CreateObjectPool(){} // RVA: 0x7611A00
        public void StartObjectPool(){} // RVA: 0x760F310
        public void AddData(){} // RVA: 0x760F330
        public void CreateDataVector(){} // RVA: 0x760F8A0
        public void CreateDataVectorBlock(){} // RVA: 0x7611C20 | overloaded x3
        public void StartDataVector(){} // RVA: 0x760FBF0
        public void EndObjectPool(){} // RVA: 0x7611CE0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x7611D30
        public void UnPackTo(){} // RVA: 0x7611DE0
        public void Pack(){} // RVA: 0x7611FF0
    }

    public class ObjectPoolT
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
        public void DeserializeFromBinary(){} // RVA: 0x76120E0
        public void SerializeToBinary(){} // RVA: 0x7612190
    }

    public class ObjectPoolVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

}