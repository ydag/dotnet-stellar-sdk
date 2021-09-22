// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  enum AllowTrustResultCode
    //  {
    //      // codes considered as "success" for the operation
    //      ALLOW_TRUST_SUCCESS = 0,
    //      // codes considered as "failure" for the operation
    //      ALLOW_TRUST_MALFORMED = -1,     // asset is not ASSET_TYPE_ALPHANUM
    //      ALLOW_TRUST_NO_TRUST_LINE = -2, // trustor does not have a trustline
    //                                      // source account does not require trust
    //      ALLOW_TRUST_TRUST_NOT_REQUIRED = -3,
    //      ALLOW_TRUST_CANT_REVOKE = -4,     // source account can't revoke trust,
    //      ALLOW_TRUST_SELF_NOT_ALLOWED = -5, // trusting self is not allowed
    //      ALLOW_TRUST_LOW_RESERVE = -6 // claimable balances can't be created
    //                                   // on revoke due to low reserves 
    //  };

    //  ===========================================================================
    public class AllowTrustResultCode
    {
        public enum AllowTrustResultCodeEnum
        {
            ALLOW_TRUST_SUCCESS = 0,
            ALLOW_TRUST_MALFORMED = -1,
            ALLOW_TRUST_NO_TRUST_LINE = -2,
            ALLOW_TRUST_TRUST_NOT_REQUIRED = -3,
            ALLOW_TRUST_CANT_REVOKE = -4,
            ALLOW_TRUST_SELF_NOT_ALLOWED = -5,
            ALLOW_TRUST_LOW_RESERVE = -6,
        }
        public AllowTrustResultCodeEnum InnerValue { get; set; } = default(AllowTrustResultCodeEnum);

        public static AllowTrustResultCode Create(AllowTrustResultCodeEnum v)
        {
            return new AllowTrustResultCode
            {
                InnerValue = v
            };
        }

        public static AllowTrustResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_SUCCESS);
                case -1: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_MALFORMED);
                case -2: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_NO_TRUST_LINE);
                case -3: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_TRUST_NOT_REQUIRED);
                case -4: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_CANT_REVOKE);
                case -5: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_SELF_NOT_ALLOWED);
                case -6: return Create(AllowTrustResultCodeEnum.ALLOW_TRUST_LOW_RESERVE);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, AllowTrustResultCode value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
