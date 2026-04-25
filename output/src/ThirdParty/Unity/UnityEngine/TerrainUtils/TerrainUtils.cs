// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TerrainUtils
// Classes: 3
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.TerrainUtils
{
    public class TerrainMap : Object
    {
        public UnityEngine.Vector3 terrainTiles; // 0x10
        public 0x6B2CBFB0 m_errorCode; // 0x1C
        public System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord,UnityEngine.Terrain> m_terrainTiles; // 0x20

        // ── Methods ──
        public void GetTerrain(){} // RVA: 0x7FFAC99F6F50
        public void CreateFromPlacement(){} // RVA: 0x7FFAC99F7690 | overloaded x2
        public void get_terrainTiles(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC99F7BF0
        public void AddTerrainInternal(){} // RVA: 0x7FFAC99F7D30
        public void TryToAddTerrain(){} // RVA: 0x7FFAC99F7FB0
        public void ValidateTerrain(){} // RVA: 0x7FFAC99F81E0
        public void Validate(){} // RVA: 0x7FFAC99F90D0
    }

    public class TerrainTileCoord : ValueType
    {
        public int tileX; // 0x10
        public int tileZ; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
    }

    public class TerrainUtility : Object
    {
        // ── Methods ──
        public void ValidTerrainsExist(){} // RVA: 0x7FFAC99F9350
        public void ClearConnectivity(){} // RVA: 0x7FFAC99F9400
        public void CollectTerrains(){} // RVA: 0x7FFAC99F9520
        public void AutoConnect(){} // RVA: 0x7FFAC99F98D0
    }

}