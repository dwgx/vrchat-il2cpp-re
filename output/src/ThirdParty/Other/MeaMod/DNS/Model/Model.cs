// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 53
// Methods: 560

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class AAAARecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8571390
    }

    public class AFSDBRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8571A90
        public void get_Subtype(){} // RVA: 0x7FFAF6697880
        public void set_Subtype(){} // RVA: 0x7FFAF8571AF0
        public void get_Target(){} // RVA: 0x7FFAF2F476A0
        public void set_Target(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8571BC0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571CF0 | overloaded x2
    }

    public class ARecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8571DA0
    }

    public class AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8571400
        public void get_Address(){} // RVA: 0x7FFAF30E74D0
        public void set_Address(){} // RVA: 0x7FFAF2DBB890
        public void Create(){} // RVA: 0x7FFAF8571470
        public void ReadData(){} // RVA: 0x7FFAF8571870 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571A40 | overloaded x2
    }

    public class CNAMERecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8571E10
        public void get_Target(){} // RVA: 0x7FFAF30E74D0
        public void set_Target(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8571EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571FB0 | overloaded x2
    }

    public class DNAMERecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8572010
        public void get_Target(){} // RVA: 0x7FFAF30E74D0
        public void set_Target(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8571EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571FB0 | overloaded x2
    }

    public class DNSKEYRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8572100 | overloaded x2
        public void get_Flags(){} // RVA: 0x7FFAF6697880
        public void set_Flags(){} // RVA: 0x7FFAF8571AF0
        public void get_Protocol(){} // RVA: 0x7FFAF6697520
        public void set_Protocol(){} // RVA: 0x7FFAF8572490
        public void get_Algorithm(){} // RVA: 0x7FFAF85724A0
        public void set_Algorithm(){} // RVA: 0x7FFAF85724B0
        public void get_PublicKey(){} // RVA: 0x7FFAF2F476A0
        public void set_PublicKey(){} // RVA: 0x7FFAF2F4B830
        public void KeyTag(){} // RVA: 0x7FFAF85724C0
        public void ReadData(){} // RVA: 0x7FFAF8572720 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF85727D0 | overloaded x2
    }

    public class DSRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8572940 | overloaded x2
        public void get_KeyTag(){} // RVA: 0x7FFAF6697880
        public void set_KeyTag(){} // RVA: 0x7FFAF8571AF0
        public void get_Algorithm(){} // RVA: 0x7FFAF6697520
        public void set_Algorithm(){} // RVA: 0x7FFAF8572490
        public void get_HashAlgorithm(){} // RVA: 0x7FFAF85724A0
        public void set_HashAlgorithm(){} // RVA: 0x7FFAF85724B0
        public void get_Digest(){} // RVA: 0x7FFAF2F476A0
        public void set_Digest(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8572E50 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8572FA0 | overloaded x2
    }

    public class DigestRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8567910
        public void Create(){} // RVA: 0x7FFAF8567DD0 | overloaded x2
    }

    public class DnsObject
    {
        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0x7FFAF2DA8380
        public void set_CreationTime(){} // RVA: 0x7FFAF4417700
        public void Length(){} // RVA: 0x7FFAF8568260
        public void Clone(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Read(){} // RVA: 0x7FFAF2ABCE10 | overloaded x4
        public void ToByteArray(){} // RVA: 0x7FFAF8568720
        public void Write(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF85688B0
    }

    public class DomainName
    {
        // ── Methods ──
        public void get_Labels(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF85689D0 | overloaded x2
        public void Join(){} // RVA: 0x7FFAF8568AE0
        public void ToString(){} // RVA: 0x7FFAF8568BE0
        public void EscapeLabel(){} // RVA: 0x7FFAF8568CB0
        public void ToCanonical(){} // RVA: 0x7FFAF8568F20
        public void BelongsTo(){} // RVA: 0x7FFAF8569140
        public void IsSubdomainOf(){} // RVA: 0x7FFAF85691D0
        public void Parent(){} // RVA: 0x7FFAF8569350
        public void Parse(){} // RVA: 0x7FFAF85694A0
        public void GetHashCode(){} // RVA: 0x7FFAF85697B0
        public void Equals(){} // RVA: 0x7FFAF85698C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF8569A20
        public void op_Inequality(){} // RVA: 0x7FFAF8569A40
        public void op_Implicit(){} // RVA: 0x7FFAF8569AD0
        public void LabelsEqual(){} // RVA: 0x7FFAF8569B30
        public void .cctor(){} // RVA: 0x7FFAF8569C00
    }

    public class EdnsDAUOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8569DA0
        public void get_Algorithms(){} // RVA: 0x7FFAF2D907C0
        public void set_Algorithms(){} // RVA: 0x7FFAF2DF3E80
        public void Create(){} // RVA: 0x7FFAF8569E60
        public void ReadData(){} // RVA: 0x7FFAF8569FF0
        public void WriteData(){} // RVA: 0x7FFAF856A150
        public void ToString(){} // RVA: 0x7FFAF856A350
    }

    public class EdnsDHUOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF856A440
        public void get_Algorithms(){} // RVA: 0x7FFAF2D907C0
        public void set_Algorithms(){} // RVA: 0x7FFAF2DF3E80
        public void Create(){} // RVA: 0x7FFAF856A500
        public void ReadData(){} // RVA: 0x7FFAF856A690
        public void WriteData(){} // RVA: 0x7FFAF856A7F0
        public void ToString(){} // RVA: 0x7FFAF856A9F0
    }

    public class EdnsKeepaliveOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF856AA60
        public void get_Timeout(){} // RVA: 0x7FFAF3444EE0
        public void set_Timeout(){} // RVA: 0x7FFAF34449A0
        public void ReadData(){} // RVA: 0x7FFAF856AA70
        public void WriteData(){} // RVA: 0x7FFAF856ABD0
        public void ToString(){} // RVA: 0x7FFAF856ACC0
    }

    public class EdnsN3UOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF856AD70
        public void get_Algorithms(){} // RVA: 0x7FFAF2D907C0
        public void set_Algorithms(){} // RVA: 0x7FFAF2DF3E80
        public void Create(){} // RVA: 0x7FFAF856AE30
        public void ReadData(){} // RVA: 0x7FFAF856AFC0
        public void WriteData(){} // RVA: 0x7FFAF856B120
        public void ToString(){} // RVA: 0x7FFAF856B320
    }

    public class EdnsNSIDOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF856B390
        public void get_Id(){} // RVA: 0x7FFAF2D907C0
        public void set_Id(){} // RVA: 0x7FFAF2DF3E80
        public void ReadData(){} // RVA: 0x7FFAF856B3A0
        public void WriteData(){} // RVA: 0x7FFAF856B420
    }

    public class EdnsOption
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF46BF720
        public void set_Type(){} // RVA: 0x7FFAF46BFA70
        public void ReadData(){} // RVA: 0x7FFAF2ADBAA0
        public void WriteData(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EdnsOptionRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF856B480
        public void Register(){} // RVA: 0x7FFAF2AD4A80
    }

    public class EdnsPaddingOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF856B600
        public void get_Padding(){} // RVA: 0x7FFAF2D907C0
        public void set_Padding(){} // RVA: 0x7FFAF2DF3E80
        public void ReadData(){} // RVA: 0x7FFAF856B3A0
        public void WriteData(){} // RVA: 0x7FFAF856B420
        public void ToString(){} // RVA: 0x7FFAF856B610
    }

    public class HINFORecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85730F0
        public void get_Cpu(){} // RVA: 0x7FFAF30E74D0
        public void set_Cpu(){} // RVA: 0x7FFAF2DBB890
        public void get_OS(){} // RVA: 0x7FFAF2F476A0
        public void set_OS(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8573250 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF85733A0 | overloaded x2
    }

    public class IPAddressExtensions
    {
        // ── Methods ──
        public void GetArpaName(){} // RVA: 0x7FFAF856B710
    }

    public class IPresentationSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAF2ABCE10
        public void Write(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IResolver
    {
        // ── Methods ──
        public void ResolveAsync(){}
    }

    public class IWireSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAF2ABCE10
        public void Write(){} // RVA: 0x7FFAF2AD4B10
    }

    public class MXRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85733F0
        public void get_Preference(){} // RVA: 0x7FFAF6697880
        public void set_Preference(){} // RVA: 0x7FFAF8571AF0
        public void get_Exchange(){} // RVA: 0x7FFAF2F476A0
        public void set_Exchange(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8571BC0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571CF0 | overloaded x2
    }

    public class Message
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF5342CA0
        public void set_Id(){} // RVA: 0x7FFAF856BFD0
        public void get_QR(){} // RVA: 0x7FFAF2DA8390
        public void set_QR(){} // RVA: 0x7FFAF2DA83A0
        public void get_IsQuery(){} // RVA: 0x7FFAF856BFE0
        public void get_IsResponse(){} // RVA: 0x7FFAF2DA8390
        public void get_Opcode(){} // RVA: 0x7FFAF856BFF0
        public void set_Opcode(){} // RVA: 0x7FFAF856C100
        public void get_AA(){} // RVA: 0x7FFAF4648300
        public void set_AA(){} // RVA: 0x7FFAF46482F0
        public void get_TC(){} // RVA: 0x7FFAF4648CC0
        public void set_TC(){} // RVA: 0x7FFAF4648330
        public void get_RD(){} // RVA: 0x7FFAF4648310
        public void set_RD(){} // RVA: 0x7FFAF4648320
        public void get_RA(){} // RVA: 0x7FFAF2E7B9D0
        public void set_RA(){} // RVA: 0x7FFAF2E7B9E0
        public void get_Z(){} // RVA: 0x7FFAF379F5B0
        public void set_Z(){} // RVA: 0x7FFAF4191F00
        public void get_AD(){} // RVA: 0x7FFAF3198A80
        public void set_AD(){} // RVA: 0x7FFAF3198B80
        public void get_CD(){} // RVA: 0x7FFAF36E6000
        public void set_CD(){} // RVA: 0x7FFAF43BAB20
        public void get_DO(){} // RVA: 0x7FFAF856C260
        public void set_DO(){} // RVA: 0x7FFAF856C320
        public void get_Status(){} // RVA: 0x7FFAF4B0EA40
        public void set_Status(){} // RVA: 0x7FFAF4B0EA30
        public void get_Questions(){} // RVA: 0x7FFAF30E74D0
        public void get_Answers(){} // RVA: 0x7FFAF2F476A0
        public void set_Answers(){} // RVA: 0x7FFAF2F4B830
        public void get_AuthorityRecords(){} // RVA: 0x7FFAF2E0A740
        public void set_AuthorityRecords(){} // RVA: 0x7FFAF2DB5200
        public void get_AdditionalRecords(){} // RVA: 0x7FFAF2E08730
        public void set_AdditionalRecords(){} // RVA: 0x7FFAF2E08740
        public void CreateResponse(){} // RVA: 0x7FFAF856C4C0
        public void Truncate(){} // RVA: 0x7FFAF856C590
        public void UseDnsSecurity(){} // RVA: 0x7FFAF856C6F0
        public void Read(){} // RVA: 0x7FFAF856C710
        public void Write(){} // RVA: 0x7FFAF856CD10
        public void ToString(){} // RVA: 0x7FFAF856D500
        public void Stringify(){} // RVA: 0x7FFAF856DBC0
        public void .ctor(){} // RVA: 0x7FFAF856DE00
    }

    public class NSEC3PARAMRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8573450
        public void get_HashAlgorithm(){} // RVA: 0x7FFAF2DB3450
        public void set_HashAlgorithm(){} // RVA: 0x7FFAF2DB3460
        public void get_Flags(){} // RVA: 0x7FFAF2DB3470
        public void set_Flags(){} // RVA: 0x7FFAF2DB3480
        public void get_Iterations(){} // RVA: 0x7FFAF85734B0
        public void set_Iterations(){} // RVA: 0x7FFAF85734C0
        public void get_Salt(){} // RVA: 0x7FFAF2F476A0
        public void set_Salt(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8573690 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF85737B0 | overloaded x2
    }

    public class NSEC3Record
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8573920
        public void get_HashAlgorithm(){} // RVA: 0x7FFAF2DB3450
        public void set_HashAlgorithm(){} // RVA: 0x7FFAF2DB3460
        public void get_Flags(){} // RVA: 0x7FFAF2DB3470
        public void set_Flags(){} // RVA: 0x7FFAF2DB3480
        public void get_Iterations(){} // RVA: 0x7FFAF85734B0
        public void set_Iterations(){} // RVA: 0x7FFAF85734C0
        public void get_Salt(){} // RVA: 0x7FFAF2F476A0
        public void set_Salt(){} // RVA: 0x7FFAF2F4B830
        public void get_NextHashedOwnerName(){} // RVA: 0x7FFAF2E0A740
        public void set_NextHashedOwnerName(){} // RVA: 0x7FFAF2DB5200
        public void get_Types(){} // RVA: 0x7FFAF2E08730
        public void set_Types(){} // RVA: 0x7FFAF2E08740
        public void ReadData(){} // RVA: 0x7FFAF8573F50 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF85742E0 | overloaded x2
    }

    public class NSECRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8574750
        public void get_NextOwnerName(){} // RVA: 0x7FFAF30E74D0
        public void set_NextOwnerName(){} // RVA: 0x7FFAF2DBB890
        public void get_Types(){} // RVA: 0x7FFAF2F476A0
        public void set_Types(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8574C90 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8574DC0 | overloaded x2
    }

    public class NSRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85750F0
        public void get_Authority(){} // RVA: 0x7FFAF30E74D0
        public void set_Authority(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8571EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571FB0 | overloaded x2
    }

    public class NULLRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8575150
        public void get_Data(){} // RVA: 0x7FFAF30E74D0
        public void set_Data(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8575230 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF85752A0
    }

    public class OPTRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8575300
        public void get_RequestorPayloadSize(){} // RVA: 0x7FFAF8570F30
        public void set_RequestorPayloadSize(){} // RVA: 0x7FFAF8570F40
        public void get_Opcode8(){} // RVA: 0x7FFAF85754D0
        public void set_Opcode8(){} // RVA: 0x7FFAF8575540
        public void get_Version(){} // RVA: 0x7FFAF85755E0
        public void set_Version(){} // RVA: 0x7FFAF8575650
        public void get_DO(){} // RVA: 0x7FFAF85756F0
        public void set_DO(){} // RVA: 0x7FFAF8575750
        public void get_Options(){} // RVA: 0x7FFAF30E74D0
        public void set_Options(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8575810
        public void WriteData(){} // RVA: 0x7FFAF85759D0
        public void ToString(){} // RVA: 0x7FFAF8575BE0
    }

    public class PTRRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8575F10
        public void get_DomainName(){} // RVA: 0x7FFAF30E74D0
        public void set_DomainName(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8571EE0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8571FB0 | overloaded x2
    }

    public class PresentationReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF856E080
        public void get_Origin(){} // RVA: 0x7FFAF2E0A740
        public void set_Origin(){} // RVA: 0x7FFAF2DB5200
        public void ReadByte(){} // RVA: 0x7FFAF856E1A0
        public void ReadUInt16(){} // RVA: 0x7FFAF856E2C0
        public void ReadUInt32(){} // RVA: 0x7FFAF856E3E0
        public void ReadDomainName(){} // RVA: 0x7FFAF856E490
        public void MakeAbsoluteDomainName(){} // RVA: 0x7FFAF856E4C0
        public void ReadString(){} // RVA: 0x7FFAF856E670
        public void ReadBase64String(){} // RVA: 0x7FFAF856E680
        public void ReadTimeSpan16(){} // RVA: 0x7FFAF856E810
        public void ReadTimeSpan32(){} // RVA: 0x7FFAF856E8C0
        public void ReadIPAddress(){} // RVA: 0x7FFAF856E970
        public void ReadDnsType(){} // RVA: 0x7FFAF856EA70
        public void ReadDateTime(){} // RVA: 0x7FFAF856EC70
        public void ReadResourceData(){} // RVA: 0x7FFAF856EE50
        public void ReadResourceRecord(){} // RVA: 0x7FFAF856F1A0
        public void IsEndOfLine(){} // RVA: 0x7FFAF856F930
        public void ReadToken(){} // RVA: 0x7FFAF856FA90
        public void .cctor(){} // RVA: 0x7FFAF856FE60
    }

    public class PresentationWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void WriteSpace(){} // RVA: 0x7FFAF856FFD0
        public void WriteEndOfLine(){} // RVA: 0x7FFAF8570000
        public void WriteByte(){} // RVA: 0x7FFAF8570060
        public void WriteUInt16(){} // RVA: 0x7FFAF85700D0
        public void WriteUInt32(){} // RVA: 0x7FFAF8570140
        public void WriteString(){} // RVA: 0x7FFAF85701B0
        public void WriteStringUnencoded(){} // RVA: 0x7FFAF85703B0
        public void WriteDomainName(){} // RVA: 0x7FFAF8570420
        public void WriteBase16String(){} // RVA: 0x7FFAF85704B0
        public void WriteBase64String(){} // RVA: 0x7FFAF8570520
        public void WriteTimeSpan16(){} // RVA: 0x7FFAF8570660
        public void WriteTimeSpan32(){} // RVA: 0x7FFAF8570730
        public void WriteDateTime(){} // RVA: 0x7FFAF8570800
        public void WriteIPAddress(){} // RVA: 0x7FFAF8570960
        public void WriteDnsType(){} // RVA: 0x7FFAF85709C0
        public void WriteDnsClass(){} // RVA: 0x7FFAF8570C30
        public void .cctor(){} // RVA: 0x7FFAF8570EA0
    }

    public class Question
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void set_Name(){} // RVA: 0x7FFAF2DF3E80
        public void get_Type(){} // RVA: 0x7FFAF6F64370
        public void set_Type(){} // RVA: 0x7FFAF8570F20
        public void get_Class(){} // RVA: 0x7FFAF8570F30
        public void set_Class(){} // RVA: 0x7FFAF8570F40
        public void Read(){} // RVA: 0x7FFAF8570F50
        public void Write(){} // RVA: 0x7FFAF8571030
        public void ToString(){} // RVA: 0x7FFAF8571110
        public void .ctor(){} // RVA: 0x7FFAF8571330
    }

    public class RPRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8575F70
        public void get_Mailbox(){} // RVA: 0x7FFAF30E74D0
        public void set_Mailbox(){} // RVA: 0x7FFAF2DBB890
        public void get_TextName(){} // RVA: 0x7FFAF2F476A0
        public void set_TextName(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF85761B0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8576310 | overloaded x2
    }

    public class RRSIGRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85763E0
        public void get_TypeCovered(){} // RVA: 0x7FFAF6697880
        public void set_TypeCovered(){} // RVA: 0x7FFAF8571AF0
        public void get_Algorithm(){} // RVA: 0x7FFAF6697520
        public void set_Algorithm(){} // RVA: 0x7FFAF8572490
        public void get_Labels(){} // RVA: 0x7FFAF85724A0
        public void set_Labels(){} // RVA: 0x7FFAF85724B0
        public void get_OriginalTTL(){} // RVA: 0x7FFAF2F476A0
        public void set_OriginalTTL(){} // RVA: 0x7FFAF3A001D0
        public void get_SignatureExpiration(){} // RVA: 0x7FFAF2E0A740
        public void set_SignatureExpiration(){} // RVA: 0x7FFAF61637A0
        public void get_SignatureInception(){} // RVA: 0x7FFAF2E08730
        public void set_SignatureInception(){} // RVA: 0x7FFAF424D760
        public void get_KeyTag(){} // RVA: 0x7FFAF6C93C10
        public void set_KeyTag(){} // RVA: 0x7FFAF8576440
        public void get_SignerName(){} // RVA: 0x7FFAF2E55500
        public void set_SignerName(){} // RVA: 0x7FFAF2E55510
        public void get_Signature(){} // RVA: 0x7FFAF2E2B370
        public void set_Signature(){} // RVA: 0x7FFAF2E2B380
        public void ReadData(){} // RVA: 0x7FFAF8576790 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8576900 | overloaded x2
    }

    public class ResourceRecord
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void set_Name(){} // RVA: 0x7FFAF2DF3E80
        public void get_CanonicalName(){} // RVA: 0x7FFAF8579870
        public void get_Type(){} // RVA: 0x7FFAF6F64370
        public void set_Type(){} // RVA: 0x7FFAF8570F20
        public void get_Class(){} // RVA: 0x7FFAF8570F30
        public void set_Class(){} // RVA: 0x7FFAF8570F40
        public void get_TTL(){} // RVA: 0x7FFAF2DBB130
        public void set_TTL(){} // RVA: 0x7FFAF335C650
        public void IsExpired(){} // RVA: 0x7FFAF85798B0
        public void GetDataLength(){} // RVA: 0x7FFAF8579990
        public void GetData(){} // RVA: 0x7FFAF8579AE0
        public void Read(){} // RVA: 0x7FFAF857AA00 | overloaded x3
        public void ReadData(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Write(){} // RVA: 0x7FFAF857A650 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF857A810 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF8579FC0
        public void op_Equality(){} // RVA: 0x7FFAF857A140
        public void op_Inequality(){} // RVA: 0x7FFAF857A170
        public void GetHashCode(){} // RVA: 0x7FFAF857A1B0
        public void ToString(){} // RVA: 0x7FFAF857A430
        public void .ctor(){} // RVA: 0x7FFAF857AA20
        public void .cctor(){} // RVA: 0x7FFAF857AAD0
    }

    public class ResourceRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF857AC90
        public void Register(){} // RVA: 0x7FFAF2AD4A80
        public void Create(){} // RVA: 0x7FFAF857B000
    }

    public class SOARecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8576AC0
        public void get_PrimaryName(){} // RVA: 0x7FFAF30E74D0
        public void set_PrimaryName(){} // RVA: 0x7FFAF2DBB890
        public void get_Mailbox(){} // RVA: 0x7FFAF2F476A0
        public void set_Mailbox(){} // RVA: 0x7FFAF2F4B830
        public void get_SerialNumber(){} // RVA: 0x7FFAF2E2E080
        public void set_SerialNumber(){} // RVA: 0x7FFAF2E2E090
        public void get_Refresh(){} // RVA: 0x7FFAF2E08730
        public void set_Refresh(){} // RVA: 0x7FFAF424D760
        public void get_Retry(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Retry(){} // RVA: 0x7FFAF2F74D50
        public void get_Expire(){} // RVA: 0x7FFAF2E55500
        public void set_Expire(){} // RVA: 0x7FFAF2F734E0
        public void get_Minimum(){} // RVA: 0x7FFAF2E2B370
        public void set_Minimum(){} // RVA: 0x7FFAF8576B90
        public void ReadData(){} // RVA: 0x7FFAF8576CE0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8576EE0 | overloaded x2
    }

    public class SRVRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85770E0
        public void get_Priority(){} // RVA: 0x7FFAF6697880
        public void set_Priority(){} // RVA: 0x7FFAF8571AF0
        public void get_Weight(){} // RVA: 0x7FFAF85734B0
        public void set_Weight(){} // RVA: 0x7FFAF85734C0
        public void get_Port(){} // RVA: 0x7FFAF8577140
        public void set_Port(){} // RVA: 0x7FFAF8577150
        public void get_Target(){} // RVA: 0x7FFAF2F476A0
        public void set_Target(){} // RVA: 0x7FFAF2F4B830
        public void ReadData(){} // RVA: 0x7FFAF8577260 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8577460 | overloaded x2
    }

    public class SecurityAlgorithmRegistry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF857B120
        public void GetMetadata(){} // RVA: 0x7FFAF857B730
    }

    public class TKEYRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85775A0
        public void get_Algorithm(){} // RVA: 0x7FFAF30E74D0
        public void set_Algorithm(){} // RVA: 0x7FFAF2DBB890
        public void get_Inception(){} // RVA: 0x7FFAF2F476A0
        public void set_Inception(){} // RVA: 0x7FFAF3A001D0
        public void get_Expiration(){} // RVA: 0x7FFAF2E0A740
        public void set_Expiration(){} // RVA: 0x7FFAF61637A0
        public void get_Mode(){} // RVA: 0x7FFAF85776F0
        public void set_Mode(){} // RVA: 0x7FFAF8577700
        public void get_Error(){} // RVA: 0x7FFAF418F2D0
        public void set_Error(){} // RVA: 0x7FFAF418E990
        public void get_Key(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Key(){} // RVA: 0x7FFAF2EE54D0
        public void get_OtherData(){} // RVA: 0x7FFAF2E55500
        public void set_OtherData(){} // RVA: 0x7FFAF2E55510
        public void ReadData(){} // RVA: 0x7FFAF8577A40 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8577D70 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8577F30
    }

    public class TSIGRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8577FE0
        public void get_Algorithm(){} // RVA: 0x7FFAF30E74D0
        public void set_Algorithm(){} // RVA: 0x7FFAF2DBB890
        public void get_TimeSigned(){} // RVA: 0x7FFAF2F476A0
        public void set_TimeSigned(){} // RVA: 0x7FFAF3A001D0
        public void get_MAC(){} // RVA: 0x7FFAF2E0A740
        public void set_MAC(){} // RVA: 0x7FFAF2DB5200
        public void get_Fudge(){} // RVA: 0x7FFAF2E08730
        public void set_Fudge(){} // RVA: 0x7FFAF424D760
        public void get_OriginalMessageId(){} // RVA: 0x7FFAF6C93C10
        public void set_OriginalMessageId(){} // RVA: 0x7FFAF8576440
        public void get_Error(){} // RVA: 0x7FFAF4695300
        public void set_Error(){} // RVA: 0x7FFAF4692180
        public void get_OtherData(){} // RVA: 0x7FFAF2E55500
        public void set_OtherData(){} // RVA: 0x7FFAF2E55510
        public void ReadData(){} // RVA: 0x7FFAF8578B70 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8578F30 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8579180
    }

    public class TXTRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8579230
        public void get_Strings(){} // RVA: 0x7FFAF30E74D0
        public void set_Strings(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8579440 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF8579670 | overloaded x2
    }

    public class UnknownEdnsOption
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2D907C0
        public void set_Data(){} // RVA: 0x7FFAF2DF3E80
        public void ReadData(){} // RVA: 0x7FFAF856B3A0
        public void WriteData(){} // RVA: 0x7FFAF856B420
        public void ToString(){} // RVA: 0x7FFAF857B8E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnknownRecord
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF30E74D0
        public void set_Data(){} // RVA: 0x7FFAF2DBB890
        public void ReadData(){} // RVA: 0x7FFAF8575230 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFAF85752A0
        public void .ctor(){} // RVA: 0x7FFAF8579820
    }

    public class UpdateMessage
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF5342C90
        public void set_Id(){} // RVA: 0x7FFAF6F20200
        public void get_QR(){} // RVA: 0x7FFAF4648340
        public void set_QR(){} // RVA: 0x7FFAF4648210
        public void get_IsUpdate(){} // RVA: 0x7FFAF857BA90
        public void get_IsResponse(){} // RVA: 0x7FFAF4648340
        public void get_Opcode(){} // RVA: 0x7FFAF857BAA0
        public void set_Opcode(){} // RVA: 0x7FFAF857BAB0
        public void get_Z(){} // RVA: 0x7FFAF3210030
        public void set_Z(){} // RVA: 0x7FFAF344E0D0
        public void get_Status(){} // RVA: 0x7FFAF2DA87C0
        public void set_Status(){} // RVA: 0x7FFAF2F87670
        public void get_Zone(){} // RVA: 0x7FFAF2DBB130
        public void set_Zone(){} // RVA: 0x7FFAF2D8EE90
        public void get_Prerequisites(){} // RVA: 0x7FFAF30E74D0
        public void get_Updates(){} // RVA: 0x7FFAF2F476A0
        public void get_AdditionalResources(){} // RVA: 0x7FFAF2E0A740
        public void CreateResponse(){} // RVA: 0x7FFAF857BAC0
        public void Read(){} // RVA: 0x7FFAF857BB40
        public void Write(){} // RVA: 0x7FFAF857C0E0
        public void .ctor(){} // RVA: 0x7FFAF857C710
    }

    public class UpdatePrerequisiteList
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x7FFAF857CBC0 | overloaded x4
        public void MustNotExist(){} // RVA: 0x7FFAF2ABCE10 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF857CDB0
    }

    public class UpdateResourceList
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x7FFAF857CE20
        public void DeleteResource(){} // RVA: 0x7FFAF2ABCE10 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAF857D170
    }

    public class WireReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF857D1E0
        public void ReadByte(){} // RVA: 0x7FFAF857D300
        public void ReadBytes(){} // RVA: 0x7FFAF857D380
        public void ReadByteLengthPrefixedBytes(){} // RVA: 0x7FFAF857D470
        public void ReadUInt16LengthPrefixedBytes(){} // RVA: 0x7FFAF857D4A0
        public void ReadUInt16(){} // RVA: 0x7FFAF857D4E0
        public void ReadUInt32(){} // RVA: 0x7FFAF857D520
        public void ReadUInt48(){} // RVA: 0x7FFAF857D590
        public void ReadDomainName(){} // RVA: 0x7FFAF857D640
        public void ReadLabels(){} // RVA: 0x7FFAF857D6E0
        public void ReadString(){} // RVA: 0x7FFAF857D900
        public void ReadTimeSpan16(){} // RVA: 0x7FFAF857DBC0
        public void ReadTimeSpan32(){} // RVA: 0x7FFAF857DC90
        public void ReadIPAddress(){} // RVA: 0x7FFAF857DD40
        public void ReadBitmap(){} // RVA: 0x7FFAF857DE20
        public void ReadDateTime32(){} // RVA: 0x7FFAF857DF70
        public void ReadDateTime48(){} // RVA: 0x7FFAF857E060
        public void .cctor(){} // RVA: 0x7FFAF857E200
    }

    public class WireWriter
    {
        public object System.Collections.Generic.IEnumerator<System.Byte>.Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF857E330
        public void get_CanonicalForm(){} // RVA: 0x7FFAF2E6C230
        public void set_CanonicalForm(){} // RVA: 0x7FFAF2E6C240
        public void PushLengthPrefixedScope(){} // RVA: 0x7FFAF857E500
        public void PopLengthPrefixedScope(){} // RVA: 0x7FFAF857E5E0
        public void WriteByte(){} // RVA: 0x7FFAF857E750
        public void WriteBytes(){} // RVA: 0x7FFAF857E790
        public void WriteByteLengthPrefixedBytes(){} // RVA: 0x7FFAF857E7F0
        public void WriteUint16LengthPrefixedBytes(){} // RVA: 0x7FFAF857E910
        public void WriteUInt16(){} // RVA: 0x7FFAF857EA10
        public void WriteUInt32(){} // RVA: 0x7FFAF857EA80
        public void WriteUInt48(){} // RVA: 0x7FFAF857EB30
        public void WriteDomainName(){} // RVA: 0x7FFAF857ED70 | overloaded x2
        public void WriteString(){} // RVA: 0x7FFAF857F140
        public void WriteTimeSpan16(){} // RVA: 0x7FFAF857F340
        public void WriteTimeSpan32(){} // RVA: 0x7FFAF857F400
        public void WriteDateTime32(){} // RVA: 0x7FFAF857F480
        public void WriteDateTime48(){} // RVA: 0x7FFAF857F5B0
        public void WriteIPAddress(){} // RVA: 0x7FFAF857F6E0
        public void WriteBitmap(){} // RVA: 0x7FFAF857F750
        public void ToBytes(){} // RVA: 0x7FFAF8580080
        public void .cctor(){} // RVA: 0x7FFAF8580140
    }

}