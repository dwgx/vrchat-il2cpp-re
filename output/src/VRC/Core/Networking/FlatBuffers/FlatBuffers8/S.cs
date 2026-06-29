// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 19
// Methods: 229

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class SerializedObjects : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7AF3BF190
        public void VerifySerializedObjects(){} // RVA: 0x7AF3C8640
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void ObjectsType(){} // RVA: 0x7A7F12810
        public void get_ObjectsTypeLength(){} // RVA: 0x7A7F12930
        public void GetObjectsTypeBytes(){} // RVA: 0x7A7F13360
        public void GetObjectsTypeArray(){} // RVA: 0x7A7F133D0
        public void Objects(){} // RVA: 0x7A8051B10
        public void get_ObjectsLength(){} // RVA: 0x7A7F12A20
        public void CreateSerializedObjects(){} // RVA: 0x7AF3C8950
        public void StartSerializedObjects(){} // RVA: 0x7AF3C0540
        public void AddObjectsType(){} // RVA: 0x7AF3BF420
        public void CreateObjectsTypeVector(){} // RVA: 0x7AF3BF9B0
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7AF3C8BA0
        public void StartObjectsTypeVector(){} // RVA: 0x7AF3BFC60
        public void AddObjects(){} // RVA: 0x7AF3C0750
        public void CreateObjectsVector(){} // RVA: 0x7AF3C0790
        public void CreateObjectsVectorBlock(){} // RVA: 0x7AF3C8D80
        public void StartObjectsVector(){} // RVA: 0x7AF3BFC60
        public void EndSerializedObjects(){} // RVA: 0x7AF3C8E10
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F133E0
        public void UnPackTo(){} // RVA: 0x7A7F133F0
        public void Pack(){} // RVA: 0x7AF3C9970
    }

    public class SerializedObjectsT : Object
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7A80F2570
        public void set_Objects(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
        public void DeserializeFromBinary(){} // RVA: 0x7AF3C9C60
        public void SerializeToBinary(){} // RVA: 0x7AF3C9D10
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C0060
    }

    public class SerializedTypeUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsSyncPhysicsData(){} // RVA: 0x7AF3C7240
        public void FromSyncPhysicsData(){} // RVA: 0x7AF3C7280
        public void AsDestructiblePlayer(){} // RVA: 0x7AF3C7380
        public void FromDestructiblePlayer(){} // RVA: 0x7AF3C73C0
        public void AsSyncVideoPlayer(){} // RVA: 0x7AF3C74C0
        public void FromSyncVideoPlayer(){} // RVA: 0x7AF3C7500
        public void AsSyncVideoStream(){} // RVA: 0x7AF3C7600
        public void FromSyncVideoStream(){} // RVA: 0x7AF3C7640
        public void AsSyncAnim(){} // RVA: 0x7AF3C7740
        public void FromSyncAnim(){} // RVA: 0x7AF3C7780
        public void AsDataStorage(){} // RVA: 0x7AF3C7880
        public void FromDataStorage(){} // RVA: 0x7AF3C78C0
        public void AsPoseRecorder(){} // RVA: 0x7AF3C79C0
        public void FromPoseRecorder(){} // RVA: 0x7AF3C7A00
        public void AsUdon(){} // RVA: 0x7AF3C7B00
        public void FromUdon(){} // RVA: 0x7AF3C7B40
        public void AsObjectPool(){} // RVA: 0x7AF3C7C40
        public void FromObjectPool(){} // RVA: 0x7AF3C7C80
        public void Pack(){} // RVA: 0x7AF3C7D80
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C8230
    }

    public class SparseSerializedObjects : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7AF3BF190
        public void VerifySparseSerializedObjects(){} // RVA: 0x7AF3CC9B0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Objects(){} // RVA: 0x7A7F13A40
        public void Bitmap(){} // RVA: 0x7A7F13A70
        public void get_BitmapLength(){} // RVA: 0x7A7F12A20
        public void GetBitmapBytes(){} // RVA: 0x7A7F13A80
        public void GetBitmapArray(){} // RVA: 0x7A7F13AF0
        public void CreateSparseSerializedObjects(){} // RVA: 0x7AF3CCD20
        public void StartSparseSerializedObjects(){} // RVA: 0x7AF3C0540
        public void AddObjects(){} // RVA: 0x7AF3BF420
        public void AddBitmap(){} // RVA: 0x7AF3C0750
        public void CreateBitmapVector(){} // RVA: 0x7AF3BF9B0
        public void CreateBitmapVectorBlock(){} // RVA: 0x7AF3CCF60
        public void StartBitmapVector(){} // RVA: 0x7AF3BFC60
        public void EndSparseSerializedObjects(){} // RVA: 0x7AF3CCFF0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F13B40
        public void UnPackTo(){} // RVA: 0x7A7F13B50
        public void Pack(){} // RVA: 0x7AF3CD4C0
    }

    public class SparseSerializedObjectsT : Object
    {
        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7A80F2570
        public void set_Objects(){} // RVA: 0x7A80D8E20
        public void get_Bitmap(){} // RVA: 0x7A80DA7B0
        public void set_Bitmap(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3CD570
        public void DeserializeFromBinary(){} // RVA: 0x7AF3CD620
        public void SerializeToBinary(){} // RVA: 0x7AF3CD6D0
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3CD850
    }

    public class SyncAnim : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSyncAnim(){} // RVA: 0x7AF3BF190
        public void VerifySyncAnim(){} // RVA: 0x7AF3CF2D0
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_AnimationIsPlaying(){} // RVA: 0x7A7F13E50
        public void AnimationStates(){} // RVA: 0x7A7F13EA0
        public void get_AnimationStatesLength(){} // RVA: 0x7A7F12A20
        public void AnimatorLayers(){} // RVA: 0x7A7F13ED0
        public void get_AnimatorLayersLength(){} // RVA: 0x7A7F13F00
        public void AnimatorParametersType(){} // RVA: 0x7A7F13F10
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x7A7F13F20
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x7A7F13F90
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x7A7F14000
        public void AnimatorParameters(){} // RVA: 0x7A8051B10
        public void get_AnimatorParametersLength(){} // RVA: 0x7A7F14010
        public void CreateSyncAnim(){} // RVA: 0x7AF3CFAE0
        public void StartSyncAnim(){} // RVA: 0x7AF3CFC70
        public void AddAnimationIsPlaying(){} // RVA: 0x7AF3CFC90
        public void AddAnimationStates(){} // RVA: 0x7AF3C0750
        public void CreateAnimationStatesVector(){} // RVA: 0x7AF3CFD00
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7AF3CFF90
        public void StartAnimationStatesVector(){} // RVA: 0x7AF3BFC60
        public void AddAnimatorLayers(){} // RVA: 0x7AF3CE370
        public void CreateAnimatorLayersVector(){} // RVA: 0x7AF3CFD00
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7AF3D0210
        public void StartAnimatorLayersVector(){} // RVA: 0x7AF3BFC60
        public void AddAnimatorParametersType(){} // RVA: 0x7AF3D02A0
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x7AF3BF9B0
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7AF3D0440
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x7AF3BFC60
        public void AddAnimatorParameters(){} // RVA: 0x7AF3D04D0
        public void CreateAnimatorParametersVector(){} // RVA: 0x7AF3C0790
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7AF3D0660
        public void StartAnimatorParametersVector(){} // RVA: 0x7AF3BFC60
        public void EndSyncAnim(){} // RVA: 0x7AF3D06F0
        public void FinishSyncAnimBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F14020
        public void UnPackTo(){} // RVA: 0x7A7F14030
        public void Pack(){} // RVA: 0x7AF3D12A0
    }

    public class SyncAnimT : Object
    {
        // ── Methods ──
        public void get_AnimationIsPlaying(){} // RVA: 0x7A81A2200
        public void set_AnimationIsPlaying(){} // RVA: 0x7A81A2210
        public void get_AnimationStates(){} // RVA: 0x7A80DA7B0
        public void set_AnimationStates(){} // RVA: 0x7A813E420
        public void get_AnimatorLayers(){} // RVA: 0x7A81052C0
        public void set_AnimatorLayers(){} // RVA: 0x7A81052D0
        public void get_AnimatorParameters(){} // RVA: 0x7A8105330
        public void set_AnimatorParameters(){} // RVA: 0x7A80D8E80
        public void .ctor(){} // RVA: 0x7AF3D19B0
        public void DeserializeFromBinary(){} // RVA: 0x7AF3D1AC0
        public void SerializeToBinary(){} // RVA: 0x7AF3D1B70
    }

    public class SyncAnimVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3D1C70
    }

    public class SyncPhysicsData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Flags(){} // RVA: 0x7A7F12E10
        public void get_Position(){} // RVA: 0x7A7F142E0
        public void get_Rotation(){} // RVA: 0x7A7F14320
        public void CreateSyncPhysicsData(){} // RVA: 0x7AF3D1E80
        public void UnPack(){} // RVA: 0x7A7F14360
        public void UnPackTo(){} // RVA: 0x7A7F14370
        public void Pack(){} // RVA: 0x7AF3D23C0
    }

    public class SyncPhysicsDataT : Object
    {
        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7A81A2200
        public void set_Flags(){} // RVA: 0x7A81A2210
        public void get_Position(){} // RVA: 0x7A80DA7B0
        public void set_Position(){} // RVA: 0x7A813E420
        public void get_Rotation(){} // RVA: 0x7A81052C0
        public void set_Rotation(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AF3D2500
    }

    public class SyncVideoPlayer : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_IsPlaying(){} // RVA: 0x7A7F13E50
        public void get_Time(){} // RVA: 0x7A7F13B80
        public void get_PlaybackSpeed(){} // RVA: 0x7A7F143A0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7A7F143F0
        public void CreateSyncVideoPlayer(){} // RVA: 0x7AF3D26E0
        public void StartSyncVideoPlayer(){} // RVA: 0x7AF3D28E0
        public void AddIsPlaying(){} // RVA: 0x7AF3CFC90
        public void AddTime(){} // RVA: 0x7AF3CE300
        public void AddPlaybackSpeed(){} // RVA: 0x7AF3D2900
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7AF3D2970
        public void EndSyncVideoPlayer(){} // RVA: 0x7AF3D29E0
        public void UnPack(){} // RVA: 0x7A7F14440
        public void UnPackTo(){} // RVA: 0x7A7F14450
        public void Pack(){} // RVA: 0x7AF3D2BF0
    }

    public class SyncVideoPlayerT : Object
    {
        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x7A81A2200
        public void set_IsPlaying(){} // RVA: 0x7A81A2210
        public void get_Time(){} // RVA: 0x7A82023E0
        public void set_Time(){} // RVA: 0x7A82023F0
        public void get_PlaybackSpeed(){} // RVA: 0x7AA69D080
        public void set_PlaybackSpeed(){} // RVA: 0x7AC25E3B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7AA69D090
        public void set_CurrentPlaylistIndex(){} // RVA: 0x7AD8A9500
        public void .ctor(){} // RVA: 0x7AF3D2C30
    }

    public class SyncVideoPlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3D2C40
    }

    public class SyncVideoStream : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsSyncVideoStream(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_IsPlaying(){} // RVA: 0x7A7F13E50
        public void get_Time(){} // RVA: 0x7A7F13B80
        public void get_PlaybackRate(){} // RVA: 0x7A7F143A0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7A7F143F0
        public void get_SyncType(){} // RVA: 0x7A7F13080
        public void get_SyncMinutes(){} // RVA: 0x7A7F14480
        public void CreateSyncVideoStream(){} // RVA: 0x7AF3D2DD0
        public void StartSyncVideoStream(){} // RVA: 0x7AF3D3070
        public void AddIsPlaying(){} // RVA: 0x7AF3CFC90
        public void AddTime(){} // RVA: 0x7AF3CE300
        public void AddPlaybackRate(){} // RVA: 0x7AF3D2900
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7AF3D2970
        public void AddSyncType(){} // RVA: 0x7AF3C59F0
        public void AddSyncMinutes(){} // RVA: 0x7AF3D3090
        public void EndSyncVideoStream(){} // RVA: 0x7AF3D3100
        public void UnPack(){} // RVA: 0x7A7F144D0
        public void UnPackTo(){} // RVA: 0x7A7F144E0
        public void Pack(){} // RVA: 0x7AF3D3370
    }

    public class SyncVideoStreamT : Object
    {
        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x7A81A2200
        public void set_IsPlaying(){} // RVA: 0x7A81A2210
        public void get_Time(){} // RVA: 0x7A82023E0
        public void set_Time(){} // RVA: 0x7A82023F0
        public void get_PlaybackRate(){} // RVA: 0x7AA69D080
        public void set_PlaybackRate(){} // RVA: 0x7AC25E3B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7AA69D090
        public void set_CurrentPlaylistIndex(){} // RVA: 0x7AD8A9500
        public void get_SyncType(){} // RVA: 0x7A80F2580
        public void set_SyncType(){} // RVA: 0x7A80F2590
        public void get_SyncMinutes(){} // RVA: 0x7AF3D33C0
        public void set_SyncMinutes(){} // RVA: 0x7AF3D33D0
        public void .ctor(){} // RVA: 0x7AF3D33E0
    }

    public class SyncVideoStreamVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3D3400
    }

}