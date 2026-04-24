// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 7
// Methods: 98

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class AccessRule : AuthorizationRule
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade79690
        public void get_AccessControlType(){} // RVA: 0x7ffaa8d14570
    }

    public class AuthorizationRule : Object
    {
        public object isInherited; // 0x35DB1670

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade797d0
        public void get_IdentityReference(){} // RVA: 0x7ffaa894d380
        public void get_InheritanceFlags(){} // RVA: 0x7ffaa8aeced0
        public void get_PropagationFlags(){} // RVA: 0x7ffaa9349010
        public void get_AccessMask(){} // RVA: 0x7ffaa8b945a0
    }

    public class CommonAcl : GenericAcl
    {
        public object is_container; // 0x31360B80

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade7a430
        public void .ctor(){} // RVA: 0x7ffaade7a430
        public void .ctor(){} // RVA: 0x7ffaade7a430
        public void Init(){} // RVA: 0x7ffaade7a5b0
        public void get_BinaryLength(){} // RVA: 0x7ffaaddafdf0
        public void get_Count(){} // RVA: 0x7ffaade7a610
        public void get_IsCanonical(){} // RVA: 0x7ffaa8b37c40
        public void get_IsContainer(){} // RVA: 0x7ffaa950f430
        public void get_IsDS(){} // RVA: 0x7ffaa9e38fa0
        public void get_IsAefa(){} // RVA: 0x7ffaa89fc5e0
        public void set_IsAefa(){} // RVA: 0x7ffaa89fc5f0
        public void get_Revision(){} // RVA: 0x7ffaade7a640
        public void get_Item(){} // RVA: 0x7ffaade7a670
        public void set_Item(){} // RVA: 0x7ffaade7a730
        public void Purge(){} // RVA: 0x7ffaade7a7a0
        public void RequireCanonicity(){} // RVA: 0x7ffaade7a910
        public void CanonicalizeAndClearAefa(){} // RVA: 0x7ffaade7a980
        public void IsAceMeaningless(){} // RVA: 0x7ffaade7ab40
        public void TestCanonicity(){} // RVA: 0x7ffaade7ac50
        public void MergeExplicitAces(){} // RVA: 0x7ffaade7b130
        public void MergeExplicitAcePair(){} // RVA: 0x7ffaade7b250
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7ffaade7b9d0
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7ffaade7b9d0
        public void RemoveAces(){} // RVA: 0x7ffaa8660d80
        public void AddAce(){} // RVA: 0x7ffaade7be10
        public void AddAceGetQualifiedAce(){} // RVA: 0x7ffaade7bc20
        public void AddAce(){} // RVA: 0x7ffaade7be10
        public void CopyAce(){} // RVA: 0x7ffaade7c010
        public void RemoveAceSpecific(){} // RVA: 0x7ffaade7c200
        // ── Binary Analysis Named ──
        public void GetBinaryForm(){} // RVA: 0x7ffaade7a770
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x7ffaade7af50
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x7ffaade7b0b0
        public void GetObjectAceTypeGuids(){} // RVA: 0x7ffaade7b930
        public void GetAceInsertPosition(){} // RVA: 0x7ffaa8650410
        public void GetAceFlags(){} // RVA: 0x7ffaade7c0b0
        public void SetAce(){} // RVA: 0x7ffaade7c560
        public void SetAce(){} // RVA: 0x7ffaade7c560
    }

    public class CommonObjectSecurity : ObjectSecurity
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade7cad0
        public void AddAccessRule(){} // RVA: 0x7ffaade7cae0
        public void ModifyAccess(){} // RVA: 0x7ffaade7cb20
    }

    public class GenericAcl : Object
    {
        public object MaxBinaryLength; // 0x31360DF0
        public object BinaryLength; // 0x170003AB

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaade7ea20
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_BinaryLength(){} // RVA: 0x7ffaa8649ca0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void get_Item(){} // RVA: 0x7ffaa8658120
        public void set_Item(){} // RVA: 0x7ffaa8662f00
        public void get_Revision(){} // RVA: 0x7ffaa864a040
        public void get_SyncRoot(){} // RVA: 0x7ffaa9f19100
        public void CopyTo(){} // RVA: 0x7ffaade7ea90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaade7eca0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaade7edd0
        // ── Binary Analysis Named ──
        public void GetBinaryForm(){} // RVA: 0x7ffaa8667cb0
        public void GetEnumerator(){} // RVA: 0x7ffaade7ed30
    }

    public class NativeObjectSecurity : CommonObjectSecurity
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade7fab0
        public void .ctor(){} // RVA: 0x7ffaade7fab0
        public void .ctor(){} // RVA: 0x7ffaade7fab0
        public void .ctor(){} // RVA: 0x7ffaade7fab0
        public void ClearAccessControlSectionsModified(){} // RVA: 0x7ffaade7fba0
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x7ffaade7fc40
        public void RaiseExceptionOnFailure(){} // RVA: 0x7ffaade7fe90
        public void InternalGet(){} // RVA: 0x7ffaade7ff40
        public void get_ResourceType(){} // RVA: 0x7ffaa898dcd0
        public void Win32GetHelper(){} // RVA: 0x7ffaade80190
        public void LocalFree(){} // RVA: 0x7ffaade80660
        public void IsValidSecurityDescriptor(){} // RVA: 0x7ffaade80760
        // ── Binary Analysis Named ──
        public void GetSecurityInfo(){} // RVA: 0x7ffaade80520
        public void GetSecurityDescriptorLength(){} // RVA: 0x7ffaade806e0
    }

    public class ObjectSecurity : Object
    {
        public object rw_lock; // 0x35DB2500
        public object AccessControlSectionsModified; // 0x170003C5

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade81780
        public void .ctor(){} // RVA: 0x7ffaade81780
        public void get_AccessControlSectionsModified(){} // RVA: 0x7ffaade819c0
        public void set_AccessControlSectionsModified(){} // RVA: 0x7ffaade81a50
        public void set_AccessRulesModified(){} // RVA: 0x7ffaade81ad0
        public void get_IsContainer(){} // RVA: 0x7ffaade81b20
        public void get_IsDS(){} // RVA: 0x7ffaade81b40
        public void set_OwnerModified(){} // RVA: 0x7ffaade81b60
        public void PurgeAccessRules(){} // RVA: 0x7ffaade81e70
        public void CopySddlForm(){} // RVA: 0x7ffaade822a0
        public void ModifyAccess(){}
        public void Reading(){} // RVA: 0x7ffaade824f0
        public void ReadLock(){} // RVA: 0x7ffaade82580
        public void ReadUnlock(){} // RVA: 0x7ffaade825b0
        public void Writing(){} // RVA: 0x7ffaade825d0
        public void WriteLock(){} // RVA: 0x7ffaade82650
        public void WriteUnlock(){} // RVA: 0x7ffaade82680
        public void SidFromIR(){} // RVA: 0x7ffaade826a0
        // ── Binary Analysis Named ──
        public void GetOwner(){} // RVA: 0x7ffaade81bb0
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x7ffaade81d50
        public void SetOwner(){} // RVA: 0x7ffaade820e0
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x7ffaade821e0
        public void SetAccessControlSectionsModified(){} // RVA: 0x7ffaade827c0
    }

}