// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 549

public class SafeModeOptions : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class SampleFramesHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F53D4B0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class SaveableInventoryGroupData : ValueType
{
}

public class SavedSearches : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Scanbeam : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ScheduledFrameEvent : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5529F630
}

public class ScheduledFrameEventComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD5529F770
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ScheduledTimeEvent : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5529F570
}

public class ScheduledTimeEventComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD5529F6F0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Scheduler : Object
{
    public object Instance;

    // ── Methods ──
    public void InitScheduler(){} // RVA: 0x7FFD53AF7F50
    public void WakeupScheduler(){} // RVA: 0x7FFD53AF8100
    public void SchedulerThread(){} // RVA: 0x7FFD53AF8170
    public void get_Instance(){} // RVA: 0x7FFD53AF83F0
    public void .ctor(){} // RVA: 0x7FFD53AF8450
    public void Remove(){} // RVA: 0x7FFD53AF8730
    public void Change(){} // RVA: 0x7FFD53AF8880
    public void Add(){} // RVA: 0x7FFD53AF8BB0
    public void InternalRemove(){} // RVA: 0x7FFD53AF8C90
    public void TimerCB(){} // RVA: 0x7FFD53AF8CC0
    public void FireTimer(){} // RVA: 0x7FFD53AF8D40
    public void RunSchedulerLoop(){} // RVA: 0x7FFD53AF8E10
    public void .cctor(){} // RVA: 0x7FFD53AF9210
}

public class Scope : Object
{
    public object Parent;
    public object State;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD537623F0
    public void get_Parent(){} // RVA: 0x7FFD4E36F0C0
    public void get_State(){} // RVA: 0x7FFD4E36F130
    public void ToString(){} // RVA: 0x7FFD537624F0
    public void Dispose(){} // RVA: 0x7FFD5376A1A0
}

public class ScriptRunBehaviourFixedUpdate : ValueType
{
}

public class ScriptRunBehaviourLateUpdate : ValueType
{
}

public class ScriptRunBehaviourUpdate : ValueType
{
}

public class ScriptRunDelayedDynamicFrameRate : ValueType
{
}

public class ScriptRunDelayedFixedFrameRate : ValueType
{
}

public class ScriptRunDelayedStartupFrame : ValueType
{
}

public class ScriptRunDelayedTasks : ValueType
{
}

public class ScrollRectEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55083780
}

public class SealedPrefab : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class SealedPrefabAllowSerializeAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class SecurePlayerPrefs : Object
{
    // ── Methods ──
    public void SetString(){} // RVA: 0x7FFD56E4F480
    public void GetString(){} // RVA: 0x7FFD56E4F630 | overloaded x2
    public void HasKey(){} // RVA: 0x7FFD56E4F6D0
    public void DeleteKey(){} // RVA: 0x7FFD56E4F730
    public void GenerateMD5(){} // RVA: 0x7FFD56E4F790
}

public class SecureStringAllocator : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D01B0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class Segment : Object
{
    public object Capacity;
    public object FreezeOffset;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51D00ED0
    public void get_Capacity(){} // RVA: 0x7FFD4E930620
    public void get_FreezeOffset(){} // RVA: 0x7FFD51D00770
    public void EnsureFrozenForEnqueues(){} // RVA: 0x7FFD51D00FB0
    public void TryDequeue(){} // RVA: 0x7FFD51D010B0
    public void TryPeek(){} // RVA: 0x7FFD51D012F0
    public void TryEnqueue(){} // RVA: 0x7FFD51D014D0
}

public class SegmentState : ValueType
{
}

public class Select : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
}

public class SelectionEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54BA7000
}

public class SendMouseEvents : ValueType
{
}

public class SendNetworkEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD57414670
    public void Invoke(){} // RVA: 0x7FFD515B3C60
    public void BeginInvoke(){} // RVA: 0x7FFD574147F0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class SerializableContainer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class SerializableVector3 : Object
{
    public object Value;

    // ── Methods ──
    public void ToNumerics(){} // RVA: 0x7FFD4EB56D20
    public void .ctor(){} // RVA: 0x7FFD4EB56D40
    public void Initialize(){} // RVA: 0x7FFD4EB56D20
    public void op_Implicit(){} // RVA: 0x7FFD4EB56D20
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EB56D20
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EB56D20
    public void GetCachedPtr(){} // RVA: 0x7FFD4EB56D20
    public void set_Value(){} // RVA: 0x7FFD4EB56D20
    public void get_Value(){} // RVA: 0x7FFD4EB56D20
    public void Instantiate(){} // RVA: 0x7FFD4EB56D20
}

public class SerializationCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){}
    public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
    public void EndInvoke(){} // RVA: 0x7FFD4E099B30
}

public class SerializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510DD190
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class SerializedState : ValueType
{
}

public class ServiceAccessor : Object
{
    public object CallSite;
    public object RealizedService;

