// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 7
// Methods: 95

namespace VRC.Core
{
    public class VRCCertificatePolicy : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A8B3FD20
        public void Equals(){} // RVA: 0x7A8B3FDC0
        public void InitVRCCertificatePolicy(){} // RVA: 0x7A8B3FE80
        public void op_Implicit(){} // RVA: 0x7A8B403D0
        public void CompareBaseObjects(){} // RVA: 0x7A8B40410
        public void IsNativeObjectAlive(){} // RVA: 0x7A8B40720
        public void GetCachedPtr(){} // RVA: 0x7A8B407C0
        public void get_name(){} // RVA: 0x7A8B40860
        public void set_name(){} // RVA: 0x7A8B40BA0
        public void Instantiate(){} // RVA: 0x7A8B40EF0
        public void Destroy(){} // RVA: 0x7A8B41200
        public void CheckValidationResult(){} // RVA: 0x7A8B41510
        public void FindObjectsOfType(){} // RVA: 0x7A8B41860
        public void FindObjectsByType(){} // RVA: 0x7A8B418A0
        public void DontDestroyOnLoad(){} // RVA: 0x7A8B41CE0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7A8B42280
        public void FindObjectOfType(){} // RVA: 0x7A8B425E0
    }

    public class VRCEvent : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_description(){} // RVA: 0x7A81A00E0
        public void set_description(){} // RVA: 0x7A81A00F0
        public void get_imageUrl(){} // RVA: 0x7A82C2060
        public void set_imageUrl(){} // RVA: 0x7A82C0530
        public void get_authorName(){} // RVA: 0x7A825E100
        public void set_authorName(){} // RVA: 0x7A825F860
        public void get_authorId(){} // RVA: 0x7A81163D0
        public void set_authorId(){} // RVA: 0x7A825E460
        public void get_startTime(){} // RVA: 0x7A8555100
        public void set_startTime(){} // RVA: 0x7A8919DE0
        public void get_venueId(){} // RVA: 0x7A87D9C10
        public void set_venueId(){} // RVA: 0x7A8744720
        public void .ctor(){} // RVA: 0x7B1754F20
        public void MakeEvents(){} // RVA: 0x7B1754FC0
        public void ToString(){} // RVA: 0x7B1755330
    }

    public class VRCEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRCLogger : Object
    {
        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x7AF4B8650
        public void get_LogFileNamePrefix(){} // RVA: 0x7AF4B86C0
        public void get_LogFilePath(){} // RVA: 0x7AF4B8720
        public void get_GlobalLogger(){} // RVA: 0x7AF4B88A0
        public void add_OnMessageLogged(){} // RVA: 0x7AF4B89B0
        public void remove_OnMessageLogged(){} // RVA: 0x7AF4B8B00
        public void IsLogPathValid(){} // RVA: 0x7AF4B8C50
        public void OverrideLogFilePath(){} // RVA: 0x7AF4B8DF0
        public void InitializeZLogger(){} // RVA: 0x7AF4B9160
        public void TeardownZLogger(){} // RVA: 0x7AF4B9640
        public void FilterLogEntry(){} // RVA: 0x7AF4B9940
        public void UnityLogFormatPrefix(){} // RVA: 0x7AF4B9A90
        public void LogFileFormatPrefix(){} // RVA: 0x7AF4B9B40
        public void HandleInterceptedMessage(){} // RVA: 0x7AF4B9C10
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x7AF4B9D90
        public void HandleZLoggerInternalException_File(){} // RVA: 0x7AF4B9F10
        public void SetLoggingMode(){} // RVA: 0x7AF4BA090
        public void GetCurrentLogLevel(){} // RVA: 0x7AF4BA0F0
        public void GetLogger(){} // RVA: 0x7AF4BA170
        public void RemoveStaleLogs(){} // RVA: 0x7AF4BA450
        public void GenerateOutputLogFilename(){} // RVA: 0x7AF4BA6E0
        public void GetLogDirectory(){} // RVA: 0x7AF4BA960
        public void Log(){} // RVA: 0x7AF4BB000
        public void LogWarning(){} // RVA: 0x7AF4BB410
        public void LogError(){} // RVA: 0x7AF4BB820
        public void LogException(){} // RVA: 0x7AF4BBD80
        public void OnMain(){} // RVA: 0x7AF4BC1D0
        public void .cctor(){} // RVA: 0x7AF4BC400
    }

    public class VRChatTestProtocol : Object
    {
        // ── Methods ──
        public void ReadLimitedString(){} // RVA: 0x7B176DFC0
        public void WriteLimitedString(){} // RVA: 0x7B176E0F0
        public void ReadToFileStream(){} // RVA: 0x7B176E250
        public void ReadHello(){} // RVA: 0x7B176E800
        public void WriteHello(){} // RVA: 0x7B176E970
        public void WriteSendWorld(){} // RVA: 0x7B176EA50
        public void WriteSendAvatar(){} // RVA: 0x7B176EAE0
        public void WriteSendProp(){} // RVA: 0x7B176EBD0
        public void ReadWorldFileToStream(){} // RVA: 0x7B176ECC0
        public void ReadAvatarFileToStream(){} // RVA: 0x7B176F0F0
        public void ReadPropFileToStream(){} // RVA: 0x7B176F680
        public void WriteHeartbeat(){} // RVA: 0x7B176FC10
        public void WriteError(){} // RVA: 0x7B176FC40
        public void ReadError(){} // RVA: 0x7B176FCD0
        public void .cctor(){} // RVA: 0x7B176FD30
    }

    public class VTPFileSizeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B176FEB0
    }

    public class VTPStringLimitException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B176FE50
    }

}