using System.Security.Cryptography.X509Certificates;

namespace ExerciseSjukhus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jag ska nu skapa ett objekt av klassen Hospital.

            Hospital Mölndal = new Hospital();

            Mölndal.Name = "MölndalSjukhus";
            Mölndal.Adress = "Mölndalsvägen";
            Mölndal.PhoneNo = 00463112312;
            Mölndal.OpeningHours = 00-24;   


            //Jag har skapat en abstrakt klass som heter User och kommer ärvas av 3 subklasser men namnen Doctor, Nurse, Patient.
            //User klassen kommer även innehålla 4 attributer och en metod som är virtual och ska skrivas över av de ärvande klasserna.
            // De ärvande klasserna kommer i sin tur ha egna metoder utöver den de ärver från User klassen.

            Doctor Haval = new Doctor();
            Haval.Id = 1;
            Haval.Name = "Jalal";
            Haval.Adress = "Goteborg";
            Haval.PhoneNo = 123456789;

            Haval.ShowLoginInfo();
            Haval.Behandla();
            Haval.SkrivaUtMedicin();
            Haval.ÄndraJournal();



            Nurse nurse1 = new Nurse();
            nurse1.Id = 2;
            nurse1.Name = "Peter";
            nurse1.Adress = "Partille";
            nurse1.PhoneNo = 987654321;

            nurse1.ShowLoginInfo();
            nurse1.RegistreraPatient();
            nurse1.BokaTid();
            nurse1.AvbokaTid();
            nurse1.ÄndraJournal();
           

            Patient patient1 = new Patient();
            patient1.Id = 3;
            patient1.Name = "Kalle";
            patient1.Adress = "Hisingen";
            patient1.PhoneNo = 123987546;

            patient1.ShowLoginInfo();
            patient1.SeJournal();
            patient1.SeRecept();
            patient1.AvbokaTid();



            MedicalRecord Register = new MedicalRecord();

            Register.PatientId = 10;
            Register.Datum = 2025 - 09 - 16;
            Register.Diagnos = "Frisk";
            Register.Medicin = "Inga mediciner";


            Register.RegistreraMedicin();
            Register.RegistreraDiagnos();
            Register.Arikvera();


            Departments Departs = new Departments();
            Departs.Dep1 = "Kardiologi";
            Departs.Dep2 = "Neurologi";


            







        }
    }
}
