using System;

namespace FirstTask
{
	class Program
	{

      //  static void OddeveProg()
       // {
         //   int i;
         //   Console.WriteLine("Enter Number : ");
         //   i = int.Parse(Console.ReadLine());
           // if (i % 2 == 0)
          //  {
           //     Console.Write("Number is an Even Number");
            //    Console.ReadLine();
        //    }
        //    else
          //  {
               // Console.Write("Number is an Odd Number");
           //     Console.ReadLine();
           // }
       // }
               static void Checkdivisible7()
        {
                int number, sum = 0;
                do
                {
				Console.WriteLine("enter the number");
                    number= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("go on..");
                    sum += number;
                    if (sum % 7 == 0)
                    {
                        Console.WriteLine("number is divisible by seven:" + sum);
                    }

                }
                while (number > 0);
            }

        static void Primewithinrange()
        {
            Console.WriteLine("minimum num");
            int startnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum num");
            int endnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime numbers from {0} and {1} are ", startnumber, endnumber);
            int i;
            for (i = startnumber; i <= endnumber; i++)
            {
                int flag = 0;
                int j;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = i;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine(i);
            }
        }
        static void accountProb()
        {
            int count = 0;
            string uname = "Ramu";
            string pass = "1234";
            do
            {
                Console.WriteLine("enter username");
                string user = Console.ReadLine();
                Console.WriteLine("enter password");
                string password = Console.ReadLine();
                if (user == uname && password == pass)
                    Console.WriteLine("WELCOME");
                else
                {
                    Console.WriteLine("Try again");
                    count++;
                }
            }
            while (count < 3);
            if (count >= 3)
                Console.WriteLine("the account locked");
        }

            static void Main(string[] args)
		{
            accountProb();
            //OddeveProg();     
            //Checkdivisible7();
           // Primewithinrange();
		}
	}
}
