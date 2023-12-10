class Program
{
    static void Main()
    {
        
        Console.WriteLine("Введите строки массива через запятую:");
        string[] inputStrings = Console.ReadLine().Split(',');

       
        string[] resultArray = FilterStrings(inputStrings);

        
        Console.WriteLine("Результирующий массив:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }
     
 
}