// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 17
// Methods: 858

namespace ThirdParty.Unity.UnityEngine
{
    public class ManagedStreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateLoadFromStream(){} // RVA: 0x7FFE87C6A770
        public void ManagedStreamRead(){} // RVA: 0x7FFE87C6A8E0
        public void ManagedStreamSeek(){} // RVA: 0x7FFE87C6A9D0
        public void ManagedStreamLength(){} // RVA: 0x7FFE87C6AAA0
    }

    public class MatchTargetWeightMask : ValueType
    {
        public UnityEngine.Vector3 m_PositionXYZWeight; // 0x10
        public float m_RotationWeight; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE855C19C0
        public void get_positionXYZWeight(){} // RVA: 0x7FFE87BBA310
        public void set_positionXYZWeight(){} // RVA: 0x7FFE835C1F00
        public void get_rotationWeight(){} // RVA: 0x7FFE8111ED00
        public void set_rotationWeight(){} // RVA: 0x7FFE82D03B80
    }

    public class Material : Object
    {
        // ── Methods ──
        public void CreateWithShader(){} // RVA: 0x7FFE87C299B0
        public void CreateWithMaterial(){} // RVA: 0x7FFE87C29A10
        public void CreateWithString(){} // RVA: 0x7FFE87C29A70
        public void .ctor(){} // RVA: 0x7FFE87C29C00 | overloaded x3
        public void get_shader(){} // RVA: 0x7FFE87C29C90
        public void set_shader(){} // RVA: 0x7FFE87C29CE0
        public void get_color(){} // RVA: 0x7FFE87C29D40
        public void set_color(){} // RVA: 0x7FFE87C29E60
        public void get_mainTexture(){} // RVA: 0x7FFE87C29F70
        public void set_mainTexture(){} // RVA: 0x7FFE87C2A060
        public void get_mainTextureOffset(){} // RVA: 0x7FFE87C2A110
        public void set_mainTextureOffset(){} // RVA: 0x7FFE87C2A1C0
        public void get_mainTextureScale(){} // RVA: 0x7FFE87C2A2D0
        public void set_mainTextureScale(){} // RVA: 0x7FFE87C2A380
        public void GetFirstPropertyNameIdByAttribute(){} // RVA: 0x7FFE87C2A490
        public void HasProperty(){} // RVA: 0x7FFE87C2A550 | overloaded x2
        public void HasFloatImpl(){} // RVA: 0x7FFE87C2A5F0
        public void HasFloat(){} // RVA: 0x7FFE87C2A5F0 | overloaded x2
        public void HasInt(){} // RVA: 0x7FFE87C2A5F0 | overloaded x2
        public void HasIntImpl(){} // RVA: 0x7FFE87C2A6F0
        public void HasInteger(){} // RVA: 0x7FFE87C2A6F0 | overloaded x2
        public void HasTextureImpl(){} // RVA: 0x7FFE87C2A7F0
        public void HasTexture(){} // RVA: 0x7FFE87C2A7F0 | overloaded x2
        public void HasMatrixImpl(){} // RVA: 0x7FFE87C2A8F0
        public void HasMatrix(){} // RVA: 0x7FFE87C2A8F0 | overloaded x2
        public void HasVectorImpl(){} // RVA: 0x7FFE87C2A9F0
        public void HasVector(){} // RVA: 0x7FFE87C2A9F0 | overloaded x2
        public void HasColor(){} // RVA: 0x7FFE87C2A9F0 | overloaded x2
        public void HasBufferImpl(){} // RVA: 0x7FFE87C2AAF0
        public void HasBuffer(){} // RVA: 0x7FFE87C2AAF0 | overloaded x2
        public void HasConstantBufferImpl(){} // RVA: 0x7FFE87C2ABF0
        public void HasConstantBuffer(){} // RVA: 0x7FFE87C2ABF0 | overloaded x2
        public void get_renderQueue(){} // RVA: 0x7FFE87C2ACF0
        public void set_renderQueue(){} // RVA: 0x7FFE87C2AD40
        public void EnableKeyword(){} // RVA: 0x7FFE87C2B050 | overloaded x2
        public void DisableKeyword(){} // RVA: 0x7FFE87C2B0C0 | overloaded x2
        public void IsKeywordEnabled(){} // RVA: 0x7FFE87C2B1B0 | overloaded x2
        public void EnableLocalKeyword(){} // RVA: 0x7FFE87C2AEC0
        public void DisableLocalKeyword(){} // RVA: 0x7FFE87C2AF20
        public void SetLocalKeyword(){} // RVA: 0x7FFE87C2AF80
        public void IsLocalKeywordEnabled(){} // RVA: 0x7FFE87C2AFF0
        public void SetKeyword(){} // RVA: 0x7FFE87C2B130
        public void GetEnabledKeywords(){} // RVA: 0x7FFE87C2B220
        public void SetEnabledKeywords(){} // RVA: 0x7FFE87C2B270
        public void get_enabledKeywords(){} // RVA: 0x7FFE87C2B220
        public void set_enabledKeywords(){} // RVA: 0x7FFE87C2B270
        public void get_globalIlluminationFlags(){} // RVA: 0x7FFE87C2B2D0
        public void set_globalIlluminationFlags(){} // RVA: 0x7FFE87C2B320
        public void get_doubleSidedGI(){} // RVA: 0x7FFE87C2B380
        public void set_doubleSidedGI(){} // RVA: 0x7FFE87C2B3D0
        public void get_enableInstancing(){} // RVA: 0x7FFE87C2B430
        public void set_enableInstancing(){} // RVA: 0x7FFE87C2B480
        public void get_passCount(){} // RVA: 0x7FFE87C2B4E0
        public void SetShaderPassEnabled(){} // RVA: 0x7FFE87C2B530
        public void GetShaderPassEnabled(){} // RVA: 0x7FFE87C2B5A0
        public void GetPassName(){} // RVA: 0x7FFE87C2B600
        public void FindPass(){} // RVA: 0x7FFE87C2B660
        public void SetOverrideTag(){} // RVA: 0x7FFE87C2B6C0
        public void GetTagImpl(){} // RVA: 0x7FFE87C2B730
        public void GetTag(){} // RVA: 0x7FFE87C2B7D0 | overloaded x2
        public void Lerp(){} // RVA: 0x7FFE87C2B840
        public void SetPass(){} // RVA: 0x7FFE87C2B8C0
        public void CopyPropertiesFromMaterial(){} // RVA: 0x7FFE87C2B920
        public void CopyMatchingPropertiesFromMaterial(){} // RVA: 0x7FFE87C2B980
        public void GetShaderKeywords(){} // RVA: 0x7FFE87C2B9E0
        public void SetShaderKeywords(){} // RVA: 0x7FFE87C2BA30
        public void get_shaderKeywords(){} // RVA: 0x7FFE87C2B9E0
        public void set_shaderKeywords(){} // RVA: 0x7FFE87C2BA30
        public void GetPropertyNamesImpl(){} // RVA: 0x7FFE87C2BA90
        public void ComputeCRC(){} // RVA: 0x7FFE87C2BAF0
        public void GetTexturePropertyNames(){} // RVA: 0x7FFE87C2BCA0 | overloaded x2
        public void GetTexturePropertyNameIDs(){} // RVA: 0x7FFE87C2BD50 | overloaded x2
        public void GetTexturePropertyNamesInternal(){} // RVA: 0x7FFE87C2BBE0
        public void GetTexturePropertyNameIDsInternal(){} // RVA: 0x7FFE87C2BC40
        public void SetIntImpl(){} // RVA: 0x7FFE87C2BE00
        public void SetFloatImpl(){} // RVA: 0x7FFE87C2BE70
        public void SetColorImpl(){} // RVA: 0x7FFE87C2BEE0
        public void SetMatrixImpl(){} // RVA: 0x7FFE87C2BF50
        public void SetTextureImpl(){} // RVA: 0x7FFE87C2BFC0
        public void SetRenderTextureImpl(){} // RVA: 0x7FFE87C2C030
        public void SetBufferImpl(){} // RVA: 0x7FFE87C2C0B0
        public void SetGraphicsBufferImpl(){} // RVA: 0x7FFE87C2C120
        public void GetIntImpl(){} // RVA: 0x7FFE87C2C190
        public void GetFloatImpl(){} // RVA: 0x7FFE87C2C1F0
        public void GetColorImpl(){} // RVA: 0x7FFE87C2C250
        public void GetMatrixImpl(){} // RVA: 0x7FFE87C2C2D0
        public void GetTextureImpl(){} // RVA: 0x7FFE87C2C360
        public void SetFloatArrayImpl(){} // RVA: 0x7FFE87C2C3C0
        public void SetVectorArrayImpl(){} // RVA: 0x7FFE87C2C440
        public void SetColorArrayImpl(){} // RVA: 0x7FFE87C2C4C0
        public void SetMatrixArrayImpl(){} // RVA: 0x7FFE87C2C540
        public void GetFloatArrayImpl(){} // RVA: 0x7FFE87C2C5C0
        public void GetVectorArrayImpl(){} // RVA: 0x7FFE87C2C620
        public void GetColorArrayImpl(){} // RVA: 0x7FFE87C2C680
        public void GetMatrixArrayImpl(){} // RVA: 0x7FFE87C2C6E0
        public void GetFloatArrayCountImpl(){} // RVA: 0x7FFE87C2C740
        public void GetVectorArrayCountImpl(){} // RVA: 0x7FFE87C2C7A0
        public void GetColorArrayCountImpl(){} // RVA: 0x7FFE87C2C800
        public void GetMatrixArrayCountImpl(){} // RVA: 0x7FFE87C2C860
        public void ExtractFloatArrayImpl(){} // RVA: 0x7FFE87C2C8C0
        public void ExtractVectorArrayImpl(){} // RVA: 0x7FFE87C2C930
        public void ExtractColorArrayImpl(){} // RVA: 0x7FFE87C2C9A0
        public void ExtractMatrixArrayImpl(){} // RVA: 0x7FFE87C2CA10
        public void GetTextureScaleAndOffsetImpl(){} // RVA: 0x7FFE87C2CA80
        public void SetTextureOffsetImpl(){} // RVA: 0x7FFE87C2CB00
        public void SetTextureScaleImpl(){} // RVA: 0x7FFE87C2CB70
        public void SetFloatArray(){} // RVA: 0x7FFE87C2E4B0 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x7FFE87C2E8F0 | overloaded x5
        public void SetColorArray(){} // RVA: 0x7FFE87C2E6D0 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x7FFE87C2EB10 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x7FFE87C2D1E0
        public void ExtractVectorArray(){} // RVA: 0x7FFE87C2D3E0
        public void ExtractColorArray(){} // RVA: 0x7FFE87C2D5E0
        public void ExtractMatrixArray(){} // RVA: 0x7FFE87C2D7E0
        public void SetInt(){} // RVA: 0x7FFE87C2DAA0 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFE87C2BE70 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFE87C2BE00 | overloaded x2
        public void SetColor(){} // RVA: 0x7FFE87C2DD30 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFE87C2DEA0 | overloaded x2
        public void SetMatrix(){} // RVA: 0x7FFE87C2E030 | overloaded x2
        public void SetTexture(){} // RVA: 0x7FFE87C2E200 | overloaded x4
        public void SetBuffer(){} // RVA: 0x7FFE87C2E210 | overloaded x2
        public void GetInt(){} // RVA: 0x7FFE87C2EBF0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFE87C2C1F0 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFE87C2C190 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFE87C2EE60 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFE87C2EFC0 | overloaded x2
        public void GetMatrix(){} // RVA: 0x7FFE87C2F160 | overloaded x2
        public void GetTexture(){} // RVA: 0x7FFE87C2C360 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x7FFE87C2F7C0 | overloaded x4
        public void GetColorArray(){} // RVA: 0x7FFE87C2F850 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x7FFE87C2F8E0 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x7FFE87C2F970 | overloaded x4
        public void SetTextureOffset(){} // RVA: 0x7FFE87C2CB00 | overloaded x2
        public void SetTextureScale(){} // RVA: 0x7FFE87C2CB70 | overloaded x2
        public void GetTextureOffset(){} // RVA: 0x7FFE87C2FB70 | overloaded x2
        public void GetTextureScale(){} // RVA: 0x7FFE87C2FC60 | overloaded x2
        public void GetPropertyNames(){} // RVA: 0x7FFE87C2BA90
        public void EnableLocalKeyword_Injected(){} // RVA: 0x7FFE87C2FCE0
        public void DisableLocalKeyword_Injected(){} // RVA: 0x7FFE87C2FD40
        public void SetLocalKeyword_Injected(){} // RVA: 0x7FFE87C2FDA0
        public void IsLocalKeywordEnabled_Injected(){} // RVA: 0x7FFE87C2FE10
        public void SetColorImpl_Injected(){} // RVA: 0x7FFE87C2FE70
        public void SetMatrixImpl_Injected(){} // RVA: 0x7FFE87C2FEE0
        public void GetColorImpl_Injected(){} // RVA: 0x7FFE87C2FF50
        public void GetMatrixImpl_Injected(){} // RVA: 0x7FFE87C2FFC0
        public void GetTextureScaleAndOffsetImpl_Injected(){} // RVA: 0x7FFE87C30030
        public void SetTextureOffsetImpl_Injected(){} // RVA: 0x7FFE87C300A0
        public void SetTextureScaleImpl_Injected(){} // RVA: 0x7FFE87C30110
    }

    public class MaterialPropertyBlock : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void GetIntImpl(){} // RVA: 0x7FFE87C1EBA0
        public void GetFloatImpl(){} // RVA: 0x7FFE87C1EC00
        public void GetVectorImpl(){} // RVA: 0x7FFE87C1EC60
        public void GetColorImpl(){} // RVA: 0x7FFE87C1ECE0
        public void GetMatrixImpl(){} // RVA: 0x7FFE87C1ED60
        public void GetTextureImpl(){} // RVA: 0x7FFE87C1EDF0
        public void HasPropertyImpl(){} // RVA: 0x7FFE87C1EE50
        public void HasFloatImpl(){} // RVA: 0x7FFE87C1EEB0
        public void HasIntImpl(){} // RVA: 0x7FFE87C1EF10
        public void HasTextureImpl(){} // RVA: 0x7FFE87C1EF70
        public void HasMatrixImpl(){} // RVA: 0x7FFE87C1EFD0
        public void HasVectorImpl(){} // RVA: 0x7FFE87C1F030
        public void HasBufferImpl(){} // RVA: 0x7FFE87C1F090
        public void HasConstantBufferImpl(){} // RVA: 0x7FFE87C1F0F0
        public void SetIntImpl(){} // RVA: 0x7FFE87C1F150
        public void SetFloatImpl(){} // RVA: 0x7FFE87C1F1C0
        public void SetVectorImpl(){} // RVA: 0x7FFE87C1F230
        public void SetColorImpl(){} // RVA: 0x7FFE87C1F2A0
        public void SetMatrixImpl(){} // RVA: 0x7FFE87C1F310
        public void SetTextureImpl(){} // RVA: 0x7FFE87C1F380
        public void SetRenderTextureImpl(){} // RVA: 0x7FFE87C1F3F0
        public void SetBufferImpl(){} // RVA: 0x7FFE87C1F470
        public void SetGraphicsBufferImpl(){} // RVA: 0x7FFE87C1F4E0
        public void SetFloatArrayImpl(){} // RVA: 0x7FFE87C1F550
        public void SetVectorArrayImpl(){} // RVA: 0x7FFE87C1F5D0
        public void SetMatrixArrayImpl(){} // RVA: 0x7FFE87C1F650
        public void GetFloatArrayImpl(){} // RVA: 0x7FFE87C1F6D0
        public void GetVectorArrayImpl(){} // RVA: 0x7FFE87C1F730
        public void GetMatrixArrayImpl(){} // RVA: 0x7FFE87C1F790
        public void GetFloatArrayCountImpl(){} // RVA: 0x7FFE87C1F7F0
        public void GetVectorArrayCountImpl(){} // RVA: 0x7FFE87C1F850
        public void GetMatrixArrayCountImpl(){} // RVA: 0x7FFE87C1F8B0
        public void ExtractFloatArrayImpl(){} // RVA: 0x7FFE87C1F910
        public void ExtractVectorArrayImpl(){} // RVA: 0x7FFE87C1F980
        public void ExtractMatrixArrayImpl(){} // RVA: 0x7FFE87C1F9F0
        public void Internal_CopySHCoefficientArraysFrom(){} // RVA: 0x7FFE87C1FA60
        public void Internal_CopyProbeOcclusionArrayFrom(){} // RVA: 0x7FFE87C1FAF0
        public void CreateImpl(){} // RVA: 0x7FFE87C1FB80
        public void DestroyImpl(){} // RVA: 0x7FFE87C1FBD0
        public void get_isEmpty(){} // RVA: 0x7FFE87C1FC20
        public void Clear(){} // RVA: 0x7FFE87C1FCD0 | overloaded x2
        public void SetFloatArray(){} // RVA: 0x7FFE87C21330 | overloaded x5
        public void SetVectorArray(){} // RVA: 0x7FFE87C21550 | overloaded x5
        public void SetMatrixArray(){} // RVA: 0x7FFE87C21770 | overloaded x5
        public void ExtractFloatArray(){} // RVA: 0x7FFE87C201B0
        public void ExtractVectorArray(){} // RVA: 0x7FFE87C203B0
        public void ExtractMatrixArray(){} // RVA: 0x7FFE87C205B0
        public void .ctor(){} // RVA: 0x7FFE87C207B0
        public void Finalize(){} // RVA: 0x7FFE87C20800
        public void Dispose(){} // RVA: 0x7FFE87C208E0
        public void SetInt(){} // RVA: 0x7FFE87C20A50 | overloaded x2
        public void SetFloat(){} // RVA: 0x7FFE87C1F1C0 | overloaded x2
        public void SetInteger(){} // RVA: 0x7FFE87C1F150 | overloaded x2
        public void SetVector(){} // RVA: 0x7FFE87C20CE0 | overloaded x2
        public void SetColor(){} // RVA: 0x7FFE87C20E10 | overloaded x2
        public void SetMatrix(){} // RVA: 0x7FFE87C20F60 | overloaded x2
        public void SetBuffer(){} // RVA: 0x7FFE87C1F4E0 | overloaded x2
        public void SetTexture(){} // RVA: 0x7FFE87C21130 | overloaded x4
        public void HasProperty(){} // RVA: 0x7FFE87C1EE50 | overloaded x2
        public void HasInt(){} // RVA: 0x7FFE87C1EEB0 | overloaded x2
        public void HasFloat(){} // RVA: 0x7FFE87C1EEB0 | overloaded x2
        public void HasInteger(){} // RVA: 0x7FFE87C1EF10 | overloaded x2
        public void HasTexture(){} // RVA: 0x7FFE87C1EF70 | overloaded x2
        public void HasMatrix(){} // RVA: 0x7FFE87C1EFD0 | overloaded x2
        public void HasVector(){} // RVA: 0x7FFE87C1F030 | overloaded x2
        public void HasColor(){} // RVA: 0x7FFE87C1F030 | overloaded x2
        public void HasBuffer(){} // RVA: 0x7FFE87C1F090 | overloaded x2
        public void HasConstantBuffer(){} // RVA: 0x7FFE87C1F0F0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFE87C1EC00 | overloaded x2
        public void GetInt(){} // RVA: 0x7FFE87C21DF0 | overloaded x2
        public void GetInteger(){} // RVA: 0x7FFE87C1EBA0 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFE87C21FC0 | overloaded x2
        public void GetColor(){} // RVA: 0x7FFE87C22120 | overloaded x2
        public void GetMatrix(){} // RVA: 0x7FFE87C222C0 | overloaded x2
        public void GetTexture(){} // RVA: 0x7FFE87C1EDF0 | overloaded x2
        public void GetFloatArray(){} // RVA: 0x7FFE87C22800 | overloaded x4
        public void GetVectorArray(){} // RVA: 0x7FFE87C22890 | overloaded x4
        public void GetMatrixArray(){} // RVA: 0x7FFE87C22920 | overloaded x4
        public void CopySHCoefficientArraysFrom(){} // RVA: 0x7FFE87C22B00 | overloaded x4
        public void CopyProbeOcclusionArrayFrom(){} // RVA: 0x7FFE87C22F40 | overloaded x4
        public void GetVectorImpl_Injected(){} // RVA: 0x7FFE87C231B0
        public void GetColorImpl_Injected(){} // RVA: 0x7FFE87C23220
        public void GetMatrixImpl_Injected(){} // RVA: 0x7FFE87C23290
        public void SetVectorImpl_Injected(){} // RVA: 0x7FFE87C23300
        public void SetColorImpl_Injected(){} // RVA: 0x7FFE87C23370
        public void SetMatrixImpl_Injected(){} // RVA: 0x7FFE87C233E0
    }

    public class Mathf : ValueType
    {
        // ── Methods ──
        public void ClosestPowerOfTwo(){} // RVA: 0x7FFE87C59520
        public void IsPowerOfTwo(){} // RVA: 0x7FFE87C59570
        public void NextPowerOfTwo(){} // RVA: 0x7FFE87C595C0
        public void GammaToLinearSpace(){} // RVA: 0x7FFE87C59610
        public void LinearToGammaSpace(){} // RVA: 0x7FFE87C59670
        public void CorrelatedColorTemperatureToRGB(){} // RVA: 0x7FFE87C596D0
        public void FloatToHalf(){} // RVA: 0x7FFE87C59740
        public void HalfToFloat(){} // RVA: 0x7FFE87C597A0
        public void PerlinNoise(){} // RVA: 0x7FFE87C597F0
        public void PerlinNoise1D(){} // RVA: 0x7FFE87C59860
        public void Sin(){} // RVA: 0x7FFE87C598C0
        public void Cos(){} // RVA: 0x7FFE87C59920
        public void Tan(){} // RVA: 0x7FFE87C59980
        public void Asin(){} // RVA: 0x7FFE87C599E0
        public void Acos(){} // RVA: 0x7FFE87C59A40
        public void Atan(){} // RVA: 0x7FFE87C59AA0
        public void Atan2(){} // RVA: 0x7FFE87C59B00
        public void Sqrt(){} // RVA: 0x7FFE87C59B70
        public void Abs(){} // RVA: 0x7FFE87C59C50 | overloaded x2
        public void Min(){} // RVA: 0x7FFE87C59D00 | overloaded x4
        public void Max(){} // RVA: 0x7FFE87C59D70 | overloaded x4
        public void Pow(){} // RVA: 0x7FFE87C59DD0
        public void Exp(){} // RVA: 0x7FFE87C59E50
        public void Log(){} // RVA: 0x7FFE87C59F30 | overloaded x2
        public void Log10(){} // RVA: 0x7FFE87C59F90
        public void Ceil(){} // RVA: 0x7FFE87C59FF0
        public void Floor(){} // RVA: 0x7FFE87C5A050
        public void Round(){} // RVA: 0x7FFE87C5A0B0
        public void CeilToInt(){} // RVA: 0x7FFE87C5A110
        public void FloorToInt(){} // RVA: 0x7FFE87C5A170
        public void RoundToInt(){} // RVA: 0x7FFE87C5A1D0
        public void Sign(){} // RVA: 0x7FFE87C5A230
        public void Clamp(){} // RVA: 0x7FFE8111FAE0 | overloaded x2
        public void Clamp01(){} // RVA: 0x7FFE8111FDC0
        public void Lerp(){} // RVA: 0x7FFE8111EF40
        public void LerpUnclamped(){} // RVA: 0x7FFE87C5A250
        public void LerpAngle(){} // RVA: 0x7FFE8111F160
        public void MoveTowards(){} // RVA: 0x7FFE8111FA60
        public void MoveTowardsAngle(){} // RVA: 0x7FFE87C5A270
        public void SmoothStep(){} // RVA: 0x7FFE817A79F0
        public void Gamma(){} // RVA: 0x7FFE87C5A310
        public void Approximately(){} // RVA: 0x7FFE87C5A370
        public void SmoothDamp(){} // RVA: 0x7FFE87C5A4B0 | overloaded x3
        public void SmoothDampAngle(){} // RVA: 0x7FFE827E8AB0 | overloaded x3
        public void Repeat(){} // RVA: 0x7FFE8111F380
        public void PingPong(){} // RVA: 0x7FFE81C039B0
        public void InverseLerp(){} // RVA: 0x7FFE8111EF00
        public void DeltaAngle(){} // RVA: 0x7FFE811480F0
        public void ClampToFloat(){} // RVA: 0x7FFE87C5A7A0
        public void ClampToInt(){} // RVA: 0x7FFE87C5A800
        public void ClampToUInt(){} // RVA: 0x7FFE87C5A820
        public void GetNumberOfDecimalsForMinimumDifference(){} // RVA: 0x7FFE87C5A840
        public void RoundBasedOnMinimumDifference(){} // RVA: 0x7FFE87C5A8E0
        public void DiscardLeastSignificantDecimal(){} // RVA: 0x7FFE87C5AA10
        public void .cctor(){} // RVA: 0x7FFE87C5AAB0
        public void CorrelatedColorTemperatureToRGB_Injected(){} // RVA: 0x7FFE87C5AB30
    }

    public class Matrix4x4 : ValueType
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
        public void GetRotation(){} // RVA: 0x7FFE87C52FE0
        public void GetLossyScale(){} // RVA: 0x7FFE87C53050
        public void IsIdentity(){} // RVA: 0x7FFE87C530C0
        public void GetDeterminant(){} // RVA: 0x7FFE87C53110
        public void DecomposeProjection(){} // RVA: 0x7FFE87C53160
        public void get_rotation(){} // RVA: 0x7FFE87C531D0
        public void get_lossyScale(){} // RVA: 0x7FFE87C53250
        public void get_isIdentity(){} // RVA: 0x7FFE87C530C0
        public void get_determinant(){} // RVA: 0x7FFE87C53110
        public void get_decomposeProjection(){} // RVA: 0x7FFE87C532E0
        public void ValidTRS(){} // RVA: 0x7FFE87C53370
        public void Determinant(){} // RVA: 0x7FFE87C533C0
        public void TRS(){} // RVA: 0x7FFE87C53410
        public void SetTRS(){} // RVA: 0x7FFE87C534B0
        public void Inverse3DAffine(){} // RVA: 0x7FFE87C53590
        public void Inverse(){} // RVA: 0x7FFE87C535F0
        public void get_inverse(){} // RVA: 0x7FFE87C53670
        public void Transpose(){} // RVA: 0x7FFE87C53740
        public void get_transpose(){} // RVA: 0x7FFE87C537C0
        public void Ortho(){} // RVA: 0x7FFE87C53890
        public void Perspective(){} // RVA: 0x7FFE87C53960
        public void LookAt(){} // RVA: 0x7FFE87C53A10
        public void Frustum(){} // RVA: 0x7FFE87C53B80 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87C53CD0
        public void get_Item(){} // RVA: 0x7FFE87C53D60 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE87C53EC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE84109F80
        public void Equals(){} // RVA: 0x7FFE831D20C0 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFE87C54610 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87C54730
        public void op_Inequality(){} // RVA: 0x7FFE87C54870
        public void GetColumn(){} // RVA: 0x7FFE87C548E0
        public void GetRow(){} // RVA: 0x7FFE87C549B0
        public void GetPosition(){} // RVA: 0x7FFE87C54AA0
        public void SetColumn(){} // RVA: 0x7FFE87C54AC0
        public void SetRow(){} // RVA: 0x7FFE87C54B40
        public void MultiplyPoint(){} // RVA: 0x7FFE87C54BB0
        public void MultiplyPoint3x4(){} // RVA: 0x7FFE87C54CA0
        public void MultiplyVector(){} // RVA: 0x7FFE87C54D40
        public void TransformPlane(){} // RVA: 0x7FFE87C54DD0
        public void Scale(){} // RVA: 0x7FFE87C55080
        public void Translate(){} // RVA: 0x7FFE87C55120
        public void Rotate(){} // RVA: 0x7FFE87C551C0
        public void get_zero(){} // RVA: 0x7FFE87C55370
        public void get_identity(){} // RVA: 0x7FFE87C553D0
        public void ToString(){} // RVA: 0x7FFE87C55450 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87C55A90
        public void GetRotation_Injected(){} // RVA: 0x7FFE87C55BB0
        public void GetLossyScale_Injected(){} // RVA: 0x7FFE87C55C10
        public void IsIdentity_Injected(){} // RVA: 0x7FFE87C530C0
        public void GetDeterminant_Injected(){} // RVA: 0x7FFE87C53110
        public void DecomposeProjection_Injected(){} // RVA: 0x7FFE87C55C70
        public void ValidTRS_Injected(){} // RVA: 0x7FFE87C53370
        public void TRS_Injected(){} // RVA: 0x7FFE87C55CD0
        public void Inverse3DAffine_Injected(){} // RVA: 0x7FFE87C55D50
        public void Inverse_Injected(){} // RVA: 0x7FFE87C55DB0
        public void Transpose_Injected(){} // RVA: 0x7FFE87C55E10
        public void Ortho_Injected(){} // RVA: 0x7FFE87C55E70
        public void Perspective_Injected(){} // RVA: 0x7FFE87C55F10
        public void LookAt_Injected(){} // RVA: 0x7FFE87C55FB0
        public void Frustum_Injected(){} // RVA: 0x7FFE87C56030
    }

    public class Mesh : Object
    {
        // ── Methods ──
        public void Internal_Create(){} // RVA: 0x7FFE87C35BF0
        public void .ctor(){} // RVA: 0x7FFE87C35C40
        public void FromInstanceID(){} // RVA: 0x7FFE87C35CD0
        public void get_indexFormat(){} // RVA: 0x7FFE87C35D20
        public void set_indexFormat(){} // RVA: 0x7FFE87C35D70
        public void SetIndexBufferParams(){} // RVA: 0x7FFE87C35DD0
        public void InternalSetIndexBufferData(){} // RVA: 0x7FFE87C35E40
        public void SetVertexBufferParamsFromArray(){} // RVA: 0x7FFE87C35ED0
        public void GetVertexAttributesAlloc(){} // RVA: 0x7FFE87C35F40
        public void GetVertexAttributesArray(){} // RVA: 0x7FFE87C35F90
        public void GetVertexAttributesList(){} // RVA: 0x7FFE87C35FF0
        public void GetVertexAttributeCountImpl(){} // RVA: 0x7FFE87C36050
        public void GetVertexAttribute(){} // RVA: 0x7FFE87C360A0
        public void GetIndexStartImpl(){} // RVA: 0x7FFE87C36120
        public void GetIndexCountImpl(){} // RVA: 0x7FFE87C36180
        public void GetTrianglesCountImpl(){} // RVA: 0x7FFE87C361E0
        public void GetBaseVertexImpl(){} // RVA: 0x7FFE87C36240
        public void GetTrianglesImpl(){} // RVA: 0x7FFE87C362A0
        public void GetIndicesImpl(){} // RVA: 0x7FFE87C36310
        public void SetIndicesImpl(){} // RVA: 0x7FFE87C36380
        public void GetTrianglesNonAllocImpl(){} // RVA: 0x7FFE87C36410
        public void GetTrianglesNonAllocImpl16(){} // RVA: 0x7FFE87C36490
        public void GetIndicesNonAllocImpl(){} // RVA: 0x7FFE87C36510
        public void GetIndicesNonAllocImpl16(){} // RVA: 0x7FFE87C36590
        public void PrintErrorCantAccessChannel(){} // RVA: 0x7FFE87C36610
        public void HasVertexAttribute(){} // RVA: 0x7FFE87C36670
        public void GetVertexAttributeDimension(){} // RVA: 0x7FFE87C366D0
        public void GetVertexAttributeFormat(){} // RVA: 0x7FFE87C36730
        public void GetVertexAttributeStream(){} // RVA: 0x7FFE87C36790
        public void GetVertexAttributeOffset(){} // RVA: 0x7FFE87C367F0
        public void SetArrayForChannelImpl(){} // RVA: 0x7FFE87C36850
        public void SetNativeArrayForChannelImpl(){} // RVA: 0x7FFE87C368D0
        public void GetAllocArrayFromChannelImpl(){} // RVA: 0x7FFE87C36950
        public void GetArrayFromChannelImpl(){} // RVA: 0x7FFE87C369D0
        public void get_vertexBufferCount(){} // RVA: 0x7FFE87C36A50
        public void GetVertexBufferStride(){} // RVA: 0x7FFE87C36AA0
        public void get_blendShapeCount(){} // RVA: 0x7FFE87C36B00
        public void ClearBlendShapes(){} // RVA: 0x7FFE87C36B50
        public void GetBlendShapeName(){} // RVA: 0x7FFE87C36BA0
        public void GetBlendShapeIndex(){} // RVA: 0x7FFE87C36C00
        public void GetBlendShapeFrameCount(){} // RVA: 0x7FFE87C36C60
        public void GetBlendShapeFrameWeight(){} // RVA: 0x7FFE87C36CC0
        public void GetBlendShapeFrameVertices(){} // RVA: 0x7FFE87C36D30
        public void AddBlendShapeFrame(){} // RVA: 0x7FFE87C36DB0
        public void GetBlendShapeOffsetInternal(){} // RVA: 0x7FFE87C36E40
        public void HasBoneWeights(){} // RVA: 0x7FFE87C36EC0
        public void GetBoneWeightsImpl(){} // RVA: 0x7FFE87C36F10
        public void SetBoneWeightsImpl(){} // RVA: 0x7FFE87C36F60
        public void GetBoneWeightBufferLayoutInternal(){} // RVA: 0x7FFE87C36FC0
        public void get_bindposeCount(){} // RVA: 0x7FFE87C37010
        public void get_bindposes(){} // RVA: 0x7FFE87C37060
        public void set_bindposes(){} // RVA: 0x7FFE87C370B0
        public void GetBoneWeightsNonAllocImpl(){} // RVA: 0x7FFE87C37110
        public void GetBindposesNonAllocImpl(){} // RVA: 0x7FFE87C37170
        public void get_isReadable(){} // RVA: 0x7FFE87C371D0
        public void get_canAccess(){} // RVA: 0x7FFE87C37220
        public void get_vertexCount(){} // RVA: 0x7FFE87C37270
        public void get_subMeshCount(){} // RVA: 0x7FFE87C372C0
        public void set_subMeshCount(){} // RVA: 0x7FFE87C37310
        public void SetSubMesh(){} // RVA: 0x7FFE87C37370
        public void GetSubMesh(){} // RVA: 0x7FFE87C373F0
        public void SetAllSubMeshesAtOnceFromArray(){} // RVA: 0x7FFE87C37470
        public void get_bounds(){} // RVA: 0x7FFE87C37500
        public void set_bounds(){} // RVA: 0x7FFE87C37570
        public void ClearImpl(){} // RVA: 0x7FFE87C375D0
        public void RecalculateBoundsImpl(){} // RVA: 0x7FFE87C37630
        public void RecalculateNormalsImpl(){} // RVA: 0x7FFE87C37690
        public void RecalculateTangentsImpl(){} // RVA: 0x7FFE87C376F0
        public void MarkDynamicImpl(){} // RVA: 0x7FFE87C37750
        public void MarkModified(){} // RVA: 0x7FFE87C377A0
        public void DiscardReadableDataImpl(){} // RVA: 0x7FFE87C377F0
        public void UploadMeshDataImpl(){} // RVA: 0x7FFE87C37840
        public void GetTopologyImpl(){} // RVA: 0x7FFE87C378A0
        public void RecalculateUVDistributionMetricImpl(){} // RVA: 0x7FFE87C37900
        public void RecalculateUVDistributionMetricsImpl(){} // RVA: 0x7FFE87C37970
        public void GetUVDistributionMetric(){} // RVA: 0x7FFE87C379D0
        public void CombineMeshesImpl(){} // RVA: 0x7FFE87C37A30
        public void OptimizeImpl(){} // RVA: 0x7FFE87C37AC0
        public void OptimizeIndexBuffersImpl(){} // RVA: 0x7FFE87C37B10
        public void OptimizeReorderVertexBufferImpl(){} // RVA: 0x7FFE87C37B60
        public void GetUVChannel(){} // RVA: 0x7FFE87C37BB0
        public void DefaultDimensionForChannel(){} // RVA: 0x7FFE87C37C40
        public void GetAllocArrayFromChannel(){} // RVA: 0x7FFE80E3D230 | overloaded x2
        public void SetSizedArrayForChannel(){} // RVA: 0x7FFE87C37CF0
        public void SetSizedNativeArrayForChannel(){} // RVA: 0x7FFE87C380B0
        public void SetArrayForChannel(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetListForChannel(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetListForChannel(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void get_vertices(){} // RVA: 0x7FFE87C38470
        public void set_vertices(){} // RVA: 0x7FFE87C384E0
        public void get_normals(){} // RVA: 0x7FFE87C38570
        public void set_normals(){} // RVA: 0x7FFE87C385F0
        public void get_tangents(){} // RVA: 0x7FFE87C38680
        public void set_tangents(){} // RVA: 0x7FFE87C38700
        public void get_uv(){} // RVA: 0x7FFE87C38790
        public void set_uv(){} // RVA: 0x7FFE87C38810
        public void get_uv2(){} // RVA: 0x7FFE87C388A0
        public void set_uv2(){} // RVA: 0x7FFE87C38920
        public void get_uv3(){} // RVA: 0x7FFE87C389B0
        public void set_uv3(){} // RVA: 0x7FFE87C38A30
        public void get_uv4(){} // RVA: 0x7FFE87C38AC0
        public void set_uv4(){} // RVA: 0x7FFE87C38B40
        public void get_uv5(){} // RVA: 0x7FFE87C38BD0
        public void set_uv5(){} // RVA: 0x7FFE87C38C50
        public void get_uv6(){} // RVA: 0x7FFE87C38CE0
        public void set_uv6(){} // RVA: 0x7FFE87C38D60
        public void get_uv7(){} // RVA: 0x7FFE87C38DF0
        public void set_uv7(){} // RVA: 0x7FFE87C38E70
        public void get_uv8(){} // RVA: 0x7FFE87C38F00
        public void set_uv8(){} // RVA: 0x7FFE87C38F80
        public void get_colors(){} // RVA: 0x7FFE87C39010
        public void set_colors(){} // RVA: 0x7FFE87C39090
        public void get_colors32(){} // RVA: 0x7FFE87C39120
        public void set_colors32(){} // RVA: 0x7FFE87C39180
        public void GetVertices(){} // RVA: 0x7FFE87C39210
        public void SetVertices(){} // RVA: 0x7FFE810A1420 | overloaded x9
        public void GetNormals(){} // RVA: 0x7FFE87C39650
        public void SetNormals(){} // RVA: 0x7FFE810A1420 | overloaded x9
        public void GetTangents(){} // RVA: 0x7FFE87C39AB0
        public void SetTangents(){} // RVA: 0x7FFE87C39E90 | overloaded x6
        public void GetColors(){} // RVA: 0x7FFE87C3A390 | overloaded x2
        public void SetColors(){} // RVA: 0x7FFE87C3A780 | overloaded x12
        public void SetUvsImpl(){} // RVA: 0x7FFE87C3AF30 | overloaded x2
        public void SetUVs(){} // RVA: 0x7FFE810A1420 | overloaded x21
        public void GetUVsImpl(){} // RVA: 0x7FFE810A1420
        public void GetUVs(){} // RVA: 0x7FFE87C3B640 | overloaded x3
        public void get_vertexAttributeCount(){} // RVA: 0x7FFE87C36050
        public void GetVertexAttributes(){} // RVA: 0x7FFE87C35FF0 | overloaded x3
        public void SetVertexBufferParams(){} // RVA: 0x7FFE87C35ED0
        public void GetBlendShapeBufferRange(){} // RVA: 0x7FFE87C3B880
        public void PrintErrorCantAccessIndices(){} // RVA: 0x7FFE87C3B9C0
        public void CheckCanAccessSubmesh(){} // RVA: 0x7FFE87C3BA80
        public void CheckCanAccessSubmeshTriangles(){} // RVA: 0x7FFE87C3BC50
        public void CheckCanAccessSubmeshIndices(){} // RVA: 0x7FFE87C3BC60
        public void get_triangles(){} // RVA: 0x7FFE87C3BC70
        public void set_triangles(){} // RVA: 0x7FFE87C3BD50
        public void GetTriangles(){} // RVA: 0x7FFE87C3C0E0 | overloaded x5
        public void GetIndices(){} // RVA: 0x7FFE87C3C5B0 | overloaded x5
        public void SetIndexBufferData(){} // RVA: 0x7FFE810A1420
        public void GetIndexStart(){} // RVA: 0x7FFE87C3C790
        public void GetIndexCount(){} // RVA: 0x7FFE87C3C890
        public void GetBaseVertex(){} // RVA: 0x7FFE87C3C990
        public void CheckIndicesArrayRange(){} // RVA: 0x7FFE87C3CA90
        public void SetTrianglesImpl(){} // RVA: 0x7FFE87C3CD00
        public void SetTriangles(){} // RVA: 0x7FFE87C3D5D0 | overloaded x12
        public void SetIndices(){} // RVA: 0x7FFE87C3DE00 | overloaded x10
        public void SetSubMeshes(){} // RVA: 0x7FFE87C3E3B0 | overloaded x4
        public void GetBindposes(){} // RVA: 0x7FFE87C3E450
        public void GetBoneWeights(){} // RVA: 0x7FFE87C3E5A0
        public void get_boneWeights(){} // RVA: 0x7FFE87C36F10
        public void set_boneWeights(){} // RVA: 0x7FFE87C36F60
        public void get_skinWeightBufferLayout(){} // RVA: 0x7FFE87C36FC0
        public void Clear(){} // RVA: 0x7FFE87C3E8D0 | overloaded x2
        public void RecalculateBounds(){} // RVA: 0x7FFE87C3E960 | overloaded x2
        public void RecalculateNormals(){} // RVA: 0x7FFE87C3EAC0 | overloaded x2
        public void RecalculateTangents(){} // RVA: 0x7FFE87C3EC20 | overloaded x2
        public void RecalculateUVDistributionMetric(){} // RVA: 0x7FFE87C3ED80
        public void RecalculateUVDistributionMetrics(){} // RVA: 0x7FFE87C3EF00
        public void MarkDynamic(){} // RVA: 0x7FFE87C3F060
        public void DiscardReadableData(){} // RVA: 0x7FFE87C3F100
        public void UploadMeshData(){} // RVA: 0x7FFE87C3F1A0
        public void Optimize(){} // RVA: 0x7FFE87C3F250
        public void OptimizeIndexBuffers(){} // RVA: 0x7FFE87C3F3A0
        public void OptimizeReorderVertexBuffer(){} // RVA: 0x7FFE87C3F4F0
        public void GetTopology(){} // RVA: 0x7FFE87C3F640
        public void CombineMeshes(){} // RVA: 0x7FFE87C3F7B0 | overloaded x4
        public void GetVertexAttribute_Injected(){} // RVA: 0x7FFE87C3F7E0
        public void GetBlendShapeOffsetInternal_Injected(){} // RVA: 0x7FFE87C3F850
        public void SetSubMesh_Injected(){} // RVA: 0x7FFE87C3F8C0
        public void GetSubMesh_Injected(){} // RVA: 0x7FFE87C3F940
        public void get_bounds_Injected(){} // RVA: 0x7FFE87C3F9B0
        public void set_bounds_Injected(){} // RVA: 0x7FFE87C3FA10
    }

    public class MeshCollider : Collider
    {
        // ── Methods ──
        public void get_sharedMesh(){} // RVA: 0x7FFE87D422B0
        public void set_sharedMesh(){} // RVA: 0x7FFE87D42300
        public void get_convex(){} // RVA: 0x7FFE87D42360
        public void set_convex(){} // RVA: 0x7FFE87D423B0
        public void get_cookingOptions(){} // RVA: 0x7FFE87D42410
        public void set_cookingOptions(){} // RVA: 0x7FFE87D42460
        public void get_smoothSphereCollisions(){} // RVA: 0x7FFE82E64CC0
        public void set_smoothSphereCollisions(){} // RVA: 0x7FFE810FB310
        public void get_skinWidth(){} // RVA: 0x7FFE87C336C0
        public void set_skinWidth(){} // RVA: 0x7FFE810FB310
        public void get_inflateMesh(){} // RVA: 0x7FFE834BA0A0
        public void set_inflateMesh(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class MeshFilter : Component
    {
        // ── Methods ──
        public void DontStripMeshFilter(){} // RVA: 0x7FFE810FB310
        public void get_sharedMesh(){} // RVA: 0x7FFE87C33A80
        public void set_sharedMesh(){} // RVA: 0x7FFE87C33AD0
        public void get_mesh(){} // RVA: 0x7FFE87C33B30
        public void set_mesh(){} // RVA: 0x7FFE87C33B80
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class MeshRenderer : Renderer
    {
        // ── Methods ──
        public void DontStripMeshRenderer(){} // RVA: 0x7FFE810FB310
        public void get_additionalVertexStreams(){} // RVA: 0x7FFE87C35210
        public void set_additionalVertexStreams(){} // RVA: 0x7FFE87C35260
        public void get_enlightenVertexStream(){} // RVA: 0x7FFE87C352C0
        public void set_enlightenVertexStream(){} // RVA: 0x7FFE87C35310
        public void get_subMeshStartIndex(){} // RVA: 0x7FFE87C35370
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Microphone : Object
    {
        // ── Methods ──
        public void GetMicrophoneDeviceIDFromName(){} // RVA: 0x7FFE87BF2170
        public void StartRecord(){} // RVA: 0x7FFE87BF21C0
        public void EndRecord(){} // RVA: 0x7FFE87BF2240
        public void IsRecording(){} // RVA: 0x7FFE87BF2750 | overloaded x2
        public void GetRecordPosition(){} // RVA: 0x7FFE87BF22E0
        public void GetDeviceCaps(){} // RVA: 0x7FFE87BF2890 | overloaded x2
        public void Start(){} // RVA: 0x7FFE87BF23A0
        public void End(){} // RVA: 0x7FFE87BF2660
        public void get_devices(){} // RVA: 0x7FFE87BF2700
        public void GetPosition(){} // RVA: 0x7FFE87BF27F0
    }

    public class MinAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81225330
    }

    public class MissingReferenceException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C6D160 | overloaded x3
    }

    public class ModifiableContactPair : ValueType
    {
    }

    public class MonoBehaviour : Behaviour
    {
        public System.Threading.CancellationTokenSource m_CancellationTokenSource; // 0x18
        public object field_1; // 0xBA30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE87C6AB50
        public void RaiseCancellation(){} // RVA: 0x7FFE87C6AC50
        public void IsInvoking(){} // RVA: 0x7FFE87C6AE70 | overloaded x3
        public void CancelInvoke(){} // RVA: 0x7FFE87C6AE10 | overloaded x3
        public void Invoke(){} // RVA: 0x7FFE87C6AD60
        public void InvokeRepeating(){} // RVA: 0x7FFE87C6AD80
        public void StartCoroutine(){} // RVA: 0x7FFE87C6B040 | overloaded x3
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE87C6B190
        public void StopCoroutine(){} // RVA: 0x7FFE87C6B440 | overloaded x3
        public void StopAllCoroutines(){} // RVA: 0x7FFE87C6B4A0
        public void get_useGUILayout(){} // RVA: 0x7FFE87C6B4F0
        public void set_useGUILayout(){} // RVA: 0x7FFE87C6B540
        public void print(){} // RVA: 0x7FFE87C6B5A0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE87C6AD10
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE87C6ACC0
        public void InvokeDelayed(){} // RVA: 0x7FFE87C6B5F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE87C6B670
        public void StartCoroutineManaged(){} // RVA: 0x7FFE87C6B6C0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE87C6B730
        public void StopCoroutineManaged(){} // RVA: 0x7FFE87C6B790
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE87C6B7F0
        public void GetScriptClassName(){} // RVA: 0x7FFE87C6B850
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE87C6B8A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Motion : Object
    {
        public bool _isAnimatorMotion; // 0x18
        public object field_1; // 0xF40
        public object field_2;
        public object field_3; // 0xAEE0
        public object field_4;
        public object field_5; // 0xE08

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BDB2A0
        public void get_averageDuration(){} // RVA: 0x7FFE87BDB2F0
        public void get_averageAngularSpeed(){} // RVA: 0x7FFE87BDB340
        public void get_averageSpeed(){} // RVA: 0x7FFE87BDB390
        public void get_apparentSpeed(){} // RVA: 0x7FFE87BDB400
        public void get_isLooping(){} // RVA: 0x7FFE87BDB450
        public void get_isHumanMotion(){} // RVA: 0x7FFE87BDB4A0
        public void get_averageSpeed_Injected(){} // RVA: 0x7FFE87BDB4F0
    }

    public class MultilineAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C60520
    }

}