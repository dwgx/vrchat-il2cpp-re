// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
// Classes: 6
// Methods: 35

namespace ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
{
    public class ILease
    {
        public object CurrentLeaseTime;
        public object CurrentState;
        public object RenewOnCallTime;

        // ── Methods ──
        public void get_CurrentLeaseTime(){} // RVA: 0x7FFAC2C58E90
        public void get_CurrentState(){} // RVA: 0x7FFAC2C59960
        public void get_RenewOnCallTime(){} // RVA: 0x7FFAC2C58E90
        public void Renew(){}
    }

    public class ISponsor
    {
        // ── Methods ──
        public void Renewal(){}
    }

    public class Lease : MarshalByRefObject
    {
        public System.DateTime CurrentLeaseTime; // 0x18
        public 0x6B0D0488 CurrentState; // 0x20
        public System.TimeSpan RenewOnCallTime; // 0x28
        public System.TimeSpan _renewOnCallTime; // 0x30
        public System.TimeSpan _sponsorshipTimeout; // 0x38
        public System.Collections.ArrayList _sponsors; // 0x40
        public System.Collections.Queue _renewingSponsors; // 0x48
        public RenewalDelegate _renewalDelegate; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC847BDD0
        public void get_CurrentLeaseTime(){} // RVA: 0x7FFAC847BF50
        public void get_CurrentState(){} // RVA: 0x7FFAC30DBBE0
        public void Activate(){} // RVA: 0x7FFAC847BFB0
        public void get_RenewOnCallTime(){} // RVA: 0x7FFAC31D95E0
        public void Renew(){} // RVA: 0x7FFAC847BFC0
        public void Unregister(){} // RVA: 0x7FFAC847C090
        public void UpdateState(){} // RVA: 0x7FFAC847C2B0
        public void CheckNextSponsor(){} // RVA: 0x7FFAC847C520
        public void ProcessSponsorResponse(){} // RVA: 0x7FFAC847C810
    }

    public class LeaseManager : Object
    {
        public System.Collections.ArrayList _objects; // 0x10
        public System.Threading.Timer _timer; // 0x18

        // ── Methods ──
        public void SetPollTime(){} // RVA: 0x7FFAC847CD80
        public void TrackLifetime(){} // RVA: 0x7FFAC847CF00
        public void StartManager(){} // RVA: 0x7FFAC847D280
        public void StopManager(){} // RVA: 0x7FFAC847D450
        public void ManageLeases(){} // RVA: 0x7FFAC847D4F0
        public void .ctor(){} // RVA: 0x7FFAC847D870
    }

    public class LeaseSink : Object
    {
        public System.Runtime.Remoting.Messaging.IMessageSink _nextSink; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SyncProcessMessage(){} // RVA: 0x7FFAC847D910
        public void AsyncProcessMessage(){} // RVA: 0x7FFAC847D980
        public void RenewLease(){} // RVA: 0x7FFAC847DA00
    }

    public class LifetimeServices : Object
    {
        public System.TimeSpan LeaseManagerPollTime;
        public System.TimeSpan LeaseTime; // 0x8
        public System.TimeSpan RenewOnCallTime; // 0x10
        public System.TimeSpan SponsorshipTimeout; // 0x18
        public System.Runtime.Remoting.Lifetime.LeaseManager _leaseManager; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC847DBC0
        public void get_LeaseManagerPollTime(){} // RVA: 0x7FFAC847DEB0
        public void set_LeaseManagerPollTime(){} // RVA: 0x7FFAC847DF10
        public void get_LeaseTime(){} // RVA: 0x7FFAC847DF90
        public void set_LeaseTime(){} // RVA: 0x7FFAC847DFF0
        public void get_RenewOnCallTime(){} // RVA: 0x7FFAC847E050
        public void set_RenewOnCallTime(){} // RVA: 0x7FFAC847E0B0
        public void get_SponsorshipTimeout(){} // RVA: 0x7FFAC847E110
        public void set_SponsorshipTimeout(){} // RVA: 0x7FFAC847E170
        public void TrackLifetime(){} // RVA: 0x7FFAC847E1D0
    }

}