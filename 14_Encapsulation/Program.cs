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

        



        Console.ReadKey();
    }
}