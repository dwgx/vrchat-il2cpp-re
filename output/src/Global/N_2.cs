// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 94
// Methods: 601

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ <Item>k__BackingField; // 0x10
    public Node<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ> <Left>k__BackingField; // 0x18
    public Node<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ> <Right>k__BackingField; // 0x20
    public 0x65853D10 <Color>k__BackingField; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C85250
    public void IsNonNullRed(){} // RVA: 0x3C852B0
    public void IsNullOrBlack(){} // RVA: 0x3C852F0
    public void get_Item(){} // RVA: 0x2F8380
    public void set_Item(){} // RVA: 0x2DEE30
    public void get_Left(){} // RVA: 0x2E07C0
    public void set_Left(){} // RVA: 0x343E80
    public void get_Right(){} // RVA: 0x30B0C0
    public void set_Right(){} // RVA: 0x30B0D0
    public void get_Color(){} // RVA: 0x6E8A80
    public void set_Color(){} // RVA: 0x6E8B80
    public void get_IsBlack(){} // RVA: 0x3C85330
    public void get_IsRed(){} // RVA: 0x3C85340
    public void get_Is2Node(){} // RVA: 0x3C85350
    public void get_Is4Node(){} // RVA: 0x3C85410
    public void ColorBlack(){} // RVA: 0x1E32400
    public void ColorRed(){} // RVA: 0x14EC4C0
    public void GetRotation(){} // RVA: 0x3C854B0
    public void GetSibling(){} // RVA: 0x3C85530
    public void Split4Node(){} // RVA: 0x3C85540
    public void Rotate(){} // RVA: 0x3C85570
    public void RotateLeft(){} // RVA: 0x3C855F0
    public void RotateLeftRight(){} // RVA: 0x3C856C0
    public void RotateRight(){} // RVA: 0x3C85850
    public void RotateRightLeft(){} // RVA: 0x3C85920
    public void Merge2Nodes(){} // RVA: 0x3C85AB0
    public void ReplaceChild(){} // RVA: 0x3C85AE0
}

public class Node
{
    public Node<string> EmptyNode;
    public string _key; // 0x10
    public bool _frozen; // 0x18
    public byte _height; // 0x19
    public int _count; // 0x1C
    public Node<string> _left; // 0x20
    public Node<string> _right; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C83020 | overloaded x2
    public void get_IsEmpty(){} // RVA: 0x3C81FA0
    public void get_Height(){} // RVA: 0x6B93D0
    public void get_Left(){} // RVA: 0x30B0C0
    public void get_Right(){} // RVA: 0x30B130
    public void get_Value(){} // RVA: 0x2F8380
    public void get_Count(){} // RVA: 0x197C3B0
    public void ItemRef(){} // RVA: 0x3C83280
    public void ItemRefUnchecked(){} // RVA: 0x3C83300
    public void GetEnumerator(){} // RVA: 0x3C83370
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3C833D0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3C833D0
    public void Add(){} // RVA: 0x3C834A0
    public void ReplaceAt(){} // RVA: 0x3C836D0
    public void IndexOf(){} // RVA: 0x3C839B0 | overloaded x2
    public void Contains(){} // RVA: 0x3C84F60 | overloaded x2
    public void CopyTo(){} // RVA: 0x3C83FB0 | overloaded x2
    public void Freeze(){} // RVA: 0x3C84290
    public void RotateLeft(){} // RVA: 0x3C84300
    public void DoubleLeft(){} // RVA: 0x3C84360
    public void get_BalanceFactor(){} // RVA: 0x3C84400
    public void get_IsBalanced(){} // RVA: 0x3C84430
    public void BalanceRight(){} // RVA: 0x3C84470
    public void MutateBoth(){} // RVA: 0x3C845B0
    public void MutateLeft(){} // RVA: 0x3C84820
    public void MutateRight(){} // RVA: 0x3C84A20
    public void ParentHeight(){} // RVA: 0x3C84C20
    public void ParentCount(){} // RVA: 0x3C84CC0
    public void MutateKey(){} // RVA: 0x3C84CF0
    public void CreateLeaf(){} // RVA: 0x3C84DF0
    public void .cctor(){} // RVA: 0x3C85130
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D570
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Transmtn.DTO.Notifications.Notification <Item>k__BackingField; // 0x10
    public Node<Transmtn.DTO.Notifications.Notification> <Left>k__BackingField; // 0x18
    public Node<Transmtn.DTO.Notifications.Notification> <Right>k__BackingField; // 0x20
    public 0x65853D10 <Color>k__BackingField; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C85250
    public void IsNonNullRed(){} // RVA: 0x3C852B0
    public void IsNullOrBlack(){} // RVA: 0x3C852F0
    public void get_Item(){} // RVA: 0x2F8380
    public void set_Item(){} // RVA: 0x2DEE30
    public void get_Left(){} // RVA: 0x2E07C0
    public void set_Left(){} // RVA: 0x343E80
    public void get_Right(){} // RVA: 0x30B0C0
    public void set_Right(){} // RVA: 0x30B0D0
    public void get_Color(){} // RVA: 0x6E8A80
    public void set_Color(){} // RVA: 0x6E8B80
    public void get_IsBlack(){} // RVA: 0x3C85330
    public void get_IsRed(){} // RVA: 0x3C85340
    public void get_Is2Node(){} // RVA: 0x3C85350
    public void get_Is4Node(){} // RVA: 0x3C85410
    public void ColorBlack(){} // RVA: 0x1E32400
    public void ColorRed(){} // RVA: 0x14EC4C0
    public void GetRotation(){} // RVA: 0x3C854B0
    public void GetSibling(){} // RVA: 0x3C85530
    public void Split4Node(){} // RVA: 0x3C85540
    public void Rotate(){} // RVA: 0x3C85570
    public void RotateLeft(){} // RVA: 0x3C855F0
    public void RotateLeftRight(){} // RVA: 0x3C856C0
    public void RotateRight(){} // RVA: 0x3C85850
    public void RotateRightLeft(){} // RVA: 0x3C85920
    public void Merge2Nodes(){} // RVA: 0x3C85AB0
    public void ReplaceChild(){} // RVA: 0x3C85AE0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D760
}

