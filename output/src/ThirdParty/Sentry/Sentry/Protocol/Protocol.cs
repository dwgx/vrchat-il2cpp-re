// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol
// Classes: 16
// Methods: 343

namespace ThirdParty.Sentry.Sentry.Protocol
{
    public class App
    {
        // ── Methods ──
        public void get_Identifier(){} // RVA: 0x2F8380
        public void set_Identifier(){} // RVA: 0x2DEE30
        public void get_StartTime(){} // RVA: 0x1F4D690
        public void set_StartTime(){} // RVA: 0x1F8D020
        public void get_Hash(){} // RVA: 0x6374D0
        public void set_Hash(){} // RVA: 0x30B890
        public void get_BuildType(){} // RVA: 0x4976A0
        public void set_BuildType(){} // RVA: 0x49B830
        public void get_Name(){} // RVA: 0x35A740
        public void set_Name(){} // RVA: 0x305200
        public void get_Version(){} // RVA: 0x358730
        public void set_Version(){} // RVA: 0x358740
        public void get_Build(){} // RVA: 0x37E0E0
        public void set_Build(){} // RVA: 0x4354D0
        public void get_InForeground(){} // RVA: 0x63CCCB0
        public void set_InForeground(){} // RVA: 0x63CCCC0
        public void Clone(){} // RVA: 0x63CCCD0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.App>.Clone(){} // RVA: 0x63CCD80
        public void UpdateFrom(){} // RVA: 0x63CD000
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63CD050
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.App>.UpdateFrom(){} // RVA: 0x63CD0C0
        public void WriteTo(){} // RVA: 0x63CD390
        public void FromJson(){} // RVA: 0x63CD6C0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Browser
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Version(){} // RVA: 0x2E07C0
        public void set_Version(){} // RVA: 0x343E80
        public void Clone(){} // RVA: 0x63CE050
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Browser>.Clone(){} // RVA: 0x63CE100
        public void UpdateFrom(){} // RVA: 0x63CE200
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63CE250
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Browser>.UpdateFrom(){} // RVA: 0x63CE2C0
        public void WriteTo(){} // RVA: 0x63CE3B0
        public void FromJson(){} // RVA: 0x63CE500
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DebugImage
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x2F8380
        public void set_Type(){} // RVA: 0x2DEE30
        public void get_ImageAddress(){} // RVA: 0x994EE0
        public void set_ImageAddress(){} // RVA: 0x9949A0
        public void get_ImageSize(){} // RVA: 0x111F520
        public void set_ImageSize(){} // RVA: 0x111C380
        public void get_DebugId(){} // RVA: 0x4976A0
        public void set_DebugId(){} // RVA: 0x49B830
        public void get_DebugChecksum(){} // RVA: 0x35A740
        public void set_DebugChecksum(){} // RVA: 0x305200
        public void get_DebugFile(){} // RVA: 0x358730
        public void set_DebugFile(){} // RVA: 0x358740
        public void get_CodeId(){} // RVA: 0x37E0E0
        public void set_CodeId(){} // RVA: 0x4354D0
        public void get_CodeFile(){} // RVA: 0x3A5500
        public void set_CodeFile(){} // RVA: 0x3A5510
        public void get_ModuleVersionId(){} // RVA: 0x63CE7C0
        public void set_ModuleVersionId(){} // RVA: 0x63CE7E0
        public void WriteTo(){} // RVA: 0x63CE7F0
        public void FromJson(){} // RVA: 0x63CEC80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DebugMeta
    {
        // ── Methods ──
        public void get_Images(){} // RVA: 0x2F8380
        public void set_Images(){} // RVA: 0x2DEE30
        public void WriteTo(){} // RVA: 0x63CF5B0
        public void FromJson(){} // RVA: 0x63CF690
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Device
    {
        // ── Methods ──
        public void get_Timezone(){} // RVA: 0x2F8380
        public void set_Timezone(){} // RVA: 0x2DEE30
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x343E80
        public void get_Manufacturer(){} // RVA: 0x30B0C0
        public void set_Manufacturer(){} // RVA: 0x30B0D0
        public void get_Brand(){} // RVA: 0x30B130
        public void set_Brand(){} // RVA: 0x2DEE90
        public void get_Family(){} // RVA: 0x6374D0
        public void set_Family(){} // RVA: 0x30B890
        public void get_Model(){} // RVA: 0x4976A0
        public void set_Model(){} // RVA: 0x49B830
        public void get_ModelId(){} // RVA: 0x35A740
        public void set_ModelId(){} // RVA: 0x305200
        public void get_Architecture(){} // RVA: 0x358730
        public void set_Architecture(){} // RVA: 0x358740
        public void get_BatteryLevel(){} // RVA: 0x59C540
        public void set_BatteryLevel(){} // RVA: 0x65F570
        public void get_IsCharging(){} // RVA: 0x63CFB40
        public void set_IsCharging(){} // RVA: 0x63CFB50
        public void get_IsOnline(){} // RVA: 0x63CFB60
        public void set_IsOnline(){} // RVA: 0x63CFB70
        public void get_Orientation(){} // RVA: 0x3A5500
        public void set_Orientation(){} // RVA: 0x4C34E0
        public void get_Simulator(){} // RVA: 0x36ACC00
        public void set_Simulator(){} // RVA: 0x63CFB80
        public void get_MemorySize(){} // RVA: 0x36ABC50
        public void set_MemorySize(){} // RVA: 0x36AC0C0
        public void get_FreeMemory(){} // RVA: 0x629CA70
        public void set_FreeMemory(){} // RVA: 0x629CA80
        public void get_UsableMemory(){} // RVA: 0x576C5E0
        public void set_UsableMemory(){} // RVA: 0x576C5F0
        public void get_LowMemory(){} // RVA: 0x63CFB90
        public void set_LowMemory(){} // RVA: 0x63CFBA0
        public void get_StorageSize(){} // RVA: 0x612FAA0
        public void set_StorageSize(){} // RVA: 0x612FAB0
        public void get_FreeStorage(){} // RVA: 0xA4F4E0
        public void set_FreeStorage(){} // RVA: 0xA4F4F0
        public void get_ExternalStorageSize(){} // RVA: 0x63B6D10
        public void set_ExternalStorageSize(){} // RVA: 0x63B6D20
        public void get_ExternalFreeStorage(){} // RVA: 0x408F60
        public void set_ExternalFreeStorage(){} // RVA: 0x408F70
        public void get_ScreenResolution(){} // RVA: 0x35E900
        public void set_ScreenResolution(){} // RVA: 0x35E910
        public void get_ScreenDensity(){} // RVA: 0x35E970
        public void set_ScreenDensity(){} // RVA: 0x6016310
        public void get_ScreenDpi(){} // RVA: 0x3482A0
        public void set_ScreenDpi(){} // RVA: 0x63CFBB0
        public void get_BootTime(){} // RVA: 0x63CFBC0
        public void set_BootTime(){} // RVA: 0x63CFBE0
        public void get_ProcessorCount(){} // RVA: 0x507710
        public void set_ProcessorCount(){} // RVA: 0x63CFC00
        public void get_CpuDescription(){} // RVA: 0x507D10
        public void set_CpuDescription(){} // RVA: 0x50A8C0
        public void get_ProcessorFrequency(){} // RVA: 0x59E660
        public void set_ProcessorFrequency(){} // RVA: 0x63CFC10
        public void get_DeviceType(){} // RVA: 0xA8EE80
        public void set_DeviceType(){} // RVA: 0xD182E0
        public void get_BatteryStatus(){} // RVA: 0xA8E870
        public void set_BatteryStatus(){} // RVA: 0xDA3F70
        public void get_DeviceUniqueIdentifier(){} // RVA: 0xA933D0
        public void set_DeviceUniqueIdentifier(){} // RVA: 0xA96DC0
        public void get_SupportsVibration(){} // RVA: 0x63CFC20
        public void set_SupportsVibration(){} // RVA: 0x63CFC30
        public void get_SupportsAccelerometer(){} // RVA: 0x63CFC40
        public void set_SupportsAccelerometer(){} // RVA: 0x63CFC50
        public void get_SupportsGyroscope(){} // RVA: 0x63CFC60
        public void set_SupportsGyroscope(){} // RVA: 0x63CFC70
        public void get_SupportsAudio(){} // RVA: 0x63CFC80
        public void set_SupportsAudio(){} // RVA: 0x63CFC90
        public void get_SupportsLocationService(){} // RVA: 0x63CFCA0
        public void set_SupportsLocationService(){} // RVA: 0x63CFCB0
        public void Clone(){} // RVA: 0x63CFCC0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Device>.Clone(){} // RVA: 0x63CFD70
        public void UpdateFrom(){} // RVA: 0x63D0370
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63D03C0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Device>.UpdateFrom(){} // RVA: 0x63D0430
        public void WriteTo(){} // RVA: 0x63D0CC0
        public void TryParseTimezone(){} // RVA: 0x63D2400
        public void FromJson(){} // RVA: 0x63D26C0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Gpu
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Id(){} // RVA: 0x2E07C0
        public void set_Id(){} // RVA: 0xC5BE60
        public void get_VendorId(){} // RVA: 0x30B0C0
        public void set_VendorId(){} // RVA: 0x30B0D0
        public void get_VendorName(){} // RVA: 0x30B130
        public void set_VendorName(){} // RVA: 0x2DEE90
        public void get_MemorySize(){} // RVA: 0x6374D0
        public void set_MemorySize(){} // RVA: 0x1F74DF0
        public void get_ApiType(){} // RVA: 0x4976A0
        public void set_ApiType(){} // RVA: 0x49B830
        public void get_MultiThreadedRendering(){} // RVA: 0x44CB950
        public void set_MultiThreadedRendering(){} // RVA: 0x6382A00
        public void get_Version(){} // RVA: 0x358730
        public void set_Version(){} // RVA: 0x358740
        public void get_NpotSupport(){} // RVA: 0x37E0E0
        public void set_NpotSupport(){} // RVA: 0x4354D0
        public void get_MaxTextureSize(){} // RVA: 0x3A5500
        public void set_MaxTextureSize(){} // RVA: 0x4C34E0
        public void get_GraphicsShaderLevel(){} // RVA: 0x37B370
        public void set_GraphicsShaderLevel(){} // RVA: 0x37B380
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x36AC8E0
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x36AC8F0
        public void get_SupportsRayTracing(){} // RVA: 0x63D4C20
        public void set_SupportsRayTracing(){} // RVA: 0x63D4C30
        public void get_SupportsComputeShaders(){} // RVA: 0x63C8170
        public void set_SupportsComputeShaders(){} // RVA: 0x63C86A0
        public void get_SupportsGeometryShaders(){} // RVA: 0x63D4C40
        public void set_SupportsGeometryShaders(){} // RVA: 0x63D4C50
        public void Clone(){} // RVA: 0x63D4C60
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Gpu>.Clone(){} // RVA: 0x63D4D10
        public void UpdateFrom(){} // RVA: 0x63D5000
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63D5050
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Gpu>.UpdateFrom(){} // RVA: 0x63D50C0
        public void WriteTo(){} // RVA: 0x63D5490
        public void FromJson(){} // RVA: 0x63D5C70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ITraceContext
    {
        // ── Methods ──
        public void get_SpanId(){}
        public void get_ParentSpanId(){}
        public void get_TraceId(){} // RVA: 0xC770
        public void get_Operation(){} // RVA: 0xCD60
        public void get_Description(){} // RVA: 0xCD60
        public void get_Status(){} // RVA: 0xCD60
        public void get_IsSampled(){} // RVA: 0xCC90
    }

    public class Measurement
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void get_Unit(){} // RVA: 0x994EE0
        public void .ctor(){} // RVA: 0x63D7020 | overloaded x5
        public void WriteTo(){} // RVA: 0x63D7130
        public void FromJson(){} // RVA: 0x63D75A0
    }

    public class Mechanism
    {
        // ── Methods ──
        public void get_InternalData(){} // RVA: 0x2F8380
        public void set_InternalData(){} // RVA: 0x2DEE30
        public void get_InternalMeta(){} // RVA: 0x2E07C0
        public void set_InternalMeta(){} // RVA: 0x343E80
        public void get_Type(){} // RVA: 0x30B0C0
        public void set_Type(){} // RVA: 0x63D78B0
        public void get_Description(){} // RVA: 0x30B130
        public void set_Description(){} // RVA: 0x2DEE90
        public void get_Source(){} // RVA: 0x6374D0
        public void set_Source(){} // RVA: 0x30B890
        public void get_HelpLink(){} // RVA: 0x4976A0
        public void set_HelpLink(){} // RVA: 0x49B830
        public void get_Handled(){} // RVA: 0x44CB950
        public void set_Handled(){} // RVA: 0x6382A00
        public void get_Synthetic(){} // RVA: 0x65F560
        public void set_Synthetic(){} // RVA: 0x65F1B0
        public void get_IsExceptionGroup(){} // RVA: 0x1514560
        public void set_IsExceptionGroup(){} // RVA: 0x1AF8C50
        public void get_ExceptionId(){} // RVA: 0x63D7960
        public void set_ExceptionId(){} // RVA: 0x63D7970
        public void get_ParentId(){} // RVA: 0x36B37B0
        public void set_ParentId(){} // RVA: 0x36B37C0
        public void get_Meta(){} // RVA: 0x63D7980
        public void get_Data(){} // RVA: 0x63D7A40
        public void WriteTo(){} // RVA: 0x63D7B00
        public void FromJson(){} // RVA: 0x63D80A0
        public void IsDefaultOrEmpty(){} // RVA: 0x63D8CA0
        public void .ctor(){} // RVA: 0x63D8DF0
        public void .cctor(){} // RVA: 0x63D8E80
    }

    public class OperatingSystem
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Version(){} // RVA: 0x2E07C0
        public void set_Version(){} // RVA: 0x343E80
        public void get_RawDescription(){} // RVA: 0x30B0C0
        public void set_RawDescription(){} // RVA: 0x30B0D0
        public void get_Build(){} // RVA: 0x30B130
        public void set_Build(){} // RVA: 0x2DEE90
        public void get_KernelVersion(){} // RVA: 0x6374D0
        public void set_KernelVersion(){} // RVA: 0x30B890
        public void get_Rooted(){} // RVA: 0x44BA5E0
        public void set_Rooted(){} // RVA: 0x63D9030
        public void Clone(){} // RVA: 0x63D9040
        public void Sentry.Internal.ICloneable<Sentry.Protocol.OperatingSystem>.Clone(){} // RVA: 0x63D90F0
        public void UpdateFrom(){} // RVA: 0x63D92F0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63D9340
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.OperatingSystem>.UpdateFrom(){} // RVA: 0x63D93B0
        public void WriteTo(){} // RVA: 0x63D95F0
        public void FromJson(){} // RVA: 0x63D9860
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ProfileInfo
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x196ABE0
        public void set_EventId(){} // RVA: 0x196ABF0
        public void get_DebugMeta(){} // RVA: 0x30B0C0
        public void set_DebugMeta(){} // RVA: 0x30B0D0
        public void get_Contexts(){} // RVA: 0x30B130
        public void set_Contexts(){} // RVA: 0x63D9F70
        public void get_Profile(){} // RVA: 0x6374D0
        public void set_Profile(){} // RVA: 0x30B890
        public void get_StartTimestamp(){} // RVA: 0x196F080
        public void set_StartTimestamp(){} // RVA: 0x1F74CD0
        public void get_Environment(){} // RVA: 0x358730
        public void set_Environment(){} // RVA: 0x358740
        public void get_Platform(){} // RVA: 0x37E0E0
        public void set_Platform(){} // RVA: 0x4354D0
        public void get_Release(){} // RVA: 0x3A5500
        public void set_Release(){} // RVA: 0x3A5510
        public void get_Transaction(){} // RVA: 0x37B370
        public void set_Transaction(){} // RVA: 0x37B380
        public void WriteTo(){} // RVA: 0x63D9F90
        public void .ctor(){} // RVA: 0x63DA970
    }

