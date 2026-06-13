// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 21
// Methods: 237

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule
    {
        public 0x657E9678 IdentityReference; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC0EF0
        public void get_AccessControlType(){} // RVA: 0x791DC0
    }

    public class AceEnumerator
    {
        public System.Security.AccessControl.GenericAcl owner; // 0x10
        public int current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F93A00
        public void get_Current(){} // RVA: 0x5CC0F90
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x5CC0F90
        public void MoveNext(){} // RVA: 0x5CC0FD0
        public void Reset(){} // RVA: 0x1CC8140
    }

    public class AuthorizationRule
    {
        public System.Security.Principal.IdentityReference identity; // 0x10
        public int accessMask; // 0x18
        public bool isInherited; // 0x1C
        public 0x657E9E08 inheritanceFlags; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC1030
        public void get_IdentityReference(){} // RVA: 0x2F8380
        public void get_InheritanceFlags(){} // RVA: 0x760030
        public void get_PropagationFlags(){} // RVA: 0xCEF5B0
        public void get_AccessMask(){} // RVA: 0x5BED50
    }

    public class CommonAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC1420 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x5CC16E0
        public void GetBinaryForm(){} // RVA: 0x5CC1730
        public void ConvertType(){} // RVA: 0x5CC1890
    }

    public class CommonAcl
    {
        public bool is_aefa; // 0x10
        public bool is_canonical; // 0x11
        public bool is_container; // 0x12
        public bool is_ds; // 0x13
        public System.Security.AccessControl.RawAcl raw_acl; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC1C90 | overloaded x3
        public void Init(){} // RVA: 0x5CC1E10
        public void get_BinaryLength(){} // RVA: 0x5BF76F0
        public void get_Count(){} // RVA: 0x5CC1E70
        public void get_IsCanonical(){} // RVA: 0x543460
        public void get_IsContainer(){} // RVA: 0x195A940
        public void get_IsDS(){} // RVA: 0x195A9E0
        public void get_IsAefa(){} // RVA: 0x3A75E0
        public void set_IsAefa(){} // RVA: 0x3A75F0
        public void get_Revision(){} // RVA: 0x5CC1EA0
        public void get_Item(){} // RVA: 0x5CC1ED0
        public void set_Item(){} // RVA: 0x5CC1F90
        public void GetBinaryForm(){} // RVA: 0x5CC1FD0
        public void Purge(){} // RVA: 0x5CC2000
        public void RequireCanonicity(){} // RVA: 0x5CC2170
        public void CanonicalizeAndClearAefa(){} // RVA: 0x5CC21E0
        public void IsAceMeaningless(){} // RVA: 0x5CC23A0
        public void TestCanonicity(){} // RVA: 0x5CC24B0
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x5CC27B0
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x5CC2910
        public void MergeExplicitAces(){} // RVA: 0x5CC2990
        public void MergeExplicitAcePair(){} // RVA: 0x5CC2AB0
        public void GetObjectAceTypeGuids(){} // RVA: 0x5CC3190
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x5CC3230 | overloaded x2
        public void RemoveAces(){} // RVA: 0x24B10
        public void AddAce(){} // RVA: 0x5CC3670 | overloaded x2
        public void AddAceGetQualifiedAce(){} // RVA: 0x5CC3480
        public void CopyAce(){} // RVA: 0x5CC3870
        public void GetAceInsertPosition(){} // RVA: 0x13FB0
        public void GetAceFlags(){} // RVA: 0x5CC3910
        public void RemoveAceSpecific(){} // RVA: 0x5CC3A60
        public void SetAce(){} // RVA: 0x5CC3DC0 | overloaded x2
    }

    public class CommonObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC4330
        public void AddAccessRule(){} // RVA: 0x5CC4340
        public void ModifyAccess(){} // RVA: 0x5CC4380
    }

    public class CommonSecurityDescriptor
    {
        public bool is_container; // 0x10
        public bool is_ds; // 0x11
        public 0x657E9BF8 flags; // 0x14
        public System.Security.Principal.SecurityIdentifier owner; // 0x18
        public System.Security.Principal.SecurityIdentifier group; // 0x20
        public System.Security.AccessControl.SystemAcl system_acl; // 0x28
        public System.Security.AccessControl.DiscretionaryAcl discretionary_acl; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC4AE0 | overloaded x2
        public void Init(){} // RVA: 0x5CC4CC0 | overloaded x2
        public void get_ControlFlags(){} // RVA: 0x5CC4D90
        public void get_DiscretionaryAcl(){} // RVA: 0x6374D0
        public void set_DiscretionaryAcl(){} // RVA: 0x5CC4DB0
        public void get_InternalDacl(){} // RVA: 0x6374D0
        public void get_Group(){} // RVA: 0x30B0C0
        public void set_Group(){} // RVA: 0x30B0D0
        public void get_IsContainer(){} // RVA: 0x3A75E0
        public void get_IsDS(){} // RVA: 0x543460
        public void get_Owner(){} // RVA: 0x2E07C0
        public void set_Owner(){} // RVA: 0x343E80
        public void get_SystemAcl(){} // RVA: 0x30B130
        public void set_SystemAcl(){} // RVA: 0x5CC5000
        public void get_InternalSacl(){} // RVA: 0x30B130
        public void PurgeAccessControl(){} // RVA: 0x5CC5080
        public void CheckAclConsistency(){} // RVA: 0x5CC51F0
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x5CC52C0
    }

    public class CryptoKeySecurity
    {
    }

    public class DiscretionaryAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC52E0 | overloaded x2
        public void AddAccess(){} // RVA: 0x5CC52F0
        public void RemoveAccess(){} // RVA: 0x5CC5360
        public void RemoveAccessSpecific(){} // RVA: 0x5CC53A0
        public void SetAccess(){} // RVA: 0x5CC5540
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x5CC5710
        public void GetAceInsertPosition(){} // RVA: 0x5CC5770
        public void GetAceQualifier(){} // RVA: 0x5CC5780
        public void IsAceMeaningless(){} // RVA: 0x5CC57F0
    }

    public class GenericAce
    {
        public 0x657E9780 ace_flags; // 0x10
        public 0x657E9830 ace_type; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC5970 | overloaded x2
        public void get_AceFlags(){} // RVA: 0x3A75E0
        public void get_AceType(){} // RVA: 0x543460
        public void get_AuditFlags(){} // RVA: 0x5CC5AB0
        public void get_BinaryLength(){} // RVA: 0xD840
        public void get_InheritanceFlags(){} // RVA: 0x5CC5AD0
        public void get_IsInherited(){} // RVA: 0x5CC5AF0
        public void get_PropagationFlags(){} // RVA: 0x5CC5B00
        public void CreateFromBinaryForm(){} // RVA: 0x5CC5B20
        public void Equals(){} // RVA: 0x5CC5CE0
        public void GetBinaryForm(){} // RVA: 0x2BAA0
        public void GetHashCode(){} // RVA: 0x5CC5D70
        public void op_Equality(){} // RVA: 0x5CC5E40
        public void op_Inequality(){} // RVA: 0x5CC5FA0
        public void IsObjectType(){} // RVA: 0x5CC6100
        public void ReadUShort(){} // RVA: 0x5CC6120
        public void ReadInt(){} // RVA: 0x5CC6160
        public void WriteInt(){} // RVA: 0x5CC61D0
        public void WriteUShort(){} // RVA: 0x5CC6240
    }

    public class GenericAcl
    {
        public byte AclRevision;
        public byte AclRevisionDS; // 0x1
        public int MaxBinaryLength; // 0x4

        // ── Methods ──
        public void .cctor(){} // RVA: 0x5CC6280
        public void .ctor(){} // RVA: 0x2DD310
        public void get_BinaryLength(){} // RVA: 0xD840
        public void get_Count(){} // RVA: 0xD840
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_Item(){} // RVA: 0x1BCC0
        public void set_Item(){} // RVA: 0x26C40
        public void get_Revision(){} // RVA: 0xDBE0
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void CopyTo(){} // RVA: 0x5CC62F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5CC6500
        public void GetBinaryForm(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x5CC6590
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5CC6630
    }

    public class GenericSecurityDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_BinaryLength(){} // RVA: 0x5CC6640
        public void get_ControlFlags(){} // RVA: 0xD840
        public void get_Group(){} // RVA: 0xCD60
        public void set_Group(){} // RVA: 0x24B10
        public void get_Owner(){} // RVA: 0xCD60
        public void set_Owner(){} // RVA: 0x24B10
        public void get_Revision(){} // RVA: 0x3C2850
        public void get_InternalDacl(){} // RVA: 0x519240
        public void get_InternalSacl(){} // RVA: 0x519240
        public void get_InternalReservedField(){} // RVA: 0x2DD320
        public void GetBinaryForm(){} // RVA: 0x5CC6850
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x2DD320
        public void get_DaclPresent(){} // RVA: 0x5CC6EE0
        public void get_SaclPresent(){} // RVA: 0x5CC6F30
        public void WriteUShort(){} // RVA: 0x5CC6F80
        public void WriteInt(){} // RVA: 0x5CC6FC0
    }

    public class KnownAce
    {
        public int access_mask; // 0x18
        public System.Security.Principal.SecurityIdentifier identifier; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC7030 | overloaded x2
        public void get_AccessMask(){} // RVA: 0x5BED50
        public void set_AccessMask(){} // RVA: 0x6374E0
        public void get_SecurityIdentifier(){} // RVA: 0x30B0C0
        public void set_SecurityIdentifier(){} // RVA: 0x30B0D0
    }

    public class NativeObjectSecurity
    {
        public ExceptionFromErrorCode exception_from_error_code; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC7310 | overloaded x4
        public void ClearAccessControlSectionsModified(){} // RVA: 0x5CC7400
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x5CC74A0
        public void RaiseExceptionOnFailure(){} // RVA: 0x5CC76F0
        public void InternalGet(){} // RVA: 0x5CC77A0
        public void get_ResourceType(){} // RVA: 0x338CD0
        public void Win32GetHelper(){} // RVA: 0x5CC79F0
        public void GetSecurityInfo(){} // RVA: 0x5CC7D80
        public void LocalFree(){} // RVA: 0x5CC7EC0
        public void GetSecurityDescriptorLength(){} // RVA: 0x5CC7F40
        public void IsValidSecurityDescriptor(){} // RVA: 0x5CC7FC0
    }

    public class ObjectAce
    {
        public System.Guid object_ace_type; // 0x30
        public System.Guid inherited_object_type; // 0x40
        public 0x657EA070 object_ace_flags; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC84E0 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x5CC88D0
        public void get_InheritedObjectAceType(){} // RVA: 0x1FA6340
        public void set_InheritedObjectAceType(){} // RVA: 0x4469B20
        public void get_InheritedObjectAceTypePresent(){} // RVA: 0x5CC8930
        public void get_ObjectAceFlags(){} // RVA: 0x59C540
        public void set_ObjectAceFlags(){} // RVA: 0x65F570
        public void get_ObjectAceType(){} // RVA: 0x5CC8940
        public void set_ObjectAceType(){} // RVA: 0x5CC8950
        public void get_ObjectAceTypePresent(){} // RVA: 0x5CC8960
        public void GetBinaryForm(){} // RVA: 0x5CC8970
        public void ConvertType(){} // RVA: 0x5CC8BC0
        public void WriteGuid(){} // RVA: 0x5CC8CE0
        public void ReadGuid(){} // RVA: 0x5CC8D30
    }

    public class ObjectSecurity
    {
        public System.Security.AccessControl.CommonSecurityDescriptor descriptor; // 0x10
        public 0x657E9620 sections_modified; // 0x18
        public System.Threading.ReaderWriterLock rw_lock; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC8FE0 | overloaded x2
        public void get_AccessControlSectionsModified(){} // RVA: 0x5CC9220
        public void set_AccessControlSectionsModified(){} // RVA: 0x5CC92B0
        public void set_AccessRulesModified(){} // RVA: 0x5CC9330
        public void get_IsContainer(){} // RVA: 0x5CC9380
        public void get_IsDS(){} // RVA: 0x5CC93A0
        public void set_OwnerModified(){} // RVA: 0x5CC93C0
        public void GetOwner(){} // RVA: 0x5CC9410
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x5CC95B0
        public void PurgeAccessRules(){} // RVA: 0x5CC96D0
        public void SetOwner(){} // RVA: 0x5CC9940
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x5CC9A40
        public void CopySddlForm(){} // RVA: 0x5CC9B00
        public void ModifyAccess(){}
        public void Reading(){} // RVA: 0x5CC9D50
        public void ReadLock(){} // RVA: 0x5CC9DE0
        public void ReadUnlock(){} // RVA: 0x5CC9E10
        public void Writing(){} // RVA: 0x5CC9E30
        public void WriteLock(){} // RVA: 0x5CC9EB0
        public void WriteUnlock(){} // RVA: 0x5CC9EE0
        public void SidFromIR(){} // RVA: 0x5CC9F00
        public void SetAccessControlSectionsModified(){} // RVA: 0x5CCA020
    }

    public class PrivilegeNotHeldException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC0C20 | overloaded x2
        public void GetObjectData(){} // RVA: 0x5CC0D30
    }

    public class QualifiedAce
    {
        public byte[] opaque; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC7030 | overloaded x2
        public void get_AceQualifier(){} // RVA: 0x5CCA0E0
        public void get_IsCallback(){} // RVA: 0x5CCA210
        public void get_OpaqueLength(){} // RVA: 0x5CCA250
        public void GetOpaque(){} // RVA: 0x5CCA270
        public void SetOpaque(){} // RVA: 0x5CCA2F0
    }

    public class RawAcl
    {
        public byte revision; // 0x10
        public System.Collections.Generic.List`1<System.Security.AccessControl.GenericAce> list; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCA570 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x5CCA960
        public void get_Count(){} // RVA: 0x5CCAAE0
        public void get_Item(){} // RVA: 0x5CCAB30
        public void set_Item(){} // RVA: 0x5CCABB0
        public void get_Revision(){} // RVA: 0x3A75E0
        public void GetBinaryForm(){} // RVA: 0x5CCAC30
        public void InsertAce(){} // RVA: 0x5CCAFA0
        public void RemoveAce(){} // RVA: 0x5CCB080
        public void WriteUShort(){} // RVA: 0x5CC6F80
        public void ReadUShort(){} // RVA: 0x5CCB0E0
    }

    public class RawSecurityDescriptor
    {
        public 0x657E9BF8 control_flags; // 0x10
        public System.Security.Principal.SecurityIdentifier owner_sid; // 0x18
        public System.Security.Principal.SecurityIdentifier group_sid; // 0x20
        public System.Security.AccessControl.RawAcl system_acl; // 0x28
        public System.Security.AccessControl.RawAcl discretionary_acl; // 0x30
        public byte resourcemgr_control; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCB120
        public void get_ControlFlags(){} // RVA: 0x32A5C0
        public void get_DiscretionaryAcl(){} // RVA: 0x6374D0
        public void get_Group(){} // RVA: 0x30B0C0
        public void set_Group(){} // RVA: 0x30B0D0
        public void get_Owner(){} // RVA: 0x2E07C0
        public void set_Owner(){} // RVA: 0x343E80
        public void get_ResourceManagerControl(){} // RVA: 0x4A6500
        public void get_SystemAcl(){} // RVA: 0x30B130
        public void get_InternalDacl(){} // RVA: 0x6374D0
        public void get_InternalSacl(){} // RVA: 0x30B130
        public void get_InternalReservedField(){} // RVA: 0x4A6500
        public void ReadUShort(){} // RVA: 0x5CCB0E0
        public void ReadInt(){} // RVA: 0x5CCB580
    }

    public class SystemAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CC52E0
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x5CCB5F0
        public void GetAceInsertPosition(){} // RVA: 0x519240
        public void IsAceMeaningless(){} // RVA: 0x5CCB620
        public void IsValidAuditFlags(){} // RVA: 0x5CCB730
    }

}