using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluntKeys
{
    class KeyCaptionPair
    {
        public KeyCaption From;
        public KeyCaption To;

        public KeyCaptionPair(ushort fromKey, ushort toKey)
        {
            From = new KeyCaption(fromKey);
            To = new KeyCaption(toKey);
        }

        public override string ToString() => $"{From.ToString()} => {To.ToString()}";
    }
}
