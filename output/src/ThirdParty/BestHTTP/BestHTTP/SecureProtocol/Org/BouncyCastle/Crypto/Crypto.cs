// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
// Classes: 52
// Methods: 212

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
    public class AsymmetricCipherKeyPair : Object
    {
        public object publicParameter;
        public object privateParameter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AABB0
        public void get_Public(){} // RVA: 0xB5DBF0
        public void get_Private(){} // RVA: 0xB465B0
    }

    public class AsymmetricKeyParameter : Object
    {
        public object privateKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_IsPrivate(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0xA1AADE0
        public void GetHashCode(){} // RVA: 0x6C49290
    }

    public class BufferedAeadBlockCipher : BufferedCipherBase
    {
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AAE00
        public void get_AlgorithmName(){} // RVA: 0xA1AAEF0
        public void Init(){} // RVA: 0xA1AAF40
        public void GetBlockSize(){} // RVA: 0xA1AB030
        public void GetUpdateOutputSize(){} // RVA: 0xA1AB080
        public void GetOutputSize(){} // RVA: 0xA1AB0E0
        public void ProcessByte(){} // RVA: 0xA1AB230
        public void ProcessBytes(){} // RVA: 0xA1AB480
        public void DoFinal(){} // RVA: 0xA1AB770
        public void Reset(){} // RVA: 0xA1AB7E0
    }

    public class BufferedAsymmetricBlockCipher : BufferedCipherBase
    {
        public object cipher;
        public object buffer;
        public object bufOff;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AB830
        public void GetBufferPosition(){} // RVA: 0xFEAE90
        public void get_AlgorithmName(){} // RVA: 0xA1AB8D0
        public void GetBlockSize(){} // RVA: 0xA1AB920
        public void GetOutputSize(){} // RVA: 0xA1AB970
        public void GetUpdateOutputSize(){} // RVA: 0xDAC980
        public void Init(){} // RVA: 0xA1AB9C0
        public void ProcessByte(){} // RVA: 0xA1ABAE0
        public void ProcessBytes(){} // RVA: 0xA1ABB80
        public void DoFinal(){} // RVA: 0xA1ABD60
        public void Reset(){} // RVA: 0xA1ABDA0
    }

    public class BufferedBlockCipher : BufferedCipherBase
    {
        public object buf;
        public object bufOff;
        public object forEncryption;
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1ABE30
        public void get_AlgorithmName(){} // RVA: 0xA1ABFD0
        public void Init(){} // RVA: 0xA1AC020
        public void GetBlockSize(){} // RVA: 0xA1AC100
        public void GetUpdateOutputSize(){} // RVA: 0xA1AC150
        public void GetOutputSize(){} // RVA: 0xA1AC180
        public void ProcessByte(){} // RVA: 0xA1AC2B0
        public void ProcessBytes(){} // RVA: 0xA1AC500
        public void DoFinal(){} // RVA: 0xA1ACB60
        public void Reset(){} // RVA: 0xA1ACD80
    }

    public class BufferedCipherBase : Object
    {
        public object EmptyBuffer;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void GetBlockSize(){} // RVA: 0x87C130
        public void GetOutputSize(){} // RVA: 0x881C20
        public void GetUpdateOutputSize(){} // RVA: 0x881C20
        public void ProcessByte(){} // RVA: 0xA1ACE00
        public void ProcessBytes(){} // RVA: 0xA1ACF50
        public void DoFinal(){} // RVA: 0xA1AD140
        public void Reset(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1AD1C0
    }

    public class BufferedIesCipher : BufferedCipherBase
    {
        public object engine;
        public object forEncryption;
        public object buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AD270
        public void get_AlgorithmName(){} // RVA: 0xA1AD400
        public void Init(){} // RVA: 0xA1AD440
        public void GetBlockSize(){} // RVA: 0xDAC980
        public void GetOutputSize(){} // RVA: 0xA1AD490
        public void GetUpdateOutputSize(){} // RVA: 0xDAC980
        public void ProcessByte(){} // RVA: 0xA1AD530
        public void ProcessBytes(){} // RVA: 0xA1AD560
        public void DoFinal(){} // RVA: 0xA1ABD60
        public void Reset(){} // RVA: 0xA1AD770
    }

    public class BufferedStreamCipher : BufferedCipherBase
    {
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AD7A0
        public void get_AlgorithmName(){} // RVA: 0xA1AD890
        public void Init(){} // RVA: 0xA1AD8E0
        public void GetBlockSize(){} // RVA: 0xDAC980
        public void GetOutputSize(){} // RVA: 0x44E8220
        public void GetUpdateOutputSize(){} // RVA: 0x44E8220
        public void ProcessByte(){} // RVA: 0xA1ADA80
        public void ProcessBytes(){} // RVA: 0xA1ADC30
        public void DoFinal(){} // RVA: 0xA1ADD40
        public void Reset(){} // RVA: 0xA1ADE10
    }

    public class Check : Object
    {
        // ── Methods ──
        public void DataLength(){} // RVA: 0xA1ADEC0
        public void OutputLength(){} // RVA: 0xA1ADF30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CipherKeyGenerator : Object
    {
        public object random;
        public object strength;
        public object uninitialised;
        public object defaultStrength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1ADFA0
        public void get_DefaultStrength(){} // RVA: 0xFEAE90
        public void Init(){} // RVA: 0xA1AE030
        public void engineInit(){} // RVA: 0xA1AE0B0
        public void GenerateKey(){} // RVA: 0xA1AE130
        public void engineGenerateKey(){} // RVA: 0xA1AE260
    }

    public class CryptoException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AE3C0
    }

    public class DataLengthException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AE430
    }

    public class IAsymmetricBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void GetInputBlockSize(){} // RVA: 0x87C130
        public void GetOutputBlockSize(){} // RVA: 0x87C130
        public void ProcessBlock(){} // RVA: 0x87D1E0
    }

    public class IAsymmetricCipherKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void GenerateKeyPair(){} // RVA: 0x87C0A0
    }

    public class IBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void GetFieldSize(){} // RVA: 0x87C130
        public void CalculateAgreement(){} // RVA: 0x87C540
    }

    public class IBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void GetBlockSize(){} // RVA: 0x87C130
        public void get_IsPartialBlockOkay(){} // RVA: 0x87D280
        public void ProcessBlock(){} // RVA: 0x886060
        public void Reset(){} // RVA: 0x894290
    }

    public class IBlockResult
    {
        // ── Methods ──
        public void Collect(){} // RVA: 0x885970
    }

    public class IBufferedCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void GetBlockSize(){} // RVA: 0x87C130
        public void GetOutputSize(){} // RVA: 0x881C20
        public void GetUpdateOutputSize(){} // RVA: 0x881C20
        public void ProcessByte(){} // RVA: 0x883350
        public void ProcessBytes(){} // RVA: 0x885B90
        public void DoFinal(){} // RVA: 0x885B90
        public void Reset(){} // RVA: 0x894290
    }

    public class ICipher
    {
        // ── Methods ──
        public void GetMaxOutputSize(){} // RVA: 0x881C20
        public void GetUpdateOutputSize(){} // RVA: 0x881C20
        public void get_Stream(){} // RVA: 0x87C0A0
    }

    public class ICipherBuilder
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x87C0A0
        public void GetMaxOutputSize(){} // RVA: 0x881C20
        public void BuildCipher(){} // RVA: 0x87C540
    }

    public class ICipherBuilderWithKey
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x87C0A0
    }

    public class IDecryptorBuilderProvider
    {
        // ── Methods ──
        public void CreateDecryptorBuilder(){} // RVA: 0x87C540
    }

    public class IDerivationFunction
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void get_Digest(){} // RVA: 0x87C0A0
        public void GenerateBytes(){} // RVA: 0x885A60
    }

    public class IDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void GetDigestSize(){} // RVA: 0x87C130
        public void GetByteLength(){} // RVA: 0x87C130
        public void Update(){} // RVA: 0x894750
        public void BlockUpdate(){} // RVA: 0x89B9B0
        public void DoFinal(){} // RVA: 0x885970
        public void Reset(){} // RVA: 0x894290
    }

    public class IDsa
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void GenerateSignature(){} // RVA: 0x87C540
        public void VerifySignature(){} // RVA: 0x87D710
    }

    public class IDsaExt
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x87C0A0
    }

    public class IEntropySource
    {
        // ── Methods ──
        public void get_IsPredictionResistant(){} // RVA: 0x87D280
        public void GetEntropy(){} // RVA: 0x87C0A0
        public void get_EntropySize(){} // RVA: 0x87C130
    }

    public class IEntropySourceProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x87C160
    }

    public class IKeyUnwrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x87C0A0
        public void Unwrap(){} // RVA: 0x87D1E0
    }

    public class IKeyWrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x87C0A0
        public void Wrap(){} // RVA: 0x87C540
    }

    public class IMac
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void GetMacSize(){} // RVA: 0x87C130
        public void Update(){} // RVA: 0x894750
        public void BlockUpdate(){} // RVA: 0x89B9B0
        public void DoFinal(){} // RVA: 0x885970
        public void Reset(){} // RVA: 0x894290
    }

    public class IMacDerivationFunction
    {
        // ── Methods ──
        public void GetMac(){} // RVA: 0x87C0A0
    }

    public class IMacFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x87C0A0
        public void CreateCalculator(){} // RVA: 0x87C0A0
    }

    public class IRawAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void get_AgreementSize(){} // RVA: 0x87C130
        public void CalculateAgreement(){} // RVA: 0x895FE0
    }

    public class IRsa
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894DF0
        public void GetInputBlockSize(){} // RVA: 0x87C130
        public void GetOutputBlockSize(){} // RVA: 0x87C130
        public void ConvertInput(){} // RVA: 0x87D1E0
        public void ProcessBlock(){} // RVA: 0x87C540
        public void ConvertOutput(){} // RVA: 0x87C540
    }

    public class ISignatureFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x87C0A0
        public void CreateCalculator(){} // RVA: 0x87C0A0
    }

    public class ISigner
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void Update(){} // RVA: 0x894750
        public void BlockUpdate(){} // RVA: 0x89B9B0
        public void GenerateSignature(){} // RVA: 0x87C0A0
        public void VerifySignature(){} // RVA: 0x87D350
        public void Reset(){} // RVA: 0x894290
    }

    public class ISignerWithRecovery
    {
        // ── Methods ──
        public void HasFullMessage(){} // RVA: 0x87D280
        public void GetRecoveredMessage(){} // RVA: 0x87C0A0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x894320
    }

    public class IStreamCalculator
    {
        // ── Methods ──
        public void get_Stream(){} // RVA: 0x87C0A0
        public void GetResult(){} // RVA: 0x87C0A0
    }

    public class IStreamCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void ReturnByte(){} // RVA: 0x87D910
        public void ProcessBytes(){} // RVA: 0x89BCC0
        public void Reset(){} // RVA: 0x894290
    }

    public class IVerifier
    {
        // ── Methods ──
        public void IsVerified(){} // RVA: 0x87FFF0
    }

    public class IVerifierFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x87C0A0
        public void CreateCalculator(){} // RVA: 0x87C0A0
    }

    public class IVerifierFactoryProvider
    {
        // ── Methods ──
        public void CreateVerifierFactory(){} // RVA: 0x87C540
    }

    public class IWrapper
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void Wrap(){} // RVA: 0x87D1E0
        public void Unwrap(){} // RVA: 0x87D1E0
    }

    public class IXof
    {
        // ── Methods ──
        public void DoFinal(){} // RVA: 0x885A60
        public void DoOutput(){} // RVA: 0x885A60
    }

    public class InvalidCipherTextException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AE430
    }

    public class KeyGenerationParameters : Object
    {
        public object random;
        public object strength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AE440
        public void get_Random(){} // RVA: 0xB5DBF0
        public void get_Strength(){} // RVA: 0xE62D00
    }

    public class MaxBytesExceededException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AE430
    }

    public class OutputLengthException : DataLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AE430
    }

    public class PbeParametersGenerator : Object
    {
        public object mPassword;
        public object mSalt;
        public object mIterationCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA1AE560
        public void get_Password(){} // RVA: 0xA1AE7F0
        public void GetPassword(){} // RVA: 0xBFA230
        public void get_Salt(){} // RVA: 0xA1AE8A0
        public void GetSalt(){} // RVA: 0x7183E10
        public void get_IterationCount(){} // RVA: 0xFEAE90
        public void GenerateDerivedParameters(){} // RVA: 0x87D1E0
        public void GenerateDerivedMacParameters(){} // RVA: 0x87C160
        public void Pkcs5PasswordToBytes(){} // RVA: 0xA1AEAC0
        public void Pkcs5PasswordToUtf8Bytes(){} // RVA: 0xA1AEB90
        public void Pkcs12PasswordToBytes(){} // RVA: 0xA1AEC20
    }

    public class SimpleBlockResult : Object
    {
        public object result;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Length(){} // RVA: 0x17F0080
        public void Collect(){} // RVA: 0xA1AECF0
    }

    public class StreamBlockCipher : Object
    {
        public object cipher;
        public object oneByte;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1AED40
        public void Init(){} // RVA: 0xA1AEF10
        public void get_AlgorithmName(){} // RVA: 0xA1AEF90
        public void ReturnByte(){} // RVA: 0xA1AEFE0
        public void ProcessBytes(){} // RVA: 0xA1AF080
        public void Reset(){} // RVA: 0xA1AF220
    }

}