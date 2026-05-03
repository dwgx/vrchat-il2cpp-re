// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 19
// Methods: 248

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class SerializedObjects : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x49
        public object field_2; // 0x4A

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFE881271C0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void ObjectsType(){} // RVA: 0x7FFE8811E240
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFE8811E2C0
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFE881272B0
        public void GetObjectsTypeArray(){} // RVA: 0x7FFE88127320
        public void Objects(){} // RVA: 0x7FFE810A1420
        public void get_ObjectsLength(){} // RVA: 0x7FFE8811EED0
        public void CreateSerializedObjects(){} // RVA: 0x7FFE881274D0
        public void StartSerializedObjects(){} // RVA: 0x7FFE8811F030
        public void AddObjectsType(){} // RVA: 0x7FFE8811DF20
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFE88127720 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFE8811E750
        public void AddObjects(){} // RVA: 0x7FFE8811F240
        public void CreateObjectsVector(){} // RVA: 0x7FFE8811F280
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFE88127900 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFE8811E750
        public void EndSerializedObjects(){} // RVA: 0x7FFE88127990
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE88127A20
        public void UnPackTo(){} // RVA: 0x7FFE88127AD0
        public void Pack(){} // RVA: 0x7FFE881284E0
    }

    public class SerializedObjectsT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.SerializedTypeUnion> _objects; // 0x10

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFE81116380
        public void set_Objects(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE881287B0
        public void SerializeToBinary(){} // RVA: 0x7FFE88128860
    }

    public class SerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8811EB50
    }

    public class SerializedTypeUnion : Object
    {
        public 0x665F5D14 _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsSyncPhysicsData(){} // RVA: 0x7FFE88125DB0
        public void FromSyncPhysicsData(){} // RVA: 0x7FFE88125DF0
        public void AsDestructiblePlayer(){} // RVA: 0x7FFE88125EF0
        public void FromDestructiblePlayer(){} // RVA: 0x7FFE88125F30
        public void AsSyncVideoPlayer(){} // RVA: 0x7FFE88126030
        public void FromSyncVideoPlayer(){} // RVA: 0x7FFE88126070
        public void AsSyncVideoStream(){} // RVA: 0x7FFE88126170
        public void FromSyncVideoStream(){} // RVA: 0x7FFE881261B0
        public void AsSyncAnim(){} // RVA: 0x7FFE881262B0
        public void FromSyncAnim(){} // RVA: 0x7FFE881262F0
        public void AsDataStorage(){} // RVA: 0x7FFE881263F0
        public void FromDataStorage(){} // RVA: 0x7FFE88126430
        public void AsPoseRecorder(){} // RVA: 0x7FFE88126530
        public void FromPoseRecorder(){} // RVA: 0x7FFE88126570
        public void AsUdon(){} // RVA: 0x7FFE88126670
        public void FromUdon(){} // RVA: 0x7FFE881266B0
        public void AsObjectPool(){} // RVA: 0x7FFE881267B0
        public void FromObjectPool(){} // RVA: 0x7FFE881267F0
        public void Pack(){} // RVA: 0x7FFE881268F0
    }

    public class SerializedTypeVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88126DB0
    }

    public class SparseSerializedObjects : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x116
        public object field_2; // 0x117

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFE8812B3E0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Objects(){} // RVA: 0x7FFE8812B4D0
        public void Bitmap(){} // RVA: 0x7FFE8812B610
        public void get_BitmapLength(){} // RVA: 0x7FFE8811EED0
        public void GetBitmapBytes(){} // RVA: 0x7FFE8812B690
        public void GetBitmapArray(){} // RVA: 0x7FFE8812B700
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFE8812B750
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFE8811F030
        public void AddObjects(){} // RVA: 0x7FFE8811DF20
        public void AddBitmap(){} // RVA: 0x7FFE8811F240
        public void CreateBitmapVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFE8812B990 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFE8811E750
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFE8812BA20
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE8812BAB0
        public void UnPackTo(){} // RVA: 0x7FFE8812BBC0
        public void Pack(){} // RVA: 0x7FFE8812BEF0
    }

    public class SparseSerializedObjectsT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.SerializedObjectsT _objects; // 0x10
        public System.Collections.Generic.List`1<byte> _bitmap; // 0x18

        // ── Methods ──
        public void get_Objects(){} // RVA: 0x7FFE81116380
        public void set_Objects(){} // RVA: 0x7FFE810FCE30
        public void get_Bitmap(){} // RVA: 0x7FFE810FE7C0
        public void set_Bitmap(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8812BFA0
        public void DeserializeFromBinary(){} // RVA: 0x7FFE8812C050
        public void SerializeToBinary(){} // RVA: 0x7FFE8812C100
    }

    public class SparseSerializedObjectsVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8812C280
    }

    public class SyncAnim : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x134
        public object field_2; // 0x135
        public object field_3; // 0x136
        public object field_4; // 0x137
        public object field_5; // 0x138

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSyncAnim(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifySyncAnim(){} // RVA: 0x7FFE8812DD00
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_AnimationIsPlaying(){} // RVA: 0x7FFE8812DDF0
        public void AnimationStates(){} // RVA: 0x7FFE8812DE40
        public void get_AnimationStatesLength(){} // RVA: 0x7FFE8811EED0
        public void AnimatorLayers(){} // RVA: 0x7FFE8812DFB0
        public void get_AnimatorLayersLength(){} // RVA: 0x7FFE8812E120
        public void AnimatorParametersType(){} // RVA: 0x7FFE8812E190
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x7FFE8812E210
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x7FFE8812E280
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x7FFE8812E2F0
        public void AnimatorParameters(){} // RVA: 0x7FFE810A1420
        public void get_AnimatorParametersLength(){} // RVA: 0x7FFE8812E4A0
        public void CreateSyncAnim(){} // RVA: 0x7FFE8812E510
        public void StartSyncAnim(){} // RVA: 0x7FFE8812E6A0
        public void AddAnimationIsPlaying(){} // RVA: 0x7FFE8812E6C0
        public void AddAnimationStates(){} // RVA: 0x7FFE8811F240
        public void CreateAnimationStatesVector(){} // RVA: 0x7FFE8811F280
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7FFE8812E920 | overloaded x3
        public void StartAnimationStatesVector(){} // RVA: 0x7FFE8811E750
        public void AddAnimatorLayers(){} // RVA: 0x7FFE8812CDA0
        public void CreateAnimatorLayersVector(){} // RVA: 0x7FFE8811F280
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7FFE8812EBA0 | overloaded x3
        public void StartAnimatorLayersVector(){} // RVA: 0x7FFE8811E750
        public void AddAnimatorParametersType(){} // RVA: 0x7FFE8812EC30
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7FFE8812EDD0 | overloaded x3
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x7FFE8811E750
        public void AddAnimatorParameters(){} // RVA: 0x7FFE8812EE60
        public void CreateAnimatorParametersVector(){} // RVA: 0x7FFE8811F280
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7FFE8812EFF0 | overloaded x3
        public void StartAnimatorParametersVector(){} // RVA: 0x7FFE8811E750
        public void EndSyncAnim(){} // RVA: 0x7FFE8812F080
        public void FinishSyncAnimBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE8812F110
        public void UnPackTo(){} // RVA: 0x7FFE8812F270
        public void Pack(){} // RVA: 0x7FFE8812FC30
    }

    public class SyncAnimT : Object
    {
        public bool _animationIsPlaying; // 0x10
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.AnimationStateT> _animationStates; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.AnimatorLayerT> _animatorLayers; // 0x20
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.AnimatorParameterUnion> _animatorParameters; // 0x28

        // ── Methods ──
        public void get_AnimationIsPlaying(){} // RVA: 0x7FFE811C55E0
        public void set_AnimationIsPlaying(){} // RVA: 0x7FFE811C55F0
        public void get_AnimationStates(){} // RVA: 0x7FFE810FE7C0
        public void set_AnimationStates(){} // RVA: 0x7FFE81161E80
        public void get_AnimatorLayers(){} // RVA: 0x7FFE811290C0
        public void set_AnimatorLayers(){} // RVA: 0x7FFE811290D0
        public void get_AnimatorParameters(){} // RVA: 0x7FFE81129130
        public void set_AnimatorParameters(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE881302F0
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88130400
        public void SerializeToBinary(){} // RVA: 0x7FFE881304B0
    }

    public class SyncAnimVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE881305B0
    }

    public class SyncPhysicsData : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x13E
        public object field_2; // 0x13F
        public object field_3; // 0x140

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Flags(){} // RVA: 0x7FFE88122E10
        public void get_Position(){} // RVA: 0x7FFE88130740
        public void get_Rotation(){} // RVA: 0x7FFE88130780
        public void CreateSyncPhysicsData(){} // RVA: 0x7FFE881307C0
        public void UnPack(){} // RVA: 0x7FFE88130990
        public void UnPackTo(){} // RVA: 0x7FFE88130B20
        public void Pack(){} // RVA: 0x7FFE88130D10
    }

    public class SyncPhysicsDataT : Object
    {
        public byte _flags; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3BytesT _position; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionTenBitT _rotation; // 0x20

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7FFE811C55E0
        public void set_Flags(){} // RVA: 0x7FFE811C55F0
        public void get_Position(){} // RVA: 0x7FFE810FE7C0
        public void set_Position(){} // RVA: 0x7FFE81161E80
        public void get_Rotation(){} // RVA: 0x7FFE811290C0
        public void set_Rotation(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE88130E50
    }

    public class SyncVideoPlayer : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x145
        public object field_2; // 0x146
        public object field_3; // 0x147
        public object field_4; // 0x148

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_IsPlaying(){} // RVA: 0x7FFE8812DDF0
        public void get_Time(){} // RVA: 0x7FFE8812C930
        public void get_PlaybackSpeed(){} // RVA: 0x7FFE88130F90
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFE88130FE0
        public void CreateSyncVideoPlayer(){} // RVA: 0x7FFE88131030
        public void StartSyncVideoPlayer(){} // RVA: 0x7FFE88131230
        public void AddIsPlaying(){} // RVA: 0x7FFE8812E6C0
        public void AddTime(){} // RVA: 0x7FFE8812CD30
        public void AddPlaybackSpeed(){} // RVA: 0x7FFE88131250
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7FFE881312C0
        public void EndSyncVideoPlayer(){} // RVA: 0x7FFE88131330
        public void UnPack(){} // RVA: 0x7FFE881313C0
        public void UnPackTo(){} // RVA: 0x7FFE88131430
        public void Pack(){} // RVA: 0x7FFE88131540
    }

    public class SyncVideoPlayerT : Object
    {
        public bool _isPlaying; // 0x10
        public float _time; // 0x14
        public short _playbackSpeed; // 0x18
        public short _currentPlaylistIndex; // 0x1A

        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x7FFE811C55E0
        public void set_IsPlaying(){} // RVA: 0x7FFE811C55F0
        public void get_Time(){} // RVA: 0x7FFE81225340
        public void set_Time(){} // RVA: 0x7FFE81225350
        public void get_PlaybackSpeed(){} // RVA: 0x7FFE84290FC0
        public void set_PlaybackSpeed(){} // RVA: 0x7FFE850AB060
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFE863989E0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x7FFE865FCE00
        public void .ctor(){} // RVA: 0x7FFE88131580
    }

    public class SyncVideoPlayerVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88131590
    }

    public class SyncVideoStream : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x14E
        public object field_2; // 0x14F
        public object field_3; // 0x150
        public object field_4; // 0x151
        public object field_5; // 0x152
        public object field_6; // 0x153

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsSyncVideoStream(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_IsPlaying(){} // RVA: 0x7FFE8812DDF0
        public void get_Time(){} // RVA: 0x7FFE8812C930
        public void get_PlaybackRate(){} // RVA: 0x7FFE88130F90
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFE88130FE0
        public void get_SyncType(){} // RVA: 0x7FFE881235E0
        public void get_SyncMinutes(){} // RVA: 0x7FFE881316D0
        public void CreateSyncVideoStream(){} // RVA: 0x7FFE88131720
        public void StartSyncVideoStream(){} // RVA: 0x7FFE881319C0
        public void AddIsPlaying(){} // RVA: 0x7FFE8812E6C0
        public void AddTime(){} // RVA: 0x7FFE8812CD30
        public void AddPlaybackRate(){} // RVA: 0x7FFE88131250
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7FFE881312C0
        public void AddSyncType(){} // RVA: 0x7FFE88124430
        public void AddSyncMinutes(){} // RVA: 0x7FFE881319E0
        public void EndSyncVideoStream(){} // RVA: 0x7FFE88131A50
        public void UnPack(){} // RVA: 0x7FFE88131AE0
        public void UnPackTo(){} // RVA: 0x7FFE88131B50
        public void Pack(){} // RVA: 0x7FFE88131CC0
    }

    public class SyncVideoStreamT : Object
    {
        public bool _isPlaying; // 0x10
        public float _time; // 0x14
        public short _playbackRate; // 0x18
        public short _currentPlaylistIndex; // 0x1A
        public byte _syncType; // 0x1C
        public short _syncMinutes; // 0x1E

        // ── Methods ──
        public void get_IsPlaying(){} // RVA: 0x7FFE811C55E0
        public void set_IsPlaying(){} // RVA: 0x7FFE811C55F0
        public void get_Time(){} // RVA: 0x7FFE81225340
        public void set_Time(){} // RVA: 0x7FFE81225350
        public void get_PlaybackRate(){} // RVA: 0x7FFE84290FC0
        public void set_PlaybackRate(){} // RVA: 0x7FFE850AB060
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFE863989E0
        public void set_CurrentPlaylistIndex(){} // RVA: 0x7FFE865FCE00
        public void get_SyncType(){} // RVA: 0x7FFE81116390
        public void set_SyncType(){} // RVA: 0x7FFE811163A0
        public void get_SyncMinutes(){} // RVA: 0x7FFE88131D10
        public void set_SyncMinutes(){} // RVA: 0x7FFE88131D20
        public void .ctor(){} // RVA: 0x7FFE88131D30
    }

    public class SyncVideoStreamVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88131D50
    }

}