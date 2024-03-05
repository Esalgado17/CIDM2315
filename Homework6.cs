namespace Homework6;
class Professor
{
    public string  Profname;
    public string classTaught;

    private double salary;
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double Getsalary(){
        return salary;
    }
}
class Student{
    public string studentName;    
    public string classEnrolled;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.Profname = "Alice";
        p1.classTaught = "Java";
        p1.SetSalary(9000.00);
        
        Professor p2= new Professor();
        p2.Profname = "Bob";
        p2.classTaught = "Math";
        p2.SetSalary(8000.00);
        
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnrolled = "Java";
        s1.SetGrade(90.00);
        
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnrolled = "Math";
        s2.SetGrade(80.00);
        
        Console.WriteLine("Professor "+ p1.Profname + " teaches "+ p1.classTaught+ " and the salary is: "+ p1.Getsalary());
        Console.WriteLine("Professor "+ p2.Profname + "teaches "+ p2.classTaught+ "and the salary is: "+ p2.Getsalary());
        Console.WriteLine("Student "+ s1.studentName + "enrolls "+ s1.classEnrolled+ "and the grade is: "+ s1.GetGrade());
        Console.WriteLine("Student "+ s2.studentName + "enrolls "+ s2.classEnrolled+ "and the grade is: "+ s2.GetGrade());
        Console.WriteLine("The salary difference between "+p1.Profname+ "and "+ p2.Profname+"is: " + (p1.Getsalary()-p2.Getsalary()));
        Console.WriteLine("The total grade of "+s1.studentName+ "and "+ s2.studentName+"is: " + (s1.GetGrade()+s2.GetGrade()));
    }
}
