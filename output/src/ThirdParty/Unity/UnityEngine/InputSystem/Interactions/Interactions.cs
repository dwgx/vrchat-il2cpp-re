// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Interactions
// Classes: 5
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Interactions
{
    public class HoldInteraction : Object
    {
        public object durationOrDefault;
        public object pressPointOrDefault;

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFD5497FCF0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD5497FD70
        public void Process(){} // RVA: 0x7FFD5497FDD0
        public void Reset(){} // RVA: 0x7FFD4FC027C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MultiTapInteraction : Object
    {
        public hpClassPrefix tapTimeOrDefault; // 0x138
        public BuffersImpl tapDelayOrDefault; // 0x140
        public ePathName117.? pressPointOrDefault; // 0x148
        public ePathName117.? releasePointOrDefault; // 0x150
        public ePathName117.? selectAllButton; // 0x158
        public ePathName117.? deselectAllButton; // 0x160
        public ePathName117.? closeButton; // 0x168
        public ?[] instanceTypeSelectionToggles; // 0x170
        public ePathName117.? applyButton; // 0x178
        public ePathName117.? cancelButton; // 0x180
        public URA.woDigitYearMax<ÎÍÎÏÍÎÏÍ> ÎÎÏÏÏÍÌÌÍÏÍÎÍÎÍÏÌÏÍÏÍÌÍ; // 0x188
        public URA.onsDepth<?> ÎÍÎÏÌÎÍÎÎÏÏÍÎÏÍÌÏÏÏÎÏÍÎ; // 0x190
        public bool[] ÌÏÏÎÌÎÌÌÍÌÎÎÏÎÌÌÏÏÌÏÌÎÌ; // 0x198

        // ── Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x7FFD5497FF60
        public void get_tapDelayOrDefault(){} // RVA: 0x7FFD5497FFE0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD54980060
        public void get_releasePointOrDefault(){} // RVA: 0x7FFD549800C0
        public void Process(){} // RVA: 0x7FFD54980140
        public void Reset(){} // RVA: 0x7FFD54980400
        public void .ctor(){} // RVA: 0x7FFD54980410
    }

    public class PressInteraction : Object
    {
        public object pressPointOrDefault;
        public object releasePointOrDefault;

        // ── Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD54980420
        public void get_releasePointOrDefault(){} // RVA: 0x7FFD54980480
        public void Process(){} // RVA: 0x7FFD54980500
        public void Reset(){} // RVA: 0x7FFD4EC5F000
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SlowTapInteraction : Object
    {
        public object durationOrDefault;
        public object pressPointOrDefault;

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFD54980760
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD549807E0
        public void Process(){} // RVA: 0x7FFD54980840
        public void Reset(){} // RVA: 0x7FFD4FC027C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TapInteraction : Object
    {
        public object durationOrDefault;
        public object pressPointOrDefault;
        public object releasePointOrDefault;

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFD54980A10
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD54980A90
        public void get_releasePointOrDefault(){} // RVA: 0x7FFD54980AF0
        public void Process(){} // RVA: 0x7FFD54980B70
        public void Reset(){} // RVA: 0x7FFD4FC027C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}