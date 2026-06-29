// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Converters
// Classes: 4
// Methods: 25

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Converters
{
    public class BinaryConverter : JsonConverter
    {
        public object _reflectionObject;

        // ── Methods ──
        public void WriteJson(){} // RVA: 0x81BA450
        public void GetByteArray(){} // RVA: 0x81BA4C0
        public void EnsureReflectionObject(){} // RVA: 0x81BA660
        public void ReadJson(){} // RVA: 0x81BA860
        public void ReadByteArray(){} // RVA: 0x81BACC0
        public void CanConvert(){} // RVA: 0x81BAF40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BsonObjectIdConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x81BAFA0
        public void ReadJson(){} // RVA: 0x81BB220
        public void CanConvert(){} // RVA: 0x81BB4E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class KeyValuePairConverter : JsonConverter
    {
        public object ReflectionObjectPerType;

        // ── Methods ──
        public void InitializeReflectionObject(){} // RVA: 0x81BB580
        public void WriteJson(){} // RVA: 0x81BB780
        public void ReadJson(){} // RVA: 0x81BBAA0
        public void CanConvert(){} // RVA: 0x81BBFF0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x81BC140
    }

    public class RegexConverter : JsonConverter
    {
        // ── Methods ──
        public void WriteJson(){} // RVA: 0x81BC5D0
        public void HasFlag(){} // RVA: 0x67AC200
        public void WriteBson(){} // RVA: 0x81BC490
        public void ReadJson(){} // RVA: 0x81BC7F0
        public void ReadRegexString(){} // RVA: 0x81BC8B0
        public void ReadRegexObject(){} // RVA: 0x81BCA90
        public void CanConvert(){} // RVA: 0x81BCEC0
        public void .ctor(){} // RVA: 0xB43310
    }

}