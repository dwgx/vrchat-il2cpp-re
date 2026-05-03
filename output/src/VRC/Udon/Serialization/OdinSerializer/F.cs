// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 27

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class FileReadType : EasyBaseFormatter`1
    {
        // ── Methods ──
        public void ReadDataEntry(){}
        public void WriteDataEntries(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class FormatterEmitter : Object
    {
        // ── Methods ──
        public void GetEmittedFormatter(){} // RVA: 0x7FFE8839B810
    }

    public class FormatterLocator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88395200
        public void add_FormatterResolve(){} // RVA: 0x7FFE883966E0
        public void remove_FormatterResolve(){} // RVA: 0x7FFE88396720
        public void GetFormatter(){} // RVA: 0x7FFE88396760 | overloaded x2
        public void LogAOTError(){} // RVA: 0x7FFE88396C70
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x7FFE88396ED0
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x7FFE88396F80
        public void CreateFormatter(){} // RVA: 0x7FFE88397D90
        public void GetFormatterInstance(){} // RVA: 0x7FFE88398BD0
    }

    public class FormatterUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE883A2C40
        public void GetSerializableMembersMap(){} // RVA: 0x7FFE883A37E0
        public void GetSerializableMembers(){} // RVA: 0x7FFE883A3B00
        public void CreateUnityNull(){} // RVA: 0x7FFE883A3E90
        public void IsPrimitiveType(){} // RVA: 0x7FFE883A42D0
        public void IsPrimitiveArrayType(){} // RVA: 0x7FFE883A4420
        public void GetContainedType(){} // RVA: 0x7FFE883A44B0
        public void GetMemberValue(){} // RVA: 0x7FFE883A4690
        public void SetMemberValue(){} // RVA: 0x7FFE883A48D0
        public void FindSerializableMembersMap(){} // RVA: 0x7FFE883A4C10
        public void FindSerializableMembers(){} // RVA: 0x7FFE883A52E0
        public void GetPrivateMemberAlias(){} // RVA: 0x7FFE883A59D0
        public void MemberIsPrivate(){} // RVA: 0x7FFE883A6530
    }

}