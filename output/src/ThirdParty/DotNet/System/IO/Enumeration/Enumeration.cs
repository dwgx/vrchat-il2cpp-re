// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Enumeration
// Classes: 10
// Methods: 140

namespace ThirdParty.DotNet.System.IO.Enumeration
{
    public class FileSystemEntry
    {
        public FILE_FULL_DIR_INFORMATION* _info; // 0x10
        public System.ReadOnlySpan`1<char> <Directory>k__BackingField; // 0x18
        public System.ReadOnlySpan`1<char> <RootDirectory>k__BackingField; // 0x28
        public System.ReadOnlySpan`1<char> <OriginalRootDirectory>k__BackingField; // 0x38

        // ── Methods ──
        public void Initialize(){} // RVA: 0x5E69740
        public void get_Directory(){} // RVA: 0x1F6F090
        public void set_Directory(){} // RVA: 0x1F74E00
        public void get_RootDirectory(){} // RVA: 0x994EE0
        public void set_RootDirectory(){} // RVA: 0x9949A0
        public void get_OriginalRootDirectory(){} // RVA: 0x111F520
        public void set_OriginalRootDirectory(){} // RVA: 0x111C380
        public void get_FileName(){} // RVA: 0x5E69760
        public void get_Attributes(){} // RVA: 0x5E697D0
        public void get_IsDirectory(){} // RVA: 0x5E697F0
        public void ToFileSystemInfo(){} // RVA: 0x5E69810
        public void ToSpecifiedFullPath(){} // RVA: 0x5E699B0
    }

    public class FileSystemEnumerableFactory
    {
        // ── Methods ──
        public void NormalizeInputs(){} // RVA: 0x5E69CD0
        public void MatchesPattern(){} // RVA: 0x5E6A430
        public void UserFiles(){} // RVA: 0x5E6A700
        public void UserDirectories(){} // RVA: 0x5E6AA40
        public void UserEntries(){} // RVA: 0x5E6AD80
        public void FileInfos(){} // RVA: 0x5E6B0C0
        public void DirectoryInfos(){} // RVA: 0x5E6B400
        public void FileSystemInfos(){} // RVA: 0x5E6B740
        public void .cctor(){} // RVA: 0x5E6BA80
    }

    public class FileSystemEnumerable`1
    {
        public DelegateEnumerator<T> _enumerator;
        public FindTransform<T> _transform;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F090
        public void get_ShouldIncludePredicate(){} // RVA: 0xCD60
        public void set_ShouldIncludePredicate(){} // RVA: 0x24B10
        public void get_ShouldRecursePredicate(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class FileSystemEnumerable`1
    {
        public DelegateEnumerator<string> _enumerator; // 0x10
        public FindTransform<string> _transform; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3336AF0
        public void get_ShouldIncludePredicate(){} // RVA: 0x6374D0
        public void set_ShouldIncludePredicate(){} // RVA: 0x30B890
        public void get_ShouldRecursePredicate(){} // RVA: 0x4976A0
        public void GetEnumerator(){} // RVA: 0x3336DA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3336E80
    }

    public class FileSystemEnumerable`1
    {
        public DelegateEnumerator<System.IO.FileInfo> _enumerator; // 0x10
        public FindTransform<System.IO.FileInfo> _transform; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3336AF0
        public void get_ShouldIncludePredicate(){} // RVA: 0x6374D0
        public void set_ShouldIncludePredicate(){} // RVA: 0x30B890
        public void get_ShouldRecursePredicate(){} // RVA: 0x4976A0
        public void GetEnumerator(){} // RVA: 0x3336DA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3336E80
    }

    public class FileSystemEnumerator`1
    {
        public string _originalRootDirectory; // 0x10
        public string _rootDirectory; // 0x18

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x3339190
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x33393A0
        public void .ctor(){} // RVA: 0x33393D0
        public void CloseDirectoryHandle(){} // RVA: 0x33399E0
        public void CreateDirectoryHandle(){} // RVA: 0x3339A30
        public void ContinueOnDirectoryError(){} // RVA: 0x3339C40
        public void MoveNext(){} // RVA: 0x3339CD0
        public void FindNextEntry(){} // RVA: 0x333AB00
        public void DequeueNextDirectory(){} // RVA: 0x333ACA0
        public void InternalDispose(){} // RVA: 0x333AE10
        public void GetData(){} // RVA: 0x333B3E0
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x333B640
        public void ShouldIncludeEntry(){} // RVA: 0x3C2850
        public void ShouldRecurseIntoEntry(){} // RVA: 0x3C2850
        public void TransformEntry(){} // RVA: 0x263BC0
        public void OnDirectoryFinished(){} // RVA: 0x2DD310
        public void ContinueOnError(){} // RVA: 0x2DD320
        public void get_Current(){} // RVA: 0x263BC0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x333B840
        public void DirectoryFinished(){} // RVA: 0x333B8F0
        public void Reset(){} // RVA: 0x28A5A70
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Finalize(){} // RVA: 0x333BB60
    }

    public class FileSystemEnumerator`1
    {
        public string _originalRootDirectory;
        public string _rootDirectory;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0xDBE0
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2DC60
        public void CloseDirectoryHandle(){} // RVA: 0x24A50
        public void CreateDirectoryHandle(){} // RVA: 0x283FA0
        public void ContinueOnDirectoryError(){}
        public void MoveNext(){} // RVA: 0xDBE0
        public void FindNextEntry(){} // RVA: 0x24A50
        public void DequeueNextDirectory(){} // RVA: 0xDBE0
        public void InternalDispose(){} // RVA: 0x25130
        public void GetData(){} // RVA: 0xDBE0
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x283FA0
        public void ShouldIncludeEntry(){} // RVA: 0xDE40
        public void ShouldRecurseIntoEntry(){} // RVA: 0xDE40
        public void TransformEntry(){} // RVA: 0x283FA0
        public void OnDirectoryFinished(){}
        public void ContinueOnError(){} // RVA: 0xE1F0
        public void get_Current(){} // RVA: 0x283FA0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xCD60
        public void DirectoryFinished(){} // RVA: 0x24A50
        public void Reset(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void Finalize(){} // RVA: 0x24A50
    }

    public class FileSystemEnumerator`1
    {
        public string _originalRootDirectory; // 0x10
        public string _rootDirectory; // 0x18

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x3337300
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x3337420
        public void .ctor(){} // RVA: 0x3337440
        public void CloseDirectoryHandle(){} // RVA: 0x33378E0
        public void CreateDirectoryHandle(){} // RVA: 0x3337900
        public void ContinueOnDirectoryError(){} // RVA: 0x3337B20
        public void MoveNext(){} // RVA: 0x3337B80
        public void FindNextEntry(){} // RVA: 0x3338610
        public void DequeueNextDirectory(){} // RVA: 0x33387F0
        public void InternalDispose(){} // RVA: 0x33388C0
        public void GetData(){} // RVA: 0x3338C60
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x3338DE0
        public void ShouldIncludeEntry(){} // RVA: 0x3C2850
        public void ShouldRecurseIntoEntry(){} // RVA: 0x3C2850
        public void TransformEntry(){} // RVA: 0xCE10
        public void OnDirectoryFinished(){} // RVA: 0x2DD310
        public void ContinueOnError(){} // RVA: 0x2DD320
        public void get_Current(){} // RVA: 0x4976A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x4976A0
        public void DirectoryFinished(){} // RVA: 0x3338F00
        public void Reset(){} // RVA: 0x28A5A70
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Finalize(){} // RVA: 0x3339110
    }

    public class FileSystemEnumerator`1
    {
        public string _originalRootDirectory; // 0x10
        public string _rootDirectory; // 0x18

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x3337300
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x3337420
        public void .ctor(){} // RVA: 0x3337440
        public void CloseDirectoryHandle(){} // RVA: 0x33378E0
        public void CreateDirectoryHandle(){} // RVA: 0x3337900
        public void ContinueOnDirectoryError(){} // RVA: 0x3337B20
        public void MoveNext(){} // RVA: 0x3337B80
        public void FindNextEntry(){} // RVA: 0x3338610
        public void DequeueNextDirectory(){} // RVA: 0x33387F0
        public void InternalDispose(){} // RVA: 0x33388C0
        public void GetData(){} // RVA: 0x3338C60
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x3338DE0
        public void ShouldIncludeEntry(){} // RVA: 0x3C2850
        public void ShouldRecurseIntoEntry(){} // RVA: 0x3C2850
        public void TransformEntry(){} // RVA: 0xCE10
        public void OnDirectoryFinished(){} // RVA: 0x2DD310
        public void ContinueOnError(){} // RVA: 0x2DD320
        public void get_Current(){} // RVA: 0x4976A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x4976A0
        public void DirectoryFinished(){} // RVA: 0x3338F00
        public void Reset(){} // RVA: 0x28A5A70
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Finalize(){} // RVA: 0x3339110
    }

    public class FileSystemName
    {
        // ── Methods ──
        public void TranslateWin32Expression(){} // RVA: 0x5E6C2E0
        public void MatchesWin32Expression(){} // RVA: 0x5E6C6C0
        public void MatchesSimpleExpression(){} // RVA: 0x5E6C750
        public void MatchPattern(){} // RVA: 0x5E6C7E0
        public void .cctor(){} // RVA: 0x5E6D110
    }

}