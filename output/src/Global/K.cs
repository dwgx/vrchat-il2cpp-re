// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 19
// Methods: 117

public class Kernel : Object
{
    // ── Methods ──
    public void AddSameSign(){} // RVA: 0x7FFAC8384400
    public void Subtract(){} // RVA: 0x7FFAC8384620
    public void MinusEq(){} // RVA: 0x7FFAC8384810
    public void PlusEq(){} // RVA: 0x7FFAC8384930
    public void Compare(){} // RVA: 0x7FFAC8384B00
    public void SingleByteDivideInPlace(){} // RVA: 0x7FFAC8384C50
    public void DwordMod(){} // RVA: 0x7FFAC8381D10
    public void DwordDivMod(){} // RVA: 0x7FFAC8384D00
    public void multiByteDivide(){} // RVA: 0x7FFAC8384F30
    public void LeftShift(){} // RVA: 0x7FFAC83856C0
    public void RightShift(){} // RVA: 0x7FFAC83859C0
    public void Multiply(){} // RVA: 0x7FFAC8385BE0
    public void MultiplyMod2p32pmod(){} // RVA: 0x7FFAC8385D00
    public void modInverse(){} // RVA: 0x7FFAC8385F70 | overloaded x2
}

public class Kernel32 : Object
{
    public bool useUWPFallback;

    // ── Methods ──
    public void CopyFileUWP(){} // RVA: 0x7FFAC83877D0
    public void CopyFile(){} // RVA: 0x7FFAC83879F0
    public void DeleteVolumeMountPointPrivate(){} // RVA: 0x7FFAC8387BE0
    public void DeleteVolumeMountPoint(){} // RVA: 0x7FFAC8387C80
    public void FreeLibrary(){} // RVA: 0x7FFAC8387DA0
    public void LoadLibraryEx(){} // RVA: 0x7FFAC8387E30
    public void GetFileMUIPath(){} // RVA: 0x7FFAC8387F50
    public void GetDynamicTimeZoneInformation(){} // RVA: 0x7FFAC83880F0
    public void GetTimeZoneInformation(){} // RVA: 0x7FFAC8388180
    public void CloseHandle(){} // RVA: 0x7FFAC8388210
    public void CopyFile2(){} // RVA: 0x7FFAC83882A0
    public void CopyFileExPrivate(){} // RVA: 0x7FFAC8388350
    public void CopyFileEx(){} // RVA: 0x7FFAC8388440
    public void CreateDirectoryPrivate(){} // RVA: 0x7FFAC8388590
    public void CreateDirectory(){} // RVA: 0x7FFAC8388640
    public void CreateFilePrivate(){} // RVA: 0x7FFAC8388730
    public void CreateFile(){} // RVA: 0x7FFAC8388820
    public void CreateFile_IntPtr(){} // RVA: 0x7FFAC8388910
    public void DeleteFilePrivate(){} // RVA: 0x7FFAC8388A40
    public void DeleteFile(){} // RVA: 0x7FFAC8388AE0
    public void FindFirstFileExPrivate(){} // RVA: 0x7FFAC8388BC0
    public void FindFirstFile(){} // RVA: 0x7FFAC8388D10
    public void FindNextFile(){} // RVA: 0x7FFAC8388E70
    public void FormatMessage(){} // RVA: 0x7FFAC8388F60
    public void GetMessage(){} // RVA: 0x7FFAC8389060 | overloaded x2
    public void TryGetErrorMessage(){} // RVA: 0x7FFAC8389260
    public void GetFileAttributesExPrivate(){} // RVA: 0x7FFAC8389600
    public void GetFileAttributesEx(){} // RVA: 0x7FFAC83896C0
    public void GetFileInformationByHandleEx(){} // RVA: 0x7FFAC83897C0
    public void MoveFileExPrivate(){} // RVA: 0x7FFAC8389880
    public void MoveFile(){} // RVA: 0x7FFAC8389940
    public void RemoveDirectoryPrivate(){} // RVA: 0x7FFAC8389A50
    public void RemoveDirectory(){} // RVA: 0x7FFAC8389AF0
    public void SetFileAttributesPrivate(){} // RVA: 0x7FFAC8389BD0
    public void SetFileAttributes(){} // RVA: 0x7FFAC8389C80
    public void SetFileInformationByHandle(){} // RVA: 0x7FFAC8389D70
    public void SetFileTime(){} // RVA: 0x7FFAC8389E70
    public void SetThreadErrorMode(){} // RVA: 0x7FFAC8389FA0
}

