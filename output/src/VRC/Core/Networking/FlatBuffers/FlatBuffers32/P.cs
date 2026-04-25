// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 258

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class PhysBoneChain : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_ChainIdA(){} // RVA: 0x7FFAC9DAEDC0
        public void MutateChainIdA(){} // RVA: 0x7FFAC9DAEDF0
        public void get_ChainIdB(){} // RVA: 0x7FFAC9DAEE20
        public void MutateChainIdB(){} // RVA: 0x7FFAC9DAEE50
        public void get_BoneOffset(){} // RVA: 0x7FFAC9DAFB20
        public void MutateBoneOffset(){} // RVA: 0x7FFAC9DAFB50
        public void get_BoneCount(){} // RVA: 0x7FFAC9DAFB80
        public void MutateBoneCount(){} // RVA: 0x7FFAC9DAFBB0
        public void CreatePhysBoneChain(){} // RVA: 0x7FFAC9DAFBE0
        public void UnPack(){} // RVA: 0x7FFAC9DAFD00
        public void UnPackTo(){} // RVA: 0x7FFAC9DAFDD0
        public void Pack(){} // RVA: 0x7FFAC9DAFE60
    }

    public class PhysBoneChainT : Object
    {
        public ulong ChainIdA; // 0x10
        public ulong ChainIdB; // 0x18
        public ushort BoneOffset; // 0x20
        public byte BoneCount; // 0x22

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7FFAC2F3C380
        public void set_ChainIdA(){} // RVA: 0x7FFAC441EFB0
        public void get_ChainIdB(){} // RVA: 0x7FFAC2F247C0
        public void set_ChainIdB(){} // RVA: 0x7FFAC38920D0
        public void get_BoneOffset(){} // RVA: 0x7FFAC6D68C80
        public void set_BoneOffset(){} // RVA: 0x7FFAC8258410
        public void get_BoneCount(){} // RVA: 0x7FFAC45F8AA0
        public void set_BoneCount(){} // RVA: 0x7FFAC3F5A420
        public void .ctor(){} // RVA: 0x7FFAC9DAFEA0
    }

    public class PhysBoneGrab : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_ChainIdA(){} // RVA: 0x7FFAC9DAEDC0
        public void MutateChainIdA(){} // RVA: 0x7FFAC9DAEDF0
        public void get_ChainIdB(){} // RVA: 0x7FFAC9DAEE20
        public void MutateChainIdB(){} // RVA: 0x7FFAC9DAEE50
        public void get_Bone(){} // RVA: 0x7FFAC9DAEE80
        public void MutateBone(){} // RVA: 0x7FFAC9DAEEB0
        public void get_Offset(){} // RVA: 0x7FFAC9DAEEE0
        public void CreatePhysBoneGrab(){} // RVA: 0x7FFAC9DAEF20
        public void UnPack(){} // RVA: 0x7FFAC9DAF0A0
        public void UnPackTo(){} // RVA: 0x7FFAC9DAF110
        public void Pack(){} // RVA: 0x7FFAC9DAF220
    }

    public class PhysBoneGrabT : Object
    {
        public ulong ChainIdA; // 0x10
        public ulong ChainIdB; // 0x18
        public byte Bone; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector3T Offset; // 0x28

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7FFAC2F3C380
        public void set_ChainIdA(){} // RVA: 0x7FFAC441EFB0
        public void get_ChainIdB(){} // RVA: 0x7FFAC2F247C0
        public void set_ChainIdB(){} // RVA: 0x7FFAC38920D0
        public void get_Bone(){} // RVA: 0x7FFAC300F9D0
        public void set_Bone(){} // RVA: 0x7FFAC300F9E0
        public void get_Offset(){} // RVA: 0x7FFAC2F4F130
        public void set_Offset(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFAC9DAF290
    }

    public class PhysBoneRecorder : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsPhysBoneRecorder(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void VerifyPhysBoneRecorder(){} // RVA: 0x7FFAC9DAFEC0
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Chains(){} // RVA: 0x7FFAC9DAFFB0
        public void get_ChainsLength(){} // RVA: 0x7FFAC9DA6550
        public void Bones(){} // RVA: 0x7FFAC9DB0110
        public void get_BonesLength(){} // RVA: 0x7FFAC9DA72E0
        public void get_GrabL(){} // RVA: 0x7FFAC9DB0260
        public void get_GrabR(){} // RVA: 0x7FFAC9DB0370
        public void CreatePhysBoneRecorder(){} // RVA: 0x7FFAC9DB0480
        public void StartPhysBoneRecorder(){} // RVA: 0x7FFAC9DAB830
        public void AddChains(){} // RVA: 0x7FFAC9DA6190
        public void StartChainsVector(){} // RVA: 0x7FFAC9DB0630
        public void AddBones(){} // RVA: 0x7FFAC9DA7690
        public void StartBonesVector(){} // RVA: 0x7FFAC9DB0660
        public void AddGrabL(){} // RVA: 0x7FFAC9DB0690
        public void AddGrabR(){} // RVA: 0x7FFAC9DB06C0
        public void EndPhysBoneRecorder(){} // RVA: 0x7FFAC9DB06F0
        public void FinishPhysBoneRecorderBuffer(){} // RVA: 0x7FFAC9DA7980
        public void FinishSizePrefixedPhysBoneRecorderBuffer(){} // RVA: 0x7FFAC9DA79E0
        public void UnPack(){} // RVA: 0x7FFAC9DB0740
        public void UnPackTo(){} // RVA: 0x7FFAC9DB07B0
        public void Pack(){} // RVA: 0x7FFAC9DB0DA0
    }

    public class PhysBoneRecorderT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneChainT> Chains; // 0x10
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneTransformT> Bones; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneGrabT GrabL; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneGrabT GrabR; // 0x28

        // ── Methods ──
        public void get_Chains(){} // RVA: 0x7FFAC2F3C380
        public void set_Chains(){} // RVA: 0x7FFAC2F22E30
        public void get_Bones(){} // RVA: 0x7FFAC2F247C0
        public void set_Bones(){} // RVA: 0x7FFAC2F87E80
        public void get_GrabL(){} // RVA: 0x7FFAC2F4F0C0
        public void set_GrabL(){} // RVA: 0x7FFAC2F4F0D0
        public void get_GrabR(){} // RVA: 0x7FFAC2F4F130
        public void set_GrabR(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFAC9DB1180
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9DB1350
        public void SerializeToBinary(){} // RVA: 0x7FFAC9DB1440
    }

    public class PhysBoneRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB1540
    }

    public class PhysBoneTransform : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_BoneId(){} // RVA: 0x7FFAC9DAF330
        public void MutateBoneId(){} // RVA: 0x7FFAC9DA58E0
        public void get_Position(){} // RVA: 0x7FFAC9D88A10
        public void get_Rotation(){} // RVA: 0x7FFAC9DAF360
        public void CreatePhysBoneTransform(){} // RVA: 0x7FFAC9DAF3A0
        public void UnPack(){} // RVA: 0x7FFAC9DAF520
        public void UnPackTo(){} // RVA: 0x7FFAC9DAF6B0
        public void Pack(){} // RVA: 0x7FFAC9DAF8A0
    }

    public class PhysBoneTransformT : Object
    {
        public byte BoneId; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.FloatHalfT Position; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.QuaternionTenBitT Rotation; // 0x20

        // ── Methods ──
        public void get_BoneId(){} // RVA: 0x7FFAC2FEB5E0
        public void set_BoneId(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Position(){} // RVA: 0x7FFAC2F247C0
        public void set_Position(){} // RVA: 0x7FFAC2F87E80
        public void get_Rotation(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Rotation(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9DAF9E0
    }

    public class PlayerData : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsPlayerData(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Pairs(){} // RVA: 0x7FFAC9DB5D20
        public void get_PairsLength(){} // RVA: 0x7FFAC9DA6550
        public void CreatePlayerData(){} // RVA: 0x7FFAC9DB5E90
        public void StartPlayerData(){} // RVA: 0x7FFAC9DA6170
        public void AddPairs(){} // RVA: 0x7FFAC9DA6190
        public void CreatePairsVector(){} // RVA: 0x7FFAC9D9D690
        public void CreatePairsVectorBlock(){} // RVA: 0x7FFAC9DB6150 | overloaded x3
        public void StartPairsVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndPlayerData(){} // RVA: 0x7FFAC9DB6210
        public void UnPack(){} // RVA: 0x7FFAC9DB6260
        public void UnPackTo(){} // RVA: 0x7FFAC9DB6310
        public void Pack(){} // RVA: 0x7FFAC9DB6570
    }

    public class PlayerDataPair : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Key(){} // RVA: 0x7FFAC9DA5FA0
        public void GetKeyBytes(){} // RVA: 0x7FFAC9DB3AF0
        public void GetKeyArray(){} // RVA: 0x7FFAC9DB3B60
        public void get_ValueType(){} // RVA: 0x7FFAC9DB3BB0
        public void Value(){} // RVA: 0x7FFAC2E8DC40
        public void ValueAsVector2(){} // RVA: 0x7FFAC9DB3C00
        public void ValueAsVector3(){} // RVA: 0x7FFAC9DB3C90
        public void ValueAsVector4(){} // RVA: 0x7FFAC9DB3D20
        public void ValueAsQuaternion(){} // RVA: 0x7FFAC9DB3DB0
        public void ValueAsColor(){} // RVA: 0x7FFAC9DB3E40
        public void ValueAsColor32(){} // RVA: 0x7FFAC9DB3ED0
        public void ValueAsWrappedString(){} // RVA: 0x7FFAC9DB3F60
        public void ValueAsWrappedShort(){} // RVA: 0x7FFAC9DB3FF0
        public void ValueAsWrappedInt(){} // RVA: 0x7FFAC9DB4080
        public void ValueAsWrappedFloat(){} // RVA: 0x7FFAC9DB4110
        public void ValueAsWrappedBool(){} // RVA: 0x7FFAC9DB41A0
        public void ValueAsWrappedByte(){} // RVA: 0x7FFAC9DB4230
        public void ValueAsWrappedBytes(){} // RVA: 0x7FFAC9DB42C0
        public void ValueAsWrappedUShort(){} // RVA: 0x7FFAC9DB4350
        public void ValueAsWrappedUByte(){} // RVA: 0x7FFAC9DB43E0
        public void ValueAsWrappedUInt(){} // RVA: 0x7FFAC9DB4470
        public void ValueAsWrappedULong(){} // RVA: 0x7FFAC9DB4500
        public void ValueAsWrappedDouble(){} // RVA: 0x7FFAC9DB4590
        public void ValueAsWrappedLong(){} // RVA: 0x7FFAC9DB4620
        public void CreatePlayerDataPair(){} // RVA: 0x7FFAC9DB46B0
        public void StartPlayerDataPair(){} // RVA: 0x7FFAC9DAD1E0
        public void AddKey(){} // RVA: 0x7FFAC9DA6190
        public void AddValueType(){} // RVA: 0x7FFAC9DB47C0
        public void AddValue(){} // RVA: 0x7FFAC9DA26A0
        public void EndPlayerDataPair(){} // RVA: 0x7FFAC9DB4830
        public void UnPack(){} // RVA: 0x7FFAC9DB4880
        public void UnPackTo(){} // RVA: 0x7FFAC9DB48F0
        public void Pack(){} // RVA: 0x7FFAC9DB5980
    }

    public class PlayerDataPairT : Object
    {
        public string Key; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PlayerDataTypeUnion Value; // 0x18

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAC2F3C380
        public void set_Key(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D84070
    }

    public class PlayerDataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB5AF0
    }

    public class PlayerDataT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PlayerDataPairT> Pairs; // 0x10

        // ── Methods ──
        public void get_Pairs(){} // RVA: 0x7FFAC2F3C380
        public void set_Pairs(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class PlayerDataTypeUnion : Object
    {
        public 0x6B200AC8 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsVector2(){} // RVA: 0x7FFAC9DB1660
        public void FromVector2(){} // RVA: 0x7FFAC9DB16A0
        public void AsVector3(){} // RVA: 0x7FFAC9DB17A0
        public void FromVector3(){} // RVA: 0x7FFAC9DB17E0
        public void AsVector4(){} // RVA: 0x7FFAC9DB18E0
        public void FromVector4(){} // RVA: 0x7FFAC9DB1920
        public void AsQuaternion(){} // RVA: 0x7FFAC9DB1A20
        public void FromQuaternion(){} // RVA: 0x7FFAC9DB1A60
        public void AsColor(){} // RVA: 0x7FFAC9DB1B60
        public void FromColor(){} // RVA: 0x7FFAC9DB1BA0
        public void AsColor32(){} // RVA: 0x7FFAC9DB1CA0
        public void FromColor32(){} // RVA: 0x7FFAC9DB1CE0
        public void AsWrappedString(){} // RVA: 0x7FFAC9DB1DE0
        public void FromWrappedString(){} // RVA: 0x7FFAC9DB1E20
        public void AsWrappedShort(){} // RVA: 0x7FFAC9DB1F20
        public void FromWrappedShort(){} // RVA: 0x7FFAC9DB1F60
        public void AsWrappedInt(){} // RVA: 0x7FFAC9DB2060
        public void FromWrappedInt(){} // RVA: 0x7FFAC9DB20A0
        public void AsWrappedFloat(){} // RVA: 0x7FFAC9DB21A0
        public void FromWrappedFloat(){} // RVA: 0x7FFAC9DB21E0
        public void AsWrappedBool(){} // RVA: 0x7FFAC9DB22E0
        public void FromWrappedBool(){} // RVA: 0x7FFAC9DB2320
        public void AsWrappedByte(){} // RVA: 0x7FFAC9DB2420
        public void FromWrappedByte(){} // RVA: 0x7FFAC9DB2460
        public void AsWrappedBytes(){} // RVA: 0x7FFAC9DB2560
        public void FromWrappedBytes(){} // RVA: 0x7FFAC9DB25A0
        public void AsWrappedUShort(){} // RVA: 0x7FFAC9DB26A0
        public void FromWrappedUShort(){} // RVA: 0x7FFAC9DB26E0
        public void AsWrappedUByte(){} // RVA: 0x7FFAC9DB27E0
        public void FromWrappedUByte(){} // RVA: 0x7FFAC9DB2820
        public void AsWrappedUInt(){} // RVA: 0x7FFAC9DB2920
        public void FromWrappedUInt(){} // RVA: 0x7FFAC9DB2960
        public void AsWrappedULong(){} // RVA: 0x7FFAC9DB2A60
        public void FromWrappedULong(){} // RVA: 0x7FFAC9DB2AA0
        public void AsWrappedDouble(){} // RVA: 0x7FFAC9DB2BA0
        public void FromWrappedDouble(){} // RVA: 0x7FFAC9DB2BE0
        public void AsWrappedLong(){} // RVA: 0x7FFAC9DB2CE0
        public void FromWrappedLong(){} // RVA: 0x7FFAC9DB2D20
        public void Pack(){} // RVA: 0x7FFAC9DB2E20
    }

    public class PlayerDataTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB3750
    }

    public class PlayerDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB67A0
    }

    public class PlayerStationStateData : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void ActiveStations(){} // RVA: 0x7FFAC9DB6870
        public void get_ActiveStationsLength(){} // RVA: 0x7FFAC9DA6550
        public void GetActiveStationsBytes(){} // RVA: 0x7FFAC9DB68F0
        public void GetActiveStationsArray(){} // RVA: 0x7FFAC9DB6960
        public void MutateActiveStations(){} // RVA: 0x7FFAC9DB69B0
        public void CreatePlayerStationStateData(){} // RVA: 0x7FFAC9DB6A40
        public void StartPlayerStationStateData(){} // RVA: 0x7FFAC9DA6170
        public void AddActiveStations(){} // RVA: 0x7FFAC9DA6190
        public void CreateActiveStationsVector(){} // RVA: 0x7FFAC9DAA810
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7FFAC9DB6C60 | overloaded x3
        public void StartActiveStationsVector(){} // RVA: 0x7FFAC9D9DA50
        public void EndPlayerStationStateData(){} // RVA: 0x7FFAC9DB6D20
        public void UnPack(){} // RVA: 0x7FFAC9DB6D70
        public void UnPackTo(){} // RVA: 0x7FFAC9DB6E20
        public void Pack(){} // RVA: 0x7FFAC9DB7040
    }

    public class PlayerStationStateDataT : Object
    {
        public System.Collections.Generic.List`1<uint> ActiveStations; // 0x10

        // ── Methods ──
        public void get_ActiveStations(){} // RVA: 0x7FFAC2F3C380
        public void set_ActiveStations(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class PlayerStationStateDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DB7130
    }

    public class PuppetData : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Channels(){} // RVA: 0x7FFAC9DBC540
        public void MutateChannels(){} // RVA: 0x7FFAC9DBC570
        public void CreatePuppetData(){} // RVA: 0x7FFAC9DBDF50
        public void UnPack(){} // RVA: 0x7FFAC9DBE020
        public void UnPackTo(){} // RVA: 0x7FFAC9DBE090
        public void Pack(){} // RVA: 0x7FFAC9DBE190
    }

    public class PuppetDataT : Object
    {
        public byte[] Channels; // 0x10

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7FFAC2F3C380
        public void set_Channels(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9DBE1B0
    }

}