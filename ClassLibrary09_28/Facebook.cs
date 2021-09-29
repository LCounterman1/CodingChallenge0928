using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary09_28
{
    public class Facebook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AgeInYears { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }

        public Facebook(string firstName, string lastName, int age, string gender, string location)
        {
            FirstName = firstName;
            LastName = lastName;
            AgeInYears = age;
            Gender = gender;
            Location = location;

        }
 
    }

 
}
