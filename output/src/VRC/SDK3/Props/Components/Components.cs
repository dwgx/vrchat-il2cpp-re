// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props.Components
// Classes: 2
// Methods: 6

namespace VRC.SDK3.Props.Components
{
    public class CustomAttribute : Object
    {
        public string name; // 0x10
        public 0x6B2E5DE8 type; // 0x18
        public bool boolValue; // 0x1C
        public int intValue; // 0x20
        public float floatValue; // 0x24
        public string stringValue; // 0x28
        public UnityEngine.Color colorValue; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VRCPropDescriptor : VRC_PropDescriptor
    {
        public UnityEngine.Vector3 selectorLocalPosition; // 0x50
        public float selectorRadius; // 0x5C
        public VRC.SDK3.Props.Components.CustomAttribute[] customAttributes; // 0x60
        public int spawnBearingOffset; // 0x68
        public int previewBearingOffset; // 0x6C
        public VRC.SDK3.Components.AbstractUdonBehaviour previewBehaviour; // 0x70

        // ── Methods ──
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFACC01CB40
        public void DrawSelectorGizmos(){} // RVA: 0x7FFACC01CC40
        public void DrawBearingGizmos(){} // RVA: 0x7FFACC01CEB0
        public void .ctor(){} // RVA: 0x7FFACC01CFB0
        public void <DrawBearingGizmos>g__DrawBearingLine|8_0(){} // RVA: 0x7FFACC01D090
    }

}