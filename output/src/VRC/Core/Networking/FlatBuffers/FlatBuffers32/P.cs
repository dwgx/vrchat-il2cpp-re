// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 22
// Methods: 248

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class PhysBoneChain
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_ChainIdA(){} // RVA: 0x7617C30
        public void get_ChainIdB(){} // RVA: 0x7617C60
        public void get_BoneOffset(){} // RVA: 0x76188D0
        public void get_BoneCount(){} // RVA: 0x7618900
        public void CreatePhysBoneChain(){} // RVA: 0x7618930
        public void UnPack(){} // RVA: 0x7618A50
        public void UnPackTo(){} // RVA: 0x7618B20
        public void Pack(){} // RVA: 0x7618BB0
    }

    public class PhysBoneChainT
    {
        public ulong ByteBuffer; // 0x10
        public ulong ChainsLength; // 0x18
        public ushort BonesLength; // 0x20
        public byte GrabL; // 0x22

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x2F8380
        public void set_ChainIdA(){} // RVA: 0x1967700
        public void get_ChainIdB(){} // RVA: 0x2E07C0
        public void set_ChainIdB(){} // RVA: 0xC5BE60
        public void get_BoneOffset(){} // RVA: 0x44B4370
        public void set_BoneOffset(){} // RVA: 0x5AC0F20
        public void get_BoneCount(){} // RVA: 0x1B97EB0
        public void set_BoneCount(){} // RVA: 0x14AD720
        public void .ctor(){} // RVA: 0x7618BF0
    }

    public class PhysBoneGrab
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_ChainIdA(){} // RVA: 0x7617C30
        public void get_ChainIdB(){} // RVA: 0x7617C60
        public void get_Bone(){} // RVA: 0x7617C90
        public void get_Offset(){} // RVA: 0x7617CC0
        public void CreatePhysBoneGrab(){} // RVA: 0x7617D00
        public void UnPack(){} // RVA: 0x7617E50
        public void UnPackTo(){} // RVA: 0x7617EC0
        public void Pack(){} // RVA: 0x7617FD0
    }

    public class PhysBoneGrabT
    {
        public ulong ByteBuffer; // 0x10
        public ulong BoneId; // 0x18
        public byte Position; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector3T Rotation; // 0x28

        // ── Methods ──
        public void get_ChainIdA(){} // RVA: 0x2F8380
        public void set_ChainIdA(){} // RVA: 0x1967700
        public void get_ChainIdB(){} // RVA: 0x2E07C0
        public void set_ChainIdB(){} // RVA: 0xC5BE60
        public void get_Bone(){} // RVA: 0x3CB9D0
        public void set_Bone(){} // RVA: 0x3CB9E0
        public void get_Offset(){} // RVA: 0x30B130
        public void set_Offset(){} // RVA: 0x2DEE90
        public void .ctor(){} // RVA: 0x7618040
    }

    public class PhysBoneRecorder
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsPhysBoneRecorder(){} // RVA: 0x7607450 | overloaded x2
        public void VerifyPhysBoneRecorder(){} // RVA: 0x7618C10
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Chains(){} // RVA: 0x7618D00
        public void get_ChainsLength(){} // RVA: 0x760F6F0
        public void Bones(){} // RVA: 0x7618E60
        public void get_BonesLength(){} // RVA: 0x76103F0
        public void get_GrabL(){} // RVA: 0x7618FB0
        public void get_GrabR(){} // RVA: 0x76190C0
        public void CreatePhysBoneRecorder(){} // RVA: 0x76191D0
        public void StartPhysBoneRecorder(){} // RVA: 0x7614700
        public void AddChains(){} // RVA: 0x760F330
        public void StartChainsVector(){} // RVA: 0x7619380
        public void AddBones(){} // RVA: 0x76107A0
        public void StartBonesVector(){} // RVA: 0x76193B0
        public void AddGrabL(){} // RVA: 0x76193E0
        public void AddGrabR(){} // RVA: 0x7619410
        public void EndPhysBoneRecorder(){} // RVA: 0x7619440
        public void FinishPhysBoneRecorderBuffer(){} // RVA: 0x7610A90
        public void FinishSizePrefixedPhysBoneRecorderBuffer(){} // RVA: 0x7610AF0
        public void UnPack(){} // RVA: 0x7619490
        public void UnPackTo(){} // RVA: 0x7619500
        public void Pack(){} // RVA: 0x7619AF0
    }

    public class PhysBoneRecorderT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneChainT> <Chains>k__BackingField; // 0x10
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneTransformT> <Bones>k__BackingField; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneGrabT <GrabL>k__BackingField; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PhysBoneGrabT <GrabR>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Chains(){} // RVA: 0x2F8380
        public void set_Chains(){} // RVA: 0x2DEE30
        public void get_Bones(){} // RVA: 0x2E07C0
        public void set_Bones(){} // RVA: 0x343E80
        public void get_GrabL(){} // RVA: 0x30B0C0
        public void set_GrabL(){} // RVA: 0x30B0D0
        public void get_GrabR(){} // RVA: 0x30B130
        public void set_GrabR(){} // RVA: 0x2DEE90
        public void .ctor(){} // RVA: 0x7619ED0
        public void DeserializeFromBinary(){} // RVA: 0x761A0A0
        public void SerializeToBinary(){} // RVA: 0x761A190
    }

    public class PhysBoneRecorderVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761A290
    }

    public class PhysBoneTransform
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_BoneId(){} // RVA: 0x76180E0
        public void get_Position(){} // RVA: 0x75F36F0
        public void get_Rotation(){} // RVA: 0x7618110
        public void CreatePhysBoneTransform(){} // RVA: 0x7618150
        public void UnPack(){} // RVA: 0x76182D0
        public void UnPackTo(){} // RVA: 0x7618460
        public void Pack(){} // RVA: 0x7618650
    }

    public class PhysBoneTransformT
    {
        public byte ByteBuffer; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.FloatHalfT ChainIdA; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.QuaternionTenBitT ChainIdB; // 0x20

        // ── Methods ──
        public void get_BoneId(){} // RVA: 0x3A75E0
        public void set_BoneId(){} // RVA: 0x3A75F0
        public void get_Position(){} // RVA: 0x2E07C0
        public void set_Position(){} // RVA: 0x343E80
        public void get_Rotation(){} // RVA: 0x30B0C0
        public void set_Rotation(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x7618790
    }

    public class PlayerData
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsPlayerData(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Pairs(){} // RVA: 0x761EA50
        public void get_PairsLength(){} // RVA: 0x760F6F0
        public void CreatePlayerData(){} // RVA: 0x761EBC0
        public void StartPlayerData(){} // RVA: 0x760F310
        public void AddPairs(){} // RVA: 0x760F330
        public void CreatePairsVector(){} // RVA: 0x7607E30
        public void CreatePairsVectorBlock(){} // RVA: 0x761EE80 | overloaded x3
        public void StartPairsVector(){} // RVA: 0x76081F0
        public void EndPlayerData(){} // RVA: 0x761EF40
        public void UnPack(){} // RVA: 0x761EF90
        public void UnPackTo(){} // RVA: 0x761F040
        public void Pack(){} // RVA: 0x761F2A0
    }

    public class PlayerDataPair
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsPlayerDataPair(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Key(){} // RVA: 0x760F140
        public void GetKeyBytes(){} // RVA: 0x761C820
        public void GetKeyArray(){} // RVA: 0x761C890
        public void get_ValueType(){} // RVA: 0x761C8E0
        public void Value(){} // RVA: 0x283FA0
        public void ValueAsVector2(){} // RVA: 0x761C930
        public void ValueAsVector3(){} // RVA: 0x761C9C0
        public void ValueAsVector4(){} // RVA: 0x761CA50
        public void ValueAsQuaternion(){} // RVA: 0x761CAE0
        public void ValueAsColor(){} // RVA: 0x761CB70
        public void ValueAsColor32(){} // RVA: 0x761CC00
        public void ValueAsWrappedString(){} // RVA: 0x761CC90
        public void ValueAsWrappedShort(){} // RVA: 0x761CD20
        public void ValueAsWrappedInt(){} // RVA: 0x761CDB0
        public void ValueAsWrappedFloat(){} // RVA: 0x761CE40
        public void ValueAsWrappedBool(){} // RVA: 0x761CED0
        public void ValueAsWrappedByte(){} // RVA: 0x761CF60
        public void ValueAsWrappedBytes(){} // RVA: 0x761CFF0
        public void ValueAsWrappedUShort(){} // RVA: 0x761D080
        public void ValueAsWrappedUByte(){} // RVA: 0x761D110
        public void ValueAsWrappedUInt(){} // RVA: 0x761D1A0
        public void ValueAsWrappedULong(){} // RVA: 0x761D230
        public void ValueAsWrappedDouble(){} // RVA: 0x761D2C0
        public void ValueAsWrappedLong(){} // RVA: 0x761D350
        public void CreatePlayerDataPair(){} // RVA: 0x761D3E0
        public void StartPlayerDataPair(){} // RVA: 0x7616050
        public void AddKey(){} // RVA: 0x760F330
        public void AddValueType(){} // RVA: 0x761D4F0
        public void AddValue(){} // RVA: 0x760B900
        public void EndPlayerDataPair(){} // RVA: 0x761D560
        public void UnPack(){} // RVA: 0x761D5B0
        public void UnPackTo(){} // RVA: 0x761D620
        public void Pack(){} // RVA: 0x761E6B0
    }

    public class PlayerDataPairT
    {
        public string <Key>k__BackingField; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.PlayerDataTypeUnion <Value>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Key(){} // RVA: 0x2F8380
        public void set_Key(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75EEF50
    }

    public class PlayerDataPairVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761E820
    }

    public class PlayerDataT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.PlayerDataPairT> <Pairs>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Pairs(){} // RVA: 0x2F8380
        public void set_Pairs(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class PlayerDataTypeUnion
    {
        public 0x6591CC80 inputIsActive; // 0x10
        public object active; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsVector2(){} // RVA: 0x761A3B0
        public void FromVector2(){} // RVA: 0x761A3F0
        public void AsVector3(){} // RVA: 0x761A4F0
        public void FromVector3(){} // RVA: 0x761A530
        public void AsVector4(){} // RVA: 0x761A630
        public void FromVector4(){} // RVA: 0x761A670
        public void AsQuaternion(){} // RVA: 0x761A770
        public void FromQuaternion(){} // RVA: 0x761A7B0
        public void AsColor(){} // RVA: 0x761A8B0
        public void FromColor(){} // RVA: 0x761A8F0
        public void AsColor32(){} // RVA: 0x761A9F0
        public void FromColor32(){} // RVA: 0x761AA30
        public void AsWrappedString(){} // RVA: 0x761AB30
        public void FromWrappedString(){} // RVA: 0x761AB70
        public void AsWrappedShort(){} // RVA: 0x761AC70
        public void FromWrappedShort(){} // RVA: 0x761ACB0
        public void AsWrappedInt(){} // RVA: 0x761ADB0
        public void FromWrappedInt(){} // RVA: 0x761ADF0
        public void AsWrappedFloat(){} // RVA: 0x761AEF0
        public void FromWrappedFloat(){} // RVA: 0x761AF30
        public void AsWrappedBool(){} // RVA: 0x761B030
        public void FromWrappedBool(){} // RVA: 0x761B070
        public void AsWrappedByte(){} // RVA: 0x761B170
        public void FromWrappedByte(){} // RVA: 0x761B1B0
        public void AsWrappedBytes(){} // RVA: 0x761B2B0
        public void FromWrappedBytes(){} // RVA: 0x761B2F0
        public void AsWrappedUShort(){} // RVA: 0x761B3F0
        public void FromWrappedUShort(){} // RVA: 0x761B430
        public void AsWrappedUByte(){} // RVA: 0x761B530
        public void FromWrappedUByte(){} // RVA: 0x761B570
        public void AsWrappedUInt(){} // RVA: 0x761B670
        public void FromWrappedUInt(){} // RVA: 0x761B6B0
        public void AsWrappedULong(){} // RVA: 0x761B7B0
        public void FromWrappedULong(){} // RVA: 0x761B7F0
        public void AsWrappedDouble(){} // RVA: 0x761B8F0
        public void FromWrappedDouble(){} // RVA: 0x761B930
        public void AsWrappedLong(){} // RVA: 0x761BA30
        public void FromWrappedLong(){} // RVA: 0x761BA70
        public void Pack(){} // RVA: 0x761BB70
    }

    public class PlayerDataTypeVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761C480
    }

    public class PlayerDataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761F4D0
    }

    public class PlayerStationStateData
    {
        public Google.FlatBuffers32.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsPlayerStationStateData(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void ActiveStations(){} // RVA: 0x761F5A0
        public void get_ActiveStationsLength(){} // RVA: 0x760F6F0
        public void GetActiveStationsBytes(){} // RVA: 0x761F620
        public void GetActiveStationsArray(){} // RVA: 0x761F690
        public void CreatePlayerStationStateData(){} // RVA: 0x761F6E0
        public void StartPlayerStationStateData(){} // RVA: 0x760F310
        public void AddActiveStations(){} // RVA: 0x760F330
        public void CreateActiveStationsVector(){} // RVA: 0x7613770
        public void CreateActiveStationsVectorBlock(){} // RVA: 0x761F900 | overloaded x3
        public void StartActiveStationsVector(){} // RVA: 0x76081F0
        public void EndPlayerStationStateData(){} // RVA: 0x761F9C0
        public void UnPack(){} // RVA: 0x761FA10
        public void UnPackTo(){} // RVA: 0x761FAC0
        public void Pack(){} // RVA: 0x761FCE0
    }

    public class PlayerStationStateDataT
    {
        public System.Collections.Generic.List`1<uint> <ActiveStations>k__BackingField; // 0x10

        // ── Methods ──
        public void get_ActiveStations(){} // RVA: 0x2F8380
        public void set_ActiveStations(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class PlayerStationStateDataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x761FDD0
    }

    public class PuppetData
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Channels(){} // RVA: 0x7624F80
        public void CreatePuppetData(){} // RVA: 0x7626890
        public void UnPack(){} // RVA: 0x7626960
        public void UnPackTo(){} // RVA: 0x76269D0
        public void Pack(){} // RVA: 0x7626AD0
    }

    public class PuppetDataT
    {
        public byte[] ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x2F8380
        public void set_Channels(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x7626AF0
    }

}