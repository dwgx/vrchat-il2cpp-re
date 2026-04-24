// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO
// Classes: 17
// Methods: 449

namespace ThirdParty.DotNet.System.IO
{
    public class DirectoryInfo : FileSystemInfo
    {
        public object Parent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539F8C10 | overloaded x3
        public void Init(){} // RVA: 0x7FFD539F7E20
        public void get_Parent(){} // RVA: 0x7FFD539F83A0
        public void Create(){} // RVA: 0x7FFD539F8570
        public void GetFiles(){} // RVA: 0x7FFD539F8700 | overloaded x3
        public void EnumerateFiles(){} // RVA: 0x7FFD539F8910 | overloaded x3
        public void InternalEnumerateInfos(){} // RVA: 0x7FFD539F89B0
        public void Delete(){} // RVA: 0x7FFD539F8BB0
    }

    public class DisableMediaInsertionPrompt : ValueType
    {
        public bool _disableSuccess; // 0x10
        public uint _oldMode; // 0x14
        public bool useUWPFallback;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD539D72B0
        public void Dispose(){} // RVA: 0x7FFD539D7330
    }

    public class EnumerationOptions : Object
    {
        public Inherited.? Compatible;
        public Inherited.? CompatibleRecursive; // 0x8
        public Inherited.? Default; // 0x10
        public bool RecurseSubdirectories; // 0x10
        public bool IgnoreInaccessible; // 0x11
        public int BufferSize; // 0x14
        public Inherited.1460699808ED5F8D48C6B09EED448CDAE597EBF52B010901CD6F75A767B047 AttributesToSkip; // 0x18
        public Inherited.Pointer MatchType; // 0x1C
        public Inherited.entSourceAttribute MatchCasing; // 0x20
        public bool ReturnSpecialDirectories; // 0x24

        // ── Methods ──
        public void get_Compatible(){} // RVA: 0x7FFD539F8C30
        public void get_CompatibleRecursive(){} // RVA: 0x7FFD539F8C90
        public void get_Default(){} // RVA: 0x7FFD539F8CF0
        public void .ctor(){} // RVA: 0x7FFD539F8D50
        public void FromSearchOption(){} // RVA: 0x7FFD539F8D60
        public void get_RecurseSubdirectories(){} // RVA: 0x7FFD4E40B5E0
        public void set_RecurseSubdirectories(){} // RVA: 0x7FFD4E40B5F0
        public void get_IgnoreInaccessible(){} // RVA: 0x7FFD4EB91DA0
        public void set_IgnoreInaccessible(){} // RVA: 0x7FFD4EB91D90
        public void get_BufferSize(){} // RVA: 0x7FFD4E7F5A20
        public void get_AttributesToSkip(){} // RVA: 0x7FFD4E577800
        public void set_AttributesToSkip(){} // RVA: 0x7FFD4ED4CD10
        public void get_MatchType(){} // RVA: 0x7FFD4F8557F0
        public void set_MatchType(){} // RVA: 0x7FFD4F8674D0
        public void get_MatchCasing(){} // RVA: 0x7FFD4E4FBBE0
        public void get_ReturnSpecialDirectories(){} // RVA: 0x7FFD4E35C7C0
        public void .cctor(){} // RVA: 0x7FFD539F8E80
    }

    public class FileInfo : FileSystemInfo
    {
        public object Length;
        public object DirectoryName;
        public object Directory;
        public object IsReadOnly;
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539F8C10 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFD539FBA60
        public void get_DirectoryName(){} // RVA: 0x7FFD539FBB10
        public void get_Directory(){} // RVA: 0x7FFD539FBB70
        public void get_IsReadOnly(){} // RVA: 0x7FFD539FBC20
        public void set_IsReadOnly(){} // RVA: 0x7FFD539FBC40
        public void CreateText(){} // RVA: 0x7FFD539FBC90
        public void AppendText(){} // RVA: 0x7FFD539FBD00
        public void Delete(){} // RVA: 0x7FFD539FBD70
        public void get_Name(){} // RVA: 0x7FFD4E3E20E0
    }

