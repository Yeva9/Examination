using System;

namespace Exam
{
    public class Abiturent
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public double Mog { get; private set; }
        public Faculty Faculty { get; private set; }

        public  Abiturent(string name, string surname, Faculty faculty) {
            Name = name;
            Surname = surname;
            Faculty = faculty;
        }
        public void ChangeMog(double mark) { //qnnutyan ardyunqum stacats gnahatakannery estegh khashvenq
            Mog += mark / Faculty.Subjects.Count;
        }

        public override bool Equals(object obj) {
            if (obj == null || !(obj is Abiturent)) {
                return false;
			}
            Abiturent abit = obj as Abiturent;
            
			return (Name == abit.Name &&
                   Surname == abit.Surname &&
                   Mog == abit.Mog &&
                   Faculty == abit.Faculty); //facer- havasarutyuny kverasahmanenq
        }
    }
}
