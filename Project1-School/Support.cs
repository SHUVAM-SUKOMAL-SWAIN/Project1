using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_School
{
    public class Support
    {
        public static int Ask()
        {
            Console.WriteLine("Enter the total number of students: ");
            int num = Convert.ToInt32(Console.ReadLine());
           
            return num;
        }
    }
}
