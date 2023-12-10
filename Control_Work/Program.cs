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
     static string[] FilterStrings(string[] inputArray)
    {
        
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
  
        string[] resultArray = new string[count];

        
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}