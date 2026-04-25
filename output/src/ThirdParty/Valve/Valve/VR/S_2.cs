// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 25
// Methods: 191

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_Input_Source : Object
    {
        public int numSources;
        public ulong[] inputSourceHandlesBySource; // 0x8
        public System.Collections.Generic.Dictionary`2<ulong,0x6B209C88> inputSourceSourcesByHandle; // 0x10
        public System.Type enumType; // 0x18
        public System.Type descriptionType; // 0x20
        public 0x6B209C88[] allSources; // 0x28

        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFAC8C8AA30
        public void GetSource(){} // RVA: 0x7FFAC8C8AAE0
        public void GetAllSources(){} // RVA: 0x7FFAC8C8AC70
        public void GetPath(){} // RVA: 0x7FFAC8C8AF10
        public void Initialize(){} // RVA: 0x7FFAC8C8B050
        public void .cctor(){} // RVA: 0x7FFAC8C8B8E0
    }

    public class SteamVR_Input_Sources_Comparer : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC5D9E3D0
        public void GetHashCode(){} // RVA: 0x7FFAC5DEA830
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition : Object
    {
        public string name; // 0x10
        public string[] references; // 0x18
        public string[] optionalUnityReferences; // 0x20
        public string[] includePlatforms; // 0x28
        public string[] excludePlatforms; // 0x30
        public bool allowUnsafeCode; // 0x38
        public bool overrideReferences; // 0x39
        public string[] precompiledReferences; // 0x40
        public bool autoReferenced; // 0x48
        public string[] defineConstraints; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C87B40
    }

    public class SteamVR_LoadLevel : MonoBehaviour
    {
        public Valve.VR.SteamVR_LoadLevel loading;
        public string progress; // 0x20
        public string progressTexture; // 0x28
        public string internalProcessArgs; // 0x30
        public bool loadAdditive; // 0x38
        public bool loadAsync; // 0x39
        public UnityEngine.Texture loadingScreen; // 0x40
        public UnityEngine.Texture progressBarEmpty; // 0x48
        public UnityEngine.Texture progressBarFull; // 0x50
        public float loadingScreenWidthInMeters; // 0x58
        public float progressBarWidthInMeters; // 0x5C
        public float loadingScreenDistance; // 0x60
        public UnityEngine.Transform loadingScreenTransform; // 0x68
        public UnityEngine.Transform progressBarTransform; // 0x70
        public UnityEngine.Texture front; // 0x78
        public UnityEngine.Texture back; // 0x80
        public UnityEngine.Texture left; // 0x88
        public UnityEngine.Texture right; // 0x90
        public UnityEngine.Texture top; // 0x98
        public UnityEngine.Texture bottom; // 0xA0
        public UnityEngine.Color backgroundColor; // 0xA8
        public bool showGrid; // 0xB8
        public float fadeOutTime; // 0xBC
        public float fadeInTime; // 0xC0
        public float postLoadSettleTime; // 0xC4
        public float loadingScreenFadeInTime; // 0xC8
        public float loadingScreenFadeOutTime; // 0xCC
        public float fadeRate; // 0xD0
        public float alpha; // 0xD4
        public UnityEngine.AsyncOperation async; // 0xD8
        public UnityEngine.RenderTexture renderTexture; // 0xE0
        public ulong loadingScreenOverlayHandle; // 0xE8
        public ulong progressBarOverlayHandle; // 0xF0
        public bool autoTriggerOnEnable; // 0xF8

        // ── Methods ──
        public void get_loading(){} // RVA: 0x7FFAC8CA52B0
        public void get_progress(){} // RVA: 0x7FFAC8CA53A0
        public void get_progressTexture(){} // RVA: 0x7FFAC8CA5500
        public void OnEnable(){} // RVA: 0x7FFAC8CA5610
        public void Trigger(){} // RVA: 0x7FFAC8CA5630
        public void Begin(){} // RVA: 0x7FFAC8CA57D0
        public void OnGUI(){} // RVA: 0x7FFAC8CA5940
        public void Update(){} // RVA: 0x7FFAC8CA60D0
        public void LoadLevel(){} // RVA: 0x7FFAC8CA6330
        public void GetOverlayHandle(){} // RVA: 0x7FFAC8CA63D0
        public void .ctor(){} // RVA: 0x7FFAC8CA6A10
    }

    public class SteamVR_Menu : MonoBehaviour
    {
        public UnityEngine.Texture texture; // 0x20
        public UnityEngine.Texture scale; // 0x28
        public UnityEngine.Texture logo; // 0x30
        public float logoHeight; // 0x38
        public float menuOffset; // 0x3C
        public UnityEngine.Vector2 scaleLimits; // 0x40
        public float scaleRate; // 0x48
        public Valve.VR.SteamVR_Overlay overlay; // 0x50
        public UnityEngine.Camera overlayCam; // 0x58
        public UnityEngine.Vector4 uvOffset; // 0x60
        public float distance; // 0x70
        public float <scale>k__BackingField; // 0x74
        public string scaleLimitX; // 0x78
        public string scaleLimitY; // 0x80
        public string scaleRateText; // 0x88
        public 0x6B17D0F8 savedCursorLockState; // 0x90
        public bool savedCursorVisible; // 0x94

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFAC8CA8070
        public void get_scale(){} // RVA: 0x7FFAC2F4A0C0
        public void set_scale(){} // RVA: 0x7FFAC2F4A0D0
        public void Awake(){} // RVA: 0x7FFAC8CA81C0
        public void OnGUI(){} // RVA: 0x7FFAC8CA8510
        public void ShowMenu(){} // RVA: 0x7FFAC8CA9C60
        public void HideMenu(){} // RVA: 0x7FFAC8CAA340
        public void Update(){} // RVA: 0x7FFAC8CAA600
        public void SetScale(){} // RVA: 0x7FFAC8CAA8A0
        public void SaveCursorState(){} // RVA: 0x7FFAC8CAAA30
        public void RestoreCursorState(){} // RVA: 0x7FFAC8CAAAD0
        public void .ctor(){} // RVA: 0x7FFAC8CAAB80
    }

    public class SteamVR_Overlay : MonoBehaviour
    {
        public UnityEngine.Texture instance; // 0x20
        public float key; // 0x28
        public float distance; // 0x2C
        public float alpha; // 0x30
        public UnityEngine.Vector4 uvOffset; // 0x34
        public UnityEngine.Vector2 mouseScale; // 0x44
        public 0x6B240F48 inputMethod; // 0x4C
        public Valve.VR.SteamVR_Overlay <instance>k__BackingField;
        public ulong handle; // 0x50

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC8CAABE0
        public void set_instance(){} // RVA: 0x7FFAC8CAAC20
        public void get_key(){} // RVA: 0x7FFAC8CAACC0
        public void OnEnable(){} // RVA: 0x7FFAC8CAADD0
        public void OnDisable(){} // RVA: 0x7FFAC8CAAFB0
        public void UpdateOverlay(){} // RVA: 0x7FFAC8CAB010
        public void PollNextEvent(){} // RVA: 0x7FFAC8CAB6D0
        public void ComputeIntersection(){} // RVA: 0x7FFAC8CAB7E0
        public void .ctor(){} // RVA: 0x7FFAC8CAB9C0
    }

    public class SteamVR_PlayArea : MonoBehaviour
    {
        public float borderThickness; // 0x20
        public float wireframeHeight; // 0x24
        public bool drawWireframeWhenSelectedOnly; // 0x28
        public bool drawInGame; // 0x29
        public 0x6B20AC58 size; // 0x2C
        public UnityEngine.Color color; // 0x30
        public UnityEngine.Vector3[] vertices; // 0x40

        // ── Methods ──
        public void GetBounds(){} // RVA: 0x7FFAC8CABA40
        public void BuildMesh(){} // RVA: 0x7FFAC8CABD50
        public void OnDrawGizmos(){} // RVA: 0x7FFAC8CACB20
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC8CACB30
        public void DrawWireframe(){} // RVA: 0x7FFAC8CACB40
        public void OnEnable(){} // RVA: 0x7FFAC8CAD110
        public void UpdateBounds(){} // RVA: 0x7FFAC8CAD320
        public void .ctor(){} // RVA: 0x7FFAC8CAD3C0
    }

    public class SteamVR_Render : MonoBehaviour
    {
        public Valve.VR.SteamVR_ExternalCamera eye; // 0x20
        public string instance; // 0x28
        public 0x6B23FE18 pauseRendering;
        public bool isQuitting; // 0x4
        public Valve.VR.SteamVR_Camera[] cameras; // 0x30
        public Valve.VR.TrackedDevicePose_t[] poses; // 0x38
        public Valve.VR.TrackedDevicePose_t[] gamePoses; // 0x40
        public bool _pauseRendering; // 0x5
        public UnityEngine.WaitForEndOfFrame waitForEndOfFrame; // 0x48
        public System.Nullable`1<bool> doesPathExist; // 0x50
        public float timeScale; // 0x54
        public 0x6B240970[] screenshotTypes; // 0x58

        // ── Methods ──
        public void get_eye(){} // RVA: 0x7FFAC8CAD680
        public void set_eye(){} // RVA: 0x7FFAC8CAD6C0
        public void get_instance(){} // RVA: 0x7FFAC8CAD700
        public void OnApplicationQuit(){} // RVA: 0x7FFAC8CAD760
        public void Add(){} // RVA: 0x7FFAC8CAD7D0
        public void Remove(){} // RVA: 0x7FFAC8C96C00
        public void Top(){} // RVA: 0x7FFAC8CAD880
        public void AddInternal(){} // RVA: 0x7FFAC8CAD940
        public void RemoveInternal(){} // RVA: 0x7FFAC8CADBD0
        public void TopInternal(){} // RVA: 0x7FFAC8CADF60
        public void get_pauseRendering(){} // RVA: 0x7FFAC8CADFA0
        public void set_pauseRendering(){} // RVA: 0x7FFAC8CADFE0
        public void RenderLoop(){} // RVA: 0x7FFAC8CAE070
        public void CheckExternalCamera(){} // RVA: 0x7FFAC8CAE110
        public void RenderExternalCamera(){} // RVA: 0x7FFAC8CAEB70
        public void OnInputFocus(){} // RVA: 0x7FFAC8CAEDC0
        public void GetScreenshotFilename(){} // RVA: 0x7FFAC8CAEEE0
        public void OnRequestScreenshot(){} // RVA: 0x7FFAC8CAF050
        public void OnEnable(){} // RVA: 0x7FFAC8CAF530
        public void OnSteamVRInitialized(){} // RVA: 0x7FFAC8CAFB20
        public void OnDisable(){} // RVA: 0x7FFAC8CAFB80
        public void UpdatePoses(){} // RVA: 0x7FFAC8CAFF20
        public void OnBeforeRender(){} // RVA: 0x7FFAC8CB0050
        public void Update(){} // RVA: 0x7FFAC8CB0120
        public void .ctor(){} // RVA: 0x7FFAC8CB0680
    }

    public class SteamVR_RenderModel : MonoBehaviour
    {
        public 0x6B20B338 renderModelName; // 0x20
        public 0x6B209C88 initializedAttachPoints; // 0x24
        public string modelOverrideWarning;
        public string modelOverride; // 0x28
        public UnityEngine.Shader shader; // 0x30
        public bool verbose; // 0x38
        public bool createComponents; // 0x39
        public bool updateDynamically; // 0x3A
        public Valve.VR.RenderModel_ControllerMode_State_t controllerModeState; // 0x3B
        public string k_localTransformName;
        public string <renderModelName>k__BackingField; // 0x40
        public bool <initializedAttachPoints>k__BackingField; // 0x48
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Transform> componentAttachPoints; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.MeshRenderer> meshRenderers; // 0x58
        public System.Collections.Hashtable models;
        public System.Collections.Hashtable materials; // 0x8
        public Action deviceConnectedAction; // 0x60
        public Action hideRenderModelsAction; // 0x68
        public Action modelSkinSettingsHaveChangedAction; // 0x70
        public System.Collections.Generic.Dictionary`2<int,string> nameCache; // 0x78

        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0x7FFAC2F9E740
        public void set_renderModelName(){} // RVA: 0x7FFAC2F49200
        public void get_initializedAttachPoints(){} // RVA: 0x7FFAC2FD8D30
        public void set_initializedAttachPoints(){} // RVA: 0x7FFAC2FD8D40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x7FFAC8CB0DB0
        public void SetMeshRendererState(){} // RVA: 0x7FFAC8CB0E60
        public void OnHideRenderModels(){} // RVA: 0x7FFAC8CB0FF0
        public void OnDeviceConnected(){} // RVA: 0x7FFAC8CB1000
        public void UpdateModel(){} // RVA: 0x7FFAC8CB1020
        public void SetModelAsync(){} // RVA: 0x7FFAC8CB1350
        public void SetModel(){} // RVA: 0x7FFAC8CB1450
        public void LoadRenderModel(){} // RVA: 0x7FFAC8CB1A60
        public void ConvertByteColorGammaExp(){} // RVA: 0x7FFAC8CB30A0
        public void FreeRenderModel(){} // RVA: 0x7FFAC8CB3100
        public void FindTransformByName(){} // RVA: 0x7FFAC8CB3150
        public void GetComponentTransform(){} // RVA: 0x7FFAC8CB3380
        public void StripMesh(){} // RVA: 0x7FFAC8CB3480
        public void LoadComponents(){} // RVA: 0x7FFAC8CB3670
        public void .ctor(){} // RVA: 0x7FFAC8CB4350
        public void OnEnable(){} // RVA: 0x7FFAC8CB4770
        public void OnDisable(){} // RVA: 0x7FFAC8CB48E0
        public void Update(){} // RVA: 0x7FFAC8CB4950
        public void UpdateComponents(){} // RVA: 0x7FFAC8CB49A0
        public void SetDeviceIndex(){} // RVA: 0x7FFAC8CB5400
        public void SetInputSource(){} // RVA: 0x7FFAC41674D0
        public void Sleep(){} // RVA: 0x7FFAC8CB54E0
        public void MarshalRenderModel(){} // RVA: 0x7FFAC8CB54F0
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x7FFAC8CB5720
        public void .cctor(){} // RVA: 0x7FFAC8CB5950
    }

    public class SteamVR_RingBuffer`1 : Object
    {
        public bool UseDateTimeForTicks;
        public T[] buffer;
        public int currentIndex;
        public T lastElement;
        public bool cleared;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void StepForward(){} // RVA: 0x7FFAC2C70980
        public void GetAtIndex(){} // RVA: 0x7FFAC2E8DC40
        public void GetLast(){} // RVA: 0x7FFAC2E8DC40
        public void GetLastIndex(){} // RVA: 0x7FFAC2C59960
        public void Clear(){} // RVA: 0x7FFAC2C70980
    }

    public class SteamVR_Settings : ScriptableObject
    {
        public Valve.VR.SteamVR_Settings instance;
        public bool trackingSpace; // 0x18
        public bool lockPhysicsUpdateRateToRenderFrequency; // 0x19
        public 0x6B240028 trackingSpaceOrigin; // 0x1C
        public string actionsFilePath; // 0x20
        public string steamVRInputPath; // 0x28
        public 0x6B20A100 inputUpdateMode; // 0x30
        public 0x6B20A100 poseUpdateMode; // 0x34
        public bool activateFirstActionSetOnStart; // 0x38
        public string editorAppKey; // 0x40
        public bool autoEnableVR; // 0x48
        public bool legacyMixedRealityCamera; // 0x49
        public Valve.VR.SteamVR_Action_Pose mixedRealityCameraPose; // 0x50
        public 0x6B209C88 mixedRealityCameraInputSource; // 0x58
        public bool mixedRealityActionSetAutoEnable; // 0x5C
        public UnityEngine.GameObject previewHandLeft; // 0x60
        public UnityEngine.GameObject previewHandRight; // 0x68
        public string previewLeftDefaultAssetName;
        public string previewRightDefaultAssetName;
        public string defaultSettingsAssetName;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC8CB7580
        public void get_trackingSpace(){} // RVA: 0x7FFAC44357F0
        public void set_trackingSpace(){} // RVA: 0x7FFAC8CB75D0
        public void IsInputUpdateMode(){} // RVA: 0x7FFAC8CB7650
        public void IsPoseUpdateMode(){} // RVA: 0x7FFAC8CB7660
        public void VerifyScriptableObject(){} // RVA: 0x7FFAC8CB7670
        public void LoadInstance(){} // RVA: 0x7FFAC8CB7680
        public void Save(){} // RVA: 0x7FFAC2F21310
        public void SetDefaultsIfNeeded(){} // RVA: 0x7FFAC8CB7940
        public void FindDefaultPreviewHand(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC8CB7B50
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists : Object
    {
        public 0x6B209D90[] enumList; // 0x10
        public string[] stringList; // 0x18

        // ── Methods ──
        public void get_enumList(){} // RVA: 0x7FFAC8C8BF80
        public void get_stringList(){} // RVA: 0x7FFAC8C8C190
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Skeleton_FingerIndexes : Object
    {
        public int thumb;
        public int index;
        public int middle;
        public int ring;
        public int pinky;
        public 0x6B207C38[] enumArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8C51910
    }

    public class SteamVR_Skeleton_FingerSplayIndexes : Object
    {
        public int thumbIndex;
        public int indexMiddle;
        public int middleRing;
        public int ringPinky;
        public 0x6B207BE0[] enumArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8C51B80
    }

    public class SteamVR_Skeleton_HandMask : Object
    {
        public bool palm; // 0x10
        public bool thumb; // 0x11
        public bool index; // 0x12
        public bool middle; // 0x13
        public bool ring; // 0x14
        public bool pinky; // 0x15
        public bool[] values; // 0x18
        public Valve.VR.SteamVR_Skeleton_HandMask fullMask;

        // ── Methods ──
        public void SetFinger(){} // RVA: 0x7FFAC8C8FC00
        public void GetFinger(){} // RVA: 0x7FFAC8C8FC40
        public void .ctor(){} // RVA: 0x7FFAC8C8FC70
        public void Reset(){} // RVA: 0x7FFAC8C8FE30
        public void Apply(){} // RVA: 0x7FFAC8C8FEF0
        public void .cctor(){} // RVA: 0x7FFAC8C8FFB0
    }

    public class SteamVR_Skeleton_JointIndexes : Object
    {
        public int root;
        public int wrist;
        public int thumbMetacarpal;
        public int thumbProximal;
        public int thumbMiddle;
        public int thumbDistal;
        public int thumbTip;
        public int indexMetacarpal;
        public int indexProximal;
        public int indexMiddle;
        public int indexDistal;
        public int indexTip;
        public int middleMetacarpal;
        public int middleProximal;
        public int middleMiddle;
        public int middleDistal;
        public int middleTip;
        public int ringMetacarpal;
        public int ringProximal;
        public int ringMiddle;
        public int ringDistal;
        public int ringTip;
        public int pinkyMetacarpal;
        public int pinkyProximal;
        public int pinkyMiddle;
        public int pinkyDistal;
        public int pinkyTip;
        public int thumbAux;
        public int indexAux;
        public int middleAux;
        public int ringAux;
        public int pinkyAux;

        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x7FFAC8C51850
        public void GetBoneForFingerTip(){} // RVA: 0x7FFAC8C518D0
    }

    public class SteamVR_Skeleton_Pose : ScriptableObject
    {
        public Valve.VR.SteamVR_Skeleton_Pose_Hand leftHand; // 0x18
        public Valve.VR.SteamVR_Skeleton_Pose_Hand rightHand; // 0x20
        public int leftHandInputSource;
        public int rightHandInputSource;
        public bool applyToSkeletonRoot; // 0x28

        // ── Methods ──
        public void GetHand(){} // RVA: 0x7FFAC8C8BCE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC8C8BD00
    }

    public class SteamVR_Skeleton_PoseSnapshot : Object
    {
        public 0x6B209C88 inputSource; // 0x10
        public UnityEngine.Vector3 position; // 0x14
        public UnityEngine.Quaternion rotation; // 0x20
        public UnityEngine.Vector3[] bonePositions; // 0x30
        public UnityEngine.Quaternion[] boneRotations; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C8F960
        public void CopyFrom(){} // RVA: 0x7FFAC8C8FB00
    }

    public class SteamVR_Skeleton_Pose_Hand : Object
    {
        public 0x6B209C88 inputSource; // 0x10
        public 0x6B209D90 thumbFingerMovementType; // 0x14
        public 0x6B209D90 indexFingerMovementType; // 0x18
        public 0x6B209D90 middleFingerMovementType; // 0x1C
        public 0x6B209D90 ringFingerMovementType; // 0x20
        public 0x6B209D90 pinkyFingerMovementType; // 0x24
        public bool ignoreRootPoseData; // 0x28
        public bool ignoreWristPoseData; // 0x29
        public UnityEngine.Vector3 position; // 0x2C
        public UnityEngine.Quaternion rotation; // 0x38
        public UnityEngine.Vector3[] bonePositions; // 0x48
        public UnityEngine.Quaternion[] boneRotations; // 0x50

        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x7FFAC8C8BE30
        public void .ctor(){} // RVA: 0x7FFAC8C8BF00
        public void GetMovementTypeForBone(){} // RVA: 0x7FFAC8C8BF10
    }

    public class SteamVR_Skeleton_Poser : MonoBehaviour
    {
        public bool blendPoseCount; // 0x20
        public bool blendEditorExpanded; // 0x21
        public string[] poseNames; // 0x28
        public UnityEngine.GameObject overridePreviewLeftHandPrefab; // 0x30
        public UnityEngine.GameObject overridePreviewRightHandPrefab; // 0x38
        public Valve.VR.SteamVR_Skeleton_Pose skeletonMainPose; // 0x40
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Skeleton_Pose> skeletonAdditionalPoses; // 0x48
        public bool showLeftPreview; // 0x50
        public bool showRightPreview; // 0x51
        public UnityEngine.GameObject previewLeftInstance; // 0x58
        public UnityEngine.GameObject previewRightInstance; // 0x60
        public int previewPoseSelection; // 0x68
        public System.Collections.Generic.List`1<PoseBlendingBehaviour> blendingBehaviours; // 0x70
        public Valve.VR.SteamVR_Skeleton_PoseSnapshot blendedSnapshotL; // 0x78
        public Valve.VR.SteamVR_Skeleton_PoseSnapshot blendedSnapshotR; // 0x80
        public SkeletonBlendablePose[] blendPoses; // 0x88
        public int boneCount; // 0x90
        public bool poseUpdatedThisFrame; // 0x94
        public float scale; // 0x98

        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x7FFAC8C8C520
        public void Awake(){} // RVA: 0x7FFAC8C8C540
        public void SetBlendingBehaviourValue(){} // RVA: 0x7FFAC8C8CA90
        public void GetBlendingBehaviourValue(){} // RVA: 0x7FFAC8C8CB60
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x7FFAC8C8CB90
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x7FFAC8C8CBC0
        public void GetBlendingBehaviour(){} // RVA: 0x7FFAC8C8CBF0
        public void FindBlendingBehaviour(){} // RVA: 0x7FFAC8C8CC00
        public void GetPoseByIndex(){} // RVA: 0x7FFAC8C8CE10
        public void GetHandSnapshot(){} // RVA: 0x7FFAC8C8CEA0
        public void GetBlendedPose(){} // RVA: 0x7FFAC8C8CF00 | overloaded x2
        public void UpdatePose(){} // RVA: 0x7FFAC8C8CF50
        public void ApplyBlenderBehaviours(){} // RVA: 0x7FFAC8C8D230
        public void LateUpdate(){} // RVA: 0x7FFAC8C8D4F0
        public void BlendVectors(){} // RVA: 0x7FFAC8C8D500
        public void BlendQuaternions(){} // RVA: 0x7FFAC8C8D600
        public void GetTargetHandPosition(){} // RVA: 0x7FFAC8C8D8F0
        public void GetTargetHandRotation(){} // RVA: 0x7FFAC8C8DEF0
        public void .ctor(){} // RVA: 0x7FFAC8C8E5B0
    }

    public class SteamVR_Skybox : MonoBehaviour
    {
        public UnityEngine.Texture front; // 0x20
        public UnityEngine.Texture back; // 0x28
        public UnityEngine.Texture left; // 0x30
        public UnityEngine.Texture right; // 0x38
        public UnityEngine.Texture top; // 0x40
        public UnityEngine.Texture bottom; // 0x48
        public 0x6B20B128 StereoCellSize; // 0x50
        public float StereoIpdMm; // 0x54

        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x7FFAC8CB7D90
        public void GetTextureByIndex(){} // RVA: 0x7FFAC8CB7E20
        public void SetOverride(){} // RVA: 0x7FFAC8CB7E80
        public void ClearOverride(){} // RVA: 0x7FFAC8CB8390
        public void OnEnable(){} // RVA: 0x7FFAC8CB83E0
        public void OnDisable(){} // RVA: 0x7FFAC8CB8390
        public void .ctor(){} // RVA: 0x7FFAC8CB8420
    }

    public class SteamVR_SphericalProjection : MonoBehaviour
    {
        public UnityEngine.Material material;

        // ── Methods ──
        public void Set(){} // RVA: 0x7FFAC8CB8480
        public void OnRenderImage(){} // RVA: 0x7FFAC8CB8A70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_TrackedCamera : Object
    {
        public VideoStreamTexture[] distorted;
        public VideoStreamTexture[] undistorted; // 0x8
        public VideoStream[] videostreams; // 0x10

        // ── Methods ──
        public void Distorted(){} // RVA: 0x7FFAC8CB8B00
        public void Undistorted(){} // RVA: 0x7FFAC8CB8CA0
        public void Source(){} // RVA: 0x7FFAC8CB8E50
        public void Stream(){} // RVA: 0x7FFAC8CB9190
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_TrackedObject : MonoBehaviour
    {
        public 0x6B20B338 isValid; // 0x20
        public UnityEngine.Transform origin; // 0x28
        public bool <isValid>k__BackingField; // 0x30
        public Action newPosesAction; // 0x38

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFAC2F47450
        public void set_isValid(){} // RVA: 0x7FFAC2F47460
        public void OnNewPoses(){} // RVA: 0x7FFAC8CB9F80
        public void .ctor(){} // RVA: 0x7FFAC8CBA560
        public void Awake(){} // RVA: 0x7FFAC8CBA680
        public void OnEnable(){} // RVA: 0x7FFAC8CBA680
        public void OnDisable(){} // RVA: 0x7FFAC8CBA810
        public void SetDeviceIndex(){} // RVA: 0x7FFAC8CBA850
    }

    public class SteamVR_TrackingReferenceManager : MonoBehaviour
    {
        public System.Collections.Generic.Dictionary`2<uint,TrackingReferenceObject> trackingReferences; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC8CBAA10
        public void OnDisable(){} // RVA: 0x7FFAC8CBAAF0
        public void OnNewPoses(){} // RVA: 0x7FFAC8CBAC00
        public void .ctor(){} // RVA: 0x7FFAC8CBAF90
    }

}