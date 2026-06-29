// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 1
// Methods: 161

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Keyboard : InputDevice
    {
        public object KeyCount;
        public object ExtendedKeyCount;
        public object _anyKey;
        public object _shiftKey;
        public object _ctrlKey;
        public object _altKey;
        public object _imeSelected;
        public object _current;
        public object m_TextInputListeners;
        public object m_KeyboardLayoutName;
        public object m_Keys;
        public object m_ImeCompositionListeners;

        // ── Methods ──
        public void add_onTextInput(){} // RVA: 0x78597C0
        public void remove_onTextInput(){} // RVA: 0x78598B0
        public void add_onIMECompositionChange(){} // RVA: 0x7859910
        public void remove_onIMECompositionChange(){} // RVA: 0x7859A00
        public void SetIMEEnabled(){} // RVA: 0x7859A60
        public void SetIMECursorPosition(){} // RVA: 0x7859AE0
        public void get_keyboardLayout(){} // RVA: 0x7859B70
        public void set_keyboardLayout(){} // RVA: 0x16612E0
        public void get_anyKey(){} // RVA: 0x13659D0
        public void set_anyKey(){} // RVA: 0x166D270
        public void get_spaceKey(){} // RVA: 0x7859BC0
        public void get_enterKey(){} // RVA: 0x7859BD0
        public void get_tabKey(){} // RVA: 0x7859BE0
        public void get_backquoteKey(){} // RVA: 0x7859BF0
        public void get_quoteKey(){} // RVA: 0x7859C00
        public void get_semicolonKey(){} // RVA: 0x7859C10
        public void get_commaKey(){} // RVA: 0x7859C20
        public void get_periodKey(){} // RVA: 0x7859C30
        public void get_slashKey(){} // RVA: 0x7859C40
        public void get_backslashKey(){} // RVA: 0x7859C50
        public void get_leftBracketKey(){} // RVA: 0x7859C60
        public void get_rightBracketKey(){} // RVA: 0x7859C70
        public void get_minusKey(){} // RVA: 0x7859C80
        public void get_equalsKey(){} // RVA: 0x7859C90
        public void get_aKey(){} // RVA: 0x7859CA0
        public void get_bKey(){} // RVA: 0x7859CB0
        public void get_cKey(){} // RVA: 0x7859CC0
        public void get_dKey(){} // RVA: 0x7859CD0
        public void get_eKey(){} // RVA: 0x7859CE0
        public void get_fKey(){} // RVA: 0x7859CF0
        public void get_gKey(){} // RVA: 0x7859D00
        public void get_hKey(){} // RVA: 0x7859D10
        public void get_iKey(){} // RVA: 0x7859D20
        public void get_jKey(){} // RVA: 0x7859D30
        public void get_kKey(){} // RVA: 0x7859D40
        public void get_lKey(){} // RVA: 0x7859D50
        public void get_mKey(){} // RVA: 0x7859D60
        public void get_nKey(){} // RVA: 0x7859D70
        public void get_oKey(){} // RVA: 0x7859D80
        public void get_pKey(){} // RVA: 0x7859D90
        public void get_qKey(){} // RVA: 0x7859DA0
        public void get_rKey(){} // RVA: 0x7859DB0
        public void get_sKey(){} // RVA: 0x7859DC0
        public void get_tKey(){} // RVA: 0x7859DD0
        public void get_uKey(){} // RVA: 0x7859DE0
        public void get_vKey(){} // RVA: 0x7859DF0
        public void get_wKey(){} // RVA: 0x7859E00
        public void get_xKey(){} // RVA: 0x7859E10
        public void get_yKey(){} // RVA: 0x7859E20
        public void get_zKey(){} // RVA: 0x7859E30
        public void get_digit1Key(){} // RVA: 0x7859E40
        public void get_digit2Key(){} // RVA: 0x7859E50
        public void get_digit3Key(){} // RVA: 0x7859E60
        public void get_digit4Key(){} // RVA: 0x7859E70
        public void get_digit5Key(){} // RVA: 0x7859E80
        public void get_digit6Key(){} // RVA: 0x7859E90
        public void get_digit7Key(){} // RVA: 0x7859EA0
        public void get_digit8Key(){} // RVA: 0x7859EB0
        public void get_digit9Key(){} // RVA: 0x7859EC0
        public void get_digit0Key(){} // RVA: 0x7859ED0
        public void get_leftShiftKey(){} // RVA: 0x7859EE0
        public void get_rightShiftKey(){} // RVA: 0x7859EF0
        public void get_leftAltKey(){} // RVA: 0x7859F00
        public void get_rightAltKey(){} // RVA: 0x7859F10
        public void get_leftCtrlKey(){} // RVA: 0x7859F20
        public void get_rightCtrlKey(){} // RVA: 0x7859F30
        public void get_leftMetaKey(){} // RVA: 0x7859F40
        public void get_rightMetaKey(){} // RVA: 0x7859F50
        public void get_leftWindowsKey(){} // RVA: 0x7859F40
        public void get_rightWindowsKey(){} // RVA: 0x7859F50
        public void get_leftAppleKey(){} // RVA: 0x7859F40
        public void get_rightAppleKey(){} // RVA: 0x7859F50
        public void get_leftCommandKey(){} // RVA: 0x7859F40
        public void get_rightCommandKey(){} // RVA: 0x7859F50
        public void get_contextMenuKey(){} // RVA: 0x7859F60
        public void get_escapeKey(){} // RVA: 0x7859F70
        public void get_leftArrowKey(){} // RVA: 0x7859F80
        public void get_rightArrowKey(){} // RVA: 0x7859F90
        public void get_upArrowKey(){} // RVA: 0x7859FA0
        public void get_downArrowKey(){} // RVA: 0x7859FB0
        public void get_backspaceKey(){} // RVA: 0x7859FC0
        public void get_pageDownKey(){} // RVA: 0x7859FD0
        public void get_pageUpKey(){} // RVA: 0x7859FE0
        public void get_homeKey(){} // RVA: 0x7859FF0
        public void get_endKey(){} // RVA: 0x785A000
        public void get_insertKey(){} // RVA: 0x785A010
        public void get_deleteKey(){} // RVA: 0x785A020
        public void get_capsLockKey(){} // RVA: 0x785A030
        public void get_scrollLockKey(){} // RVA: 0x785A040
        public void get_numLockKey(){} // RVA: 0x785A050
        public void get_printScreenKey(){} // RVA: 0x785A060
        public void get_pauseKey(){} // RVA: 0x785A070
        public void get_numpadEnterKey(){} // RVA: 0x785A080
        public void get_numpadDivideKey(){} // RVA: 0x785A090
        public void get_numpadMultiplyKey(){} // RVA: 0x785A0A0
        public void get_numpadMinusKey(){} // RVA: 0x785A0B0
        public void get_numpadPlusKey(){} // RVA: 0x785A0C0
        public void get_numpadPeriodKey(){} // RVA: 0x785A0D0
        public void get_numpadEqualsKey(){} // RVA: 0x785A0E0
        public void get_numpad0Key(){} // RVA: 0x785A0F0
        public void get_numpad1Key(){} // RVA: 0x785A100
        public void get_numpad2Key(){} // RVA: 0x785A110
        public void get_numpad3Key(){} // RVA: 0x785A120
        public void get_numpad4Key(){} // RVA: 0x785A130
        public void get_numpad5Key(){} // RVA: 0x785A140
        public void get_numpad6Key(){} // RVA: 0x785A150
        public void get_numpad7Key(){} // RVA: 0x785A160
        public void get_numpad8Key(){} // RVA: 0x785A170
        public void get_numpad9Key(){} // RVA: 0x785A180
        public void get_f1Key(){} // RVA: 0x785A190
        public void get_f2Key(){} // RVA: 0x785A1A0
        public void get_f3Key(){} // RVA: 0x785A1B0
        public void get_f4Key(){} // RVA: 0x785A1C0
        public void get_f5Key(){} // RVA: 0x785A1D0
        public void get_f6Key(){} // RVA: 0x785A1E0
        public void get_f7Key(){} // RVA: 0x785A1F0
        public void get_f8Key(){} // RVA: 0x785A200
        public void get_f9Key(){} // RVA: 0x785A210
        public void get_f10Key(){} // RVA: 0x785A220
        public void get_f11Key(){} // RVA: 0x785A230
        public void get_f12Key(){} // RVA: 0x785A240
        public void get_oem1Key(){} // RVA: 0x785A250
        public void get_oem2Key(){} // RVA: 0x785A260
        public void get_oem3Key(){} // RVA: 0x785A270
        public void get_oem4Key(){} // RVA: 0x785A280
        public void get_oem5Key(){} // RVA: 0x785A290
        public void get_f13Key(){} // RVA: 0x785A2A0
        public void get_f14Key(){} // RVA: 0x785A2B0
        public void get_f15Key(){} // RVA: 0x785A2C0
        public void get_f16Key(){} // RVA: 0x785A2D0
        public void get_f17Key(){} // RVA: 0x785A2E0
        public void get_f18Key(){} // RVA: 0x785A2F0
        public void get_f19Key(){} // RVA: 0x785A300
        public void get_f20Key(){} // RVA: 0x785A310
        public void get_f21Key(){} // RVA: 0x785A320
        public void get_f22Key(){} // RVA: 0x785A330
        public void get_f23Key(){} // RVA: 0x785A340
        public void get_f24Key(){} // RVA: 0x785A350
        public void get_shiftKey(){} // RVA: 0x135C160
        public void set_shiftKey(){} // RVA: 0x16614A0
        public void get_ctrlKey(){} // RVA: 0x1664460
        public void set_ctrlKey(){} // RVA: 0x16679E0
        public void get_altKey(){} // RVA: 0x135A180
        public void set_altKey(){} // RVA: 0x164D690
        public void get_imeSelected(){} // RVA: 0x165E8F0
        public void set_imeSelected(){} // RVA: 0x165C4D0
        public void get_Item(){} // RVA: 0x785A360
        public void get_allKeys(){} // RVA: 0x785A400
        public void get_current(){} // RVA: 0x785A4D0
        public void set_current(){} // RVA: 0x785A510
        public void MakeCurrent(){} // RVA: 0x785A5B0
        public void OnRemoved(){} // RVA: 0x785A5C0
        public void FinishSetup(){} // RVA: 0x785A610
        public void RefreshConfiguration(){} // RVA: 0x785BC50
        public void OnTextInput(){} // RVA: 0x785BE40
        public void FindKeyOnCurrentKeyboardLayout(){} // RVA: 0x785BED0
        public void OnIMECompositionChanged(){} // RVA: 0x785C0E0
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x785C1F0
        public void get_keys(){} // RVA: 0x165AD10
        public void set_keys(){} // RVA: 0x1667130
        public void .ctor(){} // RVA: 0x77D4F00
    }

}