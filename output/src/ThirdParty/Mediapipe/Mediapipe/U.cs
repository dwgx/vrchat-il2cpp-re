// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 1
// Methods: 83

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class UnsafeNativeMethods
    {
        // ── Methods ──
        public void absl_Status__delete(){} // RVA: 0x5ADD120
        public void absl_Status__ToString(){} // RVA: 0x5ADD1A0
        public void google_InitGoogleLogging__PKc(){} // RVA: 0x5ADD230
        public void google_ShutdownGoogleLogging(){} // RVA: 0x5ADD2E0
        public void glog_FLAGS_logtostderr(){} // RVA: 0x5ADD350
        public void glog_FLAGS_stderrthreshold(){} // RVA: 0x5ADD3D0
        public void glog_FLAGS_minloglevel(){} // RVA: 0x5ADD450
        public void glog_FLAGS_v(){} // RVA: 0x5ADD4D0
        public void google_protobuf__SetLogHandler__PF(){} // RVA: 0x5ADD550
        public void google_protobuf__ResetLogHandler(){} // RVA: 0x5ADD5E0
        public void mp_api_SerializedProtoArray__delete(){} // RVA: 0x5ADD650
        public void delete_array__PKc(){} // RVA: 0x5ADD6E0
        public void std_string__delete(){} // RVA: 0x5ADD760
        public void std_string__PKc_i(){} // RVA: 0x5ADD7E0
        public void std_string__swap__Rstr(){} // RVA: 0x5ADD880
        public void mp_CalculatorGraph__(){} // RVA: 0x5ADD910
        public void mp_CalculatorGraph__delete(){} // RVA: 0x5ADD990
        public void mp_CalculatorGraph__Initialize__PKc_i(){} // RVA: 0x5ADDA10
        public void mp_CalculatorGraph__ObserveOutputStream__PKc_PF_b(){} // RVA: 0x5ADDAD0
        public void mp_CalculatorGraph__AddOutputStreamPoller__PKc_b(){} // RVA: 0x5ADDBC0
        public void mp_CalculatorGraph__StartRun__Rsp(){} // RVA: 0x5ADDCA0
        public void mp_CalculatorGraph__WaitUntilDone(){} // RVA: 0x5ADDD40
        public void mp_CalculatorGraph__AddPacketToInputStream__PKc_Ppacket(){} // RVA: 0x5ADDDD0
        public void mp_CalculatorGraph__CloseAllPacketSources(){} // RVA: 0x5ADDEA0
        public void mp_CalculatorGraph__SetGpuResources__SPgpu(){} // RVA: 0x5ADDF30
        public void mp_api__ConvertFromCalculatorGraphConfigTextFormat(){} // RVA: 0x5ADDFD0
        public void mp_ImageFrame__ui_i_i_i_Pui8_PF(){} // RVA: 0x5ADE080
        public void mp_ImageFrame__delete(){} // RVA: 0x5ADE140
        public void mp__MakeImageFramePacket_At__Pif_ll(){} // RVA: 0x5ADE1C0
        public void mp_Packet__GetImageFrame(){} // RVA: 0x5ADE260
        public void mp_Image__ui_i_i_i_Pui8_PF(){} // RVA: 0x5ADE2F0
        public void mp_Image__delete(){} // RVA: 0x5ADE3B0
        public void mp_PixelWriteLock__RI(){} // RVA: 0x5ADE430
        public void mp_PixelWriteLock__delete(){} // RVA: 0x5ADE4C0
        public void mp__MakeImagePacket__PI(){} // RVA: 0x5ADE540
        public void mp__MakeImagePacket_At__PI_ll(){} // RVA: 0x5ADE5D0
        public void mp_Packet__GetImage(){} // RVA: 0x5ADE670
        public void mp_Packet__GetImageVector(){} // RVA: 0x5ADE700
        public void mp_OutputStreamPoller__delete(){} // RVA: 0x5ADE790
        public void mp_OutputStreamPoller__Next_Ppacket(){} // RVA: 0x5ADE810
        public void mp_Packet__(){} // RVA: 0x5ADE8C0
        public void mp_Packet__delete(){} // RVA: 0x5ADE940
        public void mp__MakeBoolPacket__b(){} // RVA: 0x5ADE9C0
        public void mp__MakeIntPacket__i(){} // RVA: 0x5ADEA50
        public void mp__PacketFromDynamicProto__PKc_PKc_i(){} // RVA: 0x5ADEAE0
        public void mp__PacketFromDynamicProto_At__PKc_PKc_i_ll(){} // RVA: 0x5ADEBC0
        public void mp_Packet__GetProtoMessageLite(){} // RVA: 0x5ADECB0
        public void mp_Packet__GetVectorOfProtoMessageLite(){} // RVA: 0x5ADED40
        public void mp_PacketMap__(){} // RVA: 0x5ADEDD0
        public void mp_PacketMap__delete(){} // RVA: 0x5ADEE50
        public void mp_PacketMap__emplace__PKc_Rp(){} // RVA: 0x5ADEED0
        public void mp_PacketMap__find__PKc(){} // RVA: 0x5ADEF90
        public void mp_ValidatedGraphConfig__(){} // RVA: 0x5ADF050
        public void mp_ValidatedGraphConfig__delete(){} // RVA: 0x5ADF0D0
        public void mp_ValidatedGraphConfig__Initialize__Rcgc(){} // RVA: 0x5ADF150
        public void mp_ValidatedGraphConfig__Config(){} // RVA: 0x5ADF210
        public void mp_GlCalculatorHelper__(){} // RVA: 0x5ADF2A0
        public void mp_GlCalculatorHelper__delete(){} // RVA: 0x5ADF320
        public void mp_GlCalculatorHelper__InitializeForTest__Pgr(){} // RVA: 0x5ADF3A0
        public void mp_SharedGlContext__delete(){} // RVA: 0x5ADF430
        public void mp_GlSyncToken__delete(){} // RVA: 0x5ADF4B0
        public void mp_GlSyncPoint__Wait(){} // RVA: 0x5ADF530
        public void mp_GpuBuffer__delete(){} // RVA: 0x5ADF5B0
        public void mp__MakeGpuBufferPacket__Rgb(){} // RVA: 0x5ADF630
        public void mp__MakeGpuBufferPacket_At__Rgb_ll(){} // RVA: 0x5ADF6C0
        public void mp_SharedGpuResources__delete(){} // RVA: 0x5ADF760
        public void mp_GpuResources_Create__Pv(){} // RVA: 0x5ADF7E0
        public void mp_Packet__GetClassificationsVector(){} // RVA: 0x5ADF880
        public void mp_tasks_c_components_containers_CppCloseClassificationResult(){} // RVA: 0x5ADF960
        public void mp_Packet__GetDetectionResult(){} // RVA: 0x5ADFA20
        public void mp_tasks_c_components_containers_CppCloseDetectionResult(){} // RVA: 0x5ADFAB0
        public void mp_Packet__GetLandmarksVector(){} // RVA: 0x5ADFB40
        public void mp_api_LandmarksArray__delete(){} // RVA: 0x5ADFBD0
        public void mp_Packet__GetNormalizedLandmarksVector(){} // RVA: 0x5ADFC60
        public void mp_api_NormalizedLandmarksArray__delete(){} // RVA: 0x5ADFCF0
        public void mp_tasks_core_TaskRunner_Create__PKc_i_PF(){} // RVA: 0x5ADFD80
        public void mp_tasks_core_TaskRunner__delete(){} // RVA: 0x5ADFE40
        public void mp_tasks_core_TaskRunner__Process__Ppm(){} // RVA: 0x5ADFEC0
        public void mp_tasks_core_TaskRunner__Send__Ppm(){} // RVA: 0x5ADFF70
        public void mp_tasks_core_TaskRunner__Close(){} // RVA: 0x5AE0010
        public void .cctor(){} // RVA: 0x5AE00A0
        public void FreeHGlobal(){} // RVA: 0x5AE0230
        public void mp_api__SetFreeHGlobal(){} // RVA: 0x5AE0280
    }

}