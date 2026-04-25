// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 6
// Methods: 84

namespace VRC.Core
{
    public class VRCCertificatePolicy : Object
    {
        public VRC.Core.VRCCertificatePolicy _vRCCertificatePolicy;
        public System.Net.ICertificatePolicy ÎÌÎÍÍÎÏÏÍÍÎÍÌÌÌÏÎÍÏÍÏÍÎ; // 0x8

        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7FFAC39DEDD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC39DF120
        public void op_Implicit(){} // RVA: 0x7FFAC39DF450
        public void CompareBaseObjects(){} // RVA: 0x7FFAC39DF880
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC39DF8C0
        public void GetCachedPtr(){} // RVA: 0x7FFAC39DFBF0
        public void get_name(){} // RVA: 0x7FFAC39DFCB0
        public void set_name(){} // RVA: 0x7FFAC39E0240
        public void Instantiate(){} // RVA: 0x7FFAC39E02E0
        public void InitVRCCertificatePolicy(){} // RVA: 0x7FFAC39E0610
        public void Equals(){} // RVA: 0x7FFAC39E07B0
        public void GetHashCode(){} // RVA: 0x7FFAC39E07F0
        public void ToString(){} // RVA: 0x7FFAC39E0990
        public void ToString_E009047AABDC(){} // RVA: 0x7FFAC39E0BC0
        public void InvokeComponentAction(){} // RVA: 0x7FFAC39E0C60
        public void IsInternalComponentActive(){} // RVA: 0x7FFAC39E0D00
    }

    public class VRCEvent : ApiModel
    {
        public string name; // 0x68
        public string description; // 0x70
        public string imageUrl; // 0x78
        public string authorName; // 0x80
        public string authorId; // 0x88
        public string startTime; // 0x90
        public string venueId; // 0x98

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_description(){} // RVA: 0x7FFAC2FE9590
        public void set_description(){} // RVA: 0x7FFAC2FE95A0
        public void get_imageUrl(){} // RVA: 0x7FFAC30E5600
        public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
        public void get_authorName(){} // RVA: 0x7FFAC32EF410
        public void set_authorName(){} // RVA: 0x7FFAC34D4AA0
        public void get_authorId(){} // RVA: 0x7FFAC2F60010
        public void set_authorId(){} // RVA: 0x7FFAC354E300
        public void get_startTime(){} // RVA: 0x7FFAC32EF640
        public void set_startTime(){} // RVA: 0x7FFAC354E360
        public void get_venueId(){} // RVA: 0x7FFAC354DFB0
        public void set_venueId(){} // RVA: 0x7FFAC354E3C0
        public void .ctor(){} // RVA: 0x7FFACBF15930
        public void MakeEvents(){} // RVA: 0x7FFACBF159D0
        public void ToString(){} // RVA: 0x7FFACBF15D30
    }

    public class VRCLogger : Object
    {
        public bool IsPathOverridden;
        public Microsoft.Extensions.Logging.ILoggerFactory LogFileNamePrefix; // 0x8
        public 0x6B2D2DB0 LogFilePath; // 0x10
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Microsoft.Extensions.Logging.ILogger> GlobalLogger; // 0x18
        public string _logFilePathOverride; // 0x20
        public System.Lazy`1<string> <LogFileNamePrefix>k__BackingField; // 0x28
        public Microsoft.Extensions.Logging.ILogger _globalLogger; // 0x30
        public VRC.Core.ZLoggerHandlerLogger _zLoggerHandler; // 0x38
        public ZLogger.MessageTemplateHandler UnityLogPrefixFormat; // 0x40
        public ZLogger.MessageTemplateHandler LogFilePrefixFormat; // 0x50
        public LogCallback OnMessageLogged; // 0x60

        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x7FFAC9E63F80
        public void get_LogFileNamePrefix(){} // RVA: 0x7FFAC9E63FF0
        public void get_LogFilePath(){} // RVA: 0x7FFAC9E64050
        public void get_GlobalLogger(){} // RVA: 0x7FFAC9E641D0
        public void add_OnMessageLogged(){} // RVA: 0x7FFAC9E642E0
        public void remove_OnMessageLogged(){} // RVA: 0x7FFAC9E64430
        public void IsLogPathValid(){} // RVA: 0x7FFAC9E64580
        public void OverrideLogFilePath(){} // RVA: 0x7FFAC9E64710
        public void InitializeZLogger(){} // RVA: 0x7FFAC9E64A80
        public void TeardownZLogger(){} // RVA: 0x7FFAC9E64F60
        public void FilterLogEntry(){} // RVA: 0x7FFAC9E65260
        public void UnityLogFormatPrefix(){} // RVA: 0x7FFAC9E653B0
        public void LogFileFormatPrefix(){} // RVA: 0x7FFAC9E65460
        public void HandleInterceptedMessage(){} // RVA: 0x7FFAC9E65530
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x7FFAC9E656B0
        public void HandleZLoggerInternalException_File(){} // RVA: 0x7FFAC9E65830
        public void SetLoggingMode(){} // RVA: 0x7FFAC9E659B0
        public void GetCurrentLogLevel(){} // RVA: 0x7FFAC9E65A10
        public void GetLogger(){} // RVA: 0x7FFAC9E65A90
        public void RemoveStaleLogs(){} // RVA: 0x7FFAC9E65D70
        public void GenerateOutputLogFilename(){} // RVA: 0x7FFAC9E65FF0
        public void GetLogDirectory(){} // RVA: 0x7FFAC9E66270
        public void Log(){} // RVA: 0x7FFAC9E66910 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFAC9E66D20 | overloaded x2
        public void LogError(){} // RVA: 0x7FFAC9E67130 | overloaded x2
        public void LogException(){} // RVA: 0x7FFAC9E67690 | overloaded x2
        public void OnMain(){} // RVA: 0x7FFAC9E67AE0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9E67D10
    }

    public class VRChatTestProtocol : Object
    {
        public int Port;
        public System.TimeSpan HeartbeatInterval; // 0x8
        public System.TimeSpan TimeoutInterval; // 0x10
        public int MaxStringLength;
        public int MaxFileSize;
        public int Version;

        // ── Methods ──
        public void ReadLimitedString(){} // RVA: 0x7FFACBF2DEA0
        public void WriteLimitedString(){} // RVA: 0x7FFACBF2DFD0
        public void ReadToFileStream(){} // RVA: 0x7FFACBF2E130
        public void ReadHello(){} // RVA: 0x7FFACBF2E6C0
        public void WriteHello(){} // RVA: 0x7FFACBF2E820
        public void WriteSendWorld(){} // RVA: 0x7FFACBF2E900
        public void WriteSendAvatar(){} // RVA: 0x7FFACBF2E990
        public void WriteSendProp(){} // RVA: 0x7FFACBF2EA80
        public void ReadWorldFileToStream(){} // RVA: 0x7FFACBF2EB70
        public void ReadAvatarFileToStream(){} // RVA: 0x7FFACBF2EFA0
        public void ReadPropFileToStream(){} // RVA: 0x7FFACBF2F530
        public void WriteHeartbeat(){} // RVA: 0x7FFACBF2FAC0
        public void WriteError(){} // RVA: 0x7FFACBF2FAF0
        public void ReadError(){} // RVA: 0x7FFACBF2FB80
        public void .cctor(){} // RVA: 0x7FFACBF2FBE0
    }

    public class VTPFileSizeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF2FD60
    }

    public class VTPStringLimitException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF2FD00
    }

}