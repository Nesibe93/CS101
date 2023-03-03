using _12_Polymorphism;

internal class Program : clsTutorials
{
    private static void Main(string[] args)
    {
        clsTutorials tutorials= new clsTutorials();

        tutorials.setTutorial(1,"C#"); // 1.formunu kullanıyorum..
        Console.WriteLine(tutorials.getTutorialName());

        tutorials.setTutorial(2,"SQL Server"); //2. formunu kullanıyorum
        Console.WriteLine(tutorials.getTutorialName());

        tutorials.setTutorial(3,"HTML" ,"HTML/CSS eğitimi"); //3. formunu kullanıyorum
        Console.WriteLine(tutorials.getTutorialName());

        Console.ReadKey();

    }

}