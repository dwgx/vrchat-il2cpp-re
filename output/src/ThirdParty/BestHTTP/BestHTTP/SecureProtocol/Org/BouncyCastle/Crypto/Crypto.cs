// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
// Classes: 54
// Methods: 266

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
    public class AsymmetricCipherKeyPair : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateParameter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6B580
        public void get_Public(){} // RVA: 0x7FFE81116380
        public void get_Private(){} // RVA: 0x7FFE810FE7C0
    }

    public class AsymmetricKeyParameter : Object
    {
        public bool privateKey; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_IsPrivate(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE89F6B7C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89F6B7E0
    }

    public class BufferedAeadBlockCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6B830
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F6B920
        public void Init(){} // RVA: 0x7FFE89F6B970
        public void GetBlockSize(){} // RVA: 0x7FFE89F6BA60
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE89F6BAB0
        public void GetOutputSize(){} // RVA: 0x7FFE89F6BB10
        public void ProcessByte(){} // RVA: 0x7FFE89F6BC60 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFE89F6BEB0 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFE89F6C1A0 | overloaded x3
        public void Reset(){} // RVA: 0x7FFE89F6C210
    }

    public class BufferedAsymmetricBlockCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6C260
        public void GetBufferPosition(){} // RVA: 0x7FFE8151D690
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F6C300
        public void GetBlockSize(){} // RVA: 0x7FFE89F6C350
        public void GetOutputSize(){} // RVA: 0x7FFE89F6C3A0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE813240E0
        public void Init(){} // RVA: 0x7FFE89F6C3F0
        public void ProcessByte(){} // RVA: 0x7FFE89F6C510
        public void ProcessBytes(){} // RVA: 0x7FFE89F6C5B0
        public void DoFinal(){} // RVA: 0x7FFE89F6C790 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE89F6C7D0
    }

    public class BufferedBlockCipher : BufferedCipherBase
    {
        public byte[] buf; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6C860 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F6CA00
        public void Init(){} // RVA: 0x7FFE89F6CA50
        public void GetBlockSize(){} // RVA: 0x7FFE89F6CB40
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE89F6CB90
        public void GetOutputSize(){} // RVA: 0x7FFE89F6CBC0
        public void ProcessByte(){} // RVA: 0x7FFE89F6CCF0 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFE89F6CF40 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFE89F6D5A0 | overloaded x3
        public void Reset(){} // RVA: 0x7FFE89F6D7C0
    }

    public class BufferedCipherBase : Object
    {
        public byte[] EmptyBuffer;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GetBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void GetOutputSize(){} // RVA: 0x7FFE80E35520
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE80E35520
        public void ProcessByte(){} // RVA: 0x7FFE89F6D840 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFE89F6D990 | overloaded x4
        public void DoFinal(){} // RVA: 0x7FFE89F6DB80 | overloaded x6
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F6DC00
    }

    public class BufferedIesCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.IesEngine engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6DCB0
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F6DE40
        public void Init(){} // RVA: 0x7FFE89F6DE80
        public void GetBlockSize(){} // RVA: 0x7FFE813240E0
        public void GetOutputSize(){} // RVA: 0x7FFE89F6DED0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE813240E0
        public void ProcessByte(){} // RVA: 0x7FFE89F6DF70
        public void ProcessBytes(){} // RVA: 0x7FFE89F6DFA0
        public void DoFinal(){} // RVA: 0x7FFE89F6C790 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE89F6E1B0
    }

    public class BufferedStreamCipher : BufferedCipherBase
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IStreamCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6E1E0
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F6E2D0
        public void Init(){} // RVA: 0x7FFE89F6E320
        public void GetBlockSize(){} // RVA: 0x7FFE813240E0
        public void GetOutputSize(){} // RVA: 0x7FFE8481AF30
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE8481AF30
        public void ProcessByte(){} // RVA: 0x7FFE89F6E4C0 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFE89F6E670 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFE89F6E780 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE89F6E850
    }

    public class Check : Object
    {
        // ── Methods ──
        public void DataLength(){} // RVA: 0x7FFE89F6E900 | overloaded x2
        public void OutputLength(){} // RVA: 0x7FFE89F6E970
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CipherKeyGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6E9E0 | overloaded x2
        public void get_DefaultStrength(){} // RVA: 0x7FFE8151D690
        public void Init(){} // RVA: 0x7FFE89F6EA70
        public void engineInit(){} // RVA: 0x7FFE89F6EAF0
        public void GenerateKey(){} // RVA: 0x7FFE89F6EB70
        public void engineGenerateKey(){} // RVA: 0x7FFE89F6ECA0
    }

    public class CryptoException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6EE00 | overloaded x3
    }

    public class DataLengthException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6EE70 | overloaded x3
    }

    public class IAsymmetricBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GetInputBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void ProcessBlock(){}
    }

    public class IAsymmetricCipherKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void GenerateKeyPair(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void GetFieldSize(){} // RVA: 0x7FFE80E2EDB0
        public void CalculateAgreement(){} // RVA: 0x7FFE80E2E390
    }

    public class IBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GetBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE80E2F150
        public void ProcessBlock(){}
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IBlockResult
    {
        // ── Methods ──
        public void Collect(){} // RVA: 0x7FFE80E2E2E0 | overloaded x2
    }

    public class IBufferedCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GetBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void GetOutputSize(){} // RVA: 0x7FFE80E35520
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE80E35520
        public void ProcessByte(){} // overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFE80E2E390 | overloaded x4
        public void DoFinal(){} // RVA: 0x7FFE80E2E390 | overloaded x6
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class ICipher
    {
        // ── Methods ──
        public void GetMaxOutputSize(){} // RVA: 0x7FFE80E35520
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE80E35520
        public void get_Stream(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ICipherBuilder
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE80E2E2E0
        public void GetMaxOutputSize(){} // RVA: 0x7FFE80E35520
        public void BuildCipher(){} // RVA: 0x7FFE80E2E390
    }

    public class ICipherBuilderWithKey
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ICipherParameters
    {
    }

    public class IDecryptorBuilderProvider
    {
        // ── Methods ──
        public void CreateDecryptorBuilder(){} // RVA: 0x7FFE80E2E390
    }

    public class IDerivationFunction
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void get_Digest(){} // RVA: 0x7FFE80E2E2E0
        public void GenerateBytes(){}
    }

    public class IDerivationParameters
    {
    }

    public class IDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void GetDigestSize(){} // RVA: 0x7FFE80E2EDB0
        public void GetByteLength(){} // RVA: 0x7FFE80E2EDB0
        public void Update(){} // RVA: 0x7FFE80E466C0
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IDsa
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GenerateSignature(){} // RVA: 0x7FFE80E2E390
        public void VerifySignature(){}
    }

    public class IDsaExt
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEntropySource
    {
        // ── Methods ──
        public void get_IsPredictionResistant(){} // RVA: 0x7FFE80E2F150
        public void GetEntropy(){} // RVA: 0x7FFE80E2E2E0
        public void get_EntropySize(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IEntropySourceProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE80E3D230
    }

    public class IKeyUnwrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE80E2E2E0
        public void Unwrap(){}
    }

    public class IKeyWrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE80E2E2E0
        public void Wrap(){} // RVA: 0x7FFE80E2E390
    }

    public class IMac
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void GetMacSize(){} // RVA: 0x7FFE80E2EDB0
        public void Update(){} // RVA: 0x7FFE80E466C0
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IMacDerivationFunction
    {
        // ── Methods ──
        public void GetMac(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IMacFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE80E2E2E0
        public void CreateCalculator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IRawAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void get_AgreementSize(){} // RVA: 0x7FFE80E2EDB0
        public void CalculateAgreement(){}
    }

    public class IRsa
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GetInputBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void ConvertInput(){}
        public void ProcessBlock(){} // RVA: 0x7FFE80E2E390
        public void ConvertOutput(){} // RVA: 0x7FFE80E2E390
    }

    public class ISignatureFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE80E2E2E0
        public void CreateCalculator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISigner
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void Update(){} // RVA: 0x7FFE80E466C0
        public void BlockUpdate(){}
        public void GenerateSignature(){} // RVA: 0x7FFE80E2E2E0
        public void VerifySignature(){} // RVA: 0x7FFE80E2F3B0
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISignerWithRecovery
    {
        // ── Methods ──
        public void HasFullMessage(){} // RVA: 0x7FFE80E2F150
        public void GetRecoveredMessage(){} // RVA: 0x7FFE80E2E2E0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFE80E460A0
    }

    public class IStreamCalculator
    {
        // ── Methods ──
        public void get_Stream(){} // RVA: 0x7FFE80E2E2E0
        public void GetResult(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IStreamCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void ReturnByte(){} // RVA: 0x7FFE80E2F870
        public void ProcessBytes(){}
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IVerifier
    {
        // ── Methods ──
        public void IsVerified(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
    }

    public class IVerifierFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE80E2E2E0
        public void CreateCalculator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IVerifierFactoryProvider
    {
        // ── Methods ──
        public void CreateVerifierFactory(){} // RVA: 0x7FFE80E2E390
    }

    public class IWrapper
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
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
        public void .ctor(){} // RVA: 0x7FFE89F6EE70 | overloaded x3
    }

    public class KeyGenerationParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10
        public int strength; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6EE80
        public void get_Random(){} // RVA: 0x7FFE81116380
        public void get_Strength(){} // RVA: 0x7FFE813DB630
    }

    public class MaxBytesExceededException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6EE70 | overloaded x3
    }

    public class OutputLengthException : DataLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6EE70 | overloaded x3
    }

    public class PbeParametersGenerator : Object
    {
        public byte[] mPassword; // 0x10
        public byte[] mSalt; // 0x18
        public int mIterationCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE89F6EFA0
        public void get_Password(){} // RVA: 0x7FFE89F6F230
        public void GetPassword(){} // RVA: 0x7FFE811AFBE0
        public void get_Salt(){} // RVA: 0x7FFE89F6F2E0
        public void GetSalt(){} // RVA: 0x7FFE8725AEB0
        public void get_IterationCount(){} // RVA: 0x7FFE8151D690
        public void GenerateDerivedParameters(){} // RVA: 0x7FFE80E3F2F0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFE80E3D230
        public void Pkcs5PasswordToBytes(){} // RVA: 0x7FFE89F6F4F0 | overloaded x2
        public void Pkcs5PasswordToUtf8Bytes(){} // RVA: 0x7FFE89F6F5C0 | overloaded x2
        public void Pkcs12PasswordToBytes(){} // RVA: 0x7FFE89F6F650 | overloaded x2
    }

    public class SimpleBlockResult : Object
    {
        public byte[] result; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Length(){} // RVA: 0x7FFE81CCB610
        public void Collect(){} // RVA: 0x7FFE89F6F720 | overloaded x2
    }

    public class StreamBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F6F770
        public void Init(){} // RVA: 0x7FFE89F6F940
        public void get_AlgorithmName(){} // RVA: 0x7FFE89F6F9C0
        public void ReturnByte(){} // RVA: 0x7FFE89F6FA10
        public void ProcessBytes(){} // RVA: 0x7FFE89F6FAB0
        public void Reset(){} // RVA: 0x7FFE89F6FC50
    }

}