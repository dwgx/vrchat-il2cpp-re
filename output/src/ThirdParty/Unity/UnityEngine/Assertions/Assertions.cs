// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Assertions
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.Assertions
{
    public class Assert : Object
    {
        public object raiseExceptions;

        // ── Methods ──
        public void Fail(){} // RVA: 0x7C32A90
        public void IsTrue(){} // RVA: 0x7C32C20
        public void IsFalse(){} // RVA: 0x7C32CF0
        public void AreEqual(){} // RVA: 0x7C330F0
        public void IsNull(){} // RVA: 0x7C32ED0
        public void IsNotNull(){} // RVA: 0x7C32FE0
        public void .cctor(){} // RVA: 0x7C331E0
    }

    public class AssertionException : Exception
    {
        public object m_UserMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7C33220
        public void get_Message(){} // RVA: 0x7C332F0
    }

    public class AssertionMessageUtil : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7C33460
        public void GetEqualityMessage(){} // RVA: 0x7C33700
        public void NullFailureMessage(){} // RVA: 0x7C33950
        public void BooleanFailureMessage(){} // RVA: 0x7C33AF0
    }

}