// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 52

namespace VRC.Core
{
    public class LazySingleton`1
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x283FA0
        public void CreateSingleton(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class LegacyTMPHelpers
    {
        // ── Methods ──
        public void IsBuiltInTMProShader(){} // RVA: 0x9939160
        public void IsPreU6Bundle(){} // RVA: 0x99393E0
        public void .cctor(){} // RVA: 0x9939550
    }

    public class LocalConfig
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x992DBB0
        public void SetValue(){} // RVA: 0x992DCF0
        public void FetchConfig(){} // RVA: 0x992DD90
        public void SaveConfig(){} // RVA: 0x992E0B0
    }

    public class Logger
    {
        // ── Methods ──
        public void AssignLoggerProvider(){} // RVA: 0x992F380
        public void get_KnownLevels(){} // RVA: 0x992F430
        public void get_ForcePassAllWarnings(){} // RVA: 0x992F480
        public void set_ForcePassAllWarnings(){} // RVA: 0x992F4E0
        public void get_ForcePassAllErrors(){} // RVA: 0x992F540
        public void set_ForcePassAllErrors(){} // RVA: 0x992F5A0
        public void IsValidActualCategory(){} // RVA: 0x992F600
        public void DescribeCategory(){} // RVA: 0x992F6F0 | overloaded x2
        public void CategoryIsDescribed(){} // RVA: 0x992F870
        public void SetEnabledCategory(){} // RVA: 0x992F910
        public void SetEnabledCategories(){} // RVA: 0x992FA30
        public void ClearEnabledCategories(){} // RVA: 0x992FD10
        public void EnableCategory(){} // RVA: 0x992FE20
        public void DisableCategory(){} // RVA: 0x992FF40
        public void SetTreatAllCategoriesAsEnabled(){} // RVA: 0x9930040
        public void CategoryIsEnabled(){} // RVA: 0x99300A0
        public void Log(){} // RVA: 0x99301A0
        public void LogWarning(){} // RVA: 0x9930300
        public void LogError(){} // RVA: 0x9930480
        public void LogException(){} // RVA: 0x9930600
        public void LogFormat(){} // RVA: 0x9930880 | overloaded x2
        public void LogFormatWithCategory(){} // RVA: 0x9930900 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x9930B50 | overloaded x2
        public void LogWarningFormatWithCategory(){} // RVA: 0x9930BD0 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x9930E20 | overloaded x2
        public void LogErrorFormatWithCategory(){} // RVA: 0x9930EA0 | overloaded x2
        public void LogOnceEvery(){} // RVA: 0x9931000
        public void LogOnceEveryFormat(){} // RVA: 0x9931140 | overloaded x2
        public void LogOnceEveryHashFormat(){} // RVA: 0x99311D0
        public void GetCallingStackFrameHash(){} // RVA: 0x9931430
        public void MakePrefix(){} // RVA: 0x9931670 | overloaded x2
        public void .cctor(){} // RVA: 0x9931920
    }

}