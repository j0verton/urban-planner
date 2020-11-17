using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Joeburg = new City("Joeburg", "Billy Jean");
            Building FiveOneTwoEighth = new Building("512 8th Avenue");
            FiveOneTwoEighth.Width = 50;
            FiveOneTwoEighth.Depth = 35;
            FiveOneTwoEighth.Stories = 3;
            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Jeffity Jeff");

            Joeburg.AddABuilding(FiveOneTwoEighth);

            Building OneTwoJeff = new Building("12 Jefferson Avenue");
            OneTwoJeff.Width = 50;
            OneTwoJeff.Depth = 35;
            OneTwoJeff.Stories = 3;
            OneTwoJeff.Construct();
            OneTwoJeff.Purchase("Steve Jeff");
            Joeburg.AddABuilding(OneTwoJeff);

            Building ThreeEightEighteenth = new Building("38 18th Street");
            ThreeEightEighteenth.Width = 50;
            ThreeEightEighteenth.Depth = 35;
            ThreeEightEighteenth.Stories = 3;
            ThreeEightEighteenth.Construct();
            ThreeEightEighteenth.Purchase("Mary Sue");
            Joeburg.AddABuilding(ThreeEightEighteenth);


            Joeburg.PrintCity();
        }
    }
}
