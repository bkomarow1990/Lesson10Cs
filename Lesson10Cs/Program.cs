using System;

namespace Lesson10Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil ann = new Pupil { Name = "Ann" };
            ann.Marks.Add(12);
            ann.Marks.Add(10);
            ann.Marks.Add(11);
            ann.Exams.Add(9);
            ann.Exams.Add(11);
            ann.Exams.Add(11);
            ann.Exams.Add(12);
            foreach (var item in ann)
            {
                Console.WriteLine($"{item, 5}");
            }
            Console.WriteLine("Get Marks >= 10");
            foreach (int item in ann.GetMarksHigher(10))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Task 2");
            Iterator it= new Iterator();
            foreach (var item in it.GetNumsToSumm(300))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" TEST ");
            foreach (var item in it.Converting(3))
            {
                Console.WriteLine(item);
            }
        }
    }
}
