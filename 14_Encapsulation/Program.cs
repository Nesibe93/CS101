﻿using _14_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Normal Durum (her şey açık)

        clsBank bank = new clsBank();

        bank.AccountNumber = 1234567890;
        bank.Name = "Santander Bank";
        bank.Balance = 500;

        bank.GetBalance();
        bank.WithdrawAccount();

        #endregion

        #region Getter / Setter

        clsBank bankgs = new clsBank();

        bankgs.SetBalanceCaps(500); // set etmek için

        Console.WriteLine($"Balance miktarı :  {bankgs.GetBalanceCaps() }"); // get etmek için

        #endregion


        #region Eğer sınıfı tasarlarken Kapsülleme (encapsulation) prensibine uymazsak ne olur?

        // sınıfı tasarlarken C# kapsülleme prensibini takip etmezsek, kullanıcı tarafından verilen verileri iş gereksinimlerimize göre doğrulayamayız


        clsBank bank2 = new clsBank();

        // pozitif bir değerle Amount değerini güncelliyim
        bank2.Amount = 100;

        Console.WriteLine($"Bankadaki miktar : {bank2.Amount} PNG Kina");

        bank2.Amount = -150; // aslında istenmeyen bir durumdur

        Console.WriteLine($"Bankadaki miktar : {bank2.Amount} PNG Kina");

        //Hata yakalama bölümü
        try
        {
            clsBank bank3= new clsBank();

            bank3.SetAmount(1500);

            Console.WriteLine($"\n\nDüzgün durum\n\nBankadaki miktar : {bank3.GetAmount()} PNG Kina");

            bank3.SetAmount(-5000);

            Console.WriteLine($"Bankadaki miktar : {bank3.GetAmount()} PNG Kina");
        }
        catch (Exception hata)
        {
            Console.WriteLine(hata.Message);
        }

        #endregion


        Console.ReadKey();
    }
}