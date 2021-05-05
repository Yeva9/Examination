using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class AbiturentExistsException : SystemException
  	{
        public Abiturent abiturent { get; private set; }
        public AbiturentExistsException(string mes, Abiturent abit)
            :base(mes) {
            abiturent = abit;
        }
    }

    public class AbiturentDoesNotExistException : SystemException
    {
        public Abiturent abiturent { get; private set; }
        public AbiturentDoesNotExistException(string mes, Abiturent abit)
            :base(mes) {
            abiturent = abit;
        }
    }

    public class SubjectDoesNotMatchException :SystemException
    { 
        public Subject subject { get; private set; }
        public Lecturer lecturer { get; private set; }
        public SubjectDoesNotMatchException(string mes, Lecturer l)
            :base(mes) {
            subject = l.Subject ;
        }
    }
}
