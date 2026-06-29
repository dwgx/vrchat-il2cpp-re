// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Enumeration
// Classes: 10
// Methods: 136

namespace ThirdParty.DotNet.System.IO.Enumeration
{
    public class FileSystemEntry : ValueType
    {
        public object _info;
        public object _directory;
        public object _rootDirectory;
        public object _originalRootDirectory;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x68E2B70
        public void get_Directory(){} // RVA: 0x27F5290
        public void set_Directory(){} // RVA: 0x27FA850
        public void get_RootDirectory(){} // RVA: 0x125EE60
        public void set_RootDirectory(){} // RVA: 0x125D9D0
        public void get_OriginalRootDirectory(){} // RVA: 0x19F92B0
        public void set_OriginalRootDirectory(){} // RVA: 0x19F35A0
        public void get_FileName(){} // RVA: 0x68E2B90
        public void get_Attributes(){} // RVA: 0x68E2C00
        public void get_IsDirectory(){} // RVA: 0x68E2C20
        public void ToFileSystemInfo(){} // RVA: 0x68E2C40
        public void ToSpecifiedFullPath(){} // RVA: 0x68E2DB0
    }

    public class FileSystemEnumerableFactory : Object
    {
        public object s_unixEscapeChars;

        // ── Methods ──
        public void NormalizeInputs(){} // RVA: 0x68E30D0
        public void MatchesPattern(){} // RVA: 0x68E3810
        public void UserFiles(){} // RVA: 0x68E3AE0
        public void UserDirectories(){} // RVA: 0x68E3E20
        public void UserEntries(){} // RVA: 0x68E4160
        public void FileInfos(){} // RVA: 0x68E44A0
        public void DirectoryInfos(){} // RVA: 0x68E47E0
        public void FileSystemInfos(){} // RVA: 0x68E4B20
        public void .cctor(){} // RVA: 0x68E4E60
    }

    public class FileSystemEnumerable`1 : Object
    {
        public object _enumerator;
        public object _transform;
        public object _options;
        public object _directory;
        public object _shouldIncludePredicate;
        public object _shouldRecursePredicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8954D0
        public void get_ShouldIncludePredicate(){} // RVA: 0x87C0A0
        public void set_ShouldIncludePredicate(){} // RVA: 0x894320
        public void get_ShouldRecursePredicate(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class FileSystemEnumerable`1 : Object
    {
        public object _enumerator;
        public object _transform;
        public object _options;
        public object _directory;
        public object _shouldIncludePredicate;
        public object _shouldRecursePredicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DE8EF0
        public void set_ShouldIncludePredicate(){} // RVA: 0xB708C0
        public void get_ShouldIncludePredicate(){} // RVA: 0xD33E60
        public void get_ShouldRecursePredicate(){} // RVA: 0xD05CA0
        public void GetEnumerator(){} // RVA: 0x3DE91B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DE9290
    }

