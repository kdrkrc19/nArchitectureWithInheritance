using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Users
    {
        public int id { get; set; }
        public string name {  get; set; }
        public string surname { get; set; }

        public Users(int id,string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }   
    }
}
