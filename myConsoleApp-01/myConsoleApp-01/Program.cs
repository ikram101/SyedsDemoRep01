using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleApp_01
{


    /// <summary>
    /// Requires type parameter that implements interface IDisposable.
    /// </summary>
    class Ruby<T> where T : IDisposable
    {
    }

    /// <summary>
    /// Requires type parameter that is a struct.
    /// </summary>
    class Python<T> where T : struct
    {
        public string myPytonF1()
        {
            return "Helloword";
        }
    }

    /// <summary>
    /// Requires type parameter that is a reference type with a constructor.
    /// </summary>
    class Perl<V> where V : class, new()
    {

    }

    class Java
    {
    }

    class Test<T>
    {
        T typeValue;

        public Test(T t)
        {
            // The field has the same type as the parameter.
            this.typeValue = t;
        }

        public void Write()
        {
            Console.WriteLine(this.typeValue);
        }
    }

    class Program
    {
         

        static void Main(string[] args)
        {
            
            Console.WriteLine("enter");



            var myDate = default(DateTime);
            Console.WriteLine(myDate);

            Console.ReadLine();


        }

        static void asyncTest()
        {
            Console.WriteLine("Hello World!");

            Task<int> task = HandleFileAsync();

            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Console.WriteLine("Please wait patiently " +
                "while I do something important.");

            // Do something at the same time as the file is being read.
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            // Wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> HandleFileAsync()
        {
            string file = @"C:\HarrisComputer-Oct-22-2018.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;

            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // ... Process the file data somehow.
                count += v.Length;

                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 10000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }
    }

    internal class Student
    {
        public string StudentName { get; set; }
    }
}
