
using System;

namespace cs11
{
    internal class Task1_4
    {
        public void Task1()
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error...");
                return;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("File content:");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void Task2() 
        {
            int[] array = new int[10]; 
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter the number #{i+1}: ");
                int.TryParse(Console.ReadLine(), out int num);
                array[i] = num;
            }
            string filePath = @"task2.txt";
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    writer.WriteLine(array[i]);
                }                
            }
        }

        public void Task3()
        {
            int[] array = new int[10];
            string filePath = @"task2.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("File content:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }

        public void Task4()
        {
            Random rnd = new Random();
            int[] array = new int[10000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1000, 10000);
            }

            int Pair = 0, Unpair = 0;
            string filePath1 = @"PairNumbers.txt";
            StreamWriter writer1 = new StreamWriter(filePath1);

            string filePath2 = @"UnPairNumbers.txt";
            StreamWriter writer2 = new StreamWriter(filePath2);

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    writer1.WriteLine(array[i]); 
                    Pair++;
                }
                else 
                {
                    writer2.WriteLine(array[i]);
                    Unpair++;
                }
            }
            Console.WriteLine($"Pair {Pair}   -   Unpair {Unpair}");
            writer1.Dispose();
            writer2.Dispose();
        }
    }
}
