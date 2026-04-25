// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Enumeration
// Classes: 5
// Methods: 56

namespace ThirdParty.DotNet.System.IO.Enumeration
{
    public class FileSystemEntry : ValueType
    {
        public FILE_FULL_DIR_INFORMATION* Directory; // 0x10
        public System.ReadOnlySpan`1<char> RootDirectory; // 0x18
        public System.ReadOnlySpan`1<char> OriginalRootDirectory; // 0x28
        public System.ReadOnlySpan`1<char> FileName; // 0x38

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC8600DB0
        public void get_Directory(){} // RVA: 0x7FFAC4A927D0
        public void set_Directory(){} // RVA: 0x7FFAC4A98120
        public void get_RootDirectory(){} // RVA: 0x7FFAC35D3330
        public void set_RootDirectory(){} // RVA: 0x7FFAC35D34F0
        public void get_OriginalRootDirectory(){} // RVA: 0x7FFAC3BCF020
        public void set_OriginalRootDirectory(){} // RVA: 0x7FFAC3BCC210
        public void get_FileName(){} // RVA: 0x7FFAC8600DD0
        public void get_Attributes(){} // RVA: 0x7FFAC8600E40
        public void get_IsDirectory(){} // RVA: 0x7FFAC8600E60
        public void ToFileSystemInfo(){} // RVA: 0x7FFAC8600E80
        public void ToSpecifiedFullPath(){} // RVA: 0x7FFAC8601020
    }

    public class FileSystemEnumerableFactory : Object
    {
        public char[] s_unixEscapeChars;

        // ── Methods ──
        public void NormalizeInputs(){} // RVA: 0x7FFAC8601340
        public void MatchesPattern(){} // RVA: 0x7FFAC8601AA0
        public void UserFiles(){} // RVA: 0x7FFAC8601D70
        public void UserDirectories(){} // RVA: 0x7FFAC86020B0
        public void UserEntries(){} // RVA: 0x7FFAC86023F0
        public void FileInfos(){} // RVA: 0x7FFAC8602730
        public void DirectoryInfos(){} // RVA: 0x7FFAC8602A70
        public void FileSystemInfos(){} // RVA: 0x7FFAC8602DB0
        public void .cctor(){} // RVA: 0x7FFAC86030F0
    }

    public class FileSystemEnumerable`1 : Object
    {
        public DelegateEnumerator<T> ShouldIncludePredicate;
        public FindTransform<T> ShouldRecursePredicate;
        public System.IO.EnumerationOptions _options;
        public string _directory;
        public FindPredicate<T> <ShouldIncludePredicate>k__BackingField;
        public FindPredicate<T> <ShouldRecursePredicate>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void get_ShouldIncludePredicate(){} // RVA: 0x7FFAC2C58E90
        public void set_ShouldIncludePredicate(){} // RVA: 0x7FFAC2C70A40
        public void get_ShouldRecursePredicate(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public string Current; // 0x10
        public string System.Collections.IEnumerator.Current; // 0x18
        public System.IO.EnumerationOptions _options; // 0x20
        public object _lock; // 0x28
        public FILE_FULL_DIR_INFORMATION* _entry; // 0x30
        public T _current; // 0x38
        public UIntPtr _buffer; // 0x40
        public int _bufferLength; // 0x48
        public UIntPtr _directoryHandle; // 0x50
        public string _currentPath; // 0x58
        public bool _lastEntryFound; // 0x60
        public System.Collections.Generic.Queue`1<System.ValueTuple`2<UIntPtr,string>> _pending; // 0x68

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x7FFAC5C7EED0
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x7FFAC5C7F0E0
        public void .ctor(){} // RVA: 0x7FFAC5C7F110
        public void CloseDirectoryHandle(){} // RVA: 0x7FFAC5C7F720
        public void CreateDirectoryHandle(){} // RVA: 0x7FFAC5C7F770
        public void ContinueOnDirectoryError(){} // RVA: 0x7FFAC5C7F980
        public void MoveNext(){} // RVA: 0x7FFAC5C7FA10
        public void FindNextEntry(){} // RVA: 0x7FFAC5C80840
        public void DequeueNextDirectory(){} // RVA: 0x7FFAC5C809E0
        public void InternalDispose(){} // RVA: 0x7FFAC5C80B50
        public void GetData(){} // RVA: 0x7FFAC5C81120
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x7FFAC5C81380
        public void ShouldIncludeEntry(){} // RVA: 0x7FFAC3006850
        public void ShouldRecurseIntoEntry(){} // RVA: 0x7FFAC3006850
        public void TransformEntry(){} // RVA: 0x7FFAC2E5B230
        public void OnDirectoryFinished(){} // RVA: 0x7FFAC2F21310
        public void ContinueOnError(){} // RVA: 0x7FFAC2F21320
        public void get_Current(){} // RVA: 0x7FFAC2E5B230
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC5C81580
        public void DirectoryFinished(){} // RVA: 0x7FFAC5C81630
        public void Reset(){} // RVA: 0x7FFAC5394E60
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC5C818A0
    }

    public class FileSystemName : Object
    {
        public char[] s_wildcardChars;
        public char[] s_simpleWildcardChars; // 0x8

        // ── Methods ──
        public void TranslateWin32Expression(){} // RVA: 0x7FFAC8603950
        public void MatchesWin32Expression(){} // RVA: 0x7FFAC8603D30
        public void MatchesSimpleExpression(){} // RVA: 0x7FFAC8603DC0
        public void MatchPattern(){} // RVA: 0x7FFAC8603E50
        public void .cctor(){} // RVA: 0x7FFAC8604780
    }

}