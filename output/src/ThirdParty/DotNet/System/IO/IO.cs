// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 63
// Methods: 743

namespace ThirdParty.DotNet.System.IO
{
    public class BinaryReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68CF880
        public void get_BaseStream(){} // RVA: 0xB5DBF0
        public void Close(){} // RVA: 0x25CC6C0
        public void Dispose(){} // RVA: 0x25CC6C0
        public void Read(){} // RVA: 0x68D1260
        public void ReadBoolean(){} // RVA: 0x68CFDF0
        public void ReadByte(){} // RVA: 0x68CFE40
        public void ReadSByte(){} // RVA: 0x68CFE80
        public void ReadChar(){} // RVA: 0x68CFED0
        public void ReadInt16(){} // RVA: 0x68CFF00
        public void ReadUInt16(){} // RVA: 0x68CFF00
        public void ReadInt32(){} // RVA: 0x68CFF60
        public void ReadUInt32(){} // RVA: 0x68D0180
        public void ReadInt64(){} // RVA: 0x68D0200
        public void ReadUInt64(){} // RVA: 0x68D0200
        public void ReadSingle(){} // RVA: 0x68D0320
        public void ReadDouble(){} // RVA: 0x68D03A0
        public void ReadDecimal(){} // RVA: 0x68D0410
        public void ReadString(){} // RVA: 0x68D0680
        public void InternalReadChars(){} // RVA: 0x68D0970
        public void InternalReadOneChar(){} // RVA: 0x68D0D40
        public void ReadChars(){} // RVA: 0x68D1080
        public void ReadBytes(){} // RVA: 0x68D1450
        public void FillBuffer(){} // RVA: 0x68D1650
        public void Read7BitEncodedInt(){} // RVA: 0x68D17C0
    }

    public class BinaryWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68D1BA0
        public void Close(){} // RVA: 0x25CC6C0
        public void Dispose(){} // RVA: 0x25CC6C0
        public void get_BaseStream(){} // RVA: 0x68D1DE0
        public void Flush(){} // RVA: 0x6875EF0
        public void DisposeAsync(){} // RVA: 0x68D1E10
        public void Write(){} // RVA: 0x68D2A10
        public void Write7BitEncodedInt(){} // RVA: 0x68D2DF0
        public void .cctor(){} // RVA: 0x68D2E60
    }

    public class BufferedStream : Stream
    {
        // ── Methods ──
        public void LazyEnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x68BF010
        public void .ctor(){} // RVA: 0x68BF180
        public void EnsureNotClosed(){} // RVA: 0x68BF3D0
        public void EnsureCanSeek(){} // RVA: 0x68BF440
        public void EnsureCanRead(){} // RVA: 0x68BF4D0
        public void EnsureCanWrite(){} // RVA: 0x68BF560
        public void EnsureShadowBufferAllocated(){} // RVA: 0x68BF5F0
        public void EnsureBufferAllocated(){} // RVA: 0x68BF720
        public void get_CanRead(){} // RVA: 0x68BF7C0
        public void get_CanWrite(){} // RVA: 0x68BF7F0
        public void get_CanSeek(){} // RVA: 0x68BF820
        public void get_Length(){} // RVA: 0x68BF850
        public void get_Position(){} // RVA: 0x68BF8E0
        public void set_Position(){} // RVA: 0x68BF980
        public void DisposeAsync(){} // RVA: 0x68BFA50
        public void Dispose(){} // RVA: 0x68BFC00
        public void Flush(){} // RVA: 0x68BFDD0
        public void FlushAsync(){} // RVA: 0x68BFF10
        public void FlushAsyncInternal(){} // RVA: 0x68BFFE0
        public void FlushRead(){} // RVA: 0x68C0200
        public void ClearReadBufferBeforeWrite(){} // RVA: 0x68C0250
        public void FlushWrite(){} // RVA: 0x68C0320
        public void FlushWriteAsync(){} // RVA: 0x68C0390
        public void ReadFromBuffer(){} // RVA: 0x68C07A0
        public void Read(){} // RVA: 0x68C0B40
        public void LastSyncCompletedReadTask(){} // RVA: 0x68C0D50
        public void ReadAsync(){} // RVA: 0x68C1580
        public void ReadFromUnderlyingStreamAsync(){} // RVA: 0x68C1A30
        public void BeginRead(){} // RVA: 0x68C1D30
        public void EndRead(){} // RVA: 0x68C1DE0
        public void ReadByte(){} // RVA: 0x68C1E20
        public void ReadByteSlow(){} // RVA: 0x68C1F50
        public void WriteToBuffer(){} // RVA: 0x68C2120
        public void Write(){} // RVA: 0x68C26C0
        public void WriteAsync(){} // RVA: 0x68C2D30
        public void WriteToUnderlyingStreamAsync(){} // RVA: 0x68C30D0
        public void BeginWrite(){} // RVA: 0x68C33A0
        public void EndWrite(){} // RVA: 0x66E7340
        public void WriteByte(){} // RVA: 0x68C3450
        public void Seek(){} // RVA: 0x68C3520
        public void SetLength(){} // RVA: 0x68C36A0
        public void CopyTo(){} // RVA: 0x68C3780
        public void CopyToAsync(){} // RVA: 0x68C3830
        public void CopyToAsyncCore(){} // RVA: 0x68C3920
    }

    public class CStreamReader : StreamReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E1DE0
        public void Peek(){} // RVA: 0x68E16A0
        public void Read(){} // RVA: 0x68E2130
        public void ReadLine(){} // RVA: 0x68E22E0
        public void ReadToEnd(){} // RVA: 0x68E2310
    }

    public class CStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E2340
        public void Write(){} // RVA: 0x68E2AA0
        public void InternalWriteString(){} // RVA: 0x68E2A00
        public void InternalWriteChar(){} // RVA: 0x68E2A20
        public void InternalWriteChars(){} // RVA: 0x68E2A40
        public void WriteLine(){} // RVA: 0x68E2B10
    }

    public class DefaultWatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetInstance(){} // RVA: 0x771D950
        public void StartDispatching(){} // RVA: 0x771DB20
        public void StopDispatching(){} // RVA: 0x771E7F0
        public void Dispose(){} // RVA: 0xB43310
        public void Monitor(){} // RVA: 0x771ED50
        public void UpdateDataAndDispatch(){} // RVA: 0x771F6E0
        public void DispatchEvents(){} // RVA: 0x771F820
        public void DoFiles(){} // RVA: 0x771F980
        public void IterateAndModifyFilesData(){} // RVA: 0x771FD50
        public void CreateFileData(){} // RVA: 0x7720970
        public void .cctor(){} // RVA: 0x7720A90
    }

    public class DefaultWatcherData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x771D8C0
    }

    public class Directory : Object
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x68B8E70
        public void Exists(){} // RVA: 0x68B9010
        public void GetFiles(){} // RVA: 0x68B9260
        public void GetDirectories(){} // RVA: 0x68B9410
        public void GetFileSystemEntries(){} // RVA: 0x68B95B0
        public void InternalEnumeratePaths(){} // RVA: 0x68B9640
        public void EnumerateFiles(){} // RVA: 0x68B9A90
        public void GetDirectoryRoot(){} // RVA: 0x68B9AB0
        public void InternalGetDirectoryRoot(){} // RVA: 0x68B9C30
        public void GetCurrentDirectory(){} // RVA: 0x68B9CF0
        public void Delete(){} // RVA: 0x68B9D00
        public void InsecureGetCurrentDirectory(){} // RVA: 0x68B9DA0
    }

    public class DirectoryInfo : FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68BAD60
        public void Init(){} // RVA: 0x68B9FA0
        public void get_Parent(){} // RVA: 0x68BA4F0
        public void Create(){} // RVA: 0x68BA6C0
        public void GetFiles(){} // RVA: 0x68BA850
        public void EnumerateFiles(){} // RVA: 0x68BAA60
        public void InternalEnumerateInfos(){} // RVA: 0x68BAB00
        public void Delete(){} // RVA: 0x68BAD00
    }

    public class DirectoryNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class DisableMediaInsertionPrompt : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6899630
        public void Dispose(){} // RVA: 0x8B5E00
    }

    public class DriveNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class EndOfStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class EnumerationOptions : Object
    {
        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x68BAD80
        public void get_CompatibleRecursive(){} // RVA: 0x68BADE0
        public void get_Default(){} // RVA: 0x68BAE40
        public void .ctor(){} // RVA: 0x68BAEA0
        public void FromSearchOption(){} // RVA: 0x68BAEB0
        public void get_RecurseSubdirectories(){} // RVA: 0xC120A0
        public void set_RecurseSubdirectories(){} // RVA: 0xC120B0
        public void get_IgnoreInaccessible(){} // RVA: 0xDD5C50
        public void set_IgnoreInaccessible(){} // RVA: 0xDD7A00
        public void get_BufferSize(){} // RVA: 0x116A650
        public void get_AttributesToSkip(){} // RVA: 0xE62D00
        public void set_AttributesToSkip(){} // RVA: 0x1033F40
        public void get_MatchType(){} // RVA: 0x2244FB0
        public void set_MatchType(){} // RVA: 0x22735B0
        public void get_MatchCasing(){} // RVA: 0xFEAE90
        public void get_ReturnSpecialDirectories(){} // RVA: 0xB5E030
        public void .cctor(){} // RVA: 0x68BAFD0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void GetStreamIsClosed(){} // RVA: 0x689D9D0
        public void GetEndOfFile(){} // RVA: 0x689DA40
        public void GetReadNotSupported(){} // RVA: 0x689DAB0
        public void GetWriteNotSupported(){} // RVA: 0x689DB20
    }

    public class Error : Object
    {
        // ── Methods ──
        public void GetEndOfFile(){} // RVA: 0x70E0140
        public void GetPipeNotOpen(){} // RVA: 0x70E01B0
        public void GetReadNotSupported(){} // RVA: 0x70E0220
        public void GetSeekNotSupported(){} // RVA: 0x70E0290
        public void GetWriteNotSupported(){} // RVA: 0x70E0300
        public void GetOperationAborted(){} // RVA: 0x70E0370
    }

    public class ErrorEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class File : Object
    {
        // ── Methods ──
        public void OpenText(){} // RVA: 0x68BB1A0
        public void Copy(){} // RVA: 0x68BB280
        public void Create(){} // RVA: 0x68BB5B0
        public void Delete(){} // RVA: 0x68BB650
        public void Exists(){} // RVA: 0x68BB730
        public void Open(){} // RVA: 0x68BB8D0
        public void GetUtcDateTimeOffset(){} // RVA: 0x68BB970
        public void GetCreationTime(){} // RVA: 0x68BBAA0
        public void GetCreationTimeUtc(){} // RVA: 0x68BBBD0
        public void SetLastAccessTimeUtc(){} // RVA: 0x68BBD30
        public void GetLastWriteTime(){} // RVA: 0x68BBEF0
        public void GetLastWriteTimeUtc(){} // RVA: 0x68BC020
        public void GetAttributes(){} // RVA: 0x68BC180
        public void OpenRead(){} // RVA: 0x68BC260
        public void OpenWrite(){} // RVA: 0x68BC2F0
        public void ReadAllText(){} // RVA: 0x68BC370
        public void InternalReadAllText(){} // RVA: 0x68BC450
        public void WriteAllText(){} // RVA: 0x68BC730
        public void ReadAllBytes(){} // RVA: 0x68BC960
        public void ReadAllBytesUnknownLength(){} // RVA: 0x68BCBD0
        public void WriteAllBytes(){} // RVA: 0x68BD120
        public void InternalWriteAllBytes(){} // RVA: 0x68BD250
        public void ReadAllLines(){} // RVA: 0x68BD3B0
        public void InternalReadAllLines(){} // RVA: 0x68BD490
        public void Move(){} // RVA: 0x68BD6A0
    }

    public class FileData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FileInfo : FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68BAD60
        public void get_Length(){} // RVA: 0x68BDBE0
        public void get_DirectoryName(){} // RVA: 0x68BDC90
        public void get_Directory(){} // RVA: 0x68BDCF0
        public void get_IsReadOnly(){} // RVA: 0x68BDDA0
        public void set_IsReadOnly(){} // RVA: 0x68BDDC0
        public void CreateText(){} // RVA: 0x68BDE60
        public void AppendText(){} // RVA: 0x68BDED0
        public void Delete(){} // RVA: 0x68BDF40
        public void get_Name(){} // RVA: 0xBE58B0
    }

    public class FileInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FileInfo[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FileLoadException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689DEF0
        public void get_Message(){} // RVA: 0x689DC00
        public void get_FileName(){} // RVA: 0x1069350
        public void get_FusionLog(){} // RVA: 0x106A7D0
        public void ToString(){} // RVA: 0x689DCE0
        public void GetObjectData(){} // RVA: 0x689E090
        public void FormatFileLoadExceptionMessage(){} // RVA: 0x689E340
    }

    public class FileNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689E8F0
        public void get_Message(){} // RVA: 0x689E4A0
        public void SetMessageField(){} // RVA: 0x689E5C0
        public void get_FileName(){} // RVA: 0x1069350
        public void get_FusionLog(){} // RVA: 0x106A7D0
        public void ToString(){} // RVA: 0x689E6E0
        public void GetObjectData(){} // RVA: 0x689EA90
    }

    public class FileStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68D4650
        public void Init(){} // RVA: 0x68D50C0
        public void get_CanRead(){} // RVA: 0x68D5430
        public void get_CanWrite(){} // RVA: 0x68D5450
        public void get_CanSeek(){} // RVA: 0x68D5470
        public void get_Name(){} // RVA: 0xD33E60
        public void get_Length(){} // RVA: 0x68D5480
        public void get_Position(){} // RVA: 0x68D5620
        public void set_Position(){} // RVA: 0x68D57E0
        public void get_SafeFileHandle(){} // RVA: 0x68D5880
        public void ExposeHandle(){} // RVA: 0x68D58C0
        public void ReadByte(){} // RVA: 0x68D58F0
        public void WriteByte(){} // RVA: 0x68D5A60
        public void Read(){} // RVA: 0x68D5BC0
        public void ReadInternal(){} // RVA: 0x68D5F70
        public void BeginRead(){} // RVA: 0x68D6040
        public void EndRead(){} // RVA: 0x68D6460
        public void Write(){} // RVA: 0x68D6670
        public void WriteInternal(){} // RVA: 0x68D6940
        public void BeginWrite(){} // RVA: 0x68D6B80
        public void EndWrite(){} // RVA: 0x68D6FF0
        public void Seek(){} // RVA: 0x68D71F0
        public void SetLength(){} // RVA: 0x68D7500
        public void Flush(){} // RVA: 0x68D77A0
        public void Finalize(){} // RVA: 0x672B280
        public void Dispose(){} // RVA: 0x68D7820
        public void FlushAsync(){} // RVA: 0x68D7C00
        public void ReadAsync(){} // RVA: 0x68D7C80
        public void WriteAsync(){} // RVA: 0x68D7C90
        public void ReadSegment(){} // RVA: 0x68D7CA0
        public void WriteSegment(){} // RVA: 0x68D7DB0
        public void FlushBuffer(){} // RVA: 0x68D7E20
        public void FlushBufferIfDirty(){} // RVA: 0x68D8010
        public void RefillBuffer(){} // RVA: 0x68D8020
        public void ReadData(){} // RVA: 0x68D8060
        public void InitBuffer(){} // RVA: 0x68D81A0
        public void GetSecureFileName(){} // RVA: 0x68D8600
        public void .cctor(){} // RVA: 0x68D86F0
    }

    public class FileStreamAsyncResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68D8A60
        public void CBWrapper(){} // RVA: 0x68D8C90
        public void get_AsyncState(){} // RVA: 0xB5DBF0
        public void get_CompletedSynchronously(){} // RVA: 0xB68DF0
        public void get_AsyncWaitHandle(){} // RVA: 0xB700F0
        public void get_IsCompleted(){} // RVA: 0xB5DD50
    }

    public class FileSystem : Object
    {
        // ── Methods ──
        public void CopyFile(){} // RVA: 0x6899750
        public void CreateDirectory(){} // RVA: 0x6899A20
        public void DeleteFile(){} // RVA: 0x689A150
        public void DirectoryExists(){} // RVA: 0x689A230
        public void FillAttributeInfo(){} // RVA: 0x689A280
        public void FileExists(){} // RVA: 0x689A5A0
        public void GetAttributes(){} // RVA: 0x689A5F0
        public void GetCreationTime(){} // RVA: 0x689A660
        public void GetLastWriteTime(){} // RVA: 0x689A6F0
        public void MoveFile(){} // RVA: 0x689A780
        public void OpenHandle(){} // RVA: 0x689A7D0
        public void RemoveDirectory(){} // RVA: 0x689AA70
        public void GetFindData(){} // RVA: 0x689AB50
        public void IsNameSurrogateReparsePoint(){} // RVA: 0x689ACB0
        public void RemoveDirectoryRecursive(){} // RVA: 0x689ACD0
        public void RemoveDirectoryInternal(){} // RVA: 0x689B6B0
        public void SetAttributes(){} // RVA: 0x689B7E0
        public void SetLastAccessTime(){} // RVA: 0x689BA20
        public void UnityCreateDirectory(){} // RVA: 0x689BC60
        public void UnityRemoveDirectory(){} // RVA: 0x689BE20
        public void UnityGetFileAttributesEx(){} // RVA: 0x689C030
        public void UnitySetFileAttributes(){} // RVA: 0x689C290
        public void UnityCreateFile_IntPtr(){} // RVA: 0x689C430
        public void UnityCopyFile(){} // RVA: 0x689C5F0
        public void UnityDeleteFile(){} // RVA: 0x689C6C0
        public void UnityMoveFile(){} // RVA: 0x689C8D0
        public void UnityFindFirstFile(){} // RVA: 0x689CAF0
        public void UnityFindNextFile(){} // RVA: 0x689CF60
        public void BrokeredCreateDirectory(){} // RVA: 0x689D240
        public void BrokeredRemoveDirectory(){} // RVA: 0x689D240
        public void BrokeredGetFileAttributes(){} // RVA: 0x689D2A0
        public void BrokeredSetAttributes(){} // RVA: 0x689D2B0
        public void BrokeredOpenFile(){} // RVA: 0x689D310
        public void BrokeredCopyFile(){} // RVA: 0x689D450
        public void BrokeredMoveFile(){} // RVA: 0x689D530
        public void BrokeredDeleteFile(){} // RVA: 0x689D240
        public void BrokeredFindFirstFile(){} // RVA: 0x689D600
        public void BrokeredFindNextFile(){} // RVA: 0x689D740
        public void BrokeredSafeFindHandleDispose(){} // RVA: 0x689D7E0
        public void RemoveExtendedPathPrefix(){} // RVA: 0x689D7F0
    }

    public class FileSystemEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x771D000
        public void Combine(){} // RVA: 0x771D1A0
        public void get_ChangeType(){} // RVA: 0xB8F8F0
        public void get_FullPath(){} // RVA: 0xB700F0
    }

    public class FileSystemEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class FileSystemInfo : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68BE4E0
        public void Create(){} // RVA: 0x68BDF50
        public void Invalidate(){} // RVA: 0x68BD960
        public void Init(){} // RVA: 0x68BE150
        public void get_Attributes(){} // RVA: 0x68BE1A0
        public void set_Attributes(){} // RVA: 0x68BE1C0
        public void get_ExistsCore(){} // RVA: 0x68BE1F0
        public void get_CreationTimeCore(){} // RVA: 0x68BE280
        public void get_LastAccessTimeCore(){} // RVA: 0x68BE2C0
        public void get_LastWriteTimeCore(){} // RVA: 0x68BE300
        public void get_LengthCore(){} // RVA: 0x68BE340
        public void EnsureDataInitialized(){} // RVA: 0x68BE370
        public void Refresh(){} // RVA: 0x68BE3E0
        public void get_NormalizedPath(){} // RVA: 0x68BE410
        public void GetObjectData(){} // RVA: 0x68BE740
        public void get_FullName(){} // RVA: 0xBC1B30
        public void get_Name(){} // RVA: 0xBE58B0
        public void get_Exists(){} // RVA: 0x68BEAF0
        public void Delete(){} // RVA: 0x894290
        public void get_CreationTimeUtc(){} // RVA: 0x68BEB80
        public void get_LastAccessTime(){} // RVA: 0x68BEC30
        public void get_LastAccessTimeUtc(){} // RVA: 0x68BED60
        public void get_LastWriteTime(){} // RVA: 0x68BEE10
        public void get_LastWriteTimeUtc(){} // RVA: 0x68BEF40
        public void ToString(){} // RVA: 0x68BEFF0
    }

    public class FileSystemWatcher : Component
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7720CE0
        public void InitWatcher(){} // RVA: 0x7720FC0
        public void get_Waiting(){} // RVA: 0xE3F400
        public void set_Waiting(){} // RVA: 0xE3CFC0
        public void get_MangledFilter(){} // RVA: 0x7721540
        public void get_Pattern(){} // RVA: 0x77215E0
        public void get_FullPath(){} // RVA: 0x7721740
        public void set_EnableRaisingEvents(){} // RVA: 0x7721870
        public void set_Filter(){} // RVA: 0x7721920
        public void get_IncludeSubdirectories(){} // RVA: 0xD16660
        public void set_IncludeSubdirectories(){} // RVA: 0x7721BA0
        public void set_NotifyFilter(){} // RVA: 0x7721BE0
        public void get_Site(){} // RVA: 0xB465B0
        public void set_Site(){} // RVA: 0x7721C20
        public void BeginInit(){} // RVA: 0x1D9AEF0
        public void Dispose(){} // RVA: 0x7721D10
        public void Finalize(){} // RVA: 0x7721EB0
        public void EndInit(){} // RVA: 0x7721F30
        public void RaiseEvent(){} // RVA: 0x7721FE0
        public void OnChanged(){} // RVA: 0x7722370
        public void OnCreated(){} // RVA: 0x77223A0
        public void OnDeleted(){} // RVA: 0x77223D0
        public void OnRenamed(){} // RVA: 0x7722400
        public void DispatchEvents(){} // RVA: 0x7722430
        public void Start(){} // RVA: 0x7722990
        public void Stop(){} // RVA: 0x7722A00
        public void add_Changed(){} // RVA: 0x7722A70
        public void remove_Changed(){} // RVA: 0x7722B70
        public void add_Created(){} // RVA: 0x7722C70
        public void remove_Created(){} // RVA: 0x7722D70
        public void add_Deleted(){} // RVA: 0x7722E70
        public void remove_Deleted(){} // RVA: 0x7722F70
        public void .cctor(){} // RVA: 0x7723070
    }

    public class IFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x894320
        public void StopDispatching(){} // RVA: 0x894320
        public void Dispose(){} // RVA: 0x894320
    }

    public class IODescriptionAttribute : DescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7723380
        public void get_Description(){} // RVA: 0xB5DBF0
    }

    public class IOException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class InvalidDataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class MemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689F190
        public void get_CanRead(){} // RVA: 0x1DE3FA0
        public void get_CanSeek(){} // RVA: 0x1DE3FA0
        public void get_CanWrite(){} // RVA: 0xEEA010
        public void EnsureNotClosed(){} // RVA: 0x689F3B0
        public void EnsureWriteable(){} // RVA: 0x689F3F0
        public void Dispose(){} // RVA: 0x689F440
        public void EnsureCapacity(){} // RVA: 0x689F4C0
        public void Flush(){} // RVA: 0xB43310
        public void FlushAsync(){} // RVA: 0x689F580
        public void GetBuffer(){} // RVA: 0x689F6B0
        public void InternalGetBuffer(){} // RVA: 0xB70160
        public void InternalGetPosition(){} // RVA: 0xE9CE60
        public void InternalReadInt32(){} // RVA: 0x689F720
        public void InternalEmulateRead(){} // RVA: 0x689F810
        public void get_Capacity(){} // RVA: 0x689F870
        public void set_Capacity(){} // RVA: 0x689F8B0
        public void get_Length(){} // RVA: 0x689FA90
        public void get_Position(){} // RVA: 0x689FAE0
        public void set_Position(){} // RVA: 0x689FB30
        public void Read(){} // RVA: 0x689FED0
        public void ReadAsync(){} // RVA: 0x68A0480
        public void ReadByte(){} // RVA: 0x68A08A0
        public void CopyTo(){} // RVA: 0x68A0920
        public void CopyToAsync(){} // RVA: 0x68A0A70
        public void Seek(){} // RVA: 0x68A0D40
        public void SetLength(){} // RVA: 0x68A0F90
        public void ToArray(){} // RVA: 0x68A1100
        public void Write(){} // RVA: 0x68A14C0
        public void WriteAsync(){} // RVA: 0x68A1A10
        public void WriteByte(){} // RVA: 0x68A1D60
        public void WriteTo(){} // RVA: 0x68A1E80
    }

    public class MonoIO : Object
    {
        // ── Methods ──
        public void GetException(){} // RVA: 0x68D8E50
        public void GetCurrentDirectory(){} // RVA: 0x68D96C0
        public void GetFileType(){} // RVA: 0x68D9770
        public void FindCloseFile(){} // RVA: 0x68D9880
        public void Open(){} // RVA: 0x68D9AE0
        public void Cancel_internal(){} // RVA: 0x68D9C40
        public void Cancel(){} // RVA: 0x68D9C60
        public void Close(){} // RVA: 0x68D9D80
        public void Read(){} // RVA: 0x68D9E50
        public void Write(){} // RVA: 0x68DA070
        public void Seek(){} // RVA: 0x68DA220
        public void GetLength(){} // RVA: 0x68DA3D0
        public void SetLength(){} // RVA: 0x68DA5C0
        public void get_ConsoleOutput(){} // RVA: 0x68DA790
        public void get_ConsoleInput(){} // RVA: 0x68DA7A0
        public void get_ConsoleError(){} // RVA: 0x68DA7B0
        public void CreatePipe(){} // RVA: 0x68DA7C0
        public void DuplicateHandle(){} // RVA: 0x68DA8D0
        public void get_VolumeSeparatorChar(){} // RVA: 0x68DAA00
        public void get_DirectorySeparatorChar(){} // RVA: 0x2AFF570
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x68DAA10
        public void get_PathSeparator(){} // RVA: 0x68DAA20
        public void DumpHandles(){} // RVA: 0x6814ED0
        public void RemapPath(){} // RVA: 0x68DAA30
        public void .cctor(){} // RVA: 0x68DAA40
    }

    public class MonoLinqHelper : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x31720B0
    }

    public class NullFileWatcher : Object
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0xB43310
        public void StopDispatching(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void GetInstance(){} // RVA: 0x77234B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Path : Object
    {
        // ── Methods ──
        public void ChangeExtension(){} // RVA: 0x68DAAC0
        public void Combine(){} // RVA: 0x68DF2A0
        public void CleanPath(){} // RVA: 0x68DB050
        public void GetDirectoryName(){} // RVA: 0x68DBA90
        public void GetExtension(){} // RVA: 0x68DBB70
        public void GetFileName(){} // RVA: 0x68DF4E0
        public void GetFileNameWithoutExtension(){} // RVA: 0x68DBDE0
        public void GetFullPath(){} // RVA: 0x68DBE40
        public void GetFullPathInternal(){} // RVA: 0x68DBE90
        public void GetFullPathName(){} // RVA: 0x68DBFD0
        public void WindowsDriveAdjustment(){} // RVA: 0x68DC290
        public void InsecureGetFullPath(){} // RVA: 0x68DC4C0
        public void IsDirectorySeparator(){} // RVA: 0x68DCB10
        public void GetPathRoot(){} // RVA: 0x68DCBA0
        public void GetTempPath(){} // RVA: 0x68DD030
        public void get_temp_path(){} // RVA: 0x68DD2C0
        public void IsPathRooted(){} // RVA: 0x68DD550
        public void GetInvalidFileNameChars(){} // RVA: 0x68DD790
        public void GetInvalidPathChars(){} // RVA: 0x68DD800
        public void GetRandomFileName(){} // RVA: 0x68DD870
        public void findExtension(){} // RVA: 0x68DDA30
        public void .cctor(){} // RVA: 0x68DDAF0
        public void GetServerAndShare(){} // RVA: 0x68DDF70
        public void SameRoot(){} // RVA: 0x68DE1D0
        public void CanonicalizePath(){} // RVA: 0x68DE520
        public void Join(){} // RVA: 0x68DF740
        public void JoinInternal(){} // RVA: 0x68DFFA0
        public void GetRelativePath(){} // RVA: 0x68E0650
        public void get_StringComparison(){} // RVA: 0x68E0DA0
        public void get_IsCaseSensitive(){} // RVA: 0x68E0E50
        public void get_IsWindows(){} // RVA: 0x68E0EC0
    }

    public class PathInternal : Object
    {
        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x68A1F50
        public void EndsWithPeriodOrSpace(){} // RVA: 0x68A1F70
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x68A1FC0
        public void EnsureExtendedPrefix(){} // RVA: 0x68A2070
        public void IsDevice(){} // RVA: 0x68A22C0
        public void IsDeviceUNC(){} // RVA: 0x68A2490
        public void IsExtended(){} // RVA: 0x68A2580
        public void GetRootLength(){} // RVA: 0x68A2610
        public void IsDirectorySeparator(){} // RVA: 0x68A2A00
        public void IsEffectivelyEmpty(){} // RVA: 0x68A2A20
        public void EndsInDirectorySeparator(){} // RVA: 0x68A2AA0
        public void StartsWithDirectorySeparator(){} // RVA: 0x68A2B40
        public void TrimEndingDirectorySeparator(){} // RVA: 0x68A2DF0
        public void IsRoot(){} // RVA: 0x68A2FD0
        public void GetCommonPathLength(){} // RVA: 0x68A3040
        public void EqualStartingCharacterCount(){} // RVA: 0x68A3260
        public void AreRootsEqual(){} // RVA: 0x68A3360
        public void get_IsCaseSensitive(){} // RVA: 0x68A34C0
        public void GetIsCaseSensitive(){} // RVA: 0x68A3520
        public void IsPartiallyQualified(){} // RVA: 0xB43320
        public void .cctor(){} // RVA: 0x68A3740
    }

    public class PathInternal : Object
    {
        // ── Methods ──
        public void get_StringComparison(){} // RVA: 0x771D310
        public void GetIsCaseSensitive(){} // RVA: 0x771D370
        public void .cctor(){} // RVA: 0x771D590
    }

    public class PathTooLongException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class PinnedBufferMemoryStream : UnmanagedMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68A3800
        public void Read(){} // RVA: 0x68A3950
        public void Write(){} // RVA: 0x68A3970
        public void Finalize(){} // RVA: 0x672B280
        public void Dispose(){} // RVA: 0x68A3990
    }

    public class RenamedEventArgs : FileSystemEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x771D5E0
    }

    public class RenamedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class SearchPattern2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7723690
        public void get_HasWildcard(){} // RVA: 0xF43F30
        public void Compile(){} // RVA: 0x77236F0
        public void .cctor(){} // RVA: 0x7723B20
    }

    public class Stream : MarshalByRefObject
    {
        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x68C7D90
        public void get_CanRead(){} // RVA: 0x87D280
        public void get_CanSeek(){} // RVA: 0x87D280
        public void get_CanTimeout(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x87D280
        public void get_Length(){} // RVA: 0x87C0A0
        public void get_Position(){} // RVA: 0x87C0A0
        public void set_Position(){} // RVA: 0x8943F0
        public void get_ReadTimeout(){} // RVA: 0x68C7EF0
        public void set_ReadTimeout(){} // RVA: 0x68C7F40
        public void get_WriteTimeout(){} // RVA: 0x68C7F90
        public void set_WriteTimeout(){} // RVA: 0x68C7FE0
        public void CopyToAsync(){} // RVA: 0x68C8150
        public void CopyToAsyncInternal(){} // RVA: 0x68C81B0
        public void CopyTo(){} // RVA: 0x68C8480
        public void GetCopyBufferSize(){} // RVA: 0x68C8650
        public void Close(){} // RVA: 0x68C8750
        public void Dispose(){} // RVA: 0xB43310
        public void Flush(){} // RVA: 0x894290
        public void FlushAsync(){} // RVA: 0x68C8820
        public void BeginRead(){} // RVA: 0x68C8A90
        public void BeginReadInternal(){} // RVA: 0x68C8AD0
        public void EndRead(){} // RVA: 0x68C8D70
        public void ReadAsync(){} // RVA: 0x68C9140
        public void BeginEndReadAsync(){} // RVA: 0x68C9410
        public void BeginWrite(){} // RVA: 0x68C9770
        public void BeginWriteInternal(){} // RVA: 0x68C97B0
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x68C9A50
        public void RunReadWriteTask(){} // RVA: 0x68C9CA0
        public void FinishTrackingAsyncOperation(){} // RVA: 0x68C9E00
        public void EndWrite(){} // RVA: 0x68C9E80
        public void WriteAsync(){} // RVA: 0x68CA250
        public void FinishWriteAsync(){} // RVA: 0x68CA650
        public void BeginEndWriteAsync(){} // RVA: 0x68CA860
        public void Seek(){} // RVA: 0x881DE0
        public void SetLength(){} // RVA: 0x8943F0
        public void Read(){} // RVA: 0x68CABC0
        public void ReadByte(){} // RVA: 0x68CAE70
        public void Write(){} // RVA: 0x68CAF20
        public void WriteByte(){} // RVA: 0x68CB0D0
        public void BlockingBeginRead(){} // RVA: 0x68CB160
        public void BlockingEndRead(){} // RVA: 0x68CB2A0
        public void BlockingBeginWrite(){} // RVA: 0x68CB3C0
        public void BlockingEndWrite(){} // RVA: 0x68CB500
        public void HasOverriddenBeginEndRead(){} // RVA: 0xC2E4C0
        public void HasOverriddenBeginEndWrite(){} // RVA: 0xC2E4C0
        public void DisposeAsync(){} // RVA: 0x68CB620
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x68CB6D0
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x68CB7C0
    }

    public class StreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateCopyToArgs(){} // RVA: 0x68A3A20
    }

    public class StreamReader : TextReader
    {
        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x68A3CE0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x68A3D80
        public void .ctor(){} // RVA: 0x68A4380
        public void Init(){} // RVA: 0x68A4970
        public void Close(){} // RVA: 0x6729490
        public void Dispose(){} // RVA: 0x68A49D0
        public void get_CurrentEncoding(){} // RVA: 0xB700F0
        public void get_BaseStream(){} // RVA: 0xB465B0
        public void get_LeaveOpen(){} // RVA: 0x68A4C60
        public void get_EndOfStream(){} // RVA: 0x68A4C70
        public void Peek(){} // RVA: 0x68A4D10
        public void Read(){} // RVA: 0x68A5070
        public void ReadSpan(){} // RVA: 0x68A5140
        public void ReadToEnd(){} // RVA: 0x68A53F0
        public void CompressBuffer(){} // RVA: 0x68A5530
        public void DetectEncoding(){} // RVA: 0x68A5570
        public void IsPreamble(){} // RVA: 0x68A5B10
        public void ReadBuffer(){} // RVA: 0x68A63D0
        public void ReadLine(){} // RVA: 0x68A6D90
        public void ReadToEndAsync(){} // RVA: 0x68A7010
        public void ReadToEndAsyncInternal(){} // RVA: 0x68A7460
        public void ReadAsync(){} // RVA: 0x68A7600
        public void ReadAsyncInternal(){} // RVA: 0x68A7920
        public void ReadBufferAsync(){} // RVA: 0x68A7BC0
        public void DataAvailable(){} // RVA: 0x68A7D70
        public void .cctor(){} // RVA: 0x68A7D80
    }

    public class StreamWriter : TextWriter
    {
        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x68AB080
        public void ThrowAsyncIOInProgress(){} // RVA: 0x68AB120
        public void get_UTF8NoBOM(){} // RVA: 0x68AB170
        public void .ctor(){} // RVA: 0x68AB7F0
        public void Init(){} // RVA: 0x68ABB20
        public void Close(){} // RVA: 0x68ABDF0
        public void Dispose(){} // RVA: 0x68ABE60
        public void DisposeAsync(){} // RVA: 0x68AC170
        public void DisposeAsyncCore(){} // RVA: 0x68AC3C0
        public void CloseStreamFromDispose(){} // RVA: 0x68AC560
        public void Flush(){} // RVA: 0x68AC620
        public void set_AutoFlush(){} // RVA: 0x68AC7E0
        public void get_BaseStream(){} // RVA: 0xD33E60
        public void get_LeaveOpen(){} // RVA: 0x68AC820
        public void get_Encoding(){} // RVA: 0xD05CA0
        public void Write(){} // RVA: 0x68ACE40
        public void WriteSpan(){} // RVA: 0x68ACBC0
        public void WriteLine(){} // RVA: 0x68ACEC0
        public void WriteAsync(){} // RVA: 0x68AD8E0
        public void WriteAsyncInternal(){} // RVA: 0x68ADC70
        public void WriteLineAsync(){} // RVA: 0x68ADFB0
        public void FlushAsync(){} // RVA: 0x68AE340
        public void set_CharPos_Prop(){} // RVA: 0x12BB640
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x1A194B0
        public void FlushAsyncInternal(){} // RVA: 0x68AE6C0
        public void .cctor(){} // RVA: 0x68AEAC0
    }

    public class Stream[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class StringReader : TextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68D2F10
        public void Close(){} // RVA: 0x6729490
        public void Dispose(){} // RVA: 0x68D3000
        public void Peek(){} // RVA: 0x68D3060
        public void Read(){} // RVA: 0x68D3110
        public void ReadToEnd(){} // RVA: 0x68D3320
        public void ReadLine(){} // RVA: 0x68D3370
        public void ReadToEndAsync(){} // RVA: 0x68D3490
        public void ReadAsync(){} // RVA: 0x68D3510
    }

    public class StringWriter : TextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68D3910
        public void Close(){} // RVA: 0x68D3A30
        public void Dispose(){} // RVA: 0xB51F70
        public void get_Encoding(){} // RVA: 0x68D3A50
        public void GetStringBuilder(){} // RVA: 0xD33E60
        public void Write(){} // RVA: 0x68D3D80
        public void WriteAsync(){} // RVA: 0x68D3F40
        public void WriteLineAsync(){} // RVA: 0x68D4030
        public void FlushAsync(){} // RVA: 0x68D4120
        public void ToString(){} // RVA: 0x68D41C0
    }

    public class TextReader : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Close(){} // RVA: 0x68B0BF0
        public void Dispose(){} // RVA: 0xB43310
        public void Peek(){} // RVA: 0xFE6B70
        public void Read(){} // RVA: 0x68B0EF0
        public void ReadToEnd(){} // RVA: 0x68B1190
        public void ReadLine(){} // RVA: 0x68B12E0
        public void ReadToEndAsync(){} // RVA: 0x68B1460
        public void ReadAsync(){} // RVA: 0x68B1610
        public void ReadAsyncInternal(){} // RVA: 0x68B1840
        public void Synchronized(){} // RVA: 0x68B1C90
        public void .cctor(){} // RVA: 0x68B1DD0
    }

    public class TextWriter : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68B2F10
        public void get_FormatProvider(){} // RVA: 0x68B3090
        public void Close(){} // RVA: 0x68B3130
        public void Dispose(){} // RVA: 0x68B31A0
        public void DisposeAsync(){} // RVA: 0x68B3210
        public void Flush(){} // RVA: 0xB43310
        public void get_Encoding(){} // RVA: 0x87C0A0
        public void get_NewLine(){} // RVA: 0xB700F0
        public void Write(){} // RVA: 0x68B36A0
        public void WriteLine(){} // RVA: 0x68B38D0
        public void WriteAsync(){} // RVA: 0x68B3F80
        public void WriteLineAsync(){} // RVA: 0x68B4260
        public void FlushAsync(){} // RVA: 0x68B4540
        public void Synchronized(){} // RVA: 0x68B47D0
        public void .cctor(){} // RVA: 0x68B4930
    }

    public class UnexceptionalStreamReader : StreamReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x68E1520
        public void .ctor(){} // RVA: 0x68E1610
        public void Peek(){} // RVA: 0x68E16A0
        public void Read(){} // RVA: 0x68E16E0
        public void CheckEOL(){} // RVA: 0x68E1950
        public void ReadLine(){} // RVA: 0x68E1B40
        public void ReadToEnd(){} // RVA: 0x68E1B60
    }

    public class UnexceptionalStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E1CB0
        public void Flush(){} // RVA: 0x68E1D30
        public void Write(){} // RVA: 0x68E1DC0
    }

    public class UnmanagedMemoryAccessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2141350
        public void Initialize(){} // RVA: 0x68B57C0
        public void get_Capacity(){} // RVA: 0xB700F0
        public void Dispose(){} // RVA: 0x68B5C10
        public void get_IsOpen(){} // RVA: 0xC27380
    }

    public class UnmanagedMemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68B5D60
        public void Initialize(){} // RVA: 0x68B5DF0
        public void get_CanRead(){} // RVA: 0x68B6080
        public void get_CanSeek(){} // RVA: 0xBE2B30
        public void get_CanWrite(){} // RVA: 0x68B6090
        public void Dispose(){} // RVA: 0x68B60B0
        public void EnsureNotClosed(){} // RVA: 0x68B60C0
        public void EnsureReadable(){} // RVA: 0x68B6100
        public void EnsureWriteable(){} // RVA: 0x68B6150
        public void Flush(){} // RVA: 0x68B60C0
        public void FlushAsync(){} // RVA: 0x68B61A0
        public void get_Length(){} // RVA: 0x68B62D0
        public void get_Position(){} // RVA: 0x68B6320
        public void set_Position(){} // RVA: 0x68B6370
        public void get_PositionPointer(){} // RVA: 0x68B6430
        public void Read(){} // RVA: 0x68B6750
        public void ReadCore(){} // RVA: 0x68B6820
        public void ReadAsync(){} // RVA: 0x68B6DF0
        public void ReadByte(){} // RVA: 0x68B71B0
        public void Seek(){} // RVA: 0x68B7330
        public void SetLength(){} // RVA: 0x68B7500
        public void Write(){} // RVA: 0x68B7940
        public void WriteCore(){} // RVA: 0x68B7A10
        public void WriteAsync(){} // RVA: 0x68B8040
        public void WriteByte(){} // RVA: 0x68B8330
    }

    public class WaitForChangedResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x91F630
        public void set_ChangeType(){} // RVA: 0x29580
        public void set_Name(){} // RVA: 0x77E70
        public void set_OldName(){} // RVA: 0x7E3E0
        public void set_TimedOut(){} // RVA: 0x8C660
        public void .cctor(){} // RVA: 0x771D7F0
    }

    public class Win32Marshal : Object
    {
        // ── Methods ──
        public void GetExceptionForLastWin32Error(){} // RVA: 0x68B8840
        public void GetExceptionForWin32Error(){} // RVA: 0x68B88A0
        public void MakeHRFromErrorCode(){} // RVA: 0x68B8DE0
        public void TryMakeWin32ErrorCodeFromHR(){} // RVA: 0x68B8E00
        public void GetMessage(){} // RVA: 0x666A4D0
    }

    public class __Error : Object
    {
        // ── Methods ──
        public void EndOfFile(){} // RVA: 0x68CECA0
        public void FileNotOpen(){} // RVA: 0x68CED00
        public void ReaderClosed(){} // RVA: 0x68CED70
        public void GetDisplayablePath(){} // RVA: 0x68CEDE0
        public void WinIOError(){} // RVA: 0x68CEF30
        public void WriterClosed(){} // RVA: 0x68CF750
    }

}