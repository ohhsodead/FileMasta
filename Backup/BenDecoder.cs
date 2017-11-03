using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace torrent.libtorrent
{
    public class BenDecoder
    {
        private BinaryReader source;       
        public BenDecoder(Stream source)
        {
            this.source = new BinaryReader(source, Encoding.UTF8);
        }

        internal ByteString ReadString()
        {
            string length = ReadUntil(':');
            return new ByteString(source.ReadBytes(int.Parse(length)));
        }

        internal long ReadInt()
        {
            source.ReadByte();
            string value = ReadUntil('e');
            return long.Parse(value);
        }

        private string ReadUntil(char endChar)
        {
            char letter = source.ReadChar();
            string value = "";
            while (letter != endChar)
            {
                value += letter;
                letter = source.ReadChar();
            }
            return value;
        }

        internal IList ReadList()
        {
            ArrayList list = new ArrayList();
            source.ReadByte();
            while (source.PeekChar() != 'e')
            {
                list.Add(ReadElement());
            }
            source.ReadByte();
            return list;
        }

        private object ReadElement()
        {
            char peek = (char)source.PeekChar();
            if (peek == 'i') return ReadInt();
            if (peek >= '0' && peek <= '9') return ReadString();
            if (peek == 'l') return ReadList();
            if (peek == 'd') return ReadDictionary();
            throw new BenDecoderException("Wrong format of bencoded data");
        }

        public IDictionary ReadDictionary()
        {
            Hashtable dictionary = new Hashtable();
            if (source.Read() != 'd') throw new BenDecoderException("Wrong format of bencoded data");
            while (source.PeekChar() != 'e')
            {
                string key = ReadString().ToString();
                object value = ReadElement();
                dictionary[key] = value;
            }
            source.Read();           
            return dictionary;
        }

        public static IDictionary Decode(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BenDecoder decoder = new BenDecoder(stream);
            IDictionary result = decoder.ReadDictionary();
            stream.Close();
            return result;
        }
    }
}
