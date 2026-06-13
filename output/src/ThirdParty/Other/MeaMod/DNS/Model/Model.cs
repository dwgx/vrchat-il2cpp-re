// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 53
// Methods: 560

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class AAAARecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC1390
    }

    public class AFSDBRecord
    {
        public ushort <Subtype>k__BackingField; // 0x30
        public MeaMod.DNS.Model.DomainName <Target>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC1A90
        public void get_Subtype(){} // RVA: 0x3BE7880
        public void set_Subtype(){} // RVA: 0x5AC1AF0
        public void get_Target(){} // RVA: 0x4976A0
        public void set_Target(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC1BC0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1CF0 | overloaded x2
    }

    public class ARecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC1DA0
    }

    public class AddressRecord
    {
        public System.Net.IPAddress <Address>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC1400
        public void get_Address(){} // RVA: 0x6374D0
        public void set_Address(){} // RVA: 0x30B890
        public void Create(){} // RVA: 0x5AC1470
        public void ReadData(){} // RVA: 0x5AC1870 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1A40 | overloaded x2
    }

    public class CNAMERecord
    {
        public MeaMod.DNS.Model.DomainName <Target>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC1E10
        public void get_Target(){} // RVA: 0x6374D0
        public void set_Target(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC1EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1FB0 | overloaded x2
    }

    public class DNAMERecord
    {
        public MeaMod.DNS.Model.DomainName <Target>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC2010
        public void get_Target(){} // RVA: 0x6374D0
        public void set_Target(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC1EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1FB0 | overloaded x2
    }

    public class DNSKEYRecord
    {
        public 0x659ACB48 <Flags>k__BackingField; // 0x30
        public byte <Protocol>k__BackingField; // 0x32
        public 0x659ADFE8 <Algorithm>k__BackingField; // 0x33
        public byte[] <PublicKey>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC2100 | overloaded x2
        public void get_Flags(){} // RVA: 0x3BE7880
        public void set_Flags(){} // RVA: 0x5AC1AF0
        public void get_Protocol(){} // RVA: 0x3BE7520
        public void set_Protocol(){} // RVA: 0x5AC2490
        public void get_Algorithm(){} // RVA: 0x5AC24A0
        public void set_Algorithm(){} // RVA: 0x5AC24B0
        public void get_PublicKey(){} // RVA: 0x4976A0
        public void set_PublicKey(){} // RVA: 0x49B830
        public void KeyTag(){} // RVA: 0x5AC24C0
        public void ReadData(){} // RVA: 0x5AC2720 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC27D0 | overloaded x2
    }

    public class DSRecord
    {
        public ushort <KeyTag>k__BackingField; // 0x30
        public 0x659ADFE8 <Algorithm>k__BackingField; // 0x32
        public 0x659ACA98 <HashAlgorithm>k__BackingField; // 0x33
        public byte[] <Digest>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC2940 | overloaded x2
        public void get_KeyTag(){} // RVA: 0x3BE7880
        public void set_KeyTag(){} // RVA: 0x5AC1AF0
        public void get_Algorithm(){} // RVA: 0x3BE7520
        public void set_Algorithm(){} // RVA: 0x5AC2490
        public void get_HashAlgorithm(){} // RVA: 0x5AC24A0
        public void set_HashAlgorithm(){} // RVA: 0x5AC24B0
        public void get_Digest(){} // RVA: 0x4976A0
        public void set_Digest(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC2E50 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC2FA0 | overloaded x2
    }

    public class DigestRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5AB7910
        public void Create(){} // RVA: 0x5AB7DD0 | overloaded x2
    }

    public class DnsObject
    {
        public System.DateTime <CreationTime>k__BackingField; // 0x10

        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0x2F8380
        public void set_CreationTime(){} // RVA: 0x1967700
        public void Length(){} // RVA: 0x5AB8260
        public void Clone(){} // RVA: 0x283FA0 | overloaded x2
        public void Read(){} // RVA: 0xCE10 | overloaded x4
        public void ToByteArray(){} // RVA: 0x5AB8720
        public void Write(){} // RVA: 0x24B10 | overloaded x2
        public void .ctor(){} // RVA: 0x5AB88B0
    }

    public class DomainName
    {
        public string dot;

        // ── Methods ──
        public void get_Labels(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x5AB89D0 | overloaded x2
        public void Join(){} // RVA: 0x5AB8AE0
        public void ToString(){} // RVA: 0x5AB8BE0
        public void EscapeLabel(){} // RVA: 0x5AB8CB0
        public void ToCanonical(){} // RVA: 0x5AB8F20
        public void BelongsTo(){} // RVA: 0x5AB9140
        public void IsSubdomainOf(){} // RVA: 0x5AB91D0
        public void Parent(){} // RVA: 0x5AB9350
        public void Parse(){} // RVA: 0x5AB94A0
        public void GetHashCode(){} // RVA: 0x5AB97B0
        public void Equals(){} // RVA: 0x5AB98C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x5AB9A20
        public void op_Inequality(){} // RVA: 0x5AB9A40
        public void op_Implicit(){} // RVA: 0x5AB9AD0
        public void LabelsEqual(){} // RVA: 0x5AB9B30
        public void .cctor(){} // RVA: 0x5AB9C00
    }

    public class EdnsDAUOption
    {
        public System.Collections.Generic.List`1<0x659ADFE8> <Algorithms>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AB9DA0
        public void get_Algorithms(){} // RVA: 0x2E07C0
        public void set_Algorithms(){} // RVA: 0x343E80
        public void Create(){} // RVA: 0x5AB9E60
        public void ReadData(){} // RVA: 0x5AB9FF0
        public void WriteData(){} // RVA: 0x5ABA150
        public void ToString(){} // RVA: 0x5ABA350
    }

    public class EdnsDHUOption
    {
        public System.Collections.Generic.List`1<0x659ACA98> <Algorithms>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ABA440
        public void get_Algorithms(){} // RVA: 0x2E07C0
        public void set_Algorithms(){} // RVA: 0x343E80
        public void Create(){} // RVA: 0x5ABA500
        public void ReadData(){} // RVA: 0x5ABA690
        public void WriteData(){} // RVA: 0x5ABA7F0
        public void ToString(){} // RVA: 0x5ABA9F0
    }

    public class EdnsKeepaliveOption
    {
        public System.Nullable`1<System.TimeSpan> <Timeout>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ABAA60
        public void get_Timeout(){} // RVA: 0x994EE0
        public void set_Timeout(){} // RVA: 0x9949A0
        public void ReadData(){} // RVA: 0x5ABAA70
        public void WriteData(){} // RVA: 0x5ABABD0
        public void ToString(){} // RVA: 0x5ABACC0
    }

    public class EdnsN3UOption
    {
        public System.Collections.Generic.List`1<0x659ACA98> <Algorithms>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ABAD70
        public void get_Algorithms(){} // RVA: 0x2E07C0
        public void set_Algorithms(){} // RVA: 0x343E80
        public void Create(){} // RVA: 0x5ABAE30
        public void ReadData(){} // RVA: 0x5ABAFC0
        public void WriteData(){} // RVA: 0x5ABB120
        public void ToString(){} // RVA: 0x5ABB320
    }

    public class EdnsNSIDOption
    {
        public byte[] <Id>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ABB390
        public void get_Id(){} // RVA: 0x2E07C0
        public void set_Id(){} // RVA: 0x343E80
        public void ReadData(){} // RVA: 0x5ABB3A0
        public void WriteData(){} // RVA: 0x5ABB420
    }

    public class EdnsOption
    {
        public 0x659AD018 <Type>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x1C0F720
        public void set_Type(){} // RVA: 0x1C0FA70
        public void ReadData(){} // RVA: 0x2BAA0
        public void WriteData(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EdnsOptionRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5ABB480
        public void Register(){} // RVA: 0x24A80
    }

    public class EdnsPaddingOption
    {
        public byte[] <Padding>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ABB600
        public void get_Padding(){} // RVA: 0x2E07C0
        public void set_Padding(){} // RVA: 0x343E80
        public void ReadData(){} // RVA: 0x5ABB3A0
        public void WriteData(){} // RVA: 0x5ABB420
        public void ToString(){} // RVA: 0x5ABB610
    }

    public class HINFORecord
    {
        public string <Cpu>k__BackingField; // 0x30
        public string <OS>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC30F0
        public void get_Cpu(){} // RVA: 0x6374D0
        public void set_Cpu(){} // RVA: 0x30B890
        public void get_OS(){} // RVA: 0x4976A0
        public void set_OS(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC3250 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC33A0 | overloaded x2
    }

    public class IPAddressExtensions
    {
        // ── Methods ──
        public void GetArpaName(){} // RVA: 0x5ABB710
    }

    public class IPresentationSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0xCE10
        public void Write(){} // RVA: 0x24B10
    }

    public class IResolver
    {
        // ── Methods ──
        public void ResolveAsync(){}
    }

    public class IWireSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0xCE10
        public void Write(){} // RVA: 0x24B10
    }

    public class MXRecord
    {
        public ushort <Preference>k__BackingField; // 0x30
        public MeaMod.DNS.Model.DomainName <Exchange>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC33F0
        public void get_Preference(){} // RVA: 0x3BE7880
        public void set_Preference(){} // RVA: 0x5AC1AF0
        public void get_Exchange(){} // RVA: 0x4976A0
        public void set_Exchange(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC1BC0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1CF0 | overloaded x2
    }

    public class Message
    {
        public byte opcode4; // 0x18
        public int MaxLength;
        public int MinLength;
        public ushort <Id>k__BackingField; // 0x1A
        public bool <QR>k__BackingField; // 0x1C
        public bool <AA>k__BackingField; // 0x1D
        public bool <TC>k__BackingField; // 0x1E
        public bool <RD>k__BackingField; // 0x1F
        public bool <RA>k__BackingField; // 0x20
        public int <Z>k__BackingField; // 0x24
        public bool <AD>k__BackingField; // 0x28
        public bool <CD>k__BackingField; // 0x29
        public 0x659AD330 <Status>k__BackingField; // 0x2A
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.Question> <Questions>k__BackingField; // 0x30
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> <Answers>k__BackingField; // 0x38
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> <AuthorityRecords>k__BackingField; // 0x40
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> <AdditionalRecords>k__BackingField; // 0x48

        // ── Methods ──
        public void get_Id(){} // RVA: 0x2892CA0
        public void set_Id(){} // RVA: 0x5ABBFD0
        public void get_QR(){} // RVA: 0x2F8390
        public void set_QR(){} // RVA: 0x2F83A0
        public void get_IsQuery(){} // RVA: 0x5ABBFE0
        public void get_IsResponse(){} // RVA: 0x2F8390
        public void get_Opcode(){} // RVA: 0x5ABBFF0
        public void set_Opcode(){} // RVA: 0x5ABC100
        public void get_AA(){} // RVA: 0x1B98300
        public void set_AA(){} // RVA: 0x1B982F0
        public void get_TC(){} // RVA: 0x1B98CC0
        public void set_TC(){} // RVA: 0x1B98330
        public void get_RD(){} // RVA: 0x1B98310
        public void set_RD(){} // RVA: 0x1B98320
        public void get_RA(){} // RVA: 0x3CB9D0
        public void set_RA(){} // RVA: 0x3CB9E0
        public void get_Z(){} // RVA: 0xCEF5B0
        public void set_Z(){} // RVA: 0x16E1F00
        public void get_AD(){} // RVA: 0x6E8A80
        public void set_AD(){} // RVA: 0x6E8B80
        public void get_CD(){} // RVA: 0xC36000
        public void set_CD(){} // RVA: 0x190AB20
        public void get_DO(){} // RVA: 0x5ABC260
        public void set_DO(){} // RVA: 0x5ABC320
        public void get_Status(){} // RVA: 0x205EA40
        public void set_Status(){} // RVA: 0x205EA30
        public void get_Questions(){} // RVA: 0x6374D0
        public void get_Answers(){} // RVA: 0x4976A0
        public void set_Answers(){} // RVA: 0x49B830
        public void get_AuthorityRecords(){} // RVA: 0x35A740
        public void set_AuthorityRecords(){} // RVA: 0x305200
        public void get_AdditionalRecords(){} // RVA: 0x358730
        public void set_AdditionalRecords(){} // RVA: 0x358740
        public void CreateResponse(){} // RVA: 0x5ABC4C0
        public void Truncate(){} // RVA: 0x5ABC590
        public void UseDnsSecurity(){} // RVA: 0x5ABC6F0
        public void Read(){} // RVA: 0x5ABC710
        public void Write(){} // RVA: 0x5ABCD10
        public void ToString(){} // RVA: 0x5ABD500
        public void Stringify(){} // RVA: 0x5ABDBC0
        public void .ctor(){} // RVA: 0x5ABDE00
    }

    public class NSEC3PARAMRecord
    {
        public 0x659ACA98 <HashAlgorithm>k__BackingField; // 0x30
        public byte <Flags>k__BackingField; // 0x31
        public ushort <Iterations>k__BackingField; // 0x32
        public byte[] <Salt>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC3450
        public void get_HashAlgorithm(){} // RVA: 0x303450
        public void set_HashAlgorithm(){} // RVA: 0x303460
        public void get_Flags(){} // RVA: 0x303470
        public void set_Flags(){} // RVA: 0x303480
        public void get_Iterations(){} // RVA: 0x5AC34B0
        public void set_Iterations(){} // RVA: 0x5AC34C0
        public void get_Salt(){} // RVA: 0x4976A0
        public void set_Salt(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC3690 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC37B0 | overloaded x2
    }

    public class NSEC3Record
    {
        public 0x659ACA98 <HashAlgorithm>k__BackingField; // 0x30
        public 0x659AD388 <Flags>k__BackingField; // 0x31
        public ushort <Iterations>k__BackingField; // 0x32
        public byte[] <Salt>k__BackingField; // 0x38
        public byte[] <NextHashedOwnerName>k__BackingField; // 0x40
        public System.Collections.Generic.List`1<0x659ACBF8> <Types>k__BackingField; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC3920
        public void get_HashAlgorithm(){} // RVA: 0x303450
        public void set_HashAlgorithm(){} // RVA: 0x303460
        public void get_Flags(){} // RVA: 0x303470
        public void set_Flags(){} // RVA: 0x303480
        public void get_Iterations(){} // RVA: 0x5AC34B0
        public void set_Iterations(){} // RVA: 0x5AC34C0
        public void get_Salt(){} // RVA: 0x4976A0
        public void set_Salt(){} // RVA: 0x49B830
        public void get_NextHashedOwnerName(){} // RVA: 0x35A740
        public void set_NextHashedOwnerName(){} // RVA: 0x305200
        public void get_Types(){} // RVA: 0x358730
        public void set_Types(){} // RVA: 0x358740
        public void ReadData(){} // RVA: 0x5AC3F50 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC42E0 | overloaded x2
    }

    public class NSECRecord
    {
        public MeaMod.DNS.Model.DomainName <NextOwnerName>k__BackingField; // 0x30
        public System.Collections.Generic.List`1<0x659ACBF8> <Types>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC4750
        public void get_NextOwnerName(){} // RVA: 0x6374D0
        public void set_NextOwnerName(){} // RVA: 0x30B890
        public void get_Types(){} // RVA: 0x4976A0
        public void set_Types(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC4C90 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC4DC0 | overloaded x2
    }

    public class NSRecord
    {
        public MeaMod.DNS.Model.DomainName <Authority>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC50F0
        public void get_Authority(){} // RVA: 0x6374D0
        public void set_Authority(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC1EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1FB0 | overloaded x2
    }

    public class NULLRecord
    {
        public byte[] <Data>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC5150
        public void get_Data(){} // RVA: 0x6374D0
        public void set_Data(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC5230 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC52A0
    }

    public class OPTRecord
    {
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.EdnsOption> <Options>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC5300
        public void get_RequestorPayloadSize(){} // RVA: 0x5AC0F30
        public void set_RequestorPayloadSize(){} // RVA: 0x5AC0F40
        public void get_Opcode8(){} // RVA: 0x5AC54D0
        public void set_Opcode8(){} // RVA: 0x5AC5540
        public void get_Version(){} // RVA: 0x5AC55E0
        public void set_Version(){} // RVA: 0x5AC5650
        public void get_DO(){} // RVA: 0x5AC56F0
        public void set_DO(){} // RVA: 0x5AC5750
        public void get_Options(){} // RVA: 0x6374D0
        public void set_Options(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC5810
        public void WriteData(){} // RVA: 0x5AC59D0
        public void ToString(){} // RVA: 0x5AC5BE0
    }

    public class PTRRecord
    {
        public MeaMod.DNS.Model.DomainName <DomainName>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC5F10
        public void get_DomainName(){} // RVA: 0x6374D0
        public void set_DomainName(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC1EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC1FB0 | overloaded x2
    }

    public class PresentationReader
    {
        public System.DateTime UnixEpoch;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ABE080
        public void get_Origin(){} // RVA: 0x35A740
        public void set_Origin(){} // RVA: 0x305200
        public void ReadByte(){} // RVA: 0x5ABE1A0
        public void ReadUInt16(){} // RVA: 0x5ABE2C0
        public void ReadUInt32(){} // RVA: 0x5ABE3E0
        public void ReadDomainName(){} // RVA: 0x5ABE490
        public void MakeAbsoluteDomainName(){} // RVA: 0x5ABE4C0
        public void ReadString(){} // RVA: 0x5ABE670
        public void ReadBase64String(){} // RVA: 0x5ABE680
        public void ReadTimeSpan16(){} // RVA: 0x5ABE810
        public void ReadTimeSpan32(){} // RVA: 0x5ABE8C0
        public void ReadIPAddress(){} // RVA: 0x5ABE970
        public void ReadDnsType(){} // RVA: 0x5ABEA70
        public void ReadDateTime(){} // RVA: 0x5ABEC70
        public void ReadResourceData(){} // RVA: 0x5ABEE50
        public void ReadResourceRecord(){} // RVA: 0x5ABF1A0
        public void IsEndOfLine(){} // RVA: 0x5ABF930
        public void ReadToken(){} // RVA: 0x5ABFA90
        public void .cctor(){} // RVA: 0x5ABFE60
    }

    public class PresentationWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void WriteSpace(){} // RVA: 0x5ABFFD0
        public void WriteEndOfLine(){} // RVA: 0x5AC0000
        public void WriteByte(){} // RVA: 0x5AC0060
        public void WriteUInt16(){} // RVA: 0x5AC00D0
        public void WriteUInt32(){} // RVA: 0x5AC0140
        public void WriteString(){} // RVA: 0x5AC01B0
        public void WriteStringUnencoded(){} // RVA: 0x5AC03B0
        public void WriteDomainName(){} // RVA: 0x5AC0420
        public void WriteBase16String(){} // RVA: 0x5AC04B0
        public void WriteBase64String(){} // RVA: 0x5AC0520
        public void WriteTimeSpan16(){} // RVA: 0x5AC0660
        public void WriteTimeSpan32(){} // RVA: 0x5AC0730
        public void WriteDateTime(){} // RVA: 0x5AC0800
        public void WriteIPAddress(){} // RVA: 0x5AC0960
        public void WriteDnsType(){} // RVA: 0x5AC09C0
        public void WriteDnsClass(){} // RVA: 0x5AC0C30
        public void .cctor(){} // RVA: 0x5AC0EA0
    }

    public class Question
    {
        public MeaMod.DNS.Model.DomainName <Name>k__BackingField; // 0x18
        public 0x659ACBF8 <Type>k__BackingField; // 0x20
        public 0x659ACAF0 <Class>k__BackingField; // 0x22

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x343E80
        public void get_Type(){} // RVA: 0x44B4370
        public void set_Type(){} // RVA: 0x5AC0F20
        public void get_Class(){} // RVA: 0x5AC0F30
        public void set_Class(){} // RVA: 0x5AC0F40
        public void Read(){} // RVA: 0x5AC0F50
        public void Write(){} // RVA: 0x5AC1030
        public void ToString(){} // RVA: 0x5AC1110
        public void .ctor(){} // RVA: 0x5AC1330
    }

    public class RPRecord
    {
        public MeaMod.DNS.Model.DomainName <Mailbox>k__BackingField; // 0x30
        public MeaMod.DNS.Model.DomainName <TextName>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC5F70
        public void get_Mailbox(){} // RVA: 0x6374D0
        public void set_Mailbox(){} // RVA: 0x30B890
        public void get_TextName(){} // RVA: 0x4976A0
        public void set_TextName(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC61B0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC6310 | overloaded x2
    }

    public class RRSIGRecord
    {
        public 0x659ACBF8 <TypeCovered>k__BackingField; // 0x30
        public 0x659ADFE8 <Algorithm>k__BackingField; // 0x32
        public byte <Labels>k__BackingField; // 0x33
        public System.TimeSpan <OriginalTTL>k__BackingField; // 0x38
        public System.DateTime <SignatureExpiration>k__BackingField; // 0x40
        public System.DateTime <SignatureInception>k__BackingField; // 0x48
        public ushort <KeyTag>k__BackingField; // 0x50
        public MeaMod.DNS.Model.DomainName <SignerName>k__BackingField; // 0x58
        public byte[] <Signature>k__BackingField; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC63E0
        public void get_TypeCovered(){} // RVA: 0x3BE7880
        public void set_TypeCovered(){} // RVA: 0x5AC1AF0
        public void get_Algorithm(){} // RVA: 0x3BE7520
        public void set_Algorithm(){} // RVA: 0x5AC2490
        public void get_Labels(){} // RVA: 0x5AC24A0
        public void set_Labels(){} // RVA: 0x5AC24B0
        public void get_OriginalTTL(){} // RVA: 0x4976A0
        public void set_OriginalTTL(){} // RVA: 0xF501D0
        public void get_SignatureExpiration(){} // RVA: 0x35A740
        public void set_SignatureExpiration(){} // RVA: 0x36B37A0
        public void get_SignatureInception(){} // RVA: 0x358730
        public void set_SignatureInception(){} // RVA: 0x179D760
        public void get_KeyTag(){} // RVA: 0x41E3C10
        public void set_KeyTag(){} // RVA: 0x5AC6440
        public void get_SignerName(){} // RVA: 0x3A5500
        public void set_SignerName(){} // RVA: 0x3A5510
        public void get_Signature(){} // RVA: 0x37B370
        public void set_Signature(){} // RVA: 0x37B380
        public void ReadData(){} // RVA: 0x5AC6790 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC6900 | overloaded x2
    }

    public class ResourceRecord
    {
        public System.TimeSpan DefaultTTL;
        public System.TimeSpan DefaultHostTTL; // 0x8
        public MeaMod.DNS.Model.DomainName <Name>k__BackingField; // 0x18
        public 0x659ACBF8 <Type>k__BackingField; // 0x20
        public 0x659ACAF0 <Class>k__BackingField; // 0x22

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x343E80
        public void get_CanonicalName(){} // RVA: 0x5AC9870
        public void get_Type(){} // RVA: 0x44B4370
        public void set_Type(){} // RVA: 0x5AC0F20
        public void get_Class(){} // RVA: 0x5AC0F30
        public void set_Class(){} // RVA: 0x5AC0F40
        public void get_TTL(){} // RVA: 0x30B130
        public void set_TTL(){} // RVA: 0x8AC650
        public void IsExpired(){} // RVA: 0x5AC98B0
        public void GetDataLength(){} // RVA: 0x5AC9990
        public void GetData(){} // RVA: 0x5AC9AE0
        public void Read(){} // RVA: 0x5ACAA00 | overloaded x3
        public void ReadData(){} // RVA: 0x2DD310 | overloaded x2
        public void Write(){} // RVA: 0x5ACA650 | overloaded x2
        public void WriteData(){} // RVA: 0x5ACA810 | overloaded x2
        public void Equals(){} // RVA: 0x5AC9FC0
        public void op_Equality(){} // RVA: 0x5ACA140
        public void op_Inequality(){} // RVA: 0x5ACA170
        public void GetHashCode(){} // RVA: 0x5ACA1B0
        public void ToString(){} // RVA: 0x5ACA430
        public void .ctor(){} // RVA: 0x5ACAA20
        public void .cctor(){} // RVA: 0x5ACAAD0
    }

    public class ResourceRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5ACAC90
        public void Register(){} // RVA: 0x24A80
        public void Create(){} // RVA: 0x5ACB000
    }

    public class SOARecord
    {
        public MeaMod.DNS.Model.DomainName <PrimaryName>k__BackingField; // 0x30
        public MeaMod.DNS.Model.DomainName <Mailbox>k__BackingField; // 0x38
        public uint <SerialNumber>k__BackingField; // 0x40
        public System.TimeSpan <Refresh>k__BackingField; // 0x48
        public System.TimeSpan <Retry>k__BackingField; // 0x50
        public System.TimeSpan <Expire>k__BackingField; // 0x58
        public System.TimeSpan <Minimum>k__BackingField; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC6AC0
        public void get_PrimaryName(){} // RVA: 0x6374D0
        public void set_PrimaryName(){} // RVA: 0x30B890
        public void get_Mailbox(){} // RVA: 0x4976A0
        public void set_Mailbox(){} // RVA: 0x49B830
        public void get_SerialNumber(){} // RVA: 0x37E080
        public void set_SerialNumber(){} // RVA: 0x37E090
        public void get_Refresh(){} // RVA: 0x358730
        public void set_Refresh(){} // RVA: 0x179D760
        public void get_Retry(){} // RVA: 0x37E0E0
        public void set_Retry(){} // RVA: 0x4C4D50
        public void get_Expire(){} // RVA: 0x3A5500
        public void set_Expire(){} // RVA: 0x4C34E0
        public void get_Minimum(){} // RVA: 0x37B370
        public void set_Minimum(){} // RVA: 0x5AC6B90
        public void ReadData(){} // RVA: 0x5AC6CE0 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC6EE0 | overloaded x2
    }

    public class SRVRecord
    {
        public ushort <Priority>k__BackingField; // 0x30
        public ushort <Weight>k__BackingField; // 0x32
        public ushort <Port>k__BackingField; // 0x34
        public MeaMod.DNS.Model.DomainName <Target>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC70E0
        public void get_Priority(){} // RVA: 0x3BE7880
        public void set_Priority(){} // RVA: 0x5AC1AF0
        public void get_Weight(){} // RVA: 0x5AC34B0
        public void set_Weight(){} // RVA: 0x5AC34C0
        public void get_Port(){} // RVA: 0x5AC7140
        public void set_Port(){} // RVA: 0x5AC7150
        public void get_Target(){} // RVA: 0x4976A0
        public void set_Target(){} // RVA: 0x49B830
        public void ReadData(){} // RVA: 0x5AC7260 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC7460 | overloaded x2
    }

    public class SecurityAlgorithmRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5ACB120
        public void GetMetadata(){} // RVA: 0x5ACB730
    }

    public class TKEYRecord
    {
        public byte[] NoData;
        public MeaMod.DNS.Model.DomainName <Algorithm>k__BackingField; // 0x30
        public System.DateTime <Inception>k__BackingField; // 0x38
        public System.DateTime <Expiration>k__BackingField; // 0x40
        public 0x659AD228 <Mode>k__BackingField; // 0x48
        public 0x659AD330 <Error>k__BackingField; // 0x4A
        public byte[] <Key>k__BackingField; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC75A0
        public void get_Algorithm(){} // RVA: 0x6374D0
        public void set_Algorithm(){} // RVA: 0x30B890
        public void get_Inception(){} // RVA: 0x4976A0
        public void set_Inception(){} // RVA: 0xF501D0
        public void get_Expiration(){} // RVA: 0x35A740
        public void set_Expiration(){} // RVA: 0x36B37A0
        public void get_Mode(){} // RVA: 0x5AC76F0
        public void set_Mode(){} // RVA: 0x5AC7700
        public void get_Error(){} // RVA: 0x16DF2D0
        public void set_Error(){} // RVA: 0x16DE990
        public void get_Key(){} // RVA: 0x37E0E0
        public void set_Key(){} // RVA: 0x4354D0
        public void get_OtherData(){} // RVA: 0x3A5500
        public void set_OtherData(){} // RVA: 0x3A5510
        public void ReadData(){} // RVA: 0x5AC7A40 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC7D70 | overloaded x2
        public void .cctor(){} // RVA: 0x5AC7F30
    }

    public class TSIGRecord
    {
        public byte[] NoData;
        public string HMACMD5;
        public string GSSTSIG;
        public string HMACSHA1;
        public string HMACSHA224;
        public string HMACSHA256;
        public string HMACSHA384;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC7FE0
        public void get_Algorithm(){} // RVA: 0x6374D0
        public void set_Algorithm(){} // RVA: 0x30B890
        public void get_TimeSigned(){} // RVA: 0x4976A0
        public void set_TimeSigned(){} // RVA: 0xF501D0
        public void get_MAC(){} // RVA: 0x35A740
        public void set_MAC(){} // RVA: 0x305200
        public void get_Fudge(){} // RVA: 0x358730
        public void set_Fudge(){} // RVA: 0x179D760
        public void get_OriginalMessageId(){} // RVA: 0x41E3C10
        public void set_OriginalMessageId(){} // RVA: 0x5AC6440
        public void get_Error(){} // RVA: 0x1BE5300
        public void set_Error(){} // RVA: 0x1BE2180
        public void get_OtherData(){} // RVA: 0x3A5500
        public void set_OtherData(){} // RVA: 0x3A5510
        public void ReadData(){} // RVA: 0x5AC8B70 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC8F30 | overloaded x2
        public void .cctor(){} // RVA: 0x5AC9180
    }

    public class TXTRecord
    {
        public System.Collections.Generic.List`1<string> <Strings>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AC9230
        public void get_Strings(){} // RVA: 0x6374D0
        public void set_Strings(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC9440 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC9670 | overloaded x2
    }

    public class UnknownEdnsOption
    {
        public byte[] <Data>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2E07C0
        public void set_Data(){} // RVA: 0x343E80
        public void ReadData(){} // RVA: 0x5ABB3A0
        public void WriteData(){} // RVA: 0x5ABB420
        public void ToString(){} // RVA: 0x5ACB8E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnknownRecord
    {
        public byte[] <Data>k__BackingField; // 0x30

        // ── Methods ──
        public void get_Data(){} // RVA: 0x6374D0
        public void set_Data(){} // RVA: 0x30B890
        public void ReadData(){} // RVA: 0x5AC5230 | overloaded x2
        public void WriteData(){} // RVA: 0x5AC52A0
        public void .ctor(){} // RVA: 0x5AC9820
    }

    public class UpdateMessage
    {
        public ushort <Id>k__BackingField; // 0x18
        public bool <QR>k__BackingField; // 0x1A
        public 0x659AD2D8 <Opcode>k__BackingField; // 0x1C
        public int <Z>k__BackingField; // 0x20
        public 0x659AD330 <Status>k__BackingField; // 0x24
        public MeaMod.DNS.Model.Question <Zone>k__BackingField; // 0x28
        public MeaMod.DNS.Model.UpdatePrerequisiteList <Prerequisites>k__BackingField; // 0x30
        public MeaMod.DNS.Model.UpdateResourceList <Updates>k__BackingField; // 0x38
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> <AdditionalResources>k__BackingField; // 0x40

        // ── Methods ──
        public void get_Id(){} // RVA: 0x2892C90
        public void set_Id(){} // RVA: 0x4470200
        public void get_QR(){} // RVA: 0x1B98340
        public void set_QR(){} // RVA: 0x1B98210
        public void get_IsUpdate(){} // RVA: 0x5ACBA90
        public void get_IsResponse(){} // RVA: 0x1B98340
        public void get_Opcode(){} // RVA: 0x5ACBAA0
        public void set_Opcode(){} // RVA: 0x5ACBAB0
        public void get_Z(){} // RVA: 0x760030
        public void set_Z(){} // RVA: 0x99E0D0
        public void get_Status(){} // RVA: 0x2F87C0
        public void set_Status(){} // RVA: 0x4D7670
        public void get_Zone(){} // RVA: 0x30B130
        public void set_Zone(){} // RVA: 0x2DEE90
        public void get_Prerequisites(){} // RVA: 0x6374D0
        public void get_Updates(){} // RVA: 0x4976A0
        public void get_AdditionalResources(){} // RVA: 0x35A740
        public void CreateResponse(){} // RVA: 0x5ACBAC0
        public void Read(){} // RVA: 0x5ACBB40
        public void Write(){} // RVA: 0x5ACC0E0
        public void .ctor(){} // RVA: 0x5ACC710
    }

    public class UpdatePrerequisiteList
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x5ACCBC0 | overloaded x4
        public void MustNotExist(){} // RVA: 0xCE10 | overloaded x3
        public void .ctor(){} // RVA: 0x5ACCDB0
    }

    public class UpdateResourceList
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x5ACCE20
        public void DeleteResource(){} // RVA: 0xCE10 | overloaded x4
        public void .ctor(){} // RVA: 0x5ACD170
    }

    public class WireReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ACD1E0
        public void ReadByte(){} // RVA: 0x5ACD300
        public void ReadBytes(){} // RVA: 0x5ACD380
        public void ReadByteLengthPrefixedBytes(){} // RVA: 0x5ACD470
        public void ReadUInt16LengthPrefixedBytes(){} // RVA: 0x5ACD4A0
        public void ReadUInt16(){} // RVA: 0x5ACD4E0
        public void ReadUInt32(){} // RVA: 0x5ACD520
        public void ReadUInt48(){} // RVA: 0x5ACD590
        public void ReadDomainName(){} // RVA: 0x5ACD640
        public void ReadLabels(){} // RVA: 0x5ACD6E0
        public void ReadString(){} // RVA: 0x5ACD900
        public void ReadTimeSpan16(){} // RVA: 0x5ACDBC0
        public void ReadTimeSpan32(){} // RVA: 0x5ACDC90
        public void ReadIPAddress(){} // RVA: 0x5ACDD40
        public void ReadBitmap(){} // RVA: 0x5ACDE20
        public void ReadDateTime32(){} // RVA: 0x5ACDF70
        public void ReadDateTime48(){} // RVA: 0x5ACE060
        public void .cctor(){} // RVA: 0x5ACE200
    }

    public class WireWriter
    {
        public int System.Collections.Generic.IEnumerator<System.Byte>.Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ACE330
        public void get_CanonicalForm(){} // RVA: 0x3BC230
        public void set_CanonicalForm(){} // RVA: 0x3BC240
        public void PushLengthPrefixedScope(){} // RVA: 0x5ACE500
        public void PopLengthPrefixedScope(){} // RVA: 0x5ACE5E0
        public void WriteByte(){} // RVA: 0x5ACE750
        public void WriteBytes(){} // RVA: 0x5ACE790
        public void WriteByteLengthPrefixedBytes(){} // RVA: 0x5ACE7F0
        public void WriteUint16LengthPrefixedBytes(){} // RVA: 0x5ACE910
        public void WriteUInt16(){} // RVA: 0x5ACEA10
        public void WriteUInt32(){} // RVA: 0x5ACEA80
        public void WriteUInt48(){} // RVA: 0x5ACEB30
        public void WriteDomainName(){} // RVA: 0x5ACED70 | overloaded x2
        public void WriteString(){} // RVA: 0x5ACF140
        public void WriteTimeSpan16(){} // RVA: 0x5ACF340
        public void WriteTimeSpan32(){} // RVA: 0x5ACF400
        public void WriteDateTime32(){} // RVA: 0x5ACF480
        public void WriteDateTime48(){} // RVA: 0x5ACF5B0
        public void WriteIPAddress(){} // RVA: 0x5ACF6E0
        public void WriteBitmap(){} // RVA: 0x5ACF750
        public void ToBytes(){} // RVA: 0x5AD0080
        public void .cctor(){} // RVA: 0x5AD0140
    }

}