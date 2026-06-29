// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
// Classes: 14
// Methods: 167

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Zlib
{
    public class Adler32 : Object
    {
        // ── Methods ──
        public void adler32(){} // RVA: 0x7B129DD30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Deflate : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B13E8020
        public void .ctor(){} // RVA: 0x7B13E8820
        public void lm_init(){} // RVA: 0x7B13E8C20
        public void tr_init(){} // RVA: 0x7B13E8E10
        public void init_block(){} // RVA: 0x7B13E9120
        public void pqdownheap(){} // RVA: 0x7B13E9220
        public void smaller(){} // RVA: 0x7B13E9490
        public void scan_tree(){} // RVA: 0x7B13E9510
        public void build_bl_tree(){} // RVA: 0x7B13E96F0
        public void send_all_trees(){} // RVA: 0x7B13E9840
        public void send_tree(){} // RVA: 0x7B13E99B0
        public void put_byte(){} // RVA: 0x7B13E9CC0
        public void put_short(){} // RVA: 0x7B13E9D00
        public void putShortMSB(){} // RVA: 0x7B13E9D60
        public void send_code(){} // RVA: 0x7B13E9DC0
        public void send_bits(){} // RVA: 0x7B13E9E10
        public void _tr_align(){} // RVA: 0x7B13E9EF0
        public void _tr_tally(){} // RVA: 0x7B13EA050
        public void compress_block(){} // RVA: 0x7B13EA300
        public void set_data_type(){} // RVA: 0x7B13EA660
        public void bi_flush(){} // RVA: 0x7B13EA750
        public void bi_windup(){} // RVA: 0x7B13EA820
        public void copy_block(){} // RVA: 0x7B13EA8E0
        public void flush_block_only(){} // RVA: 0x7B13EAA00
        public void deflate_stored(){} // RVA: 0x7B13EAA70
        public void _tr_stored_block(){} // RVA: 0x7B13EAC40
        public void _tr_flush_block(){} // RVA: 0x7B13EAD60
        public void fill_window(){} // RVA: 0x7B13EB240
        public void deflate_fast(){} // RVA: 0x7B13EB4F0
        public void deflate_slow(){} // RVA: 0x7B13EB950
        public void longest_match(){} // RVA: 0x7B13EBE30
        public void deflateInit(){} // RVA: 0x7B13EC290
        public void deflateInit2(){} // RVA: 0x7B13EC2C0
        public void deflateReset(){} // RVA: 0x7B13EC600
        public void deflateEnd(){} // RVA: 0x7B13EC6F0
        public void deflateParams(){} // RVA: 0x7B13EC870
        public void deflateSetDictionary(){} // RVA: 0x7B13ECAE0
        public void deflate(){} // RVA: 0x7B13ECCB0
    }

    public class InfBlocks : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13ED2D0
        public void reset(){} // RVA: 0x7B13ED650
        public void proc(){} // RVA: 0x7B13ED6E0
        public void free(){} // RVA: 0x7B13EEBA0
        public void set_dictionary(){} // RVA: 0x7B13EECD0
        public void sync_point(){} // RVA: 0x7B13EED20
        public void inflate_flush(){} // RVA: 0x7B13EED30
        public void .cctor(){} // RVA: 0x7B13EEEA0
    }

    public class InfCodes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void init(){} // RVA: 0x7B13EF040
        public void proc(){} // RVA: 0x7B13EF170
        public void free(){} // RVA: 0x7A80D7310
        public void inflate_fast(){} // RVA: 0x7B13EFE00
        public void .cctor(){} // RVA: 0x7B13F0820
    }

    public class InfTree : Object
    {
        // ── Methods ──
        public void huft_build(){} // RVA: 0x7B13F1D50
        public void inflate_trees_bits(){} // RVA: 0x7B13F2730
        public void inflate_trees_dynamic(){} // RVA: 0x7B13F2930
        public void inflate_trees_fixed(){} // RVA: 0x7B13F2D20
        public void initWorkArea(){} // RVA: 0x7B13F2E10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B13F3200
    }

    public class Inflate : Object
    {
        // ── Methods ──
        public void inflateReset(){} // RVA: 0x7B13F0900
        public void inflateEnd(){} // RVA: 0x7B13F0A10
        public void inflateInit(){} // RVA: 0x7B13F0BB0
        public void inflate(){} // RVA: 0x7B13F0F10
        public void inflateSetDictionary(){} // RVA: 0x7B13F1840
        public void inflateSync(){} // RVA: 0x7B13F1990
        public void inflateSyncPoint(){} // RVA: 0x7B13F1BB0
        public void .ctor(){} // RVA: 0x7B13F1BE0
        public void .cctor(){} // RVA: 0x7B13F1C70
    }

    public class JZlib : Object
    {
        // ── Methods ──
        public void version(){} // RVA: 0x7B13F3620
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LowMemoryCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13F3660
        public void .cctor(){} // RVA: 0x7B13F3730
    }

    public class ZDeflaterOutputStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13F3BC0
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A81BD750
        public void get_Length(){} // RVA: 0x7A82D1450
        public void get_Position(){} // RVA: 0x7A82D1450
        public void set_Position(){} // RVA: 0x7A80D7310
        public void Write(){} // RVA: 0x7B13F3E00
        public void Seek(){} // RVA: 0x7A82D1450
        public void SetLength(){} // RVA: 0x7A80D7310
        public void Read(){} // RVA: 0x7A82D1450
        public void Flush(){} // RVA: 0x7B13F4060
        public void WriteByte(){} // RVA: 0x7B13F4090
        public void Finish(){} // RVA: 0x7B13F40E0
        public void End(){} // RVA: 0x7B13F42B0
        public void Close(){} // RVA: 0x7B13F4340
    }

    public class ZInflaterInputStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13F4540
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7A82D1450
        public void get_Position(){} // RVA: 0x7A82D1450
        public void set_Position(){} // RVA: 0x7A80D7310
        public void Write(){} // RVA: 0x7A80D7310
        public void Seek(){} // RVA: 0x7A82D1450
        public void SetLength(){} // RVA: 0x7A80D7310
        public void Read(){} // RVA: 0x7B13F47F0
        public void Flush(){} // RVA: 0x7B13F4060
        public void WriteByte(){} // RVA: 0x7A80D7310
        public void Close(){} // RVA: 0x7B13F4A30
        public void ReadByte(){} // RVA: 0x7B13F4AB0
    }

    public class ZInputStream : Stream
    {
        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x7B13F4B20
        public void .ctor(){} // RVA: 0x7B13F4FE0
        public void get_CanRead(){} // RVA: 0x7ACF0C540
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void Close(){} // RVA: 0x7B13F52B0
        public void Flush(){} // RVA: 0x7A80D7310
        public void get_FlushMode(){} // RVA: 0x7A8133100
        public void set_FlushMode(){} // RVA: 0x7A8133110
        public void get_Length(){} // RVA: 0x7B13F5340
        public void get_Position(){} // RVA: 0x7B13F5380
        public void set_Position(){} // RVA: 0x7B13F53C0
        public void Read(){} // RVA: 0x7B13F5400
        public void ReadByte(){} // RVA: 0x7B13F4AB0
        public void Seek(){} // RVA: 0x7B13F5690
        public void SetLength(){} // RVA: 0x7B13F56D0
        public void get_TotalIn(){} // RVA: 0x7ABE84620
        public void get_TotalOut(){} // RVA: 0x7ADE58460
        public void Write(){} // RVA: 0x7B13F5710
    }

    public class ZOutputStream : Stream
    {
        // ── Methods ──
        public void GetDefaultZStream(){} // RVA: 0x7B13F5750
        public void .ctor(){} // RVA: 0x7B13F5B90
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7ACF0C540
        public void Close(){} // RVA: 0x7B13F5DE0
        public void DoClose(){} // RVA: 0x7B13F5E10
        public void End(){} // RVA: 0x7B13F5F80
        public void Finish(){} // RVA: 0x7B13F60B0
        public void Flush(){} // RVA: 0x7B13F62E0
        public void get_FlushMode(){} // RVA: 0x7A8133100
        public void set_FlushMode(){} // RVA: 0x7A8133110
        public void get_Length(){} // RVA: 0x7B13F6310
        public void get_Position(){} // RVA: 0x7B13F6350
        public void set_Position(){} // RVA: 0x7B13F6390
        public void Read(){} // RVA: 0x7B13F63D0
        public void Seek(){} // RVA: 0x7B13F6410
        public void SetLength(){} // RVA: 0x7B13F6450
        public void get_TotalIn(){} // RVA: 0x7ABE84620
        public void get_TotalOut(){} // RVA: 0x7ADE58460
        public void Write(){} // RVA: 0x7B13F6490
        public void WriteByte(){} // RVA: 0x7B13F4090
    }

    public class ZStream : Object
    {
        // ── Methods ──
        public void inflateInit(){} // RVA: 0x7B13F6770
        public void inflate(){} // RVA: 0x7B13F68E0
        public void inflateEnd(){} // RVA: 0x7B13F6900
        public void inflateSync(){} // RVA: 0x7B13F6990
        public void inflateSetDictionary(){} // RVA: 0x7B13F69B0
        public void deflateInit(){} // RVA: 0x7B13F6B70
        public void deflate(){} // RVA: 0x7B13F6C80
        public void deflateEnd(){} // RVA: 0x7B13F6CA0
        public void deflateParams(){} // RVA: 0x7B13F6EA0
        public void deflateSetDictionary(){} // RVA: 0x7B13F6EE0
        public void flush_pending(){} // RVA: 0x7B13F6F20
        public void read_buf(){} // RVA: 0x7B13F6FE0
        public void free(){} // RVA: 0x7B13F70A0
        public void .ctor(){} // RVA: 0x7B13F71F0
    }

    public class ZTree : Object
    {
        // ── Methods ──
        public void d_code(){} // RVA: 0x7B13F7280
        public void gen_bitlen(){} // RVA: 0x7B13F7340
        public void build_tree(){} // RVA: 0x7B13F7740
        public void gen_codes(){} // RVA: 0x7B13F7C80
        public void bi_reverse(){} // RVA: 0x7B13F7E10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B13F7E30
    }

}