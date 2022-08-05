
// Этот метод берет на вход количество слов в будущем массиве,
// а на выходе дает массив из слов
string[] CreateStringArray(int number)
{
    string[] wordsArray = new string[number];

    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово ");
        wordsArray[i] = Console.ReadLine();
    }
   
    return wordsArray;
}
//Этот метод берет на вход массив из строк и ввыовдит в консоли этот массив
void ShowStringArray(string[]stringArray)
{  
    if(stringArray.Length==1)  Console.Write("{"+stringArray[0]+"}");
    else Console.Write("{"+stringArray[0]+", ");
    for (int i = 1; i < stringArray.Length; i++)
    {
        if (i==stringArray.Length-1)
        {
           Console.Write(stringArray[i]+"}"); 
        }
        else
        {
           Console.Write(stringArray[i]+", "); 
        }
    }
}
// Этот метод берет на вход массив из строк, а на выходе
// показывает сколько слов в массиве состоит из трех и менее символов
int CountThreeSymbolsWords(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3) count++;
    }
    return count;
}
//Этот метод берет на вход массив их строк и число слов состояющих 
//из трех и менее символов. Создает новый массив и заполняет его словами состоящими 
// из трех и менее символов. На выходе мы получаем  заполненный массив
string[] CreateThreeSymbolStringArray(string[] stringArray, int size)
{
    string[] resultStringArray = new string[size];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if(stringArray[i].Length <= 3)
         {
            resultStringArray[j]= stringArray[i];
            j++;
         }
         
    }
    return resultStringArray;
}
//Число слов для первичного массива  задается пользователем
Console.WriteLine("Введите количество слов в массивем  ");
int numberOfWords = Convert.ToInt32(Console.ReadLine());

string[] userArray = CreateStringArray(numberOfWords);
Console.WriteLine();
Console.WriteLine("Ваш массив: ");
ShowStringArray(userArray);
int threeSymbolWords = CountThreeSymbolsWords(userArray);
string[] transformedArray = CreateThreeSymbolStringArray(userArray,threeSymbolWords);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
ShowStringArray(transformedArray);