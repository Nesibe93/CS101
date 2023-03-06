using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            string userName, password;

            Console.WriteLine("<Veri tabanı Bağlantısı -> \n\n -> Kullanıcı Adı:");

            userName= Console.ReadLine();   

            Console.WriteLine("-> Kullanıcı şifresi");

            password = Console.ReadLine();

            if (database.login(userName,password) == 1)
            {
                menu();

            }
            else
                Console.WriteLine("Bağlantı bilgilerinde bir terslik var...kontrol ediniz\n");
        }

        public void logoutDB()
        {
            database.close();
        }
        private void addValue(string value) 
        {
            database.addValue(value);
        }
        private void deleteValue() 
        {
            database.deleteValue();
        }
        private void getValue()
        {
            database.getValue();
        }

        private  void menu() 
        {
            string value;
            int v;
            Console.WriteLine("<Veri tabanı işlemleri>\n");
            Console.WriteLine("[1] - Veri ekle\n [2] - Veri sil\n [3] - Veri getir\n [4] - Bağlantıyı kes\n");
            Console.Write("-> Yapmak istediğiniz işlem :");
            v = Convert.ToInt32(Console.ReadLine());

            switch (v)
            {
                case 1:
                    Console.Write("{0}\n-> Eklemek istediğimiz veri : ");
                    value = Console.ReadLine();

                    addValue(value);
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    deleteValue();
                    menu();
                    break;
                case 3:
                    Console.Clear();
                    getValue();
                    menu();
                    break;

                case 4:
                    logoutDB();
                    break;
                    
            }



        }


    }
}
