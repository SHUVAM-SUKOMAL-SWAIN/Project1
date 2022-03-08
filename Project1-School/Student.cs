using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_School
{
    public class Student : Support
    {
             
        static string[] Name = new string[Support.Ask()];
        int[] Marks = new int[3];
        string[] Subject = {"Physics","Chemistry","Math"};
        int[] TotalMarks = new int[Name.Length];


        public void Store()
        {
            for (int i = 0; i < Name.Length; i++)
            {
                Console.Write("Enter student name: ");
                Name[i] = Console.ReadLine();

                for (int j = 0; j < Subject.Length; j++)
                {
                    Point1:
                    Console.Write("Enter student mark in " + Subject[j]+": ");
                    int SubMark= Convert.ToInt32(Console.ReadLine());
                    if (SubMark <= 100 && SubMark >= 0)
                        Marks[j] = SubMark;
                    else
                    {
                        Console.WriteLine("MARK MUST BE BETWEEN 0 AND 100");
                        goto Point1;
                    }
                        
                }
                TotalMarks[i] = Marks[0] + Marks[1] + Marks[2];
                Console.WriteLine();
            }
        }

        public void Show()
        {

            //Array.Sort<int>(TotalMarks, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

           
            int[] Temp = new int[TotalMarks.Length];
            Array.Copy(TotalMarks, Temp, TotalMarks.Length);
            Array.Sort(Temp);
            Array.Reverse(Temp);
           
            int z = 1;

           for(int i=0;i<Temp.Length;i++)
            {
                for(int j=0;j<Temp.Length;j++)
                {
                    if(Temp[i]==TotalMarks[j])
                    {
                        Console.WriteLine("Rank" + z + "= " + Name[j] + " with total marks " + TotalMarks[j]);
                        z++;
                    }
                       
                }
            }
        }
    }
}
