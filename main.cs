using System;

class Program {
  public static void Main (string[] args) 
  {
            bool finish = false;
            while (finish == false)
            {
                Console.WriteLine("please enter an integer");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num <= 1)
                {
                    Console.WriteLine("Not greater than 1");
                }
                if(num > 1)
                {
                    int x = 0;
                    int z = 0;
                    for(int i = 1; i <= num; i++)
                    {
                        z = num % i;
                        if (z >= 1)
                        {
                            x = x + 1;
                        }
                    }
                    if (x == (num - 2))
                    {
                        Console.WriteLine("Is Prime");
                    }
                    else
                    {
                        Console.WriteLine("Is not prime");
                    }
                }
                Console.WriteLine("Would u like to go again? (Y/N)");
                char y = Convert.ToChar(Console.ReadLine());
                bool Choice = false;
                while (Choice == false)
                {
                    if (y == 'N')
                    {
                        finish = true;
                        Choice = true;
                    }
                    else if (y == 'Y')
                    {
                        finish = false;
                        Choice = true;
                    }
                    else
                    {
                        Console.WriteLine("Would u like to go again? (Y/N)");
                        y = Convert.ToChar(Console.ReadLine());
                    }
                }
                                

            }
  }
}