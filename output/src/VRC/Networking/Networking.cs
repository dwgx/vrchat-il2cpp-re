// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Networking
// Classes: 4
// Methods: 48

namespace VRC.Networking
{
    public class SerializationRecoveryHandler : Object
    {
        public VRC.Networking.SerializationRecoveryHandler _serializationRecoveryHandler;
        public System.Collections.Generic.Dictionary`2<int,VRC.Core.Networking.Tools.BunchCollection> ÎÏÍÏÌÎÍÌÌÏÎÏÍÎÏÏÍÌÌÎÌÍÏ; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC31A1600
        public void Equals(){} // RVA: 0x7FFAC31A17F0
        public void GetHashCode(){} // RVA: 0x7FFAC31A1890
        public void op_Implicit(){} // RVA: 0x7FFAC31A1AC0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC31A1B00
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC31A1E10
        public void .ctor(){} // RVA: 0x7FFAC31A1EB0
        public void Initialize(){} // RVA: 0x7FFAC31A1F70
        public void set_name(){} // RVA: 0x7FFAC31A2180
        public void Instantiate(){} // RVA: 0x7FFAC31A2490
        public void Init(){} // RVA: 0x7FFAC31A2530
    }

    public class UdonClientImageDownloader : Object
    {
        public System.Lazy`1<string> _udonClientImageDownloader;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC31CD850
        public void Equals(){} // RVA: 0x7FFAC31CD8F0
        public void GetHashCode(){} // RVA: 0x7FFAC31CD990
        public void op_Implicit(){} // RVA: 0x7FFAC31CDA10
        public void CompareBaseObjects(){} // RVA: 0x7FFAC31CDA90
        public void Initialize(){} // RVA: 0x7FFAC31CDB10
        public void GetCachedPtr(){} // RVA: 0x7FFAC31CDCF0
        public void get_name(){} // RVA: 0x7FFAC31CDE30
        public void set_name(){} // RVA: 0x7FFAC31CDEB0
        public void Instantiate(){} // RVA: 0x7FFAC31CDFA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC31CE180
    }

    public class UdonClientStringDownloader : Object
    {
        public System.Lazy`1<string> _udonClientStringDownloader;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC31CF0D0
        public void Equals(){} // RVA: 0x7FFAC31CF270
        public void Initialize(){} // RVA: 0x7FFAC31CF3B0
        public void op_Implicit(){} // RVA: 0x7FFAC31CF590
        public void CompareBaseObjects(){} // RVA: 0x7FFAC31CF770
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC31CF860
        public void GetCachedPtr(){} // RVA: 0x7FFAC31CFA40
        public void .cctor(){} // RVA: 0x7FFAC31CFC20
        public void set_name(){} // RVA: 0x7FFAC31CFD60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Instantiate(){} // RVA: 0x7FFAC31CFDE0
        public void GetHashCode(){} // RVA: 0x7FFAC31CFE60
        public void ToString(){} // RVA: 0x7FFAC31D0040
        public void ScheduleMediaTimerCallback(){} // RVA: 0x7FFAC31D00C0
    }

    public class VRCPhotonEventSequence : Object
    {
        public byte Reserved;
        public byte InterestRequestChannel;
        public byte UdonSerializationDataChannelStart;
        public byte UdonSerializationDataChannelEnd;
        public byte PlayerSerializationDataChannelStart;
        public byte PlayerSerializationDataChannelEnd;
        public byte UnreliableSerializationDataChannelStart;
        public byte UnreliableSerializationDataChannelEnd;
        public byte ReliableSerializationDataChannelStart;
        public byte ReliableSerializationDataChannelEnd;
        public byte ChannelCount;
        public byte sNextUnreliableSerializationChannel;
        public byte sNextReliableSerializationChannel; // 0x1
        public byte sNextPlayerSerializationChannel; // 0x2
        public byte sNextUdonSerializationChannel; // 0x3

        // ── Methods ──
        public void GetNextReliableSerializationChannel(){} // RVA: 0x7FFAC9D59CD0
        public void GetNextUnreliableSerializationChannel(){} // RVA: 0x7FFAC9D59D70
        public void GetNextPlayerSerializationChannel(){} // RVA: 0x7FFAC9D59E00
        public void GetNextUdonSerializationChannel(){} // RVA: 0x7FFAC9D59EA0
        public void IsReliableChannel(){} // RVA: 0x7FFAC9D59F40
        public void IsUnreliableChannel(){} // RVA: 0x7FFAC9D59F50
        public void IsPlayerChannel(){} // RVA: 0x7FFAC9D59F60
        public void IsUdonChannel(){} // RVA: 0x7FFAC9D59F70
        public void IsVoiceChannel(){} // RVA: 0x7FFAC9D59F80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9D59F90
    }

}