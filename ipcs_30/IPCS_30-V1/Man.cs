using System;


namespace IPCS_30_V1
{
    class Man
    {
        private int numberOfPeople;

        //svojstvo za broj ljudi
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
        }


        //konstruktor za inicijalizaciju objekta
        public Man(int number)
        {
            numberOfPeople = number;
        }
    }
}
