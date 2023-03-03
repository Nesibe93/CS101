using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // Bir sınıfın içinde bulunan o sınıfındeğişkenlerini başlatmaktan sorumlu özel bir yöntemdir. Yapıcı yöntemin adı
        // içinde bulunduğu sınıfla tamamen aynı addır.Adı değiştiremezsiniz.Sınıf adınız "clsEmployee" , yapıcı yöntemin adı da "clsEmployee" olacaktır.Yapıcı yöntem herhangi bir değer döndürmez. Bu değer döndürmeyen bir metod olduğu anlamına gelir.
        // Genel olarak , metodlar iki türdendir , yani değer döndüren ve değer döndürmeyen ve yapıcılar tamamen değer döndürmeyen yöntemlerdir.

        // Bir sınıfta kaç tane constructor olabilir?
        // C# ta bir sınıf içinde istediğimiz sayıda kurucu 
        #region standart yapı

        clsTest test = new clsTest();

        Console.WriteLine($"i değeri {test.i} - s değeri {test.s} - b değeri {test.b}");

        #endregion

        // Constructor Tipleri

        // Default or Parameterless Constructer -- standart/ parametresiz
        // Parameterized Constructor -- Parametreli
        // Copy Constructor -- copy constructor 
        // Static Constructor -- Static >
        // Private Constructor -- private >

        #region Default / Parametresiz

        //Bu kurucular, bir programca tarafından açakça tanamtanabitir veya sınıf altında
        //açik(explicitly) bir kurucu olmaması nedeniyle 
        // örtük(implicit) olarak tanimlanacaktir.
        // Boylece, Varsayılan veya Parametresiz Olusturucular yine iki tipte sinıflandırılırlar.
        // 1.System-Defined Default Constructor
        // 2.User - Defined Default Constructor
        // Eger programımızda açıkça herhangi bir kurucu tanımlamazsak,
        // varsıyılan olarak derleyici derleme sirasında// bir kurucu saglayacaktır.
        // Bu yapıcıya "varsayılan (default) kurucu" denir ve varsayılan kurucu parametresizdir.
        // Varsayılan kurucu-yapıcı, veri yerine (statik olmayan degiskenler) varsayilan degerler atayacaktır.
        // Bu olusturucu sistem tarafından olusturuldugundan buna sistem tanıml1 varsayilan olusturucu da denir.

        clsEmployee emp1 = new clsEmployee();

        emp1.DisPlayEmployee();

        clsEmployee emp2 = new clsEmployee();

        emp2.DisPlayEmployee();

        #endregion

        #region Parametreli contructorlar
        // Nesneyi kullanıcı tarafından verilen değerlerle dinamik olarak başlatmak istiyorsak veya bir sınıfın her bir örneğini 
        // farklı bir değerler kümesiyle başlatmak istiyorsak, C#'ta Parameterized Constructor'ı kullanmamız gerekir.
        // Bu oluşturucular yalnızca programcılar tarafından tanımlanır. Yani, basit bir ifadeyle, geliştirici tarafından verilen
        // parametrelere sahip kurucu C#'ta Parametreli Yapıcı olarak tanımlanır.
        //        
        // Yararı Nedir?
        //
        // Parametreli bir kurucunun yardımıyla, sınıfın her bir örneğini farklı bir değerler kümesiyle başlatabiliriz.
        // Bu, parametreli yapıcı kullanarak, sınıfta oluşturulan farklı örneklerde farklı bir değer kümesi depolayabileceğimiz
        // anlamına gelir. Yani her nesneyi farklı değerlerle başlatabilme imkanı vermesidir.



        clsParametized prm1 = new clsParametized(10);

        prm1.Display();

        clsParametized prm2= new clsParametized(20);

        prm2.Display();

        clsParametized prm3 = new clsParametized(30);

        prm3.Display();

        #endregion

        #region Copy constructor

        // aynı değerlere sahip birden fazla örnek/nesne oluşturulması istendiği zaman

        #endregion

    }
}