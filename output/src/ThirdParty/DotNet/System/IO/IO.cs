// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 60
// Methods: 889

namespace ThirdParty.DotNet.System.IO
{
    public class BinaryReader : Object
    {
        public System.IO.Stream BaseStream; // 0x10
        public byte[] m_buffer; // 0x18
        public System.Text.Decoder m_decoder; // 0x20
        public byte[] m_charBytes; // 0x28
        public char[] m_singleChar; // 0x30
        public char[] m_charBuffer; // 0x38
        public int m_maxCharsSize; // 0x40
        public bool m_2BytesPerChar; // 0x44
        public bool m_isMemoryStream; // 0x45
        public bool m_leaveOpen; // 0x46

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85ED7A0 | overloaded x3
        public void get_BaseStream(){} // RVA: 0x7FFAC2F3C380
        public void Close(){} // RVA: 0x7FFAC4843BC0
        public void Dispose(){} // RVA: 0x7FFAC4843BC0 | overloaded x2
        public void Read(){} // RVA: 0x7FFAC85EF180 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x7FFAC85EDD20
        public void ReadByte(){} // RVA: 0x7FFAC85EDD70
        public void ReadSByte(){} // RVA: 0x7FFAC85EDDB0
        public void ReadChar(){} // RVA: 0x7FFAC85EDE00
        public void ReadInt16(){} // RVA: 0x7FFAC85EDE30
        public void ReadUInt16(){} // RVA: 0x7FFAC85EDE30
        public void ReadInt32(){} // RVA: 0x7FFAC85EDE90
        public void ReadUInt32(){} // RVA: 0x7FFAC85EE070
        public void ReadInt64(){} // RVA: 0x7FFAC85EE0F0
        public void ReadUInt64(){} // RVA: 0x7FFAC85EE0F0
        public void ReadSingle(){} // RVA: 0x7FFAC85EE1E0
        public void ReadDouble(){} // RVA: 0x7FFAC85EE260
        public void ReadDecimal(){} // RVA: 0x7FFAC85EE2E0
        public void ReadString(){} // RVA: 0x7FFAC85EE550
        public void InternalReadChars(){} // RVA: 0x7FFAC85EE850
        public void InternalReadOneChar(){} // RVA: 0x7FFAC85EEC60
        public void ReadChars(){} // RVA: 0x7FFAC85EEFA0
        public void ReadBytes(){} // RVA: 0x7FFAC85EF370
        public void FillBuffer(){} // RVA: 0x7FFAC85EF570
        public void Read7BitEncodedInt(){} // RVA: 0x7FFAC85EF6E0
    }

    public class BinaryWriter : Object
    {
        public System.IO.BinaryWriter BaseStream;
        public System.IO.Stream OutStream; // 0x10
        public byte[] _buffer; // 0x18
        public System.Text.Encoding _encoding; // 0x20
        public System.Text.Encoder _encoder; // 0x28
        public bool _leaveOpen; // 0x30
        public byte[] _largeByteBuffer; // 0x38
        public int _maxChars; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85EFAC0 | overloaded x4
        public void Close(){} // RVA: 0x7FFAC4843BC0
        public void Dispose(){} // RVA: 0x7FFAC4843BC0 | overloaded x2
        public void get_BaseStream(){} // RVA: 0x7FFAC85EFD00
        public void Flush(){} // RVA: 0x7FFAC85938D0
        public void DisposeAsync(){} // RVA: 0x7FFAC85EFD30
        public void Write(){} // RVA: 0x7FFAC85F0980 | overloaded x16
        public void Write7BitEncodedInt(){} // RVA: 0x7FFAC85F0D50
        public void .cctor(){} // RVA: 0x7FFAC85F0DC0
    }

