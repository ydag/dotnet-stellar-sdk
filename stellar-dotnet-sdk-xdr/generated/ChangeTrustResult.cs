// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union ChangeTrustResult switch (ChangeTrustResultCode code)
//  {
//  case CHANGE_TRUST_SUCCESS:
//      void;
//  default:
//      void;
//  };

//  ===========================================================================
public class ChangeTrustResult  {
  public ChangeTrustResult () {}

  public ChangeTrustResultCode Discriminant { get; set; } = new ChangeTrustResultCode();

  public static void Encode(XdrDataOutputStream stream, ChangeTrustResult encodedChangeTrustResult) {
  stream.WriteInt((int)encodedChangeTrustResult.Discriminant.InnerValue);
  switch (encodedChangeTrustResult.Discriminant.InnerValue) {
  case ChangeTrustResultCode.ChangeTrustResultCodeEnum.CHANGE_TRUST_SUCCESS:
  break;
  default:
  break;
  }
  }
  public static ChangeTrustResult Decode(XdrDataInputStream stream) {
  ChangeTrustResult decodedChangeTrustResult = new ChangeTrustResult();
  ChangeTrustResultCode discriminant = ChangeTrustResultCode.Decode(stream);
  decodedChangeTrustResult.Discriminant = discriminant;
  switch (decodedChangeTrustResult.Discriminant.InnerValue) {
  case ChangeTrustResultCode.ChangeTrustResultCodeEnum.CHANGE_TRUST_SUCCESS:
  break;
  default:
  break;
  }
    return decodedChangeTrustResult;
  }
}
}
