using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class DB_function
    {

        public void addStudent(string Name, string username, string password, string Cpassword, string email, string phnNo)
        {
            Student s = new Student();
            s.Id = 0;
            s.Name = Name;
            s.Username = username;
            s.Password = password;
            s.Email = email;
            s.PhoneNo = phnNo;

            ScoreifyContext storeStudent = new ScoreifyContext();
            storeStudent.Student.Add(s);
            storeStudent.SaveChanges();
        }
        
    }
}
