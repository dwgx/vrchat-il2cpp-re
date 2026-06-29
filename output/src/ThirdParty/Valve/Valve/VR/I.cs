// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 17
// Methods: 161

namespace ThirdParty.Valve.Valve.VR
{
    public class ISteamVR_Action
    {
        // ── Methods ──
        public void GetActive(){} // RVA: 0x87DD20
        public void GetShortName(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_ActionSet
    {
        // ── Methods ──
        public void get_allActions(){} // RVA: 0x87C0A0
        public void get_nonVisualInActions(){} // RVA: 0x87C0A0
        public void get_visualActions(){} // RVA: 0x87C0A0
        public void get_poseActions(){} // RVA: 0x87C0A0
        public void get_skeletonActions(){} // RVA: 0x87C0A0
        public void get_outActionArray(){} // RVA: 0x87C0A0
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_usage(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void ReadRawSetActive(){} // RVA: 0x87DD20
        public void ReadRawSetLastChanged(){} // RVA: 0x891330
        public void ReadRawSetPriority(){} // RVA: 0x881C20
        public void IsActive(){} // RVA: 0x87DD20
        public void GetTimeLastChanged(){} // RVA: 0x891330
        public void Activate(){} // RVA: 0x896840
        public void Deactivate(){} // RVA: 0x8944F0
        public void GetShortName(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_Action_Boolean
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x87D280
        public void get_stateDown(){} // RVA: 0x87D280
        public void get_stateUp(){} // RVA: 0x87D280
        public void get_lastState(){} // RVA: 0x87D280
        public void get_lastStateDown(){} // RVA: 0x87D280
        public void get_lastStateUp(){} // RVA: 0x87D280
    }

    public class ISteamVR_Action_In
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x894290
        public void GetRenderModelComponentName(){} // RVA: 0x87C160
        public void GetActiveDevice(){} // RVA: 0x881C20
        public void GetDeviceIndex(){} // RVA: 0x881C20
        public void GetChanged(){} // RVA: 0x87DD20
        public void GetLocalizedOriginPart(){} // RVA: 0x88B510
        public void GetLocalizedOrigin(){} // RVA: 0x87C160
    }

    public class ISteamVR_Action_In[] : Array
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

    public class ISteamVR_Action_In_Source
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
    }

    public class ISteamVR_Action_Out[] : Array
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

    public class ISteamVR_Action_Pose
    {
        // ── Methods ──
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
    }

    public class ISteamVR_Action_Single
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x890F90
        public void get_lastAxis(){} // RVA: 0x890F90
        public void get_delta(){} // RVA: 0x890F90
        public void get_lastDelta(){} // RVA: 0x890F90
    }

