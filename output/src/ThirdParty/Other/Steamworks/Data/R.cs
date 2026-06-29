// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 33
// Methods: 68

namespace ThirdParty.Other.Steamworks.Data
{
    public class RegisterActivationCodeResponse_t : ValueType
    {
        public object Result;
        public object PackageRegistered;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14BE70
        public void .cctor(){} // RVA: 0x2956700
    }

    public class RemotePlaySession : ValueType
    {
        public object _id;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x77E60
        public void set_Id(){} // RVA: 0x29580
        public void ToString(){} // RVA: 0x14FD20
        public void op_Implicit(){} // RVA: 0x294E720
    }

    public class RemoteStorageDeletePublishedFileResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147570
        public void .cctor(){} // RVA: 0x2954560
    }

    public class RemoteStorageDownloadUGCResult_t : ValueType
    {
        public object Result;
        public object File;
        public object AppID;
        public object SizeInBytes;
        public object PchFileName;
        public object SteamIDOwner;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x148D50
        public void .cctor(){} // RVA: 0x2954AA0
    }

    public class RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ValueType
    {
        public object Result;
        public object Action;
        public object ResultsReturned;
        public object TotalResultCount;
        public object GPublishedFileId;
        public object GRTimeUpdated;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B6F0
        public void .cctor(){} // RVA: 0x2955440
    }

    public class RemoteStorageEnumerateUserPublishedFilesResult_t : ValueType
    {
        public object Result;
        public object ResultsReturned;
        public object TotalResultCount;
        public object GPublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147D10
        public void .cctor(){} // RVA: 0x2954640
    }

    public class RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ValueType
    {
        public object Result;
        public object ResultsReturned;
        public object TotalResultCount;
        public object GPublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A8B0
        public void .cctor(){} // RVA: 0x2955280
    }

    public class RemoteStorageEnumerateUserSubscribedFilesResult_t : ValueType
    {
        public object Result;
        public object ResultsReturned;
        public object TotalResultCount;
        public object GPublishedFileId;
        public object GRTimeSubscribed;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x148B40
        public void .cctor(){} // RVA: 0x2954800
    }

    public class RemoteStorageEnumerateWorkshopFilesResult_t : ValueType
    {
        public object Result;
        public object ResultsReturned;
        public object TotalResultCount;
        public object GPublishedFileId;
        public object GScore;
        public object AppId;
        public object StartIndex;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A440
        public void .cctor(){} // RVA: 0x2954C60
    }

    public class RemoteStorageFileReadAsyncComplete_t : ValueType
    {
        public object FileReadAsync;
        public object Result;
        public object Offset;
        public object Read;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B730
        public void .cctor(){} // RVA: 0x29557C0
    }

    public class RemoteStorageFileShareResult_t : ValueType
    {
        public object Result;
        public object File;
        public object Filename;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147550
        public void .cctor(){} // RVA: 0x29543A0
    }

    public class RemoteStorageFileWriteAsyncComplete_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B720
        public void .cctor(){} // RVA: 0x29556E0
    }

    public class RemoteStorageGetPublishedFileDetailsResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object CreatorAppID;
        public object ConsumerAppID;
        public object Title;
        public object Description;
        public object File;
        public object PreviewFile;
        public object SteamIDOwner;
        public object TimeCreated;
        public object TimeUpdated;
        public object Visibility;
        public object Banned;
        public object Tags;
        public object TagsTruncated;
        public object PchFileName;
        public object FileSize;
        public object PreviewFileSize;
        public object URL;
        public object FileType;
        public object AcceptedForUse;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x149600
        public void .cctor(){} // RVA: 0x2954B80
    }

    public class RemoteStorageGetPublishedItemVoteDetailsResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object VotesFor;
        public object VotesAgainst;
        public object Reports;
        public object FScore;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A450
        public void .cctor(){} // RVA: 0x2954D40
    }

    public class RemoteStorageLocalFileChange_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B740
        public void .cctor(){} // RVA: 0x29558A0
    }

    public class RemoteStoragePublishFileProgress_t : ValueType
    {
        public object DPercentFile;
        public object Preview;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B700
        public void .cctor(){} // RVA: 0x2955520
    }

    public class RemoteStoragePublishFileResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object UserNeedsToAcceptWorkshopLegalAgreement;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147560
        public void .cctor(){} // RVA: 0x2954480
    }

    public class RemoteStoragePublishedFileDeleted_t : ValueType
    {
        public object PublishedFileId;
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A480
        public void .cctor(){} // RVA: 0x2954FE0
    }

    public class RemoteStoragePublishedFileSubscribed_t : ValueType
    {
        public object PublishedFileId;
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A460
        public void .cctor(){} // RVA: 0x2954E20
    }

    public class RemoteStoragePublishedFileUnsubscribed_t : ValueType
    {
        public object PublishedFileId;
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A470
        public void .cctor(){} // RVA: 0x2954F00
    }

    public class RemoteStoragePublishedFileUpdated_t : ValueType
    {
        public object PublishedFileId;
        public object AppID;
        public object Unused;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14B710
        public void .cctor(){} // RVA: 0x2955600
    }

    public class RemoteStorageSetUserPublishedFileActionResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object Action;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A8C0
        public void .cctor(){} // RVA: 0x2955360
    }

    public class RemoteStorageSubscribePublishedFileResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147D20
        public void .cctor(){} // RVA: 0x2954720
    }

    public class RemoteStorageUnsubscribePublishedFileResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x148B50
        public void .cctor(){} // RVA: 0x29548E0
    }

    public class RemoteStorageUpdatePublishedFileResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object UserNeedsToAcceptWorkshopLegalAgreement;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x148B60
        public void .cctor(){} // RVA: 0x29549C0
    }

    public class RemoteStorageUpdateUserPublishedItemVoteResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A490
        public void .cctor(){} // RVA: 0x29550C0
    }

    public class RemoteStorageUserVoteDetails_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object Vote;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14A4A0
        public void .cctor(){} // RVA: 0x29551A0
    }

    public class RemoveAppDependencyResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C900
        public void .cctor(){} // RVA: 0x2958E60
    }

    public class RemoveUGCDependencyResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object ChildPublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C8E0
        public void .cctor(){} // RVA: 0x2958CA0
    }

    public class RequestPlayersForGameFinalResultCallback_t : ValueType
    {
        public object Result;
        public object LSearchID;
        public object LUniqueGameID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147150
        public void .cctor(){} // RVA: 0x2953BC0
    }

    public class RequestPlayersForGameProgressCallback_t : ValueType
    {
        public object Result;
        public object LSearchID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147130
        public void .cctor(){} // RVA: 0x2953A00
    }

    public class RequestPlayersForGameResultCallback_t : ValueType
    {
        public object Result;
        public object LSearchID;
        public object SteamIDPlayerFound;
        public object SteamIDLobby;
        public object PlayerAcceptState;
        public object PlayerIndex;
        public object TotalPlayersFound;
        public object TotalPlayersAcceptedGame;
        public object SuggestedTeamIndex;
        public object LUniqueGameID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147140
        public void .cctor(){} // RVA: 0x2953AE0
    }

    public class ReservationNotificationCallback_t : ValueType
    {
        public object BeaconID;
        public object SteamIDJoiner;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147350
        public void .cctor(){} // RVA: 0x2954020
    }

}