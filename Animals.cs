using System;
using System.Collections.Generic;
namespace Model
{
    class Animal
    {
        private static List<Animal> AnimalsList = new List<Animal>(10);
        private string animalName;
        private string animalType;
        private string location;
        private string lastSeen;
        private DateTime timeCreated;

        public Animal(string name, string type, string lastlLocation, string lastSeenLocation)
        {
            animalName = name;
            animalType = type;
            location = lastlLocation;
            lastSeen = lastSeenLocation;
            timeCreated = DateTime.Now;
        }

        ///////////////////////////////////////////////
        ///////////// LIST get : set /////////////////
        public static void AddToList(Animal animal)
        {
            AnimalsList.Add(animal);
        }

        public static List<Animal> GetList()
        {
            return AnimalsList;
        }

        
//     ////////////////////////////////////////////////
//     //////////// Animal methods ///////////////////

        public string AnimalName { get{return animalName;} set{animalName = value;} }
        public string AnimalType { get{return animalType;} set{animalType = value;} }
        public string Location { get{return location;} set{location = value;} }
        public string LastSeen { get{return lastSeen;} set{lastSeen = value;}  }
        public DateTime TimeCreated { get{return  timeCreated;} }


    }
    
}