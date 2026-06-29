// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
// Classes: 16
// Methods: 171

namespace ThirdParty.BestHTTP.BestHTTP.Decompression.Zlib
{
    public class Adler : Object
    {
        public object BASE;
        public object NMAX;

        // ── Methods ──
        public void Adler32(){} // RVA: 0xA4CC720
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4CCAC0
    }

    public class DeflateManager : Object
    {
        public object MEM_LEVEL_MAX;
        public object MEM_LEVEL_DEFAULT;
        public object DeflateFunction;
        public object _ErrorMessage;
        public object PRESET_DICT;
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
        public object MIN_MATCH;
        public object MAX_MATCH;
        public object MIN_LOOKAHEAD;
        public object HEAP_SIZE;
        public object END_BLOCK;
        public object _codec;
        public object status;
        public object pending;
        public object nextPending;
        public object pendingCount;
        public object data_type;
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
        public object config;
        public object match_length;
        public object prev_match;
        public object match_available;
        public object strstart;
        public object match_start;
        public object lookahead;
        public object prev_length;
        public object compressionLevel;
        public object compressionStrategy;
        public object dyn_ltree;
        public object dyn_dtree;
        public object bl_tree;
        public object treeLiterals;
        public object treeDistances;
        public object treeBitLengths;
        public object bl_count;
        public object heap;
        public object heap_len;
        public object heap_max;
        public object depth;
        public object _lengthOffset;
        public object lit_bufsize;
        public object last_lit;
        public object _distanceOffset;
        public object opt_len;
        public object static_len;
        public object matches;
        public object last_eob_len;
        public object bi_buf;
        public object bi_valid;
        public object Rfc1950BytesEmitted;
        public object _WantRfc1950HeaderBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4BD360
        public void _InitializeLazyMatch(){} // RVA: 0xA4BD840
        public void _InitializeTreeData(){} // RVA: 0xA4BD980
        public void _InitializeBlocks(){} // RVA: 0xA4BDCA0
        public void pqdownheap(){} // RVA: 0xA4BDEA0
        public void _IsSmaller(){} // RVA: 0xA4BE110
        public void scan_tree(){} // RVA: 0xA4BE190
        public void build_bl_tree(){} // RVA: 0xA4BE450
        public void send_all_trees(){} // RVA: 0xA4BE5E0
        public void send_tree(){} // RVA: 0xA4BE750
        public void put_bytes(){} // RVA: 0xA4BEAF0
        public void send_code(){} // RVA: 0xA4BEB40
        public void send_bits(){} // RVA: 0xA4BEB90
        public void _tr_align(){} // RVA: 0xA4BED00
        public void _tr_tally(){} // RVA: 0xA4BEEF0
        public void send_compressed_block(){} // RVA: 0xA4BF210
        public void set_data_type(){} // RVA: 0xA4BF5F0
        public void bi_flush(){} // RVA: 0xA4BF7B0
        public void bi_windup(){} // RVA: 0xA4BF890
        public void copy_block(){} // RVA: 0xA4BF960
        public void flush_block_only(){} // RVA: 0xA4BFA80
        public void DeflateNone(){} // RVA: 0xA4BFAF0
        public void _tr_stored_block(){} // RVA: 0xA4BFDB0
        public void _tr_flush_block(){} // RVA: 0xA4BFF30
        public void _fillWindow(){} // RVA: 0xA4C0420
        public void DeflateFast(){} // RVA: 0xA4C07C0
        public void DeflateSlow(){} // RVA: 0xA4C0D60
        public void longest_match(){} // RVA: 0xA4C1480
        public void get_WantRfc1950HeaderBytes(){} // RVA: 0x1A41B90
        public void set_WantRfc1950HeaderBytes(){} // RVA: 0x1A452F0
        public void Initialize(){} // RVA: 0xA4C1B60
        public void Reset(){} // RVA: 0xA4C1F20
        public void End(){} // RVA: 0xA4C21D0
        public void SetDeflater(){} // RVA: 0xA4C2460
        public void SetParams(){} // RVA: 0xA4C2680
        public void SetDictionary(){} // RVA: 0xA4C27D0
        public void Deflate(){} // RVA: 0xA4C2B00
        public void .cctor(){} // RVA: 0xA4C3360
    }

