// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 6
// Methods: 61

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class LoadSceneParameters : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C8BCD0
    }

    public class Scene : ValueType
    {
        public int m_Handle; // 0x10
        public object field_1; // 0x63D
        public object field_2; // 0x63E
        public object field_3; // 0x63F
        public object field_4; // 0x640

        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7FFE87C89BC0
        public void GetNameInternal(){} // RVA: 0x7FFE87C89C10
        public void GetIsLoadedInternal(){} // RVA: 0x7FFE87C89C60
        public void GetBuildIndexInternal(){} // RVA: 0x7FFE87C89CB0
        public void GetRootCountInternal(){} // RVA: 0x7FFE87C89D00
        public void GetRootGameObjectsInternal(){} // RVA: 0x7FFE87C89D50
        public void get_handle(){} // RVA: 0x7FFE8733C3B0
        public void IsValid(){} // RVA: 0x7FFE87C89DB0
        public void get_name(){} // RVA: 0x7FFE87C89E00
        public void get_isLoaded(){} // RVA: 0x7FFE87C89E50
        public void get_buildIndex(){} // RVA: 0x7FFE87C89EA0
        public void get_rootCount(){} // RVA: 0x7FFE87C89EF0
        public void GetRootGameObjects(){} // RVA: 0x7FFE87C8A030 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87C606D0
        public void op_Inequality(){} // RVA: 0x7FFE87C8A3B0
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87C8A3C0
    }

    public class SceneManager : Object
    {
        public bool s_AllowLoadScene;
        public UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene,0x6657C0B4> sceneLoaded; // 0x8

        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7FFE87C8A890
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7FFE87C8A8E0
        public void GetActiveScene(){} // RVA: 0x7FFE87C8A950
        public void SetActiveScene(){} // RVA: 0x7FFE87C8A9E0
        public void GetSceneByName(){} // RVA: 0x7FFE87C8AA70
        public void GetSceneAt(){} // RVA: 0x7FFE87C8AB10
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFE87C8ABB0
        public void LoadFirstScene_Internal(){} // RVA: 0x7FFE87C8ACA0
        public void add_sceneLoaded(){} // RVA: 0x7FFE87C8AD10
        public void remove_sceneLoaded(){} // RVA: 0x7FFE87C8AE70
        public void add_sceneUnloaded(){} // RVA: 0x7FFE87C8AFD0
        public void remove_sceneUnloaded(){} // RVA: 0x7FFE87C8B130
        public void add_activeSceneChanged(){} // RVA: 0x7FFE87C8B290
        public void remove_activeSceneChanged(){} // RVA: 0x7FFE87C8B3F0
        public void LoadScene(){} // RVA: 0x7FFE87C8B620 | overloaded x3
        public void LoadSceneAsync(){} // RVA: 0x7FFE87C8B8C0 | overloaded x5
        public void Internal_SceneLoaded(){} // RVA: 0x7FFE87C8B930
        public void Internal_SceneUnloaded(){} // RVA: 0x7FFE87C8B9E0
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7FFE87C8BA80
        public void .cctor(){} // RVA: 0x7FFE87C8BB30
        public void GetActiveScene_Injected(){} // RVA: 0x7FFE87C8BB70
        public void SetActiveScene_Injected(){} // RVA: 0x7FFE87C8BBC0
        public void GetSceneByName_Injected(){} // RVA: 0x7FFE87C8BC10
        public void GetSceneAt_Injected(){} // RVA: 0x7FFE87C8BC70
    }

    public class SceneManagerAPI : Object
    {
        public UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
        public UnityEngine.SceneManagement.SceneManagerAPI _overrideAPI; // 0x8

        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7FFE87C8A5A0
        public void get_overrideAPI(){} // RVA: 0x7FFE87C8A660
        public void set_overrideAPI(){} // RVA: 0x7FFE87C8A6C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7FFE87C8A450
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7FFE87C8A780
        public void LoadFirstScene(){} // RVA: 0x7FFE813240E0
        public void .cctor(){} // RVA: 0x7FFE87C8A7F0
    }

    public class SceneManagerAPIInternal : Object
    {
        // ── Methods ──
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7FFE87C8A450
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7FFE87C8A4A0
        public void LoadSceneAsyncNameIndexInternal_Injected(){} // RVA: 0x7FFE87C8A520
    }

    public class SceneUtility : Object
    {
        // ── Methods ──
        public void GetScenePathByBuildIndex(){} // RVA: 0x7FFE87C8BCE0
    }

}