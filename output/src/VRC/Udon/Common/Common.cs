// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 16
// Methods: 104

namespace VRC.Udon.Common
{
    public class DeserializationResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76F5650
    }

    public class SerializationResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C4E80
    }

    public class UdonBaseHeapReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UdonGameObjectComponentHeapReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class UdonHeap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76F6C50 | overloaded x3
        public void CheckHeapBounds(){} // RVA: 0x282BFA0
        public void IsAddressWithinBounds(){} // RVA: 0x76F5A00
        public void InitializeHeapVariable(){} // RVA: 0x76F6770 | overloaded x2
        public void CopyHeapVariable(){} // RVA: 0x76F5A30
        public void SetHeapVariable(){} // RVA: 0x76F68C0 | overloaded x2
        public void SetHeapVariableInternal(){} // RVA: 0x76F69A0 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetHeapVariable(){} // RVA: 0x76F6380 | overloaded x2
        public void GetHeapVariableInternal(){} // RVA: 0x283FA0
        public void IsHeapVariableInitialized(){} // RVA: 0x76F63E0
        public void GetHeapVariableType(){} // RVA: 0x76F6430
        public void GetHeapCapacity(){} // RVA: 0xF3F910
        public void DumpHeapObjects(){} // RVA: 0x76F65B0
        public void GetObjectData(){} // RVA: 0x76F72E0
    }

    public class UdonInputEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76F7760 | overloaded x2
    }

    public class UdonProgram
    {
        public string <InstructionSetIdentifier>k__BackingField; // 0x10
        public int <InstructionSetVersion>k__BackingField; // 0x18
        public byte[] <ByteCode>k__BackingField; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonHeap <Heap>k__BackingField; // 0x28
        public VRC.Udon.Common.Interfaces.IUdonSymbolTable <EntryPoints>k__BackingField; // 0x30
        public VRC.Udon.Common.Interfaces.IUdonSymbolTable <SymbolTable>k__BackingField; // 0x38
        public VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable <SyncMetadataTable>k__BackingField; // 0x40
        public int <UpdateOrder>k__BackingField; // 0x48

        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x2F8380
        public void get_InstructionSetVersion(){} // RVA: 0x5BED50
        public void get_ByteCode(){} // RVA: 0x30B0C0
        public void get_Heap(){} // RVA: 0x30B130
        public void get_EntryPoints(){} // RVA: 0x6374D0
        public void get_SymbolTable(){} // RVA: 0x4976A0
        public void get_SyncMetadataTable(){} // RVA: 0x35A740
        public void get_UpdateOrder(){} // RVA: 0x37E0C0
        public void .ctor(){} // RVA: 0x76F7780
    }

    public class UdonSymbol
    {
        public string <Name>k__BackingField; // 0x10
        public System.Type <Type>k__BackingField; // 0x18
        public uint <Address>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Type(){} // RVA: 0x2E07C0
        public void get_Address(){} // RVA: 0x760030
        public void .ctor(){} // RVA: 0x76F7AD0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x76F7EC0
    }

    public class UdonSymbolTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76FA130 | overloaded x3
        public void HasAddressForSymbol(){} // RVA: 0x76F9A00
        public void HasSymbolForAddress(){} // RVA: 0x76F9A60
        public void GetSymbolFromAddress(){} // RVA: 0x76F9AC0
        public void TryGetSymbolFromAddress(){} // RVA: 0x76F9CA0
        public void GetAddressFromSymbol(){} // RVA: 0x76F9E10
        public void TryGetAddressFromSymbol(){} // RVA: 0x76F9F10
        public void GetExportedSymbols(){} // RVA: 0x2E07C0
        public void GetSymbols(){} // RVA: 0x2F8380
        public void HasExportedSymbol(){} // RVA: 0x76F9FD0
        public void GetSymbolType(){} // RVA: 0x76FA030
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x76FA380
    }

    public class UdonSyncMetadata : get_Name
    {
        public string <Name>k__BackingField; // 0x10
        public System.Collections.Generic.List`1<VRC.Udon.Common.Interfaces.IUdonSyncProperty> <Properties>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Properties(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x76FB4B0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x76FB820
    }

    public class UdonSyncMetadataTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76FC170 | overloaded x3
        public void GetAllSyncMetadata(){} // RVA: 0x76FC0B0
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x76FC100
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x76FC2D0
    }

    public class UdonSyncProperty : get_Name
    {
        public string <Name>k__BackingField; // 0x10
        public 0x659F2FB0 <InterpolationAlgorithm>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_InterpolationAlgorithm(){} // RVA: 0x5BED50
        public void .ctor(){} // RVA: 0x76FAC20 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x76FAED0
    }

    public class UdonVariableTable
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Interfaces.IUdonVariable> _publicVariables; // 0x10

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x76FC5D0
        public void .ctor(){} // RVA: 0x76FCF20 | overloaded x3
        public void TrySetVariableValue(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x11120 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x76FCC30
        public void TryAddVariable(){} // RVA: 0x76FCDA0
        public void RemoveVariable(){} // RVA: 0x76FCEC0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x76FD080
    }

    public class UdonVariable`1
    {
        public string <SymbolName>k__BackingField;
        public T <Value>k__BackingField;

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0x283FA0
        public void set_Value(){} // RVA: 0x283FA0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0xCD60
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x24B10
        public void get_DeclaredType(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
    }

    public class UdonVariable`1
    {
        public string <SymbolName>k__BackingField; // 0x10
        public VRC.SDKBase.VRCStation <Value>k__BackingField; // 0x18

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x2F8380
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x2E07C0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x3E03F00
        public void get_DeclaredType(){} // RVA: 0x448A570
        public void .ctor(){} // RVA: 0x448AA60 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x448A620
    }

    public class VariableChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}