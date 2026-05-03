// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 60
// Methods: 889

namespace ThirdParty.DotNet.System.IO
{
    public class BinaryReader : Object
    {
        public System.IO.Stream m_stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86996F70 | overloaded x3
        public void get_BaseStream(){} // RVA: 0x7FFE81116380
        public void Close(){} // RVA: 0x7FFE82AABF60
        public void Dispose(){} // RVA: 0x7FFE82AABF60 | overloaded x2
        public void Read(){} // RVA: 0x7FFE86998950 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x7FFE869974F0
        public void ReadByte(){} // RVA: 0x7FFE86997540
        public void ReadSByte(){} // RVA: 0x7FFE86997580
        public void ReadChar(){} // RVA: 0x7FFE869975D0
        public void ReadInt16(){} // RVA: 0x7FFE86997600
        public void ReadUInt16(){} // RVA: 0x7FFE86997600
        public void ReadInt32(){} // RVA: 0x7FFE86997660
        public void ReadUInt32(){} // RVA: 0x7FFE86997840
        public void ReadInt64(){} // RVA: 0x7FFE869978C0
        public void ReadUInt64(){} // RVA: 0x7FFE869978C0
        public void ReadSingle(){} // RVA: 0x7FFE869979B0
        public void ReadDouble(){} // RVA: 0x7FFE86997A30
        public void ReadDecimal(){} // RVA: 0x7FFE86997AB0
        public void ReadString(){} // RVA: 0x7FFE86997D20
        public void InternalReadChars(){} // RVA: 0x7FFE86998020
        public void InternalReadOneChar(){} // RVA: 0x7FFE86998430
        public void ReadChars(){} // RVA: 0x7FFE86998770
        public void ReadBytes(){} // RVA: 0x7FFE86998B40
        public void FillBuffer(){} // RVA: 0x7FFE86998D40
        public void Read7BitEncodedInt(){} // RVA: 0x7FFE86998EB0
    }

    public class BinaryWriter : Object
    {
        public System.IO.BinaryWriter Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86999290 | overloaded x4
        public void Close(){} // RVA: 0x7FFE82AABF60
        public void Dispose(){} // RVA: 0x7FFE82AABF60 | overloaded x2
        public void get_BaseStream(){} // RVA: 0x7FFE869994D0
        public void Flush(){} // RVA: 0x7FFE8693D0B0
        public void DisposeAsync(){} // RVA: 0x7FFE86999500
        public void Write(){} // RVA: 0x7FFE8699A150 | overloaded x16
        public void Write7BitEncodedInt(){} // RVA: 0x7FFE8699A520
        public void .cctor(){} // RVA: 0x7FFE8699A590
    }

    public class BufferedStream : Stream
    {
        public System.IO.Stream _stream; // 0x28
        public byte[] _buffer; // 0x30
        public int _bufferSize; // 0x38
        public int _readPos; // 0x3C
        public int _readLen; // 0x40

        // ── Methods ──
        public void LazyEnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFE86986770
        public void .ctor(){} // RVA: 0x7FFE869868E0 | overloaded x2
        public void EnsureNotClosed(){} // RVA: 0x7FFE86986B30
        public void EnsureCanSeek(){} // RVA: 0x7FFE86986BA0
        public void EnsureCanRead(){} // RVA: 0x7FFE86986C30
        public void EnsureCanWrite(){} // RVA: 0x7FFE86986CC0
        public void EnsureShadowBufferAllocated(){} // RVA: 0x7FFE86986D50
        public void EnsureBufferAllocated(){} // RVA: 0x7FFE86986E80
        public void get_CanRead(){} // RVA: 0x7FFE86986F20
        public void get_CanWrite(){} // RVA: 0x7FFE86986F50
        public void get_CanSeek(){} // RVA: 0x7FFE86986F80
        public void get_Length(){} // RVA: 0x7FFE86986FB0
        public void get_Position(){} // RVA: 0x7FFE86987040
        public void set_Position(){} // RVA: 0x7FFE869870E0
        public void DisposeAsync(){} // RVA: 0x7FFE869871B0
        public void Dispose(){} // RVA: 0x7FFE86987360
        public void Flush(){} // RVA: 0x7FFE86987530
        public void FlushAsync(){} // RVA: 0x7FFE86987670
        public void FlushAsyncInternal(){} // RVA: 0x7FFE86987740
        public void FlushRead(){} // RVA: 0x7FFE86987960
        public void ClearReadBufferBeforeWrite(){} // RVA: 0x7FFE869879B0
        public void FlushWrite(){} // RVA: 0x7FFE86987A80
        public void FlushWriteAsync(){} // RVA: 0x7FFE86987AF0
        public void ReadFromBuffer(){} // RVA: 0x7FFE86987F00 | overloaded x3
        public void Read(){} // RVA: 0x7FFE869882A0 | overloaded x2
        public void LastSyncCompletedReadTask(){} // RVA: 0x7FFE869884C0
        public void ReadAsync(){} // RVA: 0x7FFE86988CE0 | overloaded x2
        public void ReadFromUnderlyingStreamAsync(){} // RVA: 0x7FFE86989190
        public void BeginRead(){} // RVA: 0x7FFE86989490
        public void EndRead(){} // RVA: 0x7FFE86989540
        public void ReadByte(){} // RVA: 0x7FFE86989580
        public void ReadByteSlow(){} // RVA: 0x7FFE869896B0
        public void WriteToBuffer(){} // RVA: 0x7FFE86989880 | overloaded x2
        public void Write(){} // RVA: 0x7FFE86989E20 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFE8698A490 | overloaded x2
        public void WriteToUnderlyingStreamAsync(){} // RVA: 0x7FFE8698A830
        public void BeginWrite(){} // RVA: 0x7FFE8698AAF0
        public void EndWrite(){} // RVA: 0x7FFE867AFBB0
        public void WriteByte(){} // RVA: 0x7FFE8698ABA0
        public void Seek(){} // RVA: 0x7FFE8698AC70
        public void SetLength(){} // RVA: 0x7FFE8698ADF0
        public void CopyTo(){} // RVA: 0x7FFE8698AED0
        public void CopyToAsync(){} // RVA: 0x7FFE8698AF80
        public void CopyToAsyncCore(){} // RVA: 0x7FFE8698B070
    }