    public class FileStream : Stream
    {
        public int CanRead;
        public byte[] CanWrite;
        public object CanSeek; // 0x8
        public byte[] Name; // 0x28
        public string Length; // 0x30
        public 01B30335EAF483F59E5EDCB41DF7C4807E1B.6F96387473C649F557670B8A92E175272491DFC646754F4A9D Position; // 0x38
        public bool SafeFileHandle; // 0x40
        public long append_startpos; // 0x48
        public Inherited.nAppX access; // 0x50
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
        public void .ctor(){} // RVA: 0x7FFD53A127A0 | overloaded x12
        public void Init(){} // RVA: 0x7FFD53A13200
        public void get_CanRead(){} // RVA: 0x7FFD53A13570
        public void get_CanWrite(){} // RVA: 0x7FFD53A13590
        public void get_CanSeek(){} // RVA: 0x7FFD53A135B0
        public void get_Name(){} // RVA: 0x7FFD4E5F95E0
        public void get_Length(){} // RVA: 0x7FFD53A135C0
        public void get_Position(){} // RVA: 0x7FFD53A13760
        public void set_Position(){} // RVA: 0x7FFD53A13920
        public void get_SafeFileHandle(){} // RVA: 0x7FFD53A139C0
        public void ExposeHandle(){} // RVA: 0x7FFD53A13A00
        public void ReadByte(){} // RVA: 0x7FFD53A13A30
        public void WriteByte(){} // RVA: 0x7FFD53A13BA0
        public void Read(){} // RVA: 0x7FFD53A13D00
        public void ReadInternal(){} // RVA: 0x7FFD53A140B0
        public void BeginRead(){} // RVA: 0x7FFD53A14180
        public void EndRead(){} // RVA: 0x7FFD53A145D0
        public void Write(){} // RVA: 0x7FFD53A147E0
        public void WriteInternal(){} // RVA: 0x7FFD53A14AB0
        public void BeginWrite(){} // RVA: 0x7FFD53A14CF0
        public void EndWrite(){} // RVA: 0x7FFD53A15190
        public void Seek(){} // RVA: 0x7FFD53A15390
        public void SetLength(){} // RVA: 0x7FFD53A156A0
        public void Flush(){} // RVA: 0x7FFD53A15940
        public void Finalize(){} // RVA: 0x7FFD53869EF0
        public void Dispose(){} // RVA: 0x7FFD53A159C0
        public void FlushAsync(){} // RVA: 0x7FFD53A15DD0
        public void ReadAsync(){} // RVA: 0x7FFD53A15E50
        public void WriteAsync(){} // RVA: 0x7FFD53A15E60
        public void ReadSegment(){} // RVA: 0x7FFD53A15E70
        public void WriteSegment(){} // RVA: 0x7FFD53A15F80
        public void FlushBuffer(){} // RVA: 0x7FFD53A15FF0
        public void FlushBufferIfDirty(){} // RVA: 0x7FFD53A161E0
        public void RefillBuffer(){} // RVA: 0x7FFD53A161F0
        public void ReadData(){} // RVA: 0x7FFD53A16230
        public void InitBuffer(){} // RVA: 0x7FFD53A16370
        public void GetSecureFileName(){} // RVA: 0x7FFD53A16800 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD53A168F0
    }

    public class FileSystemInfo : MarshalByRefObject
    {
        public D48C6B09EED448CDAE597EBF52B010901CD6F75A767B047 Attributes; // 0x18
        public int ExistsCore; // 0x3C
        public string CreationTimeCore; // 0x40
        public string LastAccessTimeCore; // 0x48
        public string LastWriteTimeCore; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539FC3C0 | overloaded x2
        public void Create(){} // RVA: 0x7FFD539FBD80
        public void Invalidate(){} // RVA: 0x7FFD539FB7E0
        public void Init(){} // RVA: 0x7FFD539FBF80
        public void get_Attributes(){} // RVA: 0x7FFD539FBFD0
        public void set_Attributes(){} // RVA: 0x7FFD539FBFF0
        public void get_ExistsCore(){} // RVA: 0x7FFD539FC0D0
        public void get_CreationTimeCore(){} // RVA: 0x7FFD539FC160
        public void get_LastAccessTimeCore(){} // RVA: 0x7FFD539FC1A0
        public void get_LastWriteTimeCore(){} // RVA: 0x7FFD539FC1E0
        public void get_LengthCore(){} // RVA: 0x7FFD539FC220
        public void EnsureDataInitialized(){} // RVA: 0x7FFD539FC250
        public void Refresh(){} // RVA: 0x7FFD539FC2C0
        public void get_NormalizedPath(){} // RVA: 0x7FFD539FC2F0
        public void GetObjectData(){} // RVA: 0x7FFD539FC620
        public void get_FullName(){} // RVA: 0x7FFD4E3BE740
        public void get_Name(){} // RVA: 0x7FFD4E3E20E0
        public void get_Exists(){} // RVA: 0x7FFD539FCA50
        public void Delete(){} // RVA: 0x7FFD4E090980
        public void get_CreationTimeUtc(){} // RVA: 0x7FFD539FCAE0
        public void get_LastAccessTime(){} // RVA: 0x7FFD539FCB90
        public void get_LastAccessTimeUtc(){} // RVA: 0x7FFD539FCCC0
        public void get_LastWriteTime(){} // RVA: 0x7FFD539FCD70
        public void get_LastWriteTimeUtc(){} // RVA: 0x7FFD539FCEA0
        public void ToString(){} // RVA: 0x7FFD539FCF50
    }

