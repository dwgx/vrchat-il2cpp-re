// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Windows.Speech
// Classes: 5
// Methods: 9

namespace ThirdParty.Unity.UnityEngine.Windows.Speech
{
    public class DictationRecognizer : Object
    {
        // ── Methods ──
        public void DictationRecognizer_InvokeHypothesisGeneratedEvent(){} // RVA: 0x7FFE81706240
        public void DictationRecognizer_InvokeResultGeneratedEvent(){} // RVA: 0x7FFE85C32420
        public void DictationRecognizer_InvokeCompletedEvent(){} // RVA: 0x7FFE81CF80B0
        public void DictationRecognizer_InvokeErrorEvent(){} // RVA: 0x7FFE87C85200
    }

    public class PhraseRecognitionSystem : Object
    {
        // ── Methods ──
        public void PhraseRecognitionSystem_InvokeErrorEvent(){} // RVA: 0x7FFE87C84DA0
        public void PhraseRecognitionSystem_InvokeStatusChangedEvent(){} // RVA: 0x7FFE87C84E00
    }

    public class PhraseRecognizedEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C85220
    }

    public class PhraseRecognizer : Object
    {
        // ── Methods ──
        public void InvokePhraseRecognizedEvent(){} // RVA: 0x7FFE87C84E60
        public void MarshalSemanticMeaning(){} // RVA: 0x7FFE87C84FA0
    }

    public class SemanticMeaning : ValueType
    {
    }

}