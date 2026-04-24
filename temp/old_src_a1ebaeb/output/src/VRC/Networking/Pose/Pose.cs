// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Networking.Pose
// Classes: 4
// Methods: 49

namespace VRC.Networking.Pose
{
    public class PoseAV2Update : PoseRemoteUpdate
    {
        // ── Original Methods ──
        public void SampleProfilerBegin(){} // RVA: 0x7ffaa8c0cc70
        public void CaptureProfilerSample(){} // RVA: 0x7ffaa8c0cc70
        public void LateUpdate(){} // RVA: 0x7ffaa8c0cc70
        public void StartProfilerSampling(){} // RVA: 0x7ffaa8c0cc70
        public void ExecuteProfilerSample(){} // RVA: 0x7ffaa8c0cc70
        public void .ctor(){} // RVA: 0x7ffaa8c0cee0
        public void Initialize(){} // RVA: 0x7ffaa8c0cc70
        public void InitiateProfilerProbe(){} // RVA: 0x7ffaa8c0cc70
        // ── Binary Analysis Named ──
        public void DoInitializeArray(){} // RVA: 0x7ffaa8c0cd70
        public void BeginProfilerSection(){} // RVA: 0x7ffaa8c0cc70
        public void GetTime_063(){} // RVA: 0x7ffaa8c0cc70
    }

    public class PoseAV3Update : PoseRemoteUpdate
    {
        // ── Original Methods ──
        public void UpdatePoseProfile(){} // RVA: 0x7ffaa8c0cfd0
        public void .ctor(){} // RVA: 0x7ffaa8c0d190
        public void Update(){} // RVA: 0x7ffaa8c0d0b0
        public void LateUpdate(){} // RVA: 0x7ffaa8c0cfd0
        // ── Binary Analysis Named ──
        public void BeginPoseUpdateProfilingSample(){} // RVA: 0x7ffaa8c0cfd0
        public void DoInitializeArray(){} // RVA: 0x7ffaa8c0d280
        // ── Obfuscated Methods ──
        public void m_5FD(){} // RVA: 0x7ffaa8c0d0b0
        public void m_4BF(){} // RVA: 0x7ffaa8c0cfd0
        public void m_A20(){} // RVA: 0x7ffaa8c0d0b0
        public void m_0B7(){} // RVA: 0x7ffaa8c0d0b0
        public void m_8AA(){} // RVA: 0x7ffaa8c0d0b0
        public void m_A1A(){} // RVA: 0x7ffaa8c0d0b0
    }

    public class PoseLocalUpdate : MonoBehaviour
    {
        // ── Original Methods ──
        public void LateUpdate(){} // RVA: 0x7ffaa8c0d520
        public void IsInvoking(){} // RVA: 0x7ffaa8c0d650
        public void CancelInvoke(){} // RVA: 0x7ffaa8c0d780
        public void .ctor(){} // RVA: 0x7ffaa8c0d8b0
        public void OnBecameInvisible(){} // RVA: 0x7ffaa8c0dc00
        public void StartCoroutine(){} // RVA: 0x7ffaa8c0dd30
        public void OnCollisionStay(){} // RVA: 0x7ffaa8c0de60
        // ── Binary Analysis Named ──
        public void GetGameObject_785(){} // RVA: 0x7ffaa8c0d3f0
        public void GetTransform_063(){} // RVA: 0x7ffaa8c0d9a0
        public void GetTransform_4BF(){} // RVA: 0x7ffaa8c0dad0
    }

    public class PoseRemoteUpdate : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa8c0c6b0
        public void IsInvoking(){} // RVA: 0x7ffaa8c0c6d0
        public void CancelInvoke(){} // RVA: 0x7ffaa8c0c720
        public void Invoke(){} // RVA: 0x7ffaa8c0c730
        public void OnEnable(){} // RVA: 0x7ffaa8c0c6b0
        public void StartCoroutine(){} // RVA: 0x7ffaa8c0caa0
        public void Update(){} // RVA: 0x7ffaa8c0c6b0
        public void LateUpdate(){} // RVA: 0x7ffaa8c0c6b0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa8c0c730
        public void OnDestroy(){} // RVA: 0x7ffaa8c0c730
        public void Start(){} // RVA: 0x7ffaa8c0c720
        // ── Binary Analysis Named ──
        public void DoInitializeArray(){} // RVA: 0x7ffaa8c0c780
        public void GetTime_88D(){} // RVA: 0x7ffaa8c0c8f0
        public void GetTime_284(){} // RVA: 0x7ffaa8c0cc10
        public void GetTime_494(){} // RVA: 0x7ffaa8c0cc40
    }

}