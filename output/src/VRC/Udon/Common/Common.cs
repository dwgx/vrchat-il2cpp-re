// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 4
// Methods: 45

namespace VRC.Udon.Common
{
    public class UdonHeap : Object
    {
        public uint DEFAULT_CAPACITY;
        public uint MAXIMUM_CAPACITY;
        public System.Runtime.CompilerServices.IStrongBox[] _heap; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> _strongBoxOfTypeCache; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> _strongBoxOfTContainedTypeCache; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552A0E70 | overloaded x3
        public void CheckHeapBounds(){} // RVA: 0x7FFD506E5FC0
        public void IsAddressWithinBounds(){} // RVA: 0x7FFD5529FC20
        public void InitializeHeapVariable(){} // RVA: 0x7FFD552A0990 | overloaded x2
        public void CopyHeapVariable(){} // RVA: 0x7FFD5529FC50
        public void SetHeapVariable(){} // RVA: 0x7FFD552A0AE0 | overloaded x2
        public void SetHeapVariableInternal(){} // RVA: 0x7FFD552A0BC0 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryGetHeapVariable(){} // RVA: 0x7FFD552A05A0 | overloaded x2
        public void GetHeapVariableInternal(){} // RVA: 0x7FFD4E2ADC40
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFD552A0600
        public void GetHeapVariableType(){} // RVA: 0x7FFD552A0650
        public void GetHeapCapacity(){} // RVA: 0x7FFD4E930620
        public void DumpHeapObjects(){} // RVA: 0x7FFD552A07D0
        public void GetObjectData(){} // RVA: 0x7FFD552A1500
    }

    public class UdonInputEventArgs : ValueType
    {
        public ÏÍÌÎÏÏ.Ï eventType; // 0x10
        public bool boolValue; // 0x14
        public float floatValue; // 0x18
        public 0x6662F5A8 handType; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552A1980 | overloaded x2
    }

    public class UdonVariableTable : Object
    {
        public System.Collections.Generic.Dictionary`2<string,0x666300A8> VariableSymbols; // 0x10

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFD552A67F0
        public void .ctor(){} // RVA: 0x7FFD552A7140 | overloaded x3
        public void TrySetVariableValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFD552A6E50
        public void TryAddVariable(){} // RVA: 0x7FFD552A6FC0
        public void RemoveVariable(){} // RVA: 0x7FFD552A70E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD552A72A0
    }

    public class UdonVariable`1 : Object
    {
        public string SymbolName;
        public T Value;

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFD4E078E90
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void set_Value(){} // RVA: 0x7FFD4E2ADC40
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7FFD4E078E90
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7FFD4E090A40
        public void get_DeclaredType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
    }

}