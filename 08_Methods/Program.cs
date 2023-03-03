
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // Dikdörtgenin alanını hesaplayan bir metodun 4 farklı şeklinin incelenmesi

        #region 1.Geriye değer döndürmeyen ve parametre almayan metodlar

        Hesapla();

        #endregion

        #region 2.Geriye değer döndürmeyen ve parametre alan metodlar
        Console.WriteLine("Kısa kenar : ");
        int kısaK = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Uzun kenar : ");
        int uzunK = Convert.ToInt32(Console.ReadLine());

        Hesapla(kısaK, uzunK);  // hesapla isimli metoda parametre giriyoruz

        #endregion

        #region 3. Geriye değer döndüren ve parametre almayan metodlar

        int sonuc = HesaplaParametresiz(); // sonuc = alan (returnden gelen)

        Console.WriteLine("Alan = {0}", sonuc);

        #endregion

        #region 4. Geriye değer döndüren ve parametre alan metodlar

        Console.WriteLine("Kısa kenar : ");
        int kisa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Uzun kenar : ");
        int uzun = Convert.ToInt32(Console.ReadLine());

        //int sonuc1 = HesaplaParametreli(kisa,uzun);

        Console.WriteLine("Alan = {0}", HesaplaParametreli(kisa, uzun)); // hesaplaparametreli kısmı böyle console.writeline içinde yazabiliriz


        #endregion

        //Sınıf içi WO
        // Uygun metod yapısı kullarak 4 işlemi gerçekleştiriniz (+,-,*,/). Birden fazla metod tanımlayabilirsiniz

        // Ek: işlem tipini de alıp ona göre düşünelim

        //tek metodlu 
        //------------------------------------------------
        
        Console.WriteLine("Lütfen 1. sayıyı giriniz :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen 2.sayıyı giriniz");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen bir işlem seçiniz (+,-,*,/):" );
        string secenek = Console.ReadLine();

        
        Console.WriteLine("İşlem türü : " + secenek + "\n");
        Console.WriteLine("Sonuç : {0}",DortIslem(sayi1, sayi2, secenek));

        #region Metodlarda aşırı yükleme(Method overloading)

        Console.WriteLine("2 li toplama : {0}", toplamaIslemi(45, 45) + "\n");
        Console.WriteLine("3 lü toplama : {0}", toplamaIslemi(45, 45, 78) + "\n");
        Console.WriteLine("4 lü toplama : {0}", toplamaIslemi(45, 45, 90, 102) + "\n");

        #endregion


        #region Menülü bir şey
        // Ekrana seçenekli bir menü gelecek
        //seçenekleri 1- Hesap makinesi, 2- Tek/Çift kontrol
        // buna göre metodları hazırlayınız...(menüyü ekrana getirme,hesap makinesi,tek/çift..)

        // ilk seçenekte (1) normal hesap mak.
        //ikinci seçenekte 



        #endregion

        // 4 metodlu
        //----------------------------------------------------------------------
        Console.WriteLine("Sonuc = {0}", Toplama(sayi1, sayi2));
        Console.WriteLine("Sonuc = {0}", Cikarma(sayi1, sayi2));
        Console.WriteLine("Sonuc = {0}", Carpma(sayi1, sayi2));
        Console.WriteLine("Sonuc = {0}", Bolme(sayi1, sayi2));


       
    }

    #region Metodlar
    //----------------------------------------------------------------------------
    private static void Hesapla()
    {
        Console.WriteLine("Kısa kenar : ");
        int kısaKenar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Uzun kenar : ");
        int uzunKenar = Convert.ToInt32(Console.ReadLine());
        int alan = Convert.ToInt32(kısaKenar * uzunKenar);
        Console.WriteLine("Alan = {0}", alan);

        Console.ReadKey();
    }
    //------------------------------------------------------------------------------
    private static void Hesapla(int kısaK, int uzunK)
    {
        int alan = Convert.ToInt32(kısaK * uzunK);
        Console.WriteLine(("Alan = {0}"), alan);
    }
    //-------------------------------------------------------------------------------
    private static int HesaplaParametresiz()
    {
        // geriye değer döndüren metodlar veya functionlar da mutlaka return tanımı olmalıdır
        Console.WriteLine("Kısa kenar : ");
        int kısaK = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Uzun kenar : ");
        int uzunK = Convert.ToInt32(Console.ReadLine());

        int alan = kısaK * uzunK;
        return alan;
    }
    //--------------------------------------------------------------------------------
    private static int HesaplaParametreli(int kisa, int uzun)
    {
        int alan;
        return alan = kisa * uzun; // int alan = kisa * uzun 'un kısa hali
    }
    //---------------------------------------------------------------------------------
    //sınıf içi WorkOut kod kısmı
    // 4 metodlu
    private static int Toplama(int sayi1, int sayi2)
    {
        int sonuc;
        return sonuc = sayi1 + sayi2;
    }
    private static int Cikarma(int sayi1, int sayi2)
    {
        int sonuc;
        return sonuc = sayi1 - sayi2;
    }
    private static int Carpma(int sayi1, int sayi2)
    {
        int sonuc;
        return sonuc = sayi1 * sayi2;
    }
    private static int Bolme(int sayi1, int sayi2)
    {
        int sonuc;
        return sonuc = sayi2 / sayi1;

    }
    // Tek metodlu
    private static int DortIslem(int sayi1,int sayi2,string secenek)
    {
        int sonuc =0;

        if (secenek == "+")
        {
            sonuc = sayi1 + sayi2;
        }
        else if (secenek == "-")
        {
            sonuc = (sayi1 - sayi2);
        }
        else if (secenek == "*")
        {
            sonuc += sayi1 * sayi2;
        }
        else
        {
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch
            {
                Console.WriteLine("Sayi2 değeri : 0... değerlerin sırasını değiştirelim...");
                sonuc = sayi2 / sayi1;
            }
        }
        return sonuc;
    }

    //------------------------------------------------------------------------------
    private static int toplamaIslemi(int a, int b)
    {
        return a + b;
    }
    private static int toplamaIslemi (int a,int b,int c)
    {
        return a + b + c;
    }
    private static int toplamaIslemi (int a,int b,int c,int d)
    {
        return a + b + c + d;
    }
    
    public static void Menu()
    {
        Console.WriteLine("Lütfen aşağıdaki seçeneklerden birini seçiniz :");
        Console.WriteLine("1-Hesap Makinesi");
        Console.WriteLine("2-Tek/Çift Kontrol");

        int secim = Convert.ToInt32(Console.ReadLine());

        if(secim == 1)
        {
            hesapMakinesi();
        }
        else (secim == 2)
        {
            tekCiftKontrol();
        }


    }
    public static void hesapMakinesi()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
        Console.WriteLine("1-Toplama");
        Console.WriteLine("2-Çıkarma");
        Console.WriteLine("3-Çarpma");
        Console.WriteLine("4-Bölme");

        int secim = Convert.ToInt32(Console.ReadLine());
    }
    public static string tekCiftKontrol(int a)
    {
        Console.WriteLine("Lütfen seçeneklerden birini seçiniz : ");
        Console.WriteLine("Tek");
        Console.WriteLine("Çift");

        string geriDonusDegeri = " ";
        //.......
        return geriDonusDegeri;
    }


}



#endregion





