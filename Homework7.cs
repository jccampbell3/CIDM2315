using System;
namespace Homework7;

class Program {
    static void Main(string[] Args) {
        Customer alice = new Customer(110, "Alice", 28);
        Customer bob = new Customer(111,"Bob", 30);

        alice.PrintCusInfo();
        bob.PrintCusInfo();

        alice.ChangeID(220);
        bob.ChangeID(221);

        alice.PrintCusInfo();
        bob.PrintCusInfo();

        alice.CompareAge(bob);

    }

}
class Customer {
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int id, string name, int age) {
        cus_id = id;
        cus_name = name;
        cus_age = age;
    }
    public void ChangeID(int new_id ) { cus_id = new_id; }
    public void PrintCusInfo() { Console.WriteLine("Customer: "+ cus_id+", name: "+cus_name+", age: "+cus_age); }
    public void CompareAge(Customer objCustomer) {
        if(objCustomer.cus_age > cus_age) Console.WriteLine(objCustomer.cus_name + " is older");
        else Console.WriteLine(cus_name + " is older.");
    }    

}