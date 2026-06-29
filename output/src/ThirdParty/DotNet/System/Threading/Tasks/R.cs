// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 2
// Methods: 6

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class RangeManager : Object
    {
        public object _indexRanges;
        public object _use32BitCurrentIndex;
        public object _nCurrentIndexRangeToAssign;
        public object _nStep;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69BBD20
        public void RegisterNewWorker(){} // RVA: 0x69BBF60
    }

    public class RangeWorker : ValueType
    {
        public object _indexRanges;
        public object _nCurrentIndexRange;
        public object _nStep;
        public object _nIncrementValue;
        public object _nMaxIncrementValue;
        public object _use32BitCurrentIndex;

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x54A60
        public void .ctor(){} // RVA: 0x8C28C0
        public void FindNewWork(){} // RVA: 0x8C28E0
        public void FindNewWork32(){} // RVA: 0x8C28F0
    }

}