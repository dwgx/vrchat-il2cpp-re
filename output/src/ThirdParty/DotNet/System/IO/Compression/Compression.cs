// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Compression
// Classes: 34
// Methods: 385

namespace ThirdParty.DotNet.System.IO.Compression
{
    public class CheckSumAndSizeWriteStream : Stream
    {
        public object _baseStream;
        public object _baseBaseStream;
        public object _position;
        public object _checksum;
        public object _leaveOpenOnClose;
        public object _canWrite;
        public object _isDisposed;
        public object _everWritten;
        public object _initialPosition;
        public object _zipArchiveEntry;
        public object _onClose;
        public object _saveCrcAndSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x725C740
        public void get_Length(){} // RVA: 0x725C960
        public void get_Position(){} // RVA: 0x725C9C0
        public void set_Position(){} // RVA: 0x725C9E0
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x2540270
        public void ThrowIfDisposed(){} // RVA: 0x725CA40
        public void Read(){} // RVA: 0x725CAD0
        public void Seek(){} // RVA: 0x725CB30
        public void SetLength(){} // RVA: 0x725CB90
        public void Write(){} // RVA: 0x725CBF0
        public void Flush(){} // RVA: 0x725CEA0
        public void Dispose(){} // RVA: 0x725CEE0
    }

    public class CopyEncoder : Object
    {
        // ── Methods ──
        public void GetBlock(){} // RVA: 0x7248D20
        public void WriteLenNLen(){} // RVA: 0x22F5910
    }

    public class Crc32Helper : Object
    {
        public object s_crcTable_0;
        public object s_crcTable_1;
        public object s_crcTable_2;
        public object s_crcTable_3;
        public object s_crcTable_4;
        public object s_crcTable_5;
        public object s_crcTable_6;
        public object s_crcTable_7;

        // ── Methods ──
        public void UpdateCrc32(){} // RVA: 0x725D8E0
        public void ManagedCrc32(){} // RVA: 0x725D970
        public void .cctor(){} // RVA: 0x725DD30
    }

    public class DeflateInput : Object
    {
        public object _buffer;
        public object _count;
        public object _startIndex;

        // ── Methods ──
        public void get_Buffer(){} // RVA: 0xB5DBF0
        public void set_Buffer(){} // RVA: 0xB44D60
        public void get_Count(){} // RVA: 0xE62D00
        public void set_Count(){} // RVA: 0x1033F40
        public void get_StartIndex(){} // RVA: 0x2244FB0
        public void set_StartIndex(){} // RVA: 0x22735B0
        public void ConsumeBytes(){} // RVA: 0x22F5B90
        public void DumpState(){} // RVA: 0x22F5BA0
        public void RestoreState(){} // RVA: 0x22F5BC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DeflateManagedStream : Stream
    {
        public object _stream;
        public object _mode;
        public object _leaveOpen;
        public object _inflater;
        public object _deflater;
        public object _buffer;
        public object _asyncOperations;
        public object _formatWriter;
        public object _wroteHeader;
        public object _wroteBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7248FC0
        public void InitializeInflater(){} // RVA: 0x7249120
        public void get_CanRead(){} // RVA: 0x22F74C0
        public void get_CanWrite(){} // RVA: 0x22F8FE0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x7249370
        public void get_Position(){} // RVA: 0x72493C0
        public void set_Position(){} // RVA: 0x7249410
        public void Flush(){} // RVA: 0x7249460
        public void FlushAsync(){} // RVA: 0x7249480
        public void Seek(){} // RVA: 0x7249580
        public void SetLength(){} // RVA: 0x72495D0
        public void Read(){} // RVA: 0x7249620
        public void ValidateParameters(){} // RVA: 0x7249820
        public void EnsureNotDisposed(){} // RVA: 0x7249460
        public void ThrowStreamClosedException(){} // RVA: 0x7249980
        public void EnsureDecompressionMode(){} // RVA: 0x72499E0
        public void ThrowCannotReadFromDeflateManagedStreamException(){} // RVA: 0x7249A00
        public void EnsureCompressionMode(){} // RVA: 0x7249A50
        public void ThrowCannotWriteToDeflateManagedStreamException(){} // RVA: 0x7249A70
        public void BeginRead(){} // RVA: 0x7249AC0
        public void EndRead(){} // RVA: 0x7249B70
        public void ReadAsync(){} // RVA: 0x7249BB0
        public void ReadAsyncCore(){} // RVA: 0x7249F60
        public void Write(){} // RVA: 0x724A220
        public void WriteDeflaterOutput(){} // RVA: 0x724A400
        public void DoMaintenance(){} // RVA: 0x724A490
        public void PurgeBuffers(){} // RVA: 0x724A570
        public void Dispose(){} // RVA: 0x724A7A0
        public void WriteAsync(){} // RVA: 0x724AB10
        public void WriteAsyncCore(){} // RVA: 0x724ACA0
        public void BeginWrite(){} // RVA: 0x724AF30
        public void EndWrite(){} // RVA: 0x724AFE0
        public void <>n__0(){} // RVA: 0x68D7C90
    }

