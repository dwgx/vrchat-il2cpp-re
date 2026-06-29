// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 20
// Methods: 218

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule : AuthorizationRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAAF090
        public void get_AccessControlType(){} // RVA: 0x7A854FDE0
    }

    public class AceEnumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAD8AD80
        public void get_Current(){} // RVA: 0x7ADAAF130
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ADAAF130
        public void MoveNext(){} // RVA: 0x7ADAAF170
        public void Reset(){} // RVA: 0x7A9ACA7B0
    }

    public class AuthorizationRule : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAAF1D0
        public void get_IdentityReference(){} // RVA: 0x7A80F2570
        public void get_InheritanceFlags(){} // RVA: 0x7A851DB90
        public void get_PropagationFlags(){} // RVA: 0x7A8AB15F0
        public void get_AccessMask(){} // RVA: 0x7A83782A0
    }

    public class CommonAce : QualifiedAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAAF5C0
        public void get_BinaryLength(){} // RVA: 0x7ADAAF880
        public void GetBinaryForm(){} // RVA: 0x7ADAAF8D0
        public void ConvertType(){} // RVA: 0x7ADAAFA30
    }

    public class CommonAcl : GenericAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAAFE40
        public void Init(){} // RVA: 0x7ADAAFFC0
        public void get_BinaryLength(){} // RVA: 0x7AD9E5500
        public void get_Count(){} // RVA: 0x7ADAB0020
        public void get_IsCanonical(){} // RVA: 0x7A82FBFB0
        public void get_IsContainer(){} // RVA: 0x7A9716B70
        public void get_IsDS(){} // RVA: 0x7A9716C10
        public void get_IsAefa(){} // RVA: 0x7A81A2200
        public void set_IsAefa(){} // RVA: 0x7A81A2210
        public void get_Revision(){} // RVA: 0x7ADAB0050
        public void get_Item(){} // RVA: 0x7ADAB0080
        public void set_Item(){} // RVA: 0x7ADAB0140
        public void GetBinaryForm(){} // RVA: 0x7ADAB0180
        public void Purge(){} // RVA: 0x7ADAB01B0
        public void RequireCanonicity(){} // RVA: 0x7ADAB0320
        public void CanonicalizeAndClearAefa(){} // RVA: 0x7ADAB0390
        public void IsAceMeaningless(){} // RVA: 0x7ADAB0550
        public void TestCanonicity(){} // RVA: 0x7ADAB0670
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x7ADAB0950
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x7ADAB0AB0
        public void MergeExplicitAces(){} // RVA: 0x7ADAB0B30
        public void MergeExplicitAcePair(){} // RVA: 0x7ADAB0C50
        public void GetObjectAceTypeGuids(){} // RVA: 0x7ADAB1330
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7ADAB13D0
        public void RemoveAces(){} // RVA: 0x7A7E18800
        public void AddAce(){} // RVA: 0x7ADAB1810
        public void AddAceGetQualifiedAce(){} // RVA: 0x7ADAB1620
        public void CopyAce(){} // RVA: 0x7ADAB1A10
        public void GetAceInsertPosition(){} // RVA: 0x7A7E062A0
        public void GetAceFlags(){} // RVA: 0x7ADAB1AB0
        public void RemoveAceSpecific(){} // RVA: 0x7ADAB1C00
        public void SetAce(){} // RVA: 0x7ADAB1F60
    }

    public class CommonObjectSecurity : ObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB24D0
        public void AddAccessRule(){} // RVA: 0x7ADAB24E0
        public void ModifyAccess(){} // RVA: 0x7ADAB2520
    }

    public class CommonSecurityDescriptor : GenericSecurityDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB2C80
        public void Init(){} // RVA: 0x7ADAB2E60
        public void get_ControlFlags(){} // RVA: 0x7ADAB2F30
        public void get_DiscretionaryAcl(){} // RVA: 0x7A83F69F0
        public void set_DiscretionaryAcl(){} // RVA: 0x7ADAB2F50
        public void get_InternalDacl(){} // RVA: 0x7A83F69F0
        public void get_Group(){} // RVA: 0x7A81052C0
        public void set_Group(){} // RVA: 0x7A81052D0
        public void get_IsContainer(){} // RVA: 0x7A81A2200
        public void get_IsDS(){} // RVA: 0x7A82FBFB0
        public void get_Owner(){} // RVA: 0x7A80DA7B0
        public void set_Owner(){} // RVA: 0x7A813E420
        public void get_SystemAcl(){} // RVA: 0x7A8105330
        public void set_SystemAcl(){} // RVA: 0x7ADAB31B0
        public void get_InternalSacl(){} // RVA: 0x7A8105330
        public void PurgeAccessControl(){} // RVA: 0x7ADAB3230
        public void CheckAclConsistency(){} // RVA: 0x7ADAB33A0
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7ADAB3470
    }

    public class DiscretionaryAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB3490
        public void AddAccess(){} // RVA: 0x7ADAB34A0
        public void RemoveAccess(){} // RVA: 0x7ADAB3510
        public void RemoveAccessSpecific(){} // RVA: 0x7ADAB3550
        public void SetAccess(){} // RVA: 0x7ADAB3710
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7ADAB38E0
        public void GetAceInsertPosition(){} // RVA: 0x7ADAB3940
        public void GetAceQualifier(){} // RVA: 0x7ADAB3950
        public void IsAceMeaningless(){} // RVA: 0x7ADAB39C0
    }

    public class GenericAce : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB3B40
        public void get_AceFlags(){} // RVA: 0x7A81A2200
        public void get_AceType(){} // RVA: 0x7A82FBFB0
        public void get_AuditFlags(){} // RVA: 0x7ADAB3C80
        public void get_BinaryLength(){} // RVA: 0x7A7E00710
        public void get_InheritanceFlags(){} // RVA: 0x7ADAB3CA0
        public void get_IsInherited(){} // RVA: 0x7ADAB3CC0
        public void get_PropagationFlags(){} // RVA: 0x7ADAB3CD0
        public void CreateFromBinaryForm(){} // RVA: 0x7ADAB3CF0
        public void Equals(){} // RVA: 0x7ADAB3EC0
        public void GetBinaryForm(){} // RVA: 0x7A7E1D590
        public void GetHashCode(){} // RVA: 0x7ADAB3F50
        public void op_Equality(){} // RVA: 0x7ADAB4020
        public void op_Inequality(){} // RVA: 0x7ADAB4190
        public void IsObjectType(){} // RVA: 0x7ADAB4300
        public void ReadUShort(){} // RVA: 0x7ADAB4320
        public void ReadInt(){} // RVA: 0x7ADAB4360
        public void WriteInt(){} // RVA: 0x7ADAB43D0
        public void WriteUShort(){} // RVA: 0x7ADAB4440
    }

    public class GenericAcl : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADAB4480
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_BinaryLength(){} // RVA: 0x7A7E00710
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_Item(){} // RVA: 0x7A7E00740
        public void set_Item(){} // RVA: 0x7A7E19BE0
        public void get_Revision(){} // RVA: 0x7A7E01900
        public void get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void CopyTo(){} // RVA: 0x7ADAB44F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ADAB4700
        public void GetBinaryForm(){} // RVA: 0x7A7E1D590
        public void GetEnumerator(){} // RVA: 0x7ADAB4790
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADAB4830
    }

    public class GenericSecurityDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_BinaryLength(){} // RVA: 0x7ADAB4840
        public void get_ControlFlags(){} // RVA: 0x7A7E00710
        public void get_Group(){} // RVA: 0x7A7E00680
        public void set_Group(){} // RVA: 0x7A7E18800
        public void get_Owner(){} // RVA: 0x7A7E00680
        public void set_Owner(){} // RVA: 0x7A7E18800
        public void get_Revision(){} // RVA: 0x7A81BD750
        public void get_InternalDacl(){} // RVA: 0x7A82D1450
        public void get_InternalSacl(){} // RVA: 0x7A82D1450
        public void get_InternalReservedField(){} // RVA: 0x7A80D7320
        public void GetBinaryForm(){} // RVA: 0x7ADAB4A50
        public void get_DaclIsUnmodifiedAefa(){} // RVA: 0x7A80D7320
        public void get_DaclPresent(){} // RVA: 0x7ADAB50E0
        public void get_SaclPresent(){} // RVA: 0x7ADAB5130
        public void WriteUShort(){} // RVA: 0x7ADAB5180
        public void WriteInt(){} // RVA: 0x7ADAB51C0
    }

    public class KnownAce : GenericAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB5230
        public void get_AccessMask(){} // RVA: 0x7A83782A0
        public void set_AccessMask(){} // RVA: 0x7A84385B0
        public void get_SecurityIdentifier(){} // RVA: 0x7A81052C0
        public void set_SecurityIdentifier(){} // RVA: 0x7A81052D0
    }

    public class NativeObjectSecurity : CommonObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB5510
        public void ClearAccessControlSectionsModified(){} // RVA: 0x7ADAB5600
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x7ADAB56A0
        public void RaiseExceptionOnFailure(){} // RVA: 0x7ADAB58F0
        public void InternalGet(){} // RVA: 0x7ADAB59A0
        public void get_ResourceType(){} // RVA: 0x7A8133100
        public void Win32GetHelper(){} // RVA: 0x7ADAB5BF0
        public void GetSecurityInfo(){} // RVA: 0x7ADAB5F80
        public void LocalFree(){} // RVA: 0x7ADAB60C0
        public void GetSecurityDescriptorLength(){} // RVA: 0x7ADAB6140
        public void IsValidSecurityDescriptor(){} // RVA: 0x7ADAB61C0
    }

    public class ObjectAce : QualifiedAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB66E0
        public void get_BinaryLength(){} // RVA: 0x7ADAB6AD0
        public void get_InheritedObjectAceType(){} // RVA: 0x7A9DB2460
        public void set_InheritedObjectAceType(){} // RVA: 0x7AC257C80
        public void get_InheritedObjectAceTypePresent(){} // RVA: 0x7ADAB6B30
        public void get_ObjectAceFlags(){} // RVA: 0x7A8355950
        public void set_ObjectAceFlags(){} // RVA: 0x7A83F4180
        public void get_ObjectAceType(){} // RVA: 0x7ADAB6B40
        public void set_ObjectAceType(){} // RVA: 0x7ADAB6B50
        public void get_ObjectAceTypePresent(){} // RVA: 0x7ADAB6B60
        public void GetBinaryForm(){} // RVA: 0x7ADAB6B70
        public void ConvertType(){} // RVA: 0x7ADAB6DC0
        public void WriteGuid(){} // RVA: 0x7ADAB6EE0
        public void ReadGuid(){} // RVA: 0x7ADAB6F30
    }

    public class ObjectSecurity : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB71E0
        public void get_AccessControlSectionsModified(){} // RVA: 0x7ADAB7470
        public void set_AccessControlSectionsModified(){} // RVA: 0x7ADAB7500
        public void set_AccessRulesModified(){} // RVA: 0x7ADAB7580
        public void get_IsContainer(){} // RVA: 0x7ADAB75D0
        public void get_IsDS(){} // RVA: 0x7ADAB75F0
        public void set_OwnerModified(){} // RVA: 0x7ADAB7610
        public void GetOwner(){} // RVA: 0x7ADAB7660
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x7ADAB7800
        public void PurgeAccessRules(){} // RVA: 0x7ADAB7920
        public void SetOwner(){} // RVA: 0x7ADAB7B90
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x7ADAB7C90
        public void CopySddlForm(){} // RVA: 0x7ADAB7D50
        public void ModifyAccess(){} // RVA: 0x7A7E030C0
        public void Reading(){} // RVA: 0x7ADAB7FA0
        public void ReadLock(){} // RVA: 0x7ADAB8030
        public void ReadUnlock(){} // RVA: 0x7ADAB8060
        public void Writing(){} // RVA: 0x7ADAB8080
        public void WriteLock(){} // RVA: 0x7ADAB8100
        public void WriteUnlock(){} // RVA: 0x7ADAB8130
        public void SidFromIR(){} // RVA: 0x7ADAB8150
        public void SetAccessControlSectionsModified(){} // RVA: 0x7ADAB8270
    }

    public class PrivilegeNotHeldException : UnauthorizedAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAAEDC0
        public void GetObjectData(){} // RVA: 0x7ADAAEED0
    }

    public class QualifiedAce : KnownAce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB5230
        public void get_AceQualifier(){} // RVA: 0x7ADAB8330
        public void get_IsCallback(){} // RVA: 0x7ADAB8460
        public void get_OpaqueLength(){} // RVA: 0x7ADAB84A0
        public void GetOpaque(){} // RVA: 0x7ADAB84C0
        public void SetOpaque(){} // RVA: 0x7ADAB8540
    }

    public class RawAcl : GenericAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB87C0
        public void get_BinaryLength(){} // RVA: 0x7ADAB8BB0
        public void get_Count(){} // RVA: 0x7ADAB8D40
        public void get_Item(){} // RVA: 0x7ADAB8D90
        public void set_Item(){} // RVA: 0x7ADAB8E10
        public void get_Revision(){} // RVA: 0x7A81A2200
        public void GetBinaryForm(){} // RVA: 0x7ADAB8E90
        public void InsertAce(){} // RVA: 0x7ADAB91F0
        public void RemoveAce(){} // RVA: 0x7ADAB92D0
        public void WriteUShort(){} // RVA: 0x7ADAB5180
        public void ReadUShort(){} // RVA: 0x7ADAB9330
    }

    public class RawSecurityDescriptor : GenericSecurityDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB9370
        public void get_ControlFlags(){} // RVA: 0x7A8124910
        public void get_DiscretionaryAcl(){} // RVA: 0x7A83F69F0
        public void get_Group(){} // RVA: 0x7A81052C0
        public void set_Group(){} // RVA: 0x7A81052D0
        public void get_Owner(){} // RVA: 0x7A80DA7B0
        public void set_Owner(){} // RVA: 0x7A813E420
        public void get_ResourceManagerControl(){} // RVA: 0x7A82A20A0
        public void get_SystemAcl(){} // RVA: 0x7A8105330
        public void get_InternalDacl(){} // RVA: 0x7A83F69F0
        public void get_InternalSacl(){} // RVA: 0x7A8105330
        public void get_InternalReservedField(){} // RVA: 0x7A82A20A0
        public void ReadUShort(){} // RVA: 0x7ADAB9330
        public void ReadInt(){} // RVA: 0x7ADAB97D0
    }

    public class SystemAcl : CommonAcl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAB3490
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7ADAB9840
        public void GetAceInsertPosition(){} // RVA: 0x7A82D1450
        public void IsAceMeaningless(){} // RVA: 0x7ADAB9870
        public void IsValidAuditFlags(){} // RVA: 0x7ADAB9980
    }

}