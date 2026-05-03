// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Compression
// Classes: 34
// Methods: 410

namespace ThirdParty.DotNet.System.IO.Compression
{
    public class CheckSumAndSizeWriteStream : Stream
    {
        public System.IO.Stream _baseStream; // 0x28
        public System.IO.Stream _baseBaseStream; // 0x30
        public long _position; // 0x38
        public uint _checksum; // 0x40
        public bool _leaveOpenOnClose; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873362D0
        public void get_Length(){} // RVA: 0x7FFE873364F0
        public void get_Position(){} // RVA: 0x7FFE87336550
        public void set_Position(){} // RVA: 0x7FFE87336570
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE82A22A70
        public void ThrowIfDisposed(){} // RVA: 0x7FFE873365D0
        public void Read(){} // RVA: 0x7FFE87336660
        public void Seek(){} // RVA: 0x7FFE873366C0
        public void SetLength(){} // RVA: 0x7FFE87336720
        public void Write(){} // RVA: 0x7FFE87336780
        public void Flush(){} // RVA: 0x7FFE87336A30
        public void Dispose(){} // RVA: 0x7FFE87336A70
    }

    public class CopyEncoder : Object
    {
        // ── Methods ──
        public void GetBlock(){} // RVA: 0x7FFE87322940
        public void WriteLenNLen(){} // RVA: 0x7FFE827B6610
    }

    public class Crc32Helper : Object
    {
        // ── Methods ──
        public void UpdateCrc32(){} // RVA: 0x7FFE87337460
        public void ManagedCrc32(){} // RVA: 0x7FFE873374F0
        public void .cctor(){} // RVA: 0x7FFE873378B0
    }

    public class DeflateInput : Object
    {
        public byte[] _buffer; // 0x10
        public int _count; // 0x18
        public int _startIndex; // 0x1C

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFE81116380
        public void set_Buffer(){} // RVA: 0x7FFE810FCE30
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void set_Count(){} // RVA: 0x7FFE8144DF00
        public void get_StartIndex(){} // RVA: 0x7FFE82707EE0
        public void set_StartIndex(){} // RVA: 0x7FFE82717690
        public void ConsumeBytes(){} // RVA: 0x7FFE827B7070
        public void DumpState(){} // RVA: 0x7FFE827B7050
        public void RestoreState(){} // RVA: 0x7FFE827B7080
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DeflateManagedStream : Stream
    {
        public System.IO.Stream _stream; // 0x28
        public 0x66532704 _mode; // 0x30
        public bool _leaveOpen; // 0x34
        public System.IO.Compression.InflaterManaged _inflater; // 0x38
        public System.IO.Compression.DeflaterManaged _deflater; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87322BD0
        public void InitializeInflater(){} // RVA: 0x7FFE87322D30
        public void get_CanRead(){} // RVA: 0x7FFE827BAAA0
        public void get_CanWrite(){} // RVA: 0x7FFE827B9BF0
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE87322F60
        public void get_Position(){} // RVA: 0x7FFE87322FB0
        public void set_Position(){} // RVA: 0x7FFE87323000
        public void Flush(){} // RVA: 0x7FFE87323050
        public void FlushAsync(){} // RVA: 0x7FFE87323070
        public void Seek(){} // RVA: 0x7FFE87323170
        public void SetLength(){} // RVA: 0x7FFE873231C0
        public void Read(){} // RVA: 0x7FFE87323210
        public void ValidateParameters(){} // RVA: 0x7FFE87323410
        public void EnsureNotDisposed(){} // RVA: 0x7FFE87323050
        public void ThrowStreamClosedException(){} // RVA: 0x7FFE87323570
        public void EnsureDecompressionMode(){} // RVA: 0x7FFE873235D0
        public void ThrowCannotReadFromDeflateManagedStreamException(){} // RVA: 0x7FFE873235F0
        public void EnsureCompressionMode(){} // RVA: 0x7FFE87323640
        public void ThrowCannotWriteToDeflateManagedStreamException(){} // RVA: 0x7FFE87323660
        public void BeginRead(){} // RVA: 0x7FFE873236B0
        public void EndRead(){} // RVA: 0x7FFE87323760
        public void ReadAsync(){} // RVA: 0x7FFE873237A0
        public void ReadAsyncCore(){} // RVA: 0x7FFE87323B50
        public void Write(){} // RVA: 0x7FFE87323DF0
        public void WriteDeflaterOutput(){} // RVA: 0x7FFE87323FD0
        public void DoMaintenance(){} // RVA: 0x7FFE87324060
        public void PurgeBuffers(){} // RVA: 0x7FFE87324140
        public void Dispose(){} // RVA: 0x7FFE87324370
        public void WriteAsync(){} // RVA: 0x7FFE873246F0
        public void WriteAsyncCore(){} // RVA: 0x7FFE87324880
        public void BeginWrite(){} // RVA: 0x7FFE87324B10
        public void EndWrite(){} // RVA: 0x7FFE87324BC0
        public void <>n__0(){} // RVA: 0x7FFE8699F630
    }

