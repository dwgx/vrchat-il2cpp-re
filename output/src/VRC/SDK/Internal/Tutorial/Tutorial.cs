// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK.Internal.Tutorial
// Classes: 6
// Methods: 23

namespace VRC.SDK.Internal.Tutorial
{
    public class DistanceEnabler : MonoBehaviour
    {
        public float enableDistance; // 0x20
        public BuffersImpl objectToEnable; // 0x28
        public BuffersImpl objectToDisable; // 0x30
        public bool gotObjectToEnable; // 0x38
        public bool gotObjectToDisable; // 0x39

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4FAE25E0
        public void FixedUpdate(){} // RVA: 0x7FFD4FAE2750
        public void OnDrawGizmos(){} // RVA: 0x7FFD4FAE2B10
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class TutorialHelpers : MonoBehaviour
    {
        // ── Methods ──
        public void ShowLocomotionControls(){} // RVA: 0x7FFD4FAE2C90
        public void Force3PLocomotionSetting(){} // RVA: 0x7FFD4FAE2F10
        public void MoveHaptic(){} // RVA: 0x7FFD4FAE2F70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class TutorialHelpers3 : MonoBehaviour
    {
        // ── Methods ──
        public void Force3PLocomotionSetting(){} // RVA: 0x7FFD4FAE31C0
        public void SetComfortTurning(){} // RVA: 0x7FFD4FAE3230
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class TutorialInit : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4FAE32A0
        public void Initialize(){} // RVA: 0x7FFD4FAE32A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCAnalytics : Object
    {
        public rectoryInformation<string,URA.DateTime<string,object>> _Send;
        public ileFullDirectoryInformation<URA.DateTime<string,object>> _SetUserProperties; // 0x8
        public ÏÍÍÌÎÍÏÏÎÏÏÍÌÍÏ<string,string,aphy<bool>,int,float> _SendCustomWorldEvent; // 0x10

        // ── Methods ──
        public void Send(){} // RVA: 0x7FFD4FAE34C0 | overloaded x2
        public void SetUserProperties(){} // RVA: 0x7FFD4FAE3530
        public void SendCustomWorldEvent(){} // RVA: 0x7FFD4FAE3590
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class VRCAvatarCalibrator : MonoBehaviour
    {
        public string blueprintId; // 0x20
        public bool grantBlueprintAccess; // 0x28
        public object Placement; // 0x30
        public bool ChangeAvatarsOnUse; // 0x38
        public float scale; // 0x3C
        public float userEyeHeight; // 0x40
        public BuffersImpl Instance; // 0x48
        public object Instantiate;

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4FAE3640
        public void SwitchAvatar(){} // RVA: 0x7FFD4FAE3B20
        public void UpdateHeight(){} // RVA: 0x7FFD4FAE3C80
        public void .ctor(){} // RVA: 0x7FFD4FAE3DA0
    }

}