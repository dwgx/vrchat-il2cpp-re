// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 34
// Methods: 1506

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class AbuseReportOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C38CC0
        public void SetPreventPeopleChooser(){} // RVA: 0x7FFD53C38D70
        public void SetReportType(){} // RVA: 0x7FFD53C38E30
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C38F00
    }

    public class AdvancedAbuseReportOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C38FF0
        public void SetDeveloperDefinedContext(){} // RVA: 0x7FFD53C390A0
        public void ClearDeveloperDefinedContext(){} // RVA: 0x7FFD53C39210
        public void SetObjectType(){} // RVA: 0x7FFD53C392D0
        public void SetReportType(){} // RVA: 0x7FFD53C39410
        public void AddSuggestedUser(){} // RVA: 0x7FFD53C394D0
        public void ClearSuggestedUsers(){} // RVA: 0x7FFD53C395A0
        public void SetVideoMode(){} // RVA: 0x7FFD53C39660
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C39720
    }

    public class AndroidPlatform : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E341320
        public void AsyncInitialize(){} // RVA: 0x7FFD53C39810
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ApplicationOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C39860
        public void SetDeeplinkMessage(){} // RVA: 0x7FFD53C39910
        public void SetDestinationApiName(){} // RVA: 0x7FFD53C39A50
        public void SetLobbySessionId(){} // RVA: 0x7FFD53C39B90
        public void SetMatchSessionId(){} // RVA: 0x7FFD53C39CD0
        public void SetRoomId(){} // RVA: 0x7FFD53C39E10
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C39EE0
    }

    public class AvatarEditorOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C39FD0
        public void SetSourceOverride(){} // RVA: 0x7FFD53C3A080
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C3A1C0
    }

    public class CAPI : Object
    {
        public string DLL_NAME;
        public System.Text.UTF8Encoding nativeStringEncoding;
        public int VoipFilterBufferSize;

        // ── Methods ──
        public void ArrayOfStructsToIntPtr(){} // RVA: 0x7FFD53C3B5F0
        public void DictionaryToOVRKeyValuePairs(){} // RVA: 0x7FFD53C3BB90 | overloaded x2
        public void IntPtrToByteArray(){} // RVA: 0x7FFD53C3C140
        public void DataStoreFromNative(){} // RVA: 0x7FFD53C3C220
        public void StringFromNative(){} // RVA: 0x7FFD53C3C560
        public void GetNativeStringLengthNotIncludingNullTerminator(){} // RVA: 0x7FFD53C3C6B0
        public void DateTimeFromNative(){} // RVA: 0x7FFD53C3C710
        public void DateTimeToNative(){} // RVA: 0x7FFD53C3C860
        public void BlobFromNative(){} // RVA: 0x7FFD53C3CA10
        public void FiledataFromNative(){} // RVA: 0x7FFD53C3CAE0
        public void StringToNative(){} // RVA: 0x7FFD53C3CB80
        public void ovr_UnityInitWrapper(){} // RVA: 0x7FFD53C3CD30
        public void ovr_UnityInitGlobals(){} // RVA: 0x7FFD53C3CDE0
        public void ovr_UnityInitWrapperAsynchronous(){} // RVA: 0x7FFD53C3CE60
        public void ovr_UnityInitWrapperStandalone(){} // RVA: 0x7FFD53C3CF10
        public void ovr_Platform_InitializeStandaloneOculus(){} // RVA: 0x7FFD53C3CFC0
        public void ovr_PlatformInitializeWithAccessToken(){} // RVA: 0x7FFD53C3D150
        public void ovr_PlatformInitializeWithAccessTokenAndOptions(){} // RVA: 0x7FFD53C3D210
        public void ovr_UnityInitWrapperWindows(){} // RVA: 0x7FFD53C3D3F0
        public void ovr_UnityInitWrapperWindowsAsynchronous(){} // RVA: 0x7FFD53C3D4A0
        public void ovr_SetDeveloperAccessToken(){} // RVA: 0x7FFD53C3D550
        public void ovr_GetLoggedInUserLocale(){} // RVA: 0x7FFD53C3D600
        public void ovr_GetLoggedInUserLocale_Native(){} // RVA: 0x7FFD53C3D6B0
        public void ovr_PopMessage(){} // RVA: 0x7FFD53C3D720
        public void ovr_FreeMessage(){} // RVA: 0x7FFD53C3D790
        public void ovr_Voip_CreateEncoder(){} // RVA: 0x7FFD53C3D810
        public void ovr_Voip_DestroyEncoder(){} // RVA: 0x7FFD53C3D880
        public void ovr_Voip_CreateDecoder(){} // RVA: 0x7FFD53C3D900
        public void ovr_Voip_DestroyDecoder(){} // RVA: 0x7FFD53C3D970
        public void ovr_VoipDecoder_Decode(){} // RVA: 0x7FFD53C641D0 | overloaded x2
        public void ovr_Microphone_Create(){} // RVA: 0x7FFD53C3DA50
        public void ovr_Microphone_Destroy(){} // RVA: 0x7FFD53C3DAC0
        public void ovr_Voip_SetSystemVoipPassthrough(){} // RVA: 0x7FFD53C3DB40
        public void ovr_Voip_SetSystemVoipMicrophoneMuted(){} // RVA: 0x7FFD53C3DBC0
        public void ovr_UnityResetTestPlatform(){} // RVA: 0x7FFD53C3DC40
        public void ovr_HTTP_GetWithMessageType(){} // RVA: 0x7FFD53C3DCB0
        public void ovr_CrashApplication(){} // RVA: 0x7FFD53C3DD60
        public void ovr_Voip_SetMicrophoneFilterCallback(){} // RVA: 0x7FFD53C3DDD0
        public void ovr_Voip_SetMicrophoneFilterCallbackWithFixedSizeBuffer(){} // RVA: 0x7FFD53C3DE60
        public void LogNewUnifiedEvent(){} // RVA: 0x7FFD53C3DF00
        public void LogNewEvent(){} // RVA: 0x7FFD53C3DFA0
        public void ovr_Log_NewEvent(){} // RVA: 0x7FFD53C3E3B0
        public void ovr_ApplicationLifecycle_GetLaunchDetails(){} // RVA: 0x7FFD53C3E450
        public void ovr_ApplicationLifecycle_LogDeeplinkResult(){} // RVA: 0x7FFD53C3E4C0
        public void ovr_ApplicationLifecycle_LogDeeplinkResult_Native(){} // RVA: 0x7FFD53C3E5C0
        public void ovr_HTTP_StartTransfer(){} // RVA: 0x7FFD53C3E650
        public void ovr_HTTP_StartTransfer_Native(){} // RVA: 0x7FFD53C3E8A0
        public void ovr_HTTP_Write(){} // RVA: 0x7FFD53C3EA90
        public void ovr_HTTP_WriteEOM(){} // RVA: 0x7FFD53C3EB40
        public void ovr_Message_GetStringForJavascript(){} // RVA: 0x7FFD53C3EBC0
        public void ovr_Message_GetStringForJavascript_Native(){} // RVA: 0x7FFD53C3EC80
        public void ovr_NetSync_GetAmbisonicFloatPCM(){} // RVA: 0x7FFD53C3ED00
        public void ovr_NetSync_GetAmbisonicInt16PCM(){} // RVA: 0x7FFD53C3EDA0
        public void ovr_NetSync_GetAmbisonicInterleavedFloatPCM(){} // RVA: 0x7FFD53C3EE40
        public void ovr_NetSync_GetAmbisonicInterleavedInt16PCM(){} // RVA: 0x7FFD53C3EEE0
        public void ovr_NetSync_GetListenerPosition(){} // RVA: 0x7FFD53C3EF80
        public void ovr_NetSync_GetMonostreamFloatPCM(){} // RVA: 0x7FFD53C3F020
        public void ovr_NetSync_GetMonostreamInt16PCM(){} // RVA: 0x7FFD53C3F0D0
        public void ovr_NetSync_GetPcmBufferMaxSamples(){} // RVA: 0x7FFD53C3F180
        public void ovr_NetSync_GetVoipAmplitude(){} // RVA: 0x7FFD53C3F1F0
        public void ovr_NetSync_SetListenerPosition(){} // RVA: 0x7FFD53C3F290
        public void ovr_Net_Accept(){} // RVA: 0x7FFD53C3F320
        public void ovr_Net_AcceptForCurrentRoom(){} // RVA: 0x7FFD53C3F3A0
        public void ovr_Net_Close(){} // RVA: 0x7FFD53C3F410
        public void ovr_Net_CloseForCurrentRoom(){} // RVA: 0x7FFD53C3F490
        public void ovr_Net_Connect(){} // RVA: 0x7FFD53C3F500
        public void ovr_Net_IsConnected(){} // RVA: 0x7FFD53C3F580
        public void ovr_Net_Ping(){} // RVA: 0x7FFD53C3F600
        public void ovr_Net_ReadPacket(){} // RVA: 0x7FFD53C3F680
        public void ovr_Net_SendPacket(){} // RVA: 0x7FFD53C3F6F0
        public void ovr_Net_SendPacketToCurrentRoom(){} // RVA: 0x7FFD53C3F7B0
        public void ovr_Party_PluginGetSharedMemHandle(){} // RVA: 0x7FFD53C3F860
        public void ovr_Party_PluginGetVoipMicrophoneMuted(){} // RVA: 0x7FFD53C3F8D0
        public void ovr_Party_PluginGetVoipPassthrough(){} // RVA: 0x7FFD53C3F940
        public void ovr_Party_PluginGetVoipStatus(){} // RVA: 0x7FFD53C3F9B0
        public void ovr_Voip_Accept(){} // RVA: 0x7FFD53C3FA20
        public void ovr_Voip_GetIsConnectionUsingDtx(){} // RVA: 0x7FFD53C3FAA0
        public void ovr_Voip_GetLocalBitrate(){} // RVA: 0x7FFD53C3FB20
        public void ovr_Voip_GetOutputBufferMaxSize(){} // RVA: 0x7FFD53C3FBA0
        public void ovr_Voip_GetPCM(){} // RVA: 0x7FFD53C3FC10
        public void ovr_Voip_GetPCMFloat(){} // RVA: 0x7FFD53C3FCB0
        public void ovr_Voip_GetPCMSize(){} // RVA: 0x7FFD53C3FD50
        public void ovr_Voip_GetPCMWithTimestamp(){} // RVA: 0x7FFD53C3FDD0
        public void ovr_Voip_GetPCMWithTimestampFloat(){} // RVA: 0x7FFD53C3FE90
        public void ovr_Voip_GetRemoteBitrate(){} // RVA: 0x7FFD53C3FF50
        public void ovr_Voip_GetSyncTimestamp(){} // RVA: 0x7FFD53C3FFD0
        public void ovr_Voip_GetSyncTimestampDifference(){} // RVA: 0x7FFD53C40050
        public void ovr_Voip_GetSystemVoipMicrophoneMuted(){} // RVA: 0x7FFD53C400E0
        public void ovr_Voip_GetSystemVoipStatus(){} // RVA: 0x7FFD53C40150
        public void ovr_Voip_SetMicrophoneMuted(){} // RVA: 0x7FFD53C401C0
        public void ovr_Voip_SetNewConnectionOptions(){} // RVA: 0x7FFD53C40240
        public void ovr_Voip_SetOutputSampleRate(){} // RVA: 0x7FFD53C402C0
        public void ovr_Voip_Start(){} // RVA: 0x7FFD53C40340
        public void ovr_Voip_Stop(){} // RVA: 0x7FFD53C403C0
        public void ovr_AbuseReport_LaunchAdvancedReportFlow(){} // RVA: 0x7FFD53C40440
        public void ovr_AbuseReport_ReportRequestHandled(){} // RVA: 0x7FFD53C404D0
        public void ovr_Achievements_AddCount(){} // RVA: 0x7FFD53C40550
        public void ovr_Achievements_AddCount_Native(){} // RVA: 0x7FFD53C40650
        public void ovr_Achievements_AddFields(){} // RVA: 0x7FFD53C406E0
        public void ovr_Achievements_AddFields_Native(){} // RVA: 0x7FFD53C40800
        public void ovr_Achievements_GetAllDefinitions(){} // RVA: 0x7FFD53C40890
        public void ovr_Achievements_GetAllProgress(){} // RVA: 0x7FFD53C40900
        public void ovr_Achievements_GetDefinitionsByName(){} // RVA: 0x7FFD53C40970
        public void ovr_Achievements_GetProgressByName(){} // RVA: 0x7FFD53C40AE0
        public void ovr_Achievements_Unlock(){} // RVA: 0x7FFD53C40C50
        public void ovr_Achievements_Unlock_Native(){} // RVA: 0x7FFD53C40D50
        public void ovr_Application_ExecuteCoordinatedLaunch(){} // RVA: 0x7FFD53C40DD0
        public void ovr_Application_GetInstalledApplications(){} // RVA: 0x7FFD53C40E60
        public void ovr_Application_GetVersion(){} // RVA: 0x7FFD53C40ED0
        public void ovr_Application_LaunchOtherApp(){} // RVA: 0x7FFD53C40F40
        public void ovr_ApplicationLifecycle_GetRegisteredPIDs(){} // RVA: 0x7FFD53C40FD0
        public void ovr_ApplicationLifecycle_GetSessionKey(){} // RVA: 0x7FFD53C41040
        public void ovr_ApplicationLifecycle_RegisterSessionKey(){} // RVA: 0x7FFD53C410B0
        public void ovr_ApplicationLifecycle_RegisterSessionKey_Native(){} // RVA: 0x7FFD53C411B0
        public void ovr_AssetFile_Delete(){} // RVA: 0x7FFD53C41230
        public void ovr_AssetFile_DeleteById(){} // RVA: 0x7FFD53C412B0
        public void ovr_AssetFile_DeleteByName(){} // RVA: 0x7FFD53C41330
        public void ovr_AssetFile_DeleteByName_Native(){} // RVA: 0x7FFD53C41430
        public void ovr_AssetFile_Download(){} // RVA: 0x7FFD53C414B0
        public void ovr_AssetFile_DownloadById(){} // RVA: 0x7FFD53C41530
        public void ovr_AssetFile_DownloadByName(){} // RVA: 0x7FFD53C415B0
        public void ovr_AssetFile_DownloadByName_Native(){} // RVA: 0x7FFD53C416B0
        public void ovr_AssetFile_DownloadCancel(){} // RVA: 0x7FFD53C41730
        public void ovr_AssetFile_DownloadCancelById(){} // RVA: 0x7FFD53C417B0
        public void ovr_AssetFile_DownloadCancelByName(){} // RVA: 0x7FFD53C41830
        public void ovr_AssetFile_DownloadCancelByName_Native(){} // RVA: 0x7FFD53C41930
        public void ovr_AssetFile_GetList(){} // RVA: 0x7FFD53C419B0
        public void ovr_AssetFile_Status(){} // RVA: 0x7FFD53C41A20
        public void ovr_AssetFile_StatusById(){} // RVA: 0x7FFD53C41AA0
        public void ovr_AssetFile_StatusByName(){} // RVA: 0x7FFD53C41B20
        public void ovr_AssetFile_StatusByName_Native(){} // RVA: 0x7FFD53C41C20
        public void ovr_Avatar_LaunchAvatarEditor(){} // RVA: 0x7FFD53C41CA0
        public void ovr_Avatar_UpdateMetaData(){} // RVA: 0x7FFD53C41D20
        public void ovr_Avatar_UpdateMetaData_Native(){} // RVA: 0x7FFD53C41E40
        public void ovr_Cal_FinalizeApplication(){} // RVA: 0x7FFD53C41ED0
        public void ovr_Cal_GetSuggestedApplications(){} // RVA: 0x7FFD53C41F80
        public void ovr_Cal_ProposeApplication(){} // RVA: 0x7FFD53C42020
        public void ovr_Challenges_Create(){} // RVA: 0x7FFD53C420D0
        public void ovr_Challenges_Create_Native(){} // RVA: 0x7FFD53C421D0
        public void ovr_Challenges_DeclineInvite(){} // RVA: 0x7FFD53C42260
        public void ovr_Challenges_Delete(){} // RVA: 0x7FFD53C422E0
        public void ovr_Challenges_Get(){} // RVA: 0x7FFD53C42360
        public void ovr_Challenges_GetEntries(){} // RVA: 0x7FFD53C423E0
        public void ovr_Challenges_GetEntriesAfterRank(){} // RVA: 0x7FFD53C42480
        public void ovr_Challenges_GetEntriesByIds(){} // RVA: 0x7FFD53C42520
        public void ovr_Challenges_GetList(){} // RVA: 0x7FFD53C425D0
        public void ovr_Challenges_GetNextChallenges(){} // RVA: 0x7FFD53C42660
        public void ovr_Challenges_GetNextEntries(){} // RVA: 0x7FFD53C426E0
        public void ovr_Challenges_GetPreviousChallenges(){} // RVA: 0x7FFD53C42760
        public void ovr_Challenges_GetPreviousEntries(){} // RVA: 0x7FFD53C427E0
        public void ovr_Challenges_Join(){} // RVA: 0x7FFD53C42860
        public void ovr_Challenges_Leave(){} // RVA: 0x7FFD53C428E0
        public void ovr_Challenges_UpdateInfo(){} // RVA: 0x7FFD53C42960
        public void ovr_CloudStorage_Delete(){} // RVA: 0x7FFD53C429F0
        public void ovr_CloudStorage_Delete_Native(){} // RVA: 0x7FFD53C42B10
        public void ovr_CloudStorage_Load(){} // RVA: 0x7FFD53C42BA0
        public void ovr_CloudStorage_Load_Native(){} // RVA: 0x7FFD53C42CC0
        public void ovr_CloudStorage_LoadBucketMetadata(){} // RVA: 0x7FFD53C42D50
        public void ovr_CloudStorage_LoadBucketMetadata_Native(){} // RVA: 0x7FFD53C42E50
        public void ovr_CloudStorage_LoadConflictMetadata(){} // RVA: 0x7FFD53C42ED0
        public void ovr_CloudStorage_LoadConflictMetadata_Native(){} // RVA: 0x7FFD53C42FF0
        public void ovr_CloudStorage_LoadHandle(){} // RVA: 0x7FFD53C43080
        public void ovr_CloudStorage_LoadHandle_Native(){} // RVA: 0x7FFD53C43180
        public void ovr_CloudStorage_LoadMetadata(){} // RVA: 0x7FFD53C43200
        public void ovr_CloudStorage_LoadMetadata_Native(){} // RVA: 0x7FFD53C43320
        public void ovr_CloudStorage_ResolveKeepLocal(){} // RVA: 0x7FFD53C433B0
        public void ovr_CloudStorage_ResolveKeepLocal_Native(){} // RVA: 0x7FFD53C43500
        public void ovr_CloudStorage_ResolveKeepRemote(){} // RVA: 0x7FFD53C435A0
        public void ovr_CloudStorage_ResolveKeepRemote_Native(){} // RVA: 0x7FFD53C436F0
        public void ovr_CloudStorage_Save(){} // RVA: 0x7FFD53C43790
        public void ovr_CloudStorage_Save_Native(){} // RVA: 0x7FFD53C43910
        public void ovr_CloudStorage2_GetUserDirectoryPath(){} // RVA: 0x7FFD53C439C0
        public void ovr_Colocation_GetCurrentMapUuid(){} // RVA: 0x7FFD53C43A30
        public void ovr_Colocation_RequestMap(){} // RVA: 0x7FFD53C43AA0
        public void ovr_Colocation_RequestMap_Native(){} // RVA: 0x7FFD53C43BA0
        public void ovr_Colocation_ShareMap(){} // RVA: 0x7FFD53C43C20
        public void ovr_Colocation_ShareMap_Native(){} // RVA: 0x7FFD53C43D20
        public void ovr_DeviceApplicationIntegrity_GetAttestationToken(){} // RVA: 0x7FFD53C43DA0
        public void ovr_DeviceApplicationIntegrity_GetAttestationToken_Native(){} // RVA: 0x7FFD53C43EA0
        public void ovr_Entitlement_GetIsViewerEntitled(){} // RVA: 0x7FFD53C43F20
        public void ovr_GraphAPI_Get(){} // RVA: 0x7FFD53C43F90
        public void ovr_GraphAPI_Get_Native(){} // RVA: 0x7FFD53C44090
        public void ovr_GraphAPI_Post(){} // RVA: 0x7FFD53C44110
        public void ovr_GraphAPI_Post_Native(){} // RVA: 0x7FFD53C44210
        public void ovr_GroupPresence_Clear(){} // RVA: 0x7FFD53C44290
        public void ovr_GroupPresence_GetInvitableUsers(){} // RVA: 0x7FFD53C44300
        public void ovr_GroupPresence_GetSentInvites(){} // RVA: 0x7FFD53C44380
        public void ovr_GroupPresence_LaunchInvitePanel(){} // RVA: 0x7FFD53C443F0
        public void ovr_GroupPresence_LaunchMultiplayerErrorDialog(){} // RVA: 0x7FFD53C44470
        public void ovr_GroupPresence_LaunchRejoinDialog(){} // RVA: 0x7FFD53C444F0
        public void ovr_GroupPresence_LaunchRejoinDialog_Native(){} // RVA: 0x7FFD53C44640
        public void ovr_GroupPresence_LaunchRosterPanel(){} // RVA: 0x7FFD53C446E0
        public void ovr_GroupPresence_SendInvites(){} // RVA: 0x7FFD53C44760
        public void ovr_GroupPresence_Set(){} // RVA: 0x7FFD53C447F0
        public void ovr_GroupPresence_SetDeeplinkMessageOverride(){} // RVA: 0x7FFD53C44870
        public void ovr_GroupPresence_SetDeeplinkMessageOverride_Native(){} // RVA: 0x7FFD53C44970
        public void ovr_GroupPresence_SetDestination(){} // RVA: 0x7FFD53C449F0
        public void ovr_GroupPresence_SetDestination_Native(){} // RVA: 0x7FFD53C44AF0
        public void ovr_GroupPresence_SetIsJoinable(){} // RVA: 0x7FFD53C44B70
        public void ovr_GroupPresence_SetLobbySession(){} // RVA: 0x7FFD53C44BF0
        public void ovr_GroupPresence_SetLobbySession_Native(){} // RVA: 0x7FFD53C44CF0
        public void ovr_GroupPresence_SetMatchSession(){} // RVA: 0x7FFD53C44D70
        public void ovr_GroupPresence_SetMatchSession_Native(){} // RVA: 0x7FFD53C44E70
        public void ovr_HTTP_Get(){} // RVA: 0x7FFD53C44EF0
        public void ovr_HTTP_Get_Native(){} // RVA: 0x7FFD53C44FF0
        public void ovr_HTTP_GetToFile(){} // RVA: 0x7FFD53C45070
        public void ovr_HTTP_GetToFile_Native(){} // RVA: 0x7FFD53C45190
        public void ovr_HTTP_MultiPartPost(){} // RVA: 0x7FFD53C45220
        public void ovr_HTTP_MultiPartPost_Native(){} // RVA: 0x7FFD53C45360
        public void ovr_HTTP_Post(){} // RVA: 0x7FFD53C45590
        public void ovr_HTTP_Post_Native(){} // RVA: 0x7FFD53C45690
        public void ovr_IAP_ConsumePurchase(){} // RVA: 0x7FFD53C45710
        public void ovr_IAP_ConsumePurchase_Native(){} // RVA: 0x7FFD53C45810
        public void ovr_IAP_GetProductsBySKU(){} // RVA: 0x7FFD53C45890
        public void ovr_IAP_GetViewerPurchases(){} // RVA: 0x7FFD53C45A00
        public void ovr_IAP_GetViewerPurchasesDurableCache(){} // RVA: 0x7FFD53C45A70
        public void ovr_IAP_LaunchCheckoutFlow(){} // RVA: 0x7FFD53C45AE0
        public void ovr_IAP_LaunchCheckoutFlow_Native(){} // RVA: 0x7FFD53C45BE0
        public void ovr_LanguagePack_GetCurrent(){} // RVA: 0x7FFD53C45C60
        public void ovr_LanguagePack_SetCurrent(){} // RVA: 0x7FFD53C45CD0
        public void ovr_LanguagePack_SetCurrent_Native(){} // RVA: 0x7FFD53C45DD0
        public void ovr_Leaderboard_Get(){} // RVA: 0x7FFD53C45E50
        public void ovr_Leaderboard_Get_Native(){} // RVA: 0x7FFD53C45F50
        public void ovr_Leaderboard_GetEntries(){} // RVA: 0x7FFD53C45FD0
        public void ovr_Leaderboard_GetEntries_Native(){} // RVA: 0x7FFD53C460F0
        public void ovr_Leaderboard_GetEntriesAfterRank(){} // RVA: 0x7FFD53C46190
        public void ovr_Leaderboard_GetEntriesAfterRank_Native(){} // RVA: 0x7FFD53C462A0
        public void ovr_Leaderboard_GetEntriesByIds(){} // RVA: 0x7FFD53C46340
        public void ovr_Leaderboard_GetEntriesByIds_Native(){} // RVA: 0x7FFD53C46480
        public void ovr_Leaderboard_GetNextEntries(){} // RVA: 0x7FFD53C46530
        public void ovr_Leaderboard_GetPreviousEntries(){} // RVA: 0x7FFD53C465B0
        public void ovr_Leaderboard_WriteEntry(){} // RVA: 0x7FFD53C46630
        public void ovr_Leaderboard_WriteEntry_Native(){} // RVA: 0x7FFD53C46770
        public void ovr_Leaderboard_WriteEntryWithSupplementaryMetric(){} // RVA: 0x7FFD53C46830
        public void ovr_Leaderboard_WriteEntryWithSupplementaryMetric_Native(){} // RVA: 0x7FFD53C46980
        public void ovr_Livestreaming_IsAllowedForApplication(){} // RVA: 0x7FFD53C46A40
        public void ovr_Livestreaming_IsAllowedForApplication_Native(){} // RVA: 0x7FFD53C46B40
        public void ovr_Livestreaming_StartPartyStream(){} // RVA: 0x7FFD53C46BC0
        public void ovr_Livestreaming_StartStream(){} // RVA: 0x7FFD53C46C30
        public void ovr_Livestreaming_StopPartyStream(){} // RVA: 0x7FFD53C46CC0
        public void ovr_Livestreaming_StopStream(){} // RVA: 0x7FFD53C46D30
        public void ovr_Livestreaming_UpdateMicStatus(){} // RVA: 0x7FFD53C46DA0
        public void ovr_Matchmaking_Browse(){} // RVA: 0x7FFD53C46E20
        public void ovr_Matchmaking_Browse_Native(){} // RVA: 0x7FFD53C46F20
        public void ovr_Matchmaking_Browse2(){} // RVA: 0x7FFD53C46FB0
        public void ovr_Matchmaking_Browse2_Native(){} // RVA: 0x7FFD53C470B0
        public void ovr_Matchmaking_Cancel(){} // RVA: 0x7FFD53C47140
        public void ovr_Matchmaking_Cancel_Native(){} // RVA: 0x7FFD53C47260
        public void ovr_Matchmaking_Cancel2(){} // RVA: 0x7FFD53C472F0
        public void ovr_Matchmaking_CreateAndEnqueueRoom(){} // RVA: 0x7FFD53C47360
        public void ovr_Matchmaking_CreateAndEnqueueRoom_Native(){} // RVA: 0x7FFD53C47480
        public void ovr_Matchmaking_CreateAndEnqueueRoom2(){} // RVA: 0x7FFD53C47530
        public void ovr_Matchmaking_CreateAndEnqueueRoom2_Native(){} // RVA: 0x7FFD53C47630
        public void ovr_Matchmaking_CreateRoom(){} // RVA: 0x7FFD53C476C0
        public void ovr_Matchmaking_CreateRoom_Native(){} // RVA: 0x7FFD53C477D0
        public void ovr_Matchmaking_CreateRoom2(){} // RVA: 0x7FFD53C47870
        public void ovr_Matchmaking_CreateRoom2_Native(){} // RVA: 0x7FFD53C47970
        public void ovr_Matchmaking_Enqueue(){} // RVA: 0x7FFD53C47A00
        public void ovr_Matchmaking_Enqueue_Native(){} // RVA: 0x7FFD53C47B00
        public void ovr_Matchmaking_Enqueue2(){} // RVA: 0x7FFD53C47B90
        public void ovr_Matchmaking_Enqueue2_Native(){} // RVA: 0x7FFD53C47C90
        public void ovr_Matchmaking_EnqueueRoom(){} // RVA: 0x7FFD53C47D20
        public void ovr_Matchmaking_EnqueueRoom2(){} // RVA: 0x7FFD53C47DB0
        public void ovr_Matchmaking_GetAdminSnapshot(){} // RVA: 0x7FFD53C47E40
        public void ovr_Matchmaking_GetStats(){} // RVA: 0x7FFD53C47EB0
        public void ovr_Matchmaking_GetStats_Native(){} // RVA: 0x7FFD53C47FC0
        public void ovr_Matchmaking_JoinRoom(){} // RVA: 0x7FFD53C48060
        public void ovr_Matchmaking_ReportResultInsecure(){} // RVA: 0x7FFD53C480F0
        public void ovr_Matchmaking_ReportResultInsecure_Native(){} // RVA: 0x7FFD53C48300
        public void ovr_Matchmaking_StartMatch(){} // RVA: 0x7FFD53C484F0
        public void ovr_Media_ShareToFacebook(){} // RVA: 0x7FFD53C48570
        public void ovr_Media_ShareToFacebook_Native(){} // RVA: 0x7FFD53C486A0
        public void ovr_NetSync_Connect(){} // RVA: 0x7FFD53C48740
        public void ovr_NetSync_Disconnect(){} // RVA: 0x7FFD53C487C0
        public void ovr_NetSync_GetSessions(){} // RVA: 0x7FFD53C48840
        public void ovr_NetSync_GetVoipAttenuation(){} // RVA: 0x7FFD53C488C0
        public void ovr_NetSync_GetVoipAttenuationDefault(){} // RVA: 0x7FFD53C48940
        public void ovr_NetSync_SetVoipAttenuation(){} // RVA: 0x7FFD53C489B0
        public void ovr_NetSync_SetVoipAttenuationModel(){} // RVA: 0x7FFD53C48A70
        public void ovr_NetSync_SetVoipAttenuationModel_Native(){} // RVA: 0x7FFD53C48BC0
        public void ovr_NetSync_SetVoipChannelCfg(){} // RVA: 0x7FFD53C48C80
        public void ovr_NetSync_SetVoipChannelCfg_Native(){} // RVA: 0x7FFD53C48DC0
        public void ovr_NetSync_SetVoipGroup(){} // RVA: 0x7FFD53C48E70
        public void ovr_NetSync_SetVoipGroup_Native(){} // RVA: 0x7FFD53C48F70
        public void ovr_NetSync_SetVoipListentoChannels(){} // RVA: 0x7FFD53C49000
        public void ovr_NetSync_SetVoipMicSource(){} // RVA: 0x7FFD53C49180
        public void ovr_NetSync_SetVoipSessionMuted(){} // RVA: 0x7FFD53C49210
        public void ovr_NetSync_SetVoipSpeaktoChannels(){} // RVA: 0x7FFD53C492B0
        public void ovr_NetSync_SetVoipStreamMode(){} // RVA: 0x7FFD53C49430
        public void ovr_Notification_GetRoomInvites(){} // RVA: 0x7FFD53C494D0
        public void ovr_Notification_MarkAsRead(){} // RVA: 0x7FFD53C49540
        public void ovr_Party_Create(){} // RVA: 0x7FFD53C495C0
        public void ovr_Party_GatherInApplication(){} // RVA: 0x7FFD53C49630
        public void ovr_Party_Get(){} // RVA: 0x7FFD53C496C0
        public void ovr_Party_GetCurrent(){} // RVA: 0x7FFD53C49740
        public void ovr_Party_GetCurrentForUser(){} // RVA: 0x7FFD53C497B0
        public void ovr_Party_Invite(){} // RVA: 0x7FFD53C49830
        public void ovr_Party_Join(){} // RVA: 0x7FFD53C498C0
        public void ovr_Party_Leave(){} // RVA: 0x7FFD53C49940
        public void ovr_RichPresence_Clear(){} // RVA: 0x7FFD53C499C0
        public void ovr_RichPresence_GetDestinations(){} // RVA: 0x7FFD53C49A30
        public void ovr_RichPresence_Set(){} // RVA: 0x7FFD53C49AA0
        public void ovr_RichPresence_SetDestination(){} // RVA: 0x7FFD53C49B20
        public void ovr_RichPresence_SetDestination_Native(){} // RVA: 0x7FFD53C49C20
        public void ovr_RichPresence_SetIsJoinable(){} // RVA: 0x7FFD53C49CA0
        public void ovr_RichPresence_SetLobbySession(){} // RVA: 0x7FFD53C49D20
        public void ovr_RichPresence_SetLobbySession_Native(){} // RVA: 0x7FFD53C49E20
        public void ovr_RichPresence_SetMatchSession(){} // RVA: 0x7FFD53C49EA0
        public void ovr_RichPresence_SetMatchSession_Native(){} // RVA: 0x7FFD53C49FA0
        public void ovr_Room_CreateAndJoinPrivate(){} // RVA: 0x7FFD53C4A020
        public void ovr_Room_CreateAndJoinPrivate2(){} // RVA: 0x7FFD53C4A0B0
        public void ovr_Room_Get(){} // RVA: 0x7FFD53C4A140
        public void ovr_Room_GetCurrent(){} // RVA: 0x7FFD53C4A1C0
        public void ovr_Room_GetCurrentForUser(){} // RVA: 0x7FFD53C4A230
        public void ovr_Room_GetInvitableUsers(){} // RVA: 0x7FFD53C4A2B0
        public void ovr_Room_GetInvitableUsers2(){} // RVA: 0x7FFD53C4A320
        public void ovr_Room_GetModeratedRooms(){} // RVA: 0x7FFD53C4A3A0
        public void ovr_Room_GetSocialRooms(){} // RVA: 0x7FFD53C4A410
        public void ovr_Room_InviteUser(){} // RVA: 0x7FFD53C4A490
        public void ovr_Room_InviteUser_Native(){} // RVA: 0x7FFD53C4A590
        public void ovr_Room_Join(){} // RVA: 0x7FFD53C4A620
        public void ovr_Room_Join2(){} // RVA: 0x7FFD53C4A6B0
        public void ovr_Room_KickUser(){} // RVA: 0x7FFD53C4A740
        public void ovr_Room_LaunchInvitableUserFlow(){} // RVA: 0x7FFD53C4A7E0
        public void ovr_Room_Leave(){} // RVA: 0x7FFD53C4A860
        public void ovr_Room_SetDescription(){} // RVA: 0x7FFD53C4A8E0
        public void ovr_Room_SetDescription_Native(){} // RVA: 0x7FFD53C4A9E0
        public void ovr_Room_UpdateDataStore(){} // RVA: 0x7FFD53C4AA70
        public void ovr_Room_UpdateDataStore_Native(){} // RVA: 0x7FFD53C4AC80
        public void ovr_Room_UpdateMembershipLockStatus(){} // RVA: 0x7FFD53C4AE70
        public void ovr_Room_UpdateOwner(){} // RVA: 0x7FFD53C4AF00
        public void ovr_Room_UpdatePrivateRoomJoinPolicy(){} // RVA: 0x7FFD53C4AF90
        public void ovr_User_CancelRecordingForReportFlow(){} // RVA: 0x7FFD53C4B020
        public void ovr_User_CancelRecordingForReportFlow_Native(){} // RVA: 0x7FFD53C4B120
        public void ovr_User_Get(){} // RVA: 0x7FFD53C4B1A0
        public void ovr_User_GetAccessToken(){} // RVA: 0x7FFD53C4B220
        public void ovr_User_GetBlockedUsers(){} // RVA: 0x7FFD53C4B290
        public void ovr_User_GetLinkedAccounts(){} // RVA: 0x7FFD53C4B300
        public void ovr_User_GetLoggedInUser(){} // RVA: 0x7FFD53C4B380
        public void ovr_User_GetLoggedInUserFriends(){} // RVA: 0x7FFD53C4B3F0
        public void ovr_User_GetLoggedInUserFriendsAndRooms(){} // RVA: 0x7FFD53C4B460
        public void ovr_User_GetLoggedInUserRecentlyMetUsersAndRooms(){} // RVA: 0x7FFD53C4B4D0
        public void ovr_User_GetOrgScopedID(){} // RVA: 0x7FFD53C4B550
        public void ovr_User_GetSdkAccounts(){} // RVA: 0x7FFD53C4B5D0
        public void ovr_User_GetUserCapabilities(){} // RVA: 0x7FFD53C4B640
        public void ovr_User_GetUserProof(){} // RVA: 0x7FFD53C4B6B0
        public void ovr_User_LaunchBlockFlow(){} // RVA: 0x7FFD53C4B720
        public void ovr_User_LaunchFriendRequestFlow(){} // RVA: 0x7FFD53C4B7A0
        public void ovr_User_LaunchProfile(){} // RVA: 0x7FFD53C4B820
        public void ovr_User_LaunchReportFlow(){} // RVA: 0x7FFD53C4B8A0
        public void ovr_User_LaunchReportFlow2(){} // RVA: 0x7FFD53C4B920
        public void ovr_User_LaunchUnblockFlow(){} // RVA: 0x7FFD53C4B9B0
        public void ovr_User_NewEntitledTestUser(){} // RVA: 0x7FFD53C4BA30
        public void ovr_User_NewTestUser(){} // RVA: 0x7FFD53C4BAA0
        public void ovr_User_NewTestUserFriends(){} // RVA: 0x7FFD53C4BB10
        public void ovr_User_StartRecordingForReportFlow(){} // RVA: 0x7FFD53C4BB80
        public void ovr_User_StopRecordingAndLaunchReportFlow(){} // RVA: 0x7FFD53C4BBF0
        public void ovr_User_StopRecordingAndLaunchReportFlow_Native(){} // RVA: 0x7FFD53C4BCF0
        public void ovr_User_StopRecordingAndLaunchReportFlow2(){} // RVA: 0x7FFD53C4BD80
        public void ovr_User_StopRecordingAndLaunchReportFlow2_Native(){} // RVA: 0x7FFD53C4BE90
        public void ovr_User_TestUserCreateDeviceManifest(){} // RVA: 0x7FFD53C4BF30
        public void ovr_User_TestUserCreateDeviceManifest_Native(){} // RVA: 0x7FFD53C4C050
        public void ovr_UserDataStore_PrivateDeleteEntryByKey(){} // RVA: 0x7FFD53C4C0F0
        public void ovr_UserDataStore_PrivateDeleteEntryByKey_Native(){} // RVA: 0x7FFD53C4C1F0
        public void ovr_UserDataStore_PrivateGetEntries(){} // RVA: 0x7FFD53C4C280
        public void ovr_UserDataStore_PrivateGetEntryByKey(){} // RVA: 0x7FFD53C4C300
        public void ovr_UserDataStore_PrivateGetEntryByKey_Native(){} // RVA: 0x7FFD53C4C400
        public void ovr_UserDataStore_PrivateWriteEntry(){} // RVA: 0x7FFD53C4C490
        public void ovr_UserDataStore_PrivateWriteEntry_Native(){} // RVA: 0x7FFD53C4C5C0
        public void ovr_UserDataStore_PublicDeleteEntryByKey(){} // RVA: 0x7FFD53C4C660
        public void ovr_UserDataStore_PublicDeleteEntryByKey_Native(){} // RVA: 0x7FFD53C4C760
        public void ovr_UserDataStore_PublicGetEntries(){} // RVA: 0x7FFD53C4C7F0
        public void ovr_UserDataStore_PublicGetEntryByKey(){} // RVA: 0x7FFD53C4C870
        public void ovr_UserDataStore_PublicGetEntryByKey_Native(){} // RVA: 0x7FFD53C4C970
        public void ovr_UserDataStore_PublicWriteEntry(){} // RVA: 0x7FFD53C4CA00
        public void ovr_UserDataStore_PublicWriteEntry_Native(){} // RVA: 0x7FFD53C4CB30
        public void ovr_Voip_GetMicrophoneAvailability(){} // RVA: 0x7FFD53C4CBD0
        public void ovr_Voip_ReportAppVoipSessions(){} // RVA: 0x7FFD53C4CC40
        public void ovr_Voip_SetSystemVoipSuppressed(){} // RVA: 0x7FFD53C4CCD0
        public void ovr_AbuseReportRecording_GetRecordingUuid(){} // RVA: 0x7FFD53C4CD50
        public void ovr_AbuseReportRecording_GetRecordingUuid_Native(){} // RVA: 0x7FFD53C4CE10
        public void ovr_AchievementDefinition_GetBitfieldLength(){} // RVA: 0x7FFD53C4CE90
        public void ovr_AchievementDefinition_GetName(){} // RVA: 0x7FFD53C4CF10
        public void ovr_AchievementDefinition_GetName_Native(){} // RVA: 0x7FFD53C4CFD0
        public void ovr_AchievementDefinition_GetTarget(){} // RVA: 0x7FFD53C4D050
        public void ovr_AchievementDefinition_GetType(){} // RVA: 0x7FFD53C4D0D0
        public void ovr_AchievementDefinitionArray_GetElement(){} // RVA: 0x7FFD53C4D150
        public void ovr_AchievementDefinitionArray_GetNextUrl(){} // RVA: 0x7FFD53C4D1E0
        public void ovr_AchievementDefinitionArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C4D2A0
        public void ovr_AchievementDefinitionArray_GetSize(){} // RVA: 0x7FFD53C4D320
        public void ovr_AchievementDefinitionArray_HasNextPage(){} // RVA: 0x7FFD53C4D3A0
        public void ovr_AchievementProgress_GetBitfield(){} // RVA: 0x7FFD53C4D420
        public void ovr_AchievementProgress_GetBitfield_Native(){} // RVA: 0x7FFD53C4D4E0
        public void ovr_AchievementProgress_GetCount(){} // RVA: 0x7FFD53C4D560
        public void ovr_AchievementProgress_GetIsUnlocked(){} // RVA: 0x7FFD53C4D5E0
        public void ovr_AchievementProgress_GetName(){} // RVA: 0x7FFD53C4D660
        public void ovr_AchievementProgress_GetName_Native(){} // RVA: 0x7FFD53C4D720
        public void ovr_AchievementProgress_GetUnlockTime(){} // RVA: 0x7FFD53C4D7A0
        public void ovr_AchievementProgress_GetUnlockTime_Native(){} // RVA: 0x7FFD53C4D860
        public void ovr_AchievementProgressArray_GetElement(){} // RVA: 0x7FFD53C4D8E0
        public void ovr_AchievementProgressArray_GetNextUrl(){} // RVA: 0x7FFD53C4D970
        public void ovr_AchievementProgressArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C4DA30
        public void ovr_AchievementProgressArray_GetSize(){} // RVA: 0x7FFD53C4DAB0
        public void ovr_AchievementProgressArray_HasNextPage(){} // RVA: 0x7FFD53C4DB30
        public void ovr_AchievementUpdate_GetJustUnlocked(){} // RVA: 0x7FFD53C4DBB0
        public void ovr_AchievementUpdate_GetName(){} // RVA: 0x7FFD53C4DC30
        public void ovr_AchievementUpdate_GetName_Native(){} // RVA: 0x7FFD53C4DCF0
        public void ovr_Application_GetID(){} // RVA: 0x7FFD53C4DD70
        public void ovr_ApplicationInvite_GetDestination(){} // RVA: 0x7FFD53C4DDF0
        public void ovr_ApplicationInvite_GetID(){} // RVA: 0x7FFD53C4DE70
        public void ovr_ApplicationInvite_GetIsActive(){} // RVA: 0x7FFD53C4DEF0
        public void ovr_ApplicationInvite_GetLobbySessionId(){} // RVA: 0x7FFD53C4DF70
        public void ovr_ApplicationInvite_GetLobbySessionId_Native(){} // RVA: 0x7FFD53C4E030
        public void ovr_ApplicationInvite_GetMatchSessionId(){} // RVA: 0x7FFD53C4E0B0
        public void ovr_ApplicationInvite_GetMatchSessionId_Native(){} // RVA: 0x7FFD53C4E170
        public void ovr_ApplicationInvite_GetRecipient(){} // RVA: 0x7FFD53C4E1F0
        public void ovr_ApplicationInviteArray_GetElement(){} // RVA: 0x7FFD53C4E270
        public void ovr_ApplicationInviteArray_GetNextUrl(){} // RVA: 0x7FFD53C4E300
        public void ovr_ApplicationInviteArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C4E3C0
        public void ovr_ApplicationInviteArray_GetSize(){} // RVA: 0x7FFD53C4E440
        public void ovr_ApplicationInviteArray_HasNextPage(){} // RVA: 0x7FFD53C4E4C0
        public void ovr_ApplicationVersion_GetCurrentCode(){} // RVA: 0x7FFD53C4E540
        public void ovr_ApplicationVersion_GetCurrentName(){} // RVA: 0x7FFD53C4E5C0
        public void ovr_ApplicationVersion_GetCurrentName_Native(){} // RVA: 0x7FFD53C4E680
        public void ovr_ApplicationVersion_GetLatestCode(){} // RVA: 0x7FFD53C4E700
        public void ovr_ApplicationVersion_GetLatestName(){} // RVA: 0x7FFD53C4E780
        public void ovr_ApplicationVersion_GetLatestName_Native(){} // RVA: 0x7FFD53C4E840
        public void ovr_AssetDetails_GetAssetId(){} // RVA: 0x7FFD53C4E8C0
        public void ovr_AssetDetails_GetAssetType(){} // RVA: 0x7FFD53C4E940
        public void ovr_AssetDetails_GetAssetType_Native(){} // RVA: 0x7FFD53C4EA00
        public void ovr_AssetDetails_GetDownloadStatus(){} // RVA: 0x7FFD53C4EA80
        public void ovr_AssetDetails_GetDownloadStatus_Native(){} // RVA: 0x7FFD53C4EB40
        public void ovr_AssetDetails_GetFilepath(){} // RVA: 0x7FFD53C4EBC0
        public void ovr_AssetDetails_GetFilepath_Native(){} // RVA: 0x7FFD53C4EC80
        public void ovr_AssetDetails_GetIapStatus(){} // RVA: 0x7FFD53C4ED00
        public void ovr_AssetDetails_GetIapStatus_Native(){} // RVA: 0x7FFD53C4EDC0
        public void ovr_AssetDetails_GetLanguage(){} // RVA: 0x7FFD53C4EE40
        public void ovr_AssetDetails_GetMetadata(){} // RVA: 0x7FFD53C4EEC0
        public void ovr_AssetDetails_GetMetadata_Native(){} // RVA: 0x7FFD53C4EF80
        public void ovr_AssetDetailsArray_GetElement(){} // RVA: 0x7FFD53C4F000
        public void ovr_AssetDetailsArray_GetSize(){} // RVA: 0x7FFD53C4F090
        public void ovr_AssetFileDeleteResult_GetAssetFileId(){} // RVA: 0x7FFD53C4F110
        public void ovr_AssetFileDeleteResult_GetAssetId(){} // RVA: 0x7FFD53C4F190
        public void ovr_AssetFileDeleteResult_GetFilepath(){} // RVA: 0x7FFD53C4F210
        public void ovr_AssetFileDeleteResult_GetFilepath_Native(){} // RVA: 0x7FFD53C4F2D0
        public void ovr_AssetFileDeleteResult_GetSuccess(){} // RVA: 0x7FFD53C4F350
        public void ovr_AssetFileDownloadCancelResult_GetAssetFileId(){} // RVA: 0x7FFD53C4F3D0
        public void ovr_AssetFileDownloadCancelResult_GetAssetId(){} // RVA: 0x7FFD53C4F450
        public void ovr_AssetFileDownloadCancelResult_GetFilepath(){} // RVA: 0x7FFD53C4F4D0
        public void ovr_AssetFileDownloadCancelResult_GetFilepath_Native(){} // RVA: 0x7FFD53C4F590
        public void ovr_AssetFileDownloadCancelResult_GetSuccess(){} // RVA: 0x7FFD53C4F610
        public void ovr_AssetFileDownloadResult_GetAssetId(){} // RVA: 0x7FFD53C4F690
        public void ovr_AssetFileDownloadResult_GetFilepath(){} // RVA: 0x7FFD53C4F710
        public void ovr_AssetFileDownloadResult_GetFilepath_Native(){} // RVA: 0x7FFD53C4F7D0
        public void ovr_AssetFileDownloadUpdate_GetAssetFileId(){} // RVA: 0x7FFD53C4F850
        public void ovr_AssetFileDownloadUpdate_GetAssetId(){} // RVA: 0x7FFD53C4F8D0
        public void ovr_AssetFileDownloadUpdate_GetBytesTotal(){} // RVA: 0x7FFD53C4F950
        public void ovr_AssetFileDownloadUpdate_GetBytesTotalLong(){} // RVA: 0x7FFD53C4F9D0
        public void ovr_AssetFileDownloadUpdate_GetBytesTransferred(){} // RVA: 0x7FFD53C4FA50
        public void ovr_AssetFileDownloadUpdate_GetBytesTransferredLong(){} // RVA: 0x7FFD53C4FAD0
        public void ovr_AssetFileDownloadUpdate_GetCompleted(){} // RVA: 0x7FFD53C4FB50
        public void ovr_AvatarEditorResult_GetRequestSent(){} // RVA: 0x7FFD53C4FBD0
        public void ovr_BlockedUser_GetId(){} // RVA: 0x7FFD53C4FC50
        public void ovr_BlockedUserArray_GetElement(){} // RVA: 0x7FFD53C4FCD0
        public void ovr_BlockedUserArray_GetNextUrl(){} // RVA: 0x7FFD53C4FD60
        public void ovr_BlockedUserArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C4FE20
        public void ovr_BlockedUserArray_GetSize(){} // RVA: 0x7FFD53C4FEA0
        public void ovr_BlockedUserArray_HasNextPage(){} // RVA: 0x7FFD53C4FF20
        public void ovr_CalApplicationFinalized_GetCountdownMS(){} // RVA: 0x7FFD53C4FFA0
        public void ovr_CalApplicationFinalized_GetID(){} // RVA: 0x7FFD53C50020
        public void ovr_CalApplicationFinalized_GetLaunchDetails(){} // RVA: 0x7FFD53C500A0
        public void ovr_CalApplicationFinalized_GetLaunchDetails_Native(){} // RVA: 0x7FFD53C50160
        public void ovr_CalApplicationProposed_GetID(){} // RVA: 0x7FFD53C501E0
        public void ovr_CalApplicationSuggestion_GetID(){} // RVA: 0x7FFD53C50260
        public void ovr_CalApplicationSuggestion_GetSocialContext(){} // RVA: 0x7FFD53C502E0
        public void ovr_CalApplicationSuggestion_GetSocialContext_Native(){} // RVA: 0x7FFD53C503A0
        public void ovr_CalApplicationSuggestionArray_GetElement(){} // RVA: 0x7FFD53C50420
        public void ovr_CalApplicationSuggestionArray_GetSize(){} // RVA: 0x7FFD53C504B0
        public void ovr_Challenge_GetCreationType(){} // RVA: 0x7FFD53C50530
        public void ovr_Challenge_GetDescription(){} // RVA: 0x7FFD53C505B0
        public void ovr_Challenge_GetDescription_Native(){} // RVA: 0x7FFD53C50670
        public void ovr_Challenge_GetEndDate(){} // RVA: 0x7FFD53C506F0
        public void ovr_Challenge_GetEndDate_Native(){} // RVA: 0x7FFD53C507B0
        public void ovr_Challenge_GetID(){} // RVA: 0x7FFD53C50830
        public void ovr_Challenge_GetInvitedUsers(){} // RVA: 0x7FFD53C508B0
        public void ovr_Challenge_GetLeaderboard(){} // RVA: 0x7FFD53C50930
        public void ovr_Challenge_GetParticipants(){} // RVA: 0x7FFD53C509B0
        public void ovr_Challenge_GetStartDate(){} // RVA: 0x7FFD53C50A30
        public void ovr_Challenge_GetStartDate_Native(){} // RVA: 0x7FFD53C50AF0
        public void ovr_Challenge_GetTitle(){} // RVA: 0x7FFD53C50B70
        public void ovr_Challenge_GetTitle_Native(){} // RVA: 0x7FFD53C50C30
        public void ovr_Challenge_GetVisibility(){} // RVA: 0x7FFD53C50CB0
        public void ovr_ChallengeArray_GetElement(){} // RVA: 0x7FFD53C50D30
        public void ovr_ChallengeArray_GetNextUrl(){} // RVA: 0x7FFD53C50DC0
        public void ovr_ChallengeArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C50E80
        public void ovr_ChallengeArray_GetPreviousUrl(){} // RVA: 0x7FFD53C50F00
        public void ovr_ChallengeArray_GetPreviousUrl_Native(){} // RVA: 0x7FFD53C50FC0
        public void ovr_ChallengeArray_GetSize(){} // RVA: 0x7FFD53C51040
        public void ovr_ChallengeArray_GetTotalCount(){} // RVA: 0x7FFD53C510C0
        public void ovr_ChallengeArray_HasNextPage(){} // RVA: 0x7FFD53C51140
        public void ovr_ChallengeArray_HasPreviousPage(){} // RVA: 0x7FFD53C511C0
        public void ovr_ChallengeEntry_GetDisplayScore(){} // RVA: 0x7FFD53C51240
        public void ovr_ChallengeEntry_GetDisplayScore_Native(){} // RVA: 0x7FFD53C51300
        public void ovr_ChallengeEntry_GetExtraData(){} // RVA: 0x7FFD53C51380
        public void ovr_ChallengeEntry_GetExtraData_Native(){} // RVA: 0x7FFD53C51450
        public void ovr_ChallengeEntry_GetExtraDataLength(){} // RVA: 0x7FFD53C514D0
        public void ovr_ChallengeEntry_GetID(){} // RVA: 0x7FFD53C51550
        public void ovr_ChallengeEntry_GetRank(){} // RVA: 0x7FFD53C515D0
        public void ovr_ChallengeEntry_GetScore(){} // RVA: 0x7FFD53C51650
        public void ovr_ChallengeEntry_GetTimestamp(){} // RVA: 0x7FFD53C516D0
        public void ovr_ChallengeEntry_GetTimestamp_Native(){} // RVA: 0x7FFD53C51790
        public void ovr_ChallengeEntry_GetUser(){} // RVA: 0x7FFD53C51810
        public void ovr_ChallengeEntryArray_GetElement(){} // RVA: 0x7FFD53C51890
        public void ovr_ChallengeEntryArray_GetNextUrl(){} // RVA: 0x7FFD53C51920
        public void ovr_ChallengeEntryArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C519E0
        public void ovr_ChallengeEntryArray_GetPreviousUrl(){} // RVA: 0x7FFD53C51A60
        public void ovr_ChallengeEntryArray_GetPreviousUrl_Native(){} // RVA: 0x7FFD53C51B20
        public void ovr_ChallengeEntryArray_GetSize(){} // RVA: 0x7FFD53C51BA0
        public void ovr_ChallengeEntryArray_GetTotalCount(){} // RVA: 0x7FFD53C51C20
        public void ovr_ChallengeEntryArray_HasNextPage(){} // RVA: 0x7FFD53C51CA0
        public void ovr_ChallengeEntryArray_HasPreviousPage(){} // RVA: 0x7FFD53C51D20
        public void ovr_CloudStorage2UserDirectoryPathResponse_GetPath(){} // RVA: 0x7FFD53C51DA0
        public void ovr_CloudStorage2UserDirectoryPathResponse_GetPath_Native(){} // RVA: 0x7FFD53C51E60
        public void ovr_CloudStorageConflictMetadata_GetLocal(){} // RVA: 0x7FFD53C51EE0
        public void ovr_CloudStorageConflictMetadata_GetRemote(){} // RVA: 0x7FFD53C51F60
        public void ovr_CloudStorageData_GetBucket(){} // RVA: 0x7FFD53C51FE0
        public void ovr_CloudStorageData_GetBucket_Native(){} // RVA: 0x7FFD53C520A0
        public void ovr_CloudStorageData_GetData(){} // RVA: 0x7FFD53C52120
        public void ovr_CloudStorageData_GetData_Native(){} // RVA: 0x7FFD53C52270
        public void ovr_CloudStorageData_GetDataSize(){} // RVA: 0x7FFD53C522F0
        public void ovr_CloudStorageData_GetKey(){} // RVA: 0x7FFD53C52370
        public void ovr_CloudStorageData_GetKey_Native(){} // RVA: 0x7FFD53C52430
        public void ovr_CloudStorageMetadata_GetBucket(){} // RVA: 0x7FFD53C524B0
        public void ovr_CloudStorageMetadata_GetBucket_Native(){} // RVA: 0x7FFD53C52570
        public void ovr_CloudStorageMetadata_GetCounter(){} // RVA: 0x7FFD53C525F0
        public void ovr_CloudStorageMetadata_GetDataSize(){} // RVA: 0x7FFD53C52670
        public void ovr_CloudStorageMetadata_GetExtraData(){} // RVA: 0x7FFD53C526F0
        public void ovr_CloudStorageMetadata_GetExtraData_Native(){} // RVA: 0x7FFD53C527B0
        public void ovr_CloudStorageMetadata_GetKey(){} // RVA: 0x7FFD53C52830
        public void ovr_CloudStorageMetadata_GetKey_Native(){} // RVA: 0x7FFD53C528F0
        public void ovr_CloudStorageMetadata_GetSaveTime(){} // RVA: 0x7FFD53C52970
        public void ovr_CloudStorageMetadata_GetStatus(){} // RVA: 0x7FFD53C529F0
        public void ovr_CloudStorageMetadata_GetVersionHandle(){} // RVA: 0x7FFD53C52A70
        public void ovr_CloudStorageMetadata_GetVersionHandle_Native(){} // RVA: 0x7FFD53C52B30
        public void ovr_CloudStorageMetadataArray_GetElement(){} // RVA: 0x7FFD53C52BB0
        public void ovr_CloudStorageMetadataArray_GetNextUrl(){} // RVA: 0x7FFD53C52C40
        public void ovr_CloudStorageMetadataArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C52D00
        public void ovr_CloudStorageMetadataArray_GetSize(){} // RVA: 0x7FFD53C52D80
        public void ovr_CloudStorageMetadataArray_HasNextPage(){} // RVA: 0x7FFD53C52E00
        public void ovr_CloudStorageUpdateResponse_GetBucket(){} // RVA: 0x7FFD53C52E80
        public void ovr_CloudStorageUpdateResponse_GetBucket_Native(){} // RVA: 0x7FFD53C52F40
        public void ovr_CloudStorageUpdateResponse_GetKey(){} // RVA: 0x7FFD53C52FC0
        public void ovr_CloudStorageUpdateResponse_GetKey_Native(){} // RVA: 0x7FFD53C53080
        public void ovr_CloudStorageUpdateResponse_GetStatus(){} // RVA: 0x7FFD53C53100
        public void ovr_CloudStorageUpdateResponse_GetVersionHandle(){} // RVA: 0x7FFD53C53180
        public void ovr_CloudStorageUpdateResponse_GetVersionHandle_Native(){} // RVA: 0x7FFD53C53240
        public void ovr_DataStore_Contains(){} // RVA: 0x7FFD53C532C0
        public void ovr_DataStore_Contains_Native(){} // RVA: 0x7FFD53C533C0
        public void ovr_DataStore_GetKey(){} // RVA: 0x7FFD53C53450
        public void ovr_DataStore_GetKey_Native(){} // RVA: 0x7FFD53C53520
        public void ovr_DataStore_GetNumKeys(){} // RVA: 0x7FFD53C535B0
        public void ovr_DataStore_GetValue(){} // RVA: 0x7FFD53C53630
        public void ovr_DataStore_GetValue_Native(){} // RVA: 0x7FFD53C53740
        public void ovr_Destination_GetApiName(){} // RVA: 0x7FFD53C537D0
        public void ovr_Destination_GetApiName_Native(){} // RVA: 0x7FFD53C53890
        public void ovr_Destination_GetDeeplinkMessage(){} // RVA: 0x7FFD53C53910
        public void ovr_Destination_GetDeeplinkMessage_Native(){} // RVA: 0x7FFD53C539D0
        public void ovr_Destination_GetDisplayName(){} // RVA: 0x7FFD53C53A50
        public void ovr_Destination_GetDisplayName_Native(){} // RVA: 0x7FFD53C53B10
        public void ovr_DestinationArray_GetElement(){} // RVA: 0x7FFD53C53B90
        public void ovr_DestinationArray_GetNextUrl(){} // RVA: 0x7FFD53C53C20
        public void ovr_DestinationArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C53CE0
        public void ovr_DestinationArray_GetSize(){} // RVA: 0x7FFD53C53D60
        public void ovr_DestinationArray_HasNextPage(){} // RVA: 0x7FFD53C53DE0
        public void ovr_Error_GetCode(){} // RVA: 0x7FFD53C53E60
        public void ovr_Error_GetDisplayableMessage(){} // RVA: 0x7FFD53C53EE0
        public void ovr_Error_GetDisplayableMessage_Native(){} // RVA: 0x7FFD53C53FA0
        public void ovr_Error_GetHttpCode(){} // RVA: 0x7FFD53C54020
        public void ovr_Error_GetMessage(){} // RVA: 0x7FFD53C540A0
        public void ovr_Error_GetMessage_Native(){} // RVA: 0x7FFD53C54160
        public void ovr_GroupPresenceJoinIntent_GetDeeplinkMessage(){} // RVA: 0x7FFD53C541E0
        public void ovr_GroupPresenceJoinIntent_GetDeeplinkMessage_Native(){} // RVA: 0x7FFD53C542A0
        public void ovr_GroupPresenceJoinIntent_GetDestinationApiName(){} // RVA: 0x7FFD53C54320
        public void ovr_GroupPresenceJoinIntent_GetDestinationApiName_Native(){} // RVA: 0x7FFD53C543E0
        public void ovr_GroupPresenceJoinIntent_GetLobbySessionId(){} // RVA: 0x7FFD53C54460
        public void ovr_GroupPresenceJoinIntent_GetLobbySessionId_Native(){} // RVA: 0x7FFD53C54520
        public void ovr_GroupPresenceJoinIntent_GetMatchSessionId(){} // RVA: 0x7FFD53C545A0
        public void ovr_GroupPresenceJoinIntent_GetMatchSessionId_Native(){} // RVA: 0x7FFD53C54660
        public void ovr_GroupPresenceLeaveIntent_GetDestinationApiName(){} // RVA: 0x7FFD53C546E0
        public void ovr_GroupPresenceLeaveIntent_GetDestinationApiName_Native(){} // RVA: 0x7FFD53C547A0
        public void ovr_GroupPresenceLeaveIntent_GetLobbySessionId(){} // RVA: 0x7FFD53C54820
        public void ovr_GroupPresenceLeaveIntent_GetLobbySessionId_Native(){} // RVA: 0x7FFD53C548E0
        public void ovr_GroupPresenceLeaveIntent_GetMatchSessionId(){} // RVA: 0x7FFD53C54960
        public void ovr_GroupPresenceLeaveIntent_GetMatchSessionId_Native(){} // RVA: 0x7FFD53C54A20
        public void ovr_HttpTransferUpdate_GetBytes(){} // RVA: 0x7FFD53C54AA0
        public void ovr_HttpTransferUpdate_GetID(){} // RVA: 0x7FFD53C54B20
        public void ovr_HttpTransferUpdate_GetSize(){} // RVA: 0x7FFD53C54BA0
        public void ovr_HttpTransferUpdate_IsCompleted(){} // RVA: 0x7FFD53C54C20
        public void ovr_InstalledApplication_GetApplicationId(){} // RVA: 0x7FFD53C54CA0
        public void ovr_InstalledApplication_GetApplicationId_Native(){} // RVA: 0x7FFD53C54D60
        public void ovr_InstalledApplication_GetPackageName(){} // RVA: 0x7FFD53C54DE0
        public void ovr_InstalledApplication_GetPackageName_Native(){} // RVA: 0x7FFD53C54EA0
        public void ovr_InstalledApplication_GetStatus(){} // RVA: 0x7FFD53C54F20
        public void ovr_InstalledApplication_GetStatus_Native(){} // RVA: 0x7FFD53C54FE0
        public void ovr_InstalledApplication_GetVersionCode(){} // RVA: 0x7FFD53C55060
        public void ovr_InstalledApplication_GetVersionName(){} // RVA: 0x7FFD53C550E0
        public void ovr_InstalledApplication_GetVersionName_Native(){} // RVA: 0x7FFD53C551A0
        public void ovr_InstalledApplicationArray_GetElement(){} // RVA: 0x7FFD53C55220
        public void ovr_InstalledApplicationArray_GetSize(){} // RVA: 0x7FFD53C552B0
        public void ovr_InvitePanelResultInfo_GetInvitesSent(){} // RVA: 0x7FFD53C55330
        public void ovr_LanguagePackInfo_GetEnglishName(){} // RVA: 0x7FFD53C553B0
        public void ovr_LanguagePackInfo_GetEnglishName_Native(){} // RVA: 0x7FFD53C55470
        public void ovr_LanguagePackInfo_GetNativeName(){} // RVA: 0x7FFD53C554F0
        public void ovr_LanguagePackInfo_GetNativeName_Native(){} // RVA: 0x7FFD53C555B0
        public void ovr_LanguagePackInfo_GetTag(){} // RVA: 0x7FFD53C55630
        public void ovr_LanguagePackInfo_GetTag_Native(){} // RVA: 0x7FFD53C556F0
        public void ovr_LaunchBlockFlowResult_GetDidBlock(){} // RVA: 0x7FFD53C55770
        public void ovr_LaunchBlockFlowResult_GetDidCancel(){} // RVA: 0x7FFD53C557F0
        public void ovr_LaunchDetails_GetDeeplinkMessage(){} // RVA: 0x7FFD53C55870
        public void ovr_LaunchDetails_GetDeeplinkMessage_Native(){} // RVA: 0x7FFD53C55930
        public void ovr_LaunchDetails_GetDestinationApiName(){} // RVA: 0x7FFD53C559B0
        public void ovr_LaunchDetails_GetDestinationApiName_Native(){} // RVA: 0x7FFD53C55A70
        public void ovr_LaunchDetails_GetLaunchSource(){} // RVA: 0x7FFD53C55AF0
        public void ovr_LaunchDetails_GetLaunchSource_Native(){} // RVA: 0x7FFD53C55BB0
        public void ovr_LaunchDetails_GetLaunchType(){} // RVA: 0x7FFD53C55C30
        public void ovr_LaunchDetails_GetRoomID(){} // RVA: 0x7FFD53C55CB0
        public void ovr_LaunchDetails_GetTrackingID(){} // RVA: 0x7FFD53C55D30
        public void ovr_LaunchDetails_GetTrackingID_Native(){} // RVA: 0x7FFD53C55DF0
        public void ovr_LaunchDetails_GetUsers(){} // RVA: 0x7FFD53C55E70
        public void ovr_LaunchFriendRequestFlowResult_GetDidCancel(){} // RVA: 0x7FFD53C55EF0
        public void ovr_LaunchFriendRequestFlowResult_GetDidSendRequest(){} // RVA: 0x7FFD53C55F70
        public void ovr_LaunchInvitePanelFlowResult_GetInvitedUsers(){} // RVA: 0x7FFD53C55FF0
        public void ovr_LaunchReportFlowResult_GetDidCancel(){} // RVA: 0x7FFD53C56070
        public void ovr_LaunchReportFlowResult_GetUserReportId(){} // RVA: 0x7FFD53C560F0
        public void ovr_LaunchUnblockFlowResult_GetDidCancel(){} // RVA: 0x7FFD53C56170
        public void ovr_LaunchUnblockFlowResult_GetDidUnblock(){} // RVA: 0x7FFD53C561F0
        public void ovr_Leaderboard_GetApiName(){} // RVA: 0x7FFD53C56270
        public void ovr_Leaderboard_GetApiName_Native(){} // RVA: 0x7FFD53C56330
        public void ovr_Leaderboard_GetDestination(){} // RVA: 0x7FFD53C563B0
        public void ovr_Leaderboard_GetID(){} // RVA: 0x7FFD53C56430
        public void ovr_LeaderboardArray_GetElement(){} // RVA: 0x7FFD53C564B0
        public void ovr_LeaderboardArray_GetNextUrl(){} // RVA: 0x7FFD53C56540
        public void ovr_LeaderboardArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C56600
        public void ovr_LeaderboardArray_GetSize(){} // RVA: 0x7FFD53C56680
        public void ovr_LeaderboardArray_HasNextPage(){} // RVA: 0x7FFD53C56700
        public void ovr_LeaderboardEntry_GetDisplayScore(){} // RVA: 0x7FFD53C56780
        public void ovr_LeaderboardEntry_GetDisplayScore_Native(){} // RVA: 0x7FFD53C56840
        public void ovr_LeaderboardEntry_GetExtraData(){} // RVA: 0x7FFD53C568C0
        public void ovr_LeaderboardEntry_GetExtraData_Native(){} // RVA: 0x7FFD53C56990
        public void ovr_LeaderboardEntry_GetExtraDataLength(){} // RVA: 0x7FFD53C56A10
        public void ovr_LeaderboardEntry_GetID(){} // RVA: 0x7FFD53C56A90
        public void ovr_LeaderboardEntry_GetRank(){} // RVA: 0x7FFD53C56B10
        public void ovr_LeaderboardEntry_GetScore(){} // RVA: 0x7FFD53C56B90
        public void ovr_LeaderboardEntry_GetSupplementaryMetric(){} // RVA: 0x7FFD53C56C10
        public void ovr_LeaderboardEntry_GetTimestamp(){} // RVA: 0x7FFD53C56C90
        public void ovr_LeaderboardEntry_GetTimestamp_Native(){} // RVA: 0x7FFD53C56D50
        public void ovr_LeaderboardEntry_GetUser(){} // RVA: 0x7FFD53C56DD0
        public void ovr_LeaderboardEntryArray_GetElement(){} // RVA: 0x7FFD53C56E50
        public void ovr_LeaderboardEntryArray_GetNextUrl(){} // RVA: 0x7FFD53C56EE0
        public void ovr_LeaderboardEntryArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C56FA0
        public void ovr_LeaderboardEntryArray_GetPreviousUrl(){} // RVA: 0x7FFD53C57020
        public void ovr_LeaderboardEntryArray_GetPreviousUrl_Native(){} // RVA: 0x7FFD53C570E0
        public void ovr_LeaderboardEntryArray_GetSize(){} // RVA: 0x7FFD53C57160
        public void ovr_LeaderboardEntryArray_GetTotalCount(){} // RVA: 0x7FFD53C571E0
        public void ovr_LeaderboardEntryArray_HasNextPage(){} // RVA: 0x7FFD53C57260
        public void ovr_LeaderboardEntryArray_HasPreviousPage(){} // RVA: 0x7FFD53C572E0
        public void ovr_LeaderboardUpdateStatus_GetDidUpdate(){} // RVA: 0x7FFD53C57360
        public void ovr_LeaderboardUpdateStatus_GetUpdatedChallengeId(){} // RVA: 0x7FFD53C573E0
        public void ovr_LeaderboardUpdateStatus_GetUpdatedChallengeIdsSize(){} // RVA: 0x7FFD53C57470
        public void ovr_LinkedAccount_GetAccessToken(){} // RVA: 0x7FFD53C574F0
        public void ovr_LinkedAccount_GetAccessToken_Native(){} // RVA: 0x7FFD53C575B0
        public void ovr_LinkedAccount_GetServiceProvider(){} // RVA: 0x7FFD53C57630
        public void ovr_LinkedAccount_GetUserId(){} // RVA: 0x7FFD53C576B0
        public void ovr_LinkedAccount_GetUserId_Native(){} // RVA: 0x7FFD53C57770
        public void ovr_LinkedAccountArray_GetElement(){} // RVA: 0x7FFD53C577F0
        public void ovr_LinkedAccountArray_GetSize(){} // RVA: 0x7FFD53C57880
        public void ovr_LivestreamingApplicationStatus_GetStreamingEnabled(){} // RVA: 0x7FFD53C57900
        public void ovr_LivestreamingStartResult_GetStreamingResult(){} // RVA: 0x7FFD53C57980
        public void ovr_LivestreamingStatus_GetCommentsVisible(){} // RVA: 0x7FFD53C57A00
        public void ovr_LivestreamingStatus_GetIsPaused(){} // RVA: 0x7FFD53C57A80
        public void ovr_LivestreamingStatus_GetLivestreamingEnabled(){} // RVA: 0x7FFD53C57B00
        public void ovr_LivestreamingStatus_GetLivestreamingType(){} // RVA: 0x7FFD53C57B80
        public void ovr_LivestreamingStatus_GetMicEnabled(){} // RVA: 0x7FFD53C57C00
        public void ovr_LivestreamingVideoStats_GetCommentCount(){} // RVA: 0x7FFD53C57C80
        public void ovr_LivestreamingVideoStats_GetReactionCount(){} // RVA: 0x7FFD53C57D00
        public void ovr_LivestreamingVideoStats_GetTotalViews(){} // RVA: 0x7FFD53C57D80
        public void ovr_LivestreamingVideoStats_GetTotalViews_Native(){} // RVA: 0x7FFD53C57E40
        public void ovr_MatchmakingAdminSnapshot_GetCandidates(){} // RVA: 0x7FFD53C57EC0
        public void ovr_MatchmakingAdminSnapshot_GetMyCurrentThreshold(){} // RVA: 0x7FFD53C57F40
        public void ovr_MatchmakingAdminSnapshotCandidate_GetCanMatch(){} // RVA: 0x7FFD53C57FC0
        public void ovr_MatchmakingAdminSnapshotCandidate_GetMyTotalScore(){} // RVA: 0x7FFD53C58040
        public void ovr_MatchmakingAdminSnapshotCandidate_GetTheirCurrentThreshold(){} // RVA: 0x7FFD53C580C0
        public void ovr_MatchmakingAdminSnapshotCandidate_GetTheirTotalScore(){} // RVA: 0x7FFD53C58140
        public void ovr_MatchmakingAdminSnapshotCandidate_GetTraceId(){} // RVA: 0x7FFD53C581C0
        public void ovr_MatchmakingAdminSnapshotCandidate_GetTraceId_Native(){} // RVA: 0x7FFD53C58280
        public void ovr_MatchmakingAdminSnapshotCandidateArray_GetElement(){} // RVA: 0x7FFD53C58300
        public void ovr_MatchmakingAdminSnapshotCandidateArray_GetSize(){} // RVA: 0x7FFD53C58390
        public void ovr_MatchmakingBrowseResult_GetEnqueueResult(){} // RVA: 0x7FFD53C58410
        public void ovr_MatchmakingBrowseResult_GetRooms(){} // RVA: 0x7FFD53C58490
        public void ovr_MatchmakingCandidate_GetEntryHash(){} // RVA: 0x7FFD53C58510
        public void ovr_MatchmakingCandidate_GetEntryHash_Native(){} // RVA: 0x7FFD53C585D0
        public void ovr_MatchmakingCandidate_GetUserId(){} // RVA: 0x7FFD53C58650
        public void ovr_MatchmakingCandidateArray_GetElement(){} // RVA: 0x7FFD53C586D0
        public void ovr_MatchmakingCandidateArray_GetNextUrl(){} // RVA: 0x7FFD53C58760
        public void ovr_MatchmakingCandidateArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C58820
        public void ovr_MatchmakingCandidateArray_GetSize(){} // RVA: 0x7FFD53C588A0
        public void ovr_MatchmakingCandidateArray_HasNextPage(){} // RVA: 0x7FFD53C58920
        public void ovr_MatchmakingEnqueueResult_GetAdminSnapshot(){} // RVA: 0x7FFD53C589A0
        public void ovr_MatchmakingEnqueueResult_GetAverageWait(){} // RVA: 0x7FFD53C58A20
        public void ovr_MatchmakingEnqueueResult_GetMatchesInLastHourCount(){} // RVA: 0x7FFD53C58AA0
        public void ovr_MatchmakingEnqueueResult_GetMaxExpectedWait(){} // RVA: 0x7FFD53C58B20
        public void ovr_MatchmakingEnqueueResult_GetPool(){} // RVA: 0x7FFD53C58BA0
        public void ovr_MatchmakingEnqueueResult_GetPool_Native(){} // RVA: 0x7FFD53C58C60
        public void ovr_MatchmakingEnqueueResult_GetRecentMatchPercentage(){} // RVA: 0x7FFD53C58CE0
        public void ovr_MatchmakingEnqueueResult_GetRequestHash(){} // RVA: 0x7FFD53C58D60
        public void ovr_MatchmakingEnqueueResult_GetRequestHash_Native(){} // RVA: 0x7FFD53C58E20
        public void ovr_MatchmakingEnqueueResultAndRoom_GetMatchmakingEnqueueResult(){} // RVA: 0x7FFD53C58EA0
        public void ovr_MatchmakingEnqueueResultAndRoom_GetRoom(){} // RVA: 0x7FFD53C58F20
        public void ovr_MatchmakingEnqueuedUser_GetAdditionalUserID(){} // RVA: 0x7FFD53C58FA0
        public void ovr_MatchmakingEnqueuedUser_GetAdditionalUserIDsSize(){} // RVA: 0x7FFD53C59030
        public void ovr_MatchmakingEnqueuedUser_GetCustomData(){} // RVA: 0x7FFD53C590B0
        public void ovr_MatchmakingEnqueuedUser_GetUser(){} // RVA: 0x7FFD53C59130
        public void ovr_MatchmakingEnqueuedUserArray_GetElement(){} // RVA: 0x7FFD53C591B0
        public void ovr_MatchmakingEnqueuedUserArray_GetSize(){} // RVA: 0x7FFD53C59240
        public void ovr_MatchmakingNotification_GetAddedByUserId(){} // RVA: 0x7FFD53C592C0
        public void ovr_MatchmakingNotification_GetRoom(){} // RVA: 0x7FFD53C59340
        public void ovr_MatchmakingNotification_GetTraceId(){} // RVA: 0x7FFD53C593C0
        public void ovr_MatchmakingNotification_GetTraceId_Native(){} // RVA: 0x7FFD53C59480
        public void ovr_MatchmakingRoom_GetPingTime(){} // RVA: 0x7FFD53C59500
        public void ovr_MatchmakingRoom_GetRoom(){} // RVA: 0x7FFD53C59580
        public void ovr_MatchmakingRoom_HasPingTime(){} // RVA: 0x7FFD53C59600
        public void ovr_MatchmakingRoomArray_GetElement(){} // RVA: 0x7FFD53C59680
        public void ovr_MatchmakingRoomArray_GetSize(){} // RVA: 0x7FFD53C59710
        public void ovr_MatchmakingStats_GetDrawCount(){} // RVA: 0x7FFD53C59790
        public void ovr_MatchmakingStats_GetLossCount(){} // RVA: 0x7FFD53C59810
        public void ovr_MatchmakingStats_GetSkillLevel(){} // RVA: 0x7FFD53C59890
        public void ovr_MatchmakingStats_GetSkillMean(){} // RVA: 0x7FFD53C59910
        public void ovr_MatchmakingStats_GetSkillStandardDeviation(){} // RVA: 0x7FFD53C59990
        public void ovr_MatchmakingStats_GetWinCount(){} // RVA: 0x7FFD53C59A10
        public void ovr_Message_GetAbuseReportRecording(){} // RVA: 0x7FFD53C59A90
        public void ovr_Message_GetAchievementDefinitionArray(){} // RVA: 0x7FFD53C59B10
        public void ovr_Message_GetAchievementProgressArray(){} // RVA: 0x7FFD53C59B90
        public void ovr_Message_GetAchievementUpdate(){} // RVA: 0x7FFD53C59C10
        public void ovr_Message_GetApplicationInviteArray(){} // RVA: 0x7FFD53C59C90
        public void ovr_Message_GetApplicationVersion(){} // RVA: 0x7FFD53C59D10
        public void ovr_Message_GetAssetDetails(){} // RVA: 0x7FFD53C59D90
        public void ovr_Message_GetAssetDetailsArray(){} // RVA: 0x7FFD53C59E10
        public void ovr_Message_GetAssetFileDeleteResult(){} // RVA: 0x7FFD53C59E90
        public void ovr_Message_GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFD53C59F10
        public void ovr_Message_GetAssetFileDownloadResult(){} // RVA: 0x7FFD53C59F90
        public void ovr_Message_GetAssetFileDownloadUpdate(){} // RVA: 0x7FFD53C5A010
        public void ovr_Message_GetAvatarEditorResult(){} // RVA: 0x7FFD53C5A090
        public void ovr_Message_GetBlockedUserArray(){} // RVA: 0x7FFD53C5A110
        public void ovr_Message_GetCalApplicationFinalized(){} // RVA: 0x7FFD53C5A190
        public void ovr_Message_GetCalApplicationProposed(){} // RVA: 0x7FFD53C5A210
        public void ovr_Message_GetCalApplicationSuggestionArray(){} // RVA: 0x7FFD53C5A290
        public void ovr_Message_GetChallenge(){} // RVA: 0x7FFD53C5A310
        public void ovr_Message_GetChallengeArray(){} // RVA: 0x7FFD53C5A390
        public void ovr_Message_GetChallengeEntryArray(){} // RVA: 0x7FFD53C5A410
        public void ovr_Message_GetCloudStorageConflictMetadata(){} // RVA: 0x7FFD53C5A490
        public void ovr_Message_GetCloudStorageData(){} // RVA: 0x7FFD53C5A510
        public void ovr_Message_GetCloudStorageMetadata(){} // RVA: 0x7FFD53C5A590
        public void ovr_Message_GetCloudStorageMetadataArray(){} // RVA: 0x7FFD53C5A610
        public void ovr_Message_GetCloudStorageUpdateResponse(){} // RVA: 0x7FFD53C5A690
        public void ovr_Message_GetDataStore(){} // RVA: 0x7FFD53C5A710
        public void ovr_Message_GetDestinationArray(){} // RVA: 0x7FFD53C5A790
        public void ovr_Message_GetError(){} // RVA: 0x7FFD53C5A810
        public void ovr_Message_GetGroupPresenceJoinIntent(){} // RVA: 0x7FFD53C5A890
        public void ovr_Message_GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFD53C5A910
        public void ovr_Message_GetHttpTransferUpdate(){} // RVA: 0x7FFD53C5A990
        public void ovr_Message_GetInstalledApplicationArray(){} // RVA: 0x7FFD53C5AA10
        public void ovr_Message_GetInvitePanelResultInfo(){} // RVA: 0x7FFD53C5AA90
        public void ovr_Message_GetLaunchBlockFlowResult(){} // RVA: 0x7FFD53C5AB10
        public void ovr_Message_GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFD53C5AB90
        public void ovr_Message_GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFD53C5AC10
        public void ovr_Message_GetLaunchReportFlowResult(){} // RVA: 0x7FFD53C5AC90
        public void ovr_Message_GetLaunchUnblockFlowResult(){} // RVA: 0x7FFD53C5AD10
        public void ovr_Message_GetLeaderboardArray(){} // RVA: 0x7FFD53C5AD90
        public void ovr_Message_GetLeaderboardEntryArray(){} // RVA: 0x7FFD53C5AE10
        public void ovr_Message_GetLeaderboardUpdateStatus(){} // RVA: 0x7FFD53C5AE90
        public void ovr_Message_GetLinkedAccountArray(){} // RVA: 0x7FFD53C5AF10
        public void ovr_Message_GetLivestreamingApplicationStatus(){} // RVA: 0x7FFD53C5AF90
        public void ovr_Message_GetLivestreamingStartResult(){} // RVA: 0x7FFD53C5B010
        public void ovr_Message_GetLivestreamingStatus(){} // RVA: 0x7FFD53C5B090
        public void ovr_Message_GetLivestreamingVideoStats(){} // RVA: 0x7FFD53C5B110
        public void ovr_Message_GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFD53C5B190
        public void ovr_Message_GetMatchmakingBrowseResult(){} // RVA: 0x7FFD53C5B210
        public void ovr_Message_GetMatchmakingEnqueueResult(){} // RVA: 0x7FFD53C5B290
        public void ovr_Message_GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFD53C5B310
        public void ovr_Message_GetMatchmakingRoomArray(){} // RVA: 0x7FFD53C5B390
        public void ovr_Message_GetMatchmakingStats(){} // RVA: 0x7FFD53C5B410
        public void ovr_Message_GetMicrophoneAvailabilityState(){} // RVA: 0x7FFD53C5B490
        public void ovr_Message_GetNativeMessage(){} // RVA: 0x7FFD53C5B510
        public void ovr_Message_GetNetSyncConnection(){} // RVA: 0x7FFD53C5B590
        public void ovr_Message_GetNetSyncSessionArray(){} // RVA: 0x7FFD53C5B610
        public void ovr_Message_GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFD53C5B690
        public void ovr_Message_GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFD53C5B710
        public void ovr_Message_GetNetSyncVoipAttenuationValueArray(){} // RVA: 0x7FFD53C5B790
        public void ovr_Message_GetNetworkingPeer(){} // RVA: 0x7FFD53C5B810
        public void ovr_Message_GetOrgScopedID(){} // RVA: 0x7FFD53C5B890
        public void ovr_Message_GetParty(){} // RVA: 0x7FFD53C5B910
        public void ovr_Message_GetPartyID(){} // RVA: 0x7FFD53C5B990
        public void ovr_Message_GetPartyUpdateNotification(){} // RVA: 0x7FFD53C5BA10
        public void ovr_Message_GetPidArray(){} // RVA: 0x7FFD53C5BA90
        public void ovr_Message_GetPingResult(){} // RVA: 0x7FFD53C5BB10
        public void ovr_Message_GetPlatformInitialize(){} // RVA: 0x7FFD53C5BB90
        public void ovr_Message_GetProductArray(){} // RVA: 0x7FFD53C5BC10
        public void ovr_Message_GetPurchase(){} // RVA: 0x7FFD53C5BC90
        public void ovr_Message_GetPurchaseArray(){} // RVA: 0x7FFD53C5BD10
        public void ovr_Message_GetRejoinDialogResult(){} // RVA: 0x7FFD53C5BD90
        public void ovr_Message_GetRequestID(){} // RVA: 0x7FFD53C5BE10
        public void ovr_Message_GetRoom(){} // RVA: 0x7FFD53C5BE90
        public void ovr_Message_GetRoomArray(){} // RVA: 0x7FFD53C5BF10
        public void ovr_Message_GetRoomInviteNotification(){} // RVA: 0x7FFD53C5BF90
        public void ovr_Message_GetRoomInviteNotificationArray(){} // RVA: 0x7FFD53C5C010
        public void ovr_Message_GetSdkAccountArray(){} // RVA: 0x7FFD53C5C090
        public void ovr_Message_GetSendInvitesResult(){} // RVA: 0x7FFD53C5C110
        public void ovr_Message_GetShareMediaResult(){} // RVA: 0x7FFD53C5C190
        public void ovr_Message_GetString(){} // RVA: 0x7FFD53C5C210
        public void ovr_Message_GetString_Native(){} // RVA: 0x7FFD53C5C2D0
        public void ovr_Message_GetSystemVoipState(){} // RVA: 0x7FFD53C5C350
        public void ovr_Message_GetType(){} // RVA: 0x7FFD53C5C3D0
        public void ovr_Message_GetUser(){} // RVA: 0x7FFD53C5C450
        public void ovr_Message_GetUserAndRoomArray(){} // RVA: 0x7FFD53C5C4D0
        public void ovr_Message_GetUserArray(){} // RVA: 0x7FFD53C5C550
        public void ovr_Message_GetUserCapabilityArray(){} // RVA: 0x7FFD53C5C5D0
        public void ovr_Message_GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFD53C5C650
        public void ovr_Message_GetUserProof(){} // RVA: 0x7FFD53C5C6D0
        public void ovr_Message_GetUserReportID(){} // RVA: 0x7FFD53C5C750
        public void ovr_Message_IsError(){} // RVA: 0x7FFD53C5C7D0
        public void ovr_Microphone_GetNumSamplesAvailable(){} // RVA: 0x7FFD53C5C850
        public void ovr_Microphone_GetOutputBufferMaxSize(){} // RVA: 0x7FFD53C5C8D0
        public void ovr_Microphone_GetPCM(){} // RVA: 0x7FFD53C5C950
        public void ovr_Microphone_GetPCMFloat(){} // RVA: 0x7FFD53C5C9F0
        public void ovr_Microphone_ReadData(){} // RVA: 0x7FFD53C5CA90
        public void ovr_Microphone_SetAcceptableRecordingDelayHint(){} // RVA: 0x7FFD53C5CB30
        public void ovr_Microphone_Start(){} // RVA: 0x7FFD53C5CBC0
        public void ovr_Microphone_Stop(){} // RVA: 0x7FFD53C5CC40
        public void ovr_MicrophoneAvailabilityState_GetMicrophoneAvailable(){} // RVA: 0x7FFD53C5CCC0
        public void ovr_NetSyncConnection_GetConnectionId(){} // RVA: 0x7FFD53C5CD40
        public void ovr_NetSyncConnection_GetDisconnectReason(){} // RVA: 0x7FFD53C5CDC0
        public void ovr_NetSyncConnection_GetSessionId(){} // RVA: 0x7FFD53C5CE40
        public void ovr_NetSyncConnection_GetStatus(){} // RVA: 0x7FFD53C5CEC0
        public void ovr_NetSyncConnection_GetZoneId(){} // RVA: 0x7FFD53C5CF40
        public void ovr_NetSyncConnection_GetZoneId_Native(){} // RVA: 0x7FFD53C5D000
        public void ovr_NetSyncSession_GetConnectionId(){} // RVA: 0x7FFD53C5D080
        public void ovr_NetSyncSession_GetMuted(){} // RVA: 0x7FFD53C5D100
        public void ovr_NetSyncSession_GetSessionId(){} // RVA: 0x7FFD53C5D180
        public void ovr_NetSyncSession_GetUserId(){} // RVA: 0x7FFD53C5D200
        public void ovr_NetSyncSession_GetVoipGroup(){} // RVA: 0x7FFD53C5D280
        public void ovr_NetSyncSession_GetVoipGroup_Native(){} // RVA: 0x7FFD53C5D340
        public void ovr_NetSyncSessionArray_GetElement(){} // RVA: 0x7FFD53C5D3C0
        public void ovr_NetSyncSessionArray_GetSize(){} // RVA: 0x7FFD53C5D450
        public void ovr_NetSyncSessionsChangedNotification_GetConnectionId(){} // RVA: 0x7FFD53C5D4D0
        public void ovr_NetSyncSessionsChangedNotification_GetSessions(){} // RVA: 0x7FFD53C5D550
        public void ovr_NetSyncSetSessionPropertyResult_GetSession(){} // RVA: 0x7FFD53C5D5D0
        public void ovr_NetSyncVoipAttenuationValue_GetDecibels(){} // RVA: 0x7FFD53C5D650
        public void ovr_NetSyncVoipAttenuationValue_GetDistance(){} // RVA: 0x7FFD53C5D6D0
        public void ovr_NetSyncVoipAttenuationValueArray_GetElement(){} // RVA: 0x7FFD53C5D750
        public void ovr_NetSyncVoipAttenuationValueArray_GetSize(){} // RVA: 0x7FFD53C5D7E0
        public void ovr_NetworkingPeer_GetID(){} // RVA: 0x7FFD53C5D860
        public void ovr_NetworkingPeer_GetState(){} // RVA: 0x7FFD53C5D8E0
        public void ovr_OrgScopedID_GetID(){} // RVA: 0x7FFD53C5D960
        public void ovr_Packet_Free(){} // RVA: 0x7FFD53C5D9E0
        public void ovr_Packet_GetBytes(){} // RVA: 0x7FFD53C5DA60
        public void ovr_Packet_GetSendPolicy(){} // RVA: 0x7FFD53C5DAE0
        public void ovr_Packet_GetSenderID(){} // RVA: 0x7FFD53C5DB60
        public void ovr_Packet_GetSize(){} // RVA: 0x7FFD53C5DBE0
        public void ovr_Party_GetID(){} // RVA: 0x7FFD53C5DC60
        public void ovr_Party_GetInvitedUsers(){} // RVA: 0x7FFD53C5DCE0
        public void ovr_Party_GetLeader(){} // RVA: 0x7FFD53C5DD60
        public void ovr_Party_GetRoom(){} // RVA: 0x7FFD53C5DDE0
        public void ovr_Party_GetUsers(){} // RVA: 0x7FFD53C5DE60
        public void ovr_PartyID_GetID(){} // RVA: 0x7FFD53C5DEE0
        public void ovr_PartyUpdateNotification_GetAction(){} // RVA: 0x7FFD53C5DF60
        public void ovr_PartyUpdateNotification_GetPartyId(){} // RVA: 0x7FFD53C5DFE0
        public void ovr_PartyUpdateNotification_GetSenderId(){} // RVA: 0x7FFD53C5E060
        public void ovr_PartyUpdateNotification_GetUpdateTimestamp(){} // RVA: 0x7FFD53C5E0E0
        public void ovr_PartyUpdateNotification_GetUpdateTimestamp_Native(){} // RVA: 0x7FFD53C5E1A0
        public void ovr_PartyUpdateNotification_GetUserAlias(){} // RVA: 0x7FFD53C5E220
        public void ovr_PartyUpdateNotification_GetUserAlias_Native(){} // RVA: 0x7FFD53C5E2E0
        public void ovr_PartyUpdateNotification_GetUserId(){} // RVA: 0x7FFD53C5E360
        public void ovr_PartyUpdateNotification_GetUserName(){} // RVA: 0x7FFD53C5E3E0
        public void ovr_PartyUpdateNotification_GetUserName_Native(){} // RVA: 0x7FFD53C5E4A0
        public void ovr_Pid_GetId(){} // RVA: 0x7FFD53C5E520
        public void ovr_Pid_GetId_Native(){} // RVA: 0x7FFD53C5E5E0
        public void ovr_PidArray_GetElement(){} // RVA: 0x7FFD53C5E660
        public void ovr_PidArray_GetSize(){} // RVA: 0x7FFD53C5E6F0
        public void ovr_PingResult_GetID(){} // RVA: 0x7FFD53C5E770
        public void ovr_PingResult_GetPingTimeUsec(){} // RVA: 0x7FFD53C5E7F0
        public void ovr_PingResult_IsTimeout(){} // RVA: 0x7FFD53C5E870
        public void ovr_PlatformInitialize_GetResult(){} // RVA: 0x7FFD53C5E8F0
        public void ovr_Price_GetAmountInHundredths(){} // RVA: 0x7FFD53C5E970
        public void ovr_Price_GetCurrency(){} // RVA: 0x7FFD53C5E9F0
        public void ovr_Price_GetCurrency_Native(){} // RVA: 0x7FFD53C5EAB0
        public void ovr_Price_GetFormatted(){} // RVA: 0x7FFD53C5EB30
        public void ovr_Price_GetFormatted_Native(){} // RVA: 0x7FFD53C5EBF0
        public void ovr_Product_GetDescription(){} // RVA: 0x7FFD53C5EC70
        public void ovr_Product_GetDescription_Native(){} // RVA: 0x7FFD53C5ED30
        public void ovr_Product_GetFormattedPrice(){} // RVA: 0x7FFD53C5EDB0
        public void ovr_Product_GetFormattedPrice_Native(){} // RVA: 0x7FFD53C5EE70
        public void ovr_Product_GetName(){} // RVA: 0x7FFD53C5EEF0
        public void ovr_Product_GetName_Native(){} // RVA: 0x7FFD53C5EFB0
        public void ovr_Product_GetSKU(){} // RVA: 0x7FFD53C5F030
        public void ovr_Product_GetSKU_Native(){} // RVA: 0x7FFD53C5F0F0
        public void ovr_ProductArray_GetElement(){} // RVA: 0x7FFD53C5F170
        public void ovr_ProductArray_GetNextUrl(){} // RVA: 0x7FFD53C5F200
        public void ovr_ProductArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C5F2C0
        public void ovr_ProductArray_GetSize(){} // RVA: 0x7FFD53C5F340
        public void ovr_ProductArray_HasNextPage(){} // RVA: 0x7FFD53C5F3C0
        public void ovr_Purchase_GetDeveloperPayload(){} // RVA: 0x7FFD53C5F440
        public void ovr_Purchase_GetDeveloperPayload_Native(){} // RVA: 0x7FFD53C5F500
        public void ovr_Purchase_GetExpirationTime(){} // RVA: 0x7FFD53C5F580
        public void ovr_Purchase_GetExpirationTime_Native(){} // RVA: 0x7FFD53C5F640
        public void ovr_Purchase_GetGrantTime(){} // RVA: 0x7FFD53C5F6C0
        public void ovr_Purchase_GetGrantTime_Native(){} // RVA: 0x7FFD53C5F780
        public void ovr_Purchase_GetPurchaseID(){} // RVA: 0x7FFD53C5F800
        public void ovr_Purchase_GetPurchaseStrID(){} // RVA: 0x7FFD53C5F880
        public void ovr_Purchase_GetPurchaseStrID_Native(){} // RVA: 0x7FFD53C5F940
        public void ovr_Purchase_GetReportingId(){} // RVA: 0x7FFD53C5F9C0
        public void ovr_Purchase_GetReportingId_Native(){} // RVA: 0x7FFD53C5FA80
        public void ovr_Purchase_GetSKU(){} // RVA: 0x7FFD53C5FB00
        public void ovr_Purchase_GetSKU_Native(){} // RVA: 0x7FFD53C5FBC0
        public void ovr_PurchaseArray_GetElement(){} // RVA: 0x7FFD53C5FC40
        public void ovr_PurchaseArray_GetNextUrl(){} // RVA: 0x7FFD53C5FCD0
        public void ovr_PurchaseArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C5FD90
        public void ovr_PurchaseArray_GetSize(){} // RVA: 0x7FFD53C5FE10
        public void ovr_PurchaseArray_HasNextPage(){} // RVA: 0x7FFD53C5FE90
        public void ovr_RejoinDialogResult_GetRejoinSelected(){} // RVA: 0x7FFD53C5FF10
        public void ovr_Room_GetApplicationID(){} // RVA: 0x7FFD53C5FF90
        public void ovr_Room_GetDataStore(){} // RVA: 0x7FFD53C60010
        public void ovr_Room_GetDescription(){} // RVA: 0x7FFD53C60090
        public void ovr_Room_GetDescription_Native(){} // RVA: 0x7FFD53C60150
        public void ovr_Room_GetID(){} // RVA: 0x7FFD53C601D0
        public void ovr_Room_GetInvitedUsers(){} // RVA: 0x7FFD53C60250
        public void ovr_Room_GetIsMembershipLocked(){} // RVA: 0x7FFD53C602D0
        public void ovr_Room_GetJoinPolicy(){} // RVA: 0x7FFD53C60350
        public void ovr_Room_GetJoinability(){} // RVA: 0x7FFD53C603D0
        public void ovr_Room_GetMatchedUsers(){} // RVA: 0x7FFD53C60450
        public void ovr_Room_GetMaxUsers(){} // RVA: 0x7FFD53C604D0
        public void ovr_Room_GetName(){} // RVA: 0x7FFD53C60550
        public void ovr_Room_GetName_Native(){} // RVA: 0x7FFD53C60610
        public void ovr_Room_GetOwner(){} // RVA: 0x7FFD53C60690
        public void ovr_Room_GetTeams(){} // RVA: 0x7FFD53C60710
        public void ovr_Room_GetType(){} // RVA: 0x7FFD53C60790
        public void ovr_Room_GetUsers(){} // RVA: 0x7FFD53C60810
        public void ovr_Room_GetVersion(){} // RVA: 0x7FFD53C60890
        public void ovr_RoomArray_GetElement(){} // RVA: 0x7FFD53C60910
        public void ovr_RoomArray_GetNextUrl(){} // RVA: 0x7FFD53C609A0
        public void ovr_RoomArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C60A60
        public void ovr_RoomArray_GetSize(){} // RVA: 0x7FFD53C60AE0
        public void ovr_RoomArray_HasNextPage(){} // RVA: 0x7FFD53C60B60
        public void ovr_RoomInviteNotification_GetID(){} // RVA: 0x7FFD53C60BE0
        public void ovr_RoomInviteNotification_GetRoomID(){} // RVA: 0x7FFD53C60C60
        public void ovr_RoomInviteNotification_GetSenderID(){} // RVA: 0x7FFD53C60CE0
        public void ovr_RoomInviteNotification_GetSentTime(){} // RVA: 0x7FFD53C60D60
        public void ovr_RoomInviteNotification_GetSentTime_Native(){} // RVA: 0x7FFD53C60E20
        public void ovr_RoomInviteNotificationArray_GetElement(){} // RVA: 0x7FFD53C60EA0
        public void ovr_RoomInviteNotificationArray_GetNextUrl(){} // RVA: 0x7FFD53C60F30
        public void ovr_RoomInviteNotificationArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C60FF0
        public void ovr_RoomInviteNotificationArray_GetSize(){} // RVA: 0x7FFD53C61070
        public void ovr_RoomInviteNotificationArray_HasNextPage(){} // RVA: 0x7FFD53C610F0
        public void ovr_SdkAccount_GetAccountType(){} // RVA: 0x7FFD53C61170
        public void ovr_SdkAccount_GetUserId(){} // RVA: 0x7FFD53C611F0
        public void ovr_SdkAccountArray_GetElement(){} // RVA: 0x7FFD53C61270
        public void ovr_SdkAccountArray_GetSize(){} // RVA: 0x7FFD53C61300
        public void ovr_SendInvitesResult_GetInvites(){} // RVA: 0x7FFD53C61380
        public void ovr_ShareMediaResult_GetStatus(){} // RVA: 0x7FFD53C61400
        public void ovr_SupplementaryMetric_GetID(){} // RVA: 0x7FFD53C61480
        public void ovr_SupplementaryMetric_GetMetric(){} // RVA: 0x7FFD53C61500
        public void ovr_SystemVoipState_GetMicrophoneMuted(){} // RVA: 0x7FFD53C61580
        public void ovr_SystemVoipState_GetStatus(){} // RVA: 0x7FFD53C61600
        public void ovr_Team_GetAssignedUsers(){} // RVA: 0x7FFD53C61680
        public void ovr_Team_GetMaxUsers(){} // RVA: 0x7FFD53C61700
        public void ovr_Team_GetMinUsers(){} // RVA: 0x7FFD53C61780
        public void ovr_Team_GetName(){} // RVA: 0x7FFD53C61800
        public void ovr_Team_GetName_Native(){} // RVA: 0x7FFD53C618C0
        public void ovr_TeamArray_GetElement(){} // RVA: 0x7FFD53C61940
        public void ovr_TeamArray_GetSize(){} // RVA: 0x7FFD53C619D0
        public void ovr_TestUser_GetAccessToken(){} // RVA: 0x7FFD53C61A50
        public void ovr_TestUser_GetAccessToken_Native(){} // RVA: 0x7FFD53C61B10
        public void ovr_TestUser_GetAppAccessArray(){} // RVA: 0x7FFD53C61B90
        public void ovr_TestUser_GetFbAppAccessArray(){} // RVA: 0x7FFD53C61C10
        public void ovr_TestUser_GetFriendAccessToken(){} // RVA: 0x7FFD53C61C90
        public void ovr_TestUser_GetFriendAccessToken_Native(){} // RVA: 0x7FFD53C61D50
        public void ovr_TestUser_GetFriendAppAccessArray(){} // RVA: 0x7FFD53C61DD0
        public void ovr_TestUser_GetUserAlias(){} // RVA: 0x7FFD53C61E50
        public void ovr_TestUser_GetUserAlias_Native(){} // RVA: 0x7FFD53C61F10
        public void ovr_TestUser_GetUserFbid(){} // RVA: 0x7FFD53C61F90
        public void ovr_TestUser_GetUserId(){} // RVA: 0x7FFD53C62010
        public void ovr_TestUserAppAccess_GetAccessToken(){} // RVA: 0x7FFD53C62090
        public void ovr_TestUserAppAccess_GetAccessToken_Native(){} // RVA: 0x7FFD53C62150
        public void ovr_TestUserAppAccess_GetAppId(){} // RVA: 0x7FFD53C621D0
        public void ovr_TestUserAppAccess_GetUserId(){} // RVA: 0x7FFD53C62250
        public void ovr_TestUserAppAccessArray_GetElement(){} // RVA: 0x7FFD53C622D0
        public void ovr_TestUserAppAccessArray_GetSize(){} // RVA: 0x7FFD53C62360
        public void ovr_User_GetDisplayName(){} // RVA: 0x7FFD53C623E0
        public void ovr_User_GetDisplayName_Native(){} // RVA: 0x7FFD53C624A0
        public void ovr_User_GetID(){} // RVA: 0x7FFD53C62520
        public void ovr_User_GetImageUrl(){} // RVA: 0x7FFD53C625A0
        public void ovr_User_GetImageUrl_Native(){} // RVA: 0x7FFD53C62660
        public void ovr_User_GetInviteToken(){} // RVA: 0x7FFD53C626E0
        public void ovr_User_GetInviteToken_Native(){} // RVA: 0x7FFD53C627A0
        public void ovr_User_GetOculusID(){} // RVA: 0x7FFD53C62820
        public void ovr_User_GetOculusID_Native(){} // RVA: 0x7FFD53C628E0
        public void ovr_User_GetPresence(){} // RVA: 0x7FFD53C62960
        public void ovr_User_GetPresence_Native(){} // RVA: 0x7FFD53C62A20
        public void ovr_User_GetPresenceDeeplinkMessage(){} // RVA: 0x7FFD53C62AA0
        public void ovr_User_GetPresenceDeeplinkMessage_Native(){} // RVA: 0x7FFD53C62B60
        public void ovr_User_GetPresenceDestinationApiName(){} // RVA: 0x7FFD53C62BE0
        public void ovr_User_GetPresenceDestinationApiName_Native(){} // RVA: 0x7FFD53C62CA0
        public void ovr_User_GetPresenceLobbySessionId(){} // RVA: 0x7FFD53C62D20
        public void ovr_User_GetPresenceLobbySessionId_Native(){} // RVA: 0x7FFD53C62DE0
        public void ovr_User_GetPresenceMatchSessionId(){} // RVA: 0x7FFD53C62E60
        public void ovr_User_GetPresenceMatchSessionId_Native(){} // RVA: 0x7FFD53C62F20
        public void ovr_User_GetPresenceStatus(){} // RVA: 0x7FFD53C62FA0
        public void ovr_User_GetSmallImageUrl(){} // RVA: 0x7FFD53C63020
        public void ovr_User_GetSmallImageUrl_Native(){} // RVA: 0x7FFD53C630E0
        public void ovr_UserAndRoom_GetRoom(){} // RVA: 0x7FFD53C63160
        public void ovr_UserAndRoom_GetUser(){} // RVA: 0x7FFD53C631E0
        public void ovr_UserAndRoomArray_GetElement(){} // RVA: 0x7FFD53C63260
        public void ovr_UserAndRoomArray_GetNextUrl(){} // RVA: 0x7FFD53C632F0
        public void ovr_UserAndRoomArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C633B0
        public void ovr_UserAndRoomArray_GetSize(){} // RVA: 0x7FFD53C63430
        public void ovr_UserAndRoomArray_HasNextPage(){} // RVA: 0x7FFD53C634B0
        public void ovr_UserArray_GetElement(){} // RVA: 0x7FFD53C63530
        public void ovr_UserArray_GetNextUrl(){} // RVA: 0x7FFD53C635C0
        public void ovr_UserArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C63680
        public void ovr_UserArray_GetSize(){} // RVA: 0x7FFD53C63700
        public void ovr_UserArray_HasNextPage(){} // RVA: 0x7FFD53C63780
        public void ovr_UserCapability_GetDescription(){} // RVA: 0x7FFD53C63800
        public void ovr_UserCapability_GetDescription_Native(){} // RVA: 0x7FFD53C638C0
        public void ovr_UserCapability_GetIsEnabled(){} // RVA: 0x7FFD53C63940
        public void ovr_UserCapability_GetName(){} // RVA: 0x7FFD53C639C0
        public void ovr_UserCapability_GetName_Native(){} // RVA: 0x7FFD53C63A80
        public void ovr_UserCapability_GetReasonCode(){} // RVA: 0x7FFD53C63B00
        public void ovr_UserCapability_GetReasonCode_Native(){} // RVA: 0x7FFD53C63BC0
        public void ovr_UserCapabilityArray_GetElement(){} // RVA: 0x7FFD53C63C40
        public void ovr_UserCapabilityArray_GetNextUrl(){} // RVA: 0x7FFD53C63CD0
        public void ovr_UserCapabilityArray_GetNextUrl_Native(){} // RVA: 0x7FFD53C63D90
        public void ovr_UserCapabilityArray_GetSize(){} // RVA: 0x7FFD53C63E10
        public void ovr_UserCapabilityArray_HasNextPage(){} // RVA: 0x7FFD53C63E90
        public void ovr_UserDataStoreUpdateResponse_GetSuccess(){} // RVA: 0x7FFD53C63F10
        public void ovr_UserProof_GetNonce(){} // RVA: 0x7FFD53C63F90
        public void ovr_UserProof_GetNonce_Native(){} // RVA: 0x7FFD53C64050
        public void ovr_UserReportID_GetDidCancel(){} // RVA: 0x7FFD53C640D0
        public void ovr_UserReportID_GetID(){} // RVA: 0x7FFD53C64150
        public void ovr_VoipDecoder_GetDecodedPCM(){} // RVA: 0x7FFD53C64230
        public void ovr_VoipEncoder_AddPCM(){} // RVA: 0x7FFD53C642D0
        public void ovr_VoipEncoder_GetCompressedData(){} // RVA: 0x7FFD53C64370
        public void ovr_VoipEncoder_GetCompressedDataSize(){} // RVA: 0x7FFD53C64410
        public void ovr_AbuseReportOptions_Create(){} // RVA: 0x7FFD53C64490
        public void ovr_AbuseReportOptions_Destroy(){} // RVA: 0x7FFD53C64500
        public void ovr_AbuseReportOptions_SetPreventPeopleChooser(){} // RVA: 0x7FFD53C64580
        public void ovr_AbuseReportOptions_SetReportType(){} // RVA: 0x7FFD53C64610
        public void ovr_AdvancedAbuseReportOptions_Create(){} // RVA: 0x7FFD53C646A0
        public void ovr_AdvancedAbuseReportOptions_Destroy(){} // RVA: 0x7FFD53C64710
        public void ovr_AdvancedAbuseReportOptions_SetDeveloperDefinedContextString(){} // RVA: 0x7FFD53C64790
        public void ovr_AdvancedAbuseReportOptions_SetDeveloperDefinedContextString_Native(){} // RVA: 0x7FFD53C648B0
        public void ovr_AdvancedAbuseReportOptions_ClearDeveloperDefinedContext(){} // RVA: 0x7FFD53C64950
        public void ovr_AdvancedAbuseReportOptions_SetObjectType(){} // RVA: 0x7FFD53C649D0
        public void ovr_AdvancedAbuseReportOptions_SetObjectType_Native(){} // RVA: 0x7FFD53C64AD0
        public void ovr_AdvancedAbuseReportOptions_SetReportType(){} // RVA: 0x7FFD53C64B60
        public void ovr_AdvancedAbuseReportOptions_AddSuggestedUser(){} // RVA: 0x7FFD53C64BF0
        public void ovr_AdvancedAbuseReportOptions_ClearSuggestedUsers(){} // RVA: 0x7FFD53C64C80
        public void ovr_AdvancedAbuseReportOptions_SetVideoMode(){} // RVA: 0x7FFD53C64D00
        public void ovr_ApplicationOptions_Create(){} // RVA: 0x7FFD53C64D90
        public void ovr_ApplicationOptions_Destroy(){} // RVA: 0x7FFD53C64E00
        public void ovr_ApplicationOptions_SetDeeplinkMessage(){} // RVA: 0x7FFD53C64E80
        public void ovr_ApplicationOptions_SetDeeplinkMessage_Native(){} // RVA: 0x7FFD53C64F80
        public void ovr_ApplicationOptions_SetDestinationApiName(){} // RVA: 0x7FFD53C65010
        public void ovr_ApplicationOptions_SetDestinationApiName_Native(){} // RVA: 0x7FFD53C65110
        public void ovr_ApplicationOptions_SetLobbySessionId(){} // RVA: 0x7FFD53C651A0
        public void ovr_ApplicationOptions_SetLobbySessionId_Native(){} // RVA: 0x7FFD53C652A0
        public void ovr_ApplicationOptions_SetMatchSessionId(){} // RVA: 0x7FFD53C65330
        public void ovr_ApplicationOptions_SetMatchSessionId_Native(){} // RVA: 0x7FFD53C65430
        public void ovr_ApplicationOptions_SetRoomId(){} // RVA: 0x7FFD53C654C0
        public void ovr_AvatarEditorOptions_Create(){} // RVA: 0x7FFD53C65550
        public void ovr_AvatarEditorOptions_Destroy(){} // RVA: 0x7FFD53C655C0
        public void ovr_AvatarEditorOptions_SetSourceOverride(){} // RVA: 0x7FFD53C65640
        public void ovr_AvatarEditorOptions_SetSourceOverride_Native(){} // RVA: 0x7FFD53C65740
        public void ovr_ChallengeOptions_Create(){} // RVA: 0x7FFD53C657D0
        public void ovr_ChallengeOptions_Destroy(){} // RVA: 0x7FFD53C65840
        public void ovr_ChallengeOptions_SetDescription(){} // RVA: 0x7FFD53C658C0
        public void ovr_ChallengeOptions_SetDescription_Native(){} // RVA: 0x7FFD53C659C0
        public void ovr_ChallengeOptions_SetEndDate(){} // RVA: 0x7FFD53C65A50
        public void ovr_ChallengeOptions_SetEndDate_Native(){} // RVA: 0x7FFD53C65B20
        public void ovr_ChallengeOptions_SetIncludeActiveChallenges(){} // RVA: 0x7FFD53C65BB0
        public void ovr_ChallengeOptions_SetIncludeFutureChallenges(){} // RVA: 0x7FFD53C65C40
        public void ovr_ChallengeOptions_SetIncludePastChallenges(){} // RVA: 0x7FFD53C65CD0
        public void ovr_ChallengeOptions_SetLeaderboardName(){} // RVA: 0x7FFD53C65D60
        public void ovr_ChallengeOptions_SetLeaderboardName_Native(){} // RVA: 0x7FFD53C65E60
        public void ovr_ChallengeOptions_SetStartDate(){} // RVA: 0x7FFD53C65EF0
        public void ovr_ChallengeOptions_SetStartDate_Native(){} // RVA: 0x7FFD53C65FC0
        public void ovr_ChallengeOptions_SetTitle(){} // RVA: 0x7FFD53C66050
        public void ovr_ChallengeOptions_SetTitle_Native(){} // RVA: 0x7FFD53C66150
        public void ovr_ChallengeOptions_SetViewerFilter(){} // RVA: 0x7FFD53C661E0
        public void ovr_ChallengeOptions_SetVisibility(){} // RVA: 0x7FFD53C66270
        public void ovr_GroupPresenceOptions_Create(){} // RVA: 0x7FFD53C66300
        public void ovr_GroupPresenceOptions_Destroy(){} // RVA: 0x7FFD53C66370
        public void ovr_GroupPresenceOptions_SetDeeplinkMessageOverride(){} // RVA: 0x7FFD53C663F0
        public void ovr_GroupPresenceOptions_SetDeeplinkMessageOverride_Native(){} // RVA: 0x7FFD53C664F0
        public void ovr_GroupPresenceOptions_SetDestinationApiName(){} // RVA: 0x7FFD53C66580
        public void ovr_GroupPresenceOptions_SetDestinationApiName_Native(){} // RVA: 0x7FFD53C66680
        public void ovr_GroupPresenceOptions_SetIsJoinable(){} // RVA: 0x7FFD53C66710
        public void ovr_GroupPresenceOptions_SetLobbySessionId(){} // RVA: 0x7FFD53C667A0
        public void ovr_GroupPresenceOptions_SetLobbySessionId_Native(){} // RVA: 0x7FFD53C668A0
        public void ovr_GroupPresenceOptions_SetMatchSessionId(){} // RVA: 0x7FFD53C66930
        public void ovr_GroupPresenceOptions_SetMatchSessionId_Native(){} // RVA: 0x7FFD53C66A30
        public void ovr_InviteOptions_Create(){} // RVA: 0x7FFD53C66AC0
        public void ovr_InviteOptions_Destroy(){} // RVA: 0x7FFD53C66B30
        public void ovr_InviteOptions_AddSuggestedUser(){} // RVA: 0x7FFD53C66BB0
        public void ovr_InviteOptions_ClearSuggestedUsers(){} // RVA: 0x7FFD53C66C40
        public void ovr_MatchmakingOptions_Create(){} // RVA: 0x7FFD53C66CC0
        public void ovr_MatchmakingOptions_Destroy(){} // RVA: 0x7FFD53C66D30
        public void ovr_MatchmakingOptions_SetCreateRoomDataStoreString(){} // RVA: 0x7FFD53C66DB0
        public void ovr_MatchmakingOptions_SetCreateRoomDataStoreString_Native(){} // RVA: 0x7FFD53C66ED0
        public void ovr_MatchmakingOptions_ClearCreateRoomDataStore(){} // RVA: 0x7FFD53C66F70
        public void ovr_MatchmakingOptions_SetCreateRoomJoinPolicy(){} // RVA: 0x7FFD53C66FF0
        public void ovr_MatchmakingOptions_SetCreateRoomMaxUsers(){} // RVA: 0x7FFD53C67080
        public void ovr_MatchmakingOptions_AddEnqueueAdditionalUser(){} // RVA: 0x7FFD53C67110
        public void ovr_MatchmakingOptions_ClearEnqueueAdditionalUsers(){} // RVA: 0x7FFD53C671A0
        public void ovr_MatchmakingOptions_SetEnqueueDataSettingsInt(){} // RVA: 0x7FFD53C67220
        public void ovr_MatchmakingOptions_SetEnqueueDataSettingsInt_Native(){} // RVA: 0x7FFD53C67330
        public void ovr_MatchmakingOptions_SetEnqueueDataSettingsDouble(){} // RVA: 0x7FFD53C673D0
        public void ovr_MatchmakingOptions_SetEnqueueDataSettingsDouble_Native(){} // RVA: 0x7FFD53C674E0
        public void ovr_MatchmakingOptions_SetEnqueueDataSettingsString(){} // RVA: 0x7FFD53C67580
        public void ovr_MatchmakingOptions_SetEnqueueDataSettingsString_Native(){} // RVA: 0x7FFD53C676A0
        public void ovr_MatchmakingOptions_ClearEnqueueDataSettings(){} // RVA: 0x7FFD53C67740
        public void ovr_MatchmakingOptions_SetEnqueueIsDebug(){} // RVA: 0x7FFD53C677C0
        public void ovr_MatchmakingOptions_SetEnqueueQueryKey(){} // RVA: 0x7FFD53C67850
        public void ovr_MatchmakingOptions_SetEnqueueQueryKey_Native(){} // RVA: 0x7FFD53C67950
        public void ovr_MultiplayerErrorOptions_Create(){} // RVA: 0x7FFD53C679E0
        public void ovr_MultiplayerErrorOptions_Destroy(){} // RVA: 0x7FFD53C67A50
        public void ovr_MultiplayerErrorOptions_SetErrorKey(){} // RVA: 0x7FFD53C67AD0
        public void ovr_NetSyncOptions_Create(){} // RVA: 0x7FFD53C67B60
        public void ovr_NetSyncOptions_Destroy(){} // RVA: 0x7FFD53C67BD0
        public void ovr_NetSyncOptions_SetVoipGroup(){} // RVA: 0x7FFD53C67C50
        public void ovr_NetSyncOptions_SetVoipGroup_Native(){} // RVA: 0x7FFD53C67D50
        public void ovr_NetSyncOptions_SetVoipStreamDefault(){} // RVA: 0x7FFD53C67DE0
        public void ovr_NetSyncOptions_SetZoneId(){} // RVA: 0x7FFD53C67E70
        public void ovr_NetSyncOptions_SetZoneId_Native(){} // RVA: 0x7FFD53C67F70
        public void ovr_RichPresenceOptions_Create(){} // RVA: 0x7FFD53C68000
        public void ovr_RichPresenceOptions_Destroy(){} // RVA: 0x7FFD53C68070
        public void ovr_RichPresenceOptions_SetApiName(){} // RVA: 0x7FFD53C680F0
        public void ovr_RichPresenceOptions_SetApiName_Native(){} // RVA: 0x7FFD53C681F0
        public void ovr_RichPresenceOptions_SetArgsString(){} // RVA: 0x7FFD53C68280
        public void ovr_RichPresenceOptions_SetArgsString_Native(){} // RVA: 0x7FFD53C683A0
        public void ovr_RichPresenceOptions_ClearArgs(){} // RVA: 0x7FFD53C68440
        public void ovr_RichPresenceOptions_SetCurrentCapacity(){} // RVA: 0x7FFD53C684C0
        public void ovr_RichPresenceOptions_SetDeeplinkMessageOverride(){} // RVA: 0x7FFD53C68550
        public void ovr_RichPresenceOptions_SetDeeplinkMessageOverride_Native(){} // RVA: 0x7FFD53C68650
        public void ovr_RichPresenceOptions_SetEndTime(){} // RVA: 0x7FFD53C686E0
        public void ovr_RichPresenceOptions_SetEndTime_Native(){} // RVA: 0x7FFD53C687B0
        public void ovr_RichPresenceOptions_SetExtraContext(){} // RVA: 0x7FFD53C68840
        public void ovr_RichPresenceOptions_SetInstanceId(){} // RVA: 0x7FFD53C688D0
        public void ovr_RichPresenceOptions_SetInstanceId_Native(){} // RVA: 0x7FFD53C689D0
        public void ovr_RichPresenceOptions_SetIsIdle(){} // RVA: 0x7FFD53C68A60
        public void ovr_RichPresenceOptions_SetIsJoinable(){} // RVA: 0x7FFD53C68AF0
        public void ovr_RichPresenceOptions_SetJoinableId(){} // RVA: 0x7FFD53C68B80
        public void ovr_RichPresenceOptions_SetJoinableId_Native(){} // RVA: 0x7FFD53C68C80
        public void ovr_RichPresenceOptions_SetLobbySessionId(){} // RVA: 0x7FFD53C68D10
        public void ovr_RichPresenceOptions_SetLobbySessionId_Native(){} // RVA: 0x7FFD53C68E10
        public void ovr_RichPresenceOptions_SetMatchSessionId(){} // RVA: 0x7FFD53C68EA0
        public void ovr_RichPresenceOptions_SetMatchSessionId_Native(){} // RVA: 0x7FFD53C68FA0
        public void ovr_RichPresenceOptions_SetMaxCapacity(){} // RVA: 0x7FFD53C69030
        public void ovr_RichPresenceOptions_SetStartTime(){} // RVA: 0x7FFD53C690C0
        public void ovr_RichPresenceOptions_SetStartTime_Native(){} // RVA: 0x7FFD53C69190
        public void ovr_RoomOptions_Create(){} // RVA: 0x7FFD53C69220
        public void ovr_RoomOptions_Destroy(){} // RVA: 0x7FFD53C69290
        public void ovr_RoomOptions_SetDataStoreString(){} // RVA: 0x7FFD53C69310
        public void ovr_RoomOptions_SetDataStoreString_Native(){} // RVA: 0x7FFD53C69430
        public void ovr_RoomOptions_ClearDataStore(){} // RVA: 0x7FFD53C694D0
        public void ovr_RoomOptions_SetExcludeRecentlyMet(){} // RVA: 0x7FFD53C69550
        public void ovr_RoomOptions_SetMaxUserResults(){} // RVA: 0x7FFD53C695E0
        public void ovr_RoomOptions_SetOrdering(){} // RVA: 0x7FFD53C69670
        public void ovr_RoomOptions_SetRecentlyMetTimeWindow(){} // RVA: 0x7FFD53C69700
        public void ovr_RoomOptions_SetRoomId(){} // RVA: 0x7FFD53C69790
        public void ovr_RoomOptions_SetTurnOffUpdates(){} // RVA: 0x7FFD53C69820
        public void ovr_RosterOptions_Create(){} // RVA: 0x7FFD53C698B0
        public void ovr_RosterOptions_Destroy(){} // RVA: 0x7FFD53C69920
        public void ovr_RosterOptions_AddSuggestedUser(){} // RVA: 0x7FFD53C699A0
        public void ovr_RosterOptions_ClearSuggestedUsers(){} // RVA: 0x7FFD53C69A30
        public void ovr_UserOptions_Create(){} // RVA: 0x7FFD53C69AB0
        public void ovr_UserOptions_Destroy(){} // RVA: 0x7FFD53C69B20
        public void ovr_UserOptions_SetMaxUsers(){} // RVA: 0x7FFD53C69BA0
        public void ovr_UserOptions_AddServiceProvider(){} // RVA: 0x7FFD53C69C30
        public void ovr_UserOptions_ClearServiceProviders(){} // RVA: 0x7FFD53C69CC0
        public void ovr_UserOptions_SetTimeWindow(){} // RVA: 0x7FFD53C69D40
        public void ovr_VoipOptions_Create(){} // RVA: 0x7FFD53C69DD0
        public void ovr_VoipOptions_Destroy(){} // RVA: 0x7FFD53C69E40
        public void ovr_VoipOptions_SetBitrateForNewConnections(){} // RVA: 0x7FFD53C69EC0
        public void ovr_VoipOptions_SetCreateNewConnectionUseDtx(){} // RVA: 0x7FFD53C69F50
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53C69FE0
    }

    public class Callback : Object
    {
        public System.Collections.Generic.Dictionary`2<ulong,Oculus.Platform.Request> requestIDsToRequests;
        public System.Collections.Generic.Dictionary`2<!,RequestCallback> notificationCallbacks; // 0x8
        public bool hasRegisteredRoomInviteNotificationHandler; // 0x10
        public System.Collections.Generic.List`1<Oculus.Platform.Message> pendingRoomInviteNotifications; // 0x18
        public bool hasRegisteredJoinIntentNotificationHandler; // 0x20
        public Oculus.Platform.Message latestPendingJoinIntentNotifications; // 0x28

        // ── Methods ──
        public void SetNotificationCallback(){} // RVA: 0x7FFD53C3A2B0 | overloaded x2
        public void AddRequest(){} // RVA: 0x7FFD53C3A430
        public void RunCallbacks(){} // RVA: 0x7FFD53C3A530
        public void RunLimitedCallbacks(){} // RVA: 0x7FFD53C3A5B0
        public void OnApplicationQuit(){} // RVA: 0x7FFD53C3A640
        public void FlushRoomInviteNotificationQueue(){} // RVA: 0x7FFD53C3A740
        public void FlushJoinIntentNotificationQueue(){} // RVA: 0x7FFD53C3A940
        public void HandleMessage(){} // RVA: 0x7FFD53C3AA60
        public void .cctor(){} // RVA: 0x7FFD53C3AE80
    }

    public class CallbackRunner : MonoBehaviour
    {
        public bool IsPersistantBetweenSceneLoads; // 0x20

        // ── Methods ──
        public void ovr_UnityResetTestPlatform(){} // RVA: 0x7FFD53C3B180
        public void Awake(){} // RVA: 0x7FFD53C3B1F0
        public void Update(){} // RVA: 0x7FFD53C3B410
        public void OnDestroy(){} // RVA: 0x7FFD4E341310
        public void OnApplicationQuit(){} // RVA: 0x7FFD53C3B4C0
        public void .ctor(){} // RVA: 0x7FFD4E39B060
    }

    public class ChallengeOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C6A520
        public void SetDescription(){} // RVA: 0x7FFD53C6A5D0
        public void SetEndDate(){} // RVA: 0x7FFD53C6A710
        public void SetIncludeActiveChallenges(){} // RVA: 0x7FFD53C6A820
        public void SetIncludeFutureChallenges(){} // RVA: 0x7FFD53C6A8E0
        public void SetIncludePastChallenges(){} // RVA: 0x7FFD53C6A9A0
        public void SetLeaderboardName(){} // RVA: 0x7FFD53C6AA60
        public void SetStartDate(){} // RVA: 0x7FFD53C6ABA0
        public void SetTitle(){} // RVA: 0x7FFD53C6ACB0
        public void SetViewerFilter(){} // RVA: 0x7FFD53C6ADF0
        public void SetVisibility(){} // RVA: 0x7FFD53C6AEB0
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C6AF70
    }

    public class Core : Object
    {
        public bool IsPlatformInitialized;
        public bool LogMessages; // 0x1
        public string PlatformUninitializedError; // 0x8

        // ── Methods ──
        public void IsInitialized(){} // RVA: 0x7FFD53C7ABC0
        public void ForceInitialized(){} // RVA: 0x7FFD53C7AC20
        public void getAppID(){} // RVA: 0x7FFD53C7AC80
        public void AsyncInitialize(){} // RVA: 0x7FFD53C7B420 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD53C7B760
        public void GetAppIDFromConfig(){} // RVA: 0x7FFD53C7BC20
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53C7BCD0
    }

    public class GroupPresenceOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C6B060
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7FFD53C6B110
        public void SetDestinationApiName(){} // RVA: 0x7FFD53C6B250
        public void SetIsJoinable(){} // RVA: 0x7FFD53C6B390
        public void SetLobbySessionId(){} // RVA: 0x7FFD53C6B450
        public void SetMatchSessionId(){} // RVA: 0x7FFD53C6B590
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C6B6D0
    }

    public class IMicrophone
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E090980
        public void Stop(){} // RVA: 0x7FFD4E090980
        public void Update(){} // RVA: 0x7FFD4E078E90
    }

    public class IVoipPCMSource
    {
        // ── Methods ──
        public void GetPCM(){}
        public void SetSenderID(){} // RVA: 0x7FFD4E090BF0
        public void Update(){} // RVA: 0x7FFD4E090980
        public void PeekSizeElements(){} // RVA: 0x7FFD4E079960
    }

    public class InviteOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C6B7C0
        public void AddSuggestedUser(){} // RVA: 0x7FFD53C6B870
        public void ClearSuggestedUsers(){} // RVA: 0x7FFD53C6B940
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C6BA00
    }

    public class MatchmakingOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C6BAF0
        public void SetCreateRoomDataStore(){} // RVA: 0x7FFD53C6BBA0
        public void ClearCreateRoomDataStore(){} // RVA: 0x7FFD53C6BD10
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x7FFD53C6BDD0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x7FFD53C6BE90
        public void AddEnqueueAdditionalUser(){} // RVA: 0x7FFD53C6BF50
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x7FFD53C6C020
        public void SetEnqueueDataSettings(){} // RVA: 0x7FFD53C6C380 | overloaded x3
        public void ClearEnqueueDataSettings(){} // RVA: 0x7FFD53C6C4F0
        public void SetEnqueueIsDebug(){} // RVA: 0x7FFD53C6C5B0
        public void SetEnqueueQueryKey(){} // RVA: 0x7FFD53C6C670
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C6C7B0
    }

    public class Message : Object
    {
        public ! Type; // 0x10
        public ulong IsError; // 0x18
        public Oculus.Platform.Models.Error RequestID; // 0x20
        public 0x665B5630 HandleExtraMessageTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C6C8A0
        public void Finalize(){} // RVA: 0x7FFD4ECF9870
        public void get_Type(){} // RVA: 0x7FFD4E38E5C0
        public void get_IsError(){} // RVA: 0x7FFD4FD7C6A0
        public void get_RequestID(){} // RVA: 0x7FFD4E3447C0
        public void GetError(){} // RVA: 0x7FFD4E36F0C0
        public void GetPingResult(){} // RVA: 0x7FFD4E919180
        public void GetNetworkingPeer(){} // RVA: 0x7FFD4E919180
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFD4E919180
        public void GetPlatformInitialize(){} // RVA: 0x7FFD4E919180
        public void GetAbuseReportRecording(){} // RVA: 0x7FFD4E919180
        public void GetAchievementDefinitions(){} // RVA: 0x7FFD4E919180
        public void GetAchievementProgressList(){} // RVA: 0x7FFD4E919180
        public void GetAchievementUpdate(){} // RVA: 0x7FFD4E919180
        public void GetApplicationInviteList(){} // RVA: 0x7FFD4E919180
        public void GetApplicationVersion(){} // RVA: 0x7FFD4E919180
        public void GetAssetDetails(){} // RVA: 0x7FFD4E919180
        public void GetAssetDetailsList(){} // RVA: 0x7FFD4E919180
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFD4E919180
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFD4E919180
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFD4E919180
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFD4E919180
        public void GetAvatarEditorResult(){} // RVA: 0x7FFD4E919180
        public void GetBlockedUserList(){} // RVA: 0x7FFD4E919180
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFD4E919180
        public void GetCalApplicationProposed(){} // RVA: 0x7FFD4E919180
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFD4E919180
        public void GetChallenge(){} // RVA: 0x7FFD4E919180
        public void GetChallengeEntryList(){} // RVA: 0x7FFD4E919180
        public void GetChallengeList(){} // RVA: 0x7FFD4E919180
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFD4E919180
        public void GetCloudStorageData(){} // RVA: 0x7FFD4E919180
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFD4E919180
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFD4E919180
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFD4E919180
        public void GetDataStore(){} // RVA: 0x7FFD4E919180
        public void GetDestinationList(){} // RVA: 0x7FFD4E919180
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFD4E919180
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFD4E919180
        public void GetInstalledApplicationList(){} // RVA: 0x7FFD4E919180
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFD4E919180
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFD4E919180
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFD4E919180
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFD4E919180
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFD4E919180
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFD4E919180
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFD4E341320
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFD4E919180
        public void GetLeaderboardList(){} // RVA: 0x7FFD4E919180
        public void GetLinkedAccountList(){} // RVA: 0x7FFD4E919180
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFD4E919180
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFD4E919180
        public void GetLivestreamingStatus(){} // RVA: 0x7FFD4E919180
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFD4E919180
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFD4E919180
        public void GetMatchmakingBrowseResult(){} // RVA: 0x7FFD4E919180
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFD4E919180
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFD4E919180
        public void GetMatchmakingStats(){} // RVA: 0x7FFD4E919180
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFD4E919180
        public void GetNetSyncConnection(){} // RVA: 0x7FFD4E919180
        public void GetNetSyncSessionList(){} // RVA: 0x7FFD4E919180
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFD4E919180
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFD4E919180
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFD4E919180
        public void GetOrgScopedID(){} // RVA: 0x7FFD4E919180
        public void GetParty(){} // RVA: 0x7FFD4E919180
        public void GetPartyID(){} // RVA: 0x7FFD4E919180
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFD4E919180
        public void GetPidList(){} // RVA: 0x7FFD4E919180
        public void GetProductList(){} // RVA: 0x7FFD4E919180
        public void GetPurchase(){} // RVA: 0x7FFD4E919180
        public void GetPurchaseList(){} // RVA: 0x7FFD4E919180
        public void GetRejoinDialogResult(){} // RVA: 0x7FFD4E919180
        public void GetRoom(){} // RVA: 0x7FFD4E919180
        public void GetRoomInviteNotification(){} // RVA: 0x7FFD4E919180
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFD4E919180
        public void GetRoomList(){} // RVA: 0x7FFD4E919180
        public void GetSdkAccountList(){} // RVA: 0x7FFD4E919180
        public void GetSendInvitesResult(){} // RVA: 0x7FFD4E919180
        public void GetShareMediaResult(){} // RVA: 0x7FFD4E919180
        public void GetString(){} // RVA: 0x7FFD4E919180
        public void GetSystemVoipState(){} // RVA: 0x7FFD4E919180
        public void GetUser(){} // RVA: 0x7FFD4E919180
        public void GetUserAndRoomList(){} // RVA: 0x7FFD4E919180
        public void GetUserCapabilityList(){} // RVA: 0x7FFD4E919180
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFD4E919180
        public void GetUserList(){} // RVA: 0x7FFD4E919180
        public void GetUserProof(){} // RVA: 0x7FFD4E919180
        public void GetUserReportID(){} // RVA: 0x7FFD4E919180
        public void ParseMessageHandle(){} // RVA: 0x7FFD53C6CCC0
        public void PopMessage(){} // RVA: 0x7FFD53C6F4A0
        public void set_HandleExtraMessageTypes(){} // RVA: 0x7FFD53C6F650
        public void get_HandleExtraMessageTypes(){} // RVA: 0x7FFD53C6F6F0
    }

    public class Message`1 : Message
    {
        public T Data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090BF0
        public void get_Data(){} // RVA: 0x7FFD4E2ADC40
        public void GetDataFromMessage(){} // RVA: 0x7FFD4E2ADC40
    }

    public class MultiplayerErrorOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C79EC0
        public void SetErrorKey(){} // RVA: 0x7FFD53C79F70
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C7A030
    }

    public class NetSyncOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C7A120
        public void SetVoipGroup(){} // RVA: 0x7FFD53C7A1D0
        public void SetVoipStreamDefault(){} // RVA: 0x7FFD53C7A310
        public void SetZoneId(){} // RVA: 0x7FFD53C7A3D0
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C7A510
    }

    public class Packet : Object
    {
        public ulong SenderID; // 0x10
        public UIntPtr Size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C7A600
        public void ReadBytes(){} // RVA: 0x7FFD53C7A6D0
        public void get_SenderID(){} // RVA: 0x7FFD53C7A830
        public void get_Size(){} // RVA: 0x7FFD4E35C380
        public void get_Policy(){} // RVA: 0x7FFD53C7A8F0
        public void Finalize(){} // RVA: 0x7FFD53C7A9B0
        public void Dispose(){} // RVA: 0x7FFD53C7AAD0
    }

    public class PlatformInternal : Object
    {
        // ── Methods ──
        public void CrashApplication(){} // RVA: 0x7FFD53C92720
        public void ParseMessageHandle(){} // RVA: 0x7FFD53C927C0
        public void InitializeStandaloneAsync(){} // RVA: 0x7FFD53C93520
    }

    public class PlatformSettings : ScriptableObject
    {
        public string AppID; // 0x18
        public string MobileAppID; // 0x20
        public bool UseStandalonePlatform; // 0x28
        public Oculus.Platform.PlatformSettings Instance;

        // ── Methods ──
        public void get_AppID(){} // RVA: 0x7FFD53C93A60
        public void set_AppID(){} // RVA: 0x7FFD53C93A80
        public void get_MobileAppID(){} // RVA: 0x7FFD53C93AF0
        public void set_MobileAppID(){} // RVA: 0x7FFD53C93B10
        public void get_UseStandalonePlatform(){} // RVA: 0x7FFD53C93B80
        public void set_UseStandalonePlatform(){} // RVA: 0x7FFD53C93BA0
        public void get_Instance(){} // RVA: 0x7FFD53C93BD0
        public void set_Instance(){} // RVA: 0x7FFD53C93EA0
        public void .ctor(){} // RVA: 0x7FFD53C93F40
    }

    public class Request : Object
    {
        public s RequestID; // 0x10
        public ulong <RequestID>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4ECB20D0
        public void get_RequestID(){} // RVA: 0x7FFD4E3447C0
        public void set_RequestID(){} // RVA: 0x7FFD4ECB20D0
        public void OnComplete(){} // RVA: 0x7FFD53C94040
        public void HandleMessage(){} // RVA: 0x7FFD53C940F0
        public void RunCallbacks(){} // RVA: 0x7FFD53C94170
    }

    public class Request`1 : Request
    {
        public Callback<T> callback_;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090BF0
        public void OnComplete(){} // RVA: 0x7FFD4E078F40
        public void HandleMessage(){} // RVA: 0x7FFD4E090A40
    }

    public class RichPresenceOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C942C0
        public void SetApiName(){} // RVA: 0x7FFD53C94370
        public void SetCurrentCapacity(){} // RVA: 0x7FFD53C944B0
        public void SetDeeplinkMessageOverride(){} // RVA: 0x7FFD53C94570
        public void SetEndTime(){} // RVA: 0x7FFD53C946B0
        public void SetExtraContext(){} // RVA: 0x7FFD53C947C0
        public void SetInstanceId(){} // RVA: 0x7FFD53C94880
        public void SetIsIdle(){} // RVA: 0x7FFD53C949C0
        public void SetIsJoinable(){} // RVA: 0x7FFD53C94A80
        public void SetMaxCapacity(){} // RVA: 0x7FFD53C94B40
        public void SetStartTime(){} // RVA: 0x7FFD53C94C00
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C94D10
    }

    public class RoomOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C94E00
        public void SetDataStore(){} // RVA: 0x7FFD53C94EB0
        public void ClearDataStore(){} // RVA: 0x7FFD53C95020
        public void SetExcludeRecentlyMet(){} // RVA: 0x7FFD53C950E0
        public void SetMaxUserResults(){} // RVA: 0x7FFD53C951A0
        public void SetOrdering(){} // RVA: 0x7FFD53C95260
        public void SetRecentlyMetTimeWindow(){} // RVA: 0x7FFD53C95320
        public void SetRoomId(){} // RVA: 0x7FFD53C953E0
        public void SetTurnOffUpdates(){} // RVA: 0x7FFD53C954B0
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C95570
    }

    public class RosterOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C95660
        public void AddSuggestedUser(){} // RVA: 0x7FFD53C95710
        public void ClearSuggestedUsers(){} // RVA: 0x7FFD53C957E0
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C958A0
    }

    public class StandalonePlatform : Object
    {
        // ── Methods ──
        public void InitializeInEditor(){} // RVA: 0x7FFD53C95990
        public void AsyncInitialize(){} // RVA: 0x7FFD53C95B10
        public void AsyncInitializeWithAccessTokenAndOptions(){} // RVA: 0x7FFD53C95CE0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class StandalonePlatformSettings : Object
    {
        public object OculusPlatformTestUserEmail;
        public object OculusPlatformTestUserPassword;
        public object OculusPlatformTestUserAccessToken;

        // ── Methods ──
        public void get_OculusPlatformTestUserEmail(){} // RVA: 0x7FFD53C96020
        public void set_OculusPlatformTestUserEmail(){} // RVA: 0x7FFD4E341310
        public void get_OculusPlatformTestUserPassword(){} // RVA: 0x7FFD53C96060
        public void set_OculusPlatformTestUserPassword(){} // RVA: 0x7FFD4E341310
        public void get_OculusPlatformTestUserAccessToken(){} // RVA: 0x7FFD53C960A0
        public void set_OculusPlatformTestUserAccessToken(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UserOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C960E0
        public void SetMaxUsers(){} // RVA: 0x7FFD53C96190
        public void AddServiceProvider(){} // RVA: 0x7FFD53C96250
        public void ClearServiceProviders(){} // RVA: 0x7FFD53C96310
        public void SetTimeWindow(){} // RVA: 0x7FFD53C963D0
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C96490
    }

    public class VoipAudioSourceHiLevel : MonoBehaviour
    {
        public int senderID; // 0x20
        public UnityEngine.AudioSource audioSource; // 0x28
        public float peakAmplitude; // 0x30
        public Oculus.Platform.IVoipPCMSource pcmSource; // 0x38
        public int audioSystemPlaybackFrequency;
        public bool verboseLogging; // 0x4

        // ── Methods ──
        public void set_senderID(){} // RVA: 0x7FFD53C96580
        public void Stop(){} // RVA: 0x7FFD4E341310
        public void SampleRateToEnum(){} // RVA: 0x7FFD53C965E0
        public void Awake(){} // RVA: 0x7FFD53C96610
        public void Start(){} // RVA: 0x7FFD53C96B50
        public void CreatePCMSource(){} // RVA: 0x7FFD53C96BB0
        public void MSToElements(){} // RVA: 0x7FFD53C96C40
        public void Update(){} // RVA: 0x7FFD53C96CA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VoipOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C97570
        public void SetBitrateForNewConnections(){} // RVA: 0x7FFD53C97620
        public void SetCreateNewConnectionUseDtx(){} // RVA: 0x7FFD53C976E0
        public void op_Explicit(){} // RVA: 0x7FFD53C38EF0
        public void Finalize(){} // RVA: 0x7FFD53C977A0
    }

    public class VoipPCMSourceNative : Object
    {
        public ulong senderID; // 0x10

        // ── Methods ──
        public void GetPCM(){} // RVA: 0x7FFD53C97890
        public void SetSenderID(){} // RVA: 0x7FFD4F83EFB0
        public void PeekSizeElements(){} // RVA: 0x7FFD53C97970
        public void Update(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class WindowsPlatform : Object
    {
        // ── Methods ──
        public void CPPLogCallback(){} // RVA: 0x7FFD53C97A30
        public void getCallbackPointer(){} // RVA: 0x7FFD4E919180
        public void Initialize(){} // RVA: 0x7FFD53C97B70
        public void AsyncInitialize(){} // RVA: 0x7FFD53C97CA0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}