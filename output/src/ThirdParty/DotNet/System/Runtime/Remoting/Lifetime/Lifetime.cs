// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
// Classes: 6
// Methods: 35

namespace ThirdParty.DotNet.System.Runtime.Remoting.Lifetime
{
    public class ILease
    {
        // ── Methods ──
        public void get_CurrentLeaseTime(){} // RVA: 0x7FFAF2ABCD60
        public void get_CurrentState(){} // RVA: 0x7FFAF2ABD840
        public void get_RenewOnCallTime(){} // RVA: 0x7FFAF2ABCD60
        public void Renew(){}
    }

    public class ISponsor
    {
        // ── Methods ──
        public void Renewal(){}
    }

    public class Lease
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87947E0
        public void get_CurrentLeaseTime(){} // RVA: 0x7FFAF8794960
        public void get_CurrentState(){} // RVA: 0x7FFAF3210030
        public void Activate(){} // RVA: 0x7FFAF87949C0
        public void get_RenewOnCallTime(){} // RVA: 0x7FFAF30E74D0
        public void Renew(){} // RVA: 0x7FFAF87949D0
        public void Unregister(){} // RVA: 0x7FFAF8794AA0
        public void UpdateState(){} // RVA: 0x7FFAF8794CC0
        public void CheckNextSponsor(){} // RVA: 0x7FFAF8794F30
        public void ProcessSponsorResponse(){} // RVA: 0x7FFAF8795220
    }

    public class LeaseManager
    {
        // ── Methods ──
        public void SetPollTime(){} // RVA: 0x7FFAF8795790
        public void TrackLifetime(){} // RVA: 0x7FFAF8795910
        public void StartManager(){} // RVA: 0x7FFAF8795C90
        public void StopManager(){} // RVA: 0x7FFAF8795E60
        public void ManageLeases(){} // RVA: 0x7FFAF8795F00
        public void .ctor(){} // RVA: 0x7FFAF8796280
    }

    public class LeaseSink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SyncProcessMessage(){} // RVA: 0x7FFAF8796320
        public void AsyncProcessMessage(){} // RVA: 0x7FFAF8796390
        public void RenewLease(){} // RVA: 0x7FFAF8796410
    }

    public class LifetimeServices
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF87965D0
        public void get_LeaseManagerPollTime(){} // RVA: 0x7FFAF87968C0
        public void set_LeaseManagerPollTime(){} // RVA: 0x7FFAF8796920
        public void get_LeaseTime(){} // RVA: 0x7FFAF87969A0
        public void set_LeaseTime(){} // RVA: 0x7FFAF8796A00
        public void get_RenewOnCallTime(){} // RVA: 0x7FFAF8796A60
        public void set_RenewOnCallTime(){} // RVA: 0x7FFAF8796AC0
        public void get_SponsorshipTimeout(){} // RVA: 0x7FFAF8796B20
        public void set_SponsorshipTimeout(){} // RVA: 0x7FFAF8796B80
        public void TrackLifetime(){} // RVA: 0x7FFAF8796BE0
    }

}