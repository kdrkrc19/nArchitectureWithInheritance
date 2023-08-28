using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Students : Users
    {
        public bool isStudent {get; set;}
        public Students(int id, string name, string surname, bool isStudent) : base(id ,name, surname)
        {
            this.isStudent = isStudent;
        }
    }
}