public class Node
{
    public VRC.Udon.UdonBehaviour <Item>k__BackingField; // 0x10
    public Node<VRC.Udon.UdonBehaviour> <Left>k__BackingField; // 0x18
    public Node<VRC.Udon.UdonBehaviour> <Right>k__BackingField; // 0x20
    public 0x65853D10 <Color>k__BackingField; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C85250
    public void IsNonNullRed(){} // RVA: 0x3C852B0
    public void IsNullOrBlack(){} // RVA: 0x3C852F0
    public void get_Item(){} // RVA: 0x2F8380
    public void set_Item(){} // RVA: 0x2DEE30
    public void get_Left(){} // RVA: 0x2E07C0
    public void set_Left(){} // RVA: 0x343E80
    public void get_Right(){} // RVA: 0x30B0C0
    public void set_Right(){} // RVA: 0x30B0D0
    public void get_Color(){} // RVA: 0x6E8A80
    public void set_Color(){} // RVA: 0x6E8B80
    public void get_IsBlack(){} // RVA: 0x3C85330
    public void get_IsRed(){} // RVA: 0x3C85340
    public void get_Is2Node(){} // RVA: 0x3C85350
    public void get_Is4Node(){} // RVA: 0x3C85410
    public void ColorBlack(){} // RVA: 0x1E32400
    public void ColorRed(){} // RVA: 0x14EC4C0
    public void GetRotation(){} // RVA: 0x3C854B0
    public void GetSibling(){} // RVA: 0x3C85530
    public void Split4Node(){} // RVA: 0x3C85540
    public void Rotate(){} // RVA: 0x3C85570
    public void RotateLeft(){} // RVA: 0x3C855F0
    public void RotateLeftRight(){} // RVA: 0x3C856C0
    public void RotateRight(){} // RVA: 0x3C85850
    public void RotateRightLeft(){} // RVA: 0x3C85920
    public void Merge2Nodes(){} // RVA: 0x3C85AB0
    public void ReplaceChild(){} // RVA: 0x3C85AE0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D4B0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3CE2B0 | overloaded x3
}

public class Node
{
    public System.Collections.Generic.KeyValuePair`2<uint,System.ValueTuple`2<uint,uint>> <Item>k__BackingField; // 0x10
    public Node<System.Collections.Generic.KeyValuePair`2<uint,System.ValueTuple`2<uint,uint>>> <Left>k__BackingField; // 0x20
    public Node<System.Collections.Generic.KeyValuePair`2<uint,System.ValueTuple`2<uint,uint>>> <Right>k__BackingField; // 0x28
    public 0x65853D10 <Color>k__BackingField; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D760
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C81EF0
}

