using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    internal class Manager
    {
        int check;
        public static readonly Manager Instance= new Manager();
        Hashtable managerTable = new Hashtable(9899);

        Random random = new Random(DateTime.Now.Millisecond);
        public void LoadTable()
        {
            for (int i = 1; i < 1000; i++)
            {
                int randomId = random.Next(100,9999);
                if(randomId % 2==0)
                {
                    int randomForBalls = random.Next(1,5);
                    Falafel fl= new Falafel();
                    fl.id = randomId;
                    fl.ballsCount = randomForBalls;
                    if(!managerTable.ContainsKey(randomId))
                    {
                        managerTable.Add(fl.id, fl);
                    }   
                }
                else
                {
                    int randomForBalls = random.Next(1, 5);
                    IceCream ic = new IceCream();
                    ic.id = randomId;
                    ic.ballsCount = randomForBalls;
                    if (!managerTable.ContainsKey(randomId))
                    {
                        managerTable.Add(ic.id, ic);
                    }
                }      
            }
            for (int j = 1; j < 20; j++)
            {
                Console.WriteLine("Please enter a number between 100 to 9999");
                check = Convert.ToInt32(Console.ReadLine());
                if (managerTable[check] is IceCream)
                {
                    IceCream ic = (IceCream)managerTable[check];
                    Console.WriteLine("This iceCrean has: " + ic.ballsCount + " balls");
                }
                else if(managerTable[check] is Falafel)
                {
                   Falafel fl = (Falafel)managerTable[check];
                    Console.WriteLine("This falafel has: " + fl.ballsCount + " balls");
                }
                else
                {
                    Console.WriteLine("This number is not in the list");
                }
            }
        }

    }
}
