// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.TerrainUtils
// Classes: 4
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.TerrainUtils
{
    public class TerrainMap : Object
    {
        public object m_patchSize;
        public object m_errorCode;
        public object m_terrainTiles;

        // ── Methods ──
        public void GetTerrain(){} // RVA: 0x7DB7D70
        public void CreateFromPlacement(){} // RVA: 0x7DB8350
        public void get_terrainTiles(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x7DB88E0
        public void AddTerrainInternal(){} // RVA: 0x7DB8A20
        public void TryToAddTerrain(){} // RVA: 0x7DB8B90
        public void ValidateTerrain(){} // RVA: 0x7DB8EF0
        public void Validate(){} // RVA: 0x7DB9E30
    }

    public class TerrainTileCoord : ValueType
    {
        public object tileX;
        public object tileZ;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2B100
    }

    public class TerrainUtility : Object
    {
        // ── Methods ──
        public void ValidTerrainsExist(){} // RVA: 0x7DBA100
        public void ClearConnectivity(){} // RVA: 0x7DBA1B0
        public void CollectTerrains(){} // RVA: 0x7DBA3B0
        public void AutoConnect(){} // RVA: 0x7DBA770
    }

    public class TerrainUtility[] : Array
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

}