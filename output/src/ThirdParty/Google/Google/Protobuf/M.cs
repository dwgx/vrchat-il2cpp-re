// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 3
// Methods: 19

namespace ThirdParty.Google.Google.Protobuf
{
    public class MessageExtensions
    {
        // ── Methods ──
        public void MergeFrom(){} // RVA: 0x5A2D5A0 | overloaded x5
        public void ToByteArray(){} // RVA: 0x5A2CE50
        public void ToByteString(){} // RVA: 0x5A2CFA0
        public void WriteTo(){} // RVA: 0x5A2D080
    }

    public class MessageParser
    {
        public System.Func`1<Google.Protobuf.IMessage> factory; // 0x10
        public bool <DiscardUnknownFields>k__BackingField; // 0x18

        // ── Methods ──
        public void get_DiscardUnknownFields(){} // RVA: 0x2F84E0
        public void get_Extensions(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x5A2D7B0
        public void CreateTemplate(){} // RVA: 0x1281E30
        public void ParseFrom(){} // RVA: 0x5A2D870
    }

    public class MessageParser`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2AD00 | overloaded x2
        public void CreateTemplate(){} // RVA: 0x283FA0
        public void ParseFrom(){} // RVA: 0x283FA0 | overloaded x2
        public void WithExtensionRegistry(){} // RVA: 0xCE10
    }

}