    public class BufferedStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public byte[] CanWrite; // 0x30
        public int CanSeek; // 0x38
        public int Length; // 0x3C
        public int Position; // 0x40
        public int _writePos; // 0x44
        public System.Threading.Tasks.Task`1<int> _lastSyncCompletedReadTask; // 0x48
        public System.Threading.SemaphoreSlim _asyncActiveSemaphore; // 0x50

        // ── Methods ──
        public void LazyEnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFAC85DCFA0
        public void .ctor(){} // RVA: 0x7FFAC85DD110 | overloaded x2
        public void EnsureNotClosed(){} // RVA: 0x7FFAC85DD360
        public void EnsureCanSeek(){} // RVA: 0x7FFAC85DD3D0
        public void EnsureCanRead(){} // RVA: 0x7FFAC85DD460
        public void EnsureCanWrite(){} // RVA: 0x7FFAC85DD4F0
        public void EnsureShadowBufferAllocated(){} // RVA: 0x7FFAC85DD580
        public void EnsureBufferAllocated(){} // RVA: 0x7FFAC85DD6B0
        public void get_CanRead(){} // RVA: 0x7FFAC85DD750
        public void get_CanWrite(){} // RVA: 0x7FFAC85DD780
        public void get_CanSeek(){} // RVA: 0x7FFAC85DD7B0
        public void get_Length(){} // RVA: 0x7FFAC85DD7E0
        public void get_Position(){} // RVA: 0x7FFAC85DD870
        public void set_Position(){} // RVA: 0x7FFAC85DD910
        public void DisposeAsync(){} // RVA: 0x7FFAC85DD9E0
        public void Dispose(){} // RVA: 0x7FFAC85DDB90
        public void Flush(){} // RVA: 0x7FFAC85DDD60
        public void FlushAsync(){} // RVA: 0x7FFAC85DDEA0
        public void FlushAsyncInternal(){} // RVA: 0x7FFAC85DDF70
        public void FlushRead(){} // RVA: 0x7FFAC85DE190
        public void ClearReadBufferBeforeWrite(){} // RVA: 0x7FFAC85DE1E0
        public void FlushWrite(){} // RVA: 0x7FFAC85DE2B0
        public void FlushWriteAsync(){} // RVA: 0x7FFAC85DE320
        public void ReadFromBuffer(){} // RVA: 0x7FFAC85DE730 | overloaded x3
        public void Read(){} // RVA: 0x7FFAC85DEAD0 | overloaded x2
        public void LastSyncCompletedReadTask(){} // RVA: 0x7FFAC85DECF0
        public void ReadAsync(){} // RVA: 0x7FFAC85DF510 | overloaded x2
        public void ReadFromUnderlyingStreamAsync(){} // RVA: 0x7FFAC85DF9C0
        public void BeginRead(){} // RVA: 0x7FFAC85DFCC0
        public void EndRead(){} // RVA: 0x7FFAC85DFD70
        public void ReadByte(){} // RVA: 0x7FFAC85DFDB0
        public void ReadByteSlow(){} // RVA: 0x7FFAC85DFEE0
        public void WriteToBuffer(){} // RVA: 0x7FFAC85E00B0 | overloaded x2
        public void Write(){} // RVA: 0x7FFAC85E0650 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAC85E0CC0 | overloaded x2
        public void WriteToUnderlyingStreamAsync(){} // RVA: 0x7FFAC85E1060
        public void BeginWrite(){} // RVA: 0x7FFAC85E1320
        public void EndWrite(){} // RVA: 0x7FFAC84062A0
        public void WriteByte(){} // RVA: 0x7FFAC85E13D0
        public void Seek(){} // RVA: 0x7FFAC85E14A0
        public void SetLength(){} // RVA: 0x7FFAC85E1620
        public void CopyTo(){} // RVA: 0x7FFAC85E1700
        public void CopyToAsync(){} // RVA: 0x7FFAC85E17B0
        public void CopyToAsyncCore(){} // RVA: 0x7FFAC85E18A0
    }

    public class CStreamReader : StreamReader
    {
        public System.TermInfoDriver driver; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85FFFC0
        public void Peek(){} // RVA: 0x7FFAC85FF890
        public void Read(){} // RVA: 0x7FFAC8600310 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFAC86004C0
        public void ReadToEnd(){} // RVA: 0x7FFAC86004F0
    }

    public class CStreamWriter : StreamWriter
    {
        public System.TermInfoDriver driver; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8600520
        public void Write(){} // RVA: 0x7FFAC8600CE0 | overloaded x4
        public void InternalWriteString(){} // RVA: 0x7FFAC8600C40
        public void InternalWriteChar(){} // RVA: 0x7FFAC8600C60
        public void InternalWriteChars(){} // RVA: 0x7FFAC8600C80
        public void WriteLine(){} // RVA: 0x7FFAC8600D50
    }

    public class DefaultWatcher : Object
    {
        public System.IO.DefaultWatcher instance;
        public System.Threading.Thread thread; // 0x8
        public System.Collections.Hashtable watches; // 0x10
        public string[] NoStringsArray; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetInstance(){} // RVA: 0x7FFAC94574B0
        public void StartDispatching(){} // RVA: 0x7FFAC9457680
        public void StopDispatching(){} // RVA: 0x7FFAC94583B0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void Monitor(){} // RVA: 0x7FFAC94589A0
        public void UpdateDataAndDispatch(){} // RVA: 0x7FFAC94593D0
        public void DispatchEvents(){} // RVA: 0x7FFAC9459510
        public void DoFiles(){} // RVA: 0x7FFAC94596B0
        public void IterateAndModifyFilesData(){} // RVA: 0x7FFAC9459A90
        public void CreateFileData(){} // RVA: 0x7FFAC945A6D0
        public void .cctor(){} // RVA: 0x7FFAC945A7F0
    }

    public class DefaultWatcherData : Object
    {
        public System.IO.FileSystemWatcher FSW; // 0x10
        public string Directory; // 0x18
        public string FileMask; // 0x20
        public bool IncludeSubdirs; // 0x28
        public bool Enabled; // 0x29
        public bool NoWildcards; // 0x2A
        public System.DateTime DisabledTime; // 0x30
        public object FilesLock; // 0x38
        public System.Collections.Generic.Dictionary`2<string,System.IO.FileData> Files; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9457420
    }

    public class Directory : Object
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFAC85D6CF0
        public void Exists(){} // RVA: 0x7FFAC85D6E90
        public void GetFiles(){} // RVA: 0x7FFAC85D70E0 | overloaded x3
        public void GetDirectories(){} // RVA: 0x7FFAC85D7290 | overloaded x2
        public void GetFileSystemEntries(){} // RVA: 0x7FFAC85D7430 | overloaded x2
        public void InternalEnumeratePaths(){} // RVA: 0x7FFAC85D74C0
        public void EnumerateFiles(){} // RVA: 0x7FFAC85D7910 | overloaded x4
        public void GetDirectoryRoot(){} // RVA: 0x7FFAC85D7930
        public void InternalGetDirectoryRoot(){} // RVA: 0x7FFAC85D7AB0
        public void GetCurrentDirectory(){} // RVA: 0x7FFAC85D7B70
        public void Delete(){} // RVA: 0x7FFAC85D7B80
        public void InsecureGetCurrentDirectory(){} // RVA: 0x7FFAC85D7C20
    }

    public class DirectoryInfo : FileSystemInfo
    {
        public object Parent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85D8C10 | overloaded x3
        public void Init(){} // RVA: 0x7FFAC85D7E20
        public void get_Parent(){} // RVA: 0x7FFAC85D83A0
        public void Create(){} // RVA: 0x7FFAC85D8570
        public void GetFiles(){} // RVA: 0x7FFAC85D8700 | overloaded x3
        public void EnumerateFiles(){} // RVA: 0x7FFAC85D8910 | overloaded x3
        public void InternalEnumerateInfos(){} // RVA: 0x7FFAC85D89B0
        public void Delete(){} // RVA: 0x7FFAC85D8BB0
    }

    public class DirectoryNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class DisableMediaInsertionPrompt : ValueType
    {
        public bool _disableSuccess; // 0x10
        public uint _oldMode; // 0x14
        public bool useUWPFallback;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC85B72B0
        public void Dispose(){} // RVA: 0x7FFAC85B7330
    }

    public class DriveNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class EndOfStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class EnumerationOptions : Object
    {
        public System.IO.EnumerationOptions Compatible;
        public System.IO.EnumerationOptions CompatibleRecursive; // 0x8
        public System.IO.EnumerationOptions Default; // 0x10
        public bool RecurseSubdirectories; // 0x10
        public bool IgnoreInaccessible; // 0x11
        public int BufferSize; // 0x14
        public 0x6B0E2B78 AttributesToSkip; // 0x18
        public 0x6B0E27B0 MatchType; // 0x1C
        public 0x6B0E2758 MatchCasing; // 0x20
        public bool ReturnSpecialDirectories; // 0x24

        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x7FFAC85D8C30
        public void get_CompatibleRecursive(){} // RVA: 0x7FFAC85D8C90
        public void get_Default(){} // RVA: 0x7FFAC85D8CF0
        public void .ctor(){} // RVA: 0x7FFAC85D8D50
        public void FromSearchOption(){} // RVA: 0x7FFAC85D8D60
        public void get_RecurseSubdirectories(){} // RVA: 0x7FFAC2FEB5E0
        public void set_RecurseSubdirectories(){} // RVA: 0x7FFAC2FEB5F0
        public void get_IgnoreInaccessible(){} // RVA: 0x7FFAC3771DA0
        public void set_IgnoreInaccessible(){} // RVA: 0x7FFAC3771D90
        public void get_BufferSize(){} // RVA: 0x7FFAC33D5A20
        public void get_AttributesToSkip(){} // RVA: 0x7FFAC3157800
        public void set_AttributesToSkip(){} // RVA: 0x7FFAC392CD10
        public void get_MatchType(){} // RVA: 0x7FFAC44357F0
        public void set_MatchType(){} // RVA: 0x7FFAC44474D0
        public void get_MatchCasing(){} // RVA: 0x7FFAC30DBBE0
        public void get_ReturnSpecialDirectories(){} // RVA: 0x7FFAC2F3C7C0
        public void .cctor(){} // RVA: 0x7FFAC85D8E80
    }

    public class Error : Object
    {
        // ── Methods ──
        public void GetStreamIsClosed(){} // RVA: 0x7FFAC85BB6A0
        public void GetEndOfFile(){} // RVA: 0x7FFAC85BB710
        public void GetReadNotSupported(){} // RVA: 0x7FFAC85BB780
        public void GetWriteNotSupported(){} // RVA: 0x7FFAC85BB7F0
    }

    public class ErrorEventArgs : EventArgs
    {
    }

    public class ErrorEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class File : Object
    {
        // ── Methods ──
        public void OpenText(){} // RVA: 0x7FFAC85D9050
        public void Copy(){} // RVA: 0x7FFAC85D9130 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC85D9460 | overloaded x3
        public void Delete(){} // RVA: 0x7FFAC85D9500
        public void Exists(){} // RVA: 0x7FFAC85D95E0
        public void Open(){} // RVA: 0x7FFAC85D9770 | overloaded x2
        public void GetUtcDateTimeOffset(){} // RVA: 0x7FFAC85D9810
        public void GetCreationTime(){} // RVA: 0x7FFAC85D9940
        public void GetCreationTimeUtc(){} // RVA: 0x7FFAC85D9A70
        public void SetLastAccessTimeUtc(){} // RVA: 0x7FFAC85D9BD0
        public void GetLastWriteTime(){} // RVA: 0x7FFAC85D9D90
        public void GetLastWriteTimeUtc(){} // RVA: 0x7FFAC85D9EC0
        public void GetAttributes(){} // RVA: 0x7FFAC85DA020
        public void OpenRead(){} // RVA: 0x7FFAC85DA100
        public void OpenWrite(){} // RVA: 0x7FFAC85DA190
        public void ReadAllText(){} // RVA: 0x7FFAC85DA210
        public void InternalReadAllText(){} // RVA: 0x7FFAC85DA2F0
        public void WriteAllText(){} // RVA: 0x7FFAC85DA5C0 | overloaded x2
        public void ReadAllBytes(){} // RVA: 0x7FFAC85DA7F0
        public void ReadAllBytesUnknownLength(){} // RVA: 0x7FFAC85DAA60
        public void WriteAllBytes(){} // RVA: 0x7FFAC85DAFB0
        public void InternalWriteAllBytes(){} // RVA: 0x7FFAC85DB0E0
        public void ReadAllLines(){} // RVA: 0x7FFAC85DB230
        public void InternalReadAllLines(){} // RVA: 0x7FFAC85DB310
        public void Move(){} // RVA: 0x7FFAC85DB520
    }

    public class FileData : Object
    {
        public string Directory; // 0x10
        public 0x6B0E2B78 Attributes; // 0x18
        public bool NotExists; // 0x1C
        public System.DateTime CreationTime; // 0x20
        public System.DateTime LastWriteTime; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FileInfo : FileSystemInfo
    {
        public object Length;
        public object DirectoryName;
        public object Directory;
        public object IsReadOnly;
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85D8C10 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFAC85DBA60
        public void get_DirectoryName(){} // RVA: 0x7FFAC85DBB10
        public void get_Directory(){} // RVA: 0x7FFAC85DBB70
        public void get_IsReadOnly(){} // RVA: 0x7FFAC85DBC20
        public void set_IsReadOnly(){} // RVA: 0x7FFAC85DBC40
        public void CreateText(){} // RVA: 0x7FFAC85DBC90
        public void AppendText(){} // RVA: 0x7FFAC85DBD00
        public void Delete(){} // RVA: 0x7FFAC85DBD70
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
    }

    public class FileLoadException : IOException
    {
        public string Message; // 0x90
        public string FileName; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BBBC0 | overloaded x3
        public void get_Message(){} // RVA: 0x7FFAC85BB8D0
        public void get_FileName(){} // RVA: 0x7FFAC32EF640
        public void get_FusionLog(){} // RVA: 0x7FFAC354DFB0
        public void ToString(){} // RVA: 0x7FFAC85BB9B0
        public void GetObjectData(){} // RVA: 0x7FFAC85BBD60
        public void FormatFileLoadExceptionMessage(){} // RVA: 0x7FFAC85BC070
    }

    public class FileNotFoundException : IOException
    {
        public string Message; // 0x90
        public string FileName; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BC620 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFAC85BC1D0
        public void SetMessageField(){} // RVA: 0x7FFAC85BC2F0
        public void get_FileName(){} // RVA: 0x7FFAC32EF640
        public void get_FusionLog(){} // RVA: 0x7FFAC354DFB0
        public void ToString(){} // RVA: 0x7FFAC85BC410
        public void GetObjectData(){} // RVA: 0x7FFAC85BC7C0
    }

    public class FileStream : Stream
    {
        public int CanRead;
        public byte[] CanWrite;
        public object CanSeek; // 0x8
        public byte[] Name; // 0x28
        public string Length; // 0x30
        public Microsoft.Win32.SafeHandles.SafeFileHandle Position; // 0x38
        public bool SafeFileHandle; // 0x40
        public long append_startpos; // 0x48
        public 0x6B0E1890 access; // 0x50
        public bool owner; // 0x54
        public bool async; // 0x55
        public bool canseek; // 0x56
        public bool anonymous; // 0x57
        public bool buf_dirty; // 0x58
        public int buf_size; // 0x5C
        public int buf_length; // 0x60
        public int buf_offset; // 0x64
        public long buf_start; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85F27A0 | overloaded x12
        public void Init(){} // RVA: 0x7FFAC85F3200
        public void get_CanRead(){} // RVA: 0x7FFAC85F3570
        public void get_CanWrite(){} // RVA: 0x7FFAC85F3590
        public void get_CanSeek(){} // RVA: 0x7FFAC85F35B0
        public void get_Name(){} // RVA: 0x7FFAC31D95E0
        public void get_Length(){} // RVA: 0x7FFAC85F35C0
        public void get_Position(){} // RVA: 0x7FFAC85F3760
        public void set_Position(){} // RVA: 0x7FFAC85F3920
        public void get_SafeFileHandle(){} // RVA: 0x7FFAC85F39C0
        public void ExposeHandle(){} // RVA: 0x7FFAC85F3A00
        public void ReadByte(){} // RVA: 0x7FFAC85F3A30
        public void WriteByte(){} // RVA: 0x7FFAC85F3BA0
        public void Read(){} // RVA: 0x7FFAC85F3D00
        public void ReadInternal(){} // RVA: 0x7FFAC85F40B0
        public void BeginRead(){} // RVA: 0x7FFAC85F4180
        public void EndRead(){} // RVA: 0x7FFAC85F45D0
        public void Write(){} // RVA: 0x7FFAC85F47E0
        public void WriteInternal(){} // RVA: 0x7FFAC85F4AB0
        public void BeginWrite(){} // RVA: 0x7FFAC85F4CF0
        public void EndWrite(){} // RVA: 0x7FFAC85F5190
        public void Seek(){} // RVA: 0x7FFAC85F5390
        public void SetLength(){} // RVA: 0x7FFAC85F56A0
        public void Flush(){} // RVA: 0x7FFAC85F5940
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void Dispose(){} // RVA: 0x7FFAC85F59C0
        public void FlushAsync(){} // RVA: 0x7FFAC85F5DD0
        public void ReadAsync(){} // RVA: 0x7FFAC85F5E50
        public void WriteAsync(){} // RVA: 0x7FFAC85F5E60
        public void ReadSegment(){} // RVA: 0x7FFAC85F5E70
        public void WriteSegment(){} // RVA: 0x7FFAC85F5F80
        public void FlushBuffer(){} // RVA: 0x7FFAC85F5FF0
        public void FlushBufferIfDirty(){} // RVA: 0x7FFAC85F61E0
        public void RefillBuffer(){} // RVA: 0x7FFAC85F61F0
        public void ReadData(){} // RVA: 0x7FFAC85F6230
        public void InitBuffer(){} // RVA: 0x7FFAC85F6370
        public void GetSecureFileName(){} // RVA: 0x7FFAC85F6800 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC85F68F0
    }

    public class FileStreamAsyncResult : Object
    {
        public object AsyncState; // 0x10
        public bool CompletedSynchronously; // 0x18
        public System.Threading.ManualResetEvent AsyncWaitHandle; // 0x20
        public System.AsyncCallback IsCompleted; // 0x28
        public bool completedSynch; // 0x30
        public int Count; // 0x34
        public int OriginalCount; // 0x38
        public int BytesRead; // 0x3C
        public System.AsyncCallback realcb; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85F6D10
        public void CBWrapper(){} // RVA: 0x7FFAC85F6F40
        public void get_AsyncState(){} // RVA: 0x7FFAC2F3C380
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC2F47450
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IsCompleted(){} // RVA: 0x7FFAC2F3C4E0
    }

    public class FileSystem : Object
    {
        // ── Methods ──
        public void CopyFile(){} // RVA: 0x7FFAC85B73D0
        public void CreateDirectory(){} // RVA: 0x7FFAC85B7700
        public void DeleteFile(){} // RVA: 0x7FFAC85B7CC0
        public void DirectoryExists(){} // RVA: 0x7FFAC85B7DA0 | overloaded x2
        public void FillAttributeInfo(){} // RVA: 0x7FFAC85B7DF0
        public void FileExists(){} // RVA: 0x7FFAC85B80F0
        public void GetAttributes(){} // RVA: 0x7FFAC85B8140
        public void GetCreationTime(){} // RVA: 0x7FFAC85B81B0
        public void GetLastWriteTime(){} // RVA: 0x7FFAC85B8240
        public void MoveFile(){} // RVA: 0x7FFAC85B82D0
        public void OpenHandle(){} // RVA: 0x7FFAC85B8320
        public void RemoveDirectory(){} // RVA: 0x7FFAC85B85C0
        public void GetFindData(){} // RVA: 0x7FFAC85B86A0
        public void IsNameSurrogateReparsePoint(){} // RVA: 0x7FFAC85B87F0
        public void RemoveDirectoryRecursive(){} // RVA: 0x7FFAC85B8810
        public void RemoveDirectoryInternal(){} // RVA: 0x7FFAC85B91F0
        public void SetAttributes(){} // RVA: 0x7FFAC85B9320
        public void SetLastAccessTime(){} // RVA: 0x7FFAC85B9400
        public void UnityCreateDirectory(){} // RVA: 0x7FFAC85B9640
        public void UnityRemoveDirectory(){} // RVA: 0x7FFAC85B9820
        public void UnityGetFileAttributesEx(){} // RVA: 0x7FFAC85B9A60
        public void UnitySetFileAttributes(){} // RVA: 0x7FFAC85B9CC0
        public void UnityCreateFile_IntPtr(){} // RVA: 0x7FFAC85B9E90
        public void UnityCopyFile(){} // RVA: 0x7FFAC85BA040
        public void UnityDeleteFile(){} // RVA: 0x7FFAC85BA180
        public void UnityMoveFile(){} // RVA: 0x7FFAC85BA3C0
        public void UnityFindFirstFile(){} // RVA: 0x7FFAC85BA630
        public void UnityFindNextFile(){} // RVA: 0x7FFAC85BAAC0
        public void BrokeredCreateDirectory(){} // RVA: 0x7FFAC85BADD0
        public void BrokeredRemoveDirectory(){} // RVA: 0x7FFAC85BADD0
        public void BrokeredGetFileAttributes(){} // RVA: 0x7FFAC85BAE60
        public void BrokeredSetAttributes(){} // RVA: 0x7FFAC85BAE70
        public void BrokeredOpenFile(){} // RVA: 0x7FFAC85BAF00
        public void BrokeredCopyFile(){} // RVA: 0x7FFAC85BB030
        public void BrokeredMoveFile(){} // RVA: 0x7FFAC85BB160
        public void BrokeredDeleteFile(){} // RVA: 0x7FFAC85BADD0
        public void BrokeredFindFirstFile(){} // RVA: 0x7FFAC85BB280
        public void BrokeredFindNextFile(){} // RVA: 0x7FFAC85BB3E0
        public void BrokeredSafeFindHandleDispose(){} // RVA: 0x7FFAC85BB4B0
        public void RemoveExtendedPathPrefix(){} // RVA: 0x7FFAC85BB4C0
    }

    public class FileSystemEventArgs : EventArgs
    {
        public 0x6B139730 ChangeType; // 0x10
        public string FullPath; // 0x18
        public string _fullPath; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9456B90
        public void Combine(){} // RVA: 0x7FFAC9456D10
        public void get_ChangeType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_FullPath(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class FileSystemEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class FileSystemInfo : MarshalByRefObject
    {
        public WIN32_FILE_ATTRIBUTE_DATA Attributes; // 0x18
        public int ExistsCore; // 0x3C
        public string CreationTimeCore; // 0x40
        public string LastAccessTimeCore; // 0x48
        public string LastWriteTimeCore; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85DC3C0 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC85DBD80
        public void Invalidate(){} // RVA: 0x7FFAC85DB7E0
        public void Init(){} // RVA: 0x7FFAC85DBF80
        public void get_Attributes(){} // RVA: 0x7FFAC85DBFD0
        public void set_Attributes(){} // RVA: 0x7FFAC85DBFF0
        public void get_ExistsCore(){} // RVA: 0x7FFAC85DC0D0
        public void get_CreationTimeCore(){} // RVA: 0x7FFAC85DC160
        public void get_LastAccessTimeCore(){} // RVA: 0x7FFAC85DC1A0
        public void get_LastWriteTimeCore(){} // RVA: 0x7FFAC85DC1E0
        public void get_LengthCore(){} // RVA: 0x7FFAC85DC220
        public void EnsureDataInitialized(){} // RVA: 0x7FFAC85DC250
        public void Refresh(){} // RVA: 0x7FFAC85DC2C0
        public void get_NormalizedPath(){} // RVA: 0x7FFAC85DC2F0
        public void GetObjectData(){} // RVA: 0x7FFAC85DC620
        public void get_FullName(){} // RVA: 0x7FFAC2F9E740
        public void get_Name(){} // RVA: 0x7FFAC2FC20E0
        public void get_Exists(){} // RVA: 0x7FFAC85DCA50
        public void Delete(){} // RVA: 0x7FFAC2C70980
        public void get_CreationTimeUtc(){} // RVA: 0x7FFAC85DCAE0
        public void get_LastAccessTime(){} // RVA: 0x7FFAC85DCB90
        public void get_LastAccessTimeUtc(){} // RVA: 0x7FFAC85DCCC0
        public void get_LastWriteTime(){} // RVA: 0x7FFAC85DCD70
        public void get_LastWriteTimeUtc(){} // RVA: 0x7FFAC85DCEA0
        public void ToString(){} // RVA: 0x7FFAC85DCF50
    }

    public class FileSystemWatcher : Component
    {
        public bool Waiting; // 0x28
        public bool MangledFilter; // 0x29
        public bool Pattern; // 0x2A
        public string FullPath; // 0x30
        public bool EnableRaisingEvents; // 0x38
        public int Filter; // 0x3C
        public 0x6B139578 IncludeSubdirectories; // 0x40
        public string NotifyFilter; // 0x48
        public string Site; // 0x50
        public System.ComponentModel.ISynchronizeInvoke synchronizingObject; // 0x58
        public System.IO.WaitForChangedResult lastData; // 0x60
        public bool waiting; // 0x80
        public System.IO.SearchPattern2 pattern; // 0x88
        public bool disposed; // 0x90
        public string mangledFilter; // 0x98
        public System.IO.IFileWatcher watcher; // 0xA0
        public object watcher_handle; // 0xA8
        public object lockobj;
        public System.IO.FileSystemEventHandler Changed; // 0xB0
        public System.IO.FileSystemEventHandler Created; // 0xB8
        public System.IO.FileSystemEventHandler Deleted; // 0xC0
        public System.IO.ErrorEventHandler Error; // 0xC8
        public System.IO.RenamedEventHandler Renamed; // 0xD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC945A900 | overloaded x2
        public void InitWatcher(){} // RVA: 0x7FFAC945ABF0
        public void get_Waiting(){} // RVA: 0x7FFAC313E620
        public void set_Waiting(){} // RVA: 0x7FFAC313D3B0
        public void get_MangledFilter(){} // RVA: 0x7FFAC945B1A0
        public void get_Pattern(){} // RVA: 0x7FFAC945B240
        public void get_FullPath(){} // RVA: 0x7FFAC945B3A0
        public void set_EnableRaisingEvents(){} // RVA: 0x7FFAC945B4D0
        public void set_Filter(){} // RVA: 0x7FFAC945B580
        public void get_IncludeSubdirectories(){} // RVA: 0x7FFAC31D95D0
        public void set_IncludeSubdirectories(){} // RVA: 0x7FFAC945B800
        public void set_NotifyFilter(){} // RVA: 0x7FFAC945B840
        public void get_Site(){} // RVA: 0x7FFAC2F247C0
        public void set_Site(){} // RVA: 0x7FFAC945B880
        public void BeginInit(){} // RVA: 0x7FFAC494FE90
        public void Dispose(){} // RVA: 0x7FFAC945B970
        public void Finalize(){} // RVA: 0x7FFAC945BB10
        public void EndInit(){} // RVA: 0x7FFAC945BB90
        public void RaiseEvent(){} // RVA: 0x7FFAC945BC40
        public void OnChanged(){} // RVA: 0x7FFAC945BFD0
        public void OnCreated(){} // RVA: 0x7FFAC945C000
        public void OnDeleted(){} // RVA: 0x7FFAC945C030
        public void OnRenamed(){} // RVA: 0x7FFAC945C060
        public void DispatchEvents(){} // RVA: 0x7FFAC945C090
        public void Start(){} // RVA: 0x7FFAC945C5F0
        public void Stop(){} // RVA: 0x7FFAC945C660
        public void add_Changed(){} // RVA: 0x7FFAC945C6D0
        public void remove_Changed(){} // RVA: 0x7FFAC945C7C0
        public void add_Created(){} // RVA: 0x7FFAC945C8B0
        public void remove_Created(){} // RVA: 0x7FFAC945C9A0
        public void add_Deleted(){} // RVA: 0x7FFAC945CA90
        public void remove_Deleted(){} // RVA: 0x7FFAC945CB80
        public void .cctor(){} // RVA: 0x7FFAC945CC70
    }

    public class IFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7FFAC2C70A40
        public void StopDispatching(){} // RVA: 0x7FFAC2C70A40
        public void Dispose(){} // RVA: 0x7FFAC2C70A40
    }

    public class IODescriptionAttribute : DescriptionAttribute
    {
        public object Description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC945CF80
        public void get_Description(){} // RVA: 0x7FFAC2F3C380
    }

    public class IOException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x5
    }

    public class InvalidDataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

    public class MemoryStream : Stream
    {
        public byte[] CanRead; // 0x28
        public int CanSeek; // 0x30
        public int CanWrite; // 0x34
        public int Capacity; // 0x38
        public int Length; // 0x3C
        public bool Position; // 0x40
        public bool _writable; // 0x41
        public bool _exposable; // 0x42
        public bool _isOpen; // 0x43
        public System.Threading.Tasks.Task`1<int> _lastReadTask; // 0x48
        public int MemStreamMaxLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCF20 | overloaded x7
        public void get_CanRead(){} // RVA: 0x7FFAC3FA0E90
        public void get_CanSeek(){} // RVA: 0x7FFAC3FA0E90
        public void get_CanWrite(){} // RVA: 0x7FFAC31D8A60
        public void EnsureNotClosed(){} // RVA: 0x7FFAC85BD140
        public void EnsureWriteable(){} // RVA: 0x7FFAC85BD180
        public void Dispose(){} // RVA: 0x7FFAC85BD1D0
        public void EnsureCapacity(){} // RVA: 0x7FFAC85BD250
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void FlushAsync(){} // RVA: 0x7FFAC85BD310
        public void GetBuffer(){} // RVA: 0x7FFAC85BD440
        public void InternalGetBuffer(){} // RVA: 0x7FFAC2F4F130
        public void InternalGetPosition(){} // RVA: 0x7FFAC3ADEDC0
        public void InternalReadInt32(){} // RVA: 0x7FFAC85BD4B0
        public void InternalEmulateRead(){} // RVA: 0x7FFAC85BD590
        public void get_Capacity(){} // RVA: 0x7FFAC85BD5F0
        public void set_Capacity(){} // RVA: 0x7FFAC85BD630
        public void get_Length(){} // RVA: 0x7FFAC85BD810
        public void get_Position(){} // RVA: 0x7FFAC85BD860
        public void set_Position(){} // RVA: 0x7FFAC85BD8B0
        public void Read(){} // RVA: 0x7FFAC85BDC40 | overloaded x2
        public void ReadAsync(){} // RVA: 0x7FFAC85BE220 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAC85BE640
        public void CopyTo(){} // RVA: 0x7FFAC85BE6C0
        public void CopyToAsync(){} // RVA: 0x7FFAC85BE850
        public void Seek(){} // RVA: 0x7FFAC85BEB70
        public void SetLength(){} // RVA: 0x7FFAC85BEDD0
        public void ToArray(){} // RVA: 0x7FFAC85BEF40
        public void Write(){} // RVA: 0x7FFAC85BF2F0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAC85BF880 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAC85BFBD0
        public void WriteTo(){} // RVA: 0x7FFAC85BFCF0
    }

    public class MonoIO : Object
    {
        public UIntPtr ConsoleOutput;
        public bool ConsoleInput; // 0x8

        // ── Methods ──
        public void GetException(){} // RVA: 0x7FFAC85F7110 | overloaded x2
        public void GetCurrentDirectory(){} // RVA: 0x7FFAC85F7980
        public void GetFileType(){} // RVA: 0x7FFAC85F7A20 | overloaded x2
        public void FindCloseFile(){} // RVA: 0x7FFAC85F7B30
        public void Open(){} // RVA: 0x7FFAC85F7DA0 | overloaded x2
        public void Cancel_internal(){} // RVA: 0x7FFAC85F7EF0
        public void Cancel(){} // RVA: 0x7FFAC85F7F10
        public void Close(){} // RVA: 0x7FFAC85F8030
        public void Read(){} // RVA: 0x7FFAC85F8100 | overloaded x2
        public void Write(){} // RVA: 0x7FFAC85F8320 | overloaded x2
        public void Seek(){} // RVA: 0x7FFAC85F84D0 | overloaded x2
        public void GetLength(){} // RVA: 0x7FFAC85F8680 | overloaded x2
        public void SetLength(){} // RVA: 0x7FFAC85F8870 | overloaded x2
        public void get_ConsoleOutput(){} // RVA: 0x7FFAC85F8A40
        public void get_ConsoleInput(){} // RVA: 0x7FFAC85F8A50
        public void get_ConsoleError(){} // RVA: 0x7FFAC85F8A60
        public void CreatePipe(){} // RVA: 0x7FFAC85F8A70
        public void DuplicateHandle(){} // RVA: 0x7FFAC85F8B70
        public void get_VolumeSeparatorChar(){} // RVA: 0x7FFAC85F8C60
        public void get_DirectorySeparatorChar(){} // RVA: 0x7FFAC530F580
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x7FFAC85F8C70
        public void get_PathSeparator(){} // RVA: 0x7FFAC85F8C80
        public void DumpHandles(){} // RVA: 0x7FFAC8533400
        public void RemapPath(){} // RVA: 0x7FFAC85F8C90
        public void .cctor(){} // RVA: 0x7FFAC85F8CA0
    }

    public class MonoIOStat : ValueType
    {
        public 0x6B0E2B78 fileAttributes; // 0x10
        public long Length; // 0x18
        public long CreationTime; // 0x20
        public long LastAccessTime; // 0x28
        public long LastWriteTime; // 0x30
    }

    public class MonoLinqHelper : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFAC2C58F80
    }

    public class NullFileWatcher : Object
    {
        public System.IO.IFileWatcher instance;

        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7FFAC2F21310
        public void StopDispatching(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void GetInstance(){} // RVA: 0x7FFAC945D0B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Path : Object
    {
        public char[] StringComparison;
        public char IsCaseSensitive; // 0x8
        public char IsWindows; // 0xA
        public char PathSeparator; // 0xC
        public string DirectorySeparatorStr; // 0x10
        public char VolumeSeparatorChar; // 0x18
        public char[] PathSeparatorChars; // 0x20
        public bool dirEqualsVolume; // 0x28
        public char[] trimEndCharsWindows; // 0x30
        public char[] trimEndCharsUnix; // 0x38

        // ── Methods ──
        public void ChangeExtension(){} // RVA: 0x7FFAC85F8D20
        public void Combine(){} // RVA: 0x7FFAC85FD440 | overloaded x4
        public void CleanPath(){} // RVA: 0x7FFAC85F92B0
        public void GetDirectoryName(){} // RVA: 0x7FFAC85F9C20 | overloaded x2
        public void GetExtension(){} // RVA: 0x7FFAC85F9D00
        public void GetFileName(){} // RVA: 0x7FFAC85FD680 | overloaded x2
        public void GetFileNameWithoutExtension(){} // RVA: 0x7FFAC85F9F80
        public void GetFullPath(){} // RVA: 0x7FFAC85F9FE0
        public void GetFullPathInternal(){} // RVA: 0x7FFAC85FA030
        public void GetFullPathName(){} // RVA: 0x7FFAC85FA170 | overloaded x2
        public void WindowsDriveAdjustment(){} // RVA: 0x7FFAC85FA420
        public void InsecureGetFullPath(){} // RVA: 0x7FFAC85FA660
        public void IsDirectorySeparator(){} // RVA: 0x7FFAC85FAC90
        public void GetPathRoot(){} // RVA: 0x7FFAC85FAD20
        public void GetTempPath(){} // RVA: 0x7FFAC85FB1C0
        public void get_temp_path(){} // RVA: 0x7FFAC85FB430
        public void IsPathRooted(){} // RVA: 0x7FFAC85FB6B0 | overloaded x2
        public void GetInvalidFileNameChars(){} // RVA: 0x7FFAC85FB8F0
        public void GetInvalidPathChars(){} // RVA: 0x7FFAC85FB960
        public void GetRandomFileName(){} // RVA: 0x7FFAC85FB9D0
        public void findExtension(){} // RVA: 0x7FFAC85FBB70
        public void .cctor(){} // RVA: 0x7FFAC85FBC20
        public void GetServerAndShare(){} // RVA: 0x7FFAC85FC0E0
        public void SameRoot(){} // RVA: 0x7FFAC85FC340
        public void CanonicalizePath(){} // RVA: 0x7FFAC85FC6A0
        public void Join(){} // RVA: 0x7FFAC85FD8F0 | overloaded x2
        public void JoinInternal(){} // RVA: 0x7FFAC85FE160 | overloaded x2
        public void GetRelativePath(){} // RVA: 0x7FFAC85FE840 | overloaded x2
        public void get_StringComparison(){} // RVA: 0x7FFAC85FEF90
        public void get_IsCaseSensitive(){} // RVA: 0x7FFAC85FF040
        public void get_IsWindows(){} // RVA: 0x7FFAC85FF0B0
    }

    public class PathInternal : Object
    {
        public bool IsCaseSensitive;

        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x7FFAC85BFDC0
        public void EndsWithPeriodOrSpace(){} // RVA: 0x7FFAC85BFDE0
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x7FFAC85BFE30
        public void EnsureExtendedPrefix(){} // RVA: 0x7FFAC85BFEE0
        public void IsDevice(){} // RVA: 0x7FFAC85C0130
        public void IsDeviceUNC(){} // RVA: 0x7FFAC85C0300
        public void IsExtended(){} // RVA: 0x7FFAC85C03F0
        public void GetRootLength(){} // RVA: 0x7FFAC85C0480
        public void IsDirectorySeparator(){} // RVA: 0x7FFAC85C0870
        public void IsEffectivelyEmpty(){} // RVA: 0x7FFAC85C0890
        public void EndsInDirectorySeparator(){} // RVA: 0x7FFAC85C0910
        public void StartsWithDirectorySeparator(){} // RVA: 0x7FFAC85C09B0
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7FFAC85C0C60 | overloaded x2
        public void IsRoot(){} // RVA: 0x7FFAC85C0E40
        public void GetCommonPathLength(){} // RVA: 0x7FFAC85C0EB0
        public void EqualStartingCharacterCount(){} // RVA: 0x7FFAC85C10F0
        public void AreRootsEqual(){} // RVA: 0x7FFAC85C1210
        public void get_IsCaseSensitive(){} // RVA: 0x7FFAC85C1370
        public void GetIsCaseSensitive(){} // RVA: 0x7FFAC85C13D0
        public void IsPartiallyQualified(){} // RVA: 0x7FFAC2F21320
        public void .cctor(){} // RVA: 0x7FFAC85C15F0
    }

    public class PathTooLongException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class PinnedBufferMemoryStream : UnmanagedMemoryStream
    {
        public byte[] _array; // 0x68
        public System.Runtime.InteropServices.GCHandle _pinningHandle; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85C16B0
        public void Read(){} // RVA: 0x7FFAC85C1800
        public void Write(){} // RVA: 0x7FFAC85C1820
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void Dispose(){} // RVA: 0x7FFAC85C1840
    }

    public class RenamedEventArgs : FileSystemEventArgs
    {
        public string _oldName; // 0x28
        public string _oldFullPath; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9457140
    }

    public class RenamedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class SearchPattern2 : Object
    {
        public Op HasWildcard; // 0x10
        public bool ignore; // 0x18
        public bool hasWildcard; // 0x19
        public string pattern; // 0x20
        public char[] WildcardChars;
        public char[] InvalidChars; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC945D290 | overloaded x2
        public void get_HasWildcard(){} // RVA: 0x7FFAC3228D50
        public void Compile(){} // RVA: 0x7FFAC945D2F0
        public void .cctor(){} // RVA: 0x7FFAC945D720
    }

    public class Stream : MarshalByRefObject
    {
        public System.IO.Stream CanRead;
        public int CanSeek;
        public ReadWriteTask CanTimeout; // 0x18
        public System.Threading.SemaphoreSlim CanWrite; // 0x20

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFAC85E5D10
        public void get_CanRead(){} // RVA: 0x7FFAC2C59D00
        public void get_CanSeek(){} // RVA: 0x7FFAC2C59D00
        public void get_CanTimeout(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC2C59D00
        public void get_Length(){} // RVA: 0x7FFAC2C58E90
        public void get_Position(){} // RVA: 0x7FFAC2C58E90
        public void set_Position(){} // RVA: 0x7FFAC2C70BF0
        public void get_ReadTimeout(){} // RVA: 0x7FFAC85E5E70
        public void set_ReadTimeout(){} // RVA: 0x7FFAC85E5EC0
        public void get_WriteTimeout(){} // RVA: 0x7FFAC85E5F10
        public void set_WriteTimeout(){} // RVA: 0x7FFAC85E5F60
        public void CopyToAsync(){} // RVA: 0x7FFAC85E60D0 | overloaded x3
        public void CopyToAsyncInternal(){} // RVA: 0x7FFAC85E6130
        public void CopyTo(){} // RVA: 0x7FFAC85E6400 | overloaded x2
        public void GetCopyBufferSize(){} // RVA: 0x7FFAC85E65D0
        public void Close(){} // RVA: 0x7FFAC85E66D0
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAC2C70980
        public void FlushAsync(){} // RVA: 0x7FFAC85E67A0 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFAC85E6A00
        public void BeginReadInternal(){} // RVA: 0x7FFAC85E6A40
        public void EndRead(){} // RVA: 0x7FFAC85E6CD0
        public void ReadAsync(){} // RVA: 0x7FFAC85E70A0 | overloaded x3
        public void BeginEndReadAsync(){} // RVA: 0x7FFAC85E7370
        public void BeginWrite(){} // RVA: 0x7FFAC85E76D0
        public void BeginWriteInternal(){} // RVA: 0x7FFAC85E7710
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7FFAC85E79A0
        public void RunReadWriteTask(){} // RVA: 0x7FFAC85E7BF0
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFAC85E7D50
        public void EndWrite(){} // RVA: 0x7FFAC85E7DD0
        public void WriteAsync(){} // RVA: 0x7FFAC85E81A0 | overloaded x3
        public void FinishWriteAsync(){} // RVA: 0x7FFAC85E8590
        public void BeginEndWriteAsync(){} // RVA: 0x7FFAC85E87A0
        public void Seek(){}
        public void SetLength(){} // RVA: 0x7FFAC2C70BF0
        public void Read(){} // RVA: 0x7FFAC85E8B00 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAC85E8DA0
        public void Write(){} // RVA: 0x7FFAC85E8E50 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAC85E8FF0
        public void BlockingBeginRead(){} // RVA: 0x7FFAC85E9080
        public void BlockingEndRead(){} // RVA: 0x7FFAC85E91C0
        public void BlockingBeginWrite(){} // RVA: 0x7FFAC85E92E0
        public void BlockingEndWrite(){} // RVA: 0x7FFAC85E9420
        public void HasOverriddenBeginEndRead(){} // RVA: 0x7FFAC3006850
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x7FFAC3006850
        public void DisposeAsync(){} // RVA: 0x7FFAC85E9540
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC85E95F0
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x7FFAC85E96E0
    }

    public class StreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateCopyToArgs(){} // RVA: 0x7FFAC85C18D0
    }

    public class StreamReader : TextReader
    {
        public System.IO.StreamReader CurrentEncoding;
        public System.IO.Stream BaseStream; // 0x18
        public System.Text.Encoding LeaveOpen; // 0x20
        public System.Text.Decoder EndOfStream; // 0x28
        public byte[] _byteBuffer; // 0x30
        public char[] _charBuffer; // 0x38
        public int _charPos; // 0x40
        public int _charLen; // 0x44
        public int _byteLen; // 0x48
        public int _bytePos; // 0x4C
        public int _maxCharsPerBuffer; // 0x50
        public bool _detectEncoding; // 0x54
        public bool _checkPreamble; // 0x55
        public bool _isBlocked; // 0x56
        public bool _closable; // 0x57
        public System.Threading.Tasks.Task _asyncReadTask; // 0x58

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFAC85C1BA0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFAC85C1C40
        public void .ctor(){} // RVA: 0x7FFAC85C2240 | overloaded x11
        public void Init(){} // RVA: 0x7FFAC85C2820 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC84480E0
        public void Dispose(){} // RVA: 0x7FFAC85C2880
        public void get_CurrentEncoding(){} // RVA: 0x7FFAC2F4F0C0
        public void get_BaseStream(){} // RVA: 0x7FFAC2F247C0
        public void get_LeaveOpen(){} // RVA: 0x7FFAC85C2B20
        public void get_EndOfStream(){} // RVA: 0x7FFAC85C2B30
        public void Peek(){} // RVA: 0x7FFAC85C2BD0
        public void Read(){} // RVA: 0x7FFAC85C2F30 | overloaded x3
        public void ReadSpan(){} // RVA: 0x7FFAC85C3040
        public void ReadToEnd(){} // RVA: 0x7FFAC85C32F0
        public void CompressBuffer(){} // RVA: 0x7FFAC85C3430
        public void DetectEncoding(){} // RVA: 0x7FFAC85C3470
        public void IsPreamble(){} // RVA: 0x7FFAC85C3A10
        public void ReadBuffer(){} // RVA: 0x7FFAC85C42B0 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFAC85C4C60
        public void ReadToEndAsync(){} // RVA: 0x7FFAC85C4EC0
        public void ReadToEndAsyncInternal(){} // RVA: 0x7FFAC85C5340
        public void ReadAsync(){} // RVA: 0x7FFAC85C54E0
        public void ReadAsyncInternal(){} // RVA: 0x7FFAC85C5810
        public void ReadBufferAsync(){} // RVA: 0x7FFAC85C5AB0
        public void DataAvailable(){} // RVA: 0x7FFAC85C5C60
        public void .cctor(){} // RVA: 0x7FFAC85C5C70
    }

    public class StreamWriter : TextWriter
    {
        public System.IO.StreamWriter UTF8NoBOM;
        public System.IO.Stream AutoFlush; // 0x30
        public System.Text.Encoding BaseStream; // 0x38
        public System.Text.Encoder LeaveOpen; // 0x40
        public byte[] Encoding; // 0x48
        public char[] CharPos_Prop; // 0x50
        public int HaveWrittenPreamble_Prop; // 0x58
        public int _charLen; // 0x5C
        public bool _autoFlush; // 0x60
        public bool _haveWrittenPreamble; // 0x61
        public bool _closable; // 0x62
        public System.Threading.Tasks.Task _asyncWriteTask; // 0x68

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFAC85C8DE0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFAC85C8E80
        public void get_UTF8NoBOM(){} // RVA: 0x7FFAC85C8ED0
        public void .ctor(){} // RVA: 0x7FFAC85C9550 | overloaded x9
        public void Init(){} // RVA: 0x7FFAC85C9860
        public void Close(){} // RVA: 0x7FFAC85C9B30
        public void Dispose(){} // RVA: 0x7FFAC85C9BA0
        public void DisposeAsync(){} // RVA: 0x7FFAC85C9ED0
        public void DisposeAsyncCore(){} // RVA: 0x7FFAC85CA150
        public void CloseStreamFromDispose(){} // RVA: 0x7FFAC85CA2F0
        public void Flush(){} // RVA: 0x7FFAC85CA3C0 | overloaded x2
        public void set_AutoFlush(){} // RVA: 0x7FFAC85CA5B0
        public void get_BaseStream(){} // RVA: 0x7FFAC31D95E0
        public void get_LeaveOpen(){} // RVA: 0x7FFAC85CA5F0
        public void get_Encoding(){} // RVA: 0x7FFAC31D0140
        public void Write(){} // RVA: 0x7FFAC85CAC10 | overloaded x4
        public void WriteSpan(){} // RVA: 0x7FFAC85CA990
        public void WriteLine(){} // RVA: 0x7FFAC85CAC90
        public void WriteAsync(){} // RVA: 0x7FFAC85CB700 | overloaded x3
        public void WriteAsyncInternal(){} // RVA: 0x7FFAC85CBAA0 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFAC85CBDF0
        public void FlushAsync(){} // RVA: 0x7FFAC85CC190
        public void set_CharPos_Prop(){} // RVA: 0x7FFAC362EA00
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x7FFAC3C04530
        public void FlushAsyncInternal(){} // RVA: 0x7FFAC85CC540 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC85CC930
    }

    public class StringReader : TextReader
    {
        public string _s; // 0x18
        public int _pos; // 0x20
        public int _length; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85F0E70
        public void Close(){} // RVA: 0x7FFAC84480E0
        public void Dispose(){} // RVA: 0x7FFAC85F0F60
        public void Peek(){} // RVA: 0x7FFAC85F0FC0
        public void Read(){} // RVA: 0x7FFAC85F1070 | overloaded x2
        public void ReadToEnd(){} // RVA: 0x7FFAC85F1280
        public void ReadLine(){} // RVA: 0x7FFAC85F12E0
        public void ReadToEndAsync(){} // RVA: 0x7FFAC85F1410
        public void ReadAsync(){} // RVA: 0x7FFAC85F1490
    }

    public class StringWriter : TextWriter
    {
        public System.Text.UnicodeEncoding Encoding;
        public System.Text.StringBuilder _sb; // 0x30
        public bool _isOpen; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85F1890 | overloaded x4
        public void Close(){} // RVA: 0x7FFAC85F19B0
        public void Dispose(){} // RVA: 0x7FFAC2F2F7C0
        public void get_Encoding(){} // RVA: 0x7FFAC85F19D0
        public void GetStringBuilder(){} // RVA: 0x7FFAC31D95E0
        public void Write(){} // RVA: 0x7FFAC85F1D00 | overloaded x3
        public void WriteAsync(){} // RVA: 0x7FFAC85F1EC0 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFAC85F1FB0
        public void FlushAsync(){} // RVA: 0x7FFAC85F20A0
        public void ToString(){} // RVA: 0x7FFAC85F2140
    }

    public class TextReader : MarshalByRefObject
    {
        public System.IO.TextReader Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Close(){} // RVA: 0x7FFAC85CEA30
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Peek(){} // RVA: 0x7FFAC32BD0E0
        public void Read(){} // RVA: 0x7FFAC85CED20 | overloaded x3
        public void ReadToEnd(){} // RVA: 0x7FFAC85CEFC0
        public void ReadLine(){} // RVA: 0x7FFAC85CF100
        public void ReadToEndAsync(){} // RVA: 0x7FFAC85CF280
        public void ReadAsync(){} // RVA: 0x7FFAC85CF430
        public void ReadAsyncInternal(){} // RVA: 0x7FFAC85CF660
        public void Synchronized(){} // RVA: 0x7FFAC85CFAB0
        public void .cctor(){} // RVA: 0x7FFAC85CFBF0
    }

    public class TextWriter : MarshalByRefObject
    {
        public System.IO.TextWriter FormatProvider;
        public char[] Encoding; // 0x8
        public char[] NewLine; // 0x18
        public string CoreNewLineStr; // 0x20
        public System.IFormatProvider _internalFormatProvider; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85D0D30 | overloaded x2
        public void get_FormatProvider(){} // RVA: 0x7FFAC85D0EB0
        public void Close(){} // RVA: 0x7FFAC85D0F50
        public void Dispose(){} // RVA: 0x7FFAC85D0FC0 | overloaded x2
        public void DisposeAsync(){} // RVA: 0x7FFAC85D1030
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void get_Encoding(){} // RVA: 0x7FFAC2C58E90
        public void get_NewLine(){} // RVA: 0x7FFAC2F4F0C0
        public void Write(){} // RVA: 0x7FFAC85D14B0 | overloaded x8
        public void WriteLine(){} // RVA: 0x7FFAC85D16E0 | overloaded x5
        public void WriteAsync(){} // RVA: 0x7FFAC85D1D70 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFAC85D2040
        public void FlushAsync(){} // RVA: 0x7FFAC85D2310
        public void Synchronized(){} // RVA: 0x7FFAC85D25A0
        public void .cctor(){} // RVA: 0x7FFAC85D2700
    }

    public class UnexceptionalStreamReader : StreamReader
    {
        public bool[] newline;
        public char newlineChar; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC85FF710
        public void .ctor(){} // RVA: 0x7FFAC85FF800
        public void Peek(){} // RVA: 0x7FFAC85FF890
        public void Read(){} // RVA: 0x7FFAC85FF8D0 | overloaded x2
        public void CheckEOL(){} // RVA: 0x7FFAC85FFB40
        public void ReadLine(){} // RVA: 0x7FFAC85FFD20
        public void ReadToEnd(){} // RVA: 0x7FFAC85FFD40
    }

    public class UnexceptionalStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85FFE90
        public void Flush(){} // RVA: 0x7FFAC85FFF10
        public void Write(){} // RVA: 0x7FFAC85FFFA0 | overloaded x4
    }

    public class UnmanagedMemoryAccessor : Object
    {
        public System.Runtime.InteropServices.SafeBuffer Capacity; // 0x10
        public long IsOpen; // 0x18
        public long _capacity; // 0x20
        public 0x6B0E1890 _access; // 0x28
        public bool _isOpen; // 0x2C
        public bool _canRead; // 0x2D
        public bool _canWrite; // 0x2E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC42FC830
        public void Initialize(){} // RVA: 0x7FFAC85D3590
        public void get_Capacity(){} // RVA: 0x7FFAC2F4F0C0
        public void Dispose(){} // RVA: 0x7FFAC85D39D0 | overloaded x2
        public void get_IsOpen(){} // RVA: 0x7FFAC3000230
    }

    public class UnmanagedMemoryStream : Stream
    {
        public System.Runtime.InteropServices.SafeBuffer CanRead; // 0x28
        public byte* CanSeek; // 0x30
        public long CanWrite; // 0x38
        public long Length; // 0x40
        public long Position; // 0x48
        public long PositionPointer; // 0x50
        public 0x6B0E1890 _access; // 0x58
        public bool _isOpen; // 0x5C
        public System.Threading.Tasks.Task`1<int> _lastReadTask; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85D3B20 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFAC85D3BB0
        public void get_CanRead(){} // RVA: 0x7FFAC85D3E40
        public void get_CanSeek(){} // RVA: 0x7FFAC2FBF240
        public void get_CanWrite(){} // RVA: 0x7FFAC85D3E60
        public void Dispose(){} // RVA: 0x7FFAC85D3E80
        public void EnsureNotClosed(){} // RVA: 0x7FFAC85D3E90
        public void EnsureReadable(){} // RVA: 0x7FFAC85D3ED0
        public void EnsureWriteable(){} // RVA: 0x7FFAC85D3F20
        public void Flush(){} // RVA: 0x7FFAC85D3E90
        public void FlushAsync(){} // RVA: 0x7FFAC85D3F70
        public void get_Length(){} // RVA: 0x7FFAC85D40A0
        public void get_Position(){} // RVA: 0x7FFAC85D40F0
        public void set_Position(){} // RVA: 0x7FFAC85D4140
        public void get_PositionPointer(){} // RVA: 0x7FFAC85D4200
        public void Read(){} // RVA: 0x7FFAC85D4520 | overloaded x2
        public void ReadCore(){} // RVA: 0x7FFAC85D4630
        public void ReadAsync(){} // RVA: 0x7FFAC85D4C10 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAC85D4FC0
        public void Seek(){} // RVA: 0x7FFAC85D5140
        public void SetLength(){} // RVA: 0x7FFAC85D5310
        public void Write(){} // RVA: 0x7FFAC85D5750 | overloaded x2
        public void WriteCore(){} // RVA: 0x7FFAC85D5860
        public void WriteAsync(){} // RVA: 0x7FFAC85D5E90 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAC85D6180
    }

    public class WaitForChangedResult : ValueType
    {
        public System.IO.WaitForChangedResult ChangeType;
        public 0x6B139730 Name; // 0x10
        public string OldName; // 0x18
        public string TimedOut; // 0x20
        public bool <TimedOut>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9457230
        public void set_ChangeType(){} // RVA: 0x7FFAC336D8B0
        public void set_Name(){} // RVA: 0x7FFAC4420240
        public void set_OldName(){} // RVA: 0x7FFAC2F22E30
        public void set_TimedOut(){} // RVA: 0x7FFAC2F3C4F0
        public void .cctor(){} // RVA: 0x7FFAC9457350
    }

    public class Win32Marshal : Object
    {
        // ── Methods ──
        public void GetExceptionForLastWin32Error(){} // RVA: 0x7FFAC85D66C0
        public void GetExceptionForWin32Error(){} // RVA: 0x7FFAC85D6720
        public void MakeHRFromErrorCode(){} // RVA: 0x7FFAC85D6C60
        public void TryMakeWin32ErrorCodeFromHR(){} // RVA: 0x7FFAC85D6C80
        public void GetMessage(){} // RVA: 0x7FFAC8389050
    }

    public class __Error : Object
    {
        // ── Methods ──
        public void EndOfFile(){} // RVA: 0x7FFAC85ECBB0
        public void FileNotOpen(){} // RVA: 0x7FFAC85ECC10
        public void ReaderClosed(){} // RVA: 0x7FFAC85ECC80
        public void GetDisplayablePath(){} // RVA: 0x7FFAC85ECCF0
        public void WinIOError(){} // RVA: 0x7FFAC85ECE50
        public void WriterClosed(){} // RVA: 0x7FFAC85ED670
    }

}