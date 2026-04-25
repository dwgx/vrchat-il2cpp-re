// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.Demos
// Classes: 1
// Methods: 12

namespace ThirdParty.Other.RootMotion.Demos
{
    public class Navigator : Object
    {
        public bool normalizedDeltaPosition; // 0x10
        public float state; // 0x14
        public float recalculateOnPathDistance; // 0x18
        public float maxSampleDistance; // 0x1C
        public float nextPathInterval; // 0x20
        public UnityEngine.Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
        public 0x6B1BD260 <state>k__BackingField; // 0x30
        public UnityEngine.Transform transform; // 0x38
        public int cornerIndex; // 0x40
        public UnityEngine.Vector3[] corners; // 0x48
        public UnityEngine.AI.NavMeshPath path; // 0x50
        public UnityEngine.Vector3 lastTargetPosition; // 0x58
        public bool initiated; // 0x64
        public float nextPathTime; // 0x68

        // ── Methods ──
        public void get_normalizedDeltaPosition(){} // RVA: 0x7FFAC2F7CCA0
        public void set_normalizedDeltaPosition(){} // RVA: 0x7FFAC2F7CCC0
        public void get_state(){} // RVA: 0x7FFAC2F7CCD0
        public void set_state(){} // RVA: 0x7FFAC2F7CCE0
        public void Initiate(){} // RVA: 0x7FFAC2F7CCF0
        public void Update(){} // RVA: 0x7FFAC2F7CEC0
        public void CalculatePath(){} // RVA: 0x7FFAC2F7D3A0
        public void Find(){} // RVA: 0x7FFAC2F7D480
        public void Stop(){} // RVA: 0x7FFAC2F7D7D0
        public void HorDistance(){} // RVA: 0x7FFAC2F7D830
        public void Visualize(){} // RVA: 0x7FFAC2F7D860
        public void .ctor(){} // RVA: 0x7FFAC2F7DCE0
    }

}