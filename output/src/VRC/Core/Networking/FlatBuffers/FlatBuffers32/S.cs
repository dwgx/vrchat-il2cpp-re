// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 13
// Methods: 138

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class SHA256 : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Bytes(){} // RVA: 0x7FFE88161FD0
        public void CreateSHA256(){} // RVA: 0x7FFE88163F80
        public void UnPack(){} // RVA: 0x7FFE88164050
        public void UnPackTo(){} // RVA: 0x7FFE881640C0
        public void Pack(){} // RVA: 0x7FFE881641C0
    }

    public class SHA256T : Object
    {
        public byte[] _bytes; // 0x10

        // ── Methods ──
        public void get_Bytes(){} // RVA: 0x7FFE81116380
        public void set_Bytes(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE881642A0
    }

    public class SerializedObjects : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x43
        public object field_2; // 0x44

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFE8815DDF0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void ObjectsType(){} // RVA: 0x7FFE8814C6C0
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFE8814C740
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFE8815DEE0
        public void GetObjectsTypeArray(){} // RVA: 0x7FFE8815DF50
        public void Objects(){} // RVA: 0x7FFE810A1420
        public void get_ObjectsLength(){} // RVA: 0x7FFE8814D440
        public void CreateSerializedObjects(){} // RVA: 0x7FFE8815E080
        public void StartSerializedObjects(){} // RVA: 0x7FFE8814D560
        public void AddObjectsType(){} // RVA: 0x7FFE8814C380
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFE8815E2E0 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFE8814CC40
        public void AddObjects(){} // RVA: 0x7FFE8814D7F0
        public void CreateObjectsVector(){} // RVA: 0x7FFE88144E80
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFE8815E540 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFE88145240
        public void EndSerializedObjects(){} // RVA: 0x7FFE8815E600
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE8815E650
        public void UnPackTo(){} // RVA: 0x7FFE8815E700
        public void Pack(){} // RVA: 0x7FFE8815EF30
    }

    public class SerializedObjectsT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.SerializedTypeUnion> _objects; // 0x10

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFE81116380
        public void set_Objects(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE8815F2E0
        public void SerializeToBinary(){} // RVA: 0x7FFE8815F390
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

    public class SerializedTypeUnion : Object
    {
        public 0x665FA7AC _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsSyncPlayable(){} // RVA: 0x7FFE8815CE90
        public void FromSyncPlayable(){} // RVA: 0x7FFE8815CED0
        public void AsDataStorage(){} // RVA: 0x7FFE8815CFD0
        public void FromDataStorage(){} // RVA: 0x7FFE8815D010
        public void AsUdon(){} // RVA: 0x7FFE8815D110
        public void FromUdon(){} // RVA: 0x7FFE8815D150
        public void AsObjectPool(){} // RVA: 0x7FFE8815D250
        public void FromObjectPool(){} // RVA: 0x7FFE8815D290
        public void AsPlayerStationStateData(){} // RVA: 0x7FFE8815D390
        public void FromPlayerStationStateData(){} // RVA: 0x7FFE8815D3D0
        public void AsPhysBoneRecorder(){} // RVA: 0x7FFE8815D4D0
        public void FromPhysBoneRecorder(){} // RVA: 0x7FFE8815D510
        public void AsPlayerData(){} // RVA: 0x7FFE8815D610
        public void FromPlayerData(){} // RVA: 0x7FFE8815D650
        public void Pack(){} // RVA: 0x7FFE8815D750
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815DAA0
    }

    public class SparseSerializedObjects : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x2CA
        public object field_2; // 0x2CB

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFE88164330
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Objects(){} // RVA: 0x7FFE88164420
        public void Bitmap(){} // RVA: 0x7FFE88164550
        public void get_BitmapLength(){} // RVA: 0x7FFE8814D440
        public void GetBitmapBytes(){} // RVA: 0x7FFE881645D0
        public void GetBitmapArray(){} // RVA: 0x7FFE88164640
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFE88164690
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFE8814D560
        public void AddObjects(){} // RVA: 0x7FFE8814C380
        public void AddBitmap(){} // RVA: 0x7FFE8814D7F0
        public void CreateBitmapVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFE881648E0 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFE8814CC40
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFE881649A0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE881649F0
        public void UnPackTo(){} // RVA: 0x7FFE88164B00
        public void Pack(){} // RVA: 0x7FFE88164E20
    }

    public class SparseSerializedObjectsT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.SerializedObjectsT _objects; // 0x10
        public System.Collections.Generic.List`1<byte> _bitmap; // 0x18

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFE81116380
        public void set_Objects(){} // RVA: 0x7FFE810FCE30
        public void get_Bitmap(){} // RVA: 0x7FFE810FE7C0
        public void set_Bitmap(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8812BFA0
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88164EE0
        public void SerializeToBinary(){} // RVA: 0x7FFE88164F90
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88165110
    }

    public class SyncPlayable : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public int _bb_pos; // 0x10
        public Google.FlatBuffers32.ByteBuffer _bb; // 0x18
        public object field_3; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSyncPlayable(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void VerifySyncPlayable(){} // RVA: 0x7FFE88165240
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_StageParamsOffset(){} // RVA: 0x7FFE881501B0
        public void get_Puppet(){} // RVA: 0x7FFE88165330
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFE88165440
        public void CreateSyncPlayable(){} // RVA: 0x7FFE88165490
        public void StartSyncPlayable(){} // RVA: 0x7FFE881530A0
        public void AddStageParamsOffset(){} // RVA: 0x7FFE881506E0
        public void AddPuppet(){} // RVA: 0x7FFE88148920
        public void AddAvatarDiscriminator(){} // RVA: 0x7FFE881655E0
        public void EndSyncPlayable(){} // RVA: 0x7FFE88165650
        public void FinishSyncPlayableBuffer(){} // RVA: 0x7FFE8814DAE0
        public void FinishSizePrefixedSyncPlayableBuffer(){} // RVA: 0x7FFE8814DB40
        public void UnPack(){} // RVA: 0x7FFE881656A0
        public void UnPackTo(){} // RVA: 0x7FFE881657A0
        public void Pack(){} // RVA: 0x7FFE88165980
    }

    public class SyncPlayableT : Object
    {
        public int _stageParamsOffset; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PuppetDataT _puppet; // 0x18
        public ushort _avatarDiscriminator; // 0x20

        // ── Methods ──
        public void get_StageParamsOffset(){} // RVA: 0x7FFE811485C0
        public void set_StageParamsOffset(){} // RVA: 0x7FFE810FE0C0
        public void get_Puppet(){} // RVA: 0x7FFE810FE7C0
        public void set_Puppet(){} // RVA: 0x7FFE81161E80
        public void get_AvatarDiscriminator(){} // RVA: 0x7FFE850EF1D0
        public void set_AvatarDiscriminator(){} // RVA: 0x7FFE86601D50
        public void .ctor(){} // RVA: 0x7FFE88165AE0
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88165BA0
        public void SerializeToBinary(){} // RVA: 0x7FFE88165C50
    }

    public class SyncPlayableVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88165D50
    }

}