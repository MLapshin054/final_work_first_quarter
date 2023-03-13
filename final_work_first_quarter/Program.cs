// Задача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// 
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// 
// ["Russia", "Denmark", "Kazan"] -> []


Console.Clear();

// string Prompt(string message)
// {
//   Console.Write(message);
//   string result = Convert.ToString(Console.ReadLine());
//   return result;
// }


// string[] CreateArray(string m)
// {
//   string[] array = new string[5];
//   return array;
// }


void FillArray(string[] firstArray, string[] secondArray)
{
  int count = 0;
  for (int i = 0; i < firstArray.Length; i++)
  {
    if (firstArray[i].Length <= 3)
    {
      secondArray[count] = firstArray[i];
      count++;
    }
  }
}


void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

string[] firstArray = { "hello", "2", "world", ":-)" };
string[] secondArray = new string[firstArray.Length];
FillArray(firstArray, secondArray);
PrintArray(secondArray);