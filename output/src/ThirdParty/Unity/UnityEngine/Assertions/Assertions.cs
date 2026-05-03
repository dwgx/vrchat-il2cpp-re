// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Assertions
// Classes: 3
// Methods: 23

namespace ThirdParty.Unity.UnityEngine.Assertions
{
    public class Assert : Object
    {
        // ── Methods ──
        public void Fail(){} // RVA: 0x7FFE87CA9720
        public void IsTrue(){} // RVA: 0x7FFE87CA98F0 | overloaded x2
        public void IsFalse(){} // RVA: 0x7FFE87CA9960
        public void AreEqual(){} // RVA: 0x7FFE87CA9D60 | overloaded x5
        public void IsNull(){} // RVA: 0x7FFE87CA9B40 | overloaded x3
        public void IsNotNull(){} // RVA: 0x7FFE87CA9C50 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87CA9E50
    }

    public class AssertionException : Exception
    {
        public string m_UserMessage; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87CA9E90
        public void get_Message(){} // RVA: 0x7FFE87CA9F60
    }

    public class AssertionMessageUtil : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7FFE87CAA0D0 | overloaded x2
        public void GetEqualityMessage(){} // RVA: 0x7FFE87CAA370
        public void NullFailureMessage(){} // RVA: 0x7FFE87CAA5C0
        public void BooleanFailureMessage(){} // RVA: 0x7FFE87CAA760
    }

}