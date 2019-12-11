using System;
using System.Collections.Generic;
using Park.Models;


class Program
{
    static void Main()
    {
        List<Animal> Animals = new List<Animal>(0);
        Prompt();

        void Prompt()
        {
            Console.WriteLine("Would you like to add an animal? ('y' or 'n')");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                MakeNewAnimal();
            }
        }
        

        void MakeNewAnimal()
    {
    
        Console.WriteLine("What is the animal's species?");
        string spec = Console.ReadLine();
        Console.WriteLine("What is the animal's location?");
        string loca = Console.ReadLine();

        Animal name = new Animal(spec, loca);  
        AddAnimal(name);
        PrintList();
        Prompt();

    }

        void AddAnimal(Animal name)
        {
            Animals.Add(name);
        }

        void PrintList()
        {
            foreach (Animal name in Animals)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(name.GetSpecies() + "--------" + name.GetLocation());

            }
        }
        
        
        
    }
}