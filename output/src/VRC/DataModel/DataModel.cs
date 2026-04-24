// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.DataModel
// Classes: 4
// Methods: 63

namespace VRC.DataModel
{
    public class KeyboardData : Object
    {
        public itTypeSize=876 ActiveRequest; // 0x10
        public itTypeSize=876 Title; // 0x38
        public object PlaceholderText; // 0x60
        public object InputType; // 0x64
        public int ContentType; // 0x68
        public ÍÏÎÍÏÏÌÏÏÍÏÌÌÎÌÎÌ CharacterLimit; // 0x6C
        public 2_FE_LONGS KeyboardType; // 0x70
        public int KeyboardRadioButtonGroup; // 0x74
        public bool DefaultRadioButtonGroupValue; // 0x78
        public bool Multiline; // 0x79
        public itTypeSize=876 ReadOnly; // 0x80
        public itTypeSize=876 PreviousInput; // 0xA8
        public bool OnInputChanged; // 0xD0
        public ÎÌÏÍ OnInputSubmitted; // 0xD8
        public string OnInputCanceled; // 0xE0
        public ileFullDirectoryInformation<string> OnRadioOptionSet; // 0xE8
        public ileFullDirectoryInformation<string> IsWorldKeyboard; // 0xF0
        public ÎÌÍÏÏÌÍÏ StayOpenAfterSubmit; // 0xF8
        public ileFullDirectoryInformation<int> SubmitButtonText; // 0x100
        public bool CancelButtonText; // 0x108

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCD49F0
        public void Initialize(){} // RVA: 0x7FFD4FCD4C60
        public void get_PlaceholderText(){} // RVA: 0x7FFD4E9FB780
        public void set_SocketFlags(){} // RVA: 0x7FFD4FCD4C80
        public void get_Title(){} // RVA: 0x7FFD4EC33C20
        public void get_CharacterLimit(){} // RVA: 0x7FFD4F7F9E20
        public void set_OnInputCanceled(){} // RVA: 0x7FFD4E8C4860
        public void set_CharacterLimit(){} // RVA: 0x7FFD4FCD4C80
        public void set_name(){} // RVA: 0x7FFD4FCD4C90
        public void set_OnRadioOptionSet(){} // RVA: 0x7FFD4E916750
        public void get_DefaultRadioButtonGroupValue(){} // RVA: 0x7FFD4FBDAB50
        public void get_OnInputCanceled(){} // RVA: 0x7FFD4E751F50
        public void set_KeyboardRadioButtonGroup(){} // RVA: 0x7FFD4FCD4C90
        public void get_KeyboardRadioButtonGroup(){} // RVA: 0x7FFD4E558CA0
        public void get_StayOpenAfterSubmit(){} // RVA: 0x7FFD4F5B6030
        public void Instantiate(){} // RVA: 0x7FFD4FCD4DC0
        public void get_OnRadioOptionSet(){} // RVA: 0x7FFD4E916C80
        public void get_OnInputSubmitted(){} // RVA: 0x7FFD4E3AC2A0
        public void get_OnInputChanged(){} // RVA: 0x7FFD4E3C2970
        public void Destroy(){} // RVA: 0x7FFD4FCD50C0
        public void set_DefaultRadioButtonGroupValue(){} // RVA: 0x7FFD4FBDAB60
        public void get_ContentType(){} // RVA: 0x7FFD4EFB9E80
        public void get_ScreenshotCompression(){} // RVA: 0x7FFD4E558C20
        public void FindObjectsOfType(){} // RVA: 0x7FFD4FCD50C0
        public void set_ActiveRequest(){} // RVA: 0x7FFD4E3C28A0
        public void get_CancelButtonText(){} // RVA: 0x7FFD4FCD50D0
        public void get_KeyboardType(){} // RVA: 0x7FFD4E558C20
        public void set_OnInputChanged(){} // RVA: 0x7FFD4E3C2980
        public void get_IsWorldKeyboard(){} // RVA: 0x7FFD4E7EFDE0
        public void get_PreviousInput(){} // RVA: 0x7FFD4E3C2900
        public void get_ReadOnly(){} // RVA: 0x7FFD4E7EC650
        public void set_ReadOnly(){} // RVA: 0x7FFD4FCD5100
        public void set_PreviousInput(){} // RVA: 0x7FFD4E3C2910
        public void get_ActiveRequest(){} // RVA: 0x7FFD4E960F70
        public void get_currentSubmeshIndex(){} // RVA: 0x7FFD4FBDAB70
        public void get_SubmitButtonText(){} // RVA: 0x7FFD4E9E9610
        public void get_Multiline(){} // RVA: 0x7FFD4E7EE5C0
        public void get_InputType(){} // RVA: 0x7FFD4FBDAB70
        public void set_ipsQuery(){} // RVA: 0x7FFD4E3AC2B0
        public void set_OnInputSubmitted(){} // RVA: 0x7FFD4E3AC2B0
        public void set_StayOpenAfterSubmit(){} // RVA: 0x7FFD4F5B6040
        public void op_Inequality(){} // RVA: 0x7FFD4FCD54A0
    }

