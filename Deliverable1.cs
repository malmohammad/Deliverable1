using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType, result = "", strGroupSize;
            int groupSize;

            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group?");
            strGroupSize = Console.ReadLine();
            groupSize = Convert.ToInt32(strGroupSize);

            if (groupSize == 2 || groupSize == 1)
            {
                result = "First Class to ";
            }
            else if(groupSize >= 3 && groupSize <= 5)
            {
                result = "Hellicopter to ";
            }
            else if (groupSize >= 6)
            {
                result = "Charter Flight to ";
            }
           
            if (vacationType.ToLower() == "musical")
            {
                result = result + "New Orleans.";
            }
            else if (vacationType.ToLower() == "tropical")
            {
                result = result + "Beach Vacation in Mexico.";
            }
            else if (vacationType.ToLower() == "adventurous")
            {
                result = result + "Whitewater Rafting the Grand Canyon.";
            }

            Console.WriteLine("Since you are a group of " + strGroupSize + " going on a " + vacationType + ", you should take a " + result);
        }
    }
}
