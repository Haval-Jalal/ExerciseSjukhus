

namespace ExerciseSjukhus
{
    //Här skapar jag en subklass som heter Nurse som ärver från klassen User. Jag kommer ändra texten med override void.
    //Utöver den ärvda metoden kommer denna klass få ytterligare 3 metoder.
    public class Patient : User
    {
        public override void ShowLoginInfo()
        {
            Console.WriteLine("Patient loggar in");
        }

        public void SeJournal() 
        {
            Console.WriteLine("Patient kan gå in och läsa sin journal");
        }

        public void SeRecept()
        {
            Console.WriteLine("Patient kan gå in och se sina aktiva recept");
        }

        public void AvbokaTid()
        {
            Console.WriteLine("Patient kan avboka sina tider");
        }
    }
}