    public class DeflateStream : Stream
    {
        public object base_stream;
        public object mode;
        public object leaveOpen;
        public object disposed;
        public object native;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7724EE0
        public void Finalize(){} // RVA: 0x672B280
        public void Dispose(){} // RVA: 0x7724F00
        public void ReadInternal(){} // RVA: 0x7724FC0
        public void ReadAsyncMemory(){} // RVA: 0x77250D0
        public void ReadCore(){} // RVA: 0x7725110
        public void Read(){} // RVA: 0x77252A0
        public void WriteInternal(){} // RVA: 0x77255C0
        public void WriteAsyncMemory(){} // RVA: 0x77256C0
        public void WriteCore(){} // RVA: 0x7725700
        public void Write(){} // RVA: 0x7725790
        public void Flush(){} // RVA: 0x7725AB0
        public void BeginRead(){} // RVA: 0x7725C30
        public void BeginWrite(){} // RVA: 0x7725FF0
        public void EndRead(){} // RVA: 0x77263B0
        public void EndWrite(){} // RVA: 0x77265A0
        public void Seek(){} // RVA: 0x7726780
        public void SetLength(){} // RVA: 0x77267C0
        public void get_CanRead(){} // RVA: 0x7726800
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x7726840
        public void get_Length(){} // RVA: 0x7726880
        public void get_Position(){} // RVA: 0x77268C0
        public void set_Position(){} // RVA: 0x7726900
    }

    public class DeflateStreamNative : Object
    {
        public object feeder;
        public object base_stream;
        public object z_stream;
        public object data;
        public object disposed;
        public object io_buffer;
        public object last_error;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7726940
        public void Finalize(){} // RVA: 0x7726C00
        public void Dispose(){} // RVA: 0x7726C50
        public void Flush(){} // RVA: 0x7727820
        public void ReadZStream(){} // RVA: 0x77278C0
        public void WriteZStream(){} // RVA: 0x7727940
        public void UnmanagedRead(){} // RVA: 0x77271E0
        public void UnmanagedWrite(){} // RVA: 0x7727490
        public void CheckResult(){} // RVA: 0x7727610
        public void CreateZStream(){} // RVA: 0x7727750
        public void CloseZStream(){} // RVA: 0x7727810
    }

    public class DeflaterManaged : Object
    {
        public object _deflateEncoder;
        public object _copyEncoder;
        public object _input;
        public object _output;
        public object _processingState;
        public object _inputFromHistory;

        // ── Methods ──
        public void NeedsInput(){} // RVA: 0x22F5C80
        public void SetInput(){} // RVA: 0x22F5D00
        public void GetDeflateOutput(){} // RVA: 0x724BC40
        public void Finish(){} // RVA: 0x724C150
        public void UseCompressed(){} // RVA: 0x22F6340
        public void FlushInputWindows(){} // RVA: 0x724C200
        public void WriteFinal(){} // RVA: 0x724C220
        public void Dispose(){} // RVA: 0xB43310
    }

    public class FastEncoder : Object
    {
        public object _inputWindow;
        public object _currentMatch;
        public object _lastCompressionRatio;

