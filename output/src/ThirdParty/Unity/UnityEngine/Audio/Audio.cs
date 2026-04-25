// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Audio
// Classes: 8
// Methods: 47

namespace ThirdParty.Unity.UnityEngine.Audio
{
    public class AudioClipPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC984AA60
        public void CreateHandle(){} // RVA: 0x7FFAC984AE00
        public void .ctor(){} // RVA: 0x7FFAC984AF80
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9834A80
        public void op_Explicit(){} // RVA: 0x7FFAC984B070
        public void Equals(){} // RVA: 0x7FFAC984B100
        public void SetVolume(){} // RVA: 0x7FFAC984B1C0
        public void SetStereoPan(){} // RVA: 0x7FFAC984B2C0
        public void SetSpatialBlend(){} // RVA: 0x7FFAC984B3C0
        public void Seek(){} // RVA: 0x7FFAC984B4C0
        public void SetVolumeInternal(){} // RVA: 0x7FFAC984B6B0
        public void SetStereoPanInternal(){} // RVA: 0x7FFAC984B710
        public void SetSpatialBlendInternal(){} // RVA: 0x7FFAC984B770
        public void SetStartDelayInternal(){} // RVA: 0x7FFAC984B7D0
        public void SetPauseDelayInternal(){} // RVA: 0x7FFAC984B830
        public void InternalCreateAudioClipPlayable(){} // RVA: 0x7FFAC984B890
    }

    public class AudioMixer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC984B910
        public void TransitionToSnapshot(){} // RVA: 0x7FFAC984B960
        public void TransitionToSnapshotInternal(){} // RVA: 0x7FFAC984BD60
        public void SetFloat(){} // RVA: 0x7FFAC984BDD0
        public void GetFloat(){} // RVA: 0x7FFAC984BE40
    }

    public class AudioMixerGroup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC984BEB0
    }

    public class AudioMixerPlayable : ValueType
    {
        public UnityEngine.Playables.PlayableHandle m_Handle; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC984BF00
        public void CreateHandle(){} // RVA: 0x7FFAC984BF70
        public void .ctor(){} // RVA: 0x7FFAC984C180
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9834A80
        public void Equals(){} // RVA: 0x7FFAC984C270
        public void CreateAudioMixerPlayableInternal(){} // RVA: 0x7FFAC984C330
    }

    public class AudioMixerSnapshot : Object
    {
        public object audioMixer;

        // ── Methods ──
        public void get_audioMixer(){} // RVA: 0x7FFAC984C3A0
        public void TransitionTo(){} // RVA: 0x7FFAC984C3F0
    }

    public class AudioPlayableBinding : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC984C470
        public void CreateAudioOutput(){} // RVA: 0x7FFAC984C600
    }

    public class AudioPlayableGraphExtensions : Object
    {
        // ── Methods ──
        public void InternalCreateAudioOutput(){} // RVA: 0x7FFAC984C7B0
    }

    public class AudioPlayableOutput : ValueType
    {
        public UnityEngine.Playables.PlayableOutputHandle Null; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC984C820
        public void .ctor(){} // RVA: 0x7FFAC984C9E0
        public void get_Null(){} // RVA: 0x7FFAC984CAD0
        public void GetHandle(){} // RVA: 0x7FFAC68DD430
        public void op_Implicit(){} // RVA: 0x7FFAC9834A80
        public void op_Explicit(){} // RVA: 0x7FFAC984CB90
        public void GetTarget(){} // RVA: 0x7FFAC984CC20
        public void SetTarget(){} // RVA: 0x7FFAC984CC70
        public void SetEvaluateOnSeek(){} // RVA: 0x7FFAC984CCD0
        public void InternalGetTarget(){} // RVA: 0x7FFAC984CC20
        public void InternalSetTarget(){} // RVA: 0x7FFAC984CC70
        public void InternalSetEvaluateOnSeek(){} // RVA: 0x7FFAC984CCD0
    }

}