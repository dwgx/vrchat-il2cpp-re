// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Windows.Speech
// Classes: 5
// Methods: 9

namespace ThirdParty.Unity.UnityEngine.Windows.Speech
{
    public class DictationRecognizer : Object
    {
        public UIntPtr m_Recognizer; // 0x10
        public DictationHypothesisDelegate DictationHypothesis; // 0x18
        public DictationResultDelegate DictationResult; // 0x20
        public DictationCompletedDelegate DictationComplete; // 0x28
        public DictationErrorHandler DictationError; // 0x30

        // ── Methods ──
        public void DictationRecognizer_InvokeHypothesisGeneratedEvent(){} // RVA: 0x7FFAC340E9F0
        public void DictationRecognizer_InvokeResultGeneratedEvent(){} // RVA: 0x7FFAC774A710
        public void DictationRecognizer_InvokeCompletedEvent(){} // RVA: 0x7FFAC3539CE0
        public void DictationRecognizer_InvokeErrorEvent(){} // RVA: 0x7FFAC98DCAD0
    }

    public class PhraseRecognitionSystem : Object
    {
        public ErrorDelegate OnError;
        public StatusDelegate OnStatusChanged; // 0x8

        // ── Methods ──
        public void PhraseRecognitionSystem_InvokeErrorEvent(){} // RVA: 0x7FFAC98DC670
        public void PhraseRecognitionSystem_InvokeStatusChangedEvent(){} // RVA: 0x7FFAC98DC6D0
    }

    public class PhraseRecognizedEventArgs : ValueType
    {
        public 0x6B181458 confidence; // 0x10
        public UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings; // 0x18
        public string text; // 0x20
        public System.DateTime phraseStartTime; // 0x28
        public System.TimeSpan phraseDuration; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98DCAF0
    }

    public class PhraseRecognizer : Object
    {
        public UIntPtr m_Recognizer; // 0x10
        public PhraseRecognizedDelegate OnPhraseRecognized; // 0x18

        // ── Methods ──
        public void InvokePhraseRecognizedEvent(){} // RVA: 0x7FFAC98DC730
        public void MarshalSemanticMeaning(){} // RVA: 0x7FFAC98DC870
    }

    public class SemanticMeaning : ValueType
    {
        public string key; // 0x10
        public string[] values; // 0x18
    }

}