    public class MonoIO : Object
    {
        public UIntPtr ConsoleOutput;
        public bool ConsoleInput; // 0x8

        // ── Methods ──
        public void GetException(){} // RVA: 0x7FFD53A17110 | overloaded x2
        public void GetCurrentDirectory(){} // RVA: 0x7FFD53A17980
        public void GetFileType(){} // RVA: 0x7FFD53A17A20 | overloaded x2
        public void FindCloseFile(){} // RVA: 0x7FFD53A17B30
        public void Open(){} // RVA: 0x7FFD53A17DA0 | overloaded x2
        public void Cancel_internal(){} // RVA: 0x7FFD53A17EF0
        public void Cancel(){} // RVA: 0x7FFD53A17F10
        public void Close(){} // RVA: 0x7FFD53A18030
        public void Read(){} // RVA: 0x7FFD53A18100 | overloaded x2
        public void Write(){} // RVA: 0x7FFD53A18320 | overloaded x2
        public void Seek(){} // RVA: 0x7FFD53A184D0 | overloaded x2
        public void GetLength(){} // RVA: 0x7FFD53A18680 | overloaded x2
        public void SetLength(){} // RVA: 0x7FFD53A18870 | overloaded x2
        public void get_ConsoleOutput(){} // RVA: 0x7FFD53A18A40
        public void get_ConsoleInput(){} // RVA: 0x7FFD53A18A50
        public void get_ConsoleError(){} // RVA: 0x7FFD53A18A60
        public void CreatePipe(){} // RVA: 0x7FFD53A18A70
        public void DuplicateHandle(){} // RVA: 0x7FFD53A18B70
        public void get_VolumeSeparatorChar(){} // RVA: 0x7FFD53A18C60
        public void get_DirectorySeparatorChar(){} // RVA: 0x7FFD5072F580
        public void get_AltDirectorySeparatorChar(){} // RVA: 0x7FFD53A18C70
        public void get_PathSeparator(){} // RVA: 0x7FFD53A18C80
        public void DumpHandles(){} // RVA: 0x7FFD53953400
        public void RemapPath(){} // RVA: 0x7FFD53A18C90
        public void .cctor(){} // RVA: 0x7FFD53A18CA0
    }

