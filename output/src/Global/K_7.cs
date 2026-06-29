// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 47
// Methods: 286

public class Kernel : Object
{
    // ── Methods ──
    public void AddSameSign(){} // RVA: 0x6665890
    public void Subtract(){} // RVA: 0x6665A90
    public void MinusEq(){} // RVA: 0x6665C70
    public void PlusEq(){} // RVA: 0x6665D90
    public void Compare(){} // RVA: 0x6665F50
    public void SingleByteDivideInPlace(){} // RVA: 0x66660A0
    public void DwordMod(){} // RVA: 0x66631B0
    public void DwordDivMod(){} // RVA: 0x6666150
    public void multiByteDivide(){} // RVA: 0x6666380
    public void LeftShift(){} // RVA: 0x6666B30
    public void RightShift(){} // RVA: 0x6666E30
    public void Multiply(){} // RVA: 0x6667050
    public void MultiplyMod2p32pmod(){} // RVA: 0x6667170
    public void modInverse(){} // RVA: 0x66673E0
}

public class Kernel : Object
{
    // ── Methods ──
    public void AddSameSign(){} // RVA: 0x66941E0
    public void Subtract(){} // RVA: 0x66943E0
    public void MinusEq(){} // RVA: 0x6665C70
    public void PlusEq(){} // RVA: 0x6665D90
    public void Compare(){} // RVA: 0x6665F50
    public void SingleByteDivideInPlace(){} // RVA: 0x66660A0
    public void DwordMod(){} // RVA: 0x66631B0
    public void DwordDivMod(){} // RVA: 0x66945C0
    public void multiByteDivide(){} // RVA: 0x66947F0
    public void LeftShift(){} // RVA: 0x6694FA0
    public void RightShift(){} // RVA: 0x66952A0
    public void MultiplyByDword(){} // RVA: 0x66954C0
    public void Multiply(){} // RVA: 0x6667050
    public void MultiplyMod2p32pmod(){} // RVA: 0x6667170
    public void modInverse(){} // RVA: 0x6695740
}

public class Kernel32 : Object
{
    // ── Methods ──
    public void ReadFile(){} // RVA: 0x6D3F890
}

public class Kernel32 : Object
{
    public object useUWPFallback;

    // ── Methods ──
    public void CopyFileUWP(){} // RVA: 0x6668C70
    public void CopyFile(){} // RVA: 0x6668E70
    public void DeleteVolumeMountPointPrivate(){} // RVA: 0x6669060
    public void DeleteVolumeMountPoint(){} // RVA: 0x6669100
    public void FreeLibrary(){} // RVA: 0x6669220
    public void LoadLibraryEx(){} // RVA: 0x66692B0
    public void GetFileMUIPath(){} // RVA: 0x66693D0
    public void GetDynamicTimeZoneInformation(){} // RVA: 0x6669570
    public void GetTimeZoneInformation(){} // RVA: 0x6669600
    public void CloseHandle(){} // RVA: 0x6669690
    public void CopyFile2(){} // RVA: 0x6669720
    public void CopyFileExPrivate(){} // RVA: 0x66697D0
    public void CopyFileEx(){} // RVA: 0x66698C0
    public void CreateDirectoryPrivate(){} // RVA: 0x6669A10
    public void CreateDirectory(){} // RVA: 0x6669AC0
    public void CreateFilePrivate(){} // RVA: 0x6669BB0
    public void CreateFile(){} // RVA: 0x6669CA0
    public void CreateFile_IntPtr(){} // RVA: 0x6669D90
    public void DeleteFilePrivate(){} // RVA: 0x6669EC0
    public void DeleteFile(){} // RVA: 0x6669F60
    public void FindFirstFileExPrivate(){} // RVA: 0x666A040
    public void FindFirstFile(){} // RVA: 0x666A190
    public void FindNextFile(){} // RVA: 0x666A2F0
    public void FormatMessage(){} // RVA: 0x666A3E0
    public void GetMessage(){} // RVA: 0x666A4E0
    public void TryGetErrorMessage(){} // RVA: 0x666A6D0
    public void GetFileAttributesExPrivate(){} // RVA: 0x666AA70
    public void GetFileAttributesEx(){} // RVA: 0x666AB30
    public void GetFileInformationByHandleEx(){} // RVA: 0x666AC30
    public void MoveFileExPrivate(){} // RVA: 0x666ACF0
    public void MoveFile(){} // RVA: 0x666ADB0
    public void RemoveDirectoryPrivate(){} // RVA: 0x666AEC0
    public void RemoveDirectory(){} // RVA: 0x666AF60
    public void SetFileAttributesPrivate(){} // RVA: 0x666B040
    public void SetFileAttributes(){} // RVA: 0x666B0F0
    public void SetFileInformationByHandle(){} // RVA: 0x666B1E0
    public void SetFileTime(){} // RVA: 0x666B2E0
    public void SetThreadErrorMode(){} // RVA: 0x666B410
}

