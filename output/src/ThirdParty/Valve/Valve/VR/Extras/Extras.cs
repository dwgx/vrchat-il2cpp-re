// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.Extras
// Classes: 9
// Methods: 37

namespace ThirdParty.Valve.Valve.VR.Extras
{
    public class GazeEventArgs : ValueType
    {
    }

    public class GazeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870D8A20
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE870D8BA0
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class PointerEventArgs : ValueType
    {
    }

    public class PointerEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8441F9A0
        public void Invoke(){} // RVA: 0x7FFE84018310
        public void BeginInvoke(){} // RVA: 0x7FFE870DAF00
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class SteamVR_ForceSteamVRMode : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE870D79D0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_GazeTracker : MonoBehaviour
    {
        // ── Methods ──
        public void add_GazeOn(){} // RVA: 0x7FFE870D7E10
        public void remove_GazeOn(){} // RVA: 0x7FFE870D7F00
        public void add_GazeOff(){} // RVA: 0x7FFE870D7FF0
        public void remove_GazeOff(){} // RVA: 0x7FFE870D80E0
        public void OnGazeOn(){} // RVA: 0x7FFE870D81D0
        public void OnGazeOff(){} // RVA: 0x7FFE870D8200
        public void Update(){} // RVA: 0x7FFE870D8230
        public void .ctor(){} // RVA: 0x7FFE870D89C0
    }

    public class SteamVR_LaserPointer : MonoBehaviour
    {
        // ── Methods ──
        public void add_PointerIn(){} // RVA: 0x7FFE870D8C30
        public void remove_PointerIn(){} // RVA: 0x7FFE870D8D20
        public void add_PointerOut(){} // RVA: 0x7FFE870D8E10
        public void remove_PointerOut(){} // RVA: 0x7FFE870D8F00
        public void add_PointerClick(){} // RVA: 0x7FFE870D8FF0
        public void remove_PointerClick(){} // RVA: 0x7FFE870D90E0
        public void Start(){} // RVA: 0x7FFE870D91D0
        public void OnPointerIn(){} // RVA: 0x7FFE870D9E60
        public void OnPointerClick(){} // RVA: 0x7FFE870D9EA0
        public void OnPointerOut(){} // RVA: 0x7FFE870D9EF0
        public void Update(){} // RVA: 0x7FFE870D9F40
        public void .ctor(){} // RVA: 0x7FFE870DAE00
    }

    public class SteamVR_TestThrow : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE870DAF90
        public void FixedUpdate(){} // RVA: 0x7FFE870DB020
        public void .ctor(){} // RVA: 0x7FFE870DB930
    }

    public class SteamVR_TestTrackedCamera : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE870DBA40
        public void OnDisable(){} // RVA: 0x7FFE870DBB40
        public void Update(){} // RVA: 0x7FFE870DBCB0
        public void .ctor(){} // RVA: 0x7FFE870D65F0
    }

}