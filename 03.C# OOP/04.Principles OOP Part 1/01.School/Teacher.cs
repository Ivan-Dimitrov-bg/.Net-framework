using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teacher : Person, ICommentable
    {
        public List<Discipline> Disciplines{get; set;}

        public Teacher(string name)
        {
            this.Disciplines = new List<Discipline>();
            this.Name = name;
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
