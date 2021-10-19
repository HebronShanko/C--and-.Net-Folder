using System;


namespace DailyStudentReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are on : " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNumbers = Convert.ToInt32(pageNumber);
            Console.WriteLine("You're on page: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer with True or False");
            bool needHelp = true;
            string helpStatus = Convert.ToString(needHelp);
            Console.ReadLine();

            Console.WriteLine("Was there any positive experiences you'd like to share? Please give specific");
            string yourExperience = Console.ReadLine();
            Console.WriteLine(yourExperience);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHour = Console.ReadLine();
            int studyHours = Convert.ToInt32(studyHour);
            Console.WriteLine("you studied: " + studyHours);
            Console.ReadLine();


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortyly. Have a great day!");
            Console.ReadLine();



        }
    }
}
