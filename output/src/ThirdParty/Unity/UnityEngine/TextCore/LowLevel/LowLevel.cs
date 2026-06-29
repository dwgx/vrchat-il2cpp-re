// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TextCore.LowLevel
// Classes: 24
// Methods: 332

namespace ThirdParty.Unity.UnityEngine.TextCore.LowLevel
{
    public class FontEngine : Object
    {
        // ── Methods ──
        public void SetMarshallingArraySize(){} // RVA: 0x89AB50
        public void GenericListToMarshallingArray(){} // RVA: 0x8945C0
        public void LoadFontFace(){} // RVA: 0x7DBBD20
        public void LoadFontFace_Internal(){} // RVA: 0x7DBB6E0
        public void LoadFontFace_With_Size_And_FaceIndex_Internal(){} // RVA: 0x7DBB940
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(){} // RVA: 0x7DBBC50
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(){} // RVA: 0x7DBBE10
        public void UnloadFontFace(){} // RVA: 0x7DBC040
        public void UnloadFontFace_Internal(){} // RVA: 0x7DBC0C0
        public void IsColorFontFace(){} // RVA: 0x7DBC110
        public void TryGetSystemFontReference(){} // RVA: 0x7DBC160
        public void TryGetSystemFontReference_Internal(){} // RVA: 0x7DBC1D0
        public void GetFaceInfo(){} // RVA: 0x7DBC400
        public void GetFaceInfo_Internal(){} // RVA: 0x7DBC500
        public void GetFontFaces(){} // RVA: 0x7DBC550
        public void GetFontFaces_Internal(){} // RVA: 0x7DBC5E0
        public void GetVariantGlyphIndex(){} // RVA: 0x7DBC630
        public void GetGlyphIndex(){} // RVA: 0x7DBC690
        public void TryGetGlyphWithUnicodeValue(){} // RVA: 0x7DBC6E0
        public void TryGetGlyphWithUnicodeValue_Internal(){} // RVA: 0x7DBC910
        public void TryGetGlyphWithIndexValue(){} // RVA: 0x7DBC980
        public void TryGetGlyphWithIndexValue_Internal(){} // RVA: 0x7DBCBB0
        public void SetTextureUploadMode(){} // RVA: 0x7DBCC20
        public void TryAddGlyphToTexture(){} // RVA: 0x7DBCC70
        public void TryAddGlyphToTexture_Internal(){} // RVA: 0x7DBD410
        public void TryAddGlyphsToTexture(){} // RVA: 0x7DBD6A0
        public void TryAddGlyphsToTexture_Internal(){} // RVA: 0x7DBE330
        public void GetAllLigatureSubstitutionRecords(){} // RVA: 0x7DBE890
        public void GetLigatureSubstitutionRecords(){} // RVA: 0x7DBEAC0
        public void PopulateLigatureSubstitutionRecordMarshallingArray(){} // RVA: 0x7DBEDC0
        public void GetLigatureSubstitutionRecordsFromMarshallingArray(){} // RVA: 0x7DBEED0
        public void GetGlyphPairAdjustmentTable(){} // RVA: 0x7DBEF20
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(){} // RVA: 0x7DBF180
        public void GetAllPairAdjustmentRecords(){} // RVA: 0x7DBF290
        public void GetPairAdjustmentRecords(){} // RVA: 0x7DBF590
        public void PopulatePairAdjustmentRecordMarshallingArray(){} // RVA: 0x7DBF7F0
        public void GetPairAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7DBF900
        public void GetAllMarkToBaseAdjustmentRecords(){} // RVA: 0x7DBF9D0
        public void GetMarkToBaseAdjustmentRecords(){} // RVA: 0x7DBFCD0
        public void PopulateMarkToBaseAdjustmentRecordMarshallingArray(){} // RVA: 0x7DC0090
        public void GetMarkToBaseAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7DC01A0
        public void GetAllMarkToMarkAdjustmentRecords(){} // RVA: 0x7DC0270
        public void GetMarkToMarkAdjustmentRecords(){} // RVA: 0x7DC0570
        public void PopulateMarkToMarkAdjustmentRecordMarshallingArray(){} // RVA: 0x7DC0950
        public void GetMarkToMarkAdjustmentRecordsFromMarshallingArray(){} // RVA: 0x7DC0A60
        public void GlyphIndexToMarshallingArray(){} // RVA: 0x7DC0B30
        public void ResetAtlasTexture(){} // RVA: 0x7DC0C10
        public void .cctor(){} // RVA: 0x7DC0CD0
        public void LoadFontFace_Internal_Injected(){} // RVA: 0x7DC1070
        public void LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(){} // RVA: 0x7DC10C0
        public void LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(){} // RVA: 0x7DC1130
        public void LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(){} // RVA: 0x7DC11A0
        public void TryGetSystemFontReference_Internal_Injected(){} // RVA: 0x7DC1210
        public void TryAddGlyphToTexture_Internal_Injected(){} // RVA: 0x7DC1280
        public void TryAddGlyphsToTexture_Internal_Injected(){} // RVA: 0x7DC1300
        public void PopulateLigatureSubstitutionRecordMarshallingArray_Injected(){} // RVA: 0x7DC1390
        public void PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(){} // RVA: 0x7DC13F0
        public void GetAllPairAdjustmentRecords_Injected(){} // RVA: 0x7DC1450
        public void PopulatePairAdjustmentRecordMarshallingArray_Injected(){} // RVA: 0x7DC14A0
        public void GetPairAdjustmentRecordsFromMarshallingArray_Injected(){} // RVA: 0x7DC1500
        public void GetAllMarkToBaseAdjustmentRecords_Injected(){} // RVA: 0x7DC1550
        public void PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(){} // RVA: 0x7DC15A0
        public void GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(){} // RVA: 0x7DC1600
        public void GetAllMarkToMarkAdjustmentRecords_Injected(){} // RVA: 0x7DC1650
        public void PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(){} // RVA: 0x7DC16A0
        public void GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(){} // RVA: 0x7DC1700
        public void ResetAtlasTexture_Injected(){} // RVA: 0x7DC1750
    }

