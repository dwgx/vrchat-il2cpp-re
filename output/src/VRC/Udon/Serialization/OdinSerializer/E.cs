// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 6
// Methods: 15

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class EasyBaseFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFD50C27560
        public void SerializeImplementation(){} // RVA: 0x7FFD50C27710
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD50C27730
    }

    public class EmittedAssemblyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EmittedFormatterAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EmptyTypeFormatter`1 : EasyBaseFormatter`1
    {
        // ── Methods ──
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class EnumSerializer`1 : Serializer`1
    {
        public int SizeOf_T;

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void WriteValue(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ExcludeDataFromInspectorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}