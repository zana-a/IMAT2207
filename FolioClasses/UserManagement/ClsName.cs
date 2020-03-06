using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolioClasses.UserManagement
{
    public class Name
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }

        public Name(string fullName)
        {
            FirstName = fullName.Split(' ')[0];
            LastName = fullName.Split(' ')[1];
        }
    }
}
