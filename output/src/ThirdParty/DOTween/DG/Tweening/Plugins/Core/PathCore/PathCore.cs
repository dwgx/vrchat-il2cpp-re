// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
// Classes: 6
// Methods: 37

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Core.PathCore
{
    public class ABSPathDecoder
    {
        // ── Methods ──
        public void FinalizePath(){}
        public void GetPoint(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CatmullRomDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFAF4951EA0
        public void GetPoint(){} // RVA: 0x7FFAF4952240
        public void SetTimeToLengthTables(){} // RVA: 0x7FFAF49526C0
        public void SetWaypointsLengths(){} // RVA: 0x7FFAF4952A60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF4952F70
    }

    public class ControlPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D96DF0
        public void op_Addition(){} // RVA: 0x7FFAF4951D00
        public void ToString(){} // RVA: 0x7FFAF4951D90
    }

    public class CubicBezierDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFAF4950B10
        public void GetPoint(){} // RVA: 0x7FFAF4951170
        public void SetTimeToLengthTables(){} // RVA: 0x7FFAF49513F0
        public void SetWaypointsLengths(){} // RVA: 0x7FFAF4951790
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF4951BB0
    }

    public class LinearDecoder
    {
        // ── Methods ──
        public void FinalizePath(){} // RVA: 0x7FFAF49530C0
        public void GetPoint(){} // RVA: 0x7FFAF4953150
        public void SetTimeToLengthTables(){} // RVA: 0x7FFAF4953330
        public void SetWaypointsLengths(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Path
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4953920 | overloaded x2
        public void FinalizePath(){} // RVA: 0x7FFAF4953940
        public void GetPoint(){} // RVA: 0x7FFAF4953A80
        public void ConvertToConstantPathPerc(){} // RVA: 0x7FFAF4953B10
        public void GetWaypointIndexFromPerc(){} // RVA: 0x7FFAF4953C50
        public void GetDrawPoints(){} // RVA: 0x7FFAF4953CF0
        public void RefreshNonLinearDrawWps(){} // RVA: 0x7FFAF4953E20
        public void Destroy(){} // RVA: 0x7FFAF4953F90
        public void CloneIncremental(){} // RVA: 0x7FFAF4954260
        public void AssignWaypoints(){} // RVA: 0x7FFAF4954BE0
        public void AssignDecoder(){} // RVA: 0x7FFAF4954D70
        public void Draw(){} // RVA: 0x7FFAF4955080 | overloaded x2
    }

}