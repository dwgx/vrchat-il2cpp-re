// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 129

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class SHA256 : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Bytes(){} // RVA: 0x7A7F18B80
        public void CreateSHA256(){} // RVA: 0x7AF405BF0
        public void UnPack(){} // RVA: 0x7A7F191C0
        public void UnPackTo(){} // RVA: 0x7A7F191D0
        public void Pack(){} // RVA: 0x7AF405E50
    }

    public class SHA256T : Object
    {
        // ── Methods ──
        public void get_Bytes(){} // RVA: 0x7A80F2570
        public void set_Bytes(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF405F30
    }

    public class SerializedObjects : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7AF3E5C00
        public void VerifySerializedObjects(){} // RVA: 0x7AF3FF910
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void ObjectsType(){} // RVA: 0x7A7F166E0
        public void get_ObjectsTypeLength(){} // RVA: 0x7A7F167E0
        public void GetObjectsTypeBytes(){} // RVA: 0x7A7F18230
        public void GetObjectsTypeArray(){} // RVA: 0x7A7F182A0
        public void Objects(){} // RVA: 0x7A8051B10
        public void get_ObjectsLength(){} // RVA: 0x7A7F169F0
        public void CreateSerializedObjects(){} // RVA: 0x7AF3FFBA0
        public void StartSerializedObjects(){} // RVA: 0x7AF3EEE20
        public void AddObjectsType(){} // RVA: 0x7AF3EDC10
        public void CreateObjectsTypeVector(){} // RVA: 0x7AF3EE180
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7AF3FFE00
        public void StartObjectsTypeVector(){} // RVA: 0x7AF3EE4F0
        public void AddObjects(){} // RVA: 0x7AF3EF0B0
        public void CreateObjectsVector(){} // RVA: 0x7AF3E65E0
        public void CreateObjectsVectorBlock(){} // RVA: 0x7AF400060
        public void StartObjectsVector(){} // RVA: 0x7AF3E69C0
        public void EndSerializedObjects(){} // RVA: 0x7AF400120
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7AF3EF3A0
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7AF3EF400
        public void UnPack(){} // RVA: 0x7A7F183D0
        public void UnPackTo(){} // RVA: 0x7A7F183E0
        public void Pack(){} // RVA: 0x7AF400A60
    }

    public class SerializedObjectsT : Object
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7A80F2570
        public void set_Objects(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
        public void DeserializeFromBinary(){} // RVA: 0x7AF400E60
        public void SerializeToBinary(){} // RVA: 0x7AF400F10
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3EEA00
    }

    public class SerializedTypeUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsSyncPlayable(){} // RVA: 0x7AF3FE9A0
        public void FromSyncPlayable(){} // RVA: 0x7AF3FE9E0
        public void AsDataStorage(){} // RVA: 0x7AF3FEAE0
        public void FromDataStorage(){} // RVA: 0x7AF3FEB20
        public void AsUdon(){} // RVA: 0x7AF3FEC20
        public void FromUdon(){} // RVA: 0x7AF3FEC60
        public void AsObjectPool(){} // RVA: 0x7AF3FED60
        public void FromObjectPool(){} // RVA: 0x7AF3FEDA0
        public void AsPlayerStationStateData(){} // RVA: 0x7AF3FEEA0
        public void FromPlayerStationStateData(){} // RVA: 0x7AF3FEEE0
        public void AsPhysBoneRecorder(){} // RVA: 0x7AF3FEFE0
        public void FromPhysBoneRecorder(){} // RVA: 0x7AF3FF020
        public void AsPlayerData(){} // RVA: 0x7AF3FF120
        public void FromPlayerData(){} // RVA: 0x7AF3FF160
        public void Pack(){} // RVA: 0x7AF3FF260
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3FF5B0
    }

    public class SparseSerializedObjects : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7AF3E5C00
        public void VerifySparseSerializedObjects(){} // RVA: 0x7AF405FC0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Objects(){} // RVA: 0x7A7F191E0
        public void Bitmap(){} // RVA: 0x7A7F19210
        public void get_BitmapLength(){} // RVA: 0x7A7F169F0
        public void GetBitmapBytes(){} // RVA: 0x7A7F19220
        public void GetBitmapArray(){} // RVA: 0x7A7F19290
        public void CreateSparseSerializedObjects(){} // RVA: 0x7AF406330
        public void StartSparseSerializedObjects(){} // RVA: 0x7AF3EEE20
        public void AddObjects(){} // RVA: 0x7AF3EDC10
        public void AddBitmap(){} // RVA: 0x7AF3EF0B0
        public void CreateBitmapVector(){} // RVA: 0x7AF3EE180
        public void CreateBitmapVectorBlock(){} // RVA: 0x7AF406580
        public void StartBitmapVector(){} // RVA: 0x7AF3EE4F0
        public void EndSparseSerializedObjects(){} // RVA: 0x7AF406640
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7AF3EF3A0
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7AF3EF400
        public void UnPack(){} // RVA: 0x7A7F192E0
        public void UnPackTo(){} // RVA: 0x7A7F192F0
        public void Pack(){} // RVA: 0x7AF406AC0
    }

    public class SparseSerializedObjectsT : Object
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7A80F2570
        public void set_Objects(){} // RVA: 0x7A80D8E20
        public void get_Bitmap(){} // RVA: 0x7A80DA7B0
        public void set_Bitmap(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3CD570
        public void DeserializeFromBinary(){} // RVA: 0x7AF406B80
        public void SerializeToBinary(){} // RVA: 0x7AF406C30
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF406DB0
    }

    public class SyncPlayable : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSyncPlayable(){} // RVA: 0x7AF3E5C00
        public void VerifySyncPlayable(){} // RVA: 0x7AF406EE0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_StageParamsOffset(){} // RVA: 0x7A7F16B80
        public void get_Puppet(){} // RVA: 0x7A7F19320
        public void get_AvatarDiscriminator(){} // RVA: 0x7A7F19350
        public void CreateSyncPlayable(){} // RVA: 0x7AF407140
        public void StartSyncPlayable(){} // RVA: 0x7AF3F4A70
        public void AddStageParamsOffset(){} // RVA: 0x7AF3F2060
        public void AddPuppet(){} // RVA: 0x7AF3EA130
        public void AddAvatarDiscriminator(){} // RVA: 0x7AF407290
        public void EndSyncPlayable(){} // RVA: 0x7AF407300
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7AF3EF3A0
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7AF3EF400
        public void UnPack(){} // RVA: 0x7A7F193A0
        public void UnPackTo(){} // RVA: 0x7A7F193B0
        public void Pack(){} // RVA: 0x7AF407630
    }

    public class SyncPlayableT : Object
    {
        // ── Methods ──
        public void get_StageParamsOffset(){} // RVA: 0x7A8124910
        public void set_StageParamsOffset(){} // RVA: 0x7A80DA0C0
        public void get_Puppet(){} // RVA: 0x7A80DA7B0
        public void set_Puppet(){} // RVA: 0x7A813E420
        public void get_AvatarDiscriminator(){} // RVA: 0x7AC2A24B0
        public void set_AvatarDiscriminator(){} // RVA: 0x7AD8AE4B0
        public void .ctor(){} // RVA: 0x7AF407790
        public void DeserializeFromBinary(){} // RVA: 0x7AF407850
        public void SerializeToBinary(){} // RVA: 0x7AF407900
    }

    public class SyncPlayableVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF407A00
    }

}