public class KeyCollection : Object
{
    public System.Collections.Generic.Dictionary`2<int,ÍÌÌÏÏÍÏÌÏÏÏÏÏÍÎÍÌÎÌÏÌÏÍ> _dictionary; // 0x10
}

public class KeyCollectionDebugView : Object
{
}

public class KeyComparer`1 : Object
{
    public KeyComparer`1<T> Default;
    public System.Collections.Generic.IComparer`1<T> actualComparer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Compare(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class KeyEnumerator : ValueType
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<T,byte>> Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Reset(){} // RVA: 0x7FFAC2C70980
}

public class KeyGeneratedEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class KeyIterator : ValueType
{
    public int System.Collections.IEnumerator.Current;
    public Photon.Client.NonAllocDictionary`2<U,T> Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class KeyList : Object
{
    public System.Collections.Generic.SortedList`2<U,T> Count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void Clear(){} // RVA: 0x7FFAC2C70980
    public void Contains(){} // RVA: 0x7FFAC2E8DC40
    public void CopyTo(){} // RVA: 0x7FFAC2C77970
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
    public void Insert(){} // RVA: 0x7FFAC2E8DC40
    public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void set_Item(){} // RVA: 0x7FFAC2E8DC40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
    public void Remove(){} // RVA: 0x7FFAC2E8DC40
    public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
}

public class KeyValuePairComparer : Comparer`1
{
    public System.Collections.Generic.IComparer`1<U> keyComparer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Compare(){} // RVA: 0x7FFAC2E8DC40
}

public class KeyValuePairProperty : Property`2
{
    public V Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC2C58E90
    public void get_Key(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class KeyableListEnumerator : ValueType
{
    public VRC.Dynamics.VRCConstraintSourceKeyableList Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x2A8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E20280
    public void MoveNext(){} // RVA: 0x7FFAC9E203E0
    public void Reset(){} // RVA: 0x7FFAC9E20400
    public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    public void get_Current(){} // RVA: 0x7FFAC9E20410
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC9E20450
}

public class KeyboardDescription : ValueType
{
    public byte[] Name; // 0x10
    public ulong TrackedKeyboardId; // 0x18
    public Vector3f Dimensions; // 0x20
    public 0x6B1A7F18 KeyboardFlags; // 0x2C
    public 0x6B1A7EC0 SupportedPresentationStyles; // 0x30
}

public class KeyboardState : ValueType
{
    public 0x6B1A5C08 IsActive; // 0x10
    public 0x6B1A5C08 OrientationValid; // 0x14
    public 0x6B1A5C08 PositionValid; // 0x18
    public 0x6B1A5C08 OrientationTracked; // 0x1C
    public 0x6B1A5C08 PositionTracked; // 0x20
    public PoseStatef PoseState; // 0x28
    public Vector4f ContrastParameters; // 0x80
}

public class Keypair : ValueType
{
    public SigningKey SigningKey; // 0x10
    public VerifyKey VerifyKey; // 0x18

    // ── Methods ──
    public void get_SigningKey(){} // RVA: 0x7FFAC3AD9F60
    public void get_VerifyKey(){} // RVA: 0x7FFAC4420220
    public void .ctor(){} // RVA: 0x7FFACBE52420
}

public class Keys : Object
{
    public string NAME;
    public string EXTENSIONS;
    public string OSC_IP;
    public string OSC_PORT;
    public string OSC_TRANSPORT;
    public string OSC_TRANSPORT_UDP;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class KeysCollection : Object
{
    public System.Collections.Specialized.NameObjectCollectionBase Count; // 0x10

    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x7FFAC9456080
    public void get_Count(){} // RVA: 0x7FFAC8D711F0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC94560E0
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC9456460
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void .ctor(){} // RVA: 0x7FFAC94564B0
}

public class Keywords : Object
{
    public 0x6B0DCDF8 ServiceProviderInitialized;
}

public class Ktx : Object
{
    // ── Methods ──
    public void LoadKtxFromMemory(){} // RVA: 0x7FFAC890BB60
    public void GetKtxTextureWidth(){} // RVA: 0x7FFAC890BD90
    public void GetKtxTextureHeight(){} // RVA: 0x7FFAC890BFB0
    public void TranscodeKtxTexture(){} // RVA: 0x7FFAC890C1D0
    public void GetKtxTextureSize(){} // RVA: 0x7FFAC890C400
    public void GetKtxTextureData(){} // RVA: 0x7FFAC890C620
    public void DestroyKtxTexture(){} // RVA: 0x7FFAC890C860
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}
