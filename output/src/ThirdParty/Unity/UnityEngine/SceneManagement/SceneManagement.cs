// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SceneManagement
// Classes: 8
// Methods: 84

namespace ThirdParty.Unity.UnityEngine.SceneManagement
{
    public class LoadSceneParameters : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EE0930
    }

    public class Scene : ValueType
    {
        // ── Methods ──
        public void IsValidInternal(){} // RVA: 0x7AEF27EA0
        public void GetNameInternal(){} // RVA: 0x7AEF27EF0
        public void GetIsLoadedInternal(){} // RVA: 0x7AEF27F40
        public void GetBuildIndexInternal(){} // RVA: 0x7AEF27F90
        public void GetRootCountInternal(){} // RVA: 0x7AEF27FE0
        public void GetRootGameObjectsInternal(){} // RVA: 0x7AEF28030
        public void get_handle(){} // RVA: 0x7A79EAED0
        public void IsValid(){} // RVA: 0x7A7EE0600
        public void get_name(){} // RVA: 0x7A7EE0650
        public void get_isLoaded(){} // RVA: 0x7A7EE06A0
        public void get_buildIndex(){} // RVA: 0x7A7EE06F0
        public void get_rootCount(){} // RVA: 0x7A7EE0740
        public void GetRootGameObjects(){} // RVA: 0x7A7EE07A0
        public void op_Equality(){} // RVA: 0x7AEEFE800
        public void op_Inequality(){} // RVA: 0x7AEF28690
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EE07B0
    }

    public class SceneManager : Object
    {
        // ── Methods ──
        public void get_sceneCount(){} // RVA: 0x7AEF28B70
        public void get_sceneCountInBuildSettings(){} // RVA: 0x7AEF28BC0
        public void GetActiveScene(){} // RVA: 0x7AEF28C30
        public void SetActiveScene(){} // RVA: 0x7AEF28CC0
        public void GetSceneByName(){} // RVA: 0x7AEF28D50
        public void GetSceneAt(){} // RVA: 0x7AEF28DF0
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7AEF28E90
        public void LoadFirstScene_Internal(){} // RVA: 0x7AEF28F80
        public void add_sceneLoaded(){} // RVA: 0x7AEF28FF0
        public void remove_sceneLoaded(){} // RVA: 0x7AEF29160
        public void add_sceneUnloaded(){} // RVA: 0x7AEF292D0
        public void remove_sceneUnloaded(){} // RVA: 0x7AEF29440
        public void add_activeSceneChanged(){} // RVA: 0x7AEF295B0
        public void remove_activeSceneChanged(){} // RVA: 0x7AEF29720
        public void LoadScene(){} // RVA: 0x7AEF29960
        public void LoadSceneAsync(){} // RVA: 0x7AEF29C00
        public void Internal_SceneLoaded(){} // RVA: 0x7AEF29C70
        public void Internal_SceneUnloaded(){} // RVA: 0x7AEF29D20
        public void Internal_ActiveSceneChanged(){} // RVA: 0x7AEF29DC0
        public void .cctor(){} // RVA: 0x7AEF29E70
        public void GetActiveScene_Injected(){} // RVA: 0x7AEF29EB0
        public void SetActiveScene_Injected(){} // RVA: 0x7AEF29F00
        public void GetSceneByName_Injected(){} // RVA: 0x7AEF29F50
        public void GetSceneAt_Injected(){} // RVA: 0x7AEF29FB0
    }

    public class SceneManagerAPI : Object
    {
        // ── Methods ──
        public void get_ActiveAPI(){} // RVA: 0x7AEF28880
        public void get_overrideAPI(){} // RVA: 0x7AEF28940
        public void set_overrideAPI(){} // RVA: 0x7AEF289A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7AEF28730
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7AEF28A60
        public void LoadFirstScene(){} // RVA: 0x7A82D1450
        public void .cctor(){} // RVA: 0x7AEF28AD0
    }

    public class SceneManagerAPIInternal : Object
    {
        // ── Methods ──
        public void GetNumScenesInBuildSettings(){} // RVA: 0x7AEF28730
        public void LoadSceneAsyncNameIndexInternal(){} // RVA: 0x7AEF28780
        public void LoadSceneAsyncNameIndexInternal_Injected(){} // RVA: 0x7AEF28800
    }

    public class SceneManager[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SceneUtility : Object
    {
        // ── Methods ──
        public void GetScenePathByBuildIndex(){} // RVA: 0x7AEF2A020
    }

    public class Scene[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D8390
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA284A30
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}