// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 59
// Methods: 139

public class CacheEntry : ValueType
{
    public object expiry; // 0x35C01B40

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab1885e30
    public void get_TTL(){} // RVA: 0x7ffab1885fb0
    public void get_Valid(){} // RVA: 0x7ffab1886030
    public void CompareTo(){} // RVA: 0x7ffab1886050
    public void Equals(){} // RVA: 0x7ffab18860a0
}

public class CachedData : Object
{
    public object _systemTimeZones; // 0x34FA2960

    // ── Original Methods ──
    public void CreateLocal(){} // RVA: 0x7ffaadf24140
    public void get_Local(){} // RVA: 0x7ffaadf243d0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetCurrentOneYearLocal(){} // RVA: 0x7ffaadf23d10
    public void GetOneYearLocalFromUtc(){} // RVA: 0x7ffaadf23e80
    public void GetCorrespondingKind(){} // RVA: 0x7ffaadf24400
}

public class CalcProximity_000001C3$BurstDirectCall : Object
{
    // ── Original Methods ──
    public void Constructor(){} // RVA: 0x7ffaaf8490d0
    public void Initialize(){} // RVA: 0x7ffaa8932310
    public void .cctor(){} // RVA: 0x7ffaaf8490d0
    public void Invoke(){} // RVA: 0x7ffaaf849190
    // ── Binary Analysis Named ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf848e20
    public void GetFunctionPointer(){} // RVA: 0x7ffaaf848f60
}

public class CalcProximity_000001C3$PostfixBurstDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf848c80
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaa9a347f0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaf848d60
}

public class CallSiteFormatterContext : ValueType
{
    public object _offset; // 0x350653F0, was: <Offset>k__BackingField

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadd46b90
    public void get_Offset(){} // RVA: 0x7ffaaa3cefa0
    public void get_Builder(){} // RVA: 0x7ffaa894d380
    public void ShouldFormat(){} // RVA: 0x7ffaadd46c50
    public void IncrementOffset(){} // RVA: 0x7ffaadd46cc0
    public void StartObject(){} // RVA: 0x7ffaadd46d00
    public void EndObject(){} // RVA: 0x7ffaadd46dd0
    public void StartProperty(){} // RVA: 0x7ffaadd46e40
    public void StartArrayItem(){} // RVA: 0x7ffaadd46f30
    public void WriteProperty(){} // RVA: 0x7ffaadd46f70
    public void StartArray(){} // RVA: 0x7ffaadd47070
    public void EndArray(){} // RVA: 0x7ffaadd47140
}

public class CallSiteValidatorState : ValueType
{
    // ── Original Methods ──
    public void get_Singleton(){} // RVA: 0x7ffaa950bda0
    public void set_Singleton(){} // RVA: 0x7ffaa930eca0
}

public class Callback : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9bb9250
    public void Invoke(){} // RVA: 0x7ffaaeeec950
}

public class Callback : ValueType
{
}

public class CallbackContext : Object
{
    public object chain; // 0x350E4CA0
    public object EnsureModules; // 0xB3F6FFF0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaecfe0a0
}

public class CallbackMsg_t : ValueType
{
    public object Data; // 0x35ECA0F0
}

public class CellRecord : ValueType
{
    public object max; // 0x3510DF00
    public object shapeData; // 0x3510DF00
    public object pos1; // 0x84D96DB0
}

public class Chain : ValueType
{
    public object boneCount; // 0x3510EE50
    public object version; // 0x3510EE50
    public object colliders; // 0x3510EE50
    public object grabMovement; // 0x3510EE50
    public object grabIkSolved; // 0x3510EE50
    public object immobileType; // 0x3510EE50
    public object collisionBounds; // 0x3510EE50
    public object lastSceneRootState; // 0x3510EE50
    public object 00; // 0x84DC2C88

    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaf8654f0
    public void Dispose(){} // RVA: 0x7ffaaf8655b0
}

public class ChainItemInfo : ValueType
{
    // ── Original Methods ──
    public void get_Order(){} // RVA: 0x7ffaa9e47550
    public void get_ImplementationType(){} // RVA: 0x7ffaa9e47540
    public void .ctor(){} // RVA: 0x7ffaabb03a70
}

