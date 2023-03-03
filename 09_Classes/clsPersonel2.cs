using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Classes
{
    public class clsPersonel2
    {
        // Değişkenler / Propların tanımlanması

        public int personelID;
        public string personelAd;
        public string personelSoyad;
        public string personelUnvan = null;
        public int personelMaas;
        public int personelIzinGunu;

        public void setPersonelBilgileri(string pAd, string pSoyad, int pMaas)
        {
            if (pAd.Length > 0 && pSoyad.Length > 0) // ad ve soyadın tam girilmesi kontrol edilir
            {
                if (pMaas >= 2500)
                {
                    this.personelAd = pAd;
                    this.personelSoyad = pSoyad;
                    this.personelMaas = pMaas;
                    this.personelIzinGunu = 14;


                    if (pMaas >= 10000 && pMaas <= 14000)
                    {
                        this.personelUnvan = "Kıdemli Personel";
                        this.personelIzinGunu = 20;
                    }
                    else if (pMaas >= 14001 && pMaas <= 15500)
                    {
                        this.personelUnvan = "Kıdemli+ Personel";
                        this.personelIzinGunu = 24;

                    }
                    else if (pMaas > 15500)
                    {
                        this.personelUnvan = "Uzman Personel";
                        this.personelIzinGunu = 30;

                    }
                    else
                    this.personelUnvan = "Junıor Personel";
                    
                }
                else
                {
                    Console.WriteLine("\nPersonel oluşturulamadı...");
                }
            }
            else
            {
                Console.WriteLine("\nGeçerli bir personel yok...");
            }

        }
        public string getPersonelBilgileri()
        {
            if (personelUnvan != null)
            {
                return $"Personel Ad: {personelAd}\n Personel Soyad : {personelSoyad}\n Personel Ünvan : {personelUnvan}\n Personel Maaş : {personelMaas}\n Personel İzin Günü : {personelIzinGunu} gün\n";
            }
            else
            {
                return $"Lütfen personeli oluşturunuz...";
            }
        }
    }
}
