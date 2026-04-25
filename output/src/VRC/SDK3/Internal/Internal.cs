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
        public string <ÏÏÏÎÎÌÍÍÏÌÎÌÍÌÎÍÌÍÏÎÌÏÍ>k__BackingField; // 0x18
        public string[] <ÍÏÏÏÍÏÎÍÌÏÏÎÎÌÏÍÎÌÏÏÍÌÏ>k__BackingField; // 0x20
        public string[] resultInstances; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC46DDF60
        public void Initialize(){} // RVA: 0x7FFAC46DE070
        public void IndexOf(){} // RVA: 0x7FFAC2F247C0
        public void op_Implicit(){} // RVA: 0x7FFAC2F247C0
        public void StartListening(){} // RVA: 0x7FFAC46DE130
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC46DE2A0
        public void GetCachedPtr(){} // RVA: 0x7FFAC46DE360
        public void get_name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_name(){} // RVA: 0x7FFAC2F4F0C0
        public void Instantiate(){} // RVA: 0x7FFAC46DE430
        public void Equals(){} // RVA: 0x7FFAC2F4F0C0
        public void GetHashCode(){} // RVA: 0x7FFAC46DE500
        public void ToString(){} // RVA: 0x7FFAC2F247C0
    }

    public class ChangeSettings : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void SetComfortMode(){} // RVA: 0x7FFAC46DE670
        public void GetComfortMode(){} // RVA: 0x7FFAC46DE730
        public void SetComfortTurningEnabled(){} // RVA: 0x7FFAC46DE7F0
        public void GetComfortTurningEnabled(){} // RVA: 0x7FFAC46DE8C0
        public void SetChatBubbleVisibility(){} // RVA: 0x7FFAC46DE990
        public void GetChatBubbleVisibility(){} // RVA: 0x7FFAC46DEA50
        public void SetPersonalSpaceEnabled(){} // RVA: 0x7FFAC46DEB10
        public void GetPersonalSpaceEnabled(){} // RVA: 0x7FFAC46DEBE0
        public void SetSafetyLevel(){} // RVA: 0x7FFAC46DECB0
        public void GetSafetyLevel(){} // RVA: 0x7FFAC46DED70
    }

    public class IVRCPlatformChecker
    {
        public object udonEventReceiver;
        public object worldID;
        public object isUnavailableOnThisPlatform;

        // ── Methods ──
        public void GetLastServiceDescriptor(){} // RVA: 0x7FFAC2C58E90
        public void GetLastServiceDescriptor_698B829E027E(){} // RVA: 0x7FFAC2C58E90
        public void GetValueAsByte(){} // RVA: 0x7FFAC2C59D00
        public void Enable(){} // RVA: 0x7FFAC2C71060
    }

    public class PedestalPreviewListener : Object
    {
        public string target;
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver ÌÏÎÍÌÌÎÎÍÍÍÏÌÎÍÌÌÌÏÌÎÏÎ; // 0x10
        public VRC.SDK3.Components.VRCAvatarPedestal <ÍÎÎÎÍÌÍÎÏÎÌÌÌÎÏÏÎÍÌÏÍÍÎ>k__BackingField; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC46FB7A0
        public void IndexOf(){} // RVA: 0x7FFAC46FB8C0
        public void Equals(){} // RVA: 0x7FFAC46FBA30
        public void StartListening(){} // RVA: 0x7FFAC46FBB50
        public void .ctor(){} // RVA: 0x7FFAC46FBCC0
        public void Initialize(){} // RVA: 0x7FFAC2F247C0
        public void GetCachedPtr(){} // RVA: 0x7FFAC2F247C0
        public void get_name(){} // RVA: 0x7FFAC46FBD70
        public void set_name(){} // RVA: 0x7FFAC46FBFE0
        public void GetAvatarPreview(){} // RVA: 0x7FFAC46FC100
        public void Instantiate(){} // RVA: 0x7FFAC46FC160
        public void GetHashCode(){} // RVA: 0x7FFAC46FC1C0
    }

    public class PlatformChecker : Object
    {
        public string udonEventReceiver;
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver worldID; // 0x10
        public string isUnavailableOnThisPlatform; // 0x18
        public bool <ÏÌÎÍÌÏÌÏÍÏÌÌÍÏÌÏÌÌÏÏÏÌÌ>k__BackingField; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC4705830
        public void Equals(){} // RVA: 0x7FFAC2F3C380
        public void GetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void op_Implicit(){} // RVA: 0x7FFAC2F247C0
        public void set_ValidExpressions(){} // RVA: 0x7FFAC300F9E0
        public void get_ValidExpressions(){} // RVA: 0x7FFAC300F9D0
        public void GetCachedPtr(){} // RVA: 0x7FFAC300F9D0
        public void get_name(){} // RVA: 0x7FFAC4705940
        public void .ctor(){} // RVA: 0x7FFAC46FBCC0
        public void Initialize(){} // RVA: 0x7FFAC47059B0
        public void StartFetchingWorldInfo(){} // RVA: 0x7FFAC4705AC0
        public void Instantiate(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void Enable(){} // RVA: 0x7FFAC300F9E0
        public void StartCoroutine(){} // RVA: 0x7FFAC300F9D0
        public void HandleWorldInfoFetched(){} // RVA: 0x7FFAC4705C00
    }

    public class VRCBestInstances : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetBestInstances(){} // RVA: 0x7FFAC46DDEC0
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
        public void StartListening(){} // RVA: 0x7FFAC46DEE30
        public void UnregisterEventPortal(){} // RVA: 0x7FFAC46DF080
        public void Equals(){} // RVA: 0x7FFAC46DF1F0
        public void op_Implicit(){} // RVA: 0x7FFAC46DF350
        public void UnregisterAllEventPortals(){} // RVA: 0x7FFAC46DF5F0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC46DF890
        public void GetCachedPtr(){} // RVA: 0x7FFAC46DF9D0
        public void RegisterEventPortal(){} // RVA: 0x7FFAC46DFBB0
        public void set_name(){} // RVA: 0x7FFAC46DFD50
        public void Instantiate(){} // RVA: 0x7FFAC46DFF00
        public void GetHashCode(){} // RVA: 0x7FFAC46E0120
        public void ToString(){} // RVA: 0x7FFAC46E0330
        public void StartListening_1E676B9B7586(){} // RVA: 0x7FFAC46E04E0
        public void .ctor(){} // RVA: 0x7FFAC46E0690
        public void Initialize(){} // RVA: 0x7FFAC46E07D0
        public void ProcessEventPortal(){} // RVA: 0x7FFAC46E09E0
        public void InitializeOnLoad(){} // RVA: 0x7FFAC46E0BF0
        public void SetupEventPortalManager(){} // RVA: 0x7FFAC46E0D30
        public void StopListening(){} // RVA: 0x7FFAC46E0E90
        public void Destroy(){} // RVA: 0x7FFAC46E1020
        public void UnregisterAllEventPortals_402410B32299(){} // RVA: 0x7FFAC46E1270
    }

    public class VRCExperiments : Object
    {
        public string ÎÎÎÏÎÍÏÎÍÌÌÍÎÎÏÌÎÍÌÌÎÌÎ;

        // ── Methods ──
        public void IsInExperimentSegment(){} // RVA: 0x7FFAC46FA250
        public void GetExperimentPayload(){} // RVA: 0x7FFAC46FA580 | overloaded x4
    }

    public class VRCInternalAvatarPedestal : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetPedestalListener(){} // RVA: 0x7FFAC46FB710
    }

    public class VRCOpenMenu : Object
    {
        public string ÎÏÍÎÌÍÏÍÍÎÎÌÎÍÍÎÏÍÌÌÌÌÏ;

        // ── Methods ──
        public void OpenFriendsList(){} // RVA: 0x7FFAC46FA650
        public void OpenMassGifting(){} // RVA: 0x7FFAC46FA710
        public void Equals(){} // RVA: 0x7FFAC46FA7D0
        public void op_Implicit(){} // RVA: 0x7FFAC46FAB30
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
        public void .cctor(){} // RVA: 0x7FFAC46FC2E0
        public void Equals(){} // RVA: 0x7FFAC46FC4F0
        public void GetHashCode(){} // RVA: 0x7FFAC46FC6C0
        public void op_Implicit(){} // RVA: 0x7FFAC46FC7A0
        public void RefreshData(){} // RVA: 0x7FFAC46FCAA0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC46FCB50
        public void GetCachedPtr(){} // RVA: 0x7FFAC46FCBD0
        public void get_name(){} // RVA: 0x7FFAC46FCC60
        public void set_name(){} // RVA: 0x7FFAC46FCD00
        public void Instantiate(){} // RVA: 0x7FFAC46FCDA0
        public void ToString(){} // RVA: 0x7FFAC46FCE40
        public void DoSetVector_Injected_295(){} // RVA: 0x7FFAC46FCEE0
        public void DoSetVector_Injected_295_890166A2E32C(){} // RVA: 0x7FFAC46FCF70
        public void UpdateCampaignProgress(){} // RVA: 0x7FFAC46FCFF0
        public void CheckCampaignStatusAndExecute(){} // RVA: 0x7FFAC46FD070
        public void ProcessCampaignData(){} // RVA: 0x7FFAC46FD1F0
        public void InitializeCampaignData(){} // RVA: 0x7FFAC46FD430
    }

    public class VRCUrlConstructor : Object
    {
        public string ÏÏÍÎÏÏÍÍÍÏÎÏÎÎÎÌÎÌÍÎÎÌÏ;
        public string ÎÎÏÍÍÏÌÏÌÎÎÎÎÍÍÎÎÎÎÎÌÌÌ;
        public string ÌÏÍÏÌÎÎÍÎÌÎÎÍÍÏÏÌÎÎÏÌÏÌ;

        // ── Methods ──
        public void GetUrl(){} // RVA: 0x7FFAC4704580
        public void GetAllowlistedUrl(){} // RVA: 0x7FFAC4704680
        public void GetYouTubeUrlFromId(){} // RVA: 0x7FFAC4704710
    }

    public class VRCUserFirstJoin : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetIsNewUser(){} // RVA: 0x7FFAC4704FC0
    }

    public class VRCWorldPlatformChecker : Object
    {
        public string ÎÌÏÍÎÌÍÌÏÌÏÌÏÎÌÎÎÍÌÍÏÏÍ;

        // ── Methods ──
        public void GetPlatformChecker(){} // RVA: 0x7FFAC47057A0
    }

}