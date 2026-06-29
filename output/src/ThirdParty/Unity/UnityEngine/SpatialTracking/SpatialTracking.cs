// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SpatialTracking
// Classes: 3
// Methods: 36

namespace ThirdParty.Unity.UnityEngine.SpatialTracking
{
    public class PoseDataSource : Object
    {
        public object nodeStates;

        // ── Methods ──
        public void GetNodePoseData(){} // RVA: 0x7DAA4C0
        public void TryGetDataFromSource(){} // RVA: 0x7DAA960
        public void GetDataFromSource(){} // RVA: 0x7DAA9D0
        public void .cctor(){} // RVA: 0x7DAAD50
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public object m_Device;
        public object m_PoseSource;
        public object m_PoseProviderComponent;
        public object m_TrackingType;
        public object m_UpdateType;
        public object m_UseRelativeTransform;
        public object m_OriginPose;

        // ── Methods ──
        public void get_deviceType(){} // RVA: 0xFEAE90
        public void set_deviceType(){} // RVA: 0x1269760
        public void get_poseSource(){} // RVA: 0x15AF000
        public void set_poseSource(){} // RVA: 0x1FAA840
        public void SetPoseSource(){} // RVA: 0x7DAAE30
        public void get_poseProviderComponent(){} // RVA: 0xB70160
        public void set_poseProviderComponent(){} // RVA: 0xB44DC0
        public void GetPoseData(){} // RVA: 0x7DAAFC0
        public void get_trackingType(){} // RVA: 0xB9E080
        public void set_trackingType(){} // RVA: 0xB9E090
        public void get_updateType(){} // RVA: 0xE9CE60
        public void set_updateType(){} // RVA: 0xEA1260
        public void get_UseRelativeTransform(){} // RVA: 0xD16660
        public void set_UseRelativeTransform(){} // RVA: 0xD14C10
        public void get_originPose(){} // RVA: 0x7DAB100
        public void set_originPose(){} // RVA: 0x7DAB120
        public void CacheLocalPosition(){} // RVA: 0x7DAB140
        public void ResetToCachedLocalPosition(){} // RVA: 0x7DAB2C0
        public void Awake(){} // RVA: 0x7DAB140
        public void OnDestroy(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0x7DAB310
        public void OnDisable(){} // RVA: 0x7DAB3E0
        public void FixedUpdate(){} // RVA: 0x7DAB4F0
        public void Update(){} // RVA: 0x7DAB4F0
        public void OnBeforeRender(){} // RVA: 0x7DAB520
        public void SetLocalTransform(){} // RVA: 0x7DAB550
        public void TransformPoseByOriginIfNeeded(){} // RVA: 0x7DAB720
        public void HasStereoCamera(){} // RVA: 0x7DAB800
        public void PerformUpdate(){} // RVA: 0x7DAB900
        public void .ctor(){} // RVA: 0x7DABC10
    }

    public class TrackedPoseDriverDataDescription : Object
    {
        public object DeviceData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7DA9A10
    }

}