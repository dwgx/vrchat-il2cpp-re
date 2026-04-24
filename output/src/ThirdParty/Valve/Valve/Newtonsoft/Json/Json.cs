// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json
// Classes: 3
// Methods: 67

namespace ThirdParty.Valve.Valve.Newtonsoft.Json
{
    public class IArrayPool`1
    {
        // ── Methods ──
        public void Rent(){} // RVA: 0x7FFD4E087DE0
        public void Return(){} // RVA: 0x7FFD4E090A40
    }

    public class JsonConvert : Object
    {
        public ormation<l.siteShoulder> DefaultSettings;
        public string True; // 0x8
        public string False; // 0x10
        public string Null; // 0x18
        public string Undefined; // 0x20
        public string PositiveInfinity; // 0x28
        public string NegativeInfinity; // 0x30
        public string NaN; // 0x38

        // ── Methods ──
        public void get_DefaultSettings(){} // RVA: 0x7FFD550C48E0
        public void ToString(){} // RVA: 0x7FFD550C54E0 | overloaded x8
        public void EnsureFloatFormat(){} // RVA: 0x7FFD550C4CD0
        public void EnsureDecimalPlace(){} // RVA: 0x7FFD550C5130 | overloaded x2
        public void SerializeObject(){} // RVA: 0x7FFD550C56B0 | overloaded x2
        public void SerializeObjectInternal(){} // RVA: 0x7FFD550C5780
        public void DeserializeObject(){} // RVA: 0x7FFD550C5A70 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD550C5D40
    }

    public class JsonSerializer : Object
    {
        public l.hts ReferenceResolver; // 0x10
        public ri.operties Binder; // 0x14
        public l.istAlign TraceWriter; // 0x18
        public l._rightLegMapping EqualityComparer; // 0x1C
        public l.ay TypeNameHandling; // 0x20
        public l.eadMapping TypeNameAssemblyFormat; // 0x24
        public l.leftLegMapping PreserveReferencesHandling; // 0x28
        public l.aneRotationOffset ReferenceLoopHandling; // 0x2C
        public l.chainIndex2 MissingMemberHandling; // 0x30
        public l.rcCharacterSpaceBendOffsetLeft NullValueHandling; // 0x34
        public l.mPoleAxis DefaultValueHandling; // 0x38
        public eControlBarClose.iteEndAsync ObjectCreationHandling; // 0x40
        public eControlBarClose.dentAsync ConstructorHandling; // 0x48
        public mePatterns.djustment MetadataPropertyHandling; // 0x50
        public externalClaims.or<System.Security.Claims.Claim>.Current Converters; // 0x58
        public externalClaims.nvoySinks ContractResolver; // 0x60
        public eControlBarClose.eAsync Context; // 0x70
        public aphy<l.ateTokenTypeMap> Formatting; // 0x78
        public aphy<l.entationsSet> CheckAdditionalContent; // 0x80
        public aphy<l.ToBone> _dateTimeZoneHandling; // 0x88
        public aphy<l._isEndEffector> _dateParseHandling; // 0x90
        public aphy<l.?> _floatFormatHandling; // 0x98
        public aphy<l.intainRelativePositionWeight> _floatParseHandling; // 0xA0
        public aphy<l.OffsetRight> _stringEscapeHandling; // 0xA8
        public 0.T_I8 _culture; // 0xB0
        public aphy<int> _maxDepth; // 0xB8
        public bool _maxDepthSet; // 0xC0
        public aphy<bool> _checkAdditionalContent; // 0xC1
        public string _dateFormatString; // 0xC8
        public bool _dateFormatStringSet; // 0xD0
        public tTable<eControlBarClose.ize> Error; // 0xD8

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFD550CCA40
        public void remove_Error(){} // RVA: 0x7FFD550CCB40
        public void set_ReferenceResolver(){} // RVA: 0x7FFD550CCC40
        public void set_Binder(){} // RVA: 0x7FFD550CCD10
        public void get_TraceWriter(){} // RVA: 0x7FFD4E3BC730
        public void set_TraceWriter(){} // RVA: 0x7FFD4E3BC740
        public void set_EqualityComparer(){} // RVA: 0x7FFD4E4994D0
        public void set_TypeNameHandling(){} // RVA: 0x7FFD550CCDE0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFD550CCE50
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFD550CCEC0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFD550CCF30
        public void set_MissingMemberHandling(){} // RVA: 0x7FFD550CCFA0
        public void set_NullValueHandling(){} // RVA: 0x7FFD550CD010
        public void set_DefaultValueHandling(){} // RVA: 0x7FFD550CD080
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFD550CD0F0
        public void set_ConstructorHandling(){} // RVA: 0x7FFD550CD160
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFD4EEFEDC0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFD550CD1D0
        public void get_Converters(){} // RVA: 0x7FFD550CD240
        public void get_ContractResolver(){} // RVA: 0x7FFD4E3BE740
        public void set_ContractResolver(){} // RVA: 0x7FFD550CD320
        public void get_Context(){} // RVA: 0x7FFD513F8A60
        public void set_Context(){} // RVA: 0x7FFD53B1BC40
        public void get_Formatting(){} // RVA: 0x7FFD550CD3E0
        public void set_Formatting(){} // RVA: 0x7FFD550CD440
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFD550CD4A0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFD550CD500
        public void IsCheckAdditionalContentSet(){} // RVA: 0x7FFD550CD560
        public void .ctor(){} // RVA: 0x7FFD550CD5B0
        public void Create(){} // RVA: 0x7FFD550CD8A0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFD550CDA10 | overloaded x2
        public void ApplySerializerSettings(){} // RVA: 0x7FFD550CDA50
        public void Deserialize(){} // RVA: 0x7FFD550CE610 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFD550CE630
        public void SetupReader(){} // RVA: 0x7FFD550CE930
        public void ResetReader(){} // RVA: 0x7FFD550CEF50
        public void Serialize(){} // RVA: 0x7FFD550CF220 | overloaded x2
        public void SerializeInternal(){} // RVA: 0x7FFD550CF250
        public void GetReferenceResolver(){} // RVA: 0x7FFD550CFA10
        public void GetMatchingConverter(){} // RVA: 0x7FFD550CFAC0 | overloaded x2
        public void OnError(){} // RVA: 0x7FFD53B1EF60
    }

}