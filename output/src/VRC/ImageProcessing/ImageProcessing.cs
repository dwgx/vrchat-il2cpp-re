// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.ImageProcessing
// Classes: 6
// Methods: 44

namespace VRC.ImageProcessing
{
    public class IImageUploader
    {
        // ── Methods ──
        public void EnsureUploadSafeFormat(){} // RVA: 0x87CE50
        public void UploadAsync(){} // RVA: 0x88BC90
    }

    public class Image : Object
    {
        public object _handle;
        public object _cloneMarker;
        public object _dimensionsMarker;
        public object _formatMarker;
        public object _hasAlphaMarker;
        public object _convertMarker;
        public object _resizeMarker;
        public object _resizeExactMarker;
        public object _thumbnailMarker;
        public object _flipVerticalMarker;
        public object _asBytesMarker;
        public object _asNativeArrayMarker;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Handle(){} // RVA: 0xB5DBF0
        public void Dispose(){} // RVA: 0x8305C80
        public void Clone(){} // RVA: 0x8305CA0
        public void get_Dimensions(){} // RVA: 0x8306010
        public void get_Format(){} // RVA: 0x8306290
        public void Convert(){} // RVA: 0x83064D0
        public void Resize(){} // RVA: 0x8306690
        public void ResizeExact(){} // RVA: 0x8306860
        public void FlipVertical(){} // RVA: 0x8306A30
        public void ApplyPlatformFlip(){} // RVA: 0x8306DC0
        public void ApplySizeLimit(){} // RVA: 0x8306DE0
        public void AsBytes(){} // RVA: 0x8306E80
        public void AsNativeArray(){} // RVA: 0x8307010
        public void .cctor(){} // RVA: 0x8307170
    }

    public class ImageException : Exception
    {
        public object _error;

        // ── Methods ──
        public void get_Error(){} // RVA: 0x1C4D9A0
        public void .ctor(){} // RVA: 0x8305850
    }

    public class ImageFormatExtensions : Object
    {
        // ── Methods ──
        public void ToUnityTextureFormat(){} // RVA: 0x8305950
    }

    public class ImageUploader : Object
    {
        public object _flushMarker;
        public object _uploadMarker;
        public object _textureUpdateCallback;
        public object _cmd;
        public object _cts;
        public object _dirty;
        public object _disposed;

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x8307460
        public void ResetNativeState(){} // RVA: 0x83074B0
        public void .ctor(){} // RVA: 0x8307570
        public void IsUploadSafe(){} // RVA: 0x83079C0
        public void EnsureUploadSafeFormat(){} // RVA: 0x8307A10
        public void UploadAsync(){} // RVA: 0x8307F00
        public void Dispose(){} // RVA: 0x8308180
        public void RunFlushLoop(){} // RVA: 0x8308220
        public void .cctor(){} // RVA: 0x83083B0
    }

    public class Native : Object
    {
        // ── Methods ──
        public void image_load(){} // RVA: 0x830B2F0
        public void image_clone(){} // RVA: 0x830B6E0
        public void image_dimensions(){} // RVA: 0x830B9C0
        public void image_format(){} // RVA: 0x830BC00
        public void image_convert(){} // RVA: 0x830BEE0
        public void image_resize(){} // RVA: 0x830C2B0
        public void image_resize_exact(){} // RVA: 0x830C690
        public void image_flip_vertical(){} // RVA: 0x830CA50
        public void image_as_bytes(){} // RVA: 0x830CD20
        public void image_free(){} // RVA: 0x830CE50
        public void texture_upload_register(){} // RVA: 0x830CFB0
        public void texture_upload_is_complete(){} // RVA: 0x830D170
        public void get_texture_update_callback(){} // RVA: 0x830D2D0
        public void texture_upload_reset_ffi(){} // RVA: 0x830D3B0
        public void texture_upload_reset(){} // RVA: 0x83074B0
    }

}