public class Node
{
    public Google.Protobuf.MessageParser`1<Node> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public string name_; // 0x18
    public string calculator_; // 0x20
    public Google.Protobuf.FieldCodec`1<string> _repeated_inputStream_codec; // 0x8
    public Google.Protobuf.Collections.RepeatedField`1<string> inputStream_; // 0x28
    public Google.Protobuf.FieldCodec`1<string> _repeated_outputStream_codec; // 0x10
    public Google.Protobuf.Collections.RepeatedField`1<string> outputStream_; // 0x30
    public Google.Protobuf.FieldCodec`1<string> _repeated_inputSidePacket_codec; // 0x18
    public Google.Protobuf.Collections.RepeatedField`1<string> inputSidePacket_; // 0x38
    public Google.Protobuf.FieldCodec`1<string> _repeated_outputSidePacket_codec; // 0x20
    public Google.Protobuf.Collections.RepeatedField`1<string> outputSidePacket_; // 0x40
    public Mediapipe.CalculatorOptions options_; // 0x48
    public Google.Protobuf.FieldCodec`1<Google.Protobuf.WellKnownTypes.Any> _repeated_nodeOptions_codec; // 0x28
    public Google.Protobuf.Collections.RepeatedField`1<Google.Protobuf.WellKnownTypes.Any> nodeOptions_; // 0x50
    public int sourceLayer_; // 0x58
    public int bufferSizeHint_; // 0x5C
    public Mediapipe.InputStreamHandlerConfig inputStreamHandler_; // 0x60
    public Mediapipe.OutputStreamHandlerConfig outputStreamHandler_; // 0x68
    public Google.Protobuf.FieldCodec`1<Mediapipe.InputStreamInfo> _repeated_inputStreamInfo_codec; // 0x30
    public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.InputStreamInfo> inputStreamInfo_; // 0x70

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x5AFE980
    public void get_Descriptor(){} // RVA: 0x5AFE9E0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AFEA60
    public void .ctor(){} // RVA: 0x5AFF060 | overloaded x2
    public void Clone(){} // RVA: 0x5AFFA80
    public void get_Name(){} // RVA: 0x2E07C0
    public void set_Name(){} // RVA: 0x5AFFAE0
    public void get_Calculator(){} // RVA: 0x30B0C0
    public void set_Calculator(){} // RVA: 0x5AFFBE0
    public void get_InputStream(){} // RVA: 0x30B130
    public void get_OutputStream(){} // RVA: 0x6374D0
    public void get_InputSidePacket(){} // RVA: 0x4976A0
    public void get_OutputSidePacket(){} // RVA: 0x35A740
    public void get_Options(){} // RVA: 0x358730
    public void set_Options(){} // RVA: 0x358740
    public void get_NodeOptions(){} // RVA: 0x37E0E0
    public void get_SourceLayer(){} // RVA: 0x9EAB90
    public void set_SourceLayer(){} // RVA: 0x9EAAE0
    public void get_BufferSizeHint(){} // RVA: 0x5A54D0
    public void set_BufferSizeHint(){} // RVA: 0x9EACA0
    public void get_InputStreamHandler(){} // RVA: 0x37B370
    public void set_InputStreamHandler(){} // RVA: 0x37B380
    public void get_OutputStreamHandler(){} // RVA: 0x358D50
    public void set_OutputStreamHandler(){} // RVA: 0x358D60
    public void get_InputStreamInfo(){} // RVA: 0x3A5590
    public void get_Executor(){} // RVA: 0x4C7C50
    public void set_Executor(){} // RVA: 0x5AFFCE0
    public void get_ProfilerConfig(){} // RVA: 0x462D00
    public void set_ProfilerConfig(){} // RVA: 0x464450
    public void get_MaxInFlight(){} // RVA: 0xBB90C0
    public void set_MaxInFlight(){} // RVA: 0xBB9E60
    public void get_OptionValue(){} // RVA: 0x796DE0
    public void get_ExternalInput(){} // RVA: 0xA1C8C0
    public void Equals(){} // RVA: 0x5AFFE40 | overloaded x2
    public void GetHashCode(){} // RVA: 0x5B00220
    public void ToString(){} // RVA: 0x5B004C0
    public void WriteTo(){} // RVA: 0x5A39740
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B00510
    public void CalculateSize(){} // RVA: 0x5B00910
    public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B014D0
    public void .cctor(){} // RVA: 0x5B01AF0
}

