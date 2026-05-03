// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Scanners
// Classes: 11
// Methods: 37

namespace VRC.SDKBase.Validation.Performance.Scanners
{
    public class AbstractPerformanceScanner : Object
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE80E403A0
        public void RunPerformanceScan(){} // RVA: 0x7FFE8A4F7330
        public void ScanAvatarForComponentsOfType(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void HandleComponentScansPerFrameLimit(){} // RVA: 0x7FFE8A4F77A0
        public void EnabledOnPlatform(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE8A4F7840
    }

    public class AnimatorPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4F7C20
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class AudioPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4F8360
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class ClothPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4F8CF0
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class LightPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4F94A0
        public void CountParticleSystemLights(){} // RVA: 0x7FFE8A4F9660
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class LineRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4F9F70
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class MeshPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4FA510
        public void CalculateRendererPolyCount(){} // RVA: 0x7FFE8A4FA6D0
        public void RendererHasMesh(){} // RVA: 0x7FFE8A4FAB60
        public void AnalyzeGeometry(){} // RVA: 0x7FFE8A4FAF60
        public void AnalyzeMaterials(){} // RVA: 0x7FFE8A4FB120
        public void AnalyzeSkinnedMeshRenderers(){} // RVA: 0x7FFE8A4FC090
        public void AnalyzeMeshRenderers(){} // RVA: 0x7FFE8A4FC640
        public void .ctor(){} // RVA: 0x7FFE88228F30
        public void .cctor(){} // RVA: 0x7FFE8A4FCB00
    }

    public class ParticlePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4FF0B0
        public void AnalyzeParticleSystemRenderers(){} // RVA: 0x7FFE8A4FF270
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class PhysicsPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A500500
        public void HasStation(){} // RVA: 0x7FFE8A5006C0
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class RaycastPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A500E60
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

    public class TrailRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A5011F0
        public void .ctor(){} // RVA: 0x7FFE88228F30
    }

}