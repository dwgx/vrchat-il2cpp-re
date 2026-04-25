// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 20
// Methods: 211

public class NativeArrayHelper`1 : ValueType
{
    public Unity.Collections.NativeArray`1<T> UnityNativeArray;
    public System.Runtime.InteropServices.GCHandle _handle;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class NetworkSurrogateSelector : Object
{
    public 0x66432A00 _next; // 0x10

    // ── Methods ──
    public void ChainSelector(){} // RVA: 0x7FFD57499CC0
    public void GetNextSelector(){} // RVA: 0x7FFD4E35C380
    public void GetSurrogate(){} // RVA: 0x7FFD57499DD0
    public void IsAllowedType(){} // RVA: 0x7FFD5749A300
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class NeverPromise`1 : Object
{
    public System.Action`1<object> cancellationCallback;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090BF0
    public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class NewInputFixedUpdate : ValueType
{
}

public class NewInputUpdate : ValueType
{
}

public class NextFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<NextFramePromise> NextNode;
    public NextFramePromise nextNode; // 0x10
    public int frameCount; // 0x18
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x50
    public bool cancelImmediately; // 0x68

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548ACB50
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548ACCD0
    public void GetResult(){} // RVA: 0x7FFD548AD0D0
    public void GetStatus(){} // RVA: 0x7FFD548AD270
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548AD2C0
    public void OnCompleted(){} // RVA: 0x7FFD548AD300
    public void MoveNext(){} // RVA: 0x7FFD548AD380
    public void TryReturn(){} // RVA: 0x7FFD548AD4C0
}

public class NextResult : ValueType
{
    public Mediapipe.Packet`1<System.Collections.Generic.List`1<0x66571E78>> packet; // 0x10
    public bool ok; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E096500
}

public class Node : Object
{
    public bool Used; // 0x10
    public int Key; // 0x14
    public Photon.Client.NCommand Val; // 0x18
    public int Next; // 0x20
    public uint Hash; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD519D2CC0
}

public class NodePath : ValueType
{
    public int _nodeID;
    public int _mainTreeNodeID;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E092E60
}

