public static class Library
{
    public static int GetLengthArray(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static string GetElementArray(string text)
    {
        Console.WriteLine(text);
        return Convert.ToString(Console.ReadLine());
    }
    public static void GetNewArray(string [] array1)
    {
        String [] array2 = new String[array1.Length];
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                count++;
                array2[count] = array1[i];
                Console.Write(array2[count] + " ");
            }
        }
        if (count==0) Console.Write("Таких элементов нет");
    }
}