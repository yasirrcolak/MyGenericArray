using System;

namespace GenericExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new array of class "GenericArray".
            var arr1 = new GenericArray<int>();

            arr1.PrintArray();

            arr1.Add(10);

            arr1.PrintArray();

            arr1.Add(20);
            arr1.Add(30);
            arr1.Add(40);
            arr1.Add(50);

            arr1.PrintArray();

            if (arr1.Remove(40))
                arr1.PrintArray();

            if (arr1.Contains(99))
                Console.WriteLine("bulundu.\n");
            else
                Console.WriteLine("bulunamadı.\n");


            Console.WriteLine(arr1.Count.ToString());

            arr1.Clear();

            arr1.PrintArray();

            Console.ReadKey();
        }
    }
}