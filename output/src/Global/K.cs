// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 19
// Methods: 130

public class Kernel : Object
{
    // ── Methods ──
    public void AddSameSign(){} // RVA: 0x7FFE8672DD00
    public void Subtract(){} // RVA: 0x7FFE8672DF20
    public void MinusEq(){} // RVA: 0x7FFE8672E110
    public void PlusEq(){} // RVA: 0x7FFE8672E230
    public void Compare(){} // RVA: 0x7FFE8672E400
    public void SingleByteDivideInPlace(){} // RVA: 0x7FFE8672E550
    public void DwordMod(){} // RVA: 0x7FFE8672B610
    public void DwordDivMod(){} // RVA: 0x7FFE8672E600
    public void multiByteDivide(){} // RVA: 0x7FFE8672E830
    public void LeftShift(){} // RVA: 0x7FFE8672EFC0
    public void RightShift(){} // RVA: 0x7FFE8672F2C0
    public void Multiply(){} // RVA: 0x7FFE8672F4E0
    public void MultiplyMod2p32pmod(){} // RVA: 0x7FFE8672F600
    public void modInverse(){} // RVA: 0x7FFE8672F870 | overloaded x2
}

public class Kernel32 : Object
{
    // ── Methods ──
    public void CopyFileUWP(){} // RVA: 0x7FFE867310D0
    public void CopyFile(){} // RVA: 0x7FFE867312F0
    public void DeleteVolumeMountPointPrivate(){} // RVA: 0x7FFE867314E0
    public void DeleteVolumeMountPoint(){} // RVA: 0x7FFE86731580
    public void FreeLibrary(){} // RVA: 0x7FFE867316A0
    public void LoadLibraryEx(){} // RVA: 0x7FFE86731730
    public void GetFileMUIPath(){} // RVA: 0x7FFE86731850
    public void GetDynamicTimeZoneInformation(){} // RVA: 0x7FFE867319F0
    public void GetTimeZoneInformation(){} // RVA: 0x7FFE86731A80
    public void CloseHandle(){} // RVA: 0x7FFE86731B10
    public void CopyFile2(){} // RVA: 0x7FFE86731BA0
    public void CopyFileExPrivate(){} // RVA: 0x7FFE86731C50
    public void CopyFileEx(){} // RVA: 0x7FFE86731D40
    public void CreateDirectoryPrivate(){} // RVA: 0x7FFE86731E90
    public void CreateDirectory(){} // RVA: 0x7FFE86731F40
    public void CreateFilePrivate(){} // RVA: 0x7FFE86732030
    public void CreateFile(){} // RVA: 0x7FFE86732120
    public void CreateFile_IntPtr(){} // RVA: 0x7FFE86732210
    public void DeleteFilePrivate(){} // RVA: 0x7FFE86732340
    public void DeleteFile(){} // RVA: 0x7FFE867323E0
    public void FindFirstFileExPrivate(){} // RVA: 0x7FFE867324C0
    public void FindFirstFile(){} // RVA: 0x7FFE86732610
    public void FindNextFile(){} // RVA: 0x7FFE86732770
    public void FormatMessage(){} // RVA: 0x7FFE86732860
    public void GetMessage(){} // RVA: 0x7FFE86732960 | overloaded x2
    public void TryGetErrorMessage(){} // RVA: 0x7FFE86732B60
    public void GetFileAttributesExPrivate(){} // RVA: 0x7FFE86732F00
    public void GetFileAttributesEx(){} // RVA: 0x7FFE86732FC0
    public void GetFileInformationByHandleEx(){} // RVA: 0x7FFE867330C0
    public void MoveFileExPrivate(){} // RVA: 0x7FFE86733180
    public void MoveFile(){} // RVA: 0x7FFE86733240
    public void RemoveDirectoryPrivate(){} // RVA: 0x7FFE86733350
    public void RemoveDirectory(){} // RVA: 0x7FFE867333F0
    public void SetFileAttributesPrivate(){} // RVA: 0x7FFE867334D0
    public void SetFileAttributes(){} // RVA: 0x7FFE86733580
    public void SetFileInformationByHandle(){} // RVA: 0x7FFE86733670
    public void SetFileTime(){} // RVA: 0x7FFE86733770
    public void SetThreadErrorMode(){} // RVA: 0x7FFE867338A0
}