        // ── Methods ──
        public void get_BytesInHistory(){} // RVA: 0x22F9CD0
        public void get_UnprocessedInput(){} // RVA: 0x724C260
        public void FlushInput(){} // RVA: 0x724C320
        public void get_LastCompressionRatio(){} // RVA: 0x22F9F60
        public void GetBlock(){} // RVA: 0x724C4C0
        public void GetCompressedData(){} // RVA: 0x724C5A0
        public void GetBlockHeader(){} // RVA: 0x724C5C0
        public void GetBlockFooter(){} // RVA: 0x724C5D0
        public void GetCompressedOutput(){} // RVA: 0x724C8E0
        public void InputAvailable(){} // RVA: 0x22FA350
        public void SafeToWriteTo(){} // RVA: 0x22FAD00
        public void WriteEndOfBlock(){} // RVA: 0x724C5D0
        public void WriteMatch(){} // RVA: 0x724C9E0
        public void WriteChar(){} // RVA: 0x724CC60
        public void WriteDeflatePreamble(){} // RVA: 0x724CD00
    }

    public class FastEncoderStatics : Object
    {
        public object FastEncoderTreeStructureData;
        public object BFinalFastEncoderTreeStructureData;
        public object FastEncoderLiteralCodeInfo;
        public object FastEncoderDistanceCodeInfo;
        public object BitMask;
        public object ExtraLengthBits;
        public object ExtraDistanceBits;
        public object s_distLookup;

        // ── Methods ──
        public void CreateDistanceLookup(){} // RVA: 0x724CE10
        public void GetSlot(){} // RVA: 0x724CFD0
        public void BitReverse(){} // RVA: 0x22FB450
        public void .cctor(){} // RVA: 0x724D060
    }

    public class FastEncoderWindow : Object
    {
        public object _window;
        public object _bufPos;
        public object _bufEnd;
        public object _prev;
        public object _lookup;

        // ── Methods ──
        public void get_BytesAvailable(){} // RVA: 0x22FB6F0
        public void get_UnprocessedInput(){} // RVA: 0x724D730
        public void FlushWindow(){} // RVA: 0x724D7F0
        public void ResetWindow(){} // RVA: 0x724D7F0
        public void get_FreeWindowSpace(){} // RVA: 0x22FB470
        public void CopyBytes(){} // RVA: 0x22FB700
        public void MoveWindows(){} // RVA: 0x22FBE40
        public void HashValue(){} // RVA: 0x22FB7F0
        public void InsertString(){} // RVA: 0x22FB750
        public void InsertStrings(){} // RVA: 0x22FBD80
        public void GetNextSymbolOrMatch(){} // RVA: 0x22FB800
        public void FindMatch(){} // RVA: 0x22FBF30
    }

    public class GZipStream : Stream
    {
        public object _deflateStream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7723F10
        public void get_CanRead(){} // RVA: 0x7724010
        public void get_CanWrite(){} // RVA: 0x7724030
        public void get_CanSeek(){} // RVA: 0x7724050
        public void get_Length(){} // RVA: 0x7724070
        public void get_Position(){} // RVA: 0x77240C0
        public void set_Position(){} // RVA: 0x7724110
        public void Flush(){} // RVA: 0x7724160
        public void Seek(){} // RVA: 0x7724190
        public void SetLength(){} // RVA: 0x77241E0
        public void ReadByte(){} // RVA: 0x7724230
        public void BeginRead(){} // RVA: 0x7724260
        public void EndRead(){} // RVA: 0x7724310
        public void Read(){} // RVA: 0x7724390
        public void BeginWrite(){} // RVA: 0x77245F0
        public void EndWrite(){} // RVA: 0x66E7340
        public void Write(){} // RVA: 0x77246E0
        public void CopyTo(){} // RVA: 0x7724840
        public void Dispose(){} // RVA: 0x22FDF00
        public void ReadAsync(){} // RVA: 0x77248B0
        public void WriteAsync(){} // RVA: 0x7724A00
        public void FlushAsync(){} // RVA: 0x7724B10
        public void CopyToAsync(){} // RVA: 0x7724B40
        public void CheckDeflateStream(){} // RVA: 0x7724B80
        public void ThrowStreamClosedException(){} // RVA: 0x7724BA0
    }

