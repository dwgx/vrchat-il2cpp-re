// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 49

namespace VRC.Core
{
    public class LazySingleton`1 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaa887e5c0
        public void CreateSingleton(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class LocalConfig : BaseConfig
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1945140
        public void FetchConfig(){} // RVA: 0x7ffab1945320
        public void SaveConfig(){} // RVA: 0x7ffab1945640
        // ── Binary Analysis Named ──
        public void SetValue(){} // RVA: 0x7ffab1945280
    }

    public class Logger : Object
    {
        public object _treatAllCategoriesAsEnabled; // 0x34F3B410
        public object GlobalLoggerCategoryName; // 0x34F3B410

        // ── Original Methods ──
        public void AssignLoggerProvider(){} // RVA: 0x7ffab1946910
        public void get_KnownLevels(){} // RVA: 0x7ffab19469c0
        public void get_ForcePassAllWarnings(){} // RVA: 0x7ffab1946a10
        public void set_ForcePassAllWarnings(){} // RVA: 0x7ffab1946a70
        public void get_ForcePassAllErrors(){} // RVA: 0x7ffab1946ad0
        public void set_ForcePassAllErrors(){} // RVA: 0x7ffab1946b30
        public void IsValidActualCategory(){} // RVA: 0x7ffab1946b90
        public void DescribeCategory(){} // RVA: 0x7ffab1946c80
        public void DescribeCategory(){} // RVA: 0x7ffab1946c80
        public void CategoryIsDescribed(){} // RVA: 0x7ffab1946e00
        public void ClearEnabledCategories(){} // RVA: 0x7ffab19472a0
        public void EnableCategory(){} // RVA: 0x7ffab19473b0
        public void DisableCategory(){} // RVA: 0x7ffab19474d0
        public void CategoryIsEnabled(){} // RVA: 0x7ffab1947630
        public void Log(){} // RVA: 0x7ffab1947730
        public void LogWarning(){} // RVA: 0x7ffab1947890
        public void LogError(){} // RVA: 0x7ffab1947a10
        public void LogException(){} // RVA: 0x7ffab1947b90
        public void LogFormat(){} // RVA: 0x7ffab1947e10
        public void LogFormatWithCategory(){} // RVA: 0x7ffab1947e90
        public void LogFormat(){} // RVA: 0x7ffab1947e10
        public void LogFormatWithCategory(){} // RVA: 0x7ffab1947e90
        public void LogWarningFormat(){} // RVA: 0x7ffab19480e0
        public void LogWarningFormatWithCategory(){} // RVA: 0x7ffab1948160
        public void LogWarningFormat(){} // RVA: 0x7ffab19480e0
        public void LogWarningFormatWithCategory(){} // RVA: 0x7ffab1948160
        public void LogErrorFormat(){} // RVA: 0x7ffab19483b0
        public void LogErrorFormatWithCategory(){} // RVA: 0x7ffab1948430
        public void LogErrorFormat(){} // RVA: 0x7ffab19483b0
        public void LogErrorFormatWithCategory(){} // RVA: 0x7ffab1948430
        public void LogOnceEvery(){} // RVA: 0x7ffab1948590
        public void LogOnceEveryFormat(){} // RVA: 0x7ffab19486d0
        public void LogOnceEveryFormat(){} // RVA: 0x7ffab19486d0
        public void LogOnceEveryHashFormat(){} // RVA: 0x7ffab1948760
        public void MakePrefix(){} // RVA: 0x7ffab1948c00
        public void MakePrefix(){} // RVA: 0x7ffab1948c00
        public void .cctor(){} // RVA: 0x7ffab1948eb0
        // ── Binary Analysis Named ──
        public void SetEnabledCategory(){} // RVA: 0x7ffab1946ea0
        public void SetEnabledCategories(){} // RVA: 0x7ffab1946fc0
        public void SetTreatAllCategoriesAsEnabled(){} // RVA: 0x7ffab19475d0
        public void GetCallingStackFrameHash(){} // RVA: 0x7ffab19489c0
    }

}