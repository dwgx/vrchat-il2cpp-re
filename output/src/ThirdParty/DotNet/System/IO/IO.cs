// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 62
// Methods: 898

namespace ThirdParty.DotNet.System.IO
{
    public class BinaryReader
    {
        public System.IO.Stream m_stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E56130 | overloaded x3
        public void get_BaseStream(){} // RVA: 0x2F8380
        public void Close(){} // RVA: 0x1D1E0E0
        public void Dispose(){} // RVA: 0x1D1E0E0 | overloaded x2
        public void Read(){} // RVA: 0x5E57B10 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x5E566B0
        public void ReadByte(){} // RVA: 0x5E56700
        public void ReadSByte(){} // RVA: 0x5E56740
        public void ReadChar(){} // RVA: 0x5E56790
        public void ReadInt16(){} // RVA: 0x5E567C0
        public void ReadUInt16(){} // RVA: 0x5E567C0
        public void ReadInt32(){} // RVA: 0x5E56820
        public void ReadUInt32(){} // RVA: 0x5E56A00
        public void ReadInt64(){} // RVA: 0x5E56A80
        public void ReadUInt64(){} // RVA: 0x5E56A80
        public void ReadSingle(){} // RVA: 0x5E56B70
        public void ReadDouble(){} // RVA: 0x5E56BF0
        public void ReadDecimal(){} // RVA: 0x5E56C70
        public void ReadString(){} // RVA: 0x5E56EE0
        public void InternalReadChars(){} // RVA: 0x5E571E0
        public void InternalReadOneChar(){} // RVA: 0x5E575F0
        public void ReadChars(){} // RVA: 0x5E57930
        public void ReadBytes(){} // RVA: 0x5E57D00
        public void FillBuffer(){} // RVA: 0x5E57F00
        public void Read7BitEncodedInt(){} // RVA: 0x5E58070
    }

    public class BinaryWriter
    {
        public System.IO.BinaryWriter Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E58450 | overloaded x4
        public void Close(){} // RVA: 0x1D1E0E0
        public void Dispose(){} // RVA: 0x1D1E0E0 | overloaded x2
        public void get_BaseStream(){} // RVA: 0x5E58690
        public void Flush(){} // RVA: 0x5DFC2A0
        public void DisposeAsync(){} // RVA: 0x5E586C0
        public void Write(){} // RVA: 0x5E59310 | overloaded x16
        public void Write7BitEncodedInt(){} // RVA: 0x5E596E0
        public void .cctor(){} // RVA: 0x5E59750
    }

    public class BufferedStream
    {
        public System.IO.Stream _stream; // 0x28
        public byte[] _buffer; // 0x30
        public int _bufferSize; // 0x38
        public int _readPos; // 0x3C
        public int _readLen; // 0x40

        // ── Methods ──
        public void LazyEnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x5E45930
        public void .ctor(){} // RVA: 0x5E45AA0 | overloaded x2
        public void EnsureNotClosed(){} // RVA: 0x5E45CF0
        public void EnsureCanSeek(){} // RVA: 0x5E45D60
        public void EnsureCanRead(){} // RVA: 0x5E45DF0
        public void EnsureCanWrite(){} // RVA: 0x5E45E80
        public void EnsureShadowBufferAllocated(){} // RVA: 0x5E45F10
        public void EnsureBufferAllocated(){} // RVA: 0x5E46040
        public void get_CanRead(){} // RVA: 0x5E460E0
        public void get_CanWrite(){} // RVA: 0x5E46110
        public void get_CanSeek(){} // RVA: 0x5E46140
        public void get_Length(){} // RVA: 0x5E46170
        public void get_Position(){} // RVA: 0x5E46200
        public void set_Position(){} // RVA: 0x5E462A0
        public void DisposeAsync(){} // RVA: 0x5E46370
        public void Dispose(){} // RVA: 0x5E46520
        public void Flush(){} // RVA: 0x5E466F0
        public void FlushAsync(){} // RVA: 0x5E46830
        public void FlushAsyncInternal(){} // RVA: 0x5E46900
        public void FlushRead(){} // RVA: 0x5E46B20
        public void ClearReadBufferBeforeWrite(){} // RVA: 0x5E46B70
        public void FlushWrite(){} // RVA: 0x5E46C40
        public void FlushWriteAsync(){} // RVA: 0x5E46CB0
        public void ReadFromBuffer(){} // RVA: 0x5E470C0 | overloaded x3
        public void Read(){} // RVA: 0x5E47460 | overloaded x2
        public void LastSyncCompletedReadTask(){} // RVA: 0x5E47680
        public void ReadAsync(){} // RVA: 0x5E47EA0 | overloaded x2
        public void ReadFromUnderlyingStreamAsync(){} // RVA: 0x5E48350
        public void BeginRead(){} // RVA: 0x5E48650
        public void EndRead(){} // RVA: 0x5E48700
        public void ReadByte(){} // RVA: 0x5E48740
        public void ReadByteSlow(){} // RVA: 0x5E48870
        public void WriteToBuffer(){} // RVA: 0x5E48A40 | overloaded x2
        public void Write(){} // RVA: 0x5E48FE0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x5E49650 | overloaded x2
        public void WriteToUnderlyingStreamAsync(){} // RVA: 0x5E499F0
        public void BeginWrite(){} // RVA: 0x5E49CB0
        public void EndWrite(){} // RVA: 0x5C6ED10
        public void WriteByte(){} // RVA: 0x5E49D60
        public void Seek(){} // RVA: 0x5E49E30
        public void SetLength(){} // RVA: 0x5E49FB0
        public void CopyTo(){} // RVA: 0x5E4A090
        public void CopyToAsync(){} // RVA: 0x5E4A140
        public void CopyToAsyncCore(){} // RVA: 0x5E4A230
    }

