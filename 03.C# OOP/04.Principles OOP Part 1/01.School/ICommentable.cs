using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    interface ICommentable
    {
        List<string> Comments { get; set; }
        void AddComment(string comment);
    }
}