    public class DeflateStream : Stream
    {
        public object _baseStream;
        public object _innerStream;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4C3F30
        public void get_FlushMode(){} // RVA: 0xA4C40C0
        public void set_FlushMode(){} // RVA: 0xA4C40E0
        public void get_BufferSize(){} // RVA: 0xA4C4160
        public void set_BufferSize(){} // RVA: 0xA4C4180
        public void get_Strategy(){} // RVA: 0xA4C42F0
        public void set_Strategy(){} // RVA: 0xA4C4310
        public void get_TotalIn(){} // RVA: 0xA4C4390
        public void get_TotalOut(){} // RVA: 0xA4C43C0
        public void Dispose(){} // RVA: 0xA4C43F0
        public void get_CanRead(){} // RVA: 0xA4C4470
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xA4C4500
        public void Flush(){} // RVA: 0xA4C4590
        public void get_Length(){} // RVA: 0xA4C4620
        public void get_Position(){} // RVA: 0xA4C4660
        public void set_Position(){} // RVA: 0xA4C46B0
        public void Read(){} // RVA: 0xA4C46F0
        public void Seek(){} // RVA: 0xA4C4780
        public void SetLength(){} // RVA: 0x70F92B0
        public void Write(){} // RVA: 0xA4C47C0
    }

    public class GZipStream : Stream
    {
        public object LastModified;
        public object _headerByteCount;
        public object _baseStream;
        public object _disposed;
        public object _firstReadDone;
        public object _FileName;
        public object _Comment;
        public object _Crc32;
        public object _unixEpoch;
        public object iso8859dash1;

        // ── Methods ──
        public void get_Comment(){} // RVA: 0xC0FFC0
        public void set_Comment(){} // RVA: 0xA4C4850
        public void get_FileName(){} // RVA: 0xBE58B0
        public void set_FileName(){} // RVA: 0xA4C4900
        public void get_Crc32(){} // RVA: 0xD347A0
        public void .ctor(){} // RVA: 0xA4C4BC0
        public void get_FlushMode(){} // RVA: 0xA4C4CE0
        public void set_FlushMode(){} // RVA: 0xA4C4D00
        public void get_BufferSize(){} // RVA: 0xA4C4D80
        public void set_BufferSize(){} // RVA: 0xA4C4DA0
        public void get_TotalIn(){} // RVA: 0xA4C4F10
        public void get_TotalOut(){} // RVA: 0xA4C4F40
        public void Dispose(){} // RVA: 0xA4C4F70
        public void get_CanRead(){} // RVA: 0xA4C5010
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xA4C50A0
        public void Flush(){} // RVA: 0xA4C5130
        public void get_Length(){} // RVA: 0xA4C51C0
        public void get_Position(){} // RVA: 0xA4C5200
        public void set_Position(){} // RVA: 0xA4C5260
        public void Read(){} // RVA: 0xA4C52A0
        public void Seek(){} // RVA: 0xA4C5420
        public void SetLength(){} // RVA: 0xA4C5460
        public void Write(){} // RVA: 0xA4C5490
        public void EmitHeader(){} // RVA: 0xA4C55B0
        public void .cctor(){} // RVA: 0xA4C5A40
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
        public void huft_build(){} // RVA: 0xA4CA6F0
        public void inflate_trees_bits(){} // RVA: 0xA4CB0D0
        public void inflate_trees_dynamic(){} // RVA: 0xA4CB2D0
        public void inflate_trees_fixed(){} // RVA: 0xA4CB6C0
        public void initWorkArea(){} // RVA: 0xA4CB7B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4CBB80
    }