    public class CStreamReader : StreamReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869A9790
        public void Peek(){} // RVA: 0x7FFE869A9060
        public void Read(){} // RVA: 0x7FFE869A9AE0 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFE869A9C90
        public void ReadToEnd(){} // RVA: 0x7FFE869A9CC0
    }

    public class CStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869A9CF0
        public void Write(){} // RVA: 0x7FFE869AA4B0 | overloaded x4
        public void InternalWriteString(){} // RVA: 0x7FFE869AA410
        public void InternalWriteChar(){} // RVA: 0x7FFE869AA430
        public void InternalWriteChars(){} // RVA: 0x7FFE869AA450
        public void WriteLine(){} // RVA: 0x7FFE869AA520
    }

    public class DefaultWatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetInstance(){} // RVA: 0x7FFE877FFBF0
        public void StartDispatching(){} // RVA: 0x7FFE877FFDC0
        public void StopDispatching(){} // RVA: 0x7FFE87800AF0
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void Monitor(){} // RVA: 0x7FFE878010E0
        public void UpdateDataAndDispatch(){} // RVA: 0x7FFE87801B10
        public void DispatchEvents(){} // RVA: 0x7FFE87801C50
        public void DoFiles(){} // RVA: 0x7FFE87801DF0
        public void IterateAndModifyFilesData(){} // RVA: 0x7FFE878021D0
        public void CreateFileData(){} // RVA: 0x7FFE87802E10
        public void .cctor(){} // RVA: 0x7FFE87802F30
    }

    public class DefaultWatcherData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FFB60
    }

    public class Directory : Object
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFE869804C0
        public void Exists(){} // RVA: 0x7FFE86980660
        public void GetFiles(){} // RVA: 0x7FFE869808B0 | overloaded x3
        public void GetDirectories(){} // RVA: 0x7FFE86980A60 | overloaded x2
        public void GetFileSystemEntries(){} // RVA: 0x7FFE86980C00 | overloaded x2
        public void InternalEnumeratePaths(){} // RVA: 0x7FFE86980C90
        public void EnumerateFiles(){} // RVA: 0x7FFE869810E0 | overloaded x4
        public void GetDirectoryRoot(){} // RVA: 0x7FFE86981100
        public void InternalGetDirectoryRoot(){} // RVA: 0x7FFE86981280
        public void GetCurrentDirectory(){} // RVA: 0x7FFE86981340
        public void Delete(){} // RVA: 0x7FFE86981350
        public void InsecureGetCurrentDirectory(){} // RVA: 0x7FFE869813F0
    }

    public class DirectoryInfo : FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869823E0 | overloaded x3
        public void Init(){} // RVA: 0x7FFE869815F0
        public void get_Parent(){} // RVA: 0x7FFE86981B70
        public void Create(){} // RVA: 0x7FFE86981D40
        public void GetFiles(){} // RVA: 0x7FFE86981ED0 | overloaded x3
        public void EnumerateFiles(){} // RVA: 0x7FFE869820E0 | overloaded x3
        public void InternalEnumerateInfos(){} // RVA: 0x7FFE86982180
        public void Delete(){} // RVA: 0x7FFE86982380
    }

    public class DirectoryNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class DisableMediaInsertionPrompt : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE86960A80
        public void Dispose(){} // RVA: 0x7FFE86960B00
    }

    public class DriveNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class EndOfStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class EnumerationOptions : Object
    {
        public System.IO.EnumerationOptions _compatible;
        public System.IO.EnumerationOptions _compatibleRecursive; // 0x8
        public System.IO.EnumerationOptions _default; // 0x10
        public bool _recurseSubdirectories; // 0x10
        public bool _ignoreInaccessible; // 0x11
        public int _bufferSize; // 0x14
        public 0x664DBA9C _attributesToSkip; // 0x18
        public 0x664DB6D4 _matchType; // 0x1C
        public 0x664DB67C _matchCasing; // 0x20
        public bool _returnSpecialDirectories; // 0x24

        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x7FFE86982400
        public void get_CompatibleRecursive(){} // RVA: 0x7FFE86982460
        public void get_Default(){} // RVA: 0x7FFE869824C0
        public void .ctor(){} // RVA: 0x7FFE86982520
        public void FromSearchOption(){} // RVA: 0x7FFE86982530
        public void get_RecurseSubdirectories(){} // RVA: 0x7FFE811C55E0
        public void set_RecurseSubdirectories(){} // RVA: 0x7FFE811C55F0
        public void get_IgnoreInaccessible(){} // RVA: 0x7FFE81346E30
        public void set_IgnoreInaccessible(){} // RVA: 0x7FFE813471A0
        public void get_BufferSize(){} // RVA: 0x7FFE8164B230
        public void get_AttributesToSkip(){} // RVA: 0x7FFE813DB630
        public void set_AttributesToSkip(){} // RVA: 0x7FFE8144DF00
        public void get_MatchType(){} // RVA: 0x7FFE82707EE0
        public void set_MatchType(){} // RVA: 0x7FFE82717690
        public void get_MatchCasing(){} // RVA: 0x7FFE8151D690
        public void get_ReturnSpecialDirectories(){} // RVA: 0x7FFE811167C0
        public void .cctor(){} // RVA: 0x7FFE86982650
    }

    public class Error : Object
    {
        // ── Methods ──
        public void GetStreamIsClosed(){} // RVA: 0x7FFE86964E70
        public void GetEndOfFile(){} // RVA: 0x7FFE86964EE0
        public void GetReadNotSupported(){} // RVA: 0x7FFE86964F50
        public void GetWriteNotSupported(){} // RVA: 0x7FFE86964FC0
    }

    public class ErrorEventArgs : EventArgs
    {
    }

    public class ErrorEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class File : Object
    {
        // ── Methods ──
        public void OpenText(){} // RVA: 0x7FFE86982820
        public void Copy(){} // RVA: 0x7FFE86982900 | overloaded x2
        public void Create(){} // RVA: 0x7FFE86982C30 | overloaded x3
        public void Delete(){} // RVA: 0x7FFE86982CD0
        public void Exists(){} // RVA: 0x7FFE86982DB0
        public void Open(){} // RVA: 0x7FFE86982F40 | overloaded x2
        public void GetUtcDateTimeOffset(){} // RVA: 0x7FFE86982FE0
        public void GetCreationTime(){} // RVA: 0x7FFE86983110
        public void GetCreationTimeUtc(){} // RVA: 0x7FFE86983240
        public void SetLastAccessTimeUtc(){} // RVA: 0x7FFE869833A0
        public void GetLastWriteTime(){} // RVA: 0x7FFE86983560
        public void GetLastWriteTimeUtc(){} // RVA: 0x7FFE86983690
        public void GetAttributes(){} // RVA: 0x7FFE869837F0
        public void OpenRead(){} // RVA: 0x7FFE869838D0
        public void OpenWrite(){} // RVA: 0x7FFE86983960
        public void ReadAllText(){} // RVA: 0x7FFE869839E0
        public void InternalReadAllText(){} // RVA: 0x7FFE86983AC0
        public void WriteAllText(){} // RVA: 0x7FFE86983D90 | overloaded x2
        public void ReadAllBytes(){} // RVA: 0x7FFE86983FC0
        public void ReadAllBytesUnknownLength(){} // RVA: 0x7FFE86984230
        public void WriteAllBytes(){} // RVA: 0x7FFE86984780
        public void InternalWriteAllBytes(){} // RVA: 0x7FFE869848B0
        public void ReadAllLines(){} // RVA: 0x7FFE86984A00
        public void InternalReadAllLines(){} // RVA: 0x7FFE86984AE0
        public void Move(){} // RVA: 0x7FFE86984CF0
    }

    public class FileData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FileInfo : FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869823E0 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFE86985230
        public void get_DirectoryName(){} // RVA: 0x7FFE869852E0
        public void get_Directory(){} // RVA: 0x7FFE86985340
        public void get_IsReadOnly(){} // RVA: 0x7FFE869853F0
        public void set_IsReadOnly(){} // RVA: 0x7FFE86985410
        public void CreateText(){} // RVA: 0x7FFE86985460
        public void AppendText(){} // RVA: 0x7FFE869854D0
        public void Delete(){} // RVA: 0x7FFE86985540
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
    }

    public class FileLoadException : IOException
    {
        public string _fileName; // 0x90
        public string _fusionLog; // 0x98
        public object field_2; // 0x90C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86965390 | overloaded x3
        public void get_Message(){} // RVA: 0x7FFE869650A0
        public void get_FileName(){} // RVA: 0x7FFE8154EB60
        public void get_FusionLog(){} // RVA: 0x7FFE817AE360
        public void ToString(){} // RVA: 0x7FFE86965180
        public void GetObjectData(){} // RVA: 0x7FFE86965530
        public void FormatFileLoadExceptionMessage(){} // RVA: 0x7FFE86965840
    }

    public class FileNotFoundException : IOException
    {
        public string _fileName; // 0x90
        public string _fusionLog; // 0x98
        public object field_2; // 0x90F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86965DF0 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFE869659A0
        public void SetMessageField(){} // RVA: 0x7FFE86965AC0
        public void get_FileName(){} // RVA: 0x7FFE8154EB60
        public void get_FusionLog(){} // RVA: 0x7FFE817AE360
        public void ToString(){} // RVA: 0x7FFE86965BE0
        public void GetObjectData(){} // RVA: 0x7FFE86965F90
    }

    public class FileStream : Stream
    {
        public int DefaultBufferSize;
        public byte[] buf_recycle;
        public object buf_recycle_lock; // 0x8
        public byte[] buf; // 0x28
        public string name; // 0x30
        public Microsoft.Win32.SafeHandles.SafeFileHandle safeHandle; // 0x38
        public bool isExposed; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8699BF70 | overloaded x12
        public void Init(){} // RVA: 0x7FFE8699C9D0
        public void get_CanRead(){} // RVA: 0x7FFE8699CD40
        public void get_CanWrite(){} // RVA: 0x7FFE8699CD60
        public void get_CanSeek(){} // RVA: 0x7FFE8699CD80
        public void get_Name(){} // RVA: 0x7FFE8144E200
        public void get_Length(){} // RVA: 0x7FFE8699CD90
        public void get_Position(){} // RVA: 0x7FFE8699CF30
        public void set_Position(){} // RVA: 0x7FFE8699D0F0
        public void get_SafeFileHandle(){} // RVA: 0x7FFE8699D190
        public void ExposeHandle(){} // RVA: 0x7FFE8699D1D0
        public void ReadByte(){} // RVA: 0x7FFE8699D200
        public void WriteByte(){} // RVA: 0x7FFE8699D370
        public void Read(){} // RVA: 0x7FFE8699D4D0
        public void ReadInternal(){} // RVA: 0x7FFE8699D880
        public void BeginRead(){} // RVA: 0x7FFE8699D950
        public void EndRead(){} // RVA: 0x7FFE8699DDA0
        public void Write(){} // RVA: 0x7FFE8699DFB0
        public void WriteInternal(){} // RVA: 0x7FFE8699E280
        public void BeginWrite(){} // RVA: 0x7FFE8699E4C0
        public void EndWrite(){} // RVA: 0x7FFE8699E960
        public void Seek(){} // RVA: 0x7FFE8699EB60
        public void SetLength(){} // RVA: 0x7FFE8699EE70
        public void Flush(){} // RVA: 0x7FFE8699F110
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void Dispose(){} // RVA: 0x7FFE8699F190
        public void FlushAsync(){} // RVA: 0x7FFE8699F5A0
        public void ReadAsync(){} // RVA: 0x7FFE8699F620
        public void WriteAsync(){} // RVA: 0x7FFE8699F630
        public void ReadSegment(){} // RVA: 0x7FFE8699F640
        public void WriteSegment(){} // RVA: 0x7FFE8699F750
        public void FlushBuffer(){} // RVA: 0x7FFE8699F7C0
        public void FlushBufferIfDirty(){} // RVA: 0x7FFE8699F9B0
        public void RefillBuffer(){} // RVA: 0x7FFE8699F9C0
        public void ReadData(){} // RVA: 0x7FFE8699FA00
        public void InitBuffer(){} // RVA: 0x7FFE8699FB40
        public void GetSecureFileName(){} // RVA: 0x7FFE8699FFD0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE869A00C0
    }

    public class FileStreamAsyncResult : Object
    {
        public object state; // 0x10
        public bool completed; // 0x18
        public System.Threading.ManualResetEvent wh; // 0x20
        public System.AsyncCallback cb; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869A04E0
        public void CBWrapper(){} // RVA: 0x7FFE869A0710
        public void get_AsyncState(){} // RVA: 0x7FFE81116380
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE81121450
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE811290C0
        public void get_IsCompleted(){} // RVA: 0x7FFE811164E0
    }

    public class FileSystem : Object
    {
        // ── Methods ──
        public void CopyFile(){} // RVA: 0x7FFE86960BA0
        public void CreateDirectory(){} // RVA: 0x7FFE86960ED0
        public void DeleteFile(){} // RVA: 0x7FFE86961490
        public void DirectoryExists(){} // RVA: 0x7FFE86961570 | overloaded x2
        public void FillAttributeInfo(){} // RVA: 0x7FFE869615C0
        public void FileExists(){} // RVA: 0x7FFE869618C0
        public void GetAttributes(){} // RVA: 0x7FFE86961910
        public void GetCreationTime(){} // RVA: 0x7FFE86961980
        public void GetLastWriteTime(){} // RVA: 0x7FFE86961A10
        public void MoveFile(){} // RVA: 0x7FFE86961AA0
        public void OpenHandle(){} // RVA: 0x7FFE86961AF0
        public void RemoveDirectory(){} // RVA: 0x7FFE86961D90
        public void GetFindData(){} // RVA: 0x7FFE86961E70
        public void IsNameSurrogateReparsePoint(){} // RVA: 0x7FFE86961FC0
        public void RemoveDirectoryRecursive(){} // RVA: 0x7FFE86961FE0
        public void RemoveDirectoryInternal(){} // RVA: 0x7FFE869629C0
        public void SetAttributes(){} // RVA: 0x7FFE86962AF0
        public void SetLastAccessTime(){} // RVA: 0x7FFE86962BD0
        public void UnityCreateDirectory(){} // RVA: 0x7FFE86962E10
        public void UnityRemoveDirectory(){} // RVA: 0x7FFE86962FF0
        public void UnityGetFileAttributesEx(){} // RVA: 0x7FFE86963230
        public void UnitySetFileAttributes(){} // RVA: 0x7FFE86963490
        public void UnityCreateFile_IntPtr(){} // RVA: 0x7FFE86963660
        public void UnityCopyFile(){} // RVA: 0x7FFE86963810
        public void UnityDeleteFile(){} // RVA: 0x7FFE86963950
        public void UnityMoveFile(){} // RVA: 0x7FFE86963B90
        public void UnityFindFirstFile(){} // RVA: 0x7FFE86963E00
        public void UnityFindNextFile(){} // RVA: 0x7FFE86964290
        public void BrokeredCreateDirectory(){} // RVA: 0x7FFE869645A0
        public void BrokeredRemoveDirectory(){} // RVA: 0x7FFE869645A0
        public void BrokeredGetFileAttributes(){} // RVA: 0x7FFE86964630
        public void BrokeredSetAttributes(){} // RVA: 0x7FFE86964640
        public void BrokeredOpenFile(){} // RVA: 0x7FFE869646D0
        public void BrokeredCopyFile(){} // RVA: 0x7FFE86964800
        public void BrokeredMoveFile(){} // RVA: 0x7FFE86964930
        public void BrokeredDeleteFile(){} // RVA: 0x7FFE869645A0
        public void BrokeredFindFirstFile(){} // RVA: 0x7FFE86964A50
        public void BrokeredFindNextFile(){} // RVA: 0x7FFE86964BB0
        public void BrokeredSafeFindHandleDispose(){} // RVA: 0x7FFE86964C80
        public void RemoveExtendedPathPrefix(){} // RVA: 0x7FFE86964C90
    }

    public class FileSystemEventArgs : EventArgs
    {
        public 0x66532654 _changeType; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FF2D0
        public void Combine(){} // RVA: 0x7FFE877FF450
        public void get_ChangeType(){} // RVA: 0x7FFE811485C0
        public void get_FullPath(){} // RVA: 0x7FFE811290C0
    }

    public class FileSystemEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class FileSystemInfo : MarshalByRefObject
    {
        public WIN32_FILE_ATTRIBUTE_DATA _data; // 0x18
        public int _dataInitialized; // 0x3C
        public string FullPath; // 0x40
        public string OriginalPath; // 0x48
        public string _name; // 0x50
        public int dwFileAttributes; // 0x10
        public FILE_TIME ftCreationTime; // 0x14
        public FILE_TIME ftLastAccessTime; // 0x1C
        public FILE_TIME ftLastWriteTime; // 0x24
        public uint nFileSizeHigh; // 0x2C
        public uint nFileSizeLow; // 0x30
        public uint dwLowDateTime; // 0x10
        public uint dwHighDateTime; // 0x14
        public object field_13; // 0x945
        public object field_14; // 0x946

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86985B90 | overloaded x2
        public void Create(){} // RVA: 0x7FFE86985550
        public void Invalidate(){} // RVA: 0x7FFE86984FB0
        public void Init(){} // RVA: 0x7FFE86985750
        public void get_Attributes(){} // RVA: 0x7FFE869857A0
        public void set_Attributes(){} // RVA: 0x7FFE869857C0
        public void get_ExistsCore(){} // RVA: 0x7FFE869858A0
        public void get_CreationTimeCore(){} // RVA: 0x7FFE86985930
        public void get_LastAccessTimeCore(){} // RVA: 0x7FFE86985970
        public void get_LastWriteTimeCore(){} // RVA: 0x7FFE869859B0
        public void get_LengthCore(){} // RVA: 0x7FFE869859F0
        public void EnsureDataInitialized(){} // RVA: 0x7FFE86985A20
        public void Refresh(){} // RVA: 0x7FFE86985A90
        public void get_NormalizedPath(){} // RVA: 0x7FFE86985AC0
        public void GetObjectData(){} // RVA: 0x7FFE86985DF0
        public void get_FullName(){} // RVA: 0x7FFE81178740
        public void get_Name(){} // RVA: 0x7FFE8119C0E0
        public void get_Exists(){} // RVA: 0x7FFE86986220
        public void Delete(){} // RVA: 0x7FFE80E45FE0
        public void get_CreationTimeUtc(){} // RVA: 0x7FFE869862B0
        public void get_LastAccessTime(){} // RVA: 0x7FFE86986360
        public void get_LastAccessTimeUtc(){} // RVA: 0x7FFE86986490
        public void get_LastWriteTime(){} // RVA: 0x7FFE86986540
        public void get_LastWriteTimeUtc(){} // RVA: 0x7FFE86986670
        public void ToString(){} // RVA: 0x7FFE86986720
    }

    public class FileSystemWatcher : Component
    {
        public bool inited; // 0x28
        public bool start_requested; // 0x29
        public bool enableRaisingEvents; // 0x2A
        public string filter; // 0x30
        public bool includeSubdirectories; // 0x38
        public int internalBufferSize; // 0x3C
        public 0x6653249C notifyFilter; // 0x40
        public string path; // 0x48
        public string fullpath; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87803040 | overloaded x2
        public void InitWatcher(){} // RVA: 0x7FFE87803330
        public void get_Waiting(){} // RVA: 0x7FFE813A1130
        public void set_Waiting(){} // RVA: 0x7FFE813A2040
        public void get_MangledFilter(){} // RVA: 0x7FFE878038E0
        public void get_Pattern(){} // RVA: 0x7FFE87803980
        public void get_FullPath(){} // RVA: 0x7FFE87803AE0
        public void set_EnableRaisingEvents(){} // RVA: 0x7FFE87803C10
        public void set_Filter(){} // RVA: 0x7FFE87803CC0
        public void get_IncludeSubdirectories(){} // RVA: 0x7FFE812CF770
        public void set_IncludeSubdirectories(){} // RVA: 0x7FFE87803F40
        public void set_NotifyFilter(){} // RVA: 0x7FFE87803F80
        public void get_Site(){} // RVA: 0x7FFE810FE7C0
        public void set_Site(){} // RVA: 0x7FFE87803FC0
        public void BeginInit(){} // RVA: 0x7FFE82BBB9A0
        public void Dispose(){} // RVA: 0x7FFE878040B0
        public void Finalize(){} // RVA: 0x7FFE87804250
        public void EndInit(){} // RVA: 0x7FFE878042D0
        public void RaiseEvent(){} // RVA: 0x7FFE87804380
        public void OnChanged(){} // RVA: 0x7FFE87804710
        public void OnCreated(){} // RVA: 0x7FFE87804740
        public void OnDeleted(){} // RVA: 0x7FFE87804770
        public void OnRenamed(){} // RVA: 0x7FFE878047A0
        public void DispatchEvents(){} // RVA: 0x7FFE878047D0
        public void Start(){} // RVA: 0x7FFE87804D30
        public void Stop(){} // RVA: 0x7FFE87804DA0
        public void add_Changed(){} // RVA: 0x7FFE87804E10
        public void remove_Changed(){} // RVA: 0x7FFE87804F00
        public void add_Created(){} // RVA: 0x7FFE87804FF0
        public void remove_Created(){} // RVA: 0x7FFE878050E0
        public void add_Deleted(){} // RVA: 0x7FFE878051D0
        public void remove_Deleted(){} // RVA: 0x7FFE878052C0
        public void .cctor(){} // RVA: 0x7FFE878053B0
    }

    public class IFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7FFE80E460A0
        public void StopDispatching(){} // RVA: 0x7FFE80E460A0
        public void Dispose(){} // RVA: 0x7FFE80E460A0
    }

    public class IODescriptionAttribute : DescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878056C0
        public void get_Description(){} // RVA: 0x7FFE81116380
    }

    public class IOException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x5
    }

    public class InvalidDataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

    public class MemoryStream : Stream
    {
        public byte[] _buffer; // 0x28
        public int _origin; // 0x30
        public int _position; // 0x34
        public int _length; // 0x38
        public int _capacity; // 0x3C
        public bool _expandable; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869666F0 | overloaded x7
        public void get_CanRead(){} // RVA: 0x7FFE822BB340
        public void get_CanSeek(){} // RVA: 0x7FFE822BB340
        public void get_CanWrite(){} // RVA: 0x7FFE814645D0
        public void EnsureNotClosed(){} // RVA: 0x7FFE86966910
        public void EnsureWriteable(){} // RVA: 0x7FFE86966950
        public void Dispose(){} // RVA: 0x7FFE869669A0
        public void EnsureCapacity(){} // RVA: 0x7FFE86966A20
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void FlushAsync(){} // RVA: 0x7FFE86966AE0
        public void GetBuffer(){} // RVA: 0x7FFE86966C10
        public void InternalGetBuffer(){} // RVA: 0x7FFE81129130
        public void InternalGetPosition(){} // RVA: 0x7FFE82447220
        public void InternalReadInt32(){} // RVA: 0x7FFE86966C80
        public void InternalEmulateRead(){} // RVA: 0x7FFE86966D60
        public void get_Capacity(){} // RVA: 0x7FFE86966DC0
        public void set_Capacity(){} // RVA: 0x7FFE86966E00
        public void get_Length(){} // RVA: 0x7FFE86966FE0
        public void get_Position(){} // RVA: 0x7FFE86967030
        public void set_Position(){} // RVA: 0x7FFE86967080
        public void Read(){} // RVA: 0x7FFE86967410 | overloaded x2
        public void ReadAsync(){} // RVA: 0x7FFE869679F0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFE86967E10
        public void CopyTo(){} // RVA: 0x7FFE86967E90
        public void CopyToAsync(){} // RVA: 0x7FFE86968020
        public void Seek(){} // RVA: 0x7FFE86968340
        public void SetLength(){} // RVA: 0x7FFE869685A0
        public void ToArray(){} // RVA: 0x7FFE86968710
        public void Write(){} // RVA: 0x7FFE86968AC0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFE86969050 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE869693A0
        public void WriteTo(){} // RVA: 0x7FFE869694C0
    }

    public class MonoIO : Object
    {
        public UIntPtr InvalidHandle;
        public bool dump_handles; // 0x8
        public object field_2; // 0x979
        public object field_3; // 0x97A
        public object field_4; // 0x97B
        public object field_5; // 0x97C
        public object field_6; // 0x97D

        // ── Methods ──
        public void GetException(){} // RVA: 0x7FFE869A08E0 | overloaded x2
        public void GetCurrentDirectory(){} // RVA: 0x7FFE869A1150
        public void GetFileType(){} // RVA: 0x7FFE869A11F0 | overloaded x2
        public void FindCloseFile(){} // RVA: 0x7FFE869A1300
        public void Open(){} // RVA: 0x7FFE869A1570 | overloaded x2
        public void Cancel_internal(){} // RVA: 0x7FFE869A16C0
        public void Cancel(){} // RVA: 0x7FFE869A16E0
        public void Close(){} // RVA: 0x7FFE869A1800
        public void Read(){} // RVA: 0x7FFE869A18D0 | overloaded x2
        public void Write(){} // RVA: 0x7FFE869A1AF0 | overloaded x2
        public void Seek(){} // RVA: 0x7FFE869A1CA0 | overloaded x2
        public void GetLength(){} // RVA: 0x7FFE869A1E50 | overloaded x2
        public void SetLength(){} // RVA: 0x7FFE869A2040 | overloaded x2
        public void get_ConsoleOutput(){} // RVA: 0x7FFE869A2210
        public void get_ConsoleInput(){} // RVA: 0x7FFE869A2220
        public void get_ConsoleError(){} // RVA: 0x7FFE869A2230
        public void CreatePipe(){} // RVA: 0x7FFE869A2240
        public void DuplicateHandle(){} // RVA: 0x7FFE869A2340
        public void get_VolumeSeparatorChar(){} // RVA: 0x7FFE869A2430
        public void get_DirectorySeparatorChar(){} // RVA: 0x7FFE835C5E60
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x7FFE869A2440
        public void get_PathSeparator(){} // RVA: 0x7FFE869A2450
        public void DumpHandles(){} // RVA: 0x7FFE868DCC30
        public void RemapPath(){} // RVA: 0x7FFE869A2460
        public void .cctor(){} // RVA: 0x7FFE869A2470
    }

    public class MonoIOStat : ValueType
    {
    }

    public class MonoLinqHelper : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFE80E2E3D0
    }

    public class NullFileWatcher : Object
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7FFE810FB310
        public void StopDispatching(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void GetInstance(){} // RVA: 0x7FFE878057F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Path : Object
    {
        public char[] InvalidPathChars;
        public char AltDirectorySeparatorChar; // 0x8
        public char DirectorySeparatorChar; // 0xA

        // ── Methods ──
        public void ChangeExtension(){} // RVA: 0x7FFE869A24F0
        public void Combine(){} // RVA: 0x7FFE869A6C10 | overloaded x4
        public void CleanPath(){} // RVA: 0x7FFE869A2A80
        public void GetDirectoryName(){} // RVA: 0x7FFE869A33F0 | overloaded x2
        public void GetExtension(){} // RVA: 0x7FFE869A34D0
        public void GetFileName(){} // RVA: 0x7FFE869A6E50 | overloaded x2
        public void GetFileNameWithoutExtension(){} // RVA: 0x7FFE869A3750
        public void GetFullPath(){} // RVA: 0x7FFE869A37B0
        public void GetFullPathInternal(){} // RVA: 0x7FFE869A3800
        public void GetFullPathName(){} // RVA: 0x7FFE869A3940 | overloaded x2
        public void WindowsDriveAdjustment(){} // RVA: 0x7FFE869A3BF0
        public void InsecureGetFullPath(){} // RVA: 0x7FFE869A3E30
        public void IsDirectorySeparator(){} // RVA: 0x7FFE869A4460
        public void GetPathRoot(){} // RVA: 0x7FFE869A44F0
        public void GetTempPath(){} // RVA: 0x7FFE869A4990
        public void get_temp_path(){} // RVA: 0x7FFE869A4C00
        public void IsPathRooted(){} // RVA: 0x7FFE869A4E80 | overloaded x2
        public void GetInvalidFileNameChars(){} // RVA: 0x7FFE869A50C0
        public void GetInvalidPathChars(){} // RVA: 0x7FFE869A5130
        public void GetRandomFileName(){} // RVA: 0x7FFE869A51A0
        public void findExtension(){} // RVA: 0x7FFE869A5340
        public void .cctor(){} // RVA: 0x7FFE869A53F0
        public void GetServerAndShare(){} // RVA: 0x7FFE869A58B0
        public void SameRoot(){} // RVA: 0x7FFE869A5B10
        public void CanonicalizePath(){} // RVA: 0x7FFE869A5E70
        public void Join(){} // RVA: 0x7FFE869A70C0 | overloaded x2
        public void JoinInternal(){} // RVA: 0x7FFE869A7930 | overloaded x2
        public void GetRelativePath(){} // RVA: 0x7FFE869A8010 | overloaded x2
        public void get_StringComparison(){} // RVA: 0x7FFE869A8760
        public void get_IsCaseSensitive(){} // RVA: 0x7FFE869A8810
        public void get_IsWindows(){} // RVA: 0x7FFE869A8880
    }

    public class PathInternal : Object
    {
        public bool s_isCaseSensitive;

        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x7FFE86969590
        public void EndsWithPeriodOrSpace(){} // RVA: 0x7FFE869695B0
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x7FFE86969600
        public void EnsureExtendedPrefix(){} // RVA: 0x7FFE869696B0
        public void IsDevice(){} // RVA: 0x7FFE86969900
        public void IsDeviceUNC(){} // RVA: 0x7FFE86969AD0
        public void IsExtended(){} // RVA: 0x7FFE86969BC0
        public void GetRootLength(){} // RVA: 0x7FFE86969C50
        public void IsDirectorySeparator(){} // RVA: 0x7FFE8696A040
        public void IsEffectivelyEmpty(){} // RVA: 0x7FFE8696A060
        public void EndsInDirectorySeparator(){} // RVA: 0x7FFE8696A0E0
        public void StartsWithDirectorySeparator(){} // RVA: 0x7FFE8696A180
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7FFE8696A430 | overloaded x2
        public void IsRoot(){} // RVA: 0x7FFE8696A610
        public void GetCommonPathLength(){} // RVA: 0x7FFE8696A680
        public void EqualStartingCharacterCount(){} // RVA: 0x7FFE8696A8C0
        public void AreRootsEqual(){} // RVA: 0x7FFE8696A9E0
        public void get_IsCaseSensitive(){} // RVA: 0x7FFE8696AB40
        public void GetIsCaseSensitive(){} // RVA: 0x7FFE8696ABA0
        public void IsPartiallyQualified(){} // RVA: 0x7FFE810FB320
        public void .cctor(){} // RVA: 0x7FFE8696ADC0
    }

    public class PathTooLongException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class PinnedBufferMemoryStream : UnmanagedMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8696AE80
        public void Read(){} // RVA: 0x7FFE8696AFD0
        public void Write(){} // RVA: 0x7FFE8696AFF0
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void Dispose(){} // RVA: 0x7FFE8696B010
    }

    public class RenamedEventArgs : FileSystemEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FF880
    }

    public class RenamedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class SearchPattern2 : Object
    {
        public Op ops; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878059D0 | overloaded x2
        public void get_HasWildcard(){} // RVA: 0x7FFE814B3730
        public void Compile(){} // RVA: 0x7FFE87805A30
        public void .cctor(){} // RVA: 0x7FFE87805E60
    }

    public class Stream : MarshalByRefObject
    {
        public System.IO.Stream Null;
        public int DefaultCopyBufferSize;
        public ReadWriteTask _activeReadWriteTask; // 0x18
        public System.Threading.SemaphoreSlim _asyncActiveSemaphore; // 0x20
        public object field_4; // 0x959
        public object field_5; // 0x95A
        public object field_6; // 0x95B
        public object field_7; // 0x95C

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFE8698F4E0
        public void get_CanRead(){} // RVA: 0x7FFE80E2F150
        public void get_CanSeek(){} // RVA: 0x7FFE80E2F150
        public void get_CanTimeout(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE80E2F150
        public void get_Length(){} // RVA: 0x7FFE80E2E2E0
        public void get_Position(){} // RVA: 0x7FFE80E2E2E0
        public void set_Position(){} // RVA: 0x7FFE80E46250
        public void get_ReadTimeout(){} // RVA: 0x7FFE8698F640
        public void set_ReadTimeout(){} // RVA: 0x7FFE8698F690
        public void get_WriteTimeout(){} // RVA: 0x7FFE8698F6E0
        public void set_WriteTimeout(){} // RVA: 0x7FFE8698F730
        public void CopyToAsync(){} // RVA: 0x7FFE8698F8A0 | overloaded x3
        public void CopyToAsyncInternal(){} // RVA: 0x7FFE8698F900
        public void CopyTo(){} // RVA: 0x7FFE8698FBD0 | overloaded x2
        public void GetCopyBufferSize(){} // RVA: 0x7FFE8698FDA0
        public void Close(){} // RVA: 0x7FFE8698FEA0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFE80E45FE0
        public void FlushAsync(){} // RVA: 0x7FFE8698FF70 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFE869901D0
        public void BeginReadInternal(){} // RVA: 0x7FFE86990210
        public void EndRead(){} // RVA: 0x7FFE869904A0
        public void ReadAsync(){} // RVA: 0x7FFE86990870 | overloaded x3
        public void BeginEndReadAsync(){} // RVA: 0x7FFE86990B40
        public void BeginWrite(){} // RVA: 0x7FFE86990EA0
        public void BeginWriteInternal(){} // RVA: 0x7FFE86990EE0
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7FFE86991170
        public void RunReadWriteTask(){} // RVA: 0x7FFE869913C0
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFE86991520
        public void EndWrite(){} // RVA: 0x7FFE869915A0
        public void WriteAsync(){} // RVA: 0x7FFE86991970 | overloaded x3
        public void FinishWriteAsync(){} // RVA: 0x7FFE86991D60
        public void BeginEndWriteAsync(){} // RVA: 0x7FFE86991F70
        public void Seek(){}
        public void SetLength(){} // RVA: 0x7FFE80E46250
        public void Read(){} // RVA: 0x7FFE869922D0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFE86992570
        public void Write(){} // RVA: 0x7FFE86992620 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE869927C0
        public void BlockingBeginRead(){} // RVA: 0x7FFE86992850
        public void BlockingEndRead(){} // RVA: 0x7FFE86992990
        public void BlockingBeginWrite(){} // RVA: 0x7FFE86992AB0
        public void BlockingEndWrite(){} // RVA: 0x7FFE86992BF0
        public void HasOverriddenBeginEndRead(){} // RVA: 0x7FFE811E0850
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x7FFE811E0850
        public void DisposeAsync(){} // RVA: 0x7FFE86992D10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86992DC0
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x7FFE86992EB0
    }

    public class StreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateCopyToArgs(){} // RVA: 0x7FFE8696B0A0
    }

    public class StreamReader : TextReader
    {
        public System.IO.StreamReader Null;
        public System.IO.Stream _stream; // 0x18
        public System.Text.Encoding _encoding; // 0x20
        public System.Text.Decoder _decoder; // 0x28

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFE8696B370
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFE8696B410
        public void .ctor(){} // RVA: 0x7FFE8696BA10 | overloaded x11
        public void Init(){} // RVA: 0x7FFE8696BFF0 | overloaded x2
        public void Close(){} // RVA: 0x7FFE867F19F0
        public void Dispose(){} // RVA: 0x7FFE8696C050
        public void get_CurrentEncoding(){} // RVA: 0x7FFE811290C0
        public void get_BaseStream(){} // RVA: 0x7FFE810FE7C0
        public void get_LeaveOpen(){} // RVA: 0x7FFE8696C2F0
        public void get_EndOfStream(){} // RVA: 0x7FFE8696C300
        public void Peek(){} // RVA: 0x7FFE8696C3A0
        public void Read(){} // RVA: 0x7FFE8696C700 | overloaded x3
        public void ReadSpan(){} // RVA: 0x7FFE8696C810
        public void ReadToEnd(){} // RVA: 0x7FFE8696CAC0
        public void CompressBuffer(){} // RVA: 0x7FFE8696CC00
        public void DetectEncoding(){} // RVA: 0x7FFE8696CC40
        public void IsPreamble(){} // RVA: 0x7FFE8696D1E0
        public void ReadBuffer(){} // RVA: 0x7FFE8696DA80 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFE8696E430
        public void ReadToEndAsync(){} // RVA: 0x7FFE8696E690
        public void ReadToEndAsyncInternal(){} // RVA: 0x7FFE8696EB10
        public void ReadAsync(){} // RVA: 0x7FFE8696ECB0
        public void ReadAsyncInternal(){} // RVA: 0x7FFE8696EFE0
        public void ReadBufferAsync(){} // RVA: 0x7FFE8696F280
        public void DataAvailable(){} // RVA: 0x7FFE8696F430
        public void .cctor(){} // RVA: 0x7FFE8696F440
    }

    public class StreamWriter : TextWriter
    {
        public System.IO.StreamWriter Null;
        public System.IO.Stream _stream; // 0x30
        public System.Text.Encoding _encoding; // 0x38
        public System.Text.Encoder _encoder; // 0x40
        public byte[] _byteBuffer; // 0x48
        public char[] _charBuffer; // 0x50
        public int _charPos; // 0x58

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFE869725B0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFE86972650
        public void get_UTF8NoBOM(){} // RVA: 0x7FFE869726A0
        public void .ctor(){} // RVA: 0x7FFE86972D20 | overloaded x9
        public void Init(){} // RVA: 0x7FFE86973030
        public void Close(){} // RVA: 0x7FFE86973300
        public void Dispose(){} // RVA: 0x7FFE86973370
        public void DisposeAsync(){} // RVA: 0x7FFE869736A0
        public void DisposeAsyncCore(){} // RVA: 0x7FFE86973920
        public void CloseStreamFromDispose(){} // RVA: 0x7FFE86973AC0
        public void Flush(){} // RVA: 0x7FFE86973B90 | overloaded x2
        public void set_AutoFlush(){} // RVA: 0x7FFE86973D80
        public void get_BaseStream(){} // RVA: 0x7FFE8144E200
        public void get_LeaveOpen(){} // RVA: 0x7FFE86973DC0
        public void get_Encoding(){} // RVA: 0x7FFE8143BA80
        public void Write(){} // RVA: 0x7FFE869743E0 | overloaded x4
        public void WriteSpan(){} // RVA: 0x7FFE86974160
        public void WriteLine(){} // RVA: 0x7FFE86974460
        public void WriteAsync(){} // RVA: 0x7FFE86974ED0 | overloaded x3
        public void WriteAsyncInternal(){} // RVA: 0x7FFE86975270 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFE869755C0
        public void FlushAsync(){} // RVA: 0x7FFE86975960
        public void set_CharPos_Prop(){} // RVA: 0x7FFE8175AE70
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x7FFE81EB6360
        public void FlushAsyncInternal(){} // RVA: 0x7FFE86975D10 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86976100
    }

    public class StringReader : TextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8699A640
        public void Close(){} // RVA: 0x7FFE867F19F0
        public void Dispose(){} // RVA: 0x7FFE8699A730
        public void Peek(){} // RVA: 0x7FFE8699A790
        public void Read(){} // RVA: 0x7FFE8699A840 | overloaded x2
        public void ReadToEnd(){} // RVA: 0x7FFE8699AA50
        public void ReadLine(){} // RVA: 0x7FFE8699AAB0
        public void ReadToEndAsync(){} // RVA: 0x7FFE8699ABE0
        public void ReadAsync(){} // RVA: 0x7FFE8699AC60
    }

    public class StringWriter : TextWriter
    {
        public System.Text.UnicodeEncoding m_encoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8699B060 | overloaded x4
        public void Close(){} // RVA: 0x7FFE8699B180
        public void Dispose(){} // RVA: 0x7FFE811097C0
        public void get_Encoding(){} // RVA: 0x7FFE8699B1A0
        public void GetStringBuilder(){} // RVA: 0x7FFE8144E200
        public void Write(){} // RVA: 0x7FFE8699B4D0 | overloaded x3
        public void WriteAsync(){} // RVA: 0x7FFE8699B690 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFE8699B780
        public void FlushAsync(){} // RVA: 0x7FFE8699B870
        public void ToString(){} // RVA: 0x7FFE8699B910
    }

    public class TextReader : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Close(){} // RVA: 0x7FFE86978200
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Peek(){} // RVA: 0x7FFE81517DA0
        public void Read(){} // RVA: 0x7FFE869784F0 | overloaded x3
        public void ReadToEnd(){} // RVA: 0x7FFE86978790
        public void ReadLine(){} // RVA: 0x7FFE869788D0
        public void ReadToEndAsync(){} // RVA: 0x7FFE86978A50
        public void ReadAsync(){} // RVA: 0x7FFE86978C00
        public void ReadAsyncInternal(){} // RVA: 0x7FFE86978E30
        public void Synchronized(){} // RVA: 0x7FFE86979280
        public void .cctor(){} // RVA: 0x7FFE869793C0
    }

    public class TextWriter : MarshalByRefObject
    {
        public System.IO.TextWriter Null;
        public char[] s_coreNewLine; // 0x8
        public char[] CoreNewLine; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8697A500 | overloaded x2
        public void get_FormatProvider(){} // RVA: 0x7FFE8697A680
        public void Close(){} // RVA: 0x7FFE8697A720
        public void Dispose(){} // RVA: 0x7FFE8697A790 | overloaded x2
        public void DisposeAsync(){} // RVA: 0x7FFE8697A800
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void get_Encoding(){} // RVA: 0x7FFE80E2E2E0
        public void get_NewLine(){} // RVA: 0x7FFE811290C0
        public void Write(){} // RVA: 0x7FFE8697AC80 | overloaded x8
        public void WriteLine(){} // RVA: 0x7FFE8697AEB0 | overloaded x5
        public void WriteAsync(){} // RVA: 0x7FFE8697B540 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFE8697B810
        public void FlushAsync(){} // RVA: 0x7FFE8697BAE0
        public void Synchronized(){} // RVA: 0x7FFE8697BD70
        public void .cctor(){} // RVA: 0x7FFE8697BED0
    }

    public class UnexceptionalStreamReader : StreamReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE869A8EE0
        public void .ctor(){} // RVA: 0x7FFE869A8FD0
        public void Peek(){} // RVA: 0x7FFE869A9060
        public void Read(){} // RVA: 0x7FFE869A90A0 | overloaded x2
        public void CheckEOL(){} // RVA: 0x7FFE869A9310
        public void ReadLine(){} // RVA: 0x7FFE869A94F0
        public void ReadToEnd(){} // RVA: 0x7FFE869A9510
    }

    public class UnexceptionalStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869A9660
        public void Flush(){} // RVA: 0x7FFE869A96E0
        public void Write(){} // RVA: 0x7FFE869A9770 | overloaded x4
    }

    public class UnmanagedMemoryAccessor : Object
    {
        public System.Runtime.InteropServices.SafeBuffer _buffer; // 0x10
        public long _offset; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE825F1740
        public void Initialize(){} // RVA: 0x7FFE8697CD60
        public void get_Capacity(){} // RVA: 0x7FFE811290C0
        public void Dispose(){} // RVA: 0x7FFE8697D1A0 | overloaded x2
        public void get_IsOpen(){} // RVA: 0x7FFE811DA230
    }

    public class UnmanagedMemoryStream : Stream
    {
        public System.Runtime.InteropServices.SafeBuffer _buffer; // 0x28
        public byte* _mem; // 0x30
        public long _length; // 0x38
        public long _capacity; // 0x40
        public long _position; // 0x48
        public long _offset; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8697D2F0 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFE8697D380
        public void get_CanRead(){} // RVA: 0x7FFE8697D610
        public void get_CanSeek(){} // RVA: 0x7FFE81199240
        public void get_CanWrite(){} // RVA: 0x7FFE8697D630
        public void Dispose(){} // RVA: 0x7FFE8697D650
        public void EnsureNotClosed(){} // RVA: 0x7FFE8697D660
        public void EnsureReadable(){} // RVA: 0x7FFE8697D6A0
        public void EnsureWriteable(){} // RVA: 0x7FFE8697D6F0
        public void Flush(){} // RVA: 0x7FFE8697D660
        public void FlushAsync(){} // RVA: 0x7FFE8697D740
        public void get_Length(){} // RVA: 0x7FFE8697D870
        public void get_Position(){} // RVA: 0x7FFE8697D8C0
        public void set_Position(){} // RVA: 0x7FFE8697D910
        public void get_PositionPointer(){} // RVA: 0x7FFE8697D9D0
        public void Read(){} // RVA: 0x7FFE8697DCF0 | overloaded x2
        public void ReadCore(){} // RVA: 0x7FFE8697DE00
        public void ReadAsync(){} // RVA: 0x7FFE8697E3E0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFE8697E790
        public void Seek(){} // RVA: 0x7FFE8697E910
        public void SetLength(){} // RVA: 0x7FFE8697EAE0
        public void Write(){} // RVA: 0x7FFE8697EF20 | overloaded x2
        public void WriteCore(){} // RVA: 0x7FFE8697F030
        public void WriteAsync(){} // RVA: 0x7FFE8697F660 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFE8697F950
    }

    public class WaitForChangedResult : ValueType
    {
        public System.IO.WaitForChangedResult TimedOutResult;
        public 0x66532654 _changeType; // 0x10
        public string _name; // 0x18
        public string _oldName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FF970
        public void set_ChangeType(){} // RVA: 0x7FFE815BF990
        public void set_Name(){} // RVA: 0x7FFE826F4230
        public void set_OldName(){} // RVA: 0x7FFE810FCE30
        public void set_TimedOut(){} // RVA: 0x7FFE811164F0
        public void .cctor(){} // RVA: 0x7FFE877FFA90
    }

    public class Win32Marshal : Object
    {
        // ── Methods ──
        public void GetExceptionForLastWin32Error(){} // RVA: 0x7FFE8697FE90
        public void GetExceptionForWin32Error(){} // RVA: 0x7FFE8697FEF0
        public void MakeHRFromErrorCode(){} // RVA: 0x7FFE86980430
        public void TryMakeWin32ErrorCodeFromHR(){} // RVA: 0x7FFE86980450
        public void GetMessage(){} // RVA: 0x7FFE86732950
    }

    public class __Error : Object
    {
        // ── Methods ──
        public void EndOfFile(){} // RVA: 0x7FFE86996380
        public void FileNotOpen(){} // RVA: 0x7FFE869963E0
        public void ReaderClosed(){} // RVA: 0x7FFE86996450
        public void GetDisplayablePath(){} // RVA: 0x7FFE869964C0
        public void WinIOError(){} // RVA: 0x7FFE86996620
        public void WriterClosed(){} // RVA: 0x7FFE86996E40
    }

}