    public class DeflateStream : Stream
    {
        public System.IO.Stream base_stream; // 0x28
        public 0x66532704 mode; // 0x30
        public bool leaveOpen; // 0x34
        public bool disposed; // 0x35
        public System.IO.Compression.DeflateStreamNative native; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878072B0 | overloaded x7
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void Dispose(){} // RVA: 0x7FFE878072D0
        public void ReadInternal(){} // RVA: 0x7FFE87807390
        public void ReadAsyncMemory(){} // RVA: 0x7FFE878074A0
        public void ReadCore(){} // RVA: 0x7FFE878074E0
        public void Read(){} // RVA: 0x7FFE87807670
        public void WriteInternal(){} // RVA: 0x7FFE878079A0
        public void WriteAsyncMemory(){} // RVA: 0x7FFE87807AA0
        public void WriteCore(){} // RVA: 0x7FFE87807AE0
        public void Write(){} // RVA: 0x7FFE87807B70
        public void Flush(){} // RVA: 0x7FFE87807E90
        public void BeginRead(){} // RVA: 0x7FFE87808010
        public void BeginWrite(){} // RVA: 0x7FFE87808400
        public void EndRead(){} // RVA: 0x7FFE878087F0
        public void EndWrite(){} // RVA: 0x7FFE878089E0
        public void Seek(){} // RVA: 0x7FFE87808BC0
        public void SetLength(){} // RVA: 0x7FFE87808C00
        public void get_CanRead(){} // RVA: 0x7FFE87808C40
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE87808C80
        public void get_Length(){} // RVA: 0x7FFE87808CC0
        public void get_Position(){} // RVA: 0x7FFE87808D00
        public void set_Position(){} // RVA: 0x7FFE87808D40
    }

    public class DeflateStreamNative : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87808EC0
        public void Finalize(){} // RVA: 0x7FFE87809180
        public void Dispose(){} // RVA: 0x7FFE878091D0
        public void Flush(){} // RVA: 0x7FFE87809DC0 | overloaded x2
        public void ReadZStream(){} // RVA: 0x7FFE87809E60 | overloaded x2
        public void WriteZStream(){} // RVA: 0x7FFE87809EE0 | overloaded x2
        public void UnmanagedRead(){} // RVA: 0x7FFE87809770 | overloaded x2
        public void UnmanagedWrite(){} // RVA: 0x7FFE87809A30 | overloaded x2
        public void CheckResult(){} // RVA: 0x7FFE87809BB0
        public void CreateZStream(){} // RVA: 0x7FFE87809CF0
        public void CloseZStream(){} // RVA: 0x7FFE87809DB0
    }

