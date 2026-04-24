// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 34

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class GenericCollectionFormatter : Object
    {
        // ── Original Methods ──
        public void CanFormat(){} // RVA: 0x7ffaafa0b7a0
    }

    public class GenericCollectionFormatterLocator : Object
    {
        // ── Original Methods ──
        public void TryGetFormatter(){} // RVA: 0x7ffaafa098c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class GenericCollectionFormatter`2 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class GlobalSerializationConfig : Object
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaf9e1270
        public void get_Logger(){} // RVA: 0x7ffaaf9e12d0
        public void get_EditorSerializationFormat(){} // RVA: 0x7ffaa8a37cb0
        public void get_BuildSerializationFormat(){} // RVA: 0x7ffaa8f22da0
        public void get_LoggingPolicy(){} // RVA: 0x7ffaa8f22da0
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7ffaa8f22da0
        public void LoadInstanceIfAssetExists(){} // RVA: 0x7ffaa8932310
        public void get_HasInstanceLoaded(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf9e1320
    }

    public class GradientAlphaKeyFormatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa3b2e0
        public void Write(){} // RVA: 0x7ffaafa3b3a0
        public void .ctor(){} // RVA: 0x7ffaafa3b480
        public void .cctor(){} // RVA: 0x7ffaafa3b4e0
    }

    public class GradientColorKeyFormatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa3b5c0
        public void Write(){} // RVA: 0x7ffaafa3b690
        public void .ctor(){} // RVA: 0x7ffaafa3b790
        public void .cctor(){} // RVA: 0x7ffaafa3b7f0
    }

    public class GradientFormatter : MinimalBaseFormatter`1
    {
        public object ModeProperty; // 0x337DE2D0

        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa3b9e0
        public void Write(){} // RVA: 0x7ffaafa3bd90
        public void .ctor(){} // RVA: 0x7ffaafa3c060
        public void .cctor(){} // RVA: 0x7ffaafa3c0c0
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaafa3b960
    }

    public class GuidSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa270c0
        public void WriteValue(){} // RVA: 0x7ffaafa27db0
        public void .ctor(){} // RVA: 0x7ffaafa27e90
    }

}