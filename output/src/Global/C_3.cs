// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 36
// Methods: 107

public class ControlsChangedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC962F5A0
}

public class ConverterList : ConfigurationList`1
{
    public System.Text.Json.JsonSerializerOptions IsReadOnly; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9045890
    public void get_IsReadOnly(){} // RVA: 0x7FFAC9045A30
    public void OnCollectionModifying(){} // RVA: 0x7FFAC9045A60
}

public class CookieCollectionEnumerator : Object
{
    public System.Net.CookieCollection System.Collections.IEnumerator.Current; // 0x10
    public int m_count; // 0x18
    public int m_index; // 0x1C
    public int m_version; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92CEB10
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC92CEBB0
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC92CECB0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC92CED60
}

public class CoreShaderIds : Object
{
    public int _EdgeChoke;
    public int _VertexBuffer; // 0x4
    public int _NormalHeight; // 0x8
    public int _LatticeSize; // 0xC
    public int _PerspectiveTextureSize; // 0x10
    public string _DitherEdgeKW; // 0x18

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC494F260
}

public class Counter : Object
{
    public int _value; // 0x10

    // ── Methods ──
    public void GetNextValue(){} // RVA: 0x7FFAC8BA8E70
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class CounterItem : Object
{
    public int Value;

    // ── Methods ──
    public void get_Value(){} // RVA: 0x7FFAC2C59960
    public void Add(){} // RVA: 0x7FFAC2C70ED0
    public void Increment(){} // RVA: 0x7FFAC2C70980
    public void ReadAndReset(){} // RVA: 0x7FFAC2C59960
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class CountryName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368F10
}

public class CreateJointParams : ValueType
{
    public UnityEngine.Rigidbody rigidbody; // 0x10
    public UnityEngine.Rigidbody connectedBody; // 0x18
    public UnityEngine.Transform child; // 0x20
    public UnityEngine.Vector3 worldSwingAxis; // 0x28
    public Limits limits; // 0x34
    public 0x6B1BEA70 type; // 0x44

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FD55E0
}

public class CreateOutputMethod : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC98F82C0
    public void Invoke(){} // RVA: 0x7FFAC5CBF150
}

public class CreatePipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC480CDD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC3C20DC0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class CreateRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC480CDD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC3C20DC0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class CreateRuntimePanelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB2620
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class CreatorPropertyContext : Object
{
    public string Name; // 0x10
    public Newtonsoft.Json.Serialization.JsonProperty Property; // 0x18
    public Newtonsoft.Json.Serialization.JsonProperty ConstructorProperty; // 0x20
    public System.Nullable`1<0x6B1C90D0> Presence; // 0x28
    public object Value; // 0x30
    public bool Used; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
}

public class CredentialsBundle : Object
{
    public string username; // 0x10
    public string password; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Criterion : ValueType
{
    public string key; // 0x10
    public 0x6B255370 importance; // 0x18
    public System.Collections.Generic.Dictionary`2<string,object> parameters; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8861740
}

public class CryptoApiEntropySource : Object
{
    public System.Security.Cryptography.RandomNumberGenerator BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.IsPredictionResistant; // 0x10
    public bool BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.EntropySize; // 0x18
    public int mEntropySize; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC98BA7E0
    public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.get_IsPredictionResistant(){} // RVA: 0x7FFAC2F3C4E0
    public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.GetEntropy(){} // RVA: 0x7FFACBB838D0
    public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.get_EntropySize(){} // RVA: 0x7FFAC44357F0
}

public class CtrDrbgProvider : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher mBlockCipher; // 0x10
    public int mKeySizeInBits; // 0x18
    public byte[] mNonce; // 0x20
    public byte[] mPersonalizationString; // 0x28
    public int mSecurityStrength; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB86520
    public void Get(){} // RVA: 0x7FFACBB86640
}

public class CullStateChangedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C54E80
}

public class CultureComparer : Object
{
    public System.ComponentModel.CultureInfoConverter _converter; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Compare(){} // RVA: 0x7FFAC93EF6A0
}

public class CultureInfoMapper : Object
{
    public System.Collections.Generic.Dictionary`2<string,string> s_cultureInfoNameMap;

    // ── Methods ──
    public void CreateMap(){} // RVA: 0x7FFAC93EF870
    public void GetCultureInfoName(){} // RVA: 0x7FFAC93F58D0
    public void .cctor(){} // RVA: 0x7FFAC93F5970
}

public class CultureNameResourceSetPair : Object
{
    public string lastCultureName; // 0x10
    public System.Resources.ResourceSet lastResourceSet; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Curve25519Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBC4F050
    public void .cctor(){} // RVA: 0x7FFACBC4F1A0
}

public class Curve25519LookupTable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519 Size; // 0x10
    public uint[] m_table; // 0x18
    public int m_size; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7E02DD0
    public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    public void Lookup(){} // RVA: 0x7FFACBB07CC0
}

public class CustomAnimLayer : ValueType
{
    public bool isEnabled; // 0x10
    public 0x6B2D3E88 type; // 0x14
    public UnityEngine.RuntimeAnimatorController animatorController; // 0x18
    public UnityEngine.AvatarMask mask; // 0x20
    public bool isDefault; // 0x28
}

public class CustomBlend : ValueType
{
    public string m_From; // 0x10
    public string m_To; // 0x18
    public Cinemachine.CinemachineBlendDefinition m_Blend; // 0x20
}

public class CustomBlendable : ValueType
{
    public UnityEngine.Object m_Custom; // 0x10
    public float m_Weight; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BAF7D0
}

