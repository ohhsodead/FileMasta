using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using NUnit.Framework;
using System.Collections;

namespace torrent.libtorrent
{
    [TestFixture]
    public class BencodingTest
    {
        [Test]
        public void DecodeString()
        {
            BenDecoder decoder = DecoderForString("4:spam");
            Assert.AreEqual("spam", decoder.ReadString().ToString());            
        }

        private static string Decode(byte[] bytes)
        {
            return new string(Encoding.Default.GetChars(bytes));
        }

        private static string Decode(object probablyString)
        {
            return Decode(probablyString as byte[]);
        }

        [Test]
        public void DecoderZeroLengthString()
        {
            BenDecoder decoder = DecoderForString("0:");
            Assert.AreEqual("", decoder.ReadString().ToString());
        }

        private static BenDecoder DecoderForString(string value)
        {            
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(value.ToCharArray()));  
            BenDecoder decoder = new BenDecoder(stream);
            return decoder;
        }

        [Test]
        public void DecodePositiveInteger()
        {
            BenDecoder decoder = DecoderForString("i3e");
            Assert.AreEqual(3L, decoder.ReadInt());
        }

        [Test]
        public void NegativeInteger()
        {
            BenDecoder decoder = DecoderForString("i-4e");
            Assert.AreEqual(-4L, decoder.ReadInt());
        }

        [Test]
        public void ListOfStrings()
        {
            BenDecoder decoder = DecoderForString("l4:spam4:eggse");
            IList list = decoder.ReadList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("spam", list[0].ToString());
            Assert.AreEqual("eggs", list[1].ToString());
        }

        [Test]
        public void ListOfIntsAndStrings()
        {
            BenDecoder decoder = DecoderForString("li4e4:spame");
            IList list = decoder.ReadList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(4, list[0]);
            Assert.AreEqual("spam", list[1].ToString());
        }

        [Test]
        public void ListOfLists()
        {
            BenDecoder decoder = DecoderForString("li18el4:spam4:eggsee");
            IList list = decoder.ReadList();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(18, list[0]);
            Assert.IsInstanceOfType(typeof(IList), list[1]);
        }

        [Test]
        public void ReadDictionary()
        {
            BenDecoder decoder = DecoderForString("d3:cow3:moo4:spam4:eggse");
            IDictionary dictionary = decoder.ReadDictionary();
            Assert.AreEqual(2, dictionary.Count);
            Assert.AreEqual("moo", dictionary["cow"].ToString());
            Assert.AreEqual("eggs", dictionary["spam"].ToString());
        }        

        [Test]
        public void ReadDictionaryOfDictionaries()
        {
            BenDecoder decoder = DecoderForString("d4:dictd4:spam4:eggsee");
            IDictionary dictionary = decoder.ReadDictionary();
            Assert.AreEqual(1, dictionary.Count);
            Assert.IsInstanceOfType(typeof(IDictionary), dictionary["dict"]);
        }
        
        [Test]
        [ExpectedException(typeof(BenDecoderException))]
        public void NonsenceInputThrowsException()
        {
            BenDecoder decoder = DecoderForString("Nonsence!");
            decoder.ReadDictionary();
        }
    }

    internal class BenDecoderException : Exception
    {
        public BenDecoderException(string message): base(message)
        {
           
        }
    }
}
