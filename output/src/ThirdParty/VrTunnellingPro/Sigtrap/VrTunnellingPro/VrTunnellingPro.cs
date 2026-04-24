// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.VrTunnellingPro.Sigtrap.VrTunnellingPro
// Classes: 3
// Methods: 101

namespace ThirdParty.VrTunnellingPro.Sigtrap.VrTunnellingPro
{
    public class TunnellingPreset : TunnellingPresetBase
    {
        public object effectOverlay;
        public object overrideEffectOverlay;
        public object backgroundMode;
        public object overrideBackgroundMode;
        public object cageDownsample;
        public object overrideCageDownsample;
        public object cageAntiAliasing;
        public object overrideCageAntiAliasing;
        public object cageUpdateEveryFrame;
        public object overrideCageUpdateEveryFrame;
        public object cageFogDensity;
        public object overrideCageFogDensity;
        public object cageFogPower;
        public object overrideCageFogPower;
        public object cageFogBlend;
        public object overrideCageFogBlend;
        public object maskMode;
        public object overrideMaskMode;
        public object blurDownsample;
        public object overrideBlurDownsample;
        public object blurDistance;
        public object overrideBlurDistance;
        public object blurPasses;
        public object overrideBlurPasses;
        public object blurSamples;
        public object overrideBlurSamples;
        public object counterVelocityMode;
        public object overrideCounterVelocityMode;
        public object counterVelocityResetDistance;
        public object overrideCounterVelocityResetDistance;
        public object counterVelocityResetTime;
        public object overrideCounterVelocityResetTime;
        public object counterVelocityStrength;
        public object overrideCounterVelocityStrength;
        public object counterVelocityPerAxis;
        public object overrideCounterVelocityPerAxis;
        public object irisZRejection;
        public object overrideIrisZRejection;

        // ── Methods ──
        public void get_overrideCageDownsample(){} // RVA: 0x7FFD54026690
        public void get_counterVelocityResetTime(){} // RVA: 0x7FFD540266A0
        public void get_overrideMaskMode(){} // RVA: 0x7FFD540266B0
        public void get_overrideCounterVelocityStrength(){} // RVA: 0x7FFD540266C0
        public void get_overrideEffectOverlay(){} // RVA: 0x7FFD53D5FD70
        public void set_overrideEffectOverlay(){} // RVA: 0x7FFD540266D0
        public void get_cageDownsample(){} // RVA: 0x7FFD4E55B720
        public void get_overrideCageFogBlend(){} // RVA: 0x7FFD540266E0
        public void set_overrideCageFogBlend(){} // RVA: 0x7FFD4E752010
        public void get_blurSamples(){} // RVA: 0x7FFD4F9B9E70
        public void get_overrideCageUpdateEveryFrame(){} // RVA: 0x7FFD540266F0
        public void get_effectOverlay(){} // RVA: 0x7FFD4F29CCE0
        public void get_overrideBlurSamples(){} // RVA: 0x7FFD54026700
        public void GetVideoHeight(){} // RVA: 0x7FFD4FBF5FE0
        public void get_overrideCounterVelocityMode(){} // RVA: 0x7FFD54026710
        public void get_overrideCounterVelocityResetDistance(){} // RVA: 0x7FFD540266D0
        public void get_blurDownsample(){} // RVA: 0x7FFD514A55D0
        public void get_overrideCageFogDensity(){} // RVA: 0x7FFD54026720
        public void get_irisZRejection(){} // RVA: 0x7FFD54026730
        public void get_overrideBackgroundMode(){} // RVA: 0x7FFD54026740
        public void get_overrideCounterVelocityPerAxis(){} // RVA: 0x7FFD54026750
        public void get_cageUpdateEveryFrame(){} // RVA: 0x7FFD4E752010
        public void get_counterVelocityResetDistance(){} // RVA: 0x7FFD54026760
        public void get_overrideBlurDistance(){} // RVA: 0x7FFD54026770
        public void get_cageFogBlend(){} // RVA: 0x7FFD4E7F0800
        public void get_overrideCageAntiAliasing(){} // RVA: 0x7FFD54026780
        public void get_cageAntiAliasing(){} // RVA: 0x7FFD4EA61480
        public void get_maskMode(){} // RVA: 0x7FFD4FBF5FE0
        public void .ctor(){} // RVA: 0x7FFD54026790
        public void get_blurPasses(){} // RVA: 0x7FFD540268C0
        public void set_blurPasses(){} // RVA: 0x7FFD4E55B720
        public void get_counterVelocityPerAxis(){} // RVA: 0x7FFD540268D0
        public void get_overrideIrisZRejection(){} // RVA: 0x7FFD540268F0
        public void get_cageFogPower(){} // RVA: 0x7FFD4FBF6710
        public void get_overrideBlurDownsample(){} // RVA: 0x7FFD54026900
        public void get_cageFogDensity(){} // RVA: 0x7FFD53CE71D0
        public void get_overrideCounterVelocityResetTime(){} // RVA: 0x7FFD54026910
        public void get_backgroundMode(){} // RVA: 0x7FFD4F73B350
        public void set_backgroundMode(){} // RVA: 0x7FFD54026920
        public void set_overrideBlurPasses(){} // RVA: 0x7FFD540266F0
        public void get_overrideBlurPasses(){} // RVA: 0x7FFD54026940
        public void get_counterVelocityStrength(){} // RVA: 0x7FFD54026950
        public void get_counterVelocityMode(){} // RVA: 0x7FFD4ED671E0
        public void get_overrideCageFogPower(){} // RVA: 0x7FFD54026960
        public void get_blurDistance(){} // RVA: 0x7FFD54026970
    }

