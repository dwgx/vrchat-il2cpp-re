// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 93
// Methods: 169

public class UpdateMainGameViewRect : ValueType
{
}

public class UpdateMasterServerInterface : ValueType
{
}

public class UpdateNetworkManager : ValueType
{
}

public class UpdateOrderComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC9E9F2B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class UpdatePreloading : ValueType
{
}

public class UpdateReceivers : ValueType
{
    public Unity.Collections.NativeList`1<int> activeReceivers; // 0x10
    public Unity.Collections.NativeArray`1<ReceiverData> receivers; // 0x18
    public Unity.Collections.NativeArray`1<ShapeData> shapes; // 0x28
    public float deltaTime; // 0x38

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9E257C0
}

public class UpdateReceiversFunctions : Object
{
    // ── Methods ──
    public void CalcProximity(){} // RVA: 0x7FFAC9E25A10
    public void CalcProximity$BurstManaged(){} // RVA: 0x7FFAC9E25A80
}

public class UpdateRectTransform : ValueType
{
}

public class UpdateResolution : ValueType
{
}

public class UpdateRichPresenceCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class UpdateRootsJob : ValueType
{
    public int MAX_EXECUTIONS;
    public float realTime; // 0x10
    public float fixedTime; // 0x14
    public Unity.Collections.NativeArray`1<ChainRoot> roots; // 0x18
    public int FIXED_TIME_COUNTER_MAX;

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9E4E320
    public void CalculateShouldUseFixedTime(){} // RVA: 0x7FFAC9E4E470
}