    public class DeflaterManaged : Object
    {
        // ── Methods ──
        public void NeedsInput(){} // RVA: 0x7FFE827B7CF0
        public void SetInput(){} // RVA: 0x7FFE827B7D70
        public void GetDeflateOutput(){} // RVA: 0x7FFE87325820
        public void Finish(){} // RVA: 0x7FFE87325D50
        public void UseCompressed(){} // RVA: 0x7FFE827B7CE0
        public void FlushInputWindows(){} // RVA: 0x7FFE87325E00
        public void WriteFinal(){} // RVA: 0x7FFE87325E20
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class FastEncoder : Object
    {
        public System.IO.Compression.FastEncoderWindow _inputWindow; // 0x10
        public System.IO.Compression.Match _currentMatch; // 0x18
        public double _lastCompressionRatio; // 0x20

        // ── Methods ──
        public void get_BytesInHistory(){} // RVA: 0x7FFE827BB420
        public void get_UnprocessedInput(){} // RVA: 0x7FFE87325E60
        public void FlushInput(){} // RVA: 0x7FFE87325F20
        public void get_LastCompressionRatio(){} // RVA: 0x7FFE827BB220
        public void GetBlock(){} // RVA: 0x7FFE873260C0
        public void GetCompressedData(){} // RVA: 0x7FFE873261A0
        public void GetBlockHeader(){} // RVA: 0x7FFE873261C0
        public void GetBlockFooter(){} // RVA: 0x7FFE873261D0
        public void GetCompressedOutput(){} // RVA: 0x7FFE873264D0 | overloaded x2
        public void InputAvailable(){} // RVA: 0x7FFE827BB3E0
        public void SafeToWriteTo(){} // RVA: 0x7FFE827BB3B0
        public void WriteEndOfBlock(){} // RVA: 0x7FFE873261D0
        public void WriteMatch(){} // RVA: 0x7FFE873265B0
        public void WriteChar(){} // RVA: 0x7FFE87326830
        public void WriteDeflatePreamble(){} // RVA: 0x7FFE873268D0
    }

    public class FastEncoderStatics : Object
    {
        // ── Methods ──
        public void CreateDistanceLookup(){} // RVA: 0x7FFE87326970
        public void GetSlot(){} // RVA: 0x7FFE87326AF0
        public void BitReverse(){} // RVA: 0x7FFE827BC8B0
        public void .cctor(){} // RVA: 0x7FFE87326B80
    }

    public class FastEncoderWindow : Object
    {
        public byte[] _window; // 0x10
        public int _bufPos; // 0x18
        public int _bufEnd; // 0x1C

        // ── Methods ──
        public void get_BytesAvailable(){} // RVA: 0x7FFE827BCFF0
        public void get_UnprocessedInput(){} // RVA: 0x7FFE87327240
        public void FlushWindow(){} // RVA: 0x7FFE87327300
        public void ResetWindow(){} // RVA: 0x7FFE87327300
        public void get_FreeWindowSpace(){} // RVA: 0x7FFE827BCAE0
        public void CopyBytes(){} // RVA: 0x7FFE827BD0E0
        public void MoveWindows(){} // RVA: 0x7FFE827BC9E0
        public void HashValue(){} // RVA: 0x7FFE827BD6E0
        public void InsertString(){} // RVA: 0x7FFE827BC8F0
        public void InsertStrings(){} // RVA: 0x7FFE827BD010
        public void GetNextSymbolOrMatch(){} // RVA: 0x7FFE87327490
        public void FindMatch(){} // RVA: 0x7FFE827BD130
    }

    public class GZipStream : Stream
    {
        public System.IO.Compression.DeflateStream _deflateStream; // 0x28
        public object field_1; // 0x3E7
        public object field_2; // 0x3E8
        public object field_3; // 0x3E9
        public object field_4; // 0x3EA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87806240 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFE87806340
        public void get_CanWrite(){} // RVA: 0x7FFE87806360
        public void get_CanSeek(){} // RVA: 0x7FFE87806380
        public void get_Length(){} // RVA: 0x7FFE878063A0
        public void get_Position(){} // RVA: 0x7FFE878063F0
        public void set_Position(){} // RVA: 0x7FFE87806440
        public void Flush(){} // RVA: 0x7FFE87806490
        public void Seek(){} // RVA: 0x7FFE878064C0
        public void SetLength(){} // RVA: 0x7FFE87806510
        public void ReadByte(){} // RVA: 0x7FFE87806560
        public void BeginRead(){} // RVA: 0x7FFE87806590
        public void EndRead(){} // RVA: 0x7FFE87806640
        public void Read(){} // RVA: 0x7FFE878066C0 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFE87806940
        public void EndWrite(){} // RVA: 0x7FFE867AFBB0
        public void Write(){} // RVA: 0x7FFE87806A30 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFE87806BC0
        public void Dispose(){} // RVA: 0x7FFE827BF4B0
        public void ReadAsync(){} // RVA: 0x7FFE87806C30 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFE87806DB0 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFE87806EF0
        public void CopyToAsync(){} // RVA: 0x7FFE87806F20
        public void CheckDeflateStream(){} // RVA: 0x7FFE87806F60
        public void ThrowStreamClosedException(){} // RVA: 0x7FFE87806F80
    }

