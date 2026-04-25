// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol
// Classes: 16
// Methods: 343

namespace ThirdParty.Sentry.Sentry.Protocol
{
    public class App : Object
    {
        public string Identifier;
        public string StartTime; // 0x10
        public System.Nullable`1<System.DateTimeOffset> Hash; // 0x18
        public string BuildType; // 0x30
        public string Name; // 0x38
        public string Version; // 0x40
        public string Build; // 0x48
        public string InForeground; // 0x50
        public System.Nullable`1<bool> <InForeground>k__BackingField; // 0x58

        // ── Methods ──
        public void get_Identifier(){} // RVA: 0x7FFAC2F3C380
        public void set_Identifier(){} // RVA: 0x7FFAC2F22E30
        public void get_StartTime(){} // RVA: 0x7FFAC4A6D150
        public void set_StartTime(){} // RVA: 0x7FFAC4AB09F0
        public void get_Hash(){} // RVA: 0x7FFAC31D95E0
        public void set_Hash(){} // RVA: 0x7FFAC2F4F890
        public void get_BuildType(){} // RVA: 0x7FFAC31D0140
        public void set_BuildType(){} // RVA: 0x7FFAC31D0C20
        public void get_Name(){} // RVA: 0x7FFAC2F9E740
        public void set_Name(){} // RVA: 0x7FFAC2F49200
        public void get_Version(){} // RVA: 0x7FFAC2F9C730
        public void set_Version(){} // RVA: 0x7FFAC2F9C740
        public void get_Build(){} // RVA: 0x7FFAC2FC20E0
        public void set_Build(){} // RVA: 0x7FFAC30794D0
        public void get_InForeground(){} // RVA: 0x7FFAC8B64070
        public void set_InForeground(){} // RVA: 0x7FFAC8B64080
        public void Clone(){} // RVA: 0x7FFAC8B64090
        public void Sentry.Internal.ICloneable<Sentry.Protocol.App>.Clone(){} // RVA: 0x7FFAC8B64140
        public void UpdateFrom(){} // RVA: 0x7FFAC8B643C0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B64410
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.App>.UpdateFrom(){} // RVA: 0x7FFAC8B64480
        public void WriteTo(){} // RVA: 0x7FFAC8B64750
        public void FromJson(){} // RVA: 0x7FFAC8B64A80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Browser : Object
    {
        public string Name;
        public string Version; // 0x10
        public string <Version>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void set_Version(){} // RVA: 0x7FFAC2F87E80
        public void Clone(){} // RVA: 0x7FFAC8B65410
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Browser>.Clone(){} // RVA: 0x7FFAC8B654C0
        public void UpdateFrom(){} // RVA: 0x7FFAC8B655C0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B65610
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Browser>.UpdateFrom(){} // RVA: 0x7FFAC8B65680
        public void WriteTo(){} // RVA: 0x7FFAC8B65770
        public void FromJson(){} // RVA: 0x7FFAC8B658C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DebugImage : Object
    {
        public string Type; // 0x10
        public System.Nullable`1<long> ImageAddress; // 0x18
        public System.Nullable`1<long> ImageSize; // 0x28
        public string DebugId; // 0x38
        public string DebugChecksum; // 0x40
        public string DebugFile; // 0x48
        public string CodeId; // 0x50
        public string CodeFile; // 0x58
        public System.Nullable`1<System.Guid> ModuleVersionId; // 0x60

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void set_Type(){} // RVA: 0x7FFAC2F22E30
        public void get_ImageAddress(){} // RVA: 0x7FFAC35D3330
        public void set_ImageAddress(){} // RVA: 0x7FFAC35D34F0
        public void get_ImageSize(){} // RVA: 0x7FFAC3BCF020
        public void set_ImageSize(){} // RVA: 0x7FFAC3BCC210
        public void get_DebugId(){} // RVA: 0x7FFAC31D0140
        public void set_DebugId(){} // RVA: 0x7FFAC31D0C20
        public void get_DebugChecksum(){} // RVA: 0x7FFAC2F9E740
        public void set_DebugChecksum(){} // RVA: 0x7FFAC2F49200
        public void get_DebugFile(){} // RVA: 0x7FFAC2F9C730
        public void set_DebugFile(){} // RVA: 0x7FFAC2F9C740
        public void get_CodeId(){} // RVA: 0x7FFAC2FC20E0
        public void set_CodeId(){} // RVA: 0x7FFAC30794D0
        public void get_CodeFile(){} // RVA: 0x7FFAC2FE9500
        public void set_CodeFile(){} // RVA: 0x7FFAC2FE9510
        public void get_ModuleVersionId(){} // RVA: 0x7FFAC8B65B80
        public void set_ModuleVersionId(){} // RVA: 0x7FFAC8B65BA0
        public void WriteTo(){} // RVA: 0x7FFAC8B65BB0
        public void FromJson(){} // RVA: 0x7FFAC8B66040
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DebugMeta : Object
    {
        public System.Collections.Generic.List`1<Sentry.Protocol.DebugImage> Images; // 0x10

        // ── Methods ──
        public void get_Images(){} // RVA: 0x7FFAC2F3C380
        public void set_Images(){} // RVA: 0x7FFAC2F22E30
        public void WriteTo(){} // RVA: 0x7FFAC8B66970
        public void FromJson(){} // RVA: 0x7FFAC8B66A50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Device : Object
    {
        public string Timezone;
        public System.TimeZoneInfo Name; // 0x10
        public string Manufacturer; // 0x18
        public string Brand; // 0x20
        public string Family; // 0x28
        public string Model; // 0x30
        public string ModelId; // 0x38
        public string Architecture; // 0x40
        public string BatteryLevel; // 0x48
        public System.Nullable`1<short> IsCharging; // 0x50
        public System.Nullable`1<bool> IsOnline; // 0x54
        public System.Nullable`1<bool> Orientation; // 0x56
        public System.Nullable`1<0x6B19A9A0> Simulator; // 0x58
        public System.Nullable`1<bool> MemorySize; // 0x60
        public System.Nullable`1<long> FreeMemory; // 0x68
        public System.Nullable`1<long> UsableMemory; // 0x78
        public System.Nullable`1<long> LowMemory; // 0x88
        public System.Nullable`1<bool> StorageSize; // 0x98
        public System.Nullable`1<long> FreeStorage; // 0xA0
        public System.Nullable`1<long> ExternalStorageSize; // 0xB0
        public System.Nullable`1<long> ExternalFreeStorage; // 0xC0
        public System.Nullable`1<long> ScreenResolution; // 0xD0
        public string ScreenDensity; // 0xE0
        public System.Nullable`1<float> ScreenDpi; // 0xE8
        public System.Nullable`1<int> BootTime; // 0xF0
        public System.Nullable`1<System.DateTimeOffset> ProcessorCount; // 0xF8
        public System.Nullable`1<int> CpuDescription; // 0x110
        public string ProcessorFrequency; // 0x118
        public System.Nullable`1<int> DeviceType; // 0x120
        public string BatteryStatus; // 0x128
        public string DeviceUniqueIdentifier; // 0x130
        public string SupportsVibration; // 0x138
        public System.Nullable`1<bool> SupportsAccelerometer; // 0x140
        public System.Nullable`1<bool> SupportsGyroscope; // 0x142
        public System.Nullable`1<bool> SupportsAudio; // 0x144
        public System.Nullable`1<bool> SupportsLocationService; // 0x146
        public System.Nullable`1<bool> <SupportsLocationService>k__BackingField; // 0x148

        // ── Methods ──
        public void get_Timezone(){} // RVA: 0x7FFAC2F3C380
        public void set_Timezone(){} // RVA: 0x7FFAC2F22E30
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void get_Manufacturer(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Manufacturer(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Brand(){} // RVA: 0x7FFAC2F4F130
        public void set_Brand(){} // RVA: 0x7FFAC2F22E90
        public void get_Family(){} // RVA: 0x7FFAC31D95E0
        public void set_Family(){} // RVA: 0x7FFAC2F4F890
        public void get_Model(){} // RVA: 0x7FFAC31D0140
        public void set_Model(){} // RVA: 0x7FFAC31D0C20
        public void get_ModelId(){} // RVA: 0x7FFAC2F9E740
        public void set_ModelId(){} // RVA: 0x7FFAC2F49200
        public void get_Architecture(){} // RVA: 0x7FFAC2F9C730
        public void set_Architecture(){} // RVA: 0x7FFAC2F9C740
        public void get_BatteryLevel(){} // RVA: 0x7FFAC30F10E0
        public void set_BatteryLevel(){} // RVA: 0x7FFAC31D9010
        public void get_IsCharging(){} // RVA: 0x7FFAC8B66F00
        public void set_IsCharging(){} // RVA: 0x7FFAC8B66F10
        public void get_IsOnline(){} // RVA: 0x7FFAC8B66F20
        public void set_IsOnline(){} // RVA: 0x7FFAC8B66F30
        public void get_Orientation(){} // RVA: 0x7FFAC2FE9500
        public void set_Orientation(){} // RVA: 0x7FFAC4249140
        public void get_Simulator(){} // RVA: 0x7FFAC5FD9760
        public void set_Simulator(){} // RVA: 0x7FFAC8B66F40
        public void get_MemorySize(){} // RVA: 0x7FFAC5FD87B0
        public void set_MemorySize(){} // RVA: 0x7FFAC5FD8C20
        public void get_FreeMemory(){} // RVA: 0x7FFAC8A33E20
        public void set_FreeMemory(){} // RVA: 0x7FFAC8A33E30
        public void get_UsableMemory(){} // RVA: 0x7FFAC7DF99E0
        public void set_UsableMemory(){} // RVA: 0x7FFAC7DF99F0
        public void get_LowMemory(){} // RVA: 0x7FFAC8B66F50
        public void set_LowMemory(){} // RVA: 0x7FFAC8B66F60
        public void get_StorageSize(){} // RVA: 0x7FFAC88C7180
        public void set_StorageSize(){} // RVA: 0x7FFAC88C7190
        public void get_FreeStorage(){} // RVA: 0x7FFAC3695970
        public void set_FreeStorage(){} // RVA: 0x7FFAC3693CA0
        public void get_ExternalStorageSize(){} // RVA: 0x7FFAC8B4E0D0
        public void set_ExternalStorageSize(){} // RVA: 0x7FFAC8B4E0E0
        public void get_ExternalFreeStorage(){} // RVA: 0x7FFAC304CF60
        public void set_ExternalFreeStorage(){} // RVA: 0x7FFAC304CF70
        public void get_ScreenResolution(){} // RVA: 0x7FFAC2FA2900
        public void set_ScreenResolution(){} // RVA: 0x7FFAC2FA2910
        public void get_ScreenDensity(){} // RVA: 0x7FFAC2FA2970
        public void set_ScreenDensity(){} // RVA: 0x7FFAC87AD980
        public void get_ScreenDpi(){} // RVA: 0x7FFAC2F8C2A0
        public void set_ScreenDpi(){} // RVA: 0x7FFAC47467B0
        public void get_BootTime(){} // RVA: 0x7FFAC8B66F70
        public void set_BootTime(){} // RVA: 0x7FFAC8B66F90
        public void get_ProcessorCount(){} // RVA: 0x7FFAC354B170
        public void set_ProcessorCount(){} // RVA: 0x7FFAC8B66FB0
        public void get_CpuDescription(){} // RVA: 0x7FFAC33BC6D0
        public void set_CpuDescription(){} // RVA: 0x7FFAC33B8580
        public void get_ProcessorFrequency(){} // RVA: 0x7FFAC313CBB0
        public void set_ProcessorFrequency(){} // RVA: 0x7FFAC8B66FC0
        public void get_DeviceType(){} // RVA: 0x7FFAC35466F0
        public void set_DeviceType(){} // RVA: 0x7FFAC39C51C0
        public void get_BatteryStatus(){} // RVA: 0x7FFAC3544340
        public void set_BatteryStatus(){} // RVA: 0x7FFAC39A79B0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAC35422C0
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x7FFAC36D84B0
        public void get_SupportsVibration(){} // RVA: 0x7FFAC8B66FD0
        public void set_SupportsVibration(){} // RVA: 0x7FFAC8B66FE0
        public void get_SupportsAccelerometer(){} // RVA: 0x7FFAC8B66FF0
        public void set_SupportsAccelerometer(){} // RVA: 0x7FFAC8B67000
        public void get_SupportsGyroscope(){} // RVA: 0x7FFAC8B67010
        public void set_SupportsGyroscope(){} // RVA: 0x7FFAC8B67020
        public void get_SupportsAudio(){} // RVA: 0x7FFAC8B67030
        public void set_SupportsAudio(){} // RVA: 0x7FFAC8B67040
        public void get_SupportsLocationService(){} // RVA: 0x7FFAC8B67050
        public void set_SupportsLocationService(){} // RVA: 0x7FFAC8B67060
        public void Clone(){} // RVA: 0x7FFAC8B67070
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Device>.Clone(){} // RVA: 0x7FFAC8B67120
        public void UpdateFrom(){} // RVA: 0x7FFAC8B67720
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B67770
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Device>.UpdateFrom(){} // RVA: 0x7FFAC8B677E0
        public void WriteTo(){} // RVA: 0x7FFAC8B68070
        public void TryParseTimezone(){} // RVA: 0x7FFAC8B697B0
        public void FromJson(){} // RVA: 0x7FFAC8B69A70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Gpu : Object
    {
        public string Name;
        public string Id; // 0x10
        public System.Nullable`1<int> VendorId; // 0x18
        public string VendorName; // 0x20
        public string MemorySize; // 0x28
        public System.Nullable`1<int> ApiType; // 0x30
        public string MultiThreadedRendering; // 0x38
        public System.Nullable`1<bool> Version; // 0x40
        public string NpotSupport; // 0x48
        public string MaxTextureSize; // 0x50
        public System.Nullable`1<int> GraphicsShaderLevel; // 0x58
        public string SupportsDrawCallInstancing; // 0x60
        public System.Nullable`1<bool> SupportsRayTracing; // 0x68
        public System.Nullable`1<bool> SupportsComputeShaders; // 0x6A
        public System.Nullable`1<bool> SupportsGeometryShaders; // 0x6C
        public System.Nullable`1<bool> <SupportsGeometryShaders>k__BackingField; // 0x6E

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Id(){} // RVA: 0x7FFAC2F247C0
        public void set_Id(){} // RVA: 0x7FFAC38920D0
        public void get_VendorId(){} // RVA: 0x7FFAC2F4F0C0
        public void set_VendorId(){} // RVA: 0x7FFAC2F4F0D0
        public void get_VendorName(){} // RVA: 0x7FFAC2F4F130
        public void set_VendorName(){} // RVA: 0x7FFAC2F22E90
        public void get_MemorySize(){} // RVA: 0x7FFAC31D95E0
        public void set_MemorySize(){} // RVA: 0x7FFAC4A98000
        public void get_ApiType(){} // RVA: 0x7FFAC31D0140
        public void set_ApiType(){} // RVA: 0x7FFAC31D0C20
        public void get_MultiThreadedRendering(){} // RVA: 0x7FFAC6D7BEA0
        public void set_MultiThreadedRendering(){} // RVA: 0x7FFAC8B19DB0
        public void get_Version(){} // RVA: 0x7FFAC2F9C730
        public void set_Version(){} // RVA: 0x7FFAC2F9C740
        public void get_NpotSupport(){} // RVA: 0x7FFAC2FC20E0
        public void set_NpotSupport(){} // RVA: 0x7FFAC30794D0
        public void get_MaxTextureSize(){} // RVA: 0x7FFAC2FE9500
        public void set_MaxTextureSize(){} // RVA: 0x7FFAC4249140
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAC2FBF370
        public void set_GraphicsShaderLevel(){} // RVA: 0x7FFAC2FBF380
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAC5FD9440
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x7FFAC5FD9450
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAC8B6BFD0
        public void set_SupportsRayTracing(){} // RVA: 0x7FFAC8B6BFE0
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAC8B5F530
        public void set_SupportsComputeShaders(){} // RVA: 0x7FFAC8B5FA60
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAC8B6BFF0
        public void set_SupportsGeometryShaders(){} // RVA: 0x7FFAC8B6C000
        public void Clone(){} // RVA: 0x7FFAC8B6C010
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Gpu>.Clone(){} // RVA: 0x7FFAC8B6C0C0
        public void UpdateFrom(){} // RVA: 0x7FFAC8B6C3B0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B6C400
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Gpu>.UpdateFrom(){} // RVA: 0x7FFAC8B6C470
        public void WriteTo(){} // RVA: 0x7FFAC8B6C840
        public void FromJson(){} // RVA: 0x7FFAC8B6D020
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ITraceContext
    {
        public object SpanId;
        public object ParentSpanId;
        public object TraceId;
        public object Operation;
        public object Description;
        public object Status;
        public object IsSampled;

        // ── Methods ──
        public void get_SpanId(){}
        public void get_ParentSpanId(){}
        public void get_TraceId(){} // RVA: 0x7FFAC2C588A0
        public void get_Operation(){} // RVA: 0x7FFAC2C58E90
        public void get_Description(){} // RVA: 0x7FFAC2C58E90
        public void get_Status(){} // RVA: 0x7FFAC2C58E90
        public void get_IsSampled(){} // RVA: 0x7FFAC2C58DC0
    }

    public class Measurement : Object
    {
        public object Value; // 0x10
        public Sentry.MeasurementUnit Unit; // 0x18

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void get_Unit(){} // RVA: 0x7FFAC35D3330
        public void .ctor(){} // RVA: 0x7FFAC8B6E3D0 | overloaded x5
        public void WriteTo(){} // RVA: 0x7FFAC8B6E4E0
        public void FromJson(){} // RVA: 0x7FFAC8B6E950
    }

    public class Mechanism : Object
    {
        public string InternalData;
        public string InternalMeta; // 0x8
        public string Type; // 0x10
        public System.Collections.Generic.Dictionary`2<string,object> Description; // 0x10
        public System.Collections.Generic.Dictionary`2<string,object> Source; // 0x18
        public string HelpLink;
        public string Handled; // 0x20
        public string Synthetic; // 0x28
        public string IsExceptionGroup; // 0x30
        public string ExceptionId; // 0x38
        public System.Nullable`1<bool> ParentId; // 0x40
        public bool Meta; // 0x42
        public bool Data; // 0x43
        public System.Nullable`1<int> <ExceptionId>k__BackingField; // 0x44
        public System.Nullable`1<int> <ParentId>k__BackingField; // 0x4C

        // ── Methods ──
        public void get_InternalData(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalData(){} // RVA: 0x7FFAC2F22E30
        public void get_InternalMeta(){} // RVA: 0x7FFAC2F247C0
        public void set_InternalMeta(){} // RVA: 0x7FFAC2F87E80
        public void get_Type(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Type(){} // RVA: 0x7FFAC8B6EC60
        public void get_Description(){} // RVA: 0x7FFAC2F4F130
        public void set_Description(){} // RVA: 0x7FFAC2F22E90
        public void get_Source(){} // RVA: 0x7FFAC31D95E0
        public void set_Source(){} // RVA: 0x7FFAC2F4F890
        public void get_HelpLink(){} // RVA: 0x7FFAC31D0140
        public void set_HelpLink(){} // RVA: 0x7FFAC31D0C20
        public void get_Handled(){} // RVA: 0x7FFAC6D7BEA0
        public void set_Handled(){} // RVA: 0x7FFAC8B19DB0
        public void get_Synthetic(){} // RVA: 0x7FFAC31D90A0
        public void set_Synthetic(){} // RVA: 0x7FFAC31D9200
        public void get_IsExceptionGroup(){} // RVA: 0x7FFAC3FA0E90
        public void set_IsExceptionGroup(){} // RVA: 0x7FFAC45A8320
        public void get_ExceptionId(){} // RVA: 0x7FFAC8B6ED10
        public void set_ExceptionId(){} // RVA: 0x7FFAC8B6ED20
        public void get_ParentId(){} // RVA: 0x7FFAC5FE03C0
        public void set_ParentId(){} // RVA: 0x7FFAC5FE03D0
        public void get_Meta(){} // RVA: 0x7FFAC8B6ED30
        public void get_Data(){} // RVA: 0x7FFAC8B6EDF0
        public void WriteTo(){} // RVA: 0x7FFAC8B6EEB0
        public void FromJson(){} // RVA: 0x7FFAC8B6F450
        public void IsDefaultOrEmpty(){} // RVA: 0x7FFAC8B70050
        public void .ctor(){} // RVA: 0x7FFAC8B701A0
        public void .cctor(){} // RVA: 0x7FFAC8B70230
    }

    public class OperatingSystem : Object
    {
        public string Name;
        public string Version; // 0x10
        public string RawDescription; // 0x18
        public string Build; // 0x20
        public string KernelVersion; // 0x28
        public string Rooted; // 0x30
        public System.Nullable`1<bool> <Rooted>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void set_Version(){} // RVA: 0x7FFAC2F87E80
        public void get_RawDescription(){} // RVA: 0x7FFAC2F4F0C0
        public void set_RawDescription(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Build(){} // RVA: 0x7FFAC2F4F130
        public void set_Build(){} // RVA: 0x7FFAC2F22E90
        public void get_KernelVersion(){} // RVA: 0x7FFAC31D95E0
        public void set_KernelVersion(){} // RVA: 0x7FFAC2F4F890
        public void get_Rooted(){} // RVA: 0x7FFAC6D7A5C0
        public void set_Rooted(){} // RVA: 0x7FFAC8B703E0
        public void Clone(){} // RVA: 0x7FFAC8B703F0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.OperatingSystem>.Clone(){} // RVA: 0x7FFAC8B704A0
        public void UpdateFrom(){} // RVA: 0x7FFAC8B706A0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B706F0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.OperatingSystem>.UpdateFrom(){} // RVA: 0x7FFAC8B70760
        public void WriteTo(){} // RVA: 0x7FFAC8B709A0
        public void FromJson(){} // RVA: 0x7FFAC8B70C10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ProfileInfo : Object
    {
        public Sentry.SentryId EventId; // 0x10
        public Sentry.Protocol.DebugMeta DebugMeta; // 0x20
        public Sentry.SentryContexts Contexts; // 0x28
        public Sentry.Protocol.SampleProfile Profile; // 0x30
        public System.DateTimeOffset StartTimestamp; // 0x38
        public string Environment; // 0x48
        public string Platform; // 0x50
        public string Release; // 0x58
        public Sentry.SentryTransaction Transaction; // 0x60

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFAC4422E80
        public void set_EventId(){} // RVA: 0x7FFAC4422E90
        public void get_DebugMeta(){} // RVA: 0x7FFAC2F4F0C0
        public void set_DebugMeta(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Contexts(){} // RVA: 0x7FFAC2F4F130
        public void set_Contexts(){} // RVA: 0x7FFAC8B71320
        public void get_Profile(){} // RVA: 0x7FFAC31D95E0
        public void set_Profile(){} // RVA: 0x7FFAC2F4F890
        public void get_StartTimestamp(){} // RVA: 0x7FFAC4426F60
        public void set_StartTimestamp(){} // RVA: 0x7FFAC4A97FB0
        public void get_Environment(){} // RVA: 0x7FFAC2F9C730
        public void set_Environment(){} // RVA: 0x7FFAC2F9C740
        public void get_Platform(){} // RVA: 0x7FFAC2FC20E0
        public void set_Platform(){} // RVA: 0x7FFAC30794D0
        public void get_Release(){} // RVA: 0x7FFAC2FE9500
        public void set_Release(){} // RVA: 0x7FFAC2FE9510
        public void get_Transaction(){} // RVA: 0x7FFAC2FBF370
        public void set_Transaction(){} // RVA: 0x7FFAC2FBF380
        public void WriteTo(){} // RVA: 0x7FFAC8B71340
        public void .ctor(){} // RVA: 0x7FFAC8B71D20
    }

    public class Response : Object
    {
        public string InternalHeaders;
        public System.Collections.Generic.Dictionary`2<string,string> BodySize; // 0x10
        public System.Nullable`1<long> Cookies; // 0x18
        public string Data; // 0x28
        public object Headers; // 0x30
        public System.Nullable`1<short> StatusCode; // 0x38

        // ── Methods ──
        public void get_InternalHeaders(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalHeaders(){} // RVA: 0x7FFAC2F22E30
        public void get_BodySize(){} // RVA: 0x7FFAC35D3330
        public void set_BodySize(){} // RVA: 0x7FFAC35D34F0
        public void get_Cookies(){} // RVA: 0x7FFAC2F4F130
        public void set_Cookies(){} // RVA: 0x7FFAC2F22E90
        public void get_Data(){} // RVA: 0x7FFAC31D95E0
        public void set_Data(){} // RVA: 0x7FFAC2F4F890
        public void get_Headers(){} // RVA: 0x7FFAC8B720D0
        public void get_StatusCode(){} // RVA: 0x7FFAC358A870
        public void set_StatusCode(){} // RVA: 0x7FFAC3588350
        public void AddHeaders(){} // RVA: 0x7FFAC8B72190
        public void Clone(){} // RVA: 0x7FFAC8B72480
        public void UpdateFrom(){} // RVA: 0x7FFAC8B72680 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC8B726F0
        public void FromJson(){} // RVA: 0x7FFAC8B72AF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Runtime : Object
    {
        public string Name;
        public string Version; // 0x10
        public string RawDescription; // 0x18
        public string Identifier; // 0x20
        public string Build; // 0x28
        public string <Build>k__BackingField; // 0x30

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void set_Version(){} // RVA: 0x7FFAC2F87E80
        public void get_RawDescription(){} // RVA: 0x7FFAC2F4F0C0
        public void set_RawDescription(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Identifier(){} // RVA: 0x7FFAC2F4F130
        public void set_Identifier(){} // RVA: 0x7FFAC2F22E90
        public void get_Build(){} // RVA: 0x7FFAC31D95E0
        public void set_Build(){} // RVA: 0x7FFAC2F4F890
        public void Clone(){} // RVA: 0x7FFAC8B730C0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Runtime>.Clone(){} // RVA: 0x7FFAC8B73170
        public void UpdateFrom(){} // RVA: 0x7FFAC8B73360
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B733B0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Runtime>.UpdateFrom(){} // RVA: 0x7FFAC8B73420
        public void WriteTo(){} // RVA: 0x7FFAC8B73630
        public void FromJson(){} // RVA: 0x7FFAC8B73830
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SampleProfile : Object
    {
        public Sentry.Internal.GrowableArray`1<Sample> Samples; // 0x10
        public Sentry.Internal.GrowableArray`1<Sentry.SentryStackFrame> Frames; // 0x20
        public Sentry.Internal.GrowableArray`1<Sentry.Internal.GrowableArray`1<int>> Stacks; // 0x30
        public System.Collections.Generic.List`1<Sentry.SentryThread> Threads; // 0x40

        // ── Methods ──
        public void WriteTo(){} // RVA: 0x7FFAC8B73E40
        public void .ctor(){} // RVA: 0x7FFAC8B743E0
    }

    public class SentryException : Object
    {
        public string Type; // 0x10
        public string Value; // 0x18
        public string Module; // 0x20
        public int ThreadId; // 0x28
        public Sentry.SentryStackTrace Stacktrace; // 0x30
        public Sentry.Protocol.Mechanism Mechanism; // 0x38

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void set_Type(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void get_Module(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Module(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ThreadId(){} // RVA: 0x7FFAC32EC4C0
        public void set_ThreadId(){} // RVA: 0x7FFAC369A6E0
        public void get_Stacktrace(){} // RVA: 0x7FFAC31D95E0
        public void set_Stacktrace(){} // RVA: 0x7FFAC2F4F890
        public void get_Mechanism(){} // RVA: 0x7FFAC31D0140
        public void set_Mechanism(){} // RVA: 0x7FFAC31D0C20
        public void WriteTo(){} // RVA: 0x7FFAC8B74AA0
        public void FromJson(){} // RVA: 0x7FFAC8B74EE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Trace : Object
    {
        public string SpanId;
        public Sentry.SpanId ParentSpanId; // 0x10
        public System.Nullable`1<Sentry.SpanId> TraceId; // 0x18
        public Sentry.SentryId Operation; // 0x28
        public string Origin; // 0x38
        public string Description; // 0x40
        public string Status; // 0x48
        public System.Nullable`1<0x6B199F50> IsSampled; // 0x50
        public System.Nullable`1<bool> <IsSampled>k__BackingField; // 0x58

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFAC2F3C380
        public void set_SpanId(){} // RVA: 0x7FFAC441EFB0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC35D3330
        public void set_ParentSpanId(){} // RVA: 0x7FFAC35D34F0
        public void get_TraceId(){} // RVA: 0x7FFAC3BCF020
        public void set_TraceId(){} // RVA: 0x7FFAC3BCC210
        public void get_Operation(){} // RVA: 0x7FFAC31D0140
        public void set_Operation(){} // RVA: 0x7FFAC31D0C20
        public void get_Origin(){} // RVA: 0x7FFAC2F9E740
        public void set_Origin(){} // RVA: 0x7FFAC8B757E0
        public void get_Description(){} // RVA: 0x7FFAC2F9C730
        public void set_Description(){} // RVA: 0x7FFAC2F9C740
        public void get_Status(){} // RVA: 0x7FFAC2FC20E0
        public void set_Status(){} // RVA: 0x7FFAC42499F0
        public void get_IsSampled(){} // RVA: 0x7FFAC8B64070
        public void set_IsSampled(){} // RVA: 0x7FFAC8B64080
        public void Clone(){} // RVA: 0x7FFAC8B758E0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Trace>.Clone(){} // RVA: 0x7FFAC8B75990
        public void UpdateFrom(){} // RVA: 0x7FFAC8B75A80
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x7FFAC8B75AD0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Trace>.UpdateFrom(){} // RVA: 0x7FFAC8B75B70
        public void WriteTo(){} // RVA: 0x7FFAC8B75DA0
        public void FromJson(){} // RVA: 0x7FFAC8B763E0
        public void .ctor(){} // RVA: 0x7FFAC8B76FE0
    }

}