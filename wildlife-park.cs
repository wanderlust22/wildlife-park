using System;

namespace Park.Models {
     class Animal 
     {
        private string _species;
        private string _location;

        public Animal(string species, string location)
        {
            _species = species;
            _location = location;
        }

        public string GetSpecies()
        {
            return _species;
        }

        public string GetLocation()
        {
            return _location;
        }

       public void SetAnimal(string newSpecies, string newLocation)
       {
           _species = newSpecies;
           _location = newLocation;
       }

       public void SetLocation(string newLocation)
       {
           _location = newLocation;
       }
    }
}