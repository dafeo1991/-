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


void NewArray(string[] array)
{
    Console.Write("Получившийся новый массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        if (array[i].Length < 4)
        {
            Console.Write(array[i] + " ");
            count++;
        }
    }
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] newArray = Array(size);
ShowArray(newArray);
NewArray(newArray);

