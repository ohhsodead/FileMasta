using System.Collections.Generic;

namespace torrent.libtorrent
{
    internal class HttpResponse
    {
        private string statusLine;
        private Dictionary<string, string> fields = new Dictionary<string, string>();
        private ByteString content;

        public HttpResponse(ByteString responseText)
        {
            int position = responseText.IndexOf("\r\n");
            statusLine = responseText.SubString(0, position).ToString();
            position += 2;
            int lineEnd = responseText.IndexOf("\r\n", position);
            ByteString fieldLine = responseText.SubString(position, lineEnd - position);
            while(!fieldLine.ToString().Equals(""))
            {
                fields[fieldLine.Split(':')[0].Trim().ToString()] = fieldLine.Split(':')[1].Trim().ToString();
                position = lineEnd + 2;
                lineEnd = responseText.IndexOf("\r\n", position);
                fieldLine = responseText.SubString(position, lineEnd - position);
            }

            content = responseText.SubString(lineEnd + 2);
        }
        
        public string StausLine
        {
            get
            {
                return statusLine; 
            }
        }

        public Dictionary<string, string> Fields
        {
            get { return fields; }
        }

        public ByteString Content
        {
            get { return content; }
        }
    }
}