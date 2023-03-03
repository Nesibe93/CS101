using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulation
{
    internal class clsBank
    {
        #region Normal Durum

        public long AccountNumber; // Hesap no
        public string Name;
        public int Balance; // Miktar

        public void GetBalance()
        {

        }
        public void WithdrawAccount()
        {

        }
        public void Deposit()
        {

        }

        #endregion

        #region Getter / Setter

        private double balance; // yani burada dışarıya kapalı bir değişken tanımı var..

        // set (setter) ve get (getter) metodlarının tanımlanması


        // Public getter metod
        // bu metod balance değişkeninde tutulan değeri almak için

        public double GetBalanceCaps()
        {
            // Burada farklı işlemler var...
            return balance;
        }

        // Public getter metod
        // bu metod balance değişkeninde tutulan değeri set/değiştirmek/güncellemek için

        public void SetBalanceCaps(double balance) // geriye değer döndürmeyen metod
        {
            // burada farklı işlemler var...

            this.balance = balance; // --> "this" benim kendi değişkenimi güncelleyeceksin demek

        }


        #endregion


        #region 

        public int Amount;

        // Daha sonra gelecekte, müşteri uygulamanın negatif bir değere izin verememesini istiyor. Ardından miktar değişkeninde saklamadan önce kullanıcı tarafından verilen değerleri doğrulamalıyız. Bu nedenle, kapsülleme ilkesini aşağıdaki gibi izleyerek uygulamayı geliştirmemiz gerekir. 

        public int GetAmount() // get metodu
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Lütfen pozitif bir sayı giriniz...");
            }
        }

        private int _Amount1;

        public int Amount1 
        {
            get
            {
                return _Amount1;

            }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Lütfen pozitif bir değer giriniz...");
                }
                else
                {
                    _Amount1 = value;
                }
                
            }
            
        }
        public int _Amount2 { get; set; } // en sade - kontrolsüz kullanım

        #endregion

    }
}
