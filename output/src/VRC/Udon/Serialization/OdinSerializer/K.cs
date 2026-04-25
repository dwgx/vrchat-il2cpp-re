// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 8

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class KeyValuePairFormatter`2 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> KeySerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> ValueSerializer;

        // ── Methods ──
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class KeyframeFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<int> IntSerializer; // 0x8
        public bool Is_In_2018_1_Or_Above; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.IFormatter`1<UnityEngine.Keyframe> Formatter; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACA019A90
        public void Read(){} // RVA: 0x7FFACA019EA0
        public void Write(){} // RVA: 0x7FFACA01A300
        public void .ctor(){} // RVA: 0x7FFACA01A590
    }

}