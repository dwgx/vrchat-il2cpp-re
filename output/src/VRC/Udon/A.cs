// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 4
// Methods: 29

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset : ScriptableObject
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x7A7E18890
        public void RetrieveProgram(){} // RVA: 0x7A7E00680
        public void GetSerializedProgramSize(){} // RVA: 0x7A7E00680
        public void GetNetworkCallingMetadata(){} // RVA: 0x7A7E00B20
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7A7E029D0
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7A7E01A40
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class AbstractUdonBehaviourEventProxy : MonoBehaviour
    {
        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0x7A81052C0
        public void set_EventReceiver(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class AbstractUdonBehaviourEventProxy[] : Array
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

    public class AbstractUdonProgramSource : ScriptableObject
    {
        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x7A7E00680
        public void RunEditorUpdate(){} // RVA: 0x7A7E18890
        public void RefreshProgram(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

}