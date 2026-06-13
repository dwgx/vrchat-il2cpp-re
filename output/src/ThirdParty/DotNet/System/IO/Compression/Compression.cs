// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Compression
// Classes: 34
// Methods: 410

namespace ThirdParty.DotNet.System.IO.Compression
{
    public class CheckSumAndSizeWriteStream
    {
        public System.IO.Stream _baseStream; // 0x28
        public System.IO.Stream _baseBaseStream; // 0x30
        public long _position; // 0x38
        public uint _checksum; // 0x40
        public bool _leaveOpenOnClose; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67F6FF0
        public void get_Length(){} // RVA: 0x67F7210
        public void get_Position(){} // RVA: 0x67F7270
        public void set_Position(){} // RVA: 0x67F7290
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x1C90FC0
        public void ThrowIfDisposed(){} // RVA: 0x67F72F0
        public void Read(){} // RVA: 0x67F7380
        public void Seek(){} // RVA: 0x67F73E0
        public void SetLength(){} // RVA: 0x67F7440
        public void Write(){} // RVA: 0x67F74A0
        public void Flush(){} // RVA: 0x67F7750
        public void Dispose(){} // RVA: 0x67F7790
    }

    public class CopyEncoder
    {
        // ── Methods ──
        public void GetBlock(){} // RVA: 0x67E3A40
        public void WriteLenNLen(){} // RVA: 0x1A2F7C0
    }

    public class Crc32Helper
    {
        // ── Methods ──
        public void UpdateCrc32(){} // RVA: 0x67F8180
        public void ManagedCrc32(){} // RVA: 0x67F8210
        public void .cctor(){} // RVA: 0x67F85D0
    }

    public class DeflateInput
    {
        public byte[] <Buffer>k__BackingField; // 0x10
        public int <Count>k__BackingField; // 0x18
        public int <StartIndex>k__BackingField; // 0x1C

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x2F8380
        public void set_Buffer(){} // RVA: 0x2DEE30
        public void get_Count(){} // RVA: 0x5BED50
        public void set_Count(){} // RVA: 0x6374E0
        public void get_StartIndex(){} // RVA: 0x197C3B0
        public void set_StartIndex(){} // RVA: 0x1989FD0
        public void ConsumeBytes(){} // RVA: 0x1A2FFA0
        public void DumpState(){} // RVA: 0x1A2FF80
        public void RestoreState(){} // RVA: 0x1A2FFB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DeflateManagedStream
    {
        public System.IO.Stream _stream; // 0x28
        public 0x65854760 _mode; // 0x30
        public bool _leaveOpen; // 0x34
        public System.IO.Compression.InflaterManaged _inflater; // 0x38
        public System.IO.Compression.DeflaterManaged _deflater; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67E3CD0
        public void InitializeInflater(){} // RVA: 0x67E3E30
        public void get_CanRead(){} // RVA: 0x1A31510
        public void get_CanWrite(){} // RVA: 0x1A32BC0
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x67E4060
        public void get_Position(){} // RVA: 0x67E40B0
        public void set_Position(){} // RVA: 0x67E4100
        public void Flush(){} // RVA: 0x67E4150
        public void FlushAsync(){} // RVA: 0x67E4170
        public void Seek(){} // RVA: 0x67E4270
        public void SetLength(){} // RVA: 0x67E42C0
        public void Read(){} // RVA: 0x67E4310
        public void ValidateParameters(){} // RVA: 0x67E4510
        public void EnsureNotDisposed(){} // RVA: 0x67E4150
        public void ThrowStreamClosedException(){} // RVA: 0x67E4670
        public void EnsureDecompressionMode(){} // RVA: 0x67E46D0
        public void ThrowCannotReadFromDeflateManagedStreamException(){} // RVA: 0x67E46F0
        public void EnsureCompressionMode(){} // RVA: 0x67E4740
        public void ThrowCannotWriteToDeflateManagedStreamException(){} // RVA: 0x67E4760
        public void BeginRead(){} // RVA: 0x67E47B0
        public void EndRead(){} // RVA: 0x67E4860
        public void ReadAsync(){} // RVA: 0x67E48A0
        public void ReadAsyncCore(){} // RVA: 0x67E4C50
        public void Write(){} // RVA: 0x67E4EF0
        public void WriteDeflaterOutput(){} // RVA: 0x67E50D0
        public void DoMaintenance(){} // RVA: 0x67E5160
        public void PurgeBuffers(){} // RVA: 0x67E5240
        public void Dispose(){} // RVA: 0x67E5470
        public void WriteAsync(){} // RVA: 0x67E57F0
        public void WriteAsyncCore(){} // RVA: 0x67E5980
        public void BeginWrite(){} // RVA: 0x67E5C10
        public void EndWrite(){} // RVA: 0x67E5CC0
        public void <>n__0(){} // RVA: 0x5E5E7F0
    }

