using System;
using System.Collections.Generic;
using System.Text;

namespace torrent.libtorrent
{
    public class ByteString
    {
        private byte[] bytes;
        private string stringValue;
        
        public ByteString(byte b): this(new byte[] {b})
        {
            
        }

        public ByteString(byte[] bytes)
        {
            this.bytes = bytes;
            stringValue = Encoding.Default.GetString(bytes);
        }
        
        public ByteString(byte[] source, int start, int length)
        {
            bytes = new byte[length];
            Array.Copy(source, start, bytes, 0, length);
            stringValue = Encoding.Default.GetString(bytes);
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is ByteString))
            {
                return false;
            }
            else
            {
                return stringValue.Equals((obj as ByteString).ToString());
            }
        }

        public override int GetHashCode()
        {
            return stringValue.GetHashCode();
        }

        public ByteString(string value)
        {
            stringValue = value;
            bytes = Encoding.Default.GetBytes(value);
        }

        public override string ToString()
        {
            return stringValue;
        }

        public static ByteString operator + (ByteString first, ByteString second)
        {
            return new ByteString(string.Concat(first.ToString(), second.ToString()));    
        }
       
        public static ByteString operator +(ByteString first, byte[] second)
        {
            return first + new ByteString(second);
        }
        
        public static ByteString operator +(ByteString first, string second)
        {
            return first + new ByteString(second);
        }
        
        public byte[] ToBytes()
        {
            return bytes;
        }

        public int IndexOf(string searchString)
        {
            return stringValue.IndexOf(searchString);
        }
        
        public int IndexOf(string searchString, int start)
        {
            return stringValue.IndexOf(searchString, start);
        }

        public ByteString SubString(int start, int length)
        {
            return new ByteString(stringValue.Substring(start, length));
        }
        
        public ByteString SubString(int start)
        {
            return SubString(start, stringValue.Length - start);
        }
        
        public ByteString[] Split(params char[] separator)
        {
            return new List<string>(stringValue.Split(separator)).ConvertAll<ByteString>(delegate(string input){ return new ByteString(input);}).ToArray();
        }

        public ByteString Trim()
        {
            return new ByteString(stringValue.Trim());
        }
    }
}