    // ── Methods ──
    public void get_CallSite(){} // RVA: 0x7FFD4E35C380
    public void set_CallSite(){} // RVA: 0x7FFD4E342E30
    public void get_RealizedService(){} // RVA: 0x7FFD4E3447C0
    public void set_RealizedService(){} // RVA: 0x7FFD4E3A7E80
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ServiceCollectionDebugView : Object
{
}

public class ServiceDescriptorCacheItem : ValueType
{
    public object Last;
    public object Count;
    public object Item;

    // ── Methods ──
    public void get_Last(){} // RVA: 0x7FFD5374F000
    public void get_Count(){} // RVA: 0x7FFD5374F0A0
    public void get_Item(){} // RVA: 0x7FFD5374F100
    public void GetSlot(){} // RVA: 0x7FFD5374F220
    public void Add(){} // RVA: 0x7FFD5374F390
}

public class ServiceProviderDebugView : Object
{
}

public class ServiceProviderEngineScopeDebugView : Object
{
}

public class SessionStateChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD550AE2C0
    public void Invoke(){} // RVA: 0x7FFD4F90CD30
}

public class SetAnimatorBoolDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5746E130
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD5746E2B0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class SetClassValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class SetElementProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFD4E078E90
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class SetOnInvokeMres : ManualResetEventSlim
{
    public object InvokeMayRunArbitraryCode;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53B06AB0
    public void Invoke(){} // RVA: 0x7FFD53ADB010
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFD4E341320
}

public class SetStructValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class Settings : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5726A320
    public void Get(){} // RVA: 0x7FFD4E2ADC40
    public void Save(){} // RVA: 0x7FFD4E2ADC40
    public void LoadFromStorage(){} // RVA: 0x7FFD5726A600
    public void GetSettingsFilePath(){} // RVA: 0x7FFD5726AB80
    public void WriteToStorage(){} // RVA: 0x7FFD5726AC10
    public void <Save>b__9_0(){} // RVA: 0x7FFD4E090980
}

public class ShaderAssetList : ScriptableObject
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
}

public class ShaderHandleErrors : ValueType
{
}

public class Shape : Object
{
    public object id;

    // ── Methods ──
    public void get_id(){} // RVA: 0x7FFD513F9440
    public void set_id(){} // RVA: 0x7FFD5521B2D0
    public void .ctor(){} // RVA: 0x7FFD5521B2F0
    public void .cctor(){} // RVA: 0x7FFD5521B3A0
}

public class ShapeCache : ValueType
{
    // ── Methods ──
    public void Invalidate(){} // RVA: 0x7FFD4FC23630
    public void ValidateCache(){} // RVA: 0x7FFD4FC237D0
    public void IsValid(){} // RVA: 0x7FFD4FC24340
    public void CalculateDeltaTransformationMatrix(){} // RVA: 0x7FFD4FC24620
}

public class ShapeData : ValueType
{
    // ── Methods ──
    public void ToCollisionShape(){} // RVA: 0x7FFD5521B3E0
    public void GetMidpoint(){} // RVA: 0x7FFD5521B420
    public void GetClosestPoint(){} // RVA: 0x7FFD5521B4C0
    public void CalcVelocityAtPoint(){} // RVA: 0x7FFD5521B730
    public void UpdateShape(){} // RVA: 0x7FFD5521BA10
    public void GetTransformLossyScale(){} // RVA: 0x7FFD5521CD80
    public void UpdateVelocity(){} // RVA: 0x7FFD5521CFD0
}

