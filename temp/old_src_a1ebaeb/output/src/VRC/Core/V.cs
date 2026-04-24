// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 67

namespace VRC.Core
{
    public class VRCCertificatePolicy : Object
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9409f00
        public void op_Implicit(){} // RVA: 0x7ffaa940a270
        public void CompareBaseObjects(){} // RVA: 0x7ffaa940a330
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa940a760
        public void InitVRCCertificatePolicy(){} // RVA: 0x7ffaa940a800
        public void get_name(){} // RVA: 0x7ffaa940ad50
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Instantiate(){} // RVA: 0x7ffaa940b6f0
        public void ToString(){} // RVA: 0x7ffaa940ba30
        public void ProcessCertificateValidation(){} // RVA: 0x7ffaa940c590
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa9409bb0
        public void GetHashCode(){} // RVA: 0x7ffaa9409f40
        public void GetTransform_25E(){} // RVA: 0x7ffaa940b2e0
        public void CheckValidationResult(){} // RVA: 0x7ffaa940b3a0
        public void SetCurrentCertificatePolicy(){} // RVA: 0x7ffaa940c4f0
        // ── Obfuscated Methods ──
        public void m_E27(){} // RVA: 0x7ffaa940be50
        public void m_E7E(){} // RVA: 0x7ffaa940c190
    }

    public class VRCEvent : ApiModel
    {
        public object _imageUrl; // 0x373B0EA0, was: <imageUrl>k__BackingField
        public object _startTime; // 0x373B0EA0, was: <startTime>k__BackingField

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_description(){} // RVA: 0x7ffaa89fa590
        public void set_description(){} // RVA: 0x7ffaa89fa5a0
        public void get_imageUrl(){} // RVA: 0x7ffaa8af68f0
        public void set_imageUrl(){} // RVA: 0x7ffaa8af19e0
        public void get_authorName(){} // RVA: 0x7ffaa8d1a3b0
        public void set_authorName(){} // RVA: 0x7ffaa8efece0
        public void get_authorId(){} // RVA: 0x7ffaa8971010
        public void set_authorId(){} // RVA: 0x7ffaa8f7b010
        public void get_startTime(){} // RVA: 0x7ffaa8d1b980
        public void set_startTime(){} // RVA: 0x7ffaa8f7b070
        public void get_venueId(){} // RVA: 0x7ffaa8f75d20
        public void set_venueId(){} // RVA: 0x7ffaa8f7b0d0
        public void .ctor(){} // RVA: 0x7ffab1931600
        public void MakeEvents(){} // RVA: 0x7ffab19316a0
        public void ToString(){} // RVA: 0x7ffab1931a00
    }

    public class VRCLogger : Object
    {
        public object _currentLoggingMode; // 0x334568B0
        public object _logFileNamePrefix; // 0x334568B0, was: <LogFileNamePrefix>k__BackingF
        public object UnityLogPrefixFormat; // 0x334568B0
        public object <literalLength>P; // 0x34F3AA90

        // ── Original Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x7ffaaf8869a0
        public void get_LogFileNamePrefix(){} // RVA: 0x7ffaaf886a10
        public void get_LogFilePath(){} // RVA: 0x7ffaaf886a70
        public void get_GlobalLogger(){} // RVA: 0x7ffaaf886bf0
        public void add_OnMessageLogged(){} // RVA: 0x7ffaaf886d00
        public void remove_OnMessageLogged(){} // RVA: 0x7ffaaf886e50
        public void IsLogPathValid(){} // RVA: 0x7ffaaf886fa0
        public void OverrideLogFilePath(){} // RVA: 0x7ffaaf887130
        public void InitializeZLogger(){} // RVA: 0x7ffaaf8874a0
        public void TeardownZLogger(){} // RVA: 0x7ffaaf887980
        public void FilterLogEntry(){} // RVA: 0x7ffaaf887c80
        public void UnityLogFormatPrefix(){} // RVA: 0x7ffaaf887dd0
        public void LogFileFormatPrefix(){} // RVA: 0x7ffaaf887e80
        public void HandleInterceptedMessage(){} // RVA: 0x7ffaaf887f50
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x7ffaaf8880d0
        public void HandleZLoggerInternalException_File(){} // RVA: 0x7ffaaf888250
        public void RemoveStaleLogs(){} // RVA: 0x7ffaaf888790
        public void GenerateOutputLogFilename(){} // RVA: 0x7ffaaf888a10
        public void Log(){} // RVA: 0x7ffaaf889330
        public void Log(){} // RVA: 0x7ffaaf889330
        public void LogWarning(){} // RVA: 0x7ffaaf889740
        public void LogWarning(){} // RVA: 0x7ffaaf889740
        public void LogError(){} // RVA: 0x7ffaaf889b50
        public void LogError(){} // RVA: 0x7ffaaf889b50
        public void LogException(){} // RVA: 0x7ffaaf88a0b0
        public void LogException(){} // RVA: 0x7ffaaf88a0b0
        public void OnMain(){} // RVA: 0x7ffaaf88a500
        public void OnMain(){} // RVA: 0x7ffaaf88a500
        public void .cctor(){} // RVA: 0x7ffaaf88a730
        // ── Binary Analysis Named ──
        public void SetLoggingMode(){} // RVA: 0x7ffaaf8883d0
        public void GetCurrentLogLevel(){} // RVA: 0x7ffaaf888430
        public void GetLogger(){} // RVA: 0x7ffaaf8884b0
        public void GetLogDirectory(){} // RVA: 0x7ffaaf888c90
    }

}