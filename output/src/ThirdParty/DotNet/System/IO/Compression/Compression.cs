// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Compression
// Classes: 34
// Methods: 410

namespace ThirdParty.DotNet.System.IO.Compression
{
    public class CheckSumAndSizeWriteStream : Stream
    {
        public System.IO.Stream Length; // 0x28
        public System.IO.Stream Position; // 0x30
        public long CanRead; // 0x38
        public uint CanSeek; // 0x40
        public bool CanWrite; // 0x44
        public bool _canWrite; // 0x45
        public bool _isDisposed; // 0x46
        public bool _everWritten; // 0x47
        public long _initialPosition; // 0x48
        public System.IO.Compression.ZipArchiveEntry _zipArchiveEntry; // 0x50
        public System.EventHandler _onClose; // 0x58
        public System.Action`6<long,long,uint,System.IO.Stream,System.IO.Compression.ZipArchiveEntry,System.EventHandler> _saveCrcAndSizes; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F8DEB0
        public void get_Length(){} // RVA: 0x7FFAC8F8E0D0
        public void get_Position(){} // RVA: 0x7FFAC8F8E130
        public void set_Position(){} // RVA: 0x7FFAC8F8E150
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC47BA6D0
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC8F8E1B0
        public void Read(){} // RVA: 0x7FFAC8F8E240
        public void Seek(){} // RVA: 0x7FFAC8F8E2A0
        public void SetLength(){} // RVA: 0x7FFAC8F8E300
        public void Write(){} // RVA: 0x7FFAC8F8E360
        public void Flush(){} // RVA: 0x7FFAC8F8E610
        public void Dispose(){} // RVA: 0x7FFAC8F8E650
    }

    public class CopyEncoder : Object
    {
        // ── Methods ──
        public void GetBlock(){} // RVA: 0x7FFAC8F7A4F0
        public void WriteLenNLen(){} // RVA: 0x7FFAC44E85D0
    }

    public class Crc32Helper : Object
    {
        public uint[] s_crcTable_0;
        public uint[] s_crcTable_1; // 0x8
        public uint[] s_crcTable_2; // 0x10
        public uint[] s_crcTable_3; // 0x18
        public uint[] s_crcTable_4; // 0x20
        public uint[] s_crcTable_5; // 0x28
        public uint[] s_crcTable_6; // 0x30
        public uint[] s_crcTable_7; // 0x38

        // ── Methods ──
        public void UpdateCrc32(){} // RVA: 0x7FFAC8F8F040
        public void ManagedCrc32(){} // RVA: 0x7FFAC8F8F0D0
        public void .cctor(){} // RVA: 0x7FFAC8F8F490
    }

    public class DeflateInput : Object
    {
        public byte[] Buffer; // 0x10
        public int Count; // 0x18
        public int StartIndex; // 0x1C

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFAC2F3C380
        public void set_Buffer(){} // RVA: 0x7FFAC2F22E30
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void set_Count(){} // RVA: 0x7FFAC392CD10
        public void get_StartIndex(){} // RVA: 0x7FFAC44357F0
        public void set_StartIndex(){} // RVA: 0x7FFAC44474D0
        public void ConsumeBytes(){} // RVA: 0x7FFAC44E8DD0
        public void DumpState(){} // RVA: 0x7FFAC44E8DF0
        public void RestoreState(){} // RVA: 0x7FFAC44E8DE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DeflateManagedStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public 0x6B1397E0 CanWrite; // 0x30
        public bool CanSeek; // 0x34
        public System.IO.Compression.InflaterManaged Length; // 0x38
        public System.IO.Compression.DeflaterManaged Position; // 0x40
        public byte[] _buffer; // 0x48
        public int _asyncOperations; // 0x50
        public System.IO.Compression.IFileFormatWriter _formatWriter; // 0x58
        public bool _wroteHeader; // 0x60
        public bool _wroteBytes; // 0x61

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F7A780
        public void InitializeInflater(){} // RVA: 0x7FFAC8F7A8E0
        public void get_CanRead(){} // RVA: 0x7FFAC44EA910
        public void get_CanWrite(){} // RVA: 0x7FFAC44EBC40
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC8F7AB10
        public void get_Position(){} // RVA: 0x7FFAC8F7AB60
        public void set_Position(){} // RVA: 0x7FFAC8F7ABB0
        public void Flush(){} // RVA: 0x7FFAC8F7AC00
        public void FlushAsync(){} // RVA: 0x7FFAC8F7AC20
        public void Seek(){} // RVA: 0x7FFAC8F7AD20
        public void SetLength(){} // RVA: 0x7FFAC8F7AD70
        public void Read(){} // RVA: 0x7FFAC8F7ADC0
        public void ValidateParameters(){} // RVA: 0x7FFAC8F7AFC0
        public void EnsureNotDisposed(){} // RVA: 0x7FFAC8F7AC00
        public void ThrowStreamClosedException(){} // RVA: 0x7FFAC8F7B120
        public void EnsureDecompressionMode(){} // RVA: 0x7FFAC8F7B180
        public void ThrowCannotReadFromDeflateManagedStreamException(){} // RVA: 0x7FFAC8F7B1A0
        public void EnsureCompressionMode(){} // RVA: 0x7FFAC8F7B1F0
        public void ThrowCannotWriteToDeflateManagedStreamException(){} // RVA: 0x7FFAC8F7B210
        public void BeginRead(){} // RVA: 0x7FFAC8F7B260
        public void EndRead(){} // RVA: 0x7FFAC8F7B310
        public void ReadAsync(){} // RVA: 0x7FFAC8F7B350
        public void ReadAsyncCore(){} // RVA: 0x7FFAC8F7B700
        public void Write(){} // RVA: 0x7FFAC8F7B9A0
        public void WriteDeflaterOutput(){} // RVA: 0x7FFAC8F7BB80
        public void DoMaintenance(){} // RVA: 0x7FFAC8F7BC10
        public void PurgeBuffers(){} // RVA: 0x7FFAC8F7BCF0
        public void Dispose(){} // RVA: 0x7FFAC8F7BF20
        public void WriteAsync(){} // RVA: 0x7FFAC8F7C2A0
        public void WriteAsyncCore(){} // RVA: 0x7FFAC8F7C430
        public void BeginWrite(){} // RVA: 0x7FFAC8F7C6C0
        public void EndWrite(){} // RVA: 0x7FFAC8F7C770
        public void <>n__0(){} // RVA: 0x7FFAC85F5E60
    }

    public class DeflateStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public 0x6B1397E0 CanSeek; // 0x30
        public bool CanWrite; // 0x34
        public bool Length; // 0x35
        public System.IO.Compression.DeflateStreamNative Position; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC945EB70 | overloaded x7
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void Dispose(){} // RVA: 0x7FFAC945EB90
        public void ReadInternal(){} // RVA: 0x7FFAC945EC50
        public void ReadAsyncMemory(){} // RVA: 0x7FFAC945ED60
        public void ReadCore(){} // RVA: 0x7FFAC945EDA0
        public void Read(){} // RVA: 0x7FFAC945EF30
        public void WriteInternal(){} // RVA: 0x7FFAC945F260
        public void WriteAsyncMemory(){} // RVA: 0x7FFAC945F360
        public void WriteCore(){} // RVA: 0x7FFAC945F3A0
        public void Write(){} // RVA: 0x7FFAC945F430
        public void Flush(){} // RVA: 0x7FFAC945F750
        public void BeginRead(){} // RVA: 0x7FFAC945F8D0
        public void BeginWrite(){} // RVA: 0x7FFAC945FCC0
        public void EndRead(){} // RVA: 0x7FFAC94600B0
        public void EndWrite(){} // RVA: 0x7FFAC94602A0
        public void Seek(){} // RVA: 0x7FFAC9460480
        public void SetLength(){} // RVA: 0x7FFAC94604C0
        public void get_CanRead(){} // RVA: 0x7FFAC9460500
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC9460540
        public void get_Length(){} // RVA: 0x7FFAC9460580
        public void get_Position(){} // RVA: 0x7FFAC94605C0
        public void set_Position(){} // RVA: 0x7FFAC9460600
    }

    public class DeflateStreamNative : Object
    {
        public UnmanagedReadOrWrite feeder; // 0x10
        public System.IO.Stream base_stream; // 0x18
        public SafeDeflateStreamHandle z_stream; // 0x20
        public System.Runtime.InteropServices.GCHandle data; // 0x28
        public bool disposed; // 0x30
        public byte[] io_buffer; // 0x38
        public System.Exception last_error; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC9460780
        public void Finalize(){} // RVA: 0x7FFAC9460A40
        public void Dispose(){} // RVA: 0x7FFAC9460A90
        public void Flush(){} // RVA: 0x7FFAC9461680 | overloaded x2
        public void ReadZStream(){} // RVA: 0x7FFAC9461720 | overloaded x2
        public void WriteZStream(){} // RVA: 0x7FFAC94617A0 | overloaded x2
        public void UnmanagedRead(){} // RVA: 0x7FFAC9461030 | overloaded x2
        public void UnmanagedWrite(){} // RVA: 0x7FFAC94612F0 | overloaded x2
        public void CheckResult(){} // RVA: 0x7FFAC9461470
        public void CreateZStream(){} // RVA: 0x7FFAC94615B0
        public void CloseZStream(){} // RVA: 0x7FFAC9461670
    }

    public class DeflaterManaged : Object
    {
        public System.IO.Compression.FastEncoder _deflateEncoder; // 0x10
        public System.IO.Compression.CopyEncoder _copyEncoder; // 0x18
        public System.IO.Compression.DeflateInput _input; // 0x20
        public System.IO.Compression.OutputBuffer _output; // 0x28
        public 0x6B2A52E0 _processingState; // 0x30
        public System.IO.Compression.DeflateInput _inputFromHistory; // 0x38

        // ── Methods ──
        public void NeedsInput(){} // RVA: 0x7FFAC44E99E0
        public void SetInput(){} // RVA: 0x7FFAC44E8E80
        public void GetDeflateOutput(){} // RVA: 0x7FFAC8F7D3D0
        public void Finish(){} // RVA: 0x7FFAC8F7D900
        public void UseCompressed(){} // RVA: 0x7FFAC44E9990
        public void FlushInputWindows(){} // RVA: 0x7FFAC8F7D9B0
        public void WriteFinal(){} // RVA: 0x7FFAC8F7D9D0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class FastEncoder : Object
    {
        public System.IO.Compression.FastEncoderWindow BytesInHistory; // 0x10
        public System.IO.Compression.Match UnprocessedInput; // 0x18
        public double LastCompressionRatio; // 0x20

        // ── Methods ──
        public void get_BytesInHistory(){} // RVA: 0x7FFAC44EE500
        public void get_UnprocessedInput(){} // RVA: 0x7FFAC8F7DA10
        public void FlushInput(){} // RVA: 0x7FFAC8F7DAD0
        public void get_LastCompressionRatio(){} // RVA: 0x7FFAC44ED560
        public void GetBlock(){} // RVA: 0x7FFAC8F7DC70
        public void GetCompressedData(){} // RVA: 0x7FFAC8F7DD50
        public void GetBlockHeader(){} // RVA: 0x7FFAC8F7DD70
        public void GetBlockFooter(){} // RVA: 0x7FFAC8F7DD80
        public void GetCompressedOutput(){} // RVA: 0x7FFAC8F7E080 | overloaded x2
        public void InputAvailable(){} // RVA: 0x7FFAC44EDB90
        public void SafeToWriteTo(){} // RVA: 0x7FFAC44EDF20
        public void WriteEndOfBlock(){} // RVA: 0x7FFAC8F7DD80
        public void WriteMatch(){} // RVA: 0x7FFAC8F7E160
        public void WriteChar(){} // RVA: 0x7FFAC8F7E3E0
        public void WriteDeflatePreamble(){} // RVA: 0x7FFAC8F7E480
    }

    public class FastEncoderStatics : Object
    {
        public byte[] FastEncoderTreeStructureData;
        public byte[] BFinalFastEncoderTreeStructureData; // 0x8
        public uint[] FastEncoderLiteralCodeInfo; // 0x10
        public uint[] FastEncoderDistanceCodeInfo; // 0x18
        public uint[] BitMask; // 0x20
        public byte[] ExtraLengthBits; // 0x28
        public byte[] ExtraDistanceBits; // 0x30
        public byte[] s_distLookup; // 0x38

        // ── Methods ──
        public void CreateDistanceLookup(){} // RVA: 0x7FFAC8F7E520
        public void GetSlot(){} // RVA: 0x7FFAC8F7E6A0
        public void BitReverse(){} // RVA: 0x7FFAC44EEC20
        public void .cctor(){} // RVA: 0x7FFAC8F7E730
    }

    public class FastEncoderWindow : Object
    {
        public byte[] BytesAvailable; // 0x10
        public int UnprocessedInput; // 0x18
        public int FreeWindowSpace; // 0x1C
        public ushort[] _prev; // 0x20
        public ushort[] _lookup; // 0x28

        // ── Methods ──
        public void get_BytesAvailable(){} // RVA: 0x7FFAC44EF380
        public void get_UnprocessedInput(){} // RVA: 0x7FFAC8F7EDF0
        public void FlushWindow(){} // RVA: 0x7FFAC8F7EEB0
        public void ResetWindow(){} // RVA: 0x7FFAC8F7EEB0
        public void get_FreeWindowSpace(){} // RVA: 0x7FFAC44EF7D0
        public void CopyBytes(){} // RVA: 0x7FFAC44EF8A0
        public void MoveWindows(){} // RVA: 0x7FFAC44EF210
        public void HashValue(){} // RVA: 0x7FFAC44EF7E0
        public void InsertString(){} // RVA: 0x7FFAC44EF170
        public void InsertStrings(){} // RVA: 0x7FFAC44EF700
        public void GetNextSymbolOrMatch(){} // RVA: 0x7FFAC8F7F040
        public void FindMatch(){} // RVA: 0x7FFAC44EF390
    }

    public class GZipStream : Stream
    {
        public System.IO.Compression.DeflateStream CanRead; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC945DB00 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFAC945DC00
        public void get_CanWrite(){} // RVA: 0x7FFAC945DC20
        public void get_CanSeek(){} // RVA: 0x7FFAC945DC40
        public void get_Length(){} // RVA: 0x7FFAC945DC60
        public void get_Position(){} // RVA: 0x7FFAC945DCB0
        public void set_Position(){} // RVA: 0x7FFAC945DD00
        public void Flush(){} // RVA: 0x7FFAC945DD50
        public void Seek(){} // RVA: 0x7FFAC945DD80
        public void SetLength(){} // RVA: 0x7FFAC945DDD0
        public void ReadByte(){} // RVA: 0x7FFAC945DE20
        public void BeginRead(){} // RVA: 0x7FFAC945DE50
        public void EndRead(){} // RVA: 0x7FFAC945DF00
        public void Read(){} // RVA: 0x7FFAC945DF80 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFAC945E200
        public void EndWrite(){} // RVA: 0x7FFAC84062A0
        public void Write(){} // RVA: 0x7FFAC945E2F0 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAC945E480
        public void Dispose(){} // RVA: 0x7FFAC44F2320
        public void ReadAsync(){} // RVA: 0x7FFAC945E4F0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAC945E670 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFAC945E7B0
        public void CopyToAsync(){} // RVA: 0x7FFAC945E7E0
        public void CheckDeflateStream(){} // RVA: 0x7FFAC945E820
        public void ThrowStreamClosedException(){} // RVA: 0x7FFAC945E840
    }

    public class HuffmanTree : Object
    {
        public int StaticLiteralLengthTree; // 0x10
        public short[] StaticDistanceTree; // 0x18
        public short[] _left; // 0x20
        public short[] _right; // 0x28
        public byte[] _codeLengthArray; // 0x30
        public int _tableMask; // 0x38
        public System.IO.Compression.HuffmanTree <StaticLiteralLengthTree>k__BackingField;
        public System.IO.Compression.HuffmanTree <StaticDistanceTree>k__BackingField; // 0x8

        // ── Methods ──
        public void get_StaticLiteralLengthTree(){} // RVA: 0x7FFAC8F7F450
        public void get_StaticDistanceTree(){} // RVA: 0x7FFAC8F7F4B0
        public void .ctor(){} // RVA: 0x7FFAC8F7F510
        public void GetStaticLiteralTreeLength(){} // RVA: 0x7FFAC8F7F730
        public void GetStaticDistanceTreeLength(){} // RVA: 0x7FFAC8F7F800
        public void CalculateHuffmanCode(){} // RVA: 0x7FFAC8F7F870
        public void CreateTable(){} // RVA: 0x7FFAC8F7FA80
        public void GetNextSymbol(){} // RVA: 0x7FFAC8F7FCF0
        public void .cctor(){} // RVA: 0x7FFAC8F7FED0
    }

    public class IFileFormatReader
    {
        // ── Methods ──
        public void ReadHeader(){} // RVA: 0x7FFAC2C59F60
        public void ReadFooter(){} // RVA: 0x7FFAC2C59F60
        public void UpdateWithBytesRead(){}
        public void Validate(){} // RVA: 0x7FFAC2C70980
    }

    public class IFileFormatWriter
    {
        // ── Methods ──
        public void GetHeader(){} // RVA: 0x7FFAC2C58E90
        public void UpdateWithBytesRead(){}
        public void GetFooter(){} // RVA: 0x7FFAC2C58E90
    }

    public class InflaterManaged : Object
    {
        public byte[] s_extraLengthBits;
        public int[] s_lengthBase; // 0x8
        public int[] s_distanceBasePosition; // 0x10
        public byte[] s_codeOrder; // 0x18
        public byte[] s_staticDistanceTreeTable; // 0x20
        public System.IO.Compression.OutputWindow _output; // 0x10
        public System.IO.Compression.InputBuffer _input; // 0x18
        public System.IO.Compression.HuffmanTree _literalLengthTree; // 0x20
        public System.IO.Compression.HuffmanTree _distanceTree; // 0x28
        public 0x6B2A55F8 _state; // 0x30
        public bool _hasFormatReader; // 0x34
        public int _bfinal; // 0x38
        public 0x6B2A5078 _blockType; // 0x3C
        public byte[] _blockLengthBuffer; // 0x40
        public int _blockLength; // 0x48
        public int _length; // 0x4C
        public int _distanceCode; // 0x50
        public int _extraBits; // 0x54
        public int _loopCounter; // 0x58
        public int _literalLengthCodeCount; // 0x5C
        public int _distanceCodeCount; // 0x60
        public int _codeLengthCodeCount; // 0x64
        public int _codeArraySize; // 0x68
        public int _lengthCode; // 0x6C
        public byte[] _codeList; // 0x70
        public byte[] _codeLengthTreeCodeLength; // 0x78
        public bool _deflate64; // 0x80
        public System.IO.Compression.HuffmanTree _codeLengthTree; // 0x88
        public System.IO.Compression.IFileFormatReader _formatReader; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F80170
        public void Reset(){} // RVA: 0x7FFAC8F804C0
        public void SetInput(){} // RVA: 0x7FFAC44F4DF0
        public void Finished(){} // RVA: 0x7FFAC44F46E0
        public void Inflate(){} // RVA: 0x7FFAC8F804E0
        public void Decode(){} // RVA: 0x7FFAC8F80700
        public void DecodeUncompressedBlock(){} // RVA: 0x7FFAC8F80A80
        public void DecodeBlock(){} // RVA: 0x7FFAC8F80D10
        public void DecodeDynamicBlockHeader(){} // RVA: 0x7FFAC8F811B0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8F81A40
    }

    public class InputBuffer : Object
    {
        public byte[] AvailableBits; // 0x10
        public int AvailableBytes; // 0x18
        public int _end; // 0x1C
        public uint _bitBuffer; // 0x20
        public int _bitsInBuffer; // 0x24

        // ── Methods ──
        public void get_AvailableBits(){} // RVA: 0x7FFAC3921980
        public void get_AvailableBytes(){} // RVA: 0x7FFAC44F73D0
        public void EnsureBitsAvailable(){} // RVA: 0x7FFAC44F7030
        public void TryLoad16Bits(){} // RVA: 0x7FFAC44F73F0
        public void GetBitMask(){} // RVA: 0x7FFAC44F7250
        public void GetBits(){} // RVA: 0x7FFAC44F71F0
        public void CopyTo(){} // RVA: 0x7FFAC44F7270
        public void NeedsInput(){} // RVA: 0x7FFAC44F7260
        public void SetInput(){} // RVA: 0x7FFAC44F7180
        public void SkipBits(){} // RVA: 0x7FFAC44F7330
        public void SkipToByteBoundary(){} // RVA: 0x7FFAC44F74B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Match : Object
    {
        public 0x6B2A5700 State; // 0x10
        public int Position; // 0x14
        public int Length; // 0x18
        public byte Symbol; // 0x1C

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC2F6E5C0
        public void set_State(){} // RVA: 0x7FFAC2F240C0
        public void get_Position(){} // RVA: 0x7FFAC33D5A20
        public void set_Position(){} // RVA: 0x7FFAC33D4990
        public void get_Length(){} // RVA: 0x7FFAC3157800
        public void set_Length(){} // RVA: 0x7FFAC392CD10
        public void get_Symbol(){} // RVA: 0x7FFAC2F3C390
        public void set_Symbol(){} // RVA: 0x7FFAC2F3C3A0
    }

    public class OutputBuffer : Object
    {
        public byte[] BytesWritten; // 0x10
        public int FreeBytes; // 0x18
        public uint BitsInBuffer; // 0x1C
        public int _bitCount; // 0x20

        // ── Methods ──
        public void UpdateBuffer(){} // RVA: 0x7FFAC44F7620
        public void get_BytesWritten(){} // RVA: 0x7FFAC3157800
        public void get_FreeBytes(){} // RVA: 0x7FFAC44F7600
        public void WriteUInt16(){} // RVA: 0x7FFAC44F7790
        public void WriteBits(){} // RVA: 0x7FFAC44F7810
        public void FlushBits(){} // RVA: 0x7FFAC44F76D0
        public void WriteBytes(){} // RVA: 0x7FFAC44F79C0
        public void WriteBytesUnaligned(){} // RVA: 0x7FFAC44F78A0
        public void WriteByteUnaligned(){} // RVA: 0x7FFAC44F7770
        public void get_BitsInBuffer(){} // RVA: 0x7FFAC44F7760
        public void DumpState(){} // RVA: 0x7FFAC44F77F0
        public void RestoreState(){} // RVA: 0x7FFAC44F7690
    }

    public class OutputWindow : Object
    {
        public byte[] FreeBytes; // 0x10
        public int AvailableBytes; // 0x18
        public int _bytesUsed; // 0x1C

        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC8F81DD0
        public void WriteLengthDistance(){} // RVA: 0x7FFAC8F81E10
        public void CopyFrom(){} // RVA: 0x7FFAC8F81F50
        public void get_FreeBytes(){} // RVA: 0x7FFAC8F821D0
        public void get_AvailableBytes(){} // RVA: 0x7FFAC44357F0
        public void CopyTo(){} // RVA: 0x7FFAC8F821E0
        public void .ctor(){} // RVA: 0x7FFAC8F822A0
    }

    public class PositionPreservingWriteOnlyStreamWrapper : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public long CanSeek; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F82330
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void get_Position(){} // RVA: 0x7FFAC31D95E0
        public void set_Position(){} // RVA: 0x7FFAC8F823D0
        public void Write(){} // RVA: 0x7FFAC8F82420
        public void BeginWrite(){} // RVA: 0x7FFAC8F82460
        public void EndWrite(){} // RVA: 0x7FFAC8F824A0
        public void WriteByte(){} // RVA: 0x7FFAC8F824D0
        public void WriteAsync(){} // RVA: 0x7FFAC8F82500
        public void get_CanTimeout(){} // RVA: 0x7FFAC8E25690
        public void get_ReadTimeout(){} // RVA: 0x7FFAC8E257D0
        public void set_ReadTimeout(){} // RVA: 0x7FFAC8E25800
        public void get_WriteTimeout(){} // RVA: 0x7FFAC8E25830
        public void set_WriteTimeout(){} // RVA: 0x7FFAC8E25860
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void FlushAsync(){} // RVA: 0x7FFAC8F82540
        public void Close(){} // RVA: 0x7FFAC8F82570
        public void Dispose(){} // RVA: 0x7FFAC8F825A0
        public void get_Length(){} // RVA: 0x7FFAC8F825E0
        public void Seek(){} // RVA: 0x7FFAC8F82630
        public void SetLength(){} // RVA: 0x7FFAC8F82680
        public void Read(){} // RVA: 0x7FFAC8F826D0
    }

    public class SubReadStream : Stream
    {
        public long Length; // 0x28
        public long Position; // 0x30
        public long CanRead; // 0x38
        public System.IO.Stream CanSeek; // 0x40
        public bool CanWrite; // 0x48
        public bool _isDisposed; // 0x49

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F8D910
        public void get_Length(){} // RVA: 0x7FFAC8F8D9E0
        public void get_Position(){} // RVA: 0x7FFAC8F8DA00
        public void set_Position(){} // RVA: 0x7FFAC8F8DA20
        public void get_CanRead(){} // RVA: 0x7FFAC8F8DA80
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC8F8DAC0
        public void ThrowIfCantRead(){} // RVA: 0x7FFAC8F8DB50
        public void Read(){} // RVA: 0x7FFAC8F8DBD0
        public void Seek(){} // RVA: 0x7FFAC8F8DD10
        public void SetLength(){} // RVA: 0x7FFAC8F8DD70
        public void Write(){} // RVA: 0x7FFAC8F8DDD0
        public void Flush(){} // RVA: 0x7FFAC8F8DE30
        public void Dispose(){} // RVA: 0x7FFAC8F8DE90
    }

    public class WrappedStream : Stream
    {
        public System.IO.Stream Length; // 0x28
        public bool Position; // 0x30
        public System.Action`1<System.IO.Compression.ZipArchiveEntry> CanRead; // 0x38
        public System.IO.Compression.ZipArchiveEntry CanSeek; // 0x40
        public bool CanWrite; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F8D260 | overloaded x3
        public void get_Length(){} // RVA: 0x7FFAC8F8D290
        public void get_Position(){} // RVA: 0x7FFAC8F8D2D0
        public void set_Position(){} // RVA: 0x7FFAC8F8D310
        public void get_CanRead(){} // RVA: 0x7FFAC8F8D370
        public void get_CanSeek(){} // RVA: 0x7FFAC8F8D3B0
        public void get_CanWrite(){} // RVA: 0x7FFAC8F8D3F0
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC8F8D430
        public void ThrowIfCantRead(){} // RVA: 0x7FFAC8F8D4C0
        public void ThrowIfCantWrite(){} // RVA: 0x7FFAC8F8D540
        public void ThrowIfCantSeek(){} // RVA: 0x7FFAC8F8D5C0
        public void Read(){} // RVA: 0x7FFAC8F8D640
        public void Seek(){} // RVA: 0x7FFAC8F8D710
        public void SetLength(){} // RVA: 0x7FFAC8F8D780
        public void Write(){} // RVA: 0x7FFAC8F8D7E0
        public void Flush(){} // RVA: 0x7FFAC8F8D860
        public void Dispose(){} // RVA: 0x7FFAC8F8D8B0
    }

