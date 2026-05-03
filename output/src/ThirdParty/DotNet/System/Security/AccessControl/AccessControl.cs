// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 21
// Methods: 237

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule : AuthorizationRule
    {
        public 0x664C761C type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86801DF0
        public void get_AccessControlType(){} // RVA: 0x7FFE81549710
    }

    public class AceEnumerator : Object
    {
        public System.Security.AccessControl.GenericAcl owner; // 0x10
        public int current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83C3D9B0
        public void get_Current(){} // RVA: 0x7FFE86801E90
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE86801E90
        public void MoveNext(){} // RVA: 0x7FFE86801ED0
        public void Reset(){} // RVA: 0x7FFE82A55FE0
    }

    public class AuthorizationRule : Object
    {
        public System.Security.Principal.IdentityReference identity; // 0x10
        public int accessMask; // 0x18
        public bool isInherited; // 0x1C
        public 0x664C7DAC inheritanceFlags; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86801F30
        public void get_IdentityReference(){} // RVA: 0x7FFE81116380
        public void get_InheritanceFlags(){} // RVA: 0x7FFE8151D690
        public void get_PropagationFlags(){} // RVA: 0x7FFE81A56130
        public void get_AccessMask(){} // RVA: 0x7FFE813DB630
    }

    public class CommonAce : QualifiedAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86802320 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFE868025E0
        public void GetBinaryForm(){} // RVA: 0x7FFE86802630
        public void ConvertType(){} // RVA: 0x7FFE86802790
    }

    public class CommonAcl : GenericAcl
    {
        public bool is_aefa; // 0x10
        public bool is_canonical; // 0x11
        public bool is_container; // 0x12
        public bool is_ds; // 0x13
        public System.Security.AccessControl.RawAcl raw_acl; // 0x18
        public object field_5; // 0x392
        public object field_6; // 0x393
        public object field_7; // 0x394

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86802B90 | overloaded x3
        public void Init(){} // RVA: 0x7FFE86802D10
        public void get_BinaryLength(){} // RVA: 0x7FFE86738540
        public void get_Count(){} // RVA: 0x7FFE86802D70
        public void get_IsCanonical(){} // RVA: 0x7FFE81346E30
        public void get_IsContainer(){} // RVA: 0x7FFE826E3520
        public void get_IsDS(){} // RVA: 0x7FFE826E3500
        public void get_IsAefa(){} // RVA: 0x7FFE811C55E0
        public void set_IsAefa(){} // RVA: 0x7FFE811C55F0
        public void get_Revision(){} // RVA: 0x7FFE86802DA0
        public void get_Item(){} // RVA: 0x7FFE86802DD0
        public void set_Item(){} // RVA: 0x7FFE86802E90
        public void GetBinaryForm(){} // RVA: 0x7FFE86802ED0
        public void Purge(){} // RVA: 0x7FFE86802F00
        public void RequireCanonicity(){} // RVA: 0x7FFE86803070
        public void CanonicalizeAndClearAefa(){} // RVA: 0x7FFE868030E0
        public void IsAceMeaningless(){} // RVA: 0x7FFE868032A0
        public void TestCanonicity(){} // RVA: 0x7FFE868033B0
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x7FFE868036B0
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x7FFE86803810
        public void MergeExplicitAces(){} // RVA: 0x7FFE86803890
        public void MergeExplicitAcePair(){} // RVA: 0x7FFE868039B0
        public void GetObjectAceTypeGuids(){} // RVA: 0x7FFE86804090
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFE86804130 | overloaded x2
        public void RemoveAces(){} // RVA: 0x7FFE80E460A0
        public void AddAce(){} // RVA: 0x7FFE86804570 | overloaded x2
        public void AddAceGetQualifiedAce(){} // RVA: 0x7FFE86804380
        public void CopyAce(){} // RVA: 0x7FFE86804770
        public void GetAceInsertPosition(){} // RVA: 0x7FFE80E35520
        public void GetAceFlags(){} // RVA: 0x7FFE86804810
        public void RemoveAceSpecific(){} // RVA: 0x7FFE86804960
        public void SetAce(){} // RVA: 0x7FFE86804CC0 | overloaded x2
    }

    public class CommonObjectSecurity : ObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86805230
        public void AddAccessRule(){} // RVA: 0x7FFE86805240
        public void ModifyAccess(){} // RVA: 0x7FFE86805280
    }

    public class CommonSecurityDescriptor : GenericSecurityDescriptor
    {
        public bool is_container; // 0x10
        public bool is_ds; // 0x11
        public 0x664C7B9C flags; // 0x14
        public System.Security.Principal.SecurityIdentifier owner; // 0x18
        public System.Security.Principal.SecurityIdentifier group; // 0x20
        public System.Security.AccessControl.SystemAcl system_acl; // 0x28
        public System.Security.AccessControl.DiscretionaryAcl discretionary_acl; // 0x30
        public object field_7; // 0x39A
        public object field_8; // 0x39B
        public object field_9; // 0x39C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868059E0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE86805BC0 | overloaded x2
        public void get_ControlFlags(){} // RVA: 0x7FFE86805C90
        public void get_DiscretionaryAcl(){} // RVA: 0x7FFE8144E200
        public void set_DiscretionaryAcl(){} // RVA: 0x7FFE86805CB0
        public void get_InternalDacl(){} // RVA: 0x7FFE8144E200
        public void get_Group(){} // RVA: 0x7FFE811290C0
        public void set_Group(){} // RVA: 0x7FFE811290D0
        public void get_IsContainer(){} // RVA: 0x7FFE811C55E0
        public void get_IsDS(){} // RVA: 0x7FFE81346E30
        public void get_Owner(){} // RVA: 0x7FFE810FE7C0
        public void set_Owner(){} // RVA: 0x7FFE81161E80
        public void get_SystemAcl(){} // RVA: 0x7FFE81129130
        public void set_SystemAcl(){} // RVA: 0x7FFE86805F00
        public void get_InternalSacl(){} // RVA: 0x7FFE81129130
        public void PurgeAccessControl(){} // RVA: 0x7FFE86805F80
        public void CheckAclConsistency(){} // RVA: 0x7FFE868060F0
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7FFE868061C0
    }

    public class CryptoKeySecurity : NativeObjectSecurity
    {
    }

    public class DiscretionaryAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868061E0 | overloaded x2
        public void AddAccess(){} // RVA: 0x7FFE868061F0
        public void RemoveAccess(){} // RVA: 0x7FFE86806260
        public void RemoveAccessSpecific(){} // RVA: 0x7FFE868062A0
        public void SetAccess(){} // RVA: 0x7FFE86806440
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFE86806610
        public void GetAceInsertPosition(){} // RVA: 0x7FFE86806670
        public void GetAceQualifier(){} // RVA: 0x7FFE86806680
        public void IsAceMeaningless(){} // RVA: 0x7FFE868066F0
    }

    public class GenericAce : Object
    {
        public 0x664C7724 ace_flags; // 0x10
        public 0x664C77D4 ace_type; // 0x11
        public object field_2; // 0x3A4
        public object field_3; // 0x3A5
        public object field_4; // 0x3A6
        public object field_5; // 0x3A7
        public object field_6; // 0x3A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86806870 | overloaded x2
        public void get_AceFlags(){} // RVA: 0x7FFE811C55E0
        public void get_AceType(){} // RVA: 0x7FFE81346E30
        public void get_AuditFlags(){} // RVA: 0x7FFE868069B0
        public void get_BinaryLength(){} // RVA: 0x7FFE80E2EDB0
        public void get_InheritanceFlags(){} // RVA: 0x7FFE868069D0
        public void get_IsInherited(){} // RVA: 0x7FFE868069F0
        public void get_PropagationFlags(){} // RVA: 0x7FFE86806A00
        public void CreateFromBinaryForm(){} // RVA: 0x7FFE86806A20
        public void Equals(){} // RVA: 0x7FFE86806BE0
        public void GetBinaryForm(){} // RVA: 0x7FFE80E4D070
        public void GetHashCode(){} // RVA: 0x7FFE86806C70
        public void op_Equality(){} // RVA: 0x7FFE86806D40
        public void op_Inequality(){} // RVA: 0x7FFE86806EA0
        public void IsObjectType(){} // RVA: 0x7FFE86807000
        public void ReadUShort(){} // RVA: 0x7FFE86807020
        public void ReadInt(){} // RVA: 0x7FFE86807060
        public void WriteInt(){} // RVA: 0x7FFE868070D0
        public void WriteUShort(){} // RVA: 0x7FFE86807140
    }

    public class GenericAcl : Object
    {
        public byte AclRevision;
        public byte AclRevisionDS; // 0x1
        public int MaxBinaryLength; // 0x4
        public object field_3; // 0x3AB
        public object field_4; // 0x3AC
        public object field_5; // 0x3AD

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86807180
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_BinaryLength(){} // RVA: 0x7FFE80E2EDB0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void set_Item(){} // RVA: 0x7FFE80E48220
        public void get_Revision(){} // RVA: 0x7FFE80E2F150
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void CopyTo(){} // RVA: 0x7FFE868071F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE86807400
        public void GetBinaryForm(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE86807490
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86807530
    }

    public class GenericSecurityDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_BinaryLength(){} // RVA: 0x7FFE86807540
        public void get_ControlFlags(){} // RVA: 0x7FFE80E2EDB0
        public void get_Group(){} // RVA: 0x7FFE80E2E2E0
        public void set_Group(){} // RVA: 0x7FFE80E460A0
        public void get_Owner(){} // RVA: 0x7FFE80E2E2E0
        public void set_Owner(){} // RVA: 0x7FFE80E460A0
        public void get_Revision(){} // RVA: 0x7FFE811E0850
        public void get_InternalDacl(){} // RVA: 0x7FFE813240E0
        public void get_InternalSacl(){} // RVA: 0x7FFE813240E0
        public void get_InternalReservedField(){} // RVA: 0x7FFE810FB320
        public void GetBinaryForm(){} // RVA: 0x7FFE86807750
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7FFE810FB320
        public void get_DaclPresent(){} // RVA: 0x7FFE86807DE0
        public void get_SaclPresent(){} // RVA: 0x7FFE86807E30
        public void WriteUShort(){} // RVA: 0x7FFE86807E80
        public void WriteInt(){} // RVA: 0x7FFE86807EC0
    }

    public class KnownAce : GenericAce
    {
        public int access_mask; // 0x18
        public System.Security.Principal.SecurityIdentifier identifier; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86807F30 | overloaded x2
        public void get_AccessMask(){} // RVA: 0x7FFE813DB630
        public void set_AccessMask(){} // RVA: 0x7FFE8144DF00
        public void get_SecurityIdentifier(){} // RVA: 0x7FFE811290C0
        public void set_SecurityIdentifier(){} // RVA: 0x7FFE811290D0
    }

    public class NativeObjectSecurity : CommonObjectSecurity
    {
        public ExceptionFromErrorCode exception_from_error_code; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86808210 | overloaded x4
        public void ClearAccessControlSectionsModified(){} // RVA: 0x7FFE86808300
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x7FFE868083A0
        public void RaiseExceptionOnFailure(){} // RVA: 0x7FFE868085F0
        public void InternalGet(){} // RVA: 0x7FFE868086A0
        public void get_ResourceType(){} // RVA: 0x7FFE81156CD0
        public void Win32GetHelper(){} // RVA: 0x7FFE868088F0
        public void GetSecurityInfo(){} // RVA: 0x7FFE86808C80
        public void LocalFree(){} // RVA: 0x7FFE86808DC0
        public void GetSecurityDescriptorLength(){} // RVA: 0x7FFE86808E40
        public void IsValidSecurityDescriptor(){} // RVA: 0x7FFE86808EC0
    }

    public class ObjectAce : QualifiedAce
    {
        public System.Guid object_ace_type; // 0x30
        public System.Guid inherited_object_type; // 0x40
        public 0x664C8014 object_ace_flags; // 0x50
        public object field_3; // 0x3BF
        public object field_4; // 0x3C0
        public object field_5; // 0x3C1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868093E0 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFE868097D0
        public void get_InheritedObjectAceType(){} // RVA: 0x7FFE82D32FA0
        public void set_InheritedObjectAceType(){} // RVA: 0x7FFE850A4980
        public void get_InheritedObjectAceTypePresent(){} // RVA: 0x7FFE86809830
        public void get_ObjectAceFlags(){} // RVA: 0x7FFE8139DAD0
        public void set_ObjectAceFlags(){} // RVA: 0x7FFE81463B00
        public void get_ObjectAceType(){} // RVA: 0x7FFE86809840
        public void set_ObjectAceType(){} // RVA: 0x7FFE86809850
        public void get_ObjectAceTypePresent(){} // RVA: 0x7FFE86809860
        public void GetBinaryForm(){} // RVA: 0x7FFE86809870
        public void ConvertType(){} // RVA: 0x7FFE86809AC0
        public void WriteGuid(){} // RVA: 0x7FFE86809BE0
        public void ReadGuid(){} // RVA: 0x7FFE86809C30
    }

    public class ObjectSecurity : Object
    {
        public System.Security.AccessControl.CommonSecurityDescriptor descriptor; // 0x10
        public 0x664C75C4 sections_modified; // 0x18
        public System.Threading.ReaderWriterLock rw_lock; // 0x20
        public object field_3; // 0x3C5
        public object field_4; // 0x3C6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86809EE0 | overloaded x2
        public void get_AccessControlSectionsModified(){} // RVA: 0x7FFE8680A120
        public void set_AccessControlSectionsModified(){} // RVA: 0x7FFE8680A1B0
        public void set_AccessRulesModified(){} // RVA: 0x7FFE8680A230
        public void get_IsContainer(){} // RVA: 0x7FFE8680A280
        public void get_IsDS(){} // RVA: 0x7FFE8680A2A0
        public void set_OwnerModified(){} // RVA: 0x7FFE8680A2C0
        public void GetOwner(){} // RVA: 0x7FFE8680A310
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFE8680A4B0
        public void PurgeAccessRules(){} // RVA: 0x7FFE8680A5D0
        public void SetOwner(){} // RVA: 0x7FFE8680A840
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFE8680A940
        public void CopySddlForm(){} // RVA: 0x7FFE8680AA00
        public void ModifyAccess(){}
        public void Reading(){} // RVA: 0x7FFE8680AC50
        public void ReadLock(){} // RVA: 0x7FFE8680ACE0
        public void ReadUnlock(){} // RVA: 0x7FFE8680AD10
        public void Writing(){} // RVA: 0x7FFE8680AD30
        public void WriteLock(){} // RVA: 0x7FFE8680ADB0
        public void WriteUnlock(){} // RVA: 0x7FFE8680ADE0
        public void SidFromIR(){} // RVA: 0x7FFE8680AE00
        public void SetAccessControlSectionsModified(){} // RVA: 0x7FFE8680AF20
    }

    public class PrivilegeNotHeldException : UnauthorizedAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86801B20 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE86801C30
    }

    public class QualifiedAce : KnownAce
    {
        public byte[] opaque; // 0x28
        public object field_1; // 0x3CA
        public object field_2; // 0x3CB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86807F30 | overloaded x2
        public void get_AceQualifier(){} // RVA: 0x7FFE8680AFE0
        public void get_IsCallback(){} // RVA: 0x7FFE8680B110
        public void get_OpaqueLength(){} // RVA: 0x7FFE8680B150
        public void GetOpaque(){} // RVA: 0x7FFE8680B170
        public void SetOpaque(){} // RVA: 0x7FFE8680B1F0
    }

    public class RawAcl : GenericAcl
    {
        public byte revision; // 0x10
        public System.Collections.Generic.List`1<System.Security.AccessControl.GenericAce> list; // 0x18
        public object field_2; // 0x3CD
        public object field_3; // 0x3CE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680B470 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFE8680B860
        public void get_Count(){} // RVA: 0x7FFE8680B9E0
        public void get_Item(){} // RVA: 0x7FFE8680BA30
        public void set_Item(){} // RVA: 0x7FFE8680BAB0
        public void get_Revision(){} // RVA: 0x7FFE811C55E0
        public void GetBinaryForm(){} // RVA: 0x7FFE8680BB30
        public void InsertAce(){} // RVA: 0x7FFE8680BEA0
        public void RemoveAce(){} // RVA: 0x7FFE8680BF80
        public void WriteUShort(){} // RVA: 0x7FFE86807E80
        public void ReadUShort(){} // RVA: 0x7FFE8680BFE0
    }

    public class RawSecurityDescriptor : GenericSecurityDescriptor
    {
        public 0x664C7B9C control_flags; // 0x10
        public System.Security.Principal.SecurityIdentifier owner_sid; // 0x18
        public System.Security.Principal.SecurityIdentifier group_sid; // 0x20
        public System.Security.AccessControl.RawAcl system_acl; // 0x28
        public System.Security.AccessControl.RawAcl discretionary_acl; // 0x30
        public byte resourcemgr_control; // 0x38
        public object field_6; // 0x3D1
        public object field_7; // 0x3D2
        public object field_8; // 0x3D3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680C020
        public void get_ControlFlags(){} // RVA: 0x7FFE811485C0
        public void get_DiscretionaryAcl(){} // RVA: 0x7FFE8144E200
        public void get_Group(){} // RVA: 0x7FFE811290C0
        public void set_Group(){} // RVA: 0x7FFE811290D0
        public void get_Owner(){} // RVA: 0x7FFE810FE7C0
        public void set_Owner(){} // RVA: 0x7FFE81161E80
        public void get_ResourceManagerControl(){} // RVA: 0x7FFE812CF770
        public void get_SystemAcl(){} // RVA: 0x7FFE81129130
        public void get_InternalDacl(){} // RVA: 0x7FFE8144E200
        public void get_InternalSacl(){} // RVA: 0x7FFE81129130
        public void get_InternalReservedField(){} // RVA: 0x7FFE812CF770
        public void ReadUShort(){} // RVA: 0x7FFE8680BFE0
        public void ReadInt(){} // RVA: 0x7FFE8680C480
    }

    public class SystemAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868061E0
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFE8680C4F0
        public void GetAceInsertPosition(){} // RVA: 0x7FFE813240E0
        public void IsAceMeaningless(){} // RVA: 0x7FFE8680C520
        public void IsValidAuditFlags(){} // RVA: 0x7FFE8680C630
    }

}