    public class DeflateStream
    {
        public System.IO.Stream base_stream; // 0x28
        public 0x65854760 mode; // 0x30
        public bool leaveOpen; // 0x34
        public bool disposed; // 0x35
        public System.IO.Compression.DeflateStreamNative native; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CC6410 | overloaded x7
        public void Finalize(){} // RVA: 0x5CB2900
        public void Dispose(){} // RVA: 0x6CC6430
        public void ReadInternal(){} // RVA: 0x6CC64F0
        public void ReadAsyncMemory(){} // RVA: 0x6CC6600
        public void ReadCore(){} // RVA: 0x6CC6640
        public void Read(){} // RVA: 0x6CC67D0
        public void WriteInternal(){} // RVA: 0x6CC6B00
        public void WriteAsyncMemory(){} // RVA: 0x6CC6C00
        public void WriteCore(){} // RVA: 0x6CC6C40
        public void Write(){} // RVA: 0x6CC6CD0
        public void Flush(){} // RVA: 0x6CC6FF0
        public void BeginRead(){} // RVA: 0x6CC7170
        public void BeginWrite(){} // RVA: 0x6CC7560
        public void EndRead(){} // RVA: 0x6CC7950
        public void EndWrite(){} // RVA: 0x6CC7B40
        public void Seek(){} // RVA: 0x6CC7D20
        public void SetLength(){} // RVA: 0x6CC7D60
        public void get_CanRead(){} // RVA: 0x6CC7DA0
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x6CC7DE0
        public void get_Length(){} // RVA: 0x6CC7E20
        public void get_Position(){} // RVA: 0x6CC7E60
        public void set_Position(){} // RVA: 0x6CC7EA0
    }

    public class DeflateStreamNative
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6CC8020
        public void Finalize(){} // RVA: 0x6CC82E0
        public void Dispose(){} // RVA: 0x6CC8330
        public void Flush(){} // RVA: 0x6CC8F20 | overloaded x2
        public void ReadZStream(){} // RVA: 0x6CC8FC0 | overloaded x2
        public void WriteZStream(){} // RVA: 0x6CC9040 | overloaded x2
        public void UnmanagedRead(){} // RVA: 0x6CC88D0 | overloaded x2
        public void UnmanagedWrite(){} // RVA: 0x6CC8B90 | overloaded x2
        public void CheckResult(){} // RVA: 0x6CC8D10
        public void CreateZStream(){} // RVA: 0x6CC8E50
        public void CloseZStream(){} // RVA: 0x6CC8F10
    }

    public class DeflaterManaged
    {
        // ── Methods ──
        public void NeedsInput(){} // RVA: 0x1A30800
        public void SetInput(){} // RVA: 0x1A30990
        public void GetDeflateOutput(){} // RVA: 0x67E6920
        public void Finish(){} // RVA: 0x67E6E50
        public void UseCompressed(){} // RVA: 0x1A307F0
        public void FlushInputWindows(){} // RVA: 0x67E6F00
        public void WriteFinal(){} // RVA: 0x67E6F20
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class FastEncoder
    {
        public System.IO.Compression.FastEncoderWindow _inputWindow; // 0x10
        public System.IO.Compression.Match _currentMatch; // 0x18
        public double _lastCompressionRatio; // 0x20

        // ── Methods ──
        public void get_BytesInHistory(){} // RVA: 0x1A34510
        public void get_UnprocessedInput(){} // RVA: 0x67E6F60
        public void FlushInput(){} // RVA: 0x67E7020
        public void get_LastCompressionRatio(){} // RVA: 0x1A346F0
        public void GetBlock(){} // RVA: 0x67E71C0
        public void GetCompressedData(){} // RVA: 0x67E72A0
        public void GetBlockHeader(){} // RVA: 0x67E72C0
        public void GetBlockFooter(){} // RVA: 0x67E72D0
        public void GetCompressedOutput(){} // RVA: 0x67E75D0 | overloaded x2
        public void InputAvailable(){} // RVA: 0x1A34E10
        public void SafeToWriteTo(){} // RVA: 0x1A34930
        public void WriteEndOfBlock(){} // RVA: 0x67E72D0
        public void WriteMatch(){} // RVA: 0x67E76B0
        public void WriteChar(){} // RVA: 0x67E7930
        public void WriteDeflatePreamble(){} // RVA: 0x67E79D0
    }

