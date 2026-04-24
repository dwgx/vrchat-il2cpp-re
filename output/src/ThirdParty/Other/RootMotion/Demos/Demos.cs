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
        public 0x6651D260 <state>k__BackingField; // 0x30
        public UnityEngine.Transform transform; // 0x38
        public int cornerIndex; // 0x40
        public UnityEngine.Vector3[] corners; // 0x48
        public ÏÌÍÏÍÎÍÌÌÌ.ÏÏ path; // 0x50
        public UnityEngine.Vector3 lastTargetPosition; // 0x58
        public bool initiated; // 0x64
        public float nextPathTime; // 0x68

        // ── Methods ──
        public void get_normalizedDeltaPosition(){} // RVA: 0x7FFD4E39CCA0
        public void set_normalizedDeltaPosition(){} // RVA: 0x7FFD4E39CCC0
        public void get_state(){} // RVA: 0x7FFD4E39CCD0
        public void set_state(){} // RVA: 0x7FFD4E39CCE0
        public void Initiate(){} // RVA: 0x7FFD4E39CCF0
        public void Update(){} // RVA: 0x7FFD4E39CEC0
        public void CalculatePath(){} // RVA: 0x7FFD4E39D3A0
        public void Find(){} // RVA: 0x7FFD4E39D480
        public void Stop(){} // RVA: 0x7FFD4E39D7D0
        public void HorDistance(){} // RVA: 0x7FFD4E39D830
        public void Visualize(){} // RVA: 0x7FFD4E39D860
        public void .ctor(){} // RVA: 0x7FFD4E39DCE0
    }

}