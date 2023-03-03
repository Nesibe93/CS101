using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsTutorials
    {
        protected int tutorialID;
        protected string tutorialName;

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
