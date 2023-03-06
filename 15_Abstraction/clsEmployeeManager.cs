using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    // işletme içerisinde beden işçisi statüsünde çalışan kişiler için EmployeeManager isminde bir sınıf
    // oluşturarak bu sınıfı kalıtım yoluyla üst sınıfını clsEmployeeBaseManager secerek gerekli kodları yazalım
    internal class clsEmployeeManager : clsEmployeeBaseManager
    {

        public clsEmployeeManager() // Bu class/nesne ilk oluştuğunda  default en taban Title tanımlı oluşturmak için 
        {
            setTitle("Beden işçisi");
        }
        public override void doRaise() // çalışana zam yapan metod
        {
            double salary = getSalary(); // yani oluşturulmuş olan çalışanın o an ki maaşını öğreniyorum
            double raise = salary + 500; // raise --> zamlı maaşım olmuş oluyor...

            setSalary(raise); // Burada da çalışanın yeni zamlı maaşı işlendi..
        }

        public override void doRaise(double prmRaiseRate) // Çalışana zam + prim yapan metod 
        {
            double salary = getSalary();
            double raise = salary * (salary * prmRaiseRate);

            setSalary(raise); // Yeni güncellenmiş maaş...
        }
    }
}
