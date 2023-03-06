using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    // Mühendis sınıfından personeller için kullanılacak class
    internal class clsEngineerManager : clsEmployeeBaseManager
    {
        public clsEngineerManager()
        {
            setTitle("Mühendis");
        }
        public override void doRaise()
        {
            double salary = getSalary(); // yani oluşturulmuş olan çalışanın o an ki maaşını öğreniyorum
            double raise = salary + 2500; // raise --> zamlı maaşım olmuş oluyor...

            setSalary(raise); // Burada da çalışanın yeni zamlı maaşı işlendi..
        }

        public override void doRaise(double prmRaiseRate)
        {
            double salary = getSalary();
            double raise = salary * (salary * prmRaiseRate) + (salary % 2); // Prim kısmı

            setSalary(raise); // Yeni güncellenmiş maaş...
        }
    }
}
