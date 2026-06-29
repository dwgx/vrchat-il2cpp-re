// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 15
// Methods: 381

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void RefreshTile(){} // RVA: 0x7E22350
        public void CreateInstance(){} // RVA: 0x7E22660
        public void FindAllRefreshPositions(){} // RVA: 0x7E22710
        public void GetAllTileData(){} // RVA: 0x7E22B50
    }

    public class ITilemap[] : Array
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

    public class Tile : TileBase
    {
        // ── Methods ──
        public void get_sprite(){} // RVA: 0x3926770
        public void set_sprite(){} // RVA: 0xBA9BA0
        public void get_color(){} // RVA: 0x7E22DD0
        public void set_color(){} // RVA: 0x16DCCA0
        public void get_transform(){} // RVA: 0x7E22DE0
        public void set_transform(){} // RVA: 0x7E22E10
        public void get_gameObject(){} // RVA: 0x7C7E370
        public void set_gameObject(){} // RVA: 0xC10060
        public void get_flags(){} // RVA: 0x7E22E30
        public void set_flags(){} // RVA: 0x23B2A80
        public void get_colliderType(){} // RVA: 0x7E22E40
        public void set_colliderType(){} // RVA: 0x6CB6340
        public void GetTileData(){} // RVA: 0x7E22E50
        public void .ctor(){} // RVA: 0x7E22F00
    }

    public class TileAnimationData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TileBase : ScriptableObject
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x7E22F90
        public void GetTileData(){} // RVA: 0xB43310
        public void GetTileDataNoRef(){} // RVA: 0x7E22FD0
        public void GetTileAnimationData(){} // RVA: 0x263B110
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7E230B0
        public void GetTileAnimationDataRef(){} // RVA: 0x7E23140
        public void StartUp(){} // RVA: 0x263B110
        public void StartUpRef(){} // RVA: 0x7E23180
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class TileBase[] : Array
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

    public class TileChangeData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80140
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B270
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC53C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35E00
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B270
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TileData : ValueType
    {
        // ── Methods ──
        public void set_sprite(){} // RVA: 0x98F380
        public void set_color(){} // RVA: 0x944100
        public void set_transform(){} // RVA: 0x98F390
        public void set_gameObject(){} // RVA: 0x98F3B0
        public void set_flags(){} // RVA: 0xA6A70
        public void set_colliderType(){} // RVA: 0xA6BC0
        public void CreateDefault(){} // RVA: 0x7E2B860
        public void .cctor(){} // RVA: 0x7E2B9A0
    }

    public class TileDataNative[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TileData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F930
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B050
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35750
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B050
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Tile[] : Array
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

    public class Tilemap : GridLayout
    {
        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7E231C0
        public void remove_tilemapTileChanged(){} // RVA: 0x7E232F0
        public void add_tilemapPositionsChanged(){} // RVA: 0x7E23420
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7E23560
        public void add_loopEndedForTileAnimation(){} // RVA: 0x7E236A0
        public void remove_loopEndedForTileAnimation(){} // RVA: 0x7E237E0
        public void get_bufferSyncTile(){} // RVA: 0x7B049C0
        public void set_bufferSyncTile(){} // RVA: 0x7E23920
        public void HasLoopEndedForTileAnimationCallback(){} // RVA: 0x7E23A10
        public void HandleLoopEndedForTileAnimationCallback(){} // RVA: 0x7E23A50
        public void SendLoopEndedForTileAnimationCallback(){} // RVA: 0x7E23B00
        public void HasSyncTileCallback(){} // RVA: 0x7E23BB0
        public void HasPositionsChangedCallback(){} // RVA: 0x7E23BF0
        public void HandleSyncTileCallback(){} // RVA: 0x7E23C30
        public void HandlePositionsChangedCallback(){} // RVA: 0x7E23C90
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7E23D40
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7E23DF0
        public void SetSyncTileCallback(){} // RVA: 0x7E231C0
        public void RemoveSyncTileCallback(){} // RVA: 0x7E232F0
        public void get_layoutGrid(){} // RVA: 0x7E23EA0
        public void GetCellCenterLocal(){} // RVA: 0x7E23F60
        public void GetCellCenterWorld(){} // RVA: 0x7E241D0
        public void get_cellBounds(){} // RVA: 0x7E244E0
        public void get_localBounds(){} // RVA: 0x7E24680
        public void get_localFrameBounds(){} // RVA: 0x7E24740
        public void get_animationFrameRate(){} // RVA: 0x7E24800
        public void set_animationFrameRate(){} // RVA: 0x7E248A0
        public void get_color(){} // RVA: 0x7E24950
        public void set_color(){} // RVA: 0x7E24A10
        public void get_origin(){} // RVA: 0x7E24AC0
        public void set_origin(){} // RVA: 0x7E24B80
        public void get_size(){} // RVA: 0x7E24C30
        public void set_size(){} // RVA: 0x7E24CF0
        public void get_tileAnchor(){} // RVA: 0x7E24DA0
        public void set_tileAnchor(){} // RVA: 0x7E24E60
        public void get_orientation(){} // RVA: 0x7E24F10
        public void set_orientation(){} // RVA: 0x7E24FB0
        public void get_orientationMatrix(){} // RVA: 0x7E25060
        public void set_orientationMatrix(){} // RVA: 0x7E25120
        public void GetTileAsset(){} // RVA: 0x7E251D0
        public void GetTile(){} // RVA: 0xA94080
        public void GetTileAssetsBlock(){} // RVA: 0x7E253E0
        public void GetTilesBlock(){} // RVA: 0x7E254A0
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7E25770
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7E25840
        public void GetTilesRangeCount(){} // RVA: 0x7E25960
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7E25A20
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7E25B80
        public void SetTileAsset(){} // RVA: 0x7E25CF0
        public void SetTile(){} // RVA: 0x7E261F0
        public void SetTileAssets(){} // RVA: 0x7E25ED0
        public void SetTiles(){} // RVA: 0x7E262B0
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7E26000
        public void SetTilesBlock(){} // RVA: 0x7E260D0
        public void HasTile(){} // RVA: 0x7E26370
        public void RefreshTile(){} // RVA: 0x7E26510
        public void RefreshTilesNative(){} // RVA: 0x7E265C0
        public void RefreshAllTiles(){} // RVA: 0x7E26680
        public void SwapTileAsset(){} // RVA: 0x7E26720
        public void SwapTile(){} // RVA: 0x7E26720
        public void ContainsTileAsset(){} // RVA: 0x7E26830
        public void ContainsTile(){} // RVA: 0x7E26830
        public void GetUsedTilesCount(){} // RVA: 0x7E26910
        public void GetUsedSpritesCount(){} // RVA: 0x7E269B0
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7E26A50
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7E26B00
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7E26A50
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7E26B00
        public void GetSprite(){} // RVA: 0x7E26BB0
        public void GetTransformMatrix(){} // RVA: 0x7E26C80
        public void SetTransformMatrix(){} // RVA: 0x7E26D50
        public void GetColor(){} // RVA: 0x7E26E10
        public void SetColor(){} // RVA: 0x7E26EE0
        public void GetTileFlags(){} // RVA: 0x7E26FA0
        public void SetTileFlags(){} // RVA: 0x7E27050
        public void AddTileFlags(){} // RVA: 0x7E27110
        public void RemoveTileFlags(){} // RVA: 0x7E271D0
        public void GetInstantiatedObject(){} // RVA: 0x7E27290
        public void GetObjectToInstantiate(){} // RVA: 0x7E27360
        public void SetColliderType(){} // RVA: 0x7E27430
        public void GetColliderType(){} // RVA: 0x7E274F0
        public void GetAnimationFrameCount(){} // RVA: 0x7E275A0
        public void GetAnimationFrame(){} // RVA: 0x7E27650
        public void SetAnimationFrame(){} // RVA: 0x7E27700
        public void GetAnimationTime(){} // RVA: 0x7E277C0
        public void SetAnimationTime(){} // RVA: 0x7E27870
        public void GetTileAnimationFlags(){} // RVA: 0x7E27930
        public void SetTileAnimationFlags(){} // RVA: 0x7E279E0
        public void AddTileAnimationFlags(){} // RVA: 0x7E27AA0
        public void RemoveTileAnimationFlags(){} // RVA: 0x7E27B60
        public void FloodFill(){} // RVA: 0x7E27C20
        public void FloodFillTileAsset(){} // RVA: 0x7E27D10
        public void BoxFill(){} // RVA: 0x7E27E00
        public void BoxFillTileAsset(){} // RVA: 0x7E27F30
        public void InsertCells(){} // RVA: 0x7E28150
        public void DeleteCells(){} // RVA: 0x7E28320
        public void ClearAllTiles(){} // RVA: 0x7E28400
        public void ResizeBounds(){} // RVA: 0x7E284A0
        public void CompressTilemapBounds(){} // RVA: 0x7E28540
        public void CompressBounds(){} // RVA: 0x7E285F0
        public void GetLoopEndedForTileAnimationCallbackSettings(){} // RVA: 0x7E28690
        public void DoLoopEndedForTileAnimationCallback(){} // RVA: 0x7E23A50
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7E286E0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7E28780
        public void DoSyncTileCallback(){} // RVA: 0x7E23C30
        public void DoPositionsChangedCallback(){} // RVA: 0x7E23C90
        public void .ctor(){} // RVA: 0xB43D60
        public void get_layoutGrid_Injected(){} // RVA: 0x7E28820
        public void get_localBounds_Injected(){} // RVA: 0x7E28870
        public void get_localFrameBounds_Injected(){} // RVA: 0x7E288D0
        public void get_animationFrameRate_Injected(){} // RVA: 0x7E28930
        public void set_animationFrameRate_Injected(){} // RVA: 0x7E28980
        public void get_color_Injected(){} // RVA: 0x7E289E0
        public void set_color_Injected(){} // RVA: 0x7E28A40
        public void get_origin_Injected(){} // RVA: 0x7E28AA0
        public void set_origin_Injected(){} // RVA: 0x7E28B00
        public void get_size_Injected(){} // RVA: 0x7E28B60
        public void set_size_Injected(){} // RVA: 0x7E28BC0
        public void get_tileAnchor_Injected(){} // RVA: 0x7E28C20
        public void set_tileAnchor_Injected(){} // RVA: 0x7E28C80
        public void get_orientation_Injected(){} // RVA: 0x7E28CE0
        public void set_orientation_Injected(){} // RVA: 0x7E28D30
        public void get_orientationMatrix_Injected(){} // RVA: 0x7E28D90
        public void set_orientationMatrix_Injected(){} // RVA: 0x7E28DF0
        public void GetTileAsset_Injected(){} // RVA: 0x7E28E50
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7E28EB0
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7E28F20
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7E28FA0
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7E29010
        public void SetTileAsset_Injected(){} // RVA: 0x7E290A0
        public void SetTileAssets_Injected(){} // RVA: 0x7E29110
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7E29180
        public void SetTile_Injected(){} // RVA: 0x7E29200
        public void SetTiles_Injected(){} // RVA: 0x7E29270
        public void RefreshTile_Injected(){} // RVA: 0x7E292E0
        public void RefreshTilesNative_Injected(){} // RVA: 0x7E29340
        public void RefreshAllTiles_Injected(){} // RVA: 0x7E293B0
        public void SwapTileAsset_Injected(){} // RVA: 0x7E29400
        public void ContainsTileAsset_Injected(){} // RVA: 0x7E29470
        public void GetUsedTilesCount_Injected(){} // RVA: 0x7E294D0
        public void GetUsedSpritesCount_Injected(){} // RVA: 0x7E29520
        public void Internal_GetUsedTilesNonAlloc_Injected(){} // RVA: 0x7E29570
        public void Internal_GetUsedSpritesNonAlloc_Injected(){} // RVA: 0x7E295D0
        public void GetSprite_Injected(){} // RVA: 0x7E29630
        public void GetTransformMatrix_Injected(){} // RVA: 0x7E29690
        public void SetTransformMatrix_Injected(){} // RVA: 0x7E29700
        public void GetColor_Injected(){} // RVA: 0x7E29770
        public void SetColor_Injected(){} // RVA: 0x7E297E0
        public void GetTileFlags_Injected(){} // RVA: 0x7E29850
        public void SetTileFlags_Injected(){} // RVA: 0x7E298B0
        public void AddTileFlags_Injected(){} // RVA: 0x7E29920
        public void RemoveTileFlags_Injected(){} // RVA: 0x7E29990
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7E29A00
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7E29A60
        public void SetColliderType_Injected(){} // RVA: 0x7E29AC0
        public void GetColliderType_Injected(){} // RVA: 0x7E29B30
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7E29B90
        public void GetAnimationFrame_Injected(){} // RVA: 0x7E29BF0
        public void SetAnimationFrame_Injected(){} // RVA: 0x7E29C50
        public void GetAnimationTime_Injected(){} // RVA: 0x7E29CC0
        public void SetAnimationTime_Injected(){} // RVA: 0x7E29D20
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7E29D90
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7E29DF0
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7E29E60
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7E29ED0
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7E29F40
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7E29FB0
        public void InsertCells_Injected(){} // RVA: 0x7E2A040
        public void DeleteCells_Injected(){} // RVA: 0x7E2A0D0
        public void ClearAllTiles_Injected(){} // RVA: 0x7E2A160
        public void ResizeBounds_Injected(){} // RVA: 0x7E2A1B0
        public void CompressTilemapBounds_Injected(){} // RVA: 0x7E2A200
        public void SendAndClearSyncTileBuffer_Injected(){} // RVA: 0x7E2A260
    }

    public class TilemapRenderer : Renderer
    {
        // ── Methods ──
        public void get_chunkSize(){} // RVA: 0x7E2A2B0
        public void set_chunkSize(){} // RVA: 0x7E2A370
        public void get_chunkCullingBounds(){} // RVA: 0x7E2A420
        public void set_chunkCullingBounds(){} // RVA: 0x7E2A4E0
        public void get_maxChunkCount(){} // RVA: 0x7E2A590
        public void set_maxChunkCount(){} // RVA: 0x7E2A630
        public void get_maxFrameAge(){} // RVA: 0x7E2A6E0
        public void set_maxFrameAge(){} // RVA: 0x7E2A780
        public void get_sortOrder(){} // RVA: 0x7E2A830
        public void set_sortOrder(){} // RVA: 0x7E2A8D0
        public void get_mode(){} // RVA: 0x7E2A980
        public void set_mode(){} // RVA: 0x7E2AA20
        public void get_detectChunkCullingBounds(){} // RVA: 0x7E2AAD0
        public void set_detectChunkCullingBounds(){} // RVA: 0x7E2AB70
        public void get_maskInteraction(){} // RVA: 0x7E2AC20
        public void set_maskInteraction(){} // RVA: 0x7E2ACC0
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7E2AD70
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7E2ADF0
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7E2AF80
        public void .ctor(){} // RVA: 0xB43D60
        public void get_chunkSize_Injected(){} // RVA: 0x7E2B060
        public void set_chunkSize_Injected(){} // RVA: 0x7E2B0C0
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7E2B120
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7E2B180
        public void get_maxChunkCount_Injected(){} // RVA: 0x7E2B1E0
        public void set_maxChunkCount_Injected(){} // RVA: 0x7E2B230
        public void get_maxFrameAge_Injected(){} // RVA: 0x7E2B290
        public void set_maxFrameAge_Injected(){} // RVA: 0x7E2B2E0
        public void get_sortOrder_Injected(){} // RVA: 0x7E2B340
        public void set_sortOrder_Injected(){} // RVA: 0x7E2B390
        public void get_mode_Injected(){} // RVA: 0x7E2B3F0
        public void set_mode_Injected(){} // RVA: 0x7E2B440
        public void get_detectChunkCullingBounds_Injected(){} // RVA: 0x7E2B4A0
        public void set_detectChunkCullingBounds_Injected(){} // RVA: 0x7E2B4F0
        public void get_maskInteraction_Injected(){} // RVA: 0x7E2B550
        public void set_maskInteraction_Injected(){} // RVA: 0x7E2B5A0
        public void OnSpriteAtlasRegistered_Injected(){} // RVA: 0x7E2B600
    }

    public class TilemapRenderer[] : Array
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

    public class Tilemap[] : Array
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