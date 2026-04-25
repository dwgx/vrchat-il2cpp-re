// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 13

namespace ThirdParty.DotNet.System.Net
{
    public class BasicClient : Object
    {
        public object AuthenticationType;

        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7FFAC92DD100
        public void GetBytes(){} // RVA: 0x7FFAC92DD370
        public void InternalAuthenticate(){} // RVA: 0x7FFAC92DD420
        public void PreAuthenticate(){} // RVA: 0x7FFAC92DD780
        public void get_AuthenticationType(){} // RVA: 0x7FFAC92DD7A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BindIPEndPoint : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A802F0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
    }

    public class BufferOffsetSize : Object
    {
        public byte[] Buffer; // 0x10
        public int Offset; // 0x18
        public int Size; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92C12E0 | overloaded x2
    }

    public class BufferedReadStream : WebReadStream
    {
        public System.Net.BufferOffsetSize readBuffer; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92DD7E0
        public void ProcessReadAsync(){} // RVA: 0x7FFAC92DD850
        public void TryReadFromBuffer(){} // RVA: 0x7FFAC92DDAD0
    }

}