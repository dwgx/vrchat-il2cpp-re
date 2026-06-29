// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol
// Classes: 16
// Methods: 338

namespace ThirdParty.Sentry.Sentry.Protocol
{
    public class App : Object
    {
        public object Type;
        public object _identifier;
        public object _startTime;
        public object _hash;
        public object _buildType;
        public object _name;
        public object _version;
        public object _build;
        public object _inForeground;

        // ── Methods ──
        public void get_Identifier(){} // RVA: 0xB5DBF0
        public void set_Identifier(){} // RVA: 0xB44D60
        public void get_StartTime(){} // RVA: 0x27D0660
        public void set_StartTime(){} // RVA: 0x28138D0
        public void get_Hash(){} // RVA: 0xD33E60
        public void set_Hash(){} // RVA: 0xB708C0
        public void get_BuildType(){} // RVA: 0xD05CA0
        public void set_BuildType(){} // RVA: 0xD09D70
        public void get_Name(){} // RVA: 0xBC1B30
        public void set_Name(){} // RVA: 0xB6A8C0
        public void get_Version(){} // RVA: 0xBBF8F0
        public void set_Version(){} // RVA: 0xBBF900
        public void get_Build(){} // RVA: 0xBE58B0
        public void set_Build(){} // RVA: 0xCA4DF0
        public void get_InForeground(){} // RVA: 0x6E3BE50
        public void set_InForeground(){} // RVA: 0x6E3BE60
        public void Clone(){} // RVA: 0x6E3BE70
        public void Sentry.Internal.ICloneable<Sentry.Protocol.App>.Clone(){} // RVA: 0x6E3BF20
        public void UpdateFrom(){} // RVA: 0x6E3C1A0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E3C1F0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.App>.UpdateFrom(){} // RVA: 0x6E3C260
        public void WriteTo(){} // RVA: 0x6E3C530
        public void FromJson(){} // RVA: 0x6E3CA70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Browser : Object
    {
        public object Type;
        public object _name;
        public object _version;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Version(){} // RVA: 0xB465B0
        public void set_Version(){} // RVA: 0xBA9BA0
        public void Clone(){} // RVA: 0x6E3D400
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Browser>.Clone(){} // RVA: 0x6E3D4B0
        public void UpdateFrom(){} // RVA: 0x6E3D5B0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E3D600
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Browser>.UpdateFrom(){} // RVA: 0x6E3D670
        public void WriteTo(){} // RVA: 0x6E3D760
        public void FromJson(){} // RVA: 0x6E3D980
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DebugImage : Object
    {
        public object _type;
        public object _imageAddress;
        public object _imageSize;
        public object _debugId;
        public object _debugChecksum;
        public object _debugFile;
        public object _codeId;
        public object _codeFile;
        public object _moduleVersionId;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB5DBF0
        public void set_Type(){} // RVA: 0xB44D60
        public void get_ImageAddress(){} // RVA: 0x125EE60
        public void set_ImageAddress(){} // RVA: 0x125D9D0
        public void get_ImageSize(){} // RVA: 0x19F92B0
        public void set_ImageSize(){} // RVA: 0x19F35A0
        public void get_DebugId(){} // RVA: 0xD05CA0
        public void set_DebugId(){} // RVA: 0xD09D70
        public void get_DebugChecksum(){} // RVA: 0xBC1B30
        public void set_DebugChecksum(){} // RVA: 0xB6A8C0
        public void get_DebugFile(){} // RVA: 0xBBF8F0
        public void set_DebugFile(){} // RVA: 0xBBF900
        public void get_CodeId(){} // RVA: 0xBE58B0
        public void set_CodeId(){} // RVA: 0xCA4DF0
        public void get_CodeFile(){} // RVA: 0xC0FFC0
        public void set_CodeFile(){} // RVA: 0xC0FFD0
        public void get_ModuleVersionId(){} // RVA: 0x6E3DC40
        public void set_ModuleVersionId(){} // RVA: 0x6E3DC60
        public void WriteTo(){} // RVA: 0x6E3DC70
        public void FromJson(){} // RVA: 0x6E3E350
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DebugMeta : Object
    {
        public object _images;

        // ── Methods ──
        public void get_Images(){} // RVA: 0xB5DBF0
        public void set_Images(){} // RVA: 0xB44D60
        public void WriteTo(){} // RVA: 0x6E3EC80
        public void FromJson(){} // RVA: 0x6E3ED80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Device : Object
    {
        public object Type;
        public object _timezone;
        public object _name;
        public object _manufacturer;
        public object _brand;
        public object _family;
        public object _model;
        public object _modelId;
        public object _architecture;
        public object _batteryLevel;
        public object _isCharging;
        public object _isOnline;
        public object _orientation;
        public object _simulator;
        public object _memorySize;
        public object _freeMemory;
        public object _usableMemory;
        public object _lowMemory;
        public object _storageSize;
        public object _freeStorage;
        public object _externalStorageSize;
        public object _externalFreeStorage;
        public object _screenResolution;
        public object _screenDensity;
        public object _screenDpi;
        public object _bootTime;
        public object _processorCount;
        public object _cpuDescription;
        public object _processorFrequency;
        public object _deviceType;
        public object _batteryStatus;
        public object _deviceUniqueIdentifier;
        public object _supportsVibration;
        public object _supportsAccelerometer;
        public object _supportsGyroscope;
        public object _supportsAudio;
        public object _supportsLocationService;

        // ── Methods ──
        public void get_Timezone(){} // RVA: 0xB5DBF0
        public void set_Timezone(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xBA9BA0
        public void get_Manufacturer(){} // RVA: 0xB700F0
        public void set_Manufacturer(){} // RVA: 0xB70100
        public void get_Brand(){} // RVA: 0xB70160
        public void set_Brand(){} // RVA: 0xB44DC0
        public void get_Family(){} // RVA: 0xD33E60
        public void set_Family(){} // RVA: 0xB708C0
        public void get_Model(){} // RVA: 0xD05CA0
        public void set_Model(){} // RVA: 0xD09D70
        public void get_ModelId(){} // RVA: 0xBC1B30
        public void set_ModelId(){} // RVA: 0xB6A8C0
        public void get_Architecture(){} // RVA: 0xBBF8F0
        public void set_Architecture(){} // RVA: 0xBBF900
        public void get_BatteryLevel(){} // RVA: 0xE32C80
        public void set_BatteryLevel(){} // RVA: 0xEEA060
        public void get_IsCharging(){} // RVA: 0x6E3F230
        public void set_IsCharging(){} // RVA: 0x6E3F240
        public void get_IsOnline(){} // RVA: 0x6E3F250
        public void set_IsOnline(){} // RVA: 0x6E3F260
        public void get_Orientation(){} // RVA: 0xC0FFC0
        public void set_Orientation(){} // RVA: 0xEA1CE0
        public void get_Simulator(){} // RVA: 0x4128940
        public void set_Simulator(){} // RVA: 0x6E3F270
        public void get_MemorySize(){} // RVA: 0x4127AD0
        public void set_MemorySize(){} // RVA: 0x4127F60
        public void get_FreeMemory(){} // RVA: 0x6296990
        public void set_FreeMemory(){} // RVA: 0x62969A0
        public void get_UsableMemory(){} // RVA: 0x6D099E0
        public void set_UsableMemory(){} // RVA: 0x6D099F0
        public void get_LowMemory(){} // RVA: 0x6E3F280
        public void set_LowMemory(){} // RVA: 0x6E3F290
        public void get_StorageSize(){} // RVA: 0x6BA2BC0
        public void set_StorageSize(){} // RVA: 0x6BA2BD0
        public void get_FreeStorage(){} // RVA: 0x131E8D0
        public void set_FreeStorage(){} // RVA: 0x131E370
        public void get_ExternalStorageSize(){} // RVA: 0x6E24D60
        public void set_ExternalStorageSize(){} // RVA: 0x6E24D70
        public void get_ExternalFreeStorage(){} // RVA: 0xC77E30
        public void set_ExternalFreeStorage(){} // RVA: 0xC77E40
        public void get_ScreenResolution(){} // RVA: 0xBC5B30
        public void set_ScreenResolution(){} // RVA: 0xBC5B40
        public void get_ScreenDensity(){} // RVA: 0xBC5BA0
        public void set_ScreenDensity(){} // RVA: 0x6A8AFA0
        public void get_ScreenDpi(){} // RVA: 0xBAE5A0
        public void set_ScreenDpi(){} // RVA: 0x6E3F2A0
        public void get_BootTime(){} // RVA: 0x6E3F2B0
        public void set_BootTime(){} // RVA: 0x6E3F2D0
        public void get_ProcessorCount(){} // RVA: 0xD9E3D0
        public void set_ProcessorCount(){} // RVA: 0x6E3F2F0
        public void get_CpuDescription(){} // RVA: 0xDA0520
        public void set_CpuDescription(){} // RVA: 0xD9D570
        public void get_ProcessorFrequency(){} // RVA: 0x114AC20
        public void set_ProcessorFrequency(){} // RVA: 0x6E3F300
        public void get_DeviceType(){} // RVA: 0xE3C930
        public void set_DeviceType(){} // RVA: 0xE3D020
        public void get_BatteryStatus(){} // RVA: 0x135EDB0
        public void set_BatteryStatus(){} // RVA: 0x1658000
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x135A170
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x1365A40
        public void get_SupportsVibration(){} // RVA: 0x6E3F310
        public void set_SupportsVibration(){} // RVA: 0x6E3F320
        public void get_SupportsAccelerometer(){} // RVA: 0x6E3F330
        public void set_SupportsAccelerometer(){} // RVA: 0x6E3F340
        public void get_SupportsGyroscope(){} // RVA: 0x6E3F350
        public void set_SupportsGyroscope(){} // RVA: 0x6E3F360
        public void get_SupportsAudio(){} // RVA: 0x6E3F370
        public void set_SupportsAudio(){} // RVA: 0x6E3F380
        public void get_SupportsLocationService(){} // RVA: 0x6E3F390
        public void set_SupportsLocationService(){} // RVA: 0x6E3F3A0
        public void Clone(){} // RVA: 0x6E3F3B0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Device>.Clone(){} // RVA: 0x6E3F460
        public void UpdateFrom(){} // RVA: 0x6E3FA60
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E3FAB0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Device>.UpdateFrom(){} // RVA: 0x6E3FB20
        public void WriteTo(){} // RVA: 0x6E403B0
        public void TryParseTimezone(){} // RVA: 0x6E41C00
        public void FromJson(){} // RVA: 0x6E41F10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Gpu : Object
    {
        public object Type;
        public object _name;
        public object _id;
        public object _vendorId;
        public object _vendorName;
        public object _memorySize;
        public object _apiType;
        public object _multiThreadedRendering;
        public object _version;
        public object _npotSupport;
        public object _maxTextureSize;
        public object _graphicsShaderLevel;
        public object _supportsDrawCallInstancing;
        public object _supportsRayTracing;
        public object _supportsComputeShaders;
        public object _supportsGeometryShaders;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Id(){} // RVA: 0xB465B0
        public void set_Id(){} // RVA: 0x15428E0
        public void get_VendorId(){} // RVA: 0xB700F0
        public void set_VendorId(){} // RVA: 0xB70100
        public void get_VendorName(){} // RVA: 0xB70160
        public void set_VendorName(){} // RVA: 0xB44DC0
        public void get_MemorySize(){} // RVA: 0xD33E60
        public void set_MemorySize(){} // RVA: 0x27FA7C0
        public void get_ApiType(){} // RVA: 0xD05CA0
        public void set_ApiType(){} // RVA: 0xD09D70
        public void get_MultiThreadedRendering(){} // RVA: 0x5006610
        public void set_MultiThreadedRendering(){} // RVA: 0x6DEFD20
        public void get_Version(){} // RVA: 0xBBF8F0
        public void set_Version(){} // RVA: 0xBBF900
        public void get_NpotSupport(){} // RVA: 0xBE58B0
        public void set_NpotSupport(){} // RVA: 0xCA4DF0
        public void get_MaxTextureSize(){} // RVA: 0xC0FFC0
        public void set_MaxTextureSize(){} // RVA: 0xEA1CE0
        public void get_GraphicsShaderLevel(){} // RVA: 0xBE2C60
        public void set_GraphicsShaderLevel(){} // RVA: 0xBE2C70
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x4128620
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x4128630
        public void get_SupportsRayTracing(){} // RVA: 0x6E44470
        public void set_SupportsRayTracing(){} // RVA: 0x6E44480
        public void get_SupportsComputeShaders(){} // RVA: 0x4264D60
        public void set_SupportsComputeShaders(){} // RVA: 0x4264D70
        public void get_SupportsGeometryShaders(){} // RVA: 0x6E44490
        public void set_SupportsGeometryShaders(){} // RVA: 0x6E444A0
        public void Clone(){} // RVA: 0x6E444B0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Gpu>.Clone(){} // RVA: 0x6E44560
        public void UpdateFrom(){} // RVA: 0x6E44850
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E448A0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Gpu>.UpdateFrom(){} // RVA: 0x6E44910
        public void WriteTo(){} // RVA: 0x6E44CE0
        public void FromJson(){} // RVA: 0x6E45730
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ITraceContext
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x87C0A0
        public void get_ParentSpanId(){} // RVA: 0x87BEB0
        public void get_TraceId(){} // RVA: 0x87BEB0
        public void get_Operation(){} // RVA: 0x87C0A0
        public void get_Description(){} // RVA: 0x87C0A0
        public void get_Status(){} // RVA: 0x87C0A0
        public void get_IsSampled(){} // RVA: 0x87C100
    }

    public class Measurement : Object
    {
        public object _value;
        public object _unit;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void get_Unit(){} // RVA: 0x125EE60
        public void .ctor(){} // RVA: 0x6E46A50
        public void WriteTo(){} // RVA: 0x6E46B30
        public void FromJson(){} // RVA: 0x6E46FE0
    }

    public class Mechanism : Object
    {
        public object HandledKey;
        public object MechanismKey;
        public object DescriptionKey;
        public object _internalData;
        public object _internalMeta;
        public object DefaultType;
        public object _type;
        public object _description;
        public object _source;
        public object _helpLink;
        public object _handled;
        public object _synthetic;
        public object _isExceptionGroup;
        public object _exceptionId;
        public object _parentId;

        // ── Methods ──
        public void get_InternalData(){} // RVA: 0xB5DBF0
        public void set_InternalData(){} // RVA: 0xB44D60
        public void get_InternalMeta(){} // RVA: 0xB465B0
        public void set_InternalMeta(){} // RVA: 0xBA9BA0
        public void get_Type(){} // RVA: 0xB700F0
        public void set_Type(){} // RVA: 0x6E473B0
        public void get_Description(){} // RVA: 0xB70160
        public void set_Description(){} // RVA: 0xB44DC0
        public void get_Source(){} // RVA: 0xD33E60
        public void set_Source(){} // RVA: 0xB708C0
        public void get_HelpLink(){} // RVA: 0xD05CA0
        public void set_HelpLink(){} // RVA: 0xD09D70
        public void get_Handled(){} // RVA: 0x5006610
        public void set_Handled(){} // RVA: 0x6DEFD20
        public void get_Synthetic(){} // RVA: 0xEEA480
        public void set_Synthetic(){} // RVA: 0xEEA470
        public void get_IsExceptionGroup(){} // RVA: 0x1DE3FA0
        public void set_IsExceptionGroup(){} // RVA: 0x23E2280
        public void get_ExceptionId(){} // RVA: 0x6E474D0
        public void set_ExceptionId(){} // RVA: 0x6E474E0
        public void get_ParentId(){} // RVA: 0x412F510
        public void set_ParentId(){} // RVA: 0x412F520
        public void get_Meta(){} // RVA: 0x6E474F0
        public void get_Data(){} // RVA: 0x6E475B0
        public void WriteTo(){} // RVA: 0x6E47670
        public void FromJson(){} // RVA: 0x6E47D30
        public void IsDefaultOrEmpty(){} // RVA: 0x6E48930
        public void .ctor(){} // RVA: 0x6E48A80
        public void .cctor(){} // RVA: 0x6E48B10
    }

    public class OperatingSystem : Object
    {
        public object Type;
        public object _name;
        public object _version;
        public object _rawDescription;
        public object _build;
        public object _kernelVersion;
        public object _rooted;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Version(){} // RVA: 0xB465B0
        public void set_Version(){} // RVA: 0xBA9BA0
        public void get_RawDescription(){} // RVA: 0xB700F0
        public void set_RawDescription(){} // RVA: 0xB70100
        public void get_Build(){} // RVA: 0xB70160
        public void set_Build(){} // RVA: 0xB44DC0
        public void get_KernelVersion(){} // RVA: 0xD33E60
        public void set_KernelVersion(){} // RVA: 0xB708C0
        public void get_Rooted(){} // RVA: 0x4FF64C0
        public void set_Rooted(){} // RVA: 0x6E48CC0
        public void Clone(){} // RVA: 0x6E48CD0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.OperatingSystem>.Clone(){} // RVA: 0x6E48D80
        public void UpdateFrom(){} // RVA: 0x6E48F80
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E48FD0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.OperatingSystem>.UpdateFrom(){} // RVA: 0x6E49040
        public void WriteTo(){} // RVA: 0x6E49280
        public void FromJson(){} // RVA: 0x6E496A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ProfileInfo : Object
    {
        public object _eventId;
        public object _debugMeta;
        public object _contexts;
        public object _profile;
        public object _startTimestamp;
        public object _environment;
        public object _platform;
        public object _release;
        public object _transaction;

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x22343B0
        public void set_EventId(){} // RVA: 0x22343C0
        public void get_DebugMeta(){} // RVA: 0xB700F0
        public void set_DebugMeta(){} // RVA: 0xB70100
        public void get_Contexts(){} // RVA: 0xB70160
        public void set_Contexts(){} // RVA: 0x6E49DB0
        public void get_Profile(){} // RVA: 0xD33E60
        public void set_Profile(){} // RVA: 0xB708C0
        public void get_StartTimestamp(){} // RVA: 0x2237C00
        public void set_StartTimestamp(){} // RVA: 0x27FA8A0
        public void get_Environment(){} // RVA: 0xBBF8F0
        public void set_Environment(){} // RVA: 0xBBF900
        public void get_Platform(){} // RVA: 0xBE58B0
        public void set_Platform(){} // RVA: 0xCA4DF0
        public void get_Release(){} // RVA: 0xC0FFC0
        public void set_Release(){} // RVA: 0xC0FFD0
        public void get_Transaction(){} // RVA: 0xBE2C60
        public void set_Transaction(){} // RVA: 0xBE2C70
        public void WriteTo(){} // RVA: 0x6E49DD0
        public void .ctor(){} // RVA: 0x6E4AA90
    }

    public class Response : Object
    {
        public object Type;
        public object _internalHeaders;
        public object _bodySize;
        public object _cookies;
        public object _data;
        public object _statusCode;

        // ── Methods ──
        public void get_InternalHeaders(){} // RVA: 0xB5DBF0
        public void set_InternalHeaders(){} // RVA: 0xB44D60
        public void get_BodySize(){} // RVA: 0x125EE60
        public void set_BodySize(){} // RVA: 0x125D9D0
        public void get_Cookies(){} // RVA: 0xB70160
        public void set_Cookies(){} // RVA: 0xB44DC0
        public void get_Data(){} // RVA: 0xD33E60
        public void set_Data(){} // RVA: 0xB708C0
        public void get_Headers(){} // RVA: 0x6E4AE40
        public void get_StatusCode(){} // RVA: 0x18A0130
        public void set_StatusCode(){} // RVA: 0x189D3F0
        public void AddHeaders(){} // RVA: 0x6E4AF00
        public void Clone(){} // RVA: 0x6E4B1F0
        public void UpdateFrom(){} // RVA: 0x6E4B3F0
        public void WriteTo(){} // RVA: 0x6E4B460
        public void FromJson(){} // RVA: 0x6E4B900
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Runtime : Object
    {
        public object Type;
        public object _name;
        public object _version;
        public object _rawDescription;
        public object _identifier;
        public object _build;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Version(){} // RVA: 0xB465B0
        public void set_Version(){} // RVA: 0xBA9BA0
        public void get_RawDescription(){} // RVA: 0xB700F0
        public void set_RawDescription(){} // RVA: 0xB70100
        public void get_Identifier(){} // RVA: 0xB70160
        public void set_Identifier(){} // RVA: 0xB44DC0
        public void get_Build(){} // RVA: 0xD33E60
        public void set_Build(){} // RVA: 0xB708C0
        public void Clone(){} // RVA: 0x6E4BED0
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Runtime>.Clone(){} // RVA: 0x6E4BF80
        public void UpdateFrom(){} // RVA: 0x6E4C170
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E4C1C0
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Runtime>.UpdateFrom(){} // RVA: 0x6E4C230
        public void WriteTo(){} // RVA: 0x6E4C440
        public void FromJson(){} // RVA: 0x6E4C800
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SampleProfile : Object
    {
        public object Samples;
        public object Frames;
        public object Stacks;
        public object Threads;

        // ── Methods ──
        public void WriteTo(){} // RVA: 0x6E4CE10
        public void .ctor(){} // RVA: 0x6E4D410
    }

    public class SentryException : Object
    {
        public object _type;
        public object _value;
        public object _module;
        public object _threadId;
        public object _stacktrace;
        public object _mechanism;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB5DBF0
        public void set_Type(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void get_Module(){} // RVA: 0xB700F0
        public void set_Module(){} // RVA: 0xB70100
        public void get_ThreadId(){} // RVA: 0x1065D50
        public void set_ThreadId(){} // RVA: 0x13233D0
        public void get_Stacktrace(){} // RVA: 0xD33E60
        public void set_Stacktrace(){} // RVA: 0xB708C0
        public void get_Mechanism(){} // RVA: 0xD05CA0
        public void set_Mechanism(){} // RVA: 0xD09D70
        public void WriteTo(){} // RVA: 0x6E4DAF0
        public void FromJson(){} // RVA: 0x6E4E050
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Trace : Object
    {
        public object Type;
        public object _spanId;
        public object _parentSpanId;
        public object _traceId;
        public object _operation;
        public object _origin;
        public object _description;
        public object _status;
        public object _isSampled;

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0xB5DBF0
        public void set_SpanId(){} // RVA: 0x2230E30
        public void get_ParentSpanId(){} // RVA: 0x125EE60
        public void set_ParentSpanId(){} // RVA: 0x125D9D0
        public void get_TraceId(){} // RVA: 0x19F92B0
        public void set_TraceId(){} // RVA: 0x19F35A0
        public void get_Operation(){} // RVA: 0xD05CA0
        public void set_Operation(){} // RVA: 0xD09D70
        public void get_Origin(){} // RVA: 0xBC1B30
        public void set_Origin(){} // RVA: 0x6E4E950
        public void get_Description(){} // RVA: 0xBBF8F0
        public void set_Description(){} // RVA: 0xBBF900
        public void get_Status(){} // RVA: 0xBE58B0
        public void set_Status(){} // RVA: 0xE9E640
        public void get_IsSampled(){} // RVA: 0x6E3BE50
        public void set_IsSampled(){} // RVA: 0x6E3BE60
        public void Clone(){} // RVA: 0x6E4EA50
        public void Sentry.Internal.ICloneable<Sentry.Protocol.Trace>.Clone(){} // RVA: 0x6E4EB00
        public void UpdateFrom(){} // RVA: 0x6E4EBF0
        public void Sentry.Internal.IUpdatable.UpdateFrom(){} // RVA: 0x6E4EC40
        public void Sentry.Internal.IUpdatable<Sentry.Protocol.Trace>.UpdateFrom(){} // RVA: 0x6E4ECD0
        public void WriteTo(){} // RVA: 0x6E4EF60
        public void FromJson(){} // RVA: 0x6E4F6B0
        public void .ctor(){} // RVA: 0x6E502B0
    }

}