    public class HuffmanTree : Object
    {
        public int _tableBits; // 0x10
        public short[] _table; // 0x18

        // ── Methods ──
        public void get_StaticLiteralLengthTree(){} // RVA: 0x7FFE873278A0
        public void get_StaticDistanceTree(){} // RVA: 0x7FFE87327900
        public void .ctor(){} // RVA: 0x7FFE87327960
        public void GetStaticLiteralTreeLength(){} // RVA: 0x7FFE87327B80
        public void GetStaticDistanceTreeLength(){} // RVA: 0x7FFE87327C50
        public void CalculateHuffmanCode(){} // RVA: 0x7FFE87327CC0
        public void CreateTable(){} // RVA: 0x7FFE87327ED0
        public void GetNextSymbol(){} // RVA: 0x7FFE87328140
        public void .cctor(){} // RVA: 0x7FFE87328320
    }

    public class IFileFormatReader
    {
        // ── Methods ──
        public void ReadHeader(){} // RVA: 0x7FFE80E2F3B0
        public void ReadFooter(){} // RVA: 0x7FFE80E2F3B0
        public void UpdateWithBytesRead(){}
        public void Validate(){} // RVA: 0x7FFE80E45FE0
    }

    public class IFileFormatWriter
    {
        // ── Methods ──
        public void GetHeader(){} // RVA: 0x7FFE80E2E2E0
        public void UpdateWithBytesRead(){}
        public void GetFooter(){} // RVA: 0x7FFE80E2E2E0
    }

    public class InflaterManaged : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873285C0
        public void Reset(){} // RVA: 0x7FFE87328910
        public void SetInput(){} // RVA: 0x7FFE827C2530
        public void Finished(){} // RVA: 0x7FFE827C24A0
        public void Inflate(){} // RVA: 0x7FFE87328930
        public void Decode(){} // RVA: 0x7FFE87328B50
        public void DecodeUncompressedBlock(){} // RVA: 0x7FFE87328ED0
        public void DecodeBlock(){} // RVA: 0x7FFE87329160
        public void DecodeDynamicBlockHeader(){} // RVA: 0x7FFE87329600
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87329E90
    }

    public class InputBuffer : Object
    {
        public byte[] _buffer; // 0x10
        public int _start; // 0x18

        // ── Methods ──
        public void get_AvailableBits(){} // RVA: 0x7FFE81A56130
        public void get_AvailableBytes(){} // RVA: 0x7FFE827C39E0
        public void EnsureBitsAvailable(){} // RVA: 0x7FFE827C3870
        public void TryLoad16Bits(){} // RVA: 0x7FFE827C3BB0
        public void GetBitMask(){} // RVA: 0x7FFE827C3780
        public void GetBits(){} // RVA: 0x7FFE827C3A00
        public void CopyTo(){} // RVA: 0x7FFE827C3790
        public void NeedsInput(){} // RVA: 0x7FFE827C3B60
        public void SetInput(){} // RVA: 0x7FFE827C3A60
        public void SkipBits(){} // RVA: 0x7FFE827C3920
        public void SkipToByteBoundary(){} // RVA: 0x7FFE827C3B20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Match : Object
    {
        public 0x6669F4EC _state; // 0x10
        public int _position; // 0x14
        public int _length; // 0x18
        public byte _symbol; // 0x1C

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE811485C0
        public void set_State(){} // RVA: 0x7FFE810FE0C0
        public void get_Position(){} // RVA: 0x7FFE8164B230
        public void set_Position(){} // RVA: 0x7FFE8164E0F0
        public void get_Length(){} // RVA: 0x7FFE813DB630
        public void set_Length(){} // RVA: 0x7FFE8144DF00
        public void get_Symbol(){} // RVA: 0x7FFE81116390
        public void set_Symbol(){} // RVA: 0x7FFE811163A0
    }

