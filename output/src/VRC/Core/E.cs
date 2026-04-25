// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 2
// Methods: 16

namespace VRC.Core
{
    public class Endpoints : Object
    {
        public string Avatar;
        public string FavoriteList;
        public string Feedback;
        public string File;
        public string Moderation;
        public string Notification;
        public string PlayerModeration;
        public string User;
        public string World;
        public string WorldInstance;
    }

    public class ExtensionMethods : Object
    {
        public System.Collections.Generic.Stack`1<int> _componentIndices; // 0xFFFF
        public System.Text.StringBuilder _cachedStringBuilder;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFACBF327B0
        public void GetOrAddComponent(){} // RVA: 0x7FFAC2E8DC40
        public void GetHierarchyPath(){} // RVA: 0x7FFACBF32940
        public void GetShortHierarchyPath(){} // RVA: 0x7FFACBF32CB0
        public void GetFriendlyGenericTypeName(){} // RVA: 0x7FFACBF33130
        public void GetComponentsPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void GetComponentsInChildrenPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetComponentsInParentPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetComponentInClone(){} // RVA: 0x7FFACBF333F0
        public void Merge(){} // RVA: 0x7FFAC2C70C80
        public void CopyQueryParametersTo(){} // RVA: 0x7FFACBF34130
        public void .cctor(){} // RVA: 0x7FFACBF34840
    }

}