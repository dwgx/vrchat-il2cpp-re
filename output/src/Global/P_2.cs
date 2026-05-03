// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 63
// Methods: 269

public class PolarCoord : ValueType
{
    // ── Methods ──
    public void FromCart(){} // RVA: 0x7FFE86DBA8C0
}

public class PollHtcsPlayerConnection : ValueType
{
}

public class PollNextEventUnion : ValueType
{
}

public class PollNextOverlayEventUnion : ValueType
{
}

public class PollPlayerConnection : ValueType
{
}

public class PolyNode : Object
{
    public PolyNode m_Parent; // 0x10
    public System.Collections.Generic.List`1<IntPoint> m_polygon; // 0x18
    public int m_Index; // 0x20
    public 0x66625E0C m_jointype; // 0x24
    public 0x66625E64 m_endtype; // 0x28
    public System.Collections.Generic.List`1<PolyNode> m_Childs; // 0x30

    // ── Methods ──
    public void IsHoleNode(){} // RVA: 0x7FFE82AC44B0
    public void get_ChildCount(){} // RVA: 0x7FFE82AC44D0
    public void get_Contour(){} // RVA: 0x7FFE810FE7C0
    public void AddChild(){} // RVA: 0x7FFE82AC4520
    public void GetNext(){} // RVA: 0x7FFE82AC45F0
    public void GetNextSiblingUp(){} // RVA: 0x7FFE82AC4690
    public void get_Childs(){} // RVA: 0x7FFE8144E200
    public void get_Parent(){} // RVA: 0x7FFE81116380
    public void get_IsHole(){} // RVA: 0x7FFE82AC44B0
    public void get_IsOpen(){} // RVA: 0x7FFE812CF770
    public void set_IsOpen(){} // RVA: 0x7FFE812D0010
    public void .ctor(){} // RVA: 0x7FFE82AC4750
}