public class Node
{
    public System.Collections.Generic.Dictionary`2<string,Node> <Children>k__BackingField; // 0x10

    // ── Methods ──
    public void get_Children(){} // RVA: 0x2F8380
    public void .ctor(){} // RVA: 0x5A253A0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D310
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<string,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<string,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<string,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<string,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C7DA60 | overloaded x2
    public void get_IsEmpty(){} // RVA: 0x3C7C820
    public void get_Height(){} // RVA: 0x6BB3A0
    public void get_Left(){} // RVA: 0x30B130
    public void get_Right(){} // RVA: 0x6374D0
    public void get_Value(){} // RVA: 0x196ABE0
    public void get_Count(){} // RVA: 0xCEF5B0
    public void ItemRef(){} // RVA: 0x3C7DCD0
    public void ItemRefUnchecked(){} // RVA: 0x3C7DD50
    public void GetEnumerator(){} // RVA: 0x3C7DDC0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3C7DE20
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3C7DE20
    public void Add(){} // RVA: 0x3C7DEF0
    public void ReplaceAt(){} // RVA: 0x3C7E130
    public void IndexOf(){} // RVA: 0x3C7E430 | overloaded x2
    public void Contains(){} // RVA: 0x3C7FBB0 | overloaded x2
    public void CopyTo(){} // RVA: 0x3C7EB30 | overloaded x2
    public void Freeze(){} // RVA: 0x3C7EE40
    public void RotateLeft(){} // RVA: 0x3C7EEB0
    public void DoubleLeft(){} // RVA: 0x3C7EF10
    public void get_BalanceFactor(){} // RVA: 0x3C7EFB0
    public void get_IsBalanced(){} // RVA: 0x3C7EFE0
    public void BalanceRight(){} // RVA: 0x3C7F020
    public void MutateBoth(){} // RVA: 0x3C7F160
    public void MutateLeft(){} // RVA: 0x3C7F400
    public void MutateRight(){} // RVA: 0x3C7F630
    public void ParentHeight(){} // RVA: 0x3C7F860
    public void ParentCount(){} // RVA: 0x3C7F900
    public void MutateKey(){} // RVA: 0x3C7F930
    public void CreateLeaf(){} // RVA: 0x3C7FA30
    public void .cctor(){} // RVA: 0x3C7FE10
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C7FFB0 | overloaded x2
    public void get_IsEmpty(){} // RVA: 0x3C7C820
    public void get_Height(){} // RVA: 0x6BB3A0
    public void get_Left(){} // RVA: 0x30B130
    public void get_Right(){} // RVA: 0x6374D0
    public void get_Value(){} // RVA: 0x196ABE0
    public void get_Count(){} // RVA: 0xCEF5B0
    public void ItemRef(){} // RVA: 0x3C80220
    public void ItemRefUnchecked(){} // RVA: 0x3C7DD50
    public void GetEnumerator(){} // RVA: 0x3C802A0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3C80300
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3C80300
    public void Add(){} // RVA: 0x3C803D0
    public void ReplaceAt(){} // RVA: 0x3C80610
    public void IndexOf(){} // RVA: 0x3C80880 | overloaded x2
    public void Contains(){} // RVA: 0x3C7FBB0 | overloaded x2
    public void CopyTo(){} // RVA: 0x3C80F80 | overloaded x2
    public void Freeze(){} // RVA: 0x3C7EE40
    public void RotateLeft(){} // RVA: 0x3C81290
    public void DoubleLeft(){} // RVA: 0x3C812F0
    public void get_BalanceFactor(){} // RVA: 0x3C7EFB0
    public void get_IsBalanced(){} // RVA: 0x3C7EFE0
    public void BalanceRight(){} // RVA: 0x3C81390
    public void MutateBoth(){} // RVA: 0x3C814D0
    public void MutateLeft(){} // RVA: 0x3C81770
    public void MutateRight(){} // RVA: 0x3C819A0
    public void ParentHeight(){} // RVA: 0x3C81BD0
    public void ParentCount(){} // RVA: 0x3C7F900
    public void MutateKey(){} // RVA: 0x3C81C70
    public void CreateLeaf(){} // RVA: 0x3C81D70
    public void .cctor(){} // RVA: 0x3C7FE10
}

public class NodeData
{
    public NodeData s_None;
    public 0x658787D8 type; // 0x10
    public string localName; // 0x18
    public string prefix; // 0x20
    public string ns; // 0x28
    public string nameWPrefix; // 0x30
    public string value; // 0x38

    // ── Methods ──
    public void get_None(){} // RVA: 0x6A28930
    public void .ctor(){} // RVA: 0x6A28A20
    public void get_LineNo(){} // RVA: 0x59C540
    public void get_LinePos(){} // RVA: 0xC5BE80
    public void get_IsEmptyElement(){} // RVA: 0x6A28A40
    public void set_IsEmptyElement(){} // RVA: 0x3A5580
    public void get_IsDefaultAttribute(){} // RVA: 0x6A28A50
    public void set_IsDefaultAttribute(){} // RVA: 0x3A5580
    public void get_ValueBuffered(){} // RVA: 0x14064A0
    public void get_StringValue(){} // RVA: 0x6A28A60
    public void TrimSpacesInValue(){} // RVA: 0x6A28AF0
    public void Clear(){} // RVA: 0x6A28C70
    public void ClearName(){} // RVA: 0x6A28E50
    public void SetLineInfo(){} // RVA: 0x6A29010
    public void SetLineInfo2(){} // RVA: 0x6A29020
    public void SetValueNode(){} // RVA: 0x6A290B0 | overloaded x2
    public void SetNamedNode(){} // RVA: 0x6A29220 | overloaded x2
    public void SetValue(){} // RVA: 0x6A294A0 | overloaded x2
    public void OnBufferInvalidated(){} // RVA: 0x6A29570
    public void CopyTo(){} // RVA: 0x6A29690 | overloaded x2
    public void GetNameWPrefix(){} // RVA: 0x6A29710
    public void CreateNameWPrefix(){} // RVA: 0x6A29880
    public void System.IComparable.CompareTo(){} // RVA: 0x6A299D0
}

public class NodeEnumerator
{
    public System.Collections.ListDictionaryInternal list; // 0x10
    public DictionaryNode current; // 0x18
    public int version; // 0x20
    public bool start; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5DFA790
    public void get_Current(){} // RVA: 0x5DFA870
    public void get_Entry(){} // RVA: 0x5DFA930
    public void get_Key(){} // RVA: 0x5DFA9B0
    public void get_Value(){} // RVA: 0x5DFAA20
    public void MoveNext(){} // RVA: 0x5DFAA90
    public void Reset(){} // RVA: 0x5DFABB0
}

public class NodeEnumerator
{
    public System.Collections.Specialized.ListDictionary _list; // 0x10
    public DictionaryNode _current; // 0x18
    public int _version; // 0x20
    public bool _start; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5DFA790
    public void get_Current(){} // RVA: 0x6CB5950
    public void get_Entry(){} // RVA: 0x6CB5A10
    public void get_Key(){} // RVA: 0x6CB5A90
    public void get_Value(){} // RVA: 0x6CB5B00
    public void MoveNext(){} // RVA: 0x6CB5B70
    public void Reset(){} // RVA: 0x6CB5C90
}

public class NodeKeyValueCollection
{
    public System.Collections.ListDictionaryInternal list; // 0x10
    public bool isKeys; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x1AB41A0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5DFAC80
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x5DFAE80
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x5DFAEC0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5DFAF80
}

public class NodeKeyValueCollection
{
    public System.Collections.Specialized.ListDictionary _list; // 0x10
    public bool _isKeys; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x1AB41A0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6CB5D60
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x5DFAE80
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6CB5EC0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6CB5F80
}

public class NodeKeyValueEnumerator
{
    public System.Collections.ListDictionaryInternal list; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5DFB0A0
    public void get_Current(){} // RVA: 0x5DFB190
    public void MoveNext(){} // RVA: 0x5DFB210
    public void Reset(){} // RVA: 0x5DFB330
}

public class NodeKeyValueEnumerator
{
    public System.Collections.Specialized.ListDictionary _list; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5DFB0A0
    public void get_Current(){} // RVA: 0x6CB60A0
    public void MoveNext(){} // RVA: 0x6CB6120
    public void Reset(){} // RVA: 0x6CB6240
}

public class NodePath
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26EE0
}

public class NodePath
{
}

public class NodePath
{
}

public class Noise
{
}

public class NoiseModule
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void get_enabled(){} // RVA: 0x71C1470
    public void set_enabled(){} // RVA: 0x71C14C0
    public void get_separateAxes(){} // RVA: 0x71C1520
    public void set_separateAxes(){} // RVA: 0x71C1570
    public void get_strength(){} // RVA: 0x71C15D0
    public void set_strength(){} // RVA: 0x71C1640
    public void get_strengthMultiplier(){} // RVA: 0x71C16A0
    public void set_strengthMultiplier(){} // RVA: 0x71C16F0
    public void get_strengthX(){} // RVA: 0x71C1750
    public void set_strengthX(){} // RVA: 0x71C17C0
    public void get_strengthXMultiplier(){} // RVA: 0x71C1820
    public void set_strengthXMultiplier(){} // RVA: 0x71C1870
    public void get_strengthY(){} // RVA: 0x71C18D0
    public void set_strengthY(){} // RVA: 0x71C1940
    public void get_strengthYMultiplier(){} // RVA: 0x71C19A0
    public void set_strengthYMultiplier(){} // RVA: 0x71C19F0
    public void get_strengthZ(){} // RVA: 0x71C1A50
    public void set_strengthZ(){} // RVA: 0x71C1AC0
    public void get_strengthZMultiplier(){} // RVA: 0x71C1B20
    public void set_strengthZMultiplier(){} // RVA: 0x71C1B70
    public void get_frequency(){} // RVA: 0x71C1BD0
    public void set_frequency(){} // RVA: 0x71C1C20
    public void get_damping(){} // RVA: 0x71C1C80
    public void set_damping(){} // RVA: 0x71C1CD0
    public void get_octaveCount(){} // RVA: 0x71C1D30
    public void set_octaveCount(){} // RVA: 0x71C1D80
    public void get_octaveMultiplier(){} // RVA: 0x71C1DE0
    public void set_octaveMultiplier(){} // RVA: 0x71C1E30
    public void get_octaveScale(){} // RVA: 0x71C1E90
    public void set_octaveScale(){} // RVA: 0x71C1EE0
    public void get_quality(){} // RVA: 0x71C1F40
    public void set_quality(){} // RVA: 0x71C1F90
    public void get_scrollSpeed(){} // RVA: 0x71C1FF0
    public void set_scrollSpeed(){} // RVA: 0x71C2060
    public void get_scrollSpeedMultiplier(){} // RVA: 0x71C20C0
    public void set_scrollSpeedMultiplier(){} // RVA: 0x71C2110
    public void get_remapEnabled(){} // RVA: 0x71C2170
    public void set_remapEnabled(){} // RVA: 0x71C21C0
    public void get_remap(){} // RVA: 0x71C2220
    public void set_remap(){} // RVA: 0x71C2290
    public void get_remapMultiplier(){} // RVA: 0x71C22F0
    public void set_remapMultiplier(){} // RVA: 0x71C2340
    public void get_remapX(){} // RVA: 0x71C23A0
    public void set_remapX(){} // RVA: 0x71C2410
    public void get_remapXMultiplier(){} // RVA: 0x71C2470
    public void set_remapXMultiplier(){} // RVA: 0x71C24C0
    public void get_remapY(){} // RVA: 0x71C2520
    public void set_remapY(){} // RVA: 0x71C2590
    public void get_remapYMultiplier(){} // RVA: 0x71C25F0
    public void set_remapYMultiplier(){} // RVA: 0x71C2640
    public void get_remapZ(){} // RVA: 0x71C26A0
    public void set_remapZ(){} // RVA: 0x71C2710
    public void get_remapZMultiplier(){} // RVA: 0x71C2770
    public void set_remapZMultiplier(){} // RVA: 0x71C27C0
    public void get_positionAmount(){} // RVA: 0x71C2820
    public void set_positionAmount(){} // RVA: 0x71C2890
    public void get_rotationAmount(){} // RVA: 0x71C28F0
    public void set_rotationAmount(){} // RVA: 0x71C2960
    public void get_sizeAmount(){} // RVA: 0x71C29C0
    public void set_sizeAmount(){} // RVA: 0x71C2A30
    public void get_enabled_Injected(){} // RVA: 0x71C1470
    public void set_enabled_Injected(){} // RVA: 0x71C14C0
    public void get_separateAxes_Injected(){} // RVA: 0x71C1520
    public void set_separateAxes_Injected(){} // RVA: 0x71C1570
    public void get_strength_Injected(){} // RVA: 0x71C2A90
    public void set_strength_Injected(){} // RVA: 0x71C2AF0
    public void get_strengthMultiplier_Injected(){} // RVA: 0x71C16A0
    public void set_strengthMultiplier_Injected(){} // RVA: 0x71C16F0
    public void get_strengthX_Injected(){} // RVA: 0x71C2B50
    public void set_strengthX_Injected(){} // RVA: 0x71C2BB0
    public void get_strengthXMultiplier_Injected(){} // RVA: 0x71C1820
    public void set_strengthXMultiplier_Injected(){} // RVA: 0x71C1870
    public void get_strengthY_Injected(){} // RVA: 0x71C2C10
    public void set_strengthY_Injected(){} // RVA: 0x71C2C70
    public void get_strengthYMultiplier_Injected(){} // RVA: 0x71C19A0
    public void set_strengthYMultiplier_Injected(){} // RVA: 0x71C19F0
    public void get_strengthZ_Injected(){} // RVA: 0x71C2CD0
    public void set_strengthZ_Injected(){} // RVA: 0x71C2D30
    public void get_strengthZMultiplier_Injected(){} // RVA: 0x71C1B20
    public void set_strengthZMultiplier_Injected(){} // RVA: 0x71C1B70
    public void get_frequency_Injected(){} // RVA: 0x71C1BD0
    public void set_frequency_Injected(){} // RVA: 0x71C1C20
    public void get_damping_Injected(){} // RVA: 0x71C1C80
    public void set_damping_Injected(){} // RVA: 0x71C1CD0
    public void get_octaveCount_Injected(){} // RVA: 0x71C1D30
    public void set_octaveCount_Injected(){} // RVA: 0x71C1D80
    public void get_octaveMultiplier_Injected(){} // RVA: 0x71C1DE0
    public void set_octaveMultiplier_Injected(){} // RVA: 0x71C1E30
    public void get_octaveScale_Injected(){} // RVA: 0x71C1E90
    public void set_octaveScale_Injected(){} // RVA: 0x71C1EE0
    public void get_quality_Injected(){} // RVA: 0x71C1F40
    public void set_quality_Injected(){} // RVA: 0x71C1F90
    public void get_scrollSpeed_Injected(){} // RVA: 0x71C2D90
    public void set_scrollSpeed_Injected(){} // RVA: 0x71C2DF0
    public void get_scrollSpeedMultiplier_Injected(){} // RVA: 0x71C20C0
    public void set_scrollSpeedMultiplier_Injected(){} // RVA: 0x71C2110
    public void get_remapEnabled_Injected(){} // RVA: 0x71C2170
    public void set_remapEnabled_Injected(){} // RVA: 0x71C21C0
    public void get_remap_Injected(){} // RVA: 0x71C2E50
    public void set_remap_Injected(){} // RVA: 0x71C2EB0
    public void get_remapMultiplier_Injected(){} // RVA: 0x71C22F0
    public void set_remapMultiplier_Injected(){} // RVA: 0x71C2340
    public void get_remapX_Injected(){} // RVA: 0x71C2F10
    public void set_remapX_Injected(){} // RVA: 0x71C2F70
    public void get_remapXMultiplier_Injected(){} // RVA: 0x71C2470
    public void set_remapXMultiplier_Injected(){} // RVA: 0x71C24C0
    public void get_remapY_Injected(){} // RVA: 0x71C2FD0
    public void set_remapY_Injected(){} // RVA: 0x71C3030
    public void get_remapYMultiplier_Injected(){} // RVA: 0x71C25F0
    public void set_remapYMultiplier_Injected(){} // RVA: 0x71C2640
    public void get_remapZ_Injected(){} // RVA: 0x71C3090
    public void set_remapZ_Injected(){} // RVA: 0x71C30F0
    public void get_remapZMultiplier_Injected(){} // RVA: 0x71C2770
    public void set_remapZMultiplier_Injected(){} // RVA: 0x71C27C0
    public void get_positionAmount_Injected(){} // RVA: 0x71C3150
    public void set_positionAmount_Injected(){} // RVA: 0x71C31B0
    public void get_rotationAmount_Injected(){} // RVA: 0x71C3210
    public void set_rotationAmount_Injected(){} // RVA: 0x71C3270
    public void get_sizeAmount_Injected(){} // RVA: 0x71C32D0
    public void set_sizeAmount_Injected(){} // RVA: 0x71C3330
}

public class NoiseParams
{
    // ── Methods ──
    public void GetValueAt(){} // RVA: 0x1D279A0
}

public class NonConstructable
{
    // ── Methods ──
    public void Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated(){} // RVA: 0x2DD320
    public void Instantiate(){} // RVA: 0x720DA30
    public void .ctor(){} // RVA: 0x2DD310
}

public class NoopDisposable
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x24A50
    public void .ctor(){} // RVA: 0x24A50
}

public class NotBoolean
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664EB80
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotByte
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664F270
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualBoolean
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664CE40
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualByte
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D3E0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualByteLiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664DF60
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualChar
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D110
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualCharLiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664DC30
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualDouble
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D8A0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualDoubleLiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664E4D0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D020
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualInt16LiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664DB20
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D200
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualInt32LiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664DD40
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D2F0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualInt64LiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664DE50
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualReference
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D9A0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualSByte
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664CF30
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualSByteLiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664DA10
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualSingle
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D7A0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualSingleLiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664E3A0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualUInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D4D0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualUInt16LiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664E070
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualUInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D5C0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualUInt32LiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664E180
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualUInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664D6B0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotEqualUInt64LiftedToNull
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664E290
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664EE60
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664ED90
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664EC50
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotSByte
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664F340
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotUInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664F1A0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotUInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664F070
    public void .ctor(){} // RVA: 0x2DD310
}

public class NotUInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664EF30
    public void .ctor(){} // RVA: 0x2DD310
}

public class NoteOnEvent
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x9A07910
    public void GetHashCode(){} // RVA: 0x5EB2660
}

public class NotificationEntry
{
    public double time; // 0x10
    public UnityEngine.Playables.INotification payload; // 0x18
    public bool notificationFired; // 0x20

    // ── Methods ──
    public void get_triggerInEditor(){} // RVA: 0x67E1D90
    public void get_prewarm(){} // RVA: 0x703FC40
    public void get_triggerOnce(){} // RVA: 0x703FC50
}

public class NotificationType
{
}

public class NtDll
{
    // ── Methods ──
    public void NtCreateFile(){} // RVA: 0x5BF3110
    public void CreateFile(){} // RVA: 0x5BF31C0
    public void NtQueryDirectoryFile(){} // RVA: 0x5BF3430
    public void RtlNtStatusToDosError(){} // RVA: 0x5BF3500
}

public class NullDisposable
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x2DD310
    public void .ctor(){} // RVA: 0x2DD310
    public void .cctor(){} // RVA: 0x9B13E20
}

public class NullProgress`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x24A50
    public void Report(){} // RVA: 0x283FA0
    public void .cctor(){} // RVA: 0x24A80
}

