// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 15
// Methods: 95

namespace VRC.Udon.Common
{
    public class DeserializationResult : ValueType
    {
        public float sendTime; // 0x10
        public float receiveTime; // 0x14
        public bool isFromStorage; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E7F870
    }

    public class SerializationResult : ValueType
    {
        public bool success; // 0x10
        public int byteCount; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F06D0
    }

    public class UdonBaseHeapReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UdonGameObjectComponentHeapReference : UdonBaseHeapReference
    {
        public System.Type type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class UdonHeap : Object
    {
        public uint DEFAULT_CAPACITY;
        public uint MAXIMUM_CAPACITY;
        public System.Runtime.CompilerServices.IStrongBox[] _heap; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> _strongBoxOfTypeCache; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> _strongBoxOfTContainedTypeCache; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E80E70 | overloaded x3
        public void CheckHeapBounds(){} // RVA: 0x7FFAC52C5FC0
        public void IsAddressWithinBounds(){} // RVA: 0x7FFAC9E7FC20
        public void InitializeHeapVariable(){} // RVA: 0x7FFAC9E80990 | overloaded x2
        public void CopyHeapVariable(){} // RVA: 0x7FFAC9E7FC50
        public void SetHeapVariable(){} // RVA: 0x7FFAC9E80AE0 | overloaded x2
        public void SetHeapVariableInternal(){} // RVA: 0x7FFAC9E80BC0 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryGetHeapVariable(){} // RVA: 0x7FFAC9E805A0 | overloaded x2
        public void GetHeapVariableInternal(){} // RVA: 0x7FFAC2E8DC40
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFAC9E80600
        public void GetHeapVariableType(){} // RVA: 0x7FFAC9E80650
        public void GetHeapCapacity(){} // RVA: 0x7FFAC3510620
        public void DumpHeapObjects(){} // RVA: 0x7FFAC9E807D0
        public void GetObjectData(){} // RVA: 0x7FFAC9E81500
    }

    public class UdonInputEventArgs : ValueType
    {
        public 0x6B2CF550 eventType; // 0x10
        public bool boolValue; // 0x14
        public float floatValue; // 0x18
        public 0x6B2CF5A8 handType; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E81980 | overloaded x2
    }

    public class UdonProgram : Object
    {
        public string InstructionSetIdentifier; // 0x10
        public int InstructionSetVersion; // 0x18
        public byte[] ByteCode; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonHeap Heap; // 0x28
        public VRC.Udon.Common.Interfaces.IUdonSymbolTable EntryPoints; // 0x30
        public VRC.Udon.Common.Interfaces.IUdonSymbolTable SymbolTable; // 0x38
        public VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable SyncMetadataTable; // 0x40
        public int UpdateOrder; // 0x48

        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_InstructionSetVersion(){} // RVA: 0x7FFAC3157800
        public void get_ByteCode(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Heap(){} // RVA: 0x7FFAC2F4F130
        public void get_EntryPoints(){} // RVA: 0x7FFAC31D95E0
        public void get_SymbolTable(){} // RVA: 0x7FFAC31D0140
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAC2F9E740
        public void get_UpdateOrder(){} // RVA: 0x7FFAC2FC20C0
        public void .ctor(){} // RVA: 0x7FFAC9E819A0
    }

    public class UdonSymbol : Object
    {
        public string Name; // 0x10
        public System.Type Type; // 0x18
        public uint Address; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
        public void get_Address(){} // RVA: 0x7FFAC30DBBE0
        public void .ctor(){} // RVA: 0x7FFAC9E81CF0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC9E820E0
    }

    public class UdonSymbolTable : Object
    {
        public System.Collections.Immutable.ImmutableArray`1<string> _symbols; // 0x10
        public System.Collections.Immutable.ImmutableArray`1<string> _exportedSymbols; // 0x18
        public System.Collections.Immutable.ImmutableHashSet`1<string> _exportedSymbolsLookUpTable; // 0x20
        public System.Collections.Immutable.ImmutableDictionary`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _addressToSymbol; // 0x28
        public System.Collections.Immutable.ImmutableDictionary`2<string,VRC.Udon.Common.Interfaces.IUdonSymbol> _nameToSymbol; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E84350 | overloaded x3
        public void HasAddressForSymbol(){} // RVA: 0x7FFAC9E83C20
        public void HasSymbolForAddress(){} // RVA: 0x7FFAC9E83C80
        public void GetSymbolFromAddress(){} // RVA: 0x7FFAC9E83CE0
        public void TryGetSymbolFromAddress(){} // RVA: 0x7FFAC9E83EC0
        public void GetAddressFromSymbol(){} // RVA: 0x7FFAC9E84030
        public void TryGetAddressFromSymbol(){} // RVA: 0x7FFAC9E84130
        public void GetExportedSymbols(){} // RVA: 0x7FFAC2F247C0
        public void GetSymbols(){} // RVA: 0x7FFAC2F3C380
        public void HasExportedSymbol(){} // RVA: 0x7FFAC9E841F0
        public void GetSymbolType(){} // RVA: 0x7FFAC9E84250
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC9E845A0
    }

    public class UdonSyncMetadata : Object
    {
        public string Name; // 0x10
        public System.Collections.Generic.List`1<VRC.Udon.Common.Interfaces.IUdonSyncProperty> Properties; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Properties(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC9E856D0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC9E85A40
    }

    public class UdonSyncMetadataTable : Object
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Interfaces.IUdonSyncMetadata> _syncMetadataTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E86390 | overloaded x3
        public void GetAllSyncMetadata(){} // RVA: 0x7FFAC9E862D0
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7FFAC9E86320
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC9E864F0
    }

    public class UdonSyncProperty : Object
    {
        public string Name; // 0x10
        public 0x6B2CFEF0 InterpolationAlgorithm; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_InterpolationAlgorithm(){} // RVA: 0x7FFAC3157800
        public void .ctor(){} // RVA: 0x7FFAC9E84E40 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC9E850F0
    }

    public class UdonVariableTable : Object
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Interfaces.IUdonVariable> VariableSymbols; // 0x10

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFAC9E867F0
        public void .ctor(){} // RVA: 0x7FFAC9E87140 | overloaded x3
        public void TrySetVariableValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFAC9E86E50
        public void TryAddVariable(){} // RVA: 0x7FFAC9E86FC0
        public void RemoveVariable(){} // RVA: 0x7FFAC9E870E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC9E872A0
    }

    public class UdonVariable`1 : Object
    {
        public string SymbolName;
        public T Value;

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void set_Value(){} // RVA: 0x7FFAC2E8DC40
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7FFAC2C58E90
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7FFAC2C70A40
        public void get_DeclaredType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
    }

    public class VariableChangedEvent : Object
    {
        public string EVENT_PREFIX;
        public string OLD_VALUE_PREFIX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}