    public class FontEngineUtilities : ValueType
    {
        // ── Methods ──
        public void MaxValue(){} // RVA: 0x7DC17A0
    }

    public class FontReference[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphAdjustmentRecord : ValueType
    {
        // ── Methods ──
        public void get_glyphIndex(){} // RVA: 0x454FE0
        public void get_glyphValueRecord(){} // RVA: 0x98C0F0
        public void .ctor(){} // RVA: 0x3612F0
        public void GetHashCode(){} // RVA: 0x98C100
        public void Equals(){} // RVA: 0x98C1D0
    }

    public class GlyphAdjustmentRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphAnchorPoint : ValueType
    {
        // ── Methods ──
        public void get_xCoordinate(){} // RVA: 0x459690
        public void set_xCoordinate(){} // RVA: 0xD1B20
        public void get_yCoordinate(){} // RVA: 0x958940
        public void set_yCoordinate(){} // RVA: 0xD1B40
    }

    public class GlyphAnchorPoint[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphLoadFlags[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphMarshallingStruct[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAF4F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7C740
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC81A0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6B490
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7C740
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphPackingMode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphPairAdjustmentRecord : ValueType
    {
        // ── Methods ──
        public void get_firstAdjustmentRecord(){} // RVA: 0x98C260
        public void set_firstAdjustmentRecord(){} // RVA: 0x935860
        public void get_secondAdjustmentRecord(){} // RVA: 0x98C280
        public void get_featureLookupFlags(){} // RVA: 0x53FAD0
        public void .ctor(){} // RVA: 0x98C2A0
        public void GetHashCode(){} // RVA: 0x98C2D0
        public void Equals(){} // RVA: 0x98C2F0
    }

    public class GlyphPairAdjustmentRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAF730
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7C800
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC82F0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6B660
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7C800
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphRenderMode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GlyphValueRecord : ValueType
    {
        // ── Methods ──
        public void get_xPlacement(){} // RVA: 0x459690
        public void set_xPlacement(){} // RVA: 0xD1B20
        public void get_yPlacement(){} // RVA: 0x958940
        public void set_yPlacement(){} // RVA: 0xD1B40
        public void get_xAdvance(){} // RVA: 0x958950
        public void set_xAdvance(){} // RVA: 0xD1B50
        public void get_yAdvance(){} // RVA: 0x958960
        public void .ctor(){} // RVA: 0x4FE0
        public void op_Addition(){} // RVA: 0x7DC17C0
        public void GetHashCode(){} // RVA: 0x98BFA0
        public void Equals(){} // RVA: 0x98C070
    }

    public class GlyphValueRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LigatureSubstitutionRecord : ValueType
    {
        // ── Methods ──
        public void get_componentGlyphIDs(){} // RVA: 0x44D9F0
        public void set_componentGlyphIDs(){} // RVA: 0x47F10
        public void get_ligatureGlyphID(){} // RVA: 0x438050
        public void set_ligatureGlyphID(){} // RVA: 0x92DD0
        public void Equals(){} // RVA: 0x98C350
        public void GetHashCode(){} // RVA: 0x8F6C30
        public void op_Equality(){} // RVA: 0x7DC1DF0
    }

    public class LigatureSubstitutionRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB35F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6E310
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MarkPositionAdjustment : ValueType
    {
        // ── Methods ──
        public void get_xPositionAdjustment(){} // RVA: 0x459690
        public void set_xPositionAdjustment(){} // RVA: 0xD1B20
        public void get_yPositionAdjustment(){} // RVA: 0x958940
        public void set_yPositionAdjustment(){} // RVA: 0xD1B40
    }

    public class MarkPositionAdjustment[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MarkToBaseAdjustmentRecord : ValueType
    {
        // ── Methods ──
        public void get_baseGlyphID(){} // RVA: 0x454FE0
        public void set_baseGlyphID(){} // RVA: 0x29580
        public void get_baseGlyphAnchorPoint(){} // RVA: 0x971F40
        public void set_baseGlyphAnchorPoint(){} // RVA: 0x8C0C90
        public void get_markGlyphID(){} // RVA: 0x448F30
        public void set_markGlyphID(){} // RVA: 0x92DF0
        public void get_markPositionAdjustment(){} // RVA: 0x984800
        public void set_markPositionAdjustment(){} // RVA: 0xE1E10
    }

    public class MarkToBaseAdjustmentRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MarkToMarkAdjustmentRecord : ValueType
    {
        // ── Methods ──
        public void get_baseMarkGlyphID(){} // RVA: 0x454FE0
        public void set_baseMarkGlyphID(){} // RVA: 0x29580
        public void get_baseMarkGlyphAnchorPoint(){} // RVA: 0x971F40
        public void set_baseMarkGlyphAnchorPoint(){} // RVA: 0x8C0C90
        public void get_combiningMarkGlyphID(){} // RVA: 0x448F30
        public void set_combiningMarkGlyphID(){} // RVA: 0x92DF0
        public void get_combiningMarkPositionAdjustment(){} // RVA: 0x984800
        public void set_combiningMarkPositionAdjustment(){} // RVA: 0xE1E10
    }

    public class MarkToMarkAdjustmentRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MultipleSubstitutionRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}