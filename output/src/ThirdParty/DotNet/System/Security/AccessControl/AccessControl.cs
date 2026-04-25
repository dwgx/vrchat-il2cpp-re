// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.AccessControl
// Classes: 5
// Methods: 91

namespace ThirdParty.DotNet.System.Security.AccessControl
{
    public class CommonAcl : GenericAcl
    {
        public object BinaryLength;
        public object Count;
        public object IsCanonical;
        public object IsContainer;
        public object IsDS;
        public object IsAefa;
        public object Revision;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53879280 | overloaded x3
        public void Init(){} // RVA: 0x7FFD53879400
        public void get_BinaryLength(){} // RVA: 0x7FFD537AEC40
        public void get_Count(){} // RVA: 0x7FFD53879460
        public void get_IsCanonical(){} // RVA: 0x7FFD4EB91DA0
        public void get_IsContainer(){} // RVA: 0x7FFD4EF01A90
        public void get_IsDS(){} // RVA: 0x7FFD4F831E00
        public void get_IsAefa(){} // RVA: 0x7FFD4E40B5E0
        public void set_IsAefa(){} // RVA: 0x7FFD4E40B5F0
        public void get_Revision(){} // RVA: 0x7FFD53879490
        public void get_Item(){} // RVA: 0x7FFD538794C0
        public void set_Item(){} // RVA: 0x7FFD53879580
        public void GetBinaryForm(){} // RVA: 0x7FFD538795C0
        public void Purge(){} // RVA: 0x7FFD538795F0
        public void RequireCanonicity(){} // RVA: 0x7FFD53879760
        public void CanonicalizeAndClearAefa(){} // RVA: 0x7FFD538797D0
        public void IsAceMeaningless(){} // RVA: 0x7FFD53879990
        public void TestCanonicity(){} // RVA: 0x7FFD53879AA0
        public void GetCanonicalExplicitDenyAceCount(){} // RVA: 0x7FFD53879DA0
        public void GetCanonicalExplicitAceCount(){} // RVA: 0x7FFD53879F00
        public void MergeExplicitAces(){} // RVA: 0x7FFD53879F80
        public void MergeExplicitAcePair(){} // RVA: 0x7FFD5387A0A0
        public void GetObjectAceTypeGuids(){} // RVA: 0x7FFD5387A780
        public void ApplyCanonicalSortToExplicitAces(){} // RVA: 0x7FFD5387A820 | overloaded x2
        public void RemoveAces(){} // RVA: 0x7FFD4E090A40
        public void AddAce(){} // RVA: 0x7FFD5387AC60 | overloaded x2
        public void AddAceGetQualifiedAce(){} // RVA: 0x7FFD5387AA70
        public void CopyAce(){} // RVA: 0x7FFD5387AE60
        public void GetAceInsertPosition(){} // RVA: 0x7FFD4E0800D0
        public void GetAceFlags(){} // RVA: 0x7FFD5387AF00
        public void RemoveAceSpecific(){} // RVA: 0x7FFD5387B050
        public void SetAce(){} // RVA: 0x7FFD5387B3B0 | overloaded x2
    }

    public class CommonObjectSecurity : ObjectSecurity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5387B920
        public void AddAccessRule(){} // RVA: 0x7FFD5387B930
        public void ModifyAccess(){} // RVA: 0x7FFD5387B970
    }

    public class GenericAcl : Object
    {
        public object BinaryLength;
        public object Count;
        public object IsSynchronized;
        public object Item;
        public object Revision;
        public object SyncRoot;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5387D870
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_BinaryLength(){} // RVA: 0x7FFD4E079960
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void set_Item(){} // RVA: 0x7FFD4E092BC0
        public void get_Revision(){} // RVA: 0x7FFD4E079D00
        public void get_SyncRoot(){} // RVA: 0x7FFD4F9181E0
        public void CopyTo(){} // RVA: 0x7FFD5387D8E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD5387DAF0
        public void GetBinaryForm(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD5387DB80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5387DC20
    }

    public class NativeObjectSecurity : CommonObjectSecurity
    {
        public object ResourceType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5387E900 | overloaded x4
        public void ClearAccessControlSectionsModified(){} // RVA: 0x7FFD5387E9F0
        public void DefaultExceptionFromErrorCode(){} // RVA: 0x7FFD5387EA90
        public void RaiseExceptionOnFailure(){} // RVA: 0x7FFD5387ECE0
        public void InternalGet(){} // RVA: 0x7FFD5387ED90
        public void get_ResourceType(){} // RVA: 0x7FFD4E39CCD0
        public void Win32GetHelper(){} // RVA: 0x7FFD5387EFE0
        public void GetSecurityInfo(){} // RVA: 0x7FFD5387F370
        public void LocalFree(){} // RVA: 0x7FFD5387F4B0
        public void GetSecurityDescriptorLength(){} // RVA: 0x7FFD5387F530
        public void IsValidSecurityDescriptor(){} // RVA: 0x7FFD5387F5B0
    }

    public class ObjectSecurity : Object
    {
        public object AccessControlSectionsModified;
        public object AccessRulesModified;
        public object IsContainer;
        public object IsDS;
        public object OwnerModified;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538805D0 | overloaded x2
        public void get_AccessControlSectionsModified(){} // RVA: 0x7FFD53880810
        public void set_AccessControlSectionsModified(){} // RVA: 0x7FFD538808A0
        public void set_AccessRulesModified(){} // RVA: 0x7FFD53880920
        public void get_IsContainer(){} // RVA: 0x7FFD53880970
        public void get_IsDS(){} // RVA: 0x7FFD53880990
        public void set_OwnerModified(){} // RVA: 0x7FFD538809B0
        public void GetOwner(){} // RVA: 0x7FFD53880A00
        public void GetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFD53880BA0
        public void PurgeAccessRules(){} // RVA: 0x7FFD53880CC0
        public void SetOwner(){} // RVA: 0x7FFD53880F30
        public void SetSecurityDescriptorBinaryForm(){} // RVA: 0x7FFD53881030
        public void CopySddlForm(){} // RVA: 0x7FFD538810F0
        public void ModifyAccess(){}
        public void Reading(){} // RVA: 0x7FFD53881340
        public void ReadLock(){} // RVA: 0x7FFD538813D0
        public void ReadUnlock(){} // RVA: 0x7FFD53881400
        public void Writing(){} // RVA: 0x7FFD53881420
        public void WriteLock(){} // RVA: 0x7FFD538814A0
        public void WriteUnlock(){} // RVA: 0x7FFD538814D0
        public void SidFromIR(){} // RVA: 0x7FFD538814F0
        public void SetAccessControlSectionsModified(){} // RVA: 0x7FFD53881610
    }

}