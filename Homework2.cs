namespace Homework2;
using System;
using System.Data;

class Program {

    static void Main(string[] args) {


        //getinput
        Console.WriteLine("Please input a letter grade:");
        string grade = Console.ReadLine();

        // switch for various inputs
       switch (grade) {
        case "A":
             Console.WriteLine("GPA point: 4");
             break;
        case "B":
            Console.WriteLine("GPA point: 3");
            break;
        case "C":
            Console.WriteLine("GPA point: 2");
            break;
        case "D":
            Console.WriteLine("GPA point: 1");
            break;
        case "F":
            Console.WriteLine("GPA point: 0");
            break;
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break;       
       }

        ////////////////////////////////////////////////
        // Q2 Begins here
        //intialize variables
        string[] inputNums = new string[3];
        int[] threeNums = new int[4];
        int tempComp;

        //Collecting all inputs
        Console.WriteLine("Please input 3 numbers. \nPlease input the first num:");
        inputNums[0] = Console.ReadLine();
        Console.WriteLine("Please input second num:");
        inputNums[1] = Console.ReadLine();
        Console.WriteLine("Please input third num:");
        inputNums[2] = Console.ReadLine();
        
        //for loop converting to ints
        for(int i =0; i<3; i++) threeNums[i] = Convert.ToInt32(inputNums[i]);

        //setting output to first element
        tempComp = threeNums[0];

        //finding the smallest number
        for(int i =0; i<3; i++) if(threeNums[i] < tempComp) tempComp = threeNums[i];

        Console.WriteLine($"The smallest value is : "+tempComp);


        ////////////////////////////////////////////
        /// Q3 begins here
        //initialize variables
        string inputYear = "";
        int convYear = 0;
        bool brainTeaser = false;
        
        //get inputs
        Console.WriteLine("Please input a year:");
        convYear = Convert.ToInt32(inputYear = Console.ReadLine());

        //check if leap year then output result
        if((convYear%4) == 0) brainTeaser = true; 
            if((convYear%100) == 0 ) brainTeaser = false;
                if(convYear%400 == 0) brainTeaser = true;
        
        if(brainTeaser == true) Console.WriteLine(convYear+" is a Leap Year.");
        
        else Console.WriteLine(convYear + " is not a Leap Year.");
        

    }
}
