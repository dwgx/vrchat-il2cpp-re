// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Scanners
// Classes: 12
// Methods: 51

namespace VRC.SDKBase.Validation.Performance.Scanners
{
    public class AbstractPerformanceScanner : Object
    {
        public object MAXIMUM_COMPONENT_SCANS_PER_FRAME;
        public object _componentScansThisFrame;
        public object _componentScansFrameNumber;
        public object _coroutines;
        public object _limitComponentScansPerFrame;

        // ── Methods ──
        public void ScanAvatarForComponentsOfType(){} // RVA: 0x87C5F0
        public void RunPerformanceScanEnumerator(){} // RVA: 0x882090
        public void RunPerformanceScan(){} // RVA: 0xA7642A0
        public void HandleComponentScansPerFrameLimit(){} // RVA: 0xA764710
        public void EnabledOnPlatform(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xA7647B0
    }

    public class AbstractPerformanceScanner[] : Array
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

    public class AnimatorPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA764B90
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class AudioPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA7653E0
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class ClothPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA765D70
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class LightPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA7665E0
        public void CountParticleSystemLights(){} // RVA: 0xA7667A0
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class LineRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA7670F0
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class MeshPerformanceScanner : AbstractPerformanceScanner
    {
        public object TEXTURE_2D_MAXIMUM_BYTES_PER_PIXEL;
        public object _texture2DBytesPerPixelLookup;
        public object RENDER_TEXTURE_2D_MAXIMUM_BYTES_PER_PIXEL;
        public object _renderTextureBytesPerPixelLookup;

        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA767690
        public void CalculateRendererPolyCount(){} // RVA: 0xA767850
        public void RendererHasMesh(){} // RVA: 0xA767CA0
        public void AnalyzeGeometry(){} // RVA: 0xA7680A0
        public void AnalyzeMaterials(){} // RVA: 0xA768260
        public void AnalyzeSkinnedMeshRenderers(){} // RVA: 0xA769160
        public void AnalyzeMeshRenderers(){} // RVA: 0xA769730
        public void .ctor(){} // RVA: 0x832AF20
        public void .cctor(){} // RVA: 0xA769C00
    }

    public class ParticlePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA76C3B0
        public void AnalyzeParticleSystemRenderers(){} // RVA: 0xA76C570
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class PhysicsPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA76D990
        public void HasStation(){} // RVA: 0xA76DB50
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class RaycastPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA76E2B0
        public void .ctor(){} // RVA: 0x832AF20
    }

    public class TrailRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0xA76EA90
        public void .ctor(){} // RVA: 0x832AF20
    }

}