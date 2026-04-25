// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel.Design.Serialization
// Classes: 2
// Methods: 8

namespace ThirdParty.DotNet.System.ComponentModel.Design.Serialization
{
    public class InstanceDescriptor : Object
    {
        public System.Collections.ICollection Arguments; // 0x10
        public bool MemberInfo; // 0x18
        public System.Reflection.MemberInfo <MemberInfo>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC944C1D0 | overloaded x2
        public void get_Arguments(){} // RVA: 0x7FFAC2F3C380
        public void get_MemberInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void Invoke(){} // RVA: 0x7FFAC944C930
    }

    public class RootDesignerSerializerAttribute : Attribute
    {
        public string SerializerBaseTypeName; // 0x10
        public bool TypeId; // 0x18
        public string <SerializerTypeName>k__BackingField; // 0x20
        public string <SerializerBaseTypeName>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC944CD60
        public void get_SerializerBaseTypeName(){} // RVA: 0x7FFAC2F4F130
        public void get_TypeId(){} // RVA: 0x7FFAC944CE20
    }

}