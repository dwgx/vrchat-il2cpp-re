// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 2
// Methods: 48

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class Scene : ValueType
    {
        // ── Original Methods ──
        public void IsValidInternal(){} // RVA: 0x7ffaaf3033f0
        public void get_handle(){} // RVA: 0x7ffaae9b5f60
        public void IsValid(){} // RVA: 0x7ffaaf3035e0
        public void get_name(){} // RVA: 0x7ffaaf303630
        public void get_isLoaded(){} // RVA: 0x7ffaaf303680
        public void get_buildIndex(){} // RVA: 0x7ffaaf3036d0
        public void get_rootCount(){} // RVA: 0x7ffaaf303720
        public void op_Equality(){} // RVA: 0x7ffaaf2d9f00
        public void op_Inequality(){} // RVA: 0x7ffaaf303be0
        public void Equals(){} // RVA: 0x7ffaaf303bf0
        // ── Binary Analysis Named ──
        public void GetNameInternal(){} // RVA: 0x7ffaaf303440
        public void GetIsLoadedInternal(){} // RVA: 0x7ffaaf303490
        public void GetBuildIndexInternal(){} // RVA: 0x7ffaaf3034e0
        public void GetRootCountInternal(){} // RVA: 0x7ffaaf303530
        public void GetRootGameObjectsInternal(){} // RVA: 0x7ffaaf303580
        public void GetRootGameObjects(){} // RVA: 0x7ffaaf303860
        public void GetRootGameObjects(){} // RVA: 0x7ffaaf303860
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
    }

    public class SceneManager : Object
    {
        public object sceneUnloaded; // 0x32CE1180

        // ── Original Methods ──
        public void get_sceneCount(){} // RVA: 0x7ffaaf3040c0
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7ffaaf304110
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7ffaaf3043e0
        public void LoadFirstScene_Internal(){} // RVA: 0x7ffaaf3044d0
        public void add_sceneLoaded(){} // RVA: 0x7ffaaf304540
        public void remove_sceneLoaded(){} // RVA: 0x7ffaaf3046a0
        public void add_sceneUnloaded(){} // RVA: 0x7ffaaf304800
        public void remove_sceneUnloaded(){} // RVA: 0x7ffaaf304960
        public void add_activeSceneChanged(){} // RVA: 0x7ffaaf304ac0
        public void remove_activeSceneChanged(){} // RVA: 0x7ffaaf304c20
        public void LoadScene(){} // RVA: 0x7ffaaf304e50
        public void LoadScene(){} // RVA: 0x7ffaaf304e50
        public void LoadScene(){} // RVA: 0x7ffaaf304e50
        public void LoadSceneAsync(){} // RVA: 0x7ffaaf3050f0
        public void LoadSceneAsync(){} // RVA: 0x7ffaaf3050f0
        public void LoadSceneAsync(){} // RVA: 0x7ffaaf3050f0
        public void LoadSceneAsync(){} // RVA: 0x7ffaaf3050f0
        public void LoadSceneAsync(){} // RVA: 0x7ffaaf3050f0
        public void Internal_SceneLoaded(){} // RVA: 0x7ffaaf305160
        public void Internal_SceneUnloaded(){} // RVA: 0x7ffaaf305210
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7ffaaf3052b0
        public void .cctor(){} // RVA: 0x7ffaaf305360
        // ── Binary Analysis Named ──
        public void GetActiveScene(){} // RVA: 0x7ffaaf304180
        public void SetActiveScene(){} // RVA: 0x7ffaaf304210
        public void GetSceneByName(){} // RVA: 0x7ffaaf3042a0
        public void GetSceneAt(){} // RVA: 0x7ffaaf304340
        public void GetActiveScene_Injected(){} // RVA: 0x7ffaaf3053a0
        public void SetActiveScene_Injected(){} // RVA: 0x7ffaaf3053f0
        public void GetSceneByName_Injected(){} // RVA: 0x7ffaaf305440
        public void GetSceneAt_Injected(){} // RVA: 0x7ffaaf3054a0
    }

}