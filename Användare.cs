

namespace ExerciseSjukhus
{
    //Här ska jag skapa en abstrakt klass som heter User. Den ska innehålla 4 attributer och en metod. 
    //Den ska även ärvas av 3 subklasser, metoden ska vara virtual så att den går att skriva över på samtliga 3 subklasserna.
    public abstract class User
    {
        public int Id;
        public string Name;
        public string Adress;
        public int PhoneNo;


        public virtual void ShowLoginInfo()
            {
                Console.WriteLine($"loggar in");
            }



    }

   
}
