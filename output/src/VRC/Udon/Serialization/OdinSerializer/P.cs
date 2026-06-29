// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 32

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class PrefabModification : Object
    {
        public object ModificationType;
        public object Path;
        public object ReferencePaths;
        public object ModifiedValue;
        public object NewLength;
        public object DictionaryKeysAdded;
        public object DictionaryKeysRemoved;

        // ── Methods ──
        public void Apply(){} // RVA: 0x84A6D70
        public void ApplyValue(){} // RVA: 0x84A6E30
        public void ApplyListLength(){} // RVA: 0x84A7110
        public void ApplyDictionaryModifications(){} // RVA: 0x84A7D50
        public void ReplaceAllReferencesInGraph(){} // RVA: 0x84A8470
        public void GetInstanceFromPath(){} // RVA: 0x84A8A20
        public void GetInstanceOfStep(){} // RVA: 0x84A8B10
        public void SetInstanceToPath(){} // RVA: 0x84A9D50
        public void TrySetInstanceOfStep(){} // RVA: 0x84A9E50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PreviouslySerializedAsAttribute : Attribute
    {
        public object _name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class PrimitiveArrayFormatter`1 : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x87C0A0
        public void Read(){} // RVA: 0x8943B0
        public void Write(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ProperBitConverter : Object
    {
        public object ByteToHexCharLookupLowerCase;
        public object ByteToHexCharLookupUpperCase;
        public object HexToByteLookup;

        // ── Methods ──
        public void CreateByteToHexLookup(){} // RVA: 0x84AB420
        public void BytesToHexString(){} // RVA: 0x84AB780
        public void HexStringToBytes(){} // RVA: 0x84AB950
        public void ToInt16(){} // RVA: 0x84AC0F0
        public void ToUInt16(){} // RVA: 0x84AC0F0
        public void ToInt32(){} // RVA: 0x6653A50
        public void ToUInt32(){} // RVA: 0x6653A50
        public void ToInt64(){} // RVA: 0x84AC140
        public void ToUInt64(){} // RVA: 0x84AC140
        public void ToSingle(){} // RVA: 0x84AC250
        public void ToDouble(){} // RVA: 0x84AC2D0
        public void ToDecimal(){} // RVA: 0x84AC3B0
        public void ToGuid(){} // RVA: 0x84AC3B0
        public void GetBytes(){} // RVA: 0x84ACA00
        public void .cctor(){} // RVA: 0x84ACC30
    }

}