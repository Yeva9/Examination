using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class Lecturer
    {
        public string Surname { get; private set; }
        public Subject Subject { get; private set; }

        public Lecturer(string surname, Subject subject)
        {
            Surname = surname;
            Subject = subject;
        }
            

    }

}
