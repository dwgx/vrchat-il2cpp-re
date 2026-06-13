// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class TakeNObservable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0
        public void Subscribe(){} // RVA: 0xCE10
    }

    public class TypeHelpers
    {
        // ── Methods ──
        public void As(){} // RVA: 0x283FA0
        public void IsInt(){} // RVA: 0x6DDA540
        public void GetValueType(){} // RVA: 0x6DDA590
        public void GetNiceTypeName(){} // RVA: 0x6DDA700
        public void GetGenericTypeArgumentFromHierarchy(){} // RVA: 0x6DDABC0
    }

    public class TypeTable
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table; // 0x10

        // ── Methods ──
        public void get_names(){} // RVA: 0x6DDB030
        public void get_internedNames(){} // RVA: 0x6DDB1D0
        public void Initialize(){} // RVA: 0x6DDB220
        public void FindNameForType(){} // RVA: 0x6DDB2D0
        public void AddTypeRegistration(){} // RVA: 0x6DDB530
        public void LookupTypeRegistration(){} // RVA: 0x6DDB6D0
    }

}