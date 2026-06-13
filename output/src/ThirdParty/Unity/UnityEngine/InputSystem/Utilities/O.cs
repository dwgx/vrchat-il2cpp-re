// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 4
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class Observable
    {
        // ── Methods ──
        public void Where(){} // RVA: 0xCEC0
        public void Select(){} // RVA: 0xCEC0
        public void SelectMany(){} // RVA: 0xCEC0
        public void Take(){} // RVA: 0x1BF70
        public void ForDevice(){} // RVA: 0xCE50 | overloaded x2
        public void CallOnce(){} // RVA: 0xCEC0
        public void Call(){} // RVA: 0xCEC0
    }

    public class Observer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void OnCompleted(){} // RVA: 0x24A50
        public void OnError(){} // RVA: 0x24B10
        public void OnNext(){} // RVA: 0x283FA0
    }

    public class OneOrMore`2
    {
        public bool m_IsSingle;
        public U m_Single;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x283FA0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class OneOrMore`2
    {
        public bool m_IsSingle; // 0x10
        public UnityEngine.InputSystem.InputActionMap m_Single; // 0x18

        // ── Methods ──
        public void get_Count(){} // RVA: 0x3D9C5E0
        public void get_Item(){} // RVA: 0x3D9C630
        public void .ctor(){} // RVA: 0x3D9C740 | overloaded x2
        public void op_Implicit(){} // RVA: 0x3D9C840 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x3D9C8D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3D9C9B0
    }

}