// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 17
// Methods: 858

namespace ThirdParty.Unity.UnityEngine
{
    public class ManagedStreamHelpers
    {
        // ── Methods ──
        public void ValidateLoadFromStream(){} // RVA: 0x7129AB0
        public void ManagedStreamRead(){} // RVA: 0x7129C20
        public void ManagedStreamSeek(){} // RVA: 0x7129D10
        public void ManagedStreamLength(){} // RVA: 0x7129DE0
    }

    public class MatchTargetWeightMask
    {
        public UnityEngine.Vector3 m_PositionXYZWeight; // 0x10
        public float m_RotationWeight; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x49C63E0
        public void get_positionXYZWeight(){} // RVA: 0x7079450
        public void set_positionXYZWeight(){} // RVA: 0x210E450
        public void get_rotationWeight(){} // RVA: 0x300D00
        public void set_rotationWeight(){} // RVA: 0x1F78380
    }

    public class Material
    {
        // ── Methods ──
        public void CreateWithShader(){} // RVA: 0x70E8D10
        public void CreateWithMaterial(){} // RVA: 0x70E8D70
        public void CreateWithString(){} // RVA: 0x70E8DD0
        public void .ctor(){} // RVA: 0x70E8F60 | overloaded x3
        public void get_shader(){} // RVA: 0x70E8FF0
        public void set_shader(){} // RVA: 0x70E9040
        public void get_color(){} // RVA: 0x70E90A0
        public void set_color(){} // RVA: 0x70E91C0
        public void get_mainTexture(){} // RVA: 0x70E92D0
        public void set_mainTexture(){} // RVA: 0x70E93C0
        public void get_mainTextureOffset(){} // RVA: 0x70E9470
        public void set_mainTextureOffset(){} // RVA: 0x70E9520
        public void get_mainTextureScale(){} // RVA: 0x70E9630
        public void set_mainTextureScale(){} // RVA: 0x70E96E0
        public void GetFirstPropertyNameIdByAttribute(){} // RVA: 0x70E97F0
        public void HasProperty(){} // RVA: 0x70E98B0 | overloaded x2
        public void HasFloatImpl(){} // RVA: 0x70E9950
        public void HasFloat(){} // RVA: 0x70E9950 | overloaded x2
        public void HasInt(){} // RVA: 0x70E9950 | overloaded x2
        public void HasIntImpl(){} // RVA: 0x70E9A50
        public void HasInteger(){} // RVA: 0x70E9A50 | overloaded x2
        public void HasTextureImpl(){} // RVA: 0x70E9B50
        public void HasTexture(){} // RVA: 0x70E9B50 | overloaded x2
        public void HasMatrixImpl(){} // RVA: 0x70E9C50
        public void HasMatrix(){} // RVA: 0x70E9C50 | overloaded x2
        public void HasVectorImpl(){} // RVA: 0x70E9D50
        public void HasVector(){} // RVA: 0x70E9D50 | overloaded x2
        public void HasColor(){} // RVA: 0x70E9D50 | overloaded x2
        public void HasBufferImpl(){} // RVA: 0x70E9E50
        public void HasBuffer(){} // RVA: 0x70E9E50 | overloaded x2
        public void HasConstantBufferImpl(){} // RVA: 0x70E9F50
        public void HasConstantBuffer(){} // RVA: 0x70E9F50 | overloaded x2
        public void get_renderQueue(){} // RVA: 0x70EA050
        public void set_renderQueue(){} // RVA: 0x70EA0A0
        public void EnableKeyword(){} // RVA: 0x70EA3B0 | overloaded x2
        public void DisableKeyword(){} // RVA: 0x70EA420 | overloaded x2
        public void IsKeywordEnabled(){} // RVA: 0x70EA510 | overloaded x2
        public void EnableLocalKeyword(){} // RVA: 0x70EA220
        public void DisableLocalKeyword(){} // RVA: 0x70EA280
        public void SetLocalKeyword(){} // RVA: 0x70EA2E0
        public void IsLocalKeywordEnabled(){} // RVA: 0x70EA350
        public void SetKeyword(){} // RVA: 0x70EA490
        public void GetEnabledKeywords(){} // RVA: 0x70EA580
        public void SetEnabledKeywords(){} // RVA: 0x70EA5D0
        public void get_enabledKeywords(){} // RVA: 0x70EA580
        public void set_enabledKeywords(){} // RVA: 0x70EA5D0
        public void get_globalIlluminationFlags(){} // RVA: 0x70EA630
        public void set_globalIlluminationFlags(){} // RVA: 0x70EA680
        public void get_doubleSidedGI(){} // RVA: 0x70EA6E0
        public void set_doubleSidedGI(){} // RVA: 0x70EA730
        public void get_enableInstancing(){} // RVA: 0x70EA790
        public void set_enableInstancing(){} // RVA: 0x70EA7E0
        public void get_passCount(){} // RVA: 0x70EA840
        public void SetShaderPassEnabled(){} // RVA: 0x70EA890
        public void GetShaderPassEnabled(){} // RVA: 0x70EA900
        public void GetPassName(){} // RVA: 0x70EA960
        public void FindPass(){} // RVA: 0x70EA9C0
        public void SetOverrideTag(){} // RVA: 0x70EAA20
        public void GetTagImpl(){} // RVA: 0x70EAA90
        public void GetTag(){} // RVA: 0x70EAB30 | overloaded x2
        public void Lerp(){} // RVA: 0x70EABA0
        public void SetPass(){} // RVA: 0x70EAC20
        public void CopyPropertiesFromMaterial(){} // RVA: 0x70EAC80
        public void CopyMatchingPropertiesFromMaterial(){} // RVA: 0x70EACE0
        public void GetShaderKeywords(){} // RVA: 0x70EAD40
        public void SetShaderKeywords(){} // RVA: 0x70EAD90
        public void get_shaderKeywords(){} // RVA: 0x70EAD40
        public void set_shaderKeywords(){} // RVA: 0x70EAD90
        public void GetPropertyNamesImpl(){} // RVA: 0x70EADF0
        public void ComputeCRC(){} // RVA: 0x70EAE50
        public void GetTexturePropertyNames(){} // RVA: 0x70EB000 | overloaded x2
        public void GetTexturePropertyNameIDs(){} // RVA: 0x70EB0B0 | overloaded x2
        public void GetTexturePropertyNamesInternal(){} // RVA: 0x70EAF40
        public void GetTexturePropertyNameIDsInternal(){} // RVA: 0x70EAFA0
        public void SetIntImpl(){} // RVA: 0x70EB160
        public void SetFloatImpl(){} // RVA: 0x70EB1D0
        public void SetColorImpl(){} // RVA: 0x70EB240
        public void SetMatrixImpl(){} // RVA: 0x70EB2B0
        public void SetTextureImpl(){} // RVA: 0x70EB320
        public void SetRenderTextureImpl(){} // RVA: 0x70EB390
        public void SetBufferImpl(){} // RVA: 0x70EB410
        public void SetGraphicsBufferImpl(){} // RVA: 0x70EB480
        public void GetIntImpl(){} // RVA: 0x70EB4F0
        public void GetFloatImpl(){} // RVA: 0x70EB550
        public void GetColorImpl(){} // RVA: 0x70EB5B0
        public void GetMatrixImpl(){} // RVA: 0x70EB630
        public void GetTextureImpl(){} // RVA: 0x70EB6C0
        public void SetFloatArrayImpl(){} // RVA: 0x70EB720
        public void SetVectorArrayImpl(){} // RVA: 0x70EB7A0
        public void SetColorArrayImpl(){} // RVA: 0x70EB820
        public void SetMatrixArrayImpl(){} // RVA: 0x70EB8A0
        public void GetFloatArrayImpl(){} // RVA: 0x70EB920
        public void GetVectorArrayImpl(){} // RVA: 0x70EB980
        public void GetColorArrayImpl(){} // RVA: 0x70EB9E0
        public void GetMatrixArrayImpl(){} // RVA: 0x70EBA40
        public void GetFloatArrayCountImpl(){} // RVA: 0x70EBAA0
        public void GetVectorArrayCountImpl(){} // RVA: 0x70EBB00
        public void GetColorArrayCountImpl(){} // RVA: 0x70EBB60
        public void GetMatrixArrayCountImpl(){} // RVA: 0x70EBBC0
        public void ExtractFloatArrayImpl(){} // RVA: 0x70EBC20
        public void ExtractVectorArrayImpl(){} // RVA: 0x70EBC90
        public void ExtractColorArrayImpl(){} // RVA: 0x70EBD00
        public void ExtractMatrixArrayImpl(){} // RVA: 0x70EBD70
        public void GetTextureScaleAndOffsetImpl(){} // RVA: 0x70EBDE0
        public void SetTextureOffsetImpl(){} // RVA: 0x70EBE60
        public void SetTextureScaleImpl(){} // RVA: 0x70EBED0
        public void SetFloatArray(){} // RVA: 0x70ED810 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x70EDC50 | overloaded x5
        public void SetColorArray(){} // RVA: 0x70EDA30 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x70EDE70 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x70EC540
        public void ExtractVectorArray(){} // RVA: 0x70EC740
        public void ExtractColorArray(){} // RVA: 0x70EC940
        public void ExtractMatrixArray(){} // RVA: 0x70ECB40
        public void SetInt(){} // RVA: 0x70ECE00 | overloaded x2
        public void SetFloat(){} // RVA: 0x70EB1D0 | overloaded x2
        public void SetInteger(){} // RVA: 0x70EB160 | overloaded x2
        public void SetColor(){} // RVA: 0x70ED090 | overloaded x2
        public void SetVector(){} // RVA: 0x70ED200 | overloaded x2
        public void SetMatrix(){} // RVA: 0x70ED390 | overloaded x2
        public void SetTexture(){} // RVA: 0x70ED560 | overloaded x4
        public void SetBuffer(){} // RVA: 0x70ED570 | overloaded x2
        public void GetInt(){} // RVA: 0x70EDF50 | overloaded x2
        public void GetFloat(){} // RVA: 0x70EB550 | overloaded x2
        public void GetInteger(){} // RVA: 0x70EB4F0 | overloaded x2
        public void GetColor(){} // RVA: 0x70EE1C0 | overloaded x2
        public void GetVector(){} // RVA: 0x70EE320 | overloaded x2
        public void GetMatrix(){} // RVA: 0x70EE4C0 | overloaded x2
        public void GetTexture(){} // RVA: 0x70EB6C0 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x70EEB20 | overloaded x4
        public void GetColorArray(){} // RVA: 0x70EEBB0 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x70EEC40 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x70EECD0 | overloaded x4
        public void SetTextureOffset(){} // RVA: 0x70EBE60 | overloaded x2
        public void SetTextureScale(){} // RVA: 0x70EBED0 | overloaded x2
        public void GetTextureOffset(){} // RVA: 0x70EEED0 | overloaded x2
        public void GetTextureScale(){} // RVA: 0x70EEFC0 | overloaded x2
        public void GetPropertyNames(){} // RVA: 0x70EADF0
        public void EnableLocalKeyword_Injected(){} // RVA: 0x70EF040
        public void DisableLocalKeyword_Injected(){} // RVA: 0x70EF0A0
        public void SetLocalKeyword_Injected(){} // RVA: 0x70EF100
        public void IsLocalKeywordEnabled_Injected(){} // RVA: 0x70EF170
        public void SetColorImpl_Injected(){} // RVA: 0x70EF1D0
        public void SetMatrixImpl_Injected(){} // RVA: 0x70EF240
        public void GetColorImpl_Injected(){} // RVA: 0x70EF2B0
        public void GetMatrixImpl_Injected(){} // RVA: 0x70EF320
        public void GetTextureScaleAndOffsetImpl_Injected(){} // RVA: 0x70EF390
        public void SetTextureOffsetImpl_Injected(){} // RVA: 0x70EF400
        public void SetTextureScaleImpl_Injected(){} // RVA: 0x70EF470
    }

