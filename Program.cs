using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();
                        
            bool cont = true;
            while (cont)
            {
                double num3 = 0;
                while (cont)
                {
                    Console.Write("MENU" +
                        "\n*Type The Number Next To the Desired Operation*\n" +
                        "\n1. ADD" +
                        "\n2. SUBTRACT" +
                        "\n3. DIVIDE" +
                        "\n4. MULTIPLY" +
                        "\n5. RAISE NUMBER TO A POWER" +
                        "\n6. ROOT OF THE NUMBER" +
                        "\n7. LEAVE MENU" +
                        "\n>>>");
                    int op = 0;
                    while (cont)
                    {
                        try
                        {
                            op = Convert.ToInt32(Console.ReadLine());
                            if (0 < op && op < 8)
                            {
                                break;
                            }
                            else
                            {

                                op /= 0;
                            }

                        }
                        catch (FormatException)
                        {
                            Console.Write("\nType the number next to the operation you wish to perform.\n>>>");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.Write("\nType the number next to the operation you wish to perform.\n>>>");
                        }
                    }

                    if (op == 7)
                    {
                        cont = false;
                        break;
                    }

                    double num1;
                    double num2;

                    if (num3 != 0)
                    {
                        Console.Write("\nWould you like to use the answer from the last problem as your first number? (Y or N)" +
                            "\n>>>");
                        string same = Console.ReadLine().ToUpper();
                        if (same == "Y")
                        {
                            Console.Write("\nWhat is the second number?\n>>>");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("");

                            if (op == 1)
                            {
                                num3 = CalculatorOperations.Adding(num3, num2);
                            }
                            else if (op == 2)
                            {
                                num3 = CalculatorOperations.Subtracting(num3, num2);
                            }
                            else if (op == 3)
                            {
                                num3 = CalculatorOperations.Divison(num3, num2);
                            }
                            else if (op == 4)
                            {
                                num3 = CalculatorOperations.Multiplication(num3, num2);
                            }
                            else if (op == 5)
                            {
                                num3 = CalculatorOperations.Exponent(num3, num2);
                            }
                            else if (op == 6)
                            {
                                num3 = CalculatorOperations.Root(num3, num2);
                            }
                            Console.Write("The answer is : " + num3);
                            Console.WriteLine("\nPress Enter");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Alright");
                            num3 = 0;
                        }
                    }

                    if (num3 == 0)
                    {
                        Console.Write("\nWhat is the first number?\n>>>");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\nWhat is the second number?\n>>>");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        if (op == 1)
                        {
                            num3 = CalculatorOperations.Adding(num1, num2);
                        }
                        else if (op == 2)
                        {
                            num3 = CalculatorOperations.Subtracting(num1, num2);
                        }
                        else if (op == 3)
                        {
                            num3 = CalculatorOperations.Divison(num1, num2);
                        }
                        else if (op == 4)
                        {
                            num3 = CalculatorOperations.Multiplication(num1, num2);
                        }
                        else if (op == 5)
                        {
                            num3 = CalculatorOperations.Exponent(num1, num2);
                        }
                        else if (op == 6)
                        {
                            num3 = CalculatorOperations.Root(num1, num2);
                        }
                        Console.Write("The answer is: " + num3);
                        Console.WriteLine("\nPRESS ENTER");
                        Console.ReadLine();

                    }
                }
            }
        }
    }
}
