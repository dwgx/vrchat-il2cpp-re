// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
// Classes: 17
// Methods: 192

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
{
    public class Adler : Object
    {
        public uint BASE;
        public int NMAX; // 0x4

        // ── Methods ──
        public void Adler32(){} // RVA: 0x7FFACBE2F7E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBE2FB50
    }

    public class DeflateManager : Object
    {
        public int WantRfc1950HeaderBytes;
        public int MEM_LEVEL_DEFAULT; // 0x4
        public CompressFunc DeflateFunction; // 0x10
        public string[] _ErrorMessage; // 0x8
        public int PRESET_DICT; // 0x10
        public int INIT_STATE; // 0x14
        public int BUSY_STATE; // 0x18
        public int FINISH_STATE; // 0x1C
        public int Z_DEFLATED; // 0x20
        public int STORED_BLOCK; // 0x24
        public int STATIC_TREES; // 0x28
        public int DYN_TREES; // 0x2C
        public int Z_BINARY; // 0x30
        public int Z_ASCII; // 0x34
        public int Z_UNKNOWN; // 0x38
        public int Buf_size; // 0x3C
        public int MIN_MATCH; // 0x40
        public int MAX_MATCH; // 0x44
        public int MIN_LOOKAHEAD; // 0x48
        public int HEAP_SIZE; // 0x4C
        public int END_BLOCK; // 0x50
        public BestHTTP.Decompression.Zlib.ZlibCodec _codec; // 0x18
        public int status; // 0x20
        public byte[] pending; // 0x28
        public int nextPending; // 0x30
        public int pendingCount; // 0x34
        public sbyte data_type; // 0x38
        public int last_flush; // 0x3C
        public int w_size; // 0x40
        public int w_bits; // 0x44
        public int w_mask; // 0x48
        public byte[] window; // 0x50
        public int window_size; // 0x58
        public short[] prev; // 0x60
        public short[] head; // 0x68
        public int ins_h; // 0x70
        public int hash_size; // 0x74
        public int hash_bits; // 0x78
        public int hash_mask; // 0x7C
        public int hash_shift; // 0x80
        public int block_start; // 0x84
        public Config config; // 0x88
        public int match_length; // 0x90
        public int prev_match; // 0x94
        public int match_available; // 0x98
        public int strstart; // 0x9C
        public int match_start; // 0xA0
        public int lookahead; // 0xA4
        public int prev_length; // 0xA8
        public 0x6B0AAC00 compressionLevel; // 0xAC
        public 0x6B0AAC58 compressionStrategy; // 0xB0
        public short[] dyn_ltree; // 0xB8
        public short[] dyn_dtree; // 0xC0
        public short[] bl_tree; // 0xC8
        public BestHTTP.Decompression.Zlib.ZTree treeLiterals; // 0xD0
        public BestHTTP.Decompression.Zlib.ZTree treeDistances; // 0xD8
        public BestHTTP.Decompression.Zlib.ZTree treeBitLengths; // 0xE0
        public short[] bl_count; // 0xE8
        public int[] heap; // 0xF0
        public int heap_len; // 0xF8
        public int heap_max; // 0xFC
        public sbyte[] depth; // 0x100
        public int _lengthOffset; // 0x108
        public int lit_bufsize; // 0x10C
        public int last_lit; // 0x110
        public int _distanceOffset; // 0x114
        public int opt_len; // 0x118
        public int static_len; // 0x11C
        public int matches; // 0x120
        public int last_eob_len; // 0x124
        public short bi_buf; // 0x128
        public int bi_valid; // 0x12C
        public bool Rfc1950BytesEmitted; // 0x130
        public bool _WantRfc1950HeaderBytes; // 0x131

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE20890
        public void _InitializeLazyMatch(){} // RVA: 0x7FFACBE20D70
        public void _InitializeTreeData(){} // RVA: 0x7FFACBE20EB0
        public void _InitializeBlocks(){} // RVA: 0x7FFACBE211D0
        public void pqdownheap(){} // RVA: 0x7FFACBE21390
        public void _IsSmaller(){} // RVA: 0x7FFACBE215F0
        public void scan_tree(){} // RVA: 0x7FFACBE21670
        public void build_bl_tree(){} // RVA: 0x7FFACBE21900
        public void send_all_trees(){} // RVA: 0x7FFACBE21A80
        public void send_tree(){} // RVA: 0x7FFACBE21BE0
        public void put_bytes(){} // RVA: 0x7FFACBE21F60
        public void send_code(){} // RVA: 0x7FFACBE21FB0
        public void send_bits(){} // RVA: 0x7FFACBE22000
        public void _tr_align(){} // RVA: 0x7FFACBE22170
        public void _tr_tally(){} // RVA: 0x7FFACBE22360
        public void send_compressed_block(){} // RVA: 0x7FFACBE22670
        public void set_data_type(){} // RVA: 0x7FFACBE22A50
        public void bi_flush(){} // RVA: 0x7FFACBE22C00
        public void bi_windup(){} // RVA: 0x7FFACBE22CE0
        public void copy_block(){} // RVA: 0x7FFACBE22DB0
        public void flush_block_only(){} // RVA: 0x7FFACBE22ED0
        public void DeflateNone(){} // RVA: 0x7FFACBE22F40
        public void _tr_stored_block(){} // RVA: 0x7FFACBE23200
        public void _tr_flush_block(){} // RVA: 0x7FFACBE23380
        public void _fillWindow(){} // RVA: 0x7FFACBE239C0
        public void DeflateFast(){} // RVA: 0x7FFACBE23D50
        public void DeflateSlow(){} // RVA: 0x7FFACBE242F0
        public void longest_match(){} // RVA: 0x7FFACBE24A10
        public void get_WantRfc1950HeaderBytes(){} // RVA: 0x7FFAC3C169E0
        public void set_WantRfc1950HeaderBytes(){} // RVA: 0x7FFAC3C16820
        public void Initialize(){} // RVA: 0x7FFACBE250E0 | overloaded x4
        public void Reset(){} // RVA: 0x7FFACBE254A0
        public void End(){} // RVA: 0x7FFACBE25750
        public void SetDeflater(){} // RVA: 0x7FFACBE259E0
        public void SetParams(){} // RVA: 0x7FFACBE25C00
        public void SetDictionary(){} // RVA: 0x7FFACBE25D30
        public void Deflate(){} // RVA: 0x7FFACBE26060
        public void .cctor(){} // RVA: 0x7FFACBE268C0
    }

    public class DeflateStream : Stream
    {
        public BestHTTP.Decompression.Zlib.ZlibBaseStream FlushMode; // 0x28
        public System.IO.Stream BufferSize; // 0x30
        public bool Strategy; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE27490 | overloaded x5
        public void get_FlushMode(){} // RVA: 0x7FFACBE27620
        public void set_FlushMode(){} // RVA: 0x7FFACBE27640
        public void get_BufferSize(){} // RVA: 0x7FFACBE276C0
        public void set_BufferSize(){} // RVA: 0x7FFACBE276E0
        public void get_Strategy(){} // RVA: 0x7FFACBE27860
        public void set_Strategy(){} // RVA: 0x7FFACBE27880
        public void get_TotalIn(){} // RVA: 0x7FFACBE27900
        public void get_TotalOut(){} // RVA: 0x7FFACBE27930
        public void Dispose(){} // RVA: 0x7FFACBE27960
        public void get_CanRead(){} // RVA: 0x7FFACBE279E0
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFACBE27A70
        public void Flush(){} // RVA: 0x7FFACBE27B00
        public void get_Length(){} // RVA: 0x7FFACBE27B90
        public void get_Position(){} // RVA: 0x7FFACBE27BD0
        public void set_Position(){} // RVA: 0x7FFACBE27C20
        public void Read(){} // RVA: 0x7FFACBE27C60
        public void Seek(){} // RVA: 0x7FFACBE27CF0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
        public void Write(){} // RVA: 0x7FFACBE27D30
    }

    public class GZipStream : Stream
    {
        public System.Nullable`1<System.DateTime> Comment; // 0x28
        public int FileName; // 0x38
        public BestHTTP.Decompression.Zlib.ZlibBaseStream Crc32; // 0x40
        public bool FlushMode; // 0x48
        public bool BufferSize; // 0x49
        public string TotalIn; // 0x50
        public string TotalOut; // 0x58
        public int CanRead; // 0x60
        public System.DateTime CanSeek;
        public System.Text.Encoding CanWrite; // 0x8

        // ── Methods ──
        public void get_Comment(){} // RVA: 0x7FFAC2FE9500
        public void set_Comment(){} // RVA: 0x7FFACBE27DC0
        public void get_FileName(){} // RVA: 0x7FFAC2FC20E0
        public void set_FileName(){} // RVA: 0x7FFACBE27E70
        public void get_Crc32(){} // RVA: 0x7FFAC3138C20
        public void .ctor(){} // RVA: 0x7FFACBE28130 | overloaded x4
        public void get_FlushMode(){} // RVA: 0x7FFACBE28240
        public void set_FlushMode(){} // RVA: 0x7FFACBE28260
        public void get_BufferSize(){} // RVA: 0x7FFACBE282E0
        public void set_BufferSize(){} // RVA: 0x7FFACBE28300
        public void get_TotalIn(){} // RVA: 0x7FFACBE28480
        public void get_TotalOut(){} // RVA: 0x7FFACBE284B0
        public void Dispose(){} // RVA: 0x7FFACBE284E0
        public void get_CanRead(){} // RVA: 0x7FFACBE28580
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFACBE28610
        public void Flush(){} // RVA: 0x7FFACBE286A0
        public void get_Length(){} // RVA: 0x7FFACBE28730
        public void get_Position(){} // RVA: 0x7FFACBE28770
        public void set_Position(){} // RVA: 0x7FFACBE287D0
        public void Read(){} // RVA: 0x7FFACBE28810
        public void Seek(){} // RVA: 0x7FFACBE28990
        public void SetLength(){} // RVA: 0x7FFACBE289D0
        public void Write(){} // RVA: 0x7FFACBE28A00
        public void EmitHeader(){} // RVA: 0x7FFACBE28B20
        public void .cctor(){} // RVA: 0x7FFACBE28FB0
    }

    public class InfTree : Object
    {
        public int MANY;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;
        public int fixed_bl;
        public int fixed_bd;
        public int[] fixed_tl;
        public int[] fixed_td; // 0x8
        public int[] cplens; // 0x10
        public int[] cplext; // 0x18
        public int[] cpdist; // 0x20
        public int[] cpdext; // 0x28
        public int BMAX;
        public int[] hn; // 0x10
        public int[] v; // 0x18
        public int[] c; // 0x20
        public int[] r; // 0x28
        public int[] u; // 0x30
        public int[] x; // 0x38

        // ── Methods ──
        public void huft_build(){} // RVA: 0x7FFACBE2D870
        public void inflate_trees_bits(){} // RVA: 0x7FFACBE2E1B0
        public void inflate_trees_dynamic(){} // RVA: 0x7FFACBE2E3B0
        public void inflate_trees_fixed(){} // RVA: 0x7FFACBE2E790
        public void initWorkArea(){} // RVA: 0x7FFACBE2E880
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBE2EC50
    }

    public class InflateBlocks : Object
    {
        public int MANY;
        public int[] border;
        public 0x6B0AA940 mode; // 0x10
        public int left; // 0x14
        public int table; // 0x18
        public int index; // 0x1C
        public int[] blens; // 0x20
        public int[] bb; // 0x28
        public int[] tb; // 0x30
        public BestHTTP.Decompression.Zlib.InflateCodes codes; // 0x38
        public int last; // 0x40
        public BestHTTP.Decompression.Zlib.ZlibCodec _codec; // 0x48
        public int bitk; // 0x50
        public int bitb; // 0x54
        public int[] hufts; // 0x58
        public byte[] window; // 0x60
        public int end; // 0x68
        public int readAt; // 0x6C
        public int writeAt; // 0x70
        public object checkfn; // 0x78
        public uint check; // 0x80
        public BestHTTP.Decompression.Zlib.InfTree inftree; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE290C0
        public void Reset(){} // RVA: 0x7FFACBE29450
        public void Process(){} // RVA: 0x7FFACBE29500
        public void Free(){} // RVA: 0x7FFACBE2AA00
        public void SetDictionary(){} // RVA: 0x7FFACBE2AB20
        public void SyncPoint(){} // RVA: 0x7FFACBBC0B90
        public void Flush(){} // RVA: 0x7FFACBE2AB70
        public void .cctor(){} // RVA: 0x7FFACBE2AD10
    }

    public class InflateCodes : Object
    {
        public int START;
        public int LEN;
        public int LENEXT;
        public int DIST;
        public int DISTEXT;
        public int COPY;
        public int LIT;
        public int WASH;
        public int END;
        public int BADCODE;
        public int mode; // 0x10
        public int len; // 0x14
        public int[] tree; // 0x18
        public int tree_index; // 0x20
        public int need; // 0x24
        public int lit; // 0x28
        public int bitsToGet; // 0x2C
        public int dist; // 0x30
        public byte lbits; // 0x34
        public byte dbits; // 0x35
        public int[] ltree; // 0x38
        public int ltree_index; // 0x40
        public int[] dtree; // 0x48
        public int dtree_index; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBBC0EB0
        public void Process(){} // RVA: 0x7FFACBE2AED0
        public void InflateFast(){} // RVA: 0x7FFACBE2BA90
    }

    public class InflateManager : Object
    {
        public int HandleRfc1950HeaderBytes;
        public int Z_DEFLATED;
        public 0x6B0AAAA0 mode; // 0x10
        public BestHTTP.Decompression.Zlib.ZlibCodec _codec; // 0x18
        public int method; // 0x20
        public uint computedCheck; // 0x24
        public uint expectedCheck; // 0x28
        public int marker; // 0x2C
        public bool _handleRfc1950HeaderBytes; // 0x30
        public int wbits; // 0x34
        public BestHTTP.Decompression.Zlib.InflateBlocks blocks; // 0x38
        public byte[] mark;

        // ── Methods ──
        public void get_HandleRfc1950HeaderBytes(){} // RVA: 0x7FFAC2F47450
        public void set_HandleRfc1950HeaderBytes(){} // RVA: 0x7FFAC2F47460
        public void .ctor(){} // RVA: 0x7FFAC2F47460 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBE2C430
        public void End(){} // RVA: 0x7FFACBE2C4D0
        public void Initialize(){} // RVA: 0x7FFACBE2C670
        public void Inflate(){} // RVA: 0x7FFACBE2C8E0
        public void SetDictionary(){} // RVA: 0x7FFACBE2D3C0
        public void Sync(){} // RVA: 0x7FFACBE2D560
        public void SyncPoint(){} // RVA: 0x7FFACBE2D760
        public void .cctor(){} // RVA: 0x7FFACBE2D790
    }

    public class InternalConstants : Object
    {
        public int MAX_BITS;
        public int BL_CODES; // 0x4
        public int D_CODES; // 0x8
        public int LITERALS; // 0xC
        public int LENGTH_CODES; // 0x10
        public int L_CODES; // 0x14
        public int MAX_BL_BITS; // 0x18
        public int REP_3_6; // 0x1C
        public int REPZ_3_10; // 0x20
        public int REPZ_11_138; // 0x24

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBE2F280
    }

    public class InternalInflateConstants : Object
    {
        public int[] InflateMask;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBE2ADF0
    }

    public class SharedUtils : Object
    {
        // ── Methods ──
        public void URShift(){} // RVA: 0x7FFACBE2F120
        public void ReadInput(){} // RVA: 0x7FFACBE2F130
        public void ToByteArray(){} // RVA: 0x7FFACBA72BF0
        public void ToCharArray(){} // RVA: 0x7FFACBE2F240
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StaticTree : Object
    {
        public short[] lengthAndLiteralsTreeCodes;
        public short[] distTreeCodes; // 0x8
        public BestHTTP.Decompression.Zlib.StaticTree Literals; // 0x10
        public BestHTTP.Decompression.Zlib.StaticTree Distances; // 0x18
        public BestHTTP.Decompression.Zlib.StaticTree BitLengths; // 0x20
        public short[] treeCodes; // 0x10
        public int[] extraBits; // 0x18
        public int extraBase; // 0x20
        public int elems; // 0x24
        public int maxLength; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBC5250
        public void .cctor(){} // RVA: 0x7FFACBE2F380
    }

    public class ZTree : Object
    {
        public int HEAP_SIZE;
        public int[] ExtraLengthBits; // 0x8
        public int[] ExtraDistanceBits; // 0x10
        public int[] extra_blbits; // 0x18
        public sbyte[] bl_order; // 0x20
        public int Buf_size;
        public sbyte[] _dist_code; // 0x28
        public sbyte[] LengthCode; // 0x30
        public int[] LengthBase; // 0x38
        public int[] DistanceBase; // 0x40
        public short[] dyn_tree; // 0x10
        public int max_code; // 0x18
        public BestHTTP.Decompression.Zlib.StaticTree staticTree; // 0x20

        // ── Methods ──
        public void DistanceCode(){} // RVA: 0x7FFACBE32CE0
        public void gen_bitlen(){} // RVA: 0x7FFACBE32DA0
        public void build_tree(){} // RVA: 0x7FFACBE33200
        public void gen_codes(){} // RVA: 0x7FFACBE33770
        public void bi_reverse(){} // RVA: 0x7FFACBBC9AA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBE33950
    }

    public class ZlibBaseStream : Stream
    {
        public BestHTTP.Decompression.Zlib.ZlibCodec Crc32; // 0x28
        public 0x6B0AAF18 _wantCompress; // 0x30
        public 0x6B0AABA8 z; // 0x34
        public 0x6B0AAEC0 workingBuffer; // 0x38
        public 0x6B0AACB0 CanRead; // 0x3C
        public 0x6B0AAC00 CanSeek; // 0x40
        public bool CanWrite; // 0x44
        public byte[] Length; // 0x48
        public int Position; // 0x50
        public int windowBitsMax; // 0x54
        public byte[] _buf1; // 0x58
        public System.IO.Stream _stream; // 0x60
        public 0x6B0AAC58 Strategy; // 0x68
        public BestHTTP.Decompression.Crc.CRC32 crc; // 0x70
        public string _GzipFileName; // 0x78
        public string _GzipComment; // 0x80
        public System.DateTime _GzipMtime; // 0x88
        public int _gzipHeaderByteCount; // 0x90
        public bool nomoreinput; // 0x94

        // ── Methods ──
        public void get_Crc32(){} // RVA: 0x7FFACBE2FBB0
        public void .ctor(){} // RVA: 0x7FFACBE2FC00 | overloaded x2
        public void get__wantCompress(){} // RVA: 0x7FFACBE2FE00
        public void get_z(){} // RVA: 0x7FFACBE2FE10
        public void get_workingBuffer(){} // RVA: 0x7FFACBE2FF40
        public void Write(){} // RVA: 0x7FFACBE30000
        public void finish(){} // RVA: 0x7FFACBE303F0
        public void end(){} // RVA: 0x7FFACBE30CE0
        public void Close(){} // RVA: 0x7FFACBE30FC0
        public void Flush(){} // RVA: 0x7FFACBE310D0
        public void Seek(){} // RVA: 0x7FFACBE31100
        public void SetLength(){} // RVA: 0x7FFACBE31140
        public void ReadZeroTerminatedString(){} // RVA: 0x7FFACBE31180
        public void _ReadAndValidateGzipHeader(){} // RVA: 0x7FFACBE313A0
        public void Read(){} // RVA: 0x7FFACBE31830
        public void get_CanRead(){} // RVA: 0x7FFACBE31E90
        public void get_CanSeek(){} // RVA: 0x7FFACBE31EC0
        public void get_CanWrite(){} // RVA: 0x7FFACBE31EF0
        public void get_Length(){} // RVA: 0x7FFACBE31F20
        public void get_Position(){} // RVA: 0x7FFACBE31F50
        public void set_Position(){} // RVA: 0x7FFACBE31F90
    }

    public class ZlibCodec : Object
    {
        public byte[] Adler32; // 0x10
        public int NextIn; // 0x18
        public int AvailableBytesIn; // 0x1C
        public long TotalBytesIn; // 0x20
        public byte[] OutputBuffer; // 0x28
        public int NextOut; // 0x30
        public int AvailableBytesOut; // 0x34
        public long TotalBytesOut; // 0x38
        public string Message; // 0x40
        public BestHTTP.Decompression.Zlib.DeflateManager dstate; // 0x48
        public BestHTTP.Decompression.Zlib.InflateManager istate; // 0x50
        public uint _Adler32; // 0x58
        public 0x6B0AAC00 CompressLevel; // 0x5C
        public int WindowBits; // 0x60
        public 0x6B0AAC58 Strategy; // 0x64

        // ── Methods ──
        public void get_Adler32(){} // RVA: 0x7FFAC362EA40
        public void .ctor(){} // RVA: 0x7FFACBE31FE0 | overloaded x2
        public void InitializeInflate(){} // RVA: 0x7FFACBE32150 | overloaded x4
        public void Inflate(){} // RVA: 0x7FFACBE32270
        public void EndInflate(){} // RVA: 0x7FFACBE322E0
        public void SyncInflate(){} // RVA: 0x7FFACBE323B0
        public void InitializeDeflate(){} // RVA: 0x7FFACBE32480 | overloaded x5
        public void _InternalInitializeDeflate(){} // RVA: 0x7FFACBE324A0
        public void Deflate(){} // RVA: 0x7FFACBE32650
        public void EndDeflate(){} // RVA: 0x7FFACBE326C0
        public void ResetDeflate(){} // RVA: 0x7FFACBE32770
        public void SetDeflateParams(){} // RVA: 0x7FFACBE327E0
        public void SetDictionary(){} // RVA: 0x7FFACBE32970
        public void flush_pending(){} // RVA: 0x7FFACBE32A10
        public void read_buf(){} // RVA: 0x7FFACBE32BD0
    }

    public class ZlibConstants : Object
    {
        public int WindowBitsMax;
        public int WindowBitsDefault;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_BUF_ERROR;
        public int WorkingBufferSizeDefault;
        public int WorkingBufferSizeMin;
    }

    public class ZlibException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE2F0C0 | overloaded x2
    }

}