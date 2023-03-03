using OOP_DWO1;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Human adlı bir sınıf oluşturarak adınızı, iş tanımınızı, doğum tarihinizi oluşturunuz...İster ekrandan alarak ister hard coded (human.ad = " "); olacak. Tarihsel işlemler için C# ın DateTime fonksiyonundan/ metodundan yararlanabilirsiniz.

        // 2. Fruit isimli bir class ımız daha olsun. Burada bir meyve tanımı(Elma) oluşturunuz..İSter ekrandan ister hard coded olacak şekilde.

        // human sınıfından oluşan nesneniz Elma yesin ve bunu bir mesajla belirtiniz.

        // Game isimli bir sınıfınız olsun.Human sınıfından oluşturulan bir nesneniz için bir...şu oyunu oynuyor...diye bir mesaj verebilirsiniz..

        // Human sınıfından birden fazla nesne üretebilirsiniz

        Human hmn = new Human();

        hmn.Name = "Nesibe";
        hmn.Is = "IT";
        hmn.dTarihi = (22 / 01 / 1993);  // bunun formatına bak

        Fruit meyve = new Fruit();




    }
}