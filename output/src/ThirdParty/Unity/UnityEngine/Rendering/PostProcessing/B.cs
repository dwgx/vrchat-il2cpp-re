// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 3
// Methods: 6

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class Bloom : PostProcessEffectSettings
    {
        public object intensity;
        public object threshold;
        public object softKnee;
        public object clamp;
        public object diffusion;
        public object anamorphicRatio;
        public object color;
        public object fastMode;
        public object dirtTexture;
        public object dirtIntensity;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x795C120
        public void .ctor(){} // RVA: 0x795C160
    }

    public class BloomRenderer : PostProcessEffectRenderer`1
    {
        public object m_Pyramid;
        public object k_MaxPyramidSize;

        // ── Methods ──
        public void Init(){} // RVA: 0x795C790
        public void Render(){} // RVA: 0x795C9E0
        public void .ctor(){} // RVA: 0x795DE00
    }

    public class BoolParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x797CA50
    }

}