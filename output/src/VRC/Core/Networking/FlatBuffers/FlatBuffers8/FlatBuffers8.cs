// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 591

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimatorParameterUnion : Object
    {
        public 0x6655CF50 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsAnimatorBool(){} // RVA: 0x7FFD551A4480
        public void FromAnimatorBool(){} // RVA: 0x7FFD551A44C0
        public void AsAnimatorInt(){} // RVA: 0x7FFD551A45C0
        public void FromAnimatorInt(){} // RVA: 0x7FFD551A4600
        public void AsAnimatorFloat(){} // RVA: 0x7FFD551A4700
        public void FromAnimatorFloat(){} // RVA: 0x7FFD551A4740
        public void Pack(){} // RVA: 0x7FFD551A4840
    }

    public class DataStorage : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsDataStorage(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifyDataStorage(){} // RVA: 0x7FFD55196630
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void EntriesType(){} // RVA: 0x7FFD55195C20
        public void get_EntriesTypeLength(){} // RVA: 0x7FFD55195CA0
        public void GetEntriesTypeBytes(){} // RVA: 0x7FFD55196720
        public void GetEntriesTypeArray(){} // RVA: 0x7FFD55196790
        public void Entries(){} // RVA: 0x7FFD4E2ADC40
        public void get_EntriesLength(){} // RVA: 0x7FFD55196940
        public void CreateDataStorage(){} // RVA: 0x7FFD551969B0
        public void StartDataStorage(){} // RVA: 0x7FFD55196AA0
        public void AddEntriesType(){} // RVA: 0x7FFD55195900
        public void CreateEntriesTypeVector(){} // RVA: 0x7FFD55195F20
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7FFD55196C20 | overloaded x3
        public void StartEntriesTypeVector(){} // RVA: 0x7FFD551961C0
        public void AddEntries(){} // RVA: 0x7FFD55196CB0
        public void CreateEntriesVector(){} // RVA: 0x7FFD55196CF0
        public void CreateEntriesVectorBlock(){} // RVA: 0x7FFD55196ED0 | overloaded x3
        public void StartEntriesVector(){} // RVA: 0x7FFD551961C0
        public void EndDataStorage(){} // RVA: 0x7FFD55196F60
        public void FinishDataStorageBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD551970D0
        public void UnPackTo(){} // RVA: 0x7FFD55197180
        public void Pack(){} // RVA: 0x7FFD551978B0
    }

    public class DataStorageEntryUnion : Object
    {
        public 0x6655B638 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsDataStorageBool(){} // RVA: 0x7FFD551944C0
        public void FromDataStorageBool(){} // RVA: 0x7FFD55194500
        public void AsDataStorageInt(){} // RVA: 0x7FFD55194600
        public void FromDataStorageInt(){} // RVA: 0x7FFD55194640
        public void AsDataStorageFloat(){} // RVA: 0x7FFD55194740
        public void FromDataStorageFloat(){} // RVA: 0x7FFD55194780
        public void AsDataStorageString(){} // RVA: 0x7FFD55194880
        public void FromDataStorageString(){} // RVA: 0x7FFD551948C0
        public void AsDataStorageBytes(){} // RVA: 0x7FFD551949C0
        public void FromDataStorageBytes(){} // RVA: 0x7FFD55194A00
        public void Pack(){} // RVA: 0x7FFD55194B00
    }

    public class DestructiblePlayer : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifyDestructiblePlayer(){} // RVA: 0x7FFD55197DF0
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Health(){} // RVA: 0x7FFD55197EE0
        public void MutateHealth(){} // RVA: 0x7FFD55197F30
        public void CreateDestructiblePlayer(){} // RVA: 0x7FFD55197F90
        public void StartDestructiblePlayer(){} // RVA: 0x7FFD551958E0
        public void AddHealth(){} // RVA: 0x7FFD55198090
        public void EndDestructiblePlayer(){} // RVA: 0x7FFD55198110
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD551981A0
        public void UnPackTo(){} // RVA: 0x7FFD55198240
        public void Pack(){} // RVA: 0x7FFD551982A0
    }

    public class ObjectPool : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFD55198580
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void Data(){} // RVA: 0x7FFD55195C20
        public void get_DataLength(){} // RVA: 0x7FFD55195CA0
        public void GetDataBytes(){} // RVA: 0x7FFD55198670
        public void GetDataArray(){} // RVA: 0x7FFD551986E0
        public void MutateData(){} // RVA: 0x7FFD55195DD0
        public void CreateObjectPool(){} // RVA: 0x7FFD55198730
        public void StartObjectPool(){} // RVA: 0x7FFD551958E0
        public void AddData(){} // RVA: 0x7FFD55195900
        public void CreateDataVector(){} // RVA: 0x7FFD55195F20
        public void CreateDataVectorBlock(){} // RVA: 0x7FFD55198940 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFD551961C0
        public void EndObjectPool(){} // RVA: 0x7FFD551989D0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD55198A60
        public void UnPackTo(){} // RVA: 0x7FFD55198B10
        public void Pack(){} // RVA: 0x7FFD55198D20
    }

    public class PlayerDrone : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsPlayerDrone(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifyPlayerDrone(){} // RVA: 0x7FFD55199000
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Throttle(){} // RVA: 0x7FFD55197EE0
        public void MutateThrottle(){} // RVA: 0x7FFD55197F30
        public void CreatePlayerDrone(){} // RVA: 0x7FFD551990F0
        public void StartPlayerDrone(){} // RVA: 0x7FFD551958E0
        public void AddThrottle(){} // RVA: 0x7FFD55198090
        public void EndPlayerDrone(){} // RVA: 0x7FFD551991F0
        public void FinishPlayerDroneBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD55199280
        public void UnPackTo(){} // RVA: 0x7FFD55198240
        public void Pack(){} // RVA: 0x7FFD55199320
    }

    public class PosePositionDataUnion : Object
    {
        public 0x6655BF80 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsPoseMuscleData(){} // RVA: 0x7FFD55199570
        public void FromPoseMuscleData(){} // RVA: 0x7FFD55199630
        public void Pack(){} // RVA: 0x7FFD55199730
    }

    public class PoseRecorder : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsPoseRecorder(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifyPoseRecorder(){} // RVA: 0x7FFD5519AF80
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Contents(){} // RVA: 0x7FFD5519B070
        public void MutateContents(){} // RVA: 0x7FFD5519B0C0
        public void get_MotionFlags(){} // RVA: 0x7FFD5519B120
        public void MutateMotionFlags(){} // RVA: 0x7FFD5519B170
        public void get_ExtraFlags(){} // RVA: 0x7FFD5519B1D0
        public void MutateExtraFlags(){} // RVA: 0x7FFD5519B220
        public void get_StandingHeight(){} // RVA: 0x7FFD5519B280
        public void MutateStandingHeight(){} // RVA: 0x7FFD5519B2D0
        public void get_AngVelocity(){} // RVA: 0x7FFD5519B330
        public void MutateAngVelocity(){} // RVA: 0x7FFD5519B380
        public void get_Gestures(){} // RVA: 0x7FFD5519B3E0
        public void get_Fingers(){} // RVA: 0x7FFD5519B4F0
        public void get_PoseType(){} // RVA: 0x7FFD5519B600
        public void Pose(){} // RVA: 0x7FFD4E2ADC40
        public void PoseAsPoseMuscleData(){} // RVA: 0x7FFD5519B650
        public void get_Puppet(){} // RVA: 0x7FFD5519B6E0
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFD5519B7F0
        public void get_EyeClosedAmount(){} // RVA: 0x7FFD5519B900
        public void MutateEyeClosedAmount(){} // RVA: 0x7FFD5519B950
        public void get_SpineLengthFactor(){} // RVA: 0x7FFD5519B9B0
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFD5519BAC0
        public void CreatePoseRecorder(){} // RVA: 0x7FFD5519BBD0
        public void StartPoseRecorder(){} // RVA: 0x7FFD5519C060
        public void AddContents(){} // RVA: 0x7FFD5519C080
        public void AddMotionFlags(){} // RVA: 0x7FFD5519C0F0
        public void AddExtraFlags(){} // RVA: 0x7FFD5519C160
        public void AddStandingHeight(){} // RVA: 0x7FFD5519C1D0
        public void AddAngVelocity(){} // RVA: 0x7FFD5519C240
        public void AddGestures(){} // RVA: 0x7FFD5519C2B0
        public void AddFingers(){} // RVA: 0x7FFD5519C2E0
        public void AddPoseType(){} // RVA: 0x7FFD5519C310
        public void AddPose(){} // RVA: 0x7FFD5519C380
        public void AddPuppet(){} // RVA: 0x7FFD5519C3C0
        public void AddEyeLookTargetPosition(){} // RVA: 0x7FFD5519C3F0
        public void AddEyeClosedAmount(){} // RVA: 0x7FFD5519C420
        public void AddSpineLengthFactor(){} // RVA: 0x7FFD5519C490
        public void AddFaceTrackedVisemes(){} // RVA: 0x7FFD5519C4C0
        public void EndPoseRecorder(){} // RVA: 0x7FFD5519C4F0
        public void FinishPoseRecorderBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD5519C580
        public void UnPackTo(){} // RVA: 0x7FFD5519C5F0
        public void Pack(){} // RVA: 0x7FFD5519D070
    }

    public class QuaternionT : Object
    {
        public float identity; // 0x10
        public float magnitude; // 0x14
        public float sqrMagnitude; // 0x18
        public float X; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55192C50 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD551922D0
        public void ToNumerics(){} // RVA: 0x7FFD55192300
        public void get_identity(){} // RVA: 0x7FFD55192320
        public void get_magnitude(){} // RVA: 0x7FFD55192370
        public void get_sqrMagnitude(){} // RVA: 0x7FFD55192420
        public void Slerp(){} // RVA: 0x7FFD55192540 | overloaded x2
        public void Inverse(){} // RVA: 0x7FFD551925D0
        public void op_Multiply(){} // RVA: 0x7FFD551926D0
        public void IsBad(){} // RVA: 0x7FFD55192880
        public void Normalize(){} // RVA: 0x7FFD55192900
        public void ToString(){} // RVA: 0x7FFD55192A00
        public void get_X(){} // RVA: 0x7FFD4E46B320
        public void set_X(){} // RVA: 0x7FFD4E46B330
        public void get_Y(){} // RVA: 0x7FFD4E46B340
        public void set_Y(){} // RVA: 0x7FFD4E46B350
        public void get_Z(){} // RVA: 0x7FFD4E345CF0
        public void set_Z(){} // RVA: 0x7FFD4E35C4D0
        public void get_W(){} // RVA: 0x7FFD4E40E570
        public void set_W(){} // RVA: 0x7FFD4E40E580
    }

    public class SerializedObjects : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSerializedObjects(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifySerializedObjects(){} // RVA: 0x7FFD5519EFD0
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void ObjectsType(){} // RVA: 0x7FFD55195C20
        public void get_ObjectsTypeLength(){} // RVA: 0x7FFD55195CA0
        public void GetObjectsTypeBytes(){} // RVA: 0x7FFD5519F0C0
        public void GetObjectsTypeArray(){} // RVA: 0x7FFD5519F130
        public void Objects(){} // RVA: 0x7FFD4E2ADC40
        public void get_ObjectsLength(){} // RVA: 0x7FFD55196940
        public void CreateSerializedObjects(){} // RVA: 0x7FFD5519F2E0
        public void StartSerializedObjects(){} // RVA: 0x7FFD55196AA0
        public void AddObjectsType(){} // RVA: 0x7FFD55195900
        public void CreateObjectsTypeVector(){} // RVA: 0x7FFD55195F20
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7FFD5519F530 | overloaded x3
        public void StartObjectsTypeVector(){} // RVA: 0x7FFD551961C0
        public void AddObjects(){} // RVA: 0x7FFD55196CB0
        public void CreateObjectsVector(){} // RVA: 0x7FFD55196CF0
        public void CreateObjectsVectorBlock(){} // RVA: 0x7FFD5519F710 | overloaded x3
        public void StartObjectsVector(){} // RVA: 0x7FFD551961C0
        public void EndSerializedObjects(){} // RVA: 0x7FFD5519F7A0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD5519F830
        public void UnPackTo(){} // RVA: 0x7FFD5519F8E0
        public void Pack(){} // RVA: 0x7FFD551A02F0
    }

    public class SerializedTypeUnion : Object
    {
        public 0x6655C450 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsSyncPhysicsData(){} // RVA: 0x7FFD5519DBC0
        public void FromSyncPhysicsData(){} // RVA: 0x7FFD5519DC00
        public void AsDestructiblePlayer(){} // RVA: 0x7FFD5519DD00
        public void FromDestructiblePlayer(){} // RVA: 0x7FFD5519DD40
        public void AsSyncVideoPlayer(){} // RVA: 0x7FFD5519DE40
        public void FromSyncVideoPlayer(){} // RVA: 0x7FFD5519DE80
        public void AsSyncVideoStream(){} // RVA: 0x7FFD5519DF80
        public void FromSyncVideoStream(){} // RVA: 0x7FFD5519DFC0
        public void AsSyncAnim(){} // RVA: 0x7FFD5519E0C0
        public void FromSyncAnim(){} // RVA: 0x7FFD5519E100
        public void AsDataStorage(){} // RVA: 0x7FFD5519E200
        public void FromDataStorage(){} // RVA: 0x7FFD5519E240
        public void AsPoseRecorder(){} // RVA: 0x7FFD5519E340
        public void FromPoseRecorder(){} // RVA: 0x7FFD5519E380
        public void AsUdon(){} // RVA: 0x7FFD5519E480
        public void FromUdon(){} // RVA: 0x7FFD5519E4C0
        public void AsObjectPool(){} // RVA: 0x7FFD5519E5C0
        public void FromObjectPool(){} // RVA: 0x7FFD5519E600
        public void Pack(){} // RVA: 0x7FFD5519E700
    }

    public class SparseSerializedObjects : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifySparseSerializedObjects(){} // RVA: 0x7FFD551A3420
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Objects(){} // RVA: 0x7FFD551A3510
        public void Bitmap(){} // RVA: 0x7FFD551A3650
        public void get_BitmapLength(){} // RVA: 0x7FFD55196940
        public void GetBitmapBytes(){} // RVA: 0x7FFD551A36D0
        public void GetBitmapArray(){} // RVA: 0x7FFD551A3740
        public void MutateBitmap(){} // RVA: 0x7FFD551A3790
        public void CreateSparseSerializedObjects(){} // RVA: 0x7FFD551A3820
        public void StartSparseSerializedObjects(){} // RVA: 0x7FFD55196AA0
        public void AddObjects(){} // RVA: 0x7FFD55195900
        public void AddBitmap(){} // RVA: 0x7FFD55196CB0
        public void CreateBitmapVector(){} // RVA: 0x7FFD55195F20
        public void CreateBitmapVectorBlock(){} // RVA: 0x7FFD551A3A60 | overloaded x3
        public void StartBitmapVector(){} // RVA: 0x7FFD551961C0
        public void EndSparseSerializedObjects(){} // RVA: 0x7FFD551A3AF0
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD551A3B80
        public void UnPackTo(){} // RVA: 0x7FFD551A3C90
        public void Pack(){} // RVA: 0x7FFD551A3FC0
    }

    public class SyncAnim : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSyncAnim(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifySyncAnim(){} // RVA: 0x7FFD551A5F70
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_AnimationIsPlaying(){} // RVA: 0x7FFD551A6060
        public void MutateAnimationIsPlaying(){} // RVA: 0x7FFD551A60B0
        public void AnimationStates(){} // RVA: 0x7FFD551A6110
        public void get_AnimationStatesLength(){} // RVA: 0x7FFD55196940
        public void AnimatorLayers(){} // RVA: 0x7FFD551A6280
        public void get_AnimatorLayersLength(){} // RVA: 0x7FFD551A63F0
        public void AnimatorParametersType(){} // RVA: 0x7FFD551A6460
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x7FFD551A64E0
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x7FFD551A6550
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x7FFD551A65C0
        public void AnimatorParameters(){} // RVA: 0x7FFD4E2ADC40
        public void get_AnimatorParametersLength(){} // RVA: 0x7FFD551A6770
        public void CreateSyncAnim(){} // RVA: 0x7FFD551A67E0
        public void StartSyncAnim(){} // RVA: 0x7FFD551A6970
        public void AddAnimationIsPlaying(){} // RVA: 0x7FFD551A6990
        public void AddAnimationStates(){} // RVA: 0x7FFD55196CB0
        public void CreateAnimationStatesVector(){} // RVA: 0x7FFD55196CF0
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7FFD551A6BF0 | overloaded x3
        public void StartAnimationStatesVector(){} // RVA: 0x7FFD551961C0
        public void AddAnimatorLayers(){} // RVA: 0x7FFD551A4F00
        public void CreateAnimatorLayersVector(){} // RVA: 0x7FFD55196CF0
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7FFD551A6E70 | overloaded x3
        public void StartAnimatorLayersVector(){} // RVA: 0x7FFD551961C0
        public void AddAnimatorParametersType(){} // RVA: 0x7FFD551A6F00
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x7FFD55195F20
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7FFD551A70A0 | overloaded x3
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x7FFD551961C0
        public void AddAnimatorParameters(){} // RVA: 0x7FFD551A7130
        public void CreateAnimatorParametersVector(){} // RVA: 0x7FFD55196CF0
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7FFD551A72C0 | overloaded x3
        public void StartAnimatorParametersVector(){} // RVA: 0x7FFD551961C0
        public void EndSyncAnim(){} // RVA: 0x7FFD551A7350
        public void FinishSyncAnimBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD551A73E0
        public void UnPackTo(){} // RVA: 0x7FFD551A7540
        public void Pack(){} // RVA: 0x7FFD551A7F00
    }

    public class SyncPhysicsData : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_Flags(){} // RVA: 0x7FFD5519A9A0
        public void MutateFlags(){} // RVA: 0x7FFD55195030
        public void get_Position(){} // RVA: 0x7FFD551A8A10
        public void get_Rotation(){} // RVA: 0x7FFD551A8A50
        public void CreateSyncPhysicsData(){} // RVA: 0x7FFD551A8A90
        public void UnPack(){} // RVA: 0x7FFD551A8C60
        public void UnPackTo(){} // RVA: 0x7FFD551A8DF0
        public void Pack(){} // RVA: 0x7FFD551A8FE0
    }

    public class SyncVideoPlayer : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_IsPlaying(){} // RVA: 0x7FFD551A6060
        public void MutateIsPlaying(){} // RVA: 0x7FFD551A60B0
        public void get_Time(){} // RVA: 0x7FFD551A4A00
        public void MutateTime(){} // RVA: 0x7FFD551A4A50
        public void get_PlaybackSpeed(){} // RVA: 0x7FFD551A9260
        public void MutatePlaybackSpeed(){} // RVA: 0x7FFD551A92B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFD551A9310
        public void MutateCurrentPlaylistIndex(){} // RVA: 0x7FFD551A9360
        public void CreateSyncVideoPlayer(){} // RVA: 0x7FFD551A93C0
        public void StartSyncVideoPlayer(){} // RVA: 0x7FFD551A95D0
        public void AddIsPlaying(){} // RVA: 0x7FFD551A6990
        public void AddTime(){} // RVA: 0x7FFD551A4E80
        public void AddPlaybackSpeed(){} // RVA: 0x7FFD551A95F0
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7FFD551A9660
        public void EndSyncVideoPlayer(){} // RVA: 0x7FFD551A96D0
        public void UnPack(){} // RVA: 0x7FFD551A9760
        public void UnPackTo(){} // RVA: 0x7FFD551A97D0
        public void Pack(){} // RVA: 0x7FFD551A98E0
    }

    public class SyncVideoStream : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsSyncVideoStream(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_IsPlaying(){} // RVA: 0x7FFD551A6060
        public void MutateIsPlaying(){} // RVA: 0x7FFD551A60B0
        public void get_Time(){} // RVA: 0x7FFD551A4A00
        public void MutateTime(){} // RVA: 0x7FFD551A4A50
        public void get_PlaybackRate(){} // RVA: 0x7FFD551A9260
        public void MutatePlaybackRate(){} // RVA: 0x7FFD551A92B0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7FFD551A9310
        public void MutateCurrentPlaylistIndex(){} // RVA: 0x7FFD551A9360
        public void get_SyncType(){} // RVA: 0x7FFD5519B330
        public void MutateSyncType(){} // RVA: 0x7FFD5519B380
        public void get_SyncMinutes(){} // RVA: 0x7FFD551A9A70
        public void MutateSyncMinutes(){} // RVA: 0x7FFD551A9AC0
        public void CreateSyncVideoStream(){} // RVA: 0x7FFD551A9B20
        public void StartSyncVideoStream(){} // RVA: 0x7FFD551A9DD0
        public void AddIsPlaying(){} // RVA: 0x7FFD551A6990
        public void AddTime(){} // RVA: 0x7FFD551A4E80
        public void AddPlaybackRate(){} // RVA: 0x7FFD551A95F0
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7FFD551A9660
        public void AddSyncType(){} // RVA: 0x7FFD5519C240
        public void AddSyncMinutes(){} // RVA: 0x7FFD551A9DF0
        public void EndSyncVideoStream(){} // RVA: 0x7FFD551A9E60
        public void UnPack(){} // RVA: 0x7FFD551A9EF0
        public void UnPackTo(){} // RVA: 0x7FFD551A9F60
        public void Pack(){} // RVA: 0x7FFD551AA0D0
    }

    public class Udon : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void ValidateVersion(){} // RVA: 0x7FFD4E341310
        public void GetRootAsUdon(){} // RVA: 0x7FFD55195670 | overloaded x2
        public void VerifyUdon(){} // RVA: 0x7FFD551B9350
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void DataType(){} // RVA: 0x7FFD55195C20
        public void get_DataTypeLength(){} // RVA: 0x7FFD55195CA0
        public void GetDataTypeBytes(){} // RVA: 0x7FFD551B9440
        public void GetDataTypeArray(){} // RVA: 0x7FFD551B94B0
        public void Data(){} // RVA: 0x7FFD4E2ADC40
        public void get_DataLength(){} // RVA: 0x7FFD55196940
        public void CreateUdon(){} // RVA: 0x7FFD551B9660
        public void StartUdon(){} // RVA: 0x7FFD55196AA0
        public void AddDataType(){} // RVA: 0x7FFD55195900
        public void CreateDataTypeVector(){} // RVA: 0x7FFD55195F20
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7FFD551B98B0 | overloaded x3
        public void StartDataTypeVector(){} // RVA: 0x7FFD551961C0
        public void AddData(){} // RVA: 0x7FFD55196CB0
        public void CreateDataVector(){} // RVA: 0x7FFD55196CF0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFD551B9A90 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFD551961C0
        public void EndUdon(){} // RVA: 0x7FFD551B9B20
        public void FinishUdonBuffer(){} // RVA: 0x7FFD55196FF0
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7FFD55197050
        public void UnPack(){} // RVA: 0x7FFD551B9BB0
        public void UnPackTo(){} // RVA: 0x7FFD551B9C60
        public void Pack(){} // RVA: 0x7FFD551BBC20
    }

    public class UdonValueUnion : Object
    {
        public 0x6655D840 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD4E40B5E0
        public void set_Type(){} // RVA: 0x7FFD4E40B5F0
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
        public void set_Value(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD55194460
        public void As(){} // RVA: 0x7FFD4E2ADC40
        public void AsUdonShort(){} // RVA: 0x7FFD551AA310
        public void FromUdonShort(){} // RVA: 0x7FFD551AA350
        public void AsUdonUShort(){} // RVA: 0x7FFD551AA450
        public void FromUdonUShort(){} // RVA: 0x7FFD551AA490
        public void AsUdonChar(){} // RVA: 0x7FFD551AA590
        public void FromUdonChar(){} // RVA: 0x7FFD551AA5D0
        public void AsUdonByte(){} // RVA: 0x7FFD551AA6D0
        public void FromUdonByte(){} // RVA: 0x7FFD551AA710
        public void AsUdonUByte(){} // RVA: 0x7FFD551AA810
        public void FromUdonUByte(){} // RVA: 0x7FFD551AA850
        public void AsUdonLong(){} // RVA: 0x7FFD551AA950
        public void FromUdonLong(){} // RVA: 0x7FFD551AA990
        public void AsUdonULong(){} // RVA: 0x7FFD551AAA90
        public void FromUdonULong(){} // RVA: 0x7FFD551AAAD0
        public void AsUdonDouble(){} // RVA: 0x7FFD551AABD0
        public void FromUdonDouble(){} // RVA: 0x7FFD551AAC10
        public void AsUdonBool(){} // RVA: 0x7FFD551AAD10
        public void FromUdonBool(){} // RVA: 0x7FFD551AAD50
        public void AsUdonFloat(){} // RVA: 0x7FFD551AAE50
        public void FromUdonFloat(){} // RVA: 0x7FFD551AAE90
        public void AsUdonInt(){} // RVA: 0x7FFD551AAF90
        public void FromUdonInt(){} // RVA: 0x7FFD551AAFD0
        public void AsUdonUInt(){} // RVA: 0x7FFD551AB0D0
        public void FromUdonUInt(){} // RVA: 0x7FFD551AB110
        public void AsVector2(){} // RVA: 0x7FFD551AB210
        public void FromVector2(){} // RVA: 0x7FFD551AB250
        public void AsVector3(){} // RVA: 0x7FFD551AB350
        public void FromVector3(){} // RVA: 0x7FFD551AB390
        public void AsVector4(){} // RVA: 0x7FFD551AB490
        public void FromVector4(){} // RVA: 0x7FFD551AB4D0
        public void AsQuaternion(){} // RVA: 0x7FFD551AB5D0
        public void FromQuaternion(){} // RVA: 0x7FFD551AB610
        public void AsColor(){} // RVA: 0x7FFD551AB710
        public void FromColor(){} // RVA: 0x7FFD551AB750
        public void AsColor32(){} // RVA: 0x7FFD551AB850
        public void FromColor32(){} // RVA: 0x7FFD551AB890
        public void AsUdonShortArray(){} // RVA: 0x7FFD551AB990
        public void FromUdonShortArray(){} // RVA: 0x7FFD551AB9D0
        public void AsUdonUShortArray(){} // RVA: 0x7FFD551ABAD0
        public void FromUdonUShortArray(){} // RVA: 0x7FFD551ABB10
        public void AsUdonCharArray(){} // RVA: 0x7FFD551ABC10
        public void FromUdonCharArray(){} // RVA: 0x7FFD551ABC50
        public void AsUdonByteArray(){} // RVA: 0x7FFD551ABD50
        public void FromUdonByteArray(){} // RVA: 0x7FFD551ABD90
        public void AsUdonUByteArray(){} // RVA: 0x7FFD551ABE90
        public void FromUdonUByteArray(){} // RVA: 0x7FFD551ABED0
        public void AsUdonLongArray(){} // RVA: 0x7FFD551ABFD0
        public void FromUdonLongArray(){} // RVA: 0x7FFD551AC010
        public void AsUdonULongArray(){} // RVA: 0x7FFD551AC110
        public void FromUdonULongArray(){} // RVA: 0x7FFD551AC150
        public void AsUdonDoubleArray(){} // RVA: 0x7FFD551AC250
        public void FromUdonDoubleArray(){} // RVA: 0x7FFD551AC290
        public void AsUdonBoolArray(){} // RVA: 0x7FFD551AC390
        public void FromUdonBoolArray(){} // RVA: 0x7FFD551AC3D0
        public void AsUdonFloatArray(){} // RVA: 0x7FFD551AC4D0
        public void FromUdonFloatArray(){} // RVA: 0x7FFD551AC510
        public void AsUdonIntArray(){} // RVA: 0x7FFD551AC610
        public void FromUdonIntArray(){} // RVA: 0x7FFD551AC650
        public void AsUdonUIntArray(){} // RVA: 0x7FFD551AC750
        public void FromUdonUIntArray(){} // RVA: 0x7FFD551AC790
        public void AsVector2Array(){} // RVA: 0x7FFD551AC890
        public void FromVector2Array(){} // RVA: 0x7FFD551AC8D0
        public void AsVector3Array(){} // RVA: 0x7FFD551AC9D0
        public void FromVector3Array(){} // RVA: 0x7FFD551ACA10
        public void AsVector4Array(){} // RVA: 0x7FFD551ACB10
        public void FromVector4Array(){} // RVA: 0x7FFD551ACB50
        public void AsQuaternionArray(){} // RVA: 0x7FFD551ACC50
        public void FromQuaternionArray(){} // RVA: 0x7FFD551ACC90
        public void AsColorArray(){} // RVA: 0x7FFD551ACD90
        public void FromColorArray(){} // RVA: 0x7FFD551ACDD0
        public void AsColor32Array(){} // RVA: 0x7FFD551ACED0
        public void FromColor32Array(){} // RVA: 0x7FFD551ACF10
        public void AsUdonString(){} // RVA: 0x7FFD551AD010
        public void FromUdonString(){} // RVA: 0x7FFD551AD050
        public void Pack(){} // RVA: 0x7FFD551AD150
    }

    public class Vector2 : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFD4F840220
        public void __init(){} // RVA: 0x7FFD55194EF0
        public void __assign(){} // RVA: 0x7FFD55194FC0
        public void get_X(){} // RVA: 0x7FFD55195400
        public void MutateX(){} // RVA: 0x7FFD55195430
        public void get_Y(){} // RVA: 0x7FFD551A0770
        public void MutateY(){} // RVA: 0x7FFD551A07A0
        public void CreateVector2(){} // RVA: 0x7FFD551A07D0
        public void UnPack(){} // RVA: 0x7FFD551A08E0
        public void UnPackTo(){} // RVA: 0x7FFD551A0970
        public void Pack(){} // RVA: 0x7FFD551A09D0
    }

    public class Vector2T : Object
    {
        public float zero; // 0x10
        public float magnitude; // 0x14

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFD50C943D0
        public void get_zero(){} // RVA: 0x7FFD55192C60
        public void .ctor(){} // RVA: 0x7FFD53DFB450 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD55192CA0
        public void op_UnaryNegation(){} // RVA: 0x7FFD55192CD0
        public void get_magnitude(){} // RVA: 0x7FFD55192D40
        public void get_sqrMagnitude(){} // RVA: 0x7FFD55192DD0
        public void op_Multiply(){} // RVA: 0x7FFD55192F70 | overloaded x4
        public void op_Division(){} // RVA: 0x7FFD55193070 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD551931F0 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFD55193370 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFD551933F0
        public void Lerp(){} // RVA: 0x7FFD551934F0
        public void IsBad(){} // RVA: 0x7FFD551936D0
        public void get_X(){} // RVA: 0x7FFD4E46B320
        public void set_X(){} // RVA: 0x7FFD4E46B330
        public void get_Y(){} // RVA: 0x7FFD4E46B340
        public void set_Y(){} // RVA: 0x7FFD4E46B350
    }

    public class Vector3T : Object
    {
        public float zero; // 0x10
        public float magnitude; // 0x14
        public float sqrMagnitude; // 0x18

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFD4EB56D20
        public void get_zero(){} // RVA: 0x7FFD55193710
        public void .ctor(){} // RVA: 0x7FFD53E9DD60 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFD55193780
        public void get_magnitude(){} // RVA: 0x7FFD551937B0
        public void get_sqrMagnitude(){} // RVA: 0x7FFD55193850
        public void op_Multiply(){} // RVA: 0x7FFD55193AB0 | overloaded x4
        public void op_UnaryNegation(){} // RVA: 0x7FFD55193910
        public void op_Division(){} // RVA: 0x7FFD55193BD0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD55193D60 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFD55193EF0 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFD55193F80
        public void Lerp(){} // RVA: 0x7FFD551940B0
        public void IsBad(){} // RVA: 0x7FFD551942E0
        public void ToString(){} // RVA: 0x7FFD55194340
        public void get_X(){} // RVA: 0x7FFD4E46B320
        public void set_X(){} // RVA: 0x7FFD4E46B330
        public void get_Y(){} // RVA: 0x7FFD4E46B340
        public void set_Y(){} // RVA: 0x7FFD4E46B350
        public void get_Z(){} // RVA: 0x7FFD4E345CF0
        public void set_Z(){} // RVA: 0x7FFD4E35C4D0
    }

}