﻿class LowerOrUpper
{
    static void Main()
    {
        char input = char.Parse(Console.ReadLine());

        if (char.IsLower(input))
        {
            Console.WriteLine("lower-case");
        } else
        {
            Console.WriteLine("upper-case");
        }
    }
}