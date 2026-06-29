// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
// Classes: 5
// Methods: 43

namespace ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
{
    public class IEditorPlayerConnection
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7A7E18890
        public void RegisterConnection(){} // RVA: 0x7A7E18800
        public void RegisterDisconnection(){} // RVA: 0x7A7E18800
        public void Send(){} // RVA: 0x7A7E18890
    }

    public class MessageEventArgs : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PlayerConnection : ScriptableObject
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7AEF2AB20
        public void get_isConnected(){} // RVA: 0x7AEF2AD20
        public void CreateInstance(){} // RVA: 0x7AEF2ADC0
        public void OnEnable(){} // RVA: 0x7AEF2AEF0
        public void GetConnectionNativeApi(){} // RVA: 0x7AEF2AFA0
        public void Register(){} // RVA: 0x7AEF2B000
        public void Unregister(){} // RVA: 0x7AEF2B2D0
        public void RegisterConnection(){} // RVA: 0x7AEF2B640
        public void RegisterDisconnection(){} // RVA: 0x7AEF2B880
        public void UnregisterConnection(){} // RVA: 0x7AEF2B8F0
        public void UnregisterDisconnection(){} // RVA: 0x7AEF2B990
        public void Send(){} // RVA: 0x7AEF2BA30
        public void TrySend(){} // RVA: 0x7AEF2BC30
        public void BlockUntilRecvMsg(){} // RVA: 0x7AEF2BE30
        public void DisconnectAll(){} // RVA: 0x7AEF2C1A0
        public void MessageCallbackInternal(){} // RVA: 0x7AEF2C240
        public void ConnectedCallbackInternal(){} // RVA: 0x7AEF2C480
        public void DisconnectedCallback(){} // RVA: 0x7AEF2C560
        public void .ctor(){} // RVA: 0x7AEF2C600
    }

    public class PlayerConnection[] : Array
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

    public class PlayerEditorConnectionEvents : Object
    {
        // ── Methods ──
        public void InvokeMessageIdSubscribers(){} // RVA: 0x7AEF2C7E0
        public void AddAndCreate(){} // RVA: 0x7AEF2CBE0
        public void UnregisterManagedCallback(){} // RVA: 0x7AEF2CF20
        public void .ctor(){} // RVA: 0x7AEF2D0A0
    }

}