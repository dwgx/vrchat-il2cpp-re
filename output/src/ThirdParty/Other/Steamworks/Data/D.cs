// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 6
// Methods: 10

namespace ThirdParty.Other.Steamworks.Data
{
    public class DeleteItemResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3260
        public void .cctor(){} // RVA: 0x7FFAC4BF3270
    }

    public class DlcInstalled_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEFF60
        public void .cctor(){} // RVA: 0x7FFAC4BEFF70
    }

    public class DownloadClanActivityCountsResult_t : ValueType
    {
        public bool CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA850
        public void .cctor(){} // RVA: 0x7FFAC4BEA860
    }

    public class DownloadItemResult_t : ValueType
    {
        public Steamworks.AppId CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public 0x6B28D600 Result; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF26B0
        public void .cctor(){} // RVA: 0x7FFAC4BF26C0
    }

    public class DurationControl : ValueType
    {
        public Steamworks.Data.DurationControl_t _inner; // 0x10
    }

    public class DurationControl_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.AppId Appid; // 0x14
        public bool Applicable; // 0x18
        public int CsecsLast5h; // 0x1C
        public 0x6B28D868 Progress; // 0x20
        public 0x6B28D8C0 Otification; // 0x24
        public int CsecsToday; // 0x28
        public int CsecsRemaining; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9860
        public void .cctor(){} // RVA: 0x7FFAC4BE9870
    }

}