public class ShapeModule : ValueType
{
    public object enabled;
    public object shapeType;
    public object randomDirectionAmount;
    public object sphericalDirectionAmount;
    public object randomPositionAmount;
    public object alignToDirection;
    public object radius;
    public object radiusMode;
    public object radiusSpread;
    public object radiusSpeed;
    public object radiusSpeedMultiplier;
    public object radiusThickness;
    public object angle;
    public object length;
    public object boxThickness;
    public object meshShapeType;
    public object mesh;
    public object meshRenderer;
    public object skinnedMeshRenderer;
    public object sprite;
    public object spriteRenderer;
    public object useMeshMaterialIndex;
    public object meshMaterialIndex;
    public object useMeshColors;
    public object normalOffset;
    public object meshSpawnMode;
    public object meshSpawnSpread;
    public object meshSpawnSpeed;
    public object meshSpawnSpeedMultiplier;
    public object arc;
    public object arcMode;
    public object arcSpread;
    public object arcSpeed;
    public object arcSpeedMultiplier;
    public object donutRadius;
    public object position;
    public object rotation;
    public object scale;
    public object texture;
    public object textureClipChannel;
    public object textureClipThreshold;
    public object textureColorAffectsParticles;
    public object textureAlphaAffectsParticles;
    public object textureBilinearFiltering;
    public object textureUVChannel;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D6ACC0
    public void set_enabled(){} // RVA: 0x7FFD54D6AD10
    public void get_shapeType(){} // RVA: 0x7FFD54D6AD70
    public void set_shapeType(){} // RVA: 0x7FFD54D6ADC0
    public void get_randomDirectionAmount(){} // RVA: 0x7FFD54D6AE20
    public void set_randomDirectionAmount(){} // RVA: 0x7FFD54D6AE70
    public void get_sphericalDirectionAmount(){} // RVA: 0x7FFD54D6AED0
    public void set_sphericalDirectionAmount(){} // RVA: 0x7FFD54D6AF20
    public void get_randomPositionAmount(){} // RVA: 0x7FFD54D6AF80
    public void set_randomPositionAmount(){} // RVA: 0x7FFD54D6AFD0
    public void get_alignToDirection(){} // RVA: 0x7FFD54D6B030
    public void set_alignToDirection(){} // RVA: 0x7FFD54D6B080
    public void get_radius(){} // RVA: 0x7FFD54D6B0E0
    public void set_radius(){} // RVA: 0x7FFD54D6B130
    public void get_radiusMode(){} // RVA: 0x7FFD54D6B190
    public void set_radiusMode(){} // RVA: 0x7FFD54D6B1E0
    public void get_radiusSpread(){} // RVA: 0x7FFD54D6B240
    public void set_radiusSpread(){} // RVA: 0x7FFD54D6B290
    public void get_radiusSpeed(){} // RVA: 0x7FFD54D6B2F0
    public void set_radiusSpeed(){} // RVA: 0x7FFD54D6B360
    public void get_radiusSpeedMultiplier(){} // RVA: 0x7FFD54D6B3C0
    public void set_radiusSpeedMultiplier(){} // RVA: 0x7FFD54D6B410
    public void get_radiusThickness(){} // RVA: 0x7FFD54D6B470
    public void set_radiusThickness(){} // RVA: 0x7FFD54D6B4C0
    public void get_angle(){} // RVA: 0x7FFD54D6B520
    public void set_angle(){} // RVA: 0x7FFD54D6B570
    public void get_length(){} // RVA: 0x7FFD54D6B5D0
    public void set_length(){} // RVA: 0x7FFD54D6B620
    public void get_boxThickness(){} // RVA: 0x7FFD54D6B680
    public void set_boxThickness(){} // RVA: 0x7FFD54D6B6F0
    public void get_meshShapeType(){} // RVA: 0x7FFD54D6B750
    public void set_meshShapeType(){} // RVA: 0x7FFD54D6B7A0
    public void get_mesh(){} // RVA: 0x7FFD54D6B800
    public void set_mesh(){} // RVA: 0x7FFD54D6B850
    public void get_meshRenderer(){} // RVA: 0x7FFD54D6B8B0
    public void set_meshRenderer(){} // RVA: 0x7FFD54D6B900
    public void get_skinnedMeshRenderer(){} // RVA: 0x7FFD54D6B960
    public void set_skinnedMeshRenderer(){} // RVA: 0x7FFD54D6B9B0
    public void get_sprite(){} // RVA: 0x7FFD54D6BA10
    public void set_sprite(){} // RVA: 0x7FFD54D6BA60
    public void get_spriteRenderer(){} // RVA: 0x7FFD54D6BAC0
    public void set_spriteRenderer(){} // RVA: 0x7FFD54D6BB10
    public void get_useMeshMaterialIndex(){} // RVA: 0x7FFD54D6BB70
    public void set_useMeshMaterialIndex(){} // RVA: 0x7FFD54D6BBC0
    public void get_meshMaterialIndex(){} // RVA: 0x7FFD54D6BC20
    public void set_meshMaterialIndex(){} // RVA: 0x7FFD54D6BC70
    public void get_useMeshColors(){} // RVA: 0x7FFD54D6BCD0
    public void set_useMeshColors(){} // RVA: 0x7FFD54D6BD20
    public void get_normalOffset(){} // RVA: 0x7FFD54D6BD80
    public void set_normalOffset(){} // RVA: 0x7FFD54D6BDD0
    public void get_meshSpawnMode(){} // RVA: 0x7FFD54D6BE30
    public void set_meshSpawnMode(){} // RVA: 0x7FFD54D6BE80
    public void get_meshSpawnSpread(){} // RVA: 0x7FFD54D6BEE0
    public void set_meshSpawnSpread(){} // RVA: 0x7FFD54D6BF30
    public void get_meshSpawnSpeed(){} // RVA: 0x7FFD54D6BF90
    public void set_meshSpawnSpeed(){} // RVA: 0x7FFD54D6C000
    public void get_meshSpawnSpeedMultiplier(){} // RVA: 0x7FFD54D6C060
    public void set_meshSpawnSpeedMultiplier(){} // RVA: 0x7FFD54D6C0B0
    public void get_arc(){} // RVA: 0x7FFD54D6C110
    public void set_arc(){} // RVA: 0x7FFD54D6C160
    public void get_arcMode(){} // RVA: 0x7FFD54D6C1C0
    public void set_arcMode(){} // RVA: 0x7FFD54D6C210
    public void get_arcSpread(){} // RVA: 0x7FFD54D6C270
    public void set_arcSpread(){} // RVA: 0x7FFD54D6C2C0
    public void get_arcSpeed(){} // RVA: 0x7FFD54D6C320
    public void set_arcSpeed(){} // RVA: 0x7FFD54D6C390
    public void get_arcSpeedMultiplier(){} // RVA: 0x7FFD54D6C3F0
    public void set_arcSpeedMultiplier(){} // RVA: 0x7FFD54D6C440
    public void get_donutRadius(){} // RVA: 0x7FFD54D6C4A0
    public void set_donutRadius(){} // RVA: 0x7FFD54D6C4F0
    public void get_position(){} // RVA: 0x7FFD54D6C550
    public void set_position(){} // RVA: 0x7FFD54D6C5C0
    public void get_rotation(){} // RVA: 0x7FFD54D6C620
    public void set_rotation(){} // RVA: 0x7FFD54D6C690
    public void get_scale(){} // RVA: 0x7FFD54D6C6F0
    public void set_scale(){} // RVA: 0x7FFD54D6C760
    public void get_texture(){} // RVA: 0x7FFD54D6C7C0
    public void set_texture(){} // RVA: 0x7FFD54D6C810
    public void get_textureClipChannel(){} // RVA: 0x7FFD54D6C870
    public void set_textureClipChannel(){} // RVA: 0x7FFD54D6C8C0
    public void get_textureClipThreshold(){} // RVA: 0x7FFD54D6C920
    public void set_textureClipThreshold(){} // RVA: 0x7FFD54D6C970
    public void get_textureColorAffectsParticles(){} // RVA: 0x7FFD54D6C9D0
    public void set_textureColorAffectsParticles(){} // RVA: 0x7FFD54D6CA20
    public void get_textureAlphaAffectsParticles(){} // RVA: 0x7FFD54D6CA80
    public void set_textureAlphaAffectsParticles(){} // RVA: 0x7FFD54D6CAD0
    public void get_textureBilinearFiltering(){} // RVA: 0x7FFD54D6CB30
    public void set_textureBilinearFiltering(){} // RVA: 0x7FFD54D6CB80
    public void get_textureUVChannel(){} // RVA: 0x7FFD54D6CBE0
    public void set_textureUVChannel(){} // RVA: 0x7FFD54D6CC30
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D6ACC0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D6AD10
    public void get_shapeType_Injected(){} // RVA: 0x7FFD54D6AD70
    public void set_shapeType_Injected(){} // RVA: 0x7FFD54D6ADC0
    public void get_randomDirectionAmount_Injected(){} // RVA: 0x7FFD54D6AE20
    public void set_randomDirectionAmount_Injected(){} // RVA: 0x7FFD54D6AE70
    public void get_sphericalDirectionAmount_Injected(){} // RVA: 0x7FFD54D6AED0
    public void set_sphericalDirectionAmount_Injected(){} // RVA: 0x7FFD54D6AF20
    public void get_randomPositionAmount_Injected(){} // RVA: 0x7FFD54D6AF80
    public void set_randomPositionAmount_Injected(){} // RVA: 0x7FFD54D6AFD0
    public void get_alignToDirection_Injected(){} // RVA: 0x7FFD54D6B030
    public void set_alignToDirection_Injected(){} // RVA: 0x7FFD54D6B080
    public void get_radius_Injected(){} // RVA: 0x7FFD54D6B0E0
    public void set_radius_Injected(){} // RVA: 0x7FFD54D6B130
    public void get_radiusMode_Injected(){} // RVA: 0x7FFD54D6B190
    public void set_radiusMode_Injected(){} // RVA: 0x7FFD54D6B1E0
    public void get_radiusSpread_Injected(){} // RVA: 0x7FFD54D6B240
    public void set_radiusSpread_Injected(){} // RVA: 0x7FFD54D6B290
    public void get_radiusSpeed_Injected(){} // RVA: 0x7FFD54D6CC90
    public void set_radiusSpeed_Injected(){} // RVA: 0x7FFD54D6CCF0
    public void get_radiusSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D6B3C0
    public void set_radiusSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D6B410
    public void get_radiusThickness_Injected(){} // RVA: 0x7FFD54D6B470
    public void set_radiusThickness_Injected(){} // RVA: 0x7FFD54D6B4C0
    public void get_angle_Injected(){} // RVA: 0x7FFD54D6B520
    public void set_angle_Injected(){} // RVA: 0x7FFD54D6B570
    public void get_length_Injected(){} // RVA: 0x7FFD54D6B5D0
    public void set_length_Injected(){} // RVA: 0x7FFD54D6B620
    public void get_boxThickness_Injected(){} // RVA: 0x7FFD54D6CD50
    public void set_boxThickness_Injected(){} // RVA: 0x7FFD54D6CDB0
    public void get_meshShapeType_Injected(){} // RVA: 0x7FFD54D6B750
    public void set_meshShapeType_Injected(){} // RVA: 0x7FFD54D6B7A0
    public void get_mesh_Injected(){} // RVA: 0x7FFD54D6B800
    public void set_mesh_Injected(){} // RVA: 0x7FFD54D6B850
    public void get_meshRenderer_Injected(){} // RVA: 0x7FFD54D6B8B0
    public void set_meshRenderer_Injected(){} // RVA: 0x7FFD54D6B900
    public void get_skinnedMeshRenderer_Injected(){} // RVA: 0x7FFD54D6B960
    public void set_skinnedMeshRenderer_Injected(){} // RVA: 0x7FFD54D6B9B0
    public void get_sprite_Injected(){} // RVA: 0x7FFD54D6BA10
    public void set_sprite_Injected(){} // RVA: 0x7FFD54D6BA60
    public void get_spriteRenderer_Injected(){} // RVA: 0x7FFD54D6BAC0
    public void set_spriteRenderer_Injected(){} // RVA: 0x7FFD54D6BB10
    public void get_useMeshMaterialIndex_Injected(){} // RVA: 0x7FFD54D6BB70
    public void set_useMeshMaterialIndex_Injected(){} // RVA: 0x7FFD54D6BBC0
    public void get_meshMaterialIndex_Injected(){} // RVA: 0x7FFD54D6BC20
    public void set_meshMaterialIndex_Injected(){} // RVA: 0x7FFD54D6BC70
    public void get_useMeshColors_Injected(){} // RVA: 0x7FFD54D6BCD0
    public void set_useMeshColors_Injected(){} // RVA: 0x7FFD54D6BD20
    public void get_normalOffset_Injected(){} // RVA: 0x7FFD54D6BD80
    public void set_normalOffset_Injected(){} // RVA: 0x7FFD54D6BDD0
    public void get_meshSpawnMode_Injected(){} // RVA: 0x7FFD54D6BE30
    public void set_meshSpawnMode_Injected(){} // RVA: 0x7FFD54D6BE80
    public void get_meshSpawnSpread_Injected(){} // RVA: 0x7FFD54D6BEE0
    public void set_meshSpawnSpread_Injected(){} // RVA: 0x7FFD54D6BF30
    public void get_meshSpawnSpeed_Injected(){} // RVA: 0x7FFD54D6CE10
    public void set_meshSpawnSpeed_Injected(){} // RVA: 0x7FFD54D6CE70
    public void get_meshSpawnSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D6C060
    public void set_meshSpawnSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D6C0B0
    public void get_arc_Injected(){} // RVA: 0x7FFD54D6C110
    public void set_arc_Injected(){} // RVA: 0x7FFD54D6C160
    public void get_arcMode_Injected(){} // RVA: 0x7FFD54D6C1C0
    public void set_arcMode_Injected(){} // RVA: 0x7FFD54D6C210
    public void get_arcSpread_Injected(){} // RVA: 0x7FFD54D6C270
    public void set_arcSpread_Injected(){} // RVA: 0x7FFD54D6C2C0
    public void get_arcSpeed_Injected(){} // RVA: 0x7FFD54D6CED0
    public void set_arcSpeed_Injected(){} // RVA: 0x7FFD54D6CF30
    public void get_arcSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D6C3F0
    public void set_arcSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D6C440
    public void get_donutRadius_Injected(){} // RVA: 0x7FFD54D6C4A0
    public void set_donutRadius_Injected(){} // RVA: 0x7FFD54D6C4F0
    public void get_position_Injected(){} // RVA: 0x7FFD54D6CF90
    public void set_position_Injected(){} // RVA: 0x7FFD54D6CFF0
    public void get_rotation_Injected(){} // RVA: 0x7FFD54D6D050
    public void set_rotation_Injected(){} // RVA: 0x7FFD54D6D0B0
    public void get_scale_Injected(){} // RVA: 0x7FFD54D6D110
    public void set_scale_Injected(){} // RVA: 0x7FFD54D6D170
    public void get_texture_Injected(){} // RVA: 0x7FFD54D6C7C0
    public void set_texture_Injected(){} // RVA: 0x7FFD54D6C810
    public void get_textureClipChannel_Injected(){} // RVA: 0x7FFD54D6C870
    public void set_textureClipChannel_Injected(){} // RVA: 0x7FFD54D6C8C0
    public void get_textureClipThreshold_Injected(){} // RVA: 0x7FFD54D6C920
    public void set_textureClipThreshold_Injected(){} // RVA: 0x7FFD54D6C970
    public void get_textureColorAffectsParticles_Injected(){} // RVA: 0x7FFD54D6C9D0
    public void set_textureColorAffectsParticles_Injected(){} // RVA: 0x7FFD54D6CA20
    public void get_textureAlphaAffectsParticles_Injected(){} // RVA: 0x7FFD54D6CA80
    public void set_textureAlphaAffectsParticles_Injected(){} // RVA: 0x7FFD54D6CAD0
    public void get_textureBilinearFiltering_Injected(){} // RVA: 0x7FFD54D6CB30
    public void set_textureBilinearFiltering_Injected(){} // RVA: 0x7FFD54D6CB80
    public void get_textureUVChannel_Injected(){} // RVA: 0x7FFD54D6CBE0
    public void set_textureUVChannel_Injected(){} // RVA: 0x7FFD54D6CC30
}

