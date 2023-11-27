using System;
using System.Runtime.InteropServices;

public class MyDll

{
    

    
    public static int Minimum(int a, int b)
    {
        return (a < b) ? a : b;
    }

    
    public static string NumberToWords(int number)
    {
        if (number < 0 || number > 1000)
        {
            return "Некорректное число";
        }

        string[] units = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять",
                           "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать",
                           "семнадцать", "восемнадцать", "девятнадцать" };
        string[] tens = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят",
                          "восемьдесят", "девяносто" };
        string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот",
                              "восемьсот", "девятьсот" };
        string[] thousands = {  "тысяча",  };

        if (number == 0)
        {
            return "ноль";
        }

        string resultString = "";

        if (number >= 100 && number <= 999)
        {
            resultString += hundreds[number / 100] + " ";
            number %= 100;
        }

        if (number >= 20 && number <= 99)
        {
            resultString += tens[number / 10] + " ";
            number %= 10;
        }

        if (number >= 1 && number <= 19)
        {
            resultString += units[number] + " ";
        }

        if (number >= 1000)
        {
            int thousandsCount = number / 1000;
            resultString += units[thousandsCount] + " " + thousands[GetThousandForm(thousandsCount)] + " ";
        }

        return resultString.Trim();
    }

    private static int GetThousandForm(int number)
    {
        number %= 100;

        if ((number >= 11) && (number <= 19))
        {
            return 3;
        }

        int lastDigit = number % 10;

        if (lastDigit == 1)
        {
            return 1;
        }
        else if (lastDigit >= 2 && lastDigit <= 4)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}