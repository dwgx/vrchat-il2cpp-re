// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
// Classes: 17
// Methods: 192

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
{
    public class Adler : Object
    {
        // ── Methods ──
        public void Adler32(){} // RVA: 0x7FFE8A288E00
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A289170
    }

    public class DeflateManager : Object
    {
        public int MEM_LEVEL_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A279EB0
        public void _InitializeLazyMatch(){} // RVA: 0x7FFE8A27A390
        public void _InitializeTreeData(){} // RVA: 0x7FFE8A27A4D0
        public void _InitializeBlocks(){} // RVA: 0x7FFE8A27A7F0
        public void pqdownheap(){} // RVA: 0x7FFE8A27A9B0
        public void _IsSmaller(){} // RVA: 0x7FFE8A27AC10
        public void scan_tree(){} // RVA: 0x7FFE8A27AC90
        public void build_bl_tree(){} // RVA: 0x7FFE8A27AF20
        public void send_all_trees(){} // RVA: 0x7FFE8A27B0A0
        public void send_tree(){} // RVA: 0x7FFE8A27B200
        public void put_bytes(){} // RVA: 0x7FFE8A27B580
        public void send_code(){} // RVA: 0x7FFE8A27B5D0
        public void send_bits(){} // RVA: 0x7FFE8A27B620
        public void _tr_align(){} // RVA: 0x7FFE8A27B790
        public void _tr_tally(){} // RVA: 0x7FFE8A27B980
        public void send_compressed_block(){} // RVA: 0x7FFE8A27BC90
        public void set_data_type(){} // RVA: 0x7FFE8A27C070
        public void bi_flush(){} // RVA: 0x7FFE8A27C220
        public void bi_windup(){} // RVA: 0x7FFE8A27C300
        public void copy_block(){} // RVA: 0x7FFE8A27C3D0
        public void flush_block_only(){} // RVA: 0x7FFE8A27C4F0
        public void DeflateNone(){} // RVA: 0x7FFE8A27C560
        public void _tr_stored_block(){} // RVA: 0x7FFE8A27C820
        public void _tr_flush_block(){} // RVA: 0x7FFE8A27C9A0
        public void _fillWindow(){} // RVA: 0x7FFE8A27CFE0
        public void DeflateFast(){} // RVA: 0x7FFE8A27D370
        public void DeflateSlow(){} // RVA: 0x7FFE8A27D910
        public void longest_match(){} // RVA: 0x7FFE8A27E030
        public void get_WantRfc1950HeaderBytes(){} // RVA: 0x7FFE81EDE0E0
        public void set_WantRfc1950HeaderBytes(){} // RVA: 0x7FFE81EDE3B0
        public void Initialize(){} // RVA: 0x7FFE8A27E700 | overloaded x4
        public void Reset(){} // RVA: 0x7FFE8A27EAC0
        public void End(){} // RVA: 0x7FFE8A27ED70
        public void SetDeflater(){} // RVA: 0x7FFE8A27F000
        public void SetParams(){} // RVA: 0x7FFE8A27F220
        public void SetDictionary(){} // RVA: 0x7FFE8A27F350
        public void Deflate(){} // RVA: 0x7FFE8A27F680
        public void .cctor(){} // RVA: 0x7FFE8A27FEE0
    }

    public class DeflateStream : Stream
    {
        public BestHTTP.Decompression.Zlib.ZlibBaseStream _baseStream; // 0x28
        public System.IO.Stream _innerStream; // 0x30
        public bool _disposed; // 0x38
        public object field_3; // 0x9D0
        public object field_4; // 0x9D1
        public object field_5; // 0x9D2
        public object field_6; // 0x9D3
        public object field_7; // 0x9D4
        public object field_8; // 0x9D5
        public object field_9; // 0x9D6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A280AB0 | overloaded x5
        public void get_FlushMode(){} // RVA: 0x7FFE8A280C40
        public void set_FlushMode(){} // RVA: 0x7FFE8A280C60
        public void get_BufferSize(){} // RVA: 0x7FFE8A280CE0
        public void set_BufferSize(){} // RVA: 0x7FFE8A280D00
        public void get_Strategy(){} // RVA: 0x7FFE8A280E80
        public void set_Strategy(){} // RVA: 0x7FFE8A280EA0
        public void get_TotalIn(){} // RVA: 0x7FFE8A280F20
        public void get_TotalOut(){} // RVA: 0x7FFE8A280F50
        public void Dispose(){} // RVA: 0x7FFE8A280F80
        public void get_CanRead(){} // RVA: 0x7FFE8A281000
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE8A281090
        public void Flush(){} // RVA: 0x7FFE8A281120
        public void get_Length(){} // RVA: 0x7FFE8A2811B0
        public void get_Position(){} // RVA: 0x7FFE8A2811F0
        public void set_Position(){} // RVA: 0x7FFE8A281240
        public void Read(){} // RVA: 0x7FFE8A281280
        public void Seek(){} // RVA: 0x7FFE8A281310
        public void SetLength(){} // RVA: 0x7FFE871CDA40
        public void Write(){} // RVA: 0x7FFE8A281350
    }

    public class GZipStream : Stream
    {
        public System.Nullable`1<System.DateTime> LastModified; // 0x28
        public int _headerByteCount; // 0x38
        public BestHTTP.Decompression.Zlib.ZlibBaseStream _baseStream; // 0x40
        public bool _disposed; // 0x48
        public bool _firstReadDone; // 0x49
        public string _FileName; // 0x50
        public string _Comment; // 0x58
        public int _Crc32; // 0x60
        public System.DateTime _unixEpoch;
        public System.Text.Encoding iso8859dash1; // 0x8
        public object field_10; // 0x9DA
        public object field_11; // 0x9DB

        // ── Methods ──
        public void get_Comment(){} // RVA: 0x7FFE811C3500
        public void set_Comment(){} // RVA: 0x7FFE8A2813E0
        public void get_FileName(){} // RVA: 0x7FFE8119C0E0
        public void set_FileName(){} // RVA: 0x7FFE8A281490
        public void get_Crc32(){} // RVA: 0x7FFE8139EA30
        public void .ctor(){} // RVA: 0x7FFE8A281750 | overloaded x4
        public void get_FlushMode(){} // RVA: 0x7FFE8A281860
        public void set_FlushMode(){} // RVA: 0x7FFE8A281880
        public void get_BufferSize(){} // RVA: 0x7FFE8A281900
        public void set_BufferSize(){} // RVA: 0x7FFE8A281920
        public void get_TotalIn(){} // RVA: 0x7FFE8A281AA0
        public void get_TotalOut(){} // RVA: 0x7FFE8A281AD0
        public void Dispose(){} // RVA: 0x7FFE8A281B00
        public void get_CanRead(){} // RVA: 0x7FFE8A281BA0
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE8A281C30
        public void Flush(){} // RVA: 0x7FFE8A281CC0
        public void get_Length(){} // RVA: 0x7FFE8A281D50
        public void get_Position(){} // RVA: 0x7FFE8A281D90
        public void set_Position(){} // RVA: 0x7FFE8A281DF0
        public void Read(){} // RVA: 0x7FFE8A281E30
        public void Seek(){} // RVA: 0x7FFE8A281FB0
        public void SetLength(){} // RVA: 0x7FFE8A281FF0
        public void Write(){} // RVA: 0x7FFE8A282020
        public void EmitHeader(){} // RVA: 0x7FFE8A282140
        public void .cctor(){} // RVA: 0x7FFE8A2825D0
    }

    public class InfTree : Object
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x7FFE8A286E90
        public void inflate_trees_bits(){} // RVA: 0x7FFE8A2877D0
        public void inflate_trees_dynamic(){} // RVA: 0x7FFE8A2879D0
        public void inflate_trees_fixed(){} // RVA: 0x7FFE8A287DB0
        public void initWorkArea(){} // RVA: 0x7FFE8A287EA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A288270
    }

    public class InflateBlocks : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2826E0
        public void Reset(){} // RVA: 0x7FFE8A282A70
        public void Process(){} // RVA: 0x7FFE8A282B20
        public void Free(){} // RVA: 0x7FFE8A284020
        public void SetDictionary(){} // RVA: 0x7FFE8A284140
        public void SyncPoint(){} // RVA: 0x7FFE8A01A1B0
        public void Flush(){} // RVA: 0x7FFE8A284190
        public void .cctor(){} // RVA: 0x7FFE8A284330
    }

    public class InflateCodes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A01A4D0
        public void Process(){} // RVA: 0x7FFE8A2844F0
        public void InflateFast(){} // RVA: 0x7FFE8A2850B0
    }

    public class InflateManager : Object
    {
        public int PRESET_DICT;

        // ── Methods ──
        public void get_HandleRfc1950HeaderBytes(){} // RVA: 0x7FFE81121450
        public void set_HandleRfc1950HeaderBytes(){} // RVA: 0x7FFE81121460
        public void .ctor(){} // RVA: 0x7FFE81121460 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE8A285A50
        public void End(){} // RVA: 0x7FFE8A285AF0
        public void Initialize(){} // RVA: 0x7FFE8A285C90
        public void Inflate(){} // RVA: 0x7FFE8A285F00
        public void SetDictionary(){} // RVA: 0x7FFE8A2869E0
        public void Sync(){} // RVA: 0x7FFE8A286B80
        public void SyncPoint(){} // RVA: 0x7FFE8A286D80
        public void .cctor(){} // RVA: 0x7FFE8A286DB0
    }

    public class InternalConstants : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A2888A0
    }

    public class InternalInflateConstants : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A284410
    }

    public class SharedUtils : Object
    {
        // ── Methods ──
        public void URShift(){} // RVA: 0x7FFE8A288740
        public void ReadInput(){} // RVA: 0x7FFE8A288750
        public void ToByteArray(){} // RVA: 0x7FFE89ECC210
        public void ToCharArray(){} // RVA: 0x7FFE8A288860
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StaticTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A01E870
        public void .cctor(){} // RVA: 0x7FFE8A2889A0
    }

    public class ZTree : Object
    {
        // ── Methods ──
        public void DistanceCode(){} // RVA: 0x7FFE8A28C300
        public void gen_bitlen(){} // RVA: 0x7FFE8A28C3C0
        public void build_tree(){} // RVA: 0x7FFE8A28C820
        public void gen_codes(){} // RVA: 0x7FFE8A28CD90
        public void bi_reverse(){} // RVA: 0x7FFE8A0230C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A28CF70
    }

    public class ZlibBaseStream : Stream
    {
        public BestHTTP.Decompression.Zlib.ZlibCodec _z; // 0x28
        public 0x664A36AC _streamMode; // 0x30
        public 0x664A333C _flushMode; // 0x34
        public 0x664A3654 _flavor; // 0x38
        public 0x664A3444 _compressionMode; // 0x3C
        public 0x664A3394 _level; // 0x40
        public bool _leaveOpen; // 0x44
        public byte[] _workingBuffer; // 0x48
        public int _bufferSize; // 0x50

        // ── Methods ──
        public void get_Crc32(){} // RVA: 0x7FFE8A2891D0
        public void .ctor(){} // RVA: 0x7FFE8A289220 | overloaded x2
        public void get__wantCompress(){} // RVA: 0x7FFE8A289420
        public void get_z(){} // RVA: 0x7FFE8A289430
        public void get_workingBuffer(){} // RVA: 0x7FFE8A289560
        public void Write(){} // RVA: 0x7FFE8A289620
        public void finish(){} // RVA: 0x7FFE8A289A10
        public void end(){} // RVA: 0x7FFE8A28A300
        public void Close(){} // RVA: 0x7FFE8A28A5E0
        public void Flush(){} // RVA: 0x7FFE8A28A6F0
        public void Seek(){} // RVA: 0x7FFE8A28A720
        public void SetLength(){} // RVA: 0x7FFE8A28A760
        public void ReadZeroTerminatedString(){} // RVA: 0x7FFE8A28A7A0
        public void _ReadAndValidateGzipHeader(){} // RVA: 0x7FFE8A28A9C0
        public void Read(){} // RVA: 0x7FFE8A28AE50
        public void get_CanRead(){} // RVA: 0x7FFE8A28B4B0
        public void get_CanSeek(){} // RVA: 0x7FFE8A28B4E0
        public void get_CanWrite(){} // RVA: 0x7FFE8A28B510
        public void get_Length(){} // RVA: 0x7FFE8A28B540
        public void get_Position(){} // RVA: 0x7FFE8A28B570
        public void set_Position(){} // RVA: 0x7FFE8A28B5B0
    }

    public class ZlibCodec : Object
    {
        public byte[] InputBuffer; // 0x10

        // ── Methods ──
        public void get_Adler32(){} // RVA: 0x7FFE8175AC90
        public void .ctor(){} // RVA: 0x7FFE8A28B600 | overloaded x2
        public void InitializeInflate(){} // RVA: 0x7FFE8A28B770 | overloaded x4
        public void Inflate(){} // RVA: 0x7FFE8A28B890
        public void EndInflate(){} // RVA: 0x7FFE8A28B900
        public void SyncInflate(){} // RVA: 0x7FFE8A28B9D0
        public void InitializeDeflate(){} // RVA: 0x7FFE8A28BAA0 | overloaded x5
        public void _InternalInitializeDeflate(){} // RVA: 0x7FFE8A28BAC0
        public void Deflate(){} // RVA: 0x7FFE8A28BC70
        public void EndDeflate(){} // RVA: 0x7FFE8A28BCE0
        public void ResetDeflate(){} // RVA: 0x7FFE8A28BD90
        public void SetDeflateParams(){} // RVA: 0x7FFE8A28BE00
        public void SetDictionary(){} // RVA: 0x7FFE8A28BF90
        public void flush_pending(){} // RVA: 0x7FFE8A28C030
        public void read_buf(){} // RVA: 0x7FFE8A28C1F0
    }

    public class ZlibConstants : Object
    {
    }

    public class ZlibException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2886E0 | overloaded x2
    }

}