public class SharedBool : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539C5F00
}

public class SharedInt : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539C5EF0
}

public class SharedLong : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F83EFB0
}

public class SharedStatic`1 : ValueType
{
    public object Data;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Data(){} // RVA: 0x7FFD4E078E90
    public void GetOrCreate(){} // RVA: 0x7FFD4E2ADC40
}

public class SharedStatics : Object
{
}

public class SignalSource : Object
{
    public object SignalDuration;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC77880
    public void get_SignalDuration(){} // RVA: 0x7FFD4FC778F0
    public void GetSignal(){} // RVA: 0x7FFD4FC77910
}

public class SimpleScheduledItem : VisualElementScheduledItem`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55014450
    public void PerformTimerUpdate(){} // RVA: 0x7FFD550144B0
}

public class SingleAnchorDelegatePair : ValueType
{
}

public class SingleConsumerUnboundedChannelReader : ChannelReader`1
{
    public object Completion;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Completion(){} // RVA: 0x7FFD4E0788A0
    public void TryRead(){} // RVA: 0x7FFD4E079F60
    public void WaitToReadAsync(){}
    public void SingalContinuation(){} // RVA: 0x7FFD4E090980
    public void SingalCancellation(){} // RVA: 0x7FFD4E090BF0
    public void SingalCompleted(){} // RVA: 0x7FFD4E090A40
    public void ReadAllAsync(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7FFD4E07AB80
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
}

public class SingleConsumerUnboundedChannelWriter : ChannelWriter`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
    public void TryComplete(){} // RVA: 0x7FFD4E079F60
}