public class CustomDataModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC995CA20
    public void set_enabled(){} // RVA: 0x7FFAC995CA70
    public void SetMode(){} // RVA: 0x7FFAC995CAD0
    public void GetMode(){} // RVA: 0x7FFAC995CB40
    public void SetVectorComponentCount(){} // RVA: 0x7FFAC995CBA0
    public void GetVectorComponentCount(){} // RVA: 0x7FFAC995CC10
    public void SetVector(){} // RVA: 0x7FFAC995CC70
    public void GetVector(){} // RVA: 0x7FFAC995CCF0
    public void SetColor(){} // RVA: 0x7FFAC995CD80
    public void GetColor(){} // RVA: 0x7FFAC995CDF0
    public void get_enabled_Injected(){} // RVA: 0x7FFAC995CA20
    public void set_enabled_Injected(){} // RVA: 0x7FFAC995CA70
    public void SetMode_Injected(){} // RVA: 0x7FFAC995CAD0
    public void GetMode_Injected(){} // RVA: 0x7FFAC995CB40
    public void SetVectorComponentCount_Injected(){} // RVA: 0x7FFAC995CBA0
    public void GetVectorComponentCount_Injected(){} // RVA: 0x7FFAC995CC10
    public void SetVector_Injected(){} // RVA: 0x7FFAC995CE80
    public void GetVector_Injected(){} // RVA: 0x7FFAC995CF00
    public void SetColor_Injected(){} // RVA: 0x7FFAC995CF80
    public void GetColor_Injected(){} // RVA: 0x7FFAC995CFF0
}

public class CustomEmojiParticleSystemList : ScriptableObject
{
    public EmojiParticleSystem[] Count; // 0x18

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFAC43BA6F0
    public void .ctor(){} // RVA: 0x7FFAC312F5F0
    public void OnStop(){} // RVA: 0x7FFAC43BA6F0
    public void .ctor_5E5B9E321DF6(){} // RVA: 0x7FFAC43BA700
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC43BA6F0
    public void IndexOf(){} // RVA: 0x7FFAC43BA6F0
    public void Equals(){} // RVA: 0x7FFAC43BA950
    public void GetHashCode(){} // RVA: 0x7FFAC43BAB30
    public void ToString(){} // RVA: 0x7FFAC43BAC00
    public void DoGetFormattedFallbackText(){} // RVA: 0x7FFAC43BACD0
    public void GetItemByIndex(){} // RVA: 0x7FFAC43BAEB0
    public void DoThrowArgumentException(){} // RVA: 0x7FFAC43BAEB0
    public void GetItemByIndex_764F7C9EC378(){} // RVA: 0x7FFAC43BAEB0
}

public class CustomEyeLookSettings : ValueType
{
    public EyeMovements eyeMovement; // 0x10
    public UnityEngine.Transform leftEye; // 0x18
    public UnityEngine.Transform rightEye; // 0x20
    public EyeRotations eyesLookingStraight; // 0x28
    public EyeRotations eyesLookingUp; // 0x30
    public EyeRotations eyesLookingDown; // 0x38
    public EyeRotations eyesLookingLeft; // 0x40
    public EyeRotations eyesLookingRight; // 0x48
    public 0x6B2D3EE0 eyelidType; // 0x50
    public UnityEngine.Transform upperLeftEyelid; // 0x58
    public UnityEngine.Transform upperRightEyelid; // 0x60
    public UnityEngine.Transform lowerLeftEyelid; // 0x68
    public UnityEngine.Transform lowerRightEyelid; // 0x70
    public EyelidRotations eyelidsDefault; // 0x78
    public EyelidRotations eyelidsClosed; // 0x80
    public EyelidRotations eyelidsLookingUp; // 0x88
    public EyelidRotations eyelidsLookingDown; // 0x90
    public UnityEngine.SkinnedMeshRenderer eyelidsSkinnedMesh; // 0x98
    public int[] eyelidsBlendshapes; // 0xA0
}

public class CustomQuery : Object
{
    public System.Collections.Generic.Dictionary`2<string,object> data; // 0x10
    public Criterion[] criteria; // 0x18

    // ── Methods ──
    public void ToUnmanaged(){} // RVA: 0x7FFAC8861210
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class CustomRestriction : BindingRestrictions
{
    public System.Linq.Expressions.Expression _expression; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8DF7060
    public void Equals(){} // RVA: 0x7FFAC8DF7100
    public void GetHashCode(){} // RVA: 0x7FFAC8DF7170
    public void GetExpression(){} // RVA: 0x7FFAC2F3C380
}

public class CustomStyleAccess : Object
{
    public System.Collections.Generic.Dictionary`2<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties; // 0x10
    public float m_DpiScaling; // 0x18

    // ── Methods ──
    public void SetContext(){} // RVA: 0x7FFAC49B0960
    public void TryGetValue(){} // RVA: 0x7FFAC9BF50C0 | overloaded x8
    public void LogCustomPropertyWarning(){} // RVA: 0x7FFAC9BF5160
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class CustomTriggerTarget : Object
{
    public UnityEngine.GameObject TriggerObject; // 0x10
    public string CustomName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC06B1F0
}

public class cap_user_data_t : ValueType
{
    public uint effective; // 0x10
    public uint permitted; // 0x14
    public uint inheritable; // 0x18
}

public class cap_user_header_t : ValueType
{
    public uint version; // 0x10
    public int pid; // 0x14
}
