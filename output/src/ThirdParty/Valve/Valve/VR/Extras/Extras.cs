// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.Extras
// Classes: 5
// Methods: 29

namespace ThirdParty.Valve.Valve.VR.Extras
{
    public class SteamVR_ForceSteamVRMode : MonoBehaviour
    {
        public UnityEngine.GameObject vrCameraPrefab; // 0x20
        public UnityEngine.GameObject[] disableObjectsOnLoad; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5414F4E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_GazeTracker : MonoBehaviour
    {
        public bool isInGaze; // 0x20
        public 0x6656EA90 GazeOn; // 0x28
        public 0x6656EA90 GazeOff; // 0x30
        public float gazeInCutoff; // 0x38
        public float gazeOutCutoff; // 0x3C
        public UnityEngine.Transform hmdTrackedObject; // 0x40

        // ── Methods ──
        public void add_GazeOn(){} // RVA: 0x7FFD5414F920
        public void remove_GazeOn(){} // RVA: 0x7FFD5414FA10
        public void add_GazeOff(){} // RVA: 0x7FFD5414FB00
        public void remove_GazeOff(){} // RVA: 0x7FFD5414FBF0
        public void OnGazeOn(){} // RVA: 0x7FFD5414FCE0
        public void OnGazeOff(){} // RVA: 0x7FFD5414FD10
        public void Update(){} // RVA: 0x7FFD5414FD40
        public void .ctor(){} // RVA: 0x7FFD541504D0
    }

    public class SteamVR_LaserPointer : MonoBehaviour
    {
        public Valve.VR.SteamVR_Behaviour_Pose pose; // 0x20
        public Valve.VR.SteamVR_Action_Boolean interactWithUI; // 0x28
        public bool active; // 0x30
        public UnityEngine.Color color; // 0x34
        public float thickness; // 0x44
        public UnityEngine.Color clickColor; // 0x48
        public UnityEngine.GameObject holder; // 0x58
        public UnityEngine.GameObject pointer; // 0x60
        public bool isActive; // 0x68
        public bool addRigidBody; // 0x69
        public UnityEngine.Transform reference; // 0x70
        public 0x6656EB98 PointerIn; // 0x78
        public 0x6656EB98 PointerOut; // 0x80
        public 0x6656EB98 PointerClick; // 0x88
        public UnityEngine.Transform previousContact; // 0x90

        // ── Methods ──
        public void add_PointerIn(){} // RVA: 0x7FFD54150740
        public void remove_PointerIn(){} // RVA: 0x7FFD54150830
        public void add_PointerOut(){} // RVA: 0x7FFD54150920
        public void remove_PointerOut(){} // RVA: 0x7FFD54150A10
        public void add_PointerClick(){} // RVA: 0x7FFD54150B00
        public void remove_PointerClick(){} // RVA: 0x7FFD54150BF0
        public void Start(){} // RVA: 0x7FFD54150CE0
        public void OnPointerIn(){} // RVA: 0x7FFD54151970
        public void OnPointerClick(){} // RVA: 0x7FFD541519B0
        public void OnPointerOut(){} // RVA: 0x7FFD54151A00
        public void Update(){} // RVA: 0x7FFD54151A50
        public void .ctor(){} // RVA: 0x7FFD54152910
    }

    public class SteamVR_TestThrow : MonoBehaviour
    {
        public UnityEngine.GameObject prefab; // 0x20
        public UnityEngine.Rigidbody attachPoint; // 0x28
        public Valve.VR.SteamVR_Action_Boolean spawn; // 0x30
        public Valve.VR.SteamVR_Behaviour_Pose trackedObj; // 0x38
        public UnityEngine.FixedJoint joint; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54152AA0
        public void FixedUpdate(){} // RVA: 0x7FFD54152B30
        public void .ctor(){} // RVA: 0x7FFD54153440
    }

    public class SteamVR_TestTrackedCamera : MonoBehaviour
    {
        public UnityEngine.Material material; // 0x20
        public UnityEngine.Transform target; // 0x28
        public bool undistorted; // 0x30
        public bool cropped; // 0x31

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD54153550
        public void OnDisable(){} // RVA: 0x7FFD54153650
        public void Update(){} // RVA: 0x7FFD541537C0
        public void .ctor(){} // RVA: 0x7FFD5414E100
    }

}