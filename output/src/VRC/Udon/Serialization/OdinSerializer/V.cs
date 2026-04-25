// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 13
// Methods: 55

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class VRCUrlFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AE3F80
    }

    public class ValueTupleFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> T1Serializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class ValueTupleFormatter`2 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> T1Serializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> T2Serializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class ValueTupleFormatter`3 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> T1Serializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<V> T2Serializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> T3Serializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class Vector2DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider`1
    {
        public object ProviderID;

        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFACA0163B0
        public void Compare(){} // RVA: 0x7FFACA0163F0
        public void GetKeyFromPathString(){} // RVA: 0x7FFACA0164C0
        public void GetPathStringFromKey(){} // RVA: 0x7FFACA016590
        public void .ctor(){} // RVA: 0x7FFACA0167B0
    }

    public class Vector2Formatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01B010
        public void Write(){} // RVA: 0x7FFACA01B0D0
        public void .ctor(){} // RVA: 0x7FFACA01B1B0
        public void .cctor(){} // RVA: 0x7FFACA01B210
    }

    public class Vector2IntFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<int> Serializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01BA10
        public void Write(){} // RVA: 0x7FFACA01BAD0
        public void .ctor(){} // RVA: 0x7FFACA01BBB0
        public void .cctor(){} // RVA: 0x7FFACA01BC10
    }

    public class Vector3DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider`1
    {
        public object ProviderID;

        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFACA0167E0
        public void Compare(){} // RVA: 0x7FFACA016820
        public void GetKeyFromPathString(){} // RVA: 0x7FFACA0168F0
        public void GetPathStringFromKey(){} // RVA: 0x7FFACA016A60
        public void .ctor(){} // RVA: 0x7FFACA016D10
    }

    public class Vector3Formatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01B2F0
        public void Write(){} // RVA: 0x7FFACA01B3E0
        public void .ctor(){} // RVA: 0x7FFACA01B500
        public void .cctor(){} // RVA: 0x7FFACA01B560
    }

    public class Vector3IntFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<int> Serializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01BCF0
        public void Write(){} // RVA: 0x7FFACA01BDE0
        public void .ctor(){} // RVA: 0x7FFACA01BF00
        public void .cctor(){} // RVA: 0x7FFACA01BF60
    }

    public class Vector4DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider`1
    {
        public object ProviderID;

        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFACA016D40
        public void Compare(){} // RVA: 0x7FFACA016D80
        public void GetKeyFromPathString(){} // RVA: 0x7FFACA016EA0
        public void GetPathStringFromKey(){} // RVA: 0x7FFACA017080
        public void .ctor(){} // RVA: 0x7FFACA0173C0
    }

    public class Vector4Formatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01B640
        public void Write(){} // RVA: 0x7FFACA01B770
        public void .ctor(){} // RVA: 0x7FFACA01B8D0
        public void .cctor(){} // RVA: 0x7FFACA01B930
    }

    public class VersionFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFAC34F9180
        public void Read(){} // RVA: 0x7FFAC9FE9680
        public void Write(){} // RVA: 0x7FFAC9FE9A50
        public void .ctor(){} // RVA: 0x7FFAC9FE9B20
    }

}