    public class FastEncoderStatics
    {
        // ── Methods ──
        public void CreateDistanceLookup(){} // RVA: 0x67E7A70
        public void GetSlot(){} // RVA: 0x67E7BF0
        public void BitReverse(){} // RVA: 0x1A35550
        public void .cctor(){} // RVA: 0x67E7C80
    }

    public class FastEncoderWindow
    {
        public byte[] _window; // 0x10
        public int _bufPos; // 0x18
        public int _bufEnd; // 0x1C

        // ── Methods ──
        public void get_BytesAvailable(){} // RVA: 0x1A35AF0
        public void get_UnprocessedInput(){} // RVA: 0x67E8340
        public void FlushWindow(){} // RVA: 0x67E8400
        public void ResetWindow(){} // RVA: 0x67E8400
        public void get_FreeWindowSpace(){} // RVA: 0x1A35D50
        public void CopyBytes(){} // RVA: 0x1A36130
        public void MoveWindows(){} // RVA: 0x1A35D60
        public void HashValue(){} // RVA: 0x1A36570
        public void InsertString(){} // RVA: 0x1A36300
        public void InsertStrings(){} // RVA: 0x1A35580
        public void GetNextSymbolOrMatch(){} // RVA: 0x1A35650
        public void FindMatch(){} // RVA: 0x1A36180
    }

    public class GZipStream
    {
        public System.IO.Compression.DeflateStream _deflateStream; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CC53A0 | overloaded x3
        public void get_CanRead(){} // RVA: 0x6CC54A0
        public void get_CanWrite(){} // RVA: 0x6CC54C0
        public void get_CanSeek(){} // RVA: 0x6CC54E0
        public void get_Length(){} // RVA: 0x6CC5500
        public void get_Position(){} // RVA: 0x6CC5550
        public void set_Position(){} // RVA: 0x6CC55A0
        public void Flush(){} // RVA: 0x6CC55F0
        public void Seek(){} // RVA: 0x6CC5620
        public void SetLength(){} // RVA: 0x6CC5670
        public void ReadByte(){} // RVA: 0x6CC56C0
        public void BeginRead(){} // RVA: 0x6CC56F0
        public void EndRead(){} // RVA: 0x6CC57A0
        public void Read(){} // RVA: 0x6CC5820 | overloaded x2
        public void BeginWrite(){} // RVA: 0x6CC5AA0
        public void EndWrite(){} // RVA: 0x5C6ED10
        public void Write(){} // RVA: 0x6CC5B90 | overloaded x2
        public void CopyTo(){} // RVA: 0x6CC5D20
        public void Dispose(){} // RVA: 0x1A38B20
        public void ReadAsync(){} // RVA: 0x6CC5D90 | overloaded x2
        public void WriteAsync(){} // RVA: 0x6CC5F10 | overloaded x2
        public void FlushAsync(){} // RVA: 0x6CC6050
        public void CopyToAsync(){} // RVA: 0x6CC6080
        public void CheckDeflateStream(){} // RVA: 0x6CC60C0
        public void ThrowStreamClosedException(){} // RVA: 0x6CC60E0
    }

    public class HuffmanTree
    {
        public int _tableBits; // 0x10
        public short[] _table; // 0x18

        // ── Methods ──
        public void get_StaticLiteralLengthTree(){} // RVA: 0x67E8590
        public void get_StaticDistanceTree(){} // RVA: 0x67E85F0
        public void .ctor(){} // RVA: 0x67E8650
        public void GetStaticLiteralTreeLength(){} // RVA: 0x67E8870
        public void GetStaticDistanceTreeLength(){} // RVA: 0x67E8940
        public void CalculateHuffmanCode(){} // RVA: 0x67E89B0
        public void CreateTable(){} // RVA: 0x67E8BC0
        public void GetNextSymbol(){} // RVA: 0x67E8E30
        public void .cctor(){} // RVA: 0x67E9010
    }

