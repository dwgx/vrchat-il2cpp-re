// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 4
// Methods: 23

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class Observable : Object
    {
        // ── Methods ──
        public void Where(){} // RVA: 0x87C630
        public void Select(){} // RVA: 0x87C630
        public void SelectMany(){} // RVA: 0x87C630
        public void Take(){} // RVA: 0x88B6E0
        public void ForDevice(){} // RVA: 0x87C5C0
        public void CallOnce(){} // RVA: 0x87C630
        public void Call(){} // RVA: 0x87C630
    }

    public class Observer`1 : Object
    {
        public object m_OnNext;
        public object m_OnCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void OnCompleted(){} // RVA: 0x894290
        public void OnError(){} // RVA: 0x894320
        public void OnNext(){} // RVA: 0xA94080
    }

    public class OneOrMore`2 : ValueType
    {
        public object m_IsSingle;
        public object m_Single;
        public object m_Multiple;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x87C130
        public void get_Item(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xA94080
        public void op_Implicit(){} // RVA: 0xA94080
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class OneOrMore`2 : ValueType
    {
        public object m_IsSingle;
        public object m_Single;
        public object m_Multiple;

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x4759B0
        public void op_Implicit(){} // RVA: 0x4808A60
        public void get_Count(){} // RVA: 0x475890
        public void get_Item(){} // RVA: 0x4758E0
        public void .ctor(){} // RVA: 0x475950
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4759C0
    }

}