public class UpdateShapePositionsJob : ValueType
{
    public int SHAPE_BATCH_COUNT;
    public Unity.Collections.NativeList`1<ushort> activeShapes; // 0x10
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x18
    public Unity.Collections.NativeArray`1<UnityEngine.Jobs.TransformAccess> transformData; // 0x28
    public Unity.Collections.NativeArray`1<int> transformLookup; // 0x38

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9DFD650
    public void GetTransform(){} // RVA: 0x7FFAC9DFD900
    public void .cctor(){} // RVA: 0x7FFAC9DFD940
}

public class UpdateShapesJob : ValueType
{
    public Unity.Collections.NativeQueue`1<int> shapesToUpdate; // 0x10
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x18
    public Unity.Collections.NativeParallelMultiHashMap`2<UnityEngine.Vector3Int,int> shapeMap; // 0x28

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9DF1530
    public void RemoveShape(){} // RVA: 0x7FFAC9DF1CD0 | overloaded x2
    public void AddShape(){} // RVA: 0x7FFAC9DF1ED0 | overloaded x2
}

public class UpdateStatus : Object
{
    public int lastUpdateFrame; // 0x10
    public int lastUpdateFixedFrame; // 0x14
    public 0x6B22B788 lastUpdateMode; // 0x18
    public float lastUpdateDeltaTime; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class UpdateStepCount : ValueType
{
    public bool value; // 0x10
    public uint <value>k__BackingField; // 0x14

    // ── Methods ──
    public void get_value(){} // RVA: 0x7FFAC44202A0
    public void set_value(){} // RVA: 0x7FFAC4420230
    public void OnBeforeUpdate(){} // RVA: 0x7FFAC967DA10
    public void OnUpdate(){} // RVA: 0x7FFAC967DA20
}

public class UpdateStreamingManager : ValueType
{
}

public class UpdateSubstance : ValueType
{
}

public class UpdateTextureStreamingManager : ValueType
{
}

public class UpdateTokenCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class UpdateVideo : ValueType
{
}

public class UpdateVideoTextures : ValueType
{
}

public class UpdatedEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class UpdaterArray : Object
{
    public UnityEngine.UIElements.IVisualTreeUpdater[] Item; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9AC91F0
    public void set_Item(){} // RVA: 0x7FFAC9AC9280
    public void get_Item(){} // RVA: 0x7FFAC926F060 | overloaded x2
}

public class UploadStatus : ApiModel
{
    public System.Collections.Generic.List`1<string> etags; // 0x68
    public double nextPartNumber; // 0x70
    public double maxParts; // 0x78
    public System.Collections.Generic.List`1<object> parts; // 0x80
    public string uploadId; // 0x88
    public string fileName; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBE76070 | overloaded x2
    public void get_etags(){} // RVA: 0x7FFAC2F9CD50
    public void set_etags(){} // RVA: 0x7FFAC2F9CD60
    public void get_nextPartNumber(){} // RVA: 0x7FFAC8B78440
    public void set_nextPartNumber(){} // RVA: 0x7FFAC8B78450
    public void get_maxParts(){} // RVA: 0x7FFAC4870390
    public void set_maxParts(){} // RVA: 0x7FFAC48703A0
    public void get_parts(){} // RVA: 0x7FFAC32EF410
    public void set_parts(){} // RVA: 0x7FFAC34D4AA0
    public void get_uploadId(){} // RVA: 0x7FFAC2F60010
    public void set_uploadId(){} // RVA: 0x7FFAC354E300
    public void get_fileName(){} // RVA: 0x7FFAC32EF640
    public void set_fileName(){} // RVA: 0x7FFAC354E360
}

public class Uri : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFAC8FB1490
}

public class UriInfo : Object
{
    public string Host; // 0x10
    public string ScopeId; // 0x18
    public string String; // 0x20
    public Offset Offset; // 0x28
    public string DnsSafeHost; // 0x38
    public MoreInfo MoreInfo; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class UrlDecoder : Object
{
    public int _bufferSize; // 0x10
    public int _numChars; // 0x14
    public char[] _charBuffer; // 0x18
    public int _numBytes; // 0x20
    public byte[] _byteBuffer; // 0x28
    public System.Text.Encoding _encoding; // 0x30

    // ── Methods ──
    public void FlushBytes(){} // RVA: 0x7FFAC92C0EE0
    public void .ctor(){} // RVA: 0x7FFAC92C0F50
    public void AddChar(){} // RVA: 0x7FFAC92C1060
    public void AddByte(){} // RVA: 0x7FFAC92C10C0
    public void GetString(){} // RVA: 0x7FFAC92C1190
}

public class User32 : Object
{
    // ── Methods ──
    public void LoadString(){} // RVA: 0x7FFAC838A500
}

public class UserController : ScriptableObject
{
    public bool testSteamAccount; // 0x18

    // ── Methods ──
    public void BackPressed(){} // RVA: 0x7FFAC39B4E30
    public void CreateInstance(){} // RVA: 0x7FFAC426DD60
    public void Equals(){} // RVA: 0x7FFAC426DF40
    public void CreateScriptableObject(){} // RVA: 0x7FFAC426DFE0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC426E080
    public void GetHashCode(){} // RVA: 0x7FFAC426E120
    public void ToString(){} // RVA: 0x7FFAC426E1C0
    public void GetGameObject_C12(){} // RVA: 0x7FFAC426E260
    public void .ctor(){} // RVA: 0x7FFAC312F5F0
    public void Initialize(){} // RVA: 0x7FFAC426E300
    public void GetGameObject_A97(){} // RVA: 0x7FFAC426E390
    public void SetActive_448(){} // RVA: 0x7FFAC426E430
}

public class UserData : ValueType
{
    public System.Nullable`1<UnityEngine.InputSystem.Users.InputUserAccountHandle> platformUserAccountHandle; // 0x10
    public string platformUserAccountName; // 0x28
    public string platformUserAccountId; // 0x30
    public int deviceCount; // 0x38
    public int deviceStartIndex; // 0x3C
    public UnityEngine.InputSystem.IInputActionCollection actions; // 0x40
    public System.Nullable`1<UnityEngine.InputSystem.InputControlScheme> controlScheme; // 0x48
    public MatchResult controlSchemeMatch; // 0x68
    public int lostDeviceCount; // 0xB8
    public int lostDeviceStartIndex; // 0xBC
    public 0x6B14A610 flags; // 0xC0
}

public class UserDefinedSettings : ValueType
{
    public ushort stereoRenderingMode; // 0x10
    public ushort initializationType; // 0x12
    public ushort mirrorViewMode; // 0x14
    public string editorAppKey; // 0x18
    public string actionManifestPath; // 0x20
    public string applicationName; // 0x28
}

public class UserFetchParameters : Object
{
    public string Endpoint; // 0x10
    public System.Collections.Generic.Dictionary`2<string,Token> Parameters; // 0x18

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0x7FFAC2F3C380
    public void set_Endpoint(){} // RVA: 0x7FFAC2F22E30
    public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
    public void set_Parameters(){} // RVA: 0x7FFAC2F87E80
    public void .ctor(){} // RVA: 0x7FFACBEEA7F0
}

public class UserFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class UserHandle : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Drop(){} // RVA: 0x7FFAC4976780
    public void DisplayName(){} // RVA: 0x7FFAC4976800
    public void Id(){} // RVA: 0x7FFAC4976890
    public void Status(){} // RVA: 0x7FFAC4976910
}

public class UserId : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368D60
}

public class UserUpdatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class Users : Object
{
    // ── Methods ──
    public void GetLinkedAccounts(){} // RVA: 0x7FFAC8873730
}

