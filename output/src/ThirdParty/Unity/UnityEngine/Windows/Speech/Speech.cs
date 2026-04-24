// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Windows.Speech
// Classes: 3
// Methods: 8

namespace ThirdParty.Unity.UnityEngine.Windows.Speech
{
    public class DictationRecognizer : Object
    {
        public UIntPtr m_Recognizer; // 0x10
        public Engine.IPlayerEditorConnectionNative.DisconnectAll DictationHypothesis; // 0x18
        public onNative.DisconnectAll DictationResult; // 0x20
        public ollInternal DictationComplete; // 0x28
        public ption DictationError; // 0x30

        // ── Methods ──
        public void DictationRecognizer_InvokeHypothesisGeneratedEvent(){} // RVA: 0x7FFD4E82E9F0
        public void DictationRecognizer_InvokeResultGeneratedEvent(){} // RVA: 0x7FFD52B6A710
        public void DictationRecognizer_InvokeCompletedEvent(){} // RVA: 0x7FFD4E959CE0
        public void DictationRecognizer_InvokeErrorEvent(){} // RVA: 0x7FFD54CFCAD0
    }

    public class PhraseRecognitionSystem : Object
    {
        public ative OnError;
        public ctAll OnStatusChanged; // 0x8

        // ── Methods ──
        public void PhraseRecognitionSystem_InvokeErrorEvent(){} // RVA: 0x7FFD54CFC670
        public void PhraseRecognitionSystem_InvokeStatusChangedEvent(){} // RVA: 0x7FFD54CFC6D0
    }

    public class PhraseRecognizer : Object
    {
        public UIntPtr m_Recognizer; // 0x10
        public nectionNative.TrySendMessage OnPhraseRecognized; // 0x18

        // ── Methods ──
        public void InvokePhraseRecognizedEvent(){} // RVA: 0x7FFD54CFC730
        public void MarshalSemanticMeaning(){} // RVA: 0x7FFD54CFC870
    }

}