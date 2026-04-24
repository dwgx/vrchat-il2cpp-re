// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 21
// Methods: 466

namespace ThirdParty.DotNet.System.IO
{
    public class DefaultWatcher : Object
    {
        public object watches; // 0x3753C670
        public object get_StringComparison; // 0xB422C3B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void StartDispatching(){} // RVA: 0x7ffaaee79650
        public void StopDispatching(){} // RVA: 0x7ffaaee7a380
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void Monitor(){} // RVA: 0x7ffaaee7a970
        public void UpdateDataAndDispatch(){} // RVA: 0x7ffaaee7b3a0
        public void DispatchEvents(){} // RVA: 0x7ffaaee7b4e0
        public void IterateAndModifyFilesData(){} // RVA: 0x7ffaaee7ba60
        public void CreateFileData(){} // RVA: 0x7ffaaee7c6a0
        public void .cctor(){} // RVA: 0x7ffaaee7c7c0
        // ── Binary Analysis Named ──
        public void GetInstance(){} // RVA: 0x7ffaaee79480
        public void DoFiles(){} // RVA: 0x7ffaaee7b680
    }

    public class DefaultWatcherData : Object
    {
        public object FileMask; // 0x3753CE90
        public object NoWildcards; // 0x3753CE90
        public object Files; // 0x3753CE90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaee793f0
    }

