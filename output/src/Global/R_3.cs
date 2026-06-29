// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 69
// Methods: 366

public class RBTreeEnumerator : ValueType
{
    public object _tree;
    public object _version;
    public object _index;
    public object _mainTreeNodeId;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899290
    public void Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x894290
}

public class RBTreeEnumerator : ValueType
{
    public object _tree;
    public object _version;
    public object _index;
    public object _mainTreeNodeId;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x485BA0
}

public class RBTreeEnumerator : ValueType
{
    public object _tree;
    public object _version;
    public object _index;
    public object _mainTreeNodeId;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x485A40
}

public class REG_TZI_FORMAT : ValueType
{
    public object Bias;
    public object StandardBias;
    public object DaylightBias;
    public object StandardDate;
    public object DaylightDate;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8AAFD0
}

public class RaiseMessageToAll : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class RaiseMessageToPlayer : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xCA8B20
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x828CFF0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Range : ValueType
{
    public object Pointer;
    public object Items;
    public object Allocator;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x924120
}

public class Raycast2DCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x81073A0
    public void Invoke(){} // RVA: 0x8107470
    public void BeginInvoke(){} // RVA: 0x81074D0
    public void EndInvoke(){} // RVA: 0x81075A0
}

public class Raycast3DCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8106E60
    public void Invoke(){} // RVA: 0x8106F30
    public void BeginInvoke(){} // RVA: 0x8106F70
    public void EndInvoke(){} // RVA: 0x6C4A640
}

public class RaycastAllCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8107050
    public void Invoke(){} // RVA: 0x8107120
    public void BeginInvoke(){} // RVA: 0x8107160
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ReadBufferState : Object
{
    public object Buffer;
    public object Offset;
    public object Count;
    public object InitialCount;
    public object Ares;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x75AB1E0
}

public class ReadDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68D87B0
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x68D88A0
    public void EndInvoke(){} // RVA: 0x2233620
}

public class ReadMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68D87B0
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x68D88A0
    public void EndInvoke(){} // RVA: 0x2233620
}

public class ReadOnlyArrayList : ArrayList
{
    public object _list;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x68816C0
    public void get_Count(){} // RVA: 0x6881730
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void get_IsFixedSize(){} // RVA: 0xC2E4C0
    public void get_IsSynchronized(){} // RVA: 0x6881760
    public void get_Item(){} // RVA: 0x6881790
    public void set_Item(){} // RVA: 0x68817C0
    public void get_SyncRoot(){} // RVA: 0x6881810
    public void Add(){} // RVA: 0x6881840
    public void AddRange(){} // RVA: 0x6881890
    public void set_Capacity(){} // RVA: 0x68818E0
    public void Clear(){} // RVA: 0x6881930
    public void Clone(){} // RVA: 0x6881980
    public void Contains(){} // RVA: 0x6881AF0
    public void CopyTo(){} // RVA: 0x6881B50
    public void GetEnumerator(){} // RVA: 0x6881B80
    public void IndexOf(){} // RVA: 0x6881BB0
    public void Insert(){} // RVA: 0x6881BE0
    public void InsertRange(){} // RVA: 0x6881C30
    public void Remove(){} // RVA: 0x6881C80
    public void RemoveAt(){} // RVA: 0x6881CD0
    public void RemoveRange(){} // RVA: 0x6881D20
    public void Reverse(){} // RVA: 0x6881D70
    public void Sort(){} // RVA: 0x6881DC0
    public void ToArray(){} // RVA: 0x6881E40
}

