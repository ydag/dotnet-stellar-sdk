// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  enum ChangeTrustResultCode
//  {
//      // codes considered as "success" for the operation
//      CHANGE_TRUST_SUCCESS = 0,
//      // codes considered as "failure" for the operation
//      CHANGE_TRUST_MALFORMED = -1,     // bad input
//      CHANGE_TRUST_NO_ISSUER = -2,     // could not find issuer
//      CHANGE_TRUST_INVALID_LIMIT = -3, // cannot drop limit below balance
//                                       // cannot create with a limit of 0
//      CHANGE_TRUST_LOW_RESERVE =
//          -4, // not enough funds to create a new trust line,
//      CHANGE_TRUST_SELF_NOT_ALLOWED = -5,   // trusting self is not allowed
//      CHANGE_TRUST_TRUST_LINE_MISSING = -6, // Asset trustline is missing for pool
//      CHANGE_TRUST_CANNOT_DELETE =
//          -7, // Asset trustline is still referenced in a pool
//      CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES =
//          -8 // Asset trustline is deauthorized
//  };

//  ===========================================================================
public class ChangeTrustResultCode  {
  public enum ChangeTrustResultCodeEnum {
  CHANGE_TRUST_SUCCESS = 0,
  CHANGE_TRUST_MALFORMED = -1,
  CHANGE_TRUST_NO_ISSUER = -2,
  CHANGE_TRUST_INVALID_LIMIT = -3,
  CHANGE_TRUST_LOW_RESERVE = -4,
  CHANGE_TRUST_SELF_NOT_ALLOWED = -5,
  CHANGE_TRUST_TRUST_LINE_MISSING = -6,
  CHANGE_TRUST_CANNOT_DELETE = -7,
  CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES = -8,
  }
  public ChangeTrustResultCodeEnum InnerValue {get; set;} = default(ChangeTrustResultCodeEnum);

  public static ChangeTrustResultCode Create(ChangeTrustResultCodeEnum v)
  {
    return new ChangeTrustResultCode {
      InnerValue = v
    };
  }

  public static ChangeTrustResultCode Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 0: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_SUCCESS);
      case -1: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_MALFORMED);
      case -2: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_NO_ISSUER);
      case -3: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_INVALID_LIMIT);
      case -4: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_LOW_RESERVE);
      case -5: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_SELF_NOT_ALLOWED);
      case -6: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_TRUST_LINE_MISSING);
      case -7: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_CANNOT_DELETE);
      case -8: return Create(ChangeTrustResultCodeEnum.CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(XdrDataOutputStream stream, ChangeTrustResultCode value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}
