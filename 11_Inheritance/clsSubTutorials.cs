using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsSubTutorials : clsTutorials
    {
        // Alt sınıf olan clsSubTutorials da olmayan bir metodu -daha önceden yazılmış ama farklı bir sınıfta- durumlarında kullanabilmek için
        // Üst sınıf olan clsTutorialsdan miras aldırttım
        public void DersAdiBelirle(string pNewName)
        {
            tutorialName = pNewName;
        }

    }
}
