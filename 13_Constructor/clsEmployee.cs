using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsEmployee
    {
        public int Id, Age;
        public string Address, Name;
        public bool isActive;

        public clsEmployee()  // User - defined Cosntructor
        {
            Id = 100;
            Age = 30;
            Address = "İstanbul";
            Name = "Nesibe";
            isActive = true;
        }
        public void DisPlayEmployee()
        {
            Console.WriteLine($"Employee Id : {Id}");
            Console.WriteLine($"Employee Age :  {Age}");
            Console.WriteLine($"Employee Name : {Name }");
            Console.WriteLine($"Employee Address : {Address }");
            Console.WriteLine($"Employee Status { isActive}");
                            
        }


    }
}