public class PolyTree : PolyNode
{
    public System.Collections.Generic.List`1<PolyNode> m_AllPolys; // 0x40

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFE82AC4170
    public void GetFirst(){} // RVA: 0x7FFE82AC42A0
    public void get_Total(){} // RVA: 0x7FFE82AC4330
    public void .ctor(){} // RVA: 0x7FFE82AC43E0
}

public class PolyfillExtensions : Object
{
    // ── Methods ──
    public void GetNullabilityInfo(){} // RVA: 0x7FFE86DD1F70 | overloaded x5
    public void GetNullability(){} // RVA: 0x7FFE86DD2120 | overloaded x5
    public void IsNullable(){} // RVA: 0x7FFE86DD2490 | overloaded x6
    public void GetReadOrWriteState(){} // RVA: 0x7FFE86DD2260
    public void GetKnownState(){} // RVA: 0x7FFE86DD2290
    public void CancelAsync(){} // RVA: 0x7FFE86DD2500
    public void GetStreamAsync(){} // RVA: 0x7FFE86DD2840 | overloaded x2
    public void GetByteArrayAsync(){} // RVA: 0x7FFE86DD2B30 | overloaded x2
    public void GetStringAsync(){} // RVA: 0x7FFE86DD2E20 | overloaded x2
    public void ReadAsStreamAsync(){} // RVA: 0x7FFE86DD2EC0
    public void ReadAsByteArrayAsync(){} // RVA: 0x7FFE86DD2F90
    public void ReadAsStringAsync(){} // RVA: 0x7FFE86DD31E0
    public void MaxBy(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void MinBy(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void SkipLast(){} // RVA: 0x7FFE80E3D4E0
    public void GetValueOrDefault(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void Deconstruct(){} // RVA: 0x7FFE810A1420
    public void Contains(){} // RVA: 0x7FFE86DD5130 | overloaded x4
    public void SequenceEqual(){} // RVA: 0x7FFE86DD3360 | overloaded x2
    public void StartsWith(){} // RVA: 0x7FFE86DD4E70 | overloaded x3
    public void EndsWith(){} // RVA: 0x7FFE86DD4EB0 | overloaded x3
    public void Nanoseconds(){} // RVA: 0x7FFE86DD3AC0
    public void Nanosecond(){} // RVA: 0x7FFE86DD3BC0 | overloaded x2
    public void Microseconds(){} // RVA: 0x7FFE86DD3C50
    public void Microsecond(){} // RVA: 0x7FFE86DD3D50 | overloaded x2
    public void AddMicroseconds(){} // RVA: 0x7FFE86DD3E90 | overloaded x2
    public void TicksComponent(){} // RVA: 0x7FFE86DD4340 | overloaded x3
    public void ReadAsync(){} // RVA: 0x7FFE86DD5880 | overloaded x2
    public void WriteAsync(){} // RVA: 0x7FFE86DD5C70 | overloaded x2
    public void CopyToAsync(){} // RVA: 0x7FFE86DD49B0
    public void CopyTo(){} // RVA: 0x7FFE86DD5160 | overloaded x2
    public void TryCopyTo(){} // RVA: 0x7FFE86DD4AD0
    public void GetHashCode(){} // RVA: 0x7FFE86DD4B80
    public void FromComparison(){} // RVA: 0x7FFE86DD4D00
    public void Split(){} // RVA: 0x7FFE86DD5010 | overloaded x2
    public void Append(){} // RVA: 0x7FFE86DD5230
    public void Equals(){} // RVA: 0x7FFE86DD52D0
    public void WaitAsync(){} // RVA: 0x7FFE810A1420 | overloaded x6
    public void ReadToEndAsync(){} // RVA: 0x7FFE86DD5B90
    public void WriteLineAsync(){} // RVA: 0x7FFE86DD5F60
    public void Write(){} // RVA: 0x7FFE86DD6250
    public void WriteLine(){} // RVA: 0x7FFE86DD6480
    public void TryFormat(){} // RVA: 0x7FFE86DD7810 | overloaded x14
    public void CopyToSpan(){} // RVA: 0x7FFE86DD79A0
    public void HasSameMetadataDefinitionAs(){} // RVA: 0x7FFE86DD7AD0
    public void IsGenericMethodParameter(){} // RVA: 0x7FFE86DD7BA0
    public void GetMemberWithSameMetadataDefinitionAs(){} // RVA: 0x7FFE86DD7C30
    public void ReadAsStream(){} // RVA: 0x7FFE86DD7E30
    public void WriteRawValue(){} // RVA: 0x7FFE86DD7FE0
    public void .cctor(){} // RVA: 0x7FFE86DD82B0
}

public class PolygonSolution : ValueType
{
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> polygons; // 0x10

    // ── Methods ──
    public void StateChanged(){} // RVA: 0x7FFE82AB4580
    public void get_IsNull(){} // RVA: 0x7FFE82AB4690
}

public class PolygonalBoundary2DInternal : ValueType
{
}

public class PopupButtonData : ApiModel
{
    public VRC.Core.ApiLocalizableString _text; // 0x68
    public System.Collections.Generic.Dictionary`2<string,string> _capture; // 0x70
    public System.Collections.Generic.List`1<RequiredValue> _requiredCaptures; // 0x78
    public bool _completePromotionOnPress; // 0x80
    public string _analyticsEventTag; // 0x88
    public VRC.Core.ApiBindingCommandReference _onPressed; // 0x90

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFE81176D50
    public void set_text(){} // RVA: 0x7FFE81176D60
    public void get_capture(){} // RVA: 0x7FFE811C3590
    public void set_capture(){} // RVA: 0x7FFE811C35A0
    public void get_requiredCaptures(){} // RVA: 0x7FFE81463AE0
    public void set_requiredCaptures(){} // RVA: 0x7FFE81464570
    public void get_completePromotionOnPress(){} // RVA: 0x7FFE813A1130
    public void set_completePromotionOnPress(){} // RVA: 0x7FFE813A2040
    public void get_analyticsEventTag(){} // RVA: 0x7FFE8113A010
    public void set_analyticsEventTag(){} // RVA: 0x7FFE81280F90
    public void get_onPressed(){} // RVA: 0x7FFE8154EB60
    public void set_onPressed(){} // RVA: 0x7FFE818CE320
    public void .ctor(){} // RVA: 0x7FFE8A2D8720
}

public class PopupTextElement : TextElement
{
    // ── Methods ──
    public void DoMeasure(){}
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class PortalSkinMap : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE882105B0
}

public class Pose : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881FF4C0
}

public class PoseBlendingBehaviour : Object
{
    // ── Methods ──
    public void Update(){} // RVA: 0x7FFE870377B0
    public void ApplyBlending(){} // RVA: 0x7FFE87037910
    public void .ctor(){} // RVA: 0x7FFE87037D90
}

public class PoseData : ValueType
{
}

public class PoseStatef : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE86CB11D0
}

public class Posef : ValueType
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE86CB0C60
    public void .cctor(){} // RVA: 0x7FFE86CB0DD0
}

public class PosesUpdatedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823781B0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE8702C0F0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class PositionOffset : Offset
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFE8126AB50
    public void CrossFadeStart(){} // RVA: 0x7FFE8126AE60
    public void OnApply(){} // RVA: 0x7FFE8126AEC0
    public void .ctor(){} // RVA: 0x7FFE8126B230
}

public class PositionOffsetLink : Object
{
    // ── Methods ──
    public void Apply(){} // RVA: 0x7FFE8126B240
    public void CrossFadeStart(){} // RVA: 0x7FFE81269A00
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PositionProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE87D4F790
    public void .ctor(){} // RVA: 0x7FFE87D4F7D0
}

public class PostLateUpdater : MonoBehaviour
{
    // ── Methods ──
    public void LateUpdate(){} // RVA: 0x7FFE8823A4D0
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class PowerOvfl : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A62C30
}

public class PrecisionBudget : Object
{
}

public class PrecompiledLayout : ValueType
{
}

public class PrecomputeCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A1ED40
    public void Precompute(){} // RVA: 0x7FFE89ED8DE0
    public void CheckExisting(){} // RVA: 0x7FFE89ED9950
    public void CheckTable(){} // RVA: 0x7FFE89ED9A80
}

public class PrecomputeWithPointMapCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89ED9A90
    public void Precompute(){} // RVA: 0x7FFE89ED9BA0
    public void CheckExisting(){} // RVA: 0x7FFE89EDA0F0
    public void CheckTable(){} // RVA: 0x7FFE89ED9A80
}

public class PresentAfterDraw : ValueType
{
}

public class PresentBeforeUpdate : ValueType
{
}

public class PreserveAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PresetSaveData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PreviousInfo : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86744C10
}

public class Prime192v1Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A177E70
    public void .cctor(){} // RVA: 0x7FFE8A1780F0
}

public class Prime192v2Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A178190
    public void .cctor(){} // RVA: 0x7FFE8A178410
}

public class Prime192v3Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A1784B0
    public void .cctor(){} // RVA: 0x7FFE8A178730
}

public class Prime239v1Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A1787D0
    public void .cctor(){} // RVA: 0x7FFE8A178A50
}

public class Prime239v2Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A178AF0
    public void .cctor(){} // RVA: 0x7FFE8A178D70
}

public class Prime239v3Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A178E10
    public void .cctor(){} // RVA: 0x7FFE8A179090
}

public class Prime256v1Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A179130
    public void .cctor(){} // RVA: 0x7FFE8A1793B0
}

public class PrintErrorsCallbackFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D21140
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class PrintFile : ApiModel
{
    public string _fileId; // 0x68
    public string _image; // 0x70

    // ── Methods ──
    public void get_fileId(){} // RVA: 0x7FFE81176D50
    public void set_fileId(){} // RVA: 0x7FFE81176D60
    public void get_image(){} // RVA: 0x7FFE811C3590
    public void set_image(){} // RVA: 0x7FFE811C35A0
    public void .ctor(){} // RVA: 0x7FFE8A320A60
}

public class PrivateKeyInfo : Object
{
    public int _version; // 0x10
    public string _algorithm; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86721080 | overloaded x2
    public void get_Algorithm(){} // RVA: 0x7FFE810FE7C0
    public void set_Algorithm(){} // RVA: 0x7FFE81161E80
    public void get_PrivateKey(){} // RVA: 0x7FFE867210B0
    public void set_PrivateKey(){} // RVA: 0x7FFE86721130
    public void Decode(){} // RVA: 0x7FFE86721270
    public void GetBytes(){} // RVA: 0x7FFE867215A0
    public void RemoveLeadingZero(){} // RVA: 0x7FFE86721C30
    public void Normalize(){} // RVA: 0x7FFE86721CE0
    public void DecodeRSA(){} // RVA: 0x7FFE86721DA0
    public void Encode(){} // RVA: 0x7FFE867229D0 | overloaded x3
    public void DecodeDSA(){} // RVA: 0x7FFE867227B0
}

public class ProbabilisticMap : ValueType
{
}

public class ProcInfo : ValueType
{
}

public class ProcessExtractedFrame : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ProcessMessageRes : ValueType
{
}

public class ProcessMouseInWindow : ValueType
{
}

public class ProcessRemoteInput : ValueType
{
}

public class ProcessWebSendMessages : ValueType
{
}

public class ProfilerEndFrame : ValueType
{
}

public class ProfilerStartFrame : ValueType
{
}

public class ProfilerSynchronizeStats : ValueType
{
}

public class Promotion : ApiModel
{
    public string _type; // 0x68
    public string _imageUrl; // 0x70
    public int _position; // 0x78
    public int _displayDelay; // 0x7C
    public int _impressions; // 0x80
    public int _hoursBetweenImpressions; // 0x84
    public string _fallback; // 0x88
    public int _fallbackPosition; // 0x90
    public string _popupId; // 0x98
    public VRC.Core.ApiBindingCommandReference _onPressed; // 0xA0
    public VRC.Core.ApiBindingCommandReference _popupCommand; // 0xA8
    public System.Collections.Generic.List`1<ApiPopupBuilderRecipe> _recipes; // 0xB0
    public ApiPromotionNotification _notification; // 0xB8

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFE81176D50
    public void set_type(){} // RVA: 0x7FFE81176D60
    public void get_imageUrl(){} // RVA: 0x7FFE811C3590
    public void set_imageUrl(){} // RVA: 0x7FFE811C35A0
    public void get_position(){} // RVA: 0x7FFE8286C0A0
    public void set_position(){} // RVA: 0x7FFE82862F10
    public void get_displayDelay(){} // RVA: 0x7FFE8286B570
    public void set_displayDelay(){} // RVA: 0x7FFE86D89990
    public void get_impressions(){} // RVA: 0x7FFE81D30560
    public void set_impressions(){} // RVA: 0x7FFE81D307B0
    public void get_hoursBetweenImpressions(){} // RVA: 0x7FFE829DF2E0
    public void set_hoursBetweenImpressions(){} // RVA: 0x7FFE829DF3B0
    public void get_fallback(){} // RVA: 0x7FFE8113A010
    public void set_fallback(){} // RVA: 0x7FFE81280F90
    public void get_fallbackPosition(){} // RVA: 0x7FFE814AA220
    public void set_fallbackPosition(){} // RVA: 0x7FFE81C8DB30
    public void get_popupId(){} // RVA: 0x7FFE817AE360
    public void set_popupId(){} // RVA: 0x7FFE8171B470
    public void get_onPressed(){} // RVA: 0x7FFE8179C860
    public void set_onPressed(){} // RVA: 0x7FFE8171B4D0
    public void get_popupCommand(){} // RVA: 0x7FFE817AB5E0
    public void set_popupCommand(){} // RVA: 0x7FFE81857260
    public void get_recipes(){} // RVA: 0x7FFE81166040
    public void set_recipes(){} // RVA: 0x7FFE81166050
    public void get_notification(){} // RVA: 0x7FFE811660B0
    public void set_notification(){} // RVA: 0x7FFE811660C0
    public void .ctor(){} // RVA: 0x7FFE8A2D8560
}

