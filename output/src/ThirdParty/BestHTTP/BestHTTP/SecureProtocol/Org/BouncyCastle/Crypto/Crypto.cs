// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
// Classes: 54
// Methods: 266

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
    public class AsymmetricCipherKeyPair
    {
        public object IsPrivate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95091B0
        public void get_Public(){} // RVA: 0x2F8380
        public void get_Private(){} // RVA: 0x2E07C0
    }

    public class AsymmetricKeyParameter
    {
        public object AlgorithmName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
        public void get_IsPrivate(){} // RVA: 0x3A75E0
        public void Equals(){} // RVA: 0x95093F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9509410
    }

    public class BufferedAeadBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9509460
        public void get_AlgorithmName(){} // RVA: 0x9509550
        public void Init(){} // RVA: 0x95095A0
        public void GetBlockSize(){} // RVA: 0x9509690
        public void GetUpdateOutputSize(){} // RVA: 0x95096E0
        public void GetOutputSize(){} // RVA: 0x9509740
        public void ProcessByte(){} // RVA: 0x9509890 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x9509AE0 | overloaded x2
        public void DoFinal(){} // RVA: 0x9509DD0 | overloaded x3
        public void Reset(){} // RVA: 0x9509E40
    }

    public class BufferedAsymmetricBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9509E90
        public void GetBufferPosition(){} // RVA: 0x760030
        public void get_AlgorithmName(){} // RVA: 0x9509F30
        public void GetBlockSize(){} // RVA: 0x9509F80
        public void GetOutputSize(){} // RVA: 0x9509FD0
        public void GetUpdateOutputSize(){} // RVA: 0x519240
        public void Init(){} // RVA: 0x950A020
        public void ProcessByte(){} // RVA: 0x950A140
        public void ProcessBytes(){} // RVA: 0x950A1E0
        public void DoFinal(){} // RVA: 0x950A3C0 | overloaded x2
        public void Reset(){} // RVA: 0x950A400
    }

    public class BufferedBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950A490 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x950A630
        public void Init(){} // RVA: 0x950A680
        public void GetBlockSize(){} // RVA: 0x950A770
        public void GetUpdateOutputSize(){} // RVA: 0x950A7C0
        public void GetOutputSize(){} // RVA: 0x950A7F0
        public void ProcessByte(){} // RVA: 0x950A920 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x950AB70 | overloaded x2
        public void DoFinal(){} // RVA: 0x950B1D0 | overloaded x3
        public void Reset(){} // RVA: 0x950B3F0
    }

    public class BufferedCipherBase
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void GetBlockSize(){} // RVA: 0xD840
        public void GetOutputSize(){} // RVA: 0x13FB0
        public void GetUpdateOutputSize(){} // RVA: 0x13FB0
        public void ProcessByte(){} // RVA: 0x950B470 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x950B5C0 | overloaded x4
        public void DoFinal(){} // RVA: 0x950B7B0 | overloaded x6
        public void Reset(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x950B830
    }

    public class BufferedIesCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950B8E0
        public void get_AlgorithmName(){} // RVA: 0x950BA70
        public void Init(){} // RVA: 0x950BAB0
        public void GetBlockSize(){} // RVA: 0x519240
        public void GetOutputSize(){} // RVA: 0x950BB00
        public void GetUpdateOutputSize(){} // RVA: 0x519240
        public void ProcessByte(){} // RVA: 0x950BBA0
        public void ProcessBytes(){} // RVA: 0x950BBD0
        public void DoFinal(){} // RVA: 0x950A3C0 | overloaded x2
        public void Reset(){} // RVA: 0x950BDE0
    }

    public class BufferedStreamCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950BE10
        public void get_AlgorithmName(){} // RVA: 0x950BF00
        public void Init(){} // RVA: 0x950BF50
        public void GetBlockSize(){} // RVA: 0x519240
        public void GetOutputSize(){} // RVA: 0x3B45020
        public void GetUpdateOutputSize(){} // RVA: 0x3B45020
        public void ProcessByte(){} // RVA: 0x950C0F0 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x950C2A0 | overloaded x2
        public void DoFinal(){} // RVA: 0x950C3B0 | overloaded x2
        public void Reset(){} // RVA: 0x950C480
    }

    public class Check
    {
        // ── Methods ──
        public void DataLength(){} // RVA: 0x950C530 | overloaded x2
        public void OutputLength(){} // RVA: 0x950C5A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CipherKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950C610 | overloaded x2
        public void get_DefaultStrength(){} // RVA: 0x760030
        public void Init(){} // RVA: 0x950C6A0
        public void engineInit(){} // RVA: 0x950C720
        public void GenerateKey(){} // RVA: 0x950C7A0
        public void engineGenerateKey(){} // RVA: 0x950C8D0
    }

    public class CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950CA30 | overloaded x3
    }

    public class DataLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950CAA0 | overloaded x3
    }

    public class IAsymmetricBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void GetInputBlockSize(){} // RVA: 0xD840
        public void GetOutputBlockSize(){} // RVA: 0xD840
        public void ProcessBlock(){}
    }

    public class IAsymmetricCipherKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void GenerateKeyPair(){} // RVA: 0xCD60
    }

    public class IBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void GetFieldSize(){} // RVA: 0xD840
        public void CalculateAgreement(){} // RVA: 0xCE10
    }

    public class IBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void GetBlockSize(){} // RVA: 0xD840
        public void get_IsPartialBlockOkay(){} // RVA: 0xDBE0
        public void ProcessBlock(){}
        public void Reset(){} // RVA: 0x24A50
    }

    public class IBlockResult
    {
        // ── Methods ──
        public void Collect(){} // RVA: 0xCD60 | overloaded x2
    }

    public class IBufferedCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void GetBlockSize(){} // RVA: 0xD840
        public void GetOutputSize(){} // RVA: 0x13FB0
        public void GetUpdateOutputSize(){} // RVA: 0x13FB0
        public void ProcessByte(){} // overloaded x2
        public void ProcessBytes(){} // RVA: 0xCE10 | overloaded x4
        public void DoFinal(){} // RVA: 0xCE10 | overloaded x6
        public void Reset(){} // RVA: 0x24A50
    }

    public class ICipher
    {
        // ── Methods ──
        public void GetMaxOutputSize(){} // RVA: 0x13FB0
        public void GetUpdateOutputSize(){} // RVA: 0x13FB0
        public void get_Stream(){} // RVA: 0xCD60
    }

    public class ICipherBuilder
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0xCD60
        public void GetMaxOutputSize(){} // RVA: 0x13FB0
        public void BuildCipher(){} // RVA: 0xCE10
    }

    public class ICipherBuilderWithKey
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0xCD60
    }

    public class ICipherParameters
    {
    }

    public class IDecryptorBuilderProvider
    {
        // ── Methods ──
        public void CreateDecryptorBuilder(){} // RVA: 0xCE10
    }

    public class IDerivationFunction
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void get_Digest(){} // RVA: 0xCD60
        public void GenerateBytes(){}
    }

    public class IDerivationParameters
    {
    }

    public class IDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void GetDigestSize(){} // RVA: 0xD840
        public void GetByteLength(){} // RVA: 0xD840
        public void Update(){} // RVA: 0x25130
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x24A50
    }

    public class IDsa
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void GenerateSignature(){} // RVA: 0xCE10
        public void VerifySignature(){}
    }

    public class IDsaExt
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0xCD60
    }

    public class IEntropySource
    {
        // ── Methods ──
        public void get_IsPredictionResistant(){} // RVA: 0xDBE0
        public void GetEntropy(){} // RVA: 0xCD60
        public void get_EntropySize(){} // RVA: 0xD840
    }

    public class IEntropySourceProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x1BCC0
    }

    public class IKeyUnwrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0xCD60
        public void Unwrap(){}
    }

    public class IKeyWrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0xCD60
        public void Wrap(){} // RVA: 0xCE10
    }

    public class IMac
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void GetMacSize(){} // RVA: 0xD840
        public void Update(){} // RVA: 0x25130
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x24A50
    }

    public class IMacDerivationFunction
    {
        // ── Methods ──
        public void GetMac(){} // RVA: 0xCD60
    }

    public class IMacFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0xCD60
        public void CreateCalculator(){} // RVA: 0xCD60
    }

    public class IRawAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void get_AgreementSize(){} // RVA: 0xD840
        public void CalculateAgreement(){}
    }

    public class IRsa
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x25600
        public void GetInputBlockSize(){} // RVA: 0xD840
        public void GetOutputBlockSize(){} // RVA: 0xD840
        public void ConvertInput(){}
        public void ProcessBlock(){} // RVA: 0xCE10
        public void ConvertOutput(){} // RVA: 0xCE10
    }

    public class ISignatureFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0xCD60
        public void CreateCalculator(){} // RVA: 0xCD60
    }

    public class ISigner
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void Update(){} // RVA: 0x25130
        public void BlockUpdate(){}
        public void GenerateSignature(){} // RVA: 0xCD60
        public void VerifySignature(){} // RVA: 0xDE40
        public void Reset(){} // RVA: 0x24A50
    }

    public class ISignerWithRecovery
    {
        // ── Methods ──
        public void HasFullMessage(){} // RVA: 0xDBE0
        public void GetRecoveredMessage(){} // RVA: 0xCD60
        public void UpdateWithRecoveredMessage(){} // RVA: 0x24B10
    }

    public class IStreamCalculator
    {
        // ── Methods ──
        public void get_Stream(){} // RVA: 0xCD60
        public void GetResult(){} // RVA: 0xCD60
    }

    public class IStreamCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void ReturnByte(){} // RVA: 0xE300
        public void ProcessBytes(){}
        public void Reset(){} // RVA: 0x24A50
    }

    public class IVerifier
    {
        // ── Methods ──
        public void IsVerified(){} // RVA: 0xDE40 | overloaded x2
    }

    public class IVerifierFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0xCD60
        public void CreateCalculator(){} // RVA: 0xCD60
    }

    public class IVerifierFactoryProvider
    {
        // ── Methods ──
        public void CreateVerifierFactory(){} // RVA: 0xCE10
    }

    public class IWrapper
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void Wrap(){}
        public void Unwrap(){}
    }

    public class IXof
    {
        // ── Methods ──
        public void DoFinal(){}
        public void DoOutput(){}
    }

    public class InvalidCipherTextException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950CAA0 | overloaded x3
    }

    public class KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950CAB0
        public void get_Random(){} // RVA: 0x2F8380
        public void get_Strength(){} // RVA: 0x5BED50
    }

    public class MaxBytesExceededException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950CAA0 | overloaded x3
    }

    public class OutputLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950CAA0 | overloaded x3
    }

    public class PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x950CBD0
        public void get_Password(){} // RVA: 0x950CE60
        public void GetPassword(){} // RVA: 0x391BE0
        public void get_Salt(){} // RVA: 0x950CF10
        public void GetSalt(){} // RVA: 0x671BFB0
        public void get_IterationCount(){} // RVA: 0x760030
        public void GenerateDerivedParameters(){} // RVA: 0x1DD80 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x1BCC0
        public void Pkcs5PasswordToBytes(){} // RVA: 0x950D120 | overloaded x2
        public void Pkcs5PasswordToUtf8Bytes(){} // RVA: 0x950D1F0 | overloaded x2
        public void Pkcs12PasswordToBytes(){} // RVA: 0x950D280 | overloaded x2
    }

    public class SimpleBlockResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Length(){} // RVA: 0xF3F910
        public void Collect(){} // RVA: 0x950D350 | overloaded x2
    }

    public class StreamBlockCipher : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x950D3A0
        public void Init(){} // RVA: 0x950D570
        public void get_AlgorithmName(){} // RVA: 0x950D5F0
        public void ReturnByte(){} // RVA: 0x950D640
        public void ProcessBytes(){} // RVA: 0x950D6E0
        public void Reset(){} // RVA: 0x950D880
    }

}