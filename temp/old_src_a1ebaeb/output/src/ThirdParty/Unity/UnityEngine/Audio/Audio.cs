// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Audio
// Classes: 6
// Methods: 44

namespace ThirdParty.Unity.UnityEngine.Audio
{
    public class AudioClipPlayable : ValueType
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf26c9c0
        public void CreateHandle(){} // RVA: 0x7ffaaf26cd60
        public void .ctor(){} // RVA: 0x7ffaaf26cee0
        public void op_Implicit(){} // RVA: 0x7ffaaf2569e0
        public void op_Explicit(){} // RVA: 0x7ffaaf26cfd0
        public void Equals(){} // RVA: 0x7ffaaf26d060
        public void Seek(){} // RVA: 0x7ffaaf26d420
        public void InternalCreateAudioClipPlayable(){} // RVA: 0x7ffaaf26d7f0
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaac2eeee0
        public void SetVolume(){} // RVA: 0x7ffaaf26d120
        public void SetStereoPan(){} // RVA: 0x7ffaaf26d220
        public void SetSpatialBlend(){} // RVA: 0x7ffaaf26d320
        public void SetVolumeInternal(){} // RVA: 0x7ffaaf26d610
        public void SetStereoPanInternal(){} // RVA: 0x7ffaaf26d670
        public void SetSpatialBlendInternal(){} // RVA: 0x7ffaaf26d6d0
        public void SetStartDelayInternal(){} // RVA: 0x7ffaaf26d730
        public void SetPauseDelayInternal(){} // RVA: 0x7ffaaf26d790
    }

    public class AudioMixer : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf26d870
        public void TransitionToSnapshot(){} // RVA: 0x7ffaaf26d8c0
        public void TransitionToSnapshotInternal(){} // RVA: 0x7ffaaf26dcc0
        // ── Binary Analysis Named ──
        public void SetFloat(){} // RVA: 0x7ffaaf26dd30
        public void GetFloat(){} // RVA: 0x7ffaaf26dda0
    }

    public class AudioMixerGroup : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf26de10
    }

    public class AudioMixerPlayable : ValueType
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf26de60
        public void CreateHandle(){} // RVA: 0x7ffaaf26ded0
        public void .ctor(){} // RVA: 0x7ffaaf26e0e0
        public void op_Implicit(){} // RVA: 0x7ffaaf2569e0
        public void Equals(){} // RVA: 0x7ffaaf26e1d0
        public void CreateAudioMixerPlayableInternal(){} // RVA: 0x7ffaaf26e290
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaac2eeee0
    }

    public class AudioMixerSnapshot : Object
    {
        // ── Original Methods ──
        public void get_audioMixer(){} // RVA: 0x7ffaaf26e300
        public void TransitionTo(){} // RVA: 0x7ffaaf26e350
    }

    public class AudioPlayableOutput : ValueType
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaaf26e780
        public void .ctor(){} // RVA: 0x7ffaaf26e940
        public void get_Null(){} // RVA: 0x7ffaaf26ea30
        public void op_Implicit(){} // RVA: 0x7ffaaf2569e0
        public void op_Explicit(){} // RVA: 0x7ffaaf26eaf0
        public void InternalGetTarget(){} // RVA: 0x7ffaaf26eb80
        public void InternalSetTarget(){} // RVA: 0x7ffaaf26ebd0
        public void InternalSetEvaluateOnSeek(){} // RVA: 0x7ffaaf26ec30
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaac2eeee0
        public void GetTarget(){} // RVA: 0x7ffaaf26eb80
        public void SetTarget(){} // RVA: 0x7ffaaf26ebd0
        public void SetEvaluateOnSeek(){} // RVA: 0x7ffaaf26ec30
    }

}