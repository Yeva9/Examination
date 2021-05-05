using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public static class Examination //q.vor 1 hat enq sarqelu => static => miji f-nern el static
    {
        public static List<Abiturent> Abiturents = new List<Abiturent>();
        public static void AddAbiturent(Abiturent abiturent) //list enq avelacnum
        {
            if (Abiturents.Contains(abiturent)) { //q vor containsum =+y yst hasceneri e => menq chishty verasahmanenq            
                throw new AbiturentExistsException("abiturent already exists", abiturent);
            }
            Abiturents.Add(abiturent);
        }

        public static void Exam(Abiturent abit, Lecturer lect, double mark) { //qnnutyan ardyunqum stanum e gnahatakan
            //lect pokhancenq q.vor handznveliq ararkan lect-i mej enq pahe , mark-y stacats gnahatakann e
            if (!Abiturents.Contains(abit)) { //ete abit-y cankum chka => exception
                throw new AbiturentDoesNotExistException("Abiturent does not exists.", abit);
            }
            if (!abit.Faculty.Subjects.Contains(lect.Subject)) { // ete ararkan abit-i cankum chka => exception
                throw new SubjectDoesNotMatchException("Subject does not match.", lect);
            }

            for (int i = 0; i <= Abiturents.Count; ++i) { //hamap. abit-i gnahatakany pokhancenq
                if (Abiturents[i].Equals(abit)) { //abit-eri equals kverasahmanenq
                    Abiturents[i].ChangeMog(mark);
                    return;
                }
            }
        }

        public static List<Abiturent> PassedAbit() { //qnnutyuny ancatsneri cucaky
            List<Abiturent> Pased = new List<Abiturent>();
            for (int i = 0; i < Abiturents.Count ; ++i) {
                if (Abiturents[i].Mog >= Abiturents[i].Faculty.PassMark) {
                    Pased.Add(Abiturents[i]);
                }
            } 
            return Pased;
        }
    }
 }

