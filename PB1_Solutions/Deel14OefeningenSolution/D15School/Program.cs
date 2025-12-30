namespace D15School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            Klas klas1 = new Klas("Klas 1");

            Student student1 = new Student("Klas1Naam1");
            Student student2 = new Student("Klas1Naam2");

            klas1.VoegStudentToe(student1);
            klas1.VoegStudentToe(student2);

            school.VoegKlasToe(klas1);

            Klas klas2 = new Klas("Klas 2");

            Student student3 = new Student("Klas2Naam1");
            Student student4 = new Student("Klas2Naam2");
            try
            {
                Student student5 = new Student("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            klas2.VoegStudentToe(student3);
            klas2.VoegStudentToe(student4);

            school.VoegKlasToe(klas2);

            school.DrukNamenAf();
        }
    }
}
