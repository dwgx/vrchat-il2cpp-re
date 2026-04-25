// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Source.Config
// Classes: 1
// Methods: 10

namespace VRC.Core.Source.Config
{
    public class NoAllocByteSetStorage : Object
    {
        public string Count; // 0x10
        public System.Collections.Generic.Dictionary`2<string,byte> cachedSet; // 0x18
        public System.Text.Encoding encoding; // 0x20
        public byte[] SEPARATOR_BYTES;
        public int MAX_KEY_LENGTH;
        public int MAX_LINE_LENGTH;
        public char PADDING_CHAR;
        public byte[] byteBuffer; // 0x28
        public System.Collections.Generic.Dictionary`2<string,byte> appendList; // 0x30
        public bool appendOnly; // 0x38
        public System.DateTime fileLastModifiedTime; // 0x40
        public bool writeDisabled; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF3AE50
        public void get_Count(){} // RVA: 0x7FFACBF3B190
        public void Has(){} // RVA: 0x7FFACBF3B1E0
        public void Get(){} // RVA: 0x7FFACBF3B260
        public void Remove(){} // RVA: 0x7FFACBF3B320
        public void Clear(){} // RVA: 0x7FFACBF3B3F0
        public void Set(){} // RVA: 0x7FFACBF3B440
        public void LoadFromDisk(){} // RVA: 0x7FFACBF3B7B0
        public void SaveToDisk(){} // RVA: 0x7FFACBF3B850
        public void .cctor(){} // RVA: 0x7FFACBF3BFC0
    }

}