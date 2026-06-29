// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 15
// Methods: 341

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void RefreshTile(){} // RVA: 0x7AF0943A0
        public void CreateInstance(){} // RVA: 0x7AF094670
        public void FindAllRefreshPositions(){} // RVA: 0x7AF094720
        public void GetAllTileData(){} // RVA: 0x7AF094B30
    }

    public class ITilemap[] : Array
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

    public class Tile : TileBase
    {
        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7AACE3A80
        public void set_sprite(){} // RVA: 0x7A813E420
        public void get_color(){} // RVA: 0x7AF094DB0
        public void set_color(){} // RVA: 0x7AD9C7340
        public void get_transform(){} // RVA: 0x7AF094DC0
        public void set_transform(){} // RVA: 0x7AF094DF0
        public void get_gameObject(){} // RVA: 0x7AEF673C0
        public void set_gameObject(){} // RVA: 0x7A81A00F0
        public void get_flags(){} // RVA: 0x7AF094E10
        public void set_flags(){} // RVA: 0x7A98A0B60
        public void get_colliderType(){} // RVA: 0x7AF094E20
        public void set_colliderType(){} // RVA: 0x7AE034E90
        public void GetTileData(){} // RVA: 0x7AF094E30
        public void .ctor(){} // RVA: 0x7AF094EE0
    }

    public class TileAnimationData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TileBase : ScriptableObject
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x7AF094F70
        public void GetTileData(){} // RVA: 0x7A80D7310
        public void GetTileDataNoRef(){} // RVA: 0x7AF094FB0
        public void GetTileAnimationData(){} // RVA: 0x7AA57AB40
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7AF095090
        public void GetTileAnimationDataRef(){} // RVA: 0x7AF095120
        public void StartUp(){} // RVA: 0x7AA57AB40
        public void StartUpRef(){} // RVA: 0x7AF095160
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class TileBase[] : Array
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

    public class TileChangeData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A2C30
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E780
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E3AE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25CA80
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E780
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TileData : ValueType
    {
        // ── Methods ──
        public void set_sprite(){} // RVA: 0x7A7EFAF40
        public void set_color(){} // RVA: 0x7A7EC0C70
        public void set_transform(){} // RVA: 0x7A7EFAF50
        public void set_gameObject(){} // RVA: 0x7A7EFAF70
        public void set_flags(){} // RVA: 0x7A7690DA0
        public void set_colliderType(){} // RVA: 0x7A7690C50
        public void CreateDefault(){} // RVA: 0x7AF09A400
        public void .cctor(){} // RVA: 0x7AF09A540
    }

    public class TileDataNative[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TileData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A40C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29ED50
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4690
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25DB30
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29ED50
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Tile[] : Array
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

    public class Tilemap : GridLayout
    {
        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7AF0951A0
        public void remove_tilemapTileChanged(){} // RVA: 0x7AF0952D0
        public void add_tilemapPositionsChanged(){} // RVA: 0x7AF095400
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7AF095540
        public void get_bufferSyncTile(){} // RVA: 0x7AEE6F400
        public void set_bufferSyncTile(){} // RVA: 0x7AF095680
        public void HasSyncTileCallback(){} // RVA: 0x7AF095720
        public void HasPositionsChangedCallback(){} // RVA: 0x7AF095760
        public void HandleSyncTileCallback(){} // RVA: 0x7AF0957A0
        public void HandlePositionsChangedCallback(){} // RVA: 0x7AF095800
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7AF0958A0
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7AF095950
        public void SetSyncTileCallback(){} // RVA: 0x7AF0951A0
        public void RemoveSyncTileCallback(){} // RVA: 0x7AF0952D0
        public void get_layoutGrid(){} // RVA: 0x7AF095A00
        public void GetCellCenterLocal(){} // RVA: 0x7AF095A50
        public void GetCellCenterWorld(){} // RVA: 0x7AF095BF0
        public void get_cellBounds(){} // RVA: 0x7AF095DF0
        public void get_localBounds(){} // RVA: 0x7AF095F00
        public void get_localFrameBounds(){} // RVA: 0x7AF095F70
        public void get_animationFrameRate(){} // RVA: 0x7AF095FE0
        public void set_animationFrameRate(){} // RVA: 0x7AF096030
        public void get_color(){} // RVA: 0x7AF096090
        public void set_color(){} // RVA: 0x7AF096100
        public void get_origin(){} // RVA: 0x7AF096160
        public void set_origin(){} // RVA: 0x7AF0961D0
        public void get_size(){} // RVA: 0x7AF096230
        public void set_size(){} // RVA: 0x7AF0962A0
        public void get_tileAnchor(){} // RVA: 0x7AF096300
        public void set_tileAnchor(){} // RVA: 0x7AF096370
        public void get_orientation(){} // RVA: 0x7AF0963D0
        public void set_orientation(){} // RVA: 0x7AF096420
        public void get_orientationMatrix(){} // RVA: 0x7AF096480
        public void set_orientationMatrix(){} // RVA: 0x7AF096500
        public void GetTileAsset(){} // RVA: 0x7AF096560
        public void GetTile(){} // RVA: 0x7A8051B10
        public void GetTileAssetsBlock(){} // RVA: 0x7AF0966A0
        public void GetTilesBlock(){} // RVA: 0x7AF096710
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7AF0969A0
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7AF096A20
        public void GetTilesRangeCount(){} // RVA: 0x7AF096B00
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7AF096B70
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7AF096C00
        public void SetTileAsset(){} // RVA: 0x7AF096CA0
        public void SetTile(){} // RVA: 0x7AF096F60
        public void SetTileAssets(){} // RVA: 0x7AF096D90
        public void SetTiles(){} // RVA: 0x7AF096FD0
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7AF096E00
        public void SetTilesBlock(){} // RVA: 0x7AF096E80
        public void HasTile(){} // RVA: 0x7AF097040
        public void RefreshTile(){} // RVA: 0x7AF097180
        public void RefreshTilesNative(){} // RVA: 0x7AF0971E0
        public void RefreshAllTiles(){} // RVA: 0x7AF097250
        public void SwapTileAsset(){} // RVA: 0x7AF0972A0
        public void SwapTile(){} // RVA: 0x7AF0972A0
        public void ContainsTileAsset(){} // RVA: 0x7AF097310
        public void ContainsTile(){} // RVA: 0x7AF097310
        public void GetUsedTilesCount(){} // RVA: 0x7AF097370
        public void GetUsedSpritesCount(){} // RVA: 0x7AF0973C0
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7AF097410
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7AF097470
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7AF097410
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7AF097470
        public void GetSprite(){} // RVA: 0x7AF0974D0
        public void GetTransformMatrix(){} // RVA: 0x7AF097530
        public void SetTransformMatrix(){} // RVA: 0x7AF0975C0
        public void GetColor(){} // RVA: 0x7AF097630
        public void SetColor(){} // RVA: 0x7AF0976B0
        public void GetTileFlags(){} // RVA: 0x7AF097720
        public void SetTileFlags(){} // RVA: 0x7AF097780
        public void AddTileFlags(){} // RVA: 0x7AF0977F0
        public void RemoveTileFlags(){} // RVA: 0x7AF097860
        public void GetInstantiatedObject(){} // RVA: 0x7AF0978D0
        public void GetObjectToInstantiate(){} // RVA: 0x7AF097930
        public void SetColliderType(){} // RVA: 0x7AF097990
        public void GetColliderType(){} // RVA: 0x7AF097A00
        public void GetAnimationFrameCount(){} // RVA: 0x7AF097A60
        public void GetAnimationFrame(){} // RVA: 0x7AF097AC0
        public void SetAnimationFrame(){} // RVA: 0x7AF097B20
        public void GetAnimationTime(){} // RVA: 0x7AF097B90
        public void SetAnimationTime(){} // RVA: 0x7AF097BF0
        public void GetTileAnimationFlags(){} // RVA: 0x7AF097C60
        public void SetTileAnimationFlags(){} // RVA: 0x7AF097CC0
        public void AddTileAnimationFlags(){} // RVA: 0x7AF097D30
        public void RemoveTileAnimationFlags(){} // RVA: 0x7AF097DA0
        public void FloodFill(){} // RVA: 0x7AF097E10
        public void FloodFillTileAsset(){} // RVA: 0x7AF097E90
        public void BoxFill(){} // RVA: 0x7AF097F00
        public void BoxFillTileAsset(){} // RVA: 0x7AF097FB0
        public void InsertCells(){} // RVA: 0x7AF0980F0
        public void DeleteCells(){} // RVA: 0x7AF098220
        public void ClearAllTiles(){} // RVA: 0x7AF0982B0
        public void ResizeBounds(){} // RVA: 0x7AF098300
        public void CompressBounds(){} // RVA: 0x7AF098350
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7AF0983A0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7AF098440
        public void DoSyncTileCallback(){} // RVA: 0x7AF0957A0
        public void DoPositionsChangedCallback(){} // RVA: 0x7AF095800
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_localBounds_Injected(){} // RVA: 0x7AF098490
        public void get_localFrameBounds_Injected(){} // RVA: 0x7AF0984F0
        public void get_color_Injected(){} // RVA: 0x7AF098550
        public void set_color_Injected(){} // RVA: 0x7AF0985B0
        public void get_origin_Injected(){} // RVA: 0x7AF098610
        public void set_origin_Injected(){} // RVA: 0x7AF098670
        public void get_size_Injected(){} // RVA: 0x7AF0986D0
        public void set_size_Injected(){} // RVA: 0x7AF098730
        public void get_tileAnchor_Injected(){} // RVA: 0x7AF098790
        public void set_tileAnchor_Injected(){} // RVA: 0x7AF0987F0
        public void get_orientationMatrix_Injected(){} // RVA: 0x7AF098850
        public void set_orientationMatrix_Injected(){} // RVA: 0x7AF0988B0
        public void GetTileAsset_Injected(){} // RVA: 0x7AF098910
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7AF098970
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7AF0989E0
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7AF098A60
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7AF098AD0
        public void SetTileAsset_Injected(){} // RVA: 0x7AF098B60
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7AF098BD0
        public void SetTile_Injected(){} // RVA: 0x7AF098C50
        public void RefreshTile_Injected(){} // RVA: 0x7AF098CC0
        public void GetSprite_Injected(){} // RVA: 0x7AF098D20
        public void GetTransformMatrix_Injected(){} // RVA: 0x7AF098D80
        public void SetTransformMatrix_Injected(){} // RVA: 0x7AF098DF0
        public void GetColor_Injected(){} // RVA: 0x7AF098E60
        public void SetColor_Injected(){} // RVA: 0x7AF098ED0
        public void GetTileFlags_Injected(){} // RVA: 0x7AF098F40
        public void SetTileFlags_Injected(){} // RVA: 0x7AF098FA0
        public void AddTileFlags_Injected(){} // RVA: 0x7AF099010
        public void RemoveTileFlags_Injected(){} // RVA: 0x7AF099080
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7AF0990F0
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7AF099150
        public void SetColliderType_Injected(){} // RVA: 0x7AF0991B0
        public void GetColliderType_Injected(){} // RVA: 0x7AF099220
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7AF099280
        public void GetAnimationFrame_Injected(){} // RVA: 0x7AF0992E0
        public void SetAnimationFrame_Injected(){} // RVA: 0x7AF099340
        public void GetAnimationTime_Injected(){} // RVA: 0x7AF0993B0
        public void SetAnimationTime_Injected(){} // RVA: 0x7AF099410
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7AF099480
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7AF0994E0
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7AF099550
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7AF0995C0
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7AF099630
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7AF0996A0
        public void InsertCells_Injected(){} // RVA: 0x7AF099730
        public void DeleteCells_Injected(){} // RVA: 0x7AF0997C0
    }

    public class TilemapRenderer : Renderer
    {
        // ── Methods ──
        public void get_chunkSize(){} // RVA: 0x7AF099850
        public void set_chunkSize(){} // RVA: 0x7AF0998C0
        public void get_chunkCullingBounds(){} // RVA: 0x7AF099920
        public void set_chunkCullingBounds(){} // RVA: 0x7AF099990
        public void get_maxChunkCount(){} // RVA: 0x7AF0999F0
        public void set_maxChunkCount(){} // RVA: 0x7AF099A40
        public void get_maxFrameAge(){} // RVA: 0x7AF099AA0
        public void set_maxFrameAge(){} // RVA: 0x7AF099AF0
        public void get_sortOrder(){} // RVA: 0x7AF099B50
        public void set_sortOrder(){} // RVA: 0x7AF099BA0
        public void get_mode(){} // RVA: 0x7AF099C00
        public void set_mode(){} // RVA: 0x7AF099C50
        public void get_detectChunkCullingBounds(){} // RVA: 0x7AF099CB0
        public void set_detectChunkCullingBounds(){} // RVA: 0x7AF099D00
        public void get_maskInteraction(){} // RVA: 0x7AF099D60
        public void set_maskInteraction(){} // RVA: 0x7AF099DB0
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7AF099E10
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7AF099E90
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7AF09A020
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_chunkSize_Injected(){} // RVA: 0x7AF09A080
        public void set_chunkSize_Injected(){} // RVA: 0x7AF09A0E0
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7AF09A140
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7AF09A1A0
    }

    public class TilemapRenderer[] : Array
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

    public class Tilemap[] : Array
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

}