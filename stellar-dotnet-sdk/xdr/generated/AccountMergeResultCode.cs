// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  enum AccountMergeResultCode
    //  {
    //      // codes considered as "success" for the operation
    //      ACCOUNT_MERGE_SUCCESS = 0,
    //      // codes considered as "failure" for the operation
    //      ACCOUNT_MERGE_MALFORMED = -1,       // can't merge onto itself
    //      ACCOUNT_MERGE_NO_ACCOUNT = -2,      // destination does not exist
    //      ACCOUNT_MERGE_IMMUTABLE_SET = -3,   // source account has AUTH_IMMUTABLE set
    //      ACCOUNT_MERGE_HAS_SUB_ENTRIES = -4, // account has trust lines/offers
    //      ACCOUNT_MERGE_SEQNUM_TOO_FAR = -5,  // sequence number is over max allowed
    //      ACCOUNT_MERGE_DEST_FULL = -6        // can't add source balance to
    //                                          // destination balance
    //  };

    //  ===========================================================================
    public class AccountMergeResultCode
    {
        public enum AccountMergeResultCodeEnum
        {
            ACCOUNT_MERGE_SUCCESS = 0,
            ACCOUNT_MERGE_MALFORMED = -1,
            ACCOUNT_MERGE_NO_ACCOUNT = -2,
            ACCOUNT_MERGE_IMMUTABLE_SET = -3,
            ACCOUNT_MERGE_HAS_SUB_ENTRIES = -4,
            ACCOUNT_MERGE_SEQNUM_TOO_FAR = -5,
            ACCOUNT_MERGE_DEST_FULL = -6,
        }
        public AccountMergeResultCodeEnum InnerValue { get; set; } = default(AccountMergeResultCodeEnum);

        public static AccountMergeResultCode Create(AccountMergeResultCodeEnum v)
        {
            return new AccountMergeResultCode
            {
                InnerValue = v
            };
        }

        public static AccountMergeResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_SUCCESS);
                case -1: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_MALFORMED);
                case -2: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_NO_ACCOUNT);
                case -3: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_IMMUTABLE_SET);
                case -4: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_HAS_SUB_ENTRIES);
                case -5: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_SEQNUM_TOO_FAR);
                case -6: return Create(AccountMergeResultCodeEnum.ACCOUNT_MERGE_DEST_FULL);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, AccountMergeResultCode value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
