// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 248

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class PhysBoneChain
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_ChainIdA(){} // RVA: 0x7FFAFA0C7C30
        public void get_ChainIdB(){} // RVA: 0x7FFAFA0C7C60
        public void get_BoneOffset(){} // RVA: 0x7FFAFA0C88D0
        public void get_BoneCount(){} // RVA: 0x7FFAFA0C8900
        public void CreatePhysBoneChain(){} // RVA: 0x7FFAFA0C8930
        public void UnPack(){} // RVA: 0x7FFAFA0C8A50
        public void UnPackTo(){} // RVA: 0x7FFAFA0C8B20
        public void Pack(){} // RVA: 0x7FFAFA0C8BB0
    }

    public class PhysBoneChainT
    {
        public object ByteBuffer;
        public object ChainsLength;
        public object BonesLength;
        public object GrabL;

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7FFAF2DA8380
        public void set_ChainIdA(){} // RVA: 0x7FFAF4417700
        public void get_ChainIdB(){} // RVA: 0x7FFAF2D907C0
        public void set_ChainIdB(){} // RVA: 0x7FFAF370BE60
        public void get_BoneOffset(){} // RVA: 0x7FFAF6F64370
        public void set_BoneOffset(){} // RVA: 0x7FFAF8570F20
        public void get_BoneCount(){} // RVA: 0x7FFAF4647EB0
        public void set_BoneCount(){} // RVA: 0x7FFAF3F5D720
        public void .ctor(){} // RVA: 0x7FFAFA0C8BF0
    }

    public class PhysBoneGrab
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_ChainIdA(){} // RVA: 0x7FFAFA0C7C30
        public void get_ChainIdB(){} // RVA: 0x7FFAFA0C7C60
        public void get_Bone(){} // RVA: 0x7FFAFA0C7C90
        public void get_Offset(){} // RVA: 0x7FFAFA0C7CC0
        public void CreatePhysBoneGrab(){} // RVA: 0x7FFAFA0C7D00
        public void UnPack(){} // RVA: 0x7FFAFA0C7E50
        public void UnPackTo(){} // RVA: 0x7FFAFA0C7EC0
        public void Pack(){} // RVA: 0x7FFAFA0C7FD0
    }

    public class PhysBoneGrabT
    {
        public object ByteBuffer;
        public object BoneId;
        public object Position;
        public object Rotation;

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x7FFAF2DA8380
        public void set_ChainIdA(){} // RVA: 0x7FFAF4417700
        public void get_ChainIdB(){} // RVA: 0x7FFAF2D907C0
        public void set_ChainIdB(){} // RVA: 0x7FFAF370BE60
        public void get_Bone(){} // RVA: 0x7FFAF2E7B9D0
        public void set_Bone(){} // RVA: 0x7FFAF2E7B9E0
        public void get_Offset(){} // RVA: 0x7FFAF2DBB130
        public void set_Offset(){} // RVA: 0x7FFAF2D8EE90
        public void .ctor(){} // RVA: 0x7FFAFA0C8040
    }

    public class PhysBoneRecorder
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsPhysBoneRecorder(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void VerifyPhysBoneRecorder(){} // RVA: 0x7FFAFA0C8C10
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Chains(){} // RVA: 0x7FFAFA0C8D00
        public void get_ChainsLength(){} // RVA: 0x7FFAFA0BF6F0
        public void Bones(){} // RVA: 0x7FFAFA0C8E60
        public void get_BonesLength(){} // RVA: 0x7FFAFA0C03F0
        public void get_GrabL(){} // RVA: 0x7FFAFA0C8FB0
        public void get_GrabR(){} // RVA: 0x7FFAFA0C90C0
        public void CreatePhysBoneRecorder(){} // RVA: 0x7FFAFA0C91D0
        public void StartPhysBoneRecorder(){} // RVA: 0x7FFAFA0C4700
        public void AddChains(){} // RVA: 0x7FFAFA0BF330
        public void StartChainsVector(){} // RVA: 0x7FFAFA0C9380
        public void AddBones(){} // RVA: 0x7FFAFA0C07A0
        public void StartBonesVector(){} // RVA: 0x7FFAFA0C93B0
        public void AddGrabL(){} // RVA: 0x7FFAFA0C93E0
        public void AddGrabR(){} // RVA: 0x7FFAFA0C9410
        public void EndPhysBoneRecorder(){} // RVA: 0x7FFAFA0C9440
        public void FinishPhysBoneRecorderBuffer(){} // RVA: 0x7FFAFA0C0A90
        public void FinishSizePrefixedPhysBoneRecorderBuffer(){} // RVA: 0x7FFAFA0C0AF0
        public void UnPack(){} // RVA: 0x7FFAFA0C9490
        public void UnPackTo(){} // RVA: 0x7FFAFA0C9500
        public void Pack(){} // RVA: 0x7FFAFA0C9AF0
    }

    public class PhysBoneRecorderT
    {
        // ── Methods ──
        public void get_Chains(){} // RVA: 0x7FFAF2DA8380
        public void set_Chains(){} // RVA: 0x7FFAF2D8EE30
        public void get_Bones(){} // RVA: 0x7FFAF2D907C0
        public void set_Bones(){} // RVA: 0x7FFAF2DF3E80
        public void get_GrabL(){} // RVA: 0x7FFAF2DBB0C0
        public void set_GrabL(){} // RVA: 0x7FFAF2DBB0D0
        public void get_GrabR(){} // RVA: 0x7FFAF2DBB130
        public void set_GrabR(){} // RVA: 0x7FFAF2D8EE90
        public void .ctor(){} // RVA: 0x7FFAFA0C9ED0
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0CA0A0
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0CA190
    }

    public class PhysBoneRecorderVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0CA290
    }

    public class PhysBoneTransform
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_BoneId(){} // RVA: 0x7FFAFA0C80E0
        public void get_Position(){} // RVA: 0x7FFAFA0A36F0
        public void get_Rotation(){} // RVA: 0x7FFAFA0C8110
        public void CreatePhysBoneTransform(){} // RVA: 0x7FFAFA0C8150
        public void UnPack(){} // RVA: 0x7FFAFA0C82D0
        public void UnPackTo(){} // RVA: 0x7FFAFA0C8460
        public void Pack(){} // RVA: 0x7FFAFA0C8650
    }

    public class PhysBoneTransformT
    {
        public object ByteBuffer;
        public object ChainIdA;
        public object ChainIdB;

        // ── Methods ──
        public void get_BoneId(){} // RVA: 0x7FFAF2E575E0
        public void set_BoneId(){} // RVA: 0x7FFAF2E575F0
        public void get_Position(){} // RVA: 0x7FFAF2D907C0
        public void set_Position(){} // RVA: 0x7FFAF2DF3E80
        public void get_Rotation(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Rotation(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAFA0C8790
    }

    public class PlayerData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsPlayerData(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Pairs(){} // RVA: 0x7FFAFA0CEA50
        public void get_PairsLength(){} // RVA: 0x7FFAFA0BF6F0
        public void CreatePlayerData(){} // RVA: 0x7FFAFA0CEBC0
        public void StartPlayerData(){} // RVA: 0x7FFAFA0BF310
        public void AddPairs(){} // RVA: 0x7FFAFA0BF330
        public void CreatePairsVector(){} // RVA: 0x7FFAFA0B7E30
        public void CreatePairsVectorBlock(){} // RVA: 0x7FFAFA0CEE80 | overloaded x3
        public void StartPairsVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndPlayerData(){} // RVA: 0x7FFAFA0CEF40
        public void UnPack(){} // RVA: 0x7FFAFA0CEF90
        public void UnPackTo(){} // RVA: 0x7FFAFA0CF040
        public void Pack(){} // RVA: 0x7FFAFA0CF2A0
    }

    public class PlayerDataPair
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Key(){} // RVA: 0x7FFAFA0BF140
        public void GetKeyBytes(){} // RVA: 0x7FFAFA0CC820
        public void GetKeyArray(){} // RVA: 0x7FFAFA0CC890
        public void get_ValueType(){} // RVA: 0x7FFAFA0CC8E0
        public void Value(){} // RVA: 0x7FFAF2D33FA0
        public void ValueAsVector2(){} // RVA: 0x7FFAFA0CC930
        public void ValueAsVector3(){} // RVA: 0x7FFAFA0CC9C0
        public void ValueAsVector4(){} // RVA: 0x7FFAFA0CCA50
        public void ValueAsQuaternion(){} // RVA: 0x7FFAFA0CCAE0
        public void ValueAsColor(){} // RVA: 0x7FFAFA0CCB70
        public void ValueAsColor32(){} // RVA: 0x7FFAFA0CCC00
        public void ValueAsWrappedString(){} // RVA: 0x7FFAFA0CCC90
        public void ValueAsWrappedShort(){} // RVA: 0x7FFAFA0CCD20
        public void ValueAsWrappedInt(){} // RVA: 0x7FFAFA0CCDB0
        public void ValueAsWrappedFloat(){} // RVA: 0x7FFAFA0CCE40
        public void ValueAsWrappedBool(){} // RVA: 0x7FFAFA0CCED0
        public void ValueAsWrappedByte(){} // RVA: 0x7FFAFA0CCF60
        public void ValueAsWrappedBytes(){} // RVA: 0x7FFAFA0CCFF0
        public void ValueAsWrappedUShort(){} // RVA: 0x7FFAFA0CD080
        public void ValueAsWrappedUByte(){} // RVA: 0x7FFAFA0CD110
        public void ValueAsWrappedUInt(){} // RVA: 0x7FFAFA0CD1A0
        public void ValueAsWrappedULong(){} // RVA: 0x7FFAFA0CD230
        public void ValueAsWrappedDouble(){} // RVA: 0x7FFAFA0CD2C0
        public void ValueAsWrappedLong(){} // RVA: 0x7FFAFA0CD350
        public void CreatePlayerDataPair(){} // RVA: 0x7FFAFA0CD3E0
        public void StartPlayerDataPair(){} // RVA: 0x7FFAFA0C6050
        public void AddKey(){} // RVA: 0x7FFAFA0BF330
        public void AddValueType(){} // RVA: 0x7FFAFA0CD4F0
        public void AddValue(){} // RVA: 0x7FFAFA0BB900
        public void EndPlayerDataPair(){} // RVA: 0x7FFAFA0CD560
        public void UnPack(){} // RVA: 0x7FFAFA0CD5B0
        public void UnPackTo(){} // RVA: 0x7FFAFA0CD620
        public void Pack(){} // RVA: 0x7FFAFA0CE6B0
    }

    public class PlayerDataPairT
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAF2DA8380
        public void set_Key(){} // RVA: 0x7FFAF2D8EE30
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA09EF50
    }

    public class PlayerDataPairVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0CE820
    }

    public class PlayerDataT
    {
        // ── Methods ──
        public void get_Pairs(){} // RVA: 0x7FFAF2DA8380
        public void set_Pairs(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class PlayerDataTypeUnion
    {
        public object inputIsActive;
        public object active;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void set_Type(){} // RVA: 0x7FFAF2E575F0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA08FAD0
        public void As(){} // RVA: 0x7FFAF2D33FA0
        public void AsVector2(){} // RVA: 0x7FFAFA0CA3B0
        public void FromVector2(){} // RVA: 0x7FFAFA0CA3F0
        public void AsVector3(){} // RVA: 0x7FFAFA0CA4F0
        public void FromVector3(){} // RVA: 0x7FFAFA0CA530
        public void AsVector4(){} // RVA: 0x7FFAFA0CA630
        public void FromVector4(){} // RVA: 0x7FFAFA0CA670
        public void AsQuaternion(){} // RVA: 0x7FFAFA0CA770
        public void FromQuaternion(){} // RVA: 0x7FFAFA0CA7B0
        public void AsColor(){} // RVA: 0x7FFAFA0CA8B0
        public void FromColor(){} // RVA: 0x7FFAFA0CA8F0
        public void AsColor32(){} // RVA: 0x7FFAFA0CA9F0
        public void FromColor32(){} // RVA: 0x7FFAFA0CAA30
        public void AsWrappedString(){} // RVA: 0x7FFAFA0CAB30
        public void FromWrappedString(){} // RVA: 0x7FFAFA0CAB70
        public void AsWrappedShort(){} // RVA: 0x7FFAFA0CAC70
        public void FromWrappedShort(){} // RVA: 0x7FFAFA0CACB0
        public void AsWrappedInt(){} // RVA: 0x7FFAFA0CADB0
        public void FromWrappedInt(){} // RVA: 0x7FFAFA0CADF0
        public void AsWrappedFloat(){} // RVA: 0x7FFAFA0CAEF0
        public void FromWrappedFloat(){} // RVA: 0x7FFAFA0CAF30
        public void AsWrappedBool(){} // RVA: 0x7FFAFA0CB030
        public void FromWrappedBool(){} // RVA: 0x7FFAFA0CB070
        public void AsWrappedByte(){} // RVA: 0x7FFAFA0CB170
        public void FromWrappedByte(){} // RVA: 0x7FFAFA0CB1B0
        public void AsWrappedBytes(){} // RVA: 0x7FFAFA0CB2B0
        public void FromWrappedBytes(){} // RVA: 0x7FFAFA0CB2F0
        public void AsWrappedUShort(){} // RVA: 0x7FFAFA0CB3F0
        public void FromWrappedUShort(){} // RVA: 0x7FFAFA0CB430
        public void AsWrappedUByte(){} // RVA: 0x7FFAFA0CB530
        public void FromWrappedUByte(){} // RVA: 0x7FFAFA0CB570
        public void AsWrappedUInt(){} // RVA: 0x7FFAFA0CB670
        public void FromWrappedUInt(){} // RVA: 0x7FFAFA0CB6B0
        public void AsWrappedULong(){} // RVA: 0x7FFAFA0CB7B0
        public void FromWrappedULong(){} // RVA: 0x7FFAFA0CB7F0
        public void AsWrappedDouble(){} // RVA: 0x7FFAFA0CB8F0
        public void FromWrappedDouble(){} // RVA: 0x7FFAFA0CB930
        public void AsWrappedLong(){} // RVA: 0x7FFAFA0CBA30
        public void FromWrappedLong(){} // RVA: 0x7FFAFA0CBA70
        public void Pack(){} // RVA: 0x7FFAFA0CBB70
    }

    public class PlayerDataTypeVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0CC480
    }

    public class PlayerDataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0CF4D0
    }

    public class PlayerStationStateData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void ActiveStations(){} // RVA: 0x7FFAFA0CF5A0
        public void get_ActiveStationsLength(){} // RVA: 0x7FFAFA0BF6F0
        public void GetActiveStationsBytes(){} // RVA: 0x7FFAFA0CF620
        public void GetActiveStationsArray(){} // RVA: 0x7FFAFA0CF690
        public void CreatePlayerStationStateData(){} // RVA: 0x7FFAFA0CF6E0
        public void StartPlayerStationStateData(){} // RVA: 0x7FFAFA0BF310
        public void AddActiveStations(){} // RVA: 0x7FFAFA0BF330
        public void CreateActiveStationsVector(){} // RVA: 0x7FFAFA0C3770
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x7FFAFA0CF900 | overloaded x3
        public void StartActiveStationsVector(){} // RVA: 0x7FFAFA0B81F0
        public void EndPlayerStationStateData(){} // RVA: 0x7FFAFA0CF9C0
        public void UnPack(){} // RVA: 0x7FFAFA0CFA10
        public void UnPackTo(){} // RVA: 0x7FFAFA0CFAC0
        public void Pack(){} // RVA: 0x7FFAFA0CFCE0
    }

    public class PlayerStationStateDataT
    {
        // ── Methods ──
        public void get_ActiveStations(){} // RVA: 0x7FFAF2DA8380
        public void set_ActiveStations(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class PlayerStationStateDataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0CFDD0
    }

    public class PuppetData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Channels(){} // RVA: 0x7FFAFA0D4F80
        public void CreatePuppetData(){} // RVA: 0x7FFAFA0D6890
        public void UnPack(){} // RVA: 0x7FFAFA0D6960
        public void UnPackTo(){} // RVA: 0x7FFAFA0D69D0
        public void Pack(){} // RVA: 0x7FFAFA0D6AD0
    }

    public class PuppetDataT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7FFAF2DA8380
        public void set_Channels(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA0D6AF0
    }

}