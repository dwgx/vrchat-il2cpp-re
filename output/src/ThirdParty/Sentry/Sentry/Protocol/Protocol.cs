// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol
// Classes: 16
// Methods: 343

namespace ThirdParty.Sentry.Sentry.Protocol
{
    public class App : Object
    {
        public string Type;
        public string _identifier; // 0x10
        public System.Nullable`1<System.DateTimeOffset> _startTime; // 0x18
        public string _hash; // 0x30
        public string _buildType; // 0x38
        public string _name; // 0x40
        public string _version; // 0x48
        public string _build; // 0x50

        // ── Methods ──
        public void get_Identifier(){} // RVA: 0x7FFE81116380
        public void set_Identifier(){} // RVA: 0x7FFE810FCE30
        public void get_StartTime(){} // RVA: 0x7FFE82CD7E60
        public void set_StartTime(){} // RVA: 0x7FFE82D1A030
        public void get_Hash(){} // RVA: 0x7FFE8144E200
        public void set_Hash(){} // RVA: 0x7FFE81129890
        public void get_BuildType(){} // RVA: 0x7FFE8143BA80
        public void set_BuildType(){} // RVA: 0x7FFE81437330
        public void get_Name(){} // RVA: 0x7FFE81178740
        public void set_Name(){} // RVA: 0x7FFE81123200
        public void get_Version(){} // RVA: 0x7FFE81176730
        public void set_Version(){} // RVA: 0x7FFE81176740
        public void get_Build(){} // RVA: 0x7FFE8119C0E0
        public void set_Build(){} // RVA: 0x7FFE812534D0
        public void get_InForeground(){} // RVA: 0x7FFE86F0D6E0
        public void set_InForeground(){} // RVA: 0x7FFE86F0D6F0
        public void Clone(){} // RVA: 0x7FFE86F0D700
        public void Sentry.Internal.ICloneable<Sentry.Protocol.App>.Clone(){} // RVA: 0x7FFE86F0D7B0
        public void UpdateFrom(){} // RVA: 0x7FFE86F0DA30
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F0DA80
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.App>.UpdateFrom(){} // RVA: 0x7FFE86F0DAF0
        public void WriteTo(){} // RVA: 0x7FFE86F0DDC0
        public void FromJson(){} // RVA: 0x7FFE86F0E0F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Browser : Object
    {
        public string Type;
        public string _name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void set_Version(){} // RVA: 0x7FFE81161E80
        public void Clone(){} // RVA: 0x7FFE86F0EA80
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Browser>.Clone(){} // RVA: 0x7FFE86F0EB30
        public void UpdateFrom(){} // RVA: 0x7FFE86F0EC30
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F0EC80
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Browser>.UpdateFrom(){} // RVA: 0x7FFE86F0ECF0
        public void WriteTo(){} // RVA: 0x7FFE86F0EDE0
        public void FromJson(){} // RVA: 0x7FFE86F0EF30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DebugImage : Object
    {
        public string _type; // 0x10
        public System.Nullable`1<long> _imageAddress; // 0x18
        public System.Nullable`1<long> _imageSize; // 0x28
        public string _debugId; // 0x38
        public string _debugChecksum; // 0x40
        public string _debugFile; // 0x48
        public string _codeId; // 0x50
        public string _codeFile; // 0x58
        public System.Nullable`1<System.Guid> _moduleVersionId; // 0x60

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void set_Type(){} // RVA: 0x7FFE810FCE30
        public void get_ImageAddress(){} // RVA: 0x7FFE81703940
        public void set_ImageAddress(){} // RVA: 0x7FFE817036E0
        public void get_ImageSize(){} // RVA: 0x7FFE81E90600
        public void set_ImageSize(){} // RVA: 0x7FFE81E8E800
        public void get_DebugId(){} // RVA: 0x7FFE8143BA80
        public void set_DebugId(){} // RVA: 0x7FFE81437330
        public void get_DebugChecksum(){} // RVA: 0x7FFE81178740
        public void set_DebugChecksum(){} // RVA: 0x7FFE81123200
        public void get_DebugFile(){} // RVA: 0x7FFE81176730
        public void set_DebugFile(){} // RVA: 0x7FFE81176740
        public void get_CodeId(){} // RVA: 0x7FFE8119C0E0
        public void set_CodeId(){} // RVA: 0x7FFE812534D0
        public void get_CodeFile(){} // RVA: 0x7FFE811C3500
        public void set_CodeFile(){} // RVA: 0x7FFE811C3510
        public void get_ModuleVersionId(){} // RVA: 0x7FFE86F0F1F0
        public void set_ModuleVersionId(){} // RVA: 0x7FFE86F0F210
        public void WriteTo(){} // RVA: 0x7FFE86F0F220
        public void FromJson(){} // RVA: 0x7FFE86F0F6B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DebugMeta : Object
    {
        public System.Collections.Generic.List`1<Sentry.Protocol.DebugImage> _images; // 0x10

        // ── Methods ──
        public void get_Images(){} // RVA: 0x7FFE81116380
        public void set_Images(){} // RVA: 0x7FFE810FCE30
        public void WriteTo(){} // RVA: 0x7FFE86F0FFE0
        public void FromJson(){} // RVA: 0x7FFE86F100C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Device : Object
    {
        public string Type;
        public System.TimeZoneInfo _timezone; // 0x10
        public string _name; // 0x18
        public string _manufacturer; // 0x20
        public string _brand; // 0x28
        public string _family; // 0x30
        public string _model; // 0x38
        public string _modelId; // 0x40
        public string _architecture; // 0x48
        public System.Nullable`1<short> _batteryLevel; // 0x50
        public System.Nullable`1<bool> _isCharging; // 0x54
        public System.Nullable`1<bool> _isOnline; // 0x56
        public System.Nullable`1<0x66594264> _orientation; // 0x58
        public System.Nullable`1<bool> _simulator; // 0x60
        public System.Nullable`1<long> _memorySize; // 0x68
        public System.Nullable`1<long> _freeMemory; // 0x78
        public System.Nullable`1<long> _usableMemory; // 0x88
        public System.Nullable`1<bool> _lowMemory; // 0x98
        public System.Nullable`1<long> _storageSize; // 0xA0
        public System.Nullable`1<long> _freeStorage; // 0xB0
        public System.Nullable`1<long> _externalStorageSize; // 0xC0
        public System.Nullable`1<long> _externalFreeStorage; // 0xD0
        public string _screenResolution; // 0xE0
        public System.Nullable`1<float> _screenDensity; // 0xE8
        public System.Nullable`1<int> _screenDpi; // 0xF0
        public System.Nullable`1<System.DateTimeOffset> _bootTime; // 0xF8
        public System.Nullable`1<int> _processorCount; // 0x110
        public string _cpuDescription; // 0x118
        public System.Nullable`1<int> _processorFrequency; // 0x120
        public string _deviceType; // 0x128
        public string _batteryStatus; // 0x130
        public string _deviceUniqueIdentifier; // 0x138
        public System.Nullable`1<bool> _supportsVibration; // 0x140
        public System.Nullable`1<bool> _supportsAccelerometer; // 0x142
        public System.Nullable`1<bool> _supportsGyroscope; // 0x144
        public System.Nullable`1<bool> _supportsAudio; // 0x146

        // ── Methods ──
        public void get_Timezone(){} // RVA: 0x7FFE81116380
        public void set_Timezone(){} // RVA: 0x7FFE810FCE30
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void get_Manufacturer(){} // RVA: 0x7FFE811290C0
        public void set_Manufacturer(){} // RVA: 0x7FFE811290D0
        public void get_Brand(){} // RVA: 0x7FFE81129130
        public void set_Brand(){} // RVA: 0x7FFE810FCE90
        public void get_Family(){} // RVA: 0x7FFE8144E200
        public void set_Family(){} // RVA: 0x7FFE81129890
        public void get_Model(){} // RVA: 0x7FFE8143BA80
        public void set_Model(){} // RVA: 0x7FFE81437330
        public void get_ModelId(){} // RVA: 0x7FFE81178740
        public void set_ModelId(){} // RVA: 0x7FFE81123200
        public void get_Architecture(){} // RVA: 0x7FFE81176730
        public void set_Architecture(){} // RVA: 0x7FFE81176740
        public void get_BatteryLevel(){} // RVA: 0x7FFE8139DAD0
        public void set_BatteryLevel(){} // RVA: 0x7FFE81463B00
        public void get_IsCharging(){} // RVA: 0x7FFE86F10570
        public void set_IsCharging(){} // RVA: 0x7FFE86F10580
        public void get_IsOnline(){} // RVA: 0x7FFE86F10590
        public void set_IsOnline(){} // RVA: 0x7FFE86F105A0
        public void get_Orientation(){} // RVA: 0x7FFE811C3500
        public void set_Orientation(){} // RVA: 0x7FFE825093B0
        public void get_Simulator(){} // RVA: 0x7FFE84330CC0
        public void set_Simulator(){} // RVA: 0x7FFE86F105B0
        public void get_MemorySize(){} // RVA: 0x7FFE8432FD10
        public void set_MemorySize(){} // RVA: 0x7FFE84330180
        public void get_FreeMemory(){} // RVA: 0x7FFE86DDD4A0
        public void set_FreeMemory(){} // RVA: 0x7FFE86DDD4B0
        public void get_UsableMemory(){} // RVA: 0x7FFE8621CDA0
        public void set_UsableMemory(){} // RVA: 0x7FFE8621CDB0
        public void get_LowMemory(){} // RVA: 0x7FFE86F105C0
        public void set_LowMemory(){} // RVA: 0x7FFE86F105D0
        public void get_StorageSize(){} // RVA: 0x7FFE86C70870
        public void set_StorageSize(){} // RVA: 0x7FFE86C70880
        public void get_FreeStorage(){} // RVA: 0x7FFE817DEEA0
        public void set_FreeStorage(){} // RVA: 0x7FFE817DD430
        public void get_ExternalStorageSize(){} // RVA: 0x7FFE86EF7740
        public void set_ExternalStorageSize(){} // RVA: 0x7FFE86EF7750
        public void get_ExternalFreeStorage(){} // RVA: 0x7FFE81226F60
        public void set_ExternalFreeStorage(){} // RVA: 0x7FFE81226F70
        public void get_ScreenResolution(){} // RVA: 0x7FFE8117C900
        public void set_ScreenResolution(){} // RVA: 0x7FFE8117C910
        public void get_ScreenDensity(){} // RVA: 0x7FFE8117C970
        public void set_ScreenDensity(){} // RVA: 0x7FFE86B570F0
        public void get_ScreenDpi(){} // RVA: 0x7FFE811662A0
        public void set_ScreenDpi(){} // RVA: 0x7FFE86F105E0
        public void get_BootTime(){} // RVA: 0x7FFE86F105F0
        public void set_BootTime(){} // RVA: 0x7FFE86F10610
        public void get_ProcessorCount(){} // RVA: 0x7FFE81317980
        public void set_ProcessorCount(){} // RVA: 0x7FFE86F10630
        public void get_CpuDescription(){} // RVA: 0x7FFE81318010
        public void set_CpuDescription(){} // RVA: 0x7FFE81317920
        public void get_ProcessorFrequency(){} // RVA: 0x7FFE813A1DA0
        public void set_ProcessorFrequency(){} // RVA: 0x7FFE86F10640
        public void get_DeviceType(){} // RVA: 0x7FFE8182B890
        public void set_DeviceType(){} // RVA: 0x7FFE81B31E10
        public void get_BatteryStatus(){} // RVA: 0x7FFE81823850
        public void set_BatteryStatus(){} // RVA: 0x7FFE81B31120
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFE8181EA70
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x7FFE818254E0
        public void get_SupportsVibration(){} // RVA: 0x7FFE86F10650
        public void set_SupportsVibration(){} // RVA: 0x7FFE86F10660
        public void get_SupportsAccelerometer(){} // RVA: 0x7FFE86F10670
        public void set_SupportsAccelerometer(){} // RVA: 0x7FFE86F10680
        public void get_SupportsGyroscope(){} // RVA: 0x7FFE86F10690
        public void set_SupportsGyroscope(){} // RVA: 0x7FFE86F106A0
        public void get_SupportsAudio(){} // RVA: 0x7FFE86F106B0
        public void set_SupportsAudio(){} // RVA: 0x7FFE86F106C0
        public void get_SupportsLocationService(){} // RVA: 0x7FFE86F106D0
        public void set_SupportsLocationService(){} // RVA: 0x7FFE86F106E0
        public void Clone(){} // RVA: 0x7FFE86F106F0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Device>.Clone(){} // RVA: 0x7FFE86F107A0
        public void UpdateFrom(){} // RVA: 0x7FFE86F10DA0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F10DF0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Device>.UpdateFrom(){} // RVA: 0x7FFE86F10E60
        public void WriteTo(){} // RVA: 0x7FFE86F116F0
        public void TryParseTimezone(){} // RVA: 0x7FFE86F12E30
        public void FromJson(){} // RVA: 0x7FFE86F130F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Gpu : Object
    {
        public string Type;
        public string _name; // 0x10
        public System.Nullable`1<int> _id; // 0x18
        public string _vendorId; // 0x20
        public string _vendorName; // 0x28
        public System.Nullable`1<int> _memorySize; // 0x30
        public string _apiType; // 0x38
        public System.Nullable`1<bool> _multiThreadedRendering; // 0x40
        public string _version; // 0x48
        public string _npotSupport; // 0x50
        public System.Nullable`1<int> _maxTextureSize; // 0x58
        public string _graphicsShaderLevel; // 0x60
        public System.Nullable`1<bool> _supportsDrawCallInstancing; // 0x68
        public System.Nullable`1<bool> _supportsRayTracing; // 0x6A
        public System.Nullable`1<bool> _supportsComputeShaders; // 0x6C

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Id(){} // RVA: 0x7FFE810FE7C0
        public void set_Id(){} // RVA: 0x7FFE819EA910
        public void get_VendorId(){} // RVA: 0x7FFE811290C0
        public void set_VendorId(){} // RVA: 0x7FFE811290D0
        public void get_VendorName(){} // RVA: 0x7FFE81129130
        public void set_VendorName(){} // RVA: 0x7FFE810FCE90
        public void get_MemorySize(){} // RVA: 0x7FFE8144E200
        public void set_MemorySize(){} // RVA: 0x7FFE82D00170
        public void get_ApiType(){} // RVA: 0x7FFE8143BA80
        public void set_ApiType(){} // RVA: 0x7FFE81437330
        public void get_MultiThreadedRendering(){} // RVA: 0x7FFE851042F0
        public void set_MultiThreadedRendering(){} // RVA: 0x7FFE86EC3420
        public void get_Version(){} // RVA: 0x7FFE81176730
        public void set_Version(){} // RVA: 0x7FFE81176740
        public void get_NpotSupport(){} // RVA: 0x7FFE8119C0E0
        public void set_NpotSupport(){} // RVA: 0x7FFE812534D0
        public void get_MaxTextureSize(){} // RVA: 0x7FFE811C3500
        public void set_MaxTextureSize(){} // RVA: 0x7FFE825093B0
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFE81199370
        public void set_GraphicsShaderLevel(){} // RVA: 0x7FFE81199380
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFE843309A0
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x7FFE843309B0
        public void get_SupportsRayTracing(){} // RVA: 0x7FFE86F15650
        public void set_SupportsRayTracing(){} // RVA: 0x7FFE86F15660
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFE86F08BA0
        public void set_SupportsComputeShaders(){} // RVA: 0x7FFE86F090D0
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFE86F15670
        public void set_SupportsGeometryShaders(){} // RVA: 0x7FFE86F15680
        public void Clone(){} // RVA: 0x7FFE86F15690
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Gpu>.Clone(){} // RVA: 0x7FFE86F15740
        public void UpdateFrom(){} // RVA: 0x7FFE86F15A30
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F15A80
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Gpu>.UpdateFrom(){} // RVA: 0x7FFE86F15AF0
        public void WriteTo(){} // RVA: 0x7FFE86F15EC0
        public void FromJson(){} // RVA: 0x7FFE86F166A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ITraceContext
    {
        // ── Methods ──
        public void get_SpanId(){}
        public void get_ParentSpanId(){}
        public void get_TraceId(){} // RVA: 0x7FFE80E2DCF0
        public void get_Operation(){} // RVA: 0x7FFE80E2E2E0
        public void get_Description(){} // RVA: 0x7FFE80E2E2E0
        public void get_Status(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsSampled(){} // RVA: 0x7FFE80E2E210
    }

    public class Measurement : Object
    {
        public object _value; // 0x10
        public Sentry.MeasurementUnit _unit; // 0x18

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void get_Unit(){} // RVA: 0x7FFE81703940
        public void .ctor(){} // RVA: 0x7FFE86F17A50 | overloaded x5
        public void WriteTo(){} // RVA: 0x7FFE86F17B60
        public void FromJson(){} // RVA: 0x7FFE86F17FD0
    }

    public class Mechanism : Object
    {
        public string HandledKey;
        public string MechanismKey; // 0x8
        public string DescriptionKey; // 0x10
        public System.Collections.Generic.Dictionary`2<string,object> _internalData; // 0x10
        public System.Collections.Generic.Dictionary`2<string,object> _internalMeta; // 0x18
        public string DefaultType;
        public string _type; // 0x20
        public string _description; // 0x28
        public string _source; // 0x30
        public string _helpLink; // 0x38
        public System.Nullable`1<bool> _handled; // 0x40
        public bool _synthetic; // 0x42
        public bool _isExceptionGroup; // 0x43

        // ── Methods ──
        public void get_InternalData(){} // RVA: 0x7FFE81116380
        public void set_InternalData(){} // RVA: 0x7FFE810FCE30
        public void get_InternalMeta(){} // RVA: 0x7FFE810FE7C0
        public void set_InternalMeta(){} // RVA: 0x7FFE81161E80
        public void get_Type(){} // RVA: 0x7FFE811290C0
        public void set_Type(){} // RVA: 0x7FFE86F182E0
        public void get_Description(){} // RVA: 0x7FFE81129130
        public void set_Description(){} // RVA: 0x7FFE810FCE90
        public void get_Source(){} // RVA: 0x7FFE8144E200
        public void set_Source(){} // RVA: 0x7FFE81129890
        public void get_HelpLink(){} // RVA: 0x7FFE8143BA80
        public void set_HelpLink(){} // RVA: 0x7FFE81437330
        public void get_Handled(){} // RVA: 0x7FFE851042F0
        public void set_Handled(){} // RVA: 0x7FFE86EC3420
        public void get_Synthetic(){} // RVA: 0x7FFE81463AF0
        public void set_Synthetic(){} // RVA: 0x7FFE81463C10
        public void get_IsExceptionGroup(){} // RVA: 0x7FFE822BB340
        public void set_IsExceptionGroup(){} // RVA: 0x7FFE82876450
        public void get_ExceptionId(){} // RVA: 0x7FFE86F18390
        public void set_ExceptionId(){} // RVA: 0x7FFE86F183A0
        public void get_ParentId(){} // RVA: 0x7FFE84337910
        public void set_ParentId(){} // RVA: 0x7FFE84337920
        public void get_Meta(){} // RVA: 0x7FFE86F183B0
        public void get_Data(){} // RVA: 0x7FFE86F18470
        public void WriteTo(){} // RVA: 0x7FFE86F18530
        public void FromJson(){} // RVA: 0x7FFE86F18AD0
        public void IsDefaultOrEmpty(){} // RVA: 0x7FFE86F196D0
        public void .ctor(){} // RVA: 0x7FFE86F19820
        public void .cctor(){} // RVA: 0x7FFE86F198B0
    }

    public class OperatingSystem : Object
    {
        public string Type;
        public string _name; // 0x10
        public string _version; // 0x18
        public string _rawDescription; // 0x20
        public string _build; // 0x28
        public string _kernelVersion; // 0x30

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void set_Version(){} // RVA: 0x7FFE81161E80
        public void get_RawDescription(){} // RVA: 0x7FFE811290C0
        public void set_RawDescription(){} // RVA: 0x7FFE811290D0
        public void get_Build(){} // RVA: 0x7FFE81129130
        public void set_Build(){} // RVA: 0x7FFE810FCE90
        public void get_KernelVersion(){} // RVA: 0x7FFE8144E200
        public void set_KernelVersion(){} // RVA: 0x7FFE81129890
        public void get_Rooted(){} // RVA: 0x7FFE85102A10
        public void set_Rooted(){} // RVA: 0x7FFE86F19A60
        public void Clone(){} // RVA: 0x7FFE86F19A70
        public void Sentry.Internal.ICloneable<Sentry.Protocol.OperatingSystem>.Clone(){} // RVA: 0x7FFE86F19B20
        public void UpdateFrom(){} // RVA: 0x7FFE86F19D20
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F19D70
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.OperatingSystem>.UpdateFrom(){} // RVA: 0x7FFE86F19DE0
        public void WriteTo(){} // RVA: 0x7FFE86F1A020
        public void FromJson(){} // RVA: 0x7FFE86F1A290
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ProfileInfo : Object
    {
        public Sentry.SentryId _eventId; // 0x10
        public Sentry.Protocol.DebugMeta _debugMeta; // 0x20
        public Sentry.SentryContexts _contexts; // 0x28
        public Sentry.Protocol.SampleProfile _profile; // 0x30
        public System.DateTimeOffset _startTimestamp; // 0x38
        public string _environment; // 0x48
        public string _platform; // 0x50
        public string _release; // 0x58
        public Sentry.SentryTransaction _transaction; // 0x60

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFE826F6B90
        public void set_EventId(){} // RVA: 0x7FFE826F6BA0
        public void get_DebugMeta(){} // RVA: 0x7FFE811290C0
        public void set_DebugMeta(){} // RVA: 0x7FFE811290D0
        public void get_Contexts(){} // RVA: 0x7FFE81129130
        public void set_Contexts(){} // RVA: 0x7FFE86F1A9A0
        public void get_Profile(){} // RVA: 0x7FFE8144E200
        public void set_Profile(){} // RVA: 0x7FFE81129890
        public void get_StartTimestamp(){} // RVA: 0x7FFE826F9FB0
        public void set_StartTimestamp(){} // RVA: 0x7FFE82D001B0
        public void get_Environment(){} // RVA: 0x7FFE81176730
        public void set_Environment(){} // RVA: 0x7FFE81176740
        public void get_Platform(){} // RVA: 0x7FFE8119C0E0
        public void set_Platform(){} // RVA: 0x7FFE812534D0
        public void get_Release(){} // RVA: 0x7FFE811C3500
        public void set_Release(){} // RVA: 0x7FFE811C3510
        public void get_Transaction(){} // RVA: 0x7FFE81199370
        public void set_Transaction(){} // RVA: 0x7FFE81199380
        public void WriteTo(){} // RVA: 0x7FFE86F1A9C0
        public void .ctor(){} // RVA: 0x7FFE86F1B3A0
    }

    public class Response : Object
    {
        public string Type;
        public System.Collections.Generic.Dictionary`2<string,string> _internalHeaders; // 0x10
        public System.Nullable`1<long> _bodySize; // 0x18
        public string _cookies; // 0x28
        public object _data; // 0x30
        public System.Nullable`1<short> _statusCode; // 0x38

        // ── Methods ──
        public void get_InternalHeaders(){} // RVA: 0x7FFE81116380
        public void set_InternalHeaders(){} // RVA: 0x7FFE810FCE30
        public void get_BodySize(){} // RVA: 0x7FFE81703940
        public void set_BodySize(){} // RVA: 0x7FFE817036E0
        public void get_Cookies(){} // RVA: 0x7FFE81129130
        public void set_Cookies(){} // RVA: 0x7FFE810FCE90
        public void get_Data(){} // RVA: 0x7FFE8144E200
        public void set_Data(){} // RVA: 0x7FFE81129890
        public void get_Headers(){} // RVA: 0x7FFE86F1B750
        public void get_StatusCode(){} // RVA: 0x7FFE81D46090
        public void set_StatusCode(){} // RVA: 0x7FFE81D46A00
        public void AddHeaders(){} // RVA: 0x7FFE86F1B810
        public void Clone(){} // RVA: 0x7FFE86F1BB00
        public void UpdateFrom(){} // RVA: 0x7FFE86F1BD00 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE86F1BD70
        public void FromJson(){} // RVA: 0x7FFE86F1C170
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Runtime : Object
    {
        public string Type;
        public string _name; // 0x10
        public string _version; // 0x18
        public string _rawDescription; // 0x20
        public string _identifier; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void set_Version(){} // RVA: 0x7FFE81161E80
        public void get_RawDescription(){} // RVA: 0x7FFE811290C0
        public void set_RawDescription(){} // RVA: 0x7FFE811290D0
        public void get_Identifier(){} // RVA: 0x7FFE81129130
        public void set_Identifier(){} // RVA: 0x7FFE810FCE90
        public void get_Build(){} // RVA: 0x7FFE8144E200
        public void set_Build(){} // RVA: 0x7FFE81129890
        public void Clone(){} // RVA: 0x7FFE86F1C740
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Runtime>.Clone(){} // RVA: 0x7FFE86F1C7F0
        public void UpdateFrom(){} // RVA: 0x7FFE86F1C9E0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F1CA30
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Runtime>.UpdateFrom(){} // RVA: 0x7FFE86F1CAA0
        public void WriteTo(){} // RVA: 0x7FFE86F1CCB0
        public void FromJson(){} // RVA: 0x7FFE86F1CEB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SampleProfile : Object
    {
        // ── Methods ──
        public void WriteTo(){} // RVA: 0x7FFE86F1D4C0
        public void .ctor(){} // RVA: 0x7FFE86F1DA60
    }

    public class SentryException : Object
    {
        public string _type; // 0x10
        public string _value; // 0x18
        public string _module; // 0x20
        public int _threadId; // 0x28
        public Sentry.SentryStackTrace _stacktrace; // 0x30
        public Sentry.Protocol.Mechanism _mechanism; // 0x38

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void set_Type(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void get_Module(){} // RVA: 0x7FFE811290C0
        public void set_Module(){} // RVA: 0x7FFE811290D0
        public void get_ThreadId(){} // RVA: 0x7FFE81549710
        public void set_ThreadId(){} // RVA: 0x7FFE817E4800
        public void get_Stacktrace(){} // RVA: 0x7FFE8144E200
        public void set_Stacktrace(){} // RVA: 0x7FFE81129890
        public void get_Mechanism(){} // RVA: 0x7FFE8143BA80
        public void set_Mechanism(){} // RVA: 0x7FFE81437330
        public void WriteTo(){} // RVA: 0x7FFE86F1E120
        public void FromJson(){} // RVA: 0x7FFE86F1E560
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Trace : Object
    {
        public string Type;
        public Sentry.SpanId _spanId; // 0x10
        public System.Nullable`1<Sentry.SpanId> _parentSpanId; // 0x18
        public Sentry.SentryId _traceId; // 0x28
        public string _operation; // 0x38
        public string _origin; // 0x40
        public string _description; // 0x48
        public System.Nullable`1<0x66593814> _status; // 0x50

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFE81116380
        public void set_SpanId(){} // RVA: 0x7FFE826F2ED0
        public void get_ParentSpanId(){} // RVA: 0x7FFE81703940
        public void set_ParentSpanId(){} // RVA: 0x7FFE817036E0
        public void get_TraceId(){} // RVA: 0x7FFE81E90600
        public void set_TraceId(){} // RVA: 0x7FFE81E8E800
        public void get_Operation(){} // RVA: 0x7FFE8143BA80
        public void set_Operation(){} // RVA: 0x7FFE81437330
        public void get_Origin(){} // RVA: 0x7FFE81178740
        public void set_Origin(){} // RVA: 0x7FFE86F1EE60
        public void get_Description(){} // RVA: 0x7FFE81176730
        public void set_Description(){} // RVA: 0x7FFE81176740
        public void get_Status(){} // RVA: 0x7FFE8119C0E0
        public void set_Status(){} // RVA: 0x7FFE82506C00
        public void get_IsSampled(){} // RVA: 0x7FFE86F0D6E0
        public void set_IsSampled(){} // RVA: 0x7FFE86F0D6F0
        public void Clone(){} // RVA: 0x7FFE86F1EF60
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Trace>.Clone(){} // RVA: 0x7FFE86F1F010
        public void UpdateFrom(){} // RVA: 0x7FFE86F1F100
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFE86F1F150
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Trace>.UpdateFrom(){} // RVA: 0x7FFE86F1F1F0
        public void WriteTo(){} // RVA: 0x7FFE86F1F420
        public void FromJson(){} // RVA: 0x7FFE86F1FA60
        public void .ctor(){} // RVA: 0x7FFE86F20660
    }

}