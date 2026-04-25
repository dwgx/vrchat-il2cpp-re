// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 9
// Methods: 37

namespace ThirdParty.Other.Steamworks.Data
{
    public class IPCFailure_t : ValueType
    {
        public byte CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8DC0
        public void .cctor(){} // RVA: 0x7FFAC4BE8DD0
    }

    public class IPCountry_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB2F0
        public void .cctor(){} // RVA: 0x7FFAC4BEB300
    }

    public class InputActionSetHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE7610
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
        public void Equals(){} // RVA: 0x7FFAC4BF79F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7A00
    }

    public class InputAnalogActionHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE7610
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
        public void Equals(){} // RVA: 0x7FFAC4BF79F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7A00
    }

    public class InputDigitalActionHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE7610
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
        public void Equals(){} // RVA: 0x7FFAC4BF79F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7A00
    }

    public class InputHandle_t : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE7610
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
        public void Equals(){} // RVA: 0x7FFAC4BF79F0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7A00
    }

    public class InventoryDefId : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BF7850
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF78F0
    }

    public class InventoryItemId : ValueType
    {
        public ulong Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE7610
        public void GetHashCode(){} // RVA: 0x7FFAC4BE71C0
        public void Equals(){} // RVA: 0x7FFAC4BF79F0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC4BF7CC0
        public void CompareTo(){} // RVA: 0x7FFAC4BF7A00
    }

    public class ItemInstalled_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF25A0
        public void .cctor(){} // RVA: 0x7FFAC4BF25B0
    }

}