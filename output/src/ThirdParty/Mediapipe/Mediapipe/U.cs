// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 1
// Methods: 84

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class UnsafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__delete(){} // RVA: 0x6557A90
        public void absl_Status__ToString(){} // RVA: 0x6557B10
        public void google_InitGoogleLogging__PKc(){} // RVA: 0x6557BA0
        public void google_ShutdownGoogleLogging(){} // RVA: 0x6557C50
        public void glog_FLAGS_logtostderr(){} // RVA: 0x6557CC0
        public void glog_FLAGS_stderrthreshold(){} // RVA: 0x6557D40
        public void glog_FLAGS_minloglevel(){} // RVA: 0x6557DC0
        public void glog_FLAGS_v(){} // RVA: 0x6557E40
        public void google_protobuf__SetLogHandler__PF(){} // RVA: 0x6557EC0
        public void google_protobuf__ResetLogHandler(){} // RVA: 0x6557F50
        public void mp_api_SerializedProtoArray__delete(){} // RVA: 0x6557FC0
        public void delete_array__PKc(){} // RVA: 0x6558050
        public void std_string__delete(){} // RVA: 0x65580D0
        public void std_string__PKc_i(){} // RVA: 0x6558150
        public void std_string__swap__Rstr(){} // RVA: 0x65581F0
        public void mp_CalculatorGraph__(){} // RVA: 0x6558280
        public void mp_CalculatorGraph__delete(){} // RVA: 0x6558300
        public void mp_CalculatorGraph__Initialize__PKc_i(){} // RVA: 0x6558380
        public void mp_CalculatorGraph__ObserveOutputStream__PKc_PF_b(){} // RVA: 0x6558440
        public void mp_CalculatorGraph__AddOutputStreamPoller__PKc_b(){} // RVA: 0x6558530
        public void mp_CalculatorGraph__StartRun__Rsp(){} // RVA: 0x6558610
        public void mp_CalculatorGraph__WaitUntilDone(){} // RVA: 0x65586B0
        public void mp_CalculatorGraph__AddPacketToInputStream__PKc_Ppacket(){} // RVA: 0x6558740
        public void mp_CalculatorGraph__CloseAllPacketSources(){} // RVA: 0x6558810
        public void mp_CalculatorGraph__SetGpuResources__SPgpu(){} // RVA: 0x65588A0
        public void mp_api__ConvertFromCalculatorGraphConfigTextFormat(){} // RVA: 0x6558940
        public void mp_ImageFrame__(){} // RVA: 0x65589F0
        public void mp_ImageFrame__ui_i_i_i_Pui8_PF(){} // RVA: 0x6558A70
        public void mp_ImageFrame__delete(){} // RVA: 0x6558B30
        public void mp__MakeImageFramePacket_At__Pif_ll(){} // RVA: 0x6558BB0
        public void mp_Packet__GetImageFrame(){} // RVA: 0x6558C50
        public void mp_Image__ui_i_i_i_Pui8_PF(){} // RVA: 0x6558CE0
        public void mp_Image__delete(){} // RVA: 0x6558DA0
        public void mp_PixelWriteLock__RI(){} // RVA: 0x6558E20
        public void mp_PixelWriteLock__delete(){} // RVA: 0x6558EB0
        public void mp__MakeImagePacket__PI(){} // RVA: 0x6558F30
        public void mp__MakeImagePacket_At__PI_ll(){} // RVA: 0x6558FC0
        public void mp_Packet__GetImage(){} // RVA: 0x6559060
        public void mp_Packet__GetImageVector(){} // RVA: 0x65590F0
        public void mp_OutputStreamPoller__delete(){} // RVA: 0x6559180
        public void mp_OutputStreamPoller__Next_Ppacket(){} // RVA: 0x6559200
        public void mp_Packet__(){} // RVA: 0x65592B0
        public void mp_Packet__delete(){} // RVA: 0x6559330
        public void mp__MakeBoolPacket__b(){} // RVA: 0x65593B0
        public void mp__MakeIntPacket__i(){} // RVA: 0x6559440
        public void mp__PacketFromDynamicProto__PKc_PKc_i(){} // RVA: 0x65594D0
        public void mp__PacketFromDynamicProto_At__PKc_PKc_i_ll(){} // RVA: 0x65595B0
        public void mp_Packet__GetProtoMessageLite(){} // RVA: 0x65596A0
        public void mp_Packet__GetVectorOfProtoMessageLite(){} // RVA: 0x6559730
        public void mp_PacketMap__(){} // RVA: 0x65597C0
        public void mp_PacketMap__delete(){} // RVA: 0x6559840
        public void mp_PacketMap__emplace__PKc_Rp(){} // RVA: 0x65598C0
        public void mp_PacketMap__find__PKc(){} // RVA: 0x6559980
        public void mp_ValidatedGraphConfig__(){} // RVA: 0x6559A40
        public void mp_ValidatedGraphConfig__delete(){} // RVA: 0x6559AC0
        public void mp_ValidatedGraphConfig__Initialize__Rcgc(){} // RVA: 0x6559B40
        public void mp_ValidatedGraphConfig__Config(){} // RVA: 0x6559C00
        public void mp_GlCalculatorHelper__(){} // RVA: 0x6559C90
        public void mp_GlCalculatorHelper__delete(){} // RVA: 0x6559D10
        public void mp_GlCalculatorHelper__InitializeForTest__Pgr(){} // RVA: 0x6559D90
        public void mp_SharedGlContext__delete(){} // RVA: 0x6559E20
        public void mp_GlSyncToken__delete(){} // RVA: 0x6559EA0
        public void mp_GlSyncPoint__Wait(){} // RVA: 0x6559F20
        public void mp_GpuBuffer__delete(){} // RVA: 0x6559FA0
        public void mp__MakeGpuBufferPacket__Rgb(){} // RVA: 0x655A020
        public void mp__MakeGpuBufferPacket_At__Rgb_ll(){} // RVA: 0x655A0B0
        public void mp_SharedGpuResources__delete(){} // RVA: 0x655A150
        public void mp_GpuResources_Create__Pv(){} // RVA: 0x655A1D0
        public void mp_Packet__GetClassificationsVector(){} // RVA: 0x655A270
        public void mp_tasks_c_components_containers_CppCloseClassificationResult(){} // RVA: 0x655A350
        public void mp_Packet__GetDetectionResult(){} // RVA: 0x655A410
        public void mp_tasks_c_components_containers_CppCloseDetectionResult(){} // RVA: 0x655A4A0
        public void mp_Packet__GetLandmarksVector(){} // RVA: 0x655A530
        public void mp_api_LandmarksArray__delete(){} // RVA: 0x655A5C0
        public void mp_Packet__GetNormalizedLandmarksVector(){} // RVA: 0x655A650
        public void mp_api_NormalizedLandmarksArray__delete(){} // RVA: 0x655A6E0
        public void mp_tasks_core_TaskRunner_Create__PKc_i_PF(){} // RVA: 0x655A770
        public void mp_tasks_core_TaskRunner__delete(){} // RVA: 0x655A830
        public void mp_tasks_core_TaskRunner__Process__Ppm(){} // RVA: 0x655A8B0
        public void mp_tasks_core_TaskRunner__Send__Ppm(){} // RVA: 0x655A960
        public void mp_tasks_core_TaskRunner__Close(){} // RVA: 0x655AA00
        public void .cctor(){} // RVA: 0x655AA90
        public void FreeHGlobal(){} // RVA: 0x655AC10
        public void mp_api__SetFreeHGlobal(){} // RVA: 0x655AC60
    }

}