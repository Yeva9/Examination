using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public enum Subject
    {
        Math,
        English,
        Physics,
        History
    }
    public class Faculty
    {
        public string Name { get; private set; }
        public double PassMark { get; private set; }        //ancoghik bal
        public List<Subject> Subjects { get; private set; } //ararkaneri cank
        public Faculty(string name, double passmark)
        {
            Name = name;
            PassMark = passmark;
            Subjects = new List<Subject>();
        }

        public void ChangePassMark(double mark)
        {
            if (mark <= 20 && mark >= 0) 
            {
                PassMark = mark;
            }
        }
        public void AddSubject(Subject subject)
        {
            if (!Subjects.Contains(subject))
            {
                Subjects.Add(subject);
            }
        }

        public static bool operator ==(Faculty obj1, Faculty obj2) //User-defined operator  must be declared static
        {
            if (obj1.Name != obj2.Name ||
                obj1.PassMark != obj2.PassMark ||
                obj1.Subjects.Count != obj2.Subjects.Count )
            {
                return false;
            }
            for (int i = 0; i < obj1.Subjects.Count; ++i)
            {
                if (obj1.Subjects[i] != obj2.Subjects[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static  bool operator !=(Faculty obj1, Faculty obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
