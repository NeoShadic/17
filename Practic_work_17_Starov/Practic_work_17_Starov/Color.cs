using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_17_Starov
{
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;
        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public override string ToString()
        {
            return $"RGB = {R} {G} {B}";
        }
    }
}
