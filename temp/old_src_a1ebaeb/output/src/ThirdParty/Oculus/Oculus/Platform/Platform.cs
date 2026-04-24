// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 34
// Methods: 809

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class AbuseReportOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae239ed0
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae23a110
        // ── Binary Analysis Named ──
        public void SetPreventPeopleChooser(){} // RVA: 0x7ffaae239f80
        public void SetReportType(){} // RVA: 0x7ffaae23a040
    }

    public class AdvancedAbuseReportOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae23a200
        public void ClearDeveloperDefinedContext(){} // RVA: 0x7ffaae23a420
        public void AddSuggestedUser(){} // RVA: 0x7ffaae23a6e0
        public void ClearSuggestedUsers(){} // RVA: 0x7ffaae23a7b0
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae23a930
        // ── Binary Analysis Named ──
        public void SetDeveloperDefinedContext(){} // RVA: 0x7ffaae23a2b0
        public void SetObjectType(){} // RVA: 0x7ffaae23a4e0
        public void SetReportType(){} // RVA: 0x7ffaae23a620
        public void SetVideoMode(){} // RVA: 0x7ffaae23a870
    }

    public class AndroidPlatform : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8932320
        public void AsyncInitialize(){} // RVA: 0x7ffaae23aa20
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ApplicationOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae23aa70
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae23b0f0
        // ── Binary Analysis Named ──
        public void SetDeeplinkMessage(){} // RVA: 0x7ffaae23ab20
        public void SetDestinationApiName(){} // RVA: 0x7ffaae23ac60
        public void SetLobbySessionId(){} // RVA: 0x7ffaae23ada0
        public void SetMatchSessionId(){} // RVA: 0x7ffaae23aee0
        public void SetRoomId(){} // RVA: 0x7ffaae23b020
    }

    public class AvatarEditorOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae23b1e0
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae23b3d0
        // ── Binary Analysis Named ──
        public void SetSourceOverride(){} // RVA: 0x7ffaae23b290
    }

    public class CAPI : Object
    {
        public object VoipFilterBufferSize; // 0x335DB840
        public object 00; // 0x84C32590

        // ── Original Methods ──
        public void ArrayOfStructsToIntPtr(){} // RVA: 0x7ffaae23c800
        public void DictionaryToOVRKeyValuePairs(){} // RVA: 0x7ffaae23cda0
        public void DictionaryToOVRKeyValuePairs(){} // RVA: 0x7ffaae23cda0
        public void IntPtrToByteArray(){} // RVA: 0x7ffaae23d350
        public void DataStoreFromNative(){} // RVA: 0x7ffaae23d430
        public void StringFromNative(){} // RVA: 0x7ffaae23d770
        public void DateTimeFromNative(){} // RVA: 0x7ffaae23d920
        public void DateTimeToNative(){} // RVA: 0x7ffaae23da70
        public void BlobFromNative(){} // RVA: 0x7ffaae23dc20
        public void FiledataFromNative(){} // RVA: 0x7ffaae23dcf0
        public void StringToNative(){} // RVA: 0x7ffaae23dd90
        public void ovr_UnityInitWrapper(){} // RVA: 0x7ffaae23df40
        public void ovr_UnityInitGlobals(){} // RVA: 0x7ffaae23dff0
        public void ovr_UnityInitWrapperAsynchronous(){} // RVA: 0x7ffaae23e070
        public void ovr_UnityInitWrapperStandalone(){} // RVA: 0x7ffaae23e120
        public void ovr_Platform_InitializeStandaloneOculus(){} // RVA: 0x7ffaae23e1d0
        public void ovr_PlatformInitializeWithAccessToken(){} // RVA: 0x7ffaae23e360
        public void ovr_PlatformInitializeWithAccessTokenAndOptions(){} // RVA: 0x7ffaae23e420
        public void ovr_UnityInitWrapperWindows(){} // RVA: 0x7ffaae23e600
        public void ovr_UnityInitWrapperWindowsAsynchronous(){} // RVA: 0x7ffaae23e6b0
        public void ovr_SetDeveloperAccessToken(){} // RVA: 0x7ffaae23e760
        public void ovr_GetLoggedInUserLocale(){} // RVA: 0x7ffaae23e810
        public void ovr_GetLoggedInUserLocale_Native(){} // RVA: 0x7ffaae23e8c0
        public void ovr_PopMessage(){} // RVA: 0x7ffaae23e930
        public void ovr_FreeMessage(){} // RVA: 0x7ffaae23e9a0
        public void ovr_Voip_CreateEncoder(){} // RVA: 0x7ffaae23ea20
        public void ovr_Voip_DestroyEncoder(){} // RVA: 0x7ffaae23ea90
        public void ovr_Voip_CreateDecoder(){} // RVA: 0x7ffaae23eb10
        public void ovr_Voip_DestroyDecoder(){} // RVA: 0x7ffaae23eb80
        public void ovr_VoipDecoder_Decode(){} // RVA: 0x7ffaae23ec00
        public void ovr_Microphone_Create(){} // RVA: 0x7ffaae23ec60
        public void ovr_Microphone_Destroy(){} // RVA: 0x7ffaae23ecd0
        public void ovr_Voip_SetSystemVoipPassthrough(){} // RVA: 0x7ffaae23ed50
        public void ovr_Voip_SetSystemVoipMicrophoneMuted(){} // RVA: 0x7ffaae23edd0
        public void ovr_UnityResetTestPlatform(){} // RVA: 0x7ffaae23ee50
        public void ovr_HTTP_GetWithMessageType(){} // RVA: 0x7ffaae23eec0
        public void ovr_CrashApplication(){} // RVA: 0x7ffaae23ef70
        public void ovr_Voip_SetMicrophoneFilterCallback(){} // RVA: 0x7ffaae23efe0
        public void ovr_Voip_SetMicrophoneFilterCallbackWithFixedSizeBuffer(){} // RVA: 0x7ffaae23f070
        public void LogNewUnifiedEvent(){} // RVA: 0x7ffaae23f110
        public void LogNewEvent(){} // RVA: 0x7ffaae23f1b0
        public void ovr_Log_NewEvent(){} // RVA: 0x7ffaae23f5c0
        public void ovr_ApplicationLifecycle_GetLaunchDetails(){} // RVA: 0x7ffaae23f660
        public void ovr_ApplicationLifecycle_LogDeeplinkResult(){} // RVA: 0x7ffaae23f6d0
        public void ovr_ApplicationLifecycle_LogDeeplinkResult_Native(){} // RVA: 0x7ffaae23f7d0
        public void ovr_HTTP_StartTransfer(){} // RVA: 0x7ffaae23f860
        public void ovr_HTTP_StartTransfer_Native(){} // RVA: 0x7ffaae23fab0
        public void ovr_HTTP_Write(){} // RVA: 0x7ffaae23fca0
        public void ovr_HTTP_WriteEOM(){} // RVA: 0x7ffaae23fd50
        public void ovr_Message_GetStringForJavascript(){} // RVA: 0x7ffaae23fdd0
        public void ovr_Message_GetStringForJavascript_Native(){} // RVA: 0x7ffaae23fe90
        public void ovr_NetSync_GetAmbisonicFloatPCM(){} // RVA: 0x7ffaae23ff10
        public void ovr_NetSync_GetAmbisonicInt16PCM(){} // RVA: 0x7ffaae23ffb0
        public void ovr_NetSync_GetAmbisonicInterleavedFloatPCM(){} // RVA: 0x7ffaae240050
        public void ovr_NetSync_GetAmbisonicInterleavedInt16PCM(){} // RVA: 0x7ffaae2400f0
        public void ovr_NetSync_GetListenerPosition(){} // RVA: 0x7ffaae240190
        public void ovr_NetSync_GetMonostreamFloatPCM(){} // RVA: 0x7ffaae240230
        public void ovr_NetSync_GetMonostreamInt16PCM(){} // RVA: 0x7ffaae2402e0
        public void ovr_NetSync_GetPcmBufferMaxSamples(){} // RVA: 0x7ffaae240390
        public void ovr_NetSync_GetVoipAmplitude(){} // RVA: 0x7ffaae240400
        public void ovr_NetSync_SetListenerPosition(){} // RVA: 0x7ffaae2404a0
        public void ovr_Net_Accept(){} // RVA: 0x7ffaae240530
        public void ovr_Net_AcceptForCurrentRoom(){} // RVA: 0x7ffaae2405b0
        public void ovr_Net_Close(){} // RVA: 0x7ffaae240620
        public void ovr_Net_CloseForCurrentRoom(){} // RVA: 0x7ffaae2406a0
        public void ovr_Net_Connect(){} // RVA: 0x7ffaae240710
        public void ovr_Net_IsConnected(){} // RVA: 0x7ffaae240790
        public void ovr_Net_Ping(){} // RVA: 0x7ffaae240810
        public void ovr_Net_ReadPacket(){} // RVA: 0x7ffaae240890
        public void ovr_Net_SendPacket(){} // RVA: 0x7ffaae240900
        public void ovr_Net_SendPacketToCurrentRoom(){} // RVA: 0x7ffaae2409c0
        public void ovr_Party_PluginGetSharedMemHandle(){} // RVA: 0x7ffaae240a70
        public void ovr_Party_PluginGetVoipMicrophoneMuted(){} // RVA: 0x7ffaae240ae0
        public void ovr_Party_PluginGetVoipPassthrough(){} // RVA: 0x7ffaae240b50
        public void ovr_Party_PluginGetVoipStatus(){} // RVA: 0x7ffaae240bc0
        public void ovr_Voip_Accept(){} // RVA: 0x7ffaae240c30
        public void ovr_Voip_GetIsConnectionUsingDtx(){} // RVA: 0x7ffaae240cb0
        public void ovr_Voip_GetLocalBitrate(){} // RVA: 0x7ffaae240d30
        public void ovr_Voip_GetOutputBufferMaxSize(){} // RVA: 0x7ffaae240db0
        public void ovr_Voip_GetPCM(){} // RVA: 0x7ffaae240e20
        public void ovr_Voip_GetPCMFloat(){} // RVA: 0x7ffaae240ec0
        public void ovr_Voip_GetPCMSize(){} // RVA: 0x7ffaae240f60
        public void ovr_Voip_GetPCMWithTimestamp(){} // RVA: 0x7ffaae240fe0
        public void ovr_Voip_GetPCMWithTimestampFloat(){} // RVA: 0x7ffaae2410a0
        public void ovr_Voip_GetRemoteBitrate(){} // RVA: 0x7ffaae241160
        public void ovr_Voip_GetSyncTimestamp(){} // RVA: 0x7ffaae2411e0
        public void ovr_Voip_GetSyncTimestampDifference(){} // RVA: 0x7ffaae241260
        public void ovr_Voip_GetSystemVoipMicrophoneMuted(){} // RVA: 0x7ffaae2412f0
        public void ovr_Voip_GetSystemVoipStatus(){} // RVA: 0x7ffaae241360
        public void ovr_Voip_SetMicrophoneMuted(){} // RVA: 0x7ffaae2413d0
        public void ovr_Voip_SetNewConnectionOptions(){} // RVA: 0x7ffaae241450
        public void ovr_Voip_SetOutputSampleRate(){} // RVA: 0x7ffaae2414d0
        public void ovr_Voip_Start(){} // RVA: 0x7ffaae241550
        public void ovr_Voip_Stop(){} // RVA: 0x7ffaae2415d0
        public void ovr_AbuseReport_LaunchAdvancedReportFlow(){} // RVA: 0x7ffaae241650
        public void ovr_AbuseReport_ReportRequestHandled(){} // RVA: 0x7ffaae2416e0
        public void ovr_Achievements_AddCount(){} // RVA: 0x7ffaae241760
        public void ovr_Achievements_AddCount_Native(){} // RVA: 0x7ffaae241860
        public void ovr_Achievements_AddFields(){} // RVA: 0x7ffaae2418f0
        public void ovr_Achievements_AddFields_Native(){} // RVA: 0x7ffaae241a10
        public void ovr_Achievements_GetAllDefinitions(){} // RVA: 0x7ffaae241aa0
        public void ovr_Achievements_GetAllProgress(){} // RVA: 0x7ffaae241b10
        public void ovr_Achievements_GetDefinitionsByName(){} // RVA: 0x7ffaae241b80
        public void ovr_Achievements_GetProgressByName(){} // RVA: 0x7ffaae241cf0
        public void ovr_Achievements_Unlock(){} // RVA: 0x7ffaae241e60
        public void ovr_Achievements_Unlock_Native(){} // RVA: 0x7ffaae241f60
        public void ovr_Application_ExecuteCoordinatedLaunch(){} // RVA: 0x7ffaae241fe0
        public void ovr_Application_GetInstalledApplications(){} // RVA: 0x7ffaae242070
        public void ovr_Application_GetVersion(){} // RVA: 0x7ffaae2420e0
        public void ovr_Application_LaunchOtherApp(){} // RVA: 0x7ffaae242150
        public void ovr_ApplicationLifecycle_GetRegisteredPIDs(){} // RVA: 0x7ffaae2421e0
        public void ovr_ApplicationLifecycle_GetSessionKey(){} // RVA: 0x7ffaae242250
        public void ovr_ApplicationLifecycle_RegisterSessionKey(){} // RVA: 0x7ffaae2422c0
        public void ovr_ApplicationLifecycle_RegisterSessionKey_Native(){} // RVA: 0x7ffaae2423c0
        public void ovr_AssetFile_Delete(){} // RVA: 0x7ffaae242440
        public void ovr_AssetFile_DeleteById(){} // RVA: 0x7ffaae2424c0
        public void ovr_AssetFile_DeleteByName(){} // RVA: 0x7ffaae242540
        public void ovr_AssetFile_DeleteByName_Native(){} // RVA: 0x7ffaae242640
        public void ovr_AssetFile_Download(){} // RVA: 0x7ffaae2426c0
        public void ovr_AssetFile_DownloadById(){} // RVA: 0x7ffaae242740
        public void ovr_AssetFile_DownloadByName(){} // RVA: 0x7ffaae2427c0
        public void ovr_AssetFile_DownloadByName_Native(){} // RVA: 0x7ffaae2428c0
        public void ovr_AssetFile_DownloadCancel(){} // RVA: 0x7ffaae242940
        public void ovr_AssetFile_DownloadCancelById(){} // RVA: 0x7ffaae2429c0
        public void ovr_AssetFile_DownloadCancelByName(){} // RVA: 0x7ffaae242a40
        public void ovr_AssetFile_DownloadCancelByName_Native(){} // RVA: 0x7ffaae242b40
        public void ovr_AssetFile_GetList(){} // RVA: 0x7ffaae242bc0
        public void ovr_AssetFile_Status(){} // RVA: 0x7ffaae242c30
        public void ovr_AssetFile_StatusById(){} // RVA: 0x7ffaae242cb0
        public void ovr_AssetFile_StatusByName(){} // RVA: 0x7ffaae242d30
        public void ovr_AssetFile_StatusByName_Native(){} // RVA: 0x7ffaae242e30
        public void ovr_Avatar_LaunchAvatarEditor(){} // RVA: 0x7ffaae242eb0
        public void ovr_Avatar_UpdateMetaData(){} // RVA: 0x7ffaae242f30
        public void ovr_Avatar_UpdateMetaData_Native(){} // RVA: 0x7ffaae243050
        public void ovr_Cal_FinalizeApplication(){} // RVA: 0x7ffaae2430e0
        public void ovr_Cal_GetSuggestedApplications(){} // RVA: 0x7ffaae243190
        public void ovr_Cal_ProposeApplication(){} // RVA: 0x7ffaae243230
        public void ovr_Challenges_Create(){} // RVA: 0x7ffaae2432e0
        public void ovr_Challenges_Create_Native(){} // RVA: 0x7ffaae2433e0
        public void ovr_Challenges_DeclineInvite(){} // RVA: 0x7ffaae243470
        public void ovr_Challenges_Delete(){} // RVA: 0x7ffaae2434f0
        public void ovr_Challenges_Get(){} // RVA: 0x7ffaae243570
        public void ovr_Challenges_GetEntries(){} // RVA: 0x7ffaae2435f0
        public void ovr_Challenges_GetEntriesAfterRank(){} // RVA: 0x7ffaae243690
        public void ovr_Challenges_GetEntriesByIds(){} // RVA: 0x7ffaae243730
        public void ovr_Challenges_GetList(){} // RVA: 0x7ffaae2437e0
        public void ovr_Challenges_GetNextChallenges(){} // RVA: 0x7ffaae243870
        public void ovr_Challenges_GetNextEntries(){} // RVA: 0x7ffaae2438f0
        public void ovr_Challenges_GetPreviousChallenges(){} // RVA: 0x7ffaae243970
        public void ovr_Challenges_GetPreviousEntries(){} // RVA: 0x7ffaae2439f0
        public void ovr_Challenges_Join(){} // RVA: 0x7ffaae243a70
        public void ovr_Challenges_Leave(){} // RVA: 0x7ffaae243af0
        public void ovr_Challenges_UpdateInfo(){} // RVA: 0x7ffaae243b70
        public void ovr_CloudStorage_Delete(){} // RVA: 0x7ffaae243c00
        public void ovr_CloudStorage_Delete_Native(){} // RVA: 0x7ffaae243d20
        public void ovr_CloudStorage_Load(){} // RVA: 0x7ffaae243db0
        public void ovr_CloudStorage_Load_Native(){} // RVA: 0x7ffaae243ed0
        public void ovr_CloudStorage_LoadBucketMetadata(){} // RVA: 0x7ffaae243f60
        public void ovr_CloudStorage_LoadBucketMetadata_Native(){} // RVA: 0x7ffaae244060
        public void ovr_CloudStorage_LoadConflictMetadata(){} // RVA: 0x7ffaae2440e0
        public void ovr_CloudStorage_LoadConflictMetadata_Native(){} // RVA: 0x7ffaae244200
        public void ovr_CloudStorage_LoadHandle(){} // RVA: 0x7ffaae244290
        public void ovr_CloudStorage_LoadHandle_Native(){} // RVA: 0x7ffaae244390
        public void ovr_CloudStorage_LoadMetadata(){} // RVA: 0x7ffaae244410
        public void ovr_CloudStorage_LoadMetadata_Native(){} // RVA: 0x7ffaae244530
        public void ovr_CloudStorage_ResolveKeepLocal(){} // RVA: 0x7ffaae2445c0
        public void ovr_CloudStorage_ResolveKeepLocal_Native(){} // RVA: 0x7ffaae244710
        public void ovr_CloudStorage_ResolveKeepRemote(){} // RVA: 0x7ffaae2447b0
        public void ovr_CloudStorage_ResolveKeepRemote_Native(){} // RVA: 0x7ffaae244900
        public void ovr_CloudStorage_Save(){} // RVA: 0x7ffaae2449a0
        public void ovr_CloudStorage_Save_Native(){} // RVA: 0x7ffaae244b20
        public void ovr_CloudStorage2_GetUserDirectoryPath(){} // RVA: 0x7ffaae244bd0
        public void ovr_Colocation_GetCurrentMapUuid(){} // RVA: 0x7ffaae244c40
        public void ovr_Colocation_RequestMap(){} // RVA: 0x7ffaae244cb0
        public void ovr_Colocation_RequestMap_Native(){} // RVA: 0x7ffaae244db0
        public void ovr_Colocation_ShareMap(){} // RVA: 0x7ffaae244e30
        public void ovr_Colocation_ShareMap_Native(){} // RVA: 0x7ffaae244f30
        public void ovr_DeviceApplicationIntegrity_GetAttestationToken(){} // RVA: 0x7ffaae244fb0
        public void ovr_DeviceApplicationIntegrity_GetAttestationToken_Native(){} // RVA: 0x7ffaae2450b0
        public void ovr_Entitlement_GetIsViewerEntitled(){} // RVA: 0x7ffaae245130
        public void ovr_GraphAPI_Get(){} // RVA: 0x7ffaae2451a0
        public void ovr_GraphAPI_Get_Native(){} // RVA: 0x7ffaae2452a0
        public void ovr_GraphAPI_Post(){} // RVA: 0x7ffaae245320
        public void ovr_GraphAPI_Post_Native(){} // RVA: 0x7ffaae245420
        public void ovr_GroupPresence_Clear(){} // RVA: 0x7ffaae2454a0
        public void ovr_GroupPresence_GetInvitableUsers(){} // RVA: 0x7ffaae245510
        public void ovr_GroupPresence_GetSentInvites(){} // RVA: 0x7ffaae245590
        public void ovr_GroupPresence_LaunchInvitePanel(){} // RVA: 0x7ffaae245600
        public void ovr_GroupPresence_LaunchMultiplayerErrorDialog(){} // RVA: 0x7ffaae245680
        public void ovr_GroupPresence_LaunchRejoinDialog(){} // RVA: 0x7ffaae245700
        public void ovr_GroupPresence_LaunchRejoinDialog_Native(){} // RVA: 0x7ffaae245850
        public void ovr_GroupPresence_LaunchRosterPanel(){} // RVA: 0x7ffaae2458f0
        public void ovr_GroupPresence_SendInvites(){} // RVA: 0x7ffaae245970
        public void ovr_GroupPresence_Set(){} // RVA: 0x7ffaae245a00
        public void ovr_GroupPresence_SetDeeplinkMessageOverride(){} // RVA: 0x7ffaae245a80
        public void ovr_GroupPresence_SetDeeplinkMessageOverride_Native(){} // RVA: 0x7ffaae245b80
        public void ovr_GroupPresence_SetDestination(){} // RVA: 0x7ffaae245c00
        public void ovr_GroupPresence_SetDestination_Native(){} // RVA: 0x7ffaae245d00
        public void ovr_GroupPresence_SetIsJoinable(){} // RVA: 0x7ffaae245d80
        public void ovr_GroupPresence_SetLobbySession(){} // RVA: 0x7ffaae245e00
        public void ovr_GroupPresence_SetLobbySession_Native(){} // RVA: 0x7ffaae245f00
        public void ovr_GroupPresence_SetMatchSession(){} // RVA: 0x7ffaae245f80
        public void ovr_GroupPresence_SetMatchSession_Native(){} // RVA: 0x7ffaae246080
        public void ovr_HTTP_Get(){} // RVA: 0x7ffaae246100
        public void ovr_HTTP_Get_Native(){} // RVA: 0x7ffaae246200
        public void ovr_HTTP_GetToFile(){} // RVA: 0x7ffaae246280
        public void ovr_HTTP_GetToFile_Native(){} // RVA: 0x7ffaae2463a0
        public void ovr_HTTP_MultiPartPost(){} // RVA: 0x7ffaae246430
        public void ovr_HTTP_MultiPartPost_Native(){} // RVA: 0x7ffaae246570
        public void ovr_HTTP_Post(){} // RVA: 0x7ffaae2467a0
        public void ovr_HTTP_Post_Native(){} // RVA: 0x7ffaae2468a0
        public void ovr_IAP_ConsumePurchase(){} // RVA: 0x7ffaae246920
        public void ovr_IAP_ConsumePurchase_Native(){} // RVA: 0x7ffaae246a20
        public void ovr_IAP_GetProductsBySKU(){} // RVA: 0x7ffaae246aa0
        public void ovr_IAP_GetViewerPurchases(){} // RVA: 0x7ffaae246c10
        public void ovr_IAP_GetViewerPurchasesDurableCache(){} // RVA: 0x7ffaae246c80
        public void ovr_IAP_LaunchCheckoutFlow(){} // RVA: 0x7ffaae246cf0
        public void ovr_IAP_LaunchCheckoutFlow_Native(){} // RVA: 0x7ffaae246df0
        public void ovr_LanguagePack_GetCurrent(){} // RVA: 0x7ffaae246e70
        public void ovr_LanguagePack_SetCurrent(){} // RVA: 0x7ffaae246ee0
        public void ovr_LanguagePack_SetCurrent_Native(){} // RVA: 0x7ffaae246fe0
        public void ovr_Leaderboard_Get(){} // RVA: 0x7ffaae247060
        public void ovr_Leaderboard_Get_Native(){} // RVA: 0x7ffaae247160
        public void ovr_Leaderboard_GetEntries(){} // RVA: 0x7ffaae2471e0
        public void ovr_Leaderboard_GetEntries_Native(){} // RVA: 0x7ffaae247300
        public void ovr_Leaderboard_GetEntriesAfterRank(){} // RVA: 0x7ffaae2473a0
        public void ovr_Leaderboard_GetEntriesAfterRank_Native(){} // RVA: 0x7ffaae2474b0
        public void ovr_Leaderboard_GetEntriesByIds(){} // RVA: 0x7ffaae247550
        public void ovr_Leaderboard_GetEntriesByIds_Native(){} // RVA: 0x7ffaae247690
        public void ovr_Leaderboard_GetNextEntries(){} // RVA: 0x7ffaae247740
        public void ovr_Leaderboard_GetPreviousEntries(){} // RVA: 0x7ffaae2477c0
        public void ovr_Leaderboard_WriteEntry(){} // RVA: 0x7ffaae247840
        public void ovr_Leaderboard_WriteEntry_Native(){} // RVA: 0x7ffaae247980
        public void ovr_Leaderboard_WriteEntryWithSupplementaryMetric(){} // RVA: 0x7ffaae247a40
        public void ovr_Leaderboard_WriteEntryWithSupplementaryMetric_Native(){} // RVA: 0x7ffaae247b90
        public void ovr_Livestreaming_IsAllowedForApplication(){} // RVA: 0x7ffaae247c50
        public void ovr_Livestreaming_IsAllowedForApplication_Native(){} // RVA: 0x7ffaae247d50
        public void ovr_Livestreaming_StartPartyStream(){} // RVA: 0x7ffaae247dd0
        public void ovr_Livestreaming_StartStream(){} // RVA: 0x7ffaae247e40
        public void ovr_Livestreaming_StopPartyStream(){} // RVA: 0x7ffaae247ed0
        public void ovr_Livestreaming_StopStream(){} // RVA: 0x7ffaae247f40
        public void ovr_Livestreaming_UpdateMicStatus(){} // RVA: 0x7ffaae247fb0
        public void ovr_Matchmaking_Browse(){} // RVA: 0x7ffaae248030
        public void ovr_Matchmaking_Browse_Native(){} // RVA: 0x7ffaae248130
        public void ovr_Matchmaking_Browse2(){} // RVA: 0x7ffaae2481c0
        public void ovr_Matchmaking_Browse2_Native(){} // RVA: 0x7ffaae2482c0
        public void ovr_Matchmaking_Cancel(){} // RVA: 0x7ffaae248350
        public void ovr_Matchmaking_Cancel_Native(){} // RVA: 0x7ffaae248470
        public void ovr_Matchmaking_Cancel2(){} // RVA: 0x7ffaae248500
        public void ovr_Matchmaking_CreateAndEnqueueRoom(){} // RVA: 0x7ffaae248570
        public void ovr_Matchmaking_CreateAndEnqueueRoom_Native(){} // RVA: 0x7ffaae248690
        public void ovr_Matchmaking_CreateAndEnqueueRoom2(){} // RVA: 0x7ffaae248740
        public void ovr_Matchmaking_CreateAndEnqueueRoom2_Native(){} // RVA: 0x7ffaae248840
        public void ovr_Matchmaking_CreateRoom(){} // RVA: 0x7ffaae2488d0
        public void ovr_Matchmaking_CreateRoom_Native(){} // RVA: 0x7ffaae2489e0
        public void ovr_Matchmaking_CreateRoom2(){} // RVA: 0x7ffaae248a80
        public void ovr_Matchmaking_CreateRoom2_Native(){} // RVA: 0x7ffaae248b80
        public void ovr_Matchmaking_Enqueue(){} // RVA: 0x7ffaae248c10
        public void ovr_Matchmaking_Enqueue_Native(){} // RVA: 0x7ffaae248d10
        public void ovr_Matchmaking_Enqueue2(){} // RVA: 0x7ffaae248da0
        public void ovr_Matchmaking_Enqueue2_Native(){} // RVA: 0x7ffaae248ea0
        public void ovr_Matchmaking_EnqueueRoom(){} // RVA: 0x7ffaae248f30
        public void ovr_Matchmaking_EnqueueRoom2(){} // RVA: 0x7ffaae248fc0
        public void ovr_Matchmaking_GetAdminSnapshot(){} // RVA: 0x7ffaae249050
        public void ovr_Matchmaking_GetStats(){} // RVA: 0x7ffaae2490c0
        public void ovr_Matchmaking_GetStats_Native(){} // RVA: 0x7ffaae2491d0
        public void ovr_Matchmaking_JoinRoom(){} // RVA: 0x7ffaae249270
        public void ovr_Matchmaking_ReportResultInsecure(){} // RVA: 0x7ffaae249300
        public void ovr_Matchmaking_ReportResultInsecure_Native(){} // RVA: 0x7ffaae249510
        public void ovr_Matchmaking_StartMatch(){} // RVA: 0x7ffaae249700
        public void ovr_Media_ShareToFacebook(){} // RVA: 0x7ffaae249780
        public void ovr_Media_ShareToFacebook_Native(){} // RVA: 0x7ffaae2498b0
        public void ovr_NetSync_Connect(){} // RVA: 0x7ffaae249950
        public void ovr_NetSync_Disconnect(){} // RVA: 0x7ffaae2499d0
        public void ovr_NetSync_GetSessions(){} // RVA: 0x7ffaae249a50
        public void ovr_NetSync_GetVoipAttenuation(){} // RVA: 0x7ffaae249ad0
        public void ovr_NetSync_GetVoipAttenuationDefault(){} // RVA: 0x7ffaae249b50
        public void ovr_NetSync_SetVoipAttenuation(){} // RVA: 0x7ffaae249bc0
        public void ovr_NetSync_SetVoipAttenuationModel(){} // RVA: 0x7ffaae249c80
        public void ovr_NetSync_SetVoipAttenuationModel_Native(){} // RVA: 0x7ffaae249dd0
        public void ovr_NetSync_SetVoipChannelCfg(){} // RVA: 0x7ffaae249e90
        public void ovr_NetSync_SetVoipChannelCfg_Native(){} // RVA: 0x7ffaae249fd0
        public void ovr_NetSync_SetVoipGroup(){} // RVA: 0x7ffaae24a080
        public void ovr_NetSync_SetVoipGroup_Native(){} // RVA: 0x7ffaae24a180
        public void ovr_NetSync_SetVoipListentoChannels(){} // RVA: 0x7ffaae24a210
        public void ovr_NetSync_SetVoipMicSource(){} // RVA: 0x7ffaae24a390
        public void ovr_NetSync_SetVoipSessionMuted(){} // RVA: 0x7ffaae24a420
        public void ovr_NetSync_SetVoipSpeaktoChannels(){} // RVA: 0x7ffaae24a4c0
        public void ovr_NetSync_SetVoipStreamMode(){} // RVA: 0x7ffaae24a640
        public void ovr_Notification_GetRoomInvites(){} // RVA: 0x7ffaae24a6e0
        public void ovr_Notification_MarkAsRead(){} // RVA: 0x7ffaae24a750
        public void ovr_Party_Create(){} // RVA: 0x7ffaae24a7d0
        public void ovr_Party_GatherInApplication(){} // RVA: 0x7ffaae24a840
        public void ovr_Party_Get(){} // RVA: 0x7ffaae24a8d0
        public void ovr_Party_GetCurrent(){} // RVA: 0x7ffaae24a950
        public void ovr_Party_GetCurrentForUser(){} // RVA: 0x7ffaae24a9c0
        public void ovr_Party_Invite(){} // RVA: 0x7ffaae24aa40
        public void ovr_Party_Join(){} // RVA: 0x7ffaae24aad0
        public void ovr_Party_Leave(){} // RVA: 0x7ffaae24ab50
        public void ovr_RichPresence_Clear(){} // RVA: 0x7ffaae24abd0
        public void ovr_RichPresence_GetDestinations(){} // RVA: 0x7ffaae24ac40
        public void ovr_RichPresence_Set(){} // RVA: 0x7ffaae24acb0
        public void ovr_RichPresence_SetDestination(){} // RVA: 0x7ffaae24ad30
        public void ovr_RichPresence_SetDestination_Native(){} // RVA: 0x7ffaae24ae30
        public void ovr_RichPresence_SetIsJoinable(){} // RVA: 0x7ffaae24aeb0
        public void ovr_RichPresence_SetLobbySession(){} // RVA: 0x7ffaae24af30
        public void ovr_RichPresence_SetLobbySession_Native(){} // RVA: 0x7ffaae24b030
        public void ovr_RichPresence_SetMatchSession(){} // RVA: 0x7ffaae24b0b0
        public void ovr_RichPresence_SetMatchSession_Native(){} // RVA: 0x7ffaae24b1b0
        public void ovr_Room_CreateAndJoinPrivate(){} // RVA: 0x7ffaae24b230
        public void ovr_Room_CreateAndJoinPrivate2(){} // RVA: 0x7ffaae24b2c0
        public void ovr_Room_Get(){} // RVA: 0x7ffaae24b350
        public void ovr_Room_GetCurrent(){} // RVA: 0x7ffaae24b3d0
        public void ovr_Room_GetCurrentForUser(){} // RVA: 0x7ffaae24b440
        public void ovr_Room_GetInvitableUsers(){} // RVA: 0x7ffaae24b4c0
        public void ovr_Room_GetInvitableUsers2(){} // RVA: 0x7ffaae24b530
        public void ovr_Room_GetModeratedRooms(){} // RVA: 0x7ffaae24b5b0
        public void ovr_Room_GetSocialRooms(){} // RVA: 0x7ffaae24b620
        public void ovr_Room_InviteUser(){} // RVA: 0x7ffaae24b6a0
        public void ovr_Room_InviteUser_Native(){} // RVA: 0x7ffaae24b7a0
        public void ovr_Room_Join(){} // RVA: 0x7ffaae24b830
        public void ovr_Room_Join2(){} // RVA: 0x7ffaae24b8c0
        public void ovr_Room_KickUser(){} // RVA: 0x7ffaae24b950
        public void ovr_Room_LaunchInvitableUserFlow(){} // RVA: 0x7ffaae24b9f0
        public void ovr_Room_Leave(){} // RVA: 0x7ffaae24ba70
        public void ovr_Room_SetDescription(){} // RVA: 0x7ffaae24baf0
        public void ovr_Room_SetDescription_Native(){} // RVA: 0x7ffaae24bbf0
        public void ovr_Room_UpdateDataStore(){} // RVA: 0x7ffaae24bc80
        public void ovr_Room_UpdateDataStore_Native(){} // RVA: 0x7ffaae24be90
        public void ovr_Room_UpdateMembershipLockStatus(){} // RVA: 0x7ffaae24c080
        public void ovr_Room_UpdateOwner(){} // RVA: 0x7ffaae24c110
        public void ovr_Room_UpdatePrivateRoomJoinPolicy(){} // RVA: 0x7ffaae24c1a0
        public void ovr_User_CancelRecordingForReportFlow(){} // RVA: 0x7ffaae24c230
        public void ovr_User_CancelRecordingForReportFlow_Native(){} // RVA: 0x7ffaae24c330
        public void ovr_User_Get(){} // RVA: 0x7ffaae24c3b0
        public void ovr_User_GetAccessToken(){} // RVA: 0x7ffaae24c430
        public void ovr_User_GetBlockedUsers(){} // RVA: 0x7ffaae24c4a0
        public void ovr_User_GetLinkedAccounts(){} // RVA: 0x7ffaae24c510
        public void ovr_User_GetLoggedInUser(){} // RVA: 0x7ffaae24c590
        public void ovr_User_GetLoggedInUserFriends(){} // RVA: 0x7ffaae24c600
        public void ovr_User_GetLoggedInUserFriendsAndRooms(){} // RVA: 0x7ffaae24c670
        public void ovr_User_GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x7ffaae24c6e0
        public void ovr_User_GetOrgScopedID(){} // RVA: 0x7ffaae24c760
        public void ovr_User_GetSdkAccounts(){} // RVA: 0x7ffaae24c7e0
        public void ovr_User_GetUserCapabilities(){} // RVA: 0x7ffaae24c850
        public void ovr_User_GetUserProof(){} // RVA: 0x7ffaae24c8c0
        public void ovr_User_LaunchBlockFlow(){} // RVA: 0x7ffaae24c930
        public void ovr_User_LaunchFriendRequestFlow(){} // RVA: 0x7ffaae24c9b0
        public void ovr_User_LaunchProfile(){} // RVA: 0x7ffaae24ca30
        public void ovr_User_LaunchReportFlow(){} // RVA: 0x7ffaae24cab0
        public void ovr_User_LaunchReportFlow2(){} // RVA: 0x7ffaae24cb30
        public void ovr_User_LaunchUnblockFlow(){} // RVA: 0x7ffaae24cbc0
        public void ovr_User_NewEntitledTestUser(){} // RVA: 0x7ffaae24cc40
        public void ovr_User_NewTestUser(){} // RVA: 0x7ffaae24ccb0
        public void ovr_User_NewTestUserFriends(){} // RVA: 0x7ffaae24cd20
        public void ovr_User_StartRecordingForReportFlow(){} // RVA: 0x7ffaae24cd90
        public void ovr_User_StopRecordingAndLaunchReportFlow(){} // RVA: 0x7ffaae24ce00
        public void ovr_User_StopRecordingAndLaunchReportFlow_Native(){} // RVA: 0x7ffaae24cf00
        public void ovr_User_StopRecordingAndLaunchReportFlow2(){} // RVA: 0x7ffaae24cf90
        public void ovr_User_StopRecordingAndLaunchReportFlow2_Native(){} // RVA: 0x7ffaae24d0a0
        public void ovr_User_TestUserCreateDeviceManifest(){} // RVA: 0x7ffaae24d140
        public void ovr_User_TestUserCreateDeviceManifest_Native(){} // RVA: 0x7ffaae24d260
        public void ovr_UserDataStore_PrivateDeleteEntryByKey(){} // RVA: 0x7ffaae24d300
        public void ovr_UserDataStore_PrivateDeleteEntryByKey_Native(){} // RVA: 0x7ffaae24d400
        public void ovr_UserDataStore_PrivateGetEntries(){} // RVA: 0x7ffaae24d490
        public void ovr_UserDataStore_PrivateGetEntryByKey(){} // RVA: 0x7ffaae24d510
        public void ovr_UserDataStore_PrivateGetEntryByKey_Native(){} // RVA: 0x7ffaae24d610
        public void ovr_UserDataStore_PrivateWriteEntry(){} // RVA: 0x7ffaae24d6a0
        public void ovr_UserDataStore_PrivateWriteEntry_Native(){} // RVA: 0x7ffaae24d7d0
        public void ovr_UserDataStore_PublicDeleteEntryByKey(){} // RVA: 0x7ffaae24d870
        public void ovr_UserDataStore_PublicDeleteEntryByKey_Native(){} // RVA: 0x7ffaae24d970
        public void ovr_UserDataStore_PublicGetEntries(){} // RVA: 0x7ffaae24da00
        public void ovr_UserDataStore_PublicGetEntryByKey(){} // RVA: 0x7ffaae24da80
        public void ovr_UserDataStore_PublicGetEntryByKey_Native(){} // RVA: 0x7ffaae24db80
        public void ovr_UserDataStore_PublicWriteEntry(){} // RVA: 0x7ffaae24dc10
        public void ovr_UserDataStore_PublicWriteEntry_Native(){} // RVA: 0x7ffaae24dd40
        public void ovr_Voip_GetMicrophoneAvailability(){} // RVA: 0x7ffaae24dde0
        public void ovr_Voip_ReportAppVoipSessions(){} // RVA: 0x7ffaae24de50
        public void ovr_Voip_SetSystemVoipSuppressed(){} // RVA: 0x7ffaae24dee0
        public void ovr_AbuseReportRecording_GetRecordingUuid(){} // RVA: 0x7ffaae24df60
        public void ovr_AbuseReportRecording_GetRecordingUuid_Native(){} // RVA: 0x7ffaae24e020
        public void ovr_AchievementDefinition_GetBitfieldLength(){} // RVA: 0x7ffaae24e0a0
        public void ovr_AchievementDefinition_GetName(){} // RVA: 0x7ffaae24e120
        public void ovr_AchievementDefinition_GetName_Native(){} // RVA: 0x7ffaae24e1e0
        public void ovr_AchievementDefinition_GetTarget(){} // RVA: 0x7ffaae24e260
        public void ovr_AchievementDefinition_GetType(){} // RVA: 0x7ffaae24e2e0
        public void ovr_AchievementDefinitionArray_GetElement(){} // RVA: 0x7ffaae24e360
        public void ovr_AchievementDefinitionArray_GetNextUrl(){} // RVA: 0x7ffaae24e3f0
        public void ovr_AchievementDefinitionArray_GetNextUrl_Native(){} // RVA: 0x7ffaae24e4b0
        public void ovr_AchievementDefinitionArray_GetSize(){} // RVA: 0x7ffaae24e530
        public void ovr_AchievementDefinitionArray_HasNextPage(){} // RVA: 0x7ffaae24e5b0
        public void ovr_AchievementProgress_GetBitfield(){} // RVA: 0x7ffaae24e630
        public void ovr_AchievementProgress_GetBitfield_Native(){} // RVA: 0x7ffaae24e6f0
        public void ovr_AchievementProgress_GetCount(){} // RVA: 0x7ffaae24e770
        public void ovr_AchievementProgress_GetIsUnlocked(){} // RVA: 0x7ffaae24e7f0
        public void ovr_AchievementProgress_GetName(){} // RVA: 0x7ffaae24e870
        public void ovr_AchievementProgress_GetName_Native(){} // RVA: 0x7ffaae24e930
        public void ovr_AchievementProgress_GetUnlockTime(){} // RVA: 0x7ffaae24e9b0
        public void ovr_AchievementProgress_GetUnlockTime_Native(){} // RVA: 0x7ffaae24ea70
        public void ovr_AchievementProgressArray_GetElement(){} // RVA: 0x7ffaae24eaf0
        public void ovr_AchievementProgressArray_GetNextUrl(){} // RVA: 0x7ffaae24eb80
        public void ovr_AchievementProgressArray_GetNextUrl_Native(){} // RVA: 0x7ffaae24ec40
        public void ovr_AchievementProgressArray_GetSize(){} // RVA: 0x7ffaae24ecc0
        public void ovr_AchievementProgressArray_HasNextPage(){} // RVA: 0x7ffaae24ed40
        public void ovr_AchievementUpdate_GetJustUnlocked(){} // RVA: 0x7ffaae24edc0
        public void ovr_AchievementUpdate_GetName(){} // RVA: 0x7ffaae24ee40
        public void ovr_AchievementUpdate_GetName_Native(){} // RVA: 0x7ffaae24ef00
        public void ovr_Application_GetID(){} // RVA: 0x7ffaae24ef80
        public void ovr_ApplicationInvite_GetDestination(){} // RVA: 0x7ffaae24f000
        public void ovr_ApplicationInvite_GetID(){} // RVA: 0x7ffaae24f080
        public void ovr_ApplicationInvite_GetIsActive(){} // RVA: 0x7ffaae24f100
        public void ovr_ApplicationInvite_GetLobbySessionId(){} // RVA: 0x7ffaae24f180
        public void ovr_ApplicationInvite_GetLobbySessionId_Native(){} // RVA: 0x7ffaae24f240
        public void ovr_ApplicationInvite_GetMatchSessionId(){} // RVA: 0x7ffaae24f2c0
        public void ovr_ApplicationInvite_GetMatchSessionId_Native(){} // RVA: 0x7ffaae24f380
        public void ovr_ApplicationInvite_GetRecipient(){} // RVA: 0x7ffaae24f400
        public void ovr_ApplicationInviteArray_GetElement(){} // RVA: 0x7ffaae24f480
        public void ovr_ApplicationInviteArray_GetNextUrl(){} // RVA: 0x7ffaae24f510
        public void ovr_ApplicationInviteArray_GetNextUrl_Native(){} // RVA: 0x7ffaae24f5d0
        public void ovr_ApplicationInviteArray_GetSize(){} // RVA: 0x7ffaae24f650
        public void ovr_ApplicationInviteArray_HasNextPage(){} // RVA: 0x7ffaae24f6d0
        public void ovr_ApplicationVersion_GetCurrentCode(){} // RVA: 0x7ffaae24f750
        public void ovr_ApplicationVersion_GetCurrentName(){} // RVA: 0x7ffaae24f7d0
        public void ovr_ApplicationVersion_GetCurrentName_Native(){} // RVA: 0x7ffaae24f890
        public void ovr_ApplicationVersion_GetLatestCode(){} // RVA: 0x7ffaae24f910
        public void ovr_ApplicationVersion_GetLatestName(){} // RVA: 0x7ffaae24f990
        public void ovr_ApplicationVersion_GetLatestName_Native(){} // RVA: 0x7ffaae24fa50
        public void ovr_AssetDetails_GetAssetId(){} // RVA: 0x7ffaae24fad0
        public void ovr_AssetDetails_GetAssetType(){} // RVA: 0x7ffaae24fb50
        public void ovr_AssetDetails_GetAssetType_Native(){} // RVA: 0x7ffaae24fc10
        public void ovr_AssetDetails_GetDownloadStatus(){} // RVA: 0x7ffaae24fc90
        public void ovr_AssetDetails_GetDownloadStatus_Native(){} // RVA: 0x7ffaae24fd50
        public void ovr_AssetDetails_GetFilepath(){} // RVA: 0x7ffaae24fdd0
        public void ovr_AssetDetails_GetFilepath_Native(){} // RVA: 0x7ffaae24fe90
        public void ovr_AssetDetails_GetIapStatus(){} // RVA: 0x7ffaae24ff10
        public void ovr_AssetDetails_GetIapStatus_Native(){} // RVA: 0x7ffaae24ffd0
        public void ovr_AssetDetails_GetLanguage(){} // RVA: 0x7ffaae250050
        public void ovr_AssetDetails_GetMetadata(){} // RVA: 0x7ffaae2500d0
        public void ovr_AssetDetails_GetMetadata_Native(){} // RVA: 0x7ffaae250190
        public void ovr_AssetDetailsArray_GetElement(){} // RVA: 0x7ffaae250210
        public void ovr_AssetDetailsArray_GetSize(){} // RVA: 0x7ffaae2502a0
        public void ovr_AssetFileDeleteResult_GetAssetFileId(){} // RVA: 0x7ffaae250320
        public void ovr_AssetFileDeleteResult_GetAssetId(){} // RVA: 0x7ffaae2503a0
        public void ovr_AssetFileDeleteResult_GetFilepath(){} // RVA: 0x7ffaae250420
        public void ovr_AssetFileDeleteResult_GetFilepath_Native(){} // RVA: 0x7ffaae2504e0
        public void ovr_AssetFileDeleteResult_GetSuccess(){} // RVA: 0x7ffaae250560
        public void ovr_AssetFileDownloadCancelResult_GetAssetFileId(){} // RVA: 0x7ffaae2505e0
        public void ovr_AssetFileDownloadCancelResult_GetAssetId(){} // RVA: 0x7ffaae250660
        public void ovr_AssetFileDownloadCancelResult_GetFilepath(){} // RVA: 0x7ffaae2506e0
        public void ovr_AssetFileDownloadCancelResult_GetFilepath_Native(){} // RVA: 0x7ffaae2507a0
        public void ovr_AssetFileDownloadCancelResult_GetSuccess(){} // RVA: 0x7ffaae250820
        public void ovr_AssetFileDownloadResult_GetAssetId(){} // RVA: 0x7ffaae2508a0
        public void ovr_AssetFileDownloadResult_GetFilepath(){} // RVA: 0x7ffaae250920
        public void ovr_AssetFileDownloadResult_GetFilepath_Native(){} // RVA: 0x7ffaae2509e0
        public void ovr_AssetFileDownloadUpdate_GetAssetFileId(){} // RVA: 0x7ffaae250a60
        public void ovr_AssetFileDownloadUpdate_GetAssetId(){} // RVA: 0x7ffaae250ae0
        public void ovr_AssetFileDownloadUpdate_GetBytesTotal(){} // RVA: 0x7ffaae250b60
        public void ovr_AssetFileDownloadUpdate_GetBytesTotalLong(){} // RVA: 0x7ffaae250be0
        public void ovr_AssetFileDownloadUpdate_GetBytesTransferred(){} // RVA: 0x7ffaae250c60
        public void ovr_AssetFileDownloadUpdate_GetBytesTransferredLong(){} // RVA: 0x7ffaae250ce0
        public void ovr_AssetFileDownloadUpdate_GetCompleted(){} // RVA: 0x7ffaae250d60
        public void ovr_AvatarEditorResult_GetRequestSent(){} // RVA: 0x7ffaae250de0
        public void ovr_BlockedUser_GetId(){} // RVA: 0x7ffaae250e60
        public void ovr_BlockedUserArray_GetElement(){} // RVA: 0x7ffaae250ee0
        public void ovr_BlockedUserArray_GetNextUrl(){} // RVA: 0x7ffaae250f70
        public void ovr_BlockedUserArray_GetNextUrl_Native(){} // RVA: 0x7ffaae251030
        public void ovr_BlockedUserArray_GetSize(){} // RVA: 0x7ffaae2510b0
        public void ovr_BlockedUserArray_HasNextPage(){} // RVA: 0x7ffaae251130
        public void ovr_CalApplicationFinalized_GetCountdownMS(){} // RVA: 0x7ffaae2511b0
        public void ovr_CalApplicationFinalized_GetID(){} // RVA: 0x7ffaae251230
        public void ovr_CalApplicationFinalized_GetLaunchDetails(){} // RVA: 0x7ffaae2512b0
        public void ovr_CalApplicationFinalized_GetLaunchDetails_Native(){} // RVA: 0x7ffaae251370
        public void ovr_CalApplicationProposed_GetID(){} // RVA: 0x7ffaae2513f0
        public void ovr_CalApplicationSuggestion_GetID(){} // RVA: 0x7ffaae251470
        public void ovr_CalApplicationSuggestion_GetSocialContext(){} // RVA: 0x7ffaae2514f0
        public void ovr_CalApplicationSuggestion_GetSocialContext_Native(){} // RVA: 0x7ffaae2515b0
        public void ovr_CalApplicationSuggestionArray_GetElement(){} // RVA: 0x7ffaae251630
        public void ovr_CalApplicationSuggestionArray_GetSize(){} // RVA: 0x7ffaae2516c0
        public void ovr_Challenge_GetCreationType(){} // RVA: 0x7ffaae251740
        public void ovr_Challenge_GetDescription(){} // RVA: 0x7ffaae2517c0
        public void ovr_Challenge_GetDescription_Native(){} // RVA: 0x7ffaae251880
        public void ovr_Challenge_GetEndDate(){} // RVA: 0x7ffaae251900
        public void ovr_Challenge_GetEndDate_Native(){} // RVA: 0x7ffaae2519c0
        public void ovr_Challenge_GetID(){} // RVA: 0x7ffaae251a40
        public void ovr_Challenge_GetInvitedUsers(){} // RVA: 0x7ffaae251ac0
        public void ovr_Challenge_GetLeaderboard(){} // RVA: 0x7ffaae251b40
        public void ovr_Challenge_GetParticipants(){} // RVA: 0x7ffaae251bc0
        public void ovr_Challenge_GetStartDate(){} // RVA: 0x7ffaae251c40
        public void ovr_Challenge_GetStartDate_Native(){} // RVA: 0x7ffaae251d00
        public void ovr_Challenge_GetTitle(){} // RVA: 0x7ffaae251d80
        public void ovr_Challenge_GetTitle_Native(){} // RVA: 0x7ffaae251e40
        public void ovr_Challenge_GetVisibility(){} // RVA: 0x7ffaae251ec0
        public void ovr_ChallengeArray_GetElement(){} // RVA: 0x7ffaae251f40
        public void ovr_ChallengeArray_GetNextUrl(){} // RVA: 0x7ffaae251fd0
        public void ovr_ChallengeArray_GetNextUrl_Native(){} // RVA: 0x7ffaae252090
        public void ovr_ChallengeArray_GetPreviousUrl(){} // RVA: 0x7ffaae252110
        public void ovr_ChallengeArray_GetPreviousUrl_Native(){} // RVA: 0x7ffaae2521d0
        public void ovr_ChallengeArray_GetSize(){} // RVA: 0x7ffaae252250
        public void ovr_ChallengeArray_GetTotalCount(){} // RVA: 0x7ffaae2522d0
        // ── Binary Analysis Named ──
        public void GetNativeStringLengthNotIncludingNullTerminator(){} // RVA: 0x7ffaae23d8c0
    }

    public class Callback : Object
    {
        public object hasRegisteredRoomInviteNotificationHandler; // 0x313620B0
        public object latestPendingJoinIntentNotifications; // 0x313620B0
        public object IsPersistantBetweenSceneLoads; // 0x33C9E3A0

        // ── Original Methods ──
        public void AddRequest(){} // RVA: 0x7ffaae23b640
        public void RunCallbacks(){} // RVA: 0x7ffaae23b740
        public void RunLimitedCallbacks(){} // RVA: 0x7ffaae23b7c0
        public void OnApplicationQuit(){} // RVA: 0x7ffaae23b850
        public void FlushRoomInviteNotificationQueue(){} // RVA: 0x7ffaae23b950
        public void FlushJoinIntentNotificationQueue(){} // RVA: 0x7ffaae23bb50
        public void HandleMessage(){} // RVA: 0x7ffaae23bc70
        public void .cctor(){} // RVA: 0x7ffaae23c090
        // ── Binary Analysis Named ──
        public void SetNotificationCallback(){} // RVA: 0x7ffaae23b4c0
        public void SetNotificationCallback(){} // RVA: 0x7ffaae23b4c0
    }

    public class CallbackRunner : MonoBehaviour
    {
        // ── Original Methods ──
        public void ovr_UnityResetTestPlatform(){} // RVA: 0x7ffaae23c390
        public void Awake(){} // RVA: 0x7ffaae23c400
        public void Update(){} // RVA: 0x7ffaae23c620
        public void OnDestroy(){} // RVA: 0x7ffaa8932310
        public void OnApplicationQuit(){} // RVA: 0x7ffaae23c6d0
        public void .ctor(){} // RVA: 0x7ffaa898c060
    }

    public class ChallengeOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae26b730
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae26c180
        // ── Binary Analysis Named ──
        public void SetDescription(){} // RVA: 0x7ffaae26b7e0
        public void SetEndDate(){} // RVA: 0x7ffaae26b920
        public void SetIncludeActiveChallenges(){} // RVA: 0x7ffaae26ba30
        public void SetIncludeFutureChallenges(){} // RVA: 0x7ffaae26baf0
        public void SetIncludePastChallenges(){} // RVA: 0x7ffaae26bbb0
        public void SetLeaderboardName(){} // RVA: 0x7ffaae26bc70
        public void SetStartDate(){} // RVA: 0x7ffaae26bdb0
        public void SetTitle(){} // RVA: 0x7ffaae26bec0
        public void SetViewerFilter(){} // RVA: 0x7ffaae26c000
        public void SetVisibility(){} // RVA: 0x7ffaae26c0c0
    }

    public class Core : Object
    {
        public object PlatformUninitializedError; // 0x337A7B80

        // ── Original Methods ──
        public void IsInitialized(){} // RVA: 0x7ffaae27bdd0
        public void ForceInitialized(){} // RVA: 0x7ffaae27be30
        public void getAppID(){} // RVA: 0x7ffaae27be90
        public void AsyncInitialize(){} // RVA: 0x7ffaae27c630
        public void AsyncInitialize(){} // RVA: 0x7ffaae27c630
        public void Initialize(){} // RVA: 0x7ffaae27c970
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae27cee0
        // ── Binary Analysis Named ──
        public void GetAppIDFromConfig(){} // RVA: 0x7ffaae27ce30
    }

    public class GroupPresenceOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae26c270
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae26c8e0
        // ── Binary Analysis Named ──
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7ffaae26c320
        public void SetDestinationApiName(){} // RVA: 0x7ffaae26c460
        public void SetIsJoinable(){} // RVA: 0x7ffaae26c5a0
        public void SetLobbySessionId(){} // RVA: 0x7ffaae26c660
        public void SetMatchSessionId(){} // RVA: 0x7ffaae26c7a0
    }

    public class IMicrophone
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8660cc0
        public void Stop(){} // RVA: 0x7ffaa8660cc0
        public void Update(){} // RVA: 0x7ffaa86491d0
    }

    public class IVoipPCMSource
    {
        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaa8660cc0
        public void PeekSizeElements(){} // RVA: 0x7ffaa8649ca0
        // ── Binary Analysis Named ──
        public void GetPCM(){}
        public void SetSenderID(){} // RVA: 0x7ffaa8660f30
    }

    public class InviteOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae26c9d0
        public void AddSuggestedUser(){} // RVA: 0x7ffaae26ca80
        public void ClearSuggestedUsers(){} // RVA: 0x7ffaae26cb50
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae26cc10
    }

    public class MatchmakingOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae26cd00
        public void ClearCreateRoomDataStore(){} // RVA: 0x7ffaae26cf20
        public void AddEnqueueAdditionalUser(){} // RVA: 0x7ffaae26d160
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x7ffaae26d230
        public void ClearEnqueueDataSettings(){} // RVA: 0x7ffaae26d700
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae26d9c0
        // ── Binary Analysis Named ──
        public void SetCreateRoomDataStore(){} // RVA: 0x7ffaae26cdb0
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x7ffaae26cfe0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x7ffaae26d0a0
        public void SetEnqueueDataSettings(){} // RVA: 0x7ffaae26d590
        public void SetEnqueueDataSettings(){} // RVA: 0x7ffaae26d590
        public void SetEnqueueDataSettings(){} // RVA: 0x7ffaae26d590
        public void SetEnqueueIsDebug(){} // RVA: 0x7ffaae26d7c0
        public void SetEnqueueQueryKey(){} // RVA: 0x7ffaae26d880
    }

    public class Message : Object
    {
        public object error; // 0x30DECED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae26dab0
        public void Finalize(){} // RVA: 0x7ffaa930e6a0
        public void get_Type(){} // RVA: 0x7ffaa897f5c0
        public void get_IsError(){} // RVA: 0x7ffaaa364120
        public void get_RequestID(){} // RVA: 0x7ffaa89357c0
        public void ParseMessageHandle(){} // RVA: 0x7ffaae26ded0
        public void PopMessage(){} // RVA: 0x7ffaae2706b0
        public void set_HandleExtraMessageTypes(){} // RVA: 0x7ffaae270860
        public void get_HandleExtraMessageTypes(){} // RVA: 0x7ffaae270900
        // ── Binary Analysis Named ──
        public void GetError(){} // RVA: 0x7ffaa89600c0
        public void GetPingResult(){} // RVA: 0x7ffaa8f22da0
        public void GetNetworkingPeer(){} // RVA: 0x7ffaa8f22da0
        public void GetHttpTransferUpdate(){} // RVA: 0x7ffaa8f22da0
        public void GetPlatformInitialize(){} // RVA: 0x7ffaa8f22da0
        public void GetAbuseReportRecording(){} // RVA: 0x7ffaa8f22da0
        public void GetAchievementDefinitions(){} // RVA: 0x7ffaa8f22da0
        public void GetAchievementProgressList(){} // RVA: 0x7ffaa8f22da0
        public void GetAchievementUpdate(){} // RVA: 0x7ffaa8f22da0
        public void GetApplicationInviteList(){} // RVA: 0x7ffaa8f22da0
        public void GetApplicationVersion(){} // RVA: 0x7ffaa8f22da0
        public void GetAssetDetails(){} // RVA: 0x7ffaa8f22da0
        public void GetAssetDetailsList(){} // RVA: 0x7ffaa8f22da0
        public void GetAssetFileDeleteResult(){} // RVA: 0x7ffaa8f22da0
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7ffaa8f22da0
        public void GetAssetFileDownloadResult(){} // RVA: 0x7ffaa8f22da0
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7ffaa8f22da0
        public void GetAvatarEditorResult(){} // RVA: 0x7ffaa8f22da0
        public void GetBlockedUserList(){} // RVA: 0x7ffaa8f22da0
        public void GetCalApplicationFinalized(){} // RVA: 0x7ffaa8f22da0
        public void GetCalApplicationProposed(){} // RVA: 0x7ffaa8f22da0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7ffaa8f22da0
        public void GetChallenge(){} // RVA: 0x7ffaa8f22da0
        public void GetChallengeEntryList(){} // RVA: 0x7ffaa8f22da0
        public void GetChallengeList(){} // RVA: 0x7ffaa8f22da0
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7ffaa8f22da0
        public void GetCloudStorageData(){} // RVA: 0x7ffaa8f22da0
        public void GetCloudStorageMetadata(){} // RVA: 0x7ffaa8f22da0
        public void GetCloudStorageMetadataList(){} // RVA: 0x7ffaa8f22da0
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7ffaa8f22da0
        public void GetDataStore(){} // RVA: 0x7ffaa8f22da0
        public void GetDestinationList(){} // RVA: 0x7ffaa8f22da0
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7ffaa8f22da0
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7ffaa8f22da0
        public void GetInstalledApplicationList(){} // RVA: 0x7ffaa8f22da0
        public void GetInvitePanelResultInfo(){} // RVA: 0x7ffaa8f22da0
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7ffaa8f22da0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7ffaa8f22da0
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7ffaa8f22da0
        public void GetLaunchReportFlowResult(){} // RVA: 0x7ffaa8f22da0
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7ffaa8f22da0
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7ffaa8932320
        public void GetLeaderboardEntryList(){} // RVA: 0x7ffaa8f22da0
        public void GetLeaderboardList(){} // RVA: 0x7ffaa8f22da0
        public void GetLinkedAccountList(){} // RVA: 0x7ffaa8f22da0
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7ffaa8f22da0
        public void GetLivestreamingStartResult(){} // RVA: 0x7ffaa8f22da0
        public void GetLivestreamingStatus(){} // RVA: 0x7ffaa8f22da0
        public void GetLivestreamingVideoStats(){} // RVA: 0x7ffaa8f22da0
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7ffaa8f22da0
        public void GetMatchmakingBrowseResult(){} // RVA: 0x7ffaa8f22da0
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7ffaa8f22da0
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7ffaa8f22da0
        public void GetMatchmakingStats(){} // RVA: 0x7ffaa8f22da0
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7ffaa8f22da0
        public void GetNetSyncConnection(){} // RVA: 0x7ffaa8f22da0
        public void GetNetSyncSessionList(){} // RVA: 0x7ffaa8f22da0
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7ffaa8f22da0
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7ffaa8f22da0
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7ffaa8f22da0
        public void GetOrgScopedID(){} // RVA: 0x7ffaa8f22da0
        public void GetParty(){} // RVA: 0x7ffaa8f22da0
        public void GetPartyID(){} // RVA: 0x7ffaa8f22da0
        public void GetPartyUpdateNotification(){} // RVA: 0x7ffaa8f22da0
        public void GetPidList(){} // RVA: 0x7ffaa8f22da0
        public void GetProductList(){} // RVA: 0x7ffaa8f22da0
        public void GetPurchase(){} // RVA: 0x7ffaa8f22da0
        public void GetPurchaseList(){} // RVA: 0x7ffaa8f22da0
        public void GetRejoinDialogResult(){} // RVA: 0x7ffaa8f22da0
        public void GetRoom(){} // RVA: 0x7ffaa8f22da0
        public void GetRoomInviteNotification(){} // RVA: 0x7ffaa8f22da0
        public void GetRoomInviteNotificationList(){} // RVA: 0x7ffaa8f22da0
        public void GetRoomList(){} // RVA: 0x7ffaa8f22da0
        public void GetSdkAccountList(){} // RVA: 0x7ffaa8f22da0
        public void GetSendInvitesResult(){} // RVA: 0x7ffaa8f22da0
        public void GetShareMediaResult(){} // RVA: 0x7ffaa8f22da0
        public void GetString(){} // RVA: 0x7ffaa8f22da0
        public void GetSystemVoipState(){} // RVA: 0x7ffaa8f22da0
        public void GetUser(){} // RVA: 0x7ffaa8f22da0
        public void GetUserAndRoomList(){} // RVA: 0x7ffaa8f22da0
        public void GetUserCapabilityList(){} // RVA: 0x7ffaa8f22da0
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7ffaa8f22da0
        public void GetUserList(){} // RVA: 0x7ffaa8f22da0
        public void GetUserProof(){} // RVA: 0x7ffaa8f22da0
        public void GetUserReportID(){} // RVA: 0x7ffaa8f22da0
    }

    public class Message`1 : Message
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660f30
        public void get_Data(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetDataFromMessage(){} // RVA: 0x7ffaa887e5c0
    }

    public class MultiplayerErrorOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae27b0d0
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae27b240
        // ── Binary Analysis Named ──
        public void SetErrorKey(){} // RVA: 0x7ffaae27b180
    }

    public class NetSyncOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae27b330
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae27b720
        // ── Binary Analysis Named ──
        public void SetVoipGroup(){} // RVA: 0x7ffaae27b3e0
        public void SetVoipStreamDefault(){} // RVA: 0x7ffaae27b520
        public void SetZoneId(){} // RVA: 0x7ffaae27b5e0
    }

    public class Packet : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae27b810
        public void ReadBytes(){} // RVA: 0x7ffaae27b8e0
        public void get_SenderID(){} // RVA: 0x7ffaae27ba40
        public void get_Size(){} // RVA: 0x7ffaa894d380
        public void get_Policy(){} // RVA: 0x7ffaae27bb00
        public void Finalize(){} // RVA: 0x7ffaae27bbc0
        public void Dispose(){} // RVA: 0x7ffaae27bce0
    }

    public class PlatformInternal : Object
    {
        // ── Original Methods ──
        public void CrashApplication(){} // RVA: 0x7ffaae293930
        public void ParseMessageHandle(){} // RVA: 0x7ffaae2939d0
        public void InitializeStandaloneAsync(){} // RVA: 0x7ffaae294730
    }

    public class PlatformSettings : ScriptableObject
    {
        public object ovrUseStandalonePlatform; // 0x33A54030

        // ── Original Methods ──
        public void get_AppID(){} // RVA: 0x7ffaae294c70
        public void set_AppID(){} // RVA: 0x7ffaae294c90
        public void get_MobileAppID(){} // RVA: 0x7ffaae294d00
        public void set_MobileAppID(){} // RVA: 0x7ffaae294d20
        public void get_UseStandalonePlatform(){} // RVA: 0x7ffaae294d90
        public void set_UseStandalonePlatform(){} // RVA: 0x7ffaae294db0
        public void get_Instance(){} // RVA: 0x7ffaae294de0
        public void set_Instance(){} // RVA: 0x7ffaae2950b0
        public void .ctor(){} // RVA: 0x7ffaae295150
    }

    public class Request : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa92bb750
        public void get_RequestID(){} // RVA: 0x7ffaa89357c0
        public void set_RequestID(){} // RVA: 0x7ffaa92bb750
        public void OnComplete(){} // RVA: 0x7ffaae295250
        public void HandleMessage(){} // RVA: 0x7ffaae295300
        public void RunCallbacks(){} // RVA: 0x7ffaae295380
    }

    public class Request`1 : Request
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660f30
        public void OnComplete(){} // RVA: 0x7ffaa8649280
        public void HandleMessage(){} // RVA: 0x7ffaa8660d80
    }

    public class RichPresenceOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae2954d0
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae295f20
        // ── Binary Analysis Named ──
        public void SetApiName(){} // RVA: 0x7ffaae295580
        public void SetCurrentCapacity(){} // RVA: 0x7ffaae2956c0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7ffaae295780
        public void SetEndTime(){} // RVA: 0x7ffaae2958c0
        public void SetExtraContext(){} // RVA: 0x7ffaae2959d0
        public void SetInstanceId(){} // RVA: 0x7ffaae295a90
        public void SetIsIdle(){} // RVA: 0x7ffaae295bd0
        public void SetIsJoinable(){} // RVA: 0x7ffaae295c90
        public void SetMaxCapacity(){} // RVA: 0x7ffaae295d50
        public void SetStartTime(){} // RVA: 0x7ffaae295e10
    }

    public class RoomOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae296010
        public void ClearDataStore(){} // RVA: 0x7ffaae296230
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae296780
        // ── Binary Analysis Named ──
        public void SetDataStore(){} // RVA: 0x7ffaae2960c0
        public void SetExcludeRecentlyMet(){} // RVA: 0x7ffaae2962f0
        public void SetMaxUserResults(){} // RVA: 0x7ffaae2963b0
        public void SetOrdering(){} // RVA: 0x7ffaae296470
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x7ffaae296530
        public void SetRoomId(){} // RVA: 0x7ffaae2965f0
        public void SetTurnOffUpdates(){} // RVA: 0x7ffaae2966c0
    }

    public class RosterOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae296870
        public void AddSuggestedUser(){} // RVA: 0x7ffaae296920
        public void ClearSuggestedUsers(){} // RVA: 0x7ffaae2969f0
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae296ab0
    }

    public class StandalonePlatform : Object
    {
        // ── Original Methods ──
        public void InitializeInEditor(){} // RVA: 0x7ffaae296ba0
        public void AsyncInitialize(){} // RVA: 0x7ffaae296d20
        public void AsyncInitializeWithAccessTokenAndOptions(){} // RVA: 0x7ffaae296ef0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class StandalonePlatformSettings : Object
    {
        // ── Original Methods ──
        public void get_OculusPlatformTestUserEmail(){} // RVA: 0x7ffaae297230
        public void set_OculusPlatformTestUserEmail(){} // RVA: 0x7ffaa8932310
        public void get_OculusPlatformTestUserPassword(){} // RVA: 0x7ffaae297270
        public void set_OculusPlatformTestUserPassword(){} // RVA: 0x7ffaa8932310
        public void get_OculusPlatformTestUserAccessToken(){} // RVA: 0x7ffaae2972b0
        public void set_OculusPlatformTestUserAccessToken(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UserOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae2972f0
        public void AddServiceProvider(){} // RVA: 0x7ffaae297460
        public void ClearServiceProviders(){} // RVA: 0x7ffaae297520
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae2976a0
        // ── Binary Analysis Named ──
        public void SetMaxUsers(){} // RVA: 0x7ffaae2973a0
        public void SetTimeWindow(){} // RVA: 0x7ffaae2975e0
    }

    public class VoipAudioSourceHiLevel : MonoBehaviour
    {
        public object peakAmplitude; // 0x3353B0B0
        public object verboseLogging; // 0x3353B0B0
        public object senderID; // 0x17000011
        public object 00; // 0x30B1B5D0

        // ── Original Methods ──
        public void set_senderID(){} // RVA: 0x7ffaae297790
        public void Stop(){} // RVA: 0x7ffaa8932310
        public void SampleRateToEnum(){} // RVA: 0x7ffaae2977f0
        public void Awake(){} // RVA: 0x7ffaae297820
        public void Start(){} // RVA: 0x7ffaae297d60
        public void CreatePCMSource(){} // RVA: 0x7ffaae297dc0
        public void MSToElements(){} // RVA: 0x7ffaae297e50
        public void Update(){} // RVA: 0x7ffaae297eb0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class VoipOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae298780
        public void op_Explicit(){} // RVA: 0x7ffaae23a100
        public void Finalize(){} // RVA: 0x7ffaae2989b0
        // ── Binary Analysis Named ──
        public void SetBitrateForNewConnections(){} // RVA: 0x7ffaae298830
        public void SetCreateNewConnectionUseDtx(){} // RVA: 0x7ffaae2988f0
    }

    public class VoipPCMSourceNative : Object
    {
        // ── Original Methods ──
        public void PeekSizeElements(){} // RVA: 0x7ffaae298b80
        public void Update(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetPCM(){} // RVA: 0x7ffaae298aa0
        public void SetSenderID(){} // RVA: 0x7ffaa9e463c0
    }

    public class WindowsPlatform : Object
    {
        // ── Original Methods ──
        public void CPPLogCallback(){} // RVA: 0x7ffaae298c40
        public void getCallbackPointer(){} // RVA: 0x7ffaa8f22da0
        public void Initialize(){} // RVA: 0x7ffaae298d80
        public void AsyncInitialize(){} // RVA: 0x7ffaae298eb0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}