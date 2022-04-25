// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct Curve25519Secret
//  {
//      opaque key[32];
//  };

//  ===========================================================================
public class Curve25519Secret  {
  public Curve25519Secret () {}
  public byte[] Key {get; set;}

  public static void Encode(XdrDataOutputStream stream, Curve25519Secret encodedCurve25519Secret) {
    int keysize = encodedCurve25519Secret.Key.Length;
    stream.Write(encodedCurve25519Secret.Key, 0, keysize);
  }
  public static Curve25519Secret Decode(XdrDataInputStream stream) {
    Curve25519Secret decodedCurve25519Secret = new Curve25519Secret();
    int keysize = 32;
    decodedCurve25519Secret.Key = new byte[keysize];
    stream.Read(decodedCurve25519Secret.Key,0,keysize);
    return decodedCurve25519Secret;
  }
}
}
