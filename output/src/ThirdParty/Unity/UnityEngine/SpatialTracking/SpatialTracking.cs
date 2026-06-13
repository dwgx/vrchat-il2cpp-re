// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SpatialTracking
// Classes: 3
// Methods: 36

namespace ThirdParty.Unity.UnityEngine.SpatialTracking
{
    public class PoseDataSource
    {
        // ── Methods ──
        public void GetNodePoseData(){} // RVA: 0x7257A00
        public void TryGetDataFromSource(){} // RVA: 0x7257E90
        public void GetDataFromSource(){} // RVA: 0x7257F00
        public void .cctor(){} // RVA: 0x7258280
    }

    public class TrackedPoseDriver
    {
        public 0x65A056A0 m_Device; // 0x20
        public 0x65A056F8 m_PoseSource; // 0x24
        public UnityEngine.Experimental.XR.Interaction.BasePoseProvider m_PoseProviderComponent; // 0x28
        public 0x65A05750 m_TrackingType; // 0x30
        public 0x65A057A8 m_UpdateType; // 0x34
        public bool m_UseRelativeTransform; // 0x38
        public UnityEngine.Pose m_OriginPose; // 0x3C

        // ── Methods ──
        public void get_deviceType(){} // RVA: 0x760030
        public void set_deviceType(){} // RVA: 0x99E0D0
        public void get_poseSource(){} // RVA: 0xCEF5B0
        public void set_poseSource(){} // RVA: 0x16E1F00
        public void SetPoseSource(){} // RVA: 0x7258360
        public void get_poseProviderComponent(){} // RVA: 0x30B130
        public void set_poseProviderComponent(){} // RVA: 0x2DEE90
        public void GetPoseData(){} // RVA: 0x72584E0
        public void get_trackingType(){} // RVA: 0x338CD0
        public void set_trackingType(){} // RVA: 0x338CE0
        public void get_updateType(){} // RVA: 0x4C6670
        public void set_updateType(){} // RVA: 0x4C5F20
        public void get_UseRelativeTransform(){} // RVA: 0x4A6500
        public void set_UseRelativeTransform(){} // RVA: 0x4A78C0
        public void get_originPose(){} // RVA: 0x7258620
        public void set_originPose(){} // RVA: 0x7258640
        public void CacheLocalPosition(){} // RVA: 0x7258660
        public void ResetToCachedLocalPosition(){} // RVA: 0x72587E0
        public void Awake(){} // RVA: 0x7258660
        public void OnDestroy(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x7258830
        public void OnDisable(){} // RVA: 0x7258900
        public void FixedUpdate(){} // RVA: 0x7258A10
        public void Update(){} // RVA: 0x7258A10
        public void OnBeforeRender(){} // RVA: 0x7258A40
        public void SetLocalTransform(){} // RVA: 0x7258A70
        public void TransformPoseByOriginIfNeeded(){} // RVA: 0x7258C30
        public void HasStereoCamera(){} // RVA: 0x7258D10
        public void PerformUpdate(){} // RVA: 0x7258E40
        public void .ctor(){} // RVA: 0x7259110
    }

    public class TrackedPoseDriverDataDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x7256F60
    }

}