    public class InflateBlocks : Object
    {
        public object MANY;
        public object border;
        public object mode;
        public object left;
        public object table;
        public object index;
        public object blens;
        public object bb;
        public object tb;
        public object codes;
        public object last;
        public object _codec;
        public object bitk;
        public object bitb;
        public object hufts;
        public object window;
        public object end;
        public object readAt;
        public object writeAt;
        public object checkfn;
        public object check;
        public object inftree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4C5B50
        public void Reset(){} // RVA: 0xA4C5F00
        public void Process(){} // RVA: 0xA4C5FB0
        public void Free(){} // RVA: 0xA4C7740
        public void SetDictionary(){} // RVA: 0xA4C7860
        public void SyncPoint(){} // RVA: 0xA25A310
        public void Flush(){} // RVA: 0xA4C78B0
        public void .cctor(){} // RVA: 0xA4C7A50
    }

    public class InflateCodes : Object
    {
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
        public object bitsToGet;
        public object dist;
        public object lbits;
        public object dbits;
        public object ltree;
        public object ltree_index;
        public object dtree;
        public object dtree_index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA25A630
        public void Process(){} // RVA: 0xA4C7C10
        public void InflateFast(){} // RVA: 0xA4C8880
    }

    public class InflateManager : Object
    {
        public object PRESET_DICT;
        public object Z_DEFLATED;
        public object mode;
        public object _codec;
        public object method;
        public object computedCheck;
        public object expectedCheck;
        public object marker;
        public object _handleRfc1950HeaderBytes;
        public object wbits;
        public object blocks;
        public object mark;

        // ── Methods ──
        public void get_HandleRfc1950HeaderBytes(){} // RVA: 0xB68DF0
        public void set_HandleRfc1950HeaderBytes(){} // RVA: 0xB68E00
        public void .ctor(){} // RVA: 0xB68E00
        public void Reset(){} // RVA: 0xA4C92A0
        public void End(){} // RVA: 0xA4C9340
        public void Initialize(){} // RVA: 0xA4C94E0
        public void Inflate(){} // RVA: 0xA4C9760
        public void SetDictionary(){} // RVA: 0xA4CA230
        public void Sync(){} // RVA: 0xA4CA3C0
        public void SyncPoint(){} // RVA: 0xA4CA5E0
        public void .cctor(){} // RVA: 0xA4CA610
    }

    public class InternalConstants : Object
    {
        public object MAX_BITS;
        public object BL_CODES;
        public object D_CODES;
        public object LITERALS;
        public object LENGTH_CODES;
        public object L_CODES;
        public object MAX_BL_BITS;
        public object REP_3_6;
        public object REPZ_3_10;
        public object REPZ_11_138;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA4CC1B0
    }

    public class InternalInflateConstants : Object
    {
        public object InflateMask;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA4C7B30
    }

    public class SharedUtils : Object
    {
        // ── Methods ──
        public void URShift(){} // RVA: 0xA4CC050
        public void ReadInput(){} // RVA: 0xA4CC060
        public void ToByteArray(){} // RVA: 0xA109550
        public void ToCharArray(){} // RVA: 0xA4CC170
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StaticTree : Object
    {
        public object lengthAndLiteralsTreeCodes;
        public object distTreeCodes;
        public object Literals;
        public object Distances;
        public object BitLengths;
        public object treeCodes;
        public object extraBits;
        public object extraBase;
        public object elems;
        public object maxLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA25EC50
        public void .cctor(){} // RVA: 0xA4CC2B0
    }

    public class ZTree : Object
    {
        public object HEAP_SIZE;
        public object ExtraLengthBits;
        public object ExtraDistanceBits;
        public object extra_blbits;
        public object bl_order;
        public object Buf_size;
        public object _dist_code;
        public object LengthCode;
        public object LengthBase;
        public object DistanceBase;
        public object dyn_tree;
        public object max_code;
        public object staticTree;

