// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 33
// Methods: 245

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class WorldMetadata : ValueType
    {
        // ── Methods ──
        public void CompareHash(){} // RVA: 0x9BBA50
        public void ComputeHash(){} // RVA: 0x9BBBD0
        public void CollateObjectMetadata(){} // RVA: 0x9BBBE0
        public void AreCompatible(){} // RVA: 0x9BBC10
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsWorldMetadata(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Hash(){} // RVA: 0x9BBC30
        public void get_PlayerPersistenceGuid(){} // RVA: 0x9BBC60
        public void PlayerPersistenceMetadatas(){} // RVA: 0x9BBC90
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x9BBCC0
        public void ObjectMetadatas(){} // RVA: 0x9BBCD0
        public void get_ObjectMetadatasLength(){} // RVA: 0x9BB850
        public void get_MaximumViewIDs(){} // RVA: 0x9BBD00
        public void get_MinimumViewID(){} // RVA: 0x9BBD50
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x9BBDA0
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x9BBDF0
        public void NetworkCallingViews(){} // RVA: 0x9BBE40
        public void get_NetworkCallingViewsLength(){} // RVA: 0x9BBE70
        public void CreateWorldMetadata(){} // RVA: 0x82435E0
        public void StartWorldMetadata(){} // RVA: 0x82439C0
        public void AddHash(){} // RVA: 0x82439E0
        public void AddPlayerPersistenceGuid(){} // RVA: 0x8243A10
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x8243A40
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x823FEE0
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x8243C20
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x82402C0
        public void AddObjectMetadatas(){} // RVA: 0x823FEA0
        public void CreateObjectMetadatasVector(){} // RVA: 0x823FEE0
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x8243E80
        public void StartObjectMetadatasVector(){} // RVA: 0x82402C0
        public void AddMaximumViewIDs(){} // RVA: 0x8243F40
        public void AddMinimumViewID(){} // RVA: 0x8243FB0
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x8244020
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x8244090
        public void AddNetworkCallingViews(){} // RVA: 0x8244100
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x823FEE0
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x8244380
        public void StartNetworkCallingViewsVector(){} // RVA: 0x82402C0
        public void EndWorldMetadata(){} // RVA: 0x8244440
        public void UnPack(){} // RVA: 0x9BBE80
        public void UnPackTo(){} // RVA: 0x9BBE90
        public void Pack(){} // RVA: 0x8244D00
    }

    public class WorldMetadataT : Object
    {
        // ── Methods ──
        public void CompareHash(){} // RVA: 0x8245230
        public void ComputeHash(){} // RVA: 0x8245420
        public void CollateObjectMetadata(){} // RVA: 0x8245960
        public void AreCompatible(){} // RVA: 0x82459E0
        public void get_Hash(){} // RVA: 0xB5DBF0
        public void set_Hash(){} // RVA: 0xB44D60
        public void get_PlayerPersistenceGuid(){} // RVA: 0xB465B0
        public void set_PlayerPersistenceGuid(){} // RVA: 0xBA9BA0
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0xB700F0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0xB70100
        public void get_ObjectMetadatas(){} // RVA: 0xB70160
        public void set_ObjectMetadatas(){} // RVA: 0xB44DC0
        public void get_MaximumViewIDs(){} // RVA: 0xB9E080
        public void set_MaximumViewIDs(){} // RVA: 0xB9E090
        public void get_MinimumViewID(){} // RVA: 0xE9CE60
        public void set_MinimumViewID(){} // RVA: 0xEA1260
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x18A0130
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x189D3F0
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x114DAD0
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x25671C0
        public void get_NetworkCallingViews(){} // RVA: 0xBC1B30
        public void set_NetworkCallingViews(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0x8245D40
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x8245F70
    }

    public class WorldMetadataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824FED0
    }

    public class WrappedBool : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_B(){} // RVA: 0x9BC2E0
        public void CreateWrappedBool(){} // RVA: 0x825C740
        public void UnPack(){} // RVA: 0x9BFB20
        public void UnPackTo(){} // RVA: 0x9BC320
        public void Pack(){} // RVA: 0x825C840
    }

    public class WrappedBoolT : Object
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0xC120A0
        public void set_B(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class WrappedByte : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_B(){} // RVA: 0x9BDAF0
        public void CreateWrappedByte(){} // RVA: 0x825C8F0
        public void UnPack(){} // RVA: 0x9BFBF0
        public void UnPackTo(){} // RVA: 0x9BFC00
        public void Pack(){} // RVA: 0x825CA30
    }

    public class WrappedByteT : Object
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0xC120A0
        public void set_B(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class WrappedBytes : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsWrappedBytes(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void B(){} // RVA: 0x9BC8B0
        public void get_BLength(){} // RVA: 0x9BC8C0
        public void GetBBytes(){} // RVA: 0x9BFDD0
        public void GetBArray(){} // RVA: 0x9BFE40
        public void CreateWrappedBytes(){} // RVA: 0x825CD50
        public void StartWrappedBytes(){} // RVA: 0x82476C0
        public void AddB(){} // RVA: 0x82476E0
        public void CreateBVector(){} // RVA: 0x8247C50
        public void CreateBVectorBlock(){} // RVA: 0x825CF70
        public void StartBVector(){} // RVA: 0x8247FC0
        public void EndWrappedBytes(){} // RVA: 0x825D030
        public void UnPack(){} // RVA: 0x9BFE90
        public void UnPackTo(){} // RVA: 0x9BFEA0
        public void Pack(){} // RVA: 0x825D340
    }

    public class WrappedBytesT : Object
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0xB5DBF0
        public void set_B(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class WrappedBytesVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82484D0
    }

    public class WrappedDouble : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_D(){} // RVA: 0x9BF9E0
        public void CreateWrappedDouble(){} // RVA: 0x825C560
        public void UnPack(){} // RVA: 0x9BFA10
        public void UnPackTo(){} // RVA: 0x9BFA20
        public void Pack(){} // RVA: 0x825C6B0
    }

    public class WrappedDoubleT : Object
    {
        // ── Methods ──
        public void get_D(){} // RVA: 0x2566C50
        public void set_D(){} // RVA: 0x4B6F180
        public void .ctor(){} // RVA: 0x1968540
    }

    public class WrappedFloat : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_F(){} // RVA: 0x9BC560
        public void CreateWrappedFloat(){} // RVA: 0x825C3A0
        public void UnPack(){} // RVA: 0x9BF910
        public void UnPackTo(){} // RVA: 0x9BC5A0
        public void Pack(){} // RVA: 0x825C4A0
    }

    public class WrappedFloatT : Object
    {
        // ── Methods ──
        public void get_F(){} // RVA: 0xC763E0
        public void set_F(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class WrappedInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_I(){} // RVA: 0x9BC420
        public void CreateWrappedInt(){} // RVA: 0x825C040
        public void UnPack(){} // RVA: 0x9BF770
        public void UnPackTo(){} // RVA: 0x9BC460
        public void Pack(){} // RVA: 0x825C140
    }

    public class WrappedIntT : Object
    {
        // ── Methods ──
        public void get_I(){} // RVA: 0xB8F8F0
        public void set_I(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class WrappedLong : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsWrappedLong(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_L(){} // RVA: 0x9BF180
        public void CreateWrappedLong(){} // RVA: 0x825B2F0
        public void StartWrappedLong(){} // RVA: 0x82476C0
        public void AddL(){} // RVA: 0x825B3A0
        public void EndWrappedLong(){} // RVA: 0x825B410
        public void UnPack(){} // RVA: 0x9BF1D0
        public void UnPackTo(){} // RVA: 0x9BF1E0
        public void Pack(){} // RVA: 0x825B560
    }

    public class WrappedLongT : Object
    {
        // ── Methods ──
        public void get_L(){} // RVA: 0xB5DBF0
        public void set_L(){} // RVA: 0x2230E30
        public void .ctor(){} // RVA: 0x1968540
    }

    public class WrappedLongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x825B620
    }

    public class WrappedShort : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_S(){} // RVA: 0x9BF560
        public void CreateWrappedShort(){} // RVA: 0x825BCA0
        public void UnPack(){} // RVA: 0x9BF590
        public void UnPackTo(){} // RVA: 0x9BF5A0
        public void Pack(){} // RVA: 0x825BDE0
    }

    public class WrappedShortT : Object
    {
        // ── Methods ──
        public void get_S(){} // RVA: 0x24EA1D0
        public void set_S(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

    public class WrappedString : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsWrappedString(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_S(){} // RVA: 0x9BC6A0
        public void GetSBytes(){} // RVA: 0x9BF3D0
        public void GetSArray(){} // RVA: 0x9BF440
        public void CreateWrappedString(){} // RVA: 0x825B9D0
        public void StartWrappedString(){} // RVA: 0x82476C0
        public void AddS(){} // RVA: 0x82476E0
        public void EndWrappedString(){} // RVA: 0x825BA50
        public void UnPack(){} // RVA: 0x9BF490
        public void UnPackTo(){} // RVA: 0x9BC780
        public void Pack(){} // RVA: 0x825BBB0
    }

    public class WrappedStringT : Object
    {
        // ── Methods ──
        public void get_S(){} // RVA: 0xB5DBF0
        public void set_S(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class WrappedStringVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82479B0
    }

    public class WrappedUByte : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_U(){} // RVA: 0x9BDAF0
        public void CreateWrappedUByte(){} // RVA: 0x825CAE0
        public void UnPack(){} // RVA: 0x9BFD00
        public void UnPackTo(){} // RVA: 0x9BFC00
        public void Pack(){} // RVA: 0x825CBE0
    }

    public class WrappedUByteT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0xC120A0
        public void set_U(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class WrappedUInt : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_U(){} // RVA: 0x9BC420
        public void CreateWrappedUInt(){} // RVA: 0x825C1F0
        public void UnPack(){} // RVA: 0x9BF840
        public void UnPackTo(){} // RVA: 0x9BC460
        public void Pack(){} // RVA: 0x825C2F0
    }

    public class WrappedUIntT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0xB8F8F0
        public void set_U(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class WrappedULong : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsWrappedULong(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_U(){} // RVA: 0x9BF180
        public void CreateWrappedULong(){} // RVA: 0x825B6B0
        public void StartWrappedULong(){} // RVA: 0x82476C0
        public void AddU(){} // RVA: 0x825B3A0
        public void EndWrappedULong(){} // RVA: 0x825B760
        public void UnPack(){} // RVA: 0x9BF300
        public void UnPackTo(){} // RVA: 0x9BF1E0
        public void Pack(){} // RVA: 0x825B850
    }

    public class WrappedULongT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0xB5DBF0
        public void set_U(){} // RVA: 0x2230E30
        public void .ctor(){} // RVA: 0x1968540
    }

    public class WrappedULongVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x825B620
    }

    public class WrappedUShort : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_U(){} // RVA: 0x9BF560
        public void CreateWrappedUShort(){} // RVA: 0x825BE90
        public void UnPack(){} // RVA: 0x9BF6A0
        public void UnPackTo(){} // RVA: 0x9BF5A0
        public void Pack(){} // RVA: 0x825BF90
    }

    public class WrappedUShortT : Object
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0x24EA1D0
        public void set_U(){} // RVA: 0x24EAB10
        public void .ctor(){} // RVA: 0x26240F0
    }

}