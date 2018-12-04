using PCLCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Business_Logic
{
    public class Crypto
    {
        public void crypt()
        {
            byte[] keyMaterial = new byte[10]; 
            byte[] data = new byte[10];
            var provider = WinRTCrypto.SymmetricKeyAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithm.AesCbcPkcs7);
            var key = provider.CreateSymmetricKey(keyMaterial);

            // The IV may be null, but supplying a random IV increases security.
            // The IV is not a secret like the key is.
            // You can transmit the IV (w/o encryption) alongside the ciphertext.
            var iv = WinRTCrypto.CryptographicBuffer.GenerateRandom(provider.BlockLength);

            byte[] cipherText = WinRTCrypto.CryptographicEngine.Encrypt(key, data, iv);

            // When decrypting, use the same IV that was passed to encrypt.
            byte[] plainText = WinRTCrypto.CryptographicEngine.Decrypt(key, cipherText, iv);
        }
    }
}
