// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks
// Classes: 2
// Methods: 10

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks
{
    public class WhenEachEnumerable`1 : Object
    {
        public object source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void GetAsyncEnumerator(){} // RVA: 0x881D60
    }

    public class WhenEachResult`1 : ValueType
    {
        public object _result;
        public object _exception;

        // ── Methods ──
        public void get_Result(){} // RVA: 0xA94080
        public void get_Exception(){} // RVA: 0x87C0A0
        public void get_IsCompletedSuccessfully(){} // RVA: 0x87D280
        public void get_IsFaulted(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void TryThrow(){} // RVA: 0x894290
        public void GetResult(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
    }

}