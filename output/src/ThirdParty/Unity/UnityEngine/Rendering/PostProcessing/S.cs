// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 9
// Methods: 29

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class ScalableAO : Object
    {
        public object m_Result;
        public object m_PropertySheet;
        public object m_Settings;
        public object m_MRT;
        public object m_SampleCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7972050
        public void GetCameraFlags(){} // RVA: 0x12FC4A0
        public void DoLazyInitialization(){} // RVA: 0x79722B0
        public void Render(){} // RVA: 0x7972810
        public void RenderAfterOpaque(){} // RVA: 0x7973600
        public void RenderAmbientOnly(){} // RVA: 0x7973890
        public void CompositeAmbientOnly(){} // RVA: 0x7973930
        public void Release(){} // RVA: 0x7973BB0
    }

    public class ScreenSpaceReflectionPresetParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7973C60
    }

    public class ScreenSpaceReflectionResolutionParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7973CB0
    }

    public class ScreenSpaceReflections : PostProcessEffectSettings
    {
        public object preset;
        public object maximumIterationCount;
        public object resolution;
        public object thickness;
        public object maximumMarchDistance;
        public object distanceFade;
        public object vignette;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7973D00
        public void .ctor(){} // RVA: 0x7973EB0
    }

    public class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer`1
    {
        public object m_Resolve;
        public object m_History;
        public object m_MipIDs;
        public object m_Presets;

        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0xEF4110
        public void CheckRT(){} // RVA: 0x7974330
        public void Render(){} // RVA: 0x79746C0
        public void Release(){} // RVA: 0x7976030
        public void .ctor(){} // RVA: 0x7976150
    }

    public class ShaderIDs : Object
    {
        public object MainTex;
        public object Jitter;
        public object Sharpness;
        public object FinalBlendParameters;
        public object HistoryTex;
        public object SMAA_Flip;
        public object SMAA_Flop;
        public object AOParams;
        public object AOColor;
        public object OcclusionTexture1;
        public object OcclusionTexture2;
        public object SAOcclusionTexture;
        public object MSVOcclusionTexture;
        public object DepthCopy;
        public object LinearDepth;
        public object LowDepth1;
        public object LowDepth2;
        public object LowDepth3;
        public object LowDepth4;
        public object TiledDepth1;
        public object TiledDepth2;
        public object TiledDepth3;
        public object TiledDepth4;
        public object Occlusion1;
        public object Occlusion2;
        public object Occlusion3;
        public object Occlusion4;
        public object Combined1;
        public object Combined2;
        public object Combined3;
        public object SSRResolveTemp;
        public object Noise;
        public object Test;
        public object Resolve;
        public object History;
        public object ViewMatrix;
        public object InverseViewMatrix;
        public object ScreenSpaceProjectionMatrix;
        public object Params2;
        public object FogColor;
        public object FogParams;
        public object VelocityScale;
        public object MaxBlurRadius;
        public object RcpMaxBlurRadius;
        public object VelocityTex;
        public object Tile2RT;
        public object Tile4RT;
        public object Tile8RT;
        public object TileMaxOffs;
        public object TileMaxLoop;
        public object TileVRT;
        public object NeighborMaxTex;
        public object LoopCount;
        public object DepthOfFieldTemp;
        public object DepthOfFieldTex;
        public object Distance;
        public object LensCoeff;
        public object MaxCoC;
        public object RcpMaxCoC;
        public object RcpAspect;
        public object CoCTex;
        public object TaaParams;
        public object AutoExposureTex;
        public object HistogramBuffer;
        public object Params;
        public object ScaleOffsetRes;
        public object BloomTex;
        public object SampleScale;
        public object Threshold;
        public object ColorIntensity;
        public object Bloom_DirtTex;
        public object Bloom_Settings;
        public object Bloom_Color;
        public object Bloom_DirtTileOffset;
        public object ChromaticAberration_Amount;
        public object ChromaticAberration_SpectralLut;
        public object Distortion_CenterScale;
        public object Distortion_Amount;
        public object Lut2D;
        public object Lut3D;
        public object Lut3D_Params;
        public object Lut2D_Params;
        public object UserLut2D_Params;
        public object PostExposure;
        public object ColorBalance;
        public object ColorFilter;
        public object HueSatCon;
        public object Brightness;
        public object ChannelMixerRed;
        public object ChannelMixerGreen;
        public object ChannelMixerBlue;
        public object Lift;
        public object InvGamma;
        public object Gain;
        public object Curves;
        public object CustomToneCurve;
        public object ToeSegmentA;
        public object ToeSegmentB;
        public object MidSegmentA;
        public object MidSegmentB;
        public object ShoSegmentA;
        public object ShoSegmentB;
        public object Vignette_Color;
        public object Vignette_Center;
        public object Vignette_Settings;
        public object Vignette_Mask;
        public object Vignette_Opacity;
        public object Vignette_Mode;
        public object Grain_Params1;
        public object Grain_Params2;
        public object GrainTex;
        public object Phase;
        public object GrainNoiseParameters;
        public object LumaInAlpha;
        public object DitheringTex;
        public object Dithering_Coords;
        public object From;
        public object To;
        public object Interp;
        public object TargetColor;
        public object HalfResFinalCopy;
        public object WaveformSource;
        public object WaveformBuffer;
        public object VectorscopeBuffer;
        public object RenderViewportScaleFactor;
        public object UVTransform;
        public object DepthSlice;
        public object UVScaleOffset;
        public object PosScaleOffset;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x799B3E0
    }

    public class Spline : Object
    {
        public object k_Precision;
        public object k_Step;
        public object curve;
        public object m_Loop;
        public object m_ZeroValue;
        public object m_Range;
        public object m_InternalLoopingCurve;
        public object frameCount;
        public object cachedData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x799CD60
        public void Cache(){} // RVA: 0x799CE90
        public void Evaluate(){} // RVA: 0x799D380
        public void GetHashCode(){} // RVA: 0x799D420
    }

    public class SplineParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x797CEA0
        public void SetValue(){} // RVA: 0x797CEC0
        public void Interp(){} // RVA: 0x797CFD0
        public void .ctor(){} // RVA: 0x797D190
    }

    public class SubpixelMorphologicalAntialiasing : Object
    {
        public object quality;

        // ── Methods ──
        public void IsSupported(){} // RVA: 0x79764E0
        public void Render(){} // RVA: 0x7976530
        public void .ctor(){} // RVA: 0x7976CC0
    }

}