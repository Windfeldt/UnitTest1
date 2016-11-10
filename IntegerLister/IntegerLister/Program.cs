using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerLister
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rnd_number number = new Rnd_number();
            Rnd_number lister = new Rnd_number();
            Console.WriteLine(number.numb);
            foreach (var item in lister.list)
            {
                Console.Write("{0}", item);
                Console.ReadKey();
            }
            
        }
    }
}
