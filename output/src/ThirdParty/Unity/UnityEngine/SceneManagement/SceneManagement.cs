// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 6
// Methods: 61

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class LoadSceneParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BFB060
    }

    public class Scene
    {
        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFAF9BF8F50
        public void GetNameInternal(){} // RVA: 0x7FFAF9BF8FA0
        public void GetIsLoadedInternal(){} // RVA: 0x7FFAF9BF8FF0
        public void GetBuildIndexInternal(){} // RVA: 0x7FFAF9BF9040
        public void GetRootCountInternal(){} // RVA: 0x7FFAF9BF9090
        public void GetRootGameObjectsInternal(){} // RVA: 0x7FFAF9BF90E0
        public void get_handle(){} // RVA: 0x7FFAF92AD0D0
        public void IsValid(){} // RVA: 0x7FFAF9BF9140
        public void get_name(){} // RVA: 0x7FFAF9BF9190
        public void get_isLoaded(){} // RVA: 0x7FFAF9BF91E0
        public void get_buildIndex(){} // RVA: 0x7FFAF9BF9230
        public void get_rootCount(){} // RVA: 0x7FFAF9BF9280
        public void GetRootGameObjects(){} // RVA: 0x7FFAF9BF93C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF9BCFA10
        public void op_Inequality(){} // RVA: 0x7FFAF9BF9740
        public void GetHashCode(){} // RVA: 0x7FFAF92AD0D0
        public void Equals(){} // RVA: 0x7FFAF9BF9750
    }

    public class SceneManager
    {
        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7FFAF9BF9C20
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7FFAF9BF9C70
        public void GetActiveScene(){} // RVA: 0x7FFAF9BF9CE0
        public void SetActiveScene(){} // RVA: 0x7FFAF9BF9D70
        public void GetSceneByName(){} // RVA: 0x7FFAF9BF9E00
        public void GetSceneAt(){} // RVA: 0x7FFAF9BF9EA0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFAF9BF9F40
        public void LoadFirstScene_Internal(){} // RVA: 0x7FFAF9BFA030
        public void add_sceneLoaded(){} // RVA: 0x7FFAF9BFA0A0
        public void remove_sceneLoaded(){} // RVA: 0x7FFAF9BFA200
        public void add_sceneUnloaded(){} // RVA: 0x7FFAF9BFA360
        public void remove_sceneUnloaded(){} // RVA: 0x7FFAF9BFA4C0
        public void add_activeSceneChanged(){} // RVA: 0x7FFAF9BFA620
        public void remove_activeSceneChanged(){} // RVA: 0x7FFAF9BFA780
        public void LoadScene(){} // RVA: 0x7FFAF9BFA9B0 | overloaded x3
        public void LoadSceneAsync(){} // RVA: 0x7FFAF9BFAC50 | overloaded x5
        public void Internal_SceneLoaded(){} // RVA: 0x7FFAF9BFACC0
        public void Internal_SceneUnloaded(){} // RVA: 0x7FFAF9BFAD70
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7FFAF9BFAE10
        public void .cctor(){} // RVA: 0x7FFAF9BFAEC0
        public void GetActiveScene_Injected(){} // RVA: 0x7FFAF9BFAF00
        public void SetActiveScene_Injected(){} // RVA: 0x7FFAF9BFAF50
        public void GetSceneByName_Injected(){} // RVA: 0x7FFAF9BFAFA0
        public void GetSceneAt_Injected(){} // RVA: 0x7FFAF9BFB000
    }

    public class SceneManagerAPI
    {
        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFAF9BF9930
        public void get_overrideAPI(){} // RVA: 0x7FFAF9BF99F0
        public void set_overrideAPI(){} // RVA: 0x7FFAF9BF9A50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7FFAF9BF97E0
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7FFAF9BF9B10
        public void LoadFirstScene(){} // RVA: 0x7FFAF2FC9240
        public void .cctor(){} // RVA: 0x7FFAF9BF9B80
    }

    public class SceneManagerAPIInternal
    {
        // ── Methods ──
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7FFAF9BF97E0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFAF9BF9830
        public void LoadSceneAsyncNameIndexInternal_Injected(){} // RVA: 0x7FFAF9BF98B0
    }

    public class SceneUtility
    {
        // ── Methods ──
        public void GetScenePathByBuildIndex(){} // RVA: 0x7FFAF9BFB070
    }

}