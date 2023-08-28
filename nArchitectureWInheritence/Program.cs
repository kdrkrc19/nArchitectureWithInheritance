using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture
{//PRESENT KATMANI
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<UsersFakeData> users = new List<UsersFakeData>();
            MyBusinessCode myBusinessCode = new MyBusinessCode();
            users = myBusinessCode.ConvertEntityToDTO();
            foreach (UsersFakeData item in users)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.name);
                Console.WriteLine(item.surname);

            }
            Console.ReadLine();
        }
    }
}
