// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Compression
// Classes: 34
// Methods: 385

namespace ThirdParty.DotNet.System.IO.Compression
{
    public class CheckSumAndSizeWriteStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5E5830
        public void get_Length(){} // RVA: 0x7AE5E5A50
        public void get_Position(){} // RVA: 0x7AE5E5AB0
        public void set_Position(){} // RVA: 0x7AE5E5AD0
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A9A933F0
        public void ThrowIfDisposed(){} // RVA: 0x7AE5E5B30
        public void Read(){} // RVA: 0x7AE5E5BC0
        public void Seek(){} // RVA: 0x7AE5E5C20
        public void SetLength(){} // RVA: 0x7AE5E5C80
        public void Write(){} // RVA: 0x7AE5E5CE0
        public void Flush(){} // RVA: 0x7AE5E5F90
        public void Dispose(){} // RVA: 0x7AE5E5FD0
    }

    public class CopyEncoder : Object
    {
        // ── Methods ──
        public void GetBlock(){} // RVA: 0x7AE5D1E10
        public void WriteLenNLen(){} // RVA: 0x7A97E8FC0
    }

    public class Crc32Helper : Object
    {
        // ── Methods ──
        public void UpdateCrc32(){} // RVA: 0x7AE5E69D0
        public void ManagedCrc32(){} // RVA: 0x7AE5E6A60
        public void .cctor(){} // RVA: 0x7AE5E6E20
    }

    public class DeflateInput : Object
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7A80F2570
        public void set_Buffer(){} // RVA: 0x7A80D8E20
        public void get_Count(){} // RVA: 0x7A83782A0
        public void set_Count(){} // RVA: 0x7A84385B0
        public void get_StartIndex(){} // RVA: 0x7A9739200
        public void set_StartIndex(){} // RVA: 0x7A9746990
        public void ConsumeBytes(){} // RVA: 0x7A97E9720
        public void DumpState(){} // RVA: 0x7A97E9700
        public void RestoreState(){} // RVA: 0x7A97E9730
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DeflateManagedStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5D20B0
        public void InitializeInflater(){} // RVA: 0x7AE5D2210
        public void get_CanRead(){} // RVA: 0x7A97EAC70
        public void get_CanWrite(){} // RVA: 0x7A97EC2C0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7AE5D2460
        public void get_Position(){} // RVA: 0x7AE5D24B0
        public void set_Position(){} // RVA: 0x7AE5D2500
        public void Flush(){} // RVA: 0x7AE5D2550
        public void FlushAsync(){} // RVA: 0x7AE5D2570
        public void Seek(){} // RVA: 0x7AE5D2670
        public void SetLength(){} // RVA: 0x7AE5D26C0
        public void Read(){} // RVA: 0x7AE5D2710
        public void ValidateParameters(){} // RVA: 0x7AE5D2910
        public void EnsureNotDisposed(){} // RVA: 0x7AE5D2550
        public void ThrowStreamClosedException(){} // RVA: 0x7AE5D2A70
        public void EnsureDecompressionMode(){} // RVA: 0x7AE5D2AD0
        public void ThrowCannotReadFromDeflateManagedStreamException(){} // RVA: 0x7AE5D2AF0
        public void EnsureCompressionMode(){} // RVA: 0x7AE5D2B40
        public void ThrowCannotWriteToDeflateManagedStreamException(){} // RVA: 0x7AE5D2B60
        public void BeginRead(){} // RVA: 0x7AE5D2BB0
        public void EndRead(){} // RVA: 0x7AE5D2C60
        public void ReadAsync(){} // RVA: 0x7AE5D2CA0
        public void ReadAsyncCore(){} // RVA: 0x7AE5D3050
        public void Write(){} // RVA: 0x7AE5D3310
        public void WriteDeflaterOutput(){} // RVA: 0x7AE5D34F0
        public void DoMaintenance(){} // RVA: 0x7AE5D3580
        public void PurgeBuffers(){} // RVA: 0x7AE5D3660
        public void Dispose(){} // RVA: 0x7AE5D3890
        public void WriteAsync(){} // RVA: 0x7AE5D3C00
        public void WriteAsyncCore(){} // RVA: 0x7AE5D3D90
        public void BeginWrite(){} // RVA: 0x7AE5D4020
        public void EndWrite(){} // RVA: 0x7AE5D40D0
        public void <>n__0(){} // RVA: 0x7ADC4D1F0
    }

    public class DeflateStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAB5570
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void Dispose(){} // RVA: 0x7AEAB5590
        public void ReadInternal(){} // RVA: 0x7AEAB5650
        public void ReadAsyncMemory(){} // RVA: 0x7AEAB5760
        public void ReadCore(){} // RVA: 0x7AEAB57A0
        public void Read(){} // RVA: 0x7AEAB5930
        public void WriteInternal(){} // RVA: 0x7AEAB5C50
        public void WriteAsyncMemory(){} // RVA: 0x7AEAB5D50
        public void WriteCore(){} // RVA: 0x7AEAB5D90
        public void Write(){} // RVA: 0x7AEAB5E20
        public void Flush(){} // RVA: 0x7AEAB6140
        public void BeginRead(){} // RVA: 0x7AEAB62C0
        public void BeginWrite(){} // RVA: 0x7AEAB66A0
        public void EndRead(){} // RVA: 0x7AEAB6A80
        public void EndWrite(){} // RVA: 0x7AEAB6C70
        public void Seek(){} // RVA: 0x7AEAB6E50
        public void SetLength(){} // RVA: 0x7AEAB6E90
        public void get_CanRead(){} // RVA: 0x7AEAB6ED0
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7AEAB6F10
        public void get_Length(){} // RVA: 0x7AEAB6F50
        public void get_Position(){} // RVA: 0x7AEAB6F90
        public void set_Position(){} // RVA: 0x7AEAB6FD0
    }

    public class DeflateStreamNative : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AEAB7150
        public void Finalize(){} // RVA: 0x7AEAB7410
        public void Dispose(){} // RVA: 0x7AEAB7460
        public void Flush(){} // RVA: 0x7AEAB8030
        public void ReadZStream(){} // RVA: 0x7AEAB80D0
        public void WriteZStream(){} // RVA: 0x7AEAB8150
        public void UnmanagedRead(){} // RVA: 0x7AEAB79F0
        public void UnmanagedWrite(){} // RVA: 0x7AEAB7CA0
        public void CheckResult(){} // RVA: 0x7AEAB7E20
        public void CreateZStream(){} // RVA: 0x7AEAB7F60
        public void CloseZStream(){} // RVA: 0x7AEAB8020
    }

    public class DeflaterManaged : Object
    {
        // ── Methods ──
        public void NeedsInput(){} // RVA: 0x7A97E9F30
        public void SetInput(){} // RVA: 0x7A97EA0C0
        public void GetDeflateOutput(){} // RVA: 0x7AE5D4D30
        public void Finish(){} // RVA: 0x7AE5D5240
        public void UseCompressed(){} // RVA: 0x7A97E9F20
        public void FlushInputWindows(){} // RVA: 0x7AE5D52F0
        public void WriteFinal(){} // RVA: 0x7AE5D5310
        public void Dispose(){} // RVA: 0x7A80D7310
    }

    public class FastEncoder : Object
    {
        // ── Methods ──
        public void get_BytesInHistory(){} // RVA: 0x7A97EDC30
        public void get_UnprocessedInput(){} // RVA: 0x7AE5D5350
        public void FlushInput(){} // RVA: 0x7AE5D5410
        public void get_LastCompressionRatio(){} // RVA: 0x7A97EDE10
        public void GetBlock(){} // RVA: 0x7AE5D55B0
        public void GetCompressedData(){} // RVA: 0x7AE5D5690
        public void GetBlockHeader(){} // RVA: 0x7AE5D56B0
        public void GetBlockFooter(){} // RVA: 0x7AE5D56C0
        public void GetCompressedOutput(){} // RVA: 0x7AE5D59D0
        public void InputAvailable(){} // RVA: 0x7A97EE670
        public void SafeToWriteTo(){} // RVA: 0x7A97EE070
        public void WriteEndOfBlock(){} // RVA: 0x7AE5D56C0
        public void WriteMatch(){} // RVA: 0x7AE5D5AD0
        public void WriteChar(){} // RVA: 0x7AE5D5D50
        public void WriteDeflatePreamble(){} // RVA: 0x7AE5D5DF0
    }

    public class FastEncoderStatics : Object
    {
        // ── Methods ──
        public void CreateDistanceLookup(){} // RVA: 0x7AE5D5F00
        public void GetSlot(){} // RVA: 0x7AE5D60C0
        public void BitReverse(){} // RVA: 0x7A97EEDD0
        public void .cctor(){} // RVA: 0x7AE5D6150
    }

    public class FastEncoderWindow : Object
    {
        // ── Methods ──
        public void get_BytesAvailable(){} // RVA: 0x7A97EF4E0
        public void get_UnprocessedInput(){} // RVA: 0x7AE5D6820
        public void FlushWindow(){} // RVA: 0x7AE5D68E0
        public void ResetWindow(){} // RVA: 0x7AE5D68E0
        public void get_FreeWindowSpace(){} // RVA: 0x7A97EF740
        public void CopyBytes(){} // RVA: 0x7A97EFB10
        public void MoveWindows(){} // RVA: 0x7A97EF750
        public void HashValue(){} // RVA: 0x7A97EFF40
        public void InsertString(){} // RVA: 0x7A97EFCD0
        public void InsertStrings(){} // RVA: 0x7A97EEDF0
        public void GetNextSymbolOrMatch(){} // RVA: 0x7A97EEEB0
        public void FindMatch(){} // RVA: 0x7A97EFB60
    }

    public class GZipStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAB44E0
        public void get_CanRead(){} // RVA: 0x7AEAB45E0
        public void get_CanWrite(){} // RVA: 0x7AEAB4600
        public void get_CanSeek(){} // RVA: 0x7AEAB4620
        public void get_Length(){} // RVA: 0x7AEAB4640
        public void get_Position(){} // RVA: 0x7AEAB4690
        public void set_Position(){} // RVA: 0x7AEAB46E0
        public void Flush(){} // RVA: 0x7AEAB4730
        public void Seek(){} // RVA: 0x7AEAB4760
        public void SetLength(){} // RVA: 0x7AEAB47B0
        public void ReadByte(){} // RVA: 0x7AEAB4800
        public void BeginRead(){} // RVA: 0x7AEAB4830
        public void EndRead(){} // RVA: 0x7AEAB48E0
        public void Read(){} // RVA: 0x7AEAB4960
        public void BeginWrite(){} // RVA: 0x7AEAB4BF0
        public void EndWrite(){} // RVA: 0x7ADA5CD30
        public void Write(){} // RVA: 0x7AEAB4CE0
        public void CopyTo(){} // RVA: 0x7AEAB4E70
        public void Dispose(){} // RVA: 0x7A97F24D0
        public void ReadAsync(){} // RVA: 0x7AEAB4EE0
        public void WriteAsync(){} // RVA: 0x7AEAB5060
        public void FlushAsync(){} // RVA: 0x7AEAB51A0
        public void CopyToAsync(){} // RVA: 0x7AEAB51D0
        public void CheckDeflateStream(){} // RVA: 0x7AEAB5210
        public void ThrowStreamClosedException(){} // RVA: 0x7AEAB5230
    }

    public class HuffmanTree : Object
    {
        // ── Methods ──
        public void get_StaticLiteralLengthTree(){} // RVA: 0x7AE5D6A70
        public void get_StaticDistanceTree(){} // RVA: 0x7AE5D6AD0
        public void .ctor(){} // RVA: 0x7AE5D6B30
        public void GetStaticLiteralTreeLength(){} // RVA: 0x7AE5D6D50
        public void GetStaticDistanceTreeLength(){} // RVA: 0x7AE5D6E20
        public void CalculateHuffmanCode(){} // RVA: 0x7AE5D6E90
        public void CreateTable(){} // RVA: 0x7AE5D70D0
        public void GetNextSymbol(){} // RVA: 0x7AE5D7330
        public void .cctor(){} // RVA: 0x7AE5D7510
    }

    public class IFileFormatReader
    {
        // ── Methods ──
        public void ReadHeader(){} // RVA: 0x7A7E019D0
        public void ReadFooter(){} // RVA: 0x7A7E019D0
        public void UpdateWithBytesRead(){} // RVA: 0x7A7E1E220
        public void Validate(){} // RVA: 0x7A7E18770
    }

    public class IFileFormatWriter
    {
        // ── Methods ──
        public void GetHeader(){} // RVA: 0x7A7E00680
        public void UpdateWithBytesRead(){} // RVA: 0x7A7E1E220
        public void GetFooter(){} // RVA: 0x7A7E00680
    }

    public class InflaterManaged : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5D77C0
        public void Reset(){} // RVA: 0x7AE5D7B20
        public void SetInput(){} // RVA: 0x7A97F5210
        public void Finished(){} // RVA: 0x7A97F71A0
        public void Inflate(){} // RVA: 0x7AE5D7B40
        public void Decode(){} // RVA: 0x7AE5D7D60
        public void DecodeUncompressedBlock(){} // RVA: 0x7AE5D80E0
        public void DecodeBlock(){} // RVA: 0x7AE5D8370
        public void DecodeDynamicBlockHeader(){} // RVA: 0x7AE5D8810
        public void Dispose(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE5D9090
    }

    public class InputBuffer : Object
    {
        // ── Methods ──
        public void get_AvailableBits(){} // RVA: 0x7A8AB15F0
        public void get_AvailableBytes(){} // RVA: 0x7A97F74A0
        public void EnsureBitsAvailable(){} // RVA: 0x7A97F72B0
        public void TryLoad16Bits(){} // RVA: 0x7A97F7560
        public void GetBitMask(){} // RVA: 0x7A97F7800
        public void GetBits(){} // RVA: 0x7A97F7500
        public void CopyTo(){} // RVA: 0x7A97F7620
        public void NeedsInput(){} // RVA: 0x7A97F71E0
        public void SetInput(){} // RVA: 0x7A97F7360
        public void SkipBits(){} // RVA: 0x7A97F71F0
        public void SkipToByteBoundary(){} // RVA: 0x7A97F74C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Match : Object
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7A8124910
        public void set_State(){} // RVA: 0x7A80DA0C0
        public void get_Position(){} // RVA: 0x7A8668BC0
        public void set_Position(){} // RVA: 0x7A8669360
        public void get_Length(){} // RVA: 0x7A83782A0
        public void set_Length(){} // RVA: 0x7A84385B0
        public void get_Symbol(){} // RVA: 0x7A80F2580
        public void set_Symbol(){} // RVA: 0x7A80F2590
    }

    public class OutputBuffer : Object
    {
        // ── Methods ──
        public void UpdateBuffer(){} // RVA: 0x7A97F7CC0
        public void get_BytesWritten(){} // RVA: 0x7A83782A0
        public void get_FreeBytes(){} // RVA: 0x7A97F7A90
        public void WriteUInt16(){} // RVA: 0x7A97F7A30
        public void WriteBits(){} // RVA: 0x7A97F7D40
        public void FlushBits(){} // RVA: 0x7A97F7AB0
        public void WriteBytes(){} // RVA: 0x7A97F7BD0
        public void WriteBytesUnaligned(){} // RVA: 0x7A97F7900
        public void WriteByteUnaligned(){} // RVA: 0x7A97F7C80
        public void get_BitsInBuffer(){} // RVA: 0x7A97F7D30
        public void DumpState(){} // RVA: 0x7A97F7980
        public void RestoreState(){} // RVA: 0x7A97F7CA0
    }

    public class OutputWindow : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7AE5D9420
        public void WriteLengthDistance(){} // RVA: 0x7AE5D9460
        public void CopyFrom(){} // RVA: 0x7AE5D95A0
        public void get_FreeBytes(){} // RVA: 0x7AE5D9820
        public void get_AvailableBytes(){} // RVA: 0x7A9739200
        public void CopyTo(){} // RVA: 0x7AE5D9830
        public void .ctor(){} // RVA: 0x7AE5D98F0
    }

    public class PositionPreservingWriteOnlyStreamWrapper : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5D9980
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A81BD750
        public void get_Position(){} // RVA: 0x7A83F69F0
        public void set_Position(){} // RVA: 0x7AE5D9A20
        public void Write(){} // RVA: 0x7AE5D9A70
        public void BeginWrite(){} // RVA: 0x7AE5D9AB0
        public void EndWrite(){} // RVA: 0x7AE5D9AF0
        public void WriteByte(){} // RVA: 0x7AE5D9B20
        public void WriteAsync(){} // RVA: 0x7AE5D9B50
        public void get_CanTimeout(){} // RVA: 0x7AE47D240
        public void get_ReadTimeout(){} // RVA: 0x7AE47D380
        public void set_ReadTimeout(){} // RVA: 0x7AE47D3B0
        public void get_WriteTimeout(){} // RVA: 0x7AE47D3E0
        public void set_WriteTimeout(){} // RVA: 0x7AE47D410
        public void Flush(){} // RVA: 0x7AE203670
        public void FlushAsync(){} // RVA: 0x7AE5D9B90
        public void Close(){} // RVA: 0x7AE5D9BC0
        public void Dispose(){} // RVA: 0x7AE5D9BF0
        public void get_Length(){} // RVA: 0x7AE5D9C30
        public void Seek(){} // RVA: 0x7AE5D9C80
        public void SetLength(){} // RVA: 0x7AE5D9CD0
        public void Read(){} // RVA: 0x7AE5D9D20
    }

    public class SubReadStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5E5290
        public void get_Length(){} // RVA: 0x7AE5E5360
        public void get_Position(){} // RVA: 0x7AE5E5380
        public void set_Position(){} // RVA: 0x7AE5E53A0
        public void get_CanRead(){} // RVA: 0x7AE5E5400
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void ThrowIfDisposed(){} // RVA: 0x7AE5E5440
        public void ThrowIfCantRead(){} // RVA: 0x7AE5E54D0
        public void Read(){} // RVA: 0x7AE5E5550
        public void Seek(){} // RVA: 0x7AE5E5690
        public void SetLength(){} // RVA: 0x7AE5E56F0
        public void Write(){} // RVA: 0x7AE5E5750
        public void Flush(){} // RVA: 0x7AE5E57B0
        public void Dispose(){} // RVA: 0x7AE5E5810
    }

    public class WrappedStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5E4BE0
        public void get_Length(){} // RVA: 0x7AE5E4C10
        public void get_Position(){} // RVA: 0x7AE5E4C50
        public void set_Position(){} // RVA: 0x7AE5E4C90
        public void get_CanRead(){} // RVA: 0x7AE5E4CF0
        public void get_CanSeek(){} // RVA: 0x7AE5E4D30
        public void get_CanWrite(){} // RVA: 0x7AE5E4D70
        public void ThrowIfDisposed(){} // RVA: 0x7AE5E4DB0
        public void ThrowIfCantRead(){} // RVA: 0x7AE5E4E40
        public void ThrowIfCantWrite(){} // RVA: 0x7AE5E4EC0
        public void ThrowIfCantSeek(){} // RVA: 0x7AE5E4F40
        public void Read(){} // RVA: 0x7AE5E4FC0
        public void Seek(){} // RVA: 0x7AE5E5090
        public void SetLength(){} // RVA: 0x7AE5E5100
        public void Write(){} // RVA: 0x7AE5E5160
        public void Flush(){} // RVA: 0x7AE5E51E0
        public void Dispose(){} // RVA: 0x7AE5E5230
    }

    public class Zip64EndOfCentralDirectoryLocator : ValueType
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7AE5E3530
        public void WriteBlock(){} // RVA: 0x7AE5E35E0
    }

    public class Zip64EndOfCentralDirectoryRecord : ValueType
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7AE5E36C0
        public void WriteBlock(){} // RVA: 0x7AE5E3820
    }

    public class Zip64ExtraField : ValueType
    {
        // ── Methods ──
        public void get_TotalSize(){} // RVA: 0x7A7E8A800
        public void get_UncompressedSize(){} // RVA: 0x7A76B2030
        public void set_UncompressedSize(){} // RVA: 0x7A7E8A810
        public void get_CompressedSize(){} // RVA: 0x7A76D9A20
        public void set_CompressedSize(){} // RVA: 0x7A7E8A830
        public void get_LocalHeaderOffset(){} // RVA: 0x7A7827F80
        public void set_LocalHeaderOffset(){} // RVA: 0x7A7E8A850
        public void get_StartDiskNumber(){} // RVA: 0x7A768E4B0
        public void UpdateSize(){} // RVA: 0x7A7E8A870
        public void GetJustZip64Block(){} // RVA: 0x7AE5E20B0
        public void TryGetZip64BlockFromGenericExtraField(){} // RVA: 0x7AE5E2310
        public void GetAndRemoveZip64Block(){} // RVA: 0x7AE5E28A0
        public void RemoveZip64Blocks(){} // RVA: 0x7AE5E2EC0
        public void WriteBlock(){} // RVA: 0x7A7E8A880
    }

    public class ZipArchive : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5D9E40
        public void get_Mode(){} // RVA: 0x7A854FDE0
        public void CreateEntry(){} // RVA: 0x7AE5DA000
        public void Dispose(){} // RVA: 0x7AE5DA1A0
        public void get_ArchiveReader(){} // RVA: 0x7A81052C0
        public void get_ArchiveStream(){} // RVA: 0x7A80F2570
        public void get_NumberOfThisDisk(){} // RVA: 0x7A835E820
        public void get_EntryNameEncoding(){} // RVA: 0x7A82C2060
        public void set_EntryNameEncoding(){} // RVA: 0x7AE5DA210
        public void DoCreateEntry(){} // RVA: 0x7AE5DA320
        public void AcquireArchiveStream(){} // RVA: 0x7AE5DA530
        public void AddEntry(){} // RVA: 0x7AE5DA650
        public void ReleaseArchiveStream(){} // RVA: 0x7AA4BE520
        public void RemoveEntry(){} // RVA: 0x7AE5DA750
        public void ThrowIfDisposed(){} // RVA: 0x7AE5DA7E0
        public void CloseStreams(){} // RVA: 0x7AE5DA870
        public void EnsureCentralDirectoryRead(){} // RVA: 0x7AE5DA910
        public void Init(){} // RVA: 0x7AE5DA930
        public void ReadCentralDirectory(){} // RVA: 0x7AE5DB390
        public void ReadEndOfCentralDirectory(){} // RVA: 0x7AE5DB620
        public void WriteFile(){} // RVA: 0x7AE5DBEF0
        public void WriteArchiveEpilogue(){} // RVA: 0x7AE5DC650
    }

    public class ZipArchiveEntry : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE5DCE80
        public void get_FullName(){} // RVA: 0x7A87D9C10
        public void set_FullName(){} // RVA: 0x7AE5DD3F0
        public void set_LastWriteTime(){} // RVA: 0x7AE5DD6E0
        public void Delete(){} // RVA: 0x7AE5DD9A0
        public void Open(){} // RVA: 0x7AE5DDB20
        public void ToString(){} // RVA: 0x7A87D9C10
        public void get_EverOpenedForWrite(){} // RVA: 0x7A8358B70
        public void get_OffsetOfCompressedData(){} // RVA: 0x7AE5DDB80
        public void get_UncompressedData(){} // RVA: 0x7AE5DDCE0
        public void get_CompressionMethod(){} // RVA: 0x7AC2A83C0
        public void set_CompressionMethod(){} // RVA: 0x7AE5DDF00
        public void DecodeEntryName(){} // RVA: 0x7AE5DDF50
        public void EncodeEntryName(){} // RVA: 0x7AE5DDFB0
        public void WriteAndFinishLocalEntry(){} // RVA: 0x7AE5DE0E0
        public void WriteCentralDirectoryFileHeader(){} // RVA: 0x7AE5DE130
        public void LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded(){} // RVA: 0x7AE5DE790
        public void ThrowIfNotOpenable(){} // RVA: 0x7AE5DECD0
        public void GetDataCompressor(){} // RVA: 0x7AE5DED50
        public void GetDataDecompressor(){} // RVA: 0x7AE5DF020
        public void OpenInReadMode(){} // RVA: 0x7AE5DF220
        public void OpenInWriteMode(){} // RVA: 0x7AE5DF2F0
        public void OpenInUpdateMode(){} // RVA: 0x7AE5DF5C0
        public void IsOpenable(){} // RVA: 0x7AE5DF810
        public void SizesTooLarge(){} // RVA: 0x7AE5DFB90
        public void WriteLocalFileHeader(){} // RVA: 0x7AE5DFBB0
        public void WriteLocalFileHeaderAndDataIfNeeded(){} // RVA: 0x7AE5E0100
        public void WriteCrcAndSizesInLocalHeader(){} // RVA: 0x7AE5E03F0
        public void WriteDataDescriptor(){} // RVA: 0x7AE5E0740
        public void UnloadStreams(){} // RVA: 0x7AE5E0880
        public void CloseStreams(){} // RVA: 0x7AE5E0970
        public void VersionToExtractAtLeast(){} // RVA: 0x7AE5E09A0
        public void ThrowIfInvalidArchive(){} // RVA: 0x7AE5E09C0
        public void GetFileName_Windows(){} // RVA: 0x7AE5E0A30
        public void GetFileName_Unix(){} // RVA: 0x7AE5E0AB0
        public void ParseFileName(){} // RVA: 0x7AE5E0B20
        public void .cctor(){} // RVA: 0x7AE5E0C80
    }

    public class ZipCentralDirectoryFileHeader : ValueType
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7AE5E3DF0
    }

    public class ZipEndOfCentralDirectoryBlock : ValueType
    {
        // ── Methods ──
        public void WriteBlock(){} // RVA: 0x7AE5E4710
        public void TryReadBlock(){} // RVA: 0x7AE5E48C0
    }

    public class ZipFileExtensions : Object
    {
        // ── Methods ──
        public void CreateEntryFromFile(){} // RVA: 0x7AE5E7890
        public void DoCreateEntryFromFile(){} // RVA: 0x7AE5E78B0
    }

    public class ZipGenericExtraField : ValueType
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A76C87F0
        public void get_Size(){} // RVA: 0x7A76C8820
        public void get_Data(){} // RVA: 0x7A765F080
        public void WriteBlock(){} // RVA: 0x7A7E8A7D0
        public void TryReadBlock(){} // RVA: 0x7AE5E1890
        public void ParseExtraField(){} // RVA: 0x7AE5E1A00
        public void TotalSize(){} // RVA: 0x7AE5E1C90
        public void WriteAllBlocks(){} // RVA: 0x7AE5E1DF0
    }

    public class ZipHelper : Object
    {
        // ── Methods ──
        public void RequiresUnicode(){} // RVA: 0x7AE5E60C0
        public void ReadBytes(){} // RVA: 0x7AE5E6120
        public void DosTimeToDateTime(){} // RVA: 0x7AE5E61F0
        public void DateTimeToDosTime(){} // RVA: 0x7AE5E62A0
        public void SeekBackwardsToSignature(){} // RVA: 0x7AE5E6430
        public void AdvanceToPosition(){} // RVA: 0x7AE5E66A0
        public void SeekBackwardsAndRead(){} // RVA: 0x7AE5E67A0
        public void .cctor(){} // RVA: 0x7AE5E6930
    }

    public class ZipLocalFileHeader : ValueType
    {
        // ── Methods ──
        public void GetExtraFields(){} // RVA: 0x7AE5E39B0
        public void TrySkipBlock(){} // RVA: 0x7AE5E3BE0
    }

}