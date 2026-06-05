// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 9
// Methods: 211

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void RefreshTile(){} // RVA: 0x7FFAF9D643C0
        public void CreateInstance(){} // RVA: 0x7FFAF9D64630
        public void FindAllRefreshPositions(){} // RVA: 0x7FFAF9D646E0
        public void GetAllTileData(){} // RVA: 0x7FFAF9D64AA0
    }

    public class Tile
    {
        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFAF59BF420
        public void set_sprite(){} // RVA: 0x7FFAF2DF3E80
        public void get_color(){} // RVA: 0x7FFAF9D64D20
        public void set_color(){} // RVA: 0x7FFAF86897C0
        public void get_transform(){} // RVA: 0x7FFAF9D64D30
        public void set_transform(){} // RVA: 0x7FFAF9D64D60
        public void get_gameObject(){} // RVA: 0x7FFAF9C38200
        public void set_gameObject(){} // RVA: 0x7FFAF2E555A0
        public void get_flags(){} // RVA: 0x7FFAF9D64D80
        public void set_flags(){} // RVA: 0x7FFAF4596D80
        public void get_colliderType(){} // RVA: 0x7FFAF9D64D90
        public void set_colliderType(){} // RVA: 0x7FFAF8CF8F70
        public void GetTileData(){} // RVA: 0x7FFAF9D64DA0
        public void .ctor(){} // RVA: 0x7FFAF9D64E50
    }

    public class TileAnimationData
    {
    }

    public class TileBase
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x7FFAF9D64EE0
        public void GetTileData(){} // RVA: 0x7FFAF2D8D310
        public void GetTileDataNoRef(){} // RVA: 0x7FFAF9D64F20
        public void GetTileAnimationData(){} // RVA: 0x7FFAF52194F0
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7FFAF9D65000
        public void GetTileAnimationDataRef(){} // RVA: 0x7FFAF9D65090
        public void StartUp(){} // RVA: 0x7FFAF52194F0
        public void StartUpRef(){} // RVA: 0x7FFAF9D650D0
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class TileChangeData
    {
    }

    public class TileData
    {
        // ── Methods ──
        public void set_sprite(){} // RVA: 0x7FFAF9D6A140
        public void set_color(){} // RVA: 0x7FFAF9A6AB40
        public void set_transform(){} // RVA: 0x7FFAF9D6A230
        public void set_gameObject(){} // RVA: 0x7FFAF9D6A250
        public void set_flags(){} // RVA: 0x7FFAF349AAE0
        public void set_colliderType(){} // RVA: 0x7FFAF349ACA0
        public void CreateDefault(){} // RVA: 0x7FFAF9D6A340
        public void .cctor(){} // RVA: 0x7FFAF9D6A480
    }

    public class TileDataNative
    {
    }

    public class Tilemap
    {
        public object cellSize;
        public object cellGap;
        public object cellLayout;
        public object cellSwizzle;
        public object System.Collections.Generic;

        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7FFAF9D65110
        public void remove_tilemapTileChanged(){} // RVA: 0x7FFAF9D65240
        public void add_tilemapPositionsChanged(){} // RVA: 0x7FFAF9D65370
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7FFAF9D654B0
        public void get_bufferSyncTile(){} // RVA: 0x7FFAF9B40430
        public void set_bufferSyncTile(){} // RVA: 0x7FFAF9D655F0
        public void HasSyncTileCallback(){} // RVA: 0x7FFAF9D65690
        public void HasPositionsChangedCallback(){} // RVA: 0x7FFAF9D656D0
        public void HandleSyncTileCallback(){} // RVA: 0x7FFAF9D65710
        public void HandlePositionsChangedCallback(){} // RVA: 0x7FFAF9D65770
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7FFAF9D65810
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7FFAF9D658C0
        public void SetSyncTileCallback(){} // RVA: 0x7FFAF9D65110
        public void RemoveSyncTileCallback(){} // RVA: 0x7FFAF9D65240
        public void get_layoutGrid(){} // RVA: 0x7FFAF9D65970
        public void GetCellCenterLocal(){} // RVA: 0x7FFAF9D659C0
        public void GetCellCenterWorld(){} // RVA: 0x7FFAF9D65B60
        public void get_cellBounds(){} // RVA: 0x7FFAF9D65D60
        public void get_localBounds(){} // RVA: 0x7FFAF9D65E70
        public void get_localFrameBounds(){} // RVA: 0x7FFAF9D65EE0
        public void get_animationFrameRate(){} // RVA: 0x7FFAF9D65F50
        public void set_animationFrameRate(){} // RVA: 0x7FFAF9D65FA0
        public void get_color(){} // RVA: 0x7FFAF9D66000
        public void set_color(){} // RVA: 0x7FFAF9D66070
        public void get_origin(){} // RVA: 0x7FFAF9D660D0
        public void set_origin(){} // RVA: 0x7FFAF9D66140
        public void get_size(){} // RVA: 0x7FFAF9D661A0
        public void set_size(){} // RVA: 0x7FFAF9D66210
        public void get_tileAnchor(){} // RVA: 0x7FFAF9D66270
        public void set_tileAnchor(){} // RVA: 0x7FFAF9D662E0
        public void get_orientation(){} // RVA: 0x7FFAF9D66340
        public void set_orientation(){} // RVA: 0x7FFAF9D66390
        public void get_orientationMatrix(){} // RVA: 0x7FFAF9D663F0
        public void set_orientationMatrix(){} // RVA: 0x7FFAF9D66470
        public void GetTileAsset(){} // RVA: 0x7FFAF9D664D0
        public void GetTile(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetTileAssetsBlock(){} // RVA: 0x7FFAF9D66610
        public void GetTilesBlock(){} // RVA: 0x7FFAF9D66680
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7FFAF9D668E0
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7FFAF9D66960
        public void GetTilesRangeCount(){} // RVA: 0x7FFAF9D66A40
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7FFAF9D66AB0
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7FFAF9D66B40
        public void SetTileAsset(){} // RVA: 0x7FFAF9D66BE0
        public void SetTile(){} // RVA: 0x7FFAF9D66EA0 | overloaded x2
        public void SetTileAssets(){} // RVA: 0x7FFAF9D66CD0
        public void SetTiles(){} // RVA: 0x7FFAF9D66F10 | overloaded x2
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7FFAF9D66D40
        public void SetTilesBlock(){} // RVA: 0x7FFAF9D66DC0
        public void HasTile(){} // RVA: 0x7FFAF9D66F80
        public void RefreshTile(){} // RVA: 0x7FFAF9D670C0
        public void RefreshTilesNative(){} // RVA: 0x7FFAF9D67120
        public void RefreshAllTiles(){} // RVA: 0x7FFAF9D67190
        public void SwapTileAsset(){} // RVA: 0x7FFAF9D671E0
        public void SwapTile(){} // RVA: 0x7FFAF9D671E0
        public void ContainsTileAsset(){} // RVA: 0x7FFAF9D67250
        public void ContainsTile(){} // RVA: 0x7FFAF9D67250
        public void GetUsedTilesCount(){} // RVA: 0x7FFAF9D672B0
        public void GetUsedSpritesCount(){} // RVA: 0x7FFAF9D67300
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7FFAF9D67350
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7FFAF9D673B0
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7FFAF9D67350
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7FFAF9D673B0
        public void GetSprite(){} // RVA: 0x7FFAF9D67410
        public void GetTransformMatrix(){} // RVA: 0x7FFAF9D67470
        public void SetTransformMatrix(){} // RVA: 0x7FFAF9D67500
        public void GetColor(){} // RVA: 0x7FFAF9D67570
        public void SetColor(){} // RVA: 0x7FFAF9D675F0
        public void GetTileFlags(){} // RVA: 0x7FFAF9D67660
        public void SetTileFlags(){} // RVA: 0x7FFAF9D676C0
        public void AddTileFlags(){} // RVA: 0x7FFAF9D67730
        public void RemoveTileFlags(){} // RVA: 0x7FFAF9D677A0
        public void GetInstantiatedObject(){} // RVA: 0x7FFAF9D67810
        public void GetObjectToInstantiate(){} // RVA: 0x7FFAF9D67870
        public void SetColliderType(){} // RVA: 0x7FFAF9D678D0
        public void GetColliderType(){} // RVA: 0x7FFAF9D67940
        public void GetAnimationFrameCount(){} // RVA: 0x7FFAF9D679A0
        public void GetAnimationFrame(){} // RVA: 0x7FFAF9D67A00
        public void SetAnimationFrame(){} // RVA: 0x7FFAF9D67A60
        public void GetAnimationTime(){} // RVA: 0x7FFAF9D67AD0
        public void SetAnimationTime(){} // RVA: 0x7FFAF9D67B30
        public void GetTileAnimationFlags(){} // RVA: 0x7FFAF9D67BA0
        public void SetTileAnimationFlags(){} // RVA: 0x7FFAF9D67C00
        public void AddTileAnimationFlags(){} // RVA: 0x7FFAF9D67C70
        public void RemoveTileAnimationFlags(){} // RVA: 0x7FFAF9D67CE0
        public void FloodFill(){} // RVA: 0x7FFAF9D67D50
        public void FloodFillTileAsset(){} // RVA: 0x7FFAF9D67DD0
        public void BoxFill(){} // RVA: 0x7FFAF9D67E40
        public void BoxFillTileAsset(){} // RVA: 0x7FFAF9D67EF0
        public void InsertCells(){} // RVA: 0x7FFAF9D68030 | overloaded x2
        public void DeleteCells(){} // RVA: 0x7FFAF9D68160 | overloaded x2
        public void ClearAllTiles(){} // RVA: 0x7FFAF9D681F0
        public void ResizeBounds(){} // RVA: 0x7FFAF9D68240
        public void CompressBounds(){} // RVA: 0x7FFAF9D68290
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7FFAF9D682E0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7FFAF9D68380
        public void DoSyncTileCallback(){} // RVA: 0x7FFAF9D65710
        public void DoPositionsChangedCallback(){} // RVA: 0x7FFAF9D65770
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_localBounds_Injected(){} // RVA: 0x7FFAF9D683D0
        public void get_localFrameBounds_Injected(){} // RVA: 0x7FFAF9D68430
        public void get_color_Injected(){} // RVA: 0x7FFAF9D68490
        public void set_color_Injected(){} // RVA: 0x7FFAF9D684F0
        public void get_origin_Injected(){} // RVA: 0x7FFAF9D68550
        public void set_origin_Injected(){} // RVA: 0x7FFAF9D685B0
        public void get_size_Injected(){} // RVA: 0x7FFAF9D68610
        public void set_size_Injected(){} // RVA: 0x7FFAF9D68670
        public void get_tileAnchor_Injected(){} // RVA: 0x7FFAF9D686D0
        public void set_tileAnchor_Injected(){} // RVA: 0x7FFAF9D68730
        public void get_orientationMatrix_Injected(){} // RVA: 0x7FFAF9D68790
        public void set_orientationMatrix_Injected(){} // RVA: 0x7FFAF9D687F0
        public void GetTileAsset_Injected(){} // RVA: 0x7FFAF9D68850
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7FFAF9D688B0
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7FFAF9D68920
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7FFAF9D689A0
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7FFAF9D68A10
        public void SetTileAsset_Injected(){} // RVA: 0x7FFAF9D68AA0
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7FFAF9D68B10
        public void SetTile_Injected(){} // RVA: 0x7FFAF9D68B90
        public void RefreshTile_Injected(){} // RVA: 0x7FFAF9D68C00
        public void GetSprite_Injected(){} // RVA: 0x7FFAF9D68C60
        public void GetTransformMatrix_Injected(){} // RVA: 0x7FFAF9D68CC0
        public void SetTransformMatrix_Injected(){} // RVA: 0x7FFAF9D68D30
        public void GetColor_Injected(){} // RVA: 0x7FFAF9D68DA0
        public void SetColor_Injected(){} // RVA: 0x7FFAF9D68E10
        public void GetTileFlags_Injected(){} // RVA: 0x7FFAF9D68E80
        public void SetTileFlags_Injected(){} // RVA: 0x7FFAF9D68EE0
        public void AddTileFlags_Injected(){} // RVA: 0x7FFAF9D68F50
        public void RemoveTileFlags_Injected(){} // RVA: 0x7FFAF9D68FC0
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7FFAF9D69030
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7FFAF9D69090
        public void SetColliderType_Injected(){} // RVA: 0x7FFAF9D690F0
        public void GetColliderType_Injected(){} // RVA: 0x7FFAF9D69160
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7FFAF9D691C0
        public void GetAnimationFrame_Injected(){} // RVA: 0x7FFAF9D69220
        public void SetAnimationFrame_Injected(){} // RVA: 0x7FFAF9D69280
        public void GetAnimationTime_Injected(){} // RVA: 0x7FFAF9D692F0
        public void SetAnimationTime_Injected(){} // RVA: 0x7FFAF9D69350
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7FFAF9D693C0
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7FFAF9D69420
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7FFAF9D69490
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7FFAF9D69500
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7FFAF9D69570
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7FFAF9D695E0
        public void InsertCells_Injected(){} // RVA: 0x7FFAF9D69670
        public void DeleteCells_Injected(){} // RVA: 0x7FFAF9D69700
    }

    public class TilemapRenderer
    {
        // ── Methods ──
        public void get_chunkSize(){} // RVA: 0x7FFAF9D69790
        public void set_chunkSize(){} // RVA: 0x7FFAF9D69800
        public void get_chunkCullingBounds(){} // RVA: 0x7FFAF9D69860
        public void set_chunkCullingBounds(){} // RVA: 0x7FFAF9D698D0
        public void get_maxChunkCount(){} // RVA: 0x7FFAF9D69930
        public void set_maxChunkCount(){} // RVA: 0x7FFAF9D69980
        public void get_maxFrameAge(){} // RVA: 0x7FFAF9D699E0
        public void set_maxFrameAge(){} // RVA: 0x7FFAF9D69A30
        public void get_sortOrder(){} // RVA: 0x7FFAF9D69A90
        public void set_sortOrder(){} // RVA: 0x7FFAF9D69AE0
        public void get_mode(){} // RVA: 0x7FFAF9D69B40
        public void set_mode(){} // RVA: 0x7FFAF9D69B90
        public void get_detectChunkCullingBounds(){} // RVA: 0x7FFAF9D69BF0
        public void set_detectChunkCullingBounds(){} // RVA: 0x7FFAF9D69C40
        public void get_maskInteraction(){} // RVA: 0x7FFAF9D69CA0
        public void set_maskInteraction(){} // RVA: 0x7FFAF9D69CF0
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7FFAF9D69D50
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7FFAF9D69DD0
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7FFAF9D69F60
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_chunkSize_Injected(){} // RVA: 0x7FFAF9D69FC0
        public void set_chunkSize_Injected(){} // RVA: 0x7FFAF9D6A020
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7FFAF9D6A080
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7FFAF9D6A0E0
    }

}