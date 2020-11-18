using System;
using System.Collections.Generic;

namespace Planner
{
    // Define class here
    public class Building
    {

        private string _designer = "Joe Overton";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void PrintBuilding()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine("");

        }
        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }
    }
















}