    public class TunnellingPresetBase : ScriptableObject
    {
        public object overrideAll;
        public object effectCoverage;
        public object overrideEffectCoverage;
        public object effectColor;
        public object overrideEffectColor;
        public object effectFeather;
        public object overrideEffectFeather;
        public object applyColorToBackground;
        public object overrideApplyColorToBackground;
        public object skybox;
        public object overrideSkybox;
        public object angularVelocity;
        public object overrideAngularVelocity;
        public object acceleration;
        public object overrideAcceleration;
        public object velocity;
        public object overrideVelocity;
        public object useCounterMotion;
        public object overrideUseCounterMotion;
        public object counterRotationStrength;
        public object overrideCounterRotationStrength;
        public object counterRotationPerAxis;
        public object overrideCounterRotationPerAxis;
        public object useArtificialTilt;
        public object overrideUseArtificialTilt;
        public object framerateDivision;
        public object overrideFramerateDivision;
        public object divideTranslation;
        public object overrideDivideTranslation;
        public object divideRotation;
        public object overrideDividerotation;
        public object forceVignetteMode;
        public object overrideForceVignetteMode;
        public object forceVignetteValue;
        public object overrideForceVignetteValue;

        // ── Methods ──
        public void get_overrideAll(){} // RVA: 0x7FFD4E35C4E0
        public void get_effectCoverage(){} // RVA: 0x7FFD4E40E570
        public void get_overrideEffectCoverage(){} // RVA: 0x7FFD54026980
        public void get_effectColor(){} // RVA: 0x7FFD54026990
        public void get_overrideEffectColor(){} // RVA: 0x7FFD540269A0
        public void get_effectFeather(){} // RVA: 0x7FFD4EB36E90
        public void get_overrideEffectFeather(){} // RVA: 0x7FFD540269B0
        public void get_applyColorToBackground(){} // RVA: 0x7FFD4F3907D0
        public void get_overrideApplyColorToBackground(){} // RVA: 0x7FFD540269C0
        public void get_skybox(){} // RVA: 0x7FFD4E3BE740
        public void get_overrideSkybox(){} // RVA: 0x7FFD540269D0
        public void get_angularVelocity(){} // RVA: 0x7FFD4E3E20E0
        public void get_overrideAngularVelocity(){} // RVA: 0x7FFD540269E0
        public void get_acceleration(){} // RVA: 0x7FFD4E3DF370
        public void get_overrideAcceleration(){} // RVA: 0x7FFD540269F0
        public void get_velocity(){} // RVA: 0x7FFD4E409590
        public void get_overrideVelocity(){} // RVA: 0x7FFD54026A00
        public void get_useCounterMotion(){} // RVA: 0x7FFD4E7EC650
        public void get_overrideUseCounterMotion(){} // RVA: 0x7FFD54026A10
        public void get_counterRotationStrength(){} // RVA: 0x7FFD4E36A100
        public void get_overrideCounterRotationStrength(){} // RVA: 0x7FFD54026A20
        public void get_counterRotationPerAxis(){} // RVA: 0x7FFD54026A30
        public void get_overrideCounterRotationPerAxis(){} // RVA: 0x7FFD54026A50
        public void get_useArtificialTilt(){} // RVA: 0x7FFD4FC82190
        public void get_overrideUseArtificialTilt(){} // RVA: 0x7FFD54026A60
        public void get_framerateDivision(){} // RVA: 0x7FFD4E640670
        public void get_overrideFramerateDivision(){} // RVA: 0x7FFD54026A70
        public void get_divideTranslation(){} // RVA: 0x7FFD4E7BC020
        public void get_overrideDivideTranslation(){} // RVA: 0x7FFD54026A80
        public void get_divideRotation(){} // RVA: 0x7FFD4FA8DD50
        public void get_overrideDividerotation(){} // RVA: 0x7FFD54026A90
        public void get_forceVignetteMode(){} // RVA: 0x7FFD4FCBE510
        public void get_overrideForceVignetteMode(){} // RVA: 0x7FFD54026AA0
        public void get_forceVignetteValue(){} // RVA: 0x7FFD54026AB0
        public void get_overrideForceVignetteValue(){} // RVA: 0x7FFD54026AC0
        public void .ctor(){} // RVA: 0x7FFD54026AD0
    }

