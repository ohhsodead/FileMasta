using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Collections;
using System.IO;

namespace torrent.libtorrent
{
    [TestFixture]
    public class BEncoderTest
    {

        private static string Decode(object bytes)
        {
            return new string(Encoding.Default.GetChars(bytes as byte[]));
        }

        private static byte[] Encode(string victim)
        {
            return Encoding.Default.GetBytes(victim.ToCharArray());
        }

        [Test]
        public void EncodeInteger()
        {
            Assert.AreEqual(Encode("i42e"), BEncoder.Encode(42L));
        }

        [Test]
        public void EncodeByteString()
        {
            Assert.AreEqual(Encode("4:spam"), BEncoder.Encode(new ByteString("spam")));
        }               

        [Test]
        public void EncodeList()
        {            
            Assert.AreEqual(Encode("l4:spami42ee"), BEncoder.Encode(ListOf("spam", 42L)));
        }

       
        [Test]
        public void EncodeDictionary()
        {
            Hashtable dict = new Hashtable();
            Hashtable inner = new Hashtable();
            dict["list"] = ListOf("spam", "eggs");
            inner["key"] = 42L;
            dict["inner"] = inner;
            Assert.AreEqual(Encode("d3:keyi42ee"), BEncoder.Encode(inner));
            Assert.AreEqual(Encode("d5:innerd3:keyi42ee4:listl4:spam4:eggsee"), BEncoder.Encode(dict));
        }

        private IList ListOf(params object[] elements)
        {
            ArrayList list = new ArrayList();
            foreach (object element in elements)
            {
                if (element is string)
                {
                    list.Add(Encode(element as string));
                }
                else
                {
                    list.Add(element);
                }
            }
            return list;
        }
    }
}