    public class MaterialPropertyBlock
    {
        public UIntPtr Length; // 0x10

        // ── Methods ──
        public void GetIntImpl(){} // RVA: 0x70DDF00
        public void GetFloatImpl(){} // RVA: 0x70DDF60
        public void GetVectorImpl(){} // RVA: 0x70DDFC0
        public void GetColorImpl(){} // RVA: 0x70DE040
        public void GetMatrixImpl(){} // RVA: 0x70DE0C0
        public void GetTextureImpl(){} // RVA: 0x70DE150
        public void HasPropertyImpl(){} // RVA: 0x70DE1B0
        public void HasFloatImpl(){} // RVA: 0x70DE210
        public void HasIntImpl(){} // RVA: 0x70DE270
        public void HasTextureImpl(){} // RVA: 0x70DE2D0
        public void HasMatrixImpl(){} // RVA: 0x70DE330
        public void HasVectorImpl(){} // RVA: 0x70DE390
        public void HasBufferImpl(){} // RVA: 0x70DE3F0
        public void HasConstantBufferImpl(){} // RVA: 0x70DE450
        public void SetIntImpl(){} // RVA: 0x70DE4B0
        public void SetFloatImpl(){} // RVA: 0x70DE520
        public void SetVectorImpl(){} // RVA: 0x70DE590
        public void SetColorImpl(){} // RVA: 0x70DE600
        public void SetMatrixImpl(){} // RVA: 0x70DE670
        public void SetTextureImpl(){} // RVA: 0x70DE6E0
        public void SetRenderTextureImpl(){} // RVA: 0x70DE750
        public void SetBufferImpl(){} // RVA: 0x70DE7D0
        public void SetGraphicsBufferImpl(){} // RVA: 0x70DE840
        public void SetFloatArrayImpl(){} // RVA: 0x70DE8B0
        public void SetVectorArrayImpl(){} // RVA: 0x70DE930
        public void SetMatrixArrayImpl(){} // RVA: 0x70DE9B0
        public void GetFloatArrayImpl(){} // RVA: 0x70DEA30
        public void GetVectorArrayImpl(){} // RVA: 0x70DEA90
        public void GetMatrixArrayImpl(){} // RVA: 0x70DEAF0
        public void GetFloatArrayCountImpl(){} // RVA: 0x70DEB50
        public void GetVectorArrayCountImpl(){} // RVA: 0x70DEBB0
        public void GetMatrixArrayCountImpl(){} // RVA: 0x70DEC10
        public void ExtractFloatArrayImpl(){} // RVA: 0x70DEC70
        public void ExtractVectorArrayImpl(){} // RVA: 0x70DECE0
        public void ExtractMatrixArrayImpl(){} // RVA: 0x70DED50
        public void Internal_CopySHCoefficientArraysFrom(){} // RVA: 0x70DEDC0
        public void Internal_CopyProbeOcclusionArrayFrom(){} // RVA: 0x70DEE50
        public void CreateImpl(){} // RVA: 0x70DEEE0
        public void DestroyImpl(){} // RVA: 0x70DEF30
        public void get_isEmpty(){} // RVA: 0x70DEF80
        public void Clear(){} // RVA: 0x70DF030 | overloaded x2
        public void SetFloatArray(){} // RVA: 0x70E0690 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x70E08B0 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x70E0AD0 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x70DF510
        public void ExtractVectorArray(){} // RVA: 0x70DF710
        public void ExtractMatrixArray(){} // RVA: 0x70DF910
        public void .ctor(){} // RVA: 0x70DFB10
        public void Finalize(){} // RVA: 0x70DFB60
        public void Dispose(){} // RVA: 0x70DFC40
        public void SetInt(){} // RVA: 0x70DFDB0 | overloaded x2
        public void SetFloat(){} // RVA: 0x70DE520 | overloaded x2
        public void SetInteger(){} // RVA: 0x70DE4B0 | overloaded x2
        public void SetVector(){} // RVA: 0x70E0040 | overloaded x2
        public void SetColor(){} // RVA: 0x70E0170 | overloaded x2
        public void SetMatrix(){} // RVA: 0x70E02C0 | overloaded x2
        public void SetBuffer(){} // RVA: 0x70DE840 | overloaded x2
        public void SetTexture(){} // RVA: 0x70E0490 | overloaded x4
        public void HasProperty(){} // RVA: 0x70DE1B0 | overloaded x2
        public void HasInt(){} // RVA: 0x70DE210 | overloaded x2
        public void HasFloat(){} // RVA: 0x70DE210 | overloaded x2
        public void HasInteger(){} // RVA: 0x70DE270 | overloaded x2
        public void HasTexture(){} // RVA: 0x70DE2D0 | overloaded x2
        public void HasMatrix(){} // RVA: 0x70DE330 | overloaded x2
        public void HasVector(){} // RVA: 0x70DE390 | overloaded x2
        public void HasColor(){} // RVA: 0x70DE390 | overloaded x2
        public void HasBuffer(){} // RVA: 0x70DE3F0 | overloaded x2
        public void HasConstantBuffer(){} // RVA: 0x70DE450 | overloaded x2
        public void GetFloat(){} // RVA: 0x70DDF60 | overloaded x2
        public void GetInt(){} // RVA: 0x70E1150 | overloaded x2
        public void GetInteger(){} // RVA: 0x70DDF00 | overloaded x2
        public void GetVector(){} // RVA: 0x70E1320 | overloaded x2
        public void GetColor(){} // RVA: 0x70E1480 | overloaded x2
        public void GetMatrix(){} // RVA: 0x70E1620 | overloaded x2
        public void GetTexture(){} // RVA: 0x70DE150 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x70E1B60 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x70E1BF0 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x70E1C80 | overloaded x4
        public void CopySHCoefficientArraysFrom(){} // RVA: 0x70E1E60 | overloaded x4
        public void CopyProbeOcclusionArrayFrom(){} // RVA: 0x70E22A0 | overloaded x4
        public void GetVectorImpl_Injected(){} // RVA: 0x70E2510
        public void GetColorImpl_Injected(){} // RVA: 0x70E2580
        public void GetMatrixImpl_Injected(){} // RVA: 0x70E25F0
        public void SetVectorImpl_Injected(){} // RVA: 0x70E2660
        public void SetColorImpl_Injected(){} // RVA: 0x70E26D0
        public void SetMatrixImpl_Injected(){} // RVA: 0x70E2740
    }

