string[] Array(int size)
{

    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент{i + 1} ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}
void ShowArray(string[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] NewArray(string[] array)
{
    int lenght = new Random().Next(0, 4);
    string[] newArray2 = new string[lenght];

    Console.Write($"Длинна нового массива -> {lenght}");

    for (int i = 0; i < lenght; i++)
    {
        newArray2[i] = array[i];
    }
    Console.WriteLine();
    return newArray2;

}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] newArray = Array(size);
ShowArray(newArray);
ShowArray(NewArray(newArray));

