using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_10_V3
{
    class UserData
    {
        static void Main(string[] args)
        {
            //VERZIJA 1
            String firstName = "Peter";
            String lastName = "Jackson";
            String birthDate = "01/01/1980";
            //String data = "First name: " + firstName + ", Last name: " + lastName + ", Birth data: " + birthDate;
            //Console.WriteLine(data);

            //VERZIJA 2
            StringBuilder data = new StringBuilder();
            data.Append("First name: " + firstName);
            data.Append(", Last name: " + lastName);
            data.Append(", Birth date: " + birthDate);
            Console.WriteLine(data);
        }
    }
}
