using System;
using System.Collections.Generic;

using Exam;

namespace ExamConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty("IKM", 18); //fak-y uni anun u ancoghik gnahatakan
            Faculty f2 = new Faculty("Soc", 10);
            Faculty f3 = new Faculty("Irav", 17);
            Faculty f4 = new Faculty("Tntes", 17.5);

            f1.AddSubject(Subject.Math); //fak-i ararkaneri listum avelacnum enq mer enum-i ararkaneric
            f1.AddSubject(Subject.Physics);

            Abiturent a1 = new Abiturent("Aram", "Sargsyan", f1); //dimel a f1
            Abiturent a2 = new Abiturent("Ani", "Khachatryan", f2);
            Abiturent a3 = new Abiturent("Aram1", "Sargsyan1", f1);
            Abiturent a4 = new Abiturent("Aram2", "Sargsyan2", f4);

            Examination.AddAbiturent(a1); //qnnutyuna a handznum
            Examination.AddAbiturent(a2);
            Examination.AddAbiturent(a3);
            Examination.AddAbiturent(a4);

            Lecturer l1 = new Lecturer("a1", Subject.Math); //dasarun uni anun u ararka
            Lecturer l2 = new Lecturer("a2", Subject.Physics);

            Examination.Exam(a1, l1, 18);   //stacav 18
            Examination.Exam(a1, l2, 19);   //stacav 19

            List<Abiturent> r =  Examination.PassedAbit();
            foreach (Abiturent a in r) {
                Console.WriteLine(a.Name + " " + a.Surname + " " + a.Mog);
            }

            Console.WriteLine(a4.Name);
        }
    }
}
