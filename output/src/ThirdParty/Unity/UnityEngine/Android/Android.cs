// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Android
// Classes: 3
// Methods: 4

namespace ThirdParty.Unity.UnityEngine.Android
{
    public class AndroidApp : Object
    {
        public object UnityPlayerRaw;

        // ── Methods ──
        public void get_UnityPlayerRaw(){} // RVA: 0x7FFAC9825E00
    }

    public class Permission : ValueType
    {
        // ── Methods ──
        public void HasUserAuthorizedPermission(){} // RVA: 0x7FFAC9825E50
        public void RequestUserPermission(){} // RVA: 0x7FFAC9825E60
        public void RequestUserPermissions(){} // RVA: 0x7FFAC35D2DD0
    }

    public class PermissionCallbacks : AndroidJavaProxy
    {
    }

}