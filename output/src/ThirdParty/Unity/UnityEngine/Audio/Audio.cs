// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Audio
// Classes: 8
// Methods: 47

namespace ThirdParty.Unity.UnityEngine.Audio
{
    public class AudioClipPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BF3000
        public void CreateHandle(){} // RVA: 0x7FFE87BF33A0
        public void .ctor(){} // RVA: 0x7FFE87BF3520
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDCFD0
        public void op_Explicit(){} // RVA: 0x7FFE87BF3610
        public void Equals(){} // RVA: 0x7FFE87BF36A0
        public void SetVolume(){} // RVA: 0x7FFE87BF3760
        public void SetStereoPan(){} // RVA: 0x7FFE87BF3860
        public void SetSpatialBlend(){} // RVA: 0x7FFE87BF3960
        public void Seek(){} // RVA: 0x7FFE87BF3A60
        public void SetVolumeInternal(){} // RVA: 0x7FFE87BF3C50
        public void SetStereoPanInternal(){} // RVA: 0x7FFE87BF3CB0
        public void SetSpatialBlendInternal(){} // RVA: 0x7FFE87BF3D10
        public void SetStartDelayInternal(){} // RVA: 0x7FFE87BF3D70
        public void SetPauseDelayInternal(){} // RVA: 0x7FFE87BF3DD0
        public void InternalCreateAudioClipPlayable(){} // RVA: 0x7FFE87BF3E30
    }

    public class AudioMixer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BF3EB0
        public void TransitionToSnapshot(){} // RVA: 0x7FFE87BF3F00
        public void TransitionToSnapshotInternal(){} // RVA: 0x7FFE87BF4300
        public void SetFloat(){} // RVA: 0x7FFE87BF4370
        public void GetFloat(){} // RVA: 0x7FFE87BF43E0
    }

    public class AudioMixerGroup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BF4450
    }

    public class AudioMixerPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BF44A0
        public void CreateHandle(){} // RVA: 0x7FFE87BF4510
        public void .ctor(){} // RVA: 0x7FFE87BF4720
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDCFD0
        public void Equals(){} // RVA: 0x7FFE87BF4810
        public void CreateAudioMixerPlayableInternal(){} // RVA: 0x7FFE87BF48D0
    }

    public class AudioMixerSnapshot : Object
    {
        // ── Methods ──
        public void get_audioMixer(){} // RVA: 0x7FFE87BF4940
        public void TransitionTo(){} // RVA: 0x7FFE87BF4990
    }

    public class AudioPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BF4A10
        public void CreateAudioOutput(){} // RVA: 0x7FFE87BF4BA0
    }

    public class AudioPlayableGraphExtensions : Object
    {
        // ── Methods ──
        public void InternalCreateAudioOutput(){} // RVA: 0x7FFE87BF4D50
    }

    public class AudioPlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87BF4DC0
        public void .ctor(){} // RVA: 0x7FFE87BF4F80
        public void get_Null(){} // RVA: 0x7FFE87BF5070
        public void GetHandle(){} // RVA: 0x7FFE84C3F960
        public void op_Implicit(){} // RVA: 0x7FFE87BDCFD0
        public void op_Explicit(){} // RVA: 0x7FFE87BF5130
        public void GetTarget(){} // RVA: 0x7FFE87BF51C0
        public void SetTarget(){} // RVA: 0x7FFE87BF5210
        public void SetEvaluateOnSeek(){} // RVA: 0x7FFE87BF5270
        public void InternalGetTarget(){} // RVA: 0x7FFE87BF51C0
        public void InternalSetTarget(){} // RVA: 0x7FFE87BF5210
        public void InternalSetEvaluateOnSeek(){} // RVA: 0x7FFE87BF5270
    }

}