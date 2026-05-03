// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 92
// Methods: 171

public class UpdateMasterServerInterface : ValueType
{
}

public class UpdateNetworkManager : ValueType
{
}

public class UpdateOrderComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE88251D70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class UpdatePreloading : ValueType
{
}

public class UpdateReceivers : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE881D2CE0
}

public class UpdateReceiversFunctions : Object
{
    // ── Methods ──
    public void CalcProximity(){} // RVA: 0x7FFE881D2F30
    public void CalcProximity$BurstManaged(){} // RVA: 0x7FFE881D2FA0
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
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class UpdateRootsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE881FEE00
    public void CalculateShouldUseFixedTime(){} // RVA: 0x7FFE881FEF50
}

public class UpdateShapePositionsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE881A7310
    public void GetTransform(){} // RVA: 0x7FFE881A75F0
    public void .cctor(){} // RVA: 0x7FFE881A7630
}

public class UpdateShapesJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE88199D80
    public void RemoveShape(){} // RVA: 0x7FFE8819A590 | overloaded x2
    public void AddShape(){} // RVA: 0x7FFE8819A790 | overloaded x2
}

public class UpdateStatus : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class UpdateStepCount : ValueType
{
    public bool m_WasUpdated; // 0x10

    // ── Methods ──
    public void get_value(){} // RVA: 0x7FFE826F42A0
    public void set_value(){} // RVA: 0x7FFE826F4290
    public void OnBeforeUpdate(){} // RVA: 0x7FFE87A26170
    public void OnUpdate(){} // RVA: 0x7FFE87A26180
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
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
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
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class UpdaterArray : Object
{
    public UnityEngine.UIElements.IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10
    public object field_1; // 0x5B2

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87E71A90
    public void set_Item(){} // RVA: 0x7FFE87E71B20
    public void get_Item(){} // RVA: 0x7FFE876177D0 | overloaded x2
}

public class UploadStatus : ApiModel
{
    public System.Collections.Generic.List`1<string> _etags; // 0x68
    public double _nextPartNumber; // 0x70
    public double _maxParts; // 0x78
    public System.Collections.Generic.List`1<object> _parts; // 0x80
    public string _uploadId; // 0x88
    public string _fileName; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A2D5020 | overloaded x2
    public void get_etags(){} // RVA: 0x7FFE81176D50
    public void set_etags(){} // RVA: 0x7FFE81176D60
    public void get_nextPartNumber(){} // RVA: 0x7FFE86F21AC0
    public void set_nextPartNumber(){} // RVA: 0x7FFE86F21AD0
    public void get_maxParts(){} // RVA: 0x7FFE82AD8710
    public void set_maxParts(){} // RVA: 0x7FFE82AD8720
    public void get_parts(){} // RVA: 0x7FFE81280C30
    public void set_parts(){} // RVA: 0x7FFE81282380
    public void get_uploadId(){} // RVA: 0x7FFE8113A010
    public void set_uploadId(){} // RVA: 0x7FFE81280F90
    public void get_fileName(){} // RVA: 0x7FFE8154EB60
    public void set_fileName(){} // RVA: 0x7FFE818CE320
}

public class Uri : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFE873598B0
}

public class UriInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class UrlDecoder : Object
{
    // ── Methods ──
    public void FlushBytes(){} // RVA: 0x7FFE87669620
    public void .ctor(){} // RVA: 0x7FFE87669690
    public void AddChar(){} // RVA: 0x7FFE876697A0
    public void AddByte(){} // RVA: 0x7FFE87669800
    public void GetString(){} // RVA: 0x7FFE876698D0
}

public class User32 : Object
{
    // ── Methods ──
    public void LoadString(){} // RVA: 0x7FFE86733E00
}

public class UserController : ScriptableObject
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE82524130
    public void CreateInstance(){} // RVA: 0x7FFE825241C0
    public void GetHashCode(){} // RVA: 0x7FFE82524250
    public void CreateScriptableObject(){} // RVA: 0x7FFE825242F0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFE82523D40
    public void ToString(){} // RVA: 0x7FFE82524380
    public void ToString_95FCB8B0C731(){} // RVA: 0x7FFE82524460
    public void GetGameObject_E1B(){} // RVA: 0x7FFE825245A0
    public void .ctor_E0A790D8356B(){} // RVA: 0x7FFE82524680
    public void .ctor(){} // RVA: 0x7FFE81345B60
    public void Initialize(){} // RVA: 0x7FFE82523D40
    public void GetTouch(){} // RVA: 0x7FFE82524710
    public void CheckAndProcessSystemStatus(){} // RVA: 0x7FFE81B0FF50
    // ── Unresolved (hash) ──
    public void m_BC5(){} // RVA: 0x7FFE81B0FF50
}

