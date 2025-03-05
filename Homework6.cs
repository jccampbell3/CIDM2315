using System;
namespace Homeowork6;
class Program {
    static void Main(string[] args) {

        Professor Alice = new Professor("Alice","Java");
        Professor Bob = new Professor("Bob","Math");

        Alice.SetSalary(9000);
        Bob.SetSalary(8000);

        giveProf(Alice);
        giveProf(Bob);

        Student Lisa = new Student("Lisa","Java");
        Student Tom = new Student("Tom", "Math");

        Lisa.SetGrade(90);
        Tom.SetGrade(80);

        giveStud(Lisa);
        giveStud(Tom);

        profDiff(Alice, Bob);
        totStud(Lisa,Tom);

    }

    static void giveProf(Professor one) {
        Console.WriteLine($"Professor "+ one.profName+ " teaches "+ one.classTeach+ ", and the salary is: "+ one.GetSalary());
    }
    static void profDiff(Professor one, Professor two) {
        Console.WriteLine($"The salary difference between "+ one.profName + " and "+ two.profName+  " is: " + salDiff(one, two));
    }
    static double salDiff(Professor one, Professor two) {
        if(one.GetSalary()>two.GetSalary())
            return one.GetSalary() - two.GetSalary();
        else return two.GetSalary() - one.GetSalary();    
    }
    static void giveStud(Student one) {
        Console.WriteLine($"Student "+ one.studentName+ " enrolls in "+ one.classEnroll+ ", and the grade is: "+ one.GetGrade());
    }
    static void totStud(Student one, Student two) {
        Console.WriteLine($"The total grade of "+ one.studentName + " and "+ two.studentName+ " is: "+ gradDiff(one, two));
    }
    static double gradDiff(Student one, Student Two) {
        return one.GetGrade() + Two.GetGrade();
    }

}

class Professor {
    public string profName = "";
    public string classTeach = "";
    private double salary = 0;

    public Professor() {}
    public Professor(string name, string teach) {
        profName = name;
        classTeach = teach;
    }

    public void SetSalary(double salaryAmt) {
        salary = salaryAmt;
    }
    public double GetSalary() {
        return salary;
    }

}

class Student {
    public string studentName = "";
    public string classEnroll = "";
    private double studentGrade = 0;

    public Student() {}
    public Student(string name, string enroll) {
        studentName = name;
        classEnroll = enroll;
    }
    public void SetGrade(double newGrade) {
        studentGrade = newGrade;
    }

    public double GetGrade() {
        return studentGrade;
    }

}