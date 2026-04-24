#!/usr/bin/env python3
"""Add manually extracted VRChat-specific names from deep reading of source files."""
import json, sys
sys.stdout.reconfigure(encoding='utf-8')

BASE = "D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools"

vocab = json.load(open(f'{BASE}/output/master_vocabulary.json', 'r', encoding='utf-8'))
names = set(vocab['names'])

# VRCPlayerApi methods (from vrcplayerapi.hpp static fields)
vrcplayerapi_methods = [
    'IsMaster', 'IsInstanceOwner', 'IsModerator', 'IsSuper',
    'SetAnimatorBool', 'ClaimNetworkControl', 'GetLookRay',
    'IsGrounded', 'GetPlayerId', 'GetPlayerByGameObject', 'GetPlayerById',
    'IsOwner', 'TakeOwnership', 'GetTrackingData', 'GetBoneTransform',
    'GetBonePosition', 'GetBoneRotation', 'GetPickupInHand',
    'PlayHapticEventInHand', 'TeleportTo', 'TeleportToOrientation',
    'TeleportToOrientationLerp', 'Respawn', 'RespawnWithIndex',
    'EnablePickups', 'SetNamePlateColor', 'RestoreNamePlateColor',
    'SetNamePlateVisibility', 'RestoreNamePlateVisibility',
    'SetPlayerTag', 'GetPlayerTag', 'GetPlayersWithTag', 'ClearPlayerTags',
    'SetInvisibleToTagged', 'SetInvisibleToUntagged',
    'SetSilencedToTagged', 'SetSilencedToUntagged',
    'ClearInvisible', 'ClearSilence',
    'SetRunSpeed', 'SetWalkSpeed', 'SetStrafeSpeed', 'SetJumpImpulse',
    'SetGravityStrength', 'GetRunSpeed', 'GetWalkSpeed', 'GetStrafeSpeed',
    'GetJumpImpulse', 'GetGravityStrength',
    'SetVoiceGain', 'SetVoiceDistanceNear', 'SetVoiceDistanceFar',
    'SetVoiceVolumetricRadius', 'SetVoiceLowpass',
    'SetAvatarAudioGain', 'SetAvatarAudioFarRadius',
    'SetAvatarAudioNearRadius', 'SetAvatarAudioVolumetricRadius',
    'SetAvatarAudioForceSpatial', 'SetAvatarAudioCustomCurve',
    'CombatSetup', 'CombatSetMaxHitpoints', 'CombatSetCurrentHitpoints',
    'CombatGetCurrentHitpoints', 'CombatSetRespawn', 'CombatSetDamageGraphic',
    'CombatGetDestructible', 'IsUserInVR', 'UseLegacyLocomotion',
    'UseAttachedStation', 'PushAnimations', 'PopAnimations',
    'Immobilize', 'SetVelocity', 'GetVelocity', 'GetPosition', 'GetRotation',
    'IsPlayerGrounded', 'isMaster',
]

# APIUser fields (from apiuser.hpp)
apiuser_fields = [
    'blob', 'displayName', 'username', 'bio', 'bioLinks',
    'location', 'avatarId', 'fallbackId', 'hasEmail', 'hasBirthday',
    'isFriend', 'friendKey', 'friendRequestStatus', 'lastLogin', 'dateJoined',
    'developerType', 'acceptedTosVersion', 'currentAvatarImageUrl',
    'currentAvatarThumbnailImageUrl', 'authToken', 'emailVerified',
    'hasPendingEmail', 'obfuscatedPendingEmail', 'friendIDs',
    'currentAvatarAssetUrl', 'steamDetails', 'worldId', 'instanceId',
    'obfuscatedEmail', 'unsubscribe', 'hasLoggedInFromClient',
    'pastDisplayNames', 'homeLocation', 'tags', 'status', 'statusDescription',
    'statusHistory', 'state', 'allowAvatarCopying', 'userIcon',
    'profilePicOverride', 'lastPlatform', 'twoFactorAuthEnabled',
    'twoFactorAuthMethods', 'languageTagsDictionary',
    'languagesDisplayNames', 'languagesShortNames',
    'statusDefaultDescriptions', 'currentUser',
    'IsFriendsWith', 'hasTag', 'CurrentUser',
    'last_platform', 'DeveloperType',
]

# ApiAvatar fields (from apiavatar.hpp)
apiavatar_fields = [
    'imageUrl', 'authorName', 'authorId', 'assetUrl', 'description',
    'unityPackageUrl', 'thumbnailImageUrl', 'version', 'releaseStatus',
    'featured', 'unityPackageUpdated', 'unityVersion', 'apiVersion',
    'totalLikes', 'totalVisits', 'createdAt', 'updatedAt',
    'localAvatars', 'minLoadableVersion',
]

