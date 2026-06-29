// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 43

namespace VRC.Core
{
    public class LazySingleton`1 : MonoBehaviour
    {
        public object LazyInstance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0xA94080
        public void CreateSingleton(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class LegacyTMPHelpers : Object
    {
        public object CaretWidth;
        public object BuiltInTMPShaderTag;

        // ── Methods ──
        public void IsBuiltInTMProShader(){} // RVA: 0xA5E1020
        public void IsPreU6Bundle(){} // RVA: 0xA5E1260
        public void .cctor(){} // RVA: 0xA5E13D0
    }

    public class LocalConfig : BaseConfig
    {
        public object configPath;
        public object autosave;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5D5780
        public void SetValue(){} // RVA: 0xA5D58C0
        public void FetchConfig(){} // RVA: 0xA5D5960
        public void SaveConfig(){} // RVA: 0xA5D5C80
    }

    public class Logger : Object
    {
        public object _assignedLoggerReceiver;
        public object _enabledCategories;
        public object _treatAllCategoriesAsEnabled;
        public object _timeLastLogPrintedForHash;
        public object _categoryPrefixMap;
        public object GlobalLoggerCategoryName;
        public object _forcePassAllWarnings;
        public object _forcePassAllErrors;

        // ── Methods ──
        public void AssignLoggerProvider(){} // RVA: 0xA5D6F50
        public void get_KnownLevels(){} // RVA: 0xA5D7000
        public void get_ForcePassAllWarnings(){} // RVA: 0xA5D7050
        public void set_ForcePassAllWarnings(){} // RVA: 0xA5D70B0
        public void get_ForcePassAllErrors(){} // RVA: 0xA5D7110
        public void set_ForcePassAllErrors(){} // RVA: 0xA5D7170
        public void IsValidActualCategory(){} // RVA: 0xA5D71D0
        public void DescribeCategory(){} // RVA: 0xA5D72C0
        public void CategoryIsDescribed(){} // RVA: 0xA5D7440
        public void SetEnabledCategory(){} // RVA: 0xA5D74E0
        public void SetEnabledCategories(){} // RVA: 0xA5D7600
        public void ClearEnabledCategories(){} // RVA: 0xA5D78E0
        public void EnableCategory(){} // RVA: 0xA5D79F0
        public void DisableCategory(){} // RVA: 0xA5D7B10
        public void SetTreatAllCategoriesAsEnabled(){} // RVA: 0xA5D7C10
        public void CategoryIsEnabled(){} // RVA: 0xA5D7C70
        public void Log(){} // RVA: 0xA5D7D70
        public void LogWarning(){} // RVA: 0xA5D7ED0
        public void LogError(){} // RVA: 0xA5D8050
        public void LogException(){} // RVA: 0xA5D81D0
        public void LogFormat(){} // RVA: 0xA5D8450
        public void LogFormatWithCategory(){} // RVA: 0xA5D84D0
        public void LogWarningFormat(){} // RVA: 0xA5D8720
        public void LogWarningFormatWithCategory(){} // RVA: 0xA5D87A0
        public void LogErrorFormat(){} // RVA: 0xA5D89F0
        public void LogErrorFormatWithCategory(){} // RVA: 0xA5D8A70
        public void LogOnceEvery(){} // RVA: 0xA5D8BD0
        public void LogOnceEveryFormat(){} // RVA: 0xA5D8D10
        public void LogOnceEveryHashFormat(){} // RVA: 0xA5D8DA0
        public void GetCallingStackFrameHash(){} // RVA: 0xA5D9000
        public void MakePrefix(){} // RVA: 0xA5D9250
        public void .cctor(){} // RVA: 0xA5D94F0
    }

}