public class SingleProducerSingleConsumerQueue_DebugView : Object
{
}

public class SingleRange : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51510B90
}

public class SingleRangeComparer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Compare(){} // RVA: 0x7FFD547C89F0
    public void .cctor(){} // RVA: 0x7FFD547C8A50
}

public class SizeBySpeedModule : ValueType
{
    public object enabled;
    public object size;
    public object sizeMultiplier;
    public object x;
    public object xMultiplier;
    public object y;
    public object yMultiplier;
    public object z;
    public object zMultiplier;
    public object separateAxes;
    public object range;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D767C0
    public void set_enabled(){} // RVA: 0x7FFD54D76810
    public void get_size(){} // RVA: 0x7FFD54D76870
    public void set_size(){} // RVA: 0x7FFD54D768E0
    public void get_sizeMultiplier(){} // RVA: 0x7FFD54D76940
    public void set_sizeMultiplier(){} // RVA: 0x7FFD54D76990
    public void get_x(){} // RVA: 0x7FFD54D769F0
    public void set_x(){} // RVA: 0x7FFD54D76A60
    public void get_xMultiplier(){} // RVA: 0x7FFD54D76AC0
    public void set_xMultiplier(){} // RVA: 0x7FFD54D76B10
    public void get_y(){} // RVA: 0x7FFD54D76B70
    public void set_y(){} // RVA: 0x7FFD54D76BE0
    public void get_yMultiplier(){} // RVA: 0x7FFD54D76C40
    public void set_yMultiplier(){} // RVA: 0x7FFD54D76C90
    public void get_z(){} // RVA: 0x7FFD54D76CF0
    public void set_z(){} // RVA: 0x7FFD54D76D60
    public void get_zMultiplier(){} // RVA: 0x7FFD54D76DC0
    public void set_zMultiplier(){} // RVA: 0x7FFD54D76E10
    public void get_separateAxes(){} // RVA: 0x7FFD54D76E70
    public void set_separateAxes(){} // RVA: 0x7FFD54D76EC0
    public void get_range(){} // RVA: 0x7FFD54D76F20
    public void set_range(){} // RVA: 0x7FFD54D76F80
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D767C0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D76810
    public void get_size_Injected(){} // RVA: 0x7FFD54D76FE0
    public void set_size_Injected(){} // RVA: 0x7FFD54D77040
    public void get_sizeMultiplier_Injected(){} // RVA: 0x7FFD54D76940
    public void set_sizeMultiplier_Injected(){} // RVA: 0x7FFD54D76990
    public void get_x_Injected(){} // RVA: 0x7FFD54D770A0
    public void set_x_Injected(){} // RVA: 0x7FFD54D77100
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFD54D76AC0
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFD54D76B10
    public void get_y_Injected(){} // RVA: 0x7FFD54D77160
    public void set_y_Injected(){} // RVA: 0x7FFD54D771C0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFD54D76C40
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFD54D76C90
    public void get_z_Injected(){} // RVA: 0x7FFD54D77220
    public void set_z_Injected(){} // RVA: 0x7FFD54D77280
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFD54D76DC0
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFD54D76E10
    public void get_separateAxes_Injected(){} // RVA: 0x7FFD54D76E70
    public void set_separateAxes_Injected(){} // RVA: 0x7FFD54D76EC0
    public void get_range_Injected(){} // RVA: 0x7FFD54D772E0
    public void set_range_Injected(){} // RVA: 0x7FFD54D77340
}

