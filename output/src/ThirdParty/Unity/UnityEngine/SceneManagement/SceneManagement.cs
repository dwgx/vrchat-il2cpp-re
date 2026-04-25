// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 6
// Methods: 61

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class LoadSceneParameters : ValueType
    {
        public 0x6B182848 m_LoadSceneMode; // 0x10
        public 0x6B1828A0 m_LocalPhysicsMode; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98E35A0
    }

    public class Scene : ValueType
    {
        public int handle; // 0x10

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFAC98E1490
        public void GetNameInternal(){} // RVA: 0x7FFAC98E14E0
        public void GetIsLoadedInternal(){} // RVA: 0x7FFAC98E1530
        public void GetBuildIndexInternal(){} // RVA: 0x7FFAC98E1580
        public void GetRootCountInternal(){} // RVA: 0x7FFAC98E15D0
        public void GetRootGameObjectsInternal(){} // RVA: 0x7FFAC98E1620
        public void get_handle(){} // RVA: 0x7FFAC8F93F90
        public void IsValid(){} // RVA: 0x7FFAC98E1680
        public void get_name(){} // RVA: 0x7FFAC98E16D0
        public void get_isLoaded(){} // RVA: 0x7FFAC98E1720
        public void get_buildIndex(){} // RVA: 0x7FFAC98E1770
        public void get_rootCount(){} // RVA: 0x7FFAC98E17C0
        public void GetRootGameObjects(){} // RVA: 0x7FFAC98E1900 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC98B7FA0
        public void op_Inequality(){} // RVA: 0x7FFAC98E1C80
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC98E1C90
    }

    public class SceneManager : Object
    {
        public bool sceneCount;
        public UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene,0x6B182848> sceneCountInBuildSettings; // 0x8
        public UnityEngine.Events.UnityAction`1<UnityEngine.SceneManagement.Scene> sceneUnloaded; // 0x10
        public UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> activeSceneChanged; // 0x18

        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7FFAC98E2160
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7FFAC98E21B0
        public void GetActiveScene(){} // RVA: 0x7FFAC98E2220
        public void SetActiveScene(){} // RVA: 0x7FFAC98E22B0
        public void GetSceneByName(){} // RVA: 0x7FFAC98E2340
        public void GetSceneAt(){} // RVA: 0x7FFAC98E23E0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFAC98E2480
        public void LoadFirstScene_Internal(){} // RVA: 0x7FFAC98E2570
        public void add_sceneLoaded(){} // RVA: 0x7FFAC98E25E0
        public void remove_sceneLoaded(){} // RVA: 0x7FFAC98E2740
        public void add_sceneUnloaded(){} // RVA: 0x7FFAC98E28A0
        public void remove_sceneUnloaded(){} // RVA: 0x7FFAC98E2A00
        public void add_activeSceneChanged(){} // RVA: 0x7FFAC98E2B60
        public void remove_activeSceneChanged(){} // RVA: 0x7FFAC98E2CC0
        public void LoadScene(){} // RVA: 0x7FFAC98E2EF0 | overloaded x3
        public void LoadSceneAsync(){} // RVA: 0x7FFAC98E3190 | overloaded x5
        public void Internal_SceneLoaded(){} // RVA: 0x7FFAC98E3200
        public void Internal_SceneUnloaded(){} // RVA: 0x7FFAC98E32B0
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7FFAC98E3350
        public void .cctor(){} // RVA: 0x7FFAC98E3400
        public void GetActiveScene_Injected(){} // RVA: 0x7FFAC98E3440
        public void SetActiveScene_Injected(){} // RVA: 0x7FFAC98E3490
        public void GetSceneByName_Injected(){} // RVA: 0x7FFAC98E34E0
        public void GetSceneAt_Injected(){} // RVA: 0x7FFAC98E3540
    }

    public class SceneManagerAPI : Object
    {
        public UnityEngine.SceneManagement.SceneManagerAPI ActiveAPI;
        public UnityEngine.SceneManagement.SceneManagerAPI overrideAPI; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFAC98E1E70
        public void get_overrideAPI(){} // RVA: 0x7FFAC98E1F30
        public void set_overrideAPI(){} // RVA: 0x7FFAC98E1F90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7FFAC98E1D20
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7FFAC98E2050
        public void LoadFirstScene(){} // RVA: 0x7FFAC34F9180
        public void .cctor(){} // RVA: 0x7FFAC98E20C0
    }

    public class SceneManagerAPIInternal : Object
    {
        // ── Methods ──
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7FFAC98E1D20
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFAC98E1D70
        public void LoadSceneAsyncNameIndexInternal_Injected(){} // RVA: 0x7FFAC98E1DF0
    }

    public class SceneUtility : Object
    {
        // ── Methods ──
        public void GetScenePathByBuildIndex(){} // RVA: 0x7FFAC98E35B0
    }

}