# ApiWorld fields (from apiworld.hpp)
apiworld_fields = [
    'capacity', 'occupants', 'publicOccupants', 'privateOccupants',
    'latestAssetVersion', 'publicationDate', 'worldInstances',
    'instances', 'organization', 'shouldAddToAuthor', 'favoriteId',
    'isCurated', 'localWorlds',
]

# VRC Event types (PascalCase C# enum values)
vrc_event_types = [
    'MeshVisibility', 'AnimationFloat', 'AnimationBool', 'AnimationTrigger',
    'AudioTrigger', 'PlayAnimation', 'SendMessage', 'SetParticlePlaying',
    'TeleportPlayer', 'RunConsoleCommand', 'SetGameObjectActive',
    'SetWebPanelUri', 'SetWebPanelVolume', 'SpawnObject', 'SendRPC',
    'ActivateCustomTrigger', 'DestroyObject', 'SetLayer', 'SetMaterial',
    'AddHealth', 'AddDamage', 'SetComponentActive', 'AnimationInt',
    'AnimationIntAdd', 'AnimationIntSubtract', 'AnimationIntMultiply',
    'AnimationIntDivide', 'AddVelocity', 'AddAngularVelocity',
    'SetAngularVelocity', 'AddForce', 'SetUIText', 'CallUdonMethod',
]

# HumanBodyBones enum values
human_bones = [
    'Hips', 'LeftUpperLeg', 'RightUpperLeg', 'LeftLowerLeg', 'RightLowerLeg',
    'LeftFoot', 'RightFoot', 'Spine', 'Chest', 'Neck', 'Head',
    'LeftShoulder', 'RightShoulder', 'LeftUpperArm', 'RightUpperArm',
    'LeftLowerArm', 'RightLowerArm', 'LeftHand', 'RightHand',
    'LeftToes', 'RightToes', 'LeftEye', 'RightEye', 'Jaw',
    'LeftThumbProximal', 'LeftThumbIntermediate', 'LeftThumbDistal',
    'LeftIndexProximal', 'LeftIndexIntermediate', 'LeftIndexDistal',
    'LeftMiddleProximal', 'LeftMiddleIntermediate', 'LeftMiddleDistal',
    'LeftRingProximal', 'LeftRingIntermediate', 'LeftRingDistal',
    'LeftLittleProximal', 'LeftLittleIntermediate', 'LeftLittleDistal',
    'RightThumbProximal', 'RightThumbIntermediate', 'RightThumbDistal',
    'RightIndexProximal', 'RightIndexIntermediate', 'RightIndexDistal',
    'RightMiddleProximal', 'RightMiddleIntermediate', 'RightMiddleDistal',
    'RightRingProximal', 'RightRingIntermediate', 'RightRingDistal',
    'RightLittleProximal', 'RightLittleIntermediate', 'RightLittleDistal',
    'UpperChest', 'LastBone', 'HumanBodyBones',
]