public class SizeGroup : Object
{
    public object Count;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void TryGetArray(){} // RVA: 0x7FFD4E078E90
    public void ReturnArray(){} // RVA: 0x7FFD4E090A40
    public void Cleanup(){} // RVA: 0x7FFD4E079960
    public void Contains(){} // RVA: 0x7FFD4E079F60
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class SizeOverLifetimeModule : ValueType
{
    public object enabled;
    public object size;
    public object sizeMultiplier;
    public object x;
    public object xMultiplier;
    public object y;
    public object yMultiplier;
    public object z;
    public object zMultiplier;
    public object separateAxes;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D75D60
    public void set_enabled(){} // RVA: 0x7FFD54D75DB0
    public void get_size(){} // RVA: 0x7FFD54D75E10
    public void set_size(){} // RVA: 0x7FFD54D75E80
    public void get_sizeMultiplier(){} // RVA: 0x7FFD54D75EE0
    public void set_sizeMultiplier(){} // RVA: 0x7FFD54D75F30
    public void get_x(){} // RVA: 0x7FFD54D75F90
    public void set_x(){} // RVA: 0x7FFD54D76000
    public void get_xMultiplier(){} // RVA: 0x7FFD54D76060
    public void set_xMultiplier(){} // RVA: 0x7FFD54D760B0
    public void get_y(){} // RVA: 0x7FFD54D76110
    public void set_y(){} // RVA: 0x7FFD54D76180
    public void get_yMultiplier(){} // RVA: 0x7FFD54D761E0
    public void set_yMultiplier(){} // RVA: 0x7FFD54D76230
    public void get_z(){} // RVA: 0x7FFD54D76290
    public void set_z(){} // RVA: 0x7FFD54D76300
    public void get_zMultiplier(){} // RVA: 0x7FFD54D76360
    public void set_zMultiplier(){} // RVA: 0x7FFD54D763B0
    public void get_separateAxes(){} // RVA: 0x7FFD54D76410
    public void set_separateAxes(){} // RVA: 0x7FFD54D76460
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D75D60
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D75DB0
    public void get_size_Injected(){} // RVA: 0x7FFD54D764C0
    public void set_size_Injected(){} // RVA: 0x7FFD54D76520
    public void get_sizeMultiplier_Injected(){} // RVA: 0x7FFD54D75EE0
    public void set_sizeMultiplier_Injected(){} // RVA: 0x7FFD54D75F30
    public void get_x_Injected(){} // RVA: 0x7FFD54D76580
    public void set_x_Injected(){} // RVA: 0x7FFD54D765E0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFD54D76060
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFD54D760B0
    public void get_y_Injected(){} // RVA: 0x7FFD54D76640
    public void set_y_Injected(){} // RVA: 0x7FFD54D766A0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFD54D761E0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFD54D76230
    public void get_z_Injected(){} // RVA: 0x7FFD54D76700
    public void set_z_Injected(){} // RVA: 0x7FFD54D76760
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFD54D76360
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFD54D763B0
    public void get_separateAxes_Injected(){} // RVA: 0x7FFD54D76410
    public void set_separateAxes_Injected(){} // RVA: 0x7FFD54D76460
}

public class SkinChangedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class SlabAllocator : ValueType
{
    public object Handle;
    public object SlabSizeInBytes;

