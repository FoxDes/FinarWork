// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.Write("Введите сумму элементов в массиве: ");
int x;
while (!int.TryParse(Console.ReadLine(), out x) || x <= 0) 
Console.WriteLine("Введите поочередно элементы массива через Enter: ");

string[] array = new string[x]; 
string[] newArray = new string[x];

FillArray(array);
void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива №{0}: ", i + 1);
        array[i] = Console.ReadLine();
    }
}
