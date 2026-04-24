// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.Extras
// Classes: 5
// Methods: 29

namespace ThirdParty.Valve.Valve.VR.Extras
{
    public class SteamVR_ForceSteamVRMode : MonoBehaviour
    {
        public BuffersImpl vrCameraPrefab; // 0x20
        public BuffersImpl[] disableObjectsOnLoad; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5414F4E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_GazeTracker : MonoBehaviour
    {
        public bool isInGaze; // 0x20
        public ent.ch GazeOn; // 0x28
        public ent.ch GazeOff; // 0x30
        public float gazeInCutoff; // 0x38
        public float gazeOutCutoff; // 0x3C
        public object hmdTrackedObject; // 0x40

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
        public dStageParamsOffset pose; // 0x20
        public or interactWithUI; // 0x28
        public bool active; // 0x30
        public object color; // 0x34
        public float thickness; // 0x44
        public object clickColor; // 0x48
        public BuffersImpl holder; // 0x58
        public BuffersImpl pointer; // 0x60
        public bool isActive; // 0x68
        public bool addRigidBody; // 0x69
        public object reference; // 0x70
        public ent.hoverRadius PointerIn; // 0x78
        public ent.hoverRadius PointerOut; // 0x80
        public ent.hoverRadius PointerClick; // 0x88
        public object previousContact; // 0x90

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
        public BuffersImpl prefab; // 0x20
        public Touched attachPoint; // 0x28
        public or spawn; // 0x30
        public dStageParamsOffset trackedObj; // 0x38
        public one joint; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54152AA0
        public void FixedUpdate(){} // RVA: 0x7FFD54152B30
        public void .ctor(){} // RVA: 0x7FFD54153440
    }

    public class SteamVR_TestTrackedCamera : MonoBehaviour
    {
        public atrix_Injected material; // 0x20
        public object target; // 0x28
        public bool undistorted; // 0x30
        public bool cropped; // 0x31

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD54153550
        public void OnDisable(){} // RVA: 0x7FFD54153650
        public void Update(){} // RVA: 0x7FFD541537C0
        public void .ctor(){} // RVA: 0x7FFD5414E100
    }

}