using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

//对称加密与解密类 SymmetricMethodData2007,
namespace JobLogging.Common
{
    public class SymmetricMethod
    {
        private readonly SymmetricAlgorithm _mobjCryptoService;
        private readonly string _key;

        //构造函数---------------------------------------------------------------------
        public SymmetricMethod()
        {
            //Rijndael由比利时计算机科学家Vincent Rijmen和Joan Daemen开发的"对称加密算法"
            _mobjCryptoService = new RijndaelManaged();
            //下面的KEY需要保密,可以自己定义,不要被它人得到----------------------------
            _key = "Guz(%&hj7x89H$yuBI0456FtmaT5&fvHUFCy76*h%(HilJ$lhj!y6&(*jkP87jH7";
        }
        //-----------------------------------------------------------------------------

        /// 获得密钥
        private byte[] GetLegalKey()
        {
            string sTemp = _key;
            _mobjCryptoService.GenerateKey();
            byte[] bytTemp = _mobjCryptoService.Key;
            int keyLength = bytTemp.Length;

            if (sTemp.Length > keyLength) sTemp = sTemp.Substring(0, keyLength);
            else if (sTemp.Length < keyLength) sTemp = sTemp.PadRight(keyLength, ' ');

            return Encoding.ASCII.GetBytes(sTemp);
        }

        /// 获得初始向量IV
        private byte[] GetLegalIV()
        {
            string sTemp = "E4ghj*Ghg7!rNIfb&95GUY86GfghUb#er57HBh(u%g6HJ($jhWk7&!hg4ui%$hjk";
            _mobjCryptoService.GenerateIV();
            byte[] bytTemp = _mobjCryptoService.IV;
            int IVLength = bytTemp.Length;

            if (sTemp.Length > IVLength) sTemp = sTemp.Substring(0, IVLength);
            else if (sTemp.Length < IVLength) sTemp = sTemp.PadRight(IVLength, ' ');

            return Encoding.ASCII.GetBytes(sTemp);
        }

        /// 加密方法
        public string EncryptoData(string source)
        {
            try
            {
                //类UTF8Encoding使用 8 位形式的 UCS 转换格式 (UTF-8) 对 Unicode 字符进行编码
                byte[] bytIn = Encoding.UTF8.GetBytes(source);
                MemoryStream ms = new MemoryStream();
                _mobjCryptoService.Key = GetLegalKey();
                _mobjCryptoService.IV = GetLegalIV();
                ICryptoTransform encrypto = _mobjCryptoService.CreateEncryptor();
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
                cs.Write(bytIn, 0, bytIn.Length);
                cs.FlushFinalBlock();
                ms.Close();
                byte[] bytOut = ms.ToArray();
                return Convert.ToBase64String(bytOut);
            }
            catch (Exception)
            {
                return source;
            }
        }

        /// 解密方法
        public string DecryptoData(string source)
        {

            try
            {
                byte[] bytIn = Convert.FromBase64String(source);
                MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);
                _mobjCryptoService.Key = GetLegalKey();
                _mobjCryptoService.IV = GetLegalIV();
                ICryptoTransform encrypto = _mobjCryptoService.CreateDecryptor();
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            catch (Exception)
            {
                return source;
            }
        }
    }
}