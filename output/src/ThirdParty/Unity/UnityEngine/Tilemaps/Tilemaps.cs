// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 9
// Methods: 211

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void RefreshTile(){} // RVA: 0x7FFE87DF4560
        public void CreateInstance(){} // RVA: 0x7FFE87DF47D0
        public void FindAllRefreshPositions(){} // RVA: 0x7FFE87DF4880
        public void GetAllTileData(){} // RVA: 0x7FFE87DF4C40
    }

    public class Tile : TileBase
    {
        public UnityEngine.Sprite m_Sprite; // 0x18
        public UnityEngine.Color m_Color; // 0x20
        public UnityEngine.Matrix4x4 m_Transform; // 0x30
        public UnityEngine.GameObject m_InstancedGameObject; // 0x70
        public 0x666C996C m_Flags; // 0x78
        public 0x666C9704 m_ColliderType; // 0x7C

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFE83BBC680
        public void set_sprite(){} // RVA: 0x7FFE81161E80
        public void get_color(){} // RVA: 0x7FFE87DF4EC0
        public void set_color(){} // RVA: 0x7FFE8671A610
        public void get_transform(){} // RVA: 0x7FFE87DF4ED0
        public void set_transform(){} // RVA: 0x7FFE87DF4F00
        public void get_gameObject(){} // RVA: 0x7FFE87CC83A0
        public void set_gameObject(){} // RVA: 0x7FFE811C35A0
        public void get_flags(){} // RVA: 0x7FFE87DF4F20
        public void set_flags(){} // RVA: 0x7FFE82862F10
        public void get_colliderType(){} // RVA: 0x7FFE87DF4F30
        public void set_colliderType(){} // RVA: 0x7FFE86D89990
        public void GetTileData(){} // RVA: 0x7FFE87DF4F40
        public void .ctor(){} // RVA: 0x7FFE87DF4FF0
    }

    public class TileAnimationData : ValueType
    {
    }

    public class TileBase : ScriptableObject
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x7FFE87DF5080
        public void GetTileData(){} // RVA: 0x7FFE810FB310
        public void GetTileDataNoRef(){} // RVA: 0x7FFE87DF50C0
        public void GetTileAnimationData(){} // RVA: 0x7FFE834BA0A0
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7FFE87DF51A0
        public void GetTileAnimationDataRef(){} // RVA: 0x7FFE87DF5230
        public void StartUp(){} // RVA: 0x7FFE834BA0A0
        public void StartUpRef(){} // RVA: 0x7FFE87DF5270
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class TileChangeData : ValueType
    {
    }

    public class TileData : ValueType
    {
        public int m_Sprite; // 0x10
        public UnityEngine.Color m_Color; // 0x14
        public UnityEngine.Matrix4x4 m_Transform; // 0x24
        public int m_GameObject; // 0x64
        public 0x666C996C m_Flags; // 0x68
        public 0x666C9704 m_ColliderType; // 0x6C

        // ── Methods ──
        public void set_sprite(){} // RVA: 0x7FFE87DFA2E0
        public void set_color(){} // RVA: 0x7FFE87AFB9E0
        public void set_transform(){} // RVA: 0x7FFE87DFA3D0
        public void set_gameObject(){} // RVA: 0x7FFE87DFA3F0
        public void set_flags(){} // RVA: 0x7FFE8175AE70
        public void set_colliderType(){} // RVA: 0x7FFE8175ACA0
        public void CreateDefault(){} // RVA: 0x7FFE87DFA4E0
        public void .cctor(){} // RVA: 0x7FFE87DFA620
    }

    public class TileDataNative : ValueType
    {
    }

    public class Tilemap : GridLayout
    {
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,SyncTile[]> tilemapTileChanged;
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>> tilemapPositionsChanged; // 0x8
        public bool m_BufferSyncTile; // 0x18
        public object field_3; // 0xD2E0
        public object field_4; // 0xD160
        public object field_5; // 0xA950
        public object field_6; // 0x9D18
        public object field_7; // 0x7
        public object field_8; // 0x8
        public object field_9; // 0x9
        public object field_10; // 0xA
        public object field_11; // 0xB

        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7FFE87DF52B0
        public void remove_tilemapTileChanged(){} // RVA: 0x7FFE87DF53E0
        public void add_tilemapPositionsChanged(){} // RVA: 0x7FFE87DF5510
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7FFE87DF5650
        public void get_bufferSyncTile(){} // RVA: 0x7FFE87BD12F0
        public void set_bufferSyncTile(){} // RVA: 0x7FFE87DF5790
        public void HasSyncTileCallback(){} // RVA: 0x7FFE87DF5830
        public void HasPositionsChangedCallback(){} // RVA: 0x7FFE87DF5870
        public void HandleSyncTileCallback(){} // RVA: 0x7FFE87DF58B0
        public void HandlePositionsChangedCallback(){} // RVA: 0x7FFE87DF5910
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7FFE87DF59B0
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7FFE87DF5A60
        public void SetSyncTileCallback(){} // RVA: 0x7FFE87DF52B0
        public void RemoveSyncTileCallback(){} // RVA: 0x7FFE87DF53E0
        public void get_layoutGrid(){} // RVA: 0x7FFE87DF5B10
        public void GetCellCenterLocal(){} // RVA: 0x7FFE87DF5B60
        public void GetCellCenterWorld(){} // RVA: 0x7FFE87DF5D00
        public void get_cellBounds(){} // RVA: 0x7FFE87DF5F00
        public void get_localBounds(){} // RVA: 0x7FFE87DF6010
        public void get_localFrameBounds(){} // RVA: 0x7FFE87DF6080
        public void get_animationFrameRate(){} // RVA: 0x7FFE87DF60F0
        public void set_animationFrameRate(){} // RVA: 0x7FFE87DF6140
        public void get_color(){} // RVA: 0x7FFE87DF61A0
        public void set_color(){} // RVA: 0x7FFE87DF6210
        public void get_origin(){} // RVA: 0x7FFE87DF6270
        public void set_origin(){} // RVA: 0x7FFE87DF62E0
        public void get_size(){} // RVA: 0x7FFE87DF6340
        public void set_size(){} // RVA: 0x7FFE87DF63B0
        public void get_tileAnchor(){} // RVA: 0x7FFE87DF6410
        public void set_tileAnchor(){} // RVA: 0x7FFE87DF6480
        public void get_orientation(){} // RVA: 0x7FFE87DF64E0
        public void set_orientation(){} // RVA: 0x7FFE87DF6530
        public void get_orientationMatrix(){} // RVA: 0x7FFE87DF6590
        public void set_orientationMatrix(){} // RVA: 0x7FFE87DF6610
        public void GetTileAsset(){} // RVA: 0x7FFE87DF6670
        public void GetTile(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetTileAssetsBlock(){} // RVA: 0x7FFE87DF67B0
        public void GetTilesBlock(){} // RVA: 0x7FFE87DF6820
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7FFE87DF6A80
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7FFE87DF6B00
        public void GetTilesRangeCount(){} // RVA: 0x7FFE87DF6BE0
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7FFE87DF6C50
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7FFE87DF6CE0
        public void SetTileAsset(){} // RVA: 0x7FFE87DF6D80
        public void SetTile(){} // RVA: 0x7FFE87DF7040 | overloaded x2
        public void SetTileAssets(){} // RVA: 0x7FFE87DF6E70
        public void SetTiles(){} // RVA: 0x7FFE87DF70B0 | overloaded x2
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7FFE87DF6EE0
        public void SetTilesBlock(){} // RVA: 0x7FFE87DF6F60
        public void HasTile(){} // RVA: 0x7FFE87DF7120
        public void RefreshTile(){} // RVA: 0x7FFE87DF7260
        public void RefreshTilesNative(){} // RVA: 0x7FFE87DF72C0
        public void RefreshAllTiles(){} // RVA: 0x7FFE87DF7330
        public void SwapTileAsset(){} // RVA: 0x7FFE87DF7380
        public void SwapTile(){} // RVA: 0x7FFE87DF7380
        public void ContainsTileAsset(){} // RVA: 0x7FFE87DF73F0
        public void ContainsTile(){} // RVA: 0x7FFE87DF73F0
        public void GetUsedTilesCount(){} // RVA: 0x7FFE87DF7450
        public void GetUsedSpritesCount(){} // RVA: 0x7FFE87DF74A0
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7FFE87DF74F0
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7FFE87DF7550
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7FFE87DF74F0
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7FFE87DF7550
        public void GetSprite(){} // RVA: 0x7FFE87DF75B0
        public void GetTransformMatrix(){} // RVA: 0x7FFE87DF7610
        public void SetTransformMatrix(){} // RVA: 0x7FFE87DF76A0
        public void GetColor(){} // RVA: 0x7FFE87DF7710
        public void SetColor(){} // RVA: 0x7FFE87DF7790
        public void GetTileFlags(){} // RVA: 0x7FFE87DF7800
        public void SetTileFlags(){} // RVA: 0x7FFE87DF7860
        public void AddTileFlags(){} // RVA: 0x7FFE87DF78D0
        public void RemoveTileFlags(){} // RVA: 0x7FFE87DF7940
        public void GetInstantiatedObject(){} // RVA: 0x7FFE87DF79B0
        public void GetObjectToInstantiate(){} // RVA: 0x7FFE87DF7A10
        public void SetColliderType(){} // RVA: 0x7FFE87DF7A70
        public void GetColliderType(){} // RVA: 0x7FFE87DF7AE0
        public void GetAnimationFrameCount(){} // RVA: 0x7FFE87DF7B40
        public void GetAnimationFrame(){} // RVA: 0x7FFE87DF7BA0
        public void SetAnimationFrame(){} // RVA: 0x7FFE87DF7C00
        public void GetAnimationTime(){} // RVA: 0x7FFE87DF7C70
        public void SetAnimationTime(){} // RVA: 0x7FFE87DF7CD0
        public void GetTileAnimationFlags(){} // RVA: 0x7FFE87DF7D40
        public void SetTileAnimationFlags(){} // RVA: 0x7FFE87DF7DA0
        public void AddTileAnimationFlags(){} // RVA: 0x7FFE87DF7E10
        public void RemoveTileAnimationFlags(){} // RVA: 0x7FFE87DF7E80
        public void FloodFill(){} // RVA: 0x7FFE87DF7EF0
        public void FloodFillTileAsset(){} // RVA: 0x7FFE87DF7F70
        public void BoxFill(){} // RVA: 0x7FFE87DF7FE0
        public void BoxFillTileAsset(){} // RVA: 0x7FFE87DF8090
        public void InsertCells(){} // RVA: 0x7FFE87DF81D0 | overloaded x2
        public void DeleteCells(){} // RVA: 0x7FFE87DF8300 | overloaded x2
        public void ClearAllTiles(){} // RVA: 0x7FFE87DF8390
        public void ResizeBounds(){} // RVA: 0x7FFE87DF83E0
        public void CompressBounds(){} // RVA: 0x7FFE87DF8430
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7FFE87DF8480
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7FFE87DF8520
        public void DoSyncTileCallback(){} // RVA: 0x7FFE87DF58B0
        public void DoPositionsChangedCallback(){} // RVA: 0x7FFE87DF5910
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_localBounds_Injected(){} // RVA: 0x7FFE87DF8570
        public void get_localFrameBounds_Injected(){} // RVA: 0x7FFE87DF85D0
        public void get_color_Injected(){} // RVA: 0x7FFE87DF8630
        public void set_color_Injected(){} // RVA: 0x7FFE87DF8690
        public void get_origin_Injected(){} // RVA: 0x7FFE87DF86F0
        public void set_origin_Injected(){} // RVA: 0x7FFE87DF8750
        public void get_size_Injected(){} // RVA: 0x7FFE87DF87B0
        public void set_size_Injected(){} // RVA: 0x7FFE87DF8810
        public void get_tileAnchor_Injected(){} // RVA: 0x7FFE87DF8870
        public void set_tileAnchor_Injected(){} // RVA: 0x7FFE87DF88D0
        public void get_orientationMatrix_Injected(){} // RVA: 0x7FFE87DF8930
        public void set_orientationMatrix_Injected(){} // RVA: 0x7FFE87DF8990
        public void GetTileAsset_Injected(){} // RVA: 0x7FFE87DF89F0
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7FFE87DF8A50
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7FFE87DF8AC0
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7FFE87DF8B40
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7FFE87DF8BB0
        public void SetTileAsset_Injected(){} // RVA: 0x7FFE87DF8C40
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7FFE87DF8CB0
        public void SetTile_Injected(){} // RVA: 0x7FFE87DF8D30
        public void RefreshTile_Injected(){} // RVA: 0x7FFE87DF8DA0
        public void GetSprite_Injected(){} // RVA: 0x7FFE87DF8E00
        public void GetTransformMatrix_Injected(){} // RVA: 0x7FFE87DF8E60
        public void SetTransformMatrix_Injected(){} // RVA: 0x7FFE87DF8ED0
        public void GetColor_Injected(){} // RVA: 0x7FFE87DF8F40
        public void SetColor_Injected(){} // RVA: 0x7FFE87DF8FB0
        public void GetTileFlags_Injected(){} // RVA: 0x7FFE87DF9020
        public void SetTileFlags_Injected(){} // RVA: 0x7FFE87DF9080
        public void AddTileFlags_Injected(){} // RVA: 0x7FFE87DF90F0
        public void RemoveTileFlags_Injected(){} // RVA: 0x7FFE87DF9160
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7FFE87DF91D0
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7FFE87DF9230
        public void SetColliderType_Injected(){} // RVA: 0x7FFE87DF9290
        public void GetColliderType_Injected(){} // RVA: 0x7FFE87DF9300
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7FFE87DF9360
        public void GetAnimationFrame_Injected(){} // RVA: 0x7FFE87DF93C0
        public void SetAnimationFrame_Injected(){} // RVA: 0x7FFE87DF9420
        public void GetAnimationTime_Injected(){} // RVA: 0x7FFE87DF9490
        public void SetAnimationTime_Injected(){} // RVA: 0x7FFE87DF94F0
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7FFE87DF9560
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7FFE87DF95C0
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7FFE87DF9630
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7FFE87DF96A0
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7FFE87DF9710
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7FFE87DF9780
        public void InsertCells_Injected(){} // RVA: 0x7FFE87DF9810
        public void DeleteCells_Injected(){} // RVA: 0x7FFE87DF98A0
    }

    public class TilemapRenderer : Renderer
    {
        // ── Methods ──
        public void get_chunkSize(){} // RVA: 0x7FFE87DF9930
        public void set_chunkSize(){} // RVA: 0x7FFE87DF99A0
        public void get_chunkCullingBounds(){} // RVA: 0x7FFE87DF9A00
        public void set_chunkCullingBounds(){} // RVA: 0x7FFE87DF9A70
        public void get_maxChunkCount(){} // RVA: 0x7FFE87DF9AD0
        public void set_maxChunkCount(){} // RVA: 0x7FFE87DF9B20
        public void get_maxFrameAge(){} // RVA: 0x7FFE87DF9B80
        public void set_maxFrameAge(){} // RVA: 0x7FFE87DF9BD0
        public void get_sortOrder(){} // RVA: 0x7FFE87DF9C30
        public void set_sortOrder(){} // RVA: 0x7FFE87DF9C80
        public void get_mode(){} // RVA: 0x7FFE87DF9CE0
        public void set_mode(){} // RVA: 0x7FFE87DF9D30
        public void get_detectChunkCullingBounds(){} // RVA: 0x7FFE87DF9D90
        public void set_detectChunkCullingBounds(){} // RVA: 0x7FFE87DF9DE0
        public void get_maskInteraction(){} // RVA: 0x7FFE87DF9E40
        public void set_maskInteraction(){} // RVA: 0x7FFE87DF9E90
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7FFE87DF9EF0
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7FFE87DF9F70
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7FFE87DFA100
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_chunkSize_Injected(){} // RVA: 0x7FFE87DFA160
        public void set_chunkSize_Injected(){} // RVA: 0x7FFE87DFA1C0
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7FFE87DFA220
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7FFE87DFA280
    }

}