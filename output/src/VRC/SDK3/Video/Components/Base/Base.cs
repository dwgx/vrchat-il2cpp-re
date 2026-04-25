// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components.Base
// Classes: 1
// Methods: 29

namespace VRC.SDK3.Video.Components.Base
{
    public class BaseVRCVideoPlayer : MonoBehaviour
    {
        public System.Action`1<VRC.SDK3.Video.Components.Base.BaseVRCVideoPlayer> InitializeBase;
        public float SyncIndexTimeSet; // 0x20
        public float SyncIndexPosition; // 0x24
        public System.Collections.Generic.List`1<VRC.Udon.Common.Interfaces.IUdonBehaviour> Loop; // 0x28
        public bool IsPlaying; // 0x30

        // ── Methods ──
        public void get_InitializeBase(){} // RVA: 0x7FFACBFF7FD0
        public void set_InitializeBase(){} // RVA: 0x7FFACBFF8010
        public void get_SyncIndexTimeSet(){} // RVA: 0x7FFAC2F4A080
        public void set_SyncIndexTimeSet(){} // RVA: 0x7FFAC4447440
        public void get_SyncIndexPosition(){} // RVA: 0x7FFAC308EF50
        public void set_SyncIndexPosition(){} // RVA: 0x7FFAC308EF60
        public void Start(){} // RVA: 0x7FFACBFF80B0
        public void SetIndexMarker(){} // RVA: 0x7FFACBFF8170 | overloaded x2
        public void PlayURL(){} // RVA: 0x7FFAC9E75F30
        public void Play(){} // RVA: 0x7FFAC9E75F30
        public void SetTime(){} // RVA: 0x7FFAC9E75F30
        public void get_Loop(){} // RVA: 0x7FFAC2C59D00
        public void set_Loop(){} // RVA: 0x7FFAC2C71060
        public void get_IsPlaying(){} // RVA: 0x7FFAC2C59D00
        public void get_IsReady(){} // RVA: 0x7FFAC2C59D00
        public void LoadURL(){} // RVA: 0x7FFAC2C70A40
        public void Pause(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void GetTime(){} // RVA: 0x7FFAC2C6D880
        public void GetDuration(){} // RVA: 0x7FFAC2C6D880
        public void OnVideoReady(){} // RVA: 0x7FFACBFF81F0
        public void OnVideoError(){} // RVA: 0x7FFACBFF8400
        public void OnVideoStart(){} // RVA: 0x7FFACBFF8730
        public void OnVideoLoop(){} // RVA: 0x7FFACBFF8940
        public void OnVideoEnd(){} // RVA: 0x7FFACBFF8B50
        public void get_VideoWidth(){} // RVA: 0x7FFAC2C59960
        public void get_VideoHeight(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFACBFF8D60
    }

}