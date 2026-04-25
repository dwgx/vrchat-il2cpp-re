// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
// Classes: 5
// Methods: 20

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR.Haptics
{
    public class BufferedRumble : ValueType
    {
        public object capabilities;
        public object device;

        // ── Methods ──
        public void get_capabilities(){} // RVA: 0x7FFD54A5AEF0
        public void set_capabilities(){} // RVA: 0x7FFD54A5AF00
        public void get_device(){} // RVA: 0x7FFD4E3447C0
        public void set_device(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD54A5AF10
        public void EnqueueRumble(){} // RVA: 0x7FFD54A5B0B0
    }

    public class GetCurrentHapticStateCommand : ValueType
    {
        public object Type;
        public object typeStatic;
        public object currentState;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B2E0
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B2E0
        public void get_currentState(){} // RVA: 0x7FFD54A5B2F0
        public void Create(){} // RVA: 0x7FFD54A5B310
    }

    public class GetHapticCapabilitiesCommand : ValueType
    {
        public object Type;
        public object typeStatic;
        public object capabilities;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B380
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B380
        public void get_capabilities(){} // RVA: 0x7FFD54A5B390
        public void Create(){} // RVA: 0x7FFD54A5B3C0
    }

    public class SendBufferedHapticCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B3F0
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B3F0
        public void Create(){} // RVA: 0x7FFD54A5B400
    }

    public class SendHapticImpulseCommand : ValueType
    {
        public object Type;
        public object typeStatic;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFD54A5B5A0
        public void get_typeStatic(){} // RVA: 0x7FFD54A5B5A0
        public void Create(){} // RVA: 0x7FFD54A5B5B0
    }

}