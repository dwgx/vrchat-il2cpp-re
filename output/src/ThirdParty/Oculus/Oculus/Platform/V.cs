// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 5
// Methods: 38

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Voip : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6B412D0
        public void Accept(){} // RVA: 0x6B41400
        public void Stop(){} // RVA: 0x6B41530
        public void SetMicrophoneFilterCallback(){} // RVA: 0x6B41660
        public void SetMicrophoneMuted(){} // RVA: 0x6B417A0
        public void GetSystemVoipMicrophoneMuted(){} // RVA: 0x6B418D0
        public void GetSystemVoipStatus(){} // RVA: 0x6B419F0
        public void GetIsConnectionUsingDtx(){} // RVA: 0x6B41B10
        public void GetLocalBitrate(){} // RVA: 0x6B41C40
        public void GetRemoteBitrate(){} // RVA: 0x6B41D70
        public void SetNewConnectionOptions(){} // RVA: 0x6B41EA0
        public void GetMicrophoneAvailability(){} // RVA: 0x6B41FD0
        public void SetSystemVoipSuppressed(){} // RVA: 0x6B42180
        public void SetVoipConnectRequestCallback(){} // RVA: 0x6B42330
        public void SetMicrophoneAvailabilityStateUpdateNotificationCallback(){} // RVA: 0x6B423A0
        public void SetVoipStateChangeCallback(){} // RVA: 0x6B42410
        public void SetSystemVoipStateNotificationCallback(){} // RVA: 0x6B42480
    }

    public class VoipAudioSourceHiLevel : MonoBehaviour
    {
        // ── Methods ──
        public void set_senderID(){} // RVA: 0x6B52250
        public void Stop(){} // RVA: 0xB43310
        public void SampleRateToEnum(){} // RVA: 0x6B522B0
        public void Awake(){} // RVA: 0x6B522E0
        public void Start(){} // RVA: 0x6B52750
        public void CreatePCMSource(){} // RVA: 0x6B527F0
        public void MSToElements(){} // RVA: 0x6B52880
        public void Update(){} // RVA: 0x6B528E0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VoipOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B531A0
        public void SetBitrateForNewConnections(){} // RVA: 0x6B53250
        public void SetCreateNewConnectionUseDtx(){} // RVA: 0x6B53310
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B533D0
    }

    public class VoipPCMSourceNative : Object
    {
        // ── Methods ──
        public void GetPCM(){} // RVA: 0x6B534C0
        public void SetSenderID(){} // RVA: 0x2230E30
        public void PeekSizeElements(){} // RVA: 0x6B535A0
        public void Update(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Vrcamera : Object
    {
        // ── Methods ──
        public void SetGetDataChannelMessageUpdateNotificationCallback(){} // RVA: 0x6B4E410
        public void SetGetSurfaceUpdateNotificationCallback(){} // RVA: 0x6B4E480
    }

}