public class NullStream
{
    public System.Threading.Tasks.Task`1<int> s_zeroTask;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E52AB0
    public void get_CanRead(){} // RVA: 0x3C2850
    public void get_CanWrite(){} // RVA: 0x3C2850
    public void get_CanSeek(){} // RVA: 0x3C2850
    public void get_Length(){} // RVA: 0x519240
    public void get_Position(){} // RVA: 0x519240
    public void set_Position(){} // RVA: 0x2DD310
    public void CopyTo(){} // RVA: 0x5E52B00
    public void CopyToAsync(){} // RVA: 0x5E52B10
    public void Dispose(){} // RVA: 0x2DD310
    public void Flush(){} // RVA: 0x2DD310
    public void FlushAsync(){} // RVA: 0x5E52C20
    public void BeginRead(){} // RVA: 0x5E52D00
    public void EndRead(){} // RVA: 0x5E52D90
    public void BeginWrite(){} // RVA: 0x5E52F30
    public void EndWrite(){} // RVA: 0x5E52FC0
    public void Read(){} // RVA: 0x519240 | overloaded x2
    public void ReadAsync(){} // RVA: 0x5E531C0 | overloaded x2
    public void ReadByte(){} // RVA: 0x75BB20
    public void Write(){} // RVA: 0x2DD310 | overloaded x2
    public void WriteAsync(){} // RVA: 0x5E53340 | overloaded x2
    public void WriteByte(){} // RVA: 0x2DD310
    public void Seek(){} // RVA: 0x519240
    public void SetLength(){} // RVA: 0x2DD310
    public void .cctor(){} // RVA: 0x5E534B0
}

public class NullStreamReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E2E6C0
    public void get_BaseStream(){} // RVA: 0x5E2E8A0
    public void get_CurrentEncoding(){} // RVA: 0x5E2E900
    public void Dispose(){} // RVA: 0x2DD310
    public void Peek(){} // RVA: 0x75BB20
    public void Read(){} // RVA: 0x519240 | overloaded x2
    public void ReadLine(){} // RVA: 0x519240
    public void ReadToEnd(){} // RVA: 0x5E2E910
    public void ReadBuffer(){} // RVA: 0x519240
}

public class NullTextReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E38670
    public void Read(){} // RVA: 0x519240
    public void ReadLine(){} // RVA: 0x519240
}

public class NullTextWriter
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5E3B290
    public void get_Encoding(){} // RVA: 0x5E2E900
    public void Write(){} // RVA: 0x2DD310 | overloaded x3
    public void WriteLine(){} // RVA: 0x2DD310 | overloaded x3
}

public class NullableAttributeStateParser
{
    public object UnknownByte;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void get_Unknown(){} // RVA: 0x645D100
    public void ParseNullableState(){} // RVA: 0x645D1B0
    public void .cctor(){} // RVA: 0x645D480
}

public class Number
{
    // ── Methods ──
    public void IsWhite(){} // RVA: 0x682FC20
    public void MatchChars(){} // RVA: 0x682FD00 | overloaded x2
    public void ParseNumber(){} // RVA: 0x682FD50
    public void TrailingZeros(){} // RVA: 0x6830810
    public void TryStringToNumber(){} // RVA: 0x6830890
    public void Int32ToDecChars(){} // RVA: 0x6830A20
    public void ParseFormatSpecifier(){} // RVA: 0x6830A90
    public void NumberToString(){} // RVA: 0x6830C30
    public void FormatCurrency(){} // RVA: 0x68312D0
    public void wcslen(){} // RVA: 0x6831520
    public void FormatFixed(){} // RVA: 0x6831540
    public void FormatNumber(){} // RVA: 0x6831920
    public void FormatScientific(){} // RVA: 0x6831B20
    public void FormatExponent(){} // RVA: 0x6831C50
    public void FormatGeneral(){} // RVA: 0x6831DF0
    public void FormatPercent(){} // RVA: 0x6832060
    public void RoundNumber(){} // RVA: 0x68322B0
    public void FindSection(){} // RVA: 0x6832390
    public void NumberToStringFormat(){} // RVA: 0x68324A0
    public void .cctor(){} // RVA: 0x6833170
}

public class NumberBuffer
{
    public int precision; // 0x10
    public int scale; // 0x14

    // ── Methods ──
    public void get_sign(){} // RVA: 0x5EAD220
    public void set_sign(){} // RVA: 0x5EAD230
    public void get_digits(){} // RVA: 0x5EAD240
}

public class NumberBuffer
{
    public int precision; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6D73F20
    public void GetDigitsPointer(){} // RVA: 0x1AD4690
}

public class NumberBuffer
{
    public int precision; // 0x10

    // ── Methods ──
    public void get_digits(){} // RVA: 0x2F8380
}

public class NumberFormatEntryManaged
{
}
