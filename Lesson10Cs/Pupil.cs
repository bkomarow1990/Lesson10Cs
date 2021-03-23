using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Lesson10Cs
{
    class Pupil : IEnumerable
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();
        public List<int> Exams { get; set; } = new List<int>();
        public IEnumerable<int> GetAllExams()
        {
            foreach (int item in Exams)
            {
                yield return item;
            }
        }
        public IEnumerable<int> GetMarksHigher(int limit)// (out) marks >= limit  
        {
            foreach (int item in Marks)
            {
                if (item >= limit)
                {
                    yield return item;
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (int mark in Marks)
            {
                yield return mark;
            }
            foreach (int mark in Exams)
            {
                yield return mark;
            }
           // return ((IEnumerable)Marks).GetEnumerator();
        }
    }
}
