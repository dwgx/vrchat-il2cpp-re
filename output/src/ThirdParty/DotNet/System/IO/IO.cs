// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 62
// Methods: 728

namespace ThirdParty.DotNet.System.IO
{
    public class BinaryReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC44B30
        public void get_BaseStream(){} // RVA: 0x7A80F2570
        public void Close(){} // RVA: 0x7A9B205C0
        public void Dispose(){} // RVA: 0x7A9B205C0
        public void Read(){} // RVA: 0x7ADC46530
        public void ReadBoolean(){} // RVA: 0x7ADC450B0
        public void ReadByte(){} // RVA: 0x7ADC45100
        public void ReadSByte(){} // RVA: 0x7ADC45140
        public void ReadChar(){} // RVA: 0x7ADC45190
        public void ReadInt16(){} // RVA: 0x7ADC451C0
        public void ReadUInt16(){} // RVA: 0x7ADC451C0
        public void ReadInt32(){} // RVA: 0x7ADC45220
        public void ReadUInt32(){} // RVA: 0x7ADC45440
        public void ReadInt64(){} // RVA: 0x7ADC454C0
        public void ReadUInt64(){} // RVA: 0x7ADC454C0
        public void ReadSingle(){} // RVA: 0x7ADC455E0
        public void ReadDouble(){} // RVA: 0x7ADC45660
        public void ReadDecimal(){} // RVA: 0x7ADC456D0
        public void ReadString(){} // RVA: 0x7ADC45940
        public void InternalReadChars(){} // RVA: 0x7ADC45C40
        public void InternalReadOneChar(){} // RVA: 0x7ADC46010
        public void ReadChars(){} // RVA: 0x7ADC46350
        public void ReadBytes(){} // RVA: 0x7ADC46720
        public void FillBuffer(){} // RVA: 0x7ADC46920
        public void Read7BitEncodedInt(){} // RVA: 0x7ADC46A90
    }

    public class BinaryWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC46E70
        public void Close(){} // RVA: 0x7A9B205C0
        public void Dispose(){} // RVA: 0x7A9B205C0
        public void get_BaseStream(){} // RVA: 0x7ADC470B0
        public void Flush(){} // RVA: 0x7ADBEADD0
        public void DisposeAsync(){} // RVA: 0x7ADC470E0
        public void Write(){} // RVA: 0x7ADC47D30
        public void Write7BitEncodedInt(){} // RVA: 0x7ADC48110
        public void .cctor(){} // RVA: 0x7ADC48180
    }

    public class BufferedStream : Stream
    {
        // ── Methods ──
        public void LazyEnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7ADC342B0
        public void .ctor(){} // RVA: 0x7ADC34420
        public void EnsureNotClosed(){} // RVA: 0x7ADC34670
        public void EnsureCanSeek(){} // RVA: 0x7ADC346E0
        public void EnsureCanRead(){} // RVA: 0x7ADC34770
        public void EnsureCanWrite(){} // RVA: 0x7ADC34800
        public void EnsureShadowBufferAllocated(){} // RVA: 0x7ADC34890
        public void EnsureBufferAllocated(){} // RVA: 0x7ADC349C0
        public void get_CanRead(){} // RVA: 0x7ADC34A60
        public void get_CanWrite(){} // RVA: 0x7ADC34A90
        public void get_CanSeek(){} // RVA: 0x7ADC34AC0
        public void get_Length(){} // RVA: 0x7ADC34AF0
        public void get_Position(){} // RVA: 0x7ADC34B80
        public void set_Position(){} // RVA: 0x7ADC34C20
        public void DisposeAsync(){} // RVA: 0x7ADC34CF0
        public void Dispose(){} // RVA: 0x7ADC34EA0
        public void Flush(){} // RVA: 0x7ADC35070
        public void FlushAsync(){} // RVA: 0x7ADC351B0
        public void FlushAsyncInternal(){} // RVA: 0x7ADC35280
        public void FlushRead(){} // RVA: 0x7ADC354A0
        public void ClearReadBufferBeforeWrite(){} // RVA: 0x7ADC354F0
        public void FlushWrite(){} // RVA: 0x7ADC355C0
        public void FlushWriteAsync(){} // RVA: 0x7ADC35630
        public void ReadFromBuffer(){} // RVA: 0x7ADC35A40
        public void Read(){} // RVA: 0x7ADC35DE0
        public void LastSyncCompletedReadTask(){} // RVA: 0x7ADC35FF0
        public void ReadAsync(){} // RVA: 0x7ADC36820
        public void ReadFromUnderlyingStreamAsync(){} // RVA: 0x7ADC36CD0
        public void BeginRead(){} // RVA: 0x7ADC36FD0
        public void EndRead(){} // RVA: 0x7ADC37080
        public void ReadByte(){} // RVA: 0x7ADC370C0
        public void ReadByteSlow(){} // RVA: 0x7ADC371F0
        public void WriteToBuffer(){} // RVA: 0x7ADC373C0
        public void Write(){} // RVA: 0x7ADC37960
        public void WriteAsync(){} // RVA: 0x7ADC37FD0
        public void WriteToUnderlyingStreamAsync(){} // RVA: 0x7ADC38370
        public void BeginWrite(){} // RVA: 0x7ADC38640
        public void EndWrite(){} // RVA: 0x7ADA5CD30
        public void WriteByte(){} // RVA: 0x7ADC386F0
        public void Seek(){} // RVA: 0x7ADC387C0
        public void SetLength(){} // RVA: 0x7ADC38940
        public void CopyTo(){} // RVA: 0x7ADC38A20
        public void CopyToAsync(){} // RVA: 0x7ADC38AD0
        public void CopyToAsyncCore(){} // RVA: 0x7ADC38BC0
    }

    public class CStreamReader : StreamReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC574F0
        public void Peek(){} // RVA: 0x7ADC56DB0
        public void Read(){} // RVA: 0x7ADC57840
        public void ReadLine(){} // RVA: 0x7ADC579F0
        public void ReadToEnd(){} // RVA: 0x7ADC57A20
    }

    public class CStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC57A50
        public void Write(){} // RVA: 0x7ADC581B0
        public void InternalWriteString(){} // RVA: 0x7ADC58110
        public void InternalWriteChar(){} // RVA: 0x7ADC58130
        public void InternalWriteChars(){} // RVA: 0x7ADC58150
        public void WriteLine(){} // RVA: 0x7ADC58220
    }

    public class DefaultWatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetInstance(){} // RVA: 0x7AEAAE060
        public void StartDispatching(){} // RVA: 0x7AEAAE230
        public void StopDispatching(){} // RVA: 0x7AEAAEF00
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Monitor(){} // RVA: 0x7AEAAF460
        public void UpdateDataAndDispatch(){} // RVA: 0x7AEAAFDE0
        public void DispatchEvents(){} // RVA: 0x7AEAAFF20
        public void DoFiles(){} // RVA: 0x7AEAB0080
        public void IterateAndModifyFilesData(){} // RVA: 0x7AEAB0450
        public void CreateFileData(){} // RVA: 0x7AEAB1070
        public void .cctor(){} // RVA: 0x7AEAB1190
    }

    public class DefaultWatcherData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAADFD0
    }

    public class Directory : Object
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7ADC2E060
        public void Exists(){} // RVA: 0x7ADC2E200
        public void GetFiles(){} // RVA: 0x7ADC2E450
        public void GetDirectories(){} // RVA: 0x7ADC2E600
        public void GetFileSystemEntries(){} // RVA: 0x7ADC2E7A0
        public void InternalEnumeratePaths(){} // RVA: 0x7ADC2E830
        public void EnumerateFiles(){} // RVA: 0x7ADC2EC80
        public void GetDirectoryRoot(){} // RVA: 0x7ADC2ECA0
        public void InternalGetDirectoryRoot(){} // RVA: 0x7ADC2EE20
        public void GetCurrentDirectory(){} // RVA: 0x7ADC2EEE0
        public void Delete(){} // RVA: 0x7ADC2EEF0
        public void InsecureGetCurrentDirectory(){} // RVA: 0x7ADC2EF90
    }

    public class DirectoryInfo : FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC2FF50
        public void Init(){} // RVA: 0x7ADC2F190
        public void get_Parent(){} // RVA: 0x7ADC2F6E0
        public void Create(){} // RVA: 0x7ADC2F8B0
        public void GetFiles(){} // RVA: 0x7ADC2FA40
        public void EnumerateFiles(){} // RVA: 0x7ADC2FC50
        public void InternalEnumerateInfos(){} // RVA: 0x7ADC2FCF0
        public void Delete(){} // RVA: 0x7ADC2FEF0
    }

    public class DirectoryNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class DisableMediaInsertionPrompt : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7ADC0E400
        public void Dispose(){} // RVA: 0x7A7E37F60
    }

    public class DriveNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class EndOfStreamException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class EnumerationOptions : Object
    {
        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x7ADC2FF70
        public void get_CompatibleRecursive(){} // RVA: 0x7ADC2FFD0
        public void get_Default(){} // RVA: 0x7ADC30030
        public void .ctor(){} // RVA: 0x7ADC30090
        public void FromSearchOption(){} // RVA: 0x7ADC300A0
        public void get_RecurseSubdirectories(){} // RVA: 0x7A81A2200
        public void set_RecurseSubdirectories(){} // RVA: 0x7A81A2210
        public void get_IgnoreInaccessible(){} // RVA: 0x7A82FBFB0
        public void set_IgnoreInaccessible(){} // RVA: 0x7A82FBFC0
        public void get_BufferSize(){} // RVA: 0x7A8668BC0
        public void get_AttributesToSkip(){} // RVA: 0x7A83782A0
        public void set_AttributesToSkip(){} // RVA: 0x7A84385B0
        public void get_MatchType(){} // RVA: 0x7A9739200
        public void set_MatchType(){} // RVA: 0x7A9746990
        public void get_MatchCasing(){} // RVA: 0x7A851DB90
        public void get_ReturnSpecialDirectories(){} // RVA: 0x7A80F29B0
        public void .cctor(){} // RVA: 0x7ADC301C0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void GetStreamIsClosed(){} // RVA: 0x7ADC127A0
        public void GetEndOfFile(){} // RVA: 0x7ADC12810
        public void GetReadNotSupported(){} // RVA: 0x7ADC12880
        public void GetWriteNotSupported(){} // RVA: 0x7ADC128F0
    }

    public class Error : Object
    {
        // ── Methods ──
        public void GetEndOfFile(){} // RVA: 0x7AE464030
        public void GetPipeNotOpen(){} // RVA: 0x7AE4640A0
        public void GetReadNotSupported(){} // RVA: 0x7AE464110
        public void GetSeekNotSupported(){} // RVA: 0x7AE464180
        public void GetWriteNotSupported(){} // RVA: 0x7AE4641F0
        public void GetOperationAborted(){} // RVA: 0x7AE464260
    }

    public class ErrorEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class File : Object
    {
        // ── Methods ──
        public void OpenText(){} // RVA: 0x7ADC30390
        public void Copy(){} // RVA: 0x7ADC30470
        public void Create(){} // RVA: 0x7ADC307A0
        public void Delete(){} // RVA: 0x7ADC30840
        public void Exists(){} // RVA: 0x7ADC30920
        public void Open(){} // RVA: 0x7ADC30AC0
        public void GetUtcDateTimeOffset(){} // RVA: 0x7ADC30B60
        public void GetCreationTime(){} // RVA: 0x7ADC30C90
        public void GetCreationTimeUtc(){} // RVA: 0x7ADC30DC0
        public void SetLastAccessTimeUtc(){} // RVA: 0x7ADC30F20
        public void GetLastWriteTime(){} // RVA: 0x7ADC310E0
        public void GetLastWriteTimeUtc(){} // RVA: 0x7ADC31210
        public void GetAttributes(){} // RVA: 0x7ADC31370
        public void OpenRead(){} // RVA: 0x7ADC31450
        public void OpenWrite(){} // RVA: 0x7ADC314E0
        public void ReadAllText(){} // RVA: 0x7ADC31560
        public void InternalReadAllText(){} // RVA: 0x7ADC31640
        public void WriteAllText(){} // RVA: 0x7ADC31920
        public void ReadAllBytes(){} // RVA: 0x7ADC31B50
        public void ReadAllBytesUnknownLength(){} // RVA: 0x7ADC31DC0
        public void WriteAllBytes(){} // RVA: 0x7ADC32310
        public void InternalWriteAllBytes(){} // RVA: 0x7ADC32440
        public void ReadAllLines(){} // RVA: 0x7ADC325A0
        public void InternalReadAllLines(){} // RVA: 0x7ADC32680
        public void Move(){} // RVA: 0x7ADC32890
    }

    public class FileData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class FileInfo : FileSystemInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC2FF50
        public void get_Length(){} // RVA: 0x7ADC32DD0
        public void get_DirectoryName(){} // RVA: 0x7ADC32E80
        public void get_Directory(){} // RVA: 0x7ADC32EE0
        public void get_IsReadOnly(){} // RVA: 0x7ADC32F90
        public void set_IsReadOnly(){} // RVA: 0x7ADC32FB0
        public void CreateText(){} // RVA: 0x7ADC33050
        public void AppendText(){} // RVA: 0x7ADC330C0
        public void Delete(){} // RVA: 0x7ADC33130
        public void get_Name(){} // RVA: 0x7A8178B90
    }

    public class FileInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class FileInfo[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class FileLoadException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC12CC0
        public void get_Message(){} // RVA: 0x7ADC129D0
        public void get_FileName(){} // RVA: 0x7A8555100
        public void get_FusionLog(){} // RVA: 0x7A87D9C10
        public void ToString(){} // RVA: 0x7ADC12AB0
        public void GetObjectData(){} // RVA: 0x7ADC12E60
        public void FormatFileLoadExceptionMessage(){} // RVA: 0x7ADC13170
    }

    public class FileNotFoundException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13720
        public void get_Message(){} // RVA: 0x7ADC132D0
        public void SetMessageField(){} // RVA: 0x7ADC133F0
        public void get_FileName(){} // RVA: 0x7A8555100
        public void get_FusionLog(){} // RVA: 0x7A87D9C10
        public void ToString(){} // RVA: 0x7ADC13510
        public void GetObjectData(){} // RVA: 0x7ADC138C0
    }

    public class FileStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC49B70
        public void Init(){} // RVA: 0x7ADC4A5E0
        public void get_CanRead(){} // RVA: 0x7ADC4A950
        public void get_CanWrite(){} // RVA: 0x7ADC4A970
        public void get_CanSeek(){} // RVA: 0x7ADC4A990
        public void get_Name(){} // RVA: 0x7A83F69F0
        public void get_Length(){} // RVA: 0x7ADC4A9A0
        public void get_Position(){} // RVA: 0x7ADC4AB40
        public void set_Position(){} // RVA: 0x7ADC4AD00
        public void get_SafeFileHandle(){} // RVA: 0x7ADC4ADA0
        public void ExposeHandle(){} // RVA: 0x7ADC4ADE0
        public void ReadByte(){} // RVA: 0x7ADC4AE10
        public void WriteByte(){} // RVA: 0x7ADC4AF80
        public void Read(){} // RVA: 0x7ADC4B0E0
        public void ReadInternal(){} // RVA: 0x7ADC4B490
        public void BeginRead(){} // RVA: 0x7ADC4B560
        public void EndRead(){} // RVA: 0x7ADC4B9A0
        public void Write(){} // RVA: 0x7ADC4BBB0
        public void WriteInternal(){} // RVA: 0x7ADC4BE80
        public void BeginWrite(){} // RVA: 0x7ADC4C0C0
        public void EndWrite(){} // RVA: 0x7ADC4C550
        public void Seek(){} // RVA: 0x7ADC4C750
        public void SetLength(){} // RVA: 0x7ADC4CA60
        public void Flush(){} // RVA: 0x7ADC4CD00
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void Dispose(){} // RVA: 0x7ADC4CD80
        public void FlushAsync(){} // RVA: 0x7ADC4D160
        public void ReadAsync(){} // RVA: 0x7ADC4D1E0
        public void WriteAsync(){} // RVA: 0x7ADC4D1F0
        public void ReadSegment(){} // RVA: 0x7ADC4D200
        public void WriteSegment(){} // RVA: 0x7ADC4D310
        public void FlushBuffer(){} // RVA: 0x7ADC4D380
        public void FlushBufferIfDirty(){} // RVA: 0x7ADC4D570
        public void RefillBuffer(){} // RVA: 0x7ADC4D580
        public void ReadData(){} // RVA: 0x7ADC4D5C0
        public void InitBuffer(){} // RVA: 0x7ADC4D700
        public void GetSecureFileName(){} // RVA: 0x7ADC4DB60
        public void .cctor(){} // RVA: 0x7ADC4DC50
    }

    public class FileStreamAsyncResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC4E090
        public void CBWrapper(){} // RVA: 0x7ADC4E2C0
        public void get_AsyncState(){} // RVA: 0x7A80F2570
        public void get_CompletedSynchronously(){} // RVA: 0x7A80FD690
        public void get_AsyncWaitHandle(){} // RVA: 0x7A81052C0
        public void get_IsCompleted(){} // RVA: 0x7A80F26D0
    }

    public class FileSystem : Object
    {
        // ── Methods ──
        public void CopyFile(){} // RVA: 0x7ADC0E520
        public void CreateDirectory(){} // RVA: 0x7ADC0E7F0
        public void DeleteFile(){} // RVA: 0x7ADC0EF20
        public void DirectoryExists(){} // RVA: 0x7ADC0F000
        public void FillAttributeInfo(){} // RVA: 0x7ADC0F050
        public void FileExists(){} // RVA: 0x7ADC0F370
        public void GetAttributes(){} // RVA: 0x7ADC0F3C0
        public void GetCreationTime(){} // RVA: 0x7ADC0F430
        public void GetLastWriteTime(){} // RVA: 0x7ADC0F4C0
        public void MoveFile(){} // RVA: 0x7ADC0F550
        public void OpenHandle(){} // RVA: 0x7ADC0F5A0
        public void RemoveDirectory(){} // RVA: 0x7ADC0F840
        public void GetFindData(){} // RVA: 0x7ADC0F920
        public void IsNameSurrogateReparsePoint(){} // RVA: 0x7ADC0FA80
        public void RemoveDirectoryRecursive(){} // RVA: 0x7ADC0FAA0
        public void RemoveDirectoryInternal(){} // RVA: 0x7ADC10480
        public void SetAttributes(){} // RVA: 0x7ADC105B0
        public void SetLastAccessTime(){} // RVA: 0x7ADC107F0
        public void UnityCreateDirectory(){} // RVA: 0x7ADC10A30
        public void UnityRemoveDirectory(){} // RVA: 0x7ADC10BF0
        public void UnityGetFileAttributesEx(){} // RVA: 0x7ADC10E00
        public void UnitySetFileAttributes(){} // RVA: 0x7ADC11060
        public void UnityCreateFile_IntPtr(){} // RVA: 0x7ADC11200
        public void UnityCopyFile(){} // RVA: 0x7ADC113C0
        public void UnityDeleteFile(){} // RVA: 0x7ADC11490
        public void UnityMoveFile(){} // RVA: 0x7ADC116A0
        public void UnityFindFirstFile(){} // RVA: 0x7ADC118C0
        public void UnityFindNextFile(){} // RVA: 0x7ADC11D30
        public void BrokeredCreateDirectory(){} // RVA: 0x7ADC12010
        public void BrokeredRemoveDirectory(){} // RVA: 0x7ADC12010
        public void BrokeredGetFileAttributes(){} // RVA: 0x7ADC12070
        public void BrokeredSetAttributes(){} // RVA: 0x7ADC12080
        public void BrokeredOpenFile(){} // RVA: 0x7ADC120E0
        public void BrokeredCopyFile(){} // RVA: 0x7ADC12220
        public void BrokeredMoveFile(){} // RVA: 0x7ADC12300
        public void BrokeredDeleteFile(){} // RVA: 0x7ADC12010
        public void BrokeredFindFirstFile(){} // RVA: 0x7ADC123D0
        public void BrokeredFindNextFile(){} // RVA: 0x7ADC12510
        public void BrokeredSafeFindHandleDispose(){} // RVA: 0x7ADC125B0
        public void RemoveExtendedPathPrefix(){} // RVA: 0x7ADC125C0
    }

    public class FileSystemEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAAD6E0
        public void Combine(){} // RVA: 0x7AEAAD880
        public void get_ChangeType(){} // RVA: 0x7A8124910
        public void get_FullPath(){} // RVA: 0x7A81052C0
    }

    public class FileSystemEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class FileSystemInfo : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC336D0
        public void Create(){} // RVA: 0x7ADC33140
        public void Invalidate(){} // RVA: 0x7ADC32B50
        public void Init(){} // RVA: 0x7ADC33340
        public void get_Attributes(){} // RVA: 0x7ADC33390
        public void set_Attributes(){} // RVA: 0x7ADC333B0
        public void get_ExistsCore(){} // RVA: 0x7ADC333E0
        public void get_CreationTimeCore(){} // RVA: 0x7ADC33470
        public void get_LastAccessTimeCore(){} // RVA: 0x7ADC334B0
        public void get_LastWriteTimeCore(){} // RVA: 0x7ADC334F0
        public void get_LengthCore(){} // RVA: 0x7ADC33530
        public void EnsureDataInitialized(){} // RVA: 0x7ADC33560
        public void Refresh(){} // RVA: 0x7ADC335D0
        public void get_NormalizedPath(){} // RVA: 0x7ADC33600
        public void GetObjectData(){} // RVA: 0x7ADC33930
        public void get_FullName(){} // RVA: 0x7A8154D80
        public void get_Name(){} // RVA: 0x7A8178B90
        public void get_Exists(){} // RVA: 0x7ADC33D60
        public void Delete(){} // RVA: 0x7A7E18770
        public void get_CreationTimeUtc(){} // RVA: 0x7ADC33DF0
        public void get_LastAccessTime(){} // RVA: 0x7ADC33EA0
        public void get_LastAccessTimeUtc(){} // RVA: 0x7ADC33FD0
        public void get_LastWriteTime(){} // RVA: 0x7ADC34080
        public void get_LastWriteTimeUtc(){} // RVA: 0x7ADC341B0
        public void ToString(){} // RVA: 0x7ADC34260
    }

    public class FileSystemWatcher : Component
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAB12A0
        public void InitWatcher(){} // RVA: 0x7AEAB1590
        public void get_Waiting(){} // RVA: 0x7A8361EA0
        public void set_Waiting(){} // RVA: 0x7A835F4F0
        public void get_MangledFilter(){} // RVA: 0x7AEAB1B10
        public void get_Pattern(){} // RVA: 0x7AEAB1BB0
        public void get_FullPath(){} // RVA: 0x7AEAB1D10
        public void set_EnableRaisingEvents(){} // RVA: 0x7AEAB1E40
        public void set_Filter(){} // RVA: 0x7AEAB1EF0
        public void get_IncludeSubdirectories(){} // RVA: 0x7A82A20A0
        public void set_IncludeSubdirectories(){} // RVA: 0x7AEAB2170
        public void set_NotifyFilter(){} // RVA: 0x7AEAB21B0
        public void get_Site(){} // RVA: 0x7A80DA7B0
        public void set_Site(){} // RVA: 0x7AEAB21F0
        public void BeginInit(){} // RVA: 0x7A9C36C50
        public void Dispose(){} // RVA: 0x7AEAB22E0
        public void Finalize(){} // RVA: 0x7AEAB2480
        public void EndInit(){} // RVA: 0x7AEAB2500
        public void RaiseEvent(){} // RVA: 0x7AEAB25B0
        public void OnChanged(){} // RVA: 0x7AEAB2940
        public void OnCreated(){} // RVA: 0x7AEAB2970
        public void OnDeleted(){} // RVA: 0x7AEAB29A0
        public void OnRenamed(){} // RVA: 0x7AEAB29D0
        public void DispatchEvents(){} // RVA: 0x7AEAB2A00
        public void Start(){} // RVA: 0x7AEAB2F60
        public void Stop(){} // RVA: 0x7AEAB2FD0
        public void add_Changed(){} // RVA: 0x7AEAB3040
        public void remove_Changed(){} // RVA: 0x7AEAB3140
        public void add_Created(){} // RVA: 0x7AEAB3240
        public void remove_Created(){} // RVA: 0x7AEAB3340
        public void add_Deleted(){} // RVA: 0x7AEAB3440
        public void remove_Deleted(){} // RVA: 0x7AEAB3540
        public void .cctor(){} // RVA: 0x7AEAB3640
    }

    public class IFileWatcher
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7A7E18800
        public void StopDispatching(){} // RVA: 0x7A7E18800
        public void Dispose(){} // RVA: 0x7A7E18800
    }

    public class IODescriptionAttribute : DescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAB3950
        public void get_Description(){} // RVA: 0x7A80F2570
    }

    public class IOException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class InvalidDataException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class MemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC14020
        public void get_CanRead(){} // RVA: 0x7A92A8970
        public void get_CanSeek(){} // RVA: 0x7A92A8970
        public void get_CanWrite(){} // RVA: 0x7A83F3AD0
        public void EnsureNotClosed(){} // RVA: 0x7ADC14240
        public void EnsureWriteable(){} // RVA: 0x7ADC14280
        public void Dispose(){} // RVA: 0x7ADC142D0
        public void EnsureCapacity(){} // RVA: 0x7ADC14350
        public void Flush(){} // RVA: 0x7A80D7310
        public void FlushAsync(){} // RVA: 0x7ADC14410
        public void GetBuffer(){} // RVA: 0x7ADC14540
        public void InternalGetBuffer(){} // RVA: 0x7A8105330
        public void InternalGetPosition(){} // RVA: 0x7A82C2070
        public void InternalReadInt32(){} // RVA: 0x7ADC145B0
        public void InternalEmulateRead(){} // RVA: 0x7ADC146A0
        public void get_Capacity(){} // RVA: 0x7ADC14700
        public void set_Capacity(){} // RVA: 0x7ADC14740
        public void get_Length(){} // RVA: 0x7ADC14920
        public void get_Position(){} // RVA: 0x7ADC14970
        public void set_Position(){} // RVA: 0x7ADC149C0
        public void Read(){} // RVA: 0x7ADC14D60
        public void ReadAsync(){} // RVA: 0x7ADC15340
        public void ReadByte(){} // RVA: 0x7ADC15760
        public void CopyTo(){} // RVA: 0x7ADC157E0
        public void CopyToAsync(){} // RVA: 0x7ADC15970
        public void Seek(){} // RVA: 0x7ADC15C70
        public void SetLength(){} // RVA: 0x7ADC15EC0
        public void ToArray(){} // RVA: 0x7ADC16030
        public void Write(){} // RVA: 0x7ADC163F0
        public void WriteAsync(){} // RVA: 0x7ADC16980
        public void WriteByte(){} // RVA: 0x7ADC16CD0
        public void WriteTo(){} // RVA: 0x7ADC16DF0
    }

    public class MonoIO : Object
    {
        // ── Methods ──
        public void GetException(){} // RVA: 0x7ADC4E490
        public void GetCurrentDirectory(){} // RVA: 0x7ADC4ED00
        public void GetFileType(){} // RVA: 0x7ADC4EDB0
        public void FindCloseFile(){} // RVA: 0x7ADC4EEC0
        public void Open(){} // RVA: 0x7ADC4F190
        public void Cancel_internal(){} // RVA: 0x7ADC4F2F0
        public void Cancel(){} // RVA: 0x7ADC4F310
        public void Close(){} // RVA: 0x7ADC4F430
        public void Read(){} // RVA: 0x7ADC4F500
        public void Write(){} // RVA: 0x7ADC4F720
        public void Seek(){} // RVA: 0x7ADC4F8D0
        public void GetLength(){} // RVA: 0x7ADC4FA80
        public void SetLength(){} // RVA: 0x7ADC4FC70
        public void get_ConsoleOutput(){} // RVA: 0x7ADC4FE40
        public void get_ConsoleInput(){} // RVA: 0x7ADC4FE50
        public void get_ConsoleError(){} // RVA: 0x7ADC4FE60
        public void CreatePipe(){} // RVA: 0x7ADC4FE70
        public void DuplicateHandle(){} // RVA: 0x7ADC4FF80
        public void get_VolumeSeparatorChar(){} // RVA: 0x7ADC500B0
        public void get_DirectorySeparatorChar(){} // RVA: 0x7A9F26230
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x7ADC500C0
        public void get_PathSeparator(){} // RVA: 0x7ADC500D0
        public void DumpHandles(){} // RVA: 0x7ADB89E70
        public void RemapPath(){} // RVA: 0x7ADC500E0
        public void .cctor(){} // RVA: 0x7ADC500F0
    }

    public class MonoLinqHelper : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7AA547830
    }

    public class NullFileWatcher : Object
    {
        // ── Methods ──
        public void StartDispatching(){} // RVA: 0x7A80D7310
        public void StopDispatching(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7A80D7310
        public void GetInstance(){} // RVA: 0x7AEAB3A80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Path : Object
    {
        // ── Methods ──
        public void ChangeExtension(){} // RVA: 0x7ADC50170
        public void Combine(){} // RVA: 0x7ADC54990
        public void CleanPath(){} // RVA: 0x7ADC50710
        public void GetDirectoryName(){} // RVA: 0x7ADC510D0
        public void GetExtension(){} // RVA: 0x7ADC511B0
        public void GetFileName(){} // RVA: 0x7ADC54BD0
        public void GetFileNameWithoutExtension(){} // RVA: 0x7ADC51430
        public void GetFullPath(){} // RVA: 0x7ADC51490
        public void GetFullPathInternal(){} // RVA: 0x7ADC514E0
        public void GetFullPathName(){} // RVA: 0x7ADC51620
        public void WindowsDriveAdjustment(){} // RVA: 0x7ADC518E0
        public void InsecureGetFullPath(){} // RVA: 0x7ADC51B20
        public void IsDirectorySeparator(){} // RVA: 0x7ADC52150
        public void GetPathRoot(){} // RVA: 0x7ADC521E0
        public void GetTempPath(){} // RVA: 0x7ADC52680
        public void get_temp_path(){} // RVA: 0x7ADC52940
        public void IsPathRooted(){} // RVA: 0x7ADC52BD0
        public void GetInvalidFileNameChars(){} // RVA: 0x7ADC52E10
        public void GetInvalidPathChars(){} // RVA: 0x7ADC52E80
        public void GetRandomFileName(){} // RVA: 0x7ADC52EF0
        public void findExtension(){} // RVA: 0x7ADC530B0
        public void .cctor(){} // RVA: 0x7ADC53170
        public void GetServerAndShare(){} // RVA: 0x7ADC53620
        public void SameRoot(){} // RVA: 0x7ADC53880
        public void CanonicalizePath(){} // RVA: 0x7ADC53BE0
        public void Join(){} // RVA: 0x7ADC54E30
        public void JoinInternal(){} // RVA: 0x7ADC556A0
        public void GetRelativePath(){} // RVA: 0x7ADC55D60
        public void get_StringComparison(){} // RVA: 0x7ADC564B0
        public void get_IsCaseSensitive(){} // RVA: 0x7ADC56560
        public void get_IsWindows(){} // RVA: 0x7ADC565D0
    }

    public class PathInternal : Object
    {
        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x7ADC16EC0
        public void EndsWithPeriodOrSpace(){} // RVA: 0x7ADC16EE0
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x7ADC16F30
        public void EnsureExtendedPrefix(){} // RVA: 0x7ADC16FE0
        public void IsDevice(){} // RVA: 0x7ADC17230
        public void IsDeviceUNC(){} // RVA: 0x7ADC17400
        public void IsExtended(){} // RVA: 0x7ADC174F0
        public void GetRootLength(){} // RVA: 0x7ADC17580
        public void IsDirectorySeparator(){} // RVA: 0x7ADC17970
        public void IsEffectivelyEmpty(){} // RVA: 0x7ADC17990
        public void EndsInDirectorySeparator(){} // RVA: 0x7ADC17A10
        public void StartsWithDirectorySeparator(){} // RVA: 0x7ADC17AB0
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7ADC17D60
        public void IsRoot(){} // RVA: 0x7ADC17F40
        public void GetCommonPathLength(){} // RVA: 0x7ADC17FB0
        public void EqualStartingCharacterCount(){} // RVA: 0x7ADC181F0
        public void AreRootsEqual(){} // RVA: 0x7ADC18310
        public void get_IsCaseSensitive(){} // RVA: 0x7ADC18470
        public void GetIsCaseSensitive(){} // RVA: 0x7ADC184D0
        public void IsPartiallyQualified(){} // RVA: 0x7A80D7320
        public void .cctor(){} // RVA: 0x7ADC186F0
    }

    public class PathInternal : Object
    {
        // ── Methods ──
        public void get_StringComparison(){} // RVA: 0x7AEAADA20
        public void GetIsCaseSensitive(){} // RVA: 0x7AEAADA80
        public void .cctor(){} // RVA: 0x7AEAADCA0
    }

    public class PathTooLongException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class PinnedBufferMemoryStream : UnmanagedMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC187B0
        public void Read(){} // RVA: 0x7ADC18900
        public void Write(){} // RVA: 0x7ADC18920
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void Dispose(){} // RVA: 0x7ADC18940
    }

    public class RenamedEventArgs : FileSystemEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAADCF0
    }

    public class RenamedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class SearchPattern2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAB3C60
        public void get_HasWildcard(){} // RVA: 0x7A8475E20
        public void Compile(){} // RVA: 0x7AEAB3CC0
        public void .cctor(){} // RVA: 0x7AEAB40F0
    }

    public class Stream : MarshalByRefObject
    {
        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7ADC3D030
        public void get_CanRead(){} // RVA: 0x7A7E01900
        public void get_CanSeek(){} // RVA: 0x7A7E01900
        public void get_CanTimeout(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A7E01900
        public void get_Length(){} // RVA: 0x7A7E00680
        public void get_Position(){} // RVA: 0x7A7E00680
        public void set_Position(){} // RVA: 0x7A7E188D0
        public void get_ReadTimeout(){} // RVA: 0x7ADC3D190
        public void set_ReadTimeout(){} // RVA: 0x7ADC3D1E0
        public void get_WriteTimeout(){} // RVA: 0x7ADC3D230
        public void set_WriteTimeout(){} // RVA: 0x7ADC3D280
        public void CopyToAsync(){} // RVA: 0x7ADC3D3F0
        public void CopyToAsyncInternal(){} // RVA: 0x7ADC3D450
        public void CopyTo(){} // RVA: 0x7ADC3D720
        public void GetCopyBufferSize(){} // RVA: 0x7ADC3D8F0
        public void Close(){} // RVA: 0x7ADC3D9F0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Flush(){} // RVA: 0x7A7E18770
        public void FlushAsync(){} // RVA: 0x7ADC3DAC0
        public void BeginRead(){} // RVA: 0x7ADC3DD30
        public void BeginReadInternal(){} // RVA: 0x7ADC3DD70
        public void EndRead(){} // RVA: 0x7ADC3E010
        public void ReadAsync(){} // RVA: 0x7ADC3E3E0
        public void BeginEndReadAsync(){} // RVA: 0x7ADC3E6B0
        public void BeginWrite(){} // RVA: 0x7ADC3EA10
        public void BeginWriteInternal(){} // RVA: 0x7ADC3EA50
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7ADC3ECF0
        public void RunReadWriteTask(){} // RVA: 0x7ADC3EF40
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7ADC3F0A0
        public void EndWrite(){} // RVA: 0x7ADC3F120
        public void WriteAsync(){} // RVA: 0x7ADC3F4F0
        public void FinishWriteAsync(){} // RVA: 0x7ADC3F8F0
        public void BeginEndWriteAsync(){} // RVA: 0x7ADC3FB00
        public void Seek(){} // RVA: 0x7A7E06460
        public void SetLength(){} // RVA: 0x7A7E188D0
        public void Read(){} // RVA: 0x7ADC3FE60
        public void ReadByte(){} // RVA: 0x7ADC40110
        public void Write(){} // RVA: 0x7ADC401C0
        public void WriteByte(){} // RVA: 0x7ADC40370
        public void BlockingBeginRead(){} // RVA: 0x7ADC40400
        public void BlockingEndRead(){} // RVA: 0x7ADC40540
        public void BlockingBeginWrite(){} // RVA: 0x7ADC40660
        public void BlockingEndWrite(){} // RVA: 0x7ADC407A0
        public void HasOverriddenBeginEndRead(){} // RVA: 0x7A81BD750
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x7A81BD750
        public void DisposeAsync(){} // RVA: 0x7ADC408C0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADC40970
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x7ADC40A60
    }

    public class StreamHelpers : Object
    {
        // ── Methods ──
        public void ValidateCopyToArgs(){} // RVA: 0x7ADC189D0
    }

    public class StreamReader : TextReader
    {
        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7ADC18CA0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7ADC18D40
        public void .ctor(){} // RVA: 0x7ADC19340
        public void Init(){} // RVA: 0x7ADC19930
        public void Close(){} // RVA: 0x7ADA9EB80
        public void Dispose(){} // RVA: 0x7ADC19990
        public void get_CurrentEncoding(){} // RVA: 0x7A81052C0
        public void get_BaseStream(){} // RVA: 0x7A80DA7B0
        public void get_LeaveOpen(){} // RVA: 0x7ADC19C20
        public void get_EndOfStream(){} // RVA: 0x7ADC19C30
        public void Peek(){} // RVA: 0x7ADC19CD0
        public void Read(){} // RVA: 0x7ADC1A030
        public void ReadSpan(){} // RVA: 0x7ADC1A140
        public void ReadToEnd(){} // RVA: 0x7ADC1A3F0
        public void CompressBuffer(){} // RVA: 0x7ADC1A530
        public void DetectEncoding(){} // RVA: 0x7ADC1A570
        public void IsPreamble(){} // RVA: 0x7ADC1AB10
        public void ReadBuffer(){} // RVA: 0x7ADC1B3D0
        public void ReadLine(){} // RVA: 0x7ADC1BD90
        public void ReadToEndAsync(){} // RVA: 0x7ADC1C010
        public void ReadToEndAsyncInternal(){} // RVA: 0x7ADC1C490
        public void ReadAsync(){} // RVA: 0x7ADC1C630
        public void ReadAsyncInternal(){} // RVA: 0x7ADC1C960
        public void ReadBufferAsync(){} // RVA: 0x7ADC1CC00
        public void DataAvailable(){} // RVA: 0x7ADC1CDB0
        public void .cctor(){} // RVA: 0x7ADC1CDC0
    }

    public class StreamWriter : TextWriter
    {
        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7ADC20100
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7ADC201A0
        public void get_UTF8NoBOM(){} // RVA: 0x7ADC201F0
        public void .ctor(){} // RVA: 0x7ADC20870
        public void Init(){} // RVA: 0x7ADC20BA0
        public void Close(){} // RVA: 0x7ADC20E70
        public void Dispose(){} // RVA: 0x7ADC20EE0
        public void DisposeAsync(){} // RVA: 0x7ADC211F0
        public void DisposeAsyncCore(){} // RVA: 0x7ADC21470
        public void CloseStreamFromDispose(){} // RVA: 0x7ADC21610
        public void Flush(){} // RVA: 0x7ADC216D0
        public void set_AutoFlush(){} // RVA: 0x7ADC21890
        public void get_BaseStream(){} // RVA: 0x7A83F69F0
        public void get_LeaveOpen(){} // RVA: 0x7ADC218D0
        public void get_Encoding(){} // RVA: 0x7A8292C30
        public void Write(){} // RVA: 0x7ADC21EF0
        public void WriteSpan(){} // RVA: 0x7ADC21C70
        public void WriteLine(){} // RVA: 0x7ADC21F70
        public void WriteAsync(){} // RVA: 0x7ADC22A00
        public void WriteAsyncInternal(){} // RVA: 0x7ADC22DA0
        public void WriteLineAsync(){} // RVA: 0x7ADC230E0
        public void FlushAsync(){} // RVA: 0x7ADC23480
        public void set_CharPos_Prop(){} // RVA: 0x7A87A7CF0
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x7A8F17000
        public void FlushAsyncInternal(){} // RVA: 0x7ADC23830
        public void .cctor(){} // RVA: 0x7ADC23C30
    }

    public class StringReader : TextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC48230
        public void Close(){} // RVA: 0x7ADA9EB80
        public void Dispose(){} // RVA: 0x7ADC48320
        public void Peek(){} // RVA: 0x7ADC48380
        public void Read(){} // RVA: 0x7ADC48430
        public void ReadToEnd(){} // RVA: 0x7ADC48640
        public void ReadLine(){} // RVA: 0x7ADC48690
        public void ReadToEndAsync(){} // RVA: 0x7ADC487B0
        public void ReadAsync(){} // RVA: 0x7ADC48830
    }

    public class StringWriter : TextWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC48C30
        public void Close(){} // RVA: 0x7ADC48D50
        public void Dispose(){} // RVA: 0x7A80E5850
        public void get_Encoding(){} // RVA: 0x7ADC48D70
        public void GetStringBuilder(){} // RVA: 0x7A83F69F0
        public void Write(){} // RVA: 0x7ADC490A0
        public void WriteAsync(){} // RVA: 0x7ADC49260
        public void WriteLineAsync(){} // RVA: 0x7ADC49350
        public void FlushAsync(){} // RVA: 0x7ADC49440
        public void ToString(){} // RVA: 0x7ADC494E0
    }

    public class TextReader : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Close(){} // RVA: 0x7ADC25D60
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Peek(){} // RVA: 0x7A85193D0
        public void Read(){} // RVA: 0x7ADC26060
        public void ReadToEnd(){} // RVA: 0x7ADC26300
        public void ReadLine(){} // RVA: 0x7ADC26450
        public void ReadToEndAsync(){} // RVA: 0x7ADC265D0
        public void ReadAsync(){} // RVA: 0x7ADC26780
        public void ReadAsyncInternal(){} // RVA: 0x7ADC269B0
        public void Synchronized(){} // RVA: 0x7ADC26E00
        public void .cctor(){} // RVA: 0x7ADC26F40
    }

    public class TextWriter : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC28080
        public void get_FormatProvider(){} // RVA: 0x7ADC28200
        public void Close(){} // RVA: 0x7ADC282A0
        public void Dispose(){} // RVA: 0x7ADC28310
        public void DisposeAsync(){} // RVA: 0x7ADC28380
        public void Flush(){} // RVA: 0x7A80D7310
        public void get_Encoding(){} // RVA: 0x7A7E00680
        public void get_NewLine(){} // RVA: 0x7A81052C0
        public void Write(){} // RVA: 0x7ADC28810
        public void WriteLine(){} // RVA: 0x7ADC28A40
        public void WriteAsync(){} // RVA: 0x7ADC290F0
        public void WriteLineAsync(){} // RVA: 0x7ADC293D0
        public void FlushAsync(){} // RVA: 0x7ADC296B0
        public void Synchronized(){} // RVA: 0x7ADC29940
        public void .cctor(){} // RVA: 0x7ADC29AA0
    }

    public class UnexceptionalStreamReader : StreamReader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADC56C30
        public void .ctor(){} // RVA: 0x7ADC56D20
        public void Peek(){} // RVA: 0x7ADC56DB0
        public void Read(){} // RVA: 0x7ADC56DF0
        public void CheckEOL(){} // RVA: 0x7ADC57060
        public void ReadLine(){} // RVA: 0x7ADC57250
        public void ReadToEnd(){} // RVA: 0x7ADC57270
    }

    public class UnexceptionalStreamWriter : StreamWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC573C0
        public void Flush(){} // RVA: 0x7ADC57440
        public void Write(){} // RVA: 0x7ADC574D0
    }

    public class UnmanagedMemoryAccessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9610FC0
        public void Initialize(){} // RVA: 0x7ADC2A930
        public void get_Capacity(){} // RVA: 0x7A81052C0
        public void Dispose(){} // RVA: 0x7ADC2AD80
        public void get_IsOpen(){} // RVA: 0x7A81B7080
    }

    public class UnmanagedMemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC2AED0
        public void Initialize(){} // RVA: 0x7ADC2AF60
        public void get_CanRead(){} // RVA: 0x7ADC2B1F0
        public void get_CanSeek(){} // RVA: 0x7A8175CC0
        public void get_CanWrite(){} // RVA: 0x7ADC2B200
        public void Dispose(){} // RVA: 0x7ADC2B220
        public void EnsureNotClosed(){} // RVA: 0x7ADC2B230
        public void EnsureReadable(){} // RVA: 0x7ADC2B270
        public void EnsureWriteable(){} // RVA: 0x7ADC2B2C0
        public void Flush(){} // RVA: 0x7ADC2B230
        public void FlushAsync(){} // RVA: 0x7ADC2B310
        public void get_Length(){} // RVA: 0x7ADC2B440
        public void get_Position(){} // RVA: 0x7ADC2B490
        public void set_Position(){} // RVA: 0x7ADC2B4E0
        public void get_PositionPointer(){} // RVA: 0x7ADC2B5A0
        public void Read(){} // RVA: 0x7ADC2B8C0
        public void ReadCore(){} // RVA: 0x7ADC2B9D0
        public void ReadAsync(){} // RVA: 0x7ADC2BFA0
        public void ReadByte(){} // RVA: 0x7ADC2C360
        public void Seek(){} // RVA: 0x7ADC2C4E0
        public void SetLength(){} // RVA: 0x7ADC2C6B0
        public void Write(){} // RVA: 0x7ADC2CAF0
        public void WriteCore(){} // RVA: 0x7ADC2CC00
        public void WriteAsync(){} // RVA: 0x7ADC2D230
        public void WriteByte(){} // RVA: 0x7ADC2D520
    }

    public class WaitForChangedResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E9ECF0
        public void set_ChangeType(){} // RVA: 0x7A76134D0
        public void set_Name(){} // RVA: 0x7A765F010
        public void set_OldName(){} // RVA: 0x7A7664E50
        public void set_TimedOut(){} // RVA: 0x7A7677A40
        public void .cctor(){} // RVA: 0x7AEAADF00
    }

    public class Win32Marshal : Object
    {
        // ── Methods ──
        public void GetExceptionForLastWin32Error(){} // RVA: 0x7ADC2DA30
        public void GetExceptionForWin32Error(){} // RVA: 0x7ADC2DA90
        public void MakeHRFromErrorCode(){} // RVA: 0x7ADC2DFD0
        public void TryMakeWin32ErrorCodeFromHR(){} // RVA: 0x7ADC2DFF0
        public void GetMessage(){} // RVA: 0x7AD9DF770
    }

    public class __Error : Object
    {
        // ── Methods ──
        public void EndOfFile(){} // RVA: 0x7ADC43F40
        public void FileNotOpen(){} // RVA: 0x7ADC43FA0
        public void ReaderClosed(){} // RVA: 0x7ADC44010
        public void GetDisplayablePath(){} // RVA: 0x7ADC44080
        public void WinIOError(){} // RVA: 0x7ADC441E0
        public void WriterClosed(){} // RVA: 0x7ADC44A00
    }

}