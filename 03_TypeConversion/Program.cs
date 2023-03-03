internal class Program
{
    private static void Main(string[] args)
    {
        // Bilinçsiz tür dönüşümleri
        #region Bilinçsiz Tür Dönüşümleri
        //byte a = 10;
        //short b = 20;
        //sbyte c = 30;
        //int d = a + b + c;

        //Console.WriteLine(d);

        //string e = "Proje İŞKUR";
        //char f = 'A';
        //object g = e + " " + f + " " + d;
        //long h = d;
        //float i = h;
        //double j = i;
        //double k = 21.6;

        //Console.WriteLine("1.durum : " + d.ToString());
        //Console.WriteLine("2.durum : " + g.ToString());
        //Console.WriteLine("3.durum : " + (h + k));
        //Console.WriteLine("4.durum : " + h + k);

        #endregion

        #region Bilinçli Tür Dönüşümleri

        // aslında ilginç bir durumdur
        //--------------------------------------
        char l = 'H';
        int m = l;

        Console.WriteLine("5.durum : " + m.ToString());
        Console.WriteLine(" ");
        Console.WriteLine("\n\n\t");

        int r = 256;
        byte s = (byte)r;

        Console.WriteLine("6.durum : " + s.ToString());

        

        #endregion


        Console.ReadKey();
    }
}