// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 142

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class SHA256 : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Bytes(){} // RVA: 0x7FFAC9DBC540
        public void MutateBytes(){} // RVA: 0x7FFAC9DBC570
        public void CreateSHA256(){} // RVA: 0x7FFAC9DBE5F0
        public void UnPack(){} // RVA: 0x7FFAC9DBE6C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBE730
        public void Pack(){} // RVA: 0x7FFAC9DBE830
    }

    public class SHA256T : Object
    {
        public byte[] Bytes; // 0x10

        // ── Methods ──
        public void get_Bytes(){} // RVA: 0x7FFAC2F3C380
        public void set_Bytes(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9DBE910
    }

    public class SerializedObjects : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFAC9DB8100
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void ObjectsType(){} // RVA: 0x7FFAC9DA64D0
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFAC9DA6550
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFAC9DB81F0
        public void GetObjectsTypeArray(){} // RVA: 0x7FFAC9DB8260
        public void Objects(){} // RVA: 0x7FFAC2E8DC40
        public void get_ObjectsLength(){} // RVA: 0x7FFAC9DA72E0
        public void CreateSerializedObjects(){} // RVA: 0x7FFAC9DB8390
        public void StartSerializedObjects(){} // RVA: 0x7FFAC9DA7400
        public void AddObjectsType(){} // RVA: 0x7FFAC9DA6190
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFAC9DB85F0 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFAC9DA6AE0
        public void AddObjects(){} // RVA: 0x7FFAC9DA7690
        public void CreateObjectsVector(){} // RVA: 0x7FFAC9D9D690
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFAC9DB8850 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndSerializedObjects(){} // RVA: 0x7FFAC9DB8910
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DB8960
        public void UnPackTo(){} // RVA: 0x7FFAC9DB8A10
        public void Pack(){} // RVA: 0x7FFAC9DB9240
    }

    public class SerializedObjectsT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.SerializedTypeUnion> Objects; // 0x10

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFAC2F3C380
        public void set_Objects(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DB95F0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DB96A0
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DA6FE0
    }

    public class SerializedTypeUnion : Object
    {
        public 0x6B200EE8 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsSyncPlayable(){} // RVA: 0x7FFAC9DB71A0
        public void FromSyncPlayable(){} // RVA: 0x7FFAC9DB71E0
        public void AsDataStorage(){} // RVA: 0x7FFAC9DB72E0
        public void FromDataStorage(){} // RVA: 0x7FFAC9DB7320
        public void AsUdon(){} // RVA: 0x7FFAC9DB7420
        public void FromUdon(){} // RVA: 0x7FFAC9DB7460
        public void AsObjectPool(){} // RVA: 0x7FFAC9DB7560
        public void FromObjectPool(){} // RVA: 0x7FFAC9DB75A0
        public void AsPlayerStationStateData(){} // RVA: 0x7FFAC9DB76A0
        public void FromPlayerStationStateData(){} // RVA: 0x7FFAC9DB76E0
        public void AsPhysBoneRecorder(){} // RVA: 0x7FFAC9DB77E0
        public void FromPhysBoneRecorder(){} // RVA: 0x7FFAC9DB7820
        public void AsPlayerData(){} // RVA: 0x7FFAC9DB7920
        public void FromPlayerData(){} // RVA: 0x7FFAC9DB7960
        public void Pack(){} // RVA: 0x7FFAC9DB7A60
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB7DB0
    }

    public class SparseSerializedObjects : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFAC9DBE9A0
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Objects(){} // RVA: 0x7FFAC9DBEA90
        public void Bitmap(){} // RVA: 0x7FFAC9DBEBC0
        public void get_BitmapLength(){} // RVA: 0x7FFAC9DA72E0
        public void GetBitmapBytes(){} // RVA: 0x7FFAC9DBEC40
        public void GetBitmapArray(){} // RVA: 0x7FFAC9DBECB0
        public void MutateBitmap(){} // RVA: 0x7FFAC9DBED00
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFAC9DBED90
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFAC9DA7400
        public void AddObjects(){} // RVA: 0x7FFAC9DA6190
        public void AddBitmap(){} // RVA: 0x7FFAC9DA7690
        public void CreateBitmapVector(){} // RVA: 0x7FFAC9DA6790
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFAC9DBEFE0 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFAC9DA6AE0
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFAC9DBF0A0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DBF0F0
        public void UnPackTo(){} // RVA: 0x7FFAC9DBF200
        public void Pack(){} // RVA: 0x7FFAC9DBF520
    }

    public class SparseSerializedObjectsT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.SerializedObjectsT Objects; // 0x10
        public System.Collections.Generic.List`1<byte> Bitmap; // 0x18

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFAC2F3C380
        public void set_Objects(){} // RVA: 0x7FFAC2F22E30
        public void get_Bitmap(){} // RVA: 0x7FFAC2F247C0
        public void set_Bitmap(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D84070
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DBF5E0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DBF690
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DBF810
    }

    public class SyncPlayable : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSyncPlayable(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifySyncPlayable(){} // RVA: 0x7FFAC9DBF940
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_StageParamsOffset(){} // RVA: 0x7FFAC9DAA050
        public void MutateStageParamsOffset(){} // RVA: 0x7FFAC9DAA0A0
        public void get_Puppet(){} // RVA: 0x7FFAC9DBFA30
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFAC9DBFB40
        public void MutateAvatarDiscriminator(){} // RVA: 0x7FFAC9DBFB90
        public void CreateSyncPlayable(){} // RVA: 0x7FFAC9DBFBF0
        public void StartSyncPlayable(){} // RVA: 0x7FFAC9DAD1E0
        public void AddStageParamsOffset(){} // RVA: 0x7FFAC9DAA730
        public void AddPuppet(){} // RVA: 0x7FFAC9DA2670
        public void AddAvatarDiscriminator(){} // RVA: 0x7FFAC9DBFD40
        public void EndSyncPlayable(){} // RVA: 0x7FFAC9DBFDB0
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DBFE00
        public void UnPackTo(){} // RVA: 0x7FFAC9DBFF00
        public void Pack(){} // RVA: 0x7FFAC9DC00E0
    }

    public class SyncPlayableT : Object
    {
        public int StageParamsOffset; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PuppetDataT Puppet; // 0x18
        public ushort AvatarDiscriminator; // 0x20

        // ── Methods ──
        public void get_StageParamsOffset(){} // RVA: 0x7FFAC2F6E5C0
        public void set_StageParamsOffset(){} // RVA: 0x7FFAC2F240C0
        public void get_Puppet(){} // RVA: 0x7FFAC2F247C0
        public void set_Puppet(){} // RVA: 0x7FFAC2F87E80
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFAC6D68C80
        public void set_AvatarDiscriminator(){} // RVA: 0x7FFAC8258410
        public void .ctor(){} // RVA: 0x7FFAC9DC0240
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DC0300
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DC03B0
    }

    public class SyncPlayableVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DC04B0
    }

}