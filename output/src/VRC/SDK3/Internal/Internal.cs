// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Internal
// Classes: 14
// Methods: 109

namespace VRC.SDK3.Internal
{
    public class BestInstancesListener : Object
    {
        public string requestedPopulationBracket;
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver _bestInstancesListener; // 0x10
        public string <ÌÍÍÏÌÎÌÍÎÌÎÏÏÏÍÏÎÏÏÎÌÏÎ>k__BackingField; // 0x18
        public string[] <ÎÌÏÌÏÍÎÌÌÏÎÏÏÎÌÌÌÌÏÏÍÏÍ>k__BackingField; // 0x20
        public string[] resultInstances; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FAFDF60
        public void Initialize(){} // RVA: 0x7FFD4FAFE070
        public void IndexOf(){} // RVA: 0x7FFD4E3447C0
        public void op_Implicit(){} // RVA: 0x7FFD4E3447C0
        public void StartListening(){} // RVA: 0x7FFD4FAFE130
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FAFE2A0
        public void GetCachedPtr(){} // RVA: 0x7FFD4FAFE360
        public void get_name(){} // RVA: 0x7FFD4E36F0C0
        public void set_name(){} // RVA: 0x7FFD4E36F0C0
        public void Instantiate(){} // RVA: 0x7FFD4FAFE430
        public void Equals(){} // RVA: 0x7FFD4E36F0C0
        public void GetHashCode(){} // RVA: 0x7FFD4FAFE500
        public void ToString(){} // RVA: 0x7FFD4E3447C0
    }

