// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 4
// Methods: 17

namespace ThirdParty.Other.SteamAudio
{
    public class UnityAudioEngineAmbisonicSource : AudioEngineAmbisonicSource
    {
        public UnityEngine.AudioSource mAudioSource; // 0x10

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC8C323E0
        public void UpdateParameters(){} // RVA: 0x7FFAC8C32490
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityAudioEngineSource : AudioEngineSource
    {
        public UnityEngine.AudioSource mAudioSource; // 0x10
        public SteamAudio.SteamAudioSource mSteamAudioSource; // 0x18
        public int mHandle; // 0x20
        public int mPlayCounter; // 0x24
        public bool mWasPlaying; // 0x28

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC8C325A0
        public void Destroy(){} // RVA: 0x7FFAC8C32810
        public void UpdateParameters(){} // RVA: 0x7FFAC8C32950
        public void .ctor(){} // RVA: 0x7FFAC5875C30
    }

    public class UnityAudioEngineState : AudioEngineState
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC8C338C0
        public void Destroy(){} // RVA: 0x7FFAC8C17870
        public void SetHRTF(){} // RVA: 0x7FFAC8C33A30
        public void SetPerspectiveCorrection(){} // RVA: 0x7FFAC8C33A40
        public void SetReverbSource(){} // RVA: 0x7FFAC8C33A90
        public void SetHRTFDisabled(){} // RVA: 0x7FFAC8C33B20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityAudioEngineStateHelpers : AudioEngineStateHelpers
    {
        // ── Methods ──
        public void GetListenerTransform(){} // RVA: 0x7FFAC8C33BA0
        public void GetAudioSettings(){} // RVA: 0x7FFAC8C33CD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}