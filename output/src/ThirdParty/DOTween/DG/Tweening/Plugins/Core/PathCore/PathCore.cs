// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
// Classes: 6
// Methods: 35

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
{
    public class ABSPathDecoder : Object
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7A7E1EE20
        public void GetPoint(){} // RVA: 0x7A7E18710
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CatmullRomDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7A9CA6900
        public void GetPoint(){} // RVA: 0x7A9CA6CA0
        public void SetTimeToLengthTables(){} // RVA: 0x7A9CA7110
        public void SetWaypointsLengths(){} // RVA: 0x7A9CA74D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7A9CA7A20
    }

    public class ControlPoint : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A75F3A80
        public void op_Addition(){} // RVA: 0x7A9CA6760
        public void ToString(){} // RVA: 0x7A767FAB0
    }

    public class CubicBezierDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7A9CA54C0
        public void GetPoint(){} // RVA: 0x7A9CA5B50
        public void SetTimeToLengthTables(){} // RVA: 0x7A9CA5DB0
        public void SetWaypointsLengths(){} // RVA: 0x7A9CA6170
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7A9CA6610
    }

    public class LinearDecoder : ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7A9CA7B70
        public void GetPoint(){} // RVA: 0x7A9CA7C00
        public void SetTimeToLengthTables(){} // RVA: 0x7A9CA7E00
        public void SetWaypointsLengths(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Path : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9CA8440
        public void FinalizePath(){} // RVA: 0x7A9CA8460
        public void GetPoint(){} // RVA: 0x7A9CA85A0
        public void ConvertToConstantPathPerc(){} // RVA: 0x7A9CA8630
        public void GetWaypointIndexFromPerc(){} // RVA: 0x7A9CA8780
        public void GetDrawPoints(){} // RVA: 0x7A9CA8840
        public void RefreshNonLinearDrawWps(){} // RVA: 0x7A9CA8980
        public void Destroy(){} // RVA: 0x7A9CA8B00
        public void CloneIncremental(){} // RVA: 0x7A9CA8DD0
        public void AssignWaypoints(){} // RVA: 0x7A9CA9740
        public void AssignDecoder(){} // RVA: 0x7A9CA98D0
        public void Draw(){} // RVA: 0x7A9CA9BE0
    }

}