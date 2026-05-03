// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 42

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class PrefabModification : Object
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFE883A7030
        public void ApplyValue(){} // RVA: 0x7FFE883A70F0
        public void ApplyListLength(){} // RVA: 0x7FFE883A73D0
        public void ApplyDictionaryModifications(){} // RVA: 0x7FFE883A8030
        public void ReplaceAllReferencesInGraph(){} // RVA: 0x7FFE883A86E0
        public void GetInstanceFromPath(){} // RVA: 0x7FFE883A8CA0
        public void GetInstanceOfStep(){} // RVA: 0x7FFE883A8D90
        public void SetInstanceToPath(){} // RVA: 0x7FFE883A9FD0 | overloaded x2
        public void TrySetInstanceOfStep(){} // RVA: 0x7FFE883AA0D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PreviouslySerializedAsAttribute : Attribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class PrimitiveArrayFormatter`1 : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFE80E2E2E0
        public void Read(){} // RVA: 0x7FFE80E4F230
        public void Write(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ProperBitConverter : Object
    {
        // ── Methods ──
        public void CreateByteToHexLookup(){} // RVA: 0x7FFE883AB6D0
        public void BytesToHexString(){} // RVA: 0x7FFE883ABA30
        public void HexStringToBytes(){} // RVA: 0x7FFE883ABB70
        public void ToInt16(){} // RVA: 0x7FFE883AC330
        public void ToUInt16(){} // RVA: 0x7FFE883AC330
        public void ToInt32(){} // RVA: 0x7FFE8671BEF0
        public void ToUInt32(){} // RVA: 0x7FFE8671BEF0
        public void ToInt64(){} // RVA: 0x7FFE883AC380
        public void ToUInt64(){} // RVA: 0x7FFE883AC380
        public void ToSingle(){} // RVA: 0x7FFE883AC490
        public void ToDouble(){} // RVA: 0x7FFE883AC510
        public void ToDecimal(){} // RVA: 0x7FFE883AC5F0
        public void ToGuid(){} // RVA: 0x7FFE883AC5F0
        public void GetBytes(){} // RVA: 0x7FFE883ACC50 | overloaded x10
        public void .cctor(){} // RVA: 0x7FFE883ACE80
    }

}