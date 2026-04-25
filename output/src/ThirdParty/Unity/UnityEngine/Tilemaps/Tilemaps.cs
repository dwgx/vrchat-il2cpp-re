// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Tilemaps
// Classes: 9
// Methods: 211

namespace ThirdParty.Unity.UnityEngine.Tilemaps
{
    public class ITilemap : Object
    {
        public UnityEngine.Tilemaps.ITilemap s_Instance;
        public UnityEngine.Tilemaps.Tilemap m_Tilemap; // 0x10
        public bool m_AddToList; // 0x18
        public int m_RefreshCount; // 0x1C
        public Unity.Collections.NativeArray`1<UnityEngine.Vector3Int> m_RefreshPos; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void RefreshTile(){} // RVA: 0x7FFAC9A4BCC0
        public void CreateInstance(){} // RVA: 0x7FFAC9A4BF30
        public void FindAllRefreshPositions(){} // RVA: 0x7FFAC9A4BFE0
        public void GetAllTileData(){} // RVA: 0x7FFAC9A4C3A0
    }

    public class Tile : TileBase
    {
        public UnityEngine.Sprite sprite; // 0x18
        public UnityEngine.Color color; // 0x20
        public UnityEngine.Matrix4x4 transform; // 0x30
        public UnityEngine.GameObject gameObject; // 0x70
        public 0x6B2CEE18 flags; // 0x78
        public 0x6B2CEBB0 colliderType; // 0x7C

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFAC58A1130
        public void set_sprite(){} // RVA: 0x7FFAC2F87E80
        public void get_color(){} // RVA: 0x7FFAC9A4C620
        public void set_color(){} // RVA: 0x7FFAC8370D10
        public void get_transform(){} // RVA: 0x7FFAC9A4C630
        public void set_transform(){} // RVA: 0x7FFAC9A4C660
        public void get_gameObject(){} // RVA: 0x7FFAC991FB00
        public void set_gameObject(){} // RVA: 0x7FFAC2FE95A0
        public void get_flags(){} // RVA: 0x7FFAC9A4C680
        public void set_flags(){} // RVA: 0x7FFAC45963A0
        public void get_colliderType(){} // RVA: 0x7FFAC9A4C690
        public void set_colliderType(){} // RVA: 0x7FFAC89E0310
        public void GetTileData(){} // RVA: 0x7FFAC9A4C6A0
        public void .ctor(){} // RVA: 0x7FFAC9A4C750
    }

    public class TileAnimationData : ValueType
    {
        public UnityEngine.Sprite[] m_AnimatedSprites; // 0x10
        public float m_AnimationSpeed; // 0x18
        public float m_AnimationStartTime; // 0x1C
        public 0x6B2CEE70 m_Flags; // 0x20
    }

    public class TileBase : ScriptableObject
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x7FFAC9A4C7E0
        public void GetTileData(){} // RVA: 0x7FFAC2F21310
        public void GetTileDataNoRef(){} // RVA: 0x7FFAC9A4C820
        public void GetTileAnimationData(){} // RVA: 0x7FFAC52088B0
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7FFAC9A4C900
        public void GetTileAnimationDataRef(){} // RVA: 0x7FFAC9A4C990
        public void StartUp(){} // RVA: 0x7FFAC52088B0
        public void StartUpRef(){} // RVA: 0x7FFAC9A4C9D0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class TileChangeData : ValueType
    {
        public UnityEngine.Vector3Int m_Position; // 0x10
        public UnityEngine.Object m_TileAsset; // 0x20
        public UnityEngine.Color m_Color; // 0x28
        public UnityEngine.Matrix4x4 m_Transform; // 0x38
    }

    public class TileData : ValueType
    {
        public int sprite; // 0x10
        public UnityEngine.Color color; // 0x14
        public UnityEngine.Matrix4x4 transform; // 0x24
        public int gameObject; // 0x64
        public 0x6B2CEE18 flags; // 0x68
        public 0x6B2CEBB0 colliderType; // 0x6C
        public UnityEngine.Tilemaps.TileData Default;

        // ── Methods ──
        public void set_sprite(){} // RVA: 0x7FFAC9A51A40
        public void set_color(){} // RVA: 0x7FFAC9753470
        public void set_transform(){} // RVA: 0x7FFAC9A51B30
        public void set_gameObject(){} // RVA: 0x7FFAC9A51B50
        public void set_flags(){} // RVA: 0x7FFAC362EA00
        public void set_colliderType(){} // RVA: 0x7FFAC362EB40
        public void CreateDefault(){} // RVA: 0x7FFAC9A51C40
        public void .cctor(){} // RVA: 0x7FFAC9A51D80
    }

    public class TileDataNative : ValueType
    {
        public int m_Sprite; // 0x10
        public UnityEngine.Color m_Color; // 0x14
        public UnityEngine.Matrix4x4 m_Transform; // 0x24
        public int m_GameObject; // 0x64
        public 0x6B2CEE18 m_Flags; // 0x68
        public 0x6B2CEBB0 m_ColliderType; // 0x6C
    }

    public class Tilemap : GridLayout
    {
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,SyncTile[]> bufferSyncTile;
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>> layoutGrid; // 0x8
        public bool cellBounds; // 0x18

        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7FFAC9A4CA10
        public void remove_tilemapTileChanged(){} // RVA: 0x7FFAC9A4CB40
        public void add_tilemapPositionsChanged(){} // RVA: 0x7FFAC9A4CC70
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7FFAC9A4CDB0
        public void get_bufferSyncTile(){} // RVA: 0x7FFAC9828D80
        public void set_bufferSyncTile(){} // RVA: 0x7FFAC9A4CEF0
        public void HasSyncTileCallback(){} // RVA: 0x7FFAC9A4CF90
        public void HasPositionsChangedCallback(){} // RVA: 0x7FFAC9A4CFD0
        public void HandleSyncTileCallback(){} // RVA: 0x7FFAC9A4D010
        public void HandlePositionsChangedCallback(){} // RVA: 0x7FFAC9A4D070
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7FFAC9A4D110
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7FFAC9A4D1C0
        public void SetSyncTileCallback(){} // RVA: 0x7FFAC9A4CA10
        public void RemoveSyncTileCallback(){} // RVA: 0x7FFAC9A4CB40
        public void get_layoutGrid(){} // RVA: 0x7FFAC9A4D270
        public void GetCellCenterLocal(){} // RVA: 0x7FFAC9A4D2C0
        public void GetCellCenterWorld(){} // RVA: 0x7FFAC9A4D460
        public void get_cellBounds(){} // RVA: 0x7FFAC9A4D660
        public void get_localBounds(){} // RVA: 0x7FFAC9A4D770
        public void get_localFrameBounds(){} // RVA: 0x7FFAC9A4D7E0
        public void get_animationFrameRate(){} // RVA: 0x7FFAC9A4D850
        public void set_animationFrameRate(){} // RVA: 0x7FFAC9A4D8A0
        public void get_color(){} // RVA: 0x7FFAC9A4D900
        public void set_color(){} // RVA: 0x7FFAC9A4D970
        public void get_origin(){} // RVA: 0x7FFAC9A4D9D0
        public void set_origin(){} // RVA: 0x7FFAC9A4DA40
        public void get_size(){} // RVA: 0x7FFAC9A4DAA0
        public void set_size(){} // RVA: 0x7FFAC9A4DB10
        public void get_tileAnchor(){} // RVA: 0x7FFAC9A4DB70
        public void set_tileAnchor(){} // RVA: 0x7FFAC9A4DBE0
        public void get_orientation(){} // RVA: 0x7FFAC9A4DC40
        public void set_orientation(){} // RVA: 0x7FFAC9A4DC90
        public void get_orientationMatrix(){} // RVA: 0x7FFAC9A4DCF0
        public void set_orientationMatrix(){} // RVA: 0x7FFAC9A4DD70
        public void GetTileAsset(){} // RVA: 0x7FFAC9A4DDD0
        public void GetTile(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetTileAssetsBlock(){} // RVA: 0x7FFAC9A4DF10
        public void GetTilesBlock(){} // RVA: 0x7FFAC9A4DF80
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7FFAC9A4E1E0
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7FFAC9A4E260
        public void GetTilesRangeCount(){} // RVA: 0x7FFAC9A4E340
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7FFAC9A4E3B0
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7FFAC9A4E440
        public void SetTileAsset(){} // RVA: 0x7FFAC9A4E4E0
        public void SetTile(){} // RVA: 0x7FFAC9A4E7A0 | overloaded x2
        public void SetTileAssets(){} // RVA: 0x7FFAC9A4E5D0
        public void SetTiles(){} // RVA: 0x7FFAC9A4E810 | overloaded x2
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7FFAC9A4E640
        public void SetTilesBlock(){} // RVA: 0x7FFAC9A4E6C0
        public void HasTile(){} // RVA: 0x7FFAC9A4E880
        public void RefreshTile(){} // RVA: 0x7FFAC9A4E9C0
        public void RefreshTilesNative(){} // RVA: 0x7FFAC9A4EA20
        public void RefreshAllTiles(){} // RVA: 0x7FFAC9A4EA90
        public void SwapTileAsset(){} // RVA: 0x7FFAC9A4EAE0
        public void SwapTile(){} // RVA: 0x7FFAC9A4EAE0
        public void ContainsTileAsset(){} // RVA: 0x7FFAC9A4EB50
        public void ContainsTile(){} // RVA: 0x7FFAC9A4EB50
        public void GetUsedTilesCount(){} // RVA: 0x7FFAC9A4EBB0
        public void GetUsedSpritesCount(){} // RVA: 0x7FFAC9A4EC00
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7FFAC9A4EC50
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7FFAC9A4ECB0
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7FFAC9A4EC50
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7FFAC9A4ECB0
        public void GetSprite(){} // RVA: 0x7FFAC9A4ED10
        public void GetTransformMatrix(){} // RVA: 0x7FFAC9A4ED70
        public void SetTransformMatrix(){} // RVA: 0x7FFAC9A4EE00
        public void GetColor(){} // RVA: 0x7FFAC9A4EE70
        public void SetColor(){} // RVA: 0x7FFAC9A4EEF0
        public void GetTileFlags(){} // RVA: 0x7FFAC9A4EF60
        public void SetTileFlags(){} // RVA: 0x7FFAC9A4EFC0
        public void AddTileFlags(){} // RVA: 0x7FFAC9A4F030
        public void RemoveTileFlags(){} // RVA: 0x7FFAC9A4F0A0
        public void GetInstantiatedObject(){} // RVA: 0x7FFAC9A4F110
        public void GetObjectToInstantiate(){} // RVA: 0x7FFAC9A4F170
        public void SetColliderType(){} // RVA: 0x7FFAC9A4F1D0
        public void GetColliderType(){} // RVA: 0x7FFAC9A4F240
        public void GetAnimationFrameCount(){} // RVA: 0x7FFAC9A4F2A0
        public void GetAnimationFrame(){} // RVA: 0x7FFAC9A4F300
        public void SetAnimationFrame(){} // RVA: 0x7FFAC9A4F360
        public void GetAnimationTime(){} // RVA: 0x7FFAC9A4F3D0
        public void SetAnimationTime(){} // RVA: 0x7FFAC9A4F430
        public void GetTileAnimationFlags(){} // RVA: 0x7FFAC9A4F4A0
        public void SetTileAnimationFlags(){} // RVA: 0x7FFAC9A4F500
        public void AddTileAnimationFlags(){} // RVA: 0x7FFAC9A4F570
        public void RemoveTileAnimationFlags(){} // RVA: 0x7FFAC9A4F5E0
        public void FloodFill(){} // RVA: 0x7FFAC9A4F650
        public void FloodFillTileAsset(){} // RVA: 0x7FFAC9A4F6D0
        public void BoxFill(){} // RVA: 0x7FFAC9A4F740
        public void BoxFillTileAsset(){} // RVA: 0x7FFAC9A4F7F0
        public void InsertCells(){} // RVA: 0x7FFAC9A4F930 | overloaded x2
        public void DeleteCells(){} // RVA: 0x7FFAC9A4FA60 | overloaded x2
        public void ClearAllTiles(){} // RVA: 0x7FFAC9A4FAF0
        public void ResizeBounds(){} // RVA: 0x7FFAC9A4FB40
        public void CompressBounds(){} // RVA: 0x7FFAC9A4FB90
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7FFAC9A4FBE0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7FFAC9A4FC80
        public void DoSyncTileCallback(){} // RVA: 0x7FFAC9A4D010
        public void DoPositionsChangedCallback(){} // RVA: 0x7FFAC9A4D070
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_localBounds_Injected(){} // RVA: 0x7FFAC9A4FCD0
        public void get_localFrameBounds_Injected(){} // RVA: 0x7FFAC9A4FD30
        public void get_color_Injected(){} // RVA: 0x7FFAC9A4FD90
        public void set_color_Injected(){} // RVA: 0x7FFAC9A4FDF0
        public void get_origin_Injected(){} // RVA: 0x7FFAC9A4FE50
        public void set_origin_Injected(){} // RVA: 0x7FFAC9A4FEB0
        public void get_size_Injected(){} // RVA: 0x7FFAC9A4FF10
        public void set_size_Injected(){} // RVA: 0x7FFAC9A4FF70
        public void get_tileAnchor_Injected(){} // RVA: 0x7FFAC9A4FFD0
        public void set_tileAnchor_Injected(){} // RVA: 0x7FFAC9A50030
        public void get_orientationMatrix_Injected(){} // RVA: 0x7FFAC9A50090
        public void set_orientationMatrix_Injected(){} // RVA: 0x7FFAC9A500F0
        public void GetTileAsset_Injected(){} // RVA: 0x7FFAC9A50150
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7FFAC9A501B0
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7FFAC9A50220
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7FFAC9A502A0
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7FFAC9A50310
        public void SetTileAsset_Injected(){} // RVA: 0x7FFAC9A503A0
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7FFAC9A50410
        public void SetTile_Injected(){} // RVA: 0x7FFAC9A50490
        public void RefreshTile_Injected(){} // RVA: 0x7FFAC9A50500
        public void GetSprite_Injected(){} // RVA: 0x7FFAC9A50560
        public void GetTransformMatrix_Injected(){} // RVA: 0x7FFAC9A505C0
        public void SetTransformMatrix_Injected(){} // RVA: 0x7FFAC9A50630
        public void GetColor_Injected(){} // RVA: 0x7FFAC9A506A0
        public void SetColor_Injected(){} // RVA: 0x7FFAC9A50710
        public void GetTileFlags_Injected(){} // RVA: 0x7FFAC9A50780
        public void SetTileFlags_Injected(){} // RVA: 0x7FFAC9A507E0
        public void AddTileFlags_Injected(){} // RVA: 0x7FFAC9A50850
        public void RemoveTileFlags_Injected(){} // RVA: 0x7FFAC9A508C0
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7FFAC9A50930
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7FFAC9A50990
        public void SetColliderType_Injected(){} // RVA: 0x7FFAC9A509F0
        public void GetColliderType_Injected(){} // RVA: 0x7FFAC9A50A60
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7FFAC9A50AC0
        public void GetAnimationFrame_Injected(){} // RVA: 0x7FFAC9A50B20
        public void SetAnimationFrame_Injected(){} // RVA: 0x7FFAC9A50B80
        public void GetAnimationTime_Injected(){} // RVA: 0x7FFAC9A50BF0
        public void SetAnimationTime_Injected(){} // RVA: 0x7FFAC9A50C50
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7FFAC9A50CC0
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7FFAC9A50D20
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7FFAC9A50D90
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7FFAC9A50E00
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7FFAC9A50E70
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7FFAC9A50EE0
        public void InsertCells_Injected(){} // RVA: 0x7FFAC9A50F70
        public void DeleteCells_Injected(){} // RVA: 0x7FFAC9A51000
    }

    public class TilemapRenderer : Renderer
    {
        public object chunkSize;
        public object chunkCullingBounds;
        public object maxChunkCount;
        public object maxFrameAge;
        public object sortOrder;
        public object mode;
        public object detectChunkCullingBounds;
        public object maskInteraction;

        // ── Methods ──
        public void get_chunkSize(){} // RVA: 0x7FFAC9A51090
        public void set_chunkSize(){} // RVA: 0x7FFAC9A51100
        public void get_chunkCullingBounds(){} // RVA: 0x7FFAC9A51160
        public void set_chunkCullingBounds(){} // RVA: 0x7FFAC9A511D0
        public void get_maxChunkCount(){} // RVA: 0x7FFAC9A51230
        public void set_maxChunkCount(){} // RVA: 0x7FFAC9A51280
        public void get_maxFrameAge(){} // RVA: 0x7FFAC9A512E0
        public void set_maxFrameAge(){} // RVA: 0x7FFAC9A51330
        public void get_sortOrder(){} // RVA: 0x7FFAC9A51390
        public void set_sortOrder(){} // RVA: 0x7FFAC9A513E0
        public void get_mode(){} // RVA: 0x7FFAC9A51440
        public void set_mode(){} // RVA: 0x7FFAC9A51490
        public void get_detectChunkCullingBounds(){} // RVA: 0x7FFAC9A514F0
        public void set_detectChunkCullingBounds(){} // RVA: 0x7FFAC9A51540
        public void get_maskInteraction(){} // RVA: 0x7FFAC9A515A0
        public void set_maskInteraction(){} // RVA: 0x7FFAC9A515F0
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7FFAC9A51650
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7FFAC9A516D0
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7FFAC9A51860
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_chunkSize_Injected(){} // RVA: 0x7FFAC9A518C0
        public void set_chunkSize_Injected(){} // RVA: 0x7FFAC9A51920
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7FFAC9A51980
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7FFAC9A519E0
    }

}