// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.IO.Enumeration
// Classes: 4
// Methods: 44

namespace ThirdParty.DotNet.System.IO.Enumeration
{
    public class FileSystemEnumerableFactory : Object
    {
        // ── Methods ──
        public void NormalizeInputs(){} // RVA: 0x7FFD53A21340
        public void MatchesPattern(){} // RVA: 0x7FFD53A21AA0
        public void UserFiles(){} // RVA: 0x7FFD53A21D70
        public void UserDirectories(){} // RVA: 0x7FFD53A220B0
        public void UserEntries(){} // RVA: 0x7FFD53A223F0
        public void FileInfos(){} // RVA: 0x7FFD53A22730
        public void DirectoryInfos(){} // RVA: 0x7FFD53A22A70
        public void FileSystemInfos(){} // RVA: 0x7FFD53A22DB0
        public void .cctor(){} // RVA: 0x7FFD53A230F0
    }

    public class FileSystemEnumerable`1 : Object
    {
        public object ShouldIncludePredicate;
        public object ShouldRecursePredicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void get_ShouldIncludePredicate(){} // RVA: 0x7FFD4E078E90
        public void set_ShouldIncludePredicate(){} // RVA: 0x7FFD4E090A40
        public void get_ShouldRecursePredicate(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FileSystemEnumerator`1 : CriticalFinalizerObject
    {
        public object Current;
        public object System.Collections.IEnumerator.Current;

        // ── Methods ──
        public void GetDataUWP(){} // RVA: 0x7FFD5109EED0
        public void CreateRelativeDirectoryHandleUWP(){} // RVA: 0x7FFD5109F0E0
        public void .ctor(){} // RVA: 0x7FFD5109F110
        public void CloseDirectoryHandle(){} // RVA: 0x7FFD5109F720
        public void CreateDirectoryHandle(){} // RVA: 0x7FFD5109F770
        public void ContinueOnDirectoryError(){} // RVA: 0x7FFD5109F980
        public void MoveNext(){} // RVA: 0x7FFD5109FA10
        public void FindNextEntry(){} // RVA: 0x7FFD510A0840
        public void DequeueNextDirectory(){} // RVA: 0x7FFD510A09E0
        public void InternalDispose(){} // RVA: 0x7FFD510A0B50
        public void GetData(){} // RVA: 0x7FFD510A1120
        public void CreateRelativeDirectoryHandle(){} // RVA: 0x7FFD510A1380
        public void ShouldIncludeEntry(){} // RVA: 0x7FFD4E426850
        public void ShouldRecurseIntoEntry(){} // RVA: 0x7FFD4E426850
        public void TransformEntry(){} // RVA: 0x7FFD4E27B230
        public void OnDirectoryFinished(){} // RVA: 0x7FFD4E341310
        public void ContinueOnError(){} // RVA: 0x7FFD4E341320
        public void get_Current(){} // RVA: 0x7FFD4E27B230
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD510A1580
        public void DirectoryFinished(){} // RVA: 0x7FFD510A1630
        public void Reset(){} // RVA: 0x7FFD507B4E60
        public void Dispose(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD510A18A0
    }

    public class FileSystemName : Object
    {
        // ── Methods ──
        public void TranslateWin32Expression(){} // RVA: 0x7FFD53A23950
        public void MatchesWin32Expression(){} // RVA: 0x7FFD53A23D30
        public void MatchesSimpleExpression(){} // RVA: 0x7FFD53A23DC0
        public void MatchPattern(){} // RVA: 0x7FFD53A23E50
        public void .cctor(){} // RVA: 0x7FFD53A24780
    }

}