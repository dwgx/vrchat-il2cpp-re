// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components.AVPro
// Classes: 3
// Methods: 39

namespace VRC.SDK3.Video.Components.AVPro
{
    public class VRCAVProVideoPlayer : BaseVRCVideoPlayer
    {
        public object videoURL; // 0x331E12B0
        public object maximumResolution; // 0x331E12B0

        // ── Original Methods ──
        public void get_Initialize(){} // RVA: 0x7ffab1a13020
        public void set_Initialize(){} // RVA: 0x7ffab1a13060
        public void get_VideoURL(){} // RVA: 0x7ffaa89af740
        public void get_AutoPlay(){} // RVA: 0x7ffaa89e9d30
        public void get_MaximumResolution(){} // RVA: 0x7ffaa99531a0
        public void get_Initialized(){} // RVA: 0x7ffaa8bfcc70
        public void set_Initialized(){} // RVA: 0x7ffaa8bfbbe0
        public void get_UseLowLatency(){} // RVA: 0x7ffaa89ec8e0
        public void get_Loop(){} // RVA: 0x7ffab1a13100
        public void set_Loop(){} // RVA: 0x7ffab1a13150
        public void get_IsPlaying(){} // RVA: 0x7ffab1a131b0
        public void get_IsReady(){} // RVA: 0x7ffab1a13210
        public void OnValidate(){} // RVA: 0x7ffab1a13270
        public void Start(){} // RVA: 0x7ffab1a13290
        public void LoadURL(){} // RVA: 0x7ffab1a13400
        public void PlayURL(){} // RVA: 0x7ffab1a13460
        public void Play(){} // RVA: 0x7ffab1a134c0
        public void Pause(){} // RVA: 0x7ffab1a13520
        public void Stop(){} // RVA: 0x7ffab1a13570
        public void get_VideoWidth(){} // RVA: 0x7ffab1a136f0
        public void get_VideoHeight(){} // RVA: 0x7ffab1a13750
        public void .ctor(){} // RVA: 0x7ffab1a137b0
        // ── Binary Analysis Named ──
        public void GetDuration(){} // RVA: 0x7ffab1a135c0
        public void GetTime(){} // RVA: 0x7ffab1a13620
        public void SetTime(){} // RVA: 0x7ffab1a13680
    }

    public class VRCAVProVideoScreen : MonoBehaviour
    {
        public object materialIndex; // 0x331E00A0

        // ── Original Methods ──
        public void get_Initialize(){} // RVA: 0x7ffab1a137d0
        public void set_Initialize(){} // RVA: 0x7ffab1a13810
        public void get_VideoPlayer(){} // RVA: 0x7ffaa89600c0
        public void get_MaterialIndex(){} // RVA: 0x7ffaa8d14570
        public void get_TextureProperty(){} // RVA: 0x7ffaa8bfcc80
        public void get_UseSharedMaterial(){} // RVA: 0x7ffaa8bfcc70
        public void Start(){} // RVA: 0x7ffab1a138b0
        public void .ctor(){} // RVA: 0x7ffab1a139d0
    }

    public class VRCAVProVideoSpeaker : MonoBehaviour
    {
        public object mode; // 0x33D22800
        public object Initialize; // 0x17000036

        // ── Original Methods ──
        public void get_Initialize(){} // RVA: 0x7ffab1a13aa0
        public void set_Initialize(){} // RVA: 0x7ffab1a13ae0
        public void get_VideoPlayer(){} // RVA: 0x7ffaa89600c0
        public void get_Mode(){} // RVA: 0x7ffaa8d14570
        public void Start(){} // RVA: 0x7ffab1a13b80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}