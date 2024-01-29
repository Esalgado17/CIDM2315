namespace H2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input three numbers: ");
        
        Console.Write("Please input the first number: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second number: ");
            int n2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the third number: ");
            int n3 = Convert.ToInt16(Console.ReadLine());
        
        int smallest;

            if(n1 <= n2) {
                if(n1 <= n3) {
                    smallest = n1;
              }
        else {
                smallest = n3;
              }
            }
        else {
            if (n2 <= n3){
                smallest = n2;
              }
        else{
                smallest = n3;
              }
        }
            Console.WriteLine("The smallest value is: " + smallest);
                }
              }

