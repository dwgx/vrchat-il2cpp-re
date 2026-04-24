// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 5
// Methods: 12

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class IDeserializationCallback
    {
        // ── Original Methods ──
        public void OnDeserialization(){} // RVA: 0x7ffaa8660d80
    }

    public class IObjectReference
    {
        // ── Binary Analysis Named ──
        public void GetRealObject(){} // RVA: 0x7ffaa8649280
    }

    public class ISerializable
    {
        // ── Binary Analysis Named ──
        public void GetObjectData(){}
    }

    public class SerializationBinder : Object
    {
        // ── Original Methods ──
        public void BindToName(){} // RVA: 0x7ffaadebf6f0
        public void BindToType(){} // RVA: 0x7ffaa865aa30
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StreamingContext : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadecf7c0
        public void .ctor(){} // RVA: 0x7ffaadecf7c0
        public void get_Context(){} // RVA: 0x7ffaa950bda0
        public void Equals(){} // RVA: 0x7ffaadecf820
        public void get_State(){} // RVA: 0x7ffaaa3cef80
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa3cef80
    }

}