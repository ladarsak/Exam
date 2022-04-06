// Первый вариант программы (длинный, некрасивый, рабочий)

string[] initialArray = new string[] { "John", "Ann", "Li", "Chan", "Richard" };

int resultArrayLength = 0;
int arrayCount = 0;

for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length < 4)
    {
        resultArrayLength++;
    }
}

string[] resultArray = new string[resultArrayLength];
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length < 4)
    {
        resultArray[arrayCount] = initialArray[i];
        Console.WriteLine(resultArray[arrayCount]);
        arrayCount++;
    }
}

// Второй вариант программы (короткий, красивый, рабочий.
// Однако наполовину - копипаста из справочника по С#, поэтому закомменченный)

/*
string[] initialArray = new string[] { "John", "Ann", "Li", "Chan", "Richard" };
string[] resultArray = Array.FindAll(initialArray, names => names.Length < 4);
for (int i = 0; i < resultArray.Length; i++)
{
    Console.WriteLine(resultArray[i]);
}
*/