    public class Response
    {
        // ── Methods ──
        public void get_InternalHeaders(){} // RVA: 0x2F8380
        public void set_InternalHeaders(){} // RVA: 0x2DEE30
        public void get_BodySize(){} // RVA: 0x994EE0
        public void set_BodySize(){} // RVA: 0x9949A0
        public void get_Cookies(){} // RVA: 0x30B130
        public void set_Cookies(){} // RVA: 0x2DEE90
        public void get_Data(){} // RVA: 0x6374D0
        public void set_Data(){} // RVA: 0x30B890
        public void get_Headers(){} // RVA: 0x63DAD20
        public void get_StatusCode(){} // RVA: 0xFDC9F0
        public void set_StatusCode(){} // RVA: 0xFDD6E0
        public void AddHeaders(){} // RVA: 0x63DADE0
        public void Clone(){} // RVA: 0x63DB0D0
        public void UpdateFrom(){} // RVA: 0x63DB2D0 | overloaded x2
        public void WriteTo(){} // RVA: 0x63DB340
        public void FromJson(){} // RVA: 0x63DB740
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Runtime
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Version(){} // RVA: 0x2E07C0
        public void set_Version(){} // RVA: 0x343E80
        public void get_RawDescription(){} // RVA: 0x30B0C0
        public void set_RawDescription(){} // RVA: 0x30B0D0
        public void get_Identifier(){} // RVA: 0x30B130
        public void set_Identifier(){} // RVA: 0x2DEE90
        public void get_Build(){} // RVA: 0x6374D0
        public void set_Build(){} // RVA: 0x30B890
        public void Clone(){} // RVA: 0x63DBD10
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Runtime>.Clone(){} // RVA: 0x63DBDC0
        public void UpdateFrom(){} // RVA: 0x63DBFB0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63DC000
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Runtime>.UpdateFrom(){} // RVA: 0x63DC070
        public void WriteTo(){} // RVA: 0x63DC280
        public void FromJson(){} // RVA: 0x63DC480
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SampleProfile
    {
        // ── Methods ──
        public void WriteTo(){} // RVA: 0x63DCA90
        public void .ctor(){} // RVA: 0x63DD030
    }

