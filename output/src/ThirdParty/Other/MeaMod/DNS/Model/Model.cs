// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Model
// Classes: 60
// Methods: 599

namespace ThirdParty.Other.MeaMod.DNS.Model
{
    public class AAAARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x653BCD0
    }

    public class AFSDBRecord : ResourceRecord
    {
        public object _subtype;
        public object _target;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653C3D0
        public void get_Subtype(){} // RVA: 0x4674E80
        public void set_Subtype(){} // RVA: 0x653C430
        public void get_Target(){} // RVA: 0xD05CA0
        public void set_Target(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x653C500
        public void WriteData(){} // RVA: 0x653C630
    }

    public class ARecord : AddressRecord
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x653C6E0
    }

    public class ARecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AddressRecord : ResourceRecord
    {
        public object _address;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653BD40
        public void get_Address(){} // RVA: 0xD33E60
        public void set_Address(){} // RVA: 0xB708C0
        public void Create(){} // RVA: 0x653BDB0
        public void ReadData(){} // RVA: 0x653C1B0
        public void WriteData(){} // RVA: 0x653C380
    }

    public class CNAMERecord : ResourceRecord
    {
        public object _target;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653C750
        public void get_Target(){} // RVA: 0xD33E60
        public void set_Target(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x653C820
        public void WriteData(){} // RVA: 0x653C8F0
    }

    public class DNAMERecord : ResourceRecord
    {
        public object _target;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653C950
        public void get_Target(){} // RVA: 0xD33E60
        public void set_Target(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x653C820
        public void WriteData(){} // RVA: 0x653C8F0
    }

    public class DNSKEYRecord : ResourceRecord
    {
        public object _flags;
        public object _protocol;
        public object _algorithm;
        public object _publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653CA40
        public void get_Flags(){} // RVA: 0x4674E80
        public void set_Flags(){} // RVA: 0x653C430
        public void get_Protocol(){} // RVA: 0x4674B20
        public void set_Protocol(){} // RVA: 0x653CDE0
        public void get_Algorithm(){} // RVA: 0x653CDF0
        public void set_Algorithm(){} // RVA: 0x653CE00
        public void get_PublicKey(){} // RVA: 0xD05CA0
        public void set_PublicKey(){} // RVA: 0xD09D70
        public void KeyTag(){} // RVA: 0x653CE10
        public void ReadData(){} // RVA: 0x653D0A0
        public void WriteData(){} // RVA: 0x653D150
    }

    public class DSRecord : ResourceRecord
    {
        public object _keyTag;
        public object _algorithm;
        public object _hashAlgorithm;
        public object _digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653D2C0
        public void get_KeyTag(){} // RVA: 0x4674E80
        public void set_KeyTag(){} // RVA: 0x653C430
        public void get_Algorithm(){} // RVA: 0x4674B20
        public void set_Algorithm(){} // RVA: 0x653CDE0
        public void get_HashAlgorithm(){} // RVA: 0x653CDF0
        public void set_HashAlgorithm(){} // RVA: 0x653CE00
        public void get_Digest(){} // RVA: 0xD05CA0
        public void set_Digest(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x653D7E0
        public void WriteData(){} // RVA: 0x653D930
    }

    public class DigestRegistry : Object
    {
        public object Digests;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6532250
        public void Create(){} // RVA: 0x6532710
    }

    public class DnsObject : Object
    {
        public object _creationTime;

        // ── Methods ──
        public void get_CreationTime(){} // RVA: 0xB5DBF0
        public void set_CreationTime(){} // RVA: 0x2230E30
        public void Length(){} // RVA: 0x6532BA0
        public void Clone(){} // RVA: 0x306E730
        public void Read(){} // RVA: 0x87C540
        public void ToByteArray(){} // RVA: 0x6533070
        public void Write(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x6533210
    }

    public class DnsType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBD500
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7AB0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E755F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DomainName : Object
    {
        public object dot;
        public object dotChar;
        public object escapedDot;
        public object backslash;
        public object backslashChar;
        public object escapedBackslash;
        public object Root;
        public object labels;

        // ── Methods ──
        public void get_Labels(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x6533330
        public void Join(){} // RVA: 0x6533440
        public void ToString(){} // RVA: 0x6533550
        public void EscapeLabel(){} // RVA: 0x6533620
        public void ToCanonical(){} // RVA: 0x6533890
        public void BelongsTo(){} // RVA: 0x6533AB0
        public void IsSubdomainOf(){} // RVA: 0x6533B40
        public void Parent(){} // RVA: 0x6533D00
        public void Parse(){} // RVA: 0x6533E50
        public void GetHashCode(){} // RVA: 0x6534140
        public void Equals(){} // RVA: 0x6534250
        public void op_Equality(){} // RVA: 0x65343E0
        public void op_Inequality(){} // RVA: 0x6534400
        public void op_Implicit(){} // RVA: 0x6534490
        public void LabelsEqual(){} // RVA: 0x65344F0
        public void .cctor(){} // RVA: 0x65345C0
    }

    public class DomainName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EdnsDAUOption : EdnsOption
    {
        public object _algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6534750
        public void get_Algorithms(){} // RVA: 0xB465B0
        public void set_Algorithms(){} // RVA: 0xBA9BA0
        public void Create(){} // RVA: 0x6534810
        public void ReadData(){} // RVA: 0x65349A0
        public void WriteData(){} // RVA: 0x6534B00
        public void ToString(){} // RVA: 0x6534D10
    }

    public class EdnsDHUOption : EdnsOption
    {
        public object _algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6534DE0
        public void get_Algorithms(){} // RVA: 0xB465B0
        public void set_Algorithms(){} // RVA: 0xBA9BA0
        public void Create(){} // RVA: 0x6534EA0
        public void ReadData(){} // RVA: 0x6535030
        public void WriteData(){} // RVA: 0x6535190
        public void ToString(){} // RVA: 0x65353A0
    }

    public class EdnsKeepaliveOption : EdnsOption
    {
        public object _timeout;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6535410
        public void get_Timeout(){} // RVA: 0x125EE60
        public void set_Timeout(){} // RVA: 0x125D9D0
        public void ReadData(){} // RVA: 0x6535420
        public void WriteData(){} // RVA: 0x6535570
        public void ToString(){} // RVA: 0x6535660
    }

    public class EdnsN3UOption : EdnsOption
    {
        public object _algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6535710
        public void get_Algorithms(){} // RVA: 0xB465B0
        public void set_Algorithms(){} // RVA: 0xBA9BA0
        public void Create(){} // RVA: 0x65357D0
        public void ReadData(){} // RVA: 0x6535960
        public void WriteData(){} // RVA: 0x6535AC0
        public void ToString(){} // RVA: 0x6535CD0
    }

    public class EdnsNSIDOption : EdnsOption
    {
        public object _id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6535D40
        public void get_Id(){} // RVA: 0xB465B0
        public void set_Id(){} // RVA: 0xBA9BA0
        public void ReadData(){} // RVA: 0x6535D50
        public void WriteData(){} // RVA: 0x6535DD0
    }

    public class EdnsOption : Object
    {
        public object _type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x24EA1D0
        public void set_Type(){} // RVA: 0x24EAB10
        public void ReadData(){} // RVA: 0x899290
        public void WriteData(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EdnsOptionRegistry : Object
    {
        public object Options;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6535E30
        public void Register(){} // RVA: 0x8942F0
    }

    public class EdnsOption[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EdnsPaddingOption : EdnsOption
    {
        public object _padding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6535FB0
        public void get_Padding(){} // RVA: 0xB465B0
        public void set_Padding(){} // RVA: 0xBA9BA0
        public void ReadData(){} // RVA: 0x6535D50
        public void WriteData(){} // RVA: 0x6535DD0
        public void ToString(){} // RVA: 0x6535FC0
    }

    public class HINFORecord : ResourceRecord
    {
        public object _cpu;
        public object _oS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653DA80
        public void get_Cpu(){} // RVA: 0xD33E60
        public void set_Cpu(){} // RVA: 0xB708C0
        public void get_OS(){} // RVA: 0xD05CA0
        public void set_OS(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x653DBE0
        public void WriteData(){} // RVA: 0x653DD30
    }

    public class IPAddressExtensions : Object
    {
        // ── Methods ──
        public void GetArpaName(){} // RVA: 0x65360C0
    }

    public class IPresentationSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x87C540
        public void Write(){} // RVA: 0x894320
    }

    public class IResolver
    {
        // ── Methods ──
        public void ResolveAsync(){} // RVA: 0x881FC0
    }

    public class IWireSerialiser
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x87C540
        public void Write(){} // RVA: 0x894320
    }

    public class MXRecord : ResourceRecord
    {
        public object _preference;
        public object _exchange;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653DD80
        public void get_Preference(){} // RVA: 0x4674E80
        public void set_Preference(){} // RVA: 0x653C430
        public void get_Exchange(){} // RVA: 0xD05CA0
        public void set_Exchange(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x653C500
        public void WriteData(){} // RVA: 0x653C630
    }

    public class Message : DnsObject
    {
        public object opcode4;
        public object MaxLength;
        public object MinLength;
        public object _id;
        public object _qR;
        public object _aA;
        public object _tC;
        public object _rD;
        public object _rA;
        public object _z;
        public object _aD;
        public object _cD;
        public object _status;
        public object _questions;
        public object _answers;
        public object _authorityRecords;
        public object _additionalRecords;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x31D74B0
        public void set_Id(){} // RVA: 0x6536960
        public void get_QR(){} // RVA: 0xB5DC00
        public void set_QR(){} // RVA: 0xB5DC10
        public void get_IsQuery(){} // RVA: 0x6536970
        public void get_IsResponse(){} // RVA: 0xB5DC00
        public void get_Opcode(){} // RVA: 0x6536980
        public void set_Opcode(){} // RVA: 0x6536A90
        public void get_AA(){} // RVA: 0x246F120
        public void set_AA(){} // RVA: 0x246E520
        public void get_TC(){} // RVA: 0x246F670
        public void set_TC(){} // RVA: 0x246E530
        public void get_RD(){} // RVA: 0x246E8F0
        public void set_RD(){} // RVA: 0x246E510
        public void get_RA(){} // RVA: 0xC38360
        public void set_RA(){} // RVA: 0xC38370
        public void get_Z(){} // RVA: 0x15AF000
        public void set_Z(){} // RVA: 0x1FAA840
        public void get_AD(){} // RVA: 0xF73960
        public void set_AD(){} // RVA: 0xF73A60
        public void get_CD(){} // RVA: 0x14F7430
        public void set_CD(){} // RVA: 0x21CBB70
        public void get_DO(){} // RVA: 0x6536BF0
        public void set_DO(){} // RVA: 0x6536CB0
        public void get_Status(){} // RVA: 0x28E58A0
        public void set_Status(){} // RVA: 0x28E5890
        public void get_Questions(){} // RVA: 0xD33E60
        public void get_Answers(){} // RVA: 0xD05CA0
        public void set_Answers(){} // RVA: 0xD09D70
        public void get_AuthorityRecords(){} // RVA: 0xBC1B30
        public void set_AuthorityRecords(){} // RVA: 0xB6A8C0
        public void get_AdditionalRecords(){} // RVA: 0xBBF8F0
        public void set_AdditionalRecords(){} // RVA: 0xBBF900
        public void CreateResponse(){} // RVA: 0x6536E50
        public void Truncate(){} // RVA: 0x6536F20
        public void UseDnsSecurity(){} // RVA: 0x6537080
        public void Read(){} // RVA: 0x65370A0
        public void Write(){} // RVA: 0x65376B0
        public void ToString(){} // RVA: 0x6537EB0
        public void Stringify(){} // RVA: 0x6538580
        public void .ctor(){} // RVA: 0x65387D0
    }

    public class NSEC3PARAMRecord : ResourceRecord
    {
        public object _hashAlgorithm;
        public object _flags;
        public object _iterations;
        public object _salt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653DDE0
        public void get_HashAlgorithm(){} // RVA: 0xB68DF0
        public void set_HashAlgorithm(){} // RVA: 0xB68E00
        public void get_Flags(){} // RVA: 0xB68E10
        public void set_Flags(){} // RVA: 0xB68E20
        public void get_Iterations(){} // RVA: 0x653DE40
        public void set_Iterations(){} // RVA: 0x653DE50
        public void get_Salt(){} // RVA: 0xD05CA0
        public void set_Salt(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x653E020
        public void WriteData(){} // RVA: 0x653E140
    }

    public class NSEC3Record : ResourceRecord
    {
        public object _hashAlgorithm;
        public object _flags;
        public object _iterations;
        public object _salt;
        public object _nextHashedOwnerName;
        public object _types;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653E2B0
        public void get_HashAlgorithm(){} // RVA: 0xB68DF0
        public void set_HashAlgorithm(){} // RVA: 0xB68E00
        public void get_Flags(){} // RVA: 0xB68E10
        public void set_Flags(){} // RVA: 0xB68E20
        public void get_Iterations(){} // RVA: 0x653DE40
        public void set_Iterations(){} // RVA: 0x653DE50
        public void get_Salt(){} // RVA: 0xD05CA0
        public void set_Salt(){} // RVA: 0xD09D70
        public void get_NextHashedOwnerName(){} // RVA: 0xBC1B30
        public void set_NextHashedOwnerName(){} // RVA: 0xB6A8C0
        public void get_Types(){} // RVA: 0xBBF8F0
        public void set_Types(){} // RVA: 0xBBF900
        public void ReadData(){} // RVA: 0x653E8E0
        public void WriteData(){} // RVA: 0x653EC90
    }

    public class NSECRecord : ResourceRecord
    {
        public object _nextOwnerName;
        public object _types;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653F110
        public void get_NextOwnerName(){} // RVA: 0xD33E60
        public void set_NextOwnerName(){} // RVA: 0xB708C0
        public void get_Types(){} // RVA: 0xD05CA0
        public void set_Types(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x653F650
        public void WriteData(){} // RVA: 0x653F780
    }

    public class NSRecord : ResourceRecord
    {
        public object _authority;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653FAC0
        public void get_Authority(){} // RVA: 0xD33E60
        public void set_Authority(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x653C820
        public void WriteData(){} // RVA: 0x653C8F0
    }

    public class NULLRecord : ResourceRecord
    {
        public object _data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653FB20
        public void get_Data(){} // RVA: 0xD33E60
        public void set_Data(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x653FC00
        public void WriteData(){} // RVA: 0x653FC70
    }

    public class OPTRecord : ResourceRecord
    {
        public object _options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x653FCD0
        public void get_RequestorPayloadSize(){} // RVA: 0x653B860
        public void set_RequestorPayloadSize(){} // RVA: 0x653B870
        public void get_Opcode8(){} // RVA: 0x653FEA0
        public void set_Opcode8(){} // RVA: 0x653FF10
        public void get_Version(){} // RVA: 0x653FFB0
        public void set_Version(){} // RVA: 0x6540020
        public void get_DO(){} // RVA: 0x65400C0
        public void set_DO(){} // RVA: 0x6540120
        public void get_Options(){} // RVA: 0xD33E60
        public void set_Options(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x65401E0
        public void WriteData(){} // RVA: 0x65403A0
        public void ToString(){} // RVA: 0x65405A0
    }

    public class PTRRecord : ResourceRecord
    {
        public object _domainName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65408C0
        public void get_DomainName(){} // RVA: 0xD33E60
        public void set_DomainName(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x653C820
        public void WriteData(){} // RVA: 0x653C8F0
    }

    public class PTRRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PresentationReader : Object
    {
        public object UnixEpoch;
        public object text;
        public object defaultTTL;
        public object defaultDomainName;
        public object parenLevel;
        public object previousChar;
        public object eolSeen;
        public object tokenStartsNewLine;
        public object Position;
        public object _origin;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6538A50
        public void get_Origin(){} // RVA: 0xBC1B30
        public void set_Origin(){} // RVA: 0xB6A8C0
        public void ReadByte(){} // RVA: 0x6538B70
        public void ReadUInt16(){} // RVA: 0x6538C90
        public void ReadUInt32(){} // RVA: 0x6538DB0
        public void ReadDomainName(){} // RVA: 0x6538E60
        public void MakeAbsoluteDomainName(){} // RVA: 0x6538E90
        public void ReadString(){} // RVA: 0x6539040
        public void ReadBase64String(){} // RVA: 0x6539050
        public void ReadTimeSpan16(){} // RVA: 0x65391E0
        public void ReadTimeSpan32(){} // RVA: 0x6539290
        public void ReadIPAddress(){} // RVA: 0x6539340
        public void ReadDnsType(){} // RVA: 0x6539440
        public void ReadDateTime(){} // RVA: 0x6539670
        public void ReadResourceData(){} // RVA: 0x6539850
        public void ReadResourceRecord(){} // RVA: 0x6539BA0
        public void IsEndOfLine(){} // RVA: 0x653A340
        public void ReadToken(){} // RVA: 0x653A4A0
        public void .cctor(){} // RVA: 0x653A860
    }

    public class PresentationWriter : Object
    {
        public object UnixEpoch;
        public object text;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void WriteSpace(){} // RVA: 0x653A9F0
        public void WriteEndOfLine(){} // RVA: 0x653AA20
        public void WriteByte(){} // RVA: 0x653AA80
        public void WriteUInt16(){} // RVA: 0x653AAF0
        public void WriteUInt32(){} // RVA: 0x653AB60
        public void WriteString(){} // RVA: 0x653ABD0
        public void WriteStringUnencoded(){} // RVA: 0x653ADC0
        public void WriteDomainName(){} // RVA: 0x653AE30
        public void WriteBase16String(){} // RVA: 0x653AEC0
        public void WriteBase64String(){} // RVA: 0x653AF30
        public void WriteTimeSpan16(){} // RVA: 0x653B070
        public void WriteTimeSpan32(){} // RVA: 0x653B140
        public void WriteDateTime(){} // RVA: 0x653B210
        public void WriteIPAddress(){} // RVA: 0x653B370
        public void WriteDnsType(){} // RVA: 0x653B3D0
        public void WriteDnsClass(){} // RVA: 0x653B5D0
        public void .cctor(){} // RVA: 0x653B7D0
    }

    public class Question : DnsObject
    {
        public object _name;
        public object _type;
        public object _class;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xBA9BA0
        public void get_Type(){} // RVA: 0x4FEF950
        public void set_Type(){} // RVA: 0x653B850
        public void get_Class(){} // RVA: 0x653B860
        public void set_Class(){} // RVA: 0x653B870
        public void Read(){} // RVA: 0x653B880
        public void Write(){} // RVA: 0x653B960
        public void ToString(){} // RVA: 0x653BA40
        public void .ctor(){} // RVA: 0x653BC70
    }

    public class Question[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RPRecord : ResourceRecord
    {
        public object _mailbox;
        public object _textName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6540920
        public void get_Mailbox(){} // RVA: 0xD33E60
        public void set_Mailbox(){} // RVA: 0xB708C0
        public void get_TextName(){} // RVA: 0xD05CA0
        public void set_TextName(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x6540B60
        public void WriteData(){} // RVA: 0x6540CC0
    }

    public class RRSIGRecord : ResourceRecord
    {
        public object _typeCovered;
        public object _algorithm;
        public object _labels;
        public object _originalTTL;
        public object _signatureExpiration;
        public object _signatureInception;
        public object _keyTag;
        public object _signerName;
        public object _signature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6540D90
        public void get_TypeCovered(){} // RVA: 0x4674E80
        public void set_TypeCovered(){} // RVA: 0x653C430
        public void get_Algorithm(){} // RVA: 0x4674B20
        public void set_Algorithm(){} // RVA: 0x653CDE0
        public void get_Labels(){} // RVA: 0x653CDF0
        public void set_Labels(){} // RVA: 0x653CE00
        public void get_OriginalTTL(){} // RVA: 0xD05CA0
        public void set_OriginalTTL(){} // RVA: 0xE9F6B0
        public void get_SignatureExpiration(){} // RVA: 0xBC1B30
        public void set_SignatureExpiration(){} // RVA: 0xE9E8B0
        public void get_SignatureInception(){} // RVA: 0xBBF8F0
        public void set_SignatureInception(){} // RVA: 0x20633C0
        public void get_KeyTag(){} // RVA: 0x4CCE2D0
        public void set_KeyTag(){} // RVA: 0x6540DF0
        public void get_SignerName(){} // RVA: 0xC0FFC0
        public void set_SignerName(){} // RVA: 0xC0FFD0
        public void get_Signature(){} // RVA: 0xBE2C60
        public void set_Signature(){} // RVA: 0xBE2C70
        public void ReadData(){} // RVA: 0x6541140
        public void WriteData(){} // RVA: 0x65412B0
    }

    public class ResourceRecord : DnsObject
    {
        public object DefaultTTL;
        public object DefaultHostTTL;
        public object _name;
        public object _type;
        public object _class;
        public object _tTL;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xBA9BA0
        public void get_CanonicalName(){} // RVA: 0x6544240
        public void get_Type(){} // RVA: 0x4FEF950
        public void set_Type(){} // RVA: 0x653B850
        public void get_Class(){} // RVA: 0x653B860
        public void set_Class(){} // RVA: 0x653B870
        public void get_TTL(){} // RVA: 0xB70160
        public void set_TTL(){} // RVA: 0x116B360
        public void IsExpired(){} // RVA: 0x6544280
        public void GetDataLength(){} // RVA: 0x6544360
        public void GetData(){} // RVA: 0x65444B0
        public void Read(){} // RVA: 0x65453B0
        public void ReadData(){} // RVA: 0xB43310
        public void Write(){} // RVA: 0x6545000
        public void WriteData(){} // RVA: 0x65451C0
        public void Equals(){} // RVA: 0x6544990
        public void op_Equality(){} // RVA: 0x6544B10
        public void op_Inequality(){} // RVA: 0x6544B40
        public void GetHashCode(){} // RVA: 0x6544B80
        public void ToString(){} // RVA: 0x6544DF0
        public void .ctor(){} // RVA: 0x65453D0
        public void .cctor(){} // RVA: 0x6545480
    }

    public class ResourceRecord[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ResourceRegistry : Object
    {
        public object Records;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6545630
        public void Register(){} // RVA: 0x29A3F80
        public void Create(){} // RVA: 0x65459A0
    }

    public class SOARecord : ResourceRecord
    {
        public object _primaryName;
        public object _mailbox;
        public object _serialNumber;
        public object _refresh;
        public object _retry;
        public object _expire;
        public object _minimum;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6541470
        public void get_PrimaryName(){} // RVA: 0xD33E60
        public void set_PrimaryName(){} // RVA: 0xB708C0
        public void get_Mailbox(){} // RVA: 0xD05CA0
        public void set_Mailbox(){} // RVA: 0xD09D70
        public void get_SerialNumber(){} // RVA: 0xBE5850
        public void set_SerialNumber(){} // RVA: 0xBE5860
        public void get_Refresh(){} // RVA: 0xBBF8F0
        public void set_Refresh(){} // RVA: 0x20633C0
        public void get_Retry(){} // RVA: 0xBE58B0
        public void set_Retry(){} // RVA: 0xE9E640
        public void get_Expire(){} // RVA: 0xC0FFC0
        public void set_Expire(){} // RVA: 0xEA1CE0
        public void get_Minimum(){} // RVA: 0xBE2C60
        public void set_Minimum(){} // RVA: 0x6541540
        public void ReadData(){} // RVA: 0x6541690
        public void WriteData(){} // RVA: 0x6541890
    }

    public class SRVRecord : ResourceRecord
    {
        public object _priority;
        public object _weight;
        public object _port;
        public object _target;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6541A90
        public void get_Priority(){} // RVA: 0x4674E80
        public void set_Priority(){} // RVA: 0x653C430
        public void get_Weight(){} // RVA: 0x653DE40
        public void set_Weight(){} // RVA: 0x653DE50
        public void get_Port(){} // RVA: 0x6541AF0
        public void set_Port(){} // RVA: 0x6541B00
        public void get_Target(){} // RVA: 0xD05CA0
        public void set_Target(){} // RVA: 0xD09D70
        public void ReadData(){} // RVA: 0x6541C10
        public void WriteData(){} // RVA: 0x6541E10
    }

    public class SecurityAlgorithmRegistry : Object
    {
        public object Algorithms;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6545AC0
        public void GetMetadata(){} // RVA: 0x65460D0
    }

    public class TKEYRecord : ResourceRecord
    {
        public object NoData;
        public object _algorithm;
        public object _inception;
        public object _expiration;
        public object _mode;
        public object _error;
        public object _key;
        public object _otherData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6541F50
        public void get_Algorithm(){} // RVA: 0xD33E60
        public void set_Algorithm(){} // RVA: 0xB708C0
        public void get_Inception(){} // RVA: 0xD05CA0
        public void set_Inception(){} // RVA: 0xE9F6B0
        public void get_Expiration(){} // RVA: 0xBC1B30
        public void set_Expiration(){} // RVA: 0xE9E8B0
        public void get_Mode(){} // RVA: 0x65420A0
        public void set_Mode(){} // RVA: 0x65420B0
        public void get_Error(){} // RVA: 0x1FA9920
        public void set_Error(){} // RVA: 0x1FA9F50
        public void get_Key(){} // RVA: 0xBE58B0
        public void set_Key(){} // RVA: 0xCA4DF0
        public void get_OtherData(){} // RVA: 0xC0FFC0
        public void set_OtherData(){} // RVA: 0xC0FFD0
        public void ReadData(){} // RVA: 0x65423F0
        public void WriteData(){} // RVA: 0x6542720
        public void .cctor(){} // RVA: 0x65428E0
    }

    public class TSIGRecord : ResourceRecord
    {
        public object NoData;
        public object HMACMD5;
        public object GSSTSIG;
        public object HMACSHA1;
        public object HMACSHA224;
        public object HMACSHA256;
        public object HMACSHA384;
        public object HMACSHA512;
        public object _algorithm;
        public object _timeSigned;
        public object _mAC;
        public object _fudge;
        public object _originalMessageId;
        public object _error;
        public object _otherData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6542990
        public void get_Algorithm(){} // RVA: 0xD33E60
        public void set_Algorithm(){} // RVA: 0xB708C0
        public void get_TimeSigned(){} // RVA: 0xD05CA0
        public void set_TimeSigned(){} // RVA: 0xE9F6B0
        public void get_MAC(){} // RVA: 0xBC1B30
        public void set_MAC(){} // RVA: 0xB6A8C0
        public void get_Fudge(){} // RVA: 0xBBF8F0
        public void set_Fudge(){} // RVA: 0x20633C0
        public void get_OriginalMessageId(){} // RVA: 0x4CCE2D0
        public void set_OriginalMessageId(){} // RVA: 0x6540DF0
        public void get_Error(){} // RVA: 0x24BE000
        public void set_Error(){} // RVA: 0x24BB3B0
        public void get_OtherData(){} // RVA: 0xC0FFC0
        public void set_OtherData(){} // RVA: 0xC0FFD0
        public void ReadData(){} // RVA: 0x6543520
        public void WriteData(){} // RVA: 0x65438E0
        public void .cctor(){} // RVA: 0x6543B30
    }

    public class TXTRecord : ResourceRecord
    {
        public object _strings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6543BE0
        public void get_Strings(){} // RVA: 0xD33E60
        public void set_Strings(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x6543DF0
        public void WriteData(){} // RVA: 0x6544030
    }

    public class UnknownEdnsOption : EdnsOption
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB465B0
        public void set_Data(){} // RVA: 0xBA9BA0
        public void ReadData(){} // RVA: 0x6535D50
        public void WriteData(){} // RVA: 0x6535DD0
        public void ToString(){} // RVA: 0x6546280
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnknownRecord : ResourceRecord
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xD33E60
        public void set_Data(){} // RVA: 0xB708C0
        public void ReadData(){} // RVA: 0x653FC00
        public void WriteData(){} // RVA: 0x653FC70
        public void .ctor(){} // RVA: 0x65441F0
    }

    public class UpdateMessage : DnsObject
    {
        public object _id;
        public object _qR;
        public object _opcode;
        public object _z;
        public object _status;
        public object _zone;
        public object _prerequisites;
        public object _updates;
        public object _additionalResources;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x31D74A0
        public void set_Id(){} // RVA: 0x4FB44B0
        public void get_QR(){} // RVA: 0x246FA20
        public void set_QR(){} // RVA: 0x246E8E0
        public void get_IsUpdate(){} // RVA: 0x6546430
        public void get_IsResponse(){} // RVA: 0x246FA20
        public void get_Opcode(){} // RVA: 0x6546440
        public void set_Opcode(){} // RVA: 0x6546450
        public void get_Z(){} // RVA: 0xFEAE90
        public void set_Z(){} // RVA: 0x1269760
        public void get_Status(){} // RVA: 0xB5E030
        public void set_Status(){} // RVA: 0xD72F80
        public void get_Zone(){} // RVA: 0xB70160
        public void set_Zone(){} // RVA: 0xB44DC0
        public void get_Prerequisites(){} // RVA: 0xD33E60
        public void get_Updates(){} // RVA: 0xD05CA0
        public void get_AdditionalResources(){} // RVA: 0xBC1B30
        public void CreateResponse(){} // RVA: 0x6546460
        public void Read(){} // RVA: 0x65464E0
        public void Write(){} // RVA: 0x6546A90
        public void .ctor(){} // RVA: 0x65470D0
    }

    public class UpdatePrerequisiteList : List`1
    {
        // ── Methods ──
        public void MustExist(){} // RVA: 0x6547580
        public void MustNotExist(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0x6547770
    }

    public class UpdateResourceList : List`1
    {
        // ── Methods ──
        public void AddResource(){} // RVA: 0x65477E0
        public void DeleteResource(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0x6547B30
    }

    public class WireReader : Object
    {
        public object UnixEpoch;
        public object stream;
        public object names;
        public object Position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6547BA0
        public void ReadByte(){} // RVA: 0x6547CC0
        public void ReadBytes(){} // RVA: 0x6547D40
        public void ReadByteLengthPrefixedBytes(){} // RVA: 0x6547E30
        public void ReadUInt16LengthPrefixedBytes(){} // RVA: 0x6547E60
        public void ReadUInt16(){} // RVA: 0x6547EA0
        public void ReadUInt32(){} // RVA: 0x6547EE0
        public void ReadUInt48(){} // RVA: 0x6547F50
        public void ReadDomainName(){} // RVA: 0x6548000
        public void ReadLabels(){} // RVA: 0x65480A0
        public void ReadString(){} // RVA: 0x65482C0
        public void ReadTimeSpan16(){} // RVA: 0x6548570
        public void ReadTimeSpan32(){} // RVA: 0x6548640
        public void ReadIPAddress(){} // RVA: 0x65486F0
        public void ReadBitmap(){} // RVA: 0x65487D0
        public void ReadDateTime32(){} // RVA: 0x6548920
        public void ReadDateTime48(){} // RVA: 0x6548A10
        public void .cctor(){} // RVA: 0x6548BB0
    }

    public class WireWriter : Object
    {
        public object maxPointer;
        public object uint48MaxValue;
        public object UnixEpoch;
        public object stream;
        public object pointers;
        public object scopes;
        public object Position;
        public object _canonicalForm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6548CE0
        public void get_CanonicalForm(){} // RVA: 0xC27380
        public void set_CanonicalForm(){} // RVA: 0xC27390
        public void PushLengthPrefixedScope(){} // RVA: 0x6548EB0
        public void PopLengthPrefixedScope(){} // RVA: 0x6548F90
        public void WriteByte(){} // RVA: 0x6549100
        public void WriteBytes(){} // RVA: 0x6549140
        public void WriteByteLengthPrefixedBytes(){} // RVA: 0x65491A0
        public void WriteUint16LengthPrefixedBytes(){} // RVA: 0x65492B0
        public void WriteUInt16(){} // RVA: 0x65493B0
        public void WriteUInt32(){} // RVA: 0x6549420
        public void WriteUInt48(){} // RVA: 0x65494D0
        public void WriteDomainName(){} // RVA: 0x6549710
        public void WriteString(){} // RVA: 0x6549AF0
        public void WriteTimeSpan16(){} // RVA: 0x6549CF0
        public void WriteTimeSpan32(){} // RVA: 0x6549DB0
        public void WriteDateTime32(){} // RVA: 0x6549E30
        public void WriteDateTime48(){} // RVA: 0x6549F60
        public void WriteIPAddress(){} // RVA: 0x654A090
        public void WriteBitmap(){} // RVA: 0x654A100
        public void ToBytes(){} // RVA: 0x654AA40
        public void .cctor(){} // RVA: 0x654AB00
    }

}