public class PropBuilderSessionData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class PropertyDescriptorEnumerator : Object
{
    public System.ComponentModel.PropertyDescriptorCollection _owner; // 0x10
    public int _index; // 0x18
    public object field_2; // 0x29B
    public object field_3; // 0x29C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83C3D9B0
    public void get_Current(){} // RVA: 0x7FFE877B8700
    public void get_Entry(){} // RVA: 0x7FFE877B8860
    public void get_Key(){} // RVA: 0x7FFE877B88E0
    public void get_Value(){} // RVA: 0x7FFE877B88E0
    public void MoveNext(){} // RVA: 0x7FFE877B8930
    public void Reset(){} // RVA: 0x7FFE82A55FE0
}

public class PropertyHierarchyResolutionState : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8741A500
}

public class Props : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81171990 | overloaded x2
    public void Clamp(){} // RVA: 0x7FFE81171B30
}

public class ProviderRegistration : ValueType
{
}

public class PseudoStateData : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE815BF9A0
}

public class PuppetEvent : ValueType
{
    public string switchToBehaviour; // 0x10

    // ── Methods ──
    public void get_switchBehaviour(){} // RVA: 0x7FFE81159DB0
    public void Trigger(){} // RVA: 0x7FFE81159EA0
}

public class PuppetUpdateLimit : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8119C7D0
    public void Step(){} // RVA: 0x7FFE8119C7E0
    public void Update(){} // RVA: 0x7FFE8119C800
}
