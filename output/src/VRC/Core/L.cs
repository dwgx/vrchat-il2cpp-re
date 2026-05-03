// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 52

namespace VRC.Core
{
    public class LazySingleton`1 : MonoBehaviour
    {
        public System.Lazy`1<T> LazyInstance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE810A1420
        public void CreateSingleton(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class LegacyTMPHelpers : Object
    {
        // ── Methods ──
        public void IsBuiltInTMProShader(){} // RVA: 0x7FFE8A395360
        public void ShouldUseLegacyUVs(){} // RVA: 0x7FFE8A3955E0
        public void .cctor(){} // RVA: 0x7FFE8A395730
    }

    public class LocalConfig : BaseConfig
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A389BE0
        public void SetValue(){} // RVA: 0x7FFE8A389D20
        public void FetchConfig(){} // RVA: 0x7FFE8A389DC0
        public void SaveConfig(){} // RVA: 0x7FFE8A38A0E0
    }

    public class Logger : Object
    {
        public VRC.Core.ILoggerReceiver _assignedLoggerReceiver;
        public System.Collections.Generic.HashSet`1<string> _enabledCategories; // 0x8
        public bool _treatAllCategoriesAsEnabled; // 0x10

        // ── Methods ──
        public void AssignLoggerProvider(){} // RVA: 0x7FFE8A38B3B0
        public void get_KnownLevels(){} // RVA: 0x7FFE8A38B460
        public void get_ForcePassAllWarnings(){} // RVA: 0x7FFE8A38B4B0
        public void set_ForcePassAllWarnings(){} // RVA: 0x7FFE8A38B510
        public void get_ForcePassAllErrors(){} // RVA: 0x7FFE8A38B570
        public void set_ForcePassAllErrors(){} // RVA: 0x7FFE8A38B5D0
        public void IsValidActualCategory(){} // RVA: 0x7FFE8A38B630
        public void DescribeCategory(){} // RVA: 0x7FFE8A38B720 | overloaded x2
        public void CategoryIsDescribed(){} // RVA: 0x7FFE8A38B8A0
        public void SetEnabledCategory(){} // RVA: 0x7FFE8A38B940
        public void SetEnabledCategories(){} // RVA: 0x7FFE8A38BA60
        public void ClearEnabledCategories(){} // RVA: 0x7FFE8A38BD40
        public void EnableCategory(){} // RVA: 0x7FFE8A38BE50
        public void DisableCategory(){} // RVA: 0x7FFE8A38BF70
        public void SetTreatAllCategoriesAsEnabled(){} // RVA: 0x7FFE8A38C070
        public void CategoryIsEnabled(){} // RVA: 0x7FFE8A38C0D0
        public void Log(){} // RVA: 0x7FFE8A38C1D0
        public void LogWarning(){} // RVA: 0x7FFE8A38C330
        public void LogError(){} // RVA: 0x7FFE8A38C4B0
        public void LogException(){} // RVA: 0x7FFE8A38C630
        public void LogFormat(){} // RVA: 0x7FFE8A38C8B0 | overloaded x2
        public void LogFormatWithCategory(){} // RVA: 0x7FFE8A38C930 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x7FFE8A38CB80 | overloaded x2
        public void LogWarningFormatWithCategory(){} // RVA: 0x7FFE8A38CC00 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x7FFE8A38CE50 | overloaded x2
        public void LogErrorFormatWithCategory(){} // RVA: 0x7FFE8A38CED0 | overloaded x2
        public void LogOnceEvery(){} // RVA: 0x7FFE8A38D030
        public void LogOnceEveryFormat(){} // RVA: 0x7FFE8A38D170 | overloaded x2
        public void LogOnceEveryHashFormat(){} // RVA: 0x7FFE8A38D200
        public void GetCallingStackFrameHash(){} // RVA: 0x7FFE8A38D460
        public void MakePrefix(){} // RVA: 0x7FFE8A38D6A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8A38D950
    }

}