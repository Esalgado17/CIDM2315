using System.Runtime.InteropServices;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input first integer: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Input second integer: ");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.Write("Input first integer: ");
        int c = Convert.ToInt16(Console.ReadLine());
        Console.Write("Input second integer: ");
        int d = Convert.ToInt16(Console.ReadLine());
        int largestnumber = Largest_number(a, b, c, d);
         Console.WriteLine($"The largest number is: {largestnumber}");
         //Q3
         creatAccount();
    }
    static int Largest_number(int A, int B){
       if(A > B ){
            return A;
       }
       else{
        return B;
       }
    }
    static int Largest_number(int A, int B, int C, int D){
        return Largest_number(Largest_number(A,B), Largest_number(C,D));
    }
    static bool checkAge(int birth_year){
    int current_year = 2024;
    int age =  current_year - birth_year;
    if(age >= 18){
        return true;
    }
    else{
        return false;
    }
    }
    static void creatAccount(){
    Console.Write("Enter Your Username: ");
    string userName = Console.ReadLine();
    Console.Write("Enter your Password: ");
    string userpassword = Console.ReadLine();
    Console.Write("Enter Your Password again: ");
    string comfirmpassword = Console.ReadLine();
    Console.Write("Enter Your Birthyear: ");
    int birth_year =  Convert.ToInt16(Console.ReadLine());
    if(checkAge(birth_year)){
        if(userpassword == comfirmpassword){
            Console.WriteLine("Account is created successfully");
        }
        else{
            Console.WriteLine("Wrong Password");
        }
        }
        else{
            Console.WriteLine("Could not create an account");
        }

        }
        }
    

