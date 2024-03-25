namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
       int[] int_array = {11,23,31,42,53};
       ArraySum(int_array);
       
       int[,] array_2d = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
       };
      
        PrintAllOddNumber(array_2d);
       
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");
       
        int[,] Q2_3 = DoubleArray(array_2d);

        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
            Console.Write(num + " ");
        }
    }
    public static void ArraySum(int[] int_array){
        int sum = 0;
        foreach(int val in int_array){
            sum += val;
        }
        Console.WriteLine($"The sum of int_array is: {sum}");
    }
    public static void PrintAllOddNumber(int[ , ] array_2d){
        foreach(int num in array_2d){
            if(num % 2 != 0)
            Console.Write(num + " ");
        }
        
    }
    public static int ElementSum(int[ , ] array_2d){
        int sum2 = 0;
        foreach(int num in array_2d){
            sum2 += num;
    }
    return sum2;
    }
    public static int[,] DoubleArray(int[,] array_2d){
        int[,] doubleArray = new int[3,3];
        for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            doubleArray[row, col] = array_2d[row, col] * 2;
        }
    }
        return doubleArray;
   
        }
    }

        