public class Kernel32 : Object
{
    // ── Methods ──
    public void CancelIoEx(){} // RVA: 0x700C090
    public void CloseHandle(){} // RVA: 0x700C180
    public void ConnectNamedPipe(){} // RVA: 0x700C300
    public void CreateNamedPipe(){} // RVA: 0x700C3F0
    public void CreateNamedPipeClient(){} // RVA: 0x700C550
    public void DisconnectNamedPipe(){} // RVA: 0x700C6B0
    public void ReadFile(){} // RVA: 0x700C870
    public void WaitNamedPipe(){} // RVA: 0x700C980
    public void WriteFile(){} // RVA: 0x700CB40
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4207A20
    public void CopyTo(){} // RVA: 0x420A310
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x420A420
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4207C10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4207C10
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x4231210
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4231500
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4200E70
    public void CopyTo(){} // RVA: 0x423A2F0
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x423A400
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x423F6A0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x423F8E0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4200E70
    public void CopyTo(){} // RVA: 0x423A2F0
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x423A400
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x423F6A0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x423F8E0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4200E70
    public void CopyTo(){} // RVA: 0x423AEE0
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x423AFF0
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x423B660
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x423B920
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4200E70
    public void CopyTo(){} // RVA: 0x423A2F0
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x423A400
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x423F6A0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x423F8E0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4200E70
    public void CopyTo(){} // RVA: 0x423A2F0
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x423A400
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x423F6A0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x423F8E0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
    public void GetEnumerator(){} // RVA: 0x4200E70
    public void CopyTo(){} // RVA: 0x423A2F0
    public void get_Count(){} // RVA: 0x41FFD30
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x423A400
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x41FFD50
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4201060
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x423F6A0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x423F8E0
}

public class KeyCollection : Object
{
    public object _hashtable;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void CopyTo(){} // RVA: 0x6886690
    public void GetEnumerator(){} // RVA: 0x68868C0
    public void get_IsSynchronized(){} // RVA: 0x66B0FE0
    public void get_SyncRoot(){} // RVA: 0x6886990
    public void get_Count(){} // RVA: 0x17F0080
}

public class KeyCollection : Object
{
    public object _collection;
    public object _syncRoot;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894290
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0xA94080
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x894290
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0xA94080
    public void CopyTo(){} // RVA: 0x899290
    public void get_Count(){} // RVA: 0x87C130
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0x87D280
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Count(){} // RVA: 0x87C130
    public void get_IsReadOnly(){} // RVA: 0x87D280
    public void get_Item(){} // RVA: 0x87C160
    public void set_Item(){} // RVA: 0x895750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void Add(){} // RVA: 0x894320
    public void Clear(){} // RVA: 0x894290
    public void Contains(){} // RVA: 0x87D350
    public void CopyTo(){} // RVA: 0x899290
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.Generic.ICollection<System.String>.Remove(){} // RVA: 0x87D350
    public void IndexOf(){} // RVA: 0x87D050
    public void Insert(){} // RVA: 0x895750
    public void RemoveAt(){} // RVA: 0x8944F0
}

public class KeyCollection : Object
{
    public object _expando;
    public object _expandoVersion;
    public object _expandoCount;
    public object _expandoData;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70D4A40
    public void CheckVersion(){} // RVA: 0x70D4C20
    public void Add(){} // RVA: 0x70D4C90
    public void Clear(){} // RVA: 0x70D4CC0
    public void Contains(){} // RVA: 0x70D4CF0
    public void CopyTo(){} // RVA: 0x70D4EA0
    public void get_Count(){} // RVA: 0x70D5200
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void Remove(){} // RVA: 0x70D5270
    public void GetEnumerator(){} // RVA: 0x70D52A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x70D52A0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyCollection : Object
{
    public object _dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x41FFAF0
}

public class KeyEnumerator : ValueType
{
    public object _kvpEnumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
}

public class KeyGeneratedEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class KeyGeneratedEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class KeyList : Object
{
    public object sortedList;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void get_Count(){} // RVA: 0x4256270
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void get_IsFixedSize(){} // RVA: 0xC2E4C0
    public void get_IsSynchronized(){} // RVA: 0x687B750
    public void get_SyncRoot(){} // RVA: 0x687B780
    public void Add(){} // RVA: 0x687B7B0
    public void Clear(){} // RVA: 0x687B800
    public void Contains(){} // RVA: 0x687B850
    public void CopyTo(){} // RVA: 0x687B880
    public void Insert(){} // RVA: 0x687B960
    public void get_Item(){} // RVA: 0x68764B0
    public void set_Item(){} // RVA: 0x687B9B0
    public void GetEnumerator(){} // RVA: 0x687BA00
    public void IndexOf(){} // RVA: 0x687BAF0
    public void Remove(){} // RVA: 0x687BBE0
    public void RemoveAt(){} // RVA: 0x687BC30
}

public class KeyValuePairProperty : Property`2
{
    public object _key;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x87C0A0
    public void get_IsReadOnly(){} // RVA: 0x87D280
    public void GetValue(){} // RVA: 0xA94080
    public void SetValue(){} // RVA: 0xA94080
    public void get_Key(){} // RVA: 0xA94080
    public void set_Key(){} // RVA: 0xA94080
    public void get_ObjectKey(){} // RVA: 0x87C0A0
    public void .ctor(){} // RVA: 0x894290
}

public class Keypair : ValueType
{
    public object _signingKey;
    public object _verifyKey;

    // ── Methods ──
    public void get_SigningKey(){} // RVA: 0x77900
    public void get_VerifyKey(){} // RVA: 0x77ED0
    public void .ctor(){} // RVA: 0x9CCDA0
}

public class Keys : Object
{
    public object NAME;
    public object EXTENSIONS;
    public object OSC_IP;
    public object OSC_PORT;
    public object OSC_TRANSPORT;
    public object OSC_TRANSPORT_UDP;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class KeysCollection : Object
{
    public object _coll;

    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x771C4F0
    public void get_Count(){} // RVA: 0x10AD020
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x771C550
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x771C8D0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
    public void .ctor(){} // RVA: 0x771C920
}
