// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Enumeration
// Classes: 5
// Methods: 56

namespace ThirdParty.DotNet.System.IO.Enumeration
{
    public class FileSystemEntry : ValueType
    {
        public FILE_FULL_DIR_INFORMATION* _info; // 0x10
        public System.ReadOnlySpan`1<char> _directory; // 0x18
        public System.ReadOnlySpan`1<char> _rootDirectory; // 0x28
        public System.ReadOnlySpan`1<char> _originalRootDirectory; // 0x38
        public object field_4; // 0x985
        public object field_5; // 0x986

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE869AA580
        public void get_Directory(){} // RVA: 0x7FFE82CF9F60
        public void set_Directory(){} // RVA: 0x7FFE82D00180
        public void get_RootDirectory(){} // RVA: 0x7FFE81703940
        public void set_RootDirectory(){} // RVA: 0x7FFE817036E0
        public void get_OriginalRootDirectory(){} // RVA: 0x7FFE81E90600
        public void set_OriginalRootDirectory(){} // RVA: 0x7FFE81E8E800
        public void get_FileName(){} // RVA: 0x7FFE869AA5A0
        public void get_Attributes(){} // RVA: 0x7FFE869AA610
        public void get_IsDirectory(){} // RVA: 0x7FFE869AA630
        public void ToFileSystemInfo(){} // RVA: 0x7FFE869AA650
        public void ToSpecifiedFullPath(){} // RVA: 0x7FFE869AA7F0
    }

    public class FileSystemEnumerableFactory : Object
    {
        // ── Methods ──
        public void NormalizeInputs(){} // RVA: 0x7FFE869AAB10
        public void MatchesPattern(){} // RVA: 0x7FFE869AB270
        public void UserFiles(){} // RVA: 0x7FFE869AB540
        public void UserDirectories(){} // RVA: 0x7FFE869AB880
        public void UserEntries(){} // RVA: 0x7FFE869ABBC0
        public void FileInfos(){} // RVA: 0x7FFE869ABF00
        public void DirectoryInfos(){} // RVA: 0x7FFE869AC240
        public void FileSystemInfos(){} // RVA: 0x7FFE869AC580
        public void .cctor(){} // RVA: 0x7FFE869AC8C0
    }

    public class FileSystemEnumerable`1 : Object
    {
        public DelegateEnumerator<T> _enumerator;
        public FindTransform<T> _transform;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void get_ShouldIncludePredicate(){} // RVA: 0x7FFE80E2E2E0
        public void set_ShouldIncludePredicate(){} // RVA: 0x7FFE80E460A0
        public void get_ShouldRecursePredicate(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public string _originalRootDirectory;
        public string _rootDirectory;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x7FFE80E2F150
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void CloseDirectoryHandle(){} // RVA: 0x7FFE80E45FE0
        public void CreateDirectoryHandle(){} // RVA: 0x7FFE810A1420
        public void ContinueOnDirectoryError(){}
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void FindNextEntry(){} // RVA: 0x7FFE80E45FE0
        public void DequeueNextDirectory(){} // RVA: 0x7FFE80E2F150
        public void InternalDispose(){} // RVA: 0x7FFE80E466C0
        public void GetData(){} // RVA: 0x7FFE80E2F150
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x7FFE810A1420
        public void ShouldIncludeEntry(){} // RVA: 0x7FFE80E2F3B0
        public void ShouldRecurseIntoEntry(){} // RVA: 0x7FFE80E2F3B0
        public void TransformEntry(){} // RVA: 0x7FFE810A1420
        public void OnDirectoryFinished(){}
        public void ContinueOnError(){} // RVA: 0x7FFE80E2F760
        public void get_Current(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void DirectoryFinished(){} // RVA: 0x7FFE80E45FE0
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE80E45FE0
    }

    public class FileSystemName : Object
    {
        // ── Methods ──
        public void TranslateWin32Expression(){} // RVA: 0x7FFE869AD120
        public void MatchesWin32Expression(){} // RVA: 0x7FFE869AD500
        public void MatchesSimpleExpression(){} // RVA: 0x7FFE869AD590
        public void MatchPattern(){} // RVA: 0x7FFE869AD620
        public void .cctor(){} // RVA: 0x7FFE869ADF50
    }

}