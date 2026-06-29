// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 7
// Methods: 38

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class CastingConverter`1 : JsonConverter`1
    {
        public object _sourceConverter;
        public object _handleNull;

        // ── Methods ──
        public void get_KeyType(){} // RVA: 0x87C0A0
        public void get_ElementType(){} // RVA: 0x87C0A0
        public void get_HandleNull(){} // RVA: 0x87D280
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x87C0A0
        public void Read(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void OnTryRead(){} // RVA: 0x87F2C0
        public void OnTryWrite(){} // RVA: 0xA94080
        public void ReadAsPropertyName(){} // RVA: 0xA94080
        public void ReadAsPropertyNameCore(){} // RVA: 0xA94080
        public void WriteAsPropertyName(){} // RVA: 0xA94080
        public void WriteAsPropertyNameCore(){} // RVA: 0xA94080
        public void ReadNumberWithCustomHandling(){} // RVA: 0xA94080
        public void WriteNumberWithCustomHandling(){} // RVA: 0xA94080
    }

    public class CharConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x6DD2490
        public void Write(){} // RVA: 0x6DD2500
        public void ReadAsPropertyNameCore(){} // RVA: 0x6DD25F0
        public void WriteAsPropertyNameCore(){} // RVA: 0x6DD2610
        public void .ctor(){} // RVA: 0x6DD2730
    }

    public class CharConverter : JsonPrimitiveConverter`1
    {
        public object MaxEscapedCharacterLength;

        // ── Methods ──
        public void Read(){} // RVA: 0x7347AA0
        public void Write(){} // RVA: 0x7347BB0
        public void ReadAsPropertyNameCore(){} // RVA: 0x40DF800
        public void WriteAsPropertyNameCore(){} // RVA: 0x7347C80
        public void .ctor(){} // RVA: 0x7347CF0
    }

    public class ConcurrentQueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ConcurrentQueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ConcurrentStackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ConcurrentStackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

}