    public class SentryException
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x2F8380
        public void set_Type(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void get_Module(){} // RVA: 0x30B0C0
        public void set_Module(){} // RVA: 0x30B0D0
        public void get_ThreadId(){} // RVA: 0x791DC0
        public void set_ThreadId(){} // RVA: 0xA53440
        public void get_Stacktrace(){} // RVA: 0x6374D0
        public void set_Stacktrace(){} // RVA: 0x30B890
        public void get_Mechanism(){} // RVA: 0x4976A0
        public void set_Mechanism(){} // RVA: 0x49B830
        public void WriteTo(){} // RVA: 0x63DD6F0
        public void FromJson(){} // RVA: 0x63DDB30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Trace
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x2F8380
        public void set_SpanId(){} // RVA: 0x1967700
        public void get_ParentSpanId(){} // RVA: 0x994EE0
        public void set_ParentSpanId(){} // RVA: 0x9949A0
        public void get_TraceId(){} // RVA: 0x111F520
        public void set_TraceId(){} // RVA: 0x111C380
        public void get_Operation(){} // RVA: 0x4976A0
        public void set_Operation(){} // RVA: 0x49B830
        public void get_Origin(){} // RVA: 0x35A740
        public void set_Origin(){} // RVA: 0x63DE430
        public void get_Description(){} // RVA: 0x358730
        public void set_Description(){} // RVA: 0x358740
        public void get_Status(){} // RVA: 0x37E0E0
        public void set_Status(){} // RVA: 0x4C4D50
        public void get_IsSampled(){} // RVA: 0x63CCCB0
        public void set_IsSampled(){} // RVA: 0x63CCCC0
        public void Clone(){} // RVA: 0x63DE530
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Trace>.Clone(){} // RVA: 0x63DE5E0
        public void UpdateFrom(){} // RVA: 0x63DE6D0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x63DE720
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Trace>.UpdateFrom(){} // RVA: 0x63DE7C0
        public void WriteTo(){} // RVA: 0x63DE9F0
        public void FromJson(){} // RVA: 0x63DF030
        public void .ctor(){} // RVA: 0x63DFC30
    }

}