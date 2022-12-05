using System;

class Program
{
    static void AddJasmine(CircularLinkedList<char> garland)
    {
        if(garland.GetLength() > 0 && garland.Get(-1) == 'R')
        {
            if(garland.Get(-2) == 'J')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }
        garland.Add('J');
    }

    static void AddGlobeAmaranth(CircularLinkedList<char> garland)
    {
        if(garland.GetLength() > 0 && garland.Get(-1) == 'R')
        {
            if(garland.Get(-2) == 'G')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }

        if(garland.GetLength() > 2)
        {
            if(garland.Get(-1) == 'G' && garland.Get(-2) == 'G' && garland.Get(-3) == 'G')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
            else if(garland.Get(0) == 'G' && garland.Get(1) == 'G' && garland.Get(2) == 'G')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }
        
        garland.Add('G');
    }

    static void AddOrchid(CircularLinkedList<char> garland)
    {
        if(garland.GetLength() > 0 && garland.Get(-1) == 'R')
        {
            if(garland.Get(-2) == 'O')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }
        garland.Add('O');
    }

    static void AddRose(CircularLinkedList<char> garland)
    {
        if(garland.GetLength() == 0)
        {
            Console.WriteLine("Invalid pattern.");
            return;
        }
        else if(garland.GetLength() > 0 && garland.Get(-1) == 'R')
        {
            if(garland.Get(-2) == 'R')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }
        else if(garland.Get(0) == garland.Get(-1))
        {
            Console.WriteLine("Invalid pattern.");
            return;
        }
        garland.Add('R');
    }

    static void InputFlower(CircularLinkedList<char> garland)
    {
        char flower = char.Parse(Console.ReadLine());
        switch(flower)
        {
            case 'J':
                AddJasmine(garland);
                InputFlower(garland);
                break;
            case 'G':
                AddGlobeAmaranth(garland);
                InputFlower(garland);
                break;
            case 'O':
                AddOrchid(garland);
                InputFlower(garland);
                break;
            case 'R':
                AddRose(garland);
                InputFlower(garland);
                break;
            default:
                break;
        }
    }

    static void Main(string[] args)
    {
        CircularLinkedList<char> garland = new CircularLinkedList<char>();
        InputFlower(garland);
        for(int i=0; i<garland.GetLength(); i++)
        {
            Console.Write(garland.Get(i));
        }
    }
}