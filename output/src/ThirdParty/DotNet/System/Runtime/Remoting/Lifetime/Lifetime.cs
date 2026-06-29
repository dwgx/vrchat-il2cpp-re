// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
// Classes: 6
// Methods: 35

namespace ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
{
    public class ILease
    {
        // ── Methods ──
        public void get_CurrentLeaseTime(){} // RVA: 0x7A7E00680
        public void get_CurrentState(){} // RVA: 0x7A7E00710
        public void get_RenewOnCallTime(){} // RVA: 0x7A7E00680
        public void Renew(){} // RVA: 0x7A7E063E0
    }

    public class ISponsor
    {
        // ── Methods ──
        public void Renewal(){} // RVA: 0x7A7E00B20
    }

    public class Lease : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAD2530
        public void get_CurrentLeaseTime(){} // RVA: 0x7ADAD26B0
        public void get_CurrentState(){} // RVA: 0x7A851DB90
        public void Activate(){} // RVA: 0x7ADAD2710
        public void get_RenewOnCallTime(){} // RVA: 0x7A83F69F0
        public void Renew(){} // RVA: 0x7ADAD2720
        public void Unregister(){} // RVA: 0x7ADAD27F0
        public void UpdateState(){} // RVA: 0x7ADAD29D0
        public void CheckNextSponsor(){} // RVA: 0x7ADAD2BF0
        public void ProcessSponsorResponse(){} // RVA: 0x7ADAD2EE0
    }

    public class LeaseManager : Object
    {
        // ── Methods ──
        public void SetPollTime(){} // RVA: 0x7ADAD3450
        public void TrackLifetime(){} // RVA: 0x7ADAD35A0
        public void StartManager(){} // RVA: 0x7ADAD38F0
        public void StopManager(){} // RVA: 0x7ADAD3AD0
        public void ManageLeases(){} // RVA: 0x7ADAD3B70
        public void .ctor(){} // RVA: 0x7ADAD3EB0
    }

    public class LeaseSink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SyncProcessMessage(){} // RVA: 0x7ADAD3F50
        public void AsyncProcessMessage(){} // RVA: 0x7ADAD3FC0
        public void RenewLease(){} // RVA: 0x7ADAD4040
    }

    public class LifetimeServices : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADAD4200
        public void get_LeaseManagerPollTime(){} // RVA: 0x7ADAD44F0
        public void set_LeaseManagerPollTime(){} // RVA: 0x7ADAD4550
        public void get_LeaseTime(){} // RVA: 0x7ADAD45D0
        public void set_LeaseTime(){} // RVA: 0x7ADAD4630
        public void get_RenewOnCallTime(){} // RVA: 0x7ADAD4690
        public void set_RenewOnCallTime(){} // RVA: 0x7ADAD46F0
        public void get_SponsorshipTimeout(){} // RVA: 0x7ADAD4750
        public void set_SponsorshipTimeout(){} // RVA: 0x7ADAD47B0
        public void TrackLifetime(){} // RVA: 0x7ADAD4810
    }

}