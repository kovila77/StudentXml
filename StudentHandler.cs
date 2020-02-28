using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentsХml
{
    class StudentHandler
    {
        private List<Student> students = null;
        private int indexCurStudent = 0;
        public delegate bool ConditionFrilter(Student student);
        private ConditionFrilter IsNededStud = null;

        public bool haveStudens { get { return students != null && students.Count > 0; } }

        public StudentHandler()
        {
        }

        public void SetFilter(ConditionFrilter condition)
        {
            this.IsNededStud = condition;

            if (condition == null)
            {
                return;
            }

            indexCurStudent = 0;
            MoveNext();
        }

        public void CreateNewUnGrStudent()
        {
            if (students == null) CreateNewList();
            indexCurStudent = students.Count;
            students.Add(new UndergraduateStudent());
        }

        public void CreateNewPsGrStudent()
        {
            if (students == null) CreateNewList();
            indexCurStudent = students.Count;
            students.Add(new PostcgraduateStudent());
        }

        public void WriteToFileList(string file)
        {
            if (students == null) return;
            var xs = new XmlSerializer(typeof(List<Student>));
            using (var fs = new FileStream(file, FileMode.Create))
            {
                xs.Serialize(fs, students);
            }
        }

        public void CreateNewList()
        {
            students = new List<Student>();
            indexCurStudent = 0;
        }

        internal void ReadFileToList(string file)
        {
            var xs = new XmlSerializer(typeof(List<Student>));
            using (var fs = new FileStream(file, FileMode.Open))
            {
                students = (List<Student>)xs.Deserialize(fs);
            }
            indexCurStudent = 0;
        }

        public Student CurStudent()
        {
            if (students == null || students.Count == 0) return null;

            if (IsNededStud == null) return students[indexCurStudent];

            if (IsNededStud(students[indexCurStudent])) return students[indexCurStudent];

            return null;
        }

        internal void MoveNext()
        {
            if (students == null || students.Count == 0) return;

            if (IsNededStud == null)
            {
                if (indexCurStudent + 1 < students.Count) indexCurStudent++;
                return;
            }

            int old = indexCurStudent++;
            while (indexCurStudent < students.Count && !IsNededStud(students[indexCurStudent]))
            {
                indexCurStudent++;
            }
            if (!(indexCurStudent < students.Count))
            {
                indexCurStudent = old;
            }
        }

        internal void MoveBack()
        {
            if (students == null || students.Count == 0) return;

            if (IsNededStud == null)
            {
                if (indexCurStudent > 0) indexCurStudent--;
                return;
            }

            int old = indexCurStudent--;
            while (indexCurStudent >= 0 && !IsNededStud(students[indexCurStudent]))
            {
                indexCurStudent--;
            }
            if (indexCurStudent < 0)
            {
                indexCurStudent = old;
            }
        }

        internal Student Next()
        {
            int index = indexCurStudent;
            if (students == null || students.Count == 0) return null;

            if (IsNededStud == null)
            {
                if (index + 1 < students.Count)
                {
                    index++;
                    return students[index];
                }
                else return null;
            }

            index++;
            while (index < students.Count && !IsNededStud(students[index]))
            {
                index++;
            }
            if (!(index < students.Count))
            {
                return null;
            }
            return students[index];
        }
        internal Student Prev()
        {
            if (students == null || students.Count == 0) return null;
            int index = indexCurStudent;

            if (IsNededStud == null)
            {
                if (index > 0)
                {
                    index--;
                    return students[index];
                }
                else return null;
            }

            index--;
            while (index >= 0 && !IsNededStud(students[index]))
            {
                index--;
            }
            if (index < 0)
            {
                return null;
            }
            return students[index];
        }

        internal void CurStudentToPostr()
        {
            if (students == null || students.Count == 0) return;

            var tmp = students[indexCurStudent];
            students[indexCurStudent] = new PostcgraduateStudent();
            students[indexCurStudent].firstName = tmp.firstName;
            students[indexCurStudent].secondName = tmp.secondName;
            students[indexCurStudent].faculty = tmp.faculty;
        }

        public void TryFind()
        {
            int oldIndex = indexCurStudent;
            MoveBack();
            if (oldIndex != indexCurStudent) return; //что-то нашёл
            MoveNext(); //попробуем поискать впереди, елсли не найдёт то и ладно)
        }

        internal void DeletCurStud()
        {
            if (students == null || students.Count == 0) return;

            students.RemoveAt(indexCurStudent);
            if (indexCurStudent > 0) indexCurStudent--;
            if (CurStudent() != null) return;
            TryFind();
        }
    }
}
