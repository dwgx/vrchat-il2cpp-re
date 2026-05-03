// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
// Classes: 14
// Methods: 186

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
    public class Adler32 : Object
    {
        // ── Methods ──
        public void adler32(){} // RVA: 0x7FFE89ECC360
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Deflate : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A013790
        public void .ctor(){} // RVA: 0x7FFE8A013F90
        public void lm_init(){} // RVA: 0x7FFE8A014390
        public void tr_init(){} // RVA: 0x7FFE8A014580
        public void init_block(){} // RVA: 0x7FFE8A014890
        public void pqdownheap(){} // RVA: 0x7FFE8A014980
        public void smaller(){} // RVA: 0x7FFE8A014BE0
        public void scan_tree(){} // RVA: 0x7FFE8A014C60
        public void build_bl_tree(){} // RVA: 0x7FFE8A014E30
        public void send_all_trees(){} // RVA: 0x7FFE8A014F70
        public void send_tree(){} // RVA: 0x7FFE8A0150D0
        public void put_byte(){} // RVA: 0x7FFE8A0153E0 | overloaded x2
        public void put_short(){} // RVA: 0x7FFE8A015420
        public void putShortMSB(){} // RVA: 0x7FFE8A015480
        public void send_code(){} // RVA: 0x7FFE8A0154E0
        public void send_bits(){} // RVA: 0x7FFE8A015530
        public void _tr_align(){} // RVA: 0x7FFE8A015600
        public void _tr_tally(){} // RVA: 0x7FFE8A015760
        public void compress_block(){} // RVA: 0x7FFE8A015A10
        public void set_data_type(){} // RVA: 0x7FFE8A015D70
        public void bi_flush(){} // RVA: 0x7FFE8A015E40
        public void bi_windup(){} // RVA: 0x7FFE8A015F10
        public void copy_block(){} // RVA: 0x7FFE8A015FD0
        public void flush_block_only(){} // RVA: 0x7FFE8A0160F0
        public void deflate_stored(){} // RVA: 0x7FFE8A016160
        public void _tr_stored_block(){} // RVA: 0x7FFE8A016330
        public void _tr_flush_block(){} // RVA: 0x7FFE8A016450
        public void fill_window(){} // RVA: 0x7FFE8A016920
        public void deflate_fast(){} // RVA: 0x7FFE8A016BE0
        public void deflate_slow(){} // RVA: 0x7FFE8A017050
        public void longest_match(){} // RVA: 0x7FFE8A017550
        public void deflateInit(){} // RVA: 0x7FFE8A017960 | overloaded x2
        public void deflateInit2(){} // RVA: 0x7FFE8A017990
        public void deflateReset(){} // RVA: 0x7FFE8A017CD0
        public void deflateEnd(){} // RVA: 0x7FFE8A017DC0
        public void deflateParams(){} // RVA: 0x7FFE8A017F40
        public void deflateSetDictionary(){} // RVA: 0x7FFE8A0181B0
        public void deflate(){} // RVA: 0x7FFE8A018390
    }

    public class InfBlocks : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0189B0
        public void reset(){} // RVA: 0x7FFE8A018D20
        public void proc(){} // RVA: 0x7FFE8A018DB0
        public void free(){} // RVA: 0x7FFE8A01A030
        public void set_dictionary(){} // RVA: 0x7FFE8A01A160
        public void sync_point(){} // RVA: 0x7FFE8A01A1B0
        public void inflate_flush(){} // RVA: 0x7FFE8A01A1C0
        public void .cctor(){} // RVA: 0x7FFE8A01A330
    }

    public class InfCodes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void init(){} // RVA: 0x7FFE8A01A4D0
        public void proc(){} // RVA: 0x7FFE8A01A600
        public void free(){} // RVA: 0x7FFE810FB310
        public void inflate_fast(){} // RVA: 0x7FFE8A01B190
        public void .cctor(){} // RVA: 0x7FFE8A01BB30
    }

    public class InfTree : Object
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x7FFE8A01D030
        public void inflate_trees_bits(){} // RVA: 0x7FFE8A01D970
        public void inflate_trees_dynamic(){} // RVA: 0x7FFE8A01DB70
        public void inflate_trees_fixed(){} // RVA: 0x7FFE8A01DF50
        public void initWorkArea(){} // RVA: 0x7FFE8A01E040
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A01E410
    }

    public class Inflate : Object
    {
        // ── Methods ──
        public void inflateReset(){} // RVA: 0x7FFE8A01BC10
        public void inflateEnd(){} // RVA: 0x7FFE8A01BD20
        public void inflateInit(){} // RVA: 0x7FFE8A01BEC0
        public void inflate(){} // RVA: 0x7FFE8A01C220
        public void inflateSetDictionary(){} // RVA: 0x7FFE8A01CB50
        public void inflateSync(){} // RVA: 0x7FFE8A01CCA0
        public void inflateSyncPoint(){} // RVA: 0x7FFE8A01CE90
        public void .ctor(){} // RVA: 0x7FFE8A01CEC0
        public void .cctor(){} // RVA: 0x7FFE8A01CF50
    }

    public class JZlib : Object
    {
        // ── Methods ──
        public void version(){} // RVA: 0x7FFE8A01E830
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StaticTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A01E870
        public void .cctor(){} // RVA: 0x7FFE8A01E940
    }

    public class ZDeflaterOutputStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream z; // 0x28
        public int flushLevel; // 0x30
        public int BUFSIZE;
        public byte[] buf; // 0x38
        public byte[] buf1; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A01EDD0 | overloaded x3
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void get_Length(){} // RVA: 0x7FFE813240E0
        public void get_Position(){} // RVA: 0x7FFE813240E0
        public void set_Position(){} // RVA: 0x7FFE810FB310
        public void Write(){} // RVA: 0x7FFE8A01F010
        public void Seek(){} // RVA: 0x7FFE813240E0
        public void SetLength(){} // RVA: 0x7FFE810FB310
        public void Read(){} // RVA: 0x7FFE813240E0
        public void Flush(){} // RVA: 0x7FFE8A01F260
        public void WriteByte(){} // RVA: 0x7FFE8A01F290
        public void Finish(){} // RVA: 0x7FFE8A01F2E0
        public void End(){} // RVA: 0x7FFE8A01F4B0
        public void Close(){} // RVA: 0x7FFE8A01F540
    }

    public class ZInflaterInputStream : Stream
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib.ZStream z; // 0x28
        public int flushLevel; // 0x30
        public int BUFSIZE;
        public byte[] buf; // 0x38
        public byte[] buf1; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A01F740 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE813240E0
        public void get_Position(){} // RVA: 0x7FFE813240E0
        public void set_Position(){} // RVA: 0x7FFE810FB310
        public void Write(){} // RVA: 0x7FFE810FB310
        public void Seek(){} // RVA: 0x7FFE813240E0
        public void SetLength(){} // RVA: 0x7FFE810FB310
        public void Read(){} // RVA: 0x7FFE8A01F9F0
        public void Flush(){} // RVA: 0x7FFE8A01F260
        public void WriteByte(){} // RVA: 0x7FFE810FB310
        public void Close(){} // RVA: 0x7FFE8A01FC30
        public void ReadByte(){} // RVA: 0x7FFE8A01FCB0
    }

    public class ZInputStream : Stream
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
        public void GetDefaultZStream(){} // RVA: 0x7FFE8A01FD20
        public void .ctor(){} // RVA: 0x7FFE8A0201E0 | overloaded x5
        public void get_CanRead(){} // RVA: 0x7FFE8A020490
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void Close(){} // RVA: 0x7FFE8A0204A0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void get_FlushMode(){} // RVA: 0x7FFE81156CD0
        public void set_FlushMode(){} // RVA: 0x7FFE81156CE0
        public void get_Length(){} // RVA: 0x7FFE8A020530
        public void get_Position(){} // RVA: 0x7FFE8A020570
        public void set_Position(){} // RVA: 0x7FFE8A0205B0
        public void Read(){} // RVA: 0x7FFE8A0205F0
        public void ReadByte(){} // RVA: 0x7FFE8A01FCB0
        public void Seek(){} // RVA: 0x7FFE8A020880
        public void SetLength(){} // RVA: 0x7FFE8A0208C0
        public void get_TotalIn(){} // RVA: 0x7FFE84D055D0
        public void get_TotalOut(){} // RVA: 0x7FFE86BACE60
        public void Write(){} // RVA: 0x7FFE8A020900
    }

    public class ZOutputStream : Stream
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
        public void GetDefaultZStream(){} // RVA: 0x7FFE8A020940
        public void .ctor(){} // RVA: 0x7FFE8A020D80 | overloaded x5
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE8A020490
        public void Close(){} // RVA: 0x7FFE8A020FC0
        public void DoClose(){} // RVA: 0x7FFE8A020FF0
        public void End(){} // RVA: 0x7FFE8A021160
        public void Finish(){} // RVA: 0x7FFE8A021290
        public void Flush(){} // RVA: 0x7FFE8A0214C0
        public void get_FlushMode(){} // RVA: 0x7FFE81156CD0
        public void set_FlushMode(){} // RVA: 0x7FFE81156CE0
        public void get_Length(){} // RVA: 0x7FFE8A0214F0
        public void get_Position(){} // RVA: 0x7FFE8A021530
        public void set_Position(){} // RVA: 0x7FFE8A021570
        public void Read(){} // RVA: 0x7FFE8A0215B0
        public void Seek(){} // RVA: 0x7FFE8A0215F0
        public void SetLength(){} // RVA: 0x7FFE8A021630
        public void get_TotalIn(){} // RVA: 0x7FFE84D055D0
        public void get_TotalOut(){} // RVA: 0x7FFE86BACE60
        public void Write(){} // RVA: 0x7FFE8A021670
        public void WriteByte(){} // RVA: 0x7FFE8A01F290
    }

    public class ZStream : Object
    {
        // ── Methods ──
        public void inflateInit(){} // RVA: 0x7FFE8A021950 | overloaded x4
        public void inflate(){} // RVA: 0x7FFE8A021AC0
        public void inflateEnd(){} // RVA: 0x7FFE8A021AE0
        public void inflateSync(){} // RVA: 0x7FFE8A021B70
        public void inflateSetDictionary(){} // RVA: 0x7FFE8A021B90
        public void deflateInit(){} // RVA: 0x7FFE8A021D50 | overloaded x4
        public void deflate(){} // RVA: 0x7FFE8A021E50
        public void deflateEnd(){} // RVA: 0x7FFE8A021E70
        public void deflateParams(){} // RVA: 0x7FFE8A022070
        public void deflateSetDictionary(){} // RVA: 0x7FFE8A0220B0
        public void flush_pending(){} // RVA: 0x7FFE8A0220F0
        public void read_buf(){} // RVA: 0x7FFE8A0221B0
        public void free(){} // RVA: 0x7FFE8A022270
        public void .ctor(){} // RVA: 0x7FFE8A0223C0
    }

    public class ZTree : Object
    {
        // ── Methods ──
        public void d_code(){} // RVA: 0x7FFE8A022450
        public void gen_bitlen(){} // RVA: 0x7FFE8A022510
        public void build_tree(){} // RVA: 0x7FFE8A0228D0
        public void gen_codes(){} // RVA: 0x7FFE8A022F20
        public void bi_reverse(){} // RVA: 0x7FFE8A0230C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0230F0
    }

}