    public class HuffmanTree : Object
    {
        public object _tableBits;
        public object _table;
        public object _left;
        public object _right;
        public object _codeLengthArray;
        public object _tableMask;
        public object _staticLiteralLengthTree;
        public object _staticDistanceTree;

        // ── Methods ──
        public void get_StaticLiteralLengthTree(){} // RVA: 0x724D980
        public void get_StaticDistanceTree(){} // RVA: 0x724D9E0
        public void .ctor(){} // RVA: 0x724DA40
        public void GetStaticLiteralTreeLength(){} // RVA: 0x724DC60
        public void GetStaticDistanceTreeLength(){} // RVA: 0x724DD30
        public void CalculateHuffmanCode(){} // RVA: 0x724DDA0
        public void CreateTable(){} // RVA: 0x724DFE0
        public void GetNextSymbol(){} // RVA: 0x724E240
        public void .cctor(){} // RVA: 0x724E420
    }

    public class IFileFormatReader
    {
        // ── Methods ──
        public void ReadHeader(){} // RVA: 0x87D350
        public void ReadFooter(){} // RVA: 0x87D350
        public void UpdateWithBytesRead(){} // RVA: 0x89B9B0
        public void Validate(){} // RVA: 0x894290
    }

    public class IFileFormatWriter
    {
        // ── Methods ──
        public void GetHeader(){} // RVA: 0x87C0A0
        public void UpdateWithBytesRead(){} // RVA: 0x89B9B0
        public void GetFooter(){} // RVA: 0x87C0A0
    }

    public class InflaterManaged : Object
    {
        public object s_extraLengthBits;
        public object s_lengthBase;
        public object s_distanceBasePosition;
        public object s_codeOrder;
        public object s_staticDistanceTreeTable;
        public object _output;
        public object _input;
        public object _literalLengthTree;
        public object _distanceTree;
        public object _state;
        public object _hasFormatReader;
        public object _bfinal;
        public object _blockType;
        public object _blockLengthBuffer;
        public object _blockLength;
        public object _length;
        public object _distanceCode;
        public object _extraBits;
        public object _loopCounter;
        public object _literalLengthCodeCount;
        public object _distanceCodeCount;
        public object _codeLengthCodeCount;
        public object _codeArraySize;
        public object _lengthCode;
        public object _codeList;
        public object _codeLengthTreeCodeLength;
        public object _deflate64;
        public object _codeLengthTree;
        public object _formatReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x724E6D0
        public void Reset(){} // RVA: 0x724EA30
        public void SetInput(){} // RVA: 0x2300230
        public void Finished(){} // RVA: 0x2300340
        public void Inflate(){} // RVA: 0x724EA50
        public void Decode(){} // RVA: 0x724EC70
        public void DecodeUncompressedBlock(){} // RVA: 0x724EFF0
        public void DecodeBlock(){} // RVA: 0x724F280
        public void DecodeDynamicBlockHeader(){} // RVA: 0x724F720
        public void Dispose(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x724FFA0
    }

    public class InputBuffer : Object
    {
        public object _buffer;
        public object _start;
        public object _end;
        public object _bitBuffer;
        public object _bitsInBuffer;

        // ── Methods ──
        public void get_AvailableBits(){} // RVA: 0x15AF000
        public void get_AvailableBytes(){} // RVA: 0x2301EE0
        public void EnsureBitsAvailable(){} // RVA: 0x2301E20
        public void TryLoad16Bits(){} // RVA: 0x2301F00
        public void GetBitMask(){} // RVA: 0x2301ED0
        public void GetBits(){} // RVA: 0x23021D0
        public void CopyTo(){} // RVA: 0x2301FC0
        public void NeedsInput(){} // RVA: 0x2301D80
        public void SetInput(){} // RVA: 0x2302080
        public void SkipBits(){} // RVA: 0x2302100
        public void SkipToByteBoundary(){} // RVA: 0x2302290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Match : Object
    {
        public object _state;
        public object _position;
        public object _length;
        public object _symbol;

        // ── Methods ──
        public void get_State(){} // RVA: 0xB8F8F0
        public void set_State(){} // RVA: 0xB460A0
        public void get_Position(){} // RVA: 0x116A650
        public void set_Position(){} // RVA: 0x116BB10
        public void get_Length(){} // RVA: 0xE62D00
        public void set_Length(){} // RVA: 0x1033F40
        public void get_Symbol(){} // RVA: 0xB5DC00
        public void set_Symbol(){} // RVA: 0xB5DC10
    }

