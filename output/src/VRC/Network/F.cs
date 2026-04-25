// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Network
// Classes: 1
// Methods: 45

namespace VRC.Network
{
    /// <summary>Originally: ÏÎÍÏÏÌÏÏÎÎÍÍÍÏÏÌÎÌÍÎÎÍÏ</summary>
    public class FlatBufferNetworkSerializer_0BFA : NetworkReadyHandler_68D0_68D0
    {
        public int _typeId;
        public VRC.Core.Networking.ConcurrentLimitedCapacityList`1<VRC.Core.Networking.Pose.PoseEvent> _useDirectPoseCodec; // 0x58
        public ÏÎÏÏÎÍÌÎÌÏÍÏÏÎÎÏÎÍÎÌÎÎÍ f_150; // 0x60
        public ÌÎÎÌÎÌÏÍÌÎÎÌÏÌÌÎÌÎÎÌÏÌÍ f_2A1; // 0x68
        public ÌÌÍÌÌÏÎÎÏÎÌÏÍÏÍÌÌÌÌÏÎÌÍ f_DD3; // 0x70
        public UnityEngine.Animator f_3DB; // 0x78
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ ÎÏÌÍÎÎÎÍÎÎÏÌÌÍÍÏÏÏÎÎÌÎÌ; // 0x80
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÍÎÍÍÎÏÌÎÌÌÍÍÍÎÍÌÌÍÎÌÍÌÌ; // 0x88
        public ÎÎÏÌÏÎÌÏÌÌÎÏÎÍÎÌÏÌÌÍÏÍÌ ÍÌÍÏÍÏÎÎÎÌÎÎÎÎÎÎÌÍÎÏÎÌÏ; // 0x90
        public ÏÍÍÏÎÍÏÎÍÏÌÍÍÏÎÏÍÎÎÎÏÏÏ ÎÏÎÍÏÏÍÌÌÏÎÏÌÌÌÍÎÎÎÎÎÎÌ; // 0x98
        public ÍÍÎÎÍÎÎÏÍÌÏÏÌÎÍÍÎÎÍÏÌÏÎ ÍÍÎÎÌÏÌÍÏÌÎÌÍÌÎÌÎÌÍÏÎÌÎ; // 0xA0
        public ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ ÏÌÌÎÏÏÍÏÎÌÏÌÏÎÍÌÎÏÎÍÍÎÏ; // 0xA8
        public UnityEngine.Transform ÏÏÌÎÌÍÍÏÍÏÏÌÌÏÎÍÌÏÌÎÍÎÎ; // 0xB0
        public VRC.Core.Networking.Pose.PoseEvent ÌÍÍÏÌÎÏÌÍÍÎÌÎÎÏÏÎÍÌÌÌÌÎ; // 0xB8
        public UnityEngine.HumanPose ÍÎÌÍÎÌÎÍÍÎÎÎÌÌÏÏÍÌÎÌÎÍÍ; // 0xC0
        public UnityEngine.HumanPoseHandler ÍÌÏÏÌÏÏÎÎÌÌÌÎÍÎÍÎÍÏÏÎÎÏ; // 0xE8
        public ÌÎÌÎÏÏÍÏÍÎÍÏÍÏÍÏÌÌÍÏÌÌÌ ÏÏÏÎÌÎÏÍÏÍÍÎÌÍÌÌÍÎÍÏÏÍÍ; // 0xF0
        public float ÍÍÌÏÎÎÎÍÌÍÏÎÎÏÍÌÎÌÍÍÏÏÌ; // 0xF8
        public float ÎÍÍÏÎÌÏÍÌÍÏÍÏÍÎÎÍÌÌÎÍÎÌ;
        public bool ÎÎÏÌÌÎÌÎÎÏÌÌÎÌÎÌÎÏÎÍÏÎÎ; // 0xFC
        public VRC.Core.Networking.Pose.PoseCodec`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.PoseRecorder> ÎÎÏÌÍÌÌÎÍÌÍÌÏÌÎÎÎÌÍÌÍÌÌ; // 0x100
        public VRC.Core.Networking.Pose.PoseCodec`1<Google.FlatBuffers8.ByteBuffer> ÌÌÌÌÎÌÍÎÏÎÌÌÎÏÌÌÍÎÍÏÍÏÎ; // 0x108
        public bool <ÍÍÌÎÎÍÍÌÏÍÎÎÍÏÌÎÏÍÎÎÎÌÎ>k__BackingField; // 0x110
        public VRC.Core.Networking.Pose.PoseEvent ÍÎÌÏÎÏÎÎÍÎÍÎÏÏÏÌÌÏÎÏÏÌÍ; // 0x118
        public VRC.Core.Networking.Pose.PoseEvent ÏÏÌÌÏÎÍÎÏÏÏÌÌÌÏÍÏÍÎÍÌÍÎ; // 0x120
        public ÍÌÌÍÎÌÎÍÌÎÌÍÎÎÌÌÌÏÎÌÍÌÏ ÏÍÌÏÏÌÎÏÌÍÏÍÎÎÎÍÍÌÍÌÎÏÎ; // 0x128
        public UnityEngine.Object ÏÎÌÏÌÎÍÍÏÌÍÏÍÎÍÍÎÍÌÌÏÌÏ; // 0x130
        public VRC.Profiling.ProfilerMarker ÎÏÎÏÌÌÌÌÌÍÎÎÍÍÎÎÎÌÏÍÏÎÍ; // 0x138
        public VRC.Profiling.ProfilerMarker ÍÏÏÏÏÌÎÎÌÍÍÏÌÌÍÏÍÍÎÎÏÌÏ; // 0x148
        public VRC.Profiling.ProfilerMarker ÏÌÏÍÌÎÏÌÍÏÌÍÎÏÎÍÌÏÍÌÎÌÎ; // 0x158
        public VRC.Profiling.ProfilerMarker ÎÎÏÌÌÌÏÌÌÎÏÎÍÌÏÎÏÍÏÌÏÎÍ; // 0x168
        public VRC.Profiling.ProfilerMarker ÎÎÎÎÎÎÏÏÏÎÏÌÍÍÌÏÎÎÌÎÍÏÎ; // 0x178
        public VRC.Profiling.ProfilerMarker ÌÍÍÍÎÎÏÎÍÏÌÎÎÌÎÎÏÌÌÎÍÏÎ; // 0x188
        public VRC.Profiling.ProfilerMarker ÎÍÌÏÌÍÍÎÍÌÎÎÍÎÍÏÌÍÌÍÌÏÍ; // 0x198
        public VRC.Profiling.ProfilerMarker ÏÎÏÍÎÌÌÌÌÏÏÌÎÎÌÎÌÍÏÌÏÍÏ; // 0x1A8
        public VRC.Profiling.ProfilerMarker ÍÏÎÌÌÍÍÌÎÍÍÌÍÍÎÌÌÏÍÎÍÍÍ; // 0x1B8
        public VRC.Profiling.ProfilerMarker ÍÌÌÎÎÍÏÎÌÏÍÌÏÌÏÌÎÏÎÎÏÎÎ; // 0x1C8

        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFAC31E7D50 | overloaded x3
        public void Encode(){} // RVA: 0x7FFAC31E22C0 | overloaded x2
        public void GetLanguage(){} // RVA: 0x7FFAC31DFD80
        public void ReadComponentState(){} // RVA: 0x7FFAC31E0000
        public void GetComponentTransform(){} // RVA: 0x7FFAC31E0200
        public void .ctor(){} // RVA: 0x7FFAC31E10F0
        public void NeedsSync(){} // RVA: 0x7FFAC31E17F0
        public void ProcessGameObject(){} // RVA: 0x7FFAC31E1800
        public void CanSerialize32Bit(){} // RVA: 0x7FFAC2F21320
        public void CheckAndGetSerializedData(){} // RVA: 0x7FFAC31E1D50
        public void GetOutputBuffer(){} // RVA: 0x7FFAC31E2110
        public void set_TypeId(){} // RVA: 0x7FFAC31E2300
        public void SetActive_DED(){} // RVA: 0x7FFAC31E3800
        public void StartCoroutine(){} // RVA: 0x7FFAC31E3D50
        public void get_TypeId(){} // RVA: 0x7FFAC31E48B0
        public void DoSetTriggerString_235(){} // RVA: 0x7FFAC31E48C0
        public void print(){} // RVA: 0x7FFAC3006850
        public void CanProcessDataType2(){} // RVA: 0x7FFAC31E4A90
        public void Awake(){} // RVA: 0x7FFAC31E4B60
        public void OnDestroy(){} // RVA: 0x7FFAC31E4F30
        public void get_hidden(){} // RVA: 0x7FFAC31E4FA0
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7FFAC31E5070
        public void DoIsSafe(){} // RVA: 0x7FFAC31E5170
        public void DoBaseCopy(){} // RVA: 0x7FFAC31E5210
        public void ReadRectTransformState(){} // RVA: 0x7FFAC31E5740
        public void GetOrCreateNetworkSyncableValue(){} // RVA: 0x7FFAC31E5870
        public void set_UseDirectPoseCodec(){} // RVA: 0x7FFAC31E5C40
        public void CanProcessDataType4(){} // RVA: 0x7FFAC31E5C50
        public void IsNetworkSerializationReady(){} // RVA: 0x7FFAC31E5CA0
        public void GetRect(){} // RVA: 0x7FFAC31E5E70
        public void CanProcessDataPart(){} // RVA: 0x7FFAC31E5FC0
        public void Updateposition_Inj(){} // RVA: 0x7FFAC31E6850
        public void Reset(){} // RVA: 0x7FFAC31E6900
        public void CanSerialize8Bit(){} // RVA: 0x7FFAC3006850
        public void CanSerializeSpecificData(){} // RVA: 0x7FFAC31E76F0
        public void SerializedName(){} // RVA: 0x7FFAC31E7900
        public void DoSetLocalPositionAndRotation_Injected_906(){} // RVA: 0x7FFAC31E7A70
        public void DoSetLocalPositionAndRotation_Injected_A12(){} // RVA: 0x7FFAC31E7C40
        public void Update(){} // RVA: 0x7FFAC313BE20
        public void NeedsImportant(){} // RVA: 0x7FFAC3006850
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFAC31E7D90
        public void Start(){} // RVA: 0x7FFAC31E7DA0
    }

}