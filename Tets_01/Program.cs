// using System.Linq;
// using System.Text;
String [] array1 = { "Hello","2", "world", ":-)" };
String [] array2 = new String[array1.Length];
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <=3)
    {
        count++;
        array2[count] = array1[i];
        Console.Write(array2[count] + " ");
    }
}
