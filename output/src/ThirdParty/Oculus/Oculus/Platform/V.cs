// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 5
// Methods: 38

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Voip : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE86C0EC00
        public void Accept(){} // RVA: 0x7FFE86C0ED30
        public void Stop(){} // RVA: 0x7FFE86C0EE60
        public void SetMicrophoneFilterCallback(){} // RVA: 0x7FFE86C0EF90
        public void SetMicrophoneMuted(){} // RVA: 0x7FFE86C0F0D0
        public void GetSystemVoipMicrophoneMuted(){} // RVA: 0x7FFE86C0F200
        public void GetSystemVoipStatus(){} // RVA: 0x7FFE86C0F320
        public void GetIsConnectionUsingDtx(){} // RVA: 0x7FFE86C0F440
        public void GetLocalBitrate(){} // RVA: 0x7FFE86C0F570
        public void GetRemoteBitrate(){} // RVA: 0x7FFE86C0F6A0
        public void SetNewConnectionOptions(){} // RVA: 0x7FFE86C0F7D0
        public void GetMicrophoneAvailability(){} // RVA: 0x7FFE86C0F900
        public void SetSystemVoipSuppressed(){} // RVA: 0x7FFE86C0FAB0
        public void SetVoipConnectRequestCallback(){} // RVA: 0x7FFE86C0FC60
        public void SetMicrophoneAvailabilityStateUpdateNotificationCallback(){} // RVA: 0x7FFE86C0FCD0
        public void SetVoipStateChangeCallback(){} // RVA: 0x7FFE86C0FD40
        public void SetSystemVoipStateNotificationCallback(){} // RVA: 0x7FFE86C0FDB0
    }

    public class VoipAudioSourceHiLevel : MonoBehaviour
    {
        public int initialPlaybackDelayMS; // 0x20

        // ── Methods ──
        public void set_senderID(){} // RVA: 0x7FFE86C1FC70
        public void Stop(){} // RVA: 0x7FFE810FB310
        public void SampleRateToEnum(){} // RVA: 0x7FFE86C1FCD0
        public void Awake(){} // RVA: 0x7FFE86C1FD00
        public void Start(){} // RVA: 0x7FFE86C20240
        public void CreatePCMSource(){} // RVA: 0x7FFE86C202A0
        public void MSToElements(){} // RVA: 0x7FFE86C20330
        public void Update(){} // RVA: 0x7FFE86C20390
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VoipOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C20C60
        public void SetBitrateForNewConnections(){} // RVA: 0x7FFE86C20D10
        public void SetCreateNewConnectionUseDtx(){} // RVA: 0x7FFE86C20DD0
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C20E90
    }

    public class VoipPCMSourceNative : Object
    {
        // ── Methods ──
        public void GetPCM(){} // RVA: 0x7FFE86C20F80
        public void SetSenderID(){} // RVA: 0x7FFE826F2ED0
        public void PeekSizeElements(){} // RVA: 0x7FFE86C21060
        public void Update(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Vrcamera : Object
    {
        // ── Methods ──
        public void SetGetDataChannelMessageUpdateNotificationCallback(){} // RVA: 0x7FFE86C1BD30
        public void SetGetSurfaceUpdateNotificationCallback(){} // RVA: 0x7FFE86C1BDA0
    }

}