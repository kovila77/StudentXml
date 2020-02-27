using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsХml
{
    [Serializable]
    public class PostcgraduateStudent : Student
    {
        public string diploma = "";

        public PostcgraduateStudent() : base() { }
    }
}
