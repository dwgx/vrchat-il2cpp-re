// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
// Classes: 14
// Methods: 186

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
    public class Adler32 : Object
    {
        public int BASE;
        public int NMAX;

        // ── Methods ──
        public void adler32(){} // RVA: 0x7FFACBA72D40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Deflate : Object
    {
        public int MAX_MEM_LEVEL;
        public int Z_DEFAULT_COMPRESSION;
        public int MAX_WBITS;
        public int DEF_MEM_LEVEL;
        public int STORED;
        public int FAST;
        public int SLOW;
        public Config[] config_table;
        public string[] z_errmsg; // 0x8
        public int NeedMore;
        public int BlockDone;
        public int FinishStarted;
        public int FinishDone;
        public int PRESET_DICT;
        public int Z_FILTERED;
        public int Z_HUFFMAN_ONLY;
        public int Z_DEFAULT_STRATEGY;
        public int Z_NO_FLUSH;
        public int Z_PARTIAL_FLUSH;
        public int Z_SYNC_FLUSH;
        public int Z_FULL_FLUSH;
        public int Z_FINISH;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;
        public int INIT_STATE;
        public int BUSY_STATE;
        public int FINISH_STATE;
        public int Z_DEFLATED;
        public int STORED_BLOCK;
        public int STATIC_TREES;
        public int DYN_TREES;
        public int Z_BINARY;
        public int Z_ASCII;
        public int Z_UNKNOWN;
        public int Buf_size;
        public int REP_3_6;
        public int REPZ_3_10;
        public int REPZ_11_138;
        public int MIN_MATCH;
        public int MAX_MATCH;
        public int MIN_LOOKAHEAD;
        public int MAX_BITS;
        public int D_CODES;
        public int BL_CODES;
        public int LENGTH_CODES;
        public int LITERALS;
        public int L_CODES;
        public int HEAP_SIZE;
        public int END_BLOCK;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream strm; // 0x10
        public int status; // 0x18
        public byte[] pending_buf; // 0x20
        public int pending_buf_size; // 0x28
        public int pending_out; // 0x2C
        public int pending; // 0x30
        public int noheader; // 0x34
        public byte data_type; // 0x38
        public byte method; // 0x39
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
        public int match_length; // 0x88
        public int prev_match; // 0x8C
        public int match_available; // 0x90
        public int strstart; // 0x94
        public int match_start; // 0x98
        public int lookahead; // 0x9C
        public int prev_length; // 0xA0
        public int max_chain_length; // 0xA4
        public int max_lazy_match; // 0xA8
        public int level; // 0xAC
        public int strategy; // 0xB0
        public int good_match; // 0xB4
        public int nice_match; // 0xB8
        public short[] dyn_ltree; // 0xC0
        public short[] dyn_dtree; // 0xC8
        public short[] bl_tree; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZTree l_desc; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZTree d_desc; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZTree bl_desc; // 0xE8
        public short[] bl_count; // 0xF0
        public int[] heap; // 0xF8
        public int heap_len; // 0x100
        public int heap_max; // 0x104
        public byte[] depth; // 0x108
        public int l_buf; // 0x110
        public int lit_bufsize; // 0x114
        public int last_lit; // 0x118
        public int d_buf; // 0x11C
        public int opt_len; // 0x120
        public int static_len; // 0x124
        public int matches; // 0x128
        public int last_eob_len; // 0x12C
        public uint bi_buf; // 0x130
        public int bi_valid; // 0x134

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBBBA170
        public void .ctor(){} // RVA: 0x7FFACBBBA970
        public void lm_init(){} // RVA: 0x7FFACBBBAD70
        public void tr_init(){} // RVA: 0x7FFACBBBAF60
        public void init_block(){} // RVA: 0x7FFACBBBB270
        public void pqdownheap(){} // RVA: 0x7FFACBBBB360
        public void smaller(){} // RVA: 0x7FFACBBBB5C0
        public void scan_tree(){} // RVA: 0x7FFACBBBB640
        public void build_bl_tree(){} // RVA: 0x7FFACBBBB810
        public void send_all_trees(){} // RVA: 0x7FFACBBBB950
        public void send_tree(){} // RVA: 0x7FFACBBBBAB0
        public void put_byte(){} // RVA: 0x7FFACBBBBDC0 | overloaded x2
        public void put_short(){} // RVA: 0x7FFACBBBBE00
        public void putShortMSB(){} // RVA: 0x7FFACBBBBE60
        public void send_code(){} // RVA: 0x7FFACBBBBEC0
        public void send_bits(){} // RVA: 0x7FFACBBBBF10
        public void _tr_align(){} // RVA: 0x7FFACBBBBFE0
        public void _tr_tally(){} // RVA: 0x7FFACBBBC140
        public void compress_block(){} // RVA: 0x7FFACBBBC3F0
        public void set_data_type(){} // RVA: 0x7FFACBBBC750
        public void bi_flush(){} // RVA: 0x7FFACBBBC820
        public void bi_windup(){} // RVA: 0x7FFACBBBC8F0
        public void copy_block(){} // RVA: 0x7FFACBBBC9B0
        public void flush_block_only(){} // RVA: 0x7FFACBBBCAD0
        public void deflate_stored(){} // RVA: 0x7FFACBBBCB40
        public void _tr_stored_block(){} // RVA: 0x7FFACBBBCD10
        public void _tr_flush_block(){} // RVA: 0x7FFACBBBCE30
        public void fill_window(){} // RVA: 0x7FFACBBBD300
        public void deflate_fast(){} // RVA: 0x7FFACBBBD5C0
        public void deflate_slow(){} // RVA: 0x7FFACBBBDA30
        public void longest_match(){} // RVA: 0x7FFACBBBDF30
        public void deflateInit(){} // RVA: 0x7FFACBBBE340 | overloaded x2
        public void deflateInit2(){} // RVA: 0x7FFACBBBE370
        public void deflateReset(){} // RVA: 0x7FFACBBBE6B0
        public void deflateEnd(){} // RVA: 0x7FFACBBBE7A0
        public void deflateParams(){} // RVA: 0x7FFACBBBE920
        public void deflateSetDictionary(){} // RVA: 0x7FFACBBBEB90
        public void deflate(){} // RVA: 0x7FFACBBBED70
    }

    public class InfBlocks : Object
    {
        public int MANY;
        public int[] inflate_mask;
        public int[] border; // 0x8
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;
        public int TYPE;
        public int LENS;
        public int STORED;
        public int TABLE;
        public int BTREE;
        public int DTREE;
        public int CODES;
        public int DRY;
        public int DONE;
        public int BAD;
        public int mode; // 0x10
        public int left; // 0x14
        public int table; // 0x18
        public int index; // 0x1C
        public int[] blens; // 0x20
        public int[] bb; // 0x28
        public int[] tb; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.InfCodes codes; // 0x38
        public int last; // 0x40
        public int bitk; // 0x44
        public int bitb; // 0x48
        public int[] hufts; // 0x50
        public byte[] window; // 0x58
        public int end; // 0x60
        public int read; // 0x64
        public int write; // 0x68
        public object checkfn; // 0x70
        public long check; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.InfTree inftree; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBBF390
        public void reset(){} // RVA: 0x7FFACBBBF700
        public void proc(){} // RVA: 0x7FFACBBBF790
        public void free(){} // RVA: 0x7FFACBBC0A10
        public void set_dictionary(){} // RVA: 0x7FFACBBC0B40
        public void sync_point(){} // RVA: 0x7FFACBBC0B90
        public void inflate_flush(){} // RVA: 0x7FFACBBC0BA0
        public void .cctor(){} // RVA: 0x7FFACBBC0D10
    }

    public class InfCodes : Object
    {
        public int[] inflate_mask;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;
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
        public int get; // 0x2C
        public int dist; // 0x30
        public byte lbits; // 0x34
        public byte dbits; // 0x35
        public int[] ltree; // 0x38
        public int ltree_index; // 0x40
        public int[] dtree; // 0x48
        public int dtree_index; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void init(){} // RVA: 0x7FFACBBC0EB0
        public void proc(){} // RVA: 0x7FFACBBC0FE0
        public void free(){} // RVA: 0x7FFAC2F21310
        public void inflate_fast(){} // RVA: 0x7FFACBBC1B70
        public void .cctor(){} // RVA: 0x7FFACBBC2510
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
        public void huft_build(){} // RVA: 0x7FFACBBC3A10
        public void inflate_trees_bits(){} // RVA: 0x7FFACBBC4350
        public void inflate_trees_dynamic(){} // RVA: 0x7FFACBBC4550
        public void inflate_trees_fixed(){} // RVA: 0x7FFACBBC4930
        public void initWorkArea(){} // RVA: 0x7FFACBBC4A20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBC4DF0
    }

    public class Inflate : Object
    {
        public int MAX_WBITS;
        public int PRESET_DICT;
        public int Z_NO_FLUSH;
        public int Z_PARTIAL_FLUSH;
        public int Z_SYNC_FLUSH;
        public int Z_FULL_FLUSH;
        public int Z_FINISH;
        public int Z_DEFLATED;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;
        public int METHOD;
        public int FLAG;
        public int DICT4;
        public int DICT3;
        public int DICT2;
        public int DICT1;
        public int DICT0;
        public int BLOCKS;
        public int CHECK4;
        public int CHECK3;
        public int CHECK2;
        public int CHECK1;
        public int DONE;
        public int BAD;
        public int mode; // 0x10
        public int method; // 0x14
        public long[] was; // 0x18
        public long need; // 0x20
        public int marker; // 0x28
        public int nowrap; // 0x2C
        public int wbits; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.InfBlocks blocks; // 0x38
        public byte[] mark;

        // ── Methods ──
        public void inflateReset(){} // RVA: 0x7FFACBBC25F0
        public void inflateEnd(){} // RVA: 0x7FFACBBC2700
        public void inflateInit(){} // RVA: 0x7FFACBBC28A0
        public void inflate(){} // RVA: 0x7FFACBBC2C00
        public void inflateSetDictionary(){} // RVA: 0x7FFACBBC3530
        public void inflateSync(){} // RVA: 0x7FFACBBC3680
        public void inflateSyncPoint(){} // RVA: 0x7FFACBBC3870
        public void .ctor(){} // RVA: 0x7FFACBBC38A0
        public void .cctor(){} // RVA: 0x7FFACBBC3930
    }

    public class JZlib : Object
    {
        public string _version;
        public int Z_NO_COMPRESSION;
        public int Z_BEST_SPEED;
        public int Z_BEST_COMPRESSION;
        public int Z_DEFAULT_COMPRESSION;
        public int Z_FILTERED;
        public int Z_HUFFMAN_ONLY;
        public int Z_DEFAULT_STRATEGY;
        public int Z_NO_FLUSH;
        public int Z_PARTIAL_FLUSH;
        public int Z_SYNC_FLUSH;
        public int Z_FULL_FLUSH;
        public int Z_FINISH;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;

        // ── Methods ──
        public void version(){} // RVA: 0x7FFACBBC5210
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StaticTree : Object
    {
        public int MAX_BITS;
        public int BL_CODES;
        public int D_CODES;
        public int LITERALS;
        public int LENGTH_CODES;
        public int L_CODES;
        public int MAX_BL_BITS;
        public short[] static_ltree;
        public short[] static_dtree; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.StaticTree static_l_desc; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.StaticTree static_d_desc; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.StaticTree static_bl_desc; // 0x20
        public short[] static_tree; // 0x10
        public int[] extra_bits; // 0x18
        public int extra_base; // 0x20
        public int elems; // 0x24
        public int max_length; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBC5250
        public void .cctor(){} // RVA: 0x7FFACBBC5320
    }

    public class ZDeflaterOutputStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream CanRead; // 0x28
        public int CanSeek; // 0x30
        public int CanWrite;
        public byte[] Length; // 0x38
        public byte[] Position; // 0x40
        public System.IO.Stream outp; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBC57B0 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void get_Length(){} // RVA: 0x7FFAC34F9180
        public void get_Position(){} // RVA: 0x7FFAC34F9180
        public void set_Position(){} // RVA: 0x7FFAC2F21310
        public void Write(){} // RVA: 0x7FFACBBC59F0
        public void Seek(){} // RVA: 0x7FFAC34F9180
        public void SetLength(){} // RVA: 0x7FFAC2F21310
        public void Read(){} // RVA: 0x7FFAC34F9180
        public void Flush(){} // RVA: 0x7FFACBBC5C40
        public void WriteByte(){} // RVA: 0x7FFACBBC5C70
        public void Finish(){} // RVA: 0x7FFACBBC5CC0
        public void End(){} // RVA: 0x7FFACBBC5E90
        public void Close(){} // RVA: 0x7FFACBBC5F20
    }

    public class ZInflaterInputStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream CanRead; // 0x28
        public int CanSeek; // 0x30
        public int CanWrite;
        public byte[] Length; // 0x38
        public byte[] Position; // 0x40
        public System.IO.Stream inp; // 0x48
        public bool nomoreinput; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBC6120 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC34F9180
        public void get_Position(){} // RVA: 0x7FFAC34F9180
        public void set_Position(){} // RVA: 0x7FFAC2F21310
        public void Write(){} // RVA: 0x7FFAC2F21310
        public void Seek(){} // RVA: 0x7FFAC34F9180
        public void SetLength(){} // RVA: 0x7FFAC2F21310
        public void Read(){} // RVA: 0x7FFACBBC63D0
        public void Flush(){} // RVA: 0x7FFACBBC5C40
        public void WriteByte(){} // RVA: 0x7FFAC2F21310
        public void Close(){} // RVA: 0x7FFACBBC6610
        public void ReadByte(){} // RVA: 0x7FFACBBC6690
    }

    public class ZInputStream : Stream
    {
        public int CanRead;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream CanSeek; // 0x28
        public int CanWrite; // 0x30
        public byte[] FlushMode; // 0x38
        public byte[] Length; // 0x40
        public bool Position; // 0x48
        public System.IO.Stream TotalIn; // 0x50
        public bool TotalOut; // 0x58
        public bool nomoreinput; // 0x59

        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x7FFACBBC6700
        public void .ctor(){} // RVA: 0x7FFACBBC6BC0 | overloaded x5
        public void get_CanRead(){} // RVA: 0x7FFACBBC6E70
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void Close(){} // RVA: 0x7FFACBBC6E80
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void get_FlushMode(){} // RVA: 0x7FFAC2F7CCD0
        public void set_FlushMode(){} // RVA: 0x7FFAC2F7CCE0
        public void get_Length(){} // RVA: 0x7FFACBBC6F10
        public void get_Position(){} // RVA: 0x7FFACBBC6F50
        public void set_Position(){} // RVA: 0x7FFACBBC6F90
        public void Read(){} // RVA: 0x7FFACBBC6FD0
        public void ReadByte(){} // RVA: 0x7FFACBBC6690
        public void Seek(){} // RVA: 0x7FFACBBC7260
        public void SetLength(){} // RVA: 0x7FFACBBC72A0
        public void get_TotalIn(){} // RVA: 0x7FFAC69A40A0
        public void get_TotalOut(){} // RVA: 0x7FFAC8803740
        public void Write(){} // RVA: 0x7FFACBBC72E0
    }

    public class ZOutputStream : Stream
    {
        public int CanRead;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream CanSeek; // 0x28
        public int CanWrite; // 0x30
        public byte[] FlushMode; // 0x38
        public byte[] Length; // 0x40
        public bool Position; // 0x48
        public System.IO.Stream TotalIn; // 0x50
        public bool TotalOut; // 0x58

        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x7FFACBBC7320
        public void .ctor(){} // RVA: 0x7FFACBBC7760 | overloaded x5
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFACBBC6E70
        public void Close(){} // RVA: 0x7FFACBBC79A0
        public void DoClose(){} // RVA: 0x7FFACBBC79D0
        public void End(){} // RVA: 0x7FFACBBC7B40
        public void Finish(){} // RVA: 0x7FFACBBC7C70
        public void Flush(){} // RVA: 0x7FFACBBC7EA0
        public void get_FlushMode(){} // RVA: 0x7FFAC2F7CCD0
        public void set_FlushMode(){} // RVA: 0x7FFAC2F7CCE0
        public void get_Length(){} // RVA: 0x7FFACBBC7ED0
        public void get_Position(){} // RVA: 0x7FFACBBC7F10
        public void set_Position(){} // RVA: 0x7FFACBBC7F50
        public void Read(){} // RVA: 0x7FFACBBC7F90
        public void Seek(){} // RVA: 0x7FFACBBC7FD0
        public void SetLength(){} // RVA: 0x7FFACBBC8010
        public void get_TotalIn(){} // RVA: 0x7FFAC69A40A0
        public void get_TotalOut(){} // RVA: 0x7FFAC8803740
        public void Write(){} // RVA: 0x7FFACBBC8050
        public void WriteByte(){} // RVA: 0x7FFACBBC5C70
    }

    public class ZStream : Object
    {
        public int MAX_WBITS;
        public int DEF_WBITS;
        public int Z_NO_FLUSH;
        public int Z_PARTIAL_FLUSH;
        public int Z_SYNC_FLUSH;
        public int Z_FULL_FLUSH;
        public int Z_FINISH;
        public int MAX_MEM_LEVEL;
        public int Z_OK;
        public int Z_STREAM_END;
        public int Z_NEED_DICT;
        public int Z_ERRNO;
        public int Z_STREAM_ERROR;
        public int Z_DATA_ERROR;
        public int Z_MEM_ERROR;
        public int Z_BUF_ERROR;
        public int Z_VERSION_ERROR;
        public byte[] next_in; // 0x10
        public int next_in_index; // 0x18
        public int avail_in; // 0x1C
        public long total_in; // 0x20
        public byte[] next_out; // 0x28
        public int next_out_index; // 0x30
        public int avail_out; // 0x34
        public long total_out; // 0x38
        public string msg; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.Deflate dstate; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.Inflate istate; // 0x50
        public int data_type; // 0x58
        public long adler; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.Adler32 _adler; // 0x68

        // ── Methods ──
        public void inflateInit(){} // RVA: 0x7FFACBBC8330 | overloaded x4
        public void inflate(){} // RVA: 0x7FFACBBC84A0
        public void inflateEnd(){} // RVA: 0x7FFACBBC84C0
        public void inflateSync(){} // RVA: 0x7FFACBBC8550
        public void inflateSetDictionary(){} // RVA: 0x7FFACBBC8570
        public void deflateInit(){} // RVA: 0x7FFACBBC8730 | overloaded x4
        public void deflate(){} // RVA: 0x7FFACBBC8830
        public void deflateEnd(){} // RVA: 0x7FFACBBC8850
        public void deflateParams(){} // RVA: 0x7FFACBBC8A50
        public void deflateSetDictionary(){} // RVA: 0x7FFACBBC8A90
        public void flush_pending(){} // RVA: 0x7FFACBBC8AD0
        public void read_buf(){} // RVA: 0x7FFACBBC8B90
        public void free(){} // RVA: 0x7FFACBBC8C50
        public void .ctor(){} // RVA: 0x7FFACBBC8DA0
    }

    public class ZTree : Object
    {
        public int MAX_BITS;
        public int BL_CODES;
        public int D_CODES;
        public int LITERALS;
        public int LENGTH_CODES;
        public int L_CODES;
        public int HEAP_SIZE;
        public int MAX_BL_BITS;
        public int END_BLOCK;
        public int REP_3_6;
        public int REPZ_3_10;
        public int REPZ_11_138;
        public int[] extra_lbits;
        public int[] extra_dbits; // 0x8
        public int[] extra_blbits; // 0x10
        public byte[] bl_order; // 0x18
        public int Buf_size;
        public int DIST_CODE_LEN;
        public byte[] _dist_code; // 0x20
        public byte[] _length_code; // 0x28
        public int[] base_length; // 0x30
        public int[] base_dist; // 0x38
        public short[] dyn_tree; // 0x10
        public int max_code; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.StaticTree stat_desc; // 0x20

        // ── Methods ──
        public void d_code(){} // RVA: 0x7FFACBBC8E30
        public void gen_bitlen(){} // RVA: 0x7FFACBBC8EF0
        public void build_tree(){} // RVA: 0x7FFACBBC92B0
        public void gen_codes(){} // RVA: 0x7FFACBBC9900
        public void bi_reverse(){} // RVA: 0x7FFACBBC9AA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBC9AD0
    }

}