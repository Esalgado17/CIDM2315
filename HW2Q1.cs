namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a grade in letters: ");
        string letter_grade = Console.ReadLine();
        int point_int;

        if(letter_grade === "A" ){
            point_int = 4;
        }
        else if (letter_grade == "B"){
            point_int = 3;
        }
        else if (letter_grade == "C"){
            point_int = 2;
        }
        else if (letter_grade == "D"){
            point_int = 1;
        }
        else if (letter_grade == "F"){
            point_int = 0;
        }
        else{
            Console.WriteLine("Wrong Letter Grade! ");
            return;
        }
        Console.WriteLine($"GPA point: {point_int}");
       }
    }

