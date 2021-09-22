// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  union PublicKey switch (PublicKeyType type)
    //  {
    //  case PUBLIC_KEY_TYPE_ED25519:
    //      uint256 ed25519;
    //  };

    //  ===========================================================================
    public class PublicKey
    {
        public PublicKey() { }

        public PublicKeyType Discriminant { get; set; } = new PublicKeyType();

        public Uint256 Ed25519 { get; set; }
        public static void Encode(XdrDataOutputStream stream, PublicKey encodedPublicKey)
        {
            stream.WriteInt((int)encodedPublicKey.Discriminant.InnerValue);
            switch (encodedPublicKey.Discriminant.InnerValue)
            {
                case PublicKeyType.PublicKeyTypeEnum.PUBLIC_KEY_TYPE_ED25519:
                    Uint256.Encode(stream, encodedPublicKey.Ed25519);
                    break;
            }
        }
        public static PublicKey Decode(XdrDataInputStream stream)
        {
            PublicKey decodedPublicKey = new PublicKey();
            PublicKeyType discriminant = PublicKeyType.Decode(stream);
            decodedPublicKey.Discriminant = discriminant;
            switch (decodedPublicKey.Discriminant.InnerValue)
            {
                case PublicKeyType.PublicKeyTypeEnum.PUBLIC_KEY_TYPE_ED25519:
                    decodedPublicKey.Ed25519 = Uint256.Decode(stream);
                    break;
            }
            return decodedPublicKey;
        }
    }
}
