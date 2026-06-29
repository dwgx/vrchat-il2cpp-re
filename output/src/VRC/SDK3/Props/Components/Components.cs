// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props.Components
// Classes: 3
// Methods: 21

namespace VRC.SDK3.Props.Components
{
    public class CustomAttribute : Object
    {
        public object name;
        public object type;
        public object boolValue;
        public object intValue;
        public object floatValue;
        public object stringValue;
        public object colorValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CustomAttribute[] : Array
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

    public class VRCPropDescriptor : VRC_PropDescriptor
    {
        public object selectorLocalPosition;
        public object selectorRadius;
        public object customAttributes;
        public object spawnBearingOffset;
        public object previewBearingOffset;
        public object previewBehaviour;
        public object skipBuiltInSpawnAnimation;
        public object skipBuiltInDespawnAnimation;

        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0xA6D0FC0
        public void DrawSelectorGizmos(){} // RVA: 0xA6D10B0
        public void DrawBearingGizmos(){} // RVA: 0xA6D1320
        public void .ctor(){} // RVA: 0xA6D1410
        public void <DrawBearingGizmos>g__DrawBearingLine|10_0(){} // RVA: 0xA6D14F0
    }

}