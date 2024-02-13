namespace HomeWork4;

class Program
{   
     static void Main(string[] args){
        //q1
        Console.WriteLine("---Q1---");
        Console.WriteLine("Input an integer: ");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input another integer: ");
        int b = Convert.ToInt16(Console.ReadLine());
        int result = larger_number(a, b);
        Console.WriteLine($"The largest number is: {result}" );
        //q2
        Console.WriteLine("---Q2---");
        Console.Write("Input left or Right:  ");
        string shape = Console.ReadLine();
        
        Console.Write("Input N: ");
        int N = Convert.ToInt16(Console.ReadLine());

        Console.Write("Input Left or Right: ");
        if (shape == "left"){
            LeftTriangle(N);
        }
    else{
        RightTriangle(N);
    }
     }
     //q1
    static int larger_number(int a, int b){
    if(a>b){
        return a;
    }
    else{
        return b;
    }
}
//q2
        static void LeftTriangle(int N){
            Console.WriteLine($"N is: {N}, Shape is: Left");
            for (int row =1; row<= N; row++){
                for(int col=1; col<= row; col++){
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
        static void RightTriangle(int N){
            Console.WriteLine($"N is: {N}, Shape is: Right");
            for (int row =1; row<= N; row++){
                for(int col=1; col<= N-row; col++){
                    Console.Write(" ");
                }
                for(int space = 1; space <= row; space++){
                   Console.Write('*');
}
                Console.WriteLine();
        }
}
}


    
