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
        public void WriteDataEntries(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class FormatterEmitter
    {
        // ── Methods ──
        public void GetEmittedFormatter(){} // RVA: 0x785EB50
    }

    public class FormatterLocator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7858540
        public void add_FormatterResolve(){} // RVA: 0x7859A20
        public void remove_FormatterResolve(){} // RVA: 0x7859A60
        public void GetFormatter(){} // RVA: 0x7859AA0 | overloaded x2
        public void LogAOTError(){} // RVA: 0x7859FB0
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x785A210
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x785A2C0
        public void CreateFormatter(){} // RVA: 0x785B0D0
        public void GetFormatterInstance(){} // RVA: 0x785BF10
    }

    public class FormatterUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7865F80
        public void GetSerializableMembersMap(){} // RVA: 0x7866B20
        public void GetSerializableMembers(){} // RVA: 0x7866E40
        public void CreateUnityNull(){} // RVA: 0x78671D0
        public void IsPrimitiveType(){} // RVA: 0x7867610
        public void IsPrimitiveArrayType(){} // RVA: 0x7867760
        public void GetContainedType(){} // RVA: 0x78677F0
        public void GetMemberValue(){} // RVA: 0x78679D0
        public void SetMemberValue(){} // RVA: 0x7867C10
        public void FindSerializableMembersMap(){} // RVA: 0x7867F50
        public void FindSerializableMembers(){} // RVA: 0x7868620
        public void GetPrivateMemberAlias(){} // RVA: 0x7868D10
        public void MemberIsPrivate(){} // RVA: 0x7869870
    }

}