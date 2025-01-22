namespace Homework1;
    /*
        John Campbell
    */
using System;
class program {
    static void Main(string[] args) {
        //code begins here
        // alg prov - z = 4x^2 + 3y when x = 2.5, y = 3.3
        double x = 2.5;
        double y = 3.3;

        // complete formula given calling system function to calc exponent
        //double z = (4* Math.Pow(x, 2)) + (3*y);
        //using what the instructor wants us to
        double z = ( (4*(x*x)) + (3*y));

        // write to console using pointers for variables

        Console.WriteLine($"X = {x}, Y = {y}" );
        Console.WriteLine($"The value of Z is: {z}");
    }

}