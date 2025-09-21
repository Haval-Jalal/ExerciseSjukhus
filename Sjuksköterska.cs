namespace ExerciseSjukhus
{
    //Här skapar jag en subklass som heter Nurse som ärver från klassen User. Jag kommer ändra texten med override void.
    //Utöver den ärvda metoden kommer denna klass få ytterligare 4 metoder.
    public class Nurse : User
    {

        public override void ShowLoginInfo()
        {
            Console.WriteLine("Sjuksköterska loggar in");
        }

        public void RegistreraPatient() 
        {
            Console.WriteLine("Sjuksköterska registrerar Patienten");
        }

        public void BokaTid() 
        {
            Console.WriteLine("Sjuksöterka kan boka tid åt patient");
        }

        public void AvbokaTid()
        {
            Console.WriteLine("Sjuksköterska kan avboka tid åt patient");
        }

        public void ÄndraJournal() 
        {
            Console.WriteLine("Sjuksköterska kan också ändra i journalen");
        }
    }
}
