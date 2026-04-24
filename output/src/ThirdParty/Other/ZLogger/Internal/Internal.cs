// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Internal
// Classes: 8
// Methods: 30

namespace ThirdParty.Other.ZLogger.Internal
{
    public class <EnumDictionary>FADF3D51B83FF80D45F581868D8BC170BC1D06511D1532EA8388B7F748A636021__DistinctEqualityComparer`1 : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class <EnumDictionary>FADF3D51B83FF80D45F581868D8BC170BC1D06511D1532EA8388B7F748A636021__ShimsExtensions : Object
    {
        // ── Methods ──
        public void ToFrozenDictionary(){} // RVA: 0x7FFD4E089600
    }

    public class CodeGeneratorUtil : Object
    {
        public 0x665367A8 utf8JsonWriter; // 0xFFFF

        // ── Methods ──
        public void GetThreadStaticUtf8JsonWriter(){} // RVA: 0x7FFD5750F9F0
        public void AppendAsJson(){} // RVA: 0x7FFD5750FB40 | overloaded x2
    }

    public class EnumDictionary`1 : Object
    {
        public object dictionary;
        public UIntPtr GetStringName;
        public UIntPtr GetUtf8Name;
        public UIntPtr GetJsonEncodedName;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void GetStringNameCore(){} // RVA: 0x7FFD4E2ADC40
        public void GetUtf8NameCore(){} // RVA: 0x7FFD4E2ADC40
        public void GetJsonEncodedTextCore(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IObjectPoolNode`1
    {
        public object NextNode;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    }

    public class MagicalBox : ValueType
    {
        public byte[] storage; // 0x10
        public int written; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5501E610
        public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void TryRead(){} // RVA: 0x7FFD4E07B260
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void ReadBoxed(){} // RVA: 0x7FFD5750FE20
        public void TryReadTo(){} // RVA: 0x7FFD57510A00 | overloaded x2
        public void IsSupportedType(){} // RVA: 0x7FFD4E079D30
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFD57511540
    }

    public class ObjectPool`1 : Object
    {
        public int gate; // 0x10
        public ZLogger.ZLoggerEntry`1<ZLogger.LogStates.InterpolatedStringLogState> root; // 0x18

        // ── Methods ──
        public void TryPop(){} // RVA: 0x7FFD4E079F60
        public void TryPush(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class StreamBufferWriter : Object
    {
        public System.IO.Stream stream; // 0x10
        public byte[] buffer; // 0x18
        public byte[] defaultBuffer; // 0x20
        public int written; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57511CF0
        public void Advance(){} // RVA: 0x7FFD57511E40
        public void GetMemory(){} // RVA: 0x7FFD57511E50
        public void GetSpan(){} // RVA: 0x7FFD57511FF0
        public void TryGetForNewLine(){} // RVA: 0x7FFD57512190
        public void Flush(){} // RVA: 0x7FFD57512280
    }

}