// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 7
// Methods: 64

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class IDeserializationCallback
    {
        // ── Methods ──
        public void OnDeserialization(){} // RVA: 0x7FFD4E090A40
    }

    public class IFormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFD4E08A6F0
        public void ToBoolean(){} // RVA: 0x7FFD4E079F60
        public void ToByte(){} // RVA: 0x7FFD4E079F60
        public void ToInt16(){} // RVA: 0x7FFD4E07F5D0
        public void ToInt32(){} // RVA: 0x7FFD4E07E6B0
        public void ToUInt32(){} // RVA: 0x7FFD4E07E6B0
        public void ToInt64(){} // RVA: 0x7FFD4E078F40
        public void ToSingle(){} // RVA: 0x7FFD4E08DF90
        public void ToString(){} // RVA: 0x7FFD4E078F40
    }

    public class IObjectReference
    {
        // ── Methods ──
        public void GetRealObject(){} // RVA: 0x7FFD4E078F40
    }

    public class ISerializable
    {
        // ── Methods ──
        public void GetObjectData(){}
    }

    public class SerializationBinder : Object
    {
        // ── Methods ──
        public void BindToName(){} // RVA: 0x7FFD538BE540
        public void BindToType(){} // RVA: 0x7FFD4E08A6F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SerializationInfo : Object
    {
        public object FullTypeName;
        public object AssemblyName;
        public object MemberCount;
        public object ObjectType;
        public object IsFullTypeNameSetExplicit;
        public object IsAssemblyNameSetExplicit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538CA7C0 | overloaded x2
        public void get_FullTypeName(){} // RVA: 0x7FFD4E3BE740
        public void get_AssemblyName(){} // RVA: 0x7FFD4E3BC730
        public void SetType(){} // RVA: 0x7FFD538CAC40
        public void Compare(){} // RVA: 0x7FFD538CAEC0
        public void DemandForUnsafeAssemblyNameAssignments(){} // RVA: 0x7FFD538CAF40
        public void IsAssemblyNameAssignmentSafe(){} // RVA: 0x7FFD538CAF50
        public void get_MemberCount(){} // RVA: 0x7FFD4E39CCD0
        public void get_ObjectType(){} // RVA: 0x7FFD4E3E20E0
        public void get_IsFullTypeNameSetExplicit(){} // RVA: 0x7FFD4E55F600
        public void get_IsAssemblyNameSetExplicit(){} // RVA: 0x7FFD52BACF40
        public void GetEnumerator(){} // RVA: 0x7FFD538CB220
        public void ExpandArrays(){} // RVA: 0x7FFD538CB3A0
        public void AddValue(){} // RVA: 0x7FFD538CCED0 | overloaded x14
        public void AddValueInternal(){} // RVA: 0x7FFD538CD090
        public void UpdateValue(){} // RVA: 0x7FFD538CD290
        public void FindElement(){} // RVA: 0x7FFD538CD390
        public void GetElement(){} // RVA: 0x7FFD538CD490
        public void GetElementNoThrow(){} // RVA: 0x7FFD538CD5F0
        public void GetValue(){} // RVA: 0x7FFD538CD720
        public void GetValueNoThrow(){} // RVA: 0x7FFD538CD900
        public void GetBoolean(){} // RVA: 0x7FFD538CDAE0
        public void GetByte(){} // RVA: 0x7FFD538CDC40
        public void GetInt16(){} // RVA: 0x7FFD538CDDA0
        public void GetInt32(){} // RVA: 0x7FFD538CDF00
        public void GetUInt32(){} // RVA: 0x7FFD538CE060
        public void GetInt64(){} // RVA: 0x7FFD538CE1C0
        public void GetSingle(){} // RVA: 0x7FFD538CE320
        public void GetString(){} // RVA: 0x7FFD538CE480
    }

    public class StreamingContext : ValueType
    {
        public object Context;
        public object State;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538CE640 | overloaded x2
        public void get_Context(){} // RVA: 0x7FFD4EEF9F60
        public void Equals(){} // RVA: 0x7FFD538CE6A0
        public void GetHashCode(){} // RVA: 0x7FFD4FDE7500
        public void get_State(){} // RVA: 0x7FFD4FDE7500
    }

}