    public class OutputBuffer : Object
    {
        public byte[] _byteBuffer; // 0x10
        public int _pos; // 0x18
        public uint _bitBuf; // 0x1C

        // ── Methods ──
        public void UpdateBuffer(){} // RVA: 0x7FFE827C3FF0
        public void get_BytesWritten(){} // RVA: 0x7FFE813DB630
        public void get_FreeBytes(){} // RVA: 0x7FFE827C3F20
        public void WriteUInt16(){} // RVA: 0x7FFE827C41A0
        public void WriteBits(){} // RVA: 0x7FFE827C4290
        public void FlushBits(){} // RVA: 0x7FFE827C4200
        public void WriteBytes(){} // RVA: 0x7FFE827C40C0
        public void WriteBytesUnaligned(){} // RVA: 0x7FFE827C3E90
        public void WriteByteUnaligned(){} // RVA: 0x7FFE827C4180
        public void get_BitsInBuffer(){} // RVA: 0x7FFE827C3D60
        public void DumpState(){} // RVA: 0x7FFE827C3FD0
        public void RestoreState(){} // RVA: 0x7FFE827C3D70
    }

    public class OutputWindow : Object
    {
        public byte[] _window; // 0x10
        public int _end; // 0x18

        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE8732A220
        public void WriteLengthDistance(){} // RVA: 0x7FFE8732A260
        public void CopyFrom(){} // RVA: 0x7FFE8732A3A0
        public void get_FreeBytes(){} // RVA: 0x7FFE8732A620
        public void get_AvailableBytes(){} // RVA: 0x7FFE82707EE0
        public void CopyTo(){} // RVA: 0x7FFE8732A630
        public void .ctor(){} // RVA: 0x7FFE8732A6F0
    }

    public class PositionPreservingWriteOnlyStreamWrapper : Stream
    {
        public System.IO.Stream _stream; // 0x28
        public long _position; // 0x30
        public object field_2; // 0x1C
        public object field_3; // 0x1D
        public object field_4; // 0x1E
        public object field_5; // 0x1F
        public object field_6; // 0x20
        public object field_7; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8732A780
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void get_Position(){} // RVA: 0x7FFE8144E200
        public void set_Position(){} // RVA: 0x7FFE8732A820
        public void Write(){} // RVA: 0x7FFE8732A870
        public void BeginWrite(){} // RVA: 0x7FFE8732A8B0
        public void EndWrite(){} // RVA: 0x7FFE8732A8F0
        public void WriteByte(){} // RVA: 0x7FFE8732A920
        public void WriteAsync(){} // RVA: 0x7FFE8732A950
        public void get_CanTimeout(){} // RVA: 0x7FFE871CDAC0
        public void get_ReadTimeout(){} // RVA: 0x7FFE871CDC00
        public void set_ReadTimeout(){} // RVA: 0x7FFE871CDC30
        public void get_WriteTimeout(){} // RVA: 0x7FFE871CDC60
        public void set_WriteTimeout(){} // RVA: 0x7FFE871CDC90
        public void Flush(){} // RVA: 0x7FFE86F56340
        public void FlushAsync(){} // RVA: 0x7FFE81D50180
        public void Close(){} // RVA: 0x7FFE8732A990
        public void Dispose(){} // RVA: 0x7FFE8732A9C0
        public void get_Length(){} // RVA: 0x7FFE8732AA00
        public void Seek(){} // RVA: 0x7FFE8732AA50
        public void SetLength(){} // RVA: 0x7FFE8732AAA0
        public void Read(){} // RVA: 0x7FFE8732AAF0
    }

