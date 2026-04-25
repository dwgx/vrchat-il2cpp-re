// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Assertions
// Classes: 3
// Methods: 23

namespace ThirdParty.Unity.UnityEngine.Assertions
{
    public class Assert : Object
    {
        public bool raiseExceptions;

        // ── Methods ──
        public void Fail(){} // RVA: 0x7FFAC9900E80
        public void IsTrue(){} // RVA: 0x7FFAC9901050 | overloaded x2
        public void IsFalse(){} // RVA: 0x7FFAC99010C0
        public void AreEqual(){} // RVA: 0x7FFAC99014C0 | overloaded x5
        public void IsNull(){} // RVA: 0x7FFAC99012A0 | overloaded x3
        public void IsNotNull(){} // RVA: 0x7FFAC99013B0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC99015B0
    }

    public class AssertionException : Exception
    {
        public string Message; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99015F0
        public void get_Message(){} // RVA: 0x7FFAC99016C0
    }

    public class AssertionMessageUtil : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7FFAC9901830 | overloaded x2
        public void GetEqualityMessage(){} // RVA: 0x7FFAC9901AD0
        public void NullFailureMessage(){} // RVA: 0x7FFAC9901D20
        public void BooleanFailureMessage(){} // RVA: 0x7FFAC9901EC0
    }

}