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
        public void .ctor(){} // RVA: 0x7FFAFBFB91B0
        public void get_Public(){} // RVA: 0x7FFAF2DA8380
        public void get_Private(){} // RVA: 0x7FFAF2D907C0
    }

    public class AsymmetricKeyParameter
    {
        public object AlgorithmName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E575F0
        public void get_IsPrivate(){} // RVA: 0x7FFAF2E575E0
        public void Equals(){} // RVA: 0x7FFAFBFB93F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFBFB9410
    }

    public class BufferedAeadBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFB9460
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFB9550
        public void Init(){} // RVA: 0x7FFAFBFB95A0
        public void GetBlockSize(){} // RVA: 0x7FFAFBFB9690
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFBFB96E0
        public void GetOutputSize(){} // RVA: 0x7FFAFBFB9740
        public void ProcessByte(){} // RVA: 0x7FFAFBFB9890 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFAFBFB9AE0 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFAFBFB9DD0 | overloaded x3
        public void Reset(){} // RVA: 0x7FFAFBFB9E40
    }

    public class BufferedAsymmetricBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFB9E90
        public void GetBufferPosition(){} // RVA: 0x7FFAF3210030
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFB9F30
        public void GetBlockSize(){} // RVA: 0x7FFAFBFB9F80
        public void GetOutputSize(){} // RVA: 0x7FFAFBFB9FD0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2FC9240
        public void Init(){} // RVA: 0x7FFAFBFBA020
        public void ProcessByte(){} // RVA: 0x7FFAFBFBA140
        public void ProcessBytes(){} // RVA: 0x7FFAFBFBA1E0
        public void DoFinal(){} // RVA: 0x7FFAFBFBA3C0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFBFBA400
    }

    public class BufferedBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBA490 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFBA630
        public void Init(){} // RVA: 0x7FFAFBFBA680
        public void GetBlockSize(){} // RVA: 0x7FFAFBFBA770
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFBFBA7C0
        public void GetOutputSize(){} // RVA: 0x7FFAFBFBA7F0
        public void ProcessByte(){} // RVA: 0x7FFAFBFBA920 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFAFBFBAB70 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFAFBFBB1D0 | overloaded x3
        public void Reset(){} // RVA: 0x7FFAFBFBB3F0
    }

    public class BufferedCipherBase
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GetBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void GetOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void ProcessByte(){} // RVA: 0x7FFAFBFBB470 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFAFBFBB5C0 | overloaded x4
        public void DoFinal(){} // RVA: 0x7FFAFBFBB7B0 | overloaded x6
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBFBB830
    }

    public class BufferedIesCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBB8E0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFBBA70
        public void Init(){} // RVA: 0x7FFAFBFBBAB0
        public void GetBlockSize(){} // RVA: 0x7FFAF2FC9240
        public void GetOutputSize(){} // RVA: 0x7FFAFBFBBB00
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2FC9240
        public void ProcessByte(){} // RVA: 0x7FFAFBFBBBA0
        public void ProcessBytes(){} // RVA: 0x7FFAFBFBBBD0
        public void DoFinal(){} // RVA: 0x7FFAFBFBA3C0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFBFBBDE0
    }

    public class BufferedStreamCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBBE10
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFBBF00
        public void Init(){} // RVA: 0x7FFAFBFBBF50
        public void GetBlockSize(){} // RVA: 0x7FFAF2FC9240
        public void GetOutputSize(){} // RVA: 0x7FFAF65F5020
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF65F5020
        public void ProcessByte(){} // RVA: 0x7FFAFBFBC0F0 | overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFAFBFBC2A0 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFAFBFBC3B0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFBFBC480
    }

    public class Check
    {
        // ── Methods ──
        public void DataLength(){} // RVA: 0x7FFAFBFBC530 | overloaded x2
        public void OutputLength(){} // RVA: 0x7FFAFBFBC5A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CipherKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBC610 | overloaded x2
        public void get_DefaultStrength(){} // RVA: 0x7FFAF3210030
        public void Init(){} // RVA: 0x7FFAFBFBC6A0
        public void engineInit(){} // RVA: 0x7FFAFBFBC720
        public void GenerateKey(){} // RVA: 0x7FFAFBFBC7A0
        public void engineGenerateKey(){} // RVA: 0x7FFAFBFBC8D0
    }

    public class CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBCA30 | overloaded x3
    }

    public class DataLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBCAA0 | overloaded x3
    }

    public class IAsymmetricBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GetInputBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void GetOutputBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void ProcessBlock(){}
    }

    public class IAsymmetricCipherKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void GenerateKeyPair(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void GetFieldSize(){} // RVA: 0x7FFAF2ABD840
        public void CalculateAgreement(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GetBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2ABDBE0
        public void ProcessBlock(){}
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IBlockResult
    {
        // ── Methods ──
        public void Collect(){} // RVA: 0x7FFAF2ABCD60 | overloaded x2
    }

    public class IBufferedCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GetBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void GetOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void ProcessByte(){} // overloaded x2
        public void ProcessBytes(){} // RVA: 0x7FFAF2ABCE10 | overloaded x4
        public void DoFinal(){} // RVA: 0x7FFAF2ABCE10 | overloaded x6
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ICipher
    {
        // ── Methods ──
        public void GetMaxOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void get_Stream(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ICipherBuilder
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2ABCD60
        public void GetMaxOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void BuildCipher(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ICipherBuilderWithKey
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ICipherParameters
    {
    }

    public class IDecryptorBuilderProvider
    {
        // ── Methods ──
        public void CreateDecryptorBuilder(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IDerivationFunction
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void get_Digest(){} // RVA: 0x7FFAF2ABCD60
        public void GenerateBytes(){}
    }

    public class IDerivationParameters
    {
    }

    public class IDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void GetDigestSize(){} // RVA: 0x7FFAF2ABD840
        public void GetByteLength(){} // RVA: 0x7FFAF2ABD840
        public void Update(){} // RVA: 0x7FFAF2AD5130
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IDsa
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GenerateSignature(){} // RVA: 0x7FFAF2ABCE10
        public void VerifySignature(){}
    }

    public class IDsaExt
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IEntropySource
    {
        // ── Methods ──
        public void get_IsPredictionResistant(){} // RVA: 0x7FFAF2ABDBE0
        public void GetEntropy(){} // RVA: 0x7FFAF2ABCD60
        public void get_EntropySize(){} // RVA: 0x7FFAF2ABD840
    }

    public class IEntropySourceProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAF2ACBCC0
    }

    public class IKeyUnwrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2ABCD60
        public void Unwrap(){}
    }

    public class IKeyWrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2ABCD60
        public void Wrap(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IMac
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void GetMacSize(){} // RVA: 0x7FFAF2ABD840
        public void Update(){} // RVA: 0x7FFAF2AD5130
        public void BlockUpdate(){}
        public void DoFinal(){}
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IMacDerivationFunction
    {
        // ── Methods ──
        public void GetMac(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IMacFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2ABCD60
        public void CreateCalculator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IRawAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD4B10
        public void get_AgreementSize(){} // RVA: 0x7FFAF2ABD840
        public void CalculateAgreement(){}
    }

    public class IRsa
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GetInputBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void GetOutputBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void ConvertInput(){}
        public void ProcessBlock(){} // RVA: 0x7FFAF2ABCE10
        public void ConvertOutput(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ISignatureFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2ABCD60
        public void CreateCalculator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISigner
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void Update(){} // RVA: 0x7FFAF2AD5130
        public void BlockUpdate(){}
        public void GenerateSignature(){} // RVA: 0x7FFAF2ABCD60
        public void VerifySignature(){} // RVA: 0x7FFAF2ABDE40
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ISignerWithRecovery
    {
        // ── Methods ──
        public void HasFullMessage(){} // RVA: 0x7FFAF2ABDBE0
        public void GetRecoveredMessage(){} // RVA: 0x7FFAF2ABCD60
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IStreamCalculator
    {
        // ── Methods ──
        public void get_Stream(){} // RVA: 0x7FFAF2ABCD60
        public void GetResult(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IStreamCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void ReturnByte(){} // RVA: 0x7FFAF2ABE300
        public void ProcessBytes(){}
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IVerifier
    {
        // ── Methods ──
        public void IsVerified(){} // RVA: 0x7FFAF2ABDE40 | overloaded x2
    }

    public class IVerifierFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2ABCD60
        public void CreateCalculator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IVerifierFactoryProvider
    {
        // ── Methods ──
        public void CreateVerifierFactory(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IWrapper
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
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
        public void .ctor(){} // RVA: 0x7FFAFBFBCAA0 | overloaded x3
    }

    public class KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBCAB0
        public void get_Random(){} // RVA: 0x7FFAF2DA8380
        public void get_Strength(){} // RVA: 0x7FFAF306ED50
    }

    public class MaxBytesExceededException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBCAA0 | overloaded x3
    }

    public class OutputLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBCAA0 | overloaded x3
    }

    public class PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Init(){} // RVA: 0x7FFAFBFBCBD0
        public void get_Password(){} // RVA: 0x7FFAFBFBCE60
        public void GetPassword(){} // RVA: 0x7FFAF2E41BE0
        public void get_Salt(){} // RVA: 0x7FFAFBFBCF10
        public void GetSalt(){} // RVA: 0x7FFAF91CBFB0
        public void get_IterationCount(){} // RVA: 0x7FFAF3210030
        public void GenerateDerivedParameters(){} // RVA: 0x7FFAF2ACDD80 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFAF2ACBCC0
        public void Pkcs5PasswordToBytes(){} // RVA: 0x7FFAFBFBD120 | overloaded x2
        public void Pkcs5PasswordToUtf8Bytes(){} // RVA: 0x7FFAFBFBD1F0 | overloaded x2
        public void Pkcs12PasswordToBytes(){} // RVA: 0x7FFAFBFBD280 | overloaded x2
    }

    public class SimpleBlockResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Length(){} // RVA: 0x7FFAF39EF910
        public void Collect(){} // RVA: 0x7FFAFBFBD350 | overloaded x2
    }

    public class StreamBlockCipher : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFBD3A0
        public void Init(){} // RVA: 0x7FFAFBFBD570
        public void get_AlgorithmName(){} // RVA: 0x7FFAFBFBD5F0
        public void ReturnByte(){} // RVA: 0x7FFAFBFBD640
        public void ProcessBytes(){} // RVA: 0x7FFAFBFBD6E0
        public void Reset(){} // RVA: 0x7FFAFBFBD880
    }

}