    public class IFileFormatReader
    {
        // ── Methods ──
        public void ReadHeader(){} // RVA: 0xDE40
        public void ReadFooter(){} // RVA: 0xDE40
        public void UpdateWithBytesRead(){}
        public void Validate(){} // RVA: 0x24A50
    }

    public class IFileFormatWriter
    {
        // ── Methods ──
        public void GetHeader(){} // RVA: 0xCD60
        public void UpdateWithBytesRead(){}
        public void GetFooter(){} // RVA: 0xCD60
    }

    public class InflaterManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67E92B0
        public void Reset(){} // RVA: 0x67E9600
        public void SetInput(){} // RVA: 0x1A3BB60
        public void Finished(){} // RVA: 0x1A3DB00
        public void Inflate(){} // RVA: 0x67E9620
        public void Decode(){} // RVA: 0x67E9840
        public void DecodeUncompressedBlock(){} // RVA: 0x67E9BC0
        public void DecodeBlock(){} // RVA: 0x67E9E50
        public void DecodeDynamicBlockHeader(){} // RVA: 0x67EA2F0
        public void Dispose(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x67EAB80
    }

    public class InputBuffer
    {
        public byte[] State; // 0x10
        public int Position; // 0x18

        // ── Methods ──
        public void get_AvailableBits(){} // RVA: 0xCEF5B0
        public void get_AvailableBytes(){} // RVA: 0x1A3DE00
        public void EnsureBitsAvailable(){} // RVA: 0x1A3DC20
        public void TryLoad16Bits(){} // RVA: 0x1A3DEC0
        public void GetBitMask(){} // RVA: 0x1A3E160
        public void GetBits(){} // RVA: 0x1A3DE60
        public void CopyTo(){} // RVA: 0x1A3DF80
        public void NeedsInput(){} // RVA: 0x1A3DB40
        public void SetInput(){} // RVA: 0x1A3DCD0
        public void SkipBits(){} // RVA: 0x1A3DB50
        public void SkipToByteBoundary(){} // RVA: 0x1A3DE20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Match
    {
        public 0x659C9738 <State>k__BackingField; // 0x10
        public int <Position>k__BackingField; // 0x14
        public int <Length>k__BackingField; // 0x18
        public byte <Symbol>k__BackingField; // 0x1C

        // ── Methods ──
        public void get_State(){} // RVA: 0x32A5C0
        public void set_State(){} // RVA: 0x2E00C0
        public void get_Position(){} // RVA: 0x8ABED0
        public void set_Position(){} // RVA: 0x8AC660
        public void get_Length(){} // RVA: 0x5BED50
        public void set_Length(){} // RVA: 0x6374E0
        public void get_Symbol(){} // RVA: 0x2F8390
        public void set_Symbol(){} // RVA: 0x2F83A0
    }

    public class OutputBuffer
    {
        public byte[] FreeBytes; // 0x10
        public int AvailableBytes; // 0x18
        public uint _bitBuf; // 0x1C

        // ── Methods ──
        public void UpdateBuffer(){} // RVA: 0x1A3E640
        public void get_BytesWritten(){} // RVA: 0x5BED50
        public void get_FreeBytes(){} // RVA: 0x1A3E400
        public void WriteUInt16(){} // RVA: 0x1A3E3A0
        public void WriteBits(){} // RVA: 0x1A3E6C0
        public void FlushBits(){} // RVA: 0x1A3E420
        public void WriteBytes(){} // RVA: 0x1A3E540
        public void WriteBytesUnaligned(){} // RVA: 0x1A3E260
        public void WriteByteUnaligned(){} // RVA: 0x1A3E600
        public void get_BitsInBuffer(){} // RVA: 0x1A3E6B0
        public void DumpState(){} // RVA: 0x1A3E2F0
        public void RestoreState(){} // RVA: 0x1A3E620
    }

    public class OutputWindow
    {
        public byte[] CanRead; // 0x10
        public int CanSeek; // 0x18

