using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    interface ITutorialInterface
    {
        void SetTutorial(int pID, string pName);
        String GetTutorial();
    }

    class Tutorial : ITutorialInterface
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public String GetTutorial()
        {
            return TutorialName;
        }

        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial();

            pTutor.SetTutorial(1, ".Net by Tutorial");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }
    }
}