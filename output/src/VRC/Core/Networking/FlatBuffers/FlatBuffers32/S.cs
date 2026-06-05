// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 138

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class SHA256
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Bytes(){} // RVA: 0x7FFAFA0D4F80
        public void CreateSHA256(){} // RVA: 0x7FFAFA0D6F30
        public void UnPack(){} // RVA: 0x7FFAFA0D7000
        public void UnPackTo(){} // RVA: 0x7FFAFA0D7070
        public void Pack(){} // RVA: 0x7FFAFA0D7170
    }

    public class SHA256T
    {
        public object Bytes;

        // ── Methods ──
        public void get_Bytes(){} // RVA: 0x7FFAF2DA8380
        public void set_Bytes(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA0D7250
    }

    public class SerializedObjects
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFAFA0D0DA0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void ObjectsType(){} // RVA: 0x7FFAFA0BF670
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFAFA0BF6F0
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFAFA0D0E90
        public void GetObjectsTypeArray(){} // RVA: 0x7FFAFA0D0F00
        public void Objects(){} // RVA: 0x7FFAF2D33FA0
        public void get_ObjectsLength(){} // RVA: 0x7FFAFA0C03F0
        public void CreateSerializedObjects(){} // RVA: 0x7FFAFA0D1030
        public void StartSerializedObjects(){} // RVA: 0x7FFAFA0C0510
        public void AddObjectsType(){} // RVA: 0x7FFAFA0BF330
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFAFA0D1290 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFAFA0BFBF0
        public void AddObjects(){} // RVA: 0x7FFAFA0C07A0
        public void CreateObjectsVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFAFA0D14F0 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndSerializedObjects(){} // RVA: 0x7FFAFA0D15B0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFAFA0C0A90
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFAFA0C0AF0
        public void UnPack(){} // RVA: 0x7FFAFA0D1600
        public void UnPackTo(){} // RVA: 0x7FFAFA0D16B0
        public void Pack(){} // RVA: 0x7FFAFA0D1EE0
    }

    public class SerializedObjectsT
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFAF2DA8380
        public void set_Objects(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0D2290
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0D2340
    }

    public class SerializedObjectsVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C00F0
    }

    public class SerializedTypeUnion
    {
        public object Type;
        public object Value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void set_Type(){} // RVA: 0x7FFAF2E575F0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA08FAD0
        public void As(){} // RVA: 0x7FFAF2D33FA0
        public void AsSyncPlayable(){} // RVA: 0x7FFAFA0CFE40
        public void FromSyncPlayable(){} // RVA: 0x7FFAFA0CFE80
        public void AsDataStorage(){} // RVA: 0x7FFAFA0CFF80
        public void FromDataStorage(){} // RVA: 0x7FFAFA0CFFC0
        public void AsUdon(){} // RVA: 0x7FFAFA0D00C0
        public void FromUdon(){} // RVA: 0x7FFAFA0D0100
        public void AsObjectPool(){} // RVA: 0x7FFAFA0D0200
        public void FromObjectPool(){} // RVA: 0x7FFAFA0D0240
        public void AsPlayerStationStateData(){} // RVA: 0x7FFAFA0D0340
        public void FromPlayerStationStateData(){} // RVA: 0x7FFAFA0D0380
        public void AsPhysBoneRecorder(){} // RVA: 0x7FFAFA0D0480
        public void FromPhysBoneRecorder(){} // RVA: 0x7FFAFA0D04C0
        public void AsPlayerData(){} // RVA: 0x7FFAFA0D05C0
        public void FromPlayerData(){} // RVA: 0x7FFAFA0D0600
        public void Pack(){} // RVA: 0x7FFAFA0D0700
    }

    public class SerializedTypeVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0D0A50
    }

    public class SparseSerializedObjects
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFAFA0D72E0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Objects(){} // RVA: 0x7FFAFA0D73D0
        public void Bitmap(){} // RVA: 0x7FFAFA0D7500
        public void get_BitmapLength(){} // RVA: 0x7FFAFA0C03F0
        public void GetBitmapBytes(){} // RVA: 0x7FFAFA0D7580
        public void GetBitmapArray(){} // RVA: 0x7FFAFA0D75F0
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFAFA0D7640
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFAFA0C0510
        public void AddObjects(){} // RVA: 0x7FFAFA0BF330
        public void AddBitmap(){} // RVA: 0x7FFAFA0C07A0
        public void CreateBitmapVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFAFA0D7890 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFAFA0BFBF0
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFAFA0D7950
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFAFA0C0A90
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFAFA0C0AF0
        public void UnPack(){} // RVA: 0x7FFAFA0D79A0
        public void UnPackTo(){} // RVA: 0x7FFAFA0D7AB0
        public void Pack(){} // RVA: 0x7FFAFA0D7DD0
    }

    public class SparseSerializedObjectsT
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFAF2DA8380
        public void set_Objects(){} // RVA: 0x7FFAF2D8EE30
        public void get_Bitmap(){} // RVA: 0x7FFAF2D907C0
        public void set_Bitmap(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA09EF50
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0D7E90
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0D7F40
    }

    public class SparseSerializedObjectsVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0D80C0
    }

    public class SyncPlayable
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsSyncPlayable(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void VerifySyncPlayable(){} // RVA: 0x7FFAFA0D81F0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_StageParamsOffset(){} // RVA: 0x7FFAFA0C3160
        public void get_Puppet(){} // RVA: 0x7FFAFA0D82E0
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFAFA0D83F0
        public void CreateSyncPlayable(){} // RVA: 0x7FFAFA0D8440
        public void StartSyncPlayable(){} // RVA: 0x7FFAFA0C6050
        public void AddStageParamsOffset(){} // RVA: 0x7FFAFA0C3690
        public void AddPuppet(){} // RVA: 0x7FFAFA0BB8D0
        public void AddAvatarDiscriminator(){} // RVA: 0x7FFAFA0D8590
        public void EndSyncPlayable(){} // RVA: 0x7FFAFA0D8600
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7FFAFA0C0A90
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7FFAFA0C0AF0
        public void UnPack(){} // RVA: 0x7FFAFA0D8650
        public void UnPackTo(){} // RVA: 0x7FFAFA0D8750
        public void Pack(){} // RVA: 0x7FFAFA0D8930
    }

    public class SyncPlayableT
    {
        // ── Methods ──
        public void get_StageParamsOffset(){} // RVA: 0x7FFAF2DDA5C0
        public void set_StageParamsOffset(){} // RVA: 0x7FFAF2D900C0
        public void get_Puppet(){} // RVA: 0x7FFAF2D907C0
        public void set_Puppet(){} // RVA: 0x7FFAF2DF3E80
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFAF6F64370
        public void set_AvatarDiscriminator(){} // RVA: 0x7FFAF8570F20
        public void .ctor(){} // RVA: 0x7FFAFA0D8A90
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0D8B50
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0D8C00
    }

    public class SyncPlayableVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0D8D00
    }

}