    public class FileSystemEnumerable`1 : Object
    {
        public object _enumerator;
        public object _transform;
        public object _options;
        public object _directory;
        public object _shouldIncludePredicate;
        public object _shouldRecursePredicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DE8EF0
        public void set_ShouldIncludePredicate(){} // RVA: 0xB708C0
        public void get_ShouldIncludePredicate(){} // RVA: 0xD33E60
        public void get_ShouldRecursePredicate(){} // RVA: 0xD05CA0
        public void GetEnumerator(){} // RVA: 0x3DE91B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DE9290
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public object _originalRootDirectory;
        public object _rootDirectory;
        public object _options;
        public object _lock;
        public object _entry;
        public object _current;
        public object _buffer;
        public object _bufferLength;
        public object _directoryHandle;
        public object _currentPath;
        public object _lastEntryFound;
        public object _pending;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x87D280
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x8943B0
        public void CloseDirectoryHandle(){} // RVA: 0x894290
        public void CreateDirectoryHandle(){} // RVA: 0xA94080
        public void ContinueOnDirectoryError(){} // RVA: 0x87E2A0
        public void MoveNext(){} // RVA: 0x87D280
        public void FindNextEntry(){} // RVA: 0x894290
        public void DequeueNextDirectory(){} // RVA: 0x87D280
        public void InternalDispose(){} // RVA: 0x894750
        public void GetData(){} // RVA: 0x87D280
        public void CreateRelativeDirectoryHandle(){} // RVA: 0xA94080
        public void ShouldIncludeEntry(){} // RVA: 0x87D350
        public void ShouldRecurseIntoEntry(){} // RVA: 0x87D350
        public void TransformEntry(){} // RVA: 0xA94080
        public void OnDirectoryFinished(){} // RVA: 0x894320
        public void ContinueOnError(){} // RVA: 0x87DD20
        public void get_Current(){} // RVA: 0xA94080
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
        public void DirectoryFinished(){} // RVA: 0x894290
        public void Reset(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894750
        public void Finalize(){} // RVA: 0x894290
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public object _originalRootDirectory;
        public object _rootDirectory;
        public object _options;
        public object _lock;
        public object _entry;
        public object _current;
        public object _buffer;
        public object _bufferLength;
        public object _directoryHandle;
        public object _currentPath;
        public object _lastEntryFound;
        public object _pending;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x3DEB4F0
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x3DEB700
        public void .ctor(){} // RVA: 0x3DEB720
        public void CloseDirectoryHandle(){} // RVA: 0x3DEBD40
        public void CreateDirectoryHandle(){} // RVA: 0x3DEBD90
        public void ContinueOnDirectoryError(){} // RVA: 0x3DEBF90
        public void MoveNext(){} // RVA: 0x3DEC020
        public void FindNextEntry(){} // RVA: 0x3DECDE0
        public void DequeueNextDirectory(){} // RVA: 0x3DECF70
        public void InternalDispose(){} // RVA: 0x3DED0E0
        public void GetData(){} // RVA: 0x3DED670
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x3DED8D0
        public void ShouldIncludeEntry(){} // RVA: 0xC2E4C0
        public void ShouldRecurseIntoEntry(){} // RVA: 0xC2E4C0
        public void TransformEntry(){} // RVA: 0xA94080
        public void OnDirectoryFinished(){} // RVA: 0xB43310
        public void ContinueOnError(){} // RVA: 0xB43320
        public void get_Current(){} // RVA: 0xAD0950
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x3DEDAC0
        public void DirectoryFinished(){} // RVA: 0x3DEDB70
        public void Reset(){} // RVA: 0x31EA210
        public void Dispose(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x3DEDDD0
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public object _originalRootDirectory;
        public object _rootDirectory;
        public object _options;
        public object _lock;
        public object _entry;
        public object _current;
        public object _buffer;
        public object _bufferLength;
        public object _directoryHandle;
        public object _currentPath;
        public object _lastEntryFound;
        public object _pending;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x3DE9720
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x3DE9840
        public void .ctor(){} // RVA: 0x3DE9860
        public void CloseDirectoryHandle(){} // RVA: 0x3DE9CF0
        public void CreateDirectoryHandle(){} // RVA: 0x3DE9D10
        public void ContinueOnDirectoryError(){} // RVA: 0x3DE9F30
        public void MoveNext(){} // RVA: 0x3DE9F90
        public void FindNextEntry(){} // RVA: 0x3DEA9B0
        public void DequeueNextDirectory(){} // RVA: 0x3DEAB90
        public void InternalDispose(){} // RVA: 0x3DEAC60
        public void GetData(){} // RVA: 0x3DEAFC0
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x3DEB140
        public void ShouldIncludeEntry(){} // RVA: 0xC2E4C0
        public void ShouldRecurseIntoEntry(){} // RVA: 0xC2E4C0
        public void TransformEntry(){} // RVA: 0x87C540
        public void OnDirectoryFinished(){} // RVA: 0xB43310
        public void ContinueOnError(){} // RVA: 0xB43320
        public void get_Current(){} // RVA: 0xD05CA0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xD05CA0
        public void DirectoryFinished(){} // RVA: 0x3DEB260
        public void Reset(){} // RVA: 0x31EA210
        public void Dispose(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x3DEB470
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public object _originalRootDirectory;
        public object _rootDirectory;
        public object _options;
        public object _lock;
        public object _entry;
        public object _current;
        public object _buffer;
        public object _bufferLength;
        public object _directoryHandle;
        public object _currentPath;
        public object _lastEntryFound;
        public object _pending;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x3DE9720
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x3DE9840
        public void .ctor(){} // RVA: 0x3DE9860
        public void CloseDirectoryHandle(){} // RVA: 0x3DE9CF0
        public void CreateDirectoryHandle(){} // RVA: 0x3DE9D10
        public void ContinueOnDirectoryError(){} // RVA: 0x3DE9F30
        public void MoveNext(){} // RVA: 0x3DE9F90
        public void FindNextEntry(){} // RVA: 0x3DEA9B0
        public void DequeueNextDirectory(){} // RVA: 0x3DEAB90
        public void InternalDispose(){} // RVA: 0x3DEAC60
        public void GetData(){} // RVA: 0x3DEAFC0
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x3DEB140
        public void ShouldIncludeEntry(){} // RVA: 0xC2E4C0
        public void ShouldRecurseIntoEntry(){} // RVA: 0xC2E4C0
        public void TransformEntry(){} // RVA: 0x87C540
        public void OnDirectoryFinished(){} // RVA: 0xB43310
        public void ContinueOnError(){} // RVA: 0xB43320
        public void get_Current(){} // RVA: 0xD05CA0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xD05CA0
        public void DirectoryFinished(){} // RVA: 0x3DEB260
        public void Reset(){} // RVA: 0x31EA210
        public void Dispose(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x3DEB470
    }

    public class FileSystemName : Object
    {
        public object s_wildcardChars;
        public object s_simpleWildcardChars;

        // ── Methods ──
        public void TranslateWin32Expression(){} // RVA: 0x68E56C0
        public void MatchesWin32Expression(){} // RVA: 0x68E5A90
        public void MatchesSimpleExpression(){} // RVA: 0x68E5B20
        public void MatchPattern(){} // RVA: 0x68E5BB0
        public void .cctor(){} // RVA: 0x68E6460
    }

}