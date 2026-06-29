// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 100
// Methods: 1707

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR : Object
    {
        public object isSupported;
        public object _enabled;
        public object _instance;
        public object initializedState;
        public object _settings;
        public object _hmd;
        public object _compositor;
        public object _overlay;
        public object _initializing;
        public object _calibrating;
        public object _outOfRange;
        public object connected;
        public object _sceneWidth;
        public object _sceneHeight;
        public object _aspect;
        public object _fieldOfView;
        public object _tanHalfFov;
        public object _textureBounds;
        public object _eyes;
        public object textureType;
        public object runningTemporarySession;
        public object defaultUnityAppKeyTemplate;
        public object defaultAppKeyTemplate;

        // ── Methods ──
        public void get_active(){} // RVA: 0x6F65D70
        public void get_enabled(){} // RVA: 0x6F65DD0
        public void set_enabled(){} // RVA: 0x6F66010
        public void get_instance(){} // RVA: 0x6F660B0
        public void Initialize(){} // RVA: 0x6F66210
        public void get_usingNativeSupport(){} // RVA: 0x6F663D0
        public void get_settings(){} // RVA: 0x6F66420
        public void set_settings(){} // RVA: 0x6F66480
        public void ReportGeneralErrors(){} // RVA: 0x6F66540
        public void CreateInstance(){} // RVA: 0x6F665D0
        public void ReportError(){} // RVA: 0x6F66C70
        public void get_hmd(){} // RVA: 0xB5DBF0
        public void set_hmd(){} // RVA: 0xB44D60
        public void get_compositor(){} // RVA: 0xB465B0
        public void set_compositor(){} // RVA: 0xBA9BA0
        public void get_overlay(){} // RVA: 0xB700F0
        public void set_overlay(){} // RVA: 0xB70100
        public void get_initializing(){} // RVA: 0x6F66E30
        public void set_initializing(){} // RVA: 0x6F66E90
        public void get_calibrating(){} // RVA: 0x6F66EF0
        public void set_calibrating(){} // RVA: 0x6F66F50
        public void get_outOfRange(){} // RVA: 0x6F66FB0
        public void set_outOfRange(){} // RVA: 0x6F67010
        public void get_sceneWidth(){} // RVA: 0xC27360
        public void set_sceneWidth(){} // RVA: 0xC27370
        public void get_sceneHeight(){} // RVA: 0xCD5510
        public void set_sceneHeight(){} // RVA: 0x1186FB0
        public void get_aspect(){} // RVA: 0xCD64A0
        public void set_aspect(){} // RVA: 0xD96F20
        public void get_fieldOfView(){} // RVA: 0xC120F0
        public void set_fieldOfView(){} // RVA: 0xC12100
        public void get_tanHalfFov(){} // RVA: 0x1DE2440
        public void set_tanHalfFov(){} // RVA: 0xE9F6B0
        public void get_textureBounds(){} // RVA: 0xBC1B30
        public void set_textureBounds(){} // RVA: 0xB6A8C0
        public void get_eyes(){} // RVA: 0xBBF8F0
        public void set_eyes(){} // RVA: 0xBBF900
        public void get_hmd_TrackingSystemName(){} // RVA: 0x6F67070
        public void get_hmd_ActualTrackingSystemName(){} // RVA: 0x6F67080
        public void get_hmd_ModelNumber(){} // RVA: 0x6F67090
        public void get_hmd_SerialNumber(){} // RVA: 0x6F670A0
        public void get_hmd_Type(){} // RVA: 0x6F670B0
        public void get_hmd_SecondsFromVsyncToPhotons(){} // RVA: 0x6F670C0
        public void get_hmd_DisplayFrequency(){} // RVA: 0x6F67110
        public void GetHeadsetActivityLevel(){} // RVA: 0x6F67160
        public void GetTrackedDeviceString(){} // RVA: 0x6F671B0
        public void GetStringProperty(){} // RVA: 0x6F672F0
        public void GetFloatProperty(){} // RVA: 0x6F67490
        public void InitializeTemporarySession(){} // RVA: 0x6F674E0
        public void ExitTemporarySession(){} // RVA: 0x6F675A0
        public void GenerateAppKey(){} // RVA: 0x6F67640
        public void GenerateCleanProductName(){} // RVA: 0x6F677E0
        public void GetManifestFile(){} // RVA: 0x6F678F0
        public void IdentifyEditorApplication(){} // RVA: 0x6F68430
        public void OnInitializing(){} // RVA: 0x6F688B0
        public void OnCalibrating(){} // RVA: 0x6F68950
        public void OnOutOfRange(){} // RVA: 0x6F689F0
        public void OnDeviceConnected(){} // RVA: 0x6F68A90
        public void OnNewPoses(){} // RVA: 0x6F68B20
        public void .ctor(){} // RVA: 0x6F69030
        public void Finalize(){} // RVA: 0x6F69EF0
        public void Dispose(){} // RVA: 0x6F69FA0
        public void SafeDispose(){} // RVA: 0x6F6A3D0
        public void .cctor(){} // RVA: 0x6F6A4C0
    }

    public class SteamVR_Action : Object
    {
        public object actionPath;
        public object needsReinit;
        public object startUpdatingSourceOnAccess;
        public object cachedShortName;

        // ── Methods ──
        public void Create(){} // RVA: 0xA94080
        public void GetCopy(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xB43310
        public void CreateUninitialized(){} // RVA: 0x29C74C0
        public void TryNeedsInitData(){} // RVA: 0x87C0A0
        public void InitializeCopy(){} // RVA: 0x8943B0
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void get_actionSet(){} // RVA: 0x87C0A0
        public void get_direction(){} // RVA: 0x87C130
        public void get_setActive(){} // RVA: 0x6F0F940
        public void get_active(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void PreInitialize(){} // RVA: 0x894320
        public void Initialize(){} // RVA: 0x8949A0
        public void GetTimeLastChanged(){} // RVA: 0x891330
        public void GetSourceMap(){} // RVA: 0x87C0A0
        public void GetActive(){} // RVA: 0x87DD20
        public void GetSetActive(){} // RVA: 0x6F0F9A0
        public void GetActiveBinding(){} // RVA: 0x87DD20
        public void GetLastActive(){} // RVA: 0x87DD20
        public void GetLastActiveBinding(){} // RVA: 0x87DD20
        public void GetPath(){} // RVA: 0xB5DBF0
        public void IsUpdating(){} // RVA: 0x87DD20
        public void GetHashCode(){} // RVA: 0x6F0FA20
        public void Equals(){} // RVA: 0x6F0FAA0
        public void op_Inequality(){} // RVA: 0x6F0FBD0
        public void op_Equality(){} // RVA: 0x6F0FD00
        public void FindExistingActionForPartialPath(){} // RVA: 0x6F0FE00
        public void GetShortName(){} // RVA: 0x6F0FF20
        public void ShowOrigins(){} // RVA: 0x6F0FFC0
        public void HideOrigins(){} // RVA: 0x6F10090
        public void .cctor(){} // RVA: 0x6F100E0
    }

    public class SteamVR_ActionSet : Object
    {
        public object actionSetPath;
        public object setData;
        public object initialized;

        // ── Methods ──
        public void Create(){} // RVA: 0xA94080
        public void GetCopy(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xB43310
        public void get_allActions(){} // RVA: 0x6F10D50
        public void get_nonVisualInActions(){} // RVA: 0x6F10D90
        public void get_visualActions(){} // RVA: 0x6F10DD0
        public void get_poseActions(){} // RVA: 0x6F10E10
        public void get_skeletonActions(){} // RVA: 0x6F10E50
        public void get_outActionArray(){} // RVA: 0x6F10E90
        public void get_fullPath(){} // RVA: 0x6F10ED0
        public void get_usage(){} // RVA: 0x6F10F10
        public void get_handle(){} // RVA: 0x6F10F50
        public void CreateFromName(){} // RVA: 0xA94080
        public void PreInitialize(){} // RVA: 0x6F10F90
        public void FinishPreInitialize(){} // RVA: 0x6F11110
        public void Initialize(){} // RVA: 0x6F11130
        public void GetPath(){} // RVA: 0xB5DBF0
        public void IsActive(){} // RVA: 0x6F11210
        public void GetTimeLastChanged(){} // RVA: 0x6F11270
        public void Activate(){} // RVA: 0x6F112C0
        public void Deactivate(){} // RVA: 0x6F11470
        public void GetShortName(){} // RVA: 0x6F11580
        public void ShowBindingHints(){} // RVA: 0x6F11610
        public void ReadRawSetActive(){} // RVA: 0x6F11750
        public void ReadRawSetLastChanged(){} // RVA: 0x6F11790
        public void ReadRawSetPriority(){} // RVA: 0x6F117D0
        public void GetActionSetData(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x6F11810
        public void GetHashCode(){} // RVA: 0x6F0FA20
        public void op_Inequality(){} // RVA: 0x6F11920
        public void op_Equality(){} // RVA: 0x6F119E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F11A90
    }

    public class SteamVR_ActionSet[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_ActionSet_Data : Object
    {
        public object _allActions;
        public object _nonVisualInActions;
        public object _visualActions;
        public object _poseActions;
        public object _skeletonActions;
        public object _outActionArray;
        public object _fullPath;
        public object _usage;
        public object _handle;
        public object rawSetActive;
        public object rawSetLastChanged;
        public object rawSetPriority;
        public object initialized;
        public object cachedShortName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F11BB0
        public void get_allActions(){} // RVA: 0xB5DBF0
        public void set_allActions(){} // RVA: 0xB44D60
        public void get_nonVisualInActions(){} // RVA: 0xB465B0
        public void set_nonVisualInActions(){} // RVA: 0xBA9BA0
        public void get_visualActions(){} // RVA: 0xB700F0
        public void set_visualActions(){} // RVA: 0xB70100
        public void get_poseActions(){} // RVA: 0xB70160
        public void set_poseActions(){} // RVA: 0xB44DC0
        public void get_skeletonActions(){} // RVA: 0xD33E60
        public void set_skeletonActions(){} // RVA: 0xB708C0
        public void get_outActionArray(){} // RVA: 0xD05CA0
        public void set_outActionArray(){} // RVA: 0xD09D70
        public void get_fullPath(){} // RVA: 0xBC1B30
        public void set_fullPath(){} // RVA: 0xB6A8C0
        public void get_usage(){} // RVA: 0xBBF8F0
        public void set_usage(){} // RVA: 0xBBF900
        public void get_handle(){} // RVA: 0xBE58B0
        public void set_handle(){} // RVA: 0xE9E640
        public void PreInitialize(){} // RVA: 0xB43310
        public void FinishPreInitialize(){} // RVA: 0x6F11D90
        public void Initialize(){} // RVA: 0x6F127E0
        public void IsActive(){} // RVA: 0x6F129D0
        public void GetTimeLastChanged(){} // RVA: 0x6F12A20
        public void Activate(){} // RVA: 0x6F12A60
        public void Deactivate(){} // RVA: 0x6F12C00
        public void GetShortName(){} // RVA: 0x6F12D10
        public void ReadRawSetActive(){} // RVA: 0x6F12D90
        public void ReadRawSetLastChanged(){} // RVA: 0x6F12DC0
        public void ReadRawSetPriority(){} // RVA: 0x6F12DF0
    }

    public class SteamVR_Action[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Boolean[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    }

    public class SteamVR_Action_In_Source : SteamVR_Action_Source
    {
        public object inputOriginInfo_size;
        public object _isUpdating;
        public object _updateTime;
        public object _changedTime;
        public object _lastOriginGetFrame;
        public object inputOriginInfo;
        public object lastInputOriginInfo;

        // ── Methods ──
        public void get_isUpdating(){} // RVA: 0xF73960
        public void set_isUpdating(){} // RVA: 0xF73A60
        public void get_updateTime(){} // RVA: 0xCD5510
        public void set_updateTime(){} // RVA: 0x1186FB0
        public void get_activeOrigin(){} // RVA: 0x87C0A0
        public void get_lastActiveOrigin(){} // RVA: 0x87C0A0
        public void get_changed(){} // RVA: 0x87D280
        public void set_changed(){} // RVA: 0x894750
        public void get_lastChanged(){} // RVA: 0x87D280
        public void set_lastChanged(){} // RVA: 0x894750
        public void get_activeDevice(){} // RVA: 0x6F177B0
        public void get_trackedDeviceIndex(){} // RVA: 0x6F17810
        public void get_renderModelComponentName(){} // RVA: 0x6F17830
        public void get_localizedOriginName(){} // RVA: 0x6F17850
        public void get_changedTime(){} // RVA: 0xCD64A0
        public void set_changedTime(){} // RVA: 0xD96F20
        public void get_lastOriginGetFrame(){} // RVA: 0xE9CE60
        public void set_lastOriginGetFrame(){} // RVA: 0xEA1260
        public void UpdateValue(){} // RVA: 0x894290
        public void Initialize(){} // RVA: 0x6F17870
        public void UpdateOriginTrackedDeviceInfo(){} // RVA: 0x6F179A0
        public void GetLocalizedOriginPart(){} // RVA: 0x6F17E10
        public void GetLocalizedOrigin(){} // RVA: 0x6F17EC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Action_In_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x87DD20
        public void OnAccessSource(){} // RVA: 0x8944F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x8944F0
        public void UpdateValues(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x87D280
        public void get_lastChanged(){} // RVA: 0x87D280
        public void get_changedTime(){} // RVA: 0x890F90
        public void get_updateTime(){} // RVA: 0x890F90
        public void get_activeOrigin(){} // RVA: 0x87C0A0
        public void get_lastActiveOrigin(){} // RVA: 0x87C0A0
        public void get_activeDevice(){} // RVA: 0x87C130
        public void get_trackedDeviceIndex(){} // RVA: 0x87C130
        public void get_renderModelComponentName(){} // RVA: 0x87C0A0
        public void get_localizedOriginName(){} // RVA: 0x87C0A0
        public void UpdateValues(){} // RVA: 0x894290
        public void GetRenderModelComponentName(){} // RVA: 0x87C160
        public void GetActiveDevice(){} // RVA: 0x881C20
        public void GetDeviceIndex(){} // RVA: 0x881C20
        public void GetChanged(){} // RVA: 0x87DD20
        public void GetTimeLastChanged(){} // RVA: 0x891330
        public void GetLocalizedOriginPart(){} // RVA: 0x88B510
        public void GetLocalizedOrigin(){} // RVA: 0x87C160
        public void IsUpdating(){} // RVA: 0x87DD20
        public void ForceAddSourceToUpdateList(){} // RVA: 0x8944F0
        public void GetControllerType(){} // RVA: 0x87C160
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F17FB0
        public void remove_onActiveChange(){} // RVA: 0x6F18030
        public void add_onActiveBindingChange(){} // RVA: 0x6F180B0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F18200
        public void add_onChange(){} // RVA: 0x6F18280
        public void remove_onChange(){} // RVA: 0x6F18300
        public void add_onUpdate(){} // RVA: 0x6F18380
        public void remove_onUpdate(){} // RVA: 0x6F18400
        public void add_onTrackingChanged(){} // RVA: 0x6F18480
        public void remove_onTrackingChanged(){} // RVA: 0x6F18500
        public void add_onValidPoseChanged(){} // RVA: 0x6F18580
        public void remove_onValidPoseChanged(){} // RVA: 0x6F18600
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F18680
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F18700
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x6F18780
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x6F18800
        public void AddOnTrackingChanged(){} // RVA: 0x6F18880
        public void RemoveOnTrackingChanged(){} // RVA: 0x6F18900
        public void AddOnValidPoseChanged(){} // RVA: 0x6F18980
        public void RemoveOnValidPoseChanged(){} // RVA: 0x6F18A00
        public void AddOnActiveChangeListener(){} // RVA: 0x6F18A80
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F18B00
        public void AddOnChangeListener(){} // RVA: 0x6F18B80
        public void RemoveOnChangeListener(){} // RVA: 0x6F18C00
        public void AddOnUpdateListener(){} // RVA: 0x6F18C80
        public void RemoveOnUpdateListener(){} // RVA: 0x6F18D00
        public void RemoveAllListeners(){} // RVA: 0x6F18D80
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F18E00
        public void SetTrackingUniverseOrigin(){} // RVA: 0x6F18E40
        public void .ctor(){} // RVA: 0x6F18EC0
    }

    public class SteamVR_Action_Pose[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x895710
        public void get_localPosition(){} // RVA: 0x87BEB0
        public void get_localRotation(){} // RVA: 0x87BEB0
        public void get_trackingState(){} // RVA: 0x87C130
        public void get_velocity(){} // RVA: 0x87BEB0
        public void get_angularVelocity(){} // RVA: 0x87BEB0
        public void get_poseIsValid(){} // RVA: 0x87D280
        public void get_deviceIsConnected(){} // RVA: 0x87D280
        public void get_lastLocalPosition(){} // RVA: 0x87BEB0
        public void get_lastLocalRotation(){} // RVA: 0x87BEB0
        public void get_lastTrackingState(){} // RVA: 0x87C130
        public void get_lastVelocity(){} // RVA: 0x87BEB0
        public void get_lastAngularVelocity(){} // RVA: 0x87BEB0
        public void get_lastPoseIsValid(){} // RVA: 0x87D280
        public void get_lastDeviceIsConnected(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894290
        public void UpdateValues(){} // RVA: 0x894750
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0xA94080
        public void GetPoseAtTimeOffset(){} // RVA: 0xA94080
        public void UpdateTransform(){} // RVA: 0x895750
        public void GetLocalPosition(){} // RVA: 0x87BF40
        public void GetLocalRotation(){} // RVA: 0x87BF40
        public void GetVelocity(){} // RVA: 0x87BF40
        public void GetAngularVelocity(){} // RVA: 0x87BF40
        public void GetDeviceIsConnected(){} // RVA: 0x87DD20
        public void GetPoseIsValid(){} // RVA: 0x87DD20
        public void GetTrackingResult(){} // RVA: 0x881C20
        public void GetLastLocalPosition(){} // RVA: 0x87BF40
        public void GetLastLocalRotation(){} // RVA: 0x87BF40
        public void GetLastVelocity(){} // RVA: 0x87BF40
        public void GetLastAngularVelocity(){} // RVA: 0x87BF40
        public void GetLastDeviceIsConnected(){} // RVA: 0x87DD20
        public void GetLastPoseIsValid(){} // RVA: 0x87DD20
        public void GetLastTrackingResult(){} // RVA: 0x881C20
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x4B52080
        public void get_localPosition(){} // RVA: 0x4B52250
        public void get_localRotation(){} // RVA: 0x4B522A0
        public void get_trackingState(){} // RVA: 0x4B522F0
        public void get_velocity(){} // RVA: 0x4B52330
        public void get_angularVelocity(){} // RVA: 0x4B52380
        public void get_poseIsValid(){} // RVA: 0x4B523D0
        public void get_deviceIsConnected(){} // RVA: 0x4B52410
        public void get_lastLocalPosition(){} // RVA: 0x4B52450
        public void get_lastLocalRotation(){} // RVA: 0x4B524A0
        public void get_lastTrackingState(){} // RVA: 0x4B524F0
        public void get_lastVelocity(){} // RVA: 0x4B52530
        public void get_lastAngularVelocity(){} // RVA: 0x4B52580
        public void get_lastPoseIsValid(){} // RVA: 0x4B525D0
        public void get_lastDeviceIsConnected(){} // RVA: 0x4B52610
        public void .ctor(){} // RVA: 0x4B52650
        public void UpdateValues(){} // RVA: 0x4B52670
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x4B526A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x4B52700
        public void UpdateTransform(){} // RVA: 0x4B52780
        public void GetLocalPosition(){} // RVA: 0x4B52910
        public void GetLocalRotation(){} // RVA: 0x4B52970
        public void GetVelocity(){} // RVA: 0x4B529C0
        public void GetAngularVelocity(){} // RVA: 0x4B52A20
        public void GetDeviceIsConnected(){} // RVA: 0x4B52A80
        public void GetPoseIsValid(){} // RVA: 0x4B52AC0
        public void GetTrackingResult(){} // RVA: 0x4B52B00
        public void GetLastLocalPosition(){} // RVA: 0x4B52B40
        public void GetLastLocalRotation(){} // RVA: 0x4B52BA0
        public void GetLastVelocity(){} // RVA: 0x4B52BF0
        public void GetLastAngularVelocity(){} // RVA: 0x4B52C50
        public void GetLastDeviceIsConnected(){} // RVA: 0x4B52CB0
        public void GetLastPoseIsValid(){} // RVA: 0x4B52CF0
        public void GetLastTrackingResult(){} // RVA: 0x4B52D30
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x4B52080
        public void get_localPosition(){} // RVA: 0x4B52250
        public void get_localRotation(){} // RVA: 0x4B522A0
        public void get_trackingState(){} // RVA: 0x4B522F0
        public void get_velocity(){} // RVA: 0x4B52330
        public void get_angularVelocity(){} // RVA: 0x4B52380
        public void get_poseIsValid(){} // RVA: 0x4B523D0
        public void get_deviceIsConnected(){} // RVA: 0x4B52410
        public void get_lastLocalPosition(){} // RVA: 0x4B52450
        public void get_lastLocalRotation(){} // RVA: 0x4B524A0
        public void get_lastTrackingState(){} // RVA: 0x4B524F0
        public void get_lastVelocity(){} // RVA: 0x4B52530
        public void get_lastAngularVelocity(){} // RVA: 0x4B52580
        public void get_lastPoseIsValid(){} // RVA: 0x4B525D0
        public void get_lastDeviceIsConnected(){} // RVA: 0x4B52610
        public void .ctor(){} // RVA: 0x4B52650
        public void UpdateValues(){} // RVA: 0x4B52670
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x4B526A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x4B52700
        public void UpdateTransform(){} // RVA: 0x4B52780
        public void GetLocalPosition(){} // RVA: 0x4B52910
        public void GetLocalRotation(){} // RVA: 0x4B52970
        public void GetVelocity(){} // RVA: 0x4B529C0
        public void GetAngularVelocity(){} // RVA: 0x4B52A20
        public void GetDeviceIsConnected(){} // RVA: 0x4B52A80
        public void GetPoseIsValid(){} // RVA: 0x4B52AC0
        public void GetTrackingResult(){} // RVA: 0x4B52B00
        public void GetLastLocalPosition(){} // RVA: 0x4B52B40
        public void GetLastLocalRotation(){} // RVA: 0x4B52BA0
        public void GetLastVelocity(){} // RVA: 0x4B52BF0
        public void GetLastAngularVelocity(){} // RVA: 0x4B52C50
        public void GetLastDeviceIsConnected(){} // RVA: 0x4B52CB0
        public void GetLastPoseIsValid(){} // RVA: 0x4B52CF0
        public void GetLastTrackingResult(){} // RVA: 0x4B52D30
    }

    public class SteamVR_Action_Pose_Source : SteamVR_Action_In_Source
    {
        public object universeOrigin;
        public object poseActionData_size;
        public object changeTolerance;
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onChange;
        public object onUpdate;
        public object onTrackingChanged;
        public object onValidPoseChanged;
        public object onDeviceConnectedChanged;
        public object _changed;
        public object _lastChanged;
        public object _lastActive;
        public object _localPosition;
        public object _localRotation;
        public object _lastLocalPosition;
        public object _lastLocalRotation;
        public object _velocity;
        public object _lastVelocity;
        public object _angularVelocity;
        public object _lastAngularVelocity;
        public object poseActionData;
        public object lastPoseActionData;
        public object tempPoseActionData;
        public object poseAction;
        public object framesAhead;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F192C0
        public void remove_onActiveChange(){} // RVA: 0x6F193C0
        public void add_onActiveBindingChange(){} // RVA: 0x6F194C0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F195C0
        public void add_onChange(){} // RVA: 0x6F196C0
        public void remove_onChange(){} // RVA: 0x6F197C0
        public void add_onUpdate(){} // RVA: 0x6F198C0
        public void remove_onUpdate(){} // RVA: 0x6F199C0
        public void add_onTrackingChanged(){} // RVA: 0x6F19AC0
        public void remove_onTrackingChanged(){} // RVA: 0x6F19BC0
        public void add_onValidPoseChanged(){} // RVA: 0x6F19CC0
        public void remove_onValidPoseChanged(){} // RVA: 0x6F19DC0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F19EC0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F19FC0
        public void get_changed(){} // RVA: 0x6E15480
        public void set_changed(){} // RVA: 0x6E15490
        public void get_lastChanged(){} // RVA: 0x6F1A0C0
        public void set_lastChanged(){} // RVA: 0x6F1A0D0
        public void get_activeOrigin(){} // RVA: 0x6F1A0E0
        public void get_lastActiveOrigin(){} // RVA: 0x166A290
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6F1A120
        public void get_lastActive(){} // RVA: 0x6F1A130
        public void set_lastActive(){} // RVA: 0x6F1A140
        public void get_lastActiveBinding(){} // RVA: 0x1F7F9C0
        public void get_trackingState(){} // RVA: 0xBA31A0
        public void get_lastTrackingState(){} // RVA: 0x6DE8F00
        public void get_poseIsValid(){} // RVA: 0x1F7AC70
        public void get_lastPoseIsValid(){} // RVA: 0x6F1A150
        public void get_deviceIsConnected(){} // RVA: 0x1F70A60
        public void get_lastDeviceIsConnected(){} // RVA: 0x6F1A160
        public void get_localPosition(){} // RVA: 0x6F1A170
        public void set_localPosition(){} // RVA: 0x6F1A190
        public void get_localRotation(){} // RVA: 0x6F1A1B0
        public void set_localRotation(){} // RVA: 0x6F1A1C0
        public void get_lastLocalPosition(){} // RVA: 0x6F1A1D0
        public void set_lastLocalPosition(){} // RVA: 0x6F1A1F0
        public void get_lastLocalRotation(){} // RVA: 0x6F1A210
        public void set_lastLocalRotation(){} // RVA: 0x6F1A220
        public void get_velocity(){} // RVA: 0x6F1A230
        public void set_velocity(){} // RVA: 0x6F1A250
        public void get_lastVelocity(){} // RVA: 0x6F1A270
        public void set_lastVelocity(){} // RVA: 0x6F1A290
        public void get_angularVelocity(){} // RVA: 0x6F1A2B0
        public void set_angularVelocity(){} // RVA: 0x6F1A2D0
        public void get_lastAngularVelocity(){} // RVA: 0x6F1A2F0
        public void set_lastAngularVelocity(){} // RVA: 0x6F1A310
        public void Preinitialize(){} // RVA: 0x6F1A330
        public void Initialize(){} // RVA: 0x6F1A480
        public void RemoveAllListeners(){} // RVA: 0x6F1A5A0
        public void UpdateValue(){} // RVA: 0x6F1AA00
        public void SetCacheVariables(){} // RVA: 0x6F1B1B0
        public void GetChanged(){} // RVA: 0x6F1B2D0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x6F1B5A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x6F1B9C0
        public void UpdateTransform(){} // RVA: 0x6F1BED0
        public void CheckAndSendEvents(){} // RVA: 0x6F1C030
        public void GetUnityCoordinateVelocity(){} // RVA: 0x6F1C320
        public void GetUnityCoordinateAngularVelocity(){} // RVA: 0x6F1C340
        public void .ctor(){} // RVA: 0x6F1C370
        public void .cctor(){} // RVA: 0x6F1C3C0
    }

    public class SteamVR_Action_Pose_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x8944F0
        public void UpdateValues(){} // RVA: 0x894750
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B52DE0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x4B52D70
        public void .ctor(){} // RVA: 0x4B52EE0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B52DE0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x4B52D70
        public void .ctor(){} // RVA: 0x4B52EE0
    }

    public class SteamVR_Action_Single : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x6F1C420
        public void remove_onChange(){} // RVA: 0x6F1C4A0
        public void add_onUpdate(){} // RVA: 0x6F1C520
        public void remove_onUpdate(){} // RVA: 0x6F1C5A0
        public void add_onAxis(){} // RVA: 0x6F1C620
        public void remove_onAxis(){} // RVA: 0x6F1C6A0
        public void add_onActiveChange(){} // RVA: 0x6F1C720
        public void remove_onActiveChange(){} // RVA: 0x6F1C7A0
        public void add_onActiveBindingChange(){} // RVA: 0x6F1C820
        public void remove_onActiveBindingChange(){} // RVA: 0x6F1C8A0
        public void get_axis(){} // RVA: 0x6F1C920
        public void get_lastAxis(){} // RVA: 0x6F1C9B0
        public void get_delta(){} // RVA: 0x6F1CA40
        public void get_lastDelta(){} // RVA: 0x6F1CAD0
        public void .ctor(){} // RVA: 0x6F1CB60
        public void GetAxis(){} // RVA: 0x6F1CBA0
        public void GetAxisDelta(){} // RVA: 0x6F1CC40
        public void GetLastAxis(){} // RVA: 0x6F1CCE0
        public void GetLastAxisDelta(){} // RVA: 0x6F1CD80
        public void AddOnActiveChangeListener(){} // RVA: 0x6F1CE20
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F1CEA0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x6F1CF20
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x6F1CFA0
        public void AddOnChangeListener(){} // RVA: 0x6F1D020
        public void RemoveOnChangeListener(){} // RVA: 0x6F1D0A0
        public void AddOnUpdateListener(){} // RVA: 0x6F1D120
        public void RemoveOnUpdateListener(){} // RVA: 0x6F1D1A0
        public void AddOnAxisListener(){} // RVA: 0x6F1D220
        public void RemoveOnAxisListener(){} // RVA: 0x6F1D2A0
        public void RemoveAllListeners(){} // RVA: 0x6F1D320
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F1D390
    }

    public class SteamVR_Action_Single[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Single_Source : SteamVR_Action_In_Source
    {
        public object actionData_size;
        public object changeTolerance;
        public object onAxis;
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onChange;
        public object onUpdate;
        public object _changed;
        public object _lastChanged;
        public object _lastActive;
        public object actionData;
        public object lastActionData;
        public object singleAction;

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x6F1D6F0
        public void remove_onAxis(){} // RVA: 0x6F1D7F0
        public void add_onActiveChange(){} // RVA: 0x6F1D8F0
        public void remove_onActiveChange(){} // RVA: 0x6F1D9F0
        public void add_onActiveBindingChange(){} // RVA: 0x6F1DAF0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F1DBF0
        public void add_onChange(){} // RVA: 0x6F1DCF0
        public void remove_onChange(){} // RVA: 0x6F1DDF0
        public void add_onUpdate(){} // RVA: 0x6F1DEF0
        public void remove_onUpdate(){} // RVA: 0x6F1DFF0
        public void get_axis(){} // RVA: 0x6F1E0F0
        public void get_lastAxis(){} // RVA: 0x6F1E130
        public void get_delta(){} // RVA: 0x6F1E170
        public void get_lastDelta(){} // RVA: 0x6F1E1B0
        public void get_changed(){} // RVA: 0x6F1E1F0
        public void set_changed(){} // RVA: 0x6F1E200
        public void get_lastChanged(){} // RVA: 0x6F1E210
        public void set_lastChanged(){} // RVA: 0x6F1E220
        public void get_activeOrigin(){} // RVA: 0x6F1E230
        public void get_lastActiveOrigin(){} // RVA: 0x1655DD0
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6F16A30
        public void get_lastActive(){} // RVA: 0x6F1E270
        public void set_lastActive(){} // RVA: 0x6F1E280
        public void get_lastActiveBinding(){} // RVA: 0x6F168F0
        public void Preinitialize(){} // RVA: 0x6F1E290
        public void Initialize(){} // RVA: 0x6F1E420
        public void RemoveAllListeners(){} // RVA: 0x6F1E510
        public void UpdateValue(){} // RVA: 0x6F1E820
        public void .ctor(){} // RVA: 0x6F1F020
    }

    public class SteamVR_Action_Single_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Single_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F1D6B0
    }

    public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base`2
    {
        public object numBones;
        public object steamVRFixUpRotation;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F1F070
        public void remove_onActiveChange(){} // RVA: 0x6F1F0F0
        public void add_onActiveBindingChange(){} // RVA: 0x6F1F170
        public void remove_onActiveBindingChange(){} // RVA: 0x6F1F2C0
        public void add_onChange(){} // RVA: 0x6F1F340
        public void remove_onChange(){} // RVA: 0x6F1F3C0
        public void add_onUpdate(){} // RVA: 0x6F1F440
        public void remove_onUpdate(){} // RVA: 0x6F1F4C0
        public void add_onTrackingChanged(){} // RVA: 0x6F1F540
        public void remove_onTrackingChanged(){} // RVA: 0x6F1F5C0
        public void add_onValidPoseChanged(){} // RVA: 0x6F1F640
        public void remove_onValidPoseChanged(){} // RVA: 0x6F1F6C0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F1F740
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F1F7C0
        public void .ctor(){} // RVA: 0x6F1F840
        public void UpdateValue(){} // RVA: 0x6F1F890
        public void UpdateValueWithoutEvents(){} // RVA: 0x6F1F910
        public void UpdateTransform(){} // RVA: 0x6F1F990
        public void get_bonePositions(){} // RVA: 0x6F1FB40
        public void get_boneRotations(){} // RVA: 0x6F1FBA0
        public void get_lastBonePositions(){} // RVA: 0x6F1FC00
        public void get_lastBoneRotations(){} // RVA: 0x6F1FC60
        public void get_rangeOfMotion(){} // RVA: 0x6F1FCC0
        public void set_rangeOfMotion(){} // RVA: 0x6F1FD20
        public void get_skeletalTransformSpace(){} // RVA: 0x6F1FD90
        public void set_skeletalTransformSpace(){} // RVA: 0x6F1FDF0
        public void get_summaryDataType(){} // RVA: 0x6F1FE60
        public void set_summaryDataType(){} // RVA: 0x6F1FEC0
        public void get_skeletalTrackingLevel(){} // RVA: 0x6F1FF30
        public void get_thumbCurl(){} // RVA: 0x6F1FFA0
        public void get_indexCurl(){} // RVA: 0x6F20020
        public void get_middleCurl(){} // RVA: 0x6F200A0
        public void get_ringCurl(){} // RVA: 0x6F20120
        public void get_pinkyCurl(){} // RVA: 0x6F201A0
        public void get_thumbIndexSplay(){} // RVA: 0x6F20220
        public void get_indexMiddleSplay(){} // RVA: 0x6F202A0
        public void get_middleRingSplay(){} // RVA: 0x6F20320
        public void get_ringPinkySplay(){} // RVA: 0x6F203A0
        public void get_lastThumbCurl(){} // RVA: 0x6F20420
        public void get_lastIndexCurl(){} // RVA: 0x6F204A0
        public void get_lastMiddleCurl(){} // RVA: 0x6F20520
        public void get_lastRingCurl(){} // RVA: 0x6F205A0
        public void get_lastPinkyCurl(){} // RVA: 0x6F20620
        public void get_lastThumbIndexSplay(){} // RVA: 0x6F206A0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x6F20720
        public void get_lastMiddleRingSplay(){} // RVA: 0x6F207A0
        public void get_lastRingPinkySplay(){} // RVA: 0x6F20820
        public void get_fingerCurls(){} // RVA: 0x6F208A0
        public void get_fingerSplays(){} // RVA: 0x6F20900
        public void get_lastFingerCurls(){} // RVA: 0x6F20960
        public void get_lastFingerSplays(){} // RVA: 0x6F209C0
        public void get_poseChanged(){} // RVA: 0x6F20A20
        public void get_onlyUpdateSummaryData(){} // RVA: 0x6F20A80
        public void set_onlyUpdateSummaryData(){} // RVA: 0x6F20AE0
        public void GetActive(){} // RVA: 0x6F20B50
        public void GetSetActive(){} // RVA: 0x6F0F940
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x6F20BC0
        public void GetPoseAtTimeOffset(){} // RVA: 0x6F20C60
        public void GetLocalPosition(){} // RVA: 0x6F20D00
        public void GetLocalRotation(){} // RVA: 0x6F20D80
        public void GetVelocity(){} // RVA: 0x6F20E00
        public void GetAngularVelocity(){} // RVA: 0x6F20E80
        public void GetDeviceIsConnected(){} // RVA: 0x6F20F00
        public void GetPoseIsValid(){} // RVA: 0x6F20F60
        public void GetTrackingResult(){} // RVA: 0x6F20FC0
        public void GetLastLocalPosition(){} // RVA: 0x6F21020
        public void GetLastLocalRotation(){} // RVA: 0x6F210A0
        public void GetLastVelocity(){} // RVA: 0x6F21120
        public void GetLastAngularVelocity(){} // RVA: 0x6F211A0
        public void GetLastDeviceIsConnected(){} // RVA: 0x6F21220
        public void GetLastPoseIsValid(){} // RVA: 0x6F21280
        public void GetLastTrackingResult(){} // RVA: 0x6F212E0
        public void get_boneCount(){} // RVA: 0x6F21340
        public void GetBonePositions(){} // RVA: 0x6F213B0
        public void GetBoneRotations(){} // RVA: 0x6F214A0
        public void GetLastBonePositions(){} // RVA: 0x6F21590
        public void GetLastBoneRotations(){} // RVA: 0x6F21680
        public void SetRangeOfMotion(){} // RVA: 0x6F21770
        public void SetSkeletalTransformSpace(){} // RVA: 0x6F217E0
        public void GetBoneCount(){} // RVA: 0x6F21340
        public void GetBoneHierarchy(){} // RVA: 0x6F21850
        public void GetBoneName(){} // RVA: 0x6F218C0
        public void GetReferenceTransforms(){} // RVA: 0x6F21930
        public void GetSkeletalTrackingLevel(){} // RVA: 0x6F219B0
        public void GetFingerCurls(){} // RVA: 0x6F21A20
        public void GetLastFingerCurls(){} // RVA: 0x6F21B10
        public void GetFingerSplays(){} // RVA: 0x6F21C00
        public void GetLastFingerSplays(){} // RVA: 0x6F21CF0
        public void GetFingerCurl(){} // RVA: 0x6F21DE0
        public void GetSplay(){} // RVA: 0x6F21E70
        public void GetLastFingerCurl(){} // RVA: 0x6F21F00
        public void GetLastSplay(){} // RVA: 0x6F21F90
        public void GetLocalizedName(){} // RVA: 0x6F22020
        public void RemoveAllListeners(){} // RVA: 0x6F220A0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x6F22120
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x6F221A0
        public void AddOnTrackingChanged(){} // RVA: 0x6F22220
        public void RemoveOnTrackingChanged(){} // RVA: 0x6F222A0
        public void AddOnValidPoseChanged(){} // RVA: 0x6F22320
        public void RemoveOnValidPoseChanged(){} // RVA: 0x6F223A0
        public void AddOnActiveChangeListener(){} // RVA: 0x6F22420
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F224A0
        public void AddOnChangeListener(){} // RVA: 0x6F22520
        public void RemoveOnChangeListener(){} // RVA: 0x6F225A0
        public void AddOnUpdateListener(){} // RVA: 0x6F22620
        public void RemoveOnUpdateListener(){} // RVA: 0x6F226A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F22720
        public void .cctor(){} // RVA: 0x6F22760
    }

    public class SteamVR_Action_Skeleton[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Skeleton_Source : SteamVR_Action_Pose_Source
    {
        public object skeletonActionData_size;
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onChange;
        public object onUpdate;
        public object onTrackingChanged;
        public object onValidPoseChanged;
        public object onDeviceConnectedChanged;
        public object _bonePositions;
        public object _boneRotations;
        public object _lastBonePositions;
        public object _lastBoneRotations;
        public object _rangeOfMotion;
        public object _skeletalTransformSpace;
        public object _summaryDataType;
        public object _fingerCurls;
        public object _fingerSplays;
        public object _lastFingerCurls;
        public object _lastFingerSplays;
        public object _poseChanged;
        public object _onlyUpdateSummaryData;
        public object skeletalSummaryData;
        public object lastSkeletalSummaryData;
        public object skeletonAction;
        public object tempBoneTransforms;
        public object skeletonActionData;
        public object lastSkeletonActionData;
        public object tempSkeletonActionData;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F22950
        public void remove_onActiveChange(){} // RVA: 0x6F22A50
        public void add_onActiveBindingChange(){} // RVA: 0x6F22B50
        public void remove_onActiveBindingChange(){} // RVA: 0x6F22C50
        public void add_onChange(){} // RVA: 0x6F22D50
        public void remove_onChange(){} // RVA: 0x6F22E50
        public void add_onUpdate(){} // RVA: 0x6F22F50
        public void remove_onUpdate(){} // RVA: 0x6F23050
        public void add_onTrackingChanged(){} // RVA: 0x6F23150
        public void remove_onTrackingChanged(){} // RVA: 0x6F23250
        public void add_onValidPoseChanged(){} // RVA: 0x6F23350
        public void remove_onValidPoseChanged(){} // RVA: 0x6F23450
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F23550
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F23650
        public void get_activeBinding(){} // RVA: 0x6F23750
        public void get_lastActiveBinding(){} // RVA: 0x6F23760
        public void get_bonePositions(){} // RVA: 0x164CA60
        public void set_bonePositions(){} // RVA: 0x163D120
        public void get_boneRotations(){} // RVA: 0x165BD90
        public void set_boneRotations(){} // RVA: 0x1654570
        public void get_lastBonePositions(){} // RVA: 0x165B400
        public void set_lastBonePositions(){} // RVA: 0x16672F0
        public void get_lastBoneRotations(){} // RVA: 0x165B7C0
        public void set_lastBoneRotations(){} // RVA: 0x1655D70
        public void get_rangeOfMotion(){} // RVA: 0x6F23770
        public void set_rangeOfMotion(){} // RVA: 0x6F23780
        public void get_skeletalTransformSpace(){} // RVA: 0x6F23790
        public void set_skeletalTransformSpace(){} // RVA: 0x6F237A0
        public void get_summaryDataType(){} // RVA: 0x6F237B0
        public void set_summaryDataType(){} // RVA: 0x6F237C0
        public void get_thumbCurl(){} // RVA: 0x6F237D0
        public void get_indexCurl(){} // RVA: 0x6F23800
        public void get_middleCurl(){} // RVA: 0x6F23830
        public void get_ringCurl(){} // RVA: 0x6F23860
        public void get_pinkyCurl(){} // RVA: 0x6F23890
        public void get_thumbIndexSplay(){} // RVA: 0x6F238C0
        public void get_indexMiddleSplay(){} // RVA: 0x6F238F0
        public void get_middleRingSplay(){} // RVA: 0x6F23920
        public void get_ringPinkySplay(){} // RVA: 0x6F23950
        public void get_lastThumbCurl(){} // RVA: 0x6F23980
        public void get_lastIndexCurl(){} // RVA: 0x6F239B0
        public void get_lastMiddleCurl(){} // RVA: 0x6F239E0
        public void get_lastRingCurl(){} // RVA: 0x6F23A10
        public void get_lastPinkyCurl(){} // RVA: 0x6F23A40
        public void get_lastThumbIndexSplay(){} // RVA: 0x6F23A70
        public void get_lastIndexMiddleSplay(){} // RVA: 0x6F23AA0
        public void get_lastMiddleRingSplay(){} // RVA: 0x6F23AD0
        public void get_lastRingPinkySplay(){} // RVA: 0x6F23B00
        public void get_fingerCurls(){} // RVA: 0x165B290
        public void set_fingerCurls(){} // RVA: 0x163AD00
        public void get_fingerSplays(){} // RVA: 0x16683A0
        public void set_fingerSplays(){} // RVA: 0x1658B20
        public void get_lastFingerCurls(){} // RVA: 0x1661B40
        public void set_lastFingerCurls(){} // RVA: 0x1664510
        public void get_lastFingerSplays(){} // RVA: 0x1175290
        public void set_lastFingerSplays(){} // RVA: 0x166AA40
        public void get_poseChanged(){} // RVA: 0x6F23B30
        public void set_poseChanged(){} // RVA: 0x6F23B40
        public void get_onlyUpdateSummaryData(){} // RVA: 0x6F23B50
        public void set_onlyUpdateSummaryData(){} // RVA: 0x6F23B60
        public void Preinitialize(){} // RVA: 0x6F23B70
        public void Initialize(){} // RVA: 0x6F24240
        public void RemoveAllListeners(){} // RVA: 0x6F24440
        public void UpdateValue(){} // RVA: 0x6F24880
        public void get_boneCount(){} // RVA: 0x6F25760
        public void GetBoneCount(){} // RVA: 0x6F25770
        public void get_boneHierarchy(){} // RVA: 0x6F25A40
        public void GetBoneHierarchy(){} // RVA: 0x6F25A50
        public void GetBoneName(){} // RVA: 0x6F25D50
        public void GetReferenceTransforms(){} // RVA: 0x6F260C0
        public void get_skeletalTrackingLevel(){} // RVA: 0x6F266D0
        public void GetSkeletalTrackingLevel(){} // RVA: 0x6F266E0
        public void GetSkeletalSummaryData(){} // RVA: 0x6F26930
        public void UpdateSkeletalSummaryData(){} // RVA: 0x6F26990
        public void CheckAndSendEvents(){} // RVA: 0x6F26D40
        public void .ctor(){} // RVA: 0x6F26F80
    }

    public class SteamVR_Action_Skeleton_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Skeleton_Source_Map : SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void GetSourceElementForIndexer(){} // RVA: 0x6F228D0
        public void .ctor(){} // RVA: 0x6F22900
    }

    public class SteamVR_Action_Source : Object
    {
        public object _inputSource;
        public object inputSourceHandle;
        public object action;

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x6F10B40
        public void get_handle(){} // RVA: 0x6F10B70
        public void get_actionSet(){} // RVA: 0x6F10BA0
        public void get_direction(){} // RVA: 0x6F10BD0
        public void get_inputSource(){} // RVA: 0xB8F8F0
        public void set_inputSource(){} // RVA: 0xB460A0
        public void get_setActive(){} // RVA: 0x6F10C00
        public void get_active(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void set_lastActive(){} // RVA: 0x894750
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void Preinitialize(){} // RVA: 0x6F10C90
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x6F10CF0
    }

    public class SteamVR_Action_Source_Map : Object
    {
        public object _fullPath;
        public object _handle;
        public object _actionSet;
        public object _direction;
        public object action;
        public object inLowered;
        public object outLowered;

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0xB5DBF0
        public void set_fullPath(){} // RVA: 0xB44D60
        public void get_handle(){} // RVA: 0xB465B0
        public void set_handle(){} // RVA: 0x15428E0
        public void get_actionSet(){} // RVA: 0xB700F0
        public void set_actionSet(){} // RVA: 0xB70100
        public void get_direction(){} // RVA: 0x1065D50
        public void set_direction(){} // RVA: 0x13233D0
        public void PreInitialize(){} // RVA: 0x6F10120
        public void PreinitializeMap(){} // RVA: 0x895750
        public void Initialize(){} // RVA: 0x6F10390
        public void GetActionSetPath(){} // RVA: 0x6F10590
        public void GetActionDirection(){} // RVA: 0x6F10610
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6F10820
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0xA94080
        public void OnAccessSource(){} // RVA: 0x8944F0
        public void Initialize(){} // RVA: 0x894290
        public void PreinitializeMap(){} // RVA: 0x895750
        public void GetSourceElementForIndexer(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Vector2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Vector3[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Vibration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0xA94080
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void get_actionSet(){} // RVA: 0x87C0A0
        public void get_direction(){} // RVA: 0x87C130
        public void get_active(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void PreInitialize(){} // RVA: 0x894320
        public void CreateUninitialized(){} // RVA: 0x89C370
        public void TryNeedsInitData(){} // RVA: 0x87C0A0
        public void Initialize(){} // RVA: 0x8949A0
        public void GetSourceMap(){} // RVA: 0x87C0A0
        public void InitializeCopy(){} // RVA: 0x8943B0
        public void InitAfterDeserialize(){} // RVA: 0x894290
        public void GetActive(){} // RVA: 0x87DD20
        public void GetActiveBinding(){} // RVA: 0x87DD20
        public void GetLastActive(){} // RVA: 0x87DD20
        public void GetLastActiveBinding(){} // RVA: 0x87DD20
        public void GetActionBindingInfo(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_ActivateActionSetOnLoad : MonoBehaviour
    {
        public object actionSet;
        public object forSources;
        public object disableAllOtherActionSets;
        public object activateOnStart;
        public object deactivateOnDestroy;
        public object initialPriority;

        // ── Methods ──
        public void Start(){} // RVA: 0x6F44110
        public void OnDestroy(){} // RVA: 0x6F44180
        public void .ctor(){} // RVA: 0x6F441E0
    }

    public class SteamVR_Behaviour : MonoBehaviour
    {
        public object openVRDeviceName;
        public object forcingInitialization;
        public object _instance;
        public object initializeSteamVROnAwake;
        public object doNotDestroy;
        public object steamvr_render;
        public object isPlaying;
        public object initializing;
        public object initializeCoroutine;
        public object loadedOpenVRDeviceSuccess;
        public object lastFrameCount;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6F6A5C0
        public void Initialize(){} // RVA: 0x6F6A700
        public void Awake(){} // RVA: 0x6F6AFA0
        public void InitializeSteamVR(){} // RVA: 0x6F6B0A0
        public void DoInitializeSteamVR(){} // RVA: 0x6F6B2C0
        public void XRDevice_deviceLoaded(){} // RVA: 0x6F6B360
        public void EnableOpenVR(){} // RVA: 0x6F6B440
        public void OnEnable(){} // RVA: 0x6F6B560
        public void OnDisable(){} // RVA: 0x6F6B700
        public void OnBeforeRender(){} // RVA: 0x6F6B8B0
        public void PreCull(){} // RVA: 0x6F6B8C0
        public void FixedUpdate(){} // RVA: 0x6F6BB30
        public void LateUpdate(){} // RVA: 0x6F6BCB0
        public void Update(){} // RVA: 0x6F6BE50
        public void OnQuit(){} // RVA: 0x6F6BFD0
        public void .ctor(){} // RVA: 0x6F6C020
        public void .cctor(){} // RVA: 0x6F6C070
    }

    public class SteamVR_Behaviour_Boolean : MonoBehaviour
    {
        public object booleanAction;
        public object inputSource;
        public object onChange;
        public object onChangeEvent;
        public object onUpdate;
        public object onUpdateEvent;
        public object onPress;
        public object onPressEvent;
        public object onPressDown;
        public object onPressDownEvent;
        public object onPressUp;
        public object onPressUpEvent;

        // ── Methods ──
        public void add_onChangeEvent(){} // RVA: 0x6F442E0
        public void remove_onChangeEvent(){} // RVA: 0x6F443D0
        public void add_onUpdateEvent(){} // RVA: 0x6F444C0
        public void remove_onUpdateEvent(){} // RVA: 0x6F445B0
        public void add_onPressEvent(){} // RVA: 0x6F446A0
        public void remove_onPressEvent(){} // RVA: 0x6F44790
        public void add_onPressDownEvent(){} // RVA: 0x6F44880
        public void remove_onPressDownEvent(){} // RVA: 0x6F44970
        public void add_onPressUpEvent(){} // RVA: 0x6F44A60
        public void remove_onPressUpEvent(){} // RVA: 0x6F44B50
        public void get_isActive(){} // RVA: 0x6F44C40
        public void get_actionSet(){} // RVA: 0x6F44C90
        public void OnEnable(){} // RVA: 0x6F44D90
        public void OnDisable(){} // RVA: 0x6F44E80
        public void AddHandlers(){} // RVA: 0x6F44E90
        public void RemoveHandlers(){} // RVA: 0x6F45150
        public void SteamVR_Behaviour_Boolean_OnStateUp(){} // RVA: 0x6F454B0
        public void SteamVR_Behaviour_Boolean_OnStateDown(){} // RVA: 0x6F45530
        public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x6F455B0
        public void SteamVR_Behaviour_Boolean_OnUpdate(){} // RVA: 0x6F45630
        public void SteamVR_Behaviour_Boolean_OnChange(){} // RVA: 0x6F456D0
        public void GetLocalizedName(){} // RVA: 0x6F45770
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_Behaviour_BooleanEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F310
    }

    public class SteamVR_Behaviour_Pose : MonoBehaviour
    {
        public object poseAction;
        public object inputSource;
        public object origin;
        public object onTransformUpdated;
        public object onTransformChanged;
        public object onConnectedChanged;
        public object onTrackingChanged;
        public object onDeviceIndexChanged;
        public object onTransformUpdatedEvent;
        public object onTransformChangedEvent;
        public object onConnectedChangedEvent;
        public object onTrackingChangedEvent;
        public object onDeviceIndexChangedEvent;
        public object broadcastDeviceChanges;
        public object deviceIndex;
        public object historyBuffer;
        public object lastFrameUpdated;

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x6F45C40
        public void get_isActive(){} // RVA: 0x6F44C40
        public void Start(){} // RVA: 0x6F45C80
        public void OnEnable(){} // RVA: 0x6F45EA0
        public void OnDisable(){} // RVA: 0x6F46190
        public void SteamVR_Behaviour_Pose_OnUpdate(){} // RVA: 0x6F46550
        public void UpdateTransform(){} // RVA: 0x6F467F0
        public void SteamVR_Behaviour_Pose_OnChange(){} // RVA: 0x6F46F20
        public void OnDeviceConnectedChanged(){} // RVA: 0x6F46FA0
        public void OnTrackingChanged(){} // RVA: 0x6F47050
        public void CheckDeviceIndex(){} // RVA: 0x6F470E0
        public void GetDeviceIndex(){} // RVA: 0x6F47330
        public void GetVelocity(){} // RVA: 0x6F47370
        public void GetAngularVelocity(){} // RVA: 0x6F473D0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x6F47430
        public void GetEstimatedPeakVelocities(){} // RVA: 0x6F474A0
        public void UpdateHistoryBuffer(){} // RVA: 0x6F475E0
        public void GetLocalizedName(){} // RVA: 0x6F47800
        public void .ctor(){} // RVA: 0x6F47940
    }

    public class SteamVR_Behaviour_PoseEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F3A0
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F430
    }

    public class SteamVR_Behaviour_Single : MonoBehaviour
    {
        public object singleAction;
        public object inputSource;
        public object onChange;
        public object onUpdate;
        public object onAxis;
        public object onChangeEvent;
        public object onUpdateEvent;
        public object onAxisEvent;

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x6F47FE0
        public void OnEnable(){} // RVA: 0x6F48020
        public void OnDisable(){} // RVA: 0x6F48110
        public void AddHandlers(){} // RVA: 0x6F48120
        public void RemoveHandlers(){} // RVA: 0x6F482E0
        public void SteamVR_Behaviour_Single_OnUpdate(){} // RVA: 0x6F48540
        public void SteamVR_Behaviour_Single_OnChange(){} // RVA: 0x6F48600
        public void SteamVR_Behaviour_Single_OnAxis(){} // RVA: 0x6F486C0
        public void GetLocalizedName(){} // RVA: 0x6F48780
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_Behaviour_Skeleton : MonoBehaviour
    {
        public object skeletonAction;
        public object inputSource;
        public object rangeOfMotion;
        public object skeletonRoot;
        public object origin;
        public object updatePose;
        public object onlySetRotations;
        public object skeletonBlend;
        public object onBoneTransformsUpdated;
        public object onTransformUpdated;
        public object onTransformChanged;
        public object onConnectedChanged;
        public object onTrackingChanged;
        public object onBoneTransformsUpdatedEvent;
        public object onTransformUpdatedEvent;
        public object onTransformChangedEvent;
        public object onConnectedChangedEvent;
        public object onTrackingChangedEvent;
        public object mirroring;
        public object fallbackPoser;
        public object fallbackCurlAction;
        public object blendPoser;
        public object blendSnapshot;
        public object _proximals;
        public object _middles;
        public object _distals;
        public object _tips;
        public object _auxs;
        public object blendRoutine;
        public object rangeOfMotionBlendRoutine;
        public object attachRoutine;
        public object bones;
        public object temporaryRangeOfMotion;
        public object rightFlipAngle;

        // ── Methods ──
        public void get_skeletonAvailable(){} // RVA: 0x6F48B00
        public void get_isActive(){} // RVA: 0x6F48B30
        public void get_fingerCurls(){} // RVA: 0x6F48BB0
        public void get_thumbCurl(){} // RVA: 0x6F48D10
        public void get_indexCurl(){} // RVA: 0x6F48D80
        public void get_middleCurl(){} // RVA: 0x6F48DF0
        public void get_ringCurl(){} // RVA: 0x6F48E60
        public void get_pinkyCurl(){} // RVA: 0x6F48ED0
        public void get_root(){} // RVA: 0x6F48F40
        public void get_wrist(){} // RVA: 0x6F48F70
        public void get_indexMetacarpal(){} // RVA: 0x6F48FA0
        public void get_indexProximal(){} // RVA: 0x6F48FD0
        public void get_indexMiddle(){} // RVA: 0x6F49000
        public void get_indexDistal(){} // RVA: 0x6F49030
        public void get_indexTip(){} // RVA: 0x6F49060
        public void get_middleMetacarpal(){} // RVA: 0x6F49090
        public void get_middleProximal(){} // RVA: 0x6F490C0
        public void get_middleMiddle(){} // RVA: 0x6F490F0
        public void get_middleDistal(){} // RVA: 0x6F49120
        public void get_middleTip(){} // RVA: 0x6F49150
        public void get_pinkyMetacarpal(){} // RVA: 0x6F49180
        public void get_pinkyProximal(){} // RVA: 0x6F491B0
        public void get_pinkyMiddle(){} // RVA: 0x6F491E0
        public void get_pinkyDistal(){} // RVA: 0x6F49210
        public void get_pinkyTip(){} // RVA: 0x6F49240
        public void get_ringMetacarpal(){} // RVA: 0x6F49270
        public void get_ringProximal(){} // RVA: 0x6F492A0
        public void get_ringMiddle(){} // RVA: 0x6F492D0
        public void get_ringDistal(){} // RVA: 0x6F49300
        public void get_ringTip(){} // RVA: 0x6F49330
        public void get_thumbMetacarpal(){} // RVA: 0x6F49360
        public void get_thumbProximal(){} // RVA: 0x6F49360
        public void get_thumbMiddle(){} // RVA: 0x6F49390
        public void get_thumbDistal(){} // RVA: 0x6F493C0
        public void get_thumbTip(){} // RVA: 0x6F493F0
        public void get_thumbAux(){} // RVA: 0x6F49420
        public void get_indexAux(){} // RVA: 0x6F49450
        public void get_middleAux(){} // RVA: 0x6F49480
        public void get_ringAux(){} // RVA: 0x6F494B0
        public void get_pinkyAux(){} // RVA: 0x6F494E0
        public void get_proximals(){} // RVA: 0xBAE420
        public void set_proximals(){} // RVA: 0xBAE430
        public void get_middles(){} // RVA: 0xCA4D80
        public void set_middles(){} // RVA: 0xCA4D90
        public void get_distals(){} // RVA: 0xC68EB0
        public void set_distals(){} // RVA: 0xC68EC0
        public void get_tips(){} // RVA: 0x135D730
        public void set_tips(){} // RVA: 0xBC5AD0
        public void get_auxs(){} // RVA: 0xBC5B30
        public void set_auxs(){} // RVA: 0xBC5B40
        public void get_skeletalTrackingLevel(){} // RVA: 0x6F49510
        public void get_isBlending(){} // RVA: 0x6F495B0
        public void get_actionSet(){} // RVA: 0x6F10BA0
        public void get_direction(){} // RVA: 0x6F10BD0
        public void Awake(){} // RVA: 0x6F495C0
        public void CheckSkeletonAction(){} // RVA: 0x6F4A1F0
        public void AssignBonesArray(){} // RVA: 0x6F4A380
        public void OnEnable(){} // RVA: 0x6F4A420
        public void OnDisable(){} // RVA: 0x6F4A7F0
        public void OnDeviceConnectedChanged(){} // RVA: 0x6F4ABC0
        public void OnTrackingChanged(){} // RVA: 0x6F4AC60
        public void SteamVR_Input_OnSkeletonsUpdated(){} // RVA: 0x11F4110
        public void UpdateSkeleton(){} // RVA: 0x6F4AD00
        public void SetTemporaryRangeOfMotion(){} // RVA: 0x6F4AFA0
        public void ResetTemporaryRangeOfMotion(){} // RVA: 0x6F4B030
        public void SetRangeOfMotion(){} // RVA: 0x6F4B180
        public void BlendToSkeleton(){} // RVA: 0x6F4B300
        public void BlendToPoser(){} // RVA: 0x6F4B500
        public void BlendToAnimation(){} // RVA: 0x6F4B640
        public void BlendTo(){} // RVA: 0x6F4B650
        public void DoBlendRoutine(){} // RVA: 0x6F4B840
        public void RangeOfMotionBlend(){} // RVA: 0x6F4B900
        public void TemporaryRangeOfMotionBlend(){} // RVA: 0x6F4BA80
        public void ResetTemporaryRangeOfMotionBlend(){} // RVA: 0x6F4B030
        public void DoRangeOfMotionBlend(){} // RVA: 0x6F4BC60
        public void GetBlendPoseForBone(){} // RVA: 0x6F4BD30
        public void UpdateSkeletonTransforms(){} // RVA: 0x6F4BD80
        public void SetBonePosition(){} // RVA: 0x6F4CC20
        public void SetBoneRotation(){} // RVA: 0x6F4CD10
        public void GetBone(){} // RVA: 0x6F4CDE0
        public void GetBonePosition(){} // RVA: 0x6F4CE50
        public void GetBoneRotation(){} // RVA: 0x6F4D000
        public void GetBonePositions(){} // RVA: 0x6F4D1A0
        public void GetBoneRotations(){} // RVA: 0x6F4D530
        public void MirrorPosition(){} // RVA: 0x6F4D7E0
        public void MirrorRotation(){} // RVA: 0x6F4D8C0
        public void UpdatePose(){} // RVA: 0x6F4DB10
        public void ForceToReferencePose(){} // RVA: 0x6F4E460
        public void IsMetacarpal(){} // RVA: 0x6F4EBA0
        public void .ctor(){} // RVA: 0x6F4EBC0
        public void .cctor(){} // RVA: 0x6F4EC20
    }

    public class SteamVR_Behaviour_SkeletonCustom : SteamVR_Behaviour_Skeleton
    {
        public object _wrist;
        public object _thumbMetacarpal;
        public object _thumbProximal;
        public object _thumbMiddle;
        public object _thumbDistal;
        public object _thumbTip;
        public object _thumbAux;
        public object _indexMetacarpal;
        public object _indexProximal;
        public object _indexMiddle;
        public object _indexDistal;
        public object _indexTip;
        public object _indexAux;
        public object _middleMetacarpal;
        public object _middleProximal;
        public object _middleMiddle;
        public object _middleDistal;
        public object _middleTip;
        public object _middleAux;
        public object _ringMetacarpal;
        public object _ringProximal;
        public object _ringMiddle;
        public object _ringDistal;
        public object _ringTip;
        public object _ringAux;
        public object _pinkyMetacarpal;
        public object _pinkyProximal;
        public object _pinkyMiddle;
        public object _pinkyDistal;
        public object _pinkyTip;
        public object _pinkyAux;

        // ── Methods ──
        public void AssignBonesArray(){} // RVA: 0x6F4FF50
        public void .ctor(){} // RVA: 0x6F50800
    }

    public class SteamVR_Behaviour_SkeletonEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F670
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F700
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F790
    }

    public class SteamVR_Behaviour_Vector2 : MonoBehaviour
    {
        public object vector2Action;
        public object inputSource;
        public object onChange;
        public object onUpdate;
        public object onAxis;
        public object onChangeEvent;
        public object onUpdateEvent;
        public object onAxisEvent;

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x6F47FE0
        public void OnEnable(){} // RVA: 0x6F508A0
        public void OnDisable(){} // RVA: 0x6F50990
        public void AddHandlers(){} // RVA: 0x6F509A0
        public void RemoveHandlers(){} // RVA: 0x6F50B60
        public void SteamVR_Behaviour_Vector2_OnUpdate(){} // RVA: 0x6F50DC0
        public void SteamVR_Behaviour_Vector2_OnChange(){} // RVA: 0x6F50E80
        public void SteamVR_Behaviour_Vector2_OnAxis(){} // RVA: 0x6F50F40
        public void GetLocalizedName(){} // RVA: 0x6F51000
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_Behaviour_Vector3 : MonoBehaviour
    {
        public object vector3Action;
        public object inputSource;
        public object onChange;
        public object onUpdate;
        public object onAxis;
        public object onChangeEvent;
        public object onUpdateEvent;
        public object onAxisEvent;

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x6F47FE0
        public void OnEnable(){} // RVA: 0x6F513B0
        public void OnDisable(){} // RVA: 0x6F514A0
        public void AddHandlers(){} // RVA: 0x6F514B0
        public void RemoveHandlers(){} // RVA: 0x6F51670
        public void SteamVR_Behaviour_Vector3_OnUpdate(){} // RVA: 0x6F518D0
        public void SteamVR_Behaviour_Vector3_OnChange(){} // RVA: 0x6F519E0
        public void SteamVR_Behaviour_Vector3_OnAxis(){} // RVA: 0x6F51AF0
        public void GetLocalizedName(){} // RVA: 0x6F51C00
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_Camera : MonoBehaviour
    {
        public object _head;
        public object _camera;
        public object _ears;
        public object wireframe;
        public object values;
        public object eyeSuffix;
        public object earsSuffix;
        public object headSuffix;
        public object originSuffix;

        // ── Methods ──
        public void get_head(){} // RVA: 0xB700F0
        public void get_offset(){} // RVA: 0xB700F0
        public void get_origin(){} // RVA: 0x6F6C560
        public void get_camera(){} // RVA: 0xB70160
        public void set_camera(){} // RVA: 0xB44DC0
        public void get_ears(){} // RVA: 0xD33E60
        public void GetRay(){} // RVA: 0x6F6C580
        public void get_sceneResolutionScale(){} // RVA: 0x6F6C720
        public void set_sceneResolutionScale(){} // RVA: 0x6F6C770
        public void OnDisable(){} // RVA: 0x6F6C7D0
        public void OnEnable(){} // RVA: 0x6F6C930
        public void Awake(){} // RVA: 0x6F6D660
        public void ForceLast(){} // RVA: 0x6F6D6F0
        public void get_baseName(){} // RVA: 0x6F6E0D0
        public void Expand(){} // RVA: 0x6F6E190
        public void Collapse(){} // RVA: 0x6F6F8B0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_CameraFlip : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6F70A40
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_CameraHelper : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6F0F1D0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_CameraMask : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6F70B10
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_Camera[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Ears : MonoBehaviour
    {
        public object vrcam;
        public object usingSpeakers;
        public object offset;

        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x6F70BE0
        public void OnEnable(){} // RVA: 0x6F70FA0
        public void OnDisable(){} // RVA: 0x6F71320
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_ExternalCamera : MonoBehaviour
    {
        public object cameraPose;
        public object cameraInputSource;
        public object config;
        public object configPath;
        public object autoEnableDisableActionSet;
        public object watcher;
        public object cam;
        public object target;
        public object clipQuad;
        public object clipMaterial;
        public object activatedActionSet;
        public object activatedInputSource;
        public object colorMat;
        public object alphaMat;
        public object cameras;
        public object cameraRects;
        public object sceneResolutionScale;

        // ── Methods ──
        public void ReadConfig(){} // RVA: 0x6F72F90
        public void SetupPose(){} // RVA: 0x6F739E0
        public void SetupDeviceIndex(){} // RVA: 0x6F73B30
        public void OnChanged(){} // RVA: 0x6F73CD0
        public void AttachToCamera(){} // RVA: 0x6F73CE0
        public void GetTargetDistance(){} // RVA: 0x6F753A0
        public void RenderNear(){} // RVA: 0x6F75940
        public void RenderFar(){} // RVA: 0x6F76CA0
        public void OnGUI(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0x6F76EE0
        public void AutoEnableActionSet(){} // RVA: 0x6F774E0
        public void OnDisable(){} // RVA: 0x6F77670
        public void .ctor(){} // RVA: 0x6F77A60
    }

    public class SteamVR_Fade : MonoBehaviour
    {
        public object currentColor;
        public object targetColor;
        public object deltaColor;
        public object fadeOverlay;
        public object fadeMaterial;
        public object fadeMaterialColorID;

        // ── Methods ──
        public void Start(){} // RVA: 0x6F77EB0
        public void View(){} // RVA: 0x6F77F80
        public void OnStartFade(){} // RVA: 0x6F78000
        public void OnEnable(){} // RVA: 0x6F780B0
        public void OnDisable(){} // RVA: 0x6F78380
        public void OnPostRender(){} // RVA: 0x6F78480
        public void .ctor(){} // RVA: 0x6F78990
        public void .cctor(){} // RVA: 0x6F789F0
    }

    public class SteamVR_Frustum : MonoBehaviour
    {
        public object index;
        public object fovLeft;
        public object fovRight;
        public object fovTop;
        public object fovBottom;
        public object nearZ;
        public object farZ;

        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x6F78AA0
        public void OnDeviceConnected(){} // RVA: 0x6F79550
        public void OnEnable(){} // RVA: 0x6F797B0
        public void OnDisable(){} // RVA: 0x6F79960
        public void .ctor(){} // RVA: 0x6F79B40
    }

    public class SteamVR_IK : MonoBehaviour
    {
        public object target;
        public object start;
        public object joint;
        public object end;
        public object poleVector;
        public object upVector;
        public object blendPct;
        public object startXform;
        public object jointXform;
        public object endXform;

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x6F79BB0
        public void Solve(){} // RVA: 0x6F7B650
        public void .ctor(){} // RVA: 0x6F7BCF0
    }

    public class SteamVR_Input : Object
    {
        public object defaultInputGameObjectName;
        public object localizationKeyName;
        public object fileInitialized;
        public object initialized;
        public object preInitialized;
        public object actionFile;
        public object actionFileHash;
        public object onNonVisualActionsUpdated;
        public object onPosesUpdated;
        public object onSkeletonsUpdated;
        public object initializing;
        public object startupFrame;
        public object actionSets;
        public object actions;
        public object actionsIn;
        public object actionsOut;
        public object actionsBoolean;
        public object actionsSingle;
        public object actionsVector2;
        public object actionsVector3;
        public object actionsPose;
        public object actionsSkeleton;
        public object actionsVibration;
        public object actionsNonPoseNonSkeletonIn;
        public object actionSetsByPath;
        public object actionSetsByPathLowered;
        public object actionsByPath;
        public object actionsByPathLowered;
        public object actionSetsByPathCache;
        public object actionsByPathCache;
        public object actionsByNameCache;
        public object actionSetsByNameCache;
        public object sizeVRActiveActionSet_t;
        public object setCache;

        // ── Methods ──
        public void GetActionSetFromPath(){} // RVA: 0x6F567D0
        public void GetAction(){} // RVA: 0x29C7BE0
        public void CreateFakeAction(){} // RVA: 0x29C79F0
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x6F51FB0
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x6F52100
        public void add_onPosesUpdated(){} // RVA: 0x6F52250
        public void remove_onPosesUpdated(){} // RVA: 0x6F523A0
        public void add_onSkeletonsUpdated(){} // RVA: 0x6F524F0
        public void remove_onSkeletonsUpdated(){} // RVA: 0x6F52640
        public void get_isStartupFrame(){} // RVA: 0x6F52790
        public void .cctor(){} // RVA: 0x6F528B0
        public void ForcePreinitialize(){} // RVA: 0x6F52ED0
        public void FindPreinitializeMethod(){} // RVA: 0x6F52F20
        public void Initialize(){} // RVA: 0x6F53100
        public void PreinitializeFinishActionSets(){} // RVA: 0x6F536E0
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x6F537C0
        public void PreinitializeActionDictionaries(){} // RVA: 0x6F53A60
        public void Update(){} // RVA: 0x6F53CE0
        public void LateUpdate(){} // RVA: 0x6F53DF0
        public void FixedUpdate(){} // RVA: 0x6F53F30
        public void OnPreCull(){} // RVA: 0x6F54040
        public void UpdateVisualActions(){} // RVA: 0x6F54150
        public void UpdatePoseActions(){} // RVA: 0x6F54360
        public void UpdateSkeletonActions(){} // RVA: 0x6F544F0
        public void UpdateNonVisualActions(){} // RVA: 0x6F54680
        public void ShowBindingHintsForSets(){} // RVA: 0x6F54880
        public void ShowBindingHints(){} // RVA: 0x6F54BF0
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x6F54CD0
        public void GetActionDataFromPath(){} // RVA: 0x29C7E70
        public void GetActionSetDataFromPath(){} // RVA: 0x6F54E90
        public void GetActionFromPath(){} // RVA: 0xA94080
        public void GetBaseActionFromPath(){} // RVA: 0x6F54F40
        public void HasActionPath(){} // RVA: 0x6F553B0
        public void HasAction(){} // RVA: 0x6F555D0
        public void GetBooleanActionFromPath(){} // RVA: 0x6F556E0
        public void GetSingleActionFromPath(){} // RVA: 0x6F55760
        public void GetVector2ActionFromPath(){} // RVA: 0x6F557E0
        public void GetVector3ActionFromPath(){} // RVA: 0x6F55860
        public void GetVibrationActionFromPath(){} // RVA: 0x6F558E0
        public void GetPoseActionFromPath(){} // RVA: 0x6F55960
        public void GetSkeletonActionFromPath(){} // RVA: 0x6F559E0
        public void GetBaseAction(){} // RVA: 0x6F55A60
        public void GetBooleanAction(){} // RVA: 0x6F55FC0
        public void GetSingleAction(){} // RVA: 0x6F560D0
        public void GetVector2Action(){} // RVA: 0x6F561E0
        public void GetVector3Action(){} // RVA: 0x6F562F0
        public void GetPoseAction(){} // RVA: 0x6F56400
        public void GetSkeletonAction(){} // RVA: 0x6F56510
        public void GetVibrationAction(){} // RVA: 0x6F56620
        public void GetActionSet(){} // RVA: 0x6F566A0
        public void HasActionSet(){} // RVA: 0x6F56730
        public void GetState(){} // RVA: 0x6F569B0
        public void GetStateDown(){} // RVA: 0x6F56CA0
        public void GetStateUp(){} // RVA: 0x6F56F90
        public void GetFloat(){} // RVA: 0x6F57280
        public void GetSingle(){} // RVA: 0x6F57460
        public void GetVector2(){} // RVA: 0x6F57670
        public void GetVector3(){} // RVA: 0x6F57A10
        public void GetActionSets(){} // RVA: 0x6F57AB0
        public void GetActions(){} // RVA: 0x87C0D0
        public void ShouldMakeCopy(){} // RVA: 0x6F57B10
        public void GetLocalizedName(){} // RVA: 0x6F57B70
        public void CheckOldLocation(){} // RVA: 0xB43320
        public void IdentifyActionsFile(){} // RVA: 0x6F57CD0
        public void HasFileInMemoryBeenModified(){} // RVA: 0x6F58050
        public void CreateEmptyActionsFile(){} // RVA: 0x6F58220
        public void DoesActionsFileExist(){} // RVA: 0x6F588B0
        public void InitializeFile(){} // RVA: 0x6F58910
        public void GetActionsFileFolder(){} // RVA: 0x6F58D30
        public void GetActionsFilePath(){} // RVA: 0x6F58E00
        public void GetActionsFileName(){} // RVA: 0x6F59050
        public void DeleteManifestAndBindings(){} // RVA: 0x6F590B0
        public void OpenBindingUI(){} // RVA: 0x6F595F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_Sources[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_LoadLevel : MonoBehaviour
    {
        public object _active;
        public object levelName;
        public object internalProcessPath;
        public object internalProcessArgs;
        public object loadAdditive;
        public object loadAsync;
        public object loadingScreen;
        public object progressBarEmpty;
        public object progressBarFull;
        public object loadingScreenWidthInMeters;
        public object progressBarWidthInMeters;
        public object loadingScreenDistance;
        public object loadingScreenTransform;
        public object progressBarTransform;
        public object front;
        public object back;
        public object left;
        public object right;
        public object top;
        public object bottom;
        public object backgroundColor;
        public object showGrid;
        public object fadeOutTime;
        public object fadeInTime;
        public object postLoadSettleTime;
        public object loadingScreenFadeInTime;
        public object loadingScreenFadeOutTime;
        public object fadeRate;
        public object alpha;
        public object async;
        public object renderTexture;
        public object loadingScreenOverlayHandle;
        public object progressBarOverlayHandle;
        public object autoTriggerOnEnable;

        // ── Methods ──
        public void get_loading(){} // RVA: 0x6F7BD40
        public void get_progress(){} // RVA: 0x6F7BE30
        public void get_progressTexture(){} // RVA: 0x6F7BFA0
        public void OnEnable(){} // RVA: 0x6F7C0B0
        public void Trigger(){} // RVA: 0x6F7C0D0
        public void Begin(){} // RVA: 0x6F7C270
        public void OnGUI(){} // RVA: 0x6F7C420
        public void Update(){} // RVA: 0x6F7CBC0
        public void LoadLevel(){} // RVA: 0x6F7CE20
        public void GetOverlayHandle(){} // RVA: 0x6F7CEC0
        public void .ctor(){} // RVA: 0x6F7D460
    }

    public class SteamVR_Menu : MonoBehaviour
    {
        public object cursor;
        public object background;
        public object logo;
        public object logoHeight;
        public object menuOffset;
        public object scaleLimits;
        public object scaleRate;
        public object overlay;
        public object overlayCam;
        public object uvOffset;
        public object distance;
        public object _scale;
        public object scaleLimitX;
        public object scaleLimitY;
        public object scaleRateText;
        public object savedCursorLockState;
        public object savedCursorVisible;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x6F7EB20
        public void get_scale(){} // RVA: 0xB6B240
        public void set_scale(){} // RVA: 0xB6B250
        public void Awake(){} // RVA: 0x6F7EC60
        public void OnGUI(){} // RVA: 0x6F7EFA0
        public void ShowMenu(){} // RVA: 0x6F806D0
        public void HideMenu(){} // RVA: 0x6F80DC0
        public void Update(){} // RVA: 0x6F81050
        public void SetScale(){} // RVA: 0x6F812E0
        public void SaveCursorState(){} // RVA: 0x6F81480
        public void RestoreCursorState(){} // RVA: 0x6F81520
        public void .ctor(){} // RVA: 0x6F815D0
    }

    public class SteamVR_Overlay : MonoBehaviour
    {
        public object texture;
        public object scale;
        public object distance;
        public object alpha;
        public object uvOffset;
        public object mouseScale;
        public object inputMethod;
        public object _instance;
        public object handle;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6F81630
        public void set_instance(){} // RVA: 0x6F81670
        public void get_key(){} // RVA: 0x6F81710
        public void OnEnable(){} // RVA: 0x6F817B0
        public void OnDisable(){} // RVA: 0x6F81950
        public void UpdateOverlay(){} // RVA: 0x6F819B0
        public void PollNextEvent(){} // RVA: 0x6F81FE0
        public void ComputeIntersection(){} // RVA: 0x6F82110
        public void .ctor(){} // RVA: 0x6F82310
    }

    public class SteamVR_PlayArea : MonoBehaviour
    {
        public object borderThickness;
        public object wireframeHeight;
        public object drawWireframeWhenSelectedOnly;
        public object drawInGame;
        public object size;
        public object color;
        public object vertices;

        // ── Methods ──
        public void GetBounds(){} // RVA: 0x6F82390
        public void BuildMesh(){} // RVA: 0x6F82690
        public void OnDrawGizmos(){} // RVA: 0x6F835A0
        public void OnDrawGizmosSelected(){} // RVA: 0x6F835B0
        public void DrawWireframe(){} // RVA: 0x6F835C0
        public void OnEnable(){} // RVA: 0x6F83CA0
        public void UpdateBounds(){} // RVA: 0x6F83E30
        public void .ctor(){} // RVA: 0x6F83ED0
    }

    public class SteamVR_Render : MonoBehaviour
    {
        public object externalCamera;
        public object externalCameraConfigPath;
        public object _eye;
        public object isQuitting;
        public object cameras;
        public object poses;
        public object gamePoses;
        public object _pauseRendering;
        public object waitForEndOfFrame;
        public object doesPathExist;
        public object timeScale;
        public object screenshotTypes;

        // ── Methods ──
        public void get_eye(){} // RVA: 0x6F84150
        public void set_eye(){} // RVA: 0x6F84190
        public void get_instance(){} // RVA: 0x6F841D0
        public void OnApplicationQuit(){} // RVA: 0x6F84230
        public void Add(){} // RVA: 0x6F842A0
        public void Remove(){} // RVA: 0x6F6C7D0
        public void Top(){} // RVA: 0x6F84350
        public void AddInternal(){} // RVA: 0x6F84410
        public void RemoveInternal(){} // RVA: 0x6F846F0
        public void TopInternal(){} // RVA: 0x6F84AC0
        public void get_pauseRendering(){} // RVA: 0x6F84B00
        public void set_pauseRendering(){} // RVA: 0x6F84B40
        public void RenderLoop(){} // RVA: 0x6F84BD0
        public void CheckExternalCamera(){} // RVA: 0x6F84C70
        public void RenderExternalCamera(){} // RVA: 0x6F85710
        public void OnInputFocus(){} // RVA: 0x6F858F0
        public void GetScreenshotFilename(){} // RVA: 0x6F85A10
        public void OnRequestScreenshot(){} // RVA: 0x6F85B80
        public void OnEnable(){} // RVA: 0x6F861D0
        public void OnSteamVRInitialized(){} // RVA: 0x6F867C0
        public void OnDisable(){} // RVA: 0x6F86820
        public void UpdatePoses(){} // RVA: 0x6F86C10
        public void OnBeforeRender(){} // RVA: 0x6F86D40
        public void Update(){} // RVA: 0x6F86E10
        public void .ctor(){} // RVA: 0x6F87390
    }

    public class SteamVR_RenderModel : MonoBehaviour
    {
        public object index;
        public object inputSource;
        public object modelOverrideWarning;
        public object modelOverride;
        public object shader;
        public object verbose;
        public object createComponents;
        public object updateDynamically;
        public object controllerModeState;
        public object k_localTransformName;
        public object _renderModelName;
        public object _initializedAttachPoints;
        public object componentAttachPoints;
        public object meshRenderers;
        public object models;
        public object materials;
        public object deviceConnectedAction;
        public object hideRenderModelsAction;
        public object modelSkinSettingsHaveChangedAction;
        public object nameCache;

        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0xBC1B30
        public void set_renderModelName(){} // RVA: 0xB6A8C0
        public void get_initializedAttachPoints(){} // RVA: 0xBFDA40
        public void set_initializedAttachPoints(){} // RVA: 0xBFDA50
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x6F87AC0
        public void SetMeshRendererState(){} // RVA: 0x6F87B70
        public void OnHideRenderModels(){} // RVA: 0x6F87D10
        public void OnDeviceConnected(){} // RVA: 0x6F87D20
        public void UpdateModel(){} // RVA: 0x6F87D40
        public void SetModelAsync(){} // RVA: 0x6F88080
        public void SetModel(){} // RVA: 0x6F88180
        public void LoadRenderModel(){} // RVA: 0x6F88730
        public void ConvertByteColorGammaExp(){} // RVA: 0x6F89DA0
        public void FreeRenderModel(){} // RVA: 0x6F89E00
        public void FindTransformByName(){} // RVA: 0x6F89E50
        public void GetComponentTransform(){} // RVA: 0x6F8A050
        public void StripMesh(){} // RVA: 0x6F8A110
        public void LoadComponents(){} // RVA: 0x6F8A370
        public void .ctor(){} // RVA: 0x6F8B2F0
        public void OnEnable(){} // RVA: 0x6F8B730
        public void OnDisable(){} // RVA: 0x6F8B860
        public void Update(){} // RVA: 0x6F8B8D0
        public void UpdateComponents(){} // RVA: 0x6F8B920
        public void SetDeviceIndex(){} // RVA: 0x6F8C390
        public void SetInputSource(){} // RVA: 0x1FAA840
        public void Sleep(){} // RVA: 0x6F8C4A0
        public void MarshalRenderModel(){} // RVA: 0x6F8C4B0
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x6F8C720
        public void .cctor(){} // RVA: 0x6F8C9A0
    }

    public class SteamVR_Render[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Settings : ScriptableObject
    {
        public object _instance;
        public object pauseGameWhenDashboardVisible;
        public object lockPhysicsUpdateRateToRenderFrequency;
        public object trackingSpaceOrigin;
        public object actionsFilePath;
        public object steamVRInputPath;
        public object inputUpdateMode;
        public object poseUpdateMode;
        public object activateFirstActionSetOnStart;
        public object editorAppKey;
        public object autoEnableVR;
        public object legacyMixedRealityCamera;
        public object mixedRealityCameraPose;
        public object mixedRealityCameraInputSource;
        public object mixedRealityActionSetAutoEnable;
        public object previewHandLeft;
        public object previewHandRight;
        public object previewLeftDefaultAssetName;
        public object previewRightDefaultAssetName;
        public object defaultSettingsAssetName;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6F8E5C0
        public void get_trackingSpace(){} // RVA: 0x2244FB0
        public void set_trackingSpace(){} // RVA: 0x6F8E610
        public void IsInputUpdateMode(){} // RVA: 0x6F8E690
        public void IsPoseUpdateMode(){} // RVA: 0x6F8E6A0
        public void VerifyScriptableObject(){} // RVA: 0x6F8E6B0
        public void LoadInstance(){} // RVA: 0x6F8E6C0
        public void Save(){} // RVA: 0xB43310
        public void SetDefaultsIfNeeded(){} // RVA: 0x6F8E980
        public void FindDefaultPreviewHand(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0x6F8EB90
    }

    public class SteamVR_Skeleton_Pose : ScriptableObject
    {
        public object leftHand;
        public object rightHand;
        public object leftHandInputSource;
        public object rightHandInputSource;
        public object applyToSkeletonRoot;

        // ── Methods ──
        public void GetHand(){} // RVA: 0x6F61660
        public void .ctor(){} // RVA: 0x6F61680
    }

    public class SteamVR_Skeleton_PoseSnapshot : Object
    {
        public object inputSource;
        public object position;
        public object rotation;
        public object bonePositions;
        public object boneRotations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F65690
        public void CopyFrom(){} // RVA: 0x6F65830
    }

    public class SteamVR_Skeleton_Pose[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Skeleton_Pose_Hand : Object
    {
        public object inputSource;
        public object thumbFingerMovementType;
        public object indexFingerMovementType;
        public object middleFingerMovementType;
        public object ringFingerMovementType;
        public object pinkyFingerMovementType;
        public object ignoreRootPoseData;
        public object ignoreWristPoseData;
        public object position;
        public object rotation;
        public object bonePositions;
        public object boneRotations;

        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x6F617B0
        public void .ctor(){} // RVA: 0x6F61880
        public void GetMovementTypeForBone(){} // RVA: 0x6F61890
    }

    public class SteamVR_Skeleton_Poser : MonoBehaviour
    {
        public object poseEditorExpanded;
        public object blendEditorExpanded;
        public object poseNames;
        public object overridePreviewLeftHandPrefab;
        public object overridePreviewRightHandPrefab;
        public object skeletonMainPose;
        public object skeletonAdditionalPoses;
        public object showLeftPreview;
        public object showRightPreview;
        public object previewLeftInstance;
        public object previewRightInstance;
        public object previewPoseSelection;
        public object blendingBehaviours;
        public object blendedSnapshotL;
        public object blendedSnapshotR;
        public object blendPoses;
        public object boneCount;
        public object poseUpdatedThisFrame;
        public object scale;

        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x6F61E80
        public void Awake(){} // RVA: 0x6F61EA0
        public void SetBlendingBehaviourValue(){} // RVA: 0x6F62460
        public void GetBlendingBehaviourValue(){} // RVA: 0x6F62530
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x6F62560
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x6F62590
        public void GetBlendingBehaviour(){} // RVA: 0x6F625C0
        public void FindBlendingBehaviour(){} // RVA: 0x6F625D0
        public void GetPoseByIndex(){} // RVA: 0x6F627C0
        public void GetHandSnapshot(){} // RVA: 0x6F62850
        public void GetBlendedPose(){} // RVA: 0x6F628B0
        public void UpdatePose(){} // RVA: 0x6F62900
        public void ApplyBlenderBehaviours(){} // RVA: 0x6F62BD0
        public void LateUpdate(){} // RVA: 0x6F62FD0
        public void BlendVectors(){} // RVA: 0x6F62FE0
        public void BlendQuaternions(){} // RVA: 0x6F630E0
        public void GetTargetHandPosition(){} // RVA: 0x6F633E0
        public void GetTargetHandRotation(){} // RVA: 0x6F63B00
        public void .ctor(){} // RVA: 0x6F642F0
    }

    public class SteamVR_Skybox : MonoBehaviour
    {
        public object front;
        public object back;
        public object left;
        public object right;
        public object top;
        public object bottom;
        public object StereoCellSize;
        public object StereoIpdMm;

        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x6F8EDD0
        public void GetTextureByIndex(){} // RVA: 0x6F8EE60
        public void SetOverride(){} // RVA: 0x6F8EEC0
        public void ClearOverride(){} // RVA: 0x6F8F3D0
        public void OnEnable(){} // RVA: 0x6F8F420
        public void OnDisable(){} // RVA: 0x6F8F3D0
        public void .ctor(){} // RVA: 0x6F8F460
    }

    public class SteamVR_SphericalProjection : MonoBehaviour
    {
        public object material;

        // ── Methods ──
        public void Set(){} // RVA: 0x6F8F4C0
        public void OnRenderImage(){} // RVA: 0x6F8FAF0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SteamVR_TrackedObject : MonoBehaviour
    {
        public object index;
        public object origin;
        public object _isValid;
        public object newPosesAction;

        // ── Methods ──
        public void get_isValid(){} // RVA: 0xB68DF0
        public void set_isValid(){} // RVA: 0xB68E00
        public void OnNewPoses(){} // RVA: 0x6F91040
        public void .ctor(){} // RVA: 0x6F916E0
        public void Awake(){} // RVA: 0x6F91800
        public void OnEnable(){} // RVA: 0x6F91800
        public void OnDisable(){} // RVA: 0x6F91950
        public void SetDeviceIndex(){} // RVA: 0x6F91990
    }

    public class SteamVR_TrackingReferenceManager : MonoBehaviour
    {
        public object trackingReferences;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6F91AE0
        public void OnDisable(){} // RVA: 0x6F91BC0
        public void OnNewPoses(){} // RVA: 0x6F91CD0
        public void .ctor(){} // RVA: 0x6F92050
    }

}