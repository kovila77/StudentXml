using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsХml
{
    [Serializable]
    public class Student
    {
        public string firstName;
        public string lastName;
        public string faculty;

        public Student() { }
    }

    [Serializable]
    public class UndergraduateStudent : Student
    {
        public UndergraduateStudent() : base() { }
    }

    [Serializable]
    public class PostcgraduateStudent : Student
    {
        public string diploma;

        public PostcgraduateStudent() : base() { }
    }
}
