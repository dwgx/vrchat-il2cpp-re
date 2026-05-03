// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 53
// Methods: 560

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class AAAARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866021C0
    }

    public class AFSDBRecord : ResourceRecord
    {
        public ushort _subtype; // 0x30
        public MeaMod.DNS.Model.DomainName _target; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866028C0
        public void get_Subtype(){} // RVA: 0x7FFE84870400
        public void set_Subtype(){} // RVA: 0x7FFE86602920
        public void get_Target(){} // RVA: 0x7FFE8143BA80
        public void set_Target(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE866029F0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602B20 | overloaded x2
    }

    public class ARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86602BD0
    }

    public class AddressRecord : ResourceRecord
    {
        public System.Net.IPAddress _address; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86602230
        public void get_Address(){} // RVA: 0x7FFE8144E200
        public void set_Address(){} // RVA: 0x7FFE81129890
        public void Create(){} // RVA: 0x7FFE866022A0
        public void ReadData(){} // RVA: 0x7FFE866026A0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602870 | overloaded x2
    }

    public class CNAMERecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _target; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86602C40
        public void get_Target(){} // RVA: 0x7FFE8144E200
        public void set_Target(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86602D10 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602DE0 | overloaded x2
    }

    public class DNAMERecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _target; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86602E40
        public void get_Target(){} // RVA: 0x7FFE8144E200
        public void set_Target(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86602D10 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602DE0 | overloaded x2
    }

    public class DNSKEYRecord : ResourceRecord
    {
        public 0x66682A04 _flags; // 0x30
        public byte _protocol; // 0x32
        public 0x66683EA4 _algorithm; // 0x33
        public byte[] _publicKey; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86602F30 | overloaded x2
        public void get_Flags(){} // RVA: 0x7FFE84870400
        public void set_Flags(){} // RVA: 0x7FFE86602920
        public void get_Protocol(){} // RVA: 0x7FFE848700A0
        public void set_Protocol(){} // RVA: 0x7FFE866032C0
        public void get_Algorithm(){} // RVA: 0x7FFE866032D0
        public void set_Algorithm(){} // RVA: 0x7FFE866032E0
        public void get_PublicKey(){} // RVA: 0x7FFE8143BA80
        public void set_PublicKey(){} // RVA: 0x7FFE81437330
        public void KeyTag(){} // RVA: 0x7FFE866032F0
        public void ReadData(){} // RVA: 0x7FFE86603550 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86603600 | overloaded x2
    }

    public class DSRecord : ResourceRecord
    {
        public ushort _keyTag; // 0x30
        public 0x66683EA4 _algorithm; // 0x32
        public 0x66682954 _hashAlgorithm; // 0x33
        public byte[] _digest; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86603770 | overloaded x2
        public void get_KeyTag(){} // RVA: 0x7FFE84870400
        public void set_KeyTag(){} // RVA: 0x7FFE86602920
        public void get_Algorithm(){} // RVA: 0x7FFE848700A0
        public void set_Algorithm(){} // RVA: 0x7FFE866032C0
        public void get_HashAlgorithm(){} // RVA: 0x7FFE866032D0
        public void set_HashAlgorithm(){} // RVA: 0x7FFE866032E0
        public void get_Digest(){} // RVA: 0x7FFE8143BA80
        public void set_Digest(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE86603C80 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86603DD0 | overloaded x2
    }

    public class DigestRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE865F8740
        public void Create(){} // RVA: 0x7FFE865F8C00 | overloaded x2
    }

    public class DnsObject : Object
    {
        public System.DateTime _creationTime; // 0x10

        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0x7FFE81116380
        public void set_CreationTime(){} // RVA: 0x7FFE826F2ED0
        public void Length(){} // RVA: 0x7FFE865F9090
        public void Clone(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Read(){} // RVA: 0x7FFE80E2E390 | overloaded x4
        public void ToByteArray(){} // RVA: 0x7FFE865F9550
        public void Write(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE865F96E0
    }

    public class DomainName : Object
    {
        public string dot;

        // ── Methods ──
        public void get_Labels(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE865F9800 | overloaded x2
        public void Join(){} // RVA: 0x7FFE865F9910
        public void ToString(){} // RVA: 0x7FFE865F9A10
        public void EscapeLabel(){} // RVA: 0x7FFE865F9AE0
        public void ToCanonical(){} // RVA: 0x7FFE865F9D50
        public void BelongsTo(){} // RVA: 0x7FFE865F9F70
        public void IsSubdomainOf(){} // RVA: 0x7FFE865FA000
        public void Parent(){} // RVA: 0x7FFE865FA180
        public void Parse(){} // RVA: 0x7FFE865FA2D0
        public void GetHashCode(){} // RVA: 0x7FFE865FA5E0
        public void Equals(){} // RVA: 0x7FFE865FA6F0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE865FA850
        public void op_Inequality(){} // RVA: 0x7FFE865FA870
        public void op_Implicit(){} // RVA: 0x7FFE865FA900
        public void LabelsEqual(){} // RVA: 0x7FFE865FA960
        public void .cctor(){} // RVA: 0x7FFE865FAA30
    }

    public class EdnsDAUOption : EdnsOption
    {
        public System.Collections.Generic.List`1<0x66683EA4> _algorithms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FABD0
        public void get_Algorithms(){} // RVA: 0x7FFE810FE7C0
        public void set_Algorithms(){} // RVA: 0x7FFE81161E80
        public void Create(){} // RVA: 0x7FFE865FAC90
        public void ReadData(){} // RVA: 0x7FFE865FAE20
        public void WriteData(){} // RVA: 0x7FFE865FAF80
        public void ToString(){} // RVA: 0x7FFE865FB180
    }

    public class EdnsDHUOption : EdnsOption
    {
        public System.Collections.Generic.List`1<0x66682954> _algorithms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FB270
        public void get_Algorithms(){} // RVA: 0x7FFE810FE7C0
        public void set_Algorithms(){} // RVA: 0x7FFE81161E80
        public void Create(){} // RVA: 0x7FFE865FB330
        public void ReadData(){} // RVA: 0x7FFE865FB4C0
        public void WriteData(){} // RVA: 0x7FFE865FB620
        public void ToString(){} // RVA: 0x7FFE865FB820
    }

    public class EdnsKeepaliveOption : EdnsOption
    {
        public System.Nullable`1<System.TimeSpan> _timeout; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FB890
        public void get_Timeout(){} // RVA: 0x7FFE81703940
        public void set_Timeout(){} // RVA: 0x7FFE817036E0
        public void ReadData(){} // RVA: 0x7FFE865FB8A0
        public void WriteData(){} // RVA: 0x7FFE865FBA00
        public void ToString(){} // RVA: 0x7FFE865FBAF0
    }

    public class EdnsN3UOption : EdnsOption
    {
        public System.Collections.Generic.List`1<0x66682954> _algorithms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FBBA0
        public void get_Algorithms(){} // RVA: 0x7FFE810FE7C0
        public void set_Algorithms(){} // RVA: 0x7FFE81161E80
        public void Create(){} // RVA: 0x7FFE865FBC60
        public void ReadData(){} // RVA: 0x7FFE865FBDF0
        public void WriteData(){} // RVA: 0x7FFE865FBF50
        public void ToString(){} // RVA: 0x7FFE865FC150
    }

    public class EdnsNSIDOption : EdnsOption
    {
        public byte[] _id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FC1C0
        public void get_Id(){} // RVA: 0x7FFE810FE7C0
        public void set_Id(){} // RVA: 0x7FFE81161E80
        public void ReadData(){} // RVA: 0x7FFE865FC1D0
        public void WriteData(){} // RVA: 0x7FFE865FC250
    }

    public class EdnsOption : Object
    {
        public 0x66682ED4 _type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE8299FB40
        public void set_Type(){} // RVA: 0x7FFE8299FB10
        public void ReadData(){} // RVA: 0x7FFE80E4D070
        public void WriteData(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EdnsOptionRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE865FC2B0
        public void Register(){} // RVA: 0x7FFE80E46010
    }

    public class EdnsPaddingOption : EdnsOption
    {
        public byte[] _padding; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FC430
        public void get_Padding(){} // RVA: 0x7FFE810FE7C0
        public void set_Padding(){} // RVA: 0x7FFE81161E80
        public void ReadData(){} // RVA: 0x7FFE865FC1D0
        public void WriteData(){} // RVA: 0x7FFE865FC250
        public void ToString(){} // RVA: 0x7FFE865FC440
    }

    public class HINFORecord : ResourceRecord
    {
        public string _cpu; // 0x30
        public string _oS; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86603F20
        public void get_Cpu(){} // RVA: 0x7FFE8144E200
        public void set_Cpu(){} // RVA: 0x7FFE81129890
        public void get_OS(){} // RVA: 0x7FFE8143BA80
        public void set_OS(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE86604080 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE866041D0 | overloaded x2
    }

    public class IPAddressExtensions : Object
    {
        // ── Methods ──
        public void GetArpaName(){} // RVA: 0x7FFE865FC540
    }

    public class IPresentationSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE80E2E390
        public void Write(){} // RVA: 0x7FFE80E460A0
    }

    public class IResolver
    {
        // ── Methods ──
        public void ResolveAsync(){}
    }

    public class IWireSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE80E2E390
        public void Write(){} // RVA: 0x7FFE80E460A0
    }

    public class MXRecord : ResourceRecord
    {
        public ushort _preference; // 0x30
        public MeaMod.DNS.Model.DomainName _exchange; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86604220
        public void get_Preference(){} // RVA: 0x7FFE84870400
        public void set_Preference(){} // RVA: 0x7FFE86602920
        public void get_Exchange(){} // RVA: 0x7FFE8143BA80
        public void set_Exchange(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE866029F0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602B20 | overloaded x2
    }

    public class Message : DnsObject
    {
        public byte opcode4; // 0x18
        public int MaxLength;
        public int MinLength;
        public ushort _id; // 0x1A
        public bool _qR; // 0x1C
        public bool _aA; // 0x1D
        public bool _tC; // 0x1E
        public bool _rD; // 0x1F
        public bool _rA; // 0x20
        public int _z; // 0x24
        public bool _aD; // 0x28
        public bool _cD; // 0x29
        public 0x666831EC _status; // 0x2A
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.Question> _questions; // 0x30
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> _answers; // 0x38
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> _authorityRecords; // 0x40
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> _additionalRecords; // 0x48
        public object <1hf; // 0xF417

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE863989E0
        public void set_Id(){} // RVA: 0x7FFE865FCE00
        public void get_QR(){} // RVA: 0x7FFE81116390
        public void set_QR(){} // RVA: 0x7FFE811163A0
        public void get_IsQuery(){} // RVA: 0x7FFE865FCE10
        public void get_IsResponse(){} // RVA: 0x7FFE81116390
        public void get_Opcode(){} // RVA: 0x7FFE865FCE20
        public void set_Opcode(){} // RVA: 0x7FFE865FCF30
        public void get_AA(){} // RVA: 0x7FFE82930100
        public void set_AA(){} // RVA: 0x7FFE8292ECA0
        public void get_TC(){} // RVA: 0x7FFE8292F860
        public void set_TC(){} // RVA: 0x7FFE8292DD20
        public void get_RD(){} // RVA: 0x7FFE8292DD30
        public void set_RD(){} // RVA: 0x7FFE8292F560
        public void get_RA(){} // RVA: 0x7FFE811E99D0
        public void set_RA(){} // RVA: 0x7FFE811E99E0
        public void get_Z(){} // RVA: 0x7FFE81A56130
        public void set_Z(){} // RVA: 0x7FFE82447980
        public void get_AD(){} // RVA: 0x7FFE815F1380
        public void set_AD(){} // RVA: 0x7FFE81C15740
        public void get_CD(){} // RVA: 0x7FFE819C2EA0
        public void set_CD(){} // RVA: 0x7FFE8268C820
        public void get_DO(){} // RVA: 0x7FFE865FD090
        public void set_DO(){} // RVA: 0x7FFE865FD150
        public void get_Status(){} // RVA: 0x7FFE82DEC5E0
        public void set_Status(){} // RVA: 0x7FFE82DEC5B0
        public void get_Questions(){} // RVA: 0x7FFE8144E200
        public void get_Answers(){} // RVA: 0x7FFE8143BA80
        public void set_Answers(){} // RVA: 0x7FFE81437330
        public void get_AuthorityRecords(){} // RVA: 0x7FFE81178740
        public void set_AuthorityRecords(){} // RVA: 0x7FFE81123200
        public void get_AdditionalRecords(){} // RVA: 0x7FFE81176730
        public void set_AdditionalRecords(){} // RVA: 0x7FFE81176740
        public void CreateResponse(){} // RVA: 0x7FFE865FD2F0
        public void Truncate(){} // RVA: 0x7FFE865FD3C0
        public void UseDnsSecurity(){} // RVA: 0x7FFE865FD520
        public void Read(){} // RVA: 0x7FFE865FD540
        public void Write(){} // RVA: 0x7FFE865FDB40
        public void ToString(){} // RVA: 0x7FFE865FE330
        public void Stringify(){} // RVA: 0x7FFE865FE9F0
        public void .ctor(){} // RVA: 0x7FFE865FEC30
    }

    public class NSEC3PARAMRecord : ResourceRecord
    {
        public 0x66682954 _hashAlgorithm; // 0x30
        public byte _flags; // 0x31
        public ushort _iterations; // 0x32
        public byte[] _salt; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86604280
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81121450
        public void set_HashAlgorithm(){} // RVA: 0x7FFE81121460
        public void get_Flags(){} // RVA: 0x7FFE81121470
        public void set_Flags(){} // RVA: 0x7FFE81121480
        public void get_Iterations(){} // RVA: 0x7FFE866042E0
        public void set_Iterations(){} // RVA: 0x7FFE866042F0
        public void get_Salt(){} // RVA: 0x7FFE8143BA80
        public void set_Salt(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE866044C0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE866045E0 | overloaded x2
    }

    public class NSEC3Record : ResourceRecord
    {
        public 0x66682954 _hashAlgorithm; // 0x30
        public 0x66683244 _flags; // 0x31
        public ushort _iterations; // 0x32
        public byte[] _salt; // 0x38
        public byte[] _nextHashedOwnerName; // 0x40
        public System.Collections.Generic.List`1<0x66682AB4> _types; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86604750
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81121450
        public void set_HashAlgorithm(){} // RVA: 0x7FFE81121460
        public void get_Flags(){} // RVA: 0x7FFE81121470
        public void set_Flags(){} // RVA: 0x7FFE81121480
        public void get_Iterations(){} // RVA: 0x7FFE866042E0
        public void set_Iterations(){} // RVA: 0x7FFE866042F0
        public void get_Salt(){} // RVA: 0x7FFE8143BA80
        public void set_Salt(){} // RVA: 0x7FFE81437330
        public void get_NextHashedOwnerName(){} // RVA: 0x7FFE81178740
        public void set_NextHashedOwnerName(){} // RVA: 0x7FFE81123200
        public void get_Types(){} // RVA: 0x7FFE81176730
        public void set_Types(){} // RVA: 0x7FFE81176740
        public void ReadData(){} // RVA: 0x7FFE86604D80 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86605110 | overloaded x2
    }

    public class NSECRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _nextOwnerName; // 0x30
        public System.Collections.Generic.List`1<0x66682AB4> _types; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86605580
        public void get_NextOwnerName(){} // RVA: 0x7FFE8144E200
        public void set_NextOwnerName(){} // RVA: 0x7FFE81129890
        public void get_Types(){} // RVA: 0x7FFE8143BA80
        public void set_Types(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE86605AC0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86605BF0 | overloaded x2
    }

    public class NSRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _authority; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86605F20
        public void get_Authority(){} // RVA: 0x7FFE8144E200
        public void set_Authority(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86602D10 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602DE0 | overloaded x2
    }

    public class NULLRecord : ResourceRecord
    {
        public byte[] _data; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86605F80
        public void get_Data(){} // RVA: 0x7FFE8144E200
        public void set_Data(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86606060 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE866060D0
    }

    public class OPTRecord : ResourceRecord
    {
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.EdnsOption> _options; // 0x30
        public object field_1; // 0x65
        public object field_2; // 0x66
        public object field_3; // 0x67
        public object field_4; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86606130
        public void get_RequestorPayloadSize(){} // RVA: 0x7FFE86601D60
        public void set_RequestorPayloadSize(){} // RVA: 0x7FFE86601D70
        public void get_Opcode8(){} // RVA: 0x7FFE86606300
        public void set_Opcode8(){} // RVA: 0x7FFE86606370
        public void get_Version(){} // RVA: 0x7FFE86606410
        public void set_Version(){} // RVA: 0x7FFE86606480
        public void get_DO(){} // RVA: 0x7FFE86606520
        public void set_DO(){} // RVA: 0x7FFE86606580
        public void get_Options(){} // RVA: 0x7FFE8144E200
        public void set_Options(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86606640
        public void WriteData(){} // RVA: 0x7FFE86606800
        public void ToString(){} // RVA: 0x7FFE86606A10
    }

    public class PTRRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _domainName; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86606D40
        public void get_DomainName(){} // RVA: 0x7FFE8144E200
        public void set_DomainName(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86602D10 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86602DE0 | overloaded x2
    }

    public class PresentationReader : Object
    {
        public System.DateTime UnixEpoch;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865FEEB0
        public void get_Origin(){} // RVA: 0x7FFE81178740
        public void set_Origin(){} // RVA: 0x7FFE81123200
        public void ReadByte(){} // RVA: 0x7FFE865FEFD0
        public void ReadUInt16(){} // RVA: 0x7FFE865FF0F0
        public void ReadUInt32(){} // RVA: 0x7FFE865FF210
        public void ReadDomainName(){} // RVA: 0x7FFE865FF2C0
        public void MakeAbsoluteDomainName(){} // RVA: 0x7FFE865FF2F0
        public void ReadString(){} // RVA: 0x7FFE865FF4A0
        public void ReadBase64String(){} // RVA: 0x7FFE865FF4B0
        public void ReadTimeSpan16(){} // RVA: 0x7FFE865FF640
        public void ReadTimeSpan32(){} // RVA: 0x7FFE865FF6F0
        public void ReadIPAddress(){} // RVA: 0x7FFE865FF7A0
        public void ReadDnsType(){} // RVA: 0x7FFE865FF8A0
        public void ReadDateTime(){} // RVA: 0x7FFE865FFAA0
        public void ReadResourceData(){} // RVA: 0x7FFE865FFC80
        public void ReadResourceRecord(){} // RVA: 0x7FFE865FFFD0
        public void IsEndOfLine(){} // RVA: 0x7FFE86600760
        public void ReadToken(){} // RVA: 0x7FFE866008C0
        public void .cctor(){} // RVA: 0x7FFE86600C90
    }

    public class PresentationWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void WriteSpace(){} // RVA: 0x7FFE86600E00
        public void WriteEndOfLine(){} // RVA: 0x7FFE86600E30
        public void WriteByte(){} // RVA: 0x7FFE86600E90
        public void WriteUInt16(){} // RVA: 0x7FFE86600F00
        public void WriteUInt32(){} // RVA: 0x7FFE86600F70
        public void WriteString(){} // RVA: 0x7FFE86600FE0
        public void WriteStringUnencoded(){} // RVA: 0x7FFE866011E0
        public void WriteDomainName(){} // RVA: 0x7FFE86601250
        public void WriteBase16String(){} // RVA: 0x7FFE866012E0
        public void WriteBase64String(){} // RVA: 0x7FFE86601350
        public void WriteTimeSpan16(){} // RVA: 0x7FFE86601490
        public void WriteTimeSpan32(){} // RVA: 0x7FFE86601560
        public void WriteDateTime(){} // RVA: 0x7FFE86601630
        public void WriteIPAddress(){} // RVA: 0x7FFE86601790
        public void WriteDnsType(){} // RVA: 0x7FFE866017F0
        public void WriteDnsClass(){} // RVA: 0x7FFE86601A60
        public void .cctor(){} // RVA: 0x7FFE86601CD0
    }

    public class Question : DnsObject
    {
        public MeaMod.DNS.Model.DomainName _name; // 0x18
        public 0x66682AB4 _type; // 0x20
        public 0x666829AC _class; // 0x22

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void get_Type(){} // RVA: 0x7FFE850EF1D0
        public void set_Type(){} // RVA: 0x7FFE86601D50
        public void get_Class(){} // RVA: 0x7FFE86601D60
        public void set_Class(){} // RVA: 0x7FFE86601D70
        public void Read(){} // RVA: 0x7FFE86601D80
        public void Write(){} // RVA: 0x7FFE86601E60
        public void ToString(){} // RVA: 0x7FFE86601F40
        public void .ctor(){} // RVA: 0x7FFE86602160
    }

    public class RPRecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _mailbox; // 0x30
        public MeaMod.DNS.Model.DomainName _textName; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86606DA0
        public void get_Mailbox(){} // RVA: 0x7FFE8144E200
        public void set_Mailbox(){} // RVA: 0x7FFE81129890
        public void get_TextName(){} // RVA: 0x7FFE8143BA80
        public void set_TextName(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE86606FE0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86607140 | overloaded x2
    }

    public class RRSIGRecord : ResourceRecord
    {
        public 0x66682AB4 _typeCovered; // 0x30
        public 0x66683EA4 _algorithm; // 0x32
        public byte _labels; // 0x33
        public System.TimeSpan _originalTTL; // 0x38
        public System.DateTime _signatureExpiration; // 0x40
        public System.DateTime _signatureInception; // 0x48
        public ushort _keyTag; // 0x50
        public MeaMod.DNS.Model.DomainName _signerName; // 0x58
        public byte[] _signature; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86607210
        public void get_TypeCovered(){} // RVA: 0x7FFE84870400
        public void set_TypeCovered(){} // RVA: 0x7FFE86602920
        public void get_Algorithm(){} // RVA: 0x7FFE848700A0
        public void set_Algorithm(){} // RVA: 0x7FFE866032C0
        public void get_Labels(){} // RVA: 0x7FFE866032D0
        public void set_Labels(){} // RVA: 0x7FFE866032E0
        public void get_OriginalTTL(){} // RVA: 0x7FFE8143BA80
        public void set_OriginalTTL(){} // RVA: 0x7FFE81CDDAA0
        public void get_SignatureExpiration(){} // RVA: 0x7FFE81178740
        public void set_SignatureExpiration(){} // RVA: 0x7FFE84337900
        public void get_SignatureInception(){} // RVA: 0x7FFE81176730
        public void set_SignatureInception(){} // RVA: 0x7FFE82502600
        public void get_KeyTag(){} // RVA: 0x7FFE84E49AB0
        public void set_KeyTag(){} // RVA: 0x7FFE86607270
        public void get_SignerName(){} // RVA: 0x7FFE811C3500
        public void set_SignerName(){} // RVA: 0x7FFE811C3510
        public void get_Signature(){} // RVA: 0x7FFE81199370
        public void set_Signature(){} // RVA: 0x7FFE81199380
        public void ReadData(){} // RVA: 0x7FFE866075C0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86607730 | overloaded x2
    }

    public class ResourceRecord : DnsObject
    {
        public System.TimeSpan DefaultTTL;
        public System.TimeSpan DefaultHostTTL; // 0x8
        public MeaMod.DNS.Model.DomainName _name; // 0x18
        public 0x66682AB4 _type; // 0x20
        public 0x666829AC _class; // 0x22

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void get_CanonicalName(){} // RVA: 0x7FFE8660A6A0
        public void get_Type(){} // RVA: 0x7FFE850EF1D0
        public void set_Type(){} // RVA: 0x7FFE86601D50
        public void get_Class(){} // RVA: 0x7FFE86601D60
        public void set_Class(){} // RVA: 0x7FFE86601D70
        public void get_TTL(){} // RVA: 0x7FFE81129130
        public void set_TTL(){} // RVA: 0x7FFE8164D390
        public void IsExpired(){} // RVA: 0x7FFE8660A6E0
        public void GetDataLength(){} // RVA: 0x7FFE8660A7C0
        public void GetData(){} // RVA: 0x7FFE8660A910
        public void Read(){} // RVA: 0x7FFE8660B830 | overloaded x3
        public void ReadData(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Write(){} // RVA: 0x7FFE8660B480 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE8660B640 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE8660ADF0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void op_Inequality(){} // RVA: 0x7FFE8660AFA0
        public void GetHashCode(){} // RVA: 0x7FFE8660AFE0
        public void ToString(){} // RVA: 0x7FFE8660B260
        public void .ctor(){} // RVA: 0x7FFE8660B850
        public void .cctor(){} // RVA: 0x7FFE8660B900
    }

    public class ResourceRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8660BAC0
        public void Register(){} // RVA: 0x7FFE80E46010
        public void Create(){} // RVA: 0x7FFE8660BE30
    }

    public class SOARecord : ResourceRecord
    {
        public MeaMod.DNS.Model.DomainName _primaryName; // 0x30
        public MeaMod.DNS.Model.DomainName _mailbox; // 0x38
        public uint _serialNumber; // 0x40
        public System.TimeSpan _refresh; // 0x48
        public System.TimeSpan _retry; // 0x50
        public System.TimeSpan _expire; // 0x58
        public System.TimeSpan _minimum; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866078F0
        public void get_PrimaryName(){} // RVA: 0x7FFE8144E200
        public void set_PrimaryName(){} // RVA: 0x7FFE81129890
        public void get_Mailbox(){} // RVA: 0x7FFE8143BA80
        public void set_Mailbox(){} // RVA: 0x7FFE81437330
        public void get_SerialNumber(){} // RVA: 0x7FFE8119C080
        public void set_SerialNumber(){} // RVA: 0x7FFE8119C090
        public void get_Refresh(){} // RVA: 0x7FFE81176730
        public void set_Refresh(){} // RVA: 0x7FFE82502600
        public void get_Retry(){} // RVA: 0x7FFE8119C0E0
        public void set_Retry(){} // RVA: 0x7FFE82506C00
        public void get_Expire(){} // RVA: 0x7FFE811C3500
        public void set_Expire(){} // RVA: 0x7FFE825093B0
        public void get_Minimum(){} // RVA: 0x7FFE81199370
        public void set_Minimum(){} // RVA: 0x7FFE866079C0
        public void ReadData(){} // RVA: 0x7FFE86607B10 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86607D10 | overloaded x2
    }

    public class SRVRecord : ResourceRecord
    {
        public ushort _priority; // 0x30
        public ushort _weight; // 0x32
        public ushort _port; // 0x34
        public MeaMod.DNS.Model.DomainName _target; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86607F10
        public void get_Priority(){} // RVA: 0x7FFE84870400
        public void set_Priority(){} // RVA: 0x7FFE86602920
        public void get_Weight(){} // RVA: 0x7FFE866042E0
        public void set_Weight(){} // RVA: 0x7FFE866042F0
        public void get_Port(){} // RVA: 0x7FFE86607F70
        public void set_Port(){} // RVA: 0x7FFE86607F80
        public void get_Target(){} // RVA: 0x7FFE8143BA80
        public void set_Target(){} // RVA: 0x7FFE81437330
        public void ReadData(){} // RVA: 0x7FFE86608090 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86608290 | overloaded x2
    }

    public class SecurityAlgorithmRegistry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8660BF50
        public void GetMetadata(){} // RVA: 0x7FFE8660C560
    }

    public class TKEYRecord : ResourceRecord
    {
        public byte[] NoData;
        public MeaMod.DNS.Model.DomainName _algorithm; // 0x30
        public System.DateTime _inception; // 0x38
        public System.DateTime _expiration; // 0x40
        public 0x666830E4 _mode; // 0x48
        public 0x666831EC _error; // 0x4A
        public byte[] _key; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866083D0
        public void get_Algorithm(){} // RVA: 0x7FFE8144E200
        public void set_Algorithm(){} // RVA: 0x7FFE81129890
        public void get_Inception(){} // RVA: 0x7FFE8143BA80
        public void set_Inception(){} // RVA: 0x7FFE81CDDAA0
        public void get_Expiration(){} // RVA: 0x7FFE81178740
        public void set_Expiration(){} // RVA: 0x7FFE84337900
        public void get_Mode(){} // RVA: 0x7FFE86608520
        public void set_Mode(){} // RVA: 0x7FFE86608530
        public void get_Error(){} // RVA: 0x7FFE82446000
        public void set_Error(){} // RVA: 0x7FFE82444AD0
        public void get_Key(){} // RVA: 0x7FFE8119C0E0
        public void set_Key(){} // RVA: 0x7FFE812534D0
        public void get_OtherData(){} // RVA: 0x7FFE811C3500
        public void set_OtherData(){} // RVA: 0x7FFE811C3510
        public void ReadData(){} // RVA: 0x7FFE86608870 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86608BA0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86608D60
    }

    public class TSIGRecord : ResourceRecord
    {
        public byte[] NoData;
        public string HMACMD5;
        public string GSSTSIG;
        public string HMACSHA1;
        public string HMACSHA224;
        public string HMACSHA256;
        public string HMACSHA384;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86608E10
        public void get_Algorithm(){} // RVA: 0x7FFE8144E200
        public void set_Algorithm(){} // RVA: 0x7FFE81129890
        public void get_TimeSigned(){} // RVA: 0x7FFE8143BA80
        public void set_TimeSigned(){} // RVA: 0x7FFE81CDDAA0
        public void get_MAC(){} // RVA: 0x7FFE81178740
        public void set_MAC(){} // RVA: 0x7FFE81123200
        public void get_Fudge(){} // RVA: 0x7FFE81176730
        public void set_Fudge(){} // RVA: 0x7FFE82502600
        public void get_OriginalMessageId(){} // RVA: 0x7FFE84E49AB0
        public void set_OriginalMessageId(){} // RVA: 0x7FFE86607270
        public void get_Error(){} // RVA: 0x7FFE82976140
        public void set_Error(){} // RVA: 0x7FFE82975450
        public void get_OtherData(){} // RVA: 0x7FFE811C3500
        public void set_OtherData(){} // RVA: 0x7FFE811C3510
        public void ReadData(){} // RVA: 0x7FFE866099A0 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE86609D60 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86609FB0
    }

    public class TXTRecord : ResourceRecord
    {
        public System.Collections.Generic.List`1<string> _strings; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8660A060
        public void get_Strings(){} // RVA: 0x7FFE8144E200
        public void set_Strings(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE8660A270 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE8660A4A0 | overloaded x2
    }

    public class UnknownEdnsOption : EdnsOption
    {
        public byte[] _data; // 0x18

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE810FE7C0
        public void set_Data(){} // RVA: 0x7FFE81161E80
        public void ReadData(){} // RVA: 0x7FFE865FC1D0
        public void WriteData(){} // RVA: 0x7FFE865FC250
        public void ToString(){} // RVA: 0x7FFE8660C710
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnknownRecord : ResourceRecord
    {
        public byte[] _data; // 0x30

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE8144E200
        public void set_Data(){} // RVA: 0x7FFE81129890
        public void ReadData(){} // RVA: 0x7FFE86606060 | overloaded x2
        public void WriteData(){} // RVA: 0x7FFE866060D0
        public void .ctor(){} // RVA: 0x7FFE8660A650
    }

    public class UpdateMessage : DnsObject
    {
        public ushort _id; // 0x18
        public bool _qR; // 0x1A
        public 0x66683194 _opcode; // 0x1C
        public int _z; // 0x20
        public 0x666831EC _status; // 0x24
        public MeaMod.DNS.Model.Question _zone; // 0x28
        public MeaMod.DNS.Model.UpdatePrerequisiteList _prerequisites; // 0x30
        public MeaMod.DNS.Model.UpdateResourceList _updates; // 0x38
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> _additionalResources; // 0x40
        public object field_9; // 0x99
        public object field_10; // 0x9A

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE84290FC0
        public void set_Id(){} // RVA: 0x7FFE850AB060
        public void get_QR(){} // RVA: 0x7FFE82930110
        public void set_QR(){} // RVA: 0x7FFE8292DD10
        public void get_IsUpdate(){} // RVA: 0x7FFE8660C8C0
        public void get_IsResponse(){} // RVA: 0x7FFE82930110
        public void get_Opcode(){} // RVA: 0x7FFE8660C8D0
        public void set_Opcode(){} // RVA: 0x7FFE8660C8E0
        public void get_Z(){} // RVA: 0x7FFE8151D690
        public void set_Z(){} // RVA: 0x7FFE8170B670
        public void get_Status(){} // RVA: 0x7FFE811167C0
        public void set_Status(){} // RVA: 0x7FFE812EB1B0
        public void get_Zone(){} // RVA: 0x7FFE81129130
        public void set_Zone(){} // RVA: 0x7FFE810FCE90
        public void get_Prerequisites(){} // RVA: 0x7FFE8144E200
        public void get_Updates(){} // RVA: 0x7FFE8143BA80
        public void get_AdditionalResources(){} // RVA: 0x7FFE81178740
        public void CreateResponse(){} // RVA: 0x7FFE8660C8F0
        public void Read(){} // RVA: 0x7FFE8660C970
        public void Write(){} // RVA: 0x7FFE8660CF10
        public void .ctor(){} // RVA: 0x7FFE8660D540
    }

    public class UpdatePrerequisiteList : List`1
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x7FFE8660D9F0 | overloaded x4
        public void MustNotExist(){} // RVA: 0x7FFE80E2E390 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE8660DBE0
    }

    public class UpdateResourceList : List`1
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x7FFE8660DC50
        public void DeleteResource(){} // RVA: 0x7FFE80E2E390 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE8660DFA0
    }

    public class WireReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8660E010
        public void ReadByte(){} // RVA: 0x7FFE8660E130
        public void ReadBytes(){} // RVA: 0x7FFE8660E1B0
        public void ReadByteLengthPrefixedBytes(){} // RVA: 0x7FFE8660E2A0
        public void ReadUInt16LengthPrefixedBytes(){} // RVA: 0x7FFE8660E2D0
        public void ReadUInt16(){} // RVA: 0x7FFE8660E310
        public void ReadUInt32(){} // RVA: 0x7FFE8660E350
        public void ReadUInt48(){} // RVA: 0x7FFE8660E3C0
        public void ReadDomainName(){} // RVA: 0x7FFE8660E470
        public void ReadLabels(){} // RVA: 0x7FFE8660E510
        public void ReadString(){} // RVA: 0x7FFE8660E730
        public void ReadTimeSpan16(){} // RVA: 0x7FFE8660E9F0
        public void ReadTimeSpan32(){} // RVA: 0x7FFE8660EAC0
        public void ReadIPAddress(){} // RVA: 0x7FFE8660EB70
        public void ReadBitmap(){} // RVA: 0x7FFE8660EC50
        public void ReadDateTime32(){} // RVA: 0x7FFE8660EDA0
        public void ReadDateTime48(){} // RVA: 0x7FFE8660EE90
        public void .cctor(){} // RVA: 0x7FFE8660F030
    }

    public class WireWriter : Object
    {
        public int maxPointer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8660F160
        public void get_CanonicalForm(){} // RVA: 0x7FFE811DA230
        public void set_CanonicalForm(){} // RVA: 0x7FFE811DA240
        public void PushLengthPrefixedScope(){} // RVA: 0x7FFE8660F330
        public void PopLengthPrefixedScope(){} // RVA: 0x7FFE8660F410
        public void WriteByte(){} // RVA: 0x7FFE8660F580
        public void WriteBytes(){} // RVA: 0x7FFE8660F5C0
        public void WriteByteLengthPrefixedBytes(){} // RVA: 0x7FFE8660F620
        public void WriteUint16LengthPrefixedBytes(){} // RVA: 0x7FFE8660F740
        public void WriteUInt16(){} // RVA: 0x7FFE8660F840
        public void WriteUInt32(){} // RVA: 0x7FFE8660F8B0
        public void WriteUInt48(){} // RVA: 0x7FFE8660F960
        public void WriteDomainName(){} // RVA: 0x7FFE8660FBA0 | overloaded x2
        public void WriteString(){} // RVA: 0x7FFE8660FF70
        public void WriteTimeSpan16(){} // RVA: 0x7FFE86610170
        public void WriteTimeSpan32(){} // RVA: 0x7FFE86610230
        public void WriteDateTime32(){} // RVA: 0x7FFE866102B0
        public void WriteDateTime48(){} // RVA: 0x7FFE866103E0
        public void WriteIPAddress(){} // RVA: 0x7FFE86610510
        public void WriteBitmap(){} // RVA: 0x7FFE86610580
        public void ToBytes(){} // RVA: 0x7FFE86610EB0
        public void .cctor(){} // RVA: 0x7FFE86610F70
    }

}