// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union Memo switch (MemoType type)
//  {
//  case MEMO_NONE:
//      void;
//  case MEMO_TEXT:
//      string text<28>;
//  case MEMO_ID:
//      uint64 id;
//  case MEMO_HASH:
//      Hash hash; // the hash of what to pull from the content server
//  case MEMO_RETURN:
//      Hash retHash; // the hash of the tx you are rejecting
//  };

//  ===========================================================================
public class Memo  {
  public Memo () {}

  public MemoType Discriminant { get; set; } = new MemoType();

  public String Text {get; set;}
  public Uint64 Id {get; set;}
  public Hash Hash {get; set;}
  public Hash RetHash {get; set;}
  public static void Encode(XdrDataOutputStream stream, Memo encodedMemo) {
  stream.WriteInt((int)encodedMemo.Discriminant.InnerValue);
  switch (encodedMemo.Discriminant.InnerValue) {
  case MemoType.MemoTypeEnum.MEMO_NONE:
  break;
  case MemoType.MemoTypeEnum.MEMO_TEXT:
  stream.WriteString(encodedMemo.Text);
  break;
  case MemoType.MemoTypeEnum.MEMO_ID:
  Uint64.Encode(stream, encodedMemo.Id);
  break;
  case MemoType.MemoTypeEnum.MEMO_HASH:
  Hash.Encode(stream, encodedMemo.Hash);
  break;
  case MemoType.MemoTypeEnum.MEMO_RETURN:
  Hash.Encode(stream, encodedMemo.RetHash);
  break;
  }
  }
  public static Memo Decode(XdrDataInputStream stream) {
  Memo decodedMemo = new Memo();
  MemoType discriminant = MemoType.Decode(stream);
  decodedMemo.Discriminant = discriminant;
  switch (decodedMemo.Discriminant.InnerValue) {
  case MemoType.MemoTypeEnum.MEMO_NONE:
  break;
  case MemoType.MemoTypeEnum.MEMO_TEXT:
  decodedMemo.Text = stream.ReadString();
  break;
  case MemoType.MemoTypeEnum.MEMO_ID:
  decodedMemo.Id = Uint64.Decode(stream);
  break;
  case MemoType.MemoTypeEnum.MEMO_HASH:
  decodedMemo.Hash = Hash.Decode(stream);
  break;
  case MemoType.MemoTypeEnum.MEMO_RETURN:
  decodedMemo.RetHash = Hash.Decode(stream);
  break;
  }
    return decodedMemo;
  }
}
}
