// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
// Classes: 14
// Methods: 186

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
    public class Adler32
    {
        // ── Methods ──
        public void adler32(){} // RVA: 0x9469F90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Deflate
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x95B13C0
        public void .ctor(){} // RVA: 0x95B1BC0
        public void lm_init(){} // RVA: 0x95B1FC0
        public void tr_init(){} // RVA: 0x95B21B0
        public void init_block(){} // RVA: 0x95B24C0
        public void pqdownheap(){} // RVA: 0x95B25B0
        public void smaller(){} // RVA: 0x95B2810
        public void scan_tree(){} // RVA: 0x95B2890
        public void build_bl_tree(){} // RVA: 0x95B2A60
        public void send_all_trees(){} // RVA: 0x95B2BA0
        public void send_tree(){} // RVA: 0x95B2D00
        public void put_byte(){} // RVA: 0x95B3010 | overloaded x2
        public void put_short(){} // RVA: 0x95B3050
        public void putShortMSB(){} // RVA: 0x95B30B0
        public void send_code(){} // RVA: 0x95B3110
        public void send_bits(){} // RVA: 0x95B3160
        public void _tr_align(){} // RVA: 0x95B3230
        public void _tr_tally(){} // RVA: 0x95B3390
        public void compress_block(){} // RVA: 0x95B3640
        public void set_data_type(){} // RVA: 0x95B39A0
        public void bi_flush(){} // RVA: 0x95B3A70
        public void bi_windup(){} // RVA: 0x95B3B40
        public void copy_block(){} // RVA: 0x95B3C00
        public void flush_block_only(){} // RVA: 0x95B3D20
        public void deflate_stored(){} // RVA: 0x95B3D90
        public void _tr_stored_block(){} // RVA: 0x95B3F60
        public void _tr_flush_block(){} // RVA: 0x95B4080
        public void fill_window(){} // RVA: 0x95B4550
        public void deflate_fast(){} // RVA: 0x95B4810
        public void deflate_slow(){} // RVA: 0x95B4C80
        public void longest_match(){} // RVA: 0x95B5180
        public void deflateInit(){} // RVA: 0x95B5590 | overloaded x2
        public void deflateInit2(){} // RVA: 0x95B55C0
        public void deflateReset(){} // RVA: 0x95B5900
        public void deflateEnd(){} // RVA: 0x95B59F0
        public void deflateParams(){} // RVA: 0x95B5B70
        public void deflateSetDictionary(){} // RVA: 0x95B5DE0
        public void deflate(){} // RVA: 0x95B5FC0
    }

    public class InfBlocks
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95B65E0
        public void reset(){} // RVA: 0x95B6950
        public void proc(){} // RVA: 0x95B69E0
        public void free(){} // RVA: 0x95B7C60
        public void set_dictionary(){} // RVA: 0x95B7D90
        public void sync_point(){} // RVA: 0x95B7DE0
        public void inflate_flush(){} // RVA: 0x95B7DF0
        public void .cctor(){} // RVA: 0x95B7F60
    }

    public class InfCodes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void init(){} // RVA: 0x95B8100
        public void proc(){} // RVA: 0x95B8230
        public void free(){} // RVA: 0x2DD310
        public void inflate_fast(){} // RVA: 0x95B8DC0
        public void .cctor(){} // RVA: 0x95B9760
    }

    public class InfTree
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x95BAC60
        public void inflate_trees_bits(){} // RVA: 0x95BB5A0
        public void inflate_trees_dynamic(){} // RVA: 0x95BB7A0
        public void inflate_trees_fixed(){} // RVA: 0x95BBB80
        public void initWorkArea(){} // RVA: 0x95BBC70
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95BC040
    }

    public class Inflate
    {
        // ── Methods ──
        public void inflateReset(){} // RVA: 0x95B9840
        public void inflateEnd(){} // RVA: 0x95B9950
        public void inflateInit(){} // RVA: 0x95B9AF0
        public void inflate(){} // RVA: 0x95B9E50
        public void inflateSetDictionary(){} // RVA: 0x95BA780
        public void inflateSync(){} // RVA: 0x95BA8D0
        public void inflateSyncPoint(){} // RVA: 0x95BAAC0
        public void .ctor(){} // RVA: 0x95BAAF0
        public void .cctor(){} // RVA: 0x95BAB80
    }

    public class JZlib
    {
        // ── Methods ──
        public void version(){} // RVA: 0x95BC460
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LowMemoryCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95BC4A0
        public void .cctor(){} // RVA: 0x95BC570
    }

    public class ZDeflaterOutputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream z; // 0x28
        public int flushLevel; // 0x30
        public int BUFSIZE;
        public byte[] buf; // 0x38
        public byte[] buf1; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95BCA00 | overloaded x3
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void get_Length(){} // RVA: 0x519240
        public void get_Position(){} // RVA: 0x519240
        public void set_Position(){} // RVA: 0x2DD310
        public void Write(){} // RVA: 0x95BCC40
        public void Seek(){} // RVA: 0x519240
        public void SetLength(){} // RVA: 0x2DD310
        public void Read(){} // RVA: 0x519240
        public void Flush(){} // RVA: 0x95BCE90
        public void WriteByte(){} // RVA: 0x95BCEC0
        public void Finish(){} // RVA: 0x95BCF10
        public void End(){} // RVA: 0x95BD0E0
        public void Close(){} // RVA: 0x95BD170
    }

    public class ZInflaterInputStream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream z; // 0x28
        public int flushLevel; // 0x30
        public int BUFSIZE;
        public byte[] buf; // 0x38
        public byte[] buf1; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95BD370 | overloaded x2
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x519240
        public void get_Position(){} // RVA: 0x519240
        public void set_Position(){} // RVA: 0x2DD310
        public void Write(){} // RVA: 0x2DD310
        public void Seek(){} // RVA: 0x519240
        public void SetLength(){} // RVA: 0x2DD310
        public void Read(){} // RVA: 0x95BD620
        public void Flush(){} // RVA: 0x95BCE90
        public void WriteByte(){} // RVA: 0x2DD310
        public void Close(){} // RVA: 0x95BD860
        public void ReadByte(){} // RVA: 0x95BD8E0
    }

    public class ZInputStream
    {
        public int BufferSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream z; // 0x28
        public int flushLevel; // 0x30
        public byte[] buf; // 0x38
        public byte[] buf1; // 0x40
        public bool compress; // 0x48
        public System.IO.Stream input; // 0x50
        public bool closed; // 0x58

        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x95BD950
        public void .ctor(){} // RVA: 0x95BDE10 | overloaded x5
        public void get_CanRead(){} // RVA: 0x5042220
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void Close(){} // RVA: 0x95BE0C0
        public void Flush(){} // RVA: 0x2DD310
        public void get_FlushMode(){} // RVA: 0x338CD0
        public void set_FlushMode(){} // RVA: 0x338CE0
        public void get_Length(){} // RVA: 0x95BE150
        public void get_Position(){} // RVA: 0x95BE190
        public void set_Position(){} // RVA: 0x95BE1D0
        public void Read(){} // RVA: 0x95BE210
        public void ReadByte(){} // RVA: 0x95BD8E0
        public void Seek(){} // RVA: 0x95BE4A0
        public void SetLength(){} // RVA: 0x95BE4E0
        public void get_TotalIn(){} // RVA: 0x408F310
        public void get_TotalOut(){} // RVA: 0x606C090
        public void Write(){} // RVA: 0x95BE520
    }

    public class ZOutputStream
    {
        public int BufferSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream z; // 0x28
        public int flushLevel; // 0x30
        public byte[] buf; // 0x38
        public byte[] buf1; // 0x40
        public bool compress; // 0x48
        public System.IO.Stream output; // 0x50
        public bool closed; // 0x58

        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x95BE560
        public void .ctor(){} // RVA: 0x95BE9A0 | overloaded x5
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x5042220
        public void Close(){} // RVA: 0x95BEBE0
        public void DoClose(){} // RVA: 0x95BEC10
        public void End(){} // RVA: 0x95BED80
        public void Finish(){} // RVA: 0x95BEEB0
        public void Flush(){} // RVA: 0x95BF0E0
        public void get_FlushMode(){} // RVA: 0x338CD0
        public void set_FlushMode(){} // RVA: 0x338CE0
        public void get_Length(){} // RVA: 0x95BF110
        public void get_Position(){} // RVA: 0x95BF150
        public void set_Position(){} // RVA: 0x95BF190
        public void Read(){} // RVA: 0x95BF1D0
        public void Seek(){} // RVA: 0x95BF210
        public void SetLength(){} // RVA: 0x95BF250
        public void get_TotalIn(){} // RVA: 0x408F310
        public void get_TotalOut(){} // RVA: 0x606C090
        public void Write(){} // RVA: 0x95BF290
        public void WriteByte(){} // RVA: 0x95BCEC0
    }

    public class ZStream
    {
        // ── Methods ──
        public void inflateInit(){} // RVA: 0x95BF570 | overloaded x4
        public void inflate(){} // RVA: 0x95BF6E0
        public void inflateEnd(){} // RVA: 0x95BF700
        public void inflateSync(){} // RVA: 0x95BF790
        public void inflateSetDictionary(){} // RVA: 0x95BF7B0
        public void deflateInit(){} // RVA: 0x95BF970 | overloaded x4
        public void deflate(){} // RVA: 0x95BFA70
        public void deflateEnd(){} // RVA: 0x95BFA90
        public void deflateParams(){} // RVA: 0x95BFC90
        public void deflateSetDictionary(){} // RVA: 0x95BFCD0
        public void flush_pending(){} // RVA: 0x95BFD10
        public void read_buf(){} // RVA: 0x95BFDD0
        public void free(){} // RVA: 0x95BFE90
        public void .ctor(){} // RVA: 0x95BFFE0
    }

    public class ZTree
    {
        // ── Methods ──
        public void d_code(){} // RVA: 0x95C0070
        public void gen_bitlen(){} // RVA: 0x95C0130
        public void build_tree(){} // RVA: 0x95C04F0
        public void gen_codes(){} // RVA: 0x95C0B40
        public void bi_reverse(){} // RVA: 0x95C0CE0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95C0D10
    }

}