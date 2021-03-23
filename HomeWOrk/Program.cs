using System;
using System.Collections.Generic;

namespace HomeWork
{
    
    class Program
    {
        delegate int Rule(int num1,int num2);
        static void TransformArr(int[] arr, Rule rule, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rule.Invoke(arr[i],num);
            }
        }
        static int Add(int one,int two) { return one + two; }
        public static class MyCollection { 
            public delegate bool MyPredicate<T>(T elem);
            static public List<T> MyFindAll<T>(T[] arr, MyPredicate<T> predic)
            {
                List<T> elems = new List<T>();
                foreach (var item in arr)
                {
                    if (predic(item))
                    {
                        elems.Add(item);
                    }
                }
                return elems;
            }
            static public void MySort<T>(List<T> arr, Comparison<T> comp) {
                for (int i = 0; i < arr.Count - 1; i++)
                    for (int j = 0; j < arr.Count - i - 1; j++)
                        if (comp(arr[j], arr[j + 1])==1)
                        {
                            T temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
            } // по умові масив, знизу Sort для масиву, для прикладу робив List в Main
            static public void MySort<T>(T[] arr, Comparison<T> comp)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                    for (int j = 0; j < arr.Length - i - 1; j++)
                        if (comp(arr[j], arr[j + 1]) == 1)
                        { 
                            T temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
            } 

        }
        static void Main(string[] args)
        {
            Rule add= new Rule(Add);
            int [] arr = { 2,4,6,8,7,10,12,9,7,3};
            TransformArr(arr, add, 1);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            MyCollection.MyPredicate<int> mp = new MyCollection.MyPredicate<int>(elem => elem % 2 == 0);
            foreach (var item in MyCollection.MyFindAll(arr, mp))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("Task3");
            string[] lines = { "One", "two", "three", "dfdq", "fdsfsdfsdf", "e" };
            Console.WriteLine("Before: ");
            foreach (var item in lines)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            MyCollection.MySort<string>(lines, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine("After: ");
            foreach (var item in lines)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            List<Product> products = new List<Product> { new Product("Iphone X",500), new Product("Bread", 1), new Product("Brot", 3), new Product("SmartTV",1000)};
            Console.WriteLine("Before: ");
            foreach (var item in products)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            MyCollection.MySort<Product>(products, (x, y) => x.Price.CompareTo(y.Price));
            Console.WriteLine("After: ");
            foreach (var item in products)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
