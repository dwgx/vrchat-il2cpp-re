// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 53
// Methods: 560

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class AAAARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8258880
    }

    public class AFSDBRecord : ResourceRecord
    {
        public ushort Subtype; // 0x30
        public MeaMod.DNS.Model.DomainName Target; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8258F80
        public void get_Subtype(){} // RVA: 0x7FFAC64EB3B0
        public void set_Subtype(){} // RVA: 0x7FFAC8258FE0
        public void get_Target(){} // RVA: 0x7FFAC31D0140
        public void set_Target(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC82590B0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC82591E0 | overloaded x2
    }

    public class ARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8259290
    }

    public class AddressRecord : ResourceRecord
    {
        public System.Net.IPAddress Address; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82588F0
        public void get_Address(){} // RVA: 0x7FFAC31D95E0
        public void set_Address(){} // RVA: 0x7FFAC2F4F890
        public void Create(){} // RVA: 0x7FFAC8258960
        public void ReadData(){} // RVA: 0x7FFAC8258D60 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC8258F30 | overloaded x2
    }

    public class CNAMERecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName Target; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8259300
        public void get_Target(){} // RVA: 0x7FFAC31D95E0
        public void set_Target(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC82593D0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC82594A0 | overloaded x2
    }

    public class DNAMERecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName Target; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8259500
        public void get_Target(){} // RVA: 0x7FFAC31D95E0
        public void set_Target(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC82593D0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC82594A0 | overloaded x2
    }

    public class DNSKEYRecord : ResourceRecord
    {
        public 0x6B288C18 Flags; // 0x30
        public byte Protocol; // 0x32
        public 0x6B28A0B8 Algorithm; // 0x33
        public byte[] PublicKey; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82595F0 | overloaded x2
        public void get_Flags(){} // RVA: 0x7FFAC64EB3B0
        public void set_Flags(){} // RVA: 0x7FFAC8258FE0
        public void get_Protocol(){} // RVA: 0x7FFAC64EB050
        public void set_Protocol(){} // RVA: 0x7FFAC8259980
        public void get_Algorithm(){} // RVA: 0x7FFAC8259990
        public void set_Algorithm(){} // RVA: 0x7FFAC82599A0
        public void get_PublicKey(){} // RVA: 0x7FFAC31D0140
        public void set_PublicKey(){} // RVA: 0x7FFAC31D0C20
        public void KeyTag(){} // RVA: 0x7FFAC82599B0
        public void ReadData(){} // RVA: 0x7FFAC8259C10 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC8259CC0 | overloaded x2
    }

    public class DSRecord : ResourceRecord
    {
        public ushort KeyTag; // 0x30
        public 0x6B28A0B8 Algorithm; // 0x32
        public 0x6B288B68 HashAlgorithm; // 0x33
        public byte[] Digest; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8259E30 | overloaded x2
        public void get_KeyTag(){} // RVA: 0x7FFAC64EB3B0
        public void set_KeyTag(){} // RVA: 0x7FFAC8258FE0
        public void get_Algorithm(){} // RVA: 0x7FFAC64EB050
        public void set_Algorithm(){} // RVA: 0x7FFAC8259980
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC8259990
        public void set_HashAlgorithm(){} // RVA: 0x7FFAC82599A0
        public void get_Digest(){} // RVA: 0x7FFAC31D0140
        public void set_Digest(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC825A340 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825A490 | overloaded x2
    }

    public class DigestRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<0x6B288B68,System.Func`1<System.Security.Cryptography.HashAlgorithm>> Digests;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC824EE00
        public void Create(){} // RVA: 0x7FFAC824F2C0 | overloaded x2
    }

    public class DnsObject : Object
    {
        public System.DateTime CreationTime; // 0x10

        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0x7FFAC2F3C380
        public void set_CreationTime(){} // RVA: 0x7FFAC441EFB0
        public void Length(){} // RVA: 0x7FFAC824F750
        public void Clone(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Read(){} // RVA: 0x7FFAC2C58F40 | overloaded x4
        public void ToByteArray(){} // RVA: 0x7FFAC824FC10
        public void Write(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC824FDA0
    }

    public class DomainName : Object
    {
        public string Labels;
        public char dotChar;
        public string escapedDot;
        public string backslash;
        public char backslashChar;
        public string escapedBackslash;
        public MeaMod.DNS.Model.DomainName Root;
        public System.Collections.Generic.List`1<string> labels; // 0x10

        // ── Methods ──
        public void get_Labels(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC824FEC0 | overloaded x2
        public void Join(){} // RVA: 0x7FFAC824FFD0
        public void ToString(){} // RVA: 0x7FFAC82500D0
        public void EscapeLabel(){} // RVA: 0x7FFAC82501A0
        public void ToCanonical(){} // RVA: 0x7FFAC8250410
        public void BelongsTo(){} // RVA: 0x7FFAC8250630
        public void IsSubdomainOf(){} // RVA: 0x7FFAC82506C0
        public void Parent(){} // RVA: 0x7FFAC8250840
        public void Parse(){} // RVA: 0x7FFAC8250990
        public void GetHashCode(){} // RVA: 0x7FFAC8250CA0
        public void Equals(){} // RVA: 0x7FFAC8250DB0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8250F10
        public void op_Inequality(){} // RVA: 0x7FFAC8250F30
        public void op_Implicit(){} // RVA: 0x7FFAC8250FC0
        public void LabelsEqual(){} // RVA: 0x7FFAC8251020
        public void .cctor(){} // RVA: 0x7FFAC82510F0
    }

    public class EdnsDAUOption : EdnsOption
    {
        public System.Collections.Generic.List`1<0x6B28A0B8> Algorithms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8251290
        public void get_Algorithms(){} // RVA: 0x7FFAC2F247C0
        public void set_Algorithms(){} // RVA: 0x7FFAC2F87E80
        public void Create(){} // RVA: 0x7FFAC8251350
        public void ReadData(){} // RVA: 0x7FFAC82514E0
        public void WriteData(){} // RVA: 0x7FFAC8251640
        public void ToString(){} // RVA: 0x7FFAC8251840
    }

    public class EdnsDHUOption : EdnsOption
    {
        public System.Collections.Generic.List`1<0x6B288B68> Algorithms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8251930
        public void get_Algorithms(){} // RVA: 0x7FFAC2F247C0
        public void set_Algorithms(){} // RVA: 0x7FFAC2F87E80
        public void Create(){} // RVA: 0x7FFAC82519F0
        public void ReadData(){} // RVA: 0x7FFAC8251B80
        public void WriteData(){} // RVA: 0x7FFAC8251CE0
        public void ToString(){} // RVA: 0x7FFAC8251EE0
    }

    public class EdnsKeepaliveOption : EdnsOption
    {
        public System.Nullable`1<System.TimeSpan> Timeout; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8251F50
        public void get_Timeout(){} // RVA: 0x7FFAC35D3330
        public void set_Timeout(){} // RVA: 0x7FFAC35D34F0
        public void ReadData(){} // RVA: 0x7FFAC8251F60
        public void WriteData(){} // RVA: 0x7FFAC82520C0
        public void ToString(){} // RVA: 0x7FFAC82521B0
    }

    public class EdnsN3UOption : EdnsOption
    {
        public System.Collections.Generic.List`1<0x6B288B68> Algorithms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8252260
        public void get_Algorithms(){} // RVA: 0x7FFAC2F247C0
        public void set_Algorithms(){} // RVA: 0x7FFAC2F87E80
        public void Create(){} // RVA: 0x7FFAC8252320
        public void ReadData(){} // RVA: 0x7FFAC82524B0
        public void WriteData(){} // RVA: 0x7FFAC8252610
        public void ToString(){} // RVA: 0x7FFAC8252810
    }

    public class EdnsNSIDOption : EdnsOption
    {
        public byte[] Id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8252880
        public void get_Id(){} // RVA: 0x7FFAC2F247C0
        public void set_Id(){} // RVA: 0x7FFAC2F87E80
        public void ReadData(){} // RVA: 0x7FFAC8252890
        public void WriteData(){} // RVA: 0x7FFAC8252910
    }

    public class EdnsOption : Object
    {
        public 0x6B2890E8 Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC469AEC0
        public void set_Type(){} // RVA: 0x7FFAC469BCA0
        public void ReadData(){} // RVA: 0x7FFAC2C77970
        public void WriteData(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EdnsOptionRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<0x6B2890E8,System.Func`1<MeaMod.DNS.Model.EdnsOption>> Options;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8252970
        public void Register(){} // RVA: 0x7FFAC2C709B0
    }

    public class EdnsPaddingOption : EdnsOption
    {
        public byte[] Padding; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8252AF0
        public void get_Padding(){} // RVA: 0x7FFAC2F247C0
        public void set_Padding(){} // RVA: 0x7FFAC2F87E80
        public void ReadData(){} // RVA: 0x7FFAC8252890
        public void WriteData(){} // RVA: 0x7FFAC8252910
        public void ToString(){} // RVA: 0x7FFAC8252B00
    }

    public class HINFORecord : ResourceRecord
    {
        public string Cpu; // 0x30
        public string OS; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825A5E0
        public void get_Cpu(){} // RVA: 0x7FFAC31D95E0
        public void set_Cpu(){} // RVA: 0x7FFAC2F4F890
        public void get_OS(){} // RVA: 0x7FFAC31D0140
        public void set_OS(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC825A740 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825A890 | overloaded x2
    }

    public class IPAddressExtensions : Object
    {
        // ── Methods ──
        public void GetArpaName(){} // RVA: 0x7FFAC8252C00
    }

    public class IPresentationSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC2C58F40
        public void Write(){} // RVA: 0x7FFAC2C70A40
    }

    public class IResolver
    {
        // ── Methods ──
        public void ResolveAsync(){}
    }

    public class IWireSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC2C58F40
        public void Write(){} // RVA: 0x7FFAC2C70A40
    }

    public class MXRecord : ResourceRecord
    {
        public ushort Preference; // 0x30
        public MeaMod.DNS.Model.DomainName Exchange; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825A8E0
        public void get_Preference(){} // RVA: 0x7FFAC64EB3B0
        public void set_Preference(){} // RVA: 0x7FFAC8258FE0
        public void get_Exchange(){} // RVA: 0x7FFAC31D0140
        public void set_Exchange(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC82590B0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC82591E0 | overloaded x2
    }

    public class Message : DnsObject
    {
        public byte Id; // 0x18
        public int QR;
        public int IsQuery;
        public ushort IsResponse; // 0x1A
        public bool Opcode; // 0x1C
        public bool AA; // 0x1D
        public bool TC; // 0x1E
        public bool RD; // 0x1F
        public bool RA; // 0x20
        public int Z; // 0x24
        public bool AD; // 0x28
        public bool CD; // 0x29
        public 0x6B289400 DO; // 0x2A
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.Question> Status; // 0x30
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> Questions; // 0x38
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> Answers; // 0x40
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> AuthorityRecords; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC7FDE3F0
        public void set_Id(){} // RVA: 0x7FFAC82534C0
        public void get_QR(){} // RVA: 0x7FFAC2F3C390
        public void set_QR(){} // RVA: 0x7FFAC2F3C3A0
        public void get_IsQuery(){} // RVA: 0x7FFAC82534D0
        public void get_IsResponse(){} // RVA: 0x7FFAC2F3C390
        public void get_Opcode(){} // RVA: 0x7FFAC82534E0
        public void set_Opcode(){} // RVA: 0x7FFAC82535F0
        public void get_AA(){} // RVA: 0x7FFAC45FA990
        public void set_AA(){} // RVA: 0x7FFAC45F8A90
        public void get_TC(){} // RVA: 0x7FFAC45FA550
        public void set_TC(){} // RVA: 0x7FFAC45FAFF0
        public void get_RD(){} // RVA: 0x7FFAC45F9F30
        public void set_RD(){} // RVA: 0x7FFAC45FA980
        public void get_RA(){} // RVA: 0x7FFAC300F9D0
        public void set_RA(){} // RVA: 0x7FFAC300F9E0
        public void get_Z(){} // RVA: 0x7FFAC3921980
        public void set_Z(){} // RVA: 0x7FFAC41674D0
        public void get_AD(){} // RVA: 0x7FFAC30F6BA0
        public void set_AD(){} // RVA: 0x7FFAC3C24F40
        public void get_CD(){} // RVA: 0x7FFAC386C550
        public void set_CD(){} // RVA: 0x7FFAC43B4D70
        public void get_DO(){} // RVA: 0x7FFAC8253750
        public void set_DO(){} // RVA: 0x7FFAC8253810
        public void get_Status(){} // RVA: 0x7FFAC4B82F20
        public void set_Status(){} // RVA: 0x7FFAC4B82F40
        public void get_Questions(){} // RVA: 0x7FFAC31D95E0
        public void get_Answers(){} // RVA: 0x7FFAC31D0140
        public void set_Answers(){} // RVA: 0x7FFAC31D0C20
        public void get_AuthorityRecords(){} // RVA: 0x7FFAC2F9E740
        public void set_AuthorityRecords(){} // RVA: 0x7FFAC2F49200
        public void get_AdditionalRecords(){} // RVA: 0x7FFAC2F9C730
        public void set_AdditionalRecords(){} // RVA: 0x7FFAC2F9C740
        public void CreateResponse(){} // RVA: 0x7FFAC82539B0
        public void Truncate(){} // RVA: 0x7FFAC8253A80
        public void UseDnsSecurity(){} // RVA: 0x7FFAC8253BE0
        public void Read(){} // RVA: 0x7FFAC8253C00
        public void Write(){} // RVA: 0x7FFAC8254200
        public void ToString(){} // RVA: 0x7FFAC82549F0
        public void Stringify(){} // RVA: 0x7FFAC82550B0
        public void .ctor(){} // RVA: 0x7FFAC82552F0
    }

    public class NSEC3PARAMRecord : ResourceRecord
    {
        public 0x6B288B68 HashAlgorithm; // 0x30
        public byte Flags; // 0x31
        public ushort Iterations; // 0x32
        public byte[] Salt; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825A940
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F47450
        public void set_HashAlgorithm(){} // RVA: 0x7FFAC2F47460
        public void get_Flags(){} // RVA: 0x7FFAC2F47470
        public void set_Flags(){} // RVA: 0x7FFAC2F47480
        public void get_Iterations(){} // RVA: 0x7FFAC825A9A0
        public void set_Iterations(){} // RVA: 0x7FFAC825A9B0
        public void get_Salt(){} // RVA: 0x7FFAC31D0140
        public void set_Salt(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC825AB80 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825ACA0 | overloaded x2
    }

    public class NSEC3Record : ResourceRecord
    {
        public 0x6B288B68 HashAlgorithm; // 0x30
        public 0x6B289458 Flags; // 0x31
        public ushort Iterations; // 0x32
        public byte[] Salt; // 0x38
        public byte[] NextHashedOwnerName; // 0x40
        public System.Collections.Generic.List`1<0x6B288CC8> Types; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825AE10
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F47450
        public void set_HashAlgorithm(){} // RVA: 0x7FFAC2F47460
        public void get_Flags(){} // RVA: 0x7FFAC2F47470
        public void set_Flags(){} // RVA: 0x7FFAC2F47480
        public void get_Iterations(){} // RVA: 0x7FFAC825A9A0
        public void set_Iterations(){} // RVA: 0x7FFAC825A9B0
        public void get_Salt(){} // RVA: 0x7FFAC31D0140
        public void set_Salt(){} // RVA: 0x7FFAC31D0C20
        public void get_NextHashedOwnerName(){} // RVA: 0x7FFAC2F9E740
        public void set_NextHashedOwnerName(){} // RVA: 0x7FFAC2F49200
        public void get_Types(){} // RVA: 0x7FFAC2F9C730
        public void set_Types(){} // RVA: 0x7FFAC2F9C740
        public void ReadData(){} // RVA: 0x7FFAC825B440 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825B7D0 | overloaded x2
    }

    public class NSECRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName NextOwnerName; // 0x30
        public System.Collections.Generic.List`1<0x6B288CC8> Types; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825BC40
        public void get_NextOwnerName(){} // RVA: 0x7FFAC31D95E0
        public void set_NextOwnerName(){} // RVA: 0x7FFAC2F4F890
        public void get_Types(){} // RVA: 0x7FFAC31D0140
        public void set_Types(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC825C180 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825C2B0 | overloaded x2
    }

    public class NSRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName Authority; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825C5E0
        public void get_Authority(){} // RVA: 0x7FFAC31D95E0
        public void set_Authority(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC82593D0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC82594A0 | overloaded x2
    }

    public class NULLRecord : ResourceRecord
    {
        public byte[] Data; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825C640
        public void get_Data(){} // RVA: 0x7FFAC31D95E0
        public void set_Data(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC825C720 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825C790
    }

    public class OPTRecord : ResourceRecord
    {
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.EdnsOption> RequestorPayloadSize; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825C7F0
        public void get_RequestorPayloadSize(){} // RVA: 0x7FFAC8258420
        public void set_RequestorPayloadSize(){} // RVA: 0x7FFAC8258430
        public void get_Opcode8(){} // RVA: 0x7FFAC825C9C0
        public void set_Opcode8(){} // RVA: 0x7FFAC825CA30
        public void get_Version(){} // RVA: 0x7FFAC825CAD0
        public void set_Version(){} // RVA: 0x7FFAC825CB40
        public void get_DO(){} // RVA: 0x7FFAC825CBE0
        public void set_DO(){} // RVA: 0x7FFAC825CC40
        public void get_Options(){} // RVA: 0x7FFAC31D95E0
        public void set_Options(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC825CD00
        public void WriteData(){} // RVA: 0x7FFAC825CEC0
        public void ToString(){} // RVA: 0x7FFAC825D0D0
    }

    public class PTRRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName DomainName; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825D400
        public void get_DomainName(){} // RVA: 0x7FFAC31D95E0
        public void set_DomainName(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC82593D0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC82594A0 | overloaded x2
    }

    public class PresentationReader : Object
    {
        public System.DateTime Origin;
        public System.IO.TextReader text; // 0x10
        public System.Nullable`1<System.TimeSpan> defaultTTL; // 0x18
        public MeaMod.DNS.Model.DomainName defaultDomainName; // 0x28
        public int parenLevel; // 0x30
        public int previousChar; // 0x34
        public bool eolSeen; // 0x38
        public bool tokenStartsNewLine; // 0x39
        public int Position; // 0x3C
        public MeaMod.DNS.Model.DomainName <Origin>k__BackingField; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8255570
        public void get_Origin(){} // RVA: 0x7FFAC2F9E740
        public void set_Origin(){} // RVA: 0x7FFAC2F49200
        public void ReadByte(){} // RVA: 0x7FFAC8255690
        public void ReadUInt16(){} // RVA: 0x7FFAC82557B0
        public void ReadUInt32(){} // RVA: 0x7FFAC82558D0
        public void ReadDomainName(){} // RVA: 0x7FFAC8255980
        public void MakeAbsoluteDomainName(){} // RVA: 0x7FFAC82559B0
        public void ReadString(){} // RVA: 0x7FFAC8255B60
        public void ReadBase64String(){} // RVA: 0x7FFAC8255B70
        public void ReadTimeSpan16(){} // RVA: 0x7FFAC8255D00
        public void ReadTimeSpan32(){} // RVA: 0x7FFAC8255DB0
        public void ReadIPAddress(){} // RVA: 0x7FFAC8255E60
        public void ReadDnsType(){} // RVA: 0x7FFAC8255F60
        public void ReadDateTime(){} // RVA: 0x7FFAC8256160
        public void ReadResourceData(){} // RVA: 0x7FFAC8256340
        public void ReadResourceRecord(){} // RVA: 0x7FFAC8256690
        public void IsEndOfLine(){} // RVA: 0x7FFAC8256E20
        public void ReadToken(){} // RVA: 0x7FFAC8256F80
        public void .cctor(){} // RVA: 0x7FFAC8257350
    }

    public class PresentationWriter : Object
    {
        public System.DateTime UnixEpoch;
        public System.IO.TextWriter text; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void WriteSpace(){} // RVA: 0x7FFAC82574C0
        public void WriteEndOfLine(){} // RVA: 0x7FFAC82574F0
        public void WriteByte(){} // RVA: 0x7FFAC8257550
        public void WriteUInt16(){} // RVA: 0x7FFAC82575C0
        public void WriteUInt32(){} // RVA: 0x7FFAC8257630
        public void WriteString(){} // RVA: 0x7FFAC82576A0
        public void WriteStringUnencoded(){} // RVA: 0x7FFAC82578A0
        public void WriteDomainName(){} // RVA: 0x7FFAC8257910
        public void WriteBase16String(){} // RVA: 0x7FFAC82579A0
        public void WriteBase64String(){} // RVA: 0x7FFAC8257A10
        public void WriteTimeSpan16(){} // RVA: 0x7FFAC8257B50
        public void WriteTimeSpan32(){} // RVA: 0x7FFAC8257C20
        public void WriteDateTime(){} // RVA: 0x7FFAC8257CF0
        public void WriteIPAddress(){} // RVA: 0x7FFAC8257E50
        public void WriteDnsType(){} // RVA: 0x7FFAC8257EB0
        public void WriteDnsClass(){} // RVA: 0x7FFAC8258120
        public void .cctor(){} // RVA: 0x7FFAC8258390
    }

    public class Question : DnsObject
    {
        public MeaMod.DNS.Model.DomainName Name; // 0x18
        public 0x6B288CC8 Type; // 0x20
        public 0x6B288BC0 Class; // 0x22

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void get_Type(){} // RVA: 0x7FFAC6D68C80
        public void set_Type(){} // RVA: 0x7FFAC8258410
        public void get_Class(){} // RVA: 0x7FFAC8258420
        public void set_Class(){} // RVA: 0x7FFAC8258430
        public void Read(){} // RVA: 0x7FFAC8258440
        public void Write(){} // RVA: 0x7FFAC8258520
        public void ToString(){} // RVA: 0x7FFAC8258600
        public void .ctor(){} // RVA: 0x7FFAC8258820
    }

    public class RPRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName Mailbox; // 0x30
        public MeaMod.DNS.Model.DomainName TextName; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825D460
        public void get_Mailbox(){} // RVA: 0x7FFAC31D95E0
        public void set_Mailbox(){} // RVA: 0x7FFAC2F4F890
        public void get_TextName(){} // RVA: 0x7FFAC31D0140
        public void set_TextName(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC825D6A0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825D800 | overloaded x2
    }

    public class RRSIGRecord : ResourceRecord
    {
        public 0x6B288CC8 TypeCovered; // 0x30
        public 0x6B28A0B8 Algorithm; // 0x32
        public byte Labels; // 0x33
        public System.TimeSpan OriginalTTL; // 0x38
        public System.DateTime SignatureExpiration; // 0x40
        public System.DateTime SignatureInception; // 0x48
        public ushort KeyTag; // 0x50
        public MeaMod.DNS.Model.DomainName SignerName; // 0x58
        public byte[] Signature; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825D8D0
        public void get_TypeCovered(){} // RVA: 0x7FFAC64EB3B0
        public void set_TypeCovered(){} // RVA: 0x7FFAC8258FE0
        public void get_Algorithm(){} // RVA: 0x7FFAC64EB050
        public void set_Algorithm(){} // RVA: 0x7FFAC8259980
        public void get_Labels(){} // RVA: 0x7FFAC8259990
        public void set_Labels(){} // RVA: 0x7FFAC82599A0
        public void get_OriginalTTL(){} // RVA: 0x7FFAC31D0140
        public void set_OriginalTTL(){} // RVA: 0x7FFAC35233F0
        public void get_SignatureExpiration(){} // RVA: 0x7FFAC2F9E740
        public void set_SignatureExpiration(){} // RVA: 0x7FFAC5FE03B0
        public void get_SignatureInception(){} // RVA: 0x7FFAC2F9C730
        public void set_SignatureInception(){} // RVA: 0x7FFAC4248FC0
        public void get_KeyTag(){} // RVA: 0x7FFAC6AD8870
        public void set_KeyTag(){} // RVA: 0x7FFAC825D930
        public void get_SignerName(){} // RVA: 0x7FFAC2FE9500
        public void set_SignerName(){} // RVA: 0x7FFAC2FE9510
        public void get_Signature(){} // RVA: 0x7FFAC2FBF370
        public void set_Signature(){} // RVA: 0x7FFAC2FBF380
        public void ReadData(){} // RVA: 0x7FFAC825DC80 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825DDF0 | overloaded x2
    }

    public class ResourceRecord : DnsObject
    {
        public System.TimeSpan Name;
        public System.TimeSpan CanonicalName; // 0x8
        public MeaMod.DNS.Model.DomainName Type; // 0x18
        public 0x6B288CC8 Class; // 0x20
        public 0x6B288BC0 TTL; // 0x22
        public System.TimeSpan <TTL>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void get_CanonicalName(){} // RVA: 0x7FFAC8260D80
        public void get_Type(){} // RVA: 0x7FFAC6D68C80
        public void set_Type(){} // RVA: 0x7FFAC8258410
        public void get_Class(){} // RVA: 0x7FFAC8258420
        public void set_Class(){} // RVA: 0x7FFAC8258430
        public void get_TTL(){} // RVA: 0x7FFAC2F4F130
        public void set_TTL(){} // RVA: 0x7FFAC33D3BF0
        public void IsExpired(){} // RVA: 0x7FFAC8260DC0
        public void GetDataLength(){} // RVA: 0x7FFAC8260EA0
        public void GetData(){} // RVA: 0x7FFAC8260FF0
        public void Read(){} // RVA: 0x7FFAC8261F10 | overloaded x3
        public void ReadData(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Write(){} // RVA: 0x7FFAC8261B60 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC8261D20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC82614D0
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void op_Inequality(){} // RVA: 0x7FFAC8261680
        public void GetHashCode(){} // RVA: 0x7FFAC82616C0
        public void ToString(){} // RVA: 0x7FFAC8261940
        public void .ctor(){} // RVA: 0x7FFAC8261F30
        public void .cctor(){} // RVA: 0x7FFAC8261FE0
    }

    public class ResourceRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<0x6B288CC8,System.Func`1<MeaMod.DNS.Model.ResourceRecord>> Records;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC82621A0
        public void Register(){} // RVA: 0x7FFAC2C709B0
        public void Create(){} // RVA: 0x7FFAC8262510
    }

    public class SOARecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName PrimaryName; // 0x30
        public MeaMod.DNS.Model.DomainName Mailbox; // 0x38
        public uint SerialNumber; // 0x40
        public System.TimeSpan Refresh; // 0x48
        public System.TimeSpan Retry; // 0x50
        public System.TimeSpan Expire; // 0x58
        public System.TimeSpan Minimum; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825DFB0
        public void get_PrimaryName(){} // RVA: 0x7FFAC31D95E0
        public void set_PrimaryName(){} // RVA: 0x7FFAC2F4F890
        public void get_Mailbox(){} // RVA: 0x7FFAC31D0140
        public void set_Mailbox(){} // RVA: 0x7FFAC31D0C20
        public void get_SerialNumber(){} // RVA: 0x7FFAC2FC2080
        public void set_SerialNumber(){} // RVA: 0x7FFAC2FC2090
        public void get_Refresh(){} // RVA: 0x7FFAC2F9C730
        public void set_Refresh(){} // RVA: 0x7FFAC4248FC0
        public void get_Retry(){} // RVA: 0x7FFAC2FC20E0
        public void set_Retry(){} // RVA: 0x7FFAC42499F0
        public void get_Expire(){} // RVA: 0x7FFAC2FE9500
        public void set_Expire(){} // RVA: 0x7FFAC4249140
        public void get_Minimum(){} // RVA: 0x7FFAC2FBF370
        public void set_Minimum(){} // RVA: 0x7FFAC825E080
        public void ReadData(){} // RVA: 0x7FFAC825E1D0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825E3D0 | overloaded x2
    }

    public class SRVRecord : ResourceRecord
    {
        public ushort Priority; // 0x30
        public ushort Weight; // 0x32
        public ushort Port; // 0x34
        public MeaMod.DNS.Model.DomainName Target; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825E5D0
        public void get_Priority(){} // RVA: 0x7FFAC64EB3B0
        public void set_Priority(){} // RVA: 0x7FFAC8258FE0
        public void get_Weight(){} // RVA: 0x7FFAC825A9A0
        public void set_Weight(){} // RVA: 0x7FFAC825A9B0
        public void get_Port(){} // RVA: 0x7FFAC825E630
        public void set_Port(){} // RVA: 0x7FFAC825E640
        public void get_Target(){} // RVA: 0x7FFAC31D0140
        public void set_Target(){} // RVA: 0x7FFAC31D0C20
        public void ReadData(){} // RVA: 0x7FFAC825E750 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825E950 | overloaded x2
    }

    public class SecurityAlgorithmRegistry : Object
    {
        public System.Collections.Generic.Dictionary`2<0x6B28A0B8,Metadata> Algorithms;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8262630
        public void GetMetadata(){} // RVA: 0x7FFAC8262C40
    }

    public class TKEYRecord : ResourceRecord
    {
        public byte[] Algorithm;
        public MeaMod.DNS.Model.DomainName Inception; // 0x30
        public System.DateTime Expiration; // 0x38
        public System.DateTime Mode; // 0x40
        public 0x6B2892F8 Error; // 0x48
        public 0x6B289400 Key; // 0x4A
        public byte[] OtherData; // 0x50
        public byte[] <OtherData>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825EA90
        public void get_Algorithm(){} // RVA: 0x7FFAC31D95E0
        public void set_Algorithm(){} // RVA: 0x7FFAC2F4F890
        public void get_Inception(){} // RVA: 0x7FFAC31D0140
        public void set_Inception(){} // RVA: 0x7FFAC35233F0
        public void get_Expiration(){} // RVA: 0x7FFAC2F9E740
        public void set_Expiration(){} // RVA: 0x7FFAC5FE03B0
        public void get_Mode(){} // RVA: 0x7FFAC825EBE0
        public void set_Mode(){} // RVA: 0x7FFAC825EBF0
        public void get_Error(){} // RVA: 0x7FFAC41656F0
        public void set_Error(){} // RVA: 0x7FFAC4164B40
        public void get_Key(){} // RVA: 0x7FFAC2FC20E0
        public void set_Key(){} // RVA: 0x7FFAC30794D0
        public void get_OtherData(){} // RVA: 0x7FFAC2FE9500
        public void set_OtherData(){} // RVA: 0x7FFAC2FE9510
        public void ReadData(){} // RVA: 0x7FFAC825EF30 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825F260 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC825F420
    }

    public class TSIGRecord : ResourceRecord
    {
        public byte[] Algorithm;
        public string TimeSigned;
        public string MAC;
        public string Fudge;
        public string OriginalMessageId;
        public string Error;
        public string OtherData;
        public string HMACSHA512;
        public MeaMod.DNS.Model.DomainName <Algorithm>k__BackingField; // 0x30
        public System.DateTime <TimeSigned>k__BackingField; // 0x38
        public byte[] <MAC>k__BackingField; // 0x40
        public System.TimeSpan <Fudge>k__BackingField; // 0x48
        public ushort <OriginalMessageId>k__BackingField; // 0x50
        public 0x6B289400 <Error>k__BackingField; // 0x52
        public byte[] <OtherData>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC825F4D0
        public void get_Algorithm(){} // RVA: 0x7FFAC31D95E0
        public void set_Algorithm(){} // RVA: 0x7FFAC2F4F890
        public void get_TimeSigned(){} // RVA: 0x7FFAC31D0140
        public void set_TimeSigned(){} // RVA: 0x7FFAC35233F0
        public void get_MAC(){} // RVA: 0x7FFAC2F9E740
        public void set_MAC(){} // RVA: 0x7FFAC2F49200
        public void get_Fudge(){} // RVA: 0x7FFAC2F9C730
        public void set_Fudge(){} // RVA: 0x7FFAC4248FC0
        public void get_OriginalMessageId(){} // RVA: 0x7FFAC6AD8870
        public void set_OriginalMessageId(){} // RVA: 0x7FFAC825D930
        public void get_Error(){} // RVA: 0x7FFAC825F9A0
        public void set_Error(){} // RVA: 0x7FFAC825F9B0
        public void get_OtherData(){} // RVA: 0x7FFAC2FE9500
        public void set_OtherData(){} // RVA: 0x7FFAC2FE9510
        public void ReadData(){} // RVA: 0x7FFAC8260080 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC8260440 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8260690
    }

    public class TXTRecord : ResourceRecord
    {
        public System.Collections.Generic.List`1<string> Strings; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8260740
        public void get_Strings(){} // RVA: 0x7FFAC31D95E0
        public void set_Strings(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC8260950 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC8260B80 | overloaded x2
    }

    public class UnknownEdnsOption : EdnsOption
    {
        public byte[] Data; // 0x18

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F247C0
        public void set_Data(){} // RVA: 0x7FFAC2F87E80
        public void ReadData(){} // RVA: 0x7FFAC8252890
        public void WriteData(){} // RVA: 0x7FFAC8252910
        public void ToString(){} // RVA: 0x7FFAC8262DF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnknownRecord : ResourceRecord
    {
        public byte[] Data; // 0x30

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC31D95E0
        public void set_Data(){} // RVA: 0x7FFAC2F4F890
        public void ReadData(){} // RVA: 0x7FFAC825C720 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAC825C790
        public void .ctor(){} // RVA: 0x7FFAC8260D30
    }

    public class UpdateMessage : DnsObject
    {
        public ushort Id; // 0x18
        public bool QR; // 0x1A
        public 0x6B2893A8 IsUpdate; // 0x1C
        public int IsResponse; // 0x20
        public 0x6B289400 Opcode; // 0x24
        public MeaMod.DNS.Model.Question Z; // 0x28
        public MeaMod.DNS.Model.UpdatePrerequisiteList Status; // 0x30
        public MeaMod.DNS.Model.UpdateResourceList Zone; // 0x38
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> Prerequisites; // 0x40

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC5F39D20
        public void set_Id(){} // RVA: 0x7FFAC6D24B10
        public void get_QR(){} // RVA: 0x7FFAC45FA190
        public void set_QR(){} // RVA: 0x7FFAC45F9AE0
        public void get_IsUpdate(){} // RVA: 0x7FFAC8262FA0
        public void get_IsResponse(){} // RVA: 0x7FFAC45FA190
        public void get_Opcode(){} // RVA: 0x7FFAC8262FB0
        public void set_Opcode(){} // RVA: 0x7FFAC8262FC0
        public void get_Z(){} // RVA: 0x7FFAC30DBBE0
        public void set_Z(){} // RVA: 0x7FFAC35DB7A0
        public void get_Status(){} // RVA: 0x7FFAC2F3C7C0
        public void set_Status(){} // RVA: 0x7FFAC4422FB0
        public void get_Zone(){} // RVA: 0x7FFAC2F4F130
        public void set_Zone(){} // RVA: 0x7FFAC2F22E90
        public void get_Prerequisites(){} // RVA: 0x7FFAC31D95E0
        public void get_Updates(){} // RVA: 0x7FFAC31D0140
        public void get_AdditionalResources(){} // RVA: 0x7FFAC2F9E740
        public void CreateResponse(){} // RVA: 0x7FFAC8262FD0
        public void Read(){} // RVA: 0x7FFAC8263050
        public void Write(){} // RVA: 0x7FFAC82635F0
        public void .ctor(){} // RVA: 0x7FFAC8263C20
    }

    public class UpdatePrerequisiteList : List`1
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x7FFAC82640D0 | overloaded x4
        public void MustNotExist(){} // RVA: 0x7FFAC2C58F40 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC82642C0
    }

    public class UpdateResourceList : List`1
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x7FFAC8264330
        public void DeleteResource(){} // RVA: 0x7FFAC2C58F40 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAC8264680
    }

    public class WireReader : Object
    {
        public System.DateTime UnixEpoch;
        public System.IO.Stream stream; // 0x10
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<string>> names; // 0x18
        public int Position; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82646F0
        public void ReadByte(){} // RVA: 0x7FFAC8264810
        public void ReadBytes(){} // RVA: 0x7FFAC8264890
        public void ReadByteLengthPrefixedBytes(){} // RVA: 0x7FFAC8264980
        public void ReadUInt16LengthPrefixedBytes(){} // RVA: 0x7FFAC82649B0
        public void ReadUInt16(){} // RVA: 0x7FFAC82649F0
        public void ReadUInt32(){} // RVA: 0x7FFAC8264A30
        public void ReadUInt48(){} // RVA: 0x7FFAC8264AA0
        public void ReadDomainName(){} // RVA: 0x7FFAC8264B50
        public void ReadLabels(){} // RVA: 0x7FFAC8264BF0
        public void ReadString(){} // RVA: 0x7FFAC8264E10
        public void ReadTimeSpan16(){} // RVA: 0x7FFAC82650D0
        public void ReadTimeSpan32(){} // RVA: 0x7FFAC82651A0
        public void ReadIPAddress(){} // RVA: 0x7FFAC8265250
        public void ReadBitmap(){} // RVA: 0x7FFAC8265330
        public void ReadDateTime32(){} // RVA: 0x7FFAC8265480
        public void ReadDateTime48(){} // RVA: 0x7FFAC8265570
        public void .cctor(){} // RVA: 0x7FFAC8265710
    }

    public class WireWriter : Object
    {
        public int CanonicalForm;
        public ulong uint48MaxValue;
        public System.DateTime UnixEpoch;
        public System.IO.Stream stream; // 0x10
        public System.Collections.Generic.Dictionary`2<string,int> pointers; // 0x18
        public System.Collections.Generic.Stack`1<System.IO.Stream> scopes; // 0x20
        public int Position; // 0x28
        public bool <CanonicalForm>k__BackingField; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8265840
        public void get_CanonicalForm(){} // RVA: 0x7FFAC3000230
        public void set_CanonicalForm(){} // RVA: 0x7FFAC3000240
        public void PushLengthPrefixedScope(){} // RVA: 0x7FFAC8265A10
        public void PopLengthPrefixedScope(){} // RVA: 0x7FFAC8265AF0
        public void WriteByte(){} // RVA: 0x7FFAC8265C60
        public void WriteBytes(){} // RVA: 0x7FFAC8265CA0
        public void WriteByteLengthPrefixedBytes(){} // RVA: 0x7FFAC8265D00
        public void WriteUint16LengthPrefixedBytes(){} // RVA: 0x7FFAC8265E20
        public void WriteUInt16(){} // RVA: 0x7FFAC8265F20
        public void WriteUInt32(){} // RVA: 0x7FFAC8265F90
        public void WriteUInt48(){} // RVA: 0x7FFAC8266040
        public void WriteDomainName(){} // RVA: 0x7FFAC8266280 | overloaded x2
        public void WriteString(){} // RVA: 0x7FFAC8266650
        public void WriteTimeSpan16(){} // RVA: 0x7FFAC8266850
        public void WriteTimeSpan32(){} // RVA: 0x7FFAC8266910
        public void WriteDateTime32(){} // RVA: 0x7FFAC8266990
        public void WriteDateTime48(){} // RVA: 0x7FFAC8266AC0
        public void WriteIPAddress(){} // RVA: 0x7FFAC8266BF0
        public void WriteBitmap(){} // RVA: 0x7FFAC8266C60
        public void ToBytes(){} // RVA: 0x7FFAC8267590
        public void .cctor(){} // RVA: 0x7FFAC8267650
    }

}