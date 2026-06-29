// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 53
// Methods: 494

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class AAAARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AE930
    }

    public class AFSDBRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AF030
        public void get_Subtype(){} // RVA: 0x7AB9DFA00
        public void set_Subtype(){} // RVA: 0x7AD8AF090
        public void get_Target(){} // RVA: 0x7A8292C30
        public void set_Target(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8AF160
        public void WriteData(){} // RVA: 0x7AD8AF290
    }

    public class ARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AF340
    }

    public class AddressRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AE9A0
        public void get_Address(){} // RVA: 0x7A83F69F0
        public void set_Address(){} // RVA: 0x7A8105A90
        public void Create(){} // RVA: 0x7AD8AEA10
        public void ReadData(){} // RVA: 0x7AD8AEE10
        public void WriteData(){} // RVA: 0x7AD8AEFE0
    }

    public class CNAMERecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AF3B0
        public void get_Target(){} // RVA: 0x7A83F69F0
        public void set_Target(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8AF480
        public void WriteData(){} // RVA: 0x7AD8AF550
    }

    public class DNAMERecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AF5B0
        public void get_Target(){} // RVA: 0x7A83F69F0
        public void set_Target(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8AF480
        public void WriteData(){} // RVA: 0x7AD8AF550
    }

    public class DNSKEYRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AF6A0
        public void get_Flags(){} // RVA: 0x7AB9DFA00
        public void set_Flags(){} // RVA: 0x7AD8AF090
        public void get_Protocol(){} // RVA: 0x7AB9DF6A0
        public void set_Protocol(){} // RVA: 0x7AD8AFA40
        public void get_Algorithm(){} // RVA: 0x7AD8AFA50
        public void set_Algorithm(){} // RVA: 0x7AD8AFA60
        public void get_PublicKey(){} // RVA: 0x7A8292C30
        public void set_PublicKey(){} // RVA: 0x7A8296DE0
        public void KeyTag(){} // RVA: 0x7AD8AFA70
        public void ReadData(){} // RVA: 0x7AD8AFD00
        public void WriteData(){} // RVA: 0x7AD8AFDB0
    }

    public class DSRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AFF20
        public void get_KeyTag(){} // RVA: 0x7AB9DFA00
        public void set_KeyTag(){} // RVA: 0x7AD8AF090
        public void get_Algorithm(){} // RVA: 0x7AB9DF6A0
        public void set_Algorithm(){} // RVA: 0x7AD8AFA40
        public void get_HashAlgorithm(){} // RVA: 0x7AD8AFA50
        public void set_HashAlgorithm(){} // RVA: 0x7AD8AFA60
        public void get_Digest(){} // RVA: 0x7A8292C30
        public void set_Digest(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8B0440
        public void WriteData(){} // RVA: 0x7AD8B0590
    }

    public class DigestRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD8A4D90
        public void Create(){} // RVA: 0x7AD8A5250
    }

    public class DnsObject : Object
    {
        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0x7A80F2570
        public void set_CreationTime(){} // RVA: 0x7A97242F0
        public void Length(){} // RVA: 0x7AD8A56E0
        public void Clone(){} // RVA: 0x7A8051B10
        public void Read(){} // RVA: 0x7A7E00B20
        public void ToByteArray(){} // RVA: 0x7AD8A5BB0
        public void Write(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7AD8A5D50
    }

    public class DomainName : Object
    {
        // ── Methods ──
        public void get_Labels(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AD8A5E70
        public void Join(){} // RVA: 0x7AD8A5F80
        public void ToString(){} // RVA: 0x7AD8A6090
        public void EscapeLabel(){} // RVA: 0x7AD8A6160
        public void ToCanonical(){} // RVA: 0x7AD8A63D0
        public void BelongsTo(){} // RVA: 0x7AD8A65F0
        public void IsSubdomainOf(){} // RVA: 0x7AD8A6680
        public void Parent(){} // RVA: 0x7AD8A6840
        public void Parse(){} // RVA: 0x7AD8A6990
        public void GetHashCode(){} // RVA: 0x7AD8A6C90
        public void Equals(){} // RVA: 0x7AD8A6DA0
        public void op_Equality(){} // RVA: 0x7AD8A6F30
        public void op_Inequality(){} // RVA: 0x7AD8A6F50
        public void op_Implicit(){} // RVA: 0x7AD8A6FE0
        public void LabelsEqual(){} // RVA: 0x7AD8A7040
        public void .cctor(){} // RVA: 0x7AD8A7110
    }

    public class EdnsDAUOption : EdnsOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A72B0
        public void get_Algorithms(){} // RVA: 0x7A80DA7B0
        public void set_Algorithms(){} // RVA: 0x7A813E420
        public void Create(){} // RVA: 0x7AD8A7370
        public void ReadData(){} // RVA: 0x7AD8A7500
        public void WriteData(){} // RVA: 0x7AD8A7660
        public void ToString(){} // RVA: 0x7AD8A7870
    }

    public class EdnsDHUOption : EdnsOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A7960
        public void get_Algorithms(){} // RVA: 0x7A80DA7B0
        public void set_Algorithms(){} // RVA: 0x7A813E420
        public void Create(){} // RVA: 0x7AD8A7A20
        public void ReadData(){} // RVA: 0x7AD8A7BB0
        public void WriteData(){} // RVA: 0x7AD8A7D10
        public void ToString(){} // RVA: 0x7AD8A7F20
    }

    public class EdnsKeepaliveOption : EdnsOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A7F90
        public void get_Timeout(){} // RVA: 0x7A872EEF0
        public void set_Timeout(){} // RVA: 0x7A872E9B0
        public void ReadData(){} // RVA: 0x7AD8A7FA0
        public void WriteData(){} // RVA: 0x7AD8A8100
        public void ToString(){} // RVA: 0x7AD8A81F0
    }

    public class EdnsN3UOption : EdnsOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A82A0
        public void get_Algorithms(){} // RVA: 0x7A80DA7B0
        public void set_Algorithms(){} // RVA: 0x7A813E420
        public void Create(){} // RVA: 0x7AD8A8360
        public void ReadData(){} // RVA: 0x7AD8A84F0
        public void WriteData(){} // RVA: 0x7AD8A8650
        public void ToString(){} // RVA: 0x7AD8A8860
    }

    public class EdnsNSIDOption : EdnsOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A88D0
        public void get_Id(){} // RVA: 0x7A80DA7B0
        public void set_Id(){} // RVA: 0x7A813E420
        public void ReadData(){} // RVA: 0x7AD8A88E0
        public void WriteData(){} // RVA: 0x7AD8A8960
    }

    public class EdnsOption : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A99CD750
        public void set_Type(){} // RVA: 0x7A99CDAA0
        public void ReadData(){} // RVA: 0x7A7E1D590
        public void WriteData(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EdnsOptionRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD8A89C0
        public void Register(){} // RVA: 0x7A7E187D0
    }

    public class EdnsPaddingOption : EdnsOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A8B40
        public void get_Padding(){} // RVA: 0x7A80DA7B0
        public void set_Padding(){} // RVA: 0x7A813E420
        public void ReadData(){} // RVA: 0x7AD8A88E0
        public void WriteData(){} // RVA: 0x7AD8A8960
        public void ToString(){} // RVA: 0x7AD8A8B50
    }

    public class HINFORecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B06E0
        public void get_Cpu(){} // RVA: 0x7A83F69F0
        public void set_Cpu(){} // RVA: 0x7A8105A90
        public void get_OS(){} // RVA: 0x7A8292C30
        public void set_OS(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8B0840
        public void WriteData(){} // RVA: 0x7AD8B0990
    }

    public class IPAddressExtensions : Object
    {
        // ── Methods ──
        public void GetArpaName(){} // RVA: 0x7AD8A8C50
    }

    public class IPresentationSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7A7E00B20
        public void Write(){} // RVA: 0x7A7E18800
    }

    public class IResolver
    {
        // ── Methods ──
        public void ResolveAsync(){} // RVA: 0x7A7E06640
    }

    public class IWireSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7A7E00B20
        public void Write(){} // RVA: 0x7A7E18800
    }

    public class MXRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B09E0
        public void get_Preference(){} // RVA: 0x7AB9DFA00
        public void set_Preference(){} // RVA: 0x7AD8AF090
        public void get_Exchange(){} // RVA: 0x7A8292C30
        public void set_Exchange(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8AF160
        public void WriteData(){} // RVA: 0x7AD8AF290
    }

    public class Message : DnsObject
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7AA69D090
        public void set_Id(){} // RVA: 0x7AD8A9500
        public void get_QR(){} // RVA: 0x7A80F2580
        public void set_QR(){} // RVA: 0x7A80F2590
        public void get_IsQuery(){} // RVA: 0x7AD8A9510
        public void get_IsResponse(){} // RVA: 0x7A80F2580
        public void get_Opcode(){} // RVA: 0x7AD8A9520
        public void set_Opcode(){} // RVA: 0x7AD8A9630
        public void get_AA(){} // RVA: 0x7A99562E0
        public void set_AA(){} // RVA: 0x7A99562D0
        public void get_TC(){} // RVA: 0x7A9956C80
        public void set_TC(){} // RVA: 0x7A9956310
        public void get_RD(){} // RVA: 0x7A99562F0
        public void set_RD(){} // RVA: 0x7A9956300
        public void get_RA(){} // RVA: 0x7A81C68D0
        public void set_RA(){} // RVA: 0x7A81C68E0
        public void get_Z(){} // RVA: 0x7A8AB15F0
        public void set_Z(){} // RVA: 0x7A94794D0
        public void get_AD(){} // RVA: 0x7A84A5BD0
        public void set_AD(){} // RVA: 0x7A84A5CD0
        public void get_CD(){} // RVA: 0x7A89FCA90
        public void set_CD(){} // RVA: 0x7A96C67C0
        public void get_DO(){} // RVA: 0x7AD8A9790
        public void set_DO(){} // RVA: 0x7AD8A9850
        public void get_Status(){} // RVA: 0x7A9E700C0
        public void set_Status(){} // RVA: 0x7A9E700B0
        public void get_Questions(){} // RVA: 0x7A83F69F0
        public void get_Answers(){} // RVA: 0x7A8292C30
        public void set_Answers(){} // RVA: 0x7A8296DE0
        public void get_AuthorityRecords(){} // RVA: 0x7A8154D80
        public void set_AuthorityRecords(){} // RVA: 0x7A80FF440
        public void get_AdditionalRecords(){} // RVA: 0x7A8152D80
        public void set_AdditionalRecords(){} // RVA: 0x7A8152D90
        public void CreateResponse(){} // RVA: 0x7AD8A99F0
        public void Truncate(){} // RVA: 0x7AD8A9AC0
        public void UseDnsSecurity(){} // RVA: 0x7AD8A9C20
        public void Read(){} // RVA: 0x7AD8A9C40
        public void Write(){} // RVA: 0x7AD8AA250
        public void ToString(){} // RVA: 0x7AD8AAA50
        public void Stringify(){} // RVA: 0x7AD8AB120
        public void .ctor(){} // RVA: 0x7AD8AB370
    }

    public class NSEC3PARAMRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B0A40
        public void get_HashAlgorithm(){} // RVA: 0x7A80FD690
        public void set_HashAlgorithm(){} // RVA: 0x7A80FD6A0
        public void get_Flags(){} // RVA: 0x7A80FD6B0
        public void set_Flags(){} // RVA: 0x7A80FD6C0
        public void get_Iterations(){} // RVA: 0x7AD8B0AA0
        public void set_Iterations(){} // RVA: 0x7AD8B0AB0
        public void get_Salt(){} // RVA: 0x7A8292C30
        public void set_Salt(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8B0C80
        public void WriteData(){} // RVA: 0x7AD8B0DA0
    }

    public class NSEC3Record : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B0F10
        public void get_HashAlgorithm(){} // RVA: 0x7A80FD690
        public void set_HashAlgorithm(){} // RVA: 0x7A80FD6A0
        public void get_Flags(){} // RVA: 0x7A80FD6B0
        public void set_Flags(){} // RVA: 0x7A80FD6C0
        public void get_Iterations(){} // RVA: 0x7AD8B0AA0
        public void set_Iterations(){} // RVA: 0x7AD8B0AB0
        public void get_Salt(){} // RVA: 0x7A8292C30
        public void set_Salt(){} // RVA: 0x7A8296DE0
        public void get_NextHashedOwnerName(){} // RVA: 0x7A8154D80
        public void set_NextHashedOwnerName(){} // RVA: 0x7A80FF440
        public void get_Types(){} // RVA: 0x7A8152D80
        public void set_Types(){} // RVA: 0x7A8152D90
        public void ReadData(){} // RVA: 0x7AD8B1540
        public void WriteData(){} // RVA: 0x7AD8B18F0
    }

    public class NSECRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B1D70
        public void get_NextOwnerName(){} // RVA: 0x7A83F69F0
        public void set_NextOwnerName(){} // RVA: 0x7A8105A90
        public void get_Types(){} // RVA: 0x7A8292C30
        public void set_Types(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8B22B0
        public void WriteData(){} // RVA: 0x7AD8B23E0
    }

    public class NSRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B2720
        public void get_Authority(){} // RVA: 0x7A83F69F0
        public void set_Authority(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8AF480
        public void WriteData(){} // RVA: 0x7AD8AF550
    }

    public class NULLRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B2780
        public void get_Data(){} // RVA: 0x7A83F69F0
        public void set_Data(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8B2860
        public void WriteData(){} // RVA: 0x7AD8B28D0
    }

    public class OPTRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B2930
        public void get_RequestorPayloadSize(){} // RVA: 0x7AD8AE4C0
        public void set_RequestorPayloadSize(){} // RVA: 0x7AD8AE4D0
        public void get_Opcode8(){} // RVA: 0x7AD8B2B00
        public void set_Opcode8(){} // RVA: 0x7AD8B2B70
        public void get_Version(){} // RVA: 0x7AD8B2C10
        public void set_Version(){} // RVA: 0x7AD8B2C80
        public void get_DO(){} // RVA: 0x7AD8B2D20
        public void set_DO(){} // RVA: 0x7AD8B2D80
        public void get_Options(){} // RVA: 0x7A83F69F0
        public void set_Options(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8B2E40
        public void WriteData(){} // RVA: 0x7AD8B3000
        public void ToString(){} // RVA: 0x7AD8B3200
    }

    public class PTRRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B3550
        public void get_DomainName(){} // RVA: 0x7A83F69F0
        public void set_DomainName(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8AF480
        public void WriteData(){} // RVA: 0x7AD8AF550
    }

    public class PresentationReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8AB5F0
        public void get_Origin(){} // RVA: 0x7A8154D80
        public void set_Origin(){} // RVA: 0x7A80FF440
        public void ReadByte(){} // RVA: 0x7AD8AB710
        public void ReadUInt16(){} // RVA: 0x7AD8AB830
        public void ReadUInt32(){} // RVA: 0x7AD8AB950
        public void ReadDomainName(){} // RVA: 0x7AD8ABA00
        public void MakeAbsoluteDomainName(){} // RVA: 0x7AD8ABA30
        public void ReadString(){} // RVA: 0x7AD8ABBE0
        public void ReadBase64String(){} // RVA: 0x7AD8ABBF0
        public void ReadTimeSpan16(){} // RVA: 0x7AD8ABD80
        public void ReadTimeSpan32(){} // RVA: 0x7AD8ABE30
        public void ReadIPAddress(){} // RVA: 0x7AD8ABEE0
        public void ReadDnsType(){} // RVA: 0x7AD8ABFE0
        public void ReadDateTime(){} // RVA: 0x7AD8AC1E0
        public void ReadResourceData(){} // RVA: 0x7AD8AC3C0
        public void ReadResourceRecord(){} // RVA: 0x7AD8AC710
        public void IsEndOfLine(){} // RVA: 0x7AD8ACEC0
        public void ReadToken(){} // RVA: 0x7AD8AD020
        public void .cctor(){} // RVA: 0x7AD8AD3F0
    }

    public class PresentationWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void WriteSpace(){} // RVA: 0x7AD8AD560
        public void WriteEndOfLine(){} // RVA: 0x7AD8AD590
        public void WriteByte(){} // RVA: 0x7AD8AD5F0
        public void WriteUInt16(){} // RVA: 0x7AD8AD660
        public void WriteUInt32(){} // RVA: 0x7AD8AD6D0
        public void WriteString(){} // RVA: 0x7AD8AD740
        public void WriteStringUnencoded(){} // RVA: 0x7AD8AD940
        public void WriteDomainName(){} // RVA: 0x7AD8AD9B0
        public void WriteBase16String(){} // RVA: 0x7AD8ADA40
        public void WriteBase64String(){} // RVA: 0x7AD8ADAB0
        public void WriteTimeSpan16(){} // RVA: 0x7AD8ADBF0
        public void WriteTimeSpan32(){} // RVA: 0x7AD8ADCC0
        public void WriteDateTime(){} // RVA: 0x7AD8ADD90
        public void WriteIPAddress(){} // RVA: 0x7AD8ADEF0
        public void WriteDnsType(){} // RVA: 0x7AD8ADF50
        public void WriteDnsClass(){} // RVA: 0x7AD8AE1C0
        public void .cctor(){} // RVA: 0x7AD8AE430
    }

    public class Question : DnsObject
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void set_Name(){} // RVA: 0x7A813E420
        public void get_Type(){} // RVA: 0x7AC2A24B0
        public void set_Type(){} // RVA: 0x7AD8AE4B0
        public void get_Class(){} // RVA: 0x7AD8AE4C0
        public void set_Class(){} // RVA: 0x7AD8AE4D0
        public void Read(){} // RVA: 0x7AD8AE4E0
        public void Write(){} // RVA: 0x7AD8AE5C0
        public void ToString(){} // RVA: 0x7AD8AE6A0
        public void .ctor(){} // RVA: 0x7AD8AE8D0
    }

    public class RPRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B35B0
        public void get_Mailbox(){} // RVA: 0x7A83F69F0
        public void set_Mailbox(){} // RVA: 0x7A8105A90
        public void get_TextName(){} // RVA: 0x7A8292C30
        public void set_TextName(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8B37F0
        public void WriteData(){} // RVA: 0x7AD8B3950
    }

    public class RRSIGRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B3A20
        public void get_TypeCovered(){} // RVA: 0x7AB9DFA00
        public void set_TypeCovered(){} // RVA: 0x7AD8AF090
        public void get_Algorithm(){} // RVA: 0x7AB9DF6A0
        public void set_Algorithm(){} // RVA: 0x7AD8AFA40
        public void get_Labels(){} // RVA: 0x7AD8AFA50
        public void set_Labels(){} // RVA: 0x7AD8AFA60
        public void get_OriginalTTL(){} // RVA: 0x7A8292C30
        public void set_OriginalTTL(){} // RVA: 0x7A82C26E0
        public void get_SignatureExpiration(){} // RVA: 0x7A8154D80
        public void set_SignatureExpiration(){} // RVA: 0x7A82C0820
        public void get_SignatureInception(){} // RVA: 0x7A8152D80
        public void set_SignatureInception(){} // RVA: 0x7A9558880
        public void get_KeyTag(){} // RVA: 0x7ABFD44A0
        public void set_KeyTag(){} // RVA: 0x7AD8B3A80
        public void get_SignerName(){} // RVA: 0x7A81A0050
        public void set_SignerName(){} // RVA: 0x7A81A0060
        public void get_Signature(){} // RVA: 0x7A8175DF0
        public void set_Signature(){} // RVA: 0x7A8175E00
        public void ReadData(){} // RVA: 0x7AD8B3DD0
        public void WriteData(){} // RVA: 0x7AD8B3F40
    }

    public class ResourceRecord : DnsObject
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void set_Name(){} // RVA: 0x7A813E420
        public void get_CanonicalName(){} // RVA: 0x7AD8B6ED0
        public void get_Type(){} // RVA: 0x7AC2A24B0
        public void set_Type(){} // RVA: 0x7AD8AE4B0
        public void get_Class(){} // RVA: 0x7AD8AE4C0
        public void set_Class(){} // RVA: 0x7AD8AE4D0
        public void get_TTL(){} // RVA: 0x7A8105330
        public void set_TTL(){} // RVA: 0x7A8669350
        public void IsExpired(){} // RVA: 0x7AD8B6F10
        public void GetDataLength(){} // RVA: 0x7AD8B6FF0
        public void GetData(){} // RVA: 0x7AD8B7140
        public void Read(){} // RVA: 0x7AD8B8050
        public void ReadData(){} // RVA: 0x7A80D7310
        public void Write(){} // RVA: 0x7AD8B7CA0
        public void WriteData(){} // RVA: 0x7AD8B7E60
        public void Equals(){} // RVA: 0x7AD8B7620
        public void op_Equality(){} // RVA: 0x7AD8B77A0
        public void op_Inequality(){} // RVA: 0x7AD8B77D0
        public void GetHashCode(){} // RVA: 0x7AD8B7810
        public void ToString(){} // RVA: 0x7AD8B7A80
        public void .ctor(){} // RVA: 0x7AD8B8070
        public void .cctor(){} // RVA: 0x7AD8B8120
    }

    public class ResourceRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD8B82E0
        public void Register(){} // RVA: 0x7A7E187D0
        public void Create(){} // RVA: 0x7AD8B8650
    }

    public class SOARecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B4100
        public void get_PrimaryName(){} // RVA: 0x7A83F69F0
        public void set_PrimaryName(){} // RVA: 0x7A8105A90
        public void get_Mailbox(){} // RVA: 0x7A8292C30
        public void set_Mailbox(){} // RVA: 0x7A8296DE0
        public void get_SerialNumber(){} // RVA: 0x7A8178B30
        public void set_SerialNumber(){} // RVA: 0x7A8178B40
        public void get_Refresh(){} // RVA: 0x7A8152D80
        public void set_Refresh(){} // RVA: 0x7A9558880
        public void get_Retry(){} // RVA: 0x7A8178B90
        public void set_Retry(){} // RVA: 0x7A82C1E60
        public void get_Expire(){} // RVA: 0x7A81A0050
        public void set_Expire(){} // RVA: 0x7A82C2080
        public void get_Minimum(){} // RVA: 0x7A8175DF0
        public void set_Minimum(){} // RVA: 0x7AD8B41D0
        public void ReadData(){} // RVA: 0x7AD8B4320
        public void WriteData(){} // RVA: 0x7AD8B4520
    }

    public class SRVRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B4720
        public void get_Priority(){} // RVA: 0x7AB9DFA00
        public void set_Priority(){} // RVA: 0x7AD8AF090
        public void get_Weight(){} // RVA: 0x7AD8B0AA0
        public void set_Weight(){} // RVA: 0x7AD8B0AB0
        public void get_Port(){} // RVA: 0x7AD8B4780
        public void set_Port(){} // RVA: 0x7AD8B4790
        public void get_Target(){} // RVA: 0x7A8292C30
        public void set_Target(){} // RVA: 0x7A8296DE0
        public void ReadData(){} // RVA: 0x7AD8B48A0
        public void WriteData(){} // RVA: 0x7AD8B4AA0
    }

    public class SecurityAlgorithmRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD8B8770
        public void GetMetadata(){} // RVA: 0x7AD8B8D80
    }

    public class TKEYRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B4BE0
        public void get_Algorithm(){} // RVA: 0x7A83F69F0
        public void set_Algorithm(){} // RVA: 0x7A8105A90
        public void get_Inception(){} // RVA: 0x7A8292C30
        public void set_Inception(){} // RVA: 0x7A82C26E0
        public void get_Expiration(){} // RVA: 0x7A8154D80
        public void set_Expiration(){} // RVA: 0x7A82C0820
        public void get_Mode(){} // RVA: 0x7AD8B4D30
        public void set_Mode(){} // RVA: 0x7AD8B4D40
        public void get_Error(){} // RVA: 0x7A9476890
        public void set_Error(){} // RVA: 0x7A9475F50
        public void get_Key(){} // RVA: 0x7A8178B90
        public void set_Key(){} // RVA: 0x7A8230620
        public void get_OtherData(){} // RVA: 0x7A81A0050
        public void set_OtherData(){} // RVA: 0x7A81A0060
        public void ReadData(){} // RVA: 0x7AD8B5080
        public void WriteData(){} // RVA: 0x7AD8B53B0
        public void .cctor(){} // RVA: 0x7AD8B5570
    }

    public class TSIGRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B5620
        public void get_Algorithm(){} // RVA: 0x7A83F69F0
        public void set_Algorithm(){} // RVA: 0x7A8105A90
        public void get_TimeSigned(){} // RVA: 0x7A8292C30
        public void set_TimeSigned(){} // RVA: 0x7A82C26E0
        public void get_MAC(){} // RVA: 0x7A8154D80
        public void set_MAC(){} // RVA: 0x7A80FF440
        public void get_Fudge(){} // RVA: 0x7A8152D80
        public void set_Fudge(){} // RVA: 0x7A9558880
        public void get_OriginalMessageId(){} // RVA: 0x7ABFD44A0
        public void set_OriginalMessageId(){} // RVA: 0x7AD8B3A80
        public void get_Error(){} // RVA: 0x7A99A3440
        public void set_Error(){} // RVA: 0x7A99A0320
        public void get_OtherData(){} // RVA: 0x7A81A0050
        public void set_OtherData(){} // RVA: 0x7A81A0060
        public void ReadData(){} // RVA: 0x7AD8B61B0
        public void WriteData(){} // RVA: 0x7AD8B6570
        public void .cctor(){} // RVA: 0x7AD8B67C0
    }

    public class TXTRecord : ResourceRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8B6870
        public void get_Strings(){} // RVA: 0x7A83F69F0
        public void set_Strings(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8B6A80
        public void WriteData(){} // RVA: 0x7AD8B6CC0
    }

    public class UnknownEdnsOption : EdnsOption
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A80DA7B0
        public void set_Data(){} // RVA: 0x7A813E420
        public void ReadData(){} // RVA: 0x7AD8A88E0
        public void WriteData(){} // RVA: 0x7AD8A8960
        public void ToString(){} // RVA: 0x7AD8B8F30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnknownRecord : ResourceRecord
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A83F69F0
        public void set_Data(){} // RVA: 0x7A8105A90
        public void ReadData(){} // RVA: 0x7AD8B2860
        public void WriteData(){} // RVA: 0x7AD8B28D0
        public void .ctor(){} // RVA: 0x7AD8B6E80
    }

    public class UpdateMessage : DnsObject
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7AA69D080
        public void set_Id(){} // RVA: 0x7AC25E3B0
        public void get_QR(){} // RVA: 0x7A9956320
        public void set_QR(){} // RVA: 0x7A99561F0
        public void get_IsUpdate(){} // RVA: 0x7AD8B90E0
        public void get_IsResponse(){} // RVA: 0x7A9956320
        public void get_Opcode(){} // RVA: 0x7AD8B90F0
        public void set_Opcode(){} // RVA: 0x7AD8B9100
        public void get_Z(){} // RVA: 0x7A851DB90
        public void set_Z(){} // RVA: 0x7A8738180
        public void get_Status(){} // RVA: 0x7A80F29B0
        public void set_Status(){} // RVA: 0x7A9727920
        public void get_Zone(){} // RVA: 0x7A8105330
        public void set_Zone(){} // RVA: 0x7A80D8E80
        public void get_Prerequisites(){} // RVA: 0x7A83F69F0
        public void get_Updates(){} // RVA: 0x7A8292C30
        public void get_AdditionalResources(){} // RVA: 0x7A8154D80
        public void CreateResponse(){} // RVA: 0x7AD8B9110
        public void Read(){} // RVA: 0x7AD8B9190
        public void Write(){} // RVA: 0x7AD8B9740
        public void .ctor(){} // RVA: 0x7AD8B9D80
    }

    public class UpdatePrerequisiteList : List`1
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x7AD8BA230
        public void MustNotExist(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7AD8BA420
    }

    public class UpdateResourceList : List`1
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x7AD8BA490
        public void DeleteResource(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7AD8BA7E0
    }

    public class WireReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8BA850
        public void ReadByte(){} // RVA: 0x7AD8BA970
        public void ReadBytes(){} // RVA: 0x7AD8BA9F0
        public void ReadByteLengthPrefixedBytes(){} // RVA: 0x7AD8BAAE0
        public void ReadUInt16LengthPrefixedBytes(){} // RVA: 0x7AD8BAB10
        public void ReadUInt16(){} // RVA: 0x7AD8BAB50
        public void ReadUInt32(){} // RVA: 0x7AD8BAB90
        public void ReadUInt48(){} // RVA: 0x7AD8BAC00
        public void ReadDomainName(){} // RVA: 0x7AD8BACB0
        public void ReadLabels(){} // RVA: 0x7AD8BAD50
        public void ReadString(){} // RVA: 0x7AD8BAF70
        public void ReadTimeSpan16(){} // RVA: 0x7AD8BB220
        public void ReadTimeSpan32(){} // RVA: 0x7AD8BB2F0
        public void ReadIPAddress(){} // RVA: 0x7AD8BB3A0
        public void ReadBitmap(){} // RVA: 0x7AD8BB480
        public void ReadDateTime32(){} // RVA: 0x7AD8BB5D0
        public void ReadDateTime48(){} // RVA: 0x7AD8BB6C0
        public void .cctor(){} // RVA: 0x7AD8BB860
    }

    public class WireWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8BB990
        public void get_CanonicalForm(){} // RVA: 0x7A81B7080
        public void set_CanonicalForm(){} // RVA: 0x7A81B7090
        public void PushLengthPrefixedScope(){} // RVA: 0x7AD8BBB60
        public void PopLengthPrefixedScope(){} // RVA: 0x7AD8BBC40
        public void WriteByte(){} // RVA: 0x7AD8BBDB0
        public void WriteBytes(){} // RVA: 0x7AD8BBDF0
        public void WriteByteLengthPrefixedBytes(){} // RVA: 0x7AD8BBE50
        public void WriteUint16LengthPrefixedBytes(){} // RVA: 0x7AD8BBF70
        public void WriteUInt16(){} // RVA: 0x7AD8BC070
        public void WriteUInt32(){} // RVA: 0x7AD8BC0E0
        public void WriteUInt48(){} // RVA: 0x7AD8BC190
        public void WriteDomainName(){} // RVA: 0x7AD8BC3D0
        public void WriteString(){} // RVA: 0x7AD8BC7C0
        public void WriteTimeSpan16(){} // RVA: 0x7AD8BC9C0
        public void WriteTimeSpan32(){} // RVA: 0x7AD8BCA80
        public void WriteDateTime32(){} // RVA: 0x7AD8BCB00
        public void WriteDateTime48(){} // RVA: 0x7AD8BCC30
        public void WriteIPAddress(){} // RVA: 0x7AD8BCD60
        public void WriteBitmap(){} // RVA: 0x7AD8BCDD0
        public void ToBytes(){} // RVA: 0x7AD8BD710
        public void .cctor(){} // RVA: 0x7AD8BD7D0
    }

}