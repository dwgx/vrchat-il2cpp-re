// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.AssetCustomization
// Classes: 7
// Methods: 52

namespace VRC.AssetCustomization
{
    public class IPartOptionBinder
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7A7E18800
        public void Detach(){} // RVA: 0x7A7E18770
    }

    public class IPartOptionBinderContext
    {
        // ── Methods ──
        public void TryGetVariable(){} // RVA: 0x7A7E01A40
        public void SubscribeToVariable(){} // RVA: 0x7A7E12480
    }

    public class IPartOptionBinder[] : Array
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

    public class VRCAnimationPartOption : MonoBehaviour
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7B1835AC0
        public void Detach(){} // RVA: 0x7B1835EA0
        public void OnDestroy(){} // RVA: 0x7B1835FC0
        public void ApplyFloatValue(){} // RVA: 0x7B1835FD0
        public void ApplyBoolValue(){} // RVA: 0x7B1836320
        public void ApplyNormalized(){} // RVA: 0x7B1836690
        public void .ctor(){} // RVA: 0x7B18367B0
    }

    public class VRCBlendshapePartOption : MonoBehaviour
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7B1836930
        public void Detach(){} // RVA: 0x7B1836E20
        public void OnDestroy(){} // RVA: 0x7B1836F40
        public void ApplyFloatValue(){} // RVA: 0x7B1836F50
        public void ApplyBoolValue(){} // RVA: 0x7B1837110
        public void OnBeforeSerialize(){} // RVA: 0x7B18372B0
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void SyncBlendshapeIndices(){} // RVA: 0x7B18372C0
        public void FindBlendshapeIndex(){} // RVA: 0x7B1837620
        public void .ctor(){} // RVA: 0x7B1837800
    }

    public class VRCGameObjectPartOption : MonoBehaviour
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7B1837960
        public void Detach(){} // RVA: 0x7B1837CA0
        public void OnDestroy(){} // RVA: 0x7B1837DC0
        public void ApplyValue(){} // RVA: 0x7B1837DD0
        public void .ctor(){} // RVA: 0x7B1837E40
    }

    public class VRCMaterialPartOption : MonoBehaviour
    {
        // ── Methods ──
        public void get_Material(){} // RVA: 0x7A81052C0
        public void set_Material(){} // RVA: 0x7A81052D0
        public void OnBeforeSerialize(){} // RVA: 0x7B1837FC0
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void RefreshSlots(){} // RVA: 0x7B1837FD0
        public void UpdateProperties(){} // RVA: 0x7B18387F0
        public void Attach(){} // RVA: 0x7B1838970
        public void Detach(){} // RVA: 0x7B1838D90
        public void OnDestroy(){} // RVA: 0x7B1838EB0
        public void .ctor(){} // RVA: 0x7B1838EC0
        public void .cctor(){} // RVA: 0x7B1839050
    }

}