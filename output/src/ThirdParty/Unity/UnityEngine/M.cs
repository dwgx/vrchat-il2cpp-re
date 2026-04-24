// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 11
// Methods: 836

namespace ThirdParty.Unity.UnityEngine
{
    public class ManagedStreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateLoadFromStream(){} // RVA: 0x7FFD54CE2040
        public void ManagedStreamRead(){} // RVA: 0x7FFD54CE21B0
        public void ManagedStreamSeek(){} // RVA: 0x7FFD54CE22A0
        public void ManagedStreamLength(){} // RVA: 0x7FFD54CE2370
    }

    public class Material : Object
    {
        public object shader;
        public object color;
        public object mainTexture;
        public object mainTextureOffset;
        public object mainTextureScale;
        public object renderQueue;
        public object enabledKeywords;
        public object globalIlluminationFlags;
        public object doubleSidedGI;
        public object enableInstancing;
        public object passCount;
        public object shaderKeywords;

        // ── Methods ──
        public void CreateWithShader(){} // RVA: 0x7FFD54CA10B0
        public void CreateWithMaterial(){} // RVA: 0x7FFD54CA1110
        public void CreateWithString(){} // RVA: 0x7FFD54CA1170
        public void .ctor(){} // RVA: 0x7FFD54CA1300 | overloaded x3
        public void get_shader(){} // RVA: 0x7FFD54CA1390
        public void set_shader(){} // RVA: 0x7FFD54CA13E0
        public void get_color(){} // RVA: 0x7FFD54CA1440
        public void set_color(){} // RVA: 0x7FFD54CA1560
        public void get_mainTexture(){} // RVA: 0x7FFD54CA1670
        public void set_mainTexture(){} // RVA: 0x7FFD54CA1760
        public void get_mainTextureOffset(){} // RVA: 0x7FFD54CA1810
        public void set_mainTextureOffset(){} // RVA: 0x7FFD54CA18C0
        public void get_mainTextureScale(){} // RVA: 0x7FFD54CA19D0
        public void set_mainTextureScale(){} // RVA: 0x7FFD54CA1A80
        public void GetFirstPropertyNameIdByAttribute(){} // RVA: 0x7FFD54CA1B90
        public void HasProperty(){} // RVA: 0x7FFD54CA1C50 | overloaded x2
        public void HasFloatImpl(){} // RVA: 0x7FFD54CA1CF0
        public void HasFloat(){} // RVA: 0x7FFD54CA1CF0 | overloaded x2
        public void HasInt(){} // RVA: 0x7FFD54CA1CF0 | overloaded x2
        public void HasIntImpl(){} // RVA: 0x7FFD54CA1DF0
        public void HasInteger(){} // RVA: 0x7FFD54CA1DF0 | overloaded x2
        public void HasTextureImpl(){} // RVA: 0x7FFD54CA1EF0
        public void HasTexture(){} // RVA: 0x7FFD54CA1EF0 | overloaded x2
        public void HasMatrixImpl(){} // RVA: 0x7FFD54CA1FF0
        public void HasMatrix(){} // RVA: 0x7FFD54CA1FF0 | overloaded x2
        public void HasVectorImpl(){} // RVA: 0x7FFD54CA20F0
        public void HasVector(){} // RVA: 0x7FFD54CA20F0 | overloaded x2
        public void HasColor(){} // RVA: 0x7FFD54CA20F0 | overloaded x2
        public void HasBufferImpl(){} // RVA: 0x7FFD54CA21F0
        public void HasBuffer(){} // RVA: 0x7FFD54CA21F0 | overloaded x2
        public void HasConstantBufferImpl(){} // RVA: 0x7FFD54CA22F0
        public void HasConstantBuffer(){} // RVA: 0x7FFD54CA22F0 | overloaded x2
        public void get_renderQueue(){} // RVA: 0x7FFD54CA23F0
        public void set_renderQueue(){} // RVA: 0x7FFD54CA2440
        public void EnableKeyword(){} // RVA: 0x7FFD54CA2750 | overloaded x2
        public void DisableKeyword(){} // RVA: 0x7FFD54CA27C0 | overloaded x2
        public void IsKeywordEnabled(){} // RVA: 0x7FFD54CA28B0 | overloaded x2
        public void EnableLocalKeyword(){} // RVA: 0x7FFD54CA25C0
        public void DisableLocalKeyword(){} // RVA: 0x7FFD54CA2620
        public void SetLocalKeyword(){} // RVA: 0x7FFD54CA2680
        public void IsLocalKeywordEnabled(){} // RVA: 0x7FFD54CA26F0
        public void SetKeyword(){} // RVA: 0x7FFD54CA2830
        public void GetEnabledKeywords(){} // RVA: 0x7FFD54CA2920
        public void SetEnabledKeywords(){} // RVA: 0x7FFD54CA2970
        public void get_enabledKeywords(){} // RVA: 0x7FFD54CA2920
        public void set_enabledKeywords(){} // RVA: 0x7FFD54CA2970
        public void get_globalIlluminationFlags(){} // RVA: 0x7FFD54CA29D0
        public void set_globalIlluminationFlags(){} // RVA: 0x7FFD54CA2A20
        public void get_doubleSidedGI(){} // RVA: 0x7FFD54CA2A80
        public void set_doubleSidedGI(){} // RVA: 0x7FFD54CA2AD0
        public void get_enableInstancing(){} // RVA: 0x7FFD54CA2B30
        public void set_enableInstancing(){} // RVA: 0x7FFD54CA2B80
        public void get_passCount(){} // RVA: 0x7FFD54CA2BE0
        public void SetShaderPassEnabled(){} // RVA: 0x7FFD54CA2C30
        public void GetShaderPassEnabled(){} // RVA: 0x7FFD54CA2CA0
        public void GetPassName(){} // RVA: 0x7FFD54CA2D00
        public void FindPass(){} // RVA: 0x7FFD54CA2D60
        public void SetOverrideTag(){} // RVA: 0x7FFD54CA2DC0
        public void GetTagImpl(){} // RVA: 0x7FFD54CA2E30
        public void GetTag(){} // RVA: 0x7FFD54CA2ED0 | overloaded x2
        public void Lerp(){} // RVA: 0x7FFD54CA2F40
        public void SetPass(){} // RVA: 0x7FFD54CA2FC0
        public void CopyPropertiesFromMaterial(){} // RVA: 0x7FFD54CA3020
        public void CopyMatchingPropertiesFromMaterial(){} // RVA: 0x7FFD54CA3080
        public void GetShaderKeywords(){} // RVA: 0x7FFD54CA30E0
        public void SetShaderKeywords(){} // RVA: 0x7FFD54CA3130
        public void get_shaderKeywords(){} // RVA: 0x7FFD54CA30E0
        public void set_shaderKeywords(){} // RVA: 0x7FFD54CA3130
        public void GetPropertyNamesImpl(){} // RVA: 0x7FFD54CA3190
        public void ComputeCRC(){} // RVA: 0x7FFD54CA31F0
        public void GetTexturePropertyNames(){} // RVA: 0x7FFD54CA33A0 | overloaded x2
        public void GetTexturePropertyNameIDs(){} // RVA: 0x7FFD54CA3450 | overloaded x2
        public void GetTexturePropertyNamesInternal(){} // RVA: 0x7FFD54CA32E0
        public void GetTexturePropertyNameIDsInternal(){} // RVA: 0x7FFD54CA3340
        public void SetIntImpl(){} // RVA: 0x7FFD54CA3500
        public void SetFloatImpl(){} // RVA: 0x7FFD54CA3570
        public void SetColorImpl(){} // RVA: 0x7FFD54CA35E0
        public void SetMatrixImpl(){} // RVA: 0x7FFD54CA3650
        public void SetTextureImpl(){} // RVA: 0x7FFD54CA36C0
        public void SetRenderTextureImpl(){} // RVA: 0x7FFD54CA3730
        public void SetBufferImpl(){} // RVA: 0x7FFD54CA37B0
        public void SetGraphicsBufferImpl(){} // RVA: 0x7FFD54CA3820
        public void GetIntImpl(){} // RVA: 0x7FFD54CA3890
        public void GetFloatImpl(){} // RVA: 0x7FFD54CA38F0
        public void GetColorImpl(){} // RVA: 0x7FFD54CA3950
        public void GetMatrixImpl(){} // RVA: 0x7FFD54CA39D0
        public void GetTextureImpl(){} // RVA: 0x7FFD54CA3A60
        public void SetFloatArrayImpl(){} // RVA: 0x7FFD54CA3AC0
        public void SetVectorArrayImpl(){} // RVA: 0x7FFD54CA3B40
        public void SetColorArrayImpl(){} // RVA: 0x7FFD54CA3BC0
        public void SetMatrixArrayImpl(){} // RVA: 0x7FFD54CA3C40
        public void GetFloatArrayImpl(){} // RVA: 0x7FFD54CA3CC0
        public void GetVectorArrayImpl(){} // RVA: 0x7FFD54CA3D20
        public void GetColorArrayImpl(){} // RVA: 0x7FFD54CA3D80
        public void GetMatrixArrayImpl(){} // RVA: 0x7FFD54CA3DE0
        public void GetFloatArrayCountImpl(){} // RVA: 0x7FFD54CA3E40
        public void GetVectorArrayCountImpl(){} // RVA: 0x7FFD54CA3EA0
        public void GetColorArrayCountImpl(){} // RVA: 0x7FFD54CA3F00
        public void GetMatrixArrayCountImpl(){} // RVA: 0x7FFD54CA3F60
        public void ExtractFloatArrayImpl(){} // RVA: 0x7FFD54CA3FC0
        public void ExtractVectorArrayImpl(){} // RVA: 0x7FFD54CA4030
        public void ExtractColorArrayImpl(){} // RVA: 0x7FFD54CA40A0
        public void ExtractMatrixArrayImpl(){} // RVA: 0x7FFD54CA4110
        public void GetTextureScaleAndOffsetImpl(){} // RVA: 0x7FFD54CA4180
        public void SetTextureOffsetImpl(){} // RVA: 0x7FFD54CA4200
        public void SetTextureScaleImpl(){} // RVA: 0x7FFD54CA4270
        public void SetFloatArray(){} // RVA: 0x7FFD54CA5BB0 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x7FFD54CA5FF0 | overloaded x5
        public void SetColorArray(){} // RVA: 0x7FFD54CA5DD0 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x7FFD54CA6210 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x7FFD54CA48E0
        public void ExtractVectorArray(){} // RVA: 0x7FFD54CA4AE0
        public void ExtractColorArray(){} // RVA: 0x7FFD54CA4CE0
        public void ExtractMatrixArray(){} // RVA: 0x7FFD54CA4EE0
        public void SetInt(){} // RVA: 0x7FFD54CA51A0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFD54CA3570 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFD54CA3500 | overloaded x2
        public void SetColor(){} // RVA: 0x7FFD54CA5430 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFD54CA55A0 | overloaded x2
        public void SetMatrix(){} // RVA: 0x7FFD54CA5730 | overloaded x2
        public void SetTexture(){} // RVA: 0x7FFD54CA5900 | overloaded x4
        public void SetBuffer(){} // RVA: 0x7FFD54CA5910 | overloaded x2
        public void GetInt(){} // RVA: 0x7FFD54CA62F0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFD54CA38F0 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFD54CA3890 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFD54CA6560 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFD54CA66C0 | overloaded x2
        public void GetMatrix(){} // RVA: 0x7FFD54CA6860 | overloaded x2
        public void GetTexture(){} // RVA: 0x7FFD54CA3A60 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x7FFD54CA6EC0 | overloaded x4
        public void GetColorArray(){} // RVA: 0x7FFD54CA6F50 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x7FFD54CA6FE0 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x7FFD54CA7070 | overloaded x4
        public void SetTextureOffset(){} // RVA: 0x7FFD54CA4200 | overloaded x2
        public void SetTextureScale(){} // RVA: 0x7FFD54CA4270 | overloaded x2
        public void GetTextureOffset(){} // RVA: 0x7FFD54CA7270 | overloaded x2
        public void GetTextureScale(){} // RVA: 0x7FFD54CA7360 | overloaded x2
        public void GetPropertyNames(){} // RVA: 0x7FFD54CA3190
        public void EnableLocalKeyword_Injected(){} // RVA: 0x7FFD54CA73E0
        public void DisableLocalKeyword_Injected(){} // RVA: 0x7FFD54CA7440
        public void SetLocalKeyword_Injected(){} // RVA: 0x7FFD54CA74A0
        public void IsLocalKeywordEnabled_Injected(){} // RVA: 0x7FFD54CA7510
        public void SetColorImpl_Injected(){} // RVA: 0x7FFD54CA7570
        public void SetMatrixImpl_Injected(){} // RVA: 0x7FFD54CA75E0
        public void GetColorImpl_Injected(){} // RVA: 0x7FFD54CA7650
        public void GetMatrixImpl_Injected(){} // RVA: 0x7FFD54CA76C0
        public void GetTextureScaleAndOffsetImpl_Injected(){} // RVA: 0x7FFD54CA7730
        public void SetTextureOffsetImpl_Injected(){} // RVA: 0x7FFD54CA77A0
        public void SetTextureScaleImpl_Injected(){} // RVA: 0x7FFD54CA7810
    }

    public class MaterialPropertyBlock : Object
    {
        public object isEmpty;

        // ── Methods ──
        public void GetIntImpl(){} // RVA: 0x7FFD54C96550
        public void GetFloatImpl(){} // RVA: 0x7FFD54C965B0
        public void GetVectorImpl(){} // RVA: 0x7FFD54C96610
        public void GetColorImpl(){} // RVA: 0x7FFD54C96690
        public void GetMatrixImpl(){} // RVA: 0x7FFD54C96710
        public void GetTextureImpl(){} // RVA: 0x7FFD54C967A0
        public void HasPropertyImpl(){} // RVA: 0x7FFD54C96800
        public void HasFloatImpl(){} // RVA: 0x7FFD54C96860
        public void HasIntImpl(){} // RVA: 0x7FFD54C968C0
        public void HasTextureImpl(){} // RVA: 0x7FFD54C96920
        public void HasMatrixImpl(){} // RVA: 0x7FFD54C96980
        public void HasVectorImpl(){} // RVA: 0x7FFD54C969E0
        public void HasBufferImpl(){} // RVA: 0x7FFD54C96A40
        public void HasConstantBufferImpl(){} // RVA: 0x7FFD54C96AA0
        public void SetIntImpl(){} // RVA: 0x7FFD54C96B00
        public void SetFloatImpl(){} // RVA: 0x7FFD54C96B70
        public void SetVectorImpl(){} // RVA: 0x7FFD54C96BE0
        public void SetColorImpl(){} // RVA: 0x7FFD54C96C50
        public void SetMatrixImpl(){} // RVA: 0x7FFD54C96CC0
        public void SetTextureImpl(){} // RVA: 0x7FFD54C96D30
        public void SetRenderTextureImpl(){} // RVA: 0x7FFD54C96DA0
        public void SetBufferImpl(){} // RVA: 0x7FFD54C96E20
        public void SetGraphicsBufferImpl(){} // RVA: 0x7FFD54C96E90
        public void SetFloatArrayImpl(){} // RVA: 0x7FFD54C96F00
        public void SetVectorArrayImpl(){} // RVA: 0x7FFD54C96F80
        public void SetMatrixArrayImpl(){} // RVA: 0x7FFD54C97000
        public void GetFloatArrayImpl(){} // RVA: 0x7FFD54C97080
        public void GetVectorArrayImpl(){} // RVA: 0x7FFD54C970E0
        public void GetMatrixArrayImpl(){} // RVA: 0x7FFD54C97140
        public void GetFloatArrayCountImpl(){} // RVA: 0x7FFD54C971A0
        public void GetVectorArrayCountImpl(){} // RVA: 0x7FFD54C97200
        public void GetMatrixArrayCountImpl(){} // RVA: 0x7FFD54C97260
        public void ExtractFloatArrayImpl(){} // RVA: 0x7FFD54C972C0
        public void ExtractVectorArrayImpl(){} // RVA: 0x7FFD54C97330
        public void ExtractMatrixArrayImpl(){} // RVA: 0x7FFD54C973A0
        public void Internal_CopySHCoefficientArraysFrom(){} // RVA: 0x7FFD54C97410
        public void Internal_CopyProbeOcclusionArrayFrom(){} // RVA: 0x7FFD54C974A0
        public void CreateImpl(){} // RVA: 0x7FFD54C97530
        public void DestroyImpl(){} // RVA: 0x7FFD54C97580
        public void get_isEmpty(){} // RVA: 0x7FFD54C975D0
        public void Clear(){} // RVA: 0x7FFD54C97680 | overloaded x2
        public void SetFloatArray(){} // RVA: 0x7FFD54C98CE0 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x7FFD54C98F00 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x7FFD54C99120 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x7FFD54C97B60
        public void ExtractVectorArray(){} // RVA: 0x7FFD54C97D60
        public void ExtractMatrixArray(){} // RVA: 0x7FFD54C97F60
        public void .ctor(){} // RVA: 0x7FFD54C98160
        public void Finalize(){} // RVA: 0x7FFD54C981B0
        public void Dispose(){} // RVA: 0x7FFD54C98290
        public void SetInt(){} // RVA: 0x7FFD54C98400 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFD54C96B70 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFD54C96B00 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFD54C98690 | overloaded x2
        public void SetColor(){} // RVA: 0x7FFD54C987C0 | overloaded x2
        public void SetMatrix(){} // RVA: 0x7FFD54C98910 | overloaded x2
        public void SetBuffer(){} // RVA: 0x7FFD54C96E90 | overloaded x2
        public void SetTexture(){} // RVA: 0x7FFD54C98AE0 | overloaded x4
        public void HasProperty(){} // RVA: 0x7FFD54C96800 | overloaded x2
        public void HasInt(){} // RVA: 0x7FFD54C96860 | overloaded x2
        public void HasFloat(){} // RVA: 0x7FFD54C96860 | overloaded x2
        public void HasInteger(){} // RVA: 0x7FFD54C968C0 | overloaded x2
        public void HasTexture(){} // RVA: 0x7FFD54C96920 | overloaded x2
        public void HasMatrix(){} // RVA: 0x7FFD54C96980 | overloaded x2
        public void HasVector(){} // RVA: 0x7FFD54C969E0 | overloaded x2
        public void HasColor(){} // RVA: 0x7FFD54C969E0 | overloaded x2
        public void HasBuffer(){} // RVA: 0x7FFD54C96A40 | overloaded x2
        public void HasConstantBuffer(){} // RVA: 0x7FFD54C96AA0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFD54C965B0 | overloaded x2
        public void GetInt(){} // RVA: 0x7FFD54C997A0 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFD54C96550 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFD54C99970 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFD54C99AD0 | overloaded x2
        public void GetMatrix(){} // RVA: 0x7FFD54C99C70 | overloaded x2
        public void GetTexture(){} // RVA: 0x7FFD54C967A0 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x7FFD54C9A1B0 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x7FFD54C9A240 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x7FFD54C9A2D0 | overloaded x4
        public void CopySHCoefficientArraysFrom(){} // RVA: 0x7FFD54C9A4B0 | overloaded x4
        public void CopyProbeOcclusionArrayFrom(){} // RVA: 0x7FFD54C9A8F0 | overloaded x4
        public void GetVectorImpl_Injected(){} // RVA: 0x7FFD54C9AB60
        public void GetColorImpl_Injected(){} // RVA: 0x7FFD54C9ABD0
        public void GetMatrixImpl_Injected(){} // RVA: 0x7FFD54C9AC40
        public void SetVectorImpl_Injected(){} // RVA: 0x7FFD54C9ACB0
        public void SetColorImpl_Injected(){} // RVA: 0x7FFD54C9AD20
        public void SetMatrixImpl_Injected(){} // RVA: 0x7FFD54C9AD90
    }

    public class Mathf : ValueType
    {
        // ── Methods ──
        public void ClosestPowerOfTwo(){} // RVA: 0x7FFD54CD0D00
        public void IsPowerOfTwo(){} // RVA: 0x7FFD54CD0D50
        public void NextPowerOfTwo(){} // RVA: 0x7FFD54CD0DA0
        public void GammaToLinearSpace(){} // RVA: 0x7FFD54CD0DF0
        public void LinearToGammaSpace(){} // RVA: 0x7FFD54CD0E50
        public void CorrelatedColorTemperatureToRGB(){} // RVA: 0x7FFD54CD0EB0
        public void FloatToHalf(){} // RVA: 0x7FFD54CD0F20
        public void HalfToFloat(){} // RVA: 0x7FFD54CD0F80
        public void PerlinNoise(){} // RVA: 0x7FFD54CD0FD0
        public void PerlinNoise1D(){} // RVA: 0x7FFD54CD1040
        public void Sin(){} // RVA: 0x7FFD54CD10A0
        public void Cos(){} // RVA: 0x7FFD54CD1100
        public void Tan(){} // RVA: 0x7FFD54CD1160
        public void Asin(){} // RVA: 0x7FFD54CD11C0
        public void Acos(){} // RVA: 0x7FFD54CD1220
        public void Atan(){} // RVA: 0x7FFD54CD1280
        public void Atan2(){} // RVA: 0x7FFD54CD12E0
        public void Sqrt(){} // RVA: 0x7FFD54CD1350
        public void Abs(){} // RVA: 0x7FFD54CD1430 | overloaded x2
        public void Min(){} // RVA: 0x7FFD54CD14E0 | overloaded x4
        public void Max(){} // RVA: 0x7FFD54CD1550 | overloaded x4
        public void Pow(){} // RVA: 0x7FFD54CD15B0
        public void Exp(){} // RVA: 0x7FFD54CD1630
        public void Log(){} // RVA: 0x7FFD54CD1710 | overloaded x2
        public void Log10(){} // RVA: 0x7FFD54CD1770
        public void Ceil(){} // RVA: 0x7FFD54CD17D0
        public void Floor(){} // RVA: 0x7FFD54CD1830
        public void Round(){} // RVA: 0x7FFD54CD1890
        public void CeilToInt(){} // RVA: 0x7FFD54CD18F0
        public void FloorToInt(){} // RVA: 0x7FFD54CD1950
        public void RoundToInt(){} // RVA: 0x7FFD54CD19B0
        public void Sign(){} // RVA: 0x7FFD54CD1A10
        public void Clamp(){} // RVA: 0x7FFD4E365AE0 | overloaded x2
        public void Clamp01(){} // RVA: 0x7FFD4E365DC0
        public void Lerp(){} // RVA: 0x7FFD4E364F40
        public void LerpUnclamped(){} // RVA: 0x7FFD54CD1A30
        public void LerpAngle(){} // RVA: 0x7FFD4E365160
        public void MoveTowards(){} // RVA: 0x7FFD4E365A60
        public void MoveTowardsAngle(){} // RVA: 0x7FFD54CD1A50
        public void SmoothStep(){} // RVA: 0x7FFD4EA6E290
        public void Gamma(){} // RVA: 0x7FFD54CD1AF0
        public void Approximately(){} // RVA: 0x7FFD54CD1B50
        public void SmoothDamp(){} // RVA: 0x7FFD54CD1C90 | overloaded x3
        public void SmoothDampAngle(){} // RVA: 0x7FFD4F93BC40 | overloaded x3
        public void Repeat(){} // RVA: 0x7FFD4E365380
        public void PingPong(){} // RVA: 0x7FFD4EED0710
        public void InverseLerp(){} // RVA: 0x7FFD4E364F00
        public void DeltaAngle(){} // RVA: 0x7FFD4E38E0F0
        public void ClampToFloat(){} // RVA: 0x7FFD54CD1F80
        public void ClampToInt(){} // RVA: 0x7FFD54CD1FE0
        public void ClampToUInt(){} // RVA: 0x7FFD54CD2000
        public void GetNumberOfDecimalsForMinimumDifference(){} // RVA: 0x7FFD54CD2020
        public void RoundBasedOnMinimumDifference(){} // RVA: 0x7FFD54CD20C0
        public void DiscardLeastSignificantDecimal(){} // RVA: 0x7FFD54CD21F0
        public void .cctor(){} // RVA: 0x7FFD54CD2290
        public void CorrelatedColorTemperatureToRGB_Injected(){} // RVA: 0x7FFD54CD2310
    }

    public class Matrix4x4 : ValueType
    {
        public object rotation;
        public object lossyScale;
        public object isIdentity;
        public object determinant;
        public object decomposeProjection;
        public object inverse;
        public object transpose;
        public object Item;
        public object Item;
        public object zero;
        public object identity;

        // ── Methods ──
        public void GetRotation(){} // RVA: 0x7FFD54CCA6E0
        public void GetLossyScale(){} // RVA: 0x7FFD54CCA750
        public void IsIdentity(){} // RVA: 0x7FFD54CCA7C0
        public void GetDeterminant(){} // RVA: 0x7FFD54CCA810
        public void DecomposeProjection(){} // RVA: 0x7FFD54CCA860
        public void get_rotation(){} // RVA: 0x7FFD54CCA8D0
        public void get_lossyScale(){} // RVA: 0x7FFD54CCA950
        public void get_isIdentity(){} // RVA: 0x7FFD54CCA7C0
        public void get_determinant(){} // RVA: 0x7FFD54CCA810
        public void get_decomposeProjection(){} // RVA: 0x7FFD54CCA9E0
        public void ValidTRS(){} // RVA: 0x7FFD54CCAA70
        public void Determinant(){} // RVA: 0x7FFD54CCAAC0
        public void TRS(){} // RVA: 0x7FFD54CCAB10
        public void SetTRS(){} // RVA: 0x7FFD54CCABB0
        public void Inverse3DAffine(){} // RVA: 0x7FFD54CCAC90
        public void Inverse(){} // RVA: 0x7FFD54CCACF0
        public void get_inverse(){} // RVA: 0x7FFD54CCAD70
        public void Transpose(){} // RVA: 0x7FFD54CCAE40
        public void get_transpose(){} // RVA: 0x7FFD54CCAEC0
        public void Ortho(){} // RVA: 0x7FFD54CCAF90
        public void Perspective(){} // RVA: 0x7FFD54CCB060
        public void LookAt(){} // RVA: 0x7FFD54CCB110
        public void Frustum(){} // RVA: 0x7FFD54CCB280 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD54CCB3D0
        public void get_Item(){} // RVA: 0x7FFD54CCB460 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFD54CCB5C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD511C2890
        public void Equals(){} // RVA: 0x7FFD5034F130 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFD54CCBD10 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54CCBE30
        public void op_Inequality(){} // RVA: 0x7FFD54CCBF70
        public void GetColumn(){} // RVA: 0x7FFD54CCBFE0
        public void GetRow(){} // RVA: 0x7FFD54CCC0B0
        public void GetPosition(){} // RVA: 0x7FFD54CCC1A0
        public void SetColumn(){} // RVA: 0x7FFD54CCC1C0
        public void SetRow(){} // RVA: 0x7FFD54CCC240
        public void MultiplyPoint(){} // RVA: 0x7FFD54CCC2B0
        public void MultiplyPoint3x4(){} // RVA: 0x7FFD54CCC3A0
        public void MultiplyVector(){} // RVA: 0x7FFD54CCC440
        public void TransformPlane(){} // RVA: 0x7FFD54CCC4D0
        public void Scale(){} // RVA: 0x7FFD54CCC780
        public void Translate(){} // RVA: 0x7FFD54CCC820
        public void Rotate(){} // RVA: 0x7FFD54CCC8C0
        public void get_zero(){} // RVA: 0x7FFD54CCCA70
        public void get_identity(){} // RVA: 0x7FFD54CCCAD0
        public void ToString(){} // RVA: 0x7FFD54CCCB50 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD54CCD190
        public void GetRotation_Injected(){} // RVA: 0x7FFD54CCD2B0
        public void GetLossyScale_Injected(){} // RVA: 0x7FFD54CCD310
        public void IsIdentity_Injected(){} // RVA: 0x7FFD54CCA7C0
        public void GetDeterminant_Injected(){} // RVA: 0x7FFD54CCA810
        public void DecomposeProjection_Injected(){} // RVA: 0x7FFD54CCD370
        public void ValidTRS_Injected(){} // RVA: 0x7FFD54CCAA70
        public void TRS_Injected(){} // RVA: 0x7FFD54CCD3D0
        public void Inverse3DAffine_Injected(){} // RVA: 0x7FFD54CCD450
        public void Inverse_Injected(){} // RVA: 0x7FFD54CCD4B0
        public void Transpose_Injected(){} // RVA: 0x7FFD54CCD510
        public void Ortho_Injected(){} // RVA: 0x7FFD54CCD570
        public void Perspective_Injected(){} // RVA: 0x7FFD54CCD610
        public void LookAt_Injected(){} // RVA: 0x7FFD54CCD6B0
        public void Frustum_Injected(){} // RVA: 0x7FFD54CCD730
    }

    public class Mesh : Object
    {
        public object indexFormat;
        public object vertexBufferCount;
        public object blendShapeCount;
        public object bindposeCount;
        public object bindposes;
        public object isReadable;
        public object canAccess;
        public object vertexCount;
        public object subMeshCount;
        public object bounds;
        public object vertices;
        public object normals;
        public object tangents;
        public object uv;
        public object uv2;
        public object uv3;
        public object uv4;
        public object uv5;
        public object uv6;
        public object uv7;
        public object uv8;
        public object colors;
        public object colors32;
        public object vertexAttributeCount;
        public object triangles;
        public object boneWeights;
        public object skinWeightBufferLayout;

        // ── Methods ──
        public void Internal_Create(){} // RVA: 0x7FFD54CAD2F0
        public void .ctor(){} // RVA: 0x7FFD54CAD340
        public void FromInstanceID(){} // RVA: 0x7FFD54CAD3D0
        public void get_indexFormat(){} // RVA: 0x7FFD54CAD420
        public void set_indexFormat(){} // RVA: 0x7FFD54CAD470
        public void SetIndexBufferParams(){} // RVA: 0x7FFD54CAD4D0
        public void InternalSetIndexBufferData(){} // RVA: 0x7FFD54CAD540
        public void SetVertexBufferParamsFromArray(){} // RVA: 0x7FFD54CAD5D0
        public void GetVertexAttributesAlloc(){} // RVA: 0x7FFD54CAD640
        public void GetVertexAttributesArray(){} // RVA: 0x7FFD54CAD690
        public void GetVertexAttributesList(){} // RVA: 0x7FFD54CAD6F0
        public void GetVertexAttributeCountImpl(){} // RVA: 0x7FFD54CAD750
        public void GetVertexAttribute(){} // RVA: 0x7FFD54CAD7A0
        public void GetIndexStartImpl(){} // RVA: 0x7FFD54CAD820
        public void GetIndexCountImpl(){} // RVA: 0x7FFD54CAD880
        public void GetTrianglesCountImpl(){} // RVA: 0x7FFD54CAD8E0
        public void GetBaseVertexImpl(){} // RVA: 0x7FFD54CAD940
        public void GetTrianglesImpl(){} // RVA: 0x7FFD54CAD9A0
        public void GetIndicesImpl(){} // RVA: 0x7FFD54CADA10
        public void SetIndicesImpl(){} // RVA: 0x7FFD54CADA80
        public void GetTrianglesNonAllocImpl(){} // RVA: 0x7FFD54CADB10
        public void GetTrianglesNonAllocImpl16(){} // RVA: 0x7FFD54CADB90
        public void GetIndicesNonAllocImpl(){} // RVA: 0x7FFD54CADC10
        public void GetIndicesNonAllocImpl16(){} // RVA: 0x7FFD54CADC90
        public void PrintErrorCantAccessChannel(){} // RVA: 0x7FFD54CADD10
        public void HasVertexAttribute(){} // RVA: 0x7FFD54CADD70
        public void GetVertexAttributeDimension(){} // RVA: 0x7FFD54CADDD0
        public void GetVertexAttributeFormat(){} // RVA: 0x7FFD54CADE30
        public void GetVertexAttributeStream(){} // RVA: 0x7FFD54CADE90
        public void GetVertexAttributeOffset(){} // RVA: 0x7FFD54CADEF0
        public void SetArrayForChannelImpl(){} // RVA: 0x7FFD54CADF50
        public void SetNativeArrayForChannelImpl(){} // RVA: 0x7FFD54CADFD0
        public void GetAllocArrayFromChannelImpl(){} // RVA: 0x7FFD54CAE050
        public void GetArrayFromChannelImpl(){} // RVA: 0x7FFD54CAE0D0
        public void get_vertexBufferCount(){} // RVA: 0x7FFD54CAE150
        public void GetVertexBufferStride(){} // RVA: 0x7FFD54CAE1A0
        public void get_blendShapeCount(){} // RVA: 0x7FFD54CAE200
        public void ClearBlendShapes(){} // RVA: 0x7FFD54CAE250
        public void GetBlendShapeName(){} // RVA: 0x7FFD54CAE2A0
        public void GetBlendShapeIndex(){} // RVA: 0x7FFD54CAE300
        public void GetBlendShapeFrameCount(){} // RVA: 0x7FFD54CAE360
        public void GetBlendShapeFrameWeight(){} // RVA: 0x7FFD54CAE3C0
        public void GetBlendShapeFrameVertices(){} // RVA: 0x7FFD54CAE430
        public void AddBlendShapeFrame(){} // RVA: 0x7FFD54CAE4B0
        public void GetBlendShapeOffsetInternal(){} // RVA: 0x7FFD54CAE540
        public void HasBoneWeights(){} // RVA: 0x7FFD54CAE5C0
        public void GetBoneWeightsImpl(){} // RVA: 0x7FFD54CAE610
        public void SetBoneWeightsImpl(){} // RVA: 0x7FFD54CAE660
        public void GetBoneWeightBufferLayoutInternal(){} // RVA: 0x7FFD54CAE6C0
        public void get_bindposeCount(){} // RVA: 0x7FFD54CAE710
        public void get_bindposes(){} // RVA: 0x7FFD54CAE760
        public void set_bindposes(){} // RVA: 0x7FFD54CAE7B0
        public void GetBoneWeightsNonAllocImpl(){} // RVA: 0x7FFD54CAE810
        public void GetBindposesNonAllocImpl(){} // RVA: 0x7FFD54CAE870
        public void get_isReadable(){} // RVA: 0x7FFD54CAE8D0
        public void get_canAccess(){} // RVA: 0x7FFD54CAE920
        public void get_vertexCount(){} // RVA: 0x7FFD54CAE970
        public void get_subMeshCount(){} // RVA: 0x7FFD54CAE9C0
        public void set_subMeshCount(){} // RVA: 0x7FFD54CAEA10
        public void SetSubMesh(){} // RVA: 0x7FFD54CAEA70
        public void GetSubMesh(){} // RVA: 0x7FFD54CAEAF0
        public void SetAllSubMeshesAtOnceFromArray(){} // RVA: 0x7FFD54CAEB70
        public void get_bounds(){} // RVA: 0x7FFD54CAEC00
        public void set_bounds(){} // RVA: 0x7FFD54CAEC70
        public void ClearImpl(){} // RVA: 0x7FFD54CAECD0
        public void RecalculateBoundsImpl(){} // RVA: 0x7FFD54CAED30
        public void RecalculateNormalsImpl(){} // RVA: 0x7FFD54CAED90
        public void RecalculateTangentsImpl(){} // RVA: 0x7FFD54CAEDF0
        public void MarkDynamicImpl(){} // RVA: 0x7FFD54CAEE50
        public void MarkModified(){} // RVA: 0x7FFD54CAEEA0
        public void DiscardReadableDataImpl(){} // RVA: 0x7FFD54CAEEF0
        public void UploadMeshDataImpl(){} // RVA: 0x7FFD54CAEF40
        public void GetTopologyImpl(){} // RVA: 0x7FFD54CAEFA0
        public void RecalculateUVDistributionMetricImpl(){} // RVA: 0x7FFD54CAF000
        public void RecalculateUVDistributionMetricsImpl(){} // RVA: 0x7FFD54CAF070
        public void GetUVDistributionMetric(){} // RVA: 0x7FFD54CAF0D0
        public void CombineMeshesImpl(){} // RVA: 0x7FFD54CAF130
        public void OptimizeImpl(){} // RVA: 0x7FFD54CAF1C0
        public void OptimizeIndexBuffersImpl(){} // RVA: 0x7FFD54CAF210
        public void OptimizeReorderVertexBufferImpl(){} // RVA: 0x7FFD54CAF260
        public void GetUVChannel(){} // RVA: 0x7FFD54CAF2B0
        public void DefaultDimensionForChannel(){} // RVA: 0x7FFD54CAF340
        public void GetAllocArrayFromChannel(){} // RVA: 0x7FFD4E087DE0 | overloaded x2
        public void SetSizedArrayForChannel(){} // RVA: 0x7FFD54CAF3F0
        public void SetSizedNativeArrayForChannel(){} // RVA: 0x7FFD54CAF7B0
        public void SetArrayForChannel(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetListForChannel(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetListForChannel(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void get_vertices(){} // RVA: 0x7FFD54CAFB70
        public void set_vertices(){} // RVA: 0x7FFD54CAFBE0
        public void get_normals(){} // RVA: 0x7FFD54CAFC70
        public void set_normals(){} // RVA: 0x7FFD54CAFCF0
        public void get_tangents(){} // RVA: 0x7FFD54CAFD80
        public void set_tangents(){} // RVA: 0x7FFD54CAFE00
        public void get_uv(){} // RVA: 0x7FFD54CAFE90
        public void set_uv(){} // RVA: 0x7FFD54CAFF10
        public void get_uv2(){} // RVA: 0x7FFD54CAFFA0
        public void set_uv2(){} // RVA: 0x7FFD54CB0020
        public void get_uv3(){} // RVA: 0x7FFD54CB00B0
        public void set_uv3(){} // RVA: 0x7FFD54CB0130
        public void get_uv4(){} // RVA: 0x7FFD54CB01C0
        public void set_uv4(){} // RVA: 0x7FFD54CB0240
        public void get_uv5(){} // RVA: 0x7FFD54CB02D0
        public void set_uv5(){} // RVA: 0x7FFD54CB0350
        public void get_uv6(){} // RVA: 0x7FFD54CB03E0
        public void set_uv6(){} // RVA: 0x7FFD54CB0460
        public void get_uv7(){} // RVA: 0x7FFD54CB04F0
        public void set_uv7(){} // RVA: 0x7FFD54CB0570
        public void get_uv8(){} // RVA: 0x7FFD54CB0600
        public void set_uv8(){} // RVA: 0x7FFD54CB0680
        public void get_colors(){} // RVA: 0x7FFD54CB0710
        public void set_colors(){} // RVA: 0x7FFD54CB0790
        public void get_colors32(){} // RVA: 0x7FFD54CB0820
        public void set_colors32(){} // RVA: 0x7FFD54CB0880
        public void GetVertices(){} // RVA: 0x7FFD54CB0910
        public void SetVertices(){} // RVA: 0x7FFD4E2ADC40 | overloaded x9
        public void GetNormals(){} // RVA: 0x7FFD54CB0D50
        public void SetNormals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x9
        public void GetTangents(){} // RVA: 0x7FFD54CB11B0
        public void SetTangents(){} // RVA: 0x7FFD54CB1590 | overloaded x6
        public void GetColors(){} // RVA: 0x7FFD54CB1A90 | overloaded x2
        public void SetColors(){} // RVA: 0x7FFD54CB1E80 | overloaded x12
        public void SetUvsImpl(){} // RVA: 0x7FFD54CB2630 | overloaded x2
        public void SetUVs(){} // RVA: 0x7FFD4E2ADC40 | overloaded x21
        public void GetUVsImpl(){} // RVA: 0x7FFD4E2ADC40
        public void GetUVs(){} // RVA: 0x7FFD54CB2D40 | overloaded x3
        public void get_vertexAttributeCount(){} // RVA: 0x7FFD54CAD750
        public void GetVertexAttributes(){} // RVA: 0x7FFD54CAD6F0 | overloaded x3
        public void SetVertexBufferParams(){} // RVA: 0x7FFD54CAD5D0
        public void GetBlendShapeBufferRange(){} // RVA: 0x7FFD54CB2F80
        public void PrintErrorCantAccessIndices(){} // RVA: 0x7FFD54CB30C0
        public void CheckCanAccessSubmesh(){} // RVA: 0x7FFD54CB3180
        public void CheckCanAccessSubmeshTriangles(){} // RVA: 0x7FFD54CB3350
        public void CheckCanAccessSubmeshIndices(){} // RVA: 0x7FFD54CB3360
        public void get_triangles(){} // RVA: 0x7FFD54CB3370
        public void set_triangles(){} // RVA: 0x7FFD54CB3450
        public void GetTriangles(){} // RVA: 0x7FFD54CB37E0 | overloaded x5
        public void GetIndices(){} // RVA: 0x7FFD54CB3CB0 | overloaded x5
        public void SetIndexBufferData(){} // RVA: 0x7FFD4E2ADC40
        public void GetIndexStart(){} // RVA: 0x7FFD54CB3E90
        public void GetIndexCount(){} // RVA: 0x7FFD54CB3F90
        public void GetBaseVertex(){} // RVA: 0x7FFD54CB4090
        public void CheckIndicesArrayRange(){} // RVA: 0x7FFD54CB4190
        public void SetTrianglesImpl(){} // RVA: 0x7FFD54CB4400
        public void SetTriangles(){} // RVA: 0x7FFD54CB4CD0 | overloaded x12
        public void SetIndices(){} // RVA: 0x7FFD54CB5500 | overloaded x10
        public void SetSubMeshes(){} // RVA: 0x7FFD54CB5AB0 | overloaded x4
        public void GetBindposes(){} // RVA: 0x7FFD54CB5B50
        public void GetBoneWeights(){} // RVA: 0x7FFD54CB5CA0
        public void get_boneWeights(){} // RVA: 0x7FFD54CAE610
        public void set_boneWeights(){} // RVA: 0x7FFD54CAE660
        public void get_skinWeightBufferLayout(){} // RVA: 0x7FFD54CAE6C0
        public void Clear(){} // RVA: 0x7FFD54CB5FD0 | overloaded x2
        public void RecalculateBounds(){} // RVA: 0x7FFD54CB6060 | overloaded x2
        public void RecalculateNormals(){} // RVA: 0x7FFD54CB61C0 | overloaded x2
        public void RecalculateTangents(){} // RVA: 0x7FFD54CB6320 | overloaded x2
        public void RecalculateUVDistributionMetric(){} // RVA: 0x7FFD54CB6480
        public void RecalculateUVDistributionMetrics(){} // RVA: 0x7FFD54CB6600
        public void MarkDynamic(){} // RVA: 0x7FFD54CB6760
        public void DiscardReadableData(){} // RVA: 0x7FFD54CB6800
        public void UploadMeshData(){} // RVA: 0x7FFD54CB68A0
        public void Optimize(){} // RVA: 0x7FFD54CB6950
        public void OptimizeIndexBuffers(){} // RVA: 0x7FFD54CB6AA0
        public void OptimizeReorderVertexBuffer(){} // RVA: 0x7FFD54CB6BF0
        public void GetTopology(){} // RVA: 0x7FFD54CB6D40
        public void CombineMeshes(){} // RVA: 0x7FFD54CB6EB0 | overloaded x4
        public void GetVertexAttribute_Injected(){} // RVA: 0x7FFD54CB6EE0
        public void GetBlendShapeOffsetInternal_Injected(){} // RVA: 0x7FFD54CB6F50
        public void SetSubMesh_Injected(){} // RVA: 0x7FFD54CB6FC0
        public void GetSubMesh_Injected(){} // RVA: 0x7FFD54CB7040
        public void get_bounds_Injected(){} // RVA: 0x7FFD54CB70B0
        public void set_bounds_Injected(){} // RVA: 0x7FFD54CB7110
    }

    public class MeshCollider : Collider
    {
        public object sharedMesh;
        public object convex;
        public object cookingOptions;
        public object smoothSphereCollisions;
        public object skinWidth;
        public object inflateMesh;

        // ── Methods ──
        public void get_sharedMesh(){} // RVA: 0x7FFD54DB9A10
        public void set_sharedMesh(){} // RVA: 0x7FFD54DB9A60
        public void get_convex(){} // RVA: 0x7FFD54DB9AC0
        public void set_convex(){} // RVA: 0x7FFD54DB9B10
        public void get_cookingOptions(){} // RVA: 0x7FFD54DB9B70
        public void set_cookingOptions(){} // RVA: 0x7FFD54DB9BC0
        public void get_smoothSphereCollisions(){} // RVA: 0x7FFD500182C0
        public void set_smoothSphereCollisions(){} // RVA: 0x7FFD4E341310
        public void get_skinWidth(){} // RVA: 0x7FFD54CAADC0
        public void set_skinWidth(){} // RVA: 0x7FFD4E341310
        public void get_inflateMesh(){} // RVA: 0x7FFD506288B0
        public void set_inflateMesh(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class MeshFilter : Component
    {
        public object sharedMesh;
        public object mesh;

        // ── Methods ──
        public void DontStripMeshFilter(){} // RVA: 0x7FFD4E341310
        public void get_sharedMesh(){} // RVA: 0x7FFD54CAB180
        public void set_sharedMesh(){} // RVA: 0x7FFD54CAB1D0
        public void get_mesh(){} // RVA: 0x7FFD54CAB230
        public void set_mesh(){} // RVA: 0x7FFD54CAB280
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class MeshRenderer : Renderer
    {
        public object additionalVertexStreams;
        public object enlightenVertexStream;
        public object subMeshStartIndex;

        // ── Methods ──
        public void DontStripMeshRenderer(){} // RVA: 0x7FFD4E341310
        public void get_additionalVertexStreams(){} // RVA: 0x7FFD54CAC910
        public void set_additionalVertexStreams(){} // RVA: 0x7FFD54CAC960
        public void get_enlightenVertexStream(){} // RVA: 0x7FFD54CAC9C0
        public void set_enlightenVertexStream(){} // RVA: 0x7FFD54CACA10
        public void get_subMeshStartIndex(){} // RVA: 0x7FFD54CACA70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class MonoBehaviour : Behaviour
    {
        public sageKind._internal destroyCancellationToken; // 0x18

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD54CE2420
        public void RaiseCancellation(){} // RVA: 0x7FFD54CE2520
        public void IsInvoking(){} // RVA: 0x7FFD54CE2740 | overloaded x3
        public void CancelInvoke(){} // RVA: 0x7FFD54CE26E0 | overloaded x3
        public void Invoke(){} // RVA: 0x7FFD54CE2630
        public void InvokeRepeating(){} // RVA: 0x7FFD54CE2650
        public void StartCoroutine(){} // RVA: 0x7FFD54CE2910 | overloaded x3
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD54CE2A60
        public void StopCoroutine(){} // RVA: 0x7FFD54CE2D10 | overloaded x3
        public void StopAllCoroutines(){} // RVA: 0x7FFD54CE2D70
        public void get_useGUILayout(){} // RVA: 0x7FFD54CE2DC0
        public void set_useGUILayout(){} // RVA: 0x7FFD54CE2E10
        public void print(){} // RVA: 0x7FFD54CE2E70
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD54CE25E0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD54CE2590
        public void InvokeDelayed(){} // RVA: 0x7FFD54CE2EC0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD54CE2F40
        public void StartCoroutineManaged(){} // RVA: 0x7FFD54CE2F90
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD54CE3000
        public void StopCoroutineManaged(){} // RVA: 0x7FFD54CE3060
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD54CE30C0
        public void GetScriptClassName(){} // RVA: 0x7FFD54CE3120
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD54CE3170
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Motion : Object
    {
        public object averageDuration;
        public object averageAngularSpeed;
        public object averageSpeed;
        public object apparentSpeed;
        public object isLooping;
        public object isHumanMotion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C52D50
        public void get_averageDuration(){} // RVA: 0x7FFD54C52DA0
        public void get_averageAngularSpeed(){} // RVA: 0x7FFD54C52DF0
        public void get_averageSpeed(){} // RVA: 0x7FFD54C52E40
        public void get_apparentSpeed(){} // RVA: 0x7FFD54C52EB0
        public void get_isLooping(){} // RVA: 0x7FFD54C52F00
        public void get_isHumanMotion(){} // RVA: 0x7FFD54C52F50
        public void get_averageSpeed_Injected(){} // RVA: 0x7FFD54C52FA0
    }

}