    public class ISteamVR_Action_Skeleton_Source
    {
        // ── Methods ──
        public void get_skeletalTrackingLevel(){} // RVA: 0x87C130
        public void get_bonePositions(){} // RVA: 0x87C0A0
        public void get_boneRotations(){} // RVA: 0x87C0A0
        public void get_lastBonePositions(){} // RVA: 0x87C0A0
        public void get_lastBoneRotations(){} // RVA: 0x87C0A0
        public void get_rangeOfMotion(){} // RVA: 0x87C130
        public void set_rangeOfMotion(){} // RVA: 0x8944F0
        public void get_skeletalTransformSpace(){} // RVA: 0x87C130
        public void set_skeletalTransformSpace(){} // RVA: 0x8944F0
        public void get_onlyUpdateSummaryData(){} // RVA: 0x87D280
        public void set_onlyUpdateSummaryData(){} // RVA: 0x894750
        public void get_thumbCurl(){} // RVA: 0x890F90
        public void get_indexCurl(){} // RVA: 0x890F90
        public void get_middleCurl(){} // RVA: 0x890F90
        public void get_ringCurl(){} // RVA: 0x890F90
        public void get_pinkyCurl(){} // RVA: 0x890F90
        public void get_thumbIndexSplay(){} // RVA: 0x890F90
        public void get_indexMiddleSplay(){} // RVA: 0x890F90
        public void get_middleRingSplay(){} // RVA: 0x890F90
        public void get_ringPinkySplay(){} // RVA: 0x890F90
        public void get_lastThumbCurl(){} // RVA: 0x890F90
        public void get_lastIndexCurl(){} // RVA: 0x890F90
        public void get_lastMiddleCurl(){} // RVA: 0x890F90
        public void get_lastRingCurl(){} // RVA: 0x890F90
        public void get_lastPinkyCurl(){} // RVA: 0x890F90
        public void get_lastThumbIndexSplay(){} // RVA: 0x890F90
        public void get_lastIndexMiddleSplay(){} // RVA: 0x890F90
        public void get_lastMiddleRingSplay(){} // RVA: 0x890F90
        public void get_lastRingPinkySplay(){} // RVA: 0x890F90
        public void get_fingerCurls(){} // RVA: 0x87C0A0
        public void get_fingerSplays(){} // RVA: 0x87C0A0
        public void get_lastFingerCurls(){} // RVA: 0x87C0A0
        public void get_lastFingerSplays(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_Action_Source
    {
        // ── Methods ──
        public void get_active(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void get_actionSet(){} // RVA: 0x87C0A0
        public void get_direction(){} // RVA: 0x87C130
    }

    public class ISteamVR_Action_Vector2
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x87C0A0
        public void get_lastAxis(){} // RVA: 0x87C0A0
        public void get_delta(){} // RVA: 0x87C0A0
        public void get_lastDelta(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_Action_Vector3
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x87BEB0
        public void get_lastAxis(){} // RVA: 0x87BEB0
        public void get_delta(){} // RVA: 0x87BEB0
        public void get_lastDelta(){} // RVA: 0x87BEB0
    }

    public class ISteamVR_Action_Vibration
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0xA94080
    }

    public class InputBindingInfo_t : ValueType
    {
        public object rchDevicePathName0;
        public object rchDevicePathName1;
        public object rchDevicePathName2;
        public object rchDevicePathName3;
        public object rchDevicePathName4;
        public object rchDevicePathName5;
        public object rchDevicePathName6;
        public object rchDevicePathName7;
        public object rchDevicePathName8;
        public object rchDevicePathName9;
        public object rchDevicePathName10;
        public object rchDevicePathName11;
        public object rchDevicePathName12;
        public object rchDevicePathName13;
        public object rchDevicePathName14;
        public object rchDevicePathName15;
        public object rchDevicePathName16;
        public object rchDevicePathName17;
        public object rchDevicePathName18;
        public object rchDevicePathName19;
        public object rchDevicePathName20;
        public object rchDevicePathName21;
        public object rchDevicePathName22;
        public object rchDevicePathName23;
        public object rchDevicePathName24;
        public object rchDevicePathName25;
        public object rchDevicePathName26;
        public object rchDevicePathName27;
        public object rchDevicePathName28;
        public object rchDevicePathName29;
        public object rchDevicePathName30;
        public object rchDevicePathName31;
        public object rchDevicePathName32;
        public object rchDevicePathName33;
        public object rchDevicePathName34;
        public object rchDevicePathName35;
        public object rchDevicePathName36;
        public object rchDevicePathName37;
        public object rchDevicePathName38;
        public object rchDevicePathName39;
        public object rchDevicePathName40;
        public object rchDevicePathName41;
        public object rchDevicePathName42;
        public object rchDevicePathName43;
        public object rchDevicePathName44;
        public object rchDevicePathName45;
        public object rchDevicePathName46;
        public object rchDevicePathName47;
        public object rchDevicePathName48;
        public object rchDevicePathName49;
        public object rchDevicePathName50;
        public object rchDevicePathName51;
        public object rchDevicePathName52;
        public object rchDevicePathName53;
        public object rchDevicePathName54;
        public object rchDevicePathName55;
        public object rchDevicePathName56;
        public object rchDevicePathName57;
        public object rchDevicePathName58;
        public object rchDevicePathName59;
        public object rchDevicePathName60;
        public object rchDevicePathName61;
        public object rchDevicePathName62;
        public object rchDevicePathName63;
        public object rchDevicePathName64;
        public object rchDevicePathName65;
        public object rchDevicePathName66;
        public object rchDevicePathName67;
        public object rchDevicePathName68;
        public object rchDevicePathName69;
        public object rchDevicePathName70;
        public object rchDevicePathName71;
        public object rchDevicePathName72;
        public object rchDevicePathName73;
        public object rchDevicePathName74;
        public object rchDevicePathName75;
        public object rchDevicePathName76;
        public object rchDevicePathName77;
        public object rchDevicePathName78;
        public object rchDevicePathName79;
        public object rchDevicePathName80;
        public object rchDevicePathName81;
        public object rchDevicePathName82;
        public object rchDevicePathName83;
        public object rchDevicePathName84;
        public object rchDevicePathName85;
        public object rchDevicePathName86;
        public object rchDevicePathName87;
        public object rchDevicePathName88;
        public object rchDevicePathName89;
        public object rchDevicePathName90;
        public object rchDevicePathName91;
        public object rchDevicePathName92;
        public object rchDevicePathName93;
        public object rchDevicePathName94;
        public object rchDevicePathName95;
        public object rchDevicePathName96;
        public object rchDevicePathName97;
        public object rchDevicePathName98;
        public object rchDevicePathName99;
        public object rchDevicePathName100;
        public object rchDevicePathName101;
        public object rchDevicePathName102;
        public object rchDevicePathName103;
        public object rchDevicePathName104;
        public object rchDevicePathName105;
        public object rchDevicePathName106;
        public object rchDevicePathName107;
        public object rchDevicePathName108;
        public object rchDevicePathName109;
        public object rchDevicePathName110;
        public object rchDevicePathName111;
        public object rchDevicePathName112;
        public object rchDevicePathName113;
        public object rchDevicePathName114;
        public object rchDevicePathName115;
        public object rchDevicePathName116;
        public object rchDevicePathName117;
        public object rchDevicePathName118;
        public object rchDevicePathName119;
        public object rchDevicePathName120;
        public object rchDevicePathName121;
        public object rchDevicePathName122;
        public object rchDevicePathName123;
        public object rchDevicePathName124;
        public object rchDevicePathName125;
        public object rchDevicePathName126;
        public object rchDevicePathName127;
        public object rchInputPathName0;
        public object rchInputPathName1;
        public object rchInputPathName2;
        public object rchInputPathName3;
        public object rchInputPathName4;
        public object rchInputPathName5;
        public object rchInputPathName6;
        public object rchInputPathName7;
        public object rchInputPathName8;
        public object rchInputPathName9;
        public object rchInputPathName10;
        public object rchInputPathName11;
        public object rchInputPathName12;
        public object rchInputPathName13;
        public object rchInputPathName14;
        public object rchInputPathName15;
        public object rchInputPathName16;
        public object rchInputPathName17;
        public object rchInputPathName18;
        public object rchInputPathName19;
        public object rchInputPathName20;
        public object rchInputPathName21;
        public object rchInputPathName22;
        public object rchInputPathName23;
        public object rchInputPathName24;
        public object rchInputPathName25;
        public object rchInputPathName26;
        public object rchInputPathName27;
        public object rchInputPathName28;
        public object rchInputPathName29;
        public object rchInputPathName30;
        public object rchInputPathName31;
        public object rchInputPathName32;
        public object rchInputPathName33;
        public object rchInputPathName34;
        public object rchInputPathName35;
        public object rchInputPathName36;
        public object rchInputPathName37;
        public object rchInputPathName38;
        public object rchInputPathName39;
        public object rchInputPathName40;
        public object rchInputPathName41;
        public object rchInputPathName42;
        public object rchInputPathName43;
        public object rchInputPathName44;
        public object rchInputPathName45;
        public object rchInputPathName46;
        public object rchInputPathName47;
        public object rchInputPathName48;
        public object rchInputPathName49;
        public object rchInputPathName50;
        public object rchInputPathName51;
        public object rchInputPathName52;
        public object rchInputPathName53;
        public object rchInputPathName54;
        public object rchInputPathName55;
        public object rchInputPathName56;
        public object rchInputPathName57;
        public object rchInputPathName58;
        public object rchInputPathName59;
        public object rchInputPathName60;
        public object rchInputPathName61;
        public object rchInputPathName62;
        public object rchInputPathName63;
        public object rchInputPathName64;
        public object rchInputPathName65;
        public object rchInputPathName66;
        public object rchInputPathName67;
        public object rchInputPathName68;
        public object rchInputPathName69;
        public object rchInputPathName70;
        public object rchInputPathName71;
        public object rchInputPathName72;
        public object rchInputPathName73;
        public object rchInputPathName74;
        public object rchInputPathName75;
        public object rchInputPathName76;
        public object rchInputPathName77;
        public object rchInputPathName78;
        public object rchInputPathName79;
        public object rchInputPathName80;
        public object rchInputPathName81;
        public object rchInputPathName82;
        public object rchInputPathName83;
        public object rchInputPathName84;
        public object rchInputPathName85;
        public object rchInputPathName86;
        public object rchInputPathName87;
        public object rchInputPathName88;
        public object rchInputPathName89;
        public object rchInputPathName90;
        public object rchInputPathName91;
        public object rchInputPathName92;
        public object rchInputPathName93;
        public object rchInputPathName94;
        public object rchInputPathName95;
        public object rchInputPathName96;
        public object rchInputPathName97;
        public object rchInputPathName98;
        public object rchInputPathName99;
        public object rchInputPathName100;
        public object rchInputPathName101;
        public object rchInputPathName102;
        public object rchInputPathName103;
        public object rchInputPathName104;
        public object rchInputPathName105;
        public object rchInputPathName106;
        public object rchInputPathName107;
        public object rchInputPathName108;
        public object rchInputPathName109;
        public object rchInputPathName110;
        public object rchInputPathName111;
        public object rchInputPathName112;
        public object rchInputPathName113;
        public object rchInputPathName114;
        public object rchInputPathName115;
        public object rchInputPathName116;
        public object rchInputPathName117;
        public object rchInputPathName118;
        public object rchInputPathName119;
        public object rchInputPathName120;
        public object rchInputPathName121;
        public object rchInputPathName122;
        public object rchInputPathName123;
        public object rchInputPathName124;
        public object rchInputPathName125;
        public object rchInputPathName126;
        public object rchInputPathName127;

        // ── Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x9574C0
        public void get_rchInputPathName(){} // RVA: 0x9574D0
        public void get_rchModeName(){} // RVA: 0x9574E0
        public void get_rchSlotName(){} // RVA: 0x9574F0
        public void get_rchInputSourceType(){} // RVA: 0x957500
    }

    public class InputBindingInfo_t[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB1120
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7BD70
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC6A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6C840
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7BD70
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class InputOriginInfo_t : ValueType
    {
        public object devicePath;
        public object trackedDeviceIndex;
        public object rchRenderModelComponentName0;
        public object rchRenderModelComponentName1;
        public object rchRenderModelComponentName2;
        public object rchRenderModelComponentName3;
        public object rchRenderModelComponentName4;
        public object rchRenderModelComponentName5;
        public object rchRenderModelComponentName6;
        public object rchRenderModelComponentName7;
        public object rchRenderModelComponentName8;
        public object rchRenderModelComponentName9;
        public object rchRenderModelComponentName10;
        public object rchRenderModelComponentName11;
        public object rchRenderModelComponentName12;
        public object rchRenderModelComponentName13;
        public object rchRenderModelComponentName14;
        public object rchRenderModelComponentName15;
        public object rchRenderModelComponentName16;
        public object rchRenderModelComponentName17;
        public object rchRenderModelComponentName18;
        public object rchRenderModelComponentName19;
        public object rchRenderModelComponentName20;
        public object rchRenderModelComponentName21;
        public object rchRenderModelComponentName22;
        public object rchRenderModelComponentName23;
        public object rchRenderModelComponentName24;
        public object rchRenderModelComponentName25;
        public object rchRenderModelComponentName26;
        public object rchRenderModelComponentName27;
        public object rchRenderModelComponentName28;
        public object rchRenderModelComponentName29;
        public object rchRenderModelComponentName30;
        public object rchRenderModelComponentName31;
        public object rchRenderModelComponentName32;
        public object rchRenderModelComponentName33;
        public object rchRenderModelComponentName34;
        public object rchRenderModelComponentName35;
        public object rchRenderModelComponentName36;
        public object rchRenderModelComponentName37;
        public object rchRenderModelComponentName38;
        public object rchRenderModelComponentName39;
        public object rchRenderModelComponentName40;
        public object rchRenderModelComponentName41;
        public object rchRenderModelComponentName42;
        public object rchRenderModelComponentName43;
        public object rchRenderModelComponentName44;
        public object rchRenderModelComponentName45;
        public object rchRenderModelComponentName46;
        public object rchRenderModelComponentName47;
        public object rchRenderModelComponentName48;
        public object rchRenderModelComponentName49;
        public object rchRenderModelComponentName50;
        public object rchRenderModelComponentName51;
        public object rchRenderModelComponentName52;
        public object rchRenderModelComponentName53;
        public object rchRenderModelComponentName54;
        public object rchRenderModelComponentName55;
        public object rchRenderModelComponentName56;
        public object rchRenderModelComponentName57;
        public object rchRenderModelComponentName58;
        public object rchRenderModelComponentName59;
        public object rchRenderModelComponentName60;
        public object rchRenderModelComponentName61;
        public object rchRenderModelComponentName62;
        public object rchRenderModelComponentName63;
        public object rchRenderModelComponentName64;
        public object rchRenderModelComponentName65;
        public object rchRenderModelComponentName66;
        public object rchRenderModelComponentName67;
        public object rchRenderModelComponentName68;
        public object rchRenderModelComponentName69;
        public object rchRenderModelComponentName70;
        public object rchRenderModelComponentName71;
        public object rchRenderModelComponentName72;
        public object rchRenderModelComponentName73;
        public object rchRenderModelComponentName74;
        public object rchRenderModelComponentName75;
        public object rchRenderModelComponentName76;
        public object rchRenderModelComponentName77;
        public object rchRenderModelComponentName78;
        public object rchRenderModelComponentName79;
        public object rchRenderModelComponentName80;
        public object rchRenderModelComponentName81;
        public object rchRenderModelComponentName82;
        public object rchRenderModelComponentName83;
        public object rchRenderModelComponentName84;
        public object rchRenderModelComponentName85;
        public object rchRenderModelComponentName86;
        public object rchRenderModelComponentName87;
        public object rchRenderModelComponentName88;
        public object rchRenderModelComponentName89;
        public object rchRenderModelComponentName90;
        public object rchRenderModelComponentName91;
        public object rchRenderModelComponentName92;
        public object rchRenderModelComponentName93;
        public object rchRenderModelComponentName94;
        public object rchRenderModelComponentName95;
        public object rchRenderModelComponentName96;
        public object rchRenderModelComponentName97;
        public object rchRenderModelComponentName98;
        public object rchRenderModelComponentName99;
        public object rchRenderModelComponentName100;
        public object rchRenderModelComponentName101;
        public object rchRenderModelComponentName102;
        public object rchRenderModelComponentName103;
        public object rchRenderModelComponentName104;
        public object rchRenderModelComponentName105;
        public object rchRenderModelComponentName106;
        public object rchRenderModelComponentName107;
        public object rchRenderModelComponentName108;
        public object rchRenderModelComponentName109;
        public object rchRenderModelComponentName110;
        public object rchRenderModelComponentName111;
        public object rchRenderModelComponentName112;
        public object rchRenderModelComponentName113;
        public object rchRenderModelComponentName114;
        public object rchRenderModelComponentName115;
        public object rchRenderModelComponentName116;
        public object rchRenderModelComponentName117;
        public object rchRenderModelComponentName118;
        public object rchRenderModelComponentName119;
        public object rchRenderModelComponentName120;
        public object rchRenderModelComponentName121;
        public object rchRenderModelComponentName122;
        public object rchRenderModelComponentName123;
        public object rchRenderModelComponentName124;
        public object rchRenderModelComponentName125;
        public object rchRenderModelComponentName126;
        public object rchRenderModelComponentName127;

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x9574B0
    }

}