// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 9
// Methods: 211

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap : Object
    {
        public object m_AddToList; // 0x32E73D00

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void RefreshTile(){} // RVA: 0x7ffaaf46dc20
        public void CreateInstance(){} // RVA: 0x7ffaaf46de90
        public void FindAllRefreshPositions(){} // RVA: 0x7ffaaf46df40
        // ── Binary Analysis Named ──
        public void GetAllTileData(){} // RVA: 0x7ffaaf46e300
    }

    public class Tile : TileBase
    {
        public object m_Transform; // 0x32EA81F0
        public object m_ColliderType; // 0x32EA81F0

        // ── Original Methods ──
        public void get_sprite(){} // RVA: 0x7ffaab2aab40
        public void set_sprite(){} // RVA: 0x7ffaa8998e80
        public void get_color(){} // RVA: 0x7ffaaf46e580
        public void set_color(){} // RVA: 0x7ffaadd91ec0
        public void get_transform(){} // RVA: 0x7ffaaf46e590
        public void set_transform(){} // RVA: 0x7ffaaf46e5c0
        public void get_gameObject(){} // RVA: 0x7ffaaf341a60
        public void set_gameObject(){} // RVA: 0x7ffaa89fa5a0
        public void get_flags(){} // RVA: 0x7ffaaf46e5e0
        public void set_flags(){} // RVA: 0x7ffaa9fb1a60
        public void get_colliderType(){} // RVA: 0x7ffaaf46e5f0
        public void set_colliderType(){} // RVA: 0x7ffaae401520
        public void .ctor(){} // RVA: 0x7ffaaf46e6b0
        // ── Binary Analysis Named ──
        public void GetTileData(){} // RVA: 0x7ffaaf46e600
    }

    public class TileAnimationData : ValueType
    {
        public object m_AnimationStartTime; // 0x32EA8910
    }

    public class TileBase : ScriptableObject
    {
        // ── Original Methods ──
        public void RefreshTile(){} // RVA: 0x7ffaaf46e740
        public void StartUp(){} // RVA: 0x7ffaaac0a810
        public void StartUpRef(){} // RVA: 0x7ffaaf46e930
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetTileData(){} // RVA: 0x7ffaa8932310
        public void GetTileDataNoRef(){} // RVA: 0x7ffaaf46e780
        public void GetTileAnimationData(){} // RVA: 0x7ffaaac0a810
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7ffaaf46e860
        public void GetTileAnimationDataRef(){} // RVA: 0x7ffaaf46e8f0
    }

    public class TileChangeData : ValueType
    {
        public object m_Color; // 0x32EA8D40
    }

    public class TileData : ValueType
    {
        public object m_Transform; // 0x32EA8EC0
        public object m_ColliderType; // 0x32EA8EC0

        // ── Original Methods ──
        public void set_sprite(){} // RVA: 0x7ffaaf4739a0
        public void set_color(){} // RVA: 0x7ffaaf175450
        public void set_transform(){} // RVA: 0x7ffaaf473a90
        public void set_gameObject(){} // RVA: 0x7ffaaf473ab0
        public void set_flags(){} // RVA: 0x7ffaa905bde0
        public void set_colliderType(){} // RVA: 0x7ffaa905bdd0
        public void CreateDefault(){} // RVA: 0x7ffaaf473ba0
        public void .cctor(){} // RVA: 0x7ffaaf473ce0
    }

    public class TileDataNative : ValueType
    {
        public object m_Transform; // 0x32EA9040
        public object m_ColliderType; // 0x32EA9040
    }

    public class Tilemap : GridLayout
    {
        public object m_BufferSyncTile; // 0x318C33A0
        public object ("00; // 0x318C33A0

        // ── Original Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7ffaaf46e970
        public void remove_tilemapTileChanged(){} // RVA: 0x7ffaaf46eaa0
        public void add_tilemapPositionsChanged(){} // RVA: 0x7ffaaf46ebd0
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7ffaaf46ed10
        public void get_bufferSyncTile(){} // RVA: 0x7ffaaf24ace0
        public void set_bufferSyncTile(){} // RVA: 0x7ffaaf46ee50
        public void HasSyncTileCallback(){} // RVA: 0x7ffaaf46eef0
        public void HasPositionsChangedCallback(){} // RVA: 0x7ffaaf46ef30
        public void HandleSyncTileCallback(){} // RVA: 0x7ffaaf46ef70
        public void HandlePositionsChangedCallback(){} // RVA: 0x7ffaaf46efd0
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7ffaaf46f070
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7ffaaf46f120
        public void RemoveSyncTileCallback(){} // RVA: 0x7ffaaf46eaa0
        public void get_layoutGrid(){} // RVA: 0x7ffaaf46f1d0
        public void get_cellBounds(){} // RVA: 0x7ffaaf46f5c0
        public void get_localBounds(){} // RVA: 0x7ffaaf46f6d0
        public void get_localFrameBounds(){} // RVA: 0x7ffaaf46f740
        public void get_animationFrameRate(){} // RVA: 0x7ffaaf46f7b0
        public void set_animationFrameRate(){} // RVA: 0x7ffaaf46f800
        public void get_color(){} // RVA: 0x7ffaaf46f860
        public void set_color(){} // RVA: 0x7ffaaf46f8d0
        public void get_origin(){} // RVA: 0x7ffaaf46f930
        public void set_origin(){} // RVA: 0x7ffaaf46f9a0
        public void get_size(){} // RVA: 0x7ffaaf46fa00
        public void set_size(){} // RVA: 0x7ffaaf46fa70
        public void get_tileAnchor(){} // RVA: 0x7ffaaf46fad0
        public void set_tileAnchor(){} // RVA: 0x7ffaaf46fb40
        public void get_orientation(){} // RVA: 0x7ffaaf46fba0
        public void set_orientation(){} // RVA: 0x7ffaaf46fbf0
        public void get_orientationMatrix(){} // RVA: 0x7ffaaf46fc50
        public void set_orientationMatrix(){} // RVA: 0x7ffaaf46fcd0
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7ffaaf4705a0
        public void HasTile(){} // RVA: 0x7ffaaf4707e0
        public void RefreshTile(){} // RVA: 0x7ffaaf470920
        public void RefreshTilesNative(){} // RVA: 0x7ffaaf470980
        public void RefreshAllTiles(){} // RVA: 0x7ffaaf4709f0
        public void SwapTileAsset(){} // RVA: 0x7ffaaf470a40
        public void SwapTile(){} // RVA: 0x7ffaaf470a40
        public void ContainsTileAsset(){} // RVA: 0x7ffaaf470ab0
        public void ContainsTile(){} // RVA: 0x7ffaaf470ab0
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7ffaaf470bb0
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7ffaaf470c10
        public void AddTileFlags(){} // RVA: 0x7ffaaf470f90
        public void RemoveTileFlags(){} // RVA: 0x7ffaaf471000
        public void AddTileAnimationFlags(){} // RVA: 0x7ffaaf4714d0
        public void RemoveTileAnimationFlags(){} // RVA: 0x7ffaaf471540
        public void FloodFill(){} // RVA: 0x7ffaaf4715b0
        public void FloodFillTileAsset(){} // RVA: 0x7ffaaf471630
        public void BoxFill(){} // RVA: 0x7ffaaf4716a0
        public void BoxFillTileAsset(){} // RVA: 0x7ffaaf471750
        public void InsertCells(){} // RVA: 0x7ffaaf471890
        public void InsertCells(){} // RVA: 0x7ffaaf471890
        public void DeleteCells(){} // RVA: 0x7ffaaf4719c0
        public void DeleteCells(){} // RVA: 0x7ffaaf4719c0
        public void ClearAllTiles(){} // RVA: 0x7ffaaf471a50
        public void ResizeBounds(){} // RVA: 0x7ffaaf471aa0
        public void CompressBounds(){} // RVA: 0x7ffaaf471af0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7ffaaf471be0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_localBounds_Injected(){} // RVA: 0x7ffaaf471c30
        public void get_localFrameBounds_Injected(){} // RVA: 0x7ffaaf471c90
        public void get_color_Injected(){} // RVA: 0x7ffaaf471cf0
        public void set_color_Injected(){} // RVA: 0x7ffaaf471d50
        public void get_origin_Injected(){} // RVA: 0x7ffaaf471db0
        public void set_origin_Injected(){} // RVA: 0x7ffaaf471e10
        public void get_size_Injected(){} // RVA: 0x7ffaaf471e70
        public void set_size_Injected(){} // RVA: 0x7ffaaf471ed0
        public void get_tileAnchor_Injected(){} // RVA: 0x7ffaaf471f30
        public void set_tileAnchor_Injected(){} // RVA: 0x7ffaaf471f90
        public void get_orientationMatrix_Injected(){} // RVA: 0x7ffaaf471ff0
        public void set_orientationMatrix_Injected(){} // RVA: 0x7ffaaf472050
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7ffaaf472370
        public void RefreshTile_Injected(){} // RVA: 0x7ffaaf472460
        public void AddTileFlags_Injected(){} // RVA: 0x7ffaaf4727b0
        public void RemoveTileFlags_Injected(){} // RVA: 0x7ffaaf472820
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7ffaaf472cf0
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7ffaaf472d60
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7ffaaf472dd0
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7ffaaf472e40
        public void InsertCells_Injected(){} // RVA: 0x7ffaaf472ed0
        public void DeleteCells_Injected(){} // RVA: 0x7ffaaf472f60
        // ── Binary Analysis Named ──
        public void SetSyncTileCallback(){} // RVA: 0x7ffaaf46e970
        public void GetCellCenterLocal(){} // RVA: 0x7ffaaf46f220
        public void GetCellCenterWorld(){} // RVA: 0x7ffaaf46f3c0
        public void GetTileAsset(){} // RVA: 0x7ffaaf46fd30
        public void GetTile(){} // RVA: 0x7ffaa887e5c0
        public void GetTile(){} // RVA: 0x7ffaa887e5c0
        public void GetTileAssetsBlock(){} // RVA: 0x7ffaaf46fe70
        public void GetTilesBlock(){} // RVA: 0x7ffaaf46fee0
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7ffaaf470140
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7ffaaf4701c0
        public void GetTilesRangeCount(){} // RVA: 0x7ffaaf4702a0
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7ffaaf470310
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7ffaaf4703a0
        public void SetTileAsset(){} // RVA: 0x7ffaaf470440
        public void SetTile(){} // RVA: 0x7ffaaf470700
        public void SetTileAssets(){} // RVA: 0x7ffaaf470530
        public void SetTiles(){} // RVA: 0x7ffaaf470770
        public void SetTilesBlock(){} // RVA: 0x7ffaaf470620
        public void SetTile(){} // RVA: 0x7ffaaf470700
        public void SetTiles(){} // RVA: 0x7ffaaf470770
        public void GetUsedTilesCount(){} // RVA: 0x7ffaaf470b10
        public void GetUsedSpritesCount(){} // RVA: 0x7ffaaf470b60
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7ffaaf470bb0
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7ffaaf470c10
        public void GetSprite(){} // RVA: 0x7ffaaf470c70
        public void GetTransformMatrix(){} // RVA: 0x7ffaaf470cd0
        public void SetTransformMatrix(){} // RVA: 0x7ffaaf470d60
        public void GetColor(){} // RVA: 0x7ffaaf470dd0
        public void SetColor(){} // RVA: 0x7ffaaf470e50
        public void GetTileFlags(){} // RVA: 0x7ffaaf470ec0
        public void SetTileFlags(){} // RVA: 0x7ffaaf470f20
        public void GetInstantiatedObject(){} // RVA: 0x7ffaaf471070
        public void GetObjectToInstantiate(){} // RVA: 0x7ffaaf4710d0
        public void SetColliderType(){} // RVA: 0x7ffaaf471130
        public void GetColliderType(){} // RVA: 0x7ffaaf4711a0
        public void GetAnimationFrameCount(){} // RVA: 0x7ffaaf471200
        public void GetAnimationFrame(){} // RVA: 0x7ffaaf471260
        public void SetAnimationFrame(){} // RVA: 0x7ffaaf4712c0
        public void GetAnimationTime(){} // RVA: 0x7ffaaf471330
        public void SetAnimationTime(){} // RVA: 0x7ffaaf471390
        public void GetTileAnimationFlags(){} // RVA: 0x7ffaaf471400
        public void SetTileAnimationFlags(){} // RVA: 0x7ffaaf471460
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7ffaaf471b40
        public void DoSyncTileCallback(){} // RVA: 0x7ffaaf46ef70
        public void DoPositionsChangedCallback(){} // RVA: 0x7ffaaf46efd0
        public void GetTileAsset_Injected(){} // RVA: 0x7ffaaf4720b0
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7ffaaf472110
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7ffaaf472180
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7ffaaf472200
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7ffaaf472270
        public void SetTileAsset_Injected(){} // RVA: 0x7ffaaf472300
        public void SetTile_Injected(){} // RVA: 0x7ffaaf4723f0
        public void GetSprite_Injected(){} // RVA: 0x7ffaaf4724c0
        public void GetTransformMatrix_Injected(){} // RVA: 0x7ffaaf472520
        public void SetTransformMatrix_Injected(){} // RVA: 0x7ffaaf472590
        public void GetColor_Injected(){} // RVA: 0x7ffaaf472600
        public void SetColor_Injected(){} // RVA: 0x7ffaaf472670
        public void GetTileFlags_Injected(){} // RVA: 0x7ffaaf4726e0
        public void SetTileFlags_Injected(){} // RVA: 0x7ffaaf472740
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7ffaaf472890
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7ffaaf4728f0
        public void SetColliderType_Injected(){} // RVA: 0x7ffaaf472950
        public void GetColliderType_Injected(){} // RVA: 0x7ffaaf4729c0
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7ffaaf472a20
        public void GetAnimationFrame_Injected(){} // RVA: 0x7ffaaf472a80
        public void SetAnimationFrame_Injected(){} // RVA: 0x7ffaaf472ae0
        public void GetAnimationTime_Injected(){} // RVA: 0x7ffaaf472b50
        public void SetAnimationTime_Injected(){} // RVA: 0x7ffaaf472bb0
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7ffaaf472c20
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7ffaaf472c80
    }

    public class TilemapRenderer : Renderer
    {
        // ── Original Methods ──
        public void get_chunkSize(){} // RVA: 0x7ffaaf472ff0
        public void set_chunkSize(){} // RVA: 0x7ffaaf473060
        public void get_chunkCullingBounds(){} // RVA: 0x7ffaaf4730c0
        public void set_chunkCullingBounds(){} // RVA: 0x7ffaaf473130
        public void get_maxChunkCount(){} // RVA: 0x7ffaaf473190
        public void set_maxChunkCount(){} // RVA: 0x7ffaaf4731e0
        public void get_maxFrameAge(){} // RVA: 0x7ffaaf473240
        public void set_maxFrameAge(){} // RVA: 0x7ffaaf473290
        public void get_sortOrder(){} // RVA: 0x7ffaaf4732f0
        public void set_sortOrder(){} // RVA: 0x7ffaaf473340
        public void get_mode(){} // RVA: 0x7ffaaf4733a0
        public void set_mode(){} // RVA: 0x7ffaaf4733f0
        public void get_detectChunkCullingBounds(){} // RVA: 0x7ffaaf473450
        public void set_detectChunkCullingBounds(){} // RVA: 0x7ffaaf4734a0
        public void get_maskInteraction(){} // RVA: 0x7ffaaf473500
        public void set_maskInteraction(){} // RVA: 0x7ffaaf473550
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7ffaaf4735b0
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7ffaaf473630
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7ffaaf4737c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_chunkSize_Injected(){} // RVA: 0x7ffaaf473820
        public void set_chunkSize_Injected(){} // RVA: 0x7ffaaf473880
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7ffaaf4738e0
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7ffaaf473940
    }

}