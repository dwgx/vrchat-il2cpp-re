// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 3
// Methods: 24

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class FormatterEmitter : Object
    {
        public object RUNTIME_EMITTED_ASSEMBLY_NAME; // 0x30CC1930

        // ── Binary Analysis Named ──
        public void GetEmittedFormatter(){} // RVA: 0x7ffaafa0b740
    }

    public class FormatterLocator : Object
    {
        public object FormatterInstances; // 0x31790630
        public object FormatterLocators; // 0x31790630

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaafa05130
        public void add_FormatterResolve(){} // RVA: 0x7ffaafa06610
        public void remove_FormatterResolve(){} // RVA: 0x7ffaafa06650
        public void LogAOTError(){} // RVA: 0x7ffaafa06ba0
        public void CreateFormatter(){} // RVA: 0x7ffaafa07cc0
        // ── Binary Analysis Named ──
        public void GetFormatter(){} // RVA: 0x7ffaafa06690
        public void GetFormatter(){} // RVA: 0x7ffaafa06690
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x7ffaafa06e00
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x7ffaafa06eb0
        public void GetFormatterInstance(){} // RVA: 0x7ffaafa08b00
    }

    public class FormatterUtilities : Object
    {
        public object LOCK; // 0x3357FD40
        public object UnityObjectRuntimeErrorString; // 0x3357FD40

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaafa12b50
        public void CreateUnityNull(){} // RVA: 0x7ffaafa13da0
        public void IsPrimitiveType(){} // RVA: 0x7ffaafa141e0
        public void IsPrimitiveArrayType(){} // RVA: 0x7ffaafa14330
        public void FindSerializableMembersMap(){} // RVA: 0x7ffaafa14b20
        public void FindSerializableMembers(){} // RVA: 0x7ffaafa151f0
        public void MemberIsPrivate(){} // RVA: 0x7ffaafa16440
        // ── Binary Analysis Named ──
        public void GetSerializableMembersMap(){} // RVA: 0x7ffaafa136f0
        public void GetSerializableMembers(){} // RVA: 0x7ffaafa13a10
        public void GetContainedType(){} // RVA: 0x7ffaafa143c0
        public void GetMemberValue(){} // RVA: 0x7ffaafa145a0
        public void SetMemberValue(){} // RVA: 0x7ffaafa147e0
        public void GetPrivateMemberAlias(){} // RVA: 0x7ffaafa158e0
    }

}