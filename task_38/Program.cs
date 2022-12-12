void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 101); // [-20, 100]
}
void ReleaseArray(int[] array)
{
int min = array [0];
int max = array [0];
int minInd = 0;
int maxInd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
        minInd = i;
    }
    else if (array[i] > max)
    {
        max = array[i];
        maxInd = i;
    }
}
for (int i = minInd; i < maxInd; i++)
Console.Write (array [i]);
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
