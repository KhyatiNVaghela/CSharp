public class Tutorial
{

    int TutorialID;
    string TutorialName;



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



    public static void Main(string[] args)
    {
        Tutorial pTutor = new Tutorial();

        Console.WriteLine(pTutor.GetTutorial());

        pTutor.SetTutorial(1, ".Net");

        Console.WriteLine(pTutor.GetTutorial());

        Console.ReadKey();
    }

}
/*

1. The first step is to create an object for the Tutorial class. Mark here that this is done by using the keyword ‘new’. The ‘new’ keyword is used to create an object from a class in C#. The object is then assigned to the pTutor variable.
2. The method SetTutorial is then called. The parameters of 1 and “.Net” are passed to the SetTutorial method. These will then be used to set the “TutorialID” and “TutorialName” fields of the class accordingly.
3. We then use the GetTutorial method of the Tutorial class to get the TutorialName. This is then displayed to the console via the Console.WriteLine method.
*/