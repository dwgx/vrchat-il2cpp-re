
import json, os, sys

INPUT  = r"D:\Project\vrchat-il2cpp-re\output\ct_shards\shard_02b.json"
OUTPUT = r"D:\Project\vrchat-il2cpp-re\output\ct_results\shard_02b.json"

def has(calls, name):
    return name in calls

def sw(calls, prefix):
    return any(c.startswith(prefix) for c in calls)

def classify(calls):
    # 1
    if has(calls,"Image.set_sprite") and has(calls,"GameObject.SetActive"):
        return {"name":"SpriteListItemController","confidence":"medium","why":"sets sprite and toggles active on list items"}
    # 2
    if has(calls,"MediaPlayer.get_Events") and (has(calls,"DOTween.Kill") or has(calls,"TweenManager.FilteredOperation")):
        return {"name":"MediaPlayerTweenHandler","confidence":"high","why":"manages DOTween lifecycle tied to MediaPlayer events"}
    # 3
    if has(calls,"ContentSizeFitter.SetDirty") and has(calls,"LayoutRebuilder.ForceRebuildLayoutImmediate"):
        return {"name":"ContentSizeFitterResizer","confidence":"high","why":"forces layout rebuild via ContentSizeFitter"}
    # 4
    if has(calls,"AndroidJavaClass._AndroidJavaClass"):
        return {"name":"AndroidJavaBridge","confidence":"medium","why":"instantiates AndroidJavaClass for platform bridging"}
    # 5
    if has(calls,"ApiWorldInstance.GetShortName") and has(calls,"Transform.get_position"):
        return {"name":"WorldInstancePositionTracker","confidence":"medium","why":"reads world instance name and transform position"}
    # 6
    if has(calls,"APIUser.VerifyStepUpAuthCode"):
        return {"name":"StepUpAuthVerifier","confidence":"high","why":"calls step-up auth code verification on APIUser"}
    # 7
    if has(calls,"CollisionBroadphase_HybridSAP..ctor") or has(calls,"CollisionBroadphase_HashGrid..ctor") or has(calls,"CollisionScene..ctor"):
        return {"name":"CollisionSceneInitializer","confidence":"high","why":"constructs collision broadphase and scene objects"}
    # 8
    if has(calls,"PlayerPrefs.HasKey") and has(calls,"JsonConvert.DeserializeObject") and has(calls,"PlayerPrefs.SetString"):
        return {"name":"JsonPlayerPrefsStore","confidence":"high","why":"serializes/deserializes JSON to PlayerPrefs"}
    # 9
    if has(calls,"RawImage.set_texture") and has(calls,"TweenExtensions.Kill"):
        return {"name":"RawImageTextureController","confidence":"high","why":"sets texture on RawImage and kills tweens"}
    # 10
    if (has(calls,"Toggle.Set") and has(calls,"UnityEvent.AddListener") and
        any(c in calls for c in ["Component.GetComponentInParent","Component.GetComponent","GameObject.GetComponentInParent","GameObject.GetComponent"])):
        return {"name":"ToggleButtonBinder","confidence":"medium","why":"binds toggle state and event listener"}
    # 11
    if has(calls,"Behaviour.set_enabled") and has(calls,"Toggle.Set") and not has(calls,"UnityEvent.AddListener"):
        return {"name":"ToggleDisplayBinder","confidence":"medium","why":"enables behaviour and sets toggle display state"}
    # 12
    if has(calls,"CancellationTokenSource.NotifyCancellation") or has(calls,"CancellationTokenSource.get_Token"):
        return {"name":"AsyncCancellationController","confidence":"medium","why":"manages CancellationToken lifecycle"}
    # 13
    if has(calls,"Transform.GetEnumerator") and has(calls,"Unmarshal.UnmarshalUnityObject"):
        return {"name":"TransformChildUnmarshaller","confidence":"medium","why":"iterates transform children and unmarshals Unity objects"}
    # 14
    if sw(calls,"MainMenuPlacementData.") and has(calls,"Transform.get_up"):
        return {"name":"MainMenuPlacementHelper","confidence":"medium","why":"reads placement data and uses transform up vector"}
    # 15
    if has(calls,"OVRInput.GetResolvedButton"):
        return {"name":"OvrButtonStateController","confidence":"high","why":"resolves OVR controller button input"}
    # 16
    if has(calls,"Shader.PropertyToID") and has(calls,"Material.SetTextureOffsetImpl"):
        return {"name":"MaterialTextureOffsetUpdater","confidence":"high","why":"updates material texture offset via shader property"}
    # 17
    if has(calls,"Selectable.set_interactable"):
        return {"name":"SelectableInteractivityController","confidence":"medium","why":"controls interactable state on UI Selectable"}
    # 18
    if has(calls,"Logger.DescribeCategory") and has(calls,"Logger.EnableCategory") and has(calls,"APIUser.get_hasModerationPowers"):
        return {"name":"ModerationLogCategoryController","confidence":"high","why":"enables log categories conditioned on moderation power"}
    # 19
    if sw(calls,"SteamManager.") and has(calls,"PlayerPrefs.SetString"):
        return {"name":"SteamSettingsPersistor","confidence":"medium","why":"persists Steam-related settings to PlayerPrefs"}
    # 20
    if sw(calls,"VRCData.") and has(calls,"JsonConvert.DeserializeObject"):
        return {"name":"VrcDataDeserializer","confidence":"high","why":"deserializes JSON via VRCData and JsonConvert"}
    # 21
    if sw(calls,"StyleEngine.") and has(calls,"Behaviour.set_enabled"):
        return {"name":"UIStyleEngineController","confidence":"medium","why":"drives StyleEngine and toggles behaviour enabled"}
    # 22
    if has(calls,"DOTween.Kill") and has(calls,"UnityEvent.AddListener") and not has(calls,"MediaPlayer.get_Events"):
        return {"name":"TweenEventBinder","confidence":"medium","why":"kills DOTween and wires UnityEvent listeners"}
    return None

with open(INPUT, encoding="utf-8") as f:
    data = json.load(f)

result = {}
for entry in data:
    obf = entry["obf"]
    if obf in result:
        continue
    calls = entry.get("calls", [])
    r = classify(calls)
    if r:
        result[obf] = r

os.makedirs(os.path.dirname(OUTPUT), exist_ok=True)
with open(OUTPUT, "w", encoding="utf-8") as f:
    json.dump(result, f, indent=2, ensure_ascii=False)

print(f"Entries written: {len(result)}")
for k, v in result.items():
    print(f"  {k[:20]}... -> {v['name']} [{v['confidence']}]")