        // ── Methods ──
        public void Write(){} // RVA: 0x67EAF10
        public void WriteLengthDistance(){} // RVA: 0x67EAF50
        public void CopyFrom(){} // RVA: 0x67EB090
        public void get_FreeBytes(){} // RVA: 0x67EB310
        public void get_AvailableBytes(){} // RVA: 0x197C3B0
        public void CopyTo(){} // RVA: 0x67EB320
        public void .ctor(){} // RVA: 0x67EB3E0
    }

    public class PositionPreservingWriteOnlyStreamWrapper
    {
        public System.IO.Stream _stream; // 0x28
        public long _position; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EB470
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void get_Position(){} // RVA: 0x6374D0
        public void set_Position(){} // RVA: 0x67EB510
        public void Write(){} // RVA: 0x67EB560
        public void BeginWrite(){} // RVA: 0x67EB5A0
        public void EndWrite(){} // RVA: 0x67EB5E0
        public void WriteByte(){} // RVA: 0x67EB610
        public void WriteAsync(){} // RVA: 0x67EB640
        public void get_CanTimeout(){} // RVA: 0x668EBD0
        public void get_ReadTimeout(){} // RVA: 0x668ED10
        public void set_ReadTimeout(){} // RVA: 0x668ED40
        public void get_WriteTimeout(){} // RVA: 0x668ED70
        public void set_WriteTimeout(){} // RVA: 0x668EDA0
        public void Flush(){} // RVA: 0x6415940
        public void FlushAsync(){} // RVA: 0x67EB680
        public void Close(){} // RVA: 0x67EB6B0
        public void Dispose(){} // RVA: 0x67EB6E0
        public void get_Length(){} // RVA: 0x67EB720
        public void Seek(){} // RVA: 0x67EB770
        public void SetLength(){} // RVA: 0x67EB7C0
        public void Read(){} // RVA: 0x67EB810
    }

    public class SubReadStream
    {
        public long _startInSuperStream; // 0x28
        public long _positionInSuperStream; // 0x30
        public long _endInSuperStream; // 0x38
        public System.IO.Stream _superStream; // 0x40
        public bool _canRead; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67F6A50
        public void get_Length(){} // RVA: 0x67F6B20
        public void get_Position(){} // RVA: 0x67F6B40
        public void set_Position(){} // RVA: 0x67F6B60
        public void get_CanRead(){} // RVA: 0x67F6BC0
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void ThrowIfDisposed(){} // RVA: 0x67F6C00
        public void ThrowIfCantRead(){} // RVA: 0x67F6C90
        public void Read(){} // RVA: 0x67F6D10
        public void Seek(){} // RVA: 0x67F6E50
        public void SetLength(){} // RVA: 0x67F6EB0
        public void Write(){} // RVA: 0x67F6F10
        public void Flush(){} // RVA: 0x67F6F70
        public void Dispose(){} // RVA: 0x67F6FD0
    }