    public class Mathf
    {
        // ── Methods ──
        public void ClosestPowerOfTwo(){} // RVA: 0x7118860
        public void IsPowerOfTwo(){} // RVA: 0x71188B0
        public void NextPowerOfTwo(){} // RVA: 0x7118900
        public void GammaToLinearSpace(){} // RVA: 0x7118950
        public void LinearToGammaSpace(){} // RVA: 0x71189B0
        public void CorrelatedColorTemperatureToRGB(){} // RVA: 0x7118A10
        public void FloatToHalf(){} // RVA: 0x7118A80
        public void HalfToFloat(){} // RVA: 0x7118AE0
        public void PerlinNoise(){} // RVA: 0x7118B30
        public void PerlinNoise1D(){} // RVA: 0x7118BA0
        public void Sin(){} // RVA: 0x7118C00
        public void Cos(){} // RVA: 0x7118C60
        public void Tan(){} // RVA: 0x7118CC0
        public void Asin(){} // RVA: 0x7118D20
        public void Acos(){} // RVA: 0x7118D80
        public void Atan(){} // RVA: 0x7118DE0
        public void Atan2(){} // RVA: 0x7118E40
        public void Sqrt(){} // RVA: 0x7118EB0
        public void Abs(){} // RVA: 0x7118F90 | overloaded x2
        public void Min(){} // RVA: 0x7119040 | overloaded x4
        public void Max(){} // RVA: 0x71190B0 | overloaded x4
        public void Pow(){} // RVA: 0x7119110
        public void Exp(){} // RVA: 0x7119190
        public void Log(){} // RVA: 0x7119270 | overloaded x2
        public void Log10(){} // RVA: 0x71192D0
        public void Ceil(){} // RVA: 0x7119330
        public void Floor(){} // RVA: 0x7119390
        public void Round(){} // RVA: 0x71193F0
        public void CeilToInt(){} // RVA: 0x7119450
        public void FloorToInt(){} // RVA: 0x71194B0
        public void RoundToInt(){} // RVA: 0x7119510
        public void Sign(){} // RVA: 0x7119570
        public void Clamp(){} // RVA: 0x301AE0 | overloaded x2
        public void Clamp01(){} // RVA: 0x301DC0
        public void Lerp(){} // RVA: 0x300F40
        public void LerpUnclamped(){} // RVA: 0x7119590
        public void LerpAngle(){} // RVA: 0x301160
        public void MoveTowards(){} // RVA: 0x301A60
        public void MoveTowardsAngle(){} // RVA: 0x71195B0
        public void SmoothStep(){} // RVA: 0xA11CB0
        public void Gamma(){} // RVA: 0x7119650
        public void Approximately(){} // RVA: 0x71196B0
        public void SmoothDamp(){} // RVA: 0x71197F0 | overloaded x3
        public void SmoothDampAngle(){} // RVA: 0x1A70810 | overloaded x3
        public void Repeat(){} // RVA: 0x301380
        public void PingPong(){} // RVA: 0xEA3530
        public void InverseLerp(){} // RVA: 0x300F00
        public void DeltaAngle(){} // RVA: 0x32A0F0
        public void ClampToFloat(){} // RVA: 0x7119AE0
        public void ClampToInt(){} // RVA: 0x7119B40
        public void ClampToUInt(){} // RVA: 0x7119B60
        public void GetNumberOfDecimalsForMinimumDifference(){} // RVA: 0x7119B80
        public void RoundBasedOnMinimumDifference(){} // RVA: 0x7119C20
        public void DiscardLeastSignificantDecimal(){} // RVA: 0x7119D50
        public void .cctor(){} // RVA: 0x7119DF0
        public void CorrelatedColorTemperatureToRGB_Injected(){} // RVA: 0x7119E70
    }