    public class Zip64EndOfCentralDirectoryLocator : ValueType
    {
        public uint NumberOfDiskWithZip64EOCD; // 0x10
        public ulong OffsetOfZip64EOCD; // 0x18
        public uint TotalNumberOfDisks; // 0x20

        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFAC8F8BBA0
        public void WriteBlock(){} // RVA: 0x7FFAC8F8BC50
    }

    public class Zip64EndOfCentralDirectoryRecord : ValueType
    {
        public ulong SizeOfThisRecord; // 0x10
        public ushort VersionMadeBy; // 0x18
        public ushort VersionNeededToExtract; // 0x1A
        public uint NumberOfThisDisk; // 0x1C
        public uint NumberOfDiskWithStartOfCD; // 0x20
        public ulong NumberOfEntriesOnThisDisk; // 0x28
        public ulong NumberOfEntriesTotal; // 0x30
        public ulong SizeOfCentralDirectory; // 0x38
        public ulong OffsetOfCentralDirectory; // 0x40

        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFAC8F8BD30
        public void WriteBlock(){} // RVA: 0x7FFAC8F8BE90
    }

    public class Zip64ExtraField : ValueType
    {
        public ushort TotalSize; // 0x10
        public System.Nullable`1<long> UncompressedSize; // 0x18
        public System.Nullable`1<long> CompressedSize; // 0x28
        public System.Nullable`1<long> LocalHeaderOffset; // 0x38
        public System.Nullable`1<int> StartDiskNumber; // 0x48

