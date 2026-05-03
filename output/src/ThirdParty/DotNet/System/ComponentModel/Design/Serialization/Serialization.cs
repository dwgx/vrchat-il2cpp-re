// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel.Design.Serialization
// Classes: 2
// Methods: 8

namespace ThirdParty.DotNet.System.ComponentModel.Design.Serialization
{
    public class InstanceDescriptor : Object
    {
        public System.Collections.ICollection _arguments; // 0x10
        public bool _isComplete; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877F4910 | overloaded x2
        public void get_Arguments(){} // RVA: 0x7FFE81116380
        public void get_MemberInfo(){} // RVA: 0x7FFE811290C0
        public void Invoke(){} // RVA: 0x7FFE877F5070
    }

    public class RootDesignerSerializerAttribute : Attribute
    {
        public string _typeId; // 0x10
        public bool _reloadable; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877F54A0
        public void get_SerializerBaseTypeName(){} // RVA: 0x7FFE81129130
        public void get_TypeId(){} // RVA: 0x7FFE877F5560
    }

}