    public class OutputBuffer : Object
    {
        public object _byteBuffer;
        public object _pos;
        public object _bitBuf;
        public object _bitCount;

        // ── Methods ──
        public void UpdateBuffer(){} // RVA: 0x23025E0
        public void get_BytesWritten(){} // RVA: 0xE62D00
        public void get_FreeBytes(){} // RVA: 0x2302720
        public void WriteUInt16(){} // RVA: 0x2302740
        public void WriteBits(){} // RVA: 0x23027A0
        public void FlushBits(){} // RVA: 0x2302690
        public void WriteBytes(){} // RVA: 0x23024F0
        public void WriteBytesUnaligned(){} // RVA: 0x2302840
        public void WriteByteUnaligned(){} // RVA: 0x23025C0
        public void get_BitsInBuffer(){} // RVA: 0x2302440
        public void DumpState(){} // RVA: 0x23025A0
        public void RestoreState(){} // RVA: 0x2302670
    }

    public class OutputWindow : Object
    {
        public object _window;
        public object _end;
        public object _bytesUsed;

        // ── Methods ──
        public void Write(){} // RVA: 0x7250330
        public void WriteLengthDistance(){} // RVA: 0x7250370
        public void CopyFrom(){} // RVA: 0x72504B0
        public void get_FreeBytes(){} // RVA: 0x7250730
        public void get_AvailableBytes(){} // RVA: 0x2244FB0
        public void CopyTo(){} // RVA: 0x7250740
        public void .ctor(){} // RVA: 0x7250800
    }

    public class PositionPreservingWriteOnlyStreamWrapper : Stream
    {
        public object _stream;
        public object _position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7250890
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void get_Position(){} // RVA: 0xD33E60
        public void set_Position(){} // RVA: 0x7250930
        public void Write(){} // RVA: 0x7250980
        public void BeginWrite(){} // RVA: 0x72509C0
        public void EndWrite(){} // RVA: 0x7250A00
        public void WriteByte(){} // RVA: 0x7250A30
        public void WriteAsync(){} // RVA: 0x7250A60
        public void get_CanTimeout(){} // RVA: 0x70F9330
        public void get_ReadTimeout(){} // RVA: 0x70F9470
        public void set_ReadTimeout(){} // RVA: 0x70F94A0
        public void get_WriteTimeout(){} // RVA: 0x70F94D0
        public void set_WriteTimeout(){} // RVA: 0x70F9500
        public void Flush(){} // RVA: 0x6E861D0
        public void FlushAsync(){} // RVA: 0x7250AA0
        public void Close(){} // RVA: 0x7250AD0
        public void Dispose(){} // RVA: 0x7250B00
        public void get_Length(){} // RVA: 0x7250B40
        public void Seek(){} // RVA: 0x7250B90
        public void SetLength(){} // RVA: 0x7250BE0
        public void Read(){} // RVA: 0x7250C30
    }

    public class SubReadStream : Stream
    {
        public object _startInSuperStream;
        public object _positionInSuperStream;
        public object _endInSuperStream;
        public object _superStream;
        public object _canRead;
        public object _isDisposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x725C1A0
        public void get_Length(){} // RVA: 0x725C270
        public void get_Position(){} // RVA: 0x725C290
        public void set_Position(){} // RVA: 0x725C2B0
        public void get_CanRead(){} // RVA: 0x725C310
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xB43320
        public void ThrowIfDisposed(){} // RVA: 0x725C350
        public void ThrowIfCantRead(){} // RVA: 0x725C3E0
        public void Read(){} // RVA: 0x725C460
        public void Seek(){} // RVA: 0x725C5A0
        public void SetLength(){} // RVA: 0x725C600
        public void Write(){} // RVA: 0x725C660
        public void Flush(){} // RVA: 0x725C6C0
        public void Dispose(){} // RVA: 0x725C720
    }

