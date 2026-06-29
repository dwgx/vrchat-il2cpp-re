// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.AssetCustomization
// Classes: 7
// Methods: 52

namespace VRC.AssetCustomization
{
    public class IPartOptionBinder
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x894320
        public void Detach(){} // RVA: 0x894290
    }

    public class IPartOptionBinderContext
    {
        // ── Methods ──
        public void TryGetVariable(){} // RVA: 0x87D3C0
        public void SubscribeToVariable(){} // RVA: 0x88DF10
    }

    public class IPartOptionBinder[] : Array
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

    public class VRCAnimationPartOption : MonoBehaviour
    {
        public object _target;
        public object _bindings;
        public object _subscriptions;

        // ── Methods ──
        public void Attach(){} // RVA: 0xA6A0AF0
        public void Detach(){} // RVA: 0xA6A0ED0
        public void OnDestroy(){} // RVA: 0xA6A0FF0
        public void ApplyFloatValue(){} // RVA: 0xA6A1000
        public void ApplyBoolValue(){} // RVA: 0xA6A1380
        public void ApplyNormalized(){} // RVA: 0xA6A1700
        public void .ctor(){} // RVA: 0xA6A1830
    }

    public class VRCBlendshapePartOption : MonoBehaviour
    {
        public object _bindings;
        public object _subscriptions;

        // ── Methods ──
        public void Attach(){} // RVA: 0xA6A19B0
        public void Detach(){} // RVA: 0xA6A1EA0
        public void OnDestroy(){} // RVA: 0xA6A1FC0
        public void ApplyFloatValue(){} // RVA: 0xA6A1FD0
        public void ApplyBoolValue(){} // RVA: 0xA6A21D0
        public void OnBeforeSerialize(){} // RVA: 0xA6A23A0
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void SyncBlendshapeIndices(){} // RVA: 0xA6A23B0
        public void FindBlendshapeIndex(){} // RVA: 0xA6A2710
        public void .ctor(){} // RVA: 0xA6A2880
    }

    public class VRCGameObjectPartOption : MonoBehaviour
    {
        public object _bindings;
        public object _subscriptions;

        // ── Methods ──
        public void Attach(){} // RVA: 0xA6A29E0
        public void Detach(){} // RVA: 0xA6A2D20
        public void OnDestroy(){} // RVA: 0xA6A2E40
        public void ApplyValue(){} // RVA: 0xA6A2E50
        public void .ctor(){} // RVA: 0xA6A2E80
    }

    public class VRCMaterialPartOption : MonoBehaviour
    {
        public object _material;
        public object _bindings;
        public object _rendererMaterialSlotsCache;
        public object _propertyBlock;
        public object _subscriptions;
        public object _materials;

        // ── Methods ──
        public void get_Material(){} // RVA: 0xB700F0
        public void set_Material(){} // RVA: 0xB70100
        public void OnBeforeSerialize(){} // RVA: 0xA6A2FB0
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void RefreshSlots(){} // RVA: 0xA6A2FC0
        public void UpdateProperties(){} // RVA: 0xA6A3770
        public void Attach(){} // RVA: 0xA6A38F0
        public void Detach(){} // RVA: 0xA6A3D10
        public void OnDestroy(){} // RVA: 0xA6A3E30
        public void .ctor(){} // RVA: 0xA6A3E40
        public void .cctor(){} // RVA: 0xA6A3FD0
    }

}