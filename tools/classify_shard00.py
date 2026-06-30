import json

SKIP = {
    'Component.get_gameObject','Component.get_transform','GetComponent',
    'Component.GetComponent','Component.GetComponentInParent','Component.GetComponentInChildren',
    'GameObject.GetComponent','GameObject.get_transform','GameObject.get_activeInHierarchy',
    'GameObject.SetActive','GameObject.GetComponentInChildren',
}
LOG_NOISE = {
    'VRCLogger.get_GlobalLogger','VRCLogger.LogError','ZLoggerInterpolatedStringHandler..ctor',
    'ZLoggerInterpolatedStringHandler.AppendLiteral','ZLoggerInterpolatedStringHandler.AppendFormatted',
    'ThrowHelper.ThrowNullReferenceException','ThrowHelper.ThrowArgumentOutOfRange_IndexException',
}

data = json.load(open('D:/Project/vrchat-il2cpp-re/output/ct_shards/shard_00.json', encoding='utf-8'))

results = {}

def filtered(entry):
    return [c for c in entry.get('calls', []) if c not in SKIP and c not in LOG_NOISE]

def has(sig, *substrings):
    return any(any(s in c for s in substrings) for c in sig)

for e in data:
    obf = e['obf']
    if obf in results:
        continue
    calls_all = set(e.get('calls', []))
    sig = filtered(e)

    name = None
    confidence = None
    why = None

    if has(sig, 'DOTween.Sequence') and has(sig, 'ShortcutExtensions.DO', 'Sequence.DoInsert'):
        name = 'TweenSequenceController'
        confidence = 'high'
        why = 'DOTween.Sequence + TweenExtensions.Kill + ShortcutExtensions.DOScale'
    elif has(sig, 'DOVerticalNormalizedPos') and has(sig, 'LayoutRebuilder'):
        name = 'TweenScrollViewController'
        confidence = 'high'
        why = 'DOTweenModuleUI.DOVerticalNormalizedPos + LayoutRebuilder.ForceRebuildLayoutImmediate'
    elif has(sig, 'DOSizeDelta') and has(sig, 'Selectable.get_image'):
        name = 'CollapsiblePanelTweenController'
        confidence = 'high'
        why = 'DOTweenModuleUI.DOSizeDelta + Selectable.get_image + DOTween.Kill'
    elif has(sig, 'SteamFriends.SetRichPresence', 'ActivityAssets.SetLargeImage', 'ActivitySecrets.SetJoin'):
        name = 'SteamRichPresenceController'
        confidence = 'high'
        why = 'SteamFriends.SetRichPresence + ActivityAssets.SetLargeImage + ActivitySecrets.SetJoin'
    elif has(sig, 'MediaPlayer', 'SyncVideoStream') and has(sig, 'FlatBufferBuilder'):
        name = 'VideoSyncFlatBufferSerializer'
        confidence = 'high'
        why = 'MediaPlayer.set_PlaybackRate + FlatBufferBuilder.PutFloat + SyncVideoStream.AddSyncMinutes'
    elif has(sig, 'LineRenderer.set_startWidth', 'LineRenderer.set_endWidth') and has(sig, 'Shader.Find'):
        name = 'LineRendererBuilder'
        confidence = 'high'
        why = 'LineRenderer.set_startWidth/endWidth + Shader.Find + Material.set_color'
    elif 'Camera.set_layerCullDistances' in calls_all and 'Camera.get_farClipPlane' in calls_all:
        name = 'CameraCullingSetup'
        confidence = 'high'
        why = 'Camera.set_layerCullDistances + Camera.get_farClipPlane + Camera.set_allowMSAA'
    elif 'Camera.set_cullingMask' in calls_all and 'Camera.set_fieldOfView' in calls_all:
        name = 'CameraViewConfigurator'
        confidence = 'medium'
        why = 'Camera.set_cullingMask + Camera.set_fieldOfView'
    elif has(sig, 'ApiAvatarModeration.SendModeration', 'ApiPlayerModeration.DeleteModeration'):
        name = 'AvatarModerationController'
        confidence = 'high'
        why = 'ApiAvatarModeration.SendModeration + ApiPlayerModeration.DeleteModeration'
    elif has(sig, 'StencilMaterial.Add', 'StencilMaterial.Remove') and has(sig, 'VertexHelper.AddVert'):
        name = 'StencilMaskMeshModifier'
        confidence = 'high'
        why = 'VertexHelper.AddVert + StencilMaterial.Add/Remove + MaskUtilities.GetStencilDepth'
    elif has(sig, 'Protocol18', 'Protocol.Deserialize') and has(sig, 'EventData', 'ParameterDictionary'):
        name = 'PhotonEventDeserializer'
        confidence = 'high'
        why = 'Protocol18..ctor + Protocol.Deserialize + EventData.get_CustomData'
    elif has(sig, 'VRCUdonSyncTypeConverter', 'DecodeParameters8'):
        name = 'UdonSyncTypeSerializer'
        confidence = 'high'
        why = 'VRCUdonSyncTypeConverter.TypeToUdonType + DecodeParameters8.get_SerializationHashes'
    elif has(sig, 'CollisionScene', 'CollisionBroadphase'):
        name = 'CollisionSceneUpdater'
        confidence = 'high'
        why = 'CollisionBroadphase_HybridSAP..ctor + CollisionScene.UpdateAndSchedule'
    elif 'JsonConvert.DeserializeObject' in calls_all and 'PlayerPrefs.HasKey' in calls_all:
        name = 'PlayerPrefsJsonConfigProvider'
        confidence = 'high'
        why = 'JsonConvert.DeserializeObject + PlayerPrefs.HasKey + PlayerPrefs.SetInt'
    elif has(sig, 'VRCData.') and 'JsonConvert.DeserializeObject' in calls_all:
        name = 'VRCDataJsonDeserializer'
        confidence = 'medium'
        why = 'VRCData method + JsonConvert.DeserializeObject'
    elif has(sig, 'Caching.ClearCachedVersions', 'Caching.ClearAllCachedVersions'):
        name = 'AssetBundleCacheManager'
        confidence = 'high'
        why = 'Caching.ClearCachedVersions + ApiAvatar.GetAssetUrl + ApiWorld.get_IsLocal'
    elif has(sig, 'AvatarPerformanceStats') and has(sig, 'Animator.StringToHash', 'Animator.SetFloatID'):
        name = 'AvatarPerformanceStatsUpdater'
        confidence = 'high'
        why = 'AvatarPerformanceStats.Reset + Animator.SetFloatID + Material.set_renderQueue'
    elif has(sig, 'PlayerDataTypeUnion'):
        name = 'PlayerDataTypeUnionDeserializer'
        confidence = 'high'
        why = 'PlayerDataTypeUnion.AsWrappedBool/AsWrappedByte + VRCPlayerApi.GetPlayerId'
    elif has(sig, 'SHA256Managed', 'HashAlgorithm.CaptureHashCodeAndReinitialize'):
        name = 'HashComputeHelper'
        confidence = 'medium'
        why = 'SHA256Managed..ctor + HashAlgorithm.CaptureHashCodeAndReinitialize'
    elif has(sig, 'MaskAnnotation.Init', 'MaskAnnotationController.DrawLater'):
        name = 'BodyTrackingMaskAnnotationController'
        confidence = 'high'
        why = 'MaskAnnotation.Init + MaskAnnotationController.DrawLater + Transform.set_localEulerAngles'
    elif has(sig, 'Animator.GetBoneTransform', 'Animator.get_isHuman'):
        name = 'HumanoidAnimatorBinder'
        confidence = 'high'
        why = 'Animator.GetBoneTransform + Animator.get_isHuman'
    elif has(sig, 'Animator.get_isInitialized') and has(sig, 'APIGroupAnnouncement.SetLastPostReadAt'):
        name = 'GroupAnnouncementReadTracker'
        confidence = 'medium'
        why = 'APIGroupAnnouncement.SetLastPostReadAt + Animator.SetIntegerString'
    elif has(sig, 'RenderTexture.Release') and has(sig, 'Camera.get_aspect'):
        name = 'RenderTextureCameraController'
        confidence = 'medium'
        why = 'RenderTexture.Release + Camera.get_aspect + Transform.get_localEulerAngles'
    elif has(sig, 'Material.SetTextureScaleImpl', 'Material.SetTextureOffsetImpl') and has(sig, 'Shader.PropertyToID'):
        name = 'MaterialTextureScrollController'
        confidence = 'high'
        why = 'Material.SetTextureScaleImpl + Material.SetTextureOffsetImpl + Shader.PropertyToID'
    elif has(sig, 'Material.SetTextureOffsetImpl') and has(sig, 'Mathf.PingPong'):
        name = 'MaterialTexturePingPongAnimator'
        confidence = 'high'
        why = 'Mathf.PingPong + Material.SetTextureOffsetImpl + Shader.PropertyToID'
    elif has(sig, 'Material.SetIntImpl') and has(sig, 'ListPool.Get') and has(sig, 'GameObject.GetComponentsInChildren'):
        name = 'UdonMaterialPropertySetter'
        confidence = 'medium'
        why = 'Material.SetIntImpl + GetComponentsInChildren + ListPool.Get'
    elif has(sig, 'ColorUtility.DoTryParseHtmlColor', 'ColorUtility.ToHtmlStringRGB') and has(sig, 'KeyboardData'):
        name = 'ColorPickerHexInputController'
        confidence = 'high'
        why = 'ColorUtility.DoTryParseHtmlColor + ColorUtility.ToHtmlStringRGB + KeyboardData..ctor'
    elif has(sig, 'SceneManager.get_sceneCountInBuildSettings', 'SceneUtility.GetScenePathByBuildIndex'):
        name = 'SceneListBuilder'
        confidence = 'high'
        why = 'SceneManager.get_sceneCountInBuildSettings + SceneUtility.GetScenePathByBuildIndex'
    elif has(sig, 'ScrollRect.OnBeginDrag', 'ScrollRect.UpdateBounds', 'ScrollRect.LateUpdate'):
        name = 'NestedScrollRectHandler'
        confidence = 'high'
        why = 'ScrollRect.OnBeginDrag + ScrollRect.UpdateBounds + ExecuteEvents.ExecuteHierarchy'
    elif has(sig, 'Transform.LookAt') and has(sig, 'Material.set_renderQueue'):
        name = 'BillboardMaterialController'
        confidence = 'medium'
        why = 'Transform.LookAt + Material.set_renderQueue'
    elif has(sig, 'Shader.SetGlobalFloat', 'Shader.SetGlobalInteger'):
        name = 'GlobalShaderController'
        confidence = 'high'
        why = 'Shader.SetGlobalFloat + Shader.SetGlobalInteger'
    elif has(sig, 'Material.SetFloatImpl') and has(sig, 'VRC_SceneDescriptor.get_Instance'):
        name = 'SceneDescriptorMaterialController'
        confidence = 'medium'
        why = 'Material.SetFloatImpl + VRC_SceneDescriptor.get_Instance'
    elif has(sig, 'InputField.SetText') and has(sig, 'Dropdown.ClearOptions', 'Dropdown.Set'):
        name = 'DropdownInputFieldBinder'
        confidence = 'high'
        why = 'InputField.SetText + Dropdown.ClearOptions + Dropdown.Set'
    elif has(sig, 'CanvasGroup.set_alpha', 'CanvasGroup.set_interactable', 'CanvasGroup.set_blocksRaycasts'):
        name = 'CanvasGroupVisibilityController'
        confidence = 'high'
        why = 'CanvasGroup.set_alpha + set_interactable + set_blocksRaycasts'
    elif has(sig, 'ColorUtility.TryParseHtmlString') and has(sig, 'Animator.StringToHash') and has(sig, 'StyleElement.'):
        name = 'StyleElementAnimatorBinder'
        confidence = 'medium'
        why = 'ColorUtility.TryParseHtmlString + Animator.StringToHash + StyleElement method'
    elif has(sig, 'Transform.SetAsLastSibling') and has(sig, 'UnityEvent.AddListener'):
        name = 'SiblingOrderButtonController'
        confidence = 'medium'
        why = 'Transform.SetAsLastSibling + UnityEvent.AddListener'
    elif has(sig, 'SteamManager.') and not has(sig, 'SteamFriends'):
        name = 'SteamManagerHelper'
        confidence = 'medium'
        why = 'SteamManager method call'
    elif has(sig, 'VRCDynamicsScheduler.add_OnFrameComplete') and has(sig, 'UnityEvent.AddListener'):
        name = 'DynamicsFrameCompleteHandler'
        confidence = 'medium'
        why = 'VRCDynamicsScheduler.add_OnFrameComplete + UnityEvent.AddListener'
    elif has(sig, 'RawImage.set_texture') and has(sig, 'AspectRatioFitter.UpdateRect'):
        name = 'AspectFittedRawImageController'
        confidence = 'high'
        why = 'RawImage.set_texture + AspectRatioFitter.UpdateRect'
    elif has(sig, 'AudioSource.PlayHelper') and not has(sig, 'Microphone'):
        name = 'AudioSourcePlaybackController'
        confidence = 'medium'
        why = 'AudioSource.PlayHelper'
    elif has(sig, 'LayerMask.NameToLayer') and has(sig, 'Tools.SetLayerRecursivelyExceptMask'):
        name = 'LayerMaskRecursiveSetup'
        confidence = 'high'
        why = 'LayerMask.NameToLayer + Tools.SetLayerRecursivelyExceptMask'
    elif has(sig, 'PointerEventData.get_pressEventCamera') and has(sig, 'Component.GetComponent'):
        name = 'PointerPressEventHandler'
        confidence = 'medium'
        why = 'PointerEventData.get_pressEventCamera'
    elif has(sig, 'LayoutGroup.get_rectTransform') and has(sig, 'UiInputField.'):
        name = 'LayoutGroupInputFieldBinder'
        confidence = 'medium'
        why = 'LayoutGroup.get_rectTransform + UiInputField method'
    elif has(sig, 'RectTransform.set_sizeDelta') and has(sig, 'Graphic.get_rectTransform') and has(sig, 'SynchronizationContext'):
        name = 'AsyncRectTransformResizer'
        confidence = 'medium'
        why = 'RectTransform.set_sizeDelta + Graphic.get_rectTransform + SynchronizationContext'
    elif has(sig, 'TimeSpanFormat.Format') and has(sig, 'LayoutRebuilder.MarkLayoutForRebuild'):
        name = 'QueueTimerDisplayController'
        confidence = 'high'
        why = 'TimeSpanFormat.Format + LayoutRebuilder.MarkLayoutForRebuild'
    elif has(sig, 'ApiPrint.GetPrint') and has(sig, 'StyleEngine.'):
        name = 'PrintStyleElementBinder'
        confidence = 'medium'
        why = 'ApiPrint.GetPrint + StyleEngine method'
    elif has(sig, 'Transform.get_forward') and has(sig, 'Input.GetKeyInt'):
        name = 'KeyboardInputDirectionalHandler'
        confidence = 'medium'
        why = 'Transform.get_forward + Input.GetKeyInt'
    elif has(sig, 'UnityWebRequest.get_error'):
        name = 'WebRequestErrorHandler'
        confidence = 'medium'
        why = 'UnityWebRequest.get_error'
    elif has(sig, 'Quaternion.LookRotation') and has(sig, 'Material.SetTextureImpl') and has(sig, 'Shader.Find'):
        name = 'WorldFacingMaterialController'
        confidence = 'medium'
        why = 'Quaternion.LookRotation + Material.SetTextureImpl + Shader.Find'
    elif has(sig, 'Transform.SetSiblingIndex') and not has(sig, 'UnityEvent'):
        name = 'SiblingIndexSorter'
        confidence = 'medium'
        why = 'Transform.SetSiblingIndex + GameObject.SetActive'

    if name:
        results[obf] = {'name': name, 'confidence': confidence, 'why': why}

print(f"Named: {len(results)} / {len(set(e['obf'] for e in data))} unique obf keys")

out_path = 'D:/Project/vrchat-il2cpp-re/output/ct_results/shard_00.json'
with open(out_path, 'w', encoding='utf-8') as f:
    json.dump(results, f, ensure_ascii=False, indent=1)
print("Written to", out_path)
