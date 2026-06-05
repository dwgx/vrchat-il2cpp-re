// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 62
// Methods: 898

namespace ThirdParty.DotNet.System.IO
{
    public class BinaryReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8906130 | overloaded x3
        public void get_BaseStream(){} // RVA: 0x7FFAF2DA8380
        public void Close(){} // RVA: 0x7FFAF47CE0E0
        public void Dispose(){} // RVA: 0x7FFAF47CE0E0 | overloaded x2
        public void Read(){} // RVA: 0x7FFAF8907B10 | overloaded x2
        public void ReadBoolean(){} // RVA: 0x7FFAF89066B0
        public void ReadByte(){} // RVA: 0x7FFAF8906700
        public void ReadSByte(){} // RVA: 0x7FFAF8906740
        public void ReadChar(){} // RVA: 0x7FFAF8906790
        public void ReadInt16(){} // RVA: 0x7FFAF89067C0
        public void ReadUInt16(){} // RVA: 0x7FFAF89067C0
        public void ReadInt32(){} // RVA: 0x7FFAF8906820
        public void ReadUInt32(){} // RVA: 0x7FFAF8906A00
        public void ReadInt64(){} // RVA: 0x7FFAF8906A80
        public void ReadUInt64(){} // RVA: 0x7FFAF8906A80
        public void ReadSingle(){} // RVA: 0x7FFAF8906B70
        public void ReadDouble(){} // RVA: 0x7FFAF8906BF0
        public void ReadDecimal(){} // RVA: 0x7FFAF8906C70
        public void ReadString(){} // RVA: 0x7FFAF8906EE0
        public void InternalReadChars(){} // RVA: 0x7FFAF89071E0
        public void InternalReadOneChar(){} // RVA: 0x7FFAF89075F0
        public void ReadChars(){} // RVA: 0x7FFAF8907930
        public void ReadBytes(){} // RVA: 0x7FFAF8907D00
        public void FillBuffer(){} // RVA: 0x7FFAF8907F00
        public void Read7BitEncodedInt(){} // RVA: 0x7FFAF8908070
    }

    public class BinaryWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8908450 | overloaded x4
        public void Close(){} // RVA: 0x7FFAF47CE0E0
        public void Dispose(){} // RVA: 0x7FFAF47CE0E0 | overloaded x2
        public void get_BaseStream(){} // RVA: 0x7FFAF8908690
        public void Flush(){} // RVA: 0x7FFAF88AC2A0
        public void DisposeAsync(){} // RVA: 0x7FFAF89086C0
        public void Write(){} // RVA: 0x7FFAF8909310 | overloaded x16
        public void Write7BitEncodedInt(){} // RVA: 0x7FFAF89096E0
        public void .cctor(){} // RVA: 0x7FFAF8909750
    }

    public class BufferedStream
    {
        // ── Methods ──
        public void LazyEnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFAF88F5930
        public void .ctor(){} // RVA: 0x7FFAF88F5AA0 | overloaded x2
        public void EnsureNotClosed(){} // RVA: 0x7FFAF88F5CF0
        public void EnsureCanSeek(){} // RVA: 0x7FFAF88F5D60
        public void EnsureCanRead(){} // RVA: 0x7FFAF88F5DF0
        public void EnsureCanWrite(){} // RVA: 0x7FFAF88F5E80
        public void EnsureShadowBufferAllocated(){} // RVA: 0x7FFAF88F5F10
        public void EnsureBufferAllocated(){} // RVA: 0x7FFAF88F6040
        public void get_CanRead(){} // RVA: 0x7FFAF88F60E0
        public void get_CanWrite(){} // RVA: 0x7FFAF88F6110
        public void get_CanSeek(){} // RVA: 0x7FFAF88F6140
        public void get_Length(){} // RVA: 0x7FFAF88F6170
        public void get_Position(){} // RVA: 0x7FFAF88F6200
        public void set_Position(){} // RVA: 0x7FFAF88F62A0
        public void DisposeAsync(){} // RVA: 0x7FFAF88F6370
        public void Dispose(){} // RVA: 0x7FFAF88F6520
        public void Flush(){} // RVA: 0x7FFAF88F66F0
        public void FlushAsync(){} // RVA: 0x7FFAF88F6830
        public void FlushAsyncInternal(){} // RVA: 0x7FFAF88F6900
        public void FlushRead(){} // RVA: 0x7FFAF88F6B20
        public void ClearReadBufferBeforeWrite(){} // RVA: 0x7FFAF88F6B70
        public void FlushWrite(){} // RVA: 0x7FFAF88F6C40
        public void FlushWriteAsync(){} // RVA: 0x7FFAF88F6CB0
        public void ReadFromBuffer(){} // RVA: 0x7FFAF88F70C0 | overloaded x3
        public void Read(){} // RVA: 0x7FFAF88F7460 | overloaded x2
        public void LastSyncCompletedReadTask(){} // RVA: 0x7FFAF88F7680
        public void ReadAsync(){} // RVA: 0x7FFAF88F7EA0 | overloaded x2
        public void ReadFromUnderlyingStreamAsync(){} // RVA: 0x7FFAF88F8350
        public void BeginRead(){} // RVA: 0x7FFAF88F8650
        public void EndRead(){} // RVA: 0x7FFAF88F8700
        public void ReadByte(){} // RVA: 0x7FFAF88F8740
        public void ReadByteSlow(){} // RVA: 0x7FFAF88F8870
        public void WriteToBuffer(){} // RVA: 0x7FFAF88F8A40 | overloaded x2
        public void Write(){} // RVA: 0x7FFAF88F8FE0 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAF88F9650 | overloaded x2
        public void WriteToUnderlyingStreamAsync(){} // RVA: 0x7FFAF88F99F0
        public void BeginWrite(){} // RVA: 0x7FFAF88F9CB0
        public void EndWrite(){} // RVA: 0x7FFAF871ED10
        public void WriteByte(){} // RVA: 0x7FFAF88F9D60
        public void Seek(){} // RVA: 0x7FFAF88F9E30
        public void SetLength(){} // RVA: 0x7FFAF88F9FB0
        public void CopyTo(){} // RVA: 0x7FFAF88FA090
        public void CopyToAsync(){} // RVA: 0x7FFAF88FA140
        public void CopyToAsyncCore(){} // RVA: 0x7FFAF88FA230
    }

    public class CStreamReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8918950
        public void Peek(){} // RVA: 0x7FFAF8918220
        public void Read(){} // RVA: 0x7FFAF8918CA0 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFAF8918E50
        public void ReadToEnd(){} // RVA: 0x7FFAF8918E80
    }

    public class CStreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8918EB0
        public void Write(){} // RVA: 0x7FFAF8919670 | overloaded x4
        public void InternalWriteString(){} // RVA: 0x7FFAF89195D0
        public void InternalWriteChar(){} // RVA: 0x7FFAF89195F0
        public void InternalWriteChars(){} // RVA: 0x7FFAF8919610
        public void WriteLine(){} // RVA: 0x7FFAF89196E0
    }

    public class DefaultWatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void GetInstance(){} // RVA: 0x7FFAF976ED50
        public void StartDispatching(){} // RVA: 0x7FFAF976EF20
        public void StopDispatching(){} // RVA: 0x7FFAF976FC50
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void Monitor(){} // RVA: 0x7FFAF9770240
        public void UpdateDataAndDispatch(){} // RVA: 0x7FFAF9770C70
        public void DispatchEvents(){} // RVA: 0x7FFAF9770DB0
        public void DoFiles(){} // RVA: 0x7FFAF9770F50
        public void IterateAndModifyFilesData(){} // RVA: 0x7FFAF9771330
        public void CreateFileData(){} // RVA: 0x7FFAF9771F70
        public void .cctor(){} // RVA: 0x7FFAF9772090
    }

    public class DefaultWatcherData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF976ECC0
    }

    public class Directory
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFAF88EF680
        public void Exists(){} // RVA: 0x7FFAF88EF820
        public void GetFiles(){} // RVA: 0x7FFAF88EFA70 | overloaded x3
        public void GetDirectories(){} // RVA: 0x7FFAF88EFC20 | overloaded x2
        public void GetFileSystemEntries(){} // RVA: 0x7FFAF88EFDC0 | overloaded x2
        public void InternalEnumeratePaths(){} // RVA: 0x7FFAF88EFE50
        public void EnumerateFiles(){} // RVA: 0x7FFAF88F02A0 | overloaded x4
        public void GetDirectoryRoot(){} // RVA: 0x7FFAF88F02C0
        public void InternalGetDirectoryRoot(){} // RVA: 0x7FFAF88F0440
        public void GetCurrentDirectory(){} // RVA: 0x7FFAF88F0500
        public void Delete(){} // RVA: 0x7FFAF88F0510
        public void InsecureGetCurrentDirectory(){} // RVA: 0x7FFAF88F05B0
    }

    public class DirectoryInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88F15A0 | overloaded x3
        public void Init(){} // RVA: 0x7FFAF88F07B0
        public void get_Parent(){} // RVA: 0x7FFAF88F0D30
        public void Create(){} // RVA: 0x7FFAF88F0F00
        public void GetFiles(){} // RVA: 0x7FFAF88F1090 | overloaded x3
        public void EnumerateFiles(){} // RVA: 0x7FFAF88F12A0 | overloaded x3
        public void InternalEnumerateInfos(){} // RVA: 0x7FFAF88F1340
        public void Delete(){} // RVA: 0x7FFAF88F1540
    }

    public class DirectoryNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class DisableMediaInsertionPrompt
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF88CFC40
        public void Dispose(){} // RVA: 0x7FFAF88CFCC0
    }

    public class DriveNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class EndOfStreamException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class EnumerationOptions
    {
        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x7FFAF88F15C0
        public void get_CompatibleRecursive(){} // RVA: 0x7FFAF88F1620
        public void get_Default(){} // RVA: 0x7FFAF88F1680
        public void .ctor(){} // RVA: 0x7FFAF88F16E0
        public void FromSearchOption(){} // RVA: 0x7FFAF88F16F0
        public void get_RecurseSubdirectories(){} // RVA: 0x7FFAF2E575E0
        public void set_RecurseSubdirectories(){} // RVA: 0x7FFAF2E575F0
        public void get_IgnoreInaccessible(){} // RVA: 0x7FFAF2FF3460
        public void set_IgnoreInaccessible(){} // RVA: 0x7FFAF2FF3470
        public void get_BufferSize(){} // RVA: 0x7FFAF335BED0
        public void get_AttributesToSkip(){} // RVA: 0x7FFAF306ED50
        public void set_AttributesToSkip(){} // RVA: 0x7FFAF30E74E0
        public void get_MatchType(){} // RVA: 0x7FFAF442C3B0
        public void set_MatchType(){} // RVA: 0x7FFAF4439FD0
        public void get_MatchCasing(){} // RVA: 0x7FFAF3210030
        public void get_ReturnSpecialDirectories(){} // RVA: 0x7FFAF2DA87C0
        public void .cctor(){} // RVA: 0x7FFAF88F1810
    }

    public class Error
    {
        // ── Methods ──
        public void GetStreamIsClosed(){} // RVA: 0x7FFAF88D4030
        public void GetEndOfFile(){} // RVA: 0x7FFAF88D40A0
        public void GetReadNotSupported(){} // RVA: 0x7FFAF88D4110
        public void GetWriteNotSupported(){} // RVA: 0x7FFAF88D4180
    }

    public class Error
    {
        // ── Methods ──
        public void GetEndOfFile(){} // RVA: 0x7FFAF9125890
        public void GetPipeNotOpen(){} // RVA: 0x7FFAF9125900
        public void GetReadNotSupported(){} // RVA: 0x7FFAF9125970
        public void GetSeekNotSupported(){} // RVA: 0x7FFAF91259E0
        public void GetWriteNotSupported(){} // RVA: 0x7FFAF9125A50
        public void GetOperationAborted(){} // RVA: 0x7FFAF9125AC0
    }

    public class ErrorEventArgs
    {
    }

    public class ErrorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45AE240
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class File
    {
        // ── Methods ──
        public void OpenText(){} // RVA: 0x7FFAF88F19E0
        public void Copy(){} // RVA: 0x7FFAF88F1AC0 | overloaded x2
        public void Create(){} // RVA: 0x7FFAF88F1DF0 | overloaded x3
        public void Delete(){} // RVA: 0x7FFAF88F1E90
        public void Exists(){} // RVA: 0x7FFAF88F1F70
        public void Open(){} // RVA: 0x7FFAF88F2100 | overloaded x2
        public void GetUtcDateTimeOffset(){} // RVA: 0x7FFAF88F21A0
        public void GetCreationTime(){} // RVA: 0x7FFAF88F22D0
        public void GetCreationTimeUtc(){} // RVA: 0x7FFAF88F2400
        public void SetLastAccessTimeUtc(){} // RVA: 0x7FFAF88F2560
        public void GetLastWriteTime(){} // RVA: 0x7FFAF88F2720
        public void GetLastWriteTimeUtc(){} // RVA: 0x7FFAF88F2850
        public void GetAttributes(){} // RVA: 0x7FFAF88F29B0
        public void OpenRead(){} // RVA: 0x7FFAF88F2A90
        public void OpenWrite(){} // RVA: 0x7FFAF88F2B20
        public void ReadAllText(){} // RVA: 0x7FFAF88F2BA0
        public void InternalReadAllText(){} // RVA: 0x7FFAF88F2C80
        public void WriteAllText(){} // RVA: 0x7FFAF88F2F50 | overloaded x2
        public void ReadAllBytes(){} // RVA: 0x7FFAF88F3180
        public void ReadAllBytesUnknownLength(){} // RVA: 0x7FFAF88F33F0
        public void WriteAllBytes(){} // RVA: 0x7FFAF88F3940
        public void InternalWriteAllBytes(){} // RVA: 0x7FFAF88F3A70
        public void ReadAllLines(){} // RVA: 0x7FFAF88F3BC0
        public void InternalReadAllLines(){} // RVA: 0x7FFAF88F3CA0
        public void Move(){} // RVA: 0x7FFAF88F3EB0
    }

    public class FileData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class FileInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88F15A0 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFAF88F43F0
        public void get_DirectoryName(){} // RVA: 0x7FFAF88F44A0
        public void get_Directory(){} // RVA: 0x7FFAF88F4500
        public void get_IsReadOnly(){} // RVA: 0x7FFAF88F45B0
        public void set_IsReadOnly(){} // RVA: 0x7FFAF88F45D0
        public void CreateText(){} // RVA: 0x7FFAF88F4620
        public void AppendText(){} // RVA: 0x7FFAF88F4690
        public void Delete(){} // RVA: 0x7FFAF88F4700
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
    }

    public class FileLoadException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D4550 | overloaded x3
        public void get_Message(){} // RVA: 0x7FFAF88D4260
        public void get_FileName(){} // RVA: 0x7FFAF3246DE0
        public void get_FusionLog(){} // RVA: 0x7FFAF34CC8C0
        public void ToString(){} // RVA: 0x7FFAF88D4340
        public void GetObjectData(){} // RVA: 0x7FFAF88D46F0
        public void FormatFileLoadExceptionMessage(){} // RVA: 0x7FFAF88D4A00
    }

    public class FileNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D4FB0 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFAF88D4B60
        public void SetMessageField(){} // RVA: 0x7FFAF88D4C80
        public void get_FileName(){} // RVA: 0x7FFAF3246DE0
        public void get_FusionLog(){} // RVA: 0x7FFAF34CC8C0
        public void ToString(){} // RVA: 0x7FFAF88D4DA0
        public void GetObjectData(){} // RVA: 0x7FFAF88D5150
    }

    public class FileStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF890B130 | overloaded x12
        public void Init(){} // RVA: 0x7FFAF890BB90
        public void get_CanRead(){} // RVA: 0x7FFAF890BF00
        public void get_CanWrite(){} // RVA: 0x7FFAF890BF20
        public void get_CanSeek(){} // RVA: 0x7FFAF890BF40
        public void get_Name(){} // RVA: 0x7FFAF30E74D0
        public void get_Length(){} // RVA: 0x7FFAF890BF50
        public void get_Position(){} // RVA: 0x7FFAF890C0F0
        public void set_Position(){} // RVA: 0x7FFAF890C2B0
        public void get_SafeFileHandle(){} // RVA: 0x7FFAF890C350
        public void ExposeHandle(){} // RVA: 0x7FFAF890C390
        public void ReadByte(){} // RVA: 0x7FFAF890C3C0
        public void WriteByte(){} // RVA: 0x7FFAF890C530
        public void Read(){} // RVA: 0x7FFAF890C690
        public void ReadInternal(){} // RVA: 0x7FFAF890CA40
        public void BeginRead(){} // RVA: 0x7FFAF890CB10
        public void EndRead(){} // RVA: 0x7FFAF890CF60
        public void Write(){} // RVA: 0x7FFAF890D170
        public void WriteInternal(){} // RVA: 0x7FFAF890D440
        public void BeginWrite(){} // RVA: 0x7FFAF890D680
        public void EndWrite(){} // RVA: 0x7FFAF890DB20
        public void Seek(){} // RVA: 0x7FFAF890DD20
        public void SetLength(){} // RVA: 0x7FFAF890E030
        public void Flush(){} // RVA: 0x7FFAF890E2D0
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void Dispose(){} // RVA: 0x7FFAF890E350
        public void FlushAsync(){} // RVA: 0x7FFAF890E760
        public void ReadAsync(){} // RVA: 0x7FFAF890E7E0
        public void WriteAsync(){} // RVA: 0x7FFAF890E7F0
        public void ReadSegment(){} // RVA: 0x7FFAF890E800
        public void WriteSegment(){} // RVA: 0x7FFAF890E910
        public void FlushBuffer(){} // RVA: 0x7FFAF890E980
        public void FlushBufferIfDirty(){} // RVA: 0x7FFAF890EB70
        public void RefillBuffer(){} // RVA: 0x7FFAF890EB80
        public void ReadData(){} // RVA: 0x7FFAF890EBC0
        public void InitBuffer(){} // RVA: 0x7FFAF890ED00
        public void GetSecureFileName(){} // RVA: 0x7FFAF890F190 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF890F280
    }

    public class FileStreamAsyncResult : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF890F6A0
        public void CBWrapper(){} // RVA: 0x7FFAF890F8D0
        public void get_AsyncState(){} // RVA: 0x7FFAF2DA8380
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAF2DB3450
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAF2DBB0C0
        public void get_IsCompleted(){} // RVA: 0x7FFAF2DA84E0
    }

    public class FileSystem
    {
        // ── Methods ──
        public void CopyFile(){} // RVA: 0x7FFAF88CFD60
        public void CreateDirectory(){} // RVA: 0x7FFAF88D0090
        public void DeleteFile(){} // RVA: 0x7FFAF88D0650
        public void DirectoryExists(){} // RVA: 0x7FFAF88D0730 | overloaded x2
        public void FillAttributeInfo(){} // RVA: 0x7FFAF88D0780
        public void FileExists(){} // RVA: 0x7FFAF88D0A80
        public void GetAttributes(){} // RVA: 0x7FFAF88D0AD0
        public void GetCreationTime(){} // RVA: 0x7FFAF88D0B40
        public void GetLastWriteTime(){} // RVA: 0x7FFAF88D0BD0
        public void MoveFile(){} // RVA: 0x7FFAF88D0C60
        public void OpenHandle(){} // RVA: 0x7FFAF88D0CB0
        public void RemoveDirectory(){} // RVA: 0x7FFAF88D0F50
        public void GetFindData(){} // RVA: 0x7FFAF88D1030
        public void IsNameSurrogateReparsePoint(){} // RVA: 0x7FFAF88D1180
        public void RemoveDirectoryRecursive(){} // RVA: 0x7FFAF88D11A0
        public void RemoveDirectoryInternal(){} // RVA: 0x7FFAF88D1B80
        public void SetAttributes(){} // RVA: 0x7FFAF88D1CB0
        public void SetLastAccessTime(){} // RVA: 0x7FFAF88D1D90
        public void UnityCreateDirectory(){} // RVA: 0x7FFAF88D1FD0
        public void UnityRemoveDirectory(){} // RVA: 0x7FFAF88D21B0
        public void UnityGetFileAttributesEx(){} // RVA: 0x7FFAF88D23F0
        public void UnitySetFileAttributes(){} // RVA: 0x7FFAF88D2650
        public void UnityCreateFile_IntPtr(){} // RVA: 0x7FFAF88D2820
        public void UnityCopyFile(){} // RVA: 0x7FFAF88D29D0
        public void UnityDeleteFile(){} // RVA: 0x7FFAF88D2B10
        public void UnityMoveFile(){} // RVA: 0x7FFAF88D2D50
        public void UnityFindFirstFile(){} // RVA: 0x7FFAF88D2FC0
        public void UnityFindNextFile(){} // RVA: 0x7FFAF88D3450
        public void BrokeredCreateDirectory(){} // RVA: 0x7FFAF88D3760
        public void BrokeredRemoveDirectory(){} // RVA: 0x7FFAF88D3760
        public void BrokeredGetFileAttributes(){} // RVA: 0x7FFAF88D37F0
        public void BrokeredSetAttributes(){} // RVA: 0x7FFAF88D3800
        public void BrokeredOpenFile(){} // RVA: 0x7FFAF88D3890
        public void BrokeredCopyFile(){} // RVA: 0x7FFAF88D39C0
        public void BrokeredMoveFile(){} // RVA: 0x7FFAF88D3AF0
        public void BrokeredDeleteFile(){} // RVA: 0x7FFAF88D3760
        public void BrokeredFindFirstFile(){} // RVA: 0x7FFAF88D3C10
        public void BrokeredFindNextFile(){} // RVA: 0x7FFAF88D3D70
        public void BrokeredSafeFindHandleDispose(){} // RVA: 0x7FFAF88D3E40
        public void RemoveExtendedPathPrefix(){} // RVA: 0x7FFAF88D3E50
    }

    public class FileSystemEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF976E430
        public void Combine(){} // RVA: 0x7FFAF976E5B0
        public void get_ChangeType(){} // RVA: 0x7FFAF2DDA5C0
        public void get_FullPath(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class FileSystemEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45AE240
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88F4D50 | overloaded x2
        public void Create(){} // RVA: 0x7FFAF88F4710
        public void Invalidate(){} // RVA: 0x7FFAF88F4170
        public void Init(){} // RVA: 0x7FFAF88F4910
        public void get_Attributes(){} // RVA: 0x7FFAF88F4960
        public void set_Attributes(){} // RVA: 0x7FFAF88F4980
        public void get_ExistsCore(){} // RVA: 0x7FFAF88F4A60
        public void get_CreationTimeCore(){} // RVA: 0x7FFAF88F4AF0
        public void get_LastAccessTimeCore(){} // RVA: 0x7FFAF88F4B30
        public void get_LastWriteTimeCore(){} // RVA: 0x7FFAF88F4B70
        public void get_LengthCore(){} // RVA: 0x7FFAF88F4BB0
        public void EnsureDataInitialized(){} // RVA: 0x7FFAF88F4BE0
        public void Refresh(){} // RVA: 0x7FFAF88F4C50
        public void get_NormalizedPath(){} // RVA: 0x7FFAF88F4C80
        public void GetObjectData(){} // RVA: 0x7FFAF88F4FB0
        public void get_FullName(){} // RVA: 0x7FFAF2E0A740
        public void get_Name(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Exists(){} // RVA: 0x7FFAF88F53E0
        public void Delete(){} // RVA: 0x7FFAF2AD4A50
        public void get_CreationTimeUtc(){} // RVA: 0x7FFAF88F5470
        public void get_LastAccessTime(){} // RVA: 0x7FFAF88F5520
        public void get_LastAccessTimeUtc(){} // RVA: 0x7FFAF88F5650
        public void get_LastWriteTime(){} // RVA: 0x7FFAF88F5700
        public void get_LastWriteTimeUtc(){} // RVA: 0x7FFAF88F5830
        public void ToString(){} // RVA: 0x7FFAF88F58E0
    }

    public class FileSystemWatcher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF97721A0 | overloaded x2
        public void InitWatcher(){} // RVA: 0x7FFAF9772490
        public void get_Waiting(){} // RVA: 0x7FFAF3058B10
        public void set_Waiting(){} // RVA: 0x7FFAF3056190
        public void get_MangledFilter(){} // RVA: 0x7FFAF9772A40
        public void get_Pattern(){} // RVA: 0x7FFAF9772AE0
        public void get_FullPath(){} // RVA: 0x7FFAF9772C40
        public void set_EnableRaisingEvents(){} // RVA: 0x7FFAF9772D70
        public void set_Filter(){} // RVA: 0x7FFAF9772E20
        public void get_IncludeSubdirectories(){} // RVA: 0x7FFAF2F56500
        public void set_IncludeSubdirectories(){} // RVA: 0x7FFAF97730A0
        public void set_NotifyFilter(){} // RVA: 0x7FFAF97730E0
        public void get_Site(){} // RVA: 0x7FFAF2D907C0
        public void set_Site(){} // RVA: 0x7FFAF9773120
        public void BeginInit(){} // RVA: 0x7FFAF48E2400
        public void Dispose(){} // RVA: 0x7FFAF9773210
        public void Finalize(){} // RVA: 0x7FFAF97733B0
        public void EndInit(){} // RVA: 0x7FFAF9773430
        public void RaiseEvent(){} // RVA: 0x7FFAF97734E0
        public void OnChanged(){} // RVA: 0x7FFAF9773870
        public void OnCreated(){} // RVA: 0x7FFAF97738A0
        public void OnDeleted(){} // RVA: 0x7FFAF97738D0
        public void OnRenamed(){} // RVA: 0x7FFAF9773900
        public void DispatchEvents(){} // RVA: 0x7FFAF9773930
        public void Start(){} // RVA: 0x7FFAF9773E90
        public void Stop(){} // RVA: 0x7FFAF9773F00
        public void add_Changed(){} // RVA: 0x7FFAF9773F70
        public void remove_Changed(){} // RVA: 0x7FFAF9774060
        public void add_Created(){} // RVA: 0x7FFAF9774150
        public void remove_Created(){} // RVA: 0x7FFAF9774240
        public void add_Deleted(){} // RVA: 0x7FFAF9774330
        public void remove_Deleted(){} // RVA: 0x7FFAF9774420
        public void .cctor(){} // RVA: 0x7FFAF9774510
    }

    public class IFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7FFAF2AD4B10
        public void StopDispatching(){} // RVA: 0x7FFAF2AD4B10
        public void Dispose(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IODescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9774820
        public void get_Description(){} // RVA: 0x7FFAF2DA8380
    }

    public class IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x5
    }

    public class InvalidDataException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x4
    }

    public class MemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88D58B0 | overloaded x7
        public void get_CanRead(){} // RVA: 0x7FFAF3FC4560
        public void get_CanSeek(){} // RVA: 0x7FFAF3FC4560
        public void get_CanWrite(){} // RVA: 0x7FFAF310EEC0
        public void EnsureNotClosed(){} // RVA: 0x7FFAF88D5AD0
        public void EnsureWriteable(){} // RVA: 0x7FFAF88D5B10
        public void Dispose(){} // RVA: 0x7FFAF88D5B60
        public void EnsureCapacity(){} // RVA: 0x7FFAF88D5BE0
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void FlushAsync(){} // RVA: 0x7FFAF88D5CA0
        public void GetBuffer(){} // RVA: 0x7FFAF88D5DD0
        public void InternalGetBuffer(){} // RVA: 0x7FFAF2DBB130
        public void InternalGetPosition(){} // RVA: 0x7FFAF2F76670
        public void InternalReadInt32(){} // RVA: 0x7FFAF88D5E40
        public void InternalEmulateRead(){} // RVA: 0x7FFAF88D5F20
        public void get_Capacity(){} // RVA: 0x7FFAF88D5F80
        public void set_Capacity(){} // RVA: 0x7FFAF88D5FC0
        public void get_Length(){} // RVA: 0x7FFAF88D61A0
        public void get_Position(){} // RVA: 0x7FFAF88D61F0
        public void set_Position(){} // RVA: 0x7FFAF88D6240
        public void Read(){} // RVA: 0x7FFAF88D65D0 | overloaded x2
        public void ReadAsync(){} // RVA: 0x7FFAF88D6BB0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAF88D6FD0
        public void CopyTo(){} // RVA: 0x7FFAF88D7050
        public void CopyToAsync(){} // RVA: 0x7FFAF88D71E0
        public void Seek(){} // RVA: 0x7FFAF88D7500
        public void SetLength(){} // RVA: 0x7FFAF88D7760
        public void ToArray(){} // RVA: 0x7FFAF88D78D0
        public void Write(){} // RVA: 0x7FFAF88D7C80 | overloaded x2
        public void WriteAsync(){} // RVA: 0x7FFAF88D8210 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAF88D8560
        public void WriteTo(){} // RVA: 0x7FFAF88D8680
    }

    public class MonoIO
    {
        public object IsCaseSensitive;

        // ── Methods ──
        public void GetException(){} // RVA: 0x7FFAF890FAA0 | overloaded x2
        public void GetCurrentDirectory(){} // RVA: 0x7FFAF8910310
        public void GetFileType(){} // RVA: 0x7FFAF89103B0 | overloaded x2
        public void FindCloseFile(){} // RVA: 0x7FFAF89104C0
        public void Open(){} // RVA: 0x7FFAF8910730 | overloaded x2
        public void Cancel_internal(){} // RVA: 0x7FFAF8910880
        public void Cancel(){} // RVA: 0x7FFAF89108A0
        public void Close(){} // RVA: 0x7FFAF89109C0
        public void Read(){} // RVA: 0x7FFAF8910A90 | overloaded x2
        public void Write(){} // RVA: 0x7FFAF8910CB0 | overloaded x2
        public void Seek(){} // RVA: 0x7FFAF8910E60 | overloaded x2
        public void GetLength(){} // RVA: 0x7FFAF8911010 | overloaded x2
        public void SetLength(){} // RVA: 0x7FFAF8911200 | overloaded x2
        public void get_ConsoleOutput(){} // RVA: 0x7FFAF89113D0
        public void get_ConsoleInput(){} // RVA: 0x7FFAF89113E0
        public void get_ConsoleError(){} // RVA: 0x7FFAF89113F0
        public void CreatePipe(){} // RVA: 0x7FFAF8911400
        public void DuplicateHandle(){} // RVA: 0x7FFAF8911500
        public void get_VolumeSeparatorChar(){} // RVA: 0x7FFAF89115F0
        public void get_DirectorySeparatorChar(){} // RVA: 0x7FFAF4BC1A20
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x7FFAF8911600
        public void get_PathSeparator(){} // RVA: 0x7FFAF8911610
        public void DumpHandles(){} // RVA: 0x7FFAF884BDA0
        public void RemapPath(){} // RVA: 0x7FFAF8911620
        public void .cctor(){} // RVA: 0x7FFAF8911630
    }

    public class MonoIOStat
    {
    }

    public class MonoLinqHelper
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFAF2ABCE50
    }

    public class NullFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7FFAF2D8D310
        public void StopDispatching(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void GetInstance(){} // RVA: 0x7FFAF9774950
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Path
    {
        // ── Methods ──
        public void ChangeExtension(){} // RVA: 0x7FFAF89116B0
        public void Combine(){} // RVA: 0x7FFAF8915DD0 | overloaded x4
        public void CleanPath(){} // RVA: 0x7FFAF8911C40
        public void GetDirectoryName(){} // RVA: 0x7FFAF89125B0 | overloaded x2
        public void GetExtension(){} // RVA: 0x7FFAF8912690
        public void GetFileName(){} // RVA: 0x7FFAF8916010 | overloaded x2
        public void GetFileNameWithoutExtension(){} // RVA: 0x7FFAF8912910
        public void GetFullPath(){} // RVA: 0x7FFAF8912970
        public void GetFullPathInternal(){} // RVA: 0x7FFAF89129C0
        public void GetFullPathName(){} // RVA: 0x7FFAF8912B00 | overloaded x2
        public void WindowsDriveAdjustment(){} // RVA: 0x7FFAF8912DB0
        public void InsecureGetFullPath(){} // RVA: 0x7FFAF8912FF0
        public void IsDirectorySeparator(){} // RVA: 0x7FFAF8913620
        public void GetPathRoot(){} // RVA: 0x7FFAF89136B0
        public void GetTempPath(){} // RVA: 0x7FFAF8913B50
        public void get_temp_path(){} // RVA: 0x7FFAF8913DC0
        public void IsPathRooted(){} // RVA: 0x7FFAF8914040 | overloaded x2
        public void GetInvalidFileNameChars(){} // RVA: 0x7FFAF8914280
        public void GetInvalidPathChars(){} // RVA: 0x7FFAF89142F0
        public void GetRandomFileName(){} // RVA: 0x7FFAF8914360
        public void findExtension(){} // RVA: 0x7FFAF8914500
        public void .cctor(){} // RVA: 0x7FFAF89145B0
        public void GetServerAndShare(){} // RVA: 0x7FFAF8914A70
        public void SameRoot(){} // RVA: 0x7FFAF8914CD0
        public void CanonicalizePath(){} // RVA: 0x7FFAF8915030
        public void Join(){} // RVA: 0x7FFAF8916280 | overloaded x2
        public void JoinInternal(){} // RVA: 0x7FFAF8916AF0 | overloaded x2
        public void GetRelativePath(){} // RVA: 0x7FFAF89171D0 | overloaded x2
        public void get_StringComparison(){} // RVA: 0x7FFAF8917920
        public void get_IsCaseSensitive(){} // RVA: 0x7FFAF89179D0
        public void get_IsWindows(){} // RVA: 0x7FFAF8917A40
    }

    public class PathInternal
    {
        public object CanRead;

        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x7FFAF88D8750
        public void EndsWithPeriodOrSpace(){} // RVA: 0x7FFAF88D8770
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x7FFAF88D87C0
        public void EnsureExtendedPrefix(){} // RVA: 0x7FFAF88D8870
        public void IsDevice(){} // RVA: 0x7FFAF88D8AC0
        public void IsDeviceUNC(){} // RVA: 0x7FFAF88D8C90
        public void IsExtended(){} // RVA: 0x7FFAF88D8D80
        public void GetRootLength(){} // RVA: 0x7FFAF88D8E10
        public void IsDirectorySeparator(){} // RVA: 0x7FFAF88D9200
        public void IsEffectivelyEmpty(){} // RVA: 0x7FFAF88D9220
        public void EndsInDirectorySeparator(){} // RVA: 0x7FFAF88D92A0
        public void StartsWithDirectorySeparator(){} // RVA: 0x7FFAF88D9340
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7FFAF88D95F0 | overloaded x2
        public void IsRoot(){} // RVA: 0x7FFAF88D97D0
        public void GetCommonPathLength(){} // RVA: 0x7FFAF88D9840
        public void EqualStartingCharacterCount(){} // RVA: 0x7FFAF88D9A80
        public void AreRootsEqual(){} // RVA: 0x7FFAF88D9BA0
        public void get_IsCaseSensitive(){} // RVA: 0x7FFAF88D9D00
        public void GetIsCaseSensitive(){} // RVA: 0x7FFAF88D9D60
        public void IsPartiallyQualified(){} // RVA: 0x7FFAF2D8D320
        public void .cctor(){} // RVA: 0x7FFAF88D9F80
    }

    public class PathInternal
    {
        public object AllowNew;

        // ── Methods ──
        public void get_StringComparison(){} // RVA: 0x7FFAF976E710
        public void GetIsCaseSensitive(){} // RVA: 0x7FFAF976E770
        public void .cctor(){} // RVA: 0x7FFAF976E990
    }

    public class PathTooLongException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class PinnedBufferMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88DA040
        public void Read(){} // RVA: 0x7FFAF88DA190
        public void Write(){} // RVA: 0x7FFAF88DA1B0
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void Dispose(){} // RVA: 0x7FFAF88DA1D0
    }

    public class RenamedEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF976E9E0
    }

    public class RenamedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45AE240
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class SearchPattern2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9774B30 | overloaded x2
        public void get_HasWildcard(){} // RVA: 0x7FFAF31693D0
        public void Compile(){} // RVA: 0x7FFAF9774B90
        public void .cctor(){} // RVA: 0x7FFAF9774FC0
    }

    public class Stream
    {
        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFAF88FE6A0
        public void get_CanRead(){} // RVA: 0x7FFAF2ABDBE0
        public void get_CanSeek(){} // RVA: 0x7FFAF2ABDBE0
        public void get_CanTimeout(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Length(){} // RVA: 0x7FFAF2ABCD60
        public void get_Position(){} // RVA: 0x7FFAF2ABCD60
        public void set_Position(){} // RVA: 0x7FFAF2AD4CC0
        public void get_ReadTimeout(){} // RVA: 0x7FFAF88FE800
        public void set_ReadTimeout(){} // RVA: 0x7FFAF88FE850
        public void get_WriteTimeout(){} // RVA: 0x7FFAF88FE8A0
        public void set_WriteTimeout(){} // RVA: 0x7FFAF88FE8F0
        public void CopyToAsync(){} // RVA: 0x7FFAF88FEA60 | overloaded x3
        public void CopyToAsyncInternal(){} // RVA: 0x7FFAF88FEAC0
        public void CopyTo(){} // RVA: 0x7FFAF88FED90 | overloaded x2
        public void GetCopyBufferSize(){} // RVA: 0x7FFAF88FEF60
        public void Close(){} // RVA: 0x7FFAF88FF060
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAF2AD4A50
        public void FlushAsync(){} // RVA: 0x7FFAF88FF130 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFAF88FF390
        public void BeginReadInternal(){} // RVA: 0x7FFAF88FF3D0
        public void EndRead(){} // RVA: 0x7FFAF88FF660
        public void ReadAsync(){} // RVA: 0x7FFAF88FFA30 | overloaded x3
        public void BeginEndReadAsync(){} // RVA: 0x7FFAF88FFD00
        public void BeginWrite(){} // RVA: 0x7FFAF8900060
        public void BeginWriteInternal(){} // RVA: 0x7FFAF89000A0
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7FFAF8900330
        public void RunReadWriteTask(){} // RVA: 0x7FFAF8900580
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFAF89006E0
        public void EndWrite(){} // RVA: 0x7FFAF8900760
        public void WriteAsync(){} // RVA: 0x7FFAF8900B30 | overloaded x3
        public void FinishWriteAsync(){} // RVA: 0x7FFAF8900F20
        public void BeginEndWriteAsync(){} // RVA: 0x7FFAF8901130
        public void Seek(){}
        public void SetLength(){} // RVA: 0x7FFAF2AD4CC0
        public void Read(){} // RVA: 0x7FFAF8901490 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAF8901730
        public void Write(){} // RVA: 0x7FFAF89017E0 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAF8901980
        public void BlockingBeginRead(){} // RVA: 0x7FFAF8901A10
        public void BlockingEndRead(){} // RVA: 0x7FFAF8901B50
        public void BlockingBeginWrite(){} // RVA: 0x7FFAF8901C70
        public void BlockingEndWrite(){} // RVA: 0x7FFAF8901DB0
        public void HasOverriddenBeginEndRead(){} // RVA: 0x7FFAF2E72850
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x7FFAF2E72850
        public void DisposeAsync(){} // RVA: 0x7FFAF8901ED0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8901F80
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x7FFAF8902070
    }

    public class StreamHelpers
    {
        // ── Methods ──
        public void ValidateCopyToArgs(){} // RVA: 0x7FFAF88DA260
    }

    public class StreamReader
    {
        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFAF88DA530
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFAF88DA5D0
        public void .ctor(){} // RVA: 0x7FFAF88DABD0 | overloaded x11
        public void Init(){} // RVA: 0x7FFAF88DB1B0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF8760AF0
        public void Dispose(){} // RVA: 0x7FFAF88DB210
        public void get_CurrentEncoding(){} // RVA: 0x7FFAF2DBB0C0
        public void get_BaseStream(){} // RVA: 0x7FFAF2D907C0
        public void get_LeaveOpen(){} // RVA: 0x7FFAF88DB4B0
        public void get_EndOfStream(){} // RVA: 0x7FFAF88DB4C0
        public void Peek(){} // RVA: 0x7FFAF88DB560
        public void Read(){} // RVA: 0x7FFAF88DB8C0 | overloaded x3
        public void ReadSpan(){} // RVA: 0x7FFAF88DB9D0
        public void ReadToEnd(){} // RVA: 0x7FFAF88DBC80
        public void CompressBuffer(){} // RVA: 0x7FFAF88DBDC0
        public void DetectEncoding(){} // RVA: 0x7FFAF88DBE00
        public void IsPreamble(){} // RVA: 0x7FFAF88DC3A0
        public void ReadBuffer(){} // RVA: 0x7FFAF88DCC40 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFAF88DD5F0
        public void ReadToEndAsync(){} // RVA: 0x7FFAF88DD850
        public void ReadToEndAsyncInternal(){} // RVA: 0x7FFAF88DDCD0
        public void ReadAsync(){} // RVA: 0x7FFAF88DDE70
        public void ReadAsyncInternal(){} // RVA: 0x7FFAF88DE1A0
        public void ReadBufferAsync(){} // RVA: 0x7FFAF88DE440
        public void DataAvailable(){} // RVA: 0x7FFAF88DE5F0
        public void .cctor(){} // RVA: 0x7FFAF88DE600
    }

    public class StreamWriter
    {
        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFAF88E1770
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFAF88E1810
        public void get_UTF8NoBOM(){} // RVA: 0x7FFAF88E1860
        public void .ctor(){} // RVA: 0x7FFAF88E1EE0 | overloaded x9
        public void Init(){} // RVA: 0x7FFAF88E21F0
        public void Close(){} // RVA: 0x7FFAF88E24C0
        public void Dispose(){} // RVA: 0x7FFAF88E2530
        public void DisposeAsync(){} // RVA: 0x7FFAF88E2860
        public void DisposeAsyncCore(){} // RVA: 0x7FFAF88E2AE0
        public void CloseStreamFromDispose(){} // RVA: 0x7FFAF88E2C80
        public void Flush(){} // RVA: 0x7FFAF88E2D50 | overloaded x2
        public void set_AutoFlush(){} // RVA: 0x7FFAF88E2F40
        public void get_BaseStream(){} // RVA: 0x7FFAF30E74D0
        public void get_LeaveOpen(){} // RVA: 0x7FFAF88E2F80
        public void get_Encoding(){} // RVA: 0x7FFAF2F476A0
        public void Write(){} // RVA: 0x7FFAF88E35A0 | overloaded x4
        public void WriteSpan(){} // RVA: 0x7FFAF88E3320
        public void WriteLine(){} // RVA: 0x7FFAF88E3620
        public void WriteAsync(){} // RVA: 0x7FFAF88E4090 | overloaded x3
        public void WriteAsyncInternal(){} // RVA: 0x7FFAF88E4430 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFAF88E4780
        public void FlushAsync(){} // RVA: 0x7FFAF88E4B20
        public void set_CharPos_Prop(){} // RVA: 0x7FFAF349AAE0
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x7FFAF3BFF200
        public void FlushAsyncInternal(){} // RVA: 0x7FFAF88E4ED0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF88E52C0
    }

    public class StringReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8909800
        public void Close(){} // RVA: 0x7FFAF8760AF0
        public void Dispose(){} // RVA: 0x7FFAF89098F0
        public void Peek(){} // RVA: 0x7FFAF8909950
        public void Read(){} // RVA: 0x7FFAF8909A00 | overloaded x2
        public void ReadToEnd(){} // RVA: 0x7FFAF8909C10
        public void ReadLine(){} // RVA: 0x7FFAF8909C70
        public void ReadToEndAsync(){} // RVA: 0x7FFAF8909DA0
        public void ReadAsync(){} // RVA: 0x7FFAF8909E20
    }

    public class StringWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF890A220 | overloaded x4
        public void Close(){} // RVA: 0x7FFAF890A340
        public void Dispose(){} // RVA: 0x7FFAF2D9B7C0
        public void get_Encoding(){} // RVA: 0x7FFAF890A360
        public void GetStringBuilder(){} // RVA: 0x7FFAF30E74D0
        public void Write(){} // RVA: 0x7FFAF890A690 | overloaded x3
        public void WriteAsync(){} // RVA: 0x7FFAF890A850 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFAF890A940
        public void FlushAsync(){} // RVA: 0x7FFAF890AA30
        public void ToString(){} // RVA: 0x7FFAF890AAD0
    }

    public class TextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Close(){} // RVA: 0x7FFAF88E73C0
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Peek(){} // RVA: 0x7FFAF320BB20
        public void Read(){} // RVA: 0x7FFAF88E76B0 | overloaded x3
        public void ReadToEnd(){} // RVA: 0x7FFAF88E7950
        public void ReadLine(){} // RVA: 0x7FFAF88E7A90
        public void ReadToEndAsync(){} // RVA: 0x7FFAF88E7C10
        public void ReadAsync(){} // RVA: 0x7FFAF88E7DC0
        public void ReadAsyncInternal(){} // RVA: 0x7FFAF88E7FF0
        public void Synchronized(){} // RVA: 0x7FFAF88E8440
        public void .cctor(){} // RVA: 0x7FFAF88E8580
    }

    public class TextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88E96C0 | overloaded x2
        public void get_FormatProvider(){} // RVA: 0x7FFAF88E9840
        public void Close(){} // RVA: 0x7FFAF88E98E0
        public void Dispose(){} // RVA: 0x7FFAF88E9950 | overloaded x2
        public void DisposeAsync(){} // RVA: 0x7FFAF88E99C0
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void get_Encoding(){} // RVA: 0x7FFAF2ABCD60
        public void get_NewLine(){} // RVA: 0x7FFAF2DBB0C0
        public void Write(){} // RVA: 0x7FFAF88E9E40 | overloaded x8
        public void WriteLine(){} // RVA: 0x7FFAF88EA070 | overloaded x5
        public void WriteAsync(){} // RVA: 0x7FFAF88EA700 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFAF88EA9D0
        public void FlushAsync(){} // RVA: 0x7FFAF88EACA0
        public void Synchronized(){} // RVA: 0x7FFAF88EAF30
        public void .cctor(){} // RVA: 0x7FFAF88EB090
    }

    public class UnexceptionalStreamReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF89180A0
        public void .ctor(){} // RVA: 0x7FFAF8918190
        public void Peek(){} // RVA: 0x7FFAF8918220
        public void Read(){} // RVA: 0x7FFAF8918260 | overloaded x2
        public void CheckEOL(){} // RVA: 0x7FFAF89184D0
        public void ReadLine(){} // RVA: 0x7FFAF89186B0
        public void ReadToEnd(){} // RVA: 0x7FFAF89186D0
    }

    public class UnexceptionalStreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8918820
        public void Flush(){} // RVA: 0x7FFAF89188A0
        public void Write(){} // RVA: 0x7FFAF8918930 | overloaded x4
    }

    public class UnmanagedMemoryAccessor : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF432B6D0
        public void Initialize(){} // RVA: 0x7FFAF88EBF20
        public void get_Capacity(){} // RVA: 0x7FFAF2DBB0C0
        public void Dispose(){} // RVA: 0x7FFAF88EC360 | overloaded x2
        public void get_IsOpen(){} // RVA: 0x7FFAF2E6C230
    }

    public class UnmanagedMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88EC4B0 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFAF88EC540
        public void get_CanRead(){} // RVA: 0x7FFAF88EC7D0
        public void get_CanSeek(){} // RVA: 0x7FFAF2E2B240
        public void get_CanWrite(){} // RVA: 0x7FFAF88EC7F0
        public void Dispose(){} // RVA: 0x7FFAF88EC810
        public void EnsureNotClosed(){} // RVA: 0x7FFAF88EC820
        public void EnsureReadable(){} // RVA: 0x7FFAF88EC860
        public void EnsureWriteable(){} // RVA: 0x7FFAF88EC8B0
        public void Flush(){} // RVA: 0x7FFAF88EC820
        public void FlushAsync(){} // RVA: 0x7FFAF88EC900
        public void get_Length(){} // RVA: 0x7FFAF88ECA30
        public void get_Position(){} // RVA: 0x7FFAF88ECA80
        public void set_Position(){} // RVA: 0x7FFAF88ECAD0
        public void get_PositionPointer(){} // RVA: 0x7FFAF88ECB90
        public void Read(){} // RVA: 0x7FFAF88ECEB0 | overloaded x2
        public void ReadCore(){} // RVA: 0x7FFAF88ECFC0
        public void ReadAsync(){} // RVA: 0x7FFAF88ED5A0 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFAF88ED950
        public void Seek(){} // RVA: 0x7FFAF88EDAD0
        public void SetLength(){} // RVA: 0x7FFAF88EDCA0
        public void Write(){} // RVA: 0x7FFAF88EE0E0 | overloaded x2
        public void WriteCore(){} // RVA: 0x7FFAF88EE1F0
        public void WriteAsync(){} // RVA: 0x7FFAF88EE820 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFAF88EEB10
    }

    public class WaitForChangedResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF976EAD0
        public void set_ChangeType(){} // RVA: 0x7FFAF32E3580
        public void set_Name(){} // RVA: 0x7FFAF4418950
        public void set_OldName(){} // RVA: 0x7FFAF2D8EE30
        public void set_TimedOut(){} // RVA: 0x7FFAF2DA84F0
        public void .cctor(){} // RVA: 0x7FFAF976EBF0
    }

    public class Win32Marshal
    {
        // ── Methods ──
        public void GetExceptionForLastWin32Error(){} // RVA: 0x7FFAF88EF050
        public void GetExceptionForWin32Error(){} // RVA: 0x7FFAF88EF0B0
        public void MakeHRFromErrorCode(){} // RVA: 0x7FFAF88EF5F0
        public void TryMakeWin32ErrorCodeFromHR(){} // RVA: 0x7FFAF88EF610
        public void GetMessage(){} // RVA: 0x7FFAF86A1B00
    }

    public class __Error
    {
        // ── Methods ──
        public void EndOfFile(){} // RVA: 0x7FFAF8905540
        public void FileNotOpen(){} // RVA: 0x7FFAF89055A0
        public void ReaderClosed(){} // RVA: 0x7FFAF8905610
        public void GetDisplayablePath(){} // RVA: 0x7FFAF8905680
        public void WinIOError(){} // RVA: 0x7FFAF89057E0
        public void WriterClosed(){} // RVA: 0x7FFAF8906000
    }

}