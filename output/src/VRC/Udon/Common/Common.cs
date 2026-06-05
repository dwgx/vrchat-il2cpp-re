// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 16
// Methods: 104

namespace VRC.Udon.Common
{
    public class DeserializationResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA1A5650
    }

    public class SerializationResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6274E80
    }

    public class UdonBaseHeapReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UdonGameObjectComponentHeapReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class UdonHeap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA1A6C50 | overloaded x3
        public void CheckHeapBounds(){} // RVA: 0x7FFAF52DBFA0
        public void IsAddressWithinBounds(){} // RVA: 0x7FFAFA1A5A00
        public void InitializeHeapVariable(){} // RVA: 0x7FFAFA1A6770 | overloaded x2
        public void CopyHeapVariable(){} // RVA: 0x7FFAFA1A5A30
        public void SetHeapVariable(){} // RVA: 0x7FFAFA1A68C0 | overloaded x2
        public void SetHeapVariableInternal(){} // RVA: 0x7FFAFA1A69A0 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void TryGetHeapVariable(){} // RVA: 0x7FFAFA1A6380 | overloaded x2
        public void GetHeapVariableInternal(){} // RVA: 0x7FFAF2D33FA0
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFAFA1A63E0
        public void GetHeapVariableType(){} // RVA: 0x7FFAFA1A6430
        public void GetHeapCapacity(){} // RVA: 0x7FFAF39EF910
        public void DumpHeapObjects(){} // RVA: 0x7FFAFA1A65B0
        public void GetObjectData(){} // RVA: 0x7FFAFA1A72E0
    }

    public class UdonInputEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA1A7760 | overloaded x2
    }

    public class UdonProgram
    {
        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7FFAF2DA8380
        public void get_InstructionSetVersion(){} // RVA: 0x7FFAF306ED50
        public void get_ByteCode(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Heap(){} // RVA: 0x7FFAF2DBB130
        public void get_EntryPoints(){} // RVA: 0x7FFAF30E74D0
        public void get_SymbolTable(){} // RVA: 0x7FFAF2F476A0
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAF2E0A740
        public void get_UpdateOrder(){} // RVA: 0x7FFAF2E2E0C0
        public void .ctor(){} // RVA: 0x7FFAFA1A7780
    }

    public class UdonSymbol
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Type(){} // RVA: 0x7FFAF2D907C0
        public void get_Address(){} // RVA: 0x7FFAF3210030
        public void .ctor(){} // RVA: 0x7FFAFA1A7AD0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAFA1A7EC0
    }

    public class UdonSymbolTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA1AA130 | overloaded x3
        public void HasAddressForSymbol(){} // RVA: 0x7FFAFA1A9A00
        public void HasSymbolForAddress(){} // RVA: 0x7FFAFA1A9A60
        public void GetSymbolFromAddress(){} // RVA: 0x7FFAFA1A9AC0
        public void TryGetSymbolFromAddress(){} // RVA: 0x7FFAFA1A9CA0
        public void GetAddressFromSymbol(){} // RVA: 0x7FFAFA1A9E10
        public void TryGetAddressFromSymbol(){} // RVA: 0x7FFAFA1A9F10
        public void GetExportedSymbols(){} // RVA: 0x7FFAF2D907C0
        public void GetSymbols(){} // RVA: 0x7FFAF2DA8380
        public void HasExportedSymbol(){} // RVA: 0x7FFAFA1A9FD0
        public void GetSymbolType(){} // RVA: 0x7FFAFA1AA030
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAFA1AA380
    }

    public class UdonSyncMetadata : get_Name
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Properties(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAFA1AB4B0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAFA1AB820
    }

    public class UdonSyncMetadataTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA1AC170 | overloaded x3
        public void GetAllSyncMetadata(){} // RVA: 0x7FFAFA1AC0B0
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7FFAFA1AC100
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAFA1AC2D0
    }

    public class UdonSyncProperty : get_Name
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_InterpolationAlgorithm(){} // RVA: 0x7FFAF306ED50
        public void .ctor(){} // RVA: 0x7FFAFA1AAC20 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAFA1AAED0
    }

    public class UdonVariableTable
    {
        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFAFA1AC5D0
        public void .ctor(){} // RVA: 0x7FFAFA1ACF20 | overloaded x3
        public void TrySetVariableValue(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFAF2AC1120 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFAFA1ACC30
        public void TryAddVariable(){} // RVA: 0x7FFAFA1ACDA0
        public void RemoveVariable(){} // RVA: 0x7FFAFA1ACEC0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAFA1AD080
    }

    public class UdonVariable`1
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFAF2ABCD60
        public void get_Value(){} // RVA: 0x7FFAF2D33FA0
        public void set_Value(){} // RVA: 0x7FFAF2D33FA0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7FFAF2ABCD60
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7FFAF2AD4B10
        public void get_DeclaredType(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
    }

    public class UdonVariable`1
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFAF2DA8380
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7FFAF2D907C0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7FFAF68B3F00
        public void get_DeclaredType(){} // RVA: 0x7FFAF6F3A570
        public void .ctor(){} // RVA: 0x7FFAF6F3AA60 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF6F3A620
    }

    public class VariableChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}