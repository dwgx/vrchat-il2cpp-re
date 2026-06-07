// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 138

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class SHA256
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Bytes(){} // RVA: 0x7624F80
        public void CreateSHA256(){} // RVA: 0x7626F30
        public void UnPack(){} // RVA: 0x7627000
        public void UnPackTo(){} // RVA: 0x7627070
        public void Pack(){} // RVA: 0x7627170
    }

    public class SHA256T
    {
        public object Bytes;

        // ── Methods ──
        public void get_Bytes(){} // RVA: 0x2F8380
        public void set_Bytes(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x7627250
    }

    public class SerializedObjects
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7607450 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7620DA0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void ObjectsType(){} // RVA: 0x760F670
        public void get_ObjectsTypeLength(){} // RVA: 0x760F6F0
        public void GetObjectsTypeBytes(){} // RVA: 0x7620E90
        public void GetObjectsTypeArray(){} // RVA: 0x7620F00
        public void Objects(){} // RVA: 0x283FA0
        public void get_ObjectsLength(){} // RVA: 0x76103F0
        public void CreateSerializedObjects(){} // RVA: 0x7621030
        public void StartSerializedObjects(){} // RVA: 0x7610510
        public void AddObjectsType(){} // RVA: 0x760F330
        public void CreateObjectsTypeVector(){} // RVA: 0x760F8A0
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7621290 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x760FBF0
        public void AddObjects(){} // RVA: 0x76107A0
        public void CreateObjectsVector(){} // RVA: 0x7607E30
        public void CreateObjectsVectorBlock(){} // RVA: 0x76214F0 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x76081F0
        public void EndSerializedObjects(){} // RVA: 0x76215B0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x7621600
        public void UnPackTo(){} // RVA: 0x76216B0
        public void Pack(){} // RVA: 0x7621EE0
    }

    public class SerializedObjectsT
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x2F8380
        public void set_Objects(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
        public void DeserializeFromBinary(){} // RVA: 0x7622290
        public void SerializeToBinary(){} // RVA: 0x7622340
    }

    public class SerializedObjectsVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76100F0
    }

    public class SerializedTypeUnion
    {
        public object Type;
        public object Value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsSyncPlayable(){} // RVA: 0x761FE40
        public void FromSyncPlayable(){} // RVA: 0x761FE80
        public void AsDataStorage(){} // RVA: 0x761FF80
        public void FromDataStorage(){} // RVA: 0x761FFC0
        public void AsUdon(){} // RVA: 0x76200C0
        public void FromUdon(){} // RVA: 0x7620100
        public void AsObjectPool(){} // RVA: 0x7620200
        public void FromObjectPool(){} // RVA: 0x7620240
        public void AsPlayerStationStateData(){} // RVA: 0x7620340
        public void FromPlayerStationStateData(){} // RVA: 0x7620380
        public void AsPhysBoneRecorder(){} // RVA: 0x7620480
        public void FromPhysBoneRecorder(){} // RVA: 0x76204C0
        public void AsPlayerData(){} // RVA: 0x76205C0
        public void FromPlayerData(){} // RVA: 0x7620600
        public void Pack(){} // RVA: 0x7620700
    }

    public class SerializedTypeVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7620A50
    }

    public class SparseSerializedObjects
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7607450 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x76272E0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Objects(){} // RVA: 0x76273D0
        public void Bitmap(){} // RVA: 0x7627500
        public void get_BitmapLength(){} // RVA: 0x76103F0
        public void GetBitmapBytes(){} // RVA: 0x7627580
        public void GetBitmapArray(){} // RVA: 0x76275F0
        public void CreateSparseSerializedObjects(){} // RVA: 0x7627640
        public void StartSparseSerializedObjects(){} // RVA: 0x7610510
        public void AddObjects(){} // RVA: 0x760F330
        public void AddBitmap(){} // RVA: 0x76107A0
        public void CreateBitmapVector(){} // RVA: 0x760F8A0
        public void CreateBitmapVectorBlock(){} // RVA: 0x7627890 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x760FBF0
        public void EndSparseSerializedObjects(){} // RVA: 0x7627950
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x76279A0
        public void UnPackTo(){} // RVA: 0x7627AB0
        public void Pack(){} // RVA: 0x7627DD0
    }

    public class SparseSerializedObjectsT
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x2F8380
        public void set_Objects(){} // RVA: 0x2DEE30
        public void get_Bitmap(){} // RVA: 0x2E07C0
        public void set_Bitmap(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75EEF50
        public void DeserializeFromBinary(){} // RVA: 0x7627E90
        public void SerializeToBinary(){} // RVA: 0x7627F40
    }

    public class SparseSerializedObjectsVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x76280C0
    }

    public class SyncPlayable
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSyncPlayable(){} // RVA: 0x7607450 | overloaded x2
        public void VerifySyncPlayable(){} // RVA: 0x76281F0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_StageParamsOffset(){} // RVA: 0x7613160
        public void get_Puppet(){} // RVA: 0x76282E0
        public void get_AvatarDiscriminator(){} // RVA: 0x76283F0
        public void CreateSyncPlayable(){} // RVA: 0x7628440
        public void StartSyncPlayable(){} // RVA: 0x7616050
        public void AddStageParamsOffset(){} // RVA: 0x7613690
        public void AddPuppet(){} // RVA: 0x760B8D0
        public void AddAvatarDiscriminator(){} // RVA: 0x7628590
        public void EndSyncPlayable(){} // RVA: 0x7628600
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x7628650
        public void UnPackTo(){} // RVA: 0x7628750
        public void Pack(){} // RVA: 0x7628930
    }

    public class SyncPlayableT
    {
        // ── Methods ──
        public void get_StageParamsOffset(){} // RVA: 0x32A5C0
        public void set_StageParamsOffset(){} // RVA: 0x2E00C0
        public void get_Puppet(){} // RVA: 0x2E07C0
        public void set_Puppet(){} // RVA: 0x343E80
        public void get_AvatarDiscriminator(){} // RVA: 0x44B4370
        public void set_AvatarDiscriminator(){} // RVA: 0x5AC0F20
        public void .ctor(){} // RVA: 0x7628A90
        public void DeserializeFromBinary(){} // RVA: 0x7628B50
        public void SerializeToBinary(){} // RVA: 0x7628C00
    }

    public class SyncPlayableVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7628D00
    }

}