internal class Program
{
    // Global değişkenler

    // Dizi datUser
    public static string[,] datUsers = new string[,] // 2 boyutlu bir dizi
    {
        {"K1","K2","K3" }, // Kullanıcılar
        {"P1","P2","P3" }, // Şifreleri
        {"A","K","K" }, // Kullanıcı Tipi (Admin / Kullanıcı)
        {"+","+","+" }, // Kullanıcının durumu (Aktif(+) / Pasif(-))

    };

    public static string userAuthority; // Admin / Kullanıcı ??
    public static string userStatus; // Aktif / Pasif ??

    public static string[] datLog = new string[100]; // Log dizisi (Tek boyutlu)

    public static int IndexLog = 0; // Log dizisinin indexi

    private static void Main(string[] args)
    {

        // Kullanıcı adı,şifresi,yetkisi,aktifliğini içeren bir dizi var
        // (User tablom gibi)
        // 4x3 boyutunda manuel(hard coded) yaratılacak
        // K1,K2,K3 -- kullanıcı adları
        // P1,P2,P3 -- kullanıcı şifreleri
        // A,K,K -- Yetki derecesi (Admin mi Kullanıcı mı)
        // + , + , + -- Kullanıcının aktifliği + : Aktif / - : Pasif
        //-------------------------------------------------------------------------
        // Bunun dışında sistem üzerindeki işlemleri izleyebileceğim (Adminin) bir log dizisi var (Tek boyutlu dizi)
        //1. Program ilk çalıştığında kullanıcıyı bir Ana Menü ekranı karşılayacak.(Methodsal yapı)
        //2. Seçenekler ... 1.Sisteme Giriş
        //                  2.Çıkış
        //3. 1.Seçeneğe basıldığında kullanıcının karşısına bir Log In ekranı gelmeli
        //4. Kullanıcıdan userName ve userPassword alınacak
        //5. Bir kontrol işlemiyle (datUser) kullanıcın var olup olmadığı kontrol edilecek yoksa bir kullanıcı yok mesajı verilecek ve tekrar Log In ekranına dönülecek.
        //6. Eğer varsa kullanıcının diğer bilgileri (yetki ve aktiflik) öğrenilecek...Buna göre yetki durumuna bağlı olarak farklı ekranlar kullanıcının karşısına gelecek..yani admin paneli, normal kullanıcı ise yapacağı işlemler listesi gibi
        //7. Yapılan işlemler datLog isimli bir diziye işlenecek...istenildiğinde admin kullanıcı tarafından listelenecek..bu seçenek adminin kendi panelinde bir seçenek olarak bulunacak...

        bool showMenu = true;

        while (showMenu) 
        {
            showMenu = MainMenu();
        }
        Console.WriteLine("Çıkış için bir tuşa basınız....");
        Console.ReadKey();

    }

    private static bool MainMenu()
    {
        bool showLogin = true;
       

        Console.Clear();
        Console.WriteLine( "------Ana Menü------");
        Console.WriteLine("1. Sistem Giriş");
        Console.WriteLine("2. Programdan Çıkış");
        Console.Write("\nSeçeneğiniz : ");

        switch (Console.ReadLine())
        {
            case "1":
                // Login ekranı bölümü....
                while (showLogin)
                {
                    showLogin = Login();
                }
                return true;
              
            case"2":
                // Programdan çıkış bölümü
                return false;

                case "3":
                
            default:
                return true;
                
        }

    }
    private static bool Login()
    {
        // Not : Her şifre karakteri girdiğinde şifre bölümünde "****" gibi gözüksün.

        string userID = "", userPassword="";

        Console.Clear();

        Console.WriteLine("------Login------");
        Console.WriteLine("Ana menüye dönüş için * 'ı tuşlayınız...\n\n");
        Console.WriteLine("Kullanıcı adını giriniz : ");
        userID = Console.ReadLine().Trim();

        if (userID == "*")
        {
            return false;
        }

        Console.WriteLine("Şifrenizi giriniz : ");
        userPassword = Console.ReadLine();
        userPassword = userPassword.Trim();

        if (userControl(datUsers,userID,userPassword))
        {
            // Eğer kullanıcı bulunduysa....
            Console.WriteLine("Tebrikler Giriş Başarılı\n\n");
            Console.WriteLine($"Kullanıcı yetki seviyesi {userAuthority}\n\n");
            Console.WriteLine($"Kullanıcı durumu {userStatus}\n\n");
            Console.WriteLine("Devam etmek için bir tuşa basınız...\n\n");

            datLog[IndexLog] = $"{userID} isimli kullanıcı sisteme giriş yapmıştır... ";  // $ bu işaret parametreyi içine koyarak yazmamızı sağlar
            IndexLog++;

            for (int i = 0; i < IndexLog; i++)
            {
                Console.WriteLine("Log kaydı : " + datLog[i] );
                
            }

        }
        else
        {
            Console.WriteLine("Maalesef kullanıcı bulunamadı...");
        }

        return true;
    }

    private static bool userControl(string[,] prmUsers, string prmUser, string prmPass)
    {
        bool found = false; // Kullanıcının bulunup bulunmadığını belirten bir değişken
        // iç içe for döngüleri yardımıyla tüm dizi öğelerini dolaşalım

        for (int satir = 0; satir < prmUsers.GetLength(0); satir++)
        {
            for (int sutun = 0; sutun < prmUsers.GetLength(1); sutun++)
            {
                if (prmUsers[satir,sutun] == prmUser) // Eşleşen kullanıcı mı 
                {
                    if (prmUsers[satir + 1,sutun] == prmPass) // Eşleşen şifre mi
                    {
                        userAuthority = prmUsers[satir + 2 ,sutun]; //  userAuthority ne olduğuna bak ?
                        userStatus = prmUsers[satir + 3,sutun]; // userStatus ne olduğuna bak ?

                        found= true; // Kullanıcıyı buldum
                        break; // Döngüden çık. sonlandır
                    }
                }
            }

            if (found) //
            {
                break;
            }
        }

        return found;
    }
    private static void PrintLog()
    {
        //
    }
}