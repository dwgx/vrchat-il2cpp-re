// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
// Classes: 52
// Methods: 212

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
    public class AsymmetricCipherKeyPair : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B133F210
        public void get_Public(){} // RVA: 0x7A80F2570
        public void get_Private(){} // RVA: 0x7A80DA7B0
    }

    public class AsymmetricKeyParameter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
        public void get_IsPrivate(){} // RVA: 0x7A81A2200
        public void Equals(){} // RVA: 0x7B133F440
        public void GetHashCode(){} // RVA: 0x7B133F460
    }

    public class BufferedAeadBlockCipher : BufferedCipherBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B133F4B0
        public void get_AlgorithmName(){} // RVA: 0x7B133F5A0
        public void Init(){} // RVA: 0x7B133F5F0
        public void GetBlockSize(){} // RVA: 0x7B133F6E0
        public void GetUpdateOutputSize(){} // RVA: 0x7B133F730
        public void GetOutputSize(){} // RVA: 0x7B133F790
        public void ProcessByte(){} // RVA: 0x7B133F8E0
        public void ProcessBytes(){} // RVA: 0x7B133FB30
        public void DoFinal(){} // RVA: 0x7B133FE20
        public void Reset(){} // RVA: 0x7B133FE90
    }

    public class BufferedAsymmetricBlockCipher : BufferedCipherBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B133FEE0
        public void GetBufferPosition(){} // RVA: 0x7A851DB90
        public void get_AlgorithmName(){} // RVA: 0x7B133FF80
        public void GetBlockSize(){} // RVA: 0x7B133FFD0
        public void GetOutputSize(){} // RVA: 0x7B1340020
        public void GetUpdateOutputSize(){} // RVA: 0x7A82D1450
        public void Init(){} // RVA: 0x7B1340070
        public void ProcessByte(){} // RVA: 0x7B1340190
        public void ProcessBytes(){} // RVA: 0x7B1340230
        public void DoFinal(){} // RVA: 0x7B1340410
        public void Reset(){} // RVA: 0x7B1340450
    }

    public class BufferedBlockCipher : BufferedCipherBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13404E0
        public void get_AlgorithmName(){} // RVA: 0x7B1340680
        public void Init(){} // RVA: 0x7B13406D0
        public void GetBlockSize(){} // RVA: 0x7B13407B0
        public void GetUpdateOutputSize(){} // RVA: 0x7B1340800
        public void GetOutputSize(){} // RVA: 0x7B1340830
        public void ProcessByte(){} // RVA: 0x7B1340960
        public void ProcessBytes(){} // RVA: 0x7B1340BB0
        public void DoFinal(){} // RVA: 0x7B1341210
        public void Reset(){} // RVA: 0x7B1341430
    }

    public class BufferedCipherBase : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void GetBlockSize(){} // RVA: 0x7A7E00710
        public void GetOutputSize(){} // RVA: 0x7A7E062A0
        public void GetUpdateOutputSize(){} // RVA: 0x7A7E062A0
        public void ProcessByte(){} // RVA: 0x7B13414B0
        public void ProcessBytes(){} // RVA: 0x7B1341600
        public void DoFinal(){} // RVA: 0x7B13417F0
        public void Reset(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1341870
    }

    public class BufferedIesCipher : BufferedCipherBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1341920
        public void get_AlgorithmName(){} // RVA: 0x7B1341AB0
        public void Init(){} // RVA: 0x7B1341AF0
        public void GetBlockSize(){} // RVA: 0x7A82D1450
        public void GetOutputSize(){} // RVA: 0x7B1341B40
        public void GetUpdateOutputSize(){} // RVA: 0x7A82D1450
        public void ProcessByte(){} // RVA: 0x7B1341BE0
        public void ProcessBytes(){} // RVA: 0x7B1341C10
        public void DoFinal(){} // RVA: 0x7B1340410
        public void Reset(){} // RVA: 0x7B1341E20
    }

    public class BufferedStreamCipher : BufferedCipherBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1341E50
        public void get_AlgorithmName(){} // RVA: 0x7B1341F40
        public void Init(){} // RVA: 0x7B1341F90
        public void GetBlockSize(){} // RVA: 0x7A82D1450
        public void GetOutputSize(){} // RVA: 0x7AB93BE00
        public void GetUpdateOutputSize(){} // RVA: 0x7AB93BE00
        public void ProcessByte(){} // RVA: 0x7B1342130
        public void ProcessBytes(){} // RVA: 0x7B13422E0
        public void DoFinal(){} // RVA: 0x7B13423F0
        public void Reset(){} // RVA: 0x7B13424C0
    }

    public class Check : Object
    {
        // ── Methods ──
        public void DataLength(){} // RVA: 0x7B1342570
        public void OutputLength(){} // RVA: 0x7B13425E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CipherKeyGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342650
        public void get_DefaultStrength(){} // RVA: 0x7A851DB90
        public void Init(){} // RVA: 0x7B13426E0
        public void engineInit(){} // RVA: 0x7B1342760
        public void GenerateKey(){} // RVA: 0x7B13427E0
        public void engineGenerateKey(){} // RVA: 0x7B1342910
    }

    public class CryptoException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342A70
    }

    public class DataLengthException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342AE0
    }

    public class IAsymmetricBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void GetInputBlockSize(){} // RVA: 0x7A7E00710
        public void GetOutputBlockSize(){} // RVA: 0x7A7E00710
        public void ProcessBlock(){} // RVA: 0x7A7E017C0
    }

    public class IAsymmetricCipherKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void GenerateKeyPair(){} // RVA: 0x7A7E00680
    }

    public class IBasicAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void GetFieldSize(){} // RVA: 0x7A7E00710
        public void CalculateAgreement(){} // RVA: 0x7A7E00B20
    }

    public class IBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void GetBlockSize(){} // RVA: 0x7A7E00710
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A7E01900
        public void ProcessBlock(){} // RVA: 0x7A7E0A650
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class IBlockResult
    {
        // ── Methods ──
        public void Collect(){} // RVA: 0x7A7E09FB0
    }

    public class IBufferedCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void GetBlockSize(){} // RVA: 0x7A7E00710
        public void GetOutputSize(){} // RVA: 0x7A7E062A0
        public void GetUpdateOutputSize(){} // RVA: 0x7A7E062A0
        public void ProcessByte(){} // RVA: 0x7A7E07990
        public void ProcessBytes(){} // RVA: 0x7A7E0A1D0
        public void DoFinal(){} // RVA: 0x7A7E0A1D0
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class ICipher
    {
        // ── Methods ──
        public void GetMaxOutputSize(){} // RVA: 0x7A7E062A0
        public void GetUpdateOutputSize(){} // RVA: 0x7A7E062A0
        public void get_Stream(){} // RVA: 0x7A7E00680
    }

    public class ICipherBuilder
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7A7E00680
        public void GetMaxOutputSize(){} // RVA: 0x7A7E062A0
        public void BuildCipher(){} // RVA: 0x7A7E00B20
    }

    public class ICipherBuilderWithKey
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7A7E00680
    }

    public class IDecryptorBuilderProvider
    {
        // ── Methods ──
        public void CreateDecryptorBuilder(){} // RVA: 0x7A7E00B20
    }

    public class IDerivationFunction
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void get_Digest(){} // RVA: 0x7A7E00680
        public void GenerateBytes(){} // RVA: 0x7A7E0A0A0
    }

    public class IDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void GetDigestSize(){} // RVA: 0x7A7E00710
        public void GetByteLength(){} // RVA: 0x7A7E00710
        public void Update(){} // RVA: 0x7A7E18C30
        public void BlockUpdate(){} // RVA: 0x7A7E1E220
        public void DoFinal(){} // RVA: 0x7A7E09FB0
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class IDsa
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void GenerateSignature(){} // RVA: 0x7A7E00B20
        public void VerifySignature(){} // RVA: 0x7A7E01D90
    }

    public class IDsaExt
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x7A7E00680
    }

    public class IEntropySource
    {
        // ── Methods ──
        public void get_IsPredictionResistant(){} // RVA: 0x7A7E01900
        public void GetEntropy(){} // RVA: 0x7A7E00680
        public void get_EntropySize(){} // RVA: 0x7A7E00710
    }

    public class IEntropySourceProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7A7E00740
    }

    public class IKeyUnwrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7A7E00680
        public void Unwrap(){} // RVA: 0x7A7E017C0
    }

    public class IKeyWrapper
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7A7E00680
        public void Wrap(){} // RVA: 0x7A7E00B20
    }

    public class IMac
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void GetMacSize(){} // RVA: 0x7A7E00710
        public void Update(){} // RVA: 0x7A7E18C30
        public void BlockUpdate(){} // RVA: 0x7A7E1E220
        public void DoFinal(){} // RVA: 0x7A7E09FB0
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class IMacDerivationFunction
    {
        // ── Methods ──
        public void GetMac(){} // RVA: 0x7A7E00680
    }

    public class IMacFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7A7E00680
        public void CreateCalculator(){} // RVA: 0x7A7E00680
    }

    public class IRawAgreement
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void get_AgreementSize(){} // RVA: 0x7A7E00710
        public void CalculateAgreement(){} // RVA: 0x7A7E1A470
    }

    public class IRsa
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E19310
        public void GetInputBlockSize(){} // RVA: 0x7A7E00710
        public void GetOutputBlockSize(){} // RVA: 0x7A7E00710
        public void ConvertInput(){} // RVA: 0x7A7E017C0
        public void ProcessBlock(){} // RVA: 0x7A7E00B20
        public void ConvertOutput(){} // RVA: 0x7A7E00B20
    }

    public class ISignatureFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7A7E00680
        public void CreateCalculator(){} // RVA: 0x7A7E00680
    }

    public class ISigner
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void Update(){} // RVA: 0x7A7E18C30
        public void BlockUpdate(){} // RVA: 0x7A7E1E220
        public void GenerateSignature(){} // RVA: 0x7A7E00680
        public void VerifySignature(){} // RVA: 0x7A7E019D0
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class ISignerWithRecovery
    {
        // ── Methods ──
        public void HasFullMessage(){} // RVA: 0x7A7E01900
        public void GetRecoveredMessage(){} // RVA: 0x7A7E00680
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7A7E18800
    }

    public class IStreamCalculator
    {
        // ── Methods ──
        public void get_Stream(){} // RVA: 0x7A7E00680
        public void GetResult(){} // RVA: 0x7A7E00680
    }

    public class IStreamCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void ReturnByte(){} // RVA: 0x7A7E02010
        public void ProcessBytes(){} // RVA: 0x7A7E20000
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class IVerifier
    {
        // ── Methods ──
        public void IsVerified(){} // RVA: 0x7A7E046D0
    }

    public class IVerifierFactory
    {
        // ── Methods ──
        public void get_AlgorithmDetails(){} // RVA: 0x7A7E00680
        public void CreateCalculator(){} // RVA: 0x7A7E00680
    }

    public class IVerifierFactoryProvider
    {
        // ── Methods ──
        public void CreateVerifierFactory(){} // RVA: 0x7A7E00B20
    }

    public class IWrapper
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void Wrap(){} // RVA: 0x7A7E017C0
        public void Unwrap(){} // RVA: 0x7A7E017C0
    }

    public class IXof
    {
        // ── Methods ──
        public void DoFinal(){} // RVA: 0x7A7E0A0A0
        public void DoOutput(){} // RVA: 0x7A7E0A0A0
    }

    public class InvalidCipherTextException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342AE0
    }

    public class KeyGenerationParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342AF0
        public void get_Random(){} // RVA: 0x7A80F2570
        public void get_Strength(){} // RVA: 0x7A83782A0
    }

    public class MaxBytesExceededException : CryptoException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342AE0
    }

    public class OutputLengthException : DataLengthException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1342AE0
    }

    public class PbeParametersGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B1342C10
        public void get_Password(){} // RVA: 0x7B1342EA0
        public void GetPassword(){} // RVA: 0x7A818C720
        public void get_Salt(){} // RVA: 0x7B1342F50
        public void GetSalt(){} // RVA: 0x7AE50A3E0
        public void get_IterationCount(){} // RVA: 0x7A851DB90
        public void GenerateDerivedParameters(){} // RVA: 0x7A7E017C0
        public void GenerateDerivedMacParameters(){} // RVA: 0x7A7E00740
        public void Pkcs5PasswordToBytes(){} // RVA: 0x7B1343170
        public void Pkcs5PasswordToUtf8Bytes(){} // RVA: 0x7B1343240
        public void Pkcs12PasswordToBytes(){} // RVA: 0x7B13432D0
    }

    public class SimpleBlockResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Length(){} // RVA: 0x7A8D0A110
        public void Collect(){} // RVA: 0x7B13433A0
    }

    public class StreamBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13433F0
        public void Init(){} // RVA: 0x7B13435C0
        public void get_AlgorithmName(){} // RVA: 0x7B1343640
        public void ReturnByte(){} // RVA: 0x7B1343690
        public void ProcessBytes(){} // RVA: 0x7B1343730
        public void Reset(){} // RVA: 0x7B13438D0
    }

}