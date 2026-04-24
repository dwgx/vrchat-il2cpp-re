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
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void RefreshTile(){} // RVA: 0x7FFD54E6BCC0
        public void CreateInstance(){} // RVA: 0x7FFD54E6BF30
        public void FindAllRefreshPositions(){} // RVA: 0x7FFD54E6BFE0
        public void GetAllTileData(){} // RVA: 0x7FFD54E6C3A0
    }

    public class Tile : TileBase
    {
        public UnityEngine.Sprite sprite; // 0x18
        public UnityEngine.Color color; // 0x20
        public UnityEngine.Matrix4x4 transform; // 0x30
        public UnityEngine.GameObject gameObject; // 0x70
        public ÍÍÎÏÎÏÏ flags; // 0x78
        public 0x6662EBB0 colliderType; // 0x7C

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFD50CC1130
        public void set_sprite(){} // RVA: 0x7FFD4E3A7E80
        public void get_color(){} // RVA: 0x7FFD54E6C620
        public void set_color(){} // RVA: 0x7FFD53790D10
        public void get_transform(){} // RVA: 0x7FFD54E6C630
        public void set_transform(){} // RVA: 0x7FFD54E6C660
        public void get_gameObject(){} // RVA: 0x7FFD54D3FB00
        public void set_gameObject(){} // RVA: 0x7FFD4E4095A0
        public void get_flags(){} // RVA: 0x7FFD54E6C680
        public void set_flags(){} // RVA: 0x7FFD4F9B63A0
        public void get_colliderType(){} // RVA: 0x7FFD54E6C690
        public void set_colliderType(){} // RVA: 0x7FFD53E00310
        public void GetTileData(){} // RVA: 0x7FFD54E6C6A0
        public void .ctor(){} // RVA: 0x7FFD54E6C750
    }

    public class TileAnimationData : ValueType
    {
        public UnityEngine.Sprite[] m_AnimatedSprites; // 0x10
        public float m_AnimationSpeed; // 0x18
        public float m_AnimationStartTime; // 0x1C
        public 0x6662EE70 m_Flags; // 0x20
    }

    public class TileBase : ScriptableObject
    {
        // ── Methods ──
        public void RefreshTile(){} // RVA: 0x7FFD54E6C7E0
        public void GetTileData(){} // RVA: 0x7FFD4E341310
        public void GetTileDataNoRef(){} // RVA: 0x7FFD54E6C820
        public void GetTileAnimationData(){} // RVA: 0x7FFD506288B0
        public void GetTileAnimationDataNoRef(){} // RVA: 0x7FFD54E6C900
        public void GetTileAnimationDataRef(){} // RVA: 0x7FFD54E6C990
        public void StartUp(){} // RVA: 0x7FFD506288B0
        public void StartUpRef(){} // RVA: 0x7FFD54E6C9D0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
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
        public ÍÍÎÏÎÏÏ flags; // 0x68
        public 0x6662EBB0 colliderType; // 0x6C
        public UnityEngine.Tilemaps.TileData Default;

        // ── Methods ──
        public void set_sprite(){} // RVA: 0x7FFD54E71A40
        public void set_color(){} // RVA: 0x7FFD54B73470
        public void set_transform(){} // RVA: 0x7FFD54E71B30
        public void set_gameObject(){} // RVA: 0x7FFD54E71B50
        public void set_flags(){} // RVA: 0x7FFD4EA4EA00
        public void set_colliderType(){} // RVA: 0x7FFD4EA4EB40
        public void CreateDefault(){} // RVA: 0x7FFD54E71C40
        public void .cctor(){} // RVA: 0x7FFD54E71D80
    }

    public class TileDataNative : ValueType
    {
        public int m_Sprite; // 0x10
        public UnityEngine.Color m_Color; // 0x14
        public UnityEngine.Matrix4x4 m_Transform; // 0x24
        public int m_GameObject; // 0x64
        public ÍÍÎÏÎÏÏ m_Flags; // 0x68
        public 0x6662EBB0 m_ColliderType; // 0x6C
    }

    public class Tilemap : GridLayout
    {
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,SyncTile[]> bufferSyncTile;
        public System.Action`2<UnityEngine.Tilemaps.Tilemap,Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>> layoutGrid; // 0x8
        public bool cellBounds; // 0x18

        // ── Methods ──
        public void add_tilemapTileChanged(){} // RVA: 0x7FFD54E6CA10
        public void remove_tilemapTileChanged(){} // RVA: 0x7FFD54E6CB40
        public void add_tilemapPositionsChanged(){} // RVA: 0x7FFD54E6CC70
        public void remove_tilemapPositionsChanged(){} // RVA: 0x7FFD54E6CDB0
        public void get_bufferSyncTile(){} // RVA: 0x7FFD54C48D80
        public void set_bufferSyncTile(){} // RVA: 0x7FFD54E6CEF0
        public void HasSyncTileCallback(){} // RVA: 0x7FFD54E6CF90
        public void HasPositionsChangedCallback(){} // RVA: 0x7FFD54E6CFD0
        public void HandleSyncTileCallback(){} // RVA: 0x7FFD54E6D010
        public void HandlePositionsChangedCallback(){} // RVA: 0x7FFD54E6D070
        public void SendTilemapTileChangedCallback(){} // RVA: 0x7FFD54E6D110
        public void SendTilemapPositionsChangedCallback(){} // RVA: 0x7FFD54E6D1C0
        public void SetSyncTileCallback(){} // RVA: 0x7FFD54E6CA10
        public void RemoveSyncTileCallback(){} // RVA: 0x7FFD54E6CB40
        public void get_layoutGrid(){} // RVA: 0x7FFD54E6D270
        public void GetCellCenterLocal(){} // RVA: 0x7FFD54E6D2C0
        public void GetCellCenterWorld(){} // RVA: 0x7FFD54E6D460
        public void get_cellBounds(){} // RVA: 0x7FFD54E6D660
        public void get_localBounds(){} // RVA: 0x7FFD54E6D770
        public void get_localFrameBounds(){} // RVA: 0x7FFD54E6D7E0
        public void get_animationFrameRate(){} // RVA: 0x7FFD54E6D850
        public void set_animationFrameRate(){} // RVA: 0x7FFD54E6D8A0
        public void get_color(){} // RVA: 0x7FFD54E6D900
        public void set_color(){} // RVA: 0x7FFD54E6D970
        public void get_origin(){} // RVA: 0x7FFD54E6D9D0
        public void set_origin(){} // RVA: 0x7FFD54E6DA40
        public void get_size(){} // RVA: 0x7FFD54E6DAA0
        public void set_size(){} // RVA: 0x7FFD54E6DB10
        public void get_tileAnchor(){} // RVA: 0x7FFD54E6DB70
        public void set_tileAnchor(){} // RVA: 0x7FFD54E6DBE0
        public void get_orientation(){} // RVA: 0x7FFD54E6DC40
        public void set_orientation(){} // RVA: 0x7FFD54E6DC90
        public void get_orientationMatrix(){} // RVA: 0x7FFD54E6DCF0
        public void set_orientationMatrix(){} // RVA: 0x7FFD54E6DD70
        public void GetTileAsset(){} // RVA: 0x7FFD54E6DDD0
        public void GetTile(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetTileAssetsBlock(){} // RVA: 0x7FFD54E6DF10
        public void GetTilesBlock(){} // RVA: 0x7FFD54E6DF80
        public void GetTileAssetsBlockNonAlloc(){} // RVA: 0x7FFD54E6E1E0
        public void GetTilesBlockNonAlloc(){} // RVA: 0x7FFD54E6E260
        public void GetTilesRangeCount(){} // RVA: 0x7FFD54E6E340
        public void GetTileAssetsRangeNonAlloc(){} // RVA: 0x7FFD54E6E3B0
        public void GetTilesRangeNonAlloc(){} // RVA: 0x7FFD54E6E440
        public void SetTileAsset(){} // RVA: 0x7FFD54E6E4E0
        public void SetTile(){} // RVA: 0x7FFD54E6E7A0 | overloaded x2
        public void SetTileAssets(){} // RVA: 0x7FFD54E6E5D0
        public void SetTiles(){} // RVA: 0x7FFD54E6E810 | overloaded x2
        public void INTERNAL_CALL_SetTileAssetsBlock(){} // RVA: 0x7FFD54E6E640
        public void SetTilesBlock(){} // RVA: 0x7FFD54E6E6C0
        public void HasTile(){} // RVA: 0x7FFD54E6E880
        public void RefreshTile(){} // RVA: 0x7FFD54E6E9C0
        public void RefreshTilesNative(){} // RVA: 0x7FFD54E6EA20
        public void RefreshAllTiles(){} // RVA: 0x7FFD54E6EA90
        public void SwapTileAsset(){} // RVA: 0x7FFD54E6EAE0
        public void SwapTile(){} // RVA: 0x7FFD54E6EAE0
        public void ContainsTileAsset(){} // RVA: 0x7FFD54E6EB50
        public void ContainsTile(){} // RVA: 0x7FFD54E6EB50
        public void GetUsedTilesCount(){} // RVA: 0x7FFD54E6EBB0
        public void GetUsedSpritesCount(){} // RVA: 0x7FFD54E6EC00
        public void GetUsedTilesNonAlloc(){} // RVA: 0x7FFD54E6EC50
        public void GetUsedSpritesNonAlloc(){} // RVA: 0x7FFD54E6ECB0
        public void Internal_GetUsedTilesNonAlloc(){} // RVA: 0x7FFD54E6EC50
        public void Internal_GetUsedSpritesNonAlloc(){} // RVA: 0x7FFD54E6ECB0
        public void GetSprite(){} // RVA: 0x7FFD54E6ED10
        public void GetTransformMatrix(){} // RVA: 0x7FFD54E6ED70
        public void SetTransformMatrix(){} // RVA: 0x7FFD54E6EE00
        public void GetColor(){} // RVA: 0x7FFD54E6EE70
        public void SetColor(){} // RVA: 0x7FFD54E6EEF0
        public void GetTileFlags(){} // RVA: 0x7FFD54E6EF60
        public void SetTileFlags(){} // RVA: 0x7FFD54E6EFC0
        public void AddTileFlags(){} // RVA: 0x7FFD54E6F030
        public void RemoveTileFlags(){} // RVA: 0x7FFD54E6F0A0
        public void GetInstantiatedObject(){} // RVA: 0x7FFD54E6F110
        public void GetObjectToInstantiate(){} // RVA: 0x7FFD54E6F170
        public void SetColliderType(){} // RVA: 0x7FFD54E6F1D0
        public void GetColliderType(){} // RVA: 0x7FFD54E6F240
        public void GetAnimationFrameCount(){} // RVA: 0x7FFD54E6F2A0
        public void GetAnimationFrame(){} // RVA: 0x7FFD54E6F300
        public void SetAnimationFrame(){} // RVA: 0x7FFD54E6F360
        public void GetAnimationTime(){} // RVA: 0x7FFD54E6F3D0
        public void SetAnimationTime(){} // RVA: 0x7FFD54E6F430
        public void GetTileAnimationFlags(){} // RVA: 0x7FFD54E6F4A0
        public void SetTileAnimationFlags(){} // RVA: 0x7FFD54E6F500
        public void AddTileAnimationFlags(){} // RVA: 0x7FFD54E6F570
        public void RemoveTileAnimationFlags(){} // RVA: 0x7FFD54E6F5E0
        public void FloodFill(){} // RVA: 0x7FFD54E6F650
        public void FloodFillTileAsset(){} // RVA: 0x7FFD54E6F6D0
        public void BoxFill(){} // RVA: 0x7FFD54E6F740
        public void BoxFillTileAsset(){} // RVA: 0x7FFD54E6F7F0
        public void InsertCells(){} // RVA: 0x7FFD54E6F930 | overloaded x2
        public void DeleteCells(){} // RVA: 0x7FFD54E6FA60 | overloaded x2
        public void ClearAllTiles(){} // RVA: 0x7FFD54E6FAF0
        public void ResizeBounds(){} // RVA: 0x7FFD54E6FB40
        public void CompressBounds(){} // RVA: 0x7FFD54E6FB90
        public void GetSyncTileCallbackSettings(){} // RVA: 0x7FFD54E6FBE0
        public void SendAndClearSyncTileBuffer(){} // RVA: 0x7FFD54E6FC80
        public void DoSyncTileCallback(){} // RVA: 0x7FFD54E6D010
        public void DoPositionsChangedCallback(){} // RVA: 0x7FFD54E6D070
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_localBounds_Injected(){} // RVA: 0x7FFD54E6FCD0
        public void get_localFrameBounds_Injected(){} // RVA: 0x7FFD54E6FD30
        public void get_color_Injected(){} // RVA: 0x7FFD54E6FD90
        public void set_color_Injected(){} // RVA: 0x7FFD54E6FDF0
        public void get_origin_Injected(){} // RVA: 0x7FFD54E6FE50
        public void set_origin_Injected(){} // RVA: 0x7FFD54E6FEB0
        public void get_size_Injected(){} // RVA: 0x7FFD54E6FF10
        public void set_size_Injected(){} // RVA: 0x7FFD54E6FF70
        public void get_tileAnchor_Injected(){} // RVA: 0x7FFD54E6FFD0
        public void set_tileAnchor_Injected(){} // RVA: 0x7FFD54E70030
        public void get_orientationMatrix_Injected(){} // RVA: 0x7FFD54E70090
        public void set_orientationMatrix_Injected(){} // RVA: 0x7FFD54E700F0
        public void GetTileAsset_Injected(){} // RVA: 0x7FFD54E70150
        public void GetTileAssetsBlock_Injected(){} // RVA: 0x7FFD54E701B0
        public void GetTileAssetsBlockNonAlloc_Injected(){} // RVA: 0x7FFD54E70220
        public void GetTilesRangeCount_Injected(){} // RVA: 0x7FFD54E702A0
        public void GetTileAssetsRangeNonAlloc_Injected(){} // RVA: 0x7FFD54E70310
        public void SetTileAsset_Injected(){} // RVA: 0x7FFD54E703A0
        public void INTERNAL_CALL_SetTileAssetsBlock_Injected(){} // RVA: 0x7FFD54E70410
        public void SetTile_Injected(){} // RVA: 0x7FFD54E70490
        public void RefreshTile_Injected(){} // RVA: 0x7FFD54E70500
        public void GetSprite_Injected(){} // RVA: 0x7FFD54E70560
        public void GetTransformMatrix_Injected(){} // RVA: 0x7FFD54E705C0
        public void SetTransformMatrix_Injected(){} // RVA: 0x7FFD54E70630
        public void GetColor_Injected(){} // RVA: 0x7FFD54E706A0
        public void SetColor_Injected(){} // RVA: 0x7FFD54E70710
        public void GetTileFlags_Injected(){} // RVA: 0x7FFD54E70780
        public void SetTileFlags_Injected(){} // RVA: 0x7FFD54E707E0
        public void AddTileFlags_Injected(){} // RVA: 0x7FFD54E70850
        public void RemoveTileFlags_Injected(){} // RVA: 0x7FFD54E708C0
        public void GetInstantiatedObject_Injected(){} // RVA: 0x7FFD54E70930
        public void GetObjectToInstantiate_Injected(){} // RVA: 0x7FFD54E70990
        public void SetColliderType_Injected(){} // RVA: 0x7FFD54E709F0
        public void GetColliderType_Injected(){} // RVA: 0x7FFD54E70A60
        public void GetAnimationFrameCount_Injected(){} // RVA: 0x7FFD54E70AC0
        public void GetAnimationFrame_Injected(){} // RVA: 0x7FFD54E70B20
        public void SetAnimationFrame_Injected(){} // RVA: 0x7FFD54E70B80
        public void GetAnimationTime_Injected(){} // RVA: 0x7FFD54E70BF0
        public void SetAnimationTime_Injected(){} // RVA: 0x7FFD54E70C50
        public void GetTileAnimationFlags_Injected(){} // RVA: 0x7FFD54E70CC0
        public void SetTileAnimationFlags_Injected(){} // RVA: 0x7FFD54E70D20
        public void AddTileAnimationFlags_Injected(){} // RVA: 0x7FFD54E70D90
        public void RemoveTileAnimationFlags_Injected(){} // RVA: 0x7FFD54E70E00
        public void FloodFillTileAsset_Injected(){} // RVA: 0x7FFD54E70E70
        public void BoxFillTileAsset_Injected(){} // RVA: 0x7FFD54E70EE0
        public void InsertCells_Injected(){} // RVA: 0x7FFD54E70F70
        public void DeleteCells_Injected(){} // RVA: 0x7FFD54E71000
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
        public void get_chunkSize(){} // RVA: 0x7FFD54E71090
        public void set_chunkSize(){} // RVA: 0x7FFD54E71100
        public void get_chunkCullingBounds(){} // RVA: 0x7FFD54E71160
        public void set_chunkCullingBounds(){} // RVA: 0x7FFD54E711D0
        public void get_maxChunkCount(){} // RVA: 0x7FFD54E71230
        public void set_maxChunkCount(){} // RVA: 0x7FFD54E71280
        public void get_maxFrameAge(){} // RVA: 0x7FFD54E712E0
        public void set_maxFrameAge(){} // RVA: 0x7FFD54E71330
        public void get_sortOrder(){} // RVA: 0x7FFD54E71390
        public void set_sortOrder(){} // RVA: 0x7FFD54E713E0
        public void get_mode(){} // RVA: 0x7FFD54E71440
        public void set_mode(){} // RVA: 0x7FFD54E71490
        public void get_detectChunkCullingBounds(){} // RVA: 0x7FFD54E714F0
        public void set_detectChunkCullingBounds(){} // RVA: 0x7FFD54E71540
        public void get_maskInteraction(){} // RVA: 0x7FFD54E715A0
        public void set_maskInteraction(){} // RVA: 0x7FFD54E715F0
        public void RegisterSpriteAtlasRegistered(){} // RVA: 0x7FFD54E71650
        public void UnregisterSpriteAtlasRegistered(){} // RVA: 0x7FFD54E716D0
        public void OnSpriteAtlasRegistered(){} // RVA: 0x7FFD54E71860
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_chunkSize_Injected(){} // RVA: 0x7FFD54E718C0
        public void set_chunkSize_Injected(){} // RVA: 0x7FFD54E71920
        public void get_chunkCullingBounds_Injected(){} // RVA: 0x7FFD54E71980
        public void set_chunkCullingBounds_Injected(){} // RVA: 0x7FFD54E719E0
    }

}