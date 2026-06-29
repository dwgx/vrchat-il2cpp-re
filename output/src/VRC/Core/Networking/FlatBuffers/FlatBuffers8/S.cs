// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 246

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class SerializedObjects : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSerializedObjects(){} // RVA: 0x8217320
        public void VerifySerializedObjects(){} // RVA: 0x8220B20
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void ObjectsType(){} // RVA: 0x9B5A40
        public void get_ObjectsTypeLength(){} // RVA: 0x9B5C00
        public void GetObjectsTypeBytes(){} // RVA: 0x9B6BD0
        public void GetObjectsTypeArray(){} // RVA: 0x9B6C40
        public void Objects(){} // RVA: 0xA94080
        public void get_ObjectsLength(){} // RVA: 0x9B5CF0
        public void CreateSerializedObjects(){} // RVA: 0x8220E30
        public void StartSerializedObjects(){} // RVA: 0x82186D0
        public void AddObjectsType(){} // RVA: 0x82175B0
        public void CreateObjectsTypeVector(){} // RVA: 0x8217B40
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x8221080
        public void StartObjectsTypeVector(){} // RVA: 0x8217DF0
        public void AddObjects(){} // RVA: 0x82188E0
        public void CreateObjectsVector(){} // RVA: 0x8218920
        public void CreateObjectsVectorBlock(){} // RVA: 0x8221260
        public void StartObjectsVector(){} // RVA: 0x8217DF0
        public void EndSerializedObjects(){} // RVA: 0x82212F0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B6C50
        public void UnPackTo(){} // RVA: 0x9B6C60
        public void Pack(){} // RVA: 0x8221E50
    }

    public class SerializedObjectsT : Object
    {
        public object _objects;

        // ── Methods ──
        public void get_Objects(){} // RVA: 0xB5DBF0
        public void set_Objects(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x8222140
        public void SerializeToBinary(){} // RVA: 0x82221F0
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

    public class SerializedTypeUnion : Object
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
        public void AsSyncPhysicsData(){} // RVA: 0x821F340
        public void FromSyncPhysicsData(){} // RVA: 0x821F3C0
        public void AsDestructiblePlayer(){} // RVA: 0x821F4C0
        public void FromDestructiblePlayer(){} // RVA: 0x821F540
        public void AsSyncVideoPlayer(){} // RVA: 0x821F640
        public void FromSyncVideoPlayer(){} // RVA: 0x821F6C0
        public void AsSyncVideoStream(){} // RVA: 0x821F7C0
        public void FromSyncVideoStream(){} // RVA: 0x821F840
        public void AsSyncAnim(){} // RVA: 0x821F940
        public void FromSyncAnim(){} // RVA: 0x821F9C0
        public void AsDataStorage(){} // RVA: 0x821FAC0
        public void FromDataStorage(){} // RVA: 0x821FB40
        public void AsPoseRecorder(){} // RVA: 0x821FC40
        public void FromPoseRecorder(){} // RVA: 0x821FCC0
        public void AsUdon(){} // RVA: 0x821FDC0
        public void FromUdon(){} // RVA: 0x821FE40
        public void AsObjectPool(){} // RVA: 0x821FF40
        public void FromObjectPool(){} // RVA: 0x821FFC0
        public void Pack(){} // RVA: 0x82200C0
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8220710
    }

    public class SparseSerializedObjects : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x8217320
        public void VerifySparseSerializedObjects(){} // RVA: 0x8224E90
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Objects(){} // RVA: 0x9B7B70
        public void Bitmap(){} // RVA: 0x9B7BA0
        public void get_BitmapLength(){} // RVA: 0x9B5CF0
        public void GetBitmapBytes(){} // RVA: 0x9B7BB0
        public void GetBitmapArray(){} // RVA: 0x9B7C20
        public void CreateSparseSerializedObjects(){} // RVA: 0x8225200
        public void StartSparseSerializedObjects(){} // RVA: 0x82186D0
        public void AddObjects(){} // RVA: 0x82175B0
        public void AddBitmap(){} // RVA: 0x82188E0
        public void CreateBitmapVector(){} // RVA: 0x8217B40
        public void CreateBitmapVectorBlock(){} // RVA: 0x8225440
        public void StartBitmapVector(){} // RVA: 0x8217DF0
        public void EndSparseSerializedObjects(){} // RVA: 0x82254D0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B7C70
        public void UnPackTo(){} // RVA: 0x9B7C80
        public void Pack(){} // RVA: 0x82259A0
    }

    public class SparseSerializedObjectsT : Object
    {
        public object _objects;
        public object _bitmap;

        // ── Methods ──
        public void get_Objects(){} // RVA: 0xB5DBF0
        public void set_Objects(){} // RVA: 0xB44D60
        public void get_Bitmap(){} // RVA: 0xB465B0
        public void set_Bitmap(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8225A50
        public void DeserializeFromBinary(){} // RVA: 0x8225B00
        public void SerializeToBinary(){} // RVA: 0x8225BB0
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8225D30
    }

    public class SyncAnim : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSyncAnim(){} // RVA: 0x8217320
        public void VerifySyncAnim(){} // RVA: 0x8227920
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_AnimationIsPlaying(){} // RVA: 0x9B8340
        public void AnimationStates(){} // RVA: 0x9B8390
        public void get_AnimationStatesLength(){} // RVA: 0x9B5CF0
        public void AnimatorLayers(){} // RVA: 0x9B83C0
        public void get_AnimatorLayersLength(){} // RVA: 0x9B83F0
        public void AnimatorParametersType(){} // RVA: 0x9B8400
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x9B8410
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x9B8480
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x9B84F0
        public void AnimatorParameters(){} // RVA: 0xA94080
        public void get_AnimatorParametersLength(){} // RVA: 0x9B8500
        public void CreateSyncAnim(){} // RVA: 0x8228130
        public void StartSyncAnim(){} // RVA: 0x82282C0
        public void AddAnimationIsPlaying(){} // RVA: 0x82282E0
        public void AddAnimationStates(){} // RVA: 0x82188E0
        public void CreateAnimationStatesVector(){} // RVA: 0x8228350
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x82285E0
        public void StartAnimationStatesVector(){} // RVA: 0x8217DF0
        public void AddAnimatorLayers(){} // RVA: 0x82269C0
        public void CreateAnimatorLayersVector(){} // RVA: 0x8228350
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x8228860
        public void StartAnimatorLayersVector(){} // RVA: 0x8217DF0
        public void AddAnimatorParametersType(){} // RVA: 0x82288F0
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x8217B40
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x8228A90
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x8217DF0
        public void AddAnimatorParameters(){} // RVA: 0x8228B20
        public void CreateAnimatorParametersVector(){} // RVA: 0x8218920
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x8228CB0
        public void StartAnimatorParametersVector(){} // RVA: 0x8217DF0
        public void EndSyncAnim(){} // RVA: 0x8228D40
        public void FinishSyncAnimBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B8510
        public void UnPackTo(){} // RVA: 0x9B8520
        public void Pack(){} // RVA: 0x82298F0
    }

    public class SyncAnimT : Object
    {
        public object _animationIsPlaying;
        public object _animationStates;
        public object _animatorLayers;
        public object _animatorParameters;

        // ── Methods ──
        public void get_AnimationIsPlaying(){} // RVA: 0xC120A0
        public void set_AnimationIsPlaying(){} // RVA: 0xC120B0
        public void get_AnimationStates(){} // RVA: 0xB465B0
        public void set_AnimationStates(){} // RVA: 0xBA9BA0
        public void get_AnimatorLayers(){} // RVA: 0xB700F0
        public void set_AnimatorLayers(){} // RVA: 0xB70100
        public void get_AnimatorParameters(){} // RVA: 0xB70160
        public void set_AnimatorParameters(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0x8229ED0
        public void DeserializeFromBinary(){} // RVA: 0x8229FE0
        public void SerializeToBinary(){} // RVA: 0x822A090
    }

    public class SyncAnimVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x822A190
    }

    public class SyncPhysicsData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Flags(){} // RVA: 0x9B64A0
        public void get_Position(){} // RVA: 0x9B8870
        public void get_Rotation(){} // RVA: 0x9B88B0
        public void CreateSyncPhysicsData(){} // RVA: 0x822A3A0
        public void UnPack(){} // RVA: 0x9B88F0
        public void UnPackTo(){} // RVA: 0x9B8900
        public void Pack(){} // RVA: 0x822A8E0
    }

    public class SyncPhysicsDataSparseRotation : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Flags(){} // RVA: 0x9B64A0
        public void get_Position(){} // RVA: 0x9B8870
        public void get_RotationAroundY(){} // RVA: 0x9B89D0
        public void CreateSyncPhysicsDataSparseRotation(){} // RVA: 0x822AB90
        public void UnPack(){} // RVA: 0x9B8A00
        public void UnPackTo(){} // RVA: 0x9B8B00
        public void Pack(){} // RVA: 0x822AF50
    }

    public class SyncPhysicsDataSparseRotationT : Object
    {
        public object _flags;
        public object _position;
        public object _rotationAroundY;

        // ── Methods ──
        public void get_Flags(){} // RVA: 0xC120A0
        public void set_Flags(){} // RVA: 0xC120B0
        public void get_Position(){} // RVA: 0xB465B0
        public void set_Position(){} // RVA: 0xBA9BA0
        public void get_RotationAroundY(){} // RVA: 0xC38360
        public void set_RotationAroundY(){} // RVA: 0xC38370
        public void .ctor(){} // RVA: 0x822B020
    }

    public class SyncPhysicsDataT : Object
    {
        public object _flags;
        public object _position;
        public object _rotation;

        // ── Methods ──
        public void get_Flags(){} // RVA: 0xC120A0
        public void set_Flags(){} // RVA: 0xC120B0
        public void get_Position(){} // RVA: 0xB465B0
        public void set_Position(){} // RVA: 0xBA9BA0
        public void get_Rotation(){} // RVA: 0xB700F0
        public void set_Rotation(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x822AA20
    }

    public class SyncVideoPlayer : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_IsPlaying(){} // RVA: 0x9B8340
        public void get_Time(){} // RVA: 0x9B7D50
        public void get_PlaybackSpeed(){} // RVA: 0x9B8BD0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x9B8C20
        public void CreateSyncVideoPlayer(){} // RVA: 0x822B160
        public void StartSyncVideoPlayer(){} // RVA: 0x822B360
        public void AddIsPlaying(){} // RVA: 0x82282E0
        public void AddTime(){} // RVA: 0x8226950
        public void AddPlaybackSpeed(){} // RVA: 0x822B380
        public void AddCurrentPlaylistIndex(){} // RVA: 0x822B3F0
        public void EndSyncVideoPlayer(){} // RVA: 0x822B460
        public void UnPack(){} // RVA: 0x9B8C70
        public void UnPackTo(){} // RVA: 0x9B8C80
        public void Pack(){} // RVA: 0x822B670
    }

    public class SyncVideoPlayerT : Object
    {
        public object _isPlaying;
        public object _time;
        public object _playbackSpeed;
        public object _currentPlaylistIndex;

        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0xC120A0
        public void set_IsPlaying(){} // RVA: 0xC120B0
        public void get_Time(){} // RVA: 0xC76400
        public void set_Time(){} // RVA: 0xC76410
        public void get_PlaybackSpeed(){} // RVA: 0x31D74A0
        public void set_PlaybackSpeed(){} // RVA: 0x4FB44B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x31D74B0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x6536960
        public void .ctor(){} // RVA: 0x822B6B0
    }

    public class SyncVideoPlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x822B6C0
    }

    public class SyncVideoStream : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsSyncVideoStream(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_IsPlaying(){} // RVA: 0x9B8340
        public void get_Time(){} // RVA: 0x9B7D50
        public void get_PlaybackRate(){} // RVA: 0x9B8BD0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x9B8C20
        public void get_SyncType(){} // RVA: 0x9B6850
        public void get_SyncMinutes(){} // RVA: 0x9B8D50
        public void CreateSyncVideoStream(){} // RVA: 0x822B850
        public void StartSyncVideoStream(){} // RVA: 0x822BAF0
        public void AddIsPlaying(){} // RVA: 0x82282E0
        public void AddTime(){} // RVA: 0x8226950
        public void AddPlaybackRate(){} // RVA: 0x822B380
        public void AddCurrentPlaylistIndex(){} // RVA: 0x822B3F0
        public void AddSyncType(){} // RVA: 0x821DAF0
        public void AddSyncMinutes(){} // RVA: 0x822BB10
        public void EndSyncVideoStream(){} // RVA: 0x822BB80
        public void UnPack(){} // RVA: 0x9B8DA0
        public void UnPackTo(){} // RVA: 0x9B8DB0
        public void Pack(){} // RVA: 0x822BDF0
    }

    public class SyncVideoStreamT : Object
    {
        public object _isPlaying;
        public object _time;
        public object _playbackRate;
        public object _currentPlaylistIndex;
        public object _syncType;
        public object _syncMinutes;

        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0xC120A0
        public void set_IsPlaying(){} // RVA: 0xC120B0
        public void get_Time(){} // RVA: 0xC76400
        public void set_Time(){} // RVA: 0xC76410
        public void get_PlaybackRate(){} // RVA: 0x31D74A0
        public void set_PlaybackRate(){} // RVA: 0x4FB44B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x31D74B0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x6536960
        public void get_SyncType(){} // RVA: 0xB5DC00
        public void set_SyncType(){} // RVA: 0xB5DC10
        public void get_SyncMinutes(){} // RVA: 0x822BE40
        public void set_SyncMinutes(){} // RVA: 0x822BE50
        public void .ctor(){} // RVA: 0x822BE60
    }

    public class SyncVideoStreamVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x822BE80
    }

}