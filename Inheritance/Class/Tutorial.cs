using System.Security.Cryptography.X509Certificates;
namespace DemoApplication
{
    public class Tutorial
    {

        protected int TutorialID;
        protected string TutorialName;



        //Add Constructor
        public Tutorial()
        {
            TutorialID = 0;
            TutorialName = "Default";
        }


        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorial()
        {
            return TutorialName;
        }
    }
    public class TutorialChild : Tutorial
    {
        public void RenameTutorial(String pNewName)
        {
            TutorialName = pNewName;
        }

        public static void Main(string[] args)
        {
            TutorialChild pTutor = new TutorialChild();

            pTutor.RenameTutorial(".Net by TutorialChild");

            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }

    }
}
