using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            int base10 = 0, base8 = 0, base2 = 0;

            
            Console.WriteLine("Please enter a number in base 10, 8, or 2 to convert");
            string input = Console.ReadLine();
            Console.WriteLine("What base is this number in?");
            int intBase = int.Parse(Console.ReadLine());

            
            switch (intBase)
            {
                case 10:
                    {
                        base10 = int.Parse(input);
                        base2 = Binary(input, intBase);
                        base8 = Octal(input, intBase);
                        break;
                    }
                case 8:
                    {
                        // converting to base 10 before base 2
                        base8 = int.Parse(input);
                        base10 = BaseTen(input, intBase);
                        base2 = Binary(base10.ToString(), 10);
                        break;
                    }
                case 2:
                    {
                        // converting to base 10 before base 8
                        base2 = int.Parse(input);
                        base10 = BaseTen(input, intBase);
                        base8 = Octal(base10.ToString(), 10);
                        break;
                    }
                default:
                    {
                        // only accepting base 2,10, or 8 for this program. Can be modified in the future to accept all bases
                        Console.WriteLine("You have to enter a number in either base 10, 8, or 2");
                        Console.ReadLine();
                        goto MENU;
                    }
            }

            // printing all results to the screen
            Console.WriteLine($"Base 10: {base10}, Base 8: {base8}, Base 2: {base2}");
            Console.ReadLine();
        }

            catch (FormatException)
            {
                Console.WriteLine("Only allowed to input integer numbers. Try again");
                Console.ReadLine();
                goto MENU;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you input was too large");
                Console.ReadLine();
                goto MENU;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                goto MENU;
            }
        }

        
        public static int Binary(string input, int intBase)
{
    int result = 0;
    int temp = int.Parse(input);

    for (int i = 0; temp != 0; i++)
    {
        
        int mod = (temp % 2) * (int)Math.Pow(10, i);
       
        temp /= 2;
        result += mod;
    }

    return result;
}


public static int Octal(string input, int intBase)
{
    int result = 0;
    int temp = int.Parse(input);

    for (int i = 0; temp != 0; i++)
    {
        
        int mod = (temp % 8) * (int)Math.Pow(10, i);
      
        temp /= 8;
        result += mod;
    }

    return result;
}

// this method converts any number to base 10. This method works with any base, not just 2 and 8
public static int BaseTen(string input, int intBase)
{
    int result = 0;
    int endIndex = input.Length;

    for (int i = 0; i < input.Length; i++)
    {
        // the number is read starting from the lowest point - from right to left
        endIndex--;
        result += int.Parse(input[endIndex].ToString()) * (int)Math.Pow(intBase, i);
    }

    return result;
}

        }
    }
}
