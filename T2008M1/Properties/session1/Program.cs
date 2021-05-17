using System.Collections;
using System.Collections.Generic;

namespace T2008M1.Properties.session1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Huong Gino";
            Student.sName = "T2008M";
            ArrayList arrList = new ArrayList();
            arrList.Add("aa");
            arrList.Add(1);
            List<Student> students = new List<Student>();
            students.Add(s);
            List<int> ints = new List<int>();
            ints.Add(4);
            ints.Add(1);
        }
    }
}