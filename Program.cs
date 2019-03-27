using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cal
    {
        public void Calculator(int n)
        {
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                int n1 = r.Next(1, 101);
                int n2 = r.Next(1, 101);
                int n3 = r.Next(1, 101);
                int n4 = r.Next(1, 101);
                int op = r.Next(1, 5);
                int result = 0;

                switch (op)
                {
                    case 1:
                        result = n1 + n2 - n3;
                        if (result < 0) i--;
                        else
                        {
                            Console.WriteLine(n1 + "+" + n2 + "-" + n3 + "=" + result);
                        }
                        break;
                    case 2:
                        result = n1 * n2 - n3;

                        if (result < 0) i--;
                        else
                        {
                            Console.WriteLine(n1 + "*" + n2 + "-" + n3 + "=" + result);
                        }
                        break;
                    case 3:
                        result = n1 * n2 + n3;

                        Console.WriteLine(n1 + "*" + n2 + "+" + n3 + "=" + result);
                        break;
                    case 4:
                        result = n1 / n2 + n3;

                        if (n1 % n2 != 0) i--;
                        else
                        {
                            Console.WriteLine(n1 + "/" + n2 + "+" + n3 + "=" + result);
                        }
                        break;
                    case 5:
                        result = n1 / n2 - n3;

                        if (result < 0 || n1 % n2 != 0) i--;
                        else
                        {
                            Console.WriteLine(n1 + "/" + n2 + "-" + n3 + "=" + result);
                        }
                        break;
                    case 6:
                        result = n1 / n2 * n3;
                        if (n1 % n2 != 0) i--;
                        else
                        {
                            Console.WriteLine(n1 + "/" + n2 + "*" + n3 + "=" + result);
                        }
                        break;

                }
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Please input the amout of questions:");
            int n = Convert.ToInt32(Console.ReadLine());
            Cal c = new Cal();
            c.Calculator(n);
        }


    }
}