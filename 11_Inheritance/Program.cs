using _11_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        clsSubTutorials altSinif= new clsSubTutorials();

       altSinif.DersAdiBelirle(".Net tutorials from Linkedin..."); // çağırdığım bu metod alt sınıfta

        Console.WriteLine(altSinif.getTutorialName()); // alt sınıftan üst sınıfın bir metodunu çağırabiliyorum (Kalıtım)
        // 12.satıra geldiğinde ekrana bir şeyler yazmak için getTutorialName metodunu çağırıyorum. Ama aslında bu metod üst sınıfta. alt sınıfın sanki bir metoduymuş gibi çağırabiliyorum(miras almasından dolayı)

        Console.ReadKey();
    }
}