    public class WrappedStream
    {
        public System.IO.Stream _baseStream; // 0x28
        public bool _closeBaseStream; // 0x30
        public System.Action`1<System.IO.Compression.ZipArchiveEntry> _onClosed; // 0x38
        public System.IO.Compression.ZipArchiveEntry _zipArchiveEntry; // 0x40
        public bool _isDisposed; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67F63A0 | overloaded x3
        public void get_Length(){} // RVA: 0x67F63D0
        public void get_Position(){} // RVA: 0x67F6410
        public void set_Position(){} // RVA: 0x67F6450
        public void get_CanRead(){} // RVA: 0x67F64B0
        public void get_CanSeek(){} // RVA: 0x67F64F0
        public void get_CanWrite(){} // RVA: 0x67F6530
        public void ThrowIfDisposed(){} // RVA: 0x67F6570
        public void ThrowIfCantRead(){} // RVA: 0x67F6600
        public void ThrowIfCantWrite(){} // RVA: 0x67F6680
        public void ThrowIfCantSeek(){} // RVA: 0x67F6700
        public void Read(){} // RVA: 0x67F6780
        public void Seek(){} // RVA: 0x67F6850
        public void SetLength(){} // RVA: 0x67F68C0
        public void Write(){} // RVA: 0x67F6920
        public void Flush(){} // RVA: 0x67F69A0
        public void Dispose(){} // RVA: 0x67F69F0
    }

    public class Zip64EndOfCentralDirectoryLocator
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x67F4CE0
        public void WriteBlock(){} // RVA: 0x67F4D90
    }

    public class Zip64EndOfCentralDirectoryRecord
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x67F4E70
        public void WriteBlock(){} // RVA: 0x67F4FD0
    }

    public class Zip64ExtraField
    {
        public ushort _size; // 0x10
        public System.Nullable`1<long> _uncompressedSize; // 0x18
        public System.Nullable`1<long> _compressedSize; // 0x28
        public System.Nullable`1<long> _localHeaderOffset; // 0x38
        public System.Nullable`1<int> _startDiskNumber; // 0x48

        // ── Methods ──
        public void get_TotalSize(){} // RVA: 0x67F3820
        public void get_UncompressedSize(){} // RVA: 0x1F6F090
        public void set_UncompressedSize(){} // RVA: 0x67F3830
        public void get_CompressedSize(){} // RVA: 0x994EE0
        public void set_CompressedSize(){} // RVA: 0x67F3840
        public void get_LocalHeaderOffset(){} // RVA: 0x111F520
        public void set_LocalHeaderOffset(){} // RVA: 0x67F3850
        public void get_StartDiskNumber(){} // RVA: 0x4976A0
        public void UpdateSize(){} // RVA: 0x67F3860
        public void GetJustZip64Block(){} // RVA: 0x67F38D0
        public void TryGetZip64BlockFromGenericExtraField(){} // RVA: 0x67F3B30
        public void GetAndRemoveZip64Block(){} // RVA: 0x67F40C0
        public void RemoveZip64Blocks(){} // RVA: 0x67F4670
        public void WriteBlock(){} // RVA: 0x67F4B70
    }

    public class ZipArchive
    {
        public System.IO.Stream _archiveStream; // 0x10
        public System.IO.Compression.ZipArchiveEntry _archiveStreamOwner; // 0x18
        public System.IO.BinaryReader _archiveReader; // 0x20
        public 0x659C9B00 _mode; // 0x28
        public System.Collections.Generic.List`1<System.IO.Compression.ZipArchiveEntry> _entries; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EB930 | overloaded x2
        public void get_Mode(){} // RVA: 0x791DC0
        public void CreateEntry(){} // RVA: 0x67EBAF0 | overloaded x2
        public void Dispose(){} // RVA: 0x67EBC90 | overloaded x2
        public void get_ArchiveReader(){} // RVA: 0x30B0C0
        public void get_ArchiveStream(){} // RVA: 0x2F8380
        public void get_NumberOfThisDisk(){} // RVA: 0x5A54D0
        public void get_EntryNameEncoding(){} // RVA: 0x4C7C50
        public void set_EntryNameEncoding(){} // RVA: 0x67EBD00
        public void DoCreateEntry(){} // RVA: 0x67EBE10
        public void AcquireArchiveStream(){} // RVA: 0x67EC020
        public void AddEntry(){} // RVA: 0x67EC140
        public void ReleaseArchiveStream(){} // RVA: 0x26AD280
        public void RemoveEntry(){} // RVA: 0x67EC240
        public void ThrowIfDisposed(){} // RVA: 0x67EC2D0
        public void CloseStreams(){} // RVA: 0x67EC360
        public void EnsureCentralDirectoryRead(){} // RVA: 0x67EC400
        public void Init(){} // RVA: 0x67EC420
        public void ReadCentralDirectory(){} // RVA: 0x67ECE80
        public void ReadEndOfCentralDirectory(){} // RVA: 0x67ED110
        public void WriteFile(){} // RVA: 0x67ED890
        public void WriteArchiveEpilogue(){} // RVA: 0x67EDFE0
    }

