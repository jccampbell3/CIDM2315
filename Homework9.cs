using System;
namespace Homework9;

class Program {
    static void Main(string[] args) {

        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student Cathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");

        Dictionary<string, double> gradeBook = new Dictionary<string, double>();
        
        gradeBook.Add("Alice", 4.0);
        gradeBook.Add("Bob", 3.6);
        gradeBook.Add("Cathy", 2.5);
        gradeBook.Add("David", 1.8);

        Console.WriteLine("Checking gradebook for Tom");
        studentCheck(gradeBook, "Tom");

        double average = averageGPA(gradeBook);  

        printGradeBook(gradeBook, average, Student.student_list);

          

        
    } // main end


    static void studentCheck(Dictionary<string, double> grades, string match) {

        if(checkEnroll(grades, match)) Console.WriteLine("Tom found.");
        else addGrade(grades, match);
         
    }

    static bool checkEnroll(Dictionary<string, double> grades, string match) {

        foreach (var g in grades) if(g.Key == match) return true;
        return false;
    
    }

    static void addGrade(Dictionary<string, double> grades, string name) {
        grades.Add(name, 3.3);
        Student tom = new Student(555, "Tom");
        Console.WriteLine(name +" was added to the grade book with GPA: " + grades[name]);
    }

    static double averageGPA(Dictionary<string, double> grades) {
        double average = 0;
        int i = 0;
        foreach (var tgpa in grades) {
            average += tgpa.Value;
            i++;
        }
        average = average/i;
        Console.WriteLine("The Average GPA is " + average);
        return average;
    }
    static void printGradeBook(Dictionary<string, double> grades, double average, List<Student> students) {
        foreach(var tgpa in grades) {
            if(tgpa.Value > average) {
                foreach(var check in students) {
                    if(check.getName() == tgpa.Key ) check.PrintInfo();
                }
            }
        }
    }

} // program end

class Student {
    public static List<Student> student_list = new List<Student>();
    private int studentID {get;set;}
    private string studentName {get;set;}
    public Student(int studentID, string studentName) {
        this.studentID = studentID;
        this.studentName = studentName;
        student_list.Add(this);
    }
    public void PrintInfo() {
        Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
    }
    public string getName() {
        return studentName;
    }
    public int getID() {
        return studentID;
    }

}