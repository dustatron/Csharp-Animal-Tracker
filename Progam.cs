using System;
using System.Collections.Generic;
using Model;

namespace Park
{
  public static class Tracker
  { 
    private static List<Animal> searchResults = new List<Animal>(5);
    public static void Main()
    {
      Animal.AddToList( new Animal("Bunny", "Bunny", "Cage", "Day"));
      Animal.AddToList(new Animal("Randy", "Rat", "parking lot", "night"));
      Animal.AddToList( new Animal("trudy", "goose", "beach", "dawn"));

      Console.WriteLine("Press A to add an animal?");
      Console.WriteLine("Press S to search an animal?");
      Console.WriteLine("Press p to print full list of animals?");
      string userInput = Console.ReadLine().ToLower();

      if (userInput == "a")
      {
          Console.WriteLine("Add animal");
          AddAnimal();
      }
      else if (userInput == "s")
      {
          Console.WriteLine("Search animal");
          SearchForAnimal();
      }
      else if (userInput == "p")
      {
          Console.WriteLine("Print Animals");
          PrintList();
      }
    }

    public static void AddAnimal()
    {
      Console.WriteLine("Enter animal name");
      string animalName = Console.ReadLine();
      Console.WriteLine("Enter animal type");
      string animalKind = Console.ReadLine();
      Console.WriteLine("Enter animal location");
      string animalLocation = Console.ReadLine();
      Console.WriteLine("Enter animal last seen");
      string animalLastSeen = Console.ReadLine();


      Animal animal = new Animal(animalName, animalKind, animalLocation, animalLastSeen);

      System.Console.WriteLine("Count of list = "+Animal.GetList().Count);
      Animal.AddToList(animal);
      Main();
    }

    public static void PrintList()
    {
      foreach (Animal item in Animal.GetList())
      {
        System.Console.WriteLine("- - - - - - - - -");
        System.Console.WriteLine("Name : {0}", item.AnimalName );
        System.Console.WriteLine("Name : {0}", item.AnimalType );
        System.Console.WriteLine("Name : {0}", item.Location );
        System.Console.WriteLine("Name : {0}", item.LastSeen );

        System.Console.WriteLine();
        System.Console.WriteLine("- - - - - - - - -");
          
      }
        Main();
    }

    public static void SearchForAnimal()
    {
      searchResults.Clear();
      Console.WriteLine("Enter animal name");
      string input = Console.ReadLine();

      foreach (var animal in Animal.GetList())
      {
          if(animal.AnimalName.ToLower() == input.ToLower() || animal.AnimalType.ToLower() == input.ToLower() || animal.Location.ToLower() == input.ToLower() || animal.LastSeen.ToLower() == input.ToLower())
          {
            searchResults.Add(animal);
          }
      }

      if(searchResults.Count == 0)
      {
        Console.WriteLine("Sorry... No results.");
        Console.WriteLine("Try Again.");
        Console.WriteLine();
      }

       foreach (Animal item in searchResults)
       {
        Console.WriteLine();
        Console.WriteLine("Animal Name : {0}", item.AnimalName);
        Console.WriteLine("Animal Type : {0}", item.AnimalType);
        Console.WriteLine("Animal Location : {0}", item.Location);
        Console.WriteLine("Animal Last Seen : {0}", item.LastSeen);
        Console.WriteLine("Date Added : {0}", item.TimeCreated);
        System.Console.WriteLine(" - - - - - - - - - - - - - -");   
        System.Console.WriteLine();

       }
       Main();

    }

  } 
}