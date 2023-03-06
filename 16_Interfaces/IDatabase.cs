using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal interface IDatabase
    {
        // Bu Interface'de sadece metod yapılarını kodsuz olarak tanımlıyoruz. Yani şablonu oluşturuyoruz

        int login(string userName, string password); // Database imizde giriş yapan metod

        void close(); // Database mizi kapatıyoruz.

        void addValue(string value); // DataBase imize bir değer ekliyor

        void deleteValue(string value); // DataBase imizden değer siler

        void updateValue(string value); // DataBase imizde güncelleme yapar

        void getValue(); // DataBase imizden değer getirir
    }
}
