// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.U2D
// Classes: 4
// Methods: 6

namespace ThirdParty.Unity.UnityEngine.U2D
{
    public class SpriteAtlas : Object
    {
        // ── Methods ──
        public void CanBindTo(){} // RVA: 0x7FFD54CFB1C0
    }

    public class SpriteAtlasManager : Object
    {
        public rectoryInformation<string,ileFullDirectoryInformation<lerRad_Injected.fTwo>> atlasRequested;
        public ileFullDirectoryInformation<lerRad_Injected.fTwo> atlasRegistered; // 0x8

        // ── Methods ──
        public void RequestAtlas(){} // RVA: 0x7FFD54CFADD0
        public void add_atlasRegistered(){} // RVA: 0x7FFD54CFAE90
        public void remove_atlasRegistered(){} // RVA: 0x7FFD54CFAFD0
        public void PostRegisteredAtlas(){} // RVA: 0x7FFD54CFB110
        public void Register(){} // RVA: 0x7FFD54CFB170
    }

    public class SpriteBone : ValueType
    {
        public string m_Name; // 0x10
        public string m_Guid; // 0x18
        public amut m_Position; // 0x20
        public R_12x12 m_Rotation; // 0x2C
        public float m_Length; // 0x3C
        public int m_ParentId; // 0x40
        public object m_Color; // 0x44
    }

    public class SpriteShapeRenderer : Renderer
    {
    }

}