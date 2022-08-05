
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

int CountThreeSymbolsWords(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3) count++;
    }
    return count;
}

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