    public class DirectoryInfo : FileSystemInfo
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        public void Init(){} // RVA: 0x7ffaadff9040
        public void get_Parent(){} // RVA: 0x7ffaadff95c0
        public void Create(){} // RVA: 0x7ffaadff9790
        public void EnumerateFiles(){} // RVA: 0x7ffaadff9b30
        public void EnumerateFiles(){} // RVA: 0x7ffaadff9b30
        public void EnumerateFiles(){} // RVA: 0x7ffaadff9b30
        public void InternalEnumerateInfos(){} // RVA: 0x7ffaadff9bd0
        public void Delete(){} // RVA: 0x7ffaadff9dd0
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        // ── Binary Analysis Named ──
        public void GetFiles(){} // RVA: 0x7ffaadff9920
        public void GetFiles(){} // RVA: 0x7ffaadff9920
        public void GetFiles(){} // RVA: 0x7ffaadff9920
    }

    public class DisableMediaInsertionPrompt : ValueType
    {
        public object useUWPFallback; // 0x34FA24A0

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaadfd84d0
        public void Dispose(){} // RVA: 0x7ffaadfd8550
    }

    public class EnumerationOptions : Object
    {
        public object _default; // 0x34FA39A0, was: <Default>k__BackingField
        public object _bufferSize; // 0x34FA39A0, was: <BufferSize>k__BackingField
        public object _matchCasing; // 0x34FA39A0, was: <MatchCasing>k__BackingField

        // ── Original Methods ──
        public void get_Compatible(){} // RVA: 0x7ffaadff9e50
        public void get_CompatibleRecursive(){} // RVA: 0x7ffaadff9eb0
        public void get_Default(){} // RVA: 0x7ffaadff9f10
        public void .ctor(){} // RVA: 0x7ffaadff9f70
        public void FromSearchOption(){} // RVA: 0x7ffaadff9f80
        public void get_RecurseSubdirectories(){} // RVA: 0x7ffaa89fc5e0
        public void set_RecurseSubdirectories(){} // RVA: 0x7ffaa89fc5f0
        public void get_IgnoreInaccessible(){} // RVA: 0x7ffaa8b37c40
        public void set_IgnoreInaccessible(){} // RVA: 0x7ffaa919b040
        public void get_BufferSize(){} // RVA: 0x7ffaa8e046c0
        public void get_AttributesToSkip(){} // RVA: 0x7ffaa8b945a0
        public void set_AttributesToSkip(){} // RVA: 0x7ffaa9357830
        public void get_MatchType(){} // RVA: 0x7ffaa9e5ac10
        public void set_MatchType(){} // RVA: 0x7ffaa9e6a2e0
        public void get_MatchCasing(){} // RVA: 0x7ffaa8aeced0
        public void get_ReturnSpecialDirectories(){} // RVA: 0x7ffaa894d7c0
        public void .cctor(){} // RVA: 0x7ffaadffa0a0
    }

    public class FileData : Object
    {
        public object NotExists; // 0x3753D010

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class FileInfo : FileSystemInfo
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        public void get_Length(){} // RVA: 0x7ffaadffcc80
        public void get_DirectoryName(){} // RVA: 0x7ffaadffcd30
        public void get_Directory(){} // RVA: 0x7ffaadffcd90
        public void get_IsReadOnly(){} // RVA: 0x7ffaadffce40
        public void set_IsReadOnly(){} // RVA: 0x7ffaadffce60
        public void CreateText(){} // RVA: 0x7ffaadffceb0
        public void AppendText(){} // RVA: 0x7ffaadffcf20
        public void Delete(){} // RVA: 0x7ffaadffcf90
        public void .ctor(){} // RVA: 0x7ffaadff9e30
        public void get_Name(){} // RVA: 0x7ffaa89d30e0
    }

    public class FileStream : Stream
    {
        public object buf_recycle_lock; // 0x34FA0AB0
        public object safeHandle; // 0x34FA0AB0
        public object access; // 0x34FA0AB0
        public object canseek; // 0x34FA0AB0
        public object buf_size; // 0x34FA0AB0
        public object buf_start; // 0x34FA0AB0
        public object CanRead; // 0x1700096E
        public object CanWrite; // 0x1700096F
        public object CanSeek; // 0x17000970
        public object Name; // 0x17000971
        public object Length; // 0x17000972
        public object Position; // 0x17000973

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void .ctor(){} // RVA: 0x7ffaae0139c0
        public void Init(){} // RVA: 0x7ffaae014420
        public void get_CanRead(){} // RVA: 0x7ffaae014790
        public void get_CanWrite(){} // RVA: 0x7ffaae0147b0
        public void get_CanSeek(){} // RVA: 0x7ffaae0147d0
        public void get_Name(){} // RVA: 0x7ffaa8bfcc80
        public void get_Length(){} // RVA: 0x7ffaae0147e0
        public void get_Position(){} // RVA: 0x7ffaae014980
        public void set_Position(){} // RVA: 0x7ffaae014b40
        public void get_SafeFileHandle(){} // RVA: 0x7ffaae014be0
        public void ExposeHandle(){} // RVA: 0x7ffaae014c20
        public void ReadByte(){} // RVA: 0x7ffaae014c50
        public void WriteByte(){} // RVA: 0x7ffaae014dc0
        public void Read(){} // RVA: 0x7ffaae014f20
        public void ReadInternal(){} // RVA: 0x7ffaae0152d0
        public void EndRead(){} // RVA: 0x7ffaae0157f0
        public void Write(){} // RVA: 0x7ffaae015a00
        public void WriteInternal(){} // RVA: 0x7ffaae015cd0
        public void EndWrite(){} // RVA: 0x7ffaae0163b0
        public void Seek(){} // RVA: 0x7ffaae0165b0
        public void Flush(){} // RVA: 0x7ffaae016b60
        public void Finalize(){} // RVA: 0x7ffaade6b0a0
        public void Dispose(){} // RVA: 0x7ffaae016be0
        public void FlushAsync(){} // RVA: 0x7ffaae016ff0
        public void ReadAsync(){} // RVA: 0x7ffaae017070
        public void WriteAsync(){} // RVA: 0x7ffaae017080
        public void ReadSegment(){} // RVA: 0x7ffaae017090
        public void WriteSegment(){} // RVA: 0x7ffaae0171a0
        public void FlushBuffer(){} // RVA: 0x7ffaae017210
        public void FlushBufferIfDirty(){} // RVA: 0x7ffaae017400
        public void RefillBuffer(){} // RVA: 0x7ffaae017410
        public void ReadData(){} // RVA: 0x7ffaae017450
        public void InitBuffer(){} // RVA: 0x7ffaae017590
        public void .cctor(){} // RVA: 0x7ffaae017b10
        // ── Binary Analysis Named ──
        public void BeginRead(){} // RVA: 0x7ffaae0153a0
        public void BeginWrite(){} // RVA: 0x7ffaae015f10
        public void SetLength(){} // RVA: 0x7ffaae0168c0
        public void GetSecureFileName(){} // RVA: 0x7ffaae017a20
        public void GetSecureFileName(){} // RVA: 0x7ffaae017a20
    }

    public class FileSystemInfo : MarshalByRefObject
    {
        public object FullPath; // 0x33D33000
        public object dwFileAttributes; // 0x34F3BCF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadffd5e0
        public void Create(){} // RVA: 0x7ffaadffcfa0
        public void Invalidate(){} // RVA: 0x7ffaadffca00
        public void Init(){} // RVA: 0x7ffaadffd1a0
        public void get_Attributes(){} // RVA: 0x7ffaadffd1f0
        public void set_Attributes(){} // RVA: 0x7ffaadffd210
        public void get_ExistsCore(){} // RVA: 0x7ffaadffd2f0
        public void get_CreationTimeCore(){} // RVA: 0x7ffaadffd380
        public void get_LastAccessTimeCore(){} // RVA: 0x7ffaadffd3c0
        public void get_LastWriteTimeCore(){} // RVA: 0x7ffaadffd400
        public void get_LengthCore(){} // RVA: 0x7ffaadffd440
        public void EnsureDataInitialized(){} // RVA: 0x7ffaadffd470
        public void Refresh(){} // RVA: 0x7ffaadffd4e0
        public void get_NormalizedPath(){} // RVA: 0x7ffaadffd510
        public void .ctor(){} // RVA: 0x7ffaadffd5e0
        public void get_FullName(){} // RVA: 0x7ffaa89af740
        public void get_Name(){} // RVA: 0x7ffaa89d30e0
        public void get_Exists(){} // RVA: 0x7ffaadffdc70
        public void Delete(){} // RVA: 0x7ffaa8660cc0
        public void get_CreationTimeUtc(){} // RVA: 0x7ffaadffdd00
        public void get_LastAccessTime(){} // RVA: 0x7ffaadffddb0
        public void get_LastAccessTimeUtc(){} // RVA: 0x7ffaadffdee0
        public void get_LastWriteTime(){} // RVA: 0x7ffaadffdf90
        public void get_LastWriteTimeUtc(){} // RVA: 0x7ffaadffe0c0
        public void ToString(){} // RVA: 0x7ffaadffe170
        // ── Binary Analysis Named ──
        public void GetObjectData(){} // RVA: 0x7ffaadffd840
    }

    public class MonoIO : Object
    {
        // ── Original Methods ──
        public void FindCloseFile(){} // RVA: 0x7ffaae018d50
        public void Open(){} // RVA: 0x7ffaae018fc0
        public void Open(){} // RVA: 0x7ffaae018fc0
        public void Cancel_internal(){} // RVA: 0x7ffaae019110
        public void Cancel(){} // RVA: 0x7ffaae019130
        public void Close(){} // RVA: 0x7ffaae019250
        public void Read(){} // RVA: 0x7ffaae019320
        public void Read(){} // RVA: 0x7ffaae019320
        public void Write(){} // RVA: 0x7ffaae019540
        public void Write(){} // RVA: 0x7ffaae019540
        public void Seek(){} // RVA: 0x7ffaae0196f0
        public void Seek(){} // RVA: 0x7ffaae0196f0
        public void get_ConsoleOutput(){} // RVA: 0x7ffaae019c60
        public void get_ConsoleInput(){} // RVA: 0x7ffaae019c70
        public void get_ConsoleError(){} // RVA: 0x7ffaae019c80
        public void CreatePipe(){} // RVA: 0x7ffaae019c90
        public void DuplicateHandle(){} // RVA: 0x7ffaae019d90
        public void get_VolumeSeparatorChar(){} // RVA: 0x7ffaae019e80
        public void get_DirectorySeparatorChar(){} // RVA: 0x7ffaaad114e0
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x7ffaa8efa970
        public void get_PathSeparator(){} // RVA: 0x7ffaae019e90
        public void DumpHandles(){} // RVA: 0x7ffaadf54650
        public void RemapPath(){} // RVA: 0x7ffaae019ea0
        public void .cctor(){} // RVA: 0x7ffaae019eb0
        // ── Binary Analysis Named ──
        public void GetException(){} // RVA: 0x7ffaae018330
        public void GetException(){} // RVA: 0x7ffaae018330
        public void GetCurrentDirectory(){} // RVA: 0x7ffaae018ba0
        public void GetFileType(){} // RVA: 0x7ffaae018c40
        public void GetFileType(){} // RVA: 0x7ffaae018c40
        public void GetLength(){} // RVA: 0x7ffaae0198a0
        public void GetLength(){} // RVA: 0x7ffaae0198a0
        public void SetLength(){} // RVA: 0x7ffaae019a90
        public void SetLength(){} // RVA: 0x7ffaae019a90
    }

    public class MonoLinqHelper : Object
    {
        // ── Original Methods ──
        public void ToArray(){} // RVA: 0x7ffaa86492c0
    }

    public class Path : Object
    {
        public object DirectorySeparatorChar; // 0x34FA04B0
        public object VolumeSeparatorChar; // 0x34FA04B0
        public object trimEndCharsWindows; // 0x34FA04B0

        // ── Original Methods ──
        public void ChangeExtension(){} // RVA: 0x7ffaae019f30
        public void Combine(){} // RVA: 0x7ffaae01e650
        public void CleanPath(){} // RVA: 0x7ffaae01a4c0
        public void WindowsDriveAdjustment(){} // RVA: 0x7ffaae01b630
        public void InsecureGetFullPath(){} // RVA: 0x7ffaae01b870
        public void IsDirectorySeparator(){} // RVA: 0x7ffaae01bea0
        public void get_temp_path(){} // RVA: 0x7ffaae01c640
        public void IsPathRooted(){} // RVA: 0x7ffaae01c8c0
        public void IsPathRooted(){} // RVA: 0x7ffaae01c8c0
        public void findExtension(){} // RVA: 0x7ffaae01cd80
        public void .cctor(){} // RVA: 0x7ffaae01ce30
        public void SameRoot(){} // RVA: 0x7ffaae01d550
        public void CanonicalizePath(){} // RVA: 0x7ffaae01d8b0
        public void Combine(){} // RVA: 0x7ffaae01e650
        public void Combine(){} // RVA: 0x7ffaae01e650
        public void Combine(){} // RVA: 0x7ffaae01e650
        public void Join(){} // RVA: 0x7ffaae01eb00
        public void Join(){} // RVA: 0x7ffaae01eb00
        public void JoinInternal(){} // RVA: 0x7ffaae01f370
        public void JoinInternal(){} // RVA: 0x7ffaae01f370
        public void get_StringComparison(){} // RVA: 0x7ffaae0201a0
        public void get_IsCaseSensitive(){} // RVA: 0x7ffaae020250
        public void get_IsWindows(){} // RVA: 0x7ffaae0202c0
        // ── Binary Analysis Named ──
        public void GetDirectoryName(){} // RVA: 0x7ffaae01ae30
        public void GetDirectoryName(){} // RVA: 0x7ffaae01ae30
        public void GetExtension(){} // RVA: 0x7ffaae01af10
        public void GetFileName(){} // RVA: 0x7ffaae01e890
        public void GetFileNameWithoutExtension(){} // RVA: 0x7ffaae01b190
        public void GetFullPath(){} // RVA: 0x7ffaae01b1f0
        public void GetFullPathInternal(){} // RVA: 0x7ffaae01b240
        public void GetFullPathName(){} // RVA: 0x7ffaae01b380
        public void GetFullPathName(){} // RVA: 0x7ffaae01b380
        public void GetPathRoot(){} // RVA: 0x7ffaae01bf30
        public void GetTempPath(){} // RVA: 0x7ffaae01c3d0
        public void GetInvalidFileNameChars(){} // RVA: 0x7ffaae01cb00
        public void GetInvalidPathChars(){} // RVA: 0x7ffaae01cb70
        public void GetRandomFileName(){} // RVA: 0x7ffaae01cbe0
        public void GetServerAndShare(){} // RVA: 0x7ffaae01d2f0
        public void GetFileName(){} // RVA: 0x7ffaae01e890
        public void GetRelativePath(){} // RVA: 0x7ffaae01fa50
        public void GetRelativePath(){} // RVA: 0x7ffaae01fa50
    }

    public class PathInternal : Object
    {
        // ── Original Methods ──
        public void IsValidDriveChar(){} // RVA: 0x7ffaadfe0fe0
        public void EndsWithPeriodOrSpace(){} // RVA: 0x7ffaadfe1000
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x7ffaadfe1050
        public void EnsureExtendedPrefix(){} // RVA: 0x7ffaadfe1100
        public void IsDevice(){} // RVA: 0x7ffaadfe1350
        public void IsDeviceUNC(){} // RVA: 0x7ffaadfe1520
        public void IsExtended(){} // RVA: 0x7ffaadfe1610
        public void IsDirectorySeparator(){} // RVA: 0x7ffaadfe1a90
        public void IsEffectivelyEmpty(){} // RVA: 0x7ffaadfe1ab0
        public void EndsInDirectorySeparator(){} // RVA: 0x7ffaadfe1b30
        public void StartsWithDirectorySeparator(){} // RVA: 0x7ffaadfe1bd0
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7ffaadfe1e80
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7ffaadfe1e80
        public void IsRoot(){} // RVA: 0x7ffaadfe2060
        public void EqualStartingCharacterCount(){} // RVA: 0x7ffaadfe2310
        public void AreRootsEqual(){} // RVA: 0x7ffaadfe2430
        public void get_IsCaseSensitive(){} // RVA: 0x7ffaadfe2590
        public void IsPartiallyQualified(){} // RVA: 0x7ffaa8932320
        public void .cctor(){} // RVA: 0x7ffaadfe2810
        // ── Binary Analysis Named ──
        public void GetRootLength(){} // RVA: 0x7ffaadfe16a0
        public void GetCommonPathLength(){} // RVA: 0x7ffaadfe20d0
        public void GetIsCaseSensitive(){} // RVA: 0x7ffaadfe25f0
    }

    public class PathInternal : Object
    {
        // ── Original Methods ──
        public void get_StringComparison(){} // RVA: 0x7ffaaee78e40
        public void .cctor(){} // RVA: 0x7ffaaee790c0
        // ── Binary Analysis Named ──
        public void GetIsCaseSensitive(){} // RVA: 0x7ffaaee78ea0
    }

    public class Stream : MarshalByRefObject
    {
        public object _activeReadWriteTask; // 0x33E0E650

        // ── Original Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7ffaae006f30
        public void get_CanRead(){} // RVA: 0x7ffaa864a040
        public void get_CanSeek(){} // RVA: 0x7ffaa864a040
        public void get_CanTimeout(){} // RVA: 0x7ffaa8932320
        public void get_CanWrite(){} // RVA: 0x7ffaa864a040
        public void get_Length(){} // RVA: 0x7ffaa86491d0
        public void get_Position(){} // RVA: 0x7ffaa86491d0
        public void set_Position(){} // RVA: 0x7ffaa8660f30
        public void get_ReadTimeout(){} // RVA: 0x7ffaae007090
        public void set_ReadTimeout(){} // RVA: 0x7ffaae0070e0
        public void get_WriteTimeout(){} // RVA: 0x7ffaae007130
        public void set_WriteTimeout(){} // RVA: 0x7ffaae007180
        public void CopyToAsync(){} // RVA: 0x7ffaae0072f0
        public void CopyToAsync(){} // RVA: 0x7ffaae0072f0
        public void CopyToAsync(){} // RVA: 0x7ffaae0072f0
        public void CopyToAsyncInternal(){} // RVA: 0x7ffaae007350
        public void CopyTo(){} // RVA: 0x7ffaae007620
        public void CopyTo(){} // RVA: 0x7ffaae007620
        public void Close(){} // RVA: 0x7ffaae0078f0
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void Flush(){} // RVA: 0x7ffaa8660cc0
        public void FlushAsync(){} // RVA: 0x7ffaae0079c0
        public void FlushAsync(){} // RVA: 0x7ffaae0079c0
        public void EndRead(){} // RVA: 0x7ffaae007ef0
        public void ReadAsync(){} // RVA: 0x7ffaae0082c0
        public void ReadAsync(){} // RVA: 0x7ffaae0082c0
        public void ReadAsync(){} // RVA: 0x7ffaae0082c0
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7ffaae008bc0
        public void RunReadWriteTask(){} // RVA: 0x7ffaae008e10
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7ffaae008f70
        public void EndWrite(){} // RVA: 0x7ffaae008ff0
        public void WriteAsync(){} // RVA: 0x7ffaae0093c0
        public void WriteAsync(){} // RVA: 0x7ffaae0093c0
        public void WriteAsync(){} // RVA: 0x7ffaae0093c0
        public void FinishWriteAsync(){} // RVA: 0x7ffaae0097b0
        public void Seek(){}
        public void Read(){} // RVA: 0x7ffaae009d20
        public void Read(){} // RVA: 0x7ffaae009d20
        public void ReadByte(){} // RVA: 0x7ffaae009fc0
        public void Write(){} // RVA: 0x7ffaae00a070
        public void Write(){} // RVA: 0x7ffaae00a070
        public void WriteByte(){} // RVA: 0x7ffaae00a210
        public void BlockingBeginRead(){} // RVA: 0x7ffaae00a2a0
        public void BlockingEndRead(){} // RVA: 0x7ffaae00a3e0
        public void BlockingBeginWrite(){} // RVA: 0x7ffaae00a500
        public void BlockingEndWrite(){} // RVA: 0x7ffaae00a640
        public void HasOverriddenBeginEndRead(){} // RVA: 0x7ffaa8a17850
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x7ffaa8a17850
        public void DisposeAsync(){} // RVA: 0x7ffaae00a760
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae00a810
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x7ffaae00a900
        // ── Binary Analysis Named ──
        public void GetCopyBufferSize(){} // RVA: 0x7ffaae0077f0
        public void BeginRead(){} // RVA: 0x7ffaae007c20
        public void BeginReadInternal(){} // RVA: 0x7ffaae007c60
        public void BeginEndReadAsync(){} // RVA: 0x7ffaae008590
        public void BeginWrite(){} // RVA: 0x7ffaae0088f0
        public void BeginWriteInternal(){} // RVA: 0x7ffaae008930
        public void BeginEndWriteAsync(){} // RVA: 0x7ffaae0099c0
        public void SetLength(){} // RVA: 0x7ffaa8660f30
    }

    public class StreamReader : TextReader
    {
        public object _encoding; // 0x368463A0
        public object _charBuffer; // 0x368463A0
        public object _byteLen; // 0x368463A0
        public object _detectEncoding; // 0x368463A0
        public object _closable; // 0x368463A0

        // ── Original Methods ──
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7ffaadfe2e60
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void .ctor(){} // RVA: 0x7ffaadfe3460
        public void Init(){} // RVA: 0x7ffaadfe3a40
        public void Init(){} // RVA: 0x7ffaadfe3a40
        public void Close(){} // RVA: 0x7ffaade69290
        public void Dispose(){} // RVA: 0x7ffaadfe3aa0
        public void get_CurrentEncoding(){} // RVA: 0x7ffaa89600c0
        public void get_BaseStream(){} // RVA: 0x7ffaa89357c0
        public void get_LeaveOpen(){} // RVA: 0x7ffaadfe3d40
        public void get_EndOfStream(){} // RVA: 0x7ffaadfe3d50
        public void Peek(){} // RVA: 0x7ffaadfe3df0
        public void Read(){} // RVA: 0x7ffaadfe4150
        public void Read(){} // RVA: 0x7ffaadfe4150
        public void Read(){} // RVA: 0x7ffaadfe4150
        public void ReadSpan(){} // RVA: 0x7ffaadfe4260
        public void ReadToEnd(){} // RVA: 0x7ffaadfe4510
        public void CompressBuffer(){} // RVA: 0x7ffaadfe4650
        public void DetectEncoding(){} // RVA: 0x7ffaadfe4690
        public void IsPreamble(){} // RVA: 0x7ffaadfe4c30
        public void ReadBuffer(){} // RVA: 0x7ffaadfe54d0
        public void ReadBuffer(){} // RVA: 0x7ffaadfe54d0
        public void ReadLine(){} // RVA: 0x7ffaadfe5e80
        public void ReadToEndAsync(){} // RVA: 0x7ffaadfe60e0
        public void ReadToEndAsyncInternal(){} // RVA: 0x7ffaadfe6560
        public void ReadAsync(){} // RVA: 0x7ffaadfe6700
        public void ReadAsyncInternal(){} // RVA: 0x7ffaadfe6a30
        public void ReadBufferAsync(){} // RVA: 0x7ffaadfe6cd0
        public void DataAvailable(){} // RVA: 0x7ffaadfe6e80
        public void .cctor(){} // RVA: 0x7ffaadfe6e90
        // ── Binary Analysis Named ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7ffaadfe2dc0
    }

    public class StreamWriter : TextWriter
    {
        public object _encoding; // 0x368E02E0
        public object _charBuffer; // 0x368E02E0
        public object _autoFlush; // 0x368E02E0
        public object _asyncWriteTask; // 0x368E02E0
        public object UTF8NoBOM; // 0x1700091F
        public object AutoFlush; // 0x17000920
        public object BaseStream; // 0x17000921
        public object LeaveOpen; // 0x17000922

        // ── Original Methods ──
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7ffaadfea0a0
        public void get_UTF8NoBOM(){} // RVA: 0x7ffaadfea0f0
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void .ctor(){} // RVA: 0x7ffaadfea770
        public void Init(){} // RVA: 0x7ffaadfeaa80
        public void Close(){} // RVA: 0x7ffaadfead50
        public void Dispose(){} // RVA: 0x7ffaadfeadc0
        public void DisposeAsync(){} // RVA: 0x7ffaadfeb0f0
        public void DisposeAsyncCore(){} // RVA: 0x7ffaadfeb370
        public void CloseStreamFromDispose(){} // RVA: 0x7ffaadfeb510
        public void Flush(){} // RVA: 0x7ffaadfeb5e0
        public void Flush(){} // RVA: 0x7ffaadfeb5e0
        public void set_AutoFlush(){} // RVA: 0x7ffaadfeb7d0
        public void get_BaseStream(){} // RVA: 0x7ffaa8bfcc80
        public void get_LeaveOpen(){} // RVA: 0x7ffaadfeb810
        public void get_Encoding(){} // RVA: 0x7ffaa8bf45b0
        public void Write(){} // RVA: 0x7ffaadfebe30
        public void Write(){} // RVA: 0x7ffaadfebe30
        public void Write(){} // RVA: 0x7ffaadfebe30
        public void WriteSpan(){} // RVA: 0x7ffaadfebbb0
        public void Write(){} // RVA: 0x7ffaadfebe30
        public void WriteLine(){} // RVA: 0x7ffaadfebeb0
        public void WriteAsync(){} // RVA: 0x7ffaadfec920
        public void WriteAsyncInternal(){} // RVA: 0x7ffaadfeccc0
        public void WriteAsync(){} // RVA: 0x7ffaadfec920
        public void WriteAsyncInternal(){} // RVA: 0x7ffaadfeccc0
        public void WriteAsync(){} // RVA: 0x7ffaadfec920
        public void WriteAsyncInternal(){} // RVA: 0x7ffaadfeccc0
        public void WriteLineAsync(){} // RVA: 0x7ffaadfed010
        public void FlushAsync(){} // RVA: 0x7ffaadfed3b0
        public void set_CharPos_Prop(){} // RVA: 0x7ffaa905bde0
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x7ffaa962f610
        public void FlushAsyncInternal(){} // RVA: 0x7ffaadfed760
        public void FlushAsyncInternal(){} // RVA: 0x7ffaadfed760
        public void .cctor(){} // RVA: 0x7ffaadfedb50
        // ── Binary Analysis Named ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7ffaadfea000
    }

    public class StringReader : TextReader
    {
        public object _length; // 0x354EBBB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae012090
        public void Close(){} // RVA: 0x7ffaade69290
        public void Dispose(){} // RVA: 0x7ffaae012180
        public void Peek(){} // RVA: 0x7ffaae0121e0
        public void Read(){} // RVA: 0x7ffaae012290
        public void Read(){} // RVA: 0x7ffaae012290
        public void ReadToEnd(){} // RVA: 0x7ffaae0124a0
        public void ReadLine(){} // RVA: 0x7ffaae012500
        public void ReadToEndAsync(){} // RVA: 0x7ffaae012630
        public void ReadAsync(){} // RVA: 0x7ffaae0126b0
    }

    public class TextReader : MarshalByRefObject
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Close(){} // RVA: 0x7ffaadfefc50
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void Peek(){} // RVA: 0x7ffaa8ce12f0
        public void Read(){} // RVA: 0x7ffaadfeff40
        public void Read(){} // RVA: 0x7ffaadfeff40
        public void Read(){} // RVA: 0x7ffaadfeff40
        public void ReadToEnd(){} // RVA: 0x7ffaadff01e0
        public void ReadLine(){} // RVA: 0x7ffaadff0320
        public void ReadToEndAsync(){} // RVA: 0x7ffaadff04a0
        public void ReadAsync(){} // RVA: 0x7ffaadff0650
        public void ReadAsyncInternal(){} // RVA: 0x7ffaadff0880
        public void Synchronized(){} // RVA: 0x7ffaadff0cd0
        public void .cctor(){} // RVA: 0x7ffaadff0e10
    }

    public class TextWriter : MarshalByRefObject
    {
        public object CoreNewLine; // 0x33EF7BC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadff1f50
        public void .ctor(){} // RVA: 0x7ffaadff1f50
        public void get_FormatProvider(){} // RVA: 0x7ffaadff20d0
        public void Close(){} // RVA: 0x7ffaadff2170
        public void Dispose(){} // RVA: 0x7ffaadff21e0
        public void Dispose(){} // RVA: 0x7ffaadff21e0
        public void DisposeAsync(){} // RVA: 0x7ffaadff2250
        public void Flush(){} // RVA: 0x7ffaa8932310
        public void get_Encoding(){} // RVA: 0x7ffaa86491d0
        public void get_NewLine(){} // RVA: 0x7ffaa89600c0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void Write(){} // RVA: 0x7ffaadff26d0
        public void WriteLine(){} // RVA: 0x7ffaadff2900
        public void WriteLine(){} // RVA: 0x7ffaadff2900
        public void WriteLine(){} // RVA: 0x7ffaadff2900
        public void WriteLine(){} // RVA: 0x7ffaadff2900
        public void WriteLine(){} // RVA: 0x7ffaadff2900
        public void WriteAsync(){} // RVA: 0x7ffaadff2f90
        public void WriteAsync(){} // RVA: 0x7ffaadff2f90
        public void WriteAsync(){} // RVA: 0x7ffaadff2f90
        public void WriteLineAsync(){} // RVA: 0x7ffaadff3260
        public void FlushAsync(){} // RVA: 0x7ffaadff3530
        public void Synchronized(){} // RVA: 0x7ffaadff37c0
        public void .cctor(){} // RVA: 0x7ffaadff3920
    }

    public class UnmanagedMemoryStream : Stream
    {
        public object _length; // 0x33E0E270
        public object _offset; // 0x33E0E270
        public object _lastReadTask; // 0x33E0E270
        public object CanRead; // 0x1700092F
        public object CanSeek; // 0x17000930
        public object CanWrite; // 0x17000931

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadff4d40
        public void .ctor(){} // RVA: 0x7ffaadff4d40
        public void .ctor(){} // RVA: 0x7ffaadff4d40
        public void Initialize(){} // RVA: 0x7ffaadff4dd0
        public void get_CanRead(){} // RVA: 0x7ffaadff5060
        public void get_CanSeek(){} // RVA: 0x7ffaa89d0240
        public void get_CanWrite(){} // RVA: 0x7ffaadff5080
        public void Dispose(){} // RVA: 0x7ffaadff50a0
        public void EnsureNotClosed(){} // RVA: 0x7ffaadff50b0
        public void EnsureReadable(){} // RVA: 0x7ffaadff50f0
        public void EnsureWriteable(){} // RVA: 0x7ffaadff5140
        public void Flush(){} // RVA: 0x7ffaadff50b0
        public void FlushAsync(){} // RVA: 0x7ffaadff5190
        public void get_Length(){} // RVA: 0x7ffaadff52c0
        public void get_Position(){} // RVA: 0x7ffaadff5310
        public void set_Position(){} // RVA: 0x7ffaadff5360
        public void get_PositionPointer(){} // RVA: 0x7ffaadff5420
        public void Read(){} // RVA: 0x7ffaadff5740
        public void Read(){} // RVA: 0x7ffaadff5740
        public void ReadCore(){} // RVA: 0x7ffaadff5850
        public void ReadAsync(){} // RVA: 0x7ffaadff5e30
        public void ReadAsync(){} // RVA: 0x7ffaadff5e30
        public void ReadByte(){} // RVA: 0x7ffaadff61e0
        public void Seek(){} // RVA: 0x7ffaadff6360
        public void Write(){} // RVA: 0x7ffaadff6970
        public void Write(){} // RVA: 0x7ffaadff6970
        public void WriteCore(){} // RVA: 0x7ffaadff6a80
        public void WriteAsync(){} // RVA: 0x7ffaadff70b0
        public void WriteAsync(){} // RVA: 0x7ffaadff70b0
        public void WriteByte(){} // RVA: 0x7ffaadff73a0
        // ── Binary Analysis Named ──
        public void SetLength(){} // RVA: 0x7ffaadff6530
    }

}