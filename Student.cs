using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentsХml
{

    [XmlInclude(typeof(UndergraduateStudent)), XmlInclude(typeof(PostcgraduateStudent))]
    [Serializable]
    public abstract class Student
    {
        public string firstName = "";
        public string secondName = "";
        public string faculty = "";

        public Student() { }
    }
}
