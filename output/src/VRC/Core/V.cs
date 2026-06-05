// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 6
// Methods: 85

namespace VRC.Core
{
    public class VRCCertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult_564ED10A9526(){} // RVA: 0x7FFAF382CF40
        public void .ctor_C0C3457DE94F(){} // RVA: 0x7FFAF382CFE0
        public void InitVRCCertificatePolicy(){} // RVA: 0x7FFAF382D0A0
        public void op_Implicit(){} // RVA: 0x7FFAF382D5F0
        public void CompareBaseObjects(){} // RVA: 0x7FFAF382D630
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAF382D960
        public void GetCachedPtr(){} // RVA: 0x7FFAF382DA00
        public void get_name(){} // RVA: 0x7FFAF382DAA0
        public void set_name(){} // RVA: 0x7FFAF382DDE0
        public void Instantiate(){} // RVA: 0x7FFAF382E130
        public void InitVRCCertificatePolicy_DF1DE68A6BB2(){} // RVA: 0x7FFAF382E460
        public void CheckValidationResult(){} // RVA: 0x7FFAF382E790
        public void GetHashCode(){} // RVA: 0x7FFAF382EAE0
        public void ToString(){} // RVA: 0x7FFAF382EB20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Initialize(){} // RVA: 0x7FFAF382F4E0
        // ── Unresolved (hash) ──
        public void m_914(){} // RVA: 0x7FFAF382EF50
        public void m_BE9(){} // RVA: 0x7FFAF382F830
    }

    public class VRCEvent
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_description(){} // RVA: 0x7FFAF2E55590
        public void set_description(){} // RVA: 0x7FFAF2E555A0
        public void get_imageUrl(){} // RVA: 0x7FFAF2F77C50
        public void set_imageUrl(){} // RVA: 0x7FFAF2F734F0
        public void get_authorName(){} // RVA: 0x7FFAF2F12D00
        public void set_authorName(){} // RVA: 0x7FFAF2F14450
        public void get_authorId(){} // RVA: 0x7FFAF2DCC010
        public void set_authorId(){} // RVA: 0x7FFAF2F13060
        public void get_startTime(){} // RVA: 0x7FFAF3246DE0
        public void set_startTime(){} // RVA: 0x7FFAF3604600
        public void get_venueId(){} // RVA: 0x7FFAF34CC8C0
        public void set_venueId(){} // RVA: 0x7FFAF345A650
        public void .ctor(){} // RVA: 0x7FFAFC3C9570
        public void MakeEvents(){} // RVA: 0x7FFAFC3C9610
        public void ToString(){} // RVA: 0x7FFAFC3C9970
    }

    public class VRCLogger
    {
        public object _isPathOverridden;

        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x7FFAFA1897D0
        public void get_LogFileNamePrefix(){} // RVA: 0x7FFAFA189840
        public void get_LogFilePath(){} // RVA: 0x7FFAFA1898A0
        public void get_GlobalLogger(){} // RVA: 0x7FFAFA189A20
        public void add_OnMessageLogged(){} // RVA: 0x7FFAFA189B30
        public void remove_OnMessageLogged(){} // RVA: 0x7FFAFA189C80
        public void IsLogPathValid(){} // RVA: 0x7FFAFA189DD0
        public void OverrideLogFilePath(){} // RVA: 0x7FFAFA189F60
        public void InitializeZLogger(){} // RVA: 0x7FFAFA18A2D0
        public void TeardownZLogger(){} // RVA: 0x7FFAFA18A7B0
        public void FilterLogEntry(){} // RVA: 0x7FFAFA18AAB0
        public void UnityLogFormatPrefix(){} // RVA: 0x7FFAFA18AC00
        public void LogFileFormatPrefix(){} // RVA: 0x7FFAFA18ACB0
        public void HandleInterceptedMessage(){} // RVA: 0x7FFAFA18AD80
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x7FFAFA18AF00
        public void HandleZLoggerInternalException_File(){} // RVA: 0x7FFAFA18B080
        public void SetLoggingMode(){} // RVA: 0x7FFAFA18B200
        public void GetCurrentLogLevel(){} // RVA: 0x7FFAFA18B260
        public void GetLogger(){} // RVA: 0x7FFAFA18B2E0
        public void RemoveStaleLogs(){} // RVA: 0x7FFAFA18B5C0
        public void GenerateOutputLogFilename(){} // RVA: 0x7FFAFA18B840
        public void GetLogDirectory(){} // RVA: 0x7FFAFA18BAC0
        public void Log(){} // RVA: 0x7FFAFA18C160 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFAFA18C570 | overloaded x2
        public void LogError(){} // RVA: 0x7FFAFA18C980 | overloaded x2
        public void LogException(){} // RVA: 0x7FFAFA18CEE0 | overloaded x2
        public void OnMain(){} // RVA: 0x7FFAFA18D330 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAFA18D560
    }

    public class VRChatTestProtocol
    {
        // ── Methods ──
        public void ReadLimitedString(){} // RVA: 0x7FFAFC3E2580
        public void WriteLimitedString(){} // RVA: 0x7FFAFC3E26B0
        public void ReadToFileStream(){} // RVA: 0x7FFAFC3E2810
        public void ReadHello(){} // RVA: 0x7FFAFC3E2DA0
        public void WriteHello(){} // RVA: 0x7FFAFC3E2F00
        public void WriteSendWorld(){} // RVA: 0x7FFAFC3E2FE0
        public void WriteSendAvatar(){} // RVA: 0x7FFAFC3E3070
        public void WriteSendProp(){} // RVA: 0x7FFAFC3E3160
        public void ReadWorldFileToStream(){} // RVA: 0x7FFAFC3E3250
        public void ReadAvatarFileToStream(){} // RVA: 0x7FFAFC3E3680
        public void ReadPropFileToStream(){} // RVA: 0x7FFAFC3E3C10
        public void WriteHeartbeat(){} // RVA: 0x7FFAFC3E41A0
        public void WriteError(){} // RVA: 0x7FFAFC3E41D0
        public void ReadError(){} // RVA: 0x7FFAFC3E4260
        public void .cctor(){} // RVA: 0x7FFAFC3E42C0
    }

    public class VTPFileSizeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3E4440
    }

    public class VTPStringLimitException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3E43E0
    }

}