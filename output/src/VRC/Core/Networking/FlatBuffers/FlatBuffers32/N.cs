// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 10
// Methods: 90

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class NetworkCallingEntrypoint : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsNetworkCallingEntrypoint(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_NameHash(){} // RVA: 0x9BD010
        public void get_Ratelimit(){} // RVA: 0x9BD060
        public void Parameters(){} // RVA: 0x9BD720
        public void get_ParametersLength(){} // RVA: 0x9BBCC0
        public void CreateNetworkCallingEntrypoint(){} // RVA: 0x824E410
        public void StartNetworkCallingEntrypoint(){} // RVA: 0x824E540
        public void AddNameHash(){} // RVA: 0x824BB30
        public void AddRatelimit(){} // RVA: 0x824BBA0
        public void AddParameters(){} // RVA: 0x8243A40
        public void CreateParametersVector(){} // RVA: 0x823FEE0
        public void CreateParametersVectorBlock(){} // RVA: 0x824E7A0
        public void StartParametersVector(){} // RVA: 0x82402C0
        public void EndNetworkCallingEntrypoint(){} // RVA: 0x824E860
        public void UnPack(){} // RVA: 0x9BD750
        public void UnPackTo(){} // RVA: 0x9BD760
        public void Pack(){} // RVA: 0x824EBD0
    }

    public class NetworkCallingEntrypointT : Object
    {
        public object _nameHash;
        public object _ratelimit;
        public object _parameters;

        // ── Methods ──
        public void get_NameHash(){} // RVA: 0xB8F8F0
        public void set_NameHash(){} // RVA: 0xB460A0
        public void get_Ratelimit(){} // RVA: 0x116A650
        public void set_Ratelimit(){} // RVA: 0x116BB10
        public void get_Parameters(){} // RVA: 0xB465B0
        public void set_Parameters(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x824EF80
    }

    public class NetworkCallingEntrypointVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824EFE0
    }

    public class NetworkCallingParameter : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsNetworkCallingParameter(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Type(){} // RVA: 0x9BD5A0
        public void CreateNetworkCallingParameter(){} // RVA: 0x824DEF0
        public void StartNetworkCallingParameter(){} // RVA: 0x82476C0
        public void AddType(){} // RVA: 0x824DFA0
        public void EndNetworkCallingParameter(){} // RVA: 0x824E010
        public void UnPack(){} // RVA: 0x9BD5F0
        public void UnPackTo(){} // RVA: 0x9BD600
        public void Pack(){} // RVA: 0x824E160
    }

    public class NetworkCallingParameterT : Object
    {
        public object _type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xF48510
    }

    public class NetworkCallingParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824E220
    }

    public class NetworkCallingView : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsNetworkCallingView(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_ViewId(){} // RVA: 0x9BD010
        public void get_ComponentIndex(){} // RVA: 0x9BD060
        public void Entrypoints(){} // RVA: 0x9BD830
        public void get_EntrypointsLength(){} // RVA: 0x9BBCC0
        public void CreateNetworkCallingView(){} // RVA: 0x824F2C0
        public void StartNetworkCallingView(){} // RVA: 0x824E540
        public void AddViewId(){} // RVA: 0x824BB30
        public void AddComponentIndex(){} // RVA: 0x824BBA0
        public void AddEntrypoints(){} // RVA: 0x8243A40
        public void CreateEntrypointsVector(){} // RVA: 0x823FEE0
        public void CreateEntrypointsVectorBlock(){} // RVA: 0x824F630
        public void StartEntrypointsVector(){} // RVA: 0x82402C0
        public void EndNetworkCallingView(){} // RVA: 0x824F6F0
        public void UnPack(){} // RVA: 0x9BD860
        public void UnPackTo(){} // RVA: 0x9BD870
        public void Pack(){} // RVA: 0x824FA60
    }

    public class NetworkCallingViewT : Object
    {
        public object _viewId;
        public object _componentIndex;
        public object _entrypoints;

        // ── Methods ──
        public void get_ViewId(){} // RVA: 0xB8F8F0
        public void set_ViewId(){} // RVA: 0xB460A0
        public void get_ComponentIndex(){} // RVA: 0x116A650
        public void set_ComponentIndex(){} // RVA: 0x116BB10
        public void get_Entrypoints(){} // RVA: 0xB465B0
        public void set_Entrypoints(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x824EF80
    }

    public class NetworkCallingViewT[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NetworkCallingViewVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x824FD60
    }

}