    public class MonoLinqHelper : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFD4E078F80
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
        public void ChangeExtension(){} // RVA: 0x7FFD53A18D20
        public void Combine(){} // RVA: 0x7FFD53A1D440 | overloaded x4
        public void CleanPath(){} // RVA: 0x7FFD53A192B0
        public void GetDirectoryName(){} // RVA: 0x7FFD53A19C20 | overloaded x2
        public void GetExtension(){} // RVA: 0x7FFD53A19D00
        public void GetFileName(){} // RVA: 0x7FFD53A1D680 | overloaded x2
        public void GetFileNameWithoutExtension(){} // RVA: 0x7FFD53A19F80
        public void GetFullPath(){} // RVA: 0x7FFD53A19FE0
        public void GetFullPathInternal(){} // RVA: 0x7FFD53A1A030
        public void GetFullPathName(){} // RVA: 0x7FFD53A1A170 | overloaded x2
        public void WindowsDriveAdjustment(){} // RVA: 0x7FFD53A1A420
        public void InsecureGetFullPath(){} // RVA: 0x7FFD53A1A660
        public void IsDirectorySeparator(){} // RVA: 0x7FFD53A1AC90
        public void GetPathRoot(){} // RVA: 0x7FFD53A1AD20
        public void GetTempPath(){} // RVA: 0x7FFD53A1B1C0
        public void get_temp_path(){} // RVA: 0x7FFD53A1B430
        public void IsPathRooted(){} // RVA: 0x7FFD53A1B6B0 | overloaded x2
        public void GetInvalidFileNameChars(){} // RVA: 0x7FFD53A1B8F0
        public void GetInvalidPathChars(){} // RVA: 0x7FFD53A1B960
        public void GetRandomFileName(){} // RVA: 0x7FFD53A1B9D0
        public void findExtension(){} // RVA: 0x7FFD53A1BB70
        public void .cctor(){} // RVA: 0x7FFD53A1BC20
        public void GetServerAndShare(){} // RVA: 0x7FFD53A1C0E0
        public void SameRoot(){} // RVA: 0x7FFD53A1C340
        public void CanonicalizePath(){} // RVA: 0x7FFD53A1C6A0
        public void Join(){} // RVA: 0x7FFD53A1D8F0 | overloaded x2
        public void JoinInternal(){} // RVA: 0x7FFD53A1E160 | overloaded x2
        public void GetRelativePath(){} // RVA: 0x7FFD53A1E840 | overloaded x2
        public void get_StringComparison(){} // RVA: 0x7FFD53A1EF90
        public void get_IsCaseSensitive(){} // RVA: 0x7FFD53A1F040
        public void get_IsWindows(){} // RVA: 0x7FFD53A1F0B0
    }

    public class PathInternal : Object
    {
        public bool IsCaseSensitive;

        // ── Methods ──
        public void IsValidDriveChar(){} // RVA: 0x7FFD539DFDC0
        public void EndsWithPeriodOrSpace(){} // RVA: 0x7FFD539DFDE0
        public void EnsureExtendedPrefixIfNeeded(){} // RVA: 0x7FFD539DFE30
        public void EnsureExtendedPrefix(){} // RVA: 0x7FFD539DFEE0
        public void IsDevice(){} // RVA: 0x7FFD539E0130
        public void IsDeviceUNC(){} // RVA: 0x7FFD539E0300
        public void IsExtended(){} // RVA: 0x7FFD539E03F0
        public void GetRootLength(){} // RVA: 0x7FFD539E0480
        public void IsDirectorySeparator(){} // RVA: 0x7FFD539E0870
        public void IsEffectivelyEmpty(){} // RVA: 0x7FFD539E0890
        public void EndsInDirectorySeparator(){} // RVA: 0x7FFD539E0910
        public void StartsWithDirectorySeparator(){} // RVA: 0x7FFD539E09B0
        public void TrimEndingDirectorySeparator(){} // RVA: 0x7FFD539E0C60 | overloaded x2
        public void IsRoot(){} // RVA: 0x7FFD539E0E40
        public void GetCommonPathLength(){} // RVA: 0x7FFD539E0EB0
        public void EqualStartingCharacterCount(){} // RVA: 0x7FFD539E10F0
        public void AreRootsEqual(){} // RVA: 0x7FFD539E1210
        public void get_IsCaseSensitive(){} // RVA: 0x7FFD539E1370
        public void GetIsCaseSensitive(){} // RVA: 0x7FFD539E13D0
        public void IsPartiallyQualified(){} // RVA: 0x7FFD4E341320
        public void .cctor(){} // RVA: 0x7FFD539E15F0
    }

    public class Stream : MarshalByRefObject
    {
        public Inherited.? CanRead;
        public int CanSeek;
        public _bucket CanTimeout; // 0x18
        public sageKind.StringComparison CanWrite; // 0x20

        // ── Methods ──
        public void EnsureAsyncActiveSemaphoreInitialized(){} // RVA: 0x7FFD53A05D10
        public void get_CanRead(){} // RVA: 0x7FFD4E079D00
        public void get_CanSeek(){} // RVA: 0x7FFD4E079D00
        public void get_CanTimeout(){} // RVA: 0x7FFD4E341320
        public void get_CanWrite(){} // RVA: 0x7FFD4E079D00
        public void get_Length(){} // RVA: 0x7FFD4E078E90
        public void get_Position(){} // RVA: 0x7FFD4E078E90
        public void set_Position(){} // RVA: 0x7FFD4E090BF0
        public void get_ReadTimeout(){} // RVA: 0x7FFD53A05E70
        public void set_ReadTimeout(){} // RVA: 0x7FFD53A05EC0
        public void get_WriteTimeout(){} // RVA: 0x7FFD53A05F10
        public void set_WriteTimeout(){} // RVA: 0x7FFD53A05F60
        public void CopyToAsync(){} // RVA: 0x7FFD53A060D0 | overloaded x3
        public void CopyToAsyncInternal(){} // RVA: 0x7FFD53A06130
        public void CopyTo(){} // RVA: 0x7FFD53A06400 | overloaded x2
        public void GetCopyBufferSize(){} // RVA: 0x7FFD53A065D0
        public void Close(){} // RVA: 0x7FFD53A066D0
        public void Dispose(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFD4E090980
        public void FlushAsync(){} // RVA: 0x7FFD53A067A0 | overloaded x2
        public void BeginRead(){} // RVA: 0x7FFD53A06A00
        public void BeginReadInternal(){} // RVA: 0x7FFD53A06A40
        public void EndRead(){} // RVA: 0x7FFD53A06CD0
        public void ReadAsync(){} // RVA: 0x7FFD53A070A0 | overloaded x3
        public void BeginEndReadAsync(){} // RVA: 0x7FFD53A07370
        public void BeginWrite(){} // RVA: 0x7FFD53A076D0
        public void BeginWriteInternal(){} // RVA: 0x7FFD53A07710
        public void RunReadWriteTaskWhenReady(){} // RVA: 0x7FFD53A079A0
        public void RunReadWriteTask(){} // RVA: 0x7FFD53A07BF0
        public void FinishTrackingAsyncOperation(){} // RVA: 0x7FFD53A07D50
        public void EndWrite(){} // RVA: 0x7FFD53A07DD0
        public void WriteAsync(){} // RVA: 0x7FFD53A081A0 | overloaded x3
        public void FinishWriteAsync(){} // RVA: 0x7FFD53A08590
        public void BeginEndWriteAsync(){} // RVA: 0x7FFD53A087A0
        public void Seek(){}
        public void SetLength(){} // RVA: 0x7FFD4E090BF0
        public void Read(){} // RVA: 0x7FFD53A08B00 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFD53A08DA0
        public void Write(){} // RVA: 0x7FFD53A08E50 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFD53A08FF0
        public void BlockingBeginRead(){} // RVA: 0x7FFD53A09080
        public void BlockingEndRead(){} // RVA: 0x7FFD53A091C0
        public void BlockingBeginWrite(){} // RVA: 0x7FFD53A092E0
        public void BlockingEndWrite(){} // RVA: 0x7FFD53A09420
        public void HasOverriddenBeginEndRead(){} // RVA: 0x7FFD4E426850
        public void HasOverriddenBeginEndWrite(){} // RVA: 0x7FFD4E426850
        public void DisposeAsync(){} // RVA: 0x7FFD53A09540
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53A095F0
        public void <ReadAsync>g__FinishReadAsync|44_0(){} // RVA: 0x7FFD53A096E0
    }

    public class StreamReader : TextReader
    {
        public object CurrentEncoding;
        public object BaseStream;
        public object LeaveOpen;
        public object EndOfStream;

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFD539E1BA0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFD539E1C40
        public void .ctor(){} // RVA: 0x7FFD539E2240 | overloaded x11
        public void Init(){} // RVA: 0x7FFD539E2820 | overloaded x2
        public void Close(){} // RVA: 0x7FFD538680E0
        public void Dispose(){} // RVA: 0x7FFD539E2880
        public void get_CurrentEncoding(){} // RVA: 0x7FFD4E36F0C0
        public void get_BaseStream(){} // RVA: 0x7FFD4E3447C0
        public void get_LeaveOpen(){} // RVA: 0x7FFD539E2B20
        public void get_EndOfStream(){} // RVA: 0x7FFD539E2B30
        public void Peek(){} // RVA: 0x7FFD539E2BD0
        public void Read(){} // RVA: 0x7FFD539E2F30 | overloaded x3
        public void ReadSpan(){} // RVA: 0x7FFD539E3040
        public void ReadToEnd(){} // RVA: 0x7FFD539E32F0
        public void CompressBuffer(){} // RVA: 0x7FFD539E3430
        public void DetectEncoding(){} // RVA: 0x7FFD539E3470
        public void IsPreamble(){} // RVA: 0x7FFD539E3A10
        public void ReadBuffer(){} // RVA: 0x7FFD539E42B0 | overloaded x2
        public void ReadLine(){} // RVA: 0x7FFD539E4C60
        public void ReadToEndAsync(){} // RVA: 0x7FFD539E4EC0
        public void ReadToEndAsyncInternal(){} // RVA: 0x7FFD539E5340
        public void ReadAsync(){} // RVA: 0x7FFD539E54E0
        public void ReadAsyncInternal(){} // RVA: 0x7FFD539E5810
        public void ReadBufferAsync(){} // RVA: 0x7FFD539E5AB0
        public void DataAvailable(){} // RVA: 0x7FFD539E5C60
        public void .cctor(){} // RVA: 0x7FFD539E5C70
    }

    public class StreamWriter : TextWriter
    {
        public object UTF8NoBOM;
        public object AutoFlush;
        public object BaseStream;
        public object LeaveOpen;
        public object Encoding;
        public object CharPos_Prop;
        public object HaveWrittenPreamble_Prop;

        // ── Methods ──
        public void CheckAsyncTaskInProgress(){} // RVA: 0x7FFD539E8DE0
        public void ThrowAsyncIOInProgress(){} // RVA: 0x7FFD539E8E80
        public void get_UTF8NoBOM(){} // RVA: 0x7FFD539E8ED0
        public void .ctor(){} // RVA: 0x7FFD539E9550 | overloaded x9
        public void Init(){} // RVA: 0x7FFD539E9860
        public void Close(){} // RVA: 0x7FFD539E9B30
        public void Dispose(){} // RVA: 0x7FFD539E9BA0
        public void DisposeAsync(){} // RVA: 0x7FFD539E9ED0
        public void DisposeAsyncCore(){} // RVA: 0x7FFD539EA150
        public void CloseStreamFromDispose(){} // RVA: 0x7FFD539EA2F0
        public void Flush(){} // RVA: 0x7FFD539EA3C0 | overloaded x2
        public void set_AutoFlush(){} // RVA: 0x7FFD539EA5B0
        public void get_BaseStream(){} // RVA: 0x7FFD4E5F95E0
        public void get_LeaveOpen(){} // RVA: 0x7FFD539EA5F0
        public void get_Encoding(){} // RVA: 0x7FFD4E5F0140
        public void Write(){} // RVA: 0x7FFD539EAC10 | overloaded x4
        public void WriteSpan(){} // RVA: 0x7FFD539EA990
        public void WriteLine(){} // RVA: 0x7FFD539EAC90
        public void WriteAsync(){} // RVA: 0x7FFD539EB700 | overloaded x3
        public void WriteAsyncInternal(){} // RVA: 0x7FFD539EBAA0 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFD539EBDF0
        public void FlushAsync(){} // RVA: 0x7FFD539EC190
        public void set_CharPos_Prop(){} // RVA: 0x7FFD4EA4EA00
        public void set_HaveWrittenPreamble_Prop(){} // RVA: 0x7FFD4F024530
        public void FlushAsyncInternal(){} // RVA: 0x7FFD539EC540 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD539EC930
    }

    public class StringReader : TextReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A10E70
        public void Close(){} // RVA: 0x7FFD538680E0
        public void Dispose(){} // RVA: 0x7FFD53A10F60
        public void Peek(){} // RVA: 0x7FFD53A10FC0
        public void Read(){} // RVA: 0x7FFD53A11070 | overloaded x2
        public void ReadToEnd(){} // RVA: 0x7FFD53A11280
        public void ReadLine(){} // RVA: 0x7FFD53A112E0
        public void ReadToEndAsync(){} // RVA: 0x7FFD53A11410
        public void ReadAsync(){} // RVA: 0x7FFD53A11490
    }

    public class TextReader : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Close(){} // RVA: 0x7FFD539EEA30
        public void Dispose(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void Peek(){} // RVA: 0x7FFD4E6DD0E0
        public void Read(){} // RVA: 0x7FFD539EED20 | overloaded x3
        public void ReadToEnd(){} // RVA: 0x7FFD539EEFC0
        public void ReadLine(){} // RVA: 0x7FFD539EF100
        public void ReadToEndAsync(){} // RVA: 0x7FFD539EF280
        public void ReadAsync(){} // RVA: 0x7FFD539EF430
        public void ReadAsyncInternal(){} // RVA: 0x7FFD539EF660
        public void Synchronized(){} // RVA: 0x7FFD539EFAB0
        public void .cctor(){} // RVA: 0x7FFD539EFBF0
    }

    public class TextWriter : MarshalByRefObject
    {
        public Inherited.endency FormatProvider;
        public char[] Encoding; // 0x8
        public char[] NewLine; // 0x18
        public string CoreNewLineStr; // 0x20
        public nalGetValue _internalFormatProvider; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539F0D30 | overloaded x2
        public void get_FormatProvider(){} // RVA: 0x7FFD539F0EB0
        public void Close(){} // RVA: 0x7FFD539F0F50
        public void Dispose(){} // RVA: 0x7FFD539F0FC0 | overloaded x2
        public void DisposeAsync(){} // RVA: 0x7FFD539F1030
        public void Flush(){} // RVA: 0x7FFD4E341310
        public void get_Encoding(){} // RVA: 0x7FFD4E078E90
        public void get_NewLine(){} // RVA: 0x7FFD4E36F0C0
        public void Write(){} // RVA: 0x7FFD539F14B0 | overloaded x8
        public void WriteLine(){} // RVA: 0x7FFD539F16E0 | overloaded x5
        public void WriteAsync(){} // RVA: 0x7FFD539F1D70 | overloaded x3
        public void WriteLineAsync(){} // RVA: 0x7FFD539F2040
        public void FlushAsync(){} // RVA: 0x7FFD539F2310
        public void Synchronized(){} // RVA: 0x7FFD539F25A0
        public void .cctor(){} // RVA: 0x7FFD539F2700
    }

    public class UnmanagedMemoryStream : Stream
    {
        public annelDataStore.tionLevelActivator CanRead; // 0x28
        public IntPtr CanSeek; // 0x30
        public long CanWrite; // 0x38
        public long Length; // 0x40
        public long Position; // 0x48
        public long PositionPointer; // 0x50
        public Inherited.nAppX _access; // 0x58
        public bool _isOpen; // 0x5C
        public utes.?<int> _lastReadTask; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539F3B20 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFD539F3BB0
        public void get_CanRead(){} // RVA: 0x7FFD539F3E40
        public void get_CanSeek(){} // RVA: 0x7FFD4E3DF240
        public void get_CanWrite(){} // RVA: 0x7FFD539F3E60
        public void Dispose(){} // RVA: 0x7FFD539F3E80
        public void EnsureNotClosed(){} // RVA: 0x7FFD539F3E90
        public void EnsureReadable(){} // RVA: 0x7FFD539F3ED0
        public void EnsureWriteable(){} // RVA: 0x7FFD539F3F20
        public void Flush(){} // RVA: 0x7FFD539F3E90
        public void FlushAsync(){} // RVA: 0x7FFD539F3F70
        public void get_Length(){} // RVA: 0x7FFD539F40A0
        public void get_Position(){} // RVA: 0x7FFD539F40F0
        public void set_Position(){} // RVA: 0x7FFD539F4140
        public void get_PositionPointer(){} // RVA: 0x7FFD539F4200
        public void Read(){} // RVA: 0x7FFD539F4520 | overloaded x2
        public void ReadCore(){} // RVA: 0x7FFD539F4630
        public void ReadAsync(){} // RVA: 0x7FFD539F4C10 | overloaded x2
        public void ReadByte(){} // RVA: 0x7FFD539F4FC0
        public void Seek(){} // RVA: 0x7FFD539F5140
        public void SetLength(){} // RVA: 0x7FFD539F5310
        public void Write(){} // RVA: 0x7FFD539F5750 | overloaded x2
        public void WriteCore(){} // RVA: 0x7FFD539F5860
        public void WriteAsync(){} // RVA: 0x7FFD539F5E90 | overloaded x2
        public void WriteByte(){} // RVA: 0x7FFD539F6180
    }

}