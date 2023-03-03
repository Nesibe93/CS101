internal class Program
{
    private static void Main(string[] args)
    {
        #region Matematiksel
        // Mod alma opertaörü

        int a = 5 % 2;
        Console.WriteLine("Sonuç : " + a.ToString() + "\n\n");

        // Değişik bir durum
        // Eğer işlem yapılan her iki operand farklı türdeyse sonuç daha üst kapasiteli olan tipte tutulur

        float b = 5 / 2f;  // Burada 5 sayısı da float gibi davranmak durumunda. ve sonuç ondalıklı çıkar
        Console.WriteLine("değişik durum sonucu = " + b.ToString());

        //değişik durum 2
        float c = 2 / 5 / 2f; // sonuç 0 çıkacaktır. Çünkü işlem yapılırken zaten sonuç aslında 0 lanmıştı

        Console.WriteLine("değişik durum sonucu2 = " + b.ToString());

        // değişik durum 3
        float d = 2f / 5 / 2; // işlem sol taraftan ondalıklı olarak başladığı için sonuç ondalıklı çıkacaktır

        Console.WriteLine("değişik durum sonucu3 = " + b.ToString());

        // Daha da ilginç durum
        float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3;
        Console.WriteLine("değişik durum4 sonucu " + e.ToString());



        #endregion

        #region Bir artırma ve bir eksiltme operatörleri

        int fonceki = 5;
        int fsonraki = ++fonceki; // Ön ek Örneği: hem fonceki değerini 1 artırıyor hem de bu değeri tutuyor..Sonrasında fsonraki değişkenine atıyor

        Console.WriteLine("Önceki değer = " + fonceki.ToString());
        Console.WriteLine("Sonraki değer = " + fsonraki.ToString());

        int gonceki = 20;
        int gsonraki = gonceki++; // Son ek örneği: Önce gonceki değerini gsonrakiye aktarıyor..sonra değerini artırıyor

        Console.WriteLine("Önceki değer = " + gonceki.ToString());
        Console.WriteLine("Sonraki değer = " + gsonraki.ToString());



        #endregion

        #region Ortaya Karışık

        int h = 5;
        int i = h++;
        int j = i--;
        int k = 10;
        int l = --k;

        Console.WriteLine("Sonuçlar : h = değeri = {0}\ti değeri = {1}\tj değeri = {2}\tl değeri = {3}\n", h, i, j, l);


        #endregion

        #region Karşılaştırma Operatörleri

        bool m = 4 < 6;
        bool n = 6 > 5;
        bool o = 7 <= 7;
        bool p = 9 >= 12;
        bool q = 10 == 12;
        bool r = 1 != 8;

        Console.WriteLine("Sonuçlar : m değeri = {0}\tn değeri = {1}to değeri = {2}\tp değeri = {3}\tq = {4}\tr = {5}\n" , m,n,o,p,q,r);

        #endregion

        #region as Operatörü
        // tüm değişken türlerinden object değişken türüne ve object türünden de referans değişkenler dönüş işlemini yapar. Eğer dönüşüm olmazsa null değer geri döner

        object s = 50;
        string t = s as string;

        int u = 50;
        object v = u as object;


        #endregion




        Console.ReadKey();
    }
}