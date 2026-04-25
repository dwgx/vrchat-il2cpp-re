// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.Extras
// Classes: 9
// Methods: 37

namespace ThirdParty.Valve.Valve.VR.Extras
{
    public class GazeEventArgs : ValueType
    {
        public float distance; // 0x10
    }

    public class GazeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D30530
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC8D306B0
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class PointerEventArgs : ValueType
    {
        public 0x6B209C88 fromInputSource; // 0x10
        public uint flags; // 0x14
        public float distance; // 0x18
        public UnityEngine.Transform target; // 0x20
    }

    public class PointerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60568C0
        public void Invoke(){} // RVA: 0x7FFAC5CB9ED0
        public void BeginInvoke(){} // RVA: 0x7FFAC8D32A10
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class SteamVR_ForceSteamVRMode : MonoBehaviour
    {
        public UnityEngine.GameObject vrCameraPrefab; // 0x20
        public UnityEngine.GameObject[] disableObjectsOnLoad; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D2F4E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_GazeTracker : MonoBehaviour
    {
        public bool isInGaze; // 0x20
        public Valve.VR.Extras.GazeEventHandler GazeOn; // 0x28
        public Valve.VR.Extras.GazeEventHandler GazeOff; // 0x30
        public float gazeInCutoff; // 0x38
        public float gazeOutCutoff; // 0x3C
        public UnityEngine.Transform hmdTrackedObject; // 0x40

        // ── Methods ──
        public void add_GazeOn(){} // RVA: 0x7FFAC8D2F920
        public void remove_GazeOn(){} // RVA: 0x7FFAC8D2FA10
        public void add_GazeOff(){} // RVA: 0x7FFAC8D2FB00
        public void remove_GazeOff(){} // RVA: 0x7FFAC8D2FBF0
        public void OnGazeOn(){} // RVA: 0x7FFAC8D2FCE0
        public void OnGazeOff(){} // RVA: 0x7FFAC8D2FD10
        public void Update(){} // RVA: 0x7FFAC8D2FD40
        public void .ctor(){} // RVA: 0x7FFAC8D304D0
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
        public Valve.VR.Extras.PointerEventHandler PointerIn; // 0x78
        public Valve.VR.Extras.PointerEventHandler PointerOut; // 0x80
        public Valve.VR.Extras.PointerEventHandler PointerClick; // 0x88
        public UnityEngine.Transform previousContact; // 0x90

        // ── Methods ──
        public void add_PointerIn(){} // RVA: 0x7FFAC8D30740
        public void remove_PointerIn(){} // RVA: 0x7FFAC8D30830
        public void add_PointerOut(){} // RVA: 0x7FFAC8D30920
        public void remove_PointerOut(){} // RVA: 0x7FFAC8D30A10
        public void add_PointerClick(){} // RVA: 0x7FFAC8D30B00
        public void remove_PointerClick(){} // RVA: 0x7FFAC8D30BF0
        public void Start(){} // RVA: 0x7FFAC8D30CE0
        public void OnPointerIn(){} // RVA: 0x7FFAC8D31970
        public void OnPointerClick(){} // RVA: 0x7FFAC8D319B0
        public void OnPointerOut(){} // RVA: 0x7FFAC8D31A00
        public void Update(){} // RVA: 0x7FFAC8D31A50
        public void .ctor(){} // RVA: 0x7FFAC8D32910
    }

    public class SteamVR_TestThrow : MonoBehaviour
    {
        public UnityEngine.GameObject prefab; // 0x20
        public UnityEngine.Rigidbody attachPoint; // 0x28
        public Valve.VR.SteamVR_Action_Boolean spawn; // 0x30
        public Valve.VR.SteamVR_Behaviour_Pose trackedObj; // 0x38
        public UnityEngine.FixedJoint joint; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D32AA0
        public void FixedUpdate(){} // RVA: 0x7FFAC8D32B30
        public void .ctor(){} // RVA: 0x7FFAC8D33440
    }

    public class SteamVR_TestTrackedCamera : MonoBehaviour
    {
        public UnityEngine.Material material; // 0x20
        public UnityEngine.Transform target; // 0x28
        public bool undistorted; // 0x30
        public bool cropped; // 0x31

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC8D33550
        public void OnDisable(){} // RVA: 0x7FFAC8D33650
        public void Update(){} // RVA: 0x7FFAC8D337C0
        public void .ctor(){} // RVA: 0x7FFAC8D2E100
    }

}