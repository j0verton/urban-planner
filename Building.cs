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
            Console.WriteLine(this._address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {this._designer}");
            Console.WriteLine($"Constructed on {this._dateConstructed}");
            Console.WriteLine($"Owned by {this._owner}");
            Console.WriteLine($"{this.Volume} cubic meters of space");
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