    public class QuitHandler : Object
    {
        public ÎÌ.ÏÍÏÍÏÌÎÌ ÏÌÍÌÍÎÏÎÌÎÌÎÏÎÍÍÎÏÎÎÍÏÍ;
        public URA.woDigitYearMax<?> ÎÍÎÎÏÏÎÏÏÏÌÍÍÍÎÏÎÏÏÎÏÏÌ; // 0x10
        public ÏÍÍÍÏÎÎÎÍÌÏÍÏÏÌ ÏÎÌÏÎÎÍÎÎÍÍÏÌÏÎÎÏÌÎÏÏÎÎ; // 0x18
        public float ÎÌÎÎÌÍÏÏÏÎÍÍÌÏÍÍÏÏÏÎÏÌÌ;
        public float ÎÍÍÏÎÍÏÍÎÏÍÌÌÏÎÏÎÎÏÏÏÌÍ; // 0x1C

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E945DA0
        public void .ctor(){} // RVA: 0x7FFD4E945F20
        public void Equals(){} // RVA: 0x7FFD4E945FE0
        public void op_Implicit(){} // RVA: 0x7FFD4E946040
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E946170
        public void Initialize(){} // RVA: 0x7FFD4E9461D0
        public void GetCachedPtr(){} // RVA: 0x7FFD4E946350
        public void get_name(){} // RVA: 0x7FFD4E9463B0
        public void set_name(){} // RVA: 0x7FFD4E946540
        public void Instantiate(){} // RVA: 0x7FFD4E9466C0
        public void GetHashCode(){} // RVA: 0x7FFD4E946890
        public void .cctor(){} // RVA: 0x7FFD4E9469C0
        public void ToString(){} // RVA: 0x7FFD4E946B20
    }

