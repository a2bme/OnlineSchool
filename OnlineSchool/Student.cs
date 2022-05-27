using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    public class Student
    {
        public int id, mobile_number, grade;
        public string name, surname, email, password, gender, school;

        public Student(string name, string surname, string email, string password, int mobile_number, int grade, string gender, string school, int id = -1)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.mobile_number = mobile_number;
            this.grade = grade;
            this.gender = gender;
            this.school = school;
        }
    }   
}