public class NoiseModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D78D70
    public void set_enabled(){} // RVA: 0x7FFD54D78DC0
    public void get_separateAxes(){} // RVA: 0x7FFD54D78E20
    public void set_separateAxes(){} // RVA: 0x7FFD54D78E70
    public void get_strength(){} // RVA: 0x7FFD54D78ED0
    public void set_strength(){} // RVA: 0x7FFD54D78F40
    public void get_strengthMultiplier(){} // RVA: 0x7FFD54D78FA0
    public void set_strengthMultiplier(){} // RVA: 0x7FFD54D78FF0
    public void get_strengthX(){} // RVA: 0x7FFD54D79050
    public void set_strengthX(){} // RVA: 0x7FFD54D790C0
    public void get_strengthXMultiplier(){} // RVA: 0x7FFD54D79120
    public void set_strengthXMultiplier(){} // RVA: 0x7FFD54D79170
    public void get_strengthY(){} // RVA: 0x7FFD54D791D0
    public void set_strengthY(){} // RVA: 0x7FFD54D79240
    public void get_strengthYMultiplier(){} // RVA: 0x7FFD54D792A0
    public void set_strengthYMultiplier(){} // RVA: 0x7FFD54D792F0
    public void get_strengthZ(){} // RVA: 0x7FFD54D79350
    public void set_strengthZ(){} // RVA: 0x7FFD54D793C0
    public void get_strengthZMultiplier(){} // RVA: 0x7FFD54D79420
    public void set_strengthZMultiplier(){} // RVA: 0x7FFD54D79470
    public void get_frequency(){} // RVA: 0x7FFD54D794D0
    public void set_frequency(){} // RVA: 0x7FFD54D79520
    public void get_damping(){} // RVA: 0x7FFD54D79580
    public void set_damping(){} // RVA: 0x7FFD54D795D0
    public void get_octaveCount(){} // RVA: 0x7FFD54D79630
    public void set_octaveCount(){} // RVA: 0x7FFD54D79680
    public void get_octaveMultiplier(){} // RVA: 0x7FFD54D796E0
    public void set_octaveMultiplier(){} // RVA: 0x7FFD54D79730
    public void get_octaveScale(){} // RVA: 0x7FFD54D79790
    public void set_octaveScale(){} // RVA: 0x7FFD54D797E0
    public void get_quality(){} // RVA: 0x7FFD54D79840
    public void set_quality(){} // RVA: 0x7FFD54D79890
    public void get_scrollSpeed(){} // RVA: 0x7FFD54D798F0
    public void set_scrollSpeed(){} // RVA: 0x7FFD54D79960
    public void get_scrollSpeedMultiplier(){} // RVA: 0x7FFD54D799C0
    public void set_scrollSpeedMultiplier(){} // RVA: 0x7FFD54D79A10
    public void get_remapEnabled(){} // RVA: 0x7FFD54D79A70
    public void set_remapEnabled(){} // RVA: 0x7FFD54D79AC0
    public void get_remap(){} // RVA: 0x7FFD54D79B20
    public void set_remap(){} // RVA: 0x7FFD54D79B90
    public void get_remapMultiplier(){} // RVA: 0x7FFD54D79BF0
    public void set_remapMultiplier(){} // RVA: 0x7FFD54D79C40
    public void get_remapX(){} // RVA: 0x7FFD54D79CA0
    public void set_remapX(){} // RVA: 0x7FFD54D79D10
    public void get_remapXMultiplier(){} // RVA: 0x7FFD54D79D70
    public void set_remapXMultiplier(){} // RVA: 0x7FFD54D79DC0
    public void get_remapY(){} // RVA: 0x7FFD54D79E20
    public void set_remapY(){} // RVA: 0x7FFD54D79E90
    public void get_remapYMultiplier(){} // RVA: 0x7FFD54D79EF0
    public void set_remapYMultiplier(){} // RVA: 0x7FFD54D79F40
    public void get_remapZ(){} // RVA: 0x7FFD54D79FA0
    public void set_remapZ(){} // RVA: 0x7FFD54D7A010
    public void get_remapZMultiplier(){} // RVA: 0x7FFD54D7A070
    public void set_remapZMultiplier(){} // RVA: 0x7FFD54D7A0C0
    public void get_positionAmount(){} // RVA: 0x7FFD54D7A120
    public void set_positionAmount(){} // RVA: 0x7FFD54D7A190
    public void get_rotationAmount(){} // RVA: 0x7FFD54D7A1F0
    public void set_rotationAmount(){} // RVA: 0x7FFD54D7A260
    public void get_sizeAmount(){} // RVA: 0x7FFD54D7A2C0
    public void set_sizeAmount(){} // RVA: 0x7FFD54D7A330
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D78D70
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D78DC0
    public void get_separateAxes_Injected(){} // RVA: 0x7FFD54D78E20
    public void set_separateAxes_Injected(){} // RVA: 0x7FFD54D78E70
    public void get_strength_Injected(){} // RVA: 0x7FFD54D7A390
    public void set_strength_Injected(){} // RVA: 0x7FFD54D7A3F0
    public void get_strengthMultiplier_Injected(){} // RVA: 0x7FFD54D78FA0
    public void set_strengthMultiplier_Injected(){} // RVA: 0x7FFD54D78FF0
    public void get_strengthX_Injected(){} // RVA: 0x7FFD54D7A450
    public void set_strengthX_Injected(){} // RVA: 0x7FFD54D7A4B0
    public void get_strengthXMultiplier_Injected(){} // RVA: 0x7FFD54D79120
    public void set_strengthXMultiplier_Injected(){} // RVA: 0x7FFD54D79170
    public void get_strengthY_Injected(){} // RVA: 0x7FFD54D7A510
    public void set_strengthY_Injected(){} // RVA: 0x7FFD54D7A570
    public void get_strengthYMultiplier_Injected(){} // RVA: 0x7FFD54D792A0
    public void set_strengthYMultiplier_Injected(){} // RVA: 0x7FFD54D792F0
    public void get_strengthZ_Injected(){} // RVA: 0x7FFD54D7A5D0
    public void set_strengthZ_Injected(){} // RVA: 0x7FFD54D7A630
    public void get_strengthZMultiplier_Injected(){} // RVA: 0x7FFD54D79420
    public void set_strengthZMultiplier_Injected(){} // RVA: 0x7FFD54D79470
    public void get_frequency_Injected(){} // RVA: 0x7FFD54D794D0
    public void set_frequency_Injected(){} // RVA: 0x7FFD54D79520
    public void get_damping_Injected(){} // RVA: 0x7FFD54D79580
    public void set_damping_Injected(){} // RVA: 0x7FFD54D795D0
    public void get_octaveCount_Injected(){} // RVA: 0x7FFD54D79630
    public void set_octaveCount_Injected(){} // RVA: 0x7FFD54D79680
    public void get_octaveMultiplier_Injected(){} // RVA: 0x7FFD54D796E0
    public void set_octaveMultiplier_Injected(){} // RVA: 0x7FFD54D79730
    public void get_octaveScale_Injected(){} // RVA: 0x7FFD54D79790
    public void set_octaveScale_Injected(){} // RVA: 0x7FFD54D797E0
    public void get_quality_Injected(){} // RVA: 0x7FFD54D79840
    public void set_quality_Injected(){} // RVA: 0x7FFD54D79890
    public void get_scrollSpeed_Injected(){} // RVA: 0x7FFD54D7A690
    public void set_scrollSpeed_Injected(){} // RVA: 0x7FFD54D7A6F0
    public void get_scrollSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D799C0
    public void set_scrollSpeedMultiplier_Injected(){} // RVA: 0x7FFD54D79A10
    public void get_remapEnabled_Injected(){} // RVA: 0x7FFD54D79A70
    public void set_remapEnabled_Injected(){} // RVA: 0x7FFD54D79AC0
    public void get_remap_Injected(){} // RVA: 0x7FFD54D7A750
    public void set_remap_Injected(){} // RVA: 0x7FFD54D7A7B0
    public void get_remapMultiplier_Injected(){} // RVA: 0x7FFD54D79BF0
    public void set_remapMultiplier_Injected(){} // RVA: 0x7FFD54D79C40
    public void get_remapX_Injected(){} // RVA: 0x7FFD54D7A810
    public void set_remapX_Injected(){} // RVA: 0x7FFD54D7A870
    public void get_remapXMultiplier_Injected(){} // RVA: 0x7FFD54D79D70
    public void set_remapXMultiplier_Injected(){} // RVA: 0x7FFD54D79DC0
    public void get_remapY_Injected(){} // RVA: 0x7FFD54D7A8D0
    public void set_remapY_Injected(){} // RVA: 0x7FFD54D7A930
    public void get_remapYMultiplier_Injected(){} // RVA: 0x7FFD54D79EF0
    public void set_remapYMultiplier_Injected(){} // RVA: 0x7FFD54D79F40
    public void get_remapZ_Injected(){} // RVA: 0x7FFD54D7A990
    public void set_remapZ_Injected(){} // RVA: 0x7FFD54D7A9F0
    public void get_remapZMultiplier_Injected(){} // RVA: 0x7FFD54D7A070
    public void set_remapZMultiplier_Injected(){} // RVA: 0x7FFD54D7A0C0
    public void get_positionAmount_Injected(){} // RVA: 0x7FFD54D7AA50
    public void set_positionAmount_Injected(){} // RVA: 0x7FFD54D7AAB0
    public void get_rotationAmount_Injected(){} // RVA: 0x7FFD54D7AB10
    public void set_rotationAmount_Injected(){} // RVA: 0x7FFD54D7AB70
    public void get_sizeAmount_Injected(){} // RVA: 0x7FFD54D7ABD0
    public void set_sizeAmount_Injected(){} // RVA: 0x7FFD54D7AC30
}

