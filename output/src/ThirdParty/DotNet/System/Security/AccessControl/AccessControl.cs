// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 20
// Methods: 218

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule : AuthorizationRule
    {
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x673A4C0
        public void get_AccessControlType(){} // RVA: 0x1065D50
    }

    public class AceEnumerator : Object
    {
        public object owner;
        public object current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x39EC7C0
        public void get_Current(){} // RVA: 0x673A560
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x673A560
        public void MoveNext(){} // RVA: 0x673A5A0
        public void Reset(){} // RVA: 0x2576860
    }

    public class AuthorizationRule : Object
    {
        public object identity;
        public object accessMask;
        public object isInherited;
        public object inheritanceFlags;
        public object propagationFlags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x673A600
        public void get_IdentityReference(){} // RVA: 0xB5DBF0
        public void get_InheritanceFlags(){} // RVA: 0xFEAE90
        public void get_PropagationFlags(){} // RVA: 0x15AF000
        public void get_AccessMask(){} // RVA: 0xE62D00
    }

    public class CommonAce : QualifiedAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x673A9F0
        public void get_BinaryLength(){} // RVA: 0x673ACB0
        public void GetBinaryForm(){} // RVA: 0x673AD00
        public void ConvertType(){} // RVA: 0x673AE60
    }

    public class CommonAcl : GenericAcl
    {
        public object is_aefa;
        public object is_canonical;
        public object is_container;
        public object is_ds;
        public object raw_acl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x673B270
        public void Init(){} // RVA: 0x673B3F0
        public void get_BinaryLength(){} // RVA: 0x6670120
        public void get_Count(){} // RVA: 0x673B450
        public void get_IsCanonical(){} // RVA: 0xDD5C50
        public void get_IsContainer(){} // RVA: 0x22201E0
        public void get_IsDS(){} // RVA: 0x2220200
        public void get_IsAefa(){} // RVA: 0xC120A0
        public void set_IsAefa(){} // RVA: 0xC120B0
        public void get_Revision(){} // RVA: 0x673B480
        public void get_Item(){} // RVA: 0x673B4B0
        public void set_Item(){} // RVA: 0x673B570
        public void GetBinaryForm(){} // RVA: 0x673B5B0
        public void Purge(){} // RVA: 0x673B5E0
        public void RequireCanonicity(){} // RVA: 0x673B750
        public void CanonicalizeAndClearAefa(){} // RVA: 0x673B7C0
        public void IsAceMeaningless(){} // RVA: 0x673B980
        public void TestCanonicity(){} // RVA: 0x673BAA0
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x673BD80
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x673BEE0
        public void MergeExplicitAces(){} // RVA: 0x673BF60
        public void MergeExplicitAcePair(){} // RVA: 0x673C080
        public void GetObjectAceTypeGuids(){} // RVA: 0x673C760
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x673C800
        public void RemoveAces(){} // RVA: 0x894320
        public void AddAce(){} // RVA: 0x673CC40
        public void AddAceGetQualifiedAce(){} // RVA: 0x673CA50
        public void CopyAce(){} // RVA: 0x673CE40
        public void GetAceInsertPosition(){} // RVA: 0x881C20
        public void GetAceFlags(){} // RVA: 0x673CEE0
        public void RemoveAceSpecific(){} // RVA: 0x673D030
        public void SetAce(){} // RVA: 0x673D390
    }

    public class CommonObjectSecurity : ObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x673D900
        public void AddAccessRule(){} // RVA: 0x673D910
        public void ModifyAccess(){} // RVA: 0x673D950
    }

    public class CommonSecurityDescriptor : GenericSecurityDescriptor
    {
        public object is_container;
        public object is_ds;
        public object flags;
        public object owner;
        public object group;
        public object system_acl;
        public object discretionary_acl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x673E0B0
        public void Init(){} // RVA: 0x673E290
        public void get_ControlFlags(){} // RVA: 0x673E360
        public void get_DiscretionaryAcl(){} // RVA: 0xD33E60
        public void set_DiscretionaryAcl(){} // RVA: 0x673E380
        public void get_InternalDacl(){} // RVA: 0xD33E60
        public void get_Group(){} // RVA: 0xB700F0
        public void set_Group(){} // RVA: 0xB70100
        public void get_IsContainer(){} // RVA: 0xC120A0
        public void get_IsDS(){} // RVA: 0xDD5C50
        public void get_Owner(){} // RVA: 0xB465B0
        public void set_Owner(){} // RVA: 0xBA9BA0
        public void get_SystemAcl(){} // RVA: 0xB70160
        public void set_SystemAcl(){} // RVA: 0x673E5E0
        public void get_InternalSacl(){} // RVA: 0xB70160
        public void PurgeAccessControl(){} // RVA: 0x673E660
        public void CheckAclConsistency(){} // RVA: 0x673E7D0
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x673E8A0
    }

    public class DiscretionaryAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x673E8C0
        public void AddAccess(){} // RVA: 0x673E8D0
        public void RemoveAccess(){} // RVA: 0x673E940
        public void RemoveAccessSpecific(){} // RVA: 0x673E980
        public void SetAccess(){} // RVA: 0x673EB40
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x673ED10
        public void GetAceInsertPosition(){} // RVA: 0x673ED70
        public void GetAceQualifier(){} // RVA: 0x673ED80
        public void IsAceMeaningless(){} // RVA: 0x673EDF0
    }

    public class GenericAce : Object
    {
        public object ace_flags;
        public object ace_type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x673EF70
        public void get_AceFlags(){} // RVA: 0xC120A0
        public void get_AceType(){} // RVA: 0xDD5C50
        public void get_AuditFlags(){} // RVA: 0x673F0A0
        public void get_BinaryLength(){} // RVA: 0x87C130
        public void get_InheritanceFlags(){} // RVA: 0x673F0C0
        public void get_IsInherited(){} // RVA: 0x673F0E0
        public void get_PropagationFlags(){} // RVA: 0x673F0F0
        public void CreateFromBinaryForm(){} // RVA: 0x673F110
        public void Equals(){} // RVA: 0x673F2D0
        public void GetBinaryForm(){} // RVA: 0x899290
        public void GetHashCode(){} // RVA: 0x673F360
        public void op_Equality(){} // RVA: 0x673F430
        public void op_Inequality(){} // RVA: 0x673F5A0
        public void IsObjectType(){} // RVA: 0x673F710
        public void ReadUShort(){} // RVA: 0x673F730
        public void ReadInt(){} // RVA: 0x673F770
        public void WriteInt(){} // RVA: 0x673F7E0
        public void WriteUShort(){} // RVA: 0x673F850
    }

    public class GenericAcl : Object
    {
        public object AclRevision;
        public object AclRevisionDS;
        public object MaxBinaryLength;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x673F890
        public void .ctor(){} // RVA: 0xB43310
        public void get_BinaryLength(){} // RVA: 0x87C130
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_Item(){} // RVA: 0x87C160
        public void set_Item(){} // RVA: 0x895750
        public void get_Revision(){} // RVA: 0x87D280
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void CopyTo(){} // RVA: 0x673F900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x673FB10
        public void GetBinaryForm(){} // RVA: 0x899290
        public void GetEnumerator(){} // RVA: 0x673FBA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x673FC40
    }

    public class GenericSecurityDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_BinaryLength(){} // RVA: 0x673FC50
        public void get_ControlFlags(){} // RVA: 0x87C130
        public void get_Group(){} // RVA: 0x87C0A0
        public void set_Group(){} // RVA: 0x894320
        public void get_Owner(){} // RVA: 0x87C0A0
        public void set_Owner(){} // RVA: 0x894320
        public void get_Revision(){} // RVA: 0xC2E4C0
        public void get_InternalDacl(){} // RVA: 0xDAC980
        public void get_InternalSacl(){} // RVA: 0xDAC980
        public void get_InternalReservedField(){} // RVA: 0xB43320
        public void GetBinaryForm(){} // RVA: 0x673FE60
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0xB43320
        public void get_DaclPresent(){} // RVA: 0x67404F0
        public void get_SaclPresent(){} // RVA: 0x6740540
        public void WriteUShort(){} // RVA: 0x6740590
        public void WriteInt(){} // RVA: 0x67405D0
    }

    public class KnownAce : GenericAce
    {
        public object access_mask;
        public object identifier;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6740640
        public void get_AccessMask(){} // RVA: 0xE62D00
        public void set_AccessMask(){} // RVA: 0x1033F40
        public void get_SecurityIdentifier(){} // RVA: 0xB700F0
        public void set_SecurityIdentifier(){} // RVA: 0xB70100
    }

    public class NativeObjectSecurity : CommonObjectSecurity
    {
        public object exception_from_error_code;
        public object resource_type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6740910
        public void ClearAccessControlSectionsModified(){} // RVA: 0x6740A00
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x6740AA0
        public void RaiseExceptionOnFailure(){} // RVA: 0x6740CF0
        public void InternalGet(){} // RVA: 0x6740DA0
        public void get_ResourceType(){} // RVA: 0xB9E080
        public void Win32GetHelper(){} // RVA: 0x6740FF0
        public void GetSecurityInfo(){} // RVA: 0x6741380
        public void LocalFree(){} // RVA: 0x67414C0
        public void GetSecurityDescriptorLength(){} // RVA: 0x6741540
        public void IsValidSecurityDescriptor(){} // RVA: 0x67415C0
    }

    public class ObjectAce : QualifiedAce
    {
        public object object_ace_type;
        public object inherited_object_type;
        public object object_ace_flags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6741AE0
        public void get_BinaryLength(){} // RVA: 0x6741ED0
        public void get_InheritedObjectAceType(){} // RVA: 0x16DCC90
        public void set_InheritedObjectAceType(){} // RVA: 0x16DCEE0
        public void get_InheritedObjectAceTypePresent(){} // RVA: 0x6741F30
        public void get_ObjectAceFlags(){} // RVA: 0xE32C80
        public void set_ObjectAceFlags(){} // RVA: 0xEEA060
        public void get_ObjectAceType(){} // RVA: 0x16CD820
        public void set_ObjectAceType(){} // RVA: 0x16DCEF0
        public void get_ObjectAceTypePresent(){} // RVA: 0x6741F40
        public void GetBinaryForm(){} // RVA: 0x6741F50
        public void ConvertType(){} // RVA: 0x67421A0
        public void WriteGuid(){} // RVA: 0x67422C0
        public void ReadGuid(){} // RVA: 0x6742310
    }

    public class ObjectSecurity : Object
    {
        public object descriptor;
        public object sections_modified;
        public object rw_lock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67425C0
        public void get_AccessControlSectionsModified(){} // RVA: 0x6742850
        public void set_AccessControlSectionsModified(){} // RVA: 0x67428E0
        public void set_AccessRulesModified(){} // RVA: 0x6742960
        public void get_IsContainer(){} // RVA: 0x67429B0
        public void get_IsDS(){} // RVA: 0x67429D0
        public void set_OwnerModified(){} // RVA: 0x67429F0
        public void GetOwner(){} // RVA: 0x6742A40
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x6742BE0
        public void PurgeAccessRules(){} // RVA: 0x6742D00
        public void SetOwner(){} // RVA: 0x6742F70
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x6743070
        public void CopySddlForm(){} // RVA: 0x6743130
        public void ModifyAccess(){} // RVA: 0x87EA40
        public void Reading(){} // RVA: 0x6743380
        public void ReadLock(){} // RVA: 0x6743410
        public void ReadUnlock(){} // RVA: 0x6743440
        public void Writing(){} // RVA: 0x6743460
        public void WriteLock(){} // RVA: 0x67434E0
        public void WriteUnlock(){} // RVA: 0x6743510
        public void SidFromIR(){} // RVA: 0x6743530
        public void SetAccessControlSectionsModified(){} // RVA: 0x6743680
    }

    public class PrivilegeNotHeldException : UnauthorizedAccessException
    {
        public object _privilegeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x673A220
        public void GetObjectData(){} // RVA: 0x673A330
    }

    public class QualifiedAce : KnownAce
    {
        public object opaque;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6740640
        public void get_AceQualifier(){} // RVA: 0x6743740
        public void get_IsCallback(){} // RVA: 0x6743870
        public void get_OpaqueLength(){} // RVA: 0x67438B0
        public void GetOpaque(){} // RVA: 0x67438D0
        public void SetOpaque(){} // RVA: 0x6743950
    }

    public class RawAcl : GenericAcl
    {
        public object revision;
        public object list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6743BD0
        public void get_BinaryLength(){} // RVA: 0x6743FC0
        public void get_Count(){} // RVA: 0x6744150
        public void get_Item(){} // RVA: 0x67441A0
        public void set_Item(){} // RVA: 0x6744220
        public void get_Revision(){} // RVA: 0xC120A0
        public void GetBinaryForm(){} // RVA: 0x67442A0
        public void InsertAce(){} // RVA: 0x6744600
        public void RemoveAce(){} // RVA: 0x67446E0
        public void WriteUShort(){} // RVA: 0x6740590
        public void ReadUShort(){} // RVA: 0x6744740
    }

    public class RawSecurityDescriptor : GenericSecurityDescriptor
    {
        public object control_flags;
        public object owner_sid;
        public object group_sid;
        public object system_acl;
        public object discretionary_acl;
        public object resourcemgr_control;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6744780
        public void get_ControlFlags(){} // RVA: 0xB8F8F0
        public void get_DiscretionaryAcl(){} // RVA: 0xD33E60
        public void get_Group(){} // RVA: 0xB700F0
        public void set_Group(){} // RVA: 0xB70100
        public void get_Owner(){} // RVA: 0xB465B0
        public void set_Owner(){} // RVA: 0xBA9BA0
        public void get_ResourceManagerControl(){} // RVA: 0xD16660
        public void get_SystemAcl(){} // RVA: 0xB70160
        public void get_InternalDacl(){} // RVA: 0xD33E60
        public void get_InternalSacl(){} // RVA: 0xB70160
        public void get_InternalReservedField(){} // RVA: 0xD16660
        public void ReadUShort(){} // RVA: 0x6744740
        public void ReadInt(){} // RVA: 0x6744BE0
    }

    public class SystemAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x673E8C0
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x6744C50
        public void GetAceInsertPosition(){} // RVA: 0xDAC980
        public void IsAceMeaningless(){} // RVA: 0x6744C80
        public void IsValidAuditFlags(){} // RVA: 0x6744D90
    }

}