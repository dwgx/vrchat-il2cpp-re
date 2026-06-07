// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 6
// Methods: 85

namespace VRC.Core
{
    public class VRCCertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult_564ED10A9526(){} // RVA: 0xD7CF40
        public void .ctor_C0C3457DE94F(){} // RVA: 0xD7CFE0
        public void InitVRCCertificatePolicy(){} // RVA: 0xD7D0A0
        public void op_Implicit(){} // RVA: 0xD7D5F0
        public void CompareBaseObjects(){} // RVA: 0xD7D630
        public void IsNativeObjectAlive(){} // RVA: 0xD7D960
        public void GetCachedPtr(){} // RVA: 0xD7DA00
        public void get_name(){} // RVA: 0xD7DAA0
        public void set_name(){} // RVA: 0xD7DDE0
        public void Instantiate(){} // RVA: 0xD7E130
        public void InitVRCCertificatePolicy_DF1DE68A6BB2(){} // RVA: 0xD7E460
        public void CheckValidationResult(){} // RVA: 0xD7E790
        public void GetHashCode(){} // RVA: 0xD7EAE0
        public void ToString(){} // RVA: 0xD7EB20
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0xD7F4E0
        // ── Unresolved (hash) ──
        public void m_914(){} // RVA: 0xD7EF50
        public void m_BE9(){} // RVA: 0xD7F830
    }

    public class VRCEvent
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_description(){} // RVA: 0x3A5590
        public void set_description(){} // RVA: 0x3A55A0
        public void get_imageUrl(){} // RVA: 0x4C7C50
        public void set_imageUrl(){} // RVA: 0x4C34F0
        public void get_authorName(){} // RVA: 0x462D00
        public void set_authorName(){} // RVA: 0x464450
        public void get_authorId(){} // RVA: 0x31C010
        public void set_authorId(){} // RVA: 0x463060
        public void get_startTime(){} // RVA: 0x796DE0
        public void set_startTime(){} // RVA: 0xB54600
        public void get_venueId(){} // RVA: 0xA1C8C0
        public void set_venueId(){} // RVA: 0x9AA650
        public void .ctor(){} // RVA: 0x9919570
        public void MakeEvents(){} // RVA: 0x9919610
        public void ToString(){} // RVA: 0x9919970
    }

    public class VRCLogger
    {
        public object _isPathOverridden;

        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x76D97D0
        public void get_LogFileNamePrefix(){} // RVA: 0x76D9840
        public void get_LogFilePath(){} // RVA: 0x76D98A0
        public void get_GlobalLogger(){} // RVA: 0x76D9A20
        public void add_OnMessageLogged(){} // RVA: 0x76D9B30
        public void remove_OnMessageLogged(){} // RVA: 0x76D9C80
        public void IsLogPathValid(){} // RVA: 0x76D9DD0
        public void OverrideLogFilePath(){} // RVA: 0x76D9F60
        public void InitializeZLogger(){} // RVA: 0x76DA2D0
        public void TeardownZLogger(){} // RVA: 0x76DA7B0
        public void FilterLogEntry(){} // RVA: 0x76DAAB0
        public void UnityLogFormatPrefix(){} // RVA: 0x76DAC00
        public void LogFileFormatPrefix(){} // RVA: 0x76DACB0
        public void HandleInterceptedMessage(){} // RVA: 0x76DAD80
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x76DAF00
        public void HandleZLoggerInternalException_File(){} // RVA: 0x76DB080
        public void SetLoggingMode(){} // RVA: 0x76DB200
        public void GetCurrentLogLevel(){} // RVA: 0x76DB260
        public void GetLogger(){} // RVA: 0x76DB2E0
        public void RemoveStaleLogs(){} // RVA: 0x76DB5C0
        public void GenerateOutputLogFilename(){} // RVA: 0x76DB840
        public void GetLogDirectory(){} // RVA: 0x76DBAC0
        public void Log(){} // RVA: 0x76DC160 | overloaded x2
        public void LogWarning(){} // RVA: 0x76DC570 | overloaded x2
        public void LogError(){} // RVA: 0x76DC980 | overloaded x2
        public void LogException(){} // RVA: 0x76DCEE0 | overloaded x2
        public void OnMain(){} // RVA: 0x76DD330 | overloaded x2
        public void .cctor(){} // RVA: 0x76DD560
    }

    public class VRChatTestProtocol
    {
        // ── Methods ──
        public void ReadLimitedString(){} // RVA: 0x9932580
        public void WriteLimitedString(){} // RVA: 0x99326B0
        public void ReadToFileStream(){} // RVA: 0x9932810
        public void ReadHello(){} // RVA: 0x9932DA0
        public void WriteHello(){} // RVA: 0x9932F00
        public void WriteSendWorld(){} // RVA: 0x9932FE0
        public void WriteSendAvatar(){} // RVA: 0x9933070
        public void WriteSendProp(){} // RVA: 0x9933160
        public void ReadWorldFileToStream(){} // RVA: 0x9933250
        public void ReadAvatarFileToStream(){} // RVA: 0x9933680
        public void ReadPropFileToStream(){} // RVA: 0x9933C10
        public void WriteHeartbeat(){} // RVA: 0x99341A0
        public void WriteError(){} // RVA: 0x99341D0
        public void ReadError(){} // RVA: 0x9934260
        public void .cctor(){} // RVA: 0x99342C0
    }

    public class VTPFileSizeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9934440
    }

    public class VTPStringLimitException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99343E0
    }

}