    public class ZipArchiveEntry
    {
        public System.IO.Compression.ZipArchive _archive; // 0x10
        public bool _originallyInArchive; // 0x18
        public int _diskNumberStart; // 0x1C
        public 0x659C9F78 _versionMadeByPlatform; // 0x20
        public 0x659C9F20 _versionMadeBySpecification; // 0x22
        public 0x659C9F20 _versionToExtract; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EE6B0 | overloaded x3
        public void get_FullName(){} // RVA: 0xA1C8C0
        public void set_FullName(){} // RVA: 0x67EEC20
        public void set_LastWriteTime(){} // RVA: 0x67EEF10
        public void Delete(){} // RVA: 0x67EF1D0
        public void Open(){} // RVA: 0x67EF350
        public void ToString(){} // RVA: 0xA1C8C0
        public void get_EverOpenedForWrite(){} // RVA: 0x59F730
        public void get_OffsetOfCompressedData(){} // RVA: 0x67EF3B0
        public void get_UncompressedData(){} // RVA: 0x67EF510
        public void get_CompressionMethod(){} // RVA: 0x44B97F0
        public void set_CompressionMethod(){} // RVA: 0x67EF720
        public void DecodeEntryName(){} // RVA: 0x67EF770
        public void EncodeEntryName(){} // RVA: 0x67EF7D0
        public void WriteAndFinishLocalEntry(){} // RVA: 0x67EF900
        public void WriteCentralDirectoryFileHeader(){} // RVA: 0x67EF950
        public void LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded(){} // RVA: 0x67EFFB0
        public void ThrowIfNotOpenable(){} // RVA: 0x67F04F0
        public void GetDataCompressor(){} // RVA: 0x67F0570
        public void GetDataDecompressor(){} // RVA: 0x67F0850
        public void OpenInReadMode(){} // RVA: 0x67F0A50
        public void OpenInWriteMode(){} // RVA: 0x67F0B20
        public void OpenInUpdateMode(){} // RVA: 0x67F0DF0
        public void IsOpenable(){} // RVA: 0x67F1040
        public void SizesTooLarge(){} // RVA: 0x67F13B0
        public void WriteLocalFileHeader(){} // RVA: 0x67F13D0
        public void WriteLocalFileHeaderAndDataIfNeeded(){} // RVA: 0x67F1920
        public void WriteCrcAndSizesInLocalHeader(){} // RVA: 0x67F1C00
        public void WriteDataDescriptor(){} // RVA: 0x67F1F70
        public void UnloadStreams(){} // RVA: 0x67F20B0
        public void CloseStreams(){} // RVA: 0x67F21A0
        public void VersionToExtractAtLeast(){} // RVA: 0x67F21D0
        public void ThrowIfInvalidArchive(){} // RVA: 0x67F21F0
        public void GetFileName_Windows(){} // RVA: 0x67F2260
        public void GetFileName_Unix(){} // RVA: 0x67F22E0
        public void ParseFileName(){} // RVA: 0x67F2350
        public void .cctor(){} // RVA: 0x67F24C0
    }

    public class ZipCentralDirectoryFileHeader
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x67F55A0
    }

    public class ZipEndOfCentralDirectoryBlock
    {
        // ── Methods ──
        public void WriteBlock(){} // RVA: 0x67F5ED0
        public void TryReadBlock(){} // RVA: 0x67F6080
    }

    public class ZipFileExtensions
    {
        // ── Methods ──
        public void CreateEntryFromFile(){} // RVA: 0x67F9040
        public void DoCreateEntryFromFile(){} // RVA: 0x67F9060
    }

    public class ZipGenericExtraField
    {
        public ushort TotalSize; // 0x10
        public ushort UncompressedSize; // 0x12
        public byte[] CompressedSize; // 0x18

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x1FA63F0
        public void get_Size(){} // RVA: 0x1FA6420
        public void get_Data(){} // RVA: 0x19689C0
        public void WriteBlock(){} // RVA: 0x67F3020
        public void TryReadBlock(){} // RVA: 0x67F30E0
        public void ParseExtraField(){} // RVA: 0x67F3250
        public void TotalSize(){} // RVA: 0x67F34C0
        public void WriteAllBlocks(){} // RVA: 0x67F3620
    }

    public class ZipHelper
    {
        // ── Methods ──
        public void RequiresUnicode(){} // RVA: 0x67F7880
        public void ReadBytes(){} // RVA: 0x67F78E0
        public void DosTimeToDateTime(){} // RVA: 0x67F79B0
        public void DateTimeToDosTime(){} // RVA: 0x67F7A60
        public void SeekBackwardsToSignature(){} // RVA: 0x67F7BF0
        public void AdvanceToPosition(){} // RVA: 0x67F7E50
        public void SeekBackwardsAndRead(){} // RVA: 0x67F7F50
        public void .cctor(){} // RVA: 0x67F80E0
    }

    public class ZipLocalFileHeader
    {
        // ── Methods ──
        public void GetExtraFields(){} // RVA: 0x67F5160
        public void TrySkipBlock(){} // RVA: 0x67F5390
    }

}