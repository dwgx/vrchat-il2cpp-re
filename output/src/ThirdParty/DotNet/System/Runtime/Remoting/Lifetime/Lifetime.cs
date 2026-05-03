// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
// Classes: 6
// Methods: 35

namespace ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
{
    public class ILease
    {
        // ── Methods ──
        public void get_CurrentLeaseTime(){} // RVA: 0x7FFE80E2E2E0
        public void get_CurrentState(){} // RVA: 0x7FFE80E2EDB0
        public void get_RenewOnCallTime(){} // RVA: 0x7FFE80E2E2E0
        public void Renew(){}
    }

    public class ISponsor
    {
        // ── Methods ──
        public void Renewal(){}
    }

    public class Lease : MarshalByRefObject
    {
        public System.DateTime _leaseExpireTime; // 0x18
        public 0x664C93AC _currentState; // 0x20
        public System.TimeSpan _initialLeaseTime; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868256E0
        public void get_CurrentLeaseTime(){} // RVA: 0x7FFE86825860
        public void get_CurrentState(){} // RVA: 0x7FFE8151D690
        public void Activate(){} // RVA: 0x7FFE868258C0
        public void get_RenewOnCallTime(){} // RVA: 0x7FFE8144E200
        public void Renew(){} // RVA: 0x7FFE868258D0
        public void Unregister(){} // RVA: 0x7FFE868259A0
        public void UpdateState(){} // RVA: 0x7FFE86825BC0
        public void CheckNextSponsor(){} // RVA: 0x7FFE86825E30
        public void ProcessSponsorResponse(){} // RVA: 0x7FFE86826120
    }

    public class LeaseManager : Object
    {
        // ── Methods ──
        public void SetPollTime(){} // RVA: 0x7FFE86826690
        public void TrackLifetime(){} // RVA: 0x7FFE86826810
        public void StartManager(){} // RVA: 0x7FFE86826B90
        public void StopManager(){} // RVA: 0x7FFE86826D60
        public void ManageLeases(){} // RVA: 0x7FFE86826E00
        public void .ctor(){} // RVA: 0x7FFE86827180
    }

    public class LeaseSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SyncProcessMessage(){} // RVA: 0x7FFE86827220
        public void AsyncProcessMessage(){} // RVA: 0x7FFE86827290
        public void RenewLease(){} // RVA: 0x7FFE86827310
    }

    public class LifetimeServices : Object
    {
        public System.TimeSpan _leaseManagerPollTime;
        public System.TimeSpan _leaseTime; // 0x8
        public System.TimeSpan _renewOnCallTime; // 0x10
        public System.TimeSpan _sponsorshipTimeout; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE868274D0
        public void get_LeaseManagerPollTime(){} // RVA: 0x7FFE868277C0
        public void set_LeaseManagerPollTime(){} // RVA: 0x7FFE86827820
        public void get_LeaseTime(){} // RVA: 0x7FFE868278A0
        public void set_LeaseTime(){} // RVA: 0x7FFE86827900
        public void get_RenewOnCallTime(){} // RVA: 0x7FFE86827960
        public void set_RenewOnCallTime(){} // RVA: 0x7FFE868279C0
        public void get_SponsorshipTimeout(){} // RVA: 0x7FFE86827A20
        public void set_SponsorshipTimeout(){} // RVA: 0x7FFE86827A80
        public void TrackLifetime(){} // RVA: 0x7FFE86827AE0
    }

}