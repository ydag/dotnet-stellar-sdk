// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union Asset switch (AssetType type)
//  {
//  case ASSET_TYPE_NATIVE: // Not credit
//      void;
//  
//  case ASSET_TYPE_CREDIT_ALPHANUM4:
//      AlphaNum4 alphaNum4;
//  
//  case ASSET_TYPE_CREDIT_ALPHANUM12:
//      AlphaNum12 alphaNum12;
//  
//      // add other asset types here in the future
//  };

//  ===========================================================================
public class Asset  {
  public Asset () {}

  public AssetType Discriminant { get; set; } = new AssetType();

  public AlphaNum4 AlphaNum4 {get; set;}
  public AlphaNum12 AlphaNum12 {get; set;}
  public static void Encode(XdrDataOutputStream stream, Asset encodedAsset) {
  stream.WriteInt((int)encodedAsset.Discriminant.InnerValue);
  switch (encodedAsset.Discriminant.InnerValue) {
  case AssetType.AssetTypeEnum.ASSET_TYPE_NATIVE:
  break;
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
  AlphaNum4.Encode(stream, encodedAsset.AlphaNum4);
  break;
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
  AlphaNum12.Encode(stream, encodedAsset.AlphaNum12);
  break;
  }
  }
  public static Asset Decode(XdrDataInputStream stream) {
  Asset decodedAsset = new Asset();
  AssetType discriminant = AssetType.Decode(stream);
  decodedAsset.Discriminant = discriminant;
  switch (decodedAsset.Discriminant.InnerValue) {
  case AssetType.AssetTypeEnum.ASSET_TYPE_NATIVE:
  break;
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
  decodedAsset.AlphaNum4 = AlphaNum4.Decode(stream);
  break;
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
  decodedAsset.AlphaNum12 = AlphaNum12.Decode(stream);
  break;
  }
    return decodedAsset;
  }
}
}
