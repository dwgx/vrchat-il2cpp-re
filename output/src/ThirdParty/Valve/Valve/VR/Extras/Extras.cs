// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.Extras
// Classes: 7
// Methods: 37

namespace ThirdParty.Valve.Valve.VR.Extras
{
    public class GazeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70077C0
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x7007930
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class PointerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x40E0630
        public void Invoke(){} // RVA: 0x3E37A50
        public void BeginInvoke(){} // RVA: 0x7009A10
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class SteamVR_ForceSteamVRMode : MonoBehaviour
    {
        public object vrCameraPrefab;
        public object disableObjectsOnLoad;

        // ── Methods ──
        public void Start(){} // RVA: 0x70066E0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_GazeTracker : MonoBehaviour
    {
        public object isInGaze;
        public object GazeOn;
        public object GazeOff;
        public object gazeInCutoff;
        public object gazeOutCutoff;
        public object hmdTrackedObject;

        // ── Methods ──
        public void add_GazeOn(){} // RVA: 0x7006B20
        public void remove_GazeOn(){} // RVA: 0x7006C10
        public void add_GazeOff(){} // RVA: 0x7006D00
        public void remove_GazeOff(){} // RVA: 0x7006DF0
        public void OnGazeOn(){} // RVA: 0x7006EE0
        public void OnGazeOff(){} // RVA: 0x7006F10
        public void Update(){} // RVA: 0x7006F40
        public void .ctor(){} // RVA: 0x7007760
    }

    public class SteamVR_LaserPointer : MonoBehaviour
    {
        public object pose;
        public object interactWithUI;
        public object active;
        public object color;
        public object thickness;
        public object clickColor;
        public object holder;
        public object pointer;
        public object isActive;
        public object addRigidBody;
        public object reference;
        public object PointerIn;
        public object PointerOut;
        public object PointerClick;
        public object previousContact;

        // ── Methods ──
        public void add_PointerIn(){} // RVA: 0x70079C0
        public void remove_PointerIn(){} // RVA: 0x7007AB0
        public void add_PointerOut(){} // RVA: 0x7007BA0
        public void remove_PointerOut(){} // RVA: 0x7007CA0
        public void add_PointerClick(){} // RVA: 0x7007DA0
        public void remove_PointerClick(){} // RVA: 0x7007EA0
        public void Start(){} // RVA: 0x7007FA0
        public void OnPointerIn(){} // RVA: 0x7008B00
        public void OnPointerClick(){} // RVA: 0x7008B40
        public void OnPointerOut(){} // RVA: 0x7008B90
        public void Update(){} // RVA: 0x7008BE0
        public void .ctor(){} // RVA: 0x7009910
    }

    public class SteamVR_TestThrow : MonoBehaviour
    {
        public object prefab;
        public object attachPoint;
        public object spawn;
        public object trackedObj;
        public object joint;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7009AA0
        public void FixedUpdate(){} // RVA: 0x7009B30
        public void .ctor(){} // RVA: 0x700A560
    }

    public class SteamVR_TestTrackedCamera : MonoBehaviour
    {
        public object material;
        public object target;
        public object undistorted;
        public object cropped;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x700A670
        public void OnDisable(){} // RVA: 0x700A730
        public void Update(){} // RVA: 0x700A8D0
        public void .ctor(){} // RVA: 0x7005390
    }

}