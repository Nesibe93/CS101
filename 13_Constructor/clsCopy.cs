using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsCopy
    {
        int x;
        string mesaj = "Parametre geliyor olay değişiyor";

        public clsCopy(int i)
        {
            x = i;

        }

        public clsCopy(clsCopy obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine($"X değişkeninin değeri : {x}");
            Console.WriteLine($"{mesaj}");
        }

    }
}
