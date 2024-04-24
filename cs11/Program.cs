using System.Threading.Tasks;

namespace cs11
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-6): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        new Task1_4().Task1();
                        break;
                    case 2:
                        new Task1_4().Task2();
                        break;
                    case 3:
                        new Task1_4().Task3();
                        break;
                    case 4:
                        new Task1_4().Task4();
                        break;
                    case 5:
                        new SearchByFile().Task5();
                        break;
                    case 6:
                        new SearchByFile().Task6();
                        break;
                }

                if (task == 0) break;
            }





            //string filePath = @"test.txt";

            //if (!File.Exists(filePath))
            //{
            //    Console.WriteLine("Error...");
            //    return;
            //}

            //string? content = "Test";
            //var content2 = "2222";

            //using (StreamWriter writer = new StreamWriter(filePath, false))
            //{
            //    writer.WriteLine(content);
            //    writer.WriteLine(content2);
            //}
            //if (File.Exists(filePath))
            //{
            //    using (StreamReader reader = new StreamReader(filePath))
            //    {
            //        Console.WriteLine("File content:");
            //        string line;
            //        while ((line = reader.ReadLine()) != null)
            //        {                   
            //            Console.WriteLine(line);
            //        }

            //        //string line = reader.ReadToEnd();
            //        //Console.WriteLine("File content:");
            //        //Console.WriteLine(line);
            //    }
            //}

            //using (Test test = new Test())
            //{
            //    test.File = filePath;
            //    Console.WriteLine(test.File);
            //}
            //Console.WriteLine("------------------");
            //StreamWriter writer = new StreamWriter(filePath);
            //writer.Dispose();
        }
    }

    //class Test : IDisposable
    //{
    //    public string File { get; set; }
    //    public Test()
    //    {
    //        Console.WriteLine("Test");
    //    }
    //    public void Dispose()
    //    {
    //        Console.WriteLine("Dispose");
    //    }
    //}
}
