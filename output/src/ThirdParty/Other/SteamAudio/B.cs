// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 7
// Methods: 18

namespace ThirdParty.Other.SteamAudio
{
    public class BakedDataIdentifier : ValueType
    {
        public 0x6B298810 type; // 0x10
        public 0x6B2987B8 variation; // 0x14
        public SteamAudio.Sphere endpointInfluence; // 0x18
    }

    public class BakedDataLayerInfo : ValueType
    {
        public UnityEngine.GameObject gameObject; // 0x10
        public SteamAudio.BakedDataIdentifier identifier; // 0x18
        public int dataSize; // 0x30
    }

    public class BakedDataTask : ValueType
    {
        public UnityEngine.GameObject gameObject; // 0x10
        public UnityEngine.MonoBehaviour component; // 0x18
        public string name; // 0x20
        public SteamAudio.BakedDataIdentifier identifier; // 0x28
        public SteamAudio.SteamAudioProbeBatch[] probeBatches; // 0x40
        public string[] probeBatchNames; // 0x48
        public SteamAudio.SerializedData[] probeBatchAssets; // 0x50
        public SteamAudio.SteamAudioReverbDataPoint probe; // 0x58
        public UnityEngine.Vector3 probePosition; // 0x60
    }

    public class Baker : Object
    {
        public 0x6B297D68 sStatus;
        public SteamAudio.ProgressCallback sProgressCallback; // 0x8
        public UIntPtr sProgressCallbackPointer; // 0x10
        public System.Runtime.InteropServices.GCHandle sProgressCallbackHandle; // 0x18
        public System.Threading.Thread sThread; // 0x20
        public int sNumSubTasks; // 0x28
        public int sNumSubTasksCompleted; // 0x2C
        public bool sCancel; // 0x30
        public SteamAudio.BakedDataTask[] sTasks; // 0x38

        // ── Methods ──
        public void BeginBake(){} // RVA: 0x7FFAC8C08050
        public void EndBake(){} // RVA: 0x7FFAC8C088C0
        public void IsBakeActive(){} // RVA: 0x7FFAC8C08AC0
        public void DrawProgressBar(){} // RVA: 0x7FFAC3006850
        public void UpdateBakeProgress(){} // RVA: 0x7FFAC2F21310
        public void CancelBake(){} // RVA: 0x7FFAC8C08B20
        public void AdvanceProgress(){} // RVA: 0x7FFAC2F21310
        public void InEditorUpdate(){} // RVA: 0x7FFAC2F21310
        public void BakeThread(){} // RVA: 0x7FFAC8C08C60
        public void .cctor(){} // RVA: 0x7FFAC8C0A870
    }

    public class BatchedAnyHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C115F0
        public void Invoke(){} // RVA: 0x7FFAC5CC1930
        public void BeginInvoke(){} // RVA: 0x7FFAC8C117A0
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class BatchedClosestHitCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C115F0
        public void Invoke(){} // RVA: 0x7FFAC5CC1930
        public void BeginInvoke(){} // RVA: 0x7FFAC8C116C0
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class Box : ValueType
    {
        public SteamAudio.Vector3 minCoordinates; // 0x10
        public SteamAudio.Vector3 maxCoordinates; // 0x1C
    }

}