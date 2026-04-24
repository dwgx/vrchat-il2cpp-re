// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 591

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class AnimatorParameterUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsAnimatorBool(){} // RVA: 0x7ffaaf7a6ea0
        public void FromAnimatorBool(){} // RVA: 0x7ffaaf7a6ee0
        public void AsAnimatorInt(){} // RVA: 0x7ffaaf7a6fe0
        public void FromAnimatorInt(){} // RVA: 0x7ffaaf7a7020
        public void AsAnimatorFloat(){} // RVA: 0x7ffaaf7a7120
        public void FromAnimatorFloat(){} // RVA: 0x7ffaaf7a7160
        public void Pack(){} // RVA: 0x7ffaaf7a7260
    }

    public class DataStorage : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyDataStorage(){} // RVA: 0x7ffaaf799060
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void EntriesType(){} // RVA: 0x7ffaaf798650
        public void get_EntriesTypeLength(){} // RVA: 0x7ffaaf7986d0
        public void Entries(){} // RVA: 0x7ffaa887e5c0
        public void get_EntriesLength(){} // RVA: 0x7ffaaf799370
        public void CreateDataStorage(){} // RVA: 0x7ffaaf7993e0
        public void StartDataStorage(){} // RVA: 0x7ffaaf7994d0
        public void AddEntriesType(){} // RVA: 0x7ffaaf798330
        public void CreateEntriesTypeVector(){} // RVA: 0x7ffaaf798950
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7ffaaf799650
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7ffaaf799650
        public void CreateEntriesTypeVectorBlock(){} // RVA: 0x7ffaaf799650
        public void StartEntriesTypeVector(){} // RVA: 0x7ffaaf798bf0
        public void AddEntries(){} // RVA: 0x7ffaaf7996e0
        public void CreateEntriesVector(){} // RVA: 0x7ffaaf799720
        public void CreateEntriesVectorBlock(){} // RVA: 0x7ffaaf799900
        public void CreateEntriesVectorBlock(){} // RVA: 0x7ffaaf799900
        public void CreateEntriesVectorBlock(){} // RVA: 0x7ffaaf799900
        public void StartEntriesVector(){} // RVA: 0x7ffaaf798bf0
        public void EndDataStorage(){} // RVA: 0x7ffaaf799990
        public void FinishDataStorageBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedDataStorageBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf799b00
        public void UnPackTo(){} // RVA: 0x7ffaaf799bb0
        public void Pack(){} // RVA: 0x7ffaaf79a2e0
        // ── Binary Analysis Named ──
        public void GetRootAsDataStorage(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsDataStorage(){} // RVA: 0x7ffaaf7980a0
        public void GetEntriesTypeBytes(){} // RVA: 0x7ffaaf799150
        public void GetEntriesTypeArray(){} // RVA: 0x7ffaaf7991c0
    }

    public class DataStorageEntryUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsDataStorageBool(){} // RVA: 0x7ffaaf796ef0
        public void FromDataStorageBool(){} // RVA: 0x7ffaaf796f30
        public void AsDataStorageInt(){} // RVA: 0x7ffaaf797030
        public void FromDataStorageInt(){} // RVA: 0x7ffaaf797070
        public void AsDataStorageFloat(){} // RVA: 0x7ffaaf797170
        public void FromDataStorageFloat(){} // RVA: 0x7ffaaf7971b0
        public void AsDataStorageString(){} // RVA: 0x7ffaaf7972b0
        public void FromDataStorageString(){} // RVA: 0x7ffaaf7972f0
        public void AsDataStorageBytes(){} // RVA: 0x7ffaaf7973f0
        public void FromDataStorageBytes(){} // RVA: 0x7ffaaf797430
        public void Pack(){} // RVA: 0x7ffaaf797530
    }

    public class DestructiblePlayer : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyDestructiblePlayer(){} // RVA: 0x7ffaaf79a820
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Health(){} // RVA: 0x7ffaaf79a910
        public void MutateHealth(){} // RVA: 0x7ffaaf79a960
        public void CreateDestructiblePlayer(){} // RVA: 0x7ffaaf79a9c0
        public void StartDestructiblePlayer(){} // RVA: 0x7ffaaf798310
        public void AddHealth(){} // RVA: 0x7ffaaf79aac0
        public void EndDestructiblePlayer(){} // RVA: 0x7ffaaf79ab40
        public void FinishDestructiblePlayerBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedDestructiblePlayerBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf79abd0
        public void UnPackTo(){} // RVA: 0x7ffaaf79ac70
        public void Pack(){} // RVA: 0x7ffaaf79acd0
        // ── Binary Analysis Named ──
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsDestructiblePlayer(){} // RVA: 0x7ffaaf7980a0
    }

    public class ObjectPool : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyObjectPool(){} // RVA: 0x7ffaaf79afb0
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void Data(){} // RVA: 0x7ffaaf798650
        public void get_DataLength(){} // RVA: 0x7ffaaf7986d0
        public void MutateData(){} // RVA: 0x7ffaaf798800
        public void CreateObjectPool(){} // RVA: 0x7ffaaf79b160
        public void StartObjectPool(){} // RVA: 0x7ffaaf798310
        public void AddData(){} // RVA: 0x7ffaaf798330
        public void CreateDataVector(){} // RVA: 0x7ffaaf798950
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf79b370
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf79b370
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf79b370
        public void StartDataVector(){} // RVA: 0x7ffaaf798bf0
        public void EndObjectPool(){} // RVA: 0x7ffaaf79b400
        public void FinishObjectPoolBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf79b490
        public void UnPackTo(){} // RVA: 0x7ffaaf79b540
        public void Pack(){} // RVA: 0x7ffaaf79b750
        // ── Binary Analysis Named ──
        public void GetRootAsObjectPool(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsObjectPool(){} // RVA: 0x7ffaaf7980a0
        public void GetDataBytes(){} // RVA: 0x7ffaaf79b0a0
        public void GetDataArray(){} // RVA: 0x7ffaaf79b110
    }

    public class PlayerDrone : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyPlayerDrone(){} // RVA: 0x7ffaaf79ba30
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Throttle(){} // RVA: 0x7ffaaf79a910
        public void MutateThrottle(){} // RVA: 0x7ffaaf79a960
        public void CreatePlayerDrone(){} // RVA: 0x7ffaaf79bb20
        public void StartPlayerDrone(){} // RVA: 0x7ffaaf798310
        public void AddThrottle(){} // RVA: 0x7ffaaf79aac0
        public void EndPlayerDrone(){} // RVA: 0x7ffaaf79bc20
        public void FinishPlayerDroneBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf79bcb0
        public void UnPackTo(){} // RVA: 0x7ffaaf79ac70
        public void Pack(){} // RVA: 0x7ffaaf79bd50
        // ── Binary Analysis Named ──
        public void GetRootAsPlayerDrone(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsPlayerDrone(){} // RVA: 0x7ffaaf7980a0
    }

    public class PosePositionDataUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsPoseMuscleData(){} // RVA: 0x7ffaaf79bfa0
        public void FromPoseMuscleData(){} // RVA: 0x7ffaaf79c060
        public void Pack(){} // RVA: 0x7ffaaf79c160
    }

    public class PoseRecorder : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyPoseRecorder(){} // RVA: 0x7ffaaf79d9a0
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Contents(){} // RVA: 0x7ffaaf79da90
        public void MutateContents(){} // RVA: 0x7ffaaf79dae0
        public void get_MotionFlags(){} // RVA: 0x7ffaaf79db40
        public void MutateMotionFlags(){} // RVA: 0x7ffaaf79db90
        public void get_ExtraFlags(){} // RVA: 0x7ffaaf79dbf0
        public void MutateExtraFlags(){} // RVA: 0x7ffaaf79dc40
        public void get_StandingHeight(){} // RVA: 0x7ffaaf79dca0
        public void MutateStandingHeight(){} // RVA: 0x7ffaaf79dcf0
        public void get_AngVelocity(){} // RVA: 0x7ffaaf79dd50
        public void MutateAngVelocity(){} // RVA: 0x7ffaaf79dda0
        public void get_Gestures(){} // RVA: 0x7ffaaf79de00
        public void get_Fingers(){} // RVA: 0x7ffaaf79df10
        public void get_PoseType(){} // RVA: 0x7ffaaf79e020
        public void Pose(){} // RVA: 0x7ffaa887e5c0
        public void PoseAsPoseMuscleData(){} // RVA: 0x7ffaaf79e070
        public void get_Puppet(){} // RVA: 0x7ffaaf79e100
        public void get_EyeLookTargetPosition(){} // RVA: 0x7ffaaf79e210
        public void get_EyeClosedAmount(){} // RVA: 0x7ffaaf79e320
        public void MutateEyeClosedAmount(){} // RVA: 0x7ffaaf79e370
        public void get_SpineLengthFactor(){} // RVA: 0x7ffaaf79e3d0
        public void get_FaceTrackedVisemes(){} // RVA: 0x7ffaaf79e4e0
        public void CreatePoseRecorder(){} // RVA: 0x7ffaaf79e5f0
        public void StartPoseRecorder(){} // RVA: 0x7ffaaf79ea80
        public void AddContents(){} // RVA: 0x7ffaaf79eaa0
        public void AddMotionFlags(){} // RVA: 0x7ffaaf79eb10
        public void AddExtraFlags(){} // RVA: 0x7ffaaf79eb80
        public void AddStandingHeight(){} // RVA: 0x7ffaaf79ebf0
        public void AddAngVelocity(){} // RVA: 0x7ffaaf79ec60
        public void AddGestures(){} // RVA: 0x7ffaaf79ecd0
        public void AddFingers(){} // RVA: 0x7ffaaf79ed00
        public void AddPoseType(){} // RVA: 0x7ffaaf79ed30
        public void AddPose(){} // RVA: 0x7ffaaf79eda0
        public void AddPuppet(){} // RVA: 0x7ffaaf79ede0
        public void AddEyeLookTargetPosition(){} // RVA: 0x7ffaaf79ee10
        public void AddEyeClosedAmount(){} // RVA: 0x7ffaaf79ee40
        public void AddSpineLengthFactor(){} // RVA: 0x7ffaaf79eeb0
        public void AddFaceTrackedVisemes(){} // RVA: 0x7ffaaf79eee0
        public void EndPoseRecorder(){} // RVA: 0x7ffaaf79ef10
        public void FinishPoseRecorderBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf79efa0
        public void UnPackTo(){} // RVA: 0x7ffaaf79f010
        public void Pack(){} // RVA: 0x7ffaaf79fa90
        // ── Binary Analysis Named ──
        public void GetRootAsPoseRecorder(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsPoseRecorder(){} // RVA: 0x7ffaaf7980a0
    }

    public class QuaternionT : Object
    {
        public object _z; // 0x33658E40, was: <Z>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf795680
        public void CopyFrom(){} // RVA: 0x7ffaaf794d00
        public void ToNumerics(){} // RVA: 0x7ffaaf794d30
        public void get_identity(){} // RVA: 0x7ffaaf794d50
        public void get_magnitude(){} // RVA: 0x7ffaaf794da0
        public void get_sqrMagnitude(){} // RVA: 0x7ffaaf794e50
        public void Slerp(){} // RVA: 0x7ffaaf794f70
        public void Slerp(){} // RVA: 0x7ffaaf794f70
        public void Inverse(){} // RVA: 0x7ffaaf795000
        public void op_Multiply(){} // RVA: 0x7ffaaf795100
        public void IsBad(){} // RVA: 0x7ffaaf7952b0
        public void Normalize(){} // RVA: 0x7ffaaf795330
        public void ToString(){} // RVA: 0x7ffaaf795430
        public void get_X(){} // RVA: 0x7ffaa8a5c320
        public void set_X(){} // RVA: 0x7ffaa8a5c330
        public void get_Y(){} // RVA: 0x7ffaa8a5c340
        public void set_Y(){} // RVA: 0x7ffaa8a5c350
        public void get_Z(){} // RVA: 0x7ffaa8936cf0
        public void set_Z(){} // RVA: 0x7ffaa894d4d0
        public void get_W(){} // RVA: 0x7ffaa89ff570
        public void set_W(){} // RVA: 0x7ffaa89ff580
        public void .ctor(){} // RVA: 0x7ffaaf795680
    }

    public class SerializedObjects : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifySerializedObjects(){} // RVA: 0x7ffaaf7a19f0
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void ObjectsType(){} // RVA: 0x7ffaaf798650
        public void get_ObjectsTypeLength(){} // RVA: 0x7ffaaf7986d0
        public void Objects(){} // RVA: 0x7ffaa887e5c0
        public void get_ObjectsLength(){} // RVA: 0x7ffaaf799370
        public void CreateSerializedObjects(){} // RVA: 0x7ffaaf7a1d00
        public void StartSerializedObjects(){} // RVA: 0x7ffaaf7994d0
        public void AddObjectsType(){} // RVA: 0x7ffaaf798330
        public void CreateObjectsTypeVector(){} // RVA: 0x7ffaaf798950
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7ffaaf7a1f50
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7ffaaf7a1f50
        public void CreateObjectsTypeVectorBlock(){} // RVA: 0x7ffaaf7a1f50
        public void StartObjectsTypeVector(){} // RVA: 0x7ffaaf798bf0
        public void AddObjects(){} // RVA: 0x7ffaaf7996e0
        public void CreateObjectsVector(){} // RVA: 0x7ffaaf799720
        public void CreateObjectsVectorBlock(){} // RVA: 0x7ffaaf7a2130
        public void CreateObjectsVectorBlock(){} // RVA: 0x7ffaaf7a2130
        public void CreateObjectsVectorBlock(){} // RVA: 0x7ffaaf7a2130
        public void StartObjectsVector(){} // RVA: 0x7ffaaf798bf0
        public void EndSerializedObjects(){} // RVA: 0x7ffaaf7a21c0
        public void FinishSerializedObjectsBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedSerializedObjectsBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf7a2250
        public void UnPackTo(){} // RVA: 0x7ffaaf7a2300
        public void Pack(){} // RVA: 0x7ffaaf7a2d10
        // ── Binary Analysis Named ──
        public void GetRootAsSerializedObjects(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsSerializedObjects(){} // RVA: 0x7ffaaf7980a0
        public void GetObjectsTypeBytes(){} // RVA: 0x7ffaaf7a1ae0
        public void GetObjectsTypeArray(){} // RVA: 0x7ffaaf7a1b50
    }

    public class SerializedTypeUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsSyncPhysicsData(){} // RVA: 0x7ffaaf7a05e0
        public void FromSyncPhysicsData(){} // RVA: 0x7ffaaf7a0620
        public void AsDestructiblePlayer(){} // RVA: 0x7ffaaf7a0720
        public void FromDestructiblePlayer(){} // RVA: 0x7ffaaf7a0760
        public void AsSyncVideoPlayer(){} // RVA: 0x7ffaaf7a0860
        public void FromSyncVideoPlayer(){} // RVA: 0x7ffaaf7a08a0
        public void AsSyncVideoStream(){} // RVA: 0x7ffaaf7a09a0
        public void FromSyncVideoStream(){} // RVA: 0x7ffaaf7a09e0
        public void AsSyncAnim(){} // RVA: 0x7ffaaf7a0ae0
        public void FromSyncAnim(){} // RVA: 0x7ffaaf7a0b20
        public void AsDataStorage(){} // RVA: 0x7ffaaf7a0c20
        public void FromDataStorage(){} // RVA: 0x7ffaaf7a0c60
        public void AsPoseRecorder(){} // RVA: 0x7ffaaf7a0d60
        public void FromPoseRecorder(){} // RVA: 0x7ffaaf7a0da0
        public void AsUdon(){} // RVA: 0x7ffaaf7a0ea0
        public void FromUdon(){} // RVA: 0x7ffaaf7a0ee0
        public void AsObjectPool(){} // RVA: 0x7ffaaf7a0fe0
        public void FromObjectPool(){} // RVA: 0x7ffaaf7a1020
        public void Pack(){} // RVA: 0x7ffaaf7a1120
    }

    public class SparseSerializedObjects : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifySparseSerializedObjects(){} // RVA: 0x7ffaaf7a5e40
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Objects(){} // RVA: 0x7ffaaf7a5f30
        public void Bitmap(){} // RVA: 0x7ffaaf7a6070
        public void get_BitmapLength(){} // RVA: 0x7ffaaf799370
        public void MutateBitmap(){} // RVA: 0x7ffaaf7a61b0
        public void CreateSparseSerializedObjects(){} // RVA: 0x7ffaaf7a6240
        public void StartSparseSerializedObjects(){} // RVA: 0x7ffaaf7994d0
        public void AddObjects(){} // RVA: 0x7ffaaf798330
        public void AddBitmap(){} // RVA: 0x7ffaaf7996e0
        public void CreateBitmapVector(){} // RVA: 0x7ffaaf798950
        public void CreateBitmapVectorBlock(){} // RVA: 0x7ffaaf7a6480
        public void CreateBitmapVectorBlock(){} // RVA: 0x7ffaaf7a6480
        public void CreateBitmapVectorBlock(){} // RVA: 0x7ffaaf7a6480
        public void StartBitmapVector(){} // RVA: 0x7ffaaf798bf0
        public void EndSparseSerializedObjects(){} // RVA: 0x7ffaaf7a6510
        public void FinishSparseSerializedObjectsBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedSparseSerializedObjectsBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf7a65a0
        public void UnPackTo(){} // RVA: 0x7ffaaf7a66b0
        public void Pack(){} // RVA: 0x7ffaaf7a69e0
        // ── Binary Analysis Named ──
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsSparseSerializedObjects(){} // RVA: 0x7ffaaf7980a0
        public void GetBitmapBytes(){} // RVA: 0x7ffaaf7a60f0
        public void GetBitmapArray(){} // RVA: 0x7ffaaf7a6160
    }

    public class SyncAnim : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifySyncAnim(){} // RVA: 0x7ffaaf7a8990
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_AnimationIsPlaying(){} // RVA: 0x7ffaaf7a8a80
        public void MutateAnimationIsPlaying(){} // RVA: 0x7ffaaf7a8ad0
        public void AnimationStates(){} // RVA: 0x7ffaaf7a8b30
        public void get_AnimationStatesLength(){} // RVA: 0x7ffaaf799370
        public void AnimatorLayers(){} // RVA: 0x7ffaaf7a8ca0
        public void get_AnimatorLayersLength(){} // RVA: 0x7ffaaf7a8e10
        public void AnimatorParametersType(){} // RVA: 0x7ffaaf7a8e80
        public void get_AnimatorParametersTypeLength(){} // RVA: 0x7ffaaf7a8f00
        public void AnimatorParameters(){} // RVA: 0x7ffaa887e5c0
        public void get_AnimatorParametersLength(){} // RVA: 0x7ffaaf7a9190
        public void CreateSyncAnim(){} // RVA: 0x7ffaaf7a9200
        public void StartSyncAnim(){} // RVA: 0x7ffaaf7a9390
        public void AddAnimationIsPlaying(){} // RVA: 0x7ffaaf7a93b0
        public void AddAnimationStates(){} // RVA: 0x7ffaaf7996e0
        public void CreateAnimationStatesVector(){} // RVA: 0x7ffaaf799720
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7ffaaf7a9610
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7ffaaf7a9610
        public void CreateAnimationStatesVectorBlock(){} // RVA: 0x7ffaaf7a9610
        public void StartAnimationStatesVector(){} // RVA: 0x7ffaaf798bf0
        public void AddAnimatorLayers(){} // RVA: 0x7ffaaf7a7920
        public void CreateAnimatorLayersVector(){} // RVA: 0x7ffaaf799720
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7ffaaf7a9890
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7ffaaf7a9890
        public void CreateAnimatorLayersVectorBlock(){} // RVA: 0x7ffaaf7a9890
        public void StartAnimatorLayersVector(){} // RVA: 0x7ffaaf798bf0
        public void AddAnimatorParametersType(){} // RVA: 0x7ffaaf7a9920
        public void CreateAnimatorParametersTypeVector(){} // RVA: 0x7ffaaf798950
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7ffaaf7a9ac0
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7ffaaf7a9ac0
        public void CreateAnimatorParametersTypeVectorBlock(){} // RVA: 0x7ffaaf7a9ac0
        public void StartAnimatorParametersTypeVector(){} // RVA: 0x7ffaaf798bf0
        public void AddAnimatorParameters(){} // RVA: 0x7ffaaf7a9b50
        public void CreateAnimatorParametersVector(){} // RVA: 0x7ffaaf799720
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7ffaaf7a9ce0
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7ffaaf7a9ce0
        public void CreateAnimatorParametersVectorBlock(){} // RVA: 0x7ffaaf7a9ce0
        public void StartAnimatorParametersVector(){} // RVA: 0x7ffaaf798bf0
        public void EndSyncAnim(){} // RVA: 0x7ffaaf7a9d70
        public void FinishSyncAnimBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedSyncAnimBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf7a9e00
        public void UnPackTo(){} // RVA: 0x7ffaaf7a9f60
        public void Pack(){} // RVA: 0x7ffaaf7aa920
        // ── Binary Analysis Named ──
        public void GetRootAsSyncAnim(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsSyncAnim(){} // RVA: 0x7ffaaf7980a0
        public void GetAnimatorParametersTypeBytes(){} // RVA: 0x7ffaaf7a8f70
        public void GetAnimatorParametersTypeArray(){} // RVA: 0x7ffaaf7a8fe0
    }

    public class SyncPhysicsData : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_Flags(){} // RVA: 0x7ffaaf79d3d0
        public void MutateFlags(){} // RVA: 0x7ffaaf797a60
        public void get_Position(){} // RVA: 0x7ffaaf7ab430
        public void get_Rotation(){} // RVA: 0x7ffaaf7ab470
        public void CreateSyncPhysicsData(){} // RVA: 0x7ffaaf7ab4b0
        public void UnPack(){} // RVA: 0x7ffaaf7ab680
        public void UnPackTo(){} // RVA: 0x7ffaaf7ab810
        public void Pack(){} // RVA: 0x7ffaaf7aba00
    }

    public class SyncVideoPlayer : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_IsPlaying(){} // RVA: 0x7ffaaf7a8a80
        public void MutateIsPlaying(){} // RVA: 0x7ffaaf7a8ad0
        public void get_Time(){} // RVA: 0x7ffaaf7a7420
        public void MutateTime(){} // RVA: 0x7ffaaf7a7470
        public void get_PlaybackSpeed(){} // RVA: 0x7ffaaf7abc80
        public void MutatePlaybackSpeed(){} // RVA: 0x7ffaaf7abcd0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7ffaaf7abd30
        public void MutateCurrentPlaylistIndex(){} // RVA: 0x7ffaaf7abd80
        public void CreateSyncVideoPlayer(){} // RVA: 0x7ffaaf7abde0
        public void StartSyncVideoPlayer(){} // RVA: 0x7ffaaf7abff0
        public void AddIsPlaying(){} // RVA: 0x7ffaaf7a93b0
        public void AddTime(){} // RVA: 0x7ffaaf7a78a0
        public void AddPlaybackSpeed(){} // RVA: 0x7ffaaf7ac010
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7ffaaf7ac080
        public void EndSyncVideoPlayer(){} // RVA: 0x7ffaaf7ac0f0
        public void UnPack(){} // RVA: 0x7ffaaf7ac180
        public void UnPackTo(){} // RVA: 0x7ffaaf7ac1f0
        public void Pack(){} // RVA: 0x7ffaaf7ac300
        // ── Binary Analysis Named ──
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsSyncVideoPlayer(){} // RVA: 0x7ffaaf7980a0
    }

    public class SyncVideoStream : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_IsPlaying(){} // RVA: 0x7ffaaf7a8a80
        public void MutateIsPlaying(){} // RVA: 0x7ffaaf7a8ad0
        public void get_Time(){} // RVA: 0x7ffaaf7a7420
        public void MutateTime(){} // RVA: 0x7ffaaf7a7470
        public void get_PlaybackRate(){} // RVA: 0x7ffaaf7abc80
        public void MutatePlaybackRate(){} // RVA: 0x7ffaaf7abcd0
        public void get_CurrentPlaylistIndex(){} // RVA: 0x7ffaaf7abd30
        public void MutateCurrentPlaylistIndex(){} // RVA: 0x7ffaaf7abd80
        public void get_SyncType(){} // RVA: 0x7ffaaf79dd50
        public void MutateSyncType(){} // RVA: 0x7ffaaf79dda0
        public void get_SyncMinutes(){} // RVA: 0x7ffaaf7ac490
        public void MutateSyncMinutes(){} // RVA: 0x7ffaaf7ac4e0
        public void CreateSyncVideoStream(){} // RVA: 0x7ffaaf7ac540
        public void StartSyncVideoStream(){} // RVA: 0x7ffaaf7ac7f0
        public void AddIsPlaying(){} // RVA: 0x7ffaaf7a93b0
        public void AddTime(){} // RVA: 0x7ffaaf7a78a0
        public void AddPlaybackRate(){} // RVA: 0x7ffaaf7ac010
        public void AddCurrentPlaylistIndex(){} // RVA: 0x7ffaaf7ac080
        public void AddSyncType(){} // RVA: 0x7ffaaf79ec60
        public void AddSyncMinutes(){} // RVA: 0x7ffaaf7ac810
        public void EndSyncVideoStream(){} // RVA: 0x7ffaaf7ac880
        public void UnPack(){} // RVA: 0x7ffaaf7ac910
        public void UnPackTo(){} // RVA: 0x7ffaaf7ac980
        public void Pack(){} // RVA: 0x7ffaaf7acaf0
        // ── Binary Analysis Named ──
        public void GetRootAsSyncVideoStream(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsSyncVideoStream(){} // RVA: 0x7ffaaf7980a0
    }

    public class Udon : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void ValidateVersion(){} // RVA: 0x7ffaa8932310
        public void VerifyUdon(){} // RVA: 0x7ffaaf7bbd70
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void DataType(){} // RVA: 0x7ffaaf798650
        public void get_DataTypeLength(){} // RVA: 0x7ffaaf7986d0
        public void Data(){} // RVA: 0x7ffaa887e5c0
        public void get_DataLength(){} // RVA: 0x7ffaaf799370
        public void CreateUdon(){} // RVA: 0x7ffaaf7bc080
        public void StartUdon(){} // RVA: 0x7ffaaf7994d0
        public void AddDataType(){} // RVA: 0x7ffaaf798330
        public void CreateDataTypeVector(){} // RVA: 0x7ffaaf798950
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7ffaaf7bc2d0
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7ffaaf7bc2d0
        public void CreateDataTypeVectorBlock(){} // RVA: 0x7ffaaf7bc2d0
        public void StartDataTypeVector(){} // RVA: 0x7ffaaf798bf0
        public void AddData(){} // RVA: 0x7ffaaf7996e0
        public void CreateDataVector(){} // RVA: 0x7ffaaf799720
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7bc4b0
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7bc4b0
        public void CreateDataVectorBlock(){} // RVA: 0x7ffaaf7bc4b0
        public void StartDataVector(){} // RVA: 0x7ffaaf798bf0
        public void EndUdon(){} // RVA: 0x7ffaaf7bc540
        public void FinishUdonBuffer(){} // RVA: 0x7ffaaf799a20
        public void FinishSizePrefixedUdonBuffer(){} // RVA: 0x7ffaaf799a80
        public void UnPack(){} // RVA: 0x7ffaaf7bc5d0
        public void UnPackTo(){} // RVA: 0x7ffaaf7bc680
        public void Pack(){} // RVA: 0x7ffaaf7be640
        // ── Binary Analysis Named ──
        public void GetRootAsUdon(){} // RVA: 0x7ffaaf7980a0
        public void GetRootAsUdon(){} // RVA: 0x7ffaaf7980a0
        public void GetDataTypeBytes(){} // RVA: 0x7ffaaf7bbe60
        public void GetDataTypeArray(){} // RVA: 0x7ffaaf7bbed0
    }

    public class UdonValueUnion : Object
    {
        // ── Original Methods ──
        public void get_Type(){} // RVA: 0x7ffaa89fc5e0
        public void set_Type(){} // RVA: 0x7ffaa89fc5f0
        public void get_Value(){} // RVA: 0x7ffaa89357c0
        public void set_Value(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf796e90
        public void As(){} // RVA: 0x7ffaa887e5c0
        public void AsUdonShort(){} // RVA: 0x7ffaaf7acd30
        public void FromUdonShort(){} // RVA: 0x7ffaaf7acd70
        public void AsUdonUShort(){} // RVA: 0x7ffaaf7ace70
        public void FromUdonUShort(){} // RVA: 0x7ffaaf7aceb0
        public void AsUdonChar(){} // RVA: 0x7ffaaf7acfb0
        public void FromUdonChar(){} // RVA: 0x7ffaaf7acff0
        public void AsUdonByte(){} // RVA: 0x7ffaaf7ad0f0
        public void FromUdonByte(){} // RVA: 0x7ffaaf7ad130
        public void AsUdonUByte(){} // RVA: 0x7ffaaf7ad230
        public void FromUdonUByte(){} // RVA: 0x7ffaaf7ad270
        public void AsUdonLong(){} // RVA: 0x7ffaaf7ad370
        public void FromUdonLong(){} // RVA: 0x7ffaaf7ad3b0
        public void AsUdonULong(){} // RVA: 0x7ffaaf7ad4b0
        public void FromUdonULong(){} // RVA: 0x7ffaaf7ad4f0
        public void AsUdonDouble(){} // RVA: 0x7ffaaf7ad5f0
        public void FromUdonDouble(){} // RVA: 0x7ffaaf7ad630
        public void AsUdonBool(){} // RVA: 0x7ffaaf7ad730
        public void FromUdonBool(){} // RVA: 0x7ffaaf7ad770
        public void AsUdonFloat(){} // RVA: 0x7ffaaf7ad870
        public void FromUdonFloat(){} // RVA: 0x7ffaaf7ad8b0
        public void AsUdonInt(){} // RVA: 0x7ffaaf7ad9b0
        public void FromUdonInt(){} // RVA: 0x7ffaaf7ad9f0
        public void AsUdonUInt(){} // RVA: 0x7ffaaf7adaf0
        public void FromUdonUInt(){} // RVA: 0x7ffaaf7adb30
        public void AsVector2(){} // RVA: 0x7ffaaf7adc30
        public void FromVector2(){} // RVA: 0x7ffaaf7adc70
        public void AsVector3(){} // RVA: 0x7ffaaf7add70
        public void FromVector3(){} // RVA: 0x7ffaaf7addb0
        public void AsVector4(){} // RVA: 0x7ffaaf7adeb0
        public void FromVector4(){} // RVA: 0x7ffaaf7adef0
        public void AsQuaternion(){} // RVA: 0x7ffaaf7adff0
        public void FromQuaternion(){} // RVA: 0x7ffaaf7ae030
        public void AsColor(){} // RVA: 0x7ffaaf7ae130
        public void FromColor(){} // RVA: 0x7ffaaf7ae170
        public void AsColor32(){} // RVA: 0x7ffaaf7ae270
        public void FromColor32(){} // RVA: 0x7ffaaf7ae2b0
        public void AsUdonShortArray(){} // RVA: 0x7ffaaf7ae3b0
        public void FromUdonShortArray(){} // RVA: 0x7ffaaf7ae3f0
        public void AsUdonUShortArray(){} // RVA: 0x7ffaaf7ae4f0
        public void FromUdonUShortArray(){} // RVA: 0x7ffaaf7ae530
        public void AsUdonCharArray(){} // RVA: 0x7ffaaf7ae630
        public void FromUdonCharArray(){} // RVA: 0x7ffaaf7ae670
        public void AsUdonByteArray(){} // RVA: 0x7ffaaf7ae770
        public void FromUdonByteArray(){} // RVA: 0x7ffaaf7ae7b0
        public void AsUdonUByteArray(){} // RVA: 0x7ffaaf7ae8b0
        public void FromUdonUByteArray(){} // RVA: 0x7ffaaf7ae8f0
        public void AsUdonLongArray(){} // RVA: 0x7ffaaf7ae9f0
        public void FromUdonLongArray(){} // RVA: 0x7ffaaf7aea30
        public void AsUdonULongArray(){} // RVA: 0x7ffaaf7aeb30
        public void FromUdonULongArray(){} // RVA: 0x7ffaaf7aeb70
        public void AsUdonDoubleArray(){} // RVA: 0x7ffaaf7aec70
        public void FromUdonDoubleArray(){} // RVA: 0x7ffaaf7aecb0
        public void AsUdonBoolArray(){} // RVA: 0x7ffaaf7aedb0
        public void FromUdonBoolArray(){} // RVA: 0x7ffaaf7aedf0
        public void AsUdonFloatArray(){} // RVA: 0x7ffaaf7aeef0
        public void FromUdonFloatArray(){} // RVA: 0x7ffaaf7aef30
        public void AsUdonIntArray(){} // RVA: 0x7ffaaf7af030
        public void FromUdonIntArray(){} // RVA: 0x7ffaaf7af070
        public void AsUdonUIntArray(){} // RVA: 0x7ffaaf7af170
        public void FromUdonUIntArray(){} // RVA: 0x7ffaaf7af1b0
        public void AsVector2Array(){} // RVA: 0x7ffaaf7af2b0
        public void FromVector2Array(){} // RVA: 0x7ffaaf7af2f0
        public void AsVector3Array(){} // RVA: 0x7ffaaf7af3f0
        public void FromVector3Array(){} // RVA: 0x7ffaaf7af430
        public void AsVector4Array(){} // RVA: 0x7ffaaf7af530
        public void FromVector4Array(){} // RVA: 0x7ffaaf7af570
        public void AsQuaternionArray(){} // RVA: 0x7ffaaf7af670
        public void FromQuaternionArray(){} // RVA: 0x7ffaaf7af6b0
        public void AsColorArray(){} // RVA: 0x7ffaaf7af7b0
        public void FromColorArray(){} // RVA: 0x7ffaaf7af7f0
        public void AsColor32Array(){} // RVA: 0x7ffaaf7af8f0
        public void FromColor32Array(){} // RVA: 0x7ffaaf7af930
        public void AsUdonString(){} // RVA: 0x7ffaaf7afa30
        public void FromUdonString(){} // RVA: 0x7ffaaf7afa70
        public void Pack(){} // RVA: 0x7ffaaf7afb70
    }

    public class Vector2 : ValueType
    {
        // ── Original Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7ffaa9e47540
        public void __init(){} // RVA: 0x7ffaaf797920
        public void __assign(){} // RVA: 0x7ffaaf7979f0
        public void get_X(){} // RVA: 0x7ffaaf797e30
        public void MutateX(){} // RVA: 0x7ffaaf797e60
        public void get_Y(){} // RVA: 0x7ffaaf7a3190
        public void MutateY(){} // RVA: 0x7ffaaf7a31c0
        public void CreateVector2(){} // RVA: 0x7ffaaf7a31f0
        public void UnPack(){} // RVA: 0x7ffaaf7a3300
        public void UnPackTo(){} // RVA: 0x7ffaaf7a3390
        public void Pack(){} // RVA: 0x7ffaaf7a33f0
    }

    public class Vector2T : Object
    {
        // ── Original Methods ──
        public void ToNumerics(){} // RVA: 0x7ffaab27e3b0
        public void get_zero(){} // RVA: 0x7ffaaf795690
        public void .ctor(){} // RVA: 0x7ffaae3fc660
        public void CopyFrom(){} // RVA: 0x7ffaaf7956d0
        public void op_UnaryNegation(){} // RVA: 0x7ffaaf795700
        public void get_magnitude(){} // RVA: 0x7ffaaf795770
        public void get_sqrMagnitude(){} // RVA: 0x7ffaaf795800
        public void op_Multiply(){} // RVA: 0x7ffaaf7959a0
        public void op_Multiply(){} // RVA: 0x7ffaaf7959a0
        public void op_Multiply(){} // RVA: 0x7ffaaf7959a0
        public void op_Multiply(){} // RVA: 0x7ffaaf7959a0
        public void op_Division(){} // RVA: 0x7ffaaf795aa0
        public void op_Division(){} // RVA: 0x7ffaaf795aa0
        public void op_Addition(){} // RVA: 0x7ffaaf795c20
        public void op_Addition(){} // RVA: 0x7ffaaf795c20
        public void op_Addition(){} // RVA: 0x7ffaaf795c20
        public void op_Subtraction(){} // RVA: 0x7ffaaf795da0
        public void op_Subtraction(){} // RVA: 0x7ffaaf795da0
        public void op_Subtraction(){} // RVA: 0x7ffaaf795da0
        public void LerpUnclamped(){} // RVA: 0x7ffaaf795e20
        public void Lerp(){} // RVA: 0x7ffaaf795f20
        public void IsBad(){} // RVA: 0x7ffaaf796100
        public void get_X(){} // RVA: 0x7ffaa8a5c320
        public void set_X(){} // RVA: 0x7ffaa8a5c330
        public void get_Y(){} // RVA: 0x7ffaa8a5c340
        public void set_Y(){} // RVA: 0x7ffaa8a5c350
        public void .ctor(){} // RVA: 0x7ffaae3fc660
    }

    public class Vector3T : Object
    {
        public object _z; // 0x33CEDBF0, was: <Z>k__BackingField
        public object zero; // 0x1700008A

        // ── Original Methods ──
        public void ToNumerics(){} // RVA: 0x7ffaa91687f0
        public void get_zero(){} // RVA: 0x7ffaaf796140
        public void .ctor(){} // RVA: 0x7ffaae49ef80
        public void CopyFrom(){} // RVA: 0x7ffaaf7961b0
        public void get_magnitude(){} // RVA: 0x7ffaaf7961e0
        public void get_sqrMagnitude(){} // RVA: 0x7ffaaf796280
        public void op_Multiply(){} // RVA: 0x7ffaaf7964e0
        public void op_UnaryNegation(){} // RVA: 0x7ffaaf796340
        public void op_Multiply(){} // RVA: 0x7ffaaf7964e0
        public void op_Multiply(){} // RVA: 0x7ffaaf7964e0
        public void op_Multiply(){} // RVA: 0x7ffaaf7964e0
        public void op_Division(){} // RVA: 0x7ffaaf796600
        public void op_Division(){} // RVA: 0x7ffaaf796600
        public void op_Addition(){} // RVA: 0x7ffaaf796790
        public void op_Addition(){} // RVA: 0x7ffaaf796790
        public void op_Addition(){} // RVA: 0x7ffaaf796790
        public void op_Subtraction(){} // RVA: 0x7ffaaf796920
        public void op_Subtraction(){} // RVA: 0x7ffaaf796920
        public void op_Subtraction(){} // RVA: 0x7ffaaf796920
        public void LerpUnclamped(){} // RVA: 0x7ffaaf7969b0
        public void Lerp(){} // RVA: 0x7ffaaf796ae0
        public void IsBad(){} // RVA: 0x7ffaaf796d10
        public void ToString(){} // RVA: 0x7ffaaf796d70
        public void get_X(){} // RVA: 0x7ffaa8a5c320
        public void set_X(){} // RVA: 0x7ffaa8a5c330
        public void get_Y(){} // RVA: 0x7ffaa8a5c340
        public void set_Y(){} // RVA: 0x7ffaa8a5c350
        public void get_Z(){} // RVA: 0x7ffaa8936cf0
        public void set_Z(){} // RVA: 0x7ffaa894d4d0
        public void .ctor(){} // RVA: 0x7ffaae49ef80
    }

}