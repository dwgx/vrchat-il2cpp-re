// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Internal
// Classes: 9
// Methods: 32

namespace ThirdParty.Other.ZLogger.Internal
{
    public class <EnumDictionary>FADF3D51B83FF80D45F581868D8BC170BC1D06511D1532EA8388B7F748A636021__DistinctEqualityComparer`1 : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class <EnumDictionary>FADF3D51B83FF80D45F581868D8BC170BC1D06511D1532EA8388B7F748A636021__EnumName : Object
    {
        public string Name; // 0x10
        public byte[] Utf8Name; // 0x18
        public System.Text.Json.JsonEncodedText JsonEncoded; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0EFD20
        public void ToString(){} // RVA: 0x7FFAC2F3C380
    }

    public class <EnumDictionary>FADF3D51B83FF80D45F581868D8BC170BC1D06511D1532EA8388B7F748A636021__ShimsExtensions : Object
    {
        // ── Methods ──
        public void ToFrozenDictionary(){} // RVA: 0x7FFAC2C69600
    }

    public class CodeGeneratorUtil : Object
    {
        public System.Text.Json.Utf8JsonWriter utf8JsonWriter; // 0xFFFF

        // ── Methods ──
        public void GetThreadStaticUtf8JsonWriter(){} // RVA: 0x7FFACC0EF9F0
        public void AppendAsJson(){} // RVA: 0x7FFACC0EFB40 | overloaded x2
    }

    public class EnumDictionary`1 : Object
    {
        public object dictionary;
        public UIntPtr GetStringName;
        public UIntPtr GetUtf8Name;
        public UIntPtr GetJsonEncodedName;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void GetStringNameCore(){} // RVA: 0x7FFAC2E8DC40
        public void GetUtf8NameCore(){} // RVA: 0x7FFAC2E8DC40
        public void GetJsonEncodedTextCore(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IObjectPoolNode`1
    {
        public object NextNode;

        // ── Methods ──
        public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    }

    public class MagicalBox : ValueType
    {
        public byte[] storage; // 0x10
        public int written; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BFE610
        public void TryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void TryRead(){} // RVA: 0x7FFAC2C5B260
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void ReadBoxed(){} // RVA: 0x7FFACC0EFE20
        public void TryReadTo(){} // RVA: 0x7FFACC0F0A00 | overloaded x2
        public void IsSupportedType(){} // RVA: 0x7FFAC2C59D30
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFACC0F1540
    }

    public class ObjectPool`1 : Object
    {
        public int gate;
        public T root;

        // ── Methods ──
        public void TryPop(){} // RVA: 0x7FFAC2C59F60
        public void TryPush(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class StreamBufferWriter : Object
    {
        public System.IO.Stream stream; // 0x10
        public byte[] buffer; // 0x18
        public byte[] defaultBuffer; // 0x20
        public int written; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0F1CF0
        public void Advance(){} // RVA: 0x7FFACC0F1E40
        public void GetMemory(){} // RVA: 0x7FFACC0F1E50
        public void GetSpan(){} // RVA: 0x7FFACC0F1FF0
        public void TryGetForNewLine(){} // RVA: 0x7FFACC0F2190
        public void Flush(){} // RVA: 0x7FFACC0F2280
    }

}