using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccesModifiers
{
    internal class clsStudent
    {
        public string name = "Nesibe"; // private -> public 
        public void getName() // public -> private
        {
            Console.WriteLine("Öğrencinin Adı : {0}",this.name);
        }

    }
}
