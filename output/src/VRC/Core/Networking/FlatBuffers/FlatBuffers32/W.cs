// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 33
// Methods: 258

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class WorldMetadata : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x1DD
        public object field_2; // 0x1DE
        public object field_3; // 0x1DF
        public object field_4; // 0x1E0
        public object field_5; // 0x1E1
        public object field_6; // 0x1E2
        public object field_7; // 0x1E3
        public object field_8; // 0x1E4
        public object field_9; // 0x1E5

        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFE881471A0
        public void ComputeHash(){} // RVA: 0x7FFE88147310
        public void CollateObjectMetadata(){} // RVA: 0x7FFE88147750
        public void AreCompatible(){} // RVA: 0x7FFE881478F0
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsWorldMetadata(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Hash(){} // RVA: 0x7FFE88147C70
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFE88147D80
        public void PlayerPersistenceMetadatas(){} // RVA: 0x7FFE88147E90
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x7FFE88148000
        public void ObjectMetadatas(){} // RVA: 0x7FFE88148070
        public void get_ObjectMetadatasLength(){} // RVA: 0x7FFE88144760
        public void get_MaximumViewIDs(){} // RVA: 0x7FFE881481E0
        public void get_MinimumViewID(){} // RVA: 0x7FFE88148230
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFE88148280
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFE881482D0
        public void NetworkCallingViews(){} // RVA: 0x7FFE88148320
        public void get_NetworkCallingViewsLength(){} // RVA: 0x7FFE88148490
        public void CreateWorldMetadata(){} // RVA: 0x7FFE88148500
        public void StartWorldMetadata(){} // RVA: 0x7FFE881488D0
        public void AddHash(){} // RVA: 0x7FFE881488F0
        public void AddPlayerPersistenceGuid(){} // RVA: 0x7FFE88148920
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x7FFE88148950
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x7FFE88144E80
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7FFE88148B30 | overloaded x3
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x7FFE88145240
        public void AddObjectMetadatas(){} // RVA: 0x7FFE88144E40
        public void CreateObjectMetadatasVector(){} // RVA: 0x7FFE88144E80
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7FFE88148D90 | overloaded x3
        public void StartObjectMetadatasVector(){} // RVA: 0x7FFE88145240
        public void AddMaximumViewIDs(){} // RVA: 0x7FFE88148E50
        public void AddMinimumViewID(){} // RVA: 0x7FFE88148EC0
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x7FFE88148F30
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x7FFE88148FA0
        public void AddNetworkCallingViews(){} // RVA: 0x7FFE88149010
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x7FFE88144E80
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7FFE88149290 | overloaded x3
        public void StartNetworkCallingViewsVector(){} // RVA: 0x7FFE88145240
        public void EndWorldMetadata(){} // RVA: 0x7FFE88149350
        public void UnPack(){} // RVA: 0x7FFE881493A0
        public void UnPackTo(){} // RVA: 0x7FFE88149410
        public void Pack(){} // RVA: 0x7FFE88149C20
    }

    public class WorldMetadataT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.SHA256T _hash; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.GuidT _playerPersistenceGuid; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> _playerPersistenceMetadatas; // 0x20
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> _objectMetadatas; // 0x28
        public int _maximumViewIDs; // 0x30
        public int _minimumViewID; // 0x34
        public int _firstPlayerPersistenceID; // 0x38
        public int _maxPlayerPersistenceID; // 0x3C
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.NetworkCallingViewT> _networkCallingViews; // 0x40

        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFE8814A0C0
        public void ComputeHash(){} // RVA: 0x7FFE8814A2B0
        public void CollateObjectMetadata(){} // RVA: 0x7FFE8814A810
        public void AreCompatible(){} // RVA: 0x7FFE8814A890
        public void get_Hash(){} // RVA: 0x7FFE81116380
        public void set_Hash(){} // RVA: 0x7FFE810FCE30
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFE810FE7C0
        public void set_PlayerPersistenceGuid(){} // RVA: 0x7FFE81161E80
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0x7FFE811290C0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0x7FFE811290D0
        public void get_ObjectMetadatas(){} // RVA: 0x7FFE81129130
        public void set_ObjectMetadatas(){} // RVA: 0x7FFE810FCE90
        public void get_MaximumViewIDs(){} // RVA: 0x7FFE81156CD0
        public void set_MaximumViewIDs(){} // RVA: 0x7FFE81156CE0
        public void get_MinimumViewID(){} // RVA: 0x7FFE82447220
        public void set_MinimumViewID(){} // RVA: 0x7FFE82443340
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFE81D46090
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x7FFE81D46A00
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFE816311C0
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x7FFE82A4B070
        public void get_NetworkCallingViews(){} // RVA: 0x7FFE81178740
        public void set_NetworkCallingViews(){} // RVA: 0x7FFE81123200
        public void .ctor(){} // RVA: 0x7FFE8814ABE0
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x7FFE8814AE10
    }

    public class WorldMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE881549E0
    }

    public class WrappedBool : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x287

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_B(){} // RVA: 0x7FFE8814BB50
        public void CreateWrappedBool(){} // RVA: 0x7FFE88160930
        public void UnPack(){} // RVA: 0x7FFE881609C0
        public void UnPackTo(){} // RVA: 0x7FFE8814BC80
        public void Pack(){} // RVA: 0x7FFE88160A30
    }

    public class WrappedBoolT : Object
    {
        public bool _b; // 0x10

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFE811C55E0
        public void set_B(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class WrappedByte : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x28A

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_B(){} // RVA: 0x7FFE88155130
        public void CreateWrappedByte(){} // RVA: 0x7FFE88160AE0
        public void UnPack(){} // RVA: 0x7FFE88160B70
        public void UnPackTo(){} // RVA: 0x7FFE88160BE0
        public void Pack(){} // RVA: 0x7FFE88160C20
    }

    public class WrappedByteT : Object
    {
        public byte _b; // 0x10

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFE811C55E0
        public void set_B(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class WrappedBytes : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x290

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsWrappedBytes(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void B(){} // RVA: 0x7FFE8814C6C0
        public void get_BLength(){} // RVA: 0x7FFE8814C740
        public void GetBBytes(){} // RVA: 0x7FFE88160E80
        public void GetBArray(){} // RVA: 0x7FFE88160EF0
        public void CreateWrappedBytes(){} // RVA: 0x7FFE88160F40
        public void StartWrappedBytes(){} // RVA: 0x7FFE8814C360
        public void AddB(){} // RVA: 0x7FFE8814C380
        public void CreateBVector(){} // RVA: 0x7FFE8814C8F0
        public void CreateBVectorBlock(){} // RVA: 0x7FFE88161160 | overloaded x3
        public void StartBVector(){} // RVA: 0x7FFE8814CC40
        public void EndWrappedBytes(){} // RVA: 0x7FFE88161220
        public void UnPack(){} // RVA: 0x7FFE88161270
        public void UnPackTo(){} // RVA: 0x7FFE88161320
        public void Pack(){} // RVA: 0x7FFE88161530
    }

    public class WrappedBytesT : Object
    {
        public System.Collections.Generic.List`1<byte> _b; // 0x10

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFE81116380
        public void set_B(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class WrappedBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814D140
    }

    public class WrappedDouble : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x284

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_D(){} // RVA: 0x7FFE88160720
        public void CreateWrappedDouble(){} // RVA: 0x7FFE88160750
        public void UnPack(){} // RVA: 0x7FFE881607E0
        public void UnPackTo(){} // RVA: 0x7FFE88160860
        public void Pack(){} // RVA: 0x7FFE881608A0
    }

    public class WrappedDoubleT : Object
    {
        public double _d; // 0x10

        // ── Methods ──
        public void get_D(){} // RVA: 0x7FFE83BB0D80
        public void set_D(){} // RVA: 0x7FFE84D215B0
        public void .ctor(){} // RVA: 0x7FFE81DB74C0
    }

    public class WrappedFloat : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x281

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_F(){} // RVA: 0x7FFE8814BF90
        public void CreateWrappedFloat(){} // RVA: 0x7FFE88160590
        public void UnPack(){} // RVA: 0x7FFE88160620
        public void UnPackTo(){} // RVA: 0x7FFE8814C0C0
        public void Pack(){} // RVA: 0x7FFE88160690
    }

    public class WrappedFloatT : Object
    {
        public float _f; // 0x10

        // ── Methods ──
        public void get_F(){} // RVA: 0x7FFE81225320
        public void set_F(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class WrappedInt : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x27B

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_I(){} // RVA: 0x7FFE8814BD70
        public void CreateWrappedInt(){} // RVA: 0x7FFE88160230
        public void UnPack(){} // RVA: 0x7FFE881602C0
        public void UnPackTo(){} // RVA: 0x7FFE8814BEA0
        public void Pack(){} // RVA: 0x7FFE88160330
    }

    public class WrappedIntT : Object
    {
        public int _i; // 0x10

        // ── Methods ──
        public void get_I(){} // RVA: 0x7FFE811485C0
        public void set_I(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class WrappedLong : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x26C

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsWrappedLong(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_L(){} // RVA: 0x7FFE8815F490
        public void CreateWrappedLong(){} // RVA: 0x7FFE8815F4E0
        public void StartWrappedLong(){} // RVA: 0x7FFE8814C360
        public void AddL(){} // RVA: 0x7FFE8815F590
        public void EndWrappedLong(){} // RVA: 0x7FFE8815F600
        public void UnPack(){} // RVA: 0x7FFE8815F650
        public void UnPackTo(){} // RVA: 0x7FFE8815F6F0
        public void Pack(){} // RVA: 0x7FFE8815F750
    }

    public class WrappedLongT : Object
    {
        public long _l; // 0x10

        // ── Methods ──
        public void get_L(){} // RVA: 0x7FFE81116380
        public void set_L(){} // RVA: 0x7FFE826F2ED0
        public void .ctor(){} // RVA: 0x7FFE81DB74C0
    }

    public class WrappedLongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815F810
    }

    public class WrappedShort : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x275

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_S(){} // RVA: 0x7FFE8815FE60
        public void CreateWrappedShort(){} // RVA: 0x7FFE8815FE90
        public void UnPack(){} // RVA: 0x7FFE8815FF20
        public void UnPackTo(){} // RVA: 0x7FFE8815FF90
        public void Pack(){} // RVA: 0x7FFE8815FFD0
    }

    public class WrappedShortT : Object
    {
        public short _s; // 0x10

        // ── Methods ──
        public void get_S(){} // RVA: 0x7FFE8299FB40
        public void set_S(){} // RVA: 0x7FFE8299FB10
        public void .ctor(){} // RVA: 0x7FFE82B02750
    }

    public class WrappedString : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x272

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsWrappedString(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_S(){} // RVA: 0x7FFE8814C190
        public void GetSBytes(){} // RVA: 0x7FFE8815FB00
        public void GetSArray(){} // RVA: 0x7FFE8815FB70
        public void CreateWrappedString(){} // RVA: 0x7FFE8815FBC0
        public void StartWrappedString(){} // RVA: 0x7FFE8814C360
        public void AddS(){} // RVA: 0x7FFE8814C380
        public void EndWrappedString(){} // RVA: 0x7FFE8815FC40
        public void UnPack(){} // RVA: 0x7FFE8815FC90
        public void UnPackTo(){} // RVA: 0x7FFE8814C520
        public void Pack(){} // RVA: 0x7FFE8815FDA0
    }

    public class WrappedStringT : Object
    {
        public string _s; // 0x10

        // ── Methods ──
        public void get_S(){} // RVA: 0x7FFE81116380
        public void set_S(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class WrappedStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8814C650
    }

    public class WrappedUByte : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x28D

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_U(){} // RVA: 0x7FFE88155130
        public void CreateWrappedUByte(){} // RVA: 0x7FFE88160CD0
        public void UnPack(){} // RVA: 0x7FFE88160D60
        public void UnPackTo(){} // RVA: 0x7FFE88160BE0
        public void Pack(){} // RVA: 0x7FFE88160DD0
    }

    public class WrappedUByteT : Object
    {
        public byte _u; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFE811C55E0
        public void set_U(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
    }

    public class WrappedUInt : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x27E

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_U(){} // RVA: 0x7FFE8814BD70
        public void CreateWrappedUInt(){} // RVA: 0x7FFE881603E0
        public void UnPack(){} // RVA: 0x7FFE88160470
        public void UnPackTo(){} // RVA: 0x7FFE8814BEA0
        public void Pack(){} // RVA: 0x7FFE881604E0
    }

    public class WrappedUIntT : Object
    {
        public uint _u; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFE811485C0
        public void set_U(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class WrappedULong : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x26F

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsWrappedULong(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_U(){} // RVA: 0x7FFE8815F490
        public void CreateWrappedULong(){} // RVA: 0x7FFE8815F8A0
        public void StartWrappedULong(){} // RVA: 0x7FFE8814C360
        public void AddU(){} // RVA: 0x7FFE8815F590
        public void EndWrappedULong(){} // RVA: 0x7FFE8815F950
        public void UnPack(){} // RVA: 0x7FFE8815F9A0
        public void UnPackTo(){} // RVA: 0x7FFE8815F6F0
        public void Pack(){} // RVA: 0x7FFE8815FA40
    }

    public class WrappedULongT : Object
    {
        public ulong _u; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFE81116380
        public void set_U(){} // RVA: 0x7FFE826F2ED0
        public void .ctor(){} // RVA: 0x7FFE81DB74C0
    }

    public class WrappedULongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8815F810
    }

    public class WrappedUShort : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x278

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_U(){} // RVA: 0x7FFE8815FE60
        public void CreateWrappedUShort(){} // RVA: 0x7FFE88160080
        public void UnPack(){} // RVA: 0x7FFE88160110
        public void UnPackTo(){} // RVA: 0x7FFE8815FF90
        public void Pack(){} // RVA: 0x7FFE88160180
    }

    public class WrappedUShortT : Object
    {
        public ushort _u; // 0x10

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFE8299FB40
        public void set_U(){} // RVA: 0x7FFE8299FB10
        public void .ctor(){} // RVA: 0x7FFE82B02750
    }

}