public class ReadWriteTask : Task`1
{
    public object _isRead;
    public object _apm;
    public object _stream;
    public object _buffer;
    public object _offset;
    public object _count;
    public object _callback;
    public object _context;
    public object s_invokeAsyncCallback;

    // ── Methods ──
    public void ClearBeginState(){} // RVA: 0x68CBA60
    public void .ctor(){} // RVA: 0x68CBB10
    public void InvokeAsyncCallback(){} // RVA: 0x68CBE90
    public void System.Threading.Tasks.ITaskCompletionAction.Invoke(){} // RVA: 0x68CBF60
    public void System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode(){} // RVA: 0xC2E4C0
}

public class Reader : Object
{
    // ── Methods ──
    public void Read16(){} // RVA: 0xA6A55B0
    public void Read32(){} // RVA: 0xA6A5600
    public void Read8(){} // RVA: 0xA6A5690
    public void ReadAllBytesFromStream(){} // RVA: 0xA6A56C0
    public void ReadString(){} // RVA: 0xA6A5880
    public void ReadVarInt(){} // RVA: 0xA6A58F0
}

public class Reader : ValueType
{
    public object m_ec;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void DangerousGetRawExecutionContext(){} // RVA: 0x77900
    public void get_IsNull(){} // RVA: 0x88E70
    public void IsDefaultFTContext(){} // RVA: 0x8C1DC0
    public void get_IsFlowSuppressed(){} // RVA: 0x8C1DE0
    public void get_SynchronizationContext(){} // RVA: 0x8C1E00
    public void get_SynchronizationContextNoFlow(){} // RVA: 0x8C1E20
    public void get_LogicalCallContext(){} // RVA: 0x8C1E40
    public void GetLocalValue(){} // RVA: 0x8C1E50
    public void HasSameLocalValues(){} // RVA: 0x8C1E60
}

public class Reader : ValueType
{
    public object m_ctx;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_IsNull(){} // RVA: 0x88E70
    public void get_HasInfo(){} // RVA: 0x8ADD30
    public void Clone(){} // RVA: 0x8ADD50
    public void GetData(){} // RVA: 0x8ADD60
}

public class ReaderCallbackInfo : Object
{
    public object _sri;
    public object _typeMap;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void ReadObject(){} // RVA: 0x7520290
}

public class ReceiveContext : Object
{
    public object workSocket;
    public object ReceivedHeaderBytes;
    public object HeaderBuffer;
    public object ExpectedMessageBytes;
    public object ReceivedMessageBytes;
    public object MessageBuffer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6CAD620
    public void get_ReadingHeader(){} // RVA: 0x1911560
    public void get_CurrentBuffer(){} // RVA: 0x6CAD730
    public void get_CurrentOffset(){} // RVA: 0x6CAD740
    public void get_CurrentExpected(){} // RVA: 0x6CAD750
    public void Reset(){} // RVA: 0x6CAD760
}

public class ReceiveTrackingValues : Object
{
    public object ReceivedReliableCommandSincePreviousAck2;
    public object receivedReliableSequenceNumbers;
    public object reliableSequencedNumbersCompletelyReceived;
    public object reliableSequencedNumbersHighestReceived;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C79710
}

public class ReceiverData : ValueType
{
    public object isValid;
    public object shapeId;
    public object receiverType;
    public object collisions;
    public object collisionValue;

    // ── Methods ──
    public void Init(){} // RVA: 0x9C8650
    public void Dispose(){} // RVA: 0x9C8660
}

public class RecognizedAttribute : ValueType
{
    public object m_name;
    public object m_token;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x28E70
    public void get_Token(){} // RVA: 0x14790
    public void IsEqualTo(){} // RVA: 0x917EC0
}

public class Ref : CastInstructionNoT
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void ConvertNull(){} // RVA: 0x70C4140
}

public class Reference : InitializeLocalInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB460A0
    public void Run(){} // RVA: 0x70B2720
    public void BoxIfIndexMatches(){} // RVA: 0x70B2760
    public void get_InstructionName(){} // RVA: 0x70B2800
}

public class ReferenceComparer : Object
{
    public object _converter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Compare(){} // RVA: 0x76D8A10
}

public class ReferenceEqualsEqualityComparer : Object
{
    // ── Methods ──
    public void System.Collections.Generic.IEqualityComparer<System.Object>.Equals(){} // RVA: 0x3F12D40
    public void System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(){} // RVA: 0x6A6BD20
    public void .ctor(){} // RVA: 0xB43310
}

public class Reference[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class ReflectedTypeData : Object
{
    public object _type;
    public object _attributes;
    public object _events;
    public object _properties;
    public object _converter;
    public object _editors;
    public object _editorTypes;
    public object _editorCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void get_IsPopulated(){} // RVA: 0x76F7B30
    public void GetAttributes(){} // RVA: 0x76F7B60
    public void GetClassName(){} // RVA: 0x678C400
    public void GetComponentName(){} // RVA: 0x76F81D0
    public void GetConverter(){} // RVA: 0x76F82A0
    public void GetDefaultEvent(){} // RVA: 0x76F88F0
    public void GetDefaultProperty(){} // RVA: 0x76F8B40
    public void GetEditor(){} // RVA: 0x76F8D50
    public void GetEditorAttribute(){} // RVA: 0x76F9470
    public void GetEvents(){} // RVA: 0x76F96E0
    public void GetProperties(){} // RVA: 0x76F9B50
    public void GetTypeFromName(){} // RVA: 0x76F9FC0
    public void Refresh(){} // RVA: 0x76FA150
}

public class ReflectionHelper`2 : Object
{
    // ── Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x87C540
    public void CreateActionIMessage(){} // RVA: 0x87C540
    public void CreateFuncIMessageObject(){} // RVA: 0x87C540
    public void CreateActionIMessageObject(){} // RVA: 0x87C540
    public void CreateFuncIMessageBool(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x894290
}

public class Reflector : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0xB43310
    public void GetDerivedTypeSet(){} // RVA: 0x87C0D0
}