public class ChainRoot : ValueType
{
    public object useFixedTime; // 0x3510ECD0
    public object autoFixedTimeElapsed; // 0x3510ECD0
    public object prevVelFixed; // 0x3510ECD0
    public object executions; // 0x3510ECD0
    public object `Ǐf; // 0x31948F40
    public object ReadArrayElement; // 0xB3F96360
}

public class ChangeTrackerDisposable : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa11ddc0
    public void OnChange(){} // RVA: 0x7ffaad31e2e0
    public void Dispose(){} // RVA: 0x7ffaad831190
}

public class ClaimNetworkControlDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9fdcf70
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa94f9e30
}

public class CleanupCode : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaabba1970
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
}

public class Client : ValueType
{
    // ── Original Methods ──
    public void AuthorizationCallback_Handler(){} // RVA: 0x7ffaaa37e410
    public void UpdateTokenCallback_Handler(){} // RVA: 0x7ffaaa37e650
    public void LogCallback_Handler(){} // RVA: 0x7ffaaa37e750
    public void OnStatusChanged_Handler(){} // RVA: 0x7ffaaa37e920
    public void SendActivityInviteCallback_Handler(){} // RVA: 0x7ffaaa37ea10
    public void ActivityJoinCallback_Handler(){} // RVA: 0x7ffaaa37eb10
    public void UpdateRichPresenceCallback_Handler(){} // RVA: 0x7ffaaa37ecc0
    public void UserUpdatedCallback_Handler(){} // RVA: 0x7ffaaa37edc0
    public void Init(){} // RVA: 0x7ffaaa37ee80
    public void Drop(){} // RVA: 0x7ffaaa37ef00
    public void Authorize(){} // RVA: 0x7ffaaa37f000
    public void UpdateToken(){} // RVA: 0x7ffaaa37f0b0
    public void AddLogCallback(){} // RVA: 0x7ffaaa37f180
    public void Connect(){} // RVA: 0x7ffaaa37f230
    public void Disconnect(){} // RVA: 0x7ffaaa37f2b0
    public void ClearRichPresence(){} // RVA: 0x7ffaaa37f470
    public void SendActivityInvite(){} // RVA: 0x7ffaaa37f4f0
    public void UpdateRichPresence(){} // RVA: 0x7ffaaa37f680
    // ── Binary Analysis Named ──
    public void GetDefaultPresenceScopes(){} // RVA: 0x7ffaaa37ef80
    public void SetApplicationId(){} // RVA: 0x7ffaaa37f330
    public void SetStatusChangedCallback(){} // RVA: 0x7ffaaa37f3c0
    public void SetActivityJoinCallback(){} // RVA: 0x7ffaaa37f5d0
    public void GetRelationships(){} // RVA: 0x7ffaaa37f730
    public void SetUserUpdatedCallback(){} // RVA: 0x7ffaaa37f7c0
}

public class ClientResult : ValueType
{
    // ── Original Methods ──
    public void Drop(){} // RVA: 0x7ffaaa37db20
    public void ToString(){} // RVA: 0x7ffaaa37dba0
    public void Type(){} // RVA: 0x7ffaaa37dc30
    public void Error(){} // RVA: 0x7ffaaa37dcb0
    public void ErrorCode(){} // RVA: 0x7ffaaa37dd40
    public void Successful(){} // RVA: 0x7ffaaa37ddc0
}

public class Collider : ValueType
{
    public object prevPos0; // 0x351352A0
    public object nextPos1; // 0x351352A0
    public object pos1; // 0x351352A0
    public object bonesAsSpheres; // 0x351352A0
    public object 00;

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf871130
    public void Lerp(){} // RVA: 0x7ffaaf871260
}

public class ColliderToRemoveData : ValueType
{
    public object shape; // 0x35134B40
    public object Capacity; // 0x170008CD

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf866640
}

public class CollisionEnterDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab656170
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa94f9e30
}

public class CollisionEvent : ValueType
{
    public object collider; // 0x3510CDD0
    public object Enqueue; // 0xB3F6FFF0
}

public class CollisionEventsJob : ValueType
{
    public object gridCells; // 0x3510E6B0

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf81a370
}

public class CollisionExitDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab656170
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa94f9e30
}

public class CollisionsJob : ValueType
{
    public object shapeData; // 0x3510D8E0
    public object Execute; // 0xB3F6FFF0

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf814970
    public void FindCollision(){} // RVA: 0x7ffaaf8157f0
    // ── Binary Analysis Named ──
    public void GetCollision(){} // RVA: 0x7ffaaf8157b0
    public void SetCollision(){} // RVA: 0x7ffaaf8157d0
}

public class Color32Surrogate : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetObjectData(){} // RVA: 0x7ffab1a97630
    public void SetObjectData(){} // RVA: 0x7ffab1a97750
}

public class ColorSurrogate : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetObjectData(){} // RVA: 0x7ffab1a973b0
    public void SetObjectData(){} // RVA: 0x7ffab1a974d0
}

public class CompleteOnInvokePromise : Task`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaddebda0
    public void Invoke(){} // RVA: 0x7ffaaddebec0
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7ffaa8a17850
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9211760
    public void get_IsCompleted(){} // RVA: 0x7ffaaae93970
    public void OnCompleted(){} // RVA: 0x7ffaaae939e0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaaae93aa0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaae94720
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9211760
    public void get_IsCompleted(){} // RVA: 0x7ffaaae93970
    public void OnCompleted(){} // RVA: 0x7ffaaae939e0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaaae93aa0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaae93cd0
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredTaskAwaiter : ValueType
{
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa4a3e50
    public void get_IsCompleted(){} // RVA: 0x7ffaaaf1c1b0
    public void OnCompleted(){} // RVA: 0x7ffaaaf30230
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaaaf30580
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaaf2fb50
}

public class ConstraintConfigurationData : ValueType
{
    public object Axes; // 0x350E7E10
}

public class ConstraintSourceData : ValueType
{
    public object Weight; // 0x3510C2E0
}

public class CreateRuntimePanelDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab6ba650
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa94f9e70
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CreateValueCallback : MulticastDelegate
{
}

public class CredentialsBundle : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class CustomStyleAccess : Object
{
    // ── Original Methods ──
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void TryGetValue(){} // RVA: 0x7ffaaf617030
    public void LogCustomPropertyWarning(){} // RVA: 0x7ffaaf6170d0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void SetContext(){} // RVA: 0x7ffaaa3b83e0
}

public class CustomTriggerTarget : Object
{
    public object OnRemotePlayerEnterStation; // 0x33D20CB0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab1a87100
}
