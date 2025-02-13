namespace Homework3;
using System;
using System.Data;

class Program {
    static void Main(string[] args) {

        /////////Q1 starts
        //// initial variables

        int inputNum = 0;
        
        //ask and read line
        Console.WriteLine("Input an integer:");
        inputNum = Convert.ToInt32(Console.ReadLine());
        
        //setup iterators and conditionals
        int i = inputNum - 1;
        bool outCome = false;
        //check if prime
        while(i != 1) {
            if(inputNum%i==0) {
                outCome = true; 
                break;
            }
            i--;
        }

        //outout outcome
        if(outCome) Console.WriteLine("N is non-prime");
        else Console.WriteLine("N is Prime");

        ///////////////////Q2 starts
        // reusing variables
        inputNum = 0;

        //ask question and get input
        Console.WriteLine("Assign an int value to N");
        inputNum = Convert.ToInt32(Console.ReadLine());

        //for loop to draw square
        for(int j = 0; j < inputNum ; j++) {  
            for(int k = 0; k < inputNum; k++) Console.Write("*");
        Console.Write("\n");
        }

        ///////////////////////////// Q3 starts
        /// reusing variables
        inputNum = 0;

        //ask for input
        Console.WriteLine("Assign an int value to N");
        inputNum = Convert.ToInt32(Console.ReadLine());
    
        for(int j = 0; j < inputNum; j++) {
            for(int k = j+1;k > 0; k--) Console.Write("*");
        Console.Write("\n");

        }



        ////////////////////Bonus Starts
        /// reusing variables
        inputNum = 0;
        Console.WriteLine("Assign an int value to N");
        inputNum = Convert.ToInt32(Console.ReadLine());

        //int cantKeepTrack = inputNum;

       
        for(int j = 1; j <= inputNum; j++) {
            for(int k = 0; k < inputNum - j; k++) Console.Write(" ");
            
            for(int l = 0; l < j; l++) Console.Write(j);
            Console.Write("\n");
         
        }

    }
}
