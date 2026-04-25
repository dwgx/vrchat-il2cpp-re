// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 17
// Methods: 858

namespace ThirdParty.Unity.UnityEngine
{
    public class ManagedStreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateLoadFromStream(){} // RVA: 0x7FFAC98C2040
        public void ManagedStreamRead(){} // RVA: 0x7FFAC98C21B0
        public void ManagedStreamSeek(){} // RVA: 0x7FFAC98C22A0
        public void ManagedStreamLength(){} // RVA: 0x7FFAC98C2370
    }

    public class MatchTargetWeightMask : ValueType
    {
        public UnityEngine.Vector3 positionXYZWeight; // 0x10
        public float rotationWeight; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9828D90
        public void get_positionXYZWeight(){} // RVA: 0x7FFAC9811DA0
        public void set_positionXYZWeight(){} // RVA: 0x7FFAC530B6C0
        public void get_rotationWeight(){} // RVA: 0x7FFAC2F44D00
        public void set_rotationWeight(){} // RVA: 0x7FFAC4A9B8C0
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
        public void CreateWithShader(){} // RVA: 0x7FFAC98810B0
        public void CreateWithMaterial(){} // RVA: 0x7FFAC9881110
        public void CreateWithString(){} // RVA: 0x7FFAC9881170
        public void .ctor(){} // RVA: 0x7FFAC9881300 | overloaded x3
        public void get_shader(){} // RVA: 0x7FFAC9881390
        public void set_shader(){} // RVA: 0x7FFAC98813E0
        public void get_color(){} // RVA: 0x7FFAC9881440
        public void set_color(){} // RVA: 0x7FFAC9881560
        public void get_mainTexture(){} // RVA: 0x7FFAC9881670
        public void set_mainTexture(){} // RVA: 0x7FFAC9881760
        public void get_mainTextureOffset(){} // RVA: 0x7FFAC9881810
        public void set_mainTextureOffset(){} // RVA: 0x7FFAC98818C0
        public void get_mainTextureScale(){} // RVA: 0x7FFAC98819D0
        public void set_mainTextureScale(){} // RVA: 0x7FFAC9881A80
        public void GetFirstPropertyNameIdByAttribute(){} // RVA: 0x7FFAC9881B90
        public void HasProperty(){} // RVA: 0x7FFAC9881C50 | overloaded x2
        public void HasFloatImpl(){} // RVA: 0x7FFAC9881CF0
        public void HasFloat(){} // RVA: 0x7FFAC9881CF0 | overloaded x2
        public void HasInt(){} // RVA: 0x7FFAC9881CF0 | overloaded x2
        public void HasIntImpl(){} // RVA: 0x7FFAC9881DF0
        public void HasInteger(){} // RVA: 0x7FFAC9881DF0 | overloaded x2
        public void HasTextureImpl(){} // RVA: 0x7FFAC9881EF0
        public void HasTexture(){} // RVA: 0x7FFAC9881EF0 | overloaded x2
        public void HasMatrixImpl(){} // RVA: 0x7FFAC9881FF0
        public void HasMatrix(){} // RVA: 0x7FFAC9881FF0 | overloaded x2
        public void HasVectorImpl(){} // RVA: 0x7FFAC98820F0
        public void HasVector(){} // RVA: 0x7FFAC98820F0 | overloaded x2
        public void HasColor(){} // RVA: 0x7FFAC98820F0 | overloaded x2
        public void HasBufferImpl(){} // RVA: 0x7FFAC98821F0
        public void HasBuffer(){} // RVA: 0x7FFAC98821F0 | overloaded x2
        public void HasConstantBufferImpl(){} // RVA: 0x7FFAC98822F0
        public void HasConstantBuffer(){} // RVA: 0x7FFAC98822F0 | overloaded x2
        public void get_renderQueue(){} // RVA: 0x7FFAC98823F0
        public void set_renderQueue(){} // RVA: 0x7FFAC9882440
        public void EnableKeyword(){} // RVA: 0x7FFAC9882750 | overloaded x2
        public void DisableKeyword(){} // RVA: 0x7FFAC98827C0 | overloaded x2
        public void IsKeywordEnabled(){} // RVA: 0x7FFAC98828B0 | overloaded x2
        public void EnableLocalKeyword(){} // RVA: 0x7FFAC98825C0
        public void DisableLocalKeyword(){} // RVA: 0x7FFAC9882620
        public void SetLocalKeyword(){} // RVA: 0x7FFAC9882680
        public void IsLocalKeywordEnabled(){} // RVA: 0x7FFAC98826F0
        public void SetKeyword(){} // RVA: 0x7FFAC9882830
        public void GetEnabledKeywords(){} // RVA: 0x7FFAC9882920
        public void SetEnabledKeywords(){} // RVA: 0x7FFAC9882970
        public void get_enabledKeywords(){} // RVA: 0x7FFAC9882920
        public void set_enabledKeywords(){} // RVA: 0x7FFAC9882970
        public void get_globalIlluminationFlags(){} // RVA: 0x7FFAC98829D0
        public void set_globalIlluminationFlags(){} // RVA: 0x7FFAC9882A20
        public void get_doubleSidedGI(){} // RVA: 0x7FFAC9882A80
        public void set_doubleSidedGI(){} // RVA: 0x7FFAC9882AD0
        public void get_enableInstancing(){} // RVA: 0x7FFAC9882B30
        public void set_enableInstancing(){} // RVA: 0x7FFAC9882B80
        public void get_passCount(){} // RVA: 0x7FFAC9882BE0
        public void SetShaderPassEnabled(){} // RVA: 0x7FFAC9882C30
        public void GetShaderPassEnabled(){} // RVA: 0x7FFAC9882CA0
        public void GetPassName(){} // RVA: 0x7FFAC9882D00
        public void FindPass(){} // RVA: 0x7FFAC9882D60
        public void SetOverrideTag(){} // RVA: 0x7FFAC9882DC0
        public void GetTagImpl(){} // RVA: 0x7FFAC9882E30
        public void GetTag(){} // RVA: 0x7FFAC9882ED0 | overloaded x2
        public void Lerp(){} // RVA: 0x7FFAC9882F40
        public void SetPass(){} // RVA: 0x7FFAC9882FC0
        public void CopyPropertiesFromMaterial(){} // RVA: 0x7FFAC9883020
        public void CopyMatchingPropertiesFromMaterial(){} // RVA: 0x7FFAC9883080
        public void GetShaderKeywords(){} // RVA: 0x7FFAC98830E0
        public void SetShaderKeywords(){} // RVA: 0x7FFAC9883130
        public void get_shaderKeywords(){} // RVA: 0x7FFAC98830E0
        public void set_shaderKeywords(){} // RVA: 0x7FFAC9883130
        public void GetPropertyNamesImpl(){} // RVA: 0x7FFAC9883190
        public void ComputeCRC(){} // RVA: 0x7FFAC98831F0
        public void GetTexturePropertyNames(){} // RVA: 0x7FFAC98833A0 | overloaded x2
        public void GetTexturePropertyNameIDs(){} // RVA: 0x7FFAC9883450 | overloaded x2
        public void GetTexturePropertyNamesInternal(){} // RVA: 0x7FFAC98832E0
        public void GetTexturePropertyNameIDsInternal(){} // RVA: 0x7FFAC9883340
        public void SetIntImpl(){} // RVA: 0x7FFAC9883500
        public void SetFloatImpl(){} // RVA: 0x7FFAC9883570
        public void SetColorImpl(){} // RVA: 0x7FFAC98835E0
        public void SetMatrixImpl(){} // RVA: 0x7FFAC9883650
        public void SetTextureImpl(){} // RVA: 0x7FFAC98836C0
        public void SetRenderTextureImpl(){} // RVA: 0x7FFAC9883730
        public void SetBufferImpl(){} // RVA: 0x7FFAC98837B0
        public void SetGraphicsBufferImpl(){} // RVA: 0x7FFAC9883820
        public void GetIntImpl(){} // RVA: 0x7FFAC9883890
        public void GetFloatImpl(){} // RVA: 0x7FFAC98838F0
        public void GetColorImpl(){} // RVA: 0x7FFAC9883950
        public void GetMatrixImpl(){} // RVA: 0x7FFAC98839D0
        public void GetTextureImpl(){} // RVA: 0x7FFAC9883A60
        public void SetFloatArrayImpl(){} // RVA: 0x7FFAC9883AC0
        public void SetVectorArrayImpl(){} // RVA: 0x7FFAC9883B40
        public void SetColorArrayImpl(){} // RVA: 0x7FFAC9883BC0
        public void SetMatrixArrayImpl(){} // RVA: 0x7FFAC9883C40
        public void GetFloatArrayImpl(){} // RVA: 0x7FFAC9883CC0
        public void GetVectorArrayImpl(){} // RVA: 0x7FFAC9883D20
        public void GetColorArrayImpl(){} // RVA: 0x7FFAC9883D80
        public void GetMatrixArrayImpl(){} // RVA: 0x7FFAC9883DE0
        public void GetFloatArrayCountImpl(){} // RVA: 0x7FFAC9883E40
        public void GetVectorArrayCountImpl(){} // RVA: 0x7FFAC9883EA0
        public void GetColorArrayCountImpl(){} // RVA: 0x7FFAC9883F00
        public void GetMatrixArrayCountImpl(){} // RVA: 0x7FFAC9883F60
        public void ExtractFloatArrayImpl(){} // RVA: 0x7FFAC9883FC0
        public void ExtractVectorArrayImpl(){} // RVA: 0x7FFAC9884030
        public void ExtractColorArrayImpl(){} // RVA: 0x7FFAC98840A0
        public void ExtractMatrixArrayImpl(){} // RVA: 0x7FFAC9884110
        public void GetTextureScaleAndOffsetImpl(){} // RVA: 0x7FFAC9884180
        public void SetTextureOffsetImpl(){} // RVA: 0x7FFAC9884200
        public void SetTextureScaleImpl(){} // RVA: 0x7FFAC9884270
        public void SetFloatArray(){} // RVA: 0x7FFAC9885BB0 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x7FFAC9885FF0 | overloaded x5
        public void SetColorArray(){} // RVA: 0x7FFAC9885DD0 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x7FFAC9886210 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x7FFAC98848E0
        public void ExtractVectorArray(){} // RVA: 0x7FFAC9884AE0
        public void ExtractColorArray(){} // RVA: 0x7FFAC9884CE0
        public void ExtractMatrixArray(){} // RVA: 0x7FFAC9884EE0
        public void SetInt(){} // RVA: 0x7FFAC98851A0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFAC9883570 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFAC9883500 | overloaded x2
        public void SetColor(){} // RVA: 0x7FFAC9885430 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFAC98855A0 | overloaded x2
        public void SetMatrix(){} // RVA: 0x7FFAC9885730 | overloaded x2
        public void SetTexture(){} // RVA: 0x7FFAC9885900 | overloaded x4
        public void SetBuffer(){} // RVA: 0x7FFAC9885910 | overloaded x2
        public void GetInt(){} // RVA: 0x7FFAC98862F0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFAC98838F0 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFAC9883890 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFAC9886560 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFAC98866C0 | overloaded x2
        public void GetMatrix(){} // RVA: 0x7FFAC9886860 | overloaded x2
        public void GetTexture(){} // RVA: 0x7FFAC9883A60 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x7FFAC9886EC0 | overloaded x4
        public void GetColorArray(){} // RVA: 0x7FFAC9886F50 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x7FFAC9886FE0 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x7FFAC9887070 | overloaded x4
        public void SetTextureOffset(){} // RVA: 0x7FFAC9884200 | overloaded x2
        public void SetTextureScale(){} // RVA: 0x7FFAC9884270 | overloaded x2
        public void GetTextureOffset(){} // RVA: 0x7FFAC9887270 | overloaded x2
        public void GetTextureScale(){} // RVA: 0x7FFAC9887360 | overloaded x2
        public void GetPropertyNames(){} // RVA: 0x7FFAC9883190
        public void EnableLocalKeyword_Injected(){} // RVA: 0x7FFAC98873E0
        public void DisableLocalKeyword_Injected(){} // RVA: 0x7FFAC9887440
        public void SetLocalKeyword_Injected(){} // RVA: 0x7FFAC98874A0
        public void IsLocalKeywordEnabled_Injected(){} // RVA: 0x7FFAC9887510
        public void SetColorImpl_Injected(){} // RVA: 0x7FFAC9887570
        public void SetMatrixImpl_Injected(){} // RVA: 0x7FFAC98875E0
        public void GetColorImpl_Injected(){} // RVA: 0x7FFAC9887650
        public void GetMatrixImpl_Injected(){} // RVA: 0x7FFAC98876C0
        public void GetTextureScaleAndOffsetImpl_Injected(){} // RVA: 0x7FFAC9887730
        public void SetTextureOffsetImpl_Injected(){} // RVA: 0x7FFAC98877A0
        public void SetTextureScaleImpl_Injected(){} // RVA: 0x7FFAC9887810
    }

    public class MaterialPropertyBlock : Object
    {
        public UIntPtr isEmpty; // 0x10

        // ── Methods ──
        public void GetIntImpl(){} // RVA: 0x7FFAC9876550
        public void GetFloatImpl(){} // RVA: 0x7FFAC98765B0
        public void GetVectorImpl(){} // RVA: 0x7FFAC9876610
        public void GetColorImpl(){} // RVA: 0x7FFAC9876690
        public void GetMatrixImpl(){} // RVA: 0x7FFAC9876710
        public void GetTextureImpl(){} // RVA: 0x7FFAC98767A0
        public void HasPropertyImpl(){} // RVA: 0x7FFAC9876800
        public void HasFloatImpl(){} // RVA: 0x7FFAC9876860
        public void HasIntImpl(){} // RVA: 0x7FFAC98768C0
        public void HasTextureImpl(){} // RVA: 0x7FFAC9876920
        public void HasMatrixImpl(){} // RVA: 0x7FFAC9876980
        public void HasVectorImpl(){} // RVA: 0x7FFAC98769E0
        public void HasBufferImpl(){} // RVA: 0x7FFAC9876A40
        public void HasConstantBufferImpl(){} // RVA: 0x7FFAC9876AA0
        public void SetIntImpl(){} // RVA: 0x7FFAC9876B00
        public void SetFloatImpl(){} // RVA: 0x7FFAC9876B70
        public void SetVectorImpl(){} // RVA: 0x7FFAC9876BE0
        public void SetColorImpl(){} // RVA: 0x7FFAC9876C50
        public void SetMatrixImpl(){} // RVA: 0x7FFAC9876CC0
        public void SetTextureImpl(){} // RVA: 0x7FFAC9876D30
        public void SetRenderTextureImpl(){} // RVA: 0x7FFAC9876DA0
        public void SetBufferImpl(){} // RVA: 0x7FFAC9876E20
        public void SetGraphicsBufferImpl(){} // RVA: 0x7FFAC9876E90
        public void SetFloatArrayImpl(){} // RVA: 0x7FFAC9876F00
        public void SetVectorArrayImpl(){} // RVA: 0x7FFAC9876F80
        public void SetMatrixArrayImpl(){} // RVA: 0x7FFAC9877000
        public void GetFloatArrayImpl(){} // RVA: 0x7FFAC9877080
        public void GetVectorArrayImpl(){} // RVA: 0x7FFAC98770E0
        public void GetMatrixArrayImpl(){} // RVA: 0x7FFAC9877140
        public void GetFloatArrayCountImpl(){} // RVA: 0x7FFAC98771A0
        public void GetVectorArrayCountImpl(){} // RVA: 0x7FFAC9877200
        public void GetMatrixArrayCountImpl(){} // RVA: 0x7FFAC9877260
        public void ExtractFloatArrayImpl(){} // RVA: 0x7FFAC98772C0
        public void ExtractVectorArrayImpl(){} // RVA: 0x7FFAC9877330
        public void ExtractMatrixArrayImpl(){} // RVA: 0x7FFAC98773A0
        public void Internal_CopySHCoefficientArraysFrom(){} // RVA: 0x7FFAC9877410
        public void Internal_CopyProbeOcclusionArrayFrom(){} // RVA: 0x7FFAC98774A0
        public void CreateImpl(){} // RVA: 0x7FFAC9877530
        public void DestroyImpl(){} // RVA: 0x7FFAC9877580
        public void get_isEmpty(){} // RVA: 0x7FFAC98775D0
        public void Clear(){} // RVA: 0x7FFAC9877680 | overloaded x2
        public void SetFloatArray(){} // RVA: 0x7FFAC9878CE0 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x7FFAC9878F00 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x7FFAC9879120 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x7FFAC9877B60
        public void ExtractVectorArray(){} // RVA: 0x7FFAC9877D60
        public void ExtractMatrixArray(){} // RVA: 0x7FFAC9877F60
        public void .ctor(){} // RVA: 0x7FFAC9878160
        public void Finalize(){} // RVA: 0x7FFAC98781B0
        public void Dispose(){} // RVA: 0x7FFAC9878290
        public void SetInt(){} // RVA: 0x7FFAC9878400 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFAC9876B70 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFAC9876B00 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFAC9878690 | overloaded x2
        public void SetColor(){} // RVA: 0x7FFAC98787C0 | overloaded x2
        public void SetMatrix(){} // RVA: 0x7FFAC9878910 | overloaded x2
        public void SetBuffer(){} // RVA: 0x7FFAC9876E90 | overloaded x2
        public void SetTexture(){} // RVA: 0x7FFAC9878AE0 | overloaded x4
        public void HasProperty(){} // RVA: 0x7FFAC9876800 | overloaded x2
        public void HasInt(){} // RVA: 0x7FFAC9876860 | overloaded x2
        public void HasFloat(){} // RVA: 0x7FFAC9876860 | overloaded x2
        public void HasInteger(){} // RVA: 0x7FFAC98768C0 | overloaded x2
        public void HasTexture(){} // RVA: 0x7FFAC9876920 | overloaded x2
        public void HasMatrix(){} // RVA: 0x7FFAC9876980 | overloaded x2
        public void HasVector(){} // RVA: 0x7FFAC98769E0 | overloaded x2
        public void HasColor(){} // RVA: 0x7FFAC98769E0 | overloaded x2
        public void HasBuffer(){} // RVA: 0x7FFAC9876A40 | overloaded x2
        public void HasConstantBuffer(){} // RVA: 0x7FFAC9876AA0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFAC98765B0 | overloaded x2
        public void GetInt(){} // RVA: 0x7FFAC98797A0 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFAC9876550 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFAC9879970 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFAC9879AD0 | overloaded x2
        public void GetMatrix(){} // RVA: 0x7FFAC9879C70 | overloaded x2
        public void GetTexture(){} // RVA: 0x7FFAC98767A0 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x7FFAC987A1B0 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x7FFAC987A240 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x7FFAC987A2D0 | overloaded x4
        public void CopySHCoefficientArraysFrom(){} // RVA: 0x7FFAC987A4B0 | overloaded x4
        public void CopyProbeOcclusionArrayFrom(){} // RVA: 0x7FFAC987A8F0 | overloaded x4
        public void GetVectorImpl_Injected(){} // RVA: 0x7FFAC987AB60
        public void GetColorImpl_Injected(){} // RVA: 0x7FFAC987ABD0
        public void GetMatrixImpl_Injected(){} // RVA: 0x7FFAC987AC40
        public void SetVectorImpl_Injected(){} // RVA: 0x7FFAC987ACB0
        public void SetColorImpl_Injected(){} // RVA: 0x7FFAC987AD20
        public void SetMatrixImpl_Injected(){} // RVA: 0x7FFAC987AD90
    }

    public class Mathf : ValueType
    {
        public float Epsilon;

        // ── Methods ──
        public void ClosestPowerOfTwo(){} // RVA: 0x7FFAC98B0D00
        public void IsPowerOfTwo(){} // RVA: 0x7FFAC98B0D50
        public void NextPowerOfTwo(){} // RVA: 0x7FFAC98B0DA0
        public void GammaToLinearSpace(){} // RVA: 0x7FFAC98B0DF0
        public void LinearToGammaSpace(){} // RVA: 0x7FFAC98B0E50
        public void CorrelatedColorTemperatureToRGB(){} // RVA: 0x7FFAC98B0EB0
        public void FloatToHalf(){} // RVA: 0x7FFAC98B0F20
        public void HalfToFloat(){} // RVA: 0x7FFAC98B0F80
        public void PerlinNoise(){} // RVA: 0x7FFAC98B0FD0
        public void PerlinNoise1D(){} // RVA: 0x7FFAC98B1040
        public void Sin(){} // RVA: 0x7FFAC98B10A0
        public void Cos(){} // RVA: 0x7FFAC98B1100
        public void Tan(){} // RVA: 0x7FFAC98B1160
        public void Asin(){} // RVA: 0x7FFAC98B11C0
        public void Acos(){} // RVA: 0x7FFAC98B1220
        public void Atan(){} // RVA: 0x7FFAC98B1280
        public void Atan2(){} // RVA: 0x7FFAC98B12E0
        public void Sqrt(){} // RVA: 0x7FFAC98B1350
        public void Abs(){} // RVA: 0x7FFAC98B1430 | overloaded x2
        public void Min(){} // RVA: 0x7FFAC98B14E0 | overloaded x4
        public void Max(){} // RVA: 0x7FFAC98B1550 | overloaded x4
        public void Pow(){} // RVA: 0x7FFAC98B15B0
        public void Exp(){} // RVA: 0x7FFAC98B1630
        public void Log(){} // RVA: 0x7FFAC98B1710 | overloaded x2
        public void Log10(){} // RVA: 0x7FFAC98B1770
        public void Ceil(){} // RVA: 0x7FFAC98B17D0
        public void Floor(){} // RVA: 0x7FFAC98B1830
        public void Round(){} // RVA: 0x7FFAC98B1890
        public void CeilToInt(){} // RVA: 0x7FFAC98B18F0
        public void FloorToInt(){} // RVA: 0x7FFAC98B1950
        public void RoundToInt(){} // RVA: 0x7FFAC98B19B0
        public void Sign(){} // RVA: 0x7FFAC98B1A10
        public void Clamp(){} // RVA: 0x7FFAC2F45AE0 | overloaded x2
        public void Clamp01(){} // RVA: 0x7FFAC2F45DC0
        public void Lerp(){} // RVA: 0x7FFAC2F44F40
        public void LerpUnclamped(){} // RVA: 0x7FFAC98B1A30
        public void LerpAngle(){} // RVA: 0x7FFAC2F45160
        public void MoveTowards(){} // RVA: 0x7FFAC2F45A60
        public void MoveTowardsAngle(){} // RVA: 0x7FFAC98B1A50
        public void SmoothStep(){} // RVA: 0x7FFAC364E290
        public void Gamma(){} // RVA: 0x7FFAC98B1AF0
        public void Approximately(){} // RVA: 0x7FFAC98B1B50
        public void SmoothDamp(){} // RVA: 0x7FFAC98B1C90 | overloaded x3
        public void SmoothDampAngle(){} // RVA: 0x7FFAC451BC40 | overloaded x3
        public void Repeat(){} // RVA: 0x7FFAC2F45380
        public void PingPong(){} // RVA: 0x7FFAC3AB0710
        public void InverseLerp(){} // RVA: 0x7FFAC2F44F00
        public void DeltaAngle(){} // RVA: 0x7FFAC2F6E0F0
        public void ClampToFloat(){} // RVA: 0x7FFAC98B1F80
        public void ClampToInt(){} // RVA: 0x7FFAC98B1FE0
        public void ClampToUInt(){} // RVA: 0x7FFAC98B2000
        public void GetNumberOfDecimalsForMinimumDifference(){} // RVA: 0x7FFAC98B2020
        public void RoundBasedOnMinimumDifference(){} // RVA: 0x7FFAC98B20C0
        public void DiscardLeastSignificantDecimal(){} // RVA: 0x7FFAC98B21F0
        public void .cctor(){} // RVA: 0x7FFAC98B2290
        public void CorrelatedColorTemperatureToRGB_Injected(){} // RVA: 0x7FFAC98B2310
    }

    public class Matrix4x4 : ValueType
    {
        public float rotation; // 0x10
        public float lossyScale; // 0x14
        public float isIdentity; // 0x18
        public float determinant; // 0x1C
        public float decomposeProjection; // 0x20
        public float inverse; // 0x24
        public float transpose; // 0x28
        public float Item; // 0x2C
        public float Item; // 0x30
        public float zero; // 0x34
        public float identity; // 0x38
        public float m32; // 0x3C
        public float m03; // 0x40
        public float m13; // 0x44
        public float m23; // 0x48
        public float m33; // 0x4C
        public UnityEngine.Matrix4x4 zeroMatrix;
        public UnityEngine.Matrix4x4 identityMatrix; // 0x40

        // ── Methods ──
        public void GetRotation(){} // RVA: 0x7FFAC98AA6E0
        public void GetLossyScale(){} // RVA: 0x7FFAC98AA750
        public void IsIdentity(){} // RVA: 0x7FFAC98AA7C0
        public void GetDeterminant(){} // RVA: 0x7FFAC98AA810
        public void DecomposeProjection(){} // RVA: 0x7FFAC98AA860
        public void get_rotation(){} // RVA: 0x7FFAC98AA8D0
        public void get_lossyScale(){} // RVA: 0x7FFAC98AA950
        public void get_isIdentity(){} // RVA: 0x7FFAC98AA7C0
        public void get_determinant(){} // RVA: 0x7FFAC98AA810
        public void get_decomposeProjection(){} // RVA: 0x7FFAC98AA9E0
        public void ValidTRS(){} // RVA: 0x7FFAC98AAA70
        public void Determinant(){} // RVA: 0x7FFAC98AAAC0
        public void TRS(){} // RVA: 0x7FFAC98AAB10
        public void SetTRS(){} // RVA: 0x7FFAC98AABB0
        public void Inverse3DAffine(){} // RVA: 0x7FFAC98AAC90
        public void Inverse(){} // RVA: 0x7FFAC98AACF0
        public void get_inverse(){} // RVA: 0x7FFAC98AAD70
        public void Transpose(){} // RVA: 0x7FFAC98AAE40
        public void get_transpose(){} // RVA: 0x7FFAC98AAEC0
        public void Ortho(){} // RVA: 0x7FFAC98AAF90
        public void Perspective(){} // RVA: 0x7FFAC98AB060
        public void LookAt(){} // RVA: 0x7FFAC98AB110
        public void Frustum(){} // RVA: 0x7FFAC98AB280 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC98AB3D0
        public void get_Item(){} // RVA: 0x7FFAC98AB460 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC98AB5C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC5DA2890
        public void Equals(){} // RVA: 0x7FFAC4F2F130 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFAC98ABD10 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC98ABE30
        public void op_Inequality(){} // RVA: 0x7FFAC98ABF70
        public void GetColumn(){} // RVA: 0x7FFAC98ABFE0
        public void GetRow(){} // RVA: 0x7FFAC98AC0B0
        public void GetPosition(){} // RVA: 0x7FFAC98AC1A0
        public void SetColumn(){} // RVA: 0x7FFAC98AC1C0
        public void SetRow(){} // RVA: 0x7FFAC98AC240
        public void MultiplyPoint(){} // RVA: 0x7FFAC98AC2B0
        public void MultiplyPoint3x4(){} // RVA: 0x7FFAC98AC3A0
        public void MultiplyVector(){} // RVA: 0x7FFAC98AC440
        public void TransformPlane(){} // RVA: 0x7FFAC98AC4D0
        public void Scale(){} // RVA: 0x7FFAC98AC780
        public void Translate(){} // RVA: 0x7FFAC98AC820
        public void Rotate(){} // RVA: 0x7FFAC98AC8C0
        public void get_zero(){} // RVA: 0x7FFAC98ACA70
        public void get_identity(){} // RVA: 0x7FFAC98ACAD0
        public void ToString(){} // RVA: 0x7FFAC98ACB50 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC98AD190
        public void GetRotation_Injected(){} // RVA: 0x7FFAC98AD2B0
        public void GetLossyScale_Injected(){} // RVA: 0x7FFAC98AD310
        public void IsIdentity_Injected(){} // RVA: 0x7FFAC98AA7C0
        public void GetDeterminant_Injected(){} // RVA: 0x7FFAC98AA810
        public void DecomposeProjection_Injected(){} // RVA: 0x7FFAC98AD370
        public void ValidTRS_Injected(){} // RVA: 0x7FFAC98AAA70
        public void TRS_Injected(){} // RVA: 0x7FFAC98AD3D0
        public void Inverse3DAffine_Injected(){} // RVA: 0x7FFAC98AD450
        public void Inverse_Injected(){} // RVA: 0x7FFAC98AD4B0
        public void Transpose_Injected(){} // RVA: 0x7FFAC98AD510
        public void Ortho_Injected(){} // RVA: 0x7FFAC98AD570
        public void Perspective_Injected(){} // RVA: 0x7FFAC98AD610
        public void LookAt_Injected(){} // RVA: 0x7FFAC98AD6B0
        public void Frustum_Injected(){} // RVA: 0x7FFAC98AD730
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
        public void Internal_Create(){} // RVA: 0x7FFAC988D2F0
        public void .ctor(){} // RVA: 0x7FFAC988D340
        public void FromInstanceID(){} // RVA: 0x7FFAC988D3D0
        public void get_indexFormat(){} // RVA: 0x7FFAC988D420
        public void set_indexFormat(){} // RVA: 0x7FFAC988D470
        public void SetIndexBufferParams(){} // RVA: 0x7FFAC988D4D0
        public void InternalSetIndexBufferData(){} // RVA: 0x7FFAC988D540
        public void SetVertexBufferParamsFromArray(){} // RVA: 0x7FFAC988D5D0
        public void GetVertexAttributesAlloc(){} // RVA: 0x7FFAC988D640
        public void GetVertexAttributesArray(){} // RVA: 0x7FFAC988D690
        public void GetVertexAttributesList(){} // RVA: 0x7FFAC988D6F0
        public void GetVertexAttributeCountImpl(){} // RVA: 0x7FFAC988D750
        public void GetVertexAttribute(){} // RVA: 0x7FFAC988D7A0
        public void GetIndexStartImpl(){} // RVA: 0x7FFAC988D820
        public void GetIndexCountImpl(){} // RVA: 0x7FFAC988D880
        public void GetTrianglesCountImpl(){} // RVA: 0x7FFAC988D8E0
        public void GetBaseVertexImpl(){} // RVA: 0x7FFAC988D940
        public void GetTrianglesImpl(){} // RVA: 0x7FFAC988D9A0
        public void GetIndicesImpl(){} // RVA: 0x7FFAC988DA10
        public void SetIndicesImpl(){} // RVA: 0x7FFAC988DA80
        public void GetTrianglesNonAllocImpl(){} // RVA: 0x7FFAC988DB10
        public void GetTrianglesNonAllocImpl16(){} // RVA: 0x7FFAC988DB90
        public void GetIndicesNonAllocImpl(){} // RVA: 0x7FFAC988DC10
        public void GetIndicesNonAllocImpl16(){} // RVA: 0x7FFAC988DC90
        public void PrintErrorCantAccessChannel(){} // RVA: 0x7FFAC988DD10
        public void HasVertexAttribute(){} // RVA: 0x7FFAC988DD70
        public void GetVertexAttributeDimension(){} // RVA: 0x7FFAC988DDD0
        public void GetVertexAttributeFormat(){} // RVA: 0x7FFAC988DE30
        public void GetVertexAttributeStream(){} // RVA: 0x7FFAC988DE90
        public void GetVertexAttributeOffset(){} // RVA: 0x7FFAC988DEF0
        public void SetArrayForChannelImpl(){} // RVA: 0x7FFAC988DF50
        public void SetNativeArrayForChannelImpl(){} // RVA: 0x7FFAC988DFD0
        public void GetAllocArrayFromChannelImpl(){} // RVA: 0x7FFAC988E050
        public void GetArrayFromChannelImpl(){} // RVA: 0x7FFAC988E0D0
        public void get_vertexBufferCount(){} // RVA: 0x7FFAC988E150
        public void GetVertexBufferStride(){} // RVA: 0x7FFAC988E1A0
        public void get_blendShapeCount(){} // RVA: 0x7FFAC988E200
        public void ClearBlendShapes(){} // RVA: 0x7FFAC988E250
        public void GetBlendShapeName(){} // RVA: 0x7FFAC988E2A0
        public void GetBlendShapeIndex(){} // RVA: 0x7FFAC988E300
        public void GetBlendShapeFrameCount(){} // RVA: 0x7FFAC988E360
        public void GetBlendShapeFrameWeight(){} // RVA: 0x7FFAC988E3C0
        public void GetBlendShapeFrameVertices(){} // RVA: 0x7FFAC988E430
        public void AddBlendShapeFrame(){} // RVA: 0x7FFAC988E4B0
        public void GetBlendShapeOffsetInternal(){} // RVA: 0x7FFAC988E540
        public void HasBoneWeights(){} // RVA: 0x7FFAC988E5C0
        public void GetBoneWeightsImpl(){} // RVA: 0x7FFAC988E610
        public void SetBoneWeightsImpl(){} // RVA: 0x7FFAC988E660
        public void GetBoneWeightBufferLayoutInternal(){} // RVA: 0x7FFAC988E6C0
        public void get_bindposeCount(){} // RVA: 0x7FFAC988E710
        public void get_bindposes(){} // RVA: 0x7FFAC988E760
        public void set_bindposes(){} // RVA: 0x7FFAC988E7B0
        public void GetBoneWeightsNonAllocImpl(){} // RVA: 0x7FFAC988E810
        public void GetBindposesNonAllocImpl(){} // RVA: 0x7FFAC988E870
        public void get_isReadable(){} // RVA: 0x7FFAC988E8D0
        public void get_canAccess(){} // RVA: 0x7FFAC988E920
        public void get_vertexCount(){} // RVA: 0x7FFAC988E970
        public void get_subMeshCount(){} // RVA: 0x7FFAC988E9C0
        public void set_subMeshCount(){} // RVA: 0x7FFAC988EA10
        public void SetSubMesh(){} // RVA: 0x7FFAC988EA70
        public void GetSubMesh(){} // RVA: 0x7FFAC988EAF0
        public void SetAllSubMeshesAtOnceFromArray(){} // RVA: 0x7FFAC988EB70
        public void get_bounds(){} // RVA: 0x7FFAC988EC00
        public void set_bounds(){} // RVA: 0x7FFAC988EC70
        public void ClearImpl(){} // RVA: 0x7FFAC988ECD0
        public void RecalculateBoundsImpl(){} // RVA: 0x7FFAC988ED30
        public void RecalculateNormalsImpl(){} // RVA: 0x7FFAC988ED90
        public void RecalculateTangentsImpl(){} // RVA: 0x7FFAC988EDF0
        public void MarkDynamicImpl(){} // RVA: 0x7FFAC988EE50
        public void MarkModified(){} // RVA: 0x7FFAC988EEA0
        public void DiscardReadableDataImpl(){} // RVA: 0x7FFAC988EEF0
        public void UploadMeshDataImpl(){} // RVA: 0x7FFAC988EF40
        public void GetTopologyImpl(){} // RVA: 0x7FFAC988EFA0
        public void RecalculateUVDistributionMetricImpl(){} // RVA: 0x7FFAC988F000
        public void RecalculateUVDistributionMetricsImpl(){} // RVA: 0x7FFAC988F070
        public void GetUVDistributionMetric(){} // RVA: 0x7FFAC988F0D0
        public void CombineMeshesImpl(){} // RVA: 0x7FFAC988F130
        public void OptimizeImpl(){} // RVA: 0x7FFAC988F1C0
        public void OptimizeIndexBuffersImpl(){} // RVA: 0x7FFAC988F210
        public void OptimizeReorderVertexBufferImpl(){} // RVA: 0x7FFAC988F260
        public void GetUVChannel(){} // RVA: 0x7FFAC988F2B0
        public void DefaultDimensionForChannel(){} // RVA: 0x7FFAC988F340
        public void GetAllocArrayFromChannel(){} // RVA: 0x7FFAC2C67DE0 | overloaded x2
        public void SetSizedArrayForChannel(){} // RVA: 0x7FFAC988F3F0
        public void SetSizedNativeArrayForChannel(){} // RVA: 0x7FFAC988F7B0
        public void SetArrayForChannel(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetListForChannel(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetListForChannel(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void get_vertices(){} // RVA: 0x7FFAC988FB70
        public void set_vertices(){} // RVA: 0x7FFAC988FBE0
        public void get_normals(){} // RVA: 0x7FFAC988FC70
        public void set_normals(){} // RVA: 0x7FFAC988FCF0
        public void get_tangents(){} // RVA: 0x7FFAC988FD80
        public void set_tangents(){} // RVA: 0x7FFAC988FE00
        public void get_uv(){} // RVA: 0x7FFAC988FE90
        public void set_uv(){} // RVA: 0x7FFAC988FF10
        public void get_uv2(){} // RVA: 0x7FFAC988FFA0
        public void set_uv2(){} // RVA: 0x7FFAC9890020
        public void get_uv3(){} // RVA: 0x7FFAC98900B0
        public void set_uv3(){} // RVA: 0x7FFAC9890130
        public void get_uv4(){} // RVA: 0x7FFAC98901C0
        public void set_uv4(){} // RVA: 0x7FFAC9890240
        public void get_uv5(){} // RVA: 0x7FFAC98902D0
        public void set_uv5(){} // RVA: 0x7FFAC9890350
        public void get_uv6(){} // RVA: 0x7FFAC98903E0
        public void set_uv6(){} // RVA: 0x7FFAC9890460
        public void get_uv7(){} // RVA: 0x7FFAC98904F0
        public void set_uv7(){} // RVA: 0x7FFAC9890570
        public void get_uv8(){} // RVA: 0x7FFAC9890600
        public void set_uv8(){} // RVA: 0x7FFAC9890680
        public void get_colors(){} // RVA: 0x7FFAC9890710
        public void set_colors(){} // RVA: 0x7FFAC9890790
        public void get_colors32(){} // RVA: 0x7FFAC9890820
        public void set_colors32(){} // RVA: 0x7FFAC9890880
        public void GetVertices(){} // RVA: 0x7FFAC9890910
        public void SetVertices(){} // RVA: 0x7FFAC2E8DC40 | overloaded x9
        public void GetNormals(){} // RVA: 0x7FFAC9890D50
        public void SetNormals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x9
        public void GetTangents(){} // RVA: 0x7FFAC98911B0
        public void SetTangents(){} // RVA: 0x7FFAC9891590 | overloaded x6
        public void GetColors(){} // RVA: 0x7FFAC9891A90 | overloaded x2
        public void SetColors(){} // RVA: 0x7FFAC9891E80 | overloaded x12
        public void SetUvsImpl(){} // RVA: 0x7FFAC9892630 | overloaded x2
        public void SetUVs(){} // RVA: 0x7FFAC2E8DC40 | overloaded x21
        public void GetUVsImpl(){} // RVA: 0x7FFAC2E8DC40
        public void GetUVs(){} // RVA: 0x7FFAC9892D40 | overloaded x3
        public void get_vertexAttributeCount(){} // RVA: 0x7FFAC988D750
        public void GetVertexAttributes(){} // RVA: 0x7FFAC988D6F0 | overloaded x3
        public void SetVertexBufferParams(){} // RVA: 0x7FFAC988D5D0
        public void GetBlendShapeBufferRange(){} // RVA: 0x7FFAC9892F80
        public void PrintErrorCantAccessIndices(){} // RVA: 0x7FFAC98930C0
        public void CheckCanAccessSubmesh(){} // RVA: 0x7FFAC9893180
        public void CheckCanAccessSubmeshTriangles(){} // RVA: 0x7FFAC9893350
        public void CheckCanAccessSubmeshIndices(){} // RVA: 0x7FFAC9893360
        public void get_triangles(){} // RVA: 0x7FFAC9893370
        public void set_triangles(){} // RVA: 0x7FFAC9893450
        public void GetTriangles(){} // RVA: 0x7FFAC98937E0 | overloaded x5
        public void GetIndices(){} // RVA: 0x7FFAC9893CB0 | overloaded x5
        public void SetIndexBufferData(){} // RVA: 0x7FFAC2E8DC40
        public void GetIndexStart(){} // RVA: 0x7FFAC9893E90
        public void GetIndexCount(){} // RVA: 0x7FFAC9893F90
        public void GetBaseVertex(){} // RVA: 0x7FFAC9894090
        public void CheckIndicesArrayRange(){} // RVA: 0x7FFAC9894190
        public void SetTrianglesImpl(){} // RVA: 0x7FFAC9894400
        public void SetTriangles(){} // RVA: 0x7FFAC9894CD0 | overloaded x12
        public void SetIndices(){} // RVA: 0x7FFAC9895500 | overloaded x10
        public void SetSubMeshes(){} // RVA: 0x7FFAC9895AB0 | overloaded x4
        public void GetBindposes(){} // RVA: 0x7FFAC9895B50
        public void GetBoneWeights(){} // RVA: 0x7FFAC9895CA0
        public void get_boneWeights(){} // RVA: 0x7FFAC988E610
        public void set_boneWeights(){} // RVA: 0x7FFAC988E660
        public void get_skinWeightBufferLayout(){} // RVA: 0x7FFAC988E6C0
        public void Clear(){} // RVA: 0x7FFAC9895FD0 | overloaded x2
        public void RecalculateBounds(){} // RVA: 0x7FFAC9896060 | overloaded x2
        public void RecalculateNormals(){} // RVA: 0x7FFAC98961C0 | overloaded x2
        public void RecalculateTangents(){} // RVA: 0x7FFAC9896320 | overloaded x2
        public void RecalculateUVDistributionMetric(){} // RVA: 0x7FFAC9896480
        public void RecalculateUVDistributionMetrics(){} // RVA: 0x7FFAC9896600
        public void MarkDynamic(){} // RVA: 0x7FFAC9896760
        public void DiscardReadableData(){} // RVA: 0x7FFAC9896800
        public void UploadMeshData(){} // RVA: 0x7FFAC98968A0
        public void Optimize(){} // RVA: 0x7FFAC9896950
        public void OptimizeIndexBuffers(){} // RVA: 0x7FFAC9896AA0
        public void OptimizeReorderVertexBuffer(){} // RVA: 0x7FFAC9896BF0
        public void GetTopology(){} // RVA: 0x7FFAC9896D40
        public void CombineMeshes(){} // RVA: 0x7FFAC9896EB0 | overloaded x4
        public void GetVertexAttribute_Injected(){} // RVA: 0x7FFAC9896EE0
        public void GetBlendShapeOffsetInternal_Injected(){} // RVA: 0x7FFAC9896F50
        public void SetSubMesh_Injected(){} // RVA: 0x7FFAC9896FC0
        public void GetSubMesh_Injected(){} // RVA: 0x7FFAC9897040
        public void get_bounds_Injected(){} // RVA: 0x7FFAC98970B0
        public void set_bounds_Injected(){} // RVA: 0x7FFAC9897110
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
        public void get_sharedMesh(){} // RVA: 0x7FFAC9999A10
        public void set_sharedMesh(){} // RVA: 0x7FFAC9999A60
        public void get_convex(){} // RVA: 0x7FFAC9999AC0
        public void set_convex(){} // RVA: 0x7FFAC9999B10
        public void get_cookingOptions(){} // RVA: 0x7FFAC9999B70
        public void set_cookingOptions(){} // RVA: 0x7FFAC9999BC0
        public void get_smoothSphereCollisions(){} // RVA: 0x7FFAC4BF82C0
        public void set_smoothSphereCollisions(){} // RVA: 0x7FFAC2F21310
        public void get_skinWidth(){} // RVA: 0x7FFAC988ADC0
        public void set_skinWidth(){} // RVA: 0x7FFAC2F21310
        public void get_inflateMesh(){} // RVA: 0x7FFAC52088B0
        public void set_inflateMesh(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class MeshFilter : Component
    {
        public object sharedMesh;
        public object mesh;

        // ── Methods ──
        public void DontStripMeshFilter(){} // RVA: 0x7FFAC2F21310
        public void get_sharedMesh(){} // RVA: 0x7FFAC988B180
        public void set_sharedMesh(){} // RVA: 0x7FFAC988B1D0
        public void get_mesh(){} // RVA: 0x7FFAC988B230
        public void set_mesh(){} // RVA: 0x7FFAC988B280
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class MeshRenderer : Renderer
    {
        public object additionalVertexStreams;
        public object enlightenVertexStream;
        public object subMeshStartIndex;

        // ── Methods ──
        public void DontStripMeshRenderer(){} // RVA: 0x7FFAC2F21310
        public void get_additionalVertexStreams(){} // RVA: 0x7FFAC988C910
        public void set_additionalVertexStreams(){} // RVA: 0x7FFAC988C960
        public void get_enlightenVertexStream(){} // RVA: 0x7FFAC988C9C0
        public void set_enlightenVertexStream(){} // RVA: 0x7FFAC988CA10
        public void get_subMeshStartIndex(){} // RVA: 0x7FFAC988CA70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Microphone : Object
    {
        public object devices;

        // ── Methods ──
        public void GetMicrophoneDeviceIDFromName(){} // RVA: 0x7FFAC9849BD0
        public void StartRecord(){} // RVA: 0x7FFAC9849C20
        public void EndRecord(){} // RVA: 0x7FFAC9849CA0
        public void IsRecording(){} // RVA: 0x7FFAC984A1B0 | overloaded x2
        public void GetRecordPosition(){} // RVA: 0x7FFAC9849D40
        public void GetDeviceCaps(){} // RVA: 0x7FFAC984A2F0 | overloaded x2
        public void Start(){} // RVA: 0x7FFAC9849E00
        public void End(){} // RVA: 0x7FFAC984A0C0
        public void get_devices(){} // RVA: 0x7FFAC984A160
        public void GetPosition(){} // RVA: 0x7FFAC984A250
    }

    public class MinAttribute : PropertyAttribute
    {
        public float min; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC304B330
    }

    public class MissingReferenceException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98C4A30 | overloaded x3
    }

    public class ModifiableContactPair : ValueType
    {
        public UIntPtr actor; // 0x10
        public UIntPtr otherActor; // 0x18
        public UIntPtr shape; // 0x20
        public UIntPtr otherShape; // 0x28
        public UnityEngine.Quaternion rotation; // 0x30
        public UnityEngine.Vector3 position; // 0x40
        public UnityEngine.Quaternion otherRotation; // 0x4C
        public UnityEngine.Vector3 otherPosition; // 0x5C
        public int numContacts; // 0x68
        public UIntPtr contacts; // 0x70
    }

    public class MonoBehaviour : Behaviour
    {
        public System.Threading.CancellationTokenSource destroyCancellationToken; // 0x18

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC98C2420
        public void RaiseCancellation(){} // RVA: 0x7FFAC98C2520
        public void IsInvoking(){} // RVA: 0x7FFAC98C2740 | overloaded x3
        public void CancelInvoke(){} // RVA: 0x7FFAC98C26E0 | overloaded x3
        public void Invoke(){} // RVA: 0x7FFAC98C2630
        public void InvokeRepeating(){} // RVA: 0x7FFAC98C2650
        public void StartCoroutine(){} // RVA: 0x7FFAC98C2910 | overloaded x3
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC98C2A60
        public void StopCoroutine(){} // RVA: 0x7FFAC98C2D10 | overloaded x3
        public void StopAllCoroutines(){} // RVA: 0x7FFAC98C2D70
        public void get_useGUILayout(){} // RVA: 0x7FFAC98C2DC0
        public void set_useGUILayout(){} // RVA: 0x7FFAC98C2E10
        public void print(){} // RVA: 0x7FFAC98C2E70
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC98C25E0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC98C2590
        public void InvokeDelayed(){} // RVA: 0x7FFAC98C2EC0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC98C2F40
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC98C2F90
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC98C3000
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC98C3060
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC98C30C0
        public void GetScriptClassName(){} // RVA: 0x7FFAC98C3120
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFAC98C3170
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Motion : Object
    {
        public bool averageDuration; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9832D50
        public void get_averageDuration(){} // RVA: 0x7FFAC9832DA0
        public void get_averageAngularSpeed(){} // RVA: 0x7FFAC9832DF0
        public void get_averageSpeed(){} // RVA: 0x7FFAC9832E40
        public void get_apparentSpeed(){} // RVA: 0x7FFAC9832EB0
        public void get_isLooping(){} // RVA: 0x7FFAC9832F00
        public void get_isHumanMotion(){} // RVA: 0x7FFAC9832F50
        public void get_averageSpeed_Injected(){} // RVA: 0x7FFAC9832FA0
    }

    public class MultilineAttribute : PropertyAttribute
    {
        public int lines; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98B7DF0
    }

}