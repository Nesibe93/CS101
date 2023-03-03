using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism
{
    internal class clsTutorials
    {
        protected int tutorialID;
        protected string tutorialName;
        protected string tutorialDescription;

        public void setTutorial(int pID,string pTutorialName)
        {
            tutorialID= pID;
            tutorialName= pTutorialName;
        }

        public void setTutorial(string pTutorialName)
        {
            tutorialName = pTutorialName;
        }

        public void setTutorial(int pID, string pTutorialName,string pDesc)
        {
            tutorialID = pID;
            tutorialName = pTutorialName;
            tutorialDescription = pDesc;
        }

        public string getTutorialName()
        {
            return this.tutorialName + " " + tutorialID + "" + tutorialDescription;
        }

    }
}