    // ── Methods ──
    public void get_Handle(){} // RVA: 0x7FFD4F840210
    public void get_SlabSizeInBytes(){} // RVA: 0x7FFD5492FB60
    public void Try(){} // RVA: 0x7FFD5492FD90 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFD4E341310
    public void Try$BurstManaged(){} // RVA: 0x7FFD5492FDF0
}

public class SliderEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5508A3A0
}

public class Slot : ValueType
{
}

public class SortedListKeyEnumerator : Object
{
    public object Current;
    public object System.Collections.IEnumerator.Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
}

public class SortedListValueEnumerator : Object
{
    public object Current;
    public object System.Collections.IEnumerator.Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
}

public class SorterGenericArray : ValueType
{
    public ÌÎÍÏÍÎ keys; // 0x10
    public ÌÎÍÏÍÎ items; // 0x18
    public mePatterns.eTwoDigitYears comparer; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A875F0
    public void SwapIfGreaterWithItems(){} // RVA: 0x7FFD53A87770
    public void Swap(){} // RVA: 0x7FFD53A878F0
    public void Sort(){} // RVA: 0x7FFD53A879E0
    public void IntrospectiveSort(){} // RVA: 0x7FFD53A879F0
    public void IntroSort(){} // RVA: 0x7FFD53A87AE0
    public void PickPivotAndPartition(){} // RVA: 0x7FFD53A87BC0
    public void Heapsort(){} // RVA: 0x7FFD53A87D70
    public void DownHeap(){} // RVA: 0x7FFD53A87E30
    public void InsertionSort(){} // RVA: 0x7FFD53A88080
}

public class SorterObjectArray : ValueType
{
    public object[] keys; // 0x10
    public object[] items; // 0x18
    public mePatterns.eTwoDigitYears comparer; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A866F0
    public void SwapIfGreaterWithItems(){} // RVA: 0x7FFD53A86870
    public void Swap(){} // RVA: 0x7FFD53A86A80
    public void Sort(){} // RVA: 0x7FFD53A86C20
    public void IntrospectiveSort(){} // RVA: 0x7FFD53A86C30
    public void IntroSort(){} // RVA: 0x7FFD53A86D00
    public void PickPivotAndPartition(){} // RVA: 0x7FFD53A86DE0
    public void Heapsort(){} // RVA: 0x7FFD53A86F80
    public void DownHeap(){} // RVA: 0x7FFD53A87040
    public void InsertionSort(){} // RVA: 0x7FFD53A87360
}

