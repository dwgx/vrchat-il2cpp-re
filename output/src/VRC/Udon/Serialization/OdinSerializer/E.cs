// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 6
// Methods: 15

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class EasyBaseFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFE83B236F0
        public void SerializeImplementation(){} // RVA: 0x7FFE83B238A0
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE83B238C0
    }

    public class EmittedAssemblyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EmittedFormatterAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EmptyTypeFormatter`1 : EasyBaseFormatter`1
    {
        // ── Methods ──
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class EnumSerializer`1 : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void WriteValue(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ExcludeDataFromInspectorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}