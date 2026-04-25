// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.JSON
// Classes: 1
// Methods: 23

namespace ThirdParty.BestHTTP.BestHTTP.JSON
{
    public class Json : Object
    {
        public object DummySyncRootObject;
        public int TOKEN_NONE;
        public int TOKEN_CURLY_OPEN;
        public int TOKEN_CURLY_CLOSE;
        public int TOKEN_SQUARED_OPEN;
        public int TOKEN_SQUARED_CLOSE;
        public int TOKEN_COLON;
        public int TOKEN_COMMA;
        public int TOKEN_STRING;
        public int TOKEN_NUMBER;
        public int TOKEN_TRUE;
        public int TOKEN_FALSE;
        public int TOKEN_NULL;
        public Unity.Profiling.ProfilerMarker _encodeProfilerMarker; // 0x8
        public Unity.Profiling.ProfilerMarker _decodeProfilerMarker; // 0x10

        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFACBE08020 | overloaded x4
        public void Encode(){} // RVA: 0x7FFAC2C69730 | overloaded x3
        public void ParseObject(){} // RVA: 0x7FFACBE08550
        public void ParseArray(){} // RVA: 0x7FFACBE08D20
        public void ParseValue(){} // RVA: 0x7FFACBE09210
        public void ParseString(){} // RVA: 0x7FFACBE096C0
        public void ParseNumber(){} // RVA: 0x7FFACBE0A090
        public void GetLastIndexOfNumber(){} // RVA: 0x7FFACBE0A370
        public void EatWhitespace(){} // RVA: 0x7FFACBE0A430
        public void LookAhead(){} // RVA: 0x7FFACBE0A4E0
        public void NextToken(){} // RVA: 0x7FFACBE0A550
        public void SerializeValue(){} // RVA: 0x7FFACBE0A890
        public void AddWhitespace(){} // RVA: 0x7FFACBE0AC80
        public void SerializeObject(){} // RVA: 0x7FFAC2E8DC40
        public void SerializeArray(){} // RVA: 0x7FFAC2E8DC40
        public void SerializeString(){} // RVA: 0x7FFACBE0AD10
        public void SerializeNumber(){} // RVA: 0x7FFACBE0AFB0
        public void .cctor(){} // RVA: 0x7FFACBE0B0B0
    }

}