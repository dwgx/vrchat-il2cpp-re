// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 2
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Touchscreen : Pointer
    {
        // ── Methods ──
        public void get_primaryTouch(){} // RVA: 0x7A8815B70
        public void set_primaryTouch(){} // RVA: 0x7A8B58420
        public void get_touches(){} // RVA: 0x7AEC4D9D0
        public void set_touches(){} // RVA: 0x7AEC4D9E0
        public void get_touchControlArray(){} // RVA: 0x7A8B6AFA0
        public void set_touchControlArray(){} // RVA: 0x7AEC4DA40
        public void get_current(){} // RVA: 0x7AEC4DB60
        public void set_current(){} // RVA: 0x7AEC4DBC0
        public void MakeCurrent(){} // RVA: 0x7AEC4DC80
        public void OnRemoved(){} // RVA: 0x7AEC4DCE0
        public void FinishSetup(){} // RVA: 0x7AEC4DDD0
        public void OnNextUpdate(){} // RVA: 0x7AEC4E460
        public void OnStateEvent(){} // RVA: 0x7AEC4E910
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7AEC4F190
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7AEC4F1A0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7AEC4F1B0
        public void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset(){} // RVA: 0x7AEC4F540
        public void MergeForward(){} // RVA: 0x7AEC4FA40
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7AEC4FAD0
        public void TriggerTap(){} // RVA: 0x7AEC4FBB0
        public void .ctor(){} // RVA: 0x7AEB6BB90
        public void .cctor(){} // RVA: 0x7AEC4FC50
    }

    public class TrackedDevice : InputDevice
    {
        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7A884DD70
        public void set_trackingState(){} // RVA: 0x7A8B5ADA0
        public void get_isTracked(){} // RVA: 0x7A8855020
        public void set_isTracked(){} // RVA: 0x7A8B60460
        public void get_devicePosition(){} // RVA: 0x7A8B76160
        public void set_devicePosition(){} // RVA: 0x7A8B592F0
        public void get_deviceRotation(){} // RVA: 0x7A8852B30
        public void set_deviceRotation(){} // RVA: 0x7A8B66E80
        public void FinishSetup(){} // RVA: 0x7AEC4FD70
        public void .ctor(){} // RVA: 0x7AEB6BB90
        public void <trackingState>k__BackingField(){} // RVA: 0x7B4177678
    }

}