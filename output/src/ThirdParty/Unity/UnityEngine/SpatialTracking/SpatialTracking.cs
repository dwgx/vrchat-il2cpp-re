// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SpatialTracking
// Classes: 3
// Methods: 36

namespace ThirdParty.Unity.UnityEngine.SpatialTracking
{
    public class PoseDataSource : Object
    {
        // ── Methods ──
        public void GetNodePoseData(){} // RVA: 0x7FFE87D97BA0
        public void TryGetDataFromSource(){} // RVA: 0x7FFE87D98030
        public void GetDataFromSource(){} // RVA: 0x7FFE87D980A0
        public void .cctor(){} // RVA: 0x7FFE87D98420
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public 0x666DD084 m_Device; // 0x20
        public dFixup.estWritten m_PoseSource; // 0x24
        public UnityEngine.Experimental.XR.Interaction.BasePoseProvider m_PoseProviderComponent; // 0x28
        public 0x666DD134 m_TrackingType; // 0x30
        public 0x666DD18C m_UpdateType; // 0x34
        public bool m_UseRelativeTransform; // 0x38
        public UnityEngine.Pose m_OriginPose; // 0x3C

        // ── Methods ──
        public void get_deviceType(){} // RVA: 0x7FFE8151D690
        public void set_deviceType(){} // RVA: 0x7FFE8170B670
        public void get_poseSource(){} // RVA: 0x7FFE81A56130
        public void set_poseSource(){} // RVA: 0x7FFE82447980
        public void SetPoseSource(){} // RVA: 0x7FFE87D98500
        public void get_poseProviderComponent(){} // RVA: 0x7FFE81129130
        public void set_poseProviderComponent(){} // RVA: 0x7FFE810FCE90
        public void GetPoseData(){} // RVA: 0x7FFE87D98680
        public void get_trackingType(){} // RVA: 0x7FFE81156CD0
        public void set_trackingType(){} // RVA: 0x7FFE81156CE0
        public void get_updateType(){} // RVA: 0x7FFE82447220
        public void set_updateType(){} // RVA: 0x7FFE82443340
        public void get_UseRelativeTransform(){} // RVA: 0x7FFE812CF770
        public void set_UseRelativeTransform(){} // RVA: 0x7FFE812D0010
        public void get_originPose(){} // RVA: 0x7FFE87D987C0
        public void set_originPose(){} // RVA: 0x7FFE87D987E0
        public void CacheLocalPosition(){} // RVA: 0x7FFE87D98800
        public void ResetToCachedLocalPosition(){} // RVA: 0x7FFE87D98980
        public void Awake(){} // RVA: 0x7FFE87D98800
        public void OnDestroy(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE87D989D0
        public void OnDisable(){} // RVA: 0x7FFE87D98AA0
        public void FixedUpdate(){} // RVA: 0x7FFE87D98BB0
        public void Update(){} // RVA: 0x7FFE87D98BB0
        public void OnBeforeRender(){} // RVA: 0x7FFE87D98BE0
        public void SetLocalTransform(){} // RVA: 0x7FFE87D98C10
        public void TransformPoseByOriginIfNeeded(){} // RVA: 0x7FFE87D98DD0
        public void HasStereoCamera(){} // RVA: 0x7FFE87D98EB0
        public void PerformUpdate(){} // RVA: 0x7FFE87D98FE0
        public void .ctor(){} // RVA: 0x7FFE87D992B0
    }

    public class TrackedPoseDriverDataDescription : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87D97100
    }

}