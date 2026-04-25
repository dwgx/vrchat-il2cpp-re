// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Scanners
// Classes: 11
// Methods: 37

namespace VRC.SDKBase.Validation.Performance.Scanners
{
    public class AbstractPerformanceScanner : Object
    {
        public int MAXIMUM_COMPONENT_SCANS_PER_FRAME;
        public int _componentScansThisFrame;
        public int _componentScansFrameNumber; // 0x4
        public System.Collections.Generic.Stack`1<System.Collections.IEnumerator> _coroutines; // 0x10
        public bool _limitComponentScansPerFrame; // 0x18

        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFAC2C6AE80
        public void RunPerformanceScan(){} // RVA: 0x7FFACC091360
        public void ScanAvatarForComponentsOfType(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void HandleComponentScansPerFrameLimit(){} // RVA: 0x7FFACC0917D0
        public void EnabledOnPlatform(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFACC091870
    }

    public class AnimatorPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC091C50
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class AudioPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC092390
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class ClothPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC092D20
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class LightPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC0934D0
        public void CountParticleSystemLights(){} // RVA: 0x7FFACC093690
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class LineRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC093FA0
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class MeshPerformanceScanner : AbstractPerformanceScanner
    {
        public float TEXTURE_2D_MAXIMUM_BYTES_PER_PIXEL;
        public System.Collections.Generic.Dictionary`2<0x6B17C078,float> _texture2DBytesPerPixelLookup;
        public float RENDER_TEXTURE_2D_MAXIMUM_BYTES_PER_PIXEL;
        public System.Collections.Generic.Dictionary`2<0x6B17C180,float> _renderTextureBytesPerPixelLookup; // 0x8

        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC094540
        public void CalculateRendererPolyCount(){} // RVA: 0x7FFACC094700
        public void RendererHasMesh(){} // RVA: 0x7FFACC094B90
        public void AnalyzeGeometry(){} // RVA: 0x7FFACC094F90
        public void AnalyzeMaterials(){} // RVA: 0x7FFACC095150
        public void AnalyzeSkinnedMeshRenderers(){} // RVA: 0x7FFACC0960C0
        public void AnalyzeMeshRenderers(){} // RVA: 0x7FFACC096670
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
        public void .cctor(){} // RVA: 0x7FFACC096B30
    }

    public class ParticlePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC0990E0
        public void AnalyzeParticleSystemRenderers(){} // RVA: 0x7FFACC0992A0
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class PhysicsPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC09A530
        public void HasStation(){} // RVA: 0x7FFACC09A6F0
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class RaycastPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC09AE90
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

    public class TrailRendererPerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC09B220
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

}