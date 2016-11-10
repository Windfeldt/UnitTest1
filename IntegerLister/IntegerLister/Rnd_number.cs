using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerLister
{
    public class Rnd_number
    {
        public Random rnd = new Random();
        public int numb;
        public int[] list;
        public Rnd_number()
        {
            int _numb = rnd.Next();
            numb = _numb;
            int[] _list = new int[] { numb };
            list = _list;
            string numb_split = Convert.ToString(numb);
        }
    }
}
