using _10_AccesModifiers;

internal class Program : clsMovies  // Kalıtım (Inheritance) bir sınıftan baika bir sınıfa kalıtım almak demek orda yapılanları kendi üzerine almak demek
{
    private static void Main(string[] args)
    {
        #region public

        clsTutorials tutorials = new clsTutorials(); // classtan örnekleme yaptım.yani nesne oluşturduk

        tutorials.setTutorial(1, "C# eğitimi");

        Console.WriteLine("Eğitim adı : {0}",tutorials.getTutorialName());

        #endregion

        #region private

        clsStudent student = new clsStudent();

        //Console.WriteLine($"Öğrencinin Adı : {student.getName}");  //bu kodla hata verdi (System.Action hatası)
        student.getName();

        #endregion

        #region protected

        clsMovies movies= new clsMovies();

        Program program= new Program();

        Console.WriteLine($"Movie name : {program.movieName} ");


        #endregion

        Console.ReadKey();
    }
}