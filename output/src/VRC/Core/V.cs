// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 6
// Methods: 83

namespace VRC.Core
{
    public class VRCCertificatePolicy : Object
    {
        public VRC.Core.VRCCertificatePolicy _m_CachedPtr;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81B3B730
        public void Equals(){} // RVA: 0x7FFE81B3BA70
        public void GetHashCode(){} // RVA: 0x7FFE81B3C000
        public void op_Implicit(){} // RVA: 0x7FFE81B3C1A0
        public void CompareBaseObjects(){} // RVA: 0x7FFE81B3C260
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81B3C2A0
        public void GetCachedPtr(){} // RVA: 0x7FFE81B3C6D0
        public void get_name(){} // RVA: 0x7FFE81B3CC50
        public void CheckValidationResult(){} // RVA: 0x7FFE81B3CCF0
        public void InitVRCCertificatePolicy(){} // RVA: 0x7FFE81B3D040
        public void Instantiate(){} // RVA: 0x7FFE81B3D1E0
        public void ToString(){} // RVA: 0x7FFE81B3D280
        public void GetHashCode_8886ED762426(){} // RVA: 0x7FFE81B3D1E0
        public void ToString_BCFF0FEDBF64(){} // RVA: 0x7FFE81B3D420
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE81B3D750
    }

    public class VRCEvent : ApiModel
    {
        public string _name; // 0x68
        public string _description; // 0x70
        public string _imageUrl; // 0x78
        public string _authorName; // 0x80
        public string _authorId; // 0x88
        public string _startTime; // 0x90
        public string _venueId; // 0x98

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_description(){} // RVA: 0x7FFE811C3590
        public void set_description(){} // RVA: 0x7FFE811C35A0
        public void get_imageUrl(){} // RVA: 0x7FFE81463AE0
        public void set_imageUrl(){} // RVA: 0x7FFE81464570
        public void get_authorName(){} // RVA: 0x7FFE81280C30
        public void set_authorName(){} // RVA: 0x7FFE81282380
        public void get_authorId(){} // RVA: 0x7FFE8113A010
        public void set_authorId(){} // RVA: 0x7FFE81280F90
        public void get_startTime(){} // RVA: 0x7FFE8154EB60
        public void set_startTime(){} // RVA: 0x7FFE818CE320
        public void get_venueId(){} // RVA: 0x7FFE817AE360
        public void set_venueId(){} // RVA: 0x7FFE8171B470
        public void .ctor(){} // RVA: 0x7FFE8A376010
        public void MakeEvents(){} // RVA: 0x7FFE8A3760B0
        public void ToString(){} // RVA: 0x7FFE8A376410
    }

    public class VRCLogger : Object
    {
        public bool _initialized;
        public Microsoft.Extensions.Logging.ILoggerFactory _runtimeLoggerFactory; // 0x8
        public 0x666CD904 _currentLoggingMode; // 0x10
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Microsoft.Extensions.Logging.ILogger> LoggerDictionary; // 0x18

        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x7FFE882168F0
        public void get_LogFileNamePrefix(){} // RVA: 0x7FFE88216960
        public void get_LogFilePath(){} // RVA: 0x7FFE882169C0
        public void get_GlobalLogger(){} // RVA: 0x7FFE88216B40
        public void add_OnMessageLogged(){} // RVA: 0x7FFE88216C50
        public void remove_OnMessageLogged(){} // RVA: 0x7FFE88216DA0
        public void IsLogPathValid(){} // RVA: 0x7FFE88216EF0
        public void OverrideLogFilePath(){} // RVA: 0x7FFE88217080
        public void InitializeZLogger(){} // RVA: 0x7FFE882173F0
        public void TeardownZLogger(){} // RVA: 0x7FFE882178D0
        public void FilterLogEntry(){} // RVA: 0x7FFE88217BD0
        public void UnityLogFormatPrefix(){} // RVA: 0x7FFE88217D20
        public void LogFileFormatPrefix(){} // RVA: 0x7FFE88217DD0
        public void HandleInterceptedMessage(){} // RVA: 0x7FFE88217EA0
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x7FFE88218020
        public void HandleZLoggerInternalException_File(){} // RVA: 0x7FFE882181A0
        public void SetLoggingMode(){} // RVA: 0x7FFE88218320
        public void GetCurrentLogLevel(){} // RVA: 0x7FFE88218380
        public void GetLogger(){} // RVA: 0x7FFE88218400
        public void RemoveStaleLogs(){} // RVA: 0x7FFE882186E0
        public void GenerateOutputLogFilename(){} // RVA: 0x7FFE88218960
        public void GetLogDirectory(){} // RVA: 0x7FFE88218BE0
        public void Log(){} // RVA: 0x7FFE88219280 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFE88219690 | overloaded x2
        public void LogError(){} // RVA: 0x7FFE88219AA0 | overloaded x2
        public void LogException(){} // RVA: 0x7FFE8821A000 | overloaded x2
        public void OnMain(){} // RVA: 0x7FFE8821A450 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8821A680
    }

    public class VRChatTestProtocol : Object
    {
        // ── Methods ──
        public void ReadLimitedString(){} // RVA: 0x7FFE8A38E770
        public void WriteLimitedString(){} // RVA: 0x7FFE8A38E8A0
        public void ReadToFileStream(){} // RVA: 0x7FFE8A38EA00
        public void ReadHello(){} // RVA: 0x7FFE8A38EF90
        public void WriteHello(){} // RVA: 0x7FFE8A38F0F0
        public void WriteSendWorld(){} // RVA: 0x7FFE8A38F1D0
        public void WriteSendAvatar(){} // RVA: 0x7FFE8A38F260
        public void WriteSendProp(){} // RVA: 0x7FFE8A38F350
        public void ReadWorldFileToStream(){} // RVA: 0x7FFE8A38F440
        public void ReadAvatarFileToStream(){} // RVA: 0x7FFE8A38F870
        public void ReadPropFileToStream(){} // RVA: 0x7FFE8A38FE00
        public void WriteHeartbeat(){} // RVA: 0x7FFE8A390390
        public void WriteError(){} // RVA: 0x7FFE8A3903C0
        public void ReadError(){} // RVA: 0x7FFE8A390450
        public void .cctor(){} // RVA: 0x7FFE8A3904B0
    }

    public class VTPFileSizeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A390630
    }

    public class VTPStringLimitException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3905D0
    }

}