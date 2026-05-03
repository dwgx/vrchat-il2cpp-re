// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Video.Components.Base
// Classes: 1
// Methods: 29

namespace VRC.SDK3.Video.Components.Base
{
    public class BaseVRCVideoPlayer : MonoBehaviour
    {
        public System.Action`1<VRC.SDK3.Video.Components.Base.BaseVRCVideoPlayer> _initializeBase;
        public float _syncIndexTimeSet; // 0x20
        public float _syncIndexPosition; // 0x24
        public System.Collections.Generic.List`1<VRC.Udon.Common.Interfaces.IUdonBehaviour> _udonBehaviours; // 0x28
        public bool EnableAutomaticResync; // 0x30
        public object field_5; // 0x39
        public object field_6; // 0x3A
        public object field_7; // 0x3B

        // ── Methods ──
        public void get_InitializeBase(){} // RVA: 0x7FFE8A45D7D0
        public void set_InitializeBase(){} // RVA: 0x7FFE8A45D810
        public void get_SyncIndexTimeSet(){} // RVA: 0x7FFE81124080
        public void set_SyncIndexTimeSet(){} // RVA: 0x7FFE81D54160
        public void get_SyncIndexPosition(){} // RVA: 0x7FFE81268F50
        public void set_SyncIndexPosition(){} // RVA: 0x7FFE81268F60
        public void Start(){} // RVA: 0x7FFE8A45D8B0
        public void SetIndexMarker(){} // RVA: 0x7FFE8A45D970 | overloaded x2
        public void PlayURL(){} // RVA: 0x7FFE882288A0
        public void Play(){} // RVA: 0x7FFE882288A0
        public void SetTime(){} // RVA: 0x7FFE882288A0
        public void get_Loop(){} // RVA: 0x7FFE80E2F150
        public void set_Loop(){} // RVA: 0x7FFE80E466C0
        public void get_IsPlaying(){} // RVA: 0x7FFE80E2F150
        public void get_IsReady(){} // RVA: 0x7FFE80E2F150
        public void LoadURL(){} // RVA: 0x7FFE80E460A0
        public void Pause(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void GetTime(){} // RVA: 0x7FFE80E42E10
        public void GetDuration(){} // RVA: 0x7FFE80E42E10
        public void OnVideoReady(){} // RVA: 0x7FFE8A45D9F0
        public void OnVideoError(){} // RVA: 0x7FFE8A45DC00
        public void OnVideoStart(){} // RVA: 0x7FFE8A45DF30
        public void OnVideoLoop(){} // RVA: 0x7FFE8A45E140
        public void OnVideoEnd(){} // RVA: 0x7FFE8A45E350
        public void get_VideoWidth(){} // RVA: 0x7FFE80E2EDB0
        public void get_VideoHeight(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE8A45E560
    }

}