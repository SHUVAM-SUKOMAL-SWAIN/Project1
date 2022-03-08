using System;

namespace Project1_School
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student obj = new Student();
   
            obj.Store();
            obj.Show();
            Console.WriteLine("The end");
        }
    }
}