public class UserData : ValueType
{
}

public class UserDefinedSettings : ValueType
{
}

public class UserFetchParameters : Object
{
    public string _endpoint; // 0x10
    public System.Collections.Generic.Dictionary`2<string,Token> _parameters; // 0x18

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0x7FFE81116380
    public void set_Endpoint(){} // RVA: 0x7FFE810FCE30
    public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
    public void set_Parameters(){} // RVA: 0x7FFE81161E80
    public void .ctor(){} // RVA: 0x7FFE8A349890
}

public class UserFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class UserHandle : ValueType
{
    // ── Methods ──
    public void Drop(){} // RVA: 0x7FFE82BE2280
    public void DisplayName(){} // RVA: 0x7FFE82BE2300
    public void Id(){} // RVA: 0x7FFE82BE2390
    public void Status(){} // RVA: 0x7FFE82BE2410
}

public class UserId : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712660
}

public class UserUpdatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9AD0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class Users : Object
{
    // ── Methods ──
    public void GetLinkedAccounts(){} // RVA: 0x7FFE86C1CE20
}

public class UsingEntry : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87A9E320
    public void .cctor(){} // RVA: 0x7FFE87E63B20
}

public class UsingEntryComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE87E63BD0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Utf8MessageState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Utils : Object
{
    // ── Methods ──
    public void SwitchToRectTransform(){} // RVA: 0x7FFE82C18190
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87F4D120
}

public class UxmlObjectEntry : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE844576B0
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    // ── Methods ──
    public void ParseLength(){} // RVA: 0x7FFE810A1420
    public void Init(){}
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class UxmlTraits : UxmlTraits
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE851E9C00
    public void Init(){} // RVA: 0x7FFE851E9D80
    public void ParseChoiceList(){} // RVA: 0x7FFE851E9F10
}

public class unitytls_errorstate : ValueType
{
}

public class unitytls_errorstate_create_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83870F80
    public void Invoke(){} // RVA: 0x7FFE83871050
}

public class unitytls_errorstate_raise_error_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9920
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_interface_struct : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class unitytls_key : ValueType
{
}

public class unitytls_key_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class unitytls_key_get_ref_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D249F0
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_key_parse_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2080
    public void Invoke(){} // RVA: 0x7FFE83F99C10
}

public class unitytls_key_parse_pem_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2080
    public void Invoke(){} // RVA: 0x7FFE83F99C10
}

public class unitytls_key_ref : ValueType
{
}

public class unitytls_random_generate_bytes_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81EE8AB0
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class unitytls_tlsctx : ValueType
{
}

public class unitytls_tlsctx_callbacks : ValueType
{
}

public class unitytls_tlsctx_certificate_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C1EC0
    public void Invoke(){} // RVA: 0x7FFE84020340
}

public class unitytls_tlsctx_create_client_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2580
    public void Invoke(){} // RVA: 0x7FFE871C2650
}

public class unitytls_tlsctx_create_server_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2580
    public void Invoke(){} // RVA: 0x7FFE871C2650
}

public class unitytls_tlsctx_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D1C800
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_tlsctx_get_protocol_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D1C800
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_tlsctx_notify_close_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_tlsctx_process_handshake_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D1C800
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_tlsctx_protocolrange : ValueType
{
}

public class unitytls_tlsctx_read_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8671A430
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_read_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8671A430
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2300
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D25AE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D25AE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D25AE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D25AE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_trace_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D25AE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_write_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8671A430
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_write_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8671A430
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_tlsctx_x509verify_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C1FA0
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class unitytls_x509_export_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2160
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_x509_ref : ValueType
{
}

public class unitytls_x509list : ValueType
{
}

public class unitytls_x509list_append_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D25AE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_x509list_append_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2300
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class unitytls_x509list_create_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8526B7D0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class unitytls_x509list_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class unitytls_x509list_get_ref_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D249F0
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class unitytls_x509list_get_x509_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C2230
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class unitytls_x509list_ref : ValueType
{
}

public class unitytls_x509name : ValueType
{
}

public class unitytls_x509verify_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C1DE0
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class unitytls_x509verify_default_ca_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C23E0
    public void Invoke(){} // RVA: 0x7FFE8401FE60
}

public class unitytls_x509verify_explicit_ca_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871C24B0
    public void Invoke(){} // RVA: 0x7FFE84020000
}
