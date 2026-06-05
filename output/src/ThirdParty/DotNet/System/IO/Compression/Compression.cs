// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Compression
// Classes: 34
// Methods: 410

namespace ThirdParty.DotNet.System.IO.Compression
{
    public class CheckSumAndSizeWriteStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92A6FF0
        public void get_Length(){} // RVA: 0x7FFAF92A7210
        public void get_Position(){} // RVA: 0x7FFAF92A7270
        public void set_Position(){} // RVA: 0x7FFAF92A7290
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF4740FC0
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF92A72F0
        public void Read(){} // RVA: 0x7FFAF92A7380
        public void Seek(){} // RVA: 0x7FFAF92A73E0
        public void SetLength(){} // RVA: 0x7FFAF92A7440
        public void Write(){} // RVA: 0x7FFAF92A74A0
        public void Flush(){} // RVA: 0x7FFAF92A7750
        public void Dispose(){} // RVA: 0x7FFAF92A7790
    }

    public class CopyEncoder
    {
        // ── Methods ──
        public void GetBlock(){} // RVA: 0x7FFAF9293A40
        public void WriteLenNLen(){} // RVA: 0x7FFAF44DF7C0
    }

    public class Crc32Helper
    {
        // ── Methods ──
        public void UpdateCrc32(){} // RVA: 0x7FFAF92A8180
        public void ManagedCrc32(){} // RVA: 0x7FFAF92A8210
        public void .cctor(){} // RVA: 0x7FFAF92A85D0
    }

    public class DeflateInput
    {
        // ── Methods ──
        public void get_Buffer(){} // RVA: 0x7FFAF2DA8380
        public void set_Buffer(){} // RVA: 0x7FFAF2D8EE30
        public void get_Count(){} // RVA: 0x7FFAF306ED50
        public void set_Count(){} // RVA: 0x7FFAF30E74E0
        public void get_StartIndex(){} // RVA: 0x7FFAF442C3B0
        public void set_StartIndex(){} // RVA: 0x7FFAF4439FD0
        public void ConsumeBytes(){} // RVA: 0x7FFAF44DFFA0
        public void DumpState(){} // RVA: 0x7FFAF44DFF80
        public void RestoreState(){} // RVA: 0x7FFAF44DFFB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DeflateManagedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9293CD0
        public void InitializeInflater(){} // RVA: 0x7FFAF9293E30
        public void get_CanRead(){} // RVA: 0x7FFAF44E1510
        public void get_CanWrite(){} // RVA: 0x7FFAF44E2BC0
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF9294060
        public void get_Position(){} // RVA: 0x7FFAF92940B0
        public void set_Position(){} // RVA: 0x7FFAF9294100
        public void Flush(){} // RVA: 0x7FFAF9294150
        public void FlushAsync(){} // RVA: 0x7FFAF9294170
        public void Seek(){} // RVA: 0x7FFAF9294270
        public void SetLength(){} // RVA: 0x7FFAF92942C0
        public void Read(){} // RVA: 0x7FFAF9294310
        public void ValidateParameters(){} // RVA: 0x7FFAF9294510
        public void EnsureNotDisposed(){} // RVA: 0x7FFAF9294150
        public void ThrowStreamClosedException(){} // RVA: 0x7FFAF9294670
        public void EnsureDecompressionMode(){} // RVA: 0x7FFAF92946D0
        public void ThrowCannotReadFromDeflateManagedStreamException(){} // RVA: 0x7FFAF92946F0
        public void EnsureCompressionMode(){} // RVA: 0x7FFAF9294740
        public void ThrowCannotWriteToDeflateManagedStreamException(){} // RVA: 0x7FFAF9294760
        public void BeginRead(){} // RVA: 0x7FFAF92947B0
        public void EndRead(){} // RVA: 0x7FFAF9294860
        public void ReadAsync(){} // RVA: 0x7FFAF92948A0
        public void ReadAsyncCore(){} // RVA: 0x7FFAF9294C50
        public void Write(){} // RVA: 0x7FFAF9294EF0
        public void WriteDeflaterOutput(){} // RVA: 0x7FFAF92950D0
        public void DoMaintenance(){} // RVA: 0x7FFAF9295160
        public void PurgeBuffers(){} // RVA: 0x7FFAF9295240
        public void Dispose(){} // RVA: 0x7FFAF9295470
        public void WriteAsync(){} // RVA: 0x7FFAF92957F0
        public void WriteAsyncCore(){} // RVA: 0x7FFAF9295980
        public void BeginWrite(){} // RVA: 0x7FFAF9295C10
        public void EndWrite(){} // RVA: 0x7FFAF9295CC0
        public void <>n__0(){} // RVA: 0x7FFAF890E7F0
    }

    public class DeflateStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9776410 | overloaded x7
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void Dispose(){} // RVA: 0x7FFAF9776430
        public void ReadInternal(){} // RVA: 0x7FFAF97764F0
        public void ReadAsyncMemory(){} // RVA: 0x7FFAF9776600
        public void ReadCore(){} // RVA: 0x7FFAF9776640
        public void Read(){} // RVA: 0x7FFAF97767D0
        public void WriteInternal(){} // RVA: 0x7FFAF9776B00
        public void WriteAsyncMemory(){} // RVA: 0x7FFAF9776C00
        public void WriteCore(){} // RVA: 0x7FFAF9776C40
        public void Write(){} // RVA: 0x7FFAF9776CD0
        public void Flush(){} // RVA: 0x7FFAF9776FF0
        public void BeginRead(){} // RVA: 0x7FFAF9777170
        public void BeginWrite(){} // RVA: 0x7FFAF9777560
        public void EndRead(){} // RVA: 0x7FFAF9777950
        public void EndWrite(){} // RVA: 0x7FFAF9777B40
        public void Seek(){} // RVA: 0x7FFAF9777D20
        public void SetLength(){} // RVA: 0x7FFAF9777D60
        public void get_CanRead(){} // RVA: 0x7FFAF9777DA0
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF9777DE0
        public void get_Length(){} // RVA: 0x7FFAF9777E20
        public void get_Position(){} // RVA: 0x7FFAF9777E60
        public void set_Position(){} // RVA: 0x7FFAF9777EA0
    }

    public class DeflateStreamNative
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF9778020
        public void Finalize(){} // RVA: 0x7FFAF97782E0
        public void Dispose(){} // RVA: 0x7FFAF9778330
        public void Flush(){} // RVA: 0x7FFAF9778F20 | overloaded x2
        public void ReadZStream(){} // RVA: 0x7FFAF9778FC0 | overloaded x2
        public void WriteZStream(){} // RVA: 0x7FFAF9779040 | overloaded x2
        public void UnmanagedRead(){} // RVA: 0x7FFAF97788D0 | overloaded x2
        public void UnmanagedWrite(){} // RVA: 0x7FFAF9778B90 | overloaded x2
        public void CheckResult(){} // RVA: 0x7FFAF9778D10
        public void CreateZStream(){} // RVA: 0x7FFAF9778E50
        public void CloseZStream(){} // RVA: 0x7FFAF9778F10
    }

    public class DeflaterManaged
    {
        // ── Methods ──
        public void NeedsInput(){} // RVA: 0x7FFAF44E0800
        public void SetInput(){} // RVA: 0x7FFAF44E0990
        public void GetDeflateOutput(){} // RVA: 0x7FFAF9296920
        public void Finish(){} // RVA: 0x7FFAF9296E50
        public void UseCompressed(){} // RVA: 0x7FFAF44E07F0
        public void FlushInputWindows(){} // RVA: 0x7FFAF9296F00
        public void WriteFinal(){} // RVA: 0x7FFAF9296F20
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
    }

    public class FastEncoder
    {
        // ── Methods ──
        public void get_BytesInHistory(){} // RVA: 0x7FFAF44E4510
        public void get_UnprocessedInput(){} // RVA: 0x7FFAF9296F60
        public void FlushInput(){} // RVA: 0x7FFAF9297020
        public void get_LastCompressionRatio(){} // RVA: 0x7FFAF44E46F0
        public void GetBlock(){} // RVA: 0x7FFAF92971C0
        public void GetCompressedData(){} // RVA: 0x7FFAF92972A0
        public void GetBlockHeader(){} // RVA: 0x7FFAF92972C0
        public void GetBlockFooter(){} // RVA: 0x7FFAF92972D0
        public void GetCompressedOutput(){} // RVA: 0x7FFAF92975D0 | overloaded x2
        public void InputAvailable(){} // RVA: 0x7FFAF44E4E10
        public void SafeToWriteTo(){} // RVA: 0x7FFAF44E4930
        public void WriteEndOfBlock(){} // RVA: 0x7FFAF92972D0
        public void WriteMatch(){} // RVA: 0x7FFAF92976B0
        public void WriteChar(){} // RVA: 0x7FFAF9297930
        public void WriteDeflatePreamble(){} // RVA: 0x7FFAF92979D0
    }

    public class FastEncoderStatics
    {
        // ── Methods ──
        public void CreateDistanceLookup(){} // RVA: 0x7FFAF9297A70
        public void GetSlot(){} // RVA: 0x7FFAF9297BF0
        public void BitReverse(){} // RVA: 0x7FFAF44E5550
        public void .cctor(){} // RVA: 0x7FFAF9297C80
    }

    public class FastEncoderWindow
    {
        // ── Methods ──
        public void get_BytesAvailable(){} // RVA: 0x7FFAF44E5AF0
        public void get_UnprocessedInput(){} // RVA: 0x7FFAF9298340
        public void FlushWindow(){} // RVA: 0x7FFAF9298400
        public void ResetWindow(){} // RVA: 0x7FFAF9298400
        public void get_FreeWindowSpace(){} // RVA: 0x7FFAF44E5D50
        public void CopyBytes(){} // RVA: 0x7FFAF44E6130
        public void MoveWindows(){} // RVA: 0x7FFAF44E5D60
        public void HashValue(){} // RVA: 0x7FFAF44E6570
        public void InsertString(){} // RVA: 0x7FFAF44E6300
        public void InsertStrings(){} // RVA: 0x7FFAF44E5580
        public void GetNextSymbolOrMatch(){} // RVA: 0x7FFAF44E5650
        public void FindMatch(){} // RVA: 0x7FFAF44E6180
    }

    public class GZipStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF97753A0 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFAF97754A0
        public void get_CanWrite(){} // RVA: 0x7FFAF97754C0
        public void get_CanSeek(){} // RVA: 0x7FFAF97754E0
        public void get_Length(){} // RVA: 0x7FFAF9775500
        public void get_Position(){} // RVA: 0x7FFAF9775550
        public void set_Position(){} // RVA: 0x7FFAF97755A0
        public void Flush(){} // RVA: 0x7FFAF97755F0
        public void Seek(){} // RVA: 0x7FFAF9775620
        public void SetLength(){} // RVA: 0x7FFAF9775670
        public void ReadByte(){} // RVA: 0x7FFAF97756C0
        public void BeginRead(){} // RVA: 0x7FFAF97756F0
        public void EndRead(){} // RVA: 0x7FFAF97757A0
        public void Read(){} // RVA: 0x7FFAF9775820 | overloaded x2
        public void BeginWrite(){} // RVA: 0x7FFAF9775AA0
        public void EndWrite(){} // RVA: 0x7FFAF871ED10
        public void Write(){} // RVA: 0x7FFAF9775B90 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF9775D20
        public void Dispose(){} // RVA: 0x7FFAF44E8B20
        public void ReadAsync(){} // RVA: 0x7FFAF9775D90 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAF9775F10 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFAF9776050
        public void CopyToAsync(){} // RVA: 0x7FFAF9776080
        public void CheckDeflateStream(){} // RVA: 0x7FFAF97760C0
        public void ThrowStreamClosedException(){} // RVA: 0x7FFAF97760E0
    }

    public class HuffmanTree
    {
        // ── Methods ──
        public void get_StaticLiteralLengthTree(){} // RVA: 0x7FFAF9298590
        public void get_StaticDistanceTree(){} // RVA: 0x7FFAF92985F0
        public void .ctor(){} // RVA: 0x7FFAF9298650
        public void GetStaticLiteralTreeLength(){} // RVA: 0x7FFAF9298870
        public void GetStaticDistanceTreeLength(){} // RVA: 0x7FFAF9298940
        public void CalculateHuffmanCode(){} // RVA: 0x7FFAF92989B0
        public void CreateTable(){} // RVA: 0x7FFAF9298BC0
        public void GetNextSymbol(){} // RVA: 0x7FFAF9298E30
        public void .cctor(){} // RVA: 0x7FFAF9299010
    }

    public class IFileFormatReader
    {
        // ── Methods ──
        public void ReadHeader(){} // RVA: 0x7FFAF2ABDE40
        public void ReadFooter(){} // RVA: 0x7FFAF2ABDE40
        public void UpdateWithBytesRead(){}
        public void Validate(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IFileFormatWriter
    {
        // ── Methods ──
        public void GetHeader(){} // RVA: 0x7FFAF2ABCD60
        public void UpdateWithBytesRead(){}
        public void GetFooter(){} // RVA: 0x7FFAF2ABCD60
    }

    public class InflaterManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92992B0
        public void Reset(){} // RVA: 0x7FFAF9299600
        public void SetInput(){} // RVA: 0x7FFAF44EBB60
        public void Finished(){} // RVA: 0x7FFAF44EDB00
        public void Inflate(){} // RVA: 0x7FFAF9299620
        public void Decode(){} // RVA: 0x7FFAF9299840
        public void DecodeUncompressedBlock(){} // RVA: 0x7FFAF9299BC0
        public void DecodeBlock(){} // RVA: 0x7FFAF9299E50
        public void DecodeDynamicBlockHeader(){} // RVA: 0x7FFAF929A2F0
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF929AB80
    }

    public class InputBuffer
    {
        public object State;
        public object Position;

        // ── Methods ──
        public void get_AvailableBits(){} // RVA: 0x7FFAF379F5B0
        public void get_AvailableBytes(){} // RVA: 0x7FFAF44EDE00
        public void EnsureBitsAvailable(){} // RVA: 0x7FFAF44EDC20
        public void TryLoad16Bits(){} // RVA: 0x7FFAF44EDEC0
        public void GetBitMask(){} // RVA: 0x7FFAF44EE160
        public void GetBits(){} // RVA: 0x7FFAF44EDE60
        public void CopyTo(){} // RVA: 0x7FFAF44EDF80
        public void NeedsInput(){} // RVA: 0x7FFAF44EDB40
        public void SetInput(){} // RVA: 0x7FFAF44EDCD0
        public void SkipBits(){} // RVA: 0x7FFAF44EDB50
        public void SkipToByteBoundary(){} // RVA: 0x7FFAF44EDE20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Match
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAF2DDA5C0
        public void set_State(){} // RVA: 0x7FFAF2D900C0
        public void get_Position(){} // RVA: 0x7FFAF335BED0
        public void set_Position(){} // RVA: 0x7FFAF335C660
        public void get_Length(){} // RVA: 0x7FFAF306ED50
        public void set_Length(){} // RVA: 0x7FFAF30E74E0
        public void get_Symbol(){} // RVA: 0x7FFAF2DA8390
        public void set_Symbol(){} // RVA: 0x7FFAF2DA83A0
    }

    public class OutputBuffer
    {
        public object FreeBytes;
        public object AvailableBytes;

        // ── Methods ──
        public void UpdateBuffer(){} // RVA: 0x7FFAF44EE640
        public void get_BytesWritten(){} // RVA: 0x7FFAF306ED50
        public void get_FreeBytes(){} // RVA: 0x7FFAF44EE400
        public void WriteUInt16(){} // RVA: 0x7FFAF44EE3A0
        public void WriteBits(){} // RVA: 0x7FFAF44EE6C0
        public void FlushBits(){} // RVA: 0x7FFAF44EE420
        public void WriteBytes(){} // RVA: 0x7FFAF44EE540
        public void WriteBytesUnaligned(){} // RVA: 0x7FFAF44EE260
        public void WriteByteUnaligned(){} // RVA: 0x7FFAF44EE600
        public void get_BitsInBuffer(){} // RVA: 0x7FFAF44EE6B0
        public void DumpState(){} // RVA: 0x7FFAF44EE2F0
        public void RestoreState(){} // RVA: 0x7FFAF44EE620
    }

    public class OutputWindow
    {
        public object CanRead;
        public object CanSeek;

        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAF929AF10
        public void WriteLengthDistance(){} // RVA: 0x7FFAF929AF50
        public void CopyFrom(){} // RVA: 0x7FFAF929B090
        public void get_FreeBytes(){} // RVA: 0x7FFAF929B310
        public void get_AvailableBytes(){} // RVA: 0x7FFAF442C3B0
        public void CopyTo(){} // RVA: 0x7FFAF929B320
        public void .ctor(){} // RVA: 0x7FFAF929B3E0
    }

    public class PositionPreservingWriteOnlyStreamWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF929B470
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2E72850
        public void get_Position(){} // RVA: 0x7FFAF30E74D0
        public void set_Position(){} // RVA: 0x7FFAF929B510
        public void Write(){} // RVA: 0x7FFAF929B560
        public void BeginWrite(){} // RVA: 0x7FFAF929B5A0
        public void EndWrite(){} // RVA: 0x7FFAF929B5E0
        public void WriteByte(){} // RVA: 0x7FFAF929B610
        public void WriteAsync(){} // RVA: 0x7FFAF929B640
        public void get_CanTimeout(){} // RVA: 0x7FFAF913EBD0
        public void get_ReadTimeout(){} // RVA: 0x7FFAF913ED10
        public void set_ReadTimeout(){} // RVA: 0x7FFAF913ED40
        public void get_WriteTimeout(){} // RVA: 0x7FFAF913ED70
        public void set_WriteTimeout(){} // RVA: 0x7FFAF913EDA0
        public void Flush(){} // RVA: 0x7FFAF8EC5940
        public void FlushAsync(){} // RVA: 0x7FFAF929B680
        public void Close(){} // RVA: 0x7FFAF929B6B0
        public void Dispose(){} // RVA: 0x7FFAF929B6E0
        public void get_Length(){} // RVA: 0x7FFAF929B720
        public void Seek(){} // RVA: 0x7FFAF929B770
        public void SetLength(){} // RVA: 0x7FFAF929B7C0
        public void Read(){} // RVA: 0x7FFAF929B810
    }

    public class SubReadStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92A6A50
        public void get_Length(){} // RVA: 0x7FFAF92A6B20
        public void get_Position(){} // RVA: 0x7FFAF92A6B40
        public void set_Position(){} // RVA: 0x7FFAF92A6B60
        public void get_CanRead(){} // RVA: 0x7FFAF92A6BC0
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF92A6C00
        public void ThrowIfCantRead(){} // RVA: 0x7FFAF92A6C90
        public void Read(){} // RVA: 0x7FFAF92A6D10
        public void Seek(){} // RVA: 0x7FFAF92A6E50
        public void SetLength(){} // RVA: 0x7FFAF92A6EB0
        public void Write(){} // RVA: 0x7FFAF92A6F10
        public void Flush(){} // RVA: 0x7FFAF92A6F70
        public void Dispose(){} // RVA: 0x7FFAF92A6FD0
    }

    public class WrappedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF92A63A0 | overloaded x3
        public void get_Length(){} // RVA: 0x7FFAF92A63D0
        public void get_Position(){} // RVA: 0x7FFAF92A6410
        public void set_Position(){} // RVA: 0x7FFAF92A6450
        public void get_CanRead(){} // RVA: 0x7FFAF92A64B0
        public void get_CanSeek(){} // RVA: 0x7FFAF92A64F0
        public void get_CanWrite(){} // RVA: 0x7FFAF92A6530
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF92A6570
        public void ThrowIfCantRead(){} // RVA: 0x7FFAF92A6600
        public void ThrowIfCantWrite(){} // RVA: 0x7FFAF92A6680
        public void ThrowIfCantSeek(){} // RVA: 0x7FFAF92A6700
        public void Read(){} // RVA: 0x7FFAF92A6780
        public void Seek(){} // RVA: 0x7FFAF92A6850
        public void SetLength(){} // RVA: 0x7FFAF92A68C0
        public void Write(){} // RVA: 0x7FFAF92A6920
        public void Flush(){} // RVA: 0x7FFAF92A69A0
        public void Dispose(){} // RVA: 0x7FFAF92A69F0
    }

    public class Zip64EndOfCentralDirectoryLocator
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFAF92A4CE0
        public void WriteBlock(){} // RVA: 0x7FFAF92A4D90
    }

    public class Zip64EndOfCentralDirectoryRecord
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFAF92A4E70
        public void WriteBlock(){} // RVA: 0x7FFAF92A4FD0
    }

    public class Zip64ExtraField
    {
        // ── Methods ──
        public void get_TotalSize(){} // RVA: 0x7FFAF92A3820
        public void get_UncompressedSize(){} // RVA: 0x7FFAF4A1F090
        public void set_UncompressedSize(){} // RVA: 0x7FFAF92A3830
        public void get_CompressedSize(){} // RVA: 0x7FFAF3444EE0
        public void set_CompressedSize(){} // RVA: 0x7FFAF92A3840
        public void get_LocalHeaderOffset(){} // RVA: 0x7FFAF3BCF520
        public void set_LocalHeaderOffset(){} // RVA: 0x7FFAF92A3850
        public void get_StartDiskNumber(){} // RVA: 0x7FFAF2F476A0
        public void UpdateSize(){} // RVA: 0x7FFAF92A3860
        public void GetJustZip64Block(){} // RVA: 0x7FFAF92A38D0
        public void TryGetZip64BlockFromGenericExtraField(){} // RVA: 0x7FFAF92A3B30
        public void GetAndRemoveZip64Block(){} // RVA: 0x7FFAF92A40C0
        public void RemoveZip64Blocks(){} // RVA: 0x7FFAF92A4670
        public void WriteBlock(){} // RVA: 0x7FFAF92A4B70
    }

    public class ZipArchive
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF929B930 | overloaded x2
        public void get_Mode(){} // RVA: 0x7FFAF3241DC0
        public void CreateEntry(){} // RVA: 0x7FFAF929BAF0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF929BC90 | overloaded x2
        public void get_ArchiveReader(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ArchiveStream(){} // RVA: 0x7FFAF2DA8380
        public void get_NumberOfThisDisk(){} // RVA: 0x7FFAF30554D0
        public void get_EntryNameEncoding(){} // RVA: 0x7FFAF2F77C50
        public void set_EntryNameEncoding(){} // RVA: 0x7FFAF929BD00
        public void DoCreateEntry(){} // RVA: 0x7FFAF929BE10
        public void AcquireArchiveStream(){} // RVA: 0x7FFAF929C020
        public void AddEntry(){} // RVA: 0x7FFAF929C140
        public void ReleaseArchiveStream(){} // RVA: 0x7FFAF515D280
        public void RemoveEntry(){} // RVA: 0x7FFAF929C240
        public void ThrowIfDisposed(){} // RVA: 0x7FFAF929C2D0
        public void CloseStreams(){} // RVA: 0x7FFAF929C360
        public void EnsureCentralDirectoryRead(){} // RVA: 0x7FFAF929C400
        public void Init(){} // RVA: 0x7FFAF929C420
        public void ReadCentralDirectory(){} // RVA: 0x7FFAF929CE80
        public void ReadEndOfCentralDirectory(){} // RVA: 0x7FFAF929D110
        public void WriteFile(){} // RVA: 0x7FFAF929D890
        public void WriteArchiveEpilogue(){} // RVA: 0x7FFAF929DFE0
    }

    public class ZipArchiveEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF929E6B0 | overloaded x3
        public void get_FullName(){} // RVA: 0x7FFAF34CC8C0
        public void set_FullName(){} // RVA: 0x7FFAF929EC20
        public void set_LastWriteTime(){} // RVA: 0x7FFAF929EF10
        public void Delete(){} // RVA: 0x7FFAF929F1D0
        public void Open(){} // RVA: 0x7FFAF929F350
        public void ToString(){} // RVA: 0x7FFAF34CC8C0
        public void get_EverOpenedForWrite(){} // RVA: 0x7FFAF304F730
        public void get_OffsetOfCompressedData(){} // RVA: 0x7FFAF929F3B0
        public void get_UncompressedData(){} // RVA: 0x7FFAF929F510
        public void get_CompressionMethod(){} // RVA: 0x7FFAF6F697F0
        public void set_CompressionMethod(){} // RVA: 0x7FFAF929F720
        public void DecodeEntryName(){} // RVA: 0x7FFAF929F770
        public void EncodeEntryName(){} // RVA: 0x7FFAF929F7D0
        public void WriteAndFinishLocalEntry(){} // RVA: 0x7FFAF929F900
        public void WriteCentralDirectoryFileHeader(){} // RVA: 0x7FFAF929F950
        public void LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded(){} // RVA: 0x7FFAF929FFB0
        public void ThrowIfNotOpenable(){} // RVA: 0x7FFAF92A04F0
        public void GetDataCompressor(){} // RVA: 0x7FFAF92A0570
        public void GetDataDecompressor(){} // RVA: 0x7FFAF92A0850
        public void OpenInReadMode(){} // RVA: 0x7FFAF92A0A50
        public void OpenInWriteMode(){} // RVA: 0x7FFAF92A0B20
        public void OpenInUpdateMode(){} // RVA: 0x7FFAF92A0DF0
        public void IsOpenable(){} // RVA: 0x7FFAF92A1040
        public void SizesTooLarge(){} // RVA: 0x7FFAF92A13B0
        public void WriteLocalFileHeader(){} // RVA: 0x7FFAF92A13D0
        public void WriteLocalFileHeaderAndDataIfNeeded(){} // RVA: 0x7FFAF92A1920
        public void WriteCrcAndSizesInLocalHeader(){} // RVA: 0x7FFAF92A1C00
        public void WriteDataDescriptor(){} // RVA: 0x7FFAF92A1F70
        public void UnloadStreams(){} // RVA: 0x7FFAF92A20B0
        public void CloseStreams(){} // RVA: 0x7FFAF92A21A0
        public void VersionToExtractAtLeast(){} // RVA: 0x7FFAF92A21D0
        public void ThrowIfInvalidArchive(){} // RVA: 0x7FFAF92A21F0
        public void GetFileName_Windows(){} // RVA: 0x7FFAF92A2260
        public void GetFileName_Unix(){} // RVA: 0x7FFAF92A22E0
        public void ParseFileName(){} // RVA: 0x7FFAF92A2350
        public void .cctor(){} // RVA: 0x7FFAF92A24C0
    }

    public class ZipCentralDirectoryFileHeader
    {
        // ── Methods ──
        public void TryReadBlock(){} // RVA: 0x7FFAF92A55A0
    }

    public class ZipEndOfCentralDirectoryBlock
    {
        // ── Methods ──
        public void WriteBlock(){} // RVA: 0x7FFAF92A5ED0
        public void TryReadBlock(){} // RVA: 0x7FFAF92A6080
    }

    public class ZipFileExtensions
    {
        // ── Methods ──
        public void CreateEntryFromFile(){} // RVA: 0x7FFAF92A9040
        public void DoCreateEntryFromFile(){} // RVA: 0x7FFAF92A9060
    }

    public class ZipGenericExtraField
    {
        public object TotalSize;
        public object UncompressedSize;
        public object CompressedSize;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAF4A563F0
        public void get_Size(){} // RVA: 0x7FFAF4A56420
        public void get_Data(){} // RVA: 0x7FFAF44189C0
        public void WriteBlock(){} // RVA: 0x7FFAF92A3020
        public void TryReadBlock(){} // RVA: 0x7FFAF92A30E0
        public void ParseExtraField(){} // RVA: 0x7FFAF92A3250
        public void TotalSize(){} // RVA: 0x7FFAF92A34C0
        public void WriteAllBlocks(){} // RVA: 0x7FFAF92A3620
    }

    public class ZipHelper
    {
        // ── Methods ──
        public void RequiresUnicode(){} // RVA: 0x7FFAF92A7880
        public void ReadBytes(){} // RVA: 0x7FFAF92A78E0
        public void DosTimeToDateTime(){} // RVA: 0x7FFAF92A79B0
        public void DateTimeToDosTime(){} // RVA: 0x7FFAF92A7A60
        public void SeekBackwardsToSignature(){} // RVA: 0x7FFAF92A7BF0
        public void AdvanceToPosition(){} // RVA: 0x7FFAF92A7E50
        public void SeekBackwardsAndRead(){} // RVA: 0x7FFAF92A7F50
        public void .cctor(){} // RVA: 0x7FFAF92A80E0
    }

    public class ZipLocalFileHeader
    {
        // ── Methods ──
        public void GetExtraFields(){} // RVA: 0x7FFAF92A5160
        public void TrySkipBlock(){} // RVA: 0x7FFAF92A5390
    }

}