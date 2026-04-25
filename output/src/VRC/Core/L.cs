// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 49

namespace VRC.Core
{
    public class LazySingleton`1 : MonoBehaviour
    {
        public System.Lazy`1<T> Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC2E8DC40
        public void CreateSingleton(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class LocalConfig : BaseConfig
    {
        public string configPath; // 0x18
        public bool autosave; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF29470
        public void SetValue(){} // RVA: 0x7FFACBF295B0
        public void FetchConfig(){} // RVA: 0x7FFACBF29650
        public void SaveConfig(){} // RVA: 0x7FFACBF29970
    }

    public class Logger : Object
    {
        public VRC.Core.ILoggerReceiver KnownLevels;
        public System.Collections.Generic.HashSet`1<string> ForcePassAllWarnings; // 0x8
        public bool ForcePassAllErrors; // 0x10
        public System.Collections.Generic.Dictionary`2<int,float> _timeLastLogPrintedForHash; // 0x18
        public System.Collections.Generic.Dictionary`2<string,CategoryPrefix> _categoryPrefixMap; // 0x20
        public string GlobalLoggerCategoryName;
        public bool <ForcePassAllWarnings>k__BackingField; // 0x28
        public bool <ForcePassAllErrors>k__BackingField; // 0x29

        // ── Methods ──
        public void AssignLoggerProvider(){} // RVA: 0x7FFACBF2AC40
        public void get_KnownLevels(){} // RVA: 0x7FFACBF2ACF0
        public void get_ForcePassAllWarnings(){} // RVA: 0x7FFACBF2AD40
        public void set_ForcePassAllWarnings(){} // RVA: 0x7FFACBF2ADA0
        public void get_ForcePassAllErrors(){} // RVA: 0x7FFACBF2AE00
        public void set_ForcePassAllErrors(){} // RVA: 0x7FFACBF2AE60
        public void IsValidActualCategory(){} // RVA: 0x7FFACBF2AEC0
        public void DescribeCategory(){} // RVA: 0x7FFACBF2AFB0 | overloaded x2
        public void CategoryIsDescribed(){} // RVA: 0x7FFACBF2B130
        public void SetEnabledCategory(){} // RVA: 0x7FFACBF2B1D0
        public void SetEnabledCategories(){} // RVA: 0x7FFACBF2B2F0
        public void ClearEnabledCategories(){} // RVA: 0x7FFACBF2B5D0
        public void EnableCategory(){} // RVA: 0x7FFACBF2B6E0
        public void DisableCategory(){} // RVA: 0x7FFACBF2B800
        public void SetTreatAllCategoriesAsEnabled(){} // RVA: 0x7FFACBF2B900
        public void CategoryIsEnabled(){} // RVA: 0x7FFACBF2B960
        public void Log(){} // RVA: 0x7FFACBF2BA60
        public void LogWarning(){} // RVA: 0x7FFACBF2BBC0
        public void LogError(){} // RVA: 0x7FFACBF2BD40
        public void LogException(){} // RVA: 0x7FFACBF2BEC0
        public void LogFormat(){} // RVA: 0x7FFACBF2C140 | overloaded x2
        public void LogFormatWithCategory(){} // RVA: 0x7FFACBF2C1C0 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x7FFACBF2C410 | overloaded x2
        public void LogWarningFormatWithCategory(){} // RVA: 0x7FFACBF2C490 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x7FFACBF2C6E0 | overloaded x2
        public void LogErrorFormatWithCategory(){} // RVA: 0x7FFACBF2C760 | overloaded x2
        public void LogOnceEvery(){} // RVA: 0x7FFACBF2C8C0
        public void LogOnceEveryFormat(){} // RVA: 0x7FFACBF2CA00 | overloaded x2
        public void LogOnceEveryHashFormat(){} // RVA: 0x7FFACBF2CA90
        public void GetCallingStackFrameHash(){} // RVA: 0x7FFACBF2CCF0
        public void MakePrefix(){} // RVA: 0x7FFACBF2CF30 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACBF2D1E0
    }

}