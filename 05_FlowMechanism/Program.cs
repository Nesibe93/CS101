internal class Program
{
    private static void Main(string[] args)
    {
        //#region if-else

        //// if else deyimi sayesinde belli bir koşul sağlandığında söz konusu komutlar çalıştırılır, o belli koşullar sağlanmadığında çalıştırılmaz ya da başka komutlar çalıştırılır.
        ////Syntax : 
        //// if (koşul)
        ////    komut1;
        //// else
        ////    komut2;
        ////
        //// veya
        ////
        //// if(koşul)
        //// {
        ////    komutlar1
        //// }
        ////else
        //// {
        ////    komutlar2
        //// }

        //int c = 5, d = 7;
        //if (c < d)
        //{
        //    Console.WriteLine("c değeri d değerinden küçüktür...");
        //    Console.WriteLine(c);
        //}
        //else
        //{
        //    Console.WriteLine("c değeri d değerinden büyüktür");
        //    Console.WriteLine(d);
        //}

        //// if else yapılarında else kısmının bulunması zorunlu değildir. Bu durumda sadece koşul sağlandığında bir şeyler yapılacak, koşul sağlanmadığında bir şeyler yapılmayacaktır.

        //int e=5,f=7;

        //if (e>f)
        //{
        //    Console.WriteLine("e f den küçük...");
        //}

        //// şöyle de bir kullanım olabilir...

        //Console.WriteLine("Lütfen cinsiyet bilgisini giriniz...(e,k) : ");
        //char cinsiyet = Convert.ToChar(Console.ReadLine());

        //if (cinsiyet == 'e')
        //{
        //    Console.WriteLine("Erkek");

        //}
        //else if (cinsiyet == 'k')
        //{
        //    Console.WriteLine("Kadın");
        //}
        //else
        //{
        //    Console.WriteLine("Lütfen doğru karakter giriniz..");
        //}


        ////ekrandan parola bilgisi alıyoruz. eğer porola "1234" ise doğru değilse yanlış

        //Console.WriteLine("Lütfen parola giriniz...");

        //int Parola = Convert.ToInt32(Console.ReadLine());

        //if (Parola == 1234)
        //{
        //    Console.WriteLine("Parola doğru..");
        //}
        //else
        //{
        //    Console.WriteLine("Parola yanlış");
        //}

        //// iki kontrol
        //// ekrandan hem kullanıcı adı hem de şifresi alınacak
        //// ve kontrole göre mesajlar verilecek

       
        ///*string username;
        //string userpass;
        //const string UN = "admin";
        //const string UP = "Q1W2e3";



        //Console.WriteLine("Kullanıcı adını giriniz...");
        //username = Console.ReadLine();
        //Console.WriteLine("Şifrenizi giriniz");
        //userpass = Console.ReadLine();


        //if (username == UN && userpass == UP)
        //{
        //    Console.WriteLine("Kullanıcı adı ve şifre doğru");
        //}
        //else
        //{
        //    Console.WriteLine("Kullanıcı adı ve şifre yanlış");
        //}

        //*/

        //string username;
        //string userpass;
        //const string UN = "admin";
        //const string UP = "Q1W2e3";

        //Console.WriteLine("Kullanıcı adını giriniz...");
        //username = Console.ReadLine();
        //Console.WriteLine("Şifrenizi giriniz");
        //userpass = Console.ReadLine();

        //if (username == UN)
        //{
            
        //    if (userpass == UP)
        //    {
        //        Console.WriteLine("Eyvallah buyrun geçin..");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen Parola yanlış..Kontrol ediniz");
        //    }

        //}
        //else
        //{
        //    Console.WriteLine("Girilen kullanıcı adı yanlış..Kontrol ediniz");
        //}





        //#endregion

        //#region Switch-Case

        ////switch(ifade)
        //// {
        //// case sabit1;
        ////      komut1;
        ////      break;
        //// case sabit2;
        ////      komut2;
        ////      break;
        ////    default:
        ////      komut3;
        ////      break;


        //// Bazı bilinmesi gerekenler

        //// -> Aynı birden fazla case sabiti olamaz
        //// -> Herhangi bir case'e ait komutların "break;" satırı ile sonlandırılması gerekmektedir. Eğer sonlandırılmazsa program hata verir.


        ////int g = 4;
        ////switch (g)
        ////{
        ////    case 4:
        ////        Console.WriteLine("değer 4");
        ////        break;
        ////    case 5:
        ////        Console.WriteLine("değer 5");
        ////        break;
        ////    default:
        ////        break;
        ////}

        //////diğer bir örnek

        ////string ad,soyad;

        ////Console.WriteLine("Lütfen adınızı giriniz");

        ////ad = Console.ReadLine();

        ////switch (ad)
        ////{
        ////    case "Nesibe":

        ////        Console.WriteLine("Lütfen soyadınızı giriniz");
        ////        soyad = Console.ReadLine();
        ////        Console.WriteLine("Girmiş olduğunuz bilgi : " + ad + " " + soyad);

        ////        break;

        ////    default:

        ////        Console.WriteLine("Yanlış format");

        ////        break;
        ////}

        ////// Eğer programınıza bir case'deyken farklı bir case'e gitmesini istiyorsak "goto" anahtar sözcüğünü kullanırız

        ////int j = 5;

        ////switch (j)
        ////{
        ////    case 4:
        ////        string k1= Console.ReadLine();
        ////        Console.Write(k1);
        ////        break;
        ////    case 5:
        ////        Console.Write("Şimdi case 4 e gideceksiniz");
        ////        goto case 4;
        ////    default:
        ////        Console.Write("deneme4");
        ////        break;
        ////}

        //#endregion

        //#region For

        ////int toplam = 0;

        ////for (int i = 0; i <= 10; i++)
        ////{
        ////    toplam = toplam + i;
        ////    // toplam += i;
        ////}

        ////Console.WriteLine(toplam);

        ////string deger = "Ümit Karaçivi";

        ////for (int i = deger.Length-1; i>=0; i--)
        ////{
        ////    Console.WriteLine(deger[i]); // karakter katarını dizi gibi algılama ve tek tek elemanlarına erişme
        ////}


        ////girdiğiniz herhangi bir sayının faktöriyel hesabı 

        ////float s;
        ////int si, f1; // f1 değişkeni faktöriyel
        ////bool a1 = false; // girilen değerin pozitiflik/negatiflik durumunu belirlemek için

        ////for ( ; a1 ; )  // esas döngü olayı bloğun içinde, ben sadece başlamasını sağlıyorum
        ////{
        ////    Console.WriteLine("Lütfen faktöriyelini almak istediğiniz sayıyı giriniz..");

        ////    s = Convert.ToSingle(Console.ReadLine());
        ////    si = (int) s; // zorluyorum. tip değişimi için..

        ////    if (si != s || s<1)
        ////    {
        ////        Console.WriteLine("Lütfen pozitif bir tamsayı giriniz...");
        ////        a1 = false;

        ////    }
        ////    else // eğer pozitif girmişse problem yok..
        ////    {
        ////        a1 = true;

        ////        for (f1 = 1; si > 1; si--)
        ////        {
        ////            f1 *= si;

        ////        }

        ////        Console.WriteLine("Faktöriyel = {0}" , f1);

        ////    }
        ////}

        //// 1'den 1000'e (sınırlar dahil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program yazınız.

        ////int toplam = 0, adet = 0, sayac;

        ////for (sayac = 0; sayac <= 1000; sayac+=5)
        ////{
        ////    if (sayac % 5 == 0 && sayac % 7 != 0)
        ////    {
        ////        adet++; // koşula uyan bir sayı buldum
        ////        toplam += sayac; // toplam = toplam + sayac
        ////    }

        ////}

        ////Console.WriteLine("Sayıların adedi : {0} adettir... " + adet);
        ////Console.WriteLine("Sayıların toplamı : {0} dir... " + toplam);


        //// konsol ekranına girilen 0 ile 100 (sınırlar dahil) arasındaki 3 notun en büyüğünü, en küçüğünü ve ortalamasını yazan programı yazınız

        //int enBuyukNot = 0; // en büyük notu belirtsin
        //int enKucukNot = 0; // en küçük notu belirtsin
        //int toplam = 0;
        //int not = 0;

        //Console.WriteLine("3 Notu giriniz..");

        //for (int sayac = 0; sayac < 3; sayac++)
        //{
        //    Console.WriteLine(sayac + ". notu giriniz : ");
        //    not = Convert.ToInt32(Console.ReadLine());

        //    if (not > 100 || not < 0)
        //    {
        //        Console.WriteLine("Lütfen pozitif bir not giriniz..");
        //        sayac--;

        //        continue; // devam demek
        //    }

        //    if (sayac == 0)
        //    {
        //        enBuyukNot = not;
        //        enKucukNot = not;
        //    }
        //    else 
        //    {
        //        if (not > enBuyukNot)
        //        {
        //            enBuyukNot = not;
        //        }

        //        if (not < enKucukNot)
        //        {
        //            enKucukNot = not;
        //        }
        //    }

        //    toplam += not;

        //}

        //Console.WriteLine("En büyük : {0}\n En küçük : {1}\n Ortalama : " +
        //    "{2}",enBuyukNot,enKucukNot,toplam/3);


        //#endregion

        #region While

        // while (koşul)        Çalışma Prensibi
        //      komut;         1.Koşula bakılır
        // veya
        //while (koşul)
        //{
        //      komut1;
        //      komut2;

        //0-100 arasındaki sayıların toplamı

        int toplam = 0;
        int i = 0; // ilk değer

        while (i < 100)  // i < 100 olduğu sürece aşağıdaki bloğu çalıştır
        {
            toplam += i; // toplama işlemini gerçekleştir
            i++;
        }
        Console.WriteLine(toplam);


        //aşağıdaki işlemde int sayi isimli bir değişken oluşturulup
        // içine Console.ReadLine() metodundan gelen string değer dönüştürülerek atılmıştır.
        // Çünkü while döngüsünde büyüktür (>) operatörünü kullanmak için bir sayıya ihtiyacımız vardır
        // ve int değişkenler büyüktür operatörünü kullanabileceğimiz sayıyı tutmaktadır.

        // Ekrana girilen sayının basamaklarını bulan program parçası
        Console.WriteLine("Sayınızı giriniz : ");

        int sayi = Convert.ToInt32(Console.ReadLine());

        int basamak = 0;

        while (sayi>0)
        {
            basamak++;

            sayi = sayi / 10;
        }

        Console.WriteLine("Girdiğiniz sayı : " + basamak.ToString() + "basamaklıdır.");

        #endregion

        #region Do - While

        int toplam1 = 0;
        int sayac = 0;

        do
        {
            sayac++;
            toplam1 += sayac;
        }
        while (sayac < 100);

        Console.WriteLine("Toplam" + toplam1.ToString() + ",Sayac : " + sayac.ToString());


        #endregion



        Console.ReadKey();
    }
}