    public class Matrix4x4
    {
        public float m00; // 0x10
        public float m10; // 0x14
        public float m20; // 0x18
        public float m30; // 0x1C
        public float m01; // 0x20
        public float m11; // 0x24
        public float m21; // 0x28
        public float m31; // 0x2C
        public float m02; // 0x30
        public float m12; // 0x34
        public float m22; // 0x38

        // ── Methods ──
        public void GetRotation(){} // RVA: 0x7112320
        public void GetLossyScale(){} // RVA: 0x7112390
        public void IsIdentity(){} // RVA: 0x7112400
        public void GetDeterminant(){} // RVA: 0x7112450
        public void DecomposeProjection(){} // RVA: 0x71124A0
        public void get_rotation(){} // RVA: 0x7112510
        public void get_lossyScale(){} // RVA: 0x7112590
        public void get_isIdentity(){} // RVA: 0x7112400
        public void get_determinant(){} // RVA: 0x7112450
        public void get_decomposeProjection(){} // RVA: 0x7112620
        public void ValidTRS(){} // RVA: 0x71126B0
        public void Determinant(){} // RVA: 0x7112700
        public void TRS(){} // RVA: 0x7112750
        public void SetTRS(){} // RVA: 0x71127F0
        public void Inverse3DAffine(){} // RVA: 0x71128D0
        public void Inverse(){} // RVA: 0x7112930
        public void get_inverse(){} // RVA: 0x71129B0
        public void Transpose(){} // RVA: 0x7112A80
        public void get_transpose(){} // RVA: 0x7112B00
        public void Ortho(){} // RVA: 0x7112BD0
        public void Perspective(){} // RVA: 0x7112CA0
        public void LookAt(){} // RVA: 0x7112D50
        public void Frustum(){} // RVA: 0x7112EC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7113010
        public void get_Item(){} // RVA: 0x71130A0 | overloaded x2
        public void set_Item(){} // RVA: 0x7113200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x3477910
        public void Equals(){} // RVA: 0x2473470 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7113950 | overloaded x2
        public void op_Equality(){} // RVA: 0x7113A70
        public void op_Inequality(){} // RVA: 0x7113BB0
        public void GetColumn(){} // RVA: 0x7113C20
        public void GetRow(){} // RVA: 0x7113CF0
        public void GetPosition(){} // RVA: 0x7113DE0
        public void SetColumn(){} // RVA: 0x7113E00
        public void SetRow(){} // RVA: 0x7113E80
        public void MultiplyPoint(){} // RVA: 0x7113EF0
        public void MultiplyPoint3x4(){} // RVA: 0x7113FE0
        public void MultiplyVector(){} // RVA: 0x7114080
        public void TransformPlane(){} // RVA: 0x7114110
        public void Scale(){} // RVA: 0x71143C0
        public void Translate(){} // RVA: 0x7114460
        public void Rotate(){} // RVA: 0x7114500
        public void get_zero(){} // RVA: 0x71146B0
        public void get_identity(){} // RVA: 0x7114710
        public void ToString(){} // RVA: 0x7114790 | overloaded x3
        public void .cctor(){} // RVA: 0x7114DD0
        public void GetRotation_Injected(){} // RVA: 0x7114EF0
        public void GetLossyScale_Injected(){} // RVA: 0x7114F50
        public void IsIdentity_Injected(){} // RVA: 0x7112400
        public void GetDeterminant_Injected(){} // RVA: 0x7112450
        public void DecomposeProjection_Injected(){} // RVA: 0x7114FB0
        public void ValidTRS_Injected(){} // RVA: 0x71126B0
        public void TRS_Injected(){} // RVA: 0x7115010
        public void Inverse3DAffine_Injected(){} // RVA: 0x7115090
        public void Inverse_Injected(){} // RVA: 0x71150F0
        public void Transpose_Injected(){} // RVA: 0x7115150
        public void Ortho_Injected(){} // RVA: 0x71151B0
        public void Perspective_Injected(){} // RVA: 0x7115250
        public void LookAt_Injected(){} // RVA: 0x71152F0
        public void Frustum_Injected(){} // RVA: 0x7115370
    }

