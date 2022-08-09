using System;

class Program
{
    static void WriteSelect(string[] namesArray)
    {
         for (int i = 0; i < namesArray.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesArray[i] + ", ");
        }
        Console.Write(namesArray.Length + " - " + namesArray[namesArray.Length-1] + ".");
    }
    static void SelectRace()
    {
        string[] namesRace = {"Люди", "Эльфы", "Гномы", "Орки"};
        WriteSelect(namesRace );
        //Console.Write(namesRace.Length + " - " + namesRace[namesRace.Length-1] + ".");
        Console.WriteLine("Укажите вашу рассу, пожалуйста ");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша расса " + namesRace[indexRace-1]);
    }
    static void SelectClass()
    {
        string[] namesClass = {"Разбойник", "Вор", "Мэджик", "Маг"};
        WriteSelect(namesClass );
        Console.WriteLine("Укажите ваш класс, пожалуйста ");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша класс " + namesClass[indexClass-1]);
    }
    static void SelectPol()
    {
        string[] namesPol = {"Мужской", "Женский"};
        WriteSelect(namesPol );
        //Console.Write(namesPol.Length + " - " + namesPol[namesPol.Length-1] + ".");
        Console.WriteLine("Укажите ваш пол, пожалуйста ");
        int indexPol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша класс " + namesPol[indexPol-1]);
    }
    static void Main(string[] args)
    {
        //int[] array = new int[4];
        //int[] numbers = new int[10]{1,2,34,5,6,78};
        //int[] nums = {51,4,5,6,8,9,0,9};
        //nums [4] = 12; // 0 1 2 3
        SelectRace();
        SelectClass();
        SelectPol();
    }
}