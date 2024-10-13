using System;

namespace ICT407P_Assignment4
{
    class CheckPrime
    {
        static bool check_prime(int num)
        {
            for(int i=2;i<=(int)Math.Sqrt(num);i++)
            {
                if(num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:- ");
            string n = Console.ReadLine();
            Console.WriteLine("Number being prime is True/False:- " + check_prime(Convert.ToInt32(n)));
        }
    }
}