public class SortingData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5526E640
}

public class SortingGroupsUpdate : ValueType
{
}

public class Sounds : ValueType
{
}

public class SparseArray`1 : Object
{
    public object Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void get_Current(){} // RVA: 0x7FFD4E078E90
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void Remove(){} // RVA: 0x7FFD4E2ADC40
}

public class SpecialCharacter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54BBFFE0
}

public class Spectrum : Object
{
    public object Item;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4EF4F3D0
    public void .ctor(){} // RVA: 0x7FFD4EF4FA30
    public void Initialize(){} // RVA: 0x7FFD4EF4FAF0
    public void set_Item(){} // RVA: 0x7FFD4EF50150
    public void get_Item(){} // RVA: 0x7FFD4EF507B0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EF50DF0
    public void GetCachedPtr(){} // RVA: 0x7FFD4EF51450
    public void get_name(){} // RVA: 0x7FFD4EF51AB0
    public void set_name(){} // RVA: 0x7FFD4EF52110
}

public class SpriteAtlasManagerUpdate : ValueType
{
}

public class Sprites : ValueType
{
}

public class Sse : Object
{
    public object IsSseSupported;

    // ── Methods ──
    public void get_IsSseSupported(){} // RVA: 0x7FFD4E341320
    public void SHUFFLE(){} // RVA: 0x7FFD5492D5D0
}

public class Sse2 : Object
{
    // ── Methods ──
    public void add_epi64(){} // RVA: 0x7FFD5492D600
    public void mul_epu32(){} // RVA: 0x7FFD5492D620
    public void slli_epi64(){} // RVA: 0x7FFD5492D640
    public void srli_epi64(){} // RVA: 0x7FFD5492D6E0
    public void xor_si128(){} // RVA: 0x7FFD5492D7A0
    public void shuffle_epi32(){} // RVA: 0x7FFD5492D7C0
}

public class StackAllocator : ValueType
{
    public object Handle;

    // ── Methods ──
    public void get_Handle(){} // RVA: 0x7FFD4F840210
    public void Try(){} // RVA: 0x7FFD5492F570 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFD4E341310
    public void Try$BurstManaged(){} // RVA: 0x7FFD5492F5D0
}

public class State : ValueType
{
}

public class StateChangeMonitorListener : ValueType
{
}

public class StateChangeMonitorTimeout : ValueType
{
}

public class StateChangeMonitorsForDevice : ValueType
{
    public object count;

    // ── Methods ──
    public void get_count(){} // RVA: 0x7FFD4E70C4C0
    public void Add(){} // RVA: 0x7FFD54A3DBE0
    public void Remove(){} // RVA: 0x7FFD54A3DF10
    public void Clear(){} // RVA: 0x7FFD54A3DFE0
    public void CompactArrays(){} // RVA: 0x7FFD54A3E080
    public void RemoveAt(){} // RVA: 0x7FFD54A3E0E0
    public void SortMonitorsByIndex(){} // RVA: 0x7FFD54A3E290
}

public class StateChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5132D920
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class StateEventBuffer : ValueType
{
}

public class StaticGetter`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class StaticTypeReinitAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
}

public class StationOccupantDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D24A0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class StationOccupiedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EF032D0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class StatusDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class SteamVR_Utils : Object
{
    // ── Methods ──
    public void IsValid(){} // RVA: 0x7FFD54053DB0 | overloaded x2
    public void Slerp(){} // RVA: 0x7FFD54053E20
    public void Lerp(){} // RVA: 0x7FFD54054000 | overloaded x3
    public void InverseLerp(){} // RVA: 0x7FFD540540A0 | overloaded x3
    public void Saturate(){} // RVA: 0x7FFD540540D0 | overloaded x2
    public void Abs(){} // RVA: 0x7FFD54054130 | overloaded x2
    public void _copysign(){} // RVA: 0x7FFD54054170
    public void GetRotation(){} // RVA: 0x7FFD540541B0
    public void GetPosition(){} // RVA: 0x7FFD540543C0
    public void GetScale(){} // RVA: 0x7FFD540543F0
    public void GetLossyScale(){} // RVA: 0x7FFD54054570
    public void GetBadMD5Hash(){} // RVA: 0x7FFD54054670 | overloaded x2
    public void GetBadMD5HashFromFile(){} // RVA: 0x7FFD54054920
    public void SanitizePath(){} // RVA: 0x7FFD54054990
    public void FindType(){} // RVA: 0x7FFD54054AC0
    public void CallSystemFn(){} // RVA: 0x7FFD54054C10
    public void TakeStereoScreenshot(){} // RVA: 0x7FFD54054DB0
}

public class StringCache : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FEC1C40
    public void Create(){} // RVA: 0x7FFD5722B250
    public void Dispose(){} // RVA: 0x7FFD5722B4C0
    public void Get(){} // RVA: 0x7FFD5722B500
    public void .cctor(){} // RVA: 0x7FFD5722B6D0
}
