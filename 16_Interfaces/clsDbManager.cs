using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    // DataBase lerimi yönetecek
    internal class clsDbManager
    {
        private IDatabase database; // Interfaceden bir değişken tanımladım

        public clsDbManager() // Default Constructor

        {

        }
        
        public clsDbManager(IDatabase database) // Parametrik constructor ben buraya o anki Db class ının kendisini göndericem. 
        {

            this.database = database; // O anki gelen db parametresine göre içsel değeri değiştiriyoruz
        }

        public void loginDB() // Sistem Giriş
        {
            string userNAme, password;

            Console.WriteLine("<Veri tabanı Bağlantısı -> \n\n -> Kullanıcı Adı:");

            userNAme= Console.ReadLine();   

            Console.WriteLine("-> Kullanıcı şifresi");

            password = Console.ReadLine();
        }


    }
}