        // ── Methods ──
        public void DistanceCode(){} // RVA: 0xA4CFC30
        public void gen_bitlen(){} // RVA: 0xA4CFCF0
        public void build_tree(){} // RVA: 0xA4D0190
        public void gen_codes(){} // RVA: 0xA4D0700
        public void bi_reverse(){} // RVA: 0xA263400
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4D0900
    }

    public class ZlibBaseStream : Stream
    {
        public object _z;
        public object _streamMode;
        public object _flushMode;
        public object _flavor;
        public object _compressionMode;
        public object _level;
        public object _leaveOpen;
        public object _workingBuffer;
        public object _bufferSize;
        public object windowBitsMax;
        public object _buf1;
        public object _stream;
        public object Strategy;
        public object crc;
        public object _GzipFileName;
        public object _GzipComment;
        public object _GzipMtime;
        public object _gzipHeaderByteCount;
        public object nomoreinput;

        // ── Methods ──
        public void get_Crc32(){} // RVA: 0xA4CCB20
        public void .ctor(){} // RVA: 0xA4CCB70
        public void get__wantCompress(){} // RVA: 0xA4CCD80
        public void get_z(){} // RVA: 0xA4CCD90
        public void get_workingBuffer(){} // RVA: 0xA4CCEB0
        public void Write(){} // RVA: 0xA4CCF70
        public void finish(){} // RVA: 0xA4CD380
        public void end(){} // RVA: 0xA4CDC50
        public void Close(){} // RVA: 0xA4CDF30
        public void Flush(){} // RVA: 0xA4CE040
        public void Seek(){} // RVA: 0xA4CE070
        public void SetLength(){} // RVA: 0xA4CE0B0
        public void ReadZeroTerminatedString(){} // RVA: 0xA4CE0F0
        public void _ReadAndValidateGzipHeader(){} // RVA: 0xA4CE310
        public void Read(){} // RVA: 0xA4CE7A0
        public void get_CanRead(){} // RVA: 0xA4CEDE0
        public void get_CanSeek(){} // RVA: 0xA4CEE10
        public void get_CanWrite(){} // RVA: 0xA4CEE40
        public void get_Length(){} // RVA: 0xA4CEE70
        public void get_Position(){} // RVA: 0xA4CEEA0
        public void set_Position(){} // RVA: 0xA4CEEE0
    }

    public class ZlibCodec : Object
    {
        public object InputBuffer;
        public object NextIn;
        public object AvailableBytesIn;
        public object TotalBytesIn;
        public object OutputBuffer;
        public object NextOut;
        public object AvailableBytesOut;
        public object TotalBytesOut;
        public object Message;
        public object dstate;
        public object istate;
        public object _Adler32;
        public object CompressLevel;
        public object WindowBits;
        public object Strategy;

        // ── Methods ──
        public void get_Adler32(){} // RVA: 0x12BB630
        public void .ctor(){} // RVA: 0xA4CEF30
        public void InitializeInflate(){} // RVA: 0xA4CF090
        public void Inflate(){} // RVA: 0xA4CF1B0
        public void EndInflate(){} // RVA: 0xA4CF220
        public void SyncInflate(){} // RVA: 0xA4CF2F0
        public void InitializeDeflate(){} // RVA: 0xA4CF3C0
        public void _InternalInitializeDeflate(){} // RVA: 0xA4CF3E0
        public void Deflate(){} // RVA: 0xA4CF590
        public void EndDeflate(){} // RVA: 0xA4CF600
        public void ResetDeflate(){} // RVA: 0xA4CF6C0
        public void SetDeflateParams(){} // RVA: 0xA4CF730
        public void SetDictionary(){} // RVA: 0xA4CF8D0
        public void flush_pending(){} // RVA: 0xA4CF970
        public void read_buf(){} // RVA: 0xA4CFB20
    }

    public class ZlibException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4CBFF0
    }

}