public class KeyCollection : Object
{
    public System.Collections.Generic.SortedDictionary`2<U,T> _dictionary;
    public System.Collections.Generic.SortedDictionary`2<int,VRC.Dynamics.VRCConstraintGroup> _dictionary; // 0x10
    public object field_2;
    public object field_3; // 0x3E80

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void System.Collections.Generic.IEnumerable<TKey>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void CopyTo(){} // RVA: 0x7FFE80E4D070
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
    public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void System.Collections.Generic.ICollection<TKey>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.Generic.ICollection<TKey>.Add(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.ICollection<TKey>.Clear(){} // RVA: 0x7FFE80E45FE0
    public void System.Collections.Generic.ICollection<TKey>.Contains(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.ICollection<TKey>.Remove(){} // RVA: 0x7FFE810A1420
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
}

public class KeyCollectionDebugView : Object
{
}

public class KeyComparer`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Compare(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class KeyEnumerator : ValueType
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<T,byte>> _kvpEnumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Reset(){} // RVA: 0x7FFE80E45FE0
}

public class KeyGeneratedEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83F84C40
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class KeyIterator : ValueType
{
    public int _index;
    public Photon.Client.NonAllocDictionary`2<U,T> _dict;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    public void Reset(){} // RVA: 0x7FFE80E45FE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class KeyList : Object
{
    public System.Collections.Generic.SortedList`2<U,T> _dict;
    public System.Collections.Generic.SortedList`2<System.DateTime,Transmtn.DTO.Notifications.Notification> _dict; // 0x10
    public object field_2; // 0xFB30
    public object field_3;
    public object field_4; // 0xF903

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
    public void Add(){} // RVA: 0x7FFE810A1420
    public void Clear(){} // RVA: 0x7FFE80E45FE0
    public void Contains(){} // RVA: 0x7FFE810A1420
    public void CopyTo(){} // RVA: 0x7FFE80E4D070
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
    public void Insert(){} // RVA: 0x7FFE810A1420
    public void get_Item(){} // RVA: 0x7FFE810A1420
    public void set_Item(){} // RVA: 0x7FFE810A1420
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void IndexOf(){} // RVA: 0x7FFE810A1420
    public void Remove(){} // RVA: 0x7FFE810A1420
    public void RemoveAt(){} // RVA: 0x7FFE80E46530
}

public class KeyValuePairComparer : Comparer`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Compare(){} // RVA: 0x7FFE810A1420
}

public class KeyValuePairProperty : Property`2
{
    public V _key;
    public object field_1; // 0x12

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE80E2E2E0
    public void get_Key(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class KeyableListEnumerator : ValueType
{
    public VRC.Dynamics.VRCConstraintSourceKeyableList _keyableList; // 0x10
    public int _index; // 0x2A8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881CCE50
    public void MoveNext(){} // RVA: 0x7FFE881CCFB0
    public void Reset(){} // RVA: 0x7FFE881CCFD0
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    public void get_Current(){} // RVA: 0x7FFE881CCFE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE881CD020
}

public class KeyboardDescription : ValueType
{
}

public class KeyboardState : ValueType
{
}

public class Keypair : ValueType
{
    public SigningKey _signingKey; // 0x10
    public VerifyKey _verifyKey; // 0x18

    // ── Methods ──
    public void get_SigningKey(){} // RVA: 0x7FFE8284EF60
    public void get_VerifyKey(){} // RVA: 0x7FFE826F4210
    public void .ctor(){} // RVA: 0x7FFE8A2ABAA0
}

public class Keys : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class KeysCollection : Object
{
    public System.Collections.Specialized.NameObjectCollectionBase _coll; // 0x10
    public object field_1; // 0x35D
    public object field_2; // 0x35E

    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x7FFE877FE7C0
    public void get_Count(){} // RVA: 0x7FFE81588880
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE877FE820
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE877FEBA0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void .ctor(){} // RVA: 0x7FFE877FEBF0
}

public class Keywords : Object
{
}

public class Ktx : Object
{
    // ── Methods ──
    public void LoadKtxFromMemory(){} // RVA: 0x7FFE86CB5250
    public void GetKtxTextureWidth(){} // RVA: 0x7FFE86CB5480
    public void GetKtxTextureHeight(){} // RVA: 0x7FFE86CB56A0
    public void TranscodeKtxTexture(){} // RVA: 0x7FFE86CB58C0
    public void GetKtxTextureSize(){} // RVA: 0x7FFE86CB5AF0
    public void GetKtxTextureData(){} // RVA: 0x7FFE86CB5D10
    public void DestroyKtxTexture(){} // RVA: 0x7FFE86CB5F50
    public void .ctor(){} // RVA: 0x7FFE810FB310
}
