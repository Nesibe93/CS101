using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsTest
    {
        public int i; // default = 0 olur
        public string s ; //default = " "
        public bool b; // default = false olur
        
        // Kural : class ismiyle aynı olacak bir metod aslında
        // constructor otomatik class devreye girdiğinde otomatik çalışan bir metod
        // değişik durumlarda initial işlemler yapmak için kullanılır

        // parametreli de kullanımı olabilir
        public clsTest()
        {
            i= 0;
            s = "Merhaba";
            b= true;
        }
    }
}
