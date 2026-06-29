// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 9
// Methods: 77

namespace VRC.Core.Networking.Pose
{
    public class Configuration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF422560
    }

    public class DirectQuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF422CC0
        public void Encode(){} // RVA: 0x7AF423070
        public void CreateFingers(){} // RVA: 0x7AF423690
        public void CreateMuscles(){} // RVA: 0x7AF423740
        public void Decode(){} // RVA: 0x7AF4238D0
        public void ReadMuscles(){} // RVA: 0x7AF423FF0
        public void ReadFingers(){} // RVA: 0x7AF424250
        public void ReadLegacyFace(){} // RVA: 0x7AF424390
        public void ReadPuppet(){} // RVA: 0x7AF424480
        public void lastEncodedMuscles(){} // RVA: 0x7B41AE978
    }

    public class IPoseRecorder
    {
        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x7A7E01900
        public void set_UseDirectPoseCodec(){} // RVA: 0x7A7E18C30
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7A7E18800
        public void Decode(){} // RVA: 0x7A7E1DD40
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Encode(){} // RVA: 0x7A7E06320
        public void Decode(){} // RVA: 0x7A8051B10
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Encode(){} // RVA: 0x7A7E06320
        public void Decode(){} // RVA: 0x7A7E199F0
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Encode(){} // RVA: 0x7A7E06320
        public void Decode(){} // RVA: 0x7A7E199F0
    }

    public class PoseEvent : TweenableValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF425300
        public void Finalize(){} // RVA: 0x7AF425F40
        public void get_poseContents(){} // RVA: 0x7AC2B74D0
        public void set_poseContents(){} // RVA: 0x7AE16F3A0
        public void get_IsImmobilized(){} // RVA: 0x7AF4260E0
        public void get_IsLocomoting(){} // RVA: 0x7AF4260F0
        public void get_IsSeated(){} // RVA: 0x7AF426100
        public void get_InVehicle(){} // RVA: 0x7AF426110
        public void get_IsGrounded(){} // RVA: 0x7AF426120
        public void get_IsAFK(){} // RVA: 0x7AF426130
        public void get_InStation(){} // RVA: 0x7AF426140
        public void get_IsOwnerIKDisabled(){} // RVA: 0x7AF426150
        public void get_IsMutingSelf(){} // RVA: 0x7AF426160
        public void DeepCopy(){} // RVA: 0x7AF426170
        public void PartialCopy(){} // RVA: 0x7AF426270
        public void IsEmpty(){} // RVA: 0x7AF426A50
        public void Contains(){} // RVA: 0x7AF426A60
        public void Remove(){} // RVA: 0x7AF426A70
        public void Add(){} // RVA: 0x7AF426A80
        public void ClearFlags(){} // RVA: 0x7AF426A90
        public void get_Contents(){} // RVA: 0x7AF426AA0
        public void CountOnes(){} // RVA: 0x7AF426B50
        public void Interpolate(){} // RVA: 0x7AF426B80
        public void Extrapolate(){} // RVA: 0x7AF426BC0
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7AF426C40
        public void DecodeGestureFromNetwork(){} // RVA: 0x7AF426C50
    }

    public class PoseEvent[] : Array
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

    public class QuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF4272D0
        public void Encode(){} // RVA: 0x7AF427680
        public void CreateFingers(){} // RVA: 0x7AF427F30
        public void CreateMuscles(){} // RVA: 0x7AF428000
        public void Decode(){} // RVA: 0x7AF4281C0
        public void ReadHandGestures(){} // RVA: 0x7AF428870
        public void ReadMuscles(){} // RVA: 0x7AF428A30
        public void ReadFingers(){} // RVA: 0x7AF428D10
        public void ReadEyes(){} // RVA: 0x7AF428EF0
        public void ReadLegacyFace(){} // RVA: 0x7AF429030
        public void ReadPuppet(){} // RVA: 0x7AF4291C0
        public void lastEncodedMuscles(){} // RVA: 0x7B41AE978
    }

}