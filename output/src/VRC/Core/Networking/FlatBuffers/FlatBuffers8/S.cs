// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 19
// Methods: 261

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class SerializedObjects : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFAC9D7EFD0
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void ObjectsType(){} // RVA: 0x7FFAC9D75C20
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFAC9D7F0C0
        public void GetObjectsTypeArray(){} // RVA: 0x7FFAC9D7F130
        public void Objects(){} // RVA: 0x7FFAC2E8DC40
        public void get_ObjectsLength(){} // RVA: 0x7FFAC9D76940
        public void CreateSerializedObjects(){} // RVA: 0x7FFAC9D7F2E0
        public void StartSerializedObjects(){} // RVA: 0x7FFAC9D76AA0
        public void AddObjectsType(){} // RVA: 0x7FFAC9D75900
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFAC9D7F530 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFAC9D761C0
        public void AddObjects(){} // RVA: 0x7FFAC9D76CB0
        public void CreateObjectsVector(){} // RVA: 0x7FFAC9D76CF0
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFAC9D7F710 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFAC9D761C0
        public void EndSerializedObjects(){} // RVA: 0x7FFAC9D7F7A0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D7F830
        public void UnPackTo(){} // RVA: 0x7FFAC9D7F8E0
        public void Pack(){} // RVA: 0x7FFAC9D802F0
    }

    public class SerializedObjectsT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.SerializedTypeUnion> Objects; // 0x10

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFAC2F3C380
        public void set_Objects(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D805C0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D80670
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

    public class SerializedTypeUnion : Object
    {
        public 0x6B1FC450 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsSyncPhysicsData(){} // RVA: 0x7FFAC9D7DBC0
        public void FromSyncPhysicsData(){} // RVA: 0x7FFAC9D7DC00
        public void AsDestructiblePlayer(){} // RVA: 0x7FFAC9D7DD00
        public void FromDestructiblePlayer(){} // RVA: 0x7FFAC9D7DD40
        public void AsSyncVideoPlayer(){} // RVA: 0x7FFAC9D7DE40
        public void FromSyncVideoPlayer(){} // RVA: 0x7FFAC9D7DE80
        public void AsSyncVideoStream(){} // RVA: 0x7FFAC9D7DF80
        public void FromSyncVideoStream(){} // RVA: 0x7FFAC9D7DFC0
        public void AsSyncAnim(){} // RVA: 0x7FFAC9D7E0C0
        public void FromSyncAnim(){} // RVA: 0x7FFAC9D7E100
        public void AsDataStorage(){} // RVA: 0x7FFAC9D7E200
        public void FromDataStorage(){} // RVA: 0x7FFAC9D7E240
        public void AsPoseRecorder(){} // RVA: 0x7FFAC9D7E340
        public void FromPoseRecorder(){} // RVA: 0x7FFAC9D7E380
        public void AsUdon(){} // RVA: 0x7FFAC9D7E480
        public void FromUdon(){} // RVA: 0x7FFAC9D7E4C0
        public void AsObjectPool(){} // RVA: 0x7FFAC9D7E5C0
        public void FromObjectPool(){} // RVA: 0x7FFAC9D7E600
        public void Pack(){} // RVA: 0x7FFAC9D7E700
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D7EBC0
    }

    public class SparseSerializedObjects : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFAC9D83420
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Objects(){} // RVA: 0x7FFAC9D83510
        public void Bitmap(){} // RVA: 0x7FFAC9D83650
        public void get_BitmapLength(){} // RVA: 0x7FFAC9D76940
        public void GetBitmapBytes(){} // RVA: 0x7FFAC9D836D0
        public void GetBitmapArray(){} // RVA: 0x7FFAC9D83740
        public void MutateBitmap(){} // RVA: 0x7FFAC9D83790
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFAC9D83820
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFAC9D76AA0
        public void AddObjects(){} // RVA: 0x7FFAC9D75900
        public void AddBitmap(){} // RVA: 0x7FFAC9D76CB0
        public void CreateBitmapVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFAC9D83A60 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFAC9D761C0
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFAC9D83AF0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D83B80
        public void UnPackTo(){} // RVA: 0x7FFAC9D83C90
        public void Pack(){} // RVA: 0x7FFAC9D83FC0
    }

    public class SparseSerializedObjectsT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.SerializedObjectsT Objects; // 0x10
        public System.Collections.Generic.List`1<byte> Bitmap; // 0x18

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFAC2F3C380
        public void set_Objects(){} // RVA: 0x7FFAC2F22E30
        public void get_Bitmap(){} // RVA: 0x7FFAC2F247C0
        public void set_Bitmap(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D84070
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D84120
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D841D0
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D84350
    }

    public class SyncAnim : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSyncAnim(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifySyncAnim(){} // RVA: 0x7FFAC9D85F70
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_AnimationIsPlaying(){} // RVA: 0x7FFAC9D86060
        public void MutateAnimationIsPlaying(){} // RVA: 0x7FFAC9D860B0
        public void AnimationStates(){} // RVA: 0x7FFAC9D86110
        public void get_AnimationStatesLength(){} // RVA: 0x7FFAC9D76940
        public void AnimatorLayers(){} // RVA: 0x7FFAC9D86280
        public void get_AnimatorLayersLength(){} // RVA: 0x7FFAC9D863F0
        public void AnimatorParametersType(){} // RVA: 0x7FFAC9D86460
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x7FFAC9D864E0
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x7FFAC9D86550
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x7FFAC9D865C0
        public void AnimatorParameters(){} // RVA: 0x7FFAC2E8DC40
        public void get_AnimatorParametersLength(){} // RVA: 0x7FFAC9D86770
        public void CreateSyncAnim(){} // RVA: 0x7FFAC9D867E0
        public void StartSyncAnim(){} // RVA: 0x7FFAC9D86970
        public void AddAnimationIsPlaying(){} // RVA: 0x7FFAC9D86990
        public void AddAnimationStates(){} // RVA: 0x7FFAC9D76CB0
        public void CreateAnimationStatesVector(){} // RVA: 0x7FFAC9D76CF0
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7FFAC9D86BF0 | overloaded x3
        public void StartAnimationStatesVector(){} // RVA: 0x7FFAC9D761C0
        public void AddAnimatorLayers(){} // RVA: 0x7FFAC9D84F00
        public void CreateAnimatorLayersVector(){} // RVA: 0x7FFAC9D76CF0
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7FFAC9D86E70 | overloaded x3
        public void StartAnimatorLayersVector(){} // RVA: 0x7FFAC9D761C0
        public void AddAnimatorParametersType(){} // RVA: 0x7FFAC9D86F00
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7FFAC9D870A0 | overloaded x3
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x7FFAC9D761C0
        public void AddAnimatorParameters(){} // RVA: 0x7FFAC9D87130
        public void CreateAnimatorParametersVector(){} // RVA: 0x7FFAC9D76CF0
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7FFAC9D872C0 | overloaded x3
        public void StartAnimatorParametersVector(){} // RVA: 0x7FFAC9D761C0
        public void EndSyncAnim(){} // RVA: 0x7FFAC9D87350
        public void FinishSyncAnimBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D873E0
        public void UnPackTo(){} // RVA: 0x7FFAC9D87540
        public void Pack(){} // RVA: 0x7FFAC9D87F00
    }

    public class SyncAnimT : Object
    {
        public bool AnimationIsPlaying; // 0x10
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.AnimationStateT> AnimationStates; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.AnimatorLayerT> AnimatorLayers; // 0x20
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.AnimatorParameterUnion> AnimatorParameters; // 0x28

        // ── Methods ──
        public void get_AnimationIsPlaying(){} // RVA: 0x7FFAC2FEB5E0
        public void set_AnimationIsPlaying(){} // RVA: 0x7FFAC2FEB5F0
        public void get_AnimationStates(){} // RVA: 0x7FFAC2F247C0
        public void set_AnimationStates(){} // RVA: 0x7FFAC2F87E80
        public void get_AnimatorLayers(){} // RVA: 0x7FFAC2F4F0C0
        public void set_AnimatorLayers(){} // RVA: 0x7FFAC2F4F0D0
        public void get_AnimatorParameters(){} // RVA: 0x7FFAC2F4F130
        public void set_AnimatorParameters(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFAC9D885C0
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D886D0
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D88780
    }

    public class SyncAnimVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D88880
    }

    public class SyncPhysicsData : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Flags(){} // RVA: 0x7FFAC9D7A9A0
        public void MutateFlags(){} // RVA: 0x7FFAC9D75030
        public void get_Position(){} // RVA: 0x7FFAC9D88A10
        public void get_Rotation(){} // RVA: 0x7FFAC9D88A50
        public void CreateSyncPhysicsData(){} // RVA: 0x7FFAC9D88A90
        public void UnPack(){} // RVA: 0x7FFAC9D88C60
        public void UnPackTo(){} // RVA: 0x7FFAC9D88DF0
        public void Pack(){} // RVA: 0x7FFAC9D88FE0
    }

    public class SyncPhysicsDataT : Object
    {
        public byte Flags; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3BytesT Position; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionTenBitT Rotation; // 0x20

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Flags(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Position(){} // RVA: 0x7FFAC2F247C0
        public void set_Position(){} // RVA: 0x7FFAC2F87E80
        public void get_Rotation(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Rotation(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9D89120
    }

    public class SyncVideoPlayer : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_IsPlaying(){} // RVA: 0x7FFAC9D86060
        public void MutateIsPlaying(){} // RVA: 0x7FFAC9D860B0
        public void get_Time(){} // RVA: 0x7FFAC9D84A00
        public void MutateTime(){} // RVA: 0x7FFAC9D84A50
        public void get_PlaybackSpeed(){} // RVA: 0x7FFAC9D89260
        public void MutatePlaybackSpeed(){} // RVA: 0x7FFAC9D892B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFAC9D89310
        public void MutateCurrentPlaylistIndex(){} // RVA: 0x7FFAC9D89360
        public void CreateSyncVideoPlayer(){} // RVA: 0x7FFAC9D893C0
        public void StartSyncVideoPlayer(){} // RVA: 0x7FFAC9D895D0
        public void AddIsPlaying(){} // RVA: 0x7FFAC9D86990
        public void AddTime(){} // RVA: 0x7FFAC9D84E80
        public void AddPlaybackSpeed(){} // RVA: 0x7FFAC9D895F0
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7FFAC9D89660
        public void EndSyncVideoPlayer(){} // RVA: 0x7FFAC9D896D0
        public void UnPack(){} // RVA: 0x7FFAC9D89760
        public void UnPackTo(){} // RVA: 0x7FFAC9D897D0
        public void Pack(){} // RVA: 0x7FFAC9D898E0
    }

    public class SyncVideoPlayerT : Object
    {
        public bool IsPlaying; // 0x10
        public float Time; // 0x14
        public short PlaybackSpeed; // 0x18
        public short CurrentPlaylistIndex; // 0x1A

        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x7FFAC2FEB5E0
        public void set_IsPlaying(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Time(){} // RVA: 0x7FFAC304B340
        public void set_Time(){} // RVA: 0x7FFAC304B350
        public void get_PlaybackSpeed(){} // RVA: 0x7FFAC5F39D20
        public void set_PlaybackSpeed(){} // RVA: 0x7FFAC6D24B10
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFAC7FDE3F0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x7FFAC82534C0
        public void .ctor(){} // RVA: 0x7FFAC9D89920
    }

    public class SyncVideoPlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D89930
    }

    public class SyncVideoStream : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsSyncVideoStream(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_IsPlaying(){} // RVA: 0x7FFAC9D86060
        public void MutateIsPlaying(){} // RVA: 0x7FFAC9D860B0
        public void get_Time(){} // RVA: 0x7FFAC9D84A00
        public void MutateTime(){} // RVA: 0x7FFAC9D84A50
        public void get_PlaybackRate(){} // RVA: 0x7FFAC9D89260
        public void MutatePlaybackRate(){} // RVA: 0x7FFAC9D892B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFAC9D89310
        public void MutateCurrentPlaylistIndex(){} // RVA: 0x7FFAC9D89360
        public void get_SyncType(){} // RVA: 0x7FFAC9D7B330
        public void MutateSyncType(){} // RVA: 0x7FFAC9D7B380
        public void get_SyncMinutes(){} // RVA: 0x7FFAC9D89A70
        public void MutateSyncMinutes(){} // RVA: 0x7FFAC9D89AC0
        public void CreateSyncVideoStream(){} // RVA: 0x7FFAC9D89B20
        public void StartSyncVideoStream(){} // RVA: 0x7FFAC9D89DD0
        public void AddIsPlaying(){} // RVA: 0x7FFAC9D86990
        public void AddTime(){} // RVA: 0x7FFAC9D84E80
        public void AddPlaybackRate(){} // RVA: 0x7FFAC9D895F0
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7FFAC9D89660
        public void AddSyncType(){} // RVA: 0x7FFAC9D7C240
        public void AddSyncMinutes(){} // RVA: 0x7FFAC9D89DF0
        public void EndSyncVideoStream(){} // RVA: 0x7FFAC9D89E60
        public void UnPack(){} // RVA: 0x7FFAC9D89EF0
        public void UnPackTo(){} // RVA: 0x7FFAC9D89F60
        public void Pack(){} // RVA: 0x7FFAC9D8A0D0
    }

    public class SyncVideoStreamT : Object
    {
        public bool IsPlaying; // 0x10
        public float Time; // 0x14
        public short PlaybackRate; // 0x18
        public short CurrentPlaylistIndex; // 0x1A
        public byte SyncType; // 0x1C
        public short SyncMinutes; // 0x1E

        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x7FFAC2FEB5E0
        public void set_IsPlaying(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Time(){} // RVA: 0x7FFAC304B340
        public void set_Time(){} // RVA: 0x7FFAC304B350
        public void get_PlaybackRate(){} // RVA: 0x7FFAC5F39D20
        public void set_PlaybackRate(){} // RVA: 0x7FFAC6D24B10
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFAC7FDE3F0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x7FFAC82534C0
        public void get_SyncType(){} // RVA: 0x7FFAC2F3C390
        public void set_SyncType(){} // RVA: 0x7FFAC2F3C3A0
        public void get_SyncMinutes(){} // RVA: 0x7FFAC9D8A120
        public void set_SyncMinutes(){} // RVA: 0x7FFAC9D8A130
        public void .ctor(){} // RVA: 0x7FFAC9D8A140
    }

    public class SyncVideoStreamVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D8A160
    }

}