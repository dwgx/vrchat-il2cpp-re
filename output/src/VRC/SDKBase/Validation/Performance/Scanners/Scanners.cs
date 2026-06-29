// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Scanners
// Classes: 12
// Methods: 51

namespace VRC.SDKBase.Validation.Performance.Scanners
{
    public class AbstractPerformanceScanner : Object
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7A7E06710
        public void RunPerformanceScan(){} // RVA: 0x7B18F6060
        public void ScanAvatarForComponentsOfType(){} // RVA: 0x7AA1776D0
        public void HandleComponentScansPerFrameLimit(){} // RVA: 0x7B18F64D0
        public void EnabledOnPlatform(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7B18F6570
    }

    public class AbstractPerformanceScanner[] : Array
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

    public class AnimatorPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18F6950
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class AudioPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18F71A0
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class ClothPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18F7B50
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class LightPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18F83C0
        public void CountParticleSystemLights(){} // RVA: 0x7B18F8580
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class LineRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18F8EA0
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class MeshPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18F9440
        public void CalculateRendererPolyCount(){} // RVA: 0x7B18F9600
        public void RendererHasMesh(){} // RVA: 0x7B18F9A90
        public void AnalyzeGeometry(){} // RVA: 0x7B18F9F10
        public void AnalyzeMaterials(){} // RVA: 0x7B18FA0D0
        public void AnalyzeSkinnedMeshRenderers(){} // RVA: 0x7B18FB050
        public void AnalyzeMeshRenderers(){} // RVA: 0x7B18FB620
        public void .ctor(){} // RVA: 0x7AF4CADC0
        public void .cctor(){} // RVA: 0x7B18FBAF0
    }

    public class ParticlePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18FE2C0
        public void AnalyzeParticleSystemRenderers(){} // RVA: 0x7B18FE480
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class PhysicsPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B18FF720
        public void HasStation(){} // RVA: 0x7B18FF8E0
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class RaycastPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B1900080
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

    public class TrailRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7B1900860
        public void .ctor(){} // RVA: 0x7AF4CADC0
    }

}