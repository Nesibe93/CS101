using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{

    // abstract yapısını daha doğru bir şekilde kullanmak ve daha esnek bir hale getirebilmek için 
    // clsCreateEmployeeManager isminde ekleme işlemlerinin yönetileceği genel bir sınıf tanımlaması gerçekleştirelim
    // ve gerekli tanımlamaları oluşturalım
    // Burası elemanı yoktan var etmek..Personel listesi oluşturma gibi...

    internal class clsCreateEmployeeManager
    {
        public clsEmployeeBaseManager employeeBaseManager;
        private string name, surName;
        private double salary;

        public void Create()
        {
            Console.WriteLine("<Create Employee Manager>\n\n -> Çalışanın ismi : ");
            name = Console.ReadLine();

            Console.WriteLine(" -> Çalışanın soy ismi : Çalışanın ismi : ");
            surName =Console.ReadLine();

            Console.WriteLine("-> Çalışanın Maaşı : ");
            salary = Convert.ToInt32(Console.ReadLine());

            employeeBaseManager.setInfo(name, surName, salary);

            
        }

        public void getInfo()
        {
            employeeBaseManager.getInfo();
        }

        public void doRaise()
        {
            employeeBaseManager.doRaise(); // Normal çalışanlar için zam metodunu çağırıyoruz

            Console.WriteLine($"<Zam uygulandı>\n\n -> Yeni maaş : {employeeBaseManager.getSalary()} PNG Kina\n\n");
        }

        public void doRaise(double pRaiseRate)
        {
            employeeBaseManager.doRaise(pRaiseRate);

            Console.WriteLine($"<Primli zam uygulandı>\n\n-> Yeni Maaş: {employeeBaseManager.getSalary()} PNG Kina\n\n");
        }
    }

}
