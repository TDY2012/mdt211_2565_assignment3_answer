using System;

class Program
{
    static char[] supportFruitArray = new char[]{'L', 'M', 'S'};

    static void InputFruit(Queue<char> conveyor)
    {
        char fruit = char.Parse(Console.ReadLine());
        if(supportFruitArray.Contains(fruit))
        {
            conveyor.Push(fruit);
            InputFruit(conveyor);
        }
    }

    static void ProcessConveyor(Queue<char> conveyor)
    {
        char fruit;
        while(conveyor.GetLength() > 0)
        {
            fruit = conveyor.Pop();
            switch(fruit)
            {
                case 'L':
                    Console.Write(1);
                    conveyor.Push('M');
                    conveyor.Push('M');
                    break;
                case 'M':
                    conveyor.Push('S');
                    conveyor.Push('S');
                    conveyor.Push('S');
                    Console.Write(2);
                    break;
                case 'S':
                    Console.Write(3);
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Queue<char> conveyor = new Queue<char>();
        InputFruit(conveyor);
        ProcessConveyor(conveyor);
    }
}