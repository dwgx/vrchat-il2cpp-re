// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 42

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class PrefabModification : Object
    {
        public 0x6B224460 ModificationType; // 0x10
        public string Path; // 0x18
        public System.Collections.Generic.List`1<string> ReferencePaths; // 0x20
        public object ModifiedValue; // 0x28
        public int NewLength; // 0x30
        public object[] DictionaryKeysAdded; // 0x38
        public object[] DictionaryKeysRemoved; // 0x40

        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFAC9FF4520
        public void ApplyValue(){} // RVA: 0x7FFAC9FF45E0
        public void ApplyListLength(){} // RVA: 0x7FFAC9FF48C0
        public void ApplyDictionaryModifications(){} // RVA: 0x7FFAC9FF5520
        public void ReplaceAllReferencesInGraph(){} // RVA: 0x7FFAC9FF5BD0
        public void GetInstanceFromPath(){} // RVA: 0x7FFAC9FF6190
        public void GetInstanceOfStep(){} // RVA: 0x7FFAC9FF6280
        public void SetInstanceToPath(){} // RVA: 0x7FFAC9FF74C0 | overloaded x2
        public void TrySetInstanceOfStep(){} // RVA: 0x7FFAC9FF75C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PreviouslySerializedAsAttribute : Attribute
    {
        public string Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class PrimitiveArrayFormatter`1 : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2C58E90
        public void Read(){} // RVA: 0x7FFAC2C79B30
        public void Write(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ProperBitConverter : Object
    {
        public uint[] ByteToHexCharLookupLowerCase;
        public uint[] ByteToHexCharLookupUpperCase; // 0x8
        public byte[] HexToByteLookup; // 0x10

        // ── Methods ──
        public void CreateByteToHexLookup(){} // RVA: 0x7FFAC9FF8BC0
        public void BytesToHexString(){} // RVA: 0x7FFAC9FF8F20
        public void HexStringToBytes(){} // RVA: 0x7FFAC9FF9060
        public void ToInt16(){} // RVA: 0x7FFAC9FF9820
        public void ToUInt16(){} // RVA: 0x7FFAC9FF9820
        public void ToInt32(){} // RVA: 0x7FFAC83725F0
        public void ToUInt32(){} // RVA: 0x7FFAC83725F0
        public void ToInt64(){} // RVA: 0x7FFAC9FF9870
        public void ToUInt64(){} // RVA: 0x7FFAC9FF9870
        public void ToSingle(){} // RVA: 0x7FFAC9FF9980
        public void ToDouble(){} // RVA: 0x7FFAC9FF9A00
        public void ToDecimal(){} // RVA: 0x7FFAC9FF9AE0
        public void ToGuid(){} // RVA: 0x7FFAC9FF9AE0
        public void GetBytes(){} // RVA: 0x7FFAC9FFA140 | overloaded x10
        public void .cctor(){} // RVA: 0x7FFAC9FFA370
    }

}