

namespace ExerciseSjukhus
{
    //Här skapar jag en subklass som heter Doctor som ärver från klassen User. Jag kommer ändra texten med override void.
    //Utöver den ärvda metoden kommer denna klass få ytterligare 3 metoder.
    public class Doctor : User
    {


        public void Behandla() 
        {
            Console.WriteLine("Läkaren behandlar patient");
        }

        public void SkrivaUtMedicin() 
        {
            Console.WriteLine("Bara Läkare som kan skriva ut medicin");
        }

        public void ÄndraJournal() 
        {
            Console.WriteLine("Läkaren kan gå in och ändra i journalen");
        }

        public override void ShowLoginInfo()
        {
            Console.WriteLine("Läkare loggar in");
        }
    }
}