    public class SubReadStream : Stream
    {
        public long _startInSuperStream; // 0x28
        public long _positionInSuperStream; // 0x30
        public long _endInSuperStream; // 0x38
        public System.IO.Stream _superStream; // 0x40
        public bool _canRead; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87335D30
        public void get_Length(){} // RVA: 0x7FFE87335E00
        public void get_Position(){} // RVA: 0x7FFE87335E20
        public void set_Position(){} // RVA: 0x7FFE87335E40
        public void get_CanRead(){} // RVA: 0x7FFE87335EA0
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void ThrowIfDisposed(){} // RVA: 0x7FFE87335EE0
        public void ThrowIfCantRead(){} // RVA: 0x7FFE87335F70
        public void Read(){} // RVA: 0x7FFE87335FF0
        public void Seek(){} // RVA: 0x7FFE87336130
        public void SetLength(){} // RVA: 0x7FFE87336190
        public void Write(){} // RVA: 0x7FFE873361F0
        public void Flush(){} // RVA: 0x7FFE87336250
        public void Dispose(){} // RVA: 0x7FFE873362B0
    }

    public class WrappedStream : Stream
    {
        public System.IO.Stream _baseStream; // 0x28
        public bool _closeBaseStream; // 0x30
        public System.Action`1<System.IO.Compression.ZipArchiveEntry> _onClosed; // 0x38
        public System.IO.Compression.ZipArchiveEntry _zipArchiveEntry; // 0x40
        public bool _isDisposed; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87335680 | overloaded x3
        public void get_Length(){} // RVA: 0x7FFE873356B0
        public void get_Position(){} // RVA: 0x7FFE873356F0
        public void set_Position(){} // RVA: 0x7FFE87335730
        public void get_CanRead(){} // RVA: 0x7FFE87335790
        public void get_CanSeek(){} // RVA: 0x7FFE873357D0
        public void get_CanWrite(){} // RVA: 0x7FFE87335810
        public void ThrowIfDisposed(){} // RVA: 0x7FFE87335850
        public void ThrowIfCantRead(){} // RVA: 0x7FFE873358E0
        public void ThrowIfCantWrite(){} // RVA: 0x7FFE87335960
        public void ThrowIfCantSeek(){} // RVA: 0x7FFE873359E0
        public void Read(){} // RVA: 0x7FFE87335A60
        public void Seek(){} // RVA: 0x7FFE87335B30
        public void SetLength(){} // RVA: 0x7FFE87335BA0
        public void Write(){} // RVA: 0x7FFE87335C00
        public void Flush(){} // RVA: 0x7FFE87335C80
        public void Dispose(){} // RVA: 0x7FFE87335CD0
    }

    public class Zip64EndOfCentralDirectoryLocator : ValueType
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFE87333FC0
        public void WriteBlock(){} // RVA: 0x7FFE87334070
    }

    public class Zip64EndOfCentralDirectoryRecord : ValueType
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFE87334150
        public void WriteBlock(){} // RVA: 0x7FFE873342B0
    }

    public class Zip64ExtraField : ValueType
    {
        public ushort _size; // 0x10
        public System.Nullable`1<long> _uncompressedSize; // 0x18
        public System.Nullable`1<long> _compressedSize; // 0x28
        public System.Nullable`1<long> _localHeaderOffset; // 0x38
        public System.Nullable`1<int> _startDiskNumber; // 0x48

        // ── Methods ──
        public void get_TotalSize(){} // RVA: 0x7FFE87332B00
        public void get_UncompressedSize(){} // RVA: 0x7FFE82CF9F60
        public void set_UncompressedSize(){} // RVA: 0x7FFE87332B10
        public void get_CompressedSize(){} // RVA: 0x7FFE81703940
        public void set_CompressedSize(){} // RVA: 0x7FFE87332B20
        public void get_LocalHeaderOffset(){} // RVA: 0x7FFE81E90600
        public void set_LocalHeaderOffset(){} // RVA: 0x7FFE87332B30
        public void get_StartDiskNumber(){} // RVA: 0x7FFE8143BA80
        public void UpdateSize(){} // RVA: 0x7FFE87332B40
        public void GetJustZip64Block(){} // RVA: 0x7FFE87332BB0
        public void TryGetZip64BlockFromGenericExtraField(){} // RVA: 0x7FFE87332E10
        public void GetAndRemoveZip64Block(){} // RVA: 0x7FFE873333A0
        public void RemoveZip64Blocks(){} // RVA: 0x7FFE87333950
        public void WriteBlock(){} // RVA: 0x7FFE87333E50
    }

    public class ZipArchive : Object
    {
        public System.IO.Stream _archiveStream; // 0x10
        public System.IO.Compression.ZipArchiveEntry _archiveStreamOwner; // 0x18
        public System.IO.BinaryReader _archiveReader; // 0x20
        public 0x6669F8B4 _mode; // 0x28
        public System.Collections.Generic.List`1<System.IO.Compression.ZipArchiveEntry> _entries; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8732AC10 | overloaded x2
        public void get_Mode(){} // RVA: 0x7FFE81549710
        public void CreateEntry(){} // RVA: 0x7FFE8732ADD0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8732AF70 | overloaded x2
        public void get_ArchiveReader(){} // RVA: 0x7FFE811290C0
        public void get_ArchiveStream(){} // RVA: 0x7FFE81116380
        public void get_NumberOfThisDisk(){} // RVA: 0x7FFE813A7A20
        public void get_EntryNameEncoding(){} // RVA: 0x7FFE81463AE0
        public void set_EntryNameEncoding(){} // RVA: 0x7FFE8732AFE0
        public void DoCreateEntry(){} // RVA: 0x7FFE8732B0F0
        public void AcquireArchiveStream(){} // RVA: 0x7FFE8732B300
        public void AddEntry(){} // RVA: 0x7FFE8732B420
        public void ReleaseArchiveStream(){} // RVA: 0x7FFE8340D8D0
        public void RemoveEntry(){} // RVA: 0x7FFE8732B520
        public void ThrowIfDisposed(){} // RVA: 0x7FFE8732B5B0
        public void CloseStreams(){} // RVA: 0x7FFE8732B640
        public void EnsureCentralDirectoryRead(){} // RVA: 0x7FFE8732B6E0
        public void Init(){} // RVA: 0x7FFE8732B700
        public void ReadCentralDirectory(){} // RVA: 0x7FFE8732C160
        public void ReadEndOfCentralDirectory(){} // RVA: 0x7FFE8732C3F0
        public void WriteFile(){} // RVA: 0x7FFE8732CB70
        public void WriteArchiveEpilogue(){} // RVA: 0x7FFE8732D2C0
    }

