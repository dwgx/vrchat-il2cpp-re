// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 240

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class PhysBoneChain : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_ChainIdA(){} // RVA: 0x7A7F170F0
        public void get_ChainIdB(){} // RVA: 0x7A7F17120
        public void get_BoneOffset(){} // RVA: 0x7A7F172B0
        public void get_BoneCount(){} // RVA: 0x7A7F172E0
        public void CreatePhysBoneChain(){} // RVA: 0x7AF3F73A0
        public void UnPack(){} // RVA: 0x7A7F17310
        public void UnPackTo(){} // RVA: 0x7A7F17320
        public void Pack(){} // RVA: 0x7AF3F7620
    }

    public class PhysBoneChainT : Object
    {
        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7A80F2570
        public void set_ChainIdA(){} // RVA: 0x7A97242F0
        public void get_ChainIdB(){} // RVA: 0x7A80DA7B0
        public void set_ChainIdB(){} // RVA: 0x7A8A224D0
        public void get_BoneOffset(){} // RVA: 0x7AC2A24B0
        public void set_BoneOffset(){} // RVA: 0x7AD8AE4B0
        public void get_BoneCount(){} // RVA: 0x7A9955EA0
        public void set_BoneCount(){} // RVA: 0x7A9265AF0
        public void .ctor(){} // RVA: 0x7AF3F7660
    }

    public class PhysBoneGrab : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_ChainIdA(){} // RVA: 0x7A7F170F0
        public void get_ChainIdB(){} // RVA: 0x7A7F17120
        public void get_Bone(){} // RVA: 0x7A7F17150
        public void get_Offset(){} // RVA: 0x7A7F17180
        public void CreatePhysBoneGrab(){} // RVA: 0x7AF3F6770
        public void UnPack(){} // RVA: 0x7A7F171C0
        public void UnPackTo(){} // RVA: 0x7A7F171D0
        public void Pack(){} // RVA: 0x7AF3F6A40
    }

    public class PhysBoneGrabT : Object
    {
        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7A80F2570
        public void set_ChainIdA(){} // RVA: 0x7A97242F0
        public void get_ChainIdB(){} // RVA: 0x7A80DA7B0
        public void set_ChainIdB(){} // RVA: 0x7A8A224D0
        public void get_Bone(){} // RVA: 0x7A81C68D0
        public void set_Bone(){} // RVA: 0x7A81C68E0
        public void get_Offset(){} // RVA: 0x7A8105330
        public void set_Offset(){} // RVA: 0x7A80D8E80
        public void .ctor(){} // RVA: 0x7AF3F6AB0
    }

    public class PhysBoneRecorder : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsPhysBoneRecorder(){} // RVA: 0x7AF3E5C00
        public void VerifyPhysBoneRecorder(){} // RVA: 0x7AF3F7680
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Chains(){} // RVA: 0x7A7F173D0
        public void get_ChainsLength(){} // RVA: 0x7A7F166F0
        public void Bones(){} // RVA: 0x7A7F17400
        public void get_BonesLength(){} // RVA: 0x7A7F169F0
        public void get_GrabL(){} // RVA: 0x7A7F17430
        public void get_GrabR(){} // RVA: 0x7A7F17460
        public void CreatePhysBoneRecorder(){} // RVA: 0x7AF3F7C70
        public void StartPhysBoneRecorder(){} // RVA: 0x7AF3F3100
        public void AddChains(){} // RVA: 0x7AF3EDC10
        public void StartChainsVector(){} // RVA: 0x7AF3F7E20
        public void AddBones(){} // RVA: 0x7AF3EF0B0
        public void StartBonesVector(){} // RVA: 0x7AF3F7E50
        public void AddGrabL(){} // RVA: 0x7AF3F7E80
        public void AddGrabR(){} // RVA: 0x7AF3F7EB0
        public void EndPhysBoneRecorder(){} // RVA: 0x7AF3F7EE0
        public void FinishPhysBoneRecorderBuffer(){} // RVA: 0x7AF3EF3A0
        public void FinishSizePrefixedPhysBoneRecorderBuffer(){} // RVA: 0x7AF3EF400
        public void UnPack(){} // RVA: 0x7A7F17490
        public void UnPackTo(){} // RVA: 0x7A7F174A0
        public void Pack(){} // RVA: 0x7AF3F8590
    }

    public class PhysBoneRecorderT : Object
    {
        // ── Methods ──
        public void get_Chains(){} // RVA: 0x7A80F2570
        public void set_Chains(){} // RVA: 0x7A80D8E20
        public void get_Bones(){} // RVA: 0x7A80DA7B0
        public void set_Bones(){} // RVA: 0x7A813E420
        public void get_GrabL(){} // RVA: 0x7A81052C0
        public void set_GrabL(){} // RVA: 0x7A81052D0
        public void get_GrabR(){} // RVA: 0x7A8105330
        public void set_GrabR(){} // RVA: 0x7A80D8E80
        public void .ctor(){} // RVA: 0x7AF3F8AF0
        public void DeserializeFromBinary(){} // RVA: 0x7AF3F8CC0
        public void SerializeToBinary(){} // RVA: 0x7AF3F8DB0
    }

    public class PhysBoneRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F8EB0
    }

    public class PhysBoneTransform : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_BoneId(){} // RVA: 0x7A7F17200
        public void get_Position(){} // RVA: 0x7A7F142E0
        public void get_Rotation(){} // RVA: 0x7A7F17230
        public void CreatePhysBoneTransform(){} // RVA: 0x7AF3F6BC0
        public void UnPack(){} // RVA: 0x7A7F17270
        public void UnPackTo(){} // RVA: 0x7A7F17280
        public void Pack(){} // RVA: 0x7AF3F70C0
    }

    public class PhysBoneTransformT : Object
    {
        // ── Methods ──
        public void get_BoneId(){} // RVA: 0x7A81A2200
        public void set_BoneId(){} // RVA: 0x7A81A2210
        public void get_Position(){} // RVA: 0x7A80DA7B0
        public void set_Position(){} // RVA: 0x7A813E420
        public void get_Rotation(){} // RVA: 0x7A81052C0
        public void set_Rotation(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AF3F7200
    }

    public class PlayerData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsPlayerData(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Pairs(){} // RVA: 0x7A7F180D0
        public void get_PairsLength(){} // RVA: 0x7A7F166F0
        public void CreatePlayerData(){} // RVA: 0x7AF3FD6F0
        public void StartPlayerData(){} // RVA: 0x7AF3EDBF0
        public void AddPairs(){} // RVA: 0x7AF3EDC10
        public void CreatePairsVector(){} // RVA: 0x7AF3E65E0
        public void CreatePairsVectorBlock(){} // RVA: 0x7AF3FD9B0
        public void StartPairsVector(){} // RVA: 0x7AF3E69C0
        public void EndPlayerData(){} // RVA: 0x7AF3FDA70
        public void UnPack(){} // RVA: 0x7A7F18100
        public void UnPackTo(){} // RVA: 0x7A7F18110
        public void Pack(){} // RVA: 0x7AF3FDDE0
    }

    public class PlayerDataPair : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Key(){} // RVA: 0x7A7F16590
        public void GetKeyBytes(){} // RVA: 0x7A7F174D0
        public void GetKeyArray(){} // RVA: 0x7A7F17540
        public void get_ValueType(){} // RVA: 0x7A7F17590
        public void Value(){} // RVA: 0x7A8051B10
        public void ValueAsVector2(){} // RVA: 0x7A7F175E0
        public void ValueAsVector3(){} // RVA: 0x7A7F17670
        public void ValueAsVector4(){} // RVA: 0x7A7F17700
        public void ValueAsQuaternion(){} // RVA: 0x7A7F17790
        public void ValueAsColor(){} // RVA: 0x7A7F17820
        public void ValueAsColor32(){} // RVA: 0x7A7F178B0
        public void ValueAsWrappedString(){} // RVA: 0x7A7F17940
        public void ValueAsWrappedShort(){} // RVA: 0x7A7F179D0
        public void ValueAsWrappedInt(){} // RVA: 0x7A7F17A60
        public void ValueAsWrappedFloat(){} // RVA: 0x7A7F17AF0
        public void ValueAsWrappedBool(){} // RVA: 0x7A7F17B80
        public void ValueAsWrappedByte(){} // RVA: 0x7A7F17C10
        public void ValueAsWrappedBytes(){} // RVA: 0x7A7F17CA0
        public void ValueAsWrappedUShort(){} // RVA: 0x7A7F17D30
        public void ValueAsWrappedUByte(){} // RVA: 0x7A7F17DC0
        public void ValueAsWrappedUInt(){} // RVA: 0x7A7F17E50
        public void ValueAsWrappedULong(){} // RVA: 0x7A7F17EE0
        public void ValueAsWrappedDouble(){} // RVA: 0x7A7F17F70
        public void ValueAsWrappedLong(){} // RVA: 0x7A7F18000
        public void CreatePlayerDataPair(){} // RVA: 0x7AF3FC000
        public void StartPlayerDataPair(){} // RVA: 0x7AF3F4A70
        public void AddKey(){} // RVA: 0x7AF3EDC10
        public void AddValueType(){} // RVA: 0x7AF3FC110
        public void AddValue(){} // RVA: 0x7AF3EA160
        public void EndPlayerDataPair(){} // RVA: 0x7AF3FC180
        public void UnPack(){} // RVA: 0x7A7F18090
        public void UnPackTo(){} // RVA: 0x7A7F180A0
        public void Pack(){} // RVA: 0x7AF3FD2E0
    }

    public class PlayerDataPairT : Object
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7A80F2570
        public void set_Key(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3CD570
    }

    public class PlayerDataPairVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3FD450
    }

    public class PlayerDataT : Object
    {
        // ── Methods ──
        public void get_Pairs(){} // RVA: 0x7A80F2570
        public void set_Pairs(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class PlayerDataTypeUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsVector2(){} // RVA: 0x7AF3F8FD0
        public void FromVector2(){} // RVA: 0x7AF3F9010
        public void AsVector3(){} // RVA: 0x7AF3F9110
        public void FromVector3(){} // RVA: 0x7AF3F9150
        public void AsVector4(){} // RVA: 0x7AF3F9250
        public void FromVector4(){} // RVA: 0x7AF3F9290
        public void AsQuaternion(){} // RVA: 0x7AF3F9390
        public void FromQuaternion(){} // RVA: 0x7AF3F93D0
        public void AsColor(){} // RVA: 0x7AF3F94D0
        public void FromColor(){} // RVA: 0x7AF3F9510
        public void AsColor32(){} // RVA: 0x7AF3F9610
        public void FromColor32(){} // RVA: 0x7AF3F9650
        public void AsWrappedString(){} // RVA: 0x7AF3F9750
        public void FromWrappedString(){} // RVA: 0x7AF3F9790
        public void AsWrappedShort(){} // RVA: 0x7AF3F9890
        public void FromWrappedShort(){} // RVA: 0x7AF3F98D0
        public void AsWrappedInt(){} // RVA: 0x7AF3F99D0
        public void FromWrappedInt(){} // RVA: 0x7AF3F9A10
        public void AsWrappedFloat(){} // RVA: 0x7AF3F9B10
        public void FromWrappedFloat(){} // RVA: 0x7AF3F9B50
        public void AsWrappedBool(){} // RVA: 0x7AF3F9C50
        public void FromWrappedBool(){} // RVA: 0x7AF3F9C90
        public void AsWrappedByte(){} // RVA: 0x7AF3F9D90
        public void FromWrappedByte(){} // RVA: 0x7AF3F9DD0
        public void AsWrappedBytes(){} // RVA: 0x7AF3F9ED0
        public void FromWrappedBytes(){} // RVA: 0x7AF3F9F10
        public void AsWrappedUShort(){} // RVA: 0x7AF3FA010
        public void FromWrappedUShort(){} // RVA: 0x7AF3FA050
        public void AsWrappedUByte(){} // RVA: 0x7AF3FA150
        public void FromWrappedUByte(){} // RVA: 0x7AF3FA190
        public void AsWrappedUInt(){} // RVA: 0x7AF3FA290
        public void FromWrappedUInt(){} // RVA: 0x7AF3FA2D0
        public void AsWrappedULong(){} // RVA: 0x7AF3FA3D0
        public void FromWrappedULong(){} // RVA: 0x7AF3FA410
        public void AsWrappedDouble(){} // RVA: 0x7AF3FA510
        public void FromWrappedDouble(){} // RVA: 0x7AF3FA550
        public void AsWrappedLong(){} // RVA: 0x7AF3FA650
        public void FromWrappedLong(){} // RVA: 0x7AF3FA690
        public void Pack(){} // RVA: 0x7AF3FA790
    }

    public class PlayerDataTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3FB0A0
    }

    public class PlayerDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3FE030
    }

    public class PlayerStationStateData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void ActiveStations(){} // RVA: 0x7A7F18140
        public void get_ActiveStationsLength(){} // RVA: 0x7A7F166F0
        public void GetActiveStationsBytes(){} // RVA: 0x7A7F18150
        public void GetActiveStationsArray(){} // RVA: 0x7A7F181C0
        public void CreatePlayerStationStateData(){} // RVA: 0x7AF3FE240
        public void StartPlayerStationStateData(){} // RVA: 0x7AF3EDBF0
        public void AddActiveStations(){} // RVA: 0x7AF3EDC10
        public void CreateActiveStationsVector(){} // RVA: 0x7AF3F2140
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7AF3FE460
        public void StartActiveStationsVector(){} // RVA: 0x7AF3E69C0
        public void EndPlayerStationStateData(){} // RVA: 0x7AF3FE520
        public void UnPack(){} // RVA: 0x7A7F18210
        public void UnPackTo(){} // RVA: 0x7A7F18220
        public void Pack(){} // RVA: 0x7AF3FE840
    }

    public class PlayerStationStateDataT : Object
    {
        // ── Methods ──
        public void get_ActiveStations(){} // RVA: 0x7A80F2570
        public void set_ActiveStations(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class PlayerStationStateDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3FE930
    }

    public class PuppetData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Channels(){} // RVA: 0x7A7F18B80
        public void CreatePuppetData(){} // RVA: 0x7AF405510
        public void UnPack(){} // RVA: 0x7A7F19140
        public void UnPackTo(){} // RVA: 0x7A7F19150
        public void Pack(){} // RVA: 0x7AF405770
    }

    public class PuppetDataT : Object
    {
        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7A80F2570
        public void set_Channels(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF405790
    }

}