using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccesModifiers
{
    internal class clsTutorials
    {
        int tutorialID;
        string tutorialName;

        public void setTutorial(int pID,string pTutorialName)
        {
            this.tutorialID = pID; //  "this" anahtar sözcüğü, sınıf içerisinde bulunan bir nesnenin, o sınıfa ait bir üye (örneğin bir metot veya özellik) tarafından kullanıldığını belirtmek için kullanılır.
            this.tutorialName = pTutorialName;
        }

        public string getTutorialName()
        {
            return this.tutorialName;
        }

    }
}