# Key VRChat class/type names confirmed from reading sources
vrc_types = [
    # API model vtable methods
    'ShouldCache', 'ShouldClearOnLevelLoad', 'GetLifeSpan',
    'SetApiFieldsFromJson', 'ReadField', 'WriteField', 'Clone',
    # Core VRC types
    'VRC_Core_AssetVersion', 'AssetVersion',
    'PipelineManager', 'ExpressionsMenu', 'VRCAvatarDescriptor',
    'VRC_MirrorReflection', 'VRC_Pickup', 'VRCPlayerApi',
    'VRC_EventHandler', 'VRC_EventLog', 'VRC_EventReplicator',
    'VRCTrackingManager', 'VRCUIManager', 'VRCUiPage', 'VRCUiPopupManager',
    'AssetBundleDownloadManager', 'ButtonClickedEvent', 'DynamicBone',
    'DynamicBoneCollider', 'HighlightsFX',
    'ModerationManager', 'PhotonPlayer', 'PlayerNameplate',
    'RoomManager', 'SliderSlideEvent', 'ToggleClickedEvent',
    'UdonSync', 'UIManagerImpl', 'UIVRCList', 'UserSelectionManager',
    'USpeaker', 'VRCPlayer', 'VRCUiManager',
    'FlatBufferNetworkSerializer', 'BinarySerializer',
    'ParameterSerialization', 'SceneEventHandlerAndInstantiator',
    'PortalInternal', 'PortalInternalDynamic',
    'GamelikeInputController', 'ImageThreeSlice', 'PlayerSelector',
    'PlayerNet', 'VRCNetworkBehaviour', 'VRCVrCamera',
    'UserCameraController', 'PageAvatar', 'PageUserInfo', 'PageWorldInfo',
    'SelectedUserMenuQM', 'VRC_SyncVideoPlayer',
    'QuickMenu', 'ActionMenuDriver', 'ActionMenuOpener',
    'VRCUiPopup', 'VRCInputManager', 'VRCMotionState',
    'VRCFlowManager', 'VRCApplicationSetup',
    'NetworkManager', 'PlayerManager',
    'ApiContainer', 'ApiModel', 'ApiCredentials',
    'ApiAvatar', 'ApiWorld', 'ApiWorldInstance', 'APIUser',
    'DataModel', 'IUser',
    'LoadBalancingClient', 'LoadBalancingPeer',
    'PhotonNetwork', 'PhotonPeer', 'ParameterDictionary',
    'RaiseEventOptions', 'SendOptions',
    'StructWrapper', 'Il2CppStructArray', 'Il2CppReferenceArray',
    'Il2CppArrayBase', 'Il2CppException',
    'Networking',
    # Additional types
    'AvatarPerformanceStats', 'AvatarPerformanceRating',
    'VRCUiContentButton', 'VRCUiPageTab',
    'NotificationManager', 'FriendsManager', 'FavoriteManager',
    'TrustRankSystem', 'ModerationSystem',
    'VRCAvatarManager', 'AvatarLoadingBar',
    'VRCInput', 'LocomotionInputController',
    'OVRInput', 'SteamVR_Actions',
    'VRC_StationInternal', 'VRC_Station',
    'VRC_Trigger', 'VRC_DataStorage',
    'VRC_VisualDamage', 'VRC_CombatSystem',
    'VRC_Interactable', 'VRC_ObjectSync',
    'VRC_SceneDescriptor', 'VRC_AvatarDescriptor',
    'VRC_AvatarPedestal', 'VRC_PlayerMods',
    'UdonBehaviour', 'UdonManager', 'UdonSyncMeta',
    # VRChat SDK namespaces
    'VRC.Core', 'VRC.SDKBase', 'VRC.SDK3',
    'VRC.SDKBase.Validation', 'VRC.SDKBase.Validation.Performance',
    'VRC.SDK3.Avatars.Components', 'VRC.SDK3.Avatars.ScriptableObjects',
    'VRC.SDK3.Components', 'VRC.SDK3.Video',
    'VRC.DataModel', 'VRC.DataModel.Core',
    'VRC.UI', 'VRC.UI.Core', 'VRC.UI.Elements',
    'VRC.Networking', 'VRC.Animation', 'VRC.Management',
    'VRC.UserCamera', 'VRCSDK2',
    # Photon namespaces
    'Photon.Pun', 'Photon.Realtime',
    'ExitGames.Client.Photon',
    # Il2Cpp/Unhollower
    'UnhollowerBaseLib', 'UnhollowerRuntimeLib',
    'MelonLoader', 'HarmonyLib',
    # Event/RPC infrastructure
    'VrcBroadcastType', 'VrcEventType', 'VrcTargetType', 'VrcEvent',
    'EventLogEntry', 'EventReplicator',
    'Always', 'AlwaysBufferOne', 'AlwaysUnbuffered',
    'Local', 'Master', 'Owner', 'Buffered', 'BufferedAll',
    # OdinSerializer (used by Udon)
    'OdinSerializer', 'ProperBitConverter',
]

# Additional names from AbyssClient UI code
abyss_ui_names = [
    'AvatarHiddenReasonLabel',
    'VRCUiManager',
    'Method_Internal_Static_get_VRCUiManager_PDM_0',
]

# Combine
all_additions = set()
for lst in [vrcplayerapi_methods, apiuser_fields, apiavatar_fields, apiworld_fields,
            vrc_event_types, human_bones, vrc_types, abyss_ui_names]:
    all_additions.update(lst)

new_additions = all_additions - names
print(f'Manual additions from deep reading: {len(all_additions)}')
print(f'Already in vocab: {len(all_additions) - len(new_additions)}')
print(f'New to add: {len(new_additions)}')

# Merge
merged = sorted(names | all_additions)
vocab['names'] = merged
vocab['unique_names'] = len(merged)
vocab['total_signatures'] = len(merged)
if 'stats' not in vocab:
    vocab['stats'] = {}
vocab['stats']['manual_additions'] = len(new_additions)
vocab['stats']['final_total'] = len(merged)

with open(f'{BASE}/output/master_vocabulary.json', 'w', encoding='utf-8') as f:
    json.dump(vocab, f, indent=2, ensure_ascii=False)

print(f'Updated vocabulary: {len(merged)} total names')
print()
print('New additions (sample):')
for n in sorted(new_additions)[:60]:
    print(f'  {n}')
if len(new_additions) > 60:
    print(f'  ... and {len(new_additions) - 60} more')
