// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 6
// Methods: 61

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class LoadSceneParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x714B060
    }

    public class Scene
    {
        public int m_Handle; // 0x10

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7148F50
        public void GetNameInternal(){} // RVA: 0x7148FA0
        public void GetIsLoadedInternal(){} // RVA: 0x7148FF0
        public void GetBuildIndexInternal(){} // RVA: 0x7149040
        public void GetRootCountInternal(){} // RVA: 0x7149090
        public void GetRootGameObjectsInternal(){} // RVA: 0x71490E0
        public void get_handle(){} // RVA: 0x67FD0D0
        public void IsValid(){} // RVA: 0x7149140
        public void get_name(){} // RVA: 0x7149190
        public void get_isLoaded(){} // RVA: 0x71491E0
        public void get_buildIndex(){} // RVA: 0x7149230
        public void get_rootCount(){} // RVA: 0x7149280
        public void GetRootGameObjects(){} // RVA: 0x71493C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x711FA10
        public void op_Inequality(){} // RVA: 0x7149740
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x7149750
    }

    public class SceneManager
    {
        public bool s_AllowLoadScene;
        public UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene,0x6589E848> sceneLoaded; // 0x8

        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7149C20
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7149C70
        public void GetActiveScene(){} // RVA: 0x7149CE0
        public void SetActiveScene(){} // RVA: 0x7149D70
        public void GetSceneByName(){} // RVA: 0x7149E00
        public void GetSceneAt(){} // RVA: 0x7149EA0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7149F40
        public void LoadFirstScene_Internal(){} // RVA: 0x714A030
        public void add_sceneLoaded(){} // RVA: 0x714A0A0
        public void remove_sceneLoaded(){} // RVA: 0x714A200
        public void add_sceneUnloaded(){} // RVA: 0x714A360
        public void remove_sceneUnloaded(){} // RVA: 0x714A4C0
        public void add_activeSceneChanged(){} // RVA: 0x714A620
        public void remove_activeSceneChanged(){} // RVA: 0x714A780
        public void LoadScene(){} // RVA: 0x714A9B0 | overloaded x3
        public void LoadSceneAsync(){} // RVA: 0x714AC50 | overloaded x5
        public void Internal_SceneLoaded(){} // RVA: 0x714ACC0
        public void Internal_SceneUnloaded(){} // RVA: 0x714AD70
        public void Internal_ActiveSceneChanged(){} // RVA: 0x714AE10
        public void .cctor(){} // RVA: 0x714AEC0
        public void GetActiveScene_Injected(){} // RVA: 0x714AF00
        public void SetActiveScene_Injected(){} // RVA: 0x714AF50
        public void GetSceneByName_Injected(){} // RVA: 0x714AFA0
        public void GetSceneAt_Injected(){} // RVA: 0x714B000
    }

    public class SceneManagerAPI
    {
        public UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
        public UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7149930
        public void get_overrideAPI(){} // RVA: 0x71499F0
        public void set_overrideAPI(){} // RVA: 0x7149A50
        public void .ctor(){} // RVA: 0x2DD310
        public void GetNumScenesInBuildSettings(){} // RVA: 0x71497E0
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7149B10
        public void LoadFirstScene(){} // RVA: 0x519240
        public void .cctor(){} // RVA: 0x7149B80
    }

    public class SceneManagerAPIInternal
    {
        // ── Methods ──
        public void GetNumScenesInBuildSettings(){} // RVA: 0x71497E0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7149830
        public void LoadSceneAsyncNameIndexInternal_Injected(){} // RVA: 0x71498B0
    }

    public class SceneUtility
    {
        // ── Methods ──
        public void GetScenePathByBuildIndex(){} // RVA: 0x714B070
    }

}