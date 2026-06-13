// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 9
// Methods: 211

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void RefreshTile(){} // RVA: 0x72B43C0
        public void CreateInstance(){} // RVA: 0x72B4630
        public void FindAllRefreshPositions(){} // RVA: 0x72B46E0
        public void GetAllTileData(){} // RVA: 0x72B4AA0
    }

    public class Tile
    {
        public UnityEngine.Sprite m_Sprite; // 0x18
        public UnityEngine.Color m_Color; // 0x20
        public UnityEngine.Matrix4x4 m_Transform; // 0x30
        public UnityEngine.GameObject m_InstancedGameObject; // 0x70
        public 0x659F1ED8 m_Flags; // 0x78
        public 0x659F1C70 m_ColliderType; // 0x7C

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x2F0F420
        public void set_sprite(){} // RVA: 0x343E80
        public void get_color(){} // RVA: 0x72B4D20
        public void set_color(){} // RVA: 0x5BD97C0
        public void get_transform(){} // RVA: 0x72B4D30
        public void set_transform(){} // RVA: 0x72B4D60
        public void get_gameObject(){} // RVA: 0x7188200
        public void set_gameObject(){} // RVA: 0x3A55A0
        public void get_flags(){} // RVA: 0x72B4D80
        public void set_flags(){} // RVA: 0x1AE6D80
        public void get_colliderType(){} // RVA: 0x72B4D90
        public void set_colliderType(){} // RVA: 0x6248F70
        public void GetTileData(){} // RVA: 0x72B4DA0
        public void .ctor(){} // RVA: 0x72B4E50
    }

    public class TileAnimationData
    {
    }

    public class TileBase
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x72B4EE0
        public void GetTileData(){} // RVA: 0x2DD310
        public void GetTileDataNoRef(){} // RVA: 0x72B4F20
        public void GetTileAnimationData(){} // RVA: 0x27694F0
        public void GetTileAnimationDataNoRef(){} // RVA: 0x72B5000
        public void GetTileAnimationDataRef(){} // RVA: 0x72B5090
        public void StartUp(){} // RVA: 0x27694F0
        public void StartUpRef(){} // RVA: 0x72B50D0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class TileChangeData
    {
    }

    public class TileData
    {
        public int m_Sprite; // 0x10
        public UnityEngine.Color m_Color; // 0x14
        public UnityEngine.Matrix4x4 m_Transform; // 0x24
        public int m_GameObject; // 0x64
        public 0x659F1ED8 m_Flags; // 0x68
        public 0x659F1C70 m_ColliderType; // 0x6C

        // ── Methods ──
        public void set_sprite(){} // RVA: 0x72BA140
        public void set_color(){} // RVA: 0x6FBAB40
        public void set_transform(){} // RVA: 0x72BA230
        public void set_gameObject(){} // RVA: 0x72BA250
        public void set_flags(){} // RVA: 0x9EAAE0
        public void set_colliderType(){} // RVA: 0x9EACA0
        public void CreateDefault(){} // RVA: 0x72BA340
        public void .cctor(){} // RVA: 0x72BA480
    }

    public class TileDataNative
    {
    }

    public class Tilemap
    {
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,SyncTile[]> cellSize;
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>> cellGap; // 0x8
        public bool cellLayout; // 0x18

        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x72B5110
        public void remove_tilemapTileChanged(){} // RVA: 0x72B5240
        public void add_tilemapPositionsChanged(){} // RVA: 0x72B5370
        public void remove_tilemapPositionsChanged(){} // RVA: 0x72B54B0
        public void get_bufferSyncTile(){} // RVA: 0x7090430
        public void set_bufferSyncTile(){} // RVA: 0x72B55F0
        public void HasSyncTileCallback(){} // RVA: 0x72B5690
        public void HasPositionsChangedCallback(){} // RVA: 0x72B56D0
        public void HandleSyncTileCallback(){} // RVA: 0x72B5710
        public void HandlePositionsChangedCallback(){} // RVA: 0x72B5770
        public void SendTilemapTileChangedCallback(){} // RVA: 0x72B5810
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x72B58C0
        public void SetSyncTileCallback(){} // RVA: 0x72B5110
        public void RemoveSyncTileCallback(){} // RVA: 0x72B5240
        public void get_layoutGrid(){} // RVA: 0x72B5970
        public void GetCellCenterLocal(){} // RVA: 0x72B59C0
        public void GetCellCenterWorld(){} // RVA: 0x72B5B60
        public void get_cellBounds(){} // RVA: 0x72B5D60
        public void get_localBounds(){} // RVA: 0x72B5E70
        public void get_localFrameBounds(){} // RVA: 0x72B5EE0
        public void get_animationFrameRate(){} // RVA: 0x72B5F50
        public void set_animationFrameRate(){} // RVA: 0x72B5FA0
        public void get_color(){} // RVA: 0x72B6000
        public void set_color(){} // RVA: 0x72B6070
        public void get_origin(){} // RVA: 0x72B60D0
        public void set_origin(){} // RVA: 0x72B6140
        public void get_size(){} // RVA: 0x72B61A0
        public void set_size(){} // RVA: 0x72B6210
        public void get_tileAnchor(){} // RVA: 0x72B6270
        public void set_tileAnchor(){} // RVA: 0x72B62E0
        public void get_orientation(){} // RVA: 0x72B6340
        public void set_orientation(){} // RVA: 0x72B6390
        public void get_orientationMatrix(){} // RVA: 0x72B63F0
        public void set_orientationMatrix(){} // RVA: 0x72B6470
        public void GetTileAsset(){} // RVA: 0x72B64D0
        public void GetTile(){} // RVA: 0x283FA0 | overloaded x2
        public void GetTileAssetsBlock(){} // RVA: 0x72B6610
        public void GetTilesBlock(){} // RVA: 0x72B6680
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x72B68E0
        public void GetTilesBlockNonAlloc(){} // RVA: 0x72B6960
        public void GetTilesRangeCount(){} // RVA: 0x72B6A40
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x72B6AB0
        public void GetTilesRangeNonAlloc(){} // RVA: 0x72B6B40
        public void SetTileAsset(){} // RVA: 0x72B6BE0
        public void SetTile(){} // RVA: 0x72B6EA0 | overloaded x2
        public void SetTileAssets(){} // RVA: 0x72B6CD0
        public void SetTiles(){} // RVA: 0x72B6F10 | overloaded x2
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x72B6D40
        public void SetTilesBlock(){} // RVA: 0x72B6DC0
        public void HasTile(){} // RVA: 0x72B6F80
        public void RefreshTile(){} // RVA: 0x72B70C0
        public void RefreshTilesNative(){} // RVA: 0x72B7120
        public void RefreshAllTiles(){} // RVA: 0x72B7190
        public void SwapTileAsset(){} // RVA: 0x72B71E0
        public void SwapTile(){} // RVA: 0x72B71E0
        public void ContainsTileAsset(){} // RVA: 0x72B7250
        public void ContainsTile(){} // RVA: 0x72B7250
        public void GetUsedTilesCount(){} // RVA: 0x72B72B0
        public void GetUsedSpritesCount(){} // RVA: 0x72B7300
        public void GetUsedTilesNonAlloc(){} // RVA: 0x72B7350
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x72B73B0
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x72B7350
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x72B73B0
        public void GetSprite(){} // RVA: 0x72B7410
        public void GetTransformMatrix(){} // RVA: 0x72B7470
        public void SetTransformMatrix(){} // RVA: 0x72B7500
        public void GetColor(){} // RVA: 0x72B7570
        public void SetColor(){} // RVA: 0x72B75F0
        public void GetTileFlags(){} // RVA: 0x72B7660
        public void SetTileFlags(){} // RVA: 0x72B76C0
        public void AddTileFlags(){} // RVA: 0x72B7730
        public void RemoveTileFlags(){} // RVA: 0x72B77A0
        public void GetInstantiatedObject(){} // RVA: 0x72B7810
        public void GetObjectToInstantiate(){} // RVA: 0x72B7870
        public void SetColliderType(){} // RVA: 0x72B78D0
        public void GetColliderType(){} // RVA: 0x72B7940
        public void GetAnimationFrameCount(){} // RVA: 0x72B79A0
        public void GetAnimationFrame(){} // RVA: 0x72B7A00
        public void SetAnimationFrame(){} // RVA: 0x72B7A60
        public void GetAnimationTime(){} // RVA: 0x72B7AD0
        public void SetAnimationTime(){} // RVA: 0x72B7B30
        public void GetTileAnimationFlags(){} // RVA: 0x72B7BA0
        public void SetTileAnimationFlags(){} // RVA: 0x72B7C00
        public void AddTileAnimationFlags(){} // RVA: 0x72B7C70
        public void RemoveTileAnimationFlags(){} // RVA: 0x72B7CE0
        public void FloodFill(){} // RVA: 0x72B7D50
        public void FloodFillTileAsset(){} // RVA: 0x72B7DD0
        public void BoxFill(){} // RVA: 0x72B7E40
        public void BoxFillTileAsset(){} // RVA: 0x72B7EF0
        public void InsertCells(){} // RVA: 0x72B8030 | overloaded x2
        public void DeleteCells(){} // RVA: 0x72B8160 | overloaded x2
        public void ClearAllTiles(){} // RVA: 0x72B81F0
        public void ResizeBounds(){} // RVA: 0x72B8240
        public void CompressBounds(){} // RVA: 0x72B8290
        public void GetSyncTileCallbackSettings(){} // RVA: 0x72B82E0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x72B8380
        public void DoSyncTileCallback(){} // RVA: 0x72B5710
        public void DoPositionsChangedCallback(){} // RVA: 0x72B5770
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_localBounds_Injected(){} // RVA: 0x72B83D0
        public void get_localFrameBounds_Injected(){} // RVA: 0x72B8430
        public void get_color_Injected(){} // RVA: 0x72B8490
        public void set_color_Injected(){} // RVA: 0x72B84F0
        public void get_origin_Injected(){} // RVA: 0x72B8550
        public void set_origin_Injected(){} // RVA: 0x72B85B0
        public void get_size_Injected(){} // RVA: 0x72B8610
        public void set_size_Injected(){} // RVA: 0x72B8670
        public void get_tileAnchor_Injected(){} // RVA: 0x72B86D0
        public void set_tileAnchor_Injected(){} // RVA: 0x72B8730
        public void get_orientationMatrix_Injected(){} // RVA: 0x72B8790
        public void set_orientationMatrix_Injected(){} // RVA: 0x72B87F0
        public void GetTileAsset_Injected(){} // RVA: 0x72B8850
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x72B88B0
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x72B8920
        public void GetTilesRangeCount_Injected(){} // RVA: 0x72B89A0
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x72B8A10
        public void SetTileAsset_Injected(){} // RVA: 0x72B8AA0
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x72B8B10
        public void SetTile_Injected(){} // RVA: 0x72B8B90
        public void RefreshTile_Injected(){} // RVA: 0x72B8C00
        public void GetSprite_Injected(){} // RVA: 0x72B8C60
        public void GetTransformMatrix_Injected(){} // RVA: 0x72B8CC0
        public void SetTransformMatrix_Injected(){} // RVA: 0x72B8D30
        public void GetColor_Injected(){} // RVA: 0x72B8DA0
        public void SetColor_Injected(){} // RVA: 0x72B8E10
        public void GetTileFlags_Injected(){} // RVA: 0x72B8E80
        public void SetTileFlags_Injected(){} // RVA: 0x72B8EE0
        public void AddTileFlags_Injected(){} // RVA: 0x72B8F50
        public void RemoveTileFlags_Injected(){} // RVA: 0x72B8FC0
        public void GetInstantiatedObject_Injected(){} // RVA: 0x72B9030
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x72B9090
        public void SetColliderType_Injected(){} // RVA: 0x72B90F0
        public void GetColliderType_Injected(){} // RVA: 0x72B9160
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x72B91C0
        public void GetAnimationFrame_Injected(){} // RVA: 0x72B9220
        public void SetAnimationFrame_Injected(){} // RVA: 0x72B9280
        public void GetAnimationTime_Injected(){} // RVA: 0x72B92F0
        public void SetAnimationTime_Injected(){} // RVA: 0x72B9350
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x72B93C0
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x72B9420
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x72B9490
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x72B9500
        public void FloodFillTileAsset_Injected(){} // RVA: 0x72B9570
        public void BoxFillTileAsset_Injected(){} // RVA: 0x72B95E0
        public void InsertCells_Injected(){} // RVA: 0x72B9670
        public void DeleteCells_Injected(){} // RVA: 0x72B9700
    }

    public class TilemapRenderer
    {
        // ── Methods ──
        public void get_chunkSize(){} // RVA: 0x72B9790
        public void set_chunkSize(){} // RVA: 0x72B9800
        public void get_chunkCullingBounds(){} // RVA: 0x72B9860
        public void set_chunkCullingBounds(){} // RVA: 0x72B98D0
        public void get_maxChunkCount(){} // RVA: 0x72B9930
        public void set_maxChunkCount(){} // RVA: 0x72B9980
        public void get_maxFrameAge(){} // RVA: 0x72B99E0
        public void set_maxFrameAge(){} // RVA: 0x72B9A30
        public void get_sortOrder(){} // RVA: 0x72B9A90
        public void set_sortOrder(){} // RVA: 0x72B9AE0
        public void get_mode(){} // RVA: 0x72B9B40
        public void set_mode(){} // RVA: 0x72B9B90
        public void get_detectChunkCullingBounds(){} // RVA: 0x72B9BF0
        public void set_detectChunkCullingBounds(){} // RVA: 0x72B9C40
        public void get_maskInteraction(){} // RVA: 0x72B9CA0
        public void set_maskInteraction(){} // RVA: 0x72B9CF0
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x72B9D50
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x72B9DD0
        public void OnSpriteAtlasRegistered(){} // RVA: 0x72B9F60
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_chunkSize_Injected(){} // RVA: 0x72B9FC0
        public void set_chunkSize_Injected(){} // RVA: 0x72BA020
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x72BA080
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x72BA0E0
    }

}