        // ── Methods ──
        public void get_TotalSize(){} // RVA: 0x7FFAC8F8A6E0
        public void get_UncompressedSize(){} // RVA: 0x7FFAC4A927D0
        public void set_UncompressedSize(){} // RVA: 0x7FFAC8F8A6F0
        public void get_CompressedSize(){} // RVA: 0x7FFAC35D3330
        public void set_CompressedSize(){} // RVA: 0x7FFAC8F8A700
        public void get_LocalHeaderOffset(){} // RVA: 0x7FFAC3BCF020
        public void set_LocalHeaderOffset(){} // RVA: 0x7FFAC8F8A710
        public void get_StartDiskNumber(){} // RVA: 0x7FFAC31D0140
        public void UpdateSize(){} // RVA: 0x7FFAC8F8A720
        public void GetJustZip64Block(){} // RVA: 0x7FFAC8F8A790
        public void TryGetZip64BlockFromGenericExtraField(){} // RVA: 0x7FFAC8F8A9F0
        public void GetAndRemoveZip64Block(){} // RVA: 0x7FFAC8F8AF80
        public void RemoveZip64Blocks(){} // RVA: 0x7FFAC8F8B530
        public void WriteBlock(){} // RVA: 0x7FFAC8F8BA30
    }

    public class ZipArchive : Object
    {
        public System.IO.Stream Mode; // 0x10
        public System.IO.Compression.ZipArchiveEntry ArchiveReader; // 0x18
        public System.IO.BinaryReader ArchiveStream; // 0x20
        public 0x6B2A5AC8 NumberOfThisDisk; // 0x28
        public System.Collections.Generic.List`1<System.IO.Compression.ZipArchiveEntry> EntryNameEncoding; // 0x30
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.IO.Compression.ZipArchiveEntry> _entriesCollection; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.IO.Compression.ZipArchiveEntry> _entriesDictionary; // 0x40
        public bool _readEntries; // 0x48
        public bool _leaveOpen; // 0x49
        public long _centralDirectoryStart; // 0x50
        public bool _isDisposed; // 0x58
        public uint _numberOfThisDisk; // 0x5C
        public long _expectedNumberOfEntries; // 0x60
        public System.IO.Stream _backingStream; // 0x68
        public byte[] _archiveComment; // 0x70
        public System.Text.Encoding _entryNameEncoding; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F827F0 | overloaded x2
        public void get_Mode(){} // RVA: 0x7FFAC32EC4C0
        public void CreateEntry(){} // RVA: 0x7FFAC8F829B0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC8F82B50 | overloaded x2
        public void get_ArchiveReader(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ArchiveStream(){} // RVA: 0x7FFAC2F3C380
        public void get_NumberOfThisDisk(){} // RVA: 0x7FFAC313CBA0
        public void get_EntryNameEncoding(){} // RVA: 0x7FFAC30E5600
        public void set_EntryNameEncoding(){} // RVA: 0x7FFAC8F82BC0
        public void DoCreateEntry(){} // RVA: 0x7FFAC8F82CD0
        public void AcquireArchiveStream(){} // RVA: 0x7FFAC8F82EE0
        public void AddEntry(){} // RVA: 0x7FFAC8F83000
        public void ReleaseArchiveStream(){} // RVA: 0x7FFAC515CC20
        public void RemoveEntry(){} // RVA: 0x7FFAC8F83100
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC8F83190
        public void CloseStreams(){} // RVA: 0x7FFAC8F83220
        public void EnsureCentralDirectoryRead(){} // RVA: 0x7FFAC8F832C0
        public void Init(){} // RVA: 0x7FFAC8F832E0
        public void ReadCentralDirectory(){} // RVA: 0x7FFAC8F83D40
        public void ReadEndOfCentralDirectory(){} // RVA: 0x7FFAC8F83FD0
        public void WriteFile(){} // RVA: 0x7FFAC8F84750
        public void WriteArchiveEpilogue(){} // RVA: 0x7FFAC8F84EA0
    }

    public class ZipArchiveEntry : Object
    {
        public System.IO.Compression.ZipArchive FullName; // 0x10
        public bool LastWriteTime; // 0x18
        public int EverOpenedForWrite; // 0x1C
        public 0x6B2A5F40 OffsetOfCompressedData; // 0x20
        public 0x6B2A5EE8 UncompressedData; // 0x22
        public 0x6B2A5EE8 CompressionMethod; // 0x24
        public 0x6B2A5968 _generalPurposeBitFlag; // 0x26
        public 0x6B2A59C0 _storedCompressionMethod; // 0x28
        public System.DateTimeOffset _lastModified; // 0x30
        public long _compressedSize; // 0x40
        public long _uncompressedSize; // 0x48
        public long _offsetOfLocalHeader; // 0x50
        public System.Nullable`1<long> _storedOffsetOfCompressedData; // 0x58
        public uint _crc32; // 0x68
        public byte[][] _compressedBytes; // 0x70
        public System.IO.MemoryStream _storedUncompressedData; // 0x78
        public bool _currentlyOpenForWrite; // 0x80
        public bool _everOpenedForWrite; // 0x81
        public System.IO.Stream _outstandingWriteStream; // 0x88
        public uint _externalFileAttr; // 0x90
        public string _storedEntryName; // 0x98
        public byte[] _storedEntryNameBytes; // 0xA0
        public System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField> _cdUnknownExtraFields; // 0xA8
        public System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField> _lhUnknownExtraFields; // 0xB0
        public byte[] _fileComment; // 0xB8
        public System.Nullable`1<0x6B139788> _compressionLevel; // 0xC0
        public bool s_allowLargeZipArchiveEntriesInUpdateMode;
        public 0x6B2A5F40 CurrentZipPlatform; // 0x1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F85570 | overloaded x3
        public void get_FullName(){} // RVA: 0x7FFAC354DFB0
        public void set_FullName(){} // RVA: 0x7FFAC8F85AE0
        public void set_LastWriteTime(){} // RVA: 0x7FFAC8F85DD0
        public void Delete(){} // RVA: 0x7FFAC8F86090
        public void Open(){} // RVA: 0x7FFAC8F86210
        public void ToString(){} // RVA: 0x7FFAC354DFB0
        public void get_EverOpenedForWrite(){} // RVA: 0x7FFAC313DE70
        public void get_OffsetOfCompressedData(){} // RVA: 0x7FFAC8F86270
        public void get_UncompressedData(){} // RVA: 0x7FFAC8F863D0
        public void get_CompressionMethod(){} // RVA: 0x7FFAC6D6E100
        public void set_CompressionMethod(){} // RVA: 0x7FFAC8F865E0
        public void DecodeEntryName(){} // RVA: 0x7FFAC8F86630
        public void EncodeEntryName(){} // RVA: 0x7FFAC8F86690
        public void WriteAndFinishLocalEntry(){} // RVA: 0x7FFAC8F867C0
        public void WriteCentralDirectoryFileHeader(){} // RVA: 0x7FFAC8F86810
        public void LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded(){} // RVA: 0x7FFAC8F86E70
        public void ThrowIfNotOpenable(){} // RVA: 0x7FFAC8F873B0
        public void GetDataCompressor(){} // RVA: 0x7FFAC8F87430
        public void GetDataDecompressor(){} // RVA: 0x7FFAC8F87710
        public void OpenInReadMode(){} // RVA: 0x7FFAC8F87910
        public void OpenInWriteMode(){} // RVA: 0x7FFAC8F879E0
        public void OpenInUpdateMode(){} // RVA: 0x7FFAC8F87CB0
        public void IsOpenable(){} // RVA: 0x7FFAC8F87F00
        public void SizesTooLarge(){} // RVA: 0x7FFAC8F88270
        public void WriteLocalFileHeader(){} // RVA: 0x7FFAC8F88290
        public void WriteLocalFileHeaderAndDataIfNeeded(){} // RVA: 0x7FFAC8F887E0
        public void WriteCrcAndSizesInLocalHeader(){} // RVA: 0x7FFAC8F88AC0
        public void WriteDataDescriptor(){} // RVA: 0x7FFAC8F88E30
        public void UnloadStreams(){} // RVA: 0x7FFAC8F88F70
        public void CloseStreams(){} // RVA: 0x7FFAC8F89060
        public void VersionToExtractAtLeast(){} // RVA: 0x7FFAC8F89090
        public void ThrowIfInvalidArchive(){} // RVA: 0x7FFAC8F890B0
        public void GetFileName_Windows(){} // RVA: 0x7FFAC8F89120
        public void GetFileName_Unix(){} // RVA: 0x7FFAC8F891A0
        public void ParseFileName(){} // RVA: 0x7FFAC8F89210
        public void .cctor(){} // RVA: 0x7FFAC8F89380
    }

    public class ZipCentralDirectoryFileHeader : ValueType
    {
        public byte VersionMadeByCompatibility; // 0x10
        public byte VersionMadeBySpecification; // 0x11
        public ushort VersionNeededToExtract; // 0x12
        public ushort GeneralPurposeBitFlag; // 0x14
        public ushort CompressionMethod; // 0x16
        public uint LastModified; // 0x18
        public uint Crc32; // 0x1C
        public long CompressedSize; // 0x20
        public long UncompressedSize; // 0x28
        public ushort FilenameLength; // 0x30
        public ushort ExtraFieldLength; // 0x32
        public ushort FileCommentLength; // 0x34
        public int DiskNumberStart; // 0x38
        public ushort InternalFileAttributes; // 0x3C
        public uint ExternalFileAttributes; // 0x40
        public long RelativeOffsetOfLocalHeader; // 0x48
        public byte[] Filename; // 0x50
        public byte[] FileComment; // 0x58
        public System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField> ExtraFields; // 0x60

        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFAC8F8C460
    }

    public class ZipEndOfCentralDirectoryBlock : ValueType
    {
        public uint Signature; // 0x10
        public ushort NumberOfThisDisk; // 0x14
        public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory; // 0x16
        public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk; // 0x18
        public ushort NumberOfEntriesInTheCentralDirectory; // 0x1A
        public uint SizeOfCentralDirectory; // 0x1C
        public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber; // 0x20
        public byte[] ArchiveComment; // 0x28

        // ── Methods ──
        public void WriteBlock(){} // RVA: 0x7FFAC8F8CD90
        public void TryReadBlock(){} // RVA: 0x7FFAC8F8CF40
    }

    public class ZipFileExtensions : Object
    {
        // ── Methods ──
        public void CreateEntryFromFile(){} // RVA: 0x7FFAC8F8FF00
        public void DoCreateEntryFromFile(){} // RVA: 0x7FFAC8F8FF20
    }

    public class ZipGenericExtraField : ValueType
    {
        public ushort Tag; // 0x10
        public ushort Size; // 0x12
        public byte[] Data; // 0x18

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC4AC85D0
        public void get_Size(){} // RVA: 0x7FFAC4AC85E0
        public void get_Data(){} // RVA: 0x7FFAC4420220
        public void WriteBlock(){} // RVA: 0x7FFAC8F89EE0
        public void TryReadBlock(){} // RVA: 0x7FFAC8F89FA0
        public void ParseExtraField(){} // RVA: 0x7FFAC8F8A110
        public void TotalSize(){} // RVA: 0x7FFAC8F8A380
        public void WriteAllBlocks(){} // RVA: 0x7FFAC8F8A4E0
    }

    public class ZipHelper : Object
    {
        public System.DateTime s_invalidDateIndicator;

        // ── Methods ──
        public void RequiresUnicode(){} // RVA: 0x7FFAC8F8E740
        public void ReadBytes(){} // RVA: 0x7FFAC8F8E7A0
        public void DosTimeToDateTime(){} // RVA: 0x7FFAC8F8E870
        public void DateTimeToDosTime(){} // RVA: 0x7FFAC8F8E920
        public void SeekBackwardsToSignature(){} // RVA: 0x7FFAC8F8EAB0
        public void AdvanceToPosition(){} // RVA: 0x7FFAC8F8ED10
        public void SeekBackwardsAndRead(){} // RVA: 0x7FFAC8F8EE10
        public void .cctor(){} // RVA: 0x7FFAC8F8EFA0
    }

    public class ZipLocalFileHeader : ValueType
    {
        // ── Methods ──
        public void GetExtraFields(){} // RVA: 0x7FFAC8F8C020
        public void TrySkipBlock(){} // RVA: 0x7FFAC8F8C250
    }

}