// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 25
// Methods: 191

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_Input_Source : Object
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFE87032F20
        public void GetSource(){} // RVA: 0x7FFE87032FD0
        public void GetAllSources(){} // RVA: 0x7FFE87033160
        public void GetPath(){} // RVA: 0x7FFE87033400
        public void Initialize(){} // RVA: 0x7FFE87033540
        public void .cctor(){} // RVA: 0x7FFE87033DD0
    }

    public class SteamVR_Input_Sources_Comparer : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE841063C0
        public void GetHashCode(){} // RVA: 0x7FFE8481AF30
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87030030
    }

    public class SteamVR_LoadLevel : MonoBehaviour
    {
        public Valve.VR.SteamVR_LoadLevel _active;
        public string levelName; // 0x20
        public string internalProcessPath; // 0x28

        // ── Methods ──
        public void get_loading(){} // RVA: 0x7FFE8704D7A0
        public void get_progress(){} // RVA: 0x7FFE8704D890
        public void get_progressTexture(){} // RVA: 0x7FFE8704D9F0
        public void OnEnable(){} // RVA: 0x7FFE8704DB00
        public void Trigger(){} // RVA: 0x7FFE8704DB20
        public void Begin(){} // RVA: 0x7FFE8704DCC0
        public void OnGUI(){} // RVA: 0x7FFE8704DE30
        public void Update(){} // RVA: 0x7FFE8704E5C0
        public void LoadLevel(){} // RVA: 0x7FFE8704E820
        public void GetOverlayHandle(){} // RVA: 0x7FFE8704E8C0
        public void .ctor(){} // RVA: 0x7FFE8704EF00
    }

    public class SteamVR_Menu : MonoBehaviour
    {
        public UnityEngine.Texture cursor; // 0x20
        public UnityEngine.Texture background; // 0x28

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFE87050560
        public void get_scale(){} // RVA: 0x7FFE811240C0
        public void set_scale(){} // RVA: 0x7FFE811240D0
        public void Awake(){} // RVA: 0x7FFE870506B0
        public void OnGUI(){} // RVA: 0x7FFE87050A00
        public void ShowMenu(){} // RVA: 0x7FFE87052150
        public void HideMenu(){} // RVA: 0x7FFE87052830
        public void Update(){} // RVA: 0x7FFE87052AF0
        public void SetScale(){} // RVA: 0x7FFE87052D90
        public void SaveCursorState(){} // RVA: 0x7FFE87052F20
        public void RestoreCursorState(){} // RVA: 0x7FFE87052FC0
        public void .ctor(){} // RVA: 0x7FFE87053070
    }

    public class SteamVR_Overlay : MonoBehaviour
    {
        public UnityEngine.Texture texture; // 0x20
        public float scale; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE870530D0
        public void set_instance(){} // RVA: 0x7FFE87053110
        public void get_key(){} // RVA: 0x7FFE870531B0
        public void OnEnable(){} // RVA: 0x7FFE870532C0
        public void OnDisable(){} // RVA: 0x7FFE870534A0
        public void UpdateOverlay(){} // RVA: 0x7FFE87053500
        public void PollNextEvent(){} // RVA: 0x7FFE87053BC0
        public void ComputeIntersection(){} // RVA: 0x7FFE87053CD0
        public void .ctor(){} // RVA: 0x7FFE87053EB0
    }

    public class SteamVR_PlayArea : MonoBehaviour
    {
        // ── Methods ──
        public void GetBounds(){} // RVA: 0x7FFE87053F30
        public void BuildMesh(){} // RVA: 0x7FFE87054240
        public void OnDrawGizmos(){} // RVA: 0x7FFE87055010
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE87055020
        public void DrawWireframe(){} // RVA: 0x7FFE87055030
        public void OnEnable(){} // RVA: 0x7FFE87055600
        public void UpdateBounds(){} // RVA: 0x7FFE87055810
        public void .ctor(){} // RVA: 0x7FFE870558B0
    }

    public class SteamVR_Render : MonoBehaviour
    {
        public Valve.VR.SteamVR_ExternalCamera externalCamera; // 0x20
        public string externalCameraConfigPath; // 0x28
        public 0x666397E4 _eye;

        // ── Methods ──
        public void get_eye(){} // RVA: 0x7FFE87055B70
        public void set_eye(){} // RVA: 0x7FFE87055BB0
        public void get_instance(){} // RVA: 0x7FFE87055BF0
        public void OnApplicationQuit(){} // RVA: 0x7FFE87055C50
        public void Add(){} // RVA: 0x7FFE87055CC0
        public void Remove(){} // RVA: 0x7FFE8703F0F0
        public void Top(){} // RVA: 0x7FFE87055D70
        public void AddInternal(){} // RVA: 0x7FFE87055E30
        public void RemoveInternal(){} // RVA: 0x7FFE870560C0
        public void TopInternal(){} // RVA: 0x7FFE87056450
        public void get_pauseRendering(){} // RVA: 0x7FFE87056490
        public void set_pauseRendering(){} // RVA: 0x7FFE870564D0
        public void RenderLoop(){} // RVA: 0x7FFE87056560
        public void CheckExternalCamera(){} // RVA: 0x7FFE87056600
        public void RenderExternalCamera(){} // RVA: 0x7FFE87057060
        public void OnInputFocus(){} // RVA: 0x7FFE870572B0
        public void GetScreenshotFilename(){} // RVA: 0x7FFE870573D0
        public void OnRequestScreenshot(){} // RVA: 0x7FFE87057540
        public void OnEnable(){} // RVA: 0x7FFE87057A20
        public void OnSteamVRInitialized(){} // RVA: 0x7FFE87058010
        public void OnDisable(){} // RVA: 0x7FFE87058070
        public void UpdatePoses(){} // RVA: 0x7FFE87058410
        public void OnBeforeRender(){} // RVA: 0x7FFE87058540
        public void Update(){} // RVA: 0x7FFE87058610
        public void .ctor(){} // RVA: 0x7FFE87058B70
    }

    public class SteamVR_RenderModel : MonoBehaviour
    {
        public 0x66604BFC index; // 0x20
        public 0x6660354C inputSource; // 0x24

        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0x7FFE81178740
        public void set_renderModelName(){} // RVA: 0x7FFE81123200
        public void get_initializedAttachPoints(){} // RVA: 0x7FFE811B2D30
        public void set_initializedAttachPoints(){} // RVA: 0x7FFE811B2D40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x7FFE870592A0
        public void SetMeshRendererState(){} // RVA: 0x7FFE87059350
        public void OnHideRenderModels(){} // RVA: 0x7FFE870594E0
        public void OnDeviceConnected(){} // RVA: 0x7FFE870594F0
        public void UpdateModel(){} // RVA: 0x7FFE87059510
        public void SetModelAsync(){} // RVA: 0x7FFE87059840
        public void SetModel(){} // RVA: 0x7FFE87059940
        public void LoadRenderModel(){} // RVA: 0x7FFE87059F50
        public void ConvertByteColorGammaExp(){} // RVA: 0x7FFE8705B590
        public void FreeRenderModel(){} // RVA: 0x7FFE8705B5F0
        public void FindTransformByName(){} // RVA: 0x7FFE8705B640
        public void GetComponentTransform(){} // RVA: 0x7FFE8705B870
        public void StripMesh(){} // RVA: 0x7FFE8705B970
        public void LoadComponents(){} // RVA: 0x7FFE8705BB60
        public void .ctor(){} // RVA: 0x7FFE8705C840
        public void OnEnable(){} // RVA: 0x7FFE8705CC60
        public void OnDisable(){} // RVA: 0x7FFE8705CDD0
        public void Update(){} // RVA: 0x7FFE8705CE40
        public void UpdateComponents(){} // RVA: 0x7FFE8705CE90
        public void SetDeviceIndex(){} // RVA: 0x7FFE8705D8F0
        public void SetInputSource(){} // RVA: 0x7FFE82447980
        public void Sleep(){} // RVA: 0x7FFE8705D9D0
        public void MarshalRenderModel(){} // RVA: 0x7FFE8705D9E0
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x7FFE8705DC10
        public void .cctor(){} // RVA: 0x7FFE8705DE40
    }

    public class SteamVR_RingBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE810A1420
        public void StepForward(){} // RVA: 0x7FFE80E45FE0
        public void GetAtIndex(){} // RVA: 0x7FFE810A1420
        public void GetLast(){} // RVA: 0x7FFE810A1420
        public void GetLastIndex(){} // RVA: 0x7FFE80E2EDB0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
    }

    public class SteamVR_Settings : ScriptableObject
    {
        public Valve.VR.SteamVR_Settings _instance;
        public bool pauseGameWhenDashboardVisible; // 0x18

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE8705FA70
        public void get_trackingSpace(){} // RVA: 0x7FFE82707EE0
        public void set_trackingSpace(){} // RVA: 0x7FFE8705FAC0
        public void IsInputUpdateMode(){} // RVA: 0x7FFE8705FB40
        public void IsPoseUpdateMode(){} // RVA: 0x7FFE8705FB50
        public void VerifyScriptableObject(){} // RVA: 0x7FFE8705FB60
        public void LoadInstance(){} // RVA: 0x7FFE8705FB70
        public void Save(){} // RVA: 0x7FFE810FB310
        public void SetDefaultsIfNeeded(){} // RVA: 0x7FFE8705FE30
        public void FindDefaultPreviewHand(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE87060040
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists : Object
    {
        public 0x66603654[] _enumList; // 0x10
        public string[] _stringList; // 0x18

        // ── Methods ──
        public void get_enumList(){} // RVA: 0x7FFE87034470
        public void get_stringList(){} // RVA: 0x7FFE87034680
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Skeleton_FingerIndexes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86FF9E30
    }

    public class SteamVR_Skeleton_FingerSplayIndexes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86FFA0A0
    }

    public class SteamVR_Skeleton_HandMask : Object
    {
        // ── Methods ──
        public void SetFinger(){} // RVA: 0x7FFE870380F0
        public void GetFinger(){} // RVA: 0x7FFE87038130
        public void .ctor(){} // RVA: 0x7FFE87038160
        public void Reset(){} // RVA: 0x7FFE87038320
        public void Apply(){} // RVA: 0x7FFE870383E0
        public void .cctor(){} // RVA: 0x7FFE870384A0
    }

    public class SteamVR_Skeleton_JointIndexes : Object
    {
        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x7FFE86FF9D70
        public void GetBoneForFingerTip(){} // RVA: 0x7FFE86FF9DF0
    }

    public class SteamVR_Skeleton_Pose : ScriptableObject
    {
        // ── Methods ──
        public void GetHand(){} // RVA: 0x7FFE870341D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE870341F0
    }

    public class SteamVR_Skeleton_PoseSnapshot : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87037E50
        public void CopyFrom(){} // RVA: 0x7FFE87037FF0
    }

    public class SteamVR_Skeleton_Pose_Hand : Object
    {
        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x7FFE87034320
        public void .ctor(){} // RVA: 0x7FFE870343F0
        public void GetMovementTypeForBone(){} // RVA: 0x7FFE87034400
    }

    public class SteamVR_Skeleton_Poser : MonoBehaviour
    {
        public bool poseEditorExpanded; // 0x20

        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x7FFE87034A10
        public void Awake(){} // RVA: 0x7FFE87034A30
        public void SetBlendingBehaviourValue(){} // RVA: 0x7FFE87034F80
        public void GetBlendingBehaviourValue(){} // RVA: 0x7FFE87035050
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x7FFE87035080
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x7FFE870350B0
        public void GetBlendingBehaviour(){} // RVA: 0x7FFE870350E0
        public void FindBlendingBehaviour(){} // RVA: 0x7FFE870350F0
        public void GetPoseByIndex(){} // RVA: 0x7FFE87035300
        public void GetHandSnapshot(){} // RVA: 0x7FFE87035390
        public void GetBlendedPose(){} // RVA: 0x7FFE870353F0 | overloaded x2
        public void UpdatePose(){} // RVA: 0x7FFE87035440
        public void ApplyBlenderBehaviours(){} // RVA: 0x7FFE87035720
        public void LateUpdate(){} // RVA: 0x7FFE870359E0
        public void BlendVectors(){} // RVA: 0x7FFE870359F0
        public void BlendQuaternions(){} // RVA: 0x7FFE87035AF0
        public void GetTargetHandPosition(){} // RVA: 0x7FFE87035DE0
        public void GetTargetHandRotation(){} // RVA: 0x7FFE870363E0
        public void .ctor(){} // RVA: 0x7FFE87036AA0
    }

    public class SteamVR_Skybox : MonoBehaviour
    {
        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x7FFE87060280
        public void GetTextureByIndex(){} // RVA: 0x7FFE87060310
        public void SetOverride(){} // RVA: 0x7FFE87060370
        public void ClearOverride(){} // RVA: 0x7FFE87060880
        public void OnEnable(){} // RVA: 0x7FFE870608D0
        public void OnDisable(){} // RVA: 0x7FFE87060880
        public void .ctor(){} // RVA: 0x7FFE87060910
    }

    public class SteamVR_SphericalProjection : MonoBehaviour
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7FFE87060970
        public void OnRenderImage(){} // RVA: 0x7FFE87060F60
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_TrackedCamera : Object
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x7FFE87060FF0
        public void Undistorted(){} // RVA: 0x7FFE87061190
        public void Source(){} // RVA: 0x7FFE87061340
        public void Stream(){} // RVA: 0x7FFE87061680
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_TrackedObject : MonoBehaviour
    {
        public 0x66604BFC index; // 0x20

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFE81121450
        public void set_isValid(){} // RVA: 0x7FFE81121460
        public void OnNewPoses(){} // RVA: 0x7FFE87062470
        public void .ctor(){} // RVA: 0x7FFE87062A50
        public void Awake(){} // RVA: 0x7FFE87062B70
        public void OnEnable(){} // RVA: 0x7FFE87062B70
        public void OnDisable(){} // RVA: 0x7FFE87062D00
        public void SetDeviceIndex(){} // RVA: 0x7FFE87062D40
    }

    public class SteamVR_TrackingReferenceManager : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE87062F00
        public void OnDisable(){} // RVA: 0x7FFE87062FE0
        public void OnNewPoses(){} // RVA: 0x7FFE870630F0
        public void .ctor(){} // RVA: 0x7FFE87063480
    }

}