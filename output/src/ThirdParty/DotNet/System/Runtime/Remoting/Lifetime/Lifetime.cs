// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
// Classes: 6
// Methods: 35

namespace ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
{
    public class ILease
    {
        // ── Methods ──
        public void get_CurrentLeaseTime(){} // RVA: 0xCD60
        public void get_CurrentState(){} // RVA: 0xD840
        public void get_RenewOnCallTime(){} // RVA: 0xCD60
        public void Renew(){}
    }

    public class ISponsor
    {
        // ── Methods ──
        public void Renewal(){}
    }

    public class Lease
    {
        public System.DateTime _leaseExpireTime; // 0x18
        public 0x657EB408 _currentState; // 0x20
        public System.TimeSpan _initialLeaseTime; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CE47E0
        public void get_CurrentLeaseTime(){} // RVA: 0x5CE4960
        public void get_CurrentState(){} // RVA: 0x760030
        public void Activate(){} // RVA: 0x5CE49C0
        public void get_RenewOnCallTime(){} // RVA: 0x6374D0
        public void Renew(){} // RVA: 0x5CE49D0
        public void Unregister(){} // RVA: 0x5CE4AA0
        public void UpdateState(){} // RVA: 0x5CE4CC0
        public void CheckNextSponsor(){} // RVA: 0x5CE4F30
        public void ProcessSponsorResponse(){} // RVA: 0x5CE5220
    }

    public class LeaseManager
    {
        // ── Methods ──
        public void SetPollTime(){} // RVA: 0x5CE5790
        public void TrackLifetime(){} // RVA: 0x5CE5910
        public void StartManager(){} // RVA: 0x5CE5C90
        public void StopManager(){} // RVA: 0x5CE5E60
        public void ManageLeases(){} // RVA: 0x5CE5F00
        public void .ctor(){} // RVA: 0x5CE6280
    }

    public class LeaseSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void SyncProcessMessage(){} // RVA: 0x5CE6320
        public void AsyncProcessMessage(){} // RVA: 0x5CE6390
        public void RenewLease(){} // RVA: 0x5CE6410
    }

    public class LifetimeServices
    {
        public System.TimeSpan _leaseManagerPollTime;
        public System.TimeSpan _leaseTime; // 0x8
        public System.TimeSpan _renewOnCallTime; // 0x10
        public System.TimeSpan _sponsorshipTimeout; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x5CE65D0
        public void get_LeaseManagerPollTime(){} // RVA: 0x5CE68C0
        public void set_LeaseManagerPollTime(){} // RVA: 0x5CE6920
        public void get_LeaseTime(){} // RVA: 0x5CE69A0
        public void set_LeaseTime(){} // RVA: 0x5CE6A00
        public void get_RenewOnCallTime(){} // RVA: 0x5CE6A60
        public void set_RenewOnCallTime(){} // RVA: 0x5CE6AC0
        public void get_SponsorshipTimeout(){} // RVA: 0x5CE6B20
        public void set_SponsorshipTimeout(){} // RVA: 0x5CE6B80
        public void TrackLifetime(){} // RVA: 0x5CE6BE0
    }

}