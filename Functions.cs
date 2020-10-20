using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptioner
{
    class Functions
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string encodeText)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(encodeText);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
