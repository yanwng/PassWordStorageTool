using System;
using System.Collections.Generic;
using System.Text;

namespace PassWordStorageTool.HelpClass
{
    public static class EncryptionHelper
    {

        private static byte offest = 10;

        public static string EncryptionKey(string key)
        {
            string result = "";
            for(int i = 0; i < key.Length; i++)
            {
               byte[]  bytes = BitConverter.GetBytes(key[i]);
                bytes[0] += offest;
                result += BitConverter.ToChar(bytes);
            }

            return result;
        }

        public static string DecryptionKey(string key) 
        {
            string result = "";
            for (int i = 0; i < key.Length; i++)
            {
                byte[] bytes = BitConverter.GetBytes(key[i]);
                bytes[0] -= offest;
                result += BitConverter.ToChar(bytes);
            }

            return result;
        }


    }
}