    public class WrappedStream : Stream
    {
        public object _baseStream;
        public object _closeBaseStream;
        public object _onClosed;
        public object _zipArchiveEntry;
        public object _isDisposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x725BAF0
        public void get_Length(){} // RVA: 0x725BB20
        public void get_Position(){} // RVA: 0x725BB60
        public void set_Position(){} // RVA: 0x725BBA0
        public void get_CanRead(){} // RVA: 0x725BC00
        public void get_CanSeek(){} // RVA: 0x725BC40
        public void get_CanWrite(){} // RVA: 0x725BC80
        public void ThrowIfDisposed(){} // RVA: 0x725BCC0
        public void ThrowIfCantRead(){} // RVA: 0x725BD50
        public void ThrowIfCantWrite(){} // RVA: 0x725BDD0
        public void ThrowIfCantSeek(){} // RVA: 0x725BE50
        public void Read(){} // RVA: 0x725BED0
        public void Seek(){} // RVA: 0x725BFA0
        public void SetLength(){} // RVA: 0x725C010
        public void Write(){} // RVA: 0x725C070
        public void Flush(){} // RVA: 0x725C0F0
        public void Dispose(){} // RVA: 0x725C140
    }

    public class Zip64EndOfCentralDirectoryLocator : ValueType
    {
        public object NumberOfDiskWithZip64EOCD;
        public object OffsetOfZip64EOCD;
        public object TotalNumberOfDisks;

        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x725A440
        public void WriteBlock(){} // RVA: 0x725A4F0
    }

    public class Zip64EndOfCentralDirectoryRecord : ValueType
    {
        public object SizeOfThisRecord;
        public object VersionMadeBy;
        public object VersionNeededToExtract;
        public object NumberOfThisDisk;
        public object NumberOfDiskWithStartOfCD;
        public object NumberOfEntriesOnThisDisk;
        public object NumberOfEntriesTotal;
        public object SizeOfCentralDirectory;
        public object OffsetOfCentralDirectory;

        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x725A5D0
        public void WriteBlock(){} // RVA: 0x725A730
    }

    public class Zip64ExtraField : ValueType
    {
        public object _size;
        public object _uncompressedSize;
        public object _compressedSize;
        public object _localHeaderOffset;
        public object _startDiskNumber;

        // ── Methods ──
        public void get_TotalSize(){} // RVA: 0x90A3D0
        public void get_UncompressedSize(){} // RVA: 0xCB720
        public void set_UncompressedSize(){} // RVA: 0x90A3E0
        public void get_CompressedSize(){} // RVA: 0xF7220
        public void set_CompressedSize(){} // RVA: 0x90A400
        public void get_LocalHeaderOffset(){} // RVA: 0x2698F0
        public void set_LocalHeaderOffset(){} // RVA: 0x90A420
        public void get_StartDiskNumber(){} // RVA: 0xA3280
        public void UpdateSize(){} // RVA: 0x90A440
        public void GetJustZip64Block(){} // RVA: 0x7258FC0
        public void TryGetZip64BlockFromGenericExtraField(){} // RVA: 0x7259220
        public void GetAndRemoveZip64Block(){} // RVA: 0x72597B0
        public void RemoveZip64Blocks(){} // RVA: 0x7259DD0
        public void WriteBlock(){} // RVA: 0x90A450
    }