public class UsingEntry : ValueType
{
    public System.Collections.Generic.IComparer`1<UsingEntry> comparer;
    public string alias; // 0x10
    public string path; // 0x18
    public UnityEngine.UIElements.VisualTreeAsset asset; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC96F5DB0
    public void .cctor(){} // RVA: 0x7FFAC9ABB280
}

public class UsingEntryComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC9ABB330
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Utf8MessageState : Object
{
    public bool SequenceInProgress; // 0x10
    public int AdditionalBytesExpected; // 0x14
    public int ExpectedValueMin; // 0x18
    public int CurrentDecodeBits; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Utils : Object
{
    // ── Methods ──
    public void SwitchToRectTransform(){} // RVA: 0x7FFAC49AC690
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9BF1380
}

public class UxmlObjectEntry : ValueType
{
    public int parentId; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC60F24C0
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;
    public UnityEngine.UIElements.UxmlBoolAttributeDescription m_Visible;
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_Width;
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_MinWidth;
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_MaxWidth;
    public UnityEngine.UIElements.UxmlBoolAttributeDescription m_Stretch;
    public UnityEngine.UIElements.UxmlBoolAttributeDescription m_Sortable;
    public UnityEngine.UIElements.UxmlBoolAttributeDescription m_Optional;
    public UnityEngine.UIElements.UxmlBoolAttributeDescription m_Resizable;
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_HeaderTemplateId;
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_CellTemplateId;

    // ── Methods ──
    public void ParseLength(){} // RVA: 0x7FFAC2E8DC40
    public void Init(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class UxmlTraits : UxmlTraits
{
    public UnityEngine.UIElements.UxmlStringAttributeDescription m_Label; // 0x78

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6E5E2C0
    public void Init(){} // RVA: 0x7FFAC6E5E440
    public void ParseChoiceList(){} // RVA: 0x7FFAC6E5E5D0
}

public class unitytls_errorstate : ValueType
{
    public uint magic; // 0x10
    public 0x6B12B240 code; // 0x14
    public ulong reserved; // 0x18
}

public class unitytls_errorstate_create_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556BD00
    public void Invoke(){} // RVA: 0x7FFAC556BDD0
}

public class unitytls_errorstate_raise_error_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DE20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_interface_struct : Object
{
    public ulong UNITYTLS_INVALID_HANDLE; // 0x10
    public unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
    public unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
    public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
    public unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
    public unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
    public unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
    public unitytls_key_free_t unitytls_key_free; // 0x48
    public unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
    public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
    public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
    public unitytls_x509list_create_t unitytls_x509list_create; // 0x68
    public unitytls_x509list_append_t unitytls_x509list_append; // 0x70
    public unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
    public unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
    public unitytls_x509list_free_t unitytls_x509list_free; // 0x88
    public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
    public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
    public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
    public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
    public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
    public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
    public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
    public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
    public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
    public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
    public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
    public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
    public unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
    public unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
    public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
    public unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
    public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class unitytls_key : ValueType
{
}

public class unitytls_key_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class unitytls_key_get_ref_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897B360
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_key_parse_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19C50
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
}

public class unitytls_key_parse_pem_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19C50
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
}

public class unitytls_key_ref : ValueType
{
    public ulong handle; // 0x10
}

public class unitytls_random_generate_bytes_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3C20CE0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class unitytls_tlsctx : ValueType
{
}

public class unitytls_tlsctx_callbacks : ValueType
{
    public unitytls_tlsctx_read_callback read; // 0x10
    public unitytls_tlsctx_write_callback write; // 0x18
    public void* data; // 0x20
}

public class unitytls_tlsctx_certificate_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19A90
    public void Invoke(){} // RVA: 0x7FFAC5CC1E10
}

public class unitytls_tlsctx_create_client_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E1A150
    public void Invoke(){} // RVA: 0x7FFAC8E1A220
}

public class unitytls_tlsctx_create_server_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E1A150
    public void Invoke(){} // RVA: 0x7FFAC8E1A220
}

public class unitytls_tlsctx_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8973170
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_tlsctx_get_protocol_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8973170
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_tlsctx_notify_close_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_tlsctx_process_handshake_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8973170
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_tlsctx_protocolrange : ValueType
{
    public 0x6B12B660 min; // 0x10
    public 0x6B12B660 max; // 0x14
}

public class unitytls_tlsctx_read_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8370B30
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_read_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8370B30
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19ED0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897C450
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897C450
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897C450
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897C450
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_trace_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897C450
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_write_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8370B30
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_write_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8370B30
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_tlsctx_x509verify_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19B70
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class unitytls_x509_export_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19D30
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_x509_ref : ValueType
{
    public ulong handle; // 0x10
}

public class unitytls_x509list : ValueType
{
}

public class unitytls_x509list_append_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897C450
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_x509list_append_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19ED0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class unitytls_x509list_create_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class unitytls_x509list_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class unitytls_x509list_get_ref_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC897B360
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class unitytls_x509list_get_x509_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19E00
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class unitytls_x509list_ref : ValueType
{
    public ulong handle; // 0x10
}

public class unitytls_x509name : ValueType
{
}

public class unitytls_x509verify_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E199B0
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class unitytls_x509verify_default_ca_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E19FB0
    public void Invoke(){} // RVA: 0x7FFAC5CC1930
}

public class unitytls_x509verify_explicit_ca_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E1A080
    public void Invoke(){} // RVA: 0x7FFAC5CC1AD0
}
