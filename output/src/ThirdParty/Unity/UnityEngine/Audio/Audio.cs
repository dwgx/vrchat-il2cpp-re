// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Audio
// Classes: 6
// Methods: 44

namespace ThirdParty.Unity.UnityEngine.Audio
{
    public class AudioClipPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C6AA60
        public void CreateHandle(){} // RVA: 0x7FFD54C6AE00
        public void .ctor(){} // RVA: 0x7FFD54C6AF80
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C54A80
        public void op_Explicit(){} // RVA: 0x7FFD54C6B070
        public void Equals(){} // RVA: 0x7FFD54C6B100
        public void SetVolume(){} // RVA: 0x7FFD54C6B1C0
        public void SetStereoPan(){} // RVA: 0x7FFD54C6B2C0
        public void SetSpatialBlend(){} // RVA: 0x7FFD54C6B3C0
        public void Seek(){} // RVA: 0x7FFD54C6B4C0
        public void SetVolumeInternal(){} // RVA: 0x7FFD54C6B6B0
        public void SetStereoPanInternal(){} // RVA: 0x7FFD54C6B710
        public void SetSpatialBlendInternal(){} // RVA: 0x7FFD54C6B770
        public void SetStartDelayInternal(){} // RVA: 0x7FFD54C6B7D0
        public void SetPauseDelayInternal(){} // RVA: 0x7FFD54C6B830
        public void InternalCreateAudioClipPlayable(){} // RVA: 0x7FFD54C6B890
    }

    public class AudioMixer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C6B910
        public void TransitionToSnapshot(){} // RVA: 0x7FFD54C6B960
        public void TransitionToSnapshotInternal(){} // RVA: 0x7FFD54C6BD60
        public void SetFloat(){} // RVA: 0x7FFD54C6BDD0
        public void GetFloat(){} // RVA: 0x7FFD54C6BE40
    }

    public class AudioMixerGroup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C6BEB0
    }

    public class AudioMixerPlayable : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C6BF00
        public void CreateHandle(){} // RVA: 0x7FFD54C6BF70
        public void .ctor(){} // RVA: 0x7FFD54C6C180
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C54A80
        public void Equals(){} // RVA: 0x7FFD54C6C270
        public void CreateAudioMixerPlayableInternal(){} // RVA: 0x7FFD54C6C330
    }

    public class AudioMixerSnapshot : Object
    {
        public object audioMixer;

        // ── Methods ──
        public void get_audioMixer(){} // RVA: 0x7FFD54C6C3A0
        public void TransitionTo(){} // RVA: 0x7FFD54C6C3F0
    }

    public class AudioPlayableOutput : ValueType
    {
        public object Null;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54C6C820
        public void .ctor(){} // RVA: 0x7FFD54C6C9E0
        public void get_Null(){} // RVA: 0x7FFD54C6CAD0
        public void GetHandle(){} // RVA: 0x7FFD51CFD430
        public void op_Implicit(){} // RVA: 0x7FFD54C54A80
        public void op_Explicit(){} // RVA: 0x7FFD54C6CB90
        public void GetTarget(){} // RVA: 0x7FFD54C6CC20
        public void SetTarget(){} // RVA: 0x7FFD54C6CC70
        public void SetEvaluateOnSeek(){} // RVA: 0x7FFD54C6CCD0
        public void InternalGetTarget(){} // RVA: 0x7FFD54C6CC20
        public void InternalSetTarget(){} // RVA: 0x7FFD54C6CC70
        public void InternalSetEvaluateOnSeek(){} // RVA: 0x7FFD54C6CCD0
    }

}