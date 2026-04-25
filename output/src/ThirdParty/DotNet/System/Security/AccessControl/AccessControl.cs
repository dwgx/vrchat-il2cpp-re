// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 21
// Methods: 237

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule : AuthorizationRule
    {
        public 0x6B0CE6F8 AccessControlType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84584E0
        public void get_AccessControlType(){} // RVA: 0x7FFAC32EC4C0
    }

    public class AceEnumerator : Object
    {
        public System.Security.AccessControl.GenericAcl Current; // 0x10
        public int System.Collections.IEnumerator.Current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5923EB0
        public void get_Current(){} // RVA: 0x7FFAC8458580
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC8458580
        public void MoveNext(){} // RVA: 0x7FFAC84585C0
        public void Reset(){} // RVA: 0x7FFAC47EDC40
    }

    public class AuthorizationRule : Object
    {
        public System.Security.Principal.IdentityReference IdentityReference; // 0x10
        public int InheritanceFlags; // 0x18
        public bool PropagationFlags; // 0x1C
        public 0x6B0CEE88 AccessMask; // 0x20
        public 0x6B0CF1A0 propagationFlags; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8458620
        public void get_IdentityReference(){} // RVA: 0x7FFAC2F3C380
        public void get_InheritanceFlags(){} // RVA: 0x7FFAC30DBBE0
        public void get_PropagationFlags(){} // RVA: 0x7FFAC3921980
        public void get_AccessMask(){} // RVA: 0x7FFAC3157800
    }

    public class CommonAce : QualifiedAce
    {
        public object BinaryLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8458A10 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFAC8458CD0
        public void GetBinaryForm(){} // RVA: 0x7FFAC8458D20
        public void ConvertType(){} // RVA: 0x7FFAC8458E80
    }

    public class CommonAcl : GenericAcl
    {
        public bool BinaryLength; // 0x10
        public bool Count; // 0x11
        public bool IsCanonical; // 0x12
        public bool IsContainer; // 0x13
        public System.Security.AccessControl.RawAcl IsDS; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8459280 | overloaded x3
        public void Init(){} // RVA: 0x7FFAC8459400
        public void get_BinaryLength(){} // RVA: 0x7FFAC838EC40
        public void get_Count(){} // RVA: 0x7FFAC8459460
        public void get_IsCanonical(){} // RVA: 0x7FFAC3771DA0
        public void get_IsContainer(){} // RVA: 0x7FFAC3AE1A90
        public void get_IsDS(){} // RVA: 0x7FFAC4411E00
        public void get_IsAefa(){} // RVA: 0x7FFAC2FEB5E0
        public void set_IsAefa(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Revision(){} // RVA: 0x7FFAC8459490
        public void get_Item(){} // RVA: 0x7FFAC84594C0
        public void set_Item(){} // RVA: 0x7FFAC8459580
        public void GetBinaryForm(){} // RVA: 0x7FFAC84595C0
        public void Purge(){} // RVA: 0x7FFAC84595F0
        public void RequireCanonicity(){} // RVA: 0x7FFAC8459760
        public void CanonicalizeAndClearAefa(){} // RVA: 0x7FFAC84597D0
        public void IsAceMeaningless(){} // RVA: 0x7FFAC8459990
        public void TestCanonicity(){} // RVA: 0x7FFAC8459AA0
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x7FFAC8459DA0
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x7FFAC8459F00
        public void MergeExplicitAces(){} // RVA: 0x7FFAC8459F80
        public void MergeExplicitAcePair(){} // RVA: 0x7FFAC845A0A0
        public void GetObjectAceTypeGuids(){} // RVA: 0x7FFAC845A780
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFAC845A820 | overloaded x2
        public void RemoveAces(){} // RVA: 0x7FFAC2C70A40
        public void AddAce(){} // RVA: 0x7FFAC845AC60 | overloaded x2
        public void AddAceGetQualifiedAce(){} // RVA: 0x7FFAC845AA70
        public void CopyAce(){} // RVA: 0x7FFAC845AE60
        public void GetAceInsertPosition(){} // RVA: 0x7FFAC2C600D0
        public void GetAceFlags(){} // RVA: 0x7FFAC845AF00
        public void RemoveAceSpecific(){} // RVA: 0x7FFAC845B050
        public void SetAce(){} // RVA: 0x7FFAC845B3B0 | overloaded x2
    }

    public class CommonObjectSecurity : ObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845B920
        public void AddAccessRule(){} // RVA: 0x7FFAC845B930
        public void ModifyAccess(){} // RVA: 0x7FFAC845B970
    }

    public class CommonSecurityDescriptor : GenericSecurityDescriptor
    {
        public bool ControlFlags; // 0x10
        public bool DiscretionaryAcl; // 0x11
        public 0x6B0CEC78 InternalDacl; // 0x14
        public System.Security.Principal.SecurityIdentifier Group; // 0x18
        public System.Security.Principal.SecurityIdentifier IsContainer; // 0x20
        public System.Security.AccessControl.SystemAcl IsDS; // 0x28
        public System.Security.AccessControl.DiscretionaryAcl Owner; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845C0D0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC845C2B0 | overloaded x2
        public void get_ControlFlags(){} // RVA: 0x7FFAC845C380
        public void get_DiscretionaryAcl(){} // RVA: 0x7FFAC31D95E0
        public void set_DiscretionaryAcl(){} // RVA: 0x7FFAC845C3A0
        public void get_InternalDacl(){} // RVA: 0x7FFAC31D95E0
        public void get_Group(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Group(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IsContainer(){} // RVA: 0x7FFAC2FEB5E0
        public void get_IsDS(){} // RVA: 0x7FFAC3771DA0
        public void get_Owner(){} // RVA: 0x7FFAC2F247C0
        public void set_Owner(){} // RVA: 0x7FFAC2F87E80
        public void get_SystemAcl(){} // RVA: 0x7FFAC2F4F130
        public void set_SystemAcl(){} // RVA: 0x7FFAC845C5F0
        public void get_InternalSacl(){} // RVA: 0x7FFAC2F4F130
        public void PurgeAccessControl(){} // RVA: 0x7FFAC845C670
        public void CheckAclConsistency(){} // RVA: 0x7FFAC845C7E0
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7FFAC845C8B0
    }

    public class CryptoKeySecurity : NativeObjectSecurity
    {
    }

    public class DiscretionaryAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845C8D0 | overloaded x2
        public void AddAccess(){} // RVA: 0x7FFAC845C8E0
        public void RemoveAccess(){} // RVA: 0x7FFAC845C950
        public void RemoveAccessSpecific(){} // RVA: 0x7FFAC845C990
        public void SetAccess(){} // RVA: 0x7FFAC845CB30
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFAC845CD00
        public void GetAceInsertPosition(){} // RVA: 0x7FFAC845CD60
        public void GetAceQualifier(){} // RVA: 0x7FFAC845CD70
        public void IsAceMeaningless(){} // RVA: 0x7FFAC845CDE0
    }

    public class GenericAce : Object
    {
        public 0x6B0CE800 AceFlags; // 0x10
        public 0x6B0CE8B0 AceType; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845CF60 | overloaded x2
        public void get_AceFlags(){} // RVA: 0x7FFAC2FEB5E0
        public void get_AceType(){} // RVA: 0x7FFAC3771DA0
        public void get_AuditFlags(){} // RVA: 0x7FFAC845D0A0
        public void get_BinaryLength(){} // RVA: 0x7FFAC2C59960
        public void get_InheritanceFlags(){} // RVA: 0x7FFAC845D0C0
        public void get_IsInherited(){} // RVA: 0x7FFAC845D0E0
        public void get_PropagationFlags(){} // RVA: 0x7FFAC845D0F0
        public void CreateFromBinaryForm(){} // RVA: 0x7FFAC845D110
        public void Equals(){} // RVA: 0x7FFAC845D2D0
        public void GetBinaryForm(){} // RVA: 0x7FFAC2C77970
        public void GetHashCode(){} // RVA: 0x7FFAC845D360
        public void op_Equality(){} // RVA: 0x7FFAC845D430
        public void op_Inequality(){} // RVA: 0x7FFAC845D590
        public void IsObjectType(){} // RVA: 0x7FFAC845D6F0
        public void ReadUShort(){} // RVA: 0x7FFAC845D710
        public void ReadInt(){} // RVA: 0x7FFAC845D750
        public void WriteInt(){} // RVA: 0x7FFAC845D7C0
        public void WriteUShort(){} // RVA: 0x7FFAC845D830
    }

    public class GenericAcl : Object
    {
        public byte BinaryLength;
        public byte Count; // 0x1
        public int IsSynchronized; // 0x4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC845D870
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_BinaryLength(){} // RVA: 0x7FFAC2C59960
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void set_Item(){} // RVA: 0x7FFAC2C72BC0
        public void get_Revision(){} // RVA: 0x7FFAC2C59D00
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void CopyTo(){} // RVA: 0x7FFAC845D8E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC845DAF0
        public void GetBinaryForm(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC845DB80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC845DC20
    }

    public class GenericSecurityDescriptor : Object
    {
        public object BinaryLength;
        public object ControlFlags;
        public object Group;
        public object Owner;
        public object Revision;
        public object InternalDacl;
        public object InternalSacl;
        public object InternalReservedField;
        public object DaclIsUnmodifiedAefa;
        public object DaclPresent;
        public object SaclPresent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_BinaryLength(){} // RVA: 0x7FFAC845DC30
        public void get_ControlFlags(){} // RVA: 0x7FFAC2C59960
        public void get_Group(){} // RVA: 0x7FFAC2C58E90
        public void set_Group(){} // RVA: 0x7FFAC2C70A40
        public void get_Owner(){} // RVA: 0x7FFAC2C58E90
        public void set_Owner(){} // RVA: 0x7FFAC2C70A40
        public void get_Revision(){} // RVA: 0x7FFAC3006850
        public void get_InternalDacl(){} // RVA: 0x7FFAC34F9180
        public void get_InternalSacl(){} // RVA: 0x7FFAC34F9180
        public void get_InternalReservedField(){} // RVA: 0x7FFAC2F21320
        public void GetBinaryForm(){} // RVA: 0x7FFAC845DE40
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7FFAC2F21320
        public void get_DaclPresent(){} // RVA: 0x7FFAC845E4D0
        public void get_SaclPresent(){} // RVA: 0x7FFAC845E520
        public void WriteUShort(){} // RVA: 0x7FFAC845E570
        public void WriteInt(){} // RVA: 0x7FFAC845E5B0
    }

    public class KnownAce : GenericAce
    {
        public int AccessMask; // 0x18
        public System.Security.Principal.SecurityIdentifier SecurityIdentifier; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845E620 | overloaded x2
        public void get_AccessMask(){} // RVA: 0x7FFAC3157800
        public void set_AccessMask(){} // RVA: 0x7FFAC392CD10
        public void get_SecurityIdentifier(){} // RVA: 0x7FFAC2F4F0C0
        public void set_SecurityIdentifier(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class NativeObjectSecurity : CommonObjectSecurity
    {
        public ExceptionFromErrorCode ResourceType; // 0x28
        public 0x6B0CF300 resource_type; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845E900 | overloaded x4
        public void ClearAccessControlSectionsModified(){} // RVA: 0x7FFAC845E9F0
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x7FFAC845EA90
        public void RaiseExceptionOnFailure(){} // RVA: 0x7FFAC845ECE0
        public void InternalGet(){} // RVA: 0x7FFAC845ED90
        public void get_ResourceType(){} // RVA: 0x7FFAC2F7CCD0
        public void Win32GetHelper(){} // RVA: 0x7FFAC845EFE0
        public void GetSecurityInfo(){} // RVA: 0x7FFAC845F370
        public void LocalFree(){} // RVA: 0x7FFAC845F4B0
        public void GetSecurityDescriptorLength(){} // RVA: 0x7FFAC845F530
        public void IsValidSecurityDescriptor(){} // RVA: 0x7FFAC845F5B0
    }

    public class ObjectAce : QualifiedAce
    {
        public System.Guid BinaryLength; // 0x30
        public System.Guid InheritedObjectAceType; // 0x40
        public 0x6B0CF0F0 InheritedObjectAceTypePresent; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845FAD0 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFAC845FEC0
        public void get_InheritedObjectAceType(){} // RVA: 0x7FFAC4AC8580
        public void set_InheritedObjectAceType(){} // RVA: 0x7FFAC6D1E430
        public void get_InheritedObjectAceTypePresent(){} // RVA: 0x7FFAC845FF20
        public void get_ObjectAceFlags(){} // RVA: 0x7FFAC30F10E0
        public void set_ObjectAceFlags(){} // RVA: 0x7FFAC31D9010
        public void get_ObjectAceType(){} // RVA: 0x7FFAC845FF30
        public void set_ObjectAceType(){} // RVA: 0x7FFAC845FF40
        public void get_ObjectAceTypePresent(){} // RVA: 0x7FFAC845FF50
        public void GetBinaryForm(){} // RVA: 0x7FFAC845FF60
        public void ConvertType(){} // RVA: 0x7FFAC84601B0
        public void WriteGuid(){} // RVA: 0x7FFAC84602D0
        public void ReadGuid(){} // RVA: 0x7FFAC8460320
    }

    public class ObjectSecurity : Object
    {
        public System.Security.AccessControl.CommonSecurityDescriptor AccessControlSectionsModified; // 0x10
        public 0x6B0CE6A0 AccessRulesModified; // 0x18
        public System.Threading.ReaderWriterLock IsContainer; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84605D0 | overloaded x2
        public void get_AccessControlSectionsModified(){} // RVA: 0x7FFAC8460810
        public void set_AccessControlSectionsModified(){} // RVA: 0x7FFAC84608A0
        public void set_AccessRulesModified(){} // RVA: 0x7FFAC8460920
        public void get_IsContainer(){} // RVA: 0x7FFAC8460970
        public void get_IsDS(){} // RVA: 0x7FFAC8460990
        public void set_OwnerModified(){} // RVA: 0x7FFAC84609B0
        public void GetOwner(){} // RVA: 0x7FFAC8460A00
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFAC8460BA0
        public void PurgeAccessRules(){} // RVA: 0x7FFAC8460CC0
        public void SetOwner(){} // RVA: 0x7FFAC8460F30
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFAC8461030
        public void CopySddlForm(){} // RVA: 0x7FFAC84610F0
        public void ModifyAccess(){}
        public void Reading(){} // RVA: 0x7FFAC8461340
        public void ReadLock(){} // RVA: 0x7FFAC84613D0
        public void ReadUnlock(){} // RVA: 0x7FFAC8461400
        public void Writing(){} // RVA: 0x7FFAC8461420
        public void WriteLock(){} // RVA: 0x7FFAC84614A0
        public void WriteUnlock(){} // RVA: 0x7FFAC84614D0
        public void SidFromIR(){} // RVA: 0x7FFAC84614F0
        public void SetAccessControlSectionsModified(){} // RVA: 0x7FFAC8461610
    }

    public class PrivilegeNotHeldException : UnauthorizedAccessException
    {
        public string _privilegeName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8458210 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC8458320
    }

    public class QualifiedAce : KnownAce
    {
        public byte[] AceQualifier; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845E620 | overloaded x2
        public void get_AceQualifier(){} // RVA: 0x7FFAC84616D0
        public void get_IsCallback(){} // RVA: 0x7FFAC8461800
        public void get_OpaqueLength(){} // RVA: 0x7FFAC8461840
        public void GetOpaque(){} // RVA: 0x7FFAC8461860
        public void SetOpaque(){} // RVA: 0x7FFAC84618E0
    }

    public class RawAcl : GenericAcl
    {
        public byte BinaryLength; // 0x10
        public System.Collections.Generic.List`1<System.Security.AccessControl.GenericAce> Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8461B60 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFAC8461F50
        public void get_Count(){} // RVA: 0x7FFAC84620D0
        public void get_Item(){} // RVA: 0x7FFAC8462120
        public void set_Item(){} // RVA: 0x7FFAC84621A0
        public void get_Revision(){} // RVA: 0x7FFAC2FEB5E0
        public void GetBinaryForm(){} // RVA: 0x7FFAC8462220
        public void InsertAce(){} // RVA: 0x7FFAC8462590
        public void RemoveAce(){} // RVA: 0x7FFAC8462670
        public void WriteUShort(){} // RVA: 0x7FFAC845E570
        public void ReadUShort(){} // RVA: 0x7FFAC84626D0
    }

    public class RawSecurityDescriptor : GenericSecurityDescriptor
    {
        public 0x6B0CEC78 ControlFlags; // 0x10
        public System.Security.Principal.SecurityIdentifier DiscretionaryAcl; // 0x18
        public System.Security.Principal.SecurityIdentifier Group; // 0x20
        public System.Security.AccessControl.RawAcl Owner; // 0x28
        public System.Security.AccessControl.RawAcl ResourceManagerControl; // 0x30
        public byte SystemAcl; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8462710
        public void get_ControlFlags(){} // RVA: 0x7FFAC2F6E5C0
        public void get_DiscretionaryAcl(){} // RVA: 0x7FFAC31D95E0
        public void get_Group(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Group(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Owner(){} // RVA: 0x7FFAC2F247C0
        public void set_Owner(){} // RVA: 0x7FFAC2F87E80
        public void get_ResourceManagerControl(){} // RVA: 0x7FFAC31D95D0
        public void get_SystemAcl(){} // RVA: 0x7FFAC2F4F130
        public void get_InternalDacl(){} // RVA: 0x7FFAC31D95E0
        public void get_InternalSacl(){} // RVA: 0x7FFAC2F4F130
        public void get_InternalReservedField(){} // RVA: 0x7FFAC31D95D0
        public void ReadUShort(){} // RVA: 0x7FFAC84626D0
        public void ReadInt(){} // RVA: 0x7FFAC8462B70
    }

    public class SystemAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC845C8D0
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFAC8462BE0
        public void GetAceInsertPosition(){} // RVA: 0x7FFAC34F9180
        public void IsAceMeaningless(){} // RVA: 0x7FFAC8462C10
        public void IsValidAuditFlags(){} // RVA: 0x7FFAC8462D20
    }

}