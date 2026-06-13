// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Assertions
// Classes: 3
// Methods: 23

namespace ThirdParty.Unity.UnityEngine.Assertions
{
    public class Assert
    {
        // ── Methods ──
        public void Fail(){} // RVA: 0x7169580
        public void IsTrue(){} // RVA: 0x7169750 | overloaded x2
        public void IsFalse(){} // RVA: 0x71697C0
        public void AreEqual(){} // RVA: 0x7169BC0 | overloaded x5
        public void IsNull(){} // RVA: 0x71699A0 | overloaded x3
        public void IsNotNull(){} // RVA: 0x7169AB0 | overloaded x3
        public void .cctor(){} // RVA: 0x7169CB0
    }

    public class AssertionException
    {
        public string m_UserMessage; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7169CF0
        public void get_Message(){} // RVA: 0x7169DC0
    }

    public class AssertionMessageUtil
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7169F30 | overloaded x2
        public void GetEqualityMessage(){} // RVA: 0x716A1D0
        public void NullFailureMessage(){} // RVA: 0x716A420
        public void BooleanFailureMessage(){} // RVA: 0x716A5C0
    }

}