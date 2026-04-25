// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK.Internal
// Classes: 2
// Methods: 19

namespace VRC.SDK.Internal
{
    public class VRCJokeJamTracker : VRCCustomAction
    {
        // ── Methods ──
        public void CanActivateJokeJamAction(){} // RVA: 0x7FFAC46C0900
        public void CanDeactivateJokeJamAction(){} // RVA: 0x7FFAC46C0A50
        public void ShouldUpdateJokeJamState(){} // RVA: 0x7FFAC46C0B90
        public void IsJokeJamFeatureBlocked(){} // RVA: 0x7FFAC46C0CE0
        public void Execute(){} // RVA: 0x7FFAC46C0E30
        public void ShouldProcessJokeJamAction(){} // RVA: 0x7FFAC46C10C0
        public void DoInternal_FromEulerRad_Injected_F22(){} // RVA: 0x7FFAC46C1210
        public void Initialize(){} // RVA: 0x7FFAC46C1360
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class VRCUdonAnalytics : VRCCustomAction
    {
        public string prefix; // 0x20
        public string[] eventNames; // 0x28
        public string[] guids; // 0x30

        // ── Methods ──
        public void Execute_17513321FB5C(){} // RVA: 0x7FFAC46C1520
        public void .ctor(){} // RVA: 0x7FFAC46C1660
        public void Initialize(){} // RVA: 0x7FFAC46C1730
        public void Execute(){} // RVA: 0x7FFAC46C21C0 | overloaded x3
        public void ProcessAnalyticsRemoteString(){} // RVA: 0x7FFAC46C1960
        public void ResolveAnalyticsRemoteString(){} // RVA: 0x7FFAC46C1DE0
        public void ProcessRemoteStringVariables(){} // RVA: 0x7FFAC46C1F30
        public void CanExecuteAnalyticsEventThree(){} // RVA: 0x7FFAC46C2070
    }

}