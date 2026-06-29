// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 2
// Methods: 32

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Touchscreen : Pointer
    {
        public object _primaryTouch;
        public object _touches;
        public object k_TouchscreenUpdateMarker;
        public object k_TouchAllocateMarker;
        public object _current;
        public object s_TapTime;
        public object s_TapDelayTime;
        public object s_TapRadiusSquared;

        // ── Methods ──
        public void get_primaryTouch(){} // RVA: 0x1344890
        public void set_primaryTouch(){} // RVA: 0x1662780
        public void get_touches(){} // RVA: 0x78BC500
        public void set_touches(){} // RVA: 0x78BC510
        public void get_touchControlArray(){} // RVA: 0x1655DD0
        public void set_touchControlArray(){} // RVA: 0x78BC570
        public void get_current(){} // RVA: 0x78BC690
        public void set_current(){} // RVA: 0x78BC6F0
        public void MakeCurrent(){} // RVA: 0x78BC7B0
        public void OnRemoved(){} // RVA: 0x78BC810
        public void FinishSetup(){} // RVA: 0x78BC900
        public void OnNextUpdate(){} // RVA: 0x78BCF90
        public void OnStateEvent(){} // RVA: 0x78BD440
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x78BDCC0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x78BDCD0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x78BDCE0
        public void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset(){} // RVA: 0x78BE030
        public void MergeForward(){} // RVA: 0x78BE530
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x78BE5C0
        public void TriggerTap(){} // RVA: 0x78BE6A0
        public void .ctor(){} // RVA: 0x77D4F00
        public void .cctor(){} // RVA: 0x78BE740
    }

    public class TrackedDevice : InputDevice
    {
        public object _trackingState;
        public object _isTracked;
        public object _devicePosition;
        public object _deviceRotation;

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x13659D0
        public void set_trackingState(){} // RVA: 0x166D270
        public void get_isTracked(){} // RVA: 0x135C160
        public void set_isTracked(){} // RVA: 0x16614A0
        public void get_devicePosition(){} // RVA: 0x1664460
        public void set_devicePosition(){} // RVA: 0x16679E0
        public void get_deviceRotation(){} // RVA: 0x135A180
        public void set_deviceRotation(){} // RVA: 0x164D690
        public void FinishSetup(){} // RVA: 0x78BE7F0
        public void .ctor(){} // RVA: 0x77D4F00
    }

}