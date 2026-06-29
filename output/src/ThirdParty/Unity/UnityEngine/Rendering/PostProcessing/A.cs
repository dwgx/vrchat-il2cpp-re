// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 6
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion : PostProcessEffectSettings
    {
        public object mode;
        public object intensity;
        public object color;
        public object ambientOnly;
        public object noiseFilterTolerance;
        public object blurTolerance;
        public object upsampleTolerance;
        public object thicknessModifier;
        public object zBias;
        public object directLightingStrength;
        public object radius;
        public object quality;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7959290
        public void .ctor(){} // RVA: 0x7959640
    }

    public class AmbientOcclusionModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79591F0
    }

    public class AmbientOcclusionQualityParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7959240
    }

    public class AmbientOcclusionRenderer : PostProcessEffectRenderer`1
    {
        public object m_Methods;

        // ── Methods ──
        public void Init(){} // RVA: 0x7959D60
        public void IsAmbientOnly(){} // RVA: 0x7959F20
        public void Get(){} // RVA: 0x7959FB0
        public void GetCameraFlags(){} // RVA: 0x795A020
        public void Release(){} // RVA: 0x795A0C0
        public void GetScalableAO(){} // RVA: 0x795A1E0
        public void GetMultiScaleVO(){} // RVA: 0x795A250
        public void Render(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x795A2C0
    }

    public class AutoExposure : PostProcessEffectSettings
    {
        public object filtering;
        public object minLuminance;
        public object maxLuminance;
        public object keyValue;
        public object eyeAdaptation;
        public object speedUp;
        public object speedDown;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x795A350
        public void .ctor(){} // RVA: 0x795A510
    }

    public class AutoExposureRenderer : PostProcessEffectRenderer`1
    {
        public object k_NumEyes;
        public object k_NumAutoExposureTextures;
        public object m_AutoExposurePool;
        public object m_AutoExposurePingPong;
        public object m_CurrentAutoExposure;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x795A980
        public void CheckTexture(){} // RVA: 0x795AC00
        public void Render(){} // RVA: 0x795AEE0
        public void Release(){} // RVA: 0x795C030
    }

}