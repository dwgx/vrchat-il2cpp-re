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
        public object DefaultSettings;

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
        public object ReferenceResolver;
        public object Binder;
        public object TraceWriter;
        public object EqualityComparer;
        public object TypeNameHandling;
        public object TypeNameAssemblyFormat;
        public object PreserveReferencesHandling;
        public object ReferenceLoopHandling;
        public object MissingMemberHandling;
        public object NullValueHandling;
        public object DefaultValueHandling;
        public object ObjectCreationHandling;
        public object ConstructorHandling;
        public object MetadataPropertyHandling;
        public object Converters;
        public object ContractResolver;
        public object Context;
        public object Formatting;
        public object CheckAdditionalContent;

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