    public class ZipArchive : Object
    {
        public object _archiveStream;
        public object _archiveStreamOwner;
        public object _archiveReader;
        public object _mode;
        public object _entries;
        public object _entriesCollection;
        public object _entriesDictionary;
        public object _readEntries;
        public object _leaveOpen;
        public object _centralDirectoryStart;
        public object _isDisposed;
        public object _numberOfThisDisk;
        public object _expectedNumberOfEntries;
        public object _backingStream;
        public object _archiveComment;
        public object _entryNameEncoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7250D50
        public void get_Mode(){} // RVA: 0x1065D50
        public void CreateEntry(){} // RVA: 0x7250F10
        public void Dispose(){} // RVA: 0x72510B0
        public void get_ArchiveReader(){} // RVA: 0xB700F0
        public void get_ArchiveStream(){} // RVA: 0xB5DBF0
        public void get_NumberOfThisDisk(){} // RVA: 0xE36310
        public void get_EntryNameEncoding(){} // RVA: 0xCD3320
        public void set_EntryNameEncoding(){} // RVA: 0x7251120
        public void DoCreateEntry(){} // RVA: 0x7251230
        public void AcquireArchiveStream(){} // RVA: 0x7251440
        public void AddEntry(){} // RVA: 0x7251560
        public void ReleaseArchiveStream(){} // RVA: 0x30FBB60
        public void RemoveEntry(){} // RVA: 0x7251660
        public void ThrowIfDisposed(){} // RVA: 0x72516F0
        public void CloseStreams(){} // RVA: 0x7251780
        public void EnsureCentralDirectoryRead(){} // RVA: 0x7251820
        public void Init(){} // RVA: 0x7251840
        public void ReadCentralDirectory(){} // RVA: 0x72522A0
        public void ReadEndOfCentralDirectory(){} // RVA: 0x7252530
        public void WriteFile(){} // RVA: 0x7252E00
        public void WriteArchiveEpilogue(){} // RVA: 0x7253560
    }

    public class ZipArchiveEntry : Object
    {
        public object _archive;
        public object _originallyInArchive;
        public object _diskNumberStart;
        public object _versionMadeByPlatform;
        public object _versionMadeBySpecification;
        public object _versionToExtract;
        public object _generalPurposeBitFlag;
        public object _storedCompressionMethod;
        public object _lastModified;
        public object _compressedSize;
        public object _uncompressedSize;
        public object _offsetOfLocalHeader;
        public object _storedOffsetOfCompressedData;
        public object _crc32;
        public object _compressedBytes;
        public object _storedUncompressedData;
        public object _currentlyOpenForWrite;
        public object _everOpenedForWrite;
        public object _outstandingWriteStream;
        public object _externalFileAttr;
        public object _storedEntryName;
        public object _storedEntryNameBytes;
        public object _cdUnknownExtraFields;
        public object _lhUnknownExtraFields;
        public object _fileComment;
        public object _compressionLevel;
        public object s_allowLargeZipArchiveEntriesInUpdateMode;
        public object CurrentZipPlatform;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7253D90
        public void get_FullName(){} // RVA: 0x106A7D0
        public void set_FullName(){} // RVA: 0x7254300
        public void set_LastWriteTime(){} // RVA: 0x72545F0
        public void Delete(){} // RVA: 0x72548B0
        public void Open(){} // RVA: 0x7254A30
        public void ToString(){} // RVA: 0x106A7D0
        public void get_EverOpenedForWrite(){} // RVA: 0xE3A050
        public void get_OffsetOfCompressedData(){} // RVA: 0x7254A90
        public void get_UncompressedData(){} // RVA: 0x7254BF0
        public void get_CompressionMethod(){} // RVA: 0x4FF5720
        public void set_CompressionMethod(){} // RVA: 0x7254E10
        public void DecodeEntryName(){} // RVA: 0x7254E60
        public void EncodeEntryName(){} // RVA: 0x7254EC0
        public void WriteAndFinishLocalEntry(){} // RVA: 0x7254FF0
        public void WriteCentralDirectoryFileHeader(){} // RVA: 0x7255040
        public void LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded(){} // RVA: 0x72556A0
        public void ThrowIfNotOpenable(){} // RVA: 0x7255BE0
        public void GetDataCompressor(){} // RVA: 0x7255C60
        public void GetDataDecompressor(){} // RVA: 0x7255F30
        public void OpenInReadMode(){} // RVA: 0x7256130
        public void OpenInWriteMode(){} // RVA: 0x7256200
        public void OpenInUpdateMode(){} // RVA: 0x72564D0
        public void IsOpenable(){} // RVA: 0x7256720
        public void SizesTooLarge(){} // RVA: 0x7256AA0
        public void WriteLocalFileHeader(){} // RVA: 0x7256AC0
        public void WriteLocalFileHeaderAndDataIfNeeded(){} // RVA: 0x7257010
        public void WriteCrcAndSizesInLocalHeader(){} // RVA: 0x7257300
        public void WriteDataDescriptor(){} // RVA: 0x7257650
        public void UnloadStreams(){} // RVA: 0x7257790
        public void CloseStreams(){} // RVA: 0x7257880
        public void VersionToExtractAtLeast(){} // RVA: 0x72578B0
        public void ThrowIfInvalidArchive(){} // RVA: 0x72578D0
        public void GetFileName_Windows(){} // RVA: 0x7257940
        public void GetFileName_Unix(){} // RVA: 0x72579C0
        public void ParseFileName(){} // RVA: 0x7257A30
        public void .cctor(){} // RVA: 0x7257B90
    }

