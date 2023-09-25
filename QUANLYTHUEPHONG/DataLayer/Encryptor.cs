using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Encryptor
    {
        public static string Encrypt(string toEncrypt, string key, bool useHashing)
        {
            byte[] keyArray ;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            if (useHashing )
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                keyArray = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
               
            }
            else
                keyArray =UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
            tripDes.Key = keyArray;
            tripDes.Mode = CipherMode.ECB;
            tripDes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cryptoTransform = tripDes.CreateEncryptor();
            byte[] resultArray =cryptoTransform.TransformFinalBlock(toEncryptArray,0,toEncryptArray.Length);
            return Convert.ToBase64String(resultArray,0,resultArray.Length);
        }

        public static string Decrypt(string toDecrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toDecrypt);
            if (useHashing)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                keyArray = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
            tripDes.Key = keyArray;
            tripDes.Mode = CipherMode.ECB;
            tripDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cryptoTransform = tripDes.CreateEncryptor();
            byte[] resultArray = cryptoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}
