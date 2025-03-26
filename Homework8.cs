using System;
namespace Homework8;
class Program {
    static void Main(string[] args) { 

        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

 	    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};
        
   
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);


    }


        // Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list) {
        
        double total = 0;
        foreach (Customer credit in customer_list) {
            total += credit.customerCredit;
        }
        Console.WriteLine("The total credits: " + total);
    
    }


        // Q2 Create a method to calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list){
        double total = 0;
        double i = 0;
        foreach (Customer age in customer_list) {
            if(age.customerCity == "Amarillo") {
                total += age.customerAge;
                i++;
            }
        }
        Console.WriteLine("The average age of customers in Amarillo: " + total/i);
    
    }


        // Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list){
        Console.Write("Customers who live in Canyon and over 30 years old: ");
        foreach(Customer picky in customer_list) {
            if(picky.customerCity == "Canyon" && picky.customerAge > 30) Console.Write(picky.customerName + ", ");
        }    
    
    }

}//main proggram end



class Customer {
    public string customerName { get; set; }
    public int customerAge{ get; set; }
    public string customerCity {get; set;}
    public double customerCredit{ get; set; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit) {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }


}
