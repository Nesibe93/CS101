using _15_Abstraction;

internal class Program
{
    // basit bir örnek üzerinde isleyecek olursak; bir işletmemiz ve bu işletmeye bağlı çalışanlarımızın
    // bilgilerinin yer alacağı, çeşitli işlemlere imkan verecek bir sınıfımız ve bu sınıfa özelliklerin atanması sağlayacağımız bir abstract class oluşturarak gerekli bilgilerin çıktısını kullanıcıya iletmek isteyelim

    //        Bu örnek için uygulanacak aşamalar
    // 1.Çalışan bilgilerinin tutulacağı base konumunda bir abstract class oluşturmak gerektiğinden dolayı
    //  clsEmployeeBaseManager isminde bir abstract sinıf oluşturalım

    // 2. Çalışanların bilgilerinin saklanacağı çeşitli değişkenler ve bu bilgilere göre çeşitli işlemler yapılmasının sağlanacağı bazı metod tanımlamaları gerçekleştirelim

    //3. Her çalışam kişilerin zam oranı , yıllık izni gibi kavramlar çalışanın statüsüne , deneyimine bağlı değişeceği için abstract metod olarak bazı metodların da tanımlanması gerekmektedir

    // tanımlamalar gerçekleştirdikten sonra clsEmployeeBaseManager sınıfının içeriğini inceleyelim :

    private static void Main(string[] args)
    {
        // Öncelikle bir Beden işçisi oluşturalım

        clsCreateEmployeeManager bodyworker = new clsCreateEmployeeManager(); // nesneyi yarattım

        bodyworker.employeeBaseManager = new clsEmployeeManager();

        bodyworker.Create();

        bodyworker.getInfo();

        // bir mühendis için

        clsCreateEmployeeManager engineer = new clsCreateEmployeeManager();
        
        engineer.employeeBaseManager = new clsEngineerManager(); // Mühendisler için  

        engineer.Create();

        engineer.getInfo();





    }
}