    public class TunnellingPresetMobile : TunnellingPresetBase
    {
        public object drawSkybox;
        public object overrideDrawSkybox;
        public object drawBeforeTransparent;
        public object overrideDrawBeforeTransparent;
        public object useMask;
        public object overrideUseMask;
        public object stencilReference;
        public object overrideStencilReference;
        public object stencilMask;
        public object overrideStencilMask;
        public object stencilBias;
        public object overrideStencilBias;

        // ── Methods ──
        public void get_overrideUseMask(){} // RVA: 0x7FFD53F30340
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFD53F30340
        public void get_overrideStencilBias(){} // RVA: 0x7FFD4FB58E90
        public void get_IsSystemGestureInProgress(){} // RVA: 0x7FFD53D5FD50
        public void get_stencilReference(){} // RVA: 0x7FFD4F73B350
        public void get_overrideStencilMask(){} // RVA: 0x7FFD53CFEB50
        public void get_IsTracked(){} // RVA: 0x7FFD53D5FD30
        public void get_drawSkybox(){} // RVA: 0x7FFD4F6071E0
        public void get_LogCaptureStartStop(){} // RVA: 0x7FFD4FB58E90
        public void get_drawBeforeTransparent(){} // RVA: 0x7FFD53D5FD30
        public void .ctor(){} // RVA: 0x7FFD54026BB0
        public void get_stencilBias(){} // RVA: 0x7FFD4EA61480
        public void get_stencilMask(){} // RVA: 0x7FFD4E55B720
        public void get_overrideDrawSkybox(){} // RVA: 0x7FFD54026C00
        public void get_overrideDrawBeforeTransparent(){} // RVA: 0x7FFD53D5FD50
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFD53CE71A0
        public void get_IsPointerPoseValid(){} // RVA: 0x7FFD53D5FD70
        public void get_overrideStencilReference(){} // RVA: 0x7FFD53CE71A0
        public void get_useMask(){} // RVA: 0x7FFD53D5FD70
        public void set_useMask(){} // RVA: 0x7FFD53D5FD50
    }

}