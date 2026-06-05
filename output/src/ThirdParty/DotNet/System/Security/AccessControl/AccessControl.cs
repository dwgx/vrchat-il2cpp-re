// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 21
// Methods: 237

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule
    {
        public object IdentityReference;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8770EF0
        public void get_AccessControlType(){} // RVA: 0x7FFAF3241DC0
    }

    public class AceEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5A43A00
        public void get_Current(){} // RVA: 0x7FFAF8770F90
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF8770F90
        public void MoveNext(){} // RVA: 0x7FFAF8770FD0
        public void Reset(){} // RVA: 0x7FFAF4778140
    }

    public class AuthorizationRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8771030
        public void get_IdentityReference(){} // RVA: 0x7FFAF2DA8380
        public void get_InheritanceFlags(){} // RVA: 0x7FFAF3210030
        public void get_PropagationFlags(){} // RVA: 0x7FFAF379F5B0
        public void get_AccessMask(){} // RVA: 0x7FFAF306ED50
    }

    public class CommonAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8771420 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFAF87716E0
        public void GetBinaryForm(){} // RVA: 0x7FFAF8771730
        public void ConvertType(){} // RVA: 0x7FFAF8771890
    }

    public class CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8771C90 | overloaded x3
        public void Init(){} // RVA: 0x7FFAF8771E10
        public void get_BinaryLength(){} // RVA: 0x7FFAF86A76F0
        public void get_Count(){} // RVA: 0x7FFAF8771E70
        public void get_IsCanonical(){} // RVA: 0x7FFAF2FF3460
        public void get_IsContainer(){} // RVA: 0x7FFAF440A940
        public void get_IsDS(){} // RVA: 0x7FFAF440A9E0
        public void get_IsAefa(){} // RVA: 0x7FFAF2E575E0
        public void set_IsAefa(){} // RVA: 0x7FFAF2E575F0
        public void get_Revision(){} // RVA: 0x7FFAF8771EA0
        public void get_Item(){} // RVA: 0x7FFAF8771ED0
        public void set_Item(){} // RVA: 0x7FFAF8771F90
        public void GetBinaryForm(){} // RVA: 0x7FFAF8771FD0
        public void Purge(){} // RVA: 0x7FFAF8772000
        public void RequireCanonicity(){} // RVA: 0x7FFAF8772170
        public void CanonicalizeAndClearAefa(){} // RVA: 0x7FFAF87721E0
        public void IsAceMeaningless(){} // RVA: 0x7FFAF87723A0
        public void TestCanonicity(){} // RVA: 0x7FFAF87724B0
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x7FFAF87727B0
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x7FFAF8772910
        public void MergeExplicitAces(){} // RVA: 0x7FFAF8772990
        public void MergeExplicitAcePair(){} // RVA: 0x7FFAF8772AB0
        public void GetObjectAceTypeGuids(){} // RVA: 0x7FFAF8773190
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFAF8773230 | overloaded x2
        public void RemoveAces(){} // RVA: 0x7FFAF2AD4B10
        public void AddAce(){} // RVA: 0x7FFAF8773670 | overloaded x2
        public void AddAceGetQualifiedAce(){} // RVA: 0x7FFAF8773480
        public void CopyAce(){} // RVA: 0x7FFAF8773870
        public void GetAceInsertPosition(){} // RVA: 0x7FFAF2AC3FB0
        public void GetAceFlags(){} // RVA: 0x7FFAF8773910
        public void RemoveAceSpecific(){} // RVA: 0x7FFAF8773A60
        public void SetAce(){} // RVA: 0x7FFAF8773DC0 | overloaded x2
    }

    public class CommonObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8774330
        public void AddAccessRule(){} // RVA: 0x7FFAF8774340
        public void ModifyAccess(){} // RVA: 0x7FFAF8774380
    }

    public class CommonSecurityDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8774AE0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAF8774CC0 | overloaded x2
        public void get_ControlFlags(){} // RVA: 0x7FFAF8774D90
        public void get_DiscretionaryAcl(){} // RVA: 0x7FFAF30E74D0
        public void set_DiscretionaryAcl(){} // RVA: 0x7FFAF8774DB0
        public void get_InternalDacl(){} // RVA: 0x7FFAF30E74D0
        public void get_Group(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Group(){} // RVA: 0x7FFAF2DBB0D0
        public void get_IsContainer(){} // RVA: 0x7FFAF2E575E0
        public void get_IsDS(){} // RVA: 0x7FFAF2FF3460
        public void get_Owner(){} // RVA: 0x7FFAF2D907C0
        public void set_Owner(){} // RVA: 0x7FFAF2DF3E80
        public void get_SystemAcl(){} // RVA: 0x7FFAF2DBB130
        public void set_SystemAcl(){} // RVA: 0x7FFAF8775000
        public void get_InternalSacl(){} // RVA: 0x7FFAF2DBB130
        public void PurgeAccessControl(){} // RVA: 0x7FFAF8775080
        public void CheckAclConsistency(){} // RVA: 0x7FFAF87751F0
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7FFAF87752C0
    }

    public class CryptoKeySecurity
    {
    }

    public class DiscretionaryAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87752E0 | overloaded x2
        public void AddAccess(){} // RVA: 0x7FFAF87752F0
        public void RemoveAccess(){} // RVA: 0x7FFAF8775360
        public void RemoveAccessSpecific(){} // RVA: 0x7FFAF87753A0
        public void SetAccess(){} // RVA: 0x7FFAF8775540
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFAF8775710
        public void GetAceInsertPosition(){} // RVA: 0x7FFAF8775770
        public void GetAceQualifier(){} // RVA: 0x7FFAF8775780
        public void IsAceMeaningless(){} // RVA: 0x7FFAF87757F0
    }

    public class GenericAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8775970 | overloaded x2
        public void get_AceFlags(){} // RVA: 0x7FFAF2E575E0
        public void get_AceType(){} // RVA: 0x7FFAF2FF3460
        public void get_AuditFlags(){} // RVA: 0x7FFAF8775AB0
        public void get_BinaryLength(){} // RVA: 0x7FFAF2ABD840
        public void get_InheritanceFlags(){} // RVA: 0x7FFAF8775AD0
        public void get_IsInherited(){} // RVA: 0x7FFAF8775AF0
        public void get_PropagationFlags(){} // RVA: 0x7FFAF8775B00
        public void CreateFromBinaryForm(){} // RVA: 0x7FFAF8775B20
        public void Equals(){} // RVA: 0x7FFAF8775CE0
        public void GetBinaryForm(){} // RVA: 0x7FFAF2ADBAA0
        public void GetHashCode(){} // RVA: 0x7FFAF8775D70
        public void op_Equality(){} // RVA: 0x7FFAF8775E40
        public void op_Inequality(){} // RVA: 0x7FFAF8775FA0
        public void IsObjectType(){} // RVA: 0x7FFAF8776100
        public void ReadUShort(){} // RVA: 0x7FFAF8776120
        public void ReadInt(){} // RVA: 0x7FFAF8776160
        public void WriteInt(){} // RVA: 0x7FFAF87761D0
        public void WriteUShort(){} // RVA: 0x7FFAF8776240
    }

    public class GenericAcl
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8776280
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_BinaryLength(){} // RVA: 0x7FFAF2ABD840
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void get_Item(){} // RVA: 0x7FFAF2ACBCC0
        public void set_Item(){} // RVA: 0x7FFAF2AD6C40
        public void get_Revision(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void CopyTo(){} // RVA: 0x7FFAF87762F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF8776500
        public void GetBinaryForm(){} // RVA: 0x7FFAF2ADBAA0
        public void GetEnumerator(){} // RVA: 0x7FFAF8776590
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8776630
    }

    public class GenericSecurityDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_BinaryLength(){} // RVA: 0x7FFAF8776640
        public void get_ControlFlags(){} // RVA: 0x7FFAF2ABD840
        public void get_Group(){} // RVA: 0x7FFAF2ABCD60
        public void set_Group(){} // RVA: 0x7FFAF2AD4B10
        public void get_Owner(){} // RVA: 0x7FFAF2ABCD60
        public void set_Owner(){} // RVA: 0x7FFAF2AD4B10
        public void get_Revision(){} // RVA: 0x7FFAF2E72850
        public void get_InternalDacl(){} // RVA: 0x7FFAF2FC9240
        public void get_InternalSacl(){} // RVA: 0x7FFAF2FC9240
        public void get_InternalReservedField(){} // RVA: 0x7FFAF2D8D320
        public void GetBinaryForm(){} // RVA: 0x7FFAF8776850
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7FFAF2D8D320
        public void get_DaclPresent(){} // RVA: 0x7FFAF8776EE0
        public void get_SaclPresent(){} // RVA: 0x7FFAF8776F30
        public void WriteUShort(){} // RVA: 0x7FFAF8776F80
        public void WriteInt(){} // RVA: 0x7FFAF8776FC0
    }

    public class KnownAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8777030 | overloaded x2
        public void get_AccessMask(){} // RVA: 0x7FFAF306ED50
        public void set_AccessMask(){} // RVA: 0x7FFAF30E74E0
        public void get_SecurityIdentifier(){} // RVA: 0x7FFAF2DBB0C0
        public void set_SecurityIdentifier(){} // RVA: 0x7FFAF2DBB0D0
    }

    public class NativeObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8777310 | overloaded x4
        public void ClearAccessControlSectionsModified(){} // RVA: 0x7FFAF8777400
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x7FFAF87774A0
        public void RaiseExceptionOnFailure(){} // RVA: 0x7FFAF87776F0
        public void InternalGet(){} // RVA: 0x7FFAF87777A0
        public void get_ResourceType(){} // RVA: 0x7FFAF2DE8CD0
        public void Win32GetHelper(){} // RVA: 0x7FFAF87779F0
        public void GetSecurityInfo(){} // RVA: 0x7FFAF8777D80
        public void LocalFree(){} // RVA: 0x7FFAF8777EC0
        public void GetSecurityDescriptorLength(){} // RVA: 0x7FFAF8777F40
        public void IsValidSecurityDescriptor(){} // RVA: 0x7FFAF8777FC0
    }

    public class ObjectAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87784E0 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFAF87788D0
        public void get_InheritedObjectAceType(){} // RVA: 0x7FFAF4A56340
        public void set_InheritedObjectAceType(){} // RVA: 0x7FFAF6F19B20
        public void get_InheritedObjectAceTypePresent(){} // RVA: 0x7FFAF8778930
        public void get_ObjectAceFlags(){} // RVA: 0x7FFAF304C540
        public void set_ObjectAceFlags(){} // RVA: 0x7FFAF310F570
        public void get_ObjectAceType(){} // RVA: 0x7FFAF8778940
        public void set_ObjectAceType(){} // RVA: 0x7FFAF8778950
        public void get_ObjectAceTypePresent(){} // RVA: 0x7FFAF8778960
        public void GetBinaryForm(){} // RVA: 0x7FFAF8778970
        public void ConvertType(){} // RVA: 0x7FFAF8778BC0
        public void WriteGuid(){} // RVA: 0x7FFAF8778CE0
        public void ReadGuid(){} // RVA: 0x7FFAF8778D30
    }

    public class ObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8778FE0 | overloaded x2
        public void get_AccessControlSectionsModified(){} // RVA: 0x7FFAF8779220
        public void set_AccessControlSectionsModified(){} // RVA: 0x7FFAF87792B0
        public void set_AccessRulesModified(){} // RVA: 0x7FFAF8779330
        public void get_IsContainer(){} // RVA: 0x7FFAF8779380
        public void get_IsDS(){} // RVA: 0x7FFAF87793A0
        public void set_OwnerModified(){} // RVA: 0x7FFAF87793C0
        public void GetOwner(){} // RVA: 0x7FFAF8779410
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFAF87795B0
        public void PurgeAccessRules(){} // RVA: 0x7FFAF87796D0
        public void SetOwner(){} // RVA: 0x7FFAF8779940
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFAF8779A40
        public void CopySddlForm(){} // RVA: 0x7FFAF8779B00
        public void ModifyAccess(){}
        public void Reading(){} // RVA: 0x7FFAF8779D50
        public void ReadLock(){} // RVA: 0x7FFAF8779DE0
        public void ReadUnlock(){} // RVA: 0x7FFAF8779E10
        public void Writing(){} // RVA: 0x7FFAF8779E30
        public void WriteLock(){} // RVA: 0x7FFAF8779EB0
        public void WriteUnlock(){} // RVA: 0x7FFAF8779EE0
        public void SidFromIR(){} // RVA: 0x7FFAF8779F00
        public void SetAccessControlSectionsModified(){} // RVA: 0x7FFAF877A020
    }

    public class PrivilegeNotHeldException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8770C20 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAF8770D30
    }

    public class QualifiedAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8777030 | overloaded x2
        public void get_AceQualifier(){} // RVA: 0x7FFAF877A0E0
        public void get_IsCallback(){} // RVA: 0x7FFAF877A210
        public void get_OpaqueLength(){} // RVA: 0x7FFAF877A250
        public void GetOpaque(){} // RVA: 0x7FFAF877A270
        public void SetOpaque(){} // RVA: 0x7FFAF877A2F0
    }

    public class RawAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877A570 | overloaded x2
        public void get_BinaryLength(){} // RVA: 0x7FFAF877A960
        public void get_Count(){} // RVA: 0x7FFAF877AAE0
        public void get_Item(){} // RVA: 0x7FFAF877AB30
        public void set_Item(){} // RVA: 0x7FFAF877ABB0
        public void get_Revision(){} // RVA: 0x7FFAF2E575E0
        public void GetBinaryForm(){} // RVA: 0x7FFAF877AC30
        public void InsertAce(){} // RVA: 0x7FFAF877AFA0
        public void RemoveAce(){} // RVA: 0x7FFAF877B080
        public void WriteUShort(){} // RVA: 0x7FFAF8776F80
        public void ReadUShort(){} // RVA: 0x7FFAF877B0E0
    }

    public class RawSecurityDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877B120
        public void get_ControlFlags(){} // RVA: 0x7FFAF2DDA5C0
        public void get_DiscretionaryAcl(){} // RVA: 0x7FFAF30E74D0
        public void get_Group(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Group(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Owner(){} // RVA: 0x7FFAF2D907C0
        public void set_Owner(){} // RVA: 0x7FFAF2DF3E80
        public void get_ResourceManagerControl(){} // RVA: 0x7FFAF2F56500
        public void get_SystemAcl(){} // RVA: 0x7FFAF2DBB130
        public void get_InternalDacl(){} // RVA: 0x7FFAF30E74D0
        public void get_InternalSacl(){} // RVA: 0x7FFAF2DBB130
        public void get_InternalReservedField(){} // RVA: 0x7FFAF2F56500
        public void ReadUShort(){} // RVA: 0x7FFAF877B0E0
        public void ReadInt(){} // RVA: 0x7FFAF877B580
    }

    public class SystemAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87752E0
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFAF877B5F0
        public void GetAceInsertPosition(){} // RVA: 0x7FFAF2FC9240
        public void IsAceMeaningless(){} // RVA: 0x7FFAF877B620
        public void IsValidAuditFlags(){} // RVA: 0x7FFAF877B730
    }

}