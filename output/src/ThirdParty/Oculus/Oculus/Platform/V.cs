// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 5
// Methods: 39

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Voip : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7ADEBA110
        public void Accept(){} // RVA: 0x7ADEBA240
        public void Stop(){} // RVA: 0x7ADEBA370
        public void SetMicrophoneFilterCallback(){} // RVA: 0x7ADEBA4A0
        public void SetMicrophoneMuted(){} // RVA: 0x7ADEBA5E0
        public void GetSystemVoipMicrophoneMuted(){} // RVA: 0x7ADEBA710
        public void GetSystemVoipStatus(){} // RVA: 0x7ADEBA830
        public void GetIsConnectionUsingDtx(){} // RVA: 0x7ADEBA950
        public void GetLocalBitrate(){} // RVA: 0x7ADEBAA80
        public void GetRemoteBitrate(){} // RVA: 0x7ADEBABB0
        public void SetNewConnectionOptions(){} // RVA: 0x7ADEBACE0
        public void GetMicrophoneAvailability(){} // RVA: 0x7ADEBAE10
        public void SetSystemVoipSuppressed(){} // RVA: 0x7ADEBAFC0
        public void SetVoipConnectRequestCallback(){} // RVA: 0x7ADEBB170
        public void SetMicrophoneAvailabilityStateUpdateNotificationCallback(){} // RVA: 0x7ADEBB1E0
        public void SetVoipStateChangeCallback(){} // RVA: 0x7ADEBB250
        public void SetSystemVoipStateNotificationCallback(){} // RVA: 0x7ADEBB2C0
    }

    public class VoipAudioSourceHiLevel : MonoBehaviour
    {
        // ── Methods ──
        public void set_senderID(){} // RVA: 0x7ADECB190
        public void Stop(){} // RVA: 0x7A80D7310
        public void SampleRateToEnum(){} // RVA: 0x7ADECB1F0
        public void Awake(){} // RVA: 0x7ADECB220
        public void Start(){} // RVA: 0x7ADECB760
        public void CreatePCMSource(){} // RVA: 0x7ADECB7C0
        public void MSToElements(){} // RVA: 0x7ADECB850
        public void Update(){} // RVA: 0x7ADECB8B0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class VoipOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADECC1A0
        public void SetBitrateForNewConnections(){} // RVA: 0x7ADECC250
        public void SetCreateNewConnectionUseDtx(){} // RVA: 0x7ADECC310
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADECC3D0
        public void Handle(){} // RVA: 0x7B4175688
    }

    public class VoipPCMSourceNative : Object
    {
        // ── Methods ──
        public void GetPCM(){} // RVA: 0x7ADECC4C0
        public void SetSenderID(){} // RVA: 0x7A97242F0
        public void PeekSizeElements(){} // RVA: 0x7ADECC5A0
        public void Update(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Vrcamera : Object
    {
        // ── Methods ──
        public void SetGetDataChannelMessageUpdateNotificationCallback(){} // RVA: 0x7ADEC7250
        public void SetGetSurfaceUpdateNotificationCallback(){} // RVA: 0x7ADEC72C0
    }

}