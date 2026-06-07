// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 25
// Methods: 191

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_Input_Source
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x64F3EA0
        public void GetSource(){} // RVA: 0x64F3F50
        public void GetAllSources(){} // RVA: 0x64F40E0
        public void GetPath(){} // RVA: 0x64F4380
        public void Initialize(){} // RVA: 0x64F44C0
        public void .cctor(){} // RVA: 0x64F4D50
    }

    public class SteamVR_Input_Sources_Comparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x3471600
        public void GetHashCode(){} // RVA: 0x3B45020
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F0FB0
    }

    public class SteamVR_LoadLevel
    {
        // ── Methods ──
        public void get_loading(){} // RVA: 0x650E720
        public void get_progress(){} // RVA: 0x650E810
        public void get_progressTexture(){} // RVA: 0x650E970
        public void OnEnable(){} // RVA: 0x650EA80
        public void Trigger(){} // RVA: 0x650EAA0
        public void Begin(){} // RVA: 0x650EC40
        public void OnGUI(){} // RVA: 0x650EDB0
        public void Update(){} // RVA: 0x650F540
        public void LoadLevel(){} // RVA: 0x650F7A0
        public void GetOverlayHandle(){} // RVA: 0x650F840
        public void .ctor(){} // RVA: 0x650FE80
    }

    public class SteamVR_Menu
    {
        public object _texture;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x65114E0
        public void get_scale(){} // RVA: 0x3060C0
        public void set_scale(){} // RVA: 0x3060D0
        public void Awake(){} // RVA: 0x6511630
        public void OnGUI(){} // RVA: 0x6511980
        public void ShowMenu(){} // RVA: 0x65130D0
        public void HideMenu(){} // RVA: 0x65137B0
        public void Update(){} // RVA: 0x6513A70
        public void SetScale(){} // RVA: 0x6513D10
        public void SaveCursorState(){} // RVA: 0x6513EA0
        public void RestoreCursorState(){} // RVA: 0x6513F40
        public void .ctor(){} // RVA: 0x6513FF0
    }

    public class SteamVR_Overlay
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x6514050
        public void set_instance(){} // RVA: 0x6514090
        public void get_key(){} // RVA: 0x6514130
        public void OnEnable(){} // RVA: 0x6514240
        public void OnDisable(){} // RVA: 0x6514420
        public void UpdateOverlay(){} // RVA: 0x6514480
        public void PollNextEvent(){} // RVA: 0x6514B40
        public void ComputeIntersection(){} // RVA: 0x6514C50
        public void .ctor(){} // RVA: 0x6514E30
    }

    public class SteamVR_PlayArea
    {
        // ── Methods ──
        public void GetBounds(){} // RVA: 0x6514EB0
        public void BuildMesh(){} // RVA: 0x65151C0
        public void OnDrawGizmos(){} // RVA: 0x6515F90
        public void OnDrawGizmosSelected(){} // RVA: 0x6515FA0
        public void DrawWireframe(){} // RVA: 0x6515FB0
        public void OnEnable(){} // RVA: 0x6516580
        public void UpdateBounds(){} // RVA: 0x6516790
        public void .ctor(){} // RVA: 0x6516830
    }

    public class SteamVR_Render
    {
        // ── Methods ──
        public void get_eye(){} // RVA: 0x6516AF0
        public void set_eye(){} // RVA: 0x6516B30
        public void get_instance(){} // RVA: 0x6516B70
        public void OnApplicationQuit(){} // RVA: 0x6516BD0
        public void Add(){} // RVA: 0x6516C40
        public void Remove(){} // RVA: 0x6500070
        public void Top(){} // RVA: 0x6516CF0
        public void AddInternal(){} // RVA: 0x6516DB0
        public void RemoveInternal(){} // RVA: 0x6517040
        public void TopInternal(){} // RVA: 0x65173D0
        public void get_pauseRendering(){} // RVA: 0x6517410
        public void set_pauseRendering(){} // RVA: 0x6517450
        public void RenderLoop(){} // RVA: 0x65174E0
        public void CheckExternalCamera(){} // RVA: 0x6517580
        public void RenderExternalCamera(){} // RVA: 0x6517FE0
        public void OnInputFocus(){} // RVA: 0x6518230
        public void GetScreenshotFilename(){} // RVA: 0x6518350
        public void OnRequestScreenshot(){} // RVA: 0x65184C0
        public void OnEnable(){} // RVA: 0x65189A0
        public void OnSteamVRInitialized(){} // RVA: 0x6518F90
        public void OnDisable(){} // RVA: 0x6518FF0
        public void UpdatePoses(){} // RVA: 0x6519390
        public void OnBeforeRender(){} // RVA: 0x65194C0
        public void Update(){} // RVA: 0x6519590
        public void .ctor(){} // RVA: 0x6519AF0
    }

    public class SteamVR_RenderModel
    {
        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0x35A740
        public void set_renderModelName(){} // RVA: 0x305200
        public void get_initializedAttachPoints(){} // RVA: 0x394D30
        public void set_initializedAttachPoints(){} // RVA: 0x394D40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x651A220
        public void SetMeshRendererState(){} // RVA: 0x651A2D0
        public void OnHideRenderModels(){} // RVA: 0x651A460
        public void OnDeviceConnected(){} // RVA: 0x651A470
        public void UpdateModel(){} // RVA: 0x651A490
        public void SetModelAsync(){} // RVA: 0x651A7C0
        public void SetModel(){} // RVA: 0x651A8C0
        public void LoadRenderModel(){} // RVA: 0x651AED0
        public void ConvertByteColorGammaExp(){} // RVA: 0x651C510
        public void FreeRenderModel(){} // RVA: 0x651C570
        public void FindTransformByName(){} // RVA: 0x651C5C0
        public void GetComponentTransform(){} // RVA: 0x651C7F0
        public void StripMesh(){} // RVA: 0x651C8F0
        public void LoadComponents(){} // RVA: 0x651CAE0
        public void .ctor(){} // RVA: 0x651D7C0
        public void OnEnable(){} // RVA: 0x651DBE0
        public void OnDisable(){} // RVA: 0x651DD50
        public void Update(){} // RVA: 0x651DDC0
        public void UpdateComponents(){} // RVA: 0x651DE10
        public void SetDeviceIndex(){} // RVA: 0x651E870
        public void SetInputSource(){} // RVA: 0x16E1F00
        public void Sleep(){} // RVA: 0x651E950
        public void MarshalRenderModel(){} // RVA: 0x651E960
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x651EB90
        public void .cctor(){} // RVA: 0x651EDC0
    }

    public class SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x283FA0
        public void StepForward(){} // RVA: 0x24A50
        public void GetAtIndex(){} // RVA: 0x283FA0
        public void GetLast(){} // RVA: 0x283FA0
        public void GetLastIndex(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
    }

    public class SteamVR_Settings
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x65209F0
        public void get_trackingSpace(){} // RVA: 0x197C3B0
        public void set_trackingSpace(){} // RVA: 0x6520A40
        public void IsInputUpdateMode(){} // RVA: 0x6520AC0
        public void IsPoseUpdateMode(){} // RVA: 0x6520AD0
        public void VerifyScriptableObject(){} // RVA: 0x6520AE0
        public void LoadInstance(){} // RVA: 0x6520AF0
        public void Save(){} // RVA: 0x2DD310
        public void SetDefaultsIfNeeded(){} // RVA: 0x6520DB0
        public void FindDefaultPreviewHand(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x6520FC0
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists
    {
        // ── Methods ──
        public void get_enumList(){} // RVA: 0x64F53F0
        public void get_stringList(){} // RVA: 0x64F5600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Skeleton_FingerIndexes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x64BAD80
    }

    public class SteamVR_Skeleton_FingerSplayIndexes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x64BAFF0
    }

    public class SteamVR_Skeleton_HandMask
    {
        // ── Methods ──
        public void SetFinger(){} // RVA: 0x64F9070
        public void GetFinger(){} // RVA: 0x64F90B0
        public void .ctor(){} // RVA: 0x64F90E0
        public void Reset(){} // RVA: 0x64F92A0
        public void Apply(){} // RVA: 0x64F9360
        public void .cctor(){} // RVA: 0x64F9420
    }

    public class SteamVR_Skeleton_JointIndexes
    {
        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x64BACC0
        public void GetBoneForFingerTip(){} // RVA: 0x64BAD40
    }

    public class SteamVR_Skeleton_Pose
    {
        // ── Methods ──
        public void GetHand(){} // RVA: 0x64F5150 | overloaded x2
        public void .ctor(){} // RVA: 0x64F5170
    }

    public class SteamVR_Skeleton_PoseSnapshot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F8DD0
        public void CopyFrom(){} // RVA: 0x64F8F70
    }

    public class SteamVR_Skeleton_Pose_Hand
    {
        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x64F52A0
        public void .ctor(){} // RVA: 0x64F5370
        public void GetMovementTypeForBone(){} // RVA: 0x64F5380
    }

    public class SteamVR_Skeleton_Poser
    {
        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x64F5990
        public void Awake(){} // RVA: 0x64F59B0
        public void SetBlendingBehaviourValue(){} // RVA: 0x64F5F00
        public void GetBlendingBehaviourValue(){} // RVA: 0x64F5FD0
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x64F6000
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x64F6030
        public void GetBlendingBehaviour(){} // RVA: 0x64F6060
        public void FindBlendingBehaviour(){} // RVA: 0x64F6070
        public void GetPoseByIndex(){} // RVA: 0x64F6280
        public void GetHandSnapshot(){} // RVA: 0x64F6310
        public void GetBlendedPose(){} // RVA: 0x64F6370 | overloaded x2
        public void UpdatePose(){} // RVA: 0x64F63C0
        public void ApplyBlenderBehaviours(){} // RVA: 0x64F66A0
        public void LateUpdate(){} // RVA: 0x64F6960
        public void BlendVectors(){} // RVA: 0x64F6970
        public void BlendQuaternions(){} // RVA: 0x64F6A70
        public void GetTargetHandPosition(){} // RVA: 0x64F6D60
        public void GetTargetHandRotation(){} // RVA: 0x64F7360
        public void .ctor(){} // RVA: 0x64F7A20
    }

    public class SteamVR_Skybox
    {
        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x6521200
        public void GetTextureByIndex(){} // RVA: 0x6521290
        public void SetOverride(){} // RVA: 0x65212F0
        public void ClearOverride(){} // RVA: 0x6521800
        public void OnEnable(){} // RVA: 0x6521850
        public void OnDisable(){} // RVA: 0x6521800
        public void .ctor(){} // RVA: 0x6521890
    }

    public class SteamVR_SphericalProjection
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x65218F0
        public void OnRenderImage(){} // RVA: 0x6521EE0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_TrackedCamera
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x6521F70
        public void Undistorted(){} // RVA: 0x6522110
        public void Source(){} // RVA: 0x65222C0
        public void Stream(){} // RVA: 0x6522600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_TrackedObject
    {
        // ── Methods ──
        public void get_isValid(){} // RVA: 0x303450
        public void set_isValid(){} // RVA: 0x303460
        public void OnNewPoses(){} // RVA: 0x65233F0
        public void .ctor(){} // RVA: 0x65239D0
        public void Awake(){} // RVA: 0x6523AF0
        public void OnEnable(){} // RVA: 0x6523AF0
        public void OnDisable(){} // RVA: 0x6523C80
        public void SetDeviceIndex(){} // RVA: 0x6523CC0
    }

    public class SteamVR_TrackingReferenceManager
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6523E80
        public void OnDisable(){} // RVA: 0x6523F60
        public void OnNewPoses(){} // RVA: 0x6524070
        public void .ctor(){} // RVA: 0x6524400
    }

}