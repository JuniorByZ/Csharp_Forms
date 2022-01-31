using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_in_sharp
{
    internal class otomobil
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int modelyil { get; set; }
        public string renk { get; set; }
        public string vitestip { get; set; }

        public string markagetir()
        {
            return marka;
        }


    }
}
