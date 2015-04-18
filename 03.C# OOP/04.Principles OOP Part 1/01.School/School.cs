using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class School
    {
        public string Name { get; set; }
        List<SchoolClass> classes;

        public School(string schoolName)
        {
            this.classes = new List<SchoolClass>();
            this.Name = schoolName;
        }
    }
}
