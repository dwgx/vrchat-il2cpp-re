// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Converters
// Classes: 4
// Methods: 26

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        public Valve.Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject; // 0x10

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC9D1A5E0
        public void GetByteArray(){} // RVA: 0x7FFAC9D1A650
        public void EnsureReflectionObject(){} // RVA: 0x7FFAC9D1A7F0
        public void ReadJson(){} // RVA: 0x7FFAC9D1A9D0
        public void ReadByteArray(){} // RVA: 0x7FFAC9D1AE30
        public void CanConvert(){} // RVA: 0x7FFAC9D1B0B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC9D1B110
        public void ReadJson(){} // RVA: 0x7FFAC9D1B3B0
        public void CanConvert(){} // RVA: 0x7FFAC9D1B670
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class KeyValuePairConverter : JsonConverter
    {
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Valve.Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType;

        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x7FFAC9D1B740
        public void WriteJson(){} // RVA: 0x7FFAC9D1B940
        public void ReadJson(){} // RVA: 0x7FFAC9D1BC70
        public void CanConvert(){} // RVA: 0x7FFAC9D1C1C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9D1C2E0
    }

    public class RegexConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x7FFAC9D1C740 | overloaded x2
        public void HasFlag(){} // RVA: 0x7FFAC84CAD10
        public void WriteBson(){} // RVA: 0x7FFAC9D1C520
        public void ReadJson(){} // RVA: 0x7FFAC9D1C960
        public void ReadRegexString(){} // RVA: 0x7FFAC9D1CA20
        public void ReadRegexObject(){} // RVA: 0x7FFAC9D1CC10
        public void CanConvert(){} // RVA: 0x7FFAC9D1D050
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}