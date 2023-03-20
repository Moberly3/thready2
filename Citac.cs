using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thready2
{
    internal class Citac
    {
        private int value;

        public void Zvys()
        {
            for(int i = 0; i < 10000; i++) 
            {
                value++;
                System.Console.WriteLine(value);
            }
            
        }

        public void Sniz()
        {
            for (int i = 0; i < 10000; i++)
            {
                value--;
                System.Console.WriteLine(value);
            }
        }

    }
}
