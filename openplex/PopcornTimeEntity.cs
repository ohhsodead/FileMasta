using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPlex
{
    class PopcornTimeEntity
    {
        public string trailer { get; set; }
        public Images images { get; set; }
    }

    class Images
    {
        public string poster { get; set; }
        public string fanart { get; set; }
    }
}
