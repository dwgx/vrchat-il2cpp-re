// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 6
// Methods: 15

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class EasyBaseFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFAC5807560
        public void SerializeImplementation(){} // RVA: 0x7FFAC5807710
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC5807730
    }

    public class EmittedAssemblyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EmittedFormatterAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EmptyTypeFormatter`1 : EasyBaseFormatter`1
    {
        // ── Methods ──
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class EnumSerializer`1 : Serializer`1
    {
        public int SizeOf_T;

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void WriteValue(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ExcludeDataFromInspectorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}