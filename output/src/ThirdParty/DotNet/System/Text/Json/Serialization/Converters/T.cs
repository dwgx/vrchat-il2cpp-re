// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class TimeSpanConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x6DD4BC0
        public void Write(){} // RVA: 0x6DD5460
        public void .ctor(){} // RVA: 0x6DD5720
    }

    public class TimeSpanConverter : JsonPrimitiveConverter`1
    {
        public object MinimumTimeSpanFormatLength;
        public object MaximumTimeSpanFormatLength;
        public object MaximumEscapedTimeSpanFormatLength;

        // ── Methods ──
        public void Read(){} // RVA: 0x734A050
        public void ReadAsPropertyNameCore(){} // RVA: 0x734A080
        public void ReadCore(){} // RVA: 0x734A090
        public void Write(){} // RVA: 0x734A320
        public void WriteAsPropertyNameCore(){} // RVA: 0x734A4A0
        public void .ctor(){} // RVA: 0x734A620
    }

}