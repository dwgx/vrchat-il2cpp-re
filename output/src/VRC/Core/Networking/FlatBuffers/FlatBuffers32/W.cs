// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 33
// Methods: 258

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class WorldMetadata
    {
        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFAFA0BA150
        public void ComputeHash(){} // RVA: 0x7FFAFA0BA2C0
        public void CollateObjectMetadata(){} // RVA: 0x7FFAFA0BA700
        public void AreCompatible(){} // RVA: 0x7FFAFA0BA8A0
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsWorldMetadata(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Hash(){} // RVA: 0x7FFAFA0BAC20
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFAFA0BAD30
        public void PlayerPersistenceMetadatas(){} // RVA: 0x7FFAFA0BAE40
        public void get_PlayerPersistenceMetadatasLength(){} // RVA: 0x7FFAFA0BAFB0
        public void ObjectMetadatas(){} // RVA: 0x7FFAFA0BB020
        public void get_ObjectMetadatasLength(){} // RVA: 0x7FFAFA0B7710
        public void get_MaximumViewIDs(){} // RVA: 0x7FFAFA0BB190
        public void get_MinimumViewID(){} // RVA: 0x7FFAFA0BB1E0
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFAFA0BB230
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFAFA0BB280
        public void NetworkCallingViews(){} // RVA: 0x7FFAFA0BB2D0
        public void get_NetworkCallingViewsLength(){} // RVA: 0x7FFAFA0BB440
        public void CreateWorldMetadata(){} // RVA: 0x7FFAFA0BB4B0
        public void StartWorldMetadata(){} // RVA: 0x7FFAFA0BB880
        public void AddHash(){} // RVA: 0x7FFAFA0BB8A0
        public void AddPlayerPersistenceGuid(){} // RVA: 0x7FFAFA0BB8D0
        public void AddPlayerPersistenceMetadatas(){} // RVA: 0x7FFAFA0BB900
        public void CreatePlayerPersistenceMetadatasVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreatePlayerPersistenceMetadatasVectorBlock(){} // RVA: 0x7FFAFA0BBAE0 | overloaded x3
        public void StartPlayerPersistenceMetadatasVector(){} // RVA: 0x7FFAFA0B81F0
        public void AddObjectMetadatas(){} // RVA: 0x7FFAFA0B7DF0
        public void CreateObjectMetadatasVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateObjectMetadatasVectorBlock(){} // RVA: 0x7FFAFA0BBD40 | overloaded x3
        public void StartObjectMetadatasVector(){} // RVA: 0x7FFAFA0B81F0
        public void AddMaximumViewIDs(){} // RVA: 0x7FFAFA0BBE00
        public void AddMinimumViewID(){} // RVA: 0x7FFAFA0BBE70
        public void AddFirstPlayerPersistenceID(){} // RVA: 0x7FFAFA0BBEE0
        public void AddMaxPlayerPersistenceID(){} // RVA: 0x7FFAFA0BBF50
        public void AddNetworkCallingViews(){} // RVA: 0x7FFAFA0BBFC0
        public void CreateNetworkCallingViewsVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreateNetworkCallingViewsVectorBlock(){} // RVA: 0x7FFAFA0BC240 | overloaded x3
        public void StartNetworkCallingViewsVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndWorldMetadata(){} // RVA: 0x7FFAFA0BC300
        public void UnPack(){} // RVA: 0x7FFAFA0BC350
        public void UnPackTo(){} // RVA: 0x7FFAFA0BC3C0
        public void Pack(){} // RVA: 0x7FFAFA0BCBD0
    }

    public class WorldMetadataT
    {
        // ── Methods ──
        public void CompareHash(){} // RVA: 0x7FFAFA0BD070
        public void ComputeHash(){} // RVA: 0x7FFAFA0BD260
        public void CollateObjectMetadata(){} // RVA: 0x7FFAFA0BD7C0
        public void AreCompatible(){} // RVA: 0x7FFAFA0BD840
        public void get_Hash(){} // RVA: 0x7FFAF2DA8380
        public void set_Hash(){} // RVA: 0x7FFAF2D8EE30
        public void get_PlayerPersistenceGuid(){} // RVA: 0x7FFAF2D907C0
        public void set_PlayerPersistenceGuid(){} // RVA: 0x7FFAF2DF3E80
        public void get_PlayerPersistenceMetadatas(){} // RVA: 0x7FFAF2DBB0C0
        public void set_PlayerPersistenceMetadatas(){} // RVA: 0x7FFAF2DBB0D0
        public void get_ObjectMetadatas(){} // RVA: 0x7FFAF2DBB130
        public void set_ObjectMetadatas(){} // RVA: 0x7FFAF2D8EE90
        public void get_MaximumViewIDs(){} // RVA: 0x7FFAF2DE8CD0
        public void set_MaximumViewIDs(){} // RVA: 0x7FFAF2DE8CE0
        public void get_MinimumViewID(){} // RVA: 0x7FFAF2F76670
        public void set_MinimumViewID(){} // RVA: 0x7FFAF2F75F20
        public void get_FirstPlayerPersistenceID(){} // RVA: 0x7FFAF3A8C9F0
        public void set_FirstPlayerPersistenceID(){} // RVA: 0x7FFAF3A8D6E0
        public void get_MaxPlayerPersistenceID(){} // RVA: 0x7FFAF3341AF0
        public void set_MaxPlayerPersistenceID(){} // RVA: 0x7FFAF47695F0
        public void get_NetworkCallingViews(){} // RVA: 0x7FFAF2E0A740
        public void set_NetworkCallingViews(){} // RVA: 0x7FFAF2DB5200
        public void .ctor(){} // RVA: 0x7FFAFA0BDB90
        public void <AreCompatible>g__MetadataCompatible|3_0(){} // RVA: 0x7FFAFA0BDDC0
    }

    public class WorldMetadataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C7990
    }

    public class WrappedBool
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_B(){} // RVA: 0x7FFAFA0BEB00
        public void CreateWrappedBool(){} // RVA: 0x7FFAFA0D38E0
        public void UnPack(){} // RVA: 0x7FFAFA0D3970
        public void UnPackTo(){} // RVA: 0x7FFAFA0BEC30
        public void Pack(){} // RVA: 0x7FFAFA0D39E0
    }

    public class WrappedBoolT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFAF2E575E0
        public void set_B(){} // RVA: 0x7FFAF2E575F0
        public void .ctor(){} // RVA: 0x7FFAF316DA00
    }

    public class WrappedByte
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_B(){} // RVA: 0x7FFAFA0C80E0
        public void CreateWrappedByte(){} // RVA: 0x7FFAFA0D3A90
        public void UnPack(){} // RVA: 0x7FFAFA0D3B20
        public void UnPackTo(){} // RVA: 0x7FFAFA0D3B90
        public void Pack(){} // RVA: 0x7FFAFA0D3BD0
    }

    public class WrappedByteT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFAF2E575E0
        public void set_B(){} // RVA: 0x7FFAF2E575F0
        public void .ctor(){} // RVA: 0x7FFAF316DA00
    }

    public class WrappedBytes
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsWrappedBytes(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void B(){} // RVA: 0x7FFAFA0BF670
        public void get_BLength(){} // RVA: 0x7FFAFA0BF6F0
        public void GetBBytes(){} // RVA: 0x7FFAFA0D3E30
        public void GetBArray(){} // RVA: 0x7FFAFA0D3EA0
        public void CreateWrappedBytes(){} // RVA: 0x7FFAFA0D3EF0
        public void StartWrappedBytes(){} // RVA: 0x7FFAFA0BF310
        public void AddB(){} // RVA: 0x7FFAFA0BF330
        public void CreateBVector(){} // RVA: 0x7FFAFA0BF8A0
        public void CreateBVectorBlock(){} // RVA: 0x7FFAFA0D4110 | overloaded x3
        public void StartBVector(){} // RVA: 0x7FFAFA0BFBF0
        public void EndWrappedBytes(){} // RVA: 0x7FFAFA0D41D0
        public void UnPack(){} // RVA: 0x7FFAFA0D4220
        public void UnPackTo(){} // RVA: 0x7FFAFA0D42D0
        public void Pack(){} // RVA: 0x7FFAFA0D44E0
    }

    public class WrappedBytesT
    {
        // ── Methods ──
        public void get_B(){} // RVA: 0x7FFAF2DA8380
        public void set_B(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class WrappedBytesVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0C00F0
    }

    public class WrappedDouble
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_D(){} // RVA: 0x7FFAFA0D36D0
        public void CreateWrappedDouble(){} // RVA: 0x7FFAFA0D3700
        public void UnPack(){} // RVA: 0x7FFAFA0D3790
        public void UnPackTo(){} // RVA: 0x7FFAFA0D3810
        public void Pack(){} // RVA: 0x7FFAFA0D3850
    }

    public class WrappedDoubleT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_D(){} // RVA: 0x7FFAF5991B30
        public void set_D(){} // RVA: 0x7FFAF6B5B380
        public void .ctor(){} // RVA: 0x7FFAF3B121F0
    }

    public class WrappedFloat
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_F(){} // RVA: 0x7FFAFA0BEF40
        public void CreateWrappedFloat(){} // RVA: 0x7FFAFA0D3540
        public void UnPack(){} // RVA: 0x7FFAFA0D35D0
        public void UnPackTo(){} // RVA: 0x7FFAFA0BF070
        public void Pack(){} // RVA: 0x7FFAFA0D3640
    }

    public class WrappedFloatT
    {
        // ── Methods ──
        public void get_F(){} // RVA: 0x7FFAF2EB7320
        public void set_F(){} // RVA: 0x7FFAF2EB7330
        public void .ctor(){} // RVA: 0x7FFAF350D070
    }

    public class WrappedInt
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_I(){} // RVA: 0x7FFAFA0BED20
        public void CreateWrappedInt(){} // RVA: 0x7FFAFA0D31E0
        public void UnPack(){} // RVA: 0x7FFAFA0D3270
        public void UnPackTo(){} // RVA: 0x7FFAFA0BEE50
        public void Pack(){} // RVA: 0x7FFAFA0D32E0
    }

    public class WrappedIntT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_I(){} // RVA: 0x7FFAF2DDA5C0
        public void set_I(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF350D070
    }

    public class WrappedLong
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsWrappedLong(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_L(){} // RVA: 0x7FFAFA0D2440
        public void CreateWrappedLong(){} // RVA: 0x7FFAFA0D2490
        public void StartWrappedLong(){} // RVA: 0x7FFAFA0BF310
        public void AddL(){} // RVA: 0x7FFAFA0D2540
        public void EndWrappedLong(){} // RVA: 0x7FFAFA0D25B0
        public void UnPack(){} // RVA: 0x7FFAFA0D2600
        public void UnPackTo(){} // RVA: 0x7FFAFA0D26A0
        public void Pack(){} // RVA: 0x7FFAFA0D2700
    }

    public class WrappedLongT
    {
        // ── Methods ──
        public void get_L(){} // RVA: 0x7FFAF2DA8380
        public void set_L(){} // RVA: 0x7FFAF4417700
        public void .ctor(){} // RVA: 0x7FFAF3B121F0
    }

    public class WrappedLongVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0D27C0
    }

    public class WrappedShort
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_S(){} // RVA: 0x7FFAFA0D2E10
        public void CreateWrappedShort(){} // RVA: 0x7FFAFA0D2E40
        public void UnPack(){} // RVA: 0x7FFAFA0D2ED0
        public void UnPackTo(){} // RVA: 0x7FFAFA0D2F40
        public void Pack(){} // RVA: 0x7FFAFA0D2F80
    }

    public class WrappedShortT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_S(){} // RVA: 0x7FFAF46BF720
        public void set_S(){} // RVA: 0x7FFAF46BFA70
        public void .ctor(){} // RVA: 0x7FFAF4822E00
    }

    public class WrappedString
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsWrappedString(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_S(){} // RVA: 0x7FFAFA0BF140
        public void GetSBytes(){} // RVA: 0x7FFAFA0D2AB0
        public void GetSArray(){} // RVA: 0x7FFAFA0D2B20
        public void CreateWrappedString(){} // RVA: 0x7FFAFA0D2B70
        public void StartWrappedString(){} // RVA: 0x7FFAFA0BF310
        public void AddS(){} // RVA: 0x7FFAFA0BF330
        public void EndWrappedString(){} // RVA: 0x7FFAFA0D2BF0
        public void UnPack(){} // RVA: 0x7FFAFA0D2C40
        public void UnPackTo(){} // RVA: 0x7FFAFA0BF4D0
        public void Pack(){} // RVA: 0x7FFAFA0D2D50
    }

    public class WrappedStringT
    {
        // ── Methods ──
        public void get_S(){} // RVA: 0x7FFAF2DA8380
        public void set_S(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class WrappedStringVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0BF600
    }

    public class WrappedUByte
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_U(){} // RVA: 0x7FFAFA0C80E0
        public void CreateWrappedUByte(){} // RVA: 0x7FFAFA0D3C80
        public void UnPack(){} // RVA: 0x7FFAFA0D3D10
        public void UnPackTo(){} // RVA: 0x7FFAFA0D3B90
        public void Pack(){} // RVA: 0x7FFAFA0D3D80
    }

    public class WrappedUByteT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAF2E575E0
        public void set_U(){} // RVA: 0x7FFAF2E575F0
        public void .ctor(){} // RVA: 0x7FFAF316DA00
    }

    public class WrappedUInt
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_U(){} // RVA: 0x7FFAFA0BED20
        public void CreateWrappedUInt(){} // RVA: 0x7FFAFA0D3390
        public void UnPack(){} // RVA: 0x7FFAFA0D3420
        public void UnPackTo(){} // RVA: 0x7FFAFA0BEE50
        public void Pack(){} // RVA: 0x7FFAFA0D3490
    }

    public class WrappedUIntT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAF2DDA5C0
        public void set_U(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF350D070
    }

    public class WrappedULong
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsWrappedULong(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_U(){} // RVA: 0x7FFAFA0D2440
        public void CreateWrappedULong(){} // RVA: 0x7FFAFA0D2850
        public void StartWrappedULong(){} // RVA: 0x7FFAFA0BF310
        public void AddU(){} // RVA: 0x7FFAFA0D2540
        public void EndWrappedULong(){} // RVA: 0x7FFAFA0D2900
        public void UnPack(){} // RVA: 0x7FFAFA0D2950
        public void UnPackTo(){} // RVA: 0x7FFAFA0D26A0
        public void Pack(){} // RVA: 0x7FFAFA0D29F0
    }

    public class WrappedULongT
    {
        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAF2DA8380
        public void set_U(){} // RVA: 0x7FFAF4417700
        public void .ctor(){} // RVA: 0x7FFAF3B121F0
    }

    public class WrappedULongVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0D27C0
    }

    public class WrappedUShort
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_U(){} // RVA: 0x7FFAFA0D2E10
        public void CreateWrappedUShort(){} // RVA: 0x7FFAFA0D3030
        public void UnPack(){} // RVA: 0x7FFAFA0D30C0
        public void UnPackTo(){} // RVA: 0x7FFAFA0D2F40
        public void Pack(){} // RVA: 0x7FFAFA0D3130
    }

    public class WrappedUShortT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_U(){} // RVA: 0x7FFAF46BF720
        public void set_U(){} // RVA: 0x7FFAF46BFA70
        public void .ctor(){} // RVA: 0x7FFAF4822E00
    }

}