using System;
using System.Collections.Generic;

namespace Planner
{
    // Define class here
    public class City
    {
        private string _name;

        private string _mayor;

        private DateTime _dateEstabished;

        public List<Building> Buildings { get; set; } = new List<Building>();

        public void AddABuilding(Building building)
        {
            this.Buildings.Add(building);
        }

        public City(string name, string mayor)
        {
            _name = name;
            _mayor = mayor;
            _dateEstabished = DateTime.Now;
        }

        public void PrintCity()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Welcome to {this._name}");
            Console.WriteLine($"Enjoy the Premium Architecture");
            Console.WriteLine("---------------");
            Console.WriteLine("");
            foreach (Building building in this.Buildings)
            {
                building.PrintBuilding();
            }
        }
    }
}