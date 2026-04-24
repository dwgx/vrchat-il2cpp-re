// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 2
// Methods: 48

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class Scene : ValueType
    {
        public object handle;
        public object name;
        public object isLoaded;
        public object buildIndex;
        public object rootCount;

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFD54D01490
        public void GetNameInternal(){} // RVA: 0x7FFD54D014E0
        public void GetIsLoadedInternal(){} // RVA: 0x7FFD54D01530
        public void GetBuildIndexInternal(){} // RVA: 0x7FFD54D01580
        public void GetRootCountInternal(){} // RVA: 0x7FFD54D015D0
        public void GetRootGameObjectsInternal(){} // RVA: 0x7FFD54D01620
        public void get_handle(){} // RVA: 0x7FFD543B3F90
        public void IsValid(){} // RVA: 0x7FFD54D01680
        public void get_name(){} // RVA: 0x7FFD54D016D0
        public void get_isLoaded(){} // RVA: 0x7FFD54D01720
        public void get_buildIndex(){} // RVA: 0x7FFD54D01770
        public void get_rootCount(){} // RVA: 0x7FFD54D017C0
        public void GetRootGameObjects(){} // RVA: 0x7FFD54D01900 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54CD7FA0
        public void op_Inequality(){} // RVA: 0x7FFD54D01C80
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54D01C90
    }

    public class SceneManager : Object
    {
        public object sceneCount;
        public object sceneCountInBuildSettings;

        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7FFD54D02160
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7FFD54D021B0
        public void GetActiveScene(){} // RVA: 0x7FFD54D02220
        public void SetActiveScene(){} // RVA: 0x7FFD54D022B0
        public void GetSceneByName(){} // RVA: 0x7FFD54D02340
        public void GetSceneAt(){} // RVA: 0x7FFD54D023E0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFD54D02480
        public void LoadFirstScene_Internal(){} // RVA: 0x7FFD54D02570
        public void add_sceneLoaded(){} // RVA: 0x7FFD54D025E0
        public void remove_sceneLoaded(){} // RVA: 0x7FFD54D02740
        public void add_sceneUnloaded(){} // RVA: 0x7FFD54D028A0
        public void remove_sceneUnloaded(){} // RVA: 0x7FFD54D02A00
        public void add_activeSceneChanged(){} // RVA: 0x7FFD54D02B60
        public void remove_activeSceneChanged(){} // RVA: 0x7FFD54D02CC0
        public void LoadScene(){} // RVA: 0x7FFD54D02EF0 | overloaded x3
        public void LoadSceneAsync(){} // RVA: 0x7FFD54D03190 | overloaded x5
        public void Internal_SceneLoaded(){} // RVA: 0x7FFD54D03200
        public void Internal_SceneUnloaded(){} // RVA: 0x7FFD54D032B0
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7FFD54D03350
        public void .cctor(){} // RVA: 0x7FFD54D03400
        public void GetActiveScene_Injected(){} // RVA: 0x7FFD54D03440
        public void SetActiveScene_Injected(){} // RVA: 0x7FFD54D03490
        public void GetSceneByName_Injected(){} // RVA: 0x7FFD54D034E0
        public void GetSceneAt_Injected(){} // RVA: 0x7FFD54D03540
    }

}