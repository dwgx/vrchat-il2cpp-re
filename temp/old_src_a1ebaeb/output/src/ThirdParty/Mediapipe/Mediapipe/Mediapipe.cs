// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 77
// Methods: 713

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class BadStatusException : Exception
    {
        // ── Original Methods ──
        public void set_statusCode(){} // RVA: 0x7ffaa8efe560
        public void .ctor(){} // RVA: 0x7ffaadc8b920
    }

    public class CalculatorGraph : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8d760
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc8d8a0
        public void Initialize(){} // RVA: 0x7ffaadc8d960
        public void ObserveOutputStream(){} // RVA: 0x7ffaadc8daa0
        public void AddOutputStreamPoller(){} // RVA: 0x7ffaa8659a30
        public void StartRun(){} // RVA: 0x7ffaadc8dc20
        public void WaitUntilDone(){} // RVA: 0x7ffaadc8dd50
        public void AddPacketToInputStream(){} // RVA: 0x7ffaa8669e70
        public void CloseAllPacketSources(){} // RVA: 0x7ffaadc8de60
        // ── Binary Analysis Named ──
        public void SetGpuResources(){} // RVA: 0x7ffaadc8df70
    }

    public class CalculatorGraphConfigExtension : Object
    {
        // ── Original Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x7ffaadc8e180
    }

    public class CalculatorOptions : Object
    {
        public object _extensions; // 0x316F7910
        public object mergeFields_; // 0x316F7910
        public object _Extensions; // 0x170000FE
        public object Parser; // 0x170000FF

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadcbafd0
        public void get_Descriptor(){} // RVA: 0x7ffaadcbb030
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcbb0f0
        public void .ctor(){} // RVA: 0x7ffaadcbb1e0
        public void .ctor(){} // RVA: 0x7ffaadcbb1e0
        public void Clone(){} // RVA: 0x7ffaadcbb370
        public void get_MergeFields(){} // RVA: 0x7ffaadcbb530
        public void set_MergeFields(){} // RVA: 0x7ffaadc25fe0
        public void get_HasMergeFields(){} // RVA: 0x7ffaadc224f0
        public void ClearMergeFields(){} // RVA: 0x7ffaadc22500
        public void Equals(){} // RVA: 0x7ffaadcbb6b0
        public void Equals(){} // RVA: 0x7ffaadcbb6b0
        public void ToString(){} // RVA: 0x7ffaadcbb840
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcbb890
        public void CalculateSize(){} // RVA: 0x7ffaadcbb930
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcbbae0
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadcbbbb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcbb780
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class CalculatorReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadcaabe0
        public void .cctor(){} // RVA: 0x7ffaadcaac40
    }

    public class Classification : Object
    {
        public object _hasBits0; // 0x33C9EFE0
        public object index_; // 0x33C9EFE0
        public object score_; // 0x33C9EFE0
        public object label_; // 0x33C9EFE0
        public object displayName_; // 0x33C9EFE0
        public object Parser; // 0x17000113
        public object Descriptor; // 0x17000114
        public object pb::Google.Protobuf.IMessage.Descriptor; // 0x17000115
        public object Index; // 0x17000116
        public object HasIndex; // 0x17000117

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcbebb0
        public void get_Descriptor(){} // RVA: 0x7ffaadcbec10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcbecd0
        public void .ctor(){} // RVA: 0x7ffaadcbedc0
        public void .ctor(){} // RVA: 0x7ffaadcbedc0
        public void Clone(){} // RVA: 0x7ffaadcbef70
        public void get_Index(){} // RVA: 0x7ffaadcbf150
        public void set_Index(){} // RVA: 0x7ffaadc14910
        public void get_HasIndex(){} // RVA: 0x7ffaadc14920
        public void ClearIndex(){} // RVA: 0x7ffaadc14930
        public void get_Score(){} // RVA: 0x7ffaadcbf1c0
        public void set_Score(){} // RVA: 0x7ffaadcbf230
        public void get_HasScore(){} // RVA: 0x7ffaadc149c0
        public void ClearScore(){} // RVA: 0x7ffaadc149d0
        public void get_Label(){} // RVA: 0x7ffaadcbf240
        public void set_Label(){} // RVA: 0x7ffaadcbf2b0
        public void get_HasLabel(){} // RVA: 0x7ffaadc20540
        public void ClearLabel(){} // RVA: 0x7ffaaadf67e0
        public void get_DisplayName(){} // RVA: 0x7ffaadcbf3b0
        public void set_DisplayName(){} // RVA: 0x7ffaadcbf420
        public void get_HasDisplayName(){} // RVA: 0x7ffaad26b400
        public void ClearDisplayName(){} // RVA: 0x7ffaadc206c0
        public void Equals(){} // RVA: 0x7ffaadcbf580
        public void Equals(){} // RVA: 0x7ffaadcbf580
        public void ToString(){} // RVA: 0x7ffaadcbf880
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcbf8d0
        public void CalculateSize(){} // RVA: 0x7ffaadcbf9b0
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcbfc10
        public void .cctor(){} // RVA: 0x7ffaadcbfd40
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcbf740
    }

    public class Detection : Object
    {
        public object _hasBits0; // 0x338F6F00
        public object label_; // 0x338F6F00
        public object labelId_; // 0x338F6F00
        public object score_; // 0x338F6F00
        public object FeatureTagFieldNumber; // 0x338F6F00
        public object TrackIdFieldNumber; // 0x338F6F00
        public object DetectionIdFieldNumber; // 0x338F6F00
        public object AssociatedDetectionsFieldNumber; // 0x338F6F00
        public object DisplayNameFieldNumber; // 0x338F6F00
        public object TimestampUsecFieldNumber; // 0x338F6F00

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcc2b20
        public void get_Descriptor(){} // RVA: 0x7ffaadcc2b80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcc2c40
        public void .ctor(){} // RVA: 0x7ffaadcc2f90
        public void .ctor(){} // RVA: 0x7ffaadcc2f90
        public void Clone(){} // RVA: 0x7ffaadcc3460
        public void get_Label(){} // RVA: 0x7ffaa89600c0
        public void get_LabelId(){} // RVA: 0x7ffaa8960130
        public void get_Score(){} // RVA: 0x7ffaa8bfcc80
        public void get_LocationData(){} // RVA: 0x7ffaa8bf45b0
        public void set_LocationData(){} // RVA: 0x7ffaa8bf45c0
        public void get_FeatureTag(){} // RVA: 0x7ffaadcc34c0
        public void set_FeatureTag(){} // RVA: 0x7ffaadcc3530
        public void get_HasFeatureTag(){} // RVA: 0x7ffaad26b4b0
        public void ClearFeatureTag(){} // RVA: 0x7ffaadc17ec0
        public void get_TrackId(){} // RVA: 0x7ffaadcc3630
        public void set_TrackId(){} // RVA: 0x7ffaadcc36a0
        public void get_HasTrackId(){} // RVA: 0x7ffaadc18090
        public void ClearTrackId(){} // RVA: 0x7ffaadc180a0
        public void get_DetectionId(){} // RVA: 0x7ffaadcc37a0
        public void set_DetectionId(){} // RVA: 0x7ffaadcc3810
        public void get_HasDetectionId(){} // RVA: 0x7ffaadc14920
        public void ClearDetectionId(){} // RVA: 0x7ffaadc14930
        public void get_AssociatedDetections(){} // RVA: 0x7ffaa89fa500
        public void get_DisplayName(){} // RVA: 0x7ffaa89d0370
        public void get_TimestampUsec(){} // RVA: 0x7ffaadcc3820
        public void set_TimestampUsec(){} // RVA: 0x7ffaadcc3890
        public void get_HasTimestampUsec(){} // RVA: 0x7ffaadc149c0
        public void ClearTimestampUsec(){} // RVA: 0x7ffaadc149d0
        public void Equals(){} // RVA: 0x7ffaadcc3900
        public void Equals(){} // RVA: 0x7ffaadcc3900
        public void ToString(){} // RVA: 0x7ffaadcc3d80
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcc3dd0
        public void CalculateSize(){} // RVA: 0x7ffaadcc4060
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcc4700
        public void .cctor(){} // RVA: 0x7ffaadcc4ac0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcc3bc0
    }

    public class DisposableObject : Object
    {
        public object _isDisposed; // 0x312616A0, was: <isDisposed>k__BackingField
        public object DefaultAlignmentBoundary; // 0x337E6D80

        // ── Original Methods ──
        public void get_isDisposed(){} // RVA: 0x7ffaa8b603b0
        public void set_isDisposed(){} // RVA: 0x7ffaa9e38f90
        public void get_isOwner(){} // RVA: 0x7ffaa9e39000
        public void set_isOwner(){} // RVA: 0x7ffaa9e38ff0
        public void .ctor(){} // RVA: 0x7ffaadc8b9a0
        public void Dispose(){} // RVA: 0x7ffaadc8ba20
        public void Dispose(){} // RVA: 0x7ffaadc8ba20
        public void Finalize(){} // RVA: 0x7ffaadc64ff0
        public void DisposeManaged(){} // RVA: 0x7ffaa8932310
        public void DisposeUnmanaged(){} // RVA: 0x7ffaa8932310
        public void Lock(){} // RVA: 0x7ffaa96d0080
        public void Unlock(){} // RVA: 0x7ffaa96d0510
        public void TransferOwnership(){} // RVA: 0x7ffaadc8bad0
        public void ThrowIfDisposed(){} // RVA: 0x7ffaadc8bae0
    }

    public class FaceDetectionReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadce79e0
        public void .cctor(){} // RVA: 0x7ffaadce7a40
    }

    public class FlowLimiterCalculatorReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadc989d0
        public void .cctor(){} // RVA: 0x7ffaadc98a30
    }

    public class GlCalculatorHelper : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc93140
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc93280
        public void InitializeForTest(){} // RVA: 0x7ffaadc93340
        // ── Binary Analysis Named ──
        public void GetGlContext(){} // RVA: 0x7ffaadc93460
    }

    public class GlContext : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc93660
        public void DisposeManaged(){} // RVA: 0x7ffaadc937b0
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8932310
    }

    public class GlSyncPoint : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc93970
        public void DisposeManaged(){} // RVA: 0x7ffaadc937b0
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8932310
        public void Wait(){} // RVA: 0x7ffaadc93aa0
    }

    public class GlTextureBuffer : MpResourceHandle
    {
        // ── Original Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8932310
    }

    public class GlobalInstanceTable`2 : Object
    {
        public object _maxSize; // 0x30B597B0

        // ── Original Methods ──
        public void get_maxSize(){} // RVA: 0x7ffaa8649ca0
        public void set_maxSize(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void ClearUnusedKeys(){} // RVA: 0x7ffaa8660cc0
    }

    public class GlobalInstanceTable`2 : Object
    {
        public object _maxSize; // 0x35D12668
    }

    public class GlobalInstanceTable`2 : Object
    {
        public object _maxSize; // 0x35D18B08
    }

    public class Glog : Object
    {
        public object _Minloglevel; // 0x338EC980

        // ── Original Methods ──
        public void set_Logtostderr(){} // RVA: 0x7ffaadc8c5a0
        public void get_Stderrthreshold(){} // RVA: 0x7ffaadc8c6a0
        public void set_Stderrthreshold(){} // RVA: 0x7ffaadc8c700
        public void get_Minloglevel(){} // RVA: 0x7ffaadc8c800
        public void set_Minloglevel(){} // RVA: 0x7ffaadc8c860
        public void get_V(){} // RVA: 0x7ffaadc8c960
        public void set_V(){} // RVA: 0x7ffaadc8c9c0
        public void Initialize(){} // RVA: 0x7ffaadc8cac0
        public void Shutdown(){} // RVA: 0x7ffaadc8cba0
        public void .cctor(){} // RVA: 0x7ffaadc8cc40
    }

    public class GpuBuffer : MpResourceHandle
    {
        // ── Original Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc93cb0
    }

    public class GpuOrigin : Object
    {
        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadce7380
        public void get_Descriptor(){} // RVA: 0x7ffaadce73e0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadce74a0
        public void .ctor(){} // RVA: 0x7ffaadbf50c0
        public void .ctor(){} // RVA: 0x7ffaadbf50c0
        public void Clone(){} // RVA: 0x7ffaadce7590
        public void Equals(){} // RVA: 0x7ffaadbf5350
        public void Equals(){} // RVA: 0x7ffaadbf5350
        public void ToString(){} // RVA: 0x7ffaadce7740
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadbf5420
        public void CalculateSize(){} // RVA: 0x7ffaadbf5440
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadbf5540
        public void .cctor(){} // RVA: 0x7ffaadce7790
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadbf5390
    }

    public class GpuResources : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc93d70
        public void DisposeManaged(){} // RVA: 0x7ffaadc937b0
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8932310
        public void get_sharedPtr(){} // RVA: 0x7ffaadc93ea0
        public void Create(){} // RVA: 0x7ffaadc93ec0
    }

    public class Image : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8e8f0
        public void .ctor(){} // RVA: 0x7ffaadc8e8f0
        public void .ctor(){} // RVA: 0x7ffaadc8e8f0
        public void .ctor(){} // RVA: 0x7ffaadc8e8f0
        public void .ctor(){} // RVA: 0x7ffaadc8e8f0
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc8ebb0
        public void Width(){} // RVA: 0x7ffaadc8ec70
        public void Height(){} // RVA: 0x7ffaadc8ed30
        public void Step(){} // RVA: 0x7ffaadc8edf0
        public void ImageFormat(){} // RVA: 0x7ffaadc8eeb0
        public void .cctor(){} // RVA: 0x7ffaadc8ef70
    }

    public class ImageArray : ValueType
    {
        // ── Original Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7ffaadc94220
    }

    public class ImageFormat : Object
    {
        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcc74f0
        public void get_Descriptor(){} // RVA: 0x7ffaadcc7550
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcc7610
        public void .ctor(){} // RVA: 0x7ffaadbf50c0
        public void .ctor(){} // RVA: 0x7ffaadbf50c0
        public void Clone(){} // RVA: 0x7ffaadcc7700
        public void Equals(){} // RVA: 0x7ffaadbf5350
        public void Equals(){} // RVA: 0x7ffaadbf5350
        public void ToString(){} // RVA: 0x7ffaadcc78b0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadbf5420
        public void CalculateSize(){} // RVA: 0x7ffaadbf5440
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadbf5540
        public void .cctor(){} // RVA: 0x7ffaadcc7900
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadbf5390
    }

    public class ImageFormatExtension : Object
    {
        // ── Original Methods ──
        public void NumberOfChannels(){} // RVA: 0x7ffaadc8c190
        public void ByteDepth(){} // RVA: 0x7ffaadc8c200
    }

    public class ImageFrame : MpResourceHandle
    {
        public object _VoidDeleter; // 0x337E6D80
        public object TrySetResult; // 0xB41EFD10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8f660
        public void .ctor(){} // RVA: 0x7ffaadc8f660
        public void .ctor(){} // RVA: 0x7ffaadc8f660
        public void .ctor(){} // RVA: 0x7ffaadc8f660
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc8f880
        public void VoidDeleter(){} // RVA: 0x7ffaa8932310
        public void Format(){} // RVA: 0x7ffaadc8f940
        public void Width(){} // RVA: 0x7ffaadc8f9c0
        public void Height(){} // RVA: 0x7ffaadc8fa40
        public void ByteDepth(){} // RVA: 0x7ffaadc8fac0
        public void WidthStep(){} // RVA: 0x7ffaadc8fae0
        public void MutablePixelData(){} // RVA: 0x7ffaadc8fb60
        public void PixelDataSize(){} // RVA: 0x7ffaadc8fbe0
        public void .cctor(){} // RVA: 0x7ffaadc8fc10
    }

    public class InferenceCalculatorReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadc9a250
        public void .cctor(){} // RVA: 0x7ffaadc9a2b0
    }

    public class InternalException : Exception
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8bb70
    }

    public class Landmark : Object
    {
        public object _hasBits0; // 0x33874630
        public object x_; // 0x33874630
        public object y_; // 0x33874630
        public object z_; // 0x33874630
        public object visibility_; // 0x33874630
        public object presence_; // 0x33874630
        public object Parser; // 0x17000148
        public object Descriptor; // 0x17000149
        public object pb::Google.Protobuf.IMessage.Descriptor; // 0x1700014A
        public object X; // 0x1700014B
        public object HasX; // 0x1700014C
        public object Y; // 0x1700014D

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcc8980
        public void get_Descriptor(){} // RVA: 0x7ffaadcc89e0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcc8aa0
        public void .ctor(){} // RVA: 0x7ffaadcc8b90
        public void .ctor(){} // RVA: 0x7ffaadcc8b90
        public void Clone(){} // RVA: 0x7ffaadcc8c90
        public void get_X(){} // RVA: 0x7ffaadcc8dc0
        public void set_X(){} // RVA: 0x7ffaadcc8e30
        public void get_HasX(){} // RVA: 0x7ffaadc14920
        public void ClearX(){} // RVA: 0x7ffaadc14930
        public void get_Y(){} // RVA: 0x7ffaadcc8e40
        public void set_Y(){} // RVA: 0x7ffaadcbf230
        public void get_HasY(){} // RVA: 0x7ffaadc149c0
        public void ClearY(){} // RVA: 0x7ffaadc149d0
        public void get_Z(){} // RVA: 0x7ffaadcc8eb0
        public void set_Z(){} // RVA: 0x7ffaadcc8f20
        public void get_HasZ(){} // RVA: 0x7ffaadc17bc0
        public void ClearZ(){} // RVA: 0x7ffaadc17bd0
        public void get_Visibility(){} // RVA: 0x7ffaadcc8f30
        public void set_Visibility(){} // RVA: 0x7ffaadcc8fa0
        public void get_HasVisibility(){} // RVA: 0x7ffaadc18180
        public void ClearVisibility(){} // RVA: 0x7ffaadc18190
        public void get_Presence(){} // RVA: 0x7ffaadcc8fb0
        public void set_Presence(){} // RVA: 0x7ffaadcc9020
        public void get_HasPresence(){} // RVA: 0x7ffaadc183f0
        public void ClearPresence(){} // RVA: 0x7ffaadc18400
        public void Equals(){} // RVA: 0x7ffaadcc9090
        public void Equals(){} // RVA: 0x7ffaadcc9090
        public void ToString(){} // RVA: 0x7ffaadcc9520
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcc9570
        public void CalculateSize(){} // RVA: 0x7ffaadcc9680
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcc9850
        public void .cctor(){} // RVA: 0x7ffaadcc9970
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcc9310
    }

    public class ListExtension : Object
    {
        // ── Original Methods ──
        public void ResizeTo(){} // RVA: 0x7ffaa86666b0
    }

    public class LocationData : Object
    {
        public object _hasBits0; // 0x3353AD20
        public object format_; // 0x3353AD20
        public object RelativeBoundingBoxFieldNumber; // 0x3353AD20
        public object mask_; // 0x3353AD20
        public object relativeKeypoints_; // 0x3353AD20
        public object Parser; // 0x17000173
        public object Descriptor; // 0x17000174
        public object pb::Google.Protobuf.IMessage.Descriptor; // 0x17000175
        public object Format; // 0x17000176
        public object HasFormat; // 0x17000177

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadccfa70
        public void get_Descriptor(){} // RVA: 0x7ffaadccfad0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadccfb90
        public void .ctor(){} // RVA: 0x7ffaadccfca0
        public void .ctor(){} // RVA: 0x7ffaadccfca0
        public void Clone(){} // RVA: 0x7ffaadcd02d0
        public void get_Format(){} // RVA: 0x7ffaadcd0330
        public void set_Format(){} // RVA: 0x7ffaadc14910
        public void get_HasFormat(){} // RVA: 0x7ffaadc14920
        public void ClearFormat(){} // RVA: 0x7ffaadc14930
        public void get_BoundingBox(){} // RVA: 0x7ffaa89600c0
        public void set_BoundingBox(){} // RVA: 0x7ffaa89600d0
        public void get_RelativeBoundingBox(){} // RVA: 0x7ffaa8960130
        public void set_RelativeBoundingBox(){} // RVA: 0x7ffaa8933e90
        public void get_Mask(){} // RVA: 0x7ffaa8bfcc80
        public void set_Mask(){} // RVA: 0x7ffaa8960890
        public void get_RelativeKeypoints(){} // RVA: 0x7ffaa8bf45b0
        public void Equals(){} // RVA: 0x7ffaadcd0400
        public void Equals(){} // RVA: 0x7ffaadcd0400
        public void ToString(){} // RVA: 0x7ffaadcd0660
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcd06b0
        public void CalculateSize(){} // RVA: 0x7ffaadcd0800
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcd0f70
        public void .cctor(){} // RVA: 0x7ffaadcd1170
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcd0580
    }

    public class MatrixData : Object
    {
        public object _hasBits0; // 0x339578E0
        public object ColsDefaultValue; // 0x339578E0
        public object packedData_; // 0x339578E0

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcd5db0
        public void get_Descriptor(){} // RVA: 0x7ffaadcd5e10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcd5ed0
        public void .ctor(){} // RVA: 0x7ffaadcd6080
        public void .ctor(){} // RVA: 0x7ffaadcd6080
        public void Clone(){} // RVA: 0x7ffaadcd6230
        public void get_Rows(){} // RVA: 0x7ffaadcd6410
        public void set_Rows(){} // RVA: 0x7ffaadc14910
        public void get_HasRows(){} // RVA: 0x7ffaadc14920
        public void ClearRows(){} // RVA: 0x7ffaadc14930
        public void get_Cols(){} // RVA: 0x7ffaadcd6480
        public void set_Cols(){} // RVA: 0x7ffaadc149b0
        public void get_HasCols(){} // RVA: 0x7ffaadc149c0
        public void ClearCols(){} // RVA: 0x7ffaadc149d0
        public void get_PackedData(){} // RVA: 0x7ffaa8960130
        public void get_Layout(){} // RVA: 0x7ffaadcd64f0
        public void set_Layout(){} // RVA: 0x7ffaadc17bb0
        public void get_HasLayout(){} // RVA: 0x7ffaadc17bc0
        public void ClearLayout(){} // RVA: 0x7ffaadc17bd0
        public void Equals(){} // RVA: 0x7ffaadcd66c0
        public void Equals(){} // RVA: 0x7ffaadcd66c0
        public void ToString(){} // RVA: 0x7ffaadcd6890
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcd68e0
        public void CalculateSize(){} // RVA: 0x7ffaadcd6a10
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcd6d30
        public void .cctor(){} // RVA: 0x7ffaadcd6ea0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcd67f0
    }

    public class MediaPipeException : Exception
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8bbd0
    }

    public class MediaPipeOptions : Object
    {
        public object _extensions; // 0x3180BA90
        public object _Extensions; // 0x170001D0

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadcda460
        public void get_Descriptor(){} // RVA: 0x7ffaadcda4c0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcda580
        public void .ctor(){} // RVA: 0x7ffaadcda670
        public void .ctor(){} // RVA: 0x7ffaadcda670
        public void Clone(){} // RVA: 0x7ffaadcda7f0
        public void Equals(){} // RVA: 0x7ffaadcdaa90
        public void Equals(){} // RVA: 0x7ffaadcdaa90
        public void ToString(){} // RVA: 0x7ffaadcdaba0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcdabf0
        public void CalculateSize(){} // RVA: 0x7ffaadcdac60
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcdae00
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadcdaeb0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcdab30
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class MediaPipePluginException : Exception
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8bc30
    }

    public class MediapipeOptionsReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadcd9fd0
        public void .cctor(){} // RVA: 0x7ffaadcda030
    }

    public class MpResourceHandle : DisposableObject
    {
        // ── Original Methods ──
        public void get_ptr(){} // RVA: 0x7ffaa89357c0
        public void set_ptr(){} // RVA: 0x7ffaadc8bc90
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void get_mpPtr(){} // RVA: 0x7ffaadc8bd20
        public void ReleaseMpResource(){} // RVA: 0x7ffaadc8bdb0
        public void OwnsResource(){} // RVA: 0x7ffaadc8be00
        public void DisposeUnmanaged(){} // RVA: 0x7ffaadc8be20
        public void ReleaseMpPtr(){} // RVA: 0x7ffaadc8be70
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8660cc0
        public void MarshalStringFromNative(){} // RVA: 0x7ffaadc8bfb0
        public void MarshalStringFromNative(){} // RVA: 0x7ffaadc8bfb0
        public void AssertStatusOk(){} // RVA: 0x7ffaadc8c060
        public void IsResourcePresent(){} // RVA: 0x7ffaadc8c180
    }

    public class MpReturnCodeExtension : Object
    {
        // ── Original Methods ──
        public void Assert(){} // RVA: 0x7ffaadc94c10
    }

    public class NativeCategory : ValueType
    {
        public object _categoryName; // 0x33C662F0

        // ── Original Methods ──
        public void get_categoryName(){} // RVA: 0x7ffaadc94280
        public void get_displayName(){} // RVA: 0x7ffaadc942f0
    }

    public class NativeClassificationResult : ValueType
    {
        public object timestampMs; // 0x33A1E6C0

        // ── Original Methods ──
        public void get_classifications(){} // RVA: 0x7ffaadc94430
        public void Dispose(){} // RVA: 0x7ffaadc94490
    }

    public class NativeDetectionResult : ValueType
    {
        // ── Original Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7ffaadc94670
        public void Dispose(){} // RVA: 0x7ffaadc946d0
    }

    public class NativeLandmark : ValueType
    {
        public object z; // 0x3399F0B0
        public object hasPresence; // 0x3399F0B0

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaadc94810
    }

    public class NativeNormalizedKeypoint : ValueType
    {
        public object _label; // 0x3381CE30

        // ── Original Methods ──
        public void get_label(){} // RVA: 0x7ffaadc947a0
    }

    public class NativeRect : ValueType
    {
        public object bottom; // 0x338D61D0
    }

    public class OutputStreamPoller`1 : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660f30
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8660cc0
        public void Next(){} // RVA: 0x7ffaa864a2a0
    }

    public class OutputStreamPoller`1 : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f2690
        public void DeleteMpPtr(){} // RVA: 0x7ffaac0f26a0
        public void Next(){} // RVA: 0x7ffaac0f2700
    }

    public class OutputStreamPoller`1 : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f2690
        public void DeleteMpPtr(){} // RVA: 0x7ffaac0f26a0
        public void Next(){} // RVA: 0x7ffaac0f2700
    }

    public class Packet : Object
    {
        // ── Original Methods ──
        public void CreateBool(){} // RVA: 0x7ffaadc8fd20
        public void CreateGpuBuffer(){} // RVA: 0x7ffaadc8fe30
        public void CreateGpuBufferAt(){} // RVA: 0x7ffaadc8ff70
        public void CreateImage(){} // RVA: 0x7ffaadc900c0
        public void CreateImageAt(){} // RVA: 0x7ffaadc90200
        public void CreateImageFrameAt(){} // RVA: 0x7ffaadc90350
        public void CreateInt(){} // RVA: 0x7ffaadc904a0
        public void CreateProto(){} // RVA: 0x7ffaa887e5c0
        public void CreateProtoAt(){} // RVA: 0x7ffaa887e5c0
    }

    public class PacketFactoryOptions : Object
    {
        public object _extensions; // 0x318591B0
        public object _Extensions; // 0x170001D5

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadcdba00
        public void get_Descriptor(){} // RVA: 0x7ffaadcdba60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcdbb20
        public void .ctor(){} // RVA: 0x7ffaadcdbc10
        public void .ctor(){} // RVA: 0x7ffaadcdbc10
        public void Clone(){} // RVA: 0x7ffaadcdbd90
        public void Equals(){} // RVA: 0x7ffaadcdaa90
        public void Equals(){} // RVA: 0x7ffaadcdaa90
        public void ToString(){} // RVA: 0x7ffaadcdc030
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcdc080
        public void CalculateSize(){} // RVA: 0x7ffaadcdc0f0
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcdc290
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadcdc340
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcdab30
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class PacketFactoryReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadcdb100
        public void .cctor(){} // RVA: 0x7ffaadcdb160
    }

    public class PacketGeneratorOptions : Object
    {
        public object _extensions; // 0x31859430
        public object mergeFields_; // 0x31859430
        public object _Extensions; // 0x170001E8
        public object Parser; // 0x170001E9

        // ── Original Methods ──
        public void get__Extensions(){} // RVA: 0x7ffaa89357c0
        public void get_Parser(){} // RVA: 0x7ffaadcdf590
        public void get_Descriptor(){} // RVA: 0x7ffaadcdf5f0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcdf6b0
        public void .ctor(){} // RVA: 0x7ffaadcdf7a0
        public void .ctor(){} // RVA: 0x7ffaadcdf7a0
        public void Clone(){} // RVA: 0x7ffaadcdf930
        public void get_MergeFields(){} // RVA: 0x7ffaadcdfaf0
        public void set_MergeFields(){} // RVA: 0x7ffaadc25fe0
        public void get_HasMergeFields(){} // RVA: 0x7ffaadc224f0
        public void ClearMergeFields(){} // RVA: 0x7ffaadc22500
        public void Equals(){} // RVA: 0x7ffaadcdfc70
        public void Equals(){} // RVA: 0x7ffaadcdfc70
        public void ToString(){} // RVA: 0x7ffaadcdfe00
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcdfe50
        public void CalculateSize(){} // RVA: 0x7ffaadcdfef0
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadce00a0
        public void HasExtension(){} // RVA: 0x7ffaa864a2a0
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void ClearExtension(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaadce0170
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcdfd40
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetExtension(){} // RVA: 0x7ffaa8649280
        public void GetOrInitializeExtension(){} // RVA: 0x7ffaa8649280
        public void SetExtension(){} // RVA: 0x7ffaa887e5c0
    }

    public class PacketGeneratorReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadcded70
        public void .cctor(){} // RVA: 0x7ffaadcdedd0
    }

    public class PacketGetterExtension : Object
    {
        // ── Original Methods ──
        public void WriteTo(){} // RVA: 0x7ffaa86520c0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa8666530
        public void Get(){} // RVA: 0x7ffaa8666530
        public void Get(){} // RVA: 0x7ffaa8666530
        public void Get(){} // RVA: 0x7ffaa8666530
        public void Get(){} // RVA: 0x7ffaa8666530
        public void Get(){} // RVA: 0x7ffaa8666530
    }

    public class PacketMap : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc906e0
        public void At(){} // RVA: 0x7ffaa8649280
        public void Emplace(){} // RVA: 0x7ffaa8669e70
    }

    public class Packet`1 : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void DeleteMpPtr(){} // RVA: 0x7ffaa8660cc0
        public void TimestampMicroseconds(){} // RVA: 0x7ffaa86491d0
        public void IsEmpty(){} // RVA: 0x7ffaa864a040
        public void SwitchNativePtr(){} // RVA: 0x7ffaa8660f30
        public void CreateForReference(){} // RVA: 0x7ffaa8658210
    }

    public class Packet`1 : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void DeleteMpPtr(){} // RVA: 0x7ffaac0f72f0
        public void TimestampMicroseconds(){} // RVA: 0x7ffaac0f7350
        public void IsEmpty(){} // RVA: 0x7ffaac0f6c70
        public void SwitchNativePtr(){} // RVA: 0x7ffaac0f6ca0
        public void CreateForReference(){} // RVA: 0x7ffaac0f6d10
    }

    public class Packet`1 : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void DeleteMpPtr(){} // RVA: 0x7ffaac0f72f0
        public void TimestampMicroseconds(){} // RVA: 0x7ffaac0f7350
        public void IsEmpty(){} // RVA: 0x7ffaac0f6c70
        public void SwitchNativePtr(){} // RVA: 0x7ffaac0f6ca0
        public void CreateForReference(){} // RVA: 0x7ffaac0f6d10
    }

    public class ProtoMessageClearExtension : Object
    {
        // ── Original Methods ──
        public void Clear(){} // RVA: 0x7ffaadc8c460
        public void Clear(){} // RVA: 0x7ffaadc8c460
        public void Clear(){} // RVA: 0x7ffaadc8c460
    }

    public class Protobuf : Object
    {
        // ── Original Methods ──
        public void ResetLogHandler(){} // RVA: 0x7ffaadc8cd90
        public void LogProtobufMessage(){} // RVA: 0x7ffaadc8ce30
        public void .cctor(){} // RVA: 0x7ffaadc8d090
        // ── Binary Analysis Named ──
        public void SetLogHandler(){} // RVA: 0x7ffaadc8ccc0
    }

    public class Rasterization : Object
    {
        public object IntervalFieldNumber; // 0x33AA4DE0

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcbc580
        public void get_Descriptor(){} // RVA: 0x7ffaadcbc5e0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcbc6a0
        public void .ctor(){} // RVA: 0x7ffaadcbc7b0
        public void .ctor(){} // RVA: 0x7ffaadcbc7b0
        public void Clone(){} // RVA: 0x7ffaadcbc950
        public void get_Interval(){} // RVA: 0x7ffaa89357c0
        public void Equals(){} // RVA: 0x7ffaadcbcc20
        public void Equals(){} // RVA: 0x7ffaadcbcc20
        public void ToString(){} // RVA: 0x7ffaadcbccd0
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcbcd20
        public void CalculateSize(){} // RVA: 0x7ffaadcbcde0
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcbcfd0
        public void .cctor(){} // RVA: 0x7ffaadcbd0d0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadbf6510
    }

    public class Rect : Object
    {
        public object _hasBits0; // 0x333FEA40
        public object YCenterDefaultValue; // 0x333FEA40
        public object height_; // 0x333FEA40
        public object RotationDefaultValue; // 0x333FEA40
        public object rectId_; // 0x333FEA40
        public object Parser; // 0x170001B1
        public object Descriptor; // 0x170001B2
        public object pb::Google.Protobuf.IMessage.Descriptor; // 0x170001B3
        public object XCenter; // 0x170001B4
        public object HasXCenter; // 0x170001B5

        // ── Original Methods ──
        public void get_Parser(){} // RVA: 0x7ffaadcd7a20
        public void get_Descriptor(){} // RVA: 0x7ffaadcd7a80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7ffaadcd7b40
        public void .ctor(){} // RVA: 0x7ffaadcd7c30
        public void .ctor(){} // RVA: 0x7ffaadcd7c30
        public void Clone(){} // RVA: 0x7ffaadcd7d30
        public void get_XCenter(){} // RVA: 0x7ffaadcd7e60
        public void set_XCenter(){} // RVA: 0x7ffaadc14910
        public void get_HasXCenter(){} // RVA: 0x7ffaadc14920
        public void ClearXCenter(){} // RVA: 0x7ffaadc14930
        public void get_YCenter(){} // RVA: 0x7ffaadcd7ed0
        public void set_YCenter(){} // RVA: 0x7ffaadc149b0
        public void get_HasYCenter(){} // RVA: 0x7ffaadc149c0
        public void ClearYCenter(){} // RVA: 0x7ffaadc149d0
        public void get_Height(){} // RVA: 0x7ffaadcd7f40
        public void set_Height(){} // RVA: 0x7ffaadca4650
        public void get_HasHeight(){} // RVA: 0x7ffaadc17bc0
        public void ClearHeight(){} // RVA: 0x7ffaadc17bd0
        public void get_Width(){} // RVA: 0x7ffaadcd7fb0
        public void set_Width(){} // RVA: 0x7ffaadca78b0
        public void get_HasWidth(){} // RVA: 0x7ffaadc18180
        public void ClearWidth(){} // RVA: 0x7ffaadc18190
        public void get_Rotation(){} // RVA: 0x7ffaadcd8020
        public void set_Rotation(){} // RVA: 0x7ffaadcc9020
        public void get_HasRotation(){} // RVA: 0x7ffaadc183f0
        public void ClearRotation(){} // RVA: 0x7ffaadc18400
        public void get_RectId(){} // RVA: 0x7ffaadcd8090
        public void set_RectId(){} // RVA: 0x7ffaadcd8100
        public void get_HasRectId(){} // RVA: 0x7ffaadca4a60
        public void ClearRectId(){} // RVA: 0x7ffaadca4a70
        public void Equals(){} // RVA: 0x7ffaadcd8170
        public void Equals(){} // RVA: 0x7ffaadcd8170
        public void ToString(){} // RVA: 0x7ffaadcd8430
        public void WriteTo(){} // RVA: 0x7ffaadbf1d10
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7ffaadcd8480
        public void CalculateSize(){} // RVA: 0x7ffaadcd85b0
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void MergeFrom(){} // RVA: 0x7ffaadbf2050
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7ffaadcd88d0
        public void .cctor(){} // RVA: 0x7ffaadcd8a00
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadcd8300
    }

    public class ResourceManager : Object
    {
        public object _pathResolver; // 0x33612F00

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadceacf0
        public void PrepareAssetAsync(){}
        public void PathToResourceAsFile(){} // RVA: 0x7ffaadceb280
        public void .cctor(){} // RVA: 0x7ffaadceb8f0
        // ── Binary Analysis Named ──
        public void GetResourceContents(){} // RVA: 0x7ffaadceb340
        public void GetAssetNameFromPath(){} // RVA: 0x7ffaadceb710
    }

    public class SafeNativeMethods : Object
    {
        // ── Original Methods ──
        public void absl_Status__ok(){} // RVA: 0x7ffaadc94dc0
        public void absl_Status__raw_code(){} // RVA: 0x7ffaadc94e40
        public void mp_ImageFrame__Format(){} // RVA: 0x7ffaadc94ec0
        public void mp_ImageFrame__Width(){} // RVA: 0x7ffaadc94f40
        public void mp_ImageFrame__Height(){} // RVA: 0x7ffaadc94fc0
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x7ffaadc95040
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x7ffaadc950c0
        public void mp_Image__width(){} // RVA: 0x7ffaadc95140
        public void mp_Image__height(){} // RVA: 0x7ffaadc951c0
        public void mp_Image__step(){} // RVA: 0x7ffaadc95240
        public void mp_Image__image_format(){} // RVA: 0x7ffaadc952c0
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x7ffaadc95340
        public void mp_Packet__IsEmpty(){} // RVA: 0x7ffaadc953c0
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x7ffaadc95440
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x7ffaadc954c0
        public void mp_SharedGlContext__get(){} // RVA: 0x7ffaadc95540
        public void mp_GlSyncToken__get(){} // RVA: 0x7ffaadc955c0
        public void mp_SharedGpuResources__get(){} // RVA: 0x7ffaadc95640
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x7ffaadc956c0
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x7ffaadc95750
    }

    public class SerializedProto : ValueType
    {
        public object _data; // 0x31873BD0

        // ── Original Methods ──
        public void Dispose(){} // RVA: 0x7ffaadc8d300
        public void Deserialize(){} // RVA: 0x7ffaa887e5c0
        public void WriteTo(){} // RVA: 0x7ffaa887e5c0
    }

    public class SerializedProtoVector : ValueType
    {
        // ── Original Methods ──
        public void Dispose(){} // RVA: 0x7ffaadc8d360
        public void Deserialize(){} // RVA: 0x7ffaa8669e70
        public void WriteTo(){} // RVA: 0x7ffaa8653ae0
    }

    public class SharedPtrHandle : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa86491d0
    }

    public class Status : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f6b90
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc91040
        public void UnsafeAssertOk(){} // RVA: 0x7ffaadc910a0
        public void AssertOk(){} // RVA: 0x7ffaadc911c0
        public void Ok(){} // RVA: 0x7ffaadc912e0
        public void Code(){} // RVA: 0x7ffaadc913a0
        public void RawCode(){} // RVA: 0x7ffaadc913a0
        public void ToString(){} // RVA: 0x7ffaadc914d0
    }

    public class StatusArgs : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc90e10
        public void Ok(){} // RVA: 0x7ffaadc90e80
        public void InvalidArgument(){} // RVA: 0x7ffaadc90ef0
        public void NotFound(){} // RVA: 0x7ffaadc90f60
        public void Internal(){} // RVA: 0x7ffaadc90fd0
    }

    public class StatusHandlerReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadce2220
        public void .cctor(){} // RVA: 0x7ffaadce2280
    }

    public class StdString : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc8d420
        public void .ctor(){} // RVA: 0x7ffaadc8d420
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc8d590
        public void Swap(){} // RVA: 0x7ffaadc8d650
    }

    public class StreamHandlerReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadce3ef0
        public void .cctor(){} // RVA: 0x7ffaadce3f50
    }

    public class TensorsToDetectionsCalculatorReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadca2940
        public void .cctor(){} // RVA: 0x7ffaadca29a0
    }

    public class TextureFormatExtension : Object
    {
        // ── Original Methods ──
        public void ToImageFormat(){} // RVA: 0x7ffaadceac80
    }

    public class ThresholdingCalculatorReflection : Object
    {
        // ── Original Methods ──
        public void get_Descriptor(){} // RVA: 0x7ffaadca9690
        public void .cctor(){} // RVA: 0x7ffaadca96f0
    }

    public class Tool : Object
    {
        public object _TagIndexRegex; // 0x338EE320

        // ── Original Methods ──
        public void ParseNameFromStream(){} // RVA: 0x7ffaadc91b30
        public void ValidateName(){} // RVA: 0x7ffaadc91bb0
        public void ValidateNumber(){} // RVA: 0x7ffaadc91cf0
        public void ValidateTag(){} // RVA: 0x7ffaadc91e30
        public void ParseTagAndName(){} // RVA: 0x7ffaadc91f70
        public void ParseTagIndexName(){} // RVA: 0x7ffaadc92330
        public void .cctor(){} // RVA: 0x7ffaadc92920
        // ── Binary Analysis Named ──
        public void GetUnusedSidePacketName(){} // RVA: 0x7ffaadc91710
    }

    public class UnsafeNativeMethods : Object
    {
        // ── Original Methods ──
        public void absl_Status__delete(){} // RVA: 0x7ffaadc957e0
        public void absl_Status__ToString(){} // RVA: 0x7ffaadc95860
        public void google_InitGoogleLogging__PKc(){} // RVA: 0x7ffaadc958f0
        public void google_ShutdownGoogleLogging(){} // RVA: 0x7ffaadc959a0
        public void glog_FLAGS_logtostderr(){} // RVA: 0x7ffaadc95a10
        public void glog_FLAGS_stderrthreshold(){} // RVA: 0x7ffaadc95a90
        public void glog_FLAGS_minloglevel(){} // RVA: 0x7ffaadc95b10
        public void glog_FLAGS_v(){} // RVA: 0x7ffaadc95b90
        public void google_protobuf__SetLogHandler__PF(){} // RVA: 0x7ffaadc95c10
        public void google_protobuf__ResetLogHandler(){} // RVA: 0x7ffaadc95ca0
        public void mp_api_SerializedProtoArray__delete(){} // RVA: 0x7ffaadc95d10
        public void delete_array__PKc(){} // RVA: 0x7ffaadc95da0
        public void std_string__delete(){} // RVA: 0x7ffaadc95e20
        public void std_string__PKc_i(){} // RVA: 0x7ffaadc95ea0
        public void std_string__swap__Rstr(){} // RVA: 0x7ffaadc95f40
        public void mp_CalculatorGraph__(){} // RVA: 0x7ffaadc95fd0
        public void mp_CalculatorGraph__delete(){} // RVA: 0x7ffaadc96050
        public void mp_CalculatorGraph__Initialize__PKc_i(){} // RVA: 0x7ffaadc960d0
        public void mp_CalculatorGraph__ObserveOutputStream__PKc_PF_b(){} // RVA: 0x7ffaadc96190
        public void mp_CalculatorGraph__AddOutputStreamPoller__PKc_b(){} // RVA: 0x7ffaadc96280
        public void mp_CalculatorGraph__StartRun__Rsp(){} // RVA: 0x7ffaadc96360
        public void mp_CalculatorGraph__WaitUntilDone(){} // RVA: 0x7ffaadc96400
        public void mp_CalculatorGraph__AddPacketToInputStream__PKc_Ppacket(){} // RVA: 0x7ffaadc96490
        public void mp_CalculatorGraph__CloseAllPacketSources(){} // RVA: 0x7ffaadc96560
        public void mp_CalculatorGraph__SetGpuResources__SPgpu(){} // RVA: 0x7ffaadc965f0
        public void mp_api__ConvertFromCalculatorGraphConfigTextFormat(){} // RVA: 0x7ffaadc96690
        public void mp_ImageFrame__ui_i_i_i_Pui8_PF(){} // RVA: 0x7ffaadc96740
        public void mp_ImageFrame__delete(){} // RVA: 0x7ffaadc96800
        public void mp__MakeImageFramePacket_At__Pif_ll(){} // RVA: 0x7ffaadc96880
        public void mp_Packet__GetImageFrame(){} // RVA: 0x7ffaadc96920
        public void mp_Image__ui_i_i_i_Pui8_PF(){} // RVA: 0x7ffaadc969b0
        public void mp_Image__delete(){} // RVA: 0x7ffaadc96a70
        public void mp_PixelWriteLock__RI(){} // RVA: 0x7ffaadc96af0
        public void mp_PixelWriteLock__delete(){} // RVA: 0x7ffaadc96b80
        public void mp__MakeImagePacket__PI(){} // RVA: 0x7ffaadc96c00
        public void mp__MakeImagePacket_At__PI_ll(){} // RVA: 0x7ffaadc96c90
        public void mp_Packet__GetImage(){} // RVA: 0x7ffaadc96d30
        public void mp_Packet__GetImageVector(){} // RVA: 0x7ffaadc96dc0
        public void mp_OutputStreamPoller__delete(){} // RVA: 0x7ffaadc96e50
        public void mp_OutputStreamPoller__Next_Ppacket(){} // RVA: 0x7ffaadc96ed0
        public void mp_Packet__(){} // RVA: 0x7ffaadc96f80
        public void mp_Packet__delete(){} // RVA: 0x7ffaadc97000
        public void mp__MakeBoolPacket__b(){} // RVA: 0x7ffaadc97080
        public void mp__MakeIntPacket__i(){} // RVA: 0x7ffaadc97110
        public void mp__PacketFromDynamicProto__PKc_PKc_i(){} // RVA: 0x7ffaadc971a0
        public void mp__PacketFromDynamicProto_At__PKc_PKc_i_ll(){} // RVA: 0x7ffaadc97280
        public void mp_Packet__GetProtoMessageLite(){} // RVA: 0x7ffaadc97370
        public void mp_Packet__GetVectorOfProtoMessageLite(){} // RVA: 0x7ffaadc97400
        public void mp_PacketMap__(){} // RVA: 0x7ffaadc97490
        public void mp_PacketMap__delete(){} // RVA: 0x7ffaadc97510
        public void mp_PacketMap__emplace__PKc_Rp(){} // RVA: 0x7ffaadc97590
        public void mp_PacketMap__find__PKc(){} // RVA: 0x7ffaadc97650
        public void mp_ValidatedGraphConfig__(){} // RVA: 0x7ffaadc97710
        public void mp_ValidatedGraphConfig__delete(){} // RVA: 0x7ffaadc97790
        public void mp_ValidatedGraphConfig__Initialize__Rcgc(){} // RVA: 0x7ffaadc97810
        public void mp_ValidatedGraphConfig__Config(){} // RVA: 0x7ffaadc978d0
        public void mp_GlCalculatorHelper__(){} // RVA: 0x7ffaadc97960
        public void mp_GlCalculatorHelper__delete(){} // RVA: 0x7ffaadc979e0
        public void mp_GlCalculatorHelper__InitializeForTest__Pgr(){} // RVA: 0x7ffaadc97a60
        public void mp_SharedGlContext__delete(){} // RVA: 0x7ffaadc97af0
        public void mp_GlSyncToken__delete(){} // RVA: 0x7ffaadc97b70
        public void mp_GlSyncPoint__Wait(){} // RVA: 0x7ffaadc97bf0
        public void mp_GpuBuffer__delete(){} // RVA: 0x7ffaadc97c70
        public void mp__MakeGpuBufferPacket__Rgb(){} // RVA: 0x7ffaadc97cf0
        public void mp__MakeGpuBufferPacket_At__Rgb_ll(){} // RVA: 0x7ffaadc97d80
        public void mp_SharedGpuResources__delete(){} // RVA: 0x7ffaadc97e20
        public void mp_GpuResources_Create__Pv(){} // RVA: 0x7ffaadc97ea0
        public void mp_Packet__GetClassificationsVector(){} // RVA: 0x7ffaadc97f40
        public void mp_tasks_c_components_containers_CppCloseClassificationResult(){} // RVA: 0x7ffaadc98020
        public void mp_Packet__GetDetectionResult(){} // RVA: 0x7ffaadc980e0
        public void mp_tasks_c_components_containers_CppCloseDetectionResult(){} // RVA: 0x7ffaadc98170
        public void mp_Packet__GetLandmarksVector(){} // RVA: 0x7ffaadc98200
        public void mp_api_LandmarksArray__delete(){} // RVA: 0x7ffaadc98290
        public void mp_Packet__GetNormalizedLandmarksVector(){} // RVA: 0x7ffaadc98320
        public void mp_api_NormalizedLandmarksArray__delete(){} // RVA: 0x7ffaadc983b0
        public void mp_tasks_core_TaskRunner_Create__PKc_i_PF(){} // RVA: 0x7ffaadc98440
        public void mp_tasks_core_TaskRunner__delete(){} // RVA: 0x7ffaadc98500
        public void mp_tasks_core_TaskRunner__Process__Ppm(){} // RVA: 0x7ffaadc98580
        public void mp_tasks_core_TaskRunner__Send__Ppm(){} // RVA: 0x7ffaadc98630
        public void mp_tasks_core_TaskRunner__Close(){} // RVA: 0x7ffaadc986d0
        public void .cctor(){} // RVA: 0x7ffaadc98760
        public void FreeHGlobal(){} // RVA: 0x7ffaadc988f0
        public void mp_api__SetFreeHGlobal(){} // RVA: 0x7ffaadc98940
    }

    public class ValidatedGraphConfig : MpResourceHandle
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc92c10
        public void DeleteMpPtr(){} // RVA: 0x7ffaadc92d50
        public void Initialize(){} // RVA: 0x7ffaadc92e10
        public void Config(){} // RVA: 0x7ffaadc92f50
    }

}