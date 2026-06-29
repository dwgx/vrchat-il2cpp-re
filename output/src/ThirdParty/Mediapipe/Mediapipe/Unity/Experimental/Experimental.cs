// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
// Classes: 3
// Methods: 39

namespace ThirdParty.Mediapipe.Mediapipe.Unity.Experimental
{
    public class TextureFrame : Object
    {
        // ── Methods ──
        public void get_imageFormat(){} // RVA: 0x7AD940BE0
        public void .ctor(){} // RVA: 0x7AD940F70
        public void Dispose(){} // RVA: 0x7AD941050
        public void GetOrCreateRenderTexture(){} // RVA: 0x7AD9412D0
        public void ReadTextureAsync(){} // RVA: 0x7AD9416C0
        public void OnReadBackRenderTexture(){} // RVA: 0x7AD9418D0
        public void GetNativeTexturePtr(){} // RVA: 0x7AD941B40
        public void GetTextureName(){} // RVA: 0x7AD941EB0
        public void GetInstanceID(){} // RVA: 0x7A8EDF360
        public void BuildCPUImage(){} // RVA: 0x7AD941EC0
        public void RemoveAllReleaseListeners(){} // RVA: 0x7AD941F40
        public void Release(){} // RVA: 0x7AD941F60
        public void WaitUntilReleased(){} // RVA: 0x7A972A9D0
        public void AcquireName(){} // RVA: 0x7AD942020
        public void RevokeNativeTexturePtr(){} // RVA: 0x7AD942210
        public void .cctor(){} // RVA: 0x7AD9422E0
    }

    public class TextureFramePool : Object
    {
        // ── Methods ──
        public void get_poolSize(){} // RVA: 0x7A9739200
        public void set_poolSize(){} // RVA: 0x7A9746990
        public void get_frameCount(){} // RVA: 0x7AD942500
        public void .ctor(){} // RVA: 0x7AD942570
        public void Dispose(){} // RVA: 0x7AD942850
        public void TryGetTextureFrame(){} // RVA: 0x7AD942D90
        public void OnTextureFrameRelease(){} // RVA: 0x7AD943440
        public void CreateNewTextureFrame(){} // RVA: 0x7AD9435A0
    }

    public class TextureFrame[] : Array
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

}