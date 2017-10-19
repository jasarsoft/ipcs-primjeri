using System;


namespace IPCS_26_V1
{
    class Person
    {
        public static int retirementAge;
        
        public Person(int retAge)
        {
            retirementAge = retAge;
        }

        public static int CalculateRemaingWorkYears(int age)
        {
            return (retirementAge - age);
        }
    }
}
