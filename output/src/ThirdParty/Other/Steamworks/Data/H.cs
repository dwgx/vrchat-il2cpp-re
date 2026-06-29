// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 30
// Methods: 72

namespace ThirdParty.Other.Steamworks.Data
{
    public class HAuthTicket : ValueType
    {
        public object Value;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x294E720
        public void ToString(){} // RVA: 0x145060
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void CompareTo(){} // RVA: 0x14F650
    }

    public class HSteamNetPollGroup : ValueType
    {
        public object Value;

        // ── Methods ──
        public void ToString(){} // RVA: 0x145060
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void CompareTo(){} // RVA: 0x14F650
    }

    public class HSteamPipe : ValueType
    {
        public object Value;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x294E720
        public void ToString(){} // RVA: 0x14F670
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void op_Equality(){} // RVA: 0x295CBC0
        public void op_Inequality(){} // RVA: 0x295CBD0
        public void CompareTo(){} // RVA: 0x14F6F0
    }

    public class HSteamUser : ValueType
    {
        public object Value;

        // ── Methods ──
        public void ToString(){} // RVA: 0x14F670
        public void GetHashCode(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14F640
        public void CompareTo(){} // RVA: 0x14F6F0
    }

    public class HTML_BrowserReady_t : ValueType
    {
        public object UnBrowserHandle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14CD70
        public void .cctor(){} // RVA: 0x2959480
    }

    public class HTML_BrowserRestarted_t : ValueType
    {
        public object UnBrowserHandle;
        public object UnOldBrowserHandle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D7E0
        public void .cctor(){} // RVA: 0x295A7C0
    }

    public class HTML_CanGoBackAndForward_t : ValueType
    {
        public object UnBrowserHandle;
        public object BCanGoBack;
        public object BCanGoForward;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D4C0
        public void .cctor(){} // RVA: 0x2959C60
    }

    public class HTML_ChangedTitle_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchTitle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D4A0
        public void .cctor(){} // RVA: 0x2959AA0
    }

    public class HTML_CloseBrowser_t : ValueType
    {
        public object UnBrowserHandle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D1A0
        public void .cctor(){} // RVA: 0x2959720
    }

    public class HTML_FileOpenDialog_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchTitle;
        public object PchInitialFile;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D650
        public void .cctor(){} // RVA: 0x295A1A0
    }

    public class HTML_FinishedRequest_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchURL;
        public object PchPageTitle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D480
        public void .cctor(){} // RVA: 0x29598E0
    }

    public class HTML_HideToolTip_t : ValueType
    {
        public object UnBrowserHandle;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D7D0
        public void .cctor(){} // RVA: 0x295A6E0
    }

    public class HTML_HorizontalScroll_t : ValueType
    {
        public object UnBrowserHandle;
        public object UnScrollMax;
        public object UnScrollCurrent;
        public object FlPageScale;
        public object BVisible;
        public object UnPageSize;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D4D0
        public void .cctor(){} // RVA: 0x2959D40
    }

    public class HTML_JSAlert_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchMessage;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D630
        public void .cctor(){} // RVA: 0x2959FE0
    }

    public class HTML_JSConfirm_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchMessage;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D640
        public void .cctor(){} // RVA: 0x295A0C0
    }

    public class HTML_LinkAtPosition_t : ValueType
    {
        public object UnBrowserHandle;
        public object X;
        public object Y;
        public object PchURL;
        public object BInput;
        public object BLiveLink;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D620
        public void .cctor(){} // RVA: 0x2959F00
    }

    public class HTML_NeedsPaint_t : ValueType
    {
        public object UnBrowserHandle;
        public object PBGRA;
        public object UnWide;
        public object UnTall;
        public object UnUpdateX;
        public object UnUpdateY;
        public object UnUpdateWide;
        public object UnUpdateTall;
        public object UnScrollX;
        public object UnScrollY;
        public object FlPageScale;
        public object UnPageSerial;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14CEE0
        public void .cctor(){} // RVA: 0x2959560
    }

    public class HTML_NewWindow_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchURL;
        public object UnX;
        public object UnY;
        public object UnWide;
        public object UnTall;
        public object UnNewWindow_BrowserHandle_IGNORE;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D780
        public void .cctor(){} // RVA: 0x295A280
    }

    public class HTML_OpenLinkInNewTab_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchURL;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D490
        public void .cctor(){} // RVA: 0x29599C0
    }

    public class HTML_SearchResults_t : ValueType
    {
        public object UnBrowserHandle;
        public object UnResults;
        public object UnCurrentMatch;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D4B0
        public void .cctor(){} // RVA: 0x2959B80
    }

    public class HTML_SetCursor_t : ValueType
    {
        public object UnBrowserHandle;
        public object EMouseCursor;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D790
        public void .cctor(){} // RVA: 0x295A360
    }

    public class HTML_ShowToolTip_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchMsg;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D7B0
        public void .cctor(){} // RVA: 0x295A520
    }

    public class HTML_StartRequest_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchURL;
        public object PchTarget;
        public object PchPostData;
        public object BIsRedirect;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D190
        public void .cctor(){} // RVA: 0x2959640
    }

    public class HTML_StatusText_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchMsg;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D7A0
        public void .cctor(){} // RVA: 0x295A440
    }

    public class HTML_URLChanged_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchURL;
        public object PchPostData;
        public object BIsRedirect;
        public object PchPageTitle;
        public object BNewNavigation;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D470
        public void .cctor(){} // RVA: 0x2959800
    }

    public class HTML_UpdateToolTip_t : ValueType
    {
        public object UnBrowserHandle;
        public object PchMsg;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D7C0
        public void .cctor(){} // RVA: 0x295A600
    }

    public class HTML_VerticalScroll_t : ValueType
    {
        public object UnBrowserHandle;
        public object UnScrollMax;
        public object UnScrollCurrent;
        public object FlPageScale;
        public object BVisible;
        public object UnPageSize;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14D4E0
        public void .cctor(){} // RVA: 0x2959E20
    }

    public class HTTPRequestCompleted_t : ValueType
    {
        public object Request;
        public object ContextValue;
        public object RequestSuccessful;
        public object StatusCode;
        public object BodySize;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C4B0
        public void .cctor(){} // RVA: 0x2957CE0
    }

    public class HTTPRequestDataReceived_t : ValueType
    {
        public object Request;
        public object ContextValue;
        public object COffset;
        public object CBytesReceived;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C4D0
        public void .cctor(){} // RVA: 0x2957EA0
    }

    public class HTTPRequestHeadersReceived_t : ValueType
    {
        public object Request;
        public object ContextValue;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C4C0
        public void .cctor(){} // RVA: 0x2957DC0
    }

}