    public class ZipArchiveEntry : Object
    {
        public System.IO.Compression.ZipArchive _archive; // 0x10
        public bool _originallyInArchive; // 0x18
        public int _diskNumberStart; // 0x1C
        public 0x6669FD2C _versionMadeByPlatform; // 0x20
        public 0x6669FCD4 _versionMadeBySpecification; // 0x22
        public 0x6669FCD4 _versionToExtract; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8732D990 | overloaded x3
        public void get_FullName(){} // RVA: 0x7FFE817AE360
        public void set_FullName(){} // RVA: 0x7FFE8732DF00
        public void set_LastWriteTime(){} // RVA: 0x7FFE8732E1F0
        public void Delete(){} // RVA: 0x7FFE8732E4B0
        public void Open(){} // RVA: 0x7FFE8732E630
        public void ToString(){} // RVA: 0x7FFE817AE360
        public void get_EverOpenedForWrite(){} // RVA: 0x7FFE813A1BA0
        public void get_OffsetOfCompressedData(){} // RVA: 0x7FFE8732E690
        public void get_UncompressedData(){} // RVA: 0x7FFE8732E7F0
        public void get_CompressionMethod(){} // RVA: 0x7FFE850F4D50
        public void set_CompressionMethod(){} // RVA: 0x7FFE8732EA00
        public void DecodeEntryName(){} // RVA: 0x7FFE8732EA50
        public void EncodeEntryName(){} // RVA: 0x7FFE8732EAB0
        public void WriteAndFinishLocalEntry(){} // RVA: 0x7FFE8732EBE0
        public void WriteCentralDirectoryFileHeader(){} // RVA: 0x7FFE8732EC30
        public void LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded(){} // RVA: 0x7FFE8732F290
        public void ThrowIfNotOpenable(){} // RVA: 0x7FFE8732F7D0
        public void GetDataCompressor(){} // RVA: 0x7FFE8732F850
        public void GetDataDecompressor(){} // RVA: 0x7FFE8732FB30
        public void OpenInReadMode(){} // RVA: 0x7FFE8732FD30
        public void OpenInWriteMode(){} // RVA: 0x7FFE8732FE00
        public void OpenInUpdateMode(){} // RVA: 0x7FFE873300D0
        public void IsOpenable(){} // RVA: 0x7FFE87330320
        public void SizesTooLarge(){} // RVA: 0x7FFE87330690
        public void WriteLocalFileHeader(){} // RVA: 0x7FFE873306B0
        public void WriteLocalFileHeaderAndDataIfNeeded(){} // RVA: 0x7FFE87330C00
        public void WriteCrcAndSizesInLocalHeader(){} // RVA: 0x7FFE87330EE0
        public void WriteDataDescriptor(){} // RVA: 0x7FFE87331250
        public void UnloadStreams(){} // RVA: 0x7FFE87331390
        public void CloseStreams(){} // RVA: 0x7FFE87331480
        public void VersionToExtractAtLeast(){} // RVA: 0x7FFE873314B0
        public void ThrowIfInvalidArchive(){} // RVA: 0x7FFE873314D0
        public void GetFileName_Windows(){} // RVA: 0x7FFE87331540
        public void GetFileName_Unix(){} // RVA: 0x7FFE873315C0
        public void ParseFileName(){} // RVA: 0x7FFE87331630
        public void .cctor(){} // RVA: 0x7FFE873317A0
    }

