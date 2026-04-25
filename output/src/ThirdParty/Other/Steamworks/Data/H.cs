// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 30
// Methods: 77

namespace ThirdParty.Other.Steamworks.Data
{
    public class HAuthTicket : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC4BE6C00
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7830
    }

    public class HSteamNetPollGroup : ValueType
    {
        public uint Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BE6C00
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF7830
    }

    public class HSteamPipe : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10
        public void ToString(){} // RVA: 0x7FFAC4BF7850
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC4BF78D0
        public void op_Inequality(){} // RVA: 0x7FFAC4BF78E0
        public void CompareTo(){} // RVA: 0x7FFAC4BF78F0
    }

    public class HSteamUser : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC4BF7850
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void Equals(){} // RVA: 0x7FFAC4BF7820 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC4BF78F0
    }

    public class HTML_BrowserReady_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF37B0
        public void .cctor(){} // RVA: 0x7FFAC4BF37C0
    }

    public class HTML_BrowserRestarted_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint UnOldBrowserHandle; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4F10
        public void .cctor(){} // RVA: 0x7FFAC4BF4F20
    }

    public class HTML_CanGoBackAndForward_t : ValueType
    {
        public uint CallbackType; // 0x10
        public bool BCanGoBack; // 0x14
        public bool BCanGoForward; // 0x15
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4140
        public void .cctor(){} // RVA: 0x7FFAC4BF4150
    }

    public class HTML_ChangedTitle_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchTitle; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3F20
        public void .cctor(){} // RVA: 0x7FFAC4BF3F30
    }

    public class HTML_CloseBrowser_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3AE0
        public void .cctor(){} // RVA: 0x7FFAC4BF3AF0
    }

    public class HTML_FileOpenDialog_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchTitle; // 0x18
        public string PchInitialFile; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF47A0
        public void .cctor(){} // RVA: 0x7FFAC4BF47B0
    }

    public class HTML_FinishedRequest_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchURL; // 0x18
        public string PchPageTitle; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3D00
        public void .cctor(){} // RVA: 0x7FFAC4BF3D10
    }

    public class HTML_HideToolTip_t : ValueType
    {
        public uint CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4E00
        public void .cctor(){} // RVA: 0x7FFAC4BF4E10
    }

    public class HTML_HorizontalScroll_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint UnScrollMax; // 0x14
        public uint UnScrollCurrent; // 0x18
        public float FlPageScale; // 0x1C
        public bool BVisible; // 0x20
        public uint UnPageSize; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4250
        public void .cctor(){} // RVA: 0x7FFAC4BF4260
    }

    public class HTML_JSAlert_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchMessage; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4580
        public void .cctor(){} // RVA: 0x7FFAC4BF4590
    }

    public class HTML_JSConfirm_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchMessage; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4690
        public void .cctor(){} // RVA: 0x7FFAC4BF46A0
    }

    public class HTML_LinkAtPosition_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint X; // 0x14
        public uint Y; // 0x18
        public string PchURL; // 0x20
        public bool BInput; // 0x28
        public bool BLiveLink; // 0x29
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4470
        public void .cctor(){} // RVA: 0x7FFAC4BF4480
    }

    public class HTML_NeedsPaint_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PBGRA; // 0x18
        public uint UnWide; // 0x20
        public uint UnTall; // 0x24
        public uint UnUpdateX; // 0x28
        public uint UnUpdateY; // 0x2C
        public uint UnUpdateWide; // 0x30
        public uint UnUpdateTall; // 0x34
        public uint UnScrollX; // 0x38
        public uint UnScrollY; // 0x3C
        public float FlPageScale; // 0x40
        public uint UnPageSerial; // 0x44
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF38C0
        public void .cctor(){} // RVA: 0x7FFAC4BF38D0
    }

    public class HTML_NewWindow_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchURL; // 0x18
        public uint UnX; // 0x20
        public uint UnY; // 0x24
        public uint UnWide; // 0x28
        public uint UnTall; // 0x2C
        public uint UnNewWindow_BrowserHandle_IGNORE; // 0x30
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF48B0
        public void .cctor(){} // RVA: 0x7FFAC4BF48C0
    }

    public class HTML_OpenLinkInNewTab_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchURL; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3E10
        public void .cctor(){} // RVA: 0x7FFAC4BF3E20
    }

    public class HTML_SearchResults_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint UnResults; // 0x14
        public uint UnCurrentMatch; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4030
        public void .cctor(){} // RVA: 0x7FFAC4BF4040
    }

    public class HTML_SetCursor_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint EMouseCursor; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF49C0
        public void .cctor(){} // RVA: 0x7FFAC4BF49D0
    }

    public class HTML_ShowToolTip_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchMsg; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4BE0
        public void .cctor(){} // RVA: 0x7FFAC4BF4BF0
    }

    public class HTML_StartRequest_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchURL; // 0x18
        public string PchTarget; // 0x20
        public string PchPostData; // 0x28
        public bool BIsRedirect; // 0x30
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF39D0
        public void .cctor(){} // RVA: 0x7FFAC4BF39E0
    }

    public class HTML_StatusText_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchMsg; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4AD0
        public void .cctor(){} // RVA: 0x7FFAC4BF4AE0
    }

    public class HTML_URLChanged_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchURL; // 0x18
        public string PchPostData; // 0x20
        public bool BIsRedirect; // 0x28
        public string PchPageTitle; // 0x30
        public bool BNewNavigation; // 0x38
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3BF0
        public void .cctor(){} // RVA: 0x7FFAC4BF3C00
    }

    public class HTML_UpdateToolTip_t : ValueType
    {
        public uint CallbackType; // 0x10
        public string PchMsg; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4CF0
        public void .cctor(){} // RVA: 0x7FFAC4BF4D00
    }

    public class HTML_VerticalScroll_t : ValueType
    {
        public uint CallbackType; // 0x10
        public uint UnScrollMax; // 0x14
        public uint UnScrollCurrent; // 0x18
        public float FlPageScale; // 0x1C
        public bool BVisible; // 0x20
        public uint UnPageSize; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF4360
        public void .cctor(){} // RVA: 0x7FFAC4BF4370
    }

    public class HTTPRequestCompleted_t : ValueType
    {
        public uint CallbackType; // 0x10
        public ulong ContextValue; // 0x18
        public bool RequestSuccessful; // 0x20
        public 0x6B28DB80 StatusCode; // 0x24
        public uint BodySize; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1B00
        public void .cctor(){} // RVA: 0x7FFAC4BF1B10
    }

    public class HTTPRequestDataReceived_t : ValueType
    {
        public uint CallbackType; // 0x10
        public ulong ContextValue; // 0x18
        public uint COffset; // 0x20
        public uint CBytesReceived; // 0x24
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1D20
        public void .cctor(){} // RVA: 0x7FFAC4BF1D30
    }

    public class HTTPRequestHeadersReceived_t : ValueType
    {
        public uint CallbackType; // 0x10
        public ulong ContextValue; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1C10
        public void .cctor(){} // RVA: 0x7FFAC4BF1C20
    }

}