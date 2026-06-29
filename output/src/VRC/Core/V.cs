// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 7
// Methods: 95

namespace VRC.Core
{
    public class VRCCertificatePolicy : Object
    {
        public object _vRCCertificatePolicy;
        public object _vRCCertificatePolicy2;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1636D80
        public void Equals(){} // RVA: 0x16371A0
        public void GetHashCode(){} // RVA: 0x1637240
        public void op_Implicit(){} // RVA: 0x1637540
        public void ToString(){} // RVA: 0x1637920
        public void IsNativeObjectAlive(){} // RVA: 0x1637C20
        public void GetCachedPtr(){} // RVA: 0x1637F60
        public void get_name(){} // RVA: 0x1638000
        public void CheckValidationResult(){} // RVA: 0x1638310
        public void InitVRCCertificatePolicy(){} // RVA: 0x1638610
        public void Destroy(){} // RVA: 0x1638B60
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x1638EA0
        public void FindObjectsByType(){} // RVA: 0x1639290
        public void DontDestroyOnLoad(){} // RVA: 0x16393B0
        public void get_hideFlags(){} // RVA: 0x1639450
        public void set_hideFlags(){} // RVA: 0x1639580
        public void FindObjectOfType(){} // RVA: 0x1639880
    }

    public class VRCEvent : ApiModel
    {
        public object _name;
        public object _description;
        public object _imageUrl;
        public object _authorName;
        public object _authorId;
        public object _startTime;
        public object _venueId;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_description(){} // RVA: 0xC10050
        public void set_description(){} // RVA: 0xC10060
        public void get_imageUrl(){} // RVA: 0xCD3320
        public void set_imageUrl(){} // RVA: 0xCD4740
        public void get_authorName(){} // RVA: 0xCD48B0
        public void set_authorName(){} // RVA: 0xCD3600
        public void get_authorId(){} // RVA: 0xB813B0
        public void set_authorId(){} // RVA: 0xD5CBB0
        public void get_startTime(){} // RVA: 0x1069350
        public void set_startTime(){} // RVA: 0xD5CC10
        public void get_venueId(){} // RVA: 0x106A7D0
        public void set_venueId(){} // RVA: 0xD5CC70
        public void .ctor(){} // RVA: 0xA5C12A0
        public void MakeEvents(){} // RVA: 0xA5C1340
        public void ToString(){} // RVA: 0xA5C16B0
    }

    public class VRCEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VRCLogger : Object
    {
        public object _initialized;
        public object _runtimeLoggerFactory;
        public object _currentLoggingMode;
        public object LoggerDictionary;
        public object _logFilePathOverride;
        public object _logFileNamePrefix;
        public object _globalLogger;
        public object _zLoggerHandler;
        public object UnityLogPrefixFormat;
        public object LogFilePrefixFormat;
        public object OnMessageLogged;

        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x8318870
        public void get_LogFileNamePrefix(){} // RVA: 0x83188E0
        public void get_LogFilePath(){} // RVA: 0x8318940
        public void get_GlobalLogger(){} // RVA: 0x8318AC0
        public void add_OnMessageLogged(){} // RVA: 0x8318BD0
        public void remove_OnMessageLogged(){} // RVA: 0x8318D20
        public void IsLogPathValid(){} // RVA: 0x8318E70
        public void OverrideLogFilePath(){} // RVA: 0x8318FB0
        public void InitializeZLogger(){} // RVA: 0x8319320
        public void TeardownZLogger(){} // RVA: 0x8319800
        public void FilterLogEntry(){} // RVA: 0x8319B00
        public void UnityLogFormatPrefix(){} // RVA: 0x8319C50
        public void LogFileFormatPrefix(){} // RVA: 0x8319D00
        public void HandleInterceptedMessage(){} // RVA: 0x8319DD0
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x8319F50
        public void HandleZLoggerInternalException_File(){} // RVA: 0x831A0D0
        public void SetLoggingMode(){} // RVA: 0x831A250
        public void GetCurrentLogLevel(){} // RVA: 0x831A2B0
        public void GetLogger(){} // RVA: 0x831A330
        public void RemoveStaleLogs(){} // RVA: 0x831A610
        public void GenerateOutputLogFilename(){} // RVA: 0x831A8A0
        public void GetLogDirectory(){} // RVA: 0x831AB20
        public void Log(){} // RVA: 0x831B170
        public void LogWarning(){} // RVA: 0x831B580
        public void LogError(){} // RVA: 0x831B990
        public void LogException(){} // RVA: 0x831BEF0
        public void OnMain(){} // RVA: 0x831C340
        public void .cctor(){} // RVA: 0x831C570
    }

    public class VRChatTestProtocol : Object
    {
        public object Port;
        public object HeartbeatInterval;
        public object TimeoutInterval;
        public object MaxStringLength;
        public object MaxFileSize;
        public object Version;

        // ── Methods ──
        public void ReadLimitedString(){} // RVA: 0xA5DA140
        public void WriteLimitedString(){} // RVA: 0xA5DA260
        public void ReadToFileStream(){} // RVA: 0xA5DA3B0
        public void ReadHello(){} // RVA: 0xA5DA950
        public void WriteHello(){} // RVA: 0xA5DAAC0
        public void WriteSendWorld(){} // RVA: 0xA5DABA0
        public void WriteSendAvatar(){} // RVA: 0xA5DAC30
        public void WriteSendProp(){} // RVA: 0xA5DAD20
        public void ReadWorldFileToStream(){} // RVA: 0xA5DAE10
        public void ReadAvatarFileToStream(){} // RVA: 0xA5DB1C0
        public void ReadPropFileToStream(){} // RVA: 0xA5DB6D0
        public void WriteHeartbeat(){} // RVA: 0xA5DBBE0
        public void WriteError(){} // RVA: 0xA5DBC10
        public void ReadError(){} // RVA: 0xA5DBCA0
        public void .cctor(){} // RVA: 0xA5DBD00
    }

    public class VTPFileSizeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5DBE80
    }

    public class VTPStringLimitException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5DBE20
    }

}