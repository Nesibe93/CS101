using _09_Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Personel Örmeği 1
        // Personel Bilgileri 1
        // Personel kayıt sistemi clsPErsonel isimli sınıf. içinde bazı özellikler personelin tutulacağı bilgiler.
        // Adı, personel no,tck no,bölümü,maaşı
        // metod tanımlıcaz setPersonelData personel kaydı yapacak ve içerisindeki değerleri güncellicez
        //personel bilgilerini alıcam bunları ekrana göstermek için getPersonelData isimli metod tanımlayarak personelin bilgilerini ekranda göstericez
        //sınıf tanımlaması bittikten sonra işlemler başlayacak

        Console.WriteLine("Unitum Cerebris Communitas Personel Listesi");
        Console.WriteLine("-------------------------------------------");

        // Şimdi nesnemizi yaratalım
        // Manuel olarak dolduralım

        clsPersonel1 per1 = new clsPersonel1();
        
        per1.personelID = 1;
        per1.personelAd = "Nesibe";
        per1.personelSoyad = "Kosanoğlu";
        per1.personelBolum = "IT";
        per1.personelMaas = 1;
        per1.personelTCKNo= "12345678901";

        per1.setPersonelData(1,"Nesibe","Kosanoğlu","IT","12345678901",1);
        per1.getPersonelData();

        clsPersonel1 per2 = new clsPersonel1(); // Başka bir nesne oluşturuyoruz

        per2.personelID = 2;
        per2.personelAd = "Selim";
        per2.personelSoyad = "Kosanoğlu";
        per2.personelBolum = "Child";
        per2.personelMaas = 1000;
        per2.personelTCKNo = "99999999999";

        per2.setPersonelData(2, "Selim", "Kosanoğlu", "Child","99999999999",1000);
        per2.getPersonelData();

        clsPersonel1 per3 = new clsPersonel1(); // Başka bir nesne oluşturuyoruz

        per3.personelID = 3;
        per3.personelAd = "Nazire";
        per3.personelSoyad = "Yaylacı";
        per3.personelBolum = "Mom";
        per3.personelMaas = 1000;
        per3.personelTCKNo = "11111111111";

        per3.setPersonelData(3, "Nazire", "Yaylacı", "Mom", "11111111111", 1000);
        per3.getPersonelData();

        #endregion

        #region Öğrenci Örneği
        // bir class yaratılacak ismi clsOgrenci olsun
        // tutulacak bilgiler ogrNo,adSoyad,ders ve dersNotu
        // 2 tane metodumuz olacak
        // bir tanesi öğrencinin verilerini ekrana döksün
        // bir tanesi öğrencinin aldığı nota göre 50 kontrol değeri...geçti...kaldı desin


        clsOgrenci ogr1 = new clsOgrenci();

        ogr1.ogrenciNo = "1234";
        ogr1.ogrenciAdSoyad = "Nesibe Kosanoğlu";
        ogr1.ogrenciDers = "Matematik";
        ogr1.ogrenciDersNotu = 50;

        ogr1.setOgrenciData("1234", "Nesibe Kosanoğlu", "Matematik", 50);
        ogr1.getOgrenciData();

        ogr1.ogrenciControl(ogr1.ogrenciDersNotu);

        #endregion

        #region Personel Örneği 2

        // Bu örneğin amacı class yapısının bu source dosyasından farklı bir yerde tanımlanması ve kullanılması üzerine

        // bir şirket var.
        // 5 elemanı var...Ad soyad,ünvan,maaş ve izin günü
        // bir tane metodum olacak class içinde
        // bu metodda öncelikle adSoyad bilgisinin dolu olduğu durumda 
        // maaşının miktarına göre o personelin kaç gün izin hakkı olacağı belirlenecek
        //kriterler :
        // Eğer benim maaşım 2500 kina altındaysa düz personel ve izin günü 14 gün
        //maaş 10000 - 14000 arasındaysa kıdemli personel ve izin günü 20 gün olarak 
        // 14001 - 15500 arasındaysa kıdemli+ Personel (sınırlar dahil) ve izin günü 24 gün
        // 15500 üzerindeyse uzman personel ve izin günü sayısı 30 gün
        // olarak çıkış veren şekilde olacak

        // Not : personelin maaş bilgisinin belirlenmesi bilgisayara bırakılacak..Random...aralık 1000-20000 aralığı

        // Not: Eğer ad ve soyad bilgileri 

        clsPersonel2 pers1 = new clsPersonel2();

        pers1.personelID = 1;
        pers1.personelAd = "Nesibe";
        pers1.personelSoyad = "Kosanoğlu";
        pers1.personelUnvan = "Developer";
        pers1.personelMaas = 10000;
        pers1.personelIzinGunu = 0; // ?

        #endregion

        Console.ReadKey();

    }

    #region class and methods

 
    class clsPersonel1
    {
        // Şimdi sıra geldi sınıfımın özelliklerini (properties) tanımlama

        // Properties
        public int personelID;
        public string personelAd;
        public string personelSoyad;
        public string personelTCKNo;
        public string personelBolum;
        public int personelMaas;


        public void setPersonelData(int pID,string pAd,string pSoyad,string pTCKNo,string pBolum,int pMaas)
        {
            // Bu metod class/object bilgilerini set etmek için kullanılacak
            personelID = pID;
            personelAd = pAd;
            personelSoyad = pSoyad;
            personelTCKNo= pTCKNo;
            personelBolum= pBolum;
            personelMaas= pMaas;

        }

        public void getPersonelData()
        {
            // Bu metod class/object bilgilerini get etmek için kullanılacak
            Console.WriteLine($"\n\n Personel No : {personelID}\n Adı ve Soyadı : {personelAd} {personelSoyad}\n TCKNo : {personelTCKNo}\n Bölüm : {personelBolum}\n Maaş : {personelMaas} PNG Kina");

        }

    }

    class clsOgrenci
    {
        
        public string ogrenciNo;
        public string ogrenciAdSoyad;
        public string ogrenciDers;
        public int ogrenciDersNotu;


        public void setOgrenciData(string oNo,string oAdSoyad,string oDers,int oDersNotu)
        {
            ogrenciNo = oNo;
            ogrenciAdSoyad = oAdSoyad;
            ogrenciDers = oDers;
            ogrenciDersNotu= oDersNotu;
        }

        public void getOgrenciData()
        {
            // Bu metod class/object bilgilerini get etmek için kullanılacak
            Console.WriteLine($"\n\n Öğrenci No : {ogrenciNo}\n Öğrenci Adı ve Soyadı : {ogrenciAdSoyad}\n Öğrenci Ders : {ogrenciDers}\n Öğrenci Ders Notu : {ogrenciDersNotu}\n");
        }

        public void ogrenciControl(int oNot)
        {
            
            if (oNot > 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
        }

    }


    #endregion


}