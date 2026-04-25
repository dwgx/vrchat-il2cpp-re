// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 2
// Methods: 2

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class Team : Object
    {
        public Oculus.Platform.Models.UserList AssignedUsers; // 0x10
        public int MaxUsers; // 0x18
        public int MinUsers; // 0x1C
        public string Name; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888A700
    }

    public class TeamList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888AA00
    }

}