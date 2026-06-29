// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 26

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class FileReadType : EasyBaseFormatter`1
    {
        // ── Methods ──
        public void ReadDataEntry(){} // RVA: 0x7A7E21DC0
        public void WriteDataEntries(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class FormatterEmitter : Object
    {
        // ── Methods ──
        public void GetEmittedFormatter(){} // RVA: 0x7AF63E190
    }

    public class FormatterLocator : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF637CF0
        public void add_FormatterResolve(){} // RVA: 0x7AF6391C0
        public void remove_FormatterResolve(){} // RVA: 0x7AF639200
        public void GetFormatter(){} // RVA: 0x7AA4B0380
        public void LogAOTError(){} // RVA: 0x7AF639720
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x7AF639980
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x7AF639A30
        public void CreateFormatter(){} // RVA: 0x7AF63A860
        public void GetFormatterInstance(){} // RVA: 0x7AF63B6C0
    }

    public class FormatterUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF6452B0
        public void GetSerializableMembersMap(){} // RVA: 0x7AF645E50
        public void GetSerializableMembers(){} // RVA: 0x7AF646140
        public void CreateUnityNull(){} // RVA: 0x7AF6464A0
        public void IsPrimitiveType(){} // RVA: 0x7AF6468E0
        public void IsPrimitiveArrayType(){} // RVA: 0x7AF646A30
        public void GetContainedType(){} // RVA: 0x7AF646AC0
        public void GetMemberValue(){} // RVA: 0x7AF646CC0
        public void SetMemberValue(){} // RVA: 0x7AF646F20
        public void FindSerializableMembersMap(){} // RVA: 0x7AF647270
        public void FindSerializableMembers(){} // RVA: 0x7AF647950
        public void GetPrivateMemberAlias(){} // RVA: 0x7AF648070
        public void MemberIsPrivate(){} // RVA: 0x7AF648BA0
    }

}