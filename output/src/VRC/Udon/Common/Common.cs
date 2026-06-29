// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common
// Classes: 16
// Methods: 83

namespace VRC.Udon.Common
{
    public class DeserializationResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F22C90
    }

    public class SerializationResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A79089E0
    }

    public class UdonBaseHeapReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UdonGameObjectComponentHeapReference : UdonBaseHeapReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class UdonHeap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF4D5CD0
        public void CheckHeapBounds(){} // RVA: 0x7AA63DCE0
        public void IsAddressWithinBounds(){} // RVA: 0x7AF4D4A80
        public void InitializeHeapVariable(){} // RVA: 0x7AF4D57F0
        public void CopyHeapVariable(){} // RVA: 0x7AF4D4AB0
        public void SetHeapVariable(){} // RVA: 0x7AF4D5940
        public void SetHeapVariableInternal(){} // RVA: 0x7AF4D5A20
        public void GetHeapVariable(){} // RVA: 0x7AA63CBF0
        public void TryGetHeapVariable(){} // RVA: 0x7A7E029D0
        public void GetHeapVariableInternal(){} // RVA: 0x7AA6417B0
        public void IsHeapVariableInitialized(){} // RVA: 0x7AF4D5460
        public void GetHeapVariableType(){} // RVA: 0x7AF4D54B0
        public void GetHeapCapacity(){} // RVA: 0x7A8D0A110
        public void DumpHeapObjects(){} // RVA: 0x7AF4D5630
        public void GetObjectData(){} // RVA: 0x7AF4D6370
    }

    public class UdonInputEventArgs : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F22CB0
    }

    public class UdonProgram : Object
    {
        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7A80F2570
        public void get_InstructionSetVersion(){} // RVA: 0x7A83782A0
        public void get_ByteCode(){} // RVA: 0x7A81052C0
        public void get_Heap(){} // RVA: 0x7A8105330
        public void get_EntryPoints(){} // RVA: 0x7A83F69F0
        public void get_SymbolTable(){} // RVA: 0x7A8292C30
        public void get_SyncMetadataTable(){} // RVA: 0x7A8154D80
        public void get_UpdateOrder(){} // RVA: 0x7A8178B70
        public void .ctor(){} // RVA: 0x7AF4D6820
    }

    public class UdonSymbol : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Type(){} // RVA: 0x7A80DA7B0
        public void get_Address(){} // RVA: 0x7A851DB90
        public void .ctor(){} // RVA: 0x7AF4D6B70
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AF4D6F70
    }

    public class UdonSymbolTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF4D9310
        public void HasAddressForSymbol(){} // RVA: 0x7AF4D8BE0
        public void HasSymbolForAddress(){} // RVA: 0x7AF4D8C40
        public void GetSymbolFromAddress(){} // RVA: 0x7AF4D8CA0
        public void TryGetSymbolFromAddress(){} // RVA: 0x7AF4D8E80
        public void GetAddressFromSymbol(){} // RVA: 0x7AF4D8FF0
        public void TryGetAddressFromSymbol(){} // RVA: 0x7AF4D90F0
        public void GetExportedSymbols(){} // RVA: 0x7A80DA7B0
        public void GetSymbols(){} // RVA: 0x7A80F2570
        public void HasExportedSymbol(){} // RVA: 0x7AF4D91B0
        public void GetSymbolType(){} // RVA: 0x7AF4D9210
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AF4D9560
    }

    public class UdonSyncMetadata : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Properties(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7AF4DA6B0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AF4DAA30
    }

    public class UdonSyncMetadataTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF4DB390
        public void GetAllSyncMetadata(){} // RVA: 0x7AF4DB2D0
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7AF4DB320
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AF4DB4F0
    }

    public class UdonSyncProperty : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_InterpolationAlgorithm(){} // RVA: 0x7A83782A0
        public void .ctor(){} // RVA: 0x7AF4D9E00
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AF4DA0D0
    }

    public class UdonVariableTable : Object
    {
        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7AF4DB7F0
        public void .ctor(){} // RVA: 0x7AF4DC150
        public void TrySetVariableValue(){} // RVA: 0x7A8051B10
        public void TryGetVariableValue(){} // RVA: 0x7A7E01A40
        public void TryGetVariableType(){} // RVA: 0x7AF4DBE60
        public void TryAddVariable(){} // RVA: 0x7AF4DBFD0
        public void RemoveVariable(){} // RVA: 0x7AF4DC0F0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AF4DC2B0
    }

    public class UdonVariable`1 : Object
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7A7E00680
        public void get_Value(){} // RVA: 0x7A8051B10
        public void set_Value(){} // RVA: 0x7A8051B10
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7A7E00680
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7A7E18800
        public void get_DeclaredType(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18890
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7A7E18890
    }

    public class UdonVariable`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC278D90
        public void get_SymbolName(){} // RVA: 0x7A80F2570
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void VRC.Udon.Common.Interfaces.IUdonVariable.get_Value(){} // RVA: 0x7A80DA7B0
        public void VRC.Udon.Common.Interfaces.IUdonVariable.set_Value(){} // RVA: 0x7ABBFF280
        public void get_DeclaredType(){} // RVA: 0x7AC2788A0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AC278950
    }

    public class VariableChangedEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}