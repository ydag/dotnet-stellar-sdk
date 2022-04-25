// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union LiquidityPoolWithdrawResult switch (LiquidityPoolWithdrawResultCode code)
//  {
//  case LIQUIDITY_POOL_WITHDRAW_SUCCESS:
//      void;
//  default:
//      void;
//  };

//  ===========================================================================
public class LiquidityPoolWithdrawResult  {
  public LiquidityPoolWithdrawResult () {}

  public LiquidityPoolWithdrawResultCode Discriminant { get; set; } = new LiquidityPoolWithdrawResultCode();

  public static void Encode(XdrDataOutputStream stream, LiquidityPoolWithdrawResult encodedLiquidityPoolWithdrawResult) {
  stream.WriteInt((int)encodedLiquidityPoolWithdrawResult.Discriminant.InnerValue);
  switch (encodedLiquidityPoolWithdrawResult.Discriminant.InnerValue) {
  case LiquidityPoolWithdrawResultCode.LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_SUCCESS:
  break;
  default:
  break;
  }
  }
  public static LiquidityPoolWithdrawResult Decode(XdrDataInputStream stream) {
  LiquidityPoolWithdrawResult decodedLiquidityPoolWithdrawResult = new LiquidityPoolWithdrawResult();
  LiquidityPoolWithdrawResultCode discriminant = LiquidityPoolWithdrawResultCode.Decode(stream);
  decodedLiquidityPoolWithdrawResult.Discriminant = discriminant;
  switch (decodedLiquidityPoolWithdrawResult.Discriminant.InnerValue) {
  case LiquidityPoolWithdrawResultCode.LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_SUCCESS:
  break;
  default:
  break;
  }
    return decodedLiquidityPoolWithdrawResult;
  }
}
}
