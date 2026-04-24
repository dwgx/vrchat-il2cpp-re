// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Windows.Speech
// Classes: 3
// Methods: 8

namespace ThirdParty.Unity.UnityEngine.Windows.Speech
{
    public class DictationRecognizer : Object
    {
        public object DictationResult; // 0x32CE3030

        // ── Original Methods ──
        public void DictationRecognizer_InvokeHypothesisGeneratedEvent(){} // RVA: 0x7ffaa8e3ad60
        public void DictationRecognizer_InvokeResultGeneratedEvent(){} // RVA: 0x7ffaad0bafe0
        public void DictationRecognizer_InvokeCompletedEvent(){} // RVA: 0x7ffaa8f670d0
        public void DictationRecognizer_InvokeErrorEvent(){} // RVA: 0x7ffaaf2fea30
    }

    public class PhraseRecognitionSystem : Object
    {
        // ── Original Methods ──
        public void PhraseRecognitionSystem_InvokeErrorEvent(){} // RVA: 0x7ffaaf2fe5d0
        public void PhraseRecognitionSystem_InvokeStatusChangedEvent(){} // RVA: 0x7ffaaf2fe630
    }

    public class PhraseRecognizer : Object
    {
        // ── Original Methods ──
        public void InvokePhraseRecognizedEvent(){} // RVA: 0x7ffaaf2fe690
        public void MarshalSemanticMeaning(){} // RVA: 0x7ffaaf2fe7d0
    }

}