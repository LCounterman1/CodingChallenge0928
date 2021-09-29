using ClassLibrary09_28;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondingChallenge09_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook newProfile = new Facebook("Leslie", "Counterman", 30, "Female", "Indiana");



            Console.WriteLine(newProfile.FirstName);
            Console.WriteLine(newProfile.LastName);
            Console.WriteLine(newProfile.AgeInYears);
            Console.WriteLine(newProfile.Gender);
            Console.WriteLine(newProfile.Location);

            Console.ReadLine();
        }
    }
}
