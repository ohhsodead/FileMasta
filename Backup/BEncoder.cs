using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace torrent.libtorrent
{
    class BEncoder
    {

        private static byte[] ConvertToBytes(string victim)
        {
            return Encoding.Default.GetBytes(victim.ToCharArray());
        }

        private static void Encode(long i, Stream buffer)
        {
            byte[] bytes = ConvertToBytes(string.Format("i{0}e", i));
            buffer.Write(bytes, 0, bytes.Length);            
        }

        private static void Encode(ByteString s, Stream buffer)
        {
            byte[] bytes = new ByteString(string.Format("{0}:{1}", s.ToString().Length, s)).ToBytes();
            buffer.Write(bytes, 0, bytes.Length);
        }

        private static void Encode(IList list, Stream buffer)
        {
            buffer.WriteByte((byte)'l');
            foreach (object element in list)
            {
                Encode(element, buffer);
            }
            buffer.WriteByte((byte)'e');
        }        

        private static void Encode(IDictionary d, Stream buffer)
        {
            buffer.WriteByte((byte)'d');
            ArrayList keys = new ArrayList(d.Keys);
            keys.Sort();
            foreach (object key in keys)
            {
                Encode(key, buffer);
                Encode(d[key], buffer);
            }
            buffer.WriteByte((byte)'e');
        }

        internal static byte[] Encode(object element)
        {
            MemoryStream buffer = new MemoryStream();
            Encode(element, buffer);
            byte[] result = new byte[buffer.Position];
            buffer.Seek(0, SeekOrigin.Begin);
            buffer.Read(result, 0, result.Length);
            return result;            
        }

        private static void Encode(object element, Stream buffer)
        {
            if (element is ByteString)
            {
                Encode(element as ByteString, buffer);
            }
            else if (element is string)
            {
                Encode(new ByteString(element.ToString()), buffer);
            }
            else if (element is long)
            {
                Encode((long)element, buffer);
            }
            else if(element is int)
            {
                Encode((int) element, buffer);
            }
            else if (element is byte[])
            {
                byte[] value = element as byte[];
                Encode(value, buffer);
            }
            else if (element is IList)
            {
                Encode(element as IList, buffer);
            }
            else if (element is IDictionary)
            {
                Encode(element as IDictionary, buffer);
            }
            else
            {
                throw new ApplicationException(string.Format("Unable to encode element of type: {0}",
                    element.GetType()));
            }
        }

        private static void Encode(byte[] value, Stream buffer)
        {
            string length = value.Length.ToString();
            buffer.Write(Encoding.Default.GetBytes(length.ToCharArray()), 0, length.Length);
            buffer.WriteByte((byte)':');
            buffer.Write(value, 0, value.Length);
        }
    }
}
