using static Library;
int count = GetLengthArray("Задайте длину массива: ");
String [] array1 = new String[count];
for (int i = 0; i < array1.Length; i ++)
{
    array1[i] = GetElementArray("Задайте элемент массива: ");
}
GetNewArray(array1);

