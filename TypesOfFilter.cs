using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsХml
{
    static class TypesOfFilter
    {
        public static StudentHandler.ConditionFrilter FirstName(string searchingStr)
        {
            if (searchingStr == "" || searchingStr == null) return null;
            return ((Student student) => student.firstName.Contains(searchingStr));
        }
        public static StudentHandler.ConditionFrilter SecondName(string searchingStr)
        {
            if (searchingStr == "" || searchingStr == null) return null;
            return ((Student student) => student.secondName.Contains(searchingStr));
        }
        public static StudentHandler.ConditionFrilter Faculty(string searchingStr)
        {
            if (searchingStr == "" || searchingStr == null) return null;
            return ((Student student) => student.faculty.Contains(searchingStr));
        }
        public static StudentHandler.ConditionFrilter Diploma(string searchingStr)
        {
            if (searchingStr == "" || searchingStr == null) return null;
            return ((Student student) => (student is PostcgraduateStudent) && (((PostcgraduateStudent)student).diploma.Contains(searchingStr)));
        }
        public static StudentHandler.ConditionFrilter NoFilter()
        {
            return null;
        }
    }
}
