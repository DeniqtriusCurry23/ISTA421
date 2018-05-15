using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    MakeAccount(ref user);
                    goto MENU;
                case 2:
                    Authenticate(user);
                    goto MENU;
                case 3:
                    // printing each username and password to the screen then exiting
                    foreach (KeyValuePair<string, string> k in user)
                    {
                        Console.WriteLine(k);
                    }
                    Console.ReadLine();
                    return;
                default:
                    Console.WriteLine("Thats not an option. Pick a number 1-3 next time");
                    Console.ReadLine();
                    goto MENU;
            }
        }
            catch (FormatException)
            {
                Console.WriteLine("You can only input integer numbers. Try again");
                Console.ReadLine();
                goto MENU;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
                goto MENU;
            }
        }

        public static string Encrypt(string input)
{
    StringBuilder result = new StringBuilder();

    // passKey contains all the characters that are acceptable for a password
    char[] passKey = new char[] { 'a', 'b', 'c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            '0','1','2','3','4','5','6','7','8','9' };

    // passVal is the parrallel array that changes the value of the passKey into
    char[] passVal = new char[] { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','0','1','2','3','4','5','6','7','8','9',
            'a', 'b', 'c','d','e','f','g','h','i','j','k','l','m','A','B','C','D','E','F','G','H','I','J','K','L','M'};

    // adding the corresponding result one char at a time to the final result
    foreach (char letter in input)
    {
        int index = Array.IndexOf(passKey, letter);
        result.Append(passVal[index]);
    }

    return result.ToString();
}

// decrypt not used in this program
public static string Decrypt(string input)
{
    StringBuilder result = new StringBuilder();
    char[] passKey = new char[] { 'a', 'b', 'c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            '0','1','2','3','4','5','6','7','8','9' };
    char[] passVal = new char[] { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','0','1','2','3','4','5','6','7','8','9',
            'a', 'b', 'c','d','e','f','g','h','i','j','k','l','m','A','B','C','D','E','F','G','H','I','J','K','L','M'};

    // Adding the corresponding password value to the final result one char at a time
    foreach (char letter in input)
    {
        int index = Array.IndexOf(passVal, letter);
        result.Append(passKey[index]);
    }

    return result.ToString();
}

public static void MakeAccount(ref Dictionary<string, string> user)
{
    Console.Clear();
    Console.Write("Please enter a username: ");
    string userKey = Console.ReadLine();

    // testing first to see if the username already exists
    user.Add(userKey, "");
    Console.Write("Please enter your password: ");
    string userPass = Console.ReadLine();

    // saving user input as the password assigned to the username key and printing the encrypted password
    user[userKey] = userPass;
    Console.WriteLine($"encrypted password: {Encrypt(userPass)}");
    Console.ReadLine();
}

public static void Authenticate(Dictionary<string, string> user)
{
    Console.Clear();
    Console.WriteLine("Please enter a username");
    string name = Console.ReadLine();

    // first checking to see if the username exists or not
    if (user.ContainsKey(name))
    {
        Console.Write($"Please enter the password for {name}: ");
        string pass = Console.ReadLine();

        // if the username (key) exists next check to see if the password (value) is correct
        if (user[name] == pass)
        {
            Console.WriteLine("User Authenticated!");
        }
        else
        {
            Console.WriteLine("Incorrect password");
        }
    }
    else
    {
        Console.WriteLine("User does not exist");
    }

    Console.ReadLine();
} 
}
