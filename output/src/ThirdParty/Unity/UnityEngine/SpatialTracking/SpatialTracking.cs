// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SpatialTracking
// Classes: 3
// Methods: 36

namespace ThirdParty.Unity.UnityEngine.SpatialTracking
{
    public class PoseDataSource : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.XR.XRNodeState> nodeStates;

        // ── Methods ──
        public void GetNodePoseData(){} // RVA: 0x7FFAC99EF300
        public void TryGetDataFromSource(){} // RVA: 0x7FFAC99EF790
        public void GetDataFromSource(){} // RVA: 0x7FFAC99EF800
        public void .cctor(){} // RVA: 0x7FFAC99EFB80
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public 0x6B2E1820 deviceType; // 0x20
        public 0x6B2E1878 poseSource; // 0x24
        public UnityEngine.Experimental.XR.Interaction.BasePoseProvider poseProviderComponent; // 0x28
        public 0x6B2E18D0 trackingType; // 0x30
        public 0x6B2E1928 updateType; // 0x34
        public bool UseRelativeTransform; // 0x38
        public UnityEngine.Pose originPose; // 0x3C

        // ── Methods ──
        public void get_deviceType(){} // RVA: 0x7FFAC30DBBE0
        public void set_deviceType(){} // RVA: 0x7FFAC35DB7A0
        public void get_poseSource(){} // RVA: 0x7FFAC3921980
        public void set_poseSource(){} // RVA: 0x7FFAC41674D0
        public void SetPoseSource(){} // RVA: 0x7FFAC99EFC60
        public void get_poseProviderComponent(){} // RVA: 0x7FFAC2F4F130
        public void set_poseProviderComponent(){} // RVA: 0x7FFAC2F22E90
        public void GetPoseData(){} // RVA: 0x7FFAC99EFDE0
        public void get_trackingType(){} // RVA: 0x7FFAC2F7CCD0
        public void set_trackingType(){} // RVA: 0x7FFAC2F7CCE0
        public void get_updateType(){} // RVA: 0x7FFAC3ADEDC0
        public void set_updateType(){} // RVA: 0x7FFAC416A6E0
        public void get_UseRelativeTransform(){} // RVA: 0x7FFAC31D95D0
        public void set_UseRelativeTransform(){} // RVA: 0x7FFAC31D95C0
        public void get_originPose(){} // RVA: 0x7FFAC99EFF20
        public void set_originPose(){} // RVA: 0x7FFAC99EFF40
        public void CacheLocalPosition(){} // RVA: 0x7FFAC99EFF60
        public void ResetToCachedLocalPosition(){} // RVA: 0x7FFAC99F00E0
        public void Awake(){} // RVA: 0x7FFAC99EFF60
        public void OnDestroy(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC99F0130
        public void OnDisable(){} // RVA: 0x7FFAC99F0200
        public void FixedUpdate(){} // RVA: 0x7FFAC99F0310
        public void Update(){} // RVA: 0x7FFAC99F0310
        public void OnBeforeRender(){} // RVA: 0x7FFAC99F0340
        public void SetLocalTransform(){} // RVA: 0x7FFAC99F0370
        public void TransformPoseByOriginIfNeeded(){} // RVA: 0x7FFAC99F0530
        public void HasStereoCamera(){} // RVA: 0x7FFAC99F0610
        public void PerformUpdate(){} // RVA: 0x7FFAC99F0740
        public void .ctor(){} // RVA: 0x7FFAC99F0A10
    }

    public class TrackedPoseDriverDataDescription : Object
    {
        public System.Collections.Generic.List`1<PoseData> DeviceData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC99EE860
    }

}