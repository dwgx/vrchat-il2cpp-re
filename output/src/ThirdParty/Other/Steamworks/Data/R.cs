// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 33
// Methods: 68

namespace ThirdParty.Other.Steamworks.Data
{
    public class RegisterActivationCodeResponse_t : ValueType
    {
        public 0x6B28DAD0 CallbackType; // 0x10
        public uint PackageRegistered; // 0x14
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0070
        public void .cctor(){} // RVA: 0x7FFAC4BF0080
    }

    public class RemotePlaySession : ValueType
    {
        public uint Id; // 0x10

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC4420210
        public void set_Id(){} // RVA: 0x7FFAC336D8B0
        public void ToString(){} // RVA: 0x7FFAC4BF7F30
        public void op_Implicit(){} // RVA: 0x7FFAC4BE6C10
    }

    public class RemoteStorageDeletePublishedFileResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED810
        public void .cctor(){} // RVA: 0x7FFAC4BED820
    }

    public class RemoteStorageDownloadUGCResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong File; // 0x18
        public Steamworks.AppId AppID; // 0x20
        public int SizeInBytes; // 0x24
        public byte[] PchFileName; // 0x28
        public ulong SteamIDOwner; // 0x30
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEDE70
        public void .cctor(){} // RVA: 0x7FFAC4BEDE80
    }

    public class RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public 0x6B28DA78 Action; // 0x14
        public int ResultsReturned; // 0x18
        public int TotalResultCount; // 0x1C
        public Steamworks.Data.PublishedFileId[] GPublishedFileId; // 0x20
        public uint[] GRTimeUpdated; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEEA20
        public void .cctor(){} // RVA: 0x7FFAC4BEEA30
    }

    public class RemoteStorageEnumerateUserPublishedFilesResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int ResultsReturned; // 0x14
        public int TotalResultCount; // 0x18
        public Steamworks.Data.PublishedFileId[] GPublishedFileId; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED920
        public void .cctor(){} // RVA: 0x7FFAC4BED930
    }

    public class RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int ResultsReturned; // 0x14
        public int TotalResultCount; // 0x18
        public Steamworks.Data.PublishedFileId[] GPublishedFileId; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE800
        public void .cctor(){} // RVA: 0x7FFAC4BEE810
    }

    public class RemoteStorageEnumerateUserSubscribedFilesResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int ResultsReturned; // 0x14
        public int TotalResultCount; // 0x18
        public Steamworks.Data.PublishedFileId[] GPublishedFileId; // 0x20
        public uint[] GRTimeSubscribed; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEDB40
        public void .cctor(){} // RVA: 0x7FFAC4BEDB50
    }

    public class RemoteStorageEnumerateWorkshopFilesResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int ResultsReturned; // 0x14
        public int TotalResultCount; // 0x18
        public Steamworks.Data.PublishedFileId[] GPublishedFileId; // 0x20
        public float[] GScore; // 0x28
        public Steamworks.AppId AppId; // 0x30
        public uint StartIndex; // 0x34
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE090
        public void .cctor(){} // RVA: 0x7FFAC4BEE0A0
    }

    public class RemoteStorageFileReadAsyncComplete_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D600 Result; // 0x18
        public uint Offset; // 0x1C
        public uint Read; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEEE60
        public void .cctor(){} // RVA: 0x7FFAC4BEEE70
    }

    public class RemoteStorageFileShareResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong File; // 0x18
        public byte[] Filename; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED5F0
        public void .cctor(){} // RVA: 0x7FFAC4BED600
    }

    public class RemoteStorageFileWriteAsyncComplete_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEED50
        public void .cctor(){} // RVA: 0x7FFAC4BEED60
    }

    public class RemoteStorageGetPublishedFileDetailsResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public Steamworks.AppId CreatorAppID; // 0x20
        public Steamworks.AppId ConsumerAppID; // 0x24
        public byte[] Title; // 0x28
        public byte[] Description; // 0x30
        public ulong File; // 0x38
        public ulong PreviewFile; // 0x40
        public ulong SteamIDOwner; // 0x48
        public uint TimeCreated; // 0x50
        public uint TimeUpdated; // 0x54
        public 0x6B28D970 Visibility; // 0x58
        public bool Banned; // 0x5C
        public byte[] Tags; // 0x60
        public bool TagsTruncated; // 0x68
        public byte[] PchFileName; // 0x70
        public int FileSize; // 0x78
        public int PreviewFileSize; // 0x7C
        public byte[] URL; // 0x80
        public 0x6B28D9C8 FileType; // 0x88
        public bool AcceptedForUse; // 0x8C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEDF80
        public void .cctor(){} // RVA: 0x7FFAC4BEDF90
    }

    public class RemoteStorageGetPublishedItemVoteDetailsResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int VotesFor; // 0x20
        public int VotesAgainst; // 0x24
        public int Reports; // 0x28
        public float FScore; // 0x2C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE1A0
        public void .cctor(){} // RVA: 0x7FFAC4BEE1B0
    }

    public class RemoteStorageLocalFileChange_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEEF70
        public void .cctor(){} // RVA: 0x7FFAC4BEEF80
    }

    public class RemoteStoragePublishFileProgress_t : ValueType
    {
        public double CallbackType; // 0x10
        public bool Preview; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEEB30
        public void .cctor(){} // RVA: 0x7FFAC4BEEB40
    }

    public class RemoteStoragePublishFileResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED700
        public void .cctor(){} // RVA: 0x7FFAC4BED710
    }

    public class RemoteStoragePublishedFileDeleted_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE4D0
        public void .cctor(){} // RVA: 0x7FFAC4BEE4E0
    }

    public class RemoteStoragePublishedFileSubscribed_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE2B0
        public void .cctor(){} // RVA: 0x7FFAC4BEE2C0
    }

    public class RemoteStoragePublishedFileUnsubscribed_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE3C0
        public void .cctor(){} // RVA: 0x7FFAC4BEE3D0
    }

    public class RemoteStoragePublishedFileUpdated_t : ValueType
    {
        public Steamworks.Data.PublishedFileId CallbackType; // 0x10
        public Steamworks.AppId AppID; // 0x18
        public ulong Unused; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEEC40
        public void .cctor(){} // RVA: 0x7FFAC4BEEC50
    }

    public class RemoteStorageSetUserPublishedFileActionResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public 0x6B28DA78 Action; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE910
        public void .cctor(){} // RVA: 0x7FFAC4BEE920
    }

    public class RemoteStorageSubscribePublishedFileResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEDA30
        public void .cctor(){} // RVA: 0x7FFAC4BEDA40
    }

    public class RemoteStorageUnsubscribePublishedFileResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEDC50
        public void .cctor(){} // RVA: 0x7FFAC4BEDC60
    }

    public class RemoteStorageUpdatePublishedFileResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEDD60
        public void .cctor(){} // RVA: 0x7FFAC4BEDD70
    }

    public class RemoteStorageUpdateUserPublishedItemVoteResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE5E0
        public void .cctor(){} // RVA: 0x7FFAC4BEE5F0
    }

    public class RemoteStorageUserVoteDetails_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public 0x6B28DA20 Vote; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEE6F0
        public void .cctor(){} // RVA: 0x7FFAC4BEE700
    }

    public class RemoveAppDependencyResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public Steamworks.AppId AppID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF3040
        public void .cctor(){} // RVA: 0x7FFAC4BF3050
    }

    public class RemoveUGCDependencyResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public Steamworks.Data.PublishedFileId ChildPublishedFileId; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2E20
        public void .cctor(){} // RVA: 0x7FFAC4BF2E30
    }

    public class RequestPlayersForGameFinalResultCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong LSearchID; // 0x18
        public ulong LUniqueGameID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BECC60
        public void .cctor(){} // RVA: 0x7FFAC4BECC70
    }

    public class RequestPlayersForGameProgressCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong LSearchID; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BECA40
        public void .cctor(){} // RVA: 0x7FFAC4BECA50
    }

    public class RequestPlayersForGameResultCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong LSearchID; // 0x14
        public ulong SteamIDPlayerFound; // 0x1C
        public ulong SteamIDLobby; // 0x24
        public 0x6B290410 PlayerAcceptState; // 0x2C
        public int PlayerIndex; // 0x30
        public int TotalPlayersFound; // 0x34
        public int TotalPlayersAcceptedGame; // 0x38
        public int SuggestedTeamIndex; // 0x3C
        public ulong LUniqueGameID; // 0x40
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BECB50
        public void .cctor(){} // RVA: 0x7FFAC4BECB60
    }

    public class ReservationNotificationCallback_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public ulong SteamIDJoiner; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED1B0
        public void .cctor(){} // RVA: 0x7FFAC4BED1C0
    }

}