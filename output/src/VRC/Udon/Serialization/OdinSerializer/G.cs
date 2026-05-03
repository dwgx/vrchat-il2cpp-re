// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 34

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class GenericCollectionFormatter : Object
    {
        // ── Methods ──
        public void CanFormat(){} // RVA: 0x7FFE8839B870
    }

    public class GenericCollectionFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFE88399990
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GenericCollectionFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

    public class GlobalSerializationConfig : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.GlobalSerializationConfig instance;
        public object field_1; // 0x3
        public object field_2; // 0x4
        public object field_3; // 0x5
        public object field_4; // 0x6
        public object field_5; // 0x7
        public object field_6; // 0x8

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE88371340
        public void get_Logger(){} // RVA: 0x7FFE883713A0
        public void get_EditorSerializationFormat(){} // RVA: 0x7FFE81200CB0
        public void get_BuildSerializationFormat(){} // RVA: 0x7FFE813240E0
        public void get_LoggingPolicy(){} // RVA: 0x7FFE813240E0
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7FFE813240E0
        public void LoadInstanceIfAssetExists(){} // RVA: 0x7FFE810FB310
        public void get_HasInstanceLoaded(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE883713F0
    }

    public class GradientAlphaKeyFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE883CB3D0
        public void Write(){} // RVA: 0x7FFE883CB490
        public void .ctor(){} // RVA: 0x7FFE883CB570
        public void .cctor(){} // RVA: 0x7FFE883CB5D0
    }

    public class GradientColorKeyFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE883CB6B0
        public void Write(){} // RVA: 0x7FFE883CB780
        public void .ctor(){} // RVA: 0x7FFE883CB880
        public void .cctor(){} // RVA: 0x7FFE883CB8E0
    }

    public class GradientFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFE883CBA50
        public void Read(){} // RVA: 0x7FFE883CBAD0
        public void Write(){} // RVA: 0x7FFE883CBE80
        public void .ctor(){} // RVA: 0x7FFE883CC150
        public void .cctor(){} // RVA: 0x7FFE883CC1B0
    }

    public class GuidSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B71B0
        public void WriteValue(){} // RVA: 0x7FFE883B7EA0
        public void .ctor(){} // RVA: 0x7FFE883B7F80
    }

}