using System.Collections;

namespace Timetable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you have?");
            string numberOfStudents = Console.ReadLine();
            bool isInt = int.TryParse(numberOfStudents, out int studentNumber);

            if (isInt && studentNumber > 0)
            {
                Console.WriteLine(studentNumber);
            } else
            {
                Console.WriteLine("That isn't a valid number");
            }

            string[] studentArr = new string[studentNumber];

            for (int i = 0; i < studentArr.Length; i++)
            {
                Console.WriteLine("Please enter the name of student number " + (i + 1));
                studentArr[i] = Console.ReadLine();
            }

            Hashtable studentsAvailability = new Hashtable(studentNumber);

            for (int i = 0; i < studentArr.Length; i++)
            {
                bool isStillAvailable = true;

                while (isStillAvailable)
                {
                    Console.WriteLine("Please enter the availability of " + studentArr[i] + ". Or type N for no more availability");
                    string availability = Console.ReadLine();

                    if (availability == "N")
                    {
                        isStillAvailable = false;
                    } else
                    {
                        string[] times = availability.Split(",");
                        studentsAvailability.Add(studentArr[i], times);
                    }
                }  
            }

            foreach (string student in studentsAvailability.Keys)
            {
                Console.WriteLine(student); 
            }
        }
    }
}