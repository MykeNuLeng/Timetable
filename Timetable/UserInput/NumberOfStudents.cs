using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Timetable.UserInput
{
    public class UserInput
    {

        public static int NumberOfStudents()
        {
            Console.WriteLine("How many students do you have?");
            string numberOfStudents = Console.ReadLine();
            bool isInt = int.TryParse(numberOfStudents, out int studentNumber);

            while (!isInt)
            {
                Console.WriteLine("Please enter a valid number of students");
                numberOfStudents = Console.ReadLine();
                isInt = int.TryParse(numberOfStudents, out studentNumber);
            }

            return studentNumber;
        }

        public static string[] StudentArray(int studentNumber)
        {

            string[] studentArr = new string[studentNumber];

            for (int i = 0; i < studentNumber; i++)
            {
                Console.WriteLine("Please enter the name of student number " + (i + 1));
                studentArr[i] = Console.ReadLine();
            }
            return studentArr;
        }


        public static Hashtable StudentHash(string[] studentArr)
        {
            int studentNumber = studentArr.Length;

            Hashtable studentsAvailability = new Hashtable(studentNumber);

            for (int i = 0; i < studentNumber; i++)
            { 
                Console.WriteLine("Please enter the availability of " + studentArr[i]);
                string availability = Console.ReadLine();

                string[] times = availability.Split(", ");
                studentsAvailability.Add(studentArr[i], times);
            }
        }
    }
}
