// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 240

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class PhysBoneChain : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_ChainIdA(){} // RVA: 0x9BD940
        public void get_ChainIdB(){} // RVA: 0x9BD970
        public void get_BoneOffset(){} // RVA: 0x9BDC40
        public void get_BoneCount(){} // RVA: 0x9BDC70
        public void CreatePhysBoneChain(){} // RVA: 0x8250E70
        public void UnPack(){} // RVA: 0x9BDCA0
        public void UnPackTo(){} // RVA: 0x9BDCB0
        public void Pack(){} // RVA: 0x82510F0
    }

    public class PhysBoneChainT : Object
    {
        public object _chainIdA;
        public object _chainIdB;
        public object _boneOffset;
        public object _boneCount;

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0xB5DBF0
        public void set_ChainIdA(){} // RVA: 0x2230E30
        public void get_ChainIdB(){} // RVA: 0xB465B0
        public void set_ChainIdB(){} // RVA: 0x15428E0
        public void get_BoneOffset(){} // RVA: 0x4FEF950
        public void set_BoneOffset(){} // RVA: 0x653B850
        public void get_BoneCount(){} // RVA: 0x246F130
        public void set_BoneCount(){} // RVA: 0x1AD8C10
        public void .ctor(){} // RVA: 0x8251130
    }

    public class PhysBoneGrab : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_ChainIdA(){} // RVA: 0x9BD940
        public void get_ChainIdB(){} // RVA: 0x9BD970
        public void get_Bone(){} // RVA: 0x9BD9A0
        public void get_Offset(){} // RVA: 0x9BD9D0
        public void CreatePhysBoneGrab(){} // RVA: 0x8250240
        public void UnPack(){} // RVA: 0x9BDA10
        public void UnPackTo(){} // RVA: 0x9BDA20
        public void Pack(){} // RVA: 0x8250510
    }

    public class PhysBoneGrabT : Object
    {
        public object _chainIdA;
        public object _chainIdB;
        public object _bone;
        public object _offset;

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0xB5DBF0
        public void set_ChainIdA(){} // RVA: 0x2230E30
        public void get_ChainIdB(){} // RVA: 0xB465B0
        public void set_ChainIdB(){} // RVA: 0x15428E0
        public void get_Bone(){} // RVA: 0xC38360
        public void set_Bone(){} // RVA: 0xC38370
        public void get_Offset(){} // RVA: 0xB70160
        public void set_Offset(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0x8250580
    }

    public class PhysBoneRecorder : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsPhysBoneRecorder(){} // RVA: 0x823F500
        public void VerifyPhysBoneRecorder(){} // RVA: 0x8251150
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Chains(){} // RVA: 0x9BDE00
        public void get_ChainsLength(){} // RVA: 0x9BC8C0
        public void Bones(){} // RVA: 0x9BDE30
        public void get_BonesLength(){} // RVA: 0x9BCC80
        public void get_GrabL(){} // RVA: 0x9BDE60
        public void get_GrabR(){} // RVA: 0x9BDE90
        public void CreatePhysBoneRecorder(){} // RVA: 0x8251740
        public void StartPhysBoneRecorder(){} // RVA: 0x824CBD0
        public void AddChains(){} // RVA: 0x82476E0
        public void StartChainsVector(){} // RVA: 0x82518F0
        public void AddBones(){} // RVA: 0x8248B80
        public void StartBonesVector(){} // RVA: 0x8251920
        public void AddGrabL(){} // RVA: 0x8251950
        public void AddGrabR(){} // RVA: 0x8251980
        public void EndPhysBoneRecorder(){} // RVA: 0x82519B0
        public void FinishPhysBoneRecorderBuffer(){} // RVA: 0x8248E70
        public void FinishSizePrefixedPhysBoneRecorderBuffer(){} // RVA: 0x8248ED0
        public void UnPack(){} // RVA: 0x9BDEC0
        public void UnPackTo(){} // RVA: 0x9BDED0
        public void Pack(){} // RVA: 0x8252060
    }

    public class PhysBoneRecorderT : Object
    {
        public object _chains;
        public object _bones;
        public object _grabL;
        public object _grabR;

        // ── Methods ──
        public void get_Chains(){} // RVA: 0xB5DBF0
        public void set_Chains(){} // RVA: 0xB44D60
        public void get_Bones(){} // RVA: 0xB465B0
        public void set_Bones(){} // RVA: 0xBA9BA0
        public void get_GrabL(){} // RVA: 0xB700F0
        public void set_GrabL(){} // RVA: 0xB70100
        public void get_GrabR(){} // RVA: 0xB70160
        public void set_GrabR(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0x82525C0
        public void DeserializeFromBinary(){} // RVA: 0x8252790
        public void SerializeToBinary(){} // RVA: 0x8252880
    }

    public class PhysBoneRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8252980
    }

    public class PhysBoneTransform : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_BoneId(){} // RVA: 0x9BDAF0
        public void get_Position(){} // RVA: 0x9B8870
        public void get_Rotation(){} // RVA: 0x9BDB20
        public void CreatePhysBoneTransform(){} // RVA: 0x8250690
        public void UnPack(){} // RVA: 0x9BDB60
        public void UnPackTo(){} // RVA: 0x9BDB70
        public void Pack(){} // RVA: 0x8250B90
    }

    public class PhysBoneTransformT : Object
    {
        public object _boneId;
        public object _position;
        public object _rotation;

        // ── Methods ──
        public void get_BoneId(){} // RVA: 0xC120A0
        public void set_BoneId(){} // RVA: 0xC120B0
        public void get_Position(){} // RVA: 0xB465B0
        public void set_Position(){} // RVA: 0xBA9BA0
        public void get_Rotation(){} // RVA: 0xB700F0
        public void set_Rotation(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x8250CD0
    }

    public class PlayerData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsPlayerData(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Pairs(){} // RVA: 0x9BEC40
        public void get_PairsLength(){} // RVA: 0x9BC8C0
        public void CreatePlayerData(){} // RVA: 0x8257680
        public void StartPlayerData(){} // RVA: 0x82476C0
        public void AddPairs(){} // RVA: 0x82476E0
        public void CreatePairsVector(){} // RVA: 0x823FEE0
        public void CreatePairsVectorBlock(){} // RVA: 0x8257940
        public void StartPairsVector(){} // RVA: 0x82402C0
        public void EndPlayerData(){} // RVA: 0x8257A00
        public void UnPack(){} // RVA: 0x9BEC70
        public void UnPackTo(){} // RVA: 0x9BEC80
        public void Pack(){} // RVA: 0x8257D70
    }

    public class PlayerDataPair : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Key(){} // RVA: 0x9BC6A0
        public void GetKeyBytes(){} // RVA: 0x9BDFA0
        public void GetKeyArray(){} // RVA: 0x9BE010
        public void get_ValueType(){} // RVA: 0x9BE060
        public void Value(){} // RVA: 0xA94080
        public void ValueAsVector2(){} // RVA: 0x9BE0B0
        public void ValueAsVector3(){} // RVA: 0x9BE140
        public void ValueAsVector4(){} // RVA: 0x9BE1D0
        public void ValueAsQuaternion(){} // RVA: 0x9BE260
        public void ValueAsColor(){} // RVA: 0x9BE2F0
        public void ValueAsColor32(){} // RVA: 0x9BE380
        public void ValueAsWrappedString(){} // RVA: 0x9BE410
        public void ValueAsWrappedShort(){} // RVA: 0x9BE4A0
        public void ValueAsWrappedInt(){} // RVA: 0x9BE530
        public void ValueAsWrappedFloat(){} // RVA: 0x9BE5C0
        public void ValueAsWrappedBool(){} // RVA: 0x9BE650
        public void ValueAsWrappedByte(){} // RVA: 0x9BE6E0
        public void ValueAsWrappedBytes(){} // RVA: 0x9BE770
        public void ValueAsWrappedUShort(){} // RVA: 0x9BE800
        public void ValueAsWrappedUByte(){} // RVA: 0x9BE890
        public void ValueAsWrappedUInt(){} // RVA: 0x9BE920
        public void ValueAsWrappedULong(){} // RVA: 0x9BE9B0
        public void ValueAsWrappedDouble(){} // RVA: 0x9BEA40
        public void ValueAsWrappedLong(){} // RVA: 0x9BEAD0
        public void CreatePlayerDataPair(){} // RVA: 0x8255F90
        public void StartPlayerDataPair(){} // RVA: 0x824E540
        public void AddKey(){} // RVA: 0x82476E0
        public void AddValueType(){} // RVA: 0x82560A0
        public void AddValue(){} // RVA: 0x8243A40
        public void EndPlayerDataPair(){} // RVA: 0x8256110
        public void UnPack(){} // RVA: 0x9BEB60
        public void UnPackTo(){} // RVA: 0x9BEB70
        public void Pack(){} // RVA: 0x8257270
    }

    public class PlayerDataPairT : Object
    {
        public object _key;
        public object _value;

        // ── Methods ──
        public void get_Key(){} // RVA: 0xB5DBF0
        public void set_Key(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8225A50
    }

    public class PlayerDataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82573E0
    }

    public class PlayerDataT : Object
    {
        public object _pairs;

        // ── Methods ──
        public void get_Pairs(){} // RVA: 0xB5DBF0
        public void set_Pairs(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class PlayerDataTypeUnion : Object
    {
        public object _type;
        public object _value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsVector2(){} // RVA: 0x8252AA0
        public void FromVector2(){} // RVA: 0x8252B20
        public void AsVector3(){} // RVA: 0x8252C20
        public void FromVector3(){} // RVA: 0x8252CA0
        public void AsVector4(){} // RVA: 0x8252DA0
        public void FromVector4(){} // RVA: 0x8252E20
        public void AsQuaternion(){} // RVA: 0x8252F20
        public void FromQuaternion(){} // RVA: 0x8252FA0
        public void AsColor(){} // RVA: 0x82530A0
        public void FromColor(){} // RVA: 0x8253120
        public void AsColor32(){} // RVA: 0x8253220
        public void FromColor32(){} // RVA: 0x82532A0
        public void AsWrappedString(){} // RVA: 0x82533A0
        public void FromWrappedString(){} // RVA: 0x8253420
        public void AsWrappedShort(){} // RVA: 0x8253520
        public void FromWrappedShort(){} // RVA: 0x82535A0
        public void AsWrappedInt(){} // RVA: 0x82536A0
        public void FromWrappedInt(){} // RVA: 0x8253720
        public void AsWrappedFloat(){} // RVA: 0x8253820
        public void FromWrappedFloat(){} // RVA: 0x82538A0
        public void AsWrappedBool(){} // RVA: 0x82539A0
        public void FromWrappedBool(){} // RVA: 0x8253A20
        public void AsWrappedByte(){} // RVA: 0x8253B20
        public void FromWrappedByte(){} // RVA: 0x8253BA0
        public void AsWrappedBytes(){} // RVA: 0x8253CA0
        public void FromWrappedBytes(){} // RVA: 0x8253D20
        public void AsWrappedUShort(){} // RVA: 0x8253E20
        public void FromWrappedUShort(){} // RVA: 0x8253EA0
        public void AsWrappedUByte(){} // RVA: 0x8253FA0
        public void FromWrappedUByte(){} // RVA: 0x8254020
        public void AsWrappedUInt(){} // RVA: 0x8254120
        public void FromWrappedUInt(){} // RVA: 0x82541A0
        public void AsWrappedULong(){} // RVA: 0x82542A0
        public void FromWrappedULong(){} // RVA: 0x8254320
        public void AsWrappedDouble(){} // RVA: 0x8254420
        public void FromWrappedDouble(){} // RVA: 0x82544A0
        public void AsWrappedLong(){} // RVA: 0x82545A0
        public void FromWrappedLong(){} // RVA: 0x8254620
        public void Pack(){} // RVA: 0x8254720
    }

    public class PlayerDataTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8255030
    }

    public class PlayerDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8257FC0
    }

    public class PlayerStationStateData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void ActiveStations(){} // RVA: 0x9BED50
        public void get_ActiveStationsLength(){} // RVA: 0x9BC8C0
        public void GetActiveStationsBytes(){} // RVA: 0x9BED60
        public void GetActiveStationsArray(){} // RVA: 0x9BEDD0
        public void CreatePlayerStationStateData(){} // RVA: 0x82581D0
        public void StartPlayerStationStateData(){} // RVA: 0x82476C0
        public void AddActiveStations(){} // RVA: 0x82476E0
        public void CreateActiveStationsVector(){} // RVA: 0x824BC10
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x82583F0
        public void StartActiveStationsVector(){} // RVA: 0x82402C0
        public void EndPlayerStationStateData(){} // RVA: 0x82584B0
        public void UnPack(){} // RVA: 0x9BEE20
        public void UnPackTo(){} // RVA: 0x9BEE30
        public void Pack(){} // RVA: 0x82587D0
    }

    public class PlayerStationStateDataT : Object
    {
        public object _activeStations;

        // ── Methods ──
        public void get_ActiveStations(){} // RVA: 0xB5DBF0
        public void set_ActiveStations(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class PlayerStationStateDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82588C0
    }

    public class PuppetData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Channels(){} // RVA: 0x9C0430
        public void CreatePuppetData(){} // RVA: 0x825F7A0
        public void UnPack(){} // RVA: 0x9C0F30
        public void UnPackTo(){} // RVA: 0x9C0F40
        public void Pack(){} // RVA: 0x825FA00
    }

    public class PuppetDataT : Object
    {
        public object _channels;

        // ── Methods ──
        public void get_Channels(){} // RVA: 0xB5DBF0
        public void set_Channels(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x825FA20
    }

}