// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 3
// Methods: 24

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class FormatterEmitter : Object
    {
        public int helperFormatterNameId;
        public string PRE_EMITTED_ASSEMBLY_NAME;
        public string RUNTIME_EMITTED_ASSEMBLY_NAME;

        // ── Methods ──
        public void GetEmittedFormatter(){} // RVA: 0x7FFD55408D20
    }

    public class FormatterLocator : Object
    {
        public object StrongFormatters_LOCK;
        public object WeakFormatters_LOCK; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Type,VRC.Udon.Serialization.OdinSerializer.IFormatter> FormatterInstances; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.Utilities.DoubleLookupDictionary`3<System.Type,VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter> StrongTypeFormatterMap; // 0x18
        public VRC.Udon.Serialization.OdinSerializer.Utilities.DoubleLookupDictionary`3<System.Type,VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter> WeakTypeFormatterMap; // 0x20
        public System.Collections.Generic.List`1<0x66582728> FormatterLocators; // 0x28
        public System.Collections.Generic.List`1<0x665826D0> FormatterInfos; // 0x30

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD55402710
        public void add_FormatterResolve(){} // RVA: 0x7FFD55403BF0
        public void remove_FormatterResolve(){} // RVA: 0x7FFD55403C30
        public void GetFormatter(){} // RVA: 0x7FFD55403C70 | overloaded x2
        public void LogAOTError(){} // RVA: 0x7FFD55404180
        public void GetAllPossibleMissingAOTTypes(){} // RVA: 0x7FFD554043E0
        public void GetAllCompatiblePredefinedFormatters(){} // RVA: 0x7FFD55404490
        public void CreateFormatter(){} // RVA: 0x7FFD554052A0
        public void GetFormatterInstance(){} // RVA: 0x7FFD554060E0
    }

    public class FormatterUtilities : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.Utilities.DoubleLookupDictionary`3<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Type,System.Reflection.MemberInfo[]> MemberArrayCache;
        public VRC.Udon.Serialization.OdinSerializer.Utilities.DoubleLookupDictionary`3<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Type,System.Collections.Generic.Dictionary`2<string,System.Reflection.MemberInfo>> MemberMapCache; // 0x8
        public object LOCK; // 0x10
        public System.Collections.Generic.HashSet`1<System.Type> PrimitiveArrayTypes; // 0x18
        public System.Reflection.FieldInfo UnityObjectRuntimeErrorStringField; // 0x20
        public string UnityObjectRuntimeErrorString;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD55410130
        public void GetSerializableMembersMap(){} // RVA: 0x7FFD55410CD0
        public void GetSerializableMembers(){} // RVA: 0x7FFD55410FF0
        public void CreateUnityNull(){} // RVA: 0x7FFD55411380
        public void IsPrimitiveType(){} // RVA: 0x7FFD554117C0
        public void IsPrimitiveArrayType(){} // RVA: 0x7FFD55411910
        public void GetContainedType(){} // RVA: 0x7FFD554119A0
        public void GetMemberValue(){} // RVA: 0x7FFD55411B80
        public void SetMemberValue(){} // RVA: 0x7FFD55411DC0
        public void FindSerializableMembersMap(){} // RVA: 0x7FFD55412100
        public void FindSerializableMembers(){} // RVA: 0x7FFD554127D0
        public void GetPrivateMemberAlias(){} // RVA: 0x7FFD55412EC0
        public void MemberIsPrivate(){} // RVA: 0x7FFD55413A20
    }

}