    public class ZipCentralDirectoryFileHeader : ValueType
    {
        public object VersionMadeByCompatibility;
        public object VersionMadeBySpecification;
        public object VersionNeededToExtract;
        public object GeneralPurposeBitFlag;
        public object CompressionMethod;
        public object LastModified;
        public object Crc32;
        public object CompressedSize;
        public object UncompressedSize;
        public object FilenameLength;
        public object ExtraFieldLength;
        public object FileCommentLength;
        public object DiskNumberStart;
        public object InternalFileAttributes;
        public object ExternalFileAttributes;
        public object RelativeOffsetOfLocalHeader;
        public object Filename;
        public object FileComment;
        public object ExtraFields;

        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x725AD00
    }

    public class ZipEndOfCentralDirectoryBlock : ValueType
    {
        public object Signature;
        public object NumberOfThisDisk;
        public object NumberOfTheDiskWithTheStartOfTheCentralDirectory;
        public object NumberOfEntriesInTheCentralDirectoryOnThisDisk;
        public object NumberOfEntriesInTheCentralDirectory;
        public object SizeOfCentralDirectory;
        public object OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;
        public object ArchiveComment;

        // ── Methods ──
        public void WriteBlock(){} // RVA: 0x725B620
        public void TryReadBlock(){} // RVA: 0x725B7D0
    }

    public class ZipFileExtensions : Object
    {
        // ── Methods ──
        public void CreateEntryFromFile(){} // RVA: 0x725E290
        public void DoCreateEntryFromFile(){} // RVA: 0x725E2B0
    }

    public class ZipGenericExtraField : ValueType
    {
        public object _tag;
        public object _size;
        public object _data;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0xE3300
        public void get_Size(){} // RVA: 0xE32E0
        public void get_Data(){} // RVA: 0x77ED0
        public void WriteBlock(){} // RVA: 0x90A300
        public void TryReadBlock(){} // RVA: 0x72587A0
        public void ParseExtraField(){} // RVA: 0x7258910
        public void TotalSize(){} // RVA: 0x7258BA0
        public void WriteAllBlocks(){} // RVA: 0x7258D00
    }

    public class ZipHelper : Object
    {
        public object s_invalidDateIndicator;

        // ── Methods ──
        public void RequiresUnicode(){} // RVA: 0x725CFD0
        public void ReadBytes(){} // RVA: 0x725D030
        public void DosTimeToDateTime(){} // RVA: 0x725D100
        public void DateTimeToDosTime(){} // RVA: 0x725D1B0
        public void SeekBackwardsToSignature(){} // RVA: 0x725D340
        public void AdvanceToPosition(){} // RVA: 0x725D5B0
        public void SeekBackwardsAndRead(){} // RVA: 0x725D6B0
        public void .cctor(){} // RVA: 0x725D840
    }

    public class ZipLocalFileHeader : ValueType
    {
        // ── Methods ──
        public void GetExtraFields(){} // RVA: 0x725A8C0
        public void TrySkipBlock(){} // RVA: 0x725AAF0
    }

}