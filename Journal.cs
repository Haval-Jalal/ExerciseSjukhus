namespace ExerciseSjukhus
{
    public class MedicalRecord
    {
        public int PatientId;
        public int Datum;
        public string Diagnos;
        public string Medicin;


        public void RegistreraMedicin() 
        {
            Console.WriteLine("Journalen registerar medicin patienter får utskrivna");
        }

        public void RegistreraDiagnos() 
        {
            Console.WriteLine("Patientens diganos registreras här");
        }

        public void Arikvera() 
        {
            Console.WriteLine("Patientens journal och diagnos arkiveras här");
        }
    }
}
