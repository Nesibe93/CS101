internal class Program
{
    private static void Main(string[] args)
    {
        #region Hata oluşturabilecek durum

        int a = 100;
        int b = 0; // istenmeyen bazı durumlarda aslında 0 olmayan bu değer sıfırlanmış olabilir...

        Console.WriteLine("{0} / {1} işleminin sonucu = {2}" ,a,b,a/b);

        #endregion

        #region  Try - Catch Hata avcısı

        int c = 100;
        int d = 0; // istenmeyen bazı durumlarda aslında 0 olmayan bu değer sıfırlanmış olabilir...

        try
        {
            Console.WriteLine("{0} / {1} işleminin sonucu = {2}", c, d, c / d);
        }
        catch
        {
            if (c !=0 && d == 0)
            {
                d = c / 10;
                Console.WriteLine("d değeri hata oluşturduğundan dolayı güncellenmiş ve {0} değeri atanmıştır...\n {1}/{2} işleminin sonucu = {3} tür" ,d,c,d, c/d);
            }
            else if (c==0 && d!=0)
            {
                c = d * 10;

                Console.WriteLine("c değeri hata oluşturduğundan dolayı güncellenmiş ve {0} değeri atanmıştır...\n {1}/{2} işleminin sonucu = {3} tür", c, c, d, c / d);
            }
            else if (c==0 && d==0)
            {
                c = 50;
                d = 10;

                Console.WriteLine("\n {0}/{1} işleminin sonucu = {2} tür", c, d, c / d);
            }
        }



        #endregion
        #region Hata Metodları

        byte deger;

        try
        {
            Console.Write("Byte türünden bir değer giriniz... :");
            deger = Convert.ToByte(Console.ReadLine());

        }
        catch (Exception hata)
        {
            Console.WriteLine("Message : {0}\n Source: {1}\n StackTrace: {2}\n TargetSite: {3}", hata.Message,hata.Source,hata.StackTrace,hata.TargetSite);
        }


        #endregion
        Console.ReadKey();
    }
}