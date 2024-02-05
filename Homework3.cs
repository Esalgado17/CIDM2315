namespace homework3;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("---Q1--- ");
        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
        bool prime_number = N > 1;
       for(int i = 2; i < N; i++){
        if ( N % i == 0){
            prime_number = false;
        break;
        }
       }
        if(prime_number){
            Console.WriteLine($"{N} is prime");
        }
        else{
            Console.WriteLine($"{N} is not prime");
    }
    //Q2
    Console.WriteLine("---Q2---");
    Console.WriteLine("input an int value: ");
    int n1 = Convert.ToInt16(Console.ReadLine());
    for(int row = 0; row < n1; row++){
        for(int col = 0; col < n1; col++){
             Console.Write('#');
    }

    Console.WriteLine("");
}
    //Q3
    Console.WriteLine("---Q3---");
    Console.WriteLine("Assign an int value to N: ");
    int n2 = Convert.ToInt16(Console.ReadLine());
    for(int row = 0; row < n2; row++){
        for(int col = 0; col < n2; col++){
        if ( row >=col)
        Console.Write('*');
        }
        Console.WriteLine("");
    }
}
}
