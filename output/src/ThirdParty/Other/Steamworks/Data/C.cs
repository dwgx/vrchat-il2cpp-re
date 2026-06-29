// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 9
// Methods: 21

namespace ThirdParty.Other.Steamworks.Data
{
    public class ChangeNumOpenSlotsCallback_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147360
        public void .cctor(){} // RVA: 0x2954100
    }

    public class CheckFileSignature_t : ValueType
    {
        public object CheckFileSignature;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147010
        public void .cctor(){} // RVA: 0x2952A50
    }

    public class ClanOfficerListResponse_t : ValueType
    {
        public object SteamIDClan;
        public object COfficers;
        public object Success;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146420
        public void .cctor(){} // RVA: 0x2951790
    }

    public class ClientGameServerDeny_t : ValueType
    {
        public object AppID;
        public object GameServerIP;
        public object GameServerPort;
        public object Secure;
        public object Reason;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x1453A0
        public void .cctor(){} // RVA: 0x2950670
    }

    public class ComputeNewPlayerCompatibilityResult_t : ValueType
    {
        public object Result;
        public object CPlayersThatDontLikeCandidate;
        public object CPlayersThatCandidateDoesntLike;
        public object CClanPlayersThatDontLikeCandidate;
        public object SteamIDCandidate;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E840
        public void .cctor(){} // RVA: 0x295BE80
    }

    public class Connection : ValueType
    {
        public object _id;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x77E60
        public void Equals(){} // RVA: 0x14FC90
        public void GetHashCode(){} // RVA: 0x77E60
        public void ToString(){} // RVA: 0x14FD20
        public void Accept(){} // RVA: 0x14FDC0
        public void Close(){} // RVA: 0x14FDD0
    }

    public class ConnectionInfo : ValueType
    {
        public object identity;
        public object userData;
        public object listenSocket;
        public object address;
        public object pad;
        public object popRemote;
        public object popRelay;
        public object state;
        public object endReason;
        public object endDebug;
        public object connectionDescription;

        // ── Methods ──
        public void get_State(){} // RVA: 0x150150
    }

    public class CreateBeaconCallback_t : ValueType
    {
        public object Result;
        public object BeaconID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147340
        public void .cctor(){} // RVA: 0x2953F40
    }

    public class CreateItemResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object UserNeedsToAcceptWorkshopLegalAgreement;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C840
        public void .cctor(){} // RVA: 0x29583E0
    }

}