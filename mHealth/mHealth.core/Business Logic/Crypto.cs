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
       

        public byte[] GenerateSalt()
        {
            byte[] cryptoRandomBuffer = new byte[16];
            NetFxCrypto.RandomNumberGenerator.GetBytes(cryptoRandomBuffer);
            return cryptoRandomBuffer;
        }
        public string HashPassword(byte[] key)
        {
            
            var hasher = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] hash = hasher.HashData(key);
            return Convert.ToBase64String(hash);

        }

         public byte[] DeriveKey(string password, byte[] salt)
        {
           
           // comes in from the user.
            // best initialized to a unique value for each user, and stored with the user record
            int iterations = 5000; // higher makes brute force attacks more expensive
            int keyLengthInBytes = 16;
            byte[] key = NetFxCrypto.DeriveBytes.GetBytes(password, salt, iterations, keyLengthInBytes);
            
            return key; 
        }

       

    }
}
