// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 27

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class FileReadType
    {
        // ── Methods ──
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class FormatterEmitter
    {
        // ── Methods ──
        public void GetEmittedFormatter(){} // RVA: 0x7FFAFA30EB50
    }

    public class FormatterLocator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFA308540
        public void add_FormatterResolve(){} // RVA: 0x7FFAFA309A20
        public void remove_FormatterResolve(){} // RVA: 0x7FFAFA309A60
        public void GetFormatter(){} // RVA: 0x7FFAFA309AA0 | overloaded x2
        public void LogAOTError(){} // RVA: 0x7FFAFA309FB0
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x7FFAFA30A210
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x7FFAFA30A2C0
        public void CreateFormatter(){} // RVA: 0x7FFAFA30B0D0
        public void GetFormatterInstance(){} // RVA: 0x7FFAFA30BF10
    }

    public class FormatterUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFA315F80
        public void GetSerializableMembersMap(){} // RVA: 0x7FFAFA316B20
        public void GetSerializableMembers(){} // RVA: 0x7FFAFA316E40
        public void CreateUnityNull(){} // RVA: 0x7FFAFA3171D0
        public void IsPrimitiveType(){} // RVA: 0x7FFAFA317610
        public void IsPrimitiveArrayType(){} // RVA: 0x7FFAFA317760
        public void GetContainedType(){} // RVA: 0x7FFAFA3177F0
        public void GetMemberValue(){} // RVA: 0x7FFAFA3179D0
        public void SetMemberValue(){} // RVA: 0x7FFAFA317C10
        public void FindSerializableMembersMap(){} // RVA: 0x7FFAFA317F50
        public void FindSerializableMembers(){} // RVA: 0x7FFAFA318620
        public void GetPrivateMemberAlias(){} // RVA: 0x7FFAFA318D10
        public void MemberIsPrivate(){} // RVA: 0x7FFAFA319870
    }

}