    public class SupportedPlatformData : Object
    {
        public ÌÏÏÏÎÍÍÏÎÎÏÌÌÎÌÌ Platform; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class VRCData : Object
    {
        public ÎÍÏÎÍÏÌÍÌÏÍÌÎÎÏÍÌÎ _vRCData;
        public ÍÍÏÌ ÍÍÍÍÍÎÎÍÎÍÌÍÍÏÎÌÏÌÎÏÎÎÎ; // 0x8
        public ÍÌ ÏÏÎÍÍÎÏÌÍÏÎÍÎÏÏÌÍÌÏÍÎÍÏ; // 0x10
        public ÌÎÏÌÌÍÏÎÏÌÏÏÏÎÏÏ ÌÍÍÌÍÌÍÌÎÎÎÏÌÎÎÌÍÌÎÎÏÎÏ; // 0x18
        public ?<ÎÎÌÍÍÌÌÍ> <ÏÍÌÎÌÏÌÌÎÌÌÎÌÎÌÍÏÏÎÏÌÎÍ>k__BackingField; // 0x20
        public object ÏÍÎÌÏÏÍÏÌÌÌÎÏÍÏÎÌÌÌÏÏÍÎ; // 0x28
        public object ÍÍÍÍÌÍÍÏÍÌÏÏÌÌÌÌÏÌÌÍÌÌÌ; // 0x30
        public ÎÌÌÌÌÍÏÌ ÌÎÌÎÍÍÎÍÏÌÌÎÍÎÍÏÎÍÎÏÏÏÎ; // 0x38
        public ÍÎÌÎ ÌÎÏÌÍÏÎÎÍÌÏÍÌÏÎÎÌÏÎÏÎÍÏ; // 0x40
        public object ÍÎÎÏÍÌÍÌÎÍÌÏÌÌÏÍÌÏÍÌÎÍÏ; // 0x48
        public ncat ÍÍÍÏÎÎÎÎÎÍÌÏÍÎÎÏÎÎÏÌÎÎÏ; // 0x50
        public ÍÌÌÏÌÏÏÏÏÎÏÏÎÎÌÏ ÍÍÌÌÏÎÏÌÍÍÌÍÍÏÌÍÏÏÏÍÍÌÌ; // 0x58
        public ÎÌÎÍÍÌÏÎÌÏÌÎÍÌÌÌ ÏÍÏÌÌÎÌÎÎÎÍÎÏÌÏÏÎÎÍÏÎÌÎ; // 0x60
        public object ÎÍÏÎÍÌÍÍÍÌÎÍÍÍÍÌÏÍÎÎÏÍÍ; // 0x68
        public ÍÎÏÎÌÎÌÎÍÍÎÎÏÌÏÌ ÏÎÌÎÌÍÍÌÍÏÎÎÎÎÍÌÌÏÌÏÎÌÍ; // 0x70
        public object ÎÏÏÎÌÍÍÌÏÌÏÍÏÌÎÌÌÎÏÌÌÍÍ; // 0x78
        public object ÎÏÌÍÍÎÍÎÍÏÏÍÎÎÌÎÏÏÎÌÏÏÎ; // 0x80
        public ÏÌÏÏÍÏÏÌÌÏÏÍÌÎÎÍÌÌÌÌ ÌÍÏÎÎÎÍÌÌÎÍÏÌÎÌÍÏÍÌÎÏÎÎ; // 0x88
        public ÏÌ ÎÌÍÍÏÏÎÍÎÎÍÌÍÌÏÌÍÍÌÍÎÏÍ; // 0x90
        public object ÍÌÍÎÎÌÏÎÎÏÌÌÎÏÎÎÎÏÎÏÎÌÏ; // 0x98
        public ÏÌÌÏÎÎ ÏÏÎÏÎÎÎÌÌÏÍÍÏÍÎÎÎÌÎÎÍÏÏ; // 0xA0
        public object ÍÎÌÌÍÏÎÏÏÏÏÌÏÌÏÍÏÎÏÏÍÌÌ; // 0xA8
        public object ÍÍÍÌÎÌÍÌÎÏÎÌÍÌÍÍÏÍÎÍÎÌÍ; // 0xB0
        public e ÏÌÍÎÏÍÎÍÏÍÎÎÏÍÌÎÍÎÏÏÌÍÍ; // 0xB8
        public ÌÏÍÎ ÎÏÍÎÎÌÏÍÌÏÌÍÏÏÏÌÎÌÎÌÍÎÍ; // 0xC0
        public ÍÏÎÌÎÍÏÏÎÌ>k__BackingField ÎÌÏÎÏÌÎÌÌÏÍÍÏÏÏÌÏÏÍÎÏÎÏ; // 0xC8
        public object ÎÌÏÌÍÏÏÍÏÎÎÏÎÍÎÎÏÏÌÎÎÎÍ; // 0xD0
        public ÍÏ ÌÍÌÍÍÏÏÎÏÌÎÎÌÍÍÏÏÎÏÌÍÏÍ; // 0xD8
        public ÌÏ ÎÌÎÏÏÎÍÍÌÍÌÌÎÍÌÌÌÏÎÏÌÌÌ; // 0xE0
        public ÍÎÎÍÌÎÍÏÍÌÎÍÏ ÎÎÍÌÌÏÌÍÍÎÎÍÍÌÌÎÍÌÍÎÌÏÍ; // 0xE8
        public object ÏÌÍÏÎÌÎÏÏÎÍÌÌÍÍÌÎÎÌÍÏÎÌ; // 0xF0
        public utes.TRING ÌÌÏÏÌÌÌÎÌÌÎÏÏÌÌÎÌÎÍÍÍÌÌ; // 0xF8
        public anString ÎÎÏÌÏÎÌÍÌÎÌÌÌÎÏÏÏÍÍÍÍÏÍ; // 0x100
        public e ÏÏÏÌÏÌÎÎÎÌÎÍÌÏÍÎÎÎÏÌÍÌÍ; // 0x108
        public ÍÎ ÏÌÍÍÌÌÎÌÍÌÏÌÍÎÍÍÎÍÌÎÍÎÏ; // 0x110
        public ÌÍÌÏÎÌ ÎÌÏÍÍÏÏÍÌÌÌÍÎÏÏÍÏÎÏÎÌÏÍ; // 0x118
        public object ÌÎÍÏÏÎÌÍÏÏÎÌÍÌÎÍÏÍÏÏÏÍÎ; // 0x120
        public object ÌÎÎÌÌÏÍÏÍÏÍÌÏÏÍÌÏÏÏÍÏÏÏ; // 0x128
        public object ÍÌÌÎÎÎÌÏÍÎÌÏÌÌÌÎÍÎÎÎÌÍÎ; // 0x130
        public object ÎÌÏÍÍÍÏÍÎÏÏÍÎÍÏÏÏÌÏÎÌÌÍ; // 0x138
        public object ÍÍÌÍÍÌÏÎÎÎÎÏÍÏÏÎÌÍÍÍÌÏÍ; // 0x140
        public object ÌÏÏÏÍÎÎÌÌÌÏÏÎÎÌÎÍÍÍÎÎÏÎ; // 0x148
        public ÏÍ ÌÌÌÏÌÌÍÌÎÍÎÍÏÌÌÍÍÌÎÌÏÎÎ; // 0x150
        public ÏÎÌÎÌÍÎÍÍÌÌÎ ÎÌÏÌÌÏÌÍÌÎÏÌÌÎÎÌÌÎÍÍÎÏÌ; // 0x158
        public utes.Y_STRING ÎÎÏÍÏÏÏÌÌÏÌÎÌÌÌÎÌÎÌÌÎÍÎ; // 0x160
        public object ÍÍÍÏÎÍÎÎÍÏÎÌÎÏÍÏÏÏÍÎÎÌÌ; // 0x168
        public ÏÍÎÍÍÏÏÎÍÌÏ ÏÍÏÎÎÎÍÎÌÌÍÎÍÏÏÍÎÍÎÏÌÍÍ; // 0x170
        public ÏÏÌÏÎÌÎÌÎÏÍÎÏÍÏÌ ÌÎÎÎÏÏÎÏÍÍÍÌÌÍÏÏÎÌÍÎÍÏÌ; // 0x178
        public ÍÎÍÎÎÏÏÌÎÍÌÌÎÍÎÍ ÏÎÌÍÍÌÍÌÌÎÎÎÏÎÍÍÏÎÌÌÎÍÎ; // 0x180
        public ÍÏÎÏ ÍÎÍÏÏÌÍÍÏÎÎÌÎÍÎÎÏÏÏÎÏÍÌ; // 0x188
        public ÏÏÏÍÎÍÍÏ ÎÏÎÎÍÏÍÏÍÎÌÏÍÏÍÎÎÌÌÌÌÎÏ; // 0x190
        public ÍÍÌÏÏÌÍÍÎÌÌÍÍ ÍÏÌÏÏÌÏÎÎÍÌÍÌÍÍÍÎÍÎÍÌÍÎ; // 0x198
        public ldCard ÎÏÌÏÍÎÌÍÌÏÍÎÍÏÍÍÎÍÍÍÍÏÎ; // 0x1A0
        public object ÌÌÌÏÌÏÍÏÍÍÎÌÏÌÌÍÏÎÍÎÏÎÎ; // 0x1A8
        public age ÎÍÏÏÌÏÎÌÏÌÌÍÌÏÍÎÏÏÌÍÍÎÍ; // 0x1B0
        public an ÏÍÌÎÏÎÏÏÎÎÎÍÌÏÍÌÎÌÎÏÍÍÌ; // 0x1B8
        public st ÎÎÏÏÍÎÏÌÌÍÌÌÎÎÍÎÍÎÌÌÎÎÍ; // 0x1C0
        public object ÏÌÏÍÍÏÎÌÏÎÌÍÍÎÌÍÏÏÎÌÏÏÍ; // 0x1C8
        public object ÎÏÌÏÌÍÎÍÍÏÍÎÌÍÌÎÏÌÌÎÏÎÌ; // 0x1D0
        public ÎÌÌÌÍÍÍÏÏÎÏÏÌÏÌÌ ÎÎÎÌÍÌÎÍÏÎÎÍÌÎÎÍÍÎÎÌÎÏÍ; // 0x1D8
        public object ÏÍÎÎÏÏÎÍÎÏÌÌÍÎÍÏÎÌÌÎÎÍÏ; // 0x1E0
        public utes.NG ÎÍÍÏÌÌÍÏÎÍÎÍÌÏÍÍÍÍÍÏÍÍÍ; // 0x1E8
        public ÎÍÎÍ ÌÏÍÎÍÎÌÍÌÎÏÏÍÏÏÎÎÌÍÏÏÎÌ; // 0x1F0
        public ast ÎÎÍÌÍÍÎÏÍÏÏÌÎÌÏÎÎÍÏÏÌÎÌ; // 0x1F8
        public object ÌÌÏÍÎÍÎÌÏÏÎÏÍÍÌÍÎÌÌÍÎÎÌ; // 0x200
        public ÎÏÎÍÍÏÍÏÌÌÌÏÍÎÍÌÌÌ ÍÌÏÌÍÌÌÍÌÎÍÏÌÏÎÏÌÏÏÏÍÎÍ; // 0x208
        public ue ÏÏÏÏÌÍÌÌÏÏÏÌÌÌÍÎÍÏÍÏÌÍÌ; // 0x210
        public object ÍÎÏÎÍÌÎÎÎÎÌÌÎÎÏÌÍÎÌÌÎÎÍ; // 0x218
        public ÎÏÎ ÌÌÌÍÌÍÎÍÎÏÍÍÌÏÍÎÍÎÍÎÍÍÌ; // 0x220
        public e ÏÏÍÏÎÎÍÏÌÍÏÎÌÍÏÏÎÎÍÎÎÌÏ; // 0x228
        public object ÏÏÍÏÍÌÎÏÌÍÍÌÌÌÎÎÍÏÏÎÌÎÏ; // 0x230
        public object ÍÏÏÎÏÍÎÎÌÍÍÏÍÎÏÏÌÌÍÌÌÌÏ; // 0x238
        public object ÌÍÌÏÏÍÌÌÍÏÎÎÏÏÍÎÌÌÌÍÍÍÍ; // 0x240
        public itudeAssist ÌÎÏÌÌÎÌÏÏÏÏÌÎÏÏÏÎÍÍÌÌÏÏ; // 0x248
        public object ÎÍÎÎÏÏÎÍÌÎÏÌÍÍÏÌÎÏÍÎÏÏÌ; // 0x250
        public object ÌÏÎÏÏÎÏÌÌÌÌÏÎÏÎÎÏÎÎÍÏÎÌ; // 0x258
        public ÎÌÎÌÌÎÍÌ ÎÏÏÎÌÏÏÎÏÌÏÎÏÏÏÎÍÎÎÍÍÏÎ; // 0x260
        public object ÍÍÌÍÎÌÏÌÍÎÍÏÎÎÏÍÌÎÎÌÏÍÍ; // 0x268
        public ÎÍÌÎÏÍÏÍÏÎÏÍÍÍÏÍ ÎÌÎÏÏÌÎÎÌÍÌÍÎÏÌÌÎÍÎÌÏÏÌ; // 0x270
        public ÏÌÌÎÎÌÌÎÍÎÍÌÏÌÍÏÏÎÎÏ ÎÎÍÌÏÌÍÌÎÍÍÎÍÍÏÎÏÎÌÏÏÍÍ; // 0x278
        public tionGroup ÍÏÌÎÎÍÍÎÎÌÌÌÏÏÏÎÍÌÍÌÌÌÏ; // 0x280
        public utes.et_venueId ÏÌÏÏÎÎÌÎÌÎÏÌÎÎÏÌÌÎÌÌÌÎÌ; // 0x288
        public utes._ONLY_SHORT_STRING ÎÍÏÍÎÏÏÎÌÌÏÍÏÍÎÏÍÏÏÎÍÌÏ; // 0x290
        public utes.workRegion ÎÎÌÌÍÏÌÍÏÎÍÎÏÍÍÍÌÍÍÍÍÍÍ; // 0x298
        public ÎÍÏÍÍÌÌÎÏÍÌÏÏ ÍÍÍÎÏÏÎÏÏÎÌÏÎÏÍÌÎÌÏÎÍÎÌ; // 0x2A0
        public ÎÏÏÌÍÏÏÍÏÏÏÏÌÍÍÍ ÎÏÎÎÍÎÏÏÍÍÎÎÏÍÌÎÎÍÌÌÏÍÌ; // 0x2A8
        public object ÎÎÍÏÏÌÍÎÍÏÏÌÌÍÌÍÍÏÎÍÍÌÏ; // 0x2B0
        public object ÏÎÏÌÎÎÌÏÏÏÏÍÏÎÎÌÎÏÏÍÏÏÍ; // 0x2B8
        public object ÏÍÎÍÎÏÎÍÎÎÌÎÌÏÎÍÍÏÎÍÏÎÎ; // 0x2C0
        public ÌÎÏÍÏÌÍÍÍÏÍÎÏÎÌÌ ÏÏÏÌÎÍÏÎÏÎÍÌÌÍÏÏÏÍÌÍÍÍÏ; // 0x2C8
        public ÌÌÏÎÌÎÍÍÏÌÌÍÏÎÍÏ ÏÎÏÍÏÏÍÍÎÏÎÏÏÏÏÌÌÌÏÎÏÌÌ; // 0x2D0
        public ÏÌÍÏÌÏÌÎÎÍÌÎÎÎÌÍÎÎÎÍÍ ÍÏÌÎÏÍÌÎÌÍÍÌÏÍÏÏÏÏÎÏÌÍÍ; // 0x2D8
        public CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D ÎÌÏÍÏÎÌÏÏÏÍÎÌÏÎÏÌÍÍÍÍÎÏ; // 0x2E0
        public object ÍÎÏÎÌÌÍÌÎÌÌÌÌÎÌÍÌÎÍÍÏÍÏ; // 0x2E8
        public ontentRestriction ÌÎÌÎÎÌÎÌÏÌÎÏÎÎÎÍÏÍÏÏÍÏÍ; // 0x2F0
        public ÌÍÎÍÏÎÏÍÌÏÌÏÎÍÏÎ ÍÏÏÌÍÎÍÌÏÏÌÍÍÏÎÏÌÌÌÌÌÏÍ; // 0x2F8
        public ÎÎÌÍÌÏÌÎÎÎ>k__BackingField ÎÎÎÍÎÏÎÏÍÎÎÌÏÎÍÎÌÎÌÎÍÌÍ; // 0x300
        public utes.roup ÏÍÎÍÎÎÏÏÍÏÍÎÎÍÌÌÎÌÎÍÎÎÌ; // 0x308
        public object ÎÎÏÎÍÍÏÍÌÎÌÏÌÏÎÎÍÏÍÍÌÍÍ; // 0x310
        public ÌÏÏÏÎÍÍÏÎÎÏÌÌÎÌÌ ÍÌÍÎÎÏÍÍÍÍÍÍÎÏÍÎÌÎÌÎÏÍÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FCD5500
        public void Initialize(){} // RVA: 0x7FFD4FCD5560
        public void Equals(){} // RVA: 0x7FFD4FCD55F0
        public void op_Implicit(){} // RVA: 0x7FFD4FCD5720
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FCD5870
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FCD59C0
        public void .cctor(){} // RVA: 0x7FFD4FCD5A30
    }

}