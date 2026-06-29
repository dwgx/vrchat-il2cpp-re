// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 15
// Methods: 75

namespace VRC.Udon.Common
{
    public class DeserializationResult : ValueType
    {
        public object sendTime;
        public object receiveTime;
        public object isFromStorage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9CC990
    }

    public class SerializationResult : ValueType
    {
        public object success;
        public object byteCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D160
    }

    public class UdonBaseHeapReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UdonGameObjectComponentHeapReference : UdonBaseHeapReference
    {
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class UdonHeap : Object
    {
        public object DEFAULT_CAPACITY;
        public object MAXIMUM_CAPACITY;
        public object _heap;
        public object _strongBoxOfTypeCache;
        public object _strongBoxOfTContainedTypeCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8335B40
        public void CheckHeapBounds(){} // RVA: 0x2AB4360
        public void IsAddressWithinBounds(){} // RVA: 0x8334980
        public void InitializeHeapVariable(){} // RVA: 0x83356C0
        public void CopyHeapVariable(){} // RVA: 0x83349B0
        public void SetHeapVariable(){} // RVA: 0x83357C0
        public void SetHeapVariableInternal(){} // RVA: 0x8335880
        public void GetHeapVariable(){} // RVA: 0xA94080
        public void TryGetHeapVariable(){} // RVA: 0x87E350
        public void GetHeapVariableInternal(){} // RVA: 0xA94080
        public void IsHeapVariableInitialized(){} // RVA: 0x8335330
        public void GetHeapVariableType(){} // RVA: 0x8335380
        public void GetHeapCapacity(){} // RVA: 0x17F0080
        public void DumpHeapObjects(){} // RVA: 0x8335500
        public void GetObjectData(){} // RVA: 0x8336160
    }

    public class UdonInputEventArgs : ValueType
    {
        public object eventType;
        public object boolValue;
        public object floatValue;
        public object handType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9CC9B0
    }

    public class UdonProgram : Object
    {
        public object _instructionSetIdentifier;
        public object _instructionSetVersion;
        public object _byteCode;
        public object _heap;
        public object _entryPoints;
        public object _symbolTable;
        public object _syncMetadataTable;
        public object _updateOrder;

        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0xB5DBF0
        public void get_InstructionSetVersion(){} // RVA: 0xE62D00
        public void get_ByteCode(){} // RVA: 0xB700F0
        public void get_Heap(){} // RVA: 0xB70160
        public void get_EntryPoints(){} // RVA: 0xD33E60
        public void get_SymbolTable(){} // RVA: 0xD05CA0
        public void get_SyncMetadataTable(){} // RVA: 0xBC1B30
        public void get_UpdateOrder(){} // RVA: 0xBE5890
        public void .ctor(){} // RVA: 0x8336600
    }

    public class UdonSymbol : Object
    {
        public object _name;
        public object _type;
        public object _address;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Type(){} // RVA: 0xB465B0
        public void get_Address(){} // RVA: 0xFEAE90
        public void .ctor(){} // RVA: 0x8336950
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x8336C80
    }

    public class UdonSymbolTable : Object
    {
        public object _symbols;
        public object _exportedSymbols;
        public object _exportedSymbolsLookUpTable;
        public object _addressToSymbol;
        public object _nameToSymbol;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8339010
        public void HasAddressForSymbol(){} // RVA: 0x83388E0
        public void HasSymbolForAddress(){} // RVA: 0x8338940
        public void GetSymbolFromAddress(){} // RVA: 0x83389A0
        public void TryGetSymbolFromAddress(){} // RVA: 0x8338B80
        public void GetAddressFromSymbol(){} // RVA: 0x8338CF0
        public void TryGetAddressFromSymbol(){} // RVA: 0x8338DF0
        public void GetExportedSymbols(){} // RVA: 0xB465B0
        public void GetSymbols(){} // RVA: 0xB5DBF0
        public void HasExportedSymbol(){} // RVA: 0x8338EB0
        public void GetSymbolType(){} // RVA: 0x8338F10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x8339210
    }

    public class UdonSyncMetadata : Object
    {
        public object _name;
        public object _properties;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Properties(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x833A2E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x833A5F0
    }

    public class UdonSyncMetadataTable : Object
    {
        public object _syncMetadataTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x833AF40
        public void GetAllSyncMetadata(){} // RVA: 0x833AE80
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x833AED0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x833B070
    }

    public class UdonSyncProperty : Object
    {
        public object _name;
        public object _interpolationAlgorithm;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_InterpolationAlgorithm(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x8339AB0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x8339D10
    }

    public class UdonVariableTable : Object
    {
        public object _publicVariables;

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x833B370
        public void .ctor(){} // RVA: 0x833BCD0
        public void TrySetVariableValue(){} // RVA: 0xA94080
        public void TryGetVariableValue(){} // RVA: 0x87D3C0
        public void TryGetVariableType(){} // RVA: 0x833B9E0
        public void TryAddVariable(){} // RVA: 0x833BB50
        public void RemoveVariable(){} // RVA: 0x833BC70
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x833BE00
    }

    public class UdonVariable`1 : Object
    {
        public object _symbolName;
        public object _value;

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0xA94080
        public void set_Value(){} // RVA: 0xA94080
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x87C0A0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x894320
        public void get_DeclaredType(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x8943B0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x8943B0
    }

    public class VariableChangedEvent : Object
    {
        public object EVENT_PREFIX;
        public object OLD_VALUE_PREFIX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}