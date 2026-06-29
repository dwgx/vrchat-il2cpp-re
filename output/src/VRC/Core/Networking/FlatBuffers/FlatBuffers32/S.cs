// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 129

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class SHA256 : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Bytes(){} // RVA: 0x9C0430
        public void CreateSHA256(){} // RVA: 0x825FE80
        public void UnPack(){} // RVA: 0x9C10F0
        public void UnPackTo(){} // RVA: 0x9C1100
        public void Pack(){} // RVA: 0x82600E0
    }

    public class SHA256T : Object
    {
        // ── Methods ──
        public void get_Bytes(){} // RVA: 0xB5DBF0
        public void set_Bytes(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x82601C0
    }

    public class SerializedObjects : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSerializedObjects(){} // RVA: 0x823F500
        public void VerifySerializedObjects(){} // RVA: 0x8259BA0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void ObjectsType(){} // RVA: 0x9BC8B0
        public void get_ObjectsTypeLength(){} // RVA: 0x9BCA70
        public void GetObjectsTypeBytes(){} // RVA: 0x9BEF00
        public void GetObjectsTypeArray(){} // RVA: 0x9BEF70
        public void Objects(){} // RVA: 0xA94080
        public void get_ObjectsLength(){} // RVA: 0x9BCC80
        public void CreateSerializedObjects(){} // RVA: 0x8259E30
        public void StartSerializedObjects(){} // RVA: 0x82488F0
        public void AddObjectsType(){} // RVA: 0x82476E0
        public void CreateObjectsTypeVector(){} // RVA: 0x8247C50
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x825A090
        public void StartObjectsTypeVector(){} // RVA: 0x8247FC0
        public void AddObjects(){} // RVA: 0x8248B80
        public void CreateObjectsVector(){} // RVA: 0x823FEE0
        public void CreateObjectsVectorBlock(){} // RVA: 0x825A2F0
        public void StartObjectsVector(){} // RVA: 0x82402C0
        public void EndSerializedObjects(){} // RVA: 0x825A3B0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9BF0A0
        public void UnPackTo(){} // RVA: 0x9BF0B0
        public void Pack(){} // RVA: 0x825ACF0
    }

    public class SerializedObjectsT : Object
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0xB5DBF0
        public void set_Objects(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x825B0F0
        public void SerializeToBinary(){} // RVA: 0x825B1A0
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

    public class SerializedTypeUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsSyncPlayable(){} // RVA: 0x8258930
        public void FromSyncPlayable(){} // RVA: 0x82589B0
        public void AsDataStorage(){} // RVA: 0x8258AB0
        public void FromDataStorage(){} // RVA: 0x8258B30
        public void AsUdon(){} // RVA: 0x8258C30
        public void FromUdon(){} // RVA: 0x8258CB0
        public void AsObjectPool(){} // RVA: 0x8258DB0
        public void FromObjectPool(){} // RVA: 0x8258E30
        public void AsPlayerStationStateData(){} // RVA: 0x8258F30
        public void FromPlayerStationStateData(){} // RVA: 0x8258FB0
        public void AsPhysBoneRecorder(){} // RVA: 0x82590B0
        public void FromPhysBoneRecorder(){} // RVA: 0x8259130
        public void AsPlayerData(){} // RVA: 0x8259230
        public void FromPlayerData(){} // RVA: 0x82592B0
        public void Pack(){} // RVA: 0x82593B0
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8259840
    }

    public class SparseSerializedObjects : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x823F500
        public void VerifySparseSerializedObjects(){} // RVA: 0x8260250
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Objects(){} // RVA: 0x9C11D0
        public void Bitmap(){} // RVA: 0x9C1200
        public void get_BitmapLength(){} // RVA: 0x9BCC80
        public void GetBitmapBytes(){} // RVA: 0x9C1210
        public void GetBitmapArray(){} // RVA: 0x9C1280
        public void CreateSparseSerializedObjects(){} // RVA: 0x82605C0
        public void StartSparseSerializedObjects(){} // RVA: 0x82488F0
        public void AddObjects(){} // RVA: 0x82476E0
        public void AddBitmap(){} // RVA: 0x8248B80
        public void CreateBitmapVector(){} // RVA: 0x8247C50
        public void CreateBitmapVectorBlock(){} // RVA: 0x8260810
        public void StartBitmapVector(){} // RVA: 0x8247FC0
        public void EndSparseSerializedObjects(){} // RVA: 0x82608D0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9C12D0
        public void UnPackTo(){} // RVA: 0x9C12E0
        public void Pack(){} // RVA: 0x8260D50
    }

    public class SparseSerializedObjectsT : Object
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0xB5DBF0
        public void set_Objects(){} // RVA: 0xB44D60
        public void get_Bitmap(){} // RVA: 0xB465B0
        public void set_Bitmap(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8225A50
        public void DeserializeFromBinary(){} // RVA: 0x8260E10
        public void SerializeToBinary(){} // RVA: 0x8260EC0
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8261040
    }

    public class SyncPlayable : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSyncPlayable(){} // RVA: 0x823F500
        public void VerifySyncPlayable(){} // RVA: 0x8261170
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_StageParamsOffset(){} // RVA: 0x9BD010
        public void get_Puppet(){} // RVA: 0x9C13B0
        public void get_AvatarDiscriminator(){} // RVA: 0x9C13E0
        public void CreateSyncPlayable(){} // RVA: 0x82613D0
        public void StartSyncPlayable(){} // RVA: 0x824E540
        public void AddStageParamsOffset(){} // RVA: 0x824BB30
        public void AddPuppet(){} // RVA: 0x8243A10
        public void AddAvatarDiscriminator(){} // RVA: 0x8261520
        public void EndSyncPlayable(){} // RVA: 0x8261590
        public void FinishSyncPlayableBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9C1430
        public void UnPackTo(){} // RVA: 0x9C1440
        public void Pack(){} // RVA: 0x82618C0
    }

    public class SyncPlayableT : Object
    {
        // ── Methods ──
        public void get_StageParamsOffset(){} // RVA: 0xB8F8F0
        public void set_StageParamsOffset(){} // RVA: 0xB460A0
        public void get_Puppet(){} // RVA: 0xB465B0
        public void set_Puppet(){} // RVA: 0xBA9BA0
        public void get_AvatarDiscriminator(){} // RVA: 0x4FEF950
        public void set_AvatarDiscriminator(){} // RVA: 0x653B850
        public void .ctor(){} // RVA: 0x8261A20
        public void DeserializeFromBinary(){} // RVA: 0x8261AE0
        public void SerializeToBinary(){} // RVA: 0x8261B90
    }

    public class SyncPlayableVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8261C90
    }

}