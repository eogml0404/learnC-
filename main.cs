using System;

class Program
{
    public static void Main(string[] args)
    {
        bool boolVariable = true;
        int intVariable = 10;
        float floatVariable = 3.4f;
        char charVariable = 'a';


        Console.WriteLine(boolVariable);
        Console.WriteLine(intVariable);
        Console.WriteLine(floatVariable);
        Console.WriteLine(charVariable);

        if (intVariable == 10) Console.WriteLine("10 입니다.");
        else Console.WriteLine("10이 아닙니다.");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        int j = 1;
        while (true)
        {

            Console.WriteLine(j);
            j++;

            if (j > 3)
                break;

        }

        sbyte value1 = 64;
        sbyte value2 = 64;

      //(int)value1 -> 명시적 형변환, (int)value1 + value2; -> 암시적 형변환 더 큰 데이터형
        int value3 = (int)value1 + value2;
        Console.WriteLine(value3);

    }
}