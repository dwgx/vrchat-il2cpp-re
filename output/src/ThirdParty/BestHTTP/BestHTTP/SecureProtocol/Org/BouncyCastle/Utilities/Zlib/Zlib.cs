// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
// Classes: 14
// Methods: 167

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
    public class Adler32 : Object
    {
        public object BASE;
        public object NMAX;

        // ── Methods ──
        public void adler32(){} // RVA: 0xA1096A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Deflate : Object
    {
        public object MAX_MEM_LEVEL;
        public object Z_DEFAULT_COMPRESSION;
        public object MAX_WBITS;
        public object DEF_MEM_LEVEL;
        public object STORED;
        public object FAST;
        public object SLOW;
        public object config_table;
        public object z_errmsg;
        public object NeedMore;
        public object BlockDone;
        public object FinishStarted;
        public object FinishDone;
        public object PRESET_DICT;
        public object Z_FILTERED;
        public object Z_HUFFMAN_ONLY;
        public object Z_DEFAULT_STRATEGY;
        public object Z_NO_FLUSH;
        public object Z_PARTIAL_FLUSH;
        public object Z_SYNC_FLUSH;
        public object Z_FULL_FLUSH;
        public object Z_FINISH;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;
        public object INIT_STATE;
        public object BUSY_STATE;
        public object FINISH_STATE;
        public object Z_DEFLATED;
        public object STORED_BLOCK;
        public object STATIC_TREES;
        public object DYN_TREES;
        public object Z_BINARY;
        public object Z_ASCII;
        public object Z_UNKNOWN;
        public object Buf_size;
        public object REP_3_6;
        public object REPZ_3_10;
        public object REPZ_11_138;
        public object MIN_MATCH;
        public object MAX_MATCH;
        public object MIN_LOOKAHEAD;
        public object MAX_BITS;
        public object D_CODES;
        public object BL_CODES;
        public object LENGTH_CODES;
        public object LITERALS;
        public object L_CODES;
        public object HEAP_SIZE;
        public object END_BLOCK;
        public object strm;
        public object status;
        public object pending_buf;
        public object pending_buf_size;
        public object pending_out;
        public object pending;
        public object noheader;
        public object data_type;
        public object method;
        public object last_flush;
        public object w_size;
        public object w_bits;
        public object w_mask;
        public object window;
        public object window_size;
        public object prev;
        public object head;
        public object ins_h;
        public object hash_size;
        public object hash_bits;
        public object hash_mask;
        public object hash_shift;
        public object block_start;
        public object match_length;
        public object prev_match;
        public object match_available;
        public object strstart;
        public object match_start;
        public object lookahead;
        public object prev_length;
        public object max_chain_length;
        public object max_lazy_match;
        public object level;
        public object strategy;
        public object good_match;
        public object nice_match;
        public object dyn_ltree;
        public object dyn_dtree;
        public object bl_tree;
        public object l_desc;
        public object d_desc;
        public object bl_desc;
        public object bl_count;
        public object heap;
        public object heap_len;
        public object heap_max;
        public object depth;
        public object l_buf;
        public object lit_bufsize;
        public object last_lit;
        public object d_buf;
        public object opt_len;
        public object static_len;
        public object matches;
        public object last_eob_len;
        public object bi_buf;
        public object bi_valid;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA253610
        public void .ctor(){} // RVA: 0xA253E10
        public void lm_init(){} // RVA: 0xA254210
        public void tr_init(){} // RVA: 0xA254400
        public void init_block(){} // RVA: 0xA254710
        public void pqdownheap(){} // RVA: 0xA254810
        public void smaller(){} // RVA: 0xA254A80
        public void scan_tree(){} // RVA: 0xA254B00
        public void build_bl_tree(){} // RVA: 0xA254CE0
        public void send_all_trees(){} // RVA: 0xA254E30
        public void send_tree(){} // RVA: 0xA254FA0
        public void put_byte(){} // RVA: 0xA2552B0
        public void put_short(){} // RVA: 0xA2552F0
        public void putShortMSB(){} // RVA: 0xA255350
        public void send_code(){} // RVA: 0xA2553B0
        public void send_bits(){} // RVA: 0xA255400
        public void _tr_align(){} // RVA: 0xA2554E0
        public void _tr_tally(){} // RVA: 0xA255640
        public void compress_block(){} // RVA: 0xA2558F0
        public void set_data_type(){} // RVA: 0xA255C50
        public void bi_flush(){} // RVA: 0xA255D40
        public void bi_windup(){} // RVA: 0xA255E10
        public void copy_block(){} // RVA: 0xA255ED0
        public void flush_block_only(){} // RVA: 0xA255FF0
        public void deflate_stored(){} // RVA: 0xA256060
        public void _tr_stored_block(){} // RVA: 0xA256230
        public void _tr_flush_block(){} // RVA: 0xA256350
        public void fill_window(){} // RVA: 0xA256830
        public void deflate_fast(){} // RVA: 0xA256AE0
        public void deflate_slow(){} // RVA: 0xA256F40
        public void longest_match(){} // RVA: 0xA257420
        public void deflateInit(){} // RVA: 0xA257880
        public void deflateInit2(){} // RVA: 0xA2578B0
        public void deflateReset(){} // RVA: 0xA257BF0
        public void deflateEnd(){} // RVA: 0xA257CE0
        public void deflateParams(){} // RVA: 0xA257E60
        public void deflateSetDictionary(){} // RVA: 0xA2580D0
        public void deflate(){} // RVA: 0xA2582A0
    }

    public class InfBlocks : Object
    {
        public object MANY;
        public object inflate_mask;
        public object border;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;
        public object TYPE;
        public object LENS;
        public object STORED;
        public object TABLE;
        public object BTREE;
        public object DTREE;
        public object CODES;
        public object DRY;
        public object DONE;
        public object BAD;
        public object mode;
        public object left;
        public object table;
        public object index;
        public object blens;
        public object bb;
        public object tb;
        public object codes;
        public object last;
        public object bitk;
        public object bitb;
        public object hufts;
        public object window;
        public object end;
        public object read;
        public object write;
        public object checkfn;
        public object check;
        public object inftree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2588C0
        public void reset(){} // RVA: 0xA258C40
        public void proc(){} // RVA: 0xA258CD0
        public void free(){} // RVA: 0xA25A190
        public void set_dictionary(){} // RVA: 0xA25A2C0
        public void sync_point(){} // RVA: 0xA25A310
        public void inflate_flush(){} // RVA: 0xA25A320
        public void .cctor(){} // RVA: 0xA25A490
    }

    public class InfCodes : Object
    {
        public object inflate_mask;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;
        public object START;
        public object LEN;
        public object LENEXT;
        public object DIST;
        public object DISTEXT;
        public object COPY;
        public object LIT;
        public object WASH;
        public object END;
        public object BADCODE;
        public object mode;
        public object len;
        public object tree;
        public object tree_index;
        public object need;
        public object lit;
        public object get;
        public object dist;
        public object lbits;
        public object dbits;
        public object ltree;
        public object ltree_index;
        public object dtree;
        public object dtree_index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void init(){} // RVA: 0xA25A630
        public void proc(){} // RVA: 0xA25A760
        public void free(){} // RVA: 0xB43310
        public void inflate_fast(){} // RVA: 0xA25B3F0
        public void .cctor(){} // RVA: 0xA25BE10
    }

    public class InfTree : Object
    {
        public object MANY;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;
        public object fixed_bl;
        public object fixed_bd;
        public object fixed_tl;
        public object fixed_td;
        public object cplens;
        public object cplext;
        public object cpdist;
        public object cpdext;
        public object BMAX;
        public object hn;
        public object v;
        public object c;
        public object r;
        public object u;
        public object x;

        // ── Methods ──
        public void huft_build(){} // RVA: 0xA25D340
        public void inflate_trees_bits(){} // RVA: 0xA25DD20
        public void inflate_trees_dynamic(){} // RVA: 0xA25DF20
        public void inflate_trees_fixed(){} // RVA: 0xA25E310
        public void initWorkArea(){} // RVA: 0xA25E400
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA25E7F0
    }

    public class Inflate : Object
    {
        public object MAX_WBITS;
        public object PRESET_DICT;
        public object Z_NO_FLUSH;
        public object Z_PARTIAL_FLUSH;
        public object Z_SYNC_FLUSH;
        public object Z_FULL_FLUSH;
        public object Z_FINISH;
        public object Z_DEFLATED;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;
        public object METHOD;
        public object FLAG;
        public object DICT4;
        public object DICT3;
        public object DICT2;
        public object DICT1;
        public object DICT0;
        public object BLOCKS;
        public object CHECK4;
        public object CHECK3;
        public object CHECK2;
        public object CHECK1;
        public object DONE;
        public object BAD;
        public object mode;
        public object method;
        public object was;
        public object need;
        public object marker;
        public object nowrap;
        public object wbits;
        public object blocks;
        public object mark;

        // ── Methods ──
        public void inflateReset(){} // RVA: 0xA25BEF0
        public void inflateEnd(){} // RVA: 0xA25C000
        public void inflateInit(){} // RVA: 0xA25C1A0
        public void inflate(){} // RVA: 0xA25C500
        public void inflateSetDictionary(){} // RVA: 0xA25CE30
        public void inflateSync(){} // RVA: 0xA25CF80
        public void inflateSyncPoint(){} // RVA: 0xA25D1A0
        public void .ctor(){} // RVA: 0xA25D1D0
        public void .cctor(){} // RVA: 0xA25D260
    }

    public class JZlib : Object
    {
        public object _version;
        public object Z_NO_COMPRESSION;
        public object Z_BEST_SPEED;
        public object Z_BEST_COMPRESSION;
        public object Z_DEFAULT_COMPRESSION;
        public object Z_FILTERED;
        public object Z_HUFFMAN_ONLY;
        public object Z_DEFAULT_STRATEGY;
        public object Z_NO_FLUSH;
        public object Z_PARTIAL_FLUSH;
        public object Z_SYNC_FLUSH;
        public object Z_FULL_FLUSH;
        public object Z_FINISH;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;

        // ── Methods ──
        public void version(){} // RVA: 0xA25EC10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StaticTree : Object
    {
        public object MAX_BITS;
        public object BL_CODES;
        public object D_CODES;
        public object LITERALS;
        public object LENGTH_CODES;
        public object L_CODES;
        public object MAX_BL_BITS;
        public object static_ltree;
        public object static_dtree;
        public object static_l_desc;
        public object static_d_desc;
        public object static_bl_desc;
        public object static_tree;
        public object extra_bits;
        public object extra_base;
        public object elems;
        public object max_length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA25EC50
        public void .cctor(){} // RVA: 0xA25ED20
    }

    public class ZDeflaterOutputStream : Stream
    {
        public object z;
        public object flushLevel;
        public object BUFSIZE;
        public object buf;
        public object buf1;
        public object outp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA25F1B0
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void get_Length(){} // RVA: 0xDAC980
        public void get_Position(){} // RVA: 0xDAC980
        public void set_Position(){} // RVA: 0xB43310
        public void Write(){} // RVA: 0xA25F3F0
        public void Seek(){} // RVA: 0xDAC980
        public void SetLength(){} // RVA: 0xB43310
        public void Read(){} // RVA: 0xDAC980
        public void Flush(){} // RVA: 0xA25F650
        public void WriteByte(){} // RVA: 0xA25F680
        public void Finish(){} // RVA: 0xA25F6D0
        public void End(){} // RVA: 0xA25F8A0
        public void Close(){} // RVA: 0xA25F930
    }

    public class ZInflaterInputStream : Stream
    {
        public object z;
        public object flushLevel;
        public object BUFSIZE;
        public object buf;
        public object buf1;
        public object inp;
        public object nomoreinput;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA25FB30
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0xDAC980
        public void get_Position(){} // RVA: 0xDAC980
        public void set_Position(){} // RVA: 0xB43310
        public void Write(){} // RVA: 0xB43310
        public void Seek(){} // RVA: 0xDAC980
        public void SetLength(){} // RVA: 0xB43310
        public void Read(){} // RVA: 0xA25FDE0
        public void Flush(){} // RVA: 0xA25F650
        public void WriteByte(){} // RVA: 0xB43310
        public void Close(){} // RVA: 0xA260020
        public void ReadByte(){} // RVA: 0xA2600A0
    }

    public class ZInputStream : Stream
    {
        public object BufferSize;
        public object z;
        public object flushLevel;
        public object buf;
        public object buf1;
        public object compress;
        public object input;
        public object closed;
        public object nomoreinput;

        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0xA260110
        public void .ctor(){} // RVA: 0xA2605D0
        public void get_CanRead(){} // RVA: 0x5C6DCD0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xB43320
        public void Close(){} // RVA: 0xA2608A0
        public void Flush(){} // RVA: 0xB43310
        public void get_FlushMode(){} // RVA: 0xB9E080
        public void set_FlushMode(){} // RVA: 0xB9E090
        public void get_Length(){} // RVA: 0xA260930
        public void get_Position(){} // RVA: 0xA260970
        public void set_Position(){} // RVA: 0xA2609B0
        public void Read(){} // RVA: 0xA2609F0
        public void ReadByte(){} // RVA: 0xA2600A0
        public void Seek(){} // RVA: 0xA260C80
        public void SetLength(){} // RVA: 0xA260CC0
        public void get_TotalIn(){} // RVA: 0x4B53220
        public void get_TotalOut(){} // RVA: 0x6ADF9F0
        public void Write(){} // RVA: 0xA260D00
    }

    public class ZOutputStream : Stream
    {
        public object BufferSize;
        public object z;
        public object flushLevel;
        public object buf;
        public object buf1;
        public object compress;
        public object output;
        public object closed;

        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0xA260D40
        public void .ctor(){} // RVA: 0xA261180
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x5C6DCD0
        public void Close(){} // RVA: 0xA2613D0
        public void DoClose(){} // RVA: 0xA261400
        public void End(){} // RVA: 0xA261570
        public void Finish(){} // RVA: 0xA2616A0
        public void Flush(){} // RVA: 0xA2618D0
        public void get_FlushMode(){} // RVA: 0xB9E080
        public void set_FlushMode(){} // RVA: 0xB9E090
        public void get_Length(){} // RVA: 0xA261900
        public void get_Position(){} // RVA: 0xA261940
        public void set_Position(){} // RVA: 0xA261980
        public void Read(){} // RVA: 0xA2619C0
        public void Seek(){} // RVA: 0xA261A00
        public void SetLength(){} // RVA: 0xA261A40
        public void get_TotalIn(){} // RVA: 0x4B53220
        public void get_TotalOut(){} // RVA: 0x6ADF9F0
        public void Write(){} // RVA: 0xA261A80
        public void WriteByte(){} // RVA: 0xA25F680
    }

    public class ZStream : Object
    {
        public object MAX_WBITS;
        public object DEF_WBITS;
        public object Z_NO_FLUSH;
        public object Z_PARTIAL_FLUSH;
        public object Z_SYNC_FLUSH;
        public object Z_FULL_FLUSH;
        public object Z_FINISH;
        public object MAX_MEM_LEVEL;
        public object Z_OK;
        public object Z_STREAM_END;
        public object Z_NEED_DICT;
        public object Z_ERRNO;
        public object Z_STREAM_ERROR;
        public object Z_DATA_ERROR;
        public object Z_MEM_ERROR;
        public object Z_BUF_ERROR;
        public object Z_VERSION_ERROR;
        public object next_in;
        public object next_in_index;
        public object avail_in;
        public object total_in;
        public object next_out;
        public object next_out_index;
        public object avail_out;
        public object total_out;
        public object msg;
        public object dstate;
        public object istate;
        public object data_type;
        public object adler;
        public object _adler;

        // ── Methods ──
        public void inflateInit(){} // RVA: 0xA261D60
        public void inflate(){} // RVA: 0xA261ED0
        public void inflateEnd(){} // RVA: 0xA261EF0
        public void inflateSync(){} // RVA: 0xA261F80
        public void inflateSetDictionary(){} // RVA: 0xA261FA0
        public void deflateInit(){} // RVA: 0xA262160
        public void deflate(){} // RVA: 0xA262270
        public void deflateEnd(){} // RVA: 0xA262290
        public void deflateParams(){} // RVA: 0xA262490
        public void deflateSetDictionary(){} // RVA: 0xA2624D0
        public void flush_pending(){} // RVA: 0xA262510
        public void read_buf(){} // RVA: 0xA2625D0
        public void free(){} // RVA: 0xA262690
        public void .ctor(){} // RVA: 0xA2627E0
    }

    public class ZTree : Object
    {
        public object MAX_BITS;
        public object BL_CODES;
        public object D_CODES;
        public object LITERALS;
        public object LENGTH_CODES;
        public object L_CODES;
        public object HEAP_SIZE;
        public object MAX_BL_BITS;
        public object END_BLOCK;
        public object REP_3_6;
        public object REPZ_3_10;
        public object REPZ_11_138;
        public object extra_lbits;
        public object extra_dbits;
        public object extra_blbits;
        public object bl_order;
        public object Buf_size;
        public object DIST_CODE_LEN;
        public object _dist_code;
        public object _length_code;
        public object base_length;
        public object base_dist;
        public object dyn_tree;
        public object max_code;
        public object stat_desc;

        // ── Methods ──
        public void d_code(){} // RVA: 0xA262870
        public void gen_bitlen(){} // RVA: 0xA262930
        public void build_tree(){} // RVA: 0xA262D30
        public void gen_codes(){} // RVA: 0xA263270
        public void bi_reverse(){} // RVA: 0xA263400
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA263420
    }

}