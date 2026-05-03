// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TerrainUtils
// Classes: 3
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.TerrainUtils
{
    public class TerrainMap : Object
    {
        public UnityEngine.Vector3 m_patchSize; // 0x10

        // ── Methods ──
        public void GetTerrain(){} // RVA: 0x7FFE87D9F7F0
        public void CreateFromPlacement(){} // RVA: 0x7FFE87D9FF30 | overloaded x2
        public void get_terrainTiles(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE87DA0490
        public void AddTerrainInternal(){} // RVA: 0x7FFE87DA05D0
        public void TryToAddTerrain(){} // RVA: 0x7FFE87DA0850
        public void ValidateTerrain(){} // RVA: 0x7FFE87DA0A80
        public void Validate(){} // RVA: 0x7FFE87DA1970
    }

    public class TerrainTileCoord : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8164E250
    }

    public class TerrainUtility : Object
    {
        // ── Methods ──
        public void ValidTerrainsExist(){} // RVA: 0x7FFE87DA1BF0
        public void ClearConnectivity(){} // RVA: 0x7FFE87DA1CA0
        public void CollectTerrains(){} // RVA: 0x7FFE87DA1DC0
        public void AutoConnect(){} // RVA: 0x7FFE87DA2170
    }

}