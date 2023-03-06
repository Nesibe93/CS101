using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    internal abstract class clsEmployeeBaseManager
    {

        // Çalışanlar için temel bilgilerin tutulacağı değişkenler
        private string name, surname, title; // özlük bilgileri
        private double salary; // maaş
        private int annualLeave; // yıllık izin

        // Çalışan kişilerin bilgilerini yazdıracağımız metodlar

        public void getInfo()
        {
            if (annualLeave > 0)
            {
                // Eğer çalışan herhangi bir şekilde oluşturulmadıysa uayrı vermek için
                Console.WriteLine($"< Abstract Company Employee >\n\n-> İsim : {name} \n-> Soyİsim : {surname}\n-> Ünvan : {title}\n-> Maaş : {salary} PNG Kina\n-> Yıllık izin : {annualLeave}\n");
            }
            else
            {
                Console.WriteLine($"<Employee not found >\n\n");
            }
        }

        // Çalışan kişilerin bilgilerini set edeceğimiz metod

        public void setInfo(string pName, string pSurname, double pSalary)
        {
            if (pName.Length >= 3 && pSurname.Length >=2)
	        {
                this.name = pName;
                this.surname = pSurname;
                this.salary = pSalary;

                if (pSalary >= 8500 && pSalary <= 12000)
                {
                    this.title = "Deneyimli" + title;
                    this.annualLeave = 20;

                }
                else if (pSalary > 12001 && pSalary <= 15000)
                {
                    this.title = "Kıdemli" + title;
                    this.annualLeave = 24;
                }
                else if (pSalary >= 15001)
                {
                    this.title = "Uzman " + title;
                }

                else
                
                    this.annualLeave = 14;
                
                    Console.WriteLine("<ERROR>\n\n-> Çalışanınıza minimum 8500 vermeniz gerekmektedir. O yüzden çalışan kaydı oluşturulamamıştır..\n");

	        }
            else
                Console.WriteLine("<ERROR>\n\n-> Çalışan isim / soyisim uzunluğu gerekli kontrolleri karşılamıyor..kontrol ediniz..\n");
        }

        // Maaş bilgilerine erişim sağlanacak Getter / Setter metodları

        public double getSalary() // Maaşı öğrenme kısmı
        {
            return salary;
        }
        public void setSalary(double pSalary)
        {
            this.salary = pSalary;
        }
        // Ünvan bilgilerine erişim sağlanacak Getter / Setter metodları
        public void setTitle (string ptitle)
        {
            this.title = ptitle;
        }
        // Her nesne için özel zam seçenekleri olabileceği için Abstract metodlar tanımlanıyor + 

        public abstract void doRaise(); // düz zam

        public abstract void doRaise(double prmRaiseRate); // zam + prim


}

}




    
   


