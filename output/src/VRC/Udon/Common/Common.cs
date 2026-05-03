// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 15
// Methods: 95

namespace VRC.Udon.Common
{
    public class DeserializationResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88232300
    }

    public class SerializationResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844558C0
    }

    public class UdonBaseHeapReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UdonGameObjectComponentHeapReference : UdonBaseHeapReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class UdonHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88233900 | overloaded x3
        public void CheckHeapBounds(){} // RVA: 0x7FFE8357B000
        public void IsAddressWithinBounds(){} // RVA: 0x7FFE882326B0
        public void InitializeHeapVariable(){} // RVA: 0x7FFE88233420 | overloaded x2
        public void CopyHeapVariable(){} // RVA: 0x7FFE882326E0
        public void SetHeapVariable(){} // RVA: 0x7FFE88233570 | overloaded x2
        public void SetHeapVariableInternal(){} // RVA: 0x7FFE88233650 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryGetHeapVariable(){} // RVA: 0x7FFE88233030 | overloaded x2
        public void GetHeapVariableInternal(){} // RVA: 0x7FFE810A1420
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFE88233090
        public void GetHeapVariableType(){} // RVA: 0x7FFE882330E0
        public void GetHeapCapacity(){} // RVA: 0x7FFE81CCB610
        public void DumpHeapObjects(){} // RVA: 0x7FFE88233260
        public void GetObjectData(){} // RVA: 0x7FFE88233F90
    }

    public class UdonInputEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88234410 | overloaded x2
    }

    public class UdonProgram : Object
    {
        public string _instructionSetIdentifier; // 0x10
        public int _instructionSetVersion; // 0x18
        public byte[] _byteCode; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonHeap _heap; // 0x28
        public VRC.Udon.Common.Interfaces.IUdonSymbolTable _entryPoints; // 0x30
        public VRC.Udon.Common.Interfaces.IUdonSymbolTable _symbolTable; // 0x38
        public VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable _syncMetadataTable; // 0x40
        public int _updateOrder; // 0x48

        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7FFE81116380
        public void get_InstructionSetVersion(){} // RVA: 0x7FFE813DB630
        public void get_ByteCode(){} // RVA: 0x7FFE811290C0
        public void get_Heap(){} // RVA: 0x7FFE81129130
        public void get_EntryPoints(){} // RVA: 0x7FFE8144E200
        public void get_SymbolTable(){} // RVA: 0x7FFE8143BA80
        public void get_SyncMetadataTable(){} // RVA: 0x7FFE81178740
        public void get_UpdateOrder(){} // RVA: 0x7FFE8119C0C0
        public void .ctor(){} // RVA: 0x7FFE88234430
    }

    public class UdonSymbol : Object
    {
        public string _name; // 0x10
        public System.Type _type; // 0x18
        public uint _address; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
        public void get_Address(){} // RVA: 0x7FFE8151D690
        public void .ctor(){} // RVA: 0x7FFE88234780 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE88234B70
    }

    public class UdonSymbolTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88236DE0 | overloaded x3
        public void HasAddressForSymbol(){} // RVA: 0x7FFE882366B0
        public void HasSymbolForAddress(){} // RVA: 0x7FFE88236710
        public void GetSymbolFromAddress(){} // RVA: 0x7FFE88236770
        public void TryGetSymbolFromAddress(){} // RVA: 0x7FFE88236950
        public void GetAddressFromSymbol(){} // RVA: 0x7FFE88236AC0
        public void TryGetAddressFromSymbol(){} // RVA: 0x7FFE88236BC0
        public void GetExportedSymbols(){} // RVA: 0x7FFE810FE7C0
        public void GetSymbols(){} // RVA: 0x7FFE81116380
        public void HasExportedSymbol(){} // RVA: 0x7FFE88236C80
        public void GetSymbolType(){} // RVA: 0x7FFE88236CE0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE88237030
    }

    public class UdonSyncMetadata : Object
    {
        public string _name; // 0x10
        public System.Collections.Generic.List`1<VRC.Udon.Common.Interfaces.IUdonSyncProperty> _properties; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Properties(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE88238160 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE882384D0
    }

    public class UdonSyncMetadataTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88238E20 | overloaded x3
        public void GetAllSyncMetadata(){} // RVA: 0x7FFE88238D60
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7FFE88238DB0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE88238F80
    }

    public class UdonSyncProperty : Object
    {
        public string _name; // 0x10
        public 0x666CAA44 _interpolationAlgorithm; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_InterpolationAlgorithm(){} // RVA: 0x7FFE813DB630
        public void .ctor(){} // RVA: 0x7FFE882378D0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE88237B80
    }

    public class UdonVariableTable : Object
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Interfaces.IUdonVariable> _publicVariables; // 0x10

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFE88239280
        public void .ctor(){} // RVA: 0x7FFE88239BD0 | overloaded x3
        public void TrySetVariableValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFE80E32650 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFE882398E0
        public void TryAddVariable(){} // RVA: 0x7FFE88239A50
        public void RemoveVariable(){} // RVA: 0x7FFE88239B70
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE88239D30
    }

    public class UdonVariable`1 : Object
    {
        public string _symbolName;
        public T _value;
        public object field_2; // 0x12
        public object field_3; // 0x13

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void set_Value(){} // RVA: 0x7FFE810A1420
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7FFE80E460A0
        public void get_DeclaredType(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
    }

    public class VariableChangedEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}