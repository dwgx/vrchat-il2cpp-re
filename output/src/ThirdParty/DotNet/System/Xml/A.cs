// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 2
// Methods: 3

namespace ThirdParty.DotNet.System.Xml
{
    public class AsyncHelper : Object
    {
        public System.Threading.Tasks.Task DoneTask;
        public System.Threading.Tasks.Task`1<bool> DoneTaskTrue; // 0x8
        public System.Threading.Tasks.Task`1<bool> DoneTaskFalse; // 0x10
        public System.Threading.Tasks.Task`1<int> DoneTaskZero; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC907F430
    }

    public class AttributePSVIInfo : Object
    {
        public string localName; // 0x10
        public string namespaceUri; // 0x18
        public object typedAttributeValue; // 0x20
        public System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91DC250
        public void Reset(){} // RVA: 0x7FFAC91DC2F0
    }

}