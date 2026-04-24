// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 14
// Methods: 183

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Scale : ValueType
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5501D480
        public void Initial(){} // RVA: 0x7FFD5501D520
        public void None(){} // RVA: 0x7FFD5501D630
        public void get_value(){} // RVA: 0x7FFD5072B520
        public void op_Equality(){} // RVA: 0x7FFD5501D670
        public void op_Inequality(){} // RVA: 0x7FFD5501D6D0
        public void Equals(){} // RVA: 0x7FFD5501D770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5501D840
        public void ToString(){} // RVA: 0x7FFD54CCEFF0
    }

    public class ScheduledItem : Object
    {
        public object startMs;
        public object delayMs;
        public object intervalMs;
        public object endTimeMs;

        // ── Methods ──
        public void get_startMs(){} // RVA: 0x7FFD4E3447C0
        public void set_startMs(){} // RVA: 0x7FFD4ECB20D0
        public void get_delayMs(){} // RVA: 0x7FFD4E36F0C0
        public void set_delayMs(){} // RVA: 0x7FFD4EB2BEE0
        public void get_intervalMs(){} // RVA: 0x7FFD4E36F130
        public void set_intervalMs(){} // RVA: 0x7FFD4E7F3BF0
        public void get_endTimeMs(){} // RVA: 0x7FFD4E5F95E0
        public void .ctor(){} // RVA: 0x7FFD54FF2020
        public void ResetStartTime(){} // RVA: 0x7FFD54FF2110
        public void PerformTimerUpdate(){}
        public void OnItemUnscheduled(){} // RVA: 0x7FFD4E341310
        public void ShouldUnschedule(){} // RVA: 0x7FFD54FF2160
        public void .cctor(){} // RVA: 0x7FFD54FF2190
    }

    public class SortColumnDescription : Object
    {
        public object columnName;
        public object columnIndex;
        public object column;
        public object direction;

        // ── Methods ──
        public void get_columnName(){} // RVA: 0x7FFD4E3447C0
        public void set_columnName(){} // RVA: 0x7FFD54F6F490
        public void get_columnIndex(){} // RVA: 0x7FFD4E38E5C0
        public void set_columnIndex(){} // RVA: 0x7FFD54F6F550
        public void get_column(){} // RVA: 0x7FFD4E36F130
        public void set_column(){} // RVA: 0x7FFD4E342E90
        public void get_direction(){} // RVA: 0x7FFD4E4FBBE0
        public void set_direction(){} // RVA: 0x7FFD54F6F580
        public void add_changed(){} // RVA: 0x7FFD54F6F5B0
        public void remove_changed(){} // RVA: 0x7FFD54F6F6B0
        public void .ctor(){} // RVA: 0x7FFD54F6F820 | overloaded x3
    }

    public class SortColumnDescriptions : Object
    {
        public object Count;
        public object IsReadOnly;

        // ── Methods ──
        public void add_changed(){} // RVA: 0x7FFD54F6F870
        public void remove_changed(){} // RVA: 0x7FFD54F6F960
        public void GetEnumerator(){} // RVA: 0x7FFD54F6FA50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54F6FA50
        public void Add(){} // RVA: 0x7FFD54F6FAA0
        public void Clear(){} // RVA: 0x7FFD54F6FB10
        public void Contains(){} // RVA: 0x7FFD54F6FCA0
        public void CopyTo(){} // RVA: 0x7FFD54F6FD00
        public void Remove(){} // RVA: 0x7FFD54F6FDE0
        public void OnDescriptionChanged(){} // RVA: 0x7FFD4E6233B0
        public void get_Count(){} // RVA: 0x7FFD54F70020
        public void get_IsReadOnly(){} // RVA: 0x7FFD54F70070
        public void Insert(){} // RVA: 0x7FFD54F700C0
        public void .ctor(){} // RVA: 0x7FFD54F703E0
    }

    public class StartDragArgs : ValueType
    {
        public object title;
        public object visualMode;
        public object genericData;
        public object unityObjectReferences;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54F91E30
        public void get_title(){} // RVA: 0x7FFD4EEF9F60
        public void get_visualMode(){} // RVA: 0x7FFD4FDE7500
        public void get_genericData(){} // RVA: 0x7FFD4E35C380
        public void set_genericData(){} // RVA: 0x7FFD4E342E30
        public void get_unityObjectReferences(){} // RVA: 0x7FFD4E3447C0
        public void set_unityObjectReferences(){} // RVA: 0x7FFD4E3A7E80
        public void SetGenericData(){} // RVA: 0x7FFD54F91F40
    }

    public class StyleDataRef`1 : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFD4E2ADC40
        public void Release(){} // RVA: 0x7FFD4E090980
        public void CopyFrom(){} // RVA: 0x7FFD4E2ADC40
        public void Read(){} // RVA: 0x7FFD4E078E90
        public void Write(){} // RVA: 0x7FFD4E078E90
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void op_Equality(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void ReferenceEquals(){} // RVA: 0x7FFD4E2ADC40
    }

    public class StyleEnum`1 : ValueType
    {
        public object value;
        public object keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void get_keyword(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void op_Equality(){} // RVA: 0x7FFD4E2ADC40
        public void op_Inequality(){} // RVA: 0x7FFD4E2ADC40
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void ToString(){} // RVA: 0x7FFD4E078E90
    }

    public class StylePropertyAnimationSystem : Object
    {
        public long m_CurrentTimeMs; // 0x10
        public _translate m_Floats; // 0x18
        public e m_Ints; // 0x20
        public ine.UIElements.IStyle.get_scale m_Lengths; // 0x28
        public s.IStyle.get_scale m_Colors; // 0x30
        public e m_Backgrounds; // 0x38
        public etInlineTranslate m_FontDefinitions; // 0x40
        public oveInlineStyle m_Fonts; // 0x48
        public yle m_TextShadows; // 0x50
        public ursor m_Scale; // 0x58
        public InlineTextShadow m_Rotate; // 0x60
        public dow m_Translate; // 0x68
        public TransformOrigin m_TransformOrigin; // 0x70
        public InlineTranslate m_BackgroundPosition; // 0x78
        public ineRotate m_BackgroundRepeat; // 0x80
        public cale m_BackgroundSize; // 0x88
        public URA.woDigitYearMax<?> m_AllValues; // 0x90
        public URA.DateTime<tor.exSort,?> m_PropertyToValues; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55021960
        public void GetOrCreate(){} // RVA: 0x7FFD4E2ADC40
        public void StartTransition(){} // RVA: 0x7FFD55023670 | overloaded x16
        public void CancelAllAnimations(){} // RVA: 0x7FFD550239E0 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x7FFD55023BE0
        public void UpdateAnimation(){} // RVA: 0x7FFD55023C80
        public void GetAllAnimations(){} // RVA: 0x7FFD55023D20
        public void UpdateTracking(){} // RVA: 0x7FFD4E090A40
        public void CurrentTimeMs(){} // RVA: 0x7FFD510E4750
        public void Update(){} // RVA: 0x7FFD55023EA0
    }

    public class StylePropertyName : ValueType
    {
        public object id;
        public object name;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4F840210
        public void get_name(){} // RVA: 0x7FFD4F840220
        public void StylePropertyIdFromString(){} // RVA: 0x7FFD55028930
        public void .ctor(){} // RVA: 0x7FFD55028B70 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54C58C50
        public void op_Inequality(){} // RVA: 0x7FFD55028D10
        public void op_Implicit(){} // RVA: 0x7FFD55028D20
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C58C50 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD53AD4B80
    }

    public class StylePropertyNameCollection : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void GetEnumerator(){} // RVA: 0x7FFD54FB1F60
        public void System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator(){} // RVA: 0x7FFD54FB20E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54FB2150
    }

    public class StyleSheet : ScriptableObject
    {
        public object importedWithErrors;
        public object importedWithWarnings;
        public object rules;
        public object complexSelectors;
        public object flattenedRecursiveImports;
        public object contentHash;
        public object isDefaultStyleSheet;

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7FFD54C48D80
        public void set_importedWithErrors(){} // RVA: 0x7FFD4E35C4F0
        public void get_importedWithWarnings(){} // RVA: 0x7FFD5502AAC0
        public void set_importedWithWarnings(){} // RVA: 0x7FFD4E935120
        public void get_rules(){} // RVA: 0x7FFD545DAEE0
        public void set_rules(){} // RVA: 0x7FFD5502AAD0
        public void get_complexSelectors(){} // RVA: 0x7FFD54CFDAD0
        public void set_complexSelectors(){} // RVA: 0x7FFD5502AB30
        public void get_flattenedRecursiveImports(){} // RVA: 0x7FFD54D3F9B0
        public void get_contentHash(){} // RVA: 0x7FFD5502AB90
        public void set_contentHash(){} // RVA: 0x7FFD4FBDAB60
        public void get_isDefaultStyleSheet(){} // RVA: 0x7FFD5502ABA0
        public void set_isDefaultStyleSheet(){} // RVA: 0x7FFD5502ABB0
        public void TryCheckAccess(){} // RVA: 0x7FFD4E2ADC40
        public void CheckAccess(){} // RVA: 0x7FFD4E2ADC40
        public void OnEnable(){} // RVA: 0x7FFD5502AD10
        public void FlattenImportedStyleSheetsRecursive(){} // RVA: 0x7FFD5502ADF0 | overloaded x2
        public void SetupReferences(){} // RVA: 0x7FFD5502AF80
        public void ReadKeyword(){} // RVA: 0x7FFD54ECA5C0
        public void ReadFloat(){} // RVA: 0x7FFD5502B690
        public void TryReadFloat(){} // RVA: 0x7FFD5502B770
        public void ReadDimension(){} // RVA: 0x7FFD5502B880
        public void TryReadDimension(){} // RVA: 0x7FFD5502B960
        public void ReadColor(){} // RVA: 0x7FFD5502BA80
        public void TryReadColor(){} // RVA: 0x7FFD5502BB30
        public void ReadString(){} // RVA: 0x7FFD5502BBD0
        public void TryReadString(){} // RVA: 0x7FFD5502BC50
        public void ReadEnum(){} // RVA: 0x7FFD5502BCF0
        public void TryReadEnum(){} // RVA: 0x7FFD5502BD70
        public void ReadVariable(){} // RVA: 0x7FFD5502BE10
        public void TryReadVariable(){} // RVA: 0x7FFD5502BE90
        public void ReadResourcePath(){} // RVA: 0x7FFD5502BF30
        public void TryReadResourcePath(){} // RVA: 0x7FFD5502BFB0
        public void ReadAssetReference(){} // RVA: 0x7FFD5502C050
        public void ReadMissingAssetReferenceUrl(){} // RVA: 0x7FFD5502C0D0
        public void TryReadAssetReference(){} // RVA: 0x7FFD5502C150
        public void ReadFunction(){} // RVA: 0x7FFD54ECA5C0
        public void ReadFunctionName(){} // RVA: 0x7FFD5502C1F0
        public void ReadScalableImage(){} // RVA: 0x7FFD5502C490
        public void CustomStartsWith(){} // RVA: 0x7FFD5502C540
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void .cctor(){} // RVA: 0x7FFD5502C620
    }

    public class StyleValueCollection : Object
    {
        // ── Methods ──
        public void GetStyleLength(){} // RVA: 0x7FFD5501C3B0
        public void GetStyleFloat(){} // RVA: 0x7FFD5501C460
        public void GetStyleInt(){} // RVA: 0x7FFD5501C4D0
        public void TryGetStyleValue(){} // RVA: 0x7FFD5501C550
        public void SetStyleValue(){} // RVA: 0x7FFD5501C6F0
        public void .ctor(){} // RVA: 0x7FFD5501C900
    }

    public class StyleValueExtensions : Object
    {
        // ── Methods ──
        public void DebugString(){} // RVA: 0x7FFD4E078F80
        public void ToYogaValue(){} // RVA: 0x7FFD55020760
        public void ToLength(){} // RVA: 0x7FFD55020D60 | overloaded x2
        public void ToRotate(){} // RVA: 0x7FFD55020A20
        public void ToScale(){} // RVA: 0x7FFD55020B40
        public void ToTranslate(){} // RVA: 0x7FFD55020C50
        public void CopyFrom(){} // RVA: 0x7FFD4E090C80
    }

    public class StyleValueHandle : ValueType
    {
        public object valueType;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFD543B3F90
        public void set_valueType(){} // RVA: 0x7FFD4E78D8B0
    }

}