public class NoiseParams : ValueType
{
    public float Frequency; // 0x10
    public float Amplitude; // 0x14
    public bool Constant; // 0x18

    // ── Methods ──
    public void GetValueAt(){} // RVA: 0x7FFD4FC6D480
}

public class NoopDisposable : Object
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class NullDisposable : Object
{
    public System.IDisposable Instance;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFD4E341310
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void .cctor(){} // RVA: 0x7FFD5750D6C0
}

public class NullProgress`1 : Object
{
    public System.IProgress`1<T> Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Report(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class NullStream : Stream
{
    public System.Threading.Tasks.Task`1<int> CanRead;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A0A120
    public void get_CanRead(){} // RVA: 0x7FFD4E426850
    public void get_CanWrite(){} // RVA: 0x7FFD4E426850
    public void get_CanSeek(){} // RVA: 0x7FFD4E426850
    public void get_Length(){} // RVA: 0x7FFD4E919180
    public void get_Position(){} // RVA: 0x7FFD4E919180
    public void set_Position(){} // RVA: 0x7FFD4E341310
    public void CopyTo(){} // RVA: 0x7FFD53A0A170
    public void CopyToAsync(){} // RVA: 0x7FFD53A0A180
    public void Dispose(){} // RVA: 0x7FFD4E341310
    public void Flush(){} // RVA: 0x7FFD4E341310
    public void FlushAsync(){} // RVA: 0x7FFD53A0A290
    public void BeginRead(){} // RVA: 0x7FFD53A0A370
    public void EndRead(){} // RVA: 0x7FFD53A0A400
    public void BeginWrite(){} // RVA: 0x7FFD53A0A5A0
    public void EndWrite(){} // RVA: 0x7FFD53A0A630
    public void Read(){} // RVA: 0x7FFD4E919180 | overloaded x2
    public void ReadAsync(){} // RVA: 0x7FFD53A0A830 | overloaded x2
    public void ReadByte(){} // RVA: 0x7FFD4E6DD0E0
    public void Write(){} // RVA: 0x7FFD4E341310 | overloaded x2
    public void WriteAsync(){} // RVA: 0x7FFD53A0A9B0 | overloaded x2
    public void WriteByte(){} // RVA: 0x7FFD4E341310
    public void Seek(){} // RVA: 0x7FFD4E919180
    public void SetLength(){} // RVA: 0x7FFD4E341310
    public void .cctor(){} // RVA: 0x7FFD53A0AB20
}

public class NullStreamReader : StreamReader
{
    public object BaseStream;
    public object CurrentEncoding;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539E5D30
    public void get_BaseStream(){} // RVA: 0x7FFD539E5F10
    public void get_CurrentEncoding(){} // RVA: 0x7FFD539E5F70
    public void Dispose(){} // RVA: 0x7FFD4E341310
    public void Peek(){} // RVA: 0x7FFD4E6DD0E0
    public void Read(){} // RVA: 0x7FFD4E919180 | overloaded x2
    public void ReadLine(){} // RVA: 0x7FFD4E919180
    public void ReadToEnd(){} // RVA: 0x7FFD539E5F80
    public void ReadBuffer(){} // RVA: 0x7FFD4E919180
}

public class NullTextReader : TextReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539EFCE0
    public void Read(){} // RVA: 0x7FFD4E919180
    public void ReadLine(){} // RVA: 0x7FFD4E919180
}

public class NullTextWriter : TextWriter
{
    public object Encoding;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539F2900
    public void get_Encoding(){} // RVA: 0x7FFD539E5F70
    public void Write(){} // RVA: 0x7FFD4E341310 | overloaded x3
    public void WriteLine(){} // RVA: 0x7FFD4E341310 | overloaded x3
}

public class NumberBuffer : ValueType
{
    public int sign; // 0x10
    public int digits; // 0x14
    public int _sign; // 0x18
    public 0x66420788 _digits; // 0x1C
    public char* _allDigits; // 0x82

    // ── Methods ──
    public void get_sign(){} // RVA: 0x7FFD53A64870
    public void set_sign(){} // RVA: 0x7FFD53A64880
    public void get_digits(){} // RVA: 0x7FFD53A64890
}

public class NumberFormatEntryManaged : ValueType
{
    public int currency_decimal_digits; // 0x10
    public int currency_decimal_separator; // 0x14
    public int currency_group_separator; // 0x18
    public int currency_group_sizes0; // 0x1C
    public int currency_group_sizes1; // 0x20
    public int currency_negative_pattern; // 0x24
    public int currency_positive_pattern; // 0x28
    public int currency_symbol; // 0x2C
    public int nan_symbol; // 0x30
    public int negative_infinity_symbol; // 0x34
    public int negative_sign; // 0x38
    public int number_decimal_digits; // 0x3C
    public int number_decimal_separator; // 0x40
    public int number_group_separator; // 0x44
    public int number_group_sizes0; // 0x48
    public int number_group_sizes1; // 0x4C
    public int number_negative_pattern; // 0x50
    public int per_mille_symbol; // 0x54
    public int percent_negative_pattern; // 0x58
    public int percent_positive_pattern; // 0x5C
    public int percent_symbol; // 0x60
    public int positive_infinity_symbol; // 0x64
    public int positive_sign; // 0x68
}
