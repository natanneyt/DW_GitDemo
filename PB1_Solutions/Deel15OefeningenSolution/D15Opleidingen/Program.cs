using D15Opleidingen.Domein;

namespace D15Opleidingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentenInfo = File.ReadAllLines(@".\D15Opleidingen\Data\studenten.csv");
            List<Student> studenten = new List<Student>();

            foreach(string info in studentenInfo)
            {
                string[] parameters = info.Split(';');

                try
                {
                    studenten.Add(new Student(parameters[0], int.Parse(parameters[1]), new Opleiding(parameters[2], int.Parse(parameters[3]))));
                }
                catch
                {
                    Console.WriteLine("Er is iets misgegaan.");
                }
            }

            foreach(Student student in studenten)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
