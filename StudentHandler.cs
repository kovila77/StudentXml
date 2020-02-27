using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentsХml
{
    class StudentHandler
    {
        private List<Student> students = null;
        private Student curStudent = null;

        public Student GetCurStudent()
        {
            return curStudent;
        }

        public void CreateNewUnGrStudent()
        {
            curStudent = new UndergraduateStudent();
            students.Add(curStudent);
        }

        public void CreateNewPsGrStudent()
        {
            curStudent = new PostcgraduateStudent();
            students.Add(curStudent);
        }

        public void WriteToFileList(string v)
        {
            if (students == null) return;
            var xs = new XmlSerializer(typeof(List<Student>));
            using (var fs = new FileStream("data.xml", FileMode.Create))
            {
                xs.Serialize(fs, students);
            }
        }

        public void CreateNewList()
        {
            students = new List<Student>();
        }

        internal void ReadFileToList(string v)
        {
            var xs = new XmlSerializer(typeof(List<Student>));
            using (var fs = new FileStream("data.xml", FileMode.Open))
            {
                var a = (List<Student>)xs.Deserialize(fs);
                foreach (var b in a)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