    public class Mesh
    {
        // ── Methods ──
        public void Internal_Create(){} // RVA: 0x70F4FA0
        public void .ctor(){} // RVA: 0x70F4FF0
        public void FromInstanceID(){} // RVA: 0x70F5080
        public void get_indexFormat(){} // RVA: 0x70F50D0
        public void set_indexFormat(){} // RVA: 0x70F5120
        public void SetIndexBufferParams(){} // RVA: 0x70F5180
        public void InternalSetIndexBufferData(){} // RVA: 0x70F51F0
        public void SetVertexBufferParamsFromArray(){} // RVA: 0x70F5280
        public void GetVertexAttributesAlloc(){} // RVA: 0x70F52F0
        public void GetVertexAttributesArray(){} // RVA: 0x70F5340
        public void GetVertexAttributesList(){} // RVA: 0x70F53A0
        public void GetVertexAttributeCountImpl(){} // RVA: 0x70F5400
        public void GetVertexAttribute(){} // RVA: 0x70F5450
        public void GetIndexStartImpl(){} // RVA: 0x70F54D0
        public void GetIndexCountImpl(){} // RVA: 0x70F5530
        public void GetTrianglesCountImpl(){} // RVA: 0x70F5590
        public void GetBaseVertexImpl(){} // RVA: 0x70F55F0
        public void GetTrianglesImpl(){} // RVA: 0x70F5650
        public void GetIndicesImpl(){} // RVA: 0x70F56C0
        public void SetIndicesImpl(){} // RVA: 0x70F5730
        public void GetTrianglesNonAllocImpl(){} // RVA: 0x70F57C0
        public void GetTrianglesNonAllocImpl16(){} // RVA: 0x70F5840
        public void GetIndicesNonAllocImpl(){} // RVA: 0x70F58C0
        public void GetIndicesNonAllocImpl16(){} // RVA: 0x70F5940
        public void PrintErrorCantAccessChannel(){} // RVA: 0x70F59C0
        public void HasVertexAttribute(){} // RVA: 0x70F5A20
        public void GetVertexAttributeDimension(){} // RVA: 0x70F5A80
        public void GetVertexAttributeFormat(){} // RVA: 0x70F5AE0
        public void GetVertexAttributeStream(){} // RVA: 0x70F5B40
        public void GetVertexAttributeOffset(){} // RVA: 0x70F5BA0
        public void SetArrayForChannelImpl(){} // RVA: 0x70F5C00
        public void SetNativeArrayForChannelImpl(){} // RVA: 0x70F5C80
        public void GetAllocArrayFromChannelImpl(){} // RVA: 0x70F5D00
        public void GetArrayFromChannelImpl(){} // RVA: 0x70F5D80
        public void get_vertexBufferCount(){} // RVA: 0x70F5E00
        public void GetVertexBufferStride(){} // RVA: 0x70F5E50
        public void get_blendShapeCount(){} // RVA: 0x70F5EB0
        public void ClearBlendShapes(){} // RVA: 0x70F5F00
        public void GetBlendShapeName(){} // RVA: 0x70F5F50
        public void GetBlendShapeIndex(){} // RVA: 0x70F5FB0
        public void GetBlendShapeFrameCount(){} // RVA: 0x70F6010
        public void GetBlendShapeFrameWeight(){} // RVA: 0x70F6070
        public void GetBlendShapeFrameVertices(){} // RVA: 0x70F60E0
        public void AddBlendShapeFrame(){} // RVA: 0x70F6160
        public void GetBlendShapeOffsetInternal(){} // RVA: 0x70F61F0
        public void HasBoneWeights(){} // RVA: 0x70F6270
        public void GetBoneWeightsImpl(){} // RVA: 0x70F62C0
        public void SetBoneWeightsImpl(){} // RVA: 0x70F6310
        public void GetBoneWeightBufferLayoutInternal(){} // RVA: 0x70F6370
        public void get_bindposeCount(){} // RVA: 0x70F63C0
        public void get_bindposes(){} // RVA: 0x70F6410
        public void set_bindposes(){} // RVA: 0x70F6460
        public void GetBoneWeightsNonAllocImpl(){} // RVA: 0x70F64C0
        public void GetBindposesNonAllocImpl(){} // RVA: 0x70F6520
        public void get_isReadable(){} // RVA: 0x70F6580
        public void get_canAccess(){} // RVA: 0x70F65D0
        public void get_vertexCount(){} // RVA: 0x70F6620
        public void get_subMeshCount(){} // RVA: 0x70F6670
        public void set_subMeshCount(){} // RVA: 0x70F66C0
        public void SetSubMesh(){} // RVA: 0x70F6720
        public void GetSubMesh(){} // RVA: 0x70F67A0
        public void SetAllSubMeshesAtOnceFromArray(){} // RVA: 0x70F6820
        public void get_bounds(){} // RVA: 0x70F68B0
        public void set_bounds(){} // RVA: 0x70F6920
        public void ClearImpl(){} // RVA: 0x70F6980
        public void RecalculateBoundsImpl(){} // RVA: 0x70F69E0
        public void RecalculateNormalsImpl(){} // RVA: 0x70F6A40
        public void RecalculateTangentsImpl(){} // RVA: 0x70F6AA0
        public void MarkDynamicImpl(){} // RVA: 0x70F6B00
        public void MarkModified(){} // RVA: 0x70F6B50
        public void DiscardReadableDataImpl(){} // RVA: 0x70F6BA0
        public void UploadMeshDataImpl(){} // RVA: 0x70F6BF0
        public void GetTopologyImpl(){} // RVA: 0x70F6C50
        public void RecalculateUVDistributionMetricImpl(){} // RVA: 0x70F6CB0
        public void RecalculateUVDistributionMetricsImpl(){} // RVA: 0x70F6D20
        public void GetUVDistributionMetric(){} // RVA: 0x70F6D80
        public void CombineMeshesImpl(){} // RVA: 0x70F6DE0
        public void OptimizeImpl(){} // RVA: 0x70F6E70
        public void OptimizeIndexBuffersImpl(){} // RVA: 0x70F6EC0
        public void OptimizeReorderVertexBufferImpl(){} // RVA: 0x70F6F10
        public void GetUVChannel(){} // RVA: 0x70F6F60
        public void DefaultDimensionForChannel(){} // RVA: 0x70F6FF0
        public void GetAllocArrayFromChannel(){} // RVA: 0x1BCC0 | overloaded x2
        public void SetSizedArrayForChannel(){} // RVA: 0x70F70A0
        public void SetSizedNativeArrayForChannel(){} // RVA: 0x70F7460
        public void SetArrayForChannel(){} // RVA: 0x283FA0 | overloaded x2
        public void SetListForChannel(){} // RVA: 0x283FA0 | overloaded x2
        public void GetListForChannel(){} // RVA: 0x283FA0 | overloaded x2
        public void get_vertices(){} // RVA: 0x70F7820
        public void set_vertices(){} // RVA: 0x70F7890
        public void get_normals(){} // RVA: 0x70F7920
        public void set_normals(){} // RVA: 0x70F79A0
        public void get_tangents(){} // RVA: 0x70F7A30
        public void set_tangents(){} // RVA: 0x70F7AB0
        public void get_uv(){} // RVA: 0x70F7B40
        public void set_uv(){} // RVA: 0x70F7BC0
        public void get_uv2(){} // RVA: 0x70F7C50
        public void set_uv2(){} // RVA: 0x70F7CD0
        public void get_uv3(){} // RVA: 0x70F7D60
        public void set_uv3(){} // RVA: 0x70F7DE0
        public void get_uv4(){} // RVA: 0x70F7E70
        public void set_uv4(){} // RVA: 0x70F7EF0
        public void get_uv5(){} // RVA: 0x70F7F80
        public void set_uv5(){} // RVA: 0x70F8000
        public void get_uv6(){} // RVA: 0x70F8090
        public void set_uv6(){} // RVA: 0x70F8110
        public void get_uv7(){} // RVA: 0x70F81A0
        public void set_uv7(){} // RVA: 0x70F8220
        public void get_uv8(){} // RVA: 0x70F82B0
        public void set_uv8(){} // RVA: 0x70F8330
        public void get_colors(){} // RVA: 0x70F83C0
        public void set_colors(){} // RVA: 0x70F8440
        public void get_colors32(){} // RVA: 0x70F84D0
        public void set_colors32(){} // RVA: 0x70F8530
        public void GetVertices(){} // RVA: 0x70F85C0
        public void SetVertices(){} // RVA: 0x283FA0 | overloaded x9
        public void GetNormals(){} // RVA: 0x70F8A00
        public void SetNormals(){} // RVA: 0x283FA0 | overloaded x9
        public void GetTangents(){} // RVA: 0x70F8E60
        public void SetTangents(){} // RVA: 0x70F9240 | overloaded x6
        public void GetColors(){} // RVA: 0x70F9740 | overloaded x2
        public void SetColors(){} // RVA: 0x70F9B30 | overloaded x12
        public void SetUvsImpl(){} // RVA: 0x70FA2E0 | overloaded x2
        public void SetUVs(){} // RVA: 0x283FA0 | overloaded x21
        public void GetUVsImpl(){} // RVA: 0x283FA0
        public void GetUVs(){} // RVA: 0x70FA9F0 | overloaded x3
        public void get_vertexAttributeCount(){} // RVA: 0x70F5400
        public void GetVertexAttributes(){} // RVA: 0x70F53A0 | overloaded x3
        public void SetVertexBufferParams(){} // RVA: 0x70F5280
        public void GetBlendShapeBufferRange(){} // RVA: 0x70FAC30
        public void PrintErrorCantAccessIndices(){} // RVA: 0x70FAD70
        public void CheckCanAccessSubmesh(){} // RVA: 0x70FAE30
        public void CheckCanAccessSubmeshTriangles(){} // RVA: 0x70FB000
        public void CheckCanAccessSubmeshIndices(){} // RVA: 0x70FB010
        public void get_triangles(){} // RVA: 0x70FB020
        public void set_triangles(){} // RVA: 0x70FB100
        public void GetTriangles(){} // RVA: 0x70FB490 | overloaded x5
        public void GetIndices(){} // RVA: 0x70FB960 | overloaded x5
        public void SetIndexBufferData(){} // RVA: 0x283FA0
        public void GetIndexStart(){} // RVA: 0x70FBB40
        public void GetIndexCount(){} // RVA: 0x70FBC40
        public void GetBaseVertex(){} // RVA: 0x70FBD40
        public void CheckIndicesArrayRange(){} // RVA: 0x70FBE40
        public void SetTrianglesImpl(){} // RVA: 0x70FC0B0
        public void SetTriangles(){} // RVA: 0x70FC980 | overloaded x12
        public void SetIndices(){} // RVA: 0x70FD1B0 | overloaded x10
        public void SetSubMeshes(){} // RVA: 0x70FD760 | overloaded x4
        public void GetBindposes(){} // RVA: 0x70FD800
        public void GetBoneWeights(){} // RVA: 0x70FD950
        public void get_boneWeights(){} // RVA: 0x70F62C0
        public void set_boneWeights(){} // RVA: 0x70F6310
        public void get_skinWeightBufferLayout(){} // RVA: 0x70F6370
        public void Clear(){} // RVA: 0x70FDC80 | overloaded x2
        public void RecalculateBounds(){} // RVA: 0x70FDD10 | overloaded x2
        public void RecalculateNormals(){} // RVA: 0x70FDE70 | overloaded x2
        public void RecalculateTangents(){} // RVA: 0x70FDFD0 | overloaded x2
        public void RecalculateUVDistributionMetric(){} // RVA: 0x70FE130
        public void RecalculateUVDistributionMetrics(){} // RVA: 0x70FE2B0
        public void MarkDynamic(){} // RVA: 0x70FE410
        public void DiscardReadableData(){} // RVA: 0x70FE4B0
        public void UploadMeshData(){} // RVA: 0x70FE550
        public void Optimize(){} // RVA: 0x70FE600
        public void OptimizeIndexBuffers(){} // RVA: 0x70FE750
        public void OptimizeReorderVertexBuffer(){} // RVA: 0x70FE8A0
        public void GetTopology(){} // RVA: 0x70FE9F0
        public void CombineMeshes(){} // RVA: 0x70FEB60 | overloaded x4
        public void GetVertexAttribute_Injected(){} // RVA: 0x70FEB90
        public void GetBlendShapeOffsetInternal_Injected(){} // RVA: 0x70FEC00
        public void SetSubMesh_Injected(){} // RVA: 0x70FEC70
        public void GetSubMesh_Injected(){} // RVA: 0x70FECF0
        public void get_bounds_Injected(){} // RVA: 0x70FED60
        public void set_bounds_Injected(){} // RVA: 0x70FEDC0
    }

