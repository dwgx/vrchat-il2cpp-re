// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 10
// Methods: 90

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class NetworkCallingEntrypoint : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsNetworkCallingEntrypoint(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_NameHash(){} // RVA: 0x7A7F16B80
        public void get_Ratelimit(){} // RVA: 0x7A7F16BD0
        public void Parameters(){} // RVA: 0x7A7F17010
        public void get_ParametersLength(){} // RVA: 0x7A7F15EB0
        public void CreateNetworkCallingEntrypoint(){} // RVA: 0x7AF3F4940
        public void StartNetworkCallingEntrypoint(){} // RVA: 0x7AF3F4A70
        public void AddNameHash(){} // RVA: 0x7AF3F2060
        public void AddRatelimit(){} // RVA: 0x7AF3F20D0
        public void AddParameters(){} // RVA: 0x7AF3EA160
        public void CreateParametersVector(){} // RVA: 0x7AF3E65E0
        public void CreateParametersVectorBlock(){} // RVA: 0x7AF3F4CD0
        public void StartParametersVector(){} // RVA: 0x7AF3E69C0
        public void EndNetworkCallingEntrypoint(){} // RVA: 0x7AF3F4D90
        public void UnPack(){} // RVA: 0x7A7F17040
        public void UnPackTo(){} // RVA: 0x7A7F17050
        public void Pack(){} // RVA: 0x7AF3F5100
    }

    public class NetworkCallingEntrypointT : Object
    {
        // ── Methods ──
        public void get_NameHash(){} // RVA: 0x7A8124910
        public void set_NameHash(){} // RVA: 0x7A80DA0C0
        public void get_Ratelimit(){} // RVA: 0x7A8668BC0
        public void set_Ratelimit(){} // RVA: 0x7A8669360
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void set_Parameters(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3F54B0
    }

    public class NetworkCallingEntrypointVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F5510
    }

    public class NetworkCallingParameter : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsNetworkCallingParameter(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Type(){} // RVA: 0x7A7F16F30
        public void CreateNetworkCallingParameter(){} // RVA: 0x7AF3F4420
        public void StartNetworkCallingParameter(){} // RVA: 0x7AF3EDBF0
        public void AddType(){} // RVA: 0x7AF3F44D0
        public void EndNetworkCallingParameter(){} // RVA: 0x7AF3F4540
        public void UnPack(){} // RVA: 0x7A7F16F80
        public void UnPackTo(){} // RVA: 0x7A7F16F90
        public void Pack(){} // RVA: 0x7AF3F4690
    }

    public class NetworkCallingParameterT : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A847A460
    }

    public class NetworkCallingParameterVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F4750
    }

    public class NetworkCallingView : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsNetworkCallingView(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_ViewId(){} // RVA: 0x7A7F16B80
        public void get_ComponentIndex(){} // RVA: 0x7A7F16BD0
        public void Entrypoints(){} // RVA: 0x7A7F17080
        public void get_EntrypointsLength(){} // RVA: 0x7A7F15EB0
        public void CreateNetworkCallingView(){} // RVA: 0x7AF3F57F0
        public void StartNetworkCallingView(){} // RVA: 0x7AF3F4A70
        public void AddViewId(){} // RVA: 0x7AF3F2060
        public void AddComponentIndex(){} // RVA: 0x7AF3F20D0
        public void AddEntrypoints(){} // RVA: 0x7AF3EA160
        public void CreateEntrypointsVector(){} // RVA: 0x7AF3E65E0
        public void CreateEntrypointsVectorBlock(){} // RVA: 0x7AF3F5B60
        public void StartEntrypointsVector(){} // RVA: 0x7AF3E69C0
        public void EndNetworkCallingView(){} // RVA: 0x7AF3F5C20
        public void UnPack(){} // RVA: 0x7A7F170B0
        public void UnPackTo(){} // RVA: 0x7A7F170C0
        public void Pack(){} // RVA: 0x7AF3F5F90
    }

    public class NetworkCallingViewT : Object
    {
        // ── Methods ──
        public void get_ViewId(){} // RVA: 0x7A8124910
        public void set_ViewId(){} // RVA: 0x7A80DA0C0
        public void get_ComponentIndex(){} // RVA: 0x7A8668BC0
        public void set_ComponentIndex(){} // RVA: 0x7A8669360
        public void get_Entrypoints(){} // RVA: 0x7A80DA7B0
        public void set_Entrypoints(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3F54B0
    }

    public class NetworkCallingViewT[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class NetworkCallingViewVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3F6290
    }

}