// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
// Classes: 54
// Methods: 266

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
    public class AsymmetricCipherKeyPair : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter Public; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter Private; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB11F60
        public void get_Public(){} // RVA: 0x7FFAC2F3C380
        public void get_Private(){} // RVA: 0x7FFAC2F247C0
    }

    public class AsymmetricKeyParameter : Object
    {
        public bool IsPrivate; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_IsPrivate(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFACBB121A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB121C0
    }

    public class BufferedAeadBlockCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher AlgorithmName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB12210
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB12300
        public void Init(){} // RVA: 0x7FFACBB12350
        public void GetBlockSize(){} // RVA: 0x7FFACBB12440
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBB12490
        public void GetOutputSize(){} // RVA: 0x7FFACBB124F0
        public void ProcessByte(){} // RVA: 0x7FFACBB12640 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFACBB12890 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFACBB12B80 | overloaded x3
        public void Reset(){} // RVA: 0x7FFACBB12BF0
    }

    public class BufferedAsymmetricBlockCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher AlgorithmName; // 0x10
        public byte[] buffer; // 0x18
        public int bufOff; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB12C40
        public void GetBufferPosition(){} // RVA: 0x7FFAC30DBBE0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB12CE0
        public void GetBlockSize(){} // RVA: 0x7FFACBB12D30
        public void GetOutputSize(){} // RVA: 0x7FFACBB12D80
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC34F9180
        public void Init(){} // RVA: 0x7FFACBB12DD0
        public void ProcessByte(){} // RVA: 0x7FFACBB12EF0
        public void ProcessBytes(){} // RVA: 0x7FFACBB12F90
        public void DoFinal(){} // RVA: 0x7FFACBB13170 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBB131B0
    }

    public class BufferedBlockCipher : BufferedCipherBase
    {
        public byte[] AlgorithmName; // 0x10
        public int bufOff; // 0x18
        public bool forEncryption; // 0x1C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB13240 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB133E0
        public void Init(){} // RVA: 0x7FFACBB13430
        public void GetBlockSize(){} // RVA: 0x7FFACBB13520
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBB13570
        public void GetOutputSize(){} // RVA: 0x7FFACBB135A0
        public void ProcessByte(){} // RVA: 0x7FFACBB136D0 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFACBB13920 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFACBB13F80 | overloaded x3
        public void Reset(){} // RVA: 0x7FFACBB141A0
    }

    public class BufferedCipherBase : Object
    {
        public byte[] AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GetBlockSize(){} // RVA: 0x7FFAC2C59960
        public void GetOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void ProcessByte(){} // RVA: 0x7FFACBB14220 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFACBB14370 | overloaded x4
        public void DoFinal(){} // RVA: 0x7FFACBB14560 | overloaded x6
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB145E0
    }

    public class BufferedIesCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.IesEngine AlgorithmName; // 0x10
        public bool forEncryption; // 0x18
        public System.IO.MemoryStream buffer; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB14690
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB14820
        public void Init(){} // RVA: 0x7FFACBB14860
        public void GetBlockSize(){} // RVA: 0x7FFAC34F9180
        public void GetOutputSize(){} // RVA: 0x7FFACBB148B0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC34F9180
        public void ProcessByte(){} // RVA: 0x7FFACBB14950
        public void ProcessBytes(){} // RVA: 0x7FFACBB14980
        public void DoFinal(){} // RVA: 0x7FFACBB13170 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBB14B90
    }

    public class BufferedStreamCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IStreamCipher AlgorithmName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB14BC0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB14CB0
        public void Init(){} // RVA: 0x7FFACBB14D00
        public void GetBlockSize(){} // RVA: 0x7FFAC34F9180
        public void GetOutputSize(){} // RVA: 0x7FFAC5DEA830
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC5DEA830
        public void ProcessByte(){} // RVA: 0x7FFACBB14EA0 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFACBB15050 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFACBB15160 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBB15230
    }

    public class Check : Object
    {
        // ── Methods ──
        public void DataLength(){} // RVA: 0x7FFACBB152E0 | overloaded x2
        public void OutputLength(){} // RVA: 0x7FFACBB15350
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CipherKeyGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom DefaultStrength; // 0x10
        public int strength; // 0x18
        public bool uninitialised; // 0x1C
        public int defaultStrength; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB153C0 | overloaded x2
        public void get_DefaultStrength(){} // RVA: 0x7FFAC30DBBE0
        public void Init(){} // RVA: 0x7FFACBB15450
        public void engineInit(){} // RVA: 0x7FFACBB154D0
        public void GenerateKey(){} // RVA: 0x7FFACBB15550
        public void engineGenerateKey(){} // RVA: 0x7FFACBB15680
    }

    public class CryptoException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB157E0 | overloaded x3
    }

    public class DataLengthException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB15850 | overloaded x3
    }

    public class IAsymmetricBlockCipher
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GetInputBlockSize(){} // RVA: 0x7FFAC2C59960
        public void GetOutputBlockSize(){} // RVA: 0x7FFAC2C59960
        public void ProcessBlock(){}
    }

    public class IAsymmetricCipherKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void GenerateKeyPair(){} // RVA: 0x7FFAC2C58E90
    }

    public class IBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void GetFieldSize(){} // RVA: 0x7FFAC2C59960
        public void CalculateAgreement(){} // RVA: 0x7FFAC2C58F40
    }

    public class IBlockCipher
    {
        public object AlgorithmName;
        public object IsPartialBlockOkay;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GetBlockSize(){} // RVA: 0x7FFAC2C59960
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2C59D00
        public void ProcessBlock(){}
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IBlockResult
    {
        // ── Methods ──
        public void Collect(){} // RVA: 0x7FFAC2C58E90 | overloaded x2
    }

    public class IBufferedCipher
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GetBlockSize(){} // RVA: 0x7FFAC2C59960
        public void GetOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void ProcessByte(){} // overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFAC2C58F40 | overloaded x4
        public void DoFinal(){} // RVA: 0x7FFAC2C58F40 | overloaded x6
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class ICipher
    {
        public object Stream;

        // ── Methods ──
        public void GetMaxOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void get_Stream(){} // RVA: 0x7FFAC2C58E90
    }

    public class ICipherBuilder
    {
        public object AlgorithmDetails;

        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2C58E90
        public void GetMaxOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void BuildCipher(){} // RVA: 0x7FFAC2C58F40
    }

    public class ICipherBuilderWithKey
    {
        public object Key;

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAC2C58E90
    }

    public class ICipherParameters
    {
    }

    public class IDecryptorBuilderProvider
    {
        // ── Methods ──
        public void CreateDecryptorBuilder(){} // RVA: 0x7FFAC2C58F40
    }

    public class IDerivationFunction
    {
        public object Digest;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void get_Digest(){} // RVA: 0x7FFAC2C58E90
        public void GenerateBytes(){}
    }

    public class IDerivationParameters
    {
    }

    public class IDigest
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void GetDigestSize(){} // RVA: 0x7FFAC2C59960
        public void GetByteLength(){} // RVA: 0x7FFAC2C59960
        public void Update(){} // RVA: 0x7FFAC2C71060
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IDsa
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GenerateSignature(){} // RVA: 0x7FFAC2C58F40
        public void VerifySignature(){}
    }

    public class IDsaExt
    {
        public object Order;

        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEntropySource
    {
        public object IsPredictionResistant;
        public object EntropySize;

        // ── Methods ──
        public void get_IsPredictionResistant(){} // RVA: 0x7FFAC2C59D00
        public void GetEntropy(){} // RVA: 0x7FFAC2C58E90
        public void get_EntropySize(){} // RVA: 0x7FFAC2C59960
    }

    public class IEntropySourceProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2C67DE0
    }

    public class IKeyUnwrapper
    {
        public object AlgorithmDetails;

        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2C58E90
        public void Unwrap(){}
    }

    public class IKeyWrapper
    {
        public object AlgorithmDetails;

        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2C58E90
        public void Wrap(){} // RVA: 0x7FFAC2C58F40
    }

    public class IMac
    {
        public object AlgorithmName;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void GetMacSize(){} // RVA: 0x7FFAC2C59960
        public void Update(){} // RVA: 0x7FFAC2C71060
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IMacDerivationFunction
    {
        // ── Methods ──
        public void GetMac(){} // RVA: 0x7FFAC2C58E90
    }

    public class IMacFactory
    {
        public object AlgorithmDetails;

        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2C58E90
        public void CreateCalculator(){} // RVA: 0x7FFAC2C58E90
    }

    public class IRawAgreement
    {
        public object AgreementSize;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void get_AgreementSize(){} // RVA: 0x7FFAC2C59960
        public void CalculateAgreement(){}
    }

    public class IRsa
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GetInputBlockSize(){} // RVA: 0x7FFAC2C59960
        public void GetOutputBlockSize(){} // RVA: 0x7FFAC2C59960
        public void ConvertInput(){}
        public void ProcessBlock(){} // RVA: 0x7FFAC2C58F40
        public void ConvertOutput(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISignatureFactory
    {
        public object AlgorithmDetails;

        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2C58E90
        public void CreateCalculator(){} // RVA: 0x7FFAC2C58E90
    }

    public class ISigner
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void Update(){} // RVA: 0x7FFAC2C71060
        public void BlockUpdate(){}
        public void GenerateSignature(){} // RVA: 0x7FFAC2C58E90
        public void VerifySignature(){} // RVA: 0x7FFAC2C59F60
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class ISignerWithRecovery
    {
        // ── Methods ──
        public void HasFullMessage(){} // RVA: 0x7FFAC2C59D00
        public void GetRecoveredMessage(){} // RVA: 0x7FFAC2C58E90
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFAC2C70A40
    }

    public class IStreamCalculator
    {
        public object Stream;

        // ── Methods ──
        public void get_Stream(){} // RVA: 0x7FFAC2C58E90
        public void GetResult(){} // RVA: 0x7FFAC2C58E90
    }

    public class IStreamCipher
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void ReturnByte(){} // RVA: 0x7FFAC2C5A420
        public void ProcessBytes(){}
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IVerifier
    {
        // ── Methods ──
        public void IsVerified(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
    }

    public class IVerifierFactory
    {
        public object AlgorithmDetails;

        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2C58E90
        public void CreateCalculator(){} // RVA: 0x7FFAC2C58E90
    }

    public class IVerifierFactoryProvider
    {
        // ── Methods ──
        public void CreateVerifierFactory(){} // RVA: 0x7FFAC2C58F40
    }

    public class IWrapper
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void Wrap(){}
        public void Unwrap(){}
    }

    public class IXof
    {
        // ── Methods ──
        public void DoFinal(){}
        public void DoOutput(){}
    }

    public class InvalidCipherTextException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB15850 | overloaded x3
    }

    public class KeyGenerationParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom Random; // 0x10
        public int Strength; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB15860
        public void get_Random(){} // RVA: 0x7FFAC2F3C380
        public void get_Strength(){} // RVA: 0x7FFAC3157800
    }

    public class MaxBytesExceededException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB15850 | overloaded x3
    }

    public class OutputLengthException : DataLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB15850 | overloaded x3
    }

    public class PbeParametersGenerator : Object
    {
        public byte[] Password; // 0x10
        public byte[] Salt; // 0x18
        public int IterationCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBB15980
        public void get_Password(){} // RVA: 0x7FFACBB15C10
        public void GetPassword(){} // RVA: 0x7FFAC2FD5BE0
        public void get_Salt(){} // RVA: 0x7FFACBB15CC0
        public void GetSalt(){} // RVA: 0x7FFAC3EEA090
        public void get_IterationCount(){} // RVA: 0x7FFAC30DBBE0
        public void GenerateDerivedParameters(){} // RVA: 0x7FFAC2C69DD0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFAC2C67DE0
        public void Pkcs5PasswordToBytes(){} // RVA: 0x7FFACBB15ED0 | overloaded x2
        public void Pkcs5PasswordToUtf8Bytes(){} // RVA: 0x7FFACBB15FA0 | overloaded x2
        public void Pkcs12PasswordToBytes(){} // RVA: 0x7FFACBB16030 | overloaded x2
    }

    public class SimpleBlockResult : Object
    {
        public byte[] Length; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Length(){} // RVA: 0x7FFAC3510620
        public void Collect(){} // RVA: 0x7FFACBB16100 | overloaded x2
    }

    public class StreamBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher AlgorithmName; // 0x10
        public byte[] oneByte; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB16150
        public void Init(){} // RVA: 0x7FFACBB16320
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB163A0
        public void ReturnByte(){} // RVA: 0x7FFACBB163F0
        public void ProcessBytes(){} // RVA: 0x7FFACBB16490
        public void Reset(){} // RVA: 0x7FFACBB16630
    }

}