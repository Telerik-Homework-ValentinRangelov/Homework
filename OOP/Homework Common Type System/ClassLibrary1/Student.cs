
namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    public class Student : ICloneable, IComparable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public int Course { get; set; }
        public Speciality SpecialityName { get; set; }
        public University UniversityName { get; set; }
        public Faculty FacultyName { get; set; }

        public enum University
        {
            SofiaUniversity,
            TechnicalUniversity,
            UNWE,
            NBU
        }
        public enum Speciality
        {
            IT,
            Mathematician,
            Physicist,
            Economician
        }
        public enum Faculty
        {
            Mathematics,
            Economy,
            Physics
        }
        public Student()
        {

        }
        public Student(string firstName, string middleName, string lastName, ulong SSN, string address, string phone, string email)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.Address = address;
            this.MobilePhone = phone;
            this.EMail = email;
        }
        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.MobilePhone.Equals((obj as Student).MobilePhone)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.EMail.Equals((obj as Student).EMail)) return false;
            if (!this.FacultyName.Equals((obj as Student).FacultyName)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.UniversityName.Equals((obj as Student).UniversityName)) return false;
            if (!this.SpecialityName.Equals((obj as Student).SpecialityName)) return false;

            return true;
        }
        public override string ToString()
        {
            return this.FirstName +" "+this.LastName+" "+this.SSN;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Student stud1, Student stud2)
        {
            return stud1.Equals(stud2);
        }
        public static bool operator !=(Student stud1, Student stud2)
        {
            return !(stud1.Equals(stud2));
        }

        public object Clone()
        {
            Student newStud = new Student();
            newStud.Address = this.Address;
            newStud.Course = this.Course;
            newStud.EMail = this.EMail;
            newStud.FacultyName = this.FacultyName;
            newStud.FirstName = this.FirstName;
            newStud.MiddleName = this.MiddleName;
            newStud.LastName = this.LastName;
            newStud.MobilePhone = this.MobilePhone;
            newStud.SpecialityName = this.SpecialityName;
            newStud.UniversityName = this.UniversityName;
            newStud.SSN = this.SSN;
            return newStud;
        }


        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }
            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }
    }


}
