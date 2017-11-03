using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Web;

namespace torrent.libtorrent
{
    public class Hash
    {
        private byte[] hash;
        
        public Hash(byte[] data)
        {
            hash = data;
        }
        
        public static Hash Compute(byte[] data)
        {
            return new Hash(SHA1.Create().ComputeHash(data));
        }
        public byte[] Value
        {
            get { return hash; }
        }

        public string ToHexString()
        {
            StringBuilder builder = new StringBuilder(40);
            foreach (byte value in hash)
            {
                builder.AppendFormat("{0:X2}", value);
            }
            return builder.ToString();
        }

        public string ToUrlString()
        {
            return HttpUtility.UrlEncode(hash);
        }
        
        public override bool Equals(object other)
        {
            if(other is Hash)
            {
                Hash o = other as Hash;
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i] != o.hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