    public class CStreamReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E68950
        public void Peek(){} // RVA: 0x5E68220
        public void Read(){} // RVA: 0x5E68CA0 | overloaded x2
        public void ReadLine(){} // RVA: 0x5E68E50
        public void ReadToEnd(){} // RVA: 0x5E68E80
    }

    public class CStreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E68EB0
        public void Write(){} // RVA: 0x5E69670 | overloaded x4
        public void InternalWriteString(){} // RVA: 0x5E695D0
        public void InternalWriteChar(){} // RVA: 0x5E695F0
        public void InternalWriteChars(){} // RVA: 0x5E69610
        public void WriteLine(){} // RVA: 0x5E696E0
    }

    public class DefaultWatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void GetInstance(){} // RVA: 0x6CBED50
        public void StartDispatching(){} // RVA: 0x6CBEF20
        public void StopDispatching(){} // RVA: 0x6CBFC50
        public void Dispose(){} // RVA: 0x2DD310
        public void Monitor(){} // RVA: 0x6CC0240
        public void UpdateDataAndDispatch(){} // RVA: 0x6CC0C70
        public void DispatchEvents(){} // RVA: 0x6CC0DB0
        public void DoFiles(){} // RVA: 0x6CC0F50
        public void IterateAndModifyFilesData(){} // RVA: 0x6CC1330
        public void CreateFileData(){} // RVA: 0x6CC1F70
        public void .cctor(){} // RVA: 0x6CC2090
    }

    public class DefaultWatcherData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CBECC0
    }

    public class Directory
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x5E3F680
        public void Exists(){} // RVA: 0x5E3F820
        public void GetFiles(){} // RVA: 0x5E3FA70 | overloaded x3
        public void GetDirectories(){} // RVA: 0x5E3FC20 | overloaded x2
        public void GetFileSystemEntries(){} // RVA: 0x5E3FDC0 | overloaded x2
        public void InternalEnumeratePaths(){} // RVA: 0x5E3FE50
        public void EnumerateFiles(){} // RVA: 0x5E402A0 | overloaded x4
        public void GetDirectoryRoot(){} // RVA: 0x5E402C0
        public void InternalGetDirectoryRoot(){} // RVA: 0x5E40440
        public void GetCurrentDirectory(){} // RVA: 0x5E40500
        public void Delete(){} // RVA: 0x5E40510
        public void InsecureGetCurrentDirectory(){} // RVA: 0x5E405B0
    }

    public class DirectoryInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E415A0 | overloaded x3
        public void Init(){} // RVA: 0x5E407B0
        public void get_Parent(){} // RVA: 0x5E40D30
        public void Create(){} // RVA: 0x5E40F00
        public void GetFiles(){} // RVA: 0x5E41090 | overloaded x3
        public void EnumerateFiles(){} // RVA: 0x5E412A0 | overloaded x3
        public void InternalEnumerateInfos(){} // RVA: 0x5E41340
        public void Delete(){} // RVA: 0x5E41540
    }

    public class DirectoryNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class DisableMediaInsertionPrompt
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x5E1FC40
        public void Dispose(){} // RVA: 0x5E1FCC0
    }

    public class DriveNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class EndOfStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class EnumerationOptions
    {
        public System.IO.EnumerationOptions <Compatible>k__BackingField;
        public System.IO.EnumerationOptions <CompatibleRecursive>k__BackingField; // 0x8
        public System.IO.EnumerationOptions <Default>k__BackingField; // 0x10
        public bool <RecurseSubdirectories>k__BackingField; // 0x10
        public bool <IgnoreInaccessible>k__BackingField; // 0x11
        public int <BufferSize>k__BackingField; // 0x14
        public 0x657FDAF8 <AttributesToSkip>k__BackingField; // 0x18
        public 0x657FD730 <MatchType>k__BackingField; // 0x1C
        public 0x657FD6D8 <MatchCasing>k__BackingField; // 0x20
        public bool <ReturnSpecialDirectories>k__BackingField; // 0x24

        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x5E415C0
        public void get_CompatibleRecursive(){} // RVA: 0x5E41620
        public void get_Default(){} // RVA: 0x5E41680
        public void .ctor(){} // RVA: 0x5E416E0
        public void FromSearchOption(){} // RVA: 0x5E416F0
        public void get_RecurseSubdirectories(){} // RVA: 0x3A75E0
        public void set_RecurseSubdirectories(){} // RVA: 0x3A75F0
        public void get_IgnoreInaccessible(){} // RVA: 0x543460
        public void set_IgnoreInaccessible(){} // RVA: 0x543470
        public void get_BufferSize(){} // RVA: 0x8ABED0
        public void get_AttributesToSkip(){} // RVA: 0x5BED50
        public void set_AttributesToSkip(){} // RVA: 0x6374E0
        public void get_MatchType(){} // RVA: 0x197C3B0
        public void set_MatchType(){} // RVA: 0x1989FD0
        public void get_MatchCasing(){} // RVA: 0x760030
        public void get_ReturnSpecialDirectories(){} // RVA: 0x2F87C0
        public void .cctor(){} // RVA: 0x5E41810
    }

    public class Error
    {
        // ── Methods ──
        public void GetStreamIsClosed(){} // RVA: 0x5E24030
        public void GetEndOfFile(){} // RVA: 0x5E240A0
        public void GetReadNotSupported(){} // RVA: 0x5E24110
        public void GetWriteNotSupported(){} // RVA: 0x5E24180
    }

    public class Error
    {
        // ── Methods ──
        public void GetEndOfFile(){} // RVA: 0x6675890
        public void GetPipeNotOpen(){} // RVA: 0x6675900
        public void GetReadNotSupported(){} // RVA: 0x6675970
        public void GetSeekNotSupported(){} // RVA: 0x66759E0
        public void GetWriteNotSupported(){} // RVA: 0x6675A50
        public void GetOperationAborted(){} // RVA: 0x6675AC0
    }

    public class ErrorEventArgs
    {
    }

    public class ErrorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class File
    {
        // ── Methods ──
        public void OpenText(){} // RVA: 0x5E419E0
        public void Copy(){} // RVA: 0x5E41AC0 | overloaded x2
        public void Create(){} // RVA: 0x5E41DF0 | overloaded x3
        public void Delete(){} // RVA: 0x5E41E90
        public void Exists(){} // RVA: 0x5E41F70
        public void Open(){} // RVA: 0x5E42100 | overloaded x2
        public void GetUtcDateTimeOffset(){} // RVA: 0x5E421A0
        public void GetCreationTime(){} // RVA: 0x5E422D0
        public void GetCreationTimeUtc(){} // RVA: 0x5E42400
        public void SetLastAccessTimeUtc(){} // RVA: 0x5E42560
        public void GetLastWriteTime(){} // RVA: 0x5E42720
        public void GetLastWriteTimeUtc(){} // RVA: 0x5E42850
        public void GetAttributes(){} // RVA: 0x5E429B0
        public void OpenRead(){} // RVA: 0x5E42A90
        public void OpenWrite(){} // RVA: 0x5E42B20
        public void ReadAllText(){} // RVA: 0x5E42BA0
        public void InternalReadAllText(){} // RVA: 0x5E42C80
        public void WriteAllText(){} // RVA: 0x5E42F50 | overloaded x2
        public void ReadAllBytes(){} // RVA: 0x5E43180
        public void ReadAllBytesUnknownLength(){} // RVA: 0x5E433F0
        public void WriteAllBytes(){} // RVA: 0x5E43940
        public void InternalWriteAllBytes(){} // RVA: 0x5E43A70
        public void ReadAllLines(){} // RVA: 0x5E43BC0
        public void InternalReadAllLines(){} // RVA: 0x5E43CA0
        public void Move(){} // RVA: 0x5E43EB0
    }

    public class FileData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FileInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E415A0 | overloaded x4
        public void get_Length(){} // RVA: 0x5E443F0
        public void get_DirectoryName(){} // RVA: 0x5E444A0
        public void get_Directory(){} // RVA: 0x5E44500
        public void get_IsReadOnly(){} // RVA: 0x5E445B0
        public void set_IsReadOnly(){} // RVA: 0x5E445D0
        public void CreateText(){} // RVA: 0x5E44620
        public void AppendText(){} // RVA: 0x5E44690
        public void Delete(){} // RVA: 0x5E44700
        public void get_Name(){} // RVA: 0x37E0E0
    }

    public class FileLoadException
    {
        public string <FileName>k__BackingField; // 0x90
        public string <FusionLog>k__BackingField; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E24550 | overloaded x3
        public void get_Message(){} // RVA: 0x5E24260
        public void get_FileName(){} // RVA: 0x796DE0
        public void get_FusionLog(){} // RVA: 0xA1C8C0
        public void ToString(){} // RVA: 0x5E24340
        public void GetObjectData(){} // RVA: 0x5E246F0
        public void FormatFileLoadExceptionMessage(){} // RVA: 0x5E24A00
    }

    public class FileNotFoundException
    {
        public string <FileName>k__BackingField; // 0x90
        public string <FusionLog>k__BackingField; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E24FB0 | overloaded x4
        public void get_Message(){} // RVA: 0x5E24B60
        public void SetMessageField(){} // RVA: 0x5E24C80
        public void get_FileName(){} // RVA: 0x796DE0
        public void get_FusionLog(){} // RVA: 0xA1C8C0
        public void ToString(){} // RVA: 0x5E24DA0
        public void GetObjectData(){} // RVA: 0x5E25150
    }

    public class FileStream
    {
        public int DefaultBufferSize;
        public byte[] buf_recycle;
        public object buf_recycle_lock; // 0x8
        public byte[] buf; // 0x28
        public string name; // 0x30
        public Microsoft.Win32.SafeHandles.SafeFileHandle safeHandle; // 0x38
        public bool isExposed; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E5B130 | overloaded x12
        public void Init(){} // RVA: 0x5E5BB90
        public void get_CanRead(){} // RVA: 0x5E5BF00
        public void get_CanWrite(){} // RVA: 0x5E5BF20
        public void get_CanSeek(){} // RVA: 0x5E5BF40
        public void get_Name(){} // RVA: 0x6374D0
        public void get_Length(){} // RVA: 0x5E5BF50
        public void get_Position(){} // RVA: 0x5E5C0F0
        public void set_Position(){} // RVA: 0x5E5C2B0
        public void get_SafeFileHandle(){} // RVA: 0x5E5C350
        public void ExposeHandle(){} // RVA: 0x5E5C390
        public void ReadByte(){} // RVA: 0x5E5C3C0
        public void WriteByte(){} // RVA: 0x5E5C530
        public void Read(){} // RVA: 0x5E5C690
        public void ReadInternal(){} // RVA: 0x5E5CA40
        public void BeginRead(){} // RVA: 0x5E5CB10
        public void EndRead(){} // RVA: 0x5E5CF60
        public void Write(){} // RVA: 0x5E5D170
        public void WriteInternal(){} // RVA: 0x5E5D440
        public void BeginWrite(){} // RVA: 0x5E5D680
        public void EndWrite(){} // RVA: 0x5E5DB20
        public void Seek(){} // RVA: 0x5E5DD20
        public void SetLength(){} // RVA: 0x5E5E030
        public void Flush(){} // RVA: 0x5E5E2D0
        public void Finalize(){} // RVA: 0x5CB2900
        public void Dispose(){} // RVA: 0x5E5E350
        public void FlushAsync(){} // RVA: 0x5E5E760
        public void ReadAsync(){} // RVA: 0x5E5E7E0
        public void WriteAsync(){} // RVA: 0x5E5E7F0
        public void ReadSegment(){} // RVA: 0x5E5E800
        public void WriteSegment(){} // RVA: 0x5E5E910
        public void FlushBuffer(){} // RVA: 0x5E5E980
        public void FlushBufferIfDirty(){} // RVA: 0x5E5EB70
        public void RefillBuffer(){} // RVA: 0x5E5EB80
        public void ReadData(){} // RVA: 0x5E5EBC0
        public void InitBuffer(){} // RVA: 0x5E5ED00
        public void GetSecureFileName(){} // RVA: 0x5E5F190 | overloaded x2
        public void .cctor(){} // RVA: 0x5E5F280
    }

    public class FileStreamAsyncResult : .ctor
    {
        public object state; // 0x10
        public bool completed; // 0x18
        public System.Threading.ManualResetEvent wh; // 0x20
        public System.AsyncCallback cb; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E5F6A0
        public void CBWrapper(){} // RVA: 0x5E5F8D0
        public void get_AsyncState(){} // RVA: 0x2F8380
        public void get_CompletedSynchronously(){} // RVA: 0x303450
        public void get_AsyncWaitHandle(){} // RVA: 0x30B0C0
        public void get_IsCompleted(){} // RVA: 0x2F84E0
    }

    public class FileSystem
    {
        // ── Methods ──
        public void CopyFile(){} // RVA: 0x5E1FD60
        public void CreateDirectory(){} // RVA: 0x5E20090
        public void DeleteFile(){} // RVA: 0x5E20650
        public void DirectoryExists(){} // RVA: 0x5E20730 | overloaded x2
        public void FillAttributeInfo(){} // RVA: 0x5E20780
        public void FileExists(){} // RVA: 0x5E20A80
        public void GetAttributes(){} // RVA: 0x5E20AD0
        public void GetCreationTime(){} // RVA: 0x5E20B40
        public void GetLastWriteTime(){} // RVA: 0x5E20BD0
        public void MoveFile(){} // RVA: 0x5E20C60
        public void OpenHandle(){} // RVA: 0x5E20CB0
        public void RemoveDirectory(){} // RVA: 0x5E20F50
        public void GetFindData(){} // RVA: 0x5E21030
        public void IsNameSurrogateReparsePoint(){} // RVA: 0x5E21180
        public void RemoveDirectoryRecursive(){} // RVA: 0x5E211A0
        public void RemoveDirectoryInternal(){} // RVA: 0x5E21B80
        public void SetAttributes(){} // RVA: 0x5E21CB0
        public void SetLastAccessTime(){} // RVA: 0x5E21D90
        public void UnityCreateDirectory(){} // RVA: 0x5E21FD0
        public void UnityRemoveDirectory(){} // RVA: 0x5E221B0
        public void UnityGetFileAttributesEx(){} // RVA: 0x5E223F0
        public void UnitySetFileAttributes(){} // RVA: 0x5E22650
        public void UnityCreateFile_IntPtr(){} // RVA: 0x5E22820
        public void UnityCopyFile(){} // RVA: 0x5E229D0
        public void UnityDeleteFile(){} // RVA: 0x5E22B10
        public void UnityMoveFile(){} // RVA: 0x5E22D50
        public void UnityFindFirstFile(){} // RVA: 0x5E22FC0
        public void UnityFindNextFile(){} // RVA: 0x5E23450
        public void BrokeredCreateDirectory(){} // RVA: 0x5E23760
        public void BrokeredRemoveDirectory(){} // RVA: 0x5E23760
        public void BrokeredGetFileAttributes(){} // RVA: 0x5E237F0
        public void BrokeredSetAttributes(){} // RVA: 0x5E23800
        public void BrokeredOpenFile(){} // RVA: 0x5E23890
        public void BrokeredCopyFile(){} // RVA: 0x5E239C0
        public void BrokeredMoveFile(){} // RVA: 0x5E23AF0
        public void BrokeredDeleteFile(){} // RVA: 0x5E23760
        public void BrokeredFindFirstFile(){} // RVA: 0x5E23C10
        public void BrokeredFindNextFile(){} // RVA: 0x5E23D70
        public void BrokeredSafeFindHandleDispose(){} // RVA: 0x5E23E40
        public void RemoveExtendedPathPrefix(){} // RVA: 0x5E23E50
    }

    public class FileSystemEventArgs
    {
        public 0x658546B0 _changeType; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CBE430
        public void Combine(){} // RVA: 0x6CBE5B0
        public void get_ChangeType(){} // RVA: 0x32A5C0
        public void get_FullPath(){} // RVA: 0x30B0C0
    }

    public class FileSystemEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class FileSystemInfo
    {
        public WIN32_FILE_ATTRIBUTE_DATA _data; // 0x18
        public int _dataInitialized; // 0x3C
        public string FullPath; // 0x40
        public string OriginalPath; // 0x48
        public string _name; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E44D50 | overloaded x2
        public void Create(){} // RVA: 0x5E44710
        public void Invalidate(){} // RVA: 0x5E44170
        public void Init(){} // RVA: 0x5E44910
        public void get_Attributes(){} // RVA: 0x5E44960
        public void set_Attributes(){} // RVA: 0x5E44980
        public void get_ExistsCore(){} // RVA: 0x5E44A60
        public void get_CreationTimeCore(){} // RVA: 0x5E44AF0
        public void get_LastAccessTimeCore(){} // RVA: 0x5E44B30
        public void get_LastWriteTimeCore(){} // RVA: 0x5E44B70
        public void get_LengthCore(){} // RVA: 0x5E44BB0
        public void EnsureDataInitialized(){} // RVA: 0x5E44BE0
        public void Refresh(){} // RVA: 0x5E44C50
        public void get_NormalizedPath(){} // RVA: 0x5E44C80
        public void GetObjectData(){} // RVA: 0x5E44FB0
        public void get_FullName(){} // RVA: 0x35A740
        public void get_Name(){} // RVA: 0x37E0E0
        public void get_Exists(){} // RVA: 0x5E453E0
        public void Delete(){} // RVA: 0x24A50
        public void get_CreationTimeUtc(){} // RVA: 0x5E45470
        public void get_LastAccessTime(){} // RVA: 0x5E45520
        public void get_LastAccessTimeUtc(){} // RVA: 0x5E45650
        public void get_LastWriteTime(){} // RVA: 0x5E45700
        public void get_LastWriteTimeUtc(){} // RVA: 0x5E45830
        public void ToString(){} // RVA: 0x5E458E0
    }

    public class FileSystemWatcher
    {
        public bool inited; // 0x28
        public bool start_requested; // 0x29
        public bool enableRaisingEvents; // 0x2A
        public string filter; // 0x30
        public bool includeSubdirectories; // 0x38
        public int internalBufferSize; // 0x3C
        public 0x658544F8 notifyFilter; // 0x40
        public string path; // 0x48
        public string fullpath; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CC21A0 | overloaded x2
        public void InitWatcher(){} // RVA: 0x6CC2490
        public void get_Waiting(){} // RVA: 0x5A8B10
        public void set_Waiting(){} // RVA: 0x5A6190
        public void get_MangledFilter(){} // RVA: 0x6CC2A40
        public void get_Pattern(){} // RVA: 0x6CC2AE0
        public void get_FullPath(){} // RVA: 0x6CC2C40
        public void set_EnableRaisingEvents(){} // RVA: 0x6CC2D70
        public void set_Filter(){} // RVA: 0x6CC2E20
        public void get_IncludeSubdirectories(){} // RVA: 0x4A6500
        public void set_IncludeSubdirectories(){} // RVA: 0x6CC30A0
        public void set_NotifyFilter(){} // RVA: 0x6CC30E0
        public void get_Site(){} // RVA: 0x2E07C0
        public void set_Site(){} // RVA: 0x6CC3120
        public void BeginInit(){} // RVA: 0x1E32400
        public void Dispose(){} // RVA: 0x6CC3210
        public void Finalize(){} // RVA: 0x6CC33B0
        public void EndInit(){} // RVA: 0x6CC3430
        public void RaiseEvent(){} // RVA: 0x6CC34E0
        public void OnChanged(){} // RVA: 0x6CC3870
        public void OnCreated(){} // RVA: 0x6CC38A0
        public void OnDeleted(){} // RVA: 0x6CC38D0
        public void OnRenamed(){} // RVA: 0x6CC3900
        public void DispatchEvents(){} // RVA: 0x6CC3930
        public void Start(){} // RVA: 0x6CC3E90
        public void Stop(){} // RVA: 0x6CC3F00
        public void add_Changed(){} // RVA: 0x6CC3F70
        public void remove_Changed(){} // RVA: 0x6CC4060
        public void add_Created(){} // RVA: 0x6CC4150
        public void remove_Created(){} // RVA: 0x6CC4240
        public void add_Deleted(){} // RVA: 0x6CC4330
        public void remove_Deleted(){} // RVA: 0x6CC4420
        public void .cctor(){} // RVA: 0x6CC4510
    }

    public class IFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x24B10
        public void StopDispatching(){} // RVA: 0x24B10
        public void Dispose(){} // RVA: 0x24B10
    }

    public class IODescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CC4820
        public void get_Description(){} // RVA: 0x2F8380
    }

    public class IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x5
    }

    public class InvalidDataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x4
    }

    public class MemoryStream
    {
        public byte[] _buffer; // 0x28
        public int _origin; // 0x30
        public int _position; // 0x34
        public int _length; // 0x38
        public int _capacity; // 0x3C
        public bool _expandable; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E258B0 | overloaded x7
        public void get_CanRead(){} // RVA: 0x1514560
        public void get_CanSeek(){} // RVA: 0x1514560
        public void get_CanWrite(){} // RVA: 0x65EEC0
        public void EnsureNotClosed(){} // RVA: 0x5E25AD0
        public void EnsureWriteable(){} // RVA: 0x5E25B10
        public void Dispose(){} // RVA: 0x5E25B60
        public void EnsureCapacity(){} // RVA: 0x5E25BE0
        public void Flush(){} // RVA: 0x2DD310
        public void FlushAsync(){} // RVA: 0x5E25CA0
        public void GetBuffer(){} // RVA: 0x5E25DD0
        public void InternalGetBuffer(){} // RVA: 0x30B130
        public void InternalGetPosition(){} // RVA: 0x4C6670
        public void InternalReadInt32(){} // RVA: 0x5E25E40
        public void InternalEmulateRead(){} // RVA: 0x5E25F20
        public void get_Capacity(){} // RVA: 0x5E25F80
        public void set_Capacity(){} // RVA: 0x5E25FC0
        public void get_Length(){} // RVA: 0x5E261A0
        public void get_Position(){} // RVA: 0x5E261F0
        public void set_Position(){} // RVA: 0x5E26240
        public void Read(){} // RVA: 0x5E265D0 | overloaded x2
        public void ReadAsync(){} // RVA: 0x5E26BB0 | overloaded x2
        public void ReadByte(){} // RVA: 0x5E26FD0
        public void CopyTo(){} // RVA: 0x5E27050
        public void CopyToAsync(){} // RVA: 0x5E271E0
        public void Seek(){} // RVA: 0x5E27500
        public void SetLength(){} // RVA: 0x5E27760
        public void ToArray(){} // RVA: 0x5E278D0
        public void Write(){} // RVA: 0x5E27C80 | overloaded x2
        public void WriteAsync(){} // RVA: 0x5E28210 | overloaded x2
        public void WriteByte(){} // RVA: 0x5E28560
        public void WriteTo(){} // RVA: 0x5E28680
    }

    public class MonoIO
    {
        public UIntPtr IsCaseSensitive;
        public bool dump_handles; // 0x8

        // ── Methods ──
        public void GetException(){} // RVA: 0x5E5FAA0 | overloaded x2
        public void GetCurrentDirectory(){} // RVA: 0x5E60310
        public void GetFileType(){} // RVA: 0x5E603B0 | overloaded x2
        public void FindCloseFile(){} // RVA: 0x5E604C0
        public void Open(){} // RVA: 0x5E60730 | overloaded x2
        public void Cancel_internal(){} // RVA: 0x5E60880
        public void Cancel(){} // RVA: 0x5E608A0
        public void Close(){} // RVA: 0x5E609C0
        public void Read(){} // RVA: 0x5E60A90 | overloaded x2
        public void Write(){} // RVA: 0x5E60CB0 | overloaded x2
        public void Seek(){} // RVA: 0x5E60E60 | overloaded x2
        public void GetLength(){} // RVA: 0x5E61010 | overloaded x2
        public void SetLength(){} // RVA: 0x5E61200 | overloaded x2
        public void get_ConsoleOutput(){} // RVA: 0x5E613D0
        public void get_ConsoleInput(){} // RVA: 0x5E613E0
        public void get_ConsoleError(){} // RVA: 0x5E613F0
        public void CreatePipe(){} // RVA: 0x5E61400
        public void DuplicateHandle(){} // RVA: 0x5E61500
        public void get_VolumeSeparatorChar(){} // RVA: 0x5E615F0
        public void get_DirectorySeparatorChar(){} // RVA: 0x2111A20
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x5E61600
        public void get_PathSeparator(){} // RVA: 0x5E61610
        public void DumpHandles(){} // RVA: 0x5D9BDA0
        public void RemapPath(){} // RVA: 0x5E61620
        public void .cctor(){} // RVA: 0x5E61630
    }

    public class MonoIOStat
    {
    }

    public class MonoLinqHelper
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0xCE50
    }

    public class NullFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x2DD310
        public void StopDispatching(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
        public void GetInstance(){} // RVA: 0x6CC4950
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Path
    {
        public char[] InvalidPathChars;
        public char AltDirectorySeparatorChar; // 0x8
        public char DirectorySeparatorChar; // 0xA

        // ── Methods ──
        public void ChangeExtension(){} // RVA: 0x5E616B0
        public void Combine(){} // RVA: 0x5E65DD0 | overloaded x4
        public void CleanPath(){} // RVA: 0x5E61C40
        public void GetDirectoryName(){} // RVA: 0x5E625B0 | overloaded x2
        public void GetExtension(){} // RVA: 0x5E62690
        public void GetFileName(){} // RVA: 0x5E66010 | overloaded x2
        public void GetFileNameWithoutExtension(){} // RVA: 0x5E62910
        public void GetFullPath(){} // RVA: 0x5E62970
        public void GetFullPathInternal(){} // RVA: 0x5E629C0
        public void GetFullPathName(){} // RVA: 0x5E62B00 | overloaded x2
        public void WindowsDriveAdjustment(){} // RVA: 0x5E62DB0
        public void InsecureGetFullPath(){} // RVA: 0x5E62FF0
        public void IsDirectorySeparator(){} // RVA: 0x5E63620
        public void GetPathRoot(){} // RVA: 0x5E636B0
        public void GetTempPath(){} // RVA: 0x5E63B50
        public void get_temp_path(){} // RVA: 0x5E63DC0
        public void IsPathRooted(){} // RVA: 0x5E64040 | overloaded x2
        public void GetInvalidFileNameChars(){} // RVA: 0x5E64280
        public void GetInvalidPathChars(){} // RVA: 0x5E642F0
        public void GetRandomFileName(){} // RVA: 0x5E64360
        public void findExtension(){} // RVA: 0x5E64500
        public void .cctor(){} // RVA: 0x5E645B0
        public void GetServerAndShare(){} // RVA: 0x5E64A70
        public void SameRoot(){} // RVA: 0x5E64CD0
        public void CanonicalizePath(){} // RVA: 0x5E65030
        public void Join(){} // RVA: 0x5E66280 | overloaded x2
        public void JoinInternal(){} // RVA: 0x5E66AF0 | overloaded x2
        public void GetRelativePath(){} // RVA: 0x5E671D0 | overloaded x2
        public void get_StringComparison(){} // RVA: 0x5E67920
        public void get_IsCaseSensitive(){} // RVA: 0x5E679D0
        public void get_IsWindows(){} // RVA: 0x5E67A40
    }

    public class PathInternal
    {
        public bool CanRead;

        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x5E28750
        public void EndsWithPeriodOrSpace(){} // RVA: 0x5E28770
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x5E287C0
        public void EnsureExtendedPrefix(){} // RVA: 0x5E28870
        public void IsDevice(){} // RVA: 0x5E28AC0
        public void IsDeviceUNC(){} // RVA: 0x5E28C90
        public void IsExtended(){} // RVA: 0x5E28D80
        public void GetRootLength(){} // RVA: 0x5E28E10
        public void IsDirectorySeparator(){} // RVA: 0x5E29200
        public void IsEffectivelyEmpty(){} // RVA: 0x5E29220
        public void EndsInDirectorySeparator(){} // RVA: 0x5E292A0
        public void StartsWithDirectorySeparator(){} // RVA: 0x5E29340
        public void TrimEndingDirectorySeparator(){} // RVA: 0x5E295F0 | overloaded x2
        public void IsRoot(){} // RVA: 0x5E297D0
        public void GetCommonPathLength(){} // RVA: 0x5E29840
        public void EqualStartingCharacterCount(){} // RVA: 0x5E29A80
        public void AreRootsEqual(){} // RVA: 0x5E29BA0
        public void get_IsCaseSensitive(){} // RVA: 0x5E29D00
        public void GetIsCaseSensitive(){} // RVA: 0x5E29D60
        public void IsPartiallyQualified(){} // RVA: 0x2DD320
        public void .cctor(){} // RVA: 0x5E29F80
    }

    public class PathInternal
    {
        public bool AllowNew;

        // ── Methods ──
        public void get_StringComparison(){} // RVA: 0x6CBE710
        public void GetIsCaseSensitive(){} // RVA: 0x6CBE770
        public void .cctor(){} // RVA: 0x6CBE990
    }

    public class PathTooLongException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class PinnedBufferMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E2A040
        public void Read(){} // RVA: 0x5E2A190
        public void Write(){} // RVA: 0x5E2A1B0
        public void Finalize(){} // RVA: 0x5CB2900
        public void Dispose(){} // RVA: 0x5E2A1D0
    }

    public class RenamedEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CBE9E0
    }

    public class RenamedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class SearchPattern2
    {
        public Op ops; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CC4B30 | overloaded x2
        public void get_HasWildcard(){} // RVA: 0x6B93D0
        public void Compile(){} // RVA: 0x6CC4B90
        public void .cctor(){} // RVA: 0x6CC4FC0
    }

    public class Stream
    {
        public System.IO.Stream Null;
        public int DefaultCopyBufferSize;
        public ReadWriteTask _activeReadWriteTask; // 0x18
        public System.Threading.SemaphoreSlim _asyncActiveSemaphore; // 0x20

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x5E4E6A0
        public void get_CanRead(){} // RVA: 0xDBE0
        public void get_CanSeek(){} // RVA: 0xDBE0
        public void get_CanTimeout(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0xDBE0
        public void get_Length(){} // RVA: 0xCD60
        public void get_Position(){} // RVA: 0xCD60
        public void set_Position(){} // RVA: 0x24CC0
        public void get_ReadTimeout(){} // RVA: 0x5E4E800
        public void set_ReadTimeout(){} // RVA: 0x5E4E850
        public void get_WriteTimeout(){} // RVA: 0x5E4E8A0
        public void set_WriteTimeout(){} // RVA: 0x5E4E8F0
        public void CopyToAsync(){} // RVA: 0x5E4EA60 | overloaded x3
        public void CopyToAsyncInternal(){} // RVA: 0x5E4EAC0
        public void CopyTo(){} // RVA: 0x5E4ED90 | overloaded x2
        public void GetCopyBufferSize(){} // RVA: 0x5E4EF60
        public void Close(){} // RVA: 0x5E4F060
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Flush(){} // RVA: 0x24A50
        public void FlushAsync(){} // RVA: 0x5E4F130 | overloaded x2
        public void BeginRead(){} // RVA: 0x5E4F390
        public void BeginReadInternal(){} // RVA: 0x5E4F3D0
        public void EndRead(){} // RVA: 0x5E4F660
        public void ReadAsync(){} // RVA: 0x5E4FA30 | overloaded x3
        public void BeginEndReadAsync(){} // RVA: 0x5E4FD00
        public void BeginWrite(){} // RVA: 0x5E50060
        public void BeginWriteInternal(){} // RVA: 0x5E500A0
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x5E50330
        public void RunReadWriteTask(){} // RVA: 0x5E50580
        public void FinishTrackingAsyncOperation(){} // RVA: 0x5E506E0
        public void EndWrite(){} // RVA: 0x5E50760
        public void WriteAsync(){} // RVA: 0x5E50B30 | overloaded x3
        public void FinishWriteAsync(){} // RVA: 0x5E50F20
        public void BeginEndWriteAsync(){} // RVA: 0x5E51130
        public void Seek(){}
        public void SetLength(){} // RVA: 0x24CC0
        public void Read(){} // RVA: 0x5E51490 | overloaded x2
        public void ReadByte(){} // RVA: 0x5E51730
        public void Write(){} // RVA: 0x5E517E0 | overloaded x2
        public void WriteByte(){} // RVA: 0x5E51980
        public void BlockingBeginRead(){} // RVA: 0x5E51A10
        public void BlockingEndRead(){} // RVA: 0x5E51B50
        public void BlockingBeginWrite(){} // RVA: 0x5E51C70
        public void BlockingEndWrite(){} // RVA: 0x5E51DB0
        public void HasOverriddenBeginEndRead(){} // RVA: 0x3C2850
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x3C2850
        public void DisposeAsync(){} // RVA: 0x5E51ED0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5E51F80
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x5E52070
    }

    public class StreamHelpers
    {
        // ── Methods ──
        public void ValidateCopyToArgs(){} // RVA: 0x5E2A260
    }

    public class StreamReader
    {
        public System.IO.StreamReader Null;
        public System.IO.Stream _stream; // 0x18
        public System.Text.Encoding _encoding; // 0x20
        public System.Text.Decoder _decoder; // 0x28

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x5E2A530
        public void ThrowAsyncIOInProgress(){} // RVA: 0x5E2A5D0
        public void .ctor(){} // RVA: 0x5E2ABD0 | overloaded x11
        public void Init(){} // RVA: 0x5E2B1B0 | overloaded x2
        public void Close(){} // RVA: 0x5CB0AF0
        public void Dispose(){} // RVA: 0x5E2B210
        public void get_CurrentEncoding(){} // RVA: 0x30B0C0
        public void get_BaseStream(){} // RVA: 0x2E07C0
        public void get_LeaveOpen(){} // RVA: 0x5E2B4B0
        public void get_EndOfStream(){} // RVA: 0x5E2B4C0
        public void Peek(){} // RVA: 0x5E2B560
        public void Read(){} // RVA: 0x5E2B8C0 | overloaded x3
        public void ReadSpan(){} // RVA: 0x5E2B9D0
        public void ReadToEnd(){} // RVA: 0x5E2BC80
        public void CompressBuffer(){} // RVA: 0x5E2BDC0
        public void DetectEncoding(){} // RVA: 0x5E2BE00
        public void IsPreamble(){} // RVA: 0x5E2C3A0
        public void ReadBuffer(){} // RVA: 0x5E2CC40 | overloaded x2
        public void ReadLine(){} // RVA: 0x5E2D5F0
        public void ReadToEndAsync(){} // RVA: 0x5E2D850
        public void ReadToEndAsyncInternal(){} // RVA: 0x5E2DCD0
        public void ReadAsync(){} // RVA: 0x5E2DE70
        public void ReadAsyncInternal(){} // RVA: 0x5E2E1A0
        public void ReadBufferAsync(){} // RVA: 0x5E2E440
        public void DataAvailable(){} // RVA: 0x5E2E5F0
        public void .cctor(){} // RVA: 0x5E2E600
    }

    public class StreamWriter
    {
        public System.IO.StreamWriter Null;
        public System.IO.Stream _stream; // 0x30
        public System.Text.Encoding _encoding; // 0x38
        public System.Text.Encoder _encoder; // 0x40
        public byte[] _byteBuffer; // 0x48
        public char[] _charBuffer; // 0x50
        public int _charPos; // 0x58

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x5E31770
        public void ThrowAsyncIOInProgress(){} // RVA: 0x5E31810
        public void get_UTF8NoBOM(){} // RVA: 0x5E31860
        public void .ctor(){} // RVA: 0x5E31EE0 | overloaded x9
        public void Init(){} // RVA: 0x5E321F0
        public void Close(){} // RVA: 0x5E324C0
        public void Dispose(){} // RVA: 0x5E32530
        public void DisposeAsync(){} // RVA: 0x5E32860
        public void DisposeAsyncCore(){} // RVA: 0x5E32AE0
        public void CloseStreamFromDispose(){} // RVA: 0x5E32C80
        public void Flush(){} // RVA: 0x5E32D50 | overloaded x2
        public void set_AutoFlush(){} // RVA: 0x5E32F40
        public void get_BaseStream(){} // RVA: 0x6374D0
        public void get_LeaveOpen(){} // RVA: 0x5E32F80
        public void get_Encoding(){} // RVA: 0x4976A0
        public void Write(){} // RVA: 0x5E335A0 | overloaded x4
        public void WriteSpan(){} // RVA: 0x5E33320
        public void WriteLine(){} // RVA: 0x5E33620
        public void WriteAsync(){} // RVA: 0x5E34090 | overloaded x3
        public void WriteAsyncInternal(){} // RVA: 0x5E34430 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x5E34780
        public void FlushAsync(){} // RVA: 0x5E34B20
        public void set_CharPos_Prop(){} // RVA: 0x9EAAE0
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x114F200
        public void FlushAsyncInternal(){} // RVA: 0x5E34ED0 | overloaded x2
        public void .cctor(){} // RVA: 0x5E352C0
    }

    public class StringReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E59800
        public void Close(){} // RVA: 0x5CB0AF0
        public void Dispose(){} // RVA: 0x5E598F0
        public void Peek(){} // RVA: 0x5E59950
        public void Read(){} // RVA: 0x5E59A00 | overloaded x2
        public void ReadToEnd(){} // RVA: 0x5E59C10
        public void ReadLine(){} // RVA: 0x5E59C70
        public void ReadToEndAsync(){} // RVA: 0x5E59DA0
        public void ReadAsync(){} // RVA: 0x5E59E20
    }

    public class StringWriter
    {
        public System.Text.UnicodeEncoding m_encoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E5A220 | overloaded x4
        public void Close(){} // RVA: 0x5E5A340
        public void Dispose(){} // RVA: 0x2EB7C0
        public void get_Encoding(){} // RVA: 0x5E5A360
        public void GetStringBuilder(){} // RVA: 0x6374D0
        public void Write(){} // RVA: 0x5E5A690 | overloaded x3
        public void WriteAsync(){} // RVA: 0x5E5A850 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x5E5A940
        public void FlushAsync(){} // RVA: 0x5E5AA30
        public void ToString(){} // RVA: 0x5E5AAD0
    }

    public class TextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Close(){} // RVA: 0x5E373C0
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Peek(){} // RVA: 0x75BB20
        public void Read(){} // RVA: 0x5E376B0 | overloaded x3
        public void ReadToEnd(){} // RVA: 0x5E37950
        public void ReadLine(){} // RVA: 0x5E37A90
        public void ReadToEndAsync(){} // RVA: 0x5E37C10
        public void ReadAsync(){} // RVA: 0x5E37DC0
        public void ReadAsyncInternal(){} // RVA: 0x5E37FF0
        public void Synchronized(){} // RVA: 0x5E38440
        public void .cctor(){} // RVA: 0x5E38580
    }

    public class TextWriter
    {
        public System.IO.TextWriter Null;
        public char[] s_coreNewLine; // 0x8
        public char[] CoreNewLine; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E396C0 | overloaded x2
        public void get_FormatProvider(){} // RVA: 0x5E39840
        public void Close(){} // RVA: 0x5E398E0
        public void Dispose(){} // RVA: 0x5E39950 | overloaded x2
        public void DisposeAsync(){} // RVA: 0x5E399C0
        public void Flush(){} // RVA: 0x2DD310
        public void get_Encoding(){} // RVA: 0xCD60
        public void get_NewLine(){} // RVA: 0x30B0C0
        public void Write(){} // RVA: 0x5E39E40 | overloaded x8
        public void WriteLine(){} // RVA: 0x5E3A070 | overloaded x5
        public void WriteAsync(){} // RVA: 0x5E3A700 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x5E3A9D0
        public void FlushAsync(){} // RVA: 0x5E3ACA0
        public void Synchronized(){} // RVA: 0x5E3AF30
        public void .cctor(){} // RVA: 0x5E3B090
    }

    public class UnexceptionalStreamReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5E680A0
        public void .ctor(){} // RVA: 0x5E68190
        public void Peek(){} // RVA: 0x5E68220
        public void Read(){} // RVA: 0x5E68260 | overloaded x2
        public void CheckEOL(){} // RVA: 0x5E684D0
        public void ReadLine(){} // RVA: 0x5E686B0
        public void ReadToEnd(){} // RVA: 0x5E686D0
    }

    public class UnexceptionalStreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E68820
        public void Flush(){} // RVA: 0x5E688A0
        public void Write(){} // RVA: 0x5E68930 | overloaded x4
    }

    public class UnmanagedMemoryAccessor : .ctor
    {
        public System.Runtime.InteropServices.SafeBuffer _buffer; // 0x10
        public long _offset; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x187B6D0
        public void Initialize(){} // RVA: 0x5E3BF20
        public void get_Capacity(){} // RVA: 0x30B0C0
        public void Dispose(){} // RVA: 0x5E3C360 | overloaded x2
        public void get_IsOpen(){} // RVA: 0x3BC230
    }

    public class UnmanagedMemoryStream
    {
        public System.Runtime.InteropServices.SafeBuffer _buffer; // 0x28
        public byte* _mem; // 0x30
        public long _length; // 0x38
        public long _capacity; // 0x40
        public long _position; // 0x48
        public long _offset; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E3C4B0 | overloaded x3
        public void Initialize(){} // RVA: 0x5E3C540
        public void get_CanRead(){} // RVA: 0x5E3C7D0
        public void get_CanSeek(){} // RVA: 0x37B240
        public void get_CanWrite(){} // RVA: 0x5E3C7F0
        public void Dispose(){} // RVA: 0x5E3C810
        public void EnsureNotClosed(){} // RVA: 0x5E3C820
        public void EnsureReadable(){} // RVA: 0x5E3C860
        public void EnsureWriteable(){} // RVA: 0x5E3C8B0
        public void Flush(){} // RVA: 0x5E3C820
        public void FlushAsync(){} // RVA: 0x5E3C900
        public void get_Length(){} // RVA: 0x5E3CA30
        public void get_Position(){} // RVA: 0x5E3CA80
        public void set_Position(){} // RVA: 0x5E3CAD0
        public void get_PositionPointer(){} // RVA: 0x5E3CB90
        public void Read(){} // RVA: 0x5E3CEB0 | overloaded x2
        public void ReadCore(){} // RVA: 0x5E3CFC0
        public void ReadAsync(){} // RVA: 0x5E3D5A0 | overloaded x2
        public void ReadByte(){} // RVA: 0x5E3D950
        public void Seek(){} // RVA: 0x5E3DAD0
        public void SetLength(){} // RVA: 0x5E3DCA0
        public void Write(){} // RVA: 0x5E3E0E0 | overloaded x2
        public void WriteCore(){} // RVA: 0x5E3E1F0
        public void WriteAsync(){} // RVA: 0x5E3E820 | overloaded x2
        public void WriteByte(){} // RVA: 0x5E3EB10
    }

    public class WaitForChangedResult
    {
        public System.IO.WaitForChangedResult TimedOutResult;
        public 0x658546B0 <ChangeType>k__BackingField; // 0x10
        public string <Name>k__BackingField; // 0x18
        public string <OldName>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CBEAD0
        public void set_ChangeType(){} // RVA: 0x833580
        public void set_Name(){} // RVA: 0x1968950
        public void set_OldName(){} // RVA: 0x2DEE30
        public void set_TimedOut(){} // RVA: 0x2F84F0
        public void .cctor(){} // RVA: 0x6CBEBF0
    }

    public class Win32Marshal
    {
        // ── Methods ──
        public void GetExceptionForLastWin32Error(){} // RVA: 0x5E3F050
        public void GetExceptionForWin32Error(){} // RVA: 0x5E3F0B0
        public void MakeHRFromErrorCode(){} // RVA: 0x5E3F5F0
        public void TryMakeWin32ErrorCodeFromHR(){} // RVA: 0x5E3F610
        public void GetMessage(){} // RVA: 0x5BF1B00
    }

    public class __Error
    {
        // ── Methods ──
        public void EndOfFile(){} // RVA: 0x5E55540
        public void FileNotOpen(){} // RVA: 0x5E555A0
        public void ReaderClosed(){} // RVA: 0x5E55610
        public void GetDisplayablePath(){} // RVA: 0x5E55680
        public void WinIOError(){} // RVA: 0x5E557E0
        public void WriterClosed(){} // RVA: 0x5E56000
    }

}