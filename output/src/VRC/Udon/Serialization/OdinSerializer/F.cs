// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 26

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class FileReadType : EasyBaseFormatter`1
    {
        // ── Methods ──
        public void ReadDataEntry(){} // RVA: 0x89DAB0
        public void WriteDataEntries(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class FormatterEmitter : Object
    {
        // ── Methods ──
        public void GetEmittedFormatter(){} // RVA: 0x849BC60
    }

    public class FormatterLocator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x84957E0
        public void add_FormatterResolve(){} // RVA: 0x8496CA0
        public void remove_FormatterResolve(){} // RVA: 0x8496CE0
        public void GetFormatter(){} // RVA: 0x8496D20
        public void LogAOTError(){} // RVA: 0x84971F0
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x8497450
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x8497500
        public void CreateFormatter(){} // RVA: 0x8498340
        public void GetFormatterInstance(){} // RVA: 0x8499190
    }

    public class FormatterUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x84A2C90
        public void GetSerializableMembersMap(){} // RVA: 0x84A35A0
        public void GetSerializableMembers(){} // RVA: 0x84A3890
        public void CreateUnityNull(){} // RVA: 0x84A3BF0
        public void IsPrimitiveType(){} // RVA: 0x84A4040
        public void IsPrimitiveArrayType(){} // RVA: 0x84A4190
        public void GetContainedType(){} // RVA: 0x84A4220
        public void GetMemberValue(){} // RVA: 0x84A4420
        public void SetMemberValue(){} // RVA: 0x84A4680
        public void FindSerializableMembersMap(){} // RVA: 0x84A49D0
        public void FindSerializableMembers(){} // RVA: 0x84A50B0
        public void GetPrivateMemberAlias(){} // RVA: 0x84A5790
        public void MemberIsPrivate(){} // RVA: 0x84A62C0
    }

}