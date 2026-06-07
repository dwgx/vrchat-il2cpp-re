// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 19
// Methods: 248

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class SerializedObjects
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSerializedObjects(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x75EA170
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void ObjectsType(){} // RVA: 0x75E11F0
        public void get_ObjectsTypeLength(){} // RVA: 0x75E1270
        public void GetObjectsTypeBytes(){} // RVA: 0x75EA260
        public void GetObjectsTypeArray(){} // RVA: 0x75EA2D0
        public void Objects(){} // RVA: 0x283FA0
        public void get_ObjectsLength(){} // RVA: 0x75E1E80
        public void CreateSerializedObjects(){} // RVA: 0x75EA480
        public void StartSerializedObjects(){} // RVA: 0x75E1FE0
        public void AddObjectsType(){} // RVA: 0x75E0ED0
        public void CreateObjectsTypeVector(){} // RVA: 0x75E1460
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x75EA6D0 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x75E1700
        public void AddObjects(){} // RVA: 0x75E21F0
        public void CreateObjectsVector(){} // RVA: 0x75E2230
        public void CreateObjectsVectorBlock(){} // RVA: 0x75EA8B0 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x75E1700
        public void EndSerializedObjects(){} // RVA: 0x75EA940
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75EA9D0
        public void UnPackTo(){} // RVA: 0x75EAA80
        public void Pack(){} // RVA: 0x75EB490
    }

    public class SerializedObjectsT
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x2F8380
        public void set_Objects(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
        public void DeserializeFromBinary(){} // RVA: 0x75EB760
        public void SerializeToBinary(){} // RVA: 0x75EB810
    }

    public class SerializedObjectsVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E1B00
    }

    public class SerializedTypeUnion
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsSyncPhysicsData(){} // RVA: 0x75E8D60
        public void FromSyncPhysicsData(){} // RVA: 0x75E8DA0
        public void AsDestructiblePlayer(){} // RVA: 0x75E8EA0
        public void FromDestructiblePlayer(){} // RVA: 0x75E8EE0
        public void AsSyncVideoPlayer(){} // RVA: 0x75E8FE0
        public void FromSyncVideoPlayer(){} // RVA: 0x75E9020
        public void AsSyncVideoStream(){} // RVA: 0x75E9120
        public void FromSyncVideoStream(){} // RVA: 0x75E9160
        public void AsSyncAnim(){} // RVA: 0x75E9260
        public void FromSyncAnim(){} // RVA: 0x75E92A0
        public void AsDataStorage(){} // RVA: 0x75E93A0
        public void FromDataStorage(){} // RVA: 0x75E93E0
        public void AsPoseRecorder(){} // RVA: 0x75E94E0
        public void FromPoseRecorder(){} // RVA: 0x75E9520
        public void AsUdon(){} // RVA: 0x75E9620
        public void FromUdon(){} // RVA: 0x75E9660
        public void AsObjectPool(){} // RVA: 0x75E9760
        public void FromObjectPool(){} // RVA: 0x75E97A0
        public void Pack(){} // RVA: 0x75E98A0
    }

    public class SerializedTypeVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E9D60
    }

    public class SparseSerializedObjects
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x75EE390
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Objects(){} // RVA: 0x75EE480
        public void Bitmap(){} // RVA: 0x75EE5C0
        public void get_BitmapLength(){} // RVA: 0x75E1E80
        public void GetBitmapBytes(){} // RVA: 0x75EE640
        public void GetBitmapArray(){} // RVA: 0x75EE6B0
        public void CreateSparseSerializedObjects(){} // RVA: 0x75EE700
        public void StartSparseSerializedObjects(){} // RVA: 0x75E1FE0
        public void AddObjects(){} // RVA: 0x75E0ED0
        public void AddBitmap(){} // RVA: 0x75E21F0
        public void CreateBitmapVector(){} // RVA: 0x75E1460
        public void CreateBitmapVectorBlock(){} // RVA: 0x75EE940 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x75E1700
        public void EndSparseSerializedObjects(){} // RVA: 0x75EE9D0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75EEA60
        public void UnPackTo(){} // RVA: 0x75EEB70
        public void Pack(){} // RVA: 0x75EEEA0
    }

    public class SparseSerializedObjectsT
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x2F8380
        public void set_Objects(){} // RVA: 0x2DEE30
        public void get_Bitmap(){} // RVA: 0x2E07C0
        public void set_Bitmap(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75EEF50
        public void DeserializeFromBinary(){} // RVA: 0x75EF000
        public void SerializeToBinary(){} // RVA: 0x75EF0B0
    }

    public class SparseSerializedObjectsVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75EF230
    }

    public class SyncAnim
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSyncAnim(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifySyncAnim(){} // RVA: 0x75F0CB0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_AnimationIsPlaying(){} // RVA: 0x75F0DA0
        public void AnimationStates(){} // RVA: 0x75F0DF0
        public void get_AnimationStatesLength(){} // RVA: 0x75E1E80
        public void AnimatorLayers(){} // RVA: 0x75F0F60
        public void get_AnimatorLayersLength(){} // RVA: 0x75F10D0
        public void AnimatorParametersType(){} // RVA: 0x75F1140
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x75F11C0
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x75F1230
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x75F12A0
        public void AnimatorParameters(){} // RVA: 0x283FA0
        public void get_AnimatorParametersLength(){} // RVA: 0x75F1450
        public void CreateSyncAnim(){} // RVA: 0x75F14C0
        public void StartSyncAnim(){} // RVA: 0x75F1650
        public void AddAnimationIsPlaying(){} // RVA: 0x75F1670
        public void AddAnimationStates(){} // RVA: 0x75E21F0
        public void CreateAnimationStatesVector(){} // RVA: 0x75E2230
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x75F18D0 | overloaded x3
        public void StartAnimationStatesVector(){} // RVA: 0x75E1700
        public void AddAnimatorLayers(){} // RVA: 0x75EFD50
        public void CreateAnimatorLayersVector(){} // RVA: 0x75E2230
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x75F1B50 | overloaded x3
        public void StartAnimatorLayersVector(){} // RVA: 0x75E1700
        public void AddAnimatorParametersType(){} // RVA: 0x75F1BE0
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x75E1460
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x75F1D80 | overloaded x3
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x75E1700
        public void AddAnimatorParameters(){} // RVA: 0x75F1E10
        public void CreateAnimatorParametersVector(){} // RVA: 0x75E2230
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x75F1FA0 | overloaded x3
        public void StartAnimatorParametersVector(){} // RVA: 0x75E1700
        public void EndSyncAnim(){} // RVA: 0x75F2030
        public void FinishSyncAnimBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75F20C0
        public void UnPackTo(){} // RVA: 0x75F2220
        public void Pack(){} // RVA: 0x75F2BE0
    }

    public class SyncAnimT
    {
        // ── Methods ──
        public void get_AnimationIsPlaying(){} // RVA: 0x3A75E0
        public void set_AnimationIsPlaying(){} // RVA: 0x3A75F0
        public void get_AnimationStates(){} // RVA: 0x2E07C0
        public void set_AnimationStates(){} // RVA: 0x343E80
        public void get_AnimatorLayers(){} // RVA: 0x30B0C0
        public void set_AnimatorLayers(){} // RVA: 0x30B0D0
        public void get_AnimatorParameters(){} // RVA: 0x30B130
        public void set_AnimatorParameters(){} // RVA: 0x2DEE90
        public void .ctor(){} // RVA: 0x75F32A0
        public void DeserializeFromBinary(){} // RVA: 0x75F33B0
        public void SerializeToBinary(){} // RVA: 0x75F3460
    }

    public class SyncAnimVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75F3560
    }

    public class SyncPhysicsData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Flags(){} // RVA: 0x75E5DC0
        public void get_Position(){} // RVA: 0x75F36F0
        public void get_Rotation(){} // RVA: 0x75F3730
        public void CreateSyncPhysicsData(){} // RVA: 0x75F3770
        public void UnPack(){} // RVA: 0x75F3940
        public void UnPackTo(){} // RVA: 0x75F3AD0
        public void Pack(){} // RVA: 0x75F3CC0
    }

    public class SyncPhysicsDataT
    {
        public object IsPlaying;
        public object Time;
        public object PlaybackSpeed;

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x3A75E0
        public void set_Flags(){} // RVA: 0x3A75F0
        public void get_Position(){} // RVA: 0x2E07C0
        public void set_Position(){} // RVA: 0x343E80
        public void get_Rotation(){} // RVA: 0x30B0C0
        public void set_Rotation(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x75F3E00
    }

    public class SyncVideoPlayer
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_IsPlaying(){} // RVA: 0x75F0DA0
        public void get_Time(){} // RVA: 0x75EF8E0
        public void get_PlaybackSpeed(){} // RVA: 0x75F3F40
        public void get_CurrentPlaylistIndex(){} // RVA: 0x75F3F90
        public void CreateSyncVideoPlayer(){} // RVA: 0x75F3FE0
        public void StartSyncVideoPlayer(){} // RVA: 0x75F41E0
        public void AddIsPlaying(){} // RVA: 0x75F1670
        public void AddTime(){} // RVA: 0x75EFCE0
        public void AddPlaybackSpeed(){} // RVA: 0x75F4200
        public void AddCurrentPlaylistIndex(){} // RVA: 0x75F4270
        public void EndSyncVideoPlayer(){} // RVA: 0x75F42E0
        public void UnPack(){} // RVA: 0x75F4370
        public void UnPackTo(){} // RVA: 0x75F43E0
        public void Pack(){} // RVA: 0x75F44F0
    }

    public class SyncVideoPlayerT
    {
        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x3A75E0
        public void set_IsPlaying(){} // RVA: 0x3A75F0
        public void get_Time(){} // RVA: 0x407340
        public void set_Time(){} // RVA: 0x407350
        public void get_PlaybackSpeed(){} // RVA: 0x2892C90
        public void set_PlaybackSpeed(){} // RVA: 0x4470200
        public void get_CurrentPlaylistIndex(){} // RVA: 0x2892CA0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x5ABBFD0
        public void .ctor(){} // RVA: 0x75F4530
    }

    public class SyncVideoPlayerVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75F4540
    }

    public class SyncVideoStream
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsSyncVideoStream(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_IsPlaying(){} // RVA: 0x75F0DA0
        public void get_Time(){} // RVA: 0x75EF8E0
        public void get_PlaybackRate(){} // RVA: 0x75F3F40
        public void get_CurrentPlaylistIndex(){} // RVA: 0x75F3F90
        public void get_SyncType(){} // RVA: 0x75E6590
        public void get_SyncMinutes(){} // RVA: 0x75F4680
        public void CreateSyncVideoStream(){} // RVA: 0x75F46D0
        public void StartSyncVideoStream(){} // RVA: 0x75F4970
        public void AddIsPlaying(){} // RVA: 0x75F1670
        public void AddTime(){} // RVA: 0x75EFCE0
        public void AddPlaybackRate(){} // RVA: 0x75F4200
        public void AddCurrentPlaylistIndex(){} // RVA: 0x75F4270
        public void AddSyncType(){} // RVA: 0x75E73E0
        public void AddSyncMinutes(){} // RVA: 0x75F4990
        public void EndSyncVideoStream(){} // RVA: 0x75F4A00
        public void UnPack(){} // RVA: 0x75F4A90
        public void UnPackTo(){} // RVA: 0x75F4B00
        public void Pack(){} // RVA: 0x75F4C70
    }

    public class SyncVideoStreamT
    {
        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x3A75E0
        public void set_IsPlaying(){} // RVA: 0x3A75F0
        public void get_Time(){} // RVA: 0x407340
        public void set_Time(){} // RVA: 0x407350
        public void get_PlaybackRate(){} // RVA: 0x2892C90
        public void set_PlaybackRate(){} // RVA: 0x4470200
        public void get_CurrentPlaylistIndex(){} // RVA: 0x2892CA0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x5ABBFD0
        public void get_SyncType(){} // RVA: 0x2F8390
        public void set_SyncType(){} // RVA: 0x2F83A0
        public void get_SyncMinutes(){} // RVA: 0x75F4CC0
        public void set_SyncMinutes(){} // RVA: 0x75F4CD0
        public void .ctor(){} // RVA: 0x75F4CE0
    }

    public class SyncVideoStreamVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75F4D00
    }

}