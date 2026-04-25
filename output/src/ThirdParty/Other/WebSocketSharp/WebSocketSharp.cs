// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 2
// Methods: 70

namespace ThirdParty.Other.WebSocketSharp
{
    public class Ext : Object
    {
        public byte[] _last;
        public int _retry; // 0x8
        public System.Func`2<string,bool> CS$<>9__CachedAnonymousMethodDelegate1; // 0x10

        // ── Methods ──
        public void decompress(){} // RVA: 0x7FFD574BF730 | overloaded x2
        public void decompressToArray(){} // RVA: 0x7FFD574BF9D0
        public void Append(){} // RVA: 0x7FFD574BFB10
        public void CheckIfValidProtocols(){} // RVA: 0x7FFD574BFC70
        public void CheckWaitTime(){} // RVA: 0x7FFD574BFE50
        public void Contains(){} // RVA: 0x7FFD574C2D50 | overloaded x4
        public void ContainsTwice(){} // RVA: 0x7FFD574BFF90
        public void CopyTo(){} // RVA: 0x7FFD574C0170
        public void Decompress(){} // RVA: 0x7FFD574C0240
        public void DecompressToArray(){} // RVA: 0x7FFD574C02B0
        public void EqualsWith(){} // RVA: 0x7FFD574C0340
        public void GetAbsolutePath(){} // RVA: 0x7FFD574C0380
        public void GetMessage(){} // RVA: 0x7FFD574C04C0
        public void GetValue(){} // RVA: 0x7FFD574C06E0 | overloaded x2
        public void InternalToByteArray(){} // RVA: 0x7FFD574C09B0 | overloaded x2
        public void IsCompressionExtension(){} // RVA: 0x7FFD574C0AB0
        public void IsControl(){} // RVA: 0x7FFD574C0B60
        public void IsData(){} // RVA: 0x7FFD574C0B70 | overloaded x2
        public void IsReserved(){} // RVA: 0x7FFD574C0B90 | overloaded x2
        public void IsSupported(){} // RVA: 0x7FFD574C0BC0
        public void IsText(){} // RVA: 0x7FFD574C0D70
        public void IsToken(){} // RVA: 0x7FFD574C0FD0
        public void ReadBytes(){} // RVA: 0x7FFD574C12E0 | overloaded x2
        public void ReadBytesAsync(){} // RVA: 0x7FFD574C1870 | overloaded x2
        public void Reverse(){} // RVA: 0x7FFD4E078F80
        public void SplitHeaderValue(){} // RVA: 0x7FFD574C1C30
        public void ToByteArray(){} // RVA: 0x7FFD574C1D60
        public void ToExtensionString(){} // RVA: 0x7FFD574C1FC0
        public void ToUInt16(){} // RVA: 0x7FFD574C21A0
        public void ToUInt64(){} // RVA: 0x7FFD574C2250
        public void TryCreateWebSocketUri(){} // RVA: 0x7FFD574C2300
        public void Unquote(){} // RVA: 0x7FFD574C2930
        public void UTF8Decode(){} // RVA: 0x7FFD574C2A30
        public void UTF8Encode(){} // RVA: 0x7FFD574C2A70
        public void WriteBytes(){} // RVA: 0x7FFD574C2AB0
        public void Emit(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetCookies(){} // RVA: 0x7FFD574C2F50
        public void IsEnclosedIn(){} // RVA: 0x7FFD574C30A0
        public void IsHostOrder(){} // RVA: 0x7FFD54CD7F90
        public void IsNullOrEmpty(){} // RVA: 0x7FFD574C30F0
        public void IsPredefinedScheme(){} // RVA: 0x7FFD574C3110
        public void MaybeUri(){} // RVA: 0x7FFD574C3460
        public void SubArray(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Times(){} // RVA: 0x7FFD574C3500
        public void ToHostOrder(){} // RVA: 0x7FFD574C3550
        public void ToString(){} // RVA: 0x7FFD4E078FF0
        public void ToUri(){} // RVA: 0x7FFD574C36E0
        public void UrlDecode(){} // RVA: 0x7FFD574C3800
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0x7FFD574C38C0
        public void .cctor(){} // RVA: 0x7FFD574C3930
    }

    public class HttpBase : Object
    {
        public 0x664979F8 EntityBody; // 0x10
        public System.Version Headers; // 0x18
        public byte[] ProtocolVersion; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538842F0
        public void get_EntityBody(){} // RVA: 0x7FFD574E2270
        public void get_Headers(){} // RVA: 0x7FFD510E4750
        public void get_ProtocolVersion(){} // RVA: 0x7FFD50CC1130
        public void readEntityBody(){} // RVA: 0x7FFD574E23A0
        public void readHeaders(){} // RVA: 0x7FFD574E25C0
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void ToByteArray(){} // RVA: 0x7FFD574E29F0
    }

}