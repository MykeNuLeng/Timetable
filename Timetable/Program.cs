using System.Collections;
using Timetable.UserInput;

namespace Timetable
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentNumber = UserInput.NumberOfStudents();

            string[] studentArr = UserIput.StudentArray(studentNumber);

            Hashtable studentsAvailability = UserInput.StudentHash(studentArr);

        }
    }
}