    public class MeshCollider
    {
        // ── Methods ──
        public void get_sharedMesh(){} // RVA: 0x7202110
        public void set_sharedMesh(){} // RVA: 0x7202160
        public void get_convex(){} // RVA: 0x72021C0
        public void set_convex(){} // RVA: 0x7202210
        public void get_cookingOptions(){} // RVA: 0x7202270
        public void set_cookingOptions(){} // RVA: 0x72022C0
        public void get_smoothSphereCollisions(){} // RVA: 0x20D68C0
        public void set_smoothSphereCollisions(){} // RVA: 0x2DD310
        public void get_skinWidth(){} // RVA: 0x70F2A70
        public void set_skinWidth(){} // RVA: 0x2DD310
        public void get_inflateMesh(){} // RVA: 0x27694F0
        public void set_inflateMesh(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class MeshFilter
    {
        public object additionalVertexStreams;
        public object enlightenVertexStream;

        // ── Methods ──
        public void DontStripMeshFilter(){} // RVA: 0x2DD310
        public void get_sharedMesh(){} // RVA: 0x70F2E30
        public void set_sharedMesh(){} // RVA: 0x70F2E80
        public void get_mesh(){} // RVA: 0x70F2EE0
        public void set_mesh(){} // RVA: 0x70F2F30
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class MeshRenderer
    {
        public object castShadows;
        public object motionVectors;
        public object useLightProbes;

        // ── Methods ──
        public void DontStripMeshRenderer(){} // RVA: 0x2DD310
        public void get_additionalVertexStreams(){} // RVA: 0x70F45C0
        public void set_additionalVertexStreams(){} // RVA: 0x70F4610
        public void get_enlightenVertexStream(){} // RVA: 0x70F4670
        public void set_enlightenVertexStream(){} // RVA: 0x70F46C0
        public void get_subMeshStartIndex(){} // RVA: 0x70F4720
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Microphone
    {
        // ── Methods ──
        public void GetMicrophoneDeviceIDFromName(){} // RVA: 0x70B1190
        public void StartRecord(){} // RVA: 0x70B11E0
        public void EndRecord(){} // RVA: 0x70B1260
        public void IsRecording(){} // RVA: 0x70B1770 | overloaded x2
        public void GetRecordPosition(){} // RVA: 0x70B1300
        public void GetDeviceCaps(){} // RVA: 0x70B18B0 | overloaded x2
        public void Start(){} // RVA: 0x70B13C0
        public void End(){} // RVA: 0x70B1680
        public void get_devices(){} // RVA: 0x70B1720
        public void GetPosition(){} // RVA: 0x70B1810
    }

    public class MinAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330
    }

    public class MissingReferenceException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x712C4A0 | overloaded x3
    }

    public class ModifiableContactPair
    {
    }

    public class MonoBehaviour
    {
        public System.Threading.CancellationTokenSource enabled; // 0x18

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7129E90
        public void RaiseCancellation(){} // RVA: 0x7129F90
        public void IsInvoking(){} // RVA: 0x712A1B0 | overloaded x3
        public void CancelInvoke(){} // RVA: 0x712A150 | overloaded x3
        public void Invoke(){} // RVA: 0x712A0A0
        public void InvokeRepeating(){} // RVA: 0x712A0C0
        public void StartCoroutine(){} // RVA: 0x712A380 | overloaded x3
        public void StartCoroutine_Auto(){} // RVA: 0x712A4D0
        public void StopCoroutine(){} // RVA: 0x712A780 | overloaded x3
        public void StopAllCoroutines(){} // RVA: 0x712A7E0
        public void get_useGUILayout(){} // RVA: 0x712A830
        public void set_useGUILayout(){} // RVA: 0x712A880
        public void print(){} // RVA: 0x712A8E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x712A050
        public void Internal_IsInvokingAll(){} // RVA: 0x712A000
        public void InvokeDelayed(){} // RVA: 0x712A930
        public void IsObjectMonoBehaviour(){} // RVA: 0x712A9B0
        public void StartCoroutineManaged(){} // RVA: 0x712AA00
        public void StartCoroutineManaged2(){} // RVA: 0x712AA70
        public void StopCoroutineManaged(){} // RVA: 0x712AAD0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x712AB30
        public void GetScriptClassName(){} // RVA: 0x712AB90
        public void OnCancellationTokenCreated(){} // RVA: 0x712ABE0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class Motion
    {
        public bool length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x709A3E0
        public void get_averageDuration(){} // RVA: 0x709A430
        public void get_averageAngularSpeed(){} // RVA: 0x709A480
        public void get_averageSpeed(){} // RVA: 0x709A4D0
        public void get_apparentSpeed(){} // RVA: 0x709A540
        public void get_isLooping(){} // RVA: 0x709A590
        public void get_isHumanMotion(){} // RVA: 0x709A5E0
        public void get_averageSpeed_Injected(){} // RVA: 0x709A630
    }

    public class MultilineAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x711F860
    }

}