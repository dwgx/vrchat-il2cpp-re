// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 9
// Methods: 75

namespace VRC.Core.Networking.Pose
{
    public class Configuration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x827D280
    }

    public class DirectQuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x827D9E0
        public void Encode(){} // RVA: 0x827DD90
        public void CreateFingers(){} // RVA: 0x827E3B0
        public void CreateMuscles(){} // RVA: 0x827E460
        public void Decode(){} // RVA: 0x827E5F0
        public void ReadMuscles(){} // RVA: 0x827ED10
        public void ReadFingers(){} // RVA: 0x827EF70
        public void ReadLegacyFace(){} // RVA: 0x827F0B0
        public void ReadPuppet(){} // RVA: 0x827F1A0
    }

    public class IPoseRecorder
    {
        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x87D280
        public void set_UseDirectPoseCodec(){} // RVA: 0x894750
        public void UpdatePuppetChannelTypes(){} // RVA: 0x894320
        public void Decode(){} // RVA: 0x899A40
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Encode(){} // RVA: 0x881CA0
        public void Decode(){} // RVA: 0xA94080
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Encode(){} // RVA: 0x881CA0
        public void Decode(){} // RVA: 0x895520
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Encode(){} // RVA: 0x881CA0
        public void Decode(){} // RVA: 0x895520
    }

    public class PoseEvent : TweenableValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8280020
        public void Finalize(){} // RVA: 0x8280C60
        public void get_poseContents(){} // RVA: 0x5006610
        public void set_poseContents(){} // RVA: 0x6DEFD20
        public void get_IsImmobilized(){} // RVA: 0x8280E00
        public void get_IsLocomoting(){} // RVA: 0x8280E10
        public void get_IsSeated(){} // RVA: 0x8280E20
        public void get_InVehicle(){} // RVA: 0x8280E30
        public void get_IsGrounded(){} // RVA: 0x8280E40
        public void get_IsAFK(){} // RVA: 0x8280E50
        public void get_InStation(){} // RVA: 0x8280E60
        public void get_IsOwnerIKDisabled(){} // RVA: 0x8280E70
        public void get_IsMutingSelf(){} // RVA: 0x8280E80
        public void DeepCopy(){} // RVA: 0x8280E90
        public void PartialCopy(){} // RVA: 0x8280F90
        public void IsEmpty(){} // RVA: 0x8281770
        public void Contains(){} // RVA: 0x8281780
        public void Remove(){} // RVA: 0x8281790
        public void Add(){} // RVA: 0x82817A0
        public void ClearFlags(){} // RVA: 0x82817B0
        public void get_Contents(){} // RVA: 0x82817C0
        public void CountOnes(){} // RVA: 0x8281870
        public void Interpolate(){} // RVA: 0x82818A0
        public void Extrapolate(){} // RVA: 0x82818E0
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x8281960
        public void DecodeGestureFromNetwork(){} // RVA: 0x8281970
    }

    public class PoseEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class QuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8281FD0
        public void Encode(){} // RVA: 0x8282380
        public void CreateFingers(){} // RVA: 0x8282C30
        public void CreateMuscles(){} // RVA: 0x8282D00
        public void Decode(){} // RVA: 0x8282EC0
        public void ReadHandGestures(){} // RVA: 0x8283570
        public void ReadMuscles(){} // RVA: 0x8283730
        public void ReadFingers(){} // RVA: 0x8283A10
        public void ReadEyes(){} // RVA: 0x8283BF0
        public void ReadLegacyFace(){} // RVA: 0x8283D30
        public void ReadPuppet(){} // RVA: 0x8283EC0
    }

}