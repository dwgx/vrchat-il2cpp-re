// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
// Classes: 6
// Methods: 35

namespace ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
{
    public class ILease
    {
        // ── Methods ──
        public void get_CurrentLeaseTime(){} // RVA: 0x87C0A0
        public void get_CurrentState(){} // RVA: 0x87C130
        public void get_RenewOnCallTime(){} // RVA: 0x87C0A0
        public void Renew(){} // RVA: 0x881D60
    }

    public class ISponsor
    {
        // ── Methods ──
        public void Renewal(){} // RVA: 0x87C540
    }

    public class Lease : MarshalByRefObject
    {
        public object _leaseExpireTime;
        public object _currentState;
        public object _initialLeaseTime;
        public object _renewOnCallTime;
        public object _sponsorshipTimeout;
        public object _sponsors;
        public object _renewingSponsors;
        public object _renewalDelegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x675D610
        public void get_CurrentLeaseTime(){} // RVA: 0x675D790
        public void get_CurrentState(){} // RVA: 0xFEAE90
        public void Activate(){} // RVA: 0x675D7F0
        public void get_RenewOnCallTime(){} // RVA: 0xD33E60
        public void Renew(){} // RVA: 0x675D800
        public void Unregister(){} // RVA: 0x675D8D0
        public void UpdateState(){} // RVA: 0x675DAB0
        public void CheckNextSponsor(){} // RVA: 0x675DCD0
        public void ProcessSponsorResponse(){} // RVA: 0x675DFC0
    }

    public class LeaseManager : Object
    {
        public object _objects;
        public object _timer;

        // ── Methods ──
        public void SetPollTime(){} // RVA: 0x675E530
        public void TrackLifetime(){} // RVA: 0x675E680
        public void StartManager(){} // RVA: 0x675E9D0
        public void StopManager(){} // RVA: 0x675EBB0
        public void ManageLeases(){} // RVA: 0x675EC50
        public void .ctor(){} // RVA: 0x675EF90
    }

    public class LeaseSink : Object
    {
        public object _nextSink;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void SyncProcessMessage(){} // RVA: 0x675F030
        public void AsyncProcessMessage(){} // RVA: 0x675F0A0
        public void RenewLease(){} // RVA: 0x675F120
    }

    public class LifetimeServices : Object
    {
        public object _leaseManagerPollTime;
        public object _leaseTime;
        public object _renewOnCallTime;
        public object _sponsorshipTimeout;
        public object _leaseManager;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x675F2E0
        public void get_LeaseManagerPollTime(){} // RVA: 0x675F5D0
        public void set_LeaseManagerPollTime(){} // RVA: 0x675F630
        public void get_LeaseTime(){} // RVA: 0x675F6B0
        public void set_LeaseTime(){} // RVA: 0x675F710
        public void get_RenewOnCallTime(){} // RVA: 0x675F770
        public void set_RenewOnCallTime(){} // RVA: 0x675F7D0
        public void get_SponsorshipTimeout(){} // RVA: 0x675F830
        public void set_SponsorshipTimeout(){} // RVA: 0x675F890
        public void TrackLifetime(){} // RVA: 0x675F8F0
    }

}