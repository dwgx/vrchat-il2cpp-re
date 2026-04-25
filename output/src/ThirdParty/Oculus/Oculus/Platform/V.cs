// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 5
// Methods: 38

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Voip : Object
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8865510
        public void Accept(){} // RVA: 0x7FFAC8865640
        public void Stop(){} // RVA: 0x7FFAC8865770
        public void SetMicrophoneFilterCallback(){} // RVA: 0x7FFAC88658A0
        public void SetMicrophoneMuted(){} // RVA: 0x7FFAC88659E0
        public void GetSystemVoipMicrophoneMuted(){} // RVA: 0x7FFAC8865B10
        public void GetSystemVoipStatus(){} // RVA: 0x7FFAC8865C30
        public void GetIsConnectionUsingDtx(){} // RVA: 0x7FFAC8865D50
        public void GetLocalBitrate(){} // RVA: 0x7FFAC8865E80
        public void GetRemoteBitrate(){} // RVA: 0x7FFAC8865FB0
        public void SetNewConnectionOptions(){} // RVA: 0x7FFAC88660E0
        public void GetMicrophoneAvailability(){} // RVA: 0x7FFAC8866210
        public void SetSystemVoipSuppressed(){} // RVA: 0x7FFAC88663C0
        public void SetVoipConnectRequestCallback(){} // RVA: 0x7FFAC8866570
        public void SetMicrophoneAvailabilityStateUpdateNotificationCallback(){} // RVA: 0x7FFAC88665E0
        public void SetVoipStateChangeCallback(){} // RVA: 0x7FFAC8866650
        public void SetSystemVoipStateNotificationCallback(){} // RVA: 0x7FFAC88666C0
    }

    public class VoipAudioSourceHiLevel : MonoBehaviour
    {
        public int senderID; // 0x20
        public UnityEngine.AudioSource audioSource; // 0x28
        public float peakAmplitude; // 0x30
        public Oculus.Platform.IVoipPCMSource pcmSource; // 0x38
        public int audioSystemPlaybackFrequency;
        public bool verboseLogging; // 0x4

        // ── Methods ──
        public void set_senderID(){} // RVA: 0x7FFAC8876580
        public void Stop(){} // RVA: 0x7FFAC2F21310
        public void SampleRateToEnum(){} // RVA: 0x7FFAC88765E0
        public void Awake(){} // RVA: 0x7FFAC8876610
        public void Start(){} // RVA: 0x7FFAC8876B50
        public void CreatePCMSource(){} // RVA: 0x7FFAC8876BB0
        public void MSToElements(){} // RVA: 0x7FFAC8876C40
        public void Update(){} // RVA: 0x7FFAC8876CA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VoipOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8877570
        public void SetBitrateForNewConnections(){} // RVA: 0x7FFAC8877620
        public void SetCreateNewConnectionUseDtx(){} // RVA: 0x7FFAC88776E0
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC88777A0
    }

    public class VoipPCMSourceNative : Object
    {
        public ulong senderID; // 0x10

        // ── Methods ──
        public void GetPCM(){} // RVA: 0x7FFAC8877890
        public void SetSenderID(){} // RVA: 0x7FFAC441EFB0
        public void PeekSizeElements(){} // RVA: 0x7FFAC8877970
        public void Update(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Vrcamera : Object
    {
        // ── Methods ──
        public void SetGetDataChannelMessageUpdateNotificationCallback(){} // RVA: 0x7FFAC8872640
        public void SetGetSurfaceUpdateNotificationCallback(){} // RVA: 0x7FFAC88726B0
    }

}