    public class ZipCentralDirectoryFileHeader : ValueType
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFE87334880
    }

    public class ZipEndOfCentralDirectoryBlock : ValueType
    {
        // ── Methods ──
        public void WriteBlock(){} // RVA: 0x7FFE873351B0
        public void TryReadBlock(){} // RVA: 0x7FFE87335360
    }

    public class ZipFileExtensions : Object
    {
        // ── Methods ──
        public void CreateEntryFromFile(){} // RVA: 0x7FFE87338320
        public void DoCreateEntryFromFile(){} // RVA: 0x7FFE87338340
    }

    public class ZipGenericExtraField : ValueType
    {
        public ushort _tag; // 0x10
        public ushort _size; // 0x12
        public byte[] _data; // 0x18

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE82D33010
        public void get_Size(){} // RVA: 0x7FFE82D33020
        public void get_Data(){} // RVA: 0x7FFE826F4210
        public void WriteBlock(){} // RVA: 0x7FFE87332300
        public void TryReadBlock(){} // RVA: 0x7FFE873323C0
        public void ParseExtraField(){} // RVA: 0x7FFE87332530
        public void TotalSize(){} // RVA: 0x7FFE873327A0
        public void WriteAllBlocks(){} // RVA: 0x7FFE87332900
    }

    public class ZipHelper : Object
    {
        // ── Methods ──
        public void RequiresUnicode(){} // RVA: 0x7FFE87336B60
        public void ReadBytes(){} // RVA: 0x7FFE87336BC0
        public void DosTimeToDateTime(){} // RVA: 0x7FFE87336C90
        public void DateTimeToDosTime(){} // RVA: 0x7FFE87336D40
        public void SeekBackwardsToSignature(){} // RVA: 0x7FFE87336ED0
        public void AdvanceToPosition(){} // RVA: 0x7FFE87337130
        public void SeekBackwardsAndRead(){} // RVA: 0x7FFE87337230
        public void .cctor(){} // RVA: 0x7FFE873373C0
    }

    public class ZipLocalFileHeader : ValueType
    {
        // ── Methods ──
        public void GetExtraFields(){} // RVA: 0x7FFE87334440
        public void TrySkipBlock(){} // RVA: 0x7FFE87334670
    }

}