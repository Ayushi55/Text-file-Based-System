using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RecordSystem
{
    public class WorkflowDetails
    {
         
        public static void main()
        {
            int count = 0;
            WorkflowDetails obj = new WorkflowDetails();
            int value =obj.ReadData(count);
            int v1 =obj.WriteData(value);
            value = obj.ReadData(count);

        }
        public  int  ReadData(int count)
        {
            var path = @"C:\Users\anoushka_mishra\OneDrive - Dell Technologies\Desktop\Simplilearn Assignment\Assignment 1\RecordSystem\TeacherInformation.txt";
            List<TeacherDetails> TeacherInfo = new List<TeacherDetails>();
            List<string> lines = File.ReadAllLines(path).ToList();
            foreach (var line in lines)

            {
                count=count+1;
                string[] entries = line.Split(',');
                TeacherDetails Teacher = new TeacherDetails();
                Teacher.ID = int.Parse(entries[0]);
                Teacher.Name = entries[1];
                Teacher.Class = entries[2];
                Teacher.Section = entries[3];

                Console.WriteLine($"{Teacher.ID} \t {Teacher.Name} \t {Teacher.Class} \t {Teacher.Section}");

            }
            return count;
        }
        public int WriteData(int count)
        {
            var path = @"C:\Users\anoushka_mishra\OneDrive - Dell Technologies\Desktop\Simplilearn Assignment\Assignment 1\RecordSystem\TeacherInformation.txt";
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Class");
            string Class = Console.ReadLine();
            Console.WriteLine("Enter your Section");
            string Section = Console.ReadLine();
            count = count + 1;
            string data = "\n"+count.ToString()+","+Name+","+Class+","+Section ;
            File.AppendAllText(path,data);
            return count;

        }
    }
}
