// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 24
// Methods: 79

public class PrintErrorsCallbackFunc
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x61E02A0
    public void Invoke(){} // RVA: 0x4394E0
}

public class PrintFile
{
    public string <fileId>k__BackingField; // 0x68
    public string <image>k__BackingField; // 0x70

    // ── Methods ──
    public void get_fileId(){} // RVA: 0x358D50
    public void set_fileId(){} // RVA: 0x358D60
    public void get_image(){} // RVA: 0x3A5590
    public void set_image(){} // RVA: 0x3A55A0
    public void .ctor(){} // RVA: 0x98C0D80
}

public class PrivateKeyInfo
{
    public int _version; // 0x10
    public string _algorithm; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5BE0230 | overloaded x2
    public void get_Algorithm(){} // RVA: 0x2E07C0
    public void set_Algorithm(){} // RVA: 0x343E80
    public void get_PrivateKey(){} // RVA: 0x5BE0260
    public void set_PrivateKey(){} // RVA: 0x5BE02E0
    public void Decode(){} // RVA: 0x5BE0420
    public void GetBytes(){} // RVA: 0x5BE0750
    public void RemoveLeadingZero(){} // RVA: 0x5BE0DE0
    public void Normalize(){} // RVA: 0x5BE0E90
    public void DecodeRSA(){} // RVA: 0x5BE0F50
    public void Encode(){} // RVA: 0x5BE1B80 | overloaded x3
    public void DecodeDSA(){} // RVA: 0x5BE1960
}

public class ProbabilisticMap
{
}

public class ProcInfo
{
}

public class ProcessExtractedFrame
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class ProcessMessageRes
{
}

public class ProcessMouseInWindow
{
}

public class ProcessRemoteInput
{
}

public class ProcessWebSendMessages
{
}

public class ProfilerEndFrame
{
}

public class ProfilerStartFrame
{
}

public class ProfilerSynchronizeStats
{
}

public class Promotion
{
    public string <type>k__BackingField; // 0x68
    public string <imageUrl>k__BackingField; // 0x70
    public int <position>k__BackingField; // 0x78
    public int <displayDelay>k__BackingField; // 0x7C
    public int <impressions>k__BackingField; // 0x80
    public int <hoursBetweenImpressions>k__BackingField; // 0x84
    public string <fallback>k__BackingField; // 0x88
    public int <fallbackPosition>k__BackingField; // 0x90
    public string <popupId>k__BackingField; // 0x98
    public VRC.Core.ApiBindingCommandReference <onPressed>k__BackingField; // 0xA0
    public VRC.Core.ApiBindingCommandReference <popupCommand>k__BackingField; // 0xA8
    public System.Collections.Generic.List`1<ApiPopupBuilderRecipe> <recipes>k__BackingField; // 0xB0
    public ApiPromotionNotification <notification>k__BackingField; // 0xB8

    // ── Methods ──
    public void get_type(){} // RVA: 0x358D50
    public void set_type(){} // RVA: 0x358D60
    public void get_imageUrl(){} // RVA: 0x3A5590
    public void set_imageUrl(){} // RVA: 0x3A55A0
    public void get_position(){} // RVA: 0x1AE3800
    public void set_position(){} // RVA: 0x1AE6D80
    public void get_displayDelay(){} // RVA: 0x1AE6E60
    public void set_displayDelay(){} // RVA: 0x6248F70
    public void get_impressions(){} // RVA: 0xFC4570
    public void set_impressions(){} // RVA: 0xFC4560
    public void get_hoursBetweenImpressions(){} // RVA: 0x1C5A600
    public void set_hoursBetweenImpressions(){} // RVA: 0x1C5A650
    public void get_fallback(){} // RVA: 0x31C010
    public void set_fallback(){} // RVA: 0x463060
    public void get_fallbackPosition(){} // RVA: 0x6AFD40
    public void set_fallbackPosition(){} // RVA: 0xF02F80
    public void get_popupId(){} // RVA: 0xA1C8C0
    public void set_popupId(){} // RVA: 0x9AA650
    public void get_onPressed(){} // RVA: 0xA085E0
    public void set_onPressed(){} // RVA: 0x9AA5F0
    public void get_popupCommand(){} // RVA: 0xA1C130
    public void set_popupCommand(){} // RVA: 0xAE5030
    public void get_recipes(){} // RVA: 0x348040
    public void set_recipes(){} // RVA: 0x348050
    public void get_notification(){} // RVA: 0x3480B0
    public void set_notification(){} // RVA: 0x3480C0
    public void .ctor(){} // RVA: 0x9876120
}

public class PropBuilderSessionData
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class PropDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35D190
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class PropertyDescriptorEnumerator
{
    public System.ComponentModel.PropertyDescriptorCollection _owner; // 0x10
    public int _index; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2F93A00
    public void get_Current(){} // RVA: 0x6C77850
    public void get_Entry(){} // RVA: 0x6C779B0
    public void get_Key(){} // RVA: 0x6C77A30
    public void get_Value(){} // RVA: 0x6C77A30
    public void MoveNext(){} // RVA: 0x6C77A80
    public void Reset(){} // RVA: 0x1CC8140
}

public class PropertyHierarchyResolutionState
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68DB230
}

public class Props
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x353990 | overloaded x2
    public void Clamp(){} // RVA: 0x353B30
}

public class Props
{
    // ── Methods ──
    public void get__GetPropFromGameObject(){} // RVA: 0x76F2980
    public void set__GetPropFromGameObject(){} // RVA: 0x76F29C0
    public void get__GetPropApi(){} // RVA: 0x76F2A60
    public void set__GetPropApi(){} // RVA: 0x76F2AA0
}

public class ProviderRegistration
{
}

public class PseudoStateData
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x833590
}

public class PuppetEvent
{
    public string switchToBehaviour; // 0x10

    // ── Methods ──
    public void get_switchBehaviour(){} // RVA: 0x33BDB0
    public void Trigger(){} // RVA: 0x33BEA0
}

public class PuppetUpdateLimit
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37E7D0
    public void Step(){} // RVA: 0x37E7E0
    public void Update(){} // RVA: 0x37E800
}
