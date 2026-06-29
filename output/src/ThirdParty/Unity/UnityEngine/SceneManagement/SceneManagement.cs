// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 8
// Methods: 86

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class LoadSceneParameters : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A8D50
    }

    public class Scene : ValueType
    {
        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7C28350
        public void GetNameInternal(){} // RVA: 0x7C283A0
        public void GetIsLoadedInternal(){} // RVA: 0x7C28470
        public void GetBuildIndexInternal(){} // RVA: 0x7C284C0
        public void GetRootCountInternal(){} // RVA: 0x7C28510
        public void GetRootGameObjectsInternal(){} // RVA: 0x7C28560
        public void get_handle(){} // RVA: 0x454FE0
        public void IsValid(){} // RVA: 0x967230
        public void get_name(){} // RVA: 0x967280
        public void get_isLoaded(){} // RVA: 0x967290
        public void get_buildIndex(){} // RVA: 0x9672E0
        public void get_rootCount(){} // RVA: 0x967330
        public void GetRootGameObjects(){} // RVA: 0x967390
        public void op_Equality(){} // RVA: 0x7BF2630
        public void op_Inequality(){} // RVA: 0x7C28B80
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x9673A0
        public void GetNameInternal_Injected(){} // RVA: 0x7C28C20
    }

    public class SceneManager : Object
    {
        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7C292B0
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7C29300
        public void GetActiveScene(){} // RVA: 0x7C29370
        public void SetActiveScene(){} // RVA: 0x7C29400
        public void GetSceneByName(){} // RVA: 0x7C29490
        public void GetSceneAt(){} // RVA: 0x7C29640
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7C296E0
        public void LoadFirstScene_Internal(){} // RVA: 0x7C297D0
        public void add_sceneLoaded(){} // RVA: 0x7C29840
        public void remove_sceneLoaded(){} // RVA: 0x7C299B0
        public void add_sceneUnloaded(){} // RVA: 0x7C29B20
        public void remove_sceneUnloaded(){} // RVA: 0x7C29C90
        public void add_activeSceneChanged(){} // RVA: 0x7C29E00
        public void remove_activeSceneChanged(){} // RVA: 0x7C29F70
        public void LoadScene(){} // RVA: 0x7C2A1B0
        public void LoadSceneAsync(){} // RVA: 0x7C2A450
        public void Internal_SceneLoaded(){} // RVA: 0x7C2A4C0
        public void Internal_SceneUnloaded(){} // RVA: 0x7C2A570
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7C2A610
        public void .cctor(){} // RVA: 0x7C2A6C0
        public void GetActiveScene_Injected(){} // RVA: 0x7C2A700
        public void SetActiveScene_Injected(){} // RVA: 0x7C2A750
        public void GetSceneByName_Injected(){} // RVA: 0x7C2A7A0
        public void GetSceneAt_Injected(){} // RVA: 0x7C2A800
    }

    public class SceneManagerAPI : Object
    {
        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7C29000
        public void get_overrideAPI(){} // RVA: 0x7C290C0
        public void set_overrideAPI(){} // RVA: 0x7C29120
        public void .ctor(){} // RVA: 0xB43310
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7C28C80
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7C291E0
        public void LoadFirstScene(){} // RVA: 0xDAC980
        public void .cctor(){} // RVA: 0x7C29210
    }

    public class SceneManagerAPIInternal : Object
    {
        // ── Methods ──
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7C28C80
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7C28CD0
        public void LoadSceneAsyncNameIndexInternal_Injected(){} // RVA: 0x7C28F80
    }

    public class SceneManager[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SceneUtility : Object
    {
        // ── Methods ──
        public void GetScenePathByBuildIndex(){} // RVA: 0x7C2A860
        public void GetScenePathByBuildIndex_Injected(){} // RVA: 0x7C2A930
    }

    public class Scene[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB76C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E70E50
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}