// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  typedef Hash PoolID;

    //  ===========================================================================
    public class PoolID
    {
        public Hash InnerValue { get; set; } = default(Hash);

        public PoolID() { }

        public PoolID(Hash value)
        {
            InnerValue = value;
        }

        public static void Encode(XdrDataOutputStream stream, PoolID encodedPoolID)
        {
            Hash.Encode(stream, encodedPoolID.InnerValue);
        }
        public static PoolID Decode(XdrDataInputStream stream)
        {
            PoolID decodedPoolID = new PoolID();
            decodedPoolID.InnerValue = Hash.Decode(stream);
            return decodedPoolID;
        }
    }
}
