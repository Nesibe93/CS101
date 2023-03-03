using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Dizi tanımlama, değer atama, kullanma

        int[] dizi = new int[20]; // 20 Elemanlı dizi isimli bir dizi yaratılıyor

        dizi[5] = 30; // 5. indexine bir değer atanıyor

        Console.WriteLine(dizi);













        int[] dizi4 = new int[] { 1, 2, 3 };

        Console.WriteLine("1 ile 10 arasında bir sayı giriniz");
        int boyut = Convert.ToInt32(Console.ReadLine());

        int[] dizi5 = new int[] { boyut + 5 };

        dizi5[5] = 30;
        Console.WriteLine(dizi5[5]);

        int[] dizi6 = new int[10], dizi7 = new int[20];

        // Verilen bir string dizisini, ters sırada (sondan başa doğru) listeleme

        string[] myUCC08Team = { "Nur", "Nergis", "Büşra", "Helin", "Özcan", "Berna", "Ferit Kaptan", "Nesibe", "Özdenur", "Aleyna", "İlker", "Ertuğrul", "Burak", "Mehmet Doğan", "scrat" };

        int son = myUCC08Team.Length - 1;

        for (int = 0;  <; --i)
        {

        }

        #endregion


        #region for/foreach döngülerinin kullanımı
        // verilen bir tamsayı 


        //// foreach
        //int[] sayilar2 = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam = 0;
        //foreach(int i in sayilar2)
        //{
        //    toplam += i;
        //}
        //Console.WriteLine(toplam);

        // |--------------------------------------------------------------------------------------------------|

        //Kullanıcıdan alınan metin içindeki sesli harf sayısını bulma

        char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'ü', 'ü' }; // daha sonra kullanacağım içinde tüm sesli harfleri içeren bir diziyi öncelikle bir oluşturuyoruz

        char[] hangileri = new char[sesliler.Length - 1]; // Bulduğum seslileri yerleştireceğim dizi

        int hangileriIndex = 0; //  hangileri dizisinin indexi

        string metin = " "; // ekrandan alacağım metin bilgisini tutmak için oluşturuyorum.

        int adet = 0; // benim sesli harf adedini tutacak

        Console.WriteLine("Metin giriniz : ");

        metin = Console.ReadLine().ToLower(); // ekrandan girilen metini okudum ve yerleştirdim ve tüm stringi küçük harfe çevirdim... Çünkü elimdeki hazır dizi küçük harfli.

        // girilen metnin ilk boyunu kullanacağım

        // birinci for döngüsü tanımlamış olduğum sesliler dizisi üzerinde dolaşacak (kontrol amacıyla)
        for (int i = 0; i < sesliler.Length; i++)
        {
            // ikinci for çevrimi de ekrandan alınan metin için
            for (int j = 0; j < metin.Length; j++)
            {
                if (metin[j] == sesliler[i])  // girilen metini dizi gibi algılatıp benim sesliler dizisindeki bir karaktere uyuyor mu
                {

                    hangileri[hangileriIndex] = metin[j]; // bulduğum sesli harfi başka bir diziye koyuyorum
                    hangileriIndex++;
                    adet++; // seslileri tutuyor
                }

            }

        }


        foreach (int i in hangileri)
        {
            Console.WriteLine("\n\nkarakter : " + i);

        }

        Console.WriteLine("Girmiş olduğunuz metinde {0} adet sesli harf vardır... ", adet);


        char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u', 'y' };
        
        Console.WriteLine("Lütfen metin giriniz: ");
        string metin = Console.ReadLine();



        Console.WriteLine("Sesli harfler: ");
        foreach (char harf in metin)
        {
            if (Array.IndexOf(sesliHarfler, Char.ToLower(harf)) >= 0)
            {
                Console.Write(harf + " ");
                
            }
        }


        int[] sayilar5 = { 10, -3, 5, 0, 33, -2, -60, 0, -20, -10 };

        int sifirSay =0 , pozitifSay = 0, negatifSay = 0;

        for (int x = 0; x < sayilar5.Count(); x++)
        {
            if (sayilar5[x] < 0)
            {
                negatifSay++;
            }

            else if (sayilar5[x] > 0)
            {
                pozitifSay++;
            }
            else
            {
                sifirSay++;
            }

        }





        #endregion


        #region Çok boyutlu diziler
        
        int[,] dizi9 = new int[3, 2]; // 3 boyutlu dizi

        int[,] dizi10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        int[,,] dizi11 = new int[3, 2, 2]; // 3 boyutlu dizi

        int[,,] dizi12 = { { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 } } };

        // dizi elemanlarını for döngüsü ile değiştirmek

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                  dizi12[i, j, k] = 20;


        #endregion


        #region Dizilerde kullanılan bazı metodlar

        // GetLenght

        int[] dizi14 = { 1,4,7,9 };

        Console.WriteLine(dizi14.GetLength(0));

        int[,] dizi15 = { { 2, 4, 2,4 }, { 7, 10, 4,5 }, { 7, 12, 6,9 }, { 2, 1, 12,34 } };

        byte boyut1 = (byte)dizi15.GetLength(1);

        Console.WriteLine(boyut1);

        #endregion


        //Create Instance // Çalışma anında dizi yaratılır

        Array dizi17 = Array.CreateInstance(typeof(int), 5); // int türünden 5 elemanlı dizi17 adında bir dizi tanımlandı ve dizinin her bir elemanına int türünün varsayılan değeri atandı

        Array dizi18 = Array.CreateInstance(typeof(int), 3, 2, 5); // burada 3x2x5 boyutunda int türünden 3 boyutlu bir dizi oluşturuldu

        // ilginç bir kullanım
        int[] dizi19 = new int[5](2, 3, 6, 8, 7); // Burada 2x3x6x8x7 boyutunda 5 boyutlu bir dizi oluşturuldu

        // Dikkat ! CreateInstance yöntemiyle oluşturulan dizilere DiziAdi[0,4] gibi bir yöntemle erişilemez. Peki nasıl olacak bu iş...

        Array dizi21 = Array.CreateInstance(typeof(int), 5, 4, 3);

        for (int i = 0; i < dizi21.GetUpperBound(0); i++) // bir dizinin son indeks numarasını verir

        { }

        // Dizi kopyalama

        // |-----------------------------------------------------------------------------------------------------------|
        // Dizi sıralama
        // diziyi CreateInstance ile yaratıp.. içini doldurup..sıralamasını hazır metoda yaptırmak...

        #region Dizi sıralama
        Array metinsel = Array.CreateInstance(typeof(string), 8);

        //metinsel[0] = "İstanbul";
        metinsel.SetValue("İstanbul", 0);
        metinsel.SetValue("Ankara", 1);
        metinsel.SetValue("İzmir", 2);
        metinsel.SetValue("Bursa", 3);
        metinsel.SetValue("Manisa", 4);
        metinsel.SetValue("Kastamonu", 5);
        metinsel.SetValue("Muğla", 6);
        metinsel.SetValue("Bolu", 7);

        Console.WriteLine("--- Sırasız dizi : ");

        foreach (string sehirIsim in metinsel)
            Console.Write(sehirIsim + " ");

        Console.WriteLine("\n\n--- Sıralı dizi : ");

        Array.Sort(metinsel);

        foreach (string sehirIsim  in metinsel)
            Console.WriteLine(sehirIsim + " ");

        // Ters sırada isterse
        Array.Reverse(metinsel); // Reverse : Ters sıralıyor
        Console.WriteLine(" ");
        foreach (string sehirIsim in metinsel)
            Console.WriteLine(sehirIsim + " ");

        #endregion

        #region Dizilerde arama

        int[] dizi28 = { 500, 68, 234, 56, 2 };

        Array.Sort(dizi28);

        foreach (int i in dizi28)
            Console.Write(i + " ");

        Console.Write("dizi28 Index : " + Array.BinarySearch(dizi28,56));
        // BinarySearch metodu bir nesneyi dizi içerisinde arar, eğer bulursa bulduğu nesnenin indexini tutar. bulamazsa negatif bir değer tutar
        // eğer BinarySearch ü kullanmak istiyorsak zorlama gereği önce ve önce diziyi bir sort ile sıralamak gerekiyor

        if (Array.BinarySearch(dizi28,561)< 0)
        {
            Console.WriteLine("Aramış olduğunuz değer dizide yoktur");
        }

        #endregion




    }
}