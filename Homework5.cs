namespace Homework5;
using System;
using System.Diagnostics;

class Program {
    static void Main(string[] args) {

    //Q1 Method
    int inputOne, inputTwo, inputThree, inputFour = 0;
    inputOne = 3;
    inputTwo = 5;
    int result = Comp(inputOne, inputTwo);
    Console.WriteLine("a = " + inputOne + "; b = " + inputTwo);
    Console.WriteLine("The largest number is: "+ result);

    //Q2 Method
    Console.WriteLine("Please input 4 numbers, each followed by Enter");
    inputOne = Convert.ToInt32(Console.ReadLine());
    inputTwo = Convert.ToInt32(Console.ReadLine());
    inputThree = Convert.ToInt32(Console.ReadLine());
    inputFour = Convert.ToInt32(Console.ReadLine());

    result = Comp(Comp(inputOne,inputTwo), Comp(inputThree,inputFour));
    Console.WriteLine("a = "+inputOne+"; b = "+inputTwo+"; c = "+inputThree+"; d = "+inputFour);
    Console.WriteLine("The largest number is: " + result);

    //Q3 Method
    string userName ="", passWord = "";
    int age = 0;
    CreateAccount(ref userName, ref passWord, ref age);

    
    
    }
    
    /*
        //////////////////// Method 1
*/
                //Method takes two numbers and returns largest
    static int Comp(int a, int b) {     
        if(a>b) return a;
        else return b;
    }
    
    /// <summary>
    /// Method to create an account. no sense in making variables that delete so made refs in order to store data 
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="passWord"></param>
    /// <param name="age"></param>
    static void CreateAccount(ref string userName, ref string passWord, ref int age) {
        string tempPass;

        Console.WriteLine("Enter your username:");
        userName = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        passWord = Console.ReadLine();
        Console.WriteLine("Enter your password again: ");
        tempPass = Console.ReadLine();
        Console.WriteLine("Enter your Birthyear");
        age = Convert.ToInt32(Console.ReadLine());

    
        if(checkAge(age) && passMatch(passWord, tempPass)) {
            Console.WriteLine("Account is created successfully.");
            return;
        }
        else if(!passMatch(passWord, tempPass)) {
            Console.WriteLine("Wrong Password.");
            return;
        }  
        else if(!checkAge(age)) {
            Console.WriteLine("Could not create an account.");
            return;
        }
        else {
            Console.WriteLine("Some error occurred.");
            return;
        }

    }   
    // simple method to check if age is 18+
    static bool checkAge(int a) {
        if((2025 - a) >= 18) return true;
        return false;
    }
    // simple method to check if passwords match
    static bool passMatch(string pass1, string pass2) {
        if(pass1 == pass2) return true;
        return false;
    }

}