    public class ChangeSettings : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void SetComfortMode(){} // RVA: 0x7FFD4FAFE670
        public void GetComfortMode(){} // RVA: 0x7FFD4FAFE730
        public void SetComfortTurningEnabled(){} // RVA: 0x7FFD4FAFE7F0
        public void GetComfortTurningEnabled(){} // RVA: 0x7FFD4FAFE8C0
        public void SetChatBubbleVisibility(){} // RVA: 0x7FFD4FAFE990
        public void GetChatBubbleVisibility(){} // RVA: 0x7FFD4FAFEA50
        public void SetPersonalSpaceEnabled(){} // RVA: 0x7FFD4FAFEB10
        public void GetPersonalSpaceEnabled(){} // RVA: 0x7FFD4FAFEBE0
        public void SetSafetyLevel(){} // RVA: 0x7FFD4FAFECB0
        public void GetSafetyLevel(){} // RVA: 0x7FFD4FAFED70
    }

    public class IVRCPlatformChecker
    {
        public object udonEventReceiver;
        public object worldID;
        public object isUnavailableOnThisPlatform;

        // ── Methods ──
        public void GetLastServiceDescriptor(){} // RVA: 0x7FFD4E078E90
        public void GetLastServiceDescriptor_698B829E027E(){} // RVA: 0x7FFD4E078E90
        public void GetValueAsByte(){} // RVA: 0x7FFD4E079D00
        public void Enable(){} // RVA: 0x7FFD4E091060
    }

    public class PedestalPreviewListener : Object
    {
        public string target;
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver ÌÏÎÍÌÌÎÎÍÍÍÏÌÎÍÌÌÌÏÌÎÏÎ; // 0x10
        public VRC.SDK3.Components.VRCAvatarPedestal <ÏÎÍÌÍÍÏÌÏÌÏÏÏÏÌÎÍÌÍÏÍÌÌ>k__BackingField; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FB1B7A0
        public void IndexOf(){} // RVA: 0x7FFD4FB1B8C0
        public void Equals(){} // RVA: 0x7FFD4FB1BA30
        public void StartListening(){} // RVA: 0x7FFD4FB1BB50
        public void .ctor(){} // RVA: 0x7FFD4FB1BCC0
        public void Initialize(){} // RVA: 0x7FFD4E3447C0
        public void GetCachedPtr(){} // RVA: 0x7FFD4E3447C0
        public void get_name(){} // RVA: 0x7FFD4FB1BD70
        public void set_name(){} // RVA: 0x7FFD4FB1BFE0
        public void GetAvatarPreview(){} // RVA: 0x7FFD4FB1C100
        public void Instantiate(){} // RVA: 0x7FFD4FB1C160
        public void GetHashCode(){} // RVA: 0x7FFD4FB1C1C0
    }

    public class PlatformChecker : Object
    {
        public string udonEventReceiver;
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver worldID; // 0x10
        public string isUnavailableOnThisPlatform; // 0x18
        public bool <ÏÏÍÌÌÍÎÏÏÎÍÎÌÌÎÏÍÍÍÍÏÍÌ>k__BackingField; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FB25830
        public void Equals(){} // RVA: 0x7FFD4E35C380
        public void GetHashCode(){} // RVA: 0x7FFD4E3447C0
        public void op_Implicit(){} // RVA: 0x7FFD4E3447C0
        public void set_ValidExpressions(){} // RVA: 0x7FFD4E42F9E0
        public void get_ValidExpressions(){} // RVA: 0x7FFD4E42F9D0
        public void GetCachedPtr(){} // RVA: 0x7FFD4E42F9D0
        public void get_name(){} // RVA: 0x7FFD4FB25940
        public void .ctor(){} // RVA: 0x7FFD4FB1BCC0
        public void Initialize(){} // RVA: 0x7FFD4FB259B0
        public void StartFetchingWorldInfo(){} // RVA: 0x7FFD4FB25AC0
        public void Instantiate(){} // RVA: 0x7FFD4E3447C0
        public void ToString(){} // RVA: 0x7FFD4E35C380
        public void Enable(){} // RVA: 0x7FFD4E42F9E0
        public void StartCoroutine(){} // RVA: 0x7FFD4E42F9D0
        public void HandleWorldInfoFetched(){} // RVA: 0x7FFD4FB25C00
    }

    public class VRCBestInstances : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetBestInstances(){} // RVA: 0x7FFD4FAFDEC0
    }

    public class VRCEventPortalManagerInternal : Object
    {
        public string ÎÏÎÏÎÍÍÍÏÎÎÎÌÎÏÏÏÌÌÌÎÎÎ;
        public string ÌÍÍÎÏÏÍÏÌÎÌÍÎÏÎÏÌÏÌÍÍÌÍ;
        public System.Collections.Generic.List`1<VRC.SDKBase.VRC_PortalMarker> ÌÎÌÍÎÏÍÍÏÏÍÎÎÎÌÎÎÏÎÏÏÌÌ; // 0x10
        public System.Threading.CancellationTokenSource ÍÌÎÍÎÌÌÏÎÌÏÌÎÎÍÌÍÎÍÏÍÌÌ; // 0x18
        public System.Threading.CancellationTokenSource ÏÍÏÌÌÌÏÎÏÏÌÏÍÏÏÍÏÌÍÏÍÍÏ; // 0x20
        public System.Collections.Generic.IReadOnlyList`1<System.ValueTuple`3<ÎÎÏÍÏÌÏÌÎÎÏÎÎÍÍÎÎÎÍÏÍÍÏ,ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ,int>> ÏÏÎÎÎÌÍÎÍÌÏÎÎÎÎÎÌÍÏÍÌÍÏ; // 0x28
        public bool ÎÎÎÏÎÏÎÍÎÍÌÎÌÍÌÎÏÎÌÎÎÍÎ; // 0x30

        // ── Methods ──
        public void StartListening(){} // RVA: 0x7FFD4FAFEE30
        public void UnregisterEventPortal(){} // RVA: 0x7FFD4FAFF080
        public void Equals(){} // RVA: 0x7FFD4FAFF1F0
        public void op_Implicit(){} // RVA: 0x7FFD4FAFF350
        public void UnregisterAllEventPortals(){} // RVA: 0x7FFD4FAFF5F0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FAFF890
        public void GetCachedPtr(){} // RVA: 0x7FFD4FAFF9D0
        public void RegisterEventPortal(){} // RVA: 0x7FFD4FAFFBB0
        public void set_name(){} // RVA: 0x7FFD4FAFFD50
        public void Instantiate(){} // RVA: 0x7FFD4FAFFF00
        public void GetHashCode(){} // RVA: 0x7FFD4FB00120
        public void ToString(){} // RVA: 0x7FFD4FB00330
        public void StartListening_1E676B9B7586(){} // RVA: 0x7FFD4FB004E0
        public void .ctor(){} // RVA: 0x7FFD4FB00690
        public void Initialize(){} // RVA: 0x7FFD4FB007D0
        public void ProcessEventPortal(){} // RVA: 0x7FFD4FB009E0
        public void InitializeOnLoad(){} // RVA: 0x7FFD4FB00BF0
        public void SetupEventPortalManager(){} // RVA: 0x7FFD4FB00D30
        public void StopListening(){} // RVA: 0x7FFD4FB00E90
        public void Destroy(){} // RVA: 0x7FFD4FB01020
        public void UnregisterAllEventPortals_402410B32299(){} // RVA: 0x7FFD4FB01270
    }

    public class VRCExperiments : Object
    {
        public string ÎÎÎÏÎÍÏÎÍÌÌÍÎÎÏÌÎÍÌÌÎÌÎ;

        // ── Methods ──
        public void IsInExperimentSegment(){} // RVA: 0x7FFD4FB1A250
        public void GetExperimentPayload(){} // RVA: 0x7FFD4FB1A580 | overloaded x4
    }

    public class VRCInternalAvatarPedestal : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetPedestalListener(){} // RVA: 0x7FFD4FB1B710
    }

    public class VRCOpenMenu : Object
    {
        public string ÎÏÍÎÌÍÏÍÍÎÎÌÎÍÍÎÏÍÌÌÌÌÏ;

        // ── Methods ──
        public void OpenFriendsList(){} // RVA: 0x7FFD4FB1A650
        public void OpenMassGifting(){} // RVA: 0x7FFD4FB1A710
        public void Equals(){} // RVA: 0x7FFD4FB1A7D0
        public void op_Implicit(){} // RVA: 0x7FFD4FB1AB30
    }

    public class VRCPrideCampaign : Object
    {
        public string LastRefreshTimestampUTC;
        public int IsCampaignActive;
        public System.Threading.CancellationTokenSource GlobalDollarsGoal;
        public ÍÍÍÏÍÏÎÍÌÏÍÌÏÏÎÎÍÏÌÌÌÏÌ GlobalDollarsRaised; // 0x8
        public string[] GlobalParticipantCount; // 0x10
        public UnityEngine.Sprite[] LocalGiftsCount; // 0x18
        public System.DateTime FriendParticipantCount; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4FB1C2E0
        public void Equals(){} // RVA: 0x7FFD4FB1C4F0
        public void GetHashCode(){} // RVA: 0x7FFD4FB1C6C0
        public void op_Implicit(){} // RVA: 0x7FFD4FB1C7A0
        public void RefreshData(){} // RVA: 0x7FFD4FB1CAA0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FB1CB50
        public void GetCachedPtr(){} // RVA: 0x7FFD4FB1CBD0
        public void get_name(){} // RVA: 0x7FFD4FB1CC60
        public void set_name(){} // RVA: 0x7FFD4FB1CD00
        public void Instantiate(){} // RVA: 0x7FFD4FB1CDA0
        public void ToString(){} // RVA: 0x7FFD4FB1CE40
        public void DoSetVector_Injected_295(){} // RVA: 0x7FFD4FB1CEE0
        public void DoSetVector_Injected_295_890166A2E32C(){} // RVA: 0x7FFD4FB1CF70
        public void UpdateCampaignProgress(){} // RVA: 0x7FFD4FB1CFF0
        public void CheckCampaignStatusAndExecute(){} // RVA: 0x7FFD4FB1D070
        public void ProcessCampaignData(){} // RVA: 0x7FFD4FB1D1F0
        public void InitializeCampaignData(){} // RVA: 0x7FFD4FB1D430
    }

    public class VRCUrlConstructor : Object
    {
        public string ÏÏÍÎÏÏÍÍÍÏÎÏÎÎÎÌÎÌÍÎÎÌÏ;
        public string ÎÎÏÍÍÏÌÏÌÎÎÎÎÍÍÎÎÎÎÎÌÌÌ;
        public string ÌÏÍÏÌÎÎÍÎÌÎÎÍÍÏÏÌÎÎÏÌÏÌ;

        // ── Methods ──
        public void GetUrl(){} // RVA: 0x7FFD4FB24580
        public void GetAllowlistedUrl(){} // RVA: 0x7FFD4FB24680
        public void GetYouTubeUrlFromId(){} // RVA: 0x7FFD4FB24710
    }

    public class VRCUserFirstJoin : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetIsNewUser(){} // RVA: 0x7FFD4FB24FC0
    }

    public class VRCWorldPlatformChecker : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetPlatformChecker(){} // RVA: 0x7FFD4FB257A0
    }

}