public class RelationshipHandle : ValueType
{
    public object Handle;

    // ── Methods ──
    public void Drop(){} // RVA: 0x26D9B00
    public void DiscordRelationshipType(){} // RVA: 0x26D9B80
    public void User(){} // RVA: 0x26D9C00
}

public class ReleaseEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x65CEB00
}

public class RemoveAcesCallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class RenderModel : Object
{
    public object _mesh;
    public object _material;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void get_mesh(){} // RVA: 0xB5DBF0
    public void set_mesh(){} // RVA: 0xB44D60
    public void get_material(){} // RVA: 0xB465B0
    public void set_material(){} // RVA: 0xBA9BA0
}

public class RenderModelInterfaceHolder : Object
{
    public object needsShutdown;
    public object failedLoadInterface;
    public object _instance;

    // ── Methods ──
    public void get_instance(){} // RVA: 0x6F8CB10
    public void Dispose(){} // RVA: 0x6F8CC40
    public void .ctor(){} // RVA: 0xB43310
}

public class RendererMaterialSlot[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class RenewalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0x28BB5D0
}

public class RequestCallback : Object
{
    public object messageCallback;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void HandleMessage(){} // RVA: 0x6AF6E90
}

public class RequestCallback`1 : RequestCallback
{
    public object callback;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void HandleMessage(){} // RVA: 0x894320
}

public class ReservedRange : Object
{
    public object _parser;
    public object _unknownFields;
    public object _hasBits0;
    public object StartDefaultValue;
    public object start_;
    public object EndDefaultValue;
    public object end_;

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x64D7210
    public void get_Descriptor(){} // RVA: 0x64D7270
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x64D72F0
    public void .ctor(){} // RVA: 0x64D73A0
    public void Clone(){} // RVA: 0x64D7490
    public void get_Start(){} // RVA: 0x64D75B0
    public void set_Start(){} // RVA: 0x64D65C0
    public void get_HasStart(){} // RVA: 0x64D65D0
    public void ClearStart(){} // RVA: 0x64D65E0
    public void get_End(){} // RVA: 0x64D7620
    public void set_End(){} // RVA: 0x64D6660
    public void get_HasEnd(){} // RVA: 0x64D6670
    public void ClearEnd(){} // RVA: 0x64D6680
    public void Equals(){} // RVA: 0x64D7780
    public void GetHashCode(){} // RVA: 0x64D7840
    public void ToString(){} // RVA: 0x64D78B0
    public void WriteTo(){} // RVA: 0x64B3910
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x64D7900
    public void CalculateSize(){} // RVA: 0x64D7990
    public void MergeFrom(){} // RVA: 0x64B3C50
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x64D7B70
    public void .cctor(){} // RVA: 0x64D7C10
}

public class ReservedWords : ValueType
{
    public object _word;
    public object _token;
    public object _op;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x426050
}

public class ResolveEventHolder : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ResourceEnumerator : Object
{
    public object _reader;
    public object _currentIsValid;
    public object _currentName;
    public object _dataPosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67CF3E0
    public void MoveNext(){} // RVA: 0x67CF450
    public void get_Key(){} // RVA: 0x67CF4A0
    public void get_Current(){} // RVA: 0x67CF600
    public void get_DataPosition(){} // RVA: 0xFEAE90
    public void get_Entry(){} // RVA: 0x67CF660
    public void get_Value(){} // RVA: 0x67CFB80
    public void Reset(){} // RVA: 0x67CFCE0
}

public class ResourceManagerMediator : Object
{
    public object _rm;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67CA8C0
    public void get_ModuleDir(){} // RVA: 0x13F92F0
    public void get_LocationInfo(){} // RVA: 0x13F93E0
    public void get_UserResourceSet(){} // RVA: 0x13F9A90
    public void get_BaseNameField(){} // RVA: 0x13F9340
    public void get_NeutralResourcesCulture(){} // RVA: 0x17EF240
    public void GetResourceFileName(){} // RVA: 0x67CA970
    public void get_LookedForSatelliteContractVersion(){} // RVA: 0xD347B0
    public void set_LookedForSatelliteContractVersion(){} // RVA: 0x67CA9A0
    public void get_SatelliteContractVersion(){} // RVA: 0x67CA9C0
    public void set_SatelliteContractVersion(){} // RVA: 0x67CA9E0
    public void ObtainSatelliteContractVersion(){} // RVA: 0x67CAA50
    public void get_FallbackLoc(){} // RVA: 0x67CAAA0
    public void get_CallingAssembly(){} // RVA: 0x12427C0
    public void get_MainAssembly(){} // RVA: 0x67CAAC0
    public void get_BaseName(){} // RVA: 0x10AD380
}

public class ResourceProvider : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F6ECE0
    public void Invoke(){} // RVA: 0xB9E010
}

public class Response : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xCA8B20
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x828CFF0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Result : Object
{
    public object _status;
    public object _error;
    public object _argument;

    // ── Methods ──
    public void get_Status(){} // RVA: 0xA94080
    public void get_Success(){} // RVA: 0x87D280
    public void get_Error(){} // RVA: 0x87C0A0
    public void get_Argument(){} // RVA: 0xA94080
    public void .ctor(){} // RVA: 0xA94080
}

public class Result : Object
{
    public object _status;
    public object _error;
    public object _argument;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2574280
    public void get_Error(){} // RVA: 0xB465B0
}

public class ResultCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x65D4E20
    public void Invoke(){} // RVA: 0x65D4EF0
}

public class ResultCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x65D4E20
    public void Invoke(){} // RVA: 0x65D4EF0
}

public class ResultCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x65D4E20
    public void Invoke(){} // RVA: 0x65D4EF0
}

public class ResultCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E1A00
    public void Invoke(){} // RVA: 0xCA8D60
}

public class Retargetable : Object
{
    public object source;
    public object destination;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
}

public class RightShiftByte : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF390
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftInt16 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF030
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftInt32 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF130
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftInt64 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF220
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftSByte : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BEF30
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftUInt16 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF490
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftUInt32 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF590
    public void .ctor(){} // RVA: 0xB43310
}

public class RightShiftUInt64 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70BF700
    public void .ctor(){} // RVA: 0xB43310
}

public class RigidTransform : ValueType
{
    public object pos;
    public object rot;

    // ── Methods ──
    public void get_identity(){} // RVA: 0x6F0CCC0
    public void FromLocal(){} // RVA: 0x6F0CD60
    public void .ctor(){} // RVA: 0x8FC370
    public void ToHmdMatrix44(){} // RVA: 0x8FC6D0
    public void ToHmdMatrix34(){} // RVA: 0x8FC990
    public void Equals(){} // RVA: 0x8FC9D0
    public void GetHashCode(){} // RVA: 0x8FC9E0
    public void op_Equality(){} // RVA: 0x6B7C4D0
    public void op_Inequality(){} // RVA: 0x6F0E0A0
    public void op_Multiply(){} // RVA: 0x6F0EE30
    public void Inverse(){} // RVA: 0x8FCAC0
    public void GetInverse(){} // RVA: 0x8FCAD0
    public void Multiply(){} // RVA: 0x8FCB30
    public void InverseTransformPoint(){} // RVA: 0x8FCB90
    public void TransformPoint(){} // RVA: 0x8FCBE0
    public void Interpolate(){} // RVA: 0x8FCC30
}

public class RotationBySpeedModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97E730
    public void set_enabled(){} // RVA: 0x97E780
    public void get_x(){} // RVA: 0x97E790
    public void set_x(){} // RVA: 0x97E7C0
    public void get_xBlittable(){} // RVA: 0x97E7F0
    public void set_xBlittable(){} // RVA: 0x97E880
    public void get_xMultiplier(){} // RVA: 0x97E8F0
    public void set_xMultiplier(){} // RVA: 0x97E940
    public void get_y(){} // RVA: 0x97E950
    public void set_y(){} // RVA: 0x97E980
    public void get_yBlittable(){} // RVA: 0x97E9B0
    public void set_yBlittable(){} // RVA: 0x97EA40
    public void get_yMultiplier(){} // RVA: 0x97EAB0
    public void set_yMultiplier(){} // RVA: 0x97EB00
    public void get_z(){} // RVA: 0x97EB10
    public void set_z(){} // RVA: 0x97EB40
    public void get_zBlittable(){} // RVA: 0x97EB70
    public void set_zBlittable(){} // RVA: 0x97EC00
    public void get_zMultiplier(){} // RVA: 0x97EC70
    public void set_zMultiplier(){} // RVA: 0x97ECC0
    public void get_separateAxes(){} // RVA: 0x97ECD0
    public void set_separateAxes(){} // RVA: 0x97ED20
    public void get_range(){} // RVA: 0x97ED30
    public void set_range(){} // RVA: 0x97ED40
    public void get_xBlittable_Injected(){} // RVA: 0x7CCDE70
    public void set_xBlittable_Injected(){} // RVA: 0x7CCDED0
    public void get_yBlittable_Injected(){} // RVA: 0x7CCDF30
    public void set_yBlittable_Injected(){} // RVA: 0x7CCDF90
    public void get_zBlittable_Injected(){} // RVA: 0x7CCDFF0
    public void set_zBlittable_Injected(){} // RVA: 0x7CCE050
    public void get_range_Injected(){} // RVA: 0x7CCE0B0
    public void set_range_Injected(){} // RVA: 0x7CCE110
}

public class RotationOverLifetimeModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97E070
    public void set_enabled(){} // RVA: 0x97E0C0
    public void get_x(){} // RVA: 0x97E0D0
    public void set_x(){} // RVA: 0x97E100
    public void get_xBlittable(){} // RVA: 0x97E130
    public void set_xBlittable(){} // RVA: 0x97E1C0
    public void get_xMultiplier(){} // RVA: 0x97E230
    public void set_xMultiplier(){} // RVA: 0x97E280
    public void get_y(){} // RVA: 0x97E290
    public void set_y(){} // RVA: 0x97E2C0
    public void get_yBlittable(){} // RVA: 0x97E2F0
    public void set_yBlittable(){} // RVA: 0x97E380
    public void get_yMultiplier(){} // RVA: 0x97E3F0
    public void set_yMultiplier(){} // RVA: 0x97E440
    public void get_z(){} // RVA: 0x97E450
    public void set_z(){} // RVA: 0x97E480
    public void get_zBlittable(){} // RVA: 0x97E4B0
    public void set_zBlittable(){} // RVA: 0x97E540
    public void get_zMultiplier(){} // RVA: 0x97E5B0
    public void set_zMultiplier(){} // RVA: 0x97E600
    public void get_separateAxes(){} // RVA: 0x97E610
    public void set_separateAxes(){} // RVA: 0x97E660
    public void get_xBlittable_Injected(){} // RVA: 0x7CCCFC0
    public void set_xBlittable_Injected(){} // RVA: 0x7CCD020
    public void get_yBlittable_Injected(){} // RVA: 0x7CCD080
    public void set_yBlittable_Injected(){} // RVA: 0x7CCD0E0
    public void get_zBlittable_Injected(){} // RVA: 0x7CCD140
    public void set_zBlittable_Injected(){} // RVA: 0x7CCD1A0
}

public class RowDiffIdUsageSection : ValueType
{
    public object _targetTable;

    // ── Methods ──
    public void Prepare(){} // RVA: 0x902B00
}

public class Rune : ValueType
{
    public object value;

    // ── Methods ──
    public void Equals(){} // RVA: 0x9244B0
    public void GetHashCode(){} // RVA: 0x77E60
}

public class RuntimeVariables : Object
{
    public object _boxes;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x17F0080
    public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x70C97A0
    public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x70C9810
}

